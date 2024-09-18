def gender(numerPesel):
    if(int(numerPesel[9]) % 2 == 0):
        return 'K'
    else:
        return 'M'

def sprawdzNumerPesel(numerPesel):
    mnozniki = (1, 3, 7, 9, 1, 3, 7, 9, 1, 3)
    S = 0
    for i in range(len(numerPesel) - 1):
        S = S + (int(numerPesel[i]) * mnozniki[i])
    M = S % 10
    R = 0
    if (M != 0):
        R = 10 - M
    return R == int(numerPesel[10])

numerPesel = "55030101193"
numerPesel = str(input("podaj numer pesel: "))
if (gender(numerPesel) == 'K'):
    print("kobieta")
else:
    print("mezczyzna")
if (sprawdzNumerPesel(numerPesel)):
    print("zgodny numer pesel")
else:
    print("niezdogny numer pesel")
