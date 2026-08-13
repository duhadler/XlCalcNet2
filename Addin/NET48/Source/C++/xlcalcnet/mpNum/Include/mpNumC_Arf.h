//
//#ifndef MPNUMC_ARF_H_INCLUDED
//#define MPNUMC_ARF_H_INCLUDED
//
//
//
//
///** ********************** Real Basic Functions, ARF ******************************** **/
//
//
//MPNUMC_DLL_IMPORTEXPORT ArfPtr  __cdecl Lib_Arf_Init_Func();
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Clear(void* x);
//
//
//
//
//
//
//
///* Input and output  */
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Fmpq(ArfPtr res, const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Arb(ArfPtr res, const ArbPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Arf(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Mpfi(ArfPtr res, const MpfiPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Mpfr(ArfPtr res, const MpfrPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Mpd(ArfPtr res, const MpdPtr x);
////MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_CReal(ArfPtr res, const CRealPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_QReal(ArfPtr res, const QRealPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_LD(ArfPtr res, const long double*  x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_D(ArfPtr res, const double x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_S(ArfPtr res, const float* x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Si(ArfPtr res, const int32_t x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Si64(ArfPtr res, const int64_t x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Ui(ArfPtr res, const uint32_t x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Set_Ui64(ArfPtr res, const uint64_t x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Set_Str(ArfPtr res, const char* s);
//
//MPNUMC_DLL_IMPORTEXPORT uint32_t  __cdecl Lib_Arf_SizeInBase10(int32_t n, uint32_t flags, ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int64_t  __cdecl Lib_Arf_Get_Str(char * dest, ArfPtr x, int32_t n, uint32_t flags);
//
//
//
///* Operator overloading vs raw arithmetic and comparisons  */
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Neg(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Inv(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Add(ArfPtr res, const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Sub(ArfPtr res, const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Mul(ArfPtr res, const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Div(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Add_D(ArfPtr res, const ArfPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Sub_D(ArfPtr res, const ArfPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_D_Sub(ArfPtr res, const ArfPtr y, const double x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Mul_D(ArfPtr res, const ArfPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Div_D(ArfPtr res, const ArfPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_D_Div(ArfPtr res, const ArfPtr y, const double x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Add_Si(ArfPtr res, const ArfPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Sub_Si(ArfPtr res, const ArfPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Si_Sub(ArfPtr res, const ArfPtr y, const int32_t x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Mul_Si(ArfPtr res, const ArfPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Div_Si(ArfPtr res, const ArfPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arf_Si_Div(ArfPtr res, const ArfPtr y, const int32_t x);
//
//
//MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arf_LT(const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arf_GE(const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arf_GT(const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arf_LE(const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arf_EQ(const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Arf_NE(const ArfPtr x, const ArfPtr y);
//
//
//
//
//
///* General functions for real numbers  */
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Fma(ArfPtr res, const ArfPtr x, const ArfPtr y, const ArfPtr z);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Fmax(ArfPtr res, const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Fmin(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//
///* Machine constants */
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Zero(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_NegZero(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_One(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Inf(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_NegInf(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Nan(ArfPtr res);
//
//
//
///* Properties of numbers  */
//
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Signbit(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_IsFinite(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_IsInf(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_IsPosInf(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_IsNegInf(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isnan(const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Iszero(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isposzero(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isnegzero(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isone(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isinteger(const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isnumber(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isregular(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isnormal(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Issubnormal(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_Isunordered(const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_FitsInt32(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_FitsInt64(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_FitsUInt32(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int __cdecl Lib_Arf_FitsUInt64(const ArfPtr x);
//
//
//
///* Integer Related Functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Nearbyint(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Rint(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_Arf_Lrint(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_Arf_Llrint(const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Ceil(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Floor(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl  Lib_Arf_Trunc(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Round(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT long int __cdecl Lib_Arf_Lround(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT long long int __cdecl Lib_Arf_Llround(const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Arf_ToInt32(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_Arf_ToInt64(const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl Lib_Arf_ToUInt32(const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT uint64_t __cdecl Lib_Arf_ToUInt64(const ArfPtr x);
//
//
//
//
///* Floating point functions for real numbers */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Copysign(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Frexp(ArfPtr res, const ArfPtr x, FmpzPtr e);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Logb(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Ilogb(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Fmpz_Ldexp(ArfPtr res, const ArfPtr x, const FmpzPtr e);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Ldexp(ArfPtr res, const ArfPtr x, const long int e);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Scalbn(ArfPtr res, const ArfPtr x, const int e);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Scalbln(ArfPtr res, const ArfPtr x, const long int e);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Fdim(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
///* Functions related to mantissa width and exponent range (MReal, BigDecimal) */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Epsilon(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Ulp(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Max(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Lowest(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Min(ArfPtr res);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Nextabove(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Nextbelow(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Nexttoward(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//
///* Fraction and Remainder Related Functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Modf(ArfPtr frac, const ArfPtr x, ArfPtr iptr);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Fmod(ArfPtr res, const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Remainder(ArfPtr res, const ArfPtr x, const ArfPtr y);
///* not included: Remquo */
//
//
//
//
//
///* Mathematical Constants  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstDegree(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstPhi(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstLog2(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstLog10(ArfPtr res);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstPi(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstE(ArfPtr res);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstEulerGamma(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstApery(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstCatalan(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstGlaisher(ArfPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_ConstKhinchin(ArfPtr res);
//
//
//
///* Complex components  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Fabs(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Sign(ArfPtr res, const ArfPtr x);
//
//
//
///* Roots and related functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Sqrt(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Sqrt1pm1(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Rsqrt(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Cbrt(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Root_Si(ArfPtr res, const ArfPtr x, const int32_t k);
//
//
//
///* Exponential and related functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Exp(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Exp2(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Exp10(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Expm1(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Exp2m1(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Exp10m1(ArfPtr res, const ArfPtr x);
//
//
//
///* Logarithms and related functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Log(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Log2(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Log10(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Log1p(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Log2p1(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Log10p1(ArfPtr res, const ArfPtr x);
//
//
//
///* Power functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Square(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Cube(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Hypot(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Pow(ArfPtr res, const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Powm1(ArfPtr res, const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Pow1p(ArfPtr res, const ArfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Pow1pm1(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Pow_Si(ArfPtr res, const ArfPtr x, const int32_t k);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Compound_Si(ArfPtr res, const ArfPtr x, const int32_t k);
//
//
//
///* Trigonometric functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Sin(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Cos(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Tan(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Csc(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Sec(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Cot(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_SinPi(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_CosPi(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_TanPi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_CscPi(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_SecPi(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_CotPi(ArfPtr res, const ArfPtr x);
//
//
//
//
///* Hyperbolic functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Sinh(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Cosh(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Tanh(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Csch(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Sech(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Coth(ArfPtr res, const ArfPtr x);
//
//
//
///* Inverse trigonometric functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Asin(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Acos(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Atan(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Atan2(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Acsc(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Asec(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Acot(ArfPtr res, const ArfPtr x);
//
//
///* Inverse hyperbolic functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Asinh(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Acosh(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Atanh(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Acsch(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Asech(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Acoth(ArfPtr res, const ArfPtr x);
//
//
///* Special functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Erf(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Erfc(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Tgamma(ArfPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Lgamma(ArfPtr res, const ArfPtr x);
//
//
//
//
//
//
//
//
//
//
//
//
//
//
///** ********************** Complex Basic Functions, ACF ******************************** **/
//
//
//
//MPNUMC_DLL_IMPORTEXPORT AcfPtr  __cdecl Lib_Acf_Init_Func();
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Clear(void* x);
//
//
///* Input and output  */
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Set(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Neg(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Inv(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Add(AcfPtr res, const AcfPtr x, const AcfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Sub(AcfPtr res, const AcfPtr x, const AcfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Mul(AcfPtr res, const AcfPtr x, const AcfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Div(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Add_Arf(AcfPtr res, const AcfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Sub_Arf(AcfPtr res, const AcfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Arf_Sub(AcfPtr res, const AcfPtr y, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Mul_Arf(AcfPtr res, const AcfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Div_Arf(AcfPtr res, const AcfPtr x, const ArfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Arf_Div(AcfPtr res, const AcfPtr y, const ArfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Add_D(AcfPtr res, const AcfPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Sub_D(AcfPtr res, const AcfPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_D_Sub(AcfPtr res, const AcfPtr y, const double x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Mul_D(AcfPtr res, const AcfPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Div_D(AcfPtr res, const AcfPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_D_Div(AcfPtr res, const AcfPtr y, const double x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Add_Si(AcfPtr res, const AcfPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Sub_Si(AcfPtr res, const AcfPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Si_Sub(AcfPtr res, const AcfPtr y, const int32_t x);
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Mul_Si(AcfPtr res, const AcfPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Div_Si(AcfPtr res, const AcfPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Si_Div(AcfPtr res, const AcfPtr y, const int32_t x);
//
//MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Acf_EQ(AcfPtr x, AcfPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Acf_NE(AcfPtr x, AcfPtr y);
//
//
//
//
///* Floating point functions for real numbers  */
//
///* Integer and Remainder Related Functions  */
//
///* Machine constants and properties of numbers  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Onei(AcfPtr res);
//
//
///* Complex components  */
//
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Set_Real(AcfPtr res, const ArfPtr x_re);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Set2(AcfPtr res, const ArfPtr x_re, const ArfPtr x_im);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Set_Si64_Si64(AcfPtr res, const int64_t x_re, const int64_t x_im);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Set_Si_Si(AcfPtr res, const int32_t x_re, const int32_t x_im);
//MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acf_Set_D_D(AcfPtr res, double x_re, double x_im);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Abs(ArfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Arg(ArfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Imag(ArfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Real(ArfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Conj(ArfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Proj(ArfPtr res, const AcfPtr x);
//
//
//
//
//
///* Roots  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Sqrt(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Sqrt1pm1(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Rsqrt(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Cbrt(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Root_Si(AcfPtr res, const AcfPtr x, const int32_t k);
//
//
//
///* Exponential and related functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Exp(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Expj(AcfPtr res, const MpfrPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Exp2(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Exp10(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Expm1(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Exp2m1(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Exp10m1(AcfPtr res, const AcfPtr x);
//
//
//
///* Logarithms and related functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Log(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Log2(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Log10(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Log1p(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Log2p1(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Log10p1(AcfPtr res, const AcfPtr x);
//
//
//
//
///* Power functions */
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Square(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Cube(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Pow(AcfPtr res, const AcfPtr x, const AcfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Powm1(AcfPtr res, const AcfPtr x, const AcfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Pow1p(AcfPtr res, const AcfPtr x, const AcfPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Pow1pm1(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Pow_Si(AcfPtr res, const AcfPtr x, const int32_t k);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Compound_Si(AcfPtr res, const AcfPtr x, const int32_t k);
//
//
//
//
///* Trigonometric functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Sin(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Cos(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Tan(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Csc(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Sec(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Cot(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_SinPi(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_CosPi(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_TanPi(AcfPtr res, const AcfPtr x);
//
//
//
///* Hyperbolic functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Sinh(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Cosh(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Tanh(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Csch(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Sech(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Coth(AcfPtr res, const AcfPtr x);
//
//
//
///* Inverse trigonometric functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Asin(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acos(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Atan(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acsc(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Asec(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acot(AcfPtr res, const AcfPtr x);
//
//
//
///* Inverse hyperbolic functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Asinh(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acosh(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Atanh(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acsch(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Asech(AcfPtr res, const AcfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acoth(AcfPtr res, const AcfPtr x);
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
////*********************** Flint **********************************
//
//
////////////////////////////////////////////////////////
////// Arf_Arb functions
////////////////////////////////////////////////////////
//
//
//
//
///* Roots and quadratic, cubic, and quartic equations */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Sqrt(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Rsqrt(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Cbrt(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Sqrt1pm1(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Root_Si(ArfPtr res, const ArfPtr x, const int32_t n);
//
//
//
///* Exponential and related functions */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Exp(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Exp10(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Exp2(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Expm1(ArfPtr res, const ArfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Exp10m1(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Exp2m1(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_ExpRel(ArfPtr res, const ArfPtr x);
//
//
//
//
//
///* Logarithms and related functions */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Logbase(ArfPtr res, const ArfPtr x, const ArfPtr b);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Log(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Log10(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Log2(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Log1p(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Log10p1(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Log2p1(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Log1mexp(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LambertW0(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LambertWm1(ArfPtr res, const ArfPtr x);
//
//
//
//
//
///* Power functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Square(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Cube(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypot(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Pow_ui(ArfPtr res, const ArfPtr x, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Pow(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Powm1(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Pow1p(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Pow1pm1(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//
///* Trigonometric and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Sin(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Cos(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Tan(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Cot(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Csc(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Sec(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Sinc(ArfPtr res, const ArfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_SinPi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_CosPi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_TanPi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_CscPi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_SecPi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_CotPi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_SincPi(ArfPtr res, const ArfPtr x);
//
//
///* Hyperbolic functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Sinh(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Cosh(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Tanh(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Coth(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Csch(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Sech(ArfPtr res, const ArfPtr x);
//
//
//
//
///* Inverse trigonometric functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Asin(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Acos(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Atan2(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Atan(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Acot(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Acsc(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Asec(ArfPtr res, const ArfPtr x);
//
//
//
//
///* Inverse hyperbolic functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Asinh(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Acosh(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Atanh(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Acoth(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Acsch(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Asech(ArfPtr res, const ArfPtr x);
//
//
//
//
//
///* Legendre elliptic integrals (elliptic parameter m) */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_MEllipticK(AcfPtr res, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_MEllipticE(AcfPtr res, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_MEllipticPi(ArfPtr res, const ArfPtr n, const ArfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_MEllipticF(ArfPtr res, const ArfPtr phi, const ArfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_MEllipticEInc(ArfPtr res, const ArfPtr phi, const ArfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_MEllipticPiInc(ArfPtr res, const ArfPtr n, const ArfPtr phi, const ArfPtr m);
//
//
//
///* Legendre elliptic integrals (elliptic modulus k), and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_EllipticK(AcfPtr res, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_EllipticE(AcfPtr res, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_EllipticPi(ArfPtr res, const ArfPtr n, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_EllipticF(ArfPtr res, const ArfPtr phi, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_EllipticEInc(ArfPtr res, const ArfPtr phi, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_EllipticPiInc(ArfPtr res, const ArfPtr n, const ArfPtr phi, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Agm(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//
///* Carlson symmetric elliptic integrals */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Elliptic_RC(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Elliptic_RF(ArfPtr res, const ArfPtr x, const ArfPtr y, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Elliptic_RG(ArfPtr res, const ArfPtr x, const ArfPtr y, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Elliptic_RD(ArfPtr res, const ArfPtr x, const ArfPtr y, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Elliptic_RJ(ArfPtr res, const ArfPtr x, const ArfPtr y, const ArfPtr z, const ArfPtr w);
//
//
//
//
///* Jacobi theta functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Theta1Q(ArfPtr res, const ArfPtr z, const ArfPtr q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Theta2Q(ArfPtr res, const ArfPtr z, const ArfPtr q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Theta3Q(ArfPtr res, const ArfPtr z, const ArfPtr q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Theta4Q(ArfPtr res, const ArfPtr z, const ArfPtr q);
//
//
//
///* Jacobi elliptic functions */
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiSN(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiCN(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiDN(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiNS(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiNC(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiND(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiSC(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiSD(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiDC(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiDS(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiCS(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiCD(ArfPtr res, const ArfPtr u, const ArfPtr k);
//
//
//
//
//
//
//
///* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */
//
//
//
//
//
///* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */
//
//
//
//
///* Lerch’s transcendent: overview */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LerchPhi(ArfPtr res, const ArfPtr z, const ArfPtr s, const ArfPtr a);
//
//
//
//
///* Polygamma functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Polygamma(ArfPtr res, const ArfPtr s, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Digamma(ArfPtr res, const ArfPtr x);
//
//
//
//
///* Polylogarithms and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Polylog(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Dilog(ArfPtr res, const ArfPtr x);
//
//
//
//
//
///* Hurwitz zeta function and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_HurwitzZeta(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Bernoulli_ui(ArfPtr res, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BernoulliPoly_ui(ArfPtr res, const ArfPtr x, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Euler_ui(ArfPtr res, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BarnesG(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LogBarnesG(AcfPtr res, const AcfPtr x);
//
//
//
//
///* Riemann zeta function, and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Zeta(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BacklundS(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_GramPoint_ui(ArfPtr res, const int32_t n);
//
//
//
//
///* Additional numbertheoretic functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Bell_ui(ArfPtr res, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Partitions_ui(ArfPtr res, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Primorial_ui(ArfPtr res, const int32_t n);
//
//
//
//
//
///* Confluent Hypergeometric Limit Function 0F1, overview */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypgeom0F1(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypgeom0F1r(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//
//
///* Bessel functions and modified Bessel functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BesselJ(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BesselY(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BesselI(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BesselK(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BesselIScaled(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BesselKScaled(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//
///* Spherical Bessel functions  */
//
//
//
//
///* Airy functions  */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_AiryAi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_AiryAiPrime(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_AiryBi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_AiryBiPrime(ArfPtr res, const ArfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_AiryAiZero(ArfPtr res, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_AiryAiPrimeZero(ArfPtr res, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_AiryBiZero(ArfPtr res, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_AiryBiPrimeZero(ArfPtr res, const int32_t n);
//
//
//
///* Kelvin functions  */
//
//
//
//
//
///* Kummer’s Confluent Hypergeometric Function 1F1 */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypgeom1F1(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypgeom1F1r(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_HypgeomU(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//
//
//
///* Gamma function and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Gamma(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Rgamma(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Lgamma(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_RisingFactorial(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Beta(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//
///* Incomplete gamma functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_GammaUpper(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_GammaQ(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//// Missing: Tricomi
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_GammaLower(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_GammaP(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_GammaPPrime(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//
///* Error function and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Erf(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Erfc(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_ErfInv(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_ErfcInv(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Erfi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_FresnelC(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_FresnelS(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Ndens(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Ndis(ArfPtr res, const ArfPtr x);
//
//
//
//
//
///* Exponential integrals and related functions */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_ExpIntegralE(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_ExpIntegralEi(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_SinIntegral(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_CosIntegral(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_SinhIntegral(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_CoshIntegral(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LogIntegral(ArfPtr res, const ArfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LogIntegralOffset(ArfPtr res, const ArfPtr x);
//
//
//
///* 1F1: Orthogonal polynomials */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_HermiteH(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LaguerreL(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//
//
//
///* 1F1: Coulomb functions */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_CoulombF(ArfPtr res, const ArfPtr l, const ArfPtr eta, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_CoulombG(ArfPtr res, const ArfPtr l, const ArfPtr eta, const ArfPtr z);
//
//
//
//
///* 1F1: Whittaker functions */
//
//
//
//
///* 1F1: Parabolic cylinder functions */
//
//
//
//
//
///* Gauss Hypergeometric Function 2F1, overview */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypgeom2F1(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr c, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypgeom2F1r(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr c, const ArfPtr z);
//
//
//
//
//
///* 2F1: Orthogonal polynomials */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_ChebyshevT(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_ChebyshevU(ArfPtr res, const ArfPtr x, const ArfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_GegenbauerC(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_JacobiP(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr c, const ArfPtr z);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LegendreP(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LegendrePv(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LegendreQ(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_LegendreQv(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//
//
//
///* 2F1: Incomplete Beta Function */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_BetaLower(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Ibeta(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Ibetac(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_IbetaPrime(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr z);
//
//
//
//
///* Hypergeometric Function 1F2, overview */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypgeom1F2(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr c, const ArfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Arf_Arb_Hypgeom1F2r(ArfPtr res, const ArfPtr a, const ArfPtr b, const ArfPtr c, const ArfPtr z);
//
//
//
//
//
//
//
//
////////////////////////////////////////////////////////
////// Acf_Acb functions
////////////////////////////////////////////////////////
//
//
//
///* Roots and quadratic, cubic, and quartic equations */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Sqrt(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Rsqrt(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Cbrt(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Sqrt1pm1(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_UnitRoot_ui(AcfPtr res, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Root_ui(AcfPtr res, const AcfPtr x, const int32_t n);
//
//
//
//
///* Exponential and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Exp(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Expj(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Expjpi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Exp10(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Exp2(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Expm1(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Exp10m1(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Exp2m1(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ExpRel(AcfPtr res, const AcfPtr x);
//
//
//
//
//
///* Logarithms and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Logbase(AcfPtr res, const AcfPtr x, const AcfPtr b);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Log(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Log10(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Log2(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Log1p(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Log10p1(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Log2p1(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LambertW_ui(AcfPtr res, const AcfPtr x, const int32_t n);
//
//
//
//
///* Power functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Square(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Cube(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypot(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Pow_si(AcfPtr res, const AcfPtr x, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Pow(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Powm1(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Pow1p(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Pow1pm1(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//
//
//
//
///* Trigonometric and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Sin(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Cos(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Tan(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Csc(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Sec(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Cot(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Sinc(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_SinPi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CosPi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_TanPi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CotPi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_SincPi(AcfPtr res, const AcfPtr x);
//
//
//
//
//
//
///* Hyperbolic functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Sinh(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Cosh(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Tanh(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Csch(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Sech(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Coth(AcfPtr res, const AcfPtr x);
//
//
//
//
//
///* Inverse trigonometric functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Asin(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Acos(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Atan(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Acsc(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Asec(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Acot(AcfPtr res, const AcfPtr x);
//
//
//
//
//
///* Inverse hyperbolic functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Asinh(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Acosh(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Atanh(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Acsch(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Asech(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Acoth(AcfPtr res, const AcfPtr x);
//
//
//
//
//
//
//
//
///* Legendre elliptic integrals (elliptic parameter m) */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_MEllipticK(AcfPtr res, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_MEllipticE(AcfPtr res, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_MEllipticPi(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_MEllipticF(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_MEllipticEInc(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_MEllipticPiInc(AcfPtr res, const AcfPtr n, const AcfPtr phi, const AcfPtr m);
//
//
//
//
///* Legendre elliptic integrals (elliptic modulus k), and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticK(AcfPtr res, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticE(AcfPtr res, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticPi(AcfPtr res, const AcfPtr phi, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticF(AcfPtr res, const AcfPtr phi, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticEInc(AcfPtr res, const AcfPtr phi, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticPiInc(AcfPtr res, const AcfPtr n, const AcfPtr phi, const AcfPtr k);
//
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Agm(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//
//
//
///* Carlson symmetric elliptic integrals */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Elliptic_RC(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Elliptic_RF(AcfPtr res, const AcfPtr x, const AcfPtr y, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Elliptic_RG(AcfPtr res, const AcfPtr x, const AcfPtr y, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Elliptic_RD(AcfPtr res, const AcfPtr x, const AcfPtr y, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Elliptic_RJ(AcfPtr res, const AcfPtr x, const AcfPtr y, const AcfPtr z, const AcfPtr w);
//
//
//
//
//
///* Jacobi theta functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Theta1Q(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Theta2Q(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Theta3Q(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Theta4Q(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Theta1Tau(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Theta2Tau(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Theta3Tau(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Theta4Tau(AcfPtr res, const AcfPtr phi, const AcfPtr m);
//
//
//
//
///* Jacobi elliptic functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_QfromK(AcfPtr res, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_TfromUQ(AcfPtr res, const AcfPtr u, const AcfPtr q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_SnTQ(AcfPtr res, const AcfPtr t, const AcfPtr q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CnTQ(AcfPtr res, const AcfPtr t, const AcfPtr q);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_DnTQ(AcfPtr res, const AcfPtr t, const AcfPtr q);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiSN(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiCN(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiDN(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiNS(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiNC(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiND(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiSC(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiSD(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiDC(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiDS(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiCS(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiCD(AcfPtr res, const AcfPtr u, const AcfPtr k);
//
//
//
//
//
//
///* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_WeierstrassP(AcfPtr res, const AcfPtr z, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_WeierstrassPInv(AcfPtr res, const AcfPtr z, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_WeierstrassPZeta(AcfPtr res, const AcfPtr z, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_WeierstrassPSigma(AcfPtr res, const AcfPtr z, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_WeierstrassPPrime(AcfPtr res, const AcfPtr z, const AcfPtr tau);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticInvariantG2(AcfPtr res, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticInvariantG3(AcfPtr res, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticRootE1(AcfPtr res, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticRootE2(AcfPtr res, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EllipticRootE3(AcfPtr res, const AcfPtr tau);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_DedekindEta(AcfPtr res, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_KleinJ(AcfPtr res, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ModularLambda(AcfPtr res, const AcfPtr tau);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ModularDelta(AcfPtr res, const AcfPtr tau);
//
//
//
//
//
///* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */
//
//
//
//
//
///* Lerch’s transcendent: overview */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LerchPhi(AcfPtr res, const AcfPtr z, const AcfPtr s, const AcfPtr a);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LerchZeta(AcfPtr res, const AcfPtr lambda1, const AcfPtr alpha, const AcfPtr s);
//
//
//
//
///* Polygamma functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Polygamma(AcfPtr res, const AcfPtr s, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Trigamma(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Digamma(AcfPtr res, const AcfPtr x);
//
//
//
//
///* Polylogarithms and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Polylog(AcfPtr res, const AcfPtr s, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Trilog(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Dilog(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ClausenSin(AcfPtr res, const AcfPtr s, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ClausenCos(AcfPtr res, const AcfPtr s, const AcfPtr z);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Clausen2(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BoseEinstein(AcfPtr res, const AcfPtr s, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_FermiDirac(AcfPtr res, const AcfPtr s, const AcfPtr z);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LegendreChi(AcfPtr res, const AcfPtr s, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_InverseTanIntegral(AcfPtr res, const AcfPtr s, const AcfPtr z);
//
//
//
//
//
///* Hurwitz zeta function and related functions */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_HurwitzZeta(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Stieltjes_ui(AcfPtr res, const AcfPtr x, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BernoulliPoly_ui(AcfPtr res, const AcfPtr x, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Harmonic(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Harmonic2(AcfPtr res, const AcfPtr z, const AcfPtr r);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_EulerPoly_ui(AcfPtr res, const AcfPtr x, const int32_t n);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hyperfactorial(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Superfactorial(AcfPtr res, const AcfPtr x);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BarnesG(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LogBarnesG(AcfPtr res, const AcfPtr x);
//
//
//
//
///* Riemann zeta function, and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Zeta(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Zetam1(AcfPtr res, const AcfPtr x);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_DirichletXi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_DirichletEta(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_DirichletEtam1(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_DirichletBeta(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_DirichletLambda(AcfPtr res, const AcfPtr x);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_HardyZ(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_HardyTheta(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ZetaZero_ui(AcfPtr res, const int32_t n);
//
//
//
///* Additional numbertheoretic functions */
//
//
//
//
//
///* Confluent Hypergeometric Limit Function 0F1, overview */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypgeom0F1(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypgeom0F1r(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//
//
//
///* Bessel functions and modified Bessel functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BesselJ(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BesselY(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BesselI(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BesselK(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BesselIScaled(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BesselKScaled(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//
//
//
//
///* Spherical Bessel functions  */
//
//
//
///* Airy functions  */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_AiryAi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_AiryAiPrime(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_AiryBi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_AiryBiPrime(AcfPtr res, const AcfPtr x);
//
//
//
//
///* Kelvin functions  */
//
//
//
//
///* Kummer’s Confluent Hypergeometric Function 1F1 */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_HypgeomU(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypgeom1F1(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypgeom1F1r(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//
//
//
//
//
///* Gamma function and related functions */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Gamma(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Rgamma(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Lgamma(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_RisingFactorial(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Beta(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//
//
//
///* Incomplete gamma functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_GammaUpper(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_GammaLower(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_GammaPPrime(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_GammaP(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_GammaQ(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//
//
//
//
///* Error function and related functions */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Erf(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Erfc(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Erfi(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_FresnelC(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_FresnelS(AcfPtr res, const AcfPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Ndens(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Ndis(AcfPtr res, const AcfPtr x);
//
//
//
//
///* Exponential integrals and related functions */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ExpIntegralE(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ExpIntegralEi(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_SinIntegral(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CosIntegral(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_SinhIntegral(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CoshIntegral(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LogIntegral(AcfPtr res, const AcfPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LogIntegralOffset(AcfPtr res, const AcfPtr x);
//
//
//
//
//
///* 1F1: Orthogonal polynomials */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_HermiteH(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LaguerreL(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//
//
//
//
//
///* 1F1: Coulomb functions */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CoulombF(AcfPtr res, const AcfPtr l, const AcfPtr eta, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CoulombG(AcfPtr res, const AcfPtr l, const AcfPtr eta, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CoulombHpos(AcfPtr res, const AcfPtr l, const AcfPtr eta, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_CoulombHneg(AcfPtr res, const AcfPtr l, const AcfPtr eta, const AcfPtr z);
//
//
//
//
//
//
///* 1F1: Whittaker functions */
//
//
//
//
///* 1F1: Parabolic cylinder functions */
//
//
//
//
//
///* Gauss Hypergeometric Function 2F1, overview */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypgeom2F1(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr c, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypgeom2F1r(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr c, const AcfPtr z);
//
//
//
//
///* 2F1: Orthogonal polynomials */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ChebyshevT(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_ChebyshevU(AcfPtr res, const AcfPtr x, const AcfPtr y);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_GegenbauerC(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_JacobiP(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr c, const AcfPtr z);
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LegendreP(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LegendrePv(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LegendreQ(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_LegendreQv(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_SphericalY(AcfPtr res, const AcfPtr n, const AcfPtr m, const AcfPtr theta, const AcfPtr phi);
//
//
//
//
//
///* 2F1: Incomplete Beta Function */
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_BetaLower(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Ibeta(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Ibetac(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_IbetaPrime(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr z);
//
//
//
//
//
///* Hypergeometric Function 1F2, overview */
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypgeom1F2(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr c, const AcfPtr z);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Acf_Acb_Hypgeom1F2r(AcfPtr res, const AcfPtr a, const AcfPtr b, const AcfPtr c, const AcfPtr z);
//
//
//
//
//
//
//
//#endif // MPNUMC_ARF_H_INCLUDED
//
//
