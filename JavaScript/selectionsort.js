function selectionSort(arr){
    for(var i = 0; i < arr.length-1; i++){
        var min = i;
        for(var j = i; j < arr.length; j++){
            if(arr[j] < arr[min]){
                min = j;
            }
        }
        if(i !== min){
            let temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        } 
    }
    return arr;
}




