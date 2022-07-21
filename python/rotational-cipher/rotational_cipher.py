def rotate(text, key):
    alpha_lower = "abcdefghijklmnopqrstuvwxyz"
    alpha_upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    new_alpha_lower = alpha_lower[key:len(alpha_lower)]+alpha_lower[0:key]
    new_alpha_upper = alpha_upper[key:len(alpha_upper)]+alpha_upper[0:key]
    return text.translate(str.maketrans(alpha_lower+alpha_upper,new_alpha_lower+new_alpha_upper))





# CHECK OUT 
# from string import ascii_lowercase, ascii_uppercase