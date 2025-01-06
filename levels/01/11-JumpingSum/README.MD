# Jumping Sum

From 1 to 100, print the sum of the 1st, 2nd, 4th, 7th, 11th, 16th, ... numbers.

## Visualization

```
01  02  03  04  05  06  07  08  09  10  11  12  13  14  15  16  17  18
^   ^       ^           ^               ^                   ^
|   |       |           |               |                   |
|   |       |           |               |                   |
- 1 -       |           |               |                   |
    |       |           |               |                   |
    |-- 2 --|           |               |                   |
            |           |               |                   |
            |---- 3 ----|               |                   |
                        |               |                   |
                        |------ 4 ------|                   |
                                        |                   |
                                        |-------- 5 --------|
```

## Expected

```
1 + 2 + 4 + 7 + 11 + 16 + .... 79 + 92 =  469
469 <== Print this only
```

Print the final answer as a number (or integer)
