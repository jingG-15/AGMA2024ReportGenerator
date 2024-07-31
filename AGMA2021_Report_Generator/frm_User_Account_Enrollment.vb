

Imports MySql.Data.MySqlClient

Public Class frm_User_Account_Enrollment
    Private Sub frm_User_Account_Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_En_Password.ButtonCustom2.Visible = False
        txt_En_Password.ButtonCustom.Visible = True

        txt_En_Confirm_Password.ButtonCustom2.Visible = False
        txt_En_Confirm_Password.ButtonCustom.Visible = True



    End Sub

    Private Sub txt_En_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_En_Password.TextChanged

    End Sub

    Private Sub txt_En_Password_ButtonCustom2Click(sender As Object, e As EventArgs) Handles txt_En_Password.ButtonCustom2Click
        txt_En_Password.ButtonCustom2.Visible = False
        txt_En_Password.ButtonCustom.Visible = True

        txt_En_Password.UseSystemPasswordChar = True
    End Sub

    Private Sub txt_En_Password_ButtonCustomClick(sender As Object, e As EventArgs) Handles txt_En_Password.ButtonCustomClick
        txt_En_Password.ButtonCustom.Visible = False
        txt_En_Password.ButtonCustom2.Visible = True

        txt_En_Password.UseSystemPasswordChar = False
    End Sub

    Private Sub txt_En_Confirm_Password_ButtonCustom2Click(sender As Object, e As EventArgs) Handles txt_En_Confirm_Password.ButtonCustom2Click
        txt_En_Confirm_Password.ButtonCustom2.Visible = False
        txt_En_Confirm_Password.ButtonCustom.Visible = True

        txt_En_Confirm_Password.UseSystemPasswordChar = True
    End Sub

    Private Sub txt_En_Confirm_Password_ButtonCustomClick(sender As Object, e As EventArgs) Handles txt_En_Confirm_Password.ButtonCustomClick
        txt_En_Confirm_Password.ButtonCustom.Visible = False
        txt_En_Confirm_Password.ButtonCustom2.Visible = True

        txt_En_Confirm_Password.UseSystemPasswordChar = False
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        Dim MysqlConn As New MySqlConnection
        Dim cmd As New MySqlCommand
        'Dim drSQL As MySqlDataReader
        Dim da1 As New MySqlDataAdapter
        Dim Sql As String
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        Dim position As String = ""
        Dim succ As String = ""



        If txt_En_Confirm_Password.Text = txt_En_Password.Text And
            (txt_En_Confirm_Password.Text <> "" And txt_En_Password.Text <> "") Then

            If txt_En_Username.Text <> "" And
                txt_En_Last_Name.Text <> "" And
                txt_En_MI.Text <> "" And
                txt_En_First_Name.Text <> "" And
                txt_En_Position.Text <> "" And
                txt_En_Contact_Number.Text <> "" And
                txt_En_Address.Text <> "" Then

                If chk_Employee_Mark.Checked = True Then

                    position = "BILECO " + txt_En_Position.Text

                Else

                    position = txt_En_Position.Text
                End If

                Try

                    MysqlConn.Open()

                    Sql = "INSERT INTO user_accounts (Username, Password, First_Name, Middle_Initial, Last_Name, " _
                        & "Position, Contact_Number, Address) VALUES (" _
                        & "'" & Replace(txt_En_Username.Text, "'", "''") & "'," _
                        & "'" & Replace(txt_En_Password.Text, "'", "''") & "'," _
                        & "'" & Replace(txt_En_First_Name.Text, "'", "''") & "'," _
                        & "'" & Replace(txt_En_MI.Text, "'", "''") & "'," _
                        & "'" & Replace(txt_En_Last_Name.Text, "'", "''") & "'," _
                        & "'" & Replace(position, "'", "''") & "'," _
                        & "'" & Replace(txt_En_Contact_Number.Text, "'", "''") & "'," _
                        & "'" & Replace(txt_En_Address.Text, "'", "''") & "')"

                    cmd.Connection = MysqlConn
                    cmd.CommandText = Sql
                    cmd.ExecuteNonQuery()

                    succ = "Goods"
                Catch ex As Exception

                    succ = "Bads"
                    DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)


                Finally
                    MysqlConn.Close()
                End Try




                If succ = "Goods" Then

                    DevComponents.DotNetBar.MessageBoxEx.Show("User Enrolled.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Me.Close()


                End If


            Else

                DevComponents.DotNetBar.MessageBoxEx.Show("Please fill up all details required.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



            End If




        Else
            If txt_En_Confirm_Password.Text = "" And txt_En_Password.Text = "" Then

                DevComponents.DotNetBar.MessageBoxEx.Show("Password cannot be empty.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            Else
                DevComponents.DotNetBar.MessageBoxEx.Show("Password do not match. Please confirm your password.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


            End If

        End If






    End Sub
End Class