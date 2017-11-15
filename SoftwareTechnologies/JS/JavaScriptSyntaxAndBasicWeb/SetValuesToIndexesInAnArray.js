function SetValuesToIndex (arr) {
    let result = new Array(Number(arr[0]));
    for (i=1;i< arr.length;i++){
        let temp = arr[i].split(' - ');
        result[temp[0]]=temp[1];
    }
    for (let r of result){
        if (r==undefined){
            console.log('0')
        }
        else{
            console.log(r)
        }

    }

}
SetValuesToIndex(['2', '0 - 5', '0 - 6', '0 - 7']);