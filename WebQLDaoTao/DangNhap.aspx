﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="WebQLDaoTao.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập - Hệ Thống Quản Lý Đào Tạo</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <!-- Bootstrap CSS -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome for icons -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet" />
    <style>
        body {
            background-color: #f8f9fa;
            height: 100vh;
            display: flex;
            align-items: center;
            justify-content: center;
        }
        .login-container {
            background-color: white;
            border-radius: 10px;
            box-shadow: 0 0 20px rgba(0, 0, 0, 0.1);
            padding: 40px;
            width: 100%;
            max-width: 400px;
        }
        .login-header {
            text-align: center;
            margin-bottom: 30px;
        }
        .login-header h1 {
            font-size: 26px;
            color: #3b71ca;
            margin-bottom: 15px;
        }
        .login-icon {
            font-size: 50px;
            color: #3b71ca;
            margin-bottom: 15px;
        }
        .form-group {
            margin-bottom: 20px;
        }
        .form-label {
            font-weight: 500;
            color: #4a4a4a;
        }
        .input-group {
            position: relative;
        }
        .input-group-text {
            background-color: #f8f9fa;
            border-right: none;
        }
        .form-control {
            border-left: none;
        }
        .btn-login {
            background-color: #3b71ca;
            color: white;
            font-weight: 500;
            padding: 10px 20px;
            border-radius: 5px;
            width: 100%;
            margin-top: 10px;
            transition: all 0.3s;
        }
        .btn-login:hover {
            background-color: #2a5298;
        }
        .text-danger {
            margin-top: 15px;
            text-align: center;
            display: block;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div class="login-container">
            <div class="login-header">
                <i class="fas fa-user-graduate login-icon"></i>
                <h1>Đăng Nhập Hệ Thống</h1>
                <p class="text-muted">Vui lòng đăng nhập để tiếp tục</p>
            </div>
            
            <div class="form-group">
                <label for="txtUsername" class="form-label">Tên đăng nhập</label>
                <div class="input-group">
                    <span class="input-group-text"><i class="fas fa-user"></i></span>
                    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Nhập tên đăng nhập"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group">
                <label for="txtPassword" class="form-label" placeholder="Enter password">Mật khẩu</label>
                <div class="input-group">
                    <span class="input-group-text"><i class="fas fa-lock"></i></span>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password" placeholder="Nhập mật khẩu"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-check mb-3">
                <input class="form-check-input" type="checkbox" value="" id="rememberMe" />
                <label class="form-check-label" for="rememberMe">
                    Nhớ đăng nhập
                </label>
            </div>
            
            <asp:Button ID="btnDangNhap" runat="server" Text="Đăng nhập" CssClass="btn btn-login" OnClick="btDangNhap_Click" />
            
            <asp:Label ID="lblThongBao" runat="server" Text="" CssClass="text-danger"></asp:Label>
        </div>
    </form>

    <!-- Bootstrap JS Bundle with Popper -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
</body>
</html>