function multiplyOrDivide (arr){
    let numN = Number(arr[0]);
    let numX = Number(arr[1]);
    if (numX >= numN){
        return numX * numN;
    }
    else if (numN > numX){
        return numN/numX;
    }
}