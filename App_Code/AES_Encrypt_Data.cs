                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     ﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Security.Cryptography;

/// <summary>
/// Summary description for AES_Encrypt_Data
/// </summary>
public class AES_Encrypt_Data
{
    private const string AesIVName = "ThisIsASecretKey";
    public static string Encrypt_Name(string Name)
    {
        string Result = "";
        byte[] inputArray = UTF8Encoding.UTF8.GetBytes(Name);
        AesCryptoServiceProvider AES = new AesCryptoServiceProvider();
        AES.Key = UTF8Encoding.UTF8.GetBytes(AesIVName);
        AES.Mode = CipherMode.ECB;
        AES.Padding = PaddingMode.PKCS7;
        ICryptoTransform cTransform = AES.CreateEncryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
        AES.Clear();

        Result = Convert.ToBase64String(resultArray, 0, resultArray.Length);
        return Result;
    }

    private const string DAesIVName = "ThisIsASecretKey";


    public static string Decrypt(string input)
    {
        string Result = "";
        byte[] inputArray = Convert.FromBase64String(input);
        AesCryptoServiceProvider Aes = new AesCryptoServiceProvider();
        Aes.Key = UTF8Encoding.UTF8.GetBytes(DAesIVName);
        Aes.Mode = CipherMode.ECB;
        Aes.Padding = PaddingMode.PKCS7;
        ICryptoTransform cTransform = Aes.CreateDecryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
        Aes.Clear();
        Result = UTF8Encoding.UTF8.GetString(resultArray);
        return Result;
    }
}