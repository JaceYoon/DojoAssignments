class Car(object):
    def __init__(self, price, speed, fuel, milleage):
        self.price = price
        self.speed = speed
        self.fuel = fuel
        self.milleage = milleage
        self.tax = 0.12

    def taxes(self):
        if self.price > 10000:
            self.tax = 0.15
        return self
    def prices(self):
        self.price *= (1+self.tax)
        return self
    def display_all(self):
        print "--------------------------------------"
        print "Price :",self.price
        print "speed :",self.speed
        print "fuel :",self.fuel
        print "milleage :",self.milleage
        print "Total price(includes Tax) :", self.price
        print "tax :",self.tax
        print "--------------------------------------"
        return self

car1 = Car(2000,"35mph","Full","15mpg").taxes().prices().display_all()
car2 = Car(15000,"56mph","Not Full","135mpg").taxes().prices().display_all()
car3 = Car(10001,"89mph","Kind of Full","25mpg").taxes().prices().display_all()
car4 = Car(9999,"100mph","Full","150mpg").taxes().prices().display_all()
