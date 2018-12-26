<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPurshase
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
        Me.DateTimePickerPurchase = New System.Windows.Forms.DateTimePicker()
        Me.LabelDateAchat = New System.Windows.Forms.Label()
        Me.LabelTaxPoint = New System.Windows.Forms.Label()
        Me.DateTimePickerTaxPoint = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxAsPurchase = New System.Windows.Forms.CheckBox()
        Me.ComboBoxTemplate = New System.Windows.Forms.ComboBox()
        Me.LabelPurchaseTemplate = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelAmount = New System.Windows.Forms.Label()
        Me.RadioButtonGBP = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEUR = New System.Windows.Forms.RadioButton()
        Me.TrackBarBusinessPerc = New System.Windows.Forms.TrackBar()
        Me.LabelBusinessPerc = New System.Windows.Forms.Label()
        CType(Me.TrackBarBusinessPerc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePickerPurchase
        '
        Me.DateTimePickerPurchase.Location = New System.Drawing.Point(183, 30)
        Me.DateTimePickerPurchase.Name = "DateTimePickerPurchase"
        Me.DateTimePickerPurchase.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerPurchase.TabIndex = 0
        '
        'LabelDateAchat
        '
        Me.LabelDateAchat.AutoSize = True
        Me.LabelDateAchat.Location = New System.Drawing.Point(36, 30)
        Me.LabelDateAchat.Name = "LabelDateAchat"
        Me.LabelDateAchat.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelDateAchat.Size = New System.Drawing.Size(76, 16)
        Me.LabelDateAchat.TabIndex = 1
        Me.LabelDateAchat.Text = "Purchase date"
        '
        'LabelTaxPoint
        '
        Me.LabelTaxPoint.AutoSize = True
        Me.LabelTaxPoint.Location = New System.Drawing.Point(36, 56)
        Me.LabelTaxPoint.Name = "LabelTaxPoint"
        Me.LabelTaxPoint.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelTaxPoint.Size = New System.Drawing.Size(52, 16)
        Me.LabelTaxPoint.TabIndex = 2
        Me.LabelTaxPoint.Text = "Tax Point"
        '
        'DateTimePickerTaxPoint
        '
        Me.DateTimePickerTaxPoint.Location = New System.Drawing.Point(183, 56)
        Me.DateTimePickerTaxPoint.Name = "DateTimePickerTaxPoint"
        Me.DateTimePickerTaxPoint.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerTaxPoint.TabIndex = 3
        '
        'CheckBoxAsPurchase
        '
        Me.CheckBoxAsPurchase.AutoSize = True
        Me.CheckBoxAsPurchase.Location = New System.Drawing.Point(94, 56)
        Me.CheckBoxAsPurchase.Name = "CheckBoxAsPurchase"
        Me.CheckBoxAsPurchase.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.CheckBoxAsPurchase.Size = New System.Drawing.Size(85, 20)
        Me.CheckBoxAsPurchase.TabIndex = 4
        Me.CheckBoxAsPurchase.Text = "As purchase"
        Me.CheckBoxAsPurchase.UseVisualStyleBackColor = True
        '
        'ComboBoxTemplate
        '
        Me.ComboBoxTemplate.FormattingEnabled = True
        Me.ComboBoxTemplate.Location = New System.Drawing.Point(183, 82)
        Me.ComboBoxTemplate.Name = "ComboBoxTemplate"
        Me.ComboBoxTemplate.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxTemplate.TabIndex = 5
        '
        'LabelPurchaseTemplate
        '
        Me.LabelPurchaseTemplate.AutoSize = True
        Me.LabelPurchaseTemplate.Location = New System.Drawing.Point(36, 82)
        Me.LabelPurchaseTemplate.Name = "LabelPurchaseTemplate"
        Me.LabelPurchaseTemplate.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelPurchaseTemplate.Size = New System.Drawing.Size(99, 16)
        Me.LabelPurchaseTemplate.TabIndex = 6
        Me.LabelPurchaseTemplate.Text = "Purchase Template"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(36, 109)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelDescription.Size = New System.Drawing.Size(60, 16)
        Me.LabelDescription.TabIndex = 7
        Me.LabelDescription.Text = "Description"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(183, 109)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(381, 20)
        Me.TextBoxDescription.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(183, 135)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 9
        '
        'LabelAmount
        '
        Me.LabelAmount.AutoSize = True
        Me.LabelAmount.Location = New System.Drawing.Point(36, 135)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelAmount.Size = New System.Drawing.Size(43, 16)
        Me.LabelAmount.TabIndex = 10
        Me.LabelAmount.Text = "Amount"
        '
        'RadioButtonGBP
        '
        Me.RadioButtonGBP.AutoSize = True
        Me.RadioButtonGBP.Location = New System.Drawing.Point(346, 134)
        Me.RadioButtonGBP.Name = "RadioButtonGBP"
        Me.RadioButtonGBP.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.RadioButtonGBP.Size = New System.Drawing.Size(47, 20)
        Me.RadioButtonGBP.TabIndex = 11
        Me.RadioButtonGBP.TabStop = True
        Me.RadioButtonGBP.Text = "GBP"
        Me.RadioButtonGBP.UseVisualStyleBackColor = True
        '
        'RadioButtonEUR
        '
        Me.RadioButtonEUR.AutoSize = True
        Me.RadioButtonEUR.Location = New System.Drawing.Point(292, 134)
        Me.RadioButtonEUR.Name = "RadioButtonEUR"
        Me.RadioButtonEUR.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.RadioButtonEUR.Size = New System.Drawing.Size(48, 20)
        Me.RadioButtonEUR.TabIndex = 12
        Me.RadioButtonEUR.TabStop = True
        Me.RadioButtonEUR.Text = "EUR"
        Me.RadioButtonEUR.UseVisualStyleBackColor = True
        '
        'TrackBarBusinessPerc
        '
        Me.TrackBarBusinessPerc.LargeChange = 20
        Me.TrackBarBusinessPerc.Location = New System.Drawing.Point(183, 162)
        Me.TrackBarBusinessPerc.Maximum = 100
        Me.TrackBarBusinessPerc.Name = "TrackBarBusinessPerc"
        Me.TrackBarBusinessPerc.Size = New System.Drawing.Size(381, 45)
        Me.TrackBarBusinessPerc.TabIndex = 13
        Me.TrackBarBusinessPerc.Value = 100
        '
        'LabelBusinessPerc
        '
        Me.LabelBusinessPerc.AutoSize = True
        Me.LabelBusinessPerc.Location = New System.Drawing.Point(36, 162)
        Me.LabelBusinessPerc.Name = "LabelBusinessPerc"
        Me.LabelBusinessPerc.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelBusinessPerc.Size = New System.Drawing.Size(107, 16)
        Me.LabelBusinessPerc.TabIndex = 14
        Me.LabelBusinessPerc.Text = "Business Percentage"
        '
        'FormPurshase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelBusinessPerc)
        Me.Controls.Add(Me.TrackBarBusinessPerc)
        Me.Controls.Add(Me.RadioButtonEUR)
        Me.Controls.Add(Me.RadioButtonGBP)
        Me.Controls.Add(Me.LabelAmount)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelPurchaseTemplate)
        Me.Controls.Add(Me.ComboBoxTemplate)
        Me.Controls.Add(Me.CheckBoxAsPurchase)
        Me.Controls.Add(Me.DateTimePickerTaxPoint)
        Me.Controls.Add(Me.LabelTaxPoint)
        Me.Controls.Add(Me.LabelDateAchat)
        Me.Controls.Add(Me.DateTimePickerPurchase)
        Me.Name = "FormPurshase"
        Me.Text = "Purshase"
        CType(Me.TrackBarBusinessPerc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerPurchase As Windows.Forms.DateTimePicker
    Friend WithEvents LabelDateAchat As Windows.Forms.Label
    Friend WithEvents LabelTaxPoint As Windows.Forms.Label
    Friend WithEvents DateTimePickerTaxPoint As Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxAsPurchase As Windows.Forms.CheckBox
    Friend WithEvents ComboBoxTemplate As Windows.Forms.ComboBox
    Friend WithEvents LabelPurchaseTemplate As Windows.Forms.Label
    Friend WithEvents LabelDescription As Windows.Forms.Label
    Friend WithEvents TextBoxDescription As Windows.Forms.TextBox
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents LabelAmount As Windows.Forms.Label
    Friend WithEvents RadioButtonGBP As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonEUR As Windows.Forms.RadioButton
    Friend WithEvents TrackBarBusinessPerc As Windows.Forms.TrackBar
    Friend WithEvents LabelBusinessPerc As Windows.Forms.Label
End Class
