# Complex Loop 1

fFom 5 to 120:
- if number is divisible by 11, print nothing
- if number is between (inclusive) 30 - 50, print the number itself
- if the number is odd, print the cube of the number
- if the number is even
  - if the number is smaller than 70, multiply it by 2
  - if the number is larger or equal than 70, simply minus 1 from the number

## Expected

```
125, 12, 343, 16, 729, 20, 24, 2197, 28, 3375, 32, 4913, 36, 6859, 40, 9261, 12167, 48, 15625, 52, 19683, 56, 24389, 30, 31, 32, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 45, 46, 47, 48, 49, 50, 132651, 104, 148877, 108, 112, 185193, 116, 205379, 120, 226981, 124, 250047, 128, 274625, 300763, 136, 328509, 69, 357911, 71, 389017, 73, 421875, 75, 77, 493039, 79, 531441, 81, 571787, 83, 614125, 85, 658503, 704969, 89, 753571, 91, 804357, 93, 857375, 95, 912673, 97, 99, 1030301, 101, 1092727, 103, 1157625, 105, 1225043, 107, 1295029, 1367631, 111, 1442897, 113, 1520875, 115, 1601613, 117, 1685159, 119
```

## Explanation

5 => is odd, so cube, so `125`  
6 => is even, & smaller than 70, so multiply by 2, so is `12`  
7 => is odd, so cube, so is `343`  
8 => is even, & smaller than 70, so multiply by 2, so is `16`  
9 => is odd, so cube, so is `729`  
10 => is even & smaller than 70, so 2x, so is `20`  
11 => is divisible by 11, so ignore  
12 => is even & smaller than 70, so 2x, so is `24`  
....  
28 => is even & smaller than 70, so 2x, so is `56`  
29 => is odd, so cube, so `24389`  
30 => is between 30 and 50 inclusive, so its `30`  
31 =>  is between 30 and 50 inclusive, so its `31`  
32 =>  is between 30 and 50 inclusive, so its `32`  
...  
48 =>  is between 30 and 50 inclusive, so its `48`  
49 =>  is between 30 and 50 inclusive, so its `49`  
50 =>  is between 30 and 50 inclusive, so its `50`  
51 => is odd, so cube, so `132651`  
52 => is even & smaller than 70, so 2x, so `104`  
53 => is odd, so cube, so `148877`  
54 => is even & smaller than 70, so 2x, so `108`  
55 => divisible by 11, so ignore  
56 => is even & smaller than 70, so 2x, so `112`  
...  
68 => is even & smaller than 70, so 2x, is `136`  
69 => is odd, so cube is `328509`  
70 => is even & larger than or eq to 70, so minus 1, so `69`  
71 => is odd, so cube is `357911`  
72 => is even & larger or eq to 70, so minus 1, so `71`  
....  
120 => is even & larger orq eq to 70, so minus 1, so `119`  