// Echo Type

// Решение:
function solve(input){
    console.log(typeof(input));
    if(typeof(input) == 'string' || typeof(input) == 'number')
    {
        console.log(input);
    }
    else{
        console.log("Parameter is not suitable for printing");
    }
}

//Извеждане на резултат:
solve("Hello, Javasciprt!");
solve(18);
solve(null);
