Imports System.Net.NetworkInformation
Imports MySql.Data.MySqlClient
Imports scripting


Public Class Inicio
    Private data As New data
    Dim conn As MySqlConnection = New MySqlConnection
    Dim Comando As New MySqlCommand
    Dim DataGridOk As Boolean
    Dim ProGanancia
    Dim ProFlete
    Dim IdCliente
    Public me_state As Boolean = True
    Dim VentaMonto As Double


    Public Dir, User, Pass As String
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Return nics(1).GetPhysicalAddress.ToString


    End Function




    Function ENCRIPTAR(ByVal string_encriptar As String) As String
        Dim R As Integer
        Dim I As Integer
        R = Len(Trim(string_encriptar))
        For I = 1 To R
            Mid(string_encriptar, I, 1) = Chr(Asc(Mid(string_encriptar, I, 1)) - 1)
        Next I
        Return string_encriptar
    End Function

    Function DESENCRIPTAR(ByVal string_desencriptar As String) As String
        Dim R As Integer
        Dim i As Integer
        R = Len(Trim(string_desencriptar))
        For i = 1 To R
            Mid(string_desencriptar, i, 1) = Chr(Asc(Mid(string_desencriptar, i, 1)) + 1)
        Next i
        Return string_desencriptar
    End Function



    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        For Each MyObject As PictureBox In Me.Controls.OfType(Of PictureBox)()
            If Not IsNothing(MyObject.Image) And MyObject.Visible = True Then
                e.Graphics.DrawImageUnscaled(New Bitmap(MyObject.Image), MyObject.Left, MyObject.Top)
            End If
        Next
    End Sub

    Public Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load








        Dim path As String = "C:\Sistema\Data\Config\config.dat"
        ChbClienteFinal.Checked = True


        txtCantidadProd.Text = "1"
        If (System.IO.File.Exists(path) = False) Then
            btnConectar.Enabled = False
            IO.Directory.CreateDirectory("C:\Sistema\Data\Config\")
            Dim file1 As System.IO.StreamWriter
            file1 = My.Computer.FileSystem.OpenTextFileWriter(path, True)
            file1.Close()

            If (MessageBox.Show("Imposible comenzar conexion, configure datos de servidor", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK) Then
                btnConfig_Click(sender, e)
            End If

        End If

        Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader(path)
        Cfg.txtDireccion.Text = file.ReadLine()
        Cfg.txtUsuario.Text = file.ReadLine()
        Cfg.txtPassword.Text = file.ReadLine()
        file.Close()

        file = My.Computer.FileSystem.OpenTextFileReader(path)
        Dir = file.ReadLine()
        User = file.ReadLine()
        Pass = file.ReadLine()
        file.Close()



        file = My.Computer.FileSystem.OpenTextFileReader(path)
        data.GSDireccion = Dir
        data.GSUsuario = User
        data.GSPassword = Pass
        file.Close()

        conn.ConnectionString = "server=" & data.GSDireccion & ";" & "user id=" & data.GSUsuario & ";" & "password=" & data.GSPassword & "; database='prueba';"
        Comando.Connection = conn

        Dim EncryptedMac As String = ENCRIPTAR(getMacAddress() & "sdiasjd")
        Comando.CommandText = "SELECT * From state"
        Dim info As new DataTable
        Try
            conn.Open()
            info.Load(Comando.ExecuteReader())
            conn.Close()
            If (info.Rows.Count = 0) Then
                Comando.CommandText = "INSERT INTO STATE VALUES('" & EncryptedMac & "');"
                Try
                    conn.Open()
                    Comando.ExecuteReader()
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                Dim dbmacaddress As String = info.Rows.Item(0).Item(0)
                If (dbmacaddress = DESENCRIPTAR(EncryptedMac)) Then
                    MessageBox.Show("Bienvenido")
                Else
                    Me.Close()
                End If




            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click




        conn.ConnectionString = "server=" & data.GSDireccion & ";" & "user id=" & data.GSUsuario & ";" & "password=" & data.GSPassword & "; database='prueba';"
        Try
            conn.Open()
            If (conn.State = 1) Then
                lblConEstado.Text = "Conectado"
                lblConEstado.ForeColor = Color.Blue
                PanelBusqueda.Enabled = True
                btnAgregarMostrar.Enabled = True
                btnFiltros.Enabled = True
                txtCotizacion.Enabled = True
                btnOKCotizacion.Enabled = True
                txtBusqueda.Enabled = True
                btnBuscar.Enabled = True
                btnConectar.Enabled = False
                '----------------------------------------
                'Falta programar impuestos en bd

                'PorcentajeDeGanancia = 20
                'CosteDeFlete = 150


                'lblFlete.Text = "Costes por Flete: " & CosteDeFlete & " Pesos"
                'lblPorcentaje.Text = "Porcentaje de Ganancia: " & PorcentajeDeGanancia & "%"

                '''-------------------------------------





                conn.Close()
            Else
                lblConEstado.Text = "Desconectado"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub btnConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfig.Click
        Cfg.Visible = True
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        DataGridOk = False
        txtCantidadProd.Text = 1
        btnSeleccionar.Enabled = True


        Comando.Connection = conn
        If (txtBusqueda.Text = "") Then

            Comando.CommandText = "SELECT * FROM PRODUCTOS"
            Dim a As New DataTable
            Try
                conn.Open()
                a.Load(Comando.ExecuteReader)
                conn.Close()
                a.Columns.Item(1).ColumnName = "Tipo"
                a.Columns.Item(2).ColumnName = "Marca"
                a.Columns.Item(3).ColumnName = "Modelo"
                a.Columns.Item(4).ColumnName = "Cantidad"
                a.Columns.Item(5).ColumnName = "Moneda"
                a.Columns.Item(6).ColumnName = "Precio Unitario"
                a.Columns.Item(7).ColumnName = "Descripción"
                DataGridProductos.DataSource = a
                DataGridProductos.Columns.Item(0).Visible = False
                DataGridProductos.Columns.Item(8).Visible = False
                DataGridProductos.Columns.Item(9).Visible = False
                DataGridOk = True
                DataGridProductos.Rows.Item(0).Selected = True


                Dim c As Integer = 0
                For Each f As DataGridViewRow In DataGridProductos.Rows
                    DataGridProductos.Rows.Item(c).ContextMenuStrip = Contex1


                    If (f.Cells.Item(4).Value() < 3 And f.Cells.Item(4).Value() > 0) Then
                        DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Yellow
                    ElseIf (f.Cells.Item(4).Value = 0) Then
                        DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Red
                    Else
                        DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Green

                    End If
                    c += 1

                Next





            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
                DataGridOk = False
                btnSeleccionar.Enabled = False

            End Try

        Else
            Dim Busqueda As String = txtBusqueda.Text
            DataGridProductos.DataSource = Nothing



            Comando.CommandText = "SELECT * FROM PRODUCTOS WHERE ProTipo='" & txtBusqueda.Text & "' or productos.ProDescripccion LIKE '%" & txtBusqueda.Text.ToString & "%' or productos.ProModelo LIKE '%" & txtBusqueda.Text & "%' or productos.ProMarca LIKE '%" & txtBusqueda.Text & "%'"
            Dim a As New DataTable
            Try
                conn.Open()
                a.Load(Comando.ExecuteReader)
                conn.Close()
                a.Columns.Item(1).ColumnName = "Tipo"
                a.Columns.Item(2).ColumnName = "Marca"
                a.Columns.Item(3).ColumnName = "Modelo"
                a.Columns.Item(4).ColumnName = "Cantidad"
                a.Columns.Item(5).ColumnName = "Moneda"
                a.Columns.Item(6).ColumnName = "Precio Unitario"
                a.Columns.Item(7).ColumnName = "Descripción"
                DataGridProductos.DataSource = a
                DataGridProductos.Columns.Item(0).Visible = False
                DataGridOk = True


                Dim c As Integer = 0
                For Each f As DataGridViewRow In DataGridProductos.Rows

                    If (f.Cells.Item(4).Value() < 3) Then
                        DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Yellow
                    ElseIf (f.Cells.Item(4).Value = 0) Then
                        DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Red
                    Else
                        DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Green

                    End If
                    c += 1

                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
                DataGridOk = False

            End Try



        End If








    End Sub

    Private Sub BtnLimpiar_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtTipo.Text = Nothing
        txtCantidad.Text = Nothing
        txtPrecioUnitario.Text = Nothing
        txtDescripccion.Text = Nothing
        txtMarca.Text = Nothing
        txtModelo.Text = Nothing
        cmbMoneda.SelectedItem = Nothing

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Moneda As String = cmbMoneda.SelectedItem.ToString

        Comando.Connection = conn
        Comando.CommandText = "INSERT INTO PRODUCTOS VALUES(0,'" & txtTipo.Text & "','" & txtMarca.Text & "','" & txtModelo.Text & "'," & txtCantidad.Text & ",'" & Moneda & "'," & txtPrecioUnitario.Text & ",'" & txtDescripccion.Text & "'," & txtFlete.Text & "," & txtPorcentaje.Text & ");"


        Try
            conn.Open()
            Comando.ExecuteReader()
            MessageBox.Show("Producto agregado correctamente", "Sistema")
            BtnLimpiar_click(Nothing, Nothing)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try




    End Sub


    Private Sub btnFiltros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltros.Click
        If (PanelFiltros.Visible = False) Then
            PanelFiltros.Visible = True
            btnAgregarMostrar.Enabled = False
            PanelBusqueda.Enabled = False

        Else
            PanelFiltros.Visible = False
            btnAgregarMostrar.Enabled = True
            PanelBusqueda.Enabled = True

        End If
    End Sub

    Private Sub btnAgregarMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMostrar.Click
        If (PanelAgregar.Visible = False) Then
            'Muestro panel agregar
            PanelAgregar.Visible = True
            PanelAgregar.BringToFront()
            'Oculto lo demas
            PanelBusqueda.Enabled = False
            btnFiltros.Enabled = False
            txtCotizacion.Enabled = False
            btnOKCotizacion.Enabled = False
            PanelInfoProducto.Visible = False
            PanelClientes.Visible = False
            btnBuscar.Enabled = False
            txtBusqueda.Enabled = False
            btnSeleccionar.Enabled = False

        Else
            'Oculto panel Agregar
            PanelAgregar.Visible = False
            PanelAgregar.SendToBack()
            'Muestro todo lo demas
            PanelBusqueda.Enabled = True
            btnBuscar.Enabled = True
            txtBusqueda.Enabled = True
            btnFiltros.Enabled = True
            txtCotizacion.Enabled = True
            btnOKCotizacion.Enabled = True
            PanelClientes.Visible = True
            PanelInfoProducto.Visible = True
            btnSeleccionar.Enabled = True
        End If
    End Sub

    Private Sub DataGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridProductos.ColumnHeaderMouseClick


        Dim c As Integer = 0
        For Each f As DataGridViewRow In DataGridProductos.Rows

            If (f.Cells.Item(4).Value() < 3 And f.Cells.Item(4).Value > 0) Then
                DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Yellow
            ElseIf (f.Cells.Item(4).Value = 0) Then
                DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Red
            Else
                DataGridProductos.Rows.Item(c).DefaultCellStyle.BackColor = Color.Green

            End If
            c += 1

        Next
    End Sub

    Private Sub DataGrid_RowContextMenuStripNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventArgs) Handles DataGridProductos.RowContextMenuStripNeeded
        DataGridProductos.Rows.Item(e.RowIndex).Selected = True
    End Sub



    Private Sub DataGrid_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridProductos.SelectionChanged

        Try
            If (DataGridOk = True) Then
                If (DataGridProductos.SelectedRows.Item(0).Cells.Item(4).Value = 0) Then
                    lblCantidadDisponible.Text = "Sin Stock"
                    lblCantidadDisponible.ForeColor = Color.Red
                    lblTotal.Text = "Total:"
                    lblTotalPesos.Text = "Total:"
                    btnVender.Enabled = False


                ElseIf (txtCantidadProd.Text > DataGridProductos.SelectedRows.Item(0).Cells.Item(4).Value) Then
                    lblCantidadDisponible.Text = " /  " & DataGridProductos.SelectedRows.Item(0).Cells.Item(4).Value
                    lblCantidadDisponible.ForeColor = Color.Black
                    MessageBox.Show("No se dispone de productos suficientes")
                    txtCantidadProd.ForeColor = Color.Red
                    lblTotal.Text = "Total:"
                    btnVender.Enabled = False

                Else
                    lblCantidadDisponible.ForeColor = Color.Black

                    btnVender.Enabled = True
                    txtCantidadProd.ForeColor = Color.Black


                    If (DataGridOk = True) Then
                        Try
                            Dim total As Double

                            Dim PrecioUnitario As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(6).Value
                            Dim Moneda As String = DataGridProductos.SelectedRows.Item(0).Cells.Item(5).Value
                            ProGanancia = DataGridProductos.SelectedRows.Item(0).Cells.Item(9).Value
                            ProFlete = DataGridProductos.SelectedRows.Item(0).Cells.Item(8).Value
                            lblPrecioUnitario.Text = "Precio Unitario:  " & PrecioUnitario & " " & Moneda

                            lblPorcentaje.Text = "Porcentaje de Ganancia: " & ProGanancia & "%"
                            lblFlete.Text = "Coste por Flete: " & ProFlete & " Pesos"


                            Dim Cantidad
                            If (txtCantidadProd.Text = "") Then
                                Cantidad = 0
                            Else
                                Cantidad = txtCantidadProd.Text
                            End If
                            lblCantidadDisponible.Text = " /  " & DataGridProductos.SelectedRows.Item(0).Cells.Item(4).Value

                            '------------DOLARES------------------
                            If (Moneda = "Dolares") Then
                                Dim a1 As Double = PrecioUnitario * Cantidad
                                total = a1
                                Dim PorcentajeDeGananciaTotal = ProGanancia * Cantidad

                                total = total + ((total * PorcentajeDeGananciaTotal) / 100)




                                total = total + ((ProFlete * Cantidad) / txtCotizacion.Text)










                                lblTotal.Text = "Total: " & total & " " & Moneda
                                lblTotalPesos.Text = "Total: " & total * txtCotizacion.Text & " Pesos"
                                VentaMonto = total * txtCotizacion.Text






                            Else
                                '-------------------PESOS---------------------------------------
                                Dim a1 As Double = PrecioUnitario * Cantidad
                                total = a1
                                Dim PorcentajeDeGananciaTotal = ProGanancia * Cantidad
                                total = total + ((total * PorcentajeDeGananciaTotal) / 100)
                                total = total + (ProFlete * Cantidad)

                                lblTotal.Text = "Total: " & total / txtCotizacion.Text & " Dolares"
                                lblTotalPesos.Text = "Total: " & total & " " & Moneda
                                VentaMonto = total




                            End If




                            '''SE MUESTRA LA INFORMACION EN EL GRP

                            lblCodigo.Text = "Codigo: " & DataGridProductos.SelectedRows.Item(0).Cells.Item(0).Value
                            lblTipo.Text = "Tipo: " & DataGridProductos.SelectedRows.Item(0).Cells.Item(1).Value
                            lblMarca.Text = "Marca: " & DataGridProductos.SelectedRows.Item(0).Cells.Item(2).Value
                            lblModelo.Text = "Modelo: " & DataGridProductos.SelectedRows.Item(0).Cells.Item(3).Value
                            lblDescripcion.Text = "Descripcion: " & DataGridProductos.SelectedRows.Item(0).Cells.Item(7).Value
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try


                    End If
                End If
            End If
        Catch ex As Exception

        End Try






    End Sub

    Private Sub txtCantidadProd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadProd.TextChanged
        Dim a As Integer
        Try
            If (DataGridOk = True) Then
                If (txtCantidadProd.Text = "") Then
                    a = 0
                Else
                    a = txtCantidadProd.Text
                End If

                If (a > DataGridProductos.SelectedRows.Item(0).Cells.Item(4).Value) Then
                    MessageBox.Show("No se dispone de productos suficientes")
                    txtCantidadProd.ForeColor = Color.Red
                    lblTotal.Text = "Total:"
                    lblTotalPesos.Text = "Total:"

                    btnVender.Enabled = False
                Else
                    btnVender.Enabled = True
                    txtCantidadProd.ForeColor = Color.Black
                    DataGrid_SelectionChanged(Nothing, Nothing)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & "ISDISAJDI")
        End Try

    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        DataGrid_SelectionChanged(Nothing, Nothing)
    End Sub



    Private Sub txtBusqueda_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyUp
        If (e.KeyData = Keys.Enter) Then
            btnBuscar_Click(Nothing, Nothing)

        End If
    End Sub

    Private Sub btnOKCotizacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKCotizacion.Click
        DataGrid_SelectionChanged(Nothing, Nothing)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtCantidadProd.Text = ""
        txtCantidadProd.Focus()
    End Sub


    Private Sub btnVender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVender.Click
        'UPDATE `productos` SET `ProCant` = '0' WHERE `productos`.`ProCod` = 7
        Comando.Connection = conn




        Dim itsOkay As Boolean = False
        If (chbClienteOtro.Checked = True) Then
            If (txtNombreCliente.Text = "" Or txtApellidoCliente.Text = "") Then
                MessageBox.Show("Debe ingresar un nombre y apellido de cliente" & vbCrLf & "De lo contrario seleccione 'Cliente Final'")
            Else
                itsOkay = True

            End If
        Else
            itsOkay = True
        End If

        If (itsOkay = True) Then

            '------------------------------------------------------------------
            'MUESTRO EL PANEL

            PanelConfirmacionVenta.Visible = True

            'DESACTIVO LO DEMAS
            PanelBusqueda.Enabled = False
            btnBuscar.Enabled = False
            btnAgregarMostrar.Enabled = False
            btnFiltros.Enabled = False
            btnSeleccionar.Enabled = False
            btnConfig.Enabled = False
            txtBusqueda.Enabled = False
            txtCotizacion.Enabled = False
            btnOKCotizacion.Enabled = False

            '--------------------------------------------------------------------
            'Relleno el formulario

            If (ChbClienteFinal.Checked = True) Then
                lblNombreCliente.Text = "Nombre: Consumidor Final"
                lblTelefonoCliente.Visible = False
                lblApellidoCliente.Visible = False

            Else



                lblApellidoCliente.Visible = True
                lblTelefonoCliente.Visible = True

                lblNombreCliente.Text = "Nombre: " & txtNombreCliente.Text
                lblApellidoCliente.Text = "Apellido: " & txtApellidoCliente.Text
                lblTelefonoCliente.Text = "Telefono: " & txtNumeroCliente.Text
            End If

            DataGridConfirmacionVenta.Rows.Clear()

            DataGridConfirmacionVenta.Columns.Clear()


            Dim aFilasSelec As DataGridViewSelectedRowCollection = Me.DataGridProductos.SelectedRows

            Dim nContador As Integer

            For nContador = 0 To Me.DataGridProductos.Columns.Count - 1

                Me.DataGridConfirmacionVenta.Columns.Add(Me.DataGridProductos.Columns(nContador).Clone())

            Next


            For Each oFila As DataGridViewRow In aFilasSelec
                Dim nIndiceFila As Integer
                nIndiceFila = Me.DataGridConfirmacionVenta.Rows.Add()

                For Each oCelda As DataGridViewCell In oFila.Cells
                    Me.DataGridConfirmacionVenta.Rows(nIndiceFila).Cells(oCelda.ColumnIndex).Value = oCelda.Value
                Next
            Next
            DataGridConfirmacionVenta.Rows.Item(0).Cells.Item(4).Value = txtCantidadProd.Text
            DataGridConfirmacionVenta.Columns.Item(5).Visible = False







        End If





    End Sub

    Private Sub btnActualizarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarProducto.Click
        Dim ProCodigo As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(0).Value
        Dim ProTipo As String = DataGridProductos.SelectedRows.Item(0).Cells.Item(1).Value
        Dim ProMarca As String = DataGridProductos.SelectedRows.Item(0).Cells.Item(2).Value
        Dim ProModelo As String = DataGridProductos.SelectedRows.Item(0).Cells.Item(3).Value
        Dim ProCantidad As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(4).Value
        Dim Moneda As String = DataGridProductos.SelectedRows.Item(0).Cells.Item(5).Value
        Dim ProPrecioUnitario As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(6).Value
        Dim ProDescripccion As String = DataGridProductos.SelectedRows.Item(0).Cells.Item(7).Value
        Dim ProFlete As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(8).Value
        Dim ProGanancia As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(9).Value


        'Bloqueo otros paneles
        PanelBusqueda.Enabled = False
        btnFiltros.Enabled = False
        btnAgregarMostrar.Enabled = False
        txtCotizacion.Enabled = False
        btnOKCotizacion.Enabled = False
        btnBuscar.Enabled = False
        txtBusqueda.Enabled = False
        btnSeleccionar.Enabled = False
        'Oculto paneles de informacion y clientes
        PanelInfoProducto.Visible = False
        PanelClientes.Visible = False
        '------------------------------------------
        'Muestro panel
        PanelEditarProducto.Visible = True
        PanelEditarProducto.BringToFront()

        '------------------------------------------
        'Relleno campos
        txtEditarTipo.Text = ProTipo
        txtEditarCantidad.Text = ProCantidad
        txtEditarDescripcion.Text = ProDescripccion
        txtEditarMarca.Text = ProMarca
        txtEditarModelo.Text = ProModelo
        If (Moneda = "Dolares") Then
            cmbEditarMoneda.SelectedIndex = 0
        Else
            cmbEditarMoneda.SelectedIndex = 1

        End If

        txtEditarPrecioUnitario.Text = ProPrecioUnitario
        txtFleteNew.Text = ProFlete
        txtPorcentajeNew.Text = ProGanancia



    End Sub

    Private Sub btnCancelarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEdicion.Click
        'Activo otros paneles
        PanelBusqueda.Enabled = True
        btnFiltros.Enabled = True
        btnAgregarMostrar.Enabled = True
        txtCotizacion.Enabled = True
        btnOKCotizacion.Enabled = True
        PanelClientes.Visible = True
        PanelInfoProducto.Visible = True
        btnBuscar.Enabled = True
        txtBusqueda.Enabled = True
        btnSeleccionar.Enabled = True
        '------------------------------------------
        'Oculto panel
        PanelEditarProducto.Visible = False
        PanelEditarProducto.SendToBack()

    End Sub

    Private Sub cmbEditarMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEditarMoneda.SelectedIndexChanged
        txtPrecioUnitario.Focus()
    End Sub


    Private Sub ChbClienteFinal_CheckedChanged(sender As Object, e As EventArgs) Handles ChbClienteFinal.CheckedChanged
        If (ChbClienteFinal.Checked = True) Then
            chbClienteOtro.Checked = False
            PanelDatosCliente.Visible = False
            txtApellidoCliente.Text = ""
            txtNombreCliente.Text = ""
            txtNumeroCliente.Text = ""





        Else
            chbClienteOtro.Checked = True
            PanelDatosCliente.Visible = True
        End If
    End Sub

    Private Sub chbClienteOtro_CheckedChanged(sender As Object, e As EventArgs) Handles chbClienteOtro.CheckedChanged
        If (chbClienteOtro.Checked = True) Then
            ChbClienteFinal.Checked = False
            PanelDatosCliente.Visible = True





        Else
            ChbClienteFinal.Checked = True
            PanelDatosCliente.Visible = False
        End If
    End Sub

    Private Sub txtNombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCliente.TextChanged
        If (txtNombreCliente.Text = "") Then

            lstUsuarios.DataSource = Nothing
            lstUsuarios.Visible = False
        Else
            Comando.Connection = conn
            Comando.CommandText = "SELECT * From clientes where NombreCliente LIKE '%" & txtNombreCliente.Text & "%';"
            Try
                lstUsuarios.DataSource = Nothing


                conn.Open()
                Dim a As New DataTable
                a.Load(Comando.ExecuteReader())
                conn.Close()

                Dim Nombre, Apellido, ID As String


                If (a.Rows.Count = 0) Then
                    lstUsuarios.Visible = False
                    lstUsuarios.DataSource = Nothing

                Else
                    lstUsuarios.DataSource = a
                    lstUsuarios.Columns.Item(0).Visible = False
                    lstUsuarios.Columns.Item(3).Visible = False
                    lstUsuarios.Visible = True
                End If








            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()

            End Try
        End If



        If (txtNombreCliente.Text = "Consumidor") Then
            ChbClienteFinal.Checked = True
            lstUsuarios.Visible = False
        End If

    End Sub

    Private Sub btnGuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCambios.Click
        Comando.Connection = conn
        Dim Moneda As String = cmbEditarMoneda.SelectedItem.ToString
        Dim ProCodigo As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(0).Value
        Comando.CommandText = "UPDATE PRODUCTOS SET ProTipo = '" & txtEditarTipo.Text & "' , ProMarca = '" & txtEditarMarca.Text & "' , ProModelo = '" & txtEditarModelo.Text & "' , ProCant=" & txtEditarCantidad.Text & " , Moneda='" & Moneda & "' , ProPrecioUnitario=" & txtEditarPrecioUnitario.Text & " , ProDescripccion='" & txtEditarDescripcion.Text & "', ProFlete=" & txtFleteNew.Text & ", ProGanancia=" & txtPorcentajeNew.Text & " where ProCod=" & ProCodigo
        Try
            conn.Open()
            Comando.ExecuteReader()
            conn.Close()
            MessageBox.Show("Producto editado correctamente", "Sistema")

            btnCancelarEdicion_Click(Nothing, Nothing)
            btnBuscar_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub DataGrid_KeyUp(sender As Object, e As KeyEventArgs) Handles DataGridProductos.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            DataGrid_SelectionChanged(Nothing, Nothing)

        End If
    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click


        'MUESTRO EL PANEL

        PanelConfirmacionVenta.Visible = False



        'DESACTIVO LO DEMAS
        PanelBusqueda.Enabled = True
        btnBuscar.Enabled = True
        btnAgregarMostrar.Enabled = True
        btnFiltros.Enabled = True
        btnSeleccionar.Enabled = True
        btnConfig.Enabled = True
        txtBusqueda.Enabled = True
        txtCotizacion.Enabled = True
        btnOKCotizacion.Enabled = True


    End Sub

    Private Sub btnConfirmarVenta_Click(sender As Object, e As EventArgs) Handles btnConfirmarVenta.Click
        Dim CantidadActual As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(4).Value
        Dim CantidadVenta As Integer = txtCantidadProd.Text
        Dim Cliente As String
        Dim Index As Integer = DataGridProductos.SelectedRows.Item(0).Cells.Item(0).Value

        Dim ClienteRegistrado As Boolean
        Dim IDCliente As Integer


        If (ChbClienteFinal.Checked = True) Then
            Cliente = "Final"
        Else
            Cliente = "Otro"
        End If


        If (Cliente = "Otro") Then
            If (IDCliente = 0) Then
                ClienteRegistrado = False
            Else
                ClienteRegistrado = True
            End If

        Else
            ClienteRegistrado = True
        End If

        If (ClienteRegistrado = False) Then
            Comando.CommandText = "INSERT INTO CLIENTES VALUES(0,'" & txtNombreCliente.Text & "','" & txtApellidoCliente.Text & "'," & txtNumeroCliente.Text & ");"
            Try
                conn.Open()
                Comando.ExecuteReader()
                conn.Close()
                'Si se ingresa el usuario correctamente
                'Obtengo su id
                Comando.CommandText = "SELECT CodCliente from clientes where NombreCliente='" & txtNombreCliente.Text & "' and ApellidoCliente ='" & txtApellidoCliente.Text & "' and TelefonoCliente=" & txtNumeroCliente.Text & ";"

                Dim Datos As New DataTable
                Try
                    conn.Open()
                    Datos.Load(Comando.ExecuteReader)
                    conn.Close()
                    IDCliente = Datos.Rows.Item(0).Item(0).ToString
                    'Despues de obtener el idcliente realizo la venta en producto
                    Comando.CommandText = "UPDATE `productos` Set `ProCant` = '" & CantidadActual - CantidadVenta & "' WHERE `productos`.`ProCod` = " & Index
                    Try
                        conn.Open()
                        Comando.ExecuteReader()
                        conn.Close()
                        'Despues de restar ingreso la venta a la relacion en la bd
                        Dim month, day As Integer

                        If (Now.Month <= 9) Then
                            month = 0 & "" & Now.Month
                        Else
                            month = Now.Month
                        End If
                        If (Now.Day <= 9) Then
                            day = 0 & "" & Now.Day
                        Else
                            day = Now.Day
                        End If

                        Comando.CommandText = "INSERT INTO clientescompranprodserv VALUES(0," & IDCliente & "," & Index & ",1," & VentaMonto & "," & CantidadVenta & ",'" & Now.Year & "-" & month & "-" & day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "');"
                        Try
                            conn.Open()
                            Comando.ExecuteReader()
                            conn.Close()
                            MessageBox.Show("Venta correctamente realizada", "Sistema")
                            btnCancelarVenta_Click(Nothing, Nothing)
                            btnBuscar_Click(Nothing, Nothing)
                            txtNombreCliente.Text = ""
                            txtApellidoCliente.Text = ""
                            txtNumeroCliente.Text = ""
                            ChbClienteFinal.Checked = True

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            conn.Close()
                        End Try







                        conn.Close()

                    Catch ex As Exception
                        MessageBox.Show("Error al concretar la venta. Codigo de error:" & ex.Message, "Sistema")
                        conn.Close()
                    End Try



                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    conn.Close()
                End Try














            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try











        Else
            IDCliente = 1

            Comando.CommandText = "UPDATE `productos` Set `ProCant` = '" & CantidadActual - CantidadVenta & "' WHERE `productos`.`ProCod` = " & Index
            Try
                conn.Open()
                Comando.ExecuteReader()
                conn.Close()
                'Despues de restar ingreso la venta a la relacion en la bd
                Dim month, day As Integer

                If (Now.Month <= 9) Then
                    month = 0 & "" & Now.Month
                Else
                    month = Now.Month
                End If
                If (Now.Day <= 9) Then
                    day = 0 & "" & Now.Day
                Else
                    day = Now.Day
                End If

                Comando.CommandText = "INSERT INTO clientescompranprodserv VALUES(0," & IDCliente & "," & Index & ",1," & VentaMonto & "," & CantidadVenta & ",'" & Now.Year & "-" & month & "-" & day & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second & "');"
                Try
                    conn.Open()
                    Comando.ExecuteReader()
                    conn.Close()
                    MessageBox.Show("Venta correctamente realizada", "Sistema")
                    btnCancelarVenta_Click(Nothing, Nothing)
                    btnBuscar_Click(Nothing, Nothing)
                    txtNombreCliente.Text = ""
                    txtApellidoCliente.Text = ""
                    txtNumeroCliente.Text = ""
                    ChbClienteFinal.Checked = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    conn.Close()
                End Try







                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Error al concretar la venta. Codigo de error:" & ex.Message, "Sistema")
                conn.Close()
            End Try











        End If







    End Sub

    Private Sub txtNombreCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNombreCliente.KeyUp
        If (e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab) Then
            If (lstUsuarios.Rows.Count > 0) Then
                txtApellidoCliente.Text = lstUsuarios.SelectedRows.Item(0).Cells(2).Value
                txtNombreCliente.Text = lstUsuarios.SelectedRows.Item(0).Cells(1).Value
                txtNumeroCliente.Text = lstUsuarios.SelectedRows.Item(0).Cells(3).Value
                IdCliente = lstUsuarios.SelectedRows.Item(0).Cells(0).Value
                lstUsuarios.Visible = False
            End If
        End If
    End Sub

    Private Sub Inicio_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If (me_state = False) Then
            Me.me_state = True
            Me.Enabled = True

        End If
    End Sub

    Private Sub lstUsuarios_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles lstUsuarios.CellMouseDoubleClick
        If (lstUsuarios.SelectedRows.Item(0).Cells.Item(1).Value = "Consumidor") Then

            ChbClienteFinal.Checked = True
            lstUsuarios.Visible = False


        Else

            If (lstUsuarios.Rows.Count > 0) Then
                txtApellidoCliente.Text = lstUsuarios.SelectedRows.Item(0).Cells(2).Value
                txtNombreCliente.Text = lstUsuarios.SelectedRows.Item(0).Cells(1).Value
                txtNumeroCliente.Text = lstUsuarios.SelectedRows.Item(0).Cells(3).Value
                IdCliente = lstUsuarios.SelectedRows.Item(0).Cells(0).Value
                lstUsuarios.Visible = False
            End If

        End If

    End Sub

End Class