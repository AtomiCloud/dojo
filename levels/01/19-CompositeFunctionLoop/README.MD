# Composite Function Loop

The awesomeness of a number is calculated by 
multiplying the number's minus 1 by the number's plus 1:

2's awesomeness is 3, 1 * 3
3's awesomeness is 8, 2 * 4
4's awesomeness is 15, 3 * 5

From 4 to 34:
- if number ends with 3, print the awesomeness of the square of the number
- if the number is divisible by 5 print the sqaure of the awesomeness of the number
- if is divisible by both 3 and 5, print the sum of the awesomeness of the number and the square of the number
- else print the number itself

## Expected

```
4 => 4

5 => awesome = 4 * 6 = 24
  => square = 576

6 => square = 36
  => awesome = 35 * 37 = 1295

7 => 7
8 => 8

9 => square = 81
  => awesome = 80 * 82 = 6560

10 => awesome = 9 * 11 = 99
   => square = 9801

11 => 11

12 => sqaure = 144
   => awesome = 143 * 145 = 20735

13 => 13
14 => 14

15 => sqaure = 225
   => awesome = 14 * 16 = 224
   => sum = 224 + 225 = 449

16 => 16
17 => 17

18 => sqaure = 324
   => awesome = 323 * 325 = 104975
...
33 => square = 1089
   => awesome = 1088 * 1090 = 1185920
34 => 34

Print: 4, 576, 1295, 7, 8, 6560, 9801, 11, 20735, 13, 14, 449, 16, 17, 104975, ..., 1185920, 34
```

Print them as numbers (or integers)