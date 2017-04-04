# Total sum
sum = 0

# iterating from 1 to 1000
for num in range(1,1000):
    # if number has no remainders when it is divded by 5 or 3 then add number to sum 
    if num % 5 == 0 or num % 3 == 0:
        sum += num

print(sum)