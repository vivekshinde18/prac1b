<%@ Page Title="Home Page" Language="C#"  AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pract1b" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title></title>
</head>
<body>
<form id="form1" runat="server"><div>
<asp:Label ID="label1" runat="server">Enter First String</asp:Label>
<asp:TextBox ID="textBox1" runat="server" ></asp:TextBox>
<br /><br />
<asp:Label ID="label2" runat="server">Enter Second String</asp:Label>
<asp:TextBox ID="textBox2" runat="server"></asp:TextBox>
<br /><br />
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"
onselectedindexchanged="DropDownList1_SelectedIndexChanged">
<asp:ListItem >Concate</asp:ListItem>
<asp:ListItem>UpperCase</asp:ListItem>
<asp:ListItem>LowerCase</asp:ListItem>
<asp:ListItem>Reverse</asp:ListItem>
<asp:ListItem>Length</asp:ListItem>
<asp:ListItem>IsEmpty</asp:ListItem>
</asp:DropDownList>
<br /><br />
<asp:Button ID="Submit" runat="server" Text="Submit" onclick="Submit_Click"
style="height: 26px" />
<br /><br />
<asp:Label ID="result" runat="server"></asp:Label>
</div>
</form>
</body>
</html>