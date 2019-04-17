module Matematica
open System

let matematica_basica() =
    printfn "Funções matematicas basicas"
    
    printfn ""

    printfn "5 + 4 = %i" (5 + 4)    
    printfn "5 - 4 = %i" (5 - 4)
    printfn "5 * 4 = %i" (5 * 4)
    printfn "5 / 4 = %i" (5 / 4)
    printfn "5 %% 4 = %i" (5 % 4)
    printfn "5 ** 2 = %f" (5.0 ** 2.0)

let tipo_valor() = 
    printfn "Type do numero:"

    let number  = 2
        
    printfn "Type: %A" (number.GetType())
    
    printfn "Float Cast: %.2f" (float number)