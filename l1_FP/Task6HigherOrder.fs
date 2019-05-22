module Task6HigherOrder

open Task1Map
  
let mkf lst fnc =
    let rec mkf lst lst' =
        match lst with
        | []   -> lst'
        | h::t -> if (fnc h) <> true then
                      mkf t (lst')
                  else
                      mkf t (lst' @ [h])
    mkf lst []
    
let t6r1 = mkf numbers1 (fun x->x>7)

let my_map lst fnc =
    let rec my_map lst lst' = 
        match lst with
        |[]     ->lst'
        |h::t-> my_map t (lst'@[fnc h])
    my_map lst []
let t6r2 = my_map numbers1 (fun x -> x+3)
