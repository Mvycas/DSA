from max_sum_subarray import max_sum_subarray


def main():
    assert max_sum_subarray([2, 1, 5, 1, 3, 2], 3) == 9
    assert max_sum_subarray([4, 2, 1, 7, 8, 1, 2], 3) == 16
    assert max_sum_subarray([1, 2, 3, 4, 5], 2) == 9
    assert max_sum_subarray([5, 5, 5, 5], 2) == 10
    assert max_sum_subarray([-1, -2, -3, -4], 2) == -3

    print("All tests passed!")


if __name__ == "__main__":
    main()