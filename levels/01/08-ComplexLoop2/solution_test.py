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
    900, 27000, 961, 1024, 32768, 1089, 1156, 39304, 1225, -35, 1296, 46656, 1369, 105, 1444, 54872, 39, 1600, 64000,
    1681, 1764, 74088, -42, 1849, 1936, 85184, 2025, 2116, 97336, 2209, 135, 2304, 110592, 49, 2500, 125000, 2601, 2704,
    140608, 2809, 2916, 157464, 3025, 3136, 175616, -56, 3249, 165, 3364, 195112, 59, 3600, 216000, 3721, 3844, 238328,
    3969, -63, 4096, 262144, 4225, 4356, 287496, 4489, 195, 4624, 314432, 69, 4900, 343000, -70, 5041, 5184, 373248,
    5329, 5476, 405224, 5625, 5776, 438976, 5929, 225, -77,]
        self.assertEqual(result, expected)


if __name__ == '__main__':
    unittest.main()