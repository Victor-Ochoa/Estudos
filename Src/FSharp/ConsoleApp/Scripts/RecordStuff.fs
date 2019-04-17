module RecordStuff

type customer =
    {
        Name: string;
        Balance: float;
    }

let record_stuff() =
    let bob = {Name = "Bob Smith" ; Balance = 101.5}
    printfn "%s owes us %.2f" bob.Name bob.Balance