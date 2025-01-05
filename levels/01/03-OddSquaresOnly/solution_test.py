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
        expected = [27,125,343,729,1331,2197,3375,4913,6859,9261,12167,15625]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()