﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmaKode.Client.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PharmacyID {
            get {
                return ((string)(this["PharmacyID"]));
            }
            set {
                this["PharmacyID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("*.htm")]
        public string FileExtension {
            get {
                return ((string)(this["FileExtension"]));
            }
            set {
                this["FileExtension"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string SourceFolder {
            get {
                return ((string)(this["SourceFolder"]));
            }
            set {
                this["SourceFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\Farmakode")]
        public string DestinationFolder {
            get {
                return ((string)(this["DestinationFolder"]));
            }
            set {
                this["DestinationFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int ClearCacheType {
            get {
                return ((int)(this["ClearCacheType"]));
            }
            set {
                this["ClearCacheType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://farmakode.com/api/post-recipe")]
        public string ApiURL {
            get {
                return ((string)(this["ApiURL"]));
            }
            set {
                this["ApiURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public decimal NotificationDuration {
            get {
                return ((decimal)(this["NotificationDuration"]));
            }
            set {
                this["NotificationDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int NotificationPosition {
            get {
                return ((int)(this["NotificationPosition"]));
            }
            set {
                this["NotificationPosition"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int NotificationMaxCount {
            get {
                return ((int)(this["NotificationMaxCount"]));
            }
            set {
                this["NotificationMaxCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsEnableNotification {
            get {
                return ((bool)(this["IsEnableNotification"]));
            }
            set {
                this["IsEnableNotification"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string DefaultBarcodePrinter {
            get {
                return ((string)(this["DefaultBarcodePrinter"]));
            }
            set {
                this["DefaultBarcodePrinter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("XPathConfig.json")]
        public string XPathConfigFile {
            get {
                return ((string)(this["XPathConfigFile"]));
            }
            set {
                this["XPathConfigFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Log")]
        public string LogPath {
            get {
                return ((string)(this["LogPath"]));
            }
            set {
                this["LogPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AppIsEnabled {
            get {
                return ((bool)(this["AppIsEnabled"]));
            }
            set {
                this["AppIsEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/eczane/faces/pages/recete/ReceteIslem2.jsp")]
        public string IsParseableKeyword {
            get {
                return ((string)(this["IsParseableKeyword"]));
            }
            set {
                this["IsParseableKeyword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("LatestPost")]
        public string LatestPostFolderName {
            get {
                return ((string)(this["LatestPostFolderName"]));
            }
            set {
                this["LatestPostFolderName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsManuelMode {
            get {
                return ((bool)(this["IsManuelMode"]));
            }
            set {
                this["IsManuelMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://ipinfo.io/ip")]
        public string IPAddressServer {
            get {
                return ((string)(this["IPAddressServer"]));
            }
            set {
                this["IPAddressServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("PC-02")]
        public string PharmacyPCNO {
            get {
                return ((string)(this["PharmacyPCNO"]));
            }
            set {
                this["PharmacyPCNO"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowPrinterDilaog {
            get {
                return ((bool)(this["ShowPrinterDilaog"]));
            }
            set {
                this["ShowPrinterDilaog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("60")]
        public decimal PaperWidth {
            get {
                return ((decimal)(this["PaperWidth"]));
            }
            set {
                this["PaperWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("40")]
        public decimal PaperHeight {
            get {
                return ((decimal)(this["PaperHeight"]));
            }
            set {
                this["PaperHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal MarginLeft {
            get {
                return ((decimal)(this["MarginLeft"]));
            }
            set {
                this["MarginLeft"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal MarginRight {
            get {
                return ((decimal)(this["MarginRight"]));
            }
            set {
                this["MarginRight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal MarginTop {
            get {
                return ((decimal)(this["MarginTop"]));
            }
            set {
                this["MarginTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal MarginBottom {
            get {
                return ((decimal)(this["MarginBottom"]));
            }
            set {
                this["MarginBottom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ManuelKeysCTRL {
            get {
                return ((bool)(this["ManuelKeysCTRL"]));
            }
            set {
                this["ManuelKeysCTRL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ManuelKeysSHIFT {
            get {
                return ((bool)(this["ManuelKeysSHIFT"]));
            }
            set {
                this["ManuelKeysSHIFT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ManuelKeysALT {
            get {
                return ((bool)(this["ManuelKeysALT"]));
            }
            set {
                this["ManuelKeysALT"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ManuelKeysCustom {
            get {
                return ((string)(this["ManuelKeysCustom"]));
            }
            set {
                this["ManuelKeysCustom"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public decimal ManuelModeTimerInterval {
            get {
                return ((decimal)(this["ManuelModeTimerInterval"]));
            }
            set {
                this["ManuelModeTimerInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public decimal BarcodeSpeed {
            get {
                return ((decimal)(this["BarcodeSpeed"]));
            }
            set {
                this["BarcodeSpeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public decimal BarcodePostDuration {
            get {
                return ((decimal)(this["BarcodePostDuration"]));
            }
            set {
                this["BarcodePostDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public decimal BarcodeClearDuration {
            get {
                return ((decimal)(this["BarcodeClearDuration"]));
            }
            set {
                this["BarcodeClearDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public decimal BarcodeMinlength {
            get {
                return ((decimal)(this["BarcodeMinlength"]));
            }
            set {
                this["BarcodeMinlength"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool BarcodeOnlyNumber {
            get {
                return ((bool)(this["BarcodeOnlyNumber"]));
            }
            set {
                this["BarcodeOnlyNumber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>010</string>\r\n  <string>011</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection QRCodeIgnore {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["QRCodeIgnore"]));
            }
            set {
                this["QRCodeIgnore"] = value;
            }
        }
    }
}
