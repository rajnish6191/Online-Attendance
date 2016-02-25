<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AttLogin.aspx.vb" Inherits="AttLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attendance Login</title>
    <style type="text/css">

        .style82
        {
            color: #FFFFFF;
            font-weight: normal;
        }
        .style3
        {
            background-color: #666633;
            font-family: "Poor Richard";
            font-size: x-large;
        }
        .style68
        {
            width: 100%;
            color: #FFFFFF;
            height: 100px;
        }
        .style75
        {
            width: 138px;
            text-align: right;
            height: 22px;
        }
        .style76
        {
            width: 326px;
            text-align: right;
            height: 22px;
            font-family: "Poor Richard";
            font-size: large;
        }
        .style77
        {
            width: 8px;
            height: 22px;
        }
        .style80
        {
            height: 22px;
            width: 163px;
        }
        .style78
        {
            height: 22px;
        }
        #Password1
        {
            width: 162px;
        }
        .style71
        {
            width: 138px;
            height: 39px;
        }
        .style70
        {
            width: 326px;
            height: 39px;
        }
        .style69
        {
            width: 8px;
            height: 39px;
        }
        .style81
        {
            height: 39px;
            width: 163px;
        }
        .style79
        {
            height: 39px;
        }
        #TxtPassword
        {
            width: 162px;
        }
        .style83
        {
            width: 138px;
            text-align: right;
            height: 17px;
        }
        .style84
        {
            width: 326px;
            text-align: right;
            height: 17px;
            font-family: "Poor Richard";
            font-size: large;
        }
        .style85
        {
            width: 8px;
            height: 17px;
        }
        .style86
        {
            height: 17px;
            width: 163px;
        }
        .style87
        {
            height: 17px;
        }
        #TxtPassword0
        {
            width: 162px;
        }
        </style>
</head>
<body style="background-color: #666633">
    <form id="form1" runat="server">
    <div>
    
        <h2 class="style82" style="text-align: center">
            <span class="style3">Attendance Login Form</span></h2>
    
    </div>
    <p>
        &nbsp;</p>
    <p>
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />                  
        </p>
    <p>
                    <asp:Label ID="LStaffNameFull" runat="server" 
            Text="Staff Full Name ----" Visible="False"></asp:Label>
                </p>
        <table class="style68">
            <tr>
                <td class="style83">
                    </td>
                <td class="style84">
                    Academic Year</td>
                <td class="style85">
                    </td>
                <td class="style86">
                    <asp:DropDownList ID="CBAcadYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                       <%-- <asp:ListItem>2012-2013</asp:ListItem>--%>
                        <asp:ListItem>2013-2014</asp:ListItem>
                        <%--<asp:ListItem>2014-2015</asp:ListItem>
--%>                    </asp:DropDownList>
                </td>
                <td class="style87">
                    </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    User Name</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style80">
                    <asp:TextBox ID="TxtUserName" runat="server" Width="162px"></asp:TextBox>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Password</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style80">
                    <asp:TextBox ID="TxtPassword" runat="server" Width="162px" TextMode="Password"></asp:TextBox>
                 
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style71">
                    </td>
                <td class="style70">
                    <asp:TextBox ID="Textbox1" runat="server" Width="162px" Visible="False"></asp:TextBox>
                 
                    </td>
                <td class="style69">
                    </td>
                <td class="style81">
                    <asp:Button ID="ButtonLogIn" runat="server" Text="Log in" Width="85px" 
                        Height="31px" style="float: right" />
                </td>
                <td class="style79">
                    <asp:Label ID="LabelStaffID" runat="server" Text="StaffID" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
