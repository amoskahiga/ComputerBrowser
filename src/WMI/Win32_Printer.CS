namespace ROOT.CIMV2.Win32 {
    using System;
    using System.ComponentModel;
    using System.Management;
    using System.Collections;
    using System.Globalization;
    
    
    // Functions ShouldSerialize<PropertyName> are functions used by VS property browser to check if a particular property has to be serialized. These functions are added for all ValueType properties ( properties of type Int32, BOOL etc.. which cannot be set to null). These functions use Is<PropertyName>Null function. These functions are also used in the TypeConverter implementation for the properties to check for NULL value of property so that an empty value can be shown in Property browser in case of Drag and Drop in Visual studio.
    // Functions Is<PropertyName>Null() are used to check if a property is NULL.
    // Functions Reset<PropertyName> are added for Nullable Read/Write properties. These functions are used by VS designer in property browser to set a property to NULL.
    // Every property added to the class for WMI property has attributes set to define its behavior in Visual Studio designer and also to define a TypeConverter to be used.
    // Datetime conversion functions ToDateTime and ToDmtfDateTime are added to the class to convert DMTF datetime to System.DateTime and vice-versa.
    // An Early Bound class generated for the WMI class.Win32_Printer
    public class Printer : System.ComponentModel.Component {
        
        // Private property to hold the WMI namespace in which the class resides.
        private static string CreatedWmiNamespace = "root\\CimV2";
        
        // Private property to hold the name of WMI class which created this class.
        private static string CreatedClassName = "Win32_Printer";
        
        // Private member variable to hold the ManagementScope which is used by the various methods.
        private static System.Management.ManagementScope statMgmtScope = null;
        
        private ManagementSystemProperties PrivateSystemProperties;
        
        // Underlying lateBound WMI object.
        private System.Management.ManagementObject PrivateLateBoundObject;
        
        // Member variable to store the 'automatic commit' behavior for the class.
        private bool AutoCommitProp;
        
        // Private variable to hold the embedded property representing the instance.
        private System.Management.ManagementBaseObject embeddedObj;
        
        // The current WMI object used
        private System.Management.ManagementBaseObject curObj;
        
        // Flag to indicate if the instance is an embedded object.
        private bool isEmbedded;
        
        // Below are different overloads of constructors to initialize an instance of the class with a WMI object.
        public Printer() {
            this.InitializeObject(null, null, null);
        }
        
        public Printer(string keyDeviceID) {
            this.InitializeObject(null, new System.Management.ManagementPath(Printer.ConstructPath(keyDeviceID)), null);
        }
        
        public Printer(System.Management.ManagementScope mgmtScope, string keyDeviceID) {
            this.InitializeObject(((System.Management.ManagementScope)(mgmtScope)), new System.Management.ManagementPath(Printer.ConstructPath(keyDeviceID)), null);
        }
        
        public Printer(System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(null, path, getOptions);
        }
        
        public Printer(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path) {
            this.InitializeObject(mgmtScope, path, null);
        }
        
        public Printer(System.Management.ManagementPath path) {
            this.InitializeObject(null, path, null);
        }
        
        public Printer(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            this.InitializeObject(mgmtScope, path, getOptions);
        }
        
        public Printer(System.Management.ManagementObject theObject) {
            Initialize();
            if ((CheckIfProperClass(theObject) == true)) {
                PrivateLateBoundObject = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
                curObj = PrivateLateBoundObject;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        public Printer(System.Management.ManagementBaseObject theObject) {
            Initialize();
            if ((CheckIfProperClass(theObject) == true)) {
                embeddedObj = theObject;
                PrivateSystemProperties = new ManagementSystemProperties(theObject);
                curObj = embeddedObj;
                isEmbedded = true;
            }
            else {
                throw new System.ArgumentException("Class name does not match.");
            }
        }
        
        // Property returns the namespace of the WMI class.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OriginatingNamespace {
            get {
                return "root\\CimV2";
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ManagementClassName {
            get {
                string strRet = CreatedClassName;
                if ((curObj != null)) {
                    if ((curObj.ClassPath != null)) {
                        strRet = ((string)(curObj["__CLASS"]));
                        if (((strRet == null) 
                                    || (strRet == string.Empty))) {
                            strRet = CreatedClassName;
                        }
                    }
                }
                return strRet;
            }
        }
        
        // Property pointing to an embedded object to get System properties of the WMI object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ManagementSystemProperties SystemProperties {
            get {
                return PrivateSystemProperties;
            }
        }
        
        // Property returning the underlying lateBound object.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementBaseObject LateBoundObject {
            get {
                return curObj;
            }
        }
        
        // ManagementScope of the object.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public System.Management.ManagementScope Scope {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Scope;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    PrivateLateBoundObject.Scope = value;
                }
            }
        }
        
        // Property to show the commit behavior for the WMI object. If true, WMI object will be automatically saved after each property modification.(ie. Put() is called after modification of a property).
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AutoCommit {
            get {
                return AutoCommitProp;
            }
            set {
                AutoCommitProp = value;
            }
        }
        
        // The ManagementPath of the underlying WMI object.
        [Browsable(true)]
        public System.Management.ManagementPath Path {
            get {
                if ((isEmbedded == false)) {
                    return PrivateLateBoundObject.Path;
                }
                else {
                    return null;
                }
            }
            set {
                if ((isEmbedded == false)) {
                    if ((CheckIfProperClass(null, value, null) != true)) {
                        throw new System.ArgumentException("Class name does not match.");
                    }
                    PrivateLateBoundObject.Path = value;
                }
            }
        }
        
        // Public static scope property which is used by the various methods.
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static System.Management.ManagementScope StaticScope {
            get {
                return statMgmtScope;
            }
            set {
                statMgmtScope = value;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAttributesNull {
            get {
                if ((curObj["Attributes"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The Attributes property indicates the attributes of the Win32 printing device. These attributes are represented through a combination of flags. Attributes of the printer include:
Queued  - Print jobs are buffered and queued.
 Direct  - Specifies that the document should be sent directly to the printer.  This is used if print job are not being properly queued.
Default - The printer is the default printer on the computer.
Shared - Available as a shared network resource.
Network - Attached to the network.
Hidden - Hidden from some users on the network.
Local - Directly connected to this computer.
EnableDevQ - Enable the queue on the printer if available.
KeepPrintedJobs - Specifies that the spooler should not delete documents after they are printed.
DoCompleteFirst - Start jobs that are finished spooling first.
WorkOffline - Queue print jobs when printer is not available.
EnableBIDI - Enable bi-directional printing.
RawOnly - Allow only raw data type jobs to be spooled.
Published - Indicates whether the printer is published in the network directory service.
")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public AttributesValues Attributes {
            get {
                if ((curObj["Attributes"] == null)) {
                    return ((AttributesValues)(System.Convert.ToInt32(16384)));
                }
                return ((AttributesValues)(System.Convert.ToInt32(curObj["Attributes"])));
            }
            set {
                if ((AttributesValues.NULL_ENUM_VALUE == value)) {
                    curObj["Attributes"] = null;
                }
                else {
                    curObj["Attributes"] = value;
                }
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAvailabilityNull {
            get {
                if ((curObj["Availability"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The availability and status of the device.  For example, the Availability property indicates that the device is running and has full power (value=3), or is in a warning (4), test (5), degraded (10) or power save state (values 13-15 and 17). Regarding the power saving states, these are defined as follows: Value 13 (""Power Save - Unknown"") indicates that the device is known to be in a power save mode, but its exact status in this mode is unknown; 14 (""Power Save - Low Power Mode"") indicates that the device is in a power save state but still functioning, and may exhibit degraded performance; 15 (""Power Save - Standby"") describes that the device is not functioning but could be brought to full power 'quickly'; and value 17 (""Power Save - Warning"") indicates that the device is in a warning state, though also in a power save mode.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public AvailabilityValues Availability {
            get {
                if ((curObj["Availability"] == null)) {
                    return ((AvailabilityValues)(System.Convert.ToInt32(0)));
                }
                return ((AvailabilityValues)(System.Convert.ToInt32(curObj["Availability"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Describes all of the job sheets that are available on the Printer. This can also " +
            "be used to describe the banner that a Printer might provide at the beginning of " +
            "each Job, or can describe other user specified options.")]
        public string[] AvailableJobSheets {
            get {
                return ((string[])(curObj["AvailableJobSheets"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsAveragePagesPerMinuteNull {
            get {
                if ((curObj["AveragePagesPerMinute"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The AveragePagesPerMinute property specifies the rate (average number of pages pe" +
            "r minute) that the printer is capable of sustaining.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint AveragePagesPerMinute {
            get {
                if ((curObj["AveragePagesPerMinute"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["AveragePagesPerMinute"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("An array of integers indicating Printer capabilities. Information such as \"Duplex" +
            " Printing\" (value=3) or \"Transparency Printing\" (7) is specified in this propert" +
            "y.")]
        public CapabilitiesValues[] Capabilities {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["Capabilities"]));
                CapabilitiesValues[] enumToRet = new CapabilitiesValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((CapabilitiesValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("An array of free-form strings providing more detailed explanations for any of the" +
            " Printer features indicated in the Capabilities array. Note, each entry of this " +
            "array is related to the entry in the Capabilities array that is located at the s" +
            "ame index.")]
        public string[] CapabilityDescriptions {
            get {
                return ((string[])(curObj["CapabilityDescriptions"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Caption property is a short textual description (one-line string) of the obje" +
            "ct.")]
        public string Caption {
            get {
                return ((string)(curObj["Caption"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Identifies the available character sets for the output of text related to managing the Printer. Strings provided in this property should conform to the semantics and syntax specified by section 4.1.2 (""Charset parameter"") in RFC 2046 (MIME Part 2) and contained in the IANA character-set registry. Examples include ""utf-8"", ""us-ascii"" and ""iso-8859-1"".")]
        public string[] CharSetsSupported {
            get {
                return ((string[])(curObj["CharSetsSupported"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Comment property specifies the comment of a print queue.\nExample: Color print" +
            "er")]
        public string Comment {
            get {
                return ((string)(curObj["Comment"]));
            }
            set {
                curObj["Comment"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigManagerErrorCodeNull {
            get {
                if ((curObj["ConfigManagerErrorCode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates the Win32 Configuration Manager error code.  The following values may b" +
            "e returned: \n0\tThis device is working properly. \n1\tThis device is not configured" +
            " correctly. \n2\tWindows cannot load the driver for this device. \n3\tThe driver for" +
            " this device might be corrupted, or your system may be running low on memory or " +
            "other resources. \n4\tThis device is not working properly. One of its drivers or y" +
            "our registry might be corrupted. \n5\tThe driver for this device needs a resource " +
            "that Windows cannot manage. \n6\tThe boot configuration for this device conflicts " +
            "with other devices. \n7\tCannot filter. \n8\tThe driver loader for the device is mis" +
            "sing. \n9\tThis device is not working properly because the controlling firmware is" +
            " reporting the resources for the device incorrectly. \n10\tThis device cannot star" +
            "t. \n11\tThis device failed. \n12\tThis device cannot find enough free resources tha" +
            "t it can use. \n13\tWindows cannot verify this device\'s resources. \n14\tThis device" +
            " cannot work properly until you restart your computer. \n15\tThis device is not wo" +
            "rking properly because there is probably a re-enumeration problem. \n16\tWindows c" +
            "annot identify all the resources this device uses. \n17\tThis device is asking for" +
            " an unknown resource type. \n18\tReinstall the drivers for this device. \n19\tYour r" +
            "egistry might be corrupted. \n20\tFailure using the VxD loader. \n21\tSystem failure" +
            ": Try changing the driver for this device. If that does not work, see your hardw" +
            "are documentation. Windows is removing this device. \n22\tThis device is disabled." +
            " \n23\tSystem failure: Try changing the driver for this device. If that doesn\'t wo" +
            "rk, see your hardware documentation. \n24\tThis device is not present, is not work" +
            "ing properly, or does not have all its drivers installed. \n25\tWindows is still s" +
            "etting up this device. \n26\tWindows is still setting up this device. \n27\tThis dev" +
            "ice does not have valid log configuration. \n28\tThe drivers for this device are n" +
            "ot installed. \n29\tThis device is disabled because the firmware of the device did" +
            " not give it the required resources. \n30\tThis device is using an Interrupt Reque" +
            "st (IRQ) resource that another device is using. \n31\tThis device is not working p" +
            "roperly because Windows cannot load the drivers required for this device.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ConfigManagerErrorCodeValues ConfigManagerErrorCode {
            get {
                if ((curObj["ConfigManagerErrorCode"] == null)) {
                    return ((ConfigManagerErrorCodeValues)(System.Convert.ToInt32(32)));
                }
                return ((ConfigManagerErrorCodeValues)(System.Convert.ToInt32(curObj["ConfigManagerErrorCode"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsConfigManagerUserConfigNull {
            get {
                if ((curObj["ConfigManagerUserConfig"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates whether the device is using a user-defined configuration.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ConfigManagerUserConfig {
            get {
                if ((curObj["ConfigManagerUserConfig"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ConfigManagerUserConfig"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("CreationClassName indicates the name of the class or the subclass used in the cre" +
            "ation of an instance. When used with the other key properties of this class, thi" +
            "s property allows all instances of this class and its subclasses to be uniquely " +
            "identified.")]
        public string CreationClassName {
            get {
                return ((string)(curObj["CreationClassName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Specifies which finishings and other capabilities of the Printer are currently be" +
            "ing used. An entry in this property should also be listed in the Capabilities ar" +
            "ray.")]
        public CurrentCapabilitiesValues[] CurrentCapabilities {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["CurrentCapabilities"]));
                CurrentCapabilitiesValues[] enumToRet = new CurrentCapabilitiesValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((CurrentCapabilitiesValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Specifies the current character set being used for the output of text relating to management of the Printer. The character set described by this property should also be listed in CharsetsSupported. The string specified by this property should conform to the semantics and syntax specified by section 4.1.2 (""Charset parameter"") in RFC 2046 (MIME Part 2) and contained in the IANA character-set registry. Examples include ""utf-8"", ""us-ascii"" and ""iso-8859-1"".")]
        public string CurrentCharSet {
            get {
                return ((string)(curObj["CurrentCharSet"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsCurrentLanguageNull {
            get {
                if ((curObj["CurrentLanguage"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates the current printer language being used. A language that is being used " +
            "by the Printer should also be listed in LanguagesSupported.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public CurrentLanguageValues CurrentLanguage {
            get {
                if ((curObj["CurrentLanguage"] == null)) {
                    return ((CurrentLanguageValues)(System.Convert.ToInt32(0)));
                }
                return ((CurrentLanguageValues)(System.Convert.ToInt32(curObj["CurrentLanguage"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Specifies the mime type currently being used by the Printer if the CurrentLanguag" +
            "e is set to indicate a mime type is in use (value = 47).")]
        public string CurrentMimeType {
            get {
                return ((string)(curObj["CurrentMimeType"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Identifies the current language being used by the Printer for management. The lan" +
            "guage listed in the CurrentNaturalLanguage property should also be listed in Nat" +
            "uralLanguagesSupported.")]
        public string CurrentNaturalLanguage {
            get {
                return ((string)(curObj["CurrentNaturalLanguage"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Specifies the paper type that the Printer is currently using. The string should b" +
            "e expressed in the form specified by ISO/IEC 10175 Document Printing Application" +
            " (DPA) which is also summarized in Appendix C of RFC 1759 (Printer MIB).")]
        public string CurrentPaperType {
            get {
                return ((string)(curObj["CurrentPaperType"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDefaultNull {
            get {
                if ((curObj["Default"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Default property indicates whether the printer is the default printer on the " +
            "computer.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Default {
            get {
                if ((curObj["Default"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Default"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Specifies which finishings and other capabilities of the Printer will be used by " +
            "default. An entry in DefaultCapabilities should also be listed in the Capabiliti" +
            "es array.")]
        public DefaultCapabilitiesValues[] DefaultCapabilities {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["DefaultCapabilities"]));
                DefaultCapabilitiesValues[] enumToRet = new DefaultCapabilitiesValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((DefaultCapabilitiesValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDefaultCopiesNull {
            get {
                if ((curObj["DefaultCopies"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The number of copies that will be produced for a single Job unless otherwise spec" +
            "ified.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint DefaultCopies {
            get {
                if ((curObj["DefaultCopies"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["DefaultCopies"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDefaultLanguageNull {
            get {
                if ((curObj["DefaultLanguage"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates the default printer language. A language that is used as a default by t" +
            "he Printer should also be listed in LanguagesSupported.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public DefaultLanguageValues DefaultLanguage {
            get {
                if ((curObj["DefaultLanguage"] == null)) {
                    return ((DefaultLanguageValues)(System.Convert.ToInt32(0)));
                }
                return ((DefaultLanguageValues)(System.Convert.ToInt32(curObj["DefaultLanguage"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Specifies the default mime type used by the Printer if the DefaultLanguage is set" +
            " to indicate a mime type is in use (value=47).")]
        public string DefaultMimeType {
            get {
                return ((string)(curObj["DefaultMimeType"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDefaultNumberUpNull {
            get {
                if ((curObj["DefaultNumberUp"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The number of print-stream pages that the Printer will render onto a single media" +
            " sheet unless a Job specifies otherwise.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint DefaultNumberUp {
            get {
                if ((curObj["DefaultNumberUp"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["DefaultNumberUp"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Specifies the paper type that the Printer will use if a PrintJob does not specify a particular type. The string should be expressed in the form specified by ISO/IEC 10175 Document Printing Application (DPA) which is also summarized in Appendix C of RFC 1759 (Printer MIB).")]
        public string DefaultPaperType {
            get {
                return ((string)(curObj["DefaultPaperType"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDefaultPriorityNull {
            get {
                if ((curObj["DefaultPriority"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DefaultPriority property specifies the default priority value assigned to eac" +
            "h print job.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint DefaultPriority {
            get {
                if ((curObj["DefaultPriority"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["DefaultPriority"]));
            }
            set {
                curObj["DefaultPriority"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Description property provides a textual description of the object. ")]
        public string Description {
            get {
                return ((string)(curObj["Description"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDetectedErrorStateNull {
            get {
                if ((curObj["DetectedErrorState"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Printer error information.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public DetectedErrorStateValues DetectedErrorState {
            get {
                if ((curObj["DetectedErrorState"] == null)) {
                    return ((DetectedErrorStateValues)(System.Convert.ToInt32(12)));
                }
                return ((DetectedErrorStateValues)(System.Convert.ToInt32(curObj["DetectedErrorState"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DeviceID property contains a string uniquely identifying the printer  with ot" +
            "her devices on the system.")]
        public string DeviceID {
            get {
                return ((string)(curObj["DeviceID"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDirectNull {
            get {
                if ((curObj["Direct"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Direct property indicates whether the print jobs should be sent directly to t" +
            "he printer.  This means that no spool files are created for the print jobs.\n")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Direct {
            get {
                if ((curObj["Direct"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Direct"]));
            }
            set {
                curObj["Direct"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsDoCompleteFirstNull {
            get {
                if ((curObj["DoCompleteFirst"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DoCompleteFirst property indicates whether the printer should start jobs that" +
            " have finished spooling as opposed to the order of the job received.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool DoCompleteFirst {
            get {
                if ((curObj["DoCompleteFirst"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["DoCompleteFirst"]));
            }
            set {
                curObj["DoCompleteFirst"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The DriverName property specifies the name of the Win32 printer driver.\nExample: " +
            "Windows NT Fax Driver")]
        public string DriverName {
            get {
                return ((string)(curObj["DriverName"]));
            }
            set {
                curObj["DriverName"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsEnableBIDINull {
            get {
                if ((curObj["EnableBIDI"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The EnableBIDI property indicates whether the printer can print bidirectionally.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool EnableBIDI {
            get {
                if ((curObj["EnableBIDI"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["EnableBIDI"]));
            }
            set {
                curObj["EnableBIDI"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsEnableDevQueryPrintNull {
            get {
                if ((curObj["EnableDevQueryPrint"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The EnableDevQueryPrint property indicates whether to hold documents in the queue" +
            ", if document and printer setups do not match")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool EnableDevQueryPrint {
            get {
                if ((curObj["EnableDevQueryPrint"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["EnableDevQueryPrint"]));
            }
            set {
                curObj["EnableDevQueryPrint"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsErrorClearedNull {
            get {
                if ((curObj["ErrorCleared"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("ErrorCleared is a boolean property indicating that the error reported in LastErro" +
            "rCode property is now cleared.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool ErrorCleared {
            get {
                if ((curObj["ErrorCleared"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["ErrorCleared"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("ErrorDescription is a free-form string supplying more information about the error" +
            " recorded in LastErrorCode property, and information on any corrective actions t" +
            "hat may be taken.")]
        public string ErrorDescription {
            get {
                return ((string)(curObj["ErrorDescription"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("An array providing supplemental information for the current error state, indicate" +
            "d in DetectedErrorState.")]
        public string[] ErrorInformation {
            get {
                return ((string[])(curObj["ErrorInformation"]));
            }
            set {
                curObj["ErrorInformation"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsExtendedDetectedErrorStateNull {
            get {
                if ((curObj["ExtendedDetectedErrorState"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ExtendedDetectedErrorState property reports standard error information.  Any " +
            "additional information should be recorded in the DetecteErrorState property.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ExtendedDetectedErrorStateValues ExtendedDetectedErrorState {
            get {
                if ((curObj["ExtendedDetectedErrorState"] == null)) {
                    return ((ExtendedDetectedErrorStateValues)(System.Convert.ToInt32(16)));
                }
                return ((ExtendedDetectedErrorStateValues)(System.Convert.ToInt32(curObj["ExtendedDetectedErrorState"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsExtendedPrinterStatusNull {
            get {
                if ((curObj["ExtendedPrinterStatus"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Status information for a Printer, beyond that specified in the LogicalDevice Avai" +
            "lability property. Values include \"Idle\" (3) and an indication that the Device i" +
            "s currently printing (4).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public ExtendedPrinterStatusValues ExtendedPrinterStatus {
            get {
                if ((curObj["ExtendedPrinterStatus"] == null)) {
                    return ((ExtendedPrinterStatusValues)(System.Convert.ToInt32(0)));
                }
                return ((ExtendedPrinterStatusValues)(System.Convert.ToInt32(curObj["ExtendedPrinterStatus"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsHiddenNull {
            get {
                if ((curObj["Hidden"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Hidden property indicates whether the printer is hidden from network users.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Hidden {
            get {
                if ((curObj["Hidden"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Hidden"]));
            }
            set {
                curObj["Hidden"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsHorizontalResolutionNull {
            get {
                if ((curObj["HorizontalResolution"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Printer\'s horizontal resolution in Pixels per Inch.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint HorizontalResolution {
            get {
                if ((curObj["HorizontalResolution"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["HorizontalResolution"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsInstallDateNull {
            get {
                if ((curObj["InstallDate"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The InstallDate property is datetime value indicating when the object was install" +
            "ed. A lack of a value does not indicate that the object is not installed.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime InstallDate {
            get {
                if ((curObj["InstallDate"] != null)) {
                    return ToDateTime(((string)(curObj["InstallDate"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsJobCountSinceLastResetNull {
            get {
                if ((curObj["JobCountSinceLastReset"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Printer jobs processed since last reset.  These jobs may be processed from one or" +
            " more PrintQueues.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint JobCountSinceLastReset {
            get {
                if ((curObj["JobCountSinceLastReset"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["JobCountSinceLastReset"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsKeepPrintedJobsNull {
            get {
                if ((curObj["KeepPrintedJobs"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The KeepPrintedJobs property indicates whether the print spooler should not delet" +
            "e the jobs after they are completed.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool KeepPrintedJobs {
            get {
                if ((curObj["KeepPrintedJobs"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["KeepPrintedJobs"]));
            }
            set {
                curObj["KeepPrintedJobs"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("An array indicating the print languages natively supported.")]
        public LanguagesSupportedValues[] LanguagesSupported {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["LanguagesSupported"]));
                LanguagesSupportedValues[] enumToRet = new LanguagesSupportedValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((LanguagesSupportedValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLastErrorCodeNull {
            get {
                if ((curObj["LastErrorCode"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("LastErrorCode captures the last error code reported by the logical device.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint LastErrorCode {
            get {
                if ((curObj["LastErrorCode"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["LastErrorCode"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLocalNull {
            get {
                if ((curObj["Local"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The Local property indicates whether the printer is attached to the network.  A masquerading printer is printer that is implemented as local printers but has a port that refers to a remote machine.  From the application perspective these hybrid printers should be viewed as printer connections since that is their intended behavior.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Local {
            get {
                if ((curObj["Local"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Local"]));
            }
            set {
                curObj["Local"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Location property specifies the physical location of the printer.\nExample: Bl" +
            "dg. 38, Room 1164")]
        public string Location {
            get {
                return ((string)(curObj["Location"]));
            }
            set {
                curObj["Location"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMarkingTechnologyNull {
            get {
                if ((curObj["MarkingTechnology"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Specifies the marking technology used by the Printer.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public MarkingTechnologyValues MarkingTechnology {
            get {
                if ((curObj["MarkingTechnology"] == null)) {
                    return ((MarkingTechnologyValues)(System.Convert.ToInt32(0)));
                }
                return ((MarkingTechnologyValues)(System.Convert.ToInt32(curObj["MarkingTechnology"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxCopiesNull {
            get {
                if ((curObj["MaxCopies"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The maximum number of copies that can be produced by the Printer from a single Jo" +
            "b.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MaxCopies {
            get {
                if ((curObj["MaxCopies"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MaxCopies"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxNumberUpNull {
            get {
                if ((curObj["MaxNumberUp"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The maximum number of print-stream pages that the Printer can render onto a singl" +
            "e media sheet.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MaxNumberUp {
            get {
                if ((curObj["MaxNumberUp"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MaxNumberUp"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsMaxSizeSupportedNull {
            get {
                if ((curObj["MaxSizeSupported"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Specifies the largest Job (as a byte stream) that the Printer will accept in unit" +
            "s of Kbytes. A value of zero indicates that no limit has been set.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint MaxSizeSupported {
            get {
                if ((curObj["MaxSizeSupported"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["MaxSizeSupported"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("An array of free-form strings providing more detailed explanations of any mime ty" +
            "pes that are supported by the Printer. If data is provided for this property, th" +
            "en the value 47, \"Mime\", should be included in the LanguagesSupported property.")]
        public string[] MimeTypesSupported {
            get {
                return ((string[])(curObj["MimeTypesSupported"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Name property defines the label by which the object is known. When subclassed" +
            ", the Name property can be overridden to be a Key property.")]
        public string Name {
            get {
                return ((string)(curObj["Name"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Identifies the available languages for strings used by the Printer for the output" +
            " of management information. The strings should conform to RFC 1766, for example " +
            "\"en\" is used for English.")]
        public string[] NaturalLanguagesSupported {
            get {
                return ((string[])(curObj["NaturalLanguagesSupported"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsNetworkNull {
            get {
                if ((curObj["Network"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Network property indicates whether the printer is a network printer.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Network {
            get {
                if ((curObj["Network"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Network"]));
            }
            set {
                curObj["Network"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("An integer array indicating the types of paper supported.")]
        public PaperSizesSupportedValues[] PaperSizesSupported {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["PaperSizesSupported"]));
                PaperSizesSupportedValues[] enumToRet = new PaperSizesSupportedValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((PaperSizesSupportedValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"An array of free-form strings specifying the types of paper that are currently available on the Printer. Each string should be expressed in the form specified by ISO/IEC 10175 Document Printing Application (DPA) which is also summarized in Appendix C of RFC 1759 (Printer MIB). Examples of valid strings are ""iso-a4-colored"" and ""na-10x14-envelope"". By definition a paper size that is available and listed in PaperTypesAvailable should also appear in the PaperSizesSupported property.")]
        public string[] PaperTypesAvailable {
            get {
                return ((string[])(curObj["PaperTypesAvailable"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Parameters property specifies optional parameters for the print processor.\nEx" +
            "ample: Copies=2")]
        public string Parameters {
            get {
                return ((string)(curObj["Parameters"]));
            }
            set {
                curObj["Parameters"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Indicates the Win32 Plug and Play device ID of the logical device.  Example: *PNP" +
            "030b")]
        public string PNPDeviceID {
            get {
                return ((string)(curObj["PNPDeviceID"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The PortName property identifies the ports that can be used to transmit data to the printer. If a printer is connected to more than one port, the names of each port are separated by commas. Under Windows 95, only one port can be specified. 
Example: LPT1:, LPT2:, LPT3:")]
        public string PortName {
            get {
                return ((string)(curObj["PortName"]));
            }
            set {
                curObj["PortName"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Indicates the specific power-related capabilities of the logical device. The array values, 0=""Unknown"", 1=""Not Supported"" and 2=""Disabled"" are self-explanatory. The value, 3=""Enabled"" indicates that the power management features are currently enabled but the exact feature set is unknown or the information is unavailable. ""Power Saving Modes Entered Automatically"" (4) describes that a device can change its power state based on usage or other criteria. ""Power State Settable"" (5) indicates that the SetPowerState method is supported. ""Power Cycling Supported"" (6) indicates that the SetPowerState method can be invoked with the PowerState input variable set to 5 (""Power Cycle""). ""Timed Power On Supported"" (7) indicates that the SetPowerState method can be invoked with the PowerState input variable set to 5 (""Power Cycle"") and the Time parameter set to a specific date and time, or interval, for power-on.")]
        public PowerManagementCapabilitiesValues[] PowerManagementCapabilities {
            get {
                System.Array arrEnumVals = ((System.Array)(curObj["PowerManagementCapabilities"]));
                PowerManagementCapabilitiesValues[] enumToRet = new PowerManagementCapabilitiesValues[arrEnumVals.Length];
                int counter = 0;
                for (counter = 0; (counter < arrEnumVals.Length); counter = (counter + 1)) {
                    enumToRet[counter] = ((PowerManagementCapabilitiesValues)(System.Convert.ToInt32(arrEnumVals.GetValue(counter))));
                }
                return enumToRet;
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPowerManagementSupportedNull {
            get {
                if ((curObj["PowerManagementSupported"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"Boolean indicating that the Device can be power managed - ie, put into a power save state. This boolean does not indicate that power management features are currently enabled, or if enabled, what features are supported. Refer to the PowerManagementCapabilities array for this information. If this boolean is false, the integer value 1, for the string, ""Not Supported"", should be the only entry in the PowerManagementCapabilities array.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool PowerManagementSupported {
            get {
                if ((curObj["PowerManagementSupported"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["PowerManagementSupported"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The PrinterPaperNames property indicates the list of paper sizes supported by the" +
            " printer. The printer-specified names are used to represent supported paper size" +
            "s.\nExample: B5 (JIS).")]
        public string[] PrinterPaperNames {
            get {
                return ((string[])(curObj["PrinterPaperNames"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPrinterStateNull {
            get {
                if ((curObj["PrinterState"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"This property has been deprecated in favor of PrinterStatus, DetectedErrorState and ErrorInformation CIM properties that more clearly indicate the state and error status of the printer. The PrinterState property specifies a values indicating one of the possible states relating to this printer.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public PrinterStateValues PrinterState {
            get {
                if ((curObj["PrinterState"] == null)) {
                    return ((PrinterStateValues)(System.Convert.ToInt32(25)));
                }
                return ((PrinterStateValues)(System.Convert.ToInt32(curObj["PrinterState"])));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPrinterStatusNull {
            get {
                if ((curObj["PrinterStatus"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Status information for a Printer, beyond that specified in the LogicalDevice Avai" +
            "lability property. Values include \"Idle\" (3) and an indication that the Device i" +
            "s currently printing (4).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public PrinterStatusValues PrinterStatus {
            get {
                if ((curObj["PrinterStatus"] == null)) {
                    return ((PrinterStatusValues)(System.Convert.ToInt32(0)));
                }
                return ((PrinterStatusValues)(System.Convert.ToInt32(curObj["PrinterStatus"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The PrintJobDataType property indicates the default data type that will be used f" +
            "or a print job.")]
        public string PrintJobDataType {
            get {
                return ((string)(curObj["PrintJobDataType"]));
            }
            set {
                curObj["PrintJobDataType"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The PrintProcessor property specifies the name of the print spooler that handles " +
            "print jobs.\nExample: SPOOLSS.DLL.")]
        public string PrintProcessor {
            get {
                return ((string)(curObj["PrintProcessor"]));
            }
            set {
                curObj["PrintProcessor"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPriorityNull {
            get {
                if ((curObj["Priority"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Priority property specifies the priority of the  printer. The jobs on a highe" +
            "r priority printer are scheduled first.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint Priority {
            get {
                if ((curObj["Priority"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["Priority"]));
            }
            set {
                curObj["Priority"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsPublishedNull {
            get {
                if ((curObj["Published"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Published property indicates whether the printer is published in the network " +
            "directory service.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Published {
            get {
                if ((curObj["Published"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Published"]));
            }
            set {
                curObj["Published"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsQueuedNull {
            get {
                if ((curObj["Queued"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Queued property indicates whether the printer buffers and queues print jobs.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Queued {
            get {
                if ((curObj["Queued"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Queued"]));
            }
            set {
                curObj["Queued"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsRawOnlyNull {
            get {
                if ((curObj["RawOnly"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The RawOnly property indicates whether the printer accepts only raw data to be sp" +
            "ooled.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool RawOnly {
            get {
                if ((curObj["RawOnly"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["RawOnly"]));
            }
            set {
                curObj["RawOnly"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SeparatorFile property specifies the name of the file used to create a separa" +
            "tor page. This page is used to separate print jobs sent to the printer.")]
        public string SeparatorFile {
            get {
                return ((string)(curObj["SeparatorFile"]));
            }
            set {
                curObj["SeparatorFile"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ServerName property identifies the server that controls the printer. If this " +
            "string is NULL, the printer is controlled locally. ")]
        public string ServerName {
            get {
                return ((string)(curObj["ServerName"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSharedNull {
            get {
                if ((curObj["Shared"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The Shared property indicates whether the printer is available as a shared networ" +
            "k resource.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool Shared {
            get {
                if ((curObj["Shared"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["Shared"]));
            }
            set {
                curObj["Shared"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The ShareName property indicates the share name of the Win32 printing device.\nExa" +
            "mple: \\\\PRINTSERVER1\\PRINTER2")]
        public string ShareName {
            get {
                return ((string)(curObj["ShareName"]));
            }
            set {
                curObj["ShareName"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsSpoolEnabledNull {
            get {
                if ((curObj["SpoolEnabled"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The SpoolEnabled property shows whether spooling is enabled for this printer. \nVa" +
            "lues:TRUE or FALSE. \nThe SpoolEnabled property has been deprecated.  There is no" +
            " replacementvalue and this property is now considered obsolete.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool SpoolEnabled {
            get {
                if ((curObj["SpoolEnabled"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["SpoolEnabled"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsStartTimeNull {
            get {
                if ((curObj["StartTime"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The StartTime property specifies the earliest time the printer can print a job (i" +
            "f the printer has been limited to print only at certain times). This value is ex" +
            "pressed as time elapsed since 12:00 AM GMT (Greenwich mean time).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime StartTime {
            get {
                if ((curObj["StartTime"] != null)) {
                    return ToDateTime(((string)(curObj["StartTime"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
            set {
                curObj["StartTime"] = ToDmtfDateTime(((System.DateTime)(value)));
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description(@"The Status property is a string indicating the current status of the object. Various operational and non-operational statuses can be defined. Operational statuses are ""OK"", ""Degraded"" and ""Pred Fail"". ""Pred Fail"" indicates that an element may be functioning properly but predicting a failure in the near future. An example is a SMART-enabled hard drive. Non-operational statuses can also be specified. These are ""Error"", ""Starting"", ""Stopping"" and ""Service"". The latter, ""Service"", could apply during mirror-resilvering of a disk, reload of a user permissions list, or other administrative work. Not all such work is on-line, yet the managed element is neither ""OK"" nor in one of the other states.")]
        public string Status {
            get {
                return ((string)(curObj["Status"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsStatusInfoNull {
            get {
                if ((curObj["StatusInfo"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("StatusInfo is a string indicating whether the logical device is in an enabled (va" +
            "lue = 3), disabled (value = 4) or some other (1) or unknown (2) state. If this p" +
            "roperty does not apply to the logical device, the value, 5 (\"Not Applicable\"), s" +
            "hould be used.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public StatusInfoValues StatusInfo {
            get {
                if ((curObj["StatusInfo"] == null)) {
                    return ((StatusInfoValues)(System.Convert.ToInt32(0)));
                }
                return ((StatusInfoValues)(System.Convert.ToInt32(curObj["StatusInfo"])));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The scoping System\'s CreationClassName.")]
        public string SystemCreationClassName {
            get {
                return ((string)(curObj["SystemCreationClassName"]));
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The scoping System\'s Name.")]
        public string SystemName {
            get {
                return ((string)(curObj["SystemName"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsTimeOfLastResetNull {
            get {
                if ((curObj["TimeOfLastReset"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Time of last reset of the Printer Device.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime TimeOfLastReset {
            get {
                if ((curObj["TimeOfLastReset"] != null)) {
                    return ToDateTime(((string)(curObj["TimeOfLastReset"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsUntilTimeNull {
            get {
                if ((curObj["UntilTime"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The UntilTime property specifies the latest time the printer can print a job (if " +
            "the printer has been limited to print only at certain times). This value is expr" +
            "essed as time elapsed since 12:00 AM GMT (Greenwich mean time).")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public System.DateTime UntilTime {
            get {
                if ((curObj["UntilTime"] != null)) {
                    return ToDateTime(((string)(curObj["UntilTime"])));
                }
                else {
                    return System.DateTime.MinValue;
                }
            }
            set {
                curObj["UntilTime"] = ToDmtfDateTime(((System.DateTime)(value)));
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsVerticalResolutionNull {
            get {
                if ((curObj["VerticalResolution"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("Printer\'s vertical resolution in Pixels per Inch.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public uint VerticalResolution {
            get {
                if ((curObj["VerticalResolution"] == null)) {
                    return System.Convert.ToUInt32(0);
                }
                return ((uint)(curObj["VerticalResolution"]));
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsWorkOfflineNull {
            get {
                if ((curObj["WorkOffline"] == null)) {
                    return true;
                }
                else {
                    return false;
                }
            }
        }
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Description("The WorkOffline property indicates whether to queue print jobs on the computer if" +
            " the printer is offline.")]
        [TypeConverter(typeof(WMIValueTypeConverter))]
        public bool WorkOffline {
            get {
                if ((curObj["WorkOffline"] == null)) {
                    return System.Convert.ToBoolean(0);
                }
                return ((bool)(curObj["WorkOffline"]));
            }
            set {
                curObj["WorkOffline"] = value;
                if (((isEmbedded == false) 
                            && (AutoCommitProp == true))) {
                    PrivateLateBoundObject.Put();
                }
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions OptionsParam) {
            if (((path != null) 
                        && (string.Compare(path.ClassName, this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0))) {
                return true;
            }
            else {
                return CheckIfProperClass(new System.Management.ManagementObject(mgmtScope, path, OptionsParam));
            }
        }
        
        private bool CheckIfProperClass(System.Management.ManagementBaseObject theObj) {
            if (((theObj != null) 
                        && (string.Compare(((string)(theObj["__CLASS"])), this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0))) {
                return true;
            }
            else {
                System.Array parentClasses = ((System.Array)(theObj["__DERIVATION"]));
                if ((parentClasses != null)) {
                    int count = 0;
                    for (count = 0; (count < parentClasses.Length); count = (count + 1)) {
                        if ((string.Compare(((string)(parentClasses.GetValue(count))), this.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) == 0)) {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        
        private bool ShouldSerializeAttributes() {
            if ((this.IsAttributesNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetAttributes() {
            curObj["Attributes"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeAvailability() {
            if ((this.IsAvailabilityNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeAveragePagesPerMinute() {
            if ((this.IsAveragePagesPerMinuteNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetComment() {
            curObj["Comment"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeConfigManagerErrorCode() {
            if ((this.IsConfigManagerErrorCodeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeConfigManagerUserConfig() {
            if ((this.IsConfigManagerUserConfigNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeCurrentLanguage() {
            if ((this.IsCurrentLanguageNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDefault() {
            if ((this.IsDefaultNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDefaultCopies() {
            if ((this.IsDefaultCopiesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDefaultLanguage() {
            if ((this.IsDefaultLanguageNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDefaultNumberUp() {
            if ((this.IsDefaultNumberUpNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDefaultPriority() {
            if ((this.IsDefaultPriorityNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetDefaultPriority() {
            curObj["DefaultPriority"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeDetectedErrorState() {
            if ((this.IsDetectedErrorStateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeDirect() {
            if ((this.IsDirectNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetDirect() {
            curObj["Direct"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeDoCompleteFirst() {
            if ((this.IsDoCompleteFirstNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetDoCompleteFirst() {
            curObj["DoCompleteFirst"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetDriverName() {
            curObj["DriverName"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeEnableBIDI() {
            if ((this.IsEnableBIDINull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetEnableBIDI() {
            curObj["EnableBIDI"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeEnableDevQueryPrint() {
            if ((this.IsEnableDevQueryPrintNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetEnableDevQueryPrint() {
            curObj["EnableDevQueryPrint"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeErrorCleared() {
            if ((this.IsErrorClearedNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetErrorInformation() {
            curObj["ErrorInformation"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeExtendedDetectedErrorState() {
            if ((this.IsExtendedDetectedErrorStateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeExtendedPrinterStatus() {
            if ((this.IsExtendedPrinterStatusNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeHidden() {
            if ((this.IsHiddenNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetHidden() {
            curObj["Hidden"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeHorizontalResolution() {
            if ((this.IsHorizontalResolutionNull == false)) {
                return true;
            }
            return false;
        }
        
        // Converts a given datetime in DMTF format to System.DateTime object.
        static System.DateTime ToDateTime(string dmtfDate) {
            System.DateTime initializer = System.DateTime.MinValue;
            int year = initializer.Year;
            int month = initializer.Month;
            int day = initializer.Day;
            int hour = initializer.Hour;
            int minute = initializer.Minute;
            int second = initializer.Second;
            long ticks = 0;
            string dmtf = dmtfDate;
            System.DateTime datetime = System.DateTime.MinValue;
            string tempString = string.Empty;
            if ((dmtf == null)) {
                throw new System.ArgumentOutOfRangeException();
            }
            if ((dmtf.Length == 0)) {
                throw new System.ArgumentOutOfRangeException();
            }
            if ((dmtf.Length != 25)) {
                throw new System.ArgumentOutOfRangeException();
            }
            try {
                tempString = dmtf.Substring(0, 4);
                if (("****" != tempString)) {
                    year = int.Parse(tempString);
                }
                tempString = dmtf.Substring(4, 2);
                if (("**" != tempString)) {
                    month = int.Parse(tempString);
                }
                tempString = dmtf.Substring(6, 2);
                if (("**" != tempString)) {
                    day = int.Parse(tempString);
                }
                tempString = dmtf.Substring(8, 2);
                if (("**" != tempString)) {
                    hour = int.Parse(tempString);
                }
                tempString = dmtf.Substring(10, 2);
                if (("**" != tempString)) {
                    minute = int.Parse(tempString);
                }
                tempString = dmtf.Substring(12, 2);
                if (("**" != tempString)) {
                    second = int.Parse(tempString);
                }
                tempString = dmtf.Substring(15, 6);
                if (("******" != tempString)) {
                    ticks = (long.Parse(tempString) * ((long)((System.TimeSpan.TicksPerMillisecond / 1000))));
                }
                if (((((((((year < 0) 
                            || (month < 0)) 
                            || (day < 0)) 
                            || (hour < 0)) 
                            || (minute < 0)) 
                            || (minute < 0)) 
                            || (second < 0)) 
                            || (ticks < 0))) {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
            catch (System.Exception e) {
                throw new System.ArgumentOutOfRangeException(null, e.Message);
            }
            datetime = new System.DateTime(year, month, day, hour, minute, second, 0);
            datetime = datetime.AddTicks(ticks);
            System.TimeSpan tickOffset = System.TimeZone.CurrentTimeZone.GetUtcOffset(datetime);
            int UTCOffset = 0;
            int OffsetToBeAdjusted = 0;
            long OffsetMins = ((long)((tickOffset.Ticks / System.TimeSpan.TicksPerMinute)));
            tempString = dmtf.Substring(22, 3);
            if ((tempString != "******")) {
                tempString = dmtf.Substring(21, 4);
                try {
                    UTCOffset = int.Parse(tempString);
                }
                catch (System.Exception e) {
                    throw new System.ArgumentOutOfRangeException(null, e.Message);
                }
                OffsetToBeAdjusted = ((int)((OffsetMins - UTCOffset)));
                datetime = datetime.AddMinutes(((double)(OffsetToBeAdjusted)));
            }
            return datetime;
        }
        
        // Converts a given System.DateTime object to DMTF datetime format.
        static string ToDmtfDateTime(System.DateTime date) {
            string utcString = string.Empty;
            System.TimeSpan tickOffset = System.TimeZone.CurrentTimeZone.GetUtcOffset(date);
            long OffsetMins = ((long)((tickOffset.Ticks / System.TimeSpan.TicksPerMinute)));
            if ((System.Math.Abs(OffsetMins) > 999)) {
                date = date.ToUniversalTime();
                utcString = "+000";
            }
            else {
                if ((tickOffset.Ticks >= 0)) {
                    utcString = string.Concat("+", ((System.Int64 )((tickOffset.Ticks / System.TimeSpan.TicksPerMinute))).ToString().PadLeft(3, '0'));
                }
                else {
                    string strTemp = ((System.Int64 )(OffsetMins)).ToString();
                    utcString = string.Concat("-", strTemp.Substring(1, (strTemp.Length - 1)).PadLeft(3, '0'));
                }
            }
            string dmtfDateTime = ((System.Int32 )(date.Year)).ToString().PadLeft(4, '0');
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Month)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Day)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Hour)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Minute)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ((System.Int32 )(date.Second)).ToString().PadLeft(2, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, ".");
            System.DateTime dtTemp = new System.DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second, 0);
            long microsec = ((long)((((date.Ticks - dtTemp.Ticks) 
                        * 1000) 
                        / System.TimeSpan.TicksPerMillisecond)));
            string strMicrosec = ((System.Int64 )(microsec)).ToString();
            if ((strMicrosec.Length > 6)) {
                strMicrosec = strMicrosec.Substring(0, 6);
            }
            dmtfDateTime = string.Concat(dmtfDateTime, strMicrosec.PadLeft(6, '0'));
            dmtfDateTime = string.Concat(dmtfDateTime, utcString);
            return dmtfDateTime;
        }
        
        private bool ShouldSerializeInstallDate() {
            if ((this.IsInstallDateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeJobCountSinceLastReset() {
            if ((this.IsJobCountSinceLastResetNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeKeepPrintedJobs() {
            if ((this.IsKeepPrintedJobsNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetKeepPrintedJobs() {
            curObj["KeepPrintedJobs"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeLastErrorCode() {
            if ((this.IsLastErrorCodeNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeLocal() {
            if ((this.IsLocalNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetLocal() {
            curObj["Local"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetLocation() {
            curObj["Location"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeMarkingTechnology() {
            if ((this.IsMarkingTechnologyNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxCopies() {
            if ((this.IsMaxCopiesNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxNumberUp() {
            if ((this.IsMaxNumberUpNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeMaxSizeSupported() {
            if ((this.IsMaxSizeSupportedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeNetwork() {
            if ((this.IsNetworkNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetNetwork() {
            curObj["Network"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetParameters() {
            curObj["Parameters"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetPortName() {
            curObj["PortName"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializePowerManagementSupported() {
            if ((this.IsPowerManagementSupportedNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePrinterState() {
            if ((this.IsPrinterStateNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializePrinterStatus() {
            if ((this.IsPrinterStatusNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetPrintJobDataType() {
            curObj["PrintJobDataType"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetPrintProcessor() {
            curObj["PrintProcessor"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializePriority() {
            if ((this.IsPriorityNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetPriority() {
            curObj["Priority"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializePublished() {
            if ((this.IsPublishedNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetPublished() {
            curObj["Published"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeQueued() {
            if ((this.IsQueuedNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetQueued() {
            curObj["Queued"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeRawOnly() {
            if ((this.IsRawOnlyNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetRawOnly() {
            curObj["RawOnly"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetSeparatorFile() {
            curObj["SeparatorFile"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeShared() {
            if ((this.IsSharedNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetShared() {
            curObj["Shared"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private void ResetShareName() {
            curObj["ShareName"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeSpoolEnabled() {
            if ((this.IsSpoolEnabledNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeStartTime() {
            if ((this.IsStartTimeNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetStartTime() {
            curObj["StartTime"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeStatusInfo() {
            if ((this.IsStatusInfoNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeTimeOfLastReset() {
            if ((this.IsTimeOfLastResetNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeUntilTime() {
            if ((this.IsUntilTimeNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetUntilTime() {
            curObj["UntilTime"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        private bool ShouldSerializeVerticalResolution() {
            if ((this.IsVerticalResolutionNull == false)) {
                return true;
            }
            return false;
        }
        
        private bool ShouldSerializeWorkOffline() {
            if ((this.IsWorkOfflineNull == false)) {
                return true;
            }
            return false;
        }
        
        private void ResetWorkOffline() {
            curObj["WorkOffline"] = null;
            if (((isEmbedded == false) 
                        && (AutoCommitProp == true))) {
                PrivateLateBoundObject.Put();
            }
        }
        
        [Browsable(true)]
        public void CommitObject() {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put();
            }
        }
        
        [Browsable(true)]
        public void CommitObject(System.Management.PutOptions putOptions) {
            if ((isEmbedded == false)) {
                PrivateLateBoundObject.Put(putOptions);
            }
        }
        
        private void Initialize() {
            AutoCommitProp = true;
            isEmbedded = false;
        }
        
        private static string ConstructPath(string keyDeviceID) {
            string strPath = "root\\CimV2:Win32_Printer";
            strPath = string.Concat(strPath, string.Concat(".DeviceID=", string.Concat("\"", string.Concat(keyDeviceID, "\""))));
            return strPath;
        }
        
        private void InitializeObject(System.Management.ManagementScope mgmtScope, System.Management.ManagementPath path, System.Management.ObjectGetOptions getOptions) {
            Initialize();
            if ((path != null)) {
                if ((CheckIfProperClass(mgmtScope, path, getOptions) != true)) {
                    throw new System.ArgumentException("Class name does not match.");
                }
            }
            PrivateLateBoundObject = new System.Management.ManagementObject(mgmtScope, path, getOptions);
            PrivateSystemProperties = new ManagementSystemProperties(PrivateLateBoundObject);
            curObj = PrivateLateBoundObject;
        }
        
        // Different overloads of GetInstances() help in enumerating instances of the WMI class.
        public static PrinterCollection GetInstances() {
            return GetInstances(null, null, null);
        }
        
        public static PrinterCollection GetInstances(string condition) {
            return GetInstances(null, condition, null);
        }
        
        public static PrinterCollection GetInstances(System.String [] selectedProperties) {
            return GetInstances(null, null, selectedProperties);
        }
        
        public static PrinterCollection GetInstances(string condition, System.String [] selectedProperties) {
            return GetInstances(null, condition, selectedProperties);
        }
        
        public static PrinterCollection GetInstances(System.Management.ManagementScope mgmtScope, System.Management.EnumerationOptions enumOptions) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\CimV2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementPath pathObj = new System.Management.ManagementPath();
            pathObj.ClassName = "Win32_Printer";
            pathObj.NamespacePath = "root\\CimV2";
            System.Management.ManagementClass clsObject = new System.Management.ManagementClass(mgmtScope, pathObj, null);
            if ((enumOptions == null)) {
                enumOptions = new System.Management.EnumerationOptions();
                enumOptions.EnsureLocatable = true;
            }
            return new PrinterCollection(clsObject.GetInstances(enumOptions));
        }
        
        public static PrinterCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition) {
            return GetInstances(mgmtScope, condition, null);
        }
        
        public static PrinterCollection GetInstances(System.Management.ManagementScope mgmtScope, System.String [] selectedProperties) {
            return GetInstances(mgmtScope, null, selectedProperties);
        }
        
        public static PrinterCollection GetInstances(System.Management.ManagementScope mgmtScope, string condition, System.String [] selectedProperties) {
            if ((mgmtScope == null)) {
                if ((statMgmtScope == null)) {
                    mgmtScope = new System.Management.ManagementScope();
                    mgmtScope.Path.NamespacePath = "root\\CimV2";
                }
                else {
                    mgmtScope = statMgmtScope;
                }
            }
            System.Management.ManagementObjectSearcher ObjectSearcher = new System.Management.ManagementObjectSearcher(mgmtScope, new SelectQuery("Win32_Printer", condition, selectedProperties));
            System.Management.EnumerationOptions enumOptions = new System.Management.EnumerationOptions();
            enumOptions.EnsureLocatable = true;
            ObjectSearcher.Options = enumOptions;
            return new PrinterCollection(ObjectSearcher.Get());
        }
        
        [Browsable(true)]
        public static Printer CreateInstance() {
            System.Management.ManagementScope mgmtScope = null;
            if ((statMgmtScope == null)) {
                mgmtScope = new System.Management.ManagementScope();
                mgmtScope.Path.NamespacePath = CreatedWmiNamespace;
            }
            else {
                mgmtScope = statMgmtScope;
            }
            System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
            System.Management.ManagementClass tmpMgmtClass = new System.Management.ManagementClass(mgmtScope, mgmtPath, null);
            return new Printer(tmpMgmtClass.CreateInstance());
        }
        
        [Browsable(true)]
        public void Delete() {
            PrivateLateBoundObject.Delete();
        }
        
        public static uint AddPrinterConnection(string Name) {
            bool IsMethodStatic = true;
            if ((IsMethodStatic == true)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementPath mgmtPath = new System.Management.ManagementPath(CreatedClassName);
                System.Management.ManagementClass classObj = new System.Management.ManagementClass(statMgmtScope, mgmtPath, null);
                inParams = classObj.GetMethodParameters("AddPrinterConnection");
                inParams["Name"] = ((System.String )(Name));
                System.Management.ManagementBaseObject outParams = classObj.InvokeMethod("AddPrinterConnection", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint CancelAllJobs() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("CancelAllJobs", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint Pause() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Pause", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint PrintTestPage() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("PrintTestPage", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint RenamePrinter(string NewPrinterName) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("RenamePrinter");
                inParams["NewPrinterName"] = ((System.String )(NewPrinterName));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("RenamePrinter", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint Reset() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Reset", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint Resume() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("Resume", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetDefaultPrinter() {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetDefaultPrinter", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public uint SetPowerState(ushort PowerState, System.DateTime Time) {
            if ((isEmbedded == false)) {
                System.Management.ManagementBaseObject inParams = null;
                inParams = PrivateLateBoundObject.GetMethodParameters("SetPowerState");
                inParams["PowerState"] = ((System.UInt16 )(PowerState));
                inParams["Time"] = ToDmtfDateTime(((System.DateTime)(Time)));
                System.Management.ManagementBaseObject outParams = PrivateLateBoundObject.InvokeMethod("SetPowerState", inParams, null);
                return System.Convert.ToUInt32(outParams.Properties["ReturnValue"].Value);
            }
            else {
                return System.Convert.ToUInt32(0);
            }
        }
        
        public enum AttributesValues {
            
            Queued0 = 1,
            
            Direct0 = 2,
            
            Default0 = 4,
            
            Shared0 = 8,
            
            Network0 = 16,
            
            Hidden0 = 32,
            
            Local0 = 64,
            
            EnableDevQ = 128,
            
            KeepPrintedJobs0 = 256,
            
            DoCompleteFirst0 = 512,
            
            WorkOffline0 = 1024,
            
            EnableBIDI0 = 2048,
            
            RawOnly0 = 4096,
            
            Published0 = 8192,
            
            NULL_ENUM_VALUE = 16384,
        }
        
        public enum AvailabilityValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            Running_Full_Power = 3,
            
            Warning = 4,
            
            In_Test = 5,
            
            Not_Applicable = 6,
            
            Power_Off = 7,
            
            Off_Line = 8,
            
            Off_Duty = 9,
            
            Degraded = 10,
            
            Not_Installed = 11,
            
            Install_Error = 12,
            
            Power_Save_Unknown = 13,
            
            Power_Save_Low_Power_Mode = 14,
            
            Power_Save_Standby = 15,
            
            Power_Cycle = 16,
            
            Power_Save_Warning = 17,
            
            Paused = 18,
            
            Not_Ready = 19,
            
            Not_Configured = 20,
            
            Quiesced = 21,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum CapabilitiesValues {
            
            Unknown0 = 0,
            
            Other0 = 1,
            
            Color_Printing = 2,
            
            Duplex_Printing = 3,
            
            Copies = 4,
            
            Collation = 5,
            
            Stapling = 6,
            
            Transparency_Printing = 7,
            
            Punch = 8,
            
            Cover = 9,
            
            Bind = 10,
            
            Black_and_White_Printing = 11,
            
            One_Sided = 12,
            
            Two_Sided_Long_Edge = 13,
            
            Two_Sided_Short_Edge = 14,
            
            Portrait = 15,
            
            Landscape = 16,
            
            Reverse_Portrait = 17,
            
            Reverse_Landscape = 18,
            
            Quality_High = 19,
            
            Quality_Normal = 20,
            
            Quality_Low = 21,
            
            NULL_ENUM_VALUE = 22,
        }
        
        public enum ConfigManagerErrorCodeValues {
            
            This_device_is_working_properly_ = 0,
            
            This_device_is_not_configured_correctly_ = 1,
            
            Windows_cannot_load_the_driver_for_this_device_ = 2,
            
            The_driver_for_this_device_might_be_corrupted_or_your_system_may_be_running_low_on_memory_or_other_resources_ = 3,
            
            This_device_is_not_working_properly_One_of_its_drivers_or_your_registry_might_be_corrupted_ = 4,
            
            The_driver_for_this_device_needs_a_resource_that_Windows_cannot_manage_ = 5,
            
            The_boot_configuration_for_this_device_conflicts_with_other_devices_ = 6,
            
            Cannot_filter_ = 7,
            
            The_driver_loader_for_the_device_is_missing_ = 8,
            
            This_device_is_not_working_properly_because_the_controlling_firmware_is_reporting_the_resources_for_the_device_incorrectly_ = 9,
            
            This_device_cannot_start_ = 10,
            
            This_device_failed_ = 11,
            
            This_device_cannot_find_enough_free_resources_that_it_can_use_ = 12,
            
            Windows_cannot_verify_this_device_s_resources_ = 13,
            
            This_device_cannot_work_properly_until_you_restart_your_computer_ = 14,
            
            This_device_is_not_working_properly_because_there_is_probably_a_re_enumeration_problem_ = 15,
            
            Windows_cannot_identify_all_the_resources_this_device_uses_ = 16,
            
            This_device_is_asking_for_an_unknown_resource_type_ = 17,
            
            Reinstall_the_drivers_for_this_device_ = 18,
            
            Failure_using_the_VxD_loader_ = 19,
            
            Your_registry_might_be_corrupted_ = 20,
            
            System_failure_Try_changing_the_driver_for_this_device_If_that_does_not_work_see_your_hardware_documentation_Windows_is_removing_this_device_ = 21,
            
            This_device_is_disabled_ = 22,
            
            System_failure_Try_changing_the_driver_for_this_device_If_that_doesn_t_work_see_your_hardware_documentation_ = 23,
            
            This_device_is_not_present_is_not_working_properly_or_does_not_have_all_its_drivers_installed_ = 24,
            
            Windows_is_still_setting_up_this_device_ = 25,
            
            Windows_is_still_setting_up_this_device_0 = 26,
            
            This_device_does_not_have_valid_log_configuration_ = 27,
            
            The_drivers_for_this_device_are_not_installed_ = 28,
            
            This_device_is_disabled_because_the_firmware_of_the_device_did_not_give_it_the_required_resources_ = 29,
            
            This_device_is_using_an_Interrupt_Request_IRQ_resource_that_another_device_is_using_ = 30,
            
            This_device_is_not_working_properly_because_Windows_cannot_load_the_drivers_required_for_this_device_ = 31,
            
            NULL_ENUM_VALUE = 32,
        }
        
        public enum CurrentCapabilitiesValues {
            
            Unknown0 = 0,
            
            Other0 = 1,
            
            Color_Printing = 2,
            
            Duplex_Printing = 3,
            
            Copies = 4,
            
            Collation = 5,
            
            Stapling = 6,
            
            Transparency_Printing = 7,
            
            Punch = 8,
            
            Cover = 9,
            
            Bind = 10,
            
            Black_and_White_Printing = 11,
            
            One_Sided = 12,
            
            Two_Sided_Long_Edge = 13,
            
            Two_Sided_Short_Edge = 14,
            
            Portrait = 15,
            
            Landscape = 16,
            
            Reverse_Portrait = 17,
            
            Reverse_Landscape = 18,
            
            Quality_High = 19,
            
            Quality_Normal = 20,
            
            Quality_Low = 21,
            
            NULL_ENUM_VALUE = 22,
        }
        
        public enum CurrentLanguageValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            PCL = 3,
            
            HPGL = 4,
            
            PJL = 5,
            
            PS = 6,
            
            PSPrinter = 7,
            
            IPDS = 8,
            
            PPDS = 9,
            
            EscapeP = 10,
            
            Epson = 11,
            
            DDIF = 12,
            
            Interpress = 13,
            
            ISO6429 = 14,
            
            Line_Data = 15,
            
            MODCA = 16,
            
            REGIS = 17,
            
            SCS = 18,
            
            SPDL = 19,
            
            TEK4014 = 20,
            
            PDS = 21,
            
            IGP = 22,
            
            CodeV = 23,
            
            DSCDSE = 24,
            
            WPS = 25,
            
            LN03 = 26,
            
            CCITT = 27,
            
            QUIC = 28,
            
            CPAP = 29,
            
            DecPPL = 30,
            
            Simple_Text = 31,
            
            NPAP = 32,
            
            DOC = 33,
            
            ImPress = 34,
            
            Pinwriter = 35,
            
            NPDL = 36,
            
            NEC201PL = 37,
            
            Automatic = 38,
            
            Pages = 39,
            
            LIPS = 40,
            
            TIFF = 41,
            
            Diagnostic = 42,
            
            CaPSL = 43,
            
            EXCL = 44,
            
            LCDS = 45,
            
            XES = 46,
            
            MIME = 47,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum DefaultCapabilitiesValues {
            
            Unknown0 = 0,
            
            Other0 = 1,
            
            Color_Printing = 2,
            
            Duplex_Printing = 3,
            
            Copies = 4,
            
            Collation = 5,
            
            Stapling = 6,
            
            Transparency_Printing = 7,
            
            Punch = 8,
            
            Cover = 9,
            
            Bind = 10,
            
            Black_and_White_Printing = 11,
            
            One_Sided = 12,
            
            Two_Sided_Long_Edge = 13,
            
            Two_Sided_Short_Edge = 14,
            
            Portrait = 15,
            
            Landscape = 16,
            
            Reverse_Portrait = 17,
            
            Reverse_Landscape = 18,
            
            Quality_High = 19,
            
            Quality_Normal = 20,
            
            Quality_Low = 21,
            
            NULL_ENUM_VALUE = 22,
        }
        
        public enum DefaultLanguageValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            PCL = 3,
            
            HPGL = 4,
            
            PJL = 5,
            
            PS = 6,
            
            PSPrinter = 7,
            
            IPDS = 8,
            
            PPDS = 9,
            
            EscapeP = 10,
            
            Epson = 11,
            
            DDIF = 12,
            
            Interpress = 13,
            
            ISO6429 = 14,
            
            Line_Data = 15,
            
            MODCA = 16,
            
            REGIS = 17,
            
            SCS = 18,
            
            SPDL = 19,
            
            TEK4014 = 20,
            
            PDS = 21,
            
            IGP = 22,
            
            CodeV = 23,
            
            DSCDSE = 24,
            
            WPS = 25,
            
            LN03 = 26,
            
            CCITT = 27,
            
            QUIC = 28,
            
            CPAP = 29,
            
            DecPPL = 30,
            
            Simple_Text = 31,
            
            NPAP = 32,
            
            DOC = 33,
            
            ImPress = 34,
            
            Pinwriter = 35,
            
            NPDL = 36,
            
            NEC201PL = 37,
            
            Automatic = 38,
            
            Pages = 39,
            
            LIPS = 40,
            
            TIFF = 41,
            
            Diagnostic = 42,
            
            CaPSL = 43,
            
            EXCL = 44,
            
            LCDS = 45,
            
            XES = 46,
            
            MIME = 47,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum DetectedErrorStateValues {
            
            Unknown0 = 0,
            
            Other0 = 1,
            
            No_Error = 2,
            
            Low_Paper = 3,
            
            No_Paper = 4,
            
            Low_Toner = 5,
            
            No_Toner = 6,
            
            Door_Open = 7,
            
            Jammed = 8,
            
            Offline = 9,
            
            Service_Requested = 10,
            
            Output_Bin_Full = 11,
            
            NULL_ENUM_VALUE = 12,
        }
        
        public enum ExtendedDetectedErrorStateValues {
            
            Unknown0 = 0,
            
            Other0 = 1,
            
            No_Error = 2,
            
            Low_Paper = 3,
            
            No_Paper = 4,
            
            Low_Toner = 5,
            
            No_Toner = 6,
            
            Door_Open = 7,
            
            Jammed = 8,
            
            Service_Requested = 9,
            
            Output_Bin_Full = 10,
            
            Paper_Problem = 11,
            
            Cannot_Print_Page = 12,
            
            User_Intervention_Required = 13,
            
            Out_of_Memory = 14,
            
            Server_Unknown = 15,
            
            NULL_ENUM_VALUE = 16,
        }
        
        public enum ExtendedPrinterStatusValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            Idle = 3,
            
            Printing = 4,
            
            Warmup = 5,
            
            Stopped_Printing = 6,
            
            Offline = 7,
            
            Paused = 8,
            
            Error = 9,
            
            Busy = 10,
            
            Not_Available = 11,
            
            Waiting = 12,
            
            Processing = 13,
            
            Initialization = 14,
            
            Power_Save = 15,
            
            Pending_Deletion = 16,
            
            I_O_Active = 17,
            
            Manual_Feed = 18,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum LanguagesSupportedValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            PCL = 3,
            
            HPGL = 4,
            
            PJL = 5,
            
            PS = 6,
            
            PSPrinter = 7,
            
            IPDS = 8,
            
            PPDS = 9,
            
            EscapeP = 10,
            
            Epson = 11,
            
            DDIF = 12,
            
            Interpress = 13,
            
            ISO6429 = 14,
            
            Line_Data = 15,
            
            MODCA = 16,
            
            REGIS = 17,
            
            SCS = 18,
            
            SPDL = 19,
            
            TEK4014 = 20,
            
            PDS = 21,
            
            IGP = 22,
            
            CodeV = 23,
            
            DSCDSE = 24,
            
            WPS = 25,
            
            LN03 = 26,
            
            CCITT = 27,
            
            QUIC = 28,
            
            CPAP = 29,
            
            DecPPL = 30,
            
            Simple_Text = 31,
            
            NPAP = 32,
            
            DOC = 33,
            
            ImPress = 34,
            
            Pinwriter = 35,
            
            NPDL = 36,
            
            NEC201PL = 37,
            
            Automatic = 38,
            
            Pages = 39,
            
            LIPS = 40,
            
            TIFF = 41,
            
            Diagnostic = 42,
            
            CaPSL = 43,
            
            EXCL = 44,
            
            LCDS = 45,
            
            XES = 46,
            
            MIME = 47,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum MarkingTechnologyValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            Electrophotographic_LED = 3,
            
            Electrophotographic_Laser = 4,
            
            Electrophotographic_Other = 5,
            
            Impact_Moving_Head_Dot_Matrix_9pin = 6,
            
            Impact_Moving_Head_Dot_Matrix_24pin = 7,
            
            Impact_Moving_Head_Dot_Matrix_Other = 8,
            
            Impact_Moving_Head_Fully_Formed = 9,
            
            Impact_Band = 10,
            
            Impact_Other = 11,
            
            Inkjet_Aqueous = 12,
            
            Inkjet_Solid = 13,
            
            Inkjet_Other = 14,
            
            Pen = 15,
            
            Thermal_Transfer = 16,
            
            Thermal_Sensitive = 17,
            
            Thermal_Diffusion = 18,
            
            Thermal_Other = 19,
            
            Electroerosion = 20,
            
            Electrostatic = 21,
            
            Photographic_Microfiche = 22,
            
            Photographic_Imagesetter = 23,
            
            Photographic_Other = 24,
            
            Ion_Deposition = 25,
            
            EBeam = 26,
            
            Typesetter = 27,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum PaperSizesSupportedValues {
            
            Unknown0 = 0,
            
            Other0 = 1,
            
            A = 2,
            
            B = 3,
            
            C = 4,
            
            D = 5,
            
            E = 6,
            
            Letter = 7,
            
            Legal = 8,
            
            NA_10x13_Envelope = 9,
            
            NA_9x12_Envelope = 10,
            
            NA_Number_10_Envelope = 11,
            
            NA_7x9_Envelope = 12,
            
            NA_9x11_Envelope = 13,
            
            NA_10x14_Envelope = 14,
            
            NA_Number_9_Envelope = 15,
            
            NA_6x9_Envelope = 16,
            
            NA_10x15_Envelope = 17,
            
            A0 = 18,
            
            A1 = 19,
            
            A2 = 20,
            
            A3 = 21,
            
            A4 = 22,
            
            A5 = 23,
            
            A6 = 24,
            
            A7 = 25,
            
            A8 = 26,
            
            A9A10 = 27,
            
            B0 = 28,
            
            B1 = 29,
            
            B2 = 30,
            
            B3 = 31,
            
            B4 = 32,
            
            B5 = 33,
            
            B6 = 34,
            
            B7 = 35,
            
            B8 = 36,
            
            B9 = 37,
            
            B10 = 38,
            
            C0 = 39,
            
            C1 = 40,
            
            C2C3 = 41,
            
            C4 = 42,
            
            C5 = 43,
            
            C6 = 44,
            
            C7 = 45,
            
            C8 = 46,
            
            ISO_Designated = 47,
            
            JIS_B0 = 48,
            
            JIS_B1 = 49,
            
            JIS_B2 = 50,
            
            JIS_B3 = 51,
            
            JIS_B4 = 52,
            
            JIS_B5 = 53,
            
            JIS_B6 = 54,
            
            JIS_B7 = 55,
            
            JIS_B8 = 56,
            
            JIS_B9 = 57,
            
            JIS_B10 = 58,
            
            NA_Letter = 59,
            
            NA_Legal = 60,
            
            B4_Envelope = 61,
            
            B5_Envelope = 62,
            
            C3_Envelope = 63,
            
            C4_Envelope = 64,
            
            C5_Envelope = 65,
            
            C6_Envelope = 66,
            
            Designated_Long_Envelope = 67,
            
            Monarch_Envelope = 68,
            
            Executive = 69,
            
            Folio = 70,
            
            Invoice = 71,
            
            Ledger = 72,
            
            Quarto = 73,
            
            NULL_ENUM_VALUE = 74,
        }
        
        public enum PowerManagementCapabilitiesValues {
            
            Unknown0 = 0,
            
            Not_Supported = 1,
            
            Disabled = 2,
            
            Enabled = 3,
            
            Power_Saving_Modes_Entered_Automatically = 4,
            
            Power_State_Settable = 5,
            
            Power_Cycling_Supported = 6,
            
            Timed_Power_On_Supported = 7,
            
            NULL_ENUM_VALUE = 8,
        }
        
        public enum PrinterStateValues {
            
            Paused = 0,
            
            Error = 1,
            
            Pending_Deletion = 2,
            
            Paper_Jam = 3,
            
            Paper_Out = 4,
            
            Manual_Feed = 5,
            
            Paper_Problem = 6,
            
            Offline = 7,
            
            IO_Active = 8,
            
            Busy = 9,
            
            Printing = 10,
            
            Output_Bin_Full = 11,
            
            Not_Available = 12,
            
            Waiting = 13,
            
            Processing = 14,
            
            Initialization = 15,
            
            Warming_Up = 16,
            
            Toner_Low = 17,
            
            No_Toner = 18,
            
            Page_Punt = 19,
            
            User_Intervention_Required = 20,
            
            Out_of_Memory = 21,
            
            Door_Open = 22,
            
            Server_Unknown = 23,
            
            Power_Save = 24,
            
            NULL_ENUM_VALUE = 25,
        }
        
        public enum PrinterStatusValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            Idle = 3,
            
            Printing = 4,
            
            Warmup = 5,
            
            Stopped_Printing = 6,
            
            Offline = 7,
            
            NULL_ENUM_VALUE = 0,
        }
        
        public enum StatusInfoValues {
            
            Other0 = 1,
            
            Unknown0 = 2,
            
            Enabled = 3,
            
            Disabled = 4,
            
            Not_Applicable = 5,
            
            NULL_ENUM_VALUE = 0,
        }
        
        // Enumerator implementation for enumerating instances of the class.
        public class PrinterCollection : object, ICollection {
            
            private ManagementObjectCollection privColObj;
            
            public PrinterCollection(ManagementObjectCollection objCollection) {
                privColObj = objCollection;
            }
            
            public virtual int Count {
                get {
                    return privColObj.Count;
                }
            }
            
            public virtual bool IsSynchronized {
                get {
                    return privColObj.IsSynchronized;
                }
            }
            
            public virtual object SyncRoot {
                get {
                    return this;
                }
            }
            
            public virtual void CopyTo(System.Array array, int index) {
                privColObj.CopyTo(array, index);
                int nCtr;
                for (nCtr = 0; (nCtr < array.Length); nCtr = (nCtr + 1)) {
                    array.SetValue(new Printer(((System.Management.ManagementObject)(array.GetValue(nCtr)))), nCtr);
                }
            }
            
            public virtual System.Collections.IEnumerator GetEnumerator() {
                return new PrinterEnumerator(privColObj.GetEnumerator());
            }
            
            public class PrinterEnumerator : object, System.Collections.IEnumerator {
                
                private ManagementObjectCollection.ManagementObjectEnumerator privObjEnum;
                
                public PrinterEnumerator(ManagementObjectCollection.ManagementObjectEnumerator objEnum) {
                    privObjEnum = objEnum;
                }
                
                public virtual object Current {
                    get {
                        return new Printer(((System.Management.ManagementObject)(privObjEnum.Current)));
                    }
                }
                
                public virtual bool MoveNext() {
                    return privObjEnum.MoveNext();
                }
                
                public virtual void Reset() {
                    privObjEnum.Reset();
                }
            }
        }
        
        // TypeConverter to handle null values for ValueType properties
        public class WMIValueTypeConverter : TypeConverter {
            
            private TypeConverter baseConverter;
            
            private System.Type baseType;
            
            public WMIValueTypeConverter(System.Type inBaseType) {
                baseConverter = TypeDescriptor.GetConverter(inBaseType);
                baseType = inBaseType;
            }
            
            public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type srcType) {
                return baseConverter.CanConvertFrom(context, srcType);
            }
            
            public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destinationType) {
                return baseConverter.CanConvertTo(context, destinationType);
            }
            
            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) {
                return baseConverter.ConvertFrom(context, culture, value);
            }
            
            public override object CreateInstance(System.ComponentModel.ITypeDescriptorContext context, System.Collections.IDictionary dictionary) {
                return baseConverter.CreateInstance(context, dictionary);
            }
            
            public override bool GetCreateInstanceSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetCreateInstanceSupported(context);
            }
            
            public override PropertyDescriptorCollection GetProperties(System.ComponentModel.ITypeDescriptorContext context, object value, System.Attribute[] attributeVar) {
                return baseConverter.GetProperties(context, value, attributeVar);
            }
            
            public override bool GetPropertiesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetPropertiesSupported(context);
            }
            
            public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValues(context);
            }
            
            public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesExclusive(context);
            }
            
            public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) {
                return baseConverter.GetStandardValuesSupported(context);
            }
            
            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) {
                if ((baseType.BaseType == typeof(System.Enum))) {
                    if ((value.GetType() == destinationType)) {
                        return value;
                    }
                    if ((((value == null) 
                                && (context != null)) 
                                && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                        return  "NULL_ENUM_VALUE" ;
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (((baseType == typeof(bool)) 
                            && (baseType.BaseType == typeof(System.ValueType)))) {
                    if ((((value == null) 
                                && (context != null)) 
                                && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                        return "";
                    }
                    return baseConverter.ConvertTo(context, culture, value, destinationType);
                }
                if (((context != null) 
                            && (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) == false))) {
                    return "";
                }
                return baseConverter.ConvertTo(context, culture, value, destinationType);
            }
        }
        
        // Embedded class to represent WMI system Properties.
        [TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public class ManagementSystemProperties {
            
            private System.Management.ManagementBaseObject PrivateLateBoundObject;
            
            public ManagementSystemProperties(System.Management.ManagementBaseObject ManagedObject) {
                PrivateLateBoundObject = ManagedObject;
            }
            
            [Browsable(true)]
            public int GENUS {
                get {
                    return ((int)(PrivateLateBoundObject["__GENUS"]));
                }
            }
            
            [Browsable(true)]
            public string CLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__CLASS"]));
                }
            }
            
            [Browsable(true)]
            public string SUPERCLASS {
                get {
                    return ((string)(PrivateLateBoundObject["__SUPERCLASS"]));
                }
            }
            
            [Browsable(true)]
            public string DYNASTY {
                get {
                    return ((string)(PrivateLateBoundObject["__DYNASTY"]));
                }
            }
            
            [Browsable(true)]
            public string RELPATH {
                get {
                    return ((string)(PrivateLateBoundObject["__RELPATH"]));
                }
            }
            
            [Browsable(true)]
            public int PROPERTY_COUNT {
                get {
                    return ((int)(PrivateLateBoundObject["__PROPERTY_COUNT"]));
                }
            }
            
            [Browsable(true)]
            public string[] DERIVATION {
                get {
                    return ((string[])(PrivateLateBoundObject["__DERIVATION"]));
                }
            }
            
            [Browsable(true)]
            public string SERVER {
                get {
                    return ((string)(PrivateLateBoundObject["__SERVER"]));
                }
            }
            
            [Browsable(true)]
            public string NAMESPACE {
                get {
                    return ((string)(PrivateLateBoundObject["__NAMESPACE"]));
                }
            }
            
            [Browsable(true)]
            public string PATH {
                get {
                    return ((string)(PrivateLateBoundObject["__PATH"]));
                }
            }
        }
    }
}
