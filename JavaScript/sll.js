function SLL(){
    this.head = null;
    this.length = 0;
}

function Node(val){
    this.val = val;
    this.next = null;
    return this;
}


SLL.prototype.ATF = function(val){
    var newNode = new Node(val);
    var temp = newNode;
    temp.next = this.head;
    this.head = temp;
    this.length++;
    return this;
}

SLL.prototype.ATB = function(val){
    var newNode = new Node(val);
    var temp = this.head;
    if(temp == null){
        this.head = newNode;
        this.length ++;
        return this;
    } else{
        while(temp.next !== null){
            temp = temp.next;
        }
        temp.next = newNode;
        this.length ++;
        return this;
    }
}

SLL.prototype.contain = function(val){
    var temp = this.head;
    if(this.head == null){
        return false;
    } else{
        while(temp!==null){
            if(temp.val == val){
                return true;
            }
            temp = temp.next;
        }
        return false;
    }
}

SLL.prototype.removeFromBack = function(){
    var temp = this.head;
    if(temp == null){
        return this;
    }
    else if(temp.next == null){
        console.log(this.head);
        this.head == null;
        this.length --;
        return this;
    } 
    while(temp.next !== null){
        if(temp.next.next == null){
            temp.next = null;
            this.length --;
            return this;
        }
        temp = temp.next;
    }
}

SLL.prototype.removeFront = function(){
    if(this.head == null){
        return this;
    } else if(this.head.next == null){
        this.head = null;
        this.length--;
        return this;
    } else {
        this.head = this.head.next;
        this.length--;
        return this;
    }
}

SLL.prototype.removeVal = function(val){
    var temp = this.head;
    if(temp == null){
        return this;
    } 
    else if(temp.val == val){
        if(temp.next == null){
            this.head = null;
            this.length--;
            return this;
        } else {
            this.head = this.head.next;
            this.length--;
            return this;
        }
    } else{
        while(temp.next!== null){
            if(temp.next.val === val){
                if(temp.next.next == null){
                    temp.next = null;
                    this.length--;
                    return this;
                } else{
                    temp.next = temp.next.next;
                    this.length--;
                    return this;
                }
            }
            temp=temp.next;
        }
    }
    return false;
}

SLL.prototype.insertBefore = function(val1, val2){
    var temp = this.head;
    if(this.head == null){
        return this;
    } else if(this.head.val == val2){
        var newNode = new Node(val1);
        newNode.next = this.head;
        this.head = newNode;
        this.length++;
        return this;
    } else{
        while(temp.next!==null){
            if(temp.next.val == val2){
                var newNode = new Node(val1);
                newNode.next = temp.next;
                temp.next = newNode;
                this.length++;
                return this;
            }
            temp = temp.next;
        }
    }
    return false;
}

// var SLL2 = new SLL();
// console.log(SLL2.ATB(10).ATF(3).ATF(1).ATB(15));
// console.log(SLL2.contain(15));
// console.log(SLL2.removeFront().removeFront().removeFromBack().removeFront());
// console.log(SLL2.removeVal(100));
// console.log(SLL2.insertBefore(30,1));

