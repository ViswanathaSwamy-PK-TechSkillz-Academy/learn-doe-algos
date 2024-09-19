// File: tasks.go

package scheduler

import "container/heap"

func ScheduleTasks(T [][]int) int {
	optimalMachines := 0

	machinesAvailable := newHeap()
	tasksList := newHeap()

	tasksList.Heapify(T)
	machineInUse := make([]int, 0)

	for !tasksList.Empty() {
		task := heap.Pop(tasksList).([]int)

		if !machinesAvailable.Empty() && machinesAvailable.Top().([]int)[0] <= task[0] {
			machineInUse = heap.Pop(machinesAvailable).([]int)
			machineInUse = []int{task[1], machineInUse[1]}
		} else {
			optimalMachines++
			machineInUse = []int{task[1], optimalMachines}
		}

		heap.Push(machinesAvailable, machineInUse)
	}

	return optimalMachines
}
