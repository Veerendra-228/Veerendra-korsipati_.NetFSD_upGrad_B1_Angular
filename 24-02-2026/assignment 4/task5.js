let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];
console.log("===== Assignment 5 =====");
let uniqueNumbers = [...new Set(numbers)];
console.log("Unique Numbers:", uniqueNumbers);
let secondLargest = [...new Set(numbers)]
  .sort((a, b) => b - a)[1];

console.log("Second Largest:", secondLargest);
let frequency = numbers.reduce((acc, num) => {
  acc[num] = (acc[num] || 0) + 1;
  return acc;
}, {});

console.log("Frequency:", frequency);
let firstNonRepeating = numbers.find(num => frequency[num] === 1);
console.log("First Non-Repeating:", firstNonRepeating);
let rotateBy = 2;
let rotatedArray = [
  ...numbers.slice(rotateBy),
  ...numbers.slice(0, rotateBy)
];
console.log("Rotated Array (by 2):", rotatedArray);
let nestedArray = [1, 2, [3, 4, [5]]];
let flattenedArray = nestedArray.flat(Infinity);

console.log("Flattened Array:", flattenedArray);
let arr = [1, 2, 3, 5, 6];

let missingNumber = [];
let max = Math.max(...arr);

for (let i = 1; i <= max; i++) {
  if (!arr.includes(i)) {
    missingNumber.push(i);
  }
}

console.log("Missing Number(s):", missingNumber);