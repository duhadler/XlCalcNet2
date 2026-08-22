
#ifndef MPNUMC_FREAL_H_INCLUDED
#define MPNUMC_FREAL_H_INCLUDED




/** ********************** Real Basic Functions, double precision ******************************** **/






MPNUMC_DLL_IMPORTEXPORT double* __cdecl Lib_FReal_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Clear(double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Set_Acb(FCplxPtr res, const AcbPtr x);



/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set(double* res, const double* x);

//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Fmpq(double* res, const FmpqPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Arb(double* res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Arf(double* res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Mpfi(double* res, const MpfiPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Mpfr(double* res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Mpd(double* res, const MpdPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_CReal(double* res, const CRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_QReal(double* res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_LD(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_D(double* res, const double x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_S(double* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Si(double* res, const int32_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Ui(double* res, const uint32_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Si64(double* res, const int64_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Ui64(double* res, const uint64_t x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Get_Str(char* dest, const char* template1, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Set_Str(double* res, const char * str);

MPNUMC_DLL_IMPORTEXPORT double __cdecl Lib_FReal_Get_Double(double* x);



/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Neg(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Add(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sub(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Mul(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Div(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Add_D(double* res, const double* x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sub_D(double* res, const double* x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_D_Sub(double* res, const double* x, const double y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Mul_D(double* res, const double* x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Div_D(double* res, const double* x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_D_Div(double* res, const double* x, const double y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Add_Si(double* res, const double* x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sub_Si(double* res, const double* x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Si_Sub(double* res, const double* x, const int32_t y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Mul_Si(double* res, const double* x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Div_Si(double* res, const double* x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Si_Div(double* res, const double* x, const int32_t y);


MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FReal_LT(const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FReal_GE(const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FReal_GT(const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FReal_LE(const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FReal_EQ(const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FReal_NE(const double* x, const double* y);





/* General functions for real numbers  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Fma(double* res, const double* x, const double* y, const double* z);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Fmax(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Fmin(double* res, const double* x, const double* y);



/* Machine constants and properties of numbers  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Zero(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_NegZero(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_One(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Inf(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_NegInf(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Nan(double* res);



/* Properties of numbers  */

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Signbit(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Finite(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isinf(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isposinf(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isneginf(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isnan(const double* x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Iszero(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isposzero(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isnegzero(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isone(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isinteger(const double* x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isnumber(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isregular(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isnormal(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Issubnormal(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Isunordered(const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_FitsInt32(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_FitsInt64(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_FitsUInt32(const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_FitsUInt64(const double* x);




/* Integer Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Nearbyint(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Rint(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_FReal_Lrint(const double* x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_FReal_Llrint(const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ceil(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Floor(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Trunc(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Round(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_FReal_Lround(const double* x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_FReal_Llround(const double* x);

MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FReal_ToInt32(const double* x);
MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_FReal_ToInt64(const double* x);

MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl Lib_FReal_ToUInt32(const double* x);
MPNUMC_DLL_IMPORTEXPORT uint64_t __cdecl Lib_FReal_ToUInt64(const double* x);




/* Floating point functions for real numbers */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Copysign(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Frexp(double* res, const double* x, int* e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Logb(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_FReal_Ilogb(const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ldexp(double* res, const double* x, const int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Scalbln(double* res, const double* x, const long int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Scalbn(double* res, const double* x, const int e);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Fdim(double* res, const double* x, const double* y);


/* Fraction and Remainder Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Modf(double* frac, const double* x, double* iptr);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Fmod(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Remainder(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Remquo(double* res, const double* x, const double* y, int* e);



/* Functions related to mantissa width and exponent range (MReal, BigDecimal) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Epsilon(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ulp(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Max(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Lowest(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Min(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Nexttoward(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Nextabove(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Nextbelow(double* res, const double* x);



/* Mathematical Constants  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstDegree(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstPhi(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstLog2(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstLog10(double* res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstPi(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstE(double* res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstEulerGamma(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstApery(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstCatalan(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstGlaisher(double* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ConstKhinchin(double* res);



/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Fabs(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sign(double* res, const double* x);



/* Roots and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sqrt(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sqrt1pm1(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Rsqrt(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Cbrt(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Root_Si(double* res, const double* x, const int32_t k);



/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Exp(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Exp2(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Exp10(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Expm1(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Exp2m1(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Exp10m1(double* res, const double* x);


/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Log(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Log2(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Log10(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Log1p(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Log2p1(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Log10p1(double* res, const double* x);



/* Power functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Square(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Cube(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hypot(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Pow(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Powm1(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Pow1p(double* res, const double* x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Pow1pm1(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Pow_Si(double* res, const double* x, const int32_t n);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Compound_Si(double* res, const double* x, const int32_t n);



/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sin(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Cos(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Cosm1(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Tan(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Csc(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sec(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Cot(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SinPi(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_CosPi(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TanPi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_CscPi(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SecPi(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_CotPi(double* res, const double* x);



/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sinh(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Cosh(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Tanh(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Csch(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sech(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Coth(double* res, const double* x);



/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Asin(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Acos(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Atan(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Atan2(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Acsc(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Asec(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Acot(double* res, const double* x);


/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Asinh(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Acosh(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Atanh(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Acsch(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Asech(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Acoth(double* res, const double* x);



/* Special functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erf(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erfc(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Tgamma(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Lgamma(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJ0(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJ1(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJn(double* res, const double* n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselY0(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselY1(double* res, const double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselYn(double* res, const double* n, const double* x);




/** ********************** Complex Basic Functions, double precision ******************************** **/





MPNUMC_DLL_IMPORTEXPORT FCplxPtr __cdecl Lib_FCplx_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Clear(FCplxPtr x);


/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Set(FCplxPtr res, const FCplxPtr x);


/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Neg(FCplxPtr res, const FCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Add(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sub(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Mul(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Div(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Add_FReal(FCplxPtr res, const FCplxPtr x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sub_FReal(FCplxPtr res, const FCplxPtr x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_FReal_Sub(FCplxPtr res, const FCplxPtr y, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Mul_FReal(FCplxPtr res, const FCplxPtr x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Div_FReal(FCplxPtr res, const FCplxPtr x, const double* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_FReal_Div(FCplxPtr res, const FCplxPtr y, const double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Add_D(FCplxPtr res, const FCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sub_D(FCplxPtr res, const FCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_D_Sub(FCplxPtr res, const FCplxPtr y, const double x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Mul_D(FCplxPtr res, const FCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Div_D(FCplxPtr res, const FCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_D_Div(FCplxPtr res, const FCplxPtr y, const double x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Add_Si(FCplxPtr res, const FCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sub_Si(FCplxPtr res, const FCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Si_Sub(FCplxPtr res, const FCplxPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Mul_Si(FCplxPtr res, const FCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Div_Si(FCplxPtr res, const FCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Si_Div(FCplxPtr res, const FCplxPtr y, const int32_t x);




/* Floating point functions for real numbers  */

/* Integer and Remainder Related Functions  */

/* Machine constants and properties of numbers  */

/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Set_Real(FCplxPtr res, const double* re);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Set2(FCplxPtr res, const double* re, const double* im);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Abs(double* res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Arg(double* res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Imag(double* res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Real(double* res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Conj(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Proj(FCplxPtr res, const FCplxPtr x);




/* Roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sqrt(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sqrt1pm1(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Rsqrt(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Cbrt(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Root_Si(FCplxPtr res, const FCplxPtr x, const int32_t k);



/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Exp(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Exp2(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Exp10(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Expm1(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Exp2m1(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Exp10m1(FCplxPtr res, const FCplxPtr x);



/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Log(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Log2(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Log10(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Log1p(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Log2p1(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Log10p1(FCplxPtr res, const FCplxPtr x);




/* Power functions and roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Square(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Cube(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Pow(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Powm1(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Pow1p(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Pow1pm1(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Pow_Si(FCplxPtr res, const FCplxPtr x, const int32_t k);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Compound_Si(FCplxPtr res, const FCplxPtr x, const int32_t k);



/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sin(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Cos(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Tan(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Csc(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sec(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Cot(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_SinPi(FCplxPtr res, const FCplxPtr x); /* TODO */
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_CosPi(FCplxPtr res, const FCplxPtr x); /* TODO */
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_TanPi(FCplxPtr res, const FCplxPtr x); /* TODO */


/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sinh(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Cosh(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Tanh(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Csch(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Sech(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Coth(FCplxPtr res, const FCplxPtr x);


/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Asin(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acos(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Atan(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acsc(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Asec(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acot(FCplxPtr res, const FCplxPtr x);



/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Asinh(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acosh(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Atanh(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acsch(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Asech(FCplxPtr res, const FCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acoth(FCplxPtr res, const FCplxPtr x);





















//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// FReal_Arb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Sqrt(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Rsqrt(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Cbrt(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Sqrt1pm1(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Root_ui(double* res, const double* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Root_si(double* res, const double* x, const int32_t n);



/* Exponential and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Exp(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Exp10(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Exp2(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Expm1(double* res, const double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Exp10m1(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Exp2m1(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_ExpRel(double* res, const double* x);





/* Logarithms and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Logbase(double* res, const double* x, const double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Log(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Log10(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Log2(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Log1p(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Log10p1(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Log2p1(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Log1mexp(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LambertW0(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LambertWm1(double* res, const double* x);





/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Square(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Cube(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hypot(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Pow_ui(double* res, const double* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Pow_si(double* res, const double* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Compound_si(double* res, const double* x, const int32_t n);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Pow(double* res, const double* x, const double* y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Powm1(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Pow1p(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Pow1pm1(double* res, const double* x, const double* y);



/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Sin(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Cos(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Tan(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Cot(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Csc(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Sec(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Sinc(double* res, const double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_SinPi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_CosPi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_TanPi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_CotPi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_SincPi(double* res, const double* x);


/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Sinh(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Cosh(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Tanh(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Coth(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Csch(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Sech(double* res, const double* x);




/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Asin(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Acos(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Atan2(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Atan(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Acot(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Acsc(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Asec(double* res, const double* x);




/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Asinh(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Acosh(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Atanh(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Acoth(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Acsch(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Asech(double* res, const double* x);





/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_MEllipticK(double* res, const double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_MEllipticE(double* res, const double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_MEllipticPi(double* res, const double* n, const double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_MEllipticF(double* res, const double* phi, const double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_MEllipticEInc(double* res, const double* phi, const double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_MEllipticPiInc(double* res, const double* n, const double* phi, const double* m);



/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_EllipticK(double* res, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_EllipticE(double* res, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_EllipticPi(double* res, const double* n, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_EllipticF(double* res, const double* phi, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_EllipticEInc(double* res, const double* phi, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_EllipticPiInc(double* res, const double* n, const double* phi, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Agm(double* res, const double* x, const double* y);



/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Elliptic_RC(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Elliptic_RF(double* res, const double* x, const double* y, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Elliptic_RG(double* res, const double* x, const double* y, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Elliptic_RD(double* res, const double* x, const double* y, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Elliptic_RJ(double* res, const double* x, const double* y, const double* z, const double* w);




/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Theta1Q(double* res, const double* z, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Theta2Q(double* res, const double* z, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Theta3Q(double* res, const double* z, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Theta4Q(double* res, const double* z, const double* q);



/* Jacobi elliptic functions */



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiSN(double* res, const double* u, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiCN(double* res, const double* u, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiDN(double* res, const double* u, const double* k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiNS(double* res, const double* u, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiNC(double* res, const double* u, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiND(double* res, const double* u, const double* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiSC(double* res, const double* u, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiSD(double* res, const double* u, const double* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiDC(double* res, const double* u, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiDS(double* res, const double* u, const double* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiCS(double* res, const double* u, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiCD(double* res, const double* u, const double* k);







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LerchPhi(double* res, const double* z, const double* s, const double* a);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Polygamma(double* res, const double* s, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Digamma(double* res, const double* x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Polylog(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Dilog(double* res, const double* x);





/* Hurwitz zeta function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_HurwitzZeta(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Bernoulli_ui(double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BernoulliPoly_ui(double* res, const double* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Euler_ui(double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BarnesG(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LogBarnesG(double* res, const double* x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Zeta(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BacklundS(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_GramPoint_ui(double* res, const int32_t n);




/* Additional numbertheoretic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Bell_ui(double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Partitions_ui(double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Primorial_ui(double* res, const int32_t n);





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hypgeom0F1(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hypgeom0F1r(double* res, const double* x, const double* y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BesselJ(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BesselY(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BesselI(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BesselK(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BesselIScaled(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BesselKScaled(double* res, const double* x, const double* y);



/* Spherical Bessel functions  */




/* Airy functions  */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_AiryAi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_AiryAiPrime(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_AiryBi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_AiryBiPrime(double* res, const double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_AiryAiZero(double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_AiryAiPrimeZero(double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_AiryBiZero(double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_AiryBiPrimeZero(double* res, const int32_t n);



/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hypgeom1F1(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hypgeom1F1r(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_HypgeomU(double* res, const double* a, const double* b, const double* z);




/* Gamma function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Gamma(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Rgamma(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Lgamma(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_RisingFactorial(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Beta(double* res, const double* x, const double* y);



/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_GammaUpper(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_GammaQ(double* res, const double* x, const double* y);

// Missing: Tricomi

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_GammaLower(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_GammaP(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_GammaPPrime(double* res, const double* x, const double* y);



/* Error function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Erf(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Erfc(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_ErfInv(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_ErfcInv(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Erfi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_FresnelC(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_FresnelS(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Ndens(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Ndis(double* res, const double* x);





/* Exponential integrals and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_ExpIntegralE(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_ExpIntegralEi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_SinIntegral(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_CosIntegral(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_SinhIntegral(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_CoshIntegral(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LogIntegral(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LogIntegralOffset(double* res, const double* x);



/* 1F1: Orthogonal polynomials */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_HermiteH(double* res, const double* x, const double* y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LaguerreL(double* res, const double* a, const double* b, const double* z);




/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_CoulombF(double* res, const double* l, const double* eta, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_CoulombG(double* res, const double* l, const double* eta, const double* z);




/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hyp2f1(double* res, const double* a, const double* b, const double* c, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hyp2f1r(double* res, const double* a, const double* b, const double* c, const double* z);





/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_ChebyshevT(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_ChebyshevU(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_GegenbauerC(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_JacobiP(double* res, const double* a, const double* b, const double* c, const double* z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LegendreP(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LegendrePv(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LegendreQ(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_LegendreQv(double* res, const double* a, const double* b, const double* z);




/* 2F1: Incomplete Beta Function */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_BetaLower(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Ibeta(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Ibetac(double* res, const double* a, const double* b, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_IbetaPrime(double* res, const double* a, const double* b, const double* z);




/* Hypergeometric Function 1F2, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hypgeom1F2(double* res, const double* a, const double* b, const double* c, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Arb_Hypgeom1F2r(double* res, const double* a, const double* b, const double* c, const double* z);














//////////////////////////////////////////////////////
//// FCplx_Acb functions
//////////////////////////////////////////////////////




/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Sqrt(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Rsqrt(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Cbrt(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Sqrt1pm1(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_UnitRoot_ui(FCplxPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Root_ui(FCplxPtr res, const FCplxPtr x, const int32_t n);




/* Exponential and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Exp(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Expj(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Expjpi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Exp10(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Exp2(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Expm1(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Exp10m1(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Exp2m1(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ExpRel(FCplxPtr res, const FCplxPtr x);





/* Logarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Logbase(FCplxPtr res, const FCplxPtr x, const FCplxPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Log(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Log10(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Log2(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Log1p(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Log10p1(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Log2p1(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LambertW_ui(FCplxPtr res, const FCplxPtr x, const int32_t n);




/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Square(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Cube(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypot(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Pow_si(FCplxPtr res, const FCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Pow(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Powm1(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Pow1p(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Pow1pm1(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);





/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Sin(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Cos(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Tan(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Csc(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Sec(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Cot(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Sinc(FCplxPtr res, const FCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_SinPi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CosPi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_TanPi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CotPi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CscPi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_SecPi(FCplxPtr res, const FCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_SincPi(FCplxPtr res, const FCplxPtr x);






/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Sinh(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Cosh(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Tanh(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Csch(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Sech(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Coth(FCplxPtr res, const FCplxPtr x);





/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Asin(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Acos(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Atan(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Acsc(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Asec(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Acot(FCplxPtr res, const FCplxPtr x);





/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Asinh(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Acosh(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Atanh(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Acsch(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Asech(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Acoth(FCplxPtr res, const FCplxPtr x);








/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_MEllipticK(FCplxPtr res, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_MEllipticE(FCplxPtr res, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_MEllipticPi(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_MEllipticF(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_MEllipticEInc(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_MEllipticPiInc(FCplxPtr res, const FCplxPtr n, const FCplxPtr phi, const FCplxPtr m);




/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticK(FCplxPtr res, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticE(FCplxPtr res, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticPi(FCplxPtr res, const FCplxPtr phi, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticF(FCplxPtr res, const FCplxPtr phi, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticEInc(FCplxPtr res, const FCplxPtr phi, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticPiInc(FCplxPtr res, const FCplxPtr n, const FCplxPtr phi, const FCplxPtr k);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Agm(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);




/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Elliptic_RC(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Elliptic_RF(FCplxPtr res, const FCplxPtr x, const FCplxPtr y, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Elliptic_RG(FCplxPtr res, const FCplxPtr x, const FCplxPtr y, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Elliptic_RD(FCplxPtr res, const FCplxPtr x, const FCplxPtr y, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Elliptic_RJ(FCplxPtr res, const FCplxPtr x, const FCplxPtr y, const FCplxPtr z, const FCplxPtr w);





/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Theta1Q(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Theta2Q(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Theta3Q(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Theta4Q(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Theta1Tau(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Theta2Tau(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Theta3Tau(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Theta4Tau(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m);




/* Jacobi elliptic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_QfromK(FCplxPtr res, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_TfromUQ(FCplxPtr res, const FCplxPtr u, const FCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_SnTQ(FCplxPtr res, const FCplxPtr t, const FCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CnTQ(FCplxPtr res, const FCplxPtr t, const FCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_DnTQ(FCplxPtr res, const FCplxPtr t, const FCplxPtr q);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiSN(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiCN(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiDN(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiNS(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiNC(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiND(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiSC(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiSD(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiDC(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiDS(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiCS(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiCD(FCplxPtr res, const FCplxPtr u, const FCplxPtr k);






/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_WeierstrassP(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_WeierstrassPInv(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_WeierstrassPZeta(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_WeierstrassPSigma(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_WeierstrassPPrime(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticInvariantG2(FCplxPtr res, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticInvariantG3(FCplxPtr res, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticRootE1(FCplxPtr res, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticRootE2(FCplxPtr res, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EllipticRootE3(FCplxPtr res, const FCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_DedekindEta(FCplxPtr res, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_KleinJ(FCplxPtr res, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ModularLambda(FCplxPtr res, const FCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ModularDelta(FCplxPtr res, const FCplxPtr tau);





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LerchPhi(FCplxPtr res, const FCplxPtr z, const FCplxPtr s, const FCplxPtr a);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LerchZeta(FCplxPtr res, const FCplxPtr lambda1, const FCplxPtr alpha, const FCplxPtr s);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Polygamma(FCplxPtr res, const FCplxPtr s, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Trigamma(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Digamma(FCplxPtr res, const FCplxPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Polylog(FCplxPtr res, const FCplxPtr s, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Trilog(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Dilog(FCplxPtr res, const FCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ClausenSin(FCplxPtr res, const FCplxPtr s, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ClausenCos(FCplxPtr res, const FCplxPtr s, const FCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Clausen2(FCplxPtr res, const FCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BoseEinstein(FCplxPtr res, const FCplxPtr s, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_FermiDirac(FCplxPtr res, const FCplxPtr s, const FCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LegendreChi(FCplxPtr res, const FCplxPtr s, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_InverseTanIntegral(FCplxPtr res, const FCplxPtr s, const FCplxPtr z);





/* Hurwitz zeta function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_HurwitzZeta(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Stieltjes_ui(FCplxPtr res, const FCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BernoulliPoly_ui(FCplxPtr res, const FCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Harmonic(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Harmonic2(FCplxPtr res, const FCplxPtr z, const FCplxPtr r);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_EulerPoly_ui(FCplxPtr res, const FCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hyperfactorial(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Superfactorial(FCplxPtr res, const FCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BarnesG(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LogBarnesG(FCplxPtr res, const FCplxPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Zeta(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Zetam1(FCplxPtr res, const FCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_DirichletXi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_DirichletEta(FCplxPtr res, const FCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_DirichletEtam1(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_DirichletBeta(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_DirichletLambda(FCplxPtr res, const FCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_HardyZ(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_HardyTheta(FCplxPtr res, const FCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ZetaZero_ui(FCplxPtr res, const int32_t n);



/* Additional numbertheoretic functions */





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypgeom0F1(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypgeom0F1r(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BesselJ(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BesselY(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BesselI(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BesselK(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BesselIScaled(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BesselKScaled(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);





/* Spherical Bessel functions  */



/* Airy functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_AiryAi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_AiryAiPrime(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_AiryBi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_AiryBiPrime(FCplxPtr res, const FCplxPtr x);




/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_HypgeomU(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypgeom1F1(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypgeom1F1r(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);






/* Gamma function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Gamma(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Rgamma(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Lgamma(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_RisingFactorial(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Beta(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);




/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_GammaUpper(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_GammaLower(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_GammaPPrime(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_GammaP(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_GammaQ(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);





/* Error function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Erf(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Erfc(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Erfi(FCplxPtr res, const FCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_FresnelC(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_FresnelS(FCplxPtr res, const FCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Ndens(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Ndis(FCplxPtr res, const FCplxPtr x);




/* Exponential integrals and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ExpIntegralE(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ExpIntegralEi(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_SinIntegral(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CosIntegral(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_SinhIntegral(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CoshIntegral(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LogIntegral(FCplxPtr res, const FCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LogIntegralOffset(FCplxPtr res, const FCplxPtr x);





/* 1F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_HermiteH(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LaguerreL(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);






/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CoulombF(FCplxPtr res, const FCplxPtr l, const FCplxPtr eta, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CoulombG(FCplxPtr res, const FCplxPtr l, const FCplxPtr eta, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CoulombHpos(FCplxPtr res, const FCplxPtr l, const FCplxPtr eta, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_CoulombHneg(FCplxPtr res, const FCplxPtr l, const FCplxPtr eta, const FCplxPtr z);






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypgeom2F1(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr c, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypgeom2F1r(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr c, const FCplxPtr z);




/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ChebyshevT(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_ChebyshevU(FCplxPtr res, const FCplxPtr x, const FCplxPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_GegenbauerC(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_JacobiP(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr c, const FCplxPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LegendreP(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LegendrePv(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LegendreQ(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_LegendreQv(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_SphericalY(FCplxPtr res, const FCplxPtr n, const FCplxPtr m, const FCplxPtr theta, const FCplxPtr phi);





/* 2F1: Incomplete Beta Function */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_BetaLower(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Ibeta(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Ibetac(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_IbetaPrime(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z);





/* Hypergeometric Function 1F2, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypgeom1F2(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr c, const FCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FCplx_Acb_Hypgeom1F2r(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr c, const FCplxPtr z);







//
//
//
////*********************** Boost Special functions , double precision **********************************
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BernoulliB2n(double* res, const int n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TangentT2n(double* res, const int n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sqrt1pm1_Boost(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SinPi_Boost(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_CosPi_Boost(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SincPi(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SinhcPi(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Tgamma_(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Tgamma1pm1(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Digamma(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Lgamma_(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Trigamma(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Factorial(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_DoubleFactorial(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erf_(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erfc_(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erf_inv(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erfc_inv(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_AiryAi(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_AiryBi(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_AiryAiPrime(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_AiryBiPrime(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Aizero(double* res, const int n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Bizero(double* res, const int n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint_1_K(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint_2_K(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Zeta(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ei(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LambertW0(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LambertWm1(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LambertW0Prime(double* res, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LambertWm1Prime(double* res, const double* x);
//
//
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Powm1_Boost(double* res, const double* a, const double* b);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TgammaRatio(double* res, const double* a, const double* b);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TgammaDeltaRatio(double* res, const double* a, const double* b);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Binomial(double* res, const double* n, const double* k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_RisingFactorial(double* res, const double* x, const double* n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_FallingFactorial(double* res, const double* x, const double* n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJ(double* res, const double* v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselY(double* res, const double* v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselI(double* res, const double* v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselK(double* res, const double* v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphBessel(double* res, const unsigned v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphNeumann(double* res, const unsigned v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJPrime(double* res, const double* v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselYPrime(double* res, const double* v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselIPrime(double* res, const double* v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselKPrime(double* res, const double* v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphBesselPrime(double* res, const unsigned v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphNeumannPrime(double* res, const unsigned v, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJZero(double* res, const double* v, const int m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselYZero(double* res, const double* v, const int m);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaP(double* res, const double* a, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaQ(double* res, const double* a, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TgammaLower(double* res, const double* a, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TgammaUpper(double* res, const double* a, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaPInv(double* res, const double* a, const double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaQInv(double* res, const double* a, const double* q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaPInva(double* res, const double* x, const double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaQInva(double* res, const double* x, const double* q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaPDerivative(double* res, const double* a, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Beta(double* res, const double* a, const double* b);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LegendreP(double* res, int n, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LegendreQ(double* res, int n, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Laguerre(double* res, int n, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hermite(double* res, int n, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ChebyshevT(double* res, int n, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ChebyshevU(double* res, int n, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Polygamma(double* res, int n, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_EllintRC(double* res, const double* x, const double* y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint1F(double* res, const double* k, const double* phi);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint2F(double* res, const double* k, const double* phi);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint3K(double* res, const double* k, const double* n);
//
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiCD(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiCN(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiCS(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiDC(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiDN(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiDS(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiNC(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiND(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiNS(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiSC(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiSD(double* res, const double* k, const double* u);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiSN(double* res, const double* k, const double* u);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_expint(double* res, const unsigned n, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_OwenT(double* res, const double* h, const double* a);
//
//
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBeta(double* res, const double* a, const double* b, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetac(double* res, const double* a, const double* b, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaNonNormalized(double* res, const double* a, const double* b, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetacNonNormalized(double* res, const double* a, const double* b, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaInv(double* res, const double* a, const double* b, const double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetacInv(double* res, const double* a, const double* b, const double* q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaInva(double* res, const double* b, const double* x, const double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetacInva(double* res, const double* b, const double* x, const double* q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaInvb(double* res, const double* a, const double* x, const double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetacInvb(double* res, const double* a, const double* x, const double* q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaDerivative(double* res, const double* a, const double* b, const double* x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LegendrePM(double* res, const int n, const int m, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LaguerreM(double* res, const int n, const int m, const double* x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_EllipticRF(double* res, const double* x, const double* y, const double* z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_EllipticRD(double* res, const double* x, const double* y, const double* z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint3F(double* res, const double* k, const double* n, const double* phi);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphericalHarmonicR(double* res, const int n, const int m, const double* theta, const double* phi);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphericalHarmonicI(double* res, const int n, const int m, const double* theta, const double* phi);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_EllipticRJ(double* res, const double* x, const double* y, const double* z, const double* p);
//
//
//
//// Hypergeometric and Theta Functions
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hypergeo0F1(double* res, const double* b, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hypergeo1F1(double* res, const double* a, const double* b, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hypergeo1F1r(double* res, const double* a, const double* b, const double* x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LogHypergeo1F1(double* res, const double* a, const double* b, const double* x);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiTheta1(double* res, const double* x, const double* q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiTheta2(double* res, const double* x, const double* q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiTheta3(double* res, const double* x, const double* q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiTheta4(double* res, const double* x, const double* q);
//
//
//
//
//
//
////*********************** Boost Distributions, double precision **********************************
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ArcsineDist(long Target, double* res, double* xqp, double* a, double* b);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BernoulliDist(long Target, double* res, double* xqp, double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BetaDist(long Target, double* res, double* xqp, double* a, double* b);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BinomialDist(long Target, double* res, double* xqp, double* n, double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_CauchyDist(long Target, double* res, double* x, double* location, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Chi2Dist(long Target, double* res, double* xqp, double* nu);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ExponentialDist(long Target, double* res, double* xqp, double* lambda);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GumbelDist(long Target, double* res, double* xqp, double* location, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_FisherFDist(long Target, double* res, double* xqp, double* mu, double* nu);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaDist(long Target, double* res, double* xqp, double* shape, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GeometricDist(long Target, double* res, double* xqp, double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_HypergeometricDist(long Target, double* res, double* x, unsigned r, unsigned n, unsigned N);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_InverseChi2Dist(long Target, double* res, double* xqp, double* df, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_InverseGammaDist(long Target, double* res, double* xqp, double* shape, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_WaldDist(long Target, double* res, double* xqp, double* mean_, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LaplaceDist(long Target, double* res, double* xqp, double* location, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LogisticDist(long Target, double* res, double* xqp, double* location, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LognormalDist(long Target, double* res, double* xqp, double* location, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_NegBinomialDist(long Target, double* res, double* xqp, double* n, double* p);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Chi2NcDist(long Target, double* res, double* xqp, double* nu, double* nc);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_StudentTNcDist(long Target, double* res, double* xqp, double* nu, double* delta);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_FisherNcDist(long Target, double* res, double* xqp, double* mu, double* nu, double* nc);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BetaNcDist(long Target, double* res, double* xqp, double* a, double* b, double* nc);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_NormalDist(long Target, double* res, double* xqp, double* mean_, double* stdev);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ParetoDist(long Target, double* res, double* xqp, double* shape, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_PoissonDist(long Target, double* res, double* xqp, double* nu);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_RayleighDist(long Target, double* res, double* xqp, double* nu);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SkewNormalDist(long Target, double* res, double* xqp, double* mean_, double* scale, double* shape);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_StudentTDist(long Target, double* res, double* xqp, double* nu);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TriangularDist(long Target, double* res, double* xqp, double* lower, double* mode_, double* upper);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_WeibullDist(long Target, double* res, double* xqp, double* shape, double* scale);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_UniformDist(long Target, double* res, double* xqp, double* lower, double* upper);
//
//
//
//



//*********************** Boost Odeint, double precision **********************************

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Const_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Const_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Const_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Adaptive_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Adaptive_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Adaptive_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel);







//*********************** Boost Numerical Calculus, double precision **********************************


typedef void(*FRealFuncPtr) (void*, void*);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BracketRoot(double* res1, double* res2, int* iter, FRealFuncPtr f1, double* guess, double* factor, bool is_rising, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_NewtonRaphson(double* res,  int* iter, FRealFuncPtr f1, FRealFuncPtr f2, double* guess, double* xmin, double* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Halley(double* res,  int* iter, FRealFuncPtr f1, FRealFuncPtr f2, FRealFuncPtr f3, double* guess, double* xmin, double* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Schroder(double* res,  int* iter, FRealFuncPtr f1, FRealFuncPtr f2, FRealFuncPtr f3, double* guess, double* xmin, double* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Brent_Minimum(double* res, double* resFx, int* iter, FRealFuncPtr f1, double* bracket_min, double* bracket_max, int bits, unsigned int maxit);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Trapezoidal(double* res1, double* res2, double* res3, FRealFuncPtr f1, double* a, double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GaussLegendre(double* res1, double* res3, FRealFuncPtr f1, double* a, double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GaussKronrod(double* res1, double* res2, double* res3, FRealFuncPtr f1, double* a, double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TanhSinh(double* res1, double* res2, double* res3, int* levels_, FRealFuncPtr f1, double* a, double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SinhSinh(double* res1, double* res2, double* res3, int* levels_, FRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ExpSinh(double* res1, double* res2, double* res3, int* levels_, FRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ooura_Cos(double* res1, double* res2, FRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ooura_Sin(double* res1, double* res2, FRealFuncPtr f1);























#endif // MPNUMC_FREAL_H_INCLUDED



