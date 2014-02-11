using NAWEB.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NAWEB
{
    public partial class DocumentCard : System.Web.UI.Page
    {
        NAVEBData dataSet = new NAVEBData();

        protected void Page_Load(object sender, EventArgs e)
        {
            NAVEBData.OrderHeaderRow row = dataSet.OrderHeader.NewOrderHeaderRow();

            row.DocType = 1;
            row.DocNo = "1";
            row.CustNo = "100001";
            row.DocDate = DateTime.Today;
            row.DueDate = DateTime.Today.AddDays(30);
            dataSet.OrderHeader.AddOrderHeaderRow(row);

            row = dataSet.OrderHeader.NewOrderHeaderRow();
            row.DocType = 1;
            row.DocNo = "2";
            row.CustNo = "100001";
            row.DocDate = DateTime.Today;
            row.DueDate = DateTime.Today.AddDays(30);
            dataSet.OrderHeader.AddOrderHeaderRow(row);
            dataSet.AcceptChanges();

            OrderHeaderView.DataSource = dataSet.OrderHeader;
            OrderHeaderView.DataBind();

            NAVEBData.OrderLineRow line = dataSet.OrderLine.NewOrderLineRow();
            line.DocType = 1;
            line.DocNo = "1";
            line.LineNo = 1;
            line.Type = 1;
            line.No = "1001";
            line.Description = "Test Item 1001";
            line.Quantity = 2;
            dataSet.OrderLine.AddOrderLineRow(line);

            line = dataSet.OrderLine.NewOrderLineRow();
            line.DocType = 1;
            line.DocNo = "1";
            line.LineNo = 2;
            line.Type = 1;
            line.No = "1004";
            line.Description = "Test Item 1004";
            line.Quantity = 8;
            dataSet.OrderLine.AddOrderLineRow(line);

            line = dataSet.OrderLine.NewOrderLineRow();
            line.DocType = 1;
            line.DocNo = "1";
            line.LineNo = 3;
            line.Type = 1;
            line.No = "1005";
            line.Description = "Test Item 1005";
            line.Quantity = 5;
            dataSet.OrderLine.AddOrderLineRow(line);

            line = dataSet.OrderLine.NewOrderLineRow();
            line.DocType = 1;
            line.DocNo = "2";
            line.LineNo = 1;
            line.Type = 1;
            line.No = "2001";
            line.Description = "Test Item 2001";
            line.Quantity = 4;
            dataSet.OrderLine.AddOrderLineRow(line);

            OrderLineView.DataSource = dataSet.OrderLine;
            OrderLineView.DataBind();
            //OrderHeaderView.ChangeMode(FormViewMode.Insert);
        }
    }
}