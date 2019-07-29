Namespace Collections
    Public Class LinkedList(Of T As IComparable)
        Implements IList(Of T)

        Private _head As Node(Of T)
        Private _tail As Node(Of T)
        Private _count As Integer = 0

        Public Sub Add(ByVal value As T) Implements IList(Of T).Add
            Dim newNode As Node(Of T) = New Node(Of T)(value)

            If Me._head Is Nothing
                Me._head = newNode
                Me._tail = newNode
            Else
                Me._tail.NextNode = newNode
                Me._tail = newNode
            End If

            Me._count += 1
        End Sub
        
        Public Sub Remove(ByVal value As T) Implements IList(Of T).Remove
            If Me._head IsNot Nothing AND Me._head.Value.CompareTo(value) = 0 Then
                Me._head = Me._head.NextNode
                Exit Sub
            End If
            
            Dim previous As Node(Of T) = Me._head
            Dim current As Node(Of T) = Me._head.NextNode

            While current IsNot Nothing
                If current.Value.CompareTo(value) = 0 Then
                    previous.NextNode = current.NextNode
                    Me._count -= 1
                    Exit Sub
                Else
                    previous = current
                    current = current.NextNode
                End If
            End While
        End Sub
        
        Public Function IndexOf(ByVal value As T) As Integer Implements IList(Of T).IndexOf
            Dim counter As Integer = 0
            Dim temp As Node(Of T) = Me._head

            ' While temp.Value <> value ?
            While temp IsNot Nothing
                If temp.Value.CompareTo(value) = 0 Then
                    Return counter
                End If
                
                counter += 1
                temp = temp.NextNode
            End While

            Return -1
        End Function
        
        Public Function GetValue(ByVal index As Integer) As T Implements IList(Of T).GetValue
            If index < 0 Or Me._head Is Nothing Or Me.Count() <= index Then
                Return Nothing
            End If

            Dim counter As Integer = 0
            Dim temp As Node(Of T) = Me._head

            While counter <> index
                counter += 1
                temp = temp.NextNode
            End While

            Return temp.Value
        End Function

        Public Function Count() As Integer Implements IList(Of T).Count
            Return Me._count
        End Function

    End Class
End Namespace