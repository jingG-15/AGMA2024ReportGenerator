Imports MySql.Data.MySqlClient

Public Class frm_Login
    Dim BW_Credentials_Checker_Flag As Boolean = False
    Dim Circ_Forward_Login As Boolean = False

    Private Sub frm_Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If User_Curr_Logged = "" Then
            frm_Main.Close()


        End If
    End Sub
    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BW_Credentials_Checker_Flag = False
        circ_login.Visible = False

        txt_Password.ButtonCustom2.Visible = False
        txt_Password.ButtonCustom.Visible = True

        txt_Password.UseSystemPasswordChar = True
    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        If txt_Username.Text <> "" And txt_Password.Text <> "" Then

            If BW_Credentials_Checker_Flag = False Then

                User_Curr_Logged = ""

                BW_Credentials_Checker_Flag = True

                txt_Password.Enabled = False
                txt_Username.Enabled = False
                btn_Login.Enabled = False
                circ_login.Visible = True

                tmr_circ_login_animator.Enabled = True

                BW_Check_Credentials.RunWorkerAsync()

            End If



        End If
    End Sub

    Private Sub tmr_circ_login_animator_Tick(sender As Object, e As EventArgs) Handles tmr_circ_login_animator.Tick
        If Circ_Forward_Login = True Then

            If circ_login.Value < 100 Then

                circ_login.Value += 10

            ElseIf circ_login.Value >= 100 Then

                Circ_Forward_Login = False
                circ_login.Value -= 10

            End If

        Else
            If circ_login.Value > 0 Then

                circ_login.Value -= 10

            ElseIf circ_login.Value <= 0 Then

                Circ_Forward_Login = True
                circ_login.Value += 10

            End If
        End If
    End Sub

    Private Sub BW_Check_Credentials_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Check_Credentials.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1


        e.Result = "None"

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"

        Try

            
            MysqlConn.Open()
            sql = "SELECT Username, Password, Position, First_Name, Middle_Initial, Last_Name FROM user_accounts " _
                    & "WHERE BINARY Username = '" & txt_Username.Text & "' AND BINARY Password = '" & txt_Password.Text & "'"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True

                User_Curr_Logged = drSQL("Username").ToString
                User_Curr_Full_Name = drSQL("First_Name").ToString & " " & drSQL("Middle_Initial").ToString & ". " & drSQL("Last_Name").ToString
                User_Curr_Logged_Position = drSQL("Position").ToString

                If drSQL("Position").ToString.Contains("BILECO") = True Then
                    e.Result = "Goods"

                Else
                    e.Result = "Bads"

                End If





            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            e.Result = ex.Message.ToString





        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Check_Credentials_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Check_Credentials.ProgressChanged

    End Sub

    Private Sub BW_Check_Credentials_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Check_Credentials.RunWorkerCompleted

        BW_Credentials_Checker_Flag = False

        txt_Password.Enabled = True
        txt_Username.Enabled = True
        btn_Login.Enabled = True
        circ_login.Visible = False

        tmr_circ_login_animator.Enabled = False

        If e.Result = "None" Then

            DevComponents.DotNetBar.MessageBoxEx.Show("Wrong Username or Password. Please check", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf e.Result = "Goods" Then

            DevComponents.DotNetBar.MessageBoxEx.Show("Logged in as: " + User_Curr_Logged, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frm_Main.Text = "AGMA 2021 Report Generator | Logged in as: " + User_Curr_Logged
            Me.Close()

        ElseIf e.Result = "Bads" Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Username used is not allowed to use this app. Strictly for BILECO employee only. Thank you for understanding.", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show(e.Result, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub txt_Password_ButtonCustom2Click(sender As Object, e As EventArgs) Handles txt_Password.ButtonCustom2Click


        txt_Password.ButtonCustom2.Visible = False
        txt_Password.ButtonCustom.Visible = True


        txt_Password.UseSystemPasswordChar = True


    End Sub

    Private Sub txt_Password_ButtonCustomClick(sender As Object, e As EventArgs) Handles txt_Password.ButtonCustomClick

        txt_Password.ButtonCustom.Visible = False
        txt_Password.ButtonCustom2.Visible = True

        txt_Password.UseSystemPasswordChar = False
    End Sub

    Private Sub txt_Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Password.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_Username.Text <> "" And txt_Password.Text <> "" Then

                If BW_Credentials_Checker_Flag = False Then

                    User_Curr_Logged = ""

                    BW_Credentials_Checker_Flag = True

                    txt_Password.Enabled = False
                    txt_Username.Enabled = False
                    btn_Login.Enabled = False
                    circ_login.Visible = True

                    tmr_circ_login_animator.Enabled = True

                    BW_Check_Credentials.RunWorkerAsync()

                End If



            End If
        End If
    End Sub

    Private Sub txt_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_Password.TextChanged

    End Sub

    Private Sub txt_Username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Username.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_Username.Text <> "" And txt_Password.Text <> "" Then

                If BW_Credentials_Checker_Flag = False Then

                    User_Curr_Logged = ""

                    BW_Credentials_Checker_Flag = True

                    txt_Password.Enabled = False
                    txt_Username.Enabled = False
                    btn_Login.Enabled = False
                    circ_login.Visible = True

                    tmr_circ_login_animator.Enabled = True

                    BW_Check_Credentials.RunWorkerAsync()

                End If



            End If
        End If
    End Sub

    Private Sub txt_Username_TextChanged(sender As Object, e As EventArgs) Handles txt_Username.TextChanged

    End Sub
End Class