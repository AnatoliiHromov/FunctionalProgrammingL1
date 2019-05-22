module Task1Map
let twice x = x*2
let numbers1 = 
    [2;3;5;10;9;3;8]
let t1r1 = List.map twice numbers1
let sub x y= x-y
let numbers2 = 
    [2;1;5;9;5;12;4]
let t1r2 = List.map2 sub numbers1 numbers2
