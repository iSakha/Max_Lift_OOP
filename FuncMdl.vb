Module FuncMdl

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
