function rFib(num){
    if(num == 0){
        return 0;
    }
    if(num == 1 || num == 2){
        return 1;
    }

    // if(num == 1) return 1;
    // if(num == 2) return 2;
    return rFib(num-1) + rFib(num-2) + rFib(num-3);
}


console.log(rFib(5));