# File: main.py

from missingnumber import find_missing_number


def main():
    input_numbers = [
        [4, 0, 3, 1],
        [8, 3, 5, 2, 4, 6, 0, 1],
        [1, 2, 3, 4, 6, 7, 8, 9, 10, 5],
        [0],
        [1, 2, 3, 0, 4, 5, 6, 7, 8, 9, 10, 11, 12,
            13, 14, 15, 16, 17, 18, 19, 20, 21, 23]
    ]

    for i, nums in enumerate(input_numbers, 1):
        print(f"{i}.\tnums: {', '.join(map(str, nums))}")
        print(f"\n\tMissing number: {find_missing_number(nums)}")
        print("-" * 100)


if __name__ == "__main__":
    main()
