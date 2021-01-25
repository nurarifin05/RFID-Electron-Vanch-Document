var Payload = "1102ee00041621000000000000000001c57e1102ee00041621000000000000000001c57e1102ee00041621000000000000000001c57e1111";

var panjang;
var i;
target = [];
var TarId;
var Id;
var jadi;

for ( const array = Array.from(Payload); array.length; target.push(array.splice(0,36).join('')));

panjang=target.length;
console.log(target); 

console.log('panjang=',panjang);
for(i=0;i<panjang;i++){
     jadi= target[i].toString();
     jadi=jadi.slice(8,32);
console.log('data ke: ',i,'=',jadi);
}
Id = target.slice(-1);
var id = Id.toString();

console.log('data ke: ',i,'=',jadi);
console.log('ID Reader: ',id);
