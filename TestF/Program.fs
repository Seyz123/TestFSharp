let writeLine message =
    printf message

[<EntryPoint>]
let main argv =
    if argv.Length <= 0 then
        writeLine "There is no argv"
    else
        writeLine "There is %A args :" argv.Length
        for arg in argv do
            writeLine "- %A" arg
    0