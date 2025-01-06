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
    'Prime',
    'Prime',
    '4',
    'Prime',
    '6',
    'Prime',
    '8',
    '9',
    '10',
    'Prime',
    '12',
    'Prime',
    '14',
    '15',
    '16',
    'Prime',
    '18',
    'Prime',
    '20',
    '21',
    '22',
    'Prime',
    '24',
    '25',
    '26',
    '27',
    '28',
    'Prime',
    '30',
    'Prime',
    '32',
    '33',
    '34',
    '35',
    '36',
    'Prime',
    '38',
    '39',
    '40',
    'Prime',
    '42',
    'Prime',
    '44',
    '45',
    '46',
    'Prime',
    '48',
    '49',
  ]);
});
