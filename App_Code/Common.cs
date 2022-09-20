using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Common
/// </summary>
public static class Common
{
    public static string ShowMessage(string Message, int msgType)
    {
        string Msg = string.Empty;
        if (msgType == 1)
            Msg = "<Div class='alert alert-success mt-3' style='border-radius: 35px;'><a href='#' data-dismiss='alert' class='close'>&times;</a>" + Message + " </Div>";
        else if (msgType == 2)
            Msg = "<Div class='alert alert-danger mt-3' style='border-radius: 35px;'><a href='#' data-dismiss='alert' class='close'>&times;</a>" + Message + " </Div>";
        else if (msgType == 3)
            Msg = "<Div class='alert alert-info mt-3' style='border-radius: 35px;'><a href='#' data-dismiss='alert' class='close'>&times;</a>" + Message + " </Div>";
        return Msg;

    }
}