
function addHelloMessage(message: string): void{
    document.body.innerHTML = message;
}
addHelloMessage("hello from TypeScript");
//addHelloMessage(133); won't compile
