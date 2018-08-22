function merge(arr1, arr2){
    var arr = [];
    while(arr1.length!==0 && arr2.length!==0){
        if(arr1[0] < arr2[0]){
            arr.push(arr1.shift());
        } else{
            arr.push(arr2.shift());
        }
        console.log(arr, 'inside while loop');
    }

    if(arr1.length==0){
        arr = arr.concat(arr2);
    } 
    if(arr2.length==0){
        arr = arr.concat(arr1);
    }
    return arr;
}


function mergeSort(arr, start=0, end=arr.length-1){
    if(start==end){
        return [arr[end]];
    }
    var mid = Math.floor((start+end)/2);
    return merge(mergeSort(arr, start, mid), mergeSort(arr, mid+1, end));
}



console.log(mergeSort([64, 1, 77, 3, 56, -9]));