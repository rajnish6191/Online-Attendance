<script runat="server">

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        LDesg.Text = Session("Desg")
        
        If LDesg.Text = "Lab Assist" Then
            Menu1.Items(0).Enabled = False
            Menu1.Items(1).Enabled = False
            Menu1.Items(2).Enabled = False
            Menu1.Items(3).Enabled = False
            Menu1.Items(4).Enabled = False
            Menu1.Items(5).Enabled = False
            Menu1.Items(6).Enabled = False
            Menu1.Items(7).Enabled = False
            Menu1.Items(8).Enabled = False
        End If
        '-------------------------------------------
        If LDesg.Text = "Lecture" Or LDesg.Text = "Supporting Staff" Or LDesg.Text = "Prof" Then

            Menu1.Items(0).Enabled = False
            Menu1.Items(1).Enabled = False
            Menu1.Items(2).Enabled = False
            Menu1.Items(3).Enabled = False
            Menu1.Items(4).Enabled = False
            Menu1.Items(5).Enabled = False
            Menu1.Items(6).Enabled = True
            Menu1.Items(7).Enabled = True
            Menu1.Items(8).Enabled = False
		
        End If
        
        '-------------------------------------------
        If LDesg.Text = "Associate Prof" Or LDesg.Text = "" Then
       
            Menu1.Items(0).Enabled = True
            Menu1.Items(1).Enabled = True
            Menu1.Items(2).Enabled = True
            Menu1.Items(3).Enabled = True
            Menu1.Items(4).Enabled = True
            Menu1.Items(5).Enabled = True
            Menu1.Items(6).Enabled = True
            Menu1.Items(7).Enabled = True
            Menu1.Items(8).Enabled = True
                 
        End If
        '-------------------------------------------
      

    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs)
        
    End Sub
</script>

<html>
<head>
<title>Attendace Project-2013</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
    <style type="text/css">
        .style3
        {
            height: 63px;
            width: 962px;
        }
        #Table_01
        {
            position: absolute;
            top: 0px;
            left: 90px;
        }
        .style6
        {
            width: 962px;
        }
    </style>
</head>
<body bgcolor="#FFFFFF" leftmargin="0" topmargin="0" marginwidth="0" 
    marginheight="0" style="background-color: #2E2B2B; text-align: center;">
    <form id="form1" runat="server">
<!-- Save for Web Slices (Untitled-2.psd) -->
<table id="Table_01" width="1024" height="819" border="0" cellpadding="0" 
        cellspacing="0" align="center">
	<tr>
		<td class="style3">
			<img src="images/Login_01.gif" width="1021" alt="" align="middle"><asp:Menu 
                ID="Menu1" runat="server" BackColor="#FFFF99" Font-Bold="False" 
                Font-Names="Nina" Font-Overline="False" ForeColor="Red" Height="37px" 
                ItemWrap="True" onmenuitemclick="Menu1_MenuItemClick" Orientation="Horizontal" 
                style="text-align: center; color: #003300; background-color: #99CC00;" 
                Width="1023px">
                <StaticMenuItemStyle ItemSpacing="5px" />
                <DynamicMenuStyle BorderColor="#FFFFCC" BorderStyle="Solid" />
                <Items>
                    <asp:MenuItem NavigateUrl="~/Course.aspx" Text="Course Master" Value="Course">
                    </asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Year.aspx" Text="Year Master" Value="Year">
                    </asp:MenuItem>
                    <asp:MenuItem Text="Subject Master" Value="Subject" 
                        NavigateUrl="~/Subject.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Student Registration" Value="Student Registration" 
                        NavigateUrl="~/StudentReg.aspx">
                    </asp:MenuItem>
                    <asp:MenuItem Text="Staff Registration" Value="Staff Registration" 
                        NavigateUrl="~/StaffReg.aspx">
                    </asp:MenuItem>
                    <asp:MenuItem Text="Staff Assign" Value="Staff Assign" 
                        NavigateUrl="~/SubStaffAssign.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Attendance Login" Value="Attendance Login" 
                        NavigateUrl="~/AttLogin.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Report" Value="Report" NavigateUrl="~/Report.aspx"></asp:MenuItem>
                    <asp:MenuItem Text="Utility" Value="Utility">
                        <asp:MenuItem Text="Roll No" Value="Roll No" 
                            NavigateUrl="~/RollNoGen.aspx">
                        </asp:MenuItem>
                        <asp:MenuItem Text="BatchGeneration" Value="BatchGeneration" 
                            NavigateUrl="~/BatchGen.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="Email" Value="Email" NavigateUrl="~/Mail.aspx"></asp:MenuItem>
                        <asp:MenuItem Text="SMS" Value="SMS" NavigateUrl="~/SMS.aspx"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Log Out" Value="Log Out" NavigateUrl="~/Login.aspx"></asp:MenuItem>
                </Items>
                <StaticItemTemplate>
                    <%# Eval("Text") %>
                </StaticItemTemplate>
            </asp:Menu>
        </td>
		<td rowspan="2">
			<img src="images/Login_02.gif" width="3" height="819" alt=""></td>
	</tr>
	<tr>
		<td style="text-align: center" class="style6">
			<img src="images/Login_28.gif" width="1021" height="666" alt=""></td>
	</tr>
</table>
<!-- End Save for Web Slices -->
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    <asp:Label ID="LDesg" runat="server" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>