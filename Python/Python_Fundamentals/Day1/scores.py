import random
print "Scores and Grades"
def score(x):
    for count in range(0,x):
        random_num = random.randint(60,101)
        if random_num >= 60 and random_num <= 69:
            print "Score :",str(random_num)+"; Your grade is D"
        if random_num >= 70 and random_num <= 79:
            print "Score :",str(random_num)+"; Your grade is C"
        if random_num >= 80 and random_num <= 89:
            print "Score :",str(random_num)+"; Your grade is B"
        if random_num >= 90 and random_num <= 100:
            print "Score :",str(random_num)+"; Your grade is A"
    print "End of the program. Bye!"
score(10)
