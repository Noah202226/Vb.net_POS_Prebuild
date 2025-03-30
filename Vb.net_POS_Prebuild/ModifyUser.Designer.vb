<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyUser
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
        Button1 = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnUpdate = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(713, 84)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Cancel"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(385, 160)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 23)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(385, 189)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 23)
        txtPassword.TabIndex = 2
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(410, 277)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(491, 277)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ModifyUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Button1)
        Name = "ModifyUser"
        Text = "ModifyUser"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
End Class
