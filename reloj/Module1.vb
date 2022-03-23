Module Module1
    Public IDEWEB As String
    Public BOK As String
    Public NOM_1 As String
    Public NOM_T As String
    Public NOMPISTA As String
    Public COMPA As String
    Public API As String

    Public PISTA As String = "/API/?Function=Fade&Duration=500&Input="
    Public OVE As String = "/API/?Function=OverlayInput"
    Public oveIN As String = "In&Input="
    Public oveOUT As String = "Out&Input="

    Public A_ACT As String = "/api/?Function=AudioOn&Input="
    Public A_DESACT As String = "/api/?Function=AudioOff&Input="

    Public PLAY As String = "/API/?Function=Play&Input="
    Public PAUSE As String = "/API/?Function=Pause&Input="
    Public REINICIO As String = "/API/?Function=Restart&Input="

    Public TRAN1 As String = "/API/?Function="
    Public TRAN2 As String = "&Input="
    Public STNG As String = "/API/?Function=Stinger1&Input="

    Public VOLU1 As String = "/API/?Function=SetVolume&Input="
    Public VOLU2 As String = "&Value="

    Public T1ID As String = "/API/?Function=SetText&SelectedIndex=0&Input="
    Public T2ID As String = "/API/?Function=SetText&SelectedIndex=1&Input="


    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\SAMCTRL_BD\basedato1.mdb;Persist Security Info=False;")
    Public instruccion As New OleDb.OleDbCommand

    Public Sub conectarse()
        Try
            conn.Open()
            'MsgBox("CONEXION OK")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub




End Module
