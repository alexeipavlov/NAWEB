using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NAWEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void list1_Click(object sender, BulletedListEventArgs e)
        {
            var l = sender as BulletedList;
            var p = l.Parent as Panel;
            var t = p.Parent.FindControl("TextBox1") as TextBox;
            //TextBox1.Text = l.Items[e.Index].Value;
            t.Text = l.Items[e.Index].Value;
        }
    }
}