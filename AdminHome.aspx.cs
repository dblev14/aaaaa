using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminHome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        
        if (Session["loggedIn"] == null)
            Response.Redirect("LoginPage.aspx");

        if (Session["loggedIn"].ToString() != "True")
            Response.Redirect("LoginPage.aspx");

        if ((int)Session["AdminFlag"] == 0)
        {

            Response.Redirect("RewardFeed.aspx");
        }


    }


    protected void btnViewEmployees_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditEmployeeList.aspx");
    }

    protected void btnEditDeleteEmployees_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditEmployeeList.aspx");
    }

    protected void btnCreateAccount_Click(object sender, EventArgs e)
    {
        Response.Redirect("CreateAccount.aspx");
    }

    protected void btnGenerateReports_Click(object sender, EventArgs e)
    {
        Response.Redirect("GenerateReports.aspx");

    }
}