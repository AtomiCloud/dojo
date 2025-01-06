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
	assert.Equal(t, []interface{}{
		4,576,1295,7,8,6560,9801,11,20735,13,14,449,16,17,104975,19,159201,194480,22,23,331775,389376,26,531440,28,29,1799,31,32,1185920,34,
	}, fake.result)

}
