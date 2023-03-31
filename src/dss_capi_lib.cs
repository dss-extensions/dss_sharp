
// dss_sharp: A compatibility layer for DSS C-API that mimics the official OpenDSS COM interface.
// Copyright (c) 2016-2023 Paulo Meira
// Copyright (c) 2018-2023 DSS Extensions contributors
//
// See LICENSE for more information.
//
// NOTE: This file is partially generated from other files. If you would like to contribute 
//       a patch or suggestion, please open an issue ticket on:
//       https://github.com/dss-extensions/dss_sharp/issues/

using System;
using System.Runtime.InteropServices;

namespace dss_sharp
{
    namespace native
    {
        /// <summary>
        /// The DSS_CAPI static class exposes DSS C-API functions to C#.
        /// DSS C-API is the library from DSS Extensions that implements the 
        /// (customized, not supported by EPRI, etc.) OpenDSS engine and wraps
        /// it in easily consumable C-compatible functions.
        ///
        /// Some functions in this class are not exposed through the traditional
        /// API classes, but advanced users are free to use them.
        /// </summary>
        public static class DSS_CAPI
        {
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_GetGRPointers(
                IntPtr ctx,
                ref IntPtr deprecated_1,
                ref IntPtr float64_data_ptr,
                ref IntPtr int32_data_ptr,
                ref IntPtr int8_data_ptr,
                ref IntPtr deprecated_2,
                ref IntPtr float64_count_ptr,
                ref IntPtr int32_count_ptr,
                ref IntPtr int8_count_ptr
            );

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Batch_ToJSON(IntPtr[] batch, int batchSize, int options);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr DSS_BeginPascalThread(IntPtr /* void */ func, IntPtr /* void */ paramptr);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_Dispose_PByte(ref IntPtr /* int8_t* */ p);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_Dispose_PDouble(ref IntPtr /* double* */ p);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_Dispose_PInteger(ref IntPtr /* int32_t* */ p);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_Dispose_PPAnsiChar(ref IntPtr /* char** */ p, int cnt);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_Dispose_String([param: MarshalAs(UnmanagedType.LPUTF8Str)] string S);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_Dispose_String([param: MarshalAs(UnmanagedType.LPStr)] string S);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr DSS_ExtractSchema(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr DSS_Get_PAnsiChar(IntPtr /* void */ p, int index);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_SetMessagesMO([param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_SetMessagesMO([param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_SetPropertiesMO([param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_SetPropertiesMO([param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void DSS_WaitPascalThread(IntPtr /* void */ handle);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetAsString(IntPtr /* void */ obj, int Index);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetClassIdx(IntPtr /* void */ obj);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetClassName(IntPtr /* void */ obj);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetHandleByIdx(IntPtr /* void */ ctx, int ClsIdx, int Idx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetHandleByName(IntPtr /* void */ ctx, int ClsIdx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Name);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetHandleByName(IntPtr /* void */ ctx, int ClsIdx, [param: MarshalAs(UnmanagedType.LPStr)] string Name);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetName(IntPtr /* void */ obj);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetObject(IntPtr /* void */ obj, int Index);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int[] Obj_GetPropSeqPtr(IntPtr /* void */ obj);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_GetString(IntPtr /* void */ obj, int Index);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_New(IntPtr /* void */ ctx, int ClsIdx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Name, ushort Activate, ushort BeginEdit);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_New(IntPtr /* void */ ctx, int ClsIdx, [param: MarshalAs(UnmanagedType.LPStr)] string Name, ushort Activate, ushort BeginEdit);
            #endif

            public static IntPtr Obj_New(IntPtr /* void */ ctx, int ClsIdx, string Name, bool Activate, bool BeginEdit)
            {
                return Obj_New(ctx, ClsIdx, Name, (ushort) (Activate ? 1u : 0u), (ushort) (BeginEdit ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr Obj_ToJSON(IntPtr /* void */ obj, int options);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_ActiveClass_Get_ActiveClassName(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_ActiveClass_Get_ActiveClassParent(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ActiveClass_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ActiveClass_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_ActiveClass_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_ActiveClass_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_ActiveClass_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_ActiveClass_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_ActiveClass_Get_NumElements(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ActiveClass_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ActiveClass_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_ActiveClass_ToJSON(IntPtr /* void */ ctx, int options);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Bus_GetUniqueNodeNumber(IntPtr /* void */ ctx, int StartNumber);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_AllPCEatBus(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_AllPDEatBus(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Bus_Get_Coorddefined(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_CplxSeqVoltages(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_CplxSeqVoltages_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_Cust_Duration(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_Cust_Interrupts(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_Distance(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_Int_Duration(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Isc(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Isc_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_Lambda(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_LineList(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_LineList_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_LoadList(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_LoadList_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Bus_Get_N_Customers(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_N_interrupts(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Bus_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Bus_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Nodes(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Nodes_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Bus_Get_NumNodes(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Bus_Get_SectionID(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_SeqVoltages(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_SeqVoltages_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_TotalMiles(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_VLL(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_VLL_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_VMagAngle(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_VMagAngle_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Voc(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Voc_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Voltages(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Voltages_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_YscMatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_YscMatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_ZSC012Matrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_ZSC012Matrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Zsc0(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Zsc0_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Zsc1(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_Zsc1_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_ZscMatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_ZscMatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_kVBase(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_puVLL(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_puVLL_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_puVmagAngle(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_puVmagAngle_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_puVoltages(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Get_puVoltages_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_x(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Bus_Get_y(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Set_x(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Bus_Set_y(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Bus_ZscRefresh(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CNData_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_DiaCable(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_DiaIns(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_DiaStrand(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_Diameter(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_EmergAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_EpsR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CNData_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CNData_Get_GMRUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_GMRac(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_GmrStrand(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_InsLayer(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CNData_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CNData_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_NormAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_RStrand(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_Rac(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_Radius(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CNData_Get_RadiusUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CNData_Get_Rdc(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CNData_Get_ResistanceUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CNData_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CNData_Get_k(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_DiaCable(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_DiaIns(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_DiaStrand(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_Diameter(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_EmergAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_EpsR(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_GMRUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_GMRac(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_GmrStrand(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_InsLayer(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_NormAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_RStrand(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_Rac(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_Radius(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_RadiusUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_Rdc(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_ResistanceUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CNData_Set_k(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_CTratio(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CapControls_Get_Capacitor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CapControls_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_DeadTime(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_Delay(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_DelayOff(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CapControls_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CapControls_Get_Mode(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CapControls_Get_MonitoredObj(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CapControls_Get_MonitoredTerm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CapControls_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CapControls_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_OFFSetting(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_ONSetting(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_PTratio(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_CapControls_Get_UseVoltOverride(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_Vmax(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CapControls_Get_Vmin(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CapControls_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_CTratio(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_Capacitor(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_Capacitor(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_DeadTime(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_Delay(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_DelayOff(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_Mode(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_MonitoredObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_MonitoredObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_MonitoredTerm(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_OFFSetting(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_ONSetting(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_PTratio(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_UseVoltOverride(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_CapControls_Set_UseVoltOverride(IntPtr /* void */ ctx, bool Value)
            {
                ctx_CapControls_Set_UseVoltOverride(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_Vmax(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_Vmin(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CapControls_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Capacitors_AddStep(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Close(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Capacitors_Get_AvailableSteps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Capacitors_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Capacitors_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Capacitors_Get_IsDelta(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Capacitors_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Capacitors_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Capacitors_Get_NumSteps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Get_States(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Get_States_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Capacitors_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Capacitors_Get_kV(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Capacitors_Get_kvar(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Open(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Set_IsDelta(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Capacitors_Set_IsDelta(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Capacitors_Set_IsDelta(ctx, (ushort) (Value ? 1u : 0u));
            }

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Set_NumSteps(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Set_States(IntPtr /* void */ ctx, int[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Set_kV(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Capacitors_Set_kvar(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Capacitors_SubtractStep(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Circuit_Capacity(IntPtr /* void */ ctx, double Start, double Increment);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Disable(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Name);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Disable(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Name);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Enable(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Name);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Enable(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Name);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_EndOfTimeStepUpdate(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_FirstElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_FirstPCElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_FirstPDElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusDistances(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusDistances_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusVmag(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusVmagPu(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusVmagPu_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusVmag_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusVolts(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllBusVolts_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllElementLosses(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllElementLosses_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllElementNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllElementNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeDistances(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeDistancesByPhase(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, int Phase);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeDistancesByPhase_GR(IntPtr /* void */ ctx, int Phase);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeDistances_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeNamesByPhase(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount, int Phase);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeNamesByPhase_GR(IntPtr /* void */ ctx, int Phase);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeVmagByPhase(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, int Phase);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeVmagByPhase_GR(IntPtr /* void */ ctx, int Phase);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeVmagPUByPhase(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, int Phase);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_AllNodeVmagPUByPhase_GR(IntPtr /* void */ ctx, int Phase);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_ElementLosses(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, int[] ElementsPtr, int ElementsCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_ElementLosses_GR(IntPtr /* void */ ctx, int[] ElementsPtr, int ElementsCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_LineLosses(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_LineLosses_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_Losses(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_Losses_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Circuit_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_Get_NumBuses(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_Get_NumCktElements(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_Get_NumNodes(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_Get_ParentPDElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_SubstationLosses(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_SubstationLosses_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_SystemY(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_SystemY_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_TotalPower(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_TotalPower_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_YCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_YCurrents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_YNodeOrder(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_YNodeOrder_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_YNodeVarray(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Get_YNodeVarray_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_NextElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_NextPCElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_NextPDElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_Sample(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_SaveSample(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_SetActiveBus(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string BusName);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_SetActiveBus(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string BusName);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_SetActiveBusi(IntPtr /* void */ ctx, int BusIndex);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_SetActiveClass(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string ClassName);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_SetActiveClass(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string ClassName);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_SetActiveElement(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string FullName);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Circuit_SetActiveElement(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string FullName);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_SetCktElementIndex(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_SetCktElementName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_SetCktElementName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Circuit_UpdateStorage(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Close(IntPtr /* void */ ctx, int Term, int Phs);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_AllPropertyNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_AllPropertyNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_AllVariableNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_AllVariableNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_AllVariableValues(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_AllVariableValues_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_BusNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_BusNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CktElement_Get_Controller(IntPtr /* void */ ctx, int idx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_CplxSeqCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_CplxSeqCurrents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_CplxSeqVoltages(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_CplxSeqVoltages_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Currents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_CurrentsMagAng(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_CurrentsMagAng_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Currents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CktElement_Get_DisplayName(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CktElement_Get_EmergAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_CktElement_Get_Enabled(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CktElement_Get_EnergyMeter(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CktElement_Get_GUID(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_Handle(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_CktElement_Get_HasOCPDevice(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_CktElement_Get_HasSwitchControl(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_CktElement_Get_HasVoltControl(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_CktElement_Get_IsIsolated(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Losses(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Losses_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CktElement_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_NodeOrder(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_NodeOrder_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_NodeRef(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_NodeRef_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CktElement_Get_NormalAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_NumConductors(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_NumControls(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_NumPhases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_NumProperties(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_NumTerminals(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_OCPDevIndex(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_OCPDevType(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_PhaseLosses(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_PhaseLosses_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Powers(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Powers_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Residuals(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Residuals_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_SeqCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_SeqCurrents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_SeqPowers(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_SeqPowers_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_SeqVoltages(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_SeqVoltages_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_TotalPowers(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_TotalPowers_GR(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CktElement_Get_Variable(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string MyVarName, ref int Code);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CktElement_Get_Variable(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string MyVarName, ref int Code);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CktElement_Get_VariableIdx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_CktElement_Get_VariableName(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CktElement_Get_VariableValue(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_CktElement_Get_Variablei(IntPtr /* void */ ctx, int Idx, ref int Code);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Voltages(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_VoltagesMagAng(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_VoltagesMagAng_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Voltages_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Yprim(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Get_Yprim_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_CktElement_IsOpen(IntPtr /* void */ ctx, int Term, int Phs);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Open(IntPtr /* void */ ctx, int Term, int Phs);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_BusNames(IntPtr /* void */ ctx, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPUTF8Str)] string[] ValuePtr, int ValueCount);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_BusNames(IntPtr /* void */ ctx, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] ValuePtr, int ValueCount);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_DisplayName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_DisplayName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_EmergAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_Enabled(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_CktElement_Set_Enabled(IntPtr /* void */ ctx, bool Value)
            {
                ctx_CktElement_Set_Enabled(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_NormalAmps(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_Variable(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string MyVarName, ref int Code, double Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_Variable(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string MyVarName, ref int Code, double Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_VariableIdx(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_VariableName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_VariableName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_VariableValue(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CktElement_Set_Variablei(IntPtr /* void */ ctx, int Idx, ref int Code, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CtrlQueue_ClearActions(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CtrlQueue_ClearQueue(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CtrlQueue_Delete(IntPtr /* void */ ctx, int ActionHandle);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CtrlQueue_DoAllQueue(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CtrlQueue_Get_ActionCode(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CtrlQueue_Get_DeviceHandle(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CtrlQueue_Get_NumActions(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CtrlQueue_Get_PopAction(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CtrlQueue_Get_Queue(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CtrlQueue_Get_QueueSize(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CtrlQueue_Get_Queue_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_CtrlQueue_Push(IntPtr /* void */ ctx, int Hour, double Seconds, int ActionCode, int DeviceHandle);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CtrlQueue_Set_Action(IntPtr /* void */ ctx, int Param1);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_CtrlQueue_Show(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSElement_Get_AllPropertyNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSElement_Get_AllPropertyNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSSElement_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_DSSElement_Get_NumProperties(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSSElement_ToJSON(IntPtr /* void */ ctx, int options);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProgress_Close(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProgress_Set_Caption(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProgress_Set_Caption(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProgress_Set_PctProgress(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProgress_Show(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSSProperty_Get_Description(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSSProperty_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSSProperty_Get_Val(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProperty_Set_Index(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProperty_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProperty_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProperty_Set_Val(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSProperty_Set_Val(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_ClearAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_DisposeGRData(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_Executive_Get_Command(IntPtr /* void */ ctx, int i);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_Executive_Get_CommandHelp(IntPtr /* void */ ctx, int i);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_DSS_Executive_Get_NumCommands(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_DSS_Executive_Get_NumOptions(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_Executive_Get_Option(IntPtr /* void */ ctx, int i);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_Executive_Get_OptionHelp(IntPtr /* void */ ctx, int i);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_Executive_Get_OptionValue(IntPtr /* void */ ctx, int i);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_GR_CountPtr_PByte(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_GR_CountPtr_PDouble(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_GR_CountPtr_PInteger(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_GR_DataPtr_PByte(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_GR_DataPtr_PDouble(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_GR_DataPtr_PInteger(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_DSS_Get_AllowChangeDir(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_DSS_Get_AllowDOScmd(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_DSS_Get_AllowEditor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_DSS_Get_AllowForms(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_DSS_Get_COMErrorResults(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Get_Classes(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Get_Classes_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern uint ctx_DSS_Get_CompatFlags(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_Get_DataPath(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_Get_DefaultEditor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_DSS_Get_EnableArrayDimensions(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_DSS_Get_LegacyModels(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_DSS_Get_NumCircuits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_DSS_Get_NumClasses(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_DSS_Get_NumUserClasses(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Get_UserClasses(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Get_UserClasses_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_DSS_Get_Version(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_NewCircuit(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_NewCircuit(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_ResetStringBuffer(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_DSS_SetActiveClass(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string ClassName);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_DSS_SetActiveClass(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string ClassName);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_AllowChangeDir(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_DSS_Set_AllowChangeDir(IntPtr /* void */ ctx, bool Value)
            {
                ctx_DSS_Set_AllowChangeDir(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_AllowDOScmd(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_DSS_Set_AllowDOScmd(IntPtr /* void */ ctx, bool Value)
            {
                ctx_DSS_Set_AllowDOScmd(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_AllowEditor(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_DSS_Set_AllowEditor(IntPtr /* void */ ctx, bool Value)
            {
                ctx_DSS_Set_AllowEditor(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_AllowForms(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_DSS_Set_AllowForms(IntPtr /* void */ ctx, bool Value)
            {
                ctx_DSS_Set_AllowForms(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_COMErrorResults(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_DSS_Set_COMErrorResults(IntPtr /* void */ ctx, bool Value)
            {
                ctx_DSS_Set_COMErrorResults(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_CompatFlags(IntPtr /* void */ ctx, uint Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_DataPath(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_DataPath(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_EnableArrayDimensions(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_DSS_Set_EnableArrayDimensions(IntPtr /* void */ ctx, bool Value)
            {
                ctx_DSS_Set_EnableArrayDimensions(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSS_Set_LegacyModels(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_DSS_Set_LegacyModels(IntPtr /* void */ ctx, bool Value)
            {
                ctx_DSS_Set_LegacyModels(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_DSS_Start(IntPtr /* void */ ctx, int code);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSimComs_BusVoltage(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, ulong Index);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSimComs_BusVoltage_GR(IntPtr /* void */ ctx, ulong Index);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSimComs_BusVoltagepu(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, ulong Index);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_DSSimComs_BusVoltagepu_GR(IntPtr /* void */ ctx, ulong Index);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Dispose(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Error_Get_Description(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Error_Get_EarlyAbort(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Error_Get_ExtendedErrors(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Error_Get_Number(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Error_Get_NumberPtr(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Error_Set_Description(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Error_Set_Description(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Error_Set_EarlyAbort(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Error_Set_EarlyAbort(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Error_Set_EarlyAbort(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Error_Set_ExtendedErrors(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Error_Set_ExtendedErrors(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Error_Set_ExtendedErrors(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Close(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Fuses_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Fuses_Get_Delay(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Fuses_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Fuses_Get_MonitoredObj(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Fuses_Get_MonitoredTerm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Fuses_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Fuses_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Get_NormalState(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Fuses_Get_NumPhases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Fuses_Get_RatedCurrent(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Get_State(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Fuses_Get_SwitchedObj(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Fuses_Get_SwitchedTerm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Fuses_Get_TCCcurve(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Fuses_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Fuses_IsBlown(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Open(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_Delay(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_MonitoredObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_MonitoredObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_MonitoredTerm(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_NormalState(IntPtr /* void */ ctx, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPUTF8Str)] string[] ValuePtr, int ValueCount);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_NormalState(IntPtr /* void */ ctx, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] ValuePtr, int ValueCount);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_RatedCurrent(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_State(IntPtr /* void */ ctx, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPUTF8Str)] string[] ValuePtr, int ValueCount);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_State(IntPtr /* void */ ctx, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] ValuePtr, int ValueCount);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_SwitchedObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_SwitchedObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_SwitchedTerm(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_TCCcurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_TCCcurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Fuses_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_GICSources_Get_Bus1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_GICSources_Get_Bus2(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_GICSources_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_GICSources_Get_EE(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_GICSources_Get_EN(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_GICSources_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_GICSources_Get_Lat1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_GICSources_Get_Lat2(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_GICSources_Get_Lon1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_GICSources_Get_Lon2(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_GICSources_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_GICSources_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_GICSources_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_GICSources_Get_Volts(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_GICSources_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_EE(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_EN(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_Lat1(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_Lat2(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_Lon1(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_Lon2(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_Phases(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_Volts(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_GICSources_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Generators_Get_Bus1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Generators_Get_Class_(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Generators_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Generators_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Generators_Get_ForcedON(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Generators_Get_IsDelta(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Generators_Get_Model(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Generators_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Generators_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Generators_Get_PF(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Generators_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Get_RegisterNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Get_RegisterNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Get_RegisterValues(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Get_RegisterValues_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Generators_Get_Status(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Generators_Get_Vmaxpu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Generators_Get_Vminpu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Generators_Get_Yearly(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Generators_Get_daily(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Generators_Get_duty(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Generators_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Generators_Get_kV(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Generators_Get_kVArated(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Generators_Get_kW(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Generators_Get_kva(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Generators_Get_kvar(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Bus1(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Bus1(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Class_(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_ForcedON(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Generators_Set_ForcedON(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Generators_Set_ForcedON(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_IsDelta(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Generators_Set_IsDelta(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Generators_Set_IsDelta(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Model(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_PF(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Phases(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Status(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Vmaxpu(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Vminpu(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Yearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_Yearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_daily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_daily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_duty(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_duty(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_kV(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_kVArated(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_kW(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_kva(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Generators_Set_kvar(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Get_Prime();

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ISources_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ISources_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_ISources_Get_Amps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_ISources_Get_AngleDeg(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_ISources_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_ISources_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_ISources_Get_Frequency(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_ISources_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_ISources_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_ISources_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ISources_Set_Amps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ISources_Set_AngleDeg(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ISources_Set_Frequency(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ISources_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ISources_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ISources_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineCodes_Get_C0(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineCodes_Get_C1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Get_Cmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Get_Cmatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineCodes_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineCodes_Get_EmergAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineCodes_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_LineCodes_Get_IsZ1Z0(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_LineCodes_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineCodes_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineCodes_Get_NormAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineCodes_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineCodes_Get_R0(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineCodes_Get_R1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Get_Rmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Get_Rmatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineCodes_Get_Units(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineCodes_Get_X0(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineCodes_Get_X1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Get_Xmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Get_Xmatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineCodes_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_C0(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_C1(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_Cmatrix(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_EmergAmps(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_NormAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_Phases(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_R0(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_R1(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_Rmatrix(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_Units(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_X0(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_X1(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_Xmatrix(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineCodes_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Cmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, double Frequency, double Length, int Units);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Cmatrix_GR(IntPtr /* void */ ctx, double Frequency, double Length, int Units);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Conductors(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Conductors_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineGeometries_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineGeometries_Get_EmergAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineGeometries_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_LineGeometries_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineGeometries_Get_Nconds(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineGeometries_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineGeometries_Get_NormAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineGeometries_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_LineGeometries_Get_Reduce(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LineGeometries_Get_RhoEarth(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Rmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, double Frequency, double Length, int Units);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Rmatrix_GR(IntPtr /* void */ ctx, double Frequency, double Length, int Units);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Units(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Units_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Xcoords(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Xcoords_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Xmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, double Frequency, double Length, int Units);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Xmatrix_GR(IntPtr /* void */ ctx, double Frequency, double Length, int Units);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Ycoords(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Ycoords_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Zmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, double Frequency, double Length, int Units);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Get_Zmatrix_GR(IntPtr /* void */ ctx, double Frequency, double Length, int Units);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineGeometries_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_EmergAmps(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_Nconds(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_NormAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_Phases(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_Reduce(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_LineGeometries_Set_Reduce(IntPtr /* void */ ctx, bool Value)
            {
                ctx_LineGeometries_Set_Reduce(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_RhoEarth(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_Units(IntPtr /* void */ ctx, int[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_Xcoords(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_Ycoords(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineGeometries_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineSpacings_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineSpacings_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_LineSpacings_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineSpacings_Get_Nconds(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineSpacings_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineSpacings_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineSpacings_Get_Units(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Get_Xcoords(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Get_Xcoords_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Get_Ycoords(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Get_Ycoords_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LineSpacings_Get_idx(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Set_Nconds(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Set_Phases(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Set_Units(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Set_Xcoords(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Set_Ycoords(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LineSpacings_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Lines_Get_Bus1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Lines_Get_Bus2(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_C0(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_C1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_Cmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_Cmatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_EmergAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Lines_Get_Geometry(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Lines_Get_IsSwitch(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_Length(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Lines_Get_LineCode(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Lines_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_NormAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_NumCust(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_Parent(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_R0(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_R1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_Rg(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_Rho(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_Rmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_Rmatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_SeasonRating(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Lines_Get_Spacing(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_TotalCust(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_Units(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_X0(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_X1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Lines_Get_Xg(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_Xmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_Xmatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_Yprim(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Get_Yprim_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_Get_idx(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_New(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Name);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Lines_New(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Name);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Bus1(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Bus1(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Bus2(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Bus2(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_C0(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_C1(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Cmatrix(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_EmergAmps(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Geometry(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Geometry(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_IsSwitch(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Lines_Set_IsSwitch(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Lines_Set_IsSwitch(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Length(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_LineCode(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_LineCode(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_NormAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Phases(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_R0(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_R1(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Rg(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Rho(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Rmatrix(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Spacing(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Spacing(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Units(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_X0(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_X1(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Xg(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Xmatrix(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_Yprim(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Lines_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LoadShapes_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LoadShapes_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LoadShapes_Get_HrInterval(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LoadShapes_Get_MaxP(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LoadShapes_Get_MaxQ(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LoadShapes_Get_MinInterval(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_LoadShapes_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LoadShapes_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LoadShapes_Get_Npts(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LoadShapes_Get_PBase(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Get_Pmult(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Get_Pmult_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LoadShapes_Get_Qbase(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Get_Qmult(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Get_Qmult_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_LoadShapes_Get_SInterval(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Get_TimeArray(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Get_TimeArray_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_LoadShapes_Get_UseActual(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LoadShapes_Get_idx(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LoadShapes_New(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Name);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_LoadShapes_New(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Name);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Normalize(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_HrInterval(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_MaxP(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_MaxQ(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_MinInterval(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_Npts(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_PBase(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_Pmult(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_Points(IntPtr /* void */ ctx, int Npts, IntPtr /* void */ HoursPtr, IntPtr /* void */ PMultPtr, IntPtr /* void */ QMultPtr, ushort ExternalMemory, ushort IsFloat32, int Stride);

            public static void ctx_LoadShapes_Set_Points(IntPtr /* void */ ctx, int Npts, IntPtr /* void */ HoursPtr, IntPtr /* void */ PMultPtr, IntPtr /* void */ QMultPtr, bool ExternalMemory, bool IsFloat32, int Stride)
            {
                ctx_LoadShapes_Set_Points(ctx, Npts, HoursPtr, PMultPtr, QMultPtr, (ushort) (ExternalMemory ? 1u : 0u), (ushort) (IsFloat32 ? 1u : 0u), Stride);
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_Qbase(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_Qmult(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_SInterval(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_TimeArray(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_UseActual(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_LoadShapes_Set_UseActual(IntPtr /* void */ ctx, bool Value)
            {
                ctx_LoadShapes_Set_UseActual(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_UseFloat32(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_LoadShapes_UseFloat64(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_AllocationFactor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Loads_Get_CVRcurve(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_CVRvars(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_CVRwatts(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_Cfactor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_Class_(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Loads_Get_Growth(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Loads_Get_IsDelta(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_Model(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Loads_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_NumCust(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_PF(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_PctMean(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_PctStdDev(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_RelWeight(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_Rneut(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Loads_Get_Sensor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Loads_Get_Spectrum(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_Status(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_Vmaxpu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_Vminemerg(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_Vminnorm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_Vminpu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_Xneut(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Loads_Get_Yearly(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Get_ZIPV(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Get_ZIPV_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Loads_Get_daily(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Loads_Get_duty(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Loads_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_kV(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_kW(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_kva(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_kvar(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_kwh(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_kwhdays(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_pctSeriesRL(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Loads_Get_xfkVA(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_AllocationFactor(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_CVRcurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_CVRcurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_CVRvars(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_CVRwatts(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Cfactor(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Class_(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Growth(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Growth(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_IsDelta(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Loads_Set_IsDelta(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Loads_Set_IsDelta(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Model(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_NumCust(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_PF(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_PctMean(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_PctStdDev(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Phases(IntPtr /* void */ ctx, int Integer);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_RelWeight(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Rneut(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Spectrum(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Spectrum(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Status(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Vmaxpu(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Vminemerg(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Vminnorm(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Vminpu(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Xneut(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Yearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_Yearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_ZIPV(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_daily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_daily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_duty(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_duty(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_kV(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_kW(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_kva(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_kvar(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_kwh(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_kwhdays(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_pctSeriesRL(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Loads_Set_xfkVA(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_CloseAllDIFiles(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_DoReliabilityCalc(IntPtr /* void */ ctx, ushort AssumeRestoration);

            public static void ctx_Meters_DoReliabilityCalc(IntPtr /* void */ ctx, bool AssumeRestoration)
            {
                ctx_Meters_DoReliabilityCalc(ctx, (ushort) (AssumeRestoration ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_AllBranchesInZone(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_AllBranchesInZone_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_AllEndElements(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_AllEndElements_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_AllocFactors(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_AllocFactors_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Meters_Get_AvgRepairTime(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_CalcCurrent(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_CalcCurrent_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_CountBranches(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_CountEndElements(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Meters_Get_CustInterrupts(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Meters_Get_DIFilesAreOpen(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Meters_Get_FaultRateXRepairHrs(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Meters_Get_MeteredElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_MeteredTerminal(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Meters_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_NumSectionBranches(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_NumSectionCustomers(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_NumSections(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_OCPDeviceType(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_Peakcurrent(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_Peakcurrent_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_RegisterNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_RegisterNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_RegisterValues(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_RegisterValues_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Meters_Get_SAIDI(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Meters_Get_SAIFI(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Meters_Get_SAIFIKW(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_SectSeqIdx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_SectTotalCust(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_SeqListSize(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_SequenceIndex(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Meters_Get_SumBranchFltRates(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_TotalCustomers(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_Totals(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_Totals_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Get_ZonePCE(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Meters_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_OpenAllDIFiles(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_ResetAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Sample(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_SampleAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Save(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_SaveAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_SetActiveSection(IntPtr /* void */ ctx, int SectIdx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_AllocFactors(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_CalcCurrent(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_MeteredElement(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_MeteredElement(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_MeteredTerminal(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_Peakcurrent(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_SequenceIndex(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Meters_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_ByteStream(IntPtr /* void */ ctx, ref IntPtr /* int8_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_ByteStream_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_Channel(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, int Index);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_Channel_GR(IntPtr /* void */ ctx, int Index);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Monitors_Get_Element(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Monitors_Get_FileName(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_FileVersion(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_Header(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_Header_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_Mode(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Monitors_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_NumChannels(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_RecordSize(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_SampleCount(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_Terminal(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_dblFreq(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_dblFreq_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_dblHour(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Get_dblHour_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Monitors_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Process(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_ProcessAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_ResetAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Sample(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_SampleAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Save(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_SaveAll(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Set_Element(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Set_Element(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Set_Mode(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Set_Terminal(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Monitors_Show(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_New();

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PDElements_Get_AccumulatedL(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllCplxSeqCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllCplxSeqCurrents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllCurrentsMagAng(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllCurrentsMagAng_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllCurrents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllMaxCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, ushort AllNodes);

            public static void ctx_PDElements_Get_AllMaxCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, bool AllNodes)
            {
                ctx_PDElements_Get_AllMaxCurrents(ctx, ref ResultPtr, ResultCount, (ushort) (AllNodes ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllMaxCurrents_GR(IntPtr /* void */ ctx, ushort AllNodes);

            public static void ctx_PDElements_Get_AllMaxCurrents_GR(IntPtr /* void */ ctx, bool AllNodes)
            {
                ctx_PDElements_Get_AllMaxCurrents_GR(ctx, (ushort) (AllNodes ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllNumConductors(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllNumConductors_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllNumPhases(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllNumPhases_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllNumTerminals(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllNumTerminals_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllPctEmerg(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, ushort AllNodes);

            public static void ctx_PDElements_Get_AllPctEmerg(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, bool AllNodes)
            {
                ctx_PDElements_Get_AllPctEmerg(ctx, ref ResultPtr, ResultCount, (ushort) (AllNodes ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllPctEmerg_GR(IntPtr /* void */ ctx, ushort AllNodes);

            public static void ctx_PDElements_Get_AllPctEmerg_GR(IntPtr /* void */ ctx, bool AllNodes)
            {
                ctx_PDElements_Get_AllPctEmerg_GR(ctx, (ushort) (AllNodes ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllPctNorm(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, ushort AllNodes);

            public static void ctx_PDElements_Get_AllPctNorm(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, bool AllNodes)
            {
                ctx_PDElements_Get_AllPctNorm(ctx, ref ResultPtr, ResultCount, (ushort) (AllNodes ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllPctNorm_GR(IntPtr /* void */ ctx, ushort AllNodes);

            public static void ctx_PDElements_Get_AllPctNorm_GR(IntPtr /* void */ ctx, bool AllNodes)
            {
                ctx_PDElements_Get_AllPctNorm_GR(ctx, (ushort) (AllNodes ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllPowers(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllPowers_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllSeqCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllSeqCurrents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllSeqPowers(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Get_AllSeqPowers_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PDElements_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PDElements_Get_FaultRate(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PDElements_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PDElements_Get_FromTerminal(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_PDElements_Get_IsShunt(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PDElements_Get_Lambda(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PDElements_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PDElements_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PDElements_Get_Numcustomers(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PDElements_Get_ParentPDElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PDElements_Get_RepairTime(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PDElements_Get_SectionID(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PDElements_Get_TotalMiles(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PDElements_Get_Totalcustomers(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PDElements_Get_pctPermanent(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Set_FaultRate(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Set_RepairTime(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PDElements_Set_pctPermanent(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PVSystems_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PVSystems_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PVSystems_Get_Irradiance(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PVSystems_Get_IrradianceNow(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PVSystems_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PVSystems_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PVSystems_Get_PF(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PVSystems_Get_Pmpp(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Get_RegisterNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Get_RegisterNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Get_RegisterValues(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Get_RegisterValues_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PVSystems_Get_Sensor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PVSystems_Get_Tdaily(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PVSystems_Get_Tduty(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PVSystems_Get_Tyearly(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PVSystems_Get_daily(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PVSystems_Get_duty(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_PVSystems_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PVSystems_Get_kVArated(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PVSystems_Get_kW(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_PVSystems_Get_kvar(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_PVSystems_Get_yearly(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Irradiance(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_PF(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Pmpp(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Tdaily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Tdaily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Tduty(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Tduty(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Tyearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_Tyearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_daily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_daily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_duty(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_duty(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_kVArated(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_kvar(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_yearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_PVSystems_Set_yearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_CreateActor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Parallel_Get_ActiveActor(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Parallel_Get_ActiveParallel(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Parallel_Get_ActorCPU(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Get_ActorProgress(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Get_ActorProgress_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Get_ActorStatus(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Get_ActorStatus_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Parallel_Get_ConcatenateReports(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Parallel_Get_NumCPUs(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Parallel_Get_NumCores(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Parallel_Get_NumOfActors(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Set_ActiveActor(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Set_ActiveParallel(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Set_ActorCPU(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Set_ConcatenateReports(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parallel_Wait(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Parser_Get_AutoIncrement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Parser_Get_BeginQuote(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Parser_Get_CmdString(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Parser_Get_DblValue(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Parser_Get_Delimiters(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Parser_Get_EndQuote(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Parser_Get_IntValue(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Get_Matrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, int ExpectedOrder);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Get_Matrix_GR(IntPtr /* void */ ctx, int ExpectedOrder);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Parser_Get_NextParam(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Parser_Get_StrValue(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Get_SymMatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, int ExpectedOrder);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Get_SymMatrix_GR(IntPtr /* void */ ctx, int ExpectedOrder);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Get_Vector(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount, int ExpectedSize);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Get_Vector_GR(IntPtr /* void */ ctx, int ExpectedSize);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Parser_Get_WhiteSpace(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_ResetDelimiters(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_AutoIncrement(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Parser_Set_AutoIncrement(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Parser_Set_AutoIncrement(ctx, (ushort) (Value ? 1u : 0u));
            }

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_BeginQuote(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_BeginQuote(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_CmdString(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_CmdString(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_Delimiters(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_Delimiters(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_EndQuote(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_EndQuote(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_WhiteSpace(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Parser_Set_WhiteSpace(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Reactors_Get_Bus1(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Reactors_Get_Bus2(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reactors_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reactors_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Reactors_Get_IsDelta(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Reactors_Get_LCurve(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reactors_Get_LmH(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Reactors_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reactors_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Reactors_Get_Parallel(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reactors_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reactors_Get_R(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Reactors_Get_RCurve(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Rmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Rmatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reactors_Get_Rp(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reactors_Get_SpecType(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reactors_Get_X(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Xmatrix(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Xmatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Z(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Z0(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Z0_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Z1(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Z1_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Z2(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Z2_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Get_Z_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reactors_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reactors_Get_kV(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reactors_Get_kvar(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Bus1(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Bus1(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Bus2(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Bus2(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_IsDelta(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Reactors_Set_IsDelta(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Reactors_Set_IsDelta(ctx, (ushort) (Value ? 1u : 0u));
            }

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_LCurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_LCurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_LmH(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Parallel(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Reactors_Set_Parallel(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Reactors_Set_Parallel(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Phases(IntPtr /* void */ ctx, int Integer);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_R(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_RCurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_RCurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Rmatrix(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Rp(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_X(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Xmatrix(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Z(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Z0(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Z1(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_Z2(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_kV(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reactors_Set_kvar(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Close(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reclosers_Get_GroundInst(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reclosers_Get_GroundTrip(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Reclosers_Get_MonitoredObj(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_MonitoredTerm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Reclosers_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_NormalState(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_NumFast(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reclosers_Get_PhaseInst(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Reclosers_Get_PhaseTrip(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Get_RecloseIntervals(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Get_RecloseIntervals_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_Shots(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_State(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Reclosers_Get_SwitchedObj(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_SwitchedTerm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Reclosers_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Open(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_GroundInst(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_GroundTrip(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_MonitoredObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_MonitoredObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_MonitoredTerm(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_NormalState(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_NumFast(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_PhaseInst(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_PhaseTrip(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_Shots(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_State(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_SwitchedObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_SwitchedObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_SwitchedTerm(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Reclosers_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Do1phLaterals(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_DoBranchRemove(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_DoDangling(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_DoDefault(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_DoLoopBreak(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_DoParallelLines(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_DoShortLines(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_DoSwitches(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_ReduceCkt_Get_EditString(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_ReduceCkt_Get_EnergyMeter(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_ReduceCkt_Get_KeepLoad(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_ReduceCkt_Get_StartPDElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_ReduceCkt_Get_Zmag(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_SaveCircuit(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string CktName);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_SaveCircuit(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string CktName);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Set_EditString(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Set_EditString(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Set_EnergyMeter(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Set_EnergyMeter(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Set_KeepLoad(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_ReduceCkt_Set_KeepLoad(IntPtr /* void */ ctx, bool Value)
            {
                ctx_ReduceCkt_Set_KeepLoad(ctx, (ushort) (Value ? 1u : 0u));
            }

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Set_StartPDElement(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Set_StartPDElement(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ReduceCkt_Set_Zmag(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_CTPrimary(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_RegControls_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_Delay(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_RegControls_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_ForwardBand(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_ForwardR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_ForwardVreg(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_ForwardX(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_RegControls_Get_IsInverseTime(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_RegControls_Get_IsReversible(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_RegControls_Get_MaxTapChange(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_RegControls_Get_MonitoredBus(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_RegControls_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_RegControls_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_PTratio(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_ReverseBand(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_ReverseR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_ReverseVreg(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_ReverseX(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_TapDelay(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_RegControls_Get_TapNumber(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_RegControls_Get_TapWinding(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_RegControls_Get_Transformer(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_RegControls_Get_VoltageLimit(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_RegControls_Get_Winding(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_RegControls_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_CTPrimary(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_Delay(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_ForwardBand(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_ForwardR(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_ForwardVreg(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_ForwardX(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_IsInverseTime(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_RegControls_Set_IsInverseTime(IntPtr /* void */ ctx, bool Value)
            {
                ctx_RegControls_Set_IsInverseTime(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_IsReversible(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_RegControls_Set_IsReversible(IntPtr /* void */ ctx, bool Value)
            {
                ctx_RegControls_Set_IsReversible(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_MaxTapChange(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_MonitoredBus(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_MonitoredBus(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_PTratio(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_ReverseBand(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_ReverseR(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_ReverseVreg(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_ReverseX(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_TapDelay(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_TapNumber(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_TapWinding(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_Transformer(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_Transformer(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_VoltageLimit(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_Winding(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_RegControls_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Close(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Relays_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Relays_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Relays_Get_MonitoredObj(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Relays_Get_MonitoredTerm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Relays_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Relays_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Relays_Get_NormalState(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Relays_Get_State(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Relays_Get_SwitchedObj(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Relays_Get_SwitchedTerm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Relays_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Open(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Reset(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_MonitoredObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_MonitoredObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_MonitoredTerm(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_NormalState(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_State(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_SwitchedObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_SwitchedObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_SwitchedTerm(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Relays_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_AllocationFactor(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_AllocationFactor_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Sensors_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_Currents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_Currents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Sensors_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Sensors_Get_IsDelta(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Sensors_Get_MeteredElement(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Sensors_Get_MeteredTerminal(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Sensors_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Sensors_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Sensors_Get_PctError(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Sensors_Get_ReverseDelta(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Sensors_Get_Weight(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Sensors_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_kVARS(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_kVARS_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_kVS(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_kVS_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Sensors_Get_kVbase(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_kWS(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Get_kWS_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_ResetAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_Currents(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_IsDelta(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Sensors_Set_IsDelta(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Sensors_Set_IsDelta(ctx, (ushort) (Value ? 1u : 0u));
            }

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_MeteredElement(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_MeteredElement(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_MeteredTerminal(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_PctError(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_ReverseDelta(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Sensors_Set_ReverseDelta(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Sensors_Set_ReverseDelta(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_Weight(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_kVARS(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_kVS(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_kVbase(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Sensors_Set_kWS(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Set_Prime(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Settings_Get_AllowDuplicates(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Settings_Get_AutoBusList(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Settings_Get_CktModel(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Settings_Get_ControlTrace(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Settings_Get_EmergVmaxpu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Settings_Get_EmergVminpu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Settings_Get_IterateDisabled(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Settings_Get_LoadsTerminalCheck(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Get_LossRegs(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Get_LossRegs_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Settings_Get_LossWeight(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Settings_Get_NormVmaxpu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Settings_Get_NormVminpu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Settings_Get_PriceCurve(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Settings_Get_PriceSignal(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Settings_Get_Trapezoidal(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Get_UEregs(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Get_UEregs_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Settings_Get_UEweight(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Get_VoltageBases(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Get_VoltageBases_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Settings_Get_ZoneLock(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_AllocationFactors(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_AllowDuplicates(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Settings_Set_AllowDuplicates(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Settings_Set_AllowDuplicates(ctx, (ushort) (Value ? 1u : 0u));
            }

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_AutoBusList(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_AutoBusList(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_CktModel(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_ControlTrace(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Settings_Set_ControlTrace(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Settings_Set_ControlTrace(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_EmergVmaxpu(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_EmergVminpu(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_IterateDisabled(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_LoadsTerminalCheck(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Settings_Set_LoadsTerminalCheck(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Settings_Set_LoadsTerminalCheck(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_LossRegs(IntPtr /* void */ ctx, int[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_LossWeight(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_NormVmaxpu(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_NormVminpu(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_PriceCurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_PriceCurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_PriceSignal(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_Trapezoidal(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Settings_Set_Trapezoidal(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Settings_Set_Trapezoidal(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_UEregs(IntPtr /* void */ ctx, int[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_UEweight(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_VoltageBases(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Settings_Set_ZoneLock(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Settings_Set_ZoneLock(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Settings_Set_ZoneLock(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_BuildYMatrix(IntPtr /* void */ ctx, int BuildOption, int AllocateVI);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_CheckControls(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_CheckFaultStatus(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Cleanup(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_DoControlActions(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_FinishTimeStep(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_AddType(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_Algorithm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_BusLevels(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_BusLevels_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_Capkvar(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Solution_Get_ControlActionsDone(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_ControlIterations(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_ControlMode(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Solution_Get_Converged(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Solution_Get_DefaultDaily(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Solution_Get_DefaultYearly(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_EventLog(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_EventLog_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_Frequency(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_GenMult(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_GenPF(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_GenkW(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_Hour(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_IncMatrix(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_IncMatrixCols(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_IncMatrixCols_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_IncMatrixRows(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_IncMatrixRows_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_IncMatrix_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_IntervalHrs(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_Iterations(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Solution_Get_LDCurve(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_Laplacian(IntPtr /* void */ ctx, ref IntPtr /* int32_t* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Get_Laplacian_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_LoadModel(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_LoadMult(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_MaxControlIterations(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_MaxIterations(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_MinIterations(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_Mode(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Solution_Get_ModeID(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_MostIterationsDone(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_Number(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_Process_Time(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_Random(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_Seconds(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_StepSize(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Solution_Get_SystemYChanged(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_Time_of_Step(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_Tolerance(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_Total_Time(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_Totaliterations(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Solution_Get_Year(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_dblHour(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Solution_Get_pctGrowth(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_InitSnap(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_SampleControlDevices(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Sample_DoControlActions(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_AddType(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Algorithm(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Capkvar(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_ControlActionsDone(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Solution_Set_ControlActionsDone(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Solution_Set_ControlActionsDone(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_ControlIterations(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_ControlMode(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Converged(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Solution_Set_Converged(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Solution_Set_Converged(ctx, (ushort) (Value ? 1u : 0u));
            }

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_DefaultDaily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_DefaultDaily(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_DefaultYearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_DefaultYearly(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Frequency(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_GenMult(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_GenPF(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_GenkW(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Hour(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_IntervalHrs(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_LDCurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_LDCurve(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_LoadModel(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_LoadMult(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_MaxControlIterations(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_MaxIterations(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_MinIterations(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Mode(IntPtr /* void */ ctx, int Mode);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Number(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Random(IntPtr /* void */ ctx, int Random);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Seconds(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_StepSize(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_StepsizeHr(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_StepsizeMin(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Tolerance(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Total_Time(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_Year(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_dblHour(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Set_pctGrowth(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_Solve(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_SolveAll(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_SolveDirect(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_SolveNoControl(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_SolvePflow(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_SolvePlusControl(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Solution_SolveSnap(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Storages_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Storages_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Storages_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Storages_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Get_RegisterNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Get_RegisterValues(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Get_RegisterValues_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Storages_Get_State(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Storages_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Storages_Get_puSOC(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Set_State(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Storages_Set_puSOC(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_SwtControls_Get_Action(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_SwtControls_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_SwtControls_Get_Delay(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_SwtControls_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_SwtControls_Get_IsLocked(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_SwtControls_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_SwtControls_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_SwtControls_Get_NormalState(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_SwtControls_Get_State(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_SwtControls_Get_SwitchedObj(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_SwtControls_Get_SwitchedTerm(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_SwtControls_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Reset(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_Action(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_Delay(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_IsLocked(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_SwtControls_Set_IsLocked(IntPtr /* void */ ctx, bool Value)
            {
                ctx_SwtControls_Set_IsLocked(ctx, (ushort) (Value ? 1u : 0u));
            }

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_NormalState(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_State(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_SwitchedObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_SwitchedObj(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_SwitchedTerm(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_SwtControls_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_TSData_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_DiaCable(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_DiaIns(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_DiaShield(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_Diameter(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_EmergAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_EpsR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_TSData_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_TSData_Get_GMRUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_GMRac(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_InsLayer(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_TSData_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_TSData_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_NormAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_Rac(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_Radius(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_TSData_Get_RadiusUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_Rdc(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_TSData_Get_ResistanceUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_TapeLap(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_TSData_Get_TapeLayer(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_TSData_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_DiaCable(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_DiaIns(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_DiaShield(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_Diameter(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_EmergAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_EpsR(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_GMRUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_GMRac(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_InsLayer(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_NormAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_Rac(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_Radius(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_RadiusUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_Rdc(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_ResistanceUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_TapeLap(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_TapeLayer(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_TSData_Set_idx(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Text_CommandArray(IntPtr /* void */ ctx, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPUTF8Str)] string[] ValuePtr, int ValueCount);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Text_CommandArray(IntPtr /* void */ ctx, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr)] string[] ValuePtr, int ValueCount);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Text_CommandBlock(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Text_CommandBlock(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Text_Get_Command(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Text_Get_Result(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Text_Set_Command(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Text_Set_Command(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_ActiveBranch(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_ActiveLevel(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Get_AllIsolatedBranches(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Get_AllIsolatedBranches_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Get_AllIsolatedLoads(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Get_AllIsolatedLoads_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Get_AllLoopedPairs(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Get_AllLoopedPairs_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_BackwardBranch(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Topology_Get_BranchName(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Topology_Get_BusName(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_FirstLoad(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_ForwardBranch(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_LoopedBranch(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_NextLoad(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_NumIsolatedBranches(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_NumIsolatedLoads(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_NumLoops(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Topology_Get_ParallelBranch(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Set_BranchName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Set_BranchName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Set_BusName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Topology_Set_BusName(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_AllLossesByType(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_AllLossesByType_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Transformers_Get_CoreType(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Transformers_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Transformers_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_Transformers_Get_IsDelta(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_LossesByType(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_LossesByType_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_MaxTap(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_MinTap(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Transformers_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Transformers_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Transformers_Get_NumTaps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Transformers_Get_NumWindings(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_R(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_RdcOhms(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_Rneut(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_Tap(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Transformers_Get_Wdg(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_WdgCurrents(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_WdgCurrents_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_WdgVoltages(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Get_WdgVoltages_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Transformers_Get_XfmrCode(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_Xhl(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_Xht(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_Xlt(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_Xneut(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Transformers_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_kV(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Transformers_Get_kVA(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Transformers_Get_strWdgCurrents(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_CoreType(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_IsDelta(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_Transformers_Set_IsDelta(IntPtr /* void */ ctx, bool Value)
            {
                ctx_Transformers_Set_IsDelta(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_MaxTap(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_MinTap(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_NumTaps(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_NumWindings(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_R(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_RdcOhms(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Rneut(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Tap(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Wdg(IntPtr /* void */ ctx, int Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_XfmrCode(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_XfmrCode(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Xhl(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Xht(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Xlt(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_Xneut(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_kV(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Transformers_Set_kVA(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Vsources_Get_AngleDeg(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Vsources_Get_BasekV(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Vsources_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Vsources_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Vsources_Get_Frequency(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_Vsources_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Vsources_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Vsources_Get_Phases(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_Vsources_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_Vsources_Get_pu(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Set_AngleDeg(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Set_BasekV(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Set_Frequency(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Set_Phases(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_Vsources_Set_pu(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_WireData_Get_CapRadius(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_WireData_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_WireData_Get_Diameter(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_WireData_Get_EmergAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_WireData_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_WireData_Get_GMRUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_WireData_Get_GMRac(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_WireData_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_WireData_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_WireData_Get_NormAmps(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_WireData_Get_Rac(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_WireData_Get_Radius(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_WireData_Get_RadiusUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_WireData_Get_Rdc(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_WireData_Get_ResistanceUnits(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_WireData_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_CapRadius(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_Diameter(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_EmergAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_GMRUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_GMRac(IntPtr /* void */ ctx, double Value);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_NormAmps(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_Rac(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_Radius(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_RadiusUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_Rdc(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_ResistanceUnits(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_WireData_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Get_AllNames(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Get_AllNames_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_XYCurves_Get_Count(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_XYCurves_Get_First(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_XYCurves_Get_Name(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_XYCurves_Get_Next(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_XYCurves_Get_Npts(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Get_Xarray(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Get_Xarray_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_XYCurves_Get_Xscale(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_XYCurves_Get_Xshift(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Get_Yarray(IntPtr /* void */ ctx, ref IntPtr /* double* */ ResultPtr, int[] ResultCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Get_Yarray_GR(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_XYCurves_Get_Yscale(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_XYCurves_Get_Yshift(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_XYCurves_Get_idx(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_XYCurves_Get_x(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern double ctx_XYCurves_Get_y(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Value);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Name(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Value);
            #endif

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Npts(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Xarray(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Xscale(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Xshift(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Yarray(IntPtr /* void */ ctx, double[] ValuePtr, int ValueCount);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Yscale(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_Yshift(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_idx(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_x(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_XYCurves_Set_y(IntPtr /* void */ ctx, double Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_AddInAuxCurrents(IntPtr /* void */ ctx, int SType);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_BuildYMatrixD(IntPtr /* void */ ctx, int BuildOps, int AllocateVI);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_YMatrix_CheckConvergence(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_GetCompressedYMatrix(IntPtr /* void */ ctx, ushort factor, ref uint nBus, ref uint nNz, ref IntPtr /* int32_t* */ ColPtr, ref IntPtr /* int32_t* */ RowIdxPtr, ref IntPtr /* double* */ cValsPtr);

            public static void ctx_YMatrix_GetCompressedYMatrix(IntPtr /* void */ ctx, bool factor, ref uint nBus, ref uint nNz, ref IntPtr /* int32_t* */ ColPtr, ref IntPtr /* int32_t* */ RowIdxPtr, ref IntPtr /* double* */ cValsPtr)
            {
                ctx_YMatrix_GetCompressedYMatrix(ctx, (ushort) (factor ? 1u : 0u), ref nBus, ref nNz, ref ColPtr, ref RowIdxPtr, ref cValsPtr);
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_GetPCInjCurr(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_GetSourceInjCurrents(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern IntPtr ctx_YMatrix_Get_Handle(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_YMatrix_Get_Iteration(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_YMatrix_Get_LoadsNeedUpdating(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_YMatrix_Get_SolutionInitialized(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ulong ctx_YMatrix_Get_SolverOptions(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_YMatrix_Get_SystemYChanged(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_YMatrix_Get_UseAuxCurrents(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_SetGeneratordQdV(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_Set_Iteration(IntPtr /* void */ ctx, int Value);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_Set_LoadsNeedUpdating(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_YMatrix_Set_LoadsNeedUpdating(IntPtr /* void */ ctx, bool Value)
            {
                ctx_YMatrix_Set_LoadsNeedUpdating(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_Set_SolutionInitialized(IntPtr /* void */ ctx, ushort Value);

            public static void ctx_YMatrix_Set_SolutionInitialized(IntPtr /* void */ ctx, bool Value)
            {
                ctx_YMatrix_Set_SolutionInitialized(ctx, (ushort) (Value ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_Set_SolverOptions(IntPtr /* void */ ctx, ulong opts);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_Set_SystemYChanged(IntPtr /* void */ ctx, ushort arg);

            public static void ctx_YMatrix_Set_SystemYChanged(IntPtr /* void */ ctx, bool arg)
            {
                ctx_YMatrix_Set_SystemYChanged(ctx, (ushort) (arg ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_Set_UseAuxCurrents(IntPtr /* void */ ctx, ushort arg);

            public static void ctx_YMatrix_Set_UseAuxCurrents(IntPtr /* void */ ctx, bool arg)
            {
                ctx_YMatrix_Set_UseAuxCurrents(ctx, (ushort) (arg ? 1u : 0u));
            }

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern int ctx_YMatrix_SolveSystem(IntPtr /* void */ ctx, ref IntPtr /* double* */ NodeVPtr);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_ZeroInjCurr(IntPtr /* void */ ctx);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_getIpointer(IntPtr /* void */ ctx, ref IntPtr /* double* */ IvectorPtr);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_YMatrix_getVpointer(IntPtr /* void */ ctx, ref IntPtr /* double* */ VvectorPtr);

            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Close(IntPtr /* void */ ctx);

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_ZIP_Contains(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string Name);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern ushort ctx_ZIP_Contains(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string Name);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Extract(IntPtr /* void */ ctx, ref IntPtr /* int8_t* */ ResultPtr, int[] ResultCount, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string FileName);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Extract(IntPtr /* void */ ctx, ref IntPtr /* int8_t* */ ResultPtr, int[] ResultCount, [param: MarshalAs(UnmanagedType.LPStr)] string FileName);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Extract_GR(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string FileName);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Extract_GR(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string FileName);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_List(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string RegExp);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_List(IntPtr /* void */ ctx, ref IntPtr /* char** */ ResultPtr, int[] ResultCount, [param: MarshalAs(UnmanagedType.LPStr)] string RegExp);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Open(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string FileName);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Open(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string FileName);
            #endif

            #if NETSTANDARD2_1_OR_GREATER
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Redirect(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPUTF8Str)] string FileInZip);
            #else
            [DllImport("dss_capi", CallingConvention = CallingConvention.Cdecl)]
            public static extern void ctx_ZIP_Redirect(IntPtr /* void */ ctx, [param: MarshalAs(UnmanagedType.LPStr)] string FileInZip);
            #endif

        }
    }
}
