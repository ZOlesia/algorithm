
function rFactorial(num){
    if(num == 1){
        return 1;
    }
    return num * rFactorial(num - 1);
}
