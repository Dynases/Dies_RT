<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F0_KardexInventario
    Inherits Modelos.ModeloF0

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgj1Datos = New Janus.Windows.GridEX.GridEX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Bt2ActualizarSaldo = New DevComponents.DotNetBar.ButtonX()
        Me.Tb3Saldo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Bt4Imprimir = New DevComponents.DotNetBar.ButtonX()
        Me.Bt3Generar = New DevComponents.DotNetBar.ButtonX()
        Me.Dti2FechaFin = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Tb2DescEquipo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.Dti1FechaIni = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Bt1BuscarCliente = New DevComponents.DotNetBar.ButtonX()
        Me.Tb1CodEquipo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Gp1Equipos = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Dgj2Busqueda = New Janus.Windows.GridEX.GridEX()
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuperTabPrincipal.SuspendLayout()
        Me.SuperTabControlPanelBuscador.SuspendLayout()
        Me.SuperTabControlPanelRegistro.SuspendLayout()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelInferior.SuspendLayout()
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelToolBar1.SuspendLayout()
        Me.PanelToolBar2.SuspendLayout()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelUsuario.SuspendLayout()
        Me.PanelNavegacion.SuspendLayout()
        Me.MPanelUserAct.SuspendLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.Dgj1Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.Dti2FechaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dti1FechaIni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gp1Equipos.SuspendLayout()
        CType(Me.Dgj2Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SuperTabPrincipal
        '
        '
        '
        '
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.CloseBox.Name = ""
        '
        '
        '
        Me.SuperTabPrincipal.ControlBox.MenuBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.Name = ""
        Me.SuperTabPrincipal.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.SuperTabPrincipal.ControlBox.MenuBox, Me.SuperTabPrincipal.ControlBox.CloseBox})
        Me.SuperTabPrincipal.SelectedTabIndex = 1
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelRegistro, 0)
        Me.SuperTabPrincipal.Controls.SetChildIndex(Me.SuperTabControlPanelBuscador, 0)
        '
        'SuperTabControlPanelBuscador
        '
        Me.SuperTabControlPanelBuscador.Controls.Add(Me.Gp1Equipos)
        Me.SuperTabControlPanelBuscador.Location = New System.Drawing.Point(0, 28)
        Me.SuperTabControlPanelBuscador.Size = New System.Drawing.Size(1179, 662)
        '
        'SuperTabControlPanelRegistro
        '
        Me.SuperTabControlPanelRegistro.Location = New System.Drawing.Point(0, 28)
        Me.SuperTabControlPanelRegistro.Size = New System.Drawing.Size(1179, 662)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelSuperior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelInferior, 0)
        Me.SuperTabControlPanelRegistro.Controls.SetChildIndex(Me.PanelPrincipal, 0)
        '
        'PanelSuperior
        '
        Me.PanelSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelSuperior.Style.BackColor1.Color = System.Drawing.Color.Yellow
        Me.PanelSuperior.Style.BackColor2.Color = System.Drawing.Color.Khaki
        Me.PanelSuperior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelSuperior.Style.GradientAngle = 90
        '
        'PanelInferior
        '
        Me.PanelInferior.Location = New System.Drawing.Point(0, 618)
        Me.PanelInferior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelInferior.Style.BackColor1.Color = System.Drawing.Color.Gold
        Me.PanelInferior.Style.BackColor2.Color = System.Drawing.Color.Gold
        Me.PanelInferior.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelInferior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelInferior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelInferior.Style.GradientAngle = 90
        '
        'BubbleBarUsuario
        '
        '
        '
        '
        Me.BubbleBarUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BackColor = System.Drawing.Color.Transparent
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBarUsuario.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBarUsuario.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBarUsuario.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBarUsuario.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelPrincipal.Size = New System.Drawing.Size(1179, 529)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.PanelUsuario, 0)
        Me.PanelPrincipal.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(171, 0)
        '
        'MRlAccion
        '
        '
        '
        '
        Me.MRlAccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1179, 529)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.Dgj1Datos)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel2.Location = New System.Drawing.Point(4, 162)
        Me.GroupPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1171, 363)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 7
        Me.GroupPanel2.Text = "Kardex"
        '
        'Dgj1Datos
        '
        Me.Dgj1Datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj1Datos.Location = New System.Drawing.Point(0, 0)
        Me.Dgj1Datos.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgj1Datos.Name = "Dgj1Datos"
        Me.Dgj1Datos.Size = New System.Drawing.Size(1165, 340)
        Me.Dgj1Datos.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Bt2ActualizarSaldo)
        Me.GroupPanel1.Controls.Add(Me.Tb3Saldo)
        Me.GroupPanel1.Controls.Add(Me.Bt4Imprimir)
        Me.GroupPanel1.Controls.Add(Me.Bt3Generar)
        Me.GroupPanel1.Controls.Add(Me.Dti2FechaFin)
        Me.GroupPanel1.Controls.Add(Me.Tb2DescEquipo)
        Me.GroupPanel1.Controls.Add(Me.LabelX4)
        Me.GroupPanel1.Controls.Add(Me.LabelX3)
        Me.GroupPanel1.Controls.Add(Me.LabelX2)
        Me.GroupPanel1.Controls.Add(Me.Dti1FechaIni)
        Me.GroupPanel1.Controls.Add(Me.LabelX1)
        Me.GroupPanel1.Controls.Add(Me.Bt1BuscarCliente)
        Me.GroupPanel1.Controls.Add(Me.Tb1CodEquipo)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(4, 4)
        Me.GroupPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(1171, 150)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 6
        Me.GroupPanel1.Text = "Datos"
        '
        'Bt2ActualizarSaldo
        '
        Me.Bt2ActualizarSaldo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt2ActualizarSaldo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt2ActualizarSaldo.Image = Global.Presentacion.My.Resources.Resources.OK
        Me.Bt2ActualizarSaldo.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.Bt2ActualizarSaldo.Location = New System.Drawing.Point(233, 79)
        Me.Bt2ActualizarSaldo.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt2ActualizarSaldo.Name = "Bt2ActualizarSaldo"
        Me.Bt2ActualizarSaldo.Size = New System.Drawing.Size(160, 74)
        Me.Bt2ActualizarSaldo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt2ActualizarSaldo.TabIndex = 13
        Me.Bt2ActualizarSaldo.Text = "Actualizar Saldo"
        '
        'Tb3Saldo
        '
        '
        '
        '
        Me.Tb3Saldo.Border.Class = "TextBoxBorder"
        Me.Tb3Saldo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb3Saldo.Location = New System.Drawing.Point(92, 79)
        Me.Tb3Saldo.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb3Saldo.Name = "Tb3Saldo"
        Me.Tb3Saldo.PreventEnterBeep = True
        Me.Tb3Saldo.ReadOnly = True
        Me.Tb3Saldo.Size = New System.Drawing.Size(133, 22)
        Me.Tb3Saldo.TabIndex = 12
        '
        'Bt4Imprimir
        '
        Me.Bt4Imprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt4Imprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt4Imprimir.Image = Global.Presentacion.My.Resources.Resources.LISTA_ALUM_TEO
        Me.Bt4Imprimir.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.Bt4Imprimir.Location = New System.Drawing.Point(652, 79)
        Me.Bt4Imprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt4Imprimir.Name = "Bt4Imprimir"
        Me.Bt4Imprimir.Size = New System.Drawing.Size(173, 74)
        Me.Bt4Imprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt4Imprimir.TabIndex = 6
        Me.Bt4Imprimir.Text = "Imprimir"
        '
        'Bt3Generar
        '
        Me.Bt3Generar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt3Generar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt3Generar.Image = Global.Presentacion.My.Resources.Resources.GENERAR_REPORTE
        Me.Bt3Generar.ImageFixedSize = New System.Drawing.Size(50, 50)
        Me.Bt3Generar.Location = New System.Drawing.Point(401, 79)
        Me.Bt3Generar.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt3Generar.Name = "Bt3Generar"
        Me.Bt3Generar.Size = New System.Drawing.Size(173, 74)
        Me.Bt3Generar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt3Generar.TabIndex = 5
        Me.Bt3Generar.Text = "Generar"
        '
        'Dti2FechaFin
        '
        '
        '
        '
        Me.Dti2FechaFin.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Dti2FechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti2FechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Dti2FechaFin.ButtonDropDown.Visible = True
        Me.Dti2FechaFin.IsPopupCalendarOpen = False
        Me.Dti2FechaFin.Location = New System.Drawing.Point(271, 43)
        Me.Dti2FechaFin.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        '
        '
        '
        Me.Dti2FechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti2FechaFin.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Dti2FechaFin.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Dti2FechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti2FechaFin.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.Dti2FechaFin.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Dti2FechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Dti2FechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti2FechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Dti2FechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti2FechaFin.MonthCalendar.TodayButtonVisible = True
        Me.Dti2FechaFin.Name = "Dti2FechaFin"
        Me.Dti2FechaFin.Size = New System.Drawing.Size(133, 22)
        Me.Dti2FechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Dti2FechaFin.TabIndex = 3
        Me.Dti2FechaFin.Value = New Date(2016, 9, 23, 6, 49, 32, 0)
        '
        'Tb2DescEquipo
        '
        '
        '
        '
        Me.Tb2DescEquipo.Border.Class = "TextBoxBorder"
        Me.Tb2DescEquipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb2DescEquipo.Location = New System.Drawing.Point(233, 7)
        Me.Tb2DescEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb2DescEquipo.Name = "Tb2DescEquipo"
        Me.Tb2DescEquipo.PreventEnterBeep = True
        Me.Tb2DescEquipo.ReadOnly = True
        Me.Tb2DescEquipo.Size = New System.Drawing.Size(592, 22)
        Me.Tb2DescEquipo.TabIndex = 8
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(4, 75)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(80, 28)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "Saldo"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(233, 39)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(29, 28)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Al"
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(4, 39)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(80, 28)
        Me.LabelX2.TabIndex = 5
        Me.LabelX2.Text = "Fecha del"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Dti1FechaIni
        '
        '
        '
        '
        Me.Dti1FechaIni.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Dti1FechaIni.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti1FechaIni.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.Dti1FechaIni.ButtonDropDown.Visible = True
        Me.Dti1FechaIni.IsPopupCalendarOpen = False
        Me.Dti1FechaIni.Location = New System.Drawing.Point(92, 43)
        Me.Dti1FechaIni.Margin = New System.Windows.Forms.Padding(4)
        '
        '
        '
        '
        '
        '
        Me.Dti1FechaIni.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti1FechaIni.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.Dti1FechaIni.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.Dti1FechaIni.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti1FechaIni.MonthCalendar.DisplayMonth = New Date(2016, 9, 1, 0, 0, 0, 0)
        Me.Dti1FechaIni.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        '
        '
        '
        Me.Dti1FechaIni.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Dti1FechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.Dti1FechaIni.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Dti1FechaIni.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Dti1FechaIni.MonthCalendar.TodayButtonVisible = True
        Me.Dti1FechaIni.Name = "Dti1FechaIni"
        Me.Dti1FechaIni.Size = New System.Drawing.Size(133, 22)
        Me.Dti1FechaIni.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Dti1FechaIni.TabIndex = 2
        Me.Dti1FechaIni.Value = New Date(2016, 9, 23, 6, 49, 32, 0)
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(4, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(80, 28)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Equipo"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Bt1BuscarCliente
        '
        Me.Bt1BuscarCliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Bt1BuscarCliente.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Bt1BuscarCliente.Image = Global.Presentacion.My.Resources.Resources.marcado_manual
        Me.Bt1BuscarCliente.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.Bt1BuscarCliente.Location = New System.Drawing.Point(189, 7)
        Me.Bt1BuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.Bt1BuscarCliente.Name = "Bt1BuscarCliente"
        Me.Bt1BuscarCliente.Size = New System.Drawing.Size(36, 25)
        Me.Bt1BuscarCliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bt1BuscarCliente.TabIndex = 1
        Me.Bt1BuscarCliente.Tooltip = "Buscar Cliente"
        '
        'Tb1CodEquipo
        '
        '
        '
        '
        Me.Tb1CodEquipo.Border.Class = "TextBoxBorder"
        Me.Tb1CodEquipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Tb1CodEquipo.Location = New System.Drawing.Point(92, 7)
        Me.Tb1CodEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.Tb1CodEquipo.Name = "Tb1CodEquipo"
        Me.Tb1CodEquipo.PreventEnterBeep = True
        Me.Tb1CodEquipo.Size = New System.Drawing.Size(101, 22)
        Me.Tb1CodEquipo.TabIndex = 0
        '
        'Gp1Equipos
        '
        Me.Gp1Equipos.CanvasColor = System.Drawing.SystemColors.Control
        Me.Gp1Equipos.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.Gp1Equipos.Controls.Add(Me.Dgj2Busqueda)
        Me.Gp1Equipos.DisabledBackColor = System.Drawing.Color.Empty
        Me.Gp1Equipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Gp1Equipos.Location = New System.Drawing.Point(0, 0)
        Me.Gp1Equipos.Margin = New System.Windows.Forms.Padding(4)
        Me.Gp1Equipos.Name = "Gp1Equipos"
        Me.Gp1Equipos.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Gp1Equipos.Size = New System.Drawing.Size(1179, 662)
        '
        '
        '
        Me.Gp1Equipos.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.Gp1Equipos.Style.BackColorGradientAngle = 90
        Me.Gp1Equipos.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Gp1Equipos.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Equipos.Style.BorderBottomWidth = 1
        Me.Gp1Equipos.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Gp1Equipos.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Equipos.Style.BorderLeftWidth = 1
        Me.Gp1Equipos.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Equipos.Style.BorderRightWidth = 1
        Me.Gp1Equipos.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.Gp1Equipos.Style.BorderTopWidth = 1
        Me.Gp1Equipos.Style.CornerDiameter = 4
        Me.Gp1Equipos.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.Gp1Equipos.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.Gp1Equipos.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Gp1Equipos.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.Gp1Equipos.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.Gp1Equipos.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Gp1Equipos.TabIndex = 1
        Me.Gp1Equipos.Text = "Equipos"
        '
        'Dgj2Busqueda
        '
        Me.Dgj2Busqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgj2Busqueda.Location = New System.Drawing.Point(7, 6)
        Me.Dgj2Busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Dgj2Busqueda.Name = "Dgj2Busqueda"
        Me.Dgj2Busqueda.Size = New System.Drawing.Size(1159, 627)
        Me.Dgj2Busqueda.TabIndex = 1
        '
        'F0_KardexInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1179, 690)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "F0_KardexInventario"
        Me.Text = "F0_KardexInventario"
        Me.Controls.SetChildIndex(Me.SuperTabPrincipal, 0)
        CType(Me.SuperTabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuperTabPrincipal.ResumeLayout(False)
        Me.SuperTabControlPanelBuscador.ResumeLayout(False)
        Me.SuperTabControlPanelRegistro.ResumeLayout(False)
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelInferior.ResumeLayout(False)
        CType(Me.BubbleBarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelToolBar1.ResumeLayout(False)
        Me.PanelToolBar2.ResumeLayout(False)
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.PanelNavegacion.ResumeLayout(False)
        Me.MPanelUserAct.ResumeLayout(False)
        Me.MPanelUserAct.PerformLayout()
        CType(Me.MEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.Dgj1Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.Dti2FechaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dti1FechaIni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gp1Equipos.ResumeLayout(False)
        CType(Me.Dgj2Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Bt2ActualizarSaldo As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Tb3Saldo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Bt4Imprimir As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Bt3Generar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Dti2FechaFin As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Tb2DescEquipo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Dti1FechaIni As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Bt1BuscarCliente As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Tb1CodEquipo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dgj1Datos As Janus.Windows.GridEX.GridEX
    Friend WithEvents Gp1Equipos As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Dgj2Busqueda As Janus.Windows.GridEX.GridEX
End Class
