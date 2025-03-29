<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        gbxOrderList = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        txtTotalAmount = New TextBox()
        Label1 = New Label()
        txtBarcode = New TextBox()
        Label2 = New Label()
        gbxNumpad = New GroupBox()
        Button13 = New Button()
        Button14 = New Button()
        Button15 = New Button()
        Button10 = New Button()
        Button11 = New Button()
        Button12 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        gbxNumpad.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbxOrderList
        ' 
        gbxOrderList.BackColor = Color.Transparent
        gbxOrderList.Cursor = Cursors.Hand
        gbxOrderList.FlatStyle = FlatStyle.Flat
        gbxOrderList.Location = New Point(40, 91)
        gbxOrderList.Name = "gbxOrderList"
        gbxOrderList.Size = New Size(628, 539)
        gbxOrderList.TabIndex = 0
        gbxOrderList.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(1279, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(286, 20)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 189)
        Button2.TabIndex = 3
        Button2.Text = "Settings"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotalAmount.Location = New Point(489, 636)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.ReadOnly = True
        txtTotalAmount.RightToLeft = RightToLeft.Yes
        txtTotalAmount.Size = New Size(179, 29)
        txtTotalAmount.TabIndex = 4
        txtTotalAmount.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(393, 650)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 5
        Label1.Text = "Total Amount"
        ' 
        ' txtBarcode
        ' 
        txtBarcode.Font = New Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtBarcode.Location = New Point(40, 693)
        txtBarcode.Name = "txtBarcode"
        txtBarcode.ReadOnly = True
        txtBarcode.Size = New Size(628, 29)
        txtBarcode.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 675)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 7
        Label2.Text = "BARCODE:"
        ' 
        ' gbxNumpad
        ' 
        gbxNumpad.Controls.Add(Button13)
        gbxNumpad.Controls.Add(Button14)
        gbxNumpad.Controls.Add(Button15)
        gbxNumpad.Controls.Add(Button10)
        gbxNumpad.Controls.Add(Button11)
        gbxNumpad.Controls.Add(Button2)
        gbxNumpad.Controls.Add(Button12)
        gbxNumpad.Controls.Add(Button7)
        gbxNumpad.Controls.Add(Button8)
        gbxNumpad.Controls.Add(Button9)
        gbxNumpad.Controls.Add(Button6)
        gbxNumpad.Controls.Add(Button5)
        gbxNumpad.Controls.Add(Button4)
        gbxNumpad.Controls.Add(Button3)
        gbxNumpad.Location = New Point(699, 429)
        gbxNumpad.Name = "gbxNumpad"
        gbxNumpad.Size = New Size(384, 293)
        gbxNumpad.TabIndex = 8
        gbxNumpad.TabStop = False
        gbxNumpad.Text = "Numpad"
        ' 
        ' Button13
        ' 
        Button13.Location = New Point(195, 20)
        Button13.Name = "Button13"
        Button13.Size = New Size(85, 59)
        Button13.TabIndex = 12
        Button13.Text = "Void"
        Button13.UseVisualStyleBackColor = True
        ' 
        ' Button14
        ' 
        Button14.Location = New Point(104, 20)
        Button14.Name = "Button14"
        Button14.Size = New Size(85, 59)
        Button14.TabIndex = 11
        Button14.Text = "Discount"
        Button14.UseVisualStyleBackColor = True
        ' 
        ' Button15
        ' 
        Button15.Location = New Point(13, 20)
        Button15.Name = "Button15"
        Button15.Size = New Size(85, 59)
        Button15.TabIndex = 10
        Button15.Text = "9"
        Button15.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(195, 85)
        Button10.Name = "Button10"
        Button10.Size = New Size(85, 59)
        Button10.TabIndex = 9
        Button10.Text = "8"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' Button11
        ' 
        Button11.Location = New Point(104, 85)
        Button11.Name = "Button11"
        Button11.Size = New Size(85, 59)
        Button11.TabIndex = 8
        Button11.Text = "7"
        Button11.UseVisualStyleBackColor = True
        ' 
        ' Button12
        ' 
        Button12.Location = New Point(13, 85)
        Button12.Name = "Button12"
        Button12.Size = New Size(85, 59)
        Button12.TabIndex = 7
        Button12.Text = "6"
        Button12.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(195, 150)
        Button7.Name = "Button7"
        Button7.Size = New Size(85, 59)
        Button7.TabIndex = 6
        Button7.Text = "5"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(104, 150)
        Button8.Name = "Button8"
        Button8.Size = New Size(85, 59)
        Button8.TabIndex = 5
        Button8.Text = "4"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(13, 150)
        Button9.Name = "Button9"
        Button9.Size = New Size(85, 59)
        Button9.TabIndex = 4
        Button9.Text = "3"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(195, 215)
        Button6.Name = "Button6"
        Button6.Size = New Size(85, 59)
        Button6.TabIndex = 3
        Button6.Text = "2"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(104, 215)
        Button5.Name = "Button5"
        Button5.Size = New Size(85, 59)
        Button5.TabIndex = 2
        Button5.Text = "1"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(13, 215)
        Button4.Name = "Button4"
        Button4.Size = New Size(85, 59)
        Button4.TabIndex = 1
        Button4.Text = "0"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(286, 215)
        Button3.Name = "Button3"
        Button3.Size = New Size(85, 59)
        Button3.TabIndex = 0
        Button3.Text = "CLR"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1366, 768)
        Controls.Add(gbxNumpad)
        Controls.Add(Label2)
        Controls.Add(txtBarcode)
        Controls.Add(Label1)
        Controls.Add(txtTotalAmount)
        Controls.Add(Button1)
        Controls.Add(gbxOrderList)
        FormBorderStyle = FormBorderStyle.None
        Name = "Main"
        Text = "Main"
        gbxNumpad.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gbxOrderList As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbxNumpad As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
