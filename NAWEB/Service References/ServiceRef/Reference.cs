﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NAWEB.ServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", ConfigurationName="ServiceRef.NAWEBMgt_Port")]
    public interface NAWEBMgt_Port {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt:GetCustomers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        NAWEB.ServiceRef.GetCustomers_Result GetCustomers(NAWEB.ServiceRef.GetCustomers request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt:GetCustomers", ReplyAction="*")]
        System.Threading.Tasks.Task<NAWEB.ServiceRef.GetCustomers_Result> GetCustomersAsync(NAWEB.ServiceRef.GetCustomers request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/NAWEB_Customers>")]
    public partial class Customers : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Customer[] customerField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Customer", Order=0)]
        public Customer[] Customer {
            get {
                return this.customerField;
            }
            set {
                this.customerField = value;
                this.RaisePropertyChanged("Customer");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
                this.RaisePropertyChanged("Text");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="<urn:microsoft-dynamics-nav/xmlports/NAWEB_Customers>")]
    public partial class Customer : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string noField;
        
        private string nameField;
        
        private string name_2Field;
        
        private string addressField;
        
        private string address_2Field;
        
        private string cityField;
        
        private string postCodeField;
        
        private string creditLimitLCYField;
        
        private string customerPostingGroupField;
        
        private string blockedField;
        
        private string visibleForLocationsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
                this.RaisePropertyChanged("No");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("Name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Name_2 {
            get {
                return this.name_2Field;
            }
            set {
                this.name_2Field = value;
                this.RaisePropertyChanged("Name_2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Address_2 {
            get {
                return this.address_2Field;
            }
            set {
                this.address_2Field = value;
                this.RaisePropertyChanged("Address_2");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string City {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
                this.RaisePropertyChanged("City");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string PostCode {
            get {
                return this.postCodeField;
            }
            set {
                this.postCodeField = value;
                this.RaisePropertyChanged("PostCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string CreditLimitLCY {
            get {
                return this.creditLimitLCYField;
            }
            set {
                this.creditLimitLCYField = value;
                this.RaisePropertyChanged("CreditLimitLCY");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string CustomerPostingGroup {
            get {
                return this.customerPostingGroupField;
            }
            set {
                this.customerPostingGroupField = value;
                this.RaisePropertyChanged("CustomerPostingGroup");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Blocked {
            get {
                return this.blockedField;
            }
            set {
                this.blockedField = value;
                this.RaisePropertyChanged("Blocked");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string VisibleForLocations {
            get {
                return this.visibleForLocationsField;
            }
            set {
                this.visibleForLocationsField = value;
                this.RaisePropertyChanged("VisibleForLocations");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomers", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", IsWrapped=true)]
    public partial class GetCustomers {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=0)]
        public int startingRowNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=1)]
        public int endingRowNo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=2)]
        public string noFilter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=3)]
        public string nameFilter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=4)]
        public NAWEB.ServiceRef.Customers result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=5)]
        public int totalRows;
        
        public GetCustomers() {
        }
        
        public GetCustomers(int startingRowNo, int endingRowNo, string noFilter, string nameFilter, NAWEB.ServiceRef.Customers result, int totalRows) {
            this.startingRowNo = startingRowNo;
            this.endingRowNo = endingRowNo;
            this.noFilter = noFilter;
            this.nameFilter = nameFilter;
            this.result = result;
            this.totalRows = totalRows;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCustomers_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", IsWrapped=true)]
    public partial class GetCustomers_Result {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=0)]
        public bool return_value;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=1)]
        public NAWEB.ServiceRef.Customers result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/NAWEBMgt", Order=2)]
        public int totalRows;
        
        public GetCustomers_Result() {
        }
        
        public GetCustomers_Result(bool return_value, NAWEB.ServiceRef.Customers result, int totalRows) {
            this.return_value = return_value;
            this.result = result;
            this.totalRows = totalRows;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NAWEBMgt_PortChannel : NAWEB.ServiceRef.NAWEBMgt_Port, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NAWEBMgt_PortClient : System.ServiceModel.ClientBase<NAWEB.ServiceRef.NAWEBMgt_Port>, NAWEB.ServiceRef.NAWEBMgt_Port {
        
        public NAWEBMgt_PortClient() {
        }
        
        public NAWEBMgt_PortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NAWEBMgt_PortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NAWEBMgt_PortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NAWEBMgt_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        NAWEB.ServiceRef.GetCustomers_Result NAWEB.ServiceRef.NAWEBMgt_Port.GetCustomers(NAWEB.ServiceRef.GetCustomers request) {
            return base.Channel.GetCustomers(request);
        }
        
        public bool GetCustomers(int startingRowNo, int endingRowNo, string noFilter, string nameFilter, ref NAWEB.ServiceRef.Customers result, ref int totalRows) {
            NAWEB.ServiceRef.GetCustomers inValue = new NAWEB.ServiceRef.GetCustomers();
            inValue.startingRowNo = startingRowNo;
            inValue.endingRowNo = endingRowNo;
            inValue.noFilter = noFilter;
            inValue.nameFilter = nameFilter;
            inValue.result = result;
            inValue.totalRows = totalRows;
            NAWEB.ServiceRef.GetCustomers_Result retVal = ((NAWEB.ServiceRef.NAWEBMgt_Port)(this)).GetCustomers(inValue);
            result = retVal.result;
            totalRows = retVal.totalRows;
            return retVal.return_value;
        }
        
        public System.Threading.Tasks.Task<NAWEB.ServiceRef.GetCustomers_Result> GetCustomersAsync(NAWEB.ServiceRef.GetCustomers request) {
            return base.Channel.GetCustomersAsync(request);
        }
    }
}