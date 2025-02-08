# F# Mutable Variable Swap Bug

This repository demonstrates a common error when working with mutable variables in F#.  The issue arises from the fact that mutable variables in F#, despite being mutable, are passed by value to functions, not by reference. Therefore, changes within a function do not affect the original variables.

## Bug Description
The provided F# code attempts to swap the values of two mutable integer variables using a `swap` function.  However, the swap function modifies *copies* of the variables and not the originals. This results in the original variables retaining their original values.

## Solution
To solve this issue, the variables must be passed by reference to the `swap` function. This is achieved by using the `byref` keyword and the `&` operator.  The updated solution demonstrates this approach, showcasing the correct usage of references to achieve the intended variable swapping.