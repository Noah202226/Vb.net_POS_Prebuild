<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProduct
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
        txtProductName = New TextBox()
        txtID = New TextBox()
        txtPrice = New TextBox()
        txtStock = New TextBox()
        btnSave = New Button()
        BtnDelete = New Button()
        SuspendLayout()
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(230, 106)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(100, 23)
        txtProductName.TabIndex = 0
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(230, 68)
        txtID.Name = "txtID"
        txtID.Size = New Size(100, 23)
        txtID.TabIndex = 1
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(350, 214)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 2
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(360, 259)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(589, 169)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(467, 338)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(75, 23)
        BtnDelete.TabIndex = 5
        BtnDelete.Text = "Delete"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' EditProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnDelete)
        Controls.Add(btnSave)
        Controls.Add(txtStock)
        Controls.Add(txtPrice)
        Controls.Add(txtID)
        Controls.Add(txtProductName)
        Name = "EditProduct"
        Text = "EditProduct"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents BtnDelete As Button
End Class
