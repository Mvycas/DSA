from binary_search import binary_search


def main():
    assert binary_search([1, 3, 5, 7, 9], 7) == 3
    assert binary_search([1, 3, 5, 7, 9], 1) == 0
    assert binary_search([1, 3, 5, 7, 9], 9) == 4
    assert binary_search([1, 3, 5, 7, 9], 4) == -1
    assert binary_search([], 10) == -1
    assert binary_search([5], 5) == 0
    assert binary_search([5], 8) == -1

    print("All tests passed!")


if __name__ == "__main__":
    main()