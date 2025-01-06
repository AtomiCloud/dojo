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
    3, 6, 9, 12, 15, 18, 9, 18, 27, 36, 45, 54, 15, 30, 45, 60, 75, 90, 21, 42, 63, 84, 105, 126, 27, 54, 81, 108, 135,
    162, 33, 66, 99, 132, 165, 198, 39, 78, 117, 156, 195, 234, 45, 90, 135, 180, 225, 270, 51, 102, 153, 204, 255, 306,
    57, 114, 171, 228, 285, 342,
  ]);
});
