Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Imports System.IO.File

Imports System.IO


Partial Class SMS

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"


    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        Response.Redirect("Main.aspx")

    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        '  CBCourse.Items.Clear()

        Dim myCommand1 As New SqlCommand("SELECT Code FROM [01Class]where Type='Course' ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        While dr.Read()

            CBCourse.Items.Add(dr(0).ToString())

        End While

        cnn.Close()

        CBCourse.DataBind()

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        '  CBYear.Items.Clear()

        Dim myCommand2 As New SqlCommand("SELECT Code FROM [01Class]where Type='Year' ", cnn)

        cnn.Open()

        Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

        While dr2.Read()

            CBYear.Items.Add(dr2(0).ToString())

        End While

        cnn.Close()

        CBYear.DataBind()

        '-----------------------------------

    End Sub

    Protected Sub CBCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBCourse.SelectedIndexChanged

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        LCourseID.Text = ""

        Dim myCommand1 As New SqlCommand("SELECT RecNo FROM [01Class]where Type='Course' and Code='" + CBCourse.Text + "' ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        While dr.Read()

            LCourseID.Text = (dr(0).ToString())

        End While

        cnn.Close()

        LCourseID.DataBind()

        '-----------------------------------
        Try
            cnn.Close()
        Catch ex As Exception

        End Try

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT AYear'AcademicYear', RegNo, FullName , LMo   FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "' and (Status ='Yes') Order by RollNo Asc", cnn)
        '  Dim myCommand3 As New SqlCommand("SELECT 0,  RegNo  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "' and (Status ='Yes') Order by RollNo Asc", cnn)
        Dim dt1 As New DataTable
        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

        '------------------------------------

        'Dim myCommand = New SqlDataAdapter("SQL COMMAND HERE", CONNECTION HERE)
        'Dim ds As Data.DataSet = New Data.DataSet
        'myCommand.Fill(ds)
        'GridView1.DataSource = ds
        'GridView1.DataBind()
        'myCommand.dispose()

    End Sub


    Protected Sub CBYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.SelectedIndexChanged
        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        LYearID.Text = ""

        Dim myCommand1 As New SqlCommand("SELECT RecNo FROM [01Class]where Type='Year' and Code='" + CBYear.Text + "' ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        While dr.Read()

            LYearID.Text = (dr(0).ToString())

        End While

        cnn.Close()

        LYearID.DataBind()

        '-----------------------------------
        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT  AYear'AcademicYear', RegNo, FullName , LMo  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' and (Status ='Yes') ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

        '--------------------------------------

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'CBAcadYear.Text = "2012-2013"

            CBAcadYear.Text = Session("AcademicYear")

        Catch ex As Exception

        End Try

    End Sub

    Protected Sub Dgv1_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv1.DataBinding
      
    End Sub

    Protected Sub Dgv1_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv1.Init
       
    End Sub

    Protected Sub Dgv1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv1.Load
      
    End Sub

    Protected Sub Dgv1_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles Dgv1.RowCommand
        'Try
        '    If Dgv1.SelectedRow.Cells(4).Text = "&nbsp;" Or Dgv1.SelectedRow.Cells(4).Text = "" Then
        '        'MsgBox("blank")
        '    Else
        '        '  If Dgv1.SelectedRow.Cells(4).Text <> "&nbsp;" Or Dgv1.SelectedRow.Cells(4).Text <> "" Then


        '        TxtLocalMobile.Text = Dgv1.SelectedRow.Cells(4).Text.ToString()


        '        'End If

        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub Dgv1_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles Dgv1.RowDataBound
        Try
            Select Case e.Row.RowType
                Case DataControlRowType.DataRow
                    e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(Dgv1, "Select$" & e.Row.RowIndex))
            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dgv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv1.SelectedIndexChanged
        Try
            If Dgv1.SelectedRow.Cells(4).Text = "&nbsp;" Or Dgv1.SelectedRow.Cells(4).Text = "" Then
                'MsgBox("blank")
            Else
                '  If Dgv1.SelectedRow.Cells(4).Text <> "&nbsp;" Or Dgv1.SelectedRow.Cells(4).Text <> "" Then


                TxtLocalMobile.Text = Dgv1.SelectedRow.Cells(4).Text.ToString()


                'End If

            End If
        Catch ex As Exception

        End Try


    End Sub

End Class
