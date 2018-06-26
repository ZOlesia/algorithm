function maxConsecutive(str){
    var dict = {};
    var count = 1;
    var max = 0;
    var maxChar = 0;
    for(var i = 0; i < str.length; i++){
        if(str[i] == str[i+1]){
            count++;
        } else if(dict[str[i]] !== undefined && dict[str[i]] > count){
            count = 1;
        } else {
            dict[str[i]] = count;
            count = 1;
        }
    }
    console.log(dict);


    for(key in dict){
        if(max < dict[key]){
            max = dict[key];
            maxChar = key;
        } 
    }
    console.log(max);
    console.log(maxChar);
}





maxConsecutive("aaaaaaaaaaabbcbbbbbbbbbbbbbbbbbbbbbccbbbbbbaa");