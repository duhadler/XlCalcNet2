
import math
from mpfebnet import *

from decimal import *
from fractions import *

Mpfeb.SetDps(40)

frac = Fraction('-3/7')

i = 2329456398453948563945639364827346384753984573984573


def complex1():
    print()
    print("complex1():")
    z = 4+5j
    print(f"z = 4+5j: {z}")
    r = QCplx.T(z)
    print(f"r = QCplx.T(z): {r}")
    
    z = QCplx.T('3', '4')
    print("z = QCplx.T('3', '4')", z)
    z = QCplx.T(3.0, 4.0)
    print("z = QCplx.T(3.0, 4.0)", z)
    z = QCplx.T(3, 4)
    print("z = QCplx.T(3, 4)", z)
    z = QCplx.T(3+4j)
    print("z = QCplx.T(3+4j)", z)
    c = complex(3,4)
    print("c = complex(3,4)", c)
    z = QCplx.T(c)
    print("z = QCplx.T(c)", z)
    z = QCplx.T(1j)
    print("z = QCplx.T(1j)", z)
    z = QCplx.T(1)
    print("z = QCplx.T(1)", z)
    z = QCplx.T(1.1)
    print("z = QCplx.T(1.1)", z)


    print()
    z = QCplx.T(3+4j)
    print("z = QCplx.T(3+4j)", z)
    z = QCplx.Exp(z)
    print("z = QCplx.Exp(z)", z)
    z = QCplx.Exp(3+4j)
    print("z = QCplx.Exp(3+4j)", z)
    z = QCplx.Exp(5)
    print("z = QCplx.Exp(5)", z)



def complex2():
    print()
    print("complex2():")

    
    x = QCplx.T(5.7, 6.3)
    print(f"x = QCplx.T(5.7, 6.3): {x}")
    y = x + 2.5
    print(f"y = x + 2.5: {y}")
    y = 2.5 + x
    print(f"y = 2.5 + x: {y}")

    y = x - 2.5
    print(f"y = x - 2.5: {y}")
    y = 2.5 - x
    print(f"y = 2.5 - x: {y}")

    y = x * 2.5
    print(f"y = x * 2.5: {y}")
    y = 2.5 * x
    print(f"y = 2.5 * x: {y}")

    y = x / 2.5
    print(f"y = x / 2.5: {y}")
    y = 2.5 / x
    print(f"y = 2.5 / x: {y}")


    print()
    x = QCplx.T(5.7, 6.3)
    print(f"x = QCplx.T(5.7, 6.3): {x}")
    y = x + 25
    print(f"y = x + 25: {y}")
    y = 25 + x
    print(f"y = 25 + x: {y}")

    y = x - 25
    print(f"y = x - 25: {y}")
    y = 25 - x
    print(f"y = 25 - x: {y}")

    y = x * 25
    print(f"y = x * 25: {y}")
    y = 25 * x
    print(f"y = 25 * x: {y}")

    y = x / 25
    print(f"y = x / 25: {y}")
    y = 25 / x
    print(f"y = 25 / x: {y}")


    
    print()
    x = QCplx.T(5.7, 6.3)
    print(f"x = QCplx.T(5.7, 6.3): {x}")
    print(f"i: {i}")
    y = x + i
    print(f"y = x + i: {y}")
    y = i + x
    print(f"y = i + x: {y}")

    y = x - i
    print(f"y = x - i: {y}")
    y = i - x
    print(f"y = i - x: {y}")

    y = x * i
    print(f"y = x * i: {y}")
    y = i * x
    print(f"y = i * x: {y}")

    y = x / i
    print(f"y = x / i: {y}")
    y = i / x
    print(f"y = i / x: {y}")

    
    print()
    z = QCplx.T(5.7, 6.3)
    print(f"z = QCplx.T(5.7, 6.3): {z}")
    x = QReal.T(3.9)
    print(f"x = IReal.T(3.9): {x}")
    y = x + z
    print(f"y = x + z: {y}")
    y = z + x
    print(f"y = z + x: {y}")

    y = x - z
    print(f"y = x - z: {y}")
    y = z - x
    print(f"y = z - x: {y}")

    y = x * z
    print(f"y = x * z: {y}")
    y = z * x
    print(f"y = z * x: {y}")

    y = x / z
    print(f"y = x / z: {y}")
    y = z / x
    print(f"y = z / x: {y}")




def complex3():
    print()
    print("complex3():")
    x = QCplx.T(5.7, 6.3)
    print(f"x = QCplx.T(5.7, 6.3): {x}")
    y = x + 2.5j
    print(f"y = x + 2.5j: {y}")
    y = 2.5j + x
    print(f"y = 2.5j + x: {y}")

    y = x - 2.5j
    print(f"y = x - 2.5j: {y}")
    y = 2.5j - x
    print(f"y = 2.5j - x: {y}")

    y = x * 2.5j
    print(f"y = x * 2.5j: {y}")
    y = 2.5j * x
    print(f"y = 2.5j * x: {y}")

    y = x / 2.5j
    print(f"y = x / 2.5j: {y}")
    y = 2.5j / x
    print(f"y = 2.5j / x: {y}")


def complex4():
    print()
    print("complex4():")
    x = QCplx.T(5.7, 6.3)
    print(f"x = QCplx.T(5.7, 6.3): {x}")
    y = x + (4.4+2.5j)
    print(f"y = x + (4.4+2.5j): {y}")
    y = (4.4+2.5j) + x
    print(f"y = (4.4+2.5j) + x: {y}")

    y = x - (4.4+2.5j)
    print(f"y = x - (4.4+2.5j): {y}")
    y = (4.4+2.5j) - x
    print(f"y = (4.4+2.5j) - x: {y}")

    y = x * (4.4+2.5j)
    print(f"y = x * (4.4+2.5j): {y}")
    y = (4.4+2.5j) * x
    print(f"y = (4.4+2.5j) * x: {y}")

    y = x / (4.4+2.5j)
    print(f"y = x / (4.4+2.5j): {y}")
    y = (4.4+2.5j) / x
    print(f"y = (4.4+2.5j) / x: {y}")



complex1()
complex2()
complex3()
complex4()



