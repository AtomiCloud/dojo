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
        expected = [1438583736240,204]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()