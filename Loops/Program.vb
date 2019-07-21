Imports System

Module Program

    Public Sub Main(args As String())
        Dim Names() As String = {"John", "Jane", "Jason", "Joe"}
        PrintWithForLoopForward(Names)
        PrintWithForLoopBackward(Names)
    End Sub

    Public Sub PrintWithForLoopForward(ByVal ParamArray names() As String)
        Console.WriteLine("For Loop Forward")
        COnsole.WriteLine("----------------")
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

End Module
