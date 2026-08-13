
#ifndef MPNUMC_XREAL_H_INCLUDED
#define MPNUMC_XREAL_H_INCLUDED

/** ********************** Real Basic Functions, extended precision ******************************** **/

// Initialize an XReal
MPNUMC_DLL_IMPORTEXPORT long double* __cdecl Lib_XReal_Init_Func();

// Delete an XReal
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Clear(long double* x);


// Delete an XReal
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Set_Acb(XCplxPtr res, const AcbPtr x);


/* Input and output  */

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set(long double* res, const long double* x);

//// Assign x to res
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Fmpq(long double* res, const FmpqPtr x);
//
// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Arb(long double* res, const ArbPtr x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Arf(long double* res, const ArfPtr x);
//
//// Assign x to res
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Mpfi(long double* res, const MpfiPtr x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Mpfr(long double* res, const MpfrPtr x);

// Assign x to res
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Mpd(long double* res, const MpdPtr x);

// Assign x to res
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_CReal(long double* res, const CRealPtr x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_QReal(long double* res, const QRealPtr x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_LD(long double* res, const long double* x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_D(long double* res, const double x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_S(long double* res, const float* x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Si(long double* res, const int32_t x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Ui(long double* res, const uint32_t x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Si64(long double* res, const int64_t x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Ui64(long double* res, const uint64_t x);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Set_Str(long double* res, const char * str);

// Assign x to res
MPNUMC_DLL_IMPORTEXPORT void __cdecl ShowExtNet(char* cstr, const long double* d); /* In Boost Extra */





//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// XReal_Arb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Sqrt(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Rsqrt(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Cbrt(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Sqrt1pm1(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Root_ui(long double* res, const long double* x, const int32_t n);



/* Exponential and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Exp(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Exp10(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Exp2(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Expm1(long double* res, const long double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Exp10m1(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Exp2m1(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_ExpRel(long double* res, const long double* x);





/* Logarithms and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Logbase(long double* res, const long double* x, const long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Log(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Log10(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Log2(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Log1p(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Log10p1(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Log2p1(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Log1mexp(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LambertW0(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LambertWm1(long double* res, const long double* x);





/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Square(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Cube(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hypot(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Pow_ui(long double* res, const long double* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Pow_si(long double* res, const long double* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Compound_si(long double* res, const long double* x, const int32_t n);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Pow(long double* res, const long double* x, const long double* y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Powm1(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Pow1p(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Pow1pm1(long double* res, const long double* x, const long double* y);



/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Sin(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Cos(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Tan(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Cot(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Csc(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Sec(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Sinc(long double* res, const long double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_SinPi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_CosPi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_TanPi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_CotPi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_SincPi(long double* res, const long double* x);


/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Sinh(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Cosh(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Tanh(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Coth(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Csch(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Sech(long double* res, const long double* x);




/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Asin(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Acos(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Atan2(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Atan(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Acot(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Acsc(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Asec(long double* res, const long double* x);




/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Asinh(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Acosh(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Atanh(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Acoth(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Acsch(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Asech(long double* res, const long double* x);





/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_MEllipticK(long double* res, const long double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_MEllipticE(long double* res, const long double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_MEllipticPi(long double* res, const long double* n, const long double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_MEllipticF(long double* res, const long double* phi, const long double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_MEllipticEInc(long double* res, const long double* phi, const long double* m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_MEllipticPiInc(long double* res, const long double* n, const long double* phi, const long double* m);



/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_EllipticK(long double* res, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_EllipticE(long double* res, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_EllipticPi(long double* res, const long double* n, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_EllipticF(long double* res, const long double* phi, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_EllipticEInc(long double* res, const long double* phi, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_EllipticPiInc(long double* res, const long double* n, const long double* phi, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Agm(long double* res, const long double* x, const long double* y);



/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Elliptic_RC(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Elliptic_RF(long double* res, const long double* x, const long double* y, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Elliptic_RG(long double* res, const long double* x, const long double* y, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Elliptic_RD(long double* res, const long double* x, const long double* y, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Elliptic_RJ(long double* res, const long double* x, const long double* y, const long double* z, const long double* w);




/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Theta1Q(long double* res, const long double* z, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Theta2Q(long double* res, const long double* z, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Theta3Q(long double* res, const long double* z, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Theta4Q(long double* res, const long double* z, const long double* q);



/* Jacobi elliptic functions */



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiSN(long double* res, const long double* u, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiCN(long double* res, const long double* u, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiDN(long double* res, const long double* u, const long double* k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiNS(long double* res, const long double* u, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiNC(long double* res, const long double* u, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiND(long double* res, const long double* u, const long double* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiSC(long double* res, const long double* u, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiSD(long double* res, const long double* u, const long double* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiDC(long double* res, const long double* u, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiDS(long double* res, const long double* u, const long double* k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiCS(long double* res, const long double* u, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiCD(long double* res, const long double* u, const long double* k);







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LerchPhi(long double* res, const long double* z, const long double* s, const long double* a);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Polygamma(long double* res, const long double* s, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Digamma(long double* res, const long double* x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Polylog(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Dilog(long double* res, const long double* x);





/* Hurwitz zeta function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_HurwitzZeta(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Bernoulli_ui(long double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BernoulliPoly_ui(long double* res, const long double* x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Euler_ui(long double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BarnesG(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LogBarnesG(long double* res, const long double* x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Zeta(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BacklundS(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_GramPoint_ui(long double* res, const int32_t n);




/* Additional numbertheoretic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Bell_ui(long double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Partitions_ui(long double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Primorial_ui(long double* res, const int32_t n);





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hypgeom0F1(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hypgeom0F1r(long double* res, const long double* x, const long double* y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BesselJ(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BesselY(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BesselI(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BesselK(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BesselIScaled(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BesselKScaled(long double* res, const long double* x, const long double* y);



/* Spherical Bessel functions  */




/* Airy functions  */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_AiryAi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_AiryAiPrime(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_AiryBi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_AiryBiPrime(long double* res, const long double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_AiryAiZero(long double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_AiryAiPrimeZero(long double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_AiryBiZero(long double* res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_AiryBiPrimeZero(long double* res, const int32_t n);



/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hypgeom1F1(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hypgeom1F1r(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_HypgeomU(long double* res, const long double* a, const long double* b, const long double* z);




/* Gamma function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Gamma(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Rgamma(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Lgamma(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_RisingFactorial(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Beta(long double* res, const long double* x, const long double* y);



/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_GammaUpper(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_GammaQ(long double* res, const long double* x, const long double* y);

// Missing: Tricomi

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_GammaLower(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_GammaP(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_GammaPPrime(long double* res, const long double* x, const long double* y);



/* Error function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Erf(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Erfc(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_ErfInv(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_ErfcInv(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Erfi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_FresnelC(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_FresnelS(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Ndens(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Ndis(long double* res, const long double* x);





/* Exponential integrals and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_ExpIntegralE(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_ExpIntegralEi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_SinIntegral(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_CosIntegral(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_SinhIntegral(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_CoshIntegral(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LogIntegral(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LogIntegralOffset(long double* res, const long double* x);



/* 1F1: Orthogonal polynomials */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_HermiteH(long double* res, const long double* x, const long double* y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LaguerreL(long double* res, const long double* a, const long double* b, const long double* z);




/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_CoulombF(long double* res, const long double* l, const long double* eta, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_CoulombG(long double* res, const long double* l, const long double* eta, const long double* z);




/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hyp2f1(long double* res, const long double* a, const long double* b, const long double* c, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hyp2f1r(long double* res, const long double* a, const long double* b, const long double* c, const long double* z);





/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_ChebyshevT(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_ChebyshevU(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_GegenbauerC(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_JacobiP(long double* res, const long double* a, const long double* b, const long double* c, const long double* z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LegendreP(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LegendrePv(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LegendreQ(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_LegendreQv(long double* res, const long double* a, const long double* b, const long double* z);




/* 2F1: Incomplete Beta Function */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_BetaLower(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Ibeta(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Ibetac(long double* res, const long double* a, const long double* b, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_IbetaPrime(long double* res, const long double* a, const long double* b, const long double* z);




/* Hypergeometric Function 1F2, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hypgeom1F2(long double* res, const long double* a, const long double* b, const long double* c, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Arb_Hypgeom1F2r(long double* res, const long double* a, const long double* b, const long double* c, const long double* z);














//////////////////////////////////////////////////////
//// XCplx_Acb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Sqrt(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Rsqrt(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Cbrt(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Sqrt1pm1(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_UnitRoot_ui(XCplxPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Root_ui(XCplxPtr res, const XCplxPtr x, const int32_t n);




/* Exponential and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Exp(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Expj(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Expjpi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Exp10(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Exp2(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Expm1(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Exp10m1(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Exp2m1(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ExpRel(XCplxPtr res, const XCplxPtr x);





/* Logarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Logbase(XCplxPtr res, const XCplxPtr x, const XCplxPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Log(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Log10(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Log2(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Log1p(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Log10p1(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Log2p1(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LambertW_ui(XCplxPtr res, const XCplxPtr x, const int32_t n);




/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Square(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Cube(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypot(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Pow_si(XCplxPtr res, const XCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Pow(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Powm1(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Pow1p(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Pow1pm1(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);





/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Sin(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Cos(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Tan(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Csc(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Sec(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Cot(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Sinc(XCplxPtr res, const XCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_SinPi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CosPi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_TanPi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CotPi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CscPi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_SecPi(XCplxPtr res, const XCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_SincPi(XCplxPtr res, const XCplxPtr x);






/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Sinh(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Cosh(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Tanh(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Csch(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Sech(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Coth(XCplxPtr res, const XCplxPtr x);





/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Asin(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Acos(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Atan(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Acsc(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Asec(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Acot(XCplxPtr res, const XCplxPtr x);





/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Asinh(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Acosh(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Atanh(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Acsch(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Asech(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Acoth(XCplxPtr res, const XCplxPtr x);








/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_MEllipticK(XCplxPtr res, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_MEllipticE(XCplxPtr res, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_MEllipticPi(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_MEllipticF(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_MEllipticEInc(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_MEllipticPiInc(XCplxPtr res, const XCplxPtr n, const XCplxPtr phi, const XCplxPtr m);




/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticK(XCplxPtr res, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticE(XCplxPtr res, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticPi(XCplxPtr res, const XCplxPtr phi, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticF(XCplxPtr res, const XCplxPtr phi, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticEInc(XCplxPtr res, const XCplxPtr phi, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticPiInc(XCplxPtr res, const XCplxPtr n, const XCplxPtr phi, const XCplxPtr k);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Agm(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);




/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Elliptic_RC(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Elliptic_RF(XCplxPtr res, const XCplxPtr x, const XCplxPtr y, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Elliptic_RG(XCplxPtr res, const XCplxPtr x, const XCplxPtr y, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Elliptic_RD(XCplxPtr res, const XCplxPtr x, const XCplxPtr y, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Elliptic_RJ(XCplxPtr res, const XCplxPtr x, const XCplxPtr y, const XCplxPtr z, const XCplxPtr w);





/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Theta1Q(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Theta2Q(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Theta3Q(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Theta4Q(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Theta1Tau(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Theta2Tau(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Theta3Tau(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Theta4Tau(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m);




/* Jacobi elliptic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_QfromK(XCplxPtr res, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_TfromUQ(XCplxPtr res, const XCplxPtr u, const XCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_SnTQ(XCplxPtr res, const XCplxPtr t, const XCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CnTQ(XCplxPtr res, const XCplxPtr t, const XCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_DnTQ(XCplxPtr res, const XCplxPtr t, const XCplxPtr q);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiSN(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiCN(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiDN(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiNS(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiNC(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiND(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiSC(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiSD(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiDC(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiDS(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiCS(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiCD(XCplxPtr res, const XCplxPtr u, const XCplxPtr k);






/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_WeierstrassP(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_WeierstrassPInv(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_WeierstrassPZeta(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_WeierstrassPSigma(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_WeierstrassPPrime(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticInvariantG2(XCplxPtr res, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticInvariantG3(XCplxPtr res, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticRootE1(XCplxPtr res, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticRootE2(XCplxPtr res, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EllipticRootE3(XCplxPtr res, const XCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_DedekindEta(XCplxPtr res, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_KleinJ(XCplxPtr res, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ModularLambda(XCplxPtr res, const XCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ModularDelta(XCplxPtr res, const XCplxPtr tau);





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LerchPhi(XCplxPtr res, const XCplxPtr z, const XCplxPtr s, const XCplxPtr a);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LerchZeta(XCplxPtr res, const XCplxPtr lambda1, const XCplxPtr alpha, const XCplxPtr s);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Polygamma(XCplxPtr res, const XCplxPtr s, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Trigamma(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Digamma(XCplxPtr res, const XCplxPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Polylog(XCplxPtr res, const XCplxPtr s, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Trilog(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Dilog(XCplxPtr res, const XCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ClausenSin(XCplxPtr res, const XCplxPtr s, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ClausenCos(XCplxPtr res, const XCplxPtr s, const XCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Clausen2(XCplxPtr res, const XCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BoseEinstein(XCplxPtr res, const XCplxPtr s, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_FermiDirac(XCplxPtr res, const XCplxPtr s, const XCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LegendreChi(XCplxPtr res, const XCplxPtr s, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_InverseTanIntegral(XCplxPtr res, const XCplxPtr s, const XCplxPtr z);





/* Hurwitz zeta function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_HurwitzZeta(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Stieltjes_ui(XCplxPtr res, const XCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BernoulliPoly_ui(XCplxPtr res, const XCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Harmonic(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Harmonic2(XCplxPtr res, const XCplxPtr z, const XCplxPtr r);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_EulerPoly_ui(XCplxPtr res, const XCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hyperfactorial(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Superfactorial(XCplxPtr res, const XCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BarnesG(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LogBarnesG(XCplxPtr res, const XCplxPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Zeta(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Zetam1(XCplxPtr res, const XCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_DirichletXi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_DirichletEta(XCplxPtr res, const XCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_DirichletEtam1(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_DirichletBeta(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_DirichletLambda(XCplxPtr res, const XCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_HardyZ(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_HardyTheta(XCplxPtr res, const XCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ZetaZero_ui(XCplxPtr res, const int32_t n);



/* Additional numbertheoretic functions */





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypgeom0F1(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypgeom0F1r(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BesselJ(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BesselY(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BesselI(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BesselK(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BesselIScaled(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BesselKScaled(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);





/* Spherical Bessel functions  */



/* Airy functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_AiryAi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_AiryAiPrime(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_AiryBi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_AiryBiPrime(XCplxPtr res, const XCplxPtr x);




/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_HypgeomU(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypgeom1F1(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypgeom1F1r(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);






/* Gamma function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Gamma(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Rgamma(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Lgamma(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_RisingFactorial(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Beta(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);




/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_GammaUpper(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_GammaLower(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_GammaPPrime(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_GammaP(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_GammaQ(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);





/* Error function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Erf(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Erfc(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Erfi(XCplxPtr res, const XCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_FresnelC(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_FresnelS(XCplxPtr res, const XCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Ndens(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Ndis(XCplxPtr res, const XCplxPtr x);




/* Exponential integrals and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ExpIntegralE(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ExpIntegralEi(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_SinIntegral(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CosIntegral(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_SinhIntegral(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CoshIntegral(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LogIntegral(XCplxPtr res, const XCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LogIntegralOffset(XCplxPtr res, const XCplxPtr x);





/* 1F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_HermiteH(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LaguerreL(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);






/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CoulombF(XCplxPtr res, const XCplxPtr l, const XCplxPtr eta, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CoulombG(XCplxPtr res, const XCplxPtr l, const XCplxPtr eta, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CoulombHpos(XCplxPtr res, const XCplxPtr l, const XCplxPtr eta, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_CoulombHneg(XCplxPtr res, const XCplxPtr l, const XCplxPtr eta, const XCplxPtr z);






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypgeom2F1(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr c, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypgeom2F1r(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr c, const XCplxPtr z);




/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ChebyshevT(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_ChebyshevU(XCplxPtr res, const XCplxPtr x, const XCplxPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_GegenbauerC(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_JacobiP(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr c, const XCplxPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LegendreP(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LegendrePv(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LegendreQ(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_LegendreQv(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_SphericalY(XCplxPtr res, const XCplxPtr n, const XCplxPtr m, const XCplxPtr theta, const XCplxPtr phi);





/* 2F1: Incomplete Beta Function */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_BetaLower(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Ibeta(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Ibetac(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_IbetaPrime(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z);





/* Hypergeometric Function 1F2, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypgeom1F2(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr c, const XCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XCplx_Acb_Hypgeom1F2r(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr c, const XCplxPtr z);










//*********************** Boost Special functions , extended precision **********************************


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BernoulliB2n(long double* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_TangentT2n(long double* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Sqrt1pm1_Boost(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SinPi_Boost(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_CosPi_Boost(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SincPi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SinhcPi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Tgamma_(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Tgamma1pm1(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Digamma(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Lgamma_(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Trigamma(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Factorial(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_DoubleFactorial(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Erf_(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Erfc_(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Erf_inv(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Erfc_inv(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_AiryAi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_AiryBi(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_AiryAiPrime(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_AiryBiPrime(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Aizero(long double* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Bizero(long double* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ellint_1_K(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ellint_2_K(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Zeta(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ei(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LambertW0(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LambertWm1(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LambertW0Prime(long double* res, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LambertWm1Prime(long double* res, const long double* x);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Powm1_Boost(long double* res, const long double* a, const long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_TgammaRatio(long double* res, const long double* a, const long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_TgammaDeltaRatio(long double* res, const long double* a, const long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Binomial(long double* res, const long double* n, const long double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_RisingFactorial(long double* res, const long double* x, const long double* n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_FallingFactorial(long double* res, const long double* x, const long double* n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselJ(long double* res, const long double* v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselY(long double* res, const long double* v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselI(long double* res, const long double* v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselK(long double* res, const long double* v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SphBessel(long double* res, const unsigned v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SphNeumann(long double* res, const unsigned v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselJPrime(long double* res, const long double* v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselYPrime(long double* res, const long double* v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselIPrime(long double* res, const long double* v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselKPrime(long double* res, const long double* v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SphBesselPrime(long double* res, const unsigned v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SphNeumannPrime(long double* res, const unsigned v, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselJZero(long double* res, const long double* v, const int m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BesselYZero(long double* res, const long double* v, const int m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GammaP(long double* res, const long double* a, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GammaQ(long double* res, const long double* a, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_TgammaLower(long double* res, const long double* a, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_TgammaUpper(long double* res, const long double* a, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GammaPInv(long double* res, const long double* a, const long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GammaQInv(long double* res, const long double* a, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GammaPInva(long double* res, const long double* x, const long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GammaQInva(long double* res, const long double* x, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GammaPDerivative(long double* res, const long double* a, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Beta(long double* res, const long double* a, const long double* b);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LegendreP(long double* res, int n, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LegendreQ(long double* res, int n, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Laguerre(long double* res, int n, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Hermite(long double* res, int n, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_ChebyshevT(long double* res, int n, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_ChebyshevU(long double* res, int n, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Polygamma(long double* res, int n, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_EllintRC(long double* res, const long double* x, const long double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ellint1F(long double* res, const long double* k, const long double* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ellint2F(long double* res, const long double* k, const long double* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ellint3K(long double* res, const long double* k, const long double* n);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiCD(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiCN(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiCS(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiDC(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiDN(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiDS(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiNC(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiND(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiNS(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiSC(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiSD(long double* res, const long double* k, const long double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiSN(long double* res, const long double* k, const long double* u);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_expint(long double* res, const unsigned n, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_OwenT(long double* res, const long double* h, const long double* a);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBeta(long double* res, const long double* a, const long double* b, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetac(long double* res, const long double* a, const long double* b, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetaNonNormalized(long double* res, const long double* a, const long double* b, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetacNonNormalized(long double* res, const long double* a, const long double* b, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetaInv(long double* res, const long double* a, const long double* b, const long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetacInv(long double* res, const long double* a, const long double* b, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetaInva(long double* res, const long double* b, const long double* x, const long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetacInva(long double* res, const long double* b, const long double* x, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetaInvb(long double* res, const long double* a, const long double* x, const long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetacInvb(long double* res, const long double* a, const long double* x, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_IBetaDerivative(long double* res, const long double* a, const long double* b, const long double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LegendrePM(long double* res, const int n, const int m, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LaguerreM(long double* res, const int n, const int m, const long double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_EllipticRF(long double* res, const long double* x, const long double* y, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_EllipticRD(long double* res, const long double* x, const long double* y, const long double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ellint3F(long double* res, const long double* k, const long double* n, const long double* phi);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SphericalHarmonicR(long double* res, const int n, const int m, const long double* theta, const long double* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SphericalHarmonicI(long double* res, const int n, const int m, const long double* theta, const long double* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_EllipticRJ(long double* res, const long double* x, const long double* y, const long double* z, const long double* p);



// Hypergeometric and Theta Functions



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Hypergeo0F1(long double* res, const long double* b, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Hypergeo1F1(long double* res, const long double* a, const long double* b, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Hypergeo1F1r(long double* res, const long double* a, const long double* b, const long double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LogHypergeo1F1(long double* res, const long double* a, const long double* b, const long double* x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiTheta1(long double* res, const long double* x, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiTheta2(long double* res, const long double* x, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiTheta3(long double* res, const long double* x, const long double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_JacobiTheta4(long double* res, const long double* x, const long double* q);






//*********************** Boost Distributions, extended precision **********************************


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_ArcsineDist(long Target, long double* res, long double* xqp, long double* a, long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BernoulliDist(long Target, long double* res, long double* xqp, long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BetaDist(long Target, long double* res, long double* xqp, long double* a, long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BinomialDist(long Target, long double* res, long double* xqp, long double* n, long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_CauchyDist(long Target, long double* res, long double* x, long double* location, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Chi2Dist(long Target, long double* res, long double* xqp, long double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_ExponentialDist(long Target, long double* res, long double* xqp, long double* lambda);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GumbelDist(long Target, long double* res, long double* xqp, long double* location, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_FisherFDist(long Target, long double* res, long double* xqp, long double* mu, long double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GammaDist(long Target, long double* res, long double* xqp, long double* shape, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GeometricDist(long Target, long double* res, long double* xqp, long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_HypergeometricDist(long Target, long double* res, long double* x, unsigned r, unsigned n, unsigned N);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_InverseChi2Dist(long Target, long double* res, long double* xqp, long double* df, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_InverseGammaDist(long Target, long double* res, long double* xqp, long double* shape, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_WaldDist(long Target, long double* res, long double* xqp, long double* mean_, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LaplaceDist(long Target, long double* res, long double* xqp, long double* location, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LogisticDist(long Target, long double* res, long double* xqp, long double* location, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_LognormalDist(long Target, long double* res, long double* xqp, long double* location, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_NegBinomialDist(long Target, long double* res, long double* xqp, long double* n, long double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Chi2NcDist(long Target, long double* res, long double* xqp, long double* nu, long double* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_StudentTNcDist(long Target, long double* res, long double* xqp, long double* nu, long double* delta);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_FisherNcDist(long Target, long double* res, long double* xqp, long double* mu, long double* nu, long double* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BetaNcDist(long Target, long double* res, long double* xqp, long double* a, long double* b, long double* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_NormalDist(long Target, long double* res, long double* xqp, long double* mean_, long double* stdev);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_ParetoDist(long Target, long double* res, long double* xqp, long double* shape, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_PoissonDist(long Target, long double* res, long double* xqp, long double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_RayleighDist(long Target, long double* res, long double* xqp, long double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SkewNormalDist(long Target, long double* res, long double* xqp, long double* mean_, long double* scale, long double* shape);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_StudentTDist(long Target, long double* res, long double* xqp, long double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_TriangularDist(long Target, long double* res, long double* xqp, long double* lower, long double* mode_, long double* upper);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_WeibullDist(long Target, long double* res, long double* xqp, long double* shape, long double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_UniformDist(long Target, long double* res, long double* xqp, long double* lower, long double* upper);











//*********************** Boost Numerical Calculus, extended precision **********************************


typedef void(*XRealFuncPtr) (void*, void*);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_BracketRoot(long double* res1, long double* res2, int* iter, XRealFuncPtr f1, long double* guess, long double* factor, bool is_rising, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_NewtonRaphson(long double* res,  int* iter, XRealFuncPtr f1, XRealFuncPtr f2, long double* guess, long double* xmin, long double* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Halley(long double* res,  int* iter, XRealFuncPtr f1, XRealFuncPtr f2, XRealFuncPtr f3, long double* guess, long double* xmin, long double* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Schroder(long double* res,  int* iter, XRealFuncPtr f1, XRealFuncPtr f2, XRealFuncPtr f3, long double* guess, long double* xmin, long double* xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Brent_Minimum(long double* res, long double* resFx, int* iter, XRealFuncPtr f1, long double* bracket_min, long double* bracket_max, int bits, unsigned int maxit);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Trapezoidal(long double* res1, long double* res2, long double* res3, XRealFuncPtr f1, long double* a, long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GaussLegendre(long double* res1, long double* res3, XRealFuncPtr f1, long double* a, long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_GaussKronrod(long double* res1, long double* res2, long double* res3, XRealFuncPtr f1, long double* a, long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_TanhSinh(long double* res1, long double* res2, long double* res3, int* levels_, XRealFuncPtr f1, long double* a, long double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_SinhSinh(long double* res1, long double* res2, long double* res3, int* levels_, XRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_ExpSinh(long double* res1, long double* res2, long double* res3, int* levels_, XRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ooura_Cos(long double* res1, long double* res2, XRealFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Ooura_Sin(long double* res1, long double* res2, XRealFuncPtr f1);










//*********************** Boost Odeint, extended precision **********************************

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Const_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Const_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Const_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Adaptive_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Adaptive_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Adaptive_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_XReal_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel);











#endif // MPNUMC_XREAL_H_INCLUDED












