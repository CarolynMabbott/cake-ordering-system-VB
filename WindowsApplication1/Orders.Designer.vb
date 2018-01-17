<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnViewOrders = New System.Windows.Forms.Button
        Me.BtnOrdersCancel = New System.Windows.Forms.Button
        Me.LstOrders = New System.Windows.Forms.ListBox
        Me.BtnViewHelp = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(226, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orders"
        '
        'BtnViewOrders
        '
        Me.BtnViewOrders.Location = New System.Drawing.Point(12, 567)
        Me.BtnViewOrders.Name = "BtnViewOrders"
        Me.BtnViewOrders.Size = New System.Drawing.Size(168, 75)
        Me.BtnViewOrders.TabIndex = 2
        Me.BtnViewOrders.Text = "View Orders"
        Me.BtnViewOrders.UseVisualStyleBackColor = True
        '
        'BtnOrdersCancel
        '
        Me.BtnOrdersCancel.Location = New System.Drawing.Point(236, 567)
        Me.BtnOrdersCancel.Name = "BtnOrdersCancel"
        Me.BtnOrdersCancel.Size = New System.Drawing.Size(168, 75)
        Me.BtnOrdersCancel.TabIndex = 3
        Me.BtnOrdersCancel.Text = "Cancel"
        Me.BtnOrdersCancel.UseVisualStyleBackColor = True
        '
        'LstOrders
        '
        Me.LstOrders.FormattingEnabled = True
        Me.LstOrders.Location = New System.Drawing.Point(54, 68)
        Me.LstOrders.Name = "LstOrders"
        Me.LstOrders.Size = New System.Drawing.Size(554, 446)
        Me.LstOrders.TabIndex = 5
        '
        'BtnViewHelp
        '
        Me.BtnViewHelp.Location = New System.Drawing.Point(440, 567)
        Me.BtnViewHelp.Name = "BtnViewHelp"
        Me.BtnViewHelp.Size = New System.Drawing.Size(168, 75)
        Me.BtnViewHelp.TabIndex = 6
        Me.BtnViewHelp.Text = "Click here for help"
        Me.BtnViewHelp.UseVisualStyleBackColor = True
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 667)
        Me.Controls.Add(Me.BtnViewHelp)
        Me.Controls.Add(Me.LstOrders)
        Me.Controls.Add(Me.BtnOrdersCancel)
        Me.Controls.Add(Me.BtnViewOrders)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Orders"
        Me.Text = "Orders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnViewOrders As System.Windows.Forms.Button
    Friend WithEvents BtnOrdersCancel As System.Windows.Forms.Button
    Friend WithEvents LstOrders As System.Windows.Forms.ListBox
    Friend WithEvents BtnViewHelp As System.Windows.Forms.Button
End Class
