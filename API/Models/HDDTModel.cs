
/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
*/

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace API.Models
{
    [XmlRoot(ElementName = "Item")]
    public class Item
    {
        [XmlElement(ElementName = "index")]
        public string Index { get; set; }
        [XmlElement(ElementName = "cusCode")]
        public string CusCode { get; set; }
        [XmlElement(ElementName = "invToken")]
        public string InvToken { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "publishDate")]
        public string PublishDate { get; set; }
        [XmlElement(ElementName = "signStatus")]
        public string SignStatus { get; set; }
        [XmlElement(ElementName = "pattern")]
        public string Pattern { get; set; }
        [XmlElement(ElementName = "serial")]
        public string Serial { get; set; }
        [XmlElement(ElementName = "invNum")]
        public string InvNum { get; set; }
        [XmlElement(ElementName = "amount")]
        public string Amount { get; set; }
        [XmlElement(ElementName = "total")]
        public string Total { get; set; }
        [XmlElement(ElementName = "vatAmount")]
        public string VatAmount { get; set; }
        [XmlElement(ElementName = "status")]
        public string Status { get; set; }
        [XmlElement(ElementName = "cusname")]
        public string Cusname { get; set; }
        [XmlElement(ElementName = "payment")]
        public string Payment { get; set; }
        [XmlElement(ElementName = "fkey")]
        public string Fkey { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "kindOfService")]
        public string KindOfService { get; set; }
    }

    [XmlRoot(ElementName = "Data")]
    public class Data
    {
        [XmlElement(ElementName = "Item")]
        public List<Item> Item { get; set; }
    }

    //////////////////////////////// DETAIL XML ////////////////
    ///

    [XmlRoot(ElementName = "Sumption")]
    public class Sumption
    {
        [XmlElement(ElementName = "CHI_SO_DAU_KY")]
        public string CHI_SO_DAU_KY { get; set; }
        [XmlElement(ElementName = "CHI_SO_CUOI_KY")]
        public string CHI_SO_CUOI_KY { get; set; }
        [XmlElement(ElementName = "SAN_LUONG")]
        public string SAN_LUONG { get; set; }
        [XmlElement(ElementName = "MA_TINH_TRANG_DH")]
        public string MA_TINH_TRANG_DH { get; set; }
    }

    [XmlRoot(ElementName = "Sumptions")]
    public class Sumptions
    {
        [XmlElement(ElementName = "Sumption")]
        public Sumption Sumption { get; set; }
    }

    //[XmlRoot(ElementName = "Product")]
    //public class Product
    //{
    //    [XmlElement(ElementName = "Code")]
    //    public string Code { get; set; }
    //    [XmlElement(ElementName = "ProdName")]
    //    public string ProdName { get; set; }
    //    [XmlElement(ElementName = "ProdUnit")]
    //    public string ProdUnit { get; set; }
    //    [XmlElement(ElementName = "ProdQuantity")]
    //    public string ProdQuantity { get; set; }
    //    [XmlElement(ElementName = "ProdPrice")]
    //    public string ProdPrice { get; set; }
    //    [XmlElement(ElementName = "Total")]
    //    public string Total { get; set; }
    //    [XmlElement(ElementName = "Discount")]
    //    public string Discount { get; set; }
    //    [XmlElement(ElementName = "DiscountAmount")]
    //    public string DiscountAmount { get; set; }
    //    [XmlElement(ElementName = "VATRate")]
    //    public string VATRate { get; set; }
    //    [XmlElement(ElementName = "VATAmount")]
    //    public string VATAmount { get; set; }
    //    [XmlElement(ElementName = "Amount")]
    //    public string Amount { get; set; }
    //    [XmlElement(ElementName = "ExTra1")]
    //    public string ExTra1 { get; set; }
    //    [XmlElement(ElementName = "ExTra2")]
    //    public string ExTra2 { get; set; }
    //    [XmlElement(ElementName = "ExTra3")]
    //    public string ExTra3 { get; set; }
    //    [XmlElement(ElementName = "Remark")]
    //    public string Remark { get; set; }
    //}

    //[XmlRoot(ElementName = "Products")]
    //public class Products
    //{
    //    [XmlElement(ElementName = "Product")]
    //    public List<Product> Product { get; set; }
    //}

    [XmlRoot(ElementName = "Content")]
    public class Content
    {
        [XmlElement(ElementName = "Key")]
        public string Key { get; set; }
        [XmlElement(ElementName = "Extra")]
        public string Extra { get; set; }
        [XmlElement(ElementName = "InvoiceName")]
        public string InvoiceName { get; set; }
        [XmlElement(ElementName = "InvoicePattern")]
        public string InvoicePattern { get; set; }
        [XmlElement(ElementName = "SerialNo")]
        public string SerialNo { get; set; }
        [XmlElement(ElementName = "InvoiceNo")]
        public string InvoiceNo { get; set; }
        [XmlElement(ElementName = "ArisingDate")]
        public string ArisingDate { get; set; }
        [XmlElement(ElementName = "Kind_of_Payment")]
        public string Kind_of_Payment { get; set; }
        [XmlElement(ElementName = "ComName")]
        public string ComName { get; set; }
        [XmlElement(ElementName = "ComTaxCode")]
        public string ComTaxCode { get; set; }
        [XmlElement(ElementName = "ComAddress")]
        public string ComAddress { get; set; }
        [XmlElement(ElementName = "ComPhone")]
        public string ComPhone { get; set; }
        [XmlElement(ElementName = "ComBankNo")]
        public string ComBankNo { get; set; }
        [XmlElement(ElementName = "ComBankName")]
        public string ComBankName { get; set; }
        [XmlElement(ElementName = "CusCode")]
        public string CusCode { get; set; }
        [XmlElement(ElementName = "CusName")]
        public string CusName { get; set; }
        [XmlElement(ElementName = "Buyer")]
        public string Buyer { get; set; }
        [XmlElement(ElementName = "CusTaxCode")]
        public string CusTaxCode { get; set; }
        [XmlElement(ElementName = "CusPhone")]
        public string CusPhone { get; set; }
        [XmlElement(ElementName = "CusAddress")]
        public string CusAddress { get; set; }
        [XmlElement(ElementName = "CusBankName")]
        public string CusBankName { get; set; }
        [XmlElement(ElementName = "CusBankNo")]
        public string CusBankNo { get; set; }
        [XmlElement(ElementName = "Total")]
        public string Total { get; set; }
        [XmlElement(ElementName = "Amount")]
        public string Amount { get; set; }
        [XmlElement(ElementName = "Amount_words")]
        public string Amount_words { get; set; }
        [XmlElement(ElementName = "Note")]
        public string Note { get; set; }
        [XmlElement(ElementName = "KindOfService")]
        public string KindOfService { get; set; }
        [XmlElement(ElementName = "VAT_Amount")]
        public string VAT_Amount { get; set; }
        [XmlElement(ElementName = "VATNT_TN")]
        public string VATNT_TN { get; set; }
        [XmlElement(ElementName = "VATRate")]
        public string VATRate { get; set; }
        [XmlElement(ElementName = "Discount_Rate")]
        public string Discount_Rate { get; set; }
        [XmlElement(ElementName = "Discount_Amount")]
        public string Discount_Amount { get; set; }
        [XmlElement(ElementName = "SO_HOP_DONG")]
        public string SO_HOP_DONG { get; set; }
        [XmlElement(ElementName = "DIA_CHI_DONG_HO")]
        public string DIA_CHI_DONG_HO { get; set; }
        [XmlElement(ElementName = "MA_SO_DOC")]
        public string MA_SO_DOC { get; set; }
        [XmlElement(ElementName = "STT_SO_DOC")]
        public string STT_SO_DOC { get; set; }
        [XmlElement(ElementName = "NGAY_DOC_DAU")]
        public string NGAY_DOC_DAU { get; set; }
        [XmlElement(ElementName = "NGAY_DOC_CUOI")]
        public string NGAY_DOC_CUOI { get; set; }
        [XmlElement(ElementName = "TONG_SAN_LUONG")]
        public string TONG_SAN_LUONG { get; set; }
        [XmlElement(ElementName = "MA_LOAI_HOA_DON")]
        public string MA_LOAI_HOA_DON { get; set; }
        [XmlElement(ElementName = "TEN_LOAI_HOA_DON")]
        public string TEN_LOAI_HOA_DON { get; set; }
        [XmlElement(ElementName = "DIEN_GIAI")]
        public string DIEN_GIAI { get; set; }
        [XmlElement(ElementName = "PHI_BVMT")]
        public string PHI_BVMT { get; set; }
        [XmlElement(ElementName = "TONGNT_TN")]
        public string TONGNT_TN { get; set; }
        [XmlElement(ElementName = "TEN_LOAI_CHI_SO")]
        public string TEN_LOAI_CHI_SO { get; set; }
        [XmlElement(ElementName = "CHI_SO_DAU_KY")]
        public string CHI_SO_DAU_KY { get; set; }
        [XmlElement(ElementName = "CHI_SO_CUOI_KY")]
        public string CHI_SO_CUOI_KY { get; set; }
        [XmlElement(ElementName = "SAN_LUONG")]
        public string SAN_LUONG { get; set; }
        [XmlElement(ElementName = "MA_TINH_TRANG_DH")]
        public string MA_TINH_TRANG_DH { get; set; }
        [XmlElement(ElementName = "Sumptions")]
        public Sumptions Sumptions { get; set; }
        [XmlElement(ElementName = "Products")]
        //public Products Products { get; set; }
        [XmlElement(ElementName = "SignDate")]
        public string SignDate { get; set; }
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class CanonicalizationMethod
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignatureMethod
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Transform
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Transforms
    {
        [XmlElement(ElementName = "Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Transform Transform { get; set; }
    }

    [XmlRoot(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class DigestMethod
    {
        [XmlAttribute(AttributeName = "Algorithm")]
        public string Algorithm { get; set; }
    }

    [XmlRoot(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Reference
    {
        [XmlElement(ElementName = "Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Transforms Transforms { get; set; }
        [XmlElement(ElementName = "DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethod DigestMethod { get; set; }
        [XmlElement(ElementName = "DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string DigestValue { get; set; }
        [XmlAttribute(AttributeName = "URI")]
        public string URI { get; set; }
    }

    [XmlRoot(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class SignedInfo
    {
        [XmlElement(ElementName = "CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public CanonicalizationMethod CanonicalizationMethod { get; set; }
        [XmlElement(ElementName = "SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureMethod SignatureMethod { get; set; }
        [XmlElement(ElementName = "Reference", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Reference Reference { get; set; }
    }

    [XmlRoot(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class X509Data
    {
        [XmlElement(ElementName = "X509Certificate", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string X509Certificate { get; set; }
    }

    [XmlRoot(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class KeyInfo
    {
        [XmlElement(ElementName = "X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public X509Data X509Data { get; set; }
    }

    [XmlRoot(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public class Signature
    {
        [XmlElement(ElementName = "SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignedInfo SignedInfo { get; set; }
        [XmlElement(ElementName = "SignatureValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string SignatureValue { get; set; }
        [XmlElement(ElementName = "KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public KeyInfo KeyInfo { get; set; }
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Invoice")]
    public class Invoice
    {
        [XmlElement(ElementName = "Content")]
        public Content Content { get; set; }
        [XmlElement(ElementName = "Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature { get; set; }
    }

}
