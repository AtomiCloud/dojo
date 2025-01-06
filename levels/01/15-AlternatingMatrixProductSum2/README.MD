# Alternating Matrix Product Sum 2

Imagine a matrix of numbers:
- horizontal: 7 to 34
- vertical: 12 to 55

For each combination:
if horizontal is odd and vertical ends with 3, print the product
if horizontal is odd and vertical ends with 7, print the sum
if horizontal is even and vertical is divisible by 5, print the absolute difference

After that, sum all the printed number and print the sum


## Expected
```
7, 13 => 91
7, 17 => 24
7, 23 => 161
7, 27 => 34
...
8, 15 => 7
8, 20 => 12
8, 25 => 17
...
8, 50 => 42
8, 55 => 47
9, 13 => 117
9, 17 => 26
9, 23 => 207
9, 27 => 36
...
34, 15 => 19
34, 20 => 14
34, 25 => 9
...
34, 50 => 16
34, 55 => 21

Sum: 91 + 24 + 161 + 34 + .. + 7 + 12 + 17 + .. + 42 + 47 + 117 + 26 + 207 + 36 + ... + 19 + 14 + 9 + ... + 16 + 21 = 51250


Print: 91, 24, 161, 34, ..., 7, 12, 17, ..., 42, 47, 117, 26, 207, 36, ..., 19, 14, 9, ..., 16, 21, 51250
```


Print them as numbers (or integers)