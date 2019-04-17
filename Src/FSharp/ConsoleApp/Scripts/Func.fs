module Func


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

let inicio_pipiline () =
    printfn "Trabalhando com pipiline"

    let list = [5;6;7;8;9]

    printfn "Lista original: %A" list
    
    list
        |> List.filter (fun v -> (v % 2) = 0)
        |> List.map (fun m -> m * 2)
        |> printfn "Dobro dos pares: %A"

let unindo_funcoes() =
    printfn "Unindo Funções:"

    let mult_num x = x * 3
    let add_num y = y + 5

    let mult_add = mult_num >> add_num
    let add_mult = mult_num << add_num

    printfn "mult_add 10: %i" (mult_add 10)
    printfn "add_mult 10: %i" (add_mult 10)