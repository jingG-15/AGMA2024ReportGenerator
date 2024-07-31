Imports MySql.Data.MySqlClient

Public Class frm_Profile_Details
    Dim update_info_flag As Boolean = False

    Dim old_info As New ArrayList()

    Dim Circ_Forward_Profile As Boolean = False
    Private Sub btn_Change_Password_Click(sender As Object, e As EventArgs) Handles btn_Change_Password.Click
        Username_For_Password_Change = txt_Assigned_Username.Text
        frm_Change_Password_UI.ShowDialog()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()

    End Sub

    Private Sub btn_Update_Info_Click(sender As Object, e As EventArgs) Handles btn_Update_Info.Click
        If update_info_flag = False Then
            update_info_flag = True
            btn_Update_Info.Text = "Save Updates"
            btn_Exit.Enabled = False
            btn_Change_Password.Enabled = False

            txt_First_Name.ReadOnly = False
            txt_Mid_Ini.ReadOnly = False
            txt_Last_Name.ReadOnly = False
            txt_Designation.ReadOnly = False
            txt_Contact_Number.ReadOnly = False
            txt_Assigned_Username.ReadOnly = True
            txt_Assigned_Username.Enabled = False
            txt_Address.ReadOnly = False

            old_info.Clear()
            old_info.Add(txt_First_Name.Text)
            old_info.Add(txt_Mid_Ini.Text)
            old_info.Add(txt_Last_Name.Text)
            old_info.Add(txt_Designation.Text)
            old_info.Add(txt_Contact_Number.Text)
            old_info.Add(txt_Address.Text)





        Else
            update_info_flag = False
            btn_Update_Info.Text = "Update Information"
            btn_Exit.Enabled = True
            btn_Change_Password.Enabled = True


            If old_info(0).ToString <> txt_First_Name.Text Or old_info(1).ToString <> txt_Mid_Ini.Text Or old_info(2).ToString <> txt_Last_Name.Text _
                    Or old_info(3).ToString <> txt_Designation.Text Or old_info(4).ToString <> txt_Contact_Number.Text _
                    Or old_info(5).ToString <> txt_Address.Text Then

                txt_First_Name.ReadOnly = True
                txt_Mid_Ini.ReadOnly = True
                txt_Last_Name.ReadOnly = True
                txt_Designation.ReadOnly = True
                txt_Contact_Number.ReadOnly = True
                txt_Assigned_Username.ReadOnly = True
                txt_Assigned_Username.Enabled = True
                txt_Address.ReadOnly = True


                btn_Exit.Enabled = False
                btn_Change_Password.Enabled = False
                btn_Update_Info.Enabled = False

                circ_profile_update.Visible = True
                circ_profile_update.Value = 0
                tmr_circ_prof_anim.Enabled = True

                BW_Update_Profile.RunWorkerAsync()




            Else


                DevComponents.DotNetBar.MessageBoxEx.Show("No Changes were made.", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txt_First_Name.ReadOnly = True
                txt_Mid_Ini.ReadOnly = True
                txt_Last_Name.ReadOnly = True
                txt_Designation.ReadOnly = True
                txt_Contact_Number.ReadOnly = True
                txt_Assigned_Username.ReadOnly = True
                txt_Assigned_Username.Enabled = True
                txt_Address.ReadOnly = True





            End If


        End If
    End Sub

    Private Sub frm_Profile_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update_info_flag = False
    End Sub

    Private Sub tmr_circ_prof_anim_Tick(sender As Object, e As EventArgs) Handles tmr_circ_prof_anim.Tick
        If Circ_Forward_Profile = True Then
            If circ_profile_update.Value < 100 Then

                circ_profile_update.Value += 10
            ElseIf circ_profile_update.Value >= 100 Then
                Circ_Forward_Profile = False
                circ_profile_update.Value -= 10
            End If
        Else
            If circ_profile_update.Value > 0 Then

                circ_profile_update.Value -= 10
            ElseIf circ_profile_update.Value <= 0 Then
                Circ_Forward_Profile = True
                circ_profile_update.Value += 10
            End If
        End If
    End Sub

    Private Sub BW_Update_Profile_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Update_Profile.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        'Dim drSQL As New MySqlDataReader


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"



        Try
            MysqlConn.Open()

            sql = "UPDATE user_accounts SET First_Name = '" & txt_First_Name.Text & "', Middle_Initial = '" & txt_Mid_Ini.Text & "', " _
                + "Last_Name = '" & txt_Last_Name.Text & "', Position = '" & txt_Designation.Text & "', Contact_Number = '" & txt_Contact_Number.Text & "', " _
                + "Address = '" & txt_Address.Text & "' WHERE Username = '" & txt_Assigned_Username.Text & "'"

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

    Private Sub BW_Update_Profile_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Update_Profile.ProgressChanged

    End Sub

    Private Sub BW_Update_Profile_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Update_Profile.RunWorkerCompleted
        If e.Result.ToString = "Update Success!" Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Update Done!.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            DevComponents.DotNetBar.MessageBoxEx.Show("Update failed. Please check error message and restart application." + vbNewLine + vbNewLine + e.Result.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        btn_Exit.Enabled = True
        btn_Change_Password.Enabled = True
        btn_Update_Info.Enabled = True

        circ_profile_update.Visible = False
        circ_profile_update.Value = 0
        tmr_circ_prof_anim.Enabled = False

    End Sub


End Class