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

    Private Sub tsAnterior_Click(sender As Object, e As EventArgs) Handles tsAnterior.Click
        fotoAnterior()
    End Sub

    Private Sub ImagenAnteriorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenAnteriorToolStripMenuItem.Click
        fotoAnterior()
    End Sub

    Private Sub fotoAnterior()
        If Not pbMiniaturaAnterior.Image Is Nothing Then
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
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        fotoSiguiente()
    End Sub

    Private Sub ImagenSiguienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagenSiguienteToolStripMenuItem.Click
        fotoSiguiente()
    End Sub

    Private Sub fotoSiguiente()
        If Not pbMiniaturaSiguiente.Image Is Nothing Then
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
        End If
    End Sub

    Private Sub pbMiniaturaAnterior_Click(sender As Object, e As EventArgs) Handles pbMiniaturaAnterior.Click
        If Not pbMiniaturaAnterior.Image Is Nothing Then
            fotoAnterior()
        End If
    End Sub

    Private Sub pbMiniaturaSiguiente_Click(sender As Object, e As EventArgs) Handles pbMiniaturaSiguiente.Click
        If Not pbMiniaturaSiguiente.Image Is Nothing Then
            fotoSiguiente()
        End If
    End Sub

    Private Sub manejarMiniatura(pb As PictureBox)
        If Not pb.Image Is Nothing Then
            pb.Enabled = True
            pb.Cursor = Cursors.Hand
        Else
            'pb.Enabled = False
            pb.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub pbMiniaturaAnterior_MouseEnter(sender As Object, e As EventArgs) Handles pbMiniaturaAnterior.MouseEnter
        manejarMiniatura(sender)
    End Sub

    Private Sub pbMiniaturaSiguiente_MouseEnter(sender As Object, e As EventArgs) Handles pbMiniaturaSiguiente.MouseEnter
        manejarMiniatura(sender)
    End Sub

    Private Sub RotarImagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RotarImagenToolStripMenuItem.Click
        rotarDerecha()
    End Sub

    Private Sub tsRotarDerecha_Click(sender As Object, e As EventArgs) Handles tsRotarDerecha.Click
        rotarDerecha()
    End Sub

    Private Sub rotarDerecha()
        v.rotar_hor()
        pboxFoto.Image = v.Foto_Actual
        pbMiniaturaActual.Image = v.Foto_Actual
    End Sub

    Private Sub tsRotarIzquierda_Click(sender As Object, e As EventArgs) Handles tsRotarIzquierda.Click
        rotarIzquierda()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        rotarIzquierda()
    End Sub

    Public Sub rotarIzquierda()
        v.rotar_antihor()
        pboxFoto.Image = v.Foto_Actual
        pbMiniaturaActual.Image = v.Foto_Actual
    End Sub
End Class
