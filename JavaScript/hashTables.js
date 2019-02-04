function HashTable(){
    this.arr = Array(5).fill(null);
    this.length = 0;
    return this;
}

HashTable.prototype.hash = function(key){
    var hash = 0;
    if (key.length == 0) return hash;
    for (i = 0; i < key.length; i++) {
        char = key.charCodeAt(i);
        hash = ((hash << 5) - hash) + char;
        hash = hash & hash; // Convert to 32bit integer
    }
    console.log("this is the hasingfunction", hash)
    return hash;
}

HashTable.prototype.Add = function(key, val){  //using load factor
    var idx = this.hash(key) % this.arr.length;
    
    
    if(Math.floor(this.arr.length/2) <= this.length){
        var newArr = Array(Math.floor(this.arr.length*1.5)).fill(null);
        // this.arr = this.arr.concat(newArr);
        for(let i = 0; i < this.arr.length; i++){
            if(this.arr[i]!== null){
                var idx = this.arr[i].key % this.arr.length;
                newArr[idx] = this.arr[i];
            }
        }
        this.arr = newArr;
    }

    if(this.arr[idx] == null){
        this.arr[idx] = { key: idx, val: val};
        this.length++;
    } else {
        while(this.arr[idx] !== null ){
            idx++;
        }

        this.arr[idx] = {key: idx, val: val};
        this.length++;
    }

    return this;
}

function Node(key, val){
    this.key = key;
    this.val = val;
    this.next = null;
}

HashTable.prototype.chaining = function(key, val){
    var idx = this.hash(key) % this.arr.length;
    if(this.arr[idx] == null){
        this.arr[idx] = new Node(key, val);
    } else {
        var newNode = new Node(key, val);
        newNode.next = this.arr[idx];
        this.arr[idx] = newNode;
    }
    return this;
}

// var hastable = new HashTable();
// console.log(hastable.chaining('same', 'Alex'));
// console.log(hastable.chaining('fs', 'q'));
// console.log(hastable.chaining('smy', 'e'));
// console.log(hastable.chaining('as', 'f'));
// console.log(hastable.chaining('re', 'x'));
// console.log(hastable.chaining('x', 'v'));
// console.log(hastable.chaining('same', 'Bob'));
// console.log(hastable.chaining('fa', 'aaa'));
// console.log(hastable.chaining('er', '11'));

