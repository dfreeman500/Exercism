def commands(binary_str):
    handshake_components = ['jump','close your eyes','double blink','wink']     
    handshake = [handshake_components[x] for x in range(0,4) if int(binary_str[x+1]) == 1 ]
    if int(binary_str[0]) == 1:
        return handshake
    else:
        return handshake[::-1]