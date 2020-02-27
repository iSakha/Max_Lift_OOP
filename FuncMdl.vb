Module FuncMdl

    Public Sub selectMode(_sender)
        Dim i As Integer
        Form1.RadioButton1.BackColor = Color.FromArgb(200, 200, 200)
        Form1.RadioButton2.BackColor = Color.FromArgb(200, 200, 200)
        Form1.RadioButton3.BackColor = Color.FromArgb(200, 200, 200)

        Form1.RadioButton1.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        Form1.RadioButton2.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        Form1.RadioButton3.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)

        _sender.BackColor = Color.FromArgb(151, 247, 125)
        _sender.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold)

        If (_sender.name = "RadioButton3") Then
            For i = 0 To 2
                Form1.lift(i).clearDirection()
            Next i
            Form1.btnStart.Enabled = False
        Else
            Form1.btnStart.Enabled = True
        End If
    End Sub

    Public Sub chngBackColor(_sender, _lift)
        _lift.btnTopPos.BackColor = Color.FromArgb(220, 220, 220)
        _lift.btnMidPos.BackColor = Color.FromArgb(220, 220, 220)
        _lift.btnZeroPos.BackColor = Color.FromArgb(220, 220, 220)
        _sender.BackColor = Color.FromArgb(255, 192, 0)
    End Sub

    Public Sub changeBackColorTop(_lift)
        If _lift.selected Then
            _lift.btnTopPos.FlatStyle = FlatStyle.Flat
            _lift.btnTopPos.FlatAppearance.BorderSize = 2
            _lift.btnTopPos.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)
        End If
    End Sub

    Public Sub changeBackColorMid(_lift)
        If _lift.selected Then
            _lift.btnMidPos.FlatStyle = FlatStyle.Flat
            _lift.btnMidPos.FlatAppearance.BorderSize = 2
            _lift.btnMidPos.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)
        End If
    End Sub

    Public Sub changeBackColorZero(_lift)
        If _lift.selected Then
            _lift.btnZeroPos.FlatStyle = FlatStyle.Flat
            _lift.btnZeroPos.FlatAppearance.BorderSize = 2
            _lift.btnZeroPos.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)
        End If
    End Sub
End Module
