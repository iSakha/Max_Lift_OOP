Public Class Lift

    Public btnUP, btnDOWN As Button
    Public btnPump As CheckBox

    Public lblPosition As Label
    Public lblSpeedUp, lblSpeedDown As Label
    Public lblSelected As Label

    Public timer As Timer

    Public grpBx As GroupBox

    Public txtPos As TextBox

    Public speedUp, speedDown As NumericUpDown

    Public pos As Double
    Public speed As Double
    Public tuneSpeedUp As Double
    Public tuneSpeedDown As Double


    Public readyToUp, readyToDown As Boolean
    Public selected As Boolean

    Public cmdUp, cmdDown, cmdStopUp, cmdStopDown As String
    Public cmd As String = ""


    '------------------------------------------------- SELECT DIRECTION (Up or Down) -------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------

    Sub selectDirection(_sender, _lift)

        _lift.cmd = ""

        If _sender.tag = "UP" Then
            _lift.readyToUp = Not _lift.readyToUp

            If _lift.readyToUp Then
                With _lift
                    .readyToDown = False
                    .btnUP.BackColor = Color.Yellow
                    .btnUP.Font = New Font("Georgia", 10, FontStyle.Bold)
                    .btnDOWN.BackColor = Color.LightGray
                    .btnDOWN.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
                    _lift.cmd = _lift.cmdUp

                End With
            Else
                With _lift
                    .btnUP.BackColor = Color.LightGray
                    .btnUP.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
                End With
            End If

            If _lift.readyToUp Xor _lift.readyToDown Then
                _lift.highlightSelected()

            Else
                _lift.unSelected()
            End If

        End If
        If _sender.tag = "DOWN" Then
            _lift.readyToDown = Not _lift.readyToDown

            If _lift.readyToDown Then

                With _lift
                    .readyToUp = False
                    .btnDOWN.BackColor = Color.Yellow
                    .btnDOWN.Font = New Font("Georgia", 10, FontStyle.Bold)
                    .btnUP.BackColor = Color.LightGray
                    .btnUP.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
                    _lift.cmd = _lift.cmdDown
                End With
            Else
                With _lift
                    .btnDOWN.BackColor = Color.LightGray
                    .btnDOWN.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
                End With
            End If

            If _lift.readyToUp Xor _lift.readyToDown Then
                _lift.highlightSelected()
            Else
                _lift.unSelected()
            End If

        End If

    End Sub
    Sub clearDirection()
        Me.readyToUp = False
        Me.btnUP.BackColor = Color.LightGray
        Me.readyToDown = False
        Me.btnDOWN.BackColor = Color.LightGray
    End Sub

    '------------------------------------------------- LIFT MOVING (Up and Down) -----------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    Sub move(_direction)
        If _direction Then
            pos = lblPosition.Text
            pos = Convert.ToDouble(pos) + speed * tuneSpeedUp
            lblPosition.Text = pos
        Else
            pos = lblPosition.Text
            pos = Convert.ToDouble(pos) - speed * tuneSpeedDown
            lblPosition.Text = pos
        End If


    End Sub


    '------------------------------------------------- SET POSITION (TOP, MID and ZERO) ----------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    'Sub setTop()
    '    If selected Then
    '        'topPos = pos
    '    End If
    'End Sub
    'Sub setMid()
    '    If selected Then
    '        'midPos = pos
    '    End If
    'End Sub
    'Sub setZero()
    '    If selected Then
    '        pos = 0.0
    '        'zeroPos = pos
    '        'Me.lblPosition.Text = Format(zeroPos, "#0")
    '    End If
    'End Sub

    '------------------------------------------------- SELECT POSITION ---------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    'Sub readyToTop()
    '    ' Me.txtBox.Text = topPos
    'End Sub
    'Sub readyToMid()
    '    'Me.txtBox.Text = midPos
    'End Sub
    'Sub readyToZero()
    '    'Me.txtBox.Text = zeroPos
    'End Sub

    '------------------------------------------------- GO TO POSITION ---------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------
    Function delta()
        Dim deltaPos As Double
        'deltaPos = pos - Convert.ToDouble(Me.txtBox.Text)
        deltaPos = Math.Round(deltaPos, 2)
        Return deltaPos
    End Function

    '------------------------------------------------- HIGHLIGHT SELECTED -----------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------
    Sub highlightSelected()
        Me.lblSelected.visible = True
        Me.grpBx.BackColor = Color.FromName("DarkGray")
        Me.selected = True
    End Sub

    Sub unSelected()
        Me.lblSelected.visible = False
        Me.grpBx.BackColor = Color.FromName("Control")
        Me.selected = False
    End Sub

End Class
'Sub New(_btnUP As Button, _btnDOWN As Button, _pos As Label)
'    Me.btnUP = _btnUP
'    Me.btnDOWN = _btnDOWN

'End Sub