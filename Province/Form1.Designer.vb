<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lbl_NewPr = New System.Windows.Forms.Label()
        Me.DataSet1 = New System.Data.DataSet()
        Me.tbl_Prov = New System.Data.DataTable()
        Me.Prov = New System.Data.DataColumn()
        Me.Reg = New System.Data.DataColumn()
        Me.Load = New System.Data.DataColumn()
        Me.Correct = New System.Data.DataColumn()
        Me.tbl_Regions = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.lbl_NewPr_d = New System.Windows.Forms.Label()
        Me.lbl_Done_d = New System.Windows.Forms.Label()
        Me.lbl_Done = New System.Windows.Forms.Label()
        Me.lbl_Correct = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_Prov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_Regions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_NewPr
        '
        Me.lbl_NewPr.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NewPr.Font = New System.Drawing.Font("Maiandra GD", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NewPr.ForeColor = System.Drawing.Color.DarkBlue
        Me.lbl_NewPr.Location = New System.Drawing.Point(547, 82)
        Me.lbl_NewPr.Name = "lbl_NewPr"
        Me.lbl_NewPr.Size = New System.Drawing.Size(358, 64)
        Me.lbl_NewPr.TabIndex = 0
        Me.lbl_NewPr.Text = "Label1"
        Me.lbl_NewPr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Tables.AddRange(New System.Data.DataTable() {Me.tbl_Prov, Me.tbl_Regions})
        '
        'tbl_Prov
        '
        Me.tbl_Prov.Columns.AddRange(New System.Data.DataColumn() {Me.Prov, Me.Reg, Me.Load, Me.Correct})
        Me.tbl_Prov.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"Prov"}, False)})
        Me.tbl_Prov.TableName = "Prov"
        '
        'Prov
        '
        Me.Prov.ColumnName = "Prov"
        Me.Prov.ReadOnly = True
        '
        'Reg
        '
        Me.Reg.ColumnName = "Reg"
        Me.Reg.ReadOnly = True
        '
        'Load
        '
        Me.Load.ColumnName = "Load"
        Me.Load.DataType = GetType(Boolean)
        '
        'Correct
        '
        Me.Correct.Caption = "Correct"
        Me.Correct.ColumnName = "Correct"
        Me.Correct.DataType = GetType(Boolean)
        '
        'tbl_Regions
        '
        Me.tbl_Regions.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1})
        Me.tbl_Regions.Constraints.AddRange(New System.Data.Constraint() {New System.Data.UniqueConstraint("Constraint1", New String() {"Region"}, False)})
        Me.tbl_Regions.TableName = "Regions"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "Region"
        Me.DataColumn1.ReadOnly = True
        '
        'lbl_NewPr_d
        '
        Me.lbl_NewPr_d.BackColor = System.Drawing.Color.Transparent
        Me.lbl_NewPr_d.Font = New System.Drawing.Font("Maiandra GD", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NewPr_d.Location = New System.Drawing.Point(470, 18)
        Me.lbl_NewPr_d.Name = "lbl_NewPr_d"
        Me.lbl_NewPr_d.Size = New System.Drawing.Size(502, 64)
        Me.lbl_NewPr_d.TabIndex = 1
        Me.lbl_NewPr_d.Text = "Indical la regione per:"
        Me.lbl_NewPr_d.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Done_d
        '
        Me.lbl_Done_d.AutoSize = True
        Me.lbl_Done_d.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Done_d.Location = New System.Drawing.Point(42, 46)
        Me.lbl_Done_d.Name = "lbl_Done_d"
        Me.lbl_Done_d.Size = New System.Drawing.Size(67, 29)
        Me.lbl_Done_d.TabIndex = 2
        Me.lbl_Done_d.Text = "Fatte"
        '
        'lbl_Done
        '
        Me.lbl_Done.AutoSize = True
        Me.lbl_Done.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Done.Location = New System.Drawing.Point(115, 46)
        Me.lbl_Done.Name = "lbl_Done"
        Me.lbl_Done.Size = New System.Drawing.Size(26, 29)
        Me.lbl_Done.TabIndex = 3
        Me.lbl_Done.Text = "0"
        '
        'lbl_Correct
        '
        Me.lbl_Correct.AutoSize = True
        Me.lbl_Correct.Location = New System.Drawing.Point(223, 34)
        Me.lbl_Correct.Name = "lbl_Correct"
        Me.lbl_Correct.Size = New System.Drawing.Size(16, 17)
        Me.lbl_Correct.TabIndex = 4
        Me.lbl_Correct.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1048, 629)
        Me.Controls.Add(Me.lbl_Correct)
        Me.Controls.Add(Me.lbl_Done)
        Me.Controls.Add(Me.lbl_Done_d)
        Me.Controls.Add(Me.lbl_NewPr_d)
        Me.Controls.Add(Me.lbl_NewPr)
        Me.Name = "Form1"
        Me.Text = "Province Italine"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_Prov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_Regions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_NewPr As Label
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents tbl_Prov As DataTable
    Friend WithEvents Prov As DataColumn
    Friend WithEvents Reg As DataColumn
    Friend WithEvents Load As DataColumn
    Friend WithEvents Correct As DataColumn
    Friend WithEvents tbl_Regions As DataTable
    Friend WithEvents DataColumn1 As DataColumn
    Friend WithEvents lbl_NewPr_d As Label
    Friend WithEvents lbl_Done_d As Label
    Friend WithEvents lbl_Done As Label
    Friend WithEvents lbl_Correct As Label
End Class
