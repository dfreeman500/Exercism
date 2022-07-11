def is_valid(isbn):
    isbn = isbn.replace("-", "")
    if len(isbn) != 10:
        return False
    isbn_list = list(isbn)
    if isbn_list[9] == 'X':
        isbn_list[9] = 10

    try:
        isbn_list = [int(x) for x in isbn_list]
    except:
        return False

    return sum([int(x[0])*x[1] for x in zip(isbn_list,[num for num in range(10,0,-1)])]) % 11 == 0


    