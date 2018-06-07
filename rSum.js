function rSum(num){
    if (num == 1){
        return 1;
    }
    return num + rSum(num - 1);
}

