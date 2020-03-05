﻿Public Class mainForm

    Public lift_1 As New Lift()
    Public lift_2 As New Lift()
    Public lift_3 As New Lift()
    Public lift_4 As New Lift()
    Public modeState As Integer
    Public btnAutoState As Boolean = False
    Public zeroPositionSet As Boolean = False
    Public lift(3) As Lift

    Public myUrl, cmd As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myUrl = url_txt.Text
        RadioButton1.Checked = True
        Call init()

    End Sub

    '------------------------------------------------- SELECT MODE--------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        modeState = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        modeState = 1
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        modeState = 2
    End Sub
    '------------------------------------------------- SELECT DIRECTION (Up or Down) -------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------

    Private Sub btnUp_1_Click(sender As Object, e As EventArgs) Handles btnUp_1.Click
        lift(0).selectDirection(sender, lift(0))
    End Sub

    Private Sub btnDown_1_Click(sender As Object, e As EventArgs) Handles btnDown_1.Click
        lift(0).selectDirection(sender, lift(0))
    End Sub

    Private Sub btnUp_2_Click(sender As Object, e As EventArgs) Handles btnUp_2.Click
        lift(1).selectDirection(sender, lift(1))
    End Sub

    Private Sub btnDown_2_Click(sender As Object, e As EventArgs) Handles btnDown_2.Click
        lift(1).selectDirection(sender, lift(1))
    End Sub

    Private Sub btnUp_3_Click(sender As Object, e As EventArgs) Handles btnUp_3.Click
        lift(2).selectDirection(sender, lift(2))
    End Sub

    Private Sub btnDown_3_Click(sender As Object, e As EventArgs) Handles btnDown_3.Click
        lift(2).selectDirection(sender, lift(2))
    End Sub


    '------------------------------------------------- START/STOP BUTTON -------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnStart_MouseDown(sender As Object, e As MouseEventArgs) Handles btnStart.MouseDown
        Dim webCl As New System.Net.WebClient
        Dim i As Integer
        For i = 0 To 2
            lift(i).timer.Enabled = True
            Try
                'webCl.DownloadString(lift(i).cmd)
            Catch ex As Exception

            End Try

        Next i
    End Sub

    Private Sub btnStart_MouseUp(sender As Object, e As MouseEventArgs) Handles btnStart.MouseUp
        Dim webCl As New System.Net.WebClient
        For i = 0 To 2
            lift(i).timer.Enabled = False
            'webCl.DownloadString(lift(i).cmdStopUp)
            'webCl.DownloadString(lift(i).cmdStopDown)
        Next i
    End Sub

    '------------------------------------------------- TIMER TICK --------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case modeState
            Case 0

                If (lift(0).readyToUp) Then
                    lift(0).move(True)
                End If
                If (lift(0).readyToDown) Then
                    lift(0).move(False)
                End If

            Case 1

                If (lift(0).readyToUp) Then
                    lift(0).move(True)
                End If
                If (lift(0).readyToDown) Then
                    lift(0).move(False)
                End If

            Case 2
                If (btnAutoState = True) Then
                    Dim webCl As New System.Net.WebClient
                    If lift(0).delta() > 0 Then
                        lift(0).move(False)
                    End If
                    If lift(0).delta() < 0 Then
                        lift(0).move(True)
                    End If

                    If lift(0).delta() = 0 Then
                        'webCl.DownloadString(lift(0).cmdStopUp)
                        'webCl.DownloadString(lift(0).cmdStopDown)
                        lift(0).timer.Enabled = False
                    End If

                End If
        End Select
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Select Case modeState
            Case 0

                If (lift(1).readyToUp) Then
                    lift(1).move(True)
                End If
                If (lift(1).readyToDown) Then
                    lift(1).move(False)
                End If

            Case 1

                If (lift(1).readyToUp) Then
                    lift(1).move(True)
                End If
                If (lift(1).readyToDown) Then
                    lift(1).move(False)
                End If

            Case 2
                If (btnAutoState = True) Then
                    Dim webCl As New System.Net.WebClient
                    If lift(1).delta() > 0 Then
                        lift(1).move(False)
                    End If
                    If lift(1).delta() < 0 Then
                        lift(1).move(True)
                    End If

                    If lift(1).delta() = 0 Then
                        'webCl.DownloadString(lift(1).cmdStopUp)
                        'webCl.DownloadString(lift(1).cmdStopDown)
                        lift(1).timer.Enabled = False
                    End If

                End If
        End Select
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Select Case modeState
            Case 0

                If (lift(2).readyToUp) Then
                    lift(2).move(True)
                End If
                If (lift(2).readyToDown) Then
                    lift(2).move(False)
                End If

            Case 1

                If (lift(2).readyToUp) Then
                    lift(2).move(True)
                End If
                If (lift(2).readyToDown) Then
                    lift(2).move(False)
                End If

            Case 2
                If (btnAutoState = True) Then
                    Dim webCl As New System.Net.WebClient
                    If lift(2).delta() > 0 Then
                        lift(2).move(False)
                    End If
                    If lift(2).delta() < 0 Then
                        lift(2).move(True)
                    End If

                    If lift(2).delta() = 0 Then
                        'webCl.DownloadString(lift(2).cmdStopUp)
                        'webCl.DownloadString(lift(2).cmdStopDown)
                        lift(2).timer.Enabled = False
                    End If

                End If
        End Select
    End Sub

    '------------------------------------------------- GO TO POSITION ---------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------------------

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        'Dim webCl As New System.Net.WebClient
        Dim i As Integer
        btnAutoState = True
        For i = 0 To 2
            lift(i).cmd = ""
            lift(i).timer.Enabled = True
            If lift(i).delta() < 0 Then
                lift(i).cmd = lift(i).cmdUp
            End If
            If lift(i).delta() > 0 Then
                lift(i).cmd = lift(i).cmdDown
            End If
            Try
                'webCl.DownloadString(lift(i).cmd)
            Catch ex As Exception

            End Try
        Next i
    End Sub

    Private Sub resp_txt_TextChanged(sender As Object, e As EventArgs) Handles resp_txt.TextChanged
        If resp_txt.Text = "DONE" Then
            connectBtn.BackColor = Color.YellowGreen
            connectBtn.Text = "Connected"
        Else
            connectBtn.BackColor = Color.Red
        End If
    End Sub

    Private Sub connectBtn_Click(sender As Object, e As EventArgs) Handles connectBtn.Click
        Dim webCl As New System.Net.WebClient
        Dim str As String = webCl.DownloadString("http://192.168.100.115/cmd.cgi?")
        resp_txt.Text = str

    End Sub
    '------------------------------------------------- PUMP ON/OFF ---------------------------------------------------------
    '-----------------------------------------------------------------------------------------------------------------------

    Private Sub pumpChkBx_1_CheckedChanged(sender As Object, e As EventArgs) Handles pumpChkBx_1.CheckedChanged
        'Dim webCl As New System.Net.WebClient
        'If pumpChkBx_1.Checked Then
        '    pumpChkBx_1.BackColor = Color.FromName("lime")
        '    'webCl.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,9,1")
        'Else
        '    pumpChkBx_1.BackColor = Color.FromName("gainsboro")
        '    'webCl.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,9,0")
        'End If

        lift(0).pump()

    End Sub

    Private Sub pumpChkBx_2_CheckedChanged(sender As Object, e As EventArgs) Handles pumpChkBx_2.CheckedChanged
        'Dim webCl As New System.Net.WebClient
        'If pumpChkBx_2.Checked Then
        '    pumpChkBx_2.BackColor = Color.FromName("lime")
        '    ' webCl.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,10,1")
        'Else
        '    pumpChkBx_2.BackColor = Color.FromName("gainsboro")
        '    'webCl.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,10,0")
        'End If
        lift(1).pump()
    End Sub

    Private Sub pumpChkBx_3_CheckedChanged(sender As Object, e As EventArgs) Handles pumpChkBx_3.CheckedChanged
        'Dim webCl As New System.Net.WebClient
        'If pumpChkBx_3.Checked Then
        '    pumpChkBx_3.BackColor = Color.FromName("lime")
        '    'webCl.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,11,1")
        'Else
        '    pumpChkBx_3.BackColor = Color.FromName("gainsboro")
        '    'webCl.DownloadString("http://192.168.100.115/cmd.cgi?cmd=REL,11,0")
        'End If
        lift(2).pump()
    End Sub

    Private Sub speedChckBx_CheckedChanged(sender As Object, e As EventArgs) Handles speedChckBx.CheckedChanged
        Dim i As Integer
        If speedChckBx.Checked Then
            speedChckBx.BackColor = Color.FromName("lime")
            For i = 0 To 2
                lift(i).speedUp.Visible = True
                lift(i).speedDown.Visible = True
                lift(i).lblSpeedUp.Visible = True
                lift(i).lblSpeedDown.Visible = True
            Next i
        Else
            speedChckBx.BackColor = Color.FromName("gainsboro")
            For i = 0 To 2
                lift(i).speedUp.Visible = False
                lift(i).speedDown.Visible = False
                lift(i).lblSpeedUp.Visible = False
                lift(i).lblSpeedDown.Visible = False
            Next i
        End If
    End Sub



    Private Sub testBtn_Click(sender As Object, e As EventArgs)
        'Web.Show()
    End Sub

    Private Sub grpBx_1_MouseClick(sender As Object, e As MouseEventArgs) Handles grpBx_1.MouseClick
        lift(0).selected = Not lift(0).selected
        If lift(0).selected Then
            lift(0).highlightSelected()
        Else
            lift(0).unSelected()
        End If
    End Sub

    Private Sub grpBx_2_MouseClick(sender As Object, e As MouseEventArgs) Handles grpBx_2.MouseClick
        lift(1).selected = Not lift(1).selected
        If lift(1).selected Then
            lift(1).highlightSelected()
        Else
            lift(1).unSelected()
        End If
    End Sub
    Private Sub grpBx_3_MouseClick(sender As Object, e As MouseEventArgs) Handles grpBx_3.MouseClick
        lift(2).selected = Not lift(2).selected
        If lift(2).selected Then
            lift(2).highlightSelected()
        Else
            lift(2).unSelected()
        End If
    End Sub
    '------------------------------------------------- SET ZERO POSITION  ------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------

    Private Sub btnSetZero_Click(sender As Object, e As EventArgs) Handles btnSetZero.Click
        Dim zeroDataRow As DataGridViewRow
        Dim i, j As Integer

        For i = 0 To 2
            If lift(i).selected Then
                lift(i).pos = 0.0
                lift(i).lblPosition.Text = lift(i).pos
            End If

        Next i

        dgv.Rows.Add("zero", lift(0).pos, lift(1).pos, lift(2).pos)

        zeroDataRow = dgv.Rows(0)

        For i = 0 To 2
            If lift(i).selected Then
                zeroDataRow.Cells(i + 1).Style.BackColor = Color.White
            Else
                MsgBox("Zero position for Lift " & i + 1 & " is not set!!!")
                j = i + 1
                zeroDataRow.Cells(j).Style.BackColor = Color.Red
            End If

        Next i

    End Sub
    '------------------------------------------------- ADD NEW POSITION  -------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------------------------
    Private Sub btnSavePos_Click(sender As Object, e As EventArgs) Handles btnSavePos.Click
        Dim lastDataRow As DataGridViewRow
        Dim i, j As Integer

        For i = 0 To 2
            If lift(i).selected Then
                lift(i).pos = lift(i).lblPosition.Text
                lift(i).lblPosition.Text = lift(i).pos
            End If

        Next i

        dgv.Rows.Add(txtPosName.Text, lift(0).pos, lift(1).pos, lift(2).pos)
        lastDataRow = dgv.Rows(dgv.Rows.Count - 2)
        For i = 0 To 2
            If lift(i).selected Then
                lastDataRow.Cells(i + 1).Style.BackColor = Color.White
            Else
                MsgBox("Zero position for Lift " & i + 1 & " is not set!!!")
                j = i + 1
                lastDataRow.Cells(j).Style.BackColor = Color.Red
            End If

        Next i

    End Sub

    Private Sub btnEnableConnect_CheckedChanged(sender As Object, e As EventArgs) Handles btnEnableConnect.CheckedChanged
        If btnEnableConnect.Checked Then
            btnEnableConnect.BackColor = Color.Red
        Else
            btnEnableConnect.BackColor = Color.Gainsboro
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dgv.Rows(index)
        txtPosName.Text = selectedRow.Cells(0).Value.ToString
        lift(0).txtPos.Text = selectedRow.Cells(1).Value.ToString
        lift(1).txtPos.Text = selectedRow.Cells(2).Value.ToString
        lift(2).txtPos.Text = selectedRow.Cells(3).Value.ToString

    End Sub
End Class