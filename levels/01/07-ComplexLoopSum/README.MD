# Complex Loop Sum

Find the sum of 7 to 73, with the following mutation rules:
- if the number is divisible by 5, don't include it in the sum
- if the number is odd and lesser than 30, the value should be squared
- if the number is odd and larger than or equal to 30, the value should be multiplied by 4
- if the number is even, the value should be negated


## Expected

```
49 + -8 + 81 + 121 + -12 ... + 729 - 28 + 841 + 124 - 32 + 132 - 34 .... + 284 -72 + 292
= 
6346 <== FINAL ANSWER, ONLY PRINT THIS
```

Print the final answer as a number (or integer)