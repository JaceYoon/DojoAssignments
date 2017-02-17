import random
class Animal(object):
    def __init__(self,name):
        self.health = 100
        self.name = name
    def walk(self):
        self.health -= 1
        return self
    def run(self):
        self.health -= 5
        return self
    def displayHealth(self):
        print self.name+"'s Total health is :",self.health
        return self;
animal1 = Animal("animal").walk().walk().walk().run().run().displayHealth()

class Dog(Animal):
    def __init__(self,name):
        super(Dog, self).__init__(name)
        self.health = 150
    def pet(self):
        self.health += 5
        return self
Dog1 = Dog("Eevee").walk().walk().walk().run().run().pet().displayHealth()

class Dragon(Animal):
    def __init__(self,name):
        super(Dragon, self).__init__(name)
        self.health = 170
    def fly(self):
        self.health -= 10
        return self
Dragon1 = Dragon("DeathWing").walk().walk().walk().run().run().fly().displayHealth()
