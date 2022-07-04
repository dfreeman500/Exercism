def is_isogram(string):
    new_string = string.strip().lower().translate({45: None, 32: None})  
    for letter in new_string:
        if new_string.count(letter) > 1:
            return False
    return True
    
