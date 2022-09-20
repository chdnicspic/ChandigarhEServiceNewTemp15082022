using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using EDistrictBL;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for EDistrictFileSystem
/// </summary>
public class EDistrictFileSystem
{
	public EDistrictFileSystem()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public string createDirectory(string ServiceCode,ref string FileName,string Applicationno,string FileType,FileUpload flvUpload)
    {
        string strStatus = "";
        try
        {
            string DirectoryName;
            string SubDirectoryname;
            string SubDirNameForFile;
            string NewappNo = Applicationno.Replace('/', '_');


            if (DateTime.Now.Month < 10)
            {

                DirectoryName = HttpContext.Current. Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year);
                SubDirectoryname = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString());
                SubDirNameForFile = "~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString();
            }
            else
            {
                DirectoryName = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year);
                SubDirectoryname = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString());
                SubDirNameForFile = "~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString();
            }



            if (!Directory.Exists(DirectoryName))
            {
                Directory.CreateDirectory(DirectoryName);
            }
            if (!Directory.Exists(SubDirectoryname))
            {
                Directory.CreateDirectory(SubDirectoryname);
            }

            Guid strGuid = Guid.NewGuid();
            FileName = HttpContext.Current.Server.MapPath(SubDirNameForFile + "/" + NewappNo + "_" + FileType + "_" + strGuid.ToString() + ".pdf");
            flvUpload.SaveAs(FileName);
            strStatus = "OK";
        }
        catch (Exception Ex)
        {
            MyExceptionHandler.HandleException(Ex);
            strStatus = "NOT OK";
            
        }
        return strStatus;
    }

    public string createDirectoryNoting(string ServiceCode, ref string FileName, string Applicationno, string FileType)
    {
        string strStatus = "";
        try
        {
            string DirectoryName;
            string SubDirectoryname;
            string SubDirNameForFile;
            string NewappNo = Applicationno.Replace('/', '_');


            if (DateTime.Now.Month < 10)
            {

                DirectoryName = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year);
                SubDirectoryname = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString());
                SubDirNameForFile = "~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString();
            }
            else
            {
                DirectoryName = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year);
                SubDirectoryname = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString());
                SubDirNameForFile = "~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString();
            }



            if (!Directory.Exists(DirectoryName))
            {
                Directory.CreateDirectory(DirectoryName);
            }
            if (!Directory.Exists(SubDirectoryname))
            {
                Directory.CreateDirectory(SubDirectoryname);
            }

            Guid strGuid = Guid.NewGuid();
            FileName = HttpContext.Current.Server.MapPath(SubDirNameForFile + "/" + NewappNo + "_" + FileType + "_" + strGuid.ToString() + ".pdf");
            
            strStatus = "OK";
        }
        catch (Exception Ex)
        {
            MyExceptionHandler.HandleException(Ex);
            strStatus = "NOT OK";

        }
        return strStatus;
    }

    public string createDirectoryNoting(string ServiceCode, ref string FileName, string Applicationno, string FileType,int Currentlevel,int MaxLevel)
    {
        string strStatus = "";
        try
        {
            string DirectoryName;
            string SubDirectoryname;
            string SubDirNameForFile;
            string NewappNo = Applicationno.Replace('/', '_');


            if (DateTime.Now.Month < 10)
            {

                DirectoryName = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year);
                SubDirectoryname = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString());
                SubDirNameForFile = "~/Administration/Documents/" + DateTime.Now.Day + "0" + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString();
            }
            else
            {
                DirectoryName = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year);
                SubDirectoryname = HttpContext.Current.Server.MapPath("~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString());
                SubDirNameForFile = "~/Administration/Documents/" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + "/" + ServiceCode.ToString();
            }



            if (!Directory.Exists(DirectoryName))
            {
                Directory.CreateDirectory(DirectoryName);
            }
            if (!Directory.Exists(SubDirectoryname))
            {
                Directory.CreateDirectory(SubDirectoryname);
            }

            Guid strGuid = Guid.NewGuid();
            FileName = HttpContext.Current.Server.MapPath(SubDirNameForFile + "/" + NewappNo + "_" + FileType + "_" + strGuid.ToString() + ".pdf");

            strStatus = "OK";
        }
        catch (Exception Ex)
        {
            MyExceptionHandler.HandleException(Ex);
            strStatus = "NOT OK";

        }
        return strStatus;
    }
    

}