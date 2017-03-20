var x = [3,5,"Dojo", "rocks", "Michael", "Sensei"]

for(i=0; i<x.length; i++)
{
  console.log(x[i])
}

x.push(100)

x.push(["hello", "world", "JavaScript is Fun"])

console.log(x)

var sum = 0
for(var j=1; j<501; j++)
{
  sum += j
}
console.log(sum)

var newarr = [1, 5, 90, 25, -3, 0]
var max = 0
var sum = 0

for(i=0; i<newarr.length; i++)
{
  if(newarr[i] > max)
  {
    max = newarr[i]
  }
  else {
    max = max
  }
}

for(i=0; i<newarr.length; i++)
{
  sum += newarr[i]
}
var avg = sum / newarr.length

console.log(max)
console.log(avg)

var newNinja = {
 name: 'Jessica',
 profession: 'coder',
 favorite_language: 'JavaScript', //like that's even a question!
 dojo: 'Dallas'
}
for (var key in newNinja){
  if (newNinja.hasOwnProperty(key)){
    console.log(key + "-" + newNinja[key]);
  }
}
