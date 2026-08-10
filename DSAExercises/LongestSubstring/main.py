from longest_substring import longest_substring_without_repeating


def main():
    assert longest_substring_without_repeating("abcabcbb") == 3
    assert longest_substring_without_repeating("bbbbb") == 1
    assert longest_substring_without_repeating("pwwkew") == 3
    assert longest_substring_without_repeating("") == 0
    assert longest_substring_without_repeating("a") == 1
    assert longest_substring_without_repeating("abcdef") == 6
    assert longest_substring_without_repeating("abba") == 2
    assert longest_substring_without_repeating("dvdf") == 3

    print("All tests passed!")


if __name__ == "__main__":
    main()