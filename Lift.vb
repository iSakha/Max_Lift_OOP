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

    Public topPos, midPos, zeroPos As Double
    Public btnTopPos, btnMidPos, btnZeroPos As Button


    Public cmdUp, cmdDown, cmdStopUp, cmdStopDown As String
    Public cmd As String = ""





    Public selected As Boolean





    '------------------------------------------------- SELECT DIRECTION (Up or Down) -------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    Sub selectDirectionUp(_sender)

        _sender.readyToUp = Not _sender.readyToUp
        _sender.cmd = ""
        If _sender.readyToUp Then
            With _sender
                .readyToDown = False
                .notReady = False
                .btnUP.BackColor = Color.Yellow
                .btnUP.Font = New Font("Georgia", 10, FontStyle.Bold)
                .btnDOWN.BackColor = Color.LightGray
                .btnDOWN.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
                _sender.cmd = _sender.cmdUp

            End With
        Else
            With _sender
                .btnUP.BackColor = Color.LightGray
                .btnUP.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            End With
        End If

        If _sender.readyToUp Xor _sender.readyToDown Then
            _sender.notReady = False
            _sender.selected = True
            _sender.highlightSelected()
        Else
            _sender.notReady = True
            _sender.unSelected()
        End If

    End Sub
    Sub selectDirectionDown(_sender)

        _sender.readyToDown = Not _sender.readyToDown
        _sender.cmd = ""
        If _sender.readyToDown Then
            With _sender
                .readyToUp = False
                .notReady = False
                .btnDOWN.BackColor = Color.Yellow
                .btnDOWN.Font = New Font("Georgia", 10, FontStyle.Bold)
                .btnUP.BackColor = Color.LightGray
                .btnUP.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
                _sender.cmd = _sender.cmdDown
            End With
        Else
            With _sender
                .btnDOWN.BackColor = Color.LightGray
                .btnDOWN.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
            End With
        End If

        If _sender.readyToUp Xor _sender.readyToDown Then
            _sender.notReady = False
            _sender.highlightSelected()
        Else
            _sender.notReady = True
            _sender.unSelected()
        End If

    End Sub
    Sub clearDirection()
        Me.readyToUp = False
        Me.btnUP.BackColor = Color.LightGray
        Me.readyToDown = False
        Me.btnDOWN.BackColor = Color.LightGray
        ' Me.notReady = True
    End Sub

    '------------------------------------------------- LIFT MOVING (Up and Down) -----------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    Sub moveUP()

        pos = lblPosition.Text
        pos = Convert.ToDouble(pos) + speed * tuneSpeedUp
        lblPosition.Text = pos

    End Sub

    Sub moveDOWN()

        pos = lblPosition.Text
        pos = Convert.ToDouble(pos) - speed * speed * tuneSpeedDown
        lblPosition.Text = pos

    End Sub

    '------------------------------------------------- SET POSITION (TOP, MID and ZERO) ----------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    Sub setTop()
        If selected Then
            topPos = pos
        End If
    End Sub
    Sub setMid()
        If selected Then
            midPos = pos
        End If
    End Sub
    Sub setZero()
        If selected Then
            pos = 0.0
            zeroPos = pos
            Me.lblPosition.Text = Format(zeroPos, "#0")
        End If
    End Sub

    '------------------------------------------------- SELECT POSITION ---------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    Sub readyToTop()
        ' Me.txtBox.Text = topPos
    End Sub
    Sub readyToMid()
        'Me.txtBox.Text = midPos
    End Sub
    Sub readyToZero()
        'Me.txtBox.Text = zeroPos
    End Sub

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