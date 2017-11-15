function addOrRemove(arr) {
    let result = new Array();
    for (i=0; i< arr.length;i++){
        let command = arr[i].split(' ');
        if (command[0] == 'add'){
            result.push(command[1])
        }
        else if (command[1] in result){
            result.splice(command[1],1);
        }
    }
   for (let r of result){
        console.log(r)
   }

}
addOrRemove(['add 3', 'remove 0', 'add 7'])