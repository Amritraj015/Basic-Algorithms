function BinarySearch(arr, search){
	let start = 0;
	let end = arr.length - 1;
	let mid;

	while(start <= end){
		mid = Math.floor((end + start)/2);
		if(arr[mid] > search)
			end = mid - 1;
		else if(arr[mid] < search)
			start = mid + 1;
		else{
			console.log("Element found at index " + mid);
			break;
		}
	}

	if(arr[mid] !== search){
		console.log("Element does not exist in the given array");
	}
}


let arr = [1,2,3,4,5,6,7,8,9,10];
let search = 7;

BinarySearch(arr, search);
