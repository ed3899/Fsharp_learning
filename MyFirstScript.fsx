// Conditional expressions
open System.IO

let processFile (filename: string) =
    let fileExtension = Path.GetExtension(filename)

    if fileExtension = ".fs" then
        printfn "This is a source file"
    elif fileExtension = ".fsx" then
        printfn "This is a script"
    elif fileExtension = ".fsproj" then
        printfn "This is a build configuration file"
    else
        printfn "Can't process file"

processFile "hello.fsx"
processFile "app.fs"
processFile "README.md"

// Exception Handling



