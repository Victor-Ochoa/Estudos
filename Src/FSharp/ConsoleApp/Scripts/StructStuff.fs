module StructStuff

type Rectangle = struct
    val Length : float
    val Width : float

    new (length, width) =
        {
        Length = length
        Width = width
        }
end

let struct_stuff () =
    let area ( shape: Rectangle ) =
        shape.Length * shape.Width

    let rect = new Rectangle(5.0, 6.0)
    
    printfn "Area: %.2f " (area rect)