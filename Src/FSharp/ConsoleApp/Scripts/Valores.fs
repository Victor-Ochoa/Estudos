module Valores

open System

let exibir_PI() =
    printfn "Exibir PI"

    let big_pi = System.Math.PI
                 |> Convert.ToDecimal

    printfn "PI: %f" System.Math.PI
    printfn "BIG PI %M"big_pi

let mutabilidade() =
    printfn "Mutabilidade:"

    printfn "Predicato mutable"
    let mutable x = 175
    printfn "valor original de x: %i" x
    x <- 170 
    printfn "valor modificado de x: %i" x

    printfn ""
    printfn "Predicado ref"
    let y = ref 10
    printfn "valor original de y: %i" !y
    y := 15 
    printfn "valor modificado de y: %i" !y

