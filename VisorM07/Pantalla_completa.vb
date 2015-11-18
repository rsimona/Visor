


Public Class Pantalla_completa

    Dim parar As Boolean = False

    Private Sub Pantalla_completa_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Pantalla_completa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = Screen.PrimaryScreen.Bounds.Size



    End Sub

End Class