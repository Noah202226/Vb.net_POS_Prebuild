<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        txtPrice = New TextBox()
        txtStock = New TextBox()
        btnAddProduct = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        dgvProducts = New DataGridView()
        txtID = New TextBox()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(185, 121)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(100, 23)
        txtProductName.TabIndex = 0
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(185, 167)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 1
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(185, 208)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(100, 23)
        txtStock.TabIndex = 2
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.Location = New Point(185, 260)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(100, 38)
        btnAddProduct.TabIndex = 3
        btnAddProduct.Text = "Save Product"
        btnAddProduct.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 4
        Label1.Text = "Product Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 15)
        Label2.TabIndex = 5
        Label2.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 6
        Label3.Text = "Stock"
        ' 
        ' dgvProducts
        ' 
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(373, 73)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.Size = New Size(383, 290)
        dgvProducts.TabIndex = 7
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(185, 82)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(100, 23)
        txtID.TabIndex = 8
        ' 
        ' AddProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtID)
        Controls.Add(dgvProducts)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAddProduct)
        Controls.Add(txtStock)
        Controls.Add(txtPrice)
        Controls.Add(txtProductName)
        Name = "AddProduct"
        Text = "AddProduct"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents txtID As TextBox
End Class
