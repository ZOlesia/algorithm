function showFirstAndLast(arr){
    var newArr = [];
    arr.forEach(function(val){
        let newStr1 = val[0];
        let newStr2 = val[val.length - 1];
        newArr.push(newStr1.concat(newStr2));
    });
    return newArr;
}



function addKeyAndValue(arr,key,value){
    arr.forEach(function(v){
        v[key] = value;
    });
    return arr;
}


function vowelCount(str){
   var splitArr = str.toLowerCase().split("");
   var dict = {};
   var vowels = "aeiou";
   splitArr.forEach(function(letter){
        if(vowels.indexOf(letter) !== -1){
            if(letter in dict) dict[letter] ++;
            else dict[letter] = 1;
        }
   });
   return dict;
}

