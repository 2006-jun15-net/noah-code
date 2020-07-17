"use strict";

let nick = {
    name: 'Nick'
};

nick.sayName = function(){
    //console.log('Nick');
    console.log(this.name);
}

let oldNick = nick;
nick = {name: 'Mark'};


console.log(nick);
console.log(oldNick);
oldNick.sayName();

//let theFunction = oldNick.sayName;
//theFunction(); //this is undefined here because there was nothing to the left of .

function Person(name, location){
    if(typeof name !== 'string' || name.length === 0){
        throw new Error('invalid name');
    }
    this.name = name;
    this.location = location;

    this.sayName = function(){
        console.log(this.name);
    };
}

let mark = new Person('Mark', 'TX');
mark.sayName();
console.log(mark.location);

let nick2 = {name: 'nick'};
nick2.__proto__ = mark;

//nick inherits mark's data and behavior, but anything nick defines by himself
// overrides what mark defines.

nick2.sayName();

//this works because of how JS does property access (not property assignment):
    // property asignment always modifies the actual object, never any prototype
// if the accessed property is undefined on the object, JS will recursively look 
    // for it on the object's prototype, then that object's prototype, until there are no more


class Guy {
    constructor(name, location) {
        if (typeof name !== 'string' || name.length === 0) {
            throw new Error('invalid name');
        }
        this.name = name;
        this.location = location;

        
        }
        sayName() {
            console.log(this.name);
    };
}

class SchoolGuy extends Guy{
    constructor(name, location, grade){
        super(name, location);
        this.grade = grade;
    }
}
let jacob = new SchoolGuy('Jacob', 'FL', 'B');
jacob.sayName();
console.log(jacob);