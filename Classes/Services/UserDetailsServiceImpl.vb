Imports System.Collections.Generic
Imports Classes.Models

Namespace Services
    Public Class UserDetailsServiceImpl 
        Implements IUserDetailsService

        Private _usersDetails As IList(Of UserDetails)

        Public Sub New()
            Me._usersDetails = new List(Of UserDetails)()
            Me._usersDetails.Add(
                New UserDetails(1232, "John", "Doe", "jd@gmail.com", "password")
            )
        End Sub

        ' Add A New User
        Public Sub AddUserDetails(ByVal user As UserDetails) Implements IUserDetailsService.AddUserDetails
            Me._usersDetails.Add(user)
        End Sub

        ' Remove A User By Email
        Public Sub RemoveUserDetailsByEmail(ByVal email As String) Implements IUserDetailsService.RemoveUserDetailsByEmail
            Me._usersDetails = Me._usersDetails _ 
                .Where(Function(e) e.Email <> email) _
                .ToList()
        End Sub

        ' Get All Users
        Public Function GetAllUserDetails() As IList(Of UserDetails) Implements IUserDetailsService.GetAllUserDetails
            Return Me._usersDetails
        End Function
        
        ' Get Single User By Email
        Public Function GetUserDetailsByEmail(ByVal email As String) As UserDetails Implements IUserDetailsService.GetUserDetailsByEmail
            Return Me._usersDetails _
                .Where(Function(e) e.Email = email) _
                .FirstOrDefault()
        End Function

    End Class
End Namespace