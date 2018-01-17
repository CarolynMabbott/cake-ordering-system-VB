Imports System.Data.OleDb

Module database

    Structure EmployeeType
        Dim FirstName As String
        Dim LastName As String
        Dim Location As String
    End Structure


    Dim conn As New OleDbConnection()
    Dim ds As New DataSet()
    Dim da As OleDbDataAdapter
    Dim intCurrentIndex As Integer = -1


    Public Sub OpenDatabase()
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=sample.mdb;User Id=admin;Password=;"
        da = New OleDbDataAdapter("SELECT EmployeeID, FirstName, LastName, Location FROM tbl_Master", conn)

        da.SelectCommand = New OleDbCommand("SELECT EmployeeID, FirstName, LastName, Location FROM tbl_Master")
        da.SelectCommand.Connection = conn

        da.UpdateCommand = New OleDbCommand("UPDATE tbl_Master SET FirstName = @FirstName, LastName = @LastName, Location = @Location WHERE EmployeeID = @EmployeeID")
        da.UpdateCommand.Connection = conn
        da.UpdateCommand.Parameters.Add("@FirstName", OleDbType.VarChar, 40, "FirstName")
        da.UpdateCommand.Parameters.Add("@LastName", OleDbType.VarChar, 40, "LastName")
        da.UpdateCommand.Parameters.Add("@Location", OleDbType.VarChar, 40, "Location")
        da.UpdateCommand.Parameters.Add("@EmployeeID", OleDbType.Integer, 5, "EmployeeID") '.SourceVersion = DataRowVersion.Original

        da.InsertCommand = New OleDbCommand("INSERT INTO tbl_Master(FirstName, LastName, Location) VALUES(@FirstName,@LastName,@Location)")
        da.InsertCommand.Connection = conn
        da.InsertCommand.Parameters.Add("@FirstName", OleDbType.VarChar, 40, "FirstName")
        da.InsertCommand.Parameters.Add("@LastName", OleDbType.VarChar, 40, "LastName")
        da.InsertCommand.Parameters.Add("@Location", OleDbType.VarChar, 40, "Location")

        da.DeleteCommand = New OleDbCommand("DELETE FROM tbl_Master WHERE EmployeeID = @EmployeeID")
        da.DeleteCommand.Connection = conn
        da.DeleteCommand.Parameters.Add("@EmployeeID", OleDbType.Integer, 5, "EmployeeID")

        da.Fill(ds)
        intCurrentIndex = 0
    End Sub


    Public Sub SelectEmployeeRecord(ByVal idx As Integer, ByRef ThisEmployee As EmployeeType)
        If intCurrentIndex = -1 Then
            Call OpenDatabase()
        End If

        intCurrentIndex = idx

        ThisEmployee.FirstName = ds.Tables(0).Rows(intCurrentIndex).Item("FirstName").ToString()
        ThisEmployee.LastName = ds.Tables(0).Rows(intCurrentIndex).Item("LastName").ToString()
        ThisEmployee.Location = ds.Tables(0).Rows(intCurrentIndex).Item("Location").ToString()
    End Sub


    Public Function EmployeeRecordCount() As Integer
        If intCurrentIndex = -1 Then
            Call OpenDatabase()
        End If

        EmployeeRecordCount = ds.Tables(0).Rows.Count
    End Function


    Public Sub EmployeeUpdate(ByRef ThisEmployee As EmployeeType)
        Dim dr As DataRow
        dr = ds.Tables(0).Rows(intCurrentIndex) 'This gets a reference to the row currently being edited
        dr.BeginEdit()
        dr("FirstName") = ThisEmployee.FirstName
        dr("LastName") = ThisEmployee.LastName
        dr("Location") = ThisEmployee.Location
        dr.EndEdit()

        da.Update(ds)  'Ask the data adapter to call the UpdateCommand and update the database
        ds.AcceptChanges() 'Commits the change to the dataset.
    End Sub


    Public Sub EmployeeAdd(ByRef ThisEmployee As EmployeeType)
        Dim dr As DataRow

        dr = ds.Tables(0).NewRow()  'Gets a reference to a new row.
        dr("FirstName") = ThisEmployee.FirstName
        dr("LastName") = ThisEmployee.LastName
        dr("Location") = ThisEmployee.Location

        ds.Tables(0).Rows.Add(dr)
        da.Update(ds)
        ds.AcceptChanges()
    End Sub


    Public Sub EmployeeDelete()
        Dim dr As DataRow
        dr = ds.Tables(0).Rows(intCurrentIndex)
        dr.Delete() 'Delete the row

        da.Update(ds)
        ds.AcceptChanges()
    End Sub
End Module
