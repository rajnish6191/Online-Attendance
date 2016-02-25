Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Partial Class BatchGen

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

        Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo,Batch  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "' and (Status ='Yes') Order by RollNo Asc", cnn)

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
        CBBatch.Items.Clear()
        Dim b As String = CBYear.Text.Substring(0, 1)
        CBBatch.Items.Add("-- Select Batch --")
        CBBatch.Items.Add(b.ToString & 1)
        CBBatch.Items.Add(b.ToString & 2)
        CBBatch.Items.Add(b.ToString & 3)
        CBBatch.Items.Add(b.ToString & 4)
        '--------------------------------------

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo,Batch  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' and (Status ='Yes') Order by RollNo Asc ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

        '--------------------------------------

    End Sub


    Protected Sub ButtonClickProcessStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClickProcessStart.Click
        '-----------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        Dim myCommand1 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo,Batch  FROM   [02Student] where (Status ='Yes') and AYear='" + CBAcadYear.Text + "' and (RollNo between '" + TxtRollNoStrat.Text + "' and '" + TxtRollNoTo.Text + "')Order by RollNo Asc ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand1.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        '-----------------------------
        Dim i As Integer

        For i = 0 To Dgv1.Rows.Count - 1

            Dim myCommandI As New SqlCommand("UPDATE  [02Student]   SET   Batch ='" + CBBatch.Text + "'  where  (Status ='Yes') and (RecID ='" + Dgv1.Rows(i).Cells(0).Text + "') and (AYear ='" + CBAcadYear.Text + "')", cnn)

            'Try

            cnn.Open()

            myCommandI.ExecuteNonQuery()

            'MsgBox("update")

            cnn.Close()


            'Catch ex As Exception

            'End Try

        Next
        '---------------------------------------------------------------------

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo,Batch  FROM   [02Student] where (Status ='Yes') and AYear='" + CBAcadYear.Text + "' and (RollNo between '" + TxtRollNoStrat.Text + "' and '" + TxtRollNoTo.Text + "')Order by RollNo Asc ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

        '--------------------------------------------------------------
    End Sub


    Protected Sub CBAcadYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBAcadYear.SelectedIndexChanged

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo,Batch  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and (Status ='Yes')Order by RollNo Asc ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        LCount.Text = "Student Count : " & Dgv1.Rows.Count.ToString

    End Sub

End Class
