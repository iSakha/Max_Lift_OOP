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
    Public cmdPumpOn, cmdPumpOff As String
    Public cmdReadyPumpOn, cmdReadyPumpOff As String
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

    '------------------------------------------------- GO TO POSITION ---------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------
    Function delta()
        Dim deltaPos As Double
        deltaPos = pos - Convert.ToDouble(Me.txtPos.Text)
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



    '-------------------------------------------------    PUMP ON/OFF    ------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------

    Sub pump()

        Dim webCl As New System.Net.WebClient

        If Me.btnPump.Checked Then
            Me.btnPump.BackColor = Color.FromName("lime")
            If (mainForm.btnEnableConnect.Checked = False) Then
                webCl.DownloadString(Me.cmdReadyPumpOn)
                webCl.DownloadString(Me.cmdPumpOn)
            End If
        Else
            Me.btnPump.BackColor = Color.FromName("gainsboro")
            If (mainForm.btnEnableConnect.Checked = False) Then
                webCl.DownloadString(Me.cmdReadyPumpOff)
                webCl.DownloadString(Me.cmdPumpOff)
            End If
        End If

    End Sub

    Sub autoPump()
        If Me.selected Then
            Me.btnPump.Checked = True
            Me.pump()
        Else
            Me.btnPump.Checked = False
            Me.pump()
        End If
    End Sub

End Class
