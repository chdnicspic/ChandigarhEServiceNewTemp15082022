using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using EDistrictBL;

/// <summary>
/// Summary description for Darpan
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Darpan : System.Web.Services.WebService
{

    public Darpan()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string RetDMDashCaption()
    {
        DataTable dt1;
        StringBuilder strb = new StringBuilder();
        DarpanServices objDarpanServices = new DarpanServices();
        strb.Append("<RetDMDashCaption> ");
        try
        {
            dt1 = objDarpanServices.DarpanDMDashCaption();
            //dt1 = new DataTable();
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    strb.Append("<DASH>");
                    strb.Append("<state_code>" + dt1.Rows[i]["State_Code"].ToString() + "</state_code>");
                    strb.Append("<District_code>" + dt1.Rows[i]["District_Code"].ToString() + "</District_code>");

                    strb.Append("<teh_code>" + dt1.Rows[i]["teh_code"].ToString() + "</teh_code>");
                    strb.Append("<blk_code>" + dt1.Rows[i]["blk_code"].ToString() + "</blk_code>");
                    strb.Append("<sector_code>" + dt1.Rows[i]["sector_code"].ToString() + "</sector_code>");
                    strb.Append("<dept_code>" + dt1.Rows[i]["dept_code"].ToString() + "</dept_code>");
                    strb.Append("<Project_code>" + dt1.Rows[i]["Project_Code"].ToString() + "</Project_code>");

                   strb.Append("<cnt1>" + dt1.Rows[i]["cnt1"].ToString() + "</cnt1>");
		                       strb.Append("<cnt2>" + dt1.Rows[i]["cnt2"].ToString() + "</cnt2>");
		                       strb.Append("<cnt3>" + dt1.Rows[i]["cnt3"].ToString() + "</cnt3>");
		                       strb.Append("<cnt4>" + dt1.Rows[i]["cnt4"].ToString() + "</cnt4>");
		                       strb.Append("<cnt5>" + dt1.Rows[i]["cnt5"].ToString() + "</cnt5>");
		   
		                       strb.Append("<dataportmode>" + dt1.Rows[i]["dataportmode"].ToString() + "</dataportmode>");
		                       strb.Append("<modedesc>" + dt1.Rows[i]["modedesc"].ToString() + "</modedesc>");
		   
		                       strb.Append("<data_lvl_code>" + dt1.Rows[i]["data_lvl_code"].ToString() + "</data_lvl_code>");
		                       strb.Append("<yr>" + dt1.Rows[i]["yr"].ToString() + "</yr>");
		                       strb.Append("<mnth>" + dt1.Rows[i]["mnth"].ToString() + "</mnth>");
		   
                    strb.Append("</DASH>");
                }
            }
            else
            {
                strb.Append("0"); // Data is not available on this date
            }
            strb.Append("</RetDMDashCaption>");
            return strb.ToString();

        }
        catch (Exception Ex)
        {
            MyExceptionHandler.HandleException(Ex);
        }
        finally
        {
            
        }

	return strb.ToString();
        
    }

    [WebMethod]
    public string RetDMDashCaptionstatic()
    {
        //DataTable dt1;
        StringBuilder strb = new StringBuilder();
        //DarpanServices objDarpanServices = new DarpanServices();
        strb.Append("<RetDMDashCaption> ");
        try
        {
            //dt1 = objDarpanServices.DarpanDMDashCaption();
            //dt1 = new DataTable();
            //if (dt1.Rows.Count > 0)
            //{
            //    for (int i = 0; i < dt1.Rows.Count; i++)
            //    {
                    strb.Append("<DASH>");
                    strb.Append("<state_code>4</state_code>");
                    strb.Append("<District_code>44</District_code>");

                    strb.Append("<teh_code>0</teh_code>");
                    strb.Append("<blk_code>0</blk_code>");
                    strb.Append("<sector_code>1</sector_code>");
                    strb.Append("<dept_code>48</dept_code>");
                    strb.Append("<Project_code>100289</Project_code>");

                    strb.Append("<cnt1>100</cnt1>");
                    strb.Append("<cnt2>200</cnt2>");
                    strb.Append("<cnt3>0</cnt3>");
                    strb.Append("<cnt4>0</cnt4>");
                    strb.Append("<cnt5>0</cnt5>");

                    strb.Append("<dataportmode>4</dataportmode>");
                    strb.Append("<modedesc>13</modedesc>");

                    strb.Append("<data_lvl_code>1</data_lvl_code>");
                    strb.Append("<yr>2018</yr>");
                    strb.Append("<mnth>03</mnth>");

                    strb.Append("</DASH>");
            //    }
            //}
            //else
            //{
            //    strb.Append("0"); // Data is not available on this date
            //}
            strb.Append("</RetDMDashCaption>");
            return strb.ToString();

        }
        catch (Exception Ex)
        {
            MyExceptionHandler.HandleException(Ex);
        }
        finally
        {

        }


        return "Hello World";
    }



}
