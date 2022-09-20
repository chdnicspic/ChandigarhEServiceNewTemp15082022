using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Web;


namespace EDistrictBL
{
    public class validations
    {

        public const string ValidDecimal = "^-?[0-9]+(?:.[0-9]{1,2})?$";
        public  const string validName = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
        public const string validQualification = "123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+, ";
        public const string validlicenceno = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz/";
        public const string validTextwithoutSpace = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public const string validHouseNumber = "-1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz/. ";
        public const string validRemarks = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz. ";
        public const string validAddress = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz/. ";
        public const string validAddresswithHiphen = "-1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz/. ";
        public const string validAddresswithComma = "-1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz/,. ";
        public const string validCSVEventVanue = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz-,/ ";
        public const string validAlphaNumeric = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        public const string validCertificateNo = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz()/-";
        public const string licenceno = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz/";
        public const string validPhone = "1234567890";
        public const string validOnlyNumber = "1234567890";
        public const string validCurrency = "1234567890.";
        public const string validDate = "1234567890/";
        public const string validEmail = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz.@1234567890_";
        public const string validMobile = "1234567890";
        public const string validSystemLoginName = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890_";
        public const string validInformation = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz% ";
        public const string validstringwithcomma = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz, ";
        public const string validNumberwithicomma = "1234567890, ";
        public const string validAlphaNumericwithSpace = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ";
        public const string validDesignation = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz()- ";
        public const string REGEXDate = @"^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$";

        public  Boolean CheckValidCharacter(string lcno, string validstr)
        {
            string ValidString = validstr; ;

            Boolean retval = false;
            int len_lcno = lcno.Length;


            for (int xx = 0; xx < len_lcno; xx++)
            {
                string ochr = lcno.Substring(xx, 1).ToUpper();
                int pp = ValidString.IndexOf(ochr);

                if (pp == -1)
                {
                    retval = true;
                    break;
                }
            }

            return retval;
        }

        public Boolean IsPastDate(DateTime DateToCheck, DateTime ServerDate)
        {
            if (DateToCheck < ServerDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
	
	public Boolean IsPastDateIncludingToday(DateTime DateToCheck, DateTime ServerDate)
        {
            if (DateToCheck <= ServerDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        }
    }
