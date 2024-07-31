Public Class frm_Deleted_Reg_Viewer
    Private Sub frm_Deleted_Reg_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Sign_FullScreen_Click(sender As Object, e As EventArgs) Handles btn_Sign_FullScreen.Click
        frm_Photo_Viewer.pb1.Image = pic_Signature.Image
        frm_Photo_Viewer.ShowDialog()
    End Sub

    Private Sub btn_ID_Fullscreen_Click(sender As Object, e As EventArgs) Handles btn_ID_Fullscreen.Click
        frm_Photo_Viewer.pb1.Image = pic_ID_Snapshot.Image
        frm_Photo_Viewer.ShowDialog()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()

    End Sub
End Class