Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'Hacer la verificación de los datos
        If (TextBox1.Text = "") Then

            MsgBox("Ingrese el número de entradas que comprará por favor", vbQuestion)

            Exit Sub

            TextBox1.Focus()

        End If

        If (ComboBox1.Text = "") Then

            MsgBox("Seleccione la función que desea por favor", vbQuestion)


            Exit Sub

            TextBox1.Focus()

        End If

        If (ComboBox2.Text = "") Then

            MsgBox("Seleccione el cine por favor", vbQuestion)

            Exit Sub

            TextBox1.Focus()

        End If




        'Envío de la funcion y cine 

        If indice < 9 Then
            vfuncion(indice) = ComboBox2.SelectedItem
            vcine(indice) = ComboBox1.SelectedItem
            subtotal_a_pagar(indice) = calcularSubtotal(vfuncion(indice), vcine(indice))
            vdescuento1(indice) = subtotal_a_pagar(indice) * calculoDescuento1(vfuncion(indice), vcine(indice))
            'calcular el descuento 2 y el total a pagar





            Funcion.Items.Add(vfuncion(indice))
            Cine.Items.Add(vcine(indice))
            SubTotal.Items.Add(subtotal_a_pagar(indice))
            Descuento1.Items.Add(vdescuento1(indice))

        ElseIf indice >= 9 Then

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Limpiar_entradas()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Limpiar_Listas()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("Está seguro que desea salir de la aplicación?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub
End Class
