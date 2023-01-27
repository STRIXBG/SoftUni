// Print and Sum

// Solution:
function solve(start, end){
    let sum = 0;
    let text = "";
    for(var i=start; i<=end; i++){
        sum += i;
        text = text + ' ' + i;
    }
    console.log(text);
    console.log("Sum: " + sum);
}

// Print the result:
solve(5, 10);
solve(0, 26);
solve(50, 60);
