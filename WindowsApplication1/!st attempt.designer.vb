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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LblShopName = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BtnNewCustomer = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.LblShopAddress = New System.Windows.Forms.Label()
        Me.LblCakePrice1 = New System.Windows.Forms.Label()
        Me.ChbChoclateBase = New System.Windows.Forms.CheckBox()
        Me.LblChocExtra = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboName = New System.Windows.Forms.ComboBox()
        Me.CboCake = New System.Windows.Forms.ComboBox()
        Me.LblExtras = New System.Windows.Forms.Label()
        Me.LblCakePrice = New System.Windows.Forms.Label()
        Me.BtnViewOrders = New System.Windows.Forms.Button()
        Me.BtnSaveOrder = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateOrderedFor = New System.Windows.Forms.DateTimePicker()
        Me.DateOrdered = New System.Windows.Forms.DateTimePicker()
        Me.BtnOrderHelp = New System.Windows.Forms.Button()
        Me.BtnNewCake = New System.Windows.Forms.Button()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblShopName
        '
        Me.LblShopName.AutoSize = True
        Me.LblShopName.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblShopName.Location = New System.Drawing.Point(587, 37)
        Me.LblShopName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblShopName.Name = "LblShopName"
        Me.LblShopName.Size = New System.Drawing.Size(294, 54)
        Me.LblShopName.TabIndex = 4
        Me.LblShopName.Text = "Kellys Cakes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(80, 286)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 17)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Customer"
        '
        'BtnNewCustomer
        '
        Me.BtnNewCustomer.Location = New System.Drawing.Point(655, 475)
        Me.BtnNewCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewCustomer.Name = "BtnNewCustomer"
        Me.BtnNewCustomer.Size = New System.Drawing.Size(259, 38)
        Me.BtnNewCustomer.TabIndex = 31
        Me.BtnNewCustomer.Text = "New Customer"
        Me.BtnNewCustomer.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(85, 329)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 17)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Cake"
        '
        'PicLogo
        '
        Me.PicLogo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(16, 15)
        Me.PicLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(383, 176)
        Me.PicLogo.TabIndex = 34
        Me.PicLogo.TabStop = False
        '
        'LblShopAddress
        '
        Me.LblShopAddress.AutoSize = True
        Me.LblShopAddress.Location = New System.Drawing.Point(560, 103)
        Me.LblShopAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblShopAddress.Name = "LblShopAddress"
        Me.LblShopAddress.Size = New System.Drawing.Size(347, 17)
        Me.LblShopAddress.TabIndex = 36
        Me.LblShopAddress.Text = "23 Meadow Road, Treeville, Applehampton, AH9 4GH"
        '
        'LblCakePrice1
        '
        Me.LblCakePrice1.AutoSize = True
        Me.LblCakePrice1.Location = New System.Drawing.Point(452, 338)
        Me.LblCakePrice1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCakePrice1.Name = "LblCakePrice1"
        Me.LblCakePrice1.Size = New System.Drawing.Size(24, 17)
        Me.LblCakePrice1.TabIndex = 37
        Me.LblCakePrice1.Text = "£0"
        '
        'ChbChoclateBase
        '
        Me.ChbChoclateBase.AutoSize = True
        Me.ChbChoclateBase.Location = New System.Drawing.Point(92, 383)
        Me.ChbChoclateBase.Margin = New System.Windows.Forms.Padding(4)
        Me.ChbChoclateBase.Name = "ChbChoclateBase"
        Me.ChbChoclateBase.Size = New System.Drawing.Size(129, 21)
        Me.ChbChoclateBase.TabIndex = 38
        Me.ChbChoclateBase.Text = "Chocolate Base"
        Me.ChbChoclateBase.UseVisualStyleBackColor = True
        '
        'LblChocExtra
        '
        Me.LblChocExtra.AutoSize = True
        Me.LblChocExtra.Location = New System.Drawing.Point(268, 388)
        Me.LblChocExtra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblChocExtra.Name = "LblChocExtra"
        Me.LblChocExtra.Size = New System.Drawing.Size(68, 17)
        Me.LblChocExtra.TabIndex = 39
        Me.LblChocExtra.Text = "£10 Extra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 443)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Cake Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 475)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 17)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Extras Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 507)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Total Price"
        '
        'CboName
        '
        Me.CboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboName.FormattingEnabled = True
        Me.CboName.Location = New System.Drawing.Point(184, 286)
        Me.CboName.Margin = New System.Windows.Forms.Padding(4)
        Me.CboName.Name = "CboName"
        Me.CboName.Size = New System.Drawing.Size(215, 24)
        Me.CboName.TabIndex = 43
        '
        'CboCake
        '
        Me.CboCake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCake.FormattingEnabled = True
        Me.CboCake.Location = New System.Drawing.Point(184, 329)
        Me.CboCake.Margin = New System.Windows.Forms.Padding(4)
        Me.CboCake.Name = "CboCake"
        Me.CboCake.Size = New System.Drawing.Size(213, 24)
        Me.CboCake.TabIndex = 44
        '
        'LblExtras
        '
        Me.LblExtras.AutoSize = True
        Me.LblExtras.BackColor = System.Drawing.SystemColors.Control
        Me.LblExtras.Location = New System.Drawing.Point(209, 475)
        Me.LblExtras.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblExtras.Name = "LblExtras"
        Me.LblExtras.Size = New System.Drawing.Size(24, 17)
        Me.LblExtras.TabIndex = 45
        Me.LblExtras.Text = "£0"
        '
        'LblCakePrice
        '
        Me.LblCakePrice.AutoSize = True
        Me.LblCakePrice.Location = New System.Drawing.Point(209, 443)
        Me.LblCakePrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCakePrice.Name = "LblCakePrice"
        Me.LblCakePrice.Size = New System.Drawing.Size(24, 17)
        Me.LblCakePrice.TabIndex = 47
        Me.LblCakePrice.Text = "£0"
        '
        'BtnViewOrders
        '
        Me.BtnViewOrders.Location = New System.Drawing.Point(655, 542)
        Me.BtnViewOrders.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnViewOrders.Name = "BtnViewOrders"
        Me.BtnViewOrders.Size = New System.Drawing.Size(259, 39)
        Me.BtnViewOrders.TabIndex = 48
        Me.BtnViewOrders.Text = "View Orders"
        Me.BtnViewOrders.UseVisualStyleBackColor = True
        '
        'BtnSaveOrder
        '
        Me.BtnSaveOrder.Location = New System.Drawing.Point(92, 592)
        Me.BtnSaveOrder.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSaveOrder.Name = "BtnSaveOrder"
        Me.BtnSaveOrder.Size = New System.Drawing.Size(275, 50)
        Me.BtnSaveOrder.TabIndex = 49
        Me.BtnSaveOrder.Text = "Save Order"
        Me.BtnSaveOrder.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(209, 507)
        Me.LblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(24, 17)
        Me.LblTotal.TabIndex = 46
        Me.LblTotal.Text = "£0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 255)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Date Ordered"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(753, 255)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Date Ordered For"
        '
        'DateOrderedFor
        '
        Me.DateOrderedFor.Location = New System.Drawing.Point(757, 287)
        Me.DateOrderedFor.Margin = New System.Windows.Forms.Padding(4)
        Me.DateOrderedFor.MinDate = New Date(2011, 1, 28, 0, 0, 0, 0)
        Me.DateOrderedFor.Name = "DateOrderedFor"
        Me.DateOrderedFor.Size = New System.Drawing.Size(141, 22)
        Me.DateOrderedFor.TabIndex = 54
        Me.DateOrderedFor.Value = New Date(2011, 1, 28, 0, 0, 0, 0)
        '
        'DateOrdered
        '
        Me.DateOrdered.Location = New System.Drawing.Point(537, 287)
        Me.DateOrdered.Margin = New System.Windows.Forms.Padding(4)
        Me.DateOrdered.Name = "DateOrdered"
        Me.DateOrdered.Size = New System.Drawing.Size(151, 22)
        Me.DateOrdered.TabIndex = 55
        Me.DateOrdered.Value = New Date(2011, 1, 28, 0, 0, 0, 0)
        '
        'BtnOrderHelp
        '
        Me.BtnOrderHelp.Location = New System.Drawing.Point(655, 608)
        Me.BtnOrderHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnOrderHelp.Name = "BtnOrderHelp"
        Me.BtnOrderHelp.Size = New System.Drawing.Size(257, 50)
        Me.BtnOrderHelp.TabIndex = 56
        Me.BtnOrderHelp.Text = "Click here for help"
        Me.BtnOrderHelp.UseVisualStyleBackColor = True
        '
        'BtnNewCake
        '
        Me.BtnNewCake.Location = New System.Drawing.Point(653, 409)
        Me.BtnNewCake.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewCake.Name = "BtnNewCake"
        Me.BtnNewCake.Size = New System.Drawing.Size(259, 38)
        Me.BtnNewCake.TabIndex = 57
        Me.BtnNewCake.Text = "New Cake"
        Me.BtnNewCake.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 704)
        Me.Controls.Add(Me.BtnNewCake)
        Me.Controls.Add(Me.BtnOrderHelp)
        Me.Controls.Add(Me.DateOrdered)
        Me.Controls.Add(Me.DateOrderedFor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSaveOrder)
        Me.Controls.Add(Me.BtnViewOrders)
        Me.Controls.Add(Me.LblCakePrice)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.LblExtras)
        Me.Controls.Add(Me.CboCake)
        Me.Controls.Add(Me.CboName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblChocExtra)
        Me.Controls.Add(Me.ChbChoclateBase)
        Me.Controls.Add(Me.LblCakePrice1)
        Me.Controls.Add(Me.LblShopAddress)
        Me.Controls.Add(Me.PicLogo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.BtnNewCustomer)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LblShopName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblShopName As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents BtnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents LblShopAddress As System.Windows.Forms.Label
    Friend WithEvents LblCakePrice1 As System.Windows.Forms.Label
    Friend WithEvents ChbChoclateBase As System.Windows.Forms.CheckBox
    Friend WithEvents LblChocExtra As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CboName As System.Windows.Forms.ComboBox
    Friend WithEvents CboCake As System.Windows.Forms.ComboBox
    Friend WithEvents LblExtras As System.Windows.Forms.Label
    Friend WithEvents LblCakePrice As System.Windows.Forms.Label
    Friend WithEvents BtnViewOrders As System.Windows.Forms.Button
    Friend WithEvents BtnSaveOrder As System.Windows.Forms.Button
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateOrderedFor As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateOrdered As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnOrderHelp As System.Windows.Forms.Button
    Friend WithEvents BtnNewCake As System.Windows.Forms.Button

End Class
