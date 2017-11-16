function KeyValuePairs(arr) {
    let result = new Array();
    for (let i = 0; i< arr.length; i++) {
        let pair = arr[i].split(" ");
       if (i == arr.length-1){
           if(pair[0] in result){
           return result[pair[0]];
           }
           else{
               return 'None';
           }
       }
        let key = pair[0];
        let value = pair[1];
        result[key]=value;
    }
}
KeyValuePairs(['key value',
    'key avlue',
    'test tset',
    'key'
]);