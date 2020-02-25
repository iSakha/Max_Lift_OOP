Module FuncMdl

    Public Sub init()

        Form1.lift_1.pos = 0
        Form1.lift_1.speed = 0.01
        Form1.lift_1.lblPosition = Form1.lblTimer_1
        Form1.lift_1.notReady = True
        Form1.lift_1.readyToUp = False
        Form1.lift_1.readyToDown = False
        Form1.lift_1.btnUP = Form1.btnUp_1
        Form1.lift_1.btnDOWN = Form1.btnDown_1
        Form1.lift_1.btnTopPos = Form1.btnTOP_1
        Form1.lift_1.btnMidPos = Form1.btnMID_1
        Form1.lift_1.btnZeroPos = Form1.btnZERO_1
        Form1.lift_1.txtBox = Form1.txt_1
        Form1.lift_1.timer = Form1.Timer1
        Form1.lift_1.cmdUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,1,1"
        Form1.lift_1.cmdDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,2,1"
        Form1.lift_1.cmdStopUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,1,0"
        Form1.lift_1.cmdStopDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,2,0"
        Form1.lift_1.speedUp = Form1.tuneSpeedUP1
        Form1.lift_1.speedDown = Form1.tuneSpeedDOWN1
        Form1.lift_1.tuneSpeedUp = 1.0
        Form1.lift_1.tuneSpeedDown = 1.0
        Form1.lift_1.lblSpeedUp = Form1.lbl_UP1
        Form1.lift_1.lblSpeedDown = Form1.lbl_DOWN1
        Form1.lift_1.lblSelected = Form1.lblLift1
        Form1.lift_1.grpBx = Form1.grpBx_1
        Form1.lift_1.selected = False


        Form1.lift_2.pos = 0
        Form1.lift_2.speed = 0.01
        Form1.lift_2.lblPosition = Form1.lblTimer_2
        Form1.lift_2.notReady = True
        Form1.lift_2.readyToUp = False
        Form1.lift_2.readyToDown = False
        Form1.lift_2.btnUP = Form1.btnUp_2
        Form1.lift_2.btnDOWN = Form1.btnDown_2
        Form1.lift_2.btnTopPos = Form1.btnTOP_2
        Form1.lift_2.btnMidPos = Form1.btnMID_2
        Form1.lift_2.btnZeroPos = Form1.btnZERO_2
        Form1.lift_2.txtBox = Form1.txt_2
        Form1.lift_2.timer = Form1.Timer2
        Form1.lift_2.cmdUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,3,1"
        Form1.lift_2.cmdDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,4,1"
        Form1.lift_2.cmdStopUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,3,0"
        Form1.lift_2.cmdStopDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,4,0"
        Form1.lift_2.speedUp = Form1.tuneSpeedUP2
        Form1.lift_2.speedDown = Form1.tuneSpeedDOWN2
        Form1.lift_2.tuneSpeedUp = 1.0
        Form1.lift_2.tuneSpeedDown = 1.0
        Form1.lift_2.lblSpeedUp = Form1.lbl_UP2
        Form1.lift_2.lblSpeedDown = Form1.lbl_DOWN2
        Form1.lift_2.lblSelected = Form1.lblLift2
        Form1.lift_2.grpBx = Form1.grpBx_2
        Form1.lift_2.selected = False


        Form1.lift_3.pos = 0
        Form1.lift_3.speed = 0.01
        Form1.lift_3.lblPosition = Form1.lblTimer_3
        Form1.lift_3.notReady = True
        Form1.lift_3.readyToUp = False
        Form1.lift_3.readyToDown = False
        Form1.lift_3.btnUP = Form1.btnUp_3
        Form1.lift_3.btnDOWN = Form1.btnDown_3
        Form1.lift_3.btnTopPos = Form1.btnTOP_3
        Form1.lift_3.btnMidPos = Form1.btnMID_3
        Form1.lift_3.btnZeroPos = Form1.btnZERO_3
        Form1.lift_3.txtBox = Form1.txt_3
        Form1.lift_3.timer = Form1.Timer3
        Form1.lift_3.cmdUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,5,1"
        Form1.lift_3.cmdDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,6,1"
        Form1.lift_3.cmdStopUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,5,0"
        Form1.lift_3.cmdStopDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,6,0"
        Form1.lift_3.speedUp = Form1.tuneSpeedUP3
        Form1.lift_3.speedDown = Form1.tuneSpeedDOWN3
        Form1.lift_3.tuneSpeedUp = 1.0
        Form1.lift_3.tuneSpeedDown = 1.0
        Form1.lift_3.lblSpeedUp = Form1.lbl_UP3
        Form1.lift_3.lblSpeedDown = Form1.lbl_DOWN3
        Form1.lift_3.lblSelected = Form1.lblLift3
        Form1.lift_3.grpBx = Form1.grpBx_3
        Form1.lift_3.selected = False

        Form1.lift_4.pos = 0
        Form1.lift_4.speed = 0.01
        Form1.lift_4.lblPosition = Form1.lblTimer_4
        Form1.lift_4.notReady = True
        Form1.lift_4.readyToUp = False
        Form1.lift_4.readyToDown = False
        Form1.lift_4.btnUP = Form1.btnUp_4
        Form1.lift_4.btnDOWN = Form1.btnDown_4
        Form1.lift_4.btnTopPos = Form1.btnTOP_4
        Form1.lift_4.btnMidPos = Form1.btnMID_4
        Form1.lift_4.btnZeroPos = Form1.btnZERO_4
        Form1.lift_4.txtBox = Form1.txt_4
        Form1.lift_4.timer = Form1.Timer4
        Form1.lift_4.cmdUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,7,1"
        Form1.lift_4.cmdDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,8,1"
        Form1.lift_4.cmdStopUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,7,0"
        Form1.lift_4.cmdStopDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,8,0"
        Form1.lift_4.speedUp = Form1.tuneSpeedUP4
        Form1.lift_4.speedDown = Form1.tuneSpeedDOWN4
        Form1.lift_4.tuneSpeedUp = 1.0
        Form1.lift_4.tuneSpeedDown = 1.0
        Form1.lift_4.lblSpeedUp = Form1.lbl_UP4
        Form1.lift_4.lblSpeedDown = Form1.lbl_DOWN4
        Form1.lift_4.lblSelected = Form1.lblLift4
        Form1.lift_4.grpBx = Form1.grpBx_4
        Form1.lift_4.selected = False

        Form1.lift(0) = Form1.lift_1
        Form1.lift(1) = Form1.lift_2
        Form1.lift(2) = Form1.lift_3
        Form1.lift(3) = Form1.lift_4


    End Sub
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
            For i = 0 To 3
                Form1.lift(i).clearDirection()
            Next i
            Form1.btnStart.Enabled = False
        Else
            Form1.btnStart.Enabled = True
        End If
    End Sub

    Public Sub chngBackColor(_sender, _lift_1)
        _lift_1.btnTopPos.BackColor = Color.FromArgb(220, 220, 220)
        _lift_1.btnMidPos.BackColor = Color.FromArgb(220, 220, 220)
        _lift_1.btnZeroPos.BackColor = Color.FromArgb(220, 220, 220)
        _sender.BackColor = Color.FromArgb(255, 192, 0)
    End Sub

    Public Sub changeBackColor(_sender)
        _sender.BackColor = Color.FromArgb(255, 192, 0)
    End Sub
End Module
