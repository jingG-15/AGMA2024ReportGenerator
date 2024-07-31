Imports MySql.Data.MySqlClient
Imports pdf1 = PdfSharp
Imports pdf2 = PdfSharp.Drawing
Imports pdf3 = PdfSharp.Pdf
Imports PdfSharp.Pdf
Imports Microsoft.Office.Interop

Public Class frm_Registration_by_User

    Dim BW_usr_reg_flag As Boolean = False
    Delegate Sub SetListItem(ByVal lstItem As ListViewItem)

    Dim BW_Reg_User_Load_Reg_Flag As Boolean = False

    Dim Usr_Reg_View_Det_Data As New ArrayList()

    Dim Usr_image_loaded_checker As Boolean

    Dim Usr_Reg_Det_Signature As Bitmap
    Dim Usr_Reg_Det_Photo_ID As Bitmap

    Dim finalPath_Usr_PDF As String
    Dim fileName_Usr_PDF As String
    Dim filepath_Usr_PDF As String
    Dim ItemNumber_Usr_PDF As Integer = 1

    Dim fileName_Excel_Usr As String
    Dim finalPath_Excel_Usr As String

    Dim Logo_PNG As Image = Image.FromFile(My.Application.Info.DirectoryPath + "\Logo.png")

    Dim BW_Usr_Search_Loader As Boolean = False

    Dim Usr_Dialog_Column_Name_Search As String

    Private m_SortingColumn As ColumnHeader

    Dim BW_RegView_Delete_Flag As Boolean = False
    Dim Selected_Stub_For_Del_Reg_View As String
    Dim Selected_Stub_Registrant_Delete_Reg_View As String
    Dim Del_Record_Account_Number_Reg_View As String
    Dim Del_Record_Account_Name_Reg_View As String

    Dim Del_Record_Address_Reg_View As String
    Dim Del_Record_Class_Reg_View As String
    Dim Del_Record_Contact_Number_Reg_View As String
    Dim Del_Record_Stub_Number_Reg_View As String
    Dim Del_Record_Registrant_Reg_View As String
    Private Sub frm_Registraion_by_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "MCO Registered by: " + Usr_report_fullname_dialog

        lst_User_Reg_List.Columns.Clear()
        lst_User_Reg_List.Columns.Add("#", 80)
        lst_User_Reg_List.Columns.Add("Account Number", 150)
        lst_User_Reg_List.Columns.Add("Account Name", 200)
        lst_User_Reg_List.Columns.Add("Stub Number", 100)
        lst_User_Reg_List.Columns.Add("Address", 200)
        lst_User_Reg_List.Columns.Add("Date Registered", 200)
        lst_User_Reg_List.Columns.Add("Class", 100)
        lst_User_Reg_List.Columns.Add("Contact Number", 150)
        lst_User_Reg_List.Items.Clear()




        Refresh_Usr_Reg()

    End Sub

    Sub Refresh_Usr_Reg()
        If BW_usr_reg_flag = False Then

            BW_usr_reg_flag = True

            pan_usr_reg_control.Enabled = False
            lst_User_Reg_List.Enabled = False
            circ_Usr_Reg_prog.Visible = True
            circ_Usr_Reg_prog.Value = 0
            tmr_usr_reg_anim.Enabled = True

            lst_User_Reg_List.Items.Clear()

            BW_Usr_Reg_Load.RunWorkerAsync()

        End If
    End Sub


    Private Sub AddListItem_Usr_Reg(ByVal lstItem As ListViewItem)

        If Me.lst_User_Reg_List.InvokeRequired Then 'Invoke if required...
            Dim d As New SetListItem(AddressOf AddListItem_Usr_Reg) 'Your delegate...
            Me.lst_User_Reg_List.Invoke(d, New Object() {lstItem})
        Else 'Otherwise, no invoke required...
            Me.lst_User_Reg_List.Items.Add(lstItem)
        End If
    End Sub

    Private Sub BW_Usr_Reg_Load_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Usr_Reg_Load.DoWork

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
                sql = "SELECT COUNT(ID) AS rollcount FROM mco_reg WHERE Username_Reg = '" & Username_For_Reg_View & "' " _
                    & "AND (SELECT overall_reg.Sanitize_Mark FROM overall_reg WHERE overall_reg.Bil_Account_Number = mco_reg.Bil_Account_Number) = 0"

            Else
                sql = "SELECT COUNT(ID) AS rollcount FROM mco_reg WHERE Username_Reg = '" & Username_For_Reg_View & "'"

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
            MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"
            MysqlConn.Open()

            If chk_Mark_Sanitation_Only.Checked = True Then
                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, Contact_Number " _
                & "FROM mco_reg WHERE Username_Reg = '" & Username_For_Reg_View & "' AND (SELECT overall_reg.Sanitize_Mark FROM overall_reg WHERE " _
                & "overall_reg.Bil_Account_Number = mco_reg.Bil_Account_Number) = 0 ORDER BY Bil_Account_Name ASC"
            Else

                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, Contact_Number " _
                & "FROM mco_reg WHERE Username_Reg = '" & Username_For_Reg_View & "' ORDER BY Bil_Account_Name ASC"
            End If

            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Usr_Reg_Load.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = ItemNumber.ToString
                    newitem.SubItems.Add(drSQL("Bil_Account_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Stub_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Address").ToString)
                    newitem.SubItems.Add(drSQL("Date_Registered").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Class").ToString)
                    newitem.SubItems.Add(drSQL("Contact_Number").ToString)
                    AddListItem_Usr_Reg(newitem)
                    BW_Usr_Reg_Load.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Usr_Reg_Load.CancellationPending) Then
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

    Private Sub BW_Usr_Reg_Load_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Usr_Reg_Load.ProgressChanged
        circ_Usr_Reg_prog.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Usr_Reg_Load_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Usr_Reg_Load.RunWorkerCompleted


        BW_usr_reg_flag = False

        pan_usr_reg_control.Enabled = True
        lst_User_Reg_List.Enabled = True
        circ_Usr_Reg_prog.Visible = False
        circ_Usr_Reg_prog.Value = 0
        tmr_usr_reg_anim.Enabled = False


    End Sub

    Private Sub frm_Registration_by_User_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        circ_Usr_Reg_prog.Location = New Point((Me.Width / 2) - (circ_Usr_Reg_prog.Width / 2), (Me.Height / 2) - (circ_Usr_Reg_prog.Height / 2))

    End Sub

    Private Sub btn_usr_reg_View_Details_Click(sender As Object, e As EventArgs) Handles btn_usr_reg_View_Details.Click

        If BW_Reg_User_Load_Reg_Flag = False Then
            BW_Reg_User_Load_Reg_Flag = True

            User_Reg_Sel_ID = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(3).Text

            lst_User_Reg_List.Enabled = False
            pan_usr_reg_control.Enabled = False
            circ_Usr_Reg_prog.Value = 0
            circ_Usr_Reg_prog.Visible = True
            tmr_usr_reg_anim.Enabled = True

            Usr_Reg_View_Det_Data.Clear()
            Usr_image_loaded_checker = False

            BW_Usr_Load_Reg_Details.RunWorkerAsync()



        End If

    End Sub

    Private Sub BW_Usr_Load_Reg_Details_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Usr_Load_Reg_Details.DoWork
        Dim MysqlConn As MySqlConnection
        Dim sql As String
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim arrImage As Byte()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15;password=haPPymeals;database=agma_2024"


        Try


            MysqlConn.Open()
            sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " _
                + "Contact_Number, Username_Reg, (SELECT overall_reg.Raffle_Valid FROM overall_reg WHERE overall_reg.Stub_Number = mco_reg.Stub_Number) as Raf_Valid FROM mco_reg WHERE Stub_Number = '" & User_Reg_Sel_ID & "'"
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Usr_Load_Reg_Details.CancellationPending) Then

                    Usr_Reg_View_Det_Data.Add(drSQL("Bil_Account_Number").ToString)
                    Usr_Reg_View_Det_Data.Add(drSQL("Bil_Account_Name").ToString)
                    Usr_Reg_View_Det_Data.Add(drSQL("Stub_Number").ToString)
                    Usr_Reg_View_Det_Data.Add(drSQL("Bil_Address").ToString)
                    Usr_Reg_View_Det_Data.Add(drSQL("Date_Registered").ToString)
                    Usr_Reg_View_Det_Data.Add(drSQL("Bil_Class").ToString)
                    Usr_Reg_View_Det_Data.Add(drSQL("Contact_Number").ToString)
                    Usr_Reg_View_Det_Data.Add(drSQL("Username_Reg").ToString)
                    Usr_Reg_View_Det_Data.Add(drSQL("Raf_Valid").ToString)

                    BW_Usr_Load_Reg_Details.ReportProgress(25)

                ElseIf (BW_Usr_Load_Reg_Details.CancellationPending) Then
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

            sql = "SELECT Signature, Photo_ID FROM mco_reg WHERE Stub_Number = '" & User_Reg_Sel_ID & "'"

            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()

            Do While drSQL.Read = True

                Using myMS As New System.IO.MemoryStream
                    arrImage = drSQL("Signature")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Usr_Reg_Det_Signature = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_Usr_Load_Reg_Details.ReportProgress(50)


                Using myMS As New System.IO.MemoryStream
                    arrImage = drSQL("Photo_ID")
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    Usr_Reg_Det_Photo_ID = System.Drawing.Image.FromStream(myMS)

                End Using

                BW_Usr_Load_Reg_Details.ReportProgress(75)

                Usr_image_loaded_checker = True
            Loop
        Catch ex As Exception
            ' MessageBox.Show(ex.Message)
            Usr_image_loaded_checker = False
            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1009" + vbNewLine + vbNewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally


            MysqlConn.Close()


        End Try 'Give the thread a very..very short break...

        BW_Usr_Load_Reg_Details.ReportProgress(100)
    End Sub

    Private Sub BW_Usr_Load_Reg_Details_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Usr_Load_Reg_Details.ProgressChanged
        circ_Usr_Reg_prog.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Usr_Load_Reg_Details_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Usr_Load_Reg_Details.RunWorkerCompleted
        If Usr_image_loaded_checker = True Then
            BW_Reg_User_Load_Reg_Flag = False


            lst_User_Reg_List.Enabled = True
            pan_usr_reg_control.Enabled = True
            circ_Usr_Reg_prog.Value = 0
            circ_Usr_Reg_prog.Visible = False
            tmr_usr_reg_anim.Enabled = False

            frm_Reg_Details_Master.txt_Account_Number.Text = Usr_Reg_View_Det_Data(0).ToString
            frm_Reg_Details_Master.txt_Account_Name.Text = Usr_Reg_View_Det_Data(1).ToString
            frm_Reg_Details_Master.txt_Stub_Number.Text = Usr_Reg_View_Det_Data(2).ToString
            frm_Reg_Details_Master.txt_Address.Text = Usr_Reg_View_Det_Data(3).ToString
            frm_Reg_Details_Master.txt_Date_Registered.Text = Usr_Reg_View_Det_Data(4).ToString
            frm_Reg_Details_Master.txt_Account_Class.Text = Usr_Reg_View_Det_Data(5).ToString
            frm_Reg_Details_Master.txt_Contact_Number.Text = Usr_Reg_View_Det_Data(6).ToString
            frm_Reg_Details_Master.txt_Registered_By.Text = Usr_Reg_View_Det_Data(7).ToString

            If Usr_Reg_View_Det_Data(8).ToString = "2" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = True
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = False

                Reg_Raffle_Validity = 2
            ElseIf Usr_Reg_View_Det_Data(8).ToString = "1" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = False
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = True

                Reg_Raffle_Validity = 1

            ElseIf Usr_Reg_View_Det_Data(8).ToString = "0" Then

                frm_Reg_Details_Master.rdo_Valid_for_Raffle.Checked = False
                frm_Reg_Details_Master.rdo_Not_Valid.Checked = False

                Reg_Raffle_Validity = 0


            End If

            frm_Reg_Details_Master.raffle_val_changed = False

            frm_Reg_Details_Master.pic_Signature.Image = Usr_Reg_Det_Signature
            frm_Reg_Details_Master.pic_Signature.SizeMode = PictureBoxSizeMode.Zoom

            frm_Reg_Details_Master.pic_ID_Snapshot.Image = Usr_Reg_Det_Photo_ID
            frm_Reg_Details_Master.pic_ID_Snapshot.SizeMode = PictureBoxSizeMode.Zoom

            frm_Reg_Details_Master.ShowDialog()


        End If


    End Sub

    Private Sub btn_usr_reg_Export_to_PDF_Click(sender As Object, e As EventArgs) Handles btn_usr_reg_Export_to_PDF.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog

        Try
            If f.ShowDialog() = DialogResult.OK Then

                fileName_Usr_PDF = "\AGMA2021_Reg_by_" + Username_For_Reg_View
                filepath_Usr_PDF = f.SelectedPath
                finalPath_Usr_PDF = f.SelectedPath + fileName_Usr_PDF



                lst_User_Reg_List.Enabled = False
                pan_usr_reg_control.Enabled = False
                circ_Usr_Reg_prog.Value = 0
                circ_Usr_Reg_prog.Visible = True
                tmr_usr_reg_anim.Enabled = True

                ItemNumber_Usr_PDF = 1
                BW_Export_Regs_PDF.RunWorkerAsync()



            End If
        Catch ex As Exception

            DevComponents.DotNetBar.MessageBoxEx.Show("Exception line: 0xF1055", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BW_Export_Regs_PDF_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Export_Regs_PDF.DoWork
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
            sql = "SELECT COUNT(ID) AS rollcount FROM mco_reg WHERE Username_Reg = '" & Username_For_Reg_View & "' ORDER BY Bil_Account_Name ASC"
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



        Dim pdf As PdfDocument = New pdf3.PdfDocument
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
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

        graph.DrawString("BILECO",
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

        graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

        graph.DrawString("www.bileco.net",
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

        graph.DrawString("36th Annual General Membership Assembly | Registration List of " + Usr_report_fullname_dialog,
           New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

        graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
           New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

        graph.DrawString("Date:   May 28, 2021",
           New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)



        'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
        '   New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

        'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
        '    New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

        'graph.DrawString("Members : " + Member_1, _
        '    New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

        'graph.DrawString(Member_2, _
        '    New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)


        graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

        graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
           New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

        'graph.DrawString("User logged in: " + Logged_Username, _
        '   New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

        xPos += 30

        graph.DrawString("#",
           New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 30

        graph.DrawString("Account #",
           New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
        xPos += 80

        graph.DrawString("Account Name",
          New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 215

        graph.DrawString("Address",
          New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 190

        graph.DrawString("Stub #",
          New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos += 110

        graph.DrawString("Signature",
          New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

        xPos = 0

        yPos += 290

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"

        sql = "SELECT Bil_Account_Number, Bil_Account_Name, Bil_Address, Stub_number, Signature FROM mco_reg " _
            + "WHERE Username_Reg = '" & Username_For_Reg_View & "' ORDER BY Bil_Account_Name ASC"

        Try
            MysqlConn.Open()
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()
            Do While drSQL.Read = True
                ' If (Val(drSQL("r_id").ToString) > Last_ID_PDF_OVR) And (currItem < 75) Then
                'Last_ID_PDF_OVR = Val(drSQL("r_id").ToString)

                currItem += 1
                BW_Export_Regs_PDF.ReportProgress((currItem / (maxItems + 5)) * 100)
                xPos = 0
                'xIndex = 1


                xPos += 30

                graph.DrawString(ItemNumber_Usr_PDF.ToString,
                     New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)


                xPos += 30

                graph.DrawString(drSQL("Bil_Account_Number").ToString,
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 80
                TempStr = drSQL("Bil_Account_Name")
                TempLen = TempStr.Length
                If TempLen > 30 Then
                    TempStr = Mid(drSQL("Bil_Account_Name"), 1, 30)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Account_Name"), 31, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Account_Name")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If



                xPos += 215
                TempStr = drSQL("Bil_Address")
                TempLen = TempStr.Length
                If TempLen > 30 Then
                    TempStr = Mid(drSQL("Bil_Address"), 1, 27)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                    TempStr = Mid(drSQL("Bil_Address"), 28, TempLen)

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos + 11)
                Else
                    TempStr = drSQL("Bil_Address")

                    graph.DrawString(TempStr,
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                End If

                'xPos += 230
                xPos += 190

                graph.DrawString(drSQL("Stub_Number").ToString,
                    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                xPos += 90

                'If Val(drSQL("Pre_reg").ToString) = 1 Then

                '    graph.DrawString("Pre-Registered", _
                '    New pdf2.XFont("Arial", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, xPos, yPos)

                'ElseIf Val(drSQL("Pre_Reg").ToString) = 0 Then
                Using myMS As New System.IO.MemoryStream
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
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 50)

                    graph.DrawString("BILECO",
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 130, 70)

                    graph.DrawString("Brgy. Caraycaray, Naval, Biliran 6560",
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 90)

                    graph.DrawString("www.bileco.net",
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 130, 110)

                    graph.DrawString("36th Annual General Membership Assembly | Registration List of " + Usr_report_fullname_dialog,
                       New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, 150)

                    graph.DrawString("Venue: BIPSU Gym, Brgy. P.I. Garcia, Naval, Biliran",
                       New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 170)

                    graph.DrawString("Date:   May 28, 2021",
                       New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 30, 190)






                    'graph.DrawString("Station #: " + Logged_User_Group.ToString, _
                    '   New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 50)

                    'graph.DrawString("Lead Person : " + Lead_Person_Printing, _
                    '    New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, 70)

                    'graph.DrawString("Members : " + Member_1, _
                    '    New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 568, 90)

                    'graph.DrawString(Member_2, _
                    '    New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 620, 110)

                    graph.DrawString("Date generated: " + FormatDateTime(Now, DateFormat.LongDate),
                        New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 50)

                    graph.DrawString("Time generated: " + Now.Hour.ToString + ":" + Now.Minute.ToString + ":" + Now.Second.ToString + "." + Now.Millisecond.ToString,
                       New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 70)

                    'graph.DrawString("User logged in: " + Logged_Username, _
                    '   New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 580, 90)

                    xPos += 30

                    graph.DrawString("#",
                       New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 30

                    graph.DrawString("Account #",
                       New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)
                    xPos += 80

                    graph.DrawString("Account Name",
                      New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 215

                    graph.DrawString("Address",
                      New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 190

                    graph.DrawString("Stub #",
                      New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

                    xPos += 110

                    graph.DrawString("Signature",
                      New pdf2.XFont("Arial", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, xPos, 230)

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
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Verified by:",
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 300, yPos)

        graph.DrawString("Noted by:",
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Bold), pdf2.XBrushes.Black, 550, yPos)


        yPos += 40

        'graph.DrawString(Logged_FirstName + " " + Logged_MiddleName + ". " + Logged_Lastname, _
        '    New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("______________________",
            New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 30, yPos)

        graph.DrawString("Allan Joseph S. Borrinaga",
          New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 300, yPos)

        graph.DrawString("Gerardo N. Oledan, REE",
          New pdf2.XFont("Tahoma", 10, PdfSharp.Drawing.XFontStyle.Underline), pdf2.XBrushes.Black, 550, yPos)

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
               New pdf2.XFont("Tahoma", 8, PdfSharp.Drawing.XFontStyle.Regular), pdf2.XBrushes.Black, 550, yPos)

        Dim Temp_Subtractor As Integer = ItemNumber_Usr_PDF - (File_Counter * 150)
        Try
            pdf.Save(finalPath_Usr_PDF + "(Items " + (ItemNumber_Usr_PDF - Temp_Subtractor + 1).ToString + " to " + (ItemNumber_Usr_PDF - 1).ToString + ").pdf")
            pdf.Dispose()
            graph.Dispose()
            currItem += 5
            BW_Export_Regs_PDF.ReportProgress((currItem / (maxItems + 5)) * 100)

            DevComponents.DotNetBar.MessageBoxEx.Show("PDF Export done.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(filepath_Usr_PDF)
        Catch ex As Exception
            DevComponents.DotNetBar.MessageBoxEx.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BW_Export_Regs_PDF_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Export_Regs_PDF.ProgressChanged
        circ_Usr_Reg_prog.Value = e.ProgressPercentage
        circ_Usr_Reg_prog.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_Export_Regs_PDF_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Export_Regs_PDF.RunWorkerCompleted
        lst_User_Reg_List.Enabled = True
        pan_usr_reg_control.Enabled = True
        circ_Usr_Reg_prog.Value = 0
        circ_Usr_Reg_prog.Visible = False
        tmr_usr_reg_anim.Enabled = False

    End Sub

    Private Sub btn_usr_reg_Export_to_Excel_Click(sender As Object, e As EventArgs) Handles btn_usr_reg_Export_to_Excel.Click
        Dim f As FolderBrowserDialog = New FolderBrowserDialog
        If f.ShowDialog() = DialogResult.OK Then
            fileName_Excel_Usr = "\AGMA2021_Reg_By_" + Username_For_Reg_View + ".xls"
            finalPath_Excel_Usr = f.SelectedPath + fileName_Excel_Usr


            lst_User_Reg_List.Enabled = False
            pan_usr_reg_control.Enabled = False
            circ_Usr_Reg_prog.Value = 0
            circ_Usr_Reg_prog.Visible = True
            tmr_usr_reg_anim.Enabled = True


            BW_Export_Regs_Excel.RunWorkerAsync()

        End If
    End Sub

    Private Sub BW_Export_Regs_Excel_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Export_Regs_Excel.DoWork
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
            "Contact_Number As 'Contact #' FROM mco_reg WHERE Username_Reg = '" & Username_For_Reg_View & "' ORDER BY Bil_Account_Name ASC"
        cmd1 = New MySqlCommand(sql1, MysqlConn1)

        da1.SelectCommand = cmd1

        Try

            BW_Export_Regs_Excel.ReportProgress(2)
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
            BW_Export_Regs_Excel.ReportProgress(5)
            'Export the Columns to excel file
            For Each dc In datatableMain.Columns

                colIndex = colIndex + 1
                oSheet.Cells(1, colIndex) = dc.ColumnName
                rprtr = colIndex + 5
                BW_Export_Regs_Excel.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)

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
                BW_Export_Regs_Excel.ReportProgress((rprtr / (datatableMain.Columns.Count + datatableMain.Rows.Count + 10)) * 100)
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
            BW_Export_Regs_Excel.ReportProgress(100)

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

    Private Sub BW_Export_Regs_Excel_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Export_Regs_Excel.ProgressChanged
        circ_Usr_Reg_prog.Value = e.ProgressPercentage
        circ_Usr_Reg_prog.ProgressText = e.ProgressPercentage.ToString + " %"
    End Sub

    Private Sub BW_Export_Regs_Excel_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Export_Regs_Excel.RunWorkerCompleted
        lst_User_Reg_List.Enabled = True
        pan_usr_reg_control.Enabled = True
        circ_Usr_Reg_prog.Value = 0
        circ_Usr_Reg_prog.Visible = False
        tmr_usr_reg_anim.Enabled = False


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



    Private Sub btn_Usr_Reg_Search_Click(sender As Object, e As EventArgs) Handles btn_Usr_Reg_Search.Click
        If txt_Usr_Reg_Search_Term.Text <> "" Then

            If rdo_Usr_Reg_search_by_Name.Checked = True Then

                If BW_Usr_Search_Loader = False Then


                    lst_User_Reg_List.Items.Clear()

                    lst_User_Reg_List.Enabled = False
                    pan_usr_reg_control.Enabled = False
                    circ_Usr_Reg_prog.Value = 0
                    circ_Usr_Reg_prog.Visible = True
                    tmr_usr_reg_anim.Enabled = True

                    BW_Usr_Search_Loader = True

                    Usr_Dialog_Column_Name_Search = "Bil_Account_Name"

                    BW_Usr_Dialog_Search.RunWorkerAsync()
                End If

            ElseIf rdo_Usr_Reg_search_by_Account_Number.Checked = True Then

                If BW_Usr_Search_Loader = False Then

                    txt_Usr_Reg_Search_Term.Text = Correct_Account_Number(txt_Usr_Reg_Search_Term.Text)

                    lst_User_Reg_List.Items.Clear()

                    lst_User_Reg_List.Enabled = False
                    pan_usr_reg_control.Enabled = False
                    circ_Usr_Reg_prog.Value = 0
                    circ_Usr_Reg_prog.Visible = True
                    tmr_usr_reg_anim.Enabled = True

                    BW_Usr_Search_Loader = True

                    Usr_Dialog_Column_Name_Search = "Bil_Account_Number"

                    BW_Usr_Dialog_Search.RunWorkerAsync()
                End If

            ElseIf rdo_Usr_Reg_search_by_Address.Checked = True Then

                If BW_Usr_Search_Loader = False Then

                    lst_User_Reg_List.Items.Clear()

                    lst_User_Reg_List.Enabled = False
                    pan_usr_reg_control.Enabled = False
                    circ_Usr_Reg_prog.Value = 0
                    circ_Usr_Reg_prog.Visible = True
                    tmr_usr_reg_anim.Enabled = True

                    BW_Usr_Search_Loader = True

                    Usr_Dialog_Column_Name_Search = "Bil_Account_Address"

                    BW_Usr_Dialog_Search.RunWorkerAsync()

                End If

            End If

        End If

    End Sub


    Private Sub BW_Usr_Dialog_Search_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Usr_Dialog_Search.DoWork
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
                sql = "SELECT COUNT(ID) AS rollcount FROM mco_reg WHERE " & Usr_Dialog_Column_Name_Search & " LIKE '%" & txt_Usr_Reg_Search_Term.Text & "%' " _
                    & "AND (SELECT overall_reg.Sanitize_Mark FROM overall_reg WHERE overall_reg.Bil_Account_Number = mco_reg.Bil_Account_Number) = 0"

            Else
                sql = "SELECT COUNT(ID) AS rollcount FROM mco_reg WHERE " & Usr_Dialog_Column_Name_Search & " LIKE '%" & txt_Usr_Reg_Search_Term.Text & "%'"


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
                "Contact_Number FROM mco_reg WHERE " & Usr_Dialog_Column_Name_Search & " LIKE '%" _
                & txt_Usr_Reg_Search_Term.Text & "%' AND (SELECT overall_reg.Sanitize_Mark FROM " _
                & "overall_reg WHERE overall_reg.Bil_Account_Number = mco_reg.Bil_Account_Number) = 0 ORDER BY Bil_Account_Name ASC"


            Else

                sql = "SELECT Stub_Number, Bil_Account_Number, Bil_Account_Name, Bil_Address, Date_Registered, Bil_Class, " +
                "Contact_Number FROM mco_reg WHERE " & Usr_Dialog_Column_Name_Search & " Like '%" & txt_Usr_Reg_Search_Term.Text _
                & "%' ORDER BY Bil_Account_Name ASC"


            End If
            cmd = New MySqlCommand(sql, MysqlConn)
            drSQL = cmd.ExecuteReader()


            Do While drSQL.Read = True
                If Not (BW_Usr_Dialog_Search.CancellationPending) Then
                    Dim newitem As New ListViewItem()
                    newitem.Text = drSQL("Bil_Account_Number").ToString
                    newitem.SubItems.Add(drSQL("Bil_Account_Name").ToString)
                    newitem.SubItems.Add(drSQL("Stub_Number").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Address").ToString)
                    newitem.SubItems.Add(drSQL("Date_Registered").ToString)
                    newitem.SubItems.Add(drSQL("Bil_Class").ToString)
                    newitem.SubItems.Add(drSQL("Contact_Number").ToString)
                    AddListItem_Usr_Reg(newitem)
                    BW_Usr_Dialog_Search.ReportProgress((ItemNumber / max) * 100)
                    ItemNumber += 1
                ElseIf (BW_Usr_Dialog_Search.CancellationPending) Then
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

    Private Sub BW_Usr_Dialog_Search_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Usr_Dialog_Search.ProgressChanged


        circ_Usr_Reg_prog.ProgressText = e.ProgressPercentage.ToString + "%"
    End Sub

    Private Sub BW_Usr_Dialog_Search_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Usr_Dialog_Search.RunWorkerCompleted


        BW_Usr_Search_Loader = False

        lst_User_Reg_List.Enabled = True
        pan_usr_reg_control.Enabled = True
        circ_Usr_Reg_prog.Value = 0
        circ_Usr_Reg_prog.Visible = False
        tmr_usr_reg_anim.Enabled = False

    End Sub

    Private Sub txt_Usr_Reg_Search_Term_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Usr_Reg_Search_Term.KeyPress
        If Asc(e.KeyChar) = 13 Then

            If txt_Usr_Reg_Search_Term.Text <> "" Then

                If rdo_Usr_Reg_search_by_Name.Checked = True Then

                    If BW_Usr_Search_Loader = False Then



                        lst_User_Reg_List.Items.Clear()

                        lst_User_Reg_List.Enabled = False
                        pan_usr_reg_control.Enabled = False
                        circ_Usr_Reg_prog.Value = 0
                        circ_Usr_Reg_prog.Visible = True
                        tmr_usr_reg_anim.Enabled = True

                        BW_Usr_Search_Loader = True

                        Usr_Dialog_Column_Name_Search = "Bil_Account_Name"

                        BW_Usr_Dialog_Search.RunWorkerAsync()
                    End If

                ElseIf rdo_Usr_Reg_search_by_Account_Number.Checked = True Then

                    If BW_Usr_Search_Loader = False Then

                        txt_Usr_Reg_Search_Term.Text = Correct_Account_Number(txt_Usr_Reg_Search_Term.Text)

                        lst_User_Reg_List.Items.Clear()

                        lst_User_Reg_List.Enabled = False
                        pan_usr_reg_control.Enabled = False
                        circ_Usr_Reg_prog.Value = 0
                        circ_Usr_Reg_prog.Visible = True
                        tmr_usr_reg_anim.Enabled = True

                        BW_Usr_Search_Loader = True

                        Usr_Dialog_Column_Name_Search = "Bil_Account_Number"

                        BW_Usr_Dialog_Search.RunWorkerAsync()
                    End If

                ElseIf rdo_Usr_Reg_search_by_Address.Checked = True Then

                    If BW_Usr_Search_Loader = False Then

                        lst_User_Reg_List.Items.Clear()

                        lst_User_Reg_List.Enabled = False
                        pan_usr_reg_control.Enabled = False
                        circ_Usr_Reg_prog.Value = 0
                        circ_Usr_Reg_prog.Visible = True
                        tmr_usr_reg_anim.Enabled = True

                        BW_Usr_Search_Loader = True

                        Usr_Dialog_Column_Name_Search = "Bil_Account_Address"

                        BW_Usr_Dialog_Search.RunWorkerAsync()

                    End If

                End If

            End If

        End If
    End Sub

    Private Sub txt_Usr_Reg_Search_Term_TextChanged(sender As Object, e As EventArgs) Handles txt_Usr_Reg_Search_Term.TextChanged

    End Sub

    Private Sub btn_Usr_Reg_refresh_list_Click(sender As Object, e As EventArgs) Handles btn_Usr_Reg_refresh_list.Click
        Refresh_Usr_Reg()
    End Sub

    Private Sub lst_Usr_Reg_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lst_User_Reg_List.ColumnClick
        Dim new_sorting_column As ColumnHeader = lst_User_Reg_List.Columns(e.Column)

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
        lst_User_Reg_List.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        ' Sort.
        lst_User_Reg_List.Sort()
    End Sub

    Private Sub lst_Usr_Reg_DoubleClick(sender As Object, e As EventArgs) Handles lst_User_Reg_List.DoubleClick
        If BW_Reg_User_Load_Reg_Flag = False Then
            BW_Reg_User_Load_Reg_Flag = True

            User_Reg_Sel_ID = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(3).Text

            lst_User_Reg_List.Enabled = False
            pan_usr_reg_control.Enabled = False
            circ_Usr_Reg_prog.Value = 0
            circ_Usr_Reg_prog.Visible = True
            tmr_usr_reg_anim.Enabled = True

            Usr_Reg_View_Det_Data.Clear()
            Usr_image_loaded_checker = False

            BW_Usr_Load_Reg_Details.RunWorkerAsync()



        End If
    End Sub

    Private Sub lst_Usr_Reg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_User_Reg_List.SelectedIndexChanged

    End Sub

    Private Function Correct_Account_Number(ByVal accnt As String) As String
        Dim ret_val As String = ""
        If accnt = 10 Then
            ret_val = Mid(accnt, 1, 2) + "-" + Mid(accnt, 3, 6) + "-" + Mid(accnt, 7, 10)

        ElseIf accnt >= 12 Then

            ret_val = accnt
        End If




        Return ret_val
    End Function

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click



        If DevComponents.DotNetBar.MessageBoxEx.Show("Delete Selected Entry?" + vbNewLine + vbNewLine _
                                                     + "Account Number: " + lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(1).Text + vbNewLine _
                                                     + "Account Name: " + lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(2).Text + vbNewLine _
                                                     + "Stub Number: " + lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(3).Text + vbNewLine _
                                                     + "Address: " + lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(4).Text + vbNewLine _
                                                     + "Date Registered: " + lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(5).Text + vbNewLine _
                                                     + "Class: " + lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(6).Text + vbNewLine _
                                                     + "Contact Number: " + lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(7).Text,
                                                     "Notice!",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
            Del_Selected_Reason = ""

            frm_Delete_Reason.ShowDialog()

            If Del_Selected_Reason <> "" Then


                If BW_RegView_Delete_Flag = False Then
                    BW_RegView_Delete_Flag = True

                    Selected_Stub_For_Del_Reg_View = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(3).Text
                    Selected_Stub_Registrant_Delete_Reg_View = Username_For_Reg_View

                    Del_Record_Account_Number_Reg_View = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(1).Text
                    Del_Record_Account_Name_Reg_View = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(2).Text
                    Del_Record_Address_Reg_View = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(4).Text
                    Del_Record_Class_Reg_View = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(6).Text
                    Del_Record_Contact_Number_Reg_View = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(7).Text
                    Del_Record_Stub_Number_Reg_View = lst_User_Reg_List.Items(lst_User_Reg_List.FocusedItem.Index).SubItems(3).Text
                    Del_Record_Registrant_Reg_View = Username_For_Reg_View

                    lst_User_Reg_List.Visible = False
                    pan_usr_reg_control.Enabled = False
                    circ_Usr_Reg_prog.Value = 0
                    circ_Usr_Reg_prog.Visible = True
                    tmr_usr_reg_anim.Enabled = True


                    BW_Delete_Entry_Reg_View.RunWorkerAsync()


                End If


            End If





        End If

    End Sub

    Private Sub BW_Delete_Entry_Reg_View_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_Delete_Entry_Reg_View.DoWork
        Dim MysqlConn As MySqlConnection
        Dim cmd As New MySqlCommand
        Dim drSQL As MySqlDataReader
        Dim da1 As New MySqlDataAdapter

        MysqlConn = New MySqlConnection

        Dim Reason_Selected As String = Del_Selected_Reason

        Dim phase_success As Boolean = False

        Dim arrImage_Sign As Byte()
        Dim arrImage_ID As Byte()


        Dim Sql As String
        MysqlConn.ConnectionString = "server=" + Server_IP + "; userid=jingG_15; password=haPPymeals; database=agma_2024;Convert Zero Datetime=True"




        Try
            MysqlConn.Open()

            If Del_Record_Registrant_Reg_View = "Guest" Then

                Sql = "SELECT Signature, Photo_ID FROM pre_reg WHERE Bil_Account_Number = '" & Del_Record_Account_Number_Reg_View & "'"

            Else

                Sql = "SELECT Signature, Photo_ID FROM mco_reg WHERE Bil_Account_Number = '" & Del_Record_Account_Number_Reg_View & "'"

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

                If Del_Record_Registrant_Reg_View = "Guest" Then

                    Sql = "INSERT INTO delete_logs (Entry_Del_Account_Num, Entry_Del_Account_Name," _
                        & "Entry_Del_Address, Entry_Del_Class, Entry_Del_Stub_Number, Entry_Del_Contact_Number, " _
                        & "Entry_Del_Registrant, Entry_Del_Photo_ID, Entry_Del_Signature, Username, Reason) VALUES (" _
                        & "'" & Replace(Del_Record_Account_Number_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Account_Name_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Address_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Class_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Stub_Number_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Contact_Number_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Registrant_Reg_View, "'", "''") & "'," _
                        & "@Photo_ID_F, " _
                        & "@Sign_F, " _
                        & "'" & User_Curr_Logged & "'," _
                        & "'" & Reason_Selected & "')"

                Else

                    Sql = "INSERT INTO delete_logs (Entry_Del_Account_Num, Entry_Del_Account_Name," _
                        & "Entry_Del_Address, Entry_Del_Class, Entry_Del_Stub_Number, Entry_Del_Contact_Number, " _
                        & "Entry_Del_Registrant, Entry_Del_Photo_ID, Entry_Del_Signature, Username, Reason) VALUES (" _
                        & "'" & Replace(Del_Record_Account_Number_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Account_Name_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Address_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Class_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Stub_Number_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Contact_Number_Reg_View, "'", "''") & "'," _
                        & "'" & Replace(Del_Record_Registrant_Reg_View, "'", "''") & "'," _
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

                Sql = "DELETE FROM overall_reg WHERE Stub_Number = '" & Selected_Stub_For_Del_Reg_View & "'"

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

                If Selected_Stub_Registrant_Delete_Reg_View = "Guest" Then
                    Sql = "DELETE FROM pre_reg WHERE Stub_Number = '" & Selected_Stub_For_Del_Reg_View & "'"
                Else
                    Sql = "DELETE FROM mco_reg WHERE Stub_Number = '" & Selected_Stub_For_Del_Reg_View & "'"

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

    Private Sub BW_Delete_Entry_Reg_View_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BW_Delete_Entry_Reg_View.ProgressChanged

    End Sub

    Private Sub BW_Delete_Entry_Reg_View_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BW_Delete_Entry_Reg_View.RunWorkerCompleted
        If e.Result.ToString = "Goods" Then
            DevComponents.DotNetBar.MessageBoxEx.Show("Record Deleted!", "Notice!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            DevComponents.DotNetBar.MessageBoxEx.Show(e.Result.ToString, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        BW_RegView_Delete_Flag = False



        lst_User_Reg_List.Visible = True
        pan_usr_reg_control.Enabled = True
        circ_Usr_Reg_prog.Value = 0
        circ_Usr_Reg_prog.Visible = False
        tmr_usr_reg_anim.Enabled = False


    End Sub
End Class