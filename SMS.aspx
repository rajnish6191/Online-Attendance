<%@ Page Language="VB" AutoEventWireup="false" CodeFile="SMS.aspx.vb" Inherits="SMS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .style11
        {
            width: 100%;
        }
        .style2
        {
            color: #FFFFCC;
        }
        .style19
        {
            width: 432px;
            text-align: right;
        }
        .style25
        {
            width: 155px;
        }
        .style14
        {
            text-align: right;
            color: #FFFFFF;
        }
        .style21
        {
            text-align: right;
            color: #FFFFFF;
            width: 338px;
        }
        .style26
        {
            color: #FFFFFF;
            width: 155px;
        }
        .style28
        {
            color: #333300;
        }
        .style15
        {
            color: #FFFFFF;
        }
        .style29
        {
            text-align: right;
            color: #FFFFFF;
            height: 26px;
        }
        .style30
        {
            text-align: right;
            color: #FFFFFF;
            width: 338px;
            height: 26px;
        }
        .style31
        {
            color: #FFFFFF;
            width: 155px;
            height: 26px;
        }
        .style32
        {
            color: #FFFFFF;
            height: 26px;
        }
        .style27
        {
            color: #FFFFFF;
            text-align: left;
            width: 155px;
        }
        .style20
        {
            color: #FFFFFF;
            text-align: left;
        }
        .style1
        {
            width: 100%;
            color: #FFFFFF;
        }
        .style16
        {
            width: 291px;
            text-align: right;
            height: 28px;
        }
        .style17
        {
            width: 507px;
            height: 28px;
        }
        .style18
        {
            height: 28px;
        }
        .style3
        {
            width: 291px;
            text-align: right;
        }
        .style4
        {
            width: 507px;
        }
        .style12
        {
            width: 564px;
        }
        </style>
</head>
<body style="background-color: #333300">
    <form id="form1" runat="server">
    
        <table class="style11">
            <tr>
                <td>
    
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />                  
    
                </td>
                <td class="style24" colspan="4">
    
        <h1 class="style2" style="text-align: center; margin-left: 0px;">
            SMS Tools&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style24" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style19" colspan="2">
                    &nbsp;</td>
                <td style="text-align: left" class="style25">
                    <asp:Label ID="CBAcadYear" runat="server" Text="0000000000000" Font-Bold="True" 
                        Font-Size="Larger" style="color: #FFFFCC; text-align: center"></asp:Label>
                </td>
                <td style="text-align: left">
                    &nbsp;</td>
                <td style="text-align: left">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style21">
                    Course</td>
                <td class="style26">
                    <asp:DropDownList ID="CBCourse" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Course --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style28">
                    111111111111111</td>
                <td class="style28">
                    2222222222222222222222222222</td>
            </tr>
            <tr>
                <td class="style14">
                    &nbsp;</td>
                <td class="style21">
                    Year</td>
                <td class="style26">
                    <asp:DropDownList ID="CBYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Year --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style15">
                    &nbsp;</td>
                <td class="style15">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style29">
                    </td>
                <td class="style30">
                    All/Particulars</td>
                <td class="style31">
                    <asp:DropDownList ID="CBAll" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>All</asp:ListItem>
                        <asp:ListItem>Particular</asp:ListItem>
                        <asp:ListItem Selected="True">-- Select  --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style32">
                </td>
                <td class="style32">
                </td>
            </tr>
            <tr>
                <td class="style19" colspan="2">
                    &nbsp;</td>
                <td class="style27">
                </td>
                <td class="style20">
                    &nbsp;</td>
                <td class="style20">
                    &nbsp;</td>
            </tr>
        </table>
    <div>
    
        <table class="style1">
            <tr>
                <td class="style16">
                    Mobile No (10 digit Only)</td>
                <td class="style17">
                    <asp:TextBox ID="TxtLocalMobile" runat="server" Width="162px" MaxLength="10"></asp:TextBox>
                </td>
                <td class="style18">
                    <asp:Label ID="LCourseID" runat="server" Text="0" Visible="False"></asp:Label>
                    <asp:Label ID="LYearID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style18">
                    </td>
            </tr>
            <tr>
                <td class="style3">
                    SMS(Limit 160 Charater =1 SMS)</td>
                <td class="style4" rowspan="2">
                <asp:TextBox textmode="multiline" runat="server" ID ="TxtComments" name="PedEva" 
                        class="div_handelingsplan" style="OVERFLOW:auto; width:502px; height:100px; margin-left: 0px;" 
                        Height="72px" Width="492px" Wrap="False"></asp:TextBox>
                </td>
                <td rowspan="2">
                    &nbsp;</td>
                <td rowspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
    
    </div>
    <table class="style11">
        <tr>
            <td class="style12">
                &nbsp;</td>
            <td>
                <asp:Button ID="ButtonSendMail" runat="server" Height="31px" Text="Send SMS" 
                    Width="140px" style="margin-left: 99px" />
            </td>
        </tr>
    </table>
    <table class="style11">
        <tr>
            <td class="style20">
                    <asp:Label ID="LCount" runat="server" Text="Student Count : 0" Font-Bold="True" 
                        Font-Size="Medium" ForeColor="#FFFF66"></asp:Label>
                </td>
        </tr>
        <tr>
            <td class="style14">
                    <asp:GridView ID="Dgv1" runat="server" BackColor="White" BorderColor="#CC9966" 
                        BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="958px" 
                        AutoGenerateSelectButton="True" style="text-align: center" 
                        Font-Names="Palatino Linotype" Font-Size="Small" EnableCellClick="True" 
                      >
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <EditRowStyle Font-Size="Small" Wrap="False" />
                    </asp:GridView>
                   
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:AttendanceConnectionString %>" 
                    SelectCommand="SELECT [AYear], [FullName], [LEmail], [PEmail] FROM [02Student]">
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
