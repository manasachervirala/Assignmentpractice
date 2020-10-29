<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rapid.aspx.cs" Inherits="rapid.Rapid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style type="text/css">
		.auto-style2 {
			width: 352px;
		}
		.auto-style3 {
			width: 28px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    	<table style="width:100%;">
			<tr>
				<td class="auto-style3">Id</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style3">UserNAME</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox1" runat="server" BackColor="#FFFFCC" Width="344px"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style3">Email Address</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox2" runat="server" BackColor="#FFFFCC" TextMode="Email" Width="345px"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style3">Passsword</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox3" runat="server" BackColor="#FFFFCC" TextMode="Password" Width="349px">enter ur password</asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style3">Confirm PassWord</td>
				<td class="auto-style2">
					<asp:TextBox ID="TextBox4" runat="server" BackColor="#FFFFCC" TextMode="Password" Width="345px">confirm password</asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="auto-style3">Gender</td>
				<td class="auto-style2">
					<asp:RadioButton ID="RadioButton1" runat="server" GroupName="Gender"  Text="MALE" />
&nbsp;&nbsp;
					<asp:RadioButton ID="RadioButton2" runat="server" GroupName="Gender" Text="FEMALE" />
				</td>
			</tr>
			<tr>
				<td class="auto-style3">City</td>
				<td class="auto-style2">
					<asp:DropDownList ID="DropDownList1" runat="server" Width="142px">
						<asp:ListItem> please select</asp:ListItem>
						<asp:ListItem>HYD</asp:ListItem>
						<asp:ListItem>DELHI</asp:ListItem>
						<asp:ListItem>KOLKATA</asp:ListItem>
						<asp:ListItem>MUMBAI</asp:ListItem>
						<asp:ListItem>Bangalore</asp:ListItem>
						<asp:ListItem>chennai</asp:ListItem>
						<asp:ListItem>paries</asp:ListItem>
						<asp:ListItem>swizz</asp:ListItem>
						<asp:ListItem>melbourn</asp:ListItem>
					</asp:DropDownList>
				</td>
			</tr>
		</table>
		<asp:Button ID="Button1" runat="server" Height="43px" OnClick="Button1_Click" Text="Button" Width="155px" />
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
			<Columns>
				<asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
				<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
				<asp:BoundField DataField="Email " HeaderText="Email " SortExpression="Email " />
				<asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
				<asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
				<asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
			</Columns>
		</asp:GridView>
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RegistrationTabelConnectionString %>" SelectCommand="SELECT * FROM [RegistrationTabel]"></asp:SqlDataSource>
    </form>
</body>
</html>
