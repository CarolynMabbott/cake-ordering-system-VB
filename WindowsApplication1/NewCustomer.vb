'Carolyn Mabbott
Public Class NewCustomer
    'This procedure closes this form and lets the user go back to the main ordering form

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        'Hides the new customer form
        Me.Hide()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        'This procedure saves the information in the text boxes into the database as a new customer and can appear
        'in the customer drop down box on the main ordering screen
        'Also this procedure closes this form after the save has been made so the user goes back to the main
        'ordering screen
        'If TxtFirstName.Text = "" Then
        'MsgBox("No first name enterted")
        'End
        'End If

        Dim MyNewCustomer As database.CustomerType

        'Saves the new customer with a customer ID
        MyNewCustomer.CustomerID = 1
        'Saves the new customers first name as the text typed in the box
        MyNewCustomer.FirstName = Me.TxtFirstName.Text
        'Saves the new customers last name as the text typed in the box
        MyNewCustomer.LastName = Me.TxtLastName.Text
        'Saves the new customers house number as the text typed in the box
        MyNewCustomer.HouseNumber = Me.TxtHouseNumber.Text
        'Saves the new customers road name as the text typed in the box
        MyNewCustomer.RoadName = Me.TxtRoadName.Text
        'Saves the new customers town as the text typed in the box
        MyNewCustomer.Town = Me.TxtTown.Text
        'Saves the new customers postcode as the text typed in the box
        MyNewCustomer.Postcode = Me.TxtPostcode.Text
        'Saves the new customers telephone number as the text typed in the box
        MyNewCustomer.TelephoneNumber = Me.TxtTelephone.Text
        'Saves the new customer to the Customer database
        database.NewCustomer(MyNewCustomer)

        'Hides the new customer form
        Me.Hide()

        Call Form1.CallDatabase()
        'Refreshes the ordering form to include the new customer 
        Form1.Refresh()
    End Sub

    Private Sub BtnCustomerHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomerHelp.Click
        'This procedure dislpays the help page for the new customer form

        'Opens the help page for the new customer page
        CustomerHelp.ShowDialog()

    End Sub
End Class