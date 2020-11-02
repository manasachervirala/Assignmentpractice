<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentadmission.aspx.cs" Inherits="studentadminission.studentadmission" %>

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
                <td class="auto-style1">FirstName</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="FirstName Required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">LastName</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="LastNameRequired" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">FatherName</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">MotherName</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Gender</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
                    <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Aggregate</td>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Must be grater than 60%" ForeColor="Red" MaximumValue="60" MinimumValue="100"></asp:RangeValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Course</td>
                <td class="auto-style2">
                    <asp:RadioButton ID="RadioButton3" runat="server"  Text="CSE" />
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>DC</asp:ListItem>
                        <asp:ListItem>Analog Communication</asp:ListItem>
                        <asp:ListItem>Digital</asp:ListItem>
                        <asp:ListItem>Microctroller</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />
                    <asp:RadioButton ID="RadioButton5" runat="server" Text="ECE" />
                    <br />
                    <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                        <asp:ListItem>Operating System</asp:ListItem>
                        <asp:ListItem>Computer Arch</asp:ListItem>
                        <asp:ListItem>Java</asp:ListItem>
                        <asp:ListItem>Phyton</asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox6"   ErrorMessage="Enter value in specified range" ForeColor="Red" MaximumValue="6" MinimumValue="1"   SetFocusOnError="True" Type=" Integer"></asp:RangeValidator>  
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>

    
