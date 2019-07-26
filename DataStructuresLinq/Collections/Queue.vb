Namespace Collections
    Public Class Queue(Of T)
        Implements IQueue(Of T)

        Private _head As Node(Of T)
        Private _tail As Node(Of T)
        Private _count As Integer

        ' Add value to the Queue
        Public Sub Enqueue(ByVal value As T) Implements IQueue(Of T).Enqueue
            Dim newNode As Node(Of T) = new Node(Of T)(value)

            If Me._head Is Nothing Then
                Me._head = newNode
                Me._tail = newNode
            Else
                Me._tail.NextNode = newNode
                Me._tail = newNode
            End If

            Me._count += 1
        End Sub
        
        ' Remove ndoe from the  queue
        Public Function Dequeue() As T Implements IQueue(Of T).Dequeue
            If Me._head Is Nothing Then
                Return Nothing
            End If

            Dim value As T = Me._head.Value
            Me._head = Me._head.NextNode
            Me._count -= 1
            Return value
        End Function
        
        ' Get next value in the queue
        Public Function Peek() As T Implements IQueue(Of T).Peek
            If Me._head Is Nothing Then
                Return Nothing
            End If

            Return Me._head.Value
        End Function
        
        ' Get count of the queue
        Public Function Count() As Integer Implements IQueue(Of T).Count
            Return Me._count
        End Function

    End Class
End Namespace