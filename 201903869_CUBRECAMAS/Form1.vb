Public Class Form1

    Private Sub HiloCrudo_CheckedChanged(sender As Object, e As EventArgs) Handles HiloCrudo.CheckedChanged
        If HiloCrudo.Checked = True Then
            txthilo.Enabled = True
            txthilo.Text = "0"
        Else
            txthilo.Enabled = False
            txthilo.Text = "0"
        End If
    End Sub

    Private Sub Algodón_CheckedChanged(sender As Object, e As EventArgs) Handles Algodón.CheckedChanged
        If Algodón.Checked = True Then
            txtalgodon.Enabled = True
            txtalgodon.Text = "0"
        Else
            txtalgodon.Enabled = False
            txtalgodon.Text = "0"
        End If
    End Sub

    Private Sub Seda_CheckedChanged(sender As Object, e As EventArgs) Handles Seda.CheckedChanged
        If Seda.Checked = True Then
            txtseda.Enabled = True
            txtseda.Text = "0"
        Else
            txtseda.Enabled = False
            txtseda.Text = "0"
        End If
    End Sub


    Private Sub Lino_CheckedChanged(sender As Object, e As EventArgs) Handles Lino.CheckedChanged
        If Lino.Checked = True Then
            txtlino.Enabled = True
            txtlino.Text = "0"
        Else
            txtlino.Enabled = False
            txtlino.Text = "0"
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click
        lblPrecioC.Text = "0.00"
        precioCosto = 0.00
        sumaYardas = Val(txtalgodon.Text) + Val(txtlino.Text) + Val(txthilo.Text) + Val(txtseda.Text)
        If King.Checked = True Then
            If sumaYardas = matking Then
                precioCosto = precioking + Val(txtalgodon.Text) * precioalgodon + Val(txtlino.Text) * preciolino + Val(txthilo.Text) * preciohilo + Val(txtseda.Text) * precioseda
                'falta poner else de que faltan o sobran materiales 
            End If

        ElseIf Queen.Checked = True Then
            If sumaYardas = matqueen Then
                precioCosto = precioking + Val(txtalgodon.Text) * precioalgodon + Val(txtlino.Text) * preciolino + Val(txthilo.Text) * preciohilo + Val(txtseda.Text) * precioseda
                'falta poner else de que faltan o sobran materiales 
            End If
        ElseIf Matrimonial.Checked = True Then
            If sumaYardas = matmatr Then
                precioCosto = precioking + Val(txtalgodon.Text) * precioalgodon + Val(txtlino.Text) * preciolino + Val(txthilo.Text) * preciohilo + Val(txtseda.Text) * precioseda
                'falta poner else de que faltan o sobran materiales 
            End If
        ElseIf Imperial.Checked = True Then
            If sumaYardas = matimp Then
                precioCosto = precioking + Val(txtalgodon.Text) * precioalgodon + Val(txtlino.Text) * preciolino + Val(txthilo.Text) * preciohilo + Val(txtseda.Text) * precioseda
                'falta poner else de que faltan o sobran materiales 
            End If
        End If
        lblPrecioC.Text = Str(precioCosto)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Desea salir de la aplicacion", "Salir de la App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtalgodon.Text = " "
        txthilo.Text = " "
        txtlino.Text = " "
        txtseda.Text = " "
    End Sub
End Class
