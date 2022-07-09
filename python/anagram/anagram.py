def find_anagrams(word, candidates):

    return [candidate for candidate in candidates 
            if sum([ord(x) for x in candidate.lower()]) == sum([ord(x) for x in word.lower()]) 
            and set(candidate.lower())== set(word.lower()) 
            and candidate.lower()!= word.lower() ]


# for every word in candidates return a candidate if 
# 1.) the sum of the unicode for word.lower() and candidate.lower are equal
# 2.) they have the same amount of sets of letters ("mass" and "last" have the same unicod values)
# 3.) word and candidate are not the same


# a really elegant solution comes from 
# https://exercism.org/tracks/python/exercises/anagram/solutions/rjmcgrew
# Which basically just compares the sorted strings


# def find_anagrams(word, candidates):
#     return [
#         x
#         for x in candidates
#         if x.casefold() != word.casefold()
#         and sorted(x.casefold()) == sorted(word.casefold())
#     ]
