Public Class Dados

    #Region "Singleton"
        Private Shared _instance As Dados

        Public Shared Function GetInstance() As Dados
            If _instance Is Nothing
                _instance = New Dados()
            End If

            Return _instance
        End Function
    #End Region

    'Já preenchido com dados padrão
    Public Shared  _ID As Integer = 0
    Public Shared Dim _operator As string = "André Cini"
    Public Shared Dim _responsible As string = "Ricardo Saat"
    Public Shared Dim _date As string = DateTime.Now.ToString("dd/MM/yyyy")
    Public Shared Dim _local As string = "SP"

End Class
