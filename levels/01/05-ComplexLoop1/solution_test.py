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
        expected = [125, 12, 343, 16, 729, 20, 24, 2197, 28, 3375, 32, 4913, 36, 6859, 40, 9261, 12167, 48, 15625, 52, 19683, 56, 24389, 30, 31, 32, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 45, 46, 47, 48, 49, 50, 132651, 104, 148877, 108, 112, 185193, 116, 205379, 120, 226981, 124, 250047, 128, 274625, 300763, 136, 328509, 69, 357911, 71, 389017, 73, 421875, 75, 77, 493039, 79, 531441, 81, 571787, 83, 614125, 85, 658503, 704969, 89, 753571, 91, 804357, 93, 857375, 95, 912673, 97, 99, 1030301, 101, 1092727, 103, 1157625, 105, 1225043, 107, 1295029, 1367631, 111, 1442897, 113, 1520875, 115, 1601613, 117, 1685159, 119]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()