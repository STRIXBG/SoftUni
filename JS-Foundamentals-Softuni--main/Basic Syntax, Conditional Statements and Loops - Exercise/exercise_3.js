// Division

// Solution:
function solve(number){
    var divisible;
    if(number % 10 == 0){
        console.log("The number is divisible by 10");
    }
    else if(number % 6 == 0){
        console.log("The number is divisible by 6");
    }
    else if(number % 3 == 0){
        console.log("The number is divisible by 3");
    }
    else if(number % 2 == 0){
        console.log("The number is divisible by 2");
    }
    else{
        console.log("Not divisible");
    }
}

// Print the result:
solve(1643);
