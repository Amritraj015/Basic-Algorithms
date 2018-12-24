//  The RdixSort() function calls the RadixAtomicSort() function
//  to perform digit-wise sorting.
function RadixSort(arr, sizeOfData, radix) {
  for (let position = 0; position < sizeOfData; position++) {
    arr = RadixAtomicSort(arr, position, radix);
  }
  return arr;
}

//  The RadixAtomicSort() function sorts the dataset based on individual digits
//  <from the least significant digit -> most significant digit>.
//  ***This function uses a stable version of Counting Sort***
function RadixAtomicSort(arr, position, radix) {
  let tempArray = Array(arr.length).fill(0);
  let countArray = Array(radix).fill(0);

  //    Initializes the countArray based on the number of digits.
  for (let data of arr) countArray[getDigit(position, data, radix)]++;

  //    Adjusts the countArray by adding count from previous array cell
  for (let i = 1; i < radix; i++) countArray[i] += countArray[i - 1];

  //    Stable sorts the digits
  //    (i.e. preserving the previous position of the same digits from unsorted array)
  //    ***Stable sorting is critical to Radix Sort***
  for (let tempIndex = arr.length - 1; tempIndex >= 0; tempIndex--)
    tempArray[--countArray[getDigit(position, arr[tempIndex], radix)]] =
      arr[tempIndex];

  arr = [...tempArray];
  return arr;
}

function getDigit(posiiton, data, radix) {
  return Math.floor(data / radix ** posiiton) % radix;
}

let arr = [1257, 5781, 6248, 9812, 4577, 8875, 2135, 6211, 6210, 3544, 6211];
console.log(RadixSort(arr, 4, 10));
