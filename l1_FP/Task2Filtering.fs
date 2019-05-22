module Task2Filtering
open Task1Map
let t2r1 = List.filter (fun x -> x % 2 = 0) numbers1
let numbers3 = [10;23;-1;4;165;55]
let t2r2 = List.filter (fun x -> x>=10 && x<=100 ) numbers3

