function SLL(){
    this.head = null;
}

function Node(val){
    this.val = val;
    this.next = null;
    return this;
}

SLL.prototype.Push = function(val){
    var newNode = new Node(val);
    var temp = this.head;
    if(temp == null){
        this.head = newNode;
        return this;
    } else {
        while(temp.next !== null){
            temp = temp.next;
        }
        temp.next = newNode;
        return this;
    }
}

SLL.prototype.Pop = function(){
    if(this.head == null){
        return this;
    } else{
        this.head = this.head.next;
        return this;
    }
}

var SLL1 = new SLL();
console.log(SLL1.Push(12).Push(45).Push(18).Pop().Pop().Pop());
