Imports System
Imports System.Linq

Module Program

    Public Sub Main(args As String())
        Dim title As String = "Data Structures & Linq"
        
        Console.WriteLine(title)
        Console.WriteLine(ReverseStringLinq(title))
        Console.WriteLine(ReverseOrderOfWordsLinq(title))
        Console.WriteLine(ReverseWordsCharsLinq(title))
    End Sub

    ' Reverse a String with Linq
    Public Function ReverseStringLinq(ByVal str As String)
        Return str.ToCharArray() _
            .Select(Function(a) a.ToString()) _
            .Aggregate(Function(a, b) b + a)
    End Function

    ' Reverse the order of the words in a String
    Public Function ReverseOrderOfWordsLinq(ByVal str As String)
        Return str.Split(" ").Aggregate(Function(a, b) b + " " + a)
    End Function

    ' Reverse the word chars in a string keeping order of words
    Public Function ReverseWordsCharsLinq(ByVal str As String)
        Return str.Split(" ") _
            .Select(Function(a) a.ToCharArray() _
                .Select(Function(b) b.ToString()) _
                .Aggregate(Function(c,d) d + c)
            ) _
            .Aggregate(Function(b, c) b + " " + c)
    End Function

End Module
