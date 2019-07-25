Namespace Collections
    Interface IStack(Of T)
        Function Pop() As T
        Sub Push(ByVal value As T)
        Function Peek() As T
        Function Count() As Integer
    End Interface
End Namespace
