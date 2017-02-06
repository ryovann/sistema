Public Class Cfg

    Private Sub btnGuardarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatos.Click
        Dim path As String = "C:\Sistema\Data\Config\config.dat"
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(path, False)
        file.WriteLine(txtDireccion.Text)
        file.WriteLine(txtUsuario.Text)
        file.WriteLine(txtPassword.Text)
        file.Flush()
        file.Close()



        Inicio.Dir = txtDireccion.Text
        Inicio.User = txtUsuario.Text
        Inicio.Pass = txtPassword.Text

        Inicio.Inicio_Load(Nothing, Nothing)

        Me.Visible = False






    End Sub

  
    Private Sub Cfg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class