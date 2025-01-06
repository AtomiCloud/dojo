# Alternating Matrix Product Sum 1

Imagine a matrix of numbers:
- horizontal: 1 to 17
- vertical: 1 to 17

For each combination:
- if horizontal is odd and vertical is even, print the product
- if horizontal is even and vertical is odd, print the sum
- if both horizontal and vertical are odd or even, print the difference (abs)


## Expected
```
1, 1 => (difference) 0
1, 2 => (product) 2
1, 3 => (difference) 2
1, 4 => (product) 4
1, 5 => (difference) 4
1, 6 => (product) 6
...
1, 17 => (difference) 16
2, 1 => (sum) 3
2, 2 => (difference) 0
2, 3 => (sum) 5
2, 4 => (difference) 2
2, 5 => (sum) 7
2, 6 => (difference) 4
...
2, 16 => (difference) 14
2, 17 => (sum) 19
3, 1 => (difference) 2
3, 2 => (product) 6
3, 3 => (difference) 0
3, 4 => (product) 12
3, 5 => (difference) 2
3, 6 => (product) 18
...
17, 15 => (difference) 2
17, 16 => (product) 272
17, 17 => (difference) 0

Print: 0, 2, 2, 4, 4, 6, ... 16, 3, 0, 5, 2, 7, 4 ... 14, 19, 2, 6, 0, 12, 2, 18, ..., 2, 272, 0
```

Print them as numbers (or integers)