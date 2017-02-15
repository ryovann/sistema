Imports MySql.Data.MySqlClient

Public NotInheritable Class Splash

    'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").




    'Dim conn As MySqlConnection = New MySqlConnection

    'Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Dim ConnectionString As String
    '    Dim Comando As String
    '    conn.ConnectionString = ConnectionString
    '    Dim command As MySqlCommand = New MySqlCommand(Comando, conn)




    '    Dim Path As String = "C:\Sistema\Data\Config\config.dat"

    '    Dim ServerTryConnect As Integer



    '    ''''''Se verifica el estado de la configuracion
    '    'lblTrabajoActual.Text = "Verificando la configuracion..."
    '    Dim Server As String
    '    Dim Username As String
    '    Dim Password As String








    '    Dim file As System.IO.StreamReader
    '        file = My.Computer.FileSystem.OpenTextFileReader(Path)
    '        Server = file.ReadLine()
    '        Username = file.ReadLine()
    '        Password = file.ReadLine()
    '        file.Close()
    '        ConnectionString = "server=" & Server & ";" & "user id=" & Username & ";" & "password=" & Password & "; database='prueba';"
    '    'While (ServerTryConnect < 3)
    '    Try
    '                conn.Open()
    '                If (conn.State = ConnectionState.Open) Then
    '                    lblTrabajoActual.Text = "Conexion exitosa"
    '                    MessageBox.Show("jkjkjkjk")
    '                Else
    '                    lblTrabajoActual.Text = "Fallo la conexion, Intento " & ServerTryConnect & " /3"
    '                    MessageBox.Show("dADSDSAD")
    '                End If
    '            Catch ex As Exception
    '                ServerTryConnect += 1

    '            End Try
    '        'End While




    'End Sub

End Class
