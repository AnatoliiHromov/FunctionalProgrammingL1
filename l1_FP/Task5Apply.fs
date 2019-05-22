module Task5Apply
open System
open Task3Folding
let apply list = List.reduce ssqr list 
let t5r1 = Math.Sqrt(apply floatNums) 