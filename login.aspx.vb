
Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms


Public Class login
    
  Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"

  
    Protected Sub ButtonLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        LabelStaffID.Text = ""
        Textbox1.Text = ""
        LDesg.Text = ""
        LMsg.Visible = False
        cnn = New SqlConnection(connetionstring)

        Dim myCommand1 As New SqlCommand("SELECT  RecID,Desg  FROM [03Staff]  where  [User]='" + TxtUserName.Text + "' and  Pass='" + TxtPassword.Text + "'  ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        If dr.Read = True Then

            LabelStaffID.Text = (dr(0).ToString)
            Textbox1.Text = (dr(0).ToString)
            LDesg.Text = (dr(1).ToString)

        End If

        LabelStaffID.DataBind()

        Textbox1.DataBind()

        cnn.Close()

        ''------------------------------------------
        If Textbox1.Text <> "" Then
            'MsgBox("Login Successfully")

            LabelStaffID.DataBind()

            Textbox1.DataBind()

            If LabelStaffID.Text = Textbox1.Text Then

                Session("textboxvalue") = Textbox1.Text

                Session("AcademicYear") = CBAcadYear.Text

                Session("Desg") = LDesg.Text

                Response.Redirect("Main.aspx")

            End If



        ElseIf (TxtUserName.Text = "Admin" Or TxtUserName.Text = "admin") And (TxtPassword.Text = "Admin" Or TxtPassword.Text = "admin") Then
            Response.Redirect("Main.aspx")
        Else
            LMsg.Visible = True
            TxtPassword.Text = ""
            TxtUserName.Text = ""
            TxtUserName.Focus()
        End If
        '-----------------------------------------------------------
      

    End Sub
End Class
