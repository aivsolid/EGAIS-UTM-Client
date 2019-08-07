// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.22408 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Egais.Entities.ActWriteOffShop_v2</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>True</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>True</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Egais.Entities.ActWriteOffShop_v2 {
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
    using Egais.Entities.ProductRef_v2;
    

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.22414")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/ActWriteOffShop_v2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/ActWriteOffShop_v2", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActWriteOffShopType_v2", Namespace="http://fsrar.ru/WEGAIS/ActWriteOffShop_v2")]
    public partial class ActWriteOffShopType_v2 : System.ComponentModel.INotifyPropertyChanged {
        
        private string identityField;
        
        private ActWriteOffShopType_v2Header headerField;
        
        private List<ActWriteOffShopPositionType> contentField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public ActWriteOffShopType_v2() {
            this.contentField = new List<ActWriteOffShopPositionType>();
            this.headerField = new ActWriteOffShopType_v2Header();
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
        public ActWriteOffShopType_v2Header Header {
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
        public List<ActWriteOffShopPositionType> Content {
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ActWriteOffShopType_v2));
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
        /// Serializes current ActWriteOffShopType_v2 object into an XML document
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
        /// Deserializes workflow markup into an ActWriteOffShopType_v2 object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ActWriteOffShopType_v2 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ActWriteOffShopType_v2 obj, out System.Exception exception) {
            exception = null;
            obj = default(ActWriteOffShopType_v2);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out ActWriteOffShopType_v2 obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static ActWriteOffShopType_v2 Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((ActWriteOffShopType_v2)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current ActWriteOffShopType_v2 object into file
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
        /// Deserializes xml markup from file into an ActWriteOffShopType_v2 object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ActWriteOffShopType_v2 object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ActWriteOffShopType_v2 obj, out System.Exception exception) {
            exception = null;
            obj = default(ActWriteOffShopType_v2);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out ActWriteOffShopType_v2 obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ActWriteOffShopType_v2 LoadFromFile(string fileName) {
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://fsrar.ru/WEGAIS/ActWriteOffShop_v2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActWriteOffShopType_v2Header", Namespace="http://fsrar.ru/WEGAIS/ActWriteOffShop_v2")]
    public partial class ActWriteOffShopType_v2Header : System.ComponentModel.INotifyPropertyChanged {
        
        private string actNumberField;
        
        private System.DateTime actDateField;
        
        private TypeWriteOff typeWriteOffField;
        
        private string noteField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ActNumber {
            get {
                return this.actNumberField;
            }
            set {
                if ((this.actNumberField != null)) {
                    if ((actNumberField.Equals(value) != true)) {
                        this.actNumberField = value;
                        this.OnPropertyChanged("ActNumber");
                    }
                }
                else {
                    this.actNumberField = value;
                    this.OnPropertyChanged("ActNumber");
                }
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ActDate {
            get {
                return this.actDateField;
            }
            set {
                if ((actDateField.Equals(value) != true)) {
                    this.actDateField = value;
                    this.OnPropertyChanged("ActDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TypeWriteOff TypeWriteOff {
            get {
                return this.typeWriteOffField;
            }
            set {
                if ((typeWriteOffField.Equals(value) != true)) {
                    this.typeWriteOffField = value;
                    this.OnPropertyChanged("TypeWriteOff");
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
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ActWriteOffShopType_v2Header));
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
        /// Serializes current ActWriteOffShopType_v2Header object into an XML document
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
        /// Deserializes workflow markup into an ActWriteOffShopType_v2Header object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ActWriteOffShopType_v2Header object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ActWriteOffShopType_v2Header obj, out System.Exception exception) {
            exception = null;
            obj = default(ActWriteOffShopType_v2Header);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out ActWriteOffShopType_v2Header obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static ActWriteOffShopType_v2Header Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((ActWriteOffShopType_v2Header)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current ActWriteOffShopType_v2Header object into file
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
        /// Deserializes xml markup from file into an ActWriteOffShopType_v2Header object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ActWriteOffShopType_v2Header object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ActWriteOffShopType_v2Header obj, out System.Exception exception) {
            exception = null;
            obj = default(ActWriteOffShopType_v2Header);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out ActWriteOffShopType_v2Header obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ActWriteOffShopType_v2Header LoadFromFile(string fileName) {
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://fsrar.ru/WEGAIS/ActWriteOffShop_v2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://fsrar.ru/WEGAIS/ActWriteOffShop_v2", IsNullable=true)]
    [System.Runtime.Serialization.DataContractAttribute(Name="ActWriteOffShopPositionType", Namespace="http://fsrar.ru/WEGAIS/ActWriteOffShop_v2")]
    public partial class ActWriteOffShopPositionType : System.ComponentModel.INotifyPropertyChanged {
        
        private string identityField;
        
        private ProductInfo_v2 productField;
        
        private decimal quantityField;
        
        private decimal sumSaleField;
        
        private bool sumSaleFieldSpecified;
        
        private List<string> markCodeInfoField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public ActWriteOffShopPositionType() {
            this.markCodeInfoField = new List<string>();
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
        public ProductInfo_v2 Product {
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
        public decimal SumSale {
            get {
                return this.sumSaleField;
            }
            set {
                if ((this.sumSaleField != null)) {
                    if ((sumSaleField.Equals(value) != true)) {
                        this.sumSaleField = value;
                        this.OnPropertyChanged("SumSale");
                    }
                }
                else {
                    this.sumSaleField = value;
                    this.OnPropertyChanged("SumSale");
                }
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SumSaleSpecified {
            get {
                return this.sumSaleFieldSpecified;
            }
            set {
                if ((sumSaleFieldSpecified.Equals(value) != true)) {
                    this.sumSaleFieldSpecified = value;
                    this.OnPropertyChanged("SumSaleSpecified");
                }
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("MarkCode", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> MarkCodeInfo {
            get {
                return this.markCodeInfoField;
            }
            set {
                if ((this.markCodeInfoField != null)) {
                    if ((markCodeInfoField.Equals(value) != true)) {
                        this.markCodeInfoField = value;
                        this.OnPropertyChanged("MarkCodeInfo");
                    }
                }
                else {
                    this.markCodeInfoField = value;
                    this.OnPropertyChanged("MarkCodeInfo");
                }
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ActWriteOffShopPositionType));
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
        /// Serializes current ActWriteOffShopPositionType object into an XML document
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
        /// Deserializes workflow markup into an ActWriteOffShopPositionType object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ActWriteOffShopPositionType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ActWriteOffShopPositionType obj, out System.Exception exception) {
            exception = null;
            obj = default(ActWriteOffShopPositionType);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out ActWriteOffShopPositionType obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static ActWriteOffShopPositionType Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((ActWriteOffShopPositionType)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current ActWriteOffShopPositionType object into file
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
        /// Deserializes xml markup from file into an ActWriteOffShopPositionType object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ActWriteOffShopPositionType object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ActWriteOffShopPositionType obj, out System.Exception exception) {
            exception = null;
            obj = default(ActWriteOffShopPositionType);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out ActWriteOffShopPositionType obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static ActWriteOffShopPositionType LoadFromFile(string fileName) {
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