//tryfsharp.org

open System

let modulus (left:int) (right:int) :int =
  if left < right then left
  elif left=right then 0
  else
    let p = left/ right
    left - (p * right)
     
let divisibleBy3 number = (number % 3) = 0
let divisibleBy5 number = (number % 5 ) = 0
let IsDivisibleBy3And5 number =  divisibleBy3 number && divisibleBy5  number

let fizzbuzz number =
  if divisibleBy3 number && divisibleBy5  number then Console.WriteLine("FizzBuzz")
  if divisibleBy3 number then Console.WriteLine("Fizz")
  elif divisibleBy5 number then Console.WriteLine("Buzz")

[<EntryPoint>]
let main argv = 
    fizzbuzz 5
    fizzbuzz 3
    fizzbuzz 45
    0 // return an integer exit code
