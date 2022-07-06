def to_rna(dna_strand):
    return dna_strand.translate(str.maketrans("GCTA","CGAU"))


    #translate takes either a maketrans() mapping table or a unicode dictionary. ord() makes a character unicode
    # this would also work 
    #return dna_strand.translate({ord("G"):ord("C"),ord("C"):ord("G"),ord("T"):ord("A"),ord("A"):ord("U")})
