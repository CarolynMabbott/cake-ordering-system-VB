'Carolyn Mabbott
Public Class Orders

    Private Sub BtnOrdersCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrdersCancel.Click
        'Hides the view orders form
        Me.Hide()

    End Sub

    Private Sub BtnViewOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewOrders.Click
        'This procedure empties the order box then puts the orders into the order box
        'Also puts the records in order

        'Order dims
        Dim NoOfOrders As Integer
        Dim EachOrder As Integer
        Dim CurrentOrder As database.OrderType

        'Clears the LstOrders box of anything that has been left in there
        Me.LstOrders.Items.Clear()

        'Fills the LstOrders box with the orders
        NoOfOrders = database.OrderRecordCount
        For EachOrder = 0 To NoOfOrders - 1
            database.SelectOrderRecord(EachOrder, CurrentOrder)

            'Lists the orders with a ";" inbetween each piece of information
            'Lists the orders starting with the customer ID, Cake name, total price, whether chocolate base is needed or not, date the cake is ordered for
            Me.LstOrders.Items.Add(CStr(EachOrder) + ":" + CurrentOrder.CustomerID + "," + CurrentOrder.CakeName + "," + CStr(CurrentOrder.TotalPrice) + "," + CurrentOrder.ChocolateBase.ToString + "," + CurrentOrder.DateOrderedFor.ToString)

        Next

    End Sub
    Private Sub BtnViewHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewHelp.Click
        'This procedure show the help page for the orders page so the customer can see the on screen help

        'Shows the help page for the orders page
        ViewHelp.ShowDialog()

    End Sub
End Class