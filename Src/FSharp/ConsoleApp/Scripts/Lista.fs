module Lista


let lista() =
    
    let list1 = [1;2;3;4]
    list1 
        |> List.iter (printfn "Num:  %i")
    printfn ""
    printfn "%A" list1
    printfn ""

    let list2 = 5::6::7::[]
    printfn "%A" list2
    printfn ""
    
    let list3 = [1..5]
    printfn "%A" list3
    printfn ""

    let list4 = ['a'..'g']
    printfn "%A" list4
    printfn "Index 2: %c" (list4.[2])
    printfn "Head: %c" (list4.Head)
    printfn "Tail: %A" (list4.Tail)
    printfn ""

    let list5 = List.init 5 (fun i -> i * 2)
    printfn "%A" list5
    printfn ""

    let list6 = [for a in 1..5 do yield (a*a)]
    printfn "%A" list6
    printfn ""
    
    let list7 = [for a in 1..20 do if a % 2 = 0 then yield a]
    printfn "%A" list7
    printfn ""
    
    let list8 = [for a in 1..3 do yield! [a .. a+2]]
    printfn "%A" list8
    printfn "Length: %i" list8.Length
    printfn "Empty: %b"  list8.IsEmpty
    printfn ""
    
    let list9 = list3
                |> List.filter(fun x -> x % 2 = 0)

    printfn "%A" list9
    printfn ""
    
    let list10 = list9
                |> List.map(fun x -> x * x)

    printfn "%A" list10
    printfn ""
    
    
    printfn "Sorted: %A" (List.sort [5;4;3])
    printfn "Sum: %i" (List.fold (fun sum elem -> sum + elem) 0 [1;2;3])
    printfn ""