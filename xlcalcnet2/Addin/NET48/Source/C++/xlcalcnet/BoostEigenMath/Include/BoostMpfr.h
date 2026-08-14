

typedef void* MpfrPtr;

typedef void* MpfrStatePtr;

typedef void(*MpfrFuncPtr) (void*, void*);
typedef void(*MpfrAnyFuncPtr2) (const void*,const  void*);
typedef void(*MpfrAnyFuncPtr3) (const void*,const  void*,const  void*);


////*********************** Boost/CppOptLib **********************************


void LibMpfr_LbfgsSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr);

void LibMpfr_BfgsSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr);


void LibMpfr_GradientDescentSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr);

void LibMpfr_ConjugatedGradientDescentSolver(MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX_, MpfrStatePtr matGrad_, MpfrStatePtr matNorm_, MpfrStatePtr xPtr, MpfrStatePtr resPtr);



void LibMpfr_CppOptLibDirect1(long what, MpfrFuncPtr f1, MpfrStatePtr matX, MpfrStatePtr matNorm, MpfrStatePtr xPtr, MpfrStatePtr resPtr);

void LibMpfr_CppOptLibDirect2(long what, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrStatePtr matX, MpfrStatePtr matGrad, MpfrStatePtr matNorm, MpfrStatePtr xPtr, MpfrStatePtr resPtr);

void LibMpfr_CppOptLibDirect3(long what, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrStatePtr matX, MpfrStatePtr matHessian, MpfrStatePtr matGrad, MpfrStatePtr matNorm, MpfrStatePtr xPtr, MpfrStatePtr resPtr);





//*********************** Boost Odeint, DReal  **********************************

MpfrStatePtr LibMpfr_StateInit_Func_N(int N, int digits);

void LibMpfr_StateClear(MpfrStatePtr x);

void LibMpfr_StateGetCoeff(MpfrPtr res, long row, MpfrStatePtr source, int digits);

void LibMpfr_StateSetCoeff(MpfrStatePtr result, MpfrPtr source, long row, int digits);

void LibMpfr_StateGetSize(long *result, MpfrStatePtr x);


void LibMpfr_Const_RungeKutta4(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);

void LibMpfr_Const_RungeKuttaCashKarp54(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);

void LibMpfr_Const_RungeKuttaDopri5(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);

void LibMpfr_Const_RungeKuttaFehlberg78(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);

void LibMpfr_Const_AdamsBashforthMoulton(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits);


void LibMpfr_Adaptive_RungeKuttaDopri5(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

void LibMpfr_Adaptive_RungeKuttaCashKarp54(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

void LibMpfr_Adaptive_RungeKuttaFehlberg78(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

void LibMpfr_Adaptive_BulirschStoer(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

void LibMpfr_DenseOutput_Dopri5(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);

void LibMpfr_DenseOutput_BulirschStoer(MpfrAnyFuncPtr3 f1, MpfrAnyFuncPtr2 f2, MpfrStatePtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits);






//*********************** Boost Numerical Calculus, Mpfr **********************************

void LibMpfr_BracketRoot(MpfrPtr res1, MpfrPtr res2, int* iter, MpfrFuncPtr f1, MpfrPtr guess_, MpfrPtr factor_, bool is_rising, int get_digits, unsigned int maxit);

void LibMpfr_NewtonRaphson(MpfrPtr res,  int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit);

void LibMpfr_Halley(MpfrPtr res, int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit);

void LibMpfr_Schroder(MpfrPtr res, int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit);

void LibMpfr_Brent_Minimum(MpfrPtr res, MpfrPtr resFx, int* iter, MpfrFuncPtr f1, MpfrPtr bracket_min_, MpfrPtr bracket_max_, int bits, unsigned int maxit);



void LibMpfr_Trapezoidal(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits);

void LibMpfr_GaussLegendre(MpfrPtr res1, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits);

void LibMpfr_GaussKronrod(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits);

void LibMpfr_TanhSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits);

void LibMpfr_SinhSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, int get_digits);

void LibMpfr_ExpSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, int get_digits);

void LibMpfr_Ooura_Cos(MpfrPtr res1, MpfrPtr res2, MpfrFuncPtr f1, int get_digits);

void LibMpfr_Ooura_Sin(MpfrPtr res1, MpfrPtr res2, MpfrFuncPtr f1, int get_digits);





//*********************** Boost Distributions, Mpfr **********************************


void LibMpfr_ArcsineDist(long Target, MpfrPtr res, MpfrPtr x, MpfrPtr a, MpfrPtr b, int dps);

void LibMpfr_BernoulliDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr p, int dps);

void LibMpfr_BetaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, int dps);

void LibMpfr_BinomialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, MpfrPtr p, int dps);

