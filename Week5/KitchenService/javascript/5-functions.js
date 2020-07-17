"use strict";

[1,2,3].forEach(x => console.log(x));

setTimeout(() => console.log('runs second'), 1000);
console.log('runs first');

let slowAdderService = {
    add(a,b, continuation){
        setTimeout(() => continuation(a+b), 1000);
    }
}
slowAdderService.add(5,5, result => console.log(result) );

function newCounter(){
    let count =0;
    return () => ++count;
}

let counter1 = newCounter();
console.log(counter1());
console.log(counter1());
console.log(counter1());

let counter2 = newCounter();
console.log(counter2());
console.log(counter2());
console.log(counter1());