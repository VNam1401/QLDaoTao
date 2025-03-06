using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQLDaoTao
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserName"] != null && !string.IsNullOrEmpty(Session["UserName"].ToString()))
                {
                    liDangNhap.Visible = false;
                    liTenDN.Visible = true;
                    liDangXuat.Visible = true;
                    lbTen.Text = Session["UserName"].ToString();
                }
                else
                {
                    liDangNhap.Visible = true;
                    liTenDN.Visible = false;
                    liDangXuat.Visible = false;
                    lbTen.Text = "";
                }
            }
        }
    }
}