<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookie colloectio.aspx.cs" Inherits="cookie_collection.cookie_colloectio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
			<asp:Label ID="Label1" runat="server" Text="select the brand"></asp:Label><br />
			
             <asp:checkbox ID="iphone" runat="server" Text="iphone"></asp:checkbox><br />
			
			<asp:checkbox ID="real" runat="server" Text="real me"></asp:checkbox><br />
			<asp:checkbox ID="Vivo" runat="server" Text="vivo"></asp:checkbox><br />
			
			<asp:Button ID="Button1" runat="server" Text="check on" />
      
		<p>
		<asp:Label ID="Label2" runat="server" />
			</p>
			  </div>
    </form>
	
	
</body>
</html>
