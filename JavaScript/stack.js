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
    newNode.next = this.head;
    this.head = newNode;
    return this;
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
console.log(SLL1.Push(5).Push(8).Push(9).Pop().Pop().Pop());