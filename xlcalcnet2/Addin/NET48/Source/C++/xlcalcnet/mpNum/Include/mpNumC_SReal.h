
#ifndef MPNUMC_SREAL_H_INCLUDED
#define MPNUMC_SREAL_H_INCLUDED




/** ********************** Real Basic Functions, single precision ******************************** **/






MPNUMC_DLL_IMPORTEXPORT float* __cdecl Lib_SReal_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Clear(float* x);



/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Fmpq(float* res, const FmpqPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Arb(float* res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Arf(float* res, const ArfPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Mpfi(float* res, const MpfiPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Mpfr(float* res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Mpd(float* res, const MpdPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_CReal(float* res, const CRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_QReal(float* res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_LD(float* res, const long double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_D(float* res, const double x);
/* Missing: Lib_SReal_Set_D */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Si(float* res, const int32_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Ui(float* res, const uint32_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Si64(float* res, const int64_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Ui64(float* res, const uint64_t x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Get_Str(char * dest, const char* template1, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Set_Str(float* res, const char * str);

MPNUMC_DLL_IMPORTEXPORT float __cdecl Lib_SReal_Get_Single(float* x);



/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Neg(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Add(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sub(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Mul(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Div(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Add_D(float* res, const float* x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sub_D(float* res, const float* x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_D_Sub(float* res, const float* x, const double y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Mul_D(float* res, const float* x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Div_D(float* res, const float* x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_D_Div(float* res, const float* x, const double y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Add_Si(float* res, const float* x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sub_Si(float* res, const float* x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Si_Sub(float* res, const float* x, const int32_t y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Mul_Si(float* res, const float* x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Div_Si(float* res, const float* x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Si_Div(float* res, const float* x, const int32_t y);


MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_SReal_LT(const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_SReal_GE(const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_SReal_GT(const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_SReal_LE(const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_SReal_EQ(const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_SReal_NE(const float* x, const float* y);





/* General functions for real numbers  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Fma(float* res, const float* x, const float* y, const float* z);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Fmax(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Fmin(float* res, const float* x, const float* y);



/* Machine constants */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Zero(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_NegZero(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_One(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Inf(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_NegInf(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Nan(float* res);



/* Properties of numbers  */

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Signbit(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Finite(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isinf(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isposinf(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isneginf(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isnan(const float* x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Iszero(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isposzero(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isnegzero(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isone(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isinteger(const float* x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isnumber(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isregular(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isnormal(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Issubnormal(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Isunordered(const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_FitsInt32(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_FitsInt64(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_FitsUInt32(const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_FitsUInt64(const float* x);



/* Integer Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Nearbyint(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Rint(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_SReal_Lrint(const float* x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_SReal_Llrint(const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ceil(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Floor(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Trunc(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Round(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_SReal_Lround(const float* x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_SReal_Llround(const float* x);

MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_SReal_ToInt32(const float* x);
MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_SReal_ToInt64(const float* x);

MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl Lib_SReal_ToUInt32(const float* x);
MPNUMC_DLL_IMPORTEXPORT uint64_t __cdecl Lib_SReal_ToUInt64(const float* x);




/* Floating point functions for real numbers */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Copysign(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Frexp(float* res, const float* x, int* e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Logb(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_SReal_Ilogb(const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ldexp(float* res, const float* x, const int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Scalbln(float* res, const float* x, const long int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Scalbn(float* res, const float* x, const int e);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Fdim(float* res, const float* x, const float* y);


/* Fraction and Remainder Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Modf(float* frac, const float* x, float* iptr);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Fmod(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Remainder(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Remquo(float* res, const float* x, const float* y, int* e);



/* Functions related to mantissa width and exponent range */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Epsilon(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ulp(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Max(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Lowest(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Min(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Nexttoward(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Nextabove(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Nextbelow(float* res, const float* x);




/* Mathematical Constants  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstDegree(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstPhi(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstLog2(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstLog10(float* res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstPi(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstE(float* res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstEulerGamma(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstApery(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstCatalan(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstGlaisher(float* res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ConstKhinchin(float* res);





/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Fabs(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sign(float* res, const float* x);




/* Roots and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sqrt(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sqrt1pm1(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Rsqrt(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Cbrt(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Root_Si(float* res, const float* x, const int32_t k);



/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Exp(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Exp2(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Exp10(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Expm1(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Exp2m1(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Exp10m1(float* res, const float* x);



/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Log(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Log2(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Log10(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Log1p(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Log2p1(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Log10p1(float* res, const float* x);



/* Power functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Square(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Cube(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Hypot(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Pow(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Powm1(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Pow1p(float* res, const float* x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Pow1pm1(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Pow_Si(float* res, const float* x, const int32_t n);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Compound_Si(float* res, const float* x, const int32_t n);



/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sin(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Cos(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Cosm1(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Tan(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Csc(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sec(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Cot(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SinPi(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_CosPi(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_TanPi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_CscPi(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SecPi(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_CotPi(float* res, const float* x);



/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sinh(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Cosh(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Tanh(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Csch(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sech(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Coth(float* res, const float* x);



/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Asin(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Acos(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Atan(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Atan2(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Acsc(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Asec(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Acot(float* res, const float* x);


/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Asinh(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Acosh(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Atanh(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Acsch(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Asech(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Acoth(float* res, const float* x);



/* Special functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Erf(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Erfc(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Tgamma(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Lgamma(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselJ0(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselJ1(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselJn(float* res, const float* n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselY0(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselY1(float* res, const float* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselYn(float* res, const float* n, const float* x);









/** ********************** Complex Basic Functions, single precision ******************************** **/


MPNUMC_DLL_IMPORTEXPORT SCplxPtr __cdecl Lib_SCplx_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Clear(SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Set_Acb(SCplxPtr res, const AcbPtr x);




/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Set(SCplxPtr res, const SCplxPtr x);


/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Neg(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Add(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sub(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Mul(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Div(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Add_SReal(SCplxPtr res, const SCplxPtr x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sub_SReal(SCplxPtr res, const SCplxPtr x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_SReal_Sub(SCplxPtr res, const SCplxPtr y, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Mul_SReal(SCplxPtr res, const SCplxPtr x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Div_SReal(SCplxPtr res, const SCplxPtr x, const float* y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_SReal_Div(SCplxPtr res, const SCplxPtr y, const float* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Add_D(SCplxPtr res, const SCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sub_D(SCplxPtr res, const SCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_D_Sub(SCplxPtr res, const SCplxPtr y, const double x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Mul_D(SCplxPtr res, const SCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Div_D(SCplxPtr res, const SCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_D_Div(SCplxPtr res, const SCplxPtr y, const double x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Add_Si(SCplxPtr res, const SCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sub_Si(SCplxPtr res, const SCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Si_Sub(SCplxPtr res, const SCplxPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Mul_Si(SCplxPtr res, const SCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Div_Si(SCplxPtr res, const SCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Si_Div(SCplxPtr res, const SCplxPtr y, const int32_t x);




/* Floating point functions for real numbers  */

/* Integer and Remainder Related Functions  */

/* Machine constants and properties of numbers  */


/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Set_Real(SCplxPtr res, const float* re);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Set2(SCplxPtr res, const float* re, const float* im);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Abs(float* res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Arg(float* res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Imag(float* res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Real(float* res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Conj(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Proj(SCplxPtr res, const SCplxPtr x);




/* Roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sqrt(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sqrt1pm1(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Rsqrt(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Cbrt(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Root_Si(SCplxPtr res, const SCplxPtr x, const int32_t k);



/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Exp(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Exp2(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Exp10(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Expm1(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Exp2m1(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Exp10m1(SCplxPtr res, const SCplxPtr x);



/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Log(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Log2(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Log10(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Log1p(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Log2p1(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Log10p1(SCplxPtr res, const SCplxPtr x);




/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Square(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Cube(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Pow(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Powm1(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Pow1p(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Pow1pm1(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Pow_Si(SCplxPtr res, const SCplxPtr x, const int32_t k);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Compound_Si(SCplxPtr res, const SCplxPtr x, const int32_t k);



/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sin(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Cos(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Tan(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Csc(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sec(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Cot(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_SinPi(SCplxPtr res, const SCplxPtr x); /* TODO */
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_CosPi(SCplxPtr res, const SCplxPtr x); /* TODO */
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_TanPi(SCplxPtr res, const SCplxPtr x); /* TODO */


/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sinh(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Cosh(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Tanh(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Csch(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Sech(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Coth(SCplxPtr res, const SCplxPtr x);


/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Asin(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acos(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Atan(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acsc(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Asec(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acot(SCplxPtr res, const SCplxPtr x);



/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Asinh(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acosh(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Atanh(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acsch(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Asech(SCplxPtr res, const SCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acoth(SCplxPtr res, const SCplxPtr x);



































//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Sqrt(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Rsqrt(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Cbrt(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Sqrt1pm1(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Root_ui(float* res, const float* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Root_si(float* res, const float* x, const int32_t n);



/* Exponential and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Exp(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Exp10(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Exp2(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Expm1(float* res, const float* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Exp10m1(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Exp2m1(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_ExpRel(float* res, const float* x);





/* Logarithms and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Logbase(float* res, const float* x, const float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Log(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Log10(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Log2(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Log1p(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Log10p1(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Log2p1(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Log1mexp(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LambertW0(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LambertWm1(float* res, const float* x);





/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Square(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Cube(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hypot(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Pow_ui(float* res, const float* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Pow_si(float* res, const float* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Compound_si(float* res, const float* x, const int32_t n);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Pow(float* res, const float* x, const float* y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Powm1(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Pow1p(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Pow1pm1(float* res, const float* x, const float* y);



/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Sin(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Cos(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Tan(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Cot(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Csc(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Sec(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Sinc(float* res, const float* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_SinPi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_CosPi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_TanPi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_CotPi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_SincPi(float* res, const float* x);


/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Sinh(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Cosh(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Tanh(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Coth(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Csch(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Sech(float* res, const float* x);




/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Asin(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Acos(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Atan2(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Atan(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Acot(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Acsc(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Asec(float* res, const float* x);




/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Asinh(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Acosh(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Atanh(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Acoth(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Acsch(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Asech(float* res, const float* x);





/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_MEllipticK(float* res, const float* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_MEllipticE(float* res, const float* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_MEllipticPi(float* res, const float* n, const float* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_MEllipticF(float* res, const float* phi, const float* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_MEllipticEInc(float* res, const float* phi, const float* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_MEllipticPiInc(float* res, const float* n, const float* phi, const float* m);



/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_EllipticK(float* res, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_EllipticE(float* res, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_EllipticPi(float* res, const float* n, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_EllipticF(float* res, const float* phi, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_EllipticEInc(float* res, const float* phi, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_EllipticPiInc(float* res, const float* n, const float* phi, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Agm(float* res, const float* x, const float* y);



/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Elliptic_RC(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Elliptic_RF(float* res, const float* x, const float* y, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Elliptic_RG(float* res, const float* x, const float* y, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Elliptic_RD(float* res, const float* x, const float* y, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Elliptic_RJ(float* res, const float* x, const float* y, const float* z, const float* w);




/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Theta1Q(float* res, const float* z, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Theta2Q(float* res, const float* z, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Theta3Q(float* res, const float* z, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Theta4Q(float* res, const float* z, const float* q);



/* Jacobi elliptic functions */



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiSN(float* res, const float* u, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiCN(float* res, const float* u, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiDN(float* res, const float* u, const float* k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiNS(float* res, const float* u, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiNC(float* res, const float* u, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiND(float* res, const float* u, const float* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiSC(float* res, const float* u, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiSD(float* res, const float* u, const float* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiDC(float* res, const float* u, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiDS(float* res, const float* u, const float* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiCS(float* res, const float* u, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiCD(float* res, const float* u, const float* k);







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LerchPhi(float* res, const float* z, const float* s, const float* a);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Polygamma(float* res, const float* s, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Digamma(float* res, const float* x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Polylog(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Dilog(float* res, const float* x);





/* Hurwitz zeta function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_HurwitzZeta(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Bernoulli_ui(float* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BernoulliPoly_ui(float* res, const float* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Euler_ui(float* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BarnesG(float*  res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LogBarnesG(float*  res, const float*  x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Zeta(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BacklundS(float*  res, const float*  x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_GramPoint_ui(float* res, const int32_t n);




/* Additional numbertheoretic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Bell_ui(float* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Partitions_ui(float* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Primorial_ui(float* res, const int32_t n);





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hypgeom0F1(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hypgeom0F1r(float* res, const float* x, const float* y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BesselJ(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BesselY(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BesselI(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BesselK(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BesselIScaled(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BesselKScaled(float* res, const float* x, const float* y);



/* Spherical Bessel functions  */




/* Airy functions  */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_AiryAi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_AiryAiPrime(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_AiryBi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_AiryBiPrime(float* res, const float* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_AiryAiZero(float* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_AiryAiPrimeZero(float* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_AiryBiZero(float* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_AiryBiPrimeZero(float* res, const int32_t n);



/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hypgeom1F1(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hypgeom1F1r(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_HypgeomU(float* res, const float* a, const float* b, const float* z);




/* Gamma function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Gamma(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Rgamma(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Lgamma(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_RisingFactorial(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Beta(float* res, const float* x, const float* y);



/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_GammaUpper(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_GammaQ(float* res, const float* x, const float* y);

// Missing: Tricomi

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_GammaLower(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_GammaP(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_GammaPPrime(float* res, const float* x, const float* y);



/* Error function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Erf(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Erfc(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_ErfInv(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_ErfcInv(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Erfi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_FresnelC(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_FresnelS(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Ndens(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Ndis(float* res, const float* x);





/* Exponential integrals and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_ExpIntegralE(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_ExpIntegralEi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_SinIntegral(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_CosIntegral(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_SinhIntegral(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_CoshIntegral(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LogIntegral(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LogIntegralOffset(float* res, const float* x);



/* 1F1: Orthogonal polynomials */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_HermiteH(float* res, const float* x, const float* y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LaguerreL(float* res, const float* a, const float* b, const float* z);




/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_CoulombF(float* res, const float* l, const float* eta, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_CoulombG(float* res, const float* l, const float* eta, const float* z);




/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hyp2f1(float* res, const float* a, const float* b, const float* c, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hyp2f1r(float* res, const float* a, const float* b, const float* c, const float* z);





/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_ChebyshevT(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_ChebyshevU(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_GegenbauerC(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_JacobiP(float* res, const float* a, const float* b, const float* c, const float* z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LegendreP(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LegendrePv(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LegendreQ(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_LegendreQv(float* res, const float* a, const float* b, const float* z);




/* 2F1: Incomplete Beta Function */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_BetaLower(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Ibeta(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Ibetac(float* res, const float* a, const float* b, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_IbetaPrime(float* res, const float* a, const float* b, const float* z);




/* Hypergeometric Function 1F2, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hypgeom1F2(float* res, const float* a, const float* b, const float* c, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Arb_Hypgeom1F2r(float* res, const float* a, const float* b, const float* c, const float* z);














//////////////////////////////////////////////////////
//// Acb functions
//////////////////////////////////////////////////////


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Exp(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Sin(SCplxPtr res, const SCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Pow(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hyp1f1(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hyp2f1(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z);




/* ********************************** */





/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Sqrt(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Rsqrt(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Cbrt(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Sqrt1pm1(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_UnitRoot_ui(SCplxPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Root_ui(SCplxPtr res, const SCplxPtr x, const int32_t n);




/* Exponential and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Exp(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Expj(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Expjpi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Exp10(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Exp2(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Expm1(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Exp10m1(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Exp2m1(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ExpRel(SCplxPtr res, const SCplxPtr x);





/* Logarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Logbase(SCplxPtr res, const SCplxPtr x, const SCplxPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Log(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Log10(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Log2(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Log1p(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Log10p1(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Log2p1(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LambertW_ui(SCplxPtr res, const SCplxPtr x, const int32_t n);




/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Square(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Cube(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypot(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Pow_si(SCplxPtr res, const SCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Pow(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Powm1(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Pow1p(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Pow1pm1(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);





/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Sin(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Cos(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Tan(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Csc(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Sec(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Cot(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Sinc(SCplxPtr res, const SCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_SinPi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CosPi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_TanPi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CotPi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CscPi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_SecPi(SCplxPtr res, const SCplxPtr x);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_SincPi(SCplxPtr res, const SCplxPtr x);






/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Sinh(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Cosh(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Tanh(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Csch(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Sech(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Coth(SCplxPtr res, const SCplxPtr x);





/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Asin(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Acos(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Atan(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Acsc(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Asec(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Acot(SCplxPtr res, const SCplxPtr x);





/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Asinh(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Acosh(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Atanh(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Acsch(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Asech(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Acoth(SCplxPtr res, const SCplxPtr x);








/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_MEllipticK(SCplxPtr res, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_MEllipticE(SCplxPtr res, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_MEllipticPi(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_MEllipticF(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_MEllipticEInc(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_MEllipticPiInc(SCplxPtr res, const SCplxPtr n, const SCplxPtr phi, const SCplxPtr m);




/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticK(SCplxPtr res, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticE(SCplxPtr res, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticPi(SCplxPtr res, const SCplxPtr phi, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticF(SCplxPtr res, const SCplxPtr phi, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticEInc(SCplxPtr res, const SCplxPtr phi, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticPiInc(SCplxPtr res, const SCplxPtr n, const SCplxPtr phi, const SCplxPtr k);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Agm(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);




/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Elliptic_RC(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Elliptic_RF(SCplxPtr res, const SCplxPtr x, const SCplxPtr y, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Elliptic_RG(SCplxPtr res, const SCplxPtr x, const SCplxPtr y, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Elliptic_RD(SCplxPtr res, const SCplxPtr x, const SCplxPtr y, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Elliptic_RJ(SCplxPtr res, const SCplxPtr x, const SCplxPtr y, const SCplxPtr z, const SCplxPtr w);





/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Theta1Q(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Theta2Q(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Theta3Q(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Theta4Q(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Theta1Tau(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Theta2Tau(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Theta3Tau(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Theta4Tau(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m);




/* Jacobi elliptic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_QfromK(SCplxPtr res, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_TfromUQ(SCplxPtr res, const SCplxPtr u, const SCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_SnTQ(SCplxPtr res, const SCplxPtr t, const SCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CnTQ(SCplxPtr res, const SCplxPtr t, const SCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_DnTQ(SCplxPtr res, const SCplxPtr t, const SCplxPtr q);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiSN(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiCN(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiDN(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiNS(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiNC(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiND(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiSC(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiSD(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiDC(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiDS(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiCS(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiCD(SCplxPtr res, const SCplxPtr u, const SCplxPtr k);






/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_WeierstrassP(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_WeierstrassPInv(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_WeierstrassPZeta(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_WeierstrassPSigma(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_WeierstrassPPrime(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticInvariantG2(SCplxPtr res, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticInvariantG3(SCplxPtr res, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticRootE1(SCplxPtr res, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticRootE2(SCplxPtr res, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EllipticRootE3(SCplxPtr res, const SCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_DedekindEta(SCplxPtr res, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_KleinJ(SCplxPtr res, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ModularLambda(SCplxPtr res, const SCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ModularDelta(SCplxPtr res, const SCplxPtr tau);





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LerchPhi(SCplxPtr res, const SCplxPtr z, const SCplxPtr s, const SCplxPtr a);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LerchZeta(SCplxPtr res, const SCplxPtr lambda1, const SCplxPtr alpha, const SCplxPtr s);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Polygamma(SCplxPtr res, const SCplxPtr s, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Trigamma(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Digamma(SCplxPtr res, const SCplxPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Polylog(SCplxPtr res, const SCplxPtr s, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Trilog(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Dilog(SCplxPtr res, const SCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ClausenSin(SCplxPtr res, const SCplxPtr s, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ClausenCos(SCplxPtr res, const SCplxPtr s, const SCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Clausen2(SCplxPtr res, const SCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BoseEinstein(SCplxPtr res, const SCplxPtr s, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_FermiDirac(SCplxPtr res, const SCplxPtr s, const SCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LegendreChi(SCplxPtr res, const SCplxPtr s, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_InverseTanIntegral(SCplxPtr res, const SCplxPtr s, const SCplxPtr z);





/* Hurwitz zeta function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_HurwitzZeta(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Stieltjes_ui(SCplxPtr res, const SCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BernoulliPoly_ui(SCplxPtr res, const SCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Harmonic(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Harmonic2(SCplxPtr res, const SCplxPtr z, const SCplxPtr r);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_EulerPoly_ui(SCplxPtr res, const SCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hyperfactorial(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Superfactorial(SCplxPtr res, const SCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BarnesG(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LogBarnesG(SCplxPtr res, const SCplxPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Zeta(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Zetam1(SCplxPtr res, const SCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_DirichletXi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_DirichletEta(SCplxPtr res, const SCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_DirichletEtam1(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_DirichletBeta(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_DirichletLambda(SCplxPtr res, const SCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_HardyZ(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_HardyTheta(SCplxPtr res, const SCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ZetaZero_ui(SCplxPtr res, const int32_t n);



/* Additional numbertheoretic functions */





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypgeom0F1(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypgeom0F1r(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BesselJ(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BesselY(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BesselI(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BesselK(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BesselIScaled(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BesselKScaled(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);





/* Spherical Bessel functions  */



/* Airy functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_AiryAi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_AiryAiPrime(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_AiryBi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_AiryBiPrime(SCplxPtr res, const SCplxPtr x);




/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_HypgeomU(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypgeom1F1(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypgeom1F1r(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);






/* Gamma function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Gamma(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Rgamma(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Lgamma(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_RisingFactorial(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Beta(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);




/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_GammaUpper(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_GammaLower(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_GammaPPrime(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_GammaP(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_GammaQ(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);





/* Error function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Erf(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Erfc(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Erfi(SCplxPtr res, const SCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_FresnelC(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_FresnelS(SCplxPtr res, const SCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Ndens(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Ndis(SCplxPtr res, const SCplxPtr x);




/* Exponential integrals and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ExpIntegralE(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ExpIntegralEi(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_SinIntegral(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CosIntegral(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_SinhIntegral(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CoshIntegral(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LogIntegral(SCplxPtr res, const SCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LogIntegralOffset(SCplxPtr res, const SCplxPtr x);





/* 1F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_HermiteH(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LaguerreL(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);






/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CoulombF(SCplxPtr res, const SCplxPtr l, const SCplxPtr eta, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CoulombG(SCplxPtr res, const SCplxPtr l, const SCplxPtr eta, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CoulombHpos(SCplxPtr res, const SCplxPtr l, const SCplxPtr eta, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_CoulombHneg(SCplxPtr res, const SCplxPtr l, const SCplxPtr eta, const SCplxPtr z);






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypgeom2F1(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypgeom2F1r(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z);




/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ChebyshevT(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_ChebyshevU(SCplxPtr res, const SCplxPtr x, const SCplxPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_GegenbauerC(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_JacobiP(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LegendreP(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LegendrePv(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LegendreQ(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_LegendreQv(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_SphericalY(SCplxPtr res, const SCplxPtr n, const SCplxPtr m, const SCplxPtr theta, const SCplxPtr phi);





/* 2F1: Incomplete Beta Function */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_BetaLower(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Ibeta(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Ibetac(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_IbetaPrime(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z);





/* Hypergeometric Function 1F2, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypgeom1F2(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SCplx_Acb_Hypgeom1F2r(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z);









//*********************** Boost Special functions , float precision **********************************


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BernoulliB2n(float* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_TangentT2n(float* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Sqrt1pm1_Boost(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SinPi_Boost(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_CosPi_Boost(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SincPi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SinhcPi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Tgamma_(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Tgamma1pm1(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Lgamma_(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Digamma(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Trigamma(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Factorial(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_DoubleFactorial(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Erf_(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Erfc_(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Erf_inv(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Erfc_inv(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_AiryAi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_AiryBi(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_AiryAiPrime(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_AiryBiPrime(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Aizero(float* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Bizero(float* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ellint_1_K(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ellint_2_K(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Zeta(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ei(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LambertW0(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LambertWm1(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LambertW0Prime(float* res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LambertWm1Prime(float* res, const float* x);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Powm1_Boost(float* res, const float* a, const float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_TgammaRatio(float* res, const float* a, const float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_TgammaDeltaRatio(float* res, const float* a, const float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Binomial(float* res, const float* n, const float* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_RisingFactorial(float* res, const float* x, const float* n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_FallingFactorial(float* res, const float* x, const float* n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselJ(float* res, const float* v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselY(float* res, const float* v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselI(float* res, const float* v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselK(float* res, const float* v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SphBessel(float* res, const unsigned v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SphNeumann(float* res, const unsigned v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselJPrime(float* res, const float* v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselYPrime(float* res, const float* v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselIPrime(float* res, const float* v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselKPrime(float* res, const float* v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SphBesselPrime(float* res, const unsigned v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SphNeumannPrime(float* res, const unsigned v, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselJZero(float* res, const float* v, const int m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BesselYZero(float* res, const float* v, const int m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GammaP(float* res, const float* a, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GammaQ(float* res, const float* a, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_TgammaLower(float* res, const float* a, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_TgammaUpper(float* res, const float* a, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GammaPInv(float* res, const float* a, const float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GammaQInv(float* res, const float* a, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GammaPInva(float* res, const float* x, const float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GammaQInva(float* res, const float* x, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GammaPDerivative(float* res, const float* a, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Beta(float* res, const float* a, const float* b);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LegendreP(float* res, int n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LegendreQ(float* res, int n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Laguerre(float* res, int n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Hermite(float* res, int n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ChebyshevT(float* res, int n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ChebyshevU(float* res, int n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Polygamma(float* res, int n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_EllintRC(float* res, const float* x, const float* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ellint1F(float* res, const float* k, const float* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ellint2F(float* res, const float* k, const float* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ellint3K(float* res, const float* k, const float* n);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiCD(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiCN(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiCS(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiDC(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiDN(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiDS(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiNC(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiND(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiNS(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiSC(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiSD(float* res, const float* k, const float* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiSN(float* res, const float* k, const float* u);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_expint(float* res, const unsigned n, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_OwenT(float* res, const float* h, const float* a);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBeta(float* res, const float* a, const float* b, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetac(float* res, const float* a, const float* b, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetaNonNormalized(float* res, const float* a, const float* b, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetacNonNormalized(float* res, const float* a, const float* b, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetaInv(float* res, const float* a, const float* b, const float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetacInv(float* res, const float* a, const float* b, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetaInva(float* res, const float* b, const float* x, const float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetacInva(float* res, const float* b, const float* x, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetaInvb(float* res, const float* a, const float* x, const float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetacInvb(float* res, const float* a, const float* x, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_IBetaDerivative(float* res, const float* a, const float* b, const float* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LegendrePM(float* res, const int n, const int m, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LaguerreM(float* res, const int n, const int m, const float* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_EllipticRF(float* res, const float* x, const float* y, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_EllipticRD(float* res, const float* x, const float* y, const float* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ellint3F(float* res, const float* k, const float* n, const float* phi);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SphericalHarmonicR(float* res, const int n, const int m, const float* theta, const float* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SphericalHarmonicI(float* res, const int n, const int m, const float* theta, const float* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_EllipticRJ(float* res, const float* x, const float* y, const float* z, const float* p);



// Hypergeometric and Theta Functions



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Hypergeo0F1(float* res, const float* b, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Hypergeo1F1(float* res, const float* a, const float* b, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Hypergeo1F1r(float* res, const float* a, const float* b, const float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LogHypergeo1F1(float* res, const float* a, const float* b, const float* x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiTheta1(float* res, const float* x, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiTheta2(float* res, const float* x, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiTheta3(float* res, const float* x, const float* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_JacobiTheta4(float* res, const float* x, const float* q);








//*********************** Boost Distributions, float precision **********************************


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ArcsineDist(long Target, float* res, float* xqp, float* a, float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BernoulliDist(long Target, float* res, float* xqp, float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BetaDist(long Target, float* res, float* xqp, float* a, float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BinomialDist(long Target, float* res, float* xqp, float* n, float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_CauchyDist(long Target, float* res, float* xqp, float* location, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Chi2Dist(long Target, float* res, float* xqp, float* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ExponentialDist(long Target, float* res, float* xqp, float* lambda);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ExtremeValueDist(long Target, float* res, float* xqp, float* location, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_FisherFDist(long Target, float* res, float* xqp, float* mu, float* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GammaDist(long Target, float* res, float* xqp, float* shape, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GeometricDist(long Target, float* res, float* xqp, float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_HypergeometricDist(long Target, float* res, float* xqp, unsigned r, unsigned n, unsigned N);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_InverseChi2Dist(long Target, float* res, float* xqp, float* df, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_InverseGammaDist(long Target, float* res, float* xqp, float* shape, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_WaldDist(long Target, float* res, float* xqp, float* mean_, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LaplaceDist(long Target, float* res, float* xqp, float* location, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LogisticDist(long Target, float* res, float* xqp, float* location, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_LognormalDist(long Target, float* res, float* xqp, float* location, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_NegBinomialDist(long Target, float* res, float* xqp, float* n, float* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Chi2NcDist(long Target, float* res, float* xqp, float* nu, float* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_StudentTNcDist(long Target, float* res, float* xqp, float* nu, float* delta);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_FisherNcDist(long Target, float* res, float* xqp, float* mu, float* nu, float* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BetaNcDist(long Target, float* res, float* xqp, float* a, float* b, float* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_NormalDist(long Target, float* res, float* xqp, float* mean_, float* stdev);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ParetoDist(long Target, float* res, float* xqp, float* shape, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_PoissonDist(long Target, float* res, float* xqp, float* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_RayleighDist(long Target, float* res, float* xqp, float* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SkewNormalDist(long Target, float* res, float* xqp, float* mean_, float* scale, float* shape);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_StudentTDist(long Target, float* res, float* xqp, float* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_TriangularDist(long Target, float* res, float* xqp, float* lower, float* mode_, float* upper);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_WeibullDist(long Target, float* res, float* xqp, float* shape, float* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_UniformDist(long Target, float* res, float* xqp, float* lower, float* upper);







//*********************** Boost Numerical Calculus, float precision **********************************


//typedef float(*SRealFuncPtr) (float);
typedef void(*SRealFuncPtr) (void*, void*);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_BracketRoot(float* res1, float* res2, int* iter, SRealFuncPtr f1, float* guess, float* factor, bool is_rising, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_NewtonRaphson(float* res,  int* iter, SRealFuncPtr f1, SRealFuncPtr f2, float* guess, float* xmin, float* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Halley(float* res,  int* iter, SRealFuncPtr f1, SRealFuncPtr f2, SRealFuncPtr f3, float* guess, float* xmin, float* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Schroder(float* res,  int* iter, SRealFuncPtr f1, SRealFuncPtr f2, SRealFuncPtr f3, float* guess, float* xmin, float* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Brent_Minimum(float* res, float* resFx, int* iter, SRealFuncPtr f1, float* bracket_min, float* bracket_max, int bits, unsigned int maxit);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Trapezoidal(float* res1, float* res2, float* res3, SRealFuncPtr f1, float* a, float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GaussLegendre(float* res1, float* res3, SRealFuncPtr f1, float* a, float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_GaussKronrod(float* res1, float* res2, float* res3, SRealFuncPtr f1, float* a, float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_TanhSinh(float* res1, float* res2, float* res3, int* levels_, SRealFuncPtr f1, float* a, float* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_SinhSinh(float* res1, float* res2, float* res3, int* levels_, SRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_ExpSinh(float* res1, float* res2, float* res3, int* levels_, SRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ooura_Cos(float* res1, float* res2, SRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Ooura_Sin(float* res1, float* res2, SRealFuncPtr f1);








//*********************** Boost Odeint **********************************

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Const_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Const_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Const_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Adaptive_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Adaptive_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Adaptive_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_SReal_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel);


















#endif // MPNUMC_SREAL_H_INCLUDED


















