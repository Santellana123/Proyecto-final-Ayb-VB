<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnSaveToJson
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSaveToCSV = New Button()
        btnSaveToXML = New Button()
        CargarCSV = New Button()
        btnSaveToDatabase = New Button()
        btnLoadFromDatabase = New Button()
        DataGridView2 = New DataGridView()
        btnAddrow = New Button()
        btnLoadFile = New Button()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSaveToCSV
        ' 
        btnSaveToCSV.Location = New Point(79, 76)
        btnSaveToCSV.Name = "btnSaveToCSV"
        btnSaveToCSV.Size = New Size(75, 23)
        btnSaveToCSV.TabIndex = 0
        btnSaveToCSV.Text = "Button1"
        btnSaveToCSV.UseVisualStyleBackColor = True
        ' 
        ' btnSaveToXML
        ' 
        btnSaveToXML.Location = New Point(79, 119)
        btnSaveToXML.Name = "btnSaveToXML"
        btnSaveToXML.Size = New Size(75, 23)
        btnSaveToXML.TabIndex = 1
        btnSaveToXML.Text = "Button2"
        btnSaveToXML.UseVisualStyleBackColor = True
        ' 
        ' CargarCSV
        ' 
        CargarCSV.Location = New Point(79, 164)
        CargarCSV.Name = "CargarCSV"
        CargarCSV.Size = New Size(75, 23)
        CargarCSV.TabIndex = 2
        CargarCSV.Text = "Button3"
        CargarCSV.UseVisualStyleBackColor = True
        ' 
        ' btnSaveToDatabase
        ' 
        btnSaveToDatabase.Location = New Point(79, 207)
        btnSaveToDatabase.Name = "btnSaveToDatabase"
        btnSaveToDatabase.Size = New Size(75, 23)
        btnSaveToDatabase.TabIndex = 3
        btnSaveToDatabase.Text = "Button4"
        btnSaveToDatabase.UseVisualStyleBackColor = True
        ' 
        ' btnLoadFromDatabase
        ' 
        btnLoadFromDatabase.Location = New Point(79, 251)
        btnLoadFromDatabase.Name = "btnLoadFromDatabase"
        btnLoadFromDatabase.Size = New Size(75, 23)
        btnLoadFromDatabase.TabIndex = 4
        btnLoadFromDatabase.Text = "Button5"
        btnLoadFromDatabase.UseVisualStyleBackColor = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(252, 80)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(346, 194)
        DataGridView2.TabIndex = 5
        ' 
        ' btnAddrow
        ' 
        btnAddrow.Location = New Point(84, 289)
        btnAddrow.Name = "btnAddrow"
        btnAddrow.Size = New Size(75, 23)
        btnAddrow.TabIndex = 6
        btnAddrow.Text = "Button1"
        btnAddrow.UseVisualStyleBackColor = True
        ' 
        ' btnLoadFile
        ' 
        btnLoadFile.Location = New Point(90, 324)
        btnLoadFile.Name = "btnLoadFile"
        btnLoadFile.Size = New Size(75, 23)
        btnLoadFile.TabIndex = 7
        btnLoadFile.Text = "Button1"
        btnLoadFile.UseVisualStyleBackColor = True
        ' 
        ' btnSaveToJson
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLoadFile)
        Controls.Add(btnAddrow)
        Controls.Add(DataGridView2)
        Controls.Add(btnLoadFromDatabase)
        Controls.Add(btnSaveToDatabase)
        Controls.Add(CargarCSV)
        Controls.Add(btnSaveToXML)
        Controls.Add(btnSaveToCSV)
        Name = "btnSaveToJson"
        Text = "Form1"
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnSaveToCSV As Button
    Friend WithEvents btnSaveToXML As Button
    Friend WithEvents CargarCSV As Button
    Friend WithEvents btnSaveToDatabase As Button
    Friend WithEvents btnLoadFromDatabase As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnAddrow As Button
    Friend WithEvents btnLoadFile As Button

End Class
