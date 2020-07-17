"use strict";

function calculate(q){

    console.log(a); // even in strict mode, this is undefined because var variables have their declarations
        //hoisted  to the top of the function
    //z = 6; //global- calling this function had a side effect of altering something in global scope
    //prevented by strict mode
    var a = 7;// function scope

}

calculate(3);
//console.log(z); //ReferenceError
//console.log(a); //ReferenceError

//even in pre-ES5 JS, accessing an undeclared variable throws a reference error
// we can use try-catch with errors in JS (use try catch with anything);

if(true){
    let data = 5; //block scope
    const value = 8;
    //value = 3; //can't reassign const.
}

console.log(data); //can't access because of block scope