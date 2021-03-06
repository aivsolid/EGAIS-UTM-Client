// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.22408 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Egais.Entities.CarrierNotice</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Egais.Entities.CarrierNotice {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    using Egais.Entities.EGCommon;
    using Egais.Entities.EGCommonEnum;
    using Egais.Entities.ClientRef_v2;
    using Egais.Entities.ProductRef_v2;
    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.22414")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/CarrierNotice")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/CarrierNotice", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarrierNotice", Namespace="http://fsrar.ru/WEGAIS/CarrierNotice")]
    public partial class CarrierNotice : System.ComponentModel.INotifyPropertyChanged {
        
        private CarrierNoticeHeader headerField;
        
        private List<PositionType> contentField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public CarrierNotice() {
            this.contentField = new List<PositionType>();
            this.headerField = new CarrierNoticeHeader();
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CarrierNoticeHeader Header {
            get {
                return this.headerField;
            }
            set {
                if ((this.headerField != null)) {
                    if ((headerField.Equals(value) != true)) {
                        this.headerField = value;
                        this.OnPropertyChanged("Header");
                    }
                }
                else {
                    this.headerField = value;
                    this.OnPropertyChanged("Header");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Position", IsNullable=false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<PositionType> Content {
            get {
                return this.contentField;
            }
            set {
                if ((this.contentField != null)) {
                    if ((contentField.Equals(value) != true)) {
                        this.contentField = value;
                        this.OnPropertyChanged("Content");
                    }
                }
                else {
                    this.contentField = value;
                    this.OnPropertyChanged("Content");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(CarrierNotice));
                }
                return serializer;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        public virtual void OnPropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null)) {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current CarrierNotice object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize() {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally {
                if ((streamReader != null)) {
                    streamReader.Dispose();
                }
                if ((memoryStream != null)) {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an CarrierNotice object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output CarrierNotice object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out CarrierNotice obj, out System.Exception exception) {
            exception = null;
            obj = default(CarrierNotice);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out CarrierNotice obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static CarrierNotice Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((CarrierNotice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current CarrierNotice object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception) {
            exception = null;
            try {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e) {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName) {
            System.IO.StreamWriter streamWriter = null;
            try {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally {
                if ((streamWriter != null)) {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an CarrierNotice object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output CarrierNotice object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out CarrierNotice obj, out System.Exception exception) {
            exception = null;
            obj = default(CarrierNotice);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out CarrierNotice obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static CarrierNotice LoadFromFile(string fileName) {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally {
                if ((file != null)) {
                    file.Dispose();
                }
                if ((sr != null)) {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.22414")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://fsrar.ru/WEGAIS/CarrierNotice")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarrierNoticeHeader", Namespace="http://fsrar.ru/WEGAIS/CarrierNotice")]
    public partial class CarrierNoticeHeader : System.ComponentModel.INotifyPropertyChanged {
        
        private string clientIdentityField;
        
        private string serialField;
        
        private string shipperField;
        
        private string consigneeField;
        
        private string carrierField;
        
        private string clientTransportField;
        
        private System.DateTime shipmentOutDateField;
        
        private System.DateTime shipmentInDateField;
        
        private string eGAISFixNumberTTNField;
        
        private string notifNumberField;
        
        private System.DateTime notifDateField;
        
        private string notifSupplierIdField;
        
        private string notifCustomerIdField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientIdentity {
            get {
                return this.clientIdentityField;
            }
            set {
                if ((this.clientIdentityField != null)) {
                    if ((clientIdentityField.Equals(value) != true)) {
                        this.clientIdentityField = value;
                        this.OnPropertyChanged("ClientIdentity");
                    }
                }
                else {
                    this.clientIdentityField = value;
                    this.OnPropertyChanged("ClientIdentity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Serial {
            get {
                return this.serialField;
            }
            set {
                if ((this.serialField != null)) {
                    if ((serialField.Equals(value) != true)) {
                        this.serialField = value;
                        this.OnPropertyChanged("Serial");
                    }
                }
                else {
                    this.serialField = value;
                    this.OnPropertyChanged("Serial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Shipper {
            get {
                return this.shipperField;
            }
            set {
                if ((this.shipperField != null)) {
                    if ((shipperField.Equals(value) != true)) {
                        this.shipperField = value;
                        this.OnPropertyChanged("Shipper");
                    }
                }
                else {
                    this.shipperField = value;
                    this.OnPropertyChanged("Shipper");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Consignee {
            get {
                return this.consigneeField;
            }
            set {
                if ((this.consigneeField != null)) {
                    if ((consigneeField.Equals(value) != true)) {
                        this.consigneeField = value;
                        this.OnPropertyChanged("Consignee");
                    }
                }
                else {
                    this.consigneeField = value;
                    this.OnPropertyChanged("Consignee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Carrier {
            get {
                return this.carrierField;
            }
            set {
                if ((this.carrierField != null)) {
                    if ((carrierField.Equals(value) != true)) {
                        this.carrierField = value;
                        this.OnPropertyChanged("Carrier");
                    }
                }
                else {
                    this.carrierField = value;
                    this.OnPropertyChanged("Carrier");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientTransport {
            get {
                return this.clientTransportField;
            }
            set {
                if ((this.clientTransportField != null)) {
                    if ((clientTransportField.Equals(value) != true)) {
                        this.clientTransportField = value;
                        this.OnPropertyChanged("ClientTransport");
                    }
                }
                else {
                    this.clientTransportField = value;
                    this.OnPropertyChanged("ClientTransport");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ShipmentOutDate {
            get {
                return this.shipmentOutDateField;
            }
            set {
                if ((shipmentOutDateField.Equals(value) != true)) {
                    this.shipmentOutDateField = value;
                    this.OnPropertyChanged("ShipmentOutDate");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ShipmentInDate {
            get {
                return this.shipmentInDateField;
            }
            set {
                if ((shipmentInDateField.Equals(value) != true)) {
                    this.shipmentInDateField = value;
                    this.OnPropertyChanged("ShipmentInDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EGAISFixNumberTTN {
            get {
                return this.eGAISFixNumberTTNField;
            }
            set {
                if ((this.eGAISFixNumberTTNField != null)) {
                    if ((eGAISFixNumberTTNField.Equals(value) != true)) {
                        this.eGAISFixNumberTTNField = value;
                        this.OnPropertyChanged("EGAISFixNumberTTN");
                    }
                }
                else {
                    this.eGAISFixNumberTTNField = value;
                    this.OnPropertyChanged("EGAISFixNumberTTN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NotifNumber {
            get {
                return this.notifNumberField;
            }
            set {
                if ((this.notifNumberField != null)) {
                    if ((notifNumberField.Equals(value) != true)) {
                        this.notifNumberField = value;
                        this.OnPropertyChanged("NotifNumber");
                    }
                }
                else {
                    this.notifNumberField = value;
                    this.OnPropertyChanged("NotifNumber");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime NotifDate {
            get {
                return this.notifDateField;
            }
            set {
                if ((notifDateField.Equals(value) != true)) {
                    this.notifDateField = value;
                    this.OnPropertyChanged("NotifDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NotifSupplierId {
            get {
                return this.notifSupplierIdField;
            }
            set {
                if ((this.notifSupplierIdField != null)) {
                    if ((notifSupplierIdField.Equals(value) != true)) {
                        this.notifSupplierIdField = value;
                        this.OnPropertyChanged("NotifSupplierId");
                    }
                }
                else {
                    this.notifSupplierIdField = value;
                    this.OnPropertyChanged("NotifSupplierId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NotifCustomerId {
            get {
                return this.notifCustomerIdField;
            }
            set {
                if ((this.notifCustomerIdField != null)) {
                    if ((notifCustomerIdField.Equals(value) != true)) {
                        this.notifCustomerIdField = value;
                        this.OnPropertyChanged("NotifCustomerId");
                    }
                }
                else {
                    this.notifCustomerIdField = value;
                    this.OnPropertyChanged("NotifCustomerId");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(CarrierNoticeHeader));
                }
                return serializer;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        public virtual void OnPropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null)) {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current CarrierNoticeHeader object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize() {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally {
                if ((streamReader != null)) {
                    streamReader.Dispose();
                }
                if ((memoryStream != null)) {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an CarrierNoticeHeader object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output CarrierNoticeHeader object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out CarrierNoticeHeader obj, out System.Exception exception) {
            exception = null;
            obj = default(CarrierNoticeHeader);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out CarrierNoticeHeader obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static CarrierNoticeHeader Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((CarrierNoticeHeader)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current CarrierNoticeHeader object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception) {
            exception = null;
            try {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e) {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName) {
            System.IO.StreamWriter streamWriter = null;
            try {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally {
                if ((streamWriter != null)) {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an CarrierNoticeHeader object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output CarrierNoticeHeader object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out CarrierNoticeHeader obj, out System.Exception exception) {
            exception = null;
            obj = default(CarrierNoticeHeader);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out CarrierNoticeHeader obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static CarrierNoticeHeader LoadFromFile(string fileName) {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally {
                if ((file != null)) {
                    file.Dispose();
                }
                if ((sr != null)) {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.22414")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/CarrierNotice")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/CarrierNotice", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="PositionType", Namespace="http://fsrar.ru/WEGAIS/CarrierNotice")]
    public partial class PositionType : System.ComponentModel.INotifyPropertyChanged {
        
        private string productCodeField;
        
        private decimal quantity20Field;
        
        private decimal alcPerc20Field;
        
        private string posIdentityField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCode {
            get {
                return this.productCodeField;
            }
            set {
                if ((this.productCodeField != null)) {
                    if ((productCodeField.Equals(value) != true)) {
                        this.productCodeField = value;
                        this.OnPropertyChanged("ProductCode");
                    }
                }
                else {
                    this.productCodeField = value;
                    this.OnPropertyChanged("ProductCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Quantity20 {
            get {
                return this.quantity20Field;
            }
            set {
                if ((this.quantity20Field != null)) {
                    if ((quantity20Field.Equals(value) != true)) {
                        this.quantity20Field = value;
                        this.OnPropertyChanged("Quantity20");
                    }
                }
                else {
                    this.quantity20Field = value;
                    this.OnPropertyChanged("Quantity20");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal AlcPerc20 {
            get {
                return this.alcPerc20Field;
            }
            set {
                if ((this.alcPerc20Field != null)) {
                    if ((alcPerc20Field.Equals(value) != true)) {
                        this.alcPerc20Field = value;
                        this.OnPropertyChanged("AlcPerc20");
                    }
                }
                else {
                    this.alcPerc20Field = value;
                    this.OnPropertyChanged("AlcPerc20");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PosIdentity {
            get {
                return this.posIdentityField;
            }
            set {
                if ((this.posIdentityField != null)) {
                    if ((posIdentityField.Equals(value) != true)) {
                        this.posIdentityField = value;
                        this.OnPropertyChanged("PosIdentity");
                    }
                }
                else {
                    this.posIdentityField = value;
                    this.OnPropertyChanged("PosIdentity");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(PositionType));
                }
                return serializer;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        public virtual void OnPropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null)) {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current PositionType object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize() {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally {
                if ((streamReader != null)) {
                    streamReader.Dispose();
                }
                if ((memoryStream != null)) {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an PositionType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output PositionType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out PositionType obj, out System.Exception exception) {
            exception = null;
            obj = default(PositionType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out PositionType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static PositionType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((PositionType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current PositionType object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception) {
            exception = null;
            try {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e) {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName) {
            System.IO.StreamWriter streamWriter = null;
            try {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally {
                if ((streamWriter != null)) {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an PositionType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PositionType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out PositionType obj, out System.Exception exception) {
            exception = null;
            obj = default(PositionType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out PositionType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static PositionType LoadFromFile(string fileName) {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally {
                if ((file != null)) {
                    file.Dispose();
                }
                if ((sr != null)) {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }
}
