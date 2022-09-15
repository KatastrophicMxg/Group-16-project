<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGDP
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
        Me.components = New System.ComponentModel.Container()
        Me.grdCountry1 = New UJGrid.UJGrid()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnCountry1 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.grdCountry2 = New UJGrid.UJGrid()
        Me.btnCountry2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'grdCountry1
        '
        Me.grdCountry1.FixedCols = 1
        Me.grdCountry1.FixedRows = 1
        Me.grdCountry1.Location = New System.Drawing.Point(23, 12)
        Me.grdCountry1.Name = "grdCountry1"
        Me.grdCountry1.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdCountry1.Size = New System.Drawing.Size(356, 344)
        Me.grdCountry1.TabIndex = 0
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(23, 427)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(775, 41)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Enter Data"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnCountry1
        '
        Me.btnCountry1.Location = New System.Drawing.Point(23, 374)
        Me.btnCountry1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCountry1.Name = "btnCountry1"
        Me.btnCountry1.Size = New System.Drawing.Size(356, 41)
        Me.btnCountry1.TabIndex = 2
        Me.btnCountry1.Text = "Display Country 1"
        Me.btnCountry1.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'grdCountry2
        '
        Me.grdCountry2.FixedCols = 1
        Me.grdCountry2.FixedRows = 1
        Me.grdCountry2.Location = New System.Drawing.Point(442, 12)
        Me.grdCountry2.Name = "grdCountry2"
        Me.grdCountry2.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdCountry2.Size = New System.Drawing.Size(356, 344)
        Me.grdCountry2.TabIndex = 0
        '
        'btnCountry2
        '
        Me.btnCountry2.Location = New System.Drawing.Point(442, 374)
        Me.btnCountry2.Name = "btnCountry2"
        Me.btnCountry2.Size = New System.Drawing.Size(356, 41)
        Me.btnCountry2.TabIndex = 4
        Me.btnCountry2.Text = "Display Country 2"
        Me.btnCountry2.UseVisualStyleBackColor = True
        '
        'FrmGDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 479)
        Me.Controls.Add(Me.btnCountry2)
        Me.Controls.Add(Me.btnCountry1)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.grdCountry2)
        Me.Controls.Add(Me.grdCountry1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmGDP"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdCountry1 As UJGrid.UJGrid
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnCountry1 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents grdCountry2 As UJGrid.UJGrid
    Friend WithEvents btnCountry2 As Button
End Class
