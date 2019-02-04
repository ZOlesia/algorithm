function findSecondMinNumber(arr){
	
	var fmin = 0;
	var smin = 0;
	
	for(var i=0; i<arr.length; i++){
		if(fmin > arr[i]){
			smin = fmin;
			fmin = arr[i];			
		} else if(smin > arr[i]){
			smin = arr[i];
		}
	}
	return smin;
}

console.log(findSecondMinNumber([15, -2, 1, 0, 20]));