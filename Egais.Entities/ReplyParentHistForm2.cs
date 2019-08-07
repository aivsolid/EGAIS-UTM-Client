// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.22408 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Egais.Entities.ReplyParentHistForm2</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Egais.Entities.ReplyParentHistForm2 {
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
    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.22414")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/ReplyParentHistForm2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/ReplyParentHistForm2", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReplyParentHistForm2", Namespace="http://fsrar.ru/WEGAIS/ReplyParentHistForm2")]
    public partial class ReplyParentHistForm2 : System.ComponentModel.INotifyPropertyChanged {
        
        private string informF2RegIdField;
        
        private System.DateTime histForm2DateField;
        
        private List<stepBType> parentHistField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public ReplyParentHistForm2() {
            this.parentHistField = new List<stepBType>();
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InformF2RegId {
            get {
                return this.informF2RegIdField;
            }
            set {
                if ((this.informF2RegIdField != null)) {
                    if ((informF2RegIdField.Equals(value) != true)) {
                        this.informF2RegIdField = value;
                        this.OnPropertyChanged("InformF2RegId");
                    }
                }
                else {
                    this.informF2RegIdField = value;
                    this.OnPropertyChanged("InformF2RegId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime HistForm2Date {
            get {
                return this.histForm2DateField;
            }
            set {
                if ((histForm2DateField.Equals(value) != true)) {
                    this.histForm2DateField = value;
                    this.OnPropertyChanged("HistForm2Date");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("step", IsNullable=false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<stepBType> ParentHist {
            get {
                return this.parentHistField;
            }
            set {
                if ((this.parentHistField != null)) {
                    if ((parentHistField.Equals(value) != true)) {
                        this.parentHistField = value;
                        this.OnPropertyChanged("ParentHist");
                    }
                }
                else {
                    this.parentHistField = value;
                    this.OnPropertyChanged("ParentHist");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ReplyParentHistForm2));
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
        /// Serializes current ReplyParentHistForm2 object into an XML document
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
        /// Deserializes workflow markup into an ReplyParentHistForm2 object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ReplyParentHistForm2 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ReplyParentHistForm2 obj, out System.Exception exception) {
            exception = null;
            obj = default(ReplyParentHistForm2);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out ReplyParentHistForm2 obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static ReplyParentHistForm2 Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((ReplyParentHistForm2)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current ReplyParentHistForm2 object into file
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
        /// Deserializes xml markup from file into an ReplyParentHistForm2 object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ReplyParentHistForm2 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ReplyParentHistForm2 obj, out System.Exception exception) {
            exception = null;
            obj = default(ReplyParentHistForm2);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out ReplyParentHistForm2 obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ReplyParentHistForm2 LoadFromFile(string fileName) {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/ReplyParentHistForm2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/ReplyParentHistForm2", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="stepBType", Namespace="http://fsrar.ru/WEGAIS/ReplyParentHistForm2")]
    public partial class stepBType : System.ComponentModel.INotifyPropertyChanged {
        
        private string levField;
        
        private string form2Field;
        
        private string parentForm2Field;
        
        private string shipperField;
        
        private string consigneeField;
        
        private string wBRegIdField;
        
        private decimal amountField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lev {
            get {
                return this.levField;
            }
            set {
                if ((this.levField != null)) {
                    if ((levField.Equals(value) != true)) {
                        this.levField = value;
                        this.OnPropertyChanged("lev");
                    }
                }
                else {
                    this.levField = value;
                    this.OnPropertyChanged("lev");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Form2 {
            get {
                return this.form2Field;
            }
            set {
                if ((this.form2Field != null)) {
                    if ((form2Field.Equals(value) != true)) {
                        this.form2Field = value;
                        this.OnPropertyChanged("Form2");
                    }
                }
                else {
                    this.form2Field = value;
                    this.OnPropertyChanged("Form2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string parentForm2 {
            get {
                return this.parentForm2Field;
            }
            set {
                if ((this.parentForm2Field != null)) {
                    if ((parentForm2Field.Equals(value) != true)) {
                        this.parentForm2Field = value;
                        this.OnPropertyChanged("parentForm2");
                    }
                }
                else {
                    this.parentForm2Field = value;
                    this.OnPropertyChanged("parentForm2");
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
        public string WBRegId {
            get {
                return this.wBRegIdField;
            }
            set {
                if ((this.wBRegIdField != null)) {
                    if ((wBRegIdField.Equals(value) != true)) {
                        this.wBRegIdField = value;
                        this.OnPropertyChanged("WBRegId");
                    }
                }
                else {
                    this.wBRegIdField = value;
                    this.OnPropertyChanged("WBRegId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField != null)) {
                    if ((amountField.Equals(value) != true)) {
                        this.amountField = value;
                        this.OnPropertyChanged("amount");
                    }
                }
                else {
                    this.amountField = value;
                    this.OnPropertyChanged("amount");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(stepBType));
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
        /// Serializes current stepBType object into an XML document
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
        /// Deserializes workflow markup into an stepBType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output stepBType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out stepBType obj, out System.Exception exception) {
            exception = null;
            obj = default(stepBType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out stepBType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static stepBType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((stepBType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current stepBType object into file
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
        /// Deserializes xml markup from file into an stepBType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output stepBType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out stepBType obj, out System.Exception exception) {
            exception = null;
            obj = default(stepBType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out stepBType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static stepBType LoadFromFile(string fileName) {
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
