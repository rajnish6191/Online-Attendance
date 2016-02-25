<%@ Page Language="VB" AutoEventWireup="false" CodeFile="StudentReg.aspx.vb" Inherits="StudentReg" %>

<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Registration</title>
    <style type="text/css">
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
            width: 138px;
            text-align: left;
            height: 22px;
        }
        .style76
        {
            width: 966px;
            text-align: right;
            height: 22px;
        }
        .style77
        {
            width: 1px;
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
        .style83
        {
            width: 100%;
        }
        .style90
        {
            height: 22px;
            }
        .style91
        {
            height: 22px;
            width: 116px;
        }
        .style82
        {
            color: #FFFFFF;
            font-weight: normal;
        }
        .style92
        {
            width: 138px;
            text-align: right;
            height: 1px;
        }
        .style93
        {
            width: 966px;
            text-align: right;
            height: 1px;
        }
        .style94
        {
            width: 1px;
            height: 1px;
        }
        .style95
        {
            height: 1px;
        }
        .style96
        {
            width: 138px;
            text-align: right;
            height: 18px;
        }
        .style97
        {
            width: 966px;
            text-align: left;
            height: 18px;
        }
        .style98
        {
            width: 1px;
            height: 18px;
        }
        .style99
        {
            height: 18px;
        }
        .style103
        {
            height: 18px;
            }
        .style104
        {
            width: 145px;
            text-align: left;
            background-color: #666633;
        }
        .style86
        {
            width: 205px;
            height: 30px;
        }
        .style87
        {
            width: 708px;
            height: 30px;
            text-align: center;
        }
        .style88
        {
            height: 30px;
        }
        .style84
        {
            text-align: center;
        }
        .style110
        {
            height: 1px;
            width: 116px;
        }
        .style111
        {
            width: 138px;
            text-align: left;
        }
        .style112
        {
            width: 966px;
            text-align: right;
        }
        .style113
        {
            width: 1px;
        }
        .style116
        {
            background-color: #666633;
        }
        .style117
        {
            background-color: #666633;
            font-family: "Poor Richard";
            font-size: 20pt;
        }
        .style118
        {
            height: 22px;
            width: 178px;
        }
        .style119
        {
            height: 18px;
            width: 178px;
        }
        </style>
</head>
<body style="background-color: #666633">
    <form id="form1" runat="server">
    <div>
    
        <h2 class="style82" style="text-align: center">
            <table class="style83">
                <tr>
                    <td class="style104">
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />                  
                    </td>
                    <td class="style116">
            <span class="style117">Student Registration Form&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                         </span></td>
                </tr>
            </table>
        </h2>
    
    </div>
        <table class="style68">
            <tr>
                <td class="style75">
                    <asp:Label ID="LRecID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style76">
                    Academic Year</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBAcadYear" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Academic --</asp:ListItem>
                        <%--<asp:ListItem>2012-2013</asp:ListItem>--%>
                        <asp:ListItem>2013-2014</asp:ListItem>
                        <%--<asp:ListItem>2014-2015</asp:ListItem>--%>
                    </asp:DropDownList>
                </td>
                <td class="style78" colspan="2">
                    <asp:Label ID="LR1" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style96">
                    </td>
                <td class="style97">
                    <asp:Button ID="ButtonNew0" runat="server" Height="30px" Text="View Student List" 
                        Width="154px" style="text-align: center" Visible="False" />
                    </td>
                <td class="style98">
                    </td>
                <td class="style103">
                    (First Name)</td>
                <td class="style99" colspan="2">
                    (Middle Name)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; 
                    (Last Name)</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Name of Student</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtFname" runat="server" Width="163px" MaxLength="40"></asp:TextBox>
                     
                </td>
             
                
                <td class="style78" colspan="2">
                    <asp:TextBox ID="TxtMname" runat="server" Width="162px" MaxLength="40"></asp:TextBox>
                    &nbsp;<asp:TextBox ID="TxtLName" runat="server" Width="162px" MaxLength="40"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LCourseID" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
                <td class="style76">
                    Course Code</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBCourse" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Course --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78" colspan="2">
                    <asp:Label ID="LFullName" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
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
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Year --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78" colspan="2">
                    <asp:Label ID="LCo" runat="server" Text="0" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Status</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBStatus" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    RegNo</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtRegNo" runat="server" Width="162px" MaxLength="10" 
                        Enabled="False"></asp:TextBox>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Roll No</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtRollNo" runat="server" Width="163px" MaxLength="3"></asp:TextBox>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Batch Name</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBBatch" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>-- Select Batch --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Gender</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBGender" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;&nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Date of Birth</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <eo:DatePicker ID="Dtp" runat="server" DisabledDates="" SelectedDates="" 
                        ControlSkinID="None" DayCellHeight="15" DayCellWidth="31" 
                        DayHeaderFormat="Short" OtherMonthDayVisible="True" TitleFormat="dd/MM/yyyy" 
                        TitleLeftArrowImageUrl="DefaultSubMenuIconRTL" 
                        TitleRightArrowImageUrl="DefaultSubMenuIcon" VisibleDate="2013-03-01" 
                        LastMonth="9998-12-01" MaxValidDate="9998-12-31" MinValidDate="1753-01-01" 
                        PickerFormat="dd/MM/yyyy">
                        <TodayStyle CssText="font-family:Verdana;font-size:8pt;background-image:url('00040401');color:#1176db;" />
                        <SelectedDayStyle CssText="font-family:Verdana;font-size:8pt;background-image:url('00040403');color:Brown;" />
                        <DisabledDayStyle CssText="font-family:Verdana;font-size:8pt;color: gray" />
                        <FooterTemplate>
                            <table border="0" cellPadding="0" cellspacing="5" 
                                style="font-size: 11px; font-family: Verdana">
                                <tr>
                                    <td width="30">
                                    </td>
                                    <td valign="center">
                                        <img src="{img:00040401}"></img></td>
                                    <td valign="center">
                                        Today: {var:today:MM/dd/yyyy}</td>
                                </tr>
                            </table>
                        </FooterTemplate>
                        <CalendarStyle CssText="background-color:white;border-bottom-color:Silver;border-bottom-style:solid;border-bottom-width:1px;border-left-color:Silver;border-left-style:solid;border-left-width:1px;border-right-color:Silver;border-right-style:solid;border-right-width:1px;border-top-color:Silver;border-top-style:solid;border-top-width:1px;color:#2C0B1E;padding-bottom:5px;padding-left:5px;padding-right:5px;padding-top:5px;" />
                        <TitleArrowStyle CssText="cursor: hand" />
                        <DayHoverStyle CssText="font-family:Verdana;font-size:8pt;background-image:url('00040402');color:#1c7cdc;" />
                        <MonthStyle CssText="cursor:hand;margin-bottom:0px;margin-left:4px;margin-right:4px;margin-top:0px;" />
                        <TitleStyle CssText="font-family:Verdana;font-size:8.75pt;padding-bottom:5px;padding-left:5px;padding-right:5px;padding-top:5px;" />
                        <DayHeaderStyle CssText="font-family:Verdana;font-size:8pt;border-bottom: #f5f5f5 1px solid" />
                        <DayStyle CssText="font-family:Verdana;font-size:8pt;" />
                    </eo:DatePicker>
                </td>
                <td class="style78" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Local
                    Address</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style80" colspan="3">
                <%-- <asp:TextBox ID="TextBox11" runat="server" Width="496px" Height="55px"></asp:TextBox> '--%>
                <asp:TextBox textmode="multiline" runat="server" ID ="TxtLocalAddress" name="PedEva" 
                        class="div_handelingsplan" style="OVERFLOW:auto; width:380px; height:60px; margin-left: 0px;" 
                        Height="61px" MaxLength="245"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Mobile No</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style91">
                    <asp:TextBox ID="TxtLocalMobile" runat="server" Width="162px" MaxLength="10"></asp:TextBox>
                 </td>
                   <td style="width: 1702px; text-align: left;">
                    <asp:RegularExpressionValidator ID="mNoValidator" 
                    runat="server" ControlToValidate="TxtLocalMobile"
                        ErrorMessage="Mobile Number must be 10 digits(Numerals)" 
                        ValidationExpression="\d+" style="color: #FFFF00">
                        </asp:RegularExpressionValidator></td>
                        
                <td class="style118">
                    &nbsp;</td>
                        
            </tr>
            <tr>
                <td class="style111">
                    </td>
                <td class="style112">
                    Email ID</td>
                <td class="style113">
                    </td>
                <td colspan="3">
                    <asp:TextBox ID="TxtEmail" runat="server" Width="381px" MaxLength="50"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="EmailIDValidation" 
                    runat="server" ControlToValidate="TxtEmail"
                        ErrorMessage="Enter Email ID Properly" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ValidationGroup="val1" style="color: #FFFF00"></asp:RegularExpressionValidator>
                </td>
                        
            </tr>
            <tr>
                <td class="style92">
                    </td>
                <td class="style93">
                    </td>
                <td class="style94">
                    </td>
                <td class="style110">
                    </td>
                <td class="style95" colspan="2">
                    </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    Permenent Address</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="3">
                <asp:TextBox textmode="multiline" runat="server" ID ="TxtPAddress" name="PedEva" 
                        class="div_handelingsplan" style="OVERFLOW:auto; width:380px; height:60px; margin-left: 0px;" 
                        Height="94px" MaxLength="245"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style76">
                    &nbsp;Mobile No</td>
                <td class="style77">
                    &nbsp;</td>
                <td class="style90" colspan="3">
                    <asp:TextBox ID="TxtPMobile" runat="server" Width="162px" MaxLength="10"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                    runat="server" ControlToValidate="TxtPMobile"
                        ErrorMessage="Mobile Number must be 10 digits(Numerals)" 
                        ValidationExpression="\d+" style="color: #FFFF00">
                        </asp:RegularExpressionValidator>
                </td>
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
                    <asp:TextBox ID="TxtPEmail" runat="server" Width="381px" MaxLength="50"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" 
                    runat="server" ControlToValidate="TxtPEmail"
                        ErrorMessage="Enter Email ID Properly" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ValidationGroup="val1" style="color: #FFFF00"></asp:RegularExpressionValidator>
                </td>
                </td>
            </tr>
            <tr>
                <td class="style96">
                    </td>
                <td class="style97">
                    &nbsp;</td>
                <td class="style98">
                    </td>
                <td class="style103" colspan="2">
                    <asp:Label ID="LabelMessage" runat="server" Font-Bold="True" 
                        ForeColor="#CCFF66"></asp:Label>
                    </td>
                <td class="style119">
                    <asp:Button ID="ButtonExit0" runat="server" Height="22px" Text="Edit Delete ON/Off" 
                        Width="128px" BackColor="DarkGreen" ForeColor="White" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            </table>
        <table class="style83">
            <tr>
                <td class="style86">
                    <asp:Button ID="ButtonNew1" runat="server" Height="30px" Text="Email Tools" 
                        Width="84px" />
                &nbsp;<asp:Button ID="ButtonNew2" runat="server" Height="30px" Text="SMS Tools" 
                        Width="84px" />
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
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style84" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style84" colspan="3">
                    <asp:GridView ID="Dgv2" runat="server" BackColor="White" BorderColor="#CC9966" 
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
    <p>
&nbsp;&nbsp;&nbsp;
                    <asp:GridView ID="Dgv1" runat="server" BackColor="White" BorderColor="#CC9966" 
                        BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="958px" 
                        AutoGenerateSelectButton="True" style="text-align: center" 
                        Font-Names="Palatino Linotype" Font-Size="Small" Visible="False" 
                      >
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <EditRowStyle Font-Size="Small" Wrap="False" />
                    </asp:GridView>
                   
                </p>
    </form>
</body>
</html>
