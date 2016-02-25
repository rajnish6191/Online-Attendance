<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Course.aspx.vb" Inherits="Course" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Master</title>
    <style type="text/css">

        .style68
        {
            width: 100%;
            color: #FFFFFF;
            height: 100px;
            font-family: "Poor Richard";
        }
        .style75
        {
            width: 138px;
            text-align: right;
            height: 22px;
        }
        .style76
        {
            width: 287px;
            text-align: right;
            height: 22px;
        }
        .style80
        {
            height: 22px;
            }
        .style78
        {
            height: 22px;
        }
        #Password1
        {
            width: 162px;
        }
        .style83
        {
            width: 100%;
        }
        .style84
        {
            width: 174px;
            text-align: center;
        }
        .style85
        {
            width: 708px;
            text-align: center;
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
        .style89
        {
            color: #FFFFFF;
            font-weight: normal;
            font-size: xx-large;
            font-family: "Poor Richard";
        }
        .style90
        {
            height: 22px;
            width: 1px;
        }
        .style91
        {
            height: 22px;
            width: 167px;
        }
        .style92
        {
            text-align: center;
        }
    </style>
</head>
<body style="background-color: #666633">
    <form id="form1" runat="server">
    <div>
    
        <h2 class="style89" style="text-align: center" id="Title">
            Course Master</h2>
        <p class="style89" style="text-align: left">
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />                  
        </p>
    
    </div>
        <table class="style68">
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    <asp:Label ID="LType" runat="server" Text="Course" Visible="False"></asp:Label>
                </td>
                <td class="style90">
                    &nbsp;</td>
                <td class="style80">
                    <asp:Label ID="LRecID" runat="server" Text="0" style="color: #666633"></asp:Label>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Course Code&nbsp; </td>
                <td class="style90">
                    &nbsp;</td>
                <td class="style80">
                    <asp:TextBox ID="txtCode" runat="server" Width="162px" MaxLength="30"></asp:TextBox>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Course Name</td>
                <td class="style90">
                    &nbsp;</td>
                <td class="style80">
                    <asp:TextBox ID="txtName" runat="server" Width="162px" MaxLength="40"></asp:TextBox>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    &nbsp;</td>
                <td class="style90">
                    &nbsp;</td>
                <td class="style80">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonExit0" runat="server" Height="22px" Text="Edit Delete ON/Off" 
                        Width="117px" BackColor="DarkGreen" ForeColor="White" />
                &nbsp;&nbsp;</td>
                <td class="style91">
                    &nbsp;</td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    &nbsp;</td>
                <td class="style90">
                    &nbsp;</td>
                <td class="style80" colspan="2">
                    <asp:Label ID="LabelMessage" runat="server" ForeColor="Yellow"></asp:Label>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            </table>
        <table class="style83" align="center">
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
                <td class="style84">
                    &nbsp;</td>
                <td class="style85">
                    <asp:GridView ID="Dgv1" runat="server" BackColor="White" BorderColor="#CC9966" 
                        BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="596px" 
                        AutoGenerateSelectButton="True" style="text-align: left" 
                      >
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    </asp:GridView>
                   
                </td>
                <td class="style92">
                    &nbsp;</td>
            </tr>
    </table>
    </form>
</body>
</html>
