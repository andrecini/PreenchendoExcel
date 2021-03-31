Imports System.IO

Public Class DataCenter
    #Region "Singleton"
        Private Shared Dim _instance As DataCenter

        Public Shared Function GetInstance() As DataCenter
            If _instance Is Nothing
                _instance = New DataCenter()
            End If

            Return _instance
        End Function

    #End Region

    #Region "Arrays With Data"
        Public Dim names As List(Of String)
        Public Dim ages As List(Of Integer)
        Public Dim states As List(Of String)
    #End Region

    #Region "Methods to create arrays"
        Private Function ReturnArrayWithNames(ByVal path As String) As String()
            Return File.ReadAllLines(String.Format("{0}", path))
        End Function

        Private Function ReturnArrayWithStates(ByVal path As String) As String()
       
            Dim statesAux = File.ReadAllLines(string.Format("{0}", path))
            Dim states(100) As String
            Dim rdm As Random = new Random()

            For i = 0 To 99
                states(i) = statesAux(rdm.Next(0, statesAux.Length - 1))
            Next

            Return states
        End Function

         Private Function ReturnArrayWithAges() As Integer()
            Dim ages(100) as Integer
            Dim rdm As Random = New Random()

            For i = 0 To 99
                ages(i) = rdm.Next(1, 100)
            Next

            Return ages
         End Function
    #End Region

    Public Sub New()
        names = ReturnArrayWithNames("nomes.txt").ToList()
        states = ReturnArrayWithStates("estados.txt").ToList()
        ages = ReturnArrayWithAges().ToList()
    End Sub
End Class
