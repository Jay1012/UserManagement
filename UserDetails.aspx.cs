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
    public partial class UserDetails : System.Web.UI.Page
    {
        RegFormEAL regObjEAL = new RegFormEAL();
        RegFormDAL regObjDAL = new RegFormDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = regObjDAL.getAllUsers();
            grdUsers.DataSource = ds;
            grdUsers.DataBind();
        }

        

        protected void grdUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(grdUsers.SelectedDataKey.Value);
            Response.Redirect("RegistrationForm.aspx?UserID="+id);
        }

       

        protected void grdUsers_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {

            int i = Convert.ToInt32(grdUsers.DataKeys[e.RowIndex].Value);
            regObjEAL.UserID = i;
            regObjDAL.DeleteUser(regObjEAL);
            Response.Redirect("RegistrationForm.aspx");
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrationForm.aspx");
        }

       

       
    }
}