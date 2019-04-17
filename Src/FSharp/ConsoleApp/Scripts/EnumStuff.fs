module EnumStuff

type emotion = 
| joy = 0
| fear = 1
| anger = 2

let enum_stuff()=
    printfn "Estudo sobre enum:"

    let my_feeling = emotion.joy

    match my_feeling with
    |joy -> printfn "I'm Joyful"
    |fear -> printfn "I'm Fearful"
    |anger -> printfn "I'm Angry" 
