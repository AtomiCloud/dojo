# Jumping Matrix Sum

Imagine a matrix of numbers:
- horizontal: 1 to 20
- vertical: 1 to 20

Print each horizontal number that is a odd number multiplied by each
vertical number that is divisible by 3.

## Expected

```
1 * 3 = 3
1 * 6 = 6
1 * 9 = 9
1 * 12 = 12
1 * 15 = 15
1 * 18 = 18
3 * 3 = 9
3 * 6 = 18
3 * 9 = 27
3 * 12 = 36
3 * 15 = 45
...
17 * 12 = 204
17 * 15 = 255
17 * 18 = 306
19 * 3 = 57
19 * 6 = 114
19 * 9 = 171
19 * 12 = 228
19 * 15 = 285
19 * 18 = 342


Print: 3, 6, 9, 12, 15, 18, 9, 18, 27, 36, 45, ... 204, 255, 306, 57, 114, 171, 228, 285, 342
```

Print them as numbers (or integers)
