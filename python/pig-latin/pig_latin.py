import re

def rules(word):
    if word.startswith(('a','e','i','o','u','yt','xr')):
        return word+"ay"

    elif word.startswith(('thr','sch','squ')):
        return word[3:]+word[0:3]+"ay"
        
    elif word.startswith(('qu','ch','th')):
        return word[2:]+word[0:2]+"ay"

    elif len(word)>2 and word[2]=='y':
        return word[2:]+word[0:2]+"ay"
    
    elif re.findall(r"^[bcdfghjklmnpqrstvwxyz]", word):
        return word[1:]+word[0]+"ay"

def translate(text):
    return " ".join([rules(x) for x in text.split(" ")])


