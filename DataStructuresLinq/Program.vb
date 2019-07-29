Imports System
Imports System.Linq

Imports DataStructuresLinq.Collections

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


        ' Using my generic LinkedList
        Dim list As IList(Of Integer) = new LinkedList(Of Integer)()
        list.Add(4)
        list.Add(1)
        list.Add(2)
        list.Add(5)

        Console.WriteLine("LinkedList Count: " & list.Count())

        Dim index As Integer = list.IndexOf(5)
        Console.WriteLine("Index of 5 = " & index)
        Console.WriteLine("value At Index " & index & ": " & list.GetValue(index))

        Console.WriteLine("Removing value 2...")
        list.Remove(2)
        Console.WriteLine("New LinkedList Count: " & list.Count())


        Console.WriteLine()
        
        ' Using my generic Stack
        Dim stack As IStack(Of Integer) = new Stack(Of Integer)()
        stack.Push(5)
        stack.Push(3)
        stack.Push(12)
        stack.Push(9)

        Console.WriteLine("Stack Count: " & stack.Count())
        Console.WriteLine("Popping 3 ....")
        stack.Pop()
        stack.Pop()
        stack.Pop()

        Console.WriteLine("Stack Peek: " & stack.Peek())
        Console.WriteLine("New Stack Count: " & stack.Count())

        Console.WriteLine()

        Dim queue AS IQueue(Of Integer) = new Queue(Of Integer)()
        queue.Enqueue(1)
        queue.Enqueue(23)
        queue.Enqueue(82)
        queue.Enqueue(55)

        Console.WriteLine("Queue Count: " & queue.Count())
        Console.WriteLine("Dequeueing 3 ....")
        queue.Dequeue()
        queue.Dequeue()
        queue.Dequeue()

        Console.WriteLine("Queue Peek: " & queue.Peek())
        Console.WriteLine("New Queue Count: " & queue.Count())

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
