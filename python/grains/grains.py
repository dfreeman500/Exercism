
def square(number):
    if number <1 or number > 64:
        raise ValueError("square must be between 1 and 64")
    return 2**(number-1)


def total():
    sum = 0
    for x in range(1,65):
        sum+=square(x)
    return sum
    
