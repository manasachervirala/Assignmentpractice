<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication11.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Label ID="label1" runat="server" Text="Username" />
			<asp:TextBox ID="TextBox1" runat="server" />
        </div>
		<p>
			<asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
		</p>
    </form>
	<asp:Label Id="userinput" runat="server" /> <br />
	<asp:HyperLink ID="HYPERLINK1" runat="server" Text="TechMasters" NavigateUrl="www.TechMasters.com" />
</body>
</html>
