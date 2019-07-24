Namespace Collections
    Public Interface IList(Of T)
        Sub Add(ByVal node As Node(Of T))
        Sub Remove(ByVal node As Node(Of T))
        Function Find(ByVal node As Node(Of T)) As T
        Function GetValue(ByVal index As Integer) As T
    End Interface
End Namespace