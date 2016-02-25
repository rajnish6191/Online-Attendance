<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Report.aspx.vb" Inherits="Report" %>

<%@ Register assembly="CrystalDecisions.Web, Version=12.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Report Master</title>
    <style type="text/css">

        .style117
        {
            background-color: #333300;
            font-family: "Poor Richard";
            font-size: 20pt;
        }
        .style118
        {
            color: #FFFF99;
            font-size: xx-large;
        }
        .style119
        {
            width: 100%;
        }
        .style120
        {
            width: 339px;
            text-align: right;
            color: #FFFFFF;
            font-size: large;
        }
        .style121
        {
            width: 382px;
            font-size: large;
        }
        .style122
        {
            width: 339px;
            color: #FFFFFF;
            font-size: x-large;
            text-align: right;
        }
    </style>
</head>
<body style="background-color: #333300">
    <form id="form1" runat="server">
    <div>
    
           <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/Icon/images.jpg" Width="50px"
           OnClick="ImageButton1_Click" />                  
            <span class="style117">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <span class="style118">Report Master</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
           <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <br />
           </span>
    
           <table class="style119">
               <tr>
                   <td class="style122">
                       Select Report&nbsp;&nbsp; </td>
                   <td class="style121">
                       <asp:DropDownList ID="CBReport" runat="server" AutoPostBack="True" 
                           Height="39px" style="font-size: large" Width="308px">
                           <asp:ListItem>-- Select Report --</asp:ListItem>
                           <asp:ListItem>Roll Call &amp; Batch List</asp:ListItem>
                           <asp:ListItem>Subject Wise Attendance</asp:ListItem>
                           <asp:ListItem>Lecture/Monthly Attendance </asp:ListItem>
                           <asp:ListItem>Staff List</asp:ListItem>
                           <asp:ListItem>Detension List</asp:ListItem>
                       </asp:DropDownList>
                   </td>
                   <td>
                       <asp:Label ID="Label2" runat="server" style="color: #FFFFFF" 
                           Text="Detension Less than Per%   " Visible="False"></asp:Label>
                   </td>
               </tr>
               <tr>
                   <td class="style120">
                       Select Course&nbsp;&nbsp; </td>
                   <td class="style121">
                       <asp:DropDownList ID="CBCourse" runat="server" Height="31px" 
                           style="font-size: large" Width="200px">
                       </asp:DropDownList>
                   </td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td class="style120">
                       Select Year&nbsp;&nbsp; </td>
                   <td class="style121">
                       <asp:DropDownList ID="CBYear" runat="server" Height="32px" 
                           style="font-size: large" Width="200px">
                       </asp:DropDownList>
                   </td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td class="style120">
                       <asp:Label ID="Label1" runat="server" Text="Detension Less than Per%   " 
                           Visible="False"></asp:Label>
                   </td>
                   <td class="style121">
                       <asp:DropDownList ID="CBSubject" runat="server" Height="32px" 
                           style="font-size: large" Width="200px" Visible="False">
                       </asp:DropDownList>
                   </td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td class="style120">
                       <asp:Label ID="LType" runat="server" Text="Type" 
                           Visible="False"></asp:Label>
                   </td>
                   <td class="style121">
                       <asp:DropDownList ID="CBType" runat="server" Height="32px" 
                           style="font-size: large" Width="200px" Visible="False">
                           <asp:ListItem>Theory</asp:ListItem>
                           <asp:ListItem>Practical</asp:ListItem>
                       </asp:DropDownList>
                   </td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td class="style120">
                       &nbsp;</td>
                   <td class="style121">
                       <asp:Button ID="Button1" runat="server" Height="41px" style="font-size: large" 
                           Text="View Report" Width="199px" />
                   </td>
                   <td>
                       &nbsp;</td>
               </tr>
               <tr>
                   <td class="style120">
                       &nbsp;</td>
                   <td class="style121">
                       &nbsp;</td>
                   <td>
                       &nbsp;</td>
               </tr>
           </table>
    
    </div>
    </form>
</body>
</html>
