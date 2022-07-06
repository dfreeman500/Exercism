import re

def response(hey_bob):
    if hey_bob == "" or (re.search('[\w]', hey_bob) == None and hey_bob[-1]!="?"):
        return "Fine. Be that way!"
    if hey_bob[-1] == "?" and hey_bob.upper() == hey_bob and re.search('[a-zA-Z]', hey_bob) != None:
        return "Calm down, I know what I'm doing!"
    if hey_bob.strip()[-1] == "?" :
        return "Sure."
    if hey_bob.upper() == hey_bob and re.search('[a-zA-Z]', hey_bob) != None:
        return  "Whoa, chill out!" 

    else:
        return "Whatever."
