<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cam_view = New AxDVM_IPCAMLib.AxDVM_IPCam()
        Me.connect_cam = New System.Windows.Forms.Button()
        Me.ip_box = New System.Windows.Forms.TextBox()
        Me.ip_label = New System.Windows.Forms.Label()
        Me.cam_control = New System.Windows.Forms.GroupBox()
        Me.cam_right = New System.Windows.Forms.PictureBox()
        Me.cam_left = New System.Windows.Forms.PictureBox()
        Me.cam_down = New System.Windows.Forms.PictureBox()
        Me.cam_up = New System.Windows.Forms.PictureBox()
        Me.disconnect_cam = New System.Windows.Forms.Button()
        Me.robot_control = New System.Windows.Forms.GroupBox()
        Me.robot_right = New System.Windows.Forms.PictureBox()
        Me.robot_left = New System.Windows.Forms.PictureBox()
        Me.robot_reverse = New System.Windows.Forms.PictureBox()
        Me.robot_forward = New System.Windows.Forms.PictureBox()
        Me.com_setting = New System.Windows.Forms.GroupBox()
        Me.port_disconnect = New System.Windows.Forms.Button()
        Me.port_connect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.port_item = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.metal_status = New System.Windows.Forms.GroupBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.detection_label = New System.Windows.Forms.Label()
        Me.metal_indicator = New System.Windows.Forms.PictureBox()
        Me.relay1 = New System.Windows.Forms.CheckBox()
        Me.relay2 = New System.Windows.Forms.CheckBox()
        Me.relay3 = New System.Windows.Forms.CheckBox()
        Me.relay_control = New System.Windows.Forms.GroupBox()
        Me.detection_routine = New System.Windows.Forms.Timer(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.cam_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cam_control.SuspendLayout()
        CType(Me.cam_right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cam_left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cam_down, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cam_up, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.robot_control.SuspendLayout()
        CType(Me.robot_right, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.robot_left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.robot_reverse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.robot_forward, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.com_setting.SuspendLayout()
        Me.metal_status.SuspendLayout()
        CType(Me.metal_indicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.relay_control.SuspendLayout()
        Me.SuspendLayout()
        '
        'cam_view
        '
        resources.ApplyResources(Me.cam_view, "cam_view")
        Me.cam_view.Name = "cam_view"
        Me.cam_view.OcxState = CType(resources.GetObject("cam_view.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'connect_cam
        '
        resources.ApplyResources(Me.connect_cam, "connect_cam")
        Me.connect_cam.Name = "connect_cam"
        Me.connect_cam.UseVisualStyleBackColor = True
        '
        'ip_box
        '
        resources.ApplyResources(Me.ip_box, "ip_box")
        Me.ip_box.Name = "ip_box"
        '
        'ip_label
        '
        resources.ApplyResources(Me.ip_label, "ip_label")
        Me.ip_label.Name = "ip_label"
        '
        'cam_control
        '
        Me.cam_control.Controls.Add(Me.cam_right)
        Me.cam_control.Controls.Add(Me.cam_left)
        Me.cam_control.Controls.Add(Me.cam_down)
        Me.cam_control.Controls.Add(Me.cam_up)
        resources.ApplyResources(Me.cam_control, "cam_control")
        Me.cam_control.Name = "cam_control"
        Me.cam_control.TabStop = False
        '
        'cam_right
        '
        Me.cam_right.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.cam_right, "cam_right")
        Me.cam_right.Name = "cam_right"
        Me.cam_right.TabStop = False
        '
        'cam_left
        '
        Me.cam_left.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.cam_left, "cam_left")
        Me.cam_left.Name = "cam_left"
        Me.cam_left.TabStop = False
        '
        'cam_down
        '
        Me.cam_down.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.cam_down, "cam_down")
        Me.cam_down.Name = "cam_down"
        Me.cam_down.TabStop = False
        '
        'cam_up
        '
        Me.cam_up.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.cam_up, "cam_up")
        Me.cam_up.Name = "cam_up"
        Me.cam_up.TabStop = False
        '
        'disconnect_cam
        '
        resources.ApplyResources(Me.disconnect_cam, "disconnect_cam")
        Me.disconnect_cam.Name = "disconnect_cam"
        Me.disconnect_cam.UseVisualStyleBackColor = True
        '
        'robot_control
        '
        Me.robot_control.Controls.Add(Me.robot_right)
        Me.robot_control.Controls.Add(Me.robot_left)
        Me.robot_control.Controls.Add(Me.robot_reverse)
        Me.robot_control.Controls.Add(Me.robot_forward)
        resources.ApplyResources(Me.robot_control, "robot_control")
        Me.robot_control.Name = "robot_control"
        Me.robot_control.TabStop = False
        '
        'robot_right
        '
        Me.robot_right.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.robot_right, "robot_right")
        Me.robot_right.Name = "robot_right"
        Me.robot_right.TabStop = False
        '
        'robot_left
        '
        Me.robot_left.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.robot_left, "robot_left")
        Me.robot_left.Name = "robot_left"
        Me.robot_left.TabStop = False
        '
        'robot_reverse
        '
        Me.robot_reverse.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.robot_reverse, "robot_reverse")
        Me.robot_reverse.Name = "robot_reverse"
        Me.robot_reverse.TabStop = False
        '
        'robot_forward
        '
        Me.robot_forward.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.robot_forward, "robot_forward")
        Me.robot_forward.Name = "robot_forward"
        Me.robot_forward.TabStop = False
        '
        'com_setting
        '
        Me.com_setting.Controls.Add(Me.port_disconnect)
        Me.com_setting.Controls.Add(Me.port_connect)
        Me.com_setting.Controls.Add(Me.Label1)
        Me.com_setting.Controls.Add(Me.port_item)
        resources.ApplyResources(Me.com_setting, "com_setting")
        Me.com_setting.Name = "com_setting"
        Me.com_setting.TabStop = False
        '
        'port_disconnect
        '
        resources.ApplyResources(Me.port_disconnect, "port_disconnect")
        Me.port_disconnect.Name = "port_disconnect"
        Me.port_disconnect.UseVisualStyleBackColor = True
        '
        'port_connect
        '
        resources.ApplyResources(Me.port_connect, "port_connect")
        Me.port_connect.Name = "port_connect"
        Me.port_connect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'port_item
        '
        Me.port_item.FormattingEnabled = True
        resources.ApplyResources(Me.port_item, "port_item")
        Me.port_item.Name = "port_item"
        '
        'metal_status
        '
        Me.metal_status.Controls.Add(Me.clear)
        Me.metal_status.Controls.Add(Me.detection_label)
        Me.metal_status.Controls.Add(Me.metal_indicator)
        resources.ApplyResources(Me.metal_status, "metal_status")
        Me.metal_status.Name = "metal_status"
        Me.metal_status.TabStop = False
        '
        'clear
        '
        resources.ApplyResources(Me.clear, "clear")
        Me.clear.Name = "clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'detection_label
        '
        resources.ApplyResources(Me.detection_label, "detection_label")
        Me.detection_label.BackColor = System.Drawing.Color.Transparent
        Me.detection_label.ForeColor = System.Drawing.Color.Black
        Me.detection_label.Name = "detection_label"
        '
        'metal_indicator
        '
        Me.metal_indicator.BackColor = System.Drawing.Color.ForestGreen
        resources.ApplyResources(Me.metal_indicator, "metal_indicator")
        Me.metal_indicator.Name = "metal_indicator"
        Me.metal_indicator.TabStop = False
        '
        'relay1
        '
        resources.ApplyResources(Me.relay1, "relay1")
        Me.relay1.Name = "relay1"
        Me.relay1.UseVisualStyleBackColor = True
        '
        'relay2
        '
        resources.ApplyResources(Me.relay2, "relay2")
        Me.relay2.Name = "relay2"
        Me.relay2.UseVisualStyleBackColor = True
        '
        'relay3
        '
        resources.ApplyResources(Me.relay3, "relay3")
        Me.relay3.Name = "relay3"
        Me.relay3.UseVisualStyleBackColor = True
        '
        'relay_control
        '
        Me.relay_control.Controls.Add(Me.relay3)
        Me.relay_control.Controls.Add(Me.relay2)
        Me.relay_control.Controls.Add(Me.relay1)
        resources.ApplyResources(Me.relay_control, "relay_control")
        Me.relay_control.Name = "relay_control"
        Me.relay_control.TabStop = False
        '
        'detection_routine
        '
        Me.detection_routine.Interval = 200
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.relay_control)
        Me.Controls.Add(Me.metal_status)
        Me.Controls.Add(Me.com_setting)
        Me.Controls.Add(Me.robot_control)
        Me.Controls.Add(Me.disconnect_cam)
        Me.Controls.Add(Me.cam_control)
        Me.Controls.Add(Me.ip_label)
        Me.Controls.Add(Me.ip_box)
        Me.Controls.Add(Me.connect_cam)
        Me.Controls.Add(Me.cam_view)
        Me.Controls.Add(Me.CheckBox1)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        CType(Me.cam_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cam_control.ResumeLayout(False)
        CType(Me.cam_right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cam_left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cam_down, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cam_up, System.ComponentModel.ISupportInitialize).EndInit()
        Me.robot_control.ResumeLayout(False)
        CType(Me.robot_right, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.robot_left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.robot_reverse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.robot_forward, System.ComponentModel.ISupportInitialize).EndInit()
        Me.com_setting.ResumeLayout(False)
        Me.com_setting.PerformLayout()
        Me.metal_status.ResumeLayout(False)
        Me.metal_status.PerformLayout()
        CType(Me.metal_indicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.relay_control.ResumeLayout(False)
        Me.relay_control.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cam_view As AxDVM_IPCAMLib.AxDVM_IPCam
    Friend WithEvents connect_cam As System.Windows.Forms.Button
    Friend WithEvents ip_box As System.Windows.Forms.TextBox
    Friend WithEvents ip_label As System.Windows.Forms.Label
    Friend WithEvents cam_control As System.Windows.Forms.GroupBox
    Friend WithEvents cam_up As System.Windows.Forms.PictureBox
    Friend WithEvents cam_right As System.Windows.Forms.PictureBox
    Friend WithEvents cam_left As System.Windows.Forms.PictureBox
    Friend WithEvents cam_down As System.Windows.Forms.PictureBox
    Friend WithEvents disconnect_cam As System.Windows.Forms.Button
    Friend WithEvents robot_control As System.Windows.Forms.GroupBox
    Friend WithEvents robot_right As System.Windows.Forms.PictureBox
    Friend WithEvents robot_left As System.Windows.Forms.PictureBox
    Friend WithEvents robot_reverse As System.Windows.Forms.PictureBox
    Friend WithEvents robot_forward As System.Windows.Forms.PictureBox
    Friend WithEvents com_setting As System.Windows.Forms.GroupBox
    Friend WithEvents port_disconnect As System.Windows.Forms.Button
    Friend WithEvents port_connect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents port_item As System.Windows.Forms.ComboBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents metal_status As System.Windows.Forms.GroupBox
    Friend WithEvents relay3 As System.Windows.Forms.CheckBox
    Friend WithEvents relay1 As System.Windows.Forms.CheckBox
    Friend WithEvents relay2 As System.Windows.Forms.CheckBox
    Friend WithEvents metal_indicator As System.Windows.Forms.PictureBox
    Friend WithEvents relay_control As System.Windows.Forms.GroupBox
    Friend WithEvents detection_label As System.Windows.Forms.Label
    Friend WithEvents detection_routine As System.Windows.Forms.Timer
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
