
import math
from mpfebnet import *

from decimal import *
from fractions import *

Mpfeb.SetDps(60)

frac = Fraction('-3/7')

i = 2329456398453948563945639364827346384753984573984573


def real1():
    print()

##    z = 4+5j
##    r = ACplx.T(z)
##    print(f"r = ACplx.T(z): {r}")
    
    x = XReal.T(i)
    print(f"x = XReal.T(i): {x}")
    
    x = XReal.T(5.7)
    print(f"x = XRealT(5.5): {x}")
    
    x = XReal.T(5.7)
    print(f"x = XRealT(5.5): {x}")
    x0 = XReal.T(2329456398453948563945639364827346)
    print(f"x0 = XRealT(2329456398453948563945639364827346):    {x0}")
    x1 = XReal.T('2329456398453948563945639364827346')
    print(f"x1 = XReal.T('2329456398453948563945639364827346'): {x1}")
    x = XReal.T('5.5')
    print(f"x = XRealT('5.5'): {x}")

    print()
    x = XReal.T(55)
    print(f"x = XReal.T(5): {x}")
    y = XReal.Exp(x)
    print(f"y = XReal.Exp(x): {y}")
    
    z = XReal.Exp(5.5)
    print(f"z = XReal.Exp(5.5): {z}")
    z = XReal.Exp(5)
    print(f"z = XReal.Exp(5): {z}")
    z = XReal.Exp('5.5')
    print(f"z = XReal.Exp('5.5'): {z}")

    print()
    dec = Decimal(1) / Decimal(7)
    print(f"dec = Decimal(1) / Decimal(7): {dec}")
    z = XReal.Exp(dec)
    print(f"z = XReal.Exp(dec): {z}")
    frac = Fraction('-3/7')
    print(f"frac = Fraction('-3/7'): {frac}")
    #z = XReal.Exp(frac)
    #print(f"z = XReal.Exp(frac): {z}")

    print()
    x = XReal.T(5.5)
    print(f"x = XReal.T(55): {x}")
    y = XReal.T(3.3)
    print(f"y = XReal.T(33): {y}")
    z = XReal.Pow(x, y)
    print(f"z = XReal.Pow(x, y):         {z}")
    z = XReal.Pow(5.5, 3.3)
    print(f"z = XReal.Pow(5.5, 3.3):     {z}")
    z = XReal.Pow('5.5', '3.3')
    print(f"z = XReal.Pow('5.5', '3.3'): {z}")
    z = XReal.Pow(5, 3)
    print(f"z = XReal.Pow(5, 3): {z}")

    t = z + 3
    print(f"t = z + 3: {t}")
    

def real2():
    print()
    x = XReal.T(5.7)
    print(f"x = XReal.T(5.7): {x}")
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
    x = XReal.T(5.7)
    print(f"x = XReal.T(5.7): {x}")
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
    x = XReal.T(5.7)

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

    


def MyFunc(x):
    y = math.exp(x)
    #print("x: ", x, "y: ", y)
    return y

def F20Ctx(x):
    Ctx = mp4.CtxFromType(x)
    #y = Ctx.T(1) / x
    y = 1 / x
    #print("x: ", x, "y: ", y)
    return y


def real3():
    print()
    x = 5.7
    y = 0
    print()
    res = Math53.Squadx(1.1, 2.2, 3.3)
    print("res = Math53.Squadx(1.1, 2.2, 3.3): ", res)

    print()
    y = MyFunc(x)
    print("x: ", x, "y: ", y)
    res = Math53.LocalMin(mp4.cbFuncDouble(MyFunc), -10.0, 20.0, 1E-6, 1E-6)
    print("res: ", res)

    print()
    Ctx = XReal
    res2 = Ctx.Boost.Ooura_Sin2(Ctx.Cb2Scalar(F20Ctx))
    print(res2)


