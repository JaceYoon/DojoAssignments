for i in range(1,2001):
    if i % 2 == 0:
        print "Number is", i, ", This is an odd number"
    else:
        print "Number is", i, ", This is an even number"

def mutiply(x,y):
    for value in range(len(x)):
        x[value] *= y
    return x
a = [2,4,10,16]
b = mutiply(a,5)
print b

def layered_multiples(arr):
    result = []
    for i in arr:
        newarr = []
        for j in range(i):
            newarr.append(1)
        result.append(newarr)
    return result

x = layered_multiples(mutiply([2,4,5],2))
print x
