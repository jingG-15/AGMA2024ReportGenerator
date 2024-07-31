Imports System.Data.SQLite

Module Globals

    Public Common_Data_path As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)



    Public Server_IP As String

    Public Masterlist_Sel_ID As String
    Public Self_Sel_ID As String
    Public User_Reg_Sel_ID As String

    Public Selected_District As String

    Public Loaded_District As New ArrayList()

    Public Update_SMS_Marker As New ArrayList()

    Public Username_For_Password_Change As String

    Public Username_For_Reg_View As String
    Public Usr_report_fullname_dialog As String

    Public User_Curr_Logged As String
    Public User_Curr_Logged_Position As String
    Public User_Curr_Full_Name As String


    Public Reg_Raffle_Validity As Integer

    Public Del_Selected_Reason As String

    Public GSM_Port As String
    Public GSM_Baud As Integer
    Public Init_Done As Boolean = False


    Public Notif_Message As String

    Public Start_Send As Boolean = False


    Public Function Get_Server_IP() As String
        Dim ret_val As String = ""

        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        sqlite_conn = New SQLiteConnection("Data Source=" + Common_Data_path + "\AGMA2024.db3;Version=3;New=True;")
        sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()


        Try
            sqlite_cmd.CommandText = "Select Server_IP From Server_Settings Where ID = 1"
            sqlite_datareader = sqlite_cmd.ExecuteReader()

            While (sqlite_datareader.Read())
                ret_val = sqlite_datareader.GetString(0)
            End While
        Catch ex As Exception
            MsgBox("Exception line: 0xF1038" + vbNewLine + vbNewLine + ex.Message, , "Error")
        Finally
            sqlite_conn.Close()
        End Try






        Return ret_val

    End Function



    Public Function Fetch_GSM_Port() As String
        Dim Return_Val As String = ""

        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        sqlite_conn = New SQLiteConnection("Data Source=" + Common_Data_path + "\AGMA2024.db3;Version=3;New=True;")
        sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()


        Try
            sqlite_cmd.CommandText = "SELECT COM_Port FROM GSM_Config WHERE ID = 1"
            sqlite_datareader = sqlite_cmd.ExecuteReader()

            While (sqlite_datareader.Read())

                Return_Val = sqlite_datareader.GetString(0)

            End While
        Catch ex As Exception
            MsgBox("Exception line: 0xF1038" + vbNewLine + vbNewLine + ex.Message, , "Error")
        Finally
            sqlite_conn.Close()
        End Try


        Return Return_Val
    End Function


    Public Function Fetch_GSM_Baud() As Integer

        Dim Return_Val As Integer = 9800

        Dim sqlite_conn As SQLiteConnection
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        sqlite_conn = New SQLiteConnection("Data Source=" + Common_Data_path + "\AGMA2024.db3;Version=3;New=True;")
        sqlite_conn.Open()
        sqlite_cmd = sqlite_conn.CreateCommand()

        Try
            sqlite_cmd.CommandText = "SELECT Baudrate FROM GSM_Config WHERE ID = 1"
            sqlite_datareader = sqlite_cmd.ExecuteReader()

            While (sqlite_datareader.Read())

                Return_Val = sqlite_datareader.GetValue(0)

            End While
        Catch ex As Exception
            MsgBox("Exception line: 0xF1038" + vbNewLine + vbNewLine + ex.Message, , "Error")
        Finally
            sqlite_conn.Close()
        End Try

        Return Return_Val

    End Function
End Module
