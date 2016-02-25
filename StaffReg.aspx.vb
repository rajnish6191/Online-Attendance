Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Partial Class StaffReg

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        If LSta.Text = "0" Then
            Response.Redirect("Main.aspx")
        Else
            Response.Redirect("AttLogin.aspx")
        End If

    End Sub

    Protected Sub ButtonExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        TxtFName.Text = TxtFName.Text.ToUpper
        TxtMName.Text = TxtMName.Text.ToUpper
        TxtLName.Text = TxtLName.Text.ToUpper
        '-----------------------------------


        If TxtUserName.Text <> "" And TxtPassword.Text <> "" And TxtReTypePassword.Text <> "" And TxtFName.Text <> "" And TxtMName.Text <> "" And TxtLName.Text <> "" Then

            If TxtReTypePassword.Text <> TxtPassword.Text Then
                TxtPassword.Text = ""
                TxtReTypePassword.Text = ""
                TxtPassword.Focus()
                LMsg.Visible = True
            Else
                LMsg.Visible = False
            End If

            '-----------------------------------

            cnn = New SqlConnection(connetionstring)

            'CBSearch.Items.Clear()

            Dim myCommand1 As New SqlCommand("SELECT  Max(RecID) FROM [03Staff]", cnn)

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

            Dim myCommand2 As New SqlCommand("SELECT RecID FROM [03Staff]  where (RecID='" + LRecID.Text + "')  and (  FName='" + TxtFName.Text + "' and MName='" + TxtMName.Text + "' and LName='" + TxtLName.Text + "' and ShortName='" + TxtShortName.Text + "') ", cnn)

            cnn.Open()

            Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

            If dr2.Read = True Then

                ' MsgBox("Duplicate Entry", MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "Error")
                LabelMessage.Text = "Duplicate Entry"

            Else
                '-----------------------------------------------

                'Dim cnn As SqlConnection

                cnn = New SqlConnection(connetionstring)

                cnn.Close()
                '-----------------------------  
                ' Dim dt As String = Dtp.SelectedDate.Year & "/" & Dtp.SelectedDate.Month & "/" & Dtp.SelectedDate.Day
                'Dim dt1 As String = Dtp.SelectedDate.Date.ToString
                LFullName.Text = TxtFName.Text & " " & TxtMName.Text & " " & TxtLName.Text

                Dim myCommandI As New SqlCommand("INSERT INTO [03Staff] (RecID, FName, MName, LName, Quali, Desg, Exp, [Add], Mo, Email, [User], Pass, Status, FullName,Type,ShortName) VALUES  ('" + LRecID.Text + "', '" + TxtFName.Text + "', '" + TxtMName.Text + "', '" + TxtLName.Text + "', '" + TxtQuallification.Text + "', '" + CBDesignaton.Text + "', '" + TxtExperience.Text + "', '" + TxtAddress.Text + "', '" + TxtMobileNo.Text + "', '" + TxtEmailID.Text + "', '" + TxtUserName.Text + "', '" + TxtPassword.Text + "', '" + CBStatus.Text + "', '" + LFullName.Text + "','" + CBType.Text + "','" + TxtShortName.Text + "') ", cnn)

                '  Try

                cnn.Open()

                myCommandI.ExecuteNonQuery()

                'MsgBox("Ok")
                LabelMessage.Text = "Saved Successfully"

                cnn.Close()

                'Catch ex As Exception

                'End Try

                '-----------------------------------

                Try

                    cnn = New SqlConnection(connetionstring)

                    Dim myCommand3 As New SqlCommand("SELECT RecID, FName, MName, LName, ShortName,Type,Quali,Type, Desg, Exp,  Mo, Email, [User], Status   FROM    [03Staff] ", cnn)

                    cnn.Open()

                    Dgv1.DataSource = myCommand3.ExecuteReader()

                    Dgv1.DataBind()

                    cnn.Close()

                    '---------------------------------

                Catch ex As Exception

                End Try

            End If
            ' TxtRegNo.Text = ""
            TxtFName.Text = ""
            TxtMName.Text = ""
            TxtLName.Text = ""
            TxtQuallification.Text = ""
            CBDesignaton.SelectedIndex = 0
            TxtExperience.Text = ""
            TxtAddress.Text = ""
            TxtMobileNo.Text = ""
            TxtEmailID.Text = ""
            TxtUserName.Text = ""
            ' Dtp.SelectedDate = ""

            TxtFName.Focus()

        End If

    End Sub

    Protected Sub Page_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        Session("textboxvalue") = ""
        Session("status") = "0"
        LStaffID.Text = ""
        LSta.Text = ""
    End Sub

    Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
       
    End Sub

    

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        LStaffID.Text = ""
        LSta.Text = "0"

        cnn = New SqlConnection(connetionstring)

        Dim myCommand3 As New SqlCommand("SELECT RecID, FName, MName, LName,ShortName, Type, Quali, Desg, Exp,  Mo, Email, [User],  Status   FROM    [03Staff] ", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand3.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        '-----------------------------------
        '  Session("textboxvalue") = ""
        LStaffID.Text = Session("textboxvalue")
        LSta.Text = Session("status")

        If LSta.Text = "1" Then
            Try
                ButtonAdd.Enabled = False

                ButtonNew.Enabled = False

                ButtonEdit.Enabled = True

                ButtonDelete.Enabled = False

                Dgv1.Visible = False

                ButtonExit0.Visible = False

                TxtFName.ReadOnly = True
                TxtMName.ReadOnly = True
                TxtLName.ReadOnly = True
                TxtQuallification.ReadOnly = True
                CBType.Enabled = False
                CBDesignaton.Enabled = False
                TxtExperience.ReadOnly = True
                TxtAddress.ReadOnly = True
                TxtUserName.ReadOnly = True
                CBStatus.Enabled = False
                TxtShortName.ReadOnly = True

                '-------------------------------------------

                cnn = New SqlConnection(connetionstring)
                '''''''''''''''''''''''''''''''''''''''    0      1      2      3     4     5      6    7    8      9    10   11     12      13       14       15
                Dim myCommand1 As New SqlCommand("SELECT RecID, FName, MName, LName, Type, Quali, Type,Desg, Exp, [Add], Mo, Email, [User], Status, FullName ,ShortName  FROM    [03Staff]  where    RecID='" + LStaffID.Text + "' ", cnn)

                cnn.Open()

                Dim dr As SqlDataReader = myCommand1.ExecuteReader()

                If dr.Read = True Then

                    LRecID.Text = (dr(0).ToString)
                    TxtFName.Text = (dr(1).ToString)
                    TxtMName.Text = (dr(2).ToString)
                    TxtLName.Text = (dr(3).ToString)
                    TxtQuallification.Text = (dr(5).ToString)
                    CBType.Text = (dr(6).ToString)
                    CBDesignaton.Text = (dr(7).ToString)
                    TxtExperience.Text = (dr(8).ToString)
                    TxtAddress.Text = (dr(9).ToString)
                    TxtMobileNo.Text = (dr(10).ToString)
                    TxtEmailID.Text = (dr(11).ToString)
                    TxtUserName.Text = (dr(12).ToString)
                    CBStatus.Text = (dr(13).ToString)
                    TxtShortName.Text = (dr(15).ToString)

                End If


                LRecID.DataBind()
                'TxtRegNo.DataBind()
                TxtFName.DataBind()
                TxtMName.DataBind()
                TxtLName.DataBind()
                CBStatus.DataBind()
                TxtQuallification.DataBind()
                CBType.DataBind()
                CBDesignaton.DataBind()
                TxtExperience.DataBind()
                TxtAddress.DataBind()
                TxtMobileNo.DataBind()
                TxtEmailID.DataBind()
                TxtUserName.DataBind()
                TxtShortName.DataBind()
                TxtPassword.Text = ""
                TxtReTypePassword.Text = ""
                cnn.Close()

                'LStaffID.Text = ""
                'LSta.Text = ""
                Session("status") = "0"
                ''------------------------------------------
            Catch ex As Exception

            End Try

        Else
            ButtonAdd.Enabled = True

            ButtonNew.Enabled = True

            ButtonEdit.Enabled = False

            ButtonDelete.Enabled = True

            Dgv1.Visible = True

            ButtonExit0.Visible = True

            TxtFName.ReadOnly = False
            TxtMName.ReadOnly = False
            TxtLName.ReadOnly = False
            TxtQuallification.ReadOnly = False
            CBType.Enabled = True
            CBDesignaton.Enabled = True
            TxtExperience.ReadOnly = False
            TxtAddress.ReadOnly = False
            TxtUserName.ReadOnly = False
            CBStatus.Enabled = True
            TxtShortName.ReadOnly = False

        End If

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

        Try

            cnn.Close()
            'TxtFName.Text = ""
            'TxtMName.Text = ""
            'TxtLName.Text = ""
            'TxtQuallification.Text = ""
            'CBType.Text = ""
            'CBDesignaton.Text = ""
            'TxtExperience.Text = ""
            'TxtAddress.Text = ""
            'TxtMobileNo.Text = ""
            'TxtEmailID.Text = ""
            'TxtUserName.Text = ""
            'CBStatus.Text = ""
            'TxtShortName.Text = ""
            '-----------------------------------

            cnn = New SqlConnection(connetionstring)

            Dim myCommand1 As New SqlCommand("SELECT RecID, FName, MName, LName, Type, Quali, Type,Desg, Exp, [Add], Mo, Email, [User], Status, FullName ,ShortName  FROM    [03Staff]  where    RecID='" + Dgv1.SelectedRow.Cells(1).Text.ToString + "' ", cnn)

            cnn.Open()

            Dim dr As SqlDataReader = myCommand1.ExecuteReader()

            If dr.Read = True Then

                LRecID.Text = (dr(0).ToString)
                TxtFName.Text = (dr(1).ToString)
                TxtMName.Text = (dr(2).ToString)
                TxtLName.Text = (dr(3).ToString)
                TxtQuallification.Text = (dr(4).ToString)
                CBType.Text = (dr(5).ToString)
                CBDesignaton.Text = (dr(6).ToString)
                TxtExperience.Text = (dr(7).ToString)
                TxtAddress.Text = (dr(8).ToString)
                TxtMobileNo.Text = (dr(9).ToString)
                TxtEmailID.Text = (dr(10).ToString)
                TxtUserName.Text = (dr(11).ToString)
                CBStatus.Text = (dr(12).ToString)
                TxtShortName.Text = (dr(15).ToString)
               
            End If


            LRecID.DataBind()
            'TxtRegNo.DataBind()
            TxtFname.DataBind()
            TxtMname.DataBind()
            TxtLName.DataBind()
            CBStatus.DataBind()
            TxtQuallification.DataBind()
            CBType.DataBind()
            CBDesignaton.DataBind()
            TxtExperience.DataBind()
            TxtAddress.DataBind()
            TxtMobileNo.DataBind()
            TxtEmailID.DataBind()
            TxtUserName.DataBind()
            TxtShortName.DataBind()
            TxtPassword.Text = ""
            TxtReTypePassword.Text = ""
            cnn.Close()

            ''------------------------------------------

        Catch ex As Exception

        End Try


        '-----------------------------------


    End Sub

    Protected Sub ButtonNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew.Click

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        'CBSearch.Items.Clear()

        Dim myCommand1 As New SqlCommand("SELECT  Count(RecID) FROM  [03Staff]  ", cnn)

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

        ' TxtRegNo.Text = ""
        TxtFname.Text = ""
        TxtMname.Text = ""
        TxtLName.Text = ""
        TxtQuallification.Text = ""
        CBDesignaton.SelectedIndex = 0
        TxtExperience.Text = ""
        TxtAddress.Text = ""
        TxtMobileNo.Text = ""
        TxtEmailID.Text = ""
        TxtUserName.Text = ""
        TxtShortName.Text = ""
        ' Dtp.SelectedDate = ""

        TxtFname.Focus()

    End Sub

    Protected Sub ButtonEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        TxtFName.Text = TxtFName.Text.ToUpper
        TxtMName.Text = TxtMName.Text.ToUpper
        TxtLName.Text = TxtLName.Text.ToUpper
        '-----------------------------------

        '-----------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        '-----------------------------

        'Dim dt1 As String = Dtp.SelectedDate.Date.ToString
        LFullName.Text = TxtFname.Text & " " & TxtMname.Text & " " & TxtLName.Text
        'DOB ='" + dt1.ToString + "',
        If TxtReTypePassword.Text <> TxtPassword.Text Then
            TxtPassword.Text = ""
            TxtReTypePassword.Text = ""
            TxtPassword.Focus()
            LMsg.Visible = True
        Else
            LMsg.Visible = False

            Dim myCommandI As New SqlCommand("UPDATE  [03Staff] SET  FName ='" + TxtFName.Text + "', MName ='" + TxtMName.Text + "', LName ='" + TxtLName.Text + "', Quali ='" + TxtQuallification.Text + "', Desg ='" + CBDesignaton.Text + "', Exp ='" + TxtExperience.Text + "', [Add] ='" + TxtAddress.Text + "', Mo ='" + TxtMobileNo.Text + "', Email ='" + TxtEmailID.Text + "',  Status ='" + CBStatus.Text + "', FullName ='" + LFullName.Text + "', Type='" + CBType.Text + "', ShortName='" + TxtShortName.Text + "',Pass='" + TxtPassword.Text + "'  where   RecID =" + LRecID.Text + " ", cnn)
            '[User] ='" + TxtUserName.Text + "', Pass ='" + TxtPassword.Text + "',
            'Try
            myCommandI.ExecuteNonQuery()

            ' MsgBox("Update Successfully")
            LabelMessage.Text = "Update Successfully"

            cnn.Close()

        End If

       
        cnn.Open()

      
        'Catch ex As Exception

        'End Try

        '-----------------------------------

        Try

            cnn = New SqlConnection(connetionstring)

            Dim myCommand3 As New SqlCommand("SELECT RecID, FName, MName, LName,ShortName, Type,Quali, Desg, Exp,  Mo, Email, [User],  Status   FROM    [03Staff] ", cnn)

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
        TxtFName.Text = TxtFName.Text.ToUpper
        TxtMName.Text = TxtMName.Text.ToUpper
        TxtLName.Text = TxtLName.Text.ToUpper
        '-----------------------------------


        '------------------------------------------

        'Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()
        '-----------------------------

        Dim myCommandI As New SqlCommand("DELETE FROM [03Staff] where   RecID =" + LRecID.Text + " ", cnn)

        '  Try

        cnn.Open()

        myCommandI.ExecuteNonQuery()

        '   MsgBox("Delete")
        LabelMessage.Text = "Delete Successfully"

        cnn.Close()

        'Catch ex As Exception

        'End Try

        '-----------------------------------

        Try

            cnn = New SqlConnection(connetionstring)

            Dim myCommand3 As New SqlCommand("SELECT RecID, FName, MName, LName,ShortName, Type, Quali, Desg, Exp,  Mo, Email, [User],  Status   FROM    [03Staff] ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

            '-----------------------------------------

        Catch ex As Exception

        End Try

    End Sub


    Protected Sub ButtonExit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit1.Click

        If TxtReTypePassword.Text <> TxtPassword.text Then
            TxtPassword.Text = ""
            TxtReTypePassword.Text = ""
            TxtPassword.Focus()
            ' LMsg.Visible = True
            LabelMessage.Text = "Sorry wrong Password ! Please Try again..."
        Else
            LMsg.Visible = False
            LabelMessage.Text = ""
        End If
    End Sub

    Protected Sub TxtPassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged
        '  TxtPassword.Attributes.Add("value", "ThePassword")
    End Sub

    Protected Sub CBType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBType.SelectedIndexChanged
        If CBType.SelectedIndex = 0 Then
            CBDesignaton.Items.Clear()
            CBDesignaton.Items.Add("Associate Prof")
            CBDesignaton.Items.Add("Assistance Prof")
            CBDesignaton.Items.Add("Prof")
            CBDesignaton.Items.Add("Lecture")
        ElseIf CBType.SelectedIndex = 1 Then
            CBDesignaton.Items.Clear()
            CBDesignaton.Items.Add("Supporting Staff")
            CBDesignaton.Items.Add("Lab Assist")
            CBDesignaton.Items.Add("Peon")
        ElseIf CBType.SelectedIndex = 2 Then
            CBDesignaton.Items.Clear()
            CBDesignaton.Enabled = False
            TxtExperience.Enabled = False

        End If

    End Sub
End Class
