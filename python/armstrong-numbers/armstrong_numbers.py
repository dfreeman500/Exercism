def is_armstrong_number(number):
    split_number = [int(a) for a in str(number)]
    return sum([b**len(split_number) for b in split_number]) == number





    # split_number = [int(a) for a in str(number)]
    # print(split_number) 
    # print([b**len(split_number) for b in split_number])
    # return sum([b**len(split_number) for b in split_number]) == number