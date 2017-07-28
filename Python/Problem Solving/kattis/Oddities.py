n = input()

if(1 <= int(n) <= 20):
    for x in range(0, int(n)):
        y = input()
        if(-10 <= int(y) <= 10):
            if(int(y) % 2 == 0):
                print(str(y) + ' is even')
            else:
                print(str(y) + ' is odd')

