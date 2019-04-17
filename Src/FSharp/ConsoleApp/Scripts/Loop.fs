module Loop

open System

let loop_while() =
    printfn "Estudo sobre while loop"

    let magic_num = "7"
    let mutable guess = ""

    while not (magic_num.Equals(guess)) do
        printfn "Guess the Number: "
        guess <- Console.ReadLine()

    printfn "You Guessed the Number!"


let loop_for() =
    printfn "Estudo sobre for loop"
    for i = 1 to 10 do
        printfn "%i" i

    printfn ""
    for i = 10 downto 1 do
        printfn "%i" i
        
    printfn ""
    for i in [1..10] do
        printfn "%i" i

    printfn ""

    [1..10]
        |> List.iter (printfn "Num: %i")
        
    printfn ""

    let sum = List.reduce (+) [1..10]
    printfn "Sum: %i" sum