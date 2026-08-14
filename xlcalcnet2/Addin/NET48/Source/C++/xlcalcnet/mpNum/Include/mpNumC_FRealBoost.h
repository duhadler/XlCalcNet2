

#ifndef MPNUMC_FREALBOOST_H_INCLUDED
#define MPNUMC_FREALBOOST_H_INCLUDED








//*********************** Boost Special functions , double precision **********************************


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BernoulliB2n(double* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TangentT2n(double* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Sqrt1pm1_Boost(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SinPi_Boost(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_CosPi_Boost(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SincPi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SinhcPi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Tgamma_(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Tgamma1pm1(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Digamma(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Lgamma_(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Trigamma(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Factorial(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_DoubleFactorial(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erf_(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erfc_(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erf_inv(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Erfc_inv(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_AiryAi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_AiryBi(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_AiryAiPrime(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_AiryBiPrime(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Aizero(double* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Bizero(double* res, const int n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint_1_K(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint_2_K(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Zeta(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ei(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LambertW0(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LambertWm1(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LambertW0Prime(double* res, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LambertWm1Prime(double* res, const double* x);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Powm1_Boost(double* res, const double* a, const double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TgammaRatio(double* res, const double* a, const double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TgammaDeltaRatio(double* res, const double* a, const double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Binomial(double* res, const double* n, const double* k);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_RisingFactorial(double* res, const double* x, const double* n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_FallingFactorial(double* res, const double* x, const double* n);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJ(double* res, const double* v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselY(double* res, const double* v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselI(double* res, const double* v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselK(double* res, const double* v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphBessel(double* res, const unsigned v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphNeumann(double* res, const unsigned v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJPrime(double* res, const double* v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselYPrime(double* res, const double* v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselIPrime(double* res, const double* v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselKPrime(double* res, const double* v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphBesselPrime(double* res, const unsigned v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphNeumannPrime(double* res, const unsigned v, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselJZero(double* res, const double* v, const int m);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BesselYZero(double* res, const double* v, const int m);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaP(double* res, const double* a, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaQ(double* res, const double* a, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TgammaLower(double* res, const double* a, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TgammaUpper(double* res, const double* a, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaPInv(double* res, const double* a, const double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaQInv(double* res, const double* a, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaPInva(double* res, const double* x, const double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaQInva(double* res, const double* x, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaPDerivative(double* res, const double* a, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Beta(double* res, const double* a, const double* b);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LegendreP(double* res, int n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LegendreQ(double* res, int n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Laguerre(double* res, int n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hermite(double* res, int n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ChebyshevT(double* res, int n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ChebyshevU(double* res, int n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Polygamma(double* res, int n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_EllintRC(double* res, const double* x, const double* y);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint1F(double* res, const double* k, const double* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint2F(double* res, const double* k, const double* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint3K(double* res, const double* k, const double* n);




MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiCD(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiCN(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiCS(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiDC(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiDN(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiDS(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiNC(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiND(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiNS(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiSC(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiSD(double* res, const double* k, const double* u);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiSN(double* res, const double* k, const double* u);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_expint(double* res, const unsigned n, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_OwenT(double* res, const double* h, const double* a);





MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBeta(double* res, const double* a, const double* b, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetac(double* res, const double* a, const double* b, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaNonNormalized(double* res, const double* a, const double* b, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetacNonNormalized(double* res, const double* a, const double* b, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaInv(double* res, const double* a, const double* b, const double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetacInv(double* res, const double* a, const double* b, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaInva(double* res, const double* b, const double* x, const double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetacInva(double* res, const double* b, const double* x, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaInvb(double* res, const double* a, const double* x, const double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetacInvb(double* res, const double* a, const double* x, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_IBetaDerivative(double* res, const double* a, const double* b, const double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LegendrePM(double* res, const int n, const int m, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LaguerreM(double* res, const int n, const int m, const double* x);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_EllipticRF(double* res, const double* x, const double* y, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_EllipticRD(double* res, const double* x, const double* y, const double* z);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Ellint3F(double* res, const double* k, const double* n, const double* phi);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphericalHarmonicR(double* res, const int n, const int m, const double* theta, const double* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SphericalHarmonicI(double* res, const int n, const int m, const double* theta, const double* phi);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_EllipticRJ(double* res, const double* x, const double* y, const double* z, const double* p);



// Hypergeometric and Theta Functions



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hypergeo0F1(double* res, const double* b, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hypergeo1F1(double* res, const double* a, const double* b, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Hypergeo1F1r(double* res, const double* a, const double* b, const double* x);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LogHypergeo1F1(double* res, const double* a, const double* b, const double* x);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiTheta1(double* res, const double* x, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiTheta2(double* res, const double* x, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiTheta3(double* res, const double* x, const double* q);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_JacobiTheta4(double* res, const double* x, const double* q);








//*********************** Boost Distributions, double precision **********************************



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ArcsineDist(long Target, double* res, double* xqp, double* a, double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BernoulliDist(long Target, double* res, double* xqp, double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BetaDist(long Target, double* res, double* xqp, double* a, double* b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BinomialDist(long Target, double* res, double* xqp, double* n, double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_CauchyDist(long Target, double* res, double* x, double* location, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Chi2Dist(long Target, double* res, double* xqp, double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ExponentialDist(long Target, double* res, double* xqp, double* lambda);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GumbelDist(long Target, double* res, double* xqp, double* location, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_FisherFDist(long Target, double* res, double* xqp, double* mu, double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GammaDist(long Target, double* res, double* xqp, double* shape, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_GeometricDist(long Target, double* res, double* xqp, double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_HypergeometricDist(long Target, double* res, double* x, unsigned r, unsigned n, unsigned N);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_InverseChi2Dist(long Target, double* res, double* xqp, double* df, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_InverseGammaDist(long Target, double* res, double* xqp, double* shape, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_WaldDist(long Target, double* res, double* xqp, double* mean_, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LaplaceDist(long Target, double* res, double* xqp, double* location, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LogisticDist(long Target, double* res, double* xqp, double* location, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_LognormalDist(long Target, double* res, double* xqp, double* location, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_NegBinomialDist(long Target, double* res, double* xqp, double* n, double* p);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_Chi2NcDist(long Target, double* res, double* xqp, double* nu, double* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_StudentTNcDist(long Target, double* res, double* xqp, double* nu, double* delta);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_FisherNcDist(long Target, double* res, double* xqp, double* mu, double* nu, double* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_BetaNcDist(long Target, double* res, double* xqp, double* a, double* b, double* nc);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_NormalDist(long Target, double* res, double* xqp, double* mean_, double* stdev);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_ParetoDist(long Target, double* res, double* xqp, double* shape, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_PoissonDist(long Target, double* res, double* xqp, double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_RayleighDist(long Target, double* res, double* xqp, double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_SkewNormalDist(long Target, double* res, double* xqp, double* mean_, double* scale, double* shape);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_StudentTDist(long Target, double* res, double* xqp, double* nu);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_TriangularDist(long Target, double* res, double* xqp, double* lower, double* mode_, double* upper);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_WeibullDist(long Target, double* res, double* xqp, double* shape, double* scale);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_FReal_UniformDist(long Target, double* res, double* xqp, double* lower, double* upper);








//*********************** Boost Numerical Calculus, double precision, Double **********************************


typedef double(*DoubleFuncPtr) (double);


MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_BracketRoot(double* res1, double* res2, int* iter, DoubleFuncPtr f1, double guess, double factor, bool is_rising, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_NewtonRaphson(double* res,  int* iter, DoubleFuncPtr f1, DoubleFuncPtr f2, double guess, double xmin, double xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_Halley(double* res,  int* iter, DoubleFuncPtr f1, DoubleFuncPtr f2, DoubleFuncPtr f3, double guess, double xmin, double xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_Schroder(double* res,  int* iter, DoubleFuncPtr f1, DoubleFuncPtr f2, DoubleFuncPtr f3, double guess, double xmin, double xmax, int get_digits, unsigned int maxit);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_Brent_Minimum(double* res, double* resFx, int* iter, DoubleFuncPtr f1, double bracket_min, double bracket_max, int bits, unsigned int maxit);



MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_Trapezoidal(double* res1, double* res2, double* res3, DoubleFuncPtr f1, double a, double b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_GaussLegendre(double* res1, double* res3, DoubleFuncPtr f1, double a, double b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_GaussKronrod(double* res1, double* res2, double* res3, DoubleFuncPtr f1, double a, double b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_TanhSinh(double* res1, double* res2, double* res3, int* levels_, DoubleFuncPtr f1, double a, double b);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_SinhSinh(double* res1, double* res2, double* res3, int* levels_, DoubleFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_ExpSinh(double* res1, double* res2, double* res3, int* levels_, DoubleFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_Ooura_Cos(double* res1, double* res2, DoubleFuncPtr f1);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Double_Ooura_Sin(double* res1, double* res2, DoubleFuncPtr f1);





#endif // MPNUMC_FREALBOOST_H_INCLUDED



