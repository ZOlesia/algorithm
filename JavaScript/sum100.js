var findSequences = function(str, total) {
    var recurse = function(string, remaining, result) {
        if(string == '') {
            if(remaining == 0) {
                console.log(result);
            }
            return;
        }
        var i, tmp;
        for(i = 1; i <= string.length; i++) {
            tmp = parseInt(string.substr(0, i));
            recurse(string.substr(i), remaining - tmp, result + '+' + tmp);
            recurse(string.substr(i), remaining + tmp, result + '-' + tmp);
        }
    };
    recurse(str, total, '');
};

findSequences('123456789', 100);