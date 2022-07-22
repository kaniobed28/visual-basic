Public Class Form1
    Dim AverageNetProfit As Decimal = 0
    Dim netProfit As Decimal
    Dim counter As Integer = 0


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub partIdentifierLable_Click(sender As Object, e As EventArgs) Handles partIdentifierLable.Click

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub GrossPriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles GrossPriceTextBox.TextChanged

    End Sub

    Private Sub computeButton_Click(sender As Object, e As EventArgs) Handles computeButton.Click
        Const fivePercent As Single = 0.05F
        Try
            GrossPriceTextBox.Text = Decimal.Parse(qualityTextBox.Text) * (Decimal.Parse(retailPriceTextBox.Text) - Decimal.Parse(WholeSaleCostTextBox.Text))
            Dim grossPrice As Decimal = Decimal.Parse(GrossPriceTextBox.Text)
            storageChargesTextBox.Text = Decimal.Parse(fivePercent) * grossPrice
            Dim storageCharges As Decimal = Decimal.Parse(storageChargesTextBox.Text)
            netProfitTextBox.Text = grossPrice - storageCharges
            netProfit = Decimal.Parse(netProfitTextBox.Text)
            counter = counter + 1

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Finally

        End Try




    End Sub

    Private Sub totalNetProfitButton_Click(sender As Object, e As EventArgs) Handles totalNetProfitButton.Click
        AverageNetProfit = (AverageNetProfit + netProfit) / counter
        MessageBox.Show(AverageNetProfit, "Data", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub
End Class
