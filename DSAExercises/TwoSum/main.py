from HashMap import two_sum_hash_map
from SlidingWindow import two_sum_sliding_window


def main():
    numbers = [2, 7, 11, 15]
    target = 13

    hash_map_result = two_sum_hash_map(numbers, target)
    two_pointers_result = two_sum_sliding_window(numbers, target)

    print("Hash Map:", hash_map_result)
    print("Two Pointers:", two_pointers_result)


if __name__ == "__main__":
    main()