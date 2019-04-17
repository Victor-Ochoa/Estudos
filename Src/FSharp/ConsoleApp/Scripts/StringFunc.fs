module StringFunc

open System

let str1 = "This is a random string"

let str2 = @"I ignore backslashes"

let str3 = """ " I ignore double qotes and backslashes " """

let str4 = str1 + " " + str2

let exibir_resultados() =
    printfn "Resultado das funções basicas com string:"

    printfn "Length: %i" (String.length str4)

    printfn "%c" str1.[1]

    printfn "1st Word: %s" (str1.[0..3])

    let upper_string = String.collect (fun c -> sprintf"%c, " c) "commas"

    printfn "Commas: %s" upper_string

    printfn "Any upper: %b" (String.exists (fun c -> Char.IsUpper(c)) str1)

    printfn "Number: %b" (String.forall (fun c -> Char.IsDigit(c)) "1234")

    let string1 = String.init 10 (fun i -> i.ToString())

    printfn "Numbers: %s" string1

    String.iter (fun c -> printfn "  %c" c) "Print Me"
