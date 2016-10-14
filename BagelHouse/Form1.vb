Public Class Form1
    ' Class-level declarations
    Const decTAX_RATE As Decimal = 0.06D     ' Tax Rate
    Const decWHITE_BAGEL As Decimal = 1.25D
    Const decWHEAT_BAGEL As Decimal = 1.5D
    Const decCREAM_CHEESE As Decimal = 0.5D
    Const decBUTTER As Decimal = 0.25D
    Const decBLUEBERRY As Decimal = 0.75D
    Const decRASPBERRY As Decimal = 0.75D
    Const decPEACH As Decimal = 0.75D
    Const decREG_COFFEE As Decimal = 1.25D
    Const decCAPPUCCINO As Decimal = 2D
    Const decCAFE_AU_LAIT As Decimal = 1.75D

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This procedure calculates the total of an order. 
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        decSubtotal = CalcBagelCost() + CalcToppingCost() + CalcCoffeeCost()
        decTax = CalcTax(decSubtotal)

        lblSubtotal.Text = decSubtotal.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' This procedure reset the controls to default values. 
        ResetBagels()
        ResetToppings()
        ResetCoffee()
        ResetPrice()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub

    Function CalcBagelCost() As Decimal
        ' This function returns the cost of the selcted bagel.
        Dim decBagel As Decimal

        If radWhite.Checked = True Then
            decBagel = decWHITE_BAGEL
        Else
            decBagel = decWHEAT_BAGEL
        End If

        Return decBagel
    End Function


End Class
