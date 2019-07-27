Namespace Collections
    Public Class Node(Of T)
        Public Property Value As T
        Public Property NextNode As Node(Of T)

        Public Sub New(ByVal value As T)
            Me.Value = value
        End Sub
    End Class
End Namespace