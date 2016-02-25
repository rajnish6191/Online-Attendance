Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Partial Class Subject

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        Response.Redirect("Main.aspx")

    End Sub

    Protected Sub ButtonExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.Click

        Response.Redirect("Main.aspx")

    End Sub

    Protected Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click

        '  If CbAcadYear.Text <> "" And txtCodeSubject.Text <> "" And TxtNameSubject.Text <> "" And CBCourse.Text <> "" And CBYear.Text <> "" And CBSubType.Text <> "" Then

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        'CBSearch.Items.Clear()

        Dim myCommand1 As New SqlCommand("SELECT  Count(RecID) FROM  [04Subject] where AYear='" + CbAcadYear.Text + "'", cnn)

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

        Dim myCommand2 As New SqlCommand("SELECT RecID FROM  [04Subject]  where  ( Code='" + txtCodeSubject.Text + "' or  Name='" + TxtNameSubject.Text + "'or  Short='" + TxtShortName.Text + "') ", cnn)

        cnn.Open()

        Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

        If dr2.Read = True Then

            MsgBox("Duplicate Entry", MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "Error")

        Else
            '-----------------------------------------------

            'Dim cnn As SqlConnection

            cnn = New SqlConnection(connetionstring)

            cnn.Close()
            '-----------------------------      '''''''''''''''''''''   RecID, AYear, Code, Name, Short, Course, Year, Sem, Type, Th, Pr, [Or], Tw, StaffID'''''''''          RecID,                   Code,                           Name,                          Short,                    Course,                    Year,                 Sem,                       Type,                     Th,                  Pr,                  [Or],                  Tw,                  StaffID
            Dim myCommandI As New SqlCommand("INSERT INTO [04Subject]  (RecID,AYear,  Code, Name, Short, Course, Year, Sem, Type, Th, Pr, [Or], Tw, StaffID)   VALUES ('" + LRecID.Text + "','" + CbAcadYear.Text + "',  '" + txtCodeSubject.Text + "', '" + TxtNameSubject.Text + "', '" + TxtShortName.Text + "', '" + LCourseID.Text + "', '" + LYearID.Text + "', '" + CBSemister.Text + "', '" + CBSubType.Text + "', '" + txtTH.Text + "','" + TxtPR.Text + "', '" + TxtOR.Text + "', '" + TxtTW.Text + "', '" + LStaffID.Text + "' )", cnn)
            'Dim myCommandI As New SqlCommand("INSERT INTO [01Class] (RecNo, ID, Code, Name, Type)  VALUES ('" + LRecID.Text + "','" + TxtID.Text + "', '" + txtCode.Text + "', '" + txtName.Text + "', '" + LType.Text + "')", cnn)

            '  Try

            cnn.Open()

            myCommandI.ExecuteNonQuery()

            'MsgBox("Ok")

            cnn.Close()

            'Catch ex As Exception

            'End Try

            '-----------------------------------

            Try

                '  Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear, Code, Name, Short, Course, Year, Sem, Type, Th, Pr, [Or], Tw, StaffID   FROM  [04Subject] where AYear='" + CbAcadYear.Text + "' ", cnn)

                Dim myCommand3 As New SqlCommand("SELECT  [04Subject].RecID, [04Subject].Code, [04Subject].Short, [01Class].Code AS Year, [01Class_1].Code AS Course, [04Subject].Sem,[04Subject].Type, [04Subject].Th, [04Subject].Pr, [04Subject].[Or], [04Subject].Tw, [03Staff].FullName AS StaffName  FROM  [04Subject] INNER JOIN  [03Staff] ON [04Subject].StaffID = [03Staff].RecID INNER JOIN  [01Class] ON [04Subject].Year = [01Class].RecNo INNER JOIN  [01Class] AS [01Class_1] ON [04Subject].Course = [01Class_1].RecNo   WHERE     ([01Class].Type = 'Year') AND ([01Class_1].Type = 'Course') and (AYear='" + CbAcadYear.Text + "') ", cnn)

                cnn.Open()

                Dgv1.DataSource = myCommand3.ExecuteReader()

                Dgv1.DataBind()

                cnn.Close()

            Catch ex As Exception

            End Try

        End If

        ' End If

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

    Protected Sub ButtonExit0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit0.Click

        ''-----------------------------------

        'cnn = New SqlConnection(connetionstring)


        'Dim myCommand1 As New SqlCommand("SELECT  RecNo, ID, Code, Name, Type  FROM [01Class]where Type='" + LType.Text + "' ", cnn)

        'cnn.Open()

        'Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        'If dr.Read = True Then

        '    txtCode.Text = (dr(2).ToString())

        'End If

        ''While dr.Read()

        ''    CBSearch.Items.Add(dr(1).ToString())

        ''End While

        'cnn.Close()
        ''------------------------------------------

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



    End Sub

    Protected Sub Dgv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv1.SelectedIndexChanged

        Try

            cnn.Close()

            '-----------------------------------

            cnn = New SqlConnection(connetionstring)

            Dim myCommand1 As New SqlCommand("SELECT  RecID, AYear, Code, Name, Short, Course, Year, Sem, Type, Th, Pr, [Or], Tw, StaffID   FROM  [04Subject] where    RecID='" + Dgv1.SelectedRow.Cells(1).Text.ToString + "' ", cnn)

            cnn.Open()

            Dim dr As SqlDataReader = myCommand1.ExecuteReader()

            If dr.Read = True Then

                LRecID.Text = (dr(0).ToString)
                CbAcadYear.Text = (dr(1).ToString)
                txtCodeSubject.Text = (dr(2).ToString)
                TxtNameSubject.Text = (dr(3).ToString)
                TxtShortName.Text = (dr(4).ToString)
                LCourseID.Text = (dr(5).ToString)
                LYearID.Text = (dr(6).ToString)
                CBSemister.Text = (dr(7).ToString)
                CBSubType.Text = (dr(8).ToString)
                txtTH.Text = (dr(9).ToString)
                TxtPR.Text = (dr(10).ToString)
                TxtOR.Text = (dr(11).ToString)
                TxtTW.Text = (dr(12).ToString)
                LStaffID.Text = (dr(13).ToString)

            End If

            'CBSearch.Items.Add(dr(1).ToString())

            ' End While
            LRecID.DataBind()
            CbAcadYear.DataBind()
            txtCodeSubject.DataBind()
            TxtNameSubject.DataBind()
            TxtShortName.DataBind()
            CBCourse.DataBind()
            CBYear.DataBind()
            CBSemister.DataBind()
            CBSubType.DataBind()
            txtTH.DataBind()
            TxtPR.DataBind()
            TxtOR.DataBind()
            TxtTW.DataBind()
            LStaffID.DataBind()
            LYearID.DataBind()
            LCourseID.DataBind()

            cnn.Close()

            ''------------------------------------------

        Catch ex As Exception

        End Try


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

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        'CBSearch.Items.Clear()

        Dim myCommand1 As New SqlCommand("SELECT  Count(RecID) FROM  [04Subject]  ", cnn)

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

        TxtNameSubject.Text = ""

        txtCodeSubject.Text = ""

        txtCodeSubject.Focus()

    End Sub

    Protected Sub ButtonEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click

        '   If TxtID.Text <> "" And txtCode.Text <> "" And txtName.Text <> "" Then

        '------------------------------------------

        'Dim myCommand2 As New SqlCommand("SELECT RecNo, ID FROM [01Class]where Type='" + LType.Text + "' and (Name'" + txtName.Text + "' ) ", cnn)

        'cnn.Open()

        'Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

        'If dr2.Read = True Then

        '    MsgBox("Duplicate Entry", MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "Error")

        'Else
        '-----------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        '-----------------------------

        Dim myCommandI As New SqlCommand("UPDATE  [04Subject]  SET   Code='" + txtCodeSubject.Text + "', Name='" + TxtNameSubject.Text + "', Short='" + TxtShortName.Text + "', Course='" + LCourseID.Text + "', Year='" + LYearID.Text + "', Sem='" + CBSemister.Text + "', Type='" + CBSubType.Text + "', Th='" + txtTH.Text + "', Pr='" + TxtPR.Text + "', [Or]='" + TxtOR.Text + "', Tw='" + TxtTW.Text + "', StaffID='" + LStaffID.Text + "'  where   (RecID ='" + LRecID.Text + "') ", cnn)

        'Try

        cnn.Open()

        myCommandI.ExecuteNonQuery()

        MsgBox("Update Successfully")

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

    Protected Sub ButtonDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click

        'If TxtID.Text <> "" And txtCode.Text <> "" And txtName.Text <> "" Then

        '    '-----------------------------------

        '    cnn = New SqlConnection(connetionstring)

        '    'CBSearch.Items.Clear()

        '    Dim myCommand1 As New SqlCommand("SELECT  Count(RecNo) FROM [01Class]where Type='" + LType.Text + "' ", cnn)

        '    cnn.Open()

        '    Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        '    'If dr.Read = True Then

        '    '    txtCode.Text = (dr(2).ToString())

        '    'End If

        '    While dr.Read()

        '        'CBSearch.Items.Add(dr(1).ToString())

        '        LRecID.Text = (dr(0).ToString())

        '    End While

        '    cnn.Close()

        '    LRecID.Text = Val(LRecID.Text) + 1

        '------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()
        '-----------------------------

        Dim myCommandI As New SqlCommand("DELETE FROM  [04Subject] where   RecNo ='" + LRecID.Text + "' )", cnn)

        Try

            cnn.Open()

            myCommandI.ExecuteNonQuery()

            'MsgBox("Delete")

            cnn.Close()

        Catch ex As Exception

        End Try

        '-----------------------------------

        Try

            cnn = New SqlConnection(connetionstring)

            '  Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear, Code, Name, Short, Course, Year, Sem, Type, Th, Pr, [Or], Tw, StaffID   FROM  [04Subject] where AYear='" + CbAcadYear.Text + "' ", cnn)

            Dim myCommand3 As New SqlCommand("SELECT [04Subject].RecID, [04Subject].Code, [04Subject].Short, [01Class].Code AS Year, [01Class_1].Code AS Course, [04Subject].Sem,[04Subject].Type, [04Subject].Th, [04Subject].Pr, [04Subject].[Or], [04Subject].Tw, [03Staff].FullName AS StaffName  FROM  [04Subject] INNER JOIN  [03Staff] ON [04Subject].StaffID = [03Staff].RecID INNER JOIN  [01Class] ON [04Subject].Year = [01Class].RecNo INNER JOIN  [01Class] AS [01Class_1] ON [04Subject].Course = [01Class_1].RecNo   WHERE     ([01Class].Type = 'Year') AND ([01Class_1].Type = 'Course') ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()
            '-----------------------------------------

        Catch ex As Exception

        End Try

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

    Protected Sub CBSubType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBSubType.SelectedIndexChanged
        If CBSubType.SelectedIndex = 0 Then
            txtTH.Enabled = True
            TxtPR.Enabled = False
        ElseIf CBSubType.SelectedIndex = 1 Then
            txtTH.Enabled = False
            TxtPR.Enabled = True
        ElseIf CBSubType.SelectedIndex = 2 Then
            txtTH.Enabled = True
            TxtPR.Enabled = True
        End If
    End Sub

    Protected Sub CbAcadYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbAcadYear.SelectedIndexChanged

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

    End Sub

    Protected Sub ButtonNew0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew0.Click
        'SubStaffAssign.aspx
        Response.Redirect("SubStaffAssign.aspx")

    End Sub
End Class
