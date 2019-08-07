// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.22408 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Egais.Entities.ReplyFormB</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Egais.Entities.ReplyFormB {
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
    using Egais.Entities.ClientRef;
    using Egais.Entities.ProductRef;
    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.22414")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/ReplyFormB")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/ReplyFormB", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReplyFormB", Namespace="http://fsrar.ru/WEGAIS/ReplyFormB")]
    public partial class ReplyFormB : System.ComponentModel.INotifyPropertyChanged {
        
        private string informBRegIdField;
        
        private string tTNNumberField;
        
        private System.DateTime tTNDateField;
        
        private OrgInfo shipperField;
        
        private OrgInfo consigneeField;
        
        private System.DateTime shippingDateField;
        
        private bool shippingDateFieldSpecified;
        
        private ProductInfo productField;
        
        private decimal quantityField;
        
        private decimal exciseRateField;
        
        private bool exciseRateFieldSpecified;
        
        private MarkInfoType markInfoField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public ReplyFormB() {
            this.markInfoField = new MarkInfoType();
            this.productField = new ProductInfo();
            this.consigneeField = new OrgInfo();
            this.shipperField = new OrgInfo();
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InformBRegId {
            get {
                return this.informBRegIdField;
            }
            set {
                if ((this.informBRegIdField != null)) {
                    if ((informBRegIdField.Equals(value) != true)) {
                        this.informBRegIdField = value;
                        this.OnPropertyChanged("InformBRegId");
                    }
                }
                else {
                    this.informBRegIdField = value;
                    this.OnPropertyChanged("InformBRegId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TTNNumber {
            get {
                return this.tTNNumberField;
            }
            set {
                if ((this.tTNNumberField != null)) {
                    if ((tTNNumberField.Equals(value) != true)) {
                        this.tTNNumberField = value;
                        this.OnPropertyChanged("TTNNumber");
                    }
                }
                else {
                    this.tTNNumberField = value;
                    this.OnPropertyChanged("TTNNumber");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TTNDate {
            get {
                return this.tTNDateField;
            }
            set {
                if ((tTNDateField.Equals(value) != true)) {
                    this.tTNDateField = value;
                    this.OnPropertyChanged("TTNDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OrgInfo Shipper {
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
        public OrgInfo Consignee {
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
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ShippingDate {
            get {
                return this.shippingDateField;
            }
            set {
                if ((shippingDateField.Equals(value) != true)) {
                    this.shippingDateField = value;
                    this.OnPropertyChanged("ShippingDate");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ShippingDateSpecified {
            get {
                return this.shippingDateFieldSpecified;
            }
            set {
                if ((shippingDateFieldSpecified.Equals(value) != true)) {
                    this.shippingDateFieldSpecified = value;
                    this.OnPropertyChanged("ShippingDateSpecified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ProductInfo Product {
            get {
                return this.productField;
            }
            set {
                if ((this.productField != null)) {
                    if ((productField.Equals(value) != true)) {
                        this.productField = value;
                        this.OnPropertyChanged("Product");
                    }
                }
                else {
                    this.productField = value;
                    this.OnPropertyChanged("Product");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Quantity {
            get {
                return this.quantityField;
            }
            set {
                if ((this.quantityField != null)) {
                    if ((quantityField.Equals(value) != true)) {
                        this.quantityField = value;
                        this.OnPropertyChanged("Quantity");
                    }
                }
                else {
                    this.quantityField = value;
                    this.OnPropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ExciseRate {
            get {
                return this.exciseRateField;
            }
            set {
                if ((this.exciseRateField != null)) {
                    if ((exciseRateField.Equals(value) != true)) {
                        this.exciseRateField = value;
                        this.OnPropertyChanged("ExciseRate");
                    }
                }
                else {
                    this.exciseRateField = value;
                    this.OnPropertyChanged("ExciseRate");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ExciseRateSpecified {
            get {
                return this.exciseRateFieldSpecified;
            }
            set {
                if ((exciseRateFieldSpecified.Equals(value) != true)) {
                    this.exciseRateFieldSpecified = value;
                    this.OnPropertyChanged("ExciseRateSpecified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MarkInfoType MarkInfo {
            get {
                return this.markInfoField;
            }
            set {
                if ((this.markInfoField != null)) {
                    if ((markInfoField.Equals(value) != true)) {
                        this.markInfoField = value;
                        this.OnPropertyChanged("MarkInfo");
                    }
                }
                else {
                    this.markInfoField = value;
                    this.OnPropertyChanged("MarkInfo");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ReplyFormB));
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
        /// Serializes current ReplyFormB object into an XML document
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
        /// Deserializes workflow markup into an ReplyFormB object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ReplyFormB object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ReplyFormB obj, out System.Exception exception) {
            exception = null;
            obj = default(ReplyFormB);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out ReplyFormB obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static ReplyFormB Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((ReplyFormB)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current ReplyFormB object into file
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
        /// Deserializes xml markup from file into an ReplyFormB object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ReplyFormB object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ReplyFormB obj, out System.Exception exception) {
            exception = null;
            obj = default(ReplyFormB);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out ReplyFormB obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ReplyFormB LoadFromFile(string fileName) {
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
