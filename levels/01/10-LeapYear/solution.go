package fizzbuzz0101

import "strconv"

type Writer interface {
	Println(a ...interface{})
}

// Solution Starts here
func Solution(fmt Writer) {
	fmt.Println("Hello World")
}
