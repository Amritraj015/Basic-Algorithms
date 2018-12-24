function PivotIndex(arr, start, end) {
  let pivot = arr[start];

  while (start < end) {
    while (start < end && arr[--end] >= pivot);
    if (start < end) arr[start] = arr[end];

    while (start < end && arr[++start] <= pivot);
    if (start < end) arr[end] = arr[start];
  }

  arr[end] = pivot;
  return end;
}

function QuickSort(arr, start, end) {
  if (end - start <= 1) return arr;

  let pivotIndex = PivotIndex(arr, start, end);
  QuickSort(arr, start, pivotIndex);
  QuickSort(arr, pivotIndex + 1, end);

  return arr;
}

let arr = [10, 1, 9, 2, 8, 3, 7, 4, 6, 5];
console.log(QuickSort(arr, 0, arr.length));
