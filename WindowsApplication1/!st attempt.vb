'Carolyn Mabbott
Public Class Form1
    'This is for all the global dims so they work throughout the program

    'Price dims 
    Dim PriceCake As Integer
    Dim PriceExtra As Integer
    Dim TotalPrice As String

    'Customer dims
    Dim CurrentCustomer As database.CustomerType
    Dim NoOfCustomers As Integer
    Dim EachCustomer As Integer

    'Cake dims
    Dim CurrentCake As database.CakeType
    Dim EachCake As Integer
    Dim NoOfCakes As Integer

    Public Sub CallDatabase()
        'This procedure gets information from the database
        'This procedure puts the information for the cakes and the customers in the correct boxes

        'This calls the database and gets the information from there
        Call database.ReadRecords()

        'Clears CboName from having anything in it
        CboName.Items.Clear()
        'Clears CboCake from having anything in it
        CboCake.Items.Clear()


        'gets a count of how many customers
        NoOfCustomers = database.CustomerRecordCount
        'Shows the customer details in the combo box
        For EachCustomer = 0 To NoOfCustomers - 1
            database.SelectCustomerRecord(EachCustomer, CurrentCustomer)
            CboName.Items.Add(CurrentCustomer.LastName + ", " + CurrentCustomer.FirstName)
        Next


        'gets a count of how many cakes
        NoOfCakes = database.CakeRecordCount
        'shows the cake details in the combo box
        For EachCake = 0 To NoOfCakes - 1
            database.SelectCakeRecord(EachCake, CurrentCake)
            CboCake.Items.Add(CurrentCake.CakeName)

        Next


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This procedure makes the starting prices and dates correct for the day
        'This procedure opens the database and connects to there

        'opens database
        database.OpenDatabase()

        'Calls the database
        CallDatabase()

        'myDate as my date
        Dim myDate As Date
        'myDateMax as my max date
        Dim myDateMax As Date

        'Sets the max date which is 4 weeks ahead of DateOrdered
        myDateMax = Today
        myDateMax = myDateMax.AddDays(28)

        'Sets the mindate for the order which is 1 week ahead of dateOrdered
        myDate = Today
        myDate = myDate.AddDays(7)

        'Sets the maxdate for the cake to be ordered on the date picker
        DateOrderedFor.MaxDate = myDateMax
        'sets the mindate that the cake can be ordered on the date picker
        DateOrderedFor.MinDate = myDate

        'Changes all label prices to starting price of "£0"
        LblExtras.Text = "£0"
        LblTotal.Text = "£0"
        LblCakePrice.Text = "£0"
        LblCakePrice1.Text = "£0"

    End Sub

    Private Sub ChbChoclateBase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChbChoclateBase.CheckedChanged
        'This procedure makes sure the chocolate base label always updates the prices when selected or removed

        'Changes extras label to show if chocolate base is selected
        If ChbChoclateBase.Checked Then
            'Changes the extras label to £10 if chocolate base is selected
            LblExtras.Text = "£10"
            'Adds 10 to priceExtra 
            PriceExtra = 10
        Else
            'Leaves extras label as £0 if chocolate base isnt selected
            LblExtras.Text = "£0"
            'Leaves priceextra at 0
            PriceExtra = 0
        End If

        'Changes the total price label to add the £10 or take it away from the total cake price
        LblTotal.Text = "£" + CStr(PriceCake + PriceExtra)

    End Sub
    Private Sub BtnNewCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewCustomer.Click
        'This procedure opens the new customer form so the user can add a new customer

        'Get the new customer form up showing the dialogue only 
        NewCustomer.ShowDialog()

    End Sub

    Private Sub BtnSaveOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveOrder.Click
        'This procedure saves the order as a new order to the database

        Dim myNewOrder As database.OrderType

        'Saves to order form in access
        'Saves the cake selected to the order form
        myNewOrder.CakeName = Me.CboCake.SelectedItem
        'Saves whether chocolate base is order or not to order form
        myNewOrder.ChocolateBase = Me.ChbChoclateBase.Checked
        'Saves customer name to the order form
        myNewOrder.CustomerID = Me.CboName.SelectedItem
        'saves order number to order form
        myNewOrder.OrderID = 1
        'Saves total price to the order form
        myNewOrder.TotalPrice = Me.LblTotal.Text
        'Saves the dateordered to the order form
        myNewOrder.DateOrdered = Me.DateOrdered.Value
        'Saves the date ordered for to the order form
        myNewOrder.DateOrderedFor = Me.DateOrderedFor.Value
        'Inserts the new order into the database
        database.InsertOrderRecord(myNewOrder)



    End Sub

    Private Sub CboCake_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboCake.SelectedIndexChanged
        'This procedure updates the cake price labels with the chosen cake
        'This procedure adds the cake price to the total price

        'Selects cake price for the current cake
        database.SelectCakeRecord(CboCake.SelectedIndex, CurrentCake)

        'Changes the label next to the cake selection box to reflect the price of the cake
        LblCakePrice1.Text = "£" + CStr(CurrentCake.CakePrice)

        'Changes the label below the cake selection box to reflect the price of the cake
        LblCakePrice.Text = "£" + CStr(CurrentCake.CakePrice)

        'Price for the cake label
        PriceCake = "£" + CStr(CurrentCake.CakePrice)

        'Changes the total price label to add the cake price to the total cake price
        LblTotal.Text = "£" + CStr(PriceCake + PriceExtra)
    End Sub

    Private Sub DateOrdered_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateOrdered.ValueChanged
        'This procedure makes the date ordered date always be on todays date and cannot be changed

        'Sets the mindate on the dateordered to today
        DateOrdered.MinDate = Today
        'Sets the maxdate on the dateorderd to today
        DateOrdered.MaxDate = Today
    End Sub
    Private Sub BtnViewOrders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewOrders.Click
        'This procedure opens the viewing orders form so the customer can view orders

        'Shows the view orders form as show dialogue only
        Orders.ShowDialog()

    End Sub

    Private Sub BtnOrderHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrderHelp.Click
        'This procedure opens the help page for the page so the customer can have on screen help

        'Shows the help page for the order page
        OrderHelp.ShowDialog()

    End Sub

    Private Sub BtnUpdateCustomer_Click(sender As System.Object, e As System.EventArgs) Handles BtnNewCake.Click

    End Sub
End Class
