module Exp

let exp_stuff () =
    
    let divide x y =
        try
            printfn "%i / %i = %i" x y (x / y)
        with
            | :? System.DivideByZeroException -> printfn "Can't divide by zero"

    divide 5 0