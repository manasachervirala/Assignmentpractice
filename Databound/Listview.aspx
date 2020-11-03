<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listview.aspx.cs" Inherits="ListView.Listview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="ListView1_SelectedIndexChanged">
                <AlternatingItemTemplate>
                    <tr style="">
						<td>
							<asp:Label ID="StudentIdLabel" runat="server" Text='<%# Eval("StudentId") %>' />
						</td>
						<td>
							<asp:Label ID="StudentNameLabel" runat="server" Text='<%# Eval("StudentName") %>' />
						</td>
						<td>
							<asp:Label ID="StudentEmailLabel" runat="server" Text='<%# Eval("StudentEmail") %>' />
						</td>
						<td>
							<asp:Label ID="StudentMblLabel" runat="server" Text='<%# Eval("StudentMbl") %>' />
						</td>
						<td>
							<asp:Label ID="StudentGenderLabel" runat="server" Text='<%# Eval("StudentGender") %>' />
						</td>
						<td>
							<asp:Label ID="StudentRollNoLabel" runat="server" Text='<%# Eval("StudentRollNo") %>' />
						</td>
						<td>
							<asp:Label ID="StudentCityLabel" runat="server" Text='<%# Eval("StudentCity") %>' />
						</td>
						<td>
							<asp:Label ID="StudentAddressLabel" runat="server" Text='<%# Eval("StudentAddress") %>' />
						</td>
						<td>
							<asp:Label ID="StudentImageLabel" runat="server" Text='<%# Eval("StudentImage") %>' />
						</td>
					</tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="">
						<td>
							<asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
							<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
						</td>
						<td>
							<asp:TextBox ID="StudentIdTextBox" runat="server" Text='<%# Bind("StudentId") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentNameTextBox" runat="server" Text='<%# Bind("StudentName") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentEmailTextBox" runat="server" Text='<%# Bind("StudentEmail") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentMblTextBox" runat="server" Text='<%# Bind("StudentMbl") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentGenderTextBox" runat="server" Text='<%# Bind("StudentGender") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentRollNoTextBox" runat="server" Text='<%# Bind("StudentRollNo") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentCityTextBox" runat="server" Text='<%# Bind("StudentCity") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentAddressTextBox" runat="server" Text='<%# Bind("StudentAddress") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentImageTextBox" runat="server" Text='<%# Bind("StudentImage") %>' />
						</td>
					</tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="">
						<tr>
							<td>No data was returned.</td>
						</tr>
					</table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
						<td>
							<asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
							<asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
						</td>
						<td>
							<asp:TextBox ID="StudentIdTextBox" runat="server" Text='<%# Bind("StudentId") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentNameTextBox" runat="server" Text='<%# Bind("StudentName") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentEmailTextBox" runat="server" Text='<%# Bind("StudentEmail") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentMblTextBox" runat="server" Text='<%# Bind("StudentMbl") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentGenderTextBox" runat="server" Text='<%# Bind("StudentGender") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentRollNoTextBox" runat="server" Text='<%# Bind("StudentRollNo") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentCityTextBox" runat="server" Text='<%# Bind("StudentCity") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentAddressTextBox" runat="server" Text='<%# Bind("StudentAddress") %>' />
						</td>
						<td>
							<asp:TextBox ID="StudentImageTextBox" runat="server" Text='<%# Bind("StudentImage") %>' />
						</td>
					</tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="">
						<td>
							<asp:Label ID="StudentIdLabel" runat="server" Text='<%# Eval("StudentId") %>' />
						</td>
						<td>
							<asp:Label ID="StudentNameLabel" runat="server" Text='<%# Eval("StudentName") %>' />
						</td>
						<td>
							<asp:Label ID="StudentEmailLabel" runat="server" Text='<%# Eval("StudentEmail") %>' />
						</td>
						<td>
							<asp:Label ID="StudentMblLabel" runat="server" Text='<%# Eval("StudentMbl") %>' />
						</td>
						<td>
							<asp:Label ID="StudentGenderLabel" runat="server" Text='<%# Eval("StudentGender") %>' />
						</td>
						<td>
							<asp:Label ID="StudentRollNoLabel" runat="server" Text='<%# Eval("StudentRollNo") %>' />
						</td>
						<td>
							<asp:Label ID="StudentCityLabel" runat="server" Text='<%# Eval("StudentCity") %>' />
						</td>
						<td>
							<asp:Label ID="StudentAddressLabel" runat="server" Text='<%# Eval("StudentAddress") %>' />
						</td>
						<td>
							<asp:Label ID="StudentImageLabel" runat="server" Text='<%# Eval("StudentImage") %>' />
						</td>
					</tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
						<tr runat="server">
							<td runat="server">
								<table id="itemPlaceholderContainer" runat="server" border="0" style="">
									<tr runat="server" style="">
										<th runat="server">StudentId</th>
										<th runat="server">StudentName</th>
										<th runat="server">StudentEmail</th>
										<th runat="server">StudentMbl</th>
										<th runat="server">StudentGender</th>
										<th runat="server">StudentRollNo</th>
										<th runat="server">StudentCity</th>
										<th runat="server">StudentAddress</th>
										<th runat="server">StudentImage</th>
									</tr>
									<tr id="itemPlaceholder" runat="server">
									</tr>
								</table>
							</td>
						</tr>
						<tr runat="server">
							<td runat="server" style=""></td>
						</tr>
					</table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="">
						<td>
							<asp:Label ID="StudentIdLabel" runat="server" Text='<%# Eval("StudentId") %>' />
						</td>
						<td>
							<asp:Label ID="StudentNameLabel" runat="server" Text='<%# Eval("StudentName") %>' />
						</td>
						<td>
							<asp:Label ID="StudentEmailLabel" runat="server" Text='<%# Eval("StudentEmail") %>' />
						</td>
						<td>
							<asp:Label ID="StudentMblLabel" runat="server" Text='<%# Eval("StudentMbl") %>' />
						</td>
						<td>
							<asp:Label ID="StudentGenderLabel" runat="server" Text='<%# Eval("StudentGender") %>' />
						</td>
						<td>
							<asp:Label ID="StudentRollNoLabel" runat="server" Text='<%# Eval("StudentRollNo") %>' />
						</td>
						<td>
							<asp:Label ID="StudentCityLabel" runat="server" Text='<%# Eval("StudentCity") %>' />
						</td>
						<td>
							<asp:Label ID="StudentAddressLabel" runat="server" Text='<%# Eval("StudentAddress") %>' />
						</td>
						<td>
							<asp:Label ID="StudentImageLabel" runat="server" Text='<%# Eval("StudentImage") %>' />
						</td>
					</tr>
                </SelectedItemTemplate>
            </asp:ListView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:StudentsConnectionString %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>
    </form>
</body>
</html>