<%@ Page Language="VB" AutoEventWireup="false" CodeFile="StaffReg.aspx.vb" Inherits="StaffReg" %>

<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Registraion</title>
    <style type="text/css">

        .style82
        {
            color: #FFFFFF;
            font-weight: normal;
        }
        .style68
        {
            width: 100%;
            color: #FFFFFF;
            height: 100px;
            font-size: large;
            font-family: "Poor Richard";
        }
        .style75
        {
            width: 81px;
            text-align: left;
            height: 22px;
        }
        .style76
        {
            width: 227px;
            text-align: right;
            height: 22px;
        }
        .style77
        {
            width: 1px;
            height: 22px;
        }
        .style91
        {
            height: 22px;
            width: 151px;
        }
        .style78
        {
            height: 22px;
        }
        .style96
        {
            width: 81px;
            text-align: left;
            height: 18px;
        }
        .style97
        {
            text-align: right;
            height: 18px;
        }
        .style98
        {
            width: 1px;
            height: 30px;
        }
        .style103
        {
            height: 30px;
            width: 151px;
        }
        .style80
        {
            height: 22px;
            }
        .style90
        {
            height: 22px;
            }
        .style104
        {
            background-color: #333300;
            font-family: "Poor Richard";
            font-size: 20pt;
        }
        .style83
        {
            width: 100%;
        }
        .style86
        {
            width: 174px;
            height: 43px;
        }
        .style87
        {
            width: 708px;
            height: 43px;
            text-align: center;
        }
        .style88
        {
            height: 43px;
        }
        .style84
        {
        }
        .style105
        {
            width: 81px;
            text-align: left;
            height: 30px;
        }
        .style106
        {
            text-align: right;
            height: 30px;
            width: 227px;
        }
        .style107
        {
            height: 30px;
        }
        .style108
        {
            width: 1758px;
            height: 41px;
        }
        .style109
        {
            height: 18px;
            width: 1758px;
        }
        .style110
        {
            width: 81px;
            text-align: left;
            height: 41px;
        }
        .style111
        {
            width: 227px;
            text-align: right;
            height: 41px;
        }
        .style112
        {
            width: 1px;
            height: 41px;
        }
        .style113
        {
            height: 41px;
            width: 151px;
        }
        .style116
        {
            height: 41px;
        }
        .style120
        {
            width: 81px;
            text-align: left;
        }
        .style121
        {
            width: 227px;
            text-align: right;
        }
        .style122
        {
            width: 1px;
        }
        .style123
        {
            width: 151px;
        }
        .style124
        {
            color: #333300;
        }
        </style>
