
#ifndef MPNUMC_ARB_H_INCLUDED
#define MPNUMC_ARB_H_INCLUDED





/**************************** ACB ******************************/

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Acb_GL_Integration(AcbPtr s, void* f, AcbPtr a, AcbPtr b, mpNumMatrixPtr params, int32_t  prec,
    int32_t  verbose, int32_t  rel_goal, int32_t  abs_tol_bits, int32_t  eval_limit);

/**************************** ARB ******************************/

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Real_Roots(void* f, double a, double b, int32_t verbose, int32_t refine, int32_t low_prec);





/** ********************** Real Basic Functions, ARB ******************************** **/

MPNUMC_DLL_IMPORTEXPORT AnyPtr  __cdecl Lib_Arb_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Clear(void* x);



/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Fmpq(ArbPtr res, const FmpqPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Arb(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Arf(ArbPtr res, const ArfPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Arf_Arf(ArbPtr res, const ArfPtr left, const ArfPtr right);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Mpfi(ArbPtr res, const MpfiPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Mpfr(ArbPtr res, const MpfrPtr x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Mpd(ArbPtr res, const MpdPtr x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_QReal(ArbPtr res, const QRealPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_LD(ArbPtr res, const long double*  x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_D(ArbPtr res, const double x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_S(ArbPtr res, const float* x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Si(ArbPtr res, const int32_t x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Si64(ArbPtr res, const int64_t x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Ui(ArbPtr res, const uint32_t x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Set_Ui64(ArbPtr res, const uint64_t x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Set_Str(ArbPtr res, const char* s);

MPNUMC_DLL_IMPORTEXPORT uint32_t  __cdecl Lib_Arb_SizeInBase10(int32_t n, uint32_t flags, ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int64_t  __cdecl Lib_Arb_Get_Str(char * dest, ArbPtr x, int32_t n, uint32_t flags);






/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Neg(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Inv(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Add(ArbPtr res, const ArbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Sub(ArbPtr res, const ArbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Mul(ArbPtr res, const ArbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Div(ArbPtr res, const ArbPtr x, const ArbPtr y);


MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Add_D(ArbPtr res, const ArbPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Sub_D(ArbPtr res, const ArbPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_D_Sub(ArbPtr res, const ArbPtr y, const double x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Mul_D(ArbPtr res, const ArbPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Div_D(ArbPtr res, const ArbPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_D_Div(ArbPtr res, const ArbPtr y, const double x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Add_Si(ArbPtr res, const ArbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Sub_Si(ArbPtr res, const ArbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Si_Sub(ArbPtr res, const ArbPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Mul_Si(ArbPtr res, const ArbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Div_Si(ArbPtr res, const ArbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Si_Div(ArbPtr res, const ArbPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arb_EQ(void* in1, void* in2);
MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arb_NE(void* in1, void* in2);
MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arb_LT(void* in1, void* in2);
MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arb_LE(void* in1, void* in2);
MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arb_GT(void* in1, void* in2);
MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arb_GE(void* in1, void* in2);




/* Floating point functions for real numbers  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Fma(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Fmax(ArbPtr res, const ArbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Fmin(ArbPtr res, const ArbPtr x, const ArbPtr y);



/* Machine constants, general  */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_Zero(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_NegZero(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_One(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_Inf(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_NegInf(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_Nan(ArbPtr res);



/* Properties of numbers  */

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_Signbit(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_Finite(const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_IsZero(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_IsOne(const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_IsInf(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_IsPosInf(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_IsNegInf(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_Isnan(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_IsInteger(const ArbPtr x);


MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_FitsInt32(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_FitsInt64(const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_FitsUInt32(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_FitsUInt64(const ArbPtr x);




/* Integer Related Functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Nearbyint(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Rint(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_Arb_Lrint(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_Arb_Llrint(const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Ceil(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Floor(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Trunc(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Round(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_Arb_Lround(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_Arb_Llround(const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Arb_ToInt32(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_Arb_ToInt64(const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl Lib_Arb_ToUInt32(const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT uint64_t __cdecl Lib_Arb_ToUInt64(const ArbPtr x);




/* Floating point functions for real numbers */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Copysign(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Frexp(ArbPtr res, const ArbPtr x, FmpzPtr e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Logb(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arb_Ilogb(const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Ldexp(ArbPtr res, const ArbPtr x, const long int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Scalbn(ArbPtr res, const ArbPtr x, const int e);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Scalbln(ArbPtr res, const ArbPtr x, const long int e);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Fdim(ArbPtr res, const ArbPtr x, const ArbPtr y);




/* Functions related to mantissa width and exponent range (MReal, BigDecimal) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Epsilon(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Ulp(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Max(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Lowest(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Min(ArbPtr res);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Nextabove(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Nextbelow(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Nexttoward(ArbPtr res, const ArbPtr x, const ArbPtr y);



/* Fraction and Remainder Related Functions  */





/* Mathematical Constants  */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstDegree(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstPhi(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstLog2(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstLog10(ArbPtr res);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstPi(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstE(ArbPtr res);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstEulerGamma(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstApery(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstCatalan(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstGlaisher(ArbPtr res);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arb_ConstKhinchin(ArbPtr res);




/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Fabs(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Sign(ArbPtr res, const ArbPtr x);



/* Roots and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Sqrt(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Sqrt1pm1(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Rsqrt(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Cbrt(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Root_Si(ArbPtr res, const ArbPtr x, const int32_t n);


/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Exp(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Exp2(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Exp10(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Expm1(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Exp2m1(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Exp10m1(ArbPtr res, const ArbPtr x);




/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Log(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Log2(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Log10(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Log1p(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Log2p1(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Log10p1(ArbPtr res, const ArbPtr x);



/* Power functions and roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Square(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Cube(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Hypot(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Pow(ArbPtr res, const ArbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Powm1(ArbPtr res, const ArbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Pow1p(ArbPtr res, const ArbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Pow1pm1(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Pow_Si(ArbPtr res, const ArbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Compound_Si(ArbPtr res, const ArbPtr x, const int32_t y);



/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Sin(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Cos(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Cosm1(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Tan(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Csc(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Sec(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Cot(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_SinPi(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_CosPi(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_TanPi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_CscPi(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_SecPi(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_CotPi(ArbPtr res, const ArbPtr x);




/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Sinh(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Cosh(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Tanh(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Csch(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Sech(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Coth(ArbPtr res, const ArbPtr x);


/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Asin(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Acos(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Atan(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Atan2(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Acsc(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Asec(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Acot(ArbPtr res, const ArbPtr x);


/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Asinh(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Acosh(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Atanh(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Acsch(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Asech(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Acoth(ArbPtr res, const ArbPtr x);



/* Special functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Erf(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Erfc(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Tgamma(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Lgamma(ArbPtr res, const ArbPtr x);







/* Extra functions for ARB  */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Set_Mid(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Set_Rad(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Get_Mid(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Get_Rad(ArbPtr res, const ArbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Get_Supremum(ArbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Get_Infimum(ArbPtr res, const ArbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Mid_Get_Mpfr(MpfrPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Get_Interval_Mpfr(MpfrPtr res1, MpfrPtr res2, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Mid_Set_Mpfr(ArbPtr res, const MpfrPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Set_Interval_Mpfr(ArbPtr res, const MpfrPtr x1, const MpfrPtr x2);








/**************************** ACB ******************************/

MPNUMC_DLL_IMPORTEXPORT AnyPtr  __cdecl Lib_Acb_Init_Func();
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Clear(void* x);


/* Input and output  */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Set(AcbPtr res, const AcbPtr x);



/* Operator overloading vs raw arithmetic and comparisons  */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Neg(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Inv(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Add(AcbPtr res, const AcbPtr x, const AcbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Sub(AcbPtr res, const AcbPtr x, const AcbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Mul(AcbPtr res, const AcbPtr x, const AcbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Div(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Add_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Sub_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Arb_Sub(AcbPtr res, const AcbPtr y, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Mul_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Div_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Arb_Div(AcbPtr res, const AcbPtr y, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Add_D(AcbPtr res, const AcbPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Sub_D(AcbPtr res, const AcbPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_D_Sub(AcbPtr res, const AcbPtr y, const double x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Mul_D(AcbPtr res, const AcbPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Div_D(AcbPtr res, const AcbPtr x, const double y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_D_Div(AcbPtr res, const AcbPtr y, const double x);


MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Add_Si(AcbPtr res, const AcbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Sub_Si(AcbPtr res, const AcbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Si_Sub(AcbPtr res, const AcbPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Mul_Si(AcbPtr res, const AcbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Div_Si(AcbPtr res, const AcbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Si_Div(AcbPtr res, const AcbPtr y, const int32_t x);

MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Acb_EQ(void* in1, void* in2);
MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Acb_NE(void* in1, void* in2);






/* Floating point functions for real numbers  */

/* Integer and Remainder Related Functions  */

/* Machine constants and properties of numbers  */

/* Mathematical Constants  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Onei(AcbPtr res); /* TODO */





/* Complex components  */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Set_Real(AcbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Set2(AcbPtr res, const ArbPtr x, const ArbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Set_Si64_Si64(AcbPtr res, const int64_t x, const int64_t y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Abs(ArbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Arg(ArbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Imag(ArbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Real(ArbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Conj(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Proj(AcbPtr res, const AcbPtr x);






/* Roots  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Sqrt(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Sqrt1pm1(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Rsqrt(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Cbrt(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Root_Si(AcbPtr res, const AcbPtr x, const int32_t n);


/* Exponential and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Exp(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Expi(AcbPtr res, const ArbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Exp2(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Exp10(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Expm1(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Exp2m1(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Exp10m1(AcbPtr res, const AcbPtr x);



/* Logarithms and related functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Log(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Log2(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Log10(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Log1p(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Log2p1(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Log10p1(AcbPtr res, const AcbPtr x);



/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Square(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Cube(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Pow(AcbPtr res, const AcbPtr x, const AcbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Powm1(AcbPtr res, const AcbPtr x, const AcbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Pow1p(AcbPtr res, const AcbPtr x, const AcbPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Pow1pm1(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Pow_Si(AcbPtr res, const AcbPtr x, const int32_t y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Compound_Si(AcbPtr res, const AcbPtr x, const int32_t y);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Pow_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y);



/* Trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Sin(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Cos(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Tan(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Csc(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Sec(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Cot(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_SinPi(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_CosPi(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_TanPi(AcbPtr res, const AcbPtr x);


/* Hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Sinh(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Cosh(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Tanh(AcbPtr res, const AcbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Csch(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Sech(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Coth(AcbPtr res, const AcbPtr x);



/* Inverse trigonometric functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Asin(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acos(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Atan(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acsc(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Asec(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acot(AcbPtr res, const AcbPtr x);



/* Inverse hyperbolic functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Asinh(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acosh(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Atanh(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acsch(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Asech(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acoth(AcbPtr res, const AcbPtr x);




/* Extra functions for ACB  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Elliptic_Invariants(AcbPtr res_g2, AcbPtr res_g3, const AcbPtr tau);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Elliptic_Roots(AcbPtr res_e1, AcbPtr res_e2, AcbPtr res_e3, const AcbPtr tau);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Elliptic_P(AcbPtr res, const AcbPtr z, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Modj(AcbPtr res, const AcbPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Elliptic_Rc(AcbPtr res, const AcbPtr z1, const AcbPtr z2);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Elliptic_Rf(AcbPtr res, const AcbPtr z1, const AcbPtr z2, const AcbPtr z3);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Elliptic_Rg(AcbPtr res, const AcbPtr z1, const AcbPtr z2, const AcbPtr z3);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Elliptic_Rd(AcbPtr res, const AcbPtr z1, const AcbPtr z2, const AcbPtr z3);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Elliptic_Rj(AcbPtr res, const AcbPtr z1, const AcbPtr z2, const AcbPtr z3, const AcbPtr z4);







//*********************** Flint **********************************


//////////////////////////////////////////////////////
//// Arb_Arb functions
//////////////////////////////////////////////////////




/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Sqrt(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Rsqrt(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Cbrt(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Sqrt1pm1(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Root_ui(ArbPtr res, const ArbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Root_si(ArbPtr res, const ArbPtr x, const int32_t n);



/* Exponential and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Exp(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Exp10(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Exp2(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Expm1(ArbPtr res, const ArbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Exp10m1(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Exp2m1(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_ExpRel(ArbPtr res, const ArbPtr x);





/* Logarithms and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Logbase(ArbPtr res, const ArbPtr x, const ArbPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Log(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Log10(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Log2(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Log1p(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Log10p1(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Log2p1(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Log1mexp(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LambertW0(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LambertWm1(ArbPtr res, const ArbPtr x);





/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Square(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Cube(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypot(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Pow_ui(ArbPtr res, const ArbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Pow_si(ArbPtr res, const ArbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Compound_si(ArbPtr res, const ArbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Pow(ArbPtr res, const ArbPtr x, const ArbPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Powm1(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Pow1p(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Pow1pm1(ArbPtr res, const ArbPtr x, const ArbPtr y);



/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Sin(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Cos(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Tan(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Cot(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Csc(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Sec(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Sinc(ArbPtr res, const ArbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_SinPi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_CosPi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_TanPi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_CotPi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_SincPi(ArbPtr res, const ArbPtr x);


/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Sinh(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Cosh(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Tanh(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Coth(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Csch(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Sech(ArbPtr res, const ArbPtr x);




/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Asin(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Acos(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Atan2(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Atan(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Acot(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Acsc(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Asec(ArbPtr res, const ArbPtr x);




/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Asinh(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Acosh(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Atanh(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Acoth(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Acsch(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Asech(ArbPtr res, const ArbPtr x);





/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_MEllipticK(ArbPtr res, const ArbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_MEllipticE(ArbPtr res, const ArbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_MEllipticPi(ArbPtr res, const ArbPtr n, const ArbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_MEllipticF(ArbPtr res, const ArbPtr phi, const ArbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_MEllipticEInc(ArbPtr res, const ArbPtr phi, const ArbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_MEllipticPiInc(ArbPtr res, const ArbPtr n, const ArbPtr phi, const ArbPtr m);



/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_EllipticK(ArbPtr res, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_EllipticE(ArbPtr res, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_EllipticPi(ArbPtr res, const ArbPtr n, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_EllipticF(ArbPtr res, const ArbPtr phi, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_EllipticEInc(ArbPtr res, const ArbPtr phi, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_EllipticPiInc(ArbPtr res, const ArbPtr n, const ArbPtr phi, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Agm(ArbPtr res, const ArbPtr x, const ArbPtr y);



/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Elliptic_RC(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Elliptic_RF(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Elliptic_RG(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Elliptic_RD(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Elliptic_RJ(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z, const ArbPtr w);




/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Theta1Q(ArbPtr res, const ArbPtr z, const ArbPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Theta2Q(ArbPtr res, const ArbPtr z, const ArbPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Theta3Q(ArbPtr res, const ArbPtr z, const ArbPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Theta4Q(ArbPtr res, const ArbPtr z, const ArbPtr q);



/* Jacobi elliptic functions */



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiSN(ArbPtr res, const ArbPtr u, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiCN(ArbPtr res, const ArbPtr u, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiDN(ArbPtr res, const ArbPtr u, const ArbPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiNS(ArbPtr res, const ArbPtr u, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiNC(ArbPtr res, const ArbPtr u, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiND(ArbPtr res, const ArbPtr u, const ArbPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiSC(ArbPtr res, const ArbPtr u, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiSD(ArbPtr res, const ArbPtr u, const ArbPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiDC(ArbPtr res, const ArbPtr u, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiDS(ArbPtr res, const ArbPtr u, const ArbPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiCS(ArbPtr res, const ArbPtr u, const ArbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiCD(ArbPtr res, const ArbPtr u, const ArbPtr k);







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LerchPhi(ArbPtr res, const ArbPtr z, const ArbPtr s, const ArbPtr a);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Polygamma(ArbPtr res, const ArbPtr s, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Digamma(ArbPtr res, const ArbPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Polylog(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Dilog(ArbPtr res, const ArbPtr x);





/* Hurwitz zeta function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_HurwitzZeta(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Bernoulli_ui(ArbPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BernoulliPoly_ui(ArbPtr res, const ArbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Euler_ui(ArbPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BarnesG(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LogBarnesG(ArbPtr res, const ArbPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Zeta(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BacklundS(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_GramPoint_ui(ArbPtr res, const int32_t n);




/* Additional numbertheoretic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Bell_ui(ArbPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Partitions_ui(ArbPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Primorial_ui(ArbPtr res, const int32_t n);





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypgeom0F1(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypgeom0F1r(ArbPtr res, const ArbPtr x, const ArbPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BesselJ(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BesselY(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BesselI(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BesselK(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BesselIScaled(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BesselKScaled(ArbPtr res, const ArbPtr x, const ArbPtr y);



/* Spherical Bessel functions  */




/* Airy functions  */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_AiryAi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_AiryAiPrime(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_AiryBi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_AiryBiPrime(ArbPtr res, const ArbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_AiryAiZero(ArbPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_AiryAiPrimeZero(ArbPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_AiryBiZero(ArbPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_AiryBiPrimeZero(ArbPtr res, const int32_t n);



/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypgeom1F1(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypgeom1F1r(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_HypgeomU(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);




/* Gamma function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Gamma(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Rgamma(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Lgamma(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_RisingFactorial(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Beta(ArbPtr res, const ArbPtr x, const ArbPtr y);



/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_GammaUpper(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_GammaQ(ArbPtr res, const ArbPtr x, const ArbPtr y);

// Missing: Tricomi

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_GammaLower(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_GammaP(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_GammaPPrime(ArbPtr res, const ArbPtr x, const ArbPtr y);



/* Error function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Erf(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Erfc(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_ErfInv(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_ErfcInv(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Erfi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_FresnelC(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_FresnelS(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Ndens(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Ndis(ArbPtr res, const ArbPtr x);





/* Exponential integrals and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_ExpIntegralE(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_ExpIntegralEi(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_SinIntegral(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_CosIntegral(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_SinhIntegral(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_CoshIntegral(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LogIntegral(ArbPtr res, const ArbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LogIntegralOffset(ArbPtr res, const ArbPtr x);



/* 1F1: Orthogonal polynomials */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_HermiteH(ArbPtr res, const ArbPtr x, const ArbPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LaguerreL(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);




/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_CoulombF(ArbPtr res, const ArbPtr l, const ArbPtr eta, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_CoulombG(ArbPtr res, const ArbPtr l, const ArbPtr eta, const ArbPtr z);




/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypgeom2F1(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr c, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypgeom2F1r(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr c, const ArbPtr z);





/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_ChebyshevT(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_ChebyshevU(ArbPtr res, const ArbPtr x, const ArbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_GegenbauerC(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_JacobiP(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr c, const ArbPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LegendreP(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LegendrePv(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LegendreQ(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_LegendreQv(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);




/* 2F1: Incomplete Beta Function */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_BetaLower(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Ibeta(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Ibetac(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_IbetaPrime(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z);




/* Hypergeometric Function 1F2, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypgeom1F2(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr c, const ArbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arb_Arb_Hypgeom1F2r(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr c, const ArbPtr z);








//////////////////////////////////////////////////////
//// Acb_Acb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Sqrt(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Rsqrt(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Cbrt(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Sqrt1pm1(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_UnitRoot_ui(AcbPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Root_Si(AcbPtr res, const AcbPtr x, const int32_t n);




/* Exponential and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Exp(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Expj(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Expjpi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Exp10(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Exp2(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Expm1(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Exp10m1(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Exp2m1(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ExpRel(AcbPtr res, const AcbPtr x);





/* Logarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Logbase(AcbPtr res, const AcbPtr x, const AcbPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Log(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Log10(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Log2(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Log1p(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Log10p1(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Log2p1(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LambertW_ui(AcbPtr res, const AcbPtr x, const int32_t n);




/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Square(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Cube(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypot(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Pow_si(AcbPtr res, const AcbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Pow(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Powm1(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Pow1p(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Pow1pm1(AcbPtr res, const AcbPtr x, const AcbPtr y);





/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Sin(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Cos(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Tan(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Csc(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Sec(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Cot(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Sinc(AcbPtr res, const AcbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_SinPi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CosPi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_TanPi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CscPi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_SecPi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CotPi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_SincPi(AcbPtr res, const AcbPtr x);






/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Sinh(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Cosh(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Tanh(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Csch(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Sech(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Coth(AcbPtr res, const AcbPtr x);





/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Asin(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Acos(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Atan(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Acsc(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Asec(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Acot(AcbPtr res, const AcbPtr x);





/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Asinh(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Acosh(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Atanh(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Acsch(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Asech(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Acoth(AcbPtr res, const AcbPtr x);








/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_MEllipticK(AcbPtr res, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_MEllipticE(AcbPtr res, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_MEllipticPi(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_MEllipticF(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_MEllipticEInc(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_MEllipticPiInc(AcbPtr res, const AcbPtr n, const AcbPtr phi, const AcbPtr m);




/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticK(AcbPtr res, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticE(AcbPtr res, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticPi(AcbPtr res, const AcbPtr phi, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticF(AcbPtr res, const AcbPtr phi, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticEInc(AcbPtr res, const AcbPtr phi, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticPiInc(AcbPtr res, const AcbPtr n, const AcbPtr phi, const AcbPtr k);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Agm(AcbPtr res, const AcbPtr x, const AcbPtr y);




/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Elliptic_RC(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Elliptic_RF(AcbPtr res, const AcbPtr x, const AcbPtr y, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Elliptic_RG(AcbPtr res, const AcbPtr x, const AcbPtr y, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Elliptic_RD(AcbPtr res, const AcbPtr x, const AcbPtr y, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Elliptic_RJ(AcbPtr res, const AcbPtr x, const AcbPtr y, const AcbPtr z, const AcbPtr w);





/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Theta1Q(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Theta2Q(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Theta3Q(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Theta4Q(AcbPtr res, const AcbPtr phi, const AcbPtr m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Theta1Tau(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Theta2Tau(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Theta3Tau(AcbPtr res, const AcbPtr phi, const AcbPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Theta4Tau(AcbPtr res, const AcbPtr phi, const AcbPtr m);




/* Jacobi elliptic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_QfromK(AcbPtr res, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_TfromUQ(AcbPtr res, const AcbPtr u, const AcbPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_SnTQ(AcbPtr res, const AcbPtr t, const AcbPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CnTQ(AcbPtr res, const AcbPtr t, const AcbPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_DnTQ(AcbPtr res, const AcbPtr t, const AcbPtr q);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiSN(AcbPtr res, const AcbPtr u, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiCN(AcbPtr res, const AcbPtr u, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiDN(AcbPtr res, const AcbPtr u, const AcbPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiNS(AcbPtr res, const AcbPtr u, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiNC(AcbPtr res, const AcbPtr u, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiND(AcbPtr res, const AcbPtr u, const AcbPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiSC(AcbPtr res, const AcbPtr u, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiSD(AcbPtr res, const AcbPtr u, const AcbPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiDC(AcbPtr res, const AcbPtr u, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiDS(AcbPtr res, const AcbPtr u, const AcbPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiCS(AcbPtr res, const AcbPtr u, const AcbPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiCD(AcbPtr res, const AcbPtr u, const AcbPtr k);






/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_WeierstrassP(AcbPtr res, const AcbPtr z, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_WeierstrassPInv(AcbPtr res, const AcbPtr z, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_WeierstrassPZeta(AcbPtr res, const AcbPtr z, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_WeierstrassPSigma(AcbPtr res, const AcbPtr z, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_WeierstrassPPrime(AcbPtr res, const AcbPtr z, const AcbPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticInvariantG2(AcbPtr res, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticInvariantG3(AcbPtr res, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticRootE1(AcbPtr res, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticRootE2(AcbPtr res, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EllipticRootE3(AcbPtr res, const AcbPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_DedekindEta(AcbPtr res, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_KleinJ(AcbPtr res, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ModularLambda(AcbPtr res, const AcbPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ModularDelta(AcbPtr res, const AcbPtr tau);





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LerchPhi(AcbPtr res, const AcbPtr z, const AcbPtr s, const AcbPtr a);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LerchZeta(AcbPtr res, const AcbPtr lambda1, const AcbPtr alpha, const AcbPtr s);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Polygamma(AcbPtr res, const AcbPtr s, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Trigamma(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Digamma(AcbPtr res, const AcbPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Polylog(AcbPtr res, const AcbPtr s, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Trilog(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Dilog(AcbPtr res, const AcbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ClausenSin(AcbPtr res, const AcbPtr s, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ClausenCos(AcbPtr res, const AcbPtr s, const AcbPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Clausen2(AcbPtr res, const AcbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BoseEinstein(AcbPtr res, const AcbPtr s, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_FermiDirac(AcbPtr res, const AcbPtr s, const AcbPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LegendreChi(AcbPtr res, const AcbPtr s, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_InverseTanIntegral(AcbPtr res, const AcbPtr s, const AcbPtr z);





/* Hurwitz zeta function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_HurwitzZeta(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Stieltjes_ui(AcbPtr res, const AcbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BernoulliPoly_ui(AcbPtr res, const AcbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Harmonic(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Harmonic2(AcbPtr res, const AcbPtr z, const AcbPtr r);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_EulerPoly_ui(AcbPtr res, const AcbPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hyperfactorial(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Superfactorial(AcbPtr res, const AcbPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BarnesG(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LogBarnesG(AcbPtr res, const AcbPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Zeta(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Zetam1(AcbPtr res, const AcbPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_DirichletXi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_DirichletEta(AcbPtr res, const AcbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_DirichletEtam1(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_DirichletBeta(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_DirichletLambda(AcbPtr res, const AcbPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_HardyZ(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_HardyTheta(AcbPtr res, const AcbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ZetaZero_ui(AcbPtr res, const int32_t n);



/* Additional numbertheoretic functions */





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypgeom0F1(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypgeom0F1r(AcbPtr res, const AcbPtr x, const AcbPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BesselJ(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BesselY(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BesselI(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BesselK(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BesselIScaled(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BesselKScaled(AcbPtr res, const AcbPtr x, const AcbPtr y);





/* Spherical Bessel functions  */



/* Airy functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_AiryAi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_AiryAiPrime(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_AiryBi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_AiryBiPrime(AcbPtr res, const AcbPtr x);




/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_HypgeomU(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypgeom1F1(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypgeom1F1r(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);






/* Gamma function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Gamma(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Rgamma(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Lgamma(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_RisingFactorial(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Beta(AcbPtr res, const AcbPtr x, const AcbPtr y);




/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_GammaUpper(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_GammaLower(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_GammaPPrime(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_GammaP(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_GammaQ(AcbPtr res, const AcbPtr x, const AcbPtr y);





/* Error function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Erf(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Erfc(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Erfi(AcbPtr res, const AcbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_FresnelC(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_FresnelS(AcbPtr res, const AcbPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Ndens(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Ndis(AcbPtr res, const AcbPtr x);




/* Exponential integrals and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ExpIntegralE(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ExpIntegralEi(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_SinIntegral(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CosIntegral(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_SinhIntegral(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CoshIntegral(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LogIntegral(AcbPtr res, const AcbPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LogIntegralOffset(AcbPtr res, const AcbPtr x);





/* 1F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_HermiteH(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LaguerreL(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);






/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CoulombF(AcbPtr res, const AcbPtr l, const AcbPtr eta, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CoulombG(AcbPtr res, const AcbPtr l, const AcbPtr eta, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CoulombHpos(AcbPtr res, const AcbPtr l, const AcbPtr eta, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_CoulombHneg(AcbPtr res, const AcbPtr l, const AcbPtr eta, const AcbPtr z);






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypgeom2F1(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr c, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypgeom2F1r(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr c, const AcbPtr z);




/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ChebyshevT(AcbPtr res, const AcbPtr x, const AcbPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_ChebyshevU(AcbPtr res, const AcbPtr x, const AcbPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_GegenbauerC(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_JacobiP(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr c, const AcbPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LegendreP(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LegendrePv(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LegendreQ(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_LegendreQv(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_SphericalY(AcbPtr res, const AcbPtr n, const AcbPtr m, const AcbPtr theta, const AcbPtr phi);





/* 2F1: Incomplete Beta Function */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_BetaLower(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Ibeta(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Ibetac(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_IbetaPrime(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z);





/* Hypergeometric Function 1F2, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypgeom1F2(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr c, const AcbPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acb_Acb_Hypgeom1F2r(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr c, const AcbPtr z);






#endif // MPNUMC_ARB_H_INCLUDED


