class Bike(object):
    def __init__(self,price,max_speed):
        self.price = price
        self.max_speed = max_speed
        self.miles = 0

    def ride(self):
        self.miles += 10
        return self
    def reverse(self):
        self.miles -= 5
        if self.miles < 0:
            self.miles = 0
        return self
    def displayInfo(self):
        print "The price is :", self.price, "max_speed is :", self.max_speed, "Total miles is :",self.miles

bike1 = Bike("$500","20mph")
bike1.ride().ride().ride().reverse().displayInfo()
bike2 = Bike("$2,500","80mph")
bike2.ride().ride().reverse().reverse().displayInfo()
bike3 = Bike("$15,000", "170mph")
bike3.reverse().reverse().reverse().displayInfo()
