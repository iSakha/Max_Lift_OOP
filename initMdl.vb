Module initMdl
    Public Sub init()

        '****************************************************************************************
        '*************************   Lift 1   ***************************************************
        '****************************************************************************************

        '=====================   Init Controls   ================================================

        '---------------------   Buttons   ------------------------------------------------------

        Form1.lift_1.btnUP = Form1.btnUp_1
        Form1.lift_1.btnDOWN = Form1.btnDown_1

        '---------------------   CheckBox   ------------------------------------------------------

        Form1.lift_1.btnPump = Form1.pumpChkBx_1

        '----------------------   Labels   -------------------------------------------------------

        Form1.lift_1.lblPosition = Form1.lblTimer_1
        Form1.lift_1.lblSpeedUp = Form1.lbl_UP1
        Form1.lift_1.lblSpeedDown = Form1.lbl_DOWN1
        Form1.lift_1.lblSelected = Form1.lblLift1               ' green square is visible when lift is selected

        '----------------------   Timer   -------------------------------------------------------

        Form1.lift_1.timer = Form1.Timer1

        '----------------------   GroupBox   ----------------------------------------------------

        Form1.lift_1.grpBx = Form1.grpBx_1

        '----------------------   TextBox   ----------------------------------------------------

        Form1.lift_1.txtPos = Form1.txtPos_1

        '----------------------   NumericUpDown   -----------------------------------------------

        Form1.lift_1.speedUp = Form1.tuneSpeedUP1
        Form1.lift_1.speedDown = Form1.tuneSpeedDOWN1


        '=====================   Init Variables   ================================================

        Form1.lift_1.pos = 0
        Form1.lift_1.speed = 0.01
        Form1.lift_1.tuneSpeedUp = 1.0
        Form1.lift_1.tuneSpeedDown = 1.0

        Form1.lift_1.readyToUp = False
        Form1.lift_1.readyToDown = False
        Form1.lift_1.selected = False

        Form1.lift_1.cmdUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,1,1"
        Form1.lift_1.cmdDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,2,1"
        Form1.lift_1.cmdStopUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,1,0"
        Form1.lift_1.cmdStopDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,2,0"


        '****************************************************************************************
        '*************************   Lift 2   ***************************************************
        '****************************************************************************************

        '=====================   Init Controls   ================================================

        Form1.lift_2.btnUP = Form1.btnUp_2
        Form1.lift_2.btnDOWN = Form1.btnDown_2

        Form1.lift_2.btnPump = Form1.pumpChkBx_2

        Form1.lift_2.lblPosition = Form1.lblTimer_2
        Form1.lift_2.lblSpeedUp = Form1.lbl_UP2
        Form1.lift_2.lblSpeedDown = Form1.lbl_DOWN2
        Form1.lift_2.lblSelected = Form1.lblLift2

        Form1.lift_2.timer = Form1.Timer2
        Form1.lift_2.grpBx = Form1.grpBx_2
        Form1.lift_2.txtPos = Form1.txtPos_2
        Form1.lift_2.speedUp = Form1.tuneSpeedUP2           ' NumericUpDown
        Form1.lift_2.speedDown = Form1.tuneSpeedDOWN2

        '=====================   Init Variables   ================================================

        Form1.lift_2.pos = 0
        Form1.lift_2.speed = 0.01
        Form1.lift_2.tuneSpeedUp = 1.0
        Form1.lift_2.tuneSpeedDown = 1.0

        Form1.lift_2.readyToUp = False
        Form1.lift_2.readyToDown = False
        Form1.lift_2.selected = False

        Form1.lift_2.cmdUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,1,1"
        Form1.lift_2.cmdDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,2,1"
        Form1.lift_2.cmdStopUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,1,0"
        Form1.lift_2.cmdStopDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,2,0"


        '****************************************************************************************
        '*************************   Lift 3   ***************************************************
        '****************************************************************************************

        '=====================   Init Controls   ================================================

        Form1.lift_3.btnUP = Form1.btnUp_3
        Form1.lift_3.btnDOWN = Form1.btnDown_3

        Form1.lift_3.btnPump = Form1.pumpChkBx_3

        Form1.lift_3.lblPosition = Form1.lblTimer_3
        Form1.lift_3.lblSpeedUp = Form1.lbl_UP3
        Form1.lift_3.lblSpeedDown = Form1.lbl_DOWN3
        Form1.lift_3.lblSelected = Form1.lblLift3

        Form1.lift_3.timer = Form1.Timer3
        Form1.lift_3.grpBx = Form1.grpBx_3
        Form1.lift_3.txtPos = Form1.txtPos_3
        Form1.lift_3.speedUp = Form1.tuneSpeedUP3           ' NumericUpDown
        Form1.lift_3.speedDown = Form1.tuneSpeedDOWN3

        '=====================   Init Variables   ================================================

        Form1.lift_3.pos = 0
        Form1.lift_3.speed = 0.01
        Form1.lift_3.tuneSpeedUp = 1.0
        Form1.lift_3.tuneSpeedDown = 1.0

        Form1.lift_3.readyToUp = False
        Form1.lift_3.readyToDown = False
        Form1.lift_3.selected = False

        Form1.lift_3.cmdUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,1,1"
        Form1.lift_3.cmdDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,2,1"
        Form1.lift_3.cmdStopUp = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,1,0"
        Form1.lift_3.cmdStopDown = "http://" & Form1.myUrl & "/cmd.cgi?cmd=REL,2,0"


        Form1.lift(0) = Form1.lift_1
        Form1.lift(1) = Form1.lift_2
        Form1.lift(2) = Form1.lift_3

    End Sub
End Module
