﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebGroupProject.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="JsonTest", Namespace="http://schemas.datacontract.org/2004/07/MathService_IIS")]
    [System.SerializableAttribute()]
    public partial class JsonTest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SubcategoryIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubcategoryNameField;
        
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
        public int SubcategoryID {
            get {
                return this.SubcategoryIDField;
            }
            set {
                if ((this.SubcategoryIDField.Equals(value) != true)) {
                    this.SubcategoryIDField = value;
                    this.RaisePropertyChanged("SubcategoryID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubcategoryName {
            get {
                return this.SubcategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SubcategoryNameField, value) != true)) {
                    this.SubcategoryNameField = value;
                    this.RaisePropertyChanged("SubcategoryName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getSubCategory", ReplyAction="http://tempuri.org/IService1/getSubCategoryResponse")]
        WebGroupProject.ServiceReference1.JsonTest[] getSubCategory(int CategoryID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getSubCategory", ReplyAction="http://tempuri.org/IService1/getSubCategoryResponse")]
        System.Threading.Tasks.Task<WebGroupProject.ServiceReference1.JsonTest[]> getSubCategoryAsync(int CategoryID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebGroupProject.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebGroupProject.ServiceReference1.IService1>, WebGroupProject.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebGroupProject.ServiceReference1.JsonTest[] getSubCategory(int CategoryID) {
            return base.Channel.getSubCategory(CategoryID);
        }
        
        public System.Threading.Tasks.Task<WebGroupProject.ServiceReference1.JsonTest[]> getSubCategoryAsync(int CategoryID) {
            return base.Channel.getSubCategoryAsync(CategoryID);
        }
    }
}
