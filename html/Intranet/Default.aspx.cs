using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Intranet_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string Usuario = Login1.UserName;
        string Password = Login1.Password;
        if (Usuario == "UAC" && Password == "SW")
        {
            //FormsAuthentication.RedirectFromLoginPage(Usuario, false);
            Response.Redirect("Default.aspx");
        }
        else
            Login1.FailureText = "Usuario y/o Contrasenas incorrectas";

        //Encryptar ASP.Net con MD5
        Usuario = FormsAuthentication.HashPasswordForStoringInConfigFile(Usuario, "SHA1");
        Response.Write(Usuario);
    }
}