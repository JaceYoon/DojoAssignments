function vehicle(name,wheels,passenger,speed){
  this.name = name;
  this.wheels = wheels;
  this.passenger = passenger;
  this.speed = speed;
  if (!(this instanceof vehicle)){
    return new vehicle(name,wheels,passenger, speed);
  }
  var distance = 0;
  var self = this;
  function updateDistanceTraveled(){
    distance += self.speed;
    console.log(distance);
  }
  this.Move = function(){
    this.makeNoise();
    updateDistanceTraveled();
  }
  this.CheckMiles = function(){
    console.log(distance)
  }
}
vehicle.prototype.makeNoise = function(){
  console.log(this.name + 'makes a noise')
}

class Bike extends vehicle {
  makeNoise(){
    console.log('ringringring')
  }
}
class Sedan extends vehicle {
  makeNoise(){
    console.log('honk honk honk')
  }
}
class Bus extends vehicle {
  makeNoise(){
    console.log('Brrrrrrr');
  }
}

var bikes = new Bike('Bike',2,2,20);
var sedans = new Sedan('Benz',4,4,270);
var buses = new Bus('Transformer',6,10,40);

console.log(bikes);
bikes.Move();
bikes.CheckMiles();
sedans.CheckMiles();
console.log(buses.speed);
