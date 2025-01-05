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
        expected = [2, 24, 720, 40320, 3628800, 479001600]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()