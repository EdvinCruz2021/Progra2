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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Total = New System.Windows.Forms.ListBox()
        Me.Descuento2 = New System.Windows.Forms.ListBox()
        Me.Descuento1 = New System.Windows.Forms.ListBox()
        Me.SubTotal = New System.Windows.Forms.ListBox()
        Me.Funcion = New System.Windows.Forms.ListBox()
        Me.Cine = New System.Windows.Forms.ListBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NumEntradas = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 165)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elegir el cine y la función"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(234, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox2.Location = New System.Drawing.Point(81, 75)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Función:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cine:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(81, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(423, 76)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Limpiar Entradas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox2.Controls.Add(Me.NumEntradas)
        Me.GroupBox2.Controls.Add(Me.Total)
        Me.GroupBox2.Controls.Add(Me.Descuento2)
        Me.GroupBox2.Controls.Add(Me.Descuento1)
        Me.GroupBox2.Controls.Add(Me.SubTotal)
        Me.GroupBox2.Controls.Add(Me.Funcion)
        Me.GroupBox2.Controls.Add(Me.Cine)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 140)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precios"
        '
        'Total
        '
        Me.Total.FormattingEnabled = True
        Me.Total.ItemHeight = 15
        Me.Total.Location = New System.Drawing.Point(428, 22)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(69, 109)
        Me.Total.TabIndex = 12
        '
        'Descuento2
        '
        Me.Descuento2.FormattingEnabled = True
        Me.Descuento2.ItemHeight = 15
        Me.Descuento2.Location = New System.Drawing.Point(341, 22)
        Me.Descuento2.Name = "Descuento2"
        Me.Descuento2.Size = New System.Drawing.Size(69, 109)
        Me.Descuento2.TabIndex = 11
        '
        'Descuento1
        '
        Me.Descuento1.FormattingEnabled = True
        Me.Descuento1.ItemHeight = 15
        Me.Descuento1.Location = New System.Drawing.Point(255, 22)
        Me.Descuento1.Name = "Descuento1"
        Me.Descuento1.Size = New System.Drawing.Size(69, 109)
        Me.Descuento1.TabIndex = 10
        '
        'SubTotal
        '
        Me.SubTotal.FormattingEnabled = True
        Me.SubTotal.ItemHeight = 15
        Me.SubTotal.Location = New System.Drawing.Point(170, 22)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Size = New System.Drawing.Size(69, 109)
        Me.SubTotal.TabIndex = 9
        '
        'Funcion
        '
        Me.Funcion.FormattingEnabled = True
        Me.Funcion.ItemHeight = 15
        Me.Funcion.Location = New System.Drawing.Point(85, 22)
        Me.Funcion.Name = "Funcion"
        Me.Funcion.Size = New System.Drawing.Size(69, 109)
        Me.Funcion.TabIndex = 8
        '
        'Cine
        '
        Me.Cine.FormattingEnabled = True
        Me.Cine.ItemHeight = 15
        Me.Cine.Location = New System.Drawing.Point(6, 22)
        Me.Cine.Name = "Cine"
        Me.Cine.Size = New System.Drawing.Size(69, 109)
        Me.Cine.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(423, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(132, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Limpiar Listas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(423, 134)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NumEntradas
        '
        Me.NumEntradas.FormattingEnabled = True
        Me.NumEntradas.ItemHeight = 15
        Me.NumEntradas.Location = New System.Drawing.Point(503, 22)
        Me.NumEntradas.Name = "NumEntradas"
        Me.NumEntradas.Size = New System.Drawing.Size(88, 109)
        Me.NumEntradas.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201903869_TAREA5.My.Resources.Resources.cine
        Me.ClientSize = New System.Drawing.Size(681, 344)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "FUNCION DE CINE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Total As ListBox
    Friend WithEvents Descuento2 As ListBox
    Friend WithEvents Descuento1 As ListBox
    Friend WithEvents SubTotal As ListBox
    Friend WithEvents Funcion As ListBox
    Friend WithEvents Cine As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NumEntradas As ListBox
End Class
