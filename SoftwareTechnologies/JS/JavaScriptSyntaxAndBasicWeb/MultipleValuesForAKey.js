function KeyValuePairs(arr) {
    let result = new Array();
    for (let i = 0; i< arr.length; i++) {
        let pair = arr[i].split(" ");
        if (i == arr.length-1){
            if(pair[0] in result){
                let res = result[pair[0]].split(" ");
                console.log(res.join("\n"))
            }
            else{
                return 'None';
            }
        }
        let key = pair[0];
        let value = pair[1];
        if (key in result){
            result[key]+=" "+value;
        }
        else{
            result[key]=value;
        }

    }
}
KeyValuePairs(['key value',
    'key avlue',
    'test tset',
    'key'
]);