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
  expect(result).toEqual([2, 24, 720, 40320, 3628800, 479001600]);
});
