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
        expected = [3,6,9,12,15,18,9,18,27,36,45,54,15,30,45,60,75,90,21,42,63,84,105,126,27,54,81,108,135,162,33,66,99,132,165,198,39,78,117,156,195,234,45,90,135,180,225,270,51,102,153,204,255,306,57,114,171,228,285,342]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()