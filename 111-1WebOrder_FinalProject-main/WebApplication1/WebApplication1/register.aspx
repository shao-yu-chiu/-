<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication1.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="display:flex;">
        <div style="flex:1;text-align:center;color:blueviolet">
            登入狀態:&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text=" "></asp:Label></div>
        </div>
        <div style="text-align:center;">

            
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            
            <div style="width:300px; text-align:center;position:relative;top:-2147483648%; left:50%; transform:translate(-50%,-50%); height: 238px;">
            <div style=" border: 3px solid rgb(0, 0, 0);background-color:bisque;border-radius:6px;">

                註冊<br />
            <br />
            帳號:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            密碼:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
                <br />
                名稱:&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="註冊" Width="199px" />
                <br />
            <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click1" Text="返回登入畫面" Width="192px" />
                <br />
            <br />
            </div><br />
                </div><br />
                </div>
            <br />
            

        
        
    </form>
</body>
</html>

