<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Master.aspx.vb" Inherits="Master" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style82
        {
            color: #FFFFFF;
            font-weight: normal;
        }
        .style3
        {
            background-color: #666633;
            font-family: "Poor Richard";
            font-size: xx-large;
            z-index: 1;
            left: 211px;
            top: 15px;
            position: absolute;
        }
        .style83
        {
            width: 100%;
            height: 444px;
        }
        .style86
        {
            font-family: "Trebuchet MS";
            font-size: x-large;
            color: #FFFFCC;
            height: 63px;
            text-align: center;
            background-color: #000000;
        }
        .style89
        {
            width: 20px;
            font-family: Nina;
            font-size: large;
            height: 38px;
            text-align: center;
        }
        .style90
        {
            color: #CCFF33;
            font-family: "Poor Richard";
            font-size: large;
            height: 38px;
            font-weight: bold;
            text-align: left;
        }
        .style91
        {
            width: 20px;
            font-family: Nina;
            font-size: large;
            height: 16px;
            text-align: center;
        }
        .style92
        {
            color: #CCFF33;
            font-family: "Poor Richard";
            font-size: large;
            height: 16px;
            font-weight: bold;
            text-align: left;
        }
        .style93
        {
            width: 20px;
            font-family: Nina;
            font-size: large;
            height: 12px;
            text-align: center;
        }
        .style94
        {
            color: #FFFF00;
            font-family: Nina;
            font-size: large;
            height: 12px;
            text-align: left;
        }
        .style95
        {
            width: 20px;
            font-family: Nina;
            font-size: large;
            height: 29px;
        }
        .style96
        {
            color: #CCFF33;
            font-family: "Poor Richard";
            font-size: large;
            height: 29px;
            font-weight: bold;
            text-align: left;
        }
        .style101
        {
            width: 20px;
            font-family: Nina;
            font-size: large;
            height: 31px;
        }
        .style102
        {
            color: #CCFF33;
            font-family: "Poor Richard";
            font-size: large;
            height: 31px;
            font-weight: bold;
            text-align: left;
        }
        .style103
        {
            width: 20px;
            font-family: Nina;
            font-size: large;
            height: 30px;
        }
        .style104
        {
            color: #CCFF33;
            font-family: "Poor Richard";
            font-size: large;
            height: 30px;
            font-weight: bold;
            text-align: left;
        }
        .style105
        {
            color: #CCFF33;
            font-family: "Poor Richard";
            font-size: large;
            font-weight: bold;
            text-align: left;
        }
        .style106
        {
            width: 20px;
            font-family: Nina;
            font-size: large;
            color: #FFFFCC;
        }
        .style107
        {
            color: #FFFFCC;
        }
        .style108
        {
            color: #FFFF00;
            text-align: right;
        }
        .style110
        {
            width: 20px;
            font-family: "Poor Richard";
            font-size: large;
            font-weight: bold;
            text-align: right;
        }
        .style111
        {
            width: 20px;
            font-family: Nina;
            font-size: large;
            text-align: center;
        }
        .style112
        {
            color: #FFFF00;
            font-family: Nina;
            font-size: large;
            text-align: left;
        }
        .style113
        {
            color: #CCFF33;
            background-color: #003300;
        }
        .style114
        {
            text-align: center;
            background-color: #003300;
        }
    </style>
</head>
<body style="background-color: #666633">
    <form id="form1" runat="server">
    <div>
    
        <h2 class="style82" style="text-align: center">
            <span class="style3">Automation For Management System - 2013</span></h2>
        <p class="style82" style="text-align: center">
            &nbsp;</p>
        <p class="style82" style="text-align: center">
            &nbsp;</p>
        <asp:Panel ID="Panel1" runat="server" Height="455px" Width="192px" 
            CssClass="style114">
            <table class="style83">
                <tr>
                    <td class="style86" colspan="2">
                        <span class="style107">Main Menu&nbsp; &nbsp;</span></td>
                </tr>
                <tr>
                    <td class="style89">
                    </td>
                    <td class="style90">
                        <a href="Course.aspx"><span class="style108">Course Master</span></a></td>
                </tr>
                <tr>
                    <td class="style91">
                    </td>
                    <td class="style92">
                        <a href="Year.aspx"><span class="style108">Year Master</span></a></td>
                </tr>
                <tr>
                    <td class="style93">
                    </td>
                    <td class="style94">
                    </td>
                </tr>
                <tr>
                    <td class="style95">
                    </td>
                    <td class="style96">
                        <a href="StudentReg.aspx"><span class="style108">Student Registration</span></a></td>
                </tr>
                <tr>
                    <td class="style106">
                        &nbsp;</td>
                    <td class="style105">
                        <a href="StaffReg.aspx"><span class="style108">Staff Registration</span></a></td>
                </tr>
                <tr>
                    <td class="style106">
                        &nbsp;</td>
                    <td class="style105">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style101">
                    </td>
                    <td class="style102">
                        <a href="Subject.aspx"><span class="style108">Subject Master</span></a></td>
                </tr>
                <tr>
                    <td class="style103">
                    </td>
                    <td class="style104">
                        <a href="RollNoGen.aspx"><span class="style108">Roll No Generation</span></a></td>
                </tr>
                <tr>
                    <td class="style106">
                        &nbsp;</td>
                    <td class="style105">
                        <a href="BatchGen.aspx"><span class="style108">Batch Generation</span></a></td>
                </tr>
                <tr>
                    <td class="style106">
                        &nbsp;</td>
                    <td class="style105">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style106">
                        &nbsp;</td>
                    <td class="style105">
                        <a href="AttLogin.aspx"><span class="style108">Attendance Login</span></a></td>
                </tr>
                <tr>
                    <td class="style111">
                        </td>
                    <td class="style112">
                        </td>
                </tr>
                <tr>
                    <td class="style110">
                        &nbsp;</td>
                    <td class="style105">
                        <a href="Default.aspx"><span class="style113">Log Out</span></a></td>
                </tr>
            </table>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
