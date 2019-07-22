Imports System
Imports System.Linq

Module Program

    Public Sub Main(args As String())
        Dim title As String = "Data Structures & Linq"
        Dim strNum As String = "1232319842"

        ' String manipulation
        Console.WriteLine(title)
        Console.WriteLine(ReverseStringLinq(title))
        Console.WriteLine(ReverseOrderOfWordsLinq(title))
        Console.WriteLine(ReverseWordsCharsLinq(title))
        
        Console.WriteLine()
        
        Console.WriteLine("Sum: " & SumDigitsOfStringNumber(strNum))
        Console.WriteLine("Multiply: " & MultiplyDigitsOfStringNumber(strNum))
        Console.WriteLine("Subtract: " & SubtractDigitsOfStringNumber(strNum))

        ' Array maniuplation
        Console.WriteLine()
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

    ' Sum the digits in a string
    Public Function SumDigitsOfStringNumber(ByVal strNum As String)
        Return strNum.ToCharArray() _
            .Select(Function(a) a.ToString()) _
            .Select(Function(a) Convert.ToInt32(a)) _
            .Sum()
    End Function

    ' Multiply the digits in a string
    Public Function MultiplyDigitsOfStringNumber(ByVal strNum As String)
        Return strNum.ToCharArray() _
            .Select(Function(a) a.ToString()) _
            .Select(Function(a) Convert.ToInt32(a)) _
            .Aggregate(Function(a, b) a * b)
    End Function

    ' Substract the digits in a string
    Public Function SubtractDigitsOfStringNumber(ByVal strNum As String)
        Return strNum.ToCharArray() _
            .Select(Function(a) a.ToString()) _
            .Select(Function(a) Convert.ToInt32(a)) _
            .Aggregate(Function(a, b) a - b)
    End Function

End Module
