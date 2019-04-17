open System

let fim_console() =
    printfn ""
    printfn "Fim da Aplicação"
    0

let Executar_funcao f =
    printfn ""
    f()
    printfn ""

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

let fazendo_funcao_soma() =
    printfn "Função basica de soma dentro de outra função:"

    let somar(x:int, y:int) : int = 
        x + y

    printfn "7 + 5 = %i" (somar(7, 5))

let fazendo_funcao_resursiva() =
    printfn "Função recursiva fatorial:"

    let rec fatorial x =
        if(x < 1) then 1
        else x * fatorial(x - 1)

    printfn "Fatorial de 4: %i" (fatorial 4)

let expressao_lambda() =
    printfn "Expressão lambda:"

    let rand_list = [1;2;3]

    let rand_list2 = List.map (fun x -> x * 2) rand_list

    printfn "Lista original: %A" rand_list
    printfn "Lista dobrada: %A" rand_list2

[<EntryPoint>]
let main argv =
    
    Executar_funcao exibir_PI
    Executar_funcao mutabilidade
    Executar_funcao fazendo_funcao_soma
    Executar_funcao fazendo_funcao_resursiva
    Executar_funcao expressao_lambda

    fim_console()
