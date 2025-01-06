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
        expected = ["Prime","Prime","4","Prime","6","Prime","8","9","10","Prime","12","Prime","14","15","16","Prime","18","Prime","20","21","22","Prime","24","25","26","27","28","Prime","30","Prime","32","33","34","35","36","Prime","38","39","40","Prime","42","Prime","44","45","46","Prime","48","49"]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()