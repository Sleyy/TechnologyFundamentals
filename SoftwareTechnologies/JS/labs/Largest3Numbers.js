function LargestThreeNumbers(arr) {
let numbers = arr.map(Number).sort((a,b)=>b-a);
    for (let i = 0; i < Math.min(3,numbers.length);i++){
        console.log(numbers[i])
    }
}

LargestThreeNumbers([
    '10',
' 30',
' 15',
' 20',
' 50',
' 5']);