let x = ref 1
let y = ref 2

let rec factorial n =
    if n = 0 then 1
    else n * factorial (n - 1)

let z = factorial 5

printf "%d %d %d" !x !y z