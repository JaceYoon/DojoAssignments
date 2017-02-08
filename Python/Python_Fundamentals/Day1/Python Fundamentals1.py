str = "If monkeys like bananas, then I must be a monkey!"
print [n for n in xrange(len(str)) if str.find('monkey', n) == n]
print str.replace('monkey','alligator')
x = [2,54,-2,7,12,98]
print min(x)
print max(x)
x = ["hello",2,54,-2,7,12,98,"world"]
y = [x[0],x[len(x)-1]]
print y
x = [19,2,54,-2,7,12,98,32,10,-3,6]
x.sort()

y = [x[0],x[1]]
x.insert(2,y)
print x[2:]
