module OptionStuff

let divisao_0 () =
    
    let divide x y =
        match y with
        | 0 -> None
        | _ -> Some (x/y)

    let result = divide 5 0

    if result.IsSome then
        printfn "Result: %i" result.Value
    elif result.IsNone then
        printfn "Can't divide by zero."

