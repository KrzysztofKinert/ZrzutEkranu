﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZrzutEkranu.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ClipboardSource_ZrzutEkranu {
            get {
                return ((bool)(this["ClipboardSource_ZrzutEkranu"]));
            }
            set {
                this["ClipboardSource_ZrzutEkranu"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Png")]
        public global::System.Drawing.Imaging.ImageFormat ImageFormat {
            get {
                return ((global::System.Drawing.Imaging.ImageFormat)(this["ImageFormat"]));
            }
            set {
                this["ImageFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClipboardSource_SnippingTool {
            get {
                return ((bool)(this["ClipboardSource_SnippingTool"]));
            }
            set {
                this["ClipboardSource_SnippingTool"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClipboardSource_Other {
            get {
                return ((bool)(this["ClipboardSource_Other"]));
            }
            set {
                this["ClipboardSource_Other"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5")]
        public int PdfMargin {
            get {
                return ((int)(this["PdfMargin"]));
            }
            set {
                this["PdfMargin"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Vertical")]
        public global::ZrzutEkranu.Utility.PdfImageOrientation PdfImageOrientation {
            get {
                return ((global::ZrzutEkranu.Utility.PdfImageOrientation)(this["PdfImageOrientation"]));
            }
            set {
                this["PdfImageOrientation"] = value;
            }
        }
    }
}