void LibMpfr_CauchyDist(long Target, MpfrPtr res, MpfrPtr x, MpfrPtr location, MpfrPtr scale, int dps);

void LibMpfr_Chi2Dist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

void LibMpfr_ExponentialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lambda, int dps);

void LibMpfr_ExtremeValueDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps);

void LibMpfr_FisherFDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mu, MpfrPtr nu, int dps);

void LibMpfr_GammaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps);

void LibMpfr_GeometricDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr p, int dps);

void LibMpfr_HypergeometricDist(long Target, MpfrPtr res, MpfrPtr x, unsigned r, unsigned n, unsigned N, int dps);

void LibMpfr_InverseChi2Dist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr df, MpfrPtr scale, int dps);

void LibMpfr_InverseGammaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps);

void LibMpfr_InverseGaussianDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr scale, int dps);

void LibMpfr_LaplaceDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps);

void LibMpfr_LogisticDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps);

void LibMpfr_LognormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps);

void LibMpfr_NegBinomialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, MpfrPtr p, int dps);

void LibMpfr_Chi2NCDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, MpfrPtr nc, int dps);

void LibMpfr_StudentTNCDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, MpfrPtr delta, int dps);

void LibMpfr_FisherNCDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mu, MpfrPtr nu, MpfrPtr nc, int dps);

void LibMpfr_BetaNCDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, MpfrPtr nc, int dps);

void LibMpfr_NormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr stdev, int dps);

void LibMpfr_ParetoDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps);

void LibMpfr_PoissonDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

void LibMpfr_RayleighDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

void LibMpfr_SkewNormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr scale, MpfrPtr shape, int dps);

void LibMpfr_StudentTDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

void LibMpfr_TriangularDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lower, MpfrPtr mode_, MpfrPtr upper, int dps);

void LibMpfr_WeibullDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps);

void LibMpfr_UniformDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lower, MpfrPtr upper, int dps);


void LibMpfr_Logaddexp(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const int dps);

void LibMpfr_KolmogorovSmirnovDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps);

void LibMpfr_HyperexponentialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrStatePtr l1, MpfrStatePtr l2, int dps);








void LibMpfr_Set(MpfrPtr res, const MpfrPtr x);




//*********************** Boost Special functions , Mpfr **********************************

void LibMpfr_BernoulliB2n(MpfrPtr res, const int n, int const dps);

void LibMpfr_TangentT2n(MpfrPtr res, const int n, int const dps);


