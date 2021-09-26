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
        Me.combo_Marca = New System.Windows.Forms.ComboBox()
        Me.txt_dia = New System.Windows.Forms.TextBox()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.txt_nit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Check_Tarjeta = New System.Windows.Forms.CheckBox()
        Me.Check_Efectivo = New System.Windows.Forms.CheckBox()
        Me.txt_tarjeta = New System.Windows.Forms.TextBox()
        Me.txt_efec = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.List_Total = New System.Windows.Forms.ListBox()
        Me.List_Descuento = New System.Windows.Forms.ListBox()
        Me.List_Parcial = New System.Windows.Forms.ListBox()
        Me.List_Dias = New System.Windows.Forms.ListBox()
        Me.List_Marca = New System.Windows.Forms.ListBox()
        Me.List_Placa = New System.Windows.Forms.ListBox()
        Me.List_NIT = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalcularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.combo_Marca)
        Me.GroupBox1.Controls.Add(Me.txt_dia)
        Me.GroupBox1.Controls.Add(Me.txt_placa)
        Me.GroupBox1.Controls.Add(Me.txt_nit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos"
        '
        'combo_Marca
        '
        Me.combo_Marca.FormattingEnabled = True
        Me.combo_Marca.Items.AddRange(New Object() {"Honda", "Toyota", "Mazda", "Mercedez Benz"})
        Me.combo_Marca.Location = New System.Drawing.Point(173, 95)
        Me.combo_Marca.Name = "combo_Marca"
        Me.combo_Marca.Size = New System.Drawing.Size(121, 23)
        Me.combo_Marca.TabIndex = 7
        '
        'txt_dia
        '
        Me.txt_dia.Location = New System.Drawing.Point(173, 132)
        Me.txt_dia.Name = "txt_dia"
        Me.txt_dia.Size = New System.Drawing.Size(100, 23)
        Me.txt_dia.TabIndex = 6
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(173, 26)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(100, 23)
        Me.txt_placa.TabIndex = 5
        '
        'txt_nit
        '
        Me.txt_nit.Location = New System.Drawing.Point(173, 62)
        Me.txt_nit.Name = "txt_nit"
        Me.txt_nit.Size = New System.Drawing.Size(100, 23)
        Me.txt_nit.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "No. de días que alquilará"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Seleccione la Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ingrese su Placa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NIT:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Lime
        Me.GroupBox2.Controls.Add(Me.Check_Tarjeta)
        Me.GroupBox2.Controls.Add(Me.Check_Efectivo)
        Me.GroupBox2.Controls.Add(Me.txt_tarjeta)
        Me.GroupBox2.Controls.Add(Me.txt_efec)
        Me.GroupBox2.Location = New System.Drawing.Point(420, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 118)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Forma de Pago"
        '
        'Check_Tarjeta
        '
        Me.Check_Tarjeta.AutoSize = True
        Me.Check_Tarjeta.Location = New System.Drawing.Point(6, 64)
        Me.Check_Tarjeta.Name = "Check_Tarjeta"
        Me.Check_Tarjeta.Size = New System.Drawing.Size(60, 19)
        Me.Check_Tarjeta.TabIndex = 4
        Me.Check_Tarjeta.Text = "Tarjeta"
        Me.Check_Tarjeta.UseVisualStyleBackColor = True
        '
        'Check_Efectivo
        '
        Me.Check_Efectivo.AutoSize = True
        Me.Check_Efectivo.Location = New System.Drawing.Point(6, 26)
        Me.Check_Efectivo.Name = "Check_Efectivo"
        Me.Check_Efectivo.Size = New System.Drawing.Size(68, 19)
        Me.Check_Efectivo.TabIndex = 2
        Me.Check_Efectivo.Text = "Efectivo"
        Me.Check_Efectivo.UseVisualStyleBackColor = True
        '
        'txt_tarjeta
        '
        Me.txt_tarjeta.Location = New System.Drawing.Point(109, 62)
        Me.txt_tarjeta.Name = "txt_tarjeta"
        Me.txt_tarjeta.Size = New System.Drawing.Size(100, 23)
        Me.txt_tarjeta.TabIndex = 3
        '
        'txt_efec
        '
        Me.txt_efec.Location = New System.Drawing.Point(109, 22)
        Me.txt_efec.Name = "txt_efec"
        Me.txt_efec.Size = New System.Drawing.Size(100, 23)
        Me.txt_efec.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox3.Controls.Add(Me.List_Total)
        Me.GroupBox3.Controls.Add(Me.List_Descuento)
        Me.GroupBox3.Controls.Add(Me.List_Parcial)
        Me.GroupBox3.Controls.Add(Me.List_Dias)
        Me.GroupBox3.Controls.Add(Me.List_Marca)
        Me.GroupBox3.Controls.Add(Me.List_Placa)
        Me.GroupBox3.Controls.Add(Me.List_NIT)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(901, 230)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'List_Total
        '
        Me.List_Total.FormattingEnabled = True
        Me.List_Total.ItemHeight = 15
        Me.List_Total.Location = New System.Drawing.Point(769, 50)
        Me.List_Total.Name = "List_Total"
        Me.List_Total.Size = New System.Drawing.Size(120, 169)
        Me.List_Total.TabIndex = 6
        '
        'List_Descuento
        '
        Me.List_Descuento.FormattingEnabled = True
        Me.List_Descuento.ItemHeight = 15
        Me.List_Descuento.Location = New System.Drawing.Point(643, 50)
        Me.List_Descuento.Name = "List_Descuento"
        Me.List_Descuento.Size = New System.Drawing.Size(120, 169)
        Me.List_Descuento.TabIndex = 5
        '
        'List_Parcial
        '
        Me.List_Parcial.FormattingEnabled = True
        Me.List_Parcial.ItemHeight = 15
        Me.List_Parcial.Location = New System.Drawing.Point(517, 50)
        Me.List_Parcial.Name = "List_Parcial"
        Me.List_Parcial.Size = New System.Drawing.Size(120, 169)
        Me.List_Parcial.TabIndex = 4
        '
        'List_Dias
        '
        Me.List_Dias.FormattingEnabled = True
        Me.List_Dias.ItemHeight = 15
        Me.List_Dias.Location = New System.Drawing.Point(389, 50)
        Me.List_Dias.Name = "List_Dias"
        Me.List_Dias.Size = New System.Drawing.Size(120, 169)
        Me.List_Dias.TabIndex = 3
        '
        'List_Marca
        '
        Me.List_Marca.FormattingEnabled = True
        Me.List_Marca.ItemHeight = 15
        Me.List_Marca.Location = New System.Drawing.Point(263, 50)
        Me.List_Marca.Name = "List_Marca"
        Me.List_Marca.Size = New System.Drawing.Size(120, 169)
        Me.List_Marca.TabIndex = 2
        '
        'List_Placa
        '
        Me.List_Placa.FormattingEnabled = True
        Me.List_Placa.ItemHeight = 15
        Me.List_Placa.Location = New System.Drawing.Point(137, 50)
        Me.List_Placa.Name = "List_Placa"
        Me.List_Placa.Size = New System.Drawing.Size(120, 169)
        Me.List_Placa.TabIndex = 1
        '
        'List_NIT
        '
        Me.List_NIT.FormattingEnabled = True
        Me.List_NIT.ItemHeight = 15
        Me.List_NIT.Location = New System.Drawing.Point(11, 50)
        Me.List_NIT.Name = "List_NIT"
        Me.List_NIT.Size = New System.Drawing.Size(120, 169)
        Me.List_NIT.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcularToolStripMenuItem, Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem, Me.LimpiarListasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(925, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalcularToolStripMenuItem
        '
        Me.CalcularToolStripMenuItem.Name = "CalcularToolStripMenuItem"
        Me.CalcularToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CalcularToolStripMenuItem.Text = "&Calcular"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'LimpiarListasToolStripMenuItem
        '
        Me.LimpiarListasToolStripMenuItem.Name = "LimpiarListasToolStripMenuItem"
        Me.LimpiarListasToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.LimpiarListasToolStripMenuItem.Text = "Limpiar Listas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 457)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "RENTAUTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents combo_Marca As ComboBox
    Friend WithEvents txt_dia As TextBox
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents txt_nit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Check_Tarjeta As CheckBox
    Friend WithEvents Check_Efectivo As CheckBox
    Friend WithEvents txt_tarjeta As TextBox
    Friend WithEvents txt_efec As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents List_Total As ListBox
    Friend WithEvents List_Descuento As ListBox
    Friend WithEvents List_Parcial As ListBox
    Friend WithEvents List_Dias As ListBox
    Friend WithEvents List_Marca As ListBox
    Friend WithEvents List_Placa As ListBox
    Friend WithEvents List_NIT As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalcularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
