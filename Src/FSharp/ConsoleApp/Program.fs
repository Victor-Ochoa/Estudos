open System

let exibir_PI() =
    printfn "Exibir PI"

    let big_pi = System.Math.PI
                 |> Convert.ToDecimal

    printfn "PI: %f" System.Math.PI
    printfn "BIG PI %M"big_pi

let fim_console() =
    printfn ""
    printfn "Fim da Aplicação"
    0

[<EntryPoint>]
let main argv =
    exibir_PI()

    
    fim_console()
