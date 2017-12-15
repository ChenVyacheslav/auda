﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Audatex.AudaHistoryServiceReferences {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://serviceinterface_v1.b2b.audatex.com", ConfigurationName="AudaHistoryServiceReferences.AudaHistoryServicePort")]
    public interface AudaHistoryServicePort {
        
        // CODEGEN: Generating message contract since the operation ping is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Audatex.AudaHistoryServiceReferences.pingResponse ping(Audatex.AudaHistoryServiceReferences.pingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.pingResponse> pingAsync(Audatex.AudaHistoryServiceReferences.pingRequest request);
        
        // CODEGEN: Generating message contract since the operation getHistory is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Audatex.AudaHistoryServiceReferences.getHistoryResponse getHistory(Audatex.AudaHistoryServiceReferences.getHistoryRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getHistoryResponse> getHistoryAsync(Audatex.AudaHistoryServiceReferences.getHistoryRequest request);
        
        // CODEGEN: Generating message contract since the operation getImage is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Audatex.AudaHistoryServiceReferences.getImageResponse getImage(Audatex.AudaHistoryServiceReferences.getImageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getImageResponse> getImageAsync(Audatex.AudaHistoryServiceReferences.getImageRequest request);
        
        // CODEGEN: Generating message contract since the operation getImages is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Audatex.AudaHistoryServiceReferences.getImagesResponse getImages(Audatex.AudaHistoryServiceReferences.getImagesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getImagesResponse> getImagesAsync(Audatex.AudaHistoryServiceReferences.getImagesRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceinterface_v1.b2b.audatex.com")]
    public partial class B2BRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private B2BParameter[] parameterField;
        
        private object payloadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameter", Order=0)]
        public B2BParameter[] parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
                this.RaisePropertyChanged("parameter");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public object payload {
            get {
                return this.payloadField;
            }
            set {
                this.payloadField = value;
                this.RaisePropertyChanged("payload");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceinterface_v1.b2b.audatex.com")]
    public partial class B2BParameter : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string valueField;
        
        private bool xsltParameterField;
        
        private bool xsltParameterFieldSpecified;
        
        private string contextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool xsltParameter {
            get {
                return this.xsltParameterField;
            }
            set {
                this.xsltParameterField = value;
                this.RaisePropertyChanged("xsltParameter");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xsltParameterSpecified {
            get {
                return this.xsltParameterFieldSpecified;
            }
            set {
                this.xsltParameterFieldSpecified = value;
                this.RaisePropertyChanged("xsltParameterSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string context {
            get {
                return this.contextField;
            }
            set {
                this.contextField = value;
                this.RaisePropertyChanged("context");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceinterface_v1.b2b.audatex.com")]
    public partial class B2BMessage : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageCodeField;
        
        private int severityField;
        
        private string textField;
        
        private string localizedTextField;
        
        private string[] additionalInfoField;
        
        private string caseIdField;
        
        private string taskIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string messageCode {
            get {
                return this.messageCodeField;
            }
            set {
                this.messageCodeField = value;
                this.RaisePropertyChanged("messageCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int severity {
            get {
                return this.severityField;
            }
            set {
                this.severityField = value;
                this.RaisePropertyChanged("severity");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
                this.RaisePropertyChanged("text");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string localizedText {
            get {
                return this.localizedTextField;
            }
            set {
                this.localizedTextField = value;
                this.RaisePropertyChanged("localizedText");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalInfo", Order=4)]
        public string[] additionalInfo {
            get {
                return this.additionalInfoField;
            }
            set {
                this.additionalInfoField = value;
                this.RaisePropertyChanged("additionalInfo");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string caseId {
            get {
                return this.caseIdField;
            }
            set {
                this.caseIdField = value;
                this.RaisePropertyChanged("caseId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string taskId {
            get {
                return this.taskIdField;
            }
            set {
                this.taskIdField = value;
                this.RaisePropertyChanged("taskId");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://serviceinterface_v1.b2b.audatex.com")]
    public partial class B2BResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int returnCodeField;
        
        private string loginIdField;
        
        private string hostNameField;
        
        private System.DateTime timestampField;
        
        private B2BMessage[] messageField;
        
        private object payloadField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int returnCode {
            get {
                return this.returnCodeField;
            }
            set {
                this.returnCodeField = value;
                this.RaisePropertyChanged("returnCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string loginId {
            get {
                return this.loginIdField;
            }
            set {
                this.loginIdField = value;
                this.RaisePropertyChanged("loginId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string hostName {
            get {
                return this.hostNameField;
            }
            set {
                this.hostNameField = value;
                this.RaisePropertyChanged("hostName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime timestamp {
            get {
                return this.timestampField;
            }
            set {
                this.timestampField = value;
                this.RaisePropertyChanged("timestamp");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("message", Order=4)]
        public B2BMessage[] message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public object payload {
            get {
                return this.payloadField;
            }
            set {
                this.payloadField = value;
                this.RaisePropertyChanged("payload");
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class pingRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="pingRequest", Namespace="http://serviceinterface_v1.b2b.audatex.com", Order=0)]
        public Audatex.AudaHistoryServiceReferences.B2BRequest pingRequest1;
        
        public pingRequest() {
        }
        
        public pingRequest(Audatex.AudaHistoryServiceReferences.B2BRequest pingRequest1) {
            this.pingRequest1 = pingRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class pingResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="pingResponse", Namespace="http://serviceinterface_v1.b2b.audatex.com", Order=0)]
        public Audatex.AudaHistoryServiceReferences.B2BResponse pingResponse1;
        
        public pingResponse() {
        }
        
        public pingResponse(Audatex.AudaHistoryServiceReferences.B2BResponse pingResponse1) {
            this.pingResponse1 = pingResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getHistoryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getHistoryRequest", Namespace="http://serviceinterface_v1.b2b.audatex.com", Order=0)]
        public Audatex.AudaHistoryServiceReferences.B2BRequest getHistoryRequest1;
        
        public getHistoryRequest() {
        }
        
        public getHistoryRequest(Audatex.AudaHistoryServiceReferences.B2BRequest getHistoryRequest1) {
            this.getHistoryRequest1 = getHistoryRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getHistoryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getHistoryResponse", Namespace="http://serviceinterface_v1.b2b.audatex.com", Order=0)]
        public Audatex.AudaHistoryServiceReferences.B2BResponse getHistoryResponse1;
        
        public getHistoryResponse() {
        }
        
        public getHistoryResponse(Audatex.AudaHistoryServiceReferences.B2BResponse getHistoryResponse1) {
            this.getHistoryResponse1 = getHistoryResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getImageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getImageRequest", Namespace="http://serviceinterface_v1.b2b.audatex.com", Order=0)]
        public Audatex.AudaHistoryServiceReferences.B2BRequest getImageRequest1;
        
        public getImageRequest() {
        }
        
        public getImageRequest(Audatex.AudaHistoryServiceReferences.B2BRequest getImageRequest1) {
            this.getImageRequest1 = getImageRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getImageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getImageResponse", Namespace="http://serviceinterface_v1.b2b.audatex.com", Order=0)]
        public Audatex.AudaHistoryServiceReferences.B2BResponse getImageResponse1;
        
        public getImageResponse() {
        }
        
        public getImageResponse(Audatex.AudaHistoryServiceReferences.B2BResponse getImageResponse1) {
            this.getImageResponse1 = getImageResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getImagesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getImagesRequest", Namespace="http://serviceinterface_v1.b2b.audatex.com", Order=0)]
        public Audatex.AudaHistoryServiceReferences.B2BRequest getImagesRequest1;
        
        public getImagesRequest() {
        }
        
        public getImagesRequest(Audatex.AudaHistoryServiceReferences.B2BRequest getImagesRequest1) {
            this.getImagesRequest1 = getImagesRequest1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getImagesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getImagesResponse", Namespace="http://serviceinterface_v1.b2b.audatex.com", Order=0)]
        public Audatex.AudaHistoryServiceReferences.B2BResponse getImagesResponse1;
        
        public getImagesResponse() {
        }
        
        public getImagesResponse(Audatex.AudaHistoryServiceReferences.B2BResponse getImagesResponse1) {
            this.getImagesResponse1 = getImagesResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AudaHistoryServicePortChannel : Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AudaHistoryServicePortClient : System.ServiceModel.ClientBase<Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort>, Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort {
        
        public AudaHistoryServicePortClient() {
        }
        
        public AudaHistoryServicePortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AudaHistoryServicePortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AudaHistoryServicePortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AudaHistoryServicePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Audatex.AudaHistoryServiceReferences.pingResponse Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort.ping(Audatex.AudaHistoryServiceReferences.pingRequest request) {
            return base.Channel.ping(request);
        }
        
        public Audatex.AudaHistoryServiceReferences.B2BResponse ping(Audatex.AudaHistoryServiceReferences.B2BRequest pingRequest1) {
            Audatex.AudaHistoryServiceReferences.pingRequest inValue = new Audatex.AudaHistoryServiceReferences.pingRequest();
            inValue.pingRequest1 = pingRequest1;
            Audatex.AudaHistoryServiceReferences.pingResponse retVal = ((Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort)(this)).ping(inValue);
            return retVal.pingResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.pingResponse> Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort.pingAsync(Audatex.AudaHistoryServiceReferences.pingRequest request) {
            return base.Channel.pingAsync(request);
        }
        
        public System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.pingResponse> pingAsync(Audatex.AudaHistoryServiceReferences.B2BRequest pingRequest1) {
            Audatex.AudaHistoryServiceReferences.pingRequest inValue = new Audatex.AudaHistoryServiceReferences.pingRequest();
            inValue.pingRequest1 = pingRequest1;
            return ((Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort)(this)).pingAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Audatex.AudaHistoryServiceReferences.getHistoryResponse Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort.getHistory(Audatex.AudaHistoryServiceReferences.getHistoryRequest request) {
            return base.Channel.getHistory(request);
        }
        
        public Audatex.AudaHistoryServiceReferences.B2BResponse getHistory(Audatex.AudaHistoryServiceReferences.B2BRequest getHistoryRequest1) {
            Audatex.AudaHistoryServiceReferences.getHistoryRequest inValue = new Audatex.AudaHistoryServiceReferences.getHistoryRequest();
            inValue.getHistoryRequest1 = getHistoryRequest1;
            Audatex.AudaHistoryServiceReferences.getHistoryResponse retVal = ((Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort)(this)).getHistory(inValue);
            return retVal.getHistoryResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getHistoryResponse> Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort.getHistoryAsync(Audatex.AudaHistoryServiceReferences.getHistoryRequest request) {
            return base.Channel.getHistoryAsync(request);
        }
        
        public System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getHistoryResponse> getHistoryAsync(Audatex.AudaHistoryServiceReferences.B2BRequest getHistoryRequest1) {
            Audatex.AudaHistoryServiceReferences.getHistoryRequest inValue = new Audatex.AudaHistoryServiceReferences.getHistoryRequest();
            inValue.getHistoryRequest1 = getHistoryRequest1;
            return ((Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort)(this)).getHistoryAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Audatex.AudaHistoryServiceReferences.getImageResponse Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort.getImage(Audatex.AudaHistoryServiceReferences.getImageRequest request) {
            return base.Channel.getImage(request);
        }
        
        public Audatex.AudaHistoryServiceReferences.B2BResponse getImage(Audatex.AudaHistoryServiceReferences.B2BRequest getImageRequest1) {
            Audatex.AudaHistoryServiceReferences.getImageRequest inValue = new Audatex.AudaHistoryServiceReferences.getImageRequest();
            inValue.getImageRequest1 = getImageRequest1;
            Audatex.AudaHistoryServiceReferences.getImageResponse retVal = ((Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort)(this)).getImage(inValue);
            return retVal.getImageResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getImageResponse> Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort.getImageAsync(Audatex.AudaHistoryServiceReferences.getImageRequest request) {
            return base.Channel.getImageAsync(request);
        }
        
        public System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getImageResponse> getImageAsync(Audatex.AudaHistoryServiceReferences.B2BRequest getImageRequest1) {
            Audatex.AudaHistoryServiceReferences.getImageRequest inValue = new Audatex.AudaHistoryServiceReferences.getImageRequest();
            inValue.getImageRequest1 = getImageRequest1;
            return ((Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort)(this)).getImageAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Audatex.AudaHistoryServiceReferences.getImagesResponse Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort.getImages(Audatex.AudaHistoryServiceReferences.getImagesRequest request) {
            return base.Channel.getImages(request);
        }
        
        public Audatex.AudaHistoryServiceReferences.B2BResponse getImages(Audatex.AudaHistoryServiceReferences.B2BRequest getImagesRequest1) {
            Audatex.AudaHistoryServiceReferences.getImagesRequest inValue = new Audatex.AudaHistoryServiceReferences.getImagesRequest();
            inValue.getImagesRequest1 = getImagesRequest1;
            Audatex.AudaHistoryServiceReferences.getImagesResponse retVal = ((Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort)(this)).getImages(inValue);
            return retVal.getImagesResponse1;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getImagesResponse> Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort.getImagesAsync(Audatex.AudaHistoryServiceReferences.getImagesRequest request) {
            return base.Channel.getImagesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Audatex.AudaHistoryServiceReferences.getImagesResponse> getImagesAsync(Audatex.AudaHistoryServiceReferences.B2BRequest getImagesRequest1) {
            Audatex.AudaHistoryServiceReferences.getImagesRequest inValue = new Audatex.AudaHistoryServiceReferences.getImagesRequest();
            inValue.getImagesRequest1 = getImagesRequest1;
            return ((Audatex.AudaHistoryServiceReferences.AudaHistoryServicePort)(this)).getImagesAsync(inValue);
        }
    }
}