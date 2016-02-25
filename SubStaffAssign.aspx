<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SubStaffAssign.aspx.vb" Inherits="SubStaffAssign" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Subject Assign</title>
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            width: 100%;
        }
        .style106
        {
            font-family: "Poor Richard";
            font-size: large;
        }
        .style107
        {
            text-align: center;
        }
        .style108
        {
            width: 126px;
        }
        .style109
        {
            text-align: right;
            width: 348px;
            color: #FFFFFF;
        }
        .style110
        {
            font-family: Arial, Helvetica, sans-serif;
            color: #FFFFFF;
        }
        .style111
        {
            color: #FFFFFF;
        }
    </style>
</head>
<body style="background-color: #333300">
    <form id="form1" runat="server">
    <div class="style1">
    
        <h2>
            <span class="style111">Subject Staff Assign</span><br class="style110" />
    
        </h2>
    
    </div>
    <table class="style2">
        <tr>
            <td class="style108">
                &nbsp;</td>
            <td class="style109">
                Academic Year</td>
            <td>
                    <asp:DropDownList ID="CbAcadYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" CssClass="style106">
                        <%--<asp:ListItem>2012-2013</asp:ListItem>--%>
                        <asp:ListItem>2013-2014</asp:ListItem>
                        <%--<asp:ListItem>2014-2015</asp:ListItem>
                        <asp:ListItem>2015-2016</asp:ListItem>
                        <asp:ListItem>2017-2018</asp:ListItem>
                        <asp:ListItem>2018-2019</asp:ListItem>
                        <asp:ListItem>2019-2020</asp:ListItem>--%>
                    </asp:DropDownList>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style108">
                &nbsp;</td>
            <td class="style109">
                Course</td>
            <td>
                    <asp:DropDownList ID="CBCourse" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" 
                    CssClass="style106">
                        <asp:ListItem>-- Select Course --</asp:ListItem>
                    </asp:DropDownList>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style108">
                    <asp:Label ID="LCourseID" runat="server" Text="0" Visible="False"></asp:Label>
                    <asp:Label ID="LYearID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
            <td class="style109">
                Year</td>
            <td>
                    <asp:DropDownList ID="CBYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" CssClass="style106">
                        <asp:ListItem>-- Select Year --</asp:ListItem>
                    </asp:DropDownList>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style108">
                &nbsp;</td>
            <td class="style109">
                &nbsp;</td>
            <td>
                    <asp:DropDownList ID="CBSemister" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" CssClass="style106" 
                        Visible="False">
                        <asp:ListItem>Sem-I</asp:ListItem>
                        <asp:ListItem>Sem-II</asp:ListItem>
                        <asp:ListItem>Sem-III</asp:ListItem>
                        <asp:ListItem>Sem-IV</asp:ListItem>
                        <asp:ListItem>Sem-V</asp:ListItem>
                        <asp:ListItem>Sem-VI</asp:ListItem>
                        <asp:ListItem>Sem-VII</asp:ListItem>
                        <asp:ListItem>Sem-VIII</asp:ListItem>
                    </asp:DropDownList>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style108">
                    <asp:TextBox ID="txtCodeSubject" runat="server" Width="87px" 
                        CssClass="style106" Height="21px" Visible="False"></asp:TextBox>
                </td>
            <td class="style109">
                Subject</td>
            <td>
                    <asp:DropDownList ID="CBSubject" runat="server" AutoPostBack="True" 
                        Height="24px" style="margin-left: 0px" Width="167px" 
                    CssClass="style106">
                        <asp:ListItem>-- Select Subject--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style108">
                    <asp:Label ID="LStaffID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
            <td class="style109">
                Assign Teacher</td>
            <td>
                    <asp:DropDownList ID="CBAssignTeacher" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="380px" CssClass="style106">
                        <asp:ListItem>-- Select Teacher --</asp:ListItem>
                    </asp:DropDownList>
                </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style108">
                &nbsp;</td>
            <td class="style107">
                &nbsp;</td>
            <td class="style107">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style108">
                &nbsp;</td>
            <td class="style107" colspan="2">
                    <asp:Button ID="ButtonAdd" runat="server" Height="30px" Text="Update" 
                        Width="84px" />
                    <asp:Button ID="ButtonExit" runat="server" Height="30px" Text="Exit" 
                        Width="84px" />
                </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
                    <asp:GridView ID="Dgv1" runat="server" BackColor="White" BorderColor="#CC9966" 
                        BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="930px" 
                        AutoGenerateSelectButton="True" style="text-align: center" 
                      >
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                    </asp:GridView>
                   
    </form>
</body>
</html>
