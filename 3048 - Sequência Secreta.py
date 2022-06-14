length = int(input())
corrects = 0
lastnumber = 0
for i in range(length):
    number = int(input())
    if (number != lastnumber): corrects += 1
    lastnumber = number
print(corrects)
