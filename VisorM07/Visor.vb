Imports Visor

Public Class Visor
    Dim v As VisorFoto = New VisorFoto(575, 330)

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
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
        pboxFoto.Image = v.Get_Foto(0)

    End Sub

    Private Sub tsAbrir_Click(sender As Object, e As EventArgs) Handles tsAnyadir.Click
        abrirFotos()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Visor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
