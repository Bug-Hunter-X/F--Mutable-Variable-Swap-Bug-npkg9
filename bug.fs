let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20, not 20 10 as expected because of mutable variables

//In F#, mutable variables are used with the mutable keyword.  However, they are passed by value, meaning that a copy of the variable is passed to the function.   Therefore, only the copy inside the function is modified, while the original variables remain unchanged. This is different from languages like C# where mutable variables are passed by reference.  In order to solve this, we need to pass them as references.  Here is how:

let swap2 (x : byref<int>) (y: byref<int>) = 
    let temp = x
    x <- y
    y <- temp

let mutable x2 = 10
let mutable y2 = 20
swap2 &x2 &y2 //Notice the ampersand operator '&' used here to pass the references
printf "%d %d" x2 y2 //This will print 20 10 as expected