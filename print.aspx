<%@ Page Language="VB" AutoEventWireup="false" CodeFile="print.aspx.vb" Inherits="print" %>

<%@ Register assembly="CrystalDecisions.Web, Version=12.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Print</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 62px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
                <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
                <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style2">
    
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg"
           OnClick="ImageButton1_Click" 
                    style="top: 11px; left: 12px; position: absolute; height: 43px; width: 45px" />                  
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan="2">
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                    AutoDataBind="true" ReuseParameterValuesOnRefresh="True" ToolPanelView="None" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
