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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.partDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.partIdentifierTextBox = New System.Windows.Forms.TextBox()
        Me.partDescriptionLable = New System.Windows.Forms.Label()
        Me.partIdentifierLable = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.retailPriceTextBox = New System.Windows.Forms.TextBox()
        Me.WholeSaleCostTextBox = New System.Windows.Forms.TextBox()
        Me.netProfitTextBox = New System.Windows.Forms.TextBox()
        Me.storageChargesTextBox = New System.Windows.Forms.TextBox()
        Me.GrossPriceTextBox = New System.Windows.Forms.TextBox()
        Me.qualityTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.computeButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.totalNetProfitButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.partDescriptionTextBox)
        Me.GroupBox1.Controls.Add(Me.partIdentifierTextBox)
        Me.GroupBox1.Controls.Add(Me.partDescriptionLable)
        Me.GroupBox1.Controls.Add(Me.partIdentifierLable)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Part Information"
        '
        'partDescriptionTextBox
        '
        Me.partDescriptionTextBox.Location = New System.Drawing.Point(119, 79)
        Me.partDescriptionTextBox.Name = "partDescriptionTextBox"
        Me.partDescriptionTextBox.Size = New System.Drawing.Size(429, 20)
        Me.partDescriptionTextBox.TabIndex = 3
        '
        'partIdentifierTextBox
        '
        Me.partIdentifierTextBox.Location = New System.Drawing.Point(119, 32)
        Me.partIdentifierTextBox.Name = "partIdentifierTextBox"
        Me.partIdentifierTextBox.Size = New System.Drawing.Size(429, 20)
        Me.partIdentifierTextBox.TabIndex = 2
        '
        'partDescriptionLable
        '
        Me.partDescriptionLable.AutoSize = True
        Me.partDescriptionLable.Location = New System.Drawing.Point(20, 86)
        Me.partDescriptionLable.Name = "partDescriptionLable"
        Me.partDescriptionLable.Size = New System.Drawing.Size(82, 13)
        Me.partDescriptionLable.TabIndex = 1
        Me.partDescriptionLable.Text = "Part Description"
        '
        'partIdentifierLable
        '
        Me.partIdentifierLable.AutoSize = True
        Me.partIdentifierLable.Location = New System.Drawing.Point(20, 32)
        Me.partIdentifierLable.Name = "partIdentifierLable"
        Me.partIdentifierLable.Size = New System.Drawing.Size(69, 13)
        Me.partIdentifierLable.TabIndex = 0
        Me.partIdentifierLable.Text = "Part Identifier"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.retailPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.WholeSaleCostTextBox)
        Me.GroupBox2.Controls.Add(Me.netProfitTextBox)
        Me.GroupBox2.Controls.Add(Me.storageChargesTextBox)
        Me.GroupBox2.Controls.Add(Me.GrossPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.qualityTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 173)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(602, 265)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Price, Cost, Storage, Profit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Quality"
        '
        'retailPriceTextBox
        '
        Me.retailPriceTextBox.Location = New System.Drawing.Point(119, 30)
        Me.retailPriceTextBox.Name = "retailPriceTextBox"
        Me.retailPriceTextBox.Size = New System.Drawing.Size(429, 20)
        Me.retailPriceTextBox.TabIndex = 11
        '
        'WholeSaleCostTextBox
        '
        Me.WholeSaleCostTextBox.Location = New System.Drawing.Point(119, 64)
        Me.WholeSaleCostTextBox.Name = "WholeSaleCostTextBox"
        Me.WholeSaleCostTextBox.Size = New System.Drawing.Size(429, 20)
        Me.WholeSaleCostTextBox.TabIndex = 10
        '
        'netProfitTextBox
        '
        Me.netProfitTextBox.Location = New System.Drawing.Point(119, 219)
        Me.netProfitTextBox.Name = "netProfitTextBox"
        Me.netProfitTextBox.Size = New System.Drawing.Size(429, 20)
        Me.netProfitTextBox.TabIndex = 9
        Me.netProfitTextBox.TabStop = False
        '
        'storageChargesTextBox
        '
        Me.storageChargesTextBox.Location = New System.Drawing.Point(119, 183)
        Me.storageChargesTextBox.Name = "storageChargesTextBox"
        Me.storageChargesTextBox.Size = New System.Drawing.Size(429, 20)
        Me.storageChargesTextBox.TabIndex = 8
        Me.storageChargesTextBox.TabStop = False
        '
        'GrossPriceTextBox
        '
        Me.GrossPriceTextBox.Location = New System.Drawing.Point(119, 146)
        Me.GrossPriceTextBox.Name = "GrossPriceTextBox"
        Me.GrossPriceTextBox.ReadOnly = True
        Me.GrossPriceTextBox.Size = New System.Drawing.Size(429, 20)
        Me.GrossPriceTextBox.TabIndex = 7
        Me.GrossPriceTextBox.TabStop = False
        '
        'qualityTextBox
        '
        Me.qualityTextBox.Location = New System.Drawing.Point(478, 112)
        Me.qualityTextBox.Name = "qualityTextBox"
        Me.qualityTextBox.Size = New System.Drawing.Size(70, 20)
        Me.qualityTextBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Net Profit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Retail Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Wholesale Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gross Profit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Storage Charges"
        '
        'computeButton
        '
        Me.computeButton.Location = New System.Drawing.Point(646, 173)
        Me.computeButton.Name = "computeButton"
        Me.computeButton.Size = New System.Drawing.Size(110, 42)
        Me.computeButton.TabIndex = 2
        Me.computeButton.Text = "Compute"
        Me.computeButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Enabled = False
        Me.resetButton.Location = New System.Drawing.Point(646, 247)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(110, 42)
        Me.resetButton.TabIndex = 3
        Me.resetButton.Text = "Reset Form"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'totalNetProfitButton
        '
        Me.totalNetProfitButton.Location = New System.Drawing.Point(646, 322)
        Me.totalNetProfitButton.Name = "totalNetProfitButton"
        Me.totalNetProfitButton.Size = New System.Drawing.Size(110, 42)
        Me.totalNetProfitButton.TabIndex = 4
        Me.totalNetProfitButton.Text = "Total Net Charge"
        Me.totalNetProfitButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(646, 392)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(110, 42)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.computeButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.totalNetProfitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.computeButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents partIdentifierLable As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents partDescriptionTextBox As TextBox
    Friend WithEvents partIdentifierTextBox As TextBox
    Friend WithEvents partDescriptionLable As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents retailPriceTextBox As TextBox
    Friend WithEvents WholeSaleCostTextBox As TextBox
    Friend WithEvents netProfitTextBox As TextBox
    Friend WithEvents storageChargesTextBox As TextBox
    Friend WithEvents GrossPriceTextBox As TextBox
    Friend WithEvents qualityTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents computeButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents totalNetProfitButton As Button
    Friend WithEvents exitButton As Button
End Class
