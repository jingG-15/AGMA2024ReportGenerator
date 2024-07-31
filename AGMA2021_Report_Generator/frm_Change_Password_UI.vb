Imports MySql.Data.MySqlClient

Public Class frm_Change_Password_UI

    Dim showpassword_old As Boolean = True
    Dim showpassword_new As Boolean = True
    Dim showpassword_confirm As Boolean = True

    Dim BW_Check_Credetials_Flag As Boolean = False

    Dim Circ_Forward_Password As Boolean = False

    Dim Update_password_flag As Boolean = False


    Private Sub frm_Change_Password_UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_New_Password.Text = ""
        txt_Old_Password.Text = ""
        txt_Confirm_Password.Text = ""

        circ_password.Visible = False



        If showpassword_old = False Then

            showpassword_old = True

            txt_Old_Password.ButtonCustom.Visible = False
            txt_Old_Password.ButtonCustom2.Visible = True


            txt_Old_Password.UseSystemPasswordChar = False

        Else
            showpassword_old = False

            txt_Old_Password.ButtonCustom2.Visible = False
            txt_Old_Password.ButtonCustom.Visible = True

            txt_Old_Password.UseSystemPasswordChar = True
        End If

        If showpassword_new = False Then

            showpassword_new = True

            txt_New_Password.ButtonCustom.Visible = False
            txt_New_Password.ButtonCustom2.Visible = True


            txt_New_Password.UseSystemPasswordChar = False

        Else
            showpassword_new = False

            txt_New_Password.ButtonCustom2.Visible = False
            txt_New_Password.ButtonCustom.Visible = True

            txt_New_Password.UseSystemPasswordChar = True
        End If


        If showpassword_confirm = False Then

            showpassword_confirm = True

            txt_Confirm_Password.ButtonCustom.Visible = False
            txt_Confirm_Password.ButtonCustom2.Visible = True


            txt_Confirm_Password.UseSystemPasswordChar = False

        Else
            showpassword_confirm = False

            txt_Confirm_Password.ButtonCustom2.Visible = False
            txt_Confirm_Password.ButtonCustom.Visible = True

            txt_Confirm_Password.UseSystemPasswordChar = True
        End If



    End Sub

    Private Sub txt_Old_Password_ButtonCustom2Click(sender As Object, e As EventArgs) Handles txt_Old_Password.ButtonCustom2Click
        showpassword_old = False

        txt_Old_Password.ButtonCustom2.Visible = False
        txt_Old_Password.ButtonCustom.Visible = True

        txt_Old_Password.UseSystemPasswordChar = True
    End Sub

    Private Sub txt_Old_Password_ButtonCustomClick(sender As Object, e As EventArgs) Handles txt_Old_Password.ButtonCustomClick



        showpassword_old = True

        txt_Old_Password.ButtonCustom.Visible = False
        txt_Old_Password.ButtonCustom2.Visible = True


        txt_Old_Password.UseSystemPasswordChar = False





    End Sub

    Private Sub txt_New_Password_ButtonCustom2Click(sender As Object, e As EventArgs) Handles txt_New_Password.ButtonCustom2Click
        showpassword_new = False

        txt_New_Password.ButtonCustom2.Visible = False
        txt_New_Password.ButtonCustom.Visible = True

        txt_New_Password.UseSystemPasswordChar = True
    End Sub

    Private Sub txt_New_Password_ButtonCustomClick(sender As Object, e As EventArgs) Handles txt_New_Password.ButtonCustomClick
        showpassword_new = True

        txt_New_Password.ButtonCustom.Visible = False
        txt_New_Password.ButtonCustom2.Visible = True


        txt_New_Password.UseSystemPasswordChar = False
    End Sub


    Private Sub txt_New_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_New_Password.TextChanged

        txt_New_Password.BackColor = Color.White
    End Sub

    Private Sub txt_Confirm_Password_ButtonCustom2Click(sender As Object, e As EventArgs) Handles txt_Confirm_Password.ButtonCustom2Click
        showpassword_confirm = False

        txt_Confirm_Password.ButtonCustom2.Visible = False
        txt_Confirm_Password.ButtonCustom.Visible = True

        txt_Confirm_Password.UseSystemPasswordChar = True
    End Sub

    Private Sub txt_Confirm_Password_ButtonCustomClick(sender As Object, e As EventArgs) Handles txt_Confirm_Password.ButtonCustomClick
        showpassword_confirm = True

        txt_Confirm_Password.ButtonCustom.Visible = False
        txt_Confirm_Password.ButtonCustom2.Visible = True


        txt_Confirm_Password.UseSystemPasswordChar = False
    End Sub

    Private Sub txt_Confirm_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_Confirm_Password.TextChanged
        txt_Confirm_Password.BackColor = Color.White
    End Sub

    Private Sub btn_Update_Info_Click(sender As Object, e As EventArgs) Handles btn_Update_Info.Click

        If txt_New_Password.Text <> txt_Confirm_Password.Text Then
            DevComponents.DotNetBar.MessageBoxEx.Show("New Password and confirmation do not match.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_Confirm_Password.BackColor = Color.OrangeRed
            txt_New_Password.BackColor = Color.OrangeRed

        Else
            txt_Confirm_Password.BackColor = Color.White
            txt_New_Password.BackColor = Color.White

            If BW_Check_Credetials_Flag = False Then
                BW_Check_Credetials_Flag = True

                txt_Confirm_Password.Enabled = False
                txt_New_Password.Enabled = False
                txt_Old_Password.Enabled = False

                circ_password.Visible = True
                circ_password.Value = 0
                tmr_prog_password_anim.Enabled = True

                BW_Password_Compare.RunWorkerAsync()


            End If


        End If




    End Sub



    Private Sub tmr_prog_password_anim_Tick(sender As Object, e As EventArgs) Handles tmr_prog_password_anim.Tick
        If Circ_Forward_Password = True Then
            If circ_password.Value < 100 Then

                circ_password.Value += 10
            ElseIf circ_password.Value >= 100 Then
                Circ_Forward_Password = False
                circ_password.Value -= 10
            End If
        Else
            If circ_password.Value > 0 Then

                circ_password.Value -= 10
            ElseIf circ_password.Value <= 0 Then
                Circ_Forward_Password = True
                circ_password.Value += 10
            End If
        End If

    End Sub

    Private Sub BW_Password_Compare_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Password_Compare.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"



        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"
            MysqlConn.Open()
            sql = "SELECT Password FROM user_accounts WHERE Username = '" & Username_For_Password_Change & "'"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True

                If txt_Old_Password.Text = drSQL("Password").ToString Then

                    Update_password_flag = True

                Else

                    Update_password_flag = False

                End If

            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Password_Compare_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Password_Compare.ProgressChanged

    End Sub

    Private Sub BW_Password_Compare_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Password_Compare.RunWorkerCompleted



        If Update_password_flag = True Then

            BW_Password_Change.RunWorkerAsync()



        Else
            BW_Check_Credetials_Flag = False

            txt_Confirm_Password.Enabled = True
            txt_New_Password.Enabled = True
            txt_Old_Password.Enabled = True

            circ_password.Visible = False
            circ_password.Value = 0
            tmr_prog_password_anim.Enabled = False

            DevComponents.DotNetBar.MessageBoxEx.Show("Current pasword is incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)


            txt_Old_Password.BackColor = Color.OrangeRed

        End If

    End Sub

    Private Sub txt_Old_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_Old_Password.TextChanged
        txt_Old_Password.BackColor = Color.White

    End Sub

    Private Sub BW_Password_Change_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Password_Change.DoWork

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        'Dim drSQL As New MySqlDataReader


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"



        Try
            MysqlConn.Open()

            sql = "UPDATE user_accounts SET Password = '" & txt_New_Password.Text & "' WHERE Username = '" & Username_For_Password_Change & "'"

            cmd.Connection = MysqlConn
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()


            e.Result = "Update Success!"


        Catch ex As Exception
            
            e.Result = ex.Message.ToString
        Finally
            MysqlConn.Close()
        End Try




    End Sub

    Private Sub BW_Password_Change_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Password_Change.ProgressChanged

    End Sub

    Private Sub BW_Password_Change_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Password_Change.RunWorkerCompleted
        BW_Check_Credetials_Flag = False

        txt_Confirm_Password.Enabled = True
        txt_New_Password.Enabled = True
        txt_Old_Password.Enabled = True

        circ_password.Visible = False
        circ_password.Value = 0
        tmr_prog_password_anim.Enabled = False

        If e.Result.ToString = "Update Success!" Then

            DevComponents.DotNetBar.MessageBoxEx.Show("Update Done!.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("Update failed. Please check error message and restart application." + vbNewLine + vbNewLine + e.Result.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If





        
    End Sub
End Class