﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XeroWebUIAutomation.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("chrome")]
        public string Browser {
            get {
                return ((string)(this["Browser"]));
            }
            set {
                this["Browser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://login.xero.com/")]
        public string LoginUrl {
            get {
                return ((string)(this["LoginUrl"]));
            }
            set {
                this["LoginUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("false")]
        public string RemoteExecution {
            get {
                return ((string)(this["RemoteExecution"]));
            }
            set {
                this["RemoteExecution"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Drivers")]
        public string DriversLocation {
            get {
                return ((string)(this["DriversLocation"]));
            }
            set {
                this["DriversLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public string timeWaitInSeconds {
            get {
                return ((string)(this["timeWaitInSeconds"]));
            }
            set {
                this["timeWaitInSeconds"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("lolayan@outlook.com")]
        public string UserEmail {
            get {
                return ((string)(this["UserEmail"]));
            }
            set {
                this["UserEmail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("password123")]
        public string UserPassword {
            get {
                return ((string)(this["UserPassword"]));
            }
            set {
                this["UserPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://go.xero.com/Dashboard/")]
        public string DashboardUrl {
            get {
                return ((string)(this["DashboardUrl"]));
            }
            set {
                this["DashboardUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://go.xero.com/Accounts/Receivable/Dashboard/")]
        public string SalesUrl {
            get {
                return ((string)(this["SalesUrl"]));
            }
            set {
                this["SalesUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://www.xero.com/nz/signup/")]
        public string SignupUrl {
            get {
                return ((string)(this["SignupUrl"]));
            }
            set {
                this["SignupUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://app.xero.com/Preview")]
        public string APIPreviewUrl {
            get {
                return ((string)(this["APIPreviewUrl"]));
            }
            set {
                this["APIPreviewUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://app.xero.com/Previewer/DisconnectFromXero")]
        public string DisconnectFromXero {
            get {
                return ((string)(this["DisconnectFromXero"]));
            }
            set {
                this["DisconnectFromXero"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://app.xero.com/Previewer/SetupOAuthConnection")]
        public string SetupOAuthConnection {
            get {
                return ((string)(this["SetupOAuthConnection"]));
            }
            set {
                this["SetupOAuthConnection"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://login.xero.com/")]
        public string Url {
            get {
                return ((string)(this["Url"]));
            }
            set {
                this["Url"] = value;
            }
        }
    }
}