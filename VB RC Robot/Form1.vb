Public Class Form1
    Dim data_rx As String
    Dim pc_port As Array
    Private Sub connect_cam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connect_cam.Click
        cam_view.MonitorConnect(ip_box.Text, 80, "admin", "")
        Me.ProcessTabKey(12)
    End Sub

    Private Sub cam_view_OnMonitorConnectResult(ByVal sender As System.Object, ByVal e As AxDVM_IPCAMLib._DDVM_IPCamEvents_OnMonitorConnectResultEvent) Handles cam_view.OnMonitorConnectResult
        cam_view.PlayVideo()
        cam_view.Resolution = 32
        cam_control.Enabled = True
        ip_box.Enabled = False

    End Sub

    Private Sub disconnect_cam_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disconnect_cam.Click
        cam_view.MonitorDisconnect()
        cam_control.Enabled = False
        ip_box.Enabled = True
    End Sub

    Private Sub cam_up_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam_up.MouseDown
        cam_view.DecoderControl(0)
    End Sub

    Private Sub cam_up_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam_up.MouseUp
        cam_view.DecoderControl(1)
    End Sub

    Private Sub cam_down_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam_down.MouseDown
        cam_view.DecoderControl(2)
    End Sub

    Private Sub cam_down_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam_down.MouseUp
        cam_view.DecoderControl(3)
    End Sub

    Private Sub cam_left_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam_left.MouseDown
        cam_view.DecoderControl(6)
    End Sub

    Private Sub cam_left_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam_left.MouseUp
        cam_view.DecoderControl(7)
    End Sub

    Private Sub cam_right_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam_right.MouseDown
        cam_view.DecoderControl(4)
    End Sub

    Private Sub cam_right_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cam_right.MouseUp
        cam_view.DecoderControl(5)
    End Sub

    Private Sub Form1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        detection_routine.Stop()
        SerialPort1.Close()
        cam_view.MonitorDisconnect()
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If SerialPort1.IsOpen Then
            If e.KeyCode = Keys.W Then
                forward()
            ElseIf e.KeyCode = Keys.S Then
                reverse()
            ElseIf e.KeyCode = Keys.A Then
                turn_left()
            ElseIf e.KeyCode = Keys.D Then
                turn_right()
            End If
        End If

        If e.KeyCode = Keys.I Then
            cam_view.DecoderControl(0)
            ElseIf e.KeyCode = Keys.K Then
        cam_view.DecoderControl(2)
            ElseIf e.KeyCode = Keys.J Then
        cam_view.DecoderControl(6)
            ElseIf e.KeyCode = Keys.L Then
            cam_view.DecoderControl(4)
        End If

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If SerialPort1.IsOpen Then
            If e.KeyCode = Keys.W Then
                movement_stop()
            ElseIf e.KeyCode = Keys.S Then
                movement_stop()
            ElseIf e.KeyCode = Keys.A Then
                direction_stop()
            ElseIf e.KeyCode = Keys.D Then
                direction_stop()
            End If
        End If

        If e.KeyCode = Keys.I Then
            cam_view.DecoderControl(1)
        ElseIf e.KeyCode = Keys.K Then
            cam_view.DecoderControl(3)
        ElseIf e.KeyCode = Keys.J Then
            cam_view.DecoderControl(7)
        ElseIf e.KeyCode = Keys.L Then
            cam_view.DecoderControl(5)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        port_connect.Enabled = True
        port_disconnect.Enabled = False
        pc_port = IO.Ports.SerialPort.GetPortNames()
        For i = 0 To UBound(pc_port)
            port_item.Items.Add(pc_port(i))
        Next
    End Sub

    Private Sub port_connect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port_connect.Click
        Me.ProcessTabKey(12)
        Try
            SerialPort1.PortName = port_item.SelectedItem
            SerialPort1.Open()
            port_connect.Enabled = False
            port_disconnect.Enabled = True
            robot_control.Enabled = True
            relay_control.Enabled = True
            metal_status.Enabled = True
            detection_routine.Start()
            port_item.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Cannot Open Port")
        End Try
    End Sub

    Private Sub port_disconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles port_disconnect.Click
        detection_routine.Stop()
        SerialPort1.Close()
        port_connect.Enabled = True
        port_item.Enabled = True
        port_disconnect.Enabled = False
        robot_control.Enabled = False
        relay_control.Enabled = False
        metal_status.Enabled = False
    End Sub
    Private Sub turn_right()
        SerialPort1.Write("4")
    End Sub
    Private Sub turn_left()
        SerialPort1.Write("3")
    End Sub
    Private Sub forward()
        SerialPort1.Write("1")
    End Sub
    Private Sub reverse()
        SerialPort1.Write("2")
    End Sub
    Private Sub movement_stop()
        SerialPort1.Write("5")
    End Sub
    Private Sub direction_stop()
        SerialPort1.Write("6")
    End Sub

    Private Sub robot_forward_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles robot_forward.MouseDown

        forward()
    End Sub

    Private Sub robot_forward_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles robot_forward.MouseUp
        movement_stop()
    End Sub

    Private Sub robot_reverse_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles robot_reverse.MouseDown
        reverse()
    End Sub

    Private Sub robot_reverse_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles robot_reverse.MouseUp
        movement_stop()
    End Sub

    Private Sub robot_right_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles robot_right.MouseDown
        turn_right()
    End Sub

    Private Sub robot_right_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles robot_right.MouseUp
        direction_stop()
    End Sub

    Private Sub robot_left_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles robot_left.MouseDown
        turn_left()
    End Sub

    Private Sub robot_left_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles robot_left.MouseUp
        direction_stop()
    End Sub

    Private Sub relay1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles relay1.CheckedChanged
        If relay1.Checked = True Then
            SerialPort1.Write("a")
        Else
            SerialPort1.Write("b")
        End If
    End Sub

    Private Sub relay2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles relay2.CheckedChanged
        If relay2.Checked = True Then
            SerialPort1.Write("c")
        Else
            SerialPort1.Write("d")
        End If
    End Sub

    Private Sub relay3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles relay3.CheckedChanged
        If relay3.Checked = True Then
            SerialPort1.Write("e")
        Else
            SerialPort1.Write("f")
        End If
    End Sub

    Private Sub detection_routine_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detection_routine.Tick
        data_rx = SerialPort1.ReadExisting
        If data_rx.Contains("A") Then
            metal_indicator.BackColor = Color.Red
            detection_label.Text = "Metal Detected"
        End If
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        metal_indicator.BackColor = Color.ForestGreen
        detection_label.Text = "No Detection"
    End Sub
End Class
