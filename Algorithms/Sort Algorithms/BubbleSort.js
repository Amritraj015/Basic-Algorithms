function BubbleSort(arr) {
  for (let i = arr.length; i > 0; i--) {
    for (let j = 0; j < i; j++) {
      if (arr[j] > arr[j + 1]) {
        let swapper = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = swapper;
      }
    }
  }
  return arr;
}

let arr = [10, 9, 8, 7, 6, 5, 4, 3, 2, 1];
console.log(BubbleSort(arr));
