alpha = "abcdefghijklmnopqrstuvwxyz"

def is_pangram(sentence):
    is_pangram = True
    
    for letter in alpha:
        if letter not in sentence.lower():
            is_pangram = False
            break
    return is_pangram
        