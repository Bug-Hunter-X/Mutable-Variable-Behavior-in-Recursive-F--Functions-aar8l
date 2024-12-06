# Mutable Variable Behavior in Recursive F# Functions

This example demonstrates a subtle issue involving mutable variables in recursive F# functions.  The core problem lies in understanding how mutable variables are handled within the scope of recursive calls. While the `factorial` function works as expected, the mutable variables `x` and `y` remain unchanged after the function call completes. This is because the recursive calls create new instances of the variables; they don't modify the original `x` and `y`.  The example showcases how to resolve this misconception by appropriately handling mutable states.

## How to Reproduce

1. Compile and run `bug.fs`.
2. Observe that the output shows the initial values of x and y (1 and 2) instead of any updated values.

## Solution

The solution involves understanding that mutations within a recursive function don't directly affect variables outside that scope. Proper management of mutable state requires either using techniques like passing mutable variables as arguments to each recursive call, or restructuring the code to avoid relying on unexpected mutations.