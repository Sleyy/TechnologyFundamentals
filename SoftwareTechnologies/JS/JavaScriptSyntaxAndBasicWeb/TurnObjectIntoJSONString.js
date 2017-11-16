function turnObjIntoJSON(arr) {
    let object = {};
    for(let i =0; i<arr.length;i++){
        let currentObject = arr[i].split(" -> ");
        if(currentObject[1] == Number(currentObject[1])){
            currentObject[1]=Number(currentObject[1]);
        }
        object[currentObject[0]]=currentObject[1];
    }
    console.log(JSON.stringify(object))
}
turnObjIntoJSON([
    'name -> Angel',
    'surname -> Georgiev',
    'age -> 20',
    'grade -> 6.00',
    'date -> 23/05/1995'
]);