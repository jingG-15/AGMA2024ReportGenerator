Public Class frm_Photo_Viewer

    Private m_PanStartPoint As New Point

    Dim Orig_Height As Integer
    Dim Orig_Width As Integer





    Private Sub frm_Photo_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NoScrollPanel1.AutoScroll = True
        'Picture Box Settings
        pb1.SizeMode = PictureBoxSizeMode.Zoom
        NoScrollPanel1.Dock = DockStyle.Fill
        pb1.Size = New Size(NoScrollPanel1.Width, NoScrollPanel1.Height)


    End Sub

    Private Sub pb1_MouseDown(sender As Object, e As MouseEventArgs) Handles pb1.MouseDown

        m_PanStartPoint = New Point(e.X, e.Y)

    End Sub

    Private Sub pb1_MouseMove(sender As Object, e As MouseEventArgs) Handles pb1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then

            'Here we get the change in coordinates.
            Dim DeltaX As Integer = (m_PanStartPoint.X - e.X)
            Dim DeltaY As Integer = (m_PanStartPoint.Y - e.Y)

            'Then we set the new autoscroll position.
            'ALWAYS pass positive integers to the panels autoScrollPosition method
            NoScrollPanel1.AutoScrollPosition = _
            New Drawing.Point((DeltaX - NoScrollPanel1.AutoScrollPosition.X), _
                            (DeltaY - NoScrollPanel1.AutoScrollPosition.Y))
        End If
    End Sub

    Private Sub frm_Photo_Viewer_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        pic_fit_to_screen.Location = New Point(Me.Width - 80 - pic_fit_to_screen.Width, 0 + pic_fit_to_screen.Height + 10)

        pic_zoom_in.Location = New Point(pic_fit_to_screen.Location.X, pic_fit_to_screen.Location.Y + pic_fit_to_screen.Height + 10)

        pic_zoom_out.Location = New Point(pic_zoom_in.Location.X, pic_zoom_in.Location.Y + pic_zoom_in.Height + 10)

        pb1.Size = New Size(NoScrollPanel1.Width, NoScrollPanel1.Height)
        pb1.Location = New Point(0, 0)

    End Sub





    Private Sub pb1_Click(sender As Object, e As EventArgs) Handles pb1.Click

    End Sub

    Private Sub pb1_MouseWheel(sender As Object, e As MouseEventArgs) Handles pb1.MouseWheel
        If e.Delta <> 0 Then
            If e.Delta >= 0 Then
                If pb1.Width > Me.Width * 10 Then
                    Exit Sub 'maximum 2000?
                Else
                    pb1.Width += CInt(pb1.Width * e.Delta / 1000)
                    pb1.Height += CInt(pb1.Height * e.Delta / 1000)
                End If

            Else

                If pb1.Width < Me.Width Then
                    pb1.Size = New Size(NoScrollPanel1.Width, NoScrollPanel1.Height)
                    pb1.Location = New Point(0, 0)

                    Exit Sub
                Else
                    pb1.Width += CInt(pb1.Width * e.Delta / 1000)
                    pb1.Height += CInt(pb1.Height * e.Delta / 1000)
                End If
                'minimum 500?


            End If

            
        End If
    End Sub

    Private Sub NoScrollPanel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NoScrollPanel1_MouseWheel(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub pic_zoom_out_Click(sender As Object, e As EventArgs) Handles pic_zoom_out.Click
        If pb1.Width < (Me.Width) Then
            Exit Sub 'maximum 2000?
        Else
            pb1.Width += CInt(pb1.Width * (-100 / 1000))
            pb1.Height += CInt(pb1.Height * (-100 / 1000))
        End If
    End Sub

    Private Sub pic_zoom_in_Click(sender As Object, e As EventArgs) Handles pic_zoom_in.Click

        If pb1.Width > (Me.Width * 4) Then
            Exit Sub 'maximum 2000?
        Else
            pb1.Width += CInt(pb1.Width * 100 / 1000)
            pb1.Height += CInt(pb1.Height * 100 / 1000)
        End If
    End Sub

    Private Sub pic_fit_to_screen_Click(sender As Object, e As EventArgs) Handles pic_fit_to_screen.Click
        pb1.Size = New Size(NoScrollPanel1.Width, NoScrollPanel1.Height)
        pb1.Location = New Point(0, 0)
    End Sub
End Class