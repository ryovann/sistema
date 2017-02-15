<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblConEstado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Contex1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnActualizarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.grpFiltros = New System.Windows.Forms.GroupBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripccion = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpAgregarProductos = New System.Windows.Forms.GroupBox()
        Me.txtFlete = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidadProd = New System.Windows.Forms.TextBox()
        Me.PanelAgregar = New System.Windows.Forms.Panel()
        Me.PanelFiltros = New System.Windows.Forms.Panel()
        Me.btnFiltros = New System.Windows.Forms.Button()
        Me.PanelBusqueda = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTotalPesos = New System.Windows.Forms.Label()
        Me.lblCantidadDisponible = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrecioUnitario = New System.Windows.Forms.Label()
        Me.lblFlete = New System.Windows.Forms.Label()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.btnAgregarMostrar = New System.Windows.Forms.Button()
        Me.txtCotizacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnOKCotizacion = New System.Windows.Forms.Button()
        Me.PanelEditarProducto = New System.Windows.Forms.Panel()
        Me.grpEditarProd = New System.Windows.Forms.GroupBox()
        Me.txtFleteNew = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPorcentajeNew = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCancelarEdicion = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbEditarMoneda = New System.Windows.Forms.ComboBox()
        Me.txtEditarModelo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEditarMarca = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEditarTipo = New System.Windows.Forms.TextBox()
        Me.btnGuardarCambios = New System.Windows.Forms.Button()
        Me.txtEditarPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEditarCantidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEditarDescripcion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contex1.SuspendLayout()
        Me.grpAgregarProductos.SuspendLayout()
        Me.PanelAgregar.SuspendLayout()
        Me.PanelFiltros.SuspendLayout()
        Me.PanelBusqueda.SuspendLayout()
        Me.PanelEditarProducto.SuspendLayout()
        Me.grpEditarProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConfig
        '
        Me.btnConfig.Location = New System.Drawing.Point(3, 3)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(96, 23)
        Me.btnConfig.TabIndex = 2
        Me.btnConfig.Text = "Confuguracion"
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(105, 3)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(75, 23)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblConEstado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1264, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblConEstado
        '
        Me.lblConEstado.Name = "lblConEstado"
        Me.lblConEstado.Size = New System.Drawing.Size(82, 17)
        Me.lblConEstado.Text = "Desconectado"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToOrderColumns = True
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGrid.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Location = New System.Drawing.Point(3, 5)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(802, 441)
        Me.DataGrid.TabIndex = 3
        '
        'Contex1
        '
        Me.Contex1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnActualizarProducto})
        Me.Contex1.Name = "Contex1"
        Me.Contex1.Size = New System.Drawing.Size(179, 26)
        '
        'btnActualizarProducto
        '
        Me.btnActualizarProducto.Name = "btnActualizarProducto"
        Me.btnActualizarProducto.Size = New System.Drawing.Size(178, 22)
        Me.btnActualizarProducto.Text = "Actualizar Producto"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(566, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(96, 23)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.AcceptsReturn = True
        Me.txtBusqueda.Location = New System.Drawing.Point(186, 5)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(374, 20)
        Me.txtBusqueda.TabIndex = 0
        '
        'grpFiltros
        '
        Me.grpFiltros.BackColor = System.Drawing.Color.Transparent
        Me.grpFiltros.Location = New System.Drawing.Point(3, 7)
        Me.grpFiltros.Name = "grpFiltros"
        Me.grpFiltros.Size = New System.Drawing.Size(329, 176)
        Me.grpFiltros.TabIndex = 6
        Me.grpFiltros.TabStop = False
        Me.grpFiltros.Text = "Filtros de busqueda"
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(89, 216)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(134, 20)
        Me.txtPrecioUnitario.TabIndex = 6
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(67, 149)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(156, 20)
        Me.txtCantidad.TabIndex = 4
        '
        'txtDescripccion
        '
        Me.txtDescripccion.Location = New System.Drawing.Point(78, 116)
        Me.txtDescripccion.Name = "txtDescripccion"
        Me.txtDescripccion.Size = New System.Drawing.Size(145, 20)
        Me.txtDescripccion.TabIndex = 3
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(57, 17)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(166, 20)
        Me.txtTipo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Precio unitario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tipo"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(309, 251)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 7
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(308, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpAgregarProductos
        '
        Me.grpAgregarProductos.Controls.Add(Me.txtFlete)
        Me.grpAgregarProductos.Controls.Add(Me.Label18)
        Me.grpAgregarProductos.Controls.Add(Me.txtPorcentaje)
        Me.grpAgregarProductos.Controls.Add(Me.Label19)
        Me.grpAgregarProductos.Controls.Add(Me.lblMoneda)
        Me.grpAgregarProductos.Controls.Add(Me.cmbMoneda)
        Me.grpAgregarProductos.Controls.Add(Me.txtModelo)
        Me.grpAgregarProductos.Controls.Add(Me.Label8)
        Me.grpAgregarProductos.Controls.Add(Me.txtMarca)
        Me.grpAgregarProductos.Controls.Add(Me.Label7)
        Me.grpAgregarProductos.Controls.Add(Me.txtTipo)
        Me.grpAgregarProductos.Controls.Add(Me.Button1)
        Me.grpAgregarProductos.Controls.Add(Me.btnAgregar)
        Me.grpAgregarProductos.Controls.Add(Me.txtPrecioUnitario)
        Me.grpAgregarProductos.Controls.Add(Me.Label1)
        Me.grpAgregarProductos.Controls.Add(Me.txtCantidad)
        Me.grpAgregarProductos.Controls.Add(Me.Label2)
        Me.grpAgregarProductos.Controls.Add(Me.txtDescripccion)
        Me.grpAgregarProductos.Controls.Add(Me.Label3)
        Me.grpAgregarProductos.Controls.Add(Me.Label4)
        Me.grpAgregarProductos.Location = New System.Drawing.Point(13, 1)
        Me.grpAgregarProductos.Name = "grpAgregarProductos"
        Me.grpAgregarProductos.Size = New System.Drawing.Size(393, 287)
        Me.grpAgregarProductos.TabIndex = 19
        Me.grpAgregarProductos.TabStop = False
        Me.grpAgregarProductos.Text = "Agregar Productos"
        '
        'txtFlete
        '
        Me.txtFlete.Location = New System.Drawing.Point(188, 253)
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(54, 20)
        Me.txtFlete.TabIndex = 33
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(149, 256)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 13)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Flete"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(89, 253)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(54, 20)
        Me.txtPorcentaje.TabIndex = 31
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 256)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Porcentaje:"
        '
        'lblMoneda
        '
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(9, 186)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(49, 13)
        Me.lblMoneda.TabIndex = 24
        Me.lblMoneda.Text = "Moneda:"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Items.AddRange(New Object() {"Dolares", "Pesos"})
        Me.cmbMoneda.Location = New System.Drawing.Point(67, 182)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(156, 21)
        Me.cmbMoneda.TabIndex = 5
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(60, 83)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(163, 20)
        Me.txtModelo.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Modelo:"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(54, 50)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(169, 20)
        Me.txtMarca.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1024, 478)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Cantidad:"
        '
        'txtCantidadProd
        '
        Me.txtCantidadProd.Location = New System.Drawing.Point(1082, 475)
        Me.txtCantidadProd.Name = "txtCantidadProd"
        Me.txtCantidadProd.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidadProd.TabIndex = 1
        '
        'PanelAgregar
        '
        Me.PanelAgregar.Controls.Add(Me.grpAgregarProductos)
        Me.PanelAgregar.Location = New System.Drawing.Point(817, 34)
        Me.PanelAgregar.Name = "PanelAgregar"
        Me.PanelAgregar.Size = New System.Drawing.Size(423, 294)
        Me.PanelAgregar.TabIndex = 23
        Me.PanelAgregar.Visible = False
        '
        'PanelFiltros
        '
        Me.PanelFiltros.BackColor = System.Drawing.Color.Transparent
        Me.PanelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFiltros.Controls.Add(Me.grpFiltros)
        Me.PanelFiltros.Location = New System.Drawing.Point(124, 605)
        Me.PanelFiltros.Name = "PanelFiltros"
        Me.PanelFiltros.Size = New System.Drawing.Size(344, 51)
        Me.PanelFiltros.TabIndex = 24
        Me.PanelFiltros.Visible = False
        '
        'btnFiltros
        '
        Me.btnFiltros.Enabled = False
        Me.btnFiltros.Location = New System.Drawing.Point(10, 604)
        Me.btnFiltros.Name = "btnFiltros"
        Me.btnFiltros.Size = New System.Drawing.Size(108, 23)
        Me.btnFiltros.TabIndex = 0
        Me.btnFiltros.Text = "Filtros de busqueda"
        Me.btnFiltros.UseVisualStyleBackColor = True
        '
        'PanelBusqueda
        '
        Me.PanelBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.PanelBusqueda.Controls.Add(Me.Button2)
        Me.PanelBusqueda.Controls.Add(Me.lblTotalPesos)
        Me.PanelBusqueda.Controls.Add(Me.lblCantidadDisponible)
        Me.PanelBusqueda.Controls.Add(Me.btnSeleccionar)
        Me.PanelBusqueda.Controls.Add(Me.btnVender)
        Me.PanelBusqueda.Controls.Add(Me.lblTotal)
        Me.PanelBusqueda.Controls.Add(Me.lblPrecioUnitario)
        Me.PanelBusqueda.Controls.Add(Me.lblFlete)
        Me.PanelBusqueda.Controls.Add(Me.lblPorcentaje)
        Me.PanelBusqueda.Controls.Add(Me.txtCantidadProd)
        Me.PanelBusqueda.Controls.Add(Me.Label5)
        Me.PanelBusqueda.Controls.Add(Me.DataGrid)
        Me.PanelBusqueda.Enabled = False
        Me.PanelBusqueda.Location = New System.Drawing.Point(0, 27)
        Me.PanelBusqueda.Name = "PanelBusqueda"
        Me.PanelBusqueda.Size = New System.Drawing.Size(1252, 572)
        Me.PanelBusqueda.TabIndex = 26
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(1160, 475)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 20)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblTotalPesos
        '
        Me.lblTotalPesos.AutoSize = True
        Me.lblTotalPesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPesos.Location = New System.Drawing.Point(812, 533)
        Me.lblTotalPesos.Name = "lblTotalPesos"
        Me.lblTotalPesos.Size = New System.Drawing.Size(66, 25)
        Me.lblTotalPesos.TabIndex = 28
        Me.lblTotalPesos.Text = "Total:"
        '
        'lblCantidadDisponible
        '
        Me.lblCantidadDisponible.AutoSize = True
        Me.lblCantidadDisponible.Location = New System.Drawing.Point(1182, 478)
        Me.lblCantidadDisponible.Name = "lblCantidadDisponible"
        Me.lblCantidadDisponible.Size = New System.Drawing.Size(0, 13)
        Me.lblCantidadDisponible.TabIndex = 27
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(683, 452)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(122, 23)
        Me.btnSeleccionar.TabIndex = 0
        Me.btnSeleccionar.Text = "Seleccionar Producto"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnVender
        '
        Me.btnVender.Location = New System.Drawing.Point(1082, 516)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(155, 42)
        Me.btnVender.TabIndex = 2
        Me.btnVender.Text = "Vender Producto"
        Me.btnVender.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(811, 498)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(66, 25)
        Me.lblTotal.TabIndex = 26
        Me.lblTotal.Text = "Total:"
        '
        'lblPrecioUnitario
        '
        Me.lblPrecioUnitario.AutoSize = True
        Me.lblPrecioUnitario.Location = New System.Drawing.Point(814, 433)
        Me.lblPrecioUnitario.Name = "lblPrecioUnitario"
        Me.lblPrecioUnitario.Size = New System.Drawing.Size(79, 13)
        Me.lblPrecioUnitario.TabIndex = 25
        Me.lblPrecioUnitario.Text = "Precio Unitario:"
        '
        'lblFlete
        '
        Me.lblFlete.AutoSize = True
        Me.lblFlete.Location = New System.Drawing.Point(814, 398)
        Me.lblFlete.Name = "lblFlete"
        Me.lblFlete.Size = New System.Drawing.Size(86, 13)
        Me.lblFlete.TabIndex = 24
        Me.lblFlete.Text = "Costes por Flete:"
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(814, 363)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(125, 13)
        Me.lblPorcentaje.TabIndex = 23
        Me.lblPorcentaje.Text = "Porcentaje de Ganancia:"
        '
        'btnAgregarMostrar
        '
        Me.btnAgregarMostrar.Enabled = False
        Me.btnAgregarMostrar.Location = New System.Drawing.Point(9, 633)
        Me.btnAgregarMostrar.Name = "btnAgregarMostrar"
        Me.btnAgregarMostrar.Size = New System.Drawing.Size(109, 23)
        Me.btnAgregarMostrar.TabIndex = 1
        Me.btnAgregarMostrar.Text = "Agregar Producto"
        Me.btnAgregarMostrar.UseVisualStyleBackColor = True
        '
        'txtCotizacion
        '
        Me.txtCotizacion.Enabled = False
        Me.txtCotizacion.Location = New System.Drawing.Point(1171, 636)
        Me.txtCotizacion.Name = "txtCotizacion"
        Me.txtCotizacion.Size = New System.Drawing.Size(44, 20)
        Me.txtCotizacion.TabIndex = 27
        Me.txtCotizacion.Text = "30"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1064, 639)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Cotización del dolar"
        '
        'btnOKCotizacion
        '
        Me.btnOKCotizacion.Enabled = False
        Me.btnOKCotizacion.Location = New System.Drawing.Point(1221, 633)
        Me.btnOKCotizacion.Name = "btnOKCotizacion"
        Me.btnOKCotizacion.Size = New System.Drawing.Size(31, 23)
        Me.btnOKCotizacion.TabIndex = 29
        Me.btnOKCotizacion.Text = "OK"
        Me.btnOKCotizacion.UseVisualStyleBackColor = True
        '
        'PanelEditarProducto
        '
        Me.PanelEditarProducto.Controls.Add(Me.grpEditarProd)
        Me.PanelEditarProducto.Location = New System.Drawing.Point(817, 34)
        Me.PanelEditarProducto.Name = "PanelEditarProducto"
        Me.PanelEditarProducto.Size = New System.Drawing.Size(424, 294)
        Me.PanelEditarProducto.TabIndex = 24
        Me.PanelEditarProducto.Visible = False
        '
        'grpEditarProd
        '
        Me.grpEditarProd.Controls.Add(Me.txtFleteNew)
        Me.grpEditarProd.Controls.Add(Me.Label17)
        Me.grpEditarProd.Controls.Add(Me.txtPorcentajeNew)
        Me.grpEditarProd.Controls.Add(Me.Label16)
        Me.grpEditarProd.Controls.Add(Me.btnCancelarEdicion)
        Me.grpEditarProd.Controls.Add(Me.Label9)
        Me.grpEditarProd.Controls.Add(Me.cmbEditarMoneda)
        Me.grpEditarProd.Controls.Add(Me.txtEditarModelo)
        Me.grpEditarProd.Controls.Add(Me.Label10)
        Me.grpEditarProd.Controls.Add(Me.txtEditarMarca)
        Me.grpEditarProd.Controls.Add(Me.Label11)
        Me.grpEditarProd.Controls.Add(Me.txtEditarTipo)
        Me.grpEditarProd.Controls.Add(Me.btnGuardarCambios)
        Me.grpEditarProd.Controls.Add(Me.txtEditarPrecioUnitario)
        Me.grpEditarProd.Controls.Add(Me.Label12)
        Me.grpEditarProd.Controls.Add(Me.txtEditarCantidad)
        Me.grpEditarProd.Controls.Add(Me.Label13)
        Me.grpEditarProd.Controls.Add(Me.txtEditarDescripcion)
        Me.grpEditarProd.Controls.Add(Me.Label14)
        Me.grpEditarProd.Controls.Add(Me.Label15)
        Me.grpEditarProd.Location = New System.Drawing.Point(12, 6)
        Me.grpEditarProd.Name = "grpEditarProd"
        Me.grpEditarProd.Size = New System.Drawing.Size(394, 278)
        Me.grpEditarProd.TabIndex = 19
        Me.grpEditarProd.TabStop = False
        Me.grpEditarProd.Text = "Editar Producto"
        '
        'txtFleteNew
        '
        Me.txtFleteNew.Location = New System.Drawing.Point(216, 246)
        Me.txtFleteNew.Name = "txtFleteNew"
        Me.txtFleteNew.Size = New System.Drawing.Size(54, 20)
        Me.txtFleteNew.TabIndex = 29
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(149, 249)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Flete"
        '
        'txtPorcentajeNew
        '
        Me.txtPorcentajeNew.BackColor = System.Drawing.SystemColors.Window
        Me.txtPorcentajeNew.Location = New System.Drawing.Point(89, 246)
        Me.txtPorcentajeNew.Name = "txtPorcentajeNew"
        Me.txtPorcentajeNew.Size = New System.Drawing.Size(54, 20)
        Me.txtPorcentajeNew.TabIndex = 27
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Porcentaje:"
        '
        'btnCancelarEdicion
        '
        Me.btnCancelarEdicion.Location = New System.Drawing.Point(310, 218)
        Me.btnCancelarEdicion.Name = "btnCancelarEdicion"
        Me.btnCancelarEdicion.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarEdicion.TabIndex = 25
        Me.btnCancelarEdicion.Text = "Cancelar"
        Me.btnCancelarEdicion.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Moneda:"
        '
        'cmbEditarMoneda
        '
        Me.cmbEditarMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEditarMoneda.FormattingEnabled = True
        Me.cmbEditarMoneda.Items.AddRange(New Object() {"Dolares", "Pesos"})
        Me.cmbEditarMoneda.Location = New System.Drawing.Point(67, 182)
        Me.cmbEditarMoneda.Name = "cmbEditarMoneda"
        Me.cmbEditarMoneda.Size = New System.Drawing.Size(156, 21)
        Me.cmbEditarMoneda.TabIndex = 5
        '
        'txtEditarModelo
        '
        Me.txtEditarModelo.Location = New System.Drawing.Point(60, 83)
        Me.txtEditarModelo.Name = "txtEditarModelo"
        Me.txtEditarModelo.Size = New System.Drawing.Size(163, 20)
        Me.txtEditarModelo.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Modelo:"
        '
        'txtEditarMarca
        '
        Me.txtEditarMarca.Location = New System.Drawing.Point(54, 50)
        Me.txtEditarMarca.Name = "txtEditarMarca"
        Me.txtEditarMarca.Size = New System.Drawing.Size(169, 20)
        Me.txtEditarMarca.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Marca:"
        '
        'txtEditarTipo
        '
        Me.txtEditarTipo.Location = New System.Drawing.Point(57, 17)
        Me.txtEditarTipo.Name = "txtEditarTipo"
        Me.txtEditarTipo.Size = New System.Drawing.Size(166, 20)
        Me.txtEditarTipo.TabIndex = 0
        '
        'btnGuardarCambios
        '
        Me.btnGuardarCambios.Location = New System.Drawing.Point(310, 243)
        Me.btnGuardarCambios.Name = "btnGuardarCambios"
        Me.btnGuardarCambios.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarCambios.TabIndex = 7
        Me.btnGuardarCambios.Text = "Guardar"
        Me.btnGuardarCambios.UseVisualStyleBackColor = True
        '
        'txtEditarPrecioUnitario
        '
        Me.txtEditarPrecioUnitario.Location = New System.Drawing.Point(89, 216)
        Me.txtEditarPrecioUnitario.Name = "txtEditarPrecioUnitario"
        Me.txtEditarPrecioUnitario.Size = New System.Drawing.Size(134, 20)
        Me.txtEditarPrecioUnitario.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Tipo"
        '
        'txtEditarCantidad
        '
        Me.txtEditarCantidad.Location = New System.Drawing.Point(67, 149)
        Me.txtEditarCantidad.Name = "txtEditarCantidad"
        Me.txtEditarCantidad.Size = New System.Drawing.Size(156, 20)
        Me.txtEditarCantidad.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 119)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Descripción:"
        '
        'txtEditarDescripcion
        '
        Me.txtEditarDescripcion.Location = New System.Drawing.Point(78, 116)
        Me.txtEditarDescripcion.Name = "txtEditarDescripcion"
        Me.txtEditarDescripcion.Size = New System.Drawing.Size(145, 20)
        Me.txtEditarDescripcion.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Cantidad:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Precio unitario:"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.PanelFiltros)
        Me.Controls.Add(Me.PanelAgregar)
        Me.Controls.Add(Me.PanelEditarProducto)
        Me.Controls.Add(Me.btnOKCotizacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAgregarMostrar)
        Me.Controls.Add(Me.txtCotizacion)
        Me.Controls.Add(Me.btnFiltros)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.PanelBusqueda)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contex1.ResumeLayout(False)
        Me.grpAgregarProductos.ResumeLayout(False)
        Me.grpAgregarProductos.PerformLayout()
        Me.PanelAgregar.ResumeLayout(False)
        Me.PanelFiltros.ResumeLayout(False)
        Me.PanelBusqueda.ResumeLayout(False)
        Me.PanelBusqueda.PerformLayout()
        Me.PanelEditarProducto.ResumeLayout(False)
        Me.grpEditarProd.ResumeLayout(False)
        Me.grpEditarProd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConfig As System.Windows.Forms.Button
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblConEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents grpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grpAgregarProductos As System.Windows.Forms.GroupBox
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadProd As System.Windows.Forms.TextBox
    Friend WithEvents PanelAgregar As System.Windows.Forms.Panel
    Friend WithEvents PanelFiltros As System.Windows.Forms.Panel
    Friend WithEvents btnFiltros As System.Windows.Forms.Button
    Friend WithEvents PanelBusqueda As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarMostrar As System.Windows.Forms.Button
    Friend WithEvents btnVender As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPrecioUnitario As System.Windows.Forms.Label
    Friend WithEvents lblFlete As System.Windows.Forms.Label
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCotizacion As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidadDisponible As System.Windows.Forms.Label
    Friend WithEvents lblTotalPesos As System.Windows.Forms.Label
    Friend WithEvents btnOKCotizacion As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Contex1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnActualizarProducto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelEditarProducto As System.Windows.Forms.Panel
    Friend WithEvents grpEditarProd As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbEditarMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents txtEditarModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtEditarMarca As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEditarTipo As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarCambios As System.Windows.Forms.Button
    Friend WithEvents txtEditarPrecioUnitario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEditarCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEditarDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnCancelarEdicion As System.Windows.Forms.Button
    Friend WithEvents txtFleteNew As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeNew As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtFlete As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
