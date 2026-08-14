
#ifndef MPNUMC_OREAL_H_INCLUDED
#define MPNUMC_OREAL_H_INCLUDED




//*********************** Flint **********************************





//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Set_Arb(ORealPtr res, const ArbPtr x);

//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Set_Mpfr(ORealPtr res, const MpfrPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Set_Acb(OCplxPtr res, const ArbPtr x);



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Sqrt(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Rsqrt(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Cbrt(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Sqrt1pm1(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Root_ui(ORealPtr res, const ORealPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Root_si(ORealPtr res, const ORealPtr x, const int32_t n);



/* Exponential and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Exp(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Exp10(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Exp2(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Expm1(ORealPtr res, const ORealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Exp10m1(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Exp2m1(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_ExpRel(ORealPtr res, const ORealPtr x);





/* Logarithms and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Logbase(ORealPtr res, const ORealPtr x, const ORealPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Log(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Log10(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Log2(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Log1p(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Log10p1(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Log2p1(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Log1mexp(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LambertW0(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LambertWm1(ORealPtr res, const ORealPtr x);





/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Square(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Cube(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypot(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Pow_ui(ORealPtr res, const ORealPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Pow_si(ORealPtr res, const ORealPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Compound_si(ORealPtr res, const ORealPtr x, const int32_t n);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Pow(ORealPtr res, const ORealPtr x, const ORealPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Powm1(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Pow1p(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Pow1pm1(ORealPtr res, const ORealPtr x, const ORealPtr y);



/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Sin(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Cos(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Tan(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Cot(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Csc(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Sec(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Sinc(ORealPtr res, const ORealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_SinPi(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_CosPi(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_TanPi(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_CotPi(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_SincPi(ORealPtr res, const ORealPtr x);


/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Sinh(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Cosh(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Tanh(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Coth(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Csch(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Sech(ORealPtr res, const ORealPtr x);




/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Asin(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Acos(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Atan2(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Atan(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Acot(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Acsc(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Asec(ORealPtr res, const ORealPtr x);




/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Asinh(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Acosh(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Atanh(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Acoth(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Acsch(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Asech(ORealPtr res, const ORealPtr x);





/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_MEllipticK(ORealPtr res, const ORealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_MEllipticE(ORealPtr res, const ORealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_MEllipticPi(ORealPtr res, const ORealPtr n, const ORealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_MEllipticF(ORealPtr res, const ORealPtr phi, const ORealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_MEllipticEInc(ORealPtr res, const ORealPtr phi, const ORealPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_MEllipticPiInc(ORealPtr res, const ORealPtr n, const ORealPtr phi, const ORealPtr m);



/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_EllipticK(ORealPtr res, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_EllipticE(ORealPtr res, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_EllipticPi(ORealPtr res, const ORealPtr n, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_EllipticF(ORealPtr res, const ORealPtr phi, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_EllipticEInc(ORealPtr res, const ORealPtr phi, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_EllipticPiInc(ORealPtr res, const ORealPtr n, const ORealPtr phi, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Agm(ORealPtr res, const ORealPtr x, const ORealPtr y);



/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Elliptic_RC(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Elliptic_RF(ORealPtr res, const ORealPtr x, const ORealPtr y, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Elliptic_RG(ORealPtr res, const ORealPtr x, const ORealPtr y, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Elliptic_RD(ORealPtr res, const ORealPtr x, const ORealPtr y, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Elliptic_RJ(ORealPtr res, const ORealPtr x, const ORealPtr y, const ORealPtr z, const ORealPtr w);




/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Theta1Q(ORealPtr res, const ORealPtr z, const ORealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Theta2Q(ORealPtr res, const ORealPtr z, const ORealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Theta3Q(ORealPtr res, const ORealPtr z, const ORealPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Theta4Q(ORealPtr res, const ORealPtr z, const ORealPtr q);



/* Jacobi elliptic functions */



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiSN(ORealPtr res, const ORealPtr u, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiCN(ORealPtr res, const ORealPtr u, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiDN(ORealPtr res, const ORealPtr u, const ORealPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiNS(ORealPtr res, const ORealPtr u, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiNC(ORealPtr res, const ORealPtr u, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiND(ORealPtr res, const ORealPtr u, const ORealPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiSC(ORealPtr res, const ORealPtr u, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiSD(ORealPtr res, const ORealPtr u, const ORealPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiDC(ORealPtr res, const ORealPtr u, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiDS(ORealPtr res, const ORealPtr u, const ORealPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiCS(ORealPtr res, const ORealPtr u, const ORealPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiCD(ORealPtr res, const ORealPtr u, const ORealPtr k);







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LerchPhi(ORealPtr res, const ORealPtr z, const ORealPtr s, const ORealPtr a);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Polygamma(ORealPtr res, const ORealPtr s, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Digamma(ORealPtr res, const ORealPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Polylog(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Dilog(ORealPtr res, const ORealPtr x);





/* Hurwitz zeta function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_HurwitzZeta(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Bernoulli_ui(ORealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BernoulliPoly_ui(ORealPtr res, const ORealPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Euler_ui(ORealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BarnesG(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LogBarnesG(ORealPtr res, const ORealPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Zeta(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BacklundS(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_GramPoint_ui(ORealPtr res, const int32_t n);




/* Additional numbertheoretic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Bell_ui(ORealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Partitions_ui(ORealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Primorial_ui(ORealPtr res, const int32_t n);





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypgeom0F1(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypgeom0F1r(ORealPtr res, const ORealPtr x, const ORealPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BesselJ(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BesselY(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BesselI(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BesselK(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BesselIScaled(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BesselKScaled(ORealPtr res, const ORealPtr x, const ORealPtr y);



/* Spherical Bessel functions  */




/* Airy functions  */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_AiryAi(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_AiryAiPrime(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_AiryBi(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_AiryBiPrime(ORealPtr res, const ORealPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_AiryAiZero(ORealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_AiryAiPrimeZero(ORealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_AiryBiZero(ORealPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_AiryBiPrimeZero(ORealPtr res, const int32_t n);



/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypgeom1F1(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypgeom1F1r(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_HypgeomU(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);




/* Gamma function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Gamma(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Rgamma(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Lgamma(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_RisingFactorial(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Beta(ORealPtr res, const ORealPtr x, const ORealPtr y);



/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_GammaUpper(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_GammaQ(ORealPtr res, const ORealPtr x, const ORealPtr y);

// Missing: Tricomi

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_GammaLower(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_GammaP(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_GammaPPrime(ORealPtr res, const ORealPtr x, const ORealPtr y);



/* Error function and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Erf(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Erfc(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_ErfInv(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_ErfcInv(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Erfi(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_FresnelC(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_FresnelS(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Ndens(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Ndis(ORealPtr res, const ORealPtr x);





/* Exponential integrals and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_ExpIntegralE(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_ExpIntegralEi(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_SinIntegral(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_CosIntegral(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_SinhIntegral(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_CoshIntegral(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LogIntegral(ORealPtr res, const ORealPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LogIntegralOffset(ORealPtr res, const ORealPtr x);



/* 1F1: Orthogonal polynomials */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_HermiteH(ORealPtr res, const ORealPtr x, const ORealPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LaguerreL(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);




/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_CoulombF(ORealPtr res, const ORealPtr l, const ORealPtr eta, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_CoulombG(ORealPtr res, const ORealPtr l, const ORealPtr eta, const ORealPtr z);




/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypgeom2F1(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr c, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypgeom2F1r(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr c, const ORealPtr z);





/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_ChebyshevT(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_ChebyshevU(ORealPtr res, const ORealPtr x, const ORealPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_GegenbauerC(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_JacobiP(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr c, const ORealPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LegendreP(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LegendrePv(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LegendreQ(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_LegendreQv(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);




/* 2F1: Incomplete Beta Function */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_BetaLower(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Ibeta(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Ibetac(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_IbetaPrime(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z);




/* Hypergeometric Function 1F2, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypgeom1F2(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr c, const ORealPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OReal_Arb_Hypgeom1F2r(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr c, const ORealPtr z);








//////////////////////////////////////////////////////
//// Acb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Sqrt(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Rsqrt(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Cbrt(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Sqrt1pm1(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_UnitRoot_ui(OCplxPtr res, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Root_ui(OCplxPtr res, const OCplxPtr x, const int32_t n);




/* Exponential and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Exp(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Expj(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Expjpi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Exp10(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Exp2(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Expm1(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Exp10m1(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Exp2m1(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ExpRel(OCplxPtr res, const OCplxPtr x);





/* Logarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Logbase(OCplxPtr res, const OCplxPtr x, const OCplxPtr b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Log(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Log10(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Log2(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Log1p(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Log10p1(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Log2p1(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LambertW_ui(OCplxPtr res, const OCplxPtr x, const int32_t n);




/* Power functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Square(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Cube(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypot(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Pow_si(OCplxPtr res, const OCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Pow(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Powm1(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Pow1p(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Pow1pm1(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);





/* Trigonometric and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Sin(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Cos(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Tan(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Csc(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Sec(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Cot(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Sinc(OCplxPtr res, const OCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_SinPi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CosPi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_TanPi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CotPi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CscPi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_SecPi(OCplxPtr res, const OCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_SincPi(OCplxPtr res, const OCplxPtr x);






/* Hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Sinh(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Cosh(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Tanh(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Csch(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Sech(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Coth(OCplxPtr res, const OCplxPtr x);





/* Inverse trigonometric functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Asin(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Acos(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Atan(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Acsc(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Asec(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Acot(OCplxPtr res, const OCplxPtr x);





/* Inverse hyperbolic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Asinh(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Acosh(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Atanh(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Acsch(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Asech(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Acoth(OCplxPtr res, const OCplxPtr x);








/* Legendre elliptic integrals (elliptic parameter m) */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_MEllipticK(OCplxPtr res, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_MEllipticE(OCplxPtr res, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_MEllipticPi(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_MEllipticF(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_MEllipticEInc(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_MEllipticPiInc(OCplxPtr res, const OCplxPtr n, const OCplxPtr phi, const OCplxPtr m);




/* Legendre elliptic integrals (elliptic modulus k), and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticK(OCplxPtr res, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticE(OCplxPtr res, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticPi(OCplxPtr res, const OCplxPtr phi, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticF(OCplxPtr res, const OCplxPtr phi, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticEInc(OCplxPtr res, const OCplxPtr phi, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticPiInc(OCplxPtr res, const OCplxPtr n, const OCplxPtr phi, const OCplxPtr k);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Agm(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);




/* Carlson symmetric elliptic integrals */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Elliptic_RC(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Elliptic_RF(OCplxPtr res, const OCplxPtr x, const OCplxPtr y, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Elliptic_RG(OCplxPtr res, const OCplxPtr x, const OCplxPtr y, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Elliptic_RD(OCplxPtr res, const OCplxPtr x, const OCplxPtr y, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Elliptic_RJ(OCplxPtr res, const OCplxPtr x, const OCplxPtr y, const OCplxPtr z, const OCplxPtr w);





/* Jacobi theta functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Theta1Q(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Theta2Q(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Theta3Q(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Theta4Q(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Theta1Tau(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Theta2Tau(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Theta3Tau(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Theta4Tau(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m);




/* Jacobi elliptic functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_QfromK(OCplxPtr res, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_TfromUQ(OCplxPtr res, const OCplxPtr u, const OCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_SnTQ(OCplxPtr res, const OCplxPtr t, const OCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CnTQ(OCplxPtr res, const OCplxPtr t, const OCplxPtr q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_DnTQ(OCplxPtr res, const OCplxPtr t, const OCplxPtr q);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiSN(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiCN(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiDN(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiNS(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiNC(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiND(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiSC(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiSD(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiDC(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiDS(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiCS(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiCD(OCplxPtr res, const OCplxPtr u, const OCplxPtr k);






/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_WeierstrassP(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_WeierstrassPInv(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_WeierstrassPZeta(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_WeierstrassPSigma(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_WeierstrassPPrime(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticInvariantG2(OCplxPtr res, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticInvariantG3(OCplxPtr res, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticRootE1(OCplxPtr res, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticRootE2(OCplxPtr res, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EllipticRootE3(OCplxPtr res, const OCplxPtr tau);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_DedekindEta(OCplxPtr res, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_KleinJ(OCplxPtr res, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ModularLambda(OCplxPtr res, const OCplxPtr tau);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ModularDelta(OCplxPtr res, const OCplxPtr tau);





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LerchPhi(OCplxPtr res, const OCplxPtr z, const OCplxPtr s, const OCplxPtr a);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LerchZeta(OCplxPtr res, const OCplxPtr lambda1, const OCplxPtr alpha, const OCplxPtr s);




/* Polygamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Polygamma(OCplxPtr res, const OCplxPtr s, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Trigamma(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Digamma(OCplxPtr res, const OCplxPtr x);




/* Polylogarithms and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Polylog(OCplxPtr res, const OCplxPtr s, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Trilog(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Dilog(OCplxPtr res, const OCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ClausenSin(OCplxPtr res, const OCplxPtr s, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ClausenCos(OCplxPtr res, const OCplxPtr s, const OCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Clausen2(OCplxPtr res, const OCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BoseEinstein(OCplxPtr res, const OCplxPtr s, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_FermiDirac(OCplxPtr res, const OCplxPtr s, const OCplxPtr z);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LegendreChi(OCplxPtr res, const OCplxPtr s, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_InverseTanIntegral(OCplxPtr res, const OCplxPtr s, const OCplxPtr z);





/* Hurwitz zeta function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_HurwitzZeta(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Stieltjes_ui(OCplxPtr res, const OCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BernoulliPoly_ui(OCplxPtr res, const OCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Harmonic(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Harmonic2(OCplxPtr res, const OCplxPtr z, const OCplxPtr r);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_EulerPoly_ui(OCplxPtr res, const OCplxPtr x, const int32_t n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hyperfactorial(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Superfactorial(OCplxPtr res, const OCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BarnesG(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LogBarnesG(OCplxPtr res, const OCplxPtr x);




/* Riemann zeta function, and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Zeta(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Zetam1(OCplxPtr res, const OCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_DirichletXi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_DirichletEta(OCplxPtr res, const OCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_DirichletEtam1(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_DirichletBeta(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_DirichletLambda(OCplxPtr res, const OCplxPtr x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_HardyZ(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_HardyTheta(OCplxPtr res, const OCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ZetaZero_ui(OCplxPtr res, const int32_t n);



/* Additional numbertheoretic functions */





/* Confluent Hypergeometric Limit Function 0F1, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypgeom0F1(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypgeom0F1r(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);




/* Bessel functions and modified Bessel functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BesselJ(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BesselY(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BesselI(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BesselK(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BesselIScaled(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BesselKScaled(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);





/* Spherical Bessel functions  */



/* Airy functions  */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_AiryAi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_AiryAiPrime(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_AiryBi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_AiryBiPrime(OCplxPtr res, const OCplxPtr x);




/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_HypgeomU(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypgeom1F1(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypgeom1F1r(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);






/* Gamma function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Gamma(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Rgamma(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Lgamma(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_RisingFactorial(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Beta(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);




/* Incomplete gamma functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_GammaUpper(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_GammaLower(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_GammaPPrime(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_GammaP(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_GammaQ(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);





/* Error function and related functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Erf(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Erfc(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Erfi(OCplxPtr res, const OCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_FresnelC(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_FresnelS(OCplxPtr res, const OCplxPtr x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Ndens(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Ndis(OCplxPtr res, const OCplxPtr x);




/* Exponential integrals and related functions */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ExpIntegralE(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ExpIntegralEi(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_SinIntegral(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CosIntegral(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_SinhIntegral(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CoshIntegral(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LogIntegral(OCplxPtr res, const OCplxPtr x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LogIntegralOffset(OCplxPtr res, const OCplxPtr x);





/* 1F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_HermiteH(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LaguerreL(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);






/* 1F1: Coulomb functions */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CoulombF(OCplxPtr res, const OCplxPtr l, const OCplxPtr eta, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CoulombG(OCplxPtr res, const OCplxPtr l, const OCplxPtr eta, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CoulombHpos(OCplxPtr res, const OCplxPtr l, const OCplxPtr eta, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_CoulombHneg(OCplxPtr res, const OCplxPtr l, const OCplxPtr eta, const OCplxPtr z);






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypgeom2F1(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr c, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypgeom2F1r(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr c, const OCplxPtr z);




/* 2F1: Orthogonal polynomials */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ChebyshevT(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_ChebyshevU(OCplxPtr res, const OCplxPtr x, const OCplxPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_GegenbauerC(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_JacobiP(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr c, const OCplxPtr z);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LegendreP(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LegendrePv(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LegendreQ(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_LegendreQv(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_SphericalY(OCplxPtr res, const OCplxPtr n, const OCplxPtr m, const OCplxPtr theta, const OCplxPtr phi);





/* 2F1: Incomplete Beta Function */


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_BetaLower(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Ibeta(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Ibetac(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_IbetaPrime(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z);





/* Hypergeometric Function 1F2, overview */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypgeom1F2(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr c, const OCplxPtr z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_OCplx_Acb_Hypgeom1F2r(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr c, const OCplxPtr z);









#endif // MPNUMC_OREAL_H_INCLUDED








