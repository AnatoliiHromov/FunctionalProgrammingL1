module Task4Sorting
open Task3Folding
open Task1Map

let t4r1 = List.sortBy (fun x->sin(x)) floatNums 
let t4r2 = List.sortByDescending (fun x->String.length x) ["sss";"sssss";"s";"ss";"ssss"]
