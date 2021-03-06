Imports Logica.AccesoLogica
Public Class PR_ServiciosVenta

#Region "Atributos"

    Private Titulo As String
    Private Tipo As Byte
    Public _dt As DataTable

    Public Property pTitulo() As String
        Get
            Return Titulo
        End Get
        Set(ByVal valor As String)
            Titulo = valor
        End Set
    End Property

    Public Property pTipo() As Byte
        Get
            Return Tipo
        End Get
        Set(ByVal valor As Byte)
            Tipo = valor
        End Set
    End Property

#End Region

    Private Sub _prCargarReporte()

        Dim objrep As New R_ImprimirVenta
        objrep.Subreports.Item("R_ImprimirVentaCopia.rpt").SetDataSource(_dt)
            objrep.SetDataSource(_dt)
            CrystalReportViewer1.ReportSource = objrep

    End Sub
    Private Sub PR_StockActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'L_prAbrirConexion()

        Me.WindowState = FormWindowState.Maximized
        Me.Text = pTitulo
        _prCargarReporte()
    End Sub
End Class