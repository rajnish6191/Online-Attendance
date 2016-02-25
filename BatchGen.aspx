<%@ Page Language="VB" AutoEventWireup="false" CodeFile="BatchGen.aspx.vb" Inherits="BatchGen" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Batch Generation</title>
    <style type="text/css">



        .style82
        {
            color: #FFFFFF;
            font-weight: normal;
        }
        .style104
        {
            background-color: #333300;
            font-family: "Poor Richard";
            font-size: 20pt;
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
            width: 263px;
            text-align: right;
            height: 22px;
        }
        .style91
        {
            height: 22px;
            width: 162px;
        }
        .style78
        {
            height: 22px;
        }
        .style105
        {
            height: 25px;
            width: 74px;
        }
        .style106
        {
            width: 138px;
            text-align: right;
            height: 25px;
        }
        .style107
        {
            width: 263px;
            text-align: right;
            height: 25px;
        }
        .style109
        {
            height: 25px;
            width: 97px;
        }
        .style110
        {
            height: 25px;
        }
        .style111
        {
            height: 22px;
            width: 10px;
        }
        .style112
        {
            height: 25px;
            width: 10px;
        }
        .style113
        {
            width: 138px;
            text-align: right;
            height: 21px;
        }
        .style114
        {
            width: 263px;
            text-align: right;
            height: 21px;
        }
        .style115
        {
            height: 21px;
            width: 10px;
        }
        .style116
        {
            height: 21px;
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
        </style>
</head>
<body style="background-color: #333300">
    
        <h2 class="style82" style="text-align: center; width: 928px;">
            <span class="style104">Batch Generation </span></h2>
    
    <form id="form1" runat="server">
    <div style="font-size: large; font-family: 'Poor Richard'">
    
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />                  
    
        <br />
    
        <table class="style68">
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Academic Year</td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style91" colspan="2">
                    <asp:DropDownList ID="CBAcadYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Year --</asp:ListItem>
                        <%--<asp:ListItem>2012-2013</asp:ListItem>--%>
                        <asp:ListItem>2013-2014</asp:ListItem>
                        <%--<asp:ListItem>2014-2015</asp:ListItem>--%>
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LCourseID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style76">
                    Select
                    Course</td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style91" colspan="2">
                    <asp:DropDownList ID="CBCourse" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Course --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LYearID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style76">
                    Select
                    Year</td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style91" colspan="2">
                    <asp:DropDownList ID="CBYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Year --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Batch Name</td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style91" colspan="2">
                    <asp:DropDownList ID="CBBatch" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Batch --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    &nbsp;&nbsp;</td>
            </tr>
            <tr>
                <td class="style106">
                    </td>
                <td class="style107">
                    Roll No </td>
                <td class="style112">
                    </td>
                <td class="style105">
                    <asp:TextBox ID="TxtRollNoStrat" runat="server" Width="60px"></asp:TextBox>
                </td>
                <td class="style109">
                    To&nbsp;
                    <asp:TextBox ID="TxtRollNoTo" runat="server" Width="60px"></asp:TextBox>
                &nbsp;</td>
                <td class="style110">
                    </td>
            </tr>
            <tr>
                <td class="style113">
                    </td>
                <td class="style114">
                    </td>
                <td class="style115">
                    </td>
                <td class="style116" colspan="2">
                    </td>
                <td class="style116">
                    <asp:Button ID="ButtonClickProcessStart" runat="server" Height="30px" 
                        Text="Click Batch Process Start" Width="180px" />
                    <asp:Button ID="ButtonExit" runat="server" Height="30px" Text="Exit" 
                        Width="84px" />
                    </td>
            </tr>
            </table>
    
    </div>
        <table class="style83">
            <tr>
                <td class="style86">
                    <asp:Label ID="LCount" runat="server" Text="Student Count : 0" Font-Bold="True" 
                        Font-Size="Medium" ForeColor="#FFFF66"></asp:Label>
                </td>
                <td class="style87">
                    &nbsp;</td>
                <td class="style88">
                </td>
            </tr>
            <tr>
                <td class="style84" colspan="3">
                    <asp:GridView ID="Dgv1" runat="server" BackColor="White" BorderColor="#CC9966" 
                        BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="958px" style="text-align: center" 
                        Font-Names="Palatino Linotype" Font-Size="Small" EnableSortingAndPagingCallbacks="True" 
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
