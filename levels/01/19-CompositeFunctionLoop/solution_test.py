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
        expected = [
                4,576,1295,7,8,6560,9801,11,20735,13,14,449,16,17,104975,19,159201,194480,22,23,331775,389376,26,531440,28,29,1799,31,32,1185920,34
        ]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()