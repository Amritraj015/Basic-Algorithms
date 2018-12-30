function LinearSearch(arr, search) {
  let indexArray = [];
  for (let i = 0; i < arr.length; i++)
    if (arr[i] === search) indexArray.push(i);
  return indexArray;
}

let arr = [54, 98, 65, 6, 654, 6, 5, 4, 54, 6, 5, 87];
let search = 6;
let indexArray = LinearSearch(arr, search);

if (indexArray.length === 0) {
  console.log("Element not found within the array");
} else {
  console.log("Element found at:");
  for (let i of indexArray) console.log("index: " + i);
}
