def is_multiple():
    pass

def sum_of_multiples(limit, multiples):   
    return sum([i for i in range(1,limit) if any([i % a == 0 for a in multiples if a > 0])])