var money = 0.01;
for(day = 1; day <= 30; day++)
{
    money *= 2;
}
console.log(money);

//Bonus
var money = 0.01;
for(day = 1; day <= 30; day++)
{
    money *= 2;
    if(money >10000)
    {
      break;
    }
}
console.log(day);

var money = 0.01;
for(day = 1; day <= 30; day++)
{
    money *= 2;
    if(money >1000000000)
    {
      break;
    }
}
console.log(day);

//bonus
