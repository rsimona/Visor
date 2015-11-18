<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Visor))
        Me.msArchivo = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenSiguienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenAnteriorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotarImagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotarIzquiedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomAlejarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustarTamañoAVistaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarTodasLasImágenesDelVisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsAnyadir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAnterior = New System.Windows.Forms.ToolStripButton()
        Me.tsSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.tsRotarIzquierda = New System.Windows.Forms.ToolStripButton()
        Me.tsRotarDerecha = New System.Windows.Forms.ToolStripButton()
        Me.tsZoomAlejar = New System.Windows.Forms.ToolStripButton()
        Me.tsZoomAcercar = New System.Windows.Forms.ToolStripButton()
        Me.tsExtender = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsPlay = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsReset = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pbFlechaSiguiente = New System.Windows.Forms.PictureBox()
        Me.pbFlechaAnterior = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AñadirImagenContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenSiguienteContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagenAnteriorContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotarDerechaContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.RotarIzquierdaContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomAlejarContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomAcercarContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustarTamañoAVistaContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarTodasLasImágenesDelVisorContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNumFoto = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbMiniaturaAnterior = New System.Windows.Forms.PictureBox()
        Me.pbMiniaturaActual = New System.Windows.Forms.PictureBox()
        Me.pbMiniaturaSiguiente = New System.Windows.Forms.PictureBox()
        Me.btnAnyadirImagen = New System.Windows.Forms.Button()
        Me.pboxFoto = New System.Windows.Forms.PictureBox()
        Me.ReproducirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReproducirPaseDeDiapositivasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReprodcirPaseDeDiapositivasContextual = New System.Windows.Forms.ToolStripMenuItem()
        Me.msArchivo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pbFlechaSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFlechaAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbMiniaturaAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMiniaturaActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMiniaturaSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pboxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msArchivo
        '
        Me.msArchivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VistaToolStripMenuItem, Me.ReproducirToolStripMenuItem})
        Me.msArchivo.Location = New System.Drawing.Point(0, 0)
        Me.msArchivo.Name = "msArchivo"
        Me.msArchivo.Size = New System.Drawing.Size(822, 24)
        Me.msArchivo.TabIndex = 0
        Me.msArchivo.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.AbrirToolStripMenuItem.Text = "A&ñadir foto(s)"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'VistaToolStripMenuItem
        '
        Me.VistaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImagenSiguienteToolStripMenuItem, Me.ImagenAnteriorToolStripMenuItem, Me.RotarImagenToolStripMenuItem, Me.RotarIzquiedaToolStripMenuItem, Me.ZoomToolStripMenuItem, Me.ZoomAlejarToolStripMenuItem, Me.AjustarTamañoAVistaToolStripMenuItem, Me.EliminarTodasLasImágenesDelVisorToolStripMenuItem})
        Me.VistaToolStripMenuItem.Name = "VistaToolStripMenuItem"
        Me.VistaToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.VistaToolStripMenuItem.Text = "&Vista"
        '
        'ImagenSiguienteToolStripMenuItem
        '
        Me.ImagenSiguienteToolStripMenuItem.Image = CType(resources.GetObject("ImagenSiguienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImagenSiguienteToolStripMenuItem.Name = "ImagenSiguienteToolStripMenuItem"
        Me.ImagenSiguienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ImagenSiguienteToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ImagenSiguienteToolStripMenuItem.Text = "Imagen &Siguiente"
        '
        'ImagenAnteriorToolStripMenuItem
        '
        Me.ImagenAnteriorToolStripMenuItem.Image = CType(resources.GetObject("ImagenAnteriorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImagenAnteriorToolStripMenuItem.Name = "ImagenAnteriorToolStripMenuItem"
        Me.ImagenAnteriorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImagenAnteriorToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ImagenAnteriorToolStripMenuItem.Text = "Imagen &Anterior"
        '
        'RotarImagenToolStripMenuItem
        '
        Me.RotarImagenToolStripMenuItem.Image = CType(resources.GetObject("RotarImagenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RotarImagenToolStripMenuItem.Name = "RotarImagenToolStripMenuItem"
        Me.RotarImagenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RotarImagenToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.RotarImagenToolStripMenuItem.Text = "Rotar &derecha"
        '
        'RotarIzquiedaToolStripMenuItem
        '
        Me.RotarIzquiedaToolStripMenuItem.Image = CType(resources.GetObject("RotarIzquiedaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RotarIzquiedaToolStripMenuItem.Name = "RotarIzquiedaToolStripMenuItem"
        Me.RotarIzquiedaToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.RotarIzquiedaToolStripMenuItem.Text = "Rotar &izquierda"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Image = CType(resources.GetObject("ZoomToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ZoomToolStripMenuItem.Text = "&Zoom Acercar"
        '
        'ZoomAlejarToolStripMenuItem
        '
        Me.ZoomAlejarToolStripMenuItem.Image = CType(resources.GetObject("ZoomAlejarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZoomAlejarToolStripMenuItem.Name = "ZoomAlejarToolStripMenuItem"
        Me.ZoomAlejarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ZoomAlejarToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.ZoomAlejarToolStripMenuItem.Text = "Z&oom Alejar"
        '
        'AjustarTamañoAVistaToolStripMenuItem
        '
        Me.AjustarTamañoAVistaToolStripMenuItem.Image = CType(resources.GetObject("AjustarTamañoAVistaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AjustarTamañoAVistaToolStripMenuItem.Name = "AjustarTamañoAVistaToolStripMenuItem"
        Me.AjustarTamañoAVistaToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.AjustarTamañoAVistaToolStripMenuItem.Text = "Ajustar tamaño a Vista"
        '
        'EliminarTodasLasImágenesDelVisorToolStripMenuItem
        '
        Me.EliminarTodasLasImágenesDelVisorToolStripMenuItem.Image = CType(resources.GetObject("EliminarTodasLasImágenesDelVisorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EliminarTodasLasImágenesDelVisorToolStripMenuItem.Name = "EliminarTodasLasImágenesDelVisorToolStripMenuItem"
        Me.EliminarTodasLasImágenesDelVisorToolStripMenuItem.Size = New System.Drawing.Size(267, 22)
        Me.EliminarTodasLasImágenesDelVisorToolStripMenuItem.Text = "Eliminar todas las imágenes del visor"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnyadir, Me.ToolStripSeparator1, Me.tsAnterior, Me.tsSiguiente, Me.tsRotarIzquierda, Me.tsRotarDerecha, Me.tsZoomAlejar, Me.tsZoomAcercar, Me.tsExtender, Me.ToolStripSeparator2, Me.tsPlay, Me.ToolStripSeparator3, Me.tsReset})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 534)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 0, 1, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(822, 37)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsAnyadir
        '
        Me.tsAnyadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsAnyadir.Image = CType(resources.GetObject("tsAnyadir.Image"), System.Drawing.Image)
        Me.tsAnyadir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAnyadir.Name = "tsAnyadir"
        Me.tsAnyadir.Size = New System.Drawing.Size(34, 34)
        Me.tsAnyadir.Text = "ToolStripButton1"
        Me.tsAnyadir.ToolTipText = "Añadir foto(s)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
        '
        'tsAnterior
        '
        Me.tsAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsAnterior.Image = CType(resources.GetObject("tsAnterior.Image"), System.Drawing.Image)
        Me.tsAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsAnterior.Name = "tsAnterior"
        Me.tsAnterior.Size = New System.Drawing.Size(34, 34)
        Me.tsAnterior.Text = "ToolStripButton3"
        Me.tsAnterior.ToolTipText = "Ver foto anterior"
        '
        'tsSiguiente
        '
        Me.tsSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSiguiente.Image = CType(resources.GetObject("tsSiguiente.Image"), System.Drawing.Image)
        Me.tsSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSiguiente.Name = "tsSiguiente"
        Me.tsSiguiente.Size = New System.Drawing.Size(34, 34)
        Me.tsSiguiente.Text = "ToolStripButton4"
        Me.tsSiguiente.ToolTipText = "Ver foto siguiente"
        '
        'tsRotarIzquierda
        '
        Me.tsRotarIzquierda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsRotarIzquierda.Image = CType(resources.GetObject("tsRotarIzquierda.Image"), System.Drawing.Image)
        Me.tsRotarIzquierda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRotarIzquierda.Name = "tsRotarIzquierda"
        Me.tsRotarIzquierda.Size = New System.Drawing.Size(34, 34)
        Me.tsRotarIzquierda.Text = "ToolStripButton5"
        Me.tsRotarIzquierda.ToolTipText = "Rotar 90º a la izquierda"
        '
        'tsRotarDerecha
        '
        Me.tsRotarDerecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsRotarDerecha.Image = CType(resources.GetObject("tsRotarDerecha.Image"), System.Drawing.Image)
        Me.tsRotarDerecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRotarDerecha.Name = "tsRotarDerecha"
        Me.tsRotarDerecha.Size = New System.Drawing.Size(34, 34)
        Me.tsRotarDerecha.Text = "ToolStripButton6"
        Me.tsRotarDerecha.ToolTipText = "Rotar foto 90º a la derecha"
        '
        'tsZoomAlejar
        '
        Me.tsZoomAlejar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsZoomAlejar.Image = CType(resources.GetObject("tsZoomAlejar.Image"), System.Drawing.Image)
        Me.tsZoomAlejar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsZoomAlejar.Name = "tsZoomAlejar"
        Me.tsZoomAlejar.Size = New System.Drawing.Size(34, 34)
        Me.tsZoomAlejar.Text = "ToolStripButton7"
        Me.tsZoomAlejar.ToolTipText = "Zoom Alejar"
        '
        'tsZoomAcercar
        '
        Me.tsZoomAcercar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsZoomAcercar.Image = CType(resources.GetObject("tsZoomAcercar.Image"), System.Drawing.Image)
        Me.tsZoomAcercar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsZoomAcercar.Name = "tsZoomAcercar"
        Me.tsZoomAcercar.Size = New System.Drawing.Size(34, 34)
        Me.tsZoomAcercar.Text = "ToolStripButton8"
        Me.tsZoomAcercar.ToolTipText = "Zoom Acercar"
        '
        'tsExtender
        '
        Me.tsExtender.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsExtender.Image = CType(resources.GetObject("tsExtender.Image"), System.Drawing.Image)
        Me.tsExtender.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsExtender.Name = "tsExtender"
        Me.tsExtender.Size = New System.Drawing.Size(34, 34)
        Me.tsExtender.Text = "ToolStripButton2"
        Me.tsExtender.ToolTipText = "Ajustar tamaño a vista"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
        '
        'tsPlay
        '
        Me.tsPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsPlay.Image = CType(resources.GetObject("tsPlay.Image"), System.Drawing.Image)
        Me.tsPlay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPlay.Name = "tsPlay"
        Me.tsPlay.Size = New System.Drawing.Size(34, 34)
        Me.tsPlay.Text = "ToolStripButton1"
        Me.tsPlay.ToolTipText = "Reproducir pase de diapositivas"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
        '
        'tsReset
        '
        Me.tsReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsReset.Image = CType(resources.GetObject("tsReset.Image"), System.Drawing.Image)
        Me.tsReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReset.Name = "tsReset"
        Me.tsReset.Size = New System.Drawing.Size(34, 34)
        Me.tsReset.Text = "ToolStripButton1"
        Me.tsReset.ToolTipText = "Eliminar todas las imágenes del visor"
        '
        'pbFlechaSiguiente
        '
        Me.pbFlechaSiguiente.Image = Global.VisorM07.My.Resources.Resources.flecha_seguent_gris
        Me.pbFlechaSiguiente.Location = New System.Drawing.Point(702, 407)
        Me.pbFlechaSiguiente.Name = "pbFlechaSiguiente"
        Me.pbFlechaSiguiente.Size = New System.Drawing.Size(57, 88)
        Me.pbFlechaSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFlechaSiguiente.TabIndex = 7
        Me.pbFlechaSiguiente.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbFlechaSiguiente, "Imagen Siguiente")
        '
        'pbFlechaAnterior
        '
        Me.pbFlechaAnterior.Image = Global.VisorM07.My.Resources.Resources.flecha_anterior_gris
        Me.pbFlechaAnterior.Location = New System.Drawing.Point(59, 407)
        Me.pbFlechaAnterior.Name = "pbFlechaAnterior"
        Me.pbFlechaAnterior.Size = New System.Drawing.Size(57, 88)
        Me.pbFlechaAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFlechaAnterior.TabIndex = 6
        Me.pbFlechaAnterior.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pbFlechaAnterior, "Imagen Anterior")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirImagenContextual, Me.ImagenSiguienteContextual, Me.ImagenAnteriorContextual, Me.RotarDerechaContextual, Me.RotarIzquierdaContextual, Me.ZoomAlejarContextual, Me.ZoomAcercarContextual, Me.AjustarTamañoAVistaContextual, Me.EliminarTodasLasImágenesDelVisorContextual, Me.ReprodcirPaseDeDiapositivasContextual})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(268, 224)
        '
        'AñadirImagenContextual
        '
        Me.AñadirImagenContextual.Image = CType(resources.GetObject("AñadirImagenContextual.Image"), System.Drawing.Image)
        Me.AñadirImagenContextual.Name = "AñadirImagenContextual"
        Me.AñadirImagenContextual.Size = New System.Drawing.Size(267, 22)
        Me.AñadirImagenContextual.Text = "Añadir imagen"
        '
        'ImagenSiguienteContextual
        '
        Me.ImagenSiguienteContextual.Image = CType(resources.GetObject("ImagenSiguienteContextual.Image"), System.Drawing.Image)
        Me.ImagenSiguienteContextual.Name = "ImagenSiguienteContextual"
        Me.ImagenSiguienteContextual.Size = New System.Drawing.Size(267, 22)
        Me.ImagenSiguienteContextual.Text = "Imagen Siguiente"
        '
        'ImagenAnteriorContextual
        '
        Me.ImagenAnteriorContextual.Image = CType(resources.GetObject("ImagenAnteriorContextual.Image"), System.Drawing.Image)
        Me.ImagenAnteriorContextual.Name = "ImagenAnteriorContextual"
        Me.ImagenAnteriorContextual.Size = New System.Drawing.Size(267, 22)
        Me.ImagenAnteriorContextual.Text = "Imagen Anterior"
        '
        'RotarDerechaContextual
        '
        Me.RotarDerechaContextual.Image = CType(resources.GetObject("RotarDerechaContextual.Image"), System.Drawing.Image)
        Me.RotarDerechaContextual.Name = "RotarDerechaContextual"
        Me.RotarDerechaContextual.Size = New System.Drawing.Size(267, 22)
        Me.RotarDerechaContextual.Text = "Rotar derecha"
        '
        'RotarIzquierdaContextual
        '
        Me.RotarIzquierdaContextual.Image = CType(resources.GetObject("RotarIzquierdaContextual.Image"), System.Drawing.Image)
        Me.RotarIzquierdaContextual.Name = "RotarIzquierdaContextual"
        Me.RotarIzquierdaContextual.Size = New System.Drawing.Size(267, 22)
        Me.RotarIzquierdaContextual.Text = "Rotar izquierda"
        '
        'ZoomAlejarContextual
        '
        Me.ZoomAlejarContextual.Image = CType(resources.GetObject("ZoomAlejarContextual.Image"), System.Drawing.Image)
        Me.ZoomAlejarContextual.Name = "ZoomAlejarContextual"
        Me.ZoomAlejarContextual.Size = New System.Drawing.Size(267, 22)
        Me.ZoomAlejarContextual.Text = "Zoom Alejar"
        '
        'ZoomAcercarContextual
        '
        Me.ZoomAcercarContextual.Image = CType(resources.GetObject("ZoomAcercarContextual.Image"), System.Drawing.Image)
        Me.ZoomAcercarContextual.Name = "ZoomAcercarContextual"
        Me.ZoomAcercarContextual.Size = New System.Drawing.Size(267, 22)
        Me.ZoomAcercarContextual.Text = "Zoom Acercar"
        '
        'AjustarTamañoAVistaContextual
        '
        Me.AjustarTamañoAVistaContextual.Image = CType(resources.GetObject("AjustarTamañoAVistaContextual.Image"), System.Drawing.Image)
        Me.AjustarTamañoAVistaContextual.Name = "AjustarTamañoAVistaContextual"
        Me.AjustarTamañoAVistaContextual.Size = New System.Drawing.Size(267, 22)
        Me.AjustarTamañoAVistaContextual.Text = "Ajustar tamaño a vista"
        '
        'EliminarTodasLasImágenesDelVisorContextual
        '
        Me.EliminarTodasLasImágenesDelVisorContextual.Image = CType(resources.GetObject("EliminarTodasLasImágenesDelVisorContextual.Image"), System.Drawing.Image)
        Me.EliminarTodasLasImágenesDelVisorContextual.Name = "EliminarTodasLasImágenesDelVisorContextual"
        Me.EliminarTodasLasImágenesDelVisorContextual.Size = New System.Drawing.Size(267, 22)
        Me.EliminarTodasLasImágenesDelVisorContextual.Text = "Eliminar todas las imágenes del visor"
        '
        'lblNumFoto
        '
        Me.lblNumFoto.AutoSize = True
        Me.lblNumFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFoto.Location = New System.Drawing.Point(389, 510)
        Me.lblNumFoto.Name = "lblNumFoto"
        Me.lblNumFoto.Size = New System.Drawing.Size(44, 20)
        Me.lblNumFoto.TabIndex = 8
        Me.lblNumFoto.Text = "0 / 0"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.pbMiniaturaAnterior)
        Me.Panel1.Controls.Add(Me.pbMiniaturaActual)
        Me.Panel1.Controls.Add(Me.pbMiniaturaSiguiente)
        Me.Panel1.Location = New System.Drawing.Point(122, 397)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 110)
        Me.Panel1.TabIndex = 9
        '
        'pbMiniaturaAnterior
        '
        Me.pbMiniaturaAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbMiniaturaAnterior.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbMiniaturaAnterior.Location = New System.Drawing.Point(111, 16)
        Me.pbMiniaturaAnterior.Name = "pbMiniaturaAnterior"
        Me.pbMiniaturaAnterior.Size = New System.Drawing.Size(113, 78)
        Me.pbMiniaturaAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMiniaturaAnterior.TabIndex = 4
        Me.pbMiniaturaAnterior.TabStop = False
        '
        'pbMiniaturaActual
        '
        Me.pbMiniaturaActual.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbMiniaturaActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbMiniaturaActual.Image = CType(resources.GetObject("pbMiniaturaActual.Image"), System.Drawing.Image)
        Me.pbMiniaturaActual.Location = New System.Drawing.Point(229, 16)
        Me.pbMiniaturaActual.Name = "pbMiniaturaActual"
        Me.pbMiniaturaActual.Size = New System.Drawing.Size(113, 78)
        Me.pbMiniaturaActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMiniaturaActual.TabIndex = 3
        Me.pbMiniaturaActual.TabStop = False
        '
        'pbMiniaturaSiguiente
        '
        Me.pbMiniaturaSiguiente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pbMiniaturaSiguiente.Location = New System.Drawing.Point(347, 16)
        Me.pbMiniaturaSiguiente.Name = "pbMiniaturaSiguiente"
        Me.pbMiniaturaSiguiente.Size = New System.Drawing.Size(113, 78)
        Me.pbMiniaturaSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMiniaturaSiguiente.TabIndex = 5
        Me.pbMiniaturaSiguiente.TabStop = False
        '
        'btnAnyadirImagen
        '
        Me.btnAnyadirImagen.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAnyadirImagen.FlatAppearance.BorderSize = 0
        Me.btnAnyadirImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAnyadirImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAnyadirImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnyadirImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnyadirImagen.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnAnyadirImagen.Image = CType(resources.GetObject("btnAnyadirImagen.Image"), System.Drawing.Image)
        Me.btnAnyadirImagen.Location = New System.Drawing.Point(203, 70)
        Me.btnAnyadirImagen.Name = "btnAnyadirImagen"
        Me.btnAnyadirImagen.Size = New System.Drawing.Size(400, 275)
        Me.btnAnyadirImagen.TabIndex = 6
        Me.btnAnyadirImagen.Text = "Clic para añadir imágenes"
        Me.btnAnyadirImagen.UseVisualStyleBackColor = False
        '
        'pboxFoto
        '
        Me.pboxFoto.Location = New System.Drawing.Point(121, 40)
        Me.pboxFoto.Name = "pboxFoto"
        Me.pboxFoto.Size = New System.Drawing.Size(575, 351)
        Me.pboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxFoto.TabIndex = 2
        Me.pboxFoto.TabStop = False
        '
        'ReproducirToolStripMenuItem
        '
        Me.ReproducirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReproducirPaseDeDiapositivasToolStripMenuItem})
        Me.ReproducirToolStripMenuItem.Name = "ReproducirToolStripMenuItem"
        Me.ReproducirToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ReproducirToolStripMenuItem.Text = "&Reproducir"
        '
        'ReproducirPaseDeDiapositivasToolStripMenuItem
        '
        Me.ReproducirPaseDeDiapositivasToolStripMenuItem.Image = CType(resources.GetObject("ReproducirPaseDeDiapositivasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReproducirPaseDeDiapositivasToolStripMenuItem.Name = "ReproducirPaseDeDiapositivasToolStripMenuItem"
        Me.ReproducirPaseDeDiapositivasToolStripMenuItem.Size = New System.Drawing.Size(240, 22)
        Me.ReproducirPaseDeDiapositivasToolStripMenuItem.Text = "&Reproducir pase de diapositivas"
        '
        'ReprodcirPaseDeDiapositivasContextual
        '
        Me.ReprodcirPaseDeDiapositivasContextual.Image = CType(resources.GetObject("ReprodcirPaseDeDiapositivasContextual.Image"), System.Drawing.Image)
        Me.ReprodcirPaseDeDiapositivasContextual.Name = "ReprodcirPaseDeDiapositivasContextual"
        Me.ReprodcirPaseDeDiapositivasContextual.Size = New System.Drawing.Size(267, 22)
        Me.ReprodcirPaseDeDiapositivasContextual.Text = "Reprodcir pase de diapositivas"
        '
        'Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 571)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbFlechaSiguiente)
        Me.Controls.Add(Me.pbFlechaAnterior)
        Me.Controls.Add(Me.lblNumFoto)
        Me.Controls.Add(Me.btnAnyadirImagen)
        Me.Controls.Add(Me.pboxFoto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.msArchivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.msArchivo
        Me.MaximumSize = New System.Drawing.Size(838, 610)
        Me.MinimumSize = New System.Drawing.Size(838, 610)
        Me.Name = "Visor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor de Imágenes"
        Me.msArchivo.ResumeLayout(False)
        Me.msArchivo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pbFlechaSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFlechaAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbMiniaturaAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMiniaturaActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMiniaturaSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pboxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msArchivo As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenSiguienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagenAnteriorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RotarImagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RotarIzquiedaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomAlejarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsAnyadir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsAnterior As ToolStripButton
    Friend WithEvents tsSiguiente As ToolStripButton
    Friend WithEvents tsRotarIzquierda As ToolStripButton
    Friend WithEvents tsRotarDerecha As ToolStripButton
    Friend WithEvents tsZoomAlejar As ToolStripButton
    Friend WithEvents tsZoomAcercar As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pboxFoto As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents AjustarTamañoAVistaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsExtender As ToolStripButton
    Friend WithEvents btnAnyadirImagen As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AñadirImagenContextual As ToolStripMenuItem
    Friend WithEvents ImagenSiguienteContextual As ToolStripMenuItem
    Friend WithEvents ImagenAnteriorContextual As ToolStripMenuItem
    Friend WithEvents RotarDerechaContextual As ToolStripMenuItem
    Friend WithEvents RotarIzquierdaContextual As ToolStripMenuItem
    Friend WithEvents ZoomAlejarContextual As ToolStripMenuItem
    Friend WithEvents ZoomAcercarContextual As ToolStripMenuItem
    Friend WithEvents AjustarTamañoAVistaContextual As ToolStripMenuItem
    Friend WithEvents lblNumFoto As Label
    Friend WithEvents pbMiniaturaActual As PictureBox
    Friend WithEvents pbMiniaturaAnterior As PictureBox
    Friend WithEvents pbMiniaturaSiguiente As PictureBox
    Friend WithEvents pbFlechaAnterior As PictureBox
    Friend WithEvents pbFlechaSiguiente As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EliminarTodasLasImágenesDelVisorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsReset As ToolStripButton
    Friend WithEvents EliminarTodasLasImágenesDelVisorContextual As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsPlay As ToolStripButton
    Friend WithEvents ReproducirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReproducirPaseDeDiapositivasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReprodcirPaseDeDiapositivasContextual As ToolStripMenuItem
End Class
