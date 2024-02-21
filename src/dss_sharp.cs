
// dss_sharp: A compatibility layer for DSS C-API that mimics the official OpenDSS COM interface.
// Copyright (c) 2016-2024 Paulo Meira
// Copyright (c) 2018-2024 DSS-Extensions contributors
//
// See LICENSE for more information.
//
// NOTE: This file is partially generated from other files. If you would like to contribute
//       a patch or suggestion, please open an issue ticket on:
//       https://github.com/dss-extensions/dss_sharp/issues/

using System;
using dss_sharp.detail;
using dss_sharp.native;

namespace dss_sharp
{
    public enum MonitorModes {
        /// <summary>Monitor records Voltage and Current at the terminal (Default)</summary>
        dssVI = 0x00000000,
        /// <summary>Monitor records kW, kvar or kVA, angle values, etc. at the terminal to which it is connected.</summary>
        dssPower = 0x00000001,
        /// <summary>For monitoring Regulator and Transformer taps</summary>
        dssTaps = 0x00000002,
        /// <summary>For monitoring State Variables (for PC Elements only)</summary>
        dssStates = 0x00000003,
        /// <summary>Reports the monitored quantities as sequence quantities</summary>
        dssSequence = 0x00000010,
        /// <summary>Reports the monitored quantities in Magnitude Only</summary>
        dssMagnitude = 0x00000020,
        /// <summary>Reports the Positive Seq only or avg of all phases</summary>
        dssPosOnly = 0x00000040
    };

    public enum SolveModes {
        /// <summary>Solve a single snapshot power flow</summary>
        dssSnapShot = 0,
        /// <summary>Solve following Daily load shapes</summary>
        dssDaily = 1,
        /// <summary>Solve following Yearly load shapes</summary>
        dssYearly = 2,
        /// <summary>Monte Carlo Mode 1</summary>
        dssMonte1 = 3,
        /// <summary>Load-duration Mode 1</summary>
        dssLD1 = 4,
        /// <summary>Solves for Peak Day using Daily load curve</summary>
        dssPeakDay = 5,
        /// <summary>Solve following Duty Cycle load shapes</summary>
        dssDutyCycle = 6,
        /// <summary>Solve direct (forced admittance model)</summary>
        dssDirect = 7,
        /// <summary>Monte carlo Fault Study</summary>
        dssMonteFault = 8,
        /// <summary>Fault study at all buses</summary>
        dssFaultStudy = 9,
        /// <summary>Monte Carlo Mode 2</summary>
        dssMonte2 = 10,
        /// <summary>Monte Carlo Mode 3</summary>
        dssMonte3 = 11,
        /// <summary>Load-Duration Mode 2</summary>
        dssLD2 = 12,
        /// <summary>Auto add generators or capacitors</summary>
        dssAutoAdd = 13,
        /// <summary>Solve for dynamics</summary>
        dssDynamic = 14,
        /// <summary>Harmonic solution mode</summary>
        dssHarmonic = 15
    };

    public enum Options {
        dssPowerFlow = 1,
        dssAdmittance = 2,
        dssNormalSolve = 0,
        dssNewtonSolve = 1,
        dssStatic = 0,
        dssEvent = 1,
        dssTime = 2,
        dssMultiphase = 0,
        dssPositiveSeq = 1,
        dssGaussian = 1,
        dssUniform = 2,
        dssLogNormal = 3,
        dssAddGen = 1,
        dssAddCap = 2,
        dssControlOFF = -1
    };

    public enum CapControlModes {
        /// <summary>Current control, ON and OFF settings on CT secondary</summary>
        dssCapControlCurrent = 0,
        /// <summary>Voltage control, ON and OFF settings on the PT secondary base</summary>
        dssCapControlVoltage = 1,
        /// <summary>kVAR control, ON and OFF settings on PT / CT base</summary>
        dssCapControlKVAR = 2,
        /// <summary>Time control, ON and OFF settings are seconds from midnight</summary>
        dssCapControlTime = 3,
        /// <summary>ON and OFF settings are power factor, negative for leading</summary>
        dssCapControlPF = 4
    };

    public enum ActionCodes {
        /// <summary>No action</summary>
        dssActionNone = 0,
        /// <summary>Open a switch</summary>
        dssActionOpen = 1,
        /// <summary>Close a switch</summary>
        dssActionClose = 2,
        /// <summary>Reset to the shelf state (unlocked, closed for a switch)</summary>
        dssActionReset = 3,
        /// <summary>Lock a switch, preventing both manual and automatic operation</summary>
        dssActionLock = 4,
        /// <summary>Unlock a switch, permitting both manual and automatic operation</summary>
        dssActionUnlock = 5,
        /// <summary>Move a regulator tap up</summary>
        dssActionTapUp = 6,
        /// <summary>Move a regulator tap down</summary>
        dssActionTapDown = 7
    };

    public enum LoadStatus {
        dssLoadVariable = 0,
        dssLoadFixed = 1,
        dssLoadExempt = 2
    };

    public enum LoadModels {
        dssLoadConstPQ = 1,
        dssLoadConstZ = 2,
        dssLoadMotor = 3,
        dssLoadCVR = 4,
        dssLoadConstI = 5,
        dssLoadConstPFixedQ = 6,
        dssLoadConstPFixedX = 7,
        dssLoadZIPV = 8
    };

    public enum LineUnits {
        /// <summary>No line length unit.</summary>
        dssLineUnitsNone = 0,
        /// <summary>Line length units in miles.</summary>
        dssLineUnitsMiles = 1,
        /// <summary>Line length units are in thousand feet.</summary>
        dssLineUnitskFt = 2,
        /// <summary>Line length units are km.</summary>
        dssLineUnitskm = 3,
        /// <summary>Line length units are meters.</summary>
        dssLineUnitsmeter = 4,
        /// <summary>Line units in feet.</summary>
        dssLineUnitsft = 5,
        /// <summary>Line length units are inches.</summary>
        dssLineUnitsinch = 6,
        /// <summary>Line units are cm.</summary>
        dssLineUnitscm = 7,
        /// <summary>Line length units are mm.</summary>
        dssLineUnitsmm = 8,
        /// <summary>Maximum number of line units constants.</summary>
        dssLineUnitsMaxnum = 9
    };

    public enum SolutionLoadModels { // Solution.LoadModel
        /// <summary>Power Flow load model option</summary>
        PowerFlow = 1,
        /// <summary>Admittance load model option</summary>
        Admittance = 2
    };

    public enum SolutionAlgorithms { // Solution.Algorithm
        /// <summary>Solution algorithm option - Normal solution mode</summary>
        NormalSolve = 0,
        /// <summary>Solution algorithm option - Newton solution</summary>
        NewtonSolve = 1
    };

    public enum ControlModes { // Solution.ControlMode
        /// <summary>Control Mode option - Static)</summary>
        Static = 0,
        /// <summary>Control Mode Option - Event driven solution mode)</summary> 
        Event = 1,
        /// <summary>Control mode option - Time driven mode)</summary> 
        Time = 2, 
        /// <summary>Control mode option - Multirate mode)</summary>
        Multirate = 3, 
        /// <summary>Control Mode OFF)</summary>
        ControlOff = -1
    };

    public enum CktModels { // Settings.CktModel
        /// <summary>Circuit model is multiphase (default)</summary>
        Multiphase = 0,
        /// <summary>Circuit model is positive sequence model only</summary>
        PositiveSeq = 1 
    };

    public enum RandomModes { // Solution.Random
        Gaussian = 1, // Gaussian
        Uniform = 2, // Uniform
        LogNormal = 3 // Log normal
    };

    public enum AutoAddTypes { // Solution.AddType
        /// <summary>Add generators in AutoAdd mode</summary>
        AddGen = 1,
        /// <summary>Add capacitors in AutoAdd mode</summary>
        AddCap = 2
    };

    public enum GeneratorStatus {
        Variable = 0,
        Fixed = 1
    };

    public enum YMatrixModes { // Solution.BuildYMatrix, YMatrix.BuildYMatrixD
        SeriesOnly = 1,
        WholeMatrix = 2
    };

    public enum StorageStates { // Storages.State
        Charging = -1,
        Idling = 0,
        Discharging = 1
    };

    // EXPERIMENTAL: For message/write callbacks
    public enum DSSMessageType {
        Error = -1,
        General = 0,
        Info = 1,
        Help = 2,
        Progress = 3,
        ProgressCaption = 4,
        ProgressFormCaption = 5,
        ProgressPercent = 6,
        FireOffEditor = 7
    };

    [Flags]
    public enum DSSJSONFlags {
        /// <summary>Return all properties, regardless of order or if the property was filled by the user</summary>
        Full = 0x00000001,
        /// <summary>Skip redundant properties</summary>
        SkipRedundant = 0x00000002,
        /// <summary>Return enums as integers instead of strings</summary>
        EnumAsInt = 0x00000004,
        /// <summary>Use full names for the elements, including the class name</summary>
        FullNames = 0x00000008,
        /// <summary>Try to "pretty" format the JSON output</summary>
        Pretty = 0x00000010,
        /// <summary>Exclude disabled elements (only valid when exporting a collection)</summary>
        ExcludeDisabled = 0x00000020,
        /// <summary>Add "DSSClass" property to the output objects</summary>
        IncludeDSSClass = 0x00000040,
        /// <summary>Use lowercase representation for the property names (and other keys) instead of the internal variants.</summary>
        LowercaseKeys = 0x00000080,
        /// <summary>
        /// Include default unchanged objects in the exports. 
        /// Any default object that has been edited is always exported. Affects whole circuit and batch exports.
        /// </summary>
        IncludeDefaultObjs = 0x00000100,
        /// <summary>Skip timestamp/version comment, which is added a pre-command by default. Affects whole circuit exports.</summary>
        SkipTimestamp = 0x00000200,
        /// <summary>Skip exporting buses. Affects whole circuit exports.</summary>
        SkipBuses = 0x00000400
    };

    public enum BatchOperation {
        Set = 0,
        Multiply = 1,
        Increment = 2
    };

    public enum SolverOptions {
        // The values themselves are subject to change in future versions,
        // use this enum for easier upgrades
        /// <summary>Default mode, rebuilding everything</summary>
        ReuseNothing = 0,
        /// <summary>Reuse only the prepared CSC matrix</summary>
        ReuseCompressedMatrix = 1,
        /// <summary>Reuse the symbolic factorization, implies ReuseCompressedMatrix</summary>
        ReuseSymbolicFactorization = 2,
        /// <summary>Reuse the numeric factorization, implies ReuseSymbolicFactorization</summary>
        ReuseNumericFactorization = 3,
        /// <summary>Bit flag, see CktElement.pas</summary>
        AlwaysResetYPrimInvalid = 0x10000000
    };

    [Flags]
    public enum DSSCompatFlags {
        /// <summary>
        /// If enabled, don't check for NaNs in the inner solution loop. 
        /// This can lead to various errors. 
        /// This flag is useful for legacy applications that don't handle OpenDSS API errors properly.
        /// Through the development of DSS-Extensions, we noticed this is actually a quite common issue.
        /// </summary>
        NoSolverFloatChecks = 0x00000001,

        /// <summary>
        /// If enabled, toggle worse precision for certain aspects of the engine. For example, the sequence-to-phase 
        /// (`As2p`) and sequence-to-phase (`Ap2s`) transform matrices. On DSS C-API, we fill the matrix explicitly
        /// using higher precision, while numerical inversion of an initially worse precision matrix is used in the 
        /// official OpenDSS. We will introduce better precision for other aspects of the engine in the future, 
        /// so this flag can be used to toggle the old/bad values where feasible.
        /// </summary>
        BadPrecision = 0x00000002,

        /// <summary>
        /// Toggle some InvControl behavior introduced in OpenDSS 9.6.1.1. It could be a regression 
        /// but needs further investigation, so we added this flag in the time being.
        /// </summary>
        InvControl9611 = 0x00000004,

        /// <summary>
        /// When using "save circuit", the official OpenDSS always includes the "CalcVoltageBases" command in the
        /// saved script. We found that it is not always a good idea, so we removed the command (leaving it commented).
        /// Use this flag to enable the command in the saved script.
        /// </summary>
        SaveCalcVoltageBases = 0x00000008

    };

    /// <summary>
    /// This enum is used in the PropertyNameStyle property to control the naming convention.
    /// Currently, this only affects capitalization, i.e., if you software already uses case
    /// insensitive string comparisons for the property names, this is not useful. Otherwise,
    /// you can use `Legacy` to use the older names.
    /// </summary>
    public enum DSSPropertyNameStyle {
        /// <summary>
        /// By default, the modern names are used. The names were reviewed to try to reach a convention across all components.
        /// </summary>
        Modern = 0,

