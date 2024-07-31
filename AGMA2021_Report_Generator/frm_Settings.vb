Imports System.Data.SQLite

Public Class frm_Settings



    Private Sub frm_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IpAddressInput1.WatermarkText = Server_IP

        cmb_COM_Ports.Items.Clear()
        ' Get a list of serial port names.
        Dim ports As String() = IO.Ports.SerialPort.GetPortNames()

        ' Show a label with Action information on it
        ' Put each port name Into a comboBox control.
        Dim port As String
        For Each port In ports
            cmb_COM_Ports.Items.Add(port)

        Next port


        cmb_Baudrate.Items.Clear()
        cmb_Baudrate.Items.Add("9600")
        cmb_Baudrate.Items.Add("14400")
        cmb_Baudrate.Items.Add("19200")
        cmb_Baudrate.Items.Add("38400")
        cmb_Baudrate.Items.Add("57600")
        cmb_Baudrate.Items.Add("115200")
        cmb_Baudrate.Items.Add("128000")

        cmb_COM_Ports.WatermarkText = GSM_Port
        cmb_Baudrate.WatermarkText = GSM_Baud
    End Sub

    Private Sub btn_Test_IP_Click(sender As Object, e As EventArgs) Handles btn_Test_IP.Click
        Dim Test_Result As String = frm_Main.Test_Server_IP(IpAddressInput1.Value)
        If Test_Result = "True" Then

            DevComponents.DotNetBar.MessageBoxEx.Show("Server IP Valid. Please save for settings to take effect. ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            DevComponents.DotNetBar.MessageBoxEx.Show(Test_Result, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btn_Save_IP_Click(sender As Object, e As EventArgs) Handles btn_Save_IP.Click
        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        Dim trigger_point As Boolean = False
        sqlite_conn = New SQLiteConnection("Data Source=" & Common_Data_path & "\AGMA2024.db3;Version=3;New=True;")


        If IpAddressInput1.Value <> "" Then
            Server_IP = IpAddressInput1.Value





            Try
                sqlite_conn.Open()
                sqlite_cmd = sqlite_conn.CreateCommand()
                sqlite_cmd.CommandText = "UPDATE Server_Settings SET Server_IP=@New_IP WHERE ID = 1"
                sqlite_cmd.Parameters.AddWithValue("@New_IP", IpAddressInput1.Value)
                sqlite_cmd.ExecuteNonQuery()

                DevComponents.DotNetBar.MessageBoxEx.Show("Settings Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Catch ex As Exception

                DevComponents.DotNetBar.MessageBoxEx.Show("Exception code: L01029C23" + vbNewLine + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Finally
                sqlite_conn.Close()
            End Try


        End If



        If cmb_COM_Ports.SelectedIndex >= 0 Then
            GSM_Port = cmb_COM_Ports.Items(cmb_COM_Ports.SelectedIndex).ToString
            Try

                sqlite_conn.Open()
                sqlite_cmd = sqlite_conn.CreateCommand()

                Try

                    sqlite_cmd.CommandText = "UPDATE GSM_Config SET COM_Port=@New_Com_Port WHERE ID = 1"
                    sqlite_cmd.Parameters.AddWithValue("@New_Com_Port", cmb_COM_Ports.Items(cmb_COM_Ports.SelectedIndex).ToString)
                    sqlite_cmd.ExecuteNonQuery()

                Catch ex As Exception

                    MsgBox("Exception code: L01029C23" + vbNewLine + vbNewLine + ex.Message, MsgBoxStyle.OkOnly, "Error")
                    trigger_point = False
                Finally
                    sqlite_conn.Close()
                    trigger_point = True
                End Try

            Catch ex As Exception

            End Try

        End If

        If cmb_Baudrate.SelectedIndex >= 0 Then
            GSM_Baud = cmb_Baudrate.Items(cmb_Baudrate.SelectedIndex).ToString
            Try


                sqlite_conn.Open()
                sqlite_cmd = sqlite_conn.CreateCommand()

                Try

                    sqlite_cmd.CommandText = "UPDATE GSM_Config SET Baudrate=@New_Baudrate WHERE ID = 1"
                    sqlite_cmd.Parameters.AddWithValue("@New_Baudrate", cmb_Baudrate.Items(cmb_Baudrate.SelectedIndex).ToString)
                    sqlite_cmd.ExecuteNonQuery()

                Catch ex As Exception

                    MsgBox("Exception code: L01029C23" + vbNewLine + vbNewLine + ex.Message, MsgBoxStyle.OkOnly, "Error")
                    trigger_point = False
                Finally
                    sqlite_conn.Close()
                    trigger_point = True
                End Try

            Catch ex As Exception

            End Try



        End If
        If trigger_point = True Then

            frm_Main.Change_SMS_Port_Baud(GSM_Port, GSM_Baud)

        End If
        Me.Close()
    End Sub

    Private Sub btn_Refresh_Ports_Click(sender As Object, e As EventArgs) Handles btn_Refresh_Ports.Click
        cmb_COM_Ports.Items.Clear()
        ' Get a list of serial port names.
        Dim ports As String() = IO.Ports.SerialPort.GetPortNames()

        ' Show a label with Action information on it
        ' Put each port name Into a comboBox control.
        Dim port As String
        For Each port In ports
            cmb_COM_Ports.Items.Add(port)

        Next port
    End Sub
End Class