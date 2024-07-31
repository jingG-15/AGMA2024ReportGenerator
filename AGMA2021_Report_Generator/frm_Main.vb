Imports System.Data.SQLite
Imports MySql.Data.MySqlClient

Imports pdf1 = PdfSharp
Imports pdf2 = PdfSharp.Drawing
Imports pdf3 = PdfSharp.Pdf

Imports Excel = Microsoft.Office.Interop.Excel 'Before you add this reference to your project,
' you need to install Microsoft Office and find last version of this file.
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.ComponentModel
Imports System.IO.Ports
Imports System.Threading

Public Class frm_Main
    Dim Init_flag As Boolean = False
    Dim Circ_Forward_Overall As Boolean = True
    Dim Circ_Forward_Masterlist As Boolean = True
    Dim Circ_Forward_Self As Boolean = True
    Dim Circ_Forward_Usr As Boolean = True
    Dim Circ_Forward_Del_Logs As Boolean = True

    Dim BW_Masterlist_Loader As Boolean = False
    Dim BW_Masterlist_Search_Loader As Boolean = False
    Dim BW_Del_Logs_Loader As Boolean = False
    Dim BW_Self_Reg_Loader As Boolean = False



    Delegate Sub SetListItem(ByVal lstItem As ListViewItem)
    Delegate Sub SetListItem_Self(ByVal lstItem As ListViewItem)
    Delegate Sub SetListItem_QR(ByVal lstItem As ListViewItem)
    Delegate Sub SetListItem_del_logs(ByVal lstItem As ListViewItem)

    Private m_SortingColumn As ColumnHeader

    Dim DotBool As Boolean = False

    Dim BW_Get_Total_Reg_Flag As Boolean = False

    Dim Mstr_Column_Name_Search As String

    Dim BW_Mstr_Load_Reg_Flag As Boolean = False
    Dim Mstr_Reg_View_Det_Data As New ArrayList()
    Dim image_loaded_checker As Boolean = False

    Dim BW_Del_Load_Reg_Flag As Boolean = False
    Dim Del_Logs_View_Det_Data As New ArrayList()
    Dim del_image_loaded_checker As Boolean = False

    Dim Del_Logs_Det_Signature As Bitmap
    Dim Del_Logs_Det_Photo_ID As Bitmap

    Dim Mstr_Reg_Det_Signature As Bitmap
    Dim Mstr_Reg_Det_Photo_ID As Bitmap

    Dim Self_Reg_Det_Signature As Bitmap
    Dim Self_Reg_Det_Photo_ID As Bitmap

    Dim finalPath_Mstr_PDF As String
    Dim fileName_Mstr_PDF As String
    Dim filepath_Mstr_PDF As String
    Dim ItemNumber_Mstr_PDF As Integer = 1

    Dim Logo_PNG As Image = Image.FromFile(My.Application.Info.DirectoryPath + "\Logo.png")

    Dim fileName_Excel_Mstr As String
    Dim finalPath_Excel_Mstr As String

    Dim finalPath_Mstr_Dist_PDF As String
    Dim fileName_Mstr_Dist_PDF As String
    Dim filepath_Mstr_Dist_PDF As String
    Dim ItemNumber_Mstr_Dist_PDF As Integer = 1

    Dim finalPath_Audit_Dist_PDF As String
    Dim fileName_Audit_Dist_PDF As String
    Dim filepath_Audit_Dist_PDF As String
    Dim ItemNumber_Audit_Dist_PDF As Integer = 1


    Dim finalPath_Onsite_Dist_PDF As String
    Dim fileName_Onsite_Dist_PDF As String
    Dim filepath_Onsite_Dist_PDF As String
    Dim ItemNumber_Onsite_Dist_PDF As Integer = 1




    Dim fileName_Excel_Mstr_Dist As String
    Dim finalPath_Excel_Mstr_Dist As String

    Dim fileName_Excel_Del As String
    Dim finalPath_Excel_Del As String

    Dim BW_Self_Load_Reg_Flag As Boolean = False
    Dim Self_Reg_View_Det_Data As New ArrayList()
    Dim image_loaded_checker_self As Boolean = False

    Dim BW_Self_Search_Loader As Boolean = False
    Dim Self_Column_Name_Search As String

    Dim BW_Users_Loader As Boolean = False

    Dim BW_Prof_View_Loader As Boolean = False
    Dim Prof_Sel_Username As String
    Dim Users_Prof_View_Data As New ArrayList()


    Dim BW_User_Search_Loader As Boolean = False
    Dim User_Column_Name_Search As String


    Dim finalPath_Usr_PDF As String
    Dim fileName_Usr_PDF As String
    Dim filepath_Usr_PDF As String
    Dim ItemNumber_Usr_PDF As Integer = 1

    Dim Username_Sel_For_Export_PDF As String
    Dim Usr_report_fullname As String

    Dim fileName_Excel_Usr As String
    Dim finalPath_Excel_Usr As String

    Dim Username_Sel_For_Export_Excel As String

    Dim Selected_Stub_For_Del As String
    Dim BW_Mstr_Delete_Flag As Boolean = False
    Dim Selected_Stub_Registrant_Delete As String
    Dim Del_Record_Account_Number As String
    Dim Del_Record_Account_Name As String
    Dim Del_Record_Address As String
    Dim Del_Record_Class As String
    Dim Del_Record_Contact_Number As String
    Dim Del_Record_Stub_Number As String
    Dim Del_Record_Registrant As String

    Dim BW_Self_Delete_Flag As Boolean = False

    Dim BW_QR_Loader As Boolean = False
    Dim Circ_Forward_QR As Boolean = False

    Dim BW_QR_Loader_Search As Boolean = False
    Dim QR_Column_Name_Search As String

    Dim fileName_Excel_QR As String
    Dim finalPath_Excel_QR As String

    Dim BW_QR_Load_Reg_Flag As Boolean = False
    Dim QR_Sel_ID As String
    Dim QR_Reg_View_Det_Data As New ArrayList()
    Dim image_loaded_checker_QR As Boolean = False

    Dim QR_Reg_Det_Photo_ID As Bitmap
    Dim QR_Reg_Det_Signature As Bitmap

    Dim BW_Get_Area_Reg_Flag As Boolean = False
    Dim Area_Totals As New ArrayList()

    Dim BW_Get_Onsite_Reg_Flag As Boolean = False

    Dim finalPath_Self_PDF As String
    Dim fileName_Self_PDF As String
    Dim filepath_Self_PDF As String
    Dim ItemNumber_Self_PDF As Integer = 1

    Dim fileName_Excel_Self As String
    Dim finalPath_Excel_Self As String

    Dim Del_Sel_ID As String

    Dim BW_Del_Search_Loader As Boolean
    Dim Del_Column_Name_Search As String



    Dim SMSEngine As New SMSCOMMS

    'Dim BW_Del_Logs_SMS_Loader As Boolean = False





    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Run_DB_Setup As Boolean = False



        If System.IO.File.Exists(Common_Data_path & "\AGMA2024.db3") Then
            Run_DB_Setup = False
        Else
            Run_DB_Setup = True
        End If



        If Run_DB_Setup = True Then


            circ_prog_overall.Value = 0
            circ_prog_overall.Visible = True
            tmr_Circ_overall_anim.Enabled = True


            BW_Config_Local_Settings.RunWorkerAsync()


        Else



            Init_App()


        End If




    End Sub

    Sub Init_App()


        Server_IP = Get_Server_IP()
        GSM_Port = Fetch_GSM_Port()
        GSM_Baud = Fetch_GSM_Baud()

        'IP_Input.WatermarkText = Server_IP

        Dim Test_Result As String = Test_Server_IP(Server_IP)


        If Test_Result = "True" Then


            frm_Login.ShowDialog()

            lst_Masterlist.Columns.Clear()

            lst_Masterlist.Columns.Add("Account Number", 150)
            lst_Masterlist.Columns.Add("Account Name", 200)
            lst_Masterlist.Columns.Add("Stub Number", 100)
            lst_Masterlist.Columns.Add("Address", 200)
            lst_Masterlist.Columns.Add("Date Registered", 200)
            lst_Masterlist.Columns.Add("Class", 100)
            lst_Masterlist.Columns.Add("Contact Number", 150)
            lst_Masterlist.Columns.Add("Registrant", 200)
            lst_Masterlist.Columns.Add("Sanitized", 200)
            lst_Masterlist.Columns.Add("Sanitized by", 200)

            lst_Masterlist.Items.Clear()




            lst_Self_Reg.Columns.Clear()
            lst_Self_Reg.Columns.Add("Account Number", 150)
            lst_Self_Reg.Columns.Add("Account Name", 200)
            lst_Self_Reg.Columns.Add("Stub Number", 100)
            lst_Self_Reg.Columns.Add("Address", 200)
            lst_Self_Reg.Columns.Add("Date Registered", 200)
            lst_Self_Reg.Columns.Add("Class", 100)
            lst_Self_Reg.Columns.Add("Contact Number", 150)
            lst_Self_Reg.Items.Clear()




            lst_users.Columns.Clear()
            lst_users.Columns.Add("Full Name", 200)
            lst_users.Columns.Add("Designation", 200)
            lst_users.Columns.Add("Contact #", 150)
            lst_users.Columns.Add("Address", 200)
            lst_users.Columns.Add("Assigned Username", 200)
            lst_users.Columns.Add("Modification Date", 200)
            lst_users.Items.Clear()


            lst_QR_Attendees.Columns.Clear()
            lst_QR_Attendees.Columns.Add("Stub Number", 200)
            lst_QR_Attendees.Columns.Add("Account Number", 200)
            lst_QR_Attendees.Columns.Add("Account Name", 150)
            lst_QR_Attendees.Columns.Add("Date and Time of Record", 200)
            lst_QR_Attendees.Columns.Add("User Logged", 200)
            lst_QR_Attendees.Columns.Add("Account Address", 200)
            lst_QR_Attendees.Columns.Add("Account Class", 200)
            lst_users.Items.Clear()



            lst_del_logs.Clear()
            lst_del_logs.Columns.Add("Item #", 70)
            lst_del_logs.Columns.Add("Stub Number", 70)
            lst_del_logs.Columns.Add("Account Number", 100)
            lst_del_logs.Columns.Add("Account Name", 250)
            lst_del_logs.Columns.Add("Billing Address", 250)
            lst_del_logs.Columns.Add("Contact Number", 100)
            lst_del_logs.Columns.Add("Account Class", 50)
            lst_del_logs.Columns.Add("Deleter Username", 150)
            lst_del_logs.Columns.Add("Registrant Username", 150)
            lst_del_logs.Columns.Add("Date and Time Deleted", 200)
            lst_del_logs.Columns.Add("Purpose of Delete", 500)
            lst_del_logs.Items.Clear()


            lst_del_logs.Visible = False
            pan_del_logs_control.Enabled = False
            circ_del_prog.Value = 0
            circ_del_prog.Visible = True
            tmr_Circ_del_anim.Enabled = True

            Refresh_Del_Logs()


            lst_Masterlist.Visible = False
            pan_masterlist_controls.Enabled = False
            circ_prog_masterlist.Value = 0
            circ_prog_masterlist.Visible = True
            tmr_Circ_masterlist_anim.Enabled = True

            Refresh_Masterlist()


            lst_Self_Reg.Visible = False
            pan_self_controls.Enabled = False
            circ_self_reg.Value = 0
            circ_self_reg.Visible = True
            tmr_Circ_self_anim.Enabled = True

            Refresh_Self_Regs()


            lst_users.Visible = False
            pan_users_control.Enabled = False
            circ_users_prog.Value = 0
            circ_users_prog.Visible = True
            tmr_Circ_user_anim.Enabled = True

            Refresh_Users()


            lst_QR_Attendees.Visible = False
            pan_QR_control.Enabled = False
            circ_prog_QR.Value = 0
            circ_prog_QR.Visible = True
            tmr_Circ_QR_anim.Enabled = True

            Refresh_QR_Attendees()



            lbl_Time_Hour.BackColor = Color.Transparent
            lbl_Time_Hour.ForeColor = Color.DarkSlateGray

            lbl_Time_Colon.BackColor = Color.Transparent
            lbl_Time_Colon.ForeColor = Color.DarkSlateGray

            lbl_Time_Minute.BackColor = Color.Transparent
            lbl_Time_Minute.ForeColor = Color.DarkSlateGray

            lbl_Time_AMPM.BackColor = Color.Transparent
            lbl_Time_AMPM.ForeColor = Color.DarkSlateGray

            lbl_Time_Label.BackColor = Color.Transparent
            lbl_Time_Label.ForeColor = Color.DarkSlateGray

            lbl_Total_Regs.BackColor = Color.Transparent
            lbl_Total_Regs.ForeColor = Color.FromArgb(192, 64, 0)

            lbl_Total_reg_Label.BackColor = Color.Transparent
            lbl_Total_reg_Label.ForeColor = Color.DarkSlateGray

            tmr_Total_Reg_Updater.Enabled = True


            lbl_Time_Hour_Area.BackColor = Color.Transparent
            lbl_Time_Hour_Area.ForeColor = Color.DarkSlateGray

            lbl_Time_Colon_Area.BackColor = Color.Transparent
            lbl_Time_Colon_Area.ForeColor = Color.DarkSlateGray

            lbl_Time_Minute_Area.BackColor = Color.Transparent
            lbl_Time_Minute_Area.ForeColor = Color.DarkSlateGray

            lbl_Time_AMPM_Area.BackColor = Color.Transparent
            lbl_Time_AMPM_Area.ForeColor = Color.DarkSlateGray

            lbl_Time_Label_Area.BackColor = Color.Transparent
            lbl_Time_Label_Area.ForeColor = Color.DarkSlateGray

            lbl_Total_Regs_Area.BackColor = Color.Transparent
            lbl_Total_Regs_Area.ForeColor = Color.FromArgb(192, 64, 0)


            tmr_Totals_Updater_Area.Enabled = True

            lbl_Time_Hour_Onsite.BackColor = Color.Transparent
            lbl_Time_Hour_Onsite.ForeColor = Color.DarkSlateGray

            lbl_Time_Colon_Onsite.BackColor = Color.Transparent
            lbl_Time_Colon_Onsite.ForeColor = Color.DarkSlateGray

            lbl_Time_Minute_Onsite.BackColor = Color.Transparent
            lbl_Time_Minute_Onsite.ForeColor = Color.DarkSlateGray

            lbl_Time_AMPM_Onsite.BackColor = Color.Transparent
            lbl_Time_AMPM_Onsite.ForeColor = Color.DarkSlateGray

            lbl_Time_Label_Onsite.BackColor = Color.Transparent
            lbl_Time_Label_Onsite.ForeColor = Color.DarkSlateGray

            lbl_Total_Regs_Onsite.BackColor = Color.Transparent
            lbl_Total_Regs_Onsite.ForeColor = Color.FromArgb(192, 64, 0)

            tmr_Totals_Updater_Onsite.Enabled = True




        Else

            DevComponents.DotNetBar.MessageBoxEx.Show("Server IP not reachable. Please check your settings and network connection. " + vbNewLine + vbNewLine + Test_Result, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Init_Done = True

        SMSEngine.Re_Init()
        SMSEngine.Open()

    End Sub

    Private Sub BW_Config_Local_Settings_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Config_Local_Settings.DoWork

        Dim ret_val As Boolean = False
        Dim db_path As String = Common_Data_path & "\AGMA2024.db3"

        Try
            SQLiteConnection.CreateFile(Common_Data_path & "\AGMA2024.db3")



            'Set_Rich_Text(">Configuration file created successfully." + vbNewLine)


            Dim create_table As String = String.Empty


            create_table &= "CREATE TABLE IF NOT EXISTS `Server_Settings` ("
            create_table &= "`ID`	INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,"
            create_table &= "`Server_IP`	TEXT);"

            Try
                Using sqlite_conn As New SQLiteConnection("Data Source=" & Common_Data_path & "\AGMA2024.db3;Version=3;New=True;")
                    sqlite_conn.Open()
                    Using cmd As New SQLiteCommand(create_table, sqlite_conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using


            Catch ex As Exception

                ret_val = True
                DevComponents.DotNetBar.MessageBoxEx.Show(">Table 1 failed. Please check error message and restart application." + vbNewLine + vbNewLine + ex.Message.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


            create_table = String.Empty


            create_table &= "CREATE TABLE IF NOT EXISTS `GSM_Config` ("
            create_table &= "`ID`	INTEGER,"
            create_table &= "`COM_Port`	TEXT,"
            create_table &= "`Baudrate`	TEXT);"

            Try
                Using sqlite_conn As New SQLiteConnection("Data Source=" & Common_Data_path & "\AGMA2024.db3;Version=3;New=True;")
                    sqlite_conn.Open()
                    Using cmd As New SQLiteCommand(create_table, sqlite_conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using


            Catch ex As Exception

                ret_val = True
                DevComponents.DotNetBar.MessageBoxEx.Show(">Table 1 failed. Please check error message and restart application." + vbNewLine + vbNewLine + ex.Message.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try







            '_______________________________  Initial Insertion of value to local DB ______________________________




            Try
                Using sqlite_conn As New SQLiteConnection("Data Source=" & Common_Data_path & "\AGMA2024.db3;Version=3;New=True;")
                    Dim SQL_Command As String = String.Empty
                    sqlite_conn.Open()
                    Dim transaction As SQLiteTransaction = sqlite_conn.BeginTransaction()
                    Using transaction
                        Using cmd As New SQLiteCommand(sqlite_conn)
                            cmd.Transaction = transaction
                            SQL_Command &= "INSERT INTO `Server_Settings` VALUES (1,'10.0.1.240');"
                            cmd.CommandText = SQL_Command
                            cmd.ExecuteNonQuery()


                        End Using
                        transaction.Commit()
                    End Using
                End Using

            Catch ex As Exception

                ret_val = True
                DevComponents.DotNetBar.MessageBoxEx.Show(">Insertion 1 failed. Please check error message and restart application." + vbNewLine + vbNewLine + ex.Message.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try




            Try
                Using sqlite_conn As New SQLiteConnection("Data Source=" & Common_Data_path & "\AGMA2024.db3;Version=3;New=True;")
                    Dim SQL_Command As String = String.Empty
                    sqlite_conn.Open()
                    Dim transaction As SQLiteTransaction = sqlite_conn.BeginTransaction()
                    Using transaction
                        Using cmd As New SQLiteCommand(sqlite_conn)
                            cmd.Transaction = transaction
                            SQL_Command &= "INSERT INTO `GSM_Config` VALUES (1,'COM0','9600');"
                            cmd.CommandText = SQL_Command
                            cmd.ExecuteNonQuery()


                        End Using
                        transaction.Commit()
                    End Using
                End Using

            Catch ex As Exception

                ret_val = True
                DevComponents.DotNetBar.MessageBoxEx.Show(">Insertion 1 failed. Please check error message and restart application." + vbNewLine + vbNewLine + ex.Message.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



        Catch ex As Exception



        End Try






        Init_flag = ret_val
    End Sub

    Private Sub BW_Config_Local_Settings_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Config_Local_Settings.ProgressChanged

    End Sub

    Private Sub BW_Config_Local_Settings_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Config_Local_Settings.RunWorkerCompleted
        circ_prog_overall.Value = 0
        circ_prog_overall.Visible = False
        tmr_Circ_overall_anim.Enabled = False

        If Init_flag = False Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Initial configuration complete!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Init_App()


        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("Configuration failed. Try restarting the application and run as administrator.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)




        End If
    End Sub

    Private Sub frm_Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        circ_prog_overall.Location = New Point((Me.Width / 2) - (circ_prog_overall.Width / 2), (Me.Height / 2) - (circ_prog_overall.Height / 2))
        circ_prog_masterlist.Location = New Point((sidenavpan_masterlist.Width / 2) - (circ_prog_masterlist.Width / 2), (sidenavpan_masterlist.Height / 2) - (circ_prog_masterlist.Height / 2))

        circ_self_reg.Location = New Point((sidenavpan_masterlist.Width / 2) - (circ_prog_masterlist.Width / 2), (sidenavpan_masterlist.Height / 2) - (circ_prog_masterlist.Height / 2))

        circ_users_prog.Location = New Point((sidenavpan_Officer_List.Width / 2) - (circ_users_prog.Width / 2), (sidenavpan_Officer_List.Height / 2) - (circ_users_prog.Height / 2))

        circ_prog_QR.Location = New Point((sidenavpan_QR_Attendance.Width / 2) - (circ_prog_QR.Width / 2), (sidenavpan_QR_Attendance.Height / 2) - (circ_prog_QR.Height / 2))


        lbl_Total_Regs.Size = New Size(sidenavpan_LiveTotalReg.Width, sidenavpan_LiveTotalReg.Height / 2)
        lbl_Total_Regs.Location = New Point(0, (sidenavpan_LiveTotalReg.Height / 2) - (lbl_Total_Regs.Height / 2))

        lbl_Total_reg_Label.Size = New Size(sidenavpan_LiveTotalReg.Width, lbl_Total_reg_Label.Height)
        lbl_Total_reg_Label.Location = New Point(0, lbl_Total_Regs.Location.Y + lbl_Total_Regs.Height + 5)

        lbl_Total_Regs_Area.Size = New Size(sidenavpan_livetotals_per_district.Width, sidenavpan_livetotals_per_district.Height - lbl_Time_Label_Area.Height - 10)
        lbl_Total_Regs_Area.Location = New Point(0, lbl_Time_Label_Area.Location.Y + lbl_Time_Label_Area.Height + 10)

        lbl_Total_Regs_Onsite.Size = New Size(sidenavpan_livetotals_onsite.Width, sidenavpan_livetotals_onsite.Height - lbl_Time_Label_Onsite.Height - 10)
        lbl_Total_Regs_Onsite.Location = New Point(0, lbl_Time_Label_Onsite.Location.Y + lbl_Time_Label_Onsite.Height + 10)

    End Sub

    Private Sub tmr_Circ_overall_anim_Tick(sender As Object, e As EventArgs) Handles tmr_Circ_overall_anim.Tick
        If Circ_Forward_Overall = True Then
            If circ_prog_overall.Value < 100 Then

                circ_prog_overall.Value += 10
            ElseIf circ_prog_overall.Value >= 100 Then
                Circ_Forward_Overall = False
                circ_prog_overall.Value -= 10
            End If
        Else
            If circ_prog_overall.Value > 0 Then

                circ_prog_overall.Value -= 10
            ElseIf circ_prog_overall.Value <= 0 Then
                Circ_Forward_Overall = True
                circ_prog_overall.Value += 10
            End If
        End If
    End Sub

    Private Sub tmr_Circ_masterlist_anim_Tick(sender As Object, e As EventArgs) Handles tmr_Circ_masterlist_anim.Tick

        If Circ_Forward_Masterlist = True Then
            If circ_prog_masterlist.Value < 100 Then

                circ_prog_masterlist.Value += 10
            ElseIf circ_prog_masterlist.Value >= 100 Then
                Circ_Forward_Masterlist = False
                circ_prog_masterlist.Value -= 10
            End If
        Else
            If circ_prog_masterlist.Value > 0 Then

                circ_prog_masterlist.Value -= 10
            ElseIf circ_prog_masterlist.Value <= 0 Then
                Circ_Forward_Masterlist = True
                circ_prog_masterlist.Value += 10
            End If
        End If

    End Sub


    Public Function Test_Server_IP(ByVal IP_test As String) As String
        Dim ret_val As String = "False"
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim ItemNumber As Integer = 1
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + IP_test + "; userid=jingG_15;password=haPPymeals;database=agma_2024"
        Try
            MysqlConn.Open()

            ret_val = "True"
        Catch ex As Exception
            'MysqlConn.Close()

            ret_val = ex.Message.ToString
        Finally
            MysqlConn.Close()

        End Try
        Return ret_val
    End Function


    Sub Refresh_Del_Logs()

        If BW_Del_Logs_Loader = False Then
            BW_Del_Logs_Loader = True

            BW_Load_Del_Logs.RunWorkerAsync()
        End If

    End Sub

    Sub Refresh_Masterlist()
        If BW_Masterlist_Loader = False Then
            BW_Masterlist_Loader = True

            BW_Load_Masterlist.RunWorkerAsync()
        End If


    End Sub

    Sub Refresh_Self_Regs()
        If BW_Self_Reg_Loader = False Then
            BW_Self_Reg_Loader = True

            BW_Load_Self_Reg.RunWorkerAsync()
        End If

    End Sub

    Sub Refresh_Users()
        If BW_Users_Loader = False Then
            BW_Users_Loader = True

            BW_Load_Users.RunWorkerAsync()
        End If
    End Sub

    Sub Refresh_QR_Attendees()
        If BW_QR_Loader = False Then
            BW_QR_Loader = True

            BW_Fill_QR_Attendance.RunWorkerAsync()
        End If


    End Sub


    Private Sub AddListItem(ByVal lstItem As ListViewItem)

        If Me.lst_Masterlist.InvokeRequired Then 'Invoke if required...
            Dim d As New SetListItem(AddressOf AddListItem) 'Your delegate...
            Me.lst_Masterlist.Invoke(d, New Object() {lstItem})
        Else 'Otherwise, no invoke required...
            Me.lst_Masterlist.Items.Add(lstItem)
        End If
    End Sub


    Private Sub BW_Load_Masterlist_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Load_Masterlist.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()

            If chk_Mark_Sanitation_Only.Checked = True Then
                sql = "SELECT COUNT(ID) AS rollcount FROM overall_reg WHERE Sanitize_Mark = 0"

            Else
                sql = "SELECT COUNT(ID) AS rollcount FROM overall_reg"

            End If



            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()

            If chk_Mark_Sanitation_Only.Checked = True Then
                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " _
                        & "Contact_Number, Username_Reg, Sanitize_Mark, Sanitized_by FROM overall_reg WHERE Sanitize_Mark = 0 ORDER BY Bil_Account_Name ASC"

            Else

                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " _
                        & "Contact_Number, Username_Reg, Sanitize_Mark, Sanitized_by FROM overall_reg ORDER BY Bil_Account_Name ASC"

            End If
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Load_Masterlist.CancellationPending) Then

                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Bil_Account_Number").ToString
                    newitem.SubItems.Add(drSQL("Bil_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Stub_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Address").ToString)
                    newitem.SubItems.Add(drSQL("Date_Registered").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Class").ToString)
                    newitem.SubItems.Add(drSQL("Contact_Number").ToString)
                    newitem.SubItems.Add(drSQL("Username_Reg").ToString)

                    If drSQL("Sanitize_Mark").ToString = "1" Then
                        newitem.SubItems.Add("Yes")

                    Else
                        newitem.SubItems.Add("No")

                    End If


                    newitem.SubItems.Add(drSQL("Sanitized_by").ToString)

                    AddListItem(newitem)
                    BW_Load_Masterlist.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Load_Masterlist.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Load_Masterlist_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Load_Masterlist.ProgressChanged
        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Load_Masterlist_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Load_Masterlist.RunWorkerCompleted


        BW_Masterlist_Loader = False

        lst_Masterlist.Visible = True
        pan_masterlist_controls.Enabled = True
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = False
        tmr_Circ_masterlist_anim.Enabled = False



    End Sub


    Private Sub btn_Refresh_Masterlist_Click(sender As Object, e As EventArgs) Handles btn_Refresh_Masterlist.Click
        lst_Masterlist.Items.Clear()

        lst_Masterlist.Visible = False
        pan_masterlist_controls.Enabled = False
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = True
        tmr_Circ_masterlist_anim.Enabled = True
        Refresh_Masterlist()
    End Sub

    Private Sub lst_Masterlist_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lst_Masterlist.ColumnClick
        Dim new_sorting_column As ColumnHeader = lst_Masterlist.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("▲ ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text =
                m_SortingColumn.Text.Substring(2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "▲ " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "▼ " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        lst_Masterlist.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        ' Sort.
        lst_Masterlist.Sort()
    End Sub


    Private Sub tmr_Time_Updater_Tick(sender As Object, e As EventArgs) Handles tmr_Time_Updater.Tick


        If DotBool = False Then
            lbl_Time_Colon.Text = ":"
            lbl_Time_Colon_Area.Text = ":"
            lbl_Time_Colon_Onsite.Text = ":"
            'lbl_Announ_Label.Text = "Advisory /" + vbNewLine + "Announcement"
            DotBool = True
        ElseIf DotBool = True Then
            lbl_Time_Colon.Text = " "
            lbl_Time_Colon_Area.Text = " "
            lbl_Time_Colon_Onsite.Text = " "
            'lbl_Announ_Label.Text = ""
            DotBool = False
        End If

        lbl_Time_Hour.Text = Format(Now, "hh")
        lbl_Time_Minute.Text = Format(Now, "mm")
        lbl_Time_AMPM.Text = Format(Now, "tt")

        lbl_Time_Hour_Area.Text = Format(Now, "hh")
        lbl_Time_Minute_Area.Text = Format(Now, "mm")
        lbl_Time_AMPM_Area.Text = Format(Now, "tt")


        lbl_Time_Hour_Onsite.Text = Format(Now, "hh")
        lbl_Time_Minute_Onsite.Text = Format(Now, "mm")
        lbl_Time_AMPM_Onsite.Text = Format(Now, "tt")


    End Sub

    Private Sub tmr_Total_Reg_Updater_Tick(sender As Object, e As EventArgs) Handles tmr_Total_Reg_Updater.Tick
        If BW_Get_Total_Reg_Flag = False Then
            BW_Get_Total_Reg_Flag = True

            BW_Get_Total_Reg.RunWorkerAsync()


        End If
    End Sub

    Private Sub BW_Get_Total_Reg_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Get_Total_Reg.DoWork

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        Dim Age As Integer = 0
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"
        Try
            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM overall_reg"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count
            e.Result = max.ToString
        Catch ex As Exception
            e.Result = "- - - -"
            'MysqlConn.Close()

        Finally
            MysqlConn.Close()

        End Try




    End Sub

    Private Sub BW_Get_Total_Reg_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Get_Total_Reg.ProgressChanged

    End Sub

    Private Sub BW_Get_Total_Reg_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Get_Total_Reg.RunWorkerCompleted

        lbl_Total_Regs.Text = e.Result.ToString
        BW_Get_Total_Reg_Flag = False
    End Sub


    Private Sub btn_Settings_Click(sender As Object, e As EventArgs) Handles SideNavItem3.Click
        frm_Settings.ShowDialog()

    End Sub

    Private Sub BW_Mstr_Search_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Mstr_Search.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"
        Try
            MysqlConn.Open()

            If chk_Mark_Sanitation_Only.Checked = True Then
                sql = "SELECT COUNT(ID) AS rollcount FROM overall_reg WHERE " & Mstr_Column_Name_Search & " Like '%" & txt_Mstr_Search_Term.Text & "%' " _
                    & "AND Sanitize_Mark = 0"
            Else
                sql = "SELECT COUNT(ID) AS rollcount FROM overall_reg WHERE " & Mstr_Column_Name_Search & " Like '%" & txt_Mstr_Search_Term.Text & "%'"

            End If

            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()

            If chk_Mark_Sanitation_Only.Checked = True Then


                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " +
                "Contact_Number, Username_Reg, Sanitize_Mark, Sanitized_by FROM overall_reg WHERE " & Mstr_Column_Name_Search & " LIKE '%" _
                & txt_Mstr_Search_Term.Text & "%' AND Sanitize_Mark = 0 ORDER BY Bil_Account_Name ASC"

            Else

                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " +
                "Contact_Number, Username_Reg, Sanitize_Mark, Sanitized_by FROM overall_reg WHERE " & Mstr_Column_Name_Search & " LIKE '%" & txt_Mstr_Search_Term.Text & "%' ORDER BY Bil_Account_Name ASC"


            End If
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Mstr_Search.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Bil_Account_Number").ToString
                    newitem.SubItems.Add(drSQL("Bil_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Stub_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Address").ToString)
                    newitem.SubItems.Add(drSQL("Date_Registered").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Class").ToString)
                    newitem.SubItems.Add(drSQL("Contact_Number").ToString)
                    newitem.SubItems.Add(drSQL("Username_Reg").ToString)

                    If drSQL("Sanitize_Mark").ToString = "1" Then
                        newitem.SubItems.Add("Yes")

                    Else
                        newitem.SubItems.Add("No")

                    End If


                    newitem.SubItems.Add(drSQL("Sanitized_by").ToString)
                    AddListItem(newitem)
                    BW_Mstr_Search.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Mstr_Search.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Mstr_Search_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Mstr_Search.ProgressChanged
        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Mstr_Search_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Mstr_Search.RunWorkerCompleted


        BW_Masterlist_Search_Loader = False

        lst_Masterlist.Visible = True
        pan_masterlist_controls.Enabled = True
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = False
        tmr_Circ_masterlist_anim.Enabled = False



    End Sub


    Private Sub btn_Masterlist_Search_Click(sender As Object, e As EventArgs) Handles btn_Masterlist_Search.Click
        If txt_Mstr_Search_Term.Text <> "" Then

            If rdo_Mstr_AccountNumberSearch.Checked = True Then
                If BW_Masterlist_Search_Loader = False Then
                    txt_Mstr_Search_Term.Text = Correct_Account_Number(txt_Mstr_Search_Term.Text)
                    lst_Masterlist.Items.Clear()

                    lst_Masterlist.Visible = False
                    pan_masterlist_controls.Enabled = False
                    circ_prog_masterlist.Value = 0
                    circ_prog_masterlist.Visible = True
                    tmr_Circ_masterlist_anim.Enabled = True

                    BW_Masterlist_Search_Loader = True

                    Mstr_Column_Name_Search = "Bil_Account_Number"

                    BW_Mstr_Search.RunWorkerAsync()
                End If

            ElseIf rdo_Mstr_Address_Search.Checked = True Then
                If BW_Masterlist_Search_Loader = False Then
                    lst_Masterlist.Items.Clear()

                    lst_Masterlist.Visible = False
                    pan_masterlist_controls.Enabled = False
                    circ_prog_masterlist.Value = 0
                    circ_prog_masterlist.Visible = True
                    tmr_Circ_masterlist_anim.Enabled = True

                    BW_Masterlist_Search_Loader = True

                    Mstr_Column_Name_Search = "Bil_Address"

                    BW_Mstr_Search.RunWorkerAsync()
                End If
            ElseIf rdo_Mstr_NameSearch.Checked = True Then
                If BW_Masterlist_Search_Loader = False Then
                    lst_Masterlist.Items.Clear()

                    lst_Masterlist.Visible = False
                    pan_masterlist_controls.Enabled = False
                    circ_prog_masterlist.Value = 0
                    circ_prog_masterlist.Visible = True
                    tmr_Circ_masterlist_anim.Enabled = True

                    BW_Masterlist_Search_Loader = True

                    Mstr_Column_Name_Search = "Bil_Account_Name"

                    BW_Mstr_Search.RunWorkerAsync()
                End If
            ElseIf rdo_Mstr_Registrant_Search.Checked = True Then
                If BW_Masterlist_Search_Loader = False Then
                    lst_Masterlist.Items.Clear()

                    lst_Masterlist.Visible = False
                    pan_masterlist_controls.Enabled = False
                    circ_prog_masterlist.Value = 0
                    circ_prog_masterlist.Visible = True
                    tmr_Circ_masterlist_anim.Enabled = True

                    BW_Masterlist_Search_Loader = True

                    Mstr_Column_Name_Search = "Username_Reg"

                    BW_Mstr_Search.RunWorkerAsync()
                End If
            End If

        End If


    End Sub

    Private Sub txt_Mstr_Search_Term_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Mstr_Search_Term.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_Mstr_Search_Term.Text <> "" Then

                If rdo_Mstr_AccountNumberSearch.Checked = True Then
                    If BW_Masterlist_Search_Loader = False Then
                        txt_Mstr_Search_Term.Text = Correct_Account_Number(txt_Mstr_Search_Term.Text)

                        lst_Masterlist.Items.Clear()

                        lst_Masterlist.Visible = False
                        pan_masterlist_controls.Enabled = False
                        circ_prog_masterlist.Value = 0
                        circ_prog_masterlist.Visible = True
                        tmr_Circ_masterlist_anim.Enabled = True

                        BW_Masterlist_Search_Loader = True

                        Mstr_Column_Name_Search = "Bil_Account_Number"

                        BW_Mstr_Search.RunWorkerAsync()
                    End If

                ElseIf rdo_Mstr_Address_Search.Checked = True Then
                    If BW_Masterlist_Search_Loader = False Then
                        lst_Masterlist.Items.Clear()

                        lst_Masterlist.Visible = False
                        pan_masterlist_controls.Enabled = False
                        circ_prog_masterlist.Value = 0
                        circ_prog_masterlist.Visible = True
                        tmr_Circ_masterlist_anim.Enabled = True

                        BW_Masterlist_Search_Loader = True

                        Mstr_Column_Name_Search = "Bil_Address"

                        BW_Mstr_Search.RunWorkerAsync()
                    End If
                ElseIf rdo_Mstr_NameSearch.Checked = True Then
                    If BW_Masterlist_Search_Loader = False Then
                        lst_Masterlist.Items.Clear()

                        lst_Masterlist.Visible = False
                        pan_masterlist_controls.Enabled = False
                        circ_prog_masterlist.Value = 0
                        circ_prog_masterlist.Visible = True
                        tmr_Circ_masterlist_anim.Enabled = True

                        BW_Masterlist_Search_Loader = True

                        Mstr_Column_Name_Search = "Bil_Account_Name"

                        BW_Mstr_Search.RunWorkerAsync()
                    End If
                ElseIf rdo_Mstr_Registrant_Search.Checked = True Then
                    If BW_Masterlist_Search_Loader = False Then
                        lst_Masterlist.Items.Clear()

                        lst_Masterlist.Visible = False
                        pan_masterlist_controls.Enabled = False
                        circ_prog_masterlist.Value = 0
                        circ_prog_masterlist.Visible = True
                        tmr_Circ_masterlist_anim.Enabled = True

                        BW_Masterlist_Search_Loader = True

                        Mstr_Column_Name_Search = "Username_Reg"

                        BW_Mstr_Search.RunWorkerAsync()
                    End If
                End If

            End If
        End If



    End Sub



    Private Sub cntx_Masterlist_Click(sender As Object, e As EventArgs) Handles cntx_Masterlist.Click

    End Sub

    Private Sub lst_Masterlist_DoubleClick(sender As Object, e As EventArgs) Handles lst_Masterlist.DoubleClick
        If BW_Mstr_Load_Reg_Flag = False Then
            BW_Mstr_Load_Reg_Flag = True

            Masterlist_Sel_ID = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(2).Text

            lst_Masterlist.Visible = False
            pan_masterlist_controls.Enabled = False
            circ_prog_masterlist.Value = 0
            circ_prog_masterlist.Visible = True
            tmr_Circ_masterlist_anim.Enabled = True

            Mstr_Reg_View_Det_Data.Clear()
            image_loaded_checker = False

            BW_Mstr_Load_Reg_Details.RunWorkerAsync()



        End If







    End Sub

    Private Sub lst_Masterlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Masterlist.SelectedIndexChanged

    End Sub

    Private Sub BW_Mstr_Load_Reg_Details_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Mstr_Load_Reg_Details.DoWork

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim arrImage As Byte()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"


        Try


            MysqlConn.Open()
            sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " _
                + "Contact_Number, Username_Reg, Raffle_Valid FROM overall_reg WHERE Stub_Number = '" & Masterlist_Sel_ID & "'"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Mstr_Load_Reg_Details.CancellationPending) Then

                    Mstr_Reg_View_Det_Data.Add(drSQL("Bil_Account_Number").ToString)
                    Mstr_Reg_View_Det_Data.Add(drSQL("Bil_Account_Name").ToString)
                    Mstr_Reg_View_Det_Data.Add(drSQL("Stub_Number").ToString)
                    Mstr_Reg_View_Det_Data.Add(drSQL("Bil_Address").ToString)
                    Mstr_Reg_View_Det_Data.Add(drSQL("Date_Registered").ToString)
                    Mstr_Reg_View_Det_Data.Add(drSQL("Bil_Class").ToString)
                    Mstr_Reg_View_Det_Data.Add(drSQL("Contact_Number").ToString)
                    Mstr_Reg_View_Det_Data.Add(drSQL("Username_Reg").ToString)
                    Mstr_Reg_View_Det_Data.Add(drSQL("Raffle_Valid").ToString)

                    BW_Mstr_Load_Reg_Details.ReportProgress(25)

                ElseIf (BW_Mstr_Load_Reg_Details.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...



        Try
            MysqlConn.Open()

            If Mstr_Reg_View_Det_Data(7).ToString = "Guest" Then

                sql = "SELECT Signature, Photo_ID FROM pre_reg WHERE Stub_Number = '" & Masterlist_Sel_ID & "'"

            Else

                sql = "SELECT Signature, Photo_ID FROM mco_reg WHERE Stub_Number = '" & Masterlist_Sel_ID & "'"

            End If



            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()

            Do While drSQL.Read = True

                Using myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Mstr_Reg_Det_Signature = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_Mstr_Load_Reg_Details.ReportProgress(50)


                Using myMS As New IO.MemoryStream
                    arrImage = drSQL("Photo_ID")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Mstr_Reg_Det_Photo_ID = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_Mstr_Load_Reg_Details.ReportProgress(75)

                image_loaded_checker = True
            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            image_loaded_checker = False
            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1009" + vbNewLine + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally


            MysqlConn.Close()


        End Try 'Give the thread a very..very short break...

        BW_Mstr_Load_Reg_Details.ReportProgress(100)

    End Sub

    Private Sub BW_Mstr_Load_Reg_Details_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Mstr_Load_Reg_Details.ProgressChanged
        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Mstr_Load_Reg_Details_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Mstr_Load_Reg_Details.RunWorkerCompleted

        If image_loaded_checker = True Then
            BW_Mstr_Load_Reg_Flag = False


            lst_Masterlist.Visible = True
            pan_masterlist_controls.Enabled = True
            circ_prog_masterlist.Value = 0
            circ_prog_masterlist.Visible = False
            tmr_Circ_masterlist_anim.Enabled = False

            frm_Reg_Details_Master.txt_Account_Number.Text = Mstr_Reg_View_Det_Data(0).ToString
            frm_Reg_Details_Master.txt_Account_Name.Text = Mstr_Reg_View_Det_Data(1).ToString
            frm_Reg_Details_Master.txt_Stub_Number.Text = Mstr_Reg_View_Det_Data(2).ToString
            frm_Reg_Details_Master.txt_Address.Text = Mstr_Reg_View_Det_Data(3).ToString
            frm_Reg_Details_Master.txt_Date_Registered.Text = Mstr_Reg_View_Det_Data(4).ToString
            frm_Reg_Details_Master.txt_Account_Class.Text = Mstr_Reg_View_Det_Data(5).ToString
            frm_Reg_Details_Master.txt_Contact_Number.Text = Mstr_Reg_View_Det_Data(6).ToString
            frm_Reg_Details_Master.txt_Registered_By.Text = Mstr_Reg_View_Det_Data(7).ToString
            If Mstr_Reg_View_Det_Data(8).ToString = "2" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = True
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = False

                Reg_Raffle_Validity = 2
            ElseIf Mstr_Reg_View_Det_Data(8).ToString = "1" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = False
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = True

                Reg_Raffle_Validity = 1

            ElseIf Mstr_Reg_View_Det_Data(8).ToString = "0" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = False
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = False

                Reg_Raffle_Validity = 0


            End If

            frm_Reg_Details_Master.raffle_val_changed = False

            frm_Reg_Details_Master.pic_Signature.Image = Mstr_Reg_Det_Signature
            frm_Reg_Details_Master.pic_Signature.SizeMode = PictureBoxSizeMode.Zoom

            frm_Reg_Details_Master.pic_ID_Snapshot.Image = Mstr_Reg_Det_Photo_ID
            frm_Reg_Details_Master.pic_ID_Snapshot.SizeMode = PictureBoxSizeMode.Zoom

            frm_Reg_Details_Master.ShowDialog()


        End If


    End Sub


    Private Sub btn_Mstr_View_Details_Click(sender As Object, e As EventArgs) Handles btn_Mstr_View_Details.Click
        If BW_Mstr_Load_Reg_Flag = False Then
            BW_Mstr_Load_Reg_Flag = True

            Masterlist_Sel_ID = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(2).Text

            lst_Masterlist.Visible = False
            pan_masterlist_controls.Enabled = False
            circ_prog_masterlist.Value = 0
            circ_prog_masterlist.Visible = True
            tmr_Circ_masterlist_anim.Enabled = True

            Mstr_Reg_View_Det_Data.Clear()
            image_loaded_checker = False

            BW_Mstr_Load_Reg_Details.RunWorkerAsync()



        End If
    End Sub


    Private Sub btn_mstr_export_PDF_Click(sender As Object, e As EventArgs) Handles btn_mstr_export_PDF.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog

        Try
            If f.ShowDialog() = DialogResult.OK Then
                fileName_Mstr_PDF = "\AGMA2024_Masterlist"
                filepath_Mstr_PDF = f.SelectedPath
                finalPath_Mstr_PDF = f.SelectedPath + fileName_Mstr_PDF


                lst_Masterlist.Visible = False
                pan_masterlist_controls.Enabled = False
                circ_prog_masterlist.Value = 0
                circ_prog_masterlist.Visible = True
                tmr_Circ_masterlist_anim.Enabled = True



                ItemNumber_Mstr_PDF = 1
                BW_PDF_Exporter_Masterlist.RunWorkerAsync()




            End If
        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BW_PDF_Exporter_Masterlist_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_PDF_Exporter_Masterlist.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String = ""
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim MaxPage_PDF As Double
        Dim PageNum As Integer = 0

        Dim maxItems As Integer
        Dim currItem As Integer

        Dim Saver_Counter As Integer = 0
        Dim File_Counter As Integer = 0

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        Try

            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM overall_reg ORDER BY BIl_Account_Name ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            maxItems = count
            MaxPage_PDF = count / 15


            Dim TempVal As Integer = MaxPage_PDF
            If MaxPage_PDF > TempVal Then
                MaxPage_PDF += 1
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            Else
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            End If



        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1053", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()



        End Try

        'Dim currentDate As DateTime = DateTime.Now

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim CurrenPageItems As Integer = 0
        Dim TempStr As String = ""
        Dim TempLen As Integer = 0
        Dim WidthPic As Single = 100 / 1.745
        Dim HeigthPic As Single = 100



        Dim pdf As pdf3.PdfDocument = New pdf3.PdfDocument
        pdf.Info.Title = fileName_Mstr_PDF
        Dim pdfPage As pdf3.PdfPage = pdf.AddPage
        pdfPage.Size = PdfSharp.PageSize.Folio
        Dim Logo_TopLeft As pdf2.XImage
        Logo_TopLeft = Logo_PNG



        pdfPage.Width = 850
        pdfPage.Height = 1300
        pdfPage.TrimMargins.Top = 15
        pdfPage.TrimMargins.Right = 15
        pdfPage.TrimMargins.Bottom = 15
        pdfPage.TrimMargins.Left = 15


        Dim graph As pdf2.XGraphics = pdf2.XGraphics.FromPdfPage(pdfPage)
        ' Dim font As pdf2.XFont = New pdf2.XFont("Verdana", 20, pdf2.XFontStyle.Bold)
        'graph.DrawString("Sample output", font, pdf2.XBrushes.Black, New pdf2.XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), pdf2.XStringFormats.Center)

        graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

        graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

        graph.DrawString("BILECO",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

        graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

        graph.DrawString("www.bileco.net",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

        graph.DrawString("36th Annual General Membership Assembly | Overall Registration List",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

        graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

        graph.DrawString("Date:   August 24, 2024",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)



        'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

        'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

        'graph.DrawString("Members : " + Member_1, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

        'graph.DrawString(Member_2, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)


        graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

        graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

        'graph.DrawString("User logged in: " + Logged_Username, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

        xPos += 30

        graph.DrawString("#",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 40

        graph.DrawString("Account #",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
        xPos += 100

        graph.DrawString("Account Name",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 200

        graph.DrawString("Address",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 180

        graph.DrawString("Stub #",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 110

        graph.DrawString("Signature",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos = 0

        yPos += 290

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql = "SELECT Bil_Account_Number, Bil_Account_Name, Bil_Address, Stub_number, Signature FROM overall_reg ORDER BY Bil_Account_Name ASC"

        Try
            MysqlConn.Open()
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                ' If (Val(drSQL("r_id").ToString) > Last_ID_PDF_OVR) And (currItem < 75) Then
                'Last_ID_PDF_OVR = Val(drSQL("r_id").ToString)

                currItem += 1
                BW_PDF_Exporter_Masterlist.ReportProgress((currItem / (maxItems + 5)) * 100)
                xPos = 0
                'xIndex = 1


                xPos += 30

                graph.DrawString(ItemNumber_Mstr_PDF.ToString,
                     New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                xPos += 40

                graph.DrawString(drSQL("Bil_Account_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 100
                TempStr = drSQL("Bil_Account_Name")
                TempLen = TempStr.Length
                If TempLen > 25 Then
                    TempStr = Mid(drSQL("Bil_Account_Name"), 1, 25)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Account_Name"), 26, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Account_Name")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If



                xPos += 200
                TempStr = drSQL("Bil_Address")
                TempLen = TempStr.Length
                If TempLen > 27 Then
                    TempStr = Mid(drSQL("Bil_Address"), 1, 27)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Address"), 28, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Address")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If

                'xPos += 230
                xPos += 180

                graph.DrawString(drSQL("Stub_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 90

                'If Val(drSQL("Pre_reg").ToString) = 1 Then

                '    graph.DrawString("Pre-Registered", _
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'ElseIf Val(drSQL("Pre_Reg").ToString) = 0 Then
                Using myMS As New IO.MemoryStream
                    Dim arrImage As Byte()
                    'Dim myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")

                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next

                    If CurrenPageItems Mod 2 = 1 Then
                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos - 20, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    Else
                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos + 60, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    End If

                    'Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    'graph.DrawImage(Temp_Sign, xPos - 20, yPos - 60, WidthPic, HeigthPic)
                    'Temp_Sign.Dispose()


                End Using
                ' End If



                xPos = 0
                yPos += 60
                ItemNumber_Mstr_PDF += 1
                CurrenPageItems += 1

                If CurrenPageItems > 14 Then

                    CurrenPageItems = 0
                    PageNum += 1

                    graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

                    graph.DrawString("*This is an electronic-generated report. ",
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

                    Saver_Counter += 1

                    If Saver_Counter >= 10 Then
                        Saver_Counter = 0
                        File_Counter += 1

                        pdf.Save(finalPath_Mstr_PDF + "(Items " + (ItemNumber_Mstr_PDF - 150).ToString + " to " + (ItemNumber_Mstr_PDF - 1).ToString + ").pdf")
                        pdf.Dispose()
                        graph.Graphics.Dispose()
                        graph.Internals.Graphics.Dispose()
                        graph.Dispose()


                        pdf = New pdf3.PdfDocument
                        pdf.Info.Title = fileName_Mstr_PDF


                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15
                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)

                    Else
                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15

                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)


                    End If




                    '---------------------------
                    yPos = 0

                    graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

                    graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

                    graph.DrawString("BILECO",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

                    graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

                    graph.DrawString("www.bileco.net",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

                    graph.DrawString("36th Annual General Membership Assembly | Overall Registration List",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

                    graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

                    graph.DrawString("Date:   August 24, 2024",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)






                    'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

                    'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

                    'graph.DrawString("Members : " + Member_1, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

                    'graph.DrawString(Member_2, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)

                    graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

                    graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

                    'graph.DrawString("User logged in: " + Logged_Username, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

                    xPos += 30

                    graph.DrawString("#",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 40

                    graph.DrawString("Account #",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
                    xPos += 100

                    graph.DrawString("Account Name",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 200

                    graph.DrawString("Address",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 180

                    graph.DrawString("Stub #",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 110

                    graph.DrawString("Signature",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos = 0

                    yPos += 290


                End If


            Loop

        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1054", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        PageNum += 1
        graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

        graph.DrawString("*This is an electronic-generated report. ",
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

        If yPos < 1100 Then
            yPos += 30
        Else
            yPos -= 10
        End If



        graph.DrawString("Prepared by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Reviewed by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Checked by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Noted by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 590, yPos)


        yPos += 40

        graph.DrawString(User_Curr_Full_Name,
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        'graph.DrawString("______________________",
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Allan Joseph S. Borrinaga",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Maureen D. Nierra",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Gerardo N. Oledan, REE",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 590, yPos)

        yPos += 15

        'If Lead_Person_Printing = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Lead person", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'ElseIf (Member_1 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Or (Member_2 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Member", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'End If

        'graph.DrawString(Logged_User_Position, _
        '    New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString(User_Curr_Logged_Position.Replace("BILECO ", ""),
            New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("ISDM",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Internal Auditor",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 400, yPos)


        graph.DrawString("General Manager",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 590, yPos)

        Dim Temp_Subtractor As Integer = ItemNumber_Mstr_PDF - (File_Counter * 150)
        Try
            pdf.Save(finalPath_Mstr_PDF + "(Items " + (ItemNumber_Mstr_PDF - Temp_Subtractor + 1).ToString + " to " + (ItemNumber_Mstr_PDF - 1).ToString + ").pdf")
            pdf.Dispose()
            graph.Dispose()
            currItem += 5
            BW_PDF_Exporter_Masterlist.ReportProgress((currItem / (maxItems + 5)) * 100)

            DevComponents.DotNetBar.MessageBoxEx.Show("PDF Export done.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(filepath_Mstr_PDF)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BW_PDF_Exporter_Masterlist_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_PDF_Exporter_Masterlist.ProgressChanged



        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + " %"


    End Sub

    Private Sub BW_PDF_Exporter_Masterlist_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_PDF_Exporter_Masterlist.RunWorkerCompleted
        lst_Masterlist.Visible = True
        pan_masterlist_controls.Enabled = True
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = False
        tmr_Circ_masterlist_anim.Enabled = False



    End Sub

    Private Sub btn_mstr_export_Excel_Click(sender As Object, e As EventArgs) Handles btn_mstr_export_Excel.Click

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        If f.ShowDialog() = DialogResult.OK Then
            fileName_Excel_Mstr = "\AGMA2024_Masterlist.xls"
            finalPath_Excel_Mstr = f.SelectedPath + fileName_Excel_Mstr


            lst_Masterlist.Visible = False
            pan_masterlist_controls.Enabled = False
            circ_prog_masterlist.Value = 0
            circ_prog_masterlist.Visible = True
            tmr_Circ_masterlist_anim.Enabled = True


            BW_Export_Excel_Mstr.RunWorkerAsync()

        End If




    End Sub

    Private Sub BW_Export_Excel_Mstr_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Export_Excel_Mstr.DoWork
        Dim rprtr As Integer = 0
        Dim dataSet As New DataSet
        ' Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        'Dim connection As New SqlClient.SqlConnection

        Dim MysqlConn1 As MySqlConnection
        Dim sql1 As String
        Dim cmd1 As MySqlCommand
        'Dim drSQL1 As MySqlDataReader
        Dim da1 As New MySqlDataAdapter

        MysqlConn1 = New MySqlConnection
        MysqlConn1.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024"

        sql1 = "SELECT Bil_Account_Number As 'Account Number', Bil_Account_Name As 'Account Name', Bil_Class as 'Account Class', " +
            "Bil_Address As 'Address', Date_Registered As 'Date Registered', Stub_Number As 'Stub #', " +
            "Contact_Number As 'Contact #', Username_Reg as 'Registered by', CONCAT((Select First_Name FROM user_accounts WHERE Username = Username_Reg), ' ', " +
            "(Select Middle_Initial FROM user_accounts WHERE Username = Username_Reg), '. ', " +
            "(Select Last_Name FROM user_accounts WHERE Username = Username_Reg)) as 'Full Name', " +
            "(Select Position FROM user_accounts WHERE Username = Username_Reg) as 'Position' " +
            "From overall_reg Order By Bil_Account_Name ASC"

        cmd1 = New MySqlCommand(sql1, MysqlConn1)

        da1.SelectCommand = cmd1

        Try

            BW_Export_Excel_Mstr.ReportProgress(2)
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            'Fill data to datatable

            'connection.Open()
            MysqlConn1.Open()
            da1.Fill(datatableMain)
            MysqlConn1.Close()
            rprtr = 5
            BW_Export_Excel_Mstr.ReportProgress(5)
            'Export the Columns to excel file
            For Each dc In datatableMain.Columns

                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
                rprtr = colIndex + 5
                BW_Export_Excel_Mstr.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)

            Next
            oSheet.Range(oSheet.Cells(1, 1), oSheet.Cells(1, colIndex)).Font.Bold = True
            rowIndex = rowIndex + 1
            'Export the rows to excel file
            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
                rprtr = rowIndex + colIndex + 5
                BW_Export_Excel_Mstr.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)
            Next

            'Set final path

            'txtPath.Text = finalPath
            oSheet.Columns.AutoFit()
            'Save file in final path
            oBook.SaveAs(finalPath_Excel_Mstr, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            'Release the objects
            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            'Some time Office application does not quit after automation: 
            'so i am calling GC.Collect method.
            GC.Collect()
            BW_Export_Excel_Mstr.ReportProgress(100)

            'TabMain.Enabled = True
            'TabMain.Enabled = False
            'CircVal = 0
            'CircProg.Location = New Point((Pan_Excel_Loader.Width / 2) - (Circ_Loader.Width / 2), (Pan_Excel_Loader.Height / 2) - (Circ_Loader.Height / 2))
            'Pan_Excel_Loader.Location = New Point((TabRafflePanel.Width / 2) - (Pan_Excel_Loader.Width / 2), (TabRafflePanel.Height / 2) - (Pan_Excel_Loader.Height / 2))

            DevComponents.DotNetBar.MessageBoxEx.Show("Export Successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1041", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BW_Export_Excel_Mstr_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Export_Excel_Mstr.ProgressChanged

        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_Export_Excel_Mstr_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Export_Excel_Mstr.RunWorkerCompleted
        lst_Masterlist.Visible = True
        pan_masterlist_controls.Enabled = True
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = False
        tmr_Circ_masterlist_anim.Enabled = False


    End Sub

    Private Sub ReleaseObject(ByVal o As Object)
        Try
            While (System.Runtime.InteropServices.Marshal.ReleaseComObject(o) > 0)
            End While
        Catch ex As Exception
            MsgBox("Exception line: 0xF1040" + vbNewLine + vbNewLine + ex.Message, MsgBoxStyle.OkOnly, "Error")
        Finally
            o = Nothing
        End Try
    End Sub

    Private Sub btn_mstr_export_district_PDF_Click(sender As Object, e As EventArgs) Handles btn_mstr_export_district_PDF.Click
        Selected_District = ""

        Loaded_District.Clear()

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"



        Try

            MysqlConn.Open()



            sql = "SELECT Town, COUNT(*) as Town_Count FROM overall_reg GROUP BY Town ORDER BY Town_Count ASC"


            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True


                Loaded_District.Add(drSQL("Town").ToString)


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...



        If Loaded_District.Count > 0 Then
            frm_District_Selection.ShowDialog()

            If Selected_District <> "" Then
                Dim f As FolderBrowserDialog = New FolderBrowserDialog

                Try

                    If f.ShowDialog() = DialogResult.OK Then
                        fileName_Mstr_Dist_PDF = "\AGMA2024_Masterlist_" + Selected_District + "_Only"
                        filepath_Mstr_Dist_PDF = f.SelectedPath
                        finalPath_Mstr_Dist_PDF = f.SelectedPath + fileName_Mstr_Dist_PDF



                        lst_Masterlist.Visible = False
                        pan_masterlist_controls.Enabled = False
                        circ_prog_masterlist.Value = 0
                        circ_prog_masterlist.Visible = True
                        tmr_Circ_masterlist_anim.Enabled = True



                        ItemNumber_Mstr_Dist_PDF = 1
                        BW_PDF_Exporter_Mstr_Dist.RunWorkerAsync()

                    Else



                    End If


                Catch ex As Exception

                    DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try



            End If

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("No Entries Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If








    End Sub

    Private Sub BW_PDF_Exporter_Mstr_Dist_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_PDF_Exporter_Mstr_Dist.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String = ""
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim MaxPage_PDF As Double
        Dim PageNum As Integer = 0

        Dim maxItems As Integer
        Dim currItem As Integer

        Dim Saver_Counter As Integer = 0
        Dim File_Counter As Integer = 0

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        Try

            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM overall_reg WHERE Town = '" & Selected_District & "' ORDER BY Bil_Account_Name ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            maxItems = count
            MaxPage_PDF = count / 15


            Dim TempVal As Integer = MaxPage_PDF
            If MaxPage_PDF > TempVal Then
                MaxPage_PDF += 1
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            Else
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            End If



        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1053", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()



        End Try

        'Dim currentDate As DateTime = DateTime.Now

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim CurrenPageItems As Integer = 0
        Dim TempStr As String = ""
        Dim TempLen As Integer = 0
        Dim WidthPic As Single = 100 / 1.745
        Dim HeigthPic As Single = 100



        Dim pdf As pdf3.PdfDocument = New pdf3.PdfDocument
        pdf.Info.Title = fileName_Mstr_Dist_PDF
        Dim pdfPage As pdf3.PdfPage = pdf.AddPage
        pdfPage.Size = PdfSharp.PageSize.Folio
        Dim Logo_TopLeft As pdf2.XImage
        Logo_TopLeft = Logo_PNG



        pdfPage.Width = 850
        pdfPage.Height = 1300
        pdfPage.TrimMargins.Top = 15
        pdfPage.TrimMargins.Right = 15
        pdfPage.TrimMargins.Bottom = 15
        pdfPage.TrimMargins.Left = 15


        Dim graph As pdf2.XGraphics = pdf2.XGraphics.FromPdfPage(pdfPage)
        ' Dim font As pdf2.XFont = New pdf2.XFont("Verdana", 20, pdf2.XFontStyle.Bold)
        'graph.DrawString("Sample output", font, pdf2.XBrushes.Black, New pdf2.XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), pdf2.XStringFormats.Center)

        graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

        graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

        graph.DrawString("BILECO",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

        graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

        graph.DrawString("www.bileco.net",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

        graph.DrawString("36th Annual General Membership Assembly | " + Selected_District + " District Registration List",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

        graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

        graph.DrawString("Date:   August 24, 2024",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)



        'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

        'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

        'graph.DrawString("Members : " + Member_1, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

        'graph.DrawString(Member_2, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)


        graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

        graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

        'graph.DrawString("User logged in: " + Logged_Username, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

        xPos += 30

        graph.DrawString("#",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 40

        graph.DrawString("Account #",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
        xPos += 100

        graph.DrawString("Account Name",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 180

        graph.DrawString("Address",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 200

        graph.DrawString("Membership Number",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 150

        graph.DrawString("Signature",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos = 0

        yPos += 290

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql = "SELECT Bil_Account_Number, Bil_Account_Name, Bil_Address, Signature, " _
                & "(SELECT accounts_list.Membership_Number FROM accounts_list WHERE accounts_list.Account_Number = overall_reg.Bil_Account_Number) AS Membership_Number " _
                & "FROM overall_reg WHERE Town = '" & Selected_District & "' ORDER BY Bil_Account_Name ASC"

        Try
            MysqlConn.Open()
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                ' If (Val(drSQL("r_id").ToString) > Last_ID_PDF_OVR) And (currItem < 75) Then
                'Last_ID_PDF_OVR = Val(drSQL("r_id").ToString)

                currItem += 1
                BW_PDF_Exporter_Mstr_Dist.ReportProgress((currItem / (maxItems + 5)) * 100)
                xPos = 0
                'xIndex = 1


                xPos += 30

                graph.DrawString(ItemNumber_Mstr_Dist_PDF.ToString,
                     New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                xPos += 40

                graph.DrawString(drSQL("Bil_Account_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 100
                TempStr = drSQL("Bil_Account_Name")
                TempLen = TempStr.Length
                If TempLen > 25 Then
                    TempStr = Mid(drSQL("Bil_Account_Name"), 1, 25)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Account_Name"), 26, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Account_Name")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If



                xPos += 180
                TempStr = drSQL("Bil_Address")
                TempLen = TempStr.Length
                If TempLen > 27 Then
                    TempStr = Mid(drSQL("Bil_Address"), 1, 27)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Address"), 28, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Address")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If

                'xPos += 230
                xPos += 200

                graph.DrawString(drSQL("Membership_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 150

                'If Val(drSQL("Pre_reg").ToString) = 1 Then

                '    graph.DrawString("Pre-Registered", _
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'ElseIf Val(drSQL("Pre_Reg").ToString) = 0 Then
                Using myMS As New IO.MemoryStream
                    Dim arrImage As Byte()
                    'Dim myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")

                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next

                    If CurrenPageItems Mod 2 = 1 Then
                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos - 20, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    Else
                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos + 60, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    End If

                    'Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    'graph.DrawImage(Temp_Sign, xPos - 20, yPos - 60, WidthPic, HeigthPic)
                    'Temp_Sign.Dispose()


                End Using
                ' End If



                xPos = 0
                yPos += 60
                ItemNumber_Mstr_Dist_PDF += 1
                CurrenPageItems += 1

                If CurrenPageItems > 14 Then

                    CurrenPageItems = 0
                    PageNum += 1

                    graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

                    graph.DrawString("*This is an electronic-generated report. ",
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

                    Saver_Counter += 1

                    If Saver_Counter >= 10 Then
                        Saver_Counter = 0
                        File_Counter += 1

                        pdf.Save(finalPath_Mstr_Dist_PDF + "(Items " + (ItemNumber_Mstr_Dist_PDF - 150).ToString + " to " + (ItemNumber_Mstr_Dist_PDF - 1).ToString + ").pdf")
                        pdf.Dispose()
                        graph.Graphics.Dispose()
                        graph.Internals.Graphics.Dispose()
                        graph.Dispose()


                        pdf = New pdf3.PdfDocument
                        pdf.Info.Title = fileName_Mstr_Dist_PDF


                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15
                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)

                    Else
                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15

                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)


                    End If




                    '---------------------------
                    yPos = 0

                    graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

                    graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

                    graph.DrawString("BILECO",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

                    graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

                    graph.DrawString("www.bileco.net",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

                    graph.DrawString("36th Annual General Membership Assembly | " + Selected_District + " District Registration List",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

                    graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

                    graph.DrawString("Date:   August 24, 2024",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)






                    'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

                    'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

                    'graph.DrawString("Members : " + Member_1, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

                    'graph.DrawString(Member_2, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)

                    graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

                    graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

                    'graph.DrawString("User logged in: " + Logged_Username, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

                    xPos += 30

                    graph.DrawString("#",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 40

                    graph.DrawString("Account #",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
                    xPos += 100

                    graph.DrawString("Account Name",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 180

                    graph.DrawString("Address",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 200

                    graph.DrawString("Membership Number",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 150

                    graph.DrawString("Signature",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos = 0

                    yPos += 290


                End If


            Loop

        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1054", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        PageNum += 1
        graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

        graph.DrawString("*This is an electronic-generated report. ",
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

        If yPos < 1100 Then
            yPos += 30
        Else
            yPos -= 10
        End If



        graph.DrawString("Prepared by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Reviewed by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Checked by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Noted by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 590, yPos)


        yPos += 40

        graph.DrawString(User_Curr_Full_Name,
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        'graph.DrawString("______________________",
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Allan Joseph S. Borrinaga",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Maureen D. Nierra",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Gerardo N. Oledan, REE",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 590, yPos)

        yPos += 15

        'If Lead_Person_Printing = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Lead person", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'ElseIf (Member_1 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Or (Member_2 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Member", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'End If

        'graph.DrawString(Logged_User_Position, _
        '    New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString(User_Curr_Logged_Position.Replace("BILECO ", ""),
            New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("ISDM",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Internal Auditor",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 400, yPos)


        graph.DrawString("General Manager",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 590, yPos)

        Dim Temp_Subtractor As Integer = ItemNumber_Mstr_Dist_PDF - (File_Counter * 150)
        Try
            pdf.Save(finalPath_Mstr_Dist_PDF + "(Items " + (ItemNumber_Mstr_Dist_PDF - Temp_Subtractor + 1).ToString + " to " + (ItemNumber_Mstr_Dist_PDF - 1).ToString + ").pdf")
            pdf.Dispose()
            graph.Dispose()
            currItem += 5
            BW_PDF_Exporter_Mstr_Dist.ReportProgress((currItem / (maxItems + 5)) * 100)

            DevComponents.DotNetBar.MessageBoxEx.Show("PDF Export done.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(filepath_Mstr_Dist_PDF)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BW_PDF_Exporter_Mstr_Dist_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_PDF_Exporter_Mstr_Dist.ProgressChanged
        'circ_prog_masterlist.Value = e.ProgressPercentage
        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_PDF_Exporter_Mstr_Dist_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_PDF_Exporter_Mstr_Dist.RunWorkerCompleted
        lst_Masterlist.Visible = True
        pan_masterlist_controls.Enabled = True
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = False
        tmr_Circ_masterlist_anim.Enabled = False
    End Sub

    Private Sub btn_mstr_export_district_Excel_Click(sender As Object, e As EventArgs) Handles btn_mstr_export_district_Excel.Click

        Selected_District = ""

        Loaded_District.Clear()

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"



        Try


            MysqlConn.Open()
            sql = "SELECT Town, COUNT(*) as Town_Count FROM overall_reg GROUP BY Town ORDER BY Town_Count ASC"


            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True


                Loaded_District.Add(drSQL("Town").ToString)


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...



        If Loaded_District.Count > 0 Then
            frm_District_Selection.ShowDialog()

            If Selected_District <> "" Then
                Dim f As FolderBrowserDialog = New FolderBrowserDialog


                Try

                    If f.ShowDialog() = DialogResult.OK Then
                        fileName_Excel_Mstr_Dist = "\AGMA2024_Masterlist_" + Selected_District + ".xls"
                        finalPath_Excel_Mstr_Dist = f.SelectedPath + fileName_Excel_Mstr_Dist


                        lst_Masterlist.Visible = False
                        pan_masterlist_controls.Enabled = False
                        circ_prog_masterlist.Value = 0
                        circ_prog_masterlist.Visible = True
                        tmr_Circ_masterlist_anim.Enabled = True


                        BW_Export_Excel_Mstr_Dist.RunWorkerAsync()

                    End If


                Catch ex As Exception

                    DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try



            End If

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("No Entries Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If







    End Sub

    Private Sub BW_Export_Excel_Mstr_Dist_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Export_Excel_Mstr_Dist.DoWork
        Dim rprtr As Integer = 0
        Dim dataSet As New DataSet
        ' Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        'Dim connection As New SqlClient.SqlConnection

        Dim MysqlConn1 As MySqlConnection
        Dim sql1 As String
        Dim cmd1 As MySqlCommand
        'Dim drSQL1 As MySqlDataReader
        Dim da1 As New MySqlDataAdapter

        MysqlConn1 = New MySqlConnection
        MysqlConn1.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024"

        sql1 = "SELECT Bil_Account_Number As 'Account Number', Bil_Account_Name As 'Account Name', Bil_Class as 'Account Class', " +
            "Bil_Address As 'Address', Date_Registered As 'Date Registered', Stub_Number As 'Stub #', " +
            "Contact_Number As 'Contact #', Username_Reg as 'Registered by' FROM overall_reg WHERE Town = '" & Selected_District & "' ORDER BY Bil_Account_Name ASC"
        cmd1 = New MySqlCommand(sql1, MysqlConn1)

        da1.SelectCommand = cmd1

        Try

            BW_Export_Excel_Mstr_Dist.ReportProgress(2)
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            'Fill data to datatable

            'connection.Open()
            MysqlConn1.Open()
            da1.Fill(datatableMain)
            MysqlConn1.Close()
            rprtr = 5
            BW_Export_Excel_Mstr_Dist.ReportProgress(5)
            'Export the Columns to excel file
            For Each dc In datatableMain.Columns

                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
                rprtr = colIndex + 5
                BW_Export_Excel_Mstr_Dist.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)

            Next
            oSheet.Range(oSheet.Cells(1, 1), oSheet.Cells(1, colIndex)).Font.Bold = True
            rowIndex = rowIndex + 1
            'Export the rows to excel file
            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
                rprtr = rowIndex + colIndex + 5
                BW_Export_Excel_Mstr_Dist.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)
            Next

            'Set final path

            'txtPath.Text = finalPath
            oSheet.Columns.AutoFit()
            'Save file in final path
            oBook.SaveAs(finalPath_Excel_Mstr_Dist, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            'Release the objects
            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            'Some time Office application does not quit after automation: 
            'so i am calling GC.Collect method.
            GC.Collect()
            BW_Export_Excel_Mstr_Dist.ReportProgress(100)

            'TabMain.Enabled = True
            'TabMain.Enabled = False
            'CircVal = 0
            'CircProg.Location = New Point((Pan_Excel_Loader.Width / 2) - (Circ_Loader.Width / 2), (Pan_Excel_Loader.Height / 2) - (Circ_Loader.Height / 2))
            'Pan_Excel_Loader.Location = New Point((TabRafflePanel.Width / 2) - (Pan_Excel_Loader.Width / 2), (TabRafflePanel.Height / 2) - (Pan_Excel_Loader.Height / 2))

            DevComponents.DotNetBar.MessageBoxEx.Show("Export Successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1041", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub BW_Export_Excel_Mstr_Dist_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Export_Excel_Mstr_Dist.ProgressChanged


        circ_prog_masterlist.Value = e.ProgressPercentage
        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_Export_Excel_Mstr_Dist_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Export_Excel_Mstr_Dist.RunWorkerCompleted
        lst_Masterlist.Visible = True
        pan_masterlist_controls.Enabled = True
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = False
        tmr_Circ_masterlist_anim.Enabled = False
    End Sub


    Private Sub AddListItem_SelfReg(ByVal lstItem As ListViewItem)

        If Me.lst_Self_Reg.InvokeRequired Then 'Invoke if required...
            Dim d As New SetListItem_Self(AddressOf AddListItem_SelfReg) 'Your delegate...
            Me.lst_Self_Reg.Invoke(d, New Object() {lstItem})
        Else 'Otherwise, no invoke required...
            Me.lst_Self_Reg.Items.Add(lstItem)
        End If
    End Sub



    Private Sub BW_Load_Self_Reg_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Load_Self_Reg.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        Dim Age As Integer = 0
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()

            If chk_Guest_Sanitation_Only.Checked = True Then
                sql = "SELECT COUNT(ID) AS rollcount FROM pre_reg WHERE (SELECT overall_reg.Sanitize_Mark FROM overall_reg WHERE " _
                    & "overall_reg.Bil_Account_Number = pre_reg.Bil_Account_Number) = 0"

            Else

                sql = "SELECT COUNT(ID) AS rollcount FROM pre_reg"

            End If

            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()

            If chk_Guest_Sanitation_Only.Checked = True Then
                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, Contact_Number " _
                    & "FROM pre_reg WHERE (SELECT overall_reg.Sanitize_Mark FROM overall_reg WHERE " _
                    & "overall_reg.Bil_Account_Number = pre_reg.Bil_Account_Number) = 0 ORDER BY Bil_Account_Name ASC"


            Else
                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, Contact_Number FROM pre_reg ORDER BY Bil_Account_Name ASC"


            End If
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True


                If Not (BW_Load_Self_Reg.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Bil_Account_Number").ToString
                    newitem.SubItems.Add(drSQL("Bil_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Stub_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Address").ToString)
                    newitem.SubItems.Add(drSQL("Date_Registered").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Class").ToString)
                    newitem.SubItems.Add(drSQL("Contact_Number").ToString)
                    AddListItem_SelfReg(newitem)
                    BW_Load_Self_Reg.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Load_Self_Reg.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Load_Self_Reg_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Load_Self_Reg.ProgressChanged



        circ_self_reg.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Load_Self_Reg_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Load_Self_Reg.RunWorkerCompleted
        BW_Self_Reg_Loader = False

        lst_Self_Reg.Visible = True
        pan_self_controls.Enabled = True
        circ_self_reg.Value = 0
        circ_self_reg.Visible = False
        tmr_Circ_self_anim.Enabled = False
    End Sub

    Private Sub tmr_Circ_self_anim_Tick(sender As Object, e As EventArgs) Handles tmr_Circ_self_anim.Tick
        If Circ_Forward_Self = True Then
            If circ_self_reg.Value < 100 Then

                circ_self_reg.Value += 10
            ElseIf circ_self_reg.Value >= 100 Then
                Circ_Forward_Self = False
                circ_self_reg.Value -= 10
            End If
        Else
            If circ_self_reg.Value > 0 Then

                circ_self_reg.Value -= 10
            ElseIf circ_self_reg.Value <= 0 Then
                Circ_Forward_Self = True
                circ_self_reg.Value += 10
            End If
        End If
    End Sub

    Private Sub btn_self_refresh_Click(sender As Object, e As EventArgs) Handles btn_self_refresh.Click
        lst_Self_Reg.Items.Clear()

        lst_Self_Reg.Visible = False
        pan_self_controls.Enabled = False
        circ_self_reg.Value = 0
        circ_self_reg.Visible = True
        tmr_Circ_self_anim.Enabled = True

        Refresh_Self_Regs()
    End Sub

    Private Sub lst_Self_Reg_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lst_Self_Reg.ColumnClick
        Dim new_sorting_column As ColumnHeader = lst_Self_Reg.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("▲ ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text =
                m_SortingColumn.Text.Substring(2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "▲ " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "▼ " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        lst_Self_Reg.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        ' Sort.
        lst_Self_Reg.Sort()
    End Sub

    Private Sub lst_Self_Reg_DoubleClick(sender As Object, e As EventArgs) Handles lst_Self_Reg.DoubleClick
        If BW_Self_Load_Reg_Flag = False Then
            BW_Self_Load_Reg_Flag = True

            Self_Sel_ID = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(2).Text

            lst_Self_Reg.Visible = False
            pan_self_controls.Enabled = False
            circ_self_reg.Value = 0
            circ_self_reg.Visible = True
            tmr_Circ_self_anim.Enabled = True

            Self_Reg_View_Det_Data.Clear()
            image_loaded_checker_self = False

            BW_Self_Load_Reg_Details.RunWorkerAsync()



        End If
    End Sub



    Private Sub BW_Self_Load_Reg_Details_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Self_Load_Reg_Details.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim arrImage As Byte()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"


        Try


            MysqlConn.Open()
            sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " _
                + "Contact_Number, (SELECT overall_reg.Raffle_Valid FROM overall_reg WHERE overall_reg.Stub_Number = pre_reg.Stub_Number) as Raf_Valid FROM pre_reg WHERE Stub_Number = '" & Self_Sel_ID & "'"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Self_Load_Reg_Details.CancellationPending) Then

                    Self_Reg_View_Det_Data.Add(drSQL("Bil_Account_Number").ToString)
                    Self_Reg_View_Det_Data.Add(drSQL("Bil_Account_Name").ToString)
                    Self_Reg_View_Det_Data.Add(drSQL("Stub_Number").ToString)
                    Self_Reg_View_Det_Data.Add(drSQL("Bil_Address").ToString)
                    Self_Reg_View_Det_Data.Add(drSQL("Date_Registered").ToString)
                    Self_Reg_View_Det_Data.Add(drSQL("Bil_Class").ToString)
                    Self_Reg_View_Det_Data.Add(drSQL("Contact_Number").ToString)
                    Self_Reg_View_Det_Data.Add("Guest")
                    Self_Reg_View_Det_Data.Add(drSQL("Raf_Valid").ToString)

                    BW_Self_Load_Reg_Details.ReportProgress(25)

                ElseIf (BW_Self_Load_Reg_Details.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...



        Try
            MysqlConn.Open()


            sql = "SELECT Signature, Photo_ID FROM pre_reg WHERE Stub_Number = '" & Self_Sel_ID & "'"


            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()

            Do While drSQL.Read = True

                Using myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Self_Reg_Det_Signature = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_Self_Load_Reg_Details.ReportProgress(50)


                Using myMS As New IO.MemoryStream
                    arrImage = drSQL("Photo_ID")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Self_Reg_Det_Photo_ID = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_Self_Load_Reg_Details.ReportProgress(75)

                image_loaded_checker_self = True
            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            image_loaded_checker_self = False
            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1009" + vbNewLine + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally


            MysqlConn.Close()


        End Try 'Give the thread a very..very short break...

        BW_Self_Load_Reg_Details.ReportProgress(100)
    End Sub

    Private Sub BW_Self_Load_Reg_Details_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Self_Load_Reg_Details.ProgressChanged
        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Self_Load_Reg_Details_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Self_Load_Reg_Details.RunWorkerCompleted
        If image_loaded_checker_self = True Then
            BW_Self_Load_Reg_Flag = False

            lst_Self_Reg.Visible = True
            pan_self_controls.Enabled = True
            circ_self_reg.Value = 0
            circ_self_reg.Visible = False
            tmr_Circ_self_anim.Enabled = False

            frm_Reg_Details_Master.txt_Account_Number.Text = Self_Reg_View_Det_Data(0).ToString
            frm_Reg_Details_Master.txt_Account_Name.Text = Self_Reg_View_Det_Data(1).ToString
            frm_Reg_Details_Master.txt_Stub_Number.Text = Self_Reg_View_Det_Data(2).ToString
            frm_Reg_Details_Master.txt_Address.Text = Self_Reg_View_Det_Data(3).ToString
            frm_Reg_Details_Master.txt_Date_Registered.Text = Self_Reg_View_Det_Data(4).ToString
            frm_Reg_Details_Master.txt_Account_Class.Text = Self_Reg_View_Det_Data(5).ToString
            frm_Reg_Details_Master.txt_Contact_Number.Text = Self_Reg_View_Det_Data(6).ToString
            frm_Reg_Details_Master.txt_Registered_By.Text = Self_Reg_View_Det_Data(7).ToString

            If Self_Reg_View_Det_Data(8).ToString = "2" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = True
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = False

                Reg_Raffle_Validity = 2

            ElseIf Self_Reg_View_Det_Data(8).ToString = "1" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = False
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = True

                Reg_Raffle_Validity = 1

            ElseIf Self_Reg_View_Det_Data(8).ToString = "0" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = False
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = False

                Reg_Raffle_Validity = 0


            End If

            frm_Reg_Details_Master.raffle_val_changed = False

            frm_Reg_Details_Master.pic_Signature.Image = Self_Reg_Det_Signature
            frm_Reg_Details_Master.pic_Signature.SizeMode = PictureBoxSizeMode.Zoom

            frm_Reg_Details_Master.pic_ID_Snapshot.Image = Self_Reg_Det_Photo_ID
            frm_Reg_Details_Master.pic_ID_Snapshot.SizeMode = PictureBoxSizeMode.Zoom

            frm_Reg_Details_Master.ShowDialog()


        End If
    End Sub


    Private Sub btn_Self_View_Details_Click(sender As Object, e As EventArgs) Handles btn_Self_View_Details.Click
        If BW_Self_Load_Reg_Flag = False Then
            BW_Self_Load_Reg_Flag = True

            Self_Sel_ID = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(2).Text

            lst_Self_Reg.Visible = False
            pan_self_controls.Enabled = False
            circ_self_reg.Value = 0
            circ_self_reg.Visible = True
            tmr_Circ_self_anim.Enabled = True

            Self_Reg_View_Det_Data.Clear()
            image_loaded_checker_self = False

            BW_Self_Load_Reg_Details.RunWorkerAsync()



        End If
    End Sub

    Private Sub btn_self_search_Click(sender As Object, e As EventArgs) Handles btn_self_search.Click
        If txt_Self_Search_Term.Text <> "" Then

            If rdo_self_by_number.Checked = True Then
                If BW_Self_Search_Loader = False Then
                    txt_Self_Search_Term.Text = Correct_Account_Number(txt_Self_Search_Term.Text)
                    lst_Self_Reg.Items.Clear()

                    lst_Self_Reg.Visible = False
                    pan_self_controls.Enabled = False
                    circ_self_reg.Value = 0
                    circ_self_reg.Visible = True
                    tmr_Circ_self_anim.Enabled = True

                    BW_Self_Search_Loader = True

                    Self_Column_Name_Search = "Bil_Account_Number"

                    BW_Self_Search.RunWorkerAsync()
                End If

            ElseIf rdo_self_by_address.Checked = True Then
                If BW_Self_Search_Loader = False Then
                    lst_Self_Reg.Items.Clear()

                    lst_Self_Reg.Visible = False
                    pan_self_controls.Enabled = False
                    circ_self_reg.Value = 0
                    circ_self_reg.Visible = True
                    tmr_Circ_self_anim.Enabled = True

                    BW_Self_Search_Loader = True

                    Self_Column_Name_Search = "Bil_Address"

                    BW_Self_Search.RunWorkerAsync()
                End If
            ElseIf rdo_self_by_name.Checked = True Then
                If BW_Self_Search_Loader = False Then
                    lst_Self_Reg.Items.Clear()

                    lst_Self_Reg.Visible = False
                    pan_self_controls.Enabled = False
                    circ_self_reg.Value = 0
                    circ_self_reg.Visible = True
                    tmr_Circ_self_anim.Enabled = True

                    BW_Self_Search_Loader = True

                    Self_Column_Name_Search = "Bil_Account_Name"

                    BW_Self_Search.RunWorkerAsync()
                End If

            End If

        End If
    End Sub

    Private Sub txt_Self_Search_Term_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Self_Search_Term.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_Self_Search_Term.Text <> "" Then

                If rdo_self_by_number.Checked = True Then
                    If BW_Self_Search_Loader = False Then
                        txt_Self_Search_Term.Text = Correct_Account_Number(txt_Self_Search_Term.Text)
                        lst_Self_Reg.Items.Clear()

                        lst_Self_Reg.Visible = False
                        pan_self_controls.Enabled = False
                        circ_self_reg.Value = 0
                        circ_self_reg.Visible = True
                        tmr_Circ_self_anim.Enabled = True

                        BW_Self_Search_Loader = True

                        Self_Column_Name_Search = "Bil_Account_Number"

                        BW_Self_Search.RunWorkerAsync()
                    End If

                ElseIf rdo_self_by_address.Checked = True Then
                    If BW_Self_Search_Loader = False Then
                        lst_Self_Reg.Items.Clear()

                        lst_Self_Reg.Visible = False
                        pan_self_controls.Enabled = False
                        circ_self_reg.Value = 0
                        circ_self_reg.Visible = True
                        tmr_Circ_self_anim.Enabled = True

                        BW_Self_Search_Loader = True

                        Self_Column_Name_Search = "Bil_Address"

                        BW_Self_Search.RunWorkerAsync()
                    End If
                ElseIf rdo_self_by_name.Checked = True Then
                    If BW_Self_Search_Loader = False Then
                        lst_Self_Reg.Items.Clear()

                        lst_Self_Reg.Visible = False
                        pan_self_controls.Enabled = False
                        circ_self_reg.Value = 0
                        circ_self_reg.Visible = True
                        tmr_Circ_self_anim.Enabled = True

                        BW_Self_Search_Loader = True

                        Self_Column_Name_Search = "Bil_Account_Name"

                        BW_Self_Search.RunWorkerAsync()
                    End If

                End If

            End If


        End If
    End Sub

    Private Sub txt_Self_Search_Term_TextChanged(sender As Object, e As EventArgs) Handles txt_Self_Search_Term.TextChanged

    End Sub


    Private Sub BW_Self_Search_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Self_Search.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        Dim Age As Integer = 0
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()

            If chk_Guest_Sanitation_Only.Checked = True Then

                sql = "SELECT COUNT(ID) AS rollcount FROM pre_reg WHERE " & Self_Column_Name_Search & " LIKE '%" & txt_Self_Search_Term.Text & "%'" _
                    & "AND (SELECT overall_reg.Sanitize_Mark FROM overall_reg WHERE " _
                    & "overall_reg.Bil_Account_Number = pre_reg.Bil_Account_Number) = 0"

            Else

                sql = "SELECT COUNT(ID) AS rollcount FROM pre_reg WHERE " & Self_Column_Name_Search & " LIKE '%" & txt_Self_Search_Term.Text & "%'"


            End If

            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()

            If chk_Guest_Sanitation_Only.Checked = True Then

                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " +
               "Contact_Number FROM pre_reg WHERE " & Self_Column_Name_Search & " LIKE '%" & txt_Self_Search_Term.Text _
               & "%' AND (SELECT overall_reg.Sanitize_Mark FROM overall_reg WHERE " _
               & "overall_reg.Bil_Account_Number = pre_reg.Bil_Account_Number) = 0 ORDER BY Bil_Account_Name ASC"

            Else

                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " +
               "Contact_Number FROM pre_reg WHERE " & Self_Column_Name_Search & " LIKE '%" & txt_Self_Search_Term.Text & "%' ORDER BY Bil_Account_Name ASC"

            End If

            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Self_Search.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Bil_Account_Number").ToString
                    newitem.SubItems.Add(drSQL("Bil_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Stub_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Address").ToString)
                    newitem.SubItems.Add(drSQL("Date_Registered").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Class").ToString)
                    newitem.SubItems.Add(drSQL("Contact_Number").ToString)
                    AddListItem_SelfReg(newitem)
                    BW_Self_Search.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Self_Search.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Self_Search_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Self_Search.ProgressChanged
        circ_self_reg.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Self_Search_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Self_Search.RunWorkerCompleted
        BW_Self_Search_Loader = False

        lst_Self_Reg.Visible = True
        pan_self_controls.Enabled = True
        circ_self_reg.Value = 0
        circ_self_reg.Visible = False
        tmr_Circ_self_anim.Enabled = False




    End Sub


    Private Sub AddListItem_Users(ByVal lstItem As ListViewItem)

        If Me.lst_users.InvokeRequired Then 'Invoke if required...

            Dim d As New SetListItem(AddressOf AddListItem_Users) 'Your delegate...

            Me.lst_users.Invoke(d, New Object() {lstItem})

        Else 'Otherwise, no invoke required...

            Me.lst_users.Items.Add(lstItem)

        End If

    End Sub

    Private Sub BW_Load_Users_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Load_Users.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM user_accounts"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try



        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()
            sql = "SELECT First_Name, Middle_Initial, Last_Name, Position, Contact_Number, Address, Username, Date_Mod FROM user_accounts ORDER BY Last_Name ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Load_Users.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Last_Name").ToString + ", " + drSQL("First_Name").ToString + " " + drSQL("Middle_Initial").ToString + ". "
                    newitem.SubItems.Add(drSQL("Position").ToString)
                    newitem.SubItems.Add(drSQL("Contact_Number").ToString)
                    newitem.SubItems.Add(drSQL("Address").ToString)
                    If drSQL("Username").ToString = "Guest " Then
                        newitem.SubItems.Add("jingG_15")
                    Else
                        newitem.SubItems.Add(drSQL("Username").ToString)
                    End If

                    newitem.SubItems.Add(drSQL("Date_Mod").ToString)

                    AddListItem_Users(newitem)
                    BW_Load_Users.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Load_Users.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Load_Users_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Load_Users.ProgressChanged
        circ_users_prog.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Load_Users_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Load_Users.RunWorkerCompleted

        BW_Users_Loader = False

        lst_users.Visible = True
        pan_users_control.Enabled = True
        circ_users_prog.Value = 0
        circ_users_prog.Visible = False
        tmr_Circ_user_anim.Enabled = False




    End Sub


    Private Sub btn_user_refresh_list_Click(sender As Object, e As EventArgs) Handles btn_user_refresh_list.Click
        lst_users.Items.Clear()

        lst_users.Visible = False
        pan_users_control.Enabled = False
        circ_users_prog.Value = 0
        circ_users_prog.Visible = True
        tmr_Circ_user_anim.Enabled = True

        Refresh_Users()
    End Sub

    Private Sub lst_users_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lst_users.ColumnClick
        Dim new_sorting_column As ColumnHeader = lst_users.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("▲ ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text =
                m_SortingColumn.Text.Substring(2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "▲ " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "▼ " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        lst_users.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        ' Sort.
        lst_users.Sort()
    End Sub

    Private Sub lst_users_DoubleClick(sender As Object, e As EventArgs) Handles lst_users.DoubleClick
        If BW_Prof_View_Loader = False Then
            BW_Prof_View_Loader = True

            Prof_Sel_Username = lst_users.Items(lst_users.FocusedItem.Index).SubItems(4).Text

            lst_users.Visible = False
            pan_users_control.Enabled = False
            circ_users_prog.Value = 0
            circ_users_prog.Visible = True
            tmr_Circ_user_anim.Enabled = True

            Users_Prof_View_Data.Clear()

            BW_Prof_Details_Fetch.RunWorkerAsync()



        End If
    End Sub

    Private Sub lst_users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_users.SelectedIndexChanged

    End Sub

    Private Sub BW_Prof_Details_Fetch_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Prof_Details_Fetch.DoWork
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
            sql = "SELECT First_Name, Middle_Initial, Last_Name, Position, Contact_Number, Address, Username, Date_Mod, " _
                + "(SELECT COUNT(*) FROM mco_reg WHERE user_accounts.Username = mco_reg.Username_reg GROUP BY user_accounts.Username) as Total_Reg FROM user_accounts WHERE Username = '" & Prof_Sel_Username & "'"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Prof_Details_Fetch.CancellationPending) Then

                    Users_Prof_View_Data.Add(drSQL("First_Name").ToString)
                    Users_Prof_View_Data.Add(drSQL("Middle_Initial").ToString)
                    Users_Prof_View_Data.Add(drSQL("Last_Name").ToString)
                    Users_Prof_View_Data.Add(drSQL("Position").ToString)
                    Users_Prof_View_Data.Add(drSQL("Contact_Number").ToString)
                    Users_Prof_View_Data.Add(drSQL("Address").ToString)
                    Users_Prof_View_Data.Add(drSQL("Username").ToString)
                    Users_Prof_View_Data.Add(drSQL("Date_Mod").ToString)
                    Users_Prof_View_Data.Add(drSQL("Total_Reg").ToString)


                    BW_Prof_Details_Fetch.ReportProgress(100)

                ElseIf (BW_Prof_Details_Fetch.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Prof_Details_Fetch_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Prof_Details_Fetch.ProgressChanged

        circ_users_prog.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Prof_Details_Fetch_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Prof_Details_Fetch.RunWorkerCompleted
        BW_Prof_View_Loader = False

        lst_users.Visible = True
        pan_users_control.Enabled = True
        circ_users_prog.Value = 0
        circ_users_prog.Visible = False
        tmr_Circ_user_anim.Enabled = False


        If Users_Prof_View_Data.Count > 0 Then

            frm_Profile_Details.txt_First_Name.Text = Users_Prof_View_Data(0)
            frm_Profile_Details.txt_Mid_Ini.Text = Users_Prof_View_Data(1)
            frm_Profile_Details.txt_Last_Name.Text = Users_Prof_View_Data(2)
            frm_Profile_Details.txt_Designation.Text = Users_Prof_View_Data(3)
            frm_Profile_Details.txt_Contact_Number.Text = Users_Prof_View_Data(4)
            frm_Profile_Details.txt_Address.Text = Users_Prof_View_Data(5)
            frm_Profile_Details.txt_Assigned_Username.Text = Users_Prof_View_Data(6)
            frm_Profile_Details.lbl_Total_reg.Text = "Total Reg: " + Users_Prof_View_Data(8)


            frm_Profile_Details.ShowDialog()




        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("No user loaded.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub


    Private Sub btn_Prof_View_Details_Click(sender As Object, e As EventArgs) Handles btn_Prof_View_Details.Click
        If BW_Prof_View_Loader = False Then
            BW_Prof_View_Loader = True

            Prof_Sel_Username = lst_users.Items(lst_users.FocusedItem.Index).SubItems(4).Text

            lst_users.Visible = False
            pan_users_control.Enabled = False
            circ_users_prog.Value = 0
            circ_users_prog.Visible = True
            tmr_Circ_user_anim.Enabled = True

            Users_Prof_View_Data.Clear()

            BW_Prof_Details_Fetch.RunWorkerAsync()



        End If
    End Sub

    Private Sub btn_user_Search_Click(sender As Object, e As EventArgs) Handles btn_user_Search.Click
        If txt_user_Search_Term.Text <> "" Then

            If rdo_user_search_by_Real_Name.Checked = True Then
                If BW_User_Search_Loader = False Then
                    lst_users.Items.Clear()

                    lst_users.Visible = False
                    pan_users_control.Enabled = False
                    circ_users_prog.Value = 0
                    circ_users_prog.Visible = True
                    tmr_Circ_user_anim.Enabled = True

                    BW_User_Search_Loader = True

                    User_Column_Name_Search = "Real Name"

                    BW_User_Search.RunWorkerAsync()
                End If

            ElseIf rdo_user_search_by_Username.Checked = True Then
                If BW_User_Search_Loader = False Then
                    lst_users.Items.Clear()

                    lst_users.Visible = False
                    pan_users_control.Enabled = False
                    circ_users_prog.Value = 0
                    circ_users_prog.Visible = True
                    tmr_Circ_user_anim.Enabled = True

                    BW_User_Search_Loader = True

                    User_Column_Name_Search = "Username"

                    BW_User_Search.RunWorkerAsync()
                End If
            ElseIf rdo_user_search_by_Address.Checked = True Then
                If BW_User_Search_Loader = False Then
                    lst_users.Items.Clear()

                    lst_users.Visible = False
                    pan_users_control.Enabled = False
                    circ_users_prog.Value = 0
                    circ_users_prog.Visible = True
                    tmr_Circ_user_anim.Enabled = True

                    BW_User_Search_Loader = True

                    User_Column_Name_Search = "Address"

                    BW_User_Search.RunWorkerAsync()
                End If
            ElseIf rdo_user_search_by_Designation.Checked = True Then
                If BW_User_Search_Loader = False Then
                    lst_users.Items.Clear()

                    lst_users.Visible = False
                    pan_users_control.Enabled = False
                    circ_users_prog.Value = 0
                    circ_users_prog.Visible = True
                    tmr_Circ_user_anim.Enabled = True

                    BW_User_Search_Loader = True

                    User_Column_Name_Search = "Position"

                    BW_User_Search.RunWorkerAsync()
                End If


            End If

        End If
    End Sub

    Private Sub BW_User_Search_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_User_Search.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()
            If User_Column_Name_Search = "Real Name" Then
                sql = "SELECT COUNT(ID) AS rollcount FROM user_accounts WHERE First_Name LIKE '%" & txt_user_Search_Term.Text & "%' OR Last_Name LIKE '%" & txt_user_Search_Term.Text & "%'"
            Else
                sql = "SELECT COUNT(ID) AS rollcount FROM user_accounts WHERE " & User_Column_Name_Search & " LIKE '%" & txt_user_Search_Term.Text & "%'"
            End If

            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()
            If User_Column_Name_Search = "Real Name" Then

                sql = "SELECT First_Name, Middle_Initial, Last_Name, Position, Contact_Number, Address, Username, Date_Mod FROM user_accounts " _
                    + "WHERE First_Name LIKE '%" & txt_user_Search_Term.Text & "%' OR Last_Name LIKE '%" & txt_user_Search_Term.Text & "%' ORDER BY Last_Name ASC"
            Else

                sql = "SELECT First_Name, Middle_Initial, Last_Name, Position, Contact_Number, Address, Username, Date_Mod FROM user_accounts " _
                    + "WHERE " & User_Column_Name_Search & " LIKE '%" & txt_user_Search_Term.Text & "%' ORDER BY Last_Name ASC"

            End If

            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_User_Search.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Last_Name").ToString + ", " + drSQL("First_Name").ToString + " " + drSQL("Middle_Initial").ToString + ". "
                    newitem.SubItems.Add(drSQL("Position").ToString)
                    newitem.SubItems.Add(drSQL("Contact_Number").ToString)
                    newitem.SubItems.Add(drSQL("Address").ToString)
                    newitem.SubItems.Add(drSQL("Username").ToString)
                    newitem.SubItems.Add(drSQL("Date_Mod").ToString)

                    AddListItem_Users(newitem)
                    BW_User_Search.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_User_Search.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_User_Search_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_User_Search.ProgressChanged
        circ_users_prog.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_User_Search_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_User_Search.RunWorkerCompleted


        lst_users.Visible = True
        pan_users_control.Enabled = True
        circ_users_prog.Value = 0
        circ_users_prog.Visible = False
        tmr_Circ_user_anim.Enabled = False

        BW_User_Search_Loader = False



    End Sub

    Private Sub txt_Mstr_Search_Term_TextChanged(sender As Object, e As EventArgs) Handles txt_Mstr_Search_Term.TextChanged

    End Sub

    Private Sub txt_user_Search_Term_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_user_Search_Term.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_user_Search_Term.Text <> "" Then

                If rdo_user_search_by_Real_Name.Checked = True Then
                    If BW_User_Search_Loader = False Then
                        lst_users.Items.Clear()

                        lst_users.Visible = False
                        pan_users_control.Enabled = False
                        circ_users_prog.Value = 0
                        circ_users_prog.Visible = True
                        tmr_Circ_user_anim.Enabled = True

                        BW_User_Search_Loader = True

                        User_Column_Name_Search = "Real Name"

                        BW_User_Search.RunWorkerAsync()
                    End If

                ElseIf rdo_user_search_by_Username.Checked = True Then
                    If BW_User_Search_Loader = False Then
                        lst_users.Items.Clear()

                        lst_users.Visible = False
                        pan_users_control.Enabled = False
                        circ_users_prog.Value = 0
                        circ_users_prog.Visible = True
                        tmr_Circ_user_anim.Enabled = True

                        BW_User_Search_Loader = True

                        User_Column_Name_Search = "Username"

                        BW_User_Search.RunWorkerAsync()
                    End If
                ElseIf rdo_user_search_by_Address.Checked = True Then
                    If BW_User_Search_Loader = False Then
                        lst_users.Items.Clear()

                        lst_users.Visible = False
                        pan_users_control.Enabled = False
                        circ_users_prog.Value = 0
                        circ_users_prog.Visible = True
                        tmr_Circ_user_anim.Enabled = True

                        BW_User_Search_Loader = True

                        User_Column_Name_Search = "Address"

                        BW_User_Search.RunWorkerAsync()
                    End If

                ElseIf rdo_user_search_by_Designation.Checked = True Then
                    If BW_User_Search_Loader = False Then
                        lst_users.Items.Clear()

                        lst_users.Visible = False
                        pan_users_control.Enabled = False
                        circ_users_prog.Value = 0
                        circ_users_prog.Visible = True
                        tmr_Circ_user_anim.Enabled = True

                        BW_User_Search_Loader = True

                        User_Column_Name_Search = "Position"

                        BW_User_Search.RunWorkerAsync()
                    End If

                End If

            End If

        End If
    End Sub

    Private Sub txt_user_Search_Term_TextChanged(sender As Object, e As EventArgs) Handles txt_user_Search_Term.TextChanged

    End Sub

    Private Sub btn_Prof_View_Reg_by_User_Click(sender As Object, e As EventArgs) Handles btn_Prof_View_Reg_by_User.Click
        Username_For_Reg_View = lst_users.Items(lst_users.FocusedItem.Index).SubItems(4).Text
        Usr_report_fullname_dialog = lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text
        frm_Registration_by_User.ShowDialog()


    End Sub

    Private Sub btn_Prof_Export_Reg_by_User_PDF_Click(sender As Object, e As EventArgs) Handles btn_Prof_Export_Reg_by_User_PDF.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog

        If lst_users.Items(lst_users.FocusedItem.Index).SubItems(1).Text.Contains("BILECO") Then

            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\AGMA2024_PDF\Per_Employee\" + lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text)
            f.RootFolder = Environment.SpecialFolder.MyComputer
            f.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\AGMA2024_PDF\Per_Employee\" + lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text

        Else
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\AGMA2024_PDF\Per_B-Empower\" + lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text)
            f.RootFolder = Environment.SpecialFolder.MyComputer
            f.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\AGMA2024_PDF\Per_B-Empower\" + lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text


        End If




        Try
            If f.ShowDialog() = DialogResult.OK Then

                Username_Sel_For_Export_PDF = lst_users.Items(lst_users.FocusedItem.Index).SubItems(4).Text
                Usr_report_fullname = lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text

                fileName_Usr_PDF = "\AGMA2024_Reg_by_" + Username_Sel_For_Export_PDF
                filepath_Usr_PDF = f.SelectedPath
                finalPath_Usr_PDF = f.SelectedPath + fileName_Usr_PDF



                lst_users.Visible = False
                pan_users_control.Enabled = False
                circ_users_prog.Value = 0
                circ_users_prog.Visible = True
                tmr_Circ_user_anim.Enabled = True

                ItemNumber_Usr_PDF = 1
                BW_PDF_Exporter_Usr.RunWorkerAsync()



            End If
        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BW_PDF_Exporter_Usr_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_PDF_Exporter_Usr.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String = ""
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim MaxPage_PDF As Double
        Dim PageNum As Integer = 0

        Dim maxItems As Integer
        Dim currItem As Integer

        Dim Saver_Counter As Integer = 0
        Dim File_Counter As Integer = 0

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        Try

            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM mco_reg WHERE Username_Reg = '" & Username_Sel_For_Export_PDF & "' ORDER BY Bil_Account_Name ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            maxItems = count
            MaxPage_PDF = count / 15


            Dim TempVal As Integer = MaxPage_PDF
            If MaxPage_PDF > TempVal Then
                MaxPage_PDF += 1
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            Else
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            End If



        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1053", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()



        End Try

        'Dim currentDate As DateTime = DateTime.Now

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim CurrenPageItems As Integer = 0
        Dim TempStr As String = ""
        Dim TempLen As Integer = 0
        Dim WidthPic As Single = 100 / 1.745
        Dim HeigthPic As Single = 100



        Dim pdf As pdf3.PdfDocument = New pdf3.PdfDocument
        pdf.Info.Title = fileName_Usr_PDF
        Dim pdfPage As pdf3.PdfPage = pdf.AddPage
        pdfPage.Size = PdfSharp.PageSize.Folio
        Dim Logo_TopLeft As pdf2.XImage
        Logo_TopLeft = Logo_PNG



        pdfPage.Width = 850
        pdfPage.Height = 1300
        pdfPage.TrimMargins.Top = 15
        pdfPage.TrimMargins.Right = 15
        pdfPage.TrimMargins.Bottom = 15
        pdfPage.TrimMargins.Left = 15


        Dim graph As pdf2.XGraphics = pdf2.XGraphics.FromPdfPage(pdfPage)
        ' Dim font As pdf2.XFont = New pdf2.XFont("Verdana", 20, pdf2.XFontStyle.Bold)
        'graph.DrawString("Sample output", font, pdf2.XBrushes.Black, New pdf2.XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), pdf2.XStringFormats.Center)

        graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

        graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

        graph.DrawString("BILECO",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

        graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

        graph.DrawString("www.bileco.net",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

        graph.DrawString("36th Annual General Membership Assembly | Registration List of " + Usr_report_fullname,
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

        graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

        graph.DrawString("Date:   August 24, 2024",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)



        'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

        'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

        'graph.DrawString("Members : " + Member_1, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

        'graph.DrawString(Member_2, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)


        graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

        graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

        'graph.DrawString("User logged in: " + Logged_Username, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

        xPos += 30

        graph.DrawString("#",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 40

        graph.DrawString("Account #",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
        xPos += 100

        graph.DrawString("Account Name",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 200

        graph.DrawString("Address",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 180

        graph.DrawString("Stub #",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 110

        graph.DrawString("Signature",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos = 0

        yPos += 290

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql = "SELECT Bil_Account_Number, Bil_Account_Name, Bil_Address, Stub_number, Signature FROM mco_reg " _
            + "WHERE Username_Reg = '" & Username_Sel_For_Export_PDF & "' ORDER BY Bil_Account_Name ASC"

        Try
            MysqlConn.Open()
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                ' If (Val(drSQL("r_id").ToString) > Last_ID_PDF_OVR) And (currItem < 75) Then
                'Last_ID_PDF_OVR = Val(drSQL("r_id").ToString)

                currItem += 1
                BW_PDF_Exporter_Usr.ReportProgress((currItem / (maxItems + 5)) * 100)
                xPos = 0
                'xIndex = 1


                xPos += 30

                graph.DrawString(ItemNumber_Usr_PDF.ToString,
                     New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                xPos += 40

                graph.DrawString(drSQL("Bil_Account_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 100
                TempStr = drSQL("Bil_Account_Name")
                TempLen = TempStr.Length
                If TempLen > 25 Then
                    TempStr = Mid(drSQL("Bil_Account_Name"), 1, 26)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Account_Name"), 27, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Account_Name")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If



                xPos += 200
                TempStr = drSQL("Bil_Address")
                TempLen = TempStr.Length
                If TempLen > 25 Then
                    TempStr = Mid(drSQL("Bil_Address"), 1, 25)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Address"), 26, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Address")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If

                'xPos += 230
                xPos += 180

                graph.DrawString(drSQL("Stub_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 90

                'If Val(drSQL("Pre_reg").ToString) = 1 Then

                '    graph.DrawString("Pre-Registered", _
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'ElseIf Val(drSQL("Pre_Reg").ToString) = 0 Then
                Using myMS As New IO.MemoryStream
                    Dim arrImage As Byte()
                    'Dim myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")

                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next

                    If CurrenPageItems Mod 2 = 1 Then
                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos - 20, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    Else
                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos + 60, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    End If

                    'Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    'graph.DrawImage(Temp_Sign, xPos - 20, yPos - 60, WidthPic, HeigthPic)
                    'Temp_Sign.Dispose()


                End Using
                ' End If



                xPos = 0
                yPos += 60
                ItemNumber_Usr_PDF += 1
                CurrenPageItems += 1

                If CurrenPageItems > 14 Then

                    CurrenPageItems = 0
                    PageNum += 1

                    graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

                    graph.DrawString("*This is an electronic-generated report. ",
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

                    Saver_Counter += 1

                    If Saver_Counter >= 10 Then
                        Saver_Counter = 0
                        File_Counter += 1

                        pdf.Save(finalPath_Usr_PDF + "(Items " + (ItemNumber_Usr_PDF - 150).ToString + " to " + (ItemNumber_Usr_PDF - 1).ToString + ").pdf")
                        pdf.Dispose()
                        graph.Graphics.Dispose()
                        graph.Internals.Graphics.Dispose()
                        graph.Dispose()


                        pdf = New pdf3.PdfDocument
                        pdf.Info.Title = fileName_Usr_PDF


                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15
                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)

                    Else
                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15

                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)


                    End If




                    '---------------------------
                    yPos = 0

                    graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

                    graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

                    graph.DrawString("BILECO",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

                    graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

                    graph.DrawString("www.bileco.net",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

                    graph.DrawString("36th Annual General Membership Assembly | Registration List of " + Usr_report_fullname,
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

                    graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

                    graph.DrawString("Date:   August 24, 2024",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)






                    'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

                    'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

                    'graph.DrawString("Members : " + Member_1, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

                    'graph.DrawString(Member_2, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)

                    graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

                    graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

                    'graph.DrawString("User logged in: " + Logged_Username, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

                    xPos += 30

                    graph.DrawString("#",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 40

                    graph.DrawString("Account #",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
                    xPos += 100

                    graph.DrawString("Account Name",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 200

                    graph.DrawString("Address",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 180

                    graph.DrawString("Stub #",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 110

                    graph.DrawString("Signature",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos = 0

                    yPos += 290


                End If


            Loop

        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1054", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        PageNum += 1
        graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

        graph.DrawString("*This is an electronic-generated report. ",
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

        If yPos < 1100 Then
            yPos += 30
        Else
            yPos -= 10
        End If



        graph.DrawString("Prepared by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Reviewed by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Checked by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Noted by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 590, yPos)


        yPos += 40

        graph.DrawString(User_Curr_Full_Name,
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        'graph.DrawString("______________________",
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Allan Joseph S. Borrinaga",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Maureen D. Nierra",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Gerardo N. Oledan, REE",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 590, yPos)

        yPos += 15

        'If Lead_Person_Printing = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Lead person", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'ElseIf (Member_1 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Or (Member_2 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Member", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'End If

        'graph.DrawString(Logged_User_Position, _
        '    New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString(User_Curr_Logged_Position.Replace("BILECO ", ""),
            New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("ISDM",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Internal Auditor",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 400, yPos)


        graph.DrawString("General Manager",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 590, yPos)

        Dim Temp_Subtractor As Integer = ItemNumber_Usr_PDF - (File_Counter * 150)
        Try
            pdf.Save(finalPath_Usr_PDF + "(Items " + (ItemNumber_Usr_PDF - Temp_Subtractor + 1).ToString + " to " + (ItemNumber_Usr_PDF - 1).ToString + ").pdf")
            pdf.Dispose()
            graph.Dispose()
            currItem += 5
            BW_PDF_Exporter_Usr.ReportProgress((currItem / (maxItems + 5)) * 100)

            DevComponents.DotNetBar.MessageBoxEx.Show("PDF Export done.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(filepath_Usr_PDF)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BW_PDF_Exporter_Usr_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_PDF_Exporter_Usr.ProgressChanged
        circ_users_prog.Value = e.ProgressPercentage
        circ_users_prog.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_PDF_Exporter_Usr_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_PDF_Exporter_Usr.RunWorkerCompleted
        lst_users.Visible = True
        pan_users_control.Enabled = True
        circ_users_prog.Value = 0
        circ_users_prog.Visible = False
        tmr_Circ_user_anim.Enabled = False



    End Sub

    Private Sub btn_Prof_Export_Reg_by_User_Excel_Click(sender As Object, e As EventArgs) Handles btn_Prof_Export_Reg_by_User_Excel.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog

        If lst_users.Items(lst_users.FocusedItem.Index).SubItems(1).Text.Contains("BILECO") Then

            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\AGMA2024_Excel\Per_Employee\" + lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text)
            f.RootFolder = Environment.SpecialFolder.MyComputer
            f.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\AGMA2024_Excel\Per_Employee\" + lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text

        Else
            System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\AGMA2024_Excel\Per_B-Empower\" + lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text)
            f.RootFolder = Environment.SpecialFolder.MyComputer
            f.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\AGMA2024_Excel\Per_B-Empower\" + lst_users.Items(lst_users.FocusedItem.Index).SubItems(0).Text


        End If


        If f.ShowDialog() = DialogResult.OK Then

            Username_Sel_For_Export_Excel = lst_users.Items(lst_users.FocusedItem.Index).SubItems(4).Text


            fileName_Excel_Usr = "\AGMA2024_Reg_By_" + Username_Sel_For_Export_Excel + ".xls"
            finalPath_Excel_Usr = f.SelectedPath + fileName_Excel_Usr


            lst_users.Visible = False
            pan_users_control.Enabled = False
            circ_users_prog.Value = 0
            circ_users_prog.Visible = True
            tmr_Circ_user_anim.Enabled = True


            BW_Export_Excel_Usr.RunWorkerAsync()

        End If
    End Sub

    Private Sub BW_Export_Excel_Usr_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Export_Excel_Usr.DoWork
        Dim rprtr As Integer = 0
        Dim dataSet As New DataSet
        ' Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        'Dim connection As New SqlClient.SqlConnection

        Dim MysqlConn1 As MySqlConnection
        Dim sql1 As String
        Dim cmd1 As MySqlCommand
        'Dim drSQL1 As MySqlDataReader
        Dim da1 As New MySqlDataAdapter

        MysqlConn1 = New MySqlConnection
        MysqlConn1.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql1 = "SELECT Bil_Account_Number As 'Account Number', Bil_Account_Name As 'Account Name', Bil_Class as 'Account Class', " +
            "Bil_Address As 'Address', Date_Registered As 'Date Registered', Stub_Number As 'Stub #', " +
            "Contact_Number As 'Contact #' FROM mco_reg WHERE Username_Reg = '" & Username_Sel_For_Export_Excel & "' ORDER BY Bil_Account_Name ASC"
        cmd1 = New MySqlCommand(sql1, MysqlConn1)

        da1.SelectCommand = cmd1

        Try

            BW_Export_Excel_Usr.ReportProgress(2)
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            'Fill data to datatable

            'connection.Open()
            MysqlConn1.Open()
            da1.Fill(datatableMain)
            MysqlConn1.Close()
            rprtr = 5
            BW_Export_Excel_Usr.ReportProgress(5)
            'Export the Columns to excel file
            For Each dc In datatableMain.Columns

                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
                rprtr = colIndex + 5
                BW_Export_Excel_Usr.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)

            Next
            oSheet.Range(oSheet.Cells(1, 1), oSheet.Cells(1, colIndex)).Font.Bold = True
            rowIndex = rowIndex + 1
            'Export the rows to excel file
            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
                rprtr = rowIndex + colIndex + 5
                BW_Export_Excel_Usr.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)
            Next

            'Set final path

            'txtPath.Text = finalPath
            oSheet.Columns.AutoFit()
            'Save file in final path
            oBook.SaveAs(finalPath_Excel_Usr, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            'Release the objects
            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            'Some time Office application does not quit after automation: 
            'so i am calling GC.Collect method.
            GC.Collect()
            BW_Export_Excel_Usr.ReportProgress(100)

            'TabMain.Enabled = True
            'TabMain.Enabled = False
            'CircVal = 0
            'CircProg.Location = New Point((Pan_Excel_Loader.Width / 2) - (Circ_Loader.Width / 2), (Pan_Excel_Loader.Height / 2) - (Circ_Loader.Height / 2))
            'Pan_Excel_Loader.Location = New Point((TabRafflePanel.Width / 2) - (Pan_Excel_Loader.Width / 2), (TabRafflePanel.Height / 2) - (Pan_Excel_Loader.Height / 2))

            DevComponents.DotNetBar.MessageBoxEx.Show("Export Successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1041", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BW_Export_Excel_Usr_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Export_Excel_Usr.ProgressChanged

        circ_users_prog.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_Export_Excel_Usr_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Export_Excel_Usr.RunWorkerCompleted


        lst_users.Visible = True
        pan_users_control.Enabled = True
        circ_users_prog.Value = 0
        circ_users_prog.Visible = False
        tmr_Circ_user_anim.Enabled = False


    End Sub



    Private Sub lbl_Total_Regs_MouseClick(sender As Object, e As MouseEventArgs) Handles lbl_Total_Regs.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbl_Total_Regs.Font = New Font(lbl_Total_Regs.Font.FontFamily, lbl_Total_Regs.Font.Size + 5, lbl_Total_Regs.Font.Style)

        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then

            If lbl_Total_Regs.Font.Size > 5 Then
                lbl_Total_Regs.Font = New Font(lbl_Total_Regs.Font.FontFamily, lbl_Total_Regs.Font.Size - 5, lbl_Total_Regs.Font.Style)

            End If



        End If
    End Sub

    Private Sub btn_Mstr_Delete_Click(sender As Object, e As EventArgs) Handles btn_Mstr_Delete.Click



        If DevComponents.DotNetBar.MessageBoxEx.Show("Delete Selected Entry?" + vbNewLine + vbNewLine _
                                                       + "Account Number: " + lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(0).Text + vbNewLine _
                                                       + "Account Name: " + lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(1).Text + vbNewLine _
                                                       + "Stub Number: " + lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(2).Text + vbNewLine _
                                                       + "Address: " + lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(3).Text + vbNewLine _
                                                       + "Date Registered: " + lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(4).Text + vbNewLine _
                                                       + "Class: " + lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(5).Text + vbNewLine _
                                                       + "Contact Number: " + lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(6).Text + vbNewLine _
                                                       + "Registrant: " + lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(7).Text,
                                                       "Notice!",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then


            Del_Selected_Reason = ""

            frm_Delete_Reason.ShowDialog()

            If Del_Selected_Reason <> "" Then


                If BW_Mstr_Delete_Flag = False Then

                    BW_Mstr_Delete_Flag = True

                    Selected_Stub_For_Del = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(2).Text
                    Selected_Stub_Registrant_Delete = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(7).Text

                    Del_Record_Account_Number = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(0).Text
                    Del_Record_Account_Name = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(1).Text
                    Del_Record_Address = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(3).Text
                    Del_Record_Class = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(5).Text
                    Del_Record_Contact_Number = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(6).Text
                    Del_Record_Stub_Number = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(2).Text
                    Del_Record_Registrant = lst_Masterlist.Items(lst_Masterlist.FocusedItem.Index).SubItems(7).Text

                    lst_Masterlist.Visible = False
                    pan_masterlist_controls.Enabled = False
                    circ_prog_masterlist.Value = 0
                    circ_prog_masterlist.Visible = True
                    tmr_Circ_masterlist_anim.Enabled = True


                    BW_Delete_Entry.RunWorkerAsync()

                End If




            End If
        End If







    End Sub

    Private Sub BW_Delete_Entry_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Delete_Entry.DoWork
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim da1 As New MySqlDataAdapter
        Dim Reason_Selected As String = Del_Selected_Reason

        MysqlConn = New MySqlConnection

        Dim phase_success As Boolean = False

        Dim arrImage_Sign As Byte()
        Dim arrImage_ID As Byte()

        Dim Sql As String
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"


        Try
            MysqlConn.Open()

            If Del_Record_Registrant = "Guest" Then

                Sql = "SELECT Signature, Photo_ID FROM pre_reg WHERE Bil_Account_Number = '" & Del_Record_Account_Number & "'"

            Else

                Sql = "SELECT Signature, Photo_ID FROM mco_reg WHERE Bil_Account_Number = '" & Del_Record_Account_Number & "'"

            End If



            cmd = New MySqlCommand(Sql, MysqlConn)
            drSQL = cmd.ExecuteReader()

            Do While drSQL.Read = True

                arrImage_Sign = drSQL("Signature")

                arrImage_ID = drSQL("Photo_ID")

                e.Result = "Goods"

            Loop

        Catch ex As Exception

            e.Result = ex.Message.ToString


        Finally


            MysqlConn.Close()


        End Try



        If e.Result = "Goods" Then


            Try

                MysqlConn.Open()

                If Del_Record_Registrant = "Guest" Then

                    Sql = "INSERT INTO delete_logs (Entry_Del_Account_Num, Entry_Del_Account_Name," _
                        & "Entry_Del_Address, Entry_Del_Class, Entry_Del_Stub_Number, Entry_Del_Contact_Number, " _
                        & "Entry_Del_Registrant, Entry_Del_Photo_ID, Entry_Del_Signature, Username, Reason) VALUES (" _
                        & "'" & Replace(Del_Record_Account_Number, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Account_Name, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Address, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Class, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Stub_Number, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Contact_Number, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Registrant, "'", "''") & "'," _
                        & "@Photo_ID_F, " _
                        & "@Sign_F, " _
                        & "'" & User_Curr_Logged & "'," _
                        & "'" & Reason_Selected & "')"

                Else

                    Sql = "INSERT INTO delete_logs (Entry_Del_Account_Num, Entry_Del_Account_Name," _
                        & "Entry_Del_Address, Entry_Del_Class, Entry_Del_Stub_Number, Entry_Del_Contact_Number, " _
                        & "Entry_Del_Registrant, Entry_Del_Photo_ID, Entry_Del_Signature, Username, Reason) VALUES (" _
                        & "'" & Replace(Del_Record_Account_Number, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Account_Name, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Address, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Class, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Stub_Number, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Contact_Number, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Registrant, "'", "''") & "'," _
                        & "@Photo_ID_F, " _
                        & "@Sign_F, " _
                        & "'" & User_Curr_Logged & "'," _
                        & "'" & Reason_Selected & "')"

                End If

                cmd.Parameters.AddWithValue("@Photo_ID_F", arrImage_ID)
                cmd.Parameters.AddWithValue("@Sign_F", arrImage_Sign)
                cmd.Connection = MysqlConn
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                e.Result = "Goods"

            Catch ex As Exception


                e.Result = ex.Message.ToString

            Finally
                MysqlConn.Close()
            End Try




        End If



        If e.Result = "Goods" Then
            Try

                MysqlConn.Open()

                Sql = "DELETE FROM overall_reg WHERE Stub_Number = '" & Selected_Stub_For_Del & "'"

                cmd.Connection = MysqlConn
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                phase_success = True
            Catch ex As Exception

                e.Result = ex.Message.ToString

            Finally
                MysqlConn.Close()
            End Try

        End If




        If phase_success = True Then
            Try

                MysqlConn.Open()

                If Selected_Stub_Registrant_Delete = "Guest" Then
                    Sql = "DELETE FROM pre_reg WHERE Stub_Number = '" & Selected_Stub_For_Del & "'"
                Else
                    Sql = "DELETE FROM mco_reg WHERE Stub_Number = '" & Selected_Stub_For_Del & "'"

                End If


                cmd.Connection = MysqlConn
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()

                e.Result = "Goods"
            Catch ex As Exception

                e.Result = ex.Message.ToString

            Finally
                MysqlConn.Close()
            End Try

        End If










    End Sub

    Private Sub BW_Delete_Entry_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Delete_Entry.ProgressChanged

    End Sub

    Private Sub BW_Delete_Entry_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Delete_Entry.RunWorkerCompleted
        If BW_Self_Delete_Flag = True Then

            BW_Self_Delete_Flag = False

        End If


        If BW_Mstr_Delete_Flag = True Then

            BW_Mstr_Delete_Flag = False

        End If




        lst_Self_Reg.Items.Clear()


        lst_Self_Reg.Visible = False
        pan_self_controls.Enabled = False
        circ_self_reg.Value = 0
        circ_self_reg.Visible = True
        tmr_Circ_self_anim.Enabled = True


        Refresh_Self_Regs()


        lst_Masterlist.Items.Clear()


        lst_Masterlist.Visible = False
        pan_masterlist_controls.Enabled = False
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = True
        tmr_Circ_masterlist_anim.Enabled = True


        Refresh_Masterlist()






        If e.Result.ToString = "Goods" Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Record Deleted!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show(e.Result.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If









    End Sub

    Private Sub btn_Self_Delete_Entry_Click(sender As Object, e As EventArgs) Handles btn_Self_Delete_Entry.Click
        Del_Selected_Reason = ""

        frm_Delete_Reason.ShowDialog()

        If Del_Selected_Reason <> "" Then
            If BW_Self_Delete_Flag = False Then
                BW_Self_Delete_Flag = True


                Selected_Stub_For_Del = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(2).Text
                Selected_Stub_Registrant_Delete = "Guest"

                Del_Record_Account_Number = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(0).Text
                Del_Record_Account_Name = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(1).Text
                Del_Record_Address = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(3).Text
                Del_Record_Class = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(5).Text
                Del_Record_Contact_Number = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(6).Text
                Del_Record_Stub_Number = lst_Self_Reg.Items(lst_Self_Reg.FocusedItem.Index).SubItems(2).Text
                Del_Record_Registrant = "Guest"

                lst_Self_Reg.Visible = False
                pan_self_controls.Enabled = False
                circ_self_reg.Value = 0
                circ_self_reg.Visible = True
                tmr_Circ_self_anim.Enabled = True


                BW_Delete_Entry.RunWorkerAsync()



            End If


        End If



    End Sub

    Private Function Correct_Account_Number(ByVal accnt As String) As String
        Dim ret_val As String = ""
        If accnt.Count = 10 Then
            ret_val = Mid(accnt, 1, 2) + "-" + Mid(accnt, 3, 6) + "-" + Mid(accnt, 7, 10)

        ElseIf accnt.Count >= 12 Then

            ret_val = accnt
        End If




        Return ret_val
    End Function



    Private Sub tmr_Circ_QR_anim_Tick(sender As Object, e As EventArgs) Handles tmr_Circ_QR_anim.Tick
        If Circ_Forward_QR = True Then
            If circ_prog_QR.Value < 100 Then

                circ_prog_QR.Value += 10
            ElseIf circ_prog_QR.Value >= 100 Then
                Circ_Forward_QR = False
                circ_prog_QR.Value -= 10
            End If
        Else
            If circ_prog_QR.Value > 0 Then

                circ_prog_QR.Value -= 10
            ElseIf circ_prog_QR.Value <= 0 Then
                Circ_Forward_QR = True
                circ_prog_QR.Value += 10
            End If
        End If
    End Sub

    Private Sub AddListItem_QR(ByVal lstItem As ListViewItem)

        If Me.lst_QR_Attendees.InvokeRequired Then 'Invoke if required...
            Dim d As New SetListItem_QR(AddressOf AddListItem_QR) 'Your delegate...
            Me.lst_QR_Attendees.Invoke(d, New Object() {lstItem})
        Else 'Otherwise, no invoke required...
            Me.lst_QR_Attendees.Items.Add(lstItem)
        End If
    End Sub


    Private Sub BW_Fill_QR_Attendance_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Fill_QR_Attendance.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM onsite_attendance"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()
            sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Date_Recorded, User_Logged, Bil_Address, Bil_Account_Class FROM onsite_attendance ORDER BY Date_Recorded ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()



            Do While drSQL.Read = True
                If Not (BW_Fill_QR_Attendance.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Stub_Number").ToString
                    newitem.SubItems.Add(drSQL("Bil_Account_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Date_Recorded").ToString)
                    newitem.SubItems.Add(drSQL("User_Logged").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Address").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Account_Class").ToString)
                    AddListItem_QR(newitem)
                    BW_Fill_QR_Attendance.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Fill_QR_Attendance.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...
    End Sub

    Private Sub BW_Fill_QR_Attendance_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Fill_QR_Attendance.ProgressChanged
        circ_prog_QR.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Fill_QR_Attendance_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Fill_QR_Attendance.RunWorkerCompleted


        BW_QR_Loader = False

        lst_QR_Attendees.Visible = True
        pan_QR_control.Enabled = True
        circ_prog_QR.Value = 0
        circ_prog_QR.Visible = False
        tmr_Circ_QR_anim.Enabled = False


    End Sub


    Private Sub btn_QR_Refresh_List_Click(sender As Object, e As EventArgs) Handles btn_QR_Refresh_List.Click
        lst_QR_Attendees.Items.Clear()

        lst_QR_Attendees.Visible = False
        pan_QR_control.Enabled = False
        circ_prog_QR.Value = 0
        circ_prog_QR.Visible = True
        tmr_Circ_QR_anim.Enabled = True
        Refresh_QR_Attendees()

    End Sub

    Private Sub btn_QR_Search_Click(sender As Object, e As EventArgs) Handles btn_QR_Search.Click
        If txt_QR_Search_Term.Text <> "" Then

            If rdo_QR_Search_by_Account_Name.Checked = True Then
                If BW_QR_Loader_Search = False Then

                    lst_QR_Attendees.Items.Clear()

                    lst_QR_Attendees.Visible = False
                    pan_QR_control.Enabled = False
                    circ_prog_QR.Value = 0
                    circ_prog_QR.Visible = True
                    tmr_Circ_QR_anim.Enabled = True

                    BW_QR_Loader_Search = True

                    QR_Column_Name_Search = "Bil_Account_Name"

                    BW_QR_Search.RunWorkerAsync()
                End If

            ElseIf rdo_QR_Search_by_Account_Number.Checked = True Then
                If BW_QR_Loader_Search = False Then

                    txt_QR_Search_Term.Text = Correct_Account_Number(txt_QR_Search_Term.Text)

                    lst_QR_Attendees.Items.Clear()

                    lst_QR_Attendees.Visible = False
                    pan_QR_control.Enabled = False
                    circ_prog_QR.Value = 0
                    circ_prog_QR.Visible = True
                    tmr_Circ_QR_anim.Enabled = True

                    BW_QR_Loader_Search = True

                    QR_Column_Name_Search = "Bil_Account_Number"

                    BW_QR_Search.RunWorkerAsync()
                End If
            End If

        End If
    End Sub

    Private Sub BW_QR_Search_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_QR_Search.DoWork

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()

            sql = "SELECT COUNT(ID) AS rollcount FROM onsite_attendance WHERE " + QR_Column_Name_Search + " LIKE '%" & txt_QR_Search_Term.Text & "%'"

            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()


            sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Date_Recorded, User_Logged, Bil_Address, Bil_Account_Class FROM onsite_attendance " _
                + "WHERE " + QR_Column_Name_Search + " LIKE '%" & txt_QR_Search_Term.Text & "%' ORDER BY Date_Recorded ASC"


            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True

                If Not (BW_QR_Search.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Stub_Number").ToString
                    newitem.SubItems.Add(drSQL("Bil_Account_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Date_Recorded").ToString)
                    newitem.SubItems.Add(drSQL("User_Logged").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Address").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Account_Class").ToString)
                    AddListItem_QR(newitem)
                    BW_QR_Search.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_QR_Search.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...


    End Sub

    Private Sub BW_QR_Search_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_QR_Search.ProgressChanged
        circ_prog_QR.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_QR_Search_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_QR_Search.RunWorkerCompleted
        lst_QR_Attendees.Visible = True
        pan_QR_control.Enabled = True
        circ_prog_QR.Value = 0
        circ_prog_QR.Visible = False
        tmr_Circ_QR_anim.Enabled = False

        BW_QR_Loader_Search = False


    End Sub

    Private Sub txt_QR_Search_Term_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_QR_Search_Term.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If txt_QR_Search_Term.Text <> "" Then

                If rdo_QR_Search_by_Account_Name.Checked = True Then
                    If BW_QR_Loader_Search = False Then

                        lst_QR_Attendees.Items.Clear()

                        lst_QR_Attendees.Visible = False
                        pan_QR_control.Enabled = False
                        circ_prog_QR.Value = 0
                        circ_prog_QR.Visible = True
                        tmr_Circ_QR_anim.Enabled = True

                        BW_QR_Loader_Search = True

                        QR_Column_Name_Search = "Bil_Account_Name"

                        BW_QR_Search.RunWorkerAsync()
                    End If

                ElseIf rdo_QR_Search_by_Account_Number.Checked = True Then
                    If BW_QR_Loader_Search = False Then

                        txt_QR_Search_Term.Text = Correct_Account_Number(txt_QR_Search_Term.Text)

                        lst_QR_Attendees.Items.Clear()

                        lst_QR_Attendees.Visible = False
                        pan_QR_control.Enabled = False
                        circ_prog_QR.Value = 0
                        circ_prog_QR.Visible = True
                        tmr_Circ_QR_anim.Enabled = True

                        BW_QR_Loader_Search = True

                        QR_Column_Name_Search = "Bil_Account_Number"

                        BW_QR_Search.RunWorkerAsync()
                    End If
                End If

            End If


        End If
    End Sub

    Private Sub txt_QR_Search_Term_TextChanged(sender As Object, e As EventArgs) Handles txt_QR_Search_Term.TextChanged

    End Sub

    Private Sub lst_QR_Attendees_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lst_QR_Attendees.ColumnClick
        Dim new_sorting_column As ColumnHeader = lst_QR_Attendees.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("▲ ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text =
                m_SortingColumn.Text.Substring(2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "▲ " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "▼ " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        lst_QR_Attendees.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        ' Sort.
        lst_QR_Attendees.Sort()
    End Sub


    Private Sub btn_QR_Export_to_Excel_Click(sender As Object, e As EventArgs) Handles btn_QR_Export_to_Excel.Click

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        If f.ShowDialog() = DialogResult.OK Then
            fileName_Excel_QR = "\AGMA2024_Onsite_Attendance.xls"
            finalPath_Excel_QR = f.SelectedPath + fileName_Excel_QR


            lst_QR_Attendees.Visible = False
            pan_QR_control.Enabled = False
            circ_prog_QR.Value = 0
            circ_prog_QR.Visible = True
            tmr_Circ_QR_anim.Enabled = True


            BW_Export_Excel_QR.RunWorkerAsync()

        End If


    End Sub

    Private Sub BW_Export_Excel_QR_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Export_Excel_QR.DoWork
        Dim rprtr As Integer = 0
        Dim dataSet As New DataSet
        ' Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        'Dim connection As New SqlClient.SqlConnection

        Dim MysqlConn1 As MySqlConnection
        Dim sql1 As String
        Dim cmd1 As MySqlCommand
        'Dim drSQL1 As MySqlDataReader
        Dim da1 As New MySqlDataAdapter

        MysqlConn1 = New MySqlConnection
        MysqlConn1.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql1 = "SELECT Bil_Account_Number As 'Account Number', Bil_Account_Name As 'Account Name', Bil_Account_Class as 'Account Class', " +
            "Bil_Address As 'Address', Date_Recorded As 'Date and Time of Attendance', Stub_Number As 'Stub #', " +
            "User_Logged As 'User Logged' FROM onsite_attendance ORDER BY Date_Recorded ASC"
        cmd1 = New MySqlCommand(sql1, MysqlConn1)

        da1.SelectCommand = cmd1

        Try

            BW_Export_Excel_QR.ReportProgress(2)
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            'Fill data to datatable

            'connection.Open()
            MysqlConn1.Open()
            da1.Fill(datatableMain)
            MysqlConn1.Close()
            rprtr = 5
            BW_Export_Excel_QR.ReportProgress(5)
            'Export the Columns to excel file
            For Each dc In datatableMain.Columns

                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
                rprtr = colIndex + 5
                BW_Export_Excel_QR.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)

            Next
            oSheet.Range(oSheet.Cells(1, 1), oSheet.Cells(1, colIndex)).Font.Bold = True
            rowIndex = rowIndex + 1
            'Export the rows to excel file
            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
                rprtr = rowIndex + colIndex + 5
                BW_Export_Excel_QR.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)
            Next

            'Set final path

            'txtPath.Text = finalPath
            oSheet.Columns.AutoFit()
            'Save file in final path
            oBook.SaveAs(finalPath_Excel_QR, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            'Release the objects
            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            'Some time Office application does not quit after automation: 
            'so i am calling GC.Collect method.
            GC.Collect()
            BW_Export_Excel_QR.ReportProgress(100)

            'TabMain.Enabled = True
            'TabMain.Enabled = False
            'CircVal = 0
            'CircProg.Location = New Point((Pan_Excel_Loader.Width / 2) - (Circ_Loader.Width / 2), (Pan_Excel_Loader.Height / 2) - (Circ_Loader.Height / 2))
            'Pan_Excel_Loader.Location = New Point((TabRafflePanel.Width / 2) - (Pan_Excel_Loader.Width / 2), (TabRafflePanel.Height / 2) - (Pan_Excel_Loader.Height / 2))

            DevComponents.DotNetBar.MessageBoxEx.Show("Export Successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1041", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BW_Export_Excel_QR_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Export_Excel_QR.ProgressChanged
        circ_prog_QR.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_Export_Excel_QR_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Export_Excel_QR.RunWorkerCompleted
        lst_QR_Attendees.Visible = True
        pan_QR_control.Enabled = True
        circ_prog_QR.Value = 0
        circ_prog_QR.Visible = False
        tmr_Circ_QR_anim.Enabled = False


    End Sub

    Private Sub btn_QR_View_Profile_Click(sender As Object, e As EventArgs) Handles btn_QR_View_Profile.Click
        If BW_QR_Load_Reg_Flag = False Then
            BW_QR_Load_Reg_Flag = True

            QR_Sel_ID = lst_QR_Attendees.Items(lst_QR_Attendees.FocusedItem.Index).SubItems(0).Text

            lst_QR_Attendees.Visible = False
            pan_QR_control.Enabled = False
            circ_prog_QR.Value = 0
            circ_prog_QR.Visible = True
            tmr_Circ_QR_anim.Enabled = True

            QR_Reg_View_Det_Data.Clear()
            image_loaded_checker_QR = False

            BW_QR_Load_Reg_Details.RunWorkerAsync()



        End If
    End Sub

    Private Sub BW_QR_Load_Reg_Details_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_QR_Load_Reg_Details.DoWork

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim arrImage As Byte()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"


        Try


            MysqlConn.Open()
            sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " _
                + "Contact_Number, Username_Reg FROM overall_reg WHERE Stub_Number = '" & QR_Sel_ID & "'"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_QR_Load_Reg_Details.CancellationPending) Then

                    QR_Reg_View_Det_Data.Add(drSQL("Bil_Account_Number").ToString)
                    QR_Reg_View_Det_Data.Add(drSQL("Bil_Account_Name").ToString)
                    QR_Reg_View_Det_Data.Add(drSQL("Stub_Number").ToString)
                    QR_Reg_View_Det_Data.Add(drSQL("Bil_Address").ToString)
                    QR_Reg_View_Det_Data.Add(drSQL("Date_Registered").ToString)
                    QR_Reg_View_Det_Data.Add(drSQL("Bil_Class").ToString)
                    QR_Reg_View_Det_Data.Add(drSQL("Contact_Number").ToString)
                    QR_Reg_View_Det_Data.Add(drSQL("Username_Reg").ToString)

                    BW_QR_Load_Reg_Details.ReportProgress(25)

                ElseIf (BW_QR_Load_Reg_Details.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...



        Try
            MysqlConn.Open()

            If QR_Reg_View_Det_Data(7).ToString = "Guest" Then

                sql = "SELECT Signature, Photo_ID FROM pre_reg WHERE Stub_Number = '" & QR_Sel_ID & "'"

            Else

                sql = "SELECT Signature, Photo_ID FROM mco_reg WHERE Stub_Number = '" & QR_Sel_ID & "'"

            End If



            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()

            Do While drSQL.Read = True

                Using myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    QR_Reg_Det_Signature = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_QR_Load_Reg_Details.ReportProgress(50)


                Using myMS As New IO.MemoryStream
                    arrImage = drSQL("Photo_ID")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    QR_Reg_Det_Photo_ID = System.Drawing.Image.FromStream(myMS)


                End Using

                BW_QR_Load_Reg_Details.ReportProgress(75)

                image_loaded_checker_QR = True
            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            image_loaded_checker_QR = False
            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1009" + vbNewLine + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally


            MysqlConn.Close()


        End Try 'Give the thread a very..very short break...

        BW_QR_Load_Reg_Details.ReportProgress(100)

    End Sub

    Private Sub BW_QR_Load_Reg_Details_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_QR_Load_Reg_Details.ProgressChanged
        circ_prog_QR.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_QR_Load_Reg_Details_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_QR_Load_Reg_Details.RunWorkerCompleted
        If image_loaded_checker_QR = True Then
            BW_QR_Load_Reg_Flag = False


            lst_QR_Attendees.Visible = True
            pan_QR_control.Enabled = True
            circ_prog_QR.Value = 0
            circ_prog_QR.Visible = False
            tmr_Circ_QR_anim.Enabled = False

            frm_Reg_Details_Master.txt_Account_Number.Text = QR_Reg_View_Det_Data(0).ToString
            frm_Reg_Details_Master.txt_Account_Name.Text = QR_Reg_View_Det_Data(1).ToString
            frm_Reg_Details_Master.txt_Stub_Number.Text = QR_Reg_View_Det_Data(2).ToString
            frm_Reg_Details_Master.txt_Address.Text = QR_Reg_View_Det_Data(3).ToString
            frm_Reg_Details_Master.txt_Date_Registered.Text = QR_Reg_View_Det_Data(4).ToString
            frm_Reg_Details_Master.txt_Account_Class.Text = QR_Reg_View_Det_Data(5).ToString
            frm_Reg_Details_Master.txt_Contact_Number.Text = QR_Reg_View_Det_Data(6).ToString
            frm_Reg_Details_Master.txt_Registered_By.Text = QR_Reg_View_Det_Data(7).ToString

            frm_Reg_Details_Master.pic_Signature.Image = QR_Reg_Det_Signature
            frm_Reg_Details_Master.pic_Signature.SizeMode = PictureBoxSizeMode.Zoom

            frm_Reg_Details_Master.pic_ID_Snapshot.Image = QR_Reg_Det_Photo_ID
            frm_Reg_Details_Master.pic_ID_Snapshot.SizeMode = PictureBoxSizeMode.Zoom

            frm_Reg_Details_Master.ShowDialog()


        End If

    End Sub

    Private Sub lst_QR_Attendees_DoubleClick(sender As Object, e As EventArgs) Handles lst_QR_Attendees.DoubleClick
        If BW_QR_Load_Reg_Flag = False Then
            BW_QR_Load_Reg_Flag = True

            QR_Sel_ID = lst_QR_Attendees.Items(lst_QR_Attendees.FocusedItem.Index).SubItems(0).Text

            lst_QR_Attendees.Visible = False
            pan_QR_control.Enabled = False
            circ_prog_QR.Value = 0
            circ_prog_QR.Visible = True
            tmr_Circ_QR_anim.Enabled = True

            QR_Reg_View_Det_Data.Clear()
            image_loaded_checker_QR = False

            BW_QR_Load_Reg_Details.RunWorkerAsync()



        End If
    End Sub

    Private Sub lst_QR_Attendees_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_QR_Attendees.SelectedIndexChanged

    End Sub

    Private Sub tmr_Totals_Updater_Area_Tick(sender As Object, e As EventArgs) Handles tmr_Totals_Updater_Area.Tick
        If BW_Get_Area_Reg_Flag = False Then
            BW_Get_Area_Reg_Flag = True
            Area_Totals.Clear()
            BW_Get_Area_Reg.RunWorkerAsync()


        End If
    End Sub

    Private Sub BW_Get_Area_Reg_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Get_Area_Reg.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand

        Dim drSQL As MySqlDataReader
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"



        Try


            MysqlConn.Open()
            sql = "SELECT Town, COUNT(ID) as TotalRegs FROM overall_reg GROUP BY Town ORDER BY TotalRegs DESC"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True

                Area_Totals.Add(drSQL("Town").ToString + "   |   " + drSQL("TotalRegs").ToString)

            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try

    End Sub

    Private Sub BW_Get_Area_Reg_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Get_Area_Reg.ProgressChanged

    End Sub

    Private Sub BW_Get_Area_Reg_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Get_Area_Reg.RunWorkerCompleted

        lbl_Total_Regs_Area.Text = ""
        If Area_Totals.Count > 1 Then
            lbl_Total_Regs_Area.Text = Area_Totals(0).ToString
            For ind As Integer = 1 To Area_Totals.Count - 1 Step 1
                lbl_Total_Regs_Area.Text = lbl_Total_Regs_Area.Text + vbNewLine + Area_Totals(ind).ToString
            Next

        ElseIf Area_Totals.Count = 1 Then
            lbl_Total_Regs_Area.Text = Area_Totals(0).ToString
        Else
            lbl_Total_Regs_Area.Text = "----"
        End If

        BW_Get_Area_Reg_Flag = False
    End Sub



    Private Sub lbl_Total_Regs_Area_Click(sender As Object, e As EventArgs) Handles lbl_Total_Regs_Area.Click

    End Sub

    Private Sub lbl_Total_Regs_Area_MouseClick(sender As Object, e As MouseEventArgs) Handles lbl_Total_Regs_Area.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbl_Total_Regs_Area.Font = New Font(lbl_Total_Regs_Area.Font.FontFamily, lbl_Total_Regs_Area.Font.Size + 5, lbl_Total_Regs_Area.Font.Style)

        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then

            If lbl_Total_Regs_Area.Font.Size > 5 Then
                lbl_Total_Regs_Area.Font = New Font(lbl_Total_Regs_Area.Font.FontFamily, lbl_Total_Regs_Area.Font.Size - 5, lbl_Total_Regs_Area.Font.Style)

            End If



        End If
    End Sub

    Private Sub btn_Self_Export_Reg_PDF_Click(sender As Object, e As EventArgs) Handles btn_Self_Export_Reg_PDF.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog

        Try
            If f.ShowDialog() = DialogResult.OK Then
                fileName_Self_PDF = "\AGMA2024_Guest_Registration"
                filepath_Self_PDF = f.SelectedPath
                finalPath_Self_PDF = f.SelectedPath + fileName_Self_PDF


                lst_Self_Reg.Visible = False
                pan_self_controls.Enabled = False
                circ_self_reg.Value = 0
                circ_self_reg.Visible = True
                tmr_Circ_self_anim.Enabled = True



                ItemNumber_Self_PDF = 1
                BW_PDF_Exporter_Self.RunWorkerAsync()




            End If
        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BW_PDF_Exporter_Self_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_PDF_Exporter_Self.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String = ""
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim MaxPage_PDF As Double
        Dim PageNum As Integer = 0

        Dim maxItems As Integer
        Dim currItem As Integer

        Dim Saver_Counter As Integer = 0
        Dim File_Counter As Integer = 0

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        Try

            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM pre_reg ORDER BY Bil_Account_Name ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            maxItems = count
            MaxPage_PDF = count / 15


            Dim TempVal As Integer = MaxPage_PDF
            If MaxPage_PDF > TempVal Then
                MaxPage_PDF += 1
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            Else
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            End If



        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1053", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()



        End Try

        'Dim currentDate As DateTime = DateTime.Now

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim CurrenPageItems As Integer = 0
        Dim TempStr As String = ""
        Dim TempLen As Integer = 0
        Dim WidthPic As Single = 100 / 1.745
        Dim HeigthPic As Single = 100



        Dim pdf As pdf3.PdfDocument = New pdf3.PdfDocument
        pdf.Info.Title = fileName_Self_PDF
        Dim pdfPage As pdf3.PdfPage = pdf.AddPage
        pdfPage.Size = PdfSharp.PageSize.Folio
        Dim Logo_TopLeft As pdf2.XImage
        Logo_TopLeft = Logo_PNG



        pdfPage.Width = 850
        pdfPage.Height = 1300
        pdfPage.TrimMargins.Top = 15
        pdfPage.TrimMargins.Right = 15
        pdfPage.TrimMargins.Bottom = 15
        pdfPage.TrimMargins.Left = 15


        Dim graph As pdf2.XGraphics = pdf2.XGraphics.FromPdfPage(pdfPage)
        ' Dim font As pdf2.XFont = New pdf2.XFont("Verdana", 20, pdf2.XFontStyle.Bold)
        'graph.DrawString("Sample output", font, pdf2.XBrushes.Black, New pdf2.XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), pdf2.XStringFormats.Center)

        graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

        graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

        graph.DrawString("BILECO",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

        graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

        graph.DrawString("www.bileco.net",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

        graph.DrawString("36th Annual General Membership Assembly | Guest Registration List",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

        graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

        graph.DrawString("Date:   August 24, 2024",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)



        'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

        'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

        'graph.DrawString("Members : " + Member_1, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

        'graph.DrawString(Member_2, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)


        graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

        graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

        'graph.DrawString("User logged in: " + Logged_Username, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

        xPos += 30

        graph.DrawString("#",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 40

        graph.DrawString("Account #",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
        xPos += 100

        graph.DrawString("Account Name",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 200

        graph.DrawString("Address",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 180

        graph.DrawString("Stub #",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 110

        graph.DrawString("Signature",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos = 0

        yPos += 290

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql = "SELECT Bil_Account_Number, Bil_Account_Name, Bil_Address, Stub_number, Signature FROM pre_reg ORDER BY Bil_Account_Name ASC"

        Try
            MysqlConn.Open()
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                ' If (Val(drSQL("r_id").ToString) > Last_ID_PDF_OVR) And (currItem < 75) Then
                'Last_ID_PDF_OVR = Val(drSQL("r_id").ToString)

                currItem += 1
                BW_PDF_Exporter_Self.ReportProgress((currItem / (maxItems + 5)) * 100)
                xPos = 0
                'xIndex = 1


                xPos += 30

                graph.DrawString(ItemNumber_Self_PDF.ToString,
                     New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                xPos += 40

                graph.DrawString(drSQL("Bil_Account_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 100
                TempStr = drSQL("Bil_Account_Name")
                TempLen = TempStr.Length
                If TempLen > 25 Then
                    TempStr = Mid(drSQL("Bil_Account_Name"), 1, 25)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Account_Name"), 26, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Account_Name")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If



                xPos += 200
                TempStr = drSQL("Bil_Address")
                TempLen = TempStr.Length
                If TempLen > 27 Then
                    TempStr = Mid(drSQL("Bil_Address"), 1, 27)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Address"), 28, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Address")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If

                'xPos += 230
                xPos += 180

                graph.DrawString(drSQL("Stub_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 90

                'If Val(drSQL("Pre_reg").ToString) = 1 Then

                '    graph.DrawString("Pre-Registered", _
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'ElseIf Val(drSQL("Pre_Reg").ToString) = 0 Then
                Using myMS As New IO.MemoryStream
                    Dim arrImage As Byte()
                    'Dim myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")

                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next

                    If CurrenPageItems Mod 2 = 1 Then
                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos - 20, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    Else
                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos + 60, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    End If

                    'Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    'graph.DrawImage(Temp_Sign, xPos - 20, yPos - 60, WidthPic, HeigthPic)
                    'Temp_Sign.Dispose()


                End Using
                ' End If



                xPos = 0
                yPos += 60
                ItemNumber_Self_PDF += 1
                CurrenPageItems += 1

                If CurrenPageItems > 14 Then

                    CurrenPageItems = 0
                    PageNum += 1

                    graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

                    graph.DrawString("*This is an electronic-generated report. ",
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

                    Saver_Counter += 1

                    If Saver_Counter >= 10 Then
                        Saver_Counter = 0
                        File_Counter += 1

                        pdf.Save(finalPath_Self_PDF + "(Items " + (ItemNumber_Self_PDF - 150).ToString + " to " + (ItemNumber_Self_PDF - 1).ToString + ").pdf")
                        pdf.Dispose()
                        graph.Graphics.Dispose()
                        graph.Internals.Graphics.Dispose()
                        graph.Dispose()


                        pdf = New pdf3.PdfDocument
                        pdf.Info.Title = fileName_Self_PDF


                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15
                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)

                    Else
                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15

                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)


                    End If




                    '---------------------------
                    yPos = 0

                    graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

                    graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

                    graph.DrawString("BILECO",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

                    graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

                    graph.DrawString("www.bileco.net",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

                    graph.DrawString("36th Annual General Membership Assembly | Guest Registration List",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

                    graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

                    graph.DrawString("Date:   August 24, 2024",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)






                    'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

                    'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

                    'graph.DrawString("Members : " + Member_1, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

                    'graph.DrawString(Member_2, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)

                    graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

                    graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

                    'graph.DrawString("User logged in: " + Logged_Username, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

                    xPos += 30

                    graph.DrawString("#",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 40

                    graph.DrawString("Account #",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
                    xPos += 100

                    graph.DrawString("Account Name",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 200

                    graph.DrawString("Address",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 180

                    graph.DrawString("Stub #",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 110

                    graph.DrawString("Signature",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos = 0

                    yPos += 290


                End If


            Loop

        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1054", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        PageNum += 1
        graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

        graph.DrawString("*This is an electronic-generated report. ",
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

        If yPos < 1100 Then
            yPos += 30
        Else
            yPos -= 10
        End If



        graph.DrawString("Prepared by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Reviewed by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Checked by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Noted by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 590, yPos)


        yPos += 40

        graph.DrawString(User_Curr_Full_Name,
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        'graph.DrawString("______________________",
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Allan Joseph S. Borrinaga",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Maureen D. Nierra",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Gerardo N. Oledan, REE",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 590, yPos)

        yPos += 15

        'If Lead_Person_Printing = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Lead person", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'ElseIf (Member_1 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Or (Member_2 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Member", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'End If

        'graph.DrawString(Logged_User_Position, _
        '    New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString(User_Curr_Logged_Position.Replace("BILECO ", ""),
            New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("ISDM",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Internal Auditor",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 400, yPos)


        graph.DrawString("General Manager",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 590, yPos)

        Dim Temp_Subtractor As Integer = ItemNumber_Self_PDF - (File_Counter * 150)
        Try
            pdf.Save(finalPath_Self_PDF + "(Items " + (ItemNumber_Self_PDF - Temp_Subtractor + 1).ToString + " to " + (ItemNumber_Self_PDF - 1).ToString + ").pdf")
            pdf.Dispose()
            graph.Dispose()
            currItem += 5
            BW_PDF_Exporter_Self.ReportProgress((currItem / (maxItems + 5)) * 100)

            DevComponents.DotNetBar.MessageBoxEx.Show("PDF Export done.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(filepath_Self_PDF)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BW_PDF_Exporter_Self_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_PDF_Exporter_Self.ProgressChanged
        circ_self_reg.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_PDF_Exporter_Self_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_PDF_Exporter_Self.RunWorkerCompleted


        lst_Self_Reg.Visible = True
        pan_self_controls.Enabled = True
        circ_self_reg.Value = 0
        circ_self_reg.Visible = False
        tmr_Circ_self_anim.Enabled = False

    End Sub

    Private Sub btn_Self_Export_Reg_Excel_Click(sender As Object, e As EventArgs) Handles btn_Self_Export_Reg_Excel.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        If f.ShowDialog() = DialogResult.OK Then
            fileName_Excel_Self = "\AGMA2024_Masterlist.xls"
            finalPath_Excel_Self = f.SelectedPath + fileName_Excel_Self


            lst_Self_Reg.Visible = False
            pan_self_controls.Enabled = False
            circ_self_reg.Value = 0
            circ_self_reg.Visible = True
            tmr_Circ_self_anim.Enabled = True


            BW_Export_Excel_Self.RunWorkerAsync()

        End If
    End Sub

    Private Sub BW_Export_Excel_Self_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Export_Excel_Self.DoWork
        Dim rprtr As Integer = 0
        Dim dataSet As New DataSet
        ' Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        'Dim connection As New SqlClient.SqlConnection

        Dim MysqlConn1 As MySqlConnection
        Dim sql1 As String
        Dim cmd1 As MySqlCommand
        'Dim drSQL1 As MySqlDataReader
        Dim da1 As New MySqlDataAdapter

        MysqlConn1 = New MySqlConnection
        MysqlConn1.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024"

        sql1 = "SELECT Bil_Account_Number As 'Account Number', Bil_Account_Name As 'Account Name', Bil_Class as 'Account Class', " +
            "Bil_Address As 'Address', Date_Registered As 'Date Registered', Stub_Number As 'Stub #', " +
            "Contact_Number As 'Contact #' FROM pre_reg ORDER BY Bil_Account_Name ASC"
        cmd1 = New MySqlCommand(sql1, MysqlConn1)

        da1.SelectCommand = cmd1

        Try

            BW_Export_Excel_Self.ReportProgress(2)
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            'Fill data to datatable

            'connection.Open()
            MysqlConn1.Open()
            da1.Fill(datatableMain)
            MysqlConn1.Close()
            rprtr = 5
            BW_Export_Excel_Self.ReportProgress(5)
            'Export the Columns to excel file
            For Each dc In datatableMain.Columns

                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
                rprtr = colIndex + 5
                BW_Export_Excel_Self.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)

            Next
            oSheet.Range(oSheet.Cells(1, 1), oSheet.Cells(1, colIndex)).Font.Bold = True
            rowIndex = rowIndex + 1
            'Export the rows to excel file
            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
                rprtr = rowIndex + colIndex + 5
                BW_Export_Excel_Self.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)
            Next

            'Set final path

            'txtPath.Text = finalPath
            oSheet.Columns.AutoFit()
            'Save file in final path
            oBook.SaveAs(finalPath_Excel_Self, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            'Release the objects
            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            'Some time Office application does not quit after automation: 
            'so i am calling GC.Collect method.
            GC.Collect()
            BW_Export_Excel_Self.ReportProgress(100)

            'TabMain.Enabled = True
            'TabMain.Enabled = False
            'CircVal = 0
            'CircProg.Location = New Point((Pan_Excel_Loader.Width / 2) - (Circ_Loader.Width / 2), (Pan_Excel_Loader.Height / 2) - (Circ_Loader.Height / 2))
            'Pan_Excel_Loader.Location = New Point((TabRafflePanel.Width / 2) - (Pan_Excel_Loader.Width / 2), (TabRafflePanel.Height / 2) - (Pan_Excel_Loader.Height / 2))

            DevComponents.DotNetBar.MessageBoxEx.Show("Export Successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1041", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BW_Export_Excel_Self_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Export_Excel_Self.ProgressChanged
        circ_self_reg.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_Export_Excel_Self_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Export_Excel_Self.RunWorkerCompleted
        lst_Self_Reg.Visible = True
        pan_self_controls.Enabled = True
        circ_self_reg.Value = 0
        circ_self_reg.Visible = False
        tmr_Circ_self_anim.Enabled = False




    End Sub

    Private Sub lst_Self_Reg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Self_Reg.SelectedIndexChanged

    End Sub

    Private Sub tmr_Circ_user_anim_Tick(sender As Object, e As EventArgs) Handles tmr_Circ_user_anim.Tick
        If Circ_Forward_Usr = True Then
            If circ_users_prog.Value < 100 Then

                circ_users_prog.Value += 10
            ElseIf circ_users_prog.Value >= 100 Then
                Circ_Forward_Usr = False
                circ_users_prog.Value -= 10
            End If
        Else
            If circ_users_prog.Value > 0 Then

                circ_users_prog.Value -= 10
            ElseIf circ_users_prog.Value <= 0 Then
                Circ_Forward_Usr = True
                circ_users_prog.Value += 10
            End If
        End If
    End Sub

    Private Sub SideNavItem9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tmr_Circ_del_anim_Tick(sender As Object, e As EventArgs) Handles tmr_Circ_del_anim.Tick


        If Circ_Forward_Del_Logs = True Then
            If circ_del_prog.Value < 100 Then

                circ_del_prog.Value += 10
            ElseIf circ_del_prog.Value >= 100 Then
                Circ_Forward_Del_Logs = False
                circ_del_prog.Value -= 10
            End If
        Else
            If circ_del_prog.Value > 0 Then

                circ_del_prog.Value -= 10
            ElseIf circ_del_prog.Value <= 0 Then
                Circ_Forward_Del_Logs = True
                circ_del_prog.Value += 10
            End If
        End If


    End Sub

    Private Sub AddListItem_del_logs(ByVal lstItem As ListViewItem)

        If Me.lst_del_logs.InvokeRequired Then 'Invoke if required...
            Dim d As New SetListItem_del_logs(AddressOf AddListItem_del_logs) 'Your delegate...
            Me.lst_del_logs.Invoke(d, New Object() {lstItem})
        Else 'Otherwise, no invoke required...
            Me.lst_del_logs.Items.Add(lstItem)
        End If
    End Sub


    Private Sub BW_Load_Del_Logs_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Load_Del_Logs.DoWork


        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM delete_logs"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()
            sql = "SELECT ID, Entry_Del_Stub_Number, Entry_Del_Account_Num, Entry_Del_Account_Name, Entry_Del_Address, Entry_Del_Contact_Number, " _
                & "Entry_Del_Class, Username, Entry_Del_Registrant, Date_Del, Reason FROM delete_logs ORDER BY ID ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Load_Del_Logs.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("ID").ToString
                    newitem.SubItems.Add(drSQL("Entry_Del_Stub_Number").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Account_Num").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Address").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Contact_Number").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Class").ToString)
                    newitem.SubItems.Add(drSQL("Username").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Registrant").ToString)
                    newitem.SubItems.Add(drSQL("Date_Del").ToString)
                    newitem.SubItems.Add(drSQL("Reason").ToString)


                    AddListItem_del_logs(newitem)
                    BW_Load_Del_Logs.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Load_Del_Logs.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...











    End Sub

    Private Sub BW_Load_Del_Logs_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_Load_Del_Logs.ProgressChanged
        circ_del_prog.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Load_Del_Logs_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_Load_Del_Logs.RunWorkerCompleted


        BW_Del_Logs_Loader = False

        lst_del_logs.Visible = True
        pan_del_logs_control.Enabled = True
        circ_del_prog.Value = 0
        circ_del_prog.Visible = False
        tmr_Circ_del_anim.Enabled = False
    End Sub

    Private Sub btn_View_Del_Prof_Click(sender As Object, e As EventArgs) Handles btn_View_Del_Prof.Click
        If BW_Del_Load_Reg_Flag = False Then
            BW_Del_Load_Reg_Flag = True

            Del_Sel_ID = lst_del_logs.Items(lst_del_logs.FocusedItem.Index).SubItems(0).Text

            lst_del_logs.Visible = False
            pan_del_logs_control.Enabled = False
            circ_del_prog.Value = 0
            circ_del_prog.Visible = True
            tmr_Circ_del_anim.Enabled = True

            Del_Logs_View_Det_Data.Clear()
            del_image_loaded_checker = False

            BW_Del_Load_Reg_Details.RunWorkerAsync()



        End If
    End Sub

    Private Sub BW_Del_Load_Reg_Details_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_Del_Load_Reg_Details.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim arrImage As Byte()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"


        Try


            MysqlConn.Open()
            sql = "SELECT Entry_Del_Stub_Number, Entry_Del_Account_Name, Entry_Del_Account_Num, Entry_Del_Class, Date_Del, " _
                & "Entry_Del_Contact_Number, Entry_Del_Registrant, Username, Entry_Del_Address FROM delete_logs WHERE ID = '" _
                & Del_Sel_ID & "'"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Del_Load_Reg_Details.CancellationPending) Then

                    Del_Logs_View_Det_Data.Add(drSQL("Entry_Del_Account_Num").ToString)
                    Del_Logs_View_Det_Data.Add(drSQL("Entry_Del_Account_Name").ToString)
                    Del_Logs_View_Det_Data.Add(drSQL("Entry_Del_Stub_Number").ToString)
                    Del_Logs_View_Det_Data.Add(drSQL("Entry_Del_Address").ToString)
                    Del_Logs_View_Det_Data.Add(drSQL("Date_Del").ToString)
                    Del_Logs_View_Det_Data.Add(drSQL("Entry_Del_Class").ToString)
                    Del_Logs_View_Det_Data.Add(drSQL("Entry_Del_Contact_Number").ToString)
                    Del_Logs_View_Det_Data.Add(drSQL("Entry_Del_Registrant").ToString)
                    Del_Logs_View_Det_Data.Add(drSQL("Username").ToString)


                    BW_Del_Load_Reg_Details.ReportProgress(25)

                ElseIf (BW_Del_Load_Reg_Details.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...



        Try
            MysqlConn.Open()

            sql = "SELECT Entry_Del_Signature, Entry_Del_Photo_ID FROM delete_logs WHERE ID = '" & Del_Sel_ID & "'"

            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()

            Do While drSQL.Read = True

                Using myMS As New IO.MemoryStream
                    arrImage = drSQL("Entry_Del_Signature")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Del_Logs_Det_Signature = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_Del_Load_Reg_Details.ReportProgress(50)


                Using myMS As New IO.MemoryStream
                    arrImage = drSQL("Entry_Del_Photo_ID")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Del_Logs_Det_Photo_ID = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_Del_Load_Reg_Details.ReportProgress(75)

                del_image_loaded_checker = True
            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            del_image_loaded_checker = False
            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1009" + vbNewLine + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally


            MysqlConn.Close()


        End Try 'Give the thread a very..very short break...

        BW_Del_Load_Reg_Details.ReportProgress(100)
    End Sub

    Private Sub BW_Del_Load_Reg_Details_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_Del_Load_Reg_Details.ProgressChanged
        circ_del_prog.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Del_Load_Reg_Details_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_Del_Load_Reg_Details.RunWorkerCompleted

        If del_image_loaded_checker = True Then
            BW_Del_Load_Reg_Flag = False


            lst_del_logs.Visible = True
            pan_del_logs_control.Enabled = True
            circ_del_prog.Value = 0
            circ_del_prog.Visible = False
            tmr_Circ_del_anim.Enabled = False


            frm_Deleted_Reg_Viewer.txt_Account_Number.Text = Del_Logs_View_Det_Data(0).ToString
            frm_Deleted_Reg_Viewer.txt_Account_Name.Text = Del_Logs_View_Det_Data(1).ToString
            frm_Deleted_Reg_Viewer.txt_Stub_Number.Text = Del_Logs_View_Det_Data(2).ToString
            frm_Deleted_Reg_Viewer.txt_Address.Text = Del_Logs_View_Det_Data(3).ToString
            frm_Deleted_Reg_Viewer.txt_Date_Deleted.Text = Del_Logs_View_Det_Data(4).ToString
            frm_Deleted_Reg_Viewer.txt_Account_Class.Text = Del_Logs_View_Det_Data(5).ToString
            frm_Deleted_Reg_Viewer.txt_Contact_Number.Text = Del_Logs_View_Det_Data(6).ToString
            frm_Deleted_Reg_Viewer.txt_Registered_By.Text = Del_Logs_View_Det_Data(7).ToString
            frm_Deleted_Reg_Viewer.txt_Deleted_by.Text = Del_Logs_View_Det_Data(8).ToString


            frm_Deleted_Reg_Viewer.pic_Signature.Image = Del_Logs_Det_Signature
            frm_Deleted_Reg_Viewer.pic_Signature.SizeMode = PictureBoxSizeMode.Zoom

            frm_Deleted_Reg_Viewer.pic_ID_Snapshot.Image = Del_Logs_Det_Photo_ID
            frm_Deleted_Reg_Viewer.pic_ID_Snapshot.SizeMode = PictureBoxSizeMode.Zoom

            frm_Deleted_Reg_Viewer.ShowDialog()


        End If

    End Sub



    Private Sub lst_del_logs_DoubleClick(sender As Object, e As EventArgs) Handles lst_del_logs.DoubleClick
        If BW_Del_Load_Reg_Flag = False Then
            BW_Del_Load_Reg_Flag = True

            Del_Sel_ID = lst_del_logs.Items(lst_del_logs.FocusedItem.Index).SubItems(0).Text

            lst_del_logs.Visible = False
            pan_del_logs_control.Enabled = False
            circ_del_prog.Value = 0
            circ_del_prog.Visible = True
            tmr_Circ_del_anim.Enabled = True

            Del_Logs_View_Det_Data.Clear()
            del_image_loaded_checker = False

            BW_Del_Load_Reg_Details.RunWorkerAsync()



        End If
    End Sub

    Private Sub btn_Export_Del_Logs_Click(sender As Object, e As EventArgs) Handles btn_Export_Del_Logs.Click

        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        If f.ShowDialog() = DialogResult.OK Then
            fileName_Excel_Del = "\AGMA2024_Del_Logs.xls"
            finalPath_Excel_Del = f.SelectedPath + fileName_Excel_Del


            lst_del_logs.Visible = False
            pan_del_logs_control.Enabled = False
            circ_del_prog.Value = 0
            circ_del_prog.Visible = True
            tmr_Circ_del_anim.Enabled = True


            BW_Export_Excel_Del_Logs.RunWorkerAsync()

        End If




    End Sub

    Private Sub BW_Export_Excel_Del_Logs_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_Export_Excel_Del_Logs.DoWork
        Dim rprtr As Integer = 0
        Dim dataSet As New DataSet
        ' Dim command As New SqlClient.SqlCommand
        Dim datatableMain As New System.Data.DataTable()
        'Dim connection As New SqlClient.SqlConnection

        Dim MysqlConn1 As MySqlConnection
        Dim sql1 As String
        Dim cmd1 As MySqlCommand
        'Dim drSQL1 As MySqlDataReader
        Dim da1 As New MySqlDataAdapter

        MysqlConn1 = New MySqlConnection
        MysqlConn1.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024"

        sql1 = "SELECT Entry_Del_Account_Num As 'Deleted Account Number', Entry_Del_Account_Name As 'Deleted Account Name', " _
                & "Entry_Del_Address as 'Address', Entry_Del_Class as 'Class', Entry_Del_Contact_Number as 'Contact Number', " _
                & "Entry_Del_Stub_Number as 'Generated Stub Number', Entry_Del_Registrant as 'Registered by', " _
                & "Username as 'Deleted by', Date_Del as 'Date of Deletion', Reason as 'Reason of Invalidity' FROM delete_logs ORDER BY Date_Del ASC"
        cmd1 = New MySqlCommand(sql1, MysqlConn1)

        da1.SelectCommand = cmd1

        Try

            BW_Export_Excel_Del_Logs.ReportProgress(2)
            Dim oExcel As Excel.Application
            Dim oBook As Excel.Workbook
            Dim oSheet As Excel.Worksheet
            oExcel = CreateObject("Excel.Application")
            oBook = oExcel.Workbooks.Add(Type.Missing)
            oSheet = oBook.Worksheets(1)

            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            'Fill data to datatable

            'connection.Open()
            MysqlConn1.Open()
            da1.Fill(datatableMain)
            MysqlConn1.Close()
            rprtr = 5
            BW_Export_Excel_Del_Logs.ReportProgress(5)
            'Export the Columns to excel file
            For Each dc In datatableMain.Columns

                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
                rprtr = colIndex + 5
                BW_Export_Excel_Del_Logs.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)

            Next
            oSheet.Range(oSheet.Cells(1, 1), oSheet.Cells(1, colIndex)).Font.Bold = True
            rowIndex = rowIndex + 1
            'Export the rows to excel file
            For Each dr In datatableMain.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In datatableMain.Columns
                    colIndex = colIndex + 1
                    oSheet.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
                rprtr = rowIndex + colIndex + 5
                BW_Export_Excel_Del_Logs.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)
            Next

            'Set final path

            'txtPath.Text = finalPath
            oSheet.Columns.AutoFit()
            'Save file in final path
            oBook.SaveAs(finalPath_Excel_Del, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing)

            'Release the objects
            ReleaseObject(oSheet)
            oBook.Close(False, Type.Missing, Type.Missing)
            ReleaseObject(oBook)
            oExcel.Quit()
            ReleaseObject(oExcel)
            'Some time Office application does not quit after automation: 
            'so i am calling GC.Collect method.
            GC.Collect()
            BW_Export_Excel_Del_Logs.ReportProgress(100)

            'TabMain.Enabled = True
            'TabMain.Enabled = False
            'CircVal = 0
            'CircProg.Location = New Point((Pan_Excel_Loader.Width / 2) - (Circ_Loader.Width / 2), (Pan_Excel_Loader.Height / 2) - (Circ_Loader.Height / 2))
            'Pan_Excel_Loader.Location = New Point((TabRafflePanel.Width / 2) - (Pan_Excel_Loader.Width / 2), (TabRafflePanel.Height / 2) - (Pan_Excel_Loader.Height / 2))

            DevComponents.DotNetBar.MessageBoxEx.Show("Export Successfull!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK)

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1041", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub

    Private Sub BW_Export_Excel_Del_Logs_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_Export_Excel_Del_Logs.ProgressChanged

        circ_del_prog.ProgressText = e.ProgressPercentage.ToString + " %"

    End Sub

    Private Sub BW_Export_Excel_Del_Logs_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_Export_Excel_Del_Logs.RunWorkerCompleted


        lst_del_logs.Visible = True
        pan_del_logs_control.Enabled = True
        circ_del_prog.Value = 0
        circ_del_prog.Visible = False
        tmr_Circ_del_anim.Enabled = False



    End Sub

    Private Sub btn_del_Search_Click(sender As Object, e As EventArgs) Handles btn_del_Search.Click
        If txt_del_Search_Term.Text <> "" Then

            If rdo_del_Search_by_Account_Num.Checked = True Then
                If BW_Del_Search_Loader = False Then

                    lst_del_logs.Items.Clear()

                    lst_del_logs.Visible = False
                    pan_del_logs_control.Enabled = False
                    circ_del_prog.Value = 0
                    circ_del_prog.Visible = True
                    tmr_Circ_del_anim.Enabled = True

                    BW_Del_Search_Loader = True

                    Del_Column_Name_Search = "Entry_Del_Account_Num"

                    BW_Del_Logs_Search.RunWorkerAsync()
                End If

            ElseIf rdo_del_Search_by_Account_Name.Checked = True Then
                If BW_Del_Search_Loader = False Then
                    lst_del_logs.Items.Clear()

                    lst_del_logs.Visible = False
                    pan_del_logs_control.Enabled = False
                    circ_del_prog.Value = 0
                    circ_del_prog.Visible = True
                    tmr_Circ_del_anim.Enabled = True

                    BW_Del_Search_Loader = True

                    Del_Column_Name_Search = "Entry_Del_Account_Name"

                    BW_Del_Logs_Search.RunWorkerAsync()
                End If
            ElseIf rdo_del_Search_by_Reg_Username.Checked = True Then
                If BW_Del_Search_Loader = False Then
                    lst_del_logs.Items.Clear()

                    lst_del_logs.Visible = False
                    pan_del_logs_control.Enabled = False
                    circ_del_prog.Value = 0
                    circ_del_prog.Visible = True
                    tmr_Circ_del_anim.Enabled = True

                    BW_Del_Search_Loader = True

                    Del_Column_Name_Search = "Entry_Del_Registrant"

                    BW_Del_Logs_Search.RunWorkerAsync()
                End If
            ElseIf rdo_del_Search_by_Del_Username.Checked = True Then
                If BW_Del_Search_Loader = False Then
                    lst_del_logs.Items.Clear()

                    lst_del_logs.Visible = False
                    pan_del_logs_control.Enabled = False
                    circ_del_prog.Value = 0
                    circ_del_prog.Visible = True
                    tmr_Circ_del_anim.Enabled = True

                    BW_Del_Search_Loader = True

                    Del_Column_Name_Search = "Username"

                    BW_Del_Logs_Search.RunWorkerAsync()
                End If
            End If

        End If

    End Sub

    Private Sub btn_del_Refresh_Click(sender As Object, e As EventArgs) Handles btn_del_Refresh.Click
        lst_del_logs.Items.Clear()

        lst_del_logs.Visible = False
        pan_del_logs_control.Enabled = False
        circ_del_prog.Value = 0
        circ_del_prog.Visible = True
        tmr_Circ_del_anim.Enabled = True
        Refresh_Del_Logs()
    End Sub

    Private Sub BW_Del_Logs_Search_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_Del_Logs_Search.DoWork


        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM delete_logs WHERE " & Del_Column_Name_Search & " LIKE '%" & txt_del_Search_Term.Text & "%'"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()
            sql = "SELECT ID, Entry_Del_Stub_Number, Entry_Del_Account_Num, Entry_Del_Account_Name, Entry_Del_Address, Entry_Del_Contact_Number, " _
                & "Entry_Del_Class, Username, Entry_Del_Registrant, Date_Del, Reason FROM delete_logs WHERE " & Del_Column_Name_Search & " LIKE '%" _
                & txt_del_Search_Term.Text & "%' ORDER BY Date_Del ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Del_Logs_Search.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("ID").ToString
                    newitem.SubItems.Add(drSQL("Entry_Del_Stub_Number").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Account_Num").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Address").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Contact_Number").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Class").ToString)
                    newitem.SubItems.Add(drSQL("Username").ToString)
                    newitem.SubItems.Add(drSQL("Entry_Del_Registrant").ToString)
                    newitem.SubItems.Add(drSQL("Date_Del").ToString)
                    newitem.SubItems.Add(drSQL("Reason").ToString)


                    AddListItem_del_logs(newitem)
                    BW_Del_Logs_Search.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Del_Logs_Search.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...


    End Sub

    Private Sub BW_Del_Logs_Search_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_Del_Logs_Search.ProgressChanged

        circ_del_prog.ProgressText = e.ProgressPercentage.ToString + "%"


    End Sub

    Private Sub BW_Del_Logs_Search_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_Del_Logs_Search.RunWorkerCompleted


        BW_Del_Search_Loader = False

        lst_del_logs.Visible = True
        pan_del_logs_control.Enabled = True
        circ_del_prog.Value = 0
        circ_del_prog.Visible = False
        tmr_Circ_del_anim.Enabled = False


    End Sub

    Private Sub circ_prog_overall_ValueChanged(sender As Object, e As EventArgs) Handles circ_prog_overall.ValueChanged

    End Sub

    Private Sub btn_Add_New_User_Click(sender As Object, e As EventArgs) Handles btn_Add_New_User.Click
        If User_Curr_Logged_Position.Contains("IT Staff") Or
            User_Curr_Logged_Position.Contains("IT Programmer") Or
            User_Curr_Logged_Position.Contains("System Administrator") Then


            frm_User_Account_Enrollment.ShowDialog()


        Else

            DevComponents.DotNetBar.MessageBoxEx.Show("You do not have permission to add new users. Please contact the IT Division for user enrollment. Thank you.", "Stop!", MessageBoxButtons.OK, MessageBoxIcon.Stop)


        End If
    End Sub

    Private Sub lst_del_logs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_del_logs.SelectedIndexChanged

    End Sub

    Public Sub Change_SMS_Port_Baud(ByVal Port As String, ByVal Baud As String)

        SMSEngine.ChangePort_Baudrate(Port, Val(Baud))

    End Sub

    Private Sub frm_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            SMSEngine.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Send_Sanitation_SMS_Click(sender As Object, e As EventArgs) Handles btn_Send_Sanitation_SMS.Click
        frm_SMS_Console_View.Show()
    End Sub


    Private Sub BW_SMS_Marker_Updater_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_SMS_Marker_Updater.DoWork

        Dim cmd1 As New MySqlCommand
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        'Dim cmd As MySqlCommand
        'Dim drSQL As MySqlDataReader
        'Dim da As New MySqlDataAdapter
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try

            MysqlConn.Open()
            sql = "UPDATE delete_logs SET SMS_Sent = 1 Where ID = '" & Update_SMS_Marker(0) & "'"
            cmd1.Connection = MysqlConn
            cmd1.CommandText = sql
            cmd1.ExecuteNonQuery()
            Update_SMS_Marker.RemoveAt(0)
        Catch ex As Exception

            MysqlConn.Close()
            Exit Sub
        Finally
            MysqlConn.Close()
        End Try


    End Sub

    Private Sub BW_SMS_Marker_Updater_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_SMS_Marker_Updater.ProgressChanged

    End Sub

    Private Sub BW_SMS_Marker_Updater_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_SMS_Marker_Updater.RunWorkerCompleted

    End Sub

    Private Sub tmr_SMS_Done_Updater_Tick(sender As Object, e As EventArgs) Handles tmr_SMS_Done_Updater.Tick
        If BW_SMS_Marker_Updater.IsBusy = False And Update_SMS_Marker.Count > 0 Then


            BW_SMS_Marker_Updater.RunWorkerAsync()

        End If
    End Sub

    Private Sub tmr_Entries_Loader_Tick(sender As Object, e As EventArgs) Handles tmr_Entries_Loader.Tick
        If BW_del_logs_laoder.IsBusy = False Then

            BW_del_logs_laoder.RunWorkerAsync()

        End If
    End Sub

    Private Sub BW_del_logs_laoder_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_del_logs_laoder.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
        Try
            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM delete_logs WHERE SMS_Sent = 0"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count

        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try


        Try

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"
            MysqlConn.Open()
            sql = "SELECT ID, Entry_Del_Stub_Number, Entry_Del_Account_Num, Entry_Del_Account_Name, Entry_Del_Contact_Number, " _
                & "Reason FROM delete_logs WHERE SMS_Sent = 0 ORDER BY Date_Del ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_del_logs_laoder.CancellationPending) Then
                    Dim db_id As Integer = drSQL("ID").ToString
                    Dim resss = drSQL("Reason").ToString
                    Dim stub = drSQL("Entry_Del_Stub_Number").ToString
                    Dim account_num = drSQL("Entry_Del_Account_Num").ToString
                    Dim account_name = drSQL("Entry_Del_Account_Name").ToString
                    Dim cell_num = drSQL("Entry_Del_Contact_Number").ToString



                    If cell_num <> "NONE" And cell_num.Length = 11 And cell_num.Contains(" ") = False Then
                        If cell_num.Substring(0, 2) = "09" Then


                            cell_num = "+63" + cell_num.Substring(1, 10)


                        End If


                        If resss = "Invalid Signature upon visual verification and Invalid photo of ID Provided" Then


                            Notif_Message = "Hello. Your BILECO AGMA registration is INVALID for the Account " & account_num &
                                             " with Stub " & stub & ". Reason: INVALID Signature & ID. Please try again. TY."

                            SMSEngine.Add_Queue(db_id, cell_num, account_num + " : " + account_name, Notif_Message)


                        ElseIf resss = "Invalid photo of ID Provided" Then


                            Notif_Message = "Hello. Your BILECO AGMA registration is INVALID for the Account " & account_num &
                                             " with Stub " & stub & ". Reason: INVALID ID Provided. Please try again. TY."


                            SMSEngine.Add_Queue(db_id, cell_num, account_num + " : " + account_name, Notif_Message)


                        ElseIf resss = "Invalid Signature upon visual verification" Then


                            Notif_Message = "Hello. Your BILECO AGMA registration is INVALID for the Account " & account_num &
                                             " with Stub " & stub & ". Reason: INVALID Signature Provided. Please try again. TY."


                            SMSEngine.Add_Queue(db_id, cell_num, account_num + " : " + account_name, Notif_Message)


                        End If

                    End If



                    BW_del_logs_laoder.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1


                ElseIf (BW_del_logs_laoder.CancellationPending) Then
                    e.Cancel = True
                    Exit Do
                End If


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...


    End Sub

    Private Sub BW_del_logs_laoder_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_del_logs_laoder.ProgressChanged

    End Sub

    Private Sub BW_del_logs_laoder_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_del_logs_laoder.RunWorkerCompleted

    End Sub

    Private Sub btnitm_Export_Audit_Report_Click(sender As Object, e As EventArgs) Handles btnitm_Export_Audit_Report.Click



        Selected_District = ""

        Loaded_District.Clear()

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"



        Try


            MysqlConn.Open()
            sql = "SELECT Town, COUNT(*) as Town_Count FROM overall_reg GROUP BY Town ORDER BY Town_Count ASC"


            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True


                Loaded_District.Add(drSQL("Town").ToString)


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...



        If Loaded_District.Count > 0 Then
            frm_District_Selection.ShowDialog()

            If Selected_District <> "" Then
                Dim f As FolderBrowserDialog = New FolderBrowserDialog

                Try

                    If f.ShowDialog() = DialogResult.OK Then
                        fileName_Audit_Dist_PDF = "\AGMA2024_Audit_Rpt_" + Selected_District + "_Only"
                        filepath_Audit_Dist_PDF = f.SelectedPath
                        finalPath_Audit_Dist_PDF = f.SelectedPath + fileName_Audit_Dist_PDF



                        lst_Masterlist.Visible = False
                        pan_masterlist_controls.Enabled = False
                        circ_prog_masterlist.Value = 0
                        circ_prog_masterlist.Visible = True
                        tmr_Circ_masterlist_anim.Enabled = True



                        ItemNumber_Audit_Dist_PDF = 1
                        BW_PDF_Export_Audit_Rpt.RunWorkerAsync()

                    Else



                    End If


                Catch ex As Exception

                    DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try



            End If

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("No Entries Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Private Sub BW_PDF_Export_Audit_Rpt_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_PDF_Export_Audit_Rpt.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String = ""
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim MaxPage_PDF As Double
        Dim PageNum As Integer = 0

        Dim maxItems As Integer
        Dim currItem As Integer

        Dim Saver_Counter As Integer = 0
        Dim File_Counter As Integer = 0

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        Try

            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM overall_reg WHERE Town = '" & Selected_District & "' ORDER BY Bil_Account_Name ASC"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            maxItems = count
            MaxPage_PDF = count / 5


            Dim TempVal As Integer = MaxPage_PDF
            If MaxPage_PDF > TempVal Then
                MaxPage_PDF += 1
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            Else
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            End If



        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1053", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()



        End Try

        'Dim currentDate As DateTime = DateTime.Now

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim CurrenPageItems As Integer = 0
        Dim TempStr As String = ""
        Dim TempLen As Integer = 0
        Dim WidthPic As Single = 200 / 1.745
        Dim HeigthPic As Single = 200

        Dim WidthPic_ID As Single = 200 / 1.6
        Dim HeigthPic_ID As Single = 200


        Dim pdf As pdf3.PdfDocument = New pdf3.PdfDocument
        pdf.Info.Title = fileName_Audit_Dist_PDF
        Dim pdfPage As pdf3.PdfPage = pdf.AddPage
        pdfPage.Size = PdfSharp.PageSize.Folio
        Dim Logo_TopLeft As pdf2.XImage
        Logo_TopLeft = Logo_PNG



        pdfPage.Width = 850
        pdfPage.Height = 1300
        pdfPage.TrimMargins.Top = 15
        pdfPage.TrimMargins.Right = 15
        pdfPage.TrimMargins.Bottom = 15
        pdfPage.TrimMargins.Left = 15


        Dim graph As pdf2.XGraphics = pdf2.XGraphics.FromPdfPage(pdfPage)
        ' Dim font As pdf2.XFont = New pdf2.XFont("Verdana", 20, pdf2.XFontStyle.Bold)
        'graph.DrawString("Sample output", font, pdf2.XBrushes.Black, New pdf2.XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), pdf2.XStringFormats.Center)

        graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

        graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

        graph.DrawString("BILECO",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

        graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

        graph.DrawString("www.bileco.net",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

        graph.DrawString("36th Annual General Membership Assembly | " + Selected_District + " District Registration List",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

        graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

        graph.DrawString("Date:   August 24, 2024",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)



        'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

        'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

        'graph.DrawString("Members : " + Member_1, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

        'graph.DrawString(Member_2, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)


        graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

        graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

        'graph.DrawString("User logged in: " + Logged_Username, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

        xPos += 30

        graph.DrawString("#",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 40

        graph.DrawString("Account Details",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
        xPos += 100

        'graph.DrawString("Account Name",
        '  New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 160

        graph.DrawString("ID Submitted",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 330

        graph.DrawString("Signature",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 110

        'graph.DrawString("Signature",
        '  New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos = 0

        yPos += 290

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql = "SELECT Bil_Account_Number, Bil_Account_Name, Bil_Address, Stub_number, Signature, (CASE WHEN Username_Reg = 'Guest' THEN (SELECT pre_reg.Photo_ID FROM pre_reg WHERE " _
                & "pre_reg.Bil_Account_Number = overall_reg.Bil_Account_Number LIMIT 1) ELSE (SELECT mco_reg.Photo_ID FROM mco_reg WHERE " _
                & "mco_reg.Bil_Account_Number = overall_reg.Bil_Account_Number LIMIT 1) END) AS Ext_Photo_ID " _
                & "FROM overall_reg WHERE Town = '" & Selected_District & "' ORDER BY Bil_Account_Name ASC"

        Try
            MysqlConn.Open()
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                ' If (Val(drSQL("r_id").ToString) > Last_ID_PDF_OVR) And (currItem < 75) Then
                'Last_ID_PDF_OVR = Val(drSQL("r_id").ToString)

                currItem += 1
                BW_PDF_Export_Audit_Rpt.ReportProgress((currItem / (maxItems + 5)) * 100)
                xPos = 0
                'xIndex = 1


                xPos += 30

                graph.DrawString(ItemNumber_Audit_Dist_PDF.ToString,
                     New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                xPos += 40

                graph.DrawString(drSQL("Bil_Account_Number").ToString,
                    New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 90

                xPos += 160

                Using myMS As New IO.MemoryStream
                    Dim arrImage As Byte()
                    'Dim myMS As New IO.MemoryStream
                    arrImage = drSQL("Ext_Photo_ID")

                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next



                    Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)

                    graph.DrawImage(Temp_Sign, xPos, yPos - 50, (180 / Temp_Sign.PixelHeight) * Temp_Sign.PixelWidth, 180)

                    Temp_Sign.Dispose()

                    'If CurrenPageItems Mod 2 = 1 Then
                    '    Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    '    graph.DrawImage(Temp_Sign, xPos - 20, yPos - 50, WidthPic, HeigthPic)
                    '    Temp_Sign.Dispose()

                    'Else
                    '    Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    '    graph.DrawImage(Temp_Sign, xPos + 60, yPos - 50, WidthPic, HeigthPic)
                    '    Temp_Sign.Dispose()

                    'End If

                    'Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    'graph.DrawImage(Temp_Sign, xPos - 20, yPos - 60, WidthPic, HeigthPic)
                    'Temp_Sign.Dispose()


                End Using

                xPos += 330

                Using myMS As New IO.MemoryStream
                    Dim arrImage As Byte()
                    'Dim myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")

                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next

                    Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)

                    graph.DrawImage(Temp_Sign, xPos, yPos - 50, WidthPic_ID, HeigthPic_ID)
                    Temp_Sign.Dispose()

                    'If CurrenPageItems Mod 2 = 1 Then
                    '    Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    '    graph.DrawImage(Temp_Sign, xPos - 20, yPos - 50, WidthPic, HeigthPic)
                    '    Temp_Sign.Dispose()

                    'Else
                    '    Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    '    graph.DrawImage(Temp_Sign, xPos + 60, yPos - 50, WidthPic, HeigthPic)
                    '    Temp_Sign.Dispose()

                    'End If

                    'Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    'graph.DrawImage(Temp_Sign, xPos - 20, yPos - 60, WidthPic, HeigthPic)
                    'Temp_Sign.Dispose()


                End Using


                xPos = 0
                xPos += 100
                yPos += 15

                graph.DrawString(drSQL("Bil_Account_Name"),
                    New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                'TempStr = drSQL("Bil_Account_Name")
                'TempLen = TempStr.Length
                'If TempLen > 30 Then
                '    TempStr = Mid(drSQL("Bil_Account_Name"), 1, 30)

                '    graph.DrawString(TempStr,
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                '    TempStr = Mid(drSQL("Bil_Account_Name"), 31, TempLen)

                '    graph.DrawString(TempStr,
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                'Else
                '    TempStr = drSQL("Bil_Account_Name")

                '    graph.DrawString(TempStr,
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'End If


                yPos += 15

                graph.DrawString(drSQL("Bil_Address"),
                    New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'TempStr = drSQL("Bil_Address")
                'TempLen = TempStr.Length
                'If TempLen > 30 Then
                '    TempStr = Mid(drSQL("Bil_Address"), 1, 27)

                '    graph.DrawString(TempStr,
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                '    TempStr = Mid(drSQL("Bil_Address"), 28, TempLen)

                '    graph.DrawString(TempStr,
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                'Else
                '    TempStr = drSQL("Bil_Address")

                '    graph.DrawString(TempStr,
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'End If

                yPos += 15

                graph.DrawString(drSQL("Stub_Number").ToString,
                    New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)




                xPos = 0
                yPos += 140
                ItemNumber_Audit_Dist_PDF += 1
                CurrenPageItems += 1

                If CurrenPageItems > 4 Then

                    CurrenPageItems = 0
                    PageNum += 1

                    graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

                    graph.DrawString("*This is an electronic-generated report. ",
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

                    Saver_Counter += 1

                    If Saver_Counter >= 10 Then
                        Saver_Counter = 0
                        File_Counter += 1

                        pdf.Save(finalPath_Audit_Dist_PDF + "(Items " + (ItemNumber_Audit_Dist_PDF - 50).ToString + " to " + (ItemNumber_Audit_Dist_PDF - 1).ToString + ").pdf")
                        pdf.Dispose()
                        graph.Graphics.Dispose()
                        graph.Internals.Graphics.Dispose()
                        graph.Dispose()


                        pdf = New pdf3.PdfDocument
                        pdf.Info.Title = fileName_Audit_Dist_PDF


                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15
                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)

                    Else
                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15

                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)


                    End If




                    '---------------------------
                    yPos = 0

                    graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

                    graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

                    graph.DrawString("BILECO",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

                    graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

                    graph.DrawString("www.bileco.net",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

                    graph.DrawString("36th Annual General Membership Assembly | " + Selected_District + " District Registration List",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

                    graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

                    graph.DrawString("Date:   August 24, 2024",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)






                    'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

                    'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

                    'graph.DrawString("Members : " + Member_1, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

                    'graph.DrawString(Member_2, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)

                    graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

                    graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

                    'graph.DrawString("User logged in: " + Logged_Username, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

                    xPos += 30

                    graph.DrawString("#",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 40

                    graph.DrawString("Account Details",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
                    xPos += 100

                    'graph.DrawString("Account Name",
                    '  New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 160

                    graph.DrawString("ID Submitted",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 330

                    graph.DrawString("Signature",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)


                    xPos = 0

                    yPos += 290


                End If


            Loop

        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1054 " & vbNewLine & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        PageNum += 1
        graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

        graph.DrawString("*This is an electronic-generated report. ",
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

        If yPos < 1100 Then
            yPos += 30
        Else
            yPos -= 10
        End If



        graph.DrawString("Prepared by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Verified by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 300, yPos)

        graph.DrawString("Noted by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 550, yPos)


        yPos += 40

        'graph.DrawString(Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("______________________",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Allan Joseph S. Borrinaga",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 300, yPos)

        graph.DrawString("Gerardo N. Oledan, REE",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 550, yPos)

        yPos += 15

        'If Lead_Person_Printing = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Lead person", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'ElseIf (Member_1 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Or (Member_2 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Member", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'End If

        'graph.DrawString(Logged_User_Position, _
        '    New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("User",
            New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("ISDM",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 300, yPos)


        graph.DrawString("General Manager",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 590, yPos)

        Dim Temp_Subtractor As Integer = ItemNumber_Audit_Dist_PDF - (File_Counter * 50)
        Try
            pdf.Save(finalPath_Audit_Dist_PDF + "(Items " + (ItemNumber_Audit_Dist_PDF - Temp_Subtractor + 1).ToString + " to " + (ItemNumber_Audit_Dist_PDF - 1).ToString + ").pdf")
            pdf.Dispose()
            graph.Dispose()
            currItem += 5
            BW_PDF_Export_Audit_Rpt.ReportProgress((currItem / (maxItems + 5)) * 100)

            DevComponents.DotNetBar.MessageBoxEx.Show("PDF Export done.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(filepath_Audit_Dist_PDF)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BW_PDF_Export_Audit_Rpt_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_PDF_Export_Audit_Rpt.ProgressChanged
        circ_prog_masterlist.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_PDF_Export_Audit_Rpt_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_PDF_Export_Audit_Rpt.RunWorkerCompleted
        lst_Masterlist.Visible = True
        pan_masterlist_controls.Enabled = True
        circ_prog_masterlist.Value = 0
        circ_prog_masterlist.Visible = False
        tmr_Circ_masterlist_anim.Enabled = False
    End Sub


    Private Sub tmr_Totals_Updater_Onsite_Tick(sender As Object, e As EventArgs) Handles tmr_Totals_Updater_Onsite.Tick
        If BW_Get_Onsite_Reg_Flag = False Then
            BW_Get_Onsite_Reg_Flag = True
            BW_Get_Onsite_Total_Count.RunWorkerAsync()


        End If
    End Sub





    Private Sub BW_Get_Onsite_Total_Count_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_Get_Onsite_Total_Count.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim ItemNumber As Integer = 1
        Dim max As Integer
        Dim Age As Integer = 0
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"
        Try
            MysqlConn.Open()
            sql = "SELECT COUNT(ID) AS rollcount FROM onsite_attendance"
            cmd = New MySqlCommand(sql, MysqlConn)
            Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            max = count
            e.Result = max.ToString
        Catch ex As Exception
            e.Result = "- - - -"
            'MysqlConn.Close()

        Finally
            MysqlConn.Close()

        End Try
    End Sub

    Private Sub BW_Get_Onsite_Total_Count_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_Get_Onsite_Total_Count.ProgressChanged

    End Sub

    Private Sub BW_Get_Onsite_Total_Count_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_Get_Onsite_Total_Count.RunWorkerCompleted
        lbl_Total_Regs_Onsite.Text = e.Result.ToString
        BW_Get_Onsite_Reg_Flag = False
    End Sub

    Private Sub btn_QR_Export_to_PDF_Click(sender As Object, e As EventArgs) Handles btn_QR_Export_to_PDF.Click
        Selected_District = ""

        Loaded_District.Clear()

        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader


        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024;Convert Zero Datetime=True"



        Try


            MysqlConn.Open()
            sql = "SELECT Bil_Account_Number, (SELECT overall_reg.Town FROM overall_reg WHERE overall_reg.Bil_Account_Number = onsite_attendance.Bil_Account_Number) as Town, " _
                    & "COUNT(*) as Town_Count FROM onsite_attendance GROUP BY Town ORDER BY Town_Count ASC"


            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True


                Loaded_District.Add(drSQL("Town").ToString)


            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)

            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            MysqlConn.Close()

        End Try 'Give the thread a very..very short break...



        If Loaded_District.Count > 0 Then
            frm_District_Selection.ShowDialog()

            If Selected_District <> "" Then
                Dim f As FolderBrowserDialog = New FolderBrowserDialog

                Try

                    If f.ShowDialog() = DialogResult.OK Then
                        fileName_Onsite_Dist_PDF = "\AGMA2024_Onsite_" + Selected_District + "_Only"
                        filepath_Onsite_Dist_PDF = f.SelectedPath
                        finalPath_Onsite_Dist_PDF = f.SelectedPath + fileName_Onsite_Dist_PDF



                        lst_QR_Attendees.Visible = False
                        pan_QR_control.Enabled = False
                        circ_prog_QR.Value = 0
                        circ_prog_QR.Visible = True
                        tmr_Circ_QR_anim.Enabled = True



                        ItemNumber_Onsite_Dist_PDF = 1
                        BW_PDF_Exporter_Onsite_Dist.RunWorkerAsync()

                    Else



                    End If


                Catch ex As Exception

                    DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try



            End If

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show("No Entries Found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub BW_PDF_Exporter_Onsite_Dist_DoWork(sender As Object, e As DoWorkEventArgs) Handles BW_PDF_Exporter_Onsite_Dist.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String = ""
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim MaxPage_PDF As Double
        Dim PageNum As Integer = 0

        Dim maxItems As Integer
        Dim currItem As Integer

        Dim Saver_Counter As Integer = 0
        Dim File_Counter As Integer = 0

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        Try

            MysqlConn.Open()

            sql = "SELECT Bil_Account_Number, (SELECT overall_reg.Town FROM overall_reg WHERE overall_reg.Bil_Account_Number = onsite_attendance.Bil_Account_Number) AS Town, " _
                    & "COUNT(*) AS Town_Count FROM onsite_attendance GROUP BY Town ORDER BY Town_Count ASC"


            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True


                If Selected_District = drSQL("Town").ToString Then
                    Dim count As Int32 = Convert.ToInt32(drSQL("Town_Count"))
                    maxItems = count
                    MaxPage_PDF = count / 15


                End If


            Loop

            'sql = "SELECT Bil_Account_Number, (SELECT overall_reg.Town FROM overall_reg WHERE overall_reg.Bil_Account_Number = onsite_attendance.Bil_Account_Number) as Town, " _
            '        & "COUNT(ID) AS rollcount FROM onsite_attendance WHERE Town = '" & Selected_District & "'"
            'cmd = New MySqlCommand(sql, MysqlConn)
            'Dim count As Int32 = Convert.ToInt32(cmd.ExecuteScalar())
            'maxItems = count
            'MaxPage_PDF = count / 15




            Dim TempVal As Integer = MaxPage_PDF
            If MaxPage_PDF > TempVal Then
                MaxPage_PDF += 1
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            Else
                TempVal = MaxPage_PDF
                MaxPage_PDF = TempVal
            End If



        Catch ex As Exception
            'MysqlConn.Close()

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1053", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MysqlConn.Close()



        End Try

        'Dim currentDate As DateTime = DateTime.Now

        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim CurrenPageItems As Integer = 0
        Dim TempStr As String = ""
        Dim TempLen As Integer = 0
        Dim WidthPic As Single = 100 / 1.745
        Dim HeigthPic As Single = 100



        Dim pdf As pdf3.PdfDocument = New pdf3.PdfDocument
        pdf.Info.Title = fileName_Onsite_Dist_PDF
        Dim pdfPage As pdf3.PdfPage = pdf.AddPage
        pdfPage.Size = PdfSharp.PageSize.Folio
        Dim Logo_TopLeft As pdf2.XImage
        Logo_TopLeft = Logo_PNG



        pdfPage.Width = 850
        pdfPage.Height = 1300
        pdfPage.TrimMargins.Top = 15
        pdfPage.TrimMargins.Right = 15
        pdfPage.TrimMargins.Bottom = 15
        pdfPage.TrimMargins.Left = 15


        Dim graph As pdf2.XGraphics = pdf2.XGraphics.FromPdfPage(pdfPage)
        ' Dim font As pdf2.XFont = New pdf2.XFont("Verdana", 20, pdf2.XFontStyle.Bold)
        'graph.DrawString("Sample output", font, pdf2.XBrushes.Black, New pdf2.XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), pdf2.XStringFormats.Center)

        graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

        graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

        graph.DrawString("BILECO",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

        graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

        graph.DrawString("www.bileco.net",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

        graph.DrawString("36th Annual General Membership Assembly | " + Selected_District + " District Registration List",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

        graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

        graph.DrawString("Date:   August 24, 2024",
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)



        'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

        'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

        'graph.DrawString("Members : " + Member_1, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

        'graph.DrawString(Member_2, _
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)


        graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

        graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
           New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

        'graph.DrawString("User logged in: " + Logged_Username, _
        '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

        xPos += 30

        graph.DrawString("#",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 40

        graph.DrawString("Account #",
           New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
        xPos += 100

        graph.DrawString("Account Name",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 180

        graph.DrawString("Address",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 200

        graph.DrawString("Membership Number",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 150

        graph.DrawString("Signature",
          New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos = 0

        yPos += 290

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql = "SELECT Bil_Account_Number, Bil_Account_Name, Bil_Address, " _
                & "(SELECT overall_reg.Signature FROM overall_reg WHERE overall_reg.Bil_Account_Number = onsite_attendance.Bil_Account_Number) AS Signature, " _
                & "(SELECT accounts_list.Membership_Number FROM accounts_list WHERE accounts_list.Account_Number = onsite_attendance.Bil_Account_Number) AS Membership_Number, " _
                & "(SELECT overall_reg.Town FROM overall_reg WHERE overall_reg.Bil_Account_Number = onsite_attendance.Bil_Account_Number) AS Town_ovr " _
                & "FROM onsite_attendance HAVING Town_ovr = '" & Selected_District & "' ORDER BY onsite_attendance.Bil_Account_Name ASC"

        Try
            MysqlConn.Open()
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                ' If (Val(drSQL("r_id").ToString) > Last_ID_PDF_OVR) And (currItem < 75) Then
                'Last_ID_PDF_OVR = Val(drSQL("r_id").ToString)

                currItem += 1
                BW_PDF_Exporter_Onsite_Dist.ReportProgress((currItem / (maxItems + 5)) * 100)
                xPos = 0
                'xIndex = 1


                xPos += 30

                graph.DrawString(ItemNumber_Onsite_Dist_PDF.ToString,
                     New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                xPos += 40

                graph.DrawString(drSQL("Bil_Account_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 100
                TempStr = drSQL("Bil_Account_Name")
                TempLen = TempStr.Length
                If TempLen > 25 Then
                    TempStr = Mid(drSQL("Bil_Account_Name"), 1, 25)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Account_Name"), 26, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Account_Name")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If



                xPos += 180
                TempStr = drSQL("Bil_Address")
                TempLen = TempStr.Length
                If TempLen > 27 Then
                    TempStr = Mid(drSQL("Bil_Address"), 1, 27)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Address"), 28, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Address")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If

                'xPos += 230
                xPos += 200

                graph.DrawString(drSQL("Membership_Number").ToString,
                    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 150

                'If Val(drSQL("Pre_reg").ToString) = 1 Then

                '    graph.DrawString("Pre-Registered", _
                '    New pdf2.XFont("Arial", 11, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'ElseIf Val(drSQL("Pre_Reg").ToString) = 0 Then
                Using myMS As New IO.MemoryStream
                    Dim arrImage As Byte()
                    'Dim myMS As New IO.MemoryStream
                    arrImage = drSQL("Signature")

                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next

                    If CurrenPageItems Mod 2 = 1 Then

                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos - 20, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    Else

                        Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                        graph.DrawImage(Temp_Sign, xPos + 60, yPos - 50, WidthPic, HeigthPic)
                        Temp_Sign.Dispose()

                    End If

                    'Dim Temp_Sign As pdf2.XImage = System.Drawing.Image.FromStream(myMS)
                    'graph.DrawImage(Temp_Sign, xPos - 20, yPos - 60, WidthPic, HeigthPic)
                    'Temp_Sign.Dispose()


                End Using
                ' End If



                xPos = 0
                yPos += 60
                ItemNumber_Onsite_Dist_PDF += 1
                CurrenPageItems += 1

                If CurrenPageItems > 14 Then

                    CurrenPageItems = 0
                    PageNum += 1

                    graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

                    graph.DrawString("*This is an electronic-generated report. ",
                       New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

                    Saver_Counter += 1

                    If Saver_Counter >= 10 Then
                        Saver_Counter = 0
                        File_Counter += 1

                        pdf.Save(finalPath_Onsite_Dist_PDF + "(Items " + (ItemNumber_Onsite_Dist_PDF - 150).ToString + " to " + (ItemNumber_Onsite_Dist_PDF - 1).ToString + ").pdf")
                        pdf.Dispose()
                        graph.Graphics.Dispose()
                        graph.Internals.Graphics.Dispose()
                        graph.Dispose()


                        pdf = New pdf3.PdfDocument
                        pdf.Info.Title = fileName_Onsite_Dist_PDF


                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15
                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)

                    Else
                        pdfPage = pdf.AddPage
                        pdfPage.Size = PdfSharp.PageSize.Folio
                        pdfPage.Width = 850
                        pdfPage.Height = 1300
                        pdfPage.TrimMargins.Top = 15
                        pdfPage.TrimMargins.Right = 15
                        pdfPage.TrimMargins.Bottom = 15
                        pdfPage.TrimMargins.Left = 15

                        graph = pdf2.XGraphics.FromPdfPage(pdfPage)


                    End If




                    '---------------------------
                    yPos = 0

                    graph.DrawImage(Logo_TopLeft, 30, 40, 80, 80)

                    graph.DrawString("BILIRAN ELECTRIC COOPERATIVE, INC.",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

                    graph.DrawString("BILECO",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

                    graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

                    graph.DrawString("www.bileco.net",
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

                    graph.DrawString("36th Annual General Membership Assembly | " + Selected_District + " District Registration List",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

                    graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

                    graph.DrawString("Date:   August 24, 2024",
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)






                    'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

                    'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

                    'graph.DrawString("Members : " + Member_1, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

                    'graph.DrawString(Member_2, _
                    '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)

                    graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
                        New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

                    graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
                       New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

                    'graph.DrawString("User logged in: " + Logged_Username, _
                    '   New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

                    xPos += 30

                    graph.DrawString("#",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 40

                    graph.DrawString("Account #",
                       New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
                    xPos += 100

                    graph.DrawString("Account Name",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 180

                    graph.DrawString("Address",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 200

                    graph.DrawString("Membership Number",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 150

                    graph.DrawString("Signature",
                      New pdf2.XFont("Arial", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos = 0

                    yPos += 290


                End If


            Loop

        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1054", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        PageNum += 1
        graph.DrawString("Page " + PageNum.ToString + " out of " + MaxPage_PDF.ToString,
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 720, 1250)

        graph.DrawString("*This is an electronic-generated report. ",
            New pdf2.XFont("Arial", 7, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 1250)

        If yPos < 1100 Then
            yPos += 30
        Else
            yPos -= 10
        End If



        graph.DrawString("Prepared by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Reviewed by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Checked by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Noted by:",
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 590, yPos)


        yPos += 40

        graph.DrawString(User_Curr_Full_Name,
            New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        'graph.DrawString("______________________",
        '    New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Allan Joseph S. Borrinaga",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Maureen D. Nierra",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 400, yPos)

        graph.DrawString("Gerardo N. Oledan, REE",
          New pdf2.XFont("Tahoma", 12, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 590, yPos)

        yPos += 15

        'If Lead_Person_Printing = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Lead person", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'ElseIf (Member_1 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Or (Member_2 = (Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname)) Then

        '    graph.DrawString("Station " + Logged_User_Group.ToString + " Member", _
        '        New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)


        'End If

        'graph.DrawString(Logged_User_Position, _
        '    New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString(User_Curr_Logged_Position.Replace("BILECO ", ""),
            New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("ISDM",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 210, yPos)

        graph.DrawString("Internal Auditor",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 400, yPos)


        graph.DrawString("General Manager",
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 590, yPos)

        Dim Temp_Subtractor As Integer = ItemNumber_Onsite_Dist_PDF - (File_Counter * 150)
        Try
            pdf.Save(finalPath_Onsite_Dist_PDF + "(Items " + (ItemNumber_Onsite_Dist_PDF - Temp_Subtractor + 1).ToString + " to " + (ItemNumber_Onsite_Dist_PDF - 1).ToString + ").pdf")
            pdf.Dispose()
            graph.Dispose()
            currItem += 5
            BW_PDF_Exporter_Onsite_Dist.ReportProgress((currItem / (maxItems + 5)) * 100)

            DevComponents.DotNetBar.MessageBoxEx.Show("PDF Export done.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(filepath_Onsite_Dist_PDF)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BW_PDF_Exporter_Onsite_Dist_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW_PDF_Exporter_Onsite_Dist.ProgressChanged
        circ_prog_QR.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_PDF_Exporter_Onsite_Dist_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BW_PDF_Exporter_Onsite_Dist.RunWorkerCompleted



        lst_QR_Attendees.Visible = True
        pan_QR_control.Enabled = True
        circ_prog_QR.Value = 0
        circ_prog_QR.Visible = False
        tmr_Circ_QR_anim.Enabled = False
    End Sub
End Class







Public Class SMSCOMMS
    Private WithEvents SMSPort As SerialPort


    Private WithEvents myTimer As New System.Windows.Forms.Timer()
    Private WithEvents myTimer_1 As New System.Windows.Forms.Timer()
    Private WithEvents Signal_Checker As New System.Windows.Forms.Timer()
    Private alarmCounter As Integer = 1
    Private exitFlag As Boolean = False


    Private SMSThread As Thread
    Private ReadThread As Thread
    Shared _Continue As Boolean = False
    Shared _ContSMS As Boolean = True
    Private _Wait As Boolean = False
    Shared _ReadPort As Boolean = False
    Public Event Sending(ByVal Done As Boolean)
    Public Event DataReceived(ByVal Message As String)
    Dim db_id As New ArrayList()
    Dim Mobile_Number_Queue As New ArrayList()
    Dim Account_Number_Name_Texted As New ArrayList()
    Dim Message_Notif As New ArrayList()
    Public Retry_Send_Count As Integer = 0

    Public indata_rcv As New ArrayList()
    Public Response_Flag As Boolean = False
    Public indata_debug As String


    Public Signal_RSSI_Points As String
    Dim Test_Mode As Boolean = True
    Dim retry_counter As Integer = 1
    Dim Prev_retry_cnt As Integer = 0
    Dim last_displayed_no_p As Boolean = False
    Public Sub Re_Init()
        SMSPort = New SerialPort
        Try


            GSM_Port = Fetch_GSM_Port()
            GSM_Baud = Fetch_GSM_Baud()

            With SMSPort
                .PortName = GSM_Port
                .BaudRate = GSM_Baud
                .Parity = Parity.None
                .DataBits = 8
                .StopBits = StopBits.One
                .Handshake = Handshake.RequestToSend
                .DtrEnable = True
                .RtsEnable = True
                .NewLine = vbCrLf
            End With

            myTimer.Interval = 100
            myTimer_1.Interval = 3000
            Signal_Checker.Interval = 1000
        Catch ex As Exception

        End Try


    End Sub
    Public Sub New()
        'initialize all values
        SMSPort = New SerialPort
        If Init_Done = True Then
            Try


                GSM_Port = Fetch_GSM_Port()
                GSM_Baud = Fetch_GSM_Baud()

                With SMSPort
                    .PortName = GSM_Port
                    .BaudRate = GSM_Baud
                    .Parity = Parity.None
                    .DataBits = 8
                    .StopBits = StopBits.One
                    .Handshake = Handshake.RequestToSend
                    .DtrEnable = True
                    .RtsEnable = True
                    .NewLine = vbCrLf
                End With

                myTimer.Interval = 100
                myTimer_1.Interval = 3000
                Signal_Checker.Interval = 1000
            Catch ex As Exception

            End Try




        End If



    End Sub


    Public Sub ChangePort_Baudrate(ByRef COMMPORT As String, ByRef BAUDRATE As Integer)
        If SMSPort.IsOpen = True Then
            Try
                SMSPort.Close()
                frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "SMS COM Port Closed" + vbNewLine
                myTimer.Stop()
            Catch ex As Exception
                frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "SMS COM Port Error" + vbNewLine
                myTimer.Stop()
            End Try
        End If

        With SMSPort
            .PortName = COMMPORT
            .BaudRate = BAUDRATE
            .Parity = Parity.None
            .DataBits = 8
            .StopBits = StopBits.One
            .Handshake = Handshake.RequestToSend
            .DtrEnable = True
            .RtsEnable = True
            .NewLine = vbCrLf
        End With

        Try
            SMSPort.Open()
            retry_counter = 0
            Test_Mode = True
            If SMSPort.IsOpen = True Then
                SMSPort.WriteLine("AT" & vbCrLf)
                myTimer.Start()
            End If

        Catch ex As Exception
            frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "SMS COM Port Error" + vbNewLine
            myTimer.Stop()
        End Try
    End Sub
    Private Sub TimerEventProcessor_2(myObject As Object, ByVal myEventArgs As EventArgs) Handles Signal_Checker.Tick
        'SMSPort.WriteLine("AT+CSQ" & vbCrLf)

    End Sub

    Private Sub TimerEventProcessor_1(myObject As Object, ByVal myEventArgs As EventArgs) Handles myTimer_1.Tick

        retry_counter += 1
    End Sub
    Private Sub TimerEventProcessor(myObject As Object, ByVal myEventArgs As EventArgs) Handles myTimer.Tick
        'myTimer.Stop()

        '' Displays a message box asking whether to continue running the timer.
        'If MessageBox.Show("Continue running?", "Count is: " & alarmCounter, _
        '                    MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '    ' Restarts the timer and increments the counter.
        '    alarmCounter += 1
        '    myTimer.Enabled = True
        'Else
        '    ' Stops the timer.
        '    exitFlag = True
        'End If\


        'SMSPort.WriteLine("AT+CSQ" & vbCrLf)

        'If indata_debug <> "" Then
        '   frm_SMS_Console_View.Rchtxt_Message_Stats.Text =frm_SMS_Console_View.Rchtxt_Message_Stats.Text + indata_debug + vbNewLine
        '   frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart =frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
        '   frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()
        '    indata_debug = ""
        'End If

        If Test_Mode = False Then
            If indata_rcv.Count > 0 Then
                'frm_ControlPanel.Rchtxt_Message_Stats.Text =frm_SMS_Console_View.Rchtxt_Message_Stats.Text + indata_rcv + vbNewLine
                If indata_rcv(0) = "Message Sent" Then


                    Update_SMS_Marker.Add(db_id(0))

                    db_id.RemoveAt(0)
                    Mobile_Number_Queue.RemoveAt(0)
                    Account_Number_Name_Texted.RemoveAt(0)
                    Message_Notif.RemoveAt(0)

                    Response_Flag = False
                    Retry_Send_Count = 0

                    frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + indata_rcv(0) + vbNewLine + vbNewLine
                    frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                    frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()
                    Signal_Checker.Start()

                    last_displayed_no_p = False

                ElseIf indata_rcv(0) = "Message Sending Failed" Then                    'Retry_Send_Count = Retry_Send_Count + 1



                    'If Retry_Send_Count > 2 Then
                    '    frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + indata_rcv(0) + vbNewLine + vbNewLine

                    '    db_id.RemoveAt(0)
                    '    Mobile_Number_Queue.RemoveAt(0)
                    '    Account_Number_Name_Texted.RemoveAt(0)
                    '    Message_Notif.RemoveAt(0)
                    '    Response_Flag = False
                    '    Retry_Send_Count = 0
                    'Else
                    '    Response_Flag = False
                    '    frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + indata_rcv(0) + ". Re-Sending Notification (Retry # " + Retry_Send_Count.ToString + ")" + vbNewLine + vbNewLine
                    '    frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                    '    frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()
                    'End If

                    'last_displayed_no_p = False



                    Response_Flag = False
                    frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + indata_rcv(0) + ". Re-Sending Notification (Retry # " + Retry_Send_Count.ToString + ")" + vbNewLine + vbNewLine
                    frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                    frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()

                    last_displayed_no_p = False

                End If

                If Mobile_Number_Queue.Count = 0 Then
                    If last_displayed_no_p = False Then
                        last_displayed_no_p = True
                        frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "No pending messages to send." + vbNewLine + vbNewLine
                        frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                        frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()

                    End If



                End If


                indata_rcv.RemoveAt(0)
            End If



            If Signal_RSSI_Points = "99" Then
                frm_SMS_Console_View.Prog_Sig_1.Value = 0
                frm_SMS_Console_View.Prog_Sig_2.Value = 0
                frm_SMS_Console_View.Prog_Sig_3.Value = 0
                frm_SMS_Console_View.Prog_Sig_4.Value = 0
                ' frm_ControlPanel.lbl_Signal_Stat_.Text = "No Signal"
            Else
                If CInt(Signal_RSSI_Points) <= 16 Then
                    frm_SMS_Console_View.Prog_Sig_1.ColorTable = eProgressBarItemColor.Error
                    frm_SMS_Console_View.Prog_Sig_2.ColorTable = eProgressBarItemColor.Error
                    frm_SMS_Console_View.Prog_Sig_3.ColorTable = eProgressBarItemColor.Paused
                    frm_SMS_Console_View.Prog_Sig_4.ColorTable = eProgressBarItemColor.Paused
                    frm_SMS_Console_View.Prog_Sig_1.Value = 100
                    frm_SMS_Console_View.Prog_Sig_2.Value = 0
                    frm_SMS_Console_View.Prog_Sig_3.Value = 0
                    frm_SMS_Console_View.Prog_Sig_4.Value = 0
                    ' frm_ControlPanel.lbl_Signal_Stat_.Text = "Poor"

                ElseIf CInt(Signal_RSSI_Points) > 16 And CInt(Signal_RSSI_Points) < 20 Then
                    frm_SMS_Console_View.Prog_Sig_1.ColorTable = eProgressBarItemColor.Error
                    frm_SMS_Console_View.Prog_Sig_2.ColorTable = eProgressBarItemColor.Error
                    frm_SMS_Console_View.Prog_Sig_3.ColorTable = eProgressBarItemColor.Paused
                    frm_SMS_Console_View.Prog_Sig_4.ColorTable = eProgressBarItemColor.Paused
                    frm_SMS_Console_View.Prog_Sig_1.Value = 100
                    frm_SMS_Console_View.Prog_Sig_2.Value = 100
                    frm_SMS_Console_View.Prog_Sig_3.Value = 0
                    frm_SMS_Console_View.Prog_Sig_4.Value = 0
                    ' frm_ControlPanel.lbl_Signal_Stat_.Text = "Fair"

                ElseIf CInt(Signal_RSSI_Points) >= 20 And CInt(Signal_RSSI_Points) <= 25 Then
                    frm_SMS_Console_View.Prog_Sig_1.ColorTable = eProgressBarItemColor.Error
                    frm_SMS_Console_View.Prog_Sig_2.ColorTable = eProgressBarItemColor.Error
                    frm_SMS_Console_View.Prog_Sig_3.ColorTable = eProgressBarItemColor.Paused
                    frm_SMS_Console_View.Prog_Sig_4.ColorTable = eProgressBarItemColor.Paused
                    frm_SMS_Console_View.Prog_Sig_1.Value = 100
                    frm_SMS_Console_View.Prog_Sig_2.Value = 100
                    frm_SMS_Console_View.Prog_Sig_3.Value = 100
                    frm_SMS_Console_View.Prog_Sig_4.Value = 0
                    ' frm_ControlPanel.lbl_Signal_Stat_.Text = "Fair"

                ElseIf CInt(Signal_RSSI_Points) > 25 And CInt(Signal_RSSI_Points) <= 30 Then
                    frm_SMS_Console_View.Prog_Sig_1.ColorTable = eProgressBarItemColor.Error
                    frm_SMS_Console_View.Prog_Sig_2.ColorTable = eProgressBarItemColor.Error
                    frm_SMS_Console_View.Prog_Sig_3.ColorTable = eProgressBarItemColor.Paused
                    frm_SMS_Console_View.Prog_Sig_4.ColorTable = eProgressBarItemColor.Paused
                    frm_SMS_Console_View.Prog_Sig_1.Value = 100
                    frm_SMS_Console_View.Prog_Sig_2.Value = 100
                    frm_SMS_Console_View.Prog_Sig_3.Value = 100
                    frm_SMS_Console_View.Prog_Sig_4.Value = 100
                    ' frm_ControlPanel.lbl_Signal_Stat_.Text = "Excellent"

                End If

            End If


            If Start_Send = True Then

                frm_SMS_Console_View.btn_Start_Send.Enabled = False
                frm_SMS_Console_View.btn_Stop_Send.Enabled = True
                frm_SMS_Console_View.btn_Connect.Enabled = False

                If Mobile_Number_Queue.Count > 0 And Response_Flag = False Then

                    SendSMS(Mobile_Number_Queue(0), Message_Notif(0))
                    frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "Sending SMS to: " + Mobile_Number_Queue(0) + " | Account # " + Account_Number_Name_Texted(0) + vbNewLine + vbNewLine
                    'indata_rcv = ""
                    frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                    frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()



                    Response_Flag = True

                    last_displayed_no_p = False


                End If

            Else

                If last_displayed_no_p = False Then
                    last_displayed_no_p = True

                    frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "SMS Sending Stopped" + vbNewLine + vbNewLine
                    'indata_rcv = ""
                    frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                    frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()

                    frm_SMS_Console_View.btn_Start_Send.Enabled = True
                    frm_SMS_Console_View.btn_Stop_Send.Enabled = False
                    frm_SMS_Console_View.btn_Connect.Enabled = False

                End If

            End If








        ElseIf Test_Mode = True Then

            If indata_rcv.Count > 0 Then

                If indata_rcv(0) = "SMS COM Port Connected" Then
                    myTimer.Interval = 100
                    frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "SMS COM Port Connected" + vbNewLine
                    frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                    frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()

                    frm_SMS_Console_View.btn_Start_Send.Enabled = True
                    frm_SMS_Console_View.btn_Stop_Send.Enabled = False
                    frm_SMS_Console_View.btn_Connect.Enabled = False

                    Test_Mode = False
                    indata_rcv.RemoveAt(0)
                    myTimer_1.Stop()
                    Signal_Checker.Start()
                    retry_counter = 1
                    Prev_retry_cnt = 0

                    last_displayed_no_p = False

                Else
                    If retry_counter > 5 Then
                        frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "Cannot connect to USB Modem. Please check COM Port settings for USB Modem" + vbNewLine
                        frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                        frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()

                        frm_SMS_Console_View.btn_Start_Send.Enabled = False
                        frm_SMS_Console_View.btn_Stop_Send.Enabled = False
                        frm_SMS_Console_View.btn_Connect.Enabled = True

                        myTimer.Stop()
                        indata_rcv.RemoveAt(0)

                        last_displayed_no_p = False

                    ElseIf retry_counter < 6 Then
                        If Prev_retry_cnt <> retry_counter Then
                            frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "Connecting to USB Modem Port..." + vbNewLine
                            frm_SMS_Console_View.Rchtxt_Message_Stats.SelectionStart = frm_SMS_Console_View.Rchtxt_Message_Stats.Text.Length
                            frm_SMS_Console_View.Rchtxt_Message_Stats.ScrollToCaret()

                            frm_SMS_Console_View.btn_Start_Send.Enabled = False
                            frm_SMS_Console_View.btn_Stop_Send.Enabled = False
                            frm_SMS_Console_View.btn_Connect.Enabled = False

                            Test_Mode = True
                            If SMSPort.IsOpen = True Then
                                SMSPort.WriteLine("AT" & vbCrLf)
                            End If

                            'indata_rcv = ""
                            indata_rcv.RemoveAt(0)

                            myTimer.Interval = 100
                            Prev_retry_cnt = retry_counter

                            last_displayed_no_p = False
                        End If


                    End If

                End If

            End If

        End If




        'Mobile_Number_Queue(Array_Count - 1) = MobileNum
        'Account_Number_Name_Texted(Array_Count - 1) = QueueNum
        'Message_Notif(Array_Count - 1) = Message

    End Sub



    Private Sub SMSPort_DataReceived() Handles SMSPort.DataReceived
        'Form1.RichTextBox1.Text = Form1.RichTextBox1.Text + SMSPort.ReadExisting().ToString + vbNewLine
        'Form1.Set_RichText(SMSPort.ReadExisting().ToString)
        Dim indata As String = SMSPort.ReadExisting()
        'MsgBox(indata)
        Dim Len As Integer = indata.Length
        Dim Temp_Str As String

        Dim Flag1 As Boolean = False
        Dim Flag2 As Boolean = False
        Dim Flag3 As Boolean = False
        Dim Newline_Flag As Boolean = False
        'indata_rcv = indata
        indata_debug = indata
        If Test_Mode = False Then
            For x As Integer = 1 To Len Step 1

                Temp_Str = Mid(indata, x, 6)
                If Temp_Str = "+CMGS:" And Newline_Flag = False Then
                    Flag1 = True
                    Newline_Flag = True
                End If

                Temp_Str = Mid(indata, x, 10)
                If Temp_Str = "+CMS ERROR" Then
                    Flag2 = True
                End If

                Temp_Str = Mid(indata, x, Len)
                If Temp_Str = ("" & vbCrLf & "" & vbCrLf & "OK" & vbCrLf & "") Then
                    Flag3 = True
                End If

            Next

            For x As Integer = 1 To Len Step 1
                Temp_Str = Mid(indata, x, 5)
                If Temp_Str = "RSSI:" And Newline_Flag = False Then
                    Signal_RSSI_Points = Mid(indata, x + 5, 2)
                ElseIf Temp_Str = "+CSQ:" And Newline_Flag = False Then
                    Signal_RSSI_Points = Mid(indata, x + 6, 2)
                End If


            Next


            'indata = ("" & vbCrLf & "" & vbCrLf & "OK" & vbCrLf & "")

            If Flag1 = True And Flag2 = False And Flag3 = True Then
                'If Mid(indata, 2, 6) = "+CMGS:" And Mid(indata, ) Then
                indata_rcv.Add("Message Sent")

                'Form1.Set_RichText()
                'frm_ControlPanel.Delivery_Checker = True
            ElseIf Flag2 = True Then
                indata_rcv.Add("Message Sending Failed")
                'frm_ControlPanel.Delivery_Checker = False
            End If
            'MsgBox(indata)


        ElseIf Test_Mode = True Then
            For x As Integer = 1 To Len Step 1
                Temp_Str = Mid(indata, x, 2)
                If Temp_Str = "OK" Then
                    indata_rcv.Add("SMS COM Port Connected")



                    Exit For
                Else
                    'indata_rcv.Add(indata)
                End If



            Next


        End If
        '09171830838
    End Sub




    Public Function SendSMS(ByVal Mobile_Number As String, ByVal Message As String) As Boolean
        If SMSPort.IsOpen = True Then
            'sending AT commands
            Try
                Signal_Checker.Stop()
                SMSPort.WriteLine("AT")
                SMSPort.WriteLine("AT+CMGF=1" & vbCrLf) 'set command message format to text mode(1)
                SMSPort.WriteLine("AT+CSCA=""+639170000130""" & vbCrLf) 'set service center address (which varies for service providers (idea, airtel))

                'SMSPort.WriteLine("AT+CSCS=""GSM""" & vbCrLf)
                'SMSPort.WriteLine("AT+CSMP=17,167,0,16" & vbCrLf)

                'SMSPort.WriteLine("AT+COPS?" & vbCrLf)
                'SMSPort.WriteLine("AT+CMGS=""" & "+639658990044" & """" & vbCrLf) ' enter the mobile number whom you want to send the SMS

                SMSPort.WriteLine("AT+CMGS=""" & Trim(Mobile_Number) & """" & vbCrLf) ' enter the mobile number whom you want to send the SMS
                _ContSMS = True 'modified Aug 22, 2019. Try if SMS will continue with more than 1 SMS count

                SMSPort.WriteLine(Message & vbCrLf & Chr(26)) 'SMS sending

                'System.Threading.Thread.Sleep(2000)
                'If Delivery_Checker = True Then
                'frm_ControlPanel.Rchtxt_Message_Stats.Text =frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "Sent" + Fetch_Mobile_Number_Notif + vbNewLine
                ' Else
                'frm_ControlPanel.Rchtxt_Message_Stats.Text =frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "Fail" + Fetch_Mobile_Number_Notif + vbNewLine
                'End If
                'Form1.RichTextBox1.Text = Form1.RichTextBox1.Text + "SMS Sent to: " + Form1.TextBox1.Text + vbNewLine
                'Delivery_Checker = False
                'SMSPort.Close()
            Catch ex As Exception
                'frm_ControlPanel.Rchtxt_Message_Stats.Text =frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "Message not sent. COM Error." + Fetch_Mobile_Number_Notif + vbNewLine
            End Try


        End If
    End Function

    Public Sub Open()
        If Not (SMSPort.IsOpen = True) Then
            Try
                SMSPort.Open()
                retry_counter = 0
                Test_Mode = True
                SMSPort.WriteLine("AT" & vbCrLf)
                myTimer.Start()
                myTimer_1.Start()
            Catch ex As Exception
                frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "SMS COM Port Error" + vbNewLine
            End Try

        End If
    End Sub

    Public Sub Close()
        If SMSPort.IsOpen = True Then
            Try
                SMSPort.Close()
                frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "SMS COM Port Closed" + vbNewLine
                myTimer.Stop()
            Catch ex As Exception
                frm_SMS_Console_View.Rchtxt_Message_Stats.Text = frm_SMS_Console_View.Rchtxt_Message_Stats.Text + "SMS COM Port Error" + vbNewLine
                myTimer.Stop()
            End Try
        End If
    End Sub



    Public Sub Add_Queue(ByRef db_ID_p As Integer, ByRef MobileNum As String, ByRef QueueNum As String, ByRef Message As String)


        'ReDim Preserve Mobile_Number_Queue(Array_Count)
        'ReDim Preserve Account_Number_Name_Texted(Array_Count)
        'ReDim Preserve Message_Notif(Array_Count)
        If db_id.Contains(db_ID_p) = False Then


            db_id.Add(db_ID_p)
            Mobile_Number_Queue.Add(MobileNum)
            Account_Number_Name_Texted.Add(QueueNum)
            Message_Notif.Add(Message)


        End If


    End Sub
End Class