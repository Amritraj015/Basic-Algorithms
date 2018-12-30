function BucketSort(arr) {
  let bucketArray = new Array(arr.length).fill([]);

  for (let i = 0; i < arr.length; i++) {
    bucketArray[Hash(arr[i])].push(arr[i]);
  }

  //   for (let bucket of bucketArray) bucket.sort();

  //   let j = 0;
  //   for (let i = 0; i < bucketArray.length; i++) {
  //     for (let bucket of bucketArray) {
  //       arr[j++] = bucket;
  //     }
  //   }
  return bucketArray;
  //return arr;
}

function Hash(value) {
  return Math.floor(value / 10) % 10;
}

let arr = [41, 77, 84, 55, 10, 42, 55, 21, 35, 99];
console.log(BucketSort(arr));
