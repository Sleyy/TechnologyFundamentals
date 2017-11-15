function productOfThree(arr){
    let nums = arr.map(Number);
    let counter = 0;
    for (let num of nums)
    {
        if (num == 0){
            return `Positive`;
        }
        else if (num < 0){
            counter++;
        }
    }
    if (counter % 2 !== 0){
        return `Negative`;
    }
    else   {
        return `Positive`;
    }
}