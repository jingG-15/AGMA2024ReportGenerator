Public Class frm_District_Selection



    Private Sub frm_District_Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_Confirm.Enabled = False
        cmb_Districts.Items.Clear()

        For x As Integer = 0 To Loaded_District.Count - 1 Step 1

            cmb_Districts.Items.Add(Loaded_District(x))


        Next

    End Sub

    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click



        Selected_District = cmb_Districts.SelectedItem.ToString

        Me.Close()

    End Sub

    Private Sub cmb_Districts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Districts.SelectedIndexChanged
        If cmb_Districts.SelectedItem.ToString <> "" Then
            btn_Confirm.Enabled = True
        Else
            btn_Confirm.Enabled = False
        End If
    End Sub
End Class