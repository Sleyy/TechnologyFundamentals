function CapitalCaseWords(arr) {
    let words = arr.join(",");
        words = words.split(/\W+/);
    let result = [];
    for (let word of words)
    {
        if (word === word.toUpperCase() && word.length > 0){
           result.push(word);
        }
    }
    console.log(result.join(", "));
}

CapitalCaseWords([`We start by HTML, CSS, JavaScript, JSON and REST.
Later we touch some PHP, MySQL and SQL.
Later we play with C#, EF, SQL Server and ASP.NET MVC.`]);