Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports System.Text
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Xml
Public Class Form1
    Private sqlConnection As SqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComponent()
        InitializeDatabaseConnection()
    End Sub
    Private Sub InitializeDatabaseConnection()
        Dim connectionString As String = "Server=NOMBREDETUMAQUINA\SQLEXPRESS;Database=Nissan;Integrated Security=True;"
        sqlConnection = New SqlConnection(connectionString)
    End Sub

    Private Sub SaveDataToDatabase()
        Try
            sqlConnection.Open()
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Autos", sqlConnection)
            Dim sqlCommandBuilder As SqlCommandBuilder = New SqlCommandBuilder(sqlDataAdapter)
            Dim dataTable As DataTable = CType(DataGridView2.DataSource, DataTable)
            sqlDataAdapter.Update(dataTable)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub CargarCSV(ByVal filePath As String)
        Try
            Dim dataTable As DataTable = New DataTable()

            Using sr As StreamReader = New StreamReader(filePath)
                Dim headers As String() = sr.ReadLine().Split(","c)

                For Each header As String In headers
                    dataTable.Columns.Add(header)
                Next

                While Not sr.EndOfStream
                    Dim rows As String() = sr.ReadLine().Split(","c)
                    Dim dataRow As DataRow = dataTable.NewRow()

                    For i As Integer = 0 To headers.Length - 1
                        dataRow(i) = rows(i)
                    Next

                    dataTable.Rows.Add(dataRow)
                End While
            End Using

            DataGridView2.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error loading CSV: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarXML(ByVal filePath As String)
        Try
            Dim dataSet As DataSet = New DataSet()
            dataSet.ReadXml(filePath)
            DataGridView2.DataSource = dataSet.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error loading XML: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarJSON(ByVal filePath As String)
        Try
            Dim jsonData As String = File.ReadAllText(filePath)
            Dim dataTable As DataTable = JsonConvert.DeserializeObject(Of DataTable)(jsonData)
            DataGridView2.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error loading JSON: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadDataFromDatabase()
        Try
            sqlConnection.Open()
            Dim sqlDataAdapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Autos", sqlConnection)
            Dim dataTable As DataTable = New DataTable()
            sqlDataAdapter.Fill(dataTable)
            DataGridView2.DataSource = dataTable
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    Private Sub btnSaveToCSV_Click(sender As Object, e As EventArgs) Handles btnSaveToCSV.Click
        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "CSV files (.csv)|.csv"
        saveFileDialog.Title = "Save data to CSV"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            CargarCSV(filePath)
        End If
    End Sub

    Private Sub btnSaveToXML_Click(sender As Object, e As EventArgs) Handles btnSaveToXML.Click
        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "XML files (.xml)|.xml"
        saveFileDialog.Title = "Save data to XML"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            CargarXML(filePath)
        End If
    End Sub

    Private Sub btnSaveToJson_Click(sender As Object, e As EventArgs) Handles btnSaveToJson.Click
        Dim saveFileDialog As SaveFileDialog = New SaveFileDialog()
        saveFileDialog.Filter = "JSON files (.json)|.json"
        saveFileDialog.Title = "Save data to XML"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = saveFileDialog.FileName
            CargarJSON(filePath)
        End If
    End Sub

    Private Sub btnSaveToDatabase_Click(sender As Object, e As EventArgs) Handles btnSaveToDatabase.Click
        SaveDataToDatabase()

    End Sub

    Private Sub btnLoadFromDatabase_Click(sender As Object, e As EventArgs) Handles btnLoadFromDatabase.Click
        LoadDataFromDatabase()
    End Sub

    Private Sub btnAddrow_Click(sender As Object, e As EventArgs) Handles btnAddrow.Click
        Dim dataTable As DataTable = CType(DataGridView2.DataSource, DataTable)
        Dim newRow As DataRow = dataTable.NewRow()

        For i As Integer = 0 To dataTable.Columns.Count - 1
            newRow(i) = DBNull.Value
        Next

        dataTable.Rows.Add(newRow)
        DataGridView2.Refresh()
    End Sub

    Private Sub btnLoadFile_Click(sender As Object, e As EventArgs) Handles btnLoadFile.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog With {
               .Filter = "CSV files (.csv)|.csv|XML files (.xml)|.xml|JSON files (.json)|.json"
           }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            Dim extension As String = Path.GetExtension(filePath).ToLower()

            Select Case extension
                Case ".csv"
                    CargarCSV(filePath)
                Case ".xml"
                    CargarXML(filePath)
                Case ".json"
                    CargarJSON(filePath)
                Case Else
                    MessageBox.Show("Escoje el formato correcto")
            End Select
        End If
    End Sub
End Class
