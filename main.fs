module Assignment

// Problem 1
let rec prod (lst:int list) =
    if List.isEmpty lst
    then 1
    else List.head lst * prod (List.tail lst)
    // write your solution here
    

// Problem 2
let rec map f (lst:int list) =
    // write your solution here
   match lst with
    [] -> []
    h::t -> (f h)::(map f t)

// Problem 3
let rec odd (lst:int list) =
    // write your solution here
    

// Problem 4
let rec filter f lst =
    // write your solution here
    lst
