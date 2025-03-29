<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        BtnChangeLogo = New Button()
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Yu Gothic UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(418, 214)
        Label1.Name = "Label1"
        Label1.Size = New Size(637, 86)
        Label1.TabIndex = 0
        Label1.Text = "YOUR POS PARTNER"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.OrangeRed
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderColor = Color.Maroon
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatAppearance.MouseDownBackColor = Color.Firebrick
        Button1.FlatAppearance.MouseOverBackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(1304, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(50, 28)
        Button1.TabIndex = 1
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.Location = New Point(1236, 704)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 23)
        Button2.TabIndex = 2
        Button2.Text = "Test Print"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' BtnChangeLogo
        ' 
        BtnChangeLogo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        BtnChangeLogo.Location = New Point(1236, 733)
        BtnChangeLogo.Name = "BtnChangeLogo"
        BtnChangeLogo.Size = New Size(118, 23)
        BtnChangeLogo.TabIndex = 3
        BtnChangeLogo.Text = "Change Logo"
        BtnChangeLogo.UseVisualStyleBackColor = True
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtUser.Location = New Point(429, 337)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "Username"
        txtUser.Size = New Size(590, 35)
        txtUser.TabIndex = 4
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPass.Location = New Point(429, 395)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.PlaceholderText = "Password"
        txtPass.Size = New Size(590, 35)
        txtPass.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogin.BackColor = Color.Lime
        btnLogin.FlatAppearance.MouseDownBackColor = Color.Cyan
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.Maroon
        btnLogin.Location = New Point(931, 464)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(88, 37)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Login ->"
        btnLogin.UseVisualStyleBackColor = False
        btnLogin.Visible = False
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button3.Location = New Point(1117, 704)
        Button3.Name = "Button3"
        Button3.Size = New Size(111, 52)
        Button3.TabIndex = 7
        Button3.Text = "Check Connection"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        ClientSize = New Size(1366, 768)
        Controls.Add(Button3)
        Controls.Add(btnLogin)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(BtnChangeLogo)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "POS TEMPLATE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnChangeLogo As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button3 As Button

End Class