void LibMpfr_Sqrt1pm1(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_SinPi(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_CosPi(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_SincPi(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_SinhcPi(MpfrPtr res, const MpfrPtr x, int const dps);



void LibMpfr_Tgamma_(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Tgamma1pm1(MpfrPtr res, const MpfrPtr x, int const dps);



void LibMpfr_Lgamma_(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Digamma(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Trigamma(MpfrPtr res, const MpfrPtr x, int const dps);


void LibMpfr_Factorial(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_DoubleFactorial(MpfrPtr res, const MpfrPtr x, int const dps);


void LibMpfr_Erf_(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Erfc_(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Erf_inv(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Erfc_inv(MpfrPtr res, const MpfrPtr x, int const dps);


void LibMpfr_AiryAi(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_AiryBi(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_AiryAiPrime(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_AiryBiPrime(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Aizero(MpfrPtr res, int n, int const dps);

void LibMpfr_Bizero(MpfrPtr res, int n, int const dps);


void LibMpfr_Ellint_1_K(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Ellint_2_K(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Zeta(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_Ei(MpfrPtr res, const MpfrPtr x, int const dps);


void LibMpfr_LambertW0(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_LambertWm1(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_LambertW0Prime(MpfrPtr res, const MpfrPtr x, int const dps);

void LibMpfr_LambertWm1Prime(MpfrPtr res, const MpfrPtr x, int const dps);


void LibMpfr_Agm(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);


void LibMpfr_Powm1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);

void LibMpfr_TgammaRatio(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);

void LibMpfr_TgammaDeltaRatio(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);


void LibMpfr_Binomial(MpfrPtr res, const MpfrPtr n, const MpfrPtr k, int const dps);

void LibMpfr_RisingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr n, int const dps);

void LibMpfr_FallingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr n, int const dps);


void LibMpfr_BesselJ(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

void LibMpfr_BesselY(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

void LibMpfr_BesselI(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

void LibMpfr_BesselK(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

void LibMpfr_SphBessel(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps);

void LibMpfr_SphNeumann(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps);


void LibMpfr_BesselJPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

void LibMpfr_BesselYPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

void LibMpfr_BesselIPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

void LibMpfr_BesselKPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps);

void LibMpfr_SphBesselPrime(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps);

void LibMpfr_SphNeumannPrime(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps);


void LibMpfr_BesselJZero(MpfrPtr res, const MpfrPtr v, const int m, int const dps);

void LibMpfr_BesselYZero(MpfrPtr res, const MpfrPtr v, const int m, int const dps);


void LibMpfr_GammaP(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);

void LibMpfr_GammaQ(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);

void LibMpfr_TgammaLower(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);

void LibMpfr_TgammaUpper(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);


void LibMpfr_GammaPInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr p, int const dps);

void LibMpfr_GammaQInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr q, int const dps);

void LibMpfr_GammaPInva(MpfrPtr res, const MpfrPtr p, const MpfrPtr x, int const dps);

void LibMpfr_GammaQInva(MpfrPtr res, const MpfrPtr q, const MpfrPtr x, int const dps);


void LibMpfr_GammaPDerivative(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps);

void LibMpfr_Beta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps);


void LibMpfr_LegendreP(MpfrPtr res, int n, const MpfrPtr x, int const dps);

void LibMpfr_LegendreQ(MpfrPtr res, int n, const MpfrPtr x, int const dps);

void LibMpfr_Laguerre(MpfrPtr res, int n, const MpfrPtr x, int const dps);

void LibMpfr_Hermite(MpfrPtr res, int n, const MpfrPtr x, int const dps);

void LibMpfr_ChebyshevT(MpfrPtr res, int n, const MpfrPtr x, int const dps);

void LibMpfr_ChebyshevU(MpfrPtr res, int n, const MpfrPtr x, int const dps);

void LibMpfr_Polygamma(MpfrPtr res, int n, const MpfrPtr x, int const dps);


void LibMpfr_EllintRC(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, int const dps);

void LibMpfr_Ellint1F(MpfrPtr res, const MpfrPtr k, const MpfrPtr phi, int const dps);

void LibMpfr_Ellint2F(MpfrPtr res, const MpfrPtr k, const MpfrPtr phi, int const dps);

void LibMpfr_Ellint3K(MpfrPtr res, const MpfrPtr k, const MpfrPtr n, int const dps);


void LibMpfr_JacobiCD(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiCN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiCS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiDC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiDN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiDS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiNC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiND(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiNS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiSC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiSD(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);

void LibMpfr_JacobiSN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps);


void LibMpfr_expint(MpfrPtr res, const unsigned n, const MpfrPtr x, int const dps);

void LibMpfr_OwenT(MpfrPtr res, const MpfrPtr h, const MpfrPtr a, int const dps);


void LibMpfr_IBeta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

void LibMpfr_IBetac(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

void LibMpfr_IBetaNonNormalized(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

void LibMpfr_IBetacNonNormalized(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

void LibMpfr_IBetaInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr p, int const dps);

void LibMpfr_IBetacInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr q, int const dps);

void LibMpfr_IBetaInva(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, const MpfrPtr p, int const dps);

void LibMpfr_IBetacInva(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, const MpfrPtr q, int const dps);

void LibMpfr_IBetaInvb(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, const MpfrPtr p, int const dps);

void LibMpfr_IBetacInvb(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, const MpfrPtr q, int const dps);

void LibMpfr_IBetaDerivative(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);


void LibMpfr_LegendrePM(MpfrPtr res, const int n, const int m, const MpfrPtr x, int const dps);

void LibMpfr_LaguerreM(MpfrPtr res, const int n, const int m, const MpfrPtr x, int const dps);


void LibMpfr_EllipticRF(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps);

void LibMpfr_EllipticRD(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps);

void LibMpfr_EllipticRG(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps);

void LibMpfr_Ellint3F(MpfrPtr res, const MpfrPtr k, const MpfrPtr n, const MpfrPtr phi, int const dps);


void LibMpfr_Gegenbauer(MpfrPtr res, const int n, const MpfrPtr lambda1, const MpfrPtr x, int const dps);

void LibMpfr_Jacobi(MpfrPtr res, const int n, const MpfrPtr alpha, const MpfrPtr beta, const MpfrPtr x, int const dps);




void LibMpfr_SphericalHarmonicR(MpfrPtr res, const int n, const int m, const MpfrPtr theta, const MpfrPtr phi, int const dps);

void LibMpfr_SphericalHarmonicI(MpfrPtr res, const int n, const int m, const MpfrPtr theta, const MpfrPtr phi, int const dps);

void LibMpfr_EllipticRJ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, const MpfrPtr p, int const dps);


void LibMpfr_Hypergeo0F1(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, int const dps);

void LibMpfr_Hypergeo1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

void LibMpfr_Hypergeo1F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);

void LibMpfr_LogHypergeo1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps);


void LibMpfr_JacobiTheta1(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps);

void LibMpfr_JacobiTheta2(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps);

void LibMpfr_JacobiTheta3(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps);

void LibMpfr_JacobiTheta4(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps);
































