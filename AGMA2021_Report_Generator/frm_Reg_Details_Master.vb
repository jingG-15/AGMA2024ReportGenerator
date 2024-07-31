Imports MySql.Data.MySqlClient

Public Class frm_Reg_Details_Master


    Dim Circ_Forward_Saver As Boolean = True
    Dim stub_for_update As String
    Dim val_int_update As Integer

    Public raffle_val_changed As Boolean = False

    Private Sub frm_Reg_Details_Master_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If raffle_val_changed = False Then
            e.Cancel = False

        Else


            If DevComponents.DotNetBar.MessageBoxEx.Show("Save changes with this raffle entry?", "Validity changed", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

                CircularProgress1.Value = 0
                CircularProgress1.Visible = True
                tmr_save_anim.Enabled = True

                stub_for_update = txt_Stub_Number.Text

                btn_ID_Fullscreen.Enabled = False
                btn_Sign_FullScreen.Enabled = False
                btn_Exit.Enabled = False


                BW_Update_Marker.RunWorkerAsync()

            Else
                btn_Exit.Text = "Exit"
                e.Cancel = False

            End If

        End If
    End Sub


    Private Sub frm_Reg_Details_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        raffle_val_changed = False


    End Sub

    Private Sub btn_Masterlist_Search_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click

        Me.Close()




    End Sub

    Private Sub btn_Sign_FullScreen_Click(sender As Object, e As EventArgs) Handles btn_Sign_FullScreen.Click
        frm_Photo_Viewer.pb1.Image = pic_Signature.Image
        frm_Photo_Viewer.ShowDialog()
    End Sub

    Private Sub btn_ID_Fullscreen_Click(sender As Object, e As EventArgs) Handles btn_ID_Fullscreen.Click
        frm_Photo_Viewer.pb1.Image = pic_ID_Snapshot.Image
        frm_Photo_Viewer.ShowDialog()
    End Sub



    Private Sub BW_Update_Marker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Update_Marker.DoWork


        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"


        Try

            MysqlConn.Open()


            sql = "UPDATE overall_reg SET Raffle_Valid = @raf_val, Sanitize_Mark = 1, Sanitized_by = @Username_Logged WHERE Stub_Number = @stub"

            With cmd
                .Connection = MysqlConn
                .CommandText = sql
                .Parameters.AddWithValue("@raf_val", val_int_update)
                .Parameters.AddWithValue("@stub", stub_for_update)
                .Parameters.AddWithValue("@Username_Logged", User_Curr_Logged)
            End With
            cmd.ExecuteNonQuery()



        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...




       

    End Sub

    Private Sub BW_Update_Marker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Update_Marker.ProgressChanged

    End Sub

    Private Sub BW_Update_Marker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Update_Marker.RunWorkerCompleted

        CircularProgress1.Value = 0
        CircularProgress1.Visible = False
        tmr_save_anim.Enabled = False

        btn_ID_Fullscreen.Enabled = True
        btn_Sign_FullScreen.Enabled = True
        btn_Exit.Enabled = True

        btn_Exit.Text = "Exit"

    End Sub

    Private Sub tmr_save_anim_Tick(sender As Object, e As EventArgs) Handles tmr_save_anim.Tick
        If Circ_Forward_Saver = True Then
            If CircularProgress1.Value < 100 Then

                CircularProgress1.Value += 10
            ElseIf CircularProgress1.Value >= 100 Then
                Circ_Forward_Saver = False
                CircularProgress1.Value -= 10
            End If
        Else
            If CircularProgress1.Value > 0 Then

                CircularProgress1.Value -= 10
            ElseIf CircularProgress1.Value <= 0 Then
                Circ_Forward_Saver = True
                CircularProgress1.Value += 10
            End If
        End If
    End Sub

    Private Sub rdo_Valid_for_Raffle_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Valid_for_Raffle.CheckedChanged



        If rdo_Valid_for_Raffle.Checked = True And rdo_Not_Valid.Checked = False Then

            If Reg_Raffle_Validity = 0 Then

                btn_Exit.Text = "Save Entry"

            ElseIf Reg_Raffle_Validity = 1 Then

                btn_Exit.Text = "Save Entry"

            ElseIf Reg_Raffle_Validity = 2 Then

                btn_Exit.Text = "Exit"

            End If

            val_int_update = 2


        ElseIf rdo_Valid_for_Raffle.Checked = False And rdo_Not_Valid.Checked = True Then

            If Reg_Raffle_Validity = 0 Then

                btn_Exit.Text = "Save Entry"

            ElseIf Reg_Raffle_Validity = 1 Then

                btn_Exit.Text = "Exit"

            ElseIf Reg_Raffle_Validity = 2 Then

                btn_Exit.Text = "Save Entry"

            End If

            val_int_update = 1

        End If


        raffle_val_changed = True


    End Sub

    Private Sub rdo_Not_Valid_CheckedChanged(sender As Object, e As EventArgs) Handles rdo_Not_Valid.CheckedChanged

        If rdo_Valid_for_Raffle.Checked = True And rdo_Not_Valid.Checked = False Then

            If Reg_Raffle_Validity = 0 Then

                btn_Exit.Text = "Save Entry"

            ElseIf Reg_Raffle_Validity = 1 Then

                btn_Exit.Text = "Save Entry"

            ElseIf Reg_Raffle_Validity = 2 Then

                btn_Exit.Text = "Exit"

            End If

            val_int_update = 2

        ElseIf rdo_Valid_for_Raffle.Checked = False And rdo_Not_Valid.Checked = True Then

            If Reg_Raffle_Validity = 0 Then

                btn_Exit.Text = "Save Entry"

            ElseIf Reg_Raffle_Validity = 1 Then

                btn_Exit.Text = "Exit"

            ElseIf Reg_Raffle_Validity = 2 Then

                btn_Exit.Text = "Save Entry"

            End If

            val_int_update = 1

        End If


        raffle_val_changed = True
    End Sub
End Class