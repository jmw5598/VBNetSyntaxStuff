Namespace Models
    Public Class UserDetails 
        Inherits BaseEntity

        Public Property FirstName As String
        Public Property LastName As String
        Public Property Email As String
        Public Property Password As String

        Public Sub New()

        End Sub

        Public Sub New(ByVal Id As Integer, ByVal FirstName As String, 
            ByVal LastName As String, ByVal Email As String, ByVal Password As String)

            Me.Id = Id
            Me.FirstName = FirstName
            Me.LastName = LastName
            Me.Email = Email
            Me.Password = Password
            
        End Sub

    End Class
End Namespace