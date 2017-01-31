function game(quarters,leavewhen)
{
   while(quarters >0 && quarters <=leavewhen)
   {
       quarters --;
       if( Math.floor(Math.random() * 100 + 1) == 7)
       {
           quarters += Math.floor(Math.random() * 50 + 1 ) + 50;
           console.log("You won!!" + quarters);
       }
       else
       {
           console.log("You lose.." + quarters);
       }
   }
   console.log(quarters);
}
game(100,130);
