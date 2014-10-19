using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using UserManagDAL;
using UserManagEAL;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
namespace UserManagement
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        RegFormEAL regObjEAL = new RegFormEAL();
        RegFormDAL regObjDAL = new RegFormDAL();
        Int32 UserId;
        protected void Page_Load(object sender, EventArgs e)
        {

            UserId = Convert.ToInt32(Request.QueryString["UserID"]);
            if (!IsPostBack)
            {
                if (UserId != 0)
                {
                //DataView dv = dstUser.Tables[0].DefaultView;
                //dv.RowFilter = "UserID = " + UserId;
                
                    regObjEAL.UserID = UserId;
                    DataSet dstUser = regObjDAL.getSingleUsers(regObjEAL);
                    txtfname.Text = dstUser.Tables[0].Rows[0]["FirstName"].ToString();
                    txtlname.Text = dstUser.Tables[0].Rows[0]["LastName"].ToString();
                    txtaddress.Text = dstUser.Tables[0].Rows[0]["Adress"].ToString();
                    txtemail.Text = dstUser.Tables[0].Rows[0]["EmailId"].ToString();
                    string s = dstUser.Tables[0].Rows[0]["Gender"].ToString();

                    ddlCountry.SelectedValue = dstUser.Tables[0].Rows[0]["CountryIDFK"].ToString();
                    ddlState.SelectedValue = dstUser.Tables[0].Rows[0]["StateIDFK"].ToString();
                    btnUpdate.Visible = true;
                    btnSave.Visible = false;

                    bindCountry();
                    bindState();
                     if (s == "M")
                    {
                        rblgndr.SelectedValue = "1";
                    }
                    else
                    {
                    rblgndr.SelectedValue = "2";
                    }
                 }
                else
                {
                    bindCountry();
                    bindState();
                }

            }
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

            regObjEAL.CountryID = Convert.ToInt32( ddlCountry.SelectedValue);
            DataSet ds = regObjDAL.getState(regObjEAL);
            ddlState.DataSource = ds;
            ddlState.DataTextField = ds.Tables[0].Columns[1].ToString();
            ddlState.DataValueField = ds.Tables[0].Columns[0].ToString();
            ddlState.DataBind();

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            regObjEAL.FirstName = txtfname.Text;
            regObjEAL.LastName = txtlname.Text;
            regObjEAL.EmailID = txtemail.Text;
            regObjEAL.Address = txtaddress.Text;

            if (rblgndr.SelectedValue == "1")
            {
                regObjEAL.Gender = "M";
            }
            else
            {
                regObjEAL.Gender = "F";
            }
            regObjEAL.CountryID = Convert.ToInt32(ddlCountry.SelectedValue);
            regObjEAL.StateID = Convert.ToInt32( ddlState.SelectedValue);

            regObjDAL.AddUsers(regObjEAL);
            clear();
            Response.Redirect("UserDetails.aspx");
        }
        public void clear()
        {
            txtaddress.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtemail.Text = "";
            ddlCountry.SelectedIndex = 0;
            ddlState.SelectedIndex = 0;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            regObjEAL.UserID = UserId;
            regObjEAL.FirstName = txtfname.Text;
            regObjEAL.LastName = txtlname.Text;
            regObjEAL.EmailID = txtemail.Text;
            regObjEAL.Address = txtaddress.Text;
            
            if (rblgndr.SelectedValue == "1")
            {
                regObjEAL.Gender = "M";
            }
            else
            {
                regObjEAL.Gender = "F";
            }
            regObjEAL.CountryID = Convert.ToInt32(ddlCountry.SelectedValue);
            regObjEAL.StateID = Convert.ToInt32(ddlState.SelectedValue);

            regObjDAL.UpdateUserDetail(regObjEAL);
            clear();
            Response.Redirect("UserDetails.aspx");

        }
        public void bindState()
        {
            regObjEAL.CountryID = Convert.ToInt32(ddlCountry.SelectedValue);
            DataSet ds1 = regObjDAL.getState(regObjEAL);
            ddlState.DataSource = ds1;
            ddlState.DataTextField = ds1.Tables[0].Columns[1].ToString();
            ddlState.DataValueField = ds1.Tables[0].Columns[0].ToString();
            ddlState.DataBind();
        }
        public void bindCountry()
        {
            DataSet ds = regObjDAL.getCountry();
            ddlCountry.DataSource = ds;
            ddlCountry.DataTextField = ds.Tables[0].Columns[1].ToString();
            ddlCountry.DataValueField = ds.Tables[0].Columns[0].ToString();
            ddlCountry.DataBind();

        }

        protected void btncncl_Click(object sender, EventArgs e)
        {
            clear();
        }
        
    }

}