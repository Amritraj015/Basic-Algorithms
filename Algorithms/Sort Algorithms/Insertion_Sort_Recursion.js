function InsertionSortRecursion(arr, position) {
  if (arr.length <= 1 || position === arr.length) return arr;

  let newElement = arr[position];
  arr = helperInsertionSort(arr, position, newElement);
  arr = InsertionSortRecursion(arr, ++position);

  return arr;
}

function helperInsertionSort(arr, position, newElement) {
  if (position < 1) return arr;

  if (arr[position - 1] > newElement) {
    arr[position] = arr[position - 1];
    arr[--position] = newElement;
    arr = helperInsertionSort(arr, position, newElement);
  }

  return arr;
}

let arr = [-457, 45, 1, 0, -57, 66, 999, 1507, -7777, -1234, 0, 8457, 1000, -5];
console.log(InsertionSortRecursion(arr, 1));
