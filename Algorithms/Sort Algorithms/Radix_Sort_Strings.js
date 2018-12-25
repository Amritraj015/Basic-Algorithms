function RadixSortStrings(strArray, sizeOfData, radix) {
  for (let position = sizeOfData - 1; position >= 0; position--)
    strArray = RadixAtomicSort(strArray, position, radix);

  return strArray;
}

function RadixAtomicSort(strArray, position, radix) {
  let tempArray = Array(strArray.length).fill("");
  let countArray = Array(radix).fill(0);

  for (let data of strArray)
    countArray[getCharCode(data, position, radix) - 97]++;

  for (let i = 1; i < countArray.length; i++)
    countArray[i] += countArray[i - 1];

  for (let tempIndex = tempArray.length - 1; tempIndex >= 0; tempIndex--)
    tempArray[--countArray[getCharCode(strArray[tempIndex], position) - 97]] =
      strArray[tempIndex];

  strArray = [...tempArray];
  return strArray;
}

function getCharCode(data, position) {
  return data.charCodeAt(position);
}

let strArray = ["bcdef", "aaaaa", "zzzzz", "dbaqc", "abcde", "omadd", "bbbbb"];
console.log(RadixSortStrings(strArray, 5, 26));
