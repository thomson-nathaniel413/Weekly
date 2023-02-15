'Program Name: Farm Burger Specials
Public Class frmBurgers
    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        'When this button is clicked, it should make picPrime visible and picVeggie invisible
        picPrime.Visible = True
        picVeggie.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        'When this button is clicked, it should make picVeggie visible and picPrime invisible
        picVeggie.Visible = True
        picPrime.Visible = False
        btnSelectMeal.Enabled = True
    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        'When this button is clicked, several things will occur:
        'lblInstructions should be made invisible
        'lblConfirmation should be made visible
        'btnPrime and btnVeggie should both be disabled
        'btnExit should be enabled
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnPrime.Enabled = False
        btnVeggie.Enabled = False
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'When this button is clicked, the program will exit
        Close()
    End Sub
End Class
