﻿Imports Visor

Public Class Visor
    Dim v As VisorFoto = New VisorFoto(575, 330)
    Dim drag As Boolean = False
    Dim offset As Point

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        abrirFotos()
    End Sub

    Private Sub tsAbrir_Click(sender As Object, e As EventArgs) Handles tsAnyadir.Click
        abrirFotos()
    End Sub

    Private Sub btnAnyadirImagen_Click(sender As Object, e As EventArgs) Handles btnAnyadirImagen.Click
        abrirFotos()
    End Sub

    Private Sub abrirFotos()

        OpenFileDialog1.Title = "Seleccionar imágenes a importar al visor"
        OpenFileDialog1.Filter = "Imagen|*.jpg;*.gif;*.png"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            btnAnyadirImagen.Visible = False
            For Each foto In OpenFileDialog1.FileNames
                v.Agregar_Foto(Bitmap.FromFile(foto))
            Next

            v.Num_Actual = v.Num_Fotos - 1
            pboxFoto.Image = v.Get_Foto(v.Num_Actual)
            pbMiniaturaActual.Image = v.Get_Foto(v.Num_Actual)
            pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)

            pbFlechaAnterior.Image = VisorM07.My.Resources.flecha_anterior
        End If
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

    Private Sub pbFlechaAnterior_Click(sender As Object, e As EventArgs) Handles pbFlechaAnterior.Click
        fotoAnterior()
    End Sub

    Private Sub fotoAnterior()
        If Not pbMiniaturaAnterior.Image Is Nothing Then
            v.Prev_Foto()
            pboxFoto.Image = v.Get_Foto(v.Num_Actual)
            pbMiniaturaActual.Image = v.Get_Foto(v.Num_Actual)

            If v.Num_Actual - 1 >= 0 Then
                pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)
                pbFlechaAnterior.Image = VisorM07.My.Resources.flecha_anterior
            Else
                pbFlechaAnterior.Image = VisorM07.My.Resources.flecha_anterior_gris
                pbMiniaturaAnterior.Image = Nothing
            End If

            If v.Num_Actual + 1 < v.Num_Fotos Then
                pbMiniaturaSiguiente.Image = v.Get_Foto(v.Num_Actual + 1)
                pbFlechaSiguiente.Image = VisorM07.My.Resources.flecha_seguent
            Else
                pbFlechaSiguiente.Image = VisorM07.My.Resources.flecha_seguent_gris
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

    Private Sub pbFlechaSiguiente_Click(sender As Object, e As EventArgs) Handles pbFlechaSiguiente.Click
        fotoSiguiente()
    End Sub

    Private Sub fotoSiguiente()
        If Not pbMiniaturaSiguiente.Image Is Nothing Then
            v.Next_Foto()
            pboxFoto.Image = v.Get_Foto(v.Num_Actual)
            pbMiniaturaActual.Image = v.Get_Foto(v.Num_Actual)

            If v.Num_Actual - 1 >= 0 Then
                pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)
                pbFlechaAnterior.Image = VisorM07.My.Resources.flecha_anterior
            Else
                pbFlechaAnterior.Image = VisorM07.My.Resources.flecha_anterior_gris
                pbMiniaturaAnterior.Image = Nothing
            End If

            If v.Num_Actual + 1 < v.Num_Fotos Then
                pbMiniaturaSiguiente.Image = v.Get_Foto(v.Num_Actual + 1)
                pbFlechaSiguiente.Image = VisorM07.My.Resources.flecha_seguent
            Else
                pbFlechaSiguiente.Image = VisorM07.My.Resources.flecha_seguent_gris
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

    Private Sub tsZoomAcercar_Click(sender As Object, e As EventArgs) Handles tsZoomAcercar.Click
        zoomAcercar()
    End Sub

    Private Sub ZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem.Click
        zoomAcercar()
    End Sub

    Private Sub zoomAcercar()
        pboxFoto.Image = v.Zoom(1.25)
    End Sub

    Private Sub tsZoomAlejar_Click(sender As Object, e As EventArgs) Handles tsZoomAlejar.Click
        zoomAlejar()
    End Sub

    Private Sub ZoomAlejarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomAlejarToolStripMenuItem.Click
        zoomAlejar()
    End Sub

    Private Sub zoomAlejar()
        pboxFoto.Image = v.Zoom(0.75)
    End Sub

    Private Sub pboxFoto_MouseDown(sender As Object, e As MouseEventArgs) Handles pboxFoto.MouseDown
        drag = True
        offset = e.Location
        pboxFoto.Cursor = Cursors.NoMove2D
    End Sub

    Private Sub pboxFoto_MouseMove(sender As Object, e As MouseEventArgs) Handles pboxFoto.MouseMove
        If drag Then
            pboxFoto.Image = v.Despl(e.Location.X + pboxFoto.Location.X - offset.X, e.Location.Y + pboxFoto.Location.Y - offset.Y)
        End If
    End Sub

    Private Sub pboxFoto_MouseUp(sender As Object, e As MouseEventArgs) Handles pboxFoto.MouseUp
        drag = False
        pboxFoto.Cursor = Cursors.Default
    End Sub

    Private Sub tsEscalaReal_Click(sender As Object, e As EventArgs) Handles tsEscalaReal.Click
        pboxFoto.Image = v.Zoom(0)
    End Sub

    Private Sub EscalaRealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscalaRealToolStripMenuItem.Click
        pboxFoto.Image = v.Zoom(0)
    End Sub

    Private Sub tsExtender_Click(sender As Object, e As EventArgs) Handles tsExtender.Click
        pboxFoto.Image = v.Foto_Actual()
    End Sub

    Private Sub AjustarTamañoAVistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustarTamañoAVistaToolStripMenuItem.Click
        pboxFoto.Image = v.Foto_Actual()
    End Sub

    Private Sub btnAnyadirImagen_MouseEnter(sender As Object, e As EventArgs) Handles btnAnyadirImagen.MouseEnter
        btnAnyadirImagen.FlatAppearance.BorderSize = 1
        btnAnyadirImagen.FlatAppearance.BorderColor = Color.DodgerBlue
    End Sub

    Private Sub btnAnyadirImagen_MouseLeave(sender As Object, e As EventArgs) Handles btnAnyadirImagen.MouseLeave
        btnAnyadirImagen.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub pbFlechaSiguiente_MouseEnter(sender As Object, e As EventArgs) Handles pbFlechaSiguiente.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub pbFlechaAnterior_MouseEnter(sender As Object, e As EventArgs) Handles pbFlechaAnterior.MouseEnter
        Cursor = Cursors.Hand
    End Sub

    Private Sub pbFlechaSiguiente_MouseLeave(sender As Object, e As EventArgs) Handles pbFlechaSiguiente.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub pbFlechaAnterior_MouseLeave(sender As Object, e As EventArgs) Handles pbFlechaAnterior.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Visor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
