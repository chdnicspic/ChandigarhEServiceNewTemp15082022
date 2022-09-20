using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for VerifyCertificate
/// </summary>
public class VerifyCertificateData
{
	public VerifyCertificateData()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string ApplicationNo { get; set; }
    public string CertificateNo { get; set; }
    public string PdfData { get; set; }
    public string SignatoryData { get; set; }

    public string DocumentSignedBy { get; set; }
    public string OrganizationSignedBy { get; set; }
    public string DepartmentSignedBy { get; set; }
    public string CountrySignedBy { get; set; }
    public string DocumentSignedDate { get; set; }

}