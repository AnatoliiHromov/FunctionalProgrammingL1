module Task3Folding
open System
let floatNums = [2.0..8.0]
let ssqr acc x = x*x+acc
let t3r1 = List.reduce ssqr floatNums |>(fun f-> Math.Sqrt(f))
