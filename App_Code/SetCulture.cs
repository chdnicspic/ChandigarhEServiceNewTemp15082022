using System;
using System.Globalization;
using System.Threading;
using System.IO;
using System.IO.Compression;
public delegate void CultureChanged(object Sender, string CurrentCulture);

public class SetCulture : System.Web.UI.Page
{
    public event CultureChanged OnCultureChanged;

    public string LastCultureName
    {
        get
        {
            //string strlastCultureName = Session["MyLanguage"].ToString();
            string strlastCultureName = "en-GB";
            if (strlastCultureName == null)
                Session["MyLanguage"] = Thread.CurrentThread.CurrentCulture.Name;
            return strlastCultureName;
        }

        set
        {
            Session["MyLanguage"] = value;
        }
    }

    protected override void InitializeCulture()
    {
        // TODO: make this prettier
        string lang;
        lang = "en-GB";
        //lang = Session["MyLanguage"].ToString();
        // Session["MyLanguage"]= lang;
        // Session["MyLanguage"] = "en-US"

        if (Session["MyLanguage"] == null)
        {
            lang = LastCultureName;
            lang = "en-GB";
        }
        else
            lang = Session["MyLanguage"].ToString();

        Thread.CurrentThread.CurrentCulture = new CultureInfo(lang);
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(lang);
    }

    protected override void OnLoadComplete(EventArgs e)
    {
        base.OnLoadComplete(e);
        if ((LastCultureName != Thread.CurrentThread.CurrentCulture.Name))
        {
            LastCultureName = Thread.CurrentThread.CurrentCulture.Name;
            OnCultureChanged?.Invoke(this, LastCultureName);
        }

    }

    public static byte[] Compress(byte[] data)
    {
        MemoryStream output = new MemoryStream();
        GZipStream gzip = new GZipStream(output, CompressionMode.Compress, true);
        gzip.Write(data, 0, data.Length);
        gzip.Close();
        return output.ToArray();
    }


    public static byte[] Decompress(byte[] data)
    {
        MemoryStream input = new MemoryStream();
        input.Write(data, 0, data.Length);
        input.Position = 0;
        GZipStream gzip = new GZipStream(input, CompressionMode.Decompress, true);
        MemoryStream output = new MemoryStream();
        byte[] buff = new byte[] {
                63};
        int read = -1;
        read = gzip.Read(buff, 0, buff.Length);
        while ((read > 0))
        {
            output.Write(buff, 0, read);
            read = gzip.Read(buff, 0, buff.Length);
        }

        gzip.Close();
        return output.ToArray();
    }
}