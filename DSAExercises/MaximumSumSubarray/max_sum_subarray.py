def max_sum_subarray(numbers, k):
    window_sum = sum(numbers[:k])
    max_sum = window_sum

    for right in range(k, len(numbers)):
        left = right - k

        window_sum -= numbers[left]
        window_sum += numbers[right]
        
        max_sum = max(max_sum, window_sum)
    return max_sum