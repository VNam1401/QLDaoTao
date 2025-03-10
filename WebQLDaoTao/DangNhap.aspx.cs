using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao.Models;

namespace WebQLDaoTao
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangNhap_Click(object sender, EventArgs e)
        {
            

        }

        protected void btDangNhap_Click(object sender, EventArgs e)
        {
            string tendangnhap = txtUsername.Text;
            string matKhau = txtPassword.Text;

            TaiKhoanDAO tkDAO = new TaiKhoanDAO();
            TaiKhoan tk = tkDAO.KiemTra(tendangnhap, matKhau);

            if (tk != null)
            {
                Session["TaiKhoan"] = tk;
                Session["TenDN"] = tk.TenDangNhap;
                Session["VaiTro"] = tk.VaiTro.Trim();
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblThongBao.Text = "Đăng nhập thất bại do sai tên mật khẩu";
            }
        }
    }
}