Imports System

Module Program

    Public Sub Main(args As String())
        Dim Names() As String = {"John", "Jane", "Jason", "Joe"}
        PrintWithForLoopForward(Names)
        PrintWithForLoopBackward(Names)
        PrintWithForEachLoop(Names)
    End Sub

    Public Sub PrintWithForLoopForward(ByVal ParamArray names() As String)
        Console.WriteLine("For Loop Forward")
        Console.WriteLine("----------------")
        
        For i As Integer = 0 To (names.Count - 1)
            Console.WriteLine(names(i))
        Next i
        
        Console.WriteLine()
    End Sub

    Public Sub PrintWithForLoopBackward(ByVal ParamArray names() As String)
        Console.WriteLine("For Loop Backward")
        Console.WriteLine("-----------------")
        
        For i As Integer = (names.Count - 1) To 0 Step -1
            Console.WriteLine(names(i))
        Next i
        
        Console.WriteLine()
    End Sub

    Public Sub PrintWithForEachLoop(ByVal ParamArray names() As String)
        Console.WriteLine("For Each Loop")
        Console.WriteLine("-------------")
        
        For Each name As String In names
            Console.WriteLine(name)
        Next name

        Console.WriteLine()
    End Sub

    Public Sub PrintWithWhileLoop(ByVal ParamArray names() As String)
        Console.WriteLine("While Loop")
        Console.WriteLine("----------")

        Dim count As Integer = 0

        While count < 5
            Console.WriteLine(names(count))
            count += 1
        End While

        Console.WriteLine()
    End Sub

End Module
