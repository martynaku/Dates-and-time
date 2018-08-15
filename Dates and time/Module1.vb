Module Module1

    Sub Main()

        Dim myValue As Date = Now()
        Console.WriteLine(myValue)

        Console.WriteLine(myValue.ToLongDateString())
        Console.WriteLine(myValue.ToShortDateString())
        Console.WriteLine(myValue.ToLongTimeString())
        Console.WriteLine(myValue.ToShortTimeString())

        'Console.WriteLine(myValue.Month & " -- " & myValue.DayOfWeek)
        Console.WriteLine(myValue.ToString("MMM"))

        Console.WriteLine(myValue.AddDays(3).ToShortDateString())
        Console.WriteLine(myValue.AddHours(3).ToShortTimeString())

        Console.WriteLine(myValue.AddDays(-5).ToShortDateString())

        'Dim myBirthday As New Date(1989, 5, 17)
        'Dim myBirthday As New Date
        'myBirthday = Date.Parse("17/05/1989")

        Dim myBirthday As New Date(1989, 5, 17)
        Dim myAge As TimeSpan = Date.Now.Subtract(myBirthday)
        myAge.Add(New TimeSpan(100, 0, 0, 0))

        Console.WriteLine(myAge.TotalDays)


        Console.ReadLine()

    End Sub

End Module
