function BinarySearch(val, arr){
    var start = 0;
    var end = arr.length - 1;
    while (start <= end){
        var p = Math.floor((start+end)/2);
        if(val == arr[p]){
            return p;
        }
        else if(val > arr[p]){
            start = p+1;
        } 
        else{
            end = p-1;
        }
    }
    return false;
}

function RBS(val, arr, start = 0, end = arr.length-1){
    var p = Math.floor((start+end)/2);
    if(start > end){
        return -1;
    }
    if(arr[p] == val){
        return p;
    }

    else if(val > arr[p]){
        // console.log(val,arr, p+1,end,p + "first if check");
        return RBS(val, arr, p+1, end);
    } else if(val < arr[p]){
        // console.log(val, arr, start, p-1, p + "seconds if");
        return RBS(val, arr, start, p-1);
    } 
    
    return -1;
}

console.log(RBS(8, [8, 9, 10, 11, 12]));
console.log(BinarySearch(1, [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]));