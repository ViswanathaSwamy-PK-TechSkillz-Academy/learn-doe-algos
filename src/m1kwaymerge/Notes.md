# K-way Merge

Let's break down the code into multiple files to improve organization and readability. We'll create separate files for the main function, the merge function, and any utility functions or constants if needed. Here's how you can structure it:

## Merge Sorted Array

### File: `main.go`

This file contains the `main` function and calls the `mergeSorted` function.

```go
package main

import (
    "fmt"
    "strings"
)

func main() {
    m := []int {9, 2, 3, 1, 8}
    n := []int {6, 1, 4, 2, 1}
    nums1 := [][]int {
        {23, 33, 35, 41, 44, 47, 56, 91, 105, 0, 0, 0, 0, 0, 0},
        {1, 2, 0},
        {1, 1, 1, 0, 0, 0, 0},
        {6, 0, 0},
        {12, 34, 45, 56, 67, 78, 89, 99, 0},
    }
    nums2 := [][]int {
        {32, 49, 50, 51, 61, 99},
        {7},
        {1, 2, 3, 4},
        {-99, -45},
        {100},
    }

    for index, value := range m {
        fmt.Printf("%d.\tnums1: %s, m: %d\n", index + 1, strings.Replace(fmt.Sprint(nums1[index]), " ", ", ", -1), value)
        fmt.Printf("\tnums2: %s, n: %d\n", strings.Replace(fmt.Sprint(nums2[index]), " ", ", ", -1), n[index])
        result := mergeSorted(nums1[index], value, nums2[index], n[index])
        fmt.Printf("\tMerged list: %s\n", strings.Replace(fmt.Sprint(result), " ", ", ", -1))
        fmt.Printf("%s\n", strings.Repeat("-", 100))
    }
}
```

### File: `merge.go`

This file contains the `mergeSorted` function.

```go
package main

func mergeSorted(nums1 []int, m int, nums2 []int, n int) []int {
    p1 := m - 1
    p2 := n - 1
    arr := []int{p1, p2}

    for p := (n + m - 1); p >= 0; p-- {
        arr1 := []int{p1, p}
        if p2 < 0 {
            break
        }

        if p1 >= 0 && nums1[p1] > nums2[p2] {
            nums1[p] = nums1[p1]
            p1 -= 1
            arr[0] = p1
            arr1[0] = p1
        } else {
            nums1[p] = nums2[p2]
            p2 -= 1
            arr[1] = p2
        }
    }
    return nums1
}
```

### File: `utils.go`

This file can be used for any utility functions or constants. If there are no utility functions required at this point, you can leave this file empty or omit it.

For now, it is empty, but if needed, you can add helper functions here.

```go
package main

// Add any utility functions here
```

### Directory Structure

Your project directory should look like this:

```
project-directory/
│
├── main.go
├── merge.go
└── utils.go
```

### Building and Running the Program

To build and run the program, navigate to the project directory and use the following commands:

```sh
go build -o merge_program
./merge_program
```

Or, you can directly run the program using:

```sh
go run main.go merge.go utils.go
```

This structure will help keep your code organized and maintainable. If you have any specific enhancements in mind, please let me know, and I can help you incorporate those into the code.
