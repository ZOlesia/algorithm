// 	Write a small method  to do the below task.. this is not in sorted order.. all negative characters in left and positive on the right..

function negativeOnTheLeftPositiveOnTheRight(arr){
    for(var i = 0; i < arr.length; i++){
        if(arr[i] >= 0){
            let positive = arr.splice(i, 1);
            arr = arr.concat(positive);
        }
    }
    console.log(arr);
}

// negativeOnTheLeftPositiveOnTheRight([ 4, -3, 2, -5, 5, -1, 3, -2]);


function zeroOnTheLeftOneOnTheRight(arr){
    var newArr = [];
    for(var i = 0; i < arr.length; i++){
        if(arr[i] == 0){
            newArr.unshift(arr[i]);
            // arr.splice(i, 1);
        } else{
            newArr.push(arr[i]);
            // arr.splice(i, 1);
        }
    }
    arr = [];
    console.log(arr);
    console.log(newArr);
}


// zeroOnTheLeftOneOnTheRight([0, 1, 0, 1, 0, 0, 1, 1, 1, 0]);
