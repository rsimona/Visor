Imports Visor

Public Class Visor
    Dim v As VisorFoto = New VisorFoto(575, 330)

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        abrirFotos()
    End Sub

    Private Sub tsAbrir_Click(sender As Object, e As EventArgs) Handles tsAnyadir.Click
        abrirFotos()
    End Sub

    Private Sub abrirFotos()

        OpenFileDialog1.Title = "Seleccionar imágenes a importar al visor"
        OpenFileDialog1.Filter = "Imagen|*.jpg;*.gif;*.png"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            For Each foto In OpenFileDialog1.FileNames
                v.Agregar_Foto(Bitmap.FromFile(foto))
            Next
        End If
        v.Num_Actual = v.Num_Fotos - 1
        pboxFoto.Image = v.Get_Foto(v.Num_Actual)
        pbMiniaturaActual.Image = v.Get_Foto(v.Num_Actual)
        pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub fotoAnterior()
        v.Prev_Foto()
        pboxFoto.Image = v.Get_Foto(v.Num_Actual)
        pbMiniaturaActual.Image = v.Get_Foto(v.Num_Actual)

        If v.Num_Actual - 1 >= 0 Then
            pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)
        Else
            pbMiniaturaAnterior.Image = Nothing
        End If

        If v.Num_Actual + 1 < v.Num_Fotos Then
            pbMiniaturaSiguiente.Image = v.Get_Foto(v.Num_Actual + 1)
        Else
            pbMiniaturaSiguiente.Image = Nothing
        End If
    End Sub

    Private Sub tsAnterior_Click(sender As Object, e As EventArgs) Handles tsAnterior.Click
        fotoAnterior()
    End Sub

    Private Sub ImagenAnteriorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenAnteriorToolStripMenuItem.Click
        fotoAnterior()
    End Sub

    Private Sub fotoSiguiente()
        v.Next_Foto()
        pboxFoto.Image = v.Get_Foto(v.Num_Actual)
        pbMiniaturaActual.Image = v.Get_Foto(v.Num_Actual)

        If v.Num_Actual - 1 >= 0 Then
            pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)
        Else
            pbMiniaturaAnterior.Image = Nothing
        End If

        If v.Num_Actual + 1 < v.Num_Fotos Then
            pbMiniaturaSiguiente.Image = v.Get_Foto(v.Num_Actual + 1)
        Else
            pbMiniaturaSiguiente.Image = Nothing
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        fotoSiguiente()
    End Sub

    Private Sub ImagenSiguienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenSiguienteToolStripMenuItem.Click
        fotoSiguiente()
    End Sub
End Class
