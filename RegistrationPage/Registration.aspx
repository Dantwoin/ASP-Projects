<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Registration.aspx.vb" Inherits="ASPFormExample.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 90%;
            height: 267px;
            margin-top: 26px;
        }
        .auto-style2 {
            width: 96px;
        }
        .auto-style3 {
            width: 96px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 96px;
            height: 22px;
        }
        .auto-style6 {
            height: 22px;
        }
        .auto-style7 {
            height: 51px;
        }
        .auto-style8 {
            width: 96px;
            height: 24px;
        }
        .auto-style9 {
            height: 24px;
        }
        .auto-style10 {
            width: 96px;
            height: 51px;
        }
        .auto-style11 {
            height: 24px;
            width: 207px;
            text-align: justify;
        }
        .auto-style12 {
            width: 207px;
            text-align: justify;
        }
        .auto-style13 {
            height: 51px;
            width: 207px;
            text-align: justify;
        }
        .auto-style14 {
            height: 23px;
            width: 207px;
        }
        .auto-style15 {
            height: 22px;
            width: 207px;
            text-align: justify;
        }
        .auto-style16 {
            width: 96px;
            height: 30px;
        }
        .auto-style17 {
            width: 207px;
            height: 30px;
            text-align: justify;
        }
        .auto-style18 {
            height: 30px;
        }
        .auto-style19 {
            height: 23px;
            width: 207px;
            text-align: justify;
        }
        .auto-style20 {
            color: #FF0000;
        }
        #Reset1 {
            width: 79px;
        }
        .auto-style22 {
            text-decoration: underline;
            font-size: xx-large;
            text-align: center;
            width: 514px;
        }
    </style>
</head>
<body style="width: 748px">
    <form id="form1" runat="server">
    <div style="width: 659px">
    
        <div class="auto-style22">
            <strong>Registration Page</strong></div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style8">User Name</td>
                <td class="auto-style11">
                    <asp:TextBox ID="TextBoxUsername" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style9">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUsername" CssClass="auto-style20" ErrorMessage="Username is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Email</td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBoxEmail" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style18">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" CssClass="auto-style20" ErrorMessage="Email is required."></asp:RequiredFieldValidator>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="You must enter a valid email address" style="color: #FF0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password</td>
                <td class="auto-style12">
                    <asp:TextBox ID="TextBoxPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxPass" CssClass="auto-style20" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style10">Confirm Password</td>
                <td class="auto-style13">
                    <asp:TextBox ID="TextBoxConfirmPass" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
&nbsp;<br />
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxConfirmPass" CssClass="auto-style20" ErrorMessage="Confirm Password is required"></asp:RequiredFieldValidator>
                    <br />
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPass" ControlToValidate="TextBoxConfirmPass" ErrorMessage="Both passwords must be the same. " style="color: #FF0000"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">City</td>
                <td class="auto-style19">
                    <asp:TextBox ID="TextBoxCity" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxCity" CssClass="auto-style20" ErrorMessage="City is required."></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">State</td>
                <td class="auto-style15">
                    <asp:TextBox ID="TextBoxState" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBoxState" CssClass="auto-style20" ErrorMessage="State is Required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Country</td>
                <td class="auto-style19">
                    <asp:DropDownList ID="DropDownListCountry" runat="server" Width="190px">
                        <asp:ListItem Value="Select Country"></asp:ListItem>
                        <asp:ListItem Value="Australia"></asp:ListItem>
                        <asp:ListItem Value="Brazil"></asp:ListItem>
                        <asp:ListItem Value="Canada"></asp:ListItem>
                        <asp:ListItem Value="China"></asp:ListItem>
                        <asp:ListItem Value="Egypt"></asp:ListItem>
                        <asp:ListItem Value="Germany"></asp:ListItem>
                        <asp:ListItem Value="South Korea"></asp:ListItem>
                        <asp:ListItem Value="United Kingdom"></asp:ListItem>
                        <asp:ListItem Value="United States of America "></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style4">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DropDownListCountry" CssClass="auto-style20" ErrorMessage="Country not selected" InitialValue="Select Country"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style14">
                    <asp:Button ID="Button1" runat="server" Text="Submit" Width="84px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <input id="Reset1" type="reset" value="Reset" /></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style14">&nbsp;</td>
                <td class="auto-style4"></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
