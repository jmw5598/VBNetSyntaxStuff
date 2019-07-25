Namespace Collections
    Public Class Stack(Of T)
        Implements IStack(Of T)

        Private _head As Node(Of T)

        ' Add to the top of the stack
        Public Function Pop() As T Implements IStack(Of T).Pop
            If Me._head Is Nothing Then
                Return Nothing
            End If

            Dim value As T = Me._head.Value
            Me._head = Me._head.NextNode
            Return value
        End Function

        ' Remove from the top of the stack
        Public Sub Push(ByVal value As T) Implements IStack(Of T).Push
            Dim newNode As Node(Of T) = New Node(Of T)(value)
            
            If Me._head IsNot Nothing Then
                newNode.NextNode = Me._head
            End If

            Me._head = newNode
        End Sub

        ' Get value from top of the stack
        Public Function Peek() As T Implements IStack(Of T).Peek
            If Me._head Is Nothing Then
                Return Nothing
            End If

            Return Me._head.Value
        End Function

        ' Get size of the stack
        Public Function Count() As Integer Implements IStack(Of T).Count
            Dim counter As Integer = 0
            Dim current As Node(Of T) = Me._head
            
            While current IsNot Nothing
                counter += 1
                current = current.NextNode
            End While

            Return counter
        End Function

    End Class
End Namespace