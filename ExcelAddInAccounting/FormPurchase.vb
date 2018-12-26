Public Class FormPurchase
    'Dim iTemplate As Integer
    'Dim selectedTemplate As Object

    ' TODO Add date on/off Quarter

    Private Sub FormPurshase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxTemplate.Text = "Eurostar"
        BuildTemplate()

        RadioButtonEUR.Checked = True
        RadioButtonGBP.Checked = False

    End Sub

    Private Sub DateTimePickerPurchase_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerPurchase.ValueChanged
        If CheckBoxAsPurchase.Checked Then
            DateTimePickerTaxPoint.Value = DateTimePickerPurchase.Value
            DateTimePickerTaxPoint.Enabled = False
        Else
            DateTimePickerTaxPoint.Enabled = True
        End If
    End Sub

    Private Sub CheckBoxSameAsTaxPoint_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxAsPurchase.CheckedChanged
        If CheckBoxAsPurchase.Checked Then
            DateTimePickerTaxPoint.Value = DateTimePickerPurchase.Value
            DateTimePickerTaxPoint.Enabled = False
        Else
            DateTimePickerTaxPoint.Enabled = True
        End If
    End Sub

    Private Sub RadioButtonGBP_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonGBP.CheckedChanged

    End Sub

    Private Sub BuildTemplate()

        LabelTemplate1.Visible = False
        LabelTemplate2.Visible = False
        LabelTemplate3.Visible = False

        LabelTemplate1.Text = Nothing
        LabelTemplate2.Text = Nothing
        LabelTemplate3.Text = Nothing

        TextBoxTemplate1.Visible = False
        TextBoxTemplate2.Visible = False
        TextBoxTemplate3.Visible = False

        TextBoxTemplate1.Text = Nothing
        TextBoxTemplate2.Text = Nothing
        TextBoxTemplate3.Text = Nothing

        TextBoxTemplate1.Enabled = False
        TextBoxTemplate2.Enabled = False
        TextBoxTemplate3.Enabled = False

        Select Case ComboBoxTemplate.Text
            Case "Eurostar"
                '
                ' Booking reference
                '
                LabelTemplate1.Text = "Booking Reference"
                LabelTemplate1.Visible = True

                TextBoxTemplate1.Visible = True
                TextBoxTemplate1.Enabled = True

            Case Else ' Default
                '
                ' Free description
                '
                LabelTemplate1.Text = "Description"
                LabelTemplate1.Visible = True

                TextBoxTemplate1.Enabled = True
                TextBoxTemplate1.Visible = True

                LabelTemplate2.Text = "Description 2"
                LabelTemplate2.Visible = True

                TextBoxTemplate2.Enabled = True
                TextBoxTemplate2.Visible = True

                LabelTemplate3.Text = "Description 3"
                LabelTemplate3.Visible = True

                TextBoxTemplate3.Enabled = True
                TextBoxTemplate3.Visible = True
        End Select
    End Sub

    Private Sub ComboBoxTemplate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTemplate.SelectedIndexChanged
        BuildTemplate()

    End Sub

End Class