Namespace Collections
    Public Class LinkedList(Of T)
        Implements IList(Of T)

        Public Sub Add(ByVal node As Node(Of T)) Implements IList(Of T).Add
        
        End Sub
        
        Public Sub Remove(ByVal node As Node(Of T)) Implements IList(Of T).Remove
        
        End Sub
        
        Public Function Find(ByVal node As Node(Of T)) As T Implements IList(Of T).Find
        
        End Function
        
        Public Function GetValue(ByVal index As Integer) As T Implements IList(Of T).GetValue

        End Function

    End Class
End Namespace