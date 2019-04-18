open System

type Produto = class
    val Length: int
    val Arr1: float[]
    val Arr2: float[]

    new (lenght) =
        {
            Length = lenght;
            Arr1 = Array.zeroCreate<float> lenght;
            Arr2 = Array.zeroCreate<float> lenght
        }

    member this.EscalarRec =
        let rec calc (x : int) : float =
            if x < 0 then 0.0
            else 
                ((this.Arr1.[x]) * (this.Arr2.[x])) + (calc (x-1))

        calc (this.Length - 1)
                
    member this.EscalarMut =
         let mutable result = 0.0
         for i = 0 to (this.Length - 1) do
            result <- result + ((this.Arr1.[i]) * (this.Arr2.[i]))
         result
end

[<EntryPoint>]
let main argv =
    let prod = new Produto(3)

    prod.Arr1.SetValue (5.5, 0)
    prod.Arr1.SetValue (6.6, 1)
    prod.Arr1.SetValue (9.3, 2)
    
    prod.Arr2.SetValue (2.9, 0)
    prod.Arr2.SetValue (9.1, 1)
    prod.Arr2.SetValue (7.1, 2)

    printfn "Produto escalar: %.2f" prod.EscalarRec

    0
