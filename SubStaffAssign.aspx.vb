Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Partial Class SubStaffAssign

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"

  
    Protected Sub ButtonExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.Click

        Response.Redirect("Main.aspx")

    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init

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

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT RecID, FullName   FROM    [03Staff]   ", cnn)

        cnn.Open()

        Dim dr3 As SqlDataReader = myCommand3.ExecuteReader()

        While dr3.Read()

            CBAssignTeacher.Items.Add(dr3(1).ToString())

        End While

        cnn.Close()

        CBAssignTeacher.DataBind()

        '-----------------------------------

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cnn = New SqlConnection(connetionstring)

        '  Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear, Code, Name, Short, Course, Year, Sem, Type, Th, Pr, [Or], Tw, StaffID   FROM  [04Subject] where AYear='" + CbAcadYear.Text + "' ", cnn)

        Dim myCommand3 As New SqlCommand("SELECT [04Subject].RecID,  [04Subject].Code, [04Subject].Short, [01Class].Code AS Year, [01Class_1].Code AS Course, [04Subject].Sem,[04Subject].Type, [04Subject].Th, [04Subject].Pr, [04Subject].[Or], [04Subject].Tw, [03Staff].FullName AS StaffName  FROM  [04Subject] INNER JOIN  [03Staff] ON [04Subject].StaffID = [03Staff].RecID INNER JOIN  [01Class] ON [04Subject].Year = [01Class].RecNo INNER JOIN  [01Class] AS [01Class_1] ON [04Subject].Course = [01Class_1].RecNo   WHERE     ([01Class].Type = 'Year') AND ([01Class_1].Type = 'Course') ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        '-----------------------------------


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

        CBSubject.Items.Clear()

        CBSubject.Items.Add("--Subject--")

        Dim myCommand2 As New SqlCommand("SELECT Code,Short  FROM [04Subject]  where  Course='" + LCourseID.Text + "' and Year='" + LYearID.Text + "'", cnn)

        cnn.Open()

        Dim dr1 As SqlDataReader = myCommand2.ExecuteReader()

        While dr1.Read()

            CBSubject.Items.Add(dr1(1).ToString())

        End While

        cnn.Close()

        CBSubject.DataBind()

        '-----------------------------------
    End Sub

    Protected Sub CBCourse1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBCourse.SelectedIndexChanged

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

    End Sub

    Protected Sub CBAssignTeacher_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBAssignTeacher.SelectedIndexChanged

        LStaffID.Text = ""

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT RecID, FullName   FROM    [03Staff] where  FullName='" + CBAssignTeacher.Text + "'  ", cnn)

        cnn.Open()

        Dim dr3 As SqlDataReader = myCommand3.ExecuteReader()

        While dr3.Read()

            LStaffID.Text = (dr3(0).ToString())

        End While

        cnn.Close()

        LStaffID.DataBind()

        '-----------------------------------

    End Sub


    Protected Sub CBAssignTeacher_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBAssignTeacher.TextChanged

        LStaffID.Text = ""

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT RecID, FullName   FROM    [03Staff] where  FullName='" + CBAssignTeacher.Text + "'  ", cnn)

        cnn.Open()

        Dim dr3 As SqlDataReader = myCommand3.ExecuteReader()

        While dr3.Read()

            LStaffID.Text = (dr3(0).ToString())

        End While

        cnn.Close()

        LStaffID.DataBind()

        '-----------------------------------
    End Sub


    Protected Sub CBSemister_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBSemister.SelectedIndexChanged


        cnn = New SqlConnection(connetionstring)

        CBSubject.Items.Clear()

        Dim myCommand1 As New SqlCommand("SELECT Code,Short  FROM [04Subject]  where  Course='" + LCourseID.Text + "' and Year='" + LYearID.Text + "'", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        While dr.Read()

            CBSubject.Items.Add(dr(1).ToString())

        End While

        cnn.Close()

        CBSubject.DataBind()

        '-----------------------------------
    End Sub

    Protected Sub CBSubject_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBSubject.SelectedIndexChanged

        cnn = New SqlConnection(connetionstring)

        txtCodeSubject.Text = ""

        Dim myCommand1 As New SqlCommand("SELECT Code  FROM [04Subject]  where  Short='" + CBSubject.Text + "'", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        While dr.Read()

            txtCodeSubject.Text = (dr(0).ToString())

        End While

        cnn.Close()

        txtCodeSubject.DataBind()

        '-----------------------------------
    End Sub

    Protected Sub CBCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBCourse.SelectedIndexChanged

    End Sub

    Protected Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        '-----------------------------

        Dim myCommandI As New SqlCommand("UPDATE  [04Subject]  SET   StaffID='" + LStaffID.Text + "'  where   ( Code='" + txtCodeSubject.Text + "') ", cnn)

        'Try

        cnn.Open()

        myCommandI.ExecuteNonQuery()

        MsgBox("Staff Update Successfully")

        cnn.Close()

        'Catch ex As Exception

        'End Try

        '-----------------------------------

        Try

            cnn = New SqlConnection(connetionstring)

            '  Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear, Code, Name, Short, Course, Year, Sem, Type, Th, Pr, [Or], Tw, StaffID   FROM  [04Subject] where AYear='" + CbAcadYear.Text + "' ", cnn)

            Dim myCommand3 As New SqlCommand("SELECT [04Subject].RecID, [04Subject].AYear, [04Subject].Code, [04Subject].Short, [01Class].Code AS Year, [01Class_1].Code AS Course, [04Subject].Sem,[04Subject].Type, [04Subject].Th, [04Subject].Pr, [04Subject].[Or], [04Subject].Tw, [03Staff].FullName AS StaffName  FROM  [04Subject] INNER JOIN  [03Staff] ON [04Subject].StaffID = [03Staff].RecID INNER JOIN  [01Class] ON [04Subject].Year = [01Class].RecNo INNER JOIN  [01Class] AS [01Class_1] ON [04Subject].Course = [01Class_1].RecNo   WHERE     ([01Class].Type = 'Year') AND ([01Class_1].Type = 'Course') ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()
            '-----------------------------------------

        Catch ex As Exception

        End Try

        '   End If

        ' End If

    End Sub
End Class
