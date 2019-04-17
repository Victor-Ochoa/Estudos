module Condicionais

open System

let cond_if () =
    printfn "Estudo sobre if:"
    printfn "Digite uma idade para definirmos serie americana: "

    let age = Console.ReadLine()
             |> Convert.ToInt32

    if age < 5 then
        printfn "Preschool"
    elif age = 5 then
        printfn "Kindergarten"
    elif (age > 5) && (age <= 18) then
        let grade = age - 5
        printfn "Grade %i" grade
    else
        printfn "College"

        let gpa = 3.9
        let income = 15000
        printfn "college Grant: %b" ((gpa >= 3.8) || (income <= 12000))

    printfn "Not True: %b" (not true)

    let grade2: string =
        match age with
        | age when age < 5 -> "Preschool"
        | 5 -> "Kindergarten"
        | age when (age > 5) && (age <= 18) -> "Grade " + (age - 5).ToString()
        | _ -> "College"

    printfn "Grade2: %s" grade2