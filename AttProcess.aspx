<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AttProcess.aspx.vb" Inherits="AttProcess" %>

<%@ Register assembly="EO.Web" namespace="EO.Web" tagprefix="eo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Attendance Process</title>
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
        }
        .style75
        {
            width: 77px;
            text-align: left;
            height: 22px;
        }
        .style111
        {
            height: 22px;
            width: 1px;
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
        .style118
        {
            width: 263px;
            text-align: right;
            height: 22px;
            font-family: "Poor Richard";
            font-size: large;
        }
        .style120
        {
            width: 77px;
            text-align: right;
            height: 24px;
        }
        .style121
        {
            width: 263px;
            text-align: right;
            height: 24px;
            font-family: "Poor Richard";
            font-size: large;
        }
        .style122
        {
            height: 24px;
            width: 1px;
        }
        .style123
        {
            height: 24px;
            text-align: left;
        }
        .style83
        {
            width: 100%;
        }
        .style87
        {
            width: 898px;
            height: 43px;
            text-align: center;
        }
        .style88
        {
            height: 43px;
        }
        .style124
        {
            width: 77px;
            text-align: right;
        }
        .style125
        {
            text-align: right;
            font-family: "Poor Richard";
            font-size: large;
        }
        .style126
        {
            width: 1px;
        }
        .style127
        {
            height: 43px;
            width: 7px;
        }
        .style132
        {
            width: 928px;
            text-align: center;
        }
        .style139
        {
            width: 928px;
            text-align: center;
            height: 9px;
        }
        .style140
        {
            height: 9px;
        }
        .style141
        {
            width: 77px;
            text-align: left;
            height: 29px;
        }
        .style142
        {
            width: 263px;
            text-align: right;
            height: 29px;
            font-family: "Poor Richard";
            font-size: large;
        }
        .style143
        {
            height: 29px;
            width: 1px;
        }
        .style144
        {
            height: 29px;
        }
        .style148
        {
            height: 18px;
            width: 7px;
        }
        .style149
        {
            width: 898px;
            height: 18px;
            text-align: center;
        }
        .style150
        {
            height: 18px;
        }
        .style152
        {
            width: 559px;
        }
        .style153
        {
            text-align: right;
        }
        .style154
        {
            color: #FFFFFF;
        }
        .style156
        {
            background-color: #666633;
        }
        .style157
        {
            color: #666633;
        }
        </style>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body style="background-color: #666633">
    <form id="form1" runat="server">
    <div>
    
        <h2 class="style82" style="text-align: center">
            <span class="style68">&nbsp;&nbsp; 
            Attendance Entry Form</span></h2>
        <table class="style83">
            <tr>
                <td class="style152">
                    <span class="style157">Welcome to&nbsp;
            </span>
            <asp:Label ID="LStaffName" runat="server" ForeColor="Yellow" Text="Staff Name" 
                        CssClass="style157"></asp:Label>
                </td>
                <td class="style153" style="color: #FFFF00">
                    <span class="style156">
                    <asp:ImageButton ID="ImageButton2" runat="server" 
            ImageUrl="~/Icon/LogOut.jpg" Width="50px"
           OnClick="ImageButton1_Click" CssClass="style157" />
                    </span><span class="style157">|&nbsp;</span><asp:ImageButton ID="ImageButton3" runat="server" 
            ImageUrl="~/Icon/Setting.jpg" Width="50px"
           OnClick="ImageButton1_Click" CssClass="style157" />
                </td>
            </tr>
        </table>
        <table class="style68">
            <tr>
                <td class="style75">
                    <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />
                </td>
                <td class="style118">
                    &nbsp;</td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style91">
                    <asp:Button ID="ButtonNew0" runat="server" Height="40px" Text="Click Start Online Attendance " 
                        Width="212px" BackColor="#FF3300" Font-Bold="True" ForeColor="White" />
                </td>
                <td class="style78">
                    <asp:Button ID="Button1" runat="server" Height="26px" Text="Button" 
                        Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LabelStaffID" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:Label ID="LabelYearID" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="style118">
                    <asp:Label ID="LTAcademicLabel" runat="server" Text="Academic Year" 
                        Visible="False"></asp:Label>
                </td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style91">
                    <asp:Label ID="LabelAcademicYear" runat="server" Text="2012"></asp:Label>
                </td>
                <td class="style78">
                    <asp:DropDownList ID="CBCourse0" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="49px" Visible="False">
                    </asp:DropDownList>
                    <asp:DropDownList ID="CBSemister" runat="server" AutoPostBack="True" 
                        Height="17px" style="margin-left: 0px" Width="43px" Visible="False">
                    </asp:DropDownList>
                    <asp:DropDownList ID="CBYear" runat="server" AutoPostBack="True" 
                        Height="21px" style="margin-left: 0px" Width="37px" Visible="False">
                    </asp:DropDownList>
                    <asp:DropDownList ID="CBCourse" runat="server" AutoPostBack="True" 
                        Height="16px" style="margin-left: 0px" Width="42px" Visible="False">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    <asp:Label ID="LabelCourseID" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:Label ID="LabelSubID" runat="server" Text="Label" Visible="False"></asp:Label>
                    <asp:Label ID="LabelBatch" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td class="style118">
                    <asp:Label ID="LT4" runat="server" Text="Select Subject" Visible="False"></asp:Label>
                </td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBSubject" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    <asp:DropDownList ID="CBYear0" runat="server" AutoPostBack="True" 
                        Height="16px" style="margin-left: 0px" Width="223px" Visible="False">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style118">
                    <asp:Label ID="LT5" runat="server" Text="Attendance Subject Type" 
                        Visible="False"></asp:Label>
                </td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style91">
                    <asp:DropDownList ID="CBSubjectType" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" Visible="False">
                        <asp:ListItem>-- Select Type --</asp:ListItem>
                        <asp:ListItem>Theory</asp:ListItem>
                        <asp:ListItem>Practical</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style78">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style118">
                    <asp:Label ID="LT6" runat="server" Text="Select Batch" Visible="False"></asp:Label>
                </td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style90">
                    <asp:DropDownList ID="CBBatchName" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" Visible="False">
                        <asp:ListItem>-- Select Batch --</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style90">
                    <asp:Button ID="ButtonAttSheetGenerate" runat="server" Height="31px" 
                        Text="Click to New Attedance Sheet Generate" Width="280px" 
                        BackColor="#CCFF33" Font-Bold="True" ForeColor="Red" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="style75">
                    &nbsp;</td>
                <td class="style118">
                    <asp:Label ID="LT7" runat="server" Text="Select Lecture No" Visible="False"></asp:Label>
                </td>
                <td class="style111">
                    &nbsp;</td>
                <td class="style90" colspan="2">
                    <asp:DropDownList ID="CBLectNo" runat="server" AutoPostBack="True" 
                        Height="22px" style="margin-left: 0px" Width="166px" Visible="False">
                        <asp:ListItem>-- Select Attendance --</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style120">
                </td>
                <td class="style121">
                    <asp:Label ID="LT8" runat="server" Text="Date" Visible="False"></asp:Label>
                </td>
                <td class="style122">
                </td>
                <td class="style123" colspan="2">
                    &nbsp;
                    <eo:DatePicker ID="Dtp" runat="server" DisabledDates="" SelectedDates="" 
                        ControlSkinID="None" DayCellHeight="15" DayCellWidth="31" 
                        DayHeaderFormat="Short" OtherMonthDayVisible="True" TitleFormat="dd/MM/yyyy" 
                        TitleLeftArrowImageUrl="DefaultSubMenuIconRTL" 
                        TitleRightArrowImageUrl="DefaultSubMenuIcon" VisibleDate="2013-03-01" 
                        LastMonth="9998-12-01" MaxValidDate="9998-12-31" MinValidDate="1753-01-01" 
                        PickerFormat="dd/MM/yyyy" Visible="False" style="text-align: left">
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
                &nbsp;</td>
            </tr>
            <tr>
                <td class="style141">
                    <asp:Label ID="LDt" runat="server" Text="Ldt" Visible="False"></asp:Label>
                    <asp:Label ID="L1" runat="server" Text="L1" Visible="False"></asp:Label>
                    <asp:Label ID="LT3" runat="server" Text="L1" Visible="False"></asp:Label>
                    <asp:Label ID="LT2" runat="server" Text="L1" Visible="False"></asp:Label>
                    <asp:Label ID="LAtt" runat="server" Text="LAtt" Visible="False"></asp:Label>
                </td>
                <td class="style142">
                    <asp:Label ID="LT9" runat="server" Text="Attendance All (P/A)" Visible="False"></asp:Label>
                </td>
                <td class="style143">
                    &nbsp;</td>
                <td class="style144" colspan="2">
                    &nbsp;<asp:DropDownList ID="CBAttendaceAllPA" runat="server" AutoPostBack="True" 
                        Height="23px" style="margin-left: 0px" Width="166px" Visible="False">
                        <asp:ListItem>-- Select Attendance --</asp:ListItem>
                        <asp:ListItem>Present All</asp:ListItem>
                        <asp:ListItem>Absent All</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:Button ID="ButtonAllPAProcess" runat="server" Height="34px" 
                        Text="Click All P/A Process" Width="160px" BackColor="#006600" 
                        Font-Bold="True" ForeColor="White" Visible="False" />
                </td>
            </tr>
            <tr>
                <td class="style124">
                    <asp:Label ID="LableLAtt" runat="server" Text="L1" Visible="False"></asp:Label>
                    <asp:DropDownList ID="CBAbsentNo" runat="server" AutoPostBack="True" 
                        Height="18px" style="margin-left: 0px" Width="118px" Visible="False">
                    </asp:DropDownList>
                </td>
                <td class="style125">
                    <asp:Label ID="LT10" runat="server" Text="Types Absent Roll No" Visible="False"></asp:Label>
                </td>
                <td class="style126">
                </td>
                <td colspan="2">
                    <asp:TextBox ID="TxtAbsentRollNo" runat="server" Width="168px" Visible="False"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonAbsent" runat="server" Height="32px" Text="Absent" 
                        Width="84px" BackColor="Maroon" Font-Bold="True" ForeColor="#FFFF66" 
                        Visible="False" />
                    <asp:Button ID="ButtonNew1" runat="server" Height="34px" Text="Submit Avg. Calculation Process" 
                        Width="220px" Font-Bold="True" Visible="False" />
                </td>
            </tr>
        </table>
    
    </div>
        <table class="style83">
            <tr>
                <td class="style148">
                    </td>
                <td class="style149">
                    <asp:Button ID="ButtonNew" runat="server" Height="24px" Text="Submit Avg. Calculation Process" 
                        Width="52px" Font-Bold="True" Visible="False" Enabled="False" />
                </td>
                <td class="style150">
                    </td>
            </tr>
            <tr>
                <td class="style127">
                    &nbsp;</td>
                <td class="style87">
                    <asp:GridView ID="Dgv2" runat="server" Width="909px" BackColor="White" 
                        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
                        ForeColor="Black" GridLines="Vertical">
                        <FooterStyle BackColor="#CCCCCC" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <AlternatingRowStyle BackColor="#CCCCCC" />
                    </asp:GridView>
                </td>
                <td class="style88">
                    &nbsp;</td>
            </tr>
            </table>
    <table class="style83">
        <tr>
            <td class="style139">
                </td>
            <td class="style140">
                </td>
        </tr>
        <tr>
            <td class="style132">
                    <asp:GridView ID="Dgv1" runat="server" Width="909px" Visible="False">
                    </asp:GridView>
                </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
