Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Imports System.IO.File

Imports System.IO

Imports System.Web.Mail

Imports System.Net.Mail

Imports System.Net.Mail.MailMessage



Partial Class Mail

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"

   
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

        Dim myCommand3 As New SqlCommand("SELECT AYear'AcademicYear', RegNo, FullName ,LEmail   FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "' and (Status ='Yes') Order by RollNo Asc", cnn)
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

        Dim myCommand3 As New SqlCommand("SELECT  AYear'AcademicYear', RegNo, FullName ,LEmail  FROM   [02Student] where AYear='" + CBAcadYear.Text + "' and Course='" + LCourseID.Text + "'  and Year='" + LYearID.Text + "' and (Status ='Yes') ", cnn)

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

   
    Protected Sub ButtonSendMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonSendMail.Click

        Dim mailstring As String

        mailstring = ""

        mailstring = TxtComments.Text

        Dim SmtpServer As New SmtpClient()

        SmtpServer.Credentials = New Net.NetworkCredential(LMailID.Text, Lemail.Text)

        SmtpServer.Port = 587

        SmtpServer.Host = "smtp.gmail.com"

        SmtpServer.EnableSsl = True

        Dim mail As New System.Net.Mail.MailMessage

        Dim addr() As String = TxtEmail.Text.Split(",") '''' TO

        'Dim addrbcc() As String = LBcc.Text.Split(",") '''' LBCC

        'Dim addrcc() As String = LBcc.Text.Split(",") '''' LCC

        Try
            mail.From = New MailAddress("srevgade@gmail.com", "Engg.College", System.Text.Encoding.UTF8)

            Dim i As Byte

            For i = 0 To addr.Length - 1

                mail.To.Add(addr(i))

            Next

            'Dim i2 As Byte

            'For i2 = 0 To addrcc.Length - 1

            '    Mail.CC.Add(addrcc(i2))

            'Next

            'Dim i3 As Byte

            'For i3 = 0 To addrbcc.Length - 1

            '    Mail.Bcc.Add(addrbcc(i3))

            'Next

            mail.Subject = TxtSubject.Text

            mail.Body = mailstring.ToString()

            '-----------------------------------

            ' Mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure

            mail.ReplyTo = New MailAddress("srevgade@gmail.com")

            mail.Body = mailstring.ToString()

            SmtpServer.Send(mail)
            MsgBox("Email sent successfully")

        Catch ex As Exception

            ' MsgBox(ex.ToString())

        End Try



    End Sub

    Protected Sub CBAll_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBAll.SelectedIndexChanged
        Try
            If CBAll.SelectedIndex = 1 Or CBAll.SelectedIndex = 2 Then
                TxtEmail.Text = ""
            Else
                TxtEmail.Text = ""
                Dim i As Integer
                For i = 0 To Dgv1.Rows.Count - 1
                    If Dgv1.Rows(i).Cells(4).Text = "&nbsp;" Or Dgv1.Rows(i).Cells(4).Text = "" Then

                    Else
                        If Dgv1.Rows(i).Cells(4).Text <> "&nbsp;" Or Dgv1.Rows(i).Cells(4).Text <> "" Then

                            If TxtEmail.Text = "" Then
                                TxtEmail.Text = Dgv1.Rows(i).Cells(4).Text.ToString
                            Else
                                TxtEmail.Text = TxtEmail.Text & "," & Dgv1.Rows(i).Cells(4).Text.ToString
                            End If
                        End If
                    End If

                Next
            End If

        Catch ex As Exception

        End Try
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


    Protected Sub Dgv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dgv1.SelectedIndexChanged
        Try
            If Dgv1.SelectedRow.Cells(4).Text = "&nbsp;" Or Dgv1.SelectedRow.Cells(4).Text = "" Then
                'MsgBox("blank")
            Else
                If Dgv1.SelectedRow.Cells(4).Text <> "&nbsp;" Or Dgv1.SelectedRow.Cells(4).Text <> "" Then

                    If TxtEmail.Text = "" Then
                        TxtEmail.Text = Dgv1.SelectedRow.Cells(4).Text.ToString()
                    Else
                        TxtEmail.Text = TxtEmail.Text & "," & Dgv1.SelectedRow.Cells(4).Text.ToString()
                    End If

                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        Response.Redirect("Main.aspx")

    End Sub
End Class
