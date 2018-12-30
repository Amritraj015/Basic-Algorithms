function BinarySearchRecursion(arr, search, start, end){
	mid = Math.floor((start + end) / 2);
	if (start > end)
		console.log("Element does not exist in the given array");
	else if(arr[mid] < search)
		BinarySearchRecursion(arr, search, mid + 1, end);
	else if(arr[mid] > search)
		BinarySearchRecursion(arr, search, start, mid - 1);
	else if(arr[mid] === search)
		console.log("Element found at index " + mid);
}

let arr = [1,2,3,4,5,6,7,8,9,10];
let search = 9;
let start = 0;
let end = arr.length - 1;
BinarySearchRecursion(arr, search, start, end);