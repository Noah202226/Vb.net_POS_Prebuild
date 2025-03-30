<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        dgvAccounts = New DataGridView()
        Label2 = New Label()
        Label1 = New Label()
        btnAddProduct = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label3 = New Label()
        cbxAccountType = New ComboBox()
        Label4 = New Label()
        CType(dgvAccounts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAccounts
        ' 
        dgvAccounts.AllowUserToAddRows = False
        dgvAccounts.AllowUserToDeleteRows = False
        dgvAccounts.AllowUserToOrderColumns = True
        dgvAccounts.BorderStyle = BorderStyle.None
        dgvAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAccounts.Cursor = Cursors.Hand
        dgvAccounts.Location = New Point(358, 80)
        dgvAccounts.MultiSelect = False
        dgvAccounts.Name = "dgvAccounts"
        dgvAccounts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAccounts.Size = New Size(383, 290)
        dgvAccounts.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(59, 182)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 14
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 131)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 13
        Label1.Text = "Username"
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Location = New Point(170, 267)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(121, 38)
        btnAddProduct.TabIndex = 12
        btnAddProduct.Text = "Save New Account"
        btnAddProduct.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(170, 174)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(121, 23)
        txtPassword.TabIndex = 10
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(170, 128)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(121, 23)
        txtUsername.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(59, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 18
        Label3.Text = "Accounts"
        ' 
        ' cbxAccountType
        ' 
        cbxAccountType.DropDownStyle = ComboBoxStyle.DropDownList
        cbxAccountType.FormattingEnabled = True
        cbxAccountType.Items.AddRange(New Object() {"User", "Admin"})
        cbxAccountType.Location = New Point(170, 222)
        cbxAccountType.Name = "cbxAccountType"
        cbxAccountType.Size = New Size(121, 23)
        cbxAccountType.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 20
        Label4.Text = "Account Type"
        ' 
        ' Accounts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(cbxAccountType)
        Controls.Add(Label3)
        Controls.Add(dgvAccounts)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAddProduct)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "Accounts"
        Text = "Accounts"
        CType(dgvAccounts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgvAccounts As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxAccountType As ComboBox
    Friend WithEvents Label4 As Label
End Class
