module GenericStuff

let add_stuff<'T> x y =
    printfn "%A" (x + y)

let generic_stuff () =
    
    add_stuff<float> 5.5 2.4