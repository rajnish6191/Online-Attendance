<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Subject.aspx.vb" Inherits="Subject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Subject Master</title>
    <style type="text/css">


        .style82
        {
            color: #FFFFFF;
            font-weight: normal;
        }
        .style104
        {
            background-color: #666633;
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
            text-align: left;
            height: 22px;
        }
        .style76
        {
            width: 232px;
            text-align: right;
            height: 22px;
            font-family: "Poor Richard";
            font-size: large;
        }
        .style77
        {
            width: 1px;
            height: 22px;
            font-family: "Poor Richard";
            font-size: large;
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
        .style90
        {
            height: 22px;
            }
        .style83
        {
            width: 100%;
        }
        .style86
        {
            width: 208px;
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
            text-align: center;
        }
        .style105
        {
            height: 22px;
            font-family: "Poor Richard";
            font-size: large;
        }
        .style106
        {
            font-family: "Poor Richard";
            font-size: large;
        }
        </style>
</head>
<body style="background-color: #666633">
    <form id="form1" runat="server">
    
        <h2 class="style82" style="text-align: center; width: 928px;">
            <span class="style104">Subject Master </span></h2>
    
        <table class="style68">
            <tr>
                <td class="style75">
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />                  
                </td>
                <td class="style76">
                    &nbsp;</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    &nbsp;</td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LRecID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style76">Academic Year
                    &nbsp;</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
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
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Subject Code</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="txtCodeSubject" runat="server" Width="162px" 
                        CssClass="style106"></asp:TextBox>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Subject Name</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtNameSubject" runat="server" Width="380px" 
                        CssClass="style106"></asp:TextBox>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Subject Short Name</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtShortName" runat="server" Width="162px" CssClass="style106"></asp:TextBox>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LCourseID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style76">
                    Course</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBCourse" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" CssClass="style106">
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
                    Year</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" CssClass="style106">
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
                    Semister</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBSemister" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" CssClass="style106">
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
                <td class="style78">
                    &nbsp;&nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Subject Type</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBSubType" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" CssClass="style106">
                        <asp:ListItem>Theory Only</asp:ListItem>
                        <asp:ListItem>Practical Only</asp:ListItem>
                        <asp:ListItem>Theory &amp; Practical</asp:ListItem>
                        <asp:ListItem>Theory &amp; Oral</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    TH</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="txtTH" runat="server" Width="162px" CssClass="style106"></asp:TextBox>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    PR</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="2">
                    <asp:TextBox ID="TxtPR" runat="server" Width="162px" CssClass="style106" 
                        Enabled="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    OR</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="2">
                    <asp:TextBox ID="TxtOR" runat="server" Width="162px" CssClass="style106"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    TW</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="2">
                    <asp:TextBox ID="TxtTW" runat="server" Width="162px" CssClass="style106"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    &nbsp;</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style105" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LStaffID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style76">
                   </td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="2">
                    <asp:DropDownList ID="CBAssignTeacher" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="380px" CssClass="style106" 
                        Visible="False">
                        <asp:ListItem>-- Select Teacher --</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    &nbsp;</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style105">
                    &nbsp;</td>
                <td class="style105">
                    <asp:Button ID="ButtonExit0" runat="server" Height="22px" Text="Edit Delete ON/Off" 
                        Width="117px" BackColor="DarkGreen" ForeColor="White" />
                </td>
            </tr>
            </table>
        <table class="style83">
            <tr>
                <td class="style86">
                    <asp:Button ID="ButtonNew0" runat="server" Height="30px" Text="Subject Teacher Assign " 
                        Width="191px" />
                </td>
                <td class="style87">
                    <asp:Button ID="ButtonNew" runat="server" Height="30px" Text="New" 
                        Width="84px" />
                    <asp:Button ID="ButtonAdd" runat="server" Height="30px" Text="Save" 
                        Width="84px" />
                    <asp:Button ID="ButtonEdit" runat="server" Height="30px" Text="Edit" 
                        Width="84px" />
                    <asp:Button ID="ButtonDelete" runat="server" Height="30px" Text="Delete" 
                        Width="84px" />
                    <asp:Button ID="ButtonExit" runat="server" Height="30px" Text="Exit" 
                        Width="84px" />
                </td>
                <td class="style88">
                </td>
            </tr>
            <tr>
                <td class="style84" colspan="3">
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
                   
                </td>
            </tr>
    </table>
        </form>
</body>
</html>
