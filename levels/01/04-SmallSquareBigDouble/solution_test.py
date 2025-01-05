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
        expected = [49,64,81,100,121,144,169,196,225,256,289,324,361,40,42,44,46,48,50,52,54,56,58,60,62,64,66,68,70]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()