        /// <summary>
        /// Use all lowercase strings.
        /// </summary>
        Lowercase = 1,

        /// <summary>
        /// Use the previous capitalization of the property names.
        /// </summary>
        Legacy = 2
    };

    /// <summary>
    /// DSSSaveFlags are bit flags used in the Circuit_Save function to
    /// customize the saved circuit.
    /// </summary>
    [Flags]
    public enum DSSSaveFlags {
        /// <summary>Include the command CalcVoltageBases.</summary>
        CalcVoltageBases = 0x0001,

        /// <summary>Include commands to set the voltage bases individually.</summary>
        SetVoltageBases = 0x0002,

        /// <summary>Include most of the options (from the Set/Get DSS commands).</summary>
        IncludeOptions = 0x0004,

        /// <summary>Include disabled circuit elements (and LoadShapes).</summary>
        IncludeDisabled = 0x0008,

        /// <summary>Exclude default DSS items if they are not modified by the user.</summary>
        ExcludeDefault = 0x0010,

        /// <summary>Use a single file instead of a folder for output.</summary>
        SingleFile = 0x0020,

        /// <summary>Save the circuit elements in the order they were loaded in the active circuit. Guarantees better reproducibility, especially when the system is ill-conditioned. Requires "SingleFile" flag.</summary>
        KeepOrder = 0x0040,

        /// <summary>Do not export meter zones (as "feeders") separately. Has no effect when using a single file.</summary>
        ExcludeMeterZones = 0x0080,

        /// <summary>Export commands to open terminals of elements.</summary>
        IsOpen = 0x0100,

        /// <summary>Export to the result string. Requires "SingleFile" flag.</summary>
        ToString = 0x0200,
    };

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

        /// <summary>
        /// Return a unique node number at the active bus to avoid node collisions and adds 
        /// it to the node list for the bus.
        /// 
        /// Original COM help: https://opendss.epri.com/GetUniqueNodeNumber.html
        /// </summary>
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

