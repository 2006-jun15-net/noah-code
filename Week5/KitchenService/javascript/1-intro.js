"strict mode";
console.log('Hello world');

let x = 5;
x = 4.5;

console.log(x);
console.log(typeof x);

x = 1/0; //infinity
x = NaN; //NaN (not a number)

x = true; //boolean

//string

x = `my templated ${typeof x}`; //ES6 feature

//object 
x = {}; // object literal 
x = {name: 'abc'};
x.id = 1;
delete x.name;

x = [1, 2, 3, 'abs', undefined]; //arrays are objects

x = function(){
    return 3;
};
function add(a,b){
    return a+b;
}
console.log(add(1,2));
console.log(x());