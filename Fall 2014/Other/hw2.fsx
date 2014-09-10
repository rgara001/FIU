(*1.*)
let rec inner xs ys =
    match xs with
    | [] -> 0
    | x::xt -> match ys with
               y::yt -> (x*y) + (inner xt yt);;


(*2*)
let rec transpose xs =
    match xs with
    | []::_ -> []
    | _ -> (List.map (fun n -> List.head n) xs)::(transpose (List.map (fun n -> List.tail n) xs));;

let rec calculate (xs, ys) =
    match xs with
    | [] -> []
    | x::xt -> [(List.map (function n -> inner x n) ys)] @ calculate (xt, ys);;

let multiply (xs, ys) =
    let ys = transpose ys
    calculate (xs, ys);;



(*3*)

let rec merge (xs, ys) =
 match (xs, ys) with
 | ([], ys) -> ys 
 | (xs, []) -> xs 
 | (x::xs, y::ys) -> let z = x-y
                     if z < 0 then x :: merge (xs, y::ys) 
                     else y :: merge (x::xs, ys) ;;
 
let rec split = function 
 | [] -> ([], []) 
 | [a] -> ([a], []) 
 | a::b::cs -> let (M,N) = split cs
               (a::M, b::N) ;;
 
let rec mergesort = function 
 | [] -> [] 
 | L -> let (M, N) = split L
        merge(mergesort M, mergesort N);;


(*4*)

type Exp = Num of int| Neg of Exp| Sum of Exp * Exp | Diff of Exp * Exp | Prod of Exp * Exp| Quot of Exp * Exp;;

let rec evaluate = function
    | Num n -> Some n
    | Neg e -> match evaluate e with
               | None -> None
               | Some n -> Some (-n)
    | Sum(n, m) -> match evaluate n, evaluate m with
                   | None, None -> None
                   | Some n, None -> None
                   | None, Some m -> None
                   | Some n, Some m -> Some (n+m)
    | Diff(n, m) -> match evaluate n, evaluate m with
                    | None, None -> None
                    | Some n, None -> None
                    | None, Some m -> None
                    | Some n, Some m -> Some (n-m)
    | Prod(n, m) -> match evaluate n, evaluate m with
                    | None, None -> None
                    | Some n, None -> None
                    | None, Some m -> None
                    | Some n, Some m -> Some (n*m)
    | Quot(n, m) -> match evaluate n, evaluate m with
                    | None, None -> None
                    | Some n, None -> None
                    | Some n, Some 0 -> None
                    | None, Some m -> None
                    | Some n, Some m -> Some (n/m);;


(*5*)

let rec helper xs length =
    match length with
    | 1 -> [xs]
    | _ -> let xh = List.head xs
           let xt = List.tail xs
           [xs] @ helper (xt@[xh]) (length-1);;

let rotate xs =
    match xs with
    | [] -> []
    | x::xt -> helper xs (List.length xs);;