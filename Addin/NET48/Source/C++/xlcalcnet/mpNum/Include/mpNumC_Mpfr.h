
#ifndef MPNUMC_MPFR_H_INCLUDED
#define MPNUMC_MPFR_H_INCLUDED




/** ********************** Real Basic Functions, Mpfr ******************************** **/

MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_Mpfr_Get_Emin();
MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_Mpfr_Get_Emax();

MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_Set_Emin(int64_t exp);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_Set_Emax(int64_t exp);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_Check_Range(MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT MpfrPtr __cdecl Lib_Mpfr_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Clear(MpfrPtr x);

/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Fmpq(MpfrPtr res, const FmpqPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Arb(MpfrPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Arf(MpfrPtr res, const ArfPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Mpfi(MpfrPtr res, const MpfiPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Mpfr(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Mpd(MpfrPtr res, const MpdPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_CReal(MpfiPtr res, const CRealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_QReal(MpfrPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_LD(MpfrPtr res, const long double* x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_D(MpfrPtr res, const double x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_S(MpfrPtr res, const float* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Si(MpfrPtr res, const int32_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Si64(MpfrPtr res, const int64_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Ui(MpfrPtr res, const uint32_t x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Ui64(MpfrPtr res, const uint64_t x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Set_Str(MpfrPtr res, const char* s);

MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Mpfr_SizeInBase10(const char *template1, MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Mpfr_Get_Str(char* dest , uint32_t digits, const char *template1, MpfrPtr x);


/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Neg(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Add(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sub(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Mul(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Div(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Add_D(MpfrPtr res, const MpfrPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sub_D(MpfrPtr res, const MpfrPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_D_Sub(MpfrPtr res, const MpfrPtr x, const double y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Mul_D(MpfrPtr res, const MpfrPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Div_D(MpfrPtr res, const MpfrPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_D_Div(MpfrPtr res, const MpfrPtr x, const double y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Add_Si(MpfrPtr res, const MpfrPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sub_Si(MpfrPtr res, const MpfrPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Si_Sub(MpfrPtr res, const MpfrPtr x, const int32_t y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Mul_Si(MpfrPtr res, const MpfrPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Div_Si(MpfrPtr res, const MpfrPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Si_Div(MpfrPtr res, const MpfrPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Inv(MpfrPtr res, const MpfrPtr x);


MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_LT(const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_GE(const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_GT(const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_LE(const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_EQ(const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_NE(const MpfrPtr x, const MpfrPtr y);





/* General functions for real numbers  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Fma(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Fmax(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Fmin(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);



/* Machine constants */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Zero(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_NegZero(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_One(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Inf(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_NegInf(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Nan(MpfrPtr res);



/* Properties of numbers  */

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Signbit(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Finite(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isinf(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isposinf(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isneginf(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isnan(const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Iszero(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isposzero(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isnegzero(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isone(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isinteger(const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isnumber(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isregular(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isnormal(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Issubnormal(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Isunordered(const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_FitsInt32(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_FitsInt64(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_FitsUInt32(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_FitsUInt64(const MpfrPtr x);



/* Integer Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Nearbyint(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Rint(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_Mpfr_Lrint(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_Mpfr_Llrint(const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ceil(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Floor(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Trunc(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Round(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_Mpfr_Lround(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_Mpfr_Llround(const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfr_ToInt32(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_Mpfr_ToInt64(const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl Lib_Mpfr_ToUInt32(const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT uint64_t __cdecl Lib_Mpfr_ToUInt64(const MpfrPtr x);




/* Floating point functions for real numbers */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Copysign(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Frexp(MpfrPtr res, const MpfrPtr x, long int* e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Logb(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Mpfr_Ilogb(const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ldexp(MpfrPtr res, const MpfrPtr x, const long int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Scalbn(MpfrPtr res, const MpfrPtr x, const int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Scalbln(MpfrPtr res, const MpfrPtr x, const long int e);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Fdim(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);



/* Functions related to mantissa width and exponent range (MReal, BigDecimal) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Epsilon(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ulp(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Max(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Lowest(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Min(MpfrPtr res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Nextabove(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Nextbelow(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Nexttoward(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);



/* Fraction and Remainder Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Modf(MpfrPtr frac, const MpfrPtr x, MpfrPtr iptr);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Fmod(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Remainder(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Remquo(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, long* e);


/* Mathematical Constants  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstDegree(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstPhi(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstLog2(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstLog10(MpfrPtr res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstPi(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstE(MpfrPtr res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstEulerGamma(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstApery(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstCatalan(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstGlaisher(MpfrPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConstKhinchin(MpfrPtr res);


/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Fabs(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sign(MpfrPtr res, const MpfrPtr x);



/* Roots and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sqrt(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sqrt1pm1(MpfrPtr res, const MpfrPtr x); /* TODO */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Rsqrt(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Cbrt(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Root_Si(MpfrPtr res, const MpfrPtr x, const int32_t k);



/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Exp(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Exp2(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Exp10(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Expm1(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Exp2m1(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Exp10m1(MpfrPtr res, const MpfrPtr x);


/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Log(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Log2(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Log10(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Log1p(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Log2p1(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Log10p1(MpfrPtr res, const MpfrPtr x);


/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Square(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Cube(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypot(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Pow(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Powm1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y); /* TODO */
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Pow1p(MpfrPtr res, const MpfrPtr x, const MpfrPtr y); /* TODO */
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Pow1pm1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y); /* TODO */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Pow_Si(MpfrPtr res, const MpfrPtr x, const int32_t k);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Compound_Si(MpfrPtr res, const MpfrPtr x, const int32_t k);




/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sin(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Cos(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Tan(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Csc(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sec(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Cot(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SinPi(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_CosPi(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_TanPi(MpfrPtr res, const MpfrPtr x);


/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sinh(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Cosh(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Tanh(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Csch(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sech(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Coth(MpfrPtr res, const MpfrPtr x);


/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Asin(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Acos(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Atan(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Atan2(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Acsc(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Asec(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Acot(MpfrPtr res, const MpfrPtr x);

/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Asinh(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Acosh(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Atanh(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Acsch(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Asech(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Acoth(MpfrPtr res, const MpfrPtr x);

/* Special functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Erf(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Erfc(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Tgamma(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Lgamma(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselJ0(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselJ1(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselJn(MpfrPtr res, const int n, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselY0(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselY1(MpfrPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselYn(MpfrPtr res, const int n, const MpfrPtr x);





/** ********************** Complex Basic Functions, Mpfr ******************************** **/


MPNUMC_DLL_IMPORTEXPORT MpfcPtr __cdecl Lib_Mpfc_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Clear(MpfcPtr x);


/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Set(MpfcPtr res, const MpfcPtr x);


/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Neg(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Inv(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Add(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sub(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Mul(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Div(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Add_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sub_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Mpfr_Sub(MpfcPtr res, const MpfcPtr y, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Mul_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Div_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Mpfr_Div(MpfcPtr res, const MpfcPtr y, const MpfrPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Add_D(MpfcPtr res, const MpfcPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sub_D(MpfcPtr res, const MpfcPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_D_Sub(MpfcPtr res, const MpfcPtr y, const double x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Mul_D(MpfcPtr res, const MpfcPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Div_D(MpfcPtr res, const MpfcPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_D_Div(MpfcPtr res, const MpfcPtr y, const double x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Add_Si(MpfcPtr res, const MpfcPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sub_Si(MpfcPtr res, const MpfcPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Si_Sub(MpfcPtr res, const MpfcPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Mul_Si(MpfcPtr res, const MpfcPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Div_Si(MpfcPtr res, const MpfcPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Si_Div(MpfcPtr res, const MpfcPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Mpfc_Cmp(const MpfcPtr x, const MpfcPtr y);


/* Floating point functions for real numbers  */

/* Integer and Remainder Related Functions  */

/* Machine constants and properties of numbers  */

/* Mathematical Constants  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Onei(MpfcPtr res); /* TODO */



/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Set_Real(MpfcPtr res, const MpfrPtr re);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Set2(MpfcPtr res, const MpfrPtr re, const MpfrPtr im);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Set2_Si(MpfcPtr res, const int32_t re, const int32_t im);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Abs(MpfrPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Arg(MpfrPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Imag(MpfrPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Real(MpfrPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Conj(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Proj(MpfcPtr res, const MpfcPtr x);




/* Roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sqrt(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sqrt1pm1(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Rsqrt(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Cbrt(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Root_Si(MpfcPtr res, const MpfcPtr x, const int32_t y);



/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Exp(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Expi(MpfcPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Exp2(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Exp10(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Expm1(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Exp2m1(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Exp10m1(MpfcPtr res, const MpfcPtr x);



/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Log(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Log2(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Log10(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Log1p(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Log2p1(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Log10p1(MpfcPtr res, const MpfcPtr x);


/* Power functions and roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Square(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Cube(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Pow(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Powm1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Pow1p(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Pow1pm1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Pow_Si(MpfcPtr res, const MpfcPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Compound_Si(MpfcPtr res, const MpfcPtr x, const int32_t y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Pow_D(MpfcPtr res, const MpfcPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Pow_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y);


/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sin(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Cos(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Tan(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Csc(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sec(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Cot(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_SinPi(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_CosPi(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_TanPi(MpfcPtr res, const MpfcPtr x);



/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sinh(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Cosh(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Tanh(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Csch(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Sech(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Coth(MpfcPtr res, const MpfcPtr x);



/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Asin(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acos(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Atan(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acsc(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Asec(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acot(MpfcPtr res, const MpfcPtr x);




/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Asinh(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acosh(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Atanh(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acsch(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Asech(MpfcPtr res, const MpfcPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acoth(MpfcPtr res, const MpfcPtr x);





















//*********************** Flint **********************************


//////////////////////////////////////////////////////
//// Mpfr_Arb functions
//////////////////////////////////////////////////////




/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Sqrt(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Rsqrt(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Cbrt(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Sqrt1pm1(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Root_ui(MpfrPtr res, const MpfrPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Root_si(MpfrPtr res, const MpfrPtr x, const int32_t n);



/* Exponential and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Exp(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Exp10(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Exp2(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Expm1(MpfrPtr res, const MpfrPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Exp10m1(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Exp2m1(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_ExpRel(MpfrPtr res, const MpfrPtr x);





/* Logarithms and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Logbase(MpfrPtr res, const MpfrPtr x, const MpfrPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Log(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Log10(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Log2(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Log1p(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Log10p1(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Log2p1(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Log1mexp(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LambertW0(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LambertWm1(MpfrPtr res, const MpfrPtr x);





/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Square(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Cube(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypot(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Pow_ui(MpfrPtr res, const MpfrPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Pow_si(MpfrPtr res, const MpfrPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Compound_si(MpfrPtr res, const MpfrPtr x, const int32_t n);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Pow(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Powm1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Pow1p(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Pow1pm1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);



/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Sin(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Cos(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Tan(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Cot(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Csc(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Sec(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Sinc(MpfrPtr res, const MpfrPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_SinPi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_CosPi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_TanPi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_CotPi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_CscPi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_SecPi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_SincPi(MpfrPtr res, const MpfrPtr x);


/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Sinh(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Cosh(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Tanh(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Coth(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Csch(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Sech(MpfrPtr res, const MpfrPtr x);




/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Asin(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Acos(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Atan2(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Atan(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Acot(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Acsc(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Asec(MpfrPtr res, const MpfrPtr x);




/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Asinh(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Acosh(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Atanh(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Acoth(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Acsch(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Asech(MpfrPtr res, const MpfrPtr x);





/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_MEllipticK(MpfcPtr res, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_MEllipticE(MpfcPtr res, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_MEllipticPi(MpfrPtr res, const MpfrPtr n, const MpfrPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_MEllipticF(MpfrPtr res, const MpfrPtr phi, const MpfrPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_MEllipticEInc(MpfrPtr res, const MpfrPtr phi, const MpfrPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_MEllipticPiInc(MpfrPtr res, const MpfrPtr n, const MpfrPtr phi, const MpfrPtr m);



/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_EllipticK(MpfcPtr res, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_EllipticE(MpfcPtr res, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_EllipticPi(MpfrPtr res, const MpfrPtr n, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_EllipticF(MpfrPtr res, const MpfrPtr phi, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_EllipticEInc(MpfrPtr res, const MpfrPtr phi, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_EllipticPiInc(MpfrPtr res, const MpfrPtr n, const MpfrPtr phi, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Agm(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);



/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Elliptic_RC(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Elliptic_RF(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Elliptic_RG(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Elliptic_RD(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Elliptic_RJ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, const MpfrPtr w);




/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Theta1Q(MpfrPtr res, const MpfrPtr z, const MpfrPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Theta2Q(MpfrPtr res, const MpfrPtr z, const MpfrPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Theta3Q(MpfrPtr res, const MpfrPtr z, const MpfrPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Theta4Q(MpfrPtr res, const MpfrPtr z, const MpfrPtr q);



/* Jacobi elliptic functions */



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiSN(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiCN(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiDN(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiNS(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiNC(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiND(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiSC(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiSD(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiDC(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiDS(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiCS(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiCD(MpfrPtr res, const MpfrPtr u, const MpfrPtr k);







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LerchPhi(MpfrPtr res, const MpfrPtr z, const MpfrPtr s, const MpfrPtr a);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Polygamma(MpfrPtr res, const MpfrPtr s, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Digamma(MpfrPtr res, const MpfrPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Polylog(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Dilog(MpfrPtr res, const MpfrPtr x);





/* Hurwitz zeta function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_HurwitzZeta(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Bernoulli_ui(MpfrPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BernoulliPoly_ui(MpfrPtr res, const MpfrPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Euler_ui(MpfrPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BarnesG(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LogBarnesG(MpfrPtr res, const MpfrPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Zeta(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BacklundS(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_GramPoint_ui(MpfrPtr res, const int32_t n);




/* Additional numbertheoretic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Bell_ui(MpfrPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Partitions_ui(MpfrPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Primorial_ui(MpfrPtr res, const int32_t n);





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypgeom0F1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypgeom0F1r(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BesselJ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BesselY(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BesselI(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BesselK(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BesselIScaled(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BesselKScaled(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);



/* Spherical Bessel functions  */




/* Airy functions  */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_AiryAi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_AiryAiPrime(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_AiryBi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_AiryBiPrime(MpfrPtr res, const MpfrPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_AiryAiZero(MpfrPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_AiryAiPrimeZero(MpfrPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_AiryBiZero(MpfrPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_AiryBiPrimeZero(MpfrPtr res, const int32_t n);



/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypgeom1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypgeom1F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_HypgeomU(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);




/* Gamma function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Gamma(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Rgamma(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Lgamma(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_RisingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Beta(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);



/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_GammaUpper(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_GammaQ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

// Missing: Tricomi

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_GammaLower(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_GammaP(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_GammaPPrime(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);



/* Error function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Erf(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Erfc(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_ErfInv(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_ErfcInv(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Erfi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_FresnelC(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_FresnelS(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Ndens(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Ndis(MpfrPtr res, const MpfrPtr x);





/* Exponential integrals and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_ExpIntegralE(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_ExpIntegralEi(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_SinIntegral(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_CosIntegral(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_SinhIntegral(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_CoshIntegral(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LogIntegral(MpfrPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LogIntegralOffset(MpfrPtr res, const MpfrPtr x);



/* 1F1: Orthogonal polynomials */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_HermiteH(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LaguerreL(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);




/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_CoulombF(MpfrPtr res, const MpfrPtr l, const MpfrPtr eta, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_CoulombG(MpfrPtr res, const MpfrPtr l, const MpfrPtr eta, const MpfrPtr z);




/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypgeom2F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr c, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypgeom2F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr c, const MpfrPtr z);





/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_ChebyshevT(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_ChebyshevU(MpfrPtr res, const MpfrPtr x, const MpfrPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_GegenbauerC(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_JacobiP(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr c, const MpfrPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LegendreP(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LegendrePv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LegendreQ(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_LegendreQv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);




/* 2F1: Incomplete Beta Function */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_BetaLower(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Ibeta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Ibetac(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_IbetaPrime(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z);




/* Hypergeometric Function 1F2, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypgeom1F2(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr c, const MpfrPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Arb_Hypgeom1F2r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr c, const MpfrPtr z);








//////////////////////////////////////////////////////
//// Mpfc_Acb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Sqrt(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Rsqrt(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Cbrt(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Sqrt1pm1(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_UnitRoot_ui(MpfcPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Root_ui(MpfcPtr res, const MpfcPtr x, const int32_t n);




/* Exponential and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Exp(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Expj(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Expjpi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Exp10(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Exp2(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Expm1(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Exp10m1(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Exp2m1(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ExpRel(MpfcPtr res, const MpfcPtr x);





/* Logarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Logbase(MpfcPtr res, const MpfcPtr x, const MpfcPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Log(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Log10(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Log2(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Log1p(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Log10p1(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Log2p1(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LambertW_ui(MpfcPtr res, const MpfcPtr x, const int32_t n);




/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Square(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Cube(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypot(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Pow_si(MpfcPtr res, const MpfcPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Pow(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Powm1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Pow1p(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Pow1pm1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);





/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Sin(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Cos(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Tan(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Csc(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Sec(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Cot(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Sinc(MpfcPtr res, const MpfcPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_SinPi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CosPi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_TanPi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CotPi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CscPi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_SecPi(MpfcPtr res, const MpfcPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_SincPi(MpfcPtr res, const MpfcPtr x);






/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Sinh(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Cosh(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Tanh(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Csch(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Sech(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Coth(MpfcPtr res, const MpfcPtr x);





/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Asin(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Acos(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Atan(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Acsc(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Asec(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Acot(MpfcPtr res, const MpfcPtr x);





/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Asinh(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Acosh(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Atanh(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Acsch(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Asech(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Acoth(MpfcPtr res, const MpfcPtr x);








/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_MEllipticK(MpfcPtr res, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_MEllipticE(MpfcPtr res, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_MEllipticPi(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_MEllipticF(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_MEllipticEInc(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_MEllipticPiInc(MpfcPtr res, const MpfcPtr n, const MpfcPtr phi, const MpfcPtr m);




/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticK(MpfcPtr res, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticE(MpfcPtr res, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticPi(MpfcPtr res, const MpfcPtr phi, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticF(MpfcPtr res, const MpfcPtr phi, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticEInc(MpfcPtr res, const MpfcPtr phi, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticPiInc(MpfcPtr res, const MpfcPtr n, const MpfcPtr phi, const MpfcPtr k);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Agm(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);




/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Elliptic_RC(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Elliptic_RF(MpfcPtr res, const MpfcPtr x, const MpfcPtr y, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Elliptic_RG(MpfcPtr res, const MpfcPtr x, const MpfcPtr y, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Elliptic_RD(MpfcPtr res, const MpfcPtr x, const MpfcPtr y, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Elliptic_RJ(MpfcPtr res, const MpfcPtr x, const MpfcPtr y, const MpfcPtr z, const MpfcPtr w);





/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Theta1Q(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Theta2Q(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Theta3Q(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Theta4Q(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Theta1Tau(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Theta2Tau(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Theta3Tau(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Theta4Tau(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m);




/* Jacobi elliptic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_QfromK(MpfcPtr res, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_TfromUQ(MpfcPtr res, const MpfcPtr u, const MpfcPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_SnTQ(MpfcPtr res, const MpfcPtr t, const MpfcPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CnTQ(MpfcPtr res, const MpfcPtr t, const MpfcPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_DnTQ(MpfcPtr res, const MpfcPtr t, const MpfcPtr q);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiSN(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiCN(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiDN(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiNS(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiNC(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiND(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiSC(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiSD(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiDC(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiDS(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiCS(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiCD(MpfcPtr res, const MpfcPtr u, const MpfcPtr k);






/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_WeierstrassP(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_WeierstrassPInv(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_WeierstrassPZeta(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_WeierstrassPSigma(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_WeierstrassPPrime(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticInvariantG2(MpfcPtr res, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticInvariantG3(MpfcPtr res, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticRootE1(MpfcPtr res, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticRootE2(MpfcPtr res, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EllipticRootE3(MpfcPtr res, const MpfcPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_DedekindEta(MpfcPtr res, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_KleinJ(MpfcPtr res, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ModularLambda(MpfcPtr res, const MpfcPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ModularDelta(MpfcPtr res, const MpfcPtr tau);





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LerchPhi(MpfcPtr res, const MpfcPtr z, const MpfcPtr s, const MpfcPtr a);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LerchZeta(MpfcPtr res, const MpfcPtr lambda1, const MpfcPtr alpha, const MpfcPtr s);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Polygamma(MpfcPtr res, const MpfcPtr s, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Trigamma(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Digamma(MpfcPtr res, const MpfcPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Polylog(MpfcPtr res, const MpfcPtr s, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Trilog(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Dilog(MpfcPtr res, const MpfcPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ClausenSin(MpfcPtr res, const MpfcPtr s, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ClausenCos(MpfcPtr res, const MpfcPtr s, const MpfcPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Clausen2(MpfcPtr res, const MpfcPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BoseEinstein(MpfcPtr res, const MpfcPtr s, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_FermiDirac(MpfcPtr res, const MpfcPtr s, const MpfcPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LegendreChi(MpfcPtr res, const MpfcPtr s, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_InverseTanIntegral(MpfcPtr res, const MpfcPtr s, const MpfcPtr z);





/* Hurwitz zeta function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_HurwitzZeta(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Stieltjes_ui(MpfcPtr res, const MpfcPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BernoulliPoly_ui(MpfcPtr res, const MpfcPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Harmonic(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Harmonic2(MpfcPtr res, const MpfcPtr z, const MpfcPtr r);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_EulerPoly_ui(MpfcPtr res, const MpfcPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hyperfactorial(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Superfactorial(MpfcPtr res, const MpfcPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BarnesG(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LogBarnesG(MpfcPtr res, const MpfcPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Zeta(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Zetam1(MpfcPtr res, const MpfcPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_DirichletXi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_DirichletEta(MpfcPtr res, const MpfcPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_DirichletEtam1(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_DirichletBeta(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_DirichletLambda(MpfcPtr res, const MpfcPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_HardyZ(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_HardyTheta(MpfcPtr res, const MpfcPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ZetaZero_ui(MpfcPtr res, const int32_t n);



/* Additional numbertheoretic functions */





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypgeom0F1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypgeom0F1r(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BesselJ(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BesselY(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BesselI(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BesselK(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BesselIScaled(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BesselKScaled(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);





/* Spherical Bessel functions  */



/* Airy functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_AiryAi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_AiryAiPrime(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_AiryBi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_AiryBiPrime(MpfcPtr res, const MpfcPtr x);




/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_HypgeomU(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypgeom1F1(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypgeom1F1r(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);






/* Gamma function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Gamma(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Rgamma(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Lgamma(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_RisingFactorial(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Beta(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);




/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_GammaUpper(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_GammaLower(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_GammaPPrime(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_GammaP(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_GammaQ(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);





/* Error function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Erf(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Erfc(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Erfi(MpfcPtr res, const MpfcPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_FresnelC(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_FresnelS(MpfcPtr res, const MpfcPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Ndens(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Ndis(MpfcPtr res, const MpfcPtr x);




/* Exponential integrals and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ExpIntegralE(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ExpIntegralEi(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_SinIntegral(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CosIntegral(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_SinhIntegral(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CoshIntegral(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LogIntegral(MpfcPtr res, const MpfcPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LogIntegralOffset(MpfcPtr res, const MpfcPtr x);





/* 1F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_HermiteH(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LaguerreL(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);






/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CoulombF(MpfcPtr res, const MpfcPtr l, const MpfcPtr eta, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CoulombG(MpfcPtr res, const MpfcPtr l, const MpfcPtr eta, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CoulombHpos(MpfcPtr res, const MpfcPtr l, const MpfcPtr eta, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_CoulombHneg(MpfcPtr res, const MpfcPtr l, const MpfcPtr eta, const MpfcPtr z);






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypgeom2F1(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypgeom2F1r(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z);




/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ChebyshevT(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_ChebyshevU(MpfcPtr res, const MpfcPtr x, const MpfcPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_GegenbauerC(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_JacobiP(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LegendreP(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LegendrePv(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LegendreQ(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_LegendreQv(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_SphericalY(MpfcPtr res, const MpfcPtr n, const MpfcPtr m, const MpfcPtr theta, const MpfcPtr phi);





/* 2F1: Incomplete Beta Function */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_BetaLower(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Ibeta(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Ibetac(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_IbetaPrime(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z);





/* Hypergeometric Function 1F2, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypgeom1F2(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfc_Acb_Hypgeom1F2r(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z);






//*********************** Boost Special functions , Mpfr **********************************

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BernoulliB2n(MpfrPtr res, const int n, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_TangentT2n(MpfrPtr res, const int n, int const dps);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Sqrt1pm1_Boost(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SinPi_Boost(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_CosPi_Boost(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SincPi(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SinhcPi(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Tgamma_(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Tgamma1pm1(MpfrPtr res, const MpfrPtr x, int const dps);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Lgamma_(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Digamma(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Trigamma(MpfrPtr res, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Factorial(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_DoubleFactorial(MpfrPtr res, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Erf_(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Erfc_(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Erf_inv(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Erfc_inv(MpfrPtr res, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_AiryAi(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_AiryBi(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_AiryAiPrime(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_AiryBiPrime(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Aizero(MpfrPtr res, int n, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Bizero(MpfrPtr res, int n, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ellint_1_K(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ellint_2_K(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Zeta(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ei(MpfrPtr res, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LambertW0(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LambertWm1(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LambertW0Prime(MpfrPtr res, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LambertWm1Prime(MpfrPtr res, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Agm(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Powm1_Boost(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_TgammaRatio(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_TgammaDeltaRatio(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Binomial(MpfrPtr res, const MpfrPtr n, const MpfrPtr k, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_RisingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr n, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_FallingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr n, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselJ(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselY(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselI(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselK(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SphBessel(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SphNeumann(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselJPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselYPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselIPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselKPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SphBesselPrime(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SphNeumannPrime(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselJZero(MpfrPtr res, const MpfrPtr v, const int m, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BesselYZero(MpfrPtr res, const MpfrPtr v, const int m, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GammaP(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GammaQ(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_TgammaLower(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_TgammaUpper(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GammaPInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr p, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GammaQInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr q, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GammaPInva(MpfrPtr res, const MpfrPtr p, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GammaQInva(MpfrPtr res, const MpfrPtr q, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GammaPDerivative(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Beta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LegendreP(MpfrPtr res, int n, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LegendreQ(MpfrPtr res, int n, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Laguerre(MpfrPtr res, int n, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hermite(MpfrPtr res, int n, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ChebyshevT(MpfrPtr res, int n, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ChebyshevU(MpfrPtr res, int n, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Polygamma(MpfrPtr res, int n, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_EllintRC(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ellint1F(MpfrPtr res, const MpfrPtr k, const MpfrPtr phi, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ellint2F(MpfrPtr res, const MpfrPtr k, const MpfrPtr phi, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ellint3K(MpfrPtr res, const MpfrPtr k, const MpfrPtr n, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiCD(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiCN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiCS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiDC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiDN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiDS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiNC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiND(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiNS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiSC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiSD(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiSN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_expint(MpfrPtr res, const unsigned n, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_OwenT(MpfrPtr res, const MpfrPtr h, const MpfrPtr a, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBeta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetac(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetaNonNormalized(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetacNonNormalized(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetaInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr p, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetacInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr q, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetaInva(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, const MpfrPtr p, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetacInva(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, const MpfrPtr q, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetaInvb(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, const MpfrPtr p, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetacInvb(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, const MpfrPtr q, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_IBetaDerivative(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LegendrePM(MpfrPtr res, const int n, const int m, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LaguerreM(MpfrPtr res, const int n, const int m, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_EllipticRF(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_EllipticRD(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_EllipticRG(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ellint3F(MpfrPtr res, const MpfrPtr k, const MpfrPtr n, const MpfrPtr phi, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Gegenbauer(MpfrPtr res, const int n, const MpfrPtr lambda1, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Jacobi(MpfrPtr res, const int n, const MpfrPtr alpha, const MpfrPtr beta, const MpfrPtr x, int const dps);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SphericalHarmonicR(MpfrPtr res, const int n, const int m, const MpfrPtr theta, const MpfrPtr phi, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SphericalHarmonicI(MpfrPtr res, const int n, const int m, const MpfrPtr theta, const MpfrPtr phi, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_EllipticRJ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, const MpfrPtr p, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypergeo0F1(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypergeo1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypergeo1F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LogHypergeo1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypergeo1F2(MpfrPtr res, const MpfrPtr a1, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr x, int const dps, unsigned digits10, double timeout);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypergeo2F1(MpfrPtr res, const MpfrPtr a1, const MpfrPtr a2, const MpfrPtr b1, const MpfrPtr x, int const dps, unsigned digits10, double timeout);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypergeo2F2(MpfrPtr res, const MpfrPtr a1, const MpfrPtr a2, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr x, int const dps, unsigned digits10, double timeout);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypergeo2F3(MpfrPtr res, const MpfrPtr a1, const MpfrPtr a2, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr b3, const MpfrPtr x, int const dps, unsigned digits10, double timeout);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Hypergeo3F2(MpfrPtr res, const MpfrPtr a1, const MpfrPtr a2, const MpfrPtr a3, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr x, int const dps, unsigned digits10, double timeout);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiTheta1(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiTheta2(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiTheta3(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_JacobiTheta4(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps);






//*********************** Boost Distributions, Mpfr **********************************


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ArcsineDist(long Target, MpfrPtr res, MpfrPtr x, MpfrPtr a, MpfrPtr b, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BernoulliDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr p, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BetaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BinomialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, MpfrPtr p, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_CauchyDist(long Target, MpfrPtr res, MpfrPtr x, MpfrPtr location, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Chi2Dist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ExponentialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lambda, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ExtremeValueDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_FisherFDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mu, MpfrPtr nu, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GammaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GeometricDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr p, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_HypergeometricDist(long Target, MpfrPtr res, MpfrPtr x, unsigned r, unsigned n, unsigned N, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_InverseChi2Dist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr df, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_InverseGammaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_WaldDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LaplaceDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LogisticDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LognormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_NegBinomialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, MpfrPtr p, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Chi2NcDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, MpfrPtr nc, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_StudentTNcDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, MpfrPtr delta, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_FisherNcDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mu, MpfrPtr nu, MpfrPtr nc, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BetaNcDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, MpfrPtr nc, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_NormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr stdev, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ParetoDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_PoissonDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_RayleighDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SkewNormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr scale, MpfrPtr shape, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_StudentTDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_TriangularDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lower, MpfrPtr mode_, MpfrPtr upper, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_WeibullDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_UniformDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lower, MpfrPtr upper, int dps);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Logaddexp(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_HyperexponentialDist(long Target, MpfrPtr res, MpfrPtr xqp, mpNumMatrixPtr l1, mpNumMatrixPtr l2, int dps);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_KolmogorovSmirnovDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, int dps);




//*********************** Boost Numerical Calculus, Mpfr **********************************


typedef void(*MpfrFuncPtr) (void*, void*);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BracketRoot(MpfrPtr res1, MpfrPtr res2, int* iter, MpfrFuncPtr f1, MpfrPtr guess_, MpfrPtr factor_, bool is_rising, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_NewtonRaphson(MpfrPtr res,  int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Halley(MpfrPtr res, int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Schroder(MpfrPtr res, int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Brent_Minimum(MpfrPtr res, MpfrPtr resFx, int* iter, MpfrFuncPtr f1, MpfrPtr bracket_min_, MpfrPtr bracket_max_, int bits, unsigned int maxit);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Trapezoidal(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GaussLegendre(MpfrPtr res1, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GaussKronrod(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_TanhSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_SinhSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, int get_digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ExpSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, int get_digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ooura_Cos(MpfrPtr res1, MpfrPtr res2, MpfrFuncPtr f1, int get_digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Ooura_Sin(MpfrPtr res1, MpfrPtr res2, MpfrFuncPtr f1, int get_digits);






//*********************** Boost Odeint, Mpfr  **********************************


MPNUMC_DLL_IMPORTEXPORT AnyPtr __cdecl Lib_Mpfr_StateInit_Func_N(int N, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_StateClear(mpNumMatrixPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_StateGetCoeff(ScalarPtr res, long row, mpNumMatrixPtr source, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_StateSetCoeff(mpNumMatrixPtr result, ScalarPtr source, long row, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_StateGetSize(long *result, mpNumMatrixPtr x);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Const_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Const_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Const_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Adaptive_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Adaptive_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Adaptive_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);






//*********************** BoostEigen Optimization **********************************

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_GradientDescentSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_ConjugatedGradientDescentSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_BfgsSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_LbfgsSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_NewtonDescentSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_CppOptLib1(long what, FuncPtr f1, mpNumMatrixPtr matX_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_CppOptLib2(long what, FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Mpfr_CppOptLib3(long what, FuncPtr f1, FuncPtr f2, FuncPtr f3, mpNumMatrixPtr matX_, mpNumMatrixPtr matHessian_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);




#endif // MPNUMC_MPFR_H_INCLUDED







