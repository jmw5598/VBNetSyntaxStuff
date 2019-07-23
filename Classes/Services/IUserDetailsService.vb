Imports System.Collections.Generic
Imports Classes.Models

Namespace Services
    Public Interface IUserDetailsService
        Sub AddUserDetails(ByVal user As UserDetails)
        Sub RemoveUserDetailsByEmail(ByVal email As String)
        Function GetAllUserDetails() As IList(Of UserDetails)
        Function GetUserDetailsByEmail(ByVal email As String) As UserDetails
    End Interface
End Namespace