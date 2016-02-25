Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms


Partial Class Year
   
    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click

        Response.Redirect("Main.aspx")

    End Sub

    Protected Sub Button9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.Click

        Response.Redirect("Main.aspx")

    End Sub

    Protected Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click

        If txtCode.Text <> "" And txtName.Text <> "" Then
            txtCode.Text = txtCode.Text.ToUpper
            txtName.Text = txtName.Text.ToUpper
            '-----------------------------------

            cnn = New SqlConnection(connetionstring)

            'CBSearch.Items.Clear()

            Dim myCommand1 As New SqlCommand("SELECT  Count(RecNo) FROM [01Class]where Type='" + LType.Text + "' ", cnn)

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

            Dim myCommand2 As New SqlCommand("SELECT RecNo FROM [01Class]where Type='" + LType.Text + "' and (Code='" + txtCode.Text + "' or Name='" + txtName.Text + "') ", cnn)

            cnn.Open()

            Dim dr2 As SqlDataReader = myCommand2.ExecuteReader()

            If dr2.Read = True Then

                '   MsgBox("Duplicate Entry", MsgBoxStyle.Information = MsgBoxStyle.OkOnly, "Error")
                LabelMessage.Text = "Duplicate Entry"
            Else
                '-----------------------------------------------

                'Dim cnn As SqlConnection

                cnn = New SqlConnection(connetionstring)

                cnn.Close()
                '-----------------------------

                Dim myCommandI As New SqlCommand("INSERT INTO [01Class] (RecNo, Code, Name, Type)  VALUES ('" + LRecID.Text + "', '" + txtCode.Text + "', '" + txtName.Text + "', '" + LType.Text + "')", cnn)

                Try

                    cnn.Open()

                    myCommandI.ExecuteNonQuery()

                    '   MsgBox("Saved Successfully")
                    LabelMessage.Text = "Saved Successfully"
                    cnn.Close()

                Catch ex As Exception

                End Try

                '-----------------------------------

                Try

                    Dim myCommand3 As New SqlCommand("SELECT RecNo, Code, Name, Type  FROM [01Class] where Type='" + LType.Text + "' ", cnn)

                    cnn.Open()

                    Dgv1.DataSource = myCommand3.ExecuteReader()

                    Dgv1.DataBind()

                    cnn.Close()
                    '---------------------------------

                Catch ex As Exception

                End Try

                txtCode.Text = ""
                txtName.Text = ""
                txtName.Focus()

            End If

        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cnn = New SqlConnection(connetionstring)

        Dim myCommand As New SqlCommand("SELECT RecNo, Code, Name, Type  FROM [01Class] where Type='" + LType.Text + "'", cnn)

        cnn.Open()

        Dgv1.DataSource = myCommand.ExecuteReader()

        Dgv1.DataBind()

        cnn.Close()

        '-----------------------------------

    End Sub

    Protected Sub ButtonExit0_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit0.Click

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)


        Dim myCommand1 As New SqlCommand("SELECT  RecNo,  Code, Name, Type  FROM [01Class]where Type='" + LType.Text + "' ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        If dr.Read = True Then

            txtCode.Text = (dr(1).ToString())

        End If

        'While dr.Read()

        '    CBSearch.Items.Add(dr(1).ToString())

        'End While

        cnn.Close()
        '------------------------------------------

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

        cnn.Close()

        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        Dim myCommand1 As New SqlCommand("SELECT  RecNo,  Code, Name, Type  FROM [01Class]where Type='" + LType.Text + "' and  RecNo='" + Dgv1.SelectedRow.Cells(1).Text.ToString + "'", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        If dr.Read = True Then

            LRecID.Text = (dr(0).ToString)

            txtCode.Text = (dr(1).ToString)

            txtName.Text = (dr(2).ToString)

            LType.Text = (dr(3).ToString)

        End If

        ' CBSearch.Items.Add(dr(1).ToString())

        ' End While


        txtCode.DataBind()

        txtName.DataBind()

        cnn.Close()

        ''------------------------------------------

    End Sub

    Protected Sub ButtonNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonNew.Click
        LabelMessage.Text = ""
        '-----------------------------------

        cnn = New SqlConnection(connetionstring)

        'CBSearch.Items.Clear()

        Dim myCommand1 As New SqlCommand("SELECT  Count(RecNo) FROM [01Class]where Type='" + LType.Text + "' ", cnn)

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

        txtName.Text = ""

        txtCode.Text = ""

        txtCode.Focus()

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
        txtCode.Text = txtCode.Text.ToUpper
        txtName.Text = txtName.Text.ToUpper

        cnn = New SqlConnection(connetionstring)

        cnn.Close()

        '-----------------------------

        Dim myCommandI As New SqlCommand("UPDATE   [01Class]  SET   Name ='" + txtName.Text + "', Code='" + txtCode.Text + "' where   (RecNo ='" + LRecID.Text + "') and (Type ='" + LType.Text + "')", cnn)

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

            Dim myCommand3 As New SqlCommand("SELECT RecNo, Code, Name, Type  FROM [01Class] where Type='" + LType.Text + "'", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()
            '---------------------------------

        Catch ex As Exception

        End Try

        '   End If

        ' End If

    End Sub

    Protected Sub ButtonDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click

       
        '------------------------------------------

        Dim cnn As SqlConnection

        cnn = New SqlConnection(connetionstring)

        cnn.Close()
        '-----------------------------

        Dim myCommandI As New SqlCommand("DELETE FROM [01Class]  where   RecNo ='" + LRecID.Text + "' and Type ='" + LType.Text + "' ", cnn)

        cnn.Open()

        myCommandI.ExecuteNonQuery()

        '  MsgBox("Delete")
        LabelMessage.Text = "Delete Successfully"

        cnn.Close()

      

        '-----------------------------------
        Try

            Dim myCommand3 As New SqlCommand("SELECT RecNo, Code, Name, Type  FROM [01Class] where Type='" + LType.Text + "' ", cnn)

            cnn.Open()

            Dgv1.DataSource = myCommand3.ExecuteReader()

            Dgv1.DataBind()

            cnn.Close()

            '---------------------------------

        Catch ex As Exception

        End Try

        ' End If

    End Sub

    Protected Sub txtCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        txtCode.Text.ToUpper()
    End Sub

    Protected Sub txtName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub
End Class
