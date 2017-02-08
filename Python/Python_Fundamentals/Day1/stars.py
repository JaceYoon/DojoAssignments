def star(arr):
    result = ""
    for i in arr:
        newarr = ""
        if type(i) == int:
            for j in range(i):
                newarr += "*"
            result += newarr + '\n'
        if type(i) == str:
            for j in range(len(i)):
                newarr += i[0].lower()
            result += newarr + '\n'
    print result

x = [4, 6, 1, 3, 5, 7, 25] # Part 1
star(x)
x = [4, "Tom", 1, "Michael", 5, 7, "Jimmy Smith"] # Part 2
star(x)
