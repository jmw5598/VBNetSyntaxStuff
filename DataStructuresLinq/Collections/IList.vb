Namespace Collections
    Public Interface IList(Of T As IComparable)
        Sub Add(ByVal value As T)
        Sub Remove(ByVal value As T)
        Function IndexOf(ByVal value As T) As Integer
        Function GetValue(ByVal index As Integer) As T
        Function Count() As Integer
    End Interface
End Namespace