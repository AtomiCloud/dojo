package fizzbuzz0101

import (
	"fmt"
	"github.com/stretchr/testify/assert"
	"testing"
)

type KeepWriter struct {
	result []interface{}
}

func (k *KeepWriter) Println(a ...interface{}) {
	for _, v := range a {
		k.result = append(k.result, v)
	}
	fmt.Println(a...)
	return
}

func Test_Solution(t *testing.T) {

	fake := new(KeepWriter)
	Solution(fake)
	assert.Equal(t, []interface{}{2, 24, 720, 40320, 3628800, 479001600}, fake.result)

}
