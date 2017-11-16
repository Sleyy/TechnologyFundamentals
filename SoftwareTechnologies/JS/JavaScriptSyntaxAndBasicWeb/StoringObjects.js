function storingObjects(arr) {
    for(let i = 0; i< arr.length; i++) {
        let currentStudent = arr[i].split(" -> ");
        let currentName = currentStudent[0];
        let currentAge = currentStudent[1];
        let currentGrade = currentStudent[2];
        let student = {Name: currentName, Age: currentAge, Grade: currentGrade};
        console.log('Name: '+student.Name)
        console.log('Age: '+student.Age);
        console.log('Grade: '+student.Grade)
    }
}
storingObjects(['Pesho -> 13 -> 6.00',
'Ivan -> 12 -> 5.57',
'Toni -> 13 -> 4.90'
]);