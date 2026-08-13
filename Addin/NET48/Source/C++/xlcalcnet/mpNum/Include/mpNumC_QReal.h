
#ifndef MPNUMC_QREAL_H_INCLUDED
#define MPNUMC_QREAL_H_INCLUDED




/** ********************** Real Basic Functions, quadruple precision ******************************** **/


MPNUMC_DLL_IMPORTEXPORT QRealPtr __cdecl Lib_QReal_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Clear(QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Set_Acb(QCplxPtr res, const AcbPtr x);


/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Fmpq(QRealPtr res, const FmpqPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Arb(QRealPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Arf(QRealPtr res, const ArfPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Mpfi(QRealPtr res, const MpfiPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Mpfr(QRealPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Mpd(QRealPtr res, const MpdPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_CReal(QRealPtr res, const CRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_QReal(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_LD(QRealPtr res, long double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_D(QRealPtr res, const double x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_S(QRealPtr res, float* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Si(QRealPtr res, const int32_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Ui(QRealPtr res, const uint32_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Si64(QRealPtr res, const int64_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Ui64(QRealPtr res, const uint64_t x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Set_Str(QRealPtr res, const char * str);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Get_Str(char * dest, const char *template1, const QRealPtr x);

/* Get Double */







/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Neg(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Add(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sub(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Mul(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Div(QRealPtr res, const QRealPtr x, const QRealPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Add_D(QRealPtr res, const QRealPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sub_D(QRealPtr res, const QRealPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_D_Sub(QRealPtr res, const QRealPtr x, const double y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Mul_D(QRealPtr res, const QRealPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Div_D(QRealPtr res, const QRealPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_D_Div(QRealPtr res, const QRealPtr x, const double y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Add_Si(QRealPtr res, const QRealPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sub_Si(QRealPtr res, const QRealPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Si_Sub(QRealPtr res, const QRealPtr x, const int32_t y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Mul_Si(QRealPtr res, const QRealPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Div_Si(QRealPtr res, const QRealPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Si_Div(QRealPtr res, const QRealPtr x, const int32_t y);


MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_QReal_LT(const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_QReal_GE(const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_QReal_GT(const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_QReal_LE(const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_QReal_EQ(const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_QReal_NE(const QRealPtr x, const QRealPtr y);







/* General functions for real numbers  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Fma(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Fmax(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Fmin(QRealPtr res, const QRealPtr x, const QRealPtr y);



/* Machine constants */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Zero(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_NegZero(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_One(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Inf(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_NegInf(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Nan(QRealPtr res);



/* Properties of numbers  */

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Signbit(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Finite(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isinf(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isposinf(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isneginf(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isnan(const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Iszero(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isposzero(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isnegzero(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isone(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isinteger(const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isnumber(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isregular(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isnormal(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Issubnormal(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Isunordered(const QRealPtr x, const QRealPtr y);


MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_FitsInt32(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_FitsInt64(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_FitsUInt32(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_FitsUInt64(const QRealPtr x);




/* Integer Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Nearbyint(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Rint(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_QReal_Lrint(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_QReal_Llrint(const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ceil(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Floor(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Trunc(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Round(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_QReal_Lround(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_QReal_Llround(const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_QReal_ToInt32(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_QReal_ToInt64(const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl Lib_QReal_ToUInt32(const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT uint64_t __cdecl Lib_QReal_ToUInt64(const QRealPtr x);




/* Floating point functions for real numbers */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Copysign(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Frexp(QRealPtr res, const QRealPtr x, int* e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Logb(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_QReal_Ilogb(const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ldexp(QRealPtr res, const QRealPtr x, const int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Scalbn(QRealPtr res, const QRealPtr x, const int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Scalbln(QRealPtr res, const QRealPtr x, const long int e);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Fdim(QRealPtr res, const QRealPtr x, const QRealPtr y);


/* Fraction and Remainder Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Modf(QRealPtr frac, const QRealPtr x, QRealPtr iptr);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Fmod(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Remainder(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Remquo(QRealPtr res, const QRealPtr x, const QRealPtr y, int* e);



/* Functions related to mantissa width and exponent range (MReal, BigDecimal) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Epsilon(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ulp(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Max(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Lowest(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Min(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Nextabove(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Nextbelow(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Nexttoward(QRealPtr res, const QRealPtr x, const QRealPtr y);



/* Mathematical Constants  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstDegree(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstPhi(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstLog2(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstLog10(QRealPtr res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstPi(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstE(QRealPtr res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstEulerGamma(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstApery(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstCatalan(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstGlaisher(QRealPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ConstKhinchin(QRealPtr res);



/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Fabs(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sign(QRealPtr res, const QRealPtr x);




/* Roots and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sqrt(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sqrt1pm1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Rsqrt(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Cbrt(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Root_Si(QRealPtr res, const QRealPtr x, const int32_t k);



/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Exp(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Exp2(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Exp10(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Expm1(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Exp2m1(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Exp10m1(QRealPtr res, const QRealPtr x);




/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Log(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Log2(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Log10(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Log1p(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Log2p1(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Log10p1(QRealPtr res, const QRealPtr x);



/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Square(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Cube(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Hypot(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Pow(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Powm1(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Pow1p(QRealPtr res, const QRealPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Pow1pm1(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Pow_Si(QRealPtr res, const QRealPtr x, const int32_t n);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Compound_Si(QRealPtr res, const QRealPtr x, const int32_t n);



/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sin(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Cos(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Cosm1(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Tan(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Csc(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sec(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Cot(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SinPi(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_CosPi(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_TanPi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_CscPi(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SecPi(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_CotPi(QRealPtr res, const QRealPtr x);



/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sinh(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Cosh(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Tanh(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Csch(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sech(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Coth(QRealPtr res, const QRealPtr x);



/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Asin(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Acos(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Atan(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Atan2(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Acsc(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Asec(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Acot(QRealPtr res, const QRealPtr x);


/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Asinh(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Acosh(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Atanh(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Acsch(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Asech(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Acoth(QRealPtr res, const QRealPtr x);



/* Special functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Erf(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Erfc(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Tgamma(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Lgamma(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselJ0(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselJ1(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselJn(QRealPtr res, const int n, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselY0(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselY1(QRealPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselYn(QRealPtr res, const int n, const QRealPtr x);






/** ********************** Complex Basic Functions, extended precision ******************************** **/


MPNUMC_DLL_IMPORTEXPORT QCplxPtr __cdecl Lib_QCplx_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Clear(QCplxPtr x);


/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Set(QCplxPtr res, const QCplxPtr x);


/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Neg(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Add(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sub(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Mul(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Div(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Add_QReal(QCplxPtr res, const QCplxPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sub_QReal(QCplxPtr res, const QCplxPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_QReal_Sub(QCplxPtr res, const QCplxPtr y, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Mul_QReal(QCplxPtr res, const QCplxPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Div_QReal(QCplxPtr res, const QCplxPtr x, const QRealPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_QReal_Div(QCplxPtr res, const QCplxPtr y, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Add_D(QCplxPtr res, const QCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sub_D(QCplxPtr res, const QCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_D_Sub(QCplxPtr res, const QCplxPtr y, const double x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Mul_D(QCplxPtr res, const QCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Div_D(QCplxPtr res, const QCplxPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_D_Div(QCplxPtr res, const QCplxPtr y, const double x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Add_Si(QCplxPtr res, const QCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sub_Si(QCplxPtr res, const QCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Si_Sub(QCplxPtr res, const QCplxPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Mul_Si(QCplxPtr res, const QCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Div_Si(QCplxPtr res, const QCplxPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Si_Div(QCplxPtr res, const QCplxPtr y, const int32_t x);




/* Floating point functions for real numbers  */

/* Integer and Remainder Related Functions  */

/* Machine constants and properties of numbers  */

/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Set_Real(QCplxPtr res, const QRealPtr re);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Set2(QCplxPtr res, const QRealPtr re, const QRealPtr im);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Abs(QRealPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Arg(QRealPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Imag(QRealPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Real(QRealPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Conj(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Proj(QCplxPtr res, const QCplxPtr x);




/* Roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sqrt(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sqrt1pm1(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Rsqrt(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Cbrt(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Root_Si(QCplxPtr res, const QCplxPtr x, const int32_t k);



/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Exp(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Expi(QCplxPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Exp2(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Exp10(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Expm1(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Exp2m1(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Exp10m1(QCplxPtr res, const QCplxPtr x);


/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Log(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Log2(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Log10(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Log1p(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Log2p1(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Log10p1(QCplxPtr res, const QCplxPtr x);




/* Power functions and roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Square(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Cube(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Pow(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Powm1(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Pow1p(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Pow1pm1(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Pow_Si(QCplxPtr res, const QCplxPtr x, const int32_t k);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Compound_Si(QCplxPtr res, const QCplxPtr x, const int32_t k);




/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sin(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Cos(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Tan(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Csc(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sec(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Cot(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_SinPi(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_CosPi(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_TanPi(QCplxPtr res, const QCplxPtr x);


/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sinh(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Cosh(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Tanh(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Csch(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Sech(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Coth(QCplxPtr res, const QCplxPtr x);



/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Asin(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acos(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Atan(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acsc(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Asec(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acot(QCplxPtr res, const QCplxPtr x);



/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Asinh(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acosh(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Atanh(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acsch(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Asech(QCplxPtr res, const QCplxPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acoth(QCplxPtr res, const QCplxPtr x);














//*********************** Flint **********************************


//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////




/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Sqrt(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Rsqrt(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Cbrt(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Sqrt1pm1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Root_ui(QRealPtr res, const QRealPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Root_si(QRealPtr res, const QRealPtr x, const int32_t n);



/* Exponential and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Exp(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Exp10(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Exp2(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Expm1(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Exp10m1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Exp2m1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_ExpRel(QRealPtr res, const QRealPtr x);





/* Logarithms and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Logbase(QRealPtr res, const QRealPtr x, const QRealPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Log(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Log10(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Log2(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Log1p(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Log10p1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Log2p1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Log1mexp(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LambertW0(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LambertWm1(QRealPtr res, const QRealPtr x);





/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Square(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Cube(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypot(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Pow_ui(QRealPtr res, const QRealPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Pow_si(QRealPtr res, const QRealPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Compound_si(QRealPtr res, const QRealPtr x, const int32_t n);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Pow(QRealPtr res, const QRealPtr x, const QRealPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Powm1(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Pow1p(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Pow1pm1(QRealPtr res, const QRealPtr x, const QRealPtr y);



/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Sin(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Cos(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Tan(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Cot(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Csc(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Sec(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Sinc(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_SinPi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_CosPi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_TanPi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_CotPi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_SincPi(QRealPtr res, const QRealPtr x);


/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Sinh(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Cosh(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Tanh(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Coth(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Csch(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Sech(QRealPtr res, const QRealPtr x);




/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Asin(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Acos(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Atan2(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Atan(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Acot(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Acsc(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Asec(QRealPtr res, const QRealPtr x);




/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Asinh(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Acosh(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Atanh(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Acoth(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Acsch(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Asech(QRealPtr res, const QRealPtr x);





/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_MEllipticK(QRealPtr res, const QRealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_MEllipticE(QRealPtr res, const QRealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_MEllipticPi(QRealPtr res, const QRealPtr n, const QRealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_MEllipticF(QRealPtr res, const QRealPtr phi, const QRealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_MEllipticEInc(QRealPtr res, const QRealPtr phi, const QRealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_MEllipticPiInc(QRealPtr res, const QRealPtr n, const QRealPtr phi, const QRealPtr m);



/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_EllipticK(QRealPtr res, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_EllipticE(QRealPtr res, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_EllipticPi(QRealPtr res, const QRealPtr n, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_EllipticF(QRealPtr res, const QRealPtr phi, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_EllipticEInc(QRealPtr res, const QRealPtr phi, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_EllipticPiInc(QRealPtr res, const QRealPtr n, const QRealPtr phi, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Agm(QRealPtr res, const QRealPtr x, const QRealPtr y);



/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Elliptic_RC(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Elliptic_RF(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Elliptic_RG(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Elliptic_RD(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Elliptic_RJ(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z, const QRealPtr w);




/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Theta1Q(QRealPtr res, const QRealPtr z, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Theta2Q(QRealPtr res, const QRealPtr z, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Theta3Q(QRealPtr res, const QRealPtr z, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Theta4Q(QRealPtr res, const QRealPtr z, const QRealPtr q);



/* Jacobi elliptic functions */



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiSN(QRealPtr res, const QRealPtr u, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiCN(QRealPtr res, const QRealPtr u, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiDN(QRealPtr res, const QRealPtr u, const QRealPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiNS(QRealPtr res, const QRealPtr u, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiNC(QRealPtr res, const QRealPtr u, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiND(QRealPtr res, const QRealPtr u, const QRealPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiSC(QRealPtr res, const QRealPtr u, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiSD(QRealPtr res, const QRealPtr u, const QRealPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiDC(QRealPtr res, const QRealPtr u, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiDS(QRealPtr res, const QRealPtr u, const QRealPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiCS(QRealPtr res, const QRealPtr u, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiCD(QRealPtr res, const QRealPtr u, const QRealPtr k);







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LerchPhi(QRealPtr res, const QRealPtr z, const QRealPtr s, const QRealPtr a);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Polygamma(QRealPtr res, const QRealPtr s, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Digamma(QRealPtr res, const QRealPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Polylog(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Dilog(QRealPtr res, const QRealPtr x);





/* Hurwitz zeta function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_HurwitzZeta(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Bernoulli_ui(QRealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BernoulliPoly_ui(QRealPtr res, const QRealPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Euler_ui(QRealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BarnesG(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LogBarnesG(QRealPtr res, const QRealPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Zeta(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BacklundS(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_GramPoint_ui(QRealPtr res, const int32_t n);




/* Additional numbertheoretic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Bell_ui(QRealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Partitions_ui(QRealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Primorial_ui(QRealPtr res, const int32_t n);





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypgeom0F1(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypgeom0F1r(QRealPtr res, const QRealPtr x, const QRealPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BesselJ(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BesselY(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BesselI(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BesselK(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BesselIScaled(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BesselKScaled(QRealPtr res, const QRealPtr x, const QRealPtr y);



/* Spherical Bessel functions  */




/* Airy functions  */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_AiryAi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_AiryAiPrime(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_AiryBi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_AiryBiPrime(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_AiryAiZero(QRealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_AiryAiPrimeZero(QRealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_AiryBiZero(QRealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_AiryBiPrimeZero(QRealPtr res, const int32_t n);



/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypgeom1F1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypgeom1F1r(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_HypgeomU(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);




/* Gamma function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Gamma(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Rgamma(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Lgamma(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_RisingFactorial(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Beta(QRealPtr res, const QRealPtr x, const QRealPtr y);



/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_GammaUpper(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_GammaQ(QRealPtr res, const QRealPtr x, const QRealPtr y);

// Missing: Tricomi

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_GammaLower(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_GammaP(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_GammaPPrime(QRealPtr res, const QRealPtr x, const QRealPtr y);



/* Error function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Erf(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Erfc(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_ErfInv(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_ErfcInv(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Erfi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_FresnelC(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_FresnelS(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Ndens(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Ndis(QRealPtr res, const QRealPtr x);





/* Exponential integrals and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_ExpIntegralE(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_ExpIntegralEi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_SinIntegral(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_CosIntegral(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_SinhIntegral(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_CoshIntegral(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LogIntegral(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LogIntegralOffset(QRealPtr res, const QRealPtr x);



/* 1F1: Orthogonal polynomials */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_HermiteH(QRealPtr res, const QRealPtr x, const QRealPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LaguerreL(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);




/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_CoulombF(QRealPtr res, const QRealPtr l, const QRealPtr eta, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_CoulombG(QRealPtr res, const QRealPtr l, const QRealPtr eta, const QRealPtr z);




/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypgeom2F1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypgeom2F1r(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z);





/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_ChebyshevT(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_ChebyshevU(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_GegenbauerC(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_JacobiP(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LegendreP(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LegendrePv(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LegendreQ(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_LegendreQv(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);




/* 2F1: Incomplete Beta Function */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_BetaLower(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Ibeta(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Ibetac(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_IbetaPrime(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z);




/* Hypergeometric Function 1F2, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypgeom1F2(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Arb_Hypgeom1F2r(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z);








//////////////////////////////////////////////////////
//// Acb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Sqrt(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Rsqrt(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Cbrt(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Sqrt1pm1(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_UnitRoot_ui(QCplxPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Root_ui(QCplxPtr res, const QCplxPtr x, const int32_t n);




/* Exponential and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Exp(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Expj(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Expjpi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Exp10(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Exp2(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Expm1(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Exp10m1(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Exp2m1(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ExpRel(QCplxPtr res, const QCplxPtr x);





/* Logarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Logbase(QCplxPtr res, const QCplxPtr x, const QCplxPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Log(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Log10(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Log2(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Log1p(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Log10p1(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Log2p1(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LambertW_ui(QCplxPtr res, const QCplxPtr x, const int32_t n);




/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Square(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Cube(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypot(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Pow_si(QCplxPtr res, const QCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Pow(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Powm1(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Pow1p(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Pow1pm1(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);





/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Sin(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Cos(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Tan(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Csc(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Sec(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Cot(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Sinc(QCplxPtr res, const QCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_SinPi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CosPi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_TanPi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CotPi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CscPi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_SecPi(QCplxPtr res, const QCplxPtr x);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_SincPi(QCplxPtr res, const QCplxPtr x);






/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Sinh(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Cosh(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Tanh(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Csch(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Sech(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Coth(QCplxPtr res, const QCplxPtr x);





/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Asin(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Acos(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Atan(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Acsc(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Asec(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Acot(QCplxPtr res, const QCplxPtr x);





/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Asinh(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Acosh(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Atanh(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Acsch(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Asech(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Acoth(QCplxPtr res, const QCplxPtr x);








/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_MEllipticK(QCplxPtr res, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_MEllipticE(QCplxPtr res, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_MEllipticPi(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_MEllipticF(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_MEllipticEInc(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_MEllipticPiInc(QCplxPtr res, const QCplxPtr n, const QCplxPtr phi, const QCplxPtr m);




/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticK(QCplxPtr res, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticE(QCplxPtr res, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticPi(QCplxPtr res, const QCplxPtr phi, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticF(QCplxPtr res, const QCplxPtr phi, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticEInc(QCplxPtr res, const QCplxPtr phi, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticPiInc(QCplxPtr res, const QCplxPtr n, const QCplxPtr phi, const QCplxPtr k);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Agm(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);




/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Elliptic_RC(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Elliptic_RF(QCplxPtr res, const QCplxPtr x, const QCplxPtr y, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Elliptic_RG(QCplxPtr res, const QCplxPtr x, const QCplxPtr y, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Elliptic_RD(QCplxPtr res, const QCplxPtr x, const QCplxPtr y, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Elliptic_RJ(QCplxPtr res, const QCplxPtr x, const QCplxPtr y, const QCplxPtr z, const QCplxPtr w);





/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Theta1Q(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Theta2Q(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Theta3Q(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Theta4Q(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Theta1Tau(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Theta2Tau(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Theta3Tau(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Theta4Tau(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m);




/* Jacobi elliptic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_QfromK(QCplxPtr res, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_TfromUQ(QCplxPtr res, const QCplxPtr u, const QCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_SnTQ(QCplxPtr res, const QCplxPtr t, const QCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CnTQ(QCplxPtr res, const QCplxPtr t, const QCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_DnTQ(QCplxPtr res, const QCplxPtr t, const QCplxPtr q);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiSN(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiCN(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiDN(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiNS(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiNC(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiND(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiSC(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiSD(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiDC(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiDS(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiCS(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiCD(QCplxPtr res, const QCplxPtr u, const QCplxPtr k);






/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_WeierstrassP(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_WeierstrassPInv(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_WeierstrassPZeta(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_WeierstrassPSigma(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_WeierstrassPPrime(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticInvariantG2(QCplxPtr res, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticInvariantG3(QCplxPtr res, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticRootE1(QCplxPtr res, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticRootE2(QCplxPtr res, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EllipticRootE3(QCplxPtr res, const QCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_DedekindEta(QCplxPtr res, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_KleinJ(QCplxPtr res, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ModularLambda(QCplxPtr res, const QCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ModularDelta(QCplxPtr res, const QCplxPtr tau);





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LerchPhi(QCplxPtr res, const QCplxPtr z, const QCplxPtr s, const QCplxPtr a);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LerchZeta(QCplxPtr res, const QCplxPtr lambda1, const QCplxPtr alpha, const QCplxPtr s);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Polygamma(QCplxPtr res, const QCplxPtr s, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Trigamma(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Digamma(QCplxPtr res, const QCplxPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Polylog(QCplxPtr res, const QCplxPtr s, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Trilog(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Dilog(QCplxPtr res, const QCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ClausenSin(QCplxPtr res, const QCplxPtr s, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ClausenCos(QCplxPtr res, const QCplxPtr s, const QCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Clausen2(QCplxPtr res, const QCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BoseEinstein(QCplxPtr res, const QCplxPtr s, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_FermiDirac(QCplxPtr res, const QCplxPtr s, const QCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LegendreChi(QCplxPtr res, const QCplxPtr s, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_InverseTanIntegral(QCplxPtr res, const QCplxPtr s, const QCplxPtr z);





/* Hurwitz zeta function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_HurwitzZeta(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Stieltjes_ui(QCplxPtr res, const QCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BernoulliPoly_ui(QCplxPtr res, const QCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Harmonic(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Harmonic2(QCplxPtr res, const QCplxPtr z, const QCplxPtr r);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_EulerPoly_ui(QCplxPtr res, const QCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hyperfactorial(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Superfactorial(QCplxPtr res, const QCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BarnesG(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LogBarnesG(QCplxPtr res, const QCplxPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Zeta(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Zetam1(QCplxPtr res, const QCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_DirichletXi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_DirichletEta(QCplxPtr res, const QCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_DirichletEtam1(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_DirichletBeta(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_DirichletLambda(QCplxPtr res, const QCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_HardyZ(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_HardyTheta(QCplxPtr res, const QCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ZetaZero_ui(QCplxPtr res, const int32_t n);



/* Additional numbertheoretic functions */





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypgeom0F1(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypgeom0F1r(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BesselJ(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BesselY(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BesselI(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BesselK(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BesselIScaled(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BesselKScaled(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);





/* Spherical Bessel functions  */



/* Airy functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_AiryAi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_AiryAiPrime(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_AiryBi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_AiryBiPrime(QCplxPtr res, const QCplxPtr x);




/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_HypgeomU(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypgeom1F1(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypgeom1F1r(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);






/* Gamma function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Gamma(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Rgamma(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Lgamma(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_RisingFactorial(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Beta(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);




/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_GammaUpper(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_GammaLower(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_GammaPPrime(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_GammaP(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_GammaQ(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);





/* Error function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Erf(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Erfc(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Erfi(QCplxPtr res, const QCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_FresnelC(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_FresnelS(QCplxPtr res, const QCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Ndens(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Ndis(QCplxPtr res, const QCplxPtr x);




/* Exponential integrals and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ExpIntegralE(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ExpIntegralEi(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_SinIntegral(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CosIntegral(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_SinhIntegral(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CoshIntegral(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LogIntegral(QCplxPtr res, const QCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LogIntegralOffset(QCplxPtr res, const QCplxPtr x);





/* 1F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_HermiteH(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LaguerreL(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);






/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CoulombF(QCplxPtr res, const QCplxPtr l, const QCplxPtr eta, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CoulombG(QCplxPtr res, const QCplxPtr l, const QCplxPtr eta, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CoulombHpos(QCplxPtr res, const QCplxPtr l, const QCplxPtr eta, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_CoulombHneg(QCplxPtr res, const QCplxPtr l, const QCplxPtr eta, const QCplxPtr z);






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypgeom2F1(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypgeom2F1r(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z);




/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ChebyshevT(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_ChebyshevU(QCplxPtr res, const QCplxPtr x, const QCplxPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_GegenbauerC(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_JacobiP(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LegendreP(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LegendrePv(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LegendreQ(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_LegendreQv(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_SphericalY(QCplxPtr res, const QCplxPtr n, const QCplxPtr m, const QCplxPtr theta, const QCplxPtr phi);





/* 2F1: Incomplete Beta Function */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_BetaLower(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Ibeta(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Ibetac(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_IbetaPrime(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z);





/* Hypergeometric Function 1F2, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypgeom1F2(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QCplx_Acb_Hypgeom1F2r(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z);






//*********************** Boost Special functions , quadruple precision **********************************


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BernoulliB2n(QRealPtr res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_TangentT2n(QRealPtr res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Sqrt1pm1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SinPi_Boost(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_CosPi_Boost(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SincPi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SinhcPi(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Tgamma_(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Tgamma1pm1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Lgamma_(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Digamma(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Trigamma(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Factorial(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_DoubleFactorial(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Erf_(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Erfc_(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Erf_inv(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Erfc_inv(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_AiryAi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_AiryBi(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_AiryAiPrime(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_AiryBiPrime(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Aizero(QRealPtr res, int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Bizero(QRealPtr res, int n);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ellint_1_K(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ellint_2_K(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Zeta(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ei(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LambertW0(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LambertWm1(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LambertW0Prime(QRealPtr res, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LambertWm1Prime(QRealPtr res, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Powm1_Boost(QRealPtr res, const QRealPtr a, const QRealPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_TgammaRatio(QRealPtr res, const QRealPtr a, const QRealPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_TgammaDeltaRatio(QRealPtr res, const QRealPtr a, const QRealPtr b);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Binomial(QRealPtr res, const QRealPtr n, const QRealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_RisingFactorial(QRealPtr res, const QRealPtr x, const QRealPtr n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_FallingFactorial(QRealPtr res, const QRealPtr x, const QRealPtr n);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselJ(QRealPtr res, const QRealPtr v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselY(QRealPtr res, const QRealPtr v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselI(QRealPtr res, const QRealPtr v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselK(QRealPtr res, const QRealPtr v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SphBessel(QRealPtr res, const unsigned v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SphNeumann(QRealPtr res, const unsigned v, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselJPrime(QRealPtr res, const QRealPtr v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselYPrime(QRealPtr res, const QRealPtr v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselIPrime(QRealPtr res, const QRealPtr v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselKPrime(QRealPtr res, const QRealPtr v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SphBesselPrime(QRealPtr res, const unsigned v, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SphNeumannPrime(QRealPtr res, const unsigned v, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselJZero(QRealPtr res, const QRealPtr v, const int m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BesselYZero(QRealPtr res, const QRealPtr v, const int m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GammaP(QRealPtr res, const QRealPtr a, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GammaQ(QRealPtr res, const QRealPtr a, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_TgammaLower(QRealPtr res, const QRealPtr a, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_TgammaUpper(QRealPtr res, const QRealPtr a, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GammaPInv(QRealPtr res, const QRealPtr a, const QRealPtr p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GammaQInv(QRealPtr res, const QRealPtr a, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GammaPInva(QRealPtr res, const QRealPtr p, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GammaQInva(QRealPtr res, const QRealPtr q, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GammaPDerivative(QRealPtr res, const QRealPtr a, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Beta(QRealPtr res, const QRealPtr a, const QRealPtr b);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LegendreP(QRealPtr res, int n, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LegendreQ(QRealPtr res, int n, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Laguerre(QRealPtr res, int n, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Hermite(QRealPtr res, int n, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ChebyshevT(QRealPtr res, int n, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ChebyshevU(QRealPtr res, int n, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Polygamma(QRealPtr res, int n, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_EllintRC(QRealPtr res, const QRealPtr x, const QRealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ellint1F(QRealPtr res, const QRealPtr k, const QRealPtr phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ellint2F(QRealPtr res, const QRealPtr k, const QRealPtr phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ellint3K(QRealPtr res, const QRealPtr k, const QRealPtr n);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiCD(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiCN(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiCS(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiDC(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiDN(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiDS(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiNC(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiND(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiNS(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiSC(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiSD(QRealPtr res, const QRealPtr k, const QRealPtr u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiSN(QRealPtr res, const QRealPtr k, const QRealPtr u);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_expint(QRealPtr res, const unsigned n, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_OwenT(QRealPtr res, const QRealPtr h, const QRealPtr a);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBeta(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetac(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetaNonNormalized(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetacNonNormalized(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetaInv(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetacInv(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetaInva(QRealPtr res, const QRealPtr b, const QRealPtr x, const QRealPtr p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetacInva(QRealPtr res, const QRealPtr b, const QRealPtr x, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetaInvb(QRealPtr res, const QRealPtr a, const QRealPtr x, const QRealPtr p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetacInvb(QRealPtr res, const QRealPtr a, const QRealPtr x, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_IBetaDerivative(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LegendrePM(QRealPtr res, const int n, const int m, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LaguerreM(QRealPtr res, const int n, const int m, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_EllipticRF(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_EllipticRD(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ellint3F(QRealPtr res, const QRealPtr k, const QRealPtr n, const QRealPtr phi);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SphericalHarmonicR(QRealPtr res, const int n, const int m, const QRealPtr theta, const QRealPtr phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SphericalHarmonicI(QRealPtr res, const int n, const int m, const QRealPtr theta, const QRealPtr phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_EllipticRJ(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z, const QRealPtr p);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Hypergeo0F1(QRealPtr res, const QRealPtr b, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Hypergeo1F1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Hypergeo1F1r(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LogHypergeo1F1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiTheta1(QRealPtr res, const QRealPtr x, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiTheta2(QRealPtr res, const QRealPtr x, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiTheta3(QRealPtr res, const QRealPtr x, const QRealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_JacobiTheta4(QRealPtr res, const QRealPtr x, const QRealPtr q);






//*********************** Boost Distributions, quadruple precision **********************************


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ArcsineDist(long Target, QRealPtr res, QRealPtr x, QRealPtr a, QRealPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BernoulliDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BetaDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr a, QRealPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BinomialDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr n, QRealPtr p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_CauchyDist(long Target, QRealPtr res, QRealPtr x, QRealPtr location, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Chi2Dist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ExponentialDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr lambda);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ExtremeValueDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_FisherFDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mu, QRealPtr nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GammaDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr shape, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GeometricDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_HypergeometricDist(long Target, QRealPtr res, QRealPtr x, unsigned r, unsigned n, unsigned N);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_InverseChi2Dist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr df, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_InverseGammaDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr shape, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_WaldDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mean_, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LaplaceDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LogisticDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_LognormalDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_NegBinomialDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr n, QRealPtr p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Chi2NcDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu, QRealPtr nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_StudentTNcDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu, QRealPtr delta);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_FisherNcDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mu, QRealPtr nu, QRealPtr nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BetaNcDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr a, QRealPtr b, QRealPtr nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_NormalDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mean_, QRealPtr stdev);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ParetoDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr shape, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_PoissonDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_RayleighDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SkewNormalDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mean_, QRealPtr scale, QRealPtr shape);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_StudentTDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_TriangularDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr lower, QRealPtr mode_, QRealPtr upper);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_WeibullDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr shape, QRealPtr scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_UniformDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr lower, QRealPtr upper);






//*********************** Boost Numerical Calculus, quadruple precision **********************************


typedef void(*QuadFuncPtr) (void*, void*);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_BracketRoot(QRealPtr res1, QRealPtr res2, int* iter, QuadFuncPtr f1, QRealPtr guess_, QRealPtr factor_, bool is_rising, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_NewtonRaphson(QRealPtr res,  int* iter, QuadFuncPtr f1, QuadFuncPtr f2, QRealPtr guess_, QRealPtr xmin_, QRealPtr xmax_, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Halley(QRealPtr res, int* iter, QuadFuncPtr f1, QuadFuncPtr f2, QuadFuncPtr f3, QRealPtr guess_, QRealPtr xmin_, QRealPtr xmax_, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Schroder(QRealPtr res, int* iter, QuadFuncPtr f1, QuadFuncPtr f2, QuadFuncPtr f3, QRealPtr guess_, QRealPtr xmin_, QRealPtr xmax_, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Brent_Minimum(QRealPtr res, QRealPtr resFx, int* iter, QuadFuncPtr f1, QRealPtr bracket_min_, QRealPtr bracket_max_, int bits, unsigned int maxit);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Trapezoidal(QRealPtr res1, QRealPtr res2, QRealPtr res3, QuadFuncPtr f1, QRealPtr a_, QRealPtr b_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GaussLegendre(QRealPtr res1, QRealPtr res3, QuadFuncPtr f1, QRealPtr a_, QRealPtr b_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_GaussKronrod(QRealPtr res1, QRealPtr res2, QRealPtr res3, QuadFuncPtr f1, QRealPtr a_, QRealPtr b_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_TanhSinh(QRealPtr res1, QRealPtr res2, QRealPtr res3, int* levels_, QuadFuncPtr f1, QRealPtr a_, QRealPtr b_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_SinhSinh(QRealPtr res1, QRealPtr res2, QRealPtr res3, int* levels_, QuadFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_ExpSinh(QRealPtr res1, QRealPtr res2, QRealPtr res3, int* levels_, QuadFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ooura_Cos(QRealPtr res1, QRealPtr res2, QuadFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Ooura_Sin(QRealPtr res1, QRealPtr res2, QuadFuncPtr f1);







//*********************** Boost Odeint **********************************

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Const_RungeKuttaCashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Const_RungeKuttaDopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Const_RungeKuttaFehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Adaptive_RungeKuttaDopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Adaptive_RungeKuttaCashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Adaptive_RungeKuttaFehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_QReal_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_);









#endif // MPNUMC_QREAL_H_INCLUDED




