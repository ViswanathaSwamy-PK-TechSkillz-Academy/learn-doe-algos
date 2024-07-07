from happy_number_helper import is_happy_number


def main():
    inputs = [1, 5, 19, 25, 7]
    for input_num in inputs:
        print(f"Input Number: {input_num}")
        print(f"Is it a happy number? {is_happy_number(input_num)}")
        print("-" * 50)


if __name__ == "__main__":
    main()
