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
    49, 64, 81, 100, 121, 144, 169, 196, 225, 256, 289, 324, 361, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64,
    66, 68, 70,
  ]);
});
