Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Imports System.IO.File

Imports System.IO



Partial Class RollNoGen

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"


    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("Main.aspx")
    End Sub


    Protected Sub ButtonExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
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

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'cnn = New SqlConnection(connetionstring)

        'Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and (Status ='Yes') ", cnn)

        'cnn.Open()

        'Dgv1.DataSource = myCommand3.ExecuteReader()

        'Dgv1.DataBind()

        'cnn.Close()

        '-----------------------------------

    End Sub

    Protected Sub CBAcadYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBAcadYear.SelectedIndexChanged

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and (Status ='Yes') Order by RollNo Asc", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

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

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "' and (Status ='Yes') Order by RollNo Asc", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

        '------------------------------------

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

        Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' and (Status ='Yes') ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

        '--------------------------------------

    End Sub

    Protected Sub CBRollSortBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBRollSortBy.SelectedIndexChanged
        '-----------------------------------
        cnn = New SqlConnection(connetionstring)

        '   Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' ", cnn)

        If CBRollSortBy.SelectedIndex = 1 Then

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where (Status ='Yes') and AYear='" + CBAcadYear.Text + "'  and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' Order by FName Asc ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

        ElseIf CBRollSortBy.SelectedIndex = 2 Then

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where  (Status ='Yes') and AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "'  Order by MName Asc ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

        ElseIf CBRollSortBy.SelectedIndex = 3 Then

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where  (Status ='Yes') and AYear='" + CBAcadYear.Text + "'and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "'  Order by LName Asc", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

        End If
      
        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

        '--------------------------------------

    End Sub

    Protected Sub ButtonClickProcessStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClickProcessStart.Click
        '-----------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        '-----------------------------
        Dim i, r As Integer

        For i = 0 To Dgv1.Rows.Count - 1

            r = Val(txtRollNoStart.Text) + i

            Dim myCommandI As New SqlCommand("UPDATE  [02Student]   SET   RollNo ='" + r.ToString + "'  where  (Status ='Yes') and (RecID ='" + Dgv1.Rows(i).Cells(0).Text + "') and (AYear ='" + CBAcadYear.Text + "')", cnn)

            'Try

            cnn.Open()

            myCommandI.ExecuteNonQuery()

            'MsgBox("update")

            cnn.Close()


            'Catch ex As Exception

            'End Try

        Next
        '---------------------------------------------------------------------

        If CBRollSortBy.SelectedIndex = 1 Then

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where  AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' and (Status ='Yes') Order by FName Asc ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

        ElseIf CBRollSortBy.SelectedIndex = 2 Then

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where   AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' and (Status ='Yes')   Order by MName Asc ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

        ElseIf CBRollSortBy.SelectedIndex = 3 Then

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo  FROM   [02Student] where   AYear='" + CBAcadYear.Text + "'  and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' and (Status ='Yes')  Order by LName Asc", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

        End If

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

        '--------------------------------------------------------------
    End Sub

   
End Class
