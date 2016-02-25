<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Automation For Management System</title>
    <style type="text/css">

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
            background-color: #000000;
        }
        .style76
        {
            width: 320px;
            text-align: right;
            height: 22px;
            background-color: #000000;
        }
        .style77
        {
            width: 8px;
            height: 22px;
            background-color: #000000;
        }
        .style80
        {
            height: 22px;
            width: 163px;
            background-color: #000000;
        }
        .style78
        {
            height: 22px;
            background-color: #000000;
        }
        #TxtPassword
        {
            width: 162px;
        }
        .style71
        {
            width: 138px;
            height: 37px;
            background-color: #000000;
        }
        .style70
        {
            width: 320px;
            height: 37px;
        }
        .style69
        {
            width: 8px;
            height: 37px;
        }
        .style81
        {
            height: 37px;
            width: 163px;
        }
        .style79
        {
            height: 37px;
        }
        #Table_01
        {
            background-color: #000000;
            position: relative;
        }
    </style>
</head>
<body bgcolor="#FFFFFF" leftmargin="0" topmargin="0" marginwidth="0" 
    marginheight="0" style="background-color: #000000">
    <form id="form1" runat="server">
    8<!-- Save for Web Slices (Untitled-1 copy.psd) --><table id="Table_01" 
        width="1020" height="816" border="0" cellpadding="0" cellspacing="0" 
        align="center">
	<tr>
		<td>
			<img src="images/Login_01.gif" width="1020" height="107" alt=""></td>
	</tr>
	<tr>
		<td>
        <table class="style68">
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Academic Year</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style80">
                    <asp:DropDownList ID="CBAcadYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <%--<asp:ListItem>2012-2013</asp:ListItem>--%>
                        <asp:ListItem>2013-2014</asp:ListItem>
                        <%--<asp:ListItem>2014-2015</asp:ListItem>--%>
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    <asp:Label ID="LabelStaffID" runat="server" Text="Label" Visible="False"></asp:Label>
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
                    <asp:Label ID="Textbox1" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
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
                    <asp:Label ID="LDesg" runat="server" Text="LDesg" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style71">
                    </td>
                <td class="style70">
                    </td>
                <td class="style69">
                    </td>
                <td class="style81">
                    <asp:Button ID="ButtonLogin" runat="server" Text="Log in" Width="85px" 
                        Height="31px" style="float: right" onclick="ButtonLogin_Click" />
                </td>
                <td class="style79">
                    <asp:Label ID="LMsg" runat="server" 
                        style="color: #FF0000; font-family: 'Adobe Caslon Pro'" 
                        Text="Sorry ! Wrong Password or Username" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
			<img src="images/mLog.gif" width="1020" alt="" style="height: 409px"></td>
	</tr>
	<tr>
		<td style="background-color: #000000">
			&nbsp;</td>
	</tr>
	<tr>
		<td>
			&nbsp;</td>
	</tr>
</table>
<!-- End Save for Web Slices -->
    </form>
</body>
</html>