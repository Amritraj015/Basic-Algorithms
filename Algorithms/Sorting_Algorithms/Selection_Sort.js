function SelectionSort(arr) {
  for (let i = arr.length - 1; i > 0; i--) {
    let largest = 0;
    for (let j = 1; j <= i; j++) if (arr[largest] <= arr[j]) largest = j;
    let swapper = arr[largest];
    arr[largest] = arr[i];
    arr[i] = swapper;
    console.log(arr);
  }
  return arr;
}

let arr = [10, 1, 9, 2, 8, 3, 7, 4, 6, 5];
console.log(SelectionSort(arr));
