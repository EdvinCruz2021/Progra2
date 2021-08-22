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
        Me.Imperial = New System.Windows.Forms.RadioButton()
        Me.Matrimonial = New System.Windows.Forms.RadioButton()
        Me.Queen = New System.Windows.Forms.RadioButton()
        Me.King = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtlino = New System.Windows.Forms.TextBox()
        Me.txtalgodon = New System.Windows.Forms.TextBox()
        Me.txtseda = New System.Windows.Forms.TextBox()
        Me.txthilo = New System.Windows.Forms.TextBox()
        Me.Lino = New System.Windows.Forms.CheckBox()
        Me.Algodón = New System.Windows.Forms.CheckBox()
        Me.Seda = New System.Windows.Forms.CheckBox()
        Me.HiloCrudo = New System.Windows.Forms.CheckBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrecioC = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Imperial)
        Me.GroupBox1.Controls.Add(Me.Matrimonial)
        Me.GroupBox1.Controls.Add(Me.Queen)
        Me.GroupBox1.Controls.Add(Me.King)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'Imperial
        '
        Me.Imperial.AutoSize = True
        Me.Imperial.Location = New System.Drawing.Point(27, 97)
        Me.Imperial.Name = "Imperial"
        Me.Imperial.Size = New System.Drawing.Size(68, 19)
        Me.Imperial.TabIndex = 4
        Me.Imperial.TabStop = True
        Me.Imperial.Text = "Imperial"
        Me.Imperial.UseVisualStyleBackColor = True
        '
        'Matrimonial
        '
        Me.Matrimonial.AutoSize = True
        Me.Matrimonial.Location = New System.Drawing.Point(27, 72)
        Me.Matrimonial.Name = "Matrimonial"
        Me.Matrimonial.Size = New System.Drawing.Size(90, 19)
        Me.Matrimonial.TabIndex = 3
        Me.Matrimonial.TabStop = True
        Me.Matrimonial.Text = "Matrimonial"
        Me.Matrimonial.UseVisualStyleBackColor = True
        '
        'Queen
        '
        Me.Queen.AutoSize = True
        Me.Queen.Location = New System.Drawing.Point(27, 47)
        Me.Queen.Name = "Queen"
        Me.Queen.Size = New System.Drawing.Size(60, 19)
        Me.Queen.TabIndex = 2
        Me.Queen.TabStop = True
        Me.Queen.Text = "Queen"
        Me.Queen.UseVisualStyleBackColor = True
        '
        'King
        '
        Me.King.AutoSize = True
        Me.King.Location = New System.Drawing.Point(27, 22)
        Me.King.Name = "King"
        Me.King.Size = New System.Drawing.Size(49, 19)
        Me.King.TabIndex = 1
        Me.King.TabStop = True
        Me.King.Text = "King"
        Me.King.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtlino)
        Me.GroupBox2.Controls.Add(Me.txtalgodon)
        Me.GroupBox2.Controls.Add(Me.txtseda)
        Me.GroupBox2.Controls.Add(Me.txthilo)
        Me.GroupBox2.Controls.Add(Me.Lino)
        Me.GroupBox2.Controls.Add(Me.Algodón)
        Me.GroupBox2.Controls.Add(Me.Seda)
        Me.GroupBox2.Controls.Add(Me.HiloCrudo)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 144)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'txtlino
        '
        Me.txtlino.Enabled = False
        Me.txtlino.Location = New System.Drawing.Point(169, 105)
        Me.txtlino.Name = "txtlino"
        Me.txtlino.Size = New System.Drawing.Size(100, 23)
        Me.txtlino.TabIndex = 11
        Me.txtlino.Text = "0"
        '
        'txtalgodon
        '
        Me.txtalgodon.Enabled = False
        Me.txtalgodon.Location = New System.Drawing.Point(169, 76)
        Me.txtalgodon.Name = "txtalgodon"
        Me.txtalgodon.Size = New System.Drawing.Size(100, 23)
        Me.txtalgodon.TabIndex = 11
        Me.txtalgodon.Text = "0"
        '
        'txtseda
        '
        Me.txtseda.Enabled = False
        Me.txtseda.Location = New System.Drawing.Point(169, 47)
        Me.txtseda.Name = "txtseda"
        Me.txtseda.Size = New System.Drawing.Size(100, 23)
        Me.txtseda.TabIndex = 11
        Me.txtseda.Text = "0"
        '
        'txthilo
        '
        Me.txthilo.Enabled = False
        Me.txthilo.Location = New System.Drawing.Point(169, 18)
        Me.txthilo.Name = "txthilo"
        Me.txthilo.Size = New System.Drawing.Size(100, 23)
        Me.txthilo.TabIndex = 10
        Me.txthilo.Text = "0"
        '
        'Lino
        '
        Me.Lino.AutoSize = True
        Me.Lino.Location = New System.Drawing.Point(27, 97)
        Me.Lino.Name = "Lino"
        Me.Lino.Size = New System.Drawing.Size(49, 19)
        Me.Lino.TabIndex = 9
        Me.Lino.Text = "Lino"
        Me.Lino.UseVisualStyleBackColor = True
        '
        'Algodón
        '
        Me.Algodón.AutoSize = True
        Me.Algodón.Location = New System.Drawing.Point(27, 72)
        Me.Algodón.Name = "Algodón"
        Me.Algodón.Size = New System.Drawing.Size(72, 19)
        Me.Algodón.TabIndex = 8
        Me.Algodón.Text = "Algodón"
        Me.Algodón.UseVisualStyleBackColor = True
        '
        'Seda
        '
        Me.Seda.AutoSize = True
        Me.Seda.Location = New System.Drawing.Point(27, 47)
        Me.Seda.Name = "Seda"
        Me.Seda.Size = New System.Drawing.Size(51, 19)
        Me.Seda.TabIndex = 7
        Me.Seda.Text = "Seda"
        Me.Seda.UseVisualStyleBackColor = True
        '
        'HiloCrudo
        '
        Me.HiloCrudo.AutoSize = True
        Me.HiloCrudo.Location = New System.Drawing.Point(27, 22)
        Me.HiloCrudo.Name = "HiloCrudo"
        Me.HiloCrudo.Size = New System.Drawing.Size(84, 19)
        Me.HiloCrudo.TabIndex = 6
        Me.HiloCrudo.Text = "Hilo Crudo"
        Me.HiloCrudo.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(194, 352)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 12
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Precio de Costo Q:"
        '
        'lblPrecioC
        '
        Me.lblPrecioC.AutoSize = True
        Me.lblPrecioC.Location = New System.Drawing.Point(533, 50)
        Me.lblPrecioC.Name = "lblPrecioC"
        Me.lblPrecioC.Size = New System.Drawing.Size(28, 15)
        Me.lblPrecioC.TabIndex = 14
        Me.lblPrecioC.Text = "0.00"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(307, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(426, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 387)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPrecioC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Imperial As RadioButton
    Friend WithEvents Matrimonial As RadioButton
    Friend WithEvents Queen As RadioButton
    Friend WithEvents King As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lino As CheckBox
    Friend WithEvents Algodón As CheckBox
    Friend WithEvents Seda As CheckBox
    Friend WithEvents HiloCrudo As CheckBox
    Friend WithEvents txtlino As TextBox
    Friend WithEvents txtalgodon As TextBox
    Friend WithEvents txtseda As TextBox
    Friend WithEvents txthilo As TextBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrecioC As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
