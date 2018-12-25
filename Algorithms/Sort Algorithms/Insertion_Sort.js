function InsertionSort(arr) {
  for (let i = 1; i < arr.length; i++) {
    let newElement = arr[i];
    let j;
    for (j = i; j > 0 && arr[j - 1] > newElement; j--) arr[j] = arr[j - 1];
    arr[j] = newElement;
  }
  return arr;
}

let arr = [10, 1, 9, 2, 8, 3, 7, 4, 6, 5];
console.log(InsertionSort(arr));
