def transform(legacy_data):
    new_system={}
    for score in legacy_data:
        temp_list= [letter.lower() for letter in legacy_data[score]]
        new_system.update(dict.fromkeys(temp_list,score))
    return new_system
        


#        temp_list= [b.lower() for b in legacy_data[score]] 
#        new_system.update(dict.fromkeys(temp_list,score))
#
# Could be re-written as -->
#        new_system.update(dict.fromkeys([b.lower() for b in legacy_data[score]])