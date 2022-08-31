import re

def abbreviate(words):

    return ("".join([x[0] for x in (re.sub('[^a-zA-Z]+', '-', words.replace("'","")).split('-'))]).upper())


# "".join(
#     [x[0] for x in (
#         re.sub('[^a-zA-Z]+', '-', words.replace("'",""))
#         .split('-'))]
# ).upper()

# First replace "'", 
# then replace all non alpha characters with '-', 
# then split the string into a list,
# then iterate over the list and return the first letter,
# then join the letters, 
# then make them uppercase