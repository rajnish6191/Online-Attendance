Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Partial Class AttProcess

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        Try

        '--------------------------------------------------------------------------------------------------

            cnn = New SqlConnection(connetionstring)

            Dim myCommand1 As New SqlCommand("SELECT  Course, Year, Code,  Sem, Name  FROM    [04Subject]   WHERE     (StaffID = '" + LabelStaffID.Text + "' and AYear='" + LabelAcademicYear.Text + "')  ", cnn)

            cnn.Open()

            Dim dr As SqlDataReader = myCommand1.ExecuteReader()

            While dr.Read()

                CBCourse0.Items.Add(dr(0).ToString())
                'CBYear0.Items.Add(dr(1).ToString())
                'CBSubject0.Items.Add(dr(2).ToString())
                'CBSem0.Items.Add(dr(3).ToString())

            End While

            'LabelStaffID.DataBind()
            CBCourse0.DataBind()
            'CBYear0.DataBind()
            'CBSubject0.DataBind()
            'CBSem0.DataBind()

            cnn.Close()

            ''---------------------------------------------------------------------------------------------------
            'Try
            '    Me.Dgv2.Columns(0).Visible = False
            '    Me.Dgv2.Columns(1).Visible = False
            '    '   Me.Dgv2.Columns(2).Visible = True
            'Catch ex As Exception

            'End Try
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'LabelStaffID.Text = PreviousPage.staffID

        ' LabelStaffID.Text = Request.QueryString().ToString()

        LabelStaffID.Text = Session("textboxvalue")

        LabelAcademicYear.Text = Session("AcademicYear")

        LStaffName.Text = Session("LStaffName")


        'Try
        '    Me.Dgv2.Columns(0).Visible = False
        '    Me.Dgv2.Columns(1).Visible = False
        '    '   Me.Dgv2.Columns(2).Visible = True
        'Catch ex As Exception

        'End Try

   
        '   LabelS.Text = CType(PreviousPage.FindControl("Textbox1"), TextBox).Text

        'If Not Page.PreviousPage Is Nothing Then

        '    Dim SourceTextBox As TextBox

        '    SourceTextBox = CType(PreviousPage.FindControl("TextBox1"),  _

        '        TextBox)

        '    If Not SourceTextBox Is Nothing Then

        '        LabelStaffID.Text = ""

        '        LabelStaffID.Text = SourceTextBox.Text

        '    End If

        'End If

    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles ImageButton3.Click, ImageButton1.Click, ImageButton2.Click

        Session("textboxvalue") = LabelStaffID.Text
        Session("status") = "1"

        Response.Redirect("StaffReg.aspx")
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs) Handles ImageButton2.Click

        Response.Redirect("AttLogin.aspx")

    End Sub

    'Protected Sub ButtonExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
    '    Response.Redirect("Master.aspx")
    'End Sub

   
    Protected Sub ButtonNew0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew0.Click

        CBSubject.Visible = True

        LT4.Visible = True

        CBSubject.Items.Clear()

        CBSubject.Items.Add("-- Select Subject --")


        cnn = New SqlConnection(connetionstring)

        Dim myCommand2 As New SqlCommand("SELECT  Distinct[Short] FROM    [04Subject]   WHERE     (StaffID = '" + LabelStaffID.Text + "') and (AYear='" + LabelAcademicYear.Text + "') ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand2.ExecuteReader()

        While dr.Read()

            CBSubject.Items.Add(dr(0).ToString())

        End While


        CBSubject.DataBind()

        cnn.Close()

        ''---------------------------------------------------------------------------------------------------



      


        ''--------------------------------------------------------------------------------------------------
        'CBCourse0.Items.Clear()
        'CBYear0.Items.Clear()
        'CBSubject.Items.Clear()
        'CBSemister.Items.Clear()
        'ButtonNew0.Visible = True


        'cnn = New SqlConnection(connetionstring)

        '' Dim myCommand1 As New SqlCommand("SELECT  Course, Year, Code,  Sem, Name  FROM    [04Subject]   WHERE     (StaffID = '" + LabelStaffID.Text + "' and AYear='" + LabelAcademicYear.Text + "')  ", cnn)

        'Dim myCommand1 As New SqlCommand("SELECT  Distinct[Course] FROM    [04Subject]   WHERE     (StaffID = '" + LabelStaffID.Text + "' and AYear='" + LabelAcademicYear.Text + "')  ", cnn)

        'cnn.Open()

        'Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        'While dr.Read()

        '    CBCourse0.Items.Add(dr(0).ToString())
        '    '  CBYear0.Items.Add(dr(1).ToString())
        '    '  CBSubject0.Items.Add(dr(2).ToString())
        '    ' CBSem0.Items.Add(dr(3).ToString())

        'End While

        ''LabelStaffID.DataBind()
        'CBCourse0.DataBind()
        '' CBYear0.DataBind()
        '' CBSubject0.DataBind()
        '' CBSem0.DataBind()

        'cnn.Close()

        ' ''---------------------------------------------------------------------------------------------------

        ''Try

        'CBCourse.Items.Clear()
        'CBCourse.Items.Add("-- Select Course --")

        'cnn = New SqlConnection(connetionstring)

        'Dim i As Integer

        'For i = 0 To Val(CBCourse0.Items.Count.ToString) - 1

        '    CBCourse0.SelectedIndex = i

        '    cnn.Open()

        '    Dim myCommand2 As New SqlCommand("SELECT  RecNo,  Code, Name, Type   FROM   [01Class]  where  Type='Course' and  RecNo='" + CBCourse0.Text + "'  ", cnn)

        '    Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

        '    If dr2.Read = True Then

        '        CBCourse.Items.Add(dr2(1).ToString())

        '    End If

        '    cnn.Close()

        'Next

        'CBCourse.Visible = True
        'LT1.Visible = True
        'LTAcademicLabel.Visible = True
        'LabelAcademicYear.Visible = True

        'CBCourse.DataBind()

        ''------------------------------------------------------------------------------------------------


        ''-------------------------------------------------------------------------------------------------
        ''Catch ex As Exception

        ''End Try
        ' ''---------------------------------------------------------------------------------------------------

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Try

        CBCourse.Items.Clear()
        CBCourse.Items.Add("-- Select Course --")

        cnn = New SqlConnection(connetionstring)

        Dim i As Integer

        For i = 0 To Val(CBCourse0.Items.Count.ToString) - 1

            CBCourse0.SelectedIndex = i

            cnn.Open()

            Dim myCommand2 As New SqlCommand("SELECT  RecNo, Code, Name, Type   FROM   [01Class]  where  Type='Course' and  RecNo='" + CBCourse0.Text + "'  ", cnn)

            Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

            If dr2.Read = True Then

                CBCourse.Items.Add(dr2(2).ToString())

            End If

            cnn.Close()

        Next

        CBCourse.DataBind()

        '------------------------------------------------------------------------------------------------


        '-------------------------------------------------------------------------------------------------
        'Catch ex As Exception

        'End Try
        ''---------------------------------------------------------------------------------------------------

    End Sub

    Protected Sub CBYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBYear.SelectedIndexChanged

        CBSemister.Visible = True
        LT3.Visible = True
        '--------------------------------------------------------------------------------------------------
        '-----------------------------------
        CBBatchName.Items.Clear()
        Dim b As String = CBYear.Text.Substring(0, 1)
        CBBatchName.Items.Add("-- Select Batch --")
        CBBatchName.Items.Add(b.ToString & 1)
        CBBatchName.Items.Add(b.ToString & 2)
        CBBatchName.Items.Add(b.ToString & 3)
        CBBatchName.Items.Add(b.ToString & 4)
        '--------------------------------------


        LabelYearID.Text = ""

        cnn = New SqlConnection(connetionstring)

        Dim myCommand1 As New SqlCommand("SELECT  RecNo,  Code, Name, Type   FROM   [01Class]  where  Type='Year' and   Code='" + CBYear.Text + "'  ", cnn)

        cnn.Open()

        Dim dr1 As SqlDataReader = myCommand1.ExecuteReader()

        While dr1.Read()

            LabelYearID.Text = (dr1(0).ToString())

        End While


        LabelYearID.DataBind()

        cnn.Close()

        ''---------------------------------------------------------------------------------------------------


        CBSemister.Items.Clear()

        CBSemister.Items.Add("-- Select Semister --")

        cnn = New SqlConnection(connetionstring)

        Dim myCommand2 As New SqlCommand("SELECT    Distinct[Sem]  FROM    [04Subject]   WHERE     (StaffID = '" + LabelStaffID.Text + "' and AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "')  ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand2.ExecuteReader()

        While dr.Read()

            CBSemister.Items.Add(dr(0).ToString())

        End While


        CBSemister.DataBind()

        cnn.Close()

        ''---------------------------------------------------------------------------------------------------

       
     

    End Sub

    Protected Sub CBCourse_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBCourse.SelectedIndexChanged

        CBYear.Visible = True
        LT2.Visible = True
        '--------------------------------------------------------------------------------------------------


        LabelCourseID.Text = ""

        cnn = New SqlConnection(connetionstring)

        'Dim myCommand1 As New SqlCommand("SELECT  RecNo, Code, Name, Type   FROM   [01Class]  where  Type='Course' and   Code='" + CBCourse.Text + "'  ", cnn)

        Dim myCommand1 As New SqlCommand("SELECT  Distinct[RecNo]  FROM   [01Class]  where  Type='Course' and   Code='" + CBCourse.Text + "'  ", cnn)

        cnn.Open()

        Dim dr1 As SqlDataReader = myCommand1.ExecuteReader()

        While dr1.Read()

            LabelCourseID.Text = (dr1(0).ToString())

        End While


        LabelCourseID.DataBind()

        cnn.Close()

        ''---------------------------------------------------------------------------------------------------


        CBYear0.Items.Clear()

        cnn = New SqlConnection(connetionstring)
        CBYear0.Items.Add("0")

        ' Dim myCommand2 As New SqlCommand("SELECT  Course, Year, Code,Sem, Name  FROM [04Subject] ", cnn) ' where (StaffID = '" + LabelStaffID.Text + "' and AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "') 

        Dim myCommand2 As New SqlCommand("SELECT  Distinct[Year]  FROM [04Subject] ", cnn) ' where (StaffID = '" + LabelStaffID.Text + "' and AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "') 

        cnn.Open()

        Dim dr As SqlDataReader = myCommand2.ExecuteReader()

        While dr.Read()

            CBYear0.Items.Add(dr(0).ToString())

        End While


        CBYear0.DataBind()

        cnn.Close()

        ''---------------------------------------------------------------------------------------------------

        '----------------------------------------------------------------------------------------------

        CBYear.Items.Clear()
        CBYear.Items.Add("-- Select Year --")

        For i = 0 To Val(CBYear0.Items.Count.ToString) - 1

            CBYear0.SelectedIndex = i

            cnn.Open()

            ' Dim myCommand3 As New SqlCommand("SELECT  RecNo,  Code, Name, Type   FROM   [01Class]  where  Type='Year' and  RecNo='" + CBYear0.Text + "'  ", cnn)

            Dim myCommand3 As New SqlCommand("SELECT  RecNo,  Code, Name, Type   FROM   [01Class]  where  Type='Year' and  RecNo='" + CBYear0.Text + "'  ", cnn)

            Dim dr3 As SqlDataReader = myCommand3.ExecuteReader()

            If dr3.Read = True Then

                CBYear.Items.Add(dr3(1).ToString())

            End If

            cnn.Close()

        Next

        CBCourse.DataBind()

        '------------------------------------------------------------------------------------------------

    End Sub


    Protected Sub CBSemister_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBSemister.SelectedIndexChanged

        'CBSubject.Visible = True

        'LT4.Visible = True

        'CBSubject.Items.Clear()

        'CBSubject.Items.Add("-- Select Subject --")


        'cnn = New SqlConnection(connetionstring)

        'Dim myCommand2 As New SqlCommand("SELECT  Distinct[Short] FROM    [04Subject]   WHERE     (StaffID = '" + LabelStaffID.Text + "' and AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and Sem='" + CBSemister.Text + "')  ", cnn)

        'cnn.Open()

        'Dim dr As SqlDataReader = myCommand2.ExecuteReader()

        'While dr.Read()

        '    CBSubject.Items.Add(dr(0).ToString())

        'End While


        'CBSubject.DataBind()

        'cnn.Close()

        ''---------------------------------------------------------------------------------------------------




    End Sub

    Protected Sub CBSubject_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBSubject.SelectedIndexChanged

        CBSubjectType.Visible = True

        LT5.Visible = True
       
        LabelSubID.Text = ""

        cnn = New SqlConnection(connetionstring)

        Dim myCommand2 As New SqlCommand("SELECT  Distinct[Code]  FROM    [04Subject]   WHERE     (StaffID = '" + LabelStaffID.Text + "' and AYear='" + LabelAcademicYear.Text + "'  and Short='" + CBSubject.Text + "')  ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand2.ExecuteReader()

        While dr.Read()

            LabelSubID.Text = (dr(0).ToString())

        End While


        LabelSubID.DataBind()

        cnn.Close()

        ''---------------------------------------------------------------------------------------------------
        CBLectNo.Items.Clear()
        CBLectNo.Items.Add("-- Select Lecture No --")
        Dim i As Integer
        For i = 1 To 50
            CBLectNo.Items.Add(i.ToString)
        Next
        '-------------------------------------------------
        '======================================================================================

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT  Course,Year, Sem  FROM    [04Subject]   WHERE     ( AYear='" + LabelAcademicYear.Text + "'   and Short='" + CBSubject.Text + "')  ", cnn)

        cnn.Open()

        Dim dr3 As SqlDataReader = myCommand3.ExecuteReader()

        While dr3.Read()

            LabelCourseID.Text = (dr3(0).ToString())

            LabelYearID.Text = (dr3(1).ToString())

            'CBSemister.Text = (dr3(2).ToString())

        End While


        'CBSemister.DataBind()

        cnn.Close()

        ''---------------------------------------------------------------------------------------------------
        '======================================================================================
    End Sub

    Protected Sub CBSubjectType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBSubjectType.SelectedIndexChanged
        CBLectNo.Visible = True
        '----------------------------------------

        Dtp.Visible = True

        If CBSubjectType.SelectedIndex = 0 Or CBSubjectType.SelectedIndex = 1 Then

            CBBatchName.Visible = False

            LabelBatch.Text = ""

            CBBatchName.Visible = False

            LT6.Visible = False

            LT8.Visible = True

            LT9.Visible = True

            '----------------------------------------------------------
            Dgv1.DataSource = ""

            cnn = New SqlConnection(connetionstring)

            Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FullName,Course, Year, Status, RollNo, Batch FROM   [02Student] where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and Status='Yes' ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

            '---------------------------------------------------------

            '''''''''' Attendance Sheet Check Code -------------------


            cnn = New SqlConnection(connetionstring)

            Dim myCommand2 As New SqlCommand("SELECT  AYear, Batch, Sem FROM  [05AttSheet] where ( AYear='" + LabelAcademicYear.Text + "' and  StaffID='" + LabelStaffID.Text + "' and  Course='" + LabelCourseID.Text + "' and  Year='" + LabelYearID.Text + "' and Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "')  ", cnn)

            cnn.Open()

            Dim dr As SqlDataReader = myCommand2.ExecuteReader()

            If dr.Read = True Then

                MsgBox("Data Available")
                ButtonNew.Visible = True
                ButtonAttSheetGenerate.Visible = False
                CBAttendaceAllPA.Visible = True
                Dgv2.Visible = True
                Dgv2.DataSource = ""
                '----------------------------------------------------------
                Dgv2.DataSource = ""

                cnn = New SqlConnection(connetionstring)

                Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50, Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30, Dt31, Dt32, Dt33, Dt34, Dt35, Dt36, Dt37,  Dt38, Dt39, Dt40, Dt41, Dt42, Dt43, Dt44, Dt45, Dt46, Dt47, Dt48, Dt49, Dt50, AYear, StaffID, Course, Year, Subject, ThPr, Batch, Sem   FROM   [05AttSheet]   where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' ", cnn)

                cnn.Open()

                Dgv2.DataSource = myCommand4.ExecuteReader()
             

                Dgv2.DataBind()

                cnn.Close()
                Try
                    Me.Dgv2.Columns(0).Visible = False
                    Me.Dgv2.Columns(1).Visible = False
                    Me.Dgv2.Columns(2).Visible = True
                Catch ex As Exception

                End Try


                LT7.Visible = True
                '---------------------------------------------------------
            Else

                MsgBox("Data Not Available")
                ButtonAttSheetGenerate.Visible = True


            End If

            LabelSubID.DataBind()

            cnn.Close()

            ''---------------------------------------------------------------------------------------------------


        Else

            Dgv1.DataSource = ""

            LabelBatch.Visible = True

            CBBatchName.Visible = True

            LT6.Visible = True

            End If

    End Sub

    Protected Sub ButtonAttSheetGenerate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAttSheetGenerate.Click

        '-------------------------------------------------------------


        cnn = New SqlConnection(connetionstring)

        '  Dim dt As String = Dtp.SelectedDate.Year & "/" & Dtp.SelectedDate.Month & "/" & Dtp.SelectedDate.Day
        '  Dim dt1 As String = Dtp.SelectedDate.Date.ToString
        '  LFullName.Text = TxtFname.Text & " " & TxtMname.Text & " " & TxtLName.Text
        '  Try

        Dim i As Integer

        For i = 0 To Dgv1.Rows.Count - 1

            'MsgBox(Dgv1.Rows(i).Cells(0).Text.ToString)

            Dim myCommandI As New SqlCommand("INSERT INTO [05AttSheet] (RecNo, AYear, StaffID, Course, Year, Subject, ThPr, Batch, Sem, RollNo, FullName)   VALUES   ('" + Dgv1.Rows(i).Cells(0).Text.ToString + "','" + LabelAcademicYear.Text + "', '" + LabelStaffID.Text + "', '" + Dgv1.Rows(i).Cells(4).Text.ToString + "', '" + Dgv1.Rows(i).Cells(5).Text.ToString + "', '" + LabelSubID.Text + "', '" + CBSubjectType.Text + "', '" + LabelBatch.Text + "', '" + CBSemister.Text + "','" + Dgv1.Rows(i).Cells(7).Text.ToString + "', '" + Dgv1.Rows(i).Cells(3).Text.ToString + "' ) ", cnn)

            cnn.Open()

            myCommandI.ExecuteNonQuery()

            'MsgBox("Ok")

            cnn.Close()

        Next

        MsgBox("Attendance Sheet Generate Successfully")

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
        Response.Redirect("AttLogin.aspx")

    End Sub

    Protected Sub CBBatchName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBBatchName.SelectedIndexChanged

        If CBBatchName.SelectedIndex <> 0 Then
            LabelBatch.Text = CBBatchName.Text
        Else
            LabelBatch.Text = ""
        End If

        '----------------------------------------------------------
        Dgv1.DataSource = ""

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT  RecID, AYear'AcademicYear', RegNo, FullName,Course, Year, Status, RollNo, Batch FROM   [02Student] where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and Status='Yes' and Batch='" + LabelBatch.Text + "' ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        '---------------------------------------------------------

        '''''''''' Attendance Sheet Check Code -------------------


        cnn = New SqlConnection(connetionstring)

        Dim myCommand2 As New SqlCommand("SELECT  AYear, Batch, Sem FROM  [05AttSheet] where ( AYear='" + LabelAcademicYear.Text + "' and  StaffID='" + LabelStaffID.Text + "' and  Course='" + LabelCourseID.Text + "' and  Year='" + LabelYearID.Text + "' and Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' and Batch='" + LabelBatch.Text + "')  ", cnn)

        cnn.Open()


        Dim dr As SqlDataReader = myCommand2.ExecuteReader()

        If dr.Read = True Then

            MsgBox("Data Available")
            ButtonAttSheetGenerate.Visible = False
            CBAttendaceAllPA.Visible = True
            Dgv2.Visible = True
            Dgv2.DataSource = ""
            '----------------------------------------------------------
            Dgv2.DataSource = ""

            cnn = New SqlConnection(connetionstring)

            Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50,  Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30, Dt31, Dt32, Dt33, Dt34, Dt35, Dt36, Dt37,  Dt38, Dt39, Dt40, Dt41, Dt42, Dt43, Dt44, Dt45, Dt46, Dt47, Dt48, Dt49, Dt50,  AYear, StaffID, Course, Year, Subject, ThPr, Batch, Sem   FROM   [05AttSheet]   where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' and Batch='" + LabelBatch.Text + "'", cnn)

            cnn.Open()

            Dgv2.DataSource = myCommand4.ExecuteReader()


            Dgv2.DataBind()

            cnn.Close()
            'Try
            '    Me.Dgv2.Columns(0).Visible = False
            '    Me.Dgv2.Columns(1).Visible = False
            '    Me.Dgv2.Columns(2).Visible = True
            'Catch ex As Exception

            'End Try


            LT7.Visible = True
            '---------------------------------------------------------
        Else

            MsgBox("Data Not Available")
            ButtonAttSheetGenerate.Visible = True

        End If



    End Sub

    Protected Sub CBAttendaceAllPA_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBAttendaceAllPA.SelectedIndexChanged
        LAtt.Text = ""
        If CBAttendaceAllPA.SelectedIndex >= 1 Then
            If CBAttendaceAllPA.SelectedIndex = 1 Then
                LAtt.Text = "P"
                LableLAtt.Text = "A"
                LT10.Text = "Type Absent Roll No Only"
                ButtonAbsent.Text = "Absent"
            ElseIf CBAttendaceAllPA.SelectedIndex = 2 Then
                LAtt.Text = "A"
                LableLAtt.Text = "P"
                LT10.Text = "Type Present Roll No Only"
                ButtonAbsent.Text = "Present"
            End If


            ButtonAllPAProcess.Visible = True
            '--------------------------------------------------
            ''-----------------------------------------------

            ''Dim cnn As SqlConnection

            'cnn = New SqlConnection(connetionstring)

            'cnn.Close()

            ''-----------------------------
            'Dim i, r As Integer
            'Try
            '    Dim dt1 As String = Dtp.SelectedDate.Date.ToString

            '    For i = 0 To Dgv2.Rows.Count - 1

            '        Dim myCommandI As New SqlCommand("UPDATE    [05AttSheet]  SET  " + L1.Text + " ='" + LAtt.Text + "', " + LDt.Text + " ='" + dt1.ToString + "' where   RecNo='" + Dgv2.Rows(i).Cells(0).Text.ToString + "' and  AYear='" + LabelAcademicYear.Text + "' and  Course='" + LabelCourseID.Text + "' and  Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "'  and   RollNo='" + Dgv2.Rows(i).Cells(1).Text.ToString + "' ", cnn)

            '        'Try

            '        cnn.Open()

            '        myCommandI.ExecuteNonQuery()



            '        cnn.Close()


            '        'Catch ex As Exception

            '        'End Try

            '    Next

            'Catch ex As Exception

            'End Try

            'MsgBox("Attendance Process Submit All Data")
            ''---------------------------------------------------------------------
            ''----------------------------------------------------------
            'Dgv2.DataSource = ""

            'cnn = New SqlConnection(connetionstring)

            'Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50, L51, L52, L53, L54, L55, L56, L57, L58, L59, L60, L61, L62, L63, L64, L65, L66, L67, L68, L69, L70, L71, L72,  L73, L74, L75, L76, L77, L78, L79, L80, L81, L82, L83, L84, L85, L86, L87, L88, L89, L90, Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30, Dt31, Dt32, Dt33, Dt34, Dt35, Dt36, Dt37,  Dt38, Dt39, Dt40, Dt41, Dt42, Dt43, Dt44, Dt45, Dt46, Dt47, Dt48, Dt49, Dt50, Dt51, Dt52, Dt53, Dt54, Dt55, Dt56, Dt57, Dt58, Dt59, Dt60, Dt61, Dt62,  Dt63, Dt64, Dt65, Dt66, Dt67, Dt68, Dt69, Dt70, Dt71, Dt72, Dt73, Dt74, Dt75, Dt76, Dt77, Dt78, Dt79, Dt80, Dt81, Dt82, Dt83, Dt84, Dt85, Dt86, Dt87, Dt88, Dt89, Dt90, AYear, StaffID, Course, Year, Subject, ThPr, Batch, Sem   FROM   [05AttSheet]   where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' ", cnn)

            'cnn.Open()

            'Dgv2.DataSource = myCommand4.ExecuteReader()


            'Dgv2.DataBind()

            'cnn.Close()

            ''---------------------------------------------------------
            ''-------------------------------------------------------------------

        Else
            ButtonAllPAProcess.Visible = False
        End If
    End Sub

    Protected Sub ButtonAllPAProcess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAllPAProcess.Click
        ButtonNew1.Enabled = True
        ButtonNew1.Visible = True
        TxtAbsentRollNo.Visible = True
        ButtonAbsent.Visible = True
        LT10.Visible = True
        '----------------------------------------
        '-----------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        '-----------------------------
        Dim i As Integer
        Try
            Dim dt1 As String = Dtp.SelectedDate.Date.ToString

            For i = 0 To Dgv2.Rows.Count - 1

                Dim myCommandI As New SqlCommand("UPDATE    [05AttSheet]  SET  " + L1.Text + " ='" + LAtt.Text + "', " + LDt.Text + " ='" + dt1.ToString + "' where   RecNo='" + Dgv2.Rows(i).Cells(0).Text.ToString + "' and  AYear='" + LabelAcademicYear.Text + "' and  Course='" + LabelCourseID.Text + "' and  Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "'  and   RollNo='" + Dgv2.Rows(i).Cells(1).Text.ToString + "' ", cnn)

                'Try

                cnn.Open()

                myCommandI.ExecuteNonQuery()



                cnn.Close()


                'Catch ex As Exception

                'End Try

            Next

        Catch ex As Exception

        End Try

        MsgBox("Attendance Process Submit All Data")
        '---------------------------------------------------------------------
        '----------------------------------------------------------
        Dgv2.DataSource = ""

        cnn = New SqlConnection(connetionstring)

        'Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50, L51, L52, L53, L54, L55, L56, L57, L58, L59, L60, L61, L62, L63, L64, L65, L66, L67, L68, L69, L70, L71, L72,  L73, L74, L75, L76, L77, L78, L79, L80, L81, L82, L83, L84, L85, L86, L87, L88, L89, L90, Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30,  where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' ", cnn)
        Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50,  Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30, Dt31, Dt32, Dt33, Dt34, Dt35, Dt36, Dt37,  Dt38, Dt39, Dt40, Dt41, Dt42, Dt43, Dt44, Dt45, Dt46, Dt47, Dt48, Dt49, Dt50,  AYear, StaffID, Course, Year, Subject, ThPr, Batch, Sem   FROM   [05AttSheet]   where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' ", cnn)
        cnn.Open()

        Dgv2.DataSource = myCommand4.ExecuteReader()


        Dgv2.DataBind()

        cnn.Close()

        '---------------------------------------------------------

    End Sub

    Protected Sub CBLectNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBLectNo.SelectedIndexChanged
        Dtp.SelectedDate = Now.Date
        Dtp.DataBind()

        If CBLectNo.SelectedIndex <> 0 Then
            L1.Text = "L" & CBLectNo.Text
            LDt.Text = "Dt" & CBLectNo.Text
        Else
            L1.Text = ""
            LDt.Text = ""
        End If

        LT8.Visible = True
        ButtonNew.Visible = True

    End Sub


    Protected Sub ButtonAbsent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAbsent.Click
        ButtonNew1.Visible = True

        ButtonNew1.Enabled = True
     
        CBAbsentNo.Items.Clear()
        '  Dim array() As Integer = Split(TxtAbsentRollNo.Text)
        Dim TestString As String = TxtAbsentRollNo.Text
        Dim Array() As String = TestString.Split(",")
        ' Dim LastNonEmpty As Integer = -1
        Dim i As Integer
        For i = 0 To Array.Length - 1
            'If Array(i) <> "" Then
            '    LastNonEmpty += 1
            '    Array(LastNonEmpty) = Array(i)
            CBAbsentNo.Items.Add(Array(i))
            ' End If
        Next
        '-------------------------
        '-----------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        '-----------------------------
        Try

            Dim dt1 As String = Dtp.SelectedDate.Date.ToString

            For i = 0 To CBAbsentNo.Items.Count - 1

                CBAbsentNo.SelectedIndex = i

                Dim myCommandI As New SqlCommand("UPDATE    [05AttSheet]  SET  " + L1.Text + " ='" + LableLAtt.Text + "'  where   AYear='" + LabelAcademicYear.Text + "' and  Course='" + LabelCourseID.Text + "' and  Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "'  and   RollNo='" + CBAbsentNo.Text + "' and Batch='" + LabelBatch.Text + "'  ", cnn)

                'Try

                cnn.Open()

                myCommandI.ExecuteNonQuery()



                cnn.Close()


                'Catch ex As Exception

                'End Try

            Next

        Catch ex As Exception

        End Try

        MsgBox("Attendance Process Submit All Data")
        '---------------------------------------------------------------------
        '----------------------------------------------------------
        Dgv2.DataSource = ""

        cnn = New SqlConnection(connetionstring)

        'Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50, L51, L52, L53, L54, L55, L56, L57, L58, L59, L60, L61, L62, L63, L64, L65, L66, L67, L68, L69, L70, L71, L72,  L73, L74, L75, L76, L77, L78, L79, L80, L81, L82, L83, L84, L85, L86, L87, L88, L89, L90, Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30,   where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' and Batch='" + LabelBatch.Text + "' ", cnn)
        Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50,  Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30, Dt31, Dt32, Dt33, Dt34, Dt35, Dt36, Dt37,  Dt38, Dt39, Dt40, Dt41, Dt42, Dt43, Dt44, Dt45, Dt46, Dt47, Dt48, Dt49, Dt50,  AYear, StaffID, Course, Year, Subject, ThPr, Batch, Sem   FROM   [05AttSheet]   where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' and Batch='" + LabelBatch.Text + "'", cnn)

        cnn.Open()

        Dgv2.DataSource = myCommand4.ExecuteReader()


        Dgv2.DataBind()

        cnn.Close()

        '---------------------------------------------------------

    End Sub

    Protected Sub Dtp_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtp.SelectionChanged

        LT9.Visible = True

    End Sub

    Protected Sub ButtonNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        Dim TL, TP, TA, i, r, avg As Integer

        r = 0
        ' Try
        '-----------------------------------------
        For r = 0 To Val(Dgv2.Rows.Count.ToString) - 1

            Try
                TL = 0
                TP = 0
                TA = 0
                avg = 0
                For i = 6 To 91

                    If Dgv2.Rows(0).Cells(i).Text = "P" Or Dgv2.Rows(0).Cells(i).Text = "A" Then
                        TL = TL + 1
                    End If

                    If Dgv2.Rows(r).Cells(i).Text = "P" Then
                        TP = TP + 1
                    End If

                    If Dgv2.Rows(r).Cells(i).Text = "A" Then
                        TA = TA + 1
                    End If

                Next i

            Catch ex As Exception

            End Try

            avg = Format(Val(TP) * 100 / Val(TL), "n2")

            MsgBox(TL.ToString & " Present :" & TP.ToString & "  Absent:" & TA.ToString & "  Average:" & avg.ToString)
            '-----------------------------------------------
            ' Try
            'Dim cnn As SqlConnection

            cnn = New SqlConnection(connetionstring)

            cnn.Close()

            '-----------------------------

            Dim myCommandI As New SqlCommand("UPDATE  [05AttSheet]  SET  TL='" + TL.ToString + "', TP='" + TP.ToString + "', TA='" + TA.ToString + "', Avg='" + avg.ToString + "'  where   AYear='" + LabelAcademicYear.Text + "' and  Course='" + LabelCourseID.Text + "' and  Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "'  and   RollNo='" + Dgv2.Rows(r).Cells(1).Text + "'  ", cnn)

            'Try

            cnn.Open()

            myCommandI.ExecuteNonQuery()

            cnn.Close()


            'Catch ex As Exception

            'End Try

            MsgBox("Attendance Calculation")
            '---------------------------------------------------------------------
        Next r
        '---------------------------------------
        'Catch ex As Exception

        'End Try


        '----------------------------------------------------------
        Dgv2.DataSource = ""

        cnn = New SqlConnection(connetionstring)

        ' Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50, L51, L52, L53, L54, L55, L56, L57, L58, L59, L60, L61, L62, L63, L64, L65, L66, L67, L68, L69, L70, L71, L72,  L73, L74, L75, L76, L77, L78, L79, L80, L81, L82, L83, L84, L85, L86, L87, L88, L89, L90, Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26,                         where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "'  ", cnn)
        Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50,  Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30, Dt31, Dt32, Dt33, Dt34, Dt35, Dt36, Dt37,  Dt38, Dt39, Dt40, Dt41, Dt42, Dt43, Dt44, Dt45, Dt46, Dt47, Dt48, Dt49, Dt50,  AYear, StaffID, Course, Year, Subject, ThPr, Batch, Sem   FROM   [05AttSheet]   where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' ", cnn)

        cnn.Open()

        Dgv2.DataSource = myCommand4.ExecuteReader()

        Dgv2.DataBind()

        cnn.Close()

        '---------------------------------------------------------

      
    End Sub

    Protected Sub ButtonNew1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew1.Click
        Dim TL, TP, TA, i, r, avg As Integer

        r = 0
        ' Try
        '-----------------------------------------
        For r = 0 To Val(Dgv2.Rows.Count.ToString) - 1

            Try
                TL = 0
                TP = 0
                TA = 0
                avg = 0
                For i = 6 To 91

                    If Dgv2.Rows(0).Cells(i).Text = "P" Or Dgv2.Rows(0).Cells(i).Text = "A" Then
                        TL = TL + 1
                    End If

                    If Dgv2.Rows(r).Cells(i).Text = "P" Then
                        TP = TP + 1
                    End If

                    If Dgv2.Rows(r).Cells(i).Text = "A" Then
                        TA = TA + 1
                    End If

                Next i

            Catch ex As Exception

            End Try

            avg = Format(Val(TP) * 100 / Val(TL), "n2")

            '   MsgBox(TL.ToString & " Present :" & TP.ToString & "  Absent:" & TA.ToString & "  Average:" & avg.ToString)
            '-----------------------------------------------
            ' Try
            'Dim cnn As SqlConnection

            cnn = New SqlConnection(connetionstring)

            cnn.Close()

            '-----------------------------

            Dim myCommandI As New SqlCommand("UPDATE  [05AttSheet]  SET  TL='" + TL.ToString + "', TP='" + TP.ToString + "', TA='" + TA.ToString + "', Avg='" + avg.ToString + "'  where   AYear='" + LabelAcademicYear.Text + "' and  Course='" + LabelCourseID.Text + "' and  Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "'  and   RollNo='" + Dgv2.Rows(r).Cells(1).Text + "'  ", cnn)

            'Try

            cnn.Open()

            myCommandI.ExecuteNonQuery()

            cnn.Close()


            'Catch ex As Exception

            'End Try

            ' MsgBox("Attendance Calculation")
            '---------------------------------------------------------------------
        Next r
        '---------------------------------------
        'Catch ex As Exception

        'End Try


        '----------------------------------------------------------
        Dgv2.DataSource = ""

        cnn = New SqlConnection(connetionstring)

        ' Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50, L51, L52, L53, L54, L55, L56, L57, L58, L59, L60, L61, L62, L63, L64, L65, L66, L67, L68, L69, L70, L71, L72,  L73, L74, L75, L76, L77, L78, L79, L80, L81, L82, L83, L84, L85, L86, L87, L88, L89, L90, Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26,                         where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "'  ", cnn)
        Dim myCommand4 As New SqlCommand("SELECT  RecNo,RollNo, FullName, TL, TP, TA, Avg, L1, L2, L3, L4, L5, L6, L7, L8, L9, L10, L11, L12,  L13, L14, L15, L16, L17, L18, L19, L20, L21, L22, L23, L24, L25, L26, L27, L28, L29, L30, L31, L32, L33, L34, L35, L36, L37, L38, L39, L40, L41, L42,  L43, L44, L45, L46, L47, L48, L49, L50,  Dt1, Dt2, Dt3, Dt4, Dt5, Dt6, Dt7, Dt8, Dt9, Dt10, Dt11, Dt12,  Dt13, Dt14, Dt15, Dt16, Dt17, Dt18, Dt19, Dt20, Dt21, Dt22, Dt23, Dt24, Dt25, Dt26, Dt27, Dt28, Dt29, Dt30, Dt31, Dt32, Dt33, Dt34, Dt35, Dt36, Dt37,  Dt38, Dt39, Dt40, Dt41, Dt42, Dt43, Dt44, Dt45, Dt46, Dt47, Dt48, Dt49, Dt50,  AYear, StaffID, Course, Year, Subject, ThPr, Batch, Sem   FROM   [05AttSheet]   where AYear='" + LabelAcademicYear.Text + "' and Course='" + LabelCourseID.Text + "' and Year='" + LabelYearID.Text + "' and  Subject='" + LabelSubID.Text + "' and  ThPr='" + CBSubjectType.Text + "' ", cnn)

        cnn.Open()

        Dgv2.DataSource = myCommand4.ExecuteReader()

        Dgv2.DataBind()

        cnn.Close()

        '---------------------------------------------------------
        MsgBox("Attendance Calculation Process Completed")
    End Sub

    Protected Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete

    End Sub
End Class
