function ShellSort(arr) {
  for (let gap = Math.floor(arr.length / 2); gap > 0; gap = Math.floor(gap / 2))
    for (let i = gap; i < arr.length; i++) {
      let newElement = arr[i];
      let j = i;
      while (j > 0 && arr[j - gap] > newElement) {
        arr[j] = arr[j - gap];
        j -= gap;
      }
      arr[j] = newElement;
    }
  return arr;
}

let arr = [10, 1, 9, 2, 8, 3, 7, 4, 6, 5];
console.log(ShellSort(arr));
