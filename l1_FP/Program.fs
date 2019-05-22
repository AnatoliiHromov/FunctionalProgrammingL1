open System // Gets access to functionality in System namespace.
open Task1Map
open Task2Filtering
open Task3Folding
open Task4Sorting
open Task5Apply
open Task6HigherOrder
// Defines a function that takes a name and produces a greeting.

[<EntryPoint>]
let main args =
    // Defines a list of names
    printfn "Data for task1:"
    printfn "1:%A" numbers1
    printfn "2:%A" numbers2
    printfn "res1:%A" t1r1
    printfn "res2:%A" t1r2
    printfn "Data for task2.1:"
    printfn "%A" numbers1
    printfn "res1:%A" t2r1
    printfn "Data for task2.2:"
    printfn "%A" numbers3
    printfn "res2:%A" t2r2
    printfn "Data for task3:"
    printfn "%A" floatNums
    printfn "res:%A" t3r1
    printfn "Data for task4:"
    printfn "%A" floatNums
    printfn "res1:%A" t4r1
    printfn "res2:%A" t4r2
    printfn "Data for task5:"
    printfn "%A" floatNums
    printfn "res:%A" t5r1
    printfn "Data for task6:"
    printfn "%A" numbers1
    printf "Condition x->x>7: "
    printfn "%A" t6r1
    printf "Operation x->x+3: "
    printfn "%A" t6r2
    0