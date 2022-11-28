# CS313-PDA-Programming
## About the Program 💻
This program lets you choose two algorithms in the console to solve if the input is accepted or not (1/2)
``` bash
Programs:
1 - Palindrome
2 - Balancing Parentheses

Answer:
``` 
- If you input `1` in the console, it will ask for an input string and solves it if the string is accepted as a palindrome or not
``` bash
PALINDROME

Input: ababa

Process:
Pushed: a
Pushed: b
Read and Skipped: a
Popped: b
Popped: a

Input is a palindrome, therefore it is Accepted!
``` 

- If you input `2` in the console, it will ask for an input (`'('`, `')'`, `'{'`, `'}'`, `'['`, `']'`) and sovles it if the string is balanced or not

``` bash
BALANCING PARENTHESES

Input: [()]{()}

Pushed: [
Pushed: (
Popped: )
Popped: ]
Pushed: {
Pushed: (
Popped: )
Popped: }

Input is Balanced, therefore it is Accepted!
```