</head>
<body style="background-color: #333300">
    <form id="form1" runat="server">
    <div>
    
        <h2 class="style82" style="text-align: center; width: 928px;">
            <span class="style104">Staff Registration Form</span></h2>
    
    </div>
        <table class="style68" style="font-size: small">
            <tr>
                <td class="style105">
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />                  
                    </td>
                <td class="style106">
                    </td>
                <td class="style98">
                    </td>
                <td class="style103">
                    (First Name)</td>
                <td class="style107" colspan="2">
                    (Middle Name)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    (Last Name)</td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LRecID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style76">
                    Name of Staff</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtFName" runat="server" Width="163px"></asp:TextBox>
                </td>
                <td class="style78">
                    <asp:TextBox ID="TxtMName" runat="server" Width="162px"></asp:TextBox>
                &nbsp;<asp:TextBox ID="TxtLName" runat="server" Width="162px" 
                        style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LStaffID" runat="server" Text="Lstaff ID" CssClass="style124" 
                        Font-Bold="True" Font-Size="Medium" style="background-color: #333300"></asp:Label>
                </td>
                <td class="style76">
                    Short Name</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtShortName" runat="server" Width="163px"></asp:TextBox>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LSta" runat="server" Text="000000000000" CssClass="style124" 
                        Font-Bold="True" Font-Size="Medium" style="background-color: #333300"></asp:Label>
                </td>
                <td class="style76">
                    Quallificaton</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtQuallification" runat="server" Width="163px"></asp:TextBox>
                </td>
                <td class="style78" colspan="2">
                    <asp:Label ID="LFullName" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style120">
                    </td>
                <td class="style121">
                    Type</td>
                <td class="style122">
                    </td>
                <td class="style123">
                    <asp:DropDownList ID="CBType" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>Teaching</asp:ListItem>
                        <asp:ListItem>Non-Teaching</asp:ListItem>
                        <asp:ListItem>Administrator</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td colspan="2">
                    </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Designation</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBDesignaton" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>Associate Prof</asp:ListItem>
                        <asp:ListItem>Assistance Prof</asp:ListItem>
                        <asp:ListItem>Prof</asp:ListItem>
                        <asp:ListItem>Lecture</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Experience</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtExperience" runat="server" Width="163px"></asp:TextBox>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    &nbsp;Address</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style80" colspan="3">
                <%-- <asp:TextBox ID="TextBox11" runat="server" Width="496px" Height="55px"></asp:TextBox> '--%>
                <asp:TextBox textmode="multiline" runat="server" ID ="TxtAddress" name="PedEva" 
                        class="div_handelingsplan" style="OVERFLOW:auto; width:380px; height:60px; margin-left: 0px;" 
                        Height="56px" Width="345px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style110">
                    </td>
                <td class="style111">
                    Mobile No</td>
                <td class="style112">
                    </td>
                <td class="style113">
                    <asp:TextBox ID="TxtMobileNo" runat="server" Width="162px" MaxLength="10" ></asp:TextBox>
                 </td>
                   <td style="text-align: left;" class="style108" colspan="2">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                    runat="server" ControlToValidate="TxtMobileNo"
                        ErrorMessage="Mobile Number must be 10 digits(Numerals)" 
                        ValidationExpression="\d+" style="color: #FFFF00">
                        </asp:RegularExpressionValidator></td>
                        
                </td>
                 </td>
                        
                <td class="style116">
                    </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Email ID</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="3">
                    <asp:TextBox ID="TxtEmailID" runat="server" Width="256px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="EmailIDValidation" 
                    runat="server" ControlToValidate="TxtEmailID"
                        ErrorMessage="Enter Email ID Properly" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ValidationGroup="val1" style="color: #FFFF00"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Status</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="3">
                    <asp:DropDownList ID="CBStatus" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    User Name</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="3">
                    <asp:TextBox ID="TxtUserName" runat="server" Width="162px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Password</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="3">
                    <asp:TextBox ID="TxtPassword" runat="server" Width="162px" TextMode="Password"></asp:TextBox>
                 
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;</td>
                <td class="style76">
                    Re-Type Password</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="3">
                    <asp:TextBox ID="TxtReTypePassword" runat="server" Width="162px" TextMode="Password"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonExit1" runat="server" Height="22px" Text="Confirm Password" 
                        Width="125px" BackColor="#FFFF66" ForeColor="Blue" />
                    <asp:Label ID="LMsg" runat="server" 
                        Text="Sorry ! Wrong Password" Font-Names="Arial" 
                        ForeColor="#FFFF66" Visible="False" Font-Size="Medium" 
                        style="font-size: small"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style96">
                    </td>
                <td class="style97" colspan="3">
                    <asp:Label ID="LabelMessage" runat="server" Font-Bold="True" 
                        ForeColor="#CCFF66"></asp:Label>
                    </td>
                <td class="style109" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    &nbsp;<asp:Button ID="ButtonExit0" runat="server" Height="22px" Text="Edit Delete ON/Off" 
                        Width="128px" BackColor="DarkGreen" ForeColor="White" />
                    </td>
            </tr>
            </table>
        <table class="style83">
            <tr>
                <td class="style86">
                </td>
                <td class="style87">
                    <asp:Button ID="ButtonNew" runat="server" Height="30px" Text="New" 
                        Width="84px" />
                    <asp:Button ID="ButtonAdd" runat="server" Height="30px" Text="Save" 
                        Width="84px" />
                    <asp:Button ID="ButtonEdit" runat="server" Height="30px" Text="Edit" 
                        Width="84px" Enabled="False" />
                    <asp:Button ID="ButtonDelete" runat="server" Height="30px" Text="Delete" 
                        Width="84px" Enabled="False" />
                    <asp:Button ID="ButtonExit" runat="server" Height="30px" Text="Exit" 
                        Width="84px" />
                </td>
                <td class="style88">
                </td>
            </tr>
            <tr>
                <td class="style84" colspan="3">
                    <asp:GridView ID="Dgv1" runat="server" BackColor="White" BorderColor="#CC9966" 
                        BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="958px" 
                        AutoGenerateSelectButton="True" style="text-align: center" 
                        Font-Names="Palatino Linotype" Font-Size="Small" 
                      >
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <EditRowStyle Font-Size="Small" Wrap="False" />
                    </asp:GridView>
                   
                </td>
            </tr>
    </table>
    </form>
</body>
</html>
