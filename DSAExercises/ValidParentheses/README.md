# Valid Parentheses

## Problem

Given a string `s` containing only:

```text
( ) [ ] { }
```

Return `True` if every opening bracket is closed by the correct type of closing bracket and in the correct order.

### Examples

```python
is_valid_parentheses("()")       # True
is_valid_parentheses("()[]{}")   # True
is_valid_parentheses("(]")       # False
is_valid_parentheses("([{}])")   # True
is_valid_parentheses("([)]")     # False
is_valid_parentheses("")         # True
```

## Pattern

**Stack**

A stack follows:

```text
Last In, First Out
```

The most recently opened bracket must be the first one closed.

Example:

```text
([{}])

(   stack = ["("]
[   stack = ["(", "["]
{   stack = ["(", "[", "{"]

}   matches "{" → pop
]   matches "[" → pop
)   matches "(" → pop

stack = []
```

## Pair Mapping

Use a dictionary to map each closing bracket to the opening bracket it expects:

```python
pairs = {
    ")": "(",
    "]": "[",
    "}": "{",
}
```

For example:

```python
pairs["]"]  # "["
```

So when we see `]`, the top of the stack must be `[`.

## Solution

```python
def is_valid_parentheses(s: str) -> bool:
    pairs = {
        ")": "(",
        "]": "[",
        "}": "{",
    }

    stack = []

    for char in s:
        if char in "([{":
            stack.append(char)

        else:
            if not stack:
                return False

            if stack[-1] != pairs[char]:
                return False

            stack.pop()

    return not stack
```

## How It Works

### Opening bracket

```python
if char in "([{":
    stack.append(char)
```

Remember the bracket by pushing it onto the stack.

### Closing bracket with an empty stack

```python
if not stack:
    return False
```

A closing bracket cannot be valid if nothing was opened before it.

Example:

```text
")"
```

The stack is empty when `)` appears, so the answer is `False`.

### Check the top of the stack

```python
if stack[-1] != pairs[char]:
    return False
```

`stack[-1]` is the most recently opened bracket.

`pairs[char]` is the opening bracket required by the current closing bracket.

If they do not match, the string is invalid.

### Remove a matched pair

```python
stack.pop()
```

Once the closing bracket matches the top opening bracket, remove that opening bracket from the stack.

### Final check

```python
return not stack
```

At the end, the stack must be empty.

```text
"()"  → stack = []      → True
"(("  → stack = ["(", "("] → False
""    → stack = []      → True
```

## Complexity

- Time: **O(n)**
- Space: **O(n)**

Each character is processed once. In the worst case, all opening brackets are stored in the stack.
