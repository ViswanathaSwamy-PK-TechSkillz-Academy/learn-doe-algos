# File: main.py

from kth_largest import KthLargest


def print_array(arr):
    print("[{}]".format(", ".join(map(str, arr))))


def main():
    nums = [3, 6, 9, 10]
    print("Initial stream: ", end="")
    print_array(nums)
    print("\nk:", 3)
    k_largest = KthLargest(3, nums)
    values_to_add = [4, 7, 10, 8, 15]

    for val in values_to_add:
        print(f"\tAdding a new number {val} to the stream")
        nums.append(val)
        print("\tNumber stream: ", end="")
        print_array(nums)
        print(f"\n\tKth largest element in the stream: {k_largest.add(val)}")
        print("-" * 100)


if __name__ == "__main__":
    main()
