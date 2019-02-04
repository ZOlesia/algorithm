function Heap(){
    this.arr = [0];
}

Heap.prototype.Add = function(val){
    var idx = this.arr.length;
    var parent = Math.floor(idx/2);
    if(this.arr.length == 1){
        this.arr.push(val);
        return this.arr;
    }
    this.arr.push(val);
    while(this.arr[parent] > val  && parent !== 0){
        var temp = this.arr[parent];
        this.arr[parent] = this.arr[idx];
        this.arr[idx] = temp;
        idx = parent;
        parent = Math.floor(idx/2);
    }
    return this.arr;
}


Heap.prototype.RAdd = function(val, idx = this.arr.length, p = Math.floor(idx/2), x = false){
    if(x == false){
        this.arr.push(val);
        x = true;
    }
    if(p < 1){
        return p;
    }
    if(this.arr[p] > val){
        var temp = this.arr[p];
        this.arr[p] = this.arr[idx];
        this.arr[idx] = temp;
        return this.RAdd(val, p, p, true);
    }
    return this.arr;
}

Heap.prototype.Remove = function(val){
    var idx = 0;
    if (this.arr[this.arr.length - 1] == val) {
        this.arr.pop();
        return this.arr;
    }

    for(var i = 0; i < this.arr.length; i++){
        if(this.arr[i] == val){
            idx = i;
            break;
        }
    }

    if(idx == null){
        return false;
    }

    var temp = this.arr[idx];
    this.arr[idx] = this.arr[this.arr.length-1];
    this.arr[this.arr.length-1] = temp; 
    this.arr.pop();
    var child = idx*2;
    var child2 = (idx*2) +1;
    var path = this.arr[child] < this.arr[child2] ? child : child2;

        while(idx<this.arr.length && this.arr[path] <  this.arr[idx]){
            let temp = this.arr[path];
            this.arr[path] = this.arr[idx];
            this.arr[idx] = temp;
            idx = path;
            child = child*2;
            child2 = child + 1;
            if (this.arr[child2] == null) {
                path = child;
            } else {
                path = this.arr[child] < this.arr[child2] ? child : child2;
            }
        }


    var parent = Math.floor(idx/2);

    if(this.arr[idx] < this.arr[parent]){

        while (idx > 0 && this.arr[idx] > this.arr[parent]) {
            let temp = this.arr[parent]
            this.arr[parent] = this.arr[idx];
            this.arr[idx] = temp;
            idx = parent;
            parent = Math.floor(idx / 2);
        }
    }
    return this.arr;
}

var Heap1 = new Heap();
console.log(Heap1.RAdd(15));
console.log(Heap1.RAdd(20));
console.log(Heap1.RAdd(-3));
console.log(Heap1.RAdd(1));
console.log(Heap1.RAdd(3));
console.log(Heap1.RAdd(7));
console.log(Heap1.Remove(15));









