Public Class FormPurshase

    Private Sub FormPurshase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxTemplate.Items.Insert(0, "Default purchase")
        ComboBoxTemplate.Items.Insert(1, "Eurostar")

        ComboBoxTemplate.SelectedIndex = 0

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


End Class