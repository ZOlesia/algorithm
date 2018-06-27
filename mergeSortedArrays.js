function mergeSortedArrays(arr1, arr2){
    var arr = [];
    while(arr1.length !== 0 && arr2.length !==0){
        if(arr1[0] > arr2[0]){
            arr.push(arr2.shift())
        } else {
            arr.push(arr1.shift())
        }
    }

    if(arr1.length == 0){
        arr = arr.concat(arr2);
    } 
    if(arr2.length==0){
        arr = arr.concat(arr1);
    }

    console.log(arr);
}

mergeSortedArrays([1,5,7,12,18,32], [2,4,9,16,27,76,98]);