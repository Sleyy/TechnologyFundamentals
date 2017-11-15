function  SumByTown(arr) {
    let objects = arr.map(JSON.parse);
    let result = {};
    for (let obj of objects){
        if (obj.town in result){
            result[obj.town] += obj.income;
        }
        else  {
            result[obj.town] = obj.income;
        }
    }
    let towns = Object.keys(result).sort();
    for (let town of towns){
        console.log(`${town} -> ${result[town]}`);
    }

}

SumByTown([
    `{"town":"Sofia","income":200}`,
    `{"town":"Varna","income":320}`,
    `{"town":"Pleven","income":60}`,
    `{"town":"Varna","income":70}`
]);