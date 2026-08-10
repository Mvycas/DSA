# Longest Substring Without Repeating Characters

## Problem

Given a string `s`, return the length of the longest **contiguous substring** with no repeated characters.

### Example

```python
s = "abcabcbb"

# Longest unique substring: "abc"
# Result: 3
```

## Pattern

**Variable-size Sliding Window**

- `right` expands the window.
- `seen` stores characters currently inside the window.
- If `s[right]` is already in `seen`, move `left` forward until the duplicate is removed.
- Track the largest valid window.

```python
def longest_substring_without_repeating(s: str):
    seen = set()
    left, best = 0, 0

    for right in range(len(s)):
        while s[right] in seen:
            seen.remove(s[left])
            left += 1

        seen.add(s[right])

        best = max(best, right - left + 1)

    return best
```

## Example Walkthrough

```text
s = "abca"

[a] b c a      best = 1
[a b] c a      best = 2
[a b c] a      best = 3

duplicate "a" found

a [b c a]      best = 3
```

## Mental Model

```text
Expand RIGHT
↓
Duplicate?
    No  → add character
    Yes → shrink LEFT until valid
↓
Update best
```

Current window length:

```text
right - left + 1
```


## Complexity

- Time: **O(n)**
- Space: **O(n)**
