def distance(strand_a, strand_b):
    if len(strand_a) != len(strand_b):
        raise ValueError("Strands must be of equal length.")
    count=0
    for x,y in zip(strand_a,strand_b):
        if x != y:
            count+=1
    return count