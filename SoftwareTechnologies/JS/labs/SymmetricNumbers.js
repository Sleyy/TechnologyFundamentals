function GetSymetricNums(num) {
    for (let i = 1; i <= Number(num[0]); i++){
        let currentNumber = i.toString();
        let symetric = true;
        for(let g = 0; g< currentNumber.length/2; g++){
            if (currentNumber[g] != currentNumber[currentNumber.length-1-g])
            {
                symetric =  false;
            }
        }
        if (symetric == true){
            console.log(currentNumber)
        }
        }
}

GetSymetricNums(['10000']);