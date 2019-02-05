using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace storedProcedure
{
    public partial class sample : System.Web.UI.Page
    {
        storedProcedure.DataAccessLayer.Class1 dal = new storedProcedure.DataAccessLayer.Class1();



        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack) {
                btnDelete.Enabled = false;
            }
          
        }


       protected void Clear(object sender, EventArgs e)
        {
            hfContactID.Value = "";
            txtName.Text = txtAge.Text = txtCountry.Text = txtId.Text = "";
            lblSuccessMssg.Text = lblDeleteMssg.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = true;
           
        }
      

        protected void Save(object sender, EventArgs e)
        {
            dal.saveData(txtId.Text,txtName.Text,txtAge.Text,txtCountry.Text);
            lblSuccessMssg.Text="data entered successfully";
        }

        protected void Delete(object sender, EventArgs e)
        {
            dal.DeleteData(txtId.Text);
            lblDeleteMssg.Text="data deleted successfully";


        }

      protected void Update(object sender, EventArgs e)
        {
            dal.UpdateData(txtId.Text, txtName.Text, txtAge.Text, txtCountry.Text);
            lblUpdateMssg.Text = "data updated successfully";

        }
    }
   
}