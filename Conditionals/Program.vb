Imports System

Module Program

    Public Sub Main(args As String())
        RunIfBlock(5)
        RunIfElseBlock(5)
        RunIfElseIfElseBlock(5)
        RunSelectCase(5)
    End Sub

    Public Sub RunIfBlock(ByVal num As Integer)
        If num >= 5 Then
            Console.WriteLine("RunIfBlock: Ran If Block")
        End If 
    End Sub

    Public Sub RunIfElseBlock(ByVal num AS Integer)
        If num > 10 Then
            Console.WriteLine("RunIfElseBlock: Ran If Block")
        Else
            Console.WriteLine("RunIfElseBlock: Ran Else Block")
        End If
    End Sub

    Public Sub RunIfElseIfElseBlock(ByVal num AS Integer)
        If num > 10 Then
            Console.WriteLine("RunIfElseIfElseBlock: Ran If Block")
        ElseIf num = 5 Then
            Console.WriteLine("RunIfElseIfElseBlock: Ran ElseIf Block")
        Else 
            Console.WriteLine("RunIfElseIfElseBlock: Ran Else Block")
        End If
    End Sub

    Public Sub RunSelectCase(ByVal num As Integer)
        Select Case num
            Case 1 
                Console.WriteLine("RunSelectCase: 1")
            Case 2 
                Console.WriteLine("RunSelectCase: 2")
            Case 3 
                Console.WriteLine("RunSelectCase: 3")
            Case 4 
                Console.WriteLine("RunSelectCase: 4")
            Case 5 
                Console.WriteLine("RunSelectCase: 5")
            Case Else 
                Console.WriteLine("No case found!")
        End Select
    End Sub

End Module
