"use strict";

console.log(3 + []); // prints the string '3'
console.log(3 + true); // prints the number 4

if(3){
    console.log("3 is truthy");
}

function checkEquality(a, b){
    console.log(`${a} == ${b}: ${a == b}`);
    console.log(`${a} === ${b}: ${a === b}`);
}

checkEquality(3, '3');
checkEquality(false, []);