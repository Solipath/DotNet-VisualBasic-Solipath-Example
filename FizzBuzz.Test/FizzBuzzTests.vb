Imports NUnit.Framework

Namespace FizzBuzzTest
    <TestFixture>
    Public Class FizzBuzzTests
        <Test>
        Sub Given3ReturnFizz()
            Dim fizzbuzz = new FizzBuzz.FizzBuzz
            Assert.AreEqual(fizzbuzz.Execute(3), "Fizz")
        End Sub

        <Test>
        Sub Given5ReturnBuzz()
            Dim fizzbuzz = new FizzBuzz.FizzBuzz
            Assert.AreEqual(fizzbuzz.Execute(5), "Buzz")
        End Sub

        <Test>
        Sub Given9ReturnBuzz()
            Dim fizzbuzz = new FizzBuzz.FizzBuzz
            Assert.AreEqual(fizzbuzz.Execute(9), "Fizz")
        End Sub

        <Test>
        Sub Given2Return2()
            Dim fizzbuzz = new FizzBuzz.FizzBuzz
            Assert.AreEqual(fizzbuzz.Execute(2), "2")
        End Sub

        <Test>
        Sub Given7Return7()
            Dim fizzbuzz = new FizzBuzz.FizzBuzz
            Assert.AreEqual(fizzbuzz.Execute(7), "7")
        End Sub
        <Test>
        Sub Given10ReturnBuzz()
            Dim fizzbuzz = new FizzBuzz.FizzBuzz
            Assert.AreEqual(fizzbuzz.Execute(10), "Buzz")
        End Sub
        <Test>
        Sub Given15ReturnFizzBuzz()
            Dim fizzbuzz = new FizzBuzz.FizzBuzz
            Assert.AreEqual(fizzbuzz.Execute(15), "FizzBuzz")
        End Sub
        <Test>
        Sub Given30ReturnFizzBuzz()
            Dim fizzbuzz = new FizzBuzz.FizzBuzz
            Assert.AreEqual(fizzbuzz.Execute(30), "FizzBuzz")
        End Sub
    End Class
End Namespace