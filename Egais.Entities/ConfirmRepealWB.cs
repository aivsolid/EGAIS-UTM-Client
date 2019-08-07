// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.22408 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Egais.Entities.ConfirmRepealWB</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Egais.Entities.ConfirmRepealWB {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/ConfirmRepealWB")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/ConfirmRepealWB", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConfirmRepealWB", Namespace="http://fsrar.ru/WEGAIS/ConfirmRepealWB")]
    public partial class ConfirmRepealWB : System.ComponentModel.INotifyPropertyChanged {
        
        private string identityField;
        
        private ConfirmRepealWBHeader headerField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public ConfirmRepealWB() {
            this.headerField = new ConfirmRepealWBHeader();
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Identity {
            get {
                return this.identityField;
            }
            set {
                if ((this.identityField != null)) {
                    if ((identityField.Equals(value) != true)) {
                        this.identityField = value;
                        this.OnPropertyChanged("Identity");
                    }
                }
                else {
                    this.identityField = value;
                    this.OnPropertyChanged("Identity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConfirmRepealWBHeader Header {
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
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ConfirmRepealWB));
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
        /// Serializes current ConfirmRepealWB object into an XML document
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
        /// Deserializes workflow markup into an ConfirmRepealWB object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ConfirmRepealWB object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ConfirmRepealWB obj, out System.Exception exception) {
            exception = null;
            obj = default(ConfirmRepealWB);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out ConfirmRepealWB obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static ConfirmRepealWB Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((ConfirmRepealWB)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current ConfirmRepealWB object into file
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
        /// Deserializes xml markup from file into an ConfirmRepealWB object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ConfirmRepealWB object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ConfirmRepealWB obj, out System.Exception exception) {
            exception = null;
            obj = default(ConfirmRepealWB);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out ConfirmRepealWB obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ConfirmRepealWB LoadFromFile(string fileName) {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://fsrar.ru/WEGAIS/ConfirmRepealWB")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ConfirmRepealWBHeader", Namespace="http://fsrar.ru/WEGAIS/ConfirmRepealWB")]
    public partial class ConfirmRepealWBHeader : System.ComponentModel.INotifyPropertyChanged {
        
        private ConclusionType isConfirmField;
        
        private string confirmNumberField;
        
        private System.DateTime confirmDateField;
        
        private string wBRegIdField;
        
        private string noteField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConclusionType IsConfirm {
            get {
                return this.isConfirmField;
            }
            set {
                if ((isConfirmField.Equals(value) != true)) {
                    this.isConfirmField = value;
                    this.OnPropertyChanged("IsConfirm");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ConfirmNumber {
            get {
                return this.confirmNumberField;
            }
            set {
                if ((this.confirmNumberField != null)) {
                    if ((confirmNumberField.Equals(value) != true)) {
                        this.confirmNumberField = value;
                        this.OnPropertyChanged("ConfirmNumber");
                    }
                }
                else {
                    this.confirmNumberField = value;
                    this.OnPropertyChanged("ConfirmNumber");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ConfirmDate {
            get {
                return this.confirmDateField;
            }
            set {
                if ((confirmDateField.Equals(value) != true)) {
                    this.confirmDateField = value;
                    this.OnPropertyChanged("ConfirmDate");
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
        public string Note {
            get {
                return this.noteField;
            }
            set {
                if ((this.noteField != null)) {
                    if ((noteField.Equals(value) != true)) {
                        this.noteField = value;
                        this.OnPropertyChanged("Note");
                    }
                }
                else {
                    this.noteField = value;
                    this.OnPropertyChanged("Note");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ConfirmRepealWBHeader));
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
        /// Serializes current ConfirmRepealWBHeader object into an XML document
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
        /// Deserializes workflow markup into an ConfirmRepealWBHeader object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ConfirmRepealWBHeader object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ConfirmRepealWBHeader obj, out System.Exception exception) {
            exception = null;
            obj = default(ConfirmRepealWBHeader);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out ConfirmRepealWBHeader obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static ConfirmRepealWBHeader Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((ConfirmRepealWBHeader)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current ConfirmRepealWBHeader object into file
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
        /// Deserializes xml markup from file into an ConfirmRepealWBHeader object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ConfirmRepealWBHeader object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ConfirmRepealWBHeader obj, out System.Exception exception) {
            exception = null;
            obj = default(ConfirmRepealWBHeader);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out ConfirmRepealWBHeader obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ConfirmRepealWBHeader LoadFromFile(string fileName) {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/ConfirmRepealWB")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/ConfirmRepealWB", IsNullable=false)]
    public enum ConclusionType {
        
        /// <remarks/>
        Accepted,
        
        /// <remarks/>
        Rejected,
    }
}