let mutable x = 10
let mutable y = 20

let swap2 (x : byref<int>) (y: byref<int>) = 
    let temp = x
    x <- y
    y <- temp

swap2 &x &y
printf "%d %d" x y //This will print 20 10 as expected because the variables are passed by reference