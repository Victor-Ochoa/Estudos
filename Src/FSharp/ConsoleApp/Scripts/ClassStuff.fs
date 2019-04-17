module ClassStuff

open System

type Animal = class
    val Name : string
    val Height : float
    val Weight : float

    new (name, height, weight ) =
        {
            Name = name;
            Height = height;
            Weight = weight
        }

    member x.Run =
        printfn "%s Runs" x.Name

end

type Dog(name, height, weight) =
    inherit Animal(name, height, weight)

    member this.Bark =
        printfn "%s Barks" this.Name

let class_stuff() =
    
    let spot = new Animal("Spot", 20.5, 40.5)

    spot.Run

    let bowser = new Dog("Bowser", 20.5, 40.5)

    bowser.Run

    bowser.Bark