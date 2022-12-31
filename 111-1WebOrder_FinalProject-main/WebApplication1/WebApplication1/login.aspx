<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.WebForm1" %>

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
            <br />
            登入狀態:&nbsp;&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            <br />
            歡迎光臨請先登錄<br />
            若無帳號請先註冊或使用訪客模式登入</div>
        </div>
        <div style="text-align:center;">

            
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            
            <div style="width:300px; text-align:center;position:relative;top:50%;left:50%;transform:translate(-50%,-50%); ">
            <div style="border: 3px solid rgb(0, 0, 0);background-color:bisque;border-radius:6px; height: 242px;">

            登入&amp;註冊<br />
            <br />
            帳號:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            密碼:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登入" Width="199px" />
            <br />
                <br />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-left: 0px" Text="註冊" Width="196px" />
            <br />
                <br />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="訪客模式" Width="187px" />
            </div><br />
                </div><br />
                </div>
            <br />
            

        
        
    </form>
</body>
</html>
