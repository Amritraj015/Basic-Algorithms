function Merge(left, right) {
  let tempArray = [];
  let leftArrayIndex = 0;
  let rightArrayIndex = 0;

  while (leftArrayIndex < left.length && rightArrayIndex < right.length) {
    if (left[leftArrayIndex] <= right[rightArrayIndex])
      tempArray.push(left[leftArrayIndex++]);
    else tempArray.push(right[rightArrayIndex++]);
  }

  return tempArray
    .concat(left.slice(leftArrayIndex))
    .concat(right.slice(rightArrayIndex));
}

function MergeSort(arr) {
  if (arr.length <= 1) return arr;

  let mid = Math.floor(arr.length / 2);
  let left = arr.slice(0, mid);
  let right = arr.slice(mid, arr.length);

  return Merge(MergeSort(left), MergeSort(right));
}

let arr = [10, 1, 9, 2, 8, 3, 7, 4, 6, 5];
console.log(arr);
console.log();
console.log(MergeSort(arr));
