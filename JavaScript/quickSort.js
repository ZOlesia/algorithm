function quickSort(arr){
    if(arr.length<=1){
        return arr;
    }

    var left=[];
    var right=[];
    var piv=arr[0];
    for(var i = 1; i < arr.length; i++){
        if(arr[i]>piv){
            right.push(arr[i]);
        } else {
            left.push(arr[i]);
        }
    }
    
        console.log(left);
        console.log(right);
    return quickSort(left).concat(piv).concat(quickSort(right));
}

console.log(quickSort([5, 0, 89, 3, 100, 1])); 