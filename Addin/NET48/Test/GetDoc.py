import pkgutil
import sys


def list_toplevel_modules():
    for p in pkgutil.iter_modules():
        print(p[1])


def list_callables():
    import sys
    for name, test in sys.__dict__.items():
        if callable(test):
            print(name)

def list_nounderscore():
    import sys
    for name, test in sys.__dict__.items():
        if not name.startswith('_'):
            print(name)


def getfuncnames(ctxstr):
    from mpfunlab import mpm, ivm, dec    
    if ctxstr == 'mpm': ctx = mpm
    if ctxstr == 'ivm': ctx = ivm
    if ctxstr == 'dec': ctx = dec
    rlist = dir(ctx)
    sentence = "|".join(rlist)
    print(sentence)
    


def list_ctx(ctxstr):
    from mpfunlab import mpm, ivm, dec
    from inspect import signature
    
    def getprop(ctx, ctxstr, prop):
        #s = 'type(' + ctxstr + ').' + prop
        s = 'type(ctx).' + prop
        
        return eval(s)

    if ctxstr == 'mpm': ctx = mpm
    if ctxstr == 'ivm': ctx = ivm
    if ctxstr == 'dec': ctx = dec
    
    rlist = dir(ctx)
    print(len(rlist))
    for name in rlist:
        if not (name.startswith('_') or name.endswith('_')):
            func = getattr(ctx, name)
            if callable(func):
                sig = signature(func)
                print(name, type(func), sig, func.__doc__)
            else:
                res = getprop(ctx, ctxstr, name)
                print(name, type(res) , res.__doc__)

                
#getfuncnames('mpm')

#list_toplevel_modules()

#list_callables()

#list_nounderscore()

list_ctx('mpm')

#list_ctx('ivm')

#list_ctx('dec')

#rv = mpm.dist_arcsine(0,1)
#help(rv)

