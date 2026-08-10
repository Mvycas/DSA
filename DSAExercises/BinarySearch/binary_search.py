def binary_search(numbers: list[int], target: int) -> int:
    left, right = 0, len(numbers) - 1

    while left <= right:

        middle = (left + right) // 2

        if numbers[middle] == target:
            return middle

        if numbers[middle] > target:
            right = middle - 1

        if numbers[middle] < target:
            left = middle + 1

    return -1

