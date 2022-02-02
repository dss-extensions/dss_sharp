
// dss_sharp: A compatibility layer for DSS C-API that mimics the official OpenDSS COM interface.
// Copyright (c) 2016-2022 Paulo Meira
// Copyright (c) 2018-2022 DSS Extensions contributors
//
// See LICENSE for more information.
//
// NOTE: This file is partially generated from other files. If you would like to contribute 
//       a patch // or suggestion, please open a issue ticket on:
//       https://github.com/dss-extensions/dss_sharp/issues/
        
using System;
using System.Runtime.InteropServices;

namespace dss_sharp
{


    public class Bus : ContextState
    {

        public Bus(APIUtil util) : base(util)
        {
        }
    
        public Bus this[int key]
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_SetActiveBusi(ctx, key);
                    return this;
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public Bus this[string key]
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_SetActiveBus(ctx, key);
                    return this;
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns an array with the names of all PCE connected to the active bus
        /// </summary>
        public string[] AllPCEatBus
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Bus_Get_AllPCEatBus, true);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns an array with the names of all PDE connected to the active bus
        /// </summary>
        public string[] AllPDEatBus
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Bus_Get_AllPDEatBus, true);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int GetUniqueNodeNumber(int StartNumber)
        {
            try
            {
                return DSS_CAPI.ctx_Bus_GetUniqueNodeNumber(ctx, StartNumber);
            }
            finally
            {
                CheckForError();
            }
        }

        public bool ZscRefresh()
        {
            try
            {
                return (DSS_CAPI.ctx_Bus_ZscRefresh(ctx) != 0);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// False=0 else True. Indicates whether a coordinate has been defined for this bus
        /// </summary>
        public bool Coorddefined
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Bus_Get_Coorddefined(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex Double array of Sequence Voltages (0, 1, 2) at this Bus.
        /// </summary>
        public double[] CplxSeqVoltages
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_CplxSeqVoltages_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Accumulated customer outage durations
        /// </summary>
        public double Cust_Duration
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_Cust_Duration(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Annual number of customer-interruptions from this bus
        /// </summary>
        public double Cust_Interrupts
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_Cust_Interrupts(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Distance from energymeter (if non-zero)
        /// </summary>
        public double Distance
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_Distance(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Average interruption duration, hr.
        /// </summary>
        public double Int_Duration
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_Int_Duration(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Short circuit currents at bus; Complex Array.
        /// </summary>
        public double[] Isc
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_Isc_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Accumulated failure rate downstream from this bus; faults per year
        /// </summary>
        public double Lambda
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_Lambda(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total numbers of customers served downline from this bus
        /// </summary>
        public int N_Customers
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_N_Customers(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of interruptions this bus per year
        /// </summary>
        public double N_interrupts
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_N_interrupts(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of Bus
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer Array of Node Numbers defined at the bus in same order as the voltages.
        /// </summary>
        public int[] Nodes
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_Nodes_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Nodes this bus.
        /// </summary>
        public int NumNodes
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_NumNodes(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer ID of the feeder section in which this bus is located.
        /// </summary>
        public int SectionID
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_SectionID(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Double Array of sequence voltages at this bus.
        /// </summary>
        public double[] SeqVoltages
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_SeqVoltages_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total length of line downline from this bus, in miles. For recloser siting algorithm.
        /// </summary>
        public double TotalMiles
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_TotalMiles(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// For 2- and 3-phase buses, returns array of complex numbers represetin L-L voltages in volts. Returns -1.0 for 1-phase bus. If more than 3 phases, returns only first 3.
        /// </summary>
        public double[] VLL
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_VLL_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles containing voltages in Magnitude (VLN), angle (deg)
        /// </summary>
        public double[] VMagAngle
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_VMagAngle_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Open circuit voltage; Complex array.
        /// </summary>
        public double[] Voc
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_Voc_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of voltages at this bus.
        /// </summary>
        public double[] Voltages
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_Voltages_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of Ysc matrix at bus. Column by column.
        /// </summary>
        public double[] YscMatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_YscMatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex Zero-Sequence short circuit impedance at bus.
        /// </summary>
        public double[] Zsc0
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_Zsc0_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex Positive-Sequence short circuit impedance at bus..
        /// </summary>
        public double[] Zsc1
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_Zsc1_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of Zsc matrix at bus. Column by column.
        /// </summary>
        public double[] ZscMatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_ZscMatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Base voltage at bus in kV
        /// </summary>
        public double kVBase
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_kVBase(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns Complex array of pu L-L voltages for 2- and 3-phase buses. Returns -1.0 for 1-phase bus. If more than 3 phases, returns only 3 phases.
        /// </summary>
        public double[] puVLL
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_puVLL_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles containig voltage magnitude, angle pairs in per unit
        /// </summary>
        public double[] puVmagAngle
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_puVmagAngle_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex Array of pu voltages at the bus.
        /// </summary>
        public double[] puVoltages
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_puVoltages_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// X Coordinate for bus (double)
        /// </summary>
        public double x
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_x(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Set_x(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Y coordinate for bus(double)
        /// </summary>
        public double y
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Bus_Get_y(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Set_y(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// List of strings: Full Names of LOAD elements connected to the active bus.
        /// </summary>
        public string[] LoadList
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Bus_Get_LoadList);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// List of strings: Full Names of LINE elements connected to the active bus.
        /// </summary>
        public string[] LineList
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Bus_Get_LineList);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

    }

    public class CNData : ContextState
    {

        public CNData(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all CNData names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_CNData_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of CNData objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first CNData active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active CNData by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next CNData active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active CNData by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Emergency ampere rating
        /// </summary>
        public double EmergAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_EmergAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_EmergAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Normal Ampere rating
        /// </summary>
        public double NormAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_NormAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_NormAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Rdc
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_Rdc(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_Rdc(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Rac
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_Rac(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_Rac(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double GMRac
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_GMRac(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_GMRac(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int GMRUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_GMRUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_GMRUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Radius
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_Radius(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_Radius(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int RadiusUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_RadiusUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_RadiusUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int ResistanceUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_ResistanceUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_ResistanceUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Diameter
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_Diameter(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_Diameter(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double EpsR
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_EpsR(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_EpsR(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double InsLayer
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_InsLayer(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_InsLayer(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double DiaIns
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_DiaIns(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_DiaIns(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double DiaCable
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_DiaCable(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_DiaCable(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int k
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_k(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_k(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double DiaStrand
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_DiaStrand(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_DiaStrand(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double GmrStrand
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_GmrStrand(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_GmrStrand(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double RStrand
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CNData_Get_RStrand(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CNData_Set_RStrand(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Capacitors : ContextState
    {

        public Capacitors(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Capacitor names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Capacitors_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Capacitor objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Capacitor active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Capacitor by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Capacitors_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Capacitor active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Capacitor by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Capacitors_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public bool AddStep()
        {
            try
            {
                return (DSS_CAPI.ctx_Capacitors_AddStep(ctx) != 0);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Close()
        {
            try
            {
                DSS_CAPI.ctx_Capacitors_Close(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Open()
        {
            try
            {
                DSS_CAPI.ctx_Capacitors_Open(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public bool SubtractStep()
        {
            try
            {
                return (DSS_CAPI.ctx_Capacitors_SubtractStep(ctx) != 0);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Number of Steps available in cap bank to be switched ON.
        /// </summary>
        public int AvailableSteps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_AvailableSteps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Delta connection or wye?
        /// </summary>
        public bool IsDelta
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Capacitors_Get_IsDelta(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Capacitors_Set_IsDelta(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of steps (default 1) for distributing and switching the total bank kVAR.
        /// </summary>
        public int NumSteps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_NumSteps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Capacitors_Set_NumSteps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// A array of  integer [0..numsteps-1] indicating state of each step. If the read value is -1 an error has occurred.
        /// </summary>
        public int[] States
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Capacitors_Get_States_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Capacitors_Set_States(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Bank kV rating. Use LL for 2 or 3 phases, or actual can rating for 1 phase.
        /// </summary>
        public double kV
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_kV(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Capacitors_Set_kV(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total bank KVAR, distributed equally among phases and steps.
        /// </summary>
        public double kvar
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Capacitors_Get_kvar(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Capacitors_Set_kvar(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class CktElement : ContextState
    {
        public DSSProperty Properties;

        public CktElement(APIUtil util) : base(util)
        {
            Properties = new DSSProperty(util);
        }
    
        /// <summary>
        /// Value as return and error code in Code parameter. For PCElement, get the value of a variable by name. If Code>0 then no variable by this name or not a PCelement.
        /// </summary>
        public double Variable(string MyVarName, ref int Code)
        {
            try
            {
                return DSS_CAPI.ctx_CktElement_Get_Variable(ctx, MyVarName, ref Code);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Value as return and error code in Code parameter. For PCElement, get the value of a variable by integer index. If Code>0 then no variable by this index or not a PCelement.
        /// </summary>
        public double Variablei(int Idx, ref int Code)
        {
            try
            {
                return DSS_CAPI.ctx_CktElement_Get_Variablei(ctx, Idx, ref Code);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Close(int Term, int Phs)
        {
            try
            {
                DSS_CAPI.ctx_CktElement_Close(ctx, Term, Phs);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Full name of the i-th controller attached to this element. Ex: str = Controller(2).  See NumControls to determine valid index range
        /// </summary>
        public string Controller(int idx)
        {
            try
            {
                return DSS_CAPI.ctx_CktElement_Get_Controller(ctx, idx);
            }
            finally
            {
                CheckForError();
            }
        }

        public bool IsOpen(int Term, int Phs)
        {
            try
            {
                return (DSS_CAPI.ctx_CktElement_IsOpen(ctx, Term, Phs) != 0);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Open(int Term, int Phs)
        {
            try
            {
                DSS_CAPI.ctx_CktElement_Open(ctx, Term, Phs);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Array containing all property names of the active device.
        /// </summary>
        public string[] AllPropertyNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_CktElement_Get_AllPropertyNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings listing all the published variable names, if a PCElement. Otherwise, null string.
        /// </summary>
        public string[] AllVariableNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_CktElement_Get_AllVariableNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles. Values of state variables of active element if PC element.
        /// </summary>
        public double[] AllVariableValues
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_AllVariableValues_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings. Get  Bus definitions to which each terminal is connected. 0-based array.
        /// </summary>
        public string[] BusNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_CktElement_Get_BusNames);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Set_BusNames(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex double array of Sequence Currents for all conductors of all terminals of active circuit element.
        /// </summary>
        public double[] CplxSeqCurrents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_CplxSeqCurrents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex double array of Sequence Voltage for all terminals of active circuit element.
        /// </summary>
        public double[] CplxSeqVoltages
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_CplxSeqVoltages_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of currents into each conductor of each terminal
        /// </summary>
        public double[] Currents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_Currents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Currents in magnitude, angle format as a array of doubles.
        /// </summary>
        public double[] CurrentsMagAng
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_CurrentsMagAng_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Display name of the object (not necessarily unique)
        /// </summary>
        public string DisplayName
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_DisplayName(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Set_DisplayName(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Emergency Ampere Rating for PD elements
        /// </summary>
        public double EmergAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_EmergAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Set_EmergAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Boolean indicating that element is currently in the circuit.
        /// </summary>
        public bool Enabled
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_CktElement_Get_Enabled(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Set_Enabled(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the Energy Meter this element is assigned to.
        /// </summary>
        public string EnergyMeter
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_EnergyMeter(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// globally unique identifier for this object
        /// </summary>
        public string GUID
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_GUID(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Pointer to this object
        /// </summary>
        public int Handle
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_Handle(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// True if a recloser, relay, or fuse controlling this ckt element. OCP = Overcurrent Protection
        /// </summary>
        public bool HasOCPDevice
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_CktElement_Get_HasOCPDevice(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// This element has a SwtControl attached.
        /// </summary>
        public bool HasSwitchControl
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_CktElement_Get_HasSwitchControl(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// This element has a CapControl or RegControl attached.
        /// </summary>
        public bool HasVoltControl
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_CktElement_Get_HasVoltControl(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total losses in the element: two-element complex array
        /// </summary>
        public double[] Losses
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_Losses_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full Name of Active Circuit Element
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of integer containing the node numbers (representing phases, for example) for each conductor of each terminal.
        /// </summary>
        public int[] NodeOrder
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_NodeOrder_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Normal ampere rating for PD Elements
        /// </summary>
        public double NormalAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_NormalAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Set_NormalAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Conductors per Terminal
        /// </summary>
        public int NumConductors
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_NumConductors(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of controls connected to this device. 
        /// Use to determine valid range for index into Controller array.
        /// </summary>
        public int NumControls
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_NumControls(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Phases
        /// </summary>
        public int NumPhases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_NumPhases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Properties this Circuit Element.
        /// </summary>
        public int NumProperties
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_NumProperties(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Terminals this Circuit Element
        /// </summary>
        public int NumTerminals
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_NumTerminals(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Index into Controller list of OCP Device controlling this CktElement
        /// </summary>
        public int OCPDevIndex
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_OCPDevIndex(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// 0=None; 1=Fuse; 2=Recloser; 3=Relay;  Type of OCP controller device
        /// </summary>
        public int OCPDevType
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CktElement_Get_OCPDevType(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of losses by phase
        /// </summary>
        public double[] PhaseLosses
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_PhaseLosses_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of powers into each conductor of each terminal
        /// </summary>
        public double[] Powers
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_Powers_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Residual currents for each terminal: (mag, angle)
        /// </summary>
        public double[] Residuals
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_Residuals_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Double array of symmetrical component currents into each 3-phase terminal
        /// </summary>
        public double[] SeqCurrents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_SeqCurrents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Double array of sequence powers into each 3-phase teminal
        /// </summary>
        public double[] SeqPowers
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_SeqPowers_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Double array of symmetrical component voltages at each 3-phase terminal
        /// </summary>
        public double[] SeqVoltages
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_SeqVoltages_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of voltages at terminals
        /// </summary>
        public double[] Voltages
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_Voltages_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Voltages at each conductor in magnitude, angle form as array of doubles.
        /// </summary>
        public double[] VoltagesMagAng
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_VoltagesMagAng_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// YPrim matrix, column order, complex numbers (paired)
        /// </summary>
        public double[] Yprim
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_Yprim_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns true if the current active element is isolated.
        /// Note that this only fetches the current value. See also the Topology interface.
        /// </summary>
        public bool IsIsolated
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_CktElement_Get_IsIsolated(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns the total powers (complex) at ALL terminals of the active circuit element.
        /// </summary>
        public double[] TotalPowers
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_TotalPowers_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Generators : ContextState
    {

        public Generators(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Generator names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Generators_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Generator objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Generator active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Generator by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Generator active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Generator by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Indicates whether the generator is forced ON regardles of other dispatch criteria.
        /// </summary>
        public bool ForcedON
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Generators_Get_ForcedON(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_ForcedON(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Generator Model
        /// </summary>
        public int Model
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_Model(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Model(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Power factor (pos. = producing vars). Updates kvar based on present kW value.
        /// </summary>
        public double PF
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_PF(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_PF(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of phases
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of Names of all generator energy meter registers
        /// </summary>
        public string[] RegisterNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Generators_Get_RegisterNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of valus in generator energy meter registers.
        /// </summary>
        public double[] RegisterValues
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Get_RegisterValues_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Vmaxpu for generator model
        /// </summary>
        public double Vmaxpu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_Vmaxpu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Vmaxpu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Vminpu for Generator model
        /// </summary>
        public double Vminpu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_Vminpu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Vminpu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Voltage base for the active generator, kV
        /// </summary>
        public double kV
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_kV(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_kV(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// kVA rating of the generator
        /// </summary>
        public double kVArated
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_kVArated(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_kVArated(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// kW output for the active generator. kvar is updated for current power factor.
        /// </summary>
        public double kW
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_kW(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_kW(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// kvar output for the active generator. Updates power factor based on present kW value.
        /// </summary>
        public double kvar
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_kvar(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_kvar(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Lines : ContextState
    {

        public Lines(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Line names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Lines_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Line objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Line active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Line by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Line active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Line by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public int New(string Name)
        {
            try
            {
                return DSS_CAPI.ctx_Lines_New(ctx, Name);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Name of bus for terminal 1.
        /// </summary>
        public string Bus1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Bus1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Bus1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of bus for terminal 2.
        /// </summary>
        public string Bus2
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Bus2(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Bus2(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Zero Sequence capacitance, nanofarads per unit length.
        /// </summary>
        public double C0
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_C0(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_C0(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Positive Sequence capacitance, nanofarads per unit length.
        /// </summary>
        public double C1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_C1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_C1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double[] Cmatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Get_Cmatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Cmatrix(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Emergency (maximum) ampere rating of Line.
        /// </summary>
        public double EmergAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_EmergAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_EmergAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Line geometry code
        /// </summary>
        public string Geometry
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Geometry(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Geometry(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Length of line section in units compatible with the LineCode definition.
        /// </summary>
        public double Length
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Length(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Length(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of LineCode object that defines the impedances.
        /// </summary>
        public string LineCode
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_LineCode(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_LineCode(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Normal ampere rating of Line.
        /// </summary>
        public double NormAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_NormAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_NormAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of customers on this line section.
        /// </summary>
        public int NumCust
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_NumCust(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets Parent of the active Line to be the active line. Returns 0 if no parent or action fails.
        /// </summary>
        public int Parent
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Parent(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Phases, this Line element.
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Zero Sequence resistance, ohms per unit length.
        /// </summary>
        public double R0
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_R0(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_R0(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Positive Sequence resistance, ohms per unit length.
        /// </summary>
        public double R1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_R1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_R1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Earth return resistance value used to compute line impedances at power frequency
        /// </summary>
        public double Rg
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Rg(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Rg(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Earth Resistivity, m-ohms
        /// </summary>
        public double Rho
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Rho(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Rho(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Resistance matrix (full), ohms per unit length. Array of doubles.
        /// </summary>
        public double[] Rmatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Get_Rmatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Rmatrix(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Line spacing code
        /// </summary>
        public string Spacing
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Spacing(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Spacing(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total Number of customers served from this line section.
        /// </summary>
        public int TotalCust
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_TotalCust(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int Units
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Units(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Units(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Zero Sequence reactance ohms per unit length.
        /// </summary>
        public double X0
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_X0(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_X0(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Positive Sequence reactance, ohms per unit length.
        /// </summary>
        public double X1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_X1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_X1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Earth return reactance value used to compute line impedances at power frequency
        /// </summary>
        public double Xg
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_Xg(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Xg(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double[] Xmatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Get_Xmatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Xmatrix(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Yprimitive: Does Nothing at present on Put; Dangerous
        /// </summary>
        public double[] Yprim
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Get_Yprim_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_Yprim(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Delivers the rating for the current season (in Amps)  if the "SeasonalRatings" option is active
        /// </summary>
        public double SeasonRating
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Lines_Get_SeasonRating(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets/gets the Line element switch status. Setting it has side-effects to the line parameters.
        /// </summary>
        public bool IsSwitch
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Lines_Get_IsSwitch(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Lines_Set_IsSwitch(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Settings : ContextState
    {

        public Settings(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// {True | False*} Designates whether to allow duplicate names of objects
        /// </summary>
        public bool AllowDuplicates
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Settings_Get_AllowDuplicates(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_AllowDuplicates(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// List of Buses or (File=xxxx) syntax for the AutoAdd solution mode.
        /// </summary>
        public string AutoBusList
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_AutoBusList(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_AutoBusList(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// {dssMultiphase * | dssPositiveSeq} IIndicate if the circuit model is positive sequence.
        /// </summary>
        public int CktModel
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_CktModel(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_CktModel(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// {True | False*} Denotes whether to trace the control actions to a file.
        /// </summary>
        public bool ControlTrace
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Settings_Get_ControlTrace(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_ControlTrace(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Per Unit maximum voltage for Emergency conditions.
        /// </summary>
        public double EmergVmaxpu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_EmergVmaxpu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_EmergVmaxpu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Per Unit minimum voltage for Emergency conditions.
        /// </summary>
        public double EmergVminpu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_EmergVminpu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_EmergVminpu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer array defining which energy meter registers to use for computing losses
        /// </summary>
        public int[] LossRegs
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Get_LossRegs_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_LossRegs(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Weighting factor applied to Loss register values.
        /// </summary>
        public double LossWeight
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_LossWeight(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_LossWeight(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Per Unit maximum voltage for Normal conditions.
        /// </summary>
        public double NormVmaxpu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_NormVmaxpu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_NormVmaxpu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Per Unit minimum voltage for Normal conditions.
        /// </summary>
        public double NormVminpu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_NormVminpu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_NormVminpu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of LoadShape object that serves as the source of price signal data for yearly simulations, etc.
        /// </summary>
        public string PriceCurve
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_PriceCurve(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_PriceCurve(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Price Signal for the Circuit
        /// </summary>
        public double PriceSignal
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_PriceSignal(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_PriceSignal(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// {True | False *} Gets value of trapezoidal integration flag in energy meters.
        /// </summary>
        public bool Trapezoidal
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Settings_Get_Trapezoidal(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_Trapezoidal(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of Integers defining energy meter registers to use for computing UE
        /// </summary>
        public int[] UEregs
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Get_UEregs_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_UEregs(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Weighting factor applied to UE register values.
        /// </summary>
        public double UEweight
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_UEweight(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_UEweight(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles defining the legal voltage bases in kV L-L
        /// </summary>
        public double[] VoltageBases
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Get_VoltageBases_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_VoltageBases(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// {True | False*}  Locks Zones on energy meters to prevent rebuilding if a circuit change occurs.
        /// </summary>
        public bool ZoneLock
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Settings_Get_ZoneLock(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_ZoneLock(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// (write-only) Sets all load allocation factors for all loads defined by XFKVA property to this value.
        /// </summary>
        public double AllocationFactors
        {
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_AllocationFactors(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Controls whether the terminals are checked when updating the currents in Load component. Defaults to True.
        /// If the loads are guaranteed to have their terminals closed throughout the simulation, this can be set to False to save some time.
        /// 
        /// (API Extension)
        /// </summary>
        public bool LoadsTerminalCheck
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Settings_Get_LoadsTerminalCheck(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_LoadsTerminalCheck(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class ActiveClass : ContextState
    {

        public ActiveClass(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Returns name of active class.
        /// </summary>
        public string ActiveClassName
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ActiveClass_Get_ActiveClassName(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings consisting of all element names in the active class.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_ActiveClass_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of elements in Active Class. Same as NumElements Property.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ActiveClass_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets first element in the active class to be the active DSS object. If object is a CktElement, ActiveCktELment also points to this element. Returns 0 if none.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ActiveClass_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the Active Element of the Active Class
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ActiveClass_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ActiveClass_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets next element in active class to be the active DSS object. If object is a CktElement, ActiveCktElement also points to this element.  Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ActiveClass_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of elements in this class. Same as Count property.
        /// </summary>
        public int NumElements
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ActiveClass_Get_NumElements(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get the name of the parent class of the active class
        /// </summary>
        public string ActiveClassParent
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ActiveClass_Get_ActiveClassParent(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class CapControls : ContextState
    {

        public CapControls(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all CapControl names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_CapControls_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of CapControl objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first CapControl active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active CapControl by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next CapControl active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active CapControl by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_CapControls_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Transducer ratio from pirmary current to control current.
        /// </summary>
        public double CTratio
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_CTratio(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_CTratio(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the Capacitor that is controlled.
        /// </summary>
        public string Capacitor
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_Capacitor(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_Capacitor(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double DeadTime
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_DeadTime(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_DeadTime(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time delay [s] to switch on after arming.  Control may reset before actually switching.
        /// </summary>
        public double Delay
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_Delay(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_Delay(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time delay [s] before swithcing off a step. Control may reset before actually switching.
        /// </summary>
        public double DelayOff
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_DelayOff(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_DelayOff(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Type of automatic controller.
        /// </summary>
        public int Mode
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_Mode(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_Mode(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of the element that PT and CT are connected to.
        /// </summary>
        public string MonitoredObj
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_MonitoredObj(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_MonitoredObj(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Terminal number on the element that PT and CT are connected to.
        /// </summary>
        public int MonitoredTerm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_MonitoredTerm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_MonitoredTerm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Threshold to switch off a step. See Mode for units.
        /// </summary>
        public double OFFSetting
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_OFFSetting(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_OFFSetting(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Threshold to arm or switch on a step.  See Mode for units.
        /// </summary>
        public double ONSetting
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_ONSetting(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_ONSetting(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Transducer ratio from primary feeder to control voltage.
        /// </summary>
        public double PTratio
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_PTratio(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_PTratio(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Enables Vmin and Vmax to override the control Mode
        /// </summary>
        public bool UseVoltOverride
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_CapControls_Get_UseVoltOverride(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_UseVoltOverride(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// With VoltOverride, swtich off whenever PT voltage exceeds this level.
        /// </summary>
        public double Vmax
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_Vmax(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_Vmax(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// With VoltOverride, switch ON whenever PT voltage drops below this level.
        /// </summary>
        public double Vmin
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CapControls_Get_Vmin(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_Vmin(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Circuit : ContextState
    {
        public Bus Buses;
        public CktElement CktElements;
        public CktElement ActiveElement;
        public Solution Solution;
        public Bus ActiveBus;
        public Generators Generators;
        public Meters Meters;
        public Monitors Monitors;
        public Settings Settings;
        public Lines Lines;
        public CtrlQueue CtrlQueue;
        public Loads Loads;
        public CktElement ActiveCktElement;
        public DSSElement ActiveDSSElement;
        public ActiveClass ActiveClass;
        public CapControls CapControls;
        public RegControls RegControls;
        public SwtControls SwtControls;
        public Transformers Transformers;
        public Capacitors Capacitors;
        public Topology Topology;
        public Sensors Sensors;
        public XYCurves XYCurves;
        public PDElements PDElements;
        public Reclosers Reclosers;
        public Relays Relays;
        public LoadShapes LoadShapes;
        public Fuses Fuses;
        public ISources Isources;
        public DSSimComs DSSim_Coms;
        public PVSystems PVSystems;
        public Vsources Vsources;
        public LineCodes LineCodes;
        public LineGeometries LineGeometries;
        public LineSpacings LineSpacings;
        public WireData WireData;
        public CNData CNData;
        public TSData TSData;
        public Reactors Reactors;
        public ReduceCkt ReduceCkt;

        public Circuit(APIUtil util) : base(util)
        {
            Buses = new Bus(util);
            CktElements = new CktElement(util);
            ActiveElement = new CktElement(util);
            Solution = new Solution(util);
            ActiveBus = new Bus(util);
            Generators = new Generators(util);
            Meters = new Meters(util);
            Monitors = new Monitors(util);
            Settings = new Settings(util);
            Lines = new Lines(util);
            CtrlQueue = new CtrlQueue(util);
            Loads = new Loads(util);
            ActiveCktElement = new CktElement(util);
            ActiveDSSElement = new DSSElement(util);
            ActiveClass = new ActiveClass(util);
            CapControls = new CapControls(util);
            RegControls = new RegControls(util);
            SwtControls = new SwtControls(util);
            Transformers = new Transformers(util);
            Capacitors = new Capacitors(util);
            Topology = new Topology(util);
            Sensors = new Sensors(util);
            XYCurves = new XYCurves(util);
            PDElements = new PDElements(util);
            Reclosers = new Reclosers(util);
            Relays = new Relays(util);
            LoadShapes = new LoadShapes(util);
            Fuses = new Fuses(util);
            Isources = new ISources(util);
            DSSim_Coms = new DSSimComs(util);
            PVSystems = new PVSystems(util);
            Vsources = new Vsources(util);
            LineCodes = new LineCodes(util);
            LineGeometries = new LineGeometries(util);
            LineSpacings = new LineSpacings(util);
            WireData = new WireData(util);
            CNData = new CNData(util);
            TSData = new TSData(util);
            Reactors = new Reactors(util);
            ReduceCkt = new ReduceCkt(util);
        }
    
        /// <summary>
        /// Activates and returns a bus by its (zero-based) index.
        /// </summary>
        public Bus get_Buses(int idx)
        {
            try
            {
                if (DSS_CAPI.ctx_Circuit_SetActiveBusi(ctx, idx) < 0)
                    return null;

                return this.ActiveBus;
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Activates and returns a bus by its name.
        /// </summary>
        public Bus get_Buses(string name)
        {
            try
            {
                if (DSS_CAPI.ctx_Circuit_SetActiveBus(ctx, Name) < 0)
                    return null;

                return this.ActiveBus;
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Activates and returns a CktElement by its global (zero-based) index.
        /// </summary>
        public CktElement get_CktElements(int idx)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_SetCktElementIndex(ctx, idx);
                return this.ActiveCktElement;
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Activates and returns a CktElement by its full name (e.g. "load.abc").
        /// </summary>
        public CktElement get_CktElements(string fullName)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_SetCktElementName(ctx, fullName);
                return this.ActiveCktElement;
            }
            finally
            {
                CheckForError();
            }
        }

        public double Capacity(double Start, double Increment)
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_Capacity(ctx, Start, Increment);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Disable(string Name)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_Disable(ctx, Name);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Enable(string Name)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_Enable(ctx, Name);
            }
            finally
            {
                CheckForError();
            }
        }

        public void EndOfTimeStepUpdate()
        {
            try
            {
                DSS_CAPI.ctx_Circuit_EndOfTimeStepUpdate(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public int FirstElement()
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_FirstElement(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public int FirstPCElement()
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_FirstPCElement(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public int FirstPDElement()
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_FirstPDElement(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Returns an array of doubles representing the distances to parent EnergyMeter. Sequence of array corresponds to other node ByPhase properties.
        /// </summary>
        public double[] AllNodeDistancesByPhase(int Phase)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_Get_AllNodeDistancesByPhase_GR(ctx, Phase);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Return array of strings of the node names for the By Phase criteria. Sequence corresponds to other ByPhase properties.
        /// </summary>
        public string[] AllNodeNamesByPhase(int Phase)
        {
            try
            {
                return apiutil.get_string_array(DSS_CAPI.ctx_Circuit_Get_AllNodeNamesByPhase, Phase);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Returns Array of doubles represent voltage magnitudes for nodes on the specified phase.
        /// </summary>
        public double[] AllNodeVmagByPhase(int Phase)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_Get_AllNodeVmagByPhase_GR(ctx, Phase);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Returns array of per unit voltage magnitudes for each node by phase
        /// </summary>
        public double[] AllNodeVmagPUByPhase(int Phase)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_Get_AllNodeVmagPUByPhase_GR(ctx, Phase);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        public int NextElement()
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_NextElement(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public int NextPCElement()
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_NextPCElement(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public int NextPDElement()
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_NextPDElement(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Sample()
        {
            try
            {
                DSS_CAPI.ctx_Circuit_Sample(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SaveSample()
        {
            try
            {
                DSS_CAPI.ctx_Circuit_SaveSample(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public int SetActiveBus(string BusName)
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_SetActiveBus(ctx, BusName);
            }
            finally
            {
                CheckForError();
            }
        }

        public int SetActiveBusi(int BusIndex)
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_SetActiveBusi(ctx, BusIndex);
            }
            finally
            {
                CheckForError();
            }
        }

        public int SetActiveClass(string ClassName)
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_SetActiveClass(ctx, ClassName);
            }
            finally
            {
                CheckForError();
            }
        }

        public int SetActiveElement(string FullName)
        {
            try
            {
                return DSS_CAPI.ctx_Circuit_SetActiveElement(ctx, FullName);
            }
            finally
            {
                CheckForError();
            }
        }

        public void UpdateStorage()
        {
            try
            {
                DSS_CAPI.ctx_Circuit_UpdateStorage(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Returns distance from each bus to parent EnergyMeter. Corresponds to sequence in AllBusNames.
        /// </summary>
        public double[] AllBusDistances
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_AllBusDistances_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings containing names of all buses in circuit (see AllNodeNames).
        /// </summary>
        public string[] AllBusNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Circuit_Get_AllBusNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of magnitudes (doubles) of voltages at all buses
        /// </summary>
        public double[] AllBusVmag
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_AllBusVmag_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Double Array of all bus voltages (each node) magnitudes in Per unit
        /// </summary>
        public double[] AllBusVmagPu
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_AllBusVmagPu_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of all bus, node voltages from most recent solution
        /// </summary>
        public double[] AllBusVolts
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_AllBusVolts_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of total losses (complex) in each circuit element
        /// </summary>
        public double[] AllElementLosses
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_AllElementLosses_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings containing Full Name of all elements.
        /// </summary>
        public string[] AllElementNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Circuit_Get_AllElementNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns an array of distances from parent EnergyMeter for each Node. Corresponds to AllBusVMag sequence.
        /// </summary>
        public double[] AllNodeDistances
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_AllNodeDistances_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings containing full name of each node in system in same order as returned by AllBusVolts, etc.
        /// </summary>
        public string[] AllNodeNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Circuit_Get_AllNodeNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex total line losses in the circuit
        /// </summary>
        public double[] LineLosses
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_LineLosses_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total losses in active circuit, complex number (two-element array of double).
        /// </summary>
        public double[] Losses
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_Losses_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the active circuit.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Circuit_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total number of Buses in the circuit.
        /// </summary>
        public int NumBuses
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Circuit_Get_NumBuses(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of CktElements in the circuit.
        /// </summary>
        public int NumCktElements
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Circuit_Get_NumCktElements(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total number of nodes in the circuit.
        /// </summary>
        public int NumNodes
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Circuit_Get_NumNodes(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets Parent PD element, if any, to be the active circuit element and returns index>0; Returns 0 if it fails or not applicable.
        /// </summary>
        public int ParentPDElement
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Circuit_Get_ParentPDElement(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex losses in all transformers designated to substations.
        /// </summary>
        public double[] SubstationLosses
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_SubstationLosses_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// System Y matrix (after a solution has been performed). 
        /// This is deprecated as it returns a dense matrix. Only use it for small systems.
        /// For large scale systems, prefer YMatrix.GetCompressedYMatrix.
        /// </summary>
        public double[] SystemY
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_SystemY_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total power, kW delivered to the circuit
        /// </summary>
        public double[] TotalPower
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_TotalPower_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles containing complex injection currents for the present solution. Is is the "I" vector of I=YV
        /// </summary>
        public double[] YCurrents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_YCurrents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings containing the names of the nodes in the same order as the Y matrix
        /// </summary>
        public string[] YNodeOrder
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Circuit_Get_YNodeOrder);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of actual node voltages in same order as SystemY matrix.
        /// </summary>
        public double[] YNodeVarray
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Circuit_Get_YNodeVarray_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class CtrlQueue : ContextState
    {

        public CtrlQueue(APIUtil util) : base(util)
        {
        }

        public void ClearActions()
        {
            try
            {
                DSS_CAPI.ctx_CtrlQueue_ClearActions(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void ClearQueue()
        {
            try
            {
                DSS_CAPI.ctx_CtrlQueue_ClearQueue(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Delete(int ActionHandle)
        {
            try
            {
                DSS_CAPI.ctx_CtrlQueue_Delete(ctx, ActionHandle);
            }
            finally
            {
                CheckForError();
            }
        }

        public void DoAllQueue()
        {
            try
            {
                DSS_CAPI.ctx_CtrlQueue_DoAllQueue(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Show()
        {
            try
            {
                DSS_CAPI.ctx_CtrlQueue_Show(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Code for the active action. Long integer code to tell the control device what to do
        /// </summary>
        public int ActionCode
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CtrlQueue_Get_ActionCode(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Handle (User defined) to device that must act on the pending action.
        /// </summary>
        public int DeviceHandle
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CtrlQueue_Get_DeviceHandle(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Actions on the current actionlist (that have been popped off the control queue by CheckControlActions)
        /// </summary>
        public int NumActions
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CtrlQueue_Get_NumActions(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
        /// <summary>
        /// Push a control action onto the DSS control queue by time, action code, and device handle (user defined). Returns Control Queue handle.
        /// </summary>
        public int Push(int Hour, double Seconds, int ActionCode, int DeviceHandle)
        {
            try
            {
                return DSS_CAPI.ctx_CtrlQueue_Push(ctx, Hour, Seconds, ActionCode, DeviceHandle);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Pops next action off the action list and makes it the active action. Returns zero if none.
        /// </summary>
        public int PopAction
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CtrlQueue_Get_PopAction(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings containing the entire queue in CSV format
        /// </summary>
        public string[] Queue
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_CtrlQueue_Get_Queue);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of items on the OpenDSS control Queue
        /// </summary>
        public int QueueSize
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_CtrlQueue_Get_QueueSize(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// (write-only) Set the active action by index
        /// </summary>
        public int Action
        {
            set
            {
                try
                {
                    DSS_CAPI.ctx_CtrlQueue_Set_Action(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class DSS : ContextState
    {
        public Circuit ActiveCircuit;
        public Circuit Circuits;
        public Error Error;
        public Text Text;
        public DSSProgress DSSProgress;
        public ActiveClass ActiveClass;
        public DSS_Executive Executive;
        public DSSEvents Events;
        public Parser Parser;
        public DSSimComs DSSim_Coms;
        public YMatrix YMatrix;

        public DSS(APIUtil util) : base(util)
        {
            ActiveCircuit = new Circuit(util);
            Circuits = new Circuit(util);
            Error = new Error(util);
            Text = new Text(util);
            DSSProgress = new DSSProgress(util);
            ActiveClass = new ActiveClass(util);
            Executive = new DSS_Executive(util);
            Events = new DSSEvents(util);
            Parser = new Parser(util);
            DSSim_Coms = new DSSimComs(util);
            YMatrix = new YMatrix(util);
        }
    

        /// <summary>
        /// Expose DSS without a constructor parameters for backwards compatibility.
        /// This contructors always exposes the prime/default instance of OpenDSS.
        /// </summary>
        public DSS(): this(new APIUtil(DSS_CAPI.ctx_Get_Prime()))
        {
        }

        /// <summary>
        /// Creates a new DSS engine context.
        /// A DSS Context encapsulates most of the global state of the original OpenDSS engine,
        /// allowing the user to create multiple instances in the same process. By creating contexts
        /// manually, the management of threads and potential issues should be handled by the user.
        /// (API Extension)
        /// </summary>
        public DSS NewContext()
        {
            try
            {
                APIUtil new_api_util = new APIUtil(DSS_CAPI.ctx_New());
                return new DSS(new_api_util);
            }
            finally
            {
                CheckForError();
            }
        }

        public void ClearAll()
        {
            try
            {
                DSS_CAPI.ctx_DSS_ClearAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_DSS_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public int SetActiveClass(string ClassName)
        {
            try
            {
                return DSS_CAPI.ctx_DSS_SetActiveClass(ctx, ClassName);
            }
            finally
            {
                CheckForError();
            }
        }

        public bool Start(int code)
        {
            try
            {
                return (DSS_CAPI.ctx_DSS_Start(ctx, code) != 0);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// List of DSS intrinsic classes (names of the classes)
        /// </summary>
        public string[] Classes
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_DSS_Get_Classes);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// DSS Data File Path.  Default path for reports, etc. from DSS
        /// </summary>
        public string DataPath
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSS_Get_DataPath(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSS_Set_DataPath(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns the path name for the default text editor.
        /// </summary>
        public string DefaultEditor
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSS_Get_DefaultEditor(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Circuits currently defined
        /// </summary>
        public int NumCircuits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSS_Get_NumCircuits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of DSS intrinsic classes
        /// </summary>
        public int NumClasses
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSS_Get_NumClasses(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of user-defined classes
        /// </summary>
        public int NumUserClasses
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSS_Get_NumUserClasses(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// List of user-defined classes
        /// </summary>
        public string[] UserClasses
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_DSS_Get_UserClasses);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get version string for the DSS.
        /// </summary>
        public string Version
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSS_Get_Version(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets/sets whether text output is allowed
        /// </summary>
        public bool AllowForms
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_DSS_Get_AllowForms(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSS_Set_AllowForms(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets/sets whether running the external editor for "Show" is allowed
        /// 
        /// AllowEditor controls whether the external editor is used in commands like "Show".
        /// If you set to 0 (false), the editor is not executed. Note that other side effects,
        /// such as the creation of files, are not affected.
        /// </summary>
        public bool AllowEditor
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_DSS_Get_AllowEditor(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSS_Set_AllowEditor(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public void ShowPanel()
        {
            try
            {
                // #warning ("ShowPanel is not implemented.");
            }
            finally
            {
                CheckForError();
            }
        }

        public Circuit NewCircuit(string name)
        {
            try
            {
                DSS_CAPI.ctx_DSS_NewCircuit(ctx, name);
                return ActiveCircuit;
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// If enabled, the legacy/deprecated models for PVSystem, InvControl, Storage and StorageControl are used.
        /// In the official OpenDSS version 9.0, the old models where removed. They are temporarily present here
        /// but may be removed in the near future. If they are important to you, please open an issue on GitHub
        /// or contact the authors from DSS Extensions: https://github.com/dss-extensions/
        /// 
        /// After toggling LegacyModels, run a "clear" command and the models will be loaded accordingly.
        /// Defaults to False. 
        /// 
        /// This can also be enabled by setting the environment variable DSS_CAPI_LEGACY_MODELS to 1.
        /// 
        /// (API Extension)
        /// </summary>
        public bool LegacyModels
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_DSS_Get_LegacyModels(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSS_Set_LegacyModels(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// If disabled, the engine will not change the active working directory during execution. E.g. a "compile"
        /// command will not "chdir" to the file path.
        /// 
        /// If you have issues with long paths, enabling this might help in some scenarios.
        /// 
        /// Defaults to True (allow changes, backwards compatible) in the 0.10.x versions of DSS C-API. 
        /// This might change to False in future versions.
        /// 
        /// This can also be set through the environment variable DSS_CAPI_ALLOW_CHANGE_DIR. Set it to 0 to
        /// disallow changing the active working directory.
        /// 
        /// (API Extension)
        /// </summary>
        public bool AllowChangeDir
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_DSS_Get_AllowChangeDir(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSS_Set_AllowChangeDir(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

    }

    public class DSSElement : ContextState
    {
        public DSSProperty Properties;

        public DSSElement(APIUtil util) : base(util)
        {
            Properties = new DSSProperty(util);
        }

        /// <summary>
        /// Array of strings containing the names of all properties for the active DSS object.
        /// </summary>
        public string[] AllPropertyNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_DSSElement_Get_AllPropertyNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full Name of Active DSS Object (general element or circuit element).
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSSElement_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Properties for the active DSS object.
        /// </summary>
        public int NumProperties
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSSElement_Get_NumProperties(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class DSSProgress : ContextState
    {

        public DSSProgress(APIUtil util) : base(util)
        {
        }

        public void Close()
        {
            try
            {
                DSS_CAPI.ctx_DSSProgress_Close(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Show()
        {
            try
            {
                DSS_CAPI.ctx_DSSProgress_Show(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// (write-only) Caption to appear on the bottom of the DSS Progress form.
        /// </summary>
        public string Caption
        {
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSSProgress_Set_Caption(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// (write-only) Percent progress to indicate [0..100]
        /// </summary>
        public int PctProgress
        {
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSSProgress_Set_PctProgress(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class DSSProperty : ContextState
    {

        public DSSProperty(APIUtil util) : base(util)
        {
        }
    
        public DSSProperty this[int key]
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_DSSProperty_Set_Index(ctx, key);
                    return this;
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public DSSProperty this[string key]
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_DSSProperty_Set_Name(ctx, key);
                    return this;
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Description of the property.
        /// </summary>
        public string Description
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSSProperty_Get_Description(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of Property
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSSProperty_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public string Val
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSSProperty_Get_Val(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSSProperty_Set_Val(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class DSS_Executive : ContextState
    {

        public DSS_Executive(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Get i-th command
        /// </summary>
        public string Command(int i)
        {
            try
            {
                return DSS_CAPI.ctx_DSS_Executive_Get_Command(ctx, i);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get help string for i-th command
        /// </summary>
        public string CommandHelp(int i)
        {
            try
            {
                return DSS_CAPI.ctx_DSS_Executive_Get_CommandHelp(ctx, i);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get i-th option
        /// </summary>
        public string Option(int i)
        {
            try
            {
                return DSS_CAPI.ctx_DSS_Executive_Get_Option(ctx, i);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get help string for i-th option
        /// </summary>
        public string OptionHelp(int i)
        {
            try
            {
                return DSS_CAPI.ctx_DSS_Executive_Get_OptionHelp(ctx, i);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get present value of i-th option
        /// </summary>
        public string OptionValue(int i)
        {
            try
            {
                return DSS_CAPI.ctx_DSS_Executive_Get_OptionValue(ctx, i);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Number of DSS Executive Commands
        /// </summary>
        public int NumCommands
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSS_Executive_Get_NumCommands(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of DSS Executive Options
        /// </summary>
        public int NumOptions
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_DSS_Executive_Get_NumOptions(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class DSSimComs : ContextState
    {

        public DSSimComs(APIUtil util) : base(util)
        {
        }

        public double[] BusVoltage(ulong Index)
        {
            try
            {
                DSS_CAPI.ctx_DSSimComs_BusVoltage_GR(ctx, Index);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        public double[] BusVoltagepu(ulong Index)
        {
            try
            {
                DSS_CAPI.ctx_DSSimComs_BusVoltagepu_GR(ctx, Index);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }
    }

    public class Error : ContextState
    {

        public Error(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Description of error for last operation
        /// </summary>
        public string Description
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Error_Get_Description(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Error Number (returns current value and then resets to zero)
        /// </summary>
        public int Number
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Error_Get_Number(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// EarlyAbort controls whether all errors halts the DSS script processing (Compile/Redirect), defaults to True.
        /// 
        /// (API Extension)
        /// </summary>
        public bool EarlyAbort
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Error_Get_EarlyAbort(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Error_Set_EarlyAbort(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Controls whether the extended error mechanism is used. Defaults to True.
        /// 
        /// Extended errors are errors derived from checks across the API to ensure
        /// a valid state. Although many of these checks are already present in the 
        /// original/official COM interface, the checks do not produce any error 
        /// message. An error value can be returned by a function but this value
        /// can, for many of the functions, be a valid value. As such, the user
        /// has no means to detect an invalid API call. 
        /// 
        /// Extended errors use the Error interface to provide a more clear message
        /// and should help users, especially new users, to find usage issues earlier.
        /// 
        /// At Python level, an exception is raised when an error is detected through
        /// the Error interface.
        /// 
        /// The current default state is ON. For compatibility, the user can turn it
        /// off to restore the previous behavior.
        /// 
        /// (API Extension)
        /// </summary>
        public bool ExtendedErrors
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Error_Get_ExtendedErrors(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Error_Set_ExtendedErrors(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Fuses : ContextState
    {

        public Fuses(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Fuse names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Fuses_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Fuse objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Fuse active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Fuse by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Fuse active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Fuse by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public void Close()
        {
            try
            {
                DSS_CAPI.ctx_Fuses_Close(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public bool IsBlown()
        {
            try
            {
                return (DSS_CAPI.ctx_Fuses_IsBlown(ctx) != 0);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Open()
        {
            try
            {
                DSS_CAPI.ctx_Fuses_Open(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// A fixed delay time in seconds added to the fuse blowing time determined by the TCC curve. Default is 0.
        /// This represents a fuse clear or other delay.
        /// </summary>
        public double Delay
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_Delay(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_Delay(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of the circuit element to which the fuse is connected.
        /// </summary>
        public string MonitoredObj
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_MonitoredObj(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_MonitoredObj(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Terminal number to which the fuse is connected.
        /// </summary>
        public int MonitoredTerm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_MonitoredTerm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_MonitoredTerm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of phases, this fuse.
        /// </summary>
        public int NumPhases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_NumPhases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Multiplier or actual amps for the TCCcurve object. Defaults to 1.0. 
        /// Multiply current values of TCC curve by this to get actual amps.
        /// </summary>
        public double RatedCurrent
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_RatedCurrent(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_RatedCurrent(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of the circuit element switch that the fuse controls. 
        /// Defaults to the MonitoredObj.
        /// </summary>
        public string SwitchedObj
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_SwitchedObj(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_SwitchedObj(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of the terminal of the controlled element containing the switch controlled by the fuse.
        /// </summary>
        public int SwitchedTerm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_SwitchedTerm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_SwitchedTerm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the TCCcurve object that determines fuse blowing.
        /// </summary>
        public string TCCcurve
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Fuses_Get_TCCcurve(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_TCCcurve(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class ISources : ContextState
    {

        public ISources(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all ISource names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_ISources_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of ISource objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ISources_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first ISource active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ISources_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active ISource by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ISources_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ISources_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next ISource active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ISources_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active ISource by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ISources_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ISources_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Magnitude of the ISource in amps
        /// </summary>
        public double Amps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ISources_Get_Amps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ISources_Set_Amps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Phase angle for ISource, degrees
        /// </summary>
        public double AngleDeg
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ISources_Get_AngleDeg(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ISources_Set_AngleDeg(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// The present frequency of the ISource, Hz
        /// </summary>
        public double Frequency
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ISources_Get_Frequency(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ISources_Set_Frequency(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class LineCodes : ContextState
    {

        public LineCodes(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all LineCode names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_LineCodes_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of LineCode objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first LineCode active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active LineCode by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next LineCode active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active LineCode by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Zero-sequence capacitance, nF per unit length
        /// </summary>
        public double C0
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_C0(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_C0(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Positive-sequence capacitance, nF per unit length
        /// </summary>
        public double C1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_C1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_C1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Capacitance matrix, nF per unit length
        /// </summary>
        public double[] Cmatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Get_Cmatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_Cmatrix(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Emergency ampere rating
        /// </summary>
        public double EmergAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_EmergAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_EmergAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Flag denoting whether impedance data were entered in symmetrical components
        /// </summary>
        public bool IsZ1Z0
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_LineCodes_Get_IsZ1Z0(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Normal Ampere rating
        /// </summary>
        public double NormAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_NormAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_NormAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Phases
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Zero-Sequence Resistance, ohms per unit length
        /// </summary>
        public double R0
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_R0(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_R0(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Positive-sequence resistance ohms per unit length
        /// </summary>
        public double R1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_R1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_R1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Resistance matrix, ohms per unit length
        /// </summary>
        public double[] Rmatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Get_Rmatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_Rmatrix(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int Units
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_Units(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_Units(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Zero Sequence Reactance, Ohms per unit length
        /// </summary>
        public double X0
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_X0(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_X0(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Posiive-sequence reactance, ohms per unit length
        /// </summary>
        public double X1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineCodes_Get_X1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_X1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Reactance matrix, ohms per unit length
        /// </summary>
        public double[] Xmatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Get_Xmatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineCodes_Set_Xmatrix(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Monitors : ContextState
    {

        public Monitors(APIUtil util) : base(util)
        {
        }
    
        // TODO: Implement AsMatrix someday

        /// <summary>
        /// Array of float64 for the specified channel (usage: MyArray = DSSMonitor.Channel(i)).
        /// A Save or SaveAll should be executed first. Done automatically by most standard solution modes.
        /// Channels start at index 1.
        /// </summary>
        public double[] Channel(int Index)
        {
            //TODO: use the better implementation
            DSS_CAPI.ctx_Monitors_Get_Channel_GR(ctx, Index);
            return apiutil.get_float64_gr_array();
        }

        /// <summary>
        /// Array of strings with all Monitor names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Monitors_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Monitor objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Monitor active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Monitor by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Monitors_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Monitor active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Monitor by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Monitors_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public void Process()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_Process(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void ProcessAll()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_ProcessAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void ResetAll()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_ResetAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Sample()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_Sample(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SampleAll()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_SampleAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Save()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_Save(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SaveAll()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_SaveAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Show()
        {
            try
            {
                DSS_CAPI.ctx_Monitors_Show(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Byte Array containing monitor stream values. Make sure a "save" is done first (standard solution modes do this automatically)
        /// </summary>
        public byte[] ByteStream
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Monitors_Get_ByteStream_GR(ctx);
                    return apiutil.get_int8_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full object name of element being monitored.
        /// </summary>
        public string Element
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_Element(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Monitors_Set_Element(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of CSV file associated with active Monitor.
        /// </summary>
        public string FileName
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_FileName(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Monitor File Version (integer)
        /// </summary>
        public int FileVersion
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_FileVersion(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Header string;  Array of strings containing Channel names
        /// </summary>
        public string[] Header
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Monitors_Get_Header);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set Monitor mode (bitmask integer - see DSS Help)
        /// </summary>
        public int Mode
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_Mode(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Monitors_Set_Mode(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Channels in the active Monitor
        /// </summary>
        public int NumChannels
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_NumChannels(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Size of each record in ByteStream (Integer). Same as NumChannels.
        /// </summary>
        public int RecordSize
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_RecordSize(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Samples in Monitor at Present
        /// </summary>
        public int SampleCount
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_SampleCount(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Terminal number of element being monitored.
        /// </summary>
        public int Terminal
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Monitors_Get_Terminal(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Monitors_Set_Terminal(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles containing frequency values for harmonics mode solutions; Empty for time mode solutions (use dblHour)
        /// </summary>
        public double[] dblFreq
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Monitors_Get_dblFreq_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles containing time value in hours for time-sampled monitor values; Empty if frequency-sampled values for harmonics solution (see dblFreq)
        /// </summary>
        public double[] dblHour
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Monitors_Get_dblHour_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Parser : ContextState
    {

        public Parser(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Use this property to parse a Matrix token in OpenDSS format.  Returns square matrix of order specified. Order same as default Fortran order: column by column.
        /// </summary>
        public double[] Matrix(int ExpectedOrder)
        {
            try
            {
                DSS_CAPI.ctx_Parser_Get_Matrix_GR(ctx, ExpectedOrder);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Use this property to parse a matrix token specified in lower triangle form. Symmetry is forced.
        /// </summary>
        public double[] SymMatrix(int ExpectedOrder)
        {
            try
            {
                DSS_CAPI.ctx_Parser_Get_SymMatrix_GR(ctx, ExpectedOrder);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Returns token as array of doubles. For parsing quoted array syntax.
        /// </summary>
        public double[] Vector(int ExpectedSize)
        {
            try
            {
                DSS_CAPI.ctx_Parser_Get_Vector_GR(ctx, ExpectedSize);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        public void ResetDelimiters()
        {
            try
            {
                DSS_CAPI.ctx_Parser_ResetDelimiters(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Default is FALSE. If TRUE parser automatically advances to next token after DblValue, IntValue, or StrValue. Simpler when you don't need to check for parameter names.
        /// </summary>
        public bool AutoIncrement
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Parser_Get_AutoIncrement(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parser_Set_AutoIncrement(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set String containing the the characters for Quoting in OpenDSS scripts. Matching pairs defined in EndQuote. Default is "'([{.
        /// </summary>
        public string BeginQuote
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_BeginQuote(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parser_Set_BeginQuote(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// String to be parsed. Loading this string resets the Parser to the beginning of the line. Then parse off the tokens in sequence.
        /// </summary>
        public string CmdString
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_CmdString(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parser_Set_CmdString(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Return next parameter as a double.
        /// </summary>
        public double DblValue
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_DblValue(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// String defining hard delimiters used to separate token on the command string. Default is , and =. The = separates token name from token value. These override whitesspace to separate tokens.
        /// </summary>
        public string Delimiters
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_Delimiters(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parser_Set_Delimiters(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// String containing characters, in order, that match the beginning quote characters in BeginQuote. Default is "')]}
        /// </summary>
        public string EndQuote
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_EndQuote(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parser_Set_EndQuote(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Return next parameter as a long integer.
        /// </summary>
        public int IntValue
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_IntValue(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get next token and return tag name (before = sign) if any. See AutoIncrement.
        /// </summary>
        public string NextParam
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_NextParam(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Return next parameter as a string
        /// </summary>
        public string StrValue
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_StrValue(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// (read) Get the characters used for White space in the command string.  Default is blank and Tab.
        /// (write) Set the characters used for White space in the command string.  Default is blank and Tab.
        /// </summary>
        public string WhiteSpace
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parser_Get_WhiteSpace(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parser_Set_WhiteSpace(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class ReduceCkt : ContextState
    {

        public ReduceCkt(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Zmag (ohms) for Reduce Option for Z of short lines
        /// </summary>
        public double Zmag
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ReduceCkt_Get_Zmag(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ReduceCkt_Set_Zmag(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Keep load flag (T/F) for Reduction options that remove branches
        /// </summary>
        public bool KeepLoad
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_ReduceCkt_Get_KeepLoad(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ReduceCkt_Set_KeepLoad(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Edit String for RemoveBranches functions
        /// </summary>
        public string EditString
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ReduceCkt_Get_EditString(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ReduceCkt_Set_EditString(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Start element for Remove Branch function
        /// </summary>
        public string StartPDElement
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ReduceCkt_Get_StartPDElement(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ReduceCkt_Set_StartPDElement(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of Energymeter to use for reduction
        /// </summary>
        public string EnergyMeter
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_ReduceCkt_Get_EnergyMeter(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_ReduceCkt_Set_EnergyMeter(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Save present (reduced) circuit
        /// Filename is listed in the Text Result interface
        /// </summary>
        public void SaveCircuit(string CktName)
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_SaveCircuit(ctx, CktName);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Do Default Reduction algorithm
        /// </summary>
        public void DoDefault()
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_DoDefault(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Do ShortLines algorithm: Set Zmag first if you don't want the default
        /// </summary>
        public void DoShortLines()
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_DoShortLines(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Reduce Dangling Algorithm; branches with nothing connected
        /// </summary>
        public void DoDangling()
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_DoDangling(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void DoLoopBreak()
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_DoLoopBreak(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void DoParallelLines()
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_DoParallelLines(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void DoSwitches()
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_DoSwitches(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Do1phLaterals()
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_Do1phLaterals(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void DoBranchRemove()
        {
            try
            {
                DSS_CAPI.ctx_ReduceCkt_DoBranchRemove(ctx);
            }
            finally
            {
                CheckForError();
            }
        }
    }

    public class Solution : ContextState
    {

        public Solution(APIUtil util) : base(util)
        {
        }

        public void BuildYMatrix(int BuildOption, int AllocateVI)
        {
            try
            {
                DSS_CAPI.ctx_Solution_BuildYMatrix(ctx, BuildOption, AllocateVI);
            }
            finally
            {
                CheckForError();
            }
        }

        public void CheckControls()
        {
            try
            {
                DSS_CAPI.ctx_Solution_CheckControls(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void CheckFaultStatus()
        {
            try
            {
                DSS_CAPI.ctx_Solution_CheckFaultStatus(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Cleanup()
        {
            try
            {
                DSS_CAPI.ctx_Solution_Cleanup(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void DoControlActions()
        {
            try
            {
                DSS_CAPI.ctx_Solution_DoControlActions(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void FinishTimeStep()
        {
            try
            {
                DSS_CAPI.ctx_Solution_FinishTimeStep(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void InitSnap()
        {
            try
            {
                DSS_CAPI.ctx_Solution_InitSnap(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SampleControlDevices()
        {
            try
            {
                DSS_CAPI.ctx_Solution_SampleControlDevices(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Sample_DoControlActions()
        {
            try
            {
                DSS_CAPI.ctx_Solution_Sample_DoControlActions(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Solve()
        {
            try
            {
                DSS_CAPI.ctx_Solution_Solve(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SolveDirect()
        {
            try
            {
                DSS_CAPI.ctx_Solution_SolveDirect(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SolveNoControl()
        {
            try
            {
                DSS_CAPI.ctx_Solution_SolveNoControl(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SolvePflow()
        {
            try
            {
                DSS_CAPI.ctx_Solution_SolvePflow(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SolvePlusControl()
        {
            try
            {
                DSS_CAPI.ctx_Solution_SolvePlusControl(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SolveSnap()
        {
            try
            {
                DSS_CAPI.ctx_Solution_SolveSnap(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Type of device to add in AutoAdd Mode: {dssGen (Default) | dssCap}
        /// </summary>
        public int AddType
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_AddType(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_AddType(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Base Solution algorithm: {dssNormalSolve | dssNewtonSolve}
        /// </summary>
        public int Algorithm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Algorithm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Algorithm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Capacitor kvar for adding capacitors in AutoAdd mode
        /// </summary>
        public double Capkvar
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Capkvar(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Capkvar(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Flag indicating the control actions are done.
        /// </summary>
        public bool ControlActionsDone
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Solution_Get_ControlActionsDone(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_ControlActionsDone(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Value of the control iteration counter
        /// </summary>
        public int ControlIterations
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_ControlIterations(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_ControlIterations(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// {dssStatic* | dssEvent | dssTime}  Modes for control devices
        /// </summary>
        public int ControlMode
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_ControlMode(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_ControlMode(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Flag to indicate whether the circuit solution converged
        /// </summary>
        public bool Converged
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Solution_Get_Converged(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Converged(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Default daily load shape (defaults to "Default")
        /// </summary>
        public string DefaultDaily
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_DefaultDaily(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_DefaultDaily(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Default Yearly load shape (defaults to "Default")
        /// </summary>
        public string DefaultYearly
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_DefaultYearly(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_DefaultYearly(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings containing the Event Log
        /// </summary>
        public string[] EventLog
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Solution_Get_EventLog);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set the Frequency for next solution
        /// </summary>
        public double Frequency
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Frequency(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Frequency(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Default Multiplier applied to generators (like LoadMult)
        /// </summary>
        public double GenMult
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_GenMult(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_GenMult(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// PF for generators in AutoAdd mode
        /// </summary>
        public double GenPF
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_GenPF(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_GenPF(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Generator kW for AutoAdd mode
        /// </summary>
        public double GenkW
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_GenkW(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_GenkW(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set Hour for time series solutions.
        /// </summary>
        public int Hour
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Hour(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Hour(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set the Solution.IntervalHrs variable used for devices that integrate / custom solution algorithms
        /// </summary>
        public double IntervalHrs
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_IntervalHrs(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_IntervalHrs(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of iterations taken for last solution. (Same as TotalIterations)
        /// </summary>
        public int Iterations
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Iterations(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Load-Duration Curve name for LD modes
        /// </summary>
        public string LDCurve
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_LDCurve(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_LDCurve(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Load Model: {dssPowerFlow (default) | dssAdmittance}
        /// </summary>
        public int LoadModel
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_LoadModel(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_LoadModel(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Default load multiplier applied to all non-fixed loads
        /// </summary>
        public double LoadMult
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_LoadMult(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_LoadMult(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Maximum allowable control iterations
        /// </summary>
        public int MaxControlIterations
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_MaxControlIterations(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_MaxControlIterations(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Max allowable iterations.
        /// </summary>
        public int MaxIterations
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_MaxIterations(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_MaxIterations(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Minimum number of iterations required for a power flow solution.
        /// </summary>
        public int MinIterations
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_MinIterations(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_MinIterations(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set present solution mode (by a text code - see DSS Help)
        /// </summary>
        public int Mode
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Mode(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Mode(ctx, Mode);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// ID (text) of the present solution mode
        /// </summary>
        public string ModeID
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_ModeID(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Max number of iterations required to converge at any control iteration of the most recent solution.
        /// </summary>
        public int MostIterationsDone
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_MostIterationsDone(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of solutions to perform for Monte Carlo and time series simulations
        /// </summary>
        public int Number
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Number(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Number(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets the time required to perform the latest solution (Read only)
        /// </summary>
        public double Process_Time
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Process_Time(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Randomization mode for random variables "Gaussian" or "Uniform"
        /// </summary>
        public int Random
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Random(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Random(ctx, Random);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Seconds from top of the hour.
        /// </summary>
        public double Seconds
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Seconds(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Seconds(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time step size in sec
        /// </summary>
        public double StepSize
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_StepSize(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_StepSize(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Flag that indicates if elements of the System Y have been changed by recent activity.
        /// </summary>
        public bool SystemYChanged
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Solution_Get_SystemYChanged(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get the solution process time + sample time for time step
        /// </summary>
        public double Time_of_Step
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Time_of_Step(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Solution convergence tolerance.
        /// </summary>
        public double Tolerance
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Tolerance(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Tolerance(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets/sets the accumulated time of the simulation
        /// </summary>
        public double Total_Time
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Total_Time(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Total_Time(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total iterations including control iterations for most recent solution.
        /// </summary>
        public int Totaliterations
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Totaliterations(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set year for planning studies
        /// </summary>
        public int Year
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_Year(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Year(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Hour as a double, including fractional part
        /// </summary>
        public double dblHour
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_dblHour(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_dblHour(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Percent default  annual load growth rate
        /// </summary>
        public double pctGrowth
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Solution_Get_pctGrowth(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_pctGrowth(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// (write-only) Set Stepsize in Hr
        /// </summary>
        public double StepsizeHr
        {
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_StepsizeHr(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// (write-only) Set Stepsize in minutes
        /// </summary>
        public double StepsizeMin
        {
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_StepsizeMin(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int[] BusLevels
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Get_BusLevels_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int[] IncMatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Get_IncMatrix_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public string[] IncMatrixCols
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Solution_Get_IncMatrixCols);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public string[] IncMatrixRows
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Solution_Get_IncMatrixRows);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int[] Laplacian
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Get_Laplacian_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class LineGeometries : ContextState
    {

        public LineGeometries(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all LineGeometrie names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_LineGeometries_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of LineGeometrie objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first LineGeometrie active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active LineGeometrie by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next LineGeometrie active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active LineGeometrie by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Array of strings with names of all conductors in the active LineGeometry object
        /// </summary>
        public string[] Conductors
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_LineGeometries_Get_Conductors);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Emergency ampere rating
        /// </summary>
        public double EmergAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_EmergAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_EmergAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Normal ampere rating
        /// </summary>
        public double NormAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_NormAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_NormAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double RhoEarth
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_RhoEarth(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_RhoEarth(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public bool Reduce
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_LineGeometries_Get_Reduce(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_Reduce(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Phases
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Resistance matrix, ohms
        /// </summary>
        public double[] Rmatrix(double Frequency, double Length, int Units)
        {
            try
            {
                DSS_CAPI.ctx_LineGeometries_Get_Rmatrix_GR(ctx, Frequency, Length, Units);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Reactance matrix, ohms
        /// </summary>
        public double[] Xmatrix(double Frequency, double Length, int Units)
        {
            try
            {
                DSS_CAPI.ctx_LineGeometries_Get_Xmatrix_GR(ctx, Frequency, Length, Units);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Complex impedance matrix, ohms
        /// </summary>
        public double[] Zmatrix(double Frequency, double Length, int Units)
        {
            try
            {
                DSS_CAPI.ctx_LineGeometries_Get_Zmatrix_GR(ctx, Frequency, Length, Units);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Capacitance matrix, nF
        /// </summary>
        public double[] Cmatrix(double Frequency, double Length, int Units)
        {
            try
            {
                DSS_CAPI.ctx_LineGeometries_Get_Cmatrix_GR(ctx, Frequency, Length, Units);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        public int[] Units
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Get_Units_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_Units(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set the X (horizontal) coordinates of the conductors
        /// </summary>
        public double[] Xcoords
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Get_Xcoords_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_Xcoords(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set the Y (vertical/height) coordinates of the conductors
        /// </summary>
        public double[] Ycoords
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Get_Ycoords_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_Ycoords(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class LineSpacings : ContextState
    {

        public LineSpacings(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all LineSpacing names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_LineSpacings_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of LineSpacing objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineSpacings_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first LineSpacing active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineSpacings_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active LineSpacing by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineSpacings_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next LineSpacing active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineSpacings_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active LineSpacing by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineSpacings_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Number of Phases
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineSpacings_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int Nconds
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineSpacings_Get_Nconds(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Set_Nconds(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int Units
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineSpacings_Get_Units(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Set_Units(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set the X (horizontal) coordinates of the conductors
        /// </summary>
        public double[] Xcoords
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Get_Xcoords_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Set_Xcoords(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set the Y (vertical/height) coordinates of the conductors
        /// </summary>
        public double[] Ycoords
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Get_Ycoords_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineSpacings_Set_Ycoords(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class LoadShapes : ContextState
    {

        public LoadShapes(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all LoadShape names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_LoadShapes_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of LoadShape objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first LoadShape active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active LoadShape by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next LoadShape active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active LoadShape by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public int New(string Name)
        {
            try
            {
                return DSS_CAPI.ctx_LoadShapes_New(ctx, Name);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Normalize()
        {
            try
            {
                DSS_CAPI.ctx_LoadShapes_Normalize(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Fixed interval time value, hours.
        /// </summary>
        public double HrInterval
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_HrInterval(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_HrInterval(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Fixed Interval time value, in minutes
        /// </summary>
        public double MinInterval
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_MinInterval(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_MinInterval(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set Number of points in active Loadshape.
        /// </summary>
        public int Npts
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_Npts(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_Npts(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double PBase
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_PBase(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_PBase(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles for the P multiplier in the Loadshape.
        /// </summary>
        public double[] Pmult
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Get_Pmult_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_Pmult(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Base for normalizing Q curve. If left at zero, the peak value is used.
        /// </summary>
        public double QBase
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_Qbase(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_Qbase(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles containing the Q multipliers.
        /// </summary>
        public double[] Qmult
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Get_Qmult_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_Qmult(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time array in hours correscponding to P and Q multipliers when the Interval=0.
        /// </summary>
        public double[] TimeArray
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Get_TimeArray_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_TimeArray(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Boolean flag to let Loads know to use the actual value in the curve rather than use the value as a multiplier.
        /// </summary>
        public bool UseActual
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_LoadShapes_Get_UseActual(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_UseActual(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double sInterval
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LoadShapes_Get_SInterval(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LoadShapes_Set_SInterval(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Loads : ContextState
    {

        public Loads(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Load names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Loads_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Load objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Load active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Load by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Load active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Load by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Factor for allocating loads by connected xfkva
        /// </summary>
        public double AllocationFactor
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_AllocationFactor(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_AllocationFactor(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of a loadshape with both Mult and Qmult, for CVR factors as a function of time.
        /// </summary>
        public string CVRcurve
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_CVRcurve(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_CVRcurve(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Percent reduction in Q for percent reduction in V. Must be used with dssLoadModelCVR.
        /// </summary>
        public double CVRvars
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_CVRvars(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_CVRvars(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Percent reduction in P for percent reduction in V. Must be used with dssLoadModelCVR.
        /// </summary>
        public double CVRwatts
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_CVRwatts(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_CVRwatts(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Factor relates average to peak kw.  Used for allocation with kwh and kwhdays
        /// </summary>
        public double Cfactor
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Cfactor(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Cfactor(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int Class
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Class_(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Class_(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the growthshape curve for yearly load growth factors.
        /// </summary>
        public string Growth
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Growth(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Growth(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Delta loads are connected line-to-line.
        /// </summary>
        public bool IsDelta
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Loads_Get_IsDelta(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_IsDelta(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// The Load Model defines variation of P and Q with voltage.
        /// </summary>
        public int Model
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Model(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Model(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of customers in this load, defaults to one.
        /// </summary>
        public int NumCust
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_NumCust(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_NumCust(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get or set Power Factor for Active Load. Specify leading PF as negative. Updates kvar based on present value of kW
        /// </summary>
        public double PF
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_PF(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_PF(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Average percent of nominal load in Monte Carlo studies; only if no loadshape defined for this load.
        /// </summary>
        public double PctMean
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_PctMean(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_PctMean(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Percent standard deviation for Monte Carlo load studies; if there is no loadshape assigned to this load.
        /// </summary>
        public double PctStdDev
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_PctStdDev(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_PctStdDev(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Relative Weighting factor for the active LOAD
        /// </summary>
        public double RelWeight
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_RelWeight(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_RelWeight(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Neutral resistance for wye-connected loads.
        /// </summary>
        public double Rneut
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Rneut(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Rneut(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of harmonic current spectrrum shape.
        /// </summary>
        public string Spectrum
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Spectrum(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Spectrum(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Response to load multipliers: Fixed (growth only), Exempt (no LD curve), Variable (all).
        /// </summary>
        public int Status
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Status(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Status(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Maximum per-unit voltage to use the load model. Above this, constant Z applies.
        /// </summary>
        public double Vmaxpu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Vmaxpu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Vmaxpu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Minimum voltage for unserved energy (UE) evaluation.
        /// </summary>
        public double Vminemerg
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Vminemerg(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Vminemerg(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Minimum voltage for energy exceeding normal (EEN) evaluations.
        /// </summary>
        public double Vminnorm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Vminnorm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Vminnorm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Minimum voltage to apply the load model. Below this, constant Z is used.
        /// </summary>
        public double Vminpu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Vminpu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Vminpu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Neutral reactance for wye-connected loads.
        /// </summary>
        public double Xneut
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Xneut(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Xneut(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of yearly duration loadshape
        /// </summary>
        public string Yearly
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Yearly(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Yearly(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of 7 doubles with values for ZIPV property of the load object
        /// </summary>
        public double[] ZIPV
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Get_ZIPV_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_ZIPV(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the loadshape for a daily load profile.
        /// </summary>
        public string daily
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_daily(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_daily(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the loadshape for a duty cycle simulation.
        /// </summary>
        public string duty
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_duty(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_duty(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set kV rating for active Load. For 2 or more phases set Line-Line kV. Else actual kV across terminals.
        /// </summary>
        public double kV
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_kV(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_kV(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set kW for active Load. Updates kvar based on present PF.
        /// </summary>
        public double kW
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_kW(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_kW(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Base load kva. Also defined kw and kvar or pf input, or load allocation by kwh or xfkva.
        /// </summary>
        public double kva
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_kva(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_kva(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set kvar for active Load. If set, updates PF based on present kW.
        /// </summary>
        public double kvar
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_kvar(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_kvar(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// kwh billed for this period. Can be used with Cfactor for load allocation.
        /// </summary>
        public double kwh
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_kwh(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_kwh(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Length of kwh billing period for average demand calculation. Default 30.
        /// </summary>
        public double kwhdays
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_kwhdays(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_kwhdays(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Percent of Load that is modeled as series R-L for harmonics studies
        /// </summary>
        public double pctSeriesRL
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_pctSeriesRL(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_pctSeriesRL(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Rated service transformer kVA for load allocation, using AllocationFactor. Affects kW, kvar, and pf.
        /// </summary>
        public double xfkVA
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_xfkVA(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_xfkVA(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of phases
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Loads_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Meters : ContextState
    {

        public Meters(APIUtil util) : base(util)
        {
        }
    
        /// <summary>
        /// Returns the list of all PCE within the area covered by the energy meter
        /// </summary>
        public string[] ZonePCE
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Meters_Get_ZonePCE, false, true);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings with all Meter names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Meters_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Meter objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Meter active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Meter by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Meter active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Meter by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public void CloseAllDIFiles()
        {
            try
            {
                DSS_CAPI.ctx_Meters_CloseAllDIFiles(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void DoReliabilityCalc(bool AssumeRestoration)
        {
            try
            {
                DSS_CAPI.ctx_Meters_DoReliabilityCalc(ctx, AssumeRestoration);
            }
            finally
            {
                CheckForError();
            }
        }

        public void OpenAllDIFiles()
        {
            try
            {
                DSS_CAPI.ctx_Meters_OpenAllDIFiles(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_Meters_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void ResetAll()
        {
            try
            {
                DSS_CAPI.ctx_Meters_ResetAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Sample()
        {
            try
            {
                DSS_CAPI.ctx_Meters_Sample(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SampleAll()
        {
            try
            {
                DSS_CAPI.ctx_Meters_SampleAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Save()
        {
            try
            {
                DSS_CAPI.ctx_Meters_Save(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SaveAll()
        {
            try
            {
                DSS_CAPI.ctx_Meters_SaveAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SetActiveSection(int SectIdx)
        {
            try
            {
                DSS_CAPI.ctx_Meters_SetActiveSection(ctx, SectIdx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Wide string list of all branches in zone of the active energymeter object.
        /// </summary>
        public string[] AllBranchesInZone
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Meters_Get_AllBranchesInZone);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of names of all zone end elements.
        /// </summary>
        public string[] AllEndElements
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Meters_Get_AllEndElements);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles: set the phase allocation factors for the active meter.
        /// </summary>
        public double[] AllocFactors
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Get_AllocFactors_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Set_AllocFactors(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Average Repair time in this section of the meter zone
        /// </summary>
        public double AvgRepairTime
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_AvgRepairTime(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set the magnitude of the real part of the Calculated Current (normally determined by solution) for the Meter to force some behavior on Load Allocation
        /// </summary>
        public double[] CalcCurrent
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Get_CalcCurrent_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Set_CalcCurrent(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of branches in Active energymeter zone. (Same as sequencelist size)
        /// </summary>
        public int CountBranches
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_CountBranches(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of zone end elements in the active meter zone.
        /// </summary>
        public int CountEndElements
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_CountEndElements(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total customer interruptions for this Meter zone based on reliability calcs.
        /// </summary>
        public double CustInterrupts
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_CustInterrupts(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Global Flag in the DSS to indicate if Demand Interval (DI) files have been properly opened.
        /// </summary>
        public bool DIFilesAreOpen
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Meters_Get_DIFilesAreOpen(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sum of Fault Rate time Repair Hrs in this section of the meter zone
        /// </summary>
        public double FaultRateXRepairHrs
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_FaultRateXRepairHrs(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set Name of metered element
        /// </summary>
        public string MeteredElement
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_MeteredElement(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Set_MeteredElement(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// set Number of Metered Terminal
        /// </summary>
        public int MeteredTerminal
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_MeteredTerminal(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Set_MeteredTerminal(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of branches (lines) in this section
        /// </summary>
        public int NumSectionBranches
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_NumSectionBranches(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Customers in the active section.
        /// </summary>
        public int NumSectionCustomers
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_NumSectionCustomers(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of feeder sections in this meter's zone
        /// </summary>
        public int NumSections
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_NumSections(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Type of OCP device. 1=Fuse; 2=Recloser; 3=Relay
        /// </summary>
        public int OCPDeviceType
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_OCPDeviceType(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles to set values of Peak Current property
        /// </summary>
        public double[] Peakcurrent
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Get_Peakcurrent_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Set_Peakcurrent(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings containing the names of the registers.
        /// </summary>
        public string[] RegisterNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Meters_Get_RegisterNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of all the values contained in the Meter registers for the active Meter.
        /// </summary>
        public double[] RegisterValues
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Get_RegisterValues_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// SAIDI for this meter's zone. Execute DoReliabilityCalc first.
        /// </summary>
        public double SAIDI
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_SAIDI(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns SAIFI for this meter's Zone. Execute Reliability Calc method first.
        /// </summary>
        public double SAIFI
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_SAIFI(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// SAIFI based on kW rather than number of customers. Get after reliability calcs.
        /// </summary>
        public double SAIFIKW
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_SAIFIKW(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// SequenceIndex of the branch at the head of this section
        /// </summary>
        public int SectSeqIdx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_SectSeqIdx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total Customers downline from this section
        /// </summary>
        public int SectTotalCust
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_SectTotalCust(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Size of Sequence List
        /// </summary>
        public int SeqListSize
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_SeqListSize(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set Index into Meter's SequenceList that contains branch pointers in lexical order. Earlier index guaranteed to be upline from later index. Sets PDelement active.
        /// </summary>
        public int SequenceIndex
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_SequenceIndex(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Set_SequenceIndex(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sum of the branch fault rates in this section of the meter's zone
        /// </summary>
        public double SumBranchFltRates
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_SumBranchFltRates(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total Number of customers in this zone (downline from the EnergyMeter)
        /// </summary>
        public int TotalCustomers
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Meters_Get_TotalCustomers(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Totals of all registers of all meters
        /// </summary>
        public double[] Totals
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Meters_Get_Totals_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

    }

    public class PDElements : ContextState
    {

        public PDElements(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// accummulated failure rate for this branch on downline
        /// </summary>
        public double AccumulatedL
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_AccumulatedL(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of PD elements (including disabled elements)
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set Number of failures per year. 
        /// For LINE elements: Number of failures per unit length per year.
        /// </summary>
        public double FaultRate
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_FaultRate(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Set_FaultRate(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set the first enabled PD element to be the active element.
        /// Returns 0 if none found.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of the terminal of active PD element that is on the "from" 
        /// side. This is set after the meter zone is determined.
        /// </summary>
        public int FromTerminal
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_FromTerminal(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Boolean indicating of PD element should be treated as a shunt 
        /// element rather than a series element. Applies to Capacitor and Reactor 
        /// elements in particular.
        /// </summary>
        public bool IsShunt
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_PDElements_Get_IsShunt(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Failure rate for this branch. Faults per year including length of line.
        /// </summary>
        public double Lambda
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_Lambda(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set name of active PD Element. Returns null string if active element 
        /// is not PDElement type.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Advance to the next PD element in the circuit. Enabled elements 
        /// only. Returns 0 when no more elements.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of customers, this branch
        /// </summary>
        public int Numcustomers
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_Numcustomers(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the parent PD element to be the active circuit element.
        /// Returns 0 if no more elements upline.
        /// </summary>
        public int ParentPDElement
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_ParentPDElement(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Average repair time for this element in hours
        /// </summary>
        public double RepairTime
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_RepairTime(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Set_RepairTime(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer ID of the feeder section that this PDElement branch is part of
        /// </summary>
        public int SectionID
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_SectionID(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total miles of line from this element to the end of the zone. For recloser siting algorithm.
        /// </summary>
        public double TotalMiles
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_TotalMiles(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total number of customers from this branch to the end of the zone
        /// </summary>
        public int Totalcustomers
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_Totalcustomers(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set percent of faults that are permanent (require repair). Otherwise, fault is assumed to be transient/temporary.
        /// </summary>
        public double pctPermanent
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PDElements_Get_pctPermanent(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Set_pctPermanent(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings consisting of all PD element names.
        /// 
        /// (API Extension)
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_PDElements_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
        /// <summary>
        /// Array of doubles with the maximum current across the conductors, for each PD 
        /// element.
        /// 
        /// By default, only the *first terminal* is used for the maximum current, matching
        /// the behavior of the "export capacity" command. Pass `true` to 
        /// force the analysis to all terminals.
        /// 
        /// See also: 
        /// https://sourceforge.net/p/electricdss/discussion/beginners/thread/da5b93ca/
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllMaxCurrents(bool AllNodes=false)
        {
            try
            {
                DSS_CAPI.ctx_PDElements_Get_AllMaxCurrents_GR(ctx, AllNodes);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Array of doubles with the maximum current across the conductors as a percentage 
        /// of the Normal Ampere Rating, for each PD element.
        /// 
        /// By default, only the *first terminal* is used for the maximum current, matching
        /// the behavior of the "export capacity" command. Pass `true` to 
        /// force the analysis to all terminals.
        /// 
        /// See also: 
        /// https://sourceforge.net/p/electricdss/discussion/beginners/thread/da5b93ca/
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllPctNorm(bool AllNodes=false)
        {
            try
            {
                DSS_CAPI.ctx_PDElements_Get_AllPctNorm_GR(ctx, AllNodes);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Array of doubles with the maximum current across the conductors as a percentage
        /// of the Emergency Ampere Rating, for each PD element.
        /// 
        /// By default, only the *first terminal* is used for the maximum current, matching
        /// the behavior of the "export capacity" command. Pass `true` to 
        /// force the analysis to all terminals.
        /// 
        /// See also: 
        /// https://sourceforge.net/p/electricdss/discussion/beginners/thread/da5b93ca/
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllPctEmerg(bool AllNodes=false)
        {
            try
            {
                DSS_CAPI.ctx_PDElements_Get_AllPctEmerg_GR(ctx, AllNodes);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Complex array of currents for all conductors, all terminals, for each PD element.
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllCurrents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllCurrents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array (magnitude and angle format) of currents for all conductors, all terminals, for each PD element.
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllCurrentsMagAng
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllCurrentsMagAng_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex double array of Sequence Currents for all conductors of all terminals, for each PD elements.
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllCplxSeqCurrents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllCplxSeqCurrents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Double array of the symmetrical component currents into each 3-phase terminal, for each PD element.
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllSeqCurrents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllSeqCurrents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of powers into each conductor of each terminal, for each PD element.
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllPowers
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllPowers_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Double array of sequence powers into each 3-phase teminal, for each PD element
        /// 
        /// (API Extension)
        /// </summary>
        public double[] AllSeqPowers
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllSeqPowers_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer array listing the number of phases of all PD elements
        /// 
        /// (API Extension)
        /// </summary>
        public int[] AllNumPhases
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllNumPhases_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer array listing the number of conductors of all PD elements
        /// 
        /// (API Extension)
        /// </summary>
        public int[] AllNumConductors
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllNumConductors_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer array listing the number of terminals of all PD elements
        /// 
        /// (API Extension)
        /// </summary>
        public int[] AllNumTerminals
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PDElements_Get_AllNumTerminals_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class PVSystems : ContextState
    {

        public PVSystems(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all PVSystem names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_PVSystems_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of PVSystem objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first PVSystem active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active PVSystem by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next PVSystem active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active PVSystem by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Get/set the present value of the Irradiance property in W/m²
        /// </summary>
        public double Irradiance
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_Irradiance(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_Irradiance(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set the power factor for the active PVSystem
        /// </summary>
        public double PF
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_PF(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_PF(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of PVSYSTEM energy meter register names
        /// </summary>
        public string[] RegisterNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_PVSystems_Get_RegisterNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles containing values in PVSystem registers.
        /// </summary>
        public double[] RegisterValues
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Get_RegisterValues_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set Rated kVA of the PVSystem
        /// </summary>
        public double kVArated
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_kVArated(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_kVArated(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// get kW output
        /// </summary>
        public double kW
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_kW(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set kvar output value
        /// </summary>
        public double kvar
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_kvar(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_kvar(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the loadshape for a daily PVSystem profile.
        /// </summary>
        public string daily
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_daily(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_daily(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the load shape to use for duty cycle dispatch simulations such as
        /// for solar ramp rate studies. Must be previously defined as a Loadshape
        /// object. Typically would have time intervals of 1-5 seconds.
        /// </summary>
        public string duty
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_duty(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_duty(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Dispatch shape to use for yearly simulations. Must be previously defined
        /// as a Loadshape object. If this is not specified, the Daily dispatch shape,
        /// if any, is repeated during Yearly solution modes. In the default dispatch
        /// mode, the PVSystem element uses this loadshape to trigger State changes.
        /// </summary>
        public string yearly
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_yearly(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_yearly(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Temperature shape to use for daily simulations. Must be previously defined
        /// as a TShape object of 24 hrs, typically. The PVSystem element uses this
        /// TShape to determine the Pmpp from the Pmpp vs T curve. Units must agree
        /// with the Pmpp vs T curve.
        /// </summary>
        public string Tdaily
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_Tdaily(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_Tdaily(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Temperature shape to use for duty cycle dispatch simulations such as for
        /// solar ramp rate studies. Must be previously defined as a TShape object.
        /// Typically would have time intervals of 1-5 seconds. Designate the number
        /// of points to solve using the Set Number=xxxx command. If there are fewer
        /// points in the actual shape, the shape is assumed to repeat. The PVSystem
        /// model uses this TShape to determine the Pmpp from the Pmpp vs T curve.
        /// Units must agree with the Pmpp vs T curve.
        /// </summary>
        public string Tduty
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_Tduty(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_Tduty(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Temperature shape to use for yearly simulations. Must be previously defined
        /// as a TShape object. If this is not specified, the Daily dispatch shape, if
        /// any, is repeated during Yearly solution modes. The PVSystem element uses
        /// this TShape to determine the Pmpp from the Pmpp vs T curve. Units must
        /// agree with the Pmpp vs T curve.
        /// </summary>
        public string Tyearly
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_Tyearly(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_Tyearly(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Returns the current irradiance value for the active PVSystem. Use it to 
        /// know what's the current irradiance value for the PV during a simulation.
        /// </summary>
        public double IrradianceNow
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_IrradianceNow(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets/sets the rated max power of the PV array for 1.0 kW/sq-m irradiance 
        /// and a user-selected array temperature of the active PVSystem.
        /// </summary>
        public double Pmpp
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_PVSystems_Get_Pmpp(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_PVSystems_Set_Pmpp(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Reactors : ContextState
    {

        public Reactors(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Reactor names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Reactors_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Reactor objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Reactor active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Reactor by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Reactor active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Reactor by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// How the reactor data was provided: 1=kvar, 2=R+jX, 3=R and X matrices, 4=sym components.
        /// Depending on this value, only some properties are filled or make sense in the context.
        /// </summary>
        public int SpecType
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_SpecType(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Delta connection or wye?
        /// </summary>
        public bool IsDelta
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Reactors_Get_IsDelta(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_IsDelta(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Indicates whether Rmatrix and Xmatrix are to be considered in parallel.
        /// </summary>
        public bool Parallel
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Reactors_Get_Parallel(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Parallel(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Inductance, mH. Alternate way to define the reactance, X, property.
        /// </summary>
        public double LmH
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_LmH(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_LmH(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// For 2, 3-phase, kV phase-phase. Otherwise specify actual coil rating.
        /// </summary>
        public double kV
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_kV(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_kV(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total kvar, all phases.  Evenly divided among phases. Only determines X. Specify R separately
        /// </summary>
        public double kvar
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_kvar(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_kvar(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of phases.
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of first bus.
        /// Bus2 property will default to this bus, node 0, unless previously specified.
        /// Only Bus1 need be specified for a Yg shunt reactor.
        /// </summary>
        public string Bus1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_Bus1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Bus1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of 2nd bus. Defaults to all phases connected to first bus, node 0, (Shunt Wye Connection) except when Bus2 is specifically defined.
        /// Not necessary to specify for delta (LL) connection
        /// </summary>
        public string Bus2
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_Bus2(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Bus2(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of XYCurve object, previously defined, describing per-unit variation of phase inductance, L=X/w, vs. frequency. Applies to reactance specified by X, LmH, Z, or kvar property. L generally decreases somewhat with frequency above the base frequency, approaching a limit at a few kHz.
        /// </summary>
        public string LCurve
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_LCurve(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_LCurve(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of XYCurve object, previously defined, describing per-unit variation of phase resistance, R, vs. frequency. Applies to resistance specified by R or Z property. If actual values are not known, R often increases by approximately the square root of frequency.
        /// </summary>
        public string RCurve
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_RCurve(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_RCurve(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Resistance (in series with reactance), each phase, ohms. This property applies to REACTOR specified by either kvar or X. See also help on Z.
        /// </summary>
        public double R
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_R(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_R(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Reactance, each phase, ohms at base frequency. See also help on Z and LmH properties.
        /// </summary>
        public double X
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_X(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_X(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Resistance in parallel with R and X (the entire branch). Assumed infinite if not specified.
        /// </summary>
        public double Rp
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reactors_Get_Rp(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Rp(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Resistance matrix, ohms at base frequency. Order of the matrix is the number of phases. Mutually exclusive to specifying parameters by kvar or X.
        /// </summary>
        public double[] Rmatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Get_Rmatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Rmatrix(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Reactance matrix, ohms at base frequency. Order of the matrix is the number of phases. Mutually exclusive to specifying parameters by kvar or X.
        /// </summary>
        public double[] Xmatrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Get_Xmatrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Xmatrix(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Alternative way of defining R and X properties. Enter a 2-element array representing R +jX in ohms.
        /// </summary>
        public double[] Z
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Get_Z_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Z(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Positive-sequence impedance, ohms, as a 2-element array representing a complex number.
        /// 
        /// If defined, Z1, Z2, and Z0 are used to define the impedance matrix of the REACTOR.
        /// 
        /// Z1 MUST BE DEFINED TO USE THIS OPTION FOR DEFINING THE MATRIX.
        /// 
        /// Side Effect: Sets Z2 and Z0 to same values unless they were previously defined.
        /// </summary>
        public double[] Z1
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Get_Z1_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Z1(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Negative-sequence impedance, ohms, as a 2-element array representing a complex number.
        /// 
        /// Used to define the impedance matrix of the REACTOR if Z1 is also specified.
        /// 
        /// Note: Z2 defaults to Z1 if it is not specifically defined. If Z2 is not equal to Z1, the impedance matrix is asymmetrical.
        /// </summary>
        public double[] Z2
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Get_Z2_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Z2(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Zero-sequence impedance, ohms, as a 2-element array representing a complex number.
        /// 
        /// Used to define the impedance matrix of the REACTOR if Z1 is also specified.
        /// 
        /// Note: Z0 defaults to Z1 if it is not specifically defined.
        /// </summary>
        public double[] Z0
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Get_Z0_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reactors_Set_Z0(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Reclosers : ContextState
    {

        public Reclosers(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Recloser names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Reclosers_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Recloser objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Recloser active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Recloser by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Recloser active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Recloser by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public void Close()
        {
            try
            {
                DSS_CAPI.ctx_Reclosers_Close(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void Open()
        {
            try
            {
                DSS_CAPI.ctx_Reclosers_Open(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Ground (3I0) instantaneous trip setting - curve multipler or actual amps.
        /// </summary>
        public double GroundInst
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_GroundInst(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_GroundInst(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Ground (3I0) trip multiplier or actual amps
        /// </summary>
        public double GroundTrip
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_GroundTrip(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_GroundTrip(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of object this Recloser to be monitored.
        /// </summary>
        public string MonitoredObj
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_MonitoredObj(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_MonitoredObj(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Terminal number of Monitored object for the Recloser
        /// </summary>
        public int MonitoredTerm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_MonitoredTerm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_MonitoredTerm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of fast shots
        /// </summary>
        public int NumFast
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_NumFast(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_NumFast(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Phase instantaneous curve multipler or actual amps
        /// </summary>
        public double PhaseInst
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_PhaseInst(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_PhaseInst(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Phase trip curve multiplier or actual amps
        /// </summary>
        public double PhaseTrip
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_PhaseTrip(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_PhaseTrip(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of Doubles: reclose intervals, s, between shots.
        /// </summary>
        public double[] RecloseIntervals
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Get_RecloseIntervals_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of shots to lockout (fast + delayed)
        /// </summary>
        public int Shots
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_Shots(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_Shots(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of the circuit element that is being switched by the Recloser.
        /// </summary>
        public string SwitchedObj
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_SwitchedObj(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_SwitchedObj(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Terminal number of the controlled device being switched by the Recloser
        /// </summary>
        public int SwitchedTerm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Reclosers_Get_SwitchedTerm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_SwitchedTerm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class RegControls : ContextState
    {

        public RegControls(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all RegControl names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_RegControls_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of RegControl objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first RegControl active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active RegControl by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next RegControl active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active RegControl by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_RegControls_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// CT primary ampere rating (secondary is 0.2 amperes)
        /// </summary>
        public double CTPrimary
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_CTPrimary(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_CTPrimary(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time delay [s] after arming before the first tap change. Control may reset before actually changing taps.
        /// </summary>
        public double Delay
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_Delay(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_Delay(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Regulation bandwidth in forward direciton, centered on Vreg
        /// </summary>
        public double ForwardBand
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_ForwardBand(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_ForwardBand(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// LDC R setting in Volts
        /// </summary>
        public double ForwardR
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_ForwardR(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_ForwardR(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Target voltage in the forward direction, on PT secondary base.
        /// </summary>
        public double ForwardVreg
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_ForwardVreg(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_ForwardVreg(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// LDC X setting in Volts
        /// </summary>
        public double ForwardX
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_ForwardX(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_ForwardX(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time delay is inversely adjsuted, proportinal to the amount of voltage outside the regulating band.
        /// </summary>
        public bool IsInverseTime
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_RegControls_Get_IsInverseTime(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_IsInverseTime(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Regulator can use different settings in the reverse direction.  Usually not applicable to substation transformers.
        /// </summary>
        public bool IsReversible
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_RegControls_Get_IsReversible(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_IsReversible(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Maximum tap change per iteration in STATIC solution mode. 1 is more realistic, 16 is the default for a faster soluiton.
        /// </summary>
        public int MaxTapChange
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_MaxTapChange(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_MaxTapChange(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of a remote regulated bus, in lieu of LDC settings
        /// </summary>
        public string MonitoredBus
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_MonitoredBus(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_MonitoredBus(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// PT ratio for voltage control settings
        /// </summary>
        public double PTratio
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_PTratio(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_PTratio(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Bandwidth in reverse direction, centered on reverse Vreg.
        /// </summary>
        public double ReverseBand
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_ReverseBand(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_ReverseBand(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Reverse LDC R setting in Volts.
        /// </summary>
        public double ReverseR
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_ReverseR(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_ReverseR(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Target voltage in the revese direction, on PT secondary base.
        /// </summary>
        public double ReverseVreg
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_ReverseVreg(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_ReverseVreg(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Reverse LDC X setting in volts.
        /// </summary>
        public double ReverseX
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_ReverseX(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_ReverseX(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time delay [s] for subsequent tap changes in a set. Control may reset before actually changing taps.
        /// </summary>
        public double TapDelay
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_TapDelay(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_TapDelay(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer number of the tap that the controlled transformer winding is currentliy on.
        /// </summary>
        public int TapNumber
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_TapNumber(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_TapNumber(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Tapped winding number
        /// </summary>
        public int TapWinding
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_TapWinding(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_TapWinding(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the transformer this regulator controls
        /// </summary>
        public string Transformer
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_Transformer(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_Transformer(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// First house voltage limit on PT secondary base.  Setting to 0 disables this function.
        /// </summary>
        public double VoltageLimit
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_VoltageLimit(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_VoltageLimit(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Winding number for PT and CT connections
        /// </summary>
        public int Winding
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_RegControls_Get_Winding(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_RegControls_Set_Winding(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Relays : ContextState
    {

        public Relays(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Relay names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Relays_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Relay objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Relay active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Relay by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Relays_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Relay active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Relay by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Relays_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Full name of object this Relay is monitoring.
        /// </summary>
        public string MonitoredObj
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_MonitoredObj(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Relays_Set_MonitoredObj(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of terminal of monitored element that this Relay is monitoring.
        /// </summary>
        public int MonitoredTerm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_MonitoredTerm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Relays_Set_MonitoredTerm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of element that will be switched when relay trips.
        /// </summary>
        public string SwitchedObj
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_SwitchedObj(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Relays_Set_SwitchedObj(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Terminal number of the switched object that will be opened when the relay trips.
        /// </summary>
        public int SwitchedTerm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Relays_Get_SwitchedTerm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Relays_Set_SwitchedTerm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Sensors : ContextState
    {

        public Sensors(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Sensor names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Sensors_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Sensor objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Sensor active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Sensor by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Sensor active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Sensor by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_Sensors_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void ResetAll()
        {
            try
            {
                DSS_CAPI.ctx_Sensors_ResetAll(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Array of doubles for the line current measurements; don't use with kWS and kVARS.
        /// </summary>
        public double[] Currents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Get_Currents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_Currents(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// True if measured voltages are line-line. Currents are always line currents.
        /// </summary>
        public bool IsDelta
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Sensors_Get_IsDelta(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_IsDelta(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full Name of the measured element
        /// </summary>
        public string MeteredElement
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_MeteredElement(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_MeteredElement(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of the measured terminal in the measured element.
        /// </summary>
        public int MeteredTerminal
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_MeteredTerminal(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_MeteredTerminal(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Assumed percent error in the Sensor measurement. Default is 1.
        /// </summary>
        public double PctError
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_PctError(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_PctError(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// True if voltage measurements are 1-3, 3-2, 2-1.
        /// </summary>
        public bool ReverseDelta
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Sensors_Get_ReverseDelta(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_ReverseDelta(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Weighting factor for this Sensor measurement with respect to other Sensors. Default is 1.
        /// </summary>
        public double Weight
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_Weight(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_Weight(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles for Q measurements. Overwrites Currents with a new estimate using kWS.
        /// </summary>
        public double[] kVARS
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Get_kVARS_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_kVARS(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles for the LL or LN (depending on Delta connection) voltage measurements.
        /// </summary>
        public double[] kVS
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Get_kVS_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_kVS(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Voltage base for the sensor measurements. LL for 2 and 3-phase sensors, LN for 1-phase sensors.
        /// </summary>
        public double kVbase
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Sensors_Get_kVbase(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_kVbase(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles for P measurements. Overwrites Currents with a new estimate using kVARS.
        /// </summary>
        public double[] kWS
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Get_kWS_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Set_kWS(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class SwtControls : ContextState
    {

        public SwtControls(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all SwtControl names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_SwtControls_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of SwtControl objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first SwtControl active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active SwtControl by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next SwtControl active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active SwtControl by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_SwtControls_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Open or Close the switch. No effect if switch is locked.  However, Reset removes any lock and then closes the switch (shelf state).
        /// </summary>
        public int Action
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_Action(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_Action(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time delay [s] betwen arming and opening or closing the switch.  Control may reset before actually operating the switch.
        /// </summary>
        public double Delay
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_Delay(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_Delay(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// The lock prevents both manual and automatic switch operation.
        /// </summary>
        public bool IsLocked
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_SwtControls_Get_IsLocked(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_IsLocked(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set Normal state of switch (see actioncodes) dssActionOpen or dssActionClose
        /// </summary>
        public int NormalState
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_NormalState(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_NormalState(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set it to force the switch to a specified state, otherwise read its present state.
        /// </summary>
        public int State
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_State(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_State(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of the switched element.
        /// </summary>
        public string SwitchedObj
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_SwitchedObj(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_SwitchedObj(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Terminal number where the switch is located on the SwitchedObj
        /// </summary>
        public int SwitchedTerm
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_SwtControls_Get_SwitchedTerm(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_SwitchedTerm(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class TSData : ContextState
    {

        public TSData(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all TSData names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_TSData_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of TSData objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first TSData active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active TSData by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next TSData active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active TSData by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Emergency ampere rating
        /// </summary>
        public double EmergAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_EmergAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_EmergAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Normal Ampere rating
        /// </summary>
        public double NormAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_NormAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_NormAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Rdc
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_Rdc(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_Rdc(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Rac
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_Rac(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_Rac(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double GMRac
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_GMRac(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_GMRac(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int GMRUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_GMRUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_GMRUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Radius
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_Radius(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_Radius(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int RadiusUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_RadiusUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_RadiusUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int ResistanceUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_ResistanceUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_ResistanceUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Diameter
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_Diameter(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_Diameter(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double EpsR
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_EpsR(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_EpsR(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double InsLayer
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_InsLayer(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_InsLayer(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double DiaIns
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_DiaIns(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_DiaIns(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double DiaCable
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_DiaCable(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_DiaCable(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double DiaShield
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_DiaShield(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_DiaShield(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double TapeLayer
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_TapeLayer(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_TapeLayer(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double TapeLap
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_TSData_Get_TapeLap(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_TSData_Set_TapeLap(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Text : ContextState
    {

        public Text(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Input command string for the DSS.
        /// </summary>
        public string Command
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Text_Get_Command(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Text_Set_Command(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Result string for the last command.
        /// </summary>
        public string Result
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Text_Get_Result(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Topology : ContextState
    {

        public Topology(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Returns index of the active branch
        /// </summary>
        public int ActiveBranch
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_ActiveBranch(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Topological depth of the active branch
        /// </summary>
        public int ActiveLevel
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_ActiveLevel(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of all isolated branch names.
        /// </summary>
        public string[] AllIsolatedBranches
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Topology_Get_AllIsolatedBranches);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of all isolated load names.
        /// </summary>
        public string[] AllIsolatedLoads
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Topology_Get_AllIsolatedLoads);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of all looped element names, by pairs.
        /// </summary>
        public string[] AllLoopedPairs
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Topology_Get_AllLoopedPairs);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// MOve back toward the source, return index of new active branch, or 0 if no more.
        /// </summary>
        public int BackwardBranch
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_BackwardBranch(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the active branch.
        /// </summary>
        public string BranchName
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_BranchName(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Topology_Set_BranchName(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set the active branch to one containing this bus, return index or 0 if not found
        /// </summary>
        public string BusName
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_BusName(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Topology_Set_BusName(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first branch active, returns 0 if none.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// First load at the active branch, return index or 0 if none.
        /// </summary>
        public int FirstLoad
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_FirstLoad(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Move forward in the tree, return index of new active branch or 0 if no more
        /// </summary>
        public int ForwardBranch
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_ForwardBranch(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Move to looped branch, return index or 0 if none.
        /// </summary>
        public int LoopedBranch
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_LoopedBranch(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next branch active, returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Next load at the active branch, return index or 0 if no more.
        /// </summary>
        public int NextLoad
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_NextLoad(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of isolated branches (PD elements and capacitors).
        /// </summary>
        public int NumIsolatedBranches
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_NumIsolatedBranches(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of isolated loads
        /// </summary>
        public int NumIsolatedLoads
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_NumIsolatedLoads(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of loops
        /// </summary>
        public int NumLoops
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_NumLoops(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Move to directly parallel branch, return index or 0 if none.
        /// </summary>
        public int ParallelBranch
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Topology_Get_ParallelBranch(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Transformers : ContextState
    {

        public Transformers(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Transformer names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Transformers_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Transformer objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Transformer active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Transformer by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Transformer active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Transformer by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Active Winding delta or wye connection?
        /// </summary>
        public bool IsDelta
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Transformers_Get_IsDelta(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_IsDelta(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding maximum tap in per-unit.
        /// </summary>
        public double MaxTap
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_MaxTap(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_MaxTap(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding minimum tap in per-unit.
        /// </summary>
        public double MinTap
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_MinTap(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_MinTap(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding number of tap steps betwein MinTap and MaxTap.
        /// </summary>
        public int NumTaps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_NumTaps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_NumTaps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of windings on this transformer. Allocates memory; set or change this property first.
        /// </summary>
        public int NumWindings
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_NumWindings(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_NumWindings(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding resistance in %
        /// </summary>
        public double R
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_R(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_R(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding neutral resistance [ohms] for wye connections. Set less than zero for ungrounded wye.
        /// </summary>
        public double Rneut
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Rneut(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_Rneut(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding tap in per-unit.
        /// </summary>
        public double Tap
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Tap(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_Tap(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding Number from 1..NumWindings. Update this before reading or setting a sequence of winding properties (R, Tap, kV, kVA, etc.)
        /// </summary>
        public int Wdg
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Wdg(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_Wdg(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of an XfrmCode that supplies electircal parameters for this Transformer.
        /// </summary>
        public string XfmrCode
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_XfmrCode(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_XfmrCode(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Percent reactance between windings 1 and 2, on winding 1 kVA base. Use for 2-winding or 3-winding transformers.
        /// </summary>
        public double Xhl
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Xhl(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_Xhl(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Percent reactance between windigns 1 and 3, on winding 1 kVA base.  Use for 3-winding transformers only.
        /// </summary>
        public double Xht
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Xht(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_Xht(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Percent reactance between windings 2 and 3, on winding 1 kVA base. Use for 3-winding transformers only.
        /// </summary>
        public double Xlt
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Xlt(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_Xlt(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding neutral reactance [ohms] for wye connections.
        /// </summary>
        public double Xneut
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_Xneut(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_Xneut(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding kV rating.  Phase-phase for 2 or 3 phases, actual winding kV for 1 phase transformer.
        /// </summary>
        public double kV
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_kV(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_kV(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Active Winding kVA rating. On winding 1, this also determines normal and emergency current ratings for all windings.
        /// </summary>
        public double kVA
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_kVA(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_kVA(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of voltages for active winding
        /// </summary>
        public double[] WdgVoltages
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Get_WdgVoltages_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// All Winding currents (ph1, wdg1, wdg2,... ph2, wdg1, wdg2 ...)
        /// </summary>
        public double[] WdgCurrents
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Get_WdgCurrents_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// All winding currents in CSV string form like the WdgCurrents property
        /// </summary>
        public string strWdgCurrents
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_strWdgCurrents(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Transformer Core Type: 0=shell;1 = 1-phase; 3= 3-leg; 5= 5-leg
        /// </summary>
        public int CoreType
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_CoreType(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_CoreType(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// dc Resistance of active winding in ohms for GIC analysis
        /// </summary>
        public double RdcOhms
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Transformers_Get_RdcOhms(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Set_RdcOhms(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array with the losses by type (total losses, load losses, no-load losses), in VA
        /// </summary>
        public double[] LossesByType
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Get_LossesByType_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array with the losses by type (total losses, load losses, no-load losses), in VA, concatenated for ALL transformers
        /// </summary>
        public double[] AllLossesByType
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Transformers_Get_AllLossesByType_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Vsources : ContextState
    {

        public Vsources(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Vsource names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Vsources_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Vsource objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Vsource active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Vsource by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Vsources_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Vsource active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Vsource by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Vsources_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Phase angle of first phase in degrees
        /// </summary>
        public double AngleDeg
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_AngleDeg(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Vsources_Set_AngleDeg(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Source voltage in kV
        /// </summary>
        public double BasekV
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_BasekV(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Vsources_Set_BasekV(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Source frequency in Hz
        /// </summary>
        public double Frequency
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_Frequency(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Vsources_Set_Frequency(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of phases
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Vsources_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Per-unit value of source voltage
        /// </summary>
        public double pu
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Vsources_Get_pu(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Vsources_Set_pu(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class WireData : ContextState
    {

        public WireData(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all WireData names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_WireData_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of WireData objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first WireData active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active WireData by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next WireData active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active WireData by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Emergency ampere rating
        /// </summary>
        public double EmergAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_EmergAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_EmergAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Normal Ampere rating
        /// </summary>
        public double NormAmps
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_NormAmps(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_NormAmps(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Rdc
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_Rdc(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_Rdc(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Rac
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_Rac(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_Rac(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double GMRac
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_GMRac(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_GMRac(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int GMRUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_GMRUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_GMRUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Radius
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_Radius(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_Radius(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int RadiusUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_RadiusUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_RadiusUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int ResistanceUnits
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_ResistanceUnits(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_ResistanceUnits(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public double Diameter
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_Diameter(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_Diameter(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class XYCurves : ContextState
    {

        public XYCurves(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all XYCurve names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_XYCurves_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of XYCurve objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first XYCurve active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active XYCurve by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_Name(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next XYCurve active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active XYCurve by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Get/Set Number of points in X-Y curve
        /// </summary>
        public int Npts
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_Npts(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_Npts(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set X values as a Array of doubles. Set Npts to max number expected if setting
        /// </summary>
        public double[] Xarray
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Get_Xarray_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_Xarray(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Factor to scale X values from original curve
        /// </summary>
        public double Xscale
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_Xscale(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_Xscale(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Amount to shift X value from original curve
        /// </summary>
        public double Xshift
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_Xshift(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_Xshift(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/Set Y values in curve; Set Npts to max number expected if setting
        /// </summary>
        public double[] Yarray
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Get_Yarray_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_Yarray(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Factor to scale Y values from original curve
        /// </summary>
        public double Yscale
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_Yscale(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_Yscale(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Amount to shift Y valiue from original curve
        /// </summary>
        public double Yshift
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_Yshift(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_Yshift(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set X value or get interpolated value after setting Y
        /// </summary>
        public double x
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_x(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_x(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set Y value or get interpolated Y value after setting X
        /// </summary>
        public double y
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_XYCurves_Get_y(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_XYCurves_Set_y(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class YMatrix : ContextState
    {

        public YMatrix(APIUtil util) : base(util)
        {
        }

        public void ZeroInjCurr()
        {
            try
            {
                DSS_CAPI.ctx_YMatrix_ZeroInjCurr(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void GetSourceInjCurrents()
        {
            try
            {
                DSS_CAPI.ctx_YMatrix_GetSourceInjCurrents(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void GetPCInjCurr()
        {
            try
            {
                DSS_CAPI.ctx_YMatrix_GetPCInjCurr(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public void BuildYMatrixD(int BuildOps, int AllocateVI)
        {
            try
            {
                DSS_CAPI.ctx_YMatrix_BuildYMatrixD(ctx, BuildOps, AllocateVI);
            }
            finally
            {
                CheckForError();
            }
        }

        public void AddInAuxCurrents(int SType)
        {
            try
            {
                DSS_CAPI.ctx_YMatrix_AddInAuxCurrents(ctx, SType);
            }
            finally
            {
                CheckForError();
            }
        }

        public bool SystemYChanged
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_YMatrix_Get_SystemYChanged(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_YMatrix_Set_SystemYChanged(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public bool UseAuxCurrents
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_YMatrix_Get_UseAuxCurrents(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_YMatrix_Set_UseAuxCurrents(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

    }

    public class DSSEvents : ContextState
    {

        public DSSEvents(APIUtil util) : base(util)
        {
        }
    }

}
