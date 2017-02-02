Public Class data
    Private Direccion As String
    Private Usuario As String
    Private Password As String


    Public Property GSDireccion()
        Get
            Return Direccion
        End Get
        Set(ByVal value)
            Direccion = value
        End Set
    End Property

    Public Property GSUsuario()
        Get
            Return Usuario
        End Get
        Set(ByVal value)
            Usuario = value
        End Set
    End Property
    Public Property GSPassword()
        Get
            Return Password
        End Get
        Set(ByVal value)
            Password = value
        End Set
    End Property




End Class
