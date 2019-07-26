Namespace Collections
    Interface IQueue(Of T)
        Sub Enqueue(ByVal value As T)
        Function Dequeue() As T
        Function Peek() As T
        Function Count() As Integer
    End Interface
End Namespace