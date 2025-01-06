import { expect, test } from 'bun:test';
import { Solution } from './solution';

function fakeGen() {
  const result: any[] = [];
  const fake = {
    log: (a: any) => {
      console.log(a);
      result.push(a);
    },
  };
  return [fake, result];
}

test('01 01 FizzBuzz', () => {
  const [fake, result] = fakeGen();
  Solution(fake);
  expect(result).toEqual([
    4, 576, 1295, 7, 8, 6560, 9801, 11, 20735, 13, 14, 449, 16, 17, 104975, 19, 159201, 194480, 22, 23, 331775, 389376,
    26, 531440, 28, 29, 1799, 31, 32, 1185920, 34,
  ]);
});
