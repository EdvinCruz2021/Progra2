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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.montoEF = New System.Windows.Forms.TextBox()
        Me.montoCOB = New System.Windows.Forms.TextBox()
        Me.montoCP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.saldoAnterior = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.saldoNuevo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtinteres = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de Depósitos:"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(6, 84)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(62, 19)
        Me.RadioButton3.TabIndex = 6
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Ahorro"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 59)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(124, 19)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Monetario Premier"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 34)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 19)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Monetario"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 132)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Métodos de Depósitos:"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(25, 85)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(68, 19)
        Me.CheckBox3.TabIndex = 6
        Me.CheckBox3.Text = "Efectivo"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(25, 59)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(130, 19)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "Cheque Otro Banco"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(25, 34)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 19)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Cheque Primo"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.montoEF)
        Me.GroupBox3.Controls.Add(Me.montoCOB)
        Me.GroupBox3.Controls.Add(Me.montoCP)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(434, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 132)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Monto:"
        '
        'montoEF
        '
        Me.montoEF.Enabled = False
        Me.montoEF.Location = New System.Drawing.Point(44, 85)
        Me.montoEF.Name = "montoEF"
        Me.montoEF.Size = New System.Drawing.Size(100, 23)
        Me.montoEF.TabIndex = 8
        Me.montoEF.Text = "0"
        '
        'montoCOB
        '
        Me.montoCOB.Enabled = False
        Me.montoCOB.Location = New System.Drawing.Point(44, 55)
        Me.montoCOB.Name = "montoCOB"
        Me.montoCOB.Size = New System.Drawing.Size(100, 23)
        Me.montoCOB.TabIndex = 7
        Me.montoCOB.Text = "0"
        '
        'montoCP
        '
        Me.montoCP.Enabled = False
        Me.montoCP.Location = New System.Drawing.Point(44, 26)
        Me.montoCP.Name = "montoCP"
        Me.montoCP.Size = New System.Drawing.Size(100, 23)
        Me.montoCP.TabIndex = 4
        Me.montoCP.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Q"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Q"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Q"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.saldoAnterior)
        Me.GroupBox4.Location = New System.Drawing.Point(640, 48)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(170, 66)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Saldo Anterior"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Q"
        '
        'saldoAnterior
        '
        Me.saldoAnterior.Location = New System.Drawing.Point(64, 22)
        Me.saldoAnterior.Name = "saldoAnterior"
        Me.saldoAnterior.Size = New System.Drawing.Size(100, 23)
        Me.saldoAnterior.TabIndex = 5
        Me.saldoAnterior.Text = "0"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(666, 133)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 4
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Saldo Nuevo:"
        '
        'saldoNuevo
        '
        Me.saldoNuevo.AutoSize = True
        Me.saldoNuevo.Location = New System.Drawing.Point(271, 214)
        Me.saldoNuevo.Name = "saldoNuevo"
        Me.saldoNuevo.Size = New System.Drawing.Size(13, 15)
        Me.saldoNuevo.TabIndex = 6
        Me.saldoNuevo.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 15)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Interés:"
        '
        'txtinteres
        '
        Me.txtinteres.AutoSize = True
        Me.txtinteres.Location = New System.Drawing.Point(271, 251)
        Me.txtinteres.Name = "txtinteres"
        Me.txtinteres.Size = New System.Drawing.Size(13, 15)
        Me.txtinteres.TabIndex = 8
        Me.txtinteres.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(666, 175)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(503, 236)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(115, 38)
        Me.btnsalir.TabIndex = 7
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(826, 450)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtinteres)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.saldoNuevo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "BANCO S.A."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents montoEF As TextBox
    Friend WithEvents montoCOB As TextBox
    Friend WithEvents montoCP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents saldoAnterior As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents saldoNuevo As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtinteres As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnsalir As Button
End Class
