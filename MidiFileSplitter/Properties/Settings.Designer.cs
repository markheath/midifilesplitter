﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarkHeath.MidiUtils.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
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
        public string CustomFolder {
            get {
                return ((string)(this["CustomFolder"]));
            }
            set {
                this["CustomFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UniqueFilename {
            get {
                return ((bool)(this["UniqueFilename"]));
            }
            set {
                this["UniqueFilename"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SubFolder")]
        public global::MarkHeath.MidiUtils.OutputFolderSettings OutputFolder {
            get {
                return ((global::MarkHeath.MidiUtils.OutputFolderSettings)(this["OutputFolder"]));
            }
            set {
                this["OutputFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DoNotModify")]
        public global::MarkHeath.MidiUtils.NoteDurationSettings NoteDuration {
            get {
                return ((global::MarkHeath.MidiUtils.NoteDurationSettings)(this["NoteDuration"]));
            }
            set {
                this["NoteDuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FixedNoteLength {
            get {
                return ((int)(this["FixedNoteLength"]));
            }
            set {
                this["FixedNoteLength"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ModifyChannel {
            get {
                return ((bool)(this["ModifyChannel"]));
            }
            set {
                this["ModifyChannel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int FixedChannel {
            get {
                return ((int)(this["FixedChannel"]));
            }
            set {
                this["FixedChannel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowOrphanedNoteEvents {
            get {
                return ((bool)(this["AllowOrphanedNoteEvents"]));
            }
            set {
                this["AllowOrphanedNoteEvents"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int MidiFileType {
            get {
                return ((int)(this["MidiFileType"]));
            }
            set {
                this["MidiFileType"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool TextEventMarkers {
            get {
                return ((bool)(this["TextEventMarkers"]));
            }
            set {
                this["TextEventMarkers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FirstTime {
            get {
                return ((bool)(this["FirstTime"]));
            }
            set {
                this["FirstTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ProductVersion {
            get {
                return ((string)(this["ProductVersion"]));
            }
            set {
                this["ProductVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LyricsAsMarkers {
            get {
                return ((bool)(this["LyricsAsMarkers"]));
            }
            set {
                this["LyricsAsMarkers"] = value;
            }
        }
    }
}
