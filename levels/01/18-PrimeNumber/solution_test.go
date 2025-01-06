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
	assert.Equal(t, []interface{}{"Prime","Prime","4","Prime","6","Prime","8","9","10","Prime","12","Prime","14","15","16","Prime","18","Prime","20","21","22","Prime","24","25","26","27","28","Prime","30","Prime","32","33","34","35","36","Prime","38","39","40","Prime","42","Prime","44","45","46","Prime","48","49"}, fake.result)

}
