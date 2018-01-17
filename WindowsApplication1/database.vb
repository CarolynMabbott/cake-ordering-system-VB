'Carolyn Mabbott
Imports System.Data.OleDb

Module database
    'Customer structure
    Structure CustomerType
        Dim CustomerID As Integer
        Dim FirstName As String
        Dim LastName As String
        Dim Town As String
        Dim HouseNumber As String
        Dim Postcode As String
        Dim TelephoneNumber As String
        Dim RoadName As String
    End Structure
    'Cake structure
    Structure CakeType
        Dim CakeName As String
        Dim CakePrice As String
        Dim TotalPrice As String
    End Structure
    ' Order record structure
    Structure OrderType
        Dim OrderID As Integer
        Dim CustomerID As String
        Dim CakeName As String
        Dim ChocolateBase As Boolean
        Dim TotalPrice As String
        Dim DateOrdered As String
        Dim DateOrderedFor As String
        Dim LastName As String
        Dim FirstName As String
    End Structure

    'Customer Dims
    Dim conn As New OleDbConnection()
    Dim dsCustomer As New DataSet()
    Dim daCustomer As OleDbDataAdapter
    Dim intCurrentIndex As Integer = -1

    'Order Dims
    Dim dsOrder As New DataSet()
    Dim daOrder As OleDbDataAdapter
    Dim intCurrentOrderIndex As Integer = -1

    'Cake Dims
    Dim daCake As OleDbDataAdapter
    Dim dsCake As New DataSet()
    Dim intCurrentCakeIndex As Integer = -1

    Public Sub OpenDatabase()
        'This procedure opens the database and connects to the database
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CakeDatabase.mdb;User Id=admin;Password=;"

        ' connects to the database "CakeDatabase"
        daCustomer = New OleDbDataAdapter("", conn)
        'Select from customer table
        daCustomer.SelectCommand = New OleDbCommand("SELECT CustomerID, FirstName, LastName, HouseNumber, RoadName, Town, Postcode, TelephoneNumber FROM Customer")
        daCustomer.SelectCommand.Connection = conn



        ' connect to the database "CakeDatabase"
        daCake = New OleDbDataAdapter("", conn)
        'Select from cake table
        daCake.SelectCommand = New OleDbCommand("SELECT CakeID, CakeName, CakePrice FROM Cake")
        daCake.SelectCommand.Connection = conn


        'Connects to the database "CakeDatabase"
        daOrder = New OleDbDataAdapter("", conn)
        'Select from order table
        daOrder.SelectCommand = New OleDbCommand("SELECT CustomerID, CakeName, ChocolateBase, TotalPrice, DateOrdered, DateOrderedFor FROM Orders")
        daOrder.SelectCommand.Connection = conn



        'This inserts a new order in the orders table in the database
        daOrder.InsertCommand = New OleDbCommand("INSERT INTO Orders(CustomerID, CakeName, ChocolateBase, TotalPrice, DateOrdered, DateOrderedFor) VALUES(@CustomerID,@CakeName,@ChocolateBase,@TotalPrice,@DateOrdered,@DateOrderedFor)")
        daOrder.InsertCommand.Connection = conn
        daOrder.InsertCommand.Parameters.Add("@CustomerID", OleDbType.VarChar, 40, "CustomerID") 'This adds the customers name
        daOrder.InsertCommand.Parameters.Add("@CakeName", OleDbType.VarChar, 40, "CakeName") 'This adds the cake name
        daOrder.InsertCommand.Parameters.Add("@ChocolateBase", OleDbType.Boolean, 1, "ChocolateBase") 'This adds a tick if a chocolate base is needed
        daOrder.InsertCommand.Parameters.Add("@TotalPrice", OleDbType.VarChar, 40, "TotalPrice") 'This adds the total price
        daOrder.InsertCommand.Parameters.Add("@DateOrdered", OleDbType.Date, 4, "DateOrdered") 'This adds the date ordered
        daOrder.InsertCommand.Parameters.Add("@DateOrderedFor", OleDbType.Date, 4, "DateOrderedFor") 'This adds the date the cake is ordered for

        'This calls the read records sub to refill the boxes 
        Call ReadRecords()
    End Sub
    Public Sub ReadRecords()
        'This procedure clears the order box and the cake and customer 
        'drop down boxes and fills them with all the records including ny new ones

        'This clears then refills the order box
        dsOrder.Clear()
        daOrder.Fill(dsOrder)
        intCurrentOrderIndex = 0

        'This clears then refills the cake drop down box
        dsCake.Clear()
        daCake.Fill(dsCake)
        intCurrentCakeIndex = 0

        'This clear then refills the customer drop down box
        dsCustomer.Clear()
        daCustomer.Fill(dsCustomer)
        intCurrentIndex = 0

    End Sub

    Public Sub InsertOrderRecord(ByRef ThisOrder As OrderType)
        'This procedure inserts a order into the database
        Dim drOrder As DataRow
        drOrder = dsOrder.Tables(0).NewRow()
        drOrder("CustomerID") = ThisOrder.CustomerID
        drOrder("CakeName") = ThisOrder.CakeName
        drOrder("ChocolateBase") = ThisOrder.ChocolateBase
        drOrder("TotalPrice") = ThisOrder.TotalPrice
        drOrder("DateOrdered") = ThisOrder.DateOrdered
        drOrder("DateOrderedFor") = ThisOrder.DateOrderedFor

        'This adds the order to the database
        dsOrder.Tables(0).Rows.Add(drOrder)
        daOrder.Update(dsOrder)
        dsOrder.AcceptChanges()

    End Sub


    Public Sub SelectCustomerRecord(ByVal idx As Integer, ByRef ThisCustomer As CustomerType)
        'This procedure gets the customer information from the customer table in the database
        If intCurrentIndex = -1 Then
            Call OpenDatabase()
        End If

        intCurrentIndex = idx

        'This converts the customers first name, last name and town into a string
        ThisCustomer.FirstName = dsCustomer.Tables(0).Rows(intCurrentIndex).Item("FirstName").ToString()
        ThisCustomer.LastName = dsCustomer.Tables(0).Rows(intCurrentIndex).Item("LastName").ToString()
        ThisCustomer.Town = dsCustomer.Tables(0).Rows(intCurrentIndex).Item("Town").ToString()
    End Sub

    Public Sub SelectCakeRecord(ByVal idx As Integer, ByRef ThisCake As CakeType)
        'This procedure gets the cake information from the cake table in the database
        If intCurrentCakeIndex = -1 Then
            Call OpenDatabase()
        End If

        intCurrentCakeIndex = idx
        'This converts the name and the price of the cake to a string
        ThisCake.CakeName = dsCake.Tables(0).Rows(intCurrentCakeIndex).Item("CakeName").ToString()
        ThisCake.CakePrice = dsCake.Tables(0).Rows(intCurrentCakeIndex).Item("CakePrice").ToString()
    End Sub

    Public Sub SelectOrderRecord(ByVal idx As Integer, ByRef ThisOrder As OrderType)
        'This procedure gets orders from the order table in the orders table in the database
        If intCurrentOrderIndex = -1 Then
            Call OpenDatabase()
        End If

        'This converts what is needed into a string 
        intCurrentOrderIndex = idx
        ThisOrder.CustomerID = dsOrder.Tables(0).Rows(intCurrentOrderIndex).Item("CustomerID").ToString
        ThisOrder.ChocolateBase = dsOrder.Tables(0).Rows(intCurrentOrderIndex).Item("ChocolateBase").ToString
        ThisOrder.CakeName = dsOrder.Tables(0).Rows(intCurrentOrderIndex).Item("CakeName").ToString
        ThisOrder.TotalPrice = dsOrder.Tables(0).Rows(intCurrentOrderIndex).Item("TotalPrice").ToString
        ThisOrder.DateOrdered = dsOrder.Tables(0).Rows(intCurrentOrderIndex).Item("DateOrdered").ToString
        ThisOrder.DateOrderedFor = dsOrder.Tables(0).Rows(intCurrentOrderIndex).Item("DateOrderedFor").ToString
    End Sub

    Public Function CustomerRecordCount() As Integer
        'This procedure gets a count of the number of customers
        If intCurrentIndex = -1 Then
            Call OpenDatabase()
        End If

        CustomerRecordCount = dsCustomer.Tables(0).Rows.Count
    End Function

    Public Function CakeRecordCount() As Integer
        'This procedure gets a count of the number of cakes
        If intCurrentCakeIndex = -1 Then
            Call OpenDatabase()
        End If

        CakeRecordCount = dsCake.Tables(0).Rows.Count
    End Function

    Public Function OrderRecordCount() As Integer
        'This procedure gets a count of the number of orders
        If intCurrentOrderIndex = -1 Then
            Call OpenDatabase()
        End If

        OrderRecordCount = dsOrder.Tables(0).Rows.Count
    End Function
    Public Sub NewCustomer(ByRef ThisEmployee As CustomerType)
        'This procedure allows the user to add a new customer to the database
        Dim dr As DataRow

        dr = dsCustomer.Tables(0).NewRow()  'Gets a reference to a new row.
        dr("FirstName") = ThisEmployee.FirstName 'Adds a new first name for a customer to the customer table
        dr("LastName") = ThisEmployee.LastName 'Adds a new last name for a customer to the customer table
        dr("HouseNumber") = ThisEmployee.HouseNumber 'adds a new house name for a customer to the customer table
        dr("RoadName") = ThisEmployee.RoadName ' adds a new road name for a customer to the customer table
        dr("Town") = ThisEmployee.Town ' adds a new town for a customer to the customer table
        dr("Postcode") = ThisEmployee.Postcode 'adds a new postcode for a customer to the customer table
        dr("TelephoneNumber") = ThisEmployee.TelephoneNumber 'adds a new telephone number for a customer to the customer table


        'This inserts into the customer table of the database the new customers first name, last name, house number, road name, town,
        'postcode and telephone number
        daCustomer.InsertCommand = New OleDbCommand("INSERT INTO Customer(FirstName, LastName, HouseNumber, RoadName, Town, Postcode, TelephoneNumber) VALUES(@FirstName,@LastName,@HouseNumber,@RoadName,@Town, @Postcode,@TelephoneNumber)")
        daCustomer.InsertCommand.Connection = conn
        daCustomer.InsertCommand.Parameters.Add("@FirstName", OleDbType.VarChar, 40, "FirstName")
        daCustomer.InsertCommand.Parameters.Add("@LastName", OleDbType.VarChar, 40, "LastName")
        daCustomer.InsertCommand.Parameters.Add("@HouseNumber", OleDbType.VarChar, 40, "HouseNumber")
        daCustomer.InsertCommand.Parameters.Add("@RoadName", OleDbType.VarChar, 40, "RoadName")
        daCustomer.InsertCommand.Parameters.Add("@Town", OleDbType.VarChar, 40, "Town")
        daCustomer.InsertCommand.Parameters.Add("@Postcode", OleDbType.VarChar, 40, "Postcode")
        daCustomer.InsertCommand.Parameters.Add("@TelephoneNumber", OleDbType.VarChar, 40, "TelephoneNumber")

        'This adds a new row and inserts a new customer to the database
        dsCustomer.Tables(0).Rows.Add(dr)
        daCustomer.Update(dsCustomer)
        dsCustomer.AcceptChanges()

    End Sub
End Module
