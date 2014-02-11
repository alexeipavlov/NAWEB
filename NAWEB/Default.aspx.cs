using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using NAWEB.ServiceRef;
using NAWEB.App_Code;

namespace NAWEB
{
    public partial class _Default : Page
    {
        NAVEBData dataSet = new NAVEBData();

        protected void Page_Load(object sender, EventArgs e)
        {
            GetCustomers("", "");

            //GridView1.PagerSettings.Mode = PagerButtons.NextPreviousFirstLast;
            //GridView1.PageSize = 10;
            //GridView1.PageIndex = 1;

            GridView1.DataSource = dataSet.Customer;
            GridView1.DataBind();
        }

        private void GetCustomers(string noFilter, string nameFilter)
        {
            string baseURL = "http://MAIN:7047/ElmeMesser71/WS/ElmeMesserL/Codeunit/NAWEBMgt";
            // Create a NAV compatible binding
            BasicHttpBinding navWSBinding = new BasicHttpBinding();
            navWSBinding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            navWSBinding.MaxReceivedMessageSize = Int32.MaxValue;
            navWSBinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Windows;

            // Create the Customer Page Service Client

            NAWEBMgt_PortClient customerService = new NAWEBMgt_PortClient(navWSBinding, new EndpointAddress(baseURL));
            //customerService.ClientCredentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Delegation;
            //customerService.ClientCredentials.Windows.AllowNtlm = true;

            customerService.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential("alexei", "#ZWXwh123");

            NAWEB.ServiceRef.Customers customers = new NAWEB.ServiceRef.Customers();

            int totalRows = 0;
            bool res = customerService.GetCustomers(1, 50, noFilter, nameFilter, ref customers, ref totalRows);
            dataSet.Customer.Clear();

            foreach (Customer c in customers.Customer)
            {
                var row = dataSet.Customer.NewCustomerRow();
                row.No = c.No;
                row.Name = c.Name;
                row.Name2 = c.Name_2;
                row.Address = c.Address;
                row.Address2 = c.Address_2;
                row.CreditLimitLCY = Convert.ToDecimal(c.CreditLimitLCY);
                dataSet.Customer.AddCustomerRow(row);
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            //GridView1.DataSource = dataSet.Customer;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridView1.SelectedIndex = e.NewSelectedIndex;
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        protected void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            GetCustomers("", FilterTextBox.Text);

            GridView1.SelectedIndex = -1;
            GridView1.PageIndex = 0;
            GridView1.DataSource = dataSet.Customer;
            GridView1.DataBind();
        }
    }
}