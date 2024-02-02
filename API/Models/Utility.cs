using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

public class Utility
{
    public static string Sec2HMS(int totalsec)
    {
        int h = totalsec / 3600;
        int m = (totalsec % 3600) / 60;
        int s = (totalsec % 3600) % 60;
        return string.Format("{0:00}:{1:00}:{2:00}", h, m, s);
    }

    public static string XoaKiTuDacBiet(string strChuoi)
    {
        var specialChar = new string[] { "%", "/", "\\", "\"", "?", "<", ">", "#", "^", "`", "'", "=", "!", ":", ",", ".", "*", "&", "__", "▄", "+", ";", " ", "---", "--" };
        var replaceChar = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "_", "", "", "", "_", "_", "", "", "", "-", "-", "-" };
        for (int i = 0; i < specialChar.Length; i++)
            strChuoi = strChuoi.Replace(specialChar[i], replaceChar[i]);

        return strChuoi;
    }

    public static string ChuyenTVKhongDau(string strVietNamese)
    {
        var chars = new char[] { 'a', 'A', 'e', 'E', 'o', 'O', 'u', 'U', 'i', 'I', 'd', 'D', 'y', 'Y' };
        var uni = new char[14][];
        uni[0] = new char[] { 'á', 'à', 'ạ', 'ả', 'ã', 'â', 'ấ', 'ầ', 'ậ', 'ẩ', 'ẫ', 'ă', 'ắ', 'ằ', 'ặ', 'ẳ' };
        uni[1] = new char[] { 'Á', 'À', 'Ạ', 'Ả', 'Ã', 'Â', 'Ấ', 'Ầ', 'Ậ', 'Ẩ', 'Ẫ', 'Ă', 'Ắ', 'Ằ', 'Ặ', 'Ẳ' };
        uni[2] = new char[] { 'é', 'è', 'ẹ', 'ẻ', 'ẽ', 'ê', 'ế', 'ề', 'ệ', 'ể', 'ễ' };
        uni[3] = new char[] { 'É', 'È', 'Ẹ', 'Ẻ', 'Ẽ', 'Ê', 'Ế', 'Ề', 'Ệ', 'Ể', 'Ễ' };
        uni[4] = new char[] { 'ó', 'ò', 'ọ', 'ỏ', 'õ', 'ô', 'ố', 'ồ', 'ộ', 'ổ', 'ỗ', 'ơ', 'ớ', 'ờ', 'ợ', 'ở', 'ỡ' };
        uni[5] = new char[] { 'Ó', 'Ò', 'Ọ', 'Ỏ', 'Õ', 'Ô', 'Ố', 'Ồ', 'Ộ', 'Ổ', 'Ỗ', 'Ơ', 'Ớ', 'Ờ', 'Ợ', 'Ở', 'Ỡ' };
        uni[6] = new char[] { 'ú', 'ù', 'ụ', 'ủ', 'ũ', 'ư', 'ứ', 'ừ', 'ự', 'ử', 'ữ' };
        uni[7] = new char[] { 'Ú', 'Ù', 'Ụ', 'Ủ', 'Ũ', 'Ư', 'Ứ', 'Ừ', 'Ự', 'Ử', 'Ữ' };
        uni[8] = new char[] { 'í', 'ì', 'ị', 'ỉ', 'ĩ' };
        uni[9] = new char[] { 'Í', 'Ì', 'Ị', 'Ỉ', 'Ĩ' };
        uni[10] = new char[] { 'đ' };
        uni[11] = new char[] { 'Đ' };
        uni[12] = new char[] { 'ý', 'ỳ', 'ỵ', 'ỷ', 'ỹ' };
        uni[13] = new char[] { 'Ý', 'Ỳ', 'Ỵ', 'Ỷ', 'Ỹ' };

        for (int i = 0; i < chars.Length; i++)
        {
            for (int j = 0; j < uni[i].Length; j++)
            {
                strVietNamese = strVietNamese.Replace(uni[i][j], chars[i]);
            }
        }

        strVietNamese = XoaKiTuDacBiet(strVietNamese);
        return strVietNamese;
    }

    public static string ChuyenSoThanhChuoi(int number)
    {
        int ti = number / 1000000000;
        int soTrieu = number % 1000000000;
        int trieu = soTrieu / 1000000;
        int soNgan = soTrieu % 1000000;
        int ngan = soNgan / 1000;
        int soTram = soNgan % 1000;

        string strTi = string.Empty;
        string strTrieu = string.Empty;
        string strNgan = string.Empty;
        string strTram = string.Empty;

        if (ti != 0)
        {
            strTi = string.Format("{0} tỉ", TramToString(ti, false));
        }
        if (trieu != 0)
        {
            strTrieu = string.Format("{0} triệu", TramToString(trieu, ti != 0));
        }
        if (ngan != 0)
        {
            strNgan = string.Format("{0} ngàn", TramToString(ngan, ti != 0 || trieu != 0));
        }
        if (soTram != 0)
        {
            strTram = TramToString(soTram, ti != 0 || trieu != 0 || ngan != 0);
        }

        string strTien = string.Empty;

        if (!string.IsNullOrEmpty(strTi))
        {
            strTien = strTi;
        }
        if (!string.IsNullOrEmpty(strTrieu))
        {
            if (!string.IsNullOrEmpty(strTien))
            {
                strTien = string.Format("{0} {1}", strTien, strTrieu);
            }
            else
                strTien = strTrieu;
        }
        if (!string.IsNullOrEmpty(strNgan))
        {
            if (!string.IsNullOrEmpty(strTien))
                strTien = string.Format("{0} {1}", strTien, strNgan);
            else
                strTien = strNgan;
        }
        if (!string.IsNullOrEmpty(strTram))
        {
            if (!string.IsNullOrEmpty(strTram))
            {
                strTien = string.Format("{0} {1}", strTien, strTram);
            }
            else
                strTien = strTram;
        }
        return strTien;
    }

    private static string TramToString(int number, bool hasHeader)
    {
        int hangtram = number / 100;
        int duchuc = number % 100;
        int hangchuc = duchuc / 10;
        int hangdonvi = duchuc % 10;
        string tram = string.Empty;
        string chuc = string.Empty;
        if (hangtram != 0)
        {
            tram = string.Format("{0} trăm", mapNumberToString(hangtram));
            if (hangchuc != 0)
                tram = string.Format("{0} {1}", tram, ChucToString(duchuc));
            else
            {
                if (hangdonvi != 0)
                {
                    tram = string.Format("{0} lẻ {1}", tram, mapNumberToString(hangdonvi));
                }
            }
            return tram;
        }
        else if (hangchuc != 0)
        {
            return (hasHeader ? "không trăm " : "") + ChucToString(duchuc);
        }
        else if (hangdonvi != 0)
        {
            return (hasHeader ? "không trăm lẻ " : "") + mapNumberToString(hangdonvi);
        }
        return string.Empty;
    }

    private static string ChucToString(int number)
    {
        int hangchuc = number / 10;
        int hangdonvi = number % 10;
        string chuc = string.Empty;
        if (hangchuc == 1)
        {
            chuc = "mười";
            if (hangdonvi != 0 && hangdonvi != 5)
                chuc = string.Format("{0} {1}", chuc, mapNumberToString(hangdonvi));
            else if (hangdonvi == 5)
                chuc = string.Format("{0} lăm", chuc);
        }
        else
        {
            chuc = string.Format("{0} mươi", mapNumberToString(hangchuc));
            if (hangdonvi != 0)
            {
                if (hangdonvi == 1)
                    chuc = string.Format("{0} mốt", chuc);
                else if (hangdonvi == 5)
                    chuc = string.Format("{0} lăm", chuc);
                else
                    chuc = string.Format("{0} {1}", chuc, mapNumberToString(hangdonvi));
            }

        }
        return chuc;
    }

    private static string mapNumberToString(int number)
    {
        if (number == 1) return "một";
        if (number == 2) return "hai";
        if (number == 3) return "ba";
        if (number == 4) return "bốn";
        if (number == 5) return "năm";
        if (number == 6) return "sáu";
        if (number == 7) return "bảy";
        if (number == 8) return "tám";
        if (number == 9) return "chín";
        return "không";
    }

    public static string TransformXml(string inputXML, string styleSheetXml)
    {
        XslCompiledTransform proc = new XslCompiledTransform();

        using (StringReader sr = new StringReader(styleSheetXml))
        {
            using (XmlReader xr = XmlReader.Create(sr))
            {
                proc.Load(xr);
            }
        }

        string resultXML;

        using (StringReader sr = new StringReader(inputXML))
        {
            using (XmlReader xr = XmlReader.Create(sr))
            {
                using (StringWriter sw = new StringWriter())
                {

                    XsltArgumentList xslArg = new XsltArgumentList();
                    xslArg.AddExtensionObject("urn:xpath2", new XPath2());

                    proc.Transform(xr, xslArg, sw);
                    resultXML = sw.ToString();
                }
            }
        }

        return resultXML;
    }

    public static string TransformXml(string inputXML, string kyHoaDon, string styleSheetXml)
    {
        XslCompiledTransform proc = new XslCompiledTransform();

        using (StringReader sr = new StringReader(styleSheetXml))
        {
            using (XmlReader xr = XmlReader.Create(sr))
            {
                proc.Load(xr);
            }
        }

        string resultXML;

        using (StringReader sr = new StringReader(inputXML))
        {
            using (XmlReader xr = XmlReader.Create(sr))
            {
                using (StringWriter sw = new StringWriter())
                {

                    XsltArgumentList xslArg = new XsltArgumentList();
                    xslArg.AddExtensionObject("urn:xpath2", new XPath2(kyHoaDon));

                    proc.Transform(xr, xslArg, sw);
                    resultXML = sw.ToString();
                }
            }
        }

        return resultXML;
    }

    public static string Encrypt(string clearText)
    {
        string EncryptionKey = "vnptdaklak";
        byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                clearText = Convert.ToBase64String(ms.ToArray());
            }
        }
        return clearText;
    }

    public static string Decrypt(string cipherText)
    {
        string EncryptionKey = "vnptdaklak";
        cipherText = cipherText.Replace(" ", "+");
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;
    }
}

public class XPath2
{
    string kyHD;
    public XPath2()
    {
    }
    public XPath2(string kyHD)
    {
        this.kyHD = kyHD;
    }
    public int compare(String comparand1, String comparand2)
    {
        return comparand1.CompareTo(comparand2);
    }
    public String replace(String input, String pattern, String replacement)
    {
        return Regex.Replace(input, pattern, replacement);
    }
    public string encrypt(string input)
    {
        return Utility.Encrypt(input);
    }
    public string layKyHoaDon()
    {
        return kyHD;
    }
}
