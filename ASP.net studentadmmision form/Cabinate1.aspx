<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cabinate1.aspx.cs" Inherits="Cabinate1.Cabinate1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Candidate</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Candiate Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">House</td>
                <td>
                    <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="Red" Text="Red" />
                    <asp:RadioButton ID="RadioButton2" runat="server" ForeColor="#0033CC" Text="Blue" />
                    <asp:RadioButton ID="RadioButton3" runat="server" ForeColor="Yellow" Text="Yellow" />
                    <asp:RadioButton ID="RadioButton4" runat="server" ForeColor="#00CC00" Text="Green" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Class</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter correct range" ForeColor="Red" MaximumValue="6" MinimumValue="1"></asp:RangeValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please Enter EmailID" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
</body>
</html>