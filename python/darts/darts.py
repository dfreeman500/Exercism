import math
def score(x, y):
    distance_from_center = math.dist((x,y), (0,0))

    if distance_from_center > 10:
        return 0
    if distance_from_center <=10 and distance_from_center > 5:
        return 1
    if distance_from_center <= 5 and distance_from_center >1:
        return 5
    if distance_from_center <= 1:
        return 10
