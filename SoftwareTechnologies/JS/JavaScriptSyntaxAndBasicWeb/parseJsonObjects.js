function parseJson(arr) {
    for(let i=0; i<arr.length;i++){
        let currentObject = JSON.parse(arr[i]);
        console.log('Name: '+currentObject.name);
        console.log('Age: '+currentObject.age);
        console.log('Date: '+currentObject.date);
    }
}
parseJson([
    '{"name":"Gosho","age":10,"date":"19/06/2005"}',
    '{"name":"Tosho","age":11,"date":"04/04/2005"}'
]);