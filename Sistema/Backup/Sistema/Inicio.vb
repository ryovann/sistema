﻿Imports MySql.Data.MySqlClient


Public Class Inicio
    Private data As New data
    Dim conn As MySqlConnection = New MySqlConnection
    Dim Comando As New MySqlCommand
    Dim DataGridOk As Boolean
    Dim PorcentajeDeGanancia = 20
    Dim CosteDeFlete = 150
    Public Dir, User, Pass As String




    Public Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As String = "C:\Sistema\Data\Config\config.dat"


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

                '----------------------------------------
                'Falta programar impuestos en bd

                PorcentajeDeGanancia = 20
                CosteDeFlete = 150


                lblFlete.Text = "Costes por Flete: " & CosteDeFlete & " Pesos"
                lblPorcentaje.Text = "Porcentaje de Ganancia: " & PorcentajeDeGanancia & "%"

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
                DataGrid.DataSource = a
                DataGrid.Columns.Item(0).Visible = False
                DataGridOk = True
                DataGrid.Rows.Item(0).Selected = True


                Dim c As Integer = 0
                For Each f As DataGridViewRow In DataGrid.Rows
                    DataGrid.Rows.Item(c).ContextMenuStrip = Contex1


                    If (f.Cells.Item(4).Value() < 3 And f.Cells.Item(4).Value() > 0) Then
                        DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Yellow
                    ElseIf (f.Cells.Item(4).Value = 0) Then
                        DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Red
                    Else
                        DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Green

                    End If
                    c += 1

                Next





            Catch ex As Exception
                MessageBox.Show(ex.Message)
                conn.Close()
                DataGridOk = False

            End Try

        Else
            Dim Busqueda As String = txtBusqueda.Text
            DataGrid.DataSource = Nothing



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
                DataGrid.DataSource = a
                DataGrid.Columns.Item(0).Visible = False
                DataGridOk = True


                Dim c As Integer = 0
                For Each f As DataGridViewRow In DataGrid.Rows

                    If (f.Cells.Item(4).Value() < 3) Then
                        DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Yellow
                    ElseIf (f.Cells.Item(4).Value = 0) Then
                        DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Red
                    Else
                        DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Green

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
            PanelFiltros.Width = 344
            PanelFiltros.Height = 191


        Else
            PanelFiltros.Visible = False
            btnAgregarMostrar.Enabled = True
            PanelBusqueda.Enabled = True

        End If
    End Sub

    Private Sub btnAgregarMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarMostrar.Click
        If (PanelAgregar.Visible = False) Then
            PanelAgregar.Visible = True
            PanelAgregar.Width = 353
            PanelAgregar.Height = 350
            PanelBusqueda.Enabled = False
            btnFiltros.Enabled = False

            
        Else
            PanelAgregar.Visible = False
            PanelBusqueda.Enabled = True
            btnFiltros.Enabled = True

        End If
    End Sub

    Private Sub DataGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGrid.ColumnHeaderMouseClick


        Dim c As Integer = 0
        For Each f As DataGridViewRow In DataGrid.Rows

            If (f.Cells.Item(4).Value() < 3 And f.Cells.Item(4).Value > 0) Then
                DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Yellow
            ElseIf (f.Cells.Item(4).Value = 0) Then
                DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Red
            Else
                DataGrid.Rows.Item(c).DefaultCellStyle.BackColor = Color.Green

            End If
            c += 1

        Next
    End Sub

    Private Sub DataGrid_RowContextMenuStripNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowContextMenuStripNeededEventArgs) Handles DataGrid.RowContextMenuStripNeeded
        DataGrid.Rows.Item(e.RowIndex).Selected = True


        










    End Sub

  

    Private Sub DataGrid_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid.SelectionChanged
        Try
            If (DataGridOk = True) Then
                If (DataGrid.SelectedRows.Item(0).Cells.Item(4).Value = 0) Then
                    lblCantidadDisponible.Text = "Sin Stock"
                    lblCantidadDisponible.ForeColor = Color.Red
                    lblTotal.Text = "Total:"
                    lblTotalPesos.Text = "Total:"
                    btnVender.Enabled = False


                ElseIf (txtCantidadProd.Text > DataGrid.SelectedRows.Item(0).Cells.Item(4).Value) Then
                    lblCantidadDisponible.Text = " /  " & DataGrid.SelectedRows.Item(0).Cells.Item(4).Value
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

                            Dim PrecioUnitario As Integer = DataGrid.SelectedRows.Item(0).Cells.Item(6).Value
                            Dim Moneda As String = DataGrid.SelectedRows.Item(0).Cells.Item(5).Value
                            lblPrecioUnitario.Text = "Precio Unitario:  " & PrecioUnitario & " " & Moneda

                            Dim Cantidad
                            If (txtCantidadProd.Text = "") Then
                                Cantidad = 0
                            Else
                                Cantidad = txtCantidadProd.Text
                            End If
                            lblCantidadDisponible.Text = " /  " & DataGrid.SelectedRows.Item(0).Cells.Item(4).Value

                            '------------DOLARES------------------
                            If (Moneda = "Dolares") Then
                                Dim a1 As Double = PrecioUnitario * Cantidad
                                total = a1
                                Dim PorcentajeDeGananciaTotal = PorcentajeDeGanancia
                                total = total + ((total * PorcentajeDeGananciaTotal) / 100)




                                total = total + (CosteDeFlete / txtCotizacion.Text)










                                lblTotal.Text = "Total: " & total & " " & Moneda
                                lblTotalPesos.Text = "Total: " & total * txtCotizacion.Text & " Pesos"







                            Else
                                '-------------------PESOS---------------------------------------
                                Dim a1 As Double = PrecioUnitario * Cantidad
                                total = a1
                                Dim PorcentajeDeGananciaTotal = PorcentajeDeGanancia
                                total = total + ((total * PorcentajeDeGananciaTotal) / 100)
                                total = total + CosteDeFlete





                                lblTotal.Text = "Total: " & total / txtCotizacion.Text & " Dolares"
                                lblTotalPesos.Text = "Total: " & total & " " & Moneda




                            End If
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

                If (a > DataGrid.SelectedRows.Item(0).Cells.Item(4).Value) Then
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
        Dim CantidadActual As Integer = DataGrid.SelectedRows.Item(0).Cells.Item(4).Value
        Dim Index As Integer = DataGrid.SelectedRows.Item(0).Cells.Item(0).Value
        Dim FechaDeVenta As Date = Now.Date
        Dim CantidadVenta As Integer = txtCantidadProd.Text
        '------------------------------------------------------------------
        Comando.Connection = conn
        Comando.CommandText = "UPDATE `productos` SET `ProCant` = '" & CantidadActual - CantidadVenta & "' WHERE `productos`.`ProCod` = " & Index



        Try
            conn.Open()
            Comando.ExecuteReader()
            MessageBox.Show("Venta correctamente realizada", "Sistema")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al concretar la venta. Codigo de error:" & ex.Message, "Sistema")
        End Try
       





    End Sub

    Private Sub btnActualizarProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarProducto.Click
        Dim ProCodigo As Integer = DataGrid.SelectedRows.Item(0).Cells.Item(0).Value
        Dim ProTipo As String = DataGrid.SelectedRows.Item(0).Cells.Item(1).Value
        Dim ProMarca As String = DataGrid.SelectedRows.Item(0).Cells.Item(2).Value
        Dim ProModelo As String = DataGrid.SelectedRows.Item(0).Cells.Item(3).Value
        Dim ProCantidad As Integer = DataGrid.SelectedRows.Item(0).Cells.Item(4).Value
        Dim Moneda As String = DataGrid.SelectedRows.Item(0).Cells.Item(5).Value
        Dim ProPrecioUnitario As Integer = DataGrid.SelectedRows.Item(0).Cells.Item(6).Value
        Dim ProDescripccion As String = DataGrid.SelectedRows.Item(0).Cells.Item(7).Value



        'Bloqueo otros paneles
        PanelBusqueda.Enabled = False
        btnFiltros.Enabled = False
        btnAgregarMostrar.Enabled = False
        txtCotizacion.Enabled = False
        btnOKCotizacion.Enabled = False
        '------------------------------------------
        'Muestro panel
        PanelEditarProducto.Visible = True
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



    End Sub

    Private Sub btnCancelarEdicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarEdicion.Click
        'Activo otros paneles
        PanelBusqueda.Enabled = True
        btnFiltros.Enabled = True
        btnAgregarMostrar.Enabled = True
        txtCotizacion.Enabled = True
        btnOKCotizacion.Enabled = True
        '------------------------------------------
        'Oculto panel
        PanelEditarProducto.Visible = False
    End Sub

    Private Sub cmbEditarMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEditarMoneda.SelectedIndexChanged
        txtPrecioUnitario.Focus()
    End Sub

    Private Sub btnGuardarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarCambios.Click
        Comando.Connection = conn
        Dim Moneda As String = cmbEditarMoneda.SelectedItem.ToString
        Dim ProCodigo As Integer = DataGrid.SelectedRows.Item(0).Cells.Item(0).Value
        Comando.CommandText = "UPDATE PRODUCTOS SET ProTipo = '" & txtEditarTipo.Text & "' , ProMarca = '" & txtEditarMarca.Text & "' , ProModelo = '" & txtEditarModelo.Text & "' , ProCant=" & txtEditarCantidad.Text & " , Moneda='" & Moneda & "' , ProPrecioUnitario=" & txtEditarPrecioUnitario.Text & " , ProDescripccion='" & txtEditarDescripcion.Text & "' where ProCod=" & ProCodigo
        Try
            conn.Open()
            Comando.ExecuteReader()
            conn.Close()
            MessageBox.Show("Producto editado correctamente", "Sistema")

            btnCancelarEdicion_Click(Nothing, Nothing)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
End Class