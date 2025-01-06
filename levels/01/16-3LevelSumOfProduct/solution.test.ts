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
  console.log(JSON.stringify(result));
  expect(result).toEqual([2649920]);
});
