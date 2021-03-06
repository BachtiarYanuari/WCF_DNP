﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Import_Monitoring.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ImportStaging", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    [System.SerializableAttribute()]
    public partial class ImportStaging : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte ActionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AxIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CommonKeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LogField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte ModuleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Action {
            get {
                return this.ActionField;
            }
            set {
                if ((this.ActionField.Equals(value) != true)) {
                    this.ActionField = value;
                    this.RaisePropertyChanged("Action");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AxId {
            get {
                return this.AxIdField;
            }
            set {
                if ((object.ReferenceEquals(this.AxIdField, value) != true)) {
                    this.AxIdField = value;
                    this.RaisePropertyChanged("AxId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CommonKey {
            get {
                return this.CommonKeyField;
            }
            set {
                if ((this.CommonKeyField.Equals(value) != true)) {
                    this.CommonKeyField = value;
                    this.RaisePropertyChanged("CommonKey");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Log {
            get {
                return this.LogField;
            }
            set {
                if ((object.ReferenceEquals(this.LogField, value) != true)) {
                    this.LogField = value;
                    this.RaisePropertyChanged("Log");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Module {
            get {
                return this.ModuleField;
            }
            set {
                if ((this.ModuleField.Equals(value) != true)) {
                    this.ModuleField = value;
                    this.RaisePropertyChanged("Module");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IImport")]
    public interface IImport {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImport/Test", ReplyAction="http://tempuri.org/IImport/TestResponse")]
        string Test();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImport/getData", ReplyAction="http://tempuri.org/IImport/getDataResponse")]
        System.Collections.Generic.List<Import_Monitoring.ServiceReference.ImportStaging> getData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImport/getAllData", ReplyAction="http://tempuri.org/IImport/getAllDataResponse")]
        System.Collections.Generic.List<Import_Monitoring.ServiceReference.ImportStaging> getAllData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImport/setStatusbyCommonKey", ReplyAction="http://tempuri.org/IImport/setStatusbyCommonKeyResponse")]
        bool setStatusbyCommonKey(Import_Monitoring.ServiceReference.ImportStaging updated);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImportChannel : Import_Monitoring.ServiceReference.IImport, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImportClient : System.ServiceModel.ClientBase<Import_Monitoring.ServiceReference.IImport>, Import_Monitoring.ServiceReference.IImport {
        
        public ImportClient() {
        }
        
        public ImportClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImportClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImportClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImportClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Test() {
            return base.Channel.Test();
        }
        
        public System.Collections.Generic.List<Import_Monitoring.ServiceReference.ImportStaging> getData() {
            return base.Channel.getData();
        }
        
        public System.Collections.Generic.List<Import_Monitoring.ServiceReference.ImportStaging> getAllData() {
            return base.Channel.getAllData();
        }
        
        public bool setStatusbyCommonKey(Import_Monitoring.ServiceReference.ImportStaging updated) {
            return base.Channel.setStatusbyCommonKey(updated);
        }
    }
}
