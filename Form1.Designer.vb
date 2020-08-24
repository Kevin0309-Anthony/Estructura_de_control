<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnparoimpar = New System.Windows.Forms.Button()
        Me.btnprimo = New System.Windows.Forms.Button()
        Me.btncajero = New System.Windows.Forms.Button()
        Me.IstEjercicios = New System.Windows.Forms.ListBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(70, 49)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(42, 13)
        Me.lblnumero.TabIndex = 0
        Me.lblnumero.Text = "numero"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(115, 46)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(100, 20)
        Me.txtnum.TabIndex = 1
        '
        'btnparoimpar
        '
        Me.btnparoimpar.Location = New System.Drawing.Point(55, 97)
        Me.btnparoimpar.Name = "btnparoimpar"
        Me.btnparoimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnparoimpar.TabIndex = 2
        Me.btnparoimpar.Text = "Par o impar?"
        Me.btnparoimpar.UseVisualStyleBackColor = True
        '
        'btnprimo
        '
        Me.btnprimo.Location = New System.Drawing.Point(136, 97)
        Me.btnprimo.Name = "btnprimo"
        Me.btnprimo.Size = New System.Drawing.Size(75, 23)
        Me.btnprimo.TabIndex = 3
        Me.btnprimo.Text = "Primo?"
        Me.btnprimo.UseVisualStyleBackColor = True
        '
        'btncajero
        '
        Me.btncajero.Location = New System.Drawing.Point(217, 97)
        Me.btncajero.Name = "btncajero"
        Me.btncajero.Size = New System.Drawing.Size(75, 23)
        Me.btncajero.TabIndex = 4
        Me.btncajero.Text = "Cajero"
        Me.btncajero.UseVisualStyleBackColor = True
        '
        'IstEjercicios
        '
        Me.IstEjercicios.FormattingEnabled = True
        Me.IstEjercicios.Location = New System.Drawing.Point(307, 25)
        Me.IstEjercicios.Name = "IstEjercicios"
        Me.IstEjercicios.Size = New System.Drawing.Size(159, 173)
        Me.IstEjercicios.TabIndex = 5
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(307, 205)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(159, 23)
        Me.btnProcesar.TabIndex = 6
        Me.btnProcesar.Text = "Mostrar pares e impares"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.IstEjercicios)
        Me.Controls.Add(Me.btncajero)
        Me.Controls.Add(Me.btnprimo)
        Me.Controls.Add(Me.btnparoimpar)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.lblnumero)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblnumero As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnparoimpar As Button
    Friend WithEvents btnprimo As Button
    Friend WithEvents btncajero As Button
    Friend WithEvents IstEjercicios As ListBox
    Friend WithEvents btnProcesar As Button
End Class
