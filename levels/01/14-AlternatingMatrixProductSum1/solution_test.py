from solution import solution
import unittest


def print_gen():
    result = []
    def p(a):
        result.append(a)
        print(a)
    return [p, result]


class TestStringMethods(unittest.TestCase):

    def test_solution(self):
        [fake, result] = print_gen()
        solution(fake)
        expected = [0,2,2,4,4,6,6,8,8,10,10,12,12,14,14,16,16,3,0,5,2,7,4,9,6,11,8,13,10,15,12,17,14,19,2,6,0,12,2,18,4,24,6,30,8,36,10,42,12,48,14,5,2,7,0,9,2,11,4,13,6,15,8,17,10,19,12,21,4,10,2,20,0,30,2,40,4,50,6,60,8,70,10,80,12,7,4,9,2,11,0,13,2,15,4,17,6,19,8,21,10,23,6,14,4,28,2,42,0,56,2,70,4,84,6,98,8,112,10,9,6,11,4,13,2,15,0,17,2,19,4,21,6,23,8,25,8,18,6,36,4,54,2,72,0,90,2,108,4,126,6,144,8,11,8,13,6,15,4,17,2,19,0,21,2,23,4,25,6,27,10,22,8,44,6,66,4,88,2,110,0,132,2,154,4,176,6,13,10,15,8,17,6,19,4,21,2,23,0,25,2,27,4,29,12,26,10,52,8,78,6,104,4,130,2,156,0,182,2,208,4,15,12,17,10,19,8,21,6,23,4,25,2,27,0,29,2,31,14,30,12,60,10,90,8,120,6,150,4,180,2,210,0,240,2,17,14,19,12,21,10,23,8,25,6,27,4,29,2,31,0,33,16,34,14,68,12,102,10,136,8,170,6,204,4,238,2,272,0]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()