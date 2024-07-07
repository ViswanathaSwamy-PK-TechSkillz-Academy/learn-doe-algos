package main

type Hashmap struct {
	hashmap map[string]int
}

func (this *Hashmap) Insert(x string) {
	if _, ok := this.hashmap[x]; ok {
		this.hashmap[x] += 1
	} else {
		this.hashmap[x] = 1
	}
}