def real4():
    print()
    xMat = XReal.Mat.Random(2,2)
    print("xMat = XReal.Mat.Random(2,2): \n", xMat)
    
    xcoeff = XReal.T(4.5)
    print("xcoeff = XReal.T(4.5): ", xcoeff)
    
    xMat[1,1] = xcoeff
    print("xMat[1,1] = xcoeff: \n", xMat)
    print("xMat[1,1]: ", xMat[1,1])


def real5():
    print()
    x = XReal.T(5.0)
    y = XReal.T(2.5)
    print("x: ", x)
    print("y: ", y)
    res = x < y
    print(f"res = x < y: {res}")
    res = y < x
    print(f"res = y < x: {res}")

    res = x > y
    print(f"res = x > y: {res}")
    res = y > x
    print(f"res = y > x: {res}")

    res = x >= y
    print(f"res = x >= y: {res}")
    res = y >= x
    print(f"res = y >= x: {res}")

    res = x <= y
    print(f"res = x <= y: {res}")
    res = y <= x
    print(f"res = y <= x: {res}")

    res = x == y
    print(f"res = x == y: {res}")
    res = y == x
    print(f"res = y == x: {res}")

    res = x != y
    print(f"res = x != y: {res}")
    res = y != x
    print(f"res = y != x: {res}")


def real6():
    print()
    x = XReal.T(5.0)
    print("x: ", x)
    res = x < 2.5
    print(f"res = x < 2.5: {res}")
    res = 2.5 < x
    print(f"res = 2.5 < x: {res}")

    res = x > 2.5
    print(f"res = x > 2.5: {res}")
    res = 2.5 > x
    print(f"res = 2.5 > x: {res}")

    res = x >= 2.5
    print(f"res = x >= 2.5: {res}")
    res = 2.5 >= x
    print(f"res = 2.5 >= x: {res}")

    res = x <= 2.5
    print(f"res = x <= 2.5: {res}")
    res = 2.5 <= x
    print(f"res = 2.5 <= x: {res}")

    res = x == 2.5
    print(f"res = x == 2.5: {res}")
    res = 2.5 == x
    print(f"res = 2.5 == x: {res}")

    res = x != 2.5
    print(f"res = x != 2.5: {res}")
    res = 2.5 != x
    print(f"res = 2.5 != x: {res}")

    print()
    x = XReal.T(5.0)
    print("x: ", x)
    res = x < 25
    print(f"res = x < 25: {res}")
    res = 25 < x
    print(f"res = 25 < x: {res}")

    res = x > 25
    print(f"res = x > 25: {res}")
    res = 25 > x
    print(f"res = 25 > x: {res}")

    res = x >= 25
    print(f"res = x >= 25: {res}")
    res = 25 >= x
    print(f"res = 25 >= x: {res}")

    res = x <= 25
    print(f"res = x <= 25: {res}")
    res = 25 <= x
    print(f"res = 25 <= x: {res}")

    res = x == 25
    print(f"res = x == 25: {res}")
    res = 25 == x
    print(f"res = 25 == x: {res}")

    res = x != 25
    print(f"res = x != 25: {res}")
    res = 25 != x
    print(f"res = 25 != x: {res}")

    print()
    x = XReal.T(5.0)
    print("x: ", x)
    print("i: ", i)
    res = x < i
    print(f"res = x < i: {res}")
    res = i < x
    print(f"res = i < x: {res}")

    res = x > i
    print(f"res = x > i: {res}")
    res = i > x
    print(f"res = i > x: {res}")

    res = x >= i
    print(f"res = x >= i: {res}")
    res = i >= x
    print(f"res = i >= x: {res}")

    res = x <= i
    print(f"res = x <= i: {res}")
    res = i <= x
    print(f"res = i <= x: {res}")

    res = x == i
    print(f"res = x == i: {res}")
    res = i == x
    print(f"res = i == x: {res}")

    res = x != i
    print(f"res = x != i: {res}")
    res = i != x
    print(f"res = i != x: {res}")
    
    
    

real1()
real2()
#real3()
real4()
real5()
real6()








