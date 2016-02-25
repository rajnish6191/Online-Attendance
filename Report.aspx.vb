Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Partial Class Report

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"


    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("Main.aspx")
    End Sub


    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

        CBCourse.Items.Clear()

        CBCourse.Items.Add("-- Select Course --")

        cnn = New SqlConnection(connetionstring)

        Dim myCommand1 As New SqlCommand("SELECT Distinct[Code] FROM [01Class]where Type='Course' ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        While dr.Read()

            CBCourse.Items.Add(dr(0).ToString())

        End While

        cnn.Close()

        CBCourse.DataBind()

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        CBYear.Items.Clear()

        CBYear.Items.Add("-- Select Year --")

        Dim myCommand2 As New SqlCommand("SELECT Distinct[Code] FROM [01Class]where Type='Year' ", cnn)

        cnn.Open()

        Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

        While dr2.Read()

            CBYear.Items.Add(dr2(0).ToString())

        End While

        cnn.Close()

        CBYear.DataBind()

        '-----------------------------------

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' CBReport.Items.Add("-- Select Report --")
      

     

    End Sub


    Protected Sub CBReport_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBReport.SelectedIndexChanged
        Label2.Text = CBReport.Text
        '-------------------------------------
        If CBReport.SelectedIndex = 2 Or CBReport.SelectedIndex = 3 Then
            CBSubject.Visible = True
            Label1.Text = "Select Subject "
            Label1.Visible = True
            CBCourse.Enabled = False
            CBYear.Enabled = False
            '-----------------------------------

            'cnn = New SqlConnection(connetionstring)

            'CBSubject.Items.Clear()

            'Dim myCommand1 As New SqlCommand("SELECT  [04Subject].Short   FROM  [04Subject] CROSS JOIN  [01Class] CROSS JOIN  [01Class] AS [01Class_1] ", cnn)

            'cnn.Open()

            'Dim dr As SqlDataReader = myCommand1.ExecuteReader()

            'While dr.Read()

            '    CBSubject.Items.Add(dr(0).ToString())

            'End While

            'cnn.Close()

            '-----------------------------------
        Else
            CBSubject.Visible = False
            Label1.Text = "Type Detension Less than Per% in REPORT "
        End If
        '-------------------------------------
        If CBReport.SelectedIndex = 4 Then
            CBCourse.Enabled = False
            CBYear.Enabled = False
        Else
            CBCourse.Enabled = True
            CBYear.Enabled = True
        End If
        '----------------------------------------
        If CBReport.SelectedIndex = 5 Then
            Label1.Visible = True
        ElseIf CBReport.SelectedIndex = 2 Or CBReport.SelectedIndex = 3 Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
        '------------------------------------

        If CBSubject.Visible = True Then
            CBType.Visible = True
            LType.Visible = True
        Else
            CBType.Visible = False
            LType.Visible = False
        End If
        '----------------------------------


    End Sub

    Protected Sub CBReport_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBReport.TextChanged
        Label2.Text = CBReport.Text
        '-------------------------------------
        If CBReport.SelectedIndex = 2 Or CBReport.SelectedIndex = 3 Then
            CBSubject.Visible = True
            Label1.Text = "Select Subject "
            Label1.Visible = True
            CBCourse.Enabled = False
            CBYear.Enabled = False
            '-----------------------------------

            cnn = New SqlConnection(connetionstring)

            CBSubject.Items.Clear()

            Dim myCommand1 As New SqlCommand("SELECT  Distinct[Short]   FROM  [04Subject] ", cnn)

            cnn.Open()

            Dim dr As SqlDataReader = myCommand1.ExecuteReader()

            While dr.Read()

                CBSubject.Items.Add(dr(0).ToString())

            End While

            cnn.Close()

            '-----------------------------------
        Else
            CBSubject.Visible = False
            Label1.Text = "Detension Less than Per% "
        End If
        '-------------------------------------
        If CBReport.SelectedIndex = 4 Or CBReport.SelectedIndex = 2 Or CBReport.SelectedIndex = 3 Then
            CBCourse.Enabled = False
            CBYear.Enabled = False
        Else
            CBCourse.Enabled = True
            CBYear.Enabled = True
        End If
        '----------------------------------------
        If CBReport.SelectedIndex = 5 Then
            Label1.Visible = True
        ElseIf CBReport.SelectedIndex = 3 Or CBReport.SelectedIndex = 2 Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
        '------------------------------------

        If CBSubject.Visible = True Then
            CBType.Visible = True
            LType.Visible = True
        Else
            CBType.Visible = False
            LType.Visible = False
        End If
        '----------------------------------
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Session("C") = CBCourse.Text
        Session("Y") = CBYear.Text
        Session("T") = CBReport.SelectedIndex.ToString
        Session("S") = CBSubject.Text
        Session("Type") = CBType.Text
        Response.Redirect("print.aspx")





    End Sub

    Protected Sub CBYear0_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBSubject.SelectedIndexChanged

    End Sub

    Protected Sub CBYear_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.DataBinding
     
    End Sub

    Protected Sub CBYear_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.DataBound
    
    End Sub

    Protected Sub CBYear_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.Init
     
    End Sub

    Protected Sub CBYear_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.Load
    

    End Sub

    Protected Sub CBYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.SelectedIndexChanged
        ''-----------------------------------

        'cnn = New SqlConnection(connetionstring)

        'CBSubject.Items.Clear()

        'Dim myCommand1 As New SqlCommand("SELECT  [04Subject].Short   FROM  [04Subject] CROSS JOIN  [01Class] CROSS JOIN  [01Class] AS [01Class_1]  WHERE     ([01Class].Type = 'Course') AND ([01Class_1].Type = 'Year')and ([01Class].Code='" + CBCourse.Text + "') and ([01Class_1].Code='" + CBYear.Text + "') ", cnn)

        'cnn.Open()

        'Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        'While dr.Read()

        '    CBSubject.Items.Add(dr(0).ToString())

        'End While

        'cnn.Close()

        ''CBSubject.DataBind()

        ''-----------------------------------
        'MsgBox("Selected Index")
    End Sub

    Protected Sub CBYear_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.TextChanged
       
    End Sub

    Protected Sub CBCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBCourse.SelectedIndexChanged

    End Sub
End Class
