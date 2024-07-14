from remove_duplicates import remove_duplicates

inputs = [
    "g",
    "ggaabcdeb",
    "abbddaccaaabcd",
    "aannkwwwkkkwna",
    "abbabccblkklu"
]

for i, input_str in enumerate(inputs):
    print(f"{i + 1}.\tRemove duplicates from string: \"{input_str}\"")
    resulting_string = remove_duplicates(input_str)
    print(f"\tString after removing duplicates: \"{resulting_string}\"")
    print("-" * 100)
