<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="result.aspx.cs" Inherits="WebApplication1.result" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div></div>
                    <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        
        <div style="text-align:center;position:relative;top:20%;left:50%;transform:translate(-50%,-50%);width:400px;">
            <div style="border:3px solid black;">

                <br />
                <br />
                本次消費清單<br />
                <br />

<asp:TextBox ID="TextBox1" runat="server" Height="254px" TextMode="MultiLine" Width="276px"></asp:TextBox>

                <br />
                <br />
                謝謝惠顧<br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="按此回到登入頁面" />
                <br />
                <br />

            </div>
            
            
        </div>
    </form>
</body>
</html>
