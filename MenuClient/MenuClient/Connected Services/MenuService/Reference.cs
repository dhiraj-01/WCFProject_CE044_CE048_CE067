﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MenuClient.MenuService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Item", Namespace="http://schemas.datacontract.org/2004/07/Food_Ordering")]
    [System.SerializableAttribute()]
    public partial class Item : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MenuService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddItem", ReplyAction="http://tempuri.org/IService1/AddItemResponse")]
        string AddItem(MenuClient.MenuService.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddItem", ReplyAction="http://tempuri.org/IService1/AddItemResponse")]
        System.Threading.Tasks.Task<string> AddItemAsync(MenuClient.MenuService.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getItems", ReplyAction="http://tempuri.org/IService1/getItemsResponse")]
        System.Data.DataSet getItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getItems", ReplyAction="http://tempuri.org/IService1/getItemsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> getItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteItem", ReplyAction="http://tempuri.org/IService1/DeleteItemResponse")]
        string DeleteItem(MenuClient.MenuService.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteItem", ReplyAction="http://tempuri.org/IService1/DeleteItemResponse")]
        System.Threading.Tasks.Task<string> DeleteItemAsync(MenuClient.MenuService.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchItem", ReplyAction="http://tempuri.org/IService1/SearchItemResponse")]
        System.Data.DataSet SearchItem(MenuClient.MenuService.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchItem", ReplyAction="http://tempuri.org/IService1/SearchItemResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchItemAsync(MenuClient.MenuService.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateItem", ReplyAction="http://tempuri.org/IService1/UpdateItemResponse")]
        string UpdateItem(MenuClient.MenuService.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateItem", ReplyAction="http://tempuri.org/IService1/UpdateItemResponse")]
        System.Threading.Tasks.Task<string> UpdateItemAsync(MenuClient.MenuService.Item item);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MenuClient.MenuService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MenuClient.MenuService.IService1>, MenuClient.MenuService.IService1 {
        
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
        
        public string AddItem(MenuClient.MenuService.Item item) {
            return base.Channel.AddItem(item);
        }
        
        public System.Threading.Tasks.Task<string> AddItemAsync(MenuClient.MenuService.Item item) {
            return base.Channel.AddItemAsync(item);
        }
        
        public System.Data.DataSet getItems() {
            return base.Channel.getItems();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> getItemsAsync() {
            return base.Channel.getItemsAsync();
        }
        
        public string DeleteItem(MenuClient.MenuService.Item item) {
            return base.Channel.DeleteItem(item);
        }
        
        public System.Threading.Tasks.Task<string> DeleteItemAsync(MenuClient.MenuService.Item item) {
            return base.Channel.DeleteItemAsync(item);
        }
        
        public System.Data.DataSet SearchItem(MenuClient.MenuService.Item item) {
            return base.Channel.SearchItem(item);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchItemAsync(MenuClient.MenuService.Item item) {
            return base.Channel.SearchItemAsync(item);
        }
        
        public string UpdateItem(MenuClient.MenuService.Item item) {
            return base.Channel.UpdateItem(item);
        }
        
        public System.Threading.Tasks.Task<string> UpdateItemAsync(MenuClient.MenuService.Item item) {
            return base.Channel.UpdateItemAsync(item);
        }
    }
}