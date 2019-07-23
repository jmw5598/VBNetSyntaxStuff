Imports System.Collections.Generic
Imports Classes.Models

Namespace Services
    Public Class UserDetailsServiceImpl 
        Implements IUserDetailsService

        Private _usersDetails As IList(Of UserDetails)

        Public Sub New()
            Me._usersDetails = new List(Of UserDetails)()
        End Sub

        Public Sub AddUserDetails(ByVal user As UserDetails) Implements IUserDetailsService.AddUserDetails
        
        End Sub

        Public Sub RemoveUserDetailsByEmail(ByVal email As String) Implements IUserDetailsService.RemoveUserDetailsByEmail
        
        End Sub

        Public Function GetAllUserDetails() As IList(Of UserDetails) Implements IUserDetailsService.GetAllUserDetails
        
        End Function
        
        Public Function GetUserDetailsByEmail(ByVal email As String) As UserDetails Implements IUserDetailsService.GetUserDetailsByEmail

        End Function

    End Class
End Namespace