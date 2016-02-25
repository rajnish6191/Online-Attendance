
Partial Class print
    Inherits System.Web.UI.Page

    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Label1.Text = Session("C") '''' Course
        Label2.Text = Session("Y") ''''' Year
        Label3.Text = Session("T") ''''' Report Type or Report Name
        Label4.Text = Session("S") ''''' Subject
        Label5.Text = Session("Type") '''' ThPr Type

        'Response.Redirect("Roll.rpt")
        ' CrystalReportViewer1.ReportSource = "D:\1.3.2013\updates\Online Attendance\Online Attendance\Report\Roll.rpt"

        If Label3.Text = 1 Then '''''''''''''''''' Roll Call
            CrystalReportViewer1.ReportSource = "Report/Roll.rpt"
            CrystalReportViewer1.SelectionFormula = "{01Class.Type} = 'Course' and {01Class_1.Type} = 'Year' and {01Class.Code} = '" + Label1.Text + "' and  {01Class_1.Code} =  '" + Label2.Text + "'  "
        End If

        If Label3.Text = 2 Then '''''''''''''''''' Subject
            CrystalReportViewer1.ReportSource = "Report/subjectwise.rpt"
            CrystalReportViewer1.SelectionFormula = "{01Class_1.Type} = 'Year' and  {01Class.Type} = 'Course' and  {04Subject.Short} = '" + Label4.Text + "' and {05AttSheet.ThPr} = '" + Label5.Text + "'"
        End If

        If Label3.Text = 3 Then '''''''''''''''''' Lecture/MonthlyAtt
            CrystalReportViewer1.ReportSource = "Report/Lect.rpt"
            CrystalReportViewer1.SelectionFormula = "{01Class_1.Type} = 'Year' and  {01Class.Type} = 'Course' and  {04Subject.Short} = '" + Label4.Text + "' and {05AttSheet.ThPr} = '" + Label5.Text + "'"
        End If

        If Label3.Text = 4 Then
            CrystalReportViewer1.ReportSource = "Report/stafflist.rpt" ''''--------Staff List
            ' CrystalReportViewer1.SelectionFormula = "{01Class.Type} = 'Course' and {01Class_1.Type} = 'Year' and {01Class.Code} = '" + Label1.Text + "' and  {01Class_1.Code} =  '" + Label2.Text + "'  "
        End If

        If Label3.Text = 5 Then
            CrystalReportViewer1.ReportSource = "Report/Detension.rpt" '''''''  Detension
            CrystalReportViewer1.SelectionFormula = "{01Class_1.Type} = 'Course' and  {01Class.Code} = '" + Label2.Text + "'  and  {01Class.Type} = 'Year' and  {01Class_1.Code} = '" + Label1.Text + "'"
        End If


        CrystalReportViewer1.RefreshReport()
        ''  xform.CrystalReportViewer2.ExportReport()
        'xform.CrystalReportViewer2.PrintReport()
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("Report.aspx")
    End Sub
End Class
