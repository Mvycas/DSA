def two_sum_sliding_window(numbers: list[int], target: int):

    left, right = 0, len(numbers) - 1

    while left < right:

        sum = numbers[left] + numbers[right]

        if sum == target:
            return [left, right]

        if sum < target:
            left += 1

        if sum > target:
            right -= 1
    return None