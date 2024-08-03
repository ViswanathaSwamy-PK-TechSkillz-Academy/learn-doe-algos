def extra_character_index(str1: str, str2: str) -> int:
    result = 0

    for char in str1:
        result ^= ord(char)

    for char in str2:
        result ^= ord(char)

    if len(str1) > len(str2):
        return str1.index(chr(result))
    else:
        return str2.index(chr(result))
