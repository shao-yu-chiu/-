<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication1.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="./IMG/homepage.jpg" style="background-repeat:repeat-x;background-attachment:fixed;background-position:center center">
    <form id="form1" runat="server">
        <div>

            <div>
            登入狀態:&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="登出"  BorderColor="Black" BackColor="#99FF66" BorderStyle="Outset" BorderWidth="3px" Font-Italic="True" Font-Names="Arial Black" Font-Size="13px" Height="24px" Width="48px" />

            </div>
            

            <br />
            <br />
            <div style="display:flex; text-align:center;">
            <div style="flex:1;"></div>
            </div><div><br /></div>
            <div style="background-color:#BACBD4;position:relative;left:50%;transform:translate(-50%); width:33%;border: 3px solid rgb(0, 0, 0); border-radius:6px; text-align:center;">
                <h2>菜單</h2>
            </div>
            
            
            <div style="display:flex;">
            <div style="flex:1;width:100%;height:100%;">
            <asp:GridView style="width:100%;height:100%;" ID="GridView1" runat="server" Width="204px" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" ForeColor="Black">
                <Columns>
                    <asp:BoundField DataField="names" HeaderText="names" SortExpression="names" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            </div>
            <div style="flex:1;width:100%;height:100%;"><asp:GridView style="width:100%;height:100%;" ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource2" ForeColor="Black">
                <Columns>
                    <asp:BoundField DataField="names" HeaderText="names" SortExpression="names" />
                    <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="Gray" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            </div>
            </div>
            <br />
            <div id="#geto" style="background-color:#BACBD4;position:relative;left:50%;transform:translate(-50%); width:33%;border: 3px solid rgb(0, 0, 0); border-radius:6px; text-align:center;">
                <h2>點餐</h2>
            </div>
            <div style="display:flex;">
            
            <div style="flex:1;border: 3px solid rgb(0, 0, 0);border-radius:6px; text-align:center;background-color:#BACBD4;">
                <div style="width:90%;height:90%;margin:auto;">
            <h5>食物</h5> &nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="names" DataValueField="names" Height="25px" Width="148px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp; <h6>數量:</h6>&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="新增" />
                    <br />
                    </div><br />
            </div>
            <div style="flex:1;border: 3px solid rgb(0, 0, 0);border-radius:6px; text-align:center;background-color:#BACBD4;">
                <div style="width:90%;height:90%;margin:auto;">
            <h5>飲料</h5>&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="names" DataValueField="names" Height="25px" Width="146px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp; <h6>數量:</h6>&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="新增" />
                    <br />
                </div><br />
            </div>

            
            <div style="flex:1;border: 3px solid rgb(0, 0, 0);border-radius:6px; text-align:center;background-color:#BACBD4;"><br />
                <div style="width:80%;height:80%;margin:auto;">
            <asp:RadioButton ID="RadioButton1" runat="server" Text="內用" GroupName="a" CausesValidation="True" OnCheckedChanged="RadioButton1_CheckedChanged" AutoPostBack="True" />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="外帶" GroupName="a" CausesValidation="True" OnCheckedChanged="RadioButton3_CheckedChanged" AutoPostBack="True" />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="外送" GroupName="a" CausesValidation="True" OnCheckedChanged="RadioButton2_CheckedChanged" AutoPostBack="True" />
                    <br />
                    餐點確認<br />
                    <asp:TextBox ID="TextBox3" runat="server" Height="182px" TextMode="MultiLine" Width="186px"></asp:TextBox>
                    <br />
                    <asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" Text="結帳" Width="103px" />
                    <asp:Button ID="Button5" runat="server" Height="42px" OnClick="Button5_Click" Text="重新選擇" Width="89px" />
                </div><br />
            </div></div>
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [names], [price] FROM [food]"></asp:SqlDataSource>
            <br />
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [names], [price] FROM [drink]"></asp:SqlDataSource>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
