Public Class frm_Delete_Reason
    Private Sub btn_Confirm_Click(sender As Object, e As EventArgs) Handles btn_Confirm.Click

        If chk_inv_ID.Checked = True Or chk_inv_Sign.Checked = True Then
            If chk_inv_ID.Checked = True And chk_inv_Sign.Checked = False Then
                Del_Selected_Reason = "Invalid photo of ID Provided"

            ElseIf chk_inv_Sign.Checked = True And chk_inv_ID.Checked = False Then

                Del_Selected_Reason = "Invalid Signature upon visual verification"

            ElseIf chk_inv_Sign.Checked = True And chk_inv_ID.Checked = True Then

                Del_Selected_Reason = "Invalid Signature upon visual verification and Invalid photo of ID Provided"

            End If

            Me.Close()


        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("Please select a reason of data deletion", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If



    End Sub

    Private Sub frm_Delete_Reason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chk_inv_ID.Checked = False
        chk_inv_Sign.Checked = False

    End Sub
End Class