from hash_map import two_sum_hash_map
from two_pointers import two_sum_two_pointers


def main():
    assert two_sum_hash_map([2, 7, 11, 15], 9) == [0, 1]
    assert two_sum_two_pointers([2, 7, 11, 15], 9) == [0, 1]

    assert two_sum_hash_map([3, 3], 6) == [0, 1]
    assert two_sum_two_pointers([3, 3], 6) == [0, 1]

    print("All tests passed!")


if __name__ == "__main__":
    main()