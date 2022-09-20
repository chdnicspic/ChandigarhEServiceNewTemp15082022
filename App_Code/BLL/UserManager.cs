using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Web.Security;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;

/// <summary>
/// Summary description for UserManager
/// </summary>
public class UserManager
{
    public UserManager()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static string CreateSalt(int size)
    {
        //Generate a cryptographic random number.
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        byte[] buff = new byte[size];
        rng.GetBytes(buff);
        // Return a Base64 string representation of the random number.
        return Convert.ToBase64String(buff);
    }

    public static string GetMd5Hash(MD5 md5Hash, string input)
    {
        byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        StringBuilder sBuilder = new StringBuilder();
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }
        return sBuilder.ToString();
    }

    public static string GenerateString(int length, string allowedChars)
    {
        if (length < 0)
            throw new ArgumentOutOfRangeException("length", "length cannot be less than zero.");
        if (string.IsNullOrWhiteSpace(allowedChars))
            throw new ArgumentException("allowedChars may not be empty.");
        const int byteSize = 256;
        var allowedCharSet = new HashSet<char>(allowedChars).ToArray();
        if (byteSize < allowedCharSet.Length)
            throw new ArgumentException(String.Format("allowedChars may contain no more than {0} characters.", byteSize));
        using (var rng = new RNGCryptoServiceProvider())
        {
            var result = new StringBuilder();
            var buf = new byte[128];
            while (result.Length < length)
            {
                rng.GetBytes(buf);
                for (var i = 0; i < buf.Length && result.Length < length; ++i)
                {
                    var outOfRangeStart = byteSize - (byteSize % allowedCharSet.Length);
                    if (outOfRangeStart <= buf[i])
                        continue;
                    result.Append(allowedCharSet[buf[i] % allowedCharSet.Length]);
                }
            }
            return result.ToString();
        }
    }

    public string getMD(string plaintext)
    {
        MD5 md5Hash = MD5.Create();
        return GetMd5Hash(md5Hash, plaintext);
    }
}