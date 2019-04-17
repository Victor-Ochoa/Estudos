module MapStuff

let map_stuff () =
    let customers =
        Map.empty
            .Add("Bob Smith", 100.5)
            .Add("Sally Marks", 50.25)

    printfn "# of customers %i" customers.Count

    let cust = customers.TryFind "Bob Smith"
    match cust with
    |Some x -> printfn "Balance: %.2f" x
    |None -> printfn "Not Found"

    printfn "Costumers: %A" customers

    if customers.ContainsKey "Bob Smith" then
        printfn "Bob Smith was found"

    printfn "Bobs balance: %.2f" customers.["Bob Smith"]

    let cust2 = Map.remove "Sally Marks" customers
    
    printfn "# of Customers %i" cust2.Count
    printfn "customers: %A" cust2