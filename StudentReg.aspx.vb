Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Partial Class StudentReg

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=server"


    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        Response.Redirect("Main.aspx")

    End Sub

    Protected Sub ButtonExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.Click

        Response.Redirect("Main.aspx")

    End Sub

    Protected Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        TxtFname.Text = TxtFname.Text.ToUpper
        TxtMname.Text = TxtMname.Text.ToUpper
        TxtLName.Text = TxtLName.Text.ToUpper
        '-----------------------------------


        If CBAcadYear.Text <> "" And TxtFname.Text <> "" And TxtMname.Text <> "" And TxtLName.Text <> "" And CBCourse.SelectedIndex <> 0 And CBYear.SelectedIndex <> 0 Then

            TxtRegNo.Text = TxtRegNo.Text.ToUpper
            '-----------------------------------

            cnn = New SqlConnection(connetionstring)

            'CBSearch.Items.Clear()

            Dim myCommand1 As New SqlCommand("SELECT  Max(RecID) FROM  [02Student] where AYear='" + CBAcadYear.Text + "'", cnn)

            cnn.Open()

            Dim dr As SqlDataReader = myCommand1.ExecuteReader()

            'If dr.Read = True Then

            '    txtCode.Text = (dr(2).ToString())

            'End If

            While dr.Read()

                'CBSearch.Items.Add(dr(1).ToString())

                LRecID.Text = (dr(0).ToString())

            End While

            cnn.Close()

            LRecID.Text = Val(LRecID.Text) + 1
            '-----------------------------------
            Dim a, b As String
            a = CBAcadYear.Text.Substring(2, 2)
            b = CBAcadYear.Text.Substring(7, 2)
            LR1.Text = a.ToString & b.ToString

            LCo.Text = CBCourse.Text.Substring(0, 2) & LR1.Text

            If Val(LRecID.Text) >= 1 And Val(LRecID.Text) <= 9 Then
                TxtRegNo.Text = LCo.Text & "00" & LRecID.Text
            ElseIf Val(LRecID.Text) >= 10 And Val(LRecID.Text) <= 99 Then
                TxtRegNo.Text = LCo.Text & "0" & LRecID.Text
            Else
                TxtRegNo.Text = LCo.Text & LRecID.Text
            End If

            '------------------------------------
            '------------------------------------------

            Dim myCommand2 As New SqlCommand("SELECT RecID FROM [02Student]  where (RegNo='" + TxtRegNo.Text + "') or ( AYear='" + CBAcadYear.Text + "') and (  FName='" + TxtFname.Text + "' and MName='" + TxtMname.Text + "' and LName='" + TxtLName.Text + "') ", cnn)

            cnn.Open()

            Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

            If dr2.Read = True Then

                LabelMessage.Text = "Duplicate Entry"
                '  MsgBox("Duplicate Entry", MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "Error")


            Else
                '-----------------------------------------------

                'Dim cnn As SqlConnection

                cnn = New SqlConnection(connetionstring)

                cnn.Close()
                '-----------------------------  
                ' Dim dt As String = Dtp.SelectedDate.Year & "/" & Dtp.SelectedDate.Month & "/" & Dtp.SelectedDate.Day
                Dim dt1 As String = Dtp.SelectedDate.Date.ToString
                LFullName.Text = TxtFname.Text & " " & TxtMname.Text & " " & TxtLName.Text

                Dim myCommandI As New SqlCommand("INSERT INTO [02Student] (RecID, AYear, RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender, DOB, LAdd, LMo, LEmail, PAdd, PMo, PEmail, FullName) VALUES ('" + LRecID.Text + "', '" + CBAcadYear.Text + "', '" + TxtRegNo.Text + "', '" + TxtFname.Text + "', '" + TxtMname.Text + "', '" + TxtLName.Text + "', '" + LCourseID.Text + "', '" + LYearID.Text + "', '" + CBStatus.Text + "', '" + TxtRollNo.Text + "', '" + CBBatch.Text + "', '" + CBGender.Text + "', '" + dt1.ToString + "', '" + TxtLocalAddress.Text + "', '" + TxtLocalMobile.Text + "', '" + TxtEmail.Text + "', '" + TxtPAddress.Text + "', '" + TxtPMobile.Text + "', '" + TxtPEmail.Text + "', '" + LFullName.Text + "') ", cnn)

                '  Try

                cnn.Open()

                myCommandI.ExecuteNonQuery()

                'MsgBox("Ok")
                LabelMessage.Text = "Saved Successfully"

                cnn.Close()

                'Catch ex As Exception

                'End Try

                '-----------------------------------

                'Try

                '    cnn = New SqlConnection(connetionstring)

                '    Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender,  LMo, LEmail, PMo, PEmail  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' ", cnn)

                '    cnn.Open()

                '    Dgv1.DataSource = myCommand3.ExecuteReader()

                '    Dgv1.DataBind()

                '    cnn.Close()

                '    '---------------------------------

                'Catch ex As Exception

                'End Try

            End If

            TxtRegNo.Text = ""
            TxtFname.Text = ""
            TxtMname.Text = ""
            TxtLName.Text = ""
            LCourseID.Text = ""
            LYearID.Text = ""
            CBStatus.SelectedIndex = 0
            TxtRollNo.Text = ""
            CBBatch.SelectedIndex = 0
            CBGender.SelectedIndex = 0
            TxtLocalAddress.Text = ""
            TxtLocalMobile.Text = ""
            TxtEmail.Text = ""
            TxtPAddress.Text = ""
            TxtPMobile.Text = ""
            TxtPEmail.Text = ""
            ' Dtp.SelectedDate = ""

            TxtFname.Focus()

        End If

    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        '-----------------------------------
        Dtp.SelectedDate = Now.Date
        Dtp.DataBind()
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

        'Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender,  LMo, LEmail, PMo, PEmail  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' ", cnn)

        'cnn.Open()

        'Dgv1.DataSource = myCommand3.ExecuteReader()

        'Dgv1.DataBind()

        'cnn.Close()

        '-----------------------------------

    End Sub

    Protected Sub ButtonExit0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit0.Click

        ''-----------------------------------

        If ButtonEdit.Enabled = False Then

            ButtonAdd.Enabled = False

            ButtonEdit.Enabled = True

            ButtonDelete.Enabled = True

            ButtonExit0.BackColor = Drawing.Color.Red

            ButtonExit0.ForeColor = Drawing.Color.White

        ElseIf ButtonEdit.Enabled = True Then

            ButtonAdd.Enabled = True

            ButtonEdit.Enabled = False

            ButtonDelete.Enabled = False

            ButtonExit0.BackColor = Drawing.Color.DarkGreen

            ButtonExit0.ForeColor = Drawing.Color.White

        End If

        '----------------------------------------

    End Sub

    Protected Sub Dgv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv1.SelectedIndexChanged

        ' Try

        Dim mssg As String = Dgv1.SelectedRow.Cells(1).Text
        MsgBox(mssg.ToString)
        'Catch ex As Exception

        'End Try

        ' Try

        cnn.Close()

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)


        Dim myCommand1 As New SqlCommand("SELECT RecID, AYear, RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender, DOB, LAdd, LMo, LEmail, PAdd, PMo, PEmail, FullName  FROM  [02Student] where   (RecID='" + Dgv1.SelectedRow.Cells(1).Text.ToString + "') and (AYear='" + CBAcadYear.Text + "') ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        If dr.Read = True Then

            LRecID.Text = (dr(0).ToString)
            CBAcadYear.Text = (dr(1).ToString)
            TxtRegNo.Text = (dr(2).ToString)
            TxtFname.Text = (dr(3).ToString)
            TxtMname.Text = (dr(4).ToString)
            TxtLName.Text = (dr(5).ToString)
            LCourseID.Text = (dr(6).ToString)
            LYearID.Text = (dr(7).ToString)
            CBStatus.Text = (dr(8).ToString)
            TxtRollNo.Text = (dr(9).ToString)
            CBBatch.Text = (dr(10).ToString)
            CBGender.Text = (dr(11).ToString)
            TxtLocalAddress.Text = (dr(13).ToString)
            TxtLocalMobile.Text = (dr(14).ToString)
            TxtEmail.Text = (dr(15).ToString)
            TxtPAddress.Text = (dr(16).ToString)
            TxtPMobile.Text = (dr(17).ToString)
            TxtPEmail.Text = (dr(18).ToString)
            Dtp.SelectedDate = (dr(12).ToString)
        End If


        LRecID.DataBind()
        CBAcadYear.DataBind()
        TxtRegNo.DataBind()
        TxtFname.DataBind()
        TxtMname.DataBind()
        TxtLName.DataBind()
        CBStatus.DataBind()
        TxtRollNo.DataBind()
        CBBatch.DataBind()
        CBGender.DataBind()
        Dtp.DataBind()
        TxtLocalAddress.DataBind()
        TxtLocalMobile.DataBind()
        TxtEmail.DataBind()
        TxtPAddress.DataBind()
        TxtPMobile.DataBind()
        TxtPEmail.DataBind()
        LYearID.DataBind()
        LCourseID.DataBind()

        cnn.Close()

        ''------------------------------------------

        'Catch ex As Exception

        'End Try


        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        Dim myCommand2 As New SqlCommand("SELECT RecNo,Code FROM [01Class]where Type='Year' and RecNo='" + LYearID.Text + "' ", cnn)

        cnn.Open()

        Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

        While dr2.Read()

            CBYear.Text = (dr2(1).ToString())

        End While

        cnn.Close()

        CBYear.DataBind()

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT RecNo,Code FROM [01Class]where Type='Course' and RecNo='" + LCourseID.Text + "' ", cnn)

        cnn.Open()

        Dim dr3 As SqlDataReader = myCommand3.ExecuteReader()

        While dr3.Read()

            CBCourse.Text = (dr3(1).ToString())

        End While

        cnn.Close()

        CBCourse.DataBind()

        '-----------------------------------


    End Sub

    Protected Sub ButtonNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        LabelMessage.Text = ""
        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        'CBSearch.Items.Clear()

        Dim myCommand1 As New SqlCommand("SELECT  Count(RecID) FROM  [02Student]  where AYear='" + CBAcadYear.Text + "' ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        'If dr.Read = True Then

        '    txtCode.Text = (dr(2).ToString())

        'End If

        While dr.Read()

            'CBSearch.Items.Add(dr(1).ToString())

            LRecID.Text = (dr(0).ToString())

        End While

        cnn.Close()

        LRecID.Text = Val(LRecID.Text) + 1

        '------------------------------------------

        TxtRegNo.Text = ""
        TxtFname.Text = ""
        TxtMname.Text = ""
        TxtLName.Text = ""
        LCourseID.Text = ""
        LYearID.Text = ""
        CBStatus.SelectedIndex = 0
        TxtRollNo.Text = ""
        CBBatch.SelectedIndex = 0
        CBGender.SelectedIndex = 0
        TxtLocalAddress.Text = ""
        TxtLocalMobile.Text = ""
        TxtEmail.Text = ""
        TxtPAddress.Text = ""
        TxtPMobile.Text = ""
        TxtPEmail.Text = ""
        ' Dtp.SelectedDate = ""

        TxtFname.Focus()

    End Sub

    Protected Sub ButtonEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        TxtFname.Text = TxtFname.Text.ToUpper
        TxtMname.Text = TxtMname.Text.ToUpper
        TxtLName.Text = TxtLName.Text.ToUpper
        '-----------------------------------

        '-----------------------------------------------
        TxtRegNo.Text = TxtRegNo.Text.ToUpper
        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        '-----------------------------

        Dim dt1 As String = Dtp.SelectedDate.Date.ToString
        LFullName.Text = TxtFname.Text & " " & TxtMname.Text & " " & TxtLName.Text
        'DOB ='" + dt1.ToString + "',

        Dim myCommandI As New SqlCommand("UPDATE  [02Student]   SET  AYear ='" + CBAcadYear.Text + "',RegNo='" + TxtRegNo.Text + "',  FName ='" + TxtFname.Text + "', MName ='" + TxtMname.Text + "', LName ='" + TxtLName.Text + "', Course ='" + LCourseID.Text + "', Year ='" + LYearID.Text + "', Status ='" + CBStatus.Text + "', RollNo =" + TxtRollNo.Text + ", Batch ='" + CBBatch.Text + "', Gender ='" + CBGender.Text + "',  LAdd ='" + TxtLocalAddress.Text + "', LMo ='" + TxtLocalMobile.Text + "', LEmail ='" + TxtEmail.Text + "',  PAdd ='" + TxtPAddress.Text + "', PMo ='" + TxtPMobile.Text + "', PEmail ='" + TxtPEmail.Text + "', FullName ='" + LFullName.Text + "'  where   (RecID =" + LRecID.Text + ") and (AYear ='" + CBAcadYear.Text + "')", cnn)

        'Try

        cnn.Open()

        myCommandI.ExecuteNonQuery()

        ' MsgBox("Update Successfully")
        LabelMessage.Text = "Update Successfully"

        cnn.Close()

        'Catch ex As Exception

        'End Try

        '-----------------------------------

        Try

            cnn = New SqlConnection(connetionstring)

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender,  LMo, LEmail, PMo, PEmail  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' ", cnn)

            cnn.Open()

            Dgv2.DataSource = myCommand3.ExecuteReader()

            Dgv2.DataBind()

            cnn.Close()

            '-----------------------------------------

        Catch ex As Exception

        End Try

        '   End If

        ' End If

    End Sub

    Protected Sub ButtonDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click

       
        '------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()
        '-----------------------------

        Dim myCommandI As New SqlCommand("DELETE FROM  [02Student] where   RecID ='" + LRecID.Text + "' and   AYear ='" + CBAcadYear.Text + "'", cnn)

        ' Try

        cnn.Open()

        myCommandI.ExecuteNonQuery()

        '  MsgBox("Delete Succeessfully")
        LabelMessage.Text = "Delete Successfully"

        cnn.Close()

        'Catch ex As Exception

        'End Try

        '-----------------------------------

        Try

            cnn = New SqlConnection(connetionstring)

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender,  LMo, LEmail, PMo, PEmail  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' ", cnn)

            cnn.Open()

            Dgv2.DataSource = myCommand3.ExecuteReader()

            Dgv2.DataBind()

            cnn.Close()

            '-----------------------------------------

        Catch ex As Exception

        End Try

    End Sub

    Protected Sub CBCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBCourse.SelectedIndexChanged

        TxtFname.Text = TxtFname.Text.ToUpper
        TxtMname.Text = TxtMname.Text.ToUpper
        TxtLName.Text = TxtLName.Text.ToUpper
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

        LCo.Text = CBCourse.Text.Substring(0, 2) & LR1.Text

        If LRecID.Text >= 1 And LRecID.Text <= 9 Then
            TxtRegNo.Text = LCo.Text & "00" & LRecID.Text
        ElseIf LRecID.Text >= 10 And LRecID.Text <= 99 Then
            TxtRegNo.Text = LCo.Text & "0" & LRecID.Text
        Else
            TxtRegNo.Text = LCo.Text & LRecID.Text
        End If

        '------------------------------------
        TxtRegNo.Text = TxtRegNo.Text.ToUpper

    End Sub

    Protected Sub CBYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.SelectedIndexChanged
        '-----------------------------------
        TxtRegNo.Text = TxtRegNo.Text.ToUpper

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

    End Sub

    Protected Sub CBAcadYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBAcadYear.SelectedIndexChanged
        Dim a, b As String
        a = CBAcadYear.Text.Substring(2, 2)
        b = CBAcadYear.Text.Substring(7, 2)
        LR1.Text = a.ToString & b.ToString


        Try
            If Dgv1.Visible = True Then
                ButtonNew0.Text = "View Student List"
                Dgv1.Visible = False
            ElseIf Dgv1.Visible = False Then
                Dgv1.Visible = True
                ButtonNew0.Text = "Hide Student List"
            End If

            cnn = New SqlConnection(connetionstring)

            Dim myCommand3 As New SqlCommand("SELECT  [02Student].RecID, [02Student].AYear AS 'AcademicYear', [02Student].RegNo, [02Student].FName, [02Student].MName, [02Student].LName,  [01Class].Code AS Course, [01Class_1].Code AS Year, [02Student].Status, [02Student].RollNo, [02Student].Batch, [02Student].Gender, [02Student].LMo,  [02Student].LEmail, [02Student].PMo, [02Student].PEmail   FROM   [02Student] INNER JOIN  [01Class] ON [02Student].Course = [01Class].RecNo INNER JOIN   [01Class] AS [01Class_1] ON [02Student].Year = [01Class_1].RecNo  WHERE  ([01Class].Type = 'Course') AND ([01Class_1].Type = 'Year') and [02Student].AYear='" + CBAcadYear.Text + "' ", cnn)

            cnn.Open()

            'Dgv1.DataSource = myCommand3.ExecuteReader()
            Dgv2.DataSource = myCommand3.ExecuteReader()

          
            Dgv2.DataBind()

            cnn.Close()

            '-----------------------------------------

        Catch ex As Exception

        End Try
    End Sub


    Protected Sub ButtonNew0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew0.Click
        Try
            If Dgv1.Visible = True Then
                ButtonNew0.Text = "View Student List"
                Dgv1.Visible = False
            ElseIf Dgv1.Visible = False Then
                Dgv1.Visible = True
                ButtonNew0.Text = "Hide Student List"
            End If

            cnn = New SqlConnection(connetionstring)

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender,  LMo, LEmail, PMo, PEmail  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()
            Dgv2.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()
            Dgv2.DataBind()

            cnn.Close()

            '-----------------------------------------

        Catch ex As Exception

        End Try
    End Sub

   
    Protected Sub ButtonNew0_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew0.Init
        Try
            If Dgv1.Visible = True Then
                ButtonNew0.Text = "View Student List"
                Dgv1.Visible = False
            ElseIf Dgv1.Visible = False Then
                Dgv1.Visible = True
                ButtonNew0.Text = "Hide Student List"
            End If

            cnn = New SqlConnection(connetionstring)

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender,  LMo, LEmail, PMo, PEmail  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

            '-----------------------------------------

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub CBCourse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBCourse.TextChanged
        TxtFname.Text = TxtFname.Text.ToUpper
        TxtMname.Text = TxtMname.Text.ToUpper
        TxtLName.Text = TxtLName.Text.ToUpper
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

        LCo.Text = CBCourse.Text.Substring(0, 2) & LR1.Text

        If LRecID.Text >= 1 And LRecID.Text <= 9 Then
            TxtRegNo.Text = LCo.Text & "00" & LRecID.Text
        ElseIf LRecID.Text >= 10 And LRecID.Text <= 99 Then
            TxtRegNo.Text = LCo.Text & "0" & LRecID.Text
        Else
            TxtRegNo.Text = LCo.Text & LRecID.Text
        End If

        '------------------------------------
        TxtRegNo.Text = TxtRegNo.Text.ToUpper

    End Sub

    Protected Sub CBYear_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.TextChanged
        '-----------------------------------
        TxtRegNo.Text = TxtRegNo.Text.ToUpper

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
    End Sub

    Protected Sub Dgv2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv2.SelectedIndexChanged
        'Dim mssg As String = Dgv2.SelectedRow.Cells(1).Text
        'MsgBox(mssg.ToString)
        cnn.Close()

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)


        Dim myCommand1 As New SqlCommand("SELECT RecID, AYear, RegNo, FName, MName, LName, Course, Year, Status, RollNo, Batch, Gender, DOB, LAdd, LMo, LEmail, PAdd, PMo, PEmail, FullName  FROM  [02Student] where   (RecID='" + Dgv2.SelectedRow.Cells(1).Text.ToString + "') and (AYear='" + CBAcadYear.Text + "') ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()


        Try
            If dr.Read = True Then

                LRecID.Text = (dr(0).ToString)
                CBAcadYear.Text = (dr(1).ToString)
                TxtRegNo.Text = (dr(2).ToString)
                TxtFname.Text = (dr(3).ToString)
                TxtMname.Text = (dr(4).ToString)
                TxtLName.Text = (dr(5).ToString)
                LCourseID.Text = (dr(6).ToString)
                LYearID.Text = (dr(7).ToString)
                CBStatus.Text = (dr(8).ToString)
                TxtRollNo.Text = (dr(9).ToString)
                CBGender.Text = (dr(11).ToString)
                TxtLocalAddress.Text = (dr(13).ToString)
                TxtLocalMobile.Text = (dr(14).ToString)
                TxtEmail.Text = (dr(15).ToString)
                TxtPAddress.Text = (dr(16).ToString)
                TxtPMobile.Text = (dr(17).ToString)
                TxtPEmail.Text = (dr(18).ToString)
                Dtp.SelectedDate = (dr(12).ToString)
                CBBatch.Text = (dr(10).ToString)
            End If

        Catch ex As Exception
            CBBatch.SelectedIndex = 0
        End Try



        Try
            LRecID.DataBind()
            CBAcadYear.DataBind()
            TxtRegNo.DataBind()
            TxtFname.DataBind()
            TxtMname.DataBind()
            TxtLName.DataBind()
            CBStatus.DataBind()
            TxtRollNo.DataBind()
            CBBatch.DataBind()
            CBGender.DataBind()
            Dtp.DataBind()
            TxtLocalAddress.DataBind()
            TxtLocalMobile.DataBind()
            TxtEmail.DataBind()
            TxtPAddress.DataBind()
            TxtPMobile.DataBind()
            TxtPEmail.DataBind()
            LYearID.DataBind()
            LCourseID.DataBind()

        Catch ex As Exception

        End Try

        cnn.Close()

        ''------------------------------------------

        'Catch ex As Exception

        'End Try


        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        Dim myCommand2 As New SqlCommand("SELECT RecNo,Code FROM [01Class]where Type='Year' and RecNo='" + LYearID.Text + "' ", cnn)

        cnn.Open()

        Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

        While dr2.Read()

            CBYear.Text = (dr2(1).ToString())

        End While

        cnn.Close()

        CBYear.DataBind()

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT RecNo,Code FROM [01Class]where Type='Course' and RecNo='" + LCourseID.Text + "' ", cnn)

        cnn.Open()

        Dim dr3 As SqlDataReader = myCommand3.ExecuteReader()

        While dr3.Read()

            CBCourse.Text = (dr3(1).ToString())

        End While

        cnn.Close()

        CBCourse.DataBind()

        '-----------------------------------
    End Sub

    Protected Sub ButtonNew1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew1.Click
        Session("AcademicYear") = CBAcadYear.Text
        Response.Redirect("Mail.aspx")
    End Sub

    Protected Sub ButtonNew2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew2.Click
        Session("AcademicYear") = CBAcadYear.Text
        Response.Redirect("SMS.aspx")
    End Sub
End Class
