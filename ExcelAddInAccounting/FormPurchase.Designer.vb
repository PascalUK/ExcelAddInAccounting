<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPurchase
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
        Me.LabelPurchaseTemplate = New System.Windows.Forms.Label()
        Me.TextBoxAmount = New System.Windows.Forms.TextBox()
        Me.LabelAmount = New System.Windows.Forms.Label()
        Me.RadioButtonGBP = New System.Windows.Forms.RadioButton()
        Me.RadioButtonEUR = New System.Windows.Forms.RadioButton()
        Me.LabelBusinessPerc = New System.Windows.Forms.Label()
        Me.LabelTemplate1 = New System.Windows.Forms.Label()
        Me.LabelTemplate2 = New System.Windows.Forms.Label()
        Me.LabelTemplate3 = New System.Windows.Forms.Label()
        Me.TextBoxTemplate1 = New System.Windows.Forms.TextBox()
        Me.TextBoxTemplate2 = New System.Windows.Forms.TextBox()
        Me.TextBoxTemplate3 = New System.Windows.Forms.TextBox()
        Me.ComboBoxTemplate = New System.Windows.Forms.ComboBox()
        Me.TextBoxBusinessPerc = New System.Windows.Forms.TextBox()
        Me.LabelQuarter = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelVAT = New System.Windows.Forms.Label()
        Me.PanelCurrency = New System.Windows.Forms.Panel()
        Me.RadioButtonVAT0 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelCurrency.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickerPurchase
        '
        Me.DateTimePickerPurchase.Location = New System.Drawing.Point(181, 51)
        Me.DateTimePickerPurchase.Name = "DateTimePickerPurchase"
        Me.DateTimePickerPurchase.Size = New System.Drawing.Size(138, 20)
        Me.DateTimePickerPurchase.TabIndex = 3
        '
        'LabelDateAchat
        '
        Me.LabelDateAchat.AutoSize = True
        Me.LabelDateAchat.Location = New System.Drawing.Point(34, 51)
        Me.LabelDateAchat.Name = "LabelDateAchat"
        Me.LabelDateAchat.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelDateAchat.Size = New System.Drawing.Size(76, 16)
        Me.LabelDateAchat.TabIndex = 2
        Me.LabelDateAchat.Text = "Purchase date"
        '
        'LabelTaxPoint
        '
        Me.LabelTaxPoint.AutoSize = True
        Me.LabelTaxPoint.Location = New System.Drawing.Point(34, 77)
        Me.LabelTaxPoint.Name = "LabelTaxPoint"
        Me.LabelTaxPoint.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelTaxPoint.Size = New System.Drawing.Size(52, 16)
        Me.LabelTaxPoint.TabIndex = 4
        Me.LabelTaxPoint.Text = "Tax Point"
        '
        'DateTimePickerTaxPoint
        '
        Me.DateTimePickerTaxPoint.Location = New System.Drawing.Point(181, 77)
        Me.DateTimePickerTaxPoint.Name = "DateTimePickerTaxPoint"
        Me.DateTimePickerTaxPoint.Size = New System.Drawing.Size(138, 20)
        Me.DateTimePickerTaxPoint.TabIndex = 6
        '
        'CheckBoxAsPurchase
        '
        Me.CheckBoxAsPurchase.AutoSize = True
        Me.CheckBoxAsPurchase.Location = New System.Drawing.Point(92, 77)
        Me.CheckBoxAsPurchase.Name = "CheckBoxAsPurchase"
        Me.CheckBoxAsPurchase.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.CheckBoxAsPurchase.Size = New System.Drawing.Size(85, 19)
        Me.CheckBoxAsPurchase.TabIndex = 5
        Me.CheckBoxAsPurchase.Text = "As purchase"
        Me.CheckBoxAsPurchase.UseVisualStyleBackColor = True
        '
        'LabelPurchaseTemplate
        '
        Me.LabelPurchaseTemplate.AutoSize = True
        Me.LabelPurchaseTemplate.Location = New System.Drawing.Point(34, 103)
        Me.LabelPurchaseTemplate.Name = "LabelPurchaseTemplate"
        Me.LabelPurchaseTemplate.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelPurchaseTemplate.Size = New System.Drawing.Size(99, 16)
        Me.LabelPurchaseTemplate.TabIndex = 7
        Me.LabelPurchaseTemplate.Text = "Purchase Template"
        '
        'TextBoxAmount
        '
        Me.TextBoxAmount.Location = New System.Drawing.Point(181, 210)
        Me.TextBoxAmount.Name = "TextBoxAmount"
        Me.TextBoxAmount.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAmount.TabIndex = 16
        Me.TextBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelAmount
        '
        Me.LabelAmount.AutoSize = True
        Me.LabelAmount.Location = New System.Drawing.Point(34, 210)
        Me.LabelAmount.Name = "LabelAmount"
        Me.LabelAmount.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelAmount.Size = New System.Drawing.Size(43, 16)
        Me.LabelAmount.TabIndex = 15
        Me.LabelAmount.Text = "Amount"
        '
        'RadioButtonGBP
        '
        Me.RadioButtonGBP.AutoSize = True
        Me.RadioButtonGBP.Location = New System.Drawing.Point(54, -1)
        Me.RadioButtonGBP.Name = "RadioButtonGBP"
        Me.RadioButtonGBP.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.RadioButtonGBP.Size = New System.Drawing.Size(47, 20)
        Me.RadioButtonGBP.TabIndex = 1
        Me.RadioButtonGBP.TabStop = True
        Me.RadioButtonGBP.Text = "GBP"
        Me.RadioButtonGBP.UseVisualStyleBackColor = True
        '
        'RadioButtonEUR
        '
        Me.RadioButtonEUR.AutoSize = True
        Me.RadioButtonEUR.Location = New System.Drawing.Point(0, -1)
        Me.RadioButtonEUR.Name = "RadioButtonEUR"
        Me.RadioButtonEUR.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.RadioButtonEUR.Size = New System.Drawing.Size(48, 20)
        Me.RadioButtonEUR.TabIndex = 0
        Me.RadioButtonEUR.TabStop = True
        Me.RadioButtonEUR.Text = "EUR"
        Me.RadioButtonEUR.UseVisualStyleBackColor = True
        '
        'LabelBusinessPerc
        '
        Me.LabelBusinessPerc.AutoSize = True
        Me.LabelBusinessPerc.Location = New System.Drawing.Point(34, 237)
        Me.LabelBusinessPerc.Name = "LabelBusinessPerc"
        Me.LabelBusinessPerc.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelBusinessPerc.Size = New System.Drawing.Size(107, 16)
        Me.LabelBusinessPerc.TabIndex = 17
        Me.LabelBusinessPerc.Text = "Business Percentage"
        '
        'LabelTemplate1
        '
        Me.LabelTemplate1.AutoSize = True
        Me.LabelTemplate1.Location = New System.Drawing.Point(34, 131)
        Me.LabelTemplate1.Name = "LabelTemplate1"
        Me.LabelTemplate1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelTemplate1.Size = New System.Drawing.Size(39, 16)
        Me.LabelTemplate1.TabIndex = 9
        Me.LabelTemplate1.Text = "Label1"
        '
        'LabelTemplate2
        '
        Me.LabelTemplate2.AutoSize = True
        Me.LabelTemplate2.Location = New System.Drawing.Point(34, 158)
        Me.LabelTemplate2.Name = "LabelTemplate2"
        Me.LabelTemplate2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelTemplate2.Size = New System.Drawing.Size(39, 16)
        Me.LabelTemplate2.TabIndex = 11
        Me.LabelTemplate2.Text = "Label2"
        '
        'LabelTemplate3
        '
        Me.LabelTemplate3.AutoSize = True
        Me.LabelTemplate3.Location = New System.Drawing.Point(34, 185)
        Me.LabelTemplate3.Name = "LabelTemplate3"
        Me.LabelTemplate3.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelTemplate3.Size = New System.Drawing.Size(39, 16)
        Me.LabelTemplate3.TabIndex = 13
        Me.LabelTemplate3.Text = "Label3"
        '
        'TextBoxTemplate1
        '
        Me.TextBoxTemplate1.Location = New System.Drawing.Point(181, 131)
        Me.TextBoxTemplate1.Name = "TextBoxTemplate1"
        Me.TextBoxTemplate1.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxTemplate1.TabIndex = 10
        '
        'TextBoxTemplate2
        '
        Me.TextBoxTemplate2.Location = New System.Drawing.Point(181, 157)
        Me.TextBoxTemplate2.Name = "TextBoxTemplate2"
        Me.TextBoxTemplate2.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxTemplate2.TabIndex = 12
        '
        'TextBoxTemplate3
        '
        Me.TextBoxTemplate3.Location = New System.Drawing.Point(181, 184)
        Me.TextBoxTemplate3.Name = "TextBoxTemplate3"
        Me.TextBoxTemplate3.Size = New System.Drawing.Size(305, 20)
        Me.TextBoxTemplate3.TabIndex = 14
        '
        'ComboBoxTemplate
        '
        Me.ComboBoxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxTemplate.Items.AddRange(New Object() {"Default", "Eurostar", "Restaurant"})
        Me.ComboBoxTemplate.Location = New System.Drawing.Point(181, 104)
        Me.ComboBoxTemplate.Name = "ComboBoxTemplate"
        Me.ComboBoxTemplate.Size = New System.Drawing.Size(138, 21)
        Me.ComboBoxTemplate.Sorted = True
        Me.ComboBoxTemplate.TabIndex = 8
        '
        'TextBoxBusinessPerc
        '
        Me.TextBoxBusinessPerc.Location = New System.Drawing.Point(181, 237)
        Me.TextBoxBusinessPerc.MaxLength = 3
        Me.TextBoxBusinessPerc.Name = "TextBoxBusinessPerc"
        Me.TextBoxBusinessPerc.Size = New System.Drawing.Size(50, 20)
        Me.TextBoxBusinessPerc.TabIndex = 18
        Me.TextBoxBusinessPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBoxBusinessPerc.WordWrap = False
        '
        'LabelQuarter
        '
        Me.LabelQuarter.AutoSize = True
        Me.LabelQuarter.Location = New System.Drawing.Point(34, 27)
        Me.LabelQuarter.Name = "LabelQuarter"
        Me.LabelQuarter.Size = New System.Drawing.Size(42, 13)
        Me.LabelQuarter.TabIndex = 0
        Me.LabelQuarter.Text = "Quarter"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Quarter 2 Apr-Jun", "Quarter 3 Jul-Sep", "Quarter 4 Oct-Dec", "Quarter 1 Jan-Mar"})
        Me.ComboBox1.Location = New System.Drawing.Point(181, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'LabelVAT
        '
        Me.LabelVAT.AutoSize = True
        Me.LabelVAT.Location = New System.Drawing.Point(34, 263)
        Me.LabelVAT.Name = "LabelVAT"
        Me.LabelVAT.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LabelVAT.Size = New System.Drawing.Size(28, 16)
        Me.LabelVAT.TabIndex = 19
        Me.LabelVAT.Text = "VAT"
        '
        'PanelCurrency
        '
        Me.PanelCurrency.Controls.Add(Me.RadioButtonEUR)
        Me.PanelCurrency.Controls.Add(Me.RadioButtonGBP)
        Me.PanelCurrency.Location = New System.Drawing.Point(287, 210)
        Me.PanelCurrency.Name = "PanelCurrency"
        Me.PanelCurrency.Size = New System.Drawing.Size(121, 20)
        Me.PanelCurrency.TabIndex = 30
        '
        'RadioButtonVAT0
        '
        Me.RadioButtonVAT0.AutoSize = True
        Me.RadioButtonVAT0.Location = New System.Drawing.Point(3, 0)
        Me.RadioButtonVAT0.Name = "RadioButtonVAT0"
        Me.RadioButtonVAT0.Size = New System.Drawing.Size(39, 17)
        Me.RadioButtonVAT0.TabIndex = 0
        Me.RadioButtonVAT0.TabStop = True
        Me.RadioButtonVAT0.Text = "0%"
        Me.RadioButtonVAT0.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(48, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(45, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "20%"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButtonVAT0)
        Me.Panel1.Location = New System.Drawing.Point(179, 263)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 16)
        Me.Panel1.TabIndex = 31
        '
        'FormPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelCurrency)
        Me.Controls.Add(Me.LabelVAT)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LabelQuarter)
        Me.Controls.Add(Me.TextBoxBusinessPerc)
        Me.Controls.Add(Me.ComboBoxTemplate)
        Me.Controls.Add(Me.TextBoxTemplate3)
        Me.Controls.Add(Me.TextBoxTemplate2)
        Me.Controls.Add(Me.TextBoxTemplate1)
        Me.Controls.Add(Me.LabelTemplate3)
        Me.Controls.Add(Me.LabelTemplate2)
        Me.Controls.Add(Me.LabelTemplate1)
        Me.Controls.Add(Me.LabelBusinessPerc)
        Me.Controls.Add(Me.LabelAmount)
        Me.Controls.Add(Me.TextBoxAmount)
        Me.Controls.Add(Me.LabelPurchaseTemplate)
        Me.Controls.Add(Me.CheckBoxAsPurchase)
        Me.Controls.Add(Me.DateTimePickerTaxPoint)
        Me.Controls.Add(Me.LabelTaxPoint)
        Me.Controls.Add(Me.LabelDateAchat)
        Me.Controls.Add(Me.DateTimePickerPurchase)
        Me.Name = "FormPurchase"
        Me.Text = "Purchase"
        Me.PanelCurrency.ResumeLayout(False)
        Me.PanelCurrency.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerPurchase As Windows.Forms.DateTimePicker
    Friend WithEvents LabelDateAchat As Windows.Forms.Label
    Friend WithEvents LabelTaxPoint As Windows.Forms.Label
    Friend WithEvents DateTimePickerTaxPoint As Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxAsPurchase As Windows.Forms.CheckBox
    Friend WithEvents LabelPurchaseTemplate As Windows.Forms.Label
    Friend WithEvents TextBoxAmount As Windows.Forms.TextBox
    Friend WithEvents LabelAmount As Windows.Forms.Label
    Friend WithEvents RadioButtonGBP As Windows.Forms.RadioButton
    Friend WithEvents RadioButtonEUR As Windows.Forms.RadioButton
    Friend WithEvents LabelBusinessPerc As Windows.Forms.Label
    Friend WithEvents LabelTemplate1 As Windows.Forms.Label
    Friend WithEvents LabelTemplate2 As Windows.Forms.Label
    Friend WithEvents LabelTemplate3 As Windows.Forms.Label
    Friend WithEvents TextBoxTemplate1 As Windows.Forms.TextBox
    Friend WithEvents TextBoxTemplate2 As Windows.Forms.TextBox
    Friend WithEvents TextBoxTemplate3 As Windows.Forms.TextBox
    Friend WithEvents ComboBoxTemplate As Windows.Forms.ComboBox
    Friend WithEvents TextBoxBusinessPerc As Windows.Forms.TextBox
    Friend WithEvents LabelQuarter As Windows.Forms.Label
    Friend WithEvents ComboBox1 As Windows.Forms.ComboBox
    Friend WithEvents LabelVAT As Windows.Forms.Label
    Friend WithEvents PanelCurrency As Windows.Forms.Panel
    Friend WithEvents RadioButtonVAT0 As Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As Windows.Forms.RadioButton
    Friend WithEvents Panel1 As Windows.Forms.Panel
End Class
