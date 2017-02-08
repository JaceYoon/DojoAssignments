print "Starting the program.."
import random
def coin(x):
    i = 0
    count1 = 0
    count2 = 0
    while i < x:
        random_num = random.randint(0,1)
        i+=1
        if random_num == 0:
            print "head!"
            count1 += 1
            print "Attempt #",i,"Throwing a coin... Its a ...head(s) Got", count1, "head(s) so far and", count2,"tails(s) so far"
        if random_num == 1:
            print "tail!"
            count2 += 1
            print "Attempt #",i,"Throwing a coin... Its a ...tail(s) Got", count1, "head(s) so far and", count2,"tails(s) so far"
    return random_num
print coin(5000)
