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
        expected = [1,4,9,16,25,36,49,64,81,
    100,121,144,169,196,225,
    256,289,324,361,400,625,
    676,729,784,841,900,961,
    1024,1089,1156,1225,1296,
    1369,1444,1521,1600,1681,
    1764,1849,1936,2025,2116,
    2209,2304,2401,2500]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()