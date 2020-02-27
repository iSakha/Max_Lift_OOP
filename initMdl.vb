Module initMdl
    Public Sub init()

        '****************************************************************************************
        '*************************   Lift 1   ***************************************************
        '****************************************************************************************

        '=====================   Init Controls   ================================================

        '---------------------   Buttons   ------------------------------------------------------

        mainForm.lift_1.btnUP = mainForm.btnUp_1
        mainForm.lift_1.btnDOWN = mainForm.btnDown_1

        '---------------------   CheckBox   ------------------------------------------------------

        mainForm.lift_1.btnPump = mainForm.pumpChkBx_1

        '----------------------   Labels   -------------------------------------------------------

        mainForm.lift_1.lblPosition = mainForm.lblTimer_1
        mainForm.lift_1.lblSpeedUp = mainForm.lbl_UP1
        mainForm.lift_1.lblSpeedDown = mainForm.lbl_DOWN1
        mainForm.lift_1.lblSelected = mainForm.lblLift1               ' green square is visible when lift is selected

        '----------------------   Timer   -------------------------------------------------------

        mainForm.lift_1.timer = mainForm.Timer1

        '----------------------   GroupBox   ----------------------------------------------------

        mainForm.lift_1.grpBx = mainForm.grpBx_1

        '----------------------   TextBox   ----------------------------------------------------

        mainForm.lift_1.txtPos = mainForm.txtPos_1

        '----------------------   NumericUpDown   -----------------------------------------------

        mainForm.lift_1.speedUp = mainForm.tuneSpeedUP1
        mainForm.lift_1.speedDown = mainForm.tuneSpeedDOWN1


        '=====================   Init Variables   ================================================

        mainForm.lift_1.pos = 0
        mainForm.lift_1.speed = 0.01
        mainForm.lift_1.tuneSpeedUp = 1.0
        mainForm.lift_1.tuneSpeedDown = 1.0

        mainForm.lift_1.readyToUp = False
        mainForm.lift_1.readyToDown = False
        mainForm.lift_1.selected = False

        mainForm.lift_1.cmdUp = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,1,1"
        mainForm.lift_1.cmdDown = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,2,1"
        mainForm.lift_1.cmdStopUp = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,1,0"
        mainForm.lift_1.cmdStopDown = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,2,0"


        '****************************************************************************************
        '*************************   Lift 2   ***************************************************
        '****************************************************************************************

        '=====================   Init Controls   ================================================

        mainForm.lift_2.btnUP = mainForm.btnUp_2
        mainForm.lift_2.btnDOWN = mainForm.btnDown_2

        mainForm.lift_2.btnPump = mainForm.pumpChkBx_2

        mainForm.lift_2.lblPosition = mainForm.lblTimer_2
        mainForm.lift_2.lblSpeedUp = mainForm.lbl_UP2
        mainForm.lift_2.lblSpeedDown = mainForm.lbl_DOWN2
        mainForm.lift_2.lblSelected = mainForm.lblLift2

        mainForm.lift_2.timer = mainForm.Timer2
        mainForm.lift_2.grpBx = mainForm.grpBx_2
        mainForm.lift_2.txtPos = mainForm.txtPos_2
        mainForm.lift_2.speedUp = mainForm.tuneSpeedUP2           ' NumericUpDown
        mainForm.lift_2.speedDown = mainForm.tuneSpeedDOWN2

        '=====================   Init Variables   ================================================

        mainForm.lift_2.pos = 0
        mainForm.lift_2.speed = 0.01
        mainForm.lift_2.tuneSpeedUp = 1.0
        mainForm.lift_2.tuneSpeedDown = 1.0

        mainForm.lift_2.readyToUp = False
        mainForm.lift_2.readyToDown = False
        mainForm.lift_2.selected = False

        mainForm.lift_2.cmdUp = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,1,1"
        mainForm.lift_2.cmdDown = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,2,1"
        mainForm.lift_2.cmdStopUp = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,1,0"
        mainForm.lift_2.cmdStopDown = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,2,0"


        '****************************************************************************************
        '*************************   Lift 3   ***************************************************
        '****************************************************************************************

        '=====================   Init Controls   ================================================

        mainForm.lift_3.btnUP = mainForm.btnUp_3
        mainForm.lift_3.btnDOWN = mainForm.btnDown_3

        mainForm.lift_3.btnPump = mainForm.pumpChkBx_3

        mainForm.lift_3.lblPosition = mainForm.lblTimer_3
        mainForm.lift_3.lblSpeedUp = mainForm.lbl_UP3
        mainForm.lift_3.lblSpeedDown = mainForm.lbl_DOWN3
        mainForm.lift_3.lblSelected = mainForm.lblLift3

        mainForm.lift_3.timer = mainForm.Timer3
        mainForm.lift_3.grpBx = mainForm.grpBx_3
        mainForm.lift_3.txtPos = mainForm.txtPos_3
        mainForm.lift_3.speedUp = mainForm.tuneSpeedUP3           ' NumericUpDown
        mainForm.lift_3.speedDown = mainForm.tuneSpeedDOWN3

        '=====================   Init Variables   ================================================

        mainForm.lift_3.pos = 0
        mainForm.lift_3.speed = 0.01
        mainForm.lift_3.tuneSpeedUp = 1.0
        mainForm.lift_3.tuneSpeedDown = 1.0

        mainForm.lift_3.readyToUp = False
        mainForm.lift_3.readyToDown = False
        mainForm.lift_3.selected = False

        mainForm.lift_3.cmdUp = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,1,1"
        mainForm.lift_3.cmdDown = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,2,1"
        mainForm.lift_3.cmdStopUp = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,1,0"
        mainForm.lift_3.cmdStopDown = "http://" & mainForm.myUrl & "/cmd.cgi?cmd=REL,2,0"


        mainForm.lift(0) = mainForm.lift_1
        mainForm.lift(1) = mainForm.lift_2
        mainForm.lift(2) = mainForm.lift_3

    End Sub
End Module
