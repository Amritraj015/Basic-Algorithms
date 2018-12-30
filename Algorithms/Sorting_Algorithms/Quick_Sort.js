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
  arr = QuickSort(arr, start, pivotIndex);
  arr = QuickSort(arr, pivotIndex + 1, end);

  return arr;
}

let arr = [-457, 45, 1, 0, -57, 66, 999, 1507, -7777];
console.log(QuickSort(arr, 0, arr.length));
