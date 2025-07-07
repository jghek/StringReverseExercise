# Coding assignment

Given this string:

```
"Hello developer. Do you like any of these fruits: apple, pear, banana? I do!"
```

## Step 1 – Reverse the order of words

From string A, create string B by **reversing the order of words**.
Punctuation should stay attached to the word.

### Example:

```
Input A:  "Hello developer. Do you like any of these fruits: apple, pear, banana? I do!"
Output B: "do! I banana? pear, apple, fruits: these of any like you Do developer. Hello"
```

## Step 2 – Reverse characters in each word (Keep original word order)

Create a string from string A by **reversing the characters in each word**, keeping the word order intact.

### Example:

```
Input A:  "Hello developer. Do you like any of these fruits: apple, pear, banana? I do!"
Output C: "olleH .repoleved oD uoy ekil yna fo eseht :stiurf ,elppa ,raep ?ananab I !od"
```

## Step 3 – Apply text transformations on step 2

Perform the following on the result of step 2:

1. **Reverse the casing**: uppercase → lowercase, lowercase → uppercase
2. **Capitalize only the first letter of each word**
3. **Capitalize only the first letter of each sentence**
   (Sentences end with `.`, `?`, or `!`)

### Examples:

Input:

```
"olleH .repoleved oD uoy ekil yna fo eseht :stiurf ,elppa ,raep ?ananab I !od"
```

Output:

```
// Reverse casing:
"OLLEh .REPOLEVED Od UOY EKIL YNA FO ESEHT :STIURF ,ELPPA ,RAEP ?ANANAB i !OD"

// Capitalize each word:
"Olleh .repoleved Od Uoy Ekil Yna Fo Eseht :stiurf ,elppa ,raep ?ananab I !od"

// Capitalize first letter of each sentence:
"Olleh .Repoleved od uoy ekil yna fo eseht :stiurf ,elppa ,raep ?Ananab i !Od"
```

