# Binary Search

## Problem

Given a **sorted** list of integers and a target value, return the index of the target.

If the target does not exist, return `-1`.

### Examples

```python
binary_search([1, 3, 5, 7, 9], 7)  # 3
binary_search([1, 3, 5, 7, 9], 4)  # -1
binary_search([], 10)               # -1
```

## Pattern

**Binary Search**

Instead of checking every element, repeatedly inspect the middle element and discard half of the remaining search space.

```text
[2, 4, 6, 8, 10, 12, 14]
          ↑
        middle
```

If the target is greater than the middle value, search the right half.

If the target is smaller than the middle value, search the left half.

## Iterative Solution

```python
def binary_search(numbers: list[int], target: int) -> int:
    left, right = 0, len(numbers) - 1

    while left <= right:
        middle = (left + right) // 2

        if numbers[middle] == target:
            return middle

        if numbers[middle] > target:
            right = middle - 1
        else:
            left = middle + 1

    return -1
```

## How It Works

Start with the full searchable range:

```python
left = 0
right = len(numbers) - 1
```

Find the middle index:

```python
middle = (left + right) // 2
```

Remember:

```text
middle          = index
numbers[middle] = value
```

### Target Found

```python
if numbers[middle] == target:
    return middle
```

### Middle Value Is Too Large

```python
if numbers[middle] > target:
    right = middle - 1
```

The target must be somewhere to the left.

### Middle Value Is Too Small

```python
else:
    left = middle + 1
```

The target must be somewhere to the right.

### Target Does Not Exist

Eventually:

```text
left > right
```

There are no elements left to search, so return:

```python
return -1
```

## Example Walkthrough

```text
numbers = [2, 4, 6, 8, 10, 12, 14]
target = 12

left = 0
right = 6
middle = 3
numbers[3] = 8

8 < 12
→ left = middle + 1
→ left = 4

remaining search range:
[10, 12, 14]

middle = 5
numbers[5] = 12

target found → return 5
```

## Complexity

- Time: **O(log n)**
- Space: **O(1)**

Each iteration removes about half of the remaining search space, and the iterative version uses only a few variables regardless of input size.
