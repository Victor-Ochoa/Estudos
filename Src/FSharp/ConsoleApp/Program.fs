open System

let fim_console() =
    printfn ""
    printfn "Fim da Aplicação"
    0

let Executar_funcao f =
    printfn ""
    f()
    printfn ""

[<EntryPoint>]
let main argv =
    
    Executar_funcao Valores.exibir_PI
    Executar_funcao Valores.mutabilidade
    Executar_funcao Func.fazendo_funcao_soma
    Executar_funcao Func.fazendo_funcao_resursiva
    Executar_funcao Func.expressao_lambda
    Executar_funcao Func.inicio_pipiline
    Executar_funcao Func.unindo_funcoes

    fim_console()
