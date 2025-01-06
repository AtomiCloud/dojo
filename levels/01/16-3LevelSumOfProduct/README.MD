# 3 Level Sum of Product


Have 3 internal loops:
- top level: 2 to 27
    - middle level: 6 to 34
        - bottom level: 3 to 10

For each combination, multiply all the values, as long as the middle level is odd and the top level is even.
Sum all the multiplications.

## Expected
```
2 * 7 * 3 = 42
2 * 7 * 4 = 56
2 * 7 * 5 = 70
2 * 7 * 6 = 84
2 * 7 * 7 = 98
2 * 7 * 8 = 112
2 * 7 * 9 = 126
2 * 7 * 10 = 140
2 * 9 * 3 = 54
2 * 9 * 4 = 72
...
2 * 9 * 9 = 162
2 * 9 * 10 = 180
2 * 11 * 3 = 66
2 * 11 * 4 = 88
...
2 * 33 * 3 = 198
2 * 33 * 4 = 264
2 * 33 * 5 = 330
2 * 33 * 6 = 396
...
2 * 33 * 10 = 660
4 * 7 * 3 = 84
4 * 7 * 4 = 112
4 * 7 * 5 = 140
4 * 7 * 6 = 168
4 * 7 * 7 = 196
4 * 7 * 8 = 224
4 * 7 * 9 = 252
4 * 7 * 10 = 280
...
26 * 33 * 3 = 2574
26 * 33 * 4 = 3432
26 * 33 * 5 = 4290
26 * 33 * 6 = 5148
...
26 * 33 * 9 = 7722
26 * 33 * 10 = 8580

Sum = 42 + 56 + 70 + 84 + 98 + 112 + 126 + 140 + 54 + 72 + ... + 162 + 180 + 66 + 88 + ... + 198 + 264 + 330 + 396 + ... + 660 + 84 + 112 + 140 + 168 + 196 + 224 + 252 + 280 + ... + 2574 + 3432 + 4290 + 5148 + ... + 7722 + 8580 = 2649920


Print: 2649920 <== Print this only
```

Print it as a number (or integer)
