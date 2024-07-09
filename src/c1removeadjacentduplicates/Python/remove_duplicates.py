def remove_duplicates(s: str) -> str:
    stack = []

    for char in s:
        if stack and stack[-1] == char:
            stack.pop()  # pop the last element
        else:
            stack.append(char)  # push the current character

    return ''.join(stack)
