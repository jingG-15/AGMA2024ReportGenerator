Imports System.ComponentModel
Public Class frm_SMS_Console_View
    Private Sub btn_Start_Send_Click(sender As Object, e As EventArgs) Handles btn_Start_Send.Click
        Start_Send = True
    End Sub

    Private Sub btn_Stop_Send_Click(sender As Object, e As EventArgs) Handles btn_Stop_Send.Click
        Start_Send = False
    End Sub

    Private Sub frm_SMS_Console_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_Main.tmr_Entries_Loader.Enabled = True

        With Rchtxt_Message_Stats
            .BackColorRichTextBox = Color.Black
            .ForeColor = Color.FromArgb(231, 193, 184)
        End With

    End Sub

    Private Sub frm_SMS_Console_View_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frm_Main.tmr_Entries_Loader.Enabled = False
    End Sub

    Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click
        frm_Main.Change_SMS_Port_Baud(GSM_Port, GSM_Baud)
    End Sub
End Class