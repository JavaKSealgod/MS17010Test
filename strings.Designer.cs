﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MS17010Test {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MS17010Test.strings", typeof(strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Me.
        /// </summary>
        public static string buttonTestMe {
            get {
                return ResourceManager.GetString("buttonTestMe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test Other IP.
        /// </summary>
        public static string buttonTestOtherIP {
            get {
                return ResourceManager.GetString("buttonTestOtherIP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an execution error. This may mean it is not vulnerable, but the results are not reliable..
        /// </summary>
        public static string executionError {
            get {
                return ResourceManager.GetString("executionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No.
        /// </summary>
        public static string no {
            get {
                return ResourceManager.GetString("no", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to That application is for checking if your computer is vulnerable to the flaw MS17-010 that the Ransonware WannaCry exploits.
        ///The first versions of that ransomware exploits that flaw to be able to spread over network using the protocol SMB.
        ///
        ///Worth note that this application only verifies if your computer is vulnerable to this flaw, and does not guarante that new versions of the ransomware wouldn&apos;t exploit other flaws on the system.
        ///
        ///For better test execute this application in another machine and execute wit [rest of string was truncated]&quot;;.
        /// </summary>
        public static string notice {
            get {
                return ResourceManager.GetString("notice", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait ....
        /// </summary>
        public static string pleaseWait {
            get {
                return ResourceManager.GetString("pleaseWait", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result.
        /// </summary>
        public static string result {
            get {
                return ResourceManager.GetString("result", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error checking the machine: {0}.
        /// </summary>
        public static string resultErrorMessage {
            get {
                return ResourceManager.GetString("resultErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to OS: {0}
        ///Build: {1}
        ///Workgroup: {2}
        ///Is Vulnerable: {3}
        ///Message {4}.
        /// </summary>
        public static string resultString {
            get {
                return ResourceManager.GetString("resultString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown.
        /// </summary>
        public static string unknown {
            get {
                return ResourceManager.GetString("unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Yes.
        /// </summary>
        public static string yes {
            get {
                return ResourceManager.GetString("yes", resourceCulture);
            }
        }
    }
}
