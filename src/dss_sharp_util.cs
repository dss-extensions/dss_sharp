// dss_sharp: A compatibility layer for DSS C-API that mimics the official OpenDSS COM interface.
// Copyright (c) 2016-2022 Paulo Meira
// Copyright (c) 2018-2022 DSS Extensions contributors
//
// See LICENSE for more information.
//

using System;
using System.IO;
using System.Runtime.InteropServices;
using dss_sharp.native;

namespace dss_sharp
{
    /// <summary>
    /// DSSException encapsulates the error information from the
    /// "DSS.Error" interface.
    /// </summary>
    public class DSSException : Exception
    {
        public int ErrorNumber;

        public DSSException(int number, string message): base(message)
        {
            ErrorNumber = number;
        }
    }

    namespace detail
    {
        /// <summary>
        /// ContextState keeps a copy of the DSS engine instance and
        /// the utility class (APIUtil).
        /// </summary>
        public class ContextState
        {
            protected IntPtr ctx;
            protected APIUtil apiutil;

            protected void CheckForError()
            {
                apiutil.CheckForError();
            }

            public ContextState(APIUtil util)
            {
                apiutil = util;
                ctx = util.ctx;
            }

            /// <summary>
            /// Returns the low-level handle of the current OpenDSS/DSS-CAPI instance.
            /// </summary>
            public IntPtr GetContextHandle()
            {
                return ctx;
            }
        }

        /// <summary>
        /// APIUtil provides some common functions to read data and map errors.
        /// Member names are kept to mirror DSS Python and other projects.
        /// </summary>
        public class APIUtil
        {
            private static bool MOLoaded = false;
            public delegate void StringArrayDelegate1(IntPtr ctx, ref IntPtr resultPtr, int[] resultCount);
            public delegate void StringArrayDelegate2(IntPtr ctx, ref IntPtr resultPtr, int[] resultCount, int param1);
            public delegate void StringArrayDelegate3(IntPtr ctx, ref IntPtr resultPtr, int[] resultCount, string param1);
            public bool ownsCtx;
            public IntPtr ctx;
            public IntPtr errorPtr;
            private IntPtr 
                gr_float64_data, gr_float64_count,
                gr_int32_data, gr_int32_count,
                gr_int8_data, gr_int8_count;

            public APIUtil(IntPtr context, bool ownsContext)
            {
                IntPtr unused1 = IntPtr.Zero;
                IntPtr unused2 = IntPtr.Zero;

                ownsCtx = ownsContext;
                ctx = context;
                errorPtr = DSS_CAPI.ctx_Error_Get_NumberPtr(ctx);
                DSS_CAPI.ctx_DSS_GetGRPointers(
                    ctx,
                    ref unused1,
                    ref gr_float64_data,
                    ref gr_int32_data,
                    ref gr_int8_data,
                    ref unused2,
                    ref gr_float64_count,
                    ref gr_int32_count,
                    ref gr_int8_count
                );

                if (!APIUtil.MOLoaded)
                {
                    var dllPath = new System.Uri(typeof(APIUtil).Assembly.EscapedCodeBase).LocalPath;
                    var moPath = Path.Combine(Path.GetDirectoryName(dllPath), "messages", "properties-en-US.mo");
                    if (File.Exists(moPath))
                    {
                        DSS_CAPI.DSS_SetPropertiesMO(moPath);
                    }
                    APIUtil.MOLoaded = true;
                }
            }

            ~APIUtil()
            {
                if (!ownsCtx) return;
                DSS_CAPI.ctx_Dispose(ctx);
            }
            
            public double[] get_float64_gr_array()
            {
                int cnt = Marshal.ReadInt32(gr_float64_count);
                double[] res = new double[cnt];
                IntPtr actualDataPtr = Marshal.ReadIntPtr(gr_float64_data);
                Marshal.Copy(actualDataPtr, res, 0, cnt);
                return res;
            }

            public int[] get_int32_gr_array()
            {
                int cnt = Marshal.ReadInt32(gr_int32_count);
                int[] res = new int[cnt];
                IntPtr actualDataPtr = Marshal.ReadIntPtr(gr_int32_data);
                Marshal.Copy(actualDataPtr, res, 0, cnt);
                return res;
            }

            public byte[] get_int8_gr_array()
            {
                int cnt = Marshal.ReadInt32(gr_int8_count);
                byte[] res = new byte[cnt];
                IntPtr actualDataPtr = Marshal.ReadIntPtr(gr_int8_data);
                Marshal.Copy(actualDataPtr, res, 0, cnt);
                return res;
            }

            public static string get_string(IntPtr pchar)
            {
    #if NETSTANDARD2_1_OR_GREATER
                return Marshal.PtrToStringUTF8(pchar);
    #else                
                return Marshal.PtrToStringAnsi(pchar);
    #endif                
            }

            public string[] get_string_array(StringArrayDelegate1 fn, bool extra=false, bool empty_to_none=false)
            {
                IntPtr resultPtr = new IntPtr();
                int[] resultCount = new int[2];
                fn(ctx, ref resultPtr, resultCount);
                string[] result = new string[resultCount[0] + (extra ? 1 : 0)];
                for (int i = 0; i < resultCount[0]; ++i)
                {
                    IntPtr resultPtrInternal = Marshal.ReadIntPtr(resultPtr, IntPtr.Size * i);
                    result[i] = get_string(resultPtrInternal);
                }
                if (empty_to_none && (resultCount[0] == 0))
                {
                    result = new string[1];
                    result[0] = "NONE";
                }
                else if (extra)
                {
                    if (resultCount[0] == 0)
                    {
                        result[0] = "None";
                    }
                    else
                    {
                        result[resultCount[0]] = "";
                    }
                }
                DSS_CAPI.DSS_Dispose_PPAnsiChar(ref resultPtr, resultCount[1]);
                return result;
            }

            public string[] get_string_array(StringArrayDelegate2 fn, int param1)
            {
                IntPtr resultPtr = new IntPtr();
                int[] resultCount = new int[2];
                fn(ctx, ref resultPtr, resultCount, param1);
                string[] result = new string[resultCount[0]];
                for (int i = 0; i < resultCount[0]; ++i)
                {
                    IntPtr resultPtrInternal = Marshal.ReadIntPtr(resultPtr, IntPtr.Size * i);
                    result[i] = get_string(resultPtrInternal);
                }
                DSS_CAPI.DSS_Dispose_PPAnsiChar(ref resultPtr, resultCount[1]);
                return result;
            }

            public string[] get_string_array(StringArrayDelegate3 fn, string param1)
            {
                IntPtr resultPtr = new IntPtr();
                int[] resultCount = new int[2];
                fn(ctx, ref resultPtr, resultCount, param1);
                string[] result = new string[resultCount[0]];
                for (int i = 0; i < resultCount[0]; ++i)
                {
                    IntPtr resultPtrInternal = Marshal.ReadIntPtr(resultPtr, IntPtr.Size * i);
                    result[i] = get_string(resultPtrInternal);
                }
                DSS_CAPI.DSS_Dispose_PPAnsiChar(ref resultPtr, resultCount[1]);
                return result;
            }

            public void CheckForError()
            {
                var error_num = Marshal.ReadInt32(errorPtr);
                if (error_num != 0)
                {
                    Marshal.WriteInt32(errorPtr, 0);
                    throw new DSSException(error_num, get_string(DSS_CAPI.ctx_Error_Get_Description(ctx)));
                }
            }
        }
    }
}
