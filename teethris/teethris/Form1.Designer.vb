<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Timer1 = New Timer(components)
        avatar = New PictureBox()
        AAAsnack = New PictureBox()
        enemy2 = New PictureBox()
        enemy = New PictureBox()
        CType(avatar, ComponentModel.ISupportInitialize).BeginInit()
        CType(AAAsnack, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy2, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' avatar
        ' 
        avatar.Image = CType(resources.GetObject("avatar.Image"), Image)
        avatar.Location = New Point(32, 65)
        avatar.Name = "avatar"
        avatar.Size = New Size(163, 144)
        avatar.SizeMode = PictureBoxSizeMode.Zoom
        avatar.TabIndex = 0
        avatar.TabStop = False
        ' 
        ' AAAsnack
        ' 
        AAAsnack.Image = CType(resources.GetObject("AAAsnack.Image"), Image)
        AAAsnack.Location = New Point(382, 36)
        AAAsnack.Name = "AAAsnack"
        AAAsnack.Size = New Size(104, 132)
        AAAsnack.SizeMode = PictureBoxSizeMode.Zoom
        AAAsnack.TabIndex = 1
        AAAsnack.TabStop = False
        ' 
        ' enemy2
        ' 
        enemy2.Image = CType(resources.GetObject("enemy2.Image"), Image)
        enemy2.Location = New Point(539, 235)
        enemy2.Name = "enemy2"
        enemy2.Size = New Size(164, 139)
        enemy2.SizeMode = PictureBoxSizeMode.Zoom
        enemy2.TabIndex = 2
        enemy2.TabStop = False
        ' 
        ' enemy
        ' 
        enemy.Image = CType(resources.GetObject("enemy.Image"), Image)
        enemy.Location = New Point(299, 247)
        enemy.Name = "enemy"
        enemy.Size = New Size(164, 139)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 3
        enemy.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(enemy)
        Controls.Add(enemy2)
        Controls.Add(AAAsnack)
        Controls.Add(avatar)
        Name = "Form1"
        Text = "Form1"
        CType(avatar, ComponentModel.ISupportInitialize).EndInit()
        CType(AAAsnack, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy2, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents avatar As PictureBox
    Friend WithEvents AAAsnack As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents enemy As PictureBox

End Class
