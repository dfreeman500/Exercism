def classify(number):
    """ A perfect number equals the sum of its positive divisors.

    :param number: int a positive integer
    :return: str the classification of the input integer
    """

    sum_of_factor = sum([n for n in range(1, number) if number % n == 0])
    # the formula above excludes the number itself
    # List all factors: https://stackoverflow.com/questions/47064885/list-all-factors-of-number uses number+1
    
    if number<1:
        raise ValueError("Classification is only possible for positive integers.")
    
    if sum_of_factor == number:
        return "perfect"
    if sum_of_factor > number:
        return "abundant"
    if sum_of_factor < number:
        return "deficient"