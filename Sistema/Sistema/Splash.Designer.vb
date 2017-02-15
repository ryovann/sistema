<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTrabajoActual = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTrabajoActual
        '
        Me.lblTrabajoActual.AutoSize = True
        Me.lblTrabajoActual.Font = New System.Drawing.Font("Segoe Print", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrabajoActual.Location = New System.Drawing.Point(197, 248)
        Me.lblTrabajoActual.Name = "lblTrabajoActual"
        Me.lblTrabajoActual.Size = New System.Drawing.Size(245, 61)
        Me.lblTrabajoActual.TabIndex = 0
        Me.lblTrabajoActual.Text = "Inicializando"
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sistema.My.Resources.Resources.MainBackground1
        Me.ClientSize = New System.Drawing.Size(638, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTrabajoActual)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTrabajoActual As Label
End Class
