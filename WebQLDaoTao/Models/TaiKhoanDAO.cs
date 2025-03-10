using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebQLDaoTao.Models
{
    public class TaiKhoanDAO
    {
        public TaiKhoan KiemTra(string username, string passwork)
        {
            TaiKhoan tk = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE tendangnhap = @TenDangNhap AND matkhau = @MatKhau", conn);
            cmd.Parameters.AddWithValue("@TenDangNhap", username);
            cmd.Parameters.AddWithValue("@MatKhau", passwork);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tk = new TaiKhoan
                {
                    TenDangNhap = dr["TenDangNhap"].ToString(),
                    MatKhau = dr["MatKhau"].ToString(),
                    VaiTro = dr["VaiTro"].ToString()
                };
            }
            dr.Close();
            return tk;
        }
        public TaiKhoan FindById(string tenDN)
        {
            TaiKhoan tk = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap", conn);
            cmd.Parameters.AddWithValue("@TenDangNhap", tenDN);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tk = new TaiKhoan
                {
                    TenDangNhap = dr["TenDangNhap"].ToString(),
                    MatKhau = dr["MatKhau"].ToString(),
                    VaiTro = dr["VaiTro"].ToString()
                };
            }
            dr.Close();
            conn.Close();

            return tk;
        }
        public TaiKhoan FindByUserName(string username)
        {
            TaiKhoan kq = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap", conn);
            cmd.Parameters.AddWithValue("@TenDangNhap", username);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                kq = new TaiKhoan
                {
                    TenDangNhap = dr["TenDangNhap"].ToString(),
                    MatKhau = dr["MatKhau"].ToString(),
                    VaiTro = dr["VaiTro"].ToString()
                };
            }
            return kq;
        }
    }
}