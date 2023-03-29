<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnImprimirCargos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnImprimirCargos
        '
        Me.BtnImprimirCargos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnImprimirCargos.Font = New System.Drawing.Font("Roboto", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimirCargos.ForeColor = System.Drawing.Color.White
        Me.BtnImprimirCargos.Location = New System.Drawing.Point(63, 23)
        Me.BtnImprimirCargos.Name = "BtnImprimirCargos"
        Me.BtnImprimirCargos.Size = New System.Drawing.Size(240, 62)
        Me.BtnImprimirCargos.TabIndex = 0
        Me.BtnImprimirCargos.Text = "Mostrar Reportes de Cargos"
        Me.BtnImprimirCargos.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 303)
        Me.Controls.Add(Me.BtnImprimirCargos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnImprimirCargos As Button
End Class
