Imports System

Imports System.Data

Imports System.Data.SqlClient

Imports System.Configuration

Imports System.Windows.Forms

Partial Class AttLogin

    Inherits System.Web.UI.Page

    Dim cnn As SqlConnection

    Dim connetionstring As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Attendance;Data Source=Server"



    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        '  Response.Redirect("Main.aspx")
        Response.Redirect("Main.aspx")
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonLogIn.Click
        LabelStaffID.Text = ""
        Textbox1.Text = ""
        LStaffNameFull.Text = ""

        cnn = New SqlConnection(connetionstring)

        Dim myCommand1 As New SqlCommand("SELECT  RecID, FullName  FROM [03Staff]  where  [User]='" + TxtUserName.Text + "' and  Pass='" + TxtPassword.Text + "'  ", cnn)

        cnn.Open()

        Dim dr As SqlDataReader = myCommand1.ExecuteReader()

        If dr.Read = True Then

            LabelStaffID.Text = (dr(0).ToString)
            Textbox1.Text = (dr(0).ToString)

            LStaffNameFull.Text = (dr(1).ToString)

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

                Session("LStaffName") = LStaffNameFull.Text

                Response.Redirect("AttProcess.aspx")

            End If



        Else
            MsgBox("Sorry! Wrong Password or UserName Please Try again")
            TxtPassword.Text = ""
            TxtUserName.Text = ""
            TxtUserName.Focus()
        End If
      
    End Sub

    Public ReadOnly Property staffID() As String
        Get
            Return LabelStaffID.Text
        End Get
    End Property

End Class
