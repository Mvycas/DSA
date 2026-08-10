from valid_parentheses import is_valid_parentheses


def main():
    assert is_valid_parentheses("()") is True
    assert is_valid_parentheses("()[]{}") is True
    assert is_valid_parentheses("(]") is False
    assert is_valid_parentheses("([{}])") is True
    assert is_valid_parentheses("([)]") is False
    assert is_valid_parentheses("") is True
    assert is_valid_parentheses("(") is False
    assert is_valid_parentheses("]") is False

    print("All tests passed!")


if __name__ == "__main__":
    main()