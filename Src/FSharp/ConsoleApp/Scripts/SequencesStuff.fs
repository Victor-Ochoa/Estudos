module SequencesStuff

let seq_stuff() = 
    let seq1 = seq {1 .. 100}
    printfn "Seq: %A" seq1
    Seq.toList seq1 
                |> List.iter (printf "%A ")
    printfn ""

    let seq2 = seq {0 .. 2 .. 50}
    printfn "Seq: %A" seq2
    printfn ""


    let seq3 = seq {50 .. 1}
    printfn "Seq: %A" seq3
    printfn ""

    let is_prime n =
        let rec check i =
            i > n/2 || (n % i <> 0 && check (i + 1))
        check 2

    let prime_seq = seq { for n in 1 .. 500 do if is_prime n then yield n }

    Seq.toList prime_seq
                |> List.iter ( printfn "%A")