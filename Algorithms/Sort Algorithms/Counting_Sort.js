function CountinSort(arr, min, max) {
  let countArray = new Array(max - min + 1).fill(0);

  for (let i = 0; i < arr.length; i++) {
    countArray[arr[i] - min]++;
  }

  let j = 0;
  for (let i = min; i <= max; i++) {
    while (countArray[i - min] > 0) {
      arr[j++] = i;
      countArray[i - min]--;
    }
  }
  return arr;
}

let arr = [10, 1, 1, 2, 5, 3, 5, 4, 6, 5];
console.log(CountinSort(arr, 1, 10));
