using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;


/// <summary>
/// Summary description for eDistrictAuthentication
/// </summary>
public class eDistrictAuthentication
{
	public eDistrictAuthentication()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public bool ValidateUser()
    {
        
        if (HttpContext.Current.Request.UrlReferrer == null)
        {
            HttpContext.Current.Session.Abandon();
            FormsAuthentication.SignOut();
            return false;
        }

        ////For xsrf Attack 
        HttpCookie ck = HttpContext.Current.Request.Cookies["Appcookie"];
        if (ck.Value.ToString() == HttpContext.Current.Session["Rnd1"].ToString())
        {
            HttpContext.Current.Response.Cookies.Remove("Appcookie");
            Random randomclass = new Random();
            string NewRandomNumber = randomclass.Next().ToString();
            HttpContext.Current.Session["Rnd1"] = NewRandomNumber;

            HttpCookie appcookie = new HttpCookie("Appcookie");
            appcookie.Value = NewRandomNumber;
            appcookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(appcookie);
            HttpContext.Current.Response.SetCookie(appcookie);


        }
        else
        {

            HttpContext.Current.Session.Abandon();
            FormsAuthentication.SignOut();
            return false;
        }


        
        
        if (HttpContext.Current.Session.Count > 0)
        {
            if (HttpContext.Current.Session["PortalSession"] == null)
            {
                HttpContext.Current.Session.Abandon();
                FormsAuthentication.SignOut();
                return false;
            }
        }
        else
        {
            HttpContext.Current.Session.Abandon();
            FormsAuthentication.SignOut();

            return false;
        }
        return true;

        
    }


}