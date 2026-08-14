#pragma once


#ifndef MPNUMC_H_INCLUDED
#define MPNUMC_H_INCLUDED

#include <stdint.h>


typedef void* AnyPtr;

typedef const void* FuncPtr;

typedef const void* ScalarPtr;
typedef void* ScalarResPtr;
typedef void* MapPtr;

typedef void* mpNumMatrixPtr;
typedef void* GmpRandPtr;

typedef void* DblPtr;
typedef void* ExtPtr;
typedef void* QuadPtr;;



typedef void* SRealPtr;;
typedef void* SCplxPtr;;

typedef void* FRealPtr;;
typedef void* FCplxPtr;


typedef void* XRealPtr;;
typedef void* XCplxPtr;;

typedef void* QRealPtr;;
typedef void* QCplxPtr;;


typedef void* ORealPtr;;
typedef void* OCplxPtr;;


typedef void* CplxPtr;


typedef void* MpfrPtr;
typedef void* MpfcPtr;

typedef void* MpfiPtr;
typedef void* MpciPtr;


typedef void* MpdPtr;
typedef void* MpdcPtr;

typedef void* FlintRandPtr;
typedef void* FmpzPtr;
typedef void* FmpqPtr;

typedef void* ArfPtr;
typedef void* AcfPtr;

typedef void* ArbPtr;
typedef void* AcbPtr;



typedef void* YRealPtr;;
typedef void* YCplxPtr;;


typedef void* ZRealPtr;;
typedef void* ZCplxPtr;;


typedef void* FmpzMatPtr;
typedef void* FmpqMatPtr;
typedef void* ArbMatPtr;
typedef void* AcbMatPtr;

typedef void* FmpzPolyPtr;
typedef void* FmpqPolyPtr;
typedef void* ArbPolyPtr;
typedef void* AcbPolyPtr;

typedef void* FmpzPoly2Ptr;
typedef void* FmpqPoly2Ptr;
typedef void* ArbPoly2Ptr;
typedef void* AcbPoly2Ptr;
typedef void* MpfrPoly2Ptr;
typedef void* MpfrPoly2Ptr;


#define MPNUMC_DLL_IMPORTEXPORT

#ifndef _WIN32
    #define __cdecl
#endif


#ifdef _WIN32

    #if defined (BUILD_MPNUMC_DLL)
        #undef MPNUMC_DLL_IMPORTEXPORT
        #define MPNUMC_DLL_IMPORTEXPORT __declspec( dllexport )
    #elif defined (USE_MPNUMC_DLL)
        #undef MPNUMC_DLL_IMPORTEXPORT
        #define MPNUMC_DLL_IMPORTEXPORT __declspec( dllimport )
    #endif

#endif



#ifdef __cplusplus
extern "C"
{
#endif

#include "mpNumC_SReal.h"

#include "mpNumC_FReal.h"

#include "mpNumC_XReal.h"

#include "mpNumC_QReal.h"

#include "mpNumC_OReal.h"


#include "mpNumC_Mpfr.h"

#include "mpNumC_Arb.h"



#include "mpNumC_Scalar.h"




#ifdef __cplusplus
}
#endif


#endif // MPNUM_H_INCLUDED
