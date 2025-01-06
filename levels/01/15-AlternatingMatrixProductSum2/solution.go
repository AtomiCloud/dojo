package fizzbuzz0101

type Writer interface {
	Println(a ...interface{})
}

// Solution Starts here
func Solution(fmt Writer) {
	fmt.Println("Hello World")
}
