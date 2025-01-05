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
	assert.Equal(t, []interface{}{1,4,9,16,25,36,49,64,81,
		100,121,144,169,196,225,
		256,289,324,361,400,625,
		676,729,784,841,900,961,
		1024,1089,1156,1225,1296,
		1369,1444,1521,1600,1681,
		1764,1849,1936,2025,2116,
		2209,2304,2401,2500}, fake.result)

}
