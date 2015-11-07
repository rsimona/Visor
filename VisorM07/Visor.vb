Imports Visor

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

            ImagenSiguienteToolStripMenuItem.Enabled = True
            ImagenAnteriorToolStripMenuItem.Enabled = True
            RotarImagenToolStripMenuItem.Enabled = True
            RotarIzquiedaToolStripMenuItem.Enabled = True
            ZoomAlejarToolStripMenuItem.Enabled = True
            ZoomToolStripMenuItem.Enabled = True
            EscalaRealToolStripMenuItem.Enabled = True
            AjustarTamañoAVistaToolStripMenuItem.Enabled = True

            tsAnterior.Enabled = True
            tsSiguiente.Enabled = True
            tsRotarDerecha.Enabled = True
            tsRotarIzquierda.Enabled = True
            tsZoomAlejar.Enabled = True
            tsZoomAcercar.Enabled = True
            tsEscalaReal.Enabled = True
            tsExtender.Enabled = True

            ImagenSiguienteContextual.Enabled = True
            ImagenAnteriorContextual.Enabled = True
            RotarDerechaContextual.Enabled = True
            RotarIzquierdaContextual.Enabled = True
            ZoomAlejarContextual.Enabled = True
            ZoomAcercarContextual.Enabled = True
            EscalaRealContextual.Enabled = True
            AjustarTamañoAVistaContextual.Enabled = True
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

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles tsSiguiente.Click
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

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RotarIzquiedaToolStripMenuItem.Click
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
        If drag And v.Num_Fotos > 0 Then
            pboxFoto.Image = v.Despl(e.Location.X + pboxFoto.Location.X - offset.X, e.Location.Y + pboxFoto.Location.Y - offset.Y)
        End If
    End Sub

    Private Sub pboxFoto_MouseUp(sender As Object, e As MouseEventArgs) Handles pboxFoto.MouseUp
        drag = False
        pboxFoto.Cursor = Cursors.Default
    End Sub

    Private Sub tsEscalaReal_Click(sender As Object, e As EventArgs) Handles tsEscalaReal.Click
        EscalaReal()
    End Sub

    Private Sub EscalaRealToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscalaRealToolStripMenuItem.Click
        EscalaReal()
    End Sub

    Private Sub tsExtender_Click(sender As Object, e As EventArgs) Handles tsExtender.Click
        AjustarTamanyoAVista()
    End Sub

    Private Sub AjustarTamañoAVistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustarTamañoAVistaToolStripMenuItem.Click
        AjustarTamanyoAVista()
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
        If v.Num_Fotos = 0 Then
            ImagenSiguienteToolStripMenuItem.Enabled = False
            ImagenAnteriorToolStripMenuItem.Enabled = False
            RotarImagenToolStripMenuItem.Enabled = False
            RotarIzquiedaToolStripMenuItem.Enabled = False
            ZoomAlejarToolStripMenuItem.Enabled = False
            ZoomToolStripMenuItem.Enabled = False
            EscalaRealToolStripMenuItem.Enabled = False
            AjustarTamañoAVistaToolStripMenuItem.Enabled = False

            tsAnterior.Enabled = False
            tsSiguiente.Enabled = False
            tsRotarDerecha.Enabled = False
            tsRotarIzquierda.Enabled = False
            tsZoomAlejar.Enabled = False
            tsZoomAcercar.Enabled = False
            tsEscalaReal.Enabled = False
            tsExtender.Enabled = False

            ImagenSiguienteContextual.Enabled = False
            ImagenAnteriorContextual.Enabled = False
            RotarDerechaContextual.Enabled = False
            RotarIzquierdaContextual.Enabled = False
            ZoomAlejarContextual.Enabled = False
            ZoomAcercarContextual.Enabled = False
            EscalaRealContextual.Enabled = False
            AjustarTamañoAVistaContextual.Enabled = False
        End If
    End Sub

    Private Sub AñadirImagenContextual_Click(sender As Object, e As EventArgs) Handles AñadirImagenContextual.Click
        abrirFotos()
    End Sub

    Private Sub ImagenSiguienteContextual_Click(sender As Object, e As EventArgs) Handles ImagenSiguienteContextual.Click
        fotoSiguiente()
    End Sub

    Private Sub ImagenAnteriorContextual_Click(sender As Object, e As EventArgs) Handles ImagenAnteriorContextual.Click
        fotoAnterior()
    End Sub

    Private Sub RotarDerechaContextual_Click(sender As Object, e As EventArgs) Handles RotarDerechaContextual.Click
        rotarDerecha()
    End Sub

    Private Sub RotarIzquierdaContextual_Click(sender As Object, e As EventArgs) Handles RotarIzquierdaContextual.Click
        rotarIzquierda()
    End Sub

    Private Sub ZoomAlejarContextual_Click(sender As Object, e As EventArgs) Handles ZoomAlejarContextual.Click
        zoomAlejar()
    End Sub

    Private Sub ZoomAcercarContextual_Click(sender As Object, e As EventArgs) Handles ZoomAcercarContextual.Click
        zoomAcercar()
    End Sub

    Private Sub EscalaRealContextual_Click(sender As Object, e As EventArgs) Handles EscalaRealContextual.Click
        EscalaReal()
    End Sub

    Private Sub AjustarTamañoAVistaContextual_Click(sender As Object, e As EventArgs) Handles AjustarTamañoAVistaContextual.Click
        AjustarTamanyoAVista()
    End Sub

    Private Sub EscalaReal()
        pboxFoto.Image = v.Zoom(0)
    End Sub

    Private Sub AjustarTamanyoAVista()
        pboxFoto.Image = v.Foto_Actual()
        pboxFoto.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class
