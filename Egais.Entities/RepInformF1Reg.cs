// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.22408 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Egais.Entities.RepInformF1Reg</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Egais.Entities.RepInformF1Reg {
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
    using Egais.Entities.ClientRef_v2;
    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.22414")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/RepInformF1Reg")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/RepInformF1Reg", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepPIInformF1RegType", Namespace="http://fsrar.ru/WEGAIS/RepInformF1Reg")]
    public partial class RepPIInformF1RegType : System.ComponentModel.INotifyPropertyChanged {
        
        private RepPIInformF1RegTypeHeader headerField;
        
        private List<InformF1PositionType> contentField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public RepPIInformF1RegType() {
            this.contentField = new List<InformF1PositionType>();
            this.headerField = new RepPIInformF1RegTypeHeader();
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RepPIInformF1RegTypeHeader Header {
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
        public List<InformF1PositionType> Content {
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(RepPIInformF1RegType));
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
        /// Serializes current RepPIInformF1RegType object into an XML document
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
        /// Deserializes workflow markup into an RepPIInformF1RegType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output RepPIInformF1RegType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out RepPIInformF1RegType obj, out System.Exception exception) {
            exception = null;
            obj = default(RepPIInformF1RegType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out RepPIInformF1RegType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static RepPIInformF1RegType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((RepPIInformF1RegType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current RepPIInformF1RegType object into file
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
        /// Deserializes xml markup from file into an RepPIInformF1RegType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output RepPIInformF1RegType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out RepPIInformF1RegType obj, out System.Exception exception) {
            exception = null;
            obj = default(RepPIInformF1RegType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out RepPIInformF1RegType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static RepPIInformF1RegType LoadFromFile(string fileName) {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://fsrar.ru/WEGAIS/RepInformF1Reg")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepPIInformF1RegTypeHeader", Namespace="http://fsrar.ru/WEGAIS/RepInformF1Reg")]
    public partial class RepPIInformF1RegTypeHeader : System.ComponentModel.INotifyPropertyChanged {
        
        private string identityField;
        
        private string repRegIdField;
        
        private OrgInfoRusReply_v2 clientField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public RepPIInformF1RegTypeHeader() {
            this.clientField = new OrgInfoRusReply_v2();
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
        public string RepRegId {
            get {
                return this.repRegIdField;
            }
            set {
                if ((this.repRegIdField != null)) {
                    if ((repRegIdField.Equals(value) != true)) {
                        this.repRegIdField = value;
                        this.OnPropertyChanged("RepRegId");
                    }
                }
                else {
                    this.repRegIdField = value;
                    this.OnPropertyChanged("RepRegId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public OrgInfoRusReply_v2 Client {
            get {
                return this.clientField;
            }
            set {
                if ((this.clientField != null)) {
                    if ((clientField.Equals(value) != true)) {
                        this.clientField = value;
                        this.OnPropertyChanged("Client");
                    }
                }
                else {
                    this.clientField = value;
                    this.OnPropertyChanged("Client");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(RepPIInformF1RegTypeHeader));
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
        /// Serializes current RepPIInformF1RegTypeHeader object into an XML document
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
        /// Deserializes workflow markup into an RepPIInformF1RegTypeHeader object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output RepPIInformF1RegTypeHeader object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out RepPIInformF1RegTypeHeader obj, out System.Exception exception) {
            exception = null;
            obj = default(RepPIInformF1RegTypeHeader);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out RepPIInformF1RegTypeHeader obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static RepPIInformF1RegTypeHeader Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((RepPIInformF1RegTypeHeader)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current RepPIInformF1RegTypeHeader object into file
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
        /// Deserializes xml markup from file into an RepPIInformF1RegTypeHeader object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output RepPIInformF1RegTypeHeader object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out RepPIInformF1RegTypeHeader obj, out System.Exception exception) {
            exception = null;
            obj = default(RepPIInformF1RegTypeHeader);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out RepPIInformF1RegTypeHeader obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static RepPIInformF1RegTypeHeader LoadFromFile(string fileName) {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/RepInformF1Reg")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/RepInformF1Reg", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="InformF1PositionType", Namespace="http://fsrar.ru/WEGAIS/RepInformF1Reg")]
    public partial class InformF1PositionType : System.ComponentModel.INotifyPropertyChanged {
        
        private string identityField;
        
        private string informF1RegIdField;
        
        private string informF2RegIdField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
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
        public string InformF1RegId {
            get {
                return this.informF1RegIdField;
            }
            set {
                if ((this.informF1RegIdField != null)) {
                    if ((informF1RegIdField.Equals(value) != true)) {
                        this.informF1RegIdField = value;
                        this.OnPropertyChanged("InformF1RegId");
                    }
                }
                else {
                    this.informF1RegIdField = value;
                    this.OnPropertyChanged("InformF1RegId");
                }
            }
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
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(InformF1PositionType));
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
        /// Serializes current InformF1PositionType object into an XML document
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
        /// Deserializes workflow markup into an InformF1PositionType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output InformF1PositionType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out InformF1PositionType obj, out System.Exception exception) {
            exception = null;
            obj = default(InformF1PositionType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out InformF1PositionType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static InformF1PositionType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((InformF1PositionType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current InformF1PositionType object into file
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
        /// Deserializes xml markup from file into an InformF1PositionType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output InformF1PositionType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out InformF1PositionType obj, out System.Exception exception) {
            exception = null;
            obj = default(InformF1PositionType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out InformF1PositionType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static InformF1PositionType LoadFromFile(string fileName) {
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
