Imports System
Imports Classes.Models
Imports Classes.Services

Module Program
    Sub Main(args As String())

        Dim user As UserDetails = New UserDetails(
            1231, "Jason", "White", "jmw5598@gmail.com", "password")
        
        Dim userDetailsService As IUserDetailsService = New UserDetailsServiceImpl()

        ' Get current user counts
        Dim users = userDetailsService.GetAllUserDetails()
        Console.WriteLine("User Count: " & users.Count)

        ' Add another user and get count
        Console.WriteLine("Adding New User ....")
        userDetailsService.AddUserDetails(user)
        users = userDetailsService.GetAllUserDetails()
        Console.WriteLine("New User Count: " & users.Count)

        ' Get user details by email
        Console.WriteLine("Getting User By Email (jd@gmail.com) ....")
        Dim user2 As UserDetails = userDetailsService.GetUserDetailsByEmail("jd@gmail.com")
        Console.WriteLine("Email belongs to " & user2.FirstName & " " & user2.LastName)

        ' Remove user details by email
        Console.WriteLine("Removing User By Email (jd@gmail.com) ....")
        userDetailsService.RemoveUserDetailsByEmail("jd@gmail.com")
        users = userDetailsService.GetAllUserDetails()
        Console.WriteLine("Count After Removal: " & users.Count)

    End Sub
End Module
