module TupleStuff

let tupleReturn() =
    let avg (w,x,y,z) : float =
        let sum = w + x + y + z
        sum / 4.0

    printfn "Avg: %f" (avg(1.0, 2.0, 3.0, 4.0))
    printfn ""

    let my_data = ("Victor", 23, 6.25)

    let (name,age,_) = my_data

    printfn "Name: %s" name