def sum_of_squared_digits(number):
    total_sum = 0
    while number > 0:
        digit = number % 10
        number //= 10
        total_sum += digit * digit
    return total_sum


def is_happy_number(n):
    seen = set()
    while n != 1 and n not in seen:
        seen.add(n)
        n = sum_of_squared_digits(n)
    return n == 1
