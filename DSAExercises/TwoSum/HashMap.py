def two_sum_hash_map(numbers: list[int], target: int):
    seen = {}

    for i, number in enumerate(numbers):

        needed = target - number

        if needed in seen:

            return [seen[needed], i]
        
        seen[number] = i
    return None