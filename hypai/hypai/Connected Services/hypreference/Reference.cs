﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hypai.hypreference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ad", Namespace="http://schemas.datacontract.org/2004/07/hyp_connect")]
    [System.SerializableAttribute()]
    public partial class Ad : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AD_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AD_TYPEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AUDIO_DIRField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DATE_DURATIONField;
        
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
        public int AD_ID {
            get {
                return this.AD_IDField;
            }
            set {
                if ((this.AD_IDField.Equals(value) != true)) {
                    this.AD_IDField = value;
                    this.RaisePropertyChanged("AD_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AD_TYPE {
            get {
                return this.AD_TYPEField;
            }
            set {
                if ((object.ReferenceEquals(this.AD_TYPEField, value) != true)) {
                    this.AD_TYPEField = value;
                    this.RaisePropertyChanged("AD_TYPE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AUDIO_DIR {
            get {
                return this.AUDIO_DIRField;
            }
            set {
                if ((object.ReferenceEquals(this.AUDIO_DIRField, value) != true)) {
                    this.AUDIO_DIRField = value;
                    this.RaisePropertyChanged("AUDIO_DIR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DATE_DURATION {
            get {
                return this.DATE_DURATIONField;
            }
            set {
                if ((this.DATE_DURATIONField.Equals(value) != true)) {
                    this.DATE_DURATIONField = value;
                    this.RaisePropertyChanged("DATE_DURATION");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Report", Namespace="http://schemas.datacontract.org/2004/07/hyp_connect")]
    [System.SerializableAttribute()]
    public partial class Report : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CATEGORYField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string INDEXField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int READ_STATUSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int REPORT_IDField;
        
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
        public string CATEGORY {
            get {
                return this.CATEGORYField;
            }
            set {
                if ((object.ReferenceEquals(this.CATEGORYField, value) != true)) {
                    this.CATEGORYField = value;
                    this.RaisePropertyChanged("CATEGORY");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string INDEX {
            get {
                return this.INDEXField;
            }
            set {
                if ((object.ReferenceEquals(this.INDEXField, value) != true)) {
                    this.INDEXField = value;
                    this.RaisePropertyChanged("INDEX");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int READ_STATUS {
            get {
                return this.READ_STATUSField;
            }
            set {
                if ((this.READ_STATUSField.Equals(value) != true)) {
                    this.READ_STATUSField = value;
                    this.RaisePropertyChanged("READ_STATUS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int REPORT_ID {
            get {
                return this.REPORT_IDField;
            }
            set {
                if ((this.REPORT_IDField.Equals(value) != true)) {
                    this.REPORT_IDField = value;
                    this.RaisePropertyChanged("REPORT_ID");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="hypreference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllAds", ReplyAction="http://tempuri.org/IService1/getAllAdsResponse")]
        hypai.hypreference.Ad[] getAllAds();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllAds", ReplyAction="http://tempuri.org/IService1/getAllAdsResponse")]
        System.Threading.Tasks.Task<hypai.hypreference.Ad[]> getAllAdsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addAd", ReplyAction="http://tempuri.org/IService1/addAdResponse")]
        hypai.hypreference.Ad addAd(hypai.hypreference.Ad ad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addAd", ReplyAction="http://tempuri.org/IService1/addAdResponse")]
        System.Threading.Tasks.Task<hypai.hypreference.Ad> addAdAsync(hypai.hypreference.Ad ad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateAd", ReplyAction="http://tempuri.org/IService1/updateAdResponse")]
        void updateAd(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateAd", ReplyAction="http://tempuri.org/IService1/updateAdResponse")]
        System.Threading.Tasks.Task updateAdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllReports", ReplyAction="http://tempuri.org/IService1/getAllReportsResponse")]
        hypai.hypreference.Report[] getAllReports();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getAllReports", ReplyAction="http://tempuri.org/IService1/getAllReportsResponse")]
        System.Threading.Tasks.Task<hypai.hypreference.Report[]> getAllReportsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addReport", ReplyAction="http://tempuri.org/IService1/addReportResponse")]
        hypai.hypreference.Report addReport(hypai.hypreference.Report report);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addReport", ReplyAction="http://tempuri.org/IService1/addReportResponse")]
        System.Threading.Tasks.Task<hypai.hypreference.Report> addReportAsync(hypai.hypreference.Report report);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateReportRSTATUS", ReplyAction="http://tempuri.org/IService1/updateReportRSTATUSResponse")]
        void updateReportRSTATUS(int id, int newStatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/updateReportRSTATUS", ReplyAction="http://tempuri.org/IService1/updateReportRSTATUSResponse")]
        System.Threading.Tasks.Task updateReportRSTATUSAsync(int id, int newStatus);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : hypai.hypreference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<hypai.hypreference.IService1>, hypai.hypreference.IService1 {
        
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
        
        public hypai.hypreference.Ad[] getAllAds() {
            return base.Channel.getAllAds();
        }
        
        public System.Threading.Tasks.Task<hypai.hypreference.Ad[]> getAllAdsAsync() {
            return base.Channel.getAllAdsAsync();
        }
        
        public hypai.hypreference.Ad addAd(hypai.hypreference.Ad ad) {
            return base.Channel.addAd(ad);
        }
        
        public System.Threading.Tasks.Task<hypai.hypreference.Ad> addAdAsync(hypai.hypreference.Ad ad) {
            return base.Channel.addAdAsync(ad);
        }
        
        public void updateAd(int id) {
            base.Channel.updateAd(id);
        }
        
        public System.Threading.Tasks.Task updateAdAsync(int id) {
            return base.Channel.updateAdAsync(id);
        }
        
        public hypai.hypreference.Report[] getAllReports() {
            return base.Channel.getAllReports();
        }
        
        public System.Threading.Tasks.Task<hypai.hypreference.Report[]> getAllReportsAsync() {
            return base.Channel.getAllReportsAsync();
        }
        
        public hypai.hypreference.Report addReport(hypai.hypreference.Report report) {
            return base.Channel.addReport(report);
        }
        
        public System.Threading.Tasks.Task<hypai.hypreference.Report> addReportAsync(hypai.hypreference.Report report) {
            return base.Channel.addReportAsync(report);
        }
        
        public void updateReportRSTATUS(int id, int newStatus) {
            base.Channel.updateReportRSTATUS(id, newStatus);
        }
        
        public System.Threading.Tasks.Task updateReportRSTATUSAsync(int id, int newStatus) {
            return base.Channel.updateReportRSTATUSAsync(id, newStatus);
        }
    }
}
