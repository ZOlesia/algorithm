function insertionSort(arr){
    for(var i = 0; i< arr.length; i++){
        let idx = i+1;
        while(idx > 0){
            if(arr[idx] < arr[idx-1]){
                let temp = arr[idx];
                arr[idx]=arr[idx-1];
                arr[idx-1]=temp;
            }
            idx--;
        }
    }
    console.log(arr);
    return arr;
}