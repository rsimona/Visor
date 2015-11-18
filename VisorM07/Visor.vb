Imports System.ComponentModel
Imports Visor

Public Class Visor
    Dim v As VisorFoto = New VisorFoto(575, 350)
    Dim drag As Boolean = False
    Dim offset As Point
    Public listaFotos As New ArrayList

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
        OpenFileDialog1.Filter = "Imagen|*.jpg;*.gif;*.png|Todos los archivos|*.*"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                btnAnyadirImagen.Visible = False
                Dim i As Integer
                For i = 0 To OpenFileDialog1.FileNames.Count - 1
                    Dim file As String = OpenFileDialog1.FileNames(i)
                    listaFotos.Add(file)
                Next

                For Each foto In OpenFileDialog1.FileNames
                    v.Agregar_Foto(Bitmap.FromFile(foto))
                Next

                v.Num_Actual = 0
                pboxFoto.Image = v.Foto_Actual
                pbMiniaturaActual.Image = v.Foto_Actual
                lblNumFoto.Text = v.Num_Actual + 1 & " / " & v.Num_Fotos

                If v.Num_Fotos = 1 Then
                    pbFlechaAnterior.Enabled = False
                    pbFlechaSiguiente.Enabled = False
                End If
                gestionarMiniaturaAnteriorSiguiente()

                If v.Num_Fotos > 1 Then
                    pbFlechaAnterior.Image = VisorM07.My.Resources.flecha_anterior
                    pbFlechaSiguiente.Image = VisorM07.My.Resources.flecha_seguent
                    pbFlechaAnterior.Enabled = True
                    pbFlechaSiguiente.Enabled = True
                End If

                ImagenSiguienteToolStripMenuItem.Enabled = True
                ImagenAnteriorToolStripMenuItem.Enabled = True
                RotarImagenToolStripMenuItem.Enabled = True
                RotarIzquiedaToolStripMenuItem.Enabled = True
                ZoomAlejarToolStripMenuItem.Enabled = True
                ZoomToolStripMenuItem.Enabled = True
                AjustarTamañoAVistaToolStripMenuItem.Enabled = True
                EliminarTodasLasImágenesDelVisorToolStripMenuItem.Enabled = True
                ReproducirPaseDeDiapositivasToolStripMenuItem.Enabled = True

                tsAnterior.Enabled = True
                tsSiguiente.Enabled = True
                tsRotarDerecha.Enabled = True
                tsRotarIzquierda.Enabled = True
                tsZoomAlejar.Enabled = True
                tsZoomAcercar.Enabled = True
                tsExtender.Enabled = True
                tsReset.Enabled = True
                tsPlay.Enabled = True

                ImagenSiguienteContextual.Enabled = True
                ImagenAnteriorContextual.Enabled = True
                RotarDerechaContextual.Enabled = True
                RotarIzquierdaContextual.Enabled = True
                ZoomAlejarContextual.Enabled = True
                ZoomAcercarContextual.Enabled = True
                AjustarTamañoAVistaContextual.Enabled = True
                EliminarTodasLasImágenesDelVisorContextual.Enabled = True
                ReprodcirPaseDeDiapositivasContextual.Enabled = True

            Catch ex As Exception
                ' MsgBox(ex.Message)
                resetearVisor()
                btnAnyadirImagen.Visible = True
                MsgBox("Error al cargar las imágenes." & vbCrLf & "Es posible que esté intentando cargar un fichero que no es una imagen.", MsgBoxStyle.Critical, "Error de carga")
            End Try

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

        If v.Num_Fotos > 1 Then
            pboxFoto.Image = v.Prev_Foto
            pbMiniaturaActual.Image = v.Foto_Actual
            gestionarMiniaturaAnteriorSiguiente()
            lblNumFoto.Text = v.Num_Actual + 1 & " / " & v.Num_Fotos
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
        If v.Num_Fotos > 1 Then
            pboxFoto.Image = v.Next_Foto
            pbMiniaturaActual.Image = v.Foto_Actual
            gestionarMiniaturaAnteriorSiguiente()
            lblNumFoto.Text = v.Num_Actual + 1 & " / " & v.Num_Fotos
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

    Private Sub tsEscalaReal_Click(sender As Object, e As EventArgs)
        EscalaReal()
    End Sub

    Private Sub EscalaRealToolStripMenuItem_Click(sender As Object, e As EventArgs)
        EscalaReal()
    End Sub

    Private Sub tsExtender_Click(sender As Object, e As EventArgs) Handles tsExtender.Click
        AjustarTamanyoAVista()
    End Sub

    Private Sub AjustarTamañoAVistaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustarTamañoAVistaToolStripMenuItem.Click
        AjustarTamanyoAVista()
    End Sub

    Private Sub EliminarTodasLasImágenesDelVisorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarTodasLasImágenesDelVisorToolStripMenuItem.Click
        resetearVisor()
    End Sub

    Private Sub tsReset_Click(sender As Object, e As EventArgs) Handles tsReset.Click
        resetearVisor()
    End Sub

    Private Sub EliminarTodasLasImágenesDelVisorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarTodasLasImágenesDelVisorContextual.Click
        resetearVisor()
    End Sub

    Private Sub tsPlay_Click(sender As Object, e As EventArgs) Handles tsPlay.Click
        mostrarReproductor()
    End Sub

    Private Sub ReproducirPaseDeDiapositivasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReproducirPaseDeDiapositivasToolStripMenuItem.Click
        mostrarReproductor()
    End Sub

    Private Sub ReprodcirPaseDeDiapositivasContextual_Click(sender As Object, e As EventArgs) Handles ReprodcirPaseDeDiapositivasContextual.Click
        mostrarReproductor()
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
            AjustarTamañoAVistaToolStripMenuItem.Enabled = False
            EliminarTodasLasImágenesDelVisorToolStripMenuItem.Enabled = False
            ReproducirPaseDeDiapositivasToolStripMenuItem.Enabled = False

            tsAnterior.Enabled = False
            tsSiguiente.Enabled = False
            tsRotarDerecha.Enabled = False
            tsRotarIzquierda.Enabled = False
            tsZoomAlejar.Enabled = False
            tsZoomAcercar.Enabled = False
            tsExtender.Enabled = False
            tsReset.Enabled = False
            tsPlay.Enabled = False

            ImagenSiguienteContextual.Enabled = False
            ImagenAnteriorContextual.Enabled = False
            RotarDerechaContextual.Enabled = False
            RotarIzquierdaContextual.Enabled = False
            ZoomAlejarContextual.Enabled = False
            ZoomAcercarContextual.Enabled = False
            AjustarTamañoAVistaContextual.Enabled = False
            EliminarTodasLasImágenesDelVisorContextual.Enabled = False
            ReprodcirPaseDeDiapositivasContextual.Enabled = False
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

    Private Sub EscalaRealContextual_Click(sender As Object, e As EventArgs)
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
    End Sub

    Private Sub Visor_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Está seguro que quiere salir del Visor de Imágenes?", "Visor de imágenes", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub gestionarMiniaturaAnteriorSiguiente()
        If v.Num_Fotos = 1 Then
            pbMiniaturaAnterior.Image = Nothing
            pbMiniaturaSiguiente.Image = Nothing
        ElseIf v.Num_Fotos = 2 Then
            If v.Num_Actual = 0 Then
                pbMiniaturaAnterior.Image = Nothing
                pbMiniaturaSiguiente.Image = v.Get_Foto(v.Num_Actual + 1)
            Else
                pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)
                pbMiniaturaSiguiente.Image = Nothing
            End If
        Else
            If v.Num_Actual = 0 Then
                pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Fotos - 1)
                pbMiniaturaSiguiente.Image = v.Get_Foto(v.Num_Actual + 1)
            ElseIf v.Num_Actual = v.Num_Fotos - 1 Then
                pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)
                pbMiniaturaSiguiente.Image = v.Get_Foto(0)
            Else
                pbMiniaturaAnterior.Image = v.Get_Foto(v.Num_Actual - 1)
                pbMiniaturaSiguiente.Image = v.Get_Foto(v.Num_Actual + 1)
            End If
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
        Select Case keyData

            Case Keys.Right
                fotoSiguiente()
                Return True

            Case Keys.Left
                fotoAnterior()
                Return True

        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Visor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Subtract Or e.KeyCode = 189 Then
            zoomAlejar()
        ElseIf e.KeyCode = Keys.Add Or e.KeyCode = 187 Then
            zoomAcercar()
        End If

    End Sub

    Private Sub resetearVisor()
        v = New VisorFoto(575, 350)
        btnAnyadirImagen.Visible = True
        pboxFoto.Image = Nothing
        pbMiniaturaActual.Image = Nothing
        pbMiniaturaAnterior.Image = Nothing
        pbMiniaturaSiguiente.Image = Nothing
        lblNumFoto.Text = "0 / 0"
        pbFlechaAnterior.Image = VisorM07.My.Resources.flecha_anterior_gris
        pbFlechaSiguiente.Image = VisorM07.My.Resources.flecha_seguent_gris
        pbFlechaAnterior.Enabled = False
        pbFlechaSiguiente.Enabled = False

        If v.Num_Fotos = 0 Then
            ImagenSiguienteToolStripMenuItem.Enabled = False
            ImagenAnteriorToolStripMenuItem.Enabled = False
            RotarImagenToolStripMenuItem.Enabled = False
            RotarIzquiedaToolStripMenuItem.Enabled = False
            ZoomAlejarToolStripMenuItem.Enabled = False
            ZoomToolStripMenuItem.Enabled = False
            AjustarTamañoAVistaToolStripMenuItem.Enabled = False
            EliminarTodasLasImágenesDelVisorToolStripMenuItem.Enabled = False
            ReproducirPaseDeDiapositivasToolStripMenuItem.Enabled = False

            tsAnterior.Enabled = False
            tsSiguiente.Enabled = False
            tsRotarDerecha.Enabled = False
            tsRotarIzquierda.Enabled = False
            tsZoomAlejar.Enabled = False
            tsZoomAcercar.Enabled = False
            tsExtender.Enabled = False
            tsReset.Enabled = False
            tsPlay.Enabled = False

            ImagenSiguienteContextual.Enabled = False
            ImagenAnteriorContextual.Enabled = False
            RotarDerechaContextual.Enabled = False
            RotarIzquierdaContextual.Enabled = False
            ZoomAlejarContextual.Enabled = False
            ZoomAcercarContextual.Enabled = False
            AjustarTamañoAVistaContextual.Enabled = False
            EliminarTodasLasImágenesDelVisorContextual.Enabled = False
            ReprodcirPaseDeDiapositivasContextual.Enabled = False
        End If
    End Sub

    Private Sub mostrarReproductor()

        Dim play As New Pantalla_completa
        play.Location = New Point(0, 0)
        play.Show()

        Dim i As Integer

        For i = 0 To listaFotos.Count - 1
            play.BackgroundImage = Bitmap.FromFile(listaFotos(i))
            play.Refresh()
            Threading.Thread.Sleep(3000)
            Application.DoEvents()
        Next

        play.Close()
    End Sub

    Private Sub Visor_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop, False) = True Then
            btnAnyadirImagen.Visible = False
            lblSoltar.Visible = True
            Me.BackColor = Color.Yellow
            e.Effect = DragDropEffects.All
        End If
    End Sub


    Private Sub Visor_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim elementosArrastrados As String() = e.Data.GetData(DataFormats.FileDrop)

        Try
            lblSoltar.Visible = False
            For Each foto In elementosArrastrados
                Dim fichero = obtenerNombreFichero(foto)
                v.Agregar_Foto(Bitmap.FromFile(fichero))
                listaFotos.Add(fichero)
            Next

            v.Num_Actual = 0
            pboxFoto.Image = v.Foto_Actual
            pbMiniaturaActual.Image = v.Foto_Actual
            lblNumFoto.Text = v.Num_Actual + 1 & " / " & v.Num_Fotos

            If v.Num_Fotos = 1 Then
                pbFlechaAnterior.Enabled = False
                pbFlechaSiguiente.Enabled = False
            End If
            gestionarMiniaturaAnteriorSiguiente()

            If v.Num_Fotos > 1 Then
                pbFlechaAnterior.Image = VisorM07.My.Resources.flecha_anterior
                pbFlechaSiguiente.Image = VisorM07.My.Resources.flecha_seguent
                pbFlechaAnterior.Enabled = True
                pbFlechaSiguiente.Enabled = True
            End If

            ImagenSiguienteToolStripMenuItem.Enabled = True
            ImagenAnteriorToolStripMenuItem.Enabled = True
            RotarImagenToolStripMenuItem.Enabled = True
            RotarIzquiedaToolStripMenuItem.Enabled = True
            ZoomAlejarToolStripMenuItem.Enabled = True
            ZoomToolStripMenuItem.Enabled = True
            AjustarTamañoAVistaToolStripMenuItem.Enabled = True
            EliminarTodasLasImágenesDelVisorToolStripMenuItem.Enabled = True
            ReproducirPaseDeDiapositivasToolStripMenuItem.Enabled = True

            tsAnterior.Enabled = True
            tsSiguiente.Enabled = True
            tsRotarDerecha.Enabled = True
            tsRotarIzquierda.Enabled = True
            tsZoomAlejar.Enabled = True
            tsZoomAcercar.Enabled = True
            tsExtender.Enabled = True
            tsReset.Enabled = True
            tsPlay.Enabled = True

            ImagenSiguienteContextual.Enabled = True
            ImagenAnteriorContextual.Enabled = True
            RotarDerechaContextual.Enabled = True
            RotarIzquierdaContextual.Enabled = True
            ZoomAlejarContextual.Enabled = True
            ZoomAcercarContextual.Enabled = True
            AjustarTamañoAVistaContextual.Enabled = True
            EliminarTodasLasImágenesDelVisorContextual.Enabled = True
            ReprodcirPaseDeDiapositivasContextual.Enabled = True

            Me.BackColor = Color.White

        Catch ex As Exception
            ' MsgBox(ex.Message)
            resetearVisor()
            btnAnyadirImagen.Visible = True
            MsgBox("Error al cargar las imágenes." & vbCrLf & "Es posible que esté intentando cargar un fichero que no es una imagen.", MsgBoxStyle.Critical, "Error de carga")
        End Try

    End Sub

    Public Function obtenerNombreFichero(path As String)
        Return System.IO.Path.GetFullPath(path)
    End Function

    Private Sub Visor_DragLeave(sender As Object, e As EventArgs) Handles MyBase.DragLeave
        If v.Num_Fotos = 0 Then
            btnAnyadirImagen.Visible = True
        Else
            btnAnyadirImagen.Visible = False
        End If
        lblSoltar.Visible = False
        Me.BackColor = Color.White
    End Sub

    Private Sub InstruccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstruccionesToolStripMenuItem.Click
        Ayuda.Show()
    End Sub
End Class
