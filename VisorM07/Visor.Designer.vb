<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomAlejarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsAnyadir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsAnterior = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.tsRotarIzquierda = New System.Windows.Forms.ToolStripButton()
        Me.tsRotarDerecha = New System.Windows.Forms.ToolStripButton()
        Me.tsZoomAlejar = New System.Windows.Forms.ToolStripButton()
        Me.tsZoomAcercar = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pboxFoto = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pbMiniaturaActual = New System.Windows.Forms.PictureBox()
        Me.pbMiniaturaAnterior = New System.Windows.Forms.PictureBox()
        Me.pbMiniaturaSiguiente = New System.Windows.Forms.PictureBox()
        Me.msArchivo.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pboxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMiniaturaActual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMiniaturaAnterior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMiniaturaSiguiente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msArchivo
        '
        Me.msArchivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VistaToolStripMenuItem})
        Me.msArchivo.Location = New System.Drawing.Point(0, 0)
        Me.msArchivo.Name = "msArchivo"
        Me.msArchivo.Size = New System.Drawing.Size(834, 24)
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
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AbrirToolStripMenuItem.Text = "A&nyadir foto(s)"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'VistaToolStripMenuItem
        '
        Me.VistaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImagenSiguienteToolStripMenuItem, Me.ImagenAnteriorToolStripMenuItem, Me.RotarImagenToolStripMenuItem, Me.ToolStripMenuItem1, Me.ZoomToolStripMenuItem, Me.ZoomAlejarToolStripMenuItem})
        Me.VistaToolStripMenuItem.Name = "VistaToolStripMenuItem"
        Me.VistaToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.VistaToolStripMenuItem.Text = "&Vista"
        '
        'ImagenSiguienteToolStripMenuItem
        '
        Me.ImagenSiguienteToolStripMenuItem.Image = CType(resources.GetObject("ImagenSiguienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImagenSiguienteToolStripMenuItem.Name = "ImagenSiguienteToolStripMenuItem"
        Me.ImagenSiguienteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ImagenSiguienteToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ImagenSiguienteToolStripMenuItem.Text = "Imagen &Siguiente"
        '
        'ImagenAnteriorToolStripMenuItem
        '
        Me.ImagenAnteriorToolStripMenuItem.Image = CType(resources.GetObject("ImagenAnteriorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImagenAnteriorToolStripMenuItem.Name = "ImagenAnteriorToolStripMenuItem"
        Me.ImagenAnteriorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImagenAnteriorToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ImagenAnteriorToolStripMenuItem.Text = "Imagen &Anterior"
        '
        'RotarImagenToolStripMenuItem
        '
        Me.RotarImagenToolStripMenuItem.Image = CType(resources.GetObject("RotarImagenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RotarImagenToolStripMenuItem.Name = "RotarImagenToolStripMenuItem"
        Me.RotarImagenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RotarImagenToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.RotarImagenToolStripMenuItem.Text = "Rotar &derecha"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem1.Text = "Rotar &izquierda"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.Image = CType(resources.GetObject("ZoomToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ZoomToolStripMenuItem.Text = "&Zoom Acercar"
        '
        'ZoomAlejarToolStripMenuItem
        '
        Me.ZoomAlejarToolStripMenuItem.Image = CType(resources.GetObject("ZoomAlejarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ZoomAlejarToolStripMenuItem.Name = "ZoomAlejarToolStripMenuItem"
        Me.ZoomAlejarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ZoomAlejarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ZoomAlejarToolStripMenuItem.Text = "Z&oom Alejar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnyadir, Me.ToolStripSeparator1, Me.tsAnterior, Me.ToolStripButton4, Me.tsRotarIzquierda, Me.tsRotarDerecha, Me.tsZoomAlejar, Me.tsZoomAcercar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 524)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(10, 0, 1, 0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip1.Size = New System.Drawing.Size(834, 37)
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
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(34, 34)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        Me.ToolStripButton4.ToolTipText = "Ver foto siguiente"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        '
        'pboxFoto
        '
        Me.pboxFoto.Location = New System.Drawing.Point(121, 40)
        Me.pboxFoto.Name = "pboxFoto"
        Me.pboxFoto.Size = New System.Drawing.Size(575, 330)
        Me.pboxFoto.TabIndex = 2
        Me.pboxFoto.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pbMiniaturaActual
        '
        Me.pbMiniaturaActual.Location = New System.Drawing.Point(335, 397)
        Me.pbMiniaturaActual.Name = "pbMiniaturaActual"
        Me.pbMiniaturaActual.Size = New System.Drawing.Size(153, 88)
        Me.pbMiniaturaActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMiniaturaActual.TabIndex = 3
        Me.pbMiniaturaActual.TabStop = False
        '
        'pbMiniaturaAnterior
        '
        Me.pbMiniaturaAnterior.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbMiniaturaAnterior.Location = New System.Drawing.Point(121, 397)
        Me.pbMiniaturaAnterior.Name = "pbMiniaturaAnterior"
        Me.pbMiniaturaAnterior.Size = New System.Drawing.Size(153, 88)
        Me.pbMiniaturaAnterior.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMiniaturaAnterior.TabIndex = 4
        Me.pbMiniaturaAnterior.TabStop = False
        '
        'pbMiniaturaSiguiente
        '
        Me.pbMiniaturaSiguiente.Location = New System.Drawing.Point(543, 397)
        Me.pbMiniaturaSiguiente.Name = "pbMiniaturaSiguiente"
        Me.pbMiniaturaSiguiente.Size = New System.Drawing.Size(153, 88)
        Me.pbMiniaturaSiguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMiniaturaSiguiente.TabIndex = 5
        Me.pbMiniaturaSiguiente.TabStop = False
        '
        'Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 561)
        Me.Controls.Add(Me.pbMiniaturaSiguiente)
        Me.Controls.Add(Me.pbMiniaturaAnterior)
        Me.Controls.Add(Me.pbMiniaturaActual)
        Me.Controls.Add(Me.pboxFoto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.msArchivo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.msArchivo
        Me.Name = "Visor"
        Me.Text = "Visor de Imágenes"
        Me.msArchivo.ResumeLayout(False)
        Me.msArchivo.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pboxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMiniaturaActual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMiniaturaAnterior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMiniaturaSiguiente, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ZoomAlejarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsAnyadir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsAnterior As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents tsRotarIzquierda As ToolStripButton
    Friend WithEvents tsRotarDerecha As ToolStripButton
    Friend WithEvents tsZoomAlejar As ToolStripButton
    Friend WithEvents tsZoomAcercar As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pboxFoto As PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pbMiniaturaActual As PictureBox
    Friend WithEvents pbMiniaturaAnterior As PictureBox
    Friend WithEvents pbMiniaturaSiguiente As PictureBox
End Class