        /// <summary>
        /// Refreshes the Zsc matrix for the active bus.
        /// 
        /// Original COM help: https://opendss.epri.com/ZscRefresh.html
        /// </summary>
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
        /// Indicates whether a coordinate has been defined for this bus
        /// 
        /// Original COM help: https://opendss.epri.com/Coorddefined.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/CplxSeqVoltages.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Cust_Duration.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Cust_Interrupts.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Distance.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Int_Duration.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Isc.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Lambda.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/N_Customers.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/N_interrupts.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Name1.html
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Bus_Get_Name(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Integer Array of Node Numbers defined at the bus in same order as the voltages.
        /// 
        /// Original COM help: https://opendss.epri.com/Nodes.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumNodes.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SectionID.html
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
        /// Double Array of sequence voltages at this bus. Magnitudes only.
        /// 
        /// Original COM help: https://opendss.epri.com/SeqVoltages.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/TotalMiles.html
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
        /// For 2- and 3-phase buses, returns array of complex numbers representing L-L voltages in volts. Returns -1.0 for 1-phase bus. If more than 3 phases, returns only first 3.
        /// 
        /// Original COM help: https://opendss.epri.com/VLL.html
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
        /// Array of doubles containing voltages in Magnitude (VLN), angle (degrees) 
        /// 
        /// Original COM help: https://opendss.epri.com/VMagAngle.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Voc.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Voltages.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/YscMatrix.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Zsc0.html
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
        /// Complex Positive-Sequence short circuit impedance at bus.
        /// 
        /// Original COM help: https://opendss.epri.com/Zsc1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ZscMatrix.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kVBase.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/puVLL.html
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
        /// Array of doubles containing voltage magnitude, angle (degrees) pairs in per unit
        /// 
        /// Original COM help: https://opendss.epri.com/puVmagAngle.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/puVoltages.html
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
        /// Array of doubles (complex) containing the complete 012 Zsc matrix. 
        /// Only available after Zsc is computed, either through the "ZscRefresh" command, or running a "FaultStudy" solution.
        /// Only available for buses with 3 nodes.
        /// 
        /// Original COM help: https://opendss.epri.com/ZSC012Matrix.html
        /// </summary>
        public double[] ZSC012Matrix
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Bus_Get_ZSC012Matrix_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// X Coordinate for bus
        /// 
        /// Original COM help: https://opendss.epri.com/x.html
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
        /// Y coordinate for bus
        /// 
        /// Original COM help: https://opendss.epri.com/y.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LoadList.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LineList.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_CNData_Get_Name(ctx));
                }
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
                    return /*LineUnits*/(DSS_CAPI.ctx_CNData_Get_GMRUnits(ctx));
                }
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
                    return /*LineUnits*/(DSS_CAPI.ctx_CNData_Get_RadiusUnits(ctx));
                }
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
                    return /*LineUnits*/(DSS_CAPI.ctx_CNData_Get_ResistanceUnits(ctx));
                }
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Capacitors_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/AvailableSteps.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/IsDelta.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumSteps.html
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
        /// An array of integers [0..NumSteps-1] indicating state of each step. If the read value is -1 an error has occurred.
        /// 
        /// Original COM help: https://opendss.epri.com/States.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kV.html
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

        /// <summary>
        /// Value as return and error code in Code parameter. For PCElement, get the value of a variable by integer index. If Code>0 then no variable by this index or not a PCelement.
        /// </summary>
        public double VariableByIndex(int Idx, ref int Code)
        {
            return Variablei(Idx, ref Code);
        }

        /// <summary>
        /// Value as return and error code in Code parameter. For PCElement, get the value of a variable by name. If Code>0 then no variable by this name or not a PCelement.
        /// </summary>
        public double VariableByName(string Name, ref int Code)
        {
            return Variable(Name, ref Code);
        }

        /// <summary>
        /// Set the Value of a variable by indx if a PCElement. If Code>0 then no variable by this index or not a PCelement.
        /// </summary>
        public void VariableByIndex(int Idx, ref int Code, double Value)
        {
            try
            {
                DSS_CAPI.ctx_CktElement_Set_Variablei(ctx, Idx, ref Code, Value);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Set the Value of a variable by name if a PCElement. If Code>0 then no variable by this name or not a PCelement.
        /// </summary>
        public void VariableByName(string Name, ref int Code, double Value)
        {
            try
            {
                DSS_CAPI.ctx_CktElement_Set_Variable(ctx, Name, ref Code, Value);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Close the specified terminal and phase, if non-zero, or all conductors at the terminal.
        /// 
        /// Original COM help: https://opendss.epri.com/Close1.html
        /// </summary>
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
                return APIUtil.get_string(DSS_CAPI.ctx_CktElement_Get_Controller(ctx, idx));
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

        /// <summary>
        /// Open the specified terminal and phase, if non-zero, or all conductors at the terminal.
        /// 
        /// Original COM help: https://opendss.epri.com/Open1.html
        /// </summary>
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllPropertyNames.html
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
        /// Array of strings listing all the published state variable names.
        /// Valid only for PCElements.
        /// 
        /// Original COM help: https://opendss.epri.com/AllVariableNames.html
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
        /// Valid only for PCElements.
        /// 
        /// Original COM help: https://opendss.epri.com/AllVariableValues.html
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
        /// Bus definitions to which each terminal is connected.
        /// 
        /// Original COM help: https://opendss.epri.com/BusNames.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/CplxSeqCurrents.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/CplxSeqVoltages1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Currents1.html
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
        /// Currents in magnitude, angle (degrees) format as a array of doubles.
        /// 
        /// Original COM help: https://opendss.epri.com/CurrentsMagAng.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/DisplayName.html
        /// </summary>
        public string DisplayName
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_CktElement_Get_DisplayName(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/EmergAmps.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Enabled.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/EnergyMeter.html
        /// </summary>
        public string EnergyMeter
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_CktElement_Get_EnergyMeter(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// globally unique identifier for this object
        /// 
        /// Original COM help: https://opendss.epri.com/GUID.html
        /// </summary>
        public string GUID
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_CktElement_Get_GUID(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Pointer to this object
        /// 
        /// Original COM help: https://opendss.epri.com/Handle.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/HasOCPDevice.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/HasSwitchControl.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/HasVoltControl.html
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
        /// Total losses in the element: two-element double array (complex), in VA (watts, vars)
        /// 
        /// Original COM help: https://opendss.epri.com/Losses1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Name4.html
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_CktElement_Get_Name(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of integer containing the node numbers (representing phases, for example) for each conductor of each terminal. 
        /// 
        /// Original COM help: https://opendss.epri.com/NodeOrder.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NormalAmps.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumConductors.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumControls.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumPhases.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumProperties.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumTerminals.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/OCPDevIndex.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/OCPDevType.html
        /// </summary>
        public int OCPDevType
        {
            get
            {
                try
                {
                    return /*OCPDevType*/(DSS_CAPI.ctx_CktElement_Get_OCPDevType(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Complex array of losses (kVA) by phase
        /// 
        /// Original COM help: https://opendss.epri.com/PhaseLosses.html
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
        /// Complex array of powers (kVA) into each conductor of each terminal
        /// 
        /// Original COM help: https://opendss.epri.com/Powers.html
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
        /// Residual currents for each terminal: (magnitude, angle in degrees)
        /// 
        /// Original COM help: https://opendss.epri.com/Residuals.html
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
        /// Double array of symmetrical component currents (magnitudes only) into each 3-phase terminal
        /// 
        /// Original COM help: https://opendss.epri.com/SeqCurrents.html
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
        /// Complex array of sequence powers (kW, kvar) into each 3-phase terminal
        /// 
        /// Original COM help: https://opendss.epri.com/SeqPowers.html
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
        /// Double array of symmetrical component voltages (magnitudes only) at each 3-phase terminal
        /// 
        /// Original COM help: https://opendss.epri.com/SeqVoltages1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Voltages1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/VoltagesMagAng.html
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
        /// YPrim matrix, column order, complex numbers
        /// 
        /// Original COM help: https://opendss.epri.com/Yprim.html
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
        /// 
        /// **(API Extension)**
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
        /// Returns an array with the total powers (complex, kVA) at ALL terminals of the active circuit element.
        /// 
        /// Original COM help: https://opendss.epri.com/TotalPowers.html
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

        /// <summary>
        /// Array of integers, a copy of the internal NodeRef of the CktElement.
        /// 
        /// **(API Extension)**
        /// </summary>
        public int[] NodeRef
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_CktElement_Get_NodeRef_GR(ctx);
                    return apiutil.get_int32_gr_array();
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Generators_Get_Name(ctx));
                }
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
        /// Indicates whether the generator is forced ON regardless of other dispatch criteria.
        /// 
        /// Original COM help: https://opendss.epri.com/ForcedON.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Model.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PF.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Phases.html
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
        /// 
        /// See also the enum `GeneratorRegisters`.
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
        /// Array of values in generator energy meter registers.
        /// 
        /// Original COM help: https://opendss.epri.com/RegisterValues.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Vmaxpu.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Vminpu.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kV1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kVArated.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kW.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kvar.html
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

        /// <summary>
        /// Name of the loadshape for a daily generation profile.
        /// 
        /// **(API Extension)**
        /// </summary>
        public string daily
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Generators_Get_daily(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_daily(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of the loadshape for a duty cycle simulation.
        /// 
        /// **(API Extension)**
        /// </summary>
        public string duty
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Generators_Get_duty(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_duty(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of yearly loadshape
        /// 
        /// **(API Extension)**
        /// </summary>
        public string Yearly
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Generators_Get_Yearly(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Yearly(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Response to dispatch multipliers: Fixed=1 (dispatch multipliers do not apply), Variable=0 (follows curves).
        /// 
        /// Related enumeration: GeneratorStatus
        /// 
        /// **(API Extension)**
        /// </summary>
        public GeneratorStatus Status
        {
            get
            {
                try
                {
                    return (GeneratorStatus)(DSS_CAPI.ctx_Generators_Get_Status(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Status(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Generator connection. True/1 if delta connection, False/0 if wye.
        /// 
        /// **(API Extension)**
        /// </summary>
        public bool IsDelta
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_Generators_Get_IsDelta(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_IsDelta(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// kVA rating of electrical machine. Applied to machine or inverter definition for Dynamics mode solutions.
        /// 
        /// **(API Extension)**
        /// </summary>
        public double kva
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_kva(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_kva(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// An arbitrary integer number representing the class of Generator so that Generator values may be segregated by class.
        /// 
        /// **(API Extension)**
        /// </summary>
        public int Class
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Generators_Get_Class_(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Class_(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Bus to which the Generator is connected. May include specific node specification.
        /// 
        /// **(API Extension)**
        /// </summary>
        public string Bus1
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Generators_Get_Bus1(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Generators_Set_Bus1(ctx, value);
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Lines_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Bus1.html
        /// </summary>
        public string Bus1
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Lines_Get_Bus1(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Bus2.html
        /// </summary>
        public string Bus2
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Lines_Get_Bus2(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/C0.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/C1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/EmergAmps1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Geometry.html
        /// </summary>
        public string Geometry
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Lines_Get_Geometry(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Length.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LineCode.html
        /// </summary>
        public string LineCode
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Lines_Get_LineCode(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/NormAmps.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumCust.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Parent.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Phases1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/R0.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/R1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Rg.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Rho.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Rmatrix.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Spacing.html
        /// </summary>
        public string Spacing
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Lines_Get_Spacing(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/TotalCust.html
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
                    return /*LineUnits*/(DSS_CAPI.ctx_Lines_Get_Units(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/X0.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/X1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xg.html
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

        /// <summary>
        /// Reactance matrix (full), ohms per unit length. Array of doubles.
        /// 
        /// Original COM help: https://opendss.epri.com/Xmatrix.html
        /// </summary>
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
        /// Yprimitive for the active line object (complex array).
        /// 
        /// Original COM help: https://opendss.epri.com/Yprim1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SeasonRating.html
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
        /// 
        /// **(API Extension)**
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
        /// 
        /// **NOTE**: for DSS-Extensions, we are considering removing this option in a future 
        /// release since it has performance impacts even when not used.
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
        /// 
        /// Original COM help: https://opendss.epri.com/AutoBusList.html
        /// </summary>
        public string AutoBusList
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Settings_Get_AutoBusList(ctx));
                }
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
        /// Indicate if the circuit model is positive sequence.
        /// 
        /// Original COM help: https://opendss.epri.com/CktModel.html
        /// </summary>
        public int CktModel
        {
            get
            {
                try
                {
                    return /*CktModels*/(DSS_CAPI.ctx_Settings_Get_CktModel(ctx));
                }
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
        /// Denotes whether to trace the control actions to a file.
        /// 
        /// Original COM help: https://opendss.epri.com/ControlTrace.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/EmergVmaxpu.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/EmergVminpu.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LossRegs.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LossWeight.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NormVmaxpu.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NormVminpu.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PriceCurve.html
        /// </summary>
        public string PriceCurve
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Settings_Get_PriceCurve(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/PriceSignal.html
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
        /// Gets value of trapezoidal integration flag in energy meters. Defaults to false.
        /// 
        /// Original COM help: https://opendss.epri.com/Trapezoidal.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/UEregs.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/UEweight.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/VoltageBases.html
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
        /// Locks Zones on energy meters to prevent rebuilding if a circuit change occurs.
        /// 
        /// Original COM help: https://opendss.epri.com/ZoneLock.html
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
        /// Controls whether the terminals are checked when updating the currents in Load component. Defaults to true.
        /// If the loads are guaranteed to have their terminals closed throughout the simulation, this can be set to false to save some time.
        /// 
        /// **(API Extension)**
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

        /// <summary>
        /// Controls whether `First`/`Next` iteration includes or skips disabled circuit elements.
        /// The default behavior from OpenDSS is to skip those. The user can still activate the element by name or index.
        /// 
        /// The default value for IterateDisabled is 0, keeping the original behavior.
        /// Set it to 1 (or `True`) to include disabled elements.
        /// Other numeric values are reserved for other potential behaviors.
        /// 
        /// **(API Extension)**
        /// </summary>
        public int IterateDisabled
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Settings_Get_IterateDisabled(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Settings_Set_IterateDisabled(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Switch the property names according to the target style.
        ///
        /// Use this method for compatibility with code that doesn't consider that
        /// OpenDSS is case insensitive.
        /// 
        /// **(API Extension)**
        /// </summary>
        public void SetPropertyNameStyle(DSSPropertyNameStyle value)
        {
            try
            {
                DSS_CAPI.ctx_Settings_SetPropertyNameStyle(ctx, (int)value);
            }
            finally
            {
                CheckForError();
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
        /// 
        /// Original COM help: https://opendss.epri.com/ActiveClassName.html
        /// </summary>
        public string ActiveClassName
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_ActiveClass_Get_ActiveClassName(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings consisting of all element names in the active class.
        /// 
        /// Original COM help: https://opendss.epri.com/AllNames.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Count.html
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
        /// Sets first element in the active class to be the active DSS object. 
        /// If the object is a CktElement, ActiveCktELement also points to this element. 
        /// 
        /// Returns 0 if none.
        /// 
        /// Original COM help: https://opendss.epri.com/First.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Name.html
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_ActiveClass_Get_Name(ctx));
                }
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
        /// Sets next element in active class to be the active DSS object. 
        /// If the object is a CktElement, ActiveCktElement also points to this element.
        /// 
        /// Returns 0 if no more.
        /// 
        /// Original COM help: https://opendss.epri.com/Next.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumElements.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ActiveClassParent.html
        /// </summary>
        public string ActiveClassParent
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_ActiveClass_Get_ActiveClassParent(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }
        /// <summary>
        /// Returns the data (as a list) of all elements from the active class as a JSON-encoded string.
        /// 
        /// The `options` parameter contains bit-flags to toggle specific features.
        /// See `Obj_ToJSON` (C-API) for more.
        /// 
        /// Additionally, the `ExcludeDisabled` flag can be used to excluded disabled elements from the output.
        /// 
        /// **(API Extension)**
        /// </summary>
        public string ToJSON(DSSJSONFlags options=0)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_ActiveClass_ToJSON(ctx, (int)options));
            }
            finally
            {
                CheckForError();
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
                    return APIUtil.get_string(DSS_CAPI.ctx_CapControls_Get_Name(ctx));
                }
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


        /// <summary>
        /// Force a reset of this CapControl.
        /// 
        /// Original COM help: https://opendss.epri.com/Reset.html
        /// </summary>
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
        /// Transducer ratio from primary current to control current.
        /// 
        /// Original COM help: https://opendss.epri.com/CTratio.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Capacitor.html
        /// </summary>
        public string Capacitor
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_CapControls_Get_Capacitor(ctx));
                }
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

        /// <summary>
        /// Dead time after capacitor is turned OFF before it can be turned back ON for the active CapControl.
        /// 
        /// Default is 300 sec.
        /// 
        /// Original COM help: https://opendss.epri.com/DeadTime.html
        /// </summary>
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
        /// 
        /// Original COM help: https://opendss.epri.com/Delay.html
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
        /// Time delay [s] before switching off a step. Control may reset before actually switching.
        /// 
        /// Original COM help: https://opendss.epri.com/DelayOff.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Mode.html
        /// </summary>
        public CapControlModes Mode
        {
            get
            {
                try
                {
                    return (CapControlModes)(DSS_CAPI.ctx_CapControls_Get_Mode(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_CapControls_Set_Mode(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of the element that PT and CT are connected to.
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredObj.html
        /// </summary>
        public string MonitoredObj
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_CapControls_Get_MonitoredObj(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredTerm.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/OFFSetting.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ONSetting.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PTratio.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/UseVoltOverride.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Vmax.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Vmin.html
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
        public Storages Storages;
        public GICSources GICSources;
        public Parallel Parallel;

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
            Storages = new Storages(util);
            GICSources = new GICSources(util);
            Parallel = new Parallel(util);
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

        /// <summary>
        /// Compute the maximum load the active circuit can serve in the PRESENT YEAR.
        /// 
        /// This method uses the EnergyMeter objects with the registers set with the 
        /// `SET UEREGS= (...)` command for the AutoAdd functions. 
        /// 
        /// Returns the metered kW (load + losses - generation) and per unit load multiplier 
        /// for the loading level at which something in the system reports an overload or 
        /// undervoltage. If no violations, then it returns the metered kW for peak load 
        /// for the year (1.0 multiplier). 
        /// 
        /// Aborts and returns 0 if no EnergyMeters.
        /// 
        /// Original COM help: https://opendss.epri.com/Capacity1.html
        /// </summary>
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

        /// <summary>
        /// Disable a circuit element by name (removes from circuit but leave in database).
        /// 
        /// Original COM help: https://opendss.epri.com/Disable.html
        /// </summary>
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

        /// <summary>
        /// Enable a circuit element by name
        /// 
        /// Original COM help: https://opendss.epri.com/Enable.html
        /// </summary>
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

        /// <summary>
        /// Call `EndOfTimeStepCleanup` in SolutionAlgs (Do cleanup, sample monitors, and increment time).
        /// 
        /// Original COM help: https://opendss.epri.com/EndOfTimeStepUpdate.html
        /// </summary>
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

        /// <summary>
        /// Set the first element of active class to be the Active element in the active circuit.
        /// 
        /// Returns 0 if none.
        /// 
        /// Original COM help: https://opendss.epri.com/FirstElement.html
        /// </summary>
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

        /// <summary>
        /// Set the first Power Conversion (PC) element to be the active element.
        /// 
        /// Returns 0 if none.
        /// 
        /// Original COM help: https://opendss.epri.com/FirstPCElement.html
        /// </summary>
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

        /// <summary>
        /// Set the first Power Delivery (PD) element to be the active element.
        /// 
        /// Returns 0 if none.
        /// 
        /// Original COM help: https://opendss.epri.com/FirstPDElement.html
        /// </summary>
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

        /// <summary>
        /// Set the next element of the active class to be the active element in the active circuit.
        /// Returns 0 if no more elements..
        /// 
        /// Original COM help: https://opendss.epri.com/NextElement.html
        /// </summary>
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

        /// <summary>
        /// Get the next Power Conversion (PC) element to be the active element.
        /// 
        /// Original COM help: https://opendss.epri.com/NextPCElement.html
        /// </summary>
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

        /// <summary>
        /// Get the next Power Delivery (PD) element to be the active element.
        /// 
        /// Original COM help: https://opendss.epri.com/NextPDElement.html
        /// </summary>
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

        /// <summary>
        /// Force all Meters and Monitors to take a sample.
        /// 
        /// Original COM help: https://opendss.epri.com/Sample.html
        /// </summary>
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

        /// <summary>
        /// Force all meters and monitors to save their current buffers.
        /// 
        /// Original COM help: https://opendss.epri.com/SaveSample.html
        /// </summary>
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

        /// <summary>
        /// Sets Active bus by name. 
        /// 
        /// Ignores node list. Returns bus index (zero based) compatible with `AllBusNames` and Buses collection.
        /// 
        /// Original COM help: https://opendss.epri.com/SetActiveBus.html
        /// </summary>
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

        /// <summary>
        /// Set ActiveBus by an integer value. 
        /// 
        /// 0-based index compatible with SetActiveBus return value and AllBusNames indexing. 
        /// Returns 0 if OK.
        /// 
        /// Original COM help: https://opendss.epri.com/SetActiveBusi.html
        /// </summary>
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

        /// <summary>
        /// Set the active class by name. 
        /// 
        /// Use FirstElement, NextElement to iterate through the class. Returns -1 if fails.
        /// 
        /// Original COM help: https://opendss.epri.com/SetActiveClass.html
        /// </summary>
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

        /// <summary>
        /// Set the Active Circuit Element using the full object name (e.g. "generator.g1"). 
        /// 
        /// Returns -1 if not found. Else index to be used in CktElements collection or `AllElementNames`.
        /// 
        /// Original COM help: https://opendss.epri.com/SetActiveElement.html
        /// </summary>
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

        /// <summary>
        /// Force an update to all storage classes. 
        /// 
        /// Typically done after a solution. Done automatically in intrinsic solution modes.
        /// 
        /// Original COM help: https://opendss.epri.com/UpdateStorage.html
        /// </summary>
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllBusDistances.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllBusNames.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllBusVmag.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllBusVmagPu.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllBusVolts.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllElementLosses.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllElementNames.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllNodeDistances.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllNodeNames.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LineLosses.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Losses.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Circuit_Get_Name(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Total number of Buses in the circuit.
        /// 
        /// Original COM help: https://opendss.epri.com/NumBuses.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumCktElements.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumNodes1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ParentPDElement.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SubstationLosses.html
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
        /// For large-scale systems, prefer YMatrix.GetCompressedYMatrix.
        /// 
        /// Original COM help: https://opendss.epri.com/SystemY.html
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
        /// Total power (complex), kVA delivered to the circuit
        /// 
        /// Original COM help: https://opendss.epri.com/TotalPower.html
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
        /// Array of doubles containing complex injection currents for the present solution. It is the "I" vector of I=YV
        /// 
        /// Original COM help: https://opendss.epri.com/YCurrents.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/YNodeOrder.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/YNodeVarray.html
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
        /// <summary>
        /// Array of total losses (complex) in a selection of elements.
        /// Use the element indices (starting at 1) as parameter.
        /// 
        /// **(API Extension)**
        /// </summary>
        public double[] ElementLosses(int[] value)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_Get_ElementLosses_GR(ctx, value, value.Length);
                return apiutil.get_float64_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Returns data for all objects and basic circuit properties as a JSON-encoded string.
        /// 
        /// The JSON data is organized using the JSON schema proposed at 
        /// https://github.com/dss-extensions/AltDSS-Schema
        /// 
        /// The `options` parameter contains bit-flags to toggle specific features.
        /// See the enum `DSSJSONFlags` or `Obj_ToJSON` (C-API) for more.
        /// 
        /// **(API Extension)**
        /// </summary>
        public string ToJSON(DSSJSONFlags options=0)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_Circuit_ToJSON(ctx, (int)options));
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Replaces the circuit, if any, with the one provided from a JSON-encoded string.
        /// 
        /// The expected layout is defined from the JSON schema proposed at
        /// https://github.com/dss-extensions/AltDSS-Schema
        /// 
        /// The `options` parameter contains bit-flags to toggle specific features.
        /// See the enum `DSSJSONFlags`.
        /// 
        /// **(API Extension)**
        /// </summary>
        public void FromJSON(string data, DSSJSONFlags options=0)
        {
            try
            {
                DSS_CAPI.ctx_Circuit_FromJSON(ctx, data, (int)options);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Equivalent of the "save circuit" DSS command, but allows customization
        /// through the `saveFlags` argument, which is a set of bit flags. 
        /// See the "DSSSaveFlags" enumeration for available flags:
        /// 
        /// - `CalcVoltageBases`: Include the command CalcVoltageBases.
        /// - `SetVoltageBases`: Include commands to set the voltage bases individually.
        /// - `IncludeOptions`: Include most of the options (from the Set/Get DSS commands).
        /// - `IncludeDisabled`: Include disabled circuit elements (and LoadShapes).
        /// - `ExcludeDefault`: Exclude default DSS items if they are not modified by the user.
        /// - `SingleFile`: Use a single file instead of a folder for output.
        /// - `KeepOrder`: Save the circuit elements in the order they were loaded in the active circuit. Guarantees better reproducibility, especially when the system is ill-conditioned. Requires "SingleFile" flag.
        /// - `ExcludeMeterZones`: Do not export meter zones (as "feeders") separately. Has no effect when using a single file.
        /// - `IsOpen`: Export commands to open terminals of elements.
        /// - `ToString`: to the result string. Requires "SingleFile" flag.
        /// 
        /// If `SingleFile` is enabled, the first argument (`dirOrFilePath`) is the file path,
        /// otherwise it is the folder path. For string output, the argument is not used.
        /// 
        /// **(API Extension)**
        /// </summary>
        public string Save(string dirOrFilePath, DSSSaveFlags options)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_Circuit_Save(ctx, dirOrFilePath, (int)options));
            }
            finally
            {
                CheckForError();
            }
        }
    }

    public class CtrlQueue : ContextState
    {

        public CtrlQueue(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Clear all actions from the Control Proxy's Action List (they are popped off the list). 
        /// 
        /// Original COM help: https://opendss.epri.com/ClearActions.html
        /// </summary>
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

        /// <summary>
        /// Clear the control queue.
        /// 
        /// Original COM help: https://opendss.epri.com/ClearQueue.html
        /// </summary>
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

        /// <summary>
        /// Delete an Action from the DSS Control Queue by the handle that is returned when the action is added.
        /// 
        /// (The Push function returns the handle.)
        /// 
        /// Original COM help: https://opendss.epri.com/Delete.html
        /// </summary>
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

        /// <summary>
        /// Execute all actions currently on the Control Queue. 
        /// 
        /// Side effect: clears the queue.
        /// 
        /// Original COM help: https://opendss.epri.com/DoAllQueue.html
        /// </summary>
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

        /// <summary>
        /// Export the queue to a CSV table and show it.
        /// 
        /// Original COM help: https://opendss.epri.com/Show.html
        /// </summary>
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
        /// Code for the active action. Integer code to tell the control device what to do.
        /// 
        /// Use this to determine what the user-defined controls are supposed to do.
        /// It can be any 32-bit integer of the user's choosing and is the same value that the control pushed onto the control queue earlier.
        /// 
        /// Original COM help: https://opendss.epri.com/ActionCode.html
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
        /// 
        /// The user-written code driving the interface may support more than one 
        /// control element as necessary to perform the simulation. This handle is
        /// an index returned to the user program that lets the program know which
        /// control is to perform the active action.
        /// 
        /// Original COM help: https://opendss.epri.com/DeviceHandle.html
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
        /// Number of Actions on the current action list (that have been popped off the control queue by CheckControlActions)
        /// 
        /// Original COM help: https://opendss.epri.com/NumActions.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Push.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PopAction.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Queue.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/QueueSize.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Action.html
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

    public class DSSElement : ContextState
    {
        public DSSProperty Properties;

        public DSSElement(APIUtil util) : base(util)
        {
            Properties = new DSSProperty(util);
        }

        /// <summary>
        /// Array of strings containing the names of all properties for the active DSS object.
        /// 
        /// Original COM help: https://opendss.epri.com/AllPropertyNames1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Name5.html
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_DSSElement_Get_Name(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Properties for the active DSS object.
        /// 
        /// Original COM help: https://opendss.epri.com/NumProperties1.html
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
        /// <summary>
        /// Returns the properties of the active DSS object as a JSON-encoded string.
        /// 
        /// The `options` parameter contains bit-flags to toggle specific features.
        /// See `Obj_ToJSON` (C-API) for more.
        /// 
        /// **(API Extension)**
        /// </summary>
        public string ToJSON(DSSJSONFlags options=0)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_DSSElement_ToJSON(ctx, (int)options));
            }
            finally
            {
                CheckForError();
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
        /// 
        /// Original COM help: https://opendss.epri.com/Caption.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PctProgress.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Description.html
        /// </summary>
        public string Description
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_DSSProperty_Get_Description(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Name of Property
        /// 
        /// Original COM help: https://opendss.epri.com/Name6.html
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_DSSProperty_Get_Name(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set the value of the active property. The value must be specified as a string.
        /// 
        /// Original COM help: https://opendss.epri.com/Val.html
        /// </summary>
        public string Val
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_DSSProperty_Get_Val(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Command.html
        /// </summary>
        public string Command(int i)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_DSS_Executive_Get_Command(ctx, i));
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get help string for i-th command
        /// 
        /// Original COM help: https://opendss.epri.com/CommandHelp.html
        /// </summary>
        public string CommandHelp(int i)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_DSS_Executive_Get_CommandHelp(ctx, i));
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get i-th option
        /// 
        /// Original COM help: https://opendss.epri.com/Option.html
        /// </summary>
        public string Option(int i)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_DSS_Executive_Get_Option(ctx, i));
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get help string for i-th option
        /// 
        /// Original COM help: https://opendss.epri.com/OptionHelp.html
        /// </summary>
        public string OptionHelp(int i)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_DSS_Executive_Get_OptionHelp(ctx, i));
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get present value of i-th option
        /// 
        /// Original COM help: https://opendss.epri.com/OptionValue.html
        /// </summary>
        public string OptionValue(int i)
        {
            try
            {
                return APIUtil.get_string(DSS_CAPI.ctx_DSS_Executive_Get_OptionValue(ctx, i));
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Number of DSS Executive Commands
        /// 
        /// Original COM help: https://opendss.epri.com/NumCommands.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumOptions.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Description1.html
        /// </summary>
        public string Description
        {
            get
            {
                return APIUtil.get_string(DSS_CAPI.ctx_Error_Get_Description(ctx));
            }
        }

        /// <summary>
        /// Error Number (returns current value and then resets to zero)
        /// 
        /// Original COM help: https://opendss.epri.com/Number.html
        /// </summary>
        public int Number
        {
            get
            {
                return DSS_CAPI.ctx_Error_Get_Number(ctx);
            }
        }

        /// <summary>
        /// EarlyAbort controls whether all errors halts the DSS script processing (Compile/Redirect), defaults to true.
        /// 
        /// **(API Extension)**
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
        /// Controls whether the extended error mechanism is used. Defaults to true.
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
        /// Combined with the automatic exception mapping mechanism (see `UseExceptions`),
        /// a more modern and safe experience is achieved in dss_sharp.
        /// 
        /// The current default state is ON. For compatibility, the user can turn it
        /// off to restore the previous behavior.
        /// 
        /// **(API Extension)**
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

        /// <summary>
        /// UseExceptions controls whether the error numbers from the DSS engine are
        /// automatically mapped to .NET exceptions. The default and recommended state
        /// is `true`, but users can disable this to achieve better compatibility with
        /// old, COM-based code. Note that most code from OpenDSS users "in the wild" 
        /// do not check for errors, so the exception mapping can unearth hidden errors
        /// that were being ignored in old code.
        /// 
        /// NOTE: This is a global, static setting. Affects all DSS instances in the process.
        /// 
        /// (API Extension)
        /// </summary>
        public static bool UseExceptions
        {
            get
            {
                return APIUtil.exceptionsAllowed;
            }
            set
            {
                APIUtil.exceptionsAllowed = value;
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Fuses_Get_Name(ctx));
                }
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


        /// <summary>
        /// Close all phases of the fuse.
        /// 
        /// Original COM help: https://opendss.epri.com/Close3.html
        /// </summary>
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

        /// <summary>
        /// Current state of the fuses. TRUE if any fuse on any phase is blown. Else FALSE.
        /// 
        /// Original COM help: https://opendss.epri.com/IsBlown.html
        /// </summary>
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

        /// <summary>
        /// Manual opening of all phases of the fuse.
        /// 
        /// Original COM help: https://opendss.epri.com/Open2.html
        /// </summary>
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
        /// Reset fuse to normal state.
        /// 
        /// Original COM help: https://opendss.epri.com/Reset7.html
        /// </summary>
        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_Fuses_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// A fixed delay time in seconds added to the fuse blowing time determined by the TCC curve. Default is 0.
        /// This represents a fuse clear or other delay.
        /// 
        /// Original COM help: https://opendss.epri.com/Delay1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredObj1.html
        /// </summary>
        public string MonitoredObj
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Fuses_Get_MonitoredObj(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredTerm1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumPhases1.html
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
        /// 
        /// Multiply current values of TCC curve by this to get actual amps.
        /// 
        /// Original COM help: https://opendss.epri.com/RatedCurrent.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SwitchedObj.html
        /// </summary>
        public string SwitchedObj
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Fuses_Get_SwitchedObj(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/SwitchedTerm.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/TCCcurve.html
        /// </summary>
        public string TCCcurve
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Fuses_Get_TCCcurve(ctx));
                }
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

        /// <summary>
        /// Array of strings indicating the state of each phase of the fuse.
        /// 
        /// Original COM help: https://opendss.epri.com/State2.html
        /// </summary>
        public string[] State
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Fuses_Get_State);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_State(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of strings indicating the normal state of each phase of the fuse.
        /// 
        /// Original COM help: https://opendss.epri.com/NormalState2.html
        /// </summary>
        public string[] NormalState
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Fuses_Get_NormalState);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Fuses_Set_NormalState(ctx, value, value.Length);
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
                    return APIUtil.get_string(DSS_CAPI.ctx_ISources_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Amps.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AngleDeg.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Frequency.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_LineCodes_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/C2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/C3.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Cmatrix1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/EmergAmps2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/IsZ1Z0.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NormAmps1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Phases2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/R2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/R3.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Rmatrix1.html
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
                    return /*LineUnits*/(DSS_CAPI.ctx_LineCodes_Get_Units(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/X2.html
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
        /// Positive-sequence reactance, ohms per unit length
        /// 
        /// Original COM help: https://opendss.epri.com/X3.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xmatrix1.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Monitors_Get_Name(ctx));
                }
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


        /// <summary>
        /// Post-process monitor samples taken so far, e.g., Pst for mode=4.
        /// 
        /// Original COM help: https://opendss.epri.com/Process.html
        /// </summary>
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

        /// <summary>
        /// Post-process all monitor samples taken so far, e.g., Pst for mode=4.
        /// 
        /// Original COM help: https://opendss.epri.com/ProcessAll.html
        /// </summary>
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

        /// <summary>
        /// Reset active Monitor object.
        /// 
        /// Original COM help: https://opendss.epri.com/Reset3.html
        /// </summary>
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

        /// <summary>
        /// Reset all Monitor objects.
        /// 
        /// Original COM help: https://opendss.epri.com/ResetAll1.html
        /// </summary>
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

        /// <summary>
        /// Instruct the active Monitor to take a sample of the present state.
        /// 
        /// Original COM help: https://opendss.epri.com/Sample2.html
        /// </summary>
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

        /// <summary>
        /// Instruct all Monitor objects to take a sample of the present state.
        /// 
        /// Original COM help: https://opendss.epri.com/SampleAll1.html
        /// </summary>
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

        /// <summary>
        /// Instructs the active monitor to save its current sample buffer to its monitor stream. 
        /// 
        /// After the data is on the stream, you can access the ByteStream or channel data. 
        /// 
        /// **Most standard solution modes do this automatically.**
        /// 
        /// Original COM help: https://opendss.epri.com/Save1.html
        /// </summary>
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

        /// <summary>
        /// Instructs the all monitor objects to save their current sample buffers to the respective monitor streams.
        /// 
        /// **Most standard solution modes do this automatically.**
        /// 
        /// Original COM help: https://opendss.epri.com/SaveAll1.html
        /// </summary>
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

        /// <summary>
        /// Convert the monitor data to text and displays it with the text editor.
        /// 
        /// Original COM help: https://opendss.epri.com/Show3.html
        /// </summary>
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
        /// 
        /// Original COM help: https://opendss.epri.com/ByteStream.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Element.html
        /// </summary>
        public string Element
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Monitors_Get_Element(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/FileName.html
        /// </summary>
        public string FileName
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Monitors_Get_FileName(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Monitor File Version (integer)
        /// 
        /// Original COM help: https://opendss.epri.com/FileVersion.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Header.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Mode1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumChannels.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/RecordSize.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SampleCount.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Terminal.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/dblFreq.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/dblHour.html
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

        /// <summary>
        /// Reset the delimiters to their default values.
        /// 
        /// Original COM help: https://opendss.epri.com/ResetDelimiters.html
        /// </summary>
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
        /// Default is FALSE. If TRUE, the parser automatically advances to next token after DblValue, IntValue, or StrValue. Simpler when you don't need to check for parameter names.
        /// 
        /// Original COM help: https://opendss.epri.com/AutoIncrement.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/BeginQuote.html
        /// </summary>
        public string BeginQuote
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Parser_Get_BeginQuote(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/CmdString.html
        /// </summary>
        public string CmdString
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Parser_Get_CmdString(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/DblValue.html
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
        /// String defining hard delimiters used to separate token on the command string. Default is , and =. The = separates token name from token value. These override whitespace to separate tokens.
        /// 
        /// Original COM help: https://opendss.epri.com/Delimiters.html
        /// </summary>
        public string Delimiters
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Parser_Get_Delimiters(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/EndQuote.html
        /// </summary>
        public string EndQuote
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Parser_Get_EndQuote(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/IntValue.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NextParam.html
        /// </summary>
        public string NextParam
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Parser_Get_NextParam(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Return next parameter as a string
        /// 
        /// Original COM help: https://opendss.epri.com/StrValue.html
        /// </summary>
        public string StrValue
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Parser_Get_StrValue(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set the characters used for White space in the command string.  Default is blank and Tab.
        /// 
        /// Original COM help: https://opendss.epri.com/WhiteSpace.html
        /// </summary>
        public string WhiteSpace
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Parser_Get_WhiteSpace(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Zmag.html
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
        /// Keep load flag for Reduction options that remove branches
        /// 
        /// Original COM help: https://opendss.epri.com/KeepLoad.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/EditString.html
        /// </summary>
        public string EditString
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_ReduceCkt_Get_EditString(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/StartPDElement.html
        /// </summary>
        public string StartPDElement
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_ReduceCkt_Get_StartPDElement(ctx));
                }
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
        /// Name of EnergyMeter to use for reduction
        /// 
        /// Original COM help: https://opendss.epri.com/EnergyMeter1.html
        /// </summary>
        public string EnergyMeter
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_ReduceCkt_Get_EnergyMeter(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/DoDefault.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/DoShortLines.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/DoDangling.html
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

        /// <summary>
        /// Break (disable) all the loops found in the active circuit.
        /// 
        /// Disables one of the Line objects at the head of a loop to force the circuit to be radial.
        /// </summary>
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

        /// <summary>
        /// Merge all parallel lines found in the circuit to facilitate its reduction.
        /// </summary>
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

        /// <summary>
        /// Merge Line objects in which the IsSwitch property is true with the down-line Line object.
        /// </summary>
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

        /// <summary>
        /// Remove all 1-phase laterals in the active EnergyMeter's zone.
        /// 
        /// Loads and other shunt elements are moved to the parent 3-phase bus.
        /// </summary>
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

        /// <summary>
        /// Remove (disable) all branches down-line from the active PDElement. 
        /// 
        /// Circuit must have an EnergyMeter on this branch.
        /// If KeepLoad=Y (default), a new Load element is defined and kW, kvar are set to present power flow solution for the first element eliminated. 
        /// The EditString is applied to each new Load element defined.
        /// </summary>
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
        /// 
        /// Original COM help: https://opendss.epri.com/AddType.html
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
        /// Base Solution algorithm
        /// 
        /// Original COM help: https://opendss.epri.com/Algorithm.html
        /// </summary>
        public int Algorithm
        {
            get
            {
                try
                {
                    return /*SolutionAlgorithms*/(DSS_CAPI.ctx_Solution_Get_Algorithm(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Capkvar.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ControlActionsDone.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ControlIterations.html
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
        /// Modes for control devices
        /// 
        /// Original COM help: https://opendss.epri.com/ControlMode.html
        /// </summary>
        public int ControlMode
        {
            get
            {
                try
                {
                    return /*ControlModes*/(DSS_CAPI.ctx_Solution_Get_ControlMode(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Converged.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/DefaultDaily.html
        /// </summary>
        public string DefaultDaily
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Solution_Get_DefaultDaily(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/DefaultYearly.html
        /// </summary>
        public string DefaultYearly
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Solution_Get_DefaultYearly(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/EventLog.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Frequency1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/GenMult.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/GenPF.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/GenkW.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Hour.html
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
        /// Number of iterations taken for last solution. (Same as Totaliterations)
        /// 
        /// Original COM help: https://opendss.epri.com/Iterations.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LDCurve.html
        /// </summary>
        public string LDCurve
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Solution_Get_LDCurve(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/LoadModel.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LoadMult.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MaxControlIterations.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MaxIterations.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MinIterations.html
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
        /// Set present solution mode
        /// 
        /// Original COM help: https://opendss.epri.com/Mode2.html
        /// </summary>
        public int Mode
        {
            get
            {
                try
                {
                    return /*SolveModes*/(DSS_CAPI.ctx_Solution_Get_Mode(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Solution_Set_Mode(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// ID (text) of the present solution mode
        /// 
        /// Original COM help: https://opendss.epri.com/ModeID.html
        /// </summary>
        public string ModeID
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Solution_Get_ModeID(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Max number of iterations required to converge at any control iteration of the most recent solution.
        /// 
        /// Original COM help: https://opendss.epri.com/MostIterationsDone.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Number1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Process_Time.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Random.html
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
                    DSS_CAPI.ctx_Solution_Set_Random(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Seconds from top of the hour.
        /// 
        /// Original COM help: https://opendss.epri.com/Seconds.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/StepSize.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SystemYChanged.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Time_of_Step.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Tolerance.html
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
        /// 
        /// This accumulator has to be reset manually.
        /// 
        /// Original COM help: https://opendss.epri.com/Total_Time.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Totaliterations.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Year.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/dblHour1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/pctGrowth.html
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

        /// <summary>
        /// Bus levels for all the buses in the model. 
        /// 
        /// The bus levels are calculated after calculating the incidence branch-to-node (B2N) 
        /// matrix and they represent the distance from the buses to a reference that goes from
        /// the feeder head to the farthest bus in the model. The bus level index matches with
        /// the bus list obtained with the circuit interface.
        /// 
        /// Original COM help: https://opendss.epri.com/BusLevels.html
        /// </summary>
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

        /// <summary>
        /// Incidence branch-to-node (B2N) matrix calculated for the model as a vector of integers.
        /// 
        /// The vector represents a sparse matrix (non-zero values are the only ones delivered) and
        /// can be interpreted as follows: The first element is the row number, the second one is
        /// the column and the third is the value, this way, by dividing the number of elements
        /// in the array by 3 the user can obtain the number of rows in case of wanting to sort 
        /// the vector values within a matrix.
        /// 
        /// Original COM help: https://opendss.epri.com/IncMatrix.html
        /// </summary>
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

        /// <summary>
        /// Names of the columns of the branch-to-node (B2N) matrix.
        /// 
        /// Original COM help: https://opendss.epri.com/IncMatrixCols.html
        /// </summary>
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

        /// <summary>
        /// Names of the rows of the branch-to-node (B2N) matrix.
        /// 
        /// Original COM help: https://opendss.epri.com/IncMatrixRows.html
        /// </summary>
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

        /// <summary>
        /// Laplacian matrix calculated in OpenDSS based on the latest branch-to-node (B2N) matrix.
        /// 
        /// The vector represents a sparse matrix (non-zero values are the only ones delivered) and
        /// can be interpreted as follows: The first element is the row number, the second one is
        /// the column and the third is the value, this way, by dividing the number of elements
        /// in the array by 3 the user can obtain the number of rows in case of wanting to sort
        /// the vector values within a matrix. The tables for the columns and rows are the same
        /// as the columns for the B2N columns (square matrix).        
        /// 
        /// Original COM help: https://opendss.epri.com/Laplacian.html
        /// </summary>
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
        /// <summary>
        /// Solves all the circuits (Actors) loaded into memory by the user.
        /// 
        /// Original COM help: https://opendss.epri.com/SolveAll.html
        /// </summary>
        public void SolveAll()
        {
            try
            {
                DSS_CAPI.ctx_Solution_SolveAll(ctx);
            }
            finally
            {
                CheckForError();
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
                    return APIUtil.get_string(DSS_CAPI.ctx_LineGeometries_Get_Name(ctx));
                }
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

        /// <summary>
        /// Number of conductors in this geometry. Default is 3. Triggers memory allocations. Define first!
        /// </summary>
        public int Nconds
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_LineGeometries_Get_Nconds(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_LineGeometries_Set_Nconds(ctx, value);
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
                    return APIUtil.get_string(DSS_CAPI.ctx_LineSpacings_Get_Name(ctx));
                }
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
                    return /*LineUnits*/(DSS_CAPI.ctx_LineSpacings_Get_Units(ctx));
                }
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
                    return APIUtil.get_string(DSS_CAPI.ctx_LoadShapes_Get_Name(ctx));
                }
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


        /// <summary>
        /// Create a new LoadShape, with default parameters
        /// </summary>
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

        /// <summary>
        /// Normalize the LoadShape data inplace
        /// </summary>
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
        /// Fixed interval time value, in hours.
        /// 
        /// Original COM help: https://opendss.epri.com/HrInterval.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MinInterval.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Npts.html
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

        /// <summary>
        /// Base P value for normalization. Default is zero, meaning the peak will be used.
        /// 
        /// Original COM help: https://opendss.epri.com/Pbase.html
        /// </summary>
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
        /// 
        /// Original COM help: https://opendss.epri.com/Pmult.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Qbase.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Qmult.html
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
        /// Time array in hours corresponding to P and Q multipliers when the Interval=0.
        /// 
        /// Original COM help: https://opendss.epri.com/TimeArray.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/UseActual.html
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

        /// <summary>
        /// Fixed interval time value, in seconds.
        /// 
        /// Original COM help: https://opendss.epri.com/Sinterval.html
        /// </summary>
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

        /// <summary>
        /// Converts the current LoadShape data to float32/single precision.
        /// If there is no data or the data is already represented using float32, nothing is done.
        /// 
        /// **(API Extension)**
        /// </summary>
        public void UseFloat32()
        {
            try
            {
                DSS_CAPI.ctx_LoadShapes_UseFloat32(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Converts the current LoadShape data to float64/double precision.
        /// If there is no data or the data is already represented using float64, nothing is done.
        /// 
        /// **(API Extension)**
        /// </summary>
        public void UseFloat64()
        {
            try
            {
                DSS_CAPI.ctx_LoadShapes_UseFloat64(ctx);
            }
            finally
            {
                CheckForError();
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Loads_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllocationFactor.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/CVRcurve.html
        /// </summary>
        public string CVRcurve
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Loads_Get_CVRcurve(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/CVRvars.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/CVRwatts.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Cfactor.html
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

        /// <summary>
        /// Code number used to separate loads by class or group. No effect on the solution.
        /// 
        /// Original COM help: https://opendss.epri.com/Class.html
        /// </summary>
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
        /// 
        /// Original COM help: https://opendss.epri.com/Growth.html
        /// </summary>
        public string Growth
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Loads_Get_Growth(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/IsDelta1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Model1.html
        /// </summary>
        public LoadModels Model
        {
            get
            {
                try
                {
                    return (LoadModels)(DSS_CAPI.ctx_Loads_Get_Model(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Model(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of customers in this load, defaults to one.
        /// 
        /// Original COM help: https://opendss.epri.com/NumCust1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PF1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PctMean.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PctStdDev.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/RelWeight.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Rneut.html
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
        /// Name of harmonic current spectrum shape.
        /// 
        /// Original COM help: https://opendss.epri.com/Spectrum.html
        /// </summary>
        public string Spectrum
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Loads_Get_Spectrum(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Status.html
        /// </summary>
        public LoadStatus Status
        {
            get
            {
                try
                {
                    return (LoadStatus)(DSS_CAPI.ctx_Loads_Get_Status(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Loads_Set_Status(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Maximum per-unit voltage to use the load model. Above this, constant Z applies.
        /// 
        /// Original COM help: https://opendss.epri.com/Vmaxpu1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Vminemerg.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Vminnorm.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Vminpu1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xneut.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Yearly.html
        /// </summary>
        public string Yearly
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Loads_Get_Yearly(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/ZIPV.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/daily.html
        /// </summary>
        public string daily
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Loads_Get_daily(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/duty.html
        /// </summary>
        public string duty
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Loads_Get_duty(ctx));
                }
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
        /// kV rating for active Load. For 2 or more phases set Line-Line kV. Else actual kV across terminals.
        /// 
        /// Original COM help: https://opendss.epri.com/kV2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kW1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kva.html
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
        /// Reactive power in kvar for active Load. If set, updates PF based on present kW.
        /// 
        ///         Original COM help: https://opendss.epri.com/kvar1.html
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
        /// kWh billed for this period. Can be used with Cfactor for load allocation.
        /// 
        /// Original COM help: https://opendss.epri.com/kwh.html
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
        /// Length of kWh billing period for average demand calculation. Default 30.
        /// 
        /// Original COM help: https://opendss.epri.com/kwhdays.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/pctSeriesRL.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/xfkVA.html
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
        /// Name of the sensor monitoring this load.
        /// 
        /// Original COM help: https://opendss.epri.com/Sensor.html
        /// </summary>
        public string Sensor
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Loads_Get_Sensor(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of phases
        /// 
        /// **(API Extension)**
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Meters_Get_Name(ctx));
                }
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


        /// <summary>
        /// Close All Demand Interval Files. Users are required to close the DI files at the end of a run.
        /// 
        /// Original COM help: https://opendss.epri.com/CloseAllDIFiles.html
        /// </summary>
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

        /// <summary>
        /// Calculate reliability indices
        /// 
        /// Original COM help: https://opendss.epri.com/DoReliabilityCalc.html
        /// </summary>
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

        /// <summary>
        /// Open Demand Interval (DI) files
        /// 
        /// Original COM help: https://opendss.epri.com/OpenAllDIFiles.html
        /// </summary>
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

        /// <summary>
        /// Resets registers of active meter.
        /// 
        /// Original COM help: https://opendss.epri.com/Reset2.html
        /// </summary>
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

        /// <summary>
        /// Resets registers of all meter objects.
        /// 
        /// Original COM help: https://opendss.epri.com/ResetAll.html
        /// </summary>
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

        /// <summary>
        /// Forces active Meter to take a sample.
        /// 
        /// Original COM help: https://opendss.epri.com/Sample1.html
        /// </summary>
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

        /// <summary>
        /// Causes all EnergyMeter objects to take a sample at the present time.
        /// 
        /// Original COM help: https://opendss.epri.com/SampleAll.html
        /// </summary>
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

        /// <summary>
        /// Saves meter register values.
        /// 
        /// Original COM help: https://opendss.epri.com/Save.html
        /// </summary>
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

        /// <summary>
        /// Save All EnergyMeter objects
        /// 
        /// Original COM help: https://opendss.epri.com/SaveAll.html
        /// </summary>
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
        /// Wide string list of all branches in zone of the active EnergyMeter object.
        /// 
        /// Original COM help: https://opendss.epri.com/AllBranchesInZone.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllEndElements.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllocFactors.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AvgRepairTime.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/CalcCurrent.html
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
        /// Number of branches in Active EnergyMeter zone. (Same as sequence list size)
        /// 
        /// Original COM help: https://opendss.epri.com/CountBranches.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/CountEndElements.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/CustInterrupts.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/DIFilesAreOpen.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/FaultRateXRepairHrs.html
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
        /// Name of metered element
        /// 
        /// Original COM help: https://opendss.epri.com/MeteredElement.html
        /// </summary>
        public string MeteredElement
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Meters_Get_MeteredElement(ctx));
                }
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
        /// Number of Metered Terminal
        /// 
        /// Original COM help: https://opendss.epri.com/MeteredTerminal.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumSectionBranches.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumSectionCustomers.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumSections.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/OCPDeviceType.html
        /// </summary>
        public int OCPDeviceType
        {
            get
            {
                try
                {
                    return /*OCPDevType*/(DSS_CAPI.ctx_Meters_Get_OCPDeviceType(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of doubles to set values of Peak Current property
        /// 
        /// Original COM help: https://opendss.epri.com/Peakcurrent.html
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
        /// 
        /// See also the enum `EnergyMeterRegisters` for the standard register names.
        /// Besides those listed in the enumeration, users may need to check `RegisterNames`
        /// in order to find a specific register index at runtime.
        /// 
        /// Original COM help: https://opendss.epri.com/RegisterNames1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/RegisterValues1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SAIDI.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SAIFI.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SAIFIKW.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SectSeqIdx.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SectTotalCust.html
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
        /// Size of the Sequence List
        /// 
        /// Original COM help: https://opendss.epri.com/SeqListSize.html
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
        /// Get/set Index into Meter's SequenceList that contains branch pointers in lexical order. 
        /// Earlier index guaranteed to be upline from later index. Sets PDelement active.
        /// 
        /// Original COM help: https://opendss.epri.com/SequenceIndex.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SumBranchFltRates.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/TotalCustomers.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Totals.html
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
        /// Accumulated failure rate for this branch on downline
        /// 
        /// Original COM help: https://opendss.epri.com/AccumulatedL.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Count12.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Lambda1.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_PDElements_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Numcustomers.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/RepairTime.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SectionID1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/TotalMiles1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/TotalCustomers1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/pctPermanent.html
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
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// Double array of the symmetrical component currents (magnitudes only) into each 3-phase terminal, for each PD element.
        /// 
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// Complex array of sequence powers into each 3-phase terminal, for each PD element
        /// 
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// **(API Extension)**
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
        /// **(API Extension)**
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
                    return APIUtil.get_string(DSS_CAPI.ctx_PVSystems_Get_Name(ctx));
                }
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
        /// Get/set the present value of the Irradiance property in kW/m²
        /// 
        /// Original COM help: https://opendss.epri.com/Irradiance.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PF2.html
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
        /// Array of PVSystem energy meter register names
        /// 
        /// See also the enum `GeneratorRegisters`.
        /// 
        /// Original COM help: https://opendss.epri.com/RegisterNames2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/RegisterValues2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kVArated1.html
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
        /// Get kW output
        /// 
        /// Original COM help: https://opendss.epri.com/kW2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kvar2.html
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
        /// Name of the dispatch shape to use for daily simulations. Must be previously
        /// defined as a Loadshape object of 24 hrs, typically. In the default dispatch
        /// mode, the PVSystem element uses this loadshape to trigger State changes.
        /// 
        /// **(API Extension)**
        /// </summary>
        public string daily
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_PVSystems_Get_daily(ctx));
                }
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
        /// 
        /// **(API Extension)**
        /// </summary>
        public string duty
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_PVSystems_Get_duty(ctx));
                }
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
        /// 
        /// **(API Extension)**
        /// </summary>
        public string yearly
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_PVSystems_Get_yearly(ctx));
                }
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
        /// 
        /// **(API Extension)**
        /// </summary>
        public string Tdaily
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_PVSystems_Get_Tdaily(ctx));
                }
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
        /// 
        /// **(API Extension)**
        /// </summary>
        public string Tduty
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_PVSystems_Get_Tduty(ctx));
                }
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
        /// 
        /// **(API Extension)**
        /// </summary>
        public string Tyearly
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_PVSystems_Get_Tyearly(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/IrradianceNow.html
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
        /// Gets/sets the rated max power of the PV array for 1.0 kW/m² irradiance 
        /// and a user-selected array temperature of the active PVSystem.
        /// 
        /// Original COM help: https://opendss.epri.com/Pmpp.html
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

        /// <summary>
        /// Name of the sensor monitoring this element.
        /// 
        /// Original COM help: https://opendss.epri.com/Sensor1.html
        /// </summary>
        public string Sensor
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_PVSystems_Get_Sensor(ctx));
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Reactors_Get_Name(ctx));
                }
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Reactors_Get_Bus1(ctx));
                }
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Reactors_Get_Bus2(ctx));
                }
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Reactors_Get_LCurve(ctx));
                }
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Reactors_Get_RCurve(ctx));
                }
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Reclosers_Get_Name(ctx));
                }
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
        /// Ground (3I0) instantaneous trip setting - curve multiplier or actual amps.
        /// 
        /// Original COM help: https://opendss.epri.com/GroundInst.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/GroundTrip.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredObj2.html
        /// </summary>
        public string MonitoredObj
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Reclosers_Get_MonitoredObj(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredTerm2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumFast.html
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
        /// Phase instantaneous curve multiplier or actual amps
        /// 
        /// Original COM help: https://opendss.epri.com/PhaseInst.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PhaseTrip.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/RecloseIntervals.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Shots.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SwitchedObj1.html
        /// </summary>
        public string SwitchedObj
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Reclosers_Get_SwitchedObj(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/SwitchedTerm1.html
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

        /// <summary>
        /// Reset recloser to normal state. 
        /// If open, lock out the recloser. 
        /// If closed, resets recloser to first operation.
        /// </summary>
        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_Reclosers_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get/Set present state of recloser. 
        /// If set to open (ActionCodes.Open=1), open recloser's controlled element and lock out the recloser. 
        /// If set to close (ActionCodes.Close=2), close recloser's controlled element and resets recloser to first operation.
        /// </summary>
        public ActionCodes State
        {
            get
            {
                try
                {
                    return (ActionCodes)(DSS_CAPI.ctx_Reclosers_Get_State(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_State(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set normal state (ActionCodes.Open=1, ActionCodes.Close=2) of the recloser.
        /// 
        /// Original COM help: https://opendss.epri.com/NormalState1.html
        /// </summary>
        public ActionCodes NormalState
        {
            get
            {
                try
                {
                    return (ActionCodes)(DSS_CAPI.ctx_Reclosers_Get_NormalState(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Reclosers_Set_NormalState(ctx, (int)value);
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
                    return APIUtil.get_string(DSS_CAPI.ctx_RegControls_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/CTPrimary.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Delay2.html
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
        /// Regulation bandwidth in forward direction, centered on Vreg
        /// 
        /// Original COM help: https://opendss.epri.com/ForwardBand.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ForwardR.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ForwardVreg.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ForwardX.html
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
        /// Time delay is inversely adjusted, proportional to the amount of voltage outside the regulating band.
        /// 
        /// Original COM help: https://opendss.epri.com/IsInverseTime.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/IsReversible.html
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
        /// Maximum tap change per iteration in STATIC solution mode. 1 is more realistic, 16 is the default for a faster solution.
        /// 
        /// Original COM help: https://opendss.epri.com/MaxTapChange.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredBus.html
        /// </summary>
        public string MonitoredBus
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_RegControls_Get_MonitoredBus(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/PTratio1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ReverseBand.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ReverseR.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ReverseVreg.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ReverseX.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/TapDelay.html
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
        /// Integer number of the tap that the controlled transformer winding is currently on.
        /// 
        /// Original COM help: https://opendss.epri.com/TapNumber.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/TapWinding.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Transformer.html
        /// </summary>
        public string Transformer
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_RegControls_Get_Transformer(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/VoltageLimit.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Winding.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Relays_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredObj3.html
        /// </summary>
        public string MonitoredObj
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Relays_Get_MonitoredObj(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/MonitoredTerm3.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/SwitchedObj2.html
        /// </summary>
        public string SwitchedObj
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Relays_Get_SwitchedObj(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/SwitchedTerm2.html
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

        /// <summary>
        /// Open relay's controlled element and lock out the relay.
        /// 
        /// Original COM help: https://opendss.epri.com/Open4.html
        /// </summary>
        public void Open()
        {
            try
            {
                DSS_CAPI.ctx_Relays_Open(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Close the switched object controlled by the relay. Resets relay to first operation.
        /// 
        /// Original COM help: https://opendss.epri.com/Close5.html
        /// </summary>
        public void Close()
        {
            try
            {
                DSS_CAPI.ctx_Relays_Close(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Reset relay to normal state. 
        /// If open, lock out the relay. 
        /// If closed, resets relay to first operation.
        /// </summary>
        public void Reset()
        {
            try
            {
                DSS_CAPI.ctx_Relays_Reset(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Get/Set present state of relay. 
        /// If set to open, open relay's controlled element and lock out the relay. 
        /// If set to close, close relay's controlled element and resets relay to first operation.
        /// </summary>
        public ActionCodes State
        {
            get
            {
                try
                {
                    return (ActionCodes)(DSS_CAPI.ctx_Relays_Get_State(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Relays_Set_State(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Normal state of relay.
        /// 
        /// Original COM help: https://opendss.epri.com/NormalState3.html
        /// </summary>
        public ActionCodes NormalState
        {
            get
            {
                try
                {
                    return (ActionCodes)(DSS_CAPI.ctx_Relays_Get_NormalState(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Relays_Set_NormalState(ctx, (int)value);
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Sensors_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Currents2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/IsDelta2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MeteredElement1.html
        /// </summary>
        public string MeteredElement
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Sensors_Get_MeteredElement(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/MeteredTerminal1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/PctError.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ReverseDelta.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Weight.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kVARS.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kVS.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kVBase1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kWS.html
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

        /// <summary>
        /// Array of doubles for the allocation factors for each phase.
        /// 
        /// Original COM help: https://opendss.epri.com/AllocationFactor1.html
        /// </summary>
        public double[] AllocationFactor
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Sensors_Get_AllocationFactor_GR(ctx);
                    return apiutil.get_float64_gr_array();
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
                    return APIUtil.get_string(DSS_CAPI.ctx_SwtControls_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Action1.html
        /// </summary>
        public ActionCodes Action
        {
            get
            {
                try
                {
                    return (ActionCodes)DSS_CAPI.ctx_SwtControls_Get_Action(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_Action(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Time delay [s] between arming and opening or closing the switch.  Control may reset before actually operating the switch.
        /// 
        /// Original COM help: https://opendss.epri.com/Delay3.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/IsLocked.html
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
        /// Get/set Normal state of switch (see ActionCodes) dssActionOpen or dssActionClose
        /// </summary>
        public ActionCodes NormalState
        {
            get
            {
                try
                {
                    return (ActionCodes)DSS_CAPI.ctx_SwtControls_Get_NormalState(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_NormalState(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Set it to force the switch to a specified state, otherwise read its present state.
        /// 
        /// Original COM help: https://opendss.epri.com/State.html
        /// </summary>
        public ActionCodes State
        {
            get
            {
                try
                {
                    return (ActionCodes)(DSS_CAPI.ctx_SwtControls_Get_State(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_SwtControls_Set_State(ctx, (int)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Full name of the switched element.
        /// 
        /// Original COM help: https://opendss.epri.com/SwitchedObj3.html
        /// </summary>
        public string SwitchedObj
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_SwtControls_Get_SwitchedObj(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/SwitchedTerm3.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_TSData_Get_Name(ctx));
                }
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
            /// Runs a list of strings as commands directly in the DSS engine.
            /// Intermediate results are ignored.
            ///
            /// (API Extensions)
            /// </summary>
            public void Commands(string[] value)
            {
                try
                {
                    DSS_CAPI.ctx_Text_CommandArray(ctx, value, value.Length);
                }
                finally
                {
                    CheckForError();
                }
            }

            /// <summary>
            /// Runs a large string as commands directly in the DSS engine.
            /// Intermediate results are ignored.
            ///
            /// (API Extensions)
            /// </summary>
            public void Commands(string value)
            {
                try
                {
                    DSS_CAPI.ctx_Text_CommandBlock(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }

        /// <summary>
        /// Input command string for the DSS.
        /// 
        /// Original COM help: https://opendss.epri.com/Command1.html
        /// </summary>
        public string Command
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Text_Get_Command(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Result.html
        /// </summary>
        public string Result
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Text_Get_Result(ctx));
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
        /// 
        /// Original COM help: https://opendss.epri.com/ActiveBranch.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ActiveLevel.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllIsolatedBranches.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllIsolatedLoads.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/AllLoopedPairs.html
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
        /// Move back toward the source, return index of new active branch, or 0 if no more.
        /// 
        /// Original COM help: https://opendss.epri.com/BackwardBranch.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/BranchName.html
        /// </summary>
        public string BranchName
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Topology_Get_BranchName(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/BusName.html
        /// </summary>
        public string BusName
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Topology_Get_BusName(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/First19.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/FirstLoad.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ForwardBranch.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/LoopedBranch.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Next18.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NextLoad.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumIsolatedBranches.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumIsolatedLoads.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumLoops.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/ParallelBranch.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Transformers_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/IsDelta3.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MaxTap.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/MinTap.html
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
        /// Active Winding number of tap steps between MinTap and MaxTap.
        /// 
        /// Original COM help: https://opendss.epri.com/NumTaps.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumWindings.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/R.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Rneut1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Tap.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Wdg.html
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
        /// Name of an XfrmCode that supplies electrical parameters for this Transformer.
        /// 
        /// Original COM help: https://opendss.epri.com/XfmrCode1.html
        /// </summary>
        public string XfmrCode
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Transformers_Get_XfmrCode(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xhl.html
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
        /// Percent reactance between windings 1 and 3, on winding 1 kVA base.  Use for 3-winding transformers only.
        /// 
        /// Original COM help: https://opendss.epri.com/Xht.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xlt.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xneut1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kV3.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/kva1.html
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
        /// 
        /// **WARNING:** If the transformer has open terminal(s), results may be wrong, i.e. avoid using this
        /// in those situations. For more information, see https://github.com/dss-extensions/dss-extensions/issues/24
        /// 
        /// Original COM help: https://opendss.epri.com/WdgVoltages.html
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
        /// 
        /// **WARNING:** If the transformer has open terminal(s), results may be wrong, i.e. avoid using this
        /// in those situations. For more information, see https://github.com/dss-extensions/dss-extensions/issues/24
        /// 
        /// Original COM help: https://opendss.epri.com/WdgCurrents.html
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
        /// 
        /// **WARNING:** If the transformer has open terminal(s), results may be wrong, i.e. avoid using this
        /// in those situations. For more information, see https://github.com/dss-extensions/dss-extensions/issues/24
        /// </summary>
        public string strWdgCurrents
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Transformers_Get_strWdgCurrents(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Transformer Core Type: 0=Shell; 1=1ph; 3-3leg; 4=4-Leg; 5=5-leg; 9=Core-1-phase
        /// 
        /// Original COM help: https://opendss.epri.com/CoreType.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/RdcOhms.html
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
        /// 
        /// **(API Extension)**
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
        /// 
        /// **(API Extension)**
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
                    return APIUtil.get_string(DSS_CAPI.ctx_Vsources_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/AngleDeg1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/BasekV.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Frequency2.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Phases3.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/pu.html
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
                    return APIUtil.get_string(DSS_CAPI.ctx_WireData_Get_Name(ctx));
                }
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
                    return /*LineUnits*/(DSS_CAPI.ctx_WireData_Get_GMRUnits(ctx));
                }
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
                    return /*LineUnits*/(DSS_CAPI.ctx_WireData_Get_ResistanceUnits(ctx));
                }
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

        /// <summary>
        /// Equivalent conductor radius for capacitance calcs. Specify this for bundled conductors. Defaults to same value as radius.
        /// </summary>
        public double CapRadius
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_WireData_Get_CapRadius(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_WireData_Set_CapRadius(ctx, value);
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
                    return APIUtil.get_string(DSS_CAPI.ctx_XYCurves_Get_Name(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/Npts1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xarray.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xscale.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Xshift.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Yarray.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Yscale.html
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
        /// Amount to shift Y value from original curve
        /// 
        /// Original COM help: https://opendss.epri.com/Yshift.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/x4.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/y1.html
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

        /// <summary>
        /// Sparse solver options. See the enumeration SparseSolverOptions
        /// </summary>
        public ulong SolverOptions
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_YMatrix_Get_SolverOptions(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_YMatrix_Set_SolverOptions(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public bool CheckConvergence()
        {
            try
            {
                return (DSS_CAPI.ctx_YMatrix_CheckConvergence(ctx) != 0);
            }
            finally
            {
                CheckForError();
            }
        }

        public void SetGeneratordQdV()
        {
            try
            {
                DSS_CAPI.ctx_YMatrix_SetGeneratordQdV(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        public bool LoadsNeedUpdating
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_YMatrix_Get_LoadsNeedUpdating(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_YMatrix_Set_LoadsNeedUpdating(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public bool SolutionInitialized
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_YMatrix_Get_SolutionInitialized(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_YMatrix_Set_SolutionInitialized(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        public int Iteration
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_YMatrix_Get_Iteration(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_YMatrix_Set_Iteration(ctx, value);
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

    public class ZIP : ContextState
    {

        public ZIP(APIUtil util) : base(util)
        {
        }
    
        /// <summary>
        /// Extracts the contents of the file "FileName" from the current (open) ZIP file.
        /// Returns a byte-string.
        ///
        /// (API Extension)
        /// </summary>
        public byte[] Extract(string FileName)
        {
            try
            {
                DSS_CAPI.ctx_ZIP_Extract_GR(ctx, FileName);
                return apiutil.get_int8_gr_array();
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// List of strings consisting of all names match the regular expression provided in regexp.
        /// If no expression is provided, all names in the current open ZIP are returned.
        ///
        /// See https://regex.sorokin.engineer/en/latest/regular_expressions.html for information on
        /// the expression syntax and options.
        ///
        /// (API Extension)
        /// </summary>
        public string[] List(string regexp="")
        {
            try
            {
                return apiutil.get_string_array(DSS_CAPI.ctx_ZIP_List, regexp);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Opens and prepares a ZIP file to be used by the DSS text parser.
        /// Currently, the ZIP format support is limited by what is provided in the Free Pascal distribution.
        /// Besides that, the full filenames inside the ZIP must be shorter than 256 characters.
        /// The limitations should be removed in a future revision.
        /// 
        /// **(API Extension)**
        /// </summary>
        public void Open(string FileName)
        {
            try
            {
                DSS_CAPI.ctx_ZIP_Open(ctx, FileName);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Closes the current open ZIP file
        /// 
        /// **(API Extension)**
        /// </summary>
        public void Close()
        {
            try
            {
                DSS_CAPI.ctx_ZIP_Close(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Runs a "Redirect" command inside the current (open) ZIP file.
        /// In the current implementation, all files required by the script must
        /// be present inside the ZIP, using relative paths. The only exceptions are
        /// memory-mapped files.
        /// 
        /// **(API Extension)**
        /// </summary>
        public void Redirect(string FileInZip)
        {
            try
            {
                DSS_CAPI.ctx_ZIP_Redirect(ctx, FileInZip);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Check if the given path name is present in the current ZIP file.
        /// 
        /// **(API Extension)**
        /// </summary>
        public bool Contains(string Name)
        {
            try
            {
                return (DSS_CAPI.ctx_ZIP_Contains(ctx, Name) != 0);
            }
            finally
            {
                CheckForError();
            }
        }

    }

    public class GICSources : ContextState
    {

        public GICSources(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all GICSource names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_GICSources_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of GICSource objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first GICSource active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active GICSource by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_GICSources_Get_Name(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next GICSource active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active GICSource by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// First bus name of GICSource (Created name)
        /// </summary>
        public string Bus1
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_GICSources_Get_Bus1(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Second bus name
        /// </summary>
        public string Bus2
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_GICSources_Get_Bus2(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Phases, this GICSource element.
        /// </summary>
        public int Phases
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_Phases(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_Phases(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Northward E Field V/km
        /// </summary>
        public double EN
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_EN(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_EN(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Eastward E Field, V/km
        /// </summary>
        public double EE
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_EE(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_EE(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Latitude of Bus1 (degrees)
        /// </summary>
        public double Lat1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_Lat1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_Lat1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Latitude of Bus2 (degrees)
        /// </summary>
        public double Lat2
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_Lat2(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_Lat2(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Longitude of Bus1 (Degrees)
        /// </summary>
        public double Lon1
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_Lon1(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_Lon1(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Longitude of Bus2 (Degrees)
        /// </summary>
        public double Lon2
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_Lon2(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_Lon2(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Specify dc voltage directly
        /// </summary>
        public double Volts
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_GICSources_Get_Volts(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_GICSources_Set_Volts(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Storages : ContextState
    {

        public Storages(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Array of strings with all Storage names in the circuit.
        /// </summary>
        public string[] AllNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Storages_Get_AllNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Storage objects in active circuit.
        /// </summary>
        public int Count
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Storages_Get_Count(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the first Storage active. Returns 0 if no more.
        /// </summary>
        public int First
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Storages_Get_First(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the active Storage by Name.
        /// </summary>
        public string Name
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_Storages_Get_Name(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Storages_Set_Name(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Sets the next Storage active. Returns 0 if no more.
        /// </summary>
        public int Next
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Storages_Get_Next(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set active Storage by index; index is 1-based: 1..count
        /// </summary>
        public int idx
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Storages_Get_idx(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Storages_Set_idx(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }


        /// <summary>
        /// Per unit state of charge
        /// </summary>
        public double puSOC
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Storages_Get_puSOC(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Storages_Set_puSOC(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Get/set state: 0=Idling; 1=Discharging; -1=Charging;
        /// </summary>
        public int State
        {
            get
            {
                try
                {
                    return /*StorageStates*/(DSS_CAPI.ctx_Storages_Get_State(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Storages_Set_State(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of Storage energy meter register names
        /// 
        /// See also the enum `GeneratorRegisters`.
        /// </summary>
        public string[] RegisterNames
        {
            get
            {
                try
                {
                    return apiutil.get_string_array(DSS_CAPI.ctx_Storages_Get_RegisterNames);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Array of values in Storage registers.
        /// </summary>
        public double[] RegisterValues
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Storages_Get_RegisterValues_GR(ctx);
                    return apiutil.get_float64_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

    public class Parallel : ContextState
    {

        public Parallel(APIUtil util) : base(util)
        {
        }

        /// <summary>
        /// Create a new actor, if there are still cores available.
        /// </summary>
        public void CreateActor()
        {
            try
            {
                DSS_CAPI.ctx_Parallel_CreateActor(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Suspends the host's thread until all the OpenDSS running jobs finish.
        /// 
        /// Original COM help: https://opendss.epri.com/Wait.html
        /// </summary>
        public void Wait()
        {
            try
            {
                DSS_CAPI.ctx_Parallel_Wait(ctx);
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Gets/sets the ID of the Active Actor
        /// 
        /// Original COM help: https://opendss.epri.com/ActiveActor.html
        /// </summary>
        public int ActiveActor
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parallel_Get_ActiveActor(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parallel_Set_ActiveActor(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// (read) Sets ON/OFF (1/0) Parallel features of the Engine
        /// (write) Delivers if the Parallel features of the Engine are Active
        /// 
        /// Original COM help: https://opendss.epri.com/ActiveParallel.html
        /// </summary>
        public int ActiveParallel
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parallel_Get_ActiveParallel(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parallel_Set_ActiveParallel(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets/sets the CPU of the Active Actor
        /// 
        /// Original COM help: https://opendss.epri.com/ActorCPU.html
        /// </summary>
        public int ActorCPU
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parallel_Get_ActorCPU(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parallel_Set_ActorCPU(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets the progress of all existing actors in pct
        /// 
        /// Original COM help: https://opendss.epri.com/ActorProgress.html
        /// </summary>
        public int[] ActorProgress
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Parallel_Get_ActorProgress_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets the status of each actor
        /// 
        /// Original COM help: https://opendss.epri.com/ActorStatus.html
        /// </summary>
        public int[] ActorStatus
        {
            get
            {
                try
                {
                    DSS_CAPI.ctx_Parallel_Get_ActorStatus_GR(ctx);
                    return apiutil.get_int32_gr_array();
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// (read) Reads the values of the ConcatenateReports option (1=enabled, 0=disabled)
        /// (write) Enable/Disable (1/0) the ConcatenateReports option for extracting monitors data
        /// 
        /// Original COM help: https://opendss.epri.com/ConcatenateReports.html
        /// </summary>
        public int ConcatenateReports
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parallel_Get_ConcatenateReports(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_Parallel_Set_ConcatenateReports(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Delivers the number of CPUs on the current PC
        /// 
        /// Original COM help: https://opendss.epri.com/NumCPUs.html
        /// </summary>
        public int NumCPUs
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parallel_Get_NumCPUs(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Delivers the number of Cores of the local PC
        /// 
        /// Original COM help: https://opendss.epri.com/NumCores.html
        /// </summary>
        public int NumCores
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parallel_Get_NumCores(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets the number of Actors created
        /// 
        /// Original COM help: https://opendss.epri.com/NumOfActors.html
        /// </summary>
        public int NumOfActors
        {
            get
            {
                try
                {
                    return DSS_CAPI.ctx_Parallel_Get_NumOfActors(ctx);
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
        public ZIP ZIP;

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
            ZIP = new ZIP(util);
        }
    

        /// <summary>
        /// Expose DSS without a constructor parameters for backwards compatibility.
        /// This contructors always exposes the prime/default instance of OpenDSS.
        ///
        /// For creating new independent instances, use the static helper function
        /// <cref>NewContext</cref>.
        /// </summary>
        public DSS(): this(new APIUtil(DSS_CAPI.ctx_Get_Prime(), false))
        {
            DSS_CAPI.ctx_DSS_Start(ctx, 0);
        }

        /// <summary>
        /// Creates a new DSS engine context.
        /// A DSS Context encapsulates most of the global state of the original OpenDSS engine,
        /// allowing the user to create multiple instances in the same process. By creating contexts
        /// manually, the management of threads and potential issues should be handled by the user.
        ///
        /// (API Extension)
        /// </summary>
        static public DSS NewContext()
        {
            DSS_CAPI.ctx_DSS_Start(DSS_CAPI.ctx_Get_Prime(), 0);
            APIUtil new_api_util = new APIUtil(DSS_CAPI.ctx_New(), true);
            return new DSS(new_api_util);
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

        /// <summary>
        /// This is a no-op function, does nothing. Left for compatibility.
        /// 
        /// Original COM help: https://opendss.epri.com/Reset1.html
        /// </summary>
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

        /// <summary>
        /// This is a no-op function, does nothing. Left for compatibility.
        /// 
        /// Calling `Start` in AltDSS/DSS-Extensions is required but that is already
        /// handled automatically, so the users do not need to call it manually,
        /// unless using AltDSS/DSS C-API directly without further tools.
        /// 
        /// On the official OpenDSS, `Start` also does nothing at all in the current 
        /// versions.
        /// 
        /// Original COM help: https://opendss.epri.com/Start.html
        /// </summary>
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
        /// 
        /// Original COM help: https://opendss.epri.com/Classes1.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/DataPath.html
        /// </summary>
        public string DataPath
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_DSS_Get_DataPath(ctx));
                }
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
        /// 
        /// Original COM help: https://opendss.epri.com/DefaultEditor.html
        /// </summary>
        public string DefaultEditor
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_DSS_Get_DefaultEditor(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Number of Circuits currently defined
        /// 
        /// Original COM help: https://opendss.epri.com/NumCircuits.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumClasses.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/NumUserClasses.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/UserClasses.html
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
        /// 
        /// Original COM help: https://opendss.epri.com/Version.html
        /// </summary>
        public string Version
        {
            get
            {
                try
                {
                    return APIUtil.get_string(DSS_CAPI.ctx_DSS_Get_Version(ctx));
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Gets/sets whether text output is allowed (DSS-Extensions) or general forms/windows are shown (official OpenDSS).
        /// 
        /// Original COM help: https://opendss.epri.com/AllowForms.html
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
        /// 
        /// **(API Extension)**
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
            }
            finally
            {
                CheckForError();
            }
        }

        /// <summary>
        /// Make a new circuit and returns the interface to the active circuit.
        /// 
        /// Original COM help: https://opendss.epri.com/NewCircuit.html
        /// </summary>
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
        /// LegacyModels was a flag used to toggle legacy (pre-2019) models for PVSystem, InvControl, Storage and
        /// StorageControl.
        /// In the official OpenDSS version 9.0, the old models were removed. They were temporarily present here
        /// but were also removed in DSS C-API v0.13.0.
        /// 
        /// **NOTE**: this property will be removed for v1.0. It is left to avoid breaking the current API too soon.
        /// 
        /// **(API Extension)**
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
        /// Defaults to true (allow changes, backwards compatible) in the 0.10.x versions of DSS C-API. 
        /// This might change to false in future versions.
        /// 
        /// This can also be set through the environment variable DSS_CAPI_ALLOW_CHANGE_DIR. Set it to 0 to
        /// disallow changing the active working directory.
        /// 
        /// **(API Extension)**
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

        /// <summary>
        /// If enabled, the `DOScmd` command is allowed. Otherwise, an error is reported if the user tries to use it.
        /// 
        /// Defaults to false (disabled state). Users should consider DOScmd deprecated on DSS-Extensions.
        /// 
        /// This can also be set through the environment variable DSS_CAPI_ALLOW_DOSCMD. Setting it to 1 enables
        /// the command.
        /// 
        /// **(API Extension)**
        /// </summary>
        public bool AllowDOScmd
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_DSS_Get_AllowDOScmd(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSS_Set_AllowDOScmd(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// If enabled, in case of errors or empty arrays, the API returns arrays with values compatible with the 
        /// official OpenDSS COM interface. 
        /// 
        /// For example, consider the function `Loads_Get_ZIPV`. If there is no active circuit or active load element:
        /// 
        /// - In the disabled state (COMErrorResults==false), the function will return "[]", an array with 0 elements.
        /// - In the enabled state (COMErrorResults==true), the function will return "[0.0]" instead. This should
        /// be compatible with the return value of the official COM interface.
        /// 
        /// Defaults to true (enabled state) in the v0.12.x series. This will change to false in future series.
        /// 
        /// This can also be set through the environment variable `DSS_CAPI_COM_DEFAULTS`. Setting it to 0 disables
        /// the legacy/COM behavior. The value can be toggled through the API at any time.
        /// 
        /// **(API Extension)**
        /// </summary>
        public bool COMErrorResults
        {
            get
            {
                try
                {
                    return (DSS_CAPI.ctx_DSS_Get_COMErrorResults(ctx) != 0);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSS_Set_COMErrorResults(ctx, value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }

        /// <summary>
        /// Controls some compatibility flags introduced to toggle some behavior from the official OpenDSS.
        /// 
        /// **THE FLAGS ARE GLOBAL, affecting all DSS engines in the process.**
        /// 
        /// These flags may change for each version of DSS C-API, but the same value will not be reused. That is,
        /// when we remove a compatibility flag, it will have no effect but will also not affect anything else
        /// besides raising an error if the user tries to toggle a flag that was available in a previous version.
        /// 
        /// We expect to keep a very limited number of flags. Since the flags are more transient than the other
        /// options/flags, it was preferred to add this generic function instead of a separate function per
        /// flag.
        /// 
        /// See the enumeration `DSSCompatFlags` for available flags, including description.
        /// 
        /// **(API Extension)**
        /// </summary>
        public DSSCompatFlags CompatFlags
        {
            get
            {
                try
                {
                    return (DSSCompatFlags)DSS_CAPI.ctx_DSS_Get_CompatFlags(ctx);
                }
                finally
                {
                    CheckForError();
                }
            }
            set
            {
                try
                {
                    DSS_CAPI.ctx_DSS_Set_CompatFlags(ctx, (uint)value);
                }
                finally
                {
                    CheckForError();
                }
            }
        }
    }

}
