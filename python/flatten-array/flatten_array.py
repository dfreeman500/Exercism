def flatten(iterable):
    flattened_list=[]
    for item in iterable:
        if isinstance(item, list):
            flattened_list.extend(flatten(item))
        elif item != None:
            flattened_list.append(item)
    return flattened_list


# https://realpython.com/python-recursion/#:~:text=In%20Python%2C%20it's%20also%20possible,problems%20are%20best%20expressed%20recursively.

