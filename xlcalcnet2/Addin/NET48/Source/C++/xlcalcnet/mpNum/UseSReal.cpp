
#define MPFR_WANT_FLOAT128
#include "Helperfunctions.h"

#include "mpNumC_Main.h"
//#include "BoostSReal.h"

#include "stdint.h"
#include <complex>
#include <limits>
#include <mp_BoostEigenConstants.h>

using namespace std;
using namespace std::numbers;




/** ********************** Real Basic Functions, single precision ******************************** **/


float* Lib_SReal_Init_Func()
{
	float* x = NULL;
	x = (float*)malloc(sizeof(float));
	*x = 0.0f;
	return x;
}


void Lib_SReal_Clear(float* x)
{
	free(x);
}


/* Input and output  */


void Lib_SReal_Set(float* res, const float* x)
{
	*res = (*x);
}

void Lib_SReal_Set_Fmpq(float* res, const FmpqPtr x)
{
    mpfr_t temp; mpfr_init(temp);
	fmpq_get_mpfr (temp, (fmpq*)x, MPFR_RNDN);
	*res = mpfr_get_d(temp, MPFR_RNDN);
    mpfr_clear(temp);
}

void Lib_SReal_Set_Arb(float* res, const ArbPtr x)
{
	*res = arf_get_d(arb_midref((arb_ptr)x), ARF_RND_NEAR);
}

void Lib_SReal_Set_Arf(float* res, const ArfPtr x)
{
	*res = arf_get_d((arf_ptr)x, ARF_RND_NEAR);
}


void Lib_SReal_Set_Mpfr(float* res, const MpfrPtr x)
{
	*res = mpfr_get_d((mpfr_ptr)x, MPFR_RNDN);
}




void Lib_SCplx_Set_Acb(SCplxPtr res, const AcbPtr x)
{
    (*(std::complex<float>*) res) = std::complex<float>(
          arf_get_d(arb_midref(acb_realref((acb_ptr)x)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref((acb_ptr)x)), ARF_RND_NEAR));
}


//void SCplx_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, SCplxPtr res, const SCplxPtr x1)
//{
//	//printf("using SCplx_Acb_Cplxfunc1_Prec:  ");
//	slong wp = 36;  // 24 * 1.5
//
//    acb_t out1_acb, in1_acb;
//    acb_init(out1_acb); acb_init(in1_acb);
//
//    acb_set_d_d(in1_acb, (*(std::complex<float>*) x1).real(), (*(std::complex<float>*) x1).imag());
//
//	f1(out1_acb, in1_acb, wp);
//
//    (*(std::complex<float>*) res) = std::complex<float>(
//          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
//          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));
//
//    acb_clear(out1_acb); acb_clear(in1_acb);
//}





//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////



void SReal_Arb_Realfunc0Int32_Prec(ArbFuncPtr0Int32 f0Int32, float* res, int32_t in1)
{
	//printf("using SReal_Arb_Realfunc1_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    arb_t out1_arb;
    arb_init(out1_arb);

	f0Int32((arb_ptr)out1_arb, in1, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb);
}





void SReal_Arb_Realfunc1_Prec(ArbFuncPtr1 f1, float* res, const float* x1)
{
	//printf("using SReal_Arb_Realfunc1_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);
    arb_set_d(in1_arb, (double)*x1);

	f1(out1_arb, in1_arb, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb);
}




void SReal_Arb_Realfunc1Int32_Prec(ArbFuncPtr1Int32 f1Int32, float* res, const float* x1, int32_t in2)
{
	//printf("using SReal_Arb_Realfunc1Int32_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);
    arb_set_d(in1_arb, (double)*x1);

	//f1(out1_arb, in1_arb, wp);
	f1Int32(out1_arb, in1_arb, in2, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb);
}





void SReal_Arb_Realfunc2_Prec(ArbFuncPtr2 f2, float* res, const float* x1, const float* x2)
{
	//printf("using SReal_Arb_Realfunc2_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    arb_t out1_arb, in1_arb, in2_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb);
    arb_set_d(in1_arb, (double)*x1); arb_set_d(in2_arb, (double)*x2);

	f2(out1_arb, in1_arb, in2_arb, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb);
}





void SReal_Arb_Realfunc3_Prec(ArbFuncPtr3 f3, float* res, const float* x1, const float* x2, const float* x3)
{
	//printf("using SReal_Arb_Realfunc3_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    arb_t out1_arb, in1_arb, in2_arb, in3_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb);
    arb_set_d(in1_arb, (double)*x1); arb_set_d(in2_arb, (double)*x2); arb_set_d(in3_arb, (double)*x3);

	f3(out1_arb, in1_arb, in2_arb, in3_arb, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb);
}





void SReal_Arb_Realfunc4_Prec(ArbFuncPtr4 f4, float* res, const float* x1, const float* x2, const float* x3, const float* x4)
{
	//printf("using SReal_Arb_Realfunc4_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    arb_t out1_arb, in1_arb, in2_arb, in3_arb, in4_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb); arb_init(in4_arb);
    arb_set_d(in1_arb, (double)*x1); arb_set_d(in2_arb, (double)*x2);
    arb_set_d(in3_arb, (double)*x3); arb_set_d(in4_arb, (double)*x4);

	f4(out1_arb, in1_arb, in2_arb, in3_arb, in4_arb, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb); arb_clear(in4_arb);
}





void SCplx_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, SCplxPtr res, const int32_t in1)
{
	//printf("using SCplx_Acb_Cplxfunc0Int32_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    acb_t out1_acb;
    acb_init(out1_acb);

	f0Int32((acb_ptr)out1_acb, in1, wp);

    (*(std::complex<float>*) res) = std::complex<float>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb);
}




void SCplx_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, SCplxPtr res, const SCplxPtr x1)
{
	//printf("using SCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);

    acb_set_d_d(in1_acb, (*(std::complex<float>*) x1).real(), (*(std::complex<float>*) x1).imag());

	f1(out1_acb, in1_acb, wp);

    (*(std::complex<float>*) res) = std::complex<float>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb);
}




void SCplx_Acb_Cplxfunc1Int32_Prec(AcbFuncPtr1Int32 f1Int32, SCplxPtr res, const SCplxPtr x1, int32_t in2)
{
	//printf("using SCplx_Acb_Cplxfunc1Int32_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);

    acb_set_d_d(in1_acb, (*(std::complex<float>*) x1).real(), (*(std::complex<float>*) x1).imag());

	f1Int32((acb_ptr)out1_acb, (acb_ptr)in1_acb, in2, wp);

    (*(std::complex<float>*) res) = std::complex<float>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb);
}




void SCplx_Acb_Cplxfunc2_Prec(AcbFuncPtr2 f2, SCplxPtr res, const SCplxPtr x1, const SCplxPtr x2)
{
	//printf("using SCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    acb_t out1_acb, in1_acb, in2_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb);

    acb_set_d_d(in1_acb, (*(std::complex<float>*) x1).real(), (*(std::complex<float>*) x1).imag());
    acb_set_d_d(in2_acb, (*(std::complex<float>*) x2).real(), (*(std::complex<float>*) x2).imag());

	f2(out1_acb, in1_acb, in2_acb, wp);

    (*(std::complex<float>*) res) = std::complex<float>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb);
}




void SCplx_Acb_Cplxfunc3_Prec(AcbFuncPtr3 f3, SCplxPtr res, const SCplxPtr x1, const SCplxPtr x2, const SCplxPtr x3)
{
	//printf("using SCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    acb_t out1_acb, in1_acb, in2_acb, in3_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb);

    acb_set_d_d(in1_acb, (*(std::complex<float>*) x1).real(), (*(std::complex<float>*) x1).imag());
    acb_set_d_d(in2_acb, (*(std::complex<float>*) x2).real(), (*(std::complex<float>*) x2).imag());
    acb_set_d_d(in3_acb, (*(std::complex<float>*) x3).real(), (*(std::complex<float>*) x3).imag());

	f3(out1_acb, in1_acb, in2_acb, in3_acb, wp);

    (*(std::complex<float>*) res) = std::complex<float>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb);
}




void SCplx_Acb_Cplxfunc4_Prec(AcbFuncPtr4 f4, SCplxPtr res, const SCplxPtr x1, const SCplxPtr x2, const SCplxPtr x3, const SCplxPtr x4)
{
	//printf("using SCplx_Acb_Cplxfunc4_Prec:  ");
	slong wp = 36;  // 24 * 1.5

    acb_t out1_acb, in1_acb, in2_acb, in3_acb, in4_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb); acb_init(in4_acb);

    acb_set_d_d(in1_acb, (*(std::complex<float>*) x1).real(), (*(std::complex<float>*) x1).imag());
    acb_set_d_d(in2_acb, (*(std::complex<float>*) x2).real(), (*(std::complex<float>*) x2).imag());
    acb_set_d_d(in3_acb, (*(std::complex<float>*) x3).real(), (*(std::complex<float>*) x3).imag());
    acb_set_d_d(in4_acb, (*(std::complex<float>*) x4).real(), (*(std::complex<float>*) x4).imag());

	f4(out1_acb, in1_acb, in2_acb, in3_acb, in4_acb, wp);

    (*(std::complex<float>*) res) = std::complex<float>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb); acb_clear(in4_acb);
}









//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////




/* Roots and quadratic, cubic, and quartic equations */



void Lib_SReal_Arb_Sqrt(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sqrt, res, x);
}


void Lib_SReal_Arb_Rsqrt(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_rsqrt, res, x);
}


void Lib_SReal_Arb_Cbrt(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_cbrt, res, x);
}


void Lib_SReal_Arb_Sqrt1pm1(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sqrt1pm1, res, x);
}


void Lib_SReal_Arb_Root_ui(float* res, const float* x, const int32_t n)
{
    SReal_Arb_Realfunc1Int32_Prec(arb_root_ui_, res, x, n);
}


void Lib_SReal_Arb_Root_si(float* res, const float* x, const int32_t n)
{
    SReal_Arb_Realfunc1Int32_Prec(arb_root_si_, res, x, n);
}




/* Exponential and related functions */



void Lib_SReal_Arb_Exp(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_exp, res, x);
}


void Lib_SReal_Arb_Expm1(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_expm1, res, x);
}


void Lib_SReal_Arb_Exp10(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_exp10_, res, x);
}


void Lib_SReal_Arb_Exp2(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_exp2_, res, x);
}


void Lib_SReal_Arb_Exp10m1(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_exp10m1_, res, x);
}


void Lib_SReal_Arb_Exp2m1(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_exp2m1_, res, x);
}


void Lib_SReal_Arb_ExpRel(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_exprel_, res, x);
}



/* Logarithms and related functions */



void Lib_SReal_Arb_Log(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_log, res, x);
}


void Lib_SReal_Arb_Logbase(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_logbase_, res, x, y);
}


void Lib_SReal_Arb_Log10(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_log10, res, x);
}


void Lib_SReal_Arb_Log2(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_log2, res, x);
}


void Lib_SReal_Arb_Log1p(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_log1p, res, x);
}


void Lib_SReal_Arb_Log10p1(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_log10p1_, res, x);
}


void Lib_SReal_Arb_Log2p1(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_log2p1_, res, x);
}


void Lib_SReal_Arb_Log1mexp(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_log1mexp_, res, x);
}


void Lib_SReal_Arb_LambertW0(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_lambertw0, res, x);
}


void Lib_SReal_Arb_LambertWm1(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_lambertwm1, res, x);
}





/* Power functions */


void Lib_SReal_Arb_Square(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sqr, res, x);
}


void Lib_SReal_Arb_Cube(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_cube_, res, x);
}


void Lib_SReal_Arb_Pow_ui(float* res, const float* x, const int32_t n)
{
    SReal_Arb_Realfunc1Int32_Prec(arb_pow_ui_, res, x, n);
}


void Lib_SReal_Arb_Pow_si(float* res, const float* x, const int32_t n)
{
    SReal_Arb_Realfunc1Int32_Prec(arb_pow_si_, res, x, n);
}


void Lib_SReal_Arb_Compound_si(float* res, const float* x, const int32_t n)
{
    SReal_Arb_Realfunc1Int32_Prec(arb_compound_si_, res, x, n);
}


void Lib_SReal_Arb_Hypot(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypot, res, x, y);
}


void Lib_SReal_Arb_Pow(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_pow, res, x, y);
}


void Lib_SReal_Arb_Powm1(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_powm1_, res, x, y);
}


void Lib_SReal_Arb_Pow1p(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_pow1p_, res, x, y);
}


void Lib_SReal_Arb_Pow1pm1(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_pow1pm1_, res, x, y);
}





/* Trigonometric and related functions */



void Lib_SReal_Arb_Sin(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sin, res, x);
}


void Lib_SReal_Arb_Cos(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_cos, res, x);
}


void Lib_SReal_Arb_Tan(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_tan, res, x);
}


void Lib_SReal_Arb_Csc(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_csc, res, x);
}


void Lib_SReal_Arb_Sec(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sec, res, x);
}


void Lib_SReal_Arb_Cot(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_cot, res, x);
}


void Lib_SReal_Arb_Sinc(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sinc, res, x);
}


void Lib_SReal_Arb_SincPi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sinc_pi, res, x);
}


void Lib_SReal_Arb_SinPi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sin_pi, res, x);
}


void Lib_SReal_Arb_CosPi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_cos_pi, res, x);
}


void Lib_SReal_Arb_TanPi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_tan_pi, res, x);
}


void Lib_SReal_Arb_CotPi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_cot_pi, res, x);
}






/* Hyperbolic functions */


void Lib_SReal_Arb_Sinh(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sinh, res, x);
}


void Lib_SReal_Arb_Cosh(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_cosh, res, x);
}


void Lib_SReal_Arb_Tanh(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_tanh, res, x);
}


void Lib_SReal_Arb_Csch(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_csch, res, x);
}


void Lib_SReal_Arb_Sech(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_sech, res, x);
}


void Lib_SReal_Arb_Coth(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_coth, res, x);
}







/* Inverse trigonometric functions */



void Lib_SReal_Arb_Asin(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_asin, res, x);
}


void Lib_SReal_Arb_Acos(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_acos, res, x);
}


void Lib_SReal_Arb_Atan2(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_atan2, res, x, y);
}


void Lib_SReal_Arb_Atan(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_atan, res, x);
}


void Lib_SReal_Arb_Acsc(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_acsc, res, x);
}


void Lib_SReal_Arb_Asec(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_asec, res, x);
}


void Lib_SReal_Arb_Acot(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_acot, res, x);
}









/* Inverse hyperbolic functions */



void Lib_SReal_Arb_Asinh(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_asinh, res, x);
}


void Lib_SReal_Arb_Acosh(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_acosh, res, x);
}


void Lib_SReal_Arb_Atanh(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_atanh, res, x);
}


void Lib_SReal_Arb_Acsch(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_acsch, res, x);
}


void Lib_SReal_Arb_Asech(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_asech, res, x);
}


void Lib_SReal_Arb_Acoth(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_acoth, res, x);
}








/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_SReal_Arb_MEllipticK(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_elliptic_k, res, x);
}


void Lib_SReal_Arb_MEllipticE(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_elliptic_e, res, x);
}


void Lib_SReal_Arb_MEllipticPi(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_elliptic_pi, res, x, y);
}


void Lib_SReal_Arb_MEllipticF(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_elliptic_f_, res, x, y);
}


void Lib_SReal_Arb_MEllipticEInc(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_, res, x, y);
}


void Lib_SReal_Arb_MEllipticPiInc(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_, res, a, b, z);
}




/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_SReal_Arb_EllipticK(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_elliptic_k_k_, res, x);
}


void Lib_SReal_Arb_EllipticE(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_elliptic_e_k_, res, x);
}


void Lib_SReal_Arb_EllipticPi(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_elliptic_pi_k_, res, x, y);
}


void Lib_SReal_Arb_EllipticF(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_elliptic_f_k_, res, x, y);
}


void Lib_SReal_Arb_EllipticEInc(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_k_, res, x, y);
}


void Lib_SReal_Arb_EllipticPiInc(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_k_, res, a, b, z);
}


void Lib_SReal_Arb_Agm(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */


void Lib_SReal_Arb_Elliptic_RC(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_elliptic_rc_, res, x, y);
}


void Lib_SReal_Arb_Elliptic_RF(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_elliptic_rf_, res, a, b, z);
}


void Lib_SReal_Arb_Elliptic_RG(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_elliptic_rg_, res, a, b, z);
}


void Lib_SReal_Arb_Elliptic_RD(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_elliptic_rd_, res, a, b, z);
}


void Lib_SReal_Arb_Elliptic_RJ(float* res, const float* a, const float* b, const float* c, const float* z)
{
    SReal_Arb_Realfunc4_Prec(arb_elliptic_rj_, res, a, b, c, z);
}





/* Jacobi theta functions */


void Lib_SReal_Arb_Theta1Q(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_theta1q, res, x, y);
}


void Lib_SReal_Arb_Theta2Q(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_theta2q, res, x, y);
}


void Lib_SReal_Arb_Theta3Q(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_theta3q, res, x, y);
}


void Lib_SReal_Arb_Theta4Q(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_theta4q, res, x, y);
}




/* Jacobi elliptic functions */


void Lib_SReal_Arb_JacobiSN(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_sn, res, x, y);
}


void Lib_SReal_Arb_JacobiCN(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_cn, res, x, y);
}


void Lib_SReal_Arb_JacobiDN(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_dn, res, x, y);
}


void Lib_SReal_Arb_JacobiNS(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_ns, res, x, y);
}


void Lib_SReal_Arb_JacobiNC(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_nc, res, x, y);
}


void Lib_SReal_Arb_JacobiND(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_nd, res, x, y);
}


void Lib_SReal_Arb_JacobiSC(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_sc, res, x, y);
}


void Lib_SReal_Arb_JacobiSD(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_sd, res, x, y);
}


void Lib_SReal_Arb_JacobiDC(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_dc, res, x, y);
}


void Lib_SReal_Arb_JacobiDS(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_ds, res, x, y);
}


void Lib_SReal_Arb_JacobiCS(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_cs, res, x, y);
}


void Lib_SReal_Arb_JacobiCD(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(_arb_jacobi_cd, res, x, y);
}





/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */



void Lib_SReal_Arb_LerchPhi(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_dirichlet_lerch_phi, res, a, b, z);
}




/* Polygamma functions */


void Lib_SReal_Arb_Polygamma(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_polygamma, res, x, y);
}


void Lib_SReal_Arb_Digamma(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_SReal_Arb_Polylog(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_polylog, res, x, y);
}


void Lib_SReal_Arb_Dilog(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_dilog, res, x);
}




/* Hurwitz zeta function and related functions */


void Lib_SReal_Arb_HurwitzZeta(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hurwitz_zeta, res, x, y);
}



void Lib_SReal_Arb_Bernoulli_ui(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_bernoulli_ui_, res, n);
}


void Lib_SReal_Arb_Euler_ui(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_euler_number_ui_, res, n);
}


void Lib_SReal_Arb_BernoulliPoly_ui(float* res, const float* x, const int32_t n)
{
    SReal_Arb_Realfunc1Int32_Prec(arb_bernoulli_poly_ui_, res, x, n);
}



void Lib_SReal_Arb_BarnesG(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_barnes_g, res, x);
}


void Lib_SReal_Arb_LogBarnesG(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_log_barnes_g, res, x);
}






/* Riemann zeta function, and related functions */



void Lib_SReal_Arb_Zeta(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_zeta, res, x);
}


void Lib_SReal_Arb_BacklundS(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(acb_dirichlet_backlund_s, res, x);
}


void Lib_SReal_Arb_GramPoint_ui(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_gram_point_ui_, res, n);
}





/* Additional numbertheoretic functions */


void Lib_SReal_Arb_Bell_ui(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_bell_ui_, res, n);
}


void Lib_SReal_Arb_Partitions_ui(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_partitions_ui_, res, n);
}


void Lib_SReal_Arb_Primorial_ui(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_primorial_nth_ui_, res, n);
}





/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_SReal_Arb_Hypgeom0F1(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_, res, x, y);
}


void Lib_SReal_Arb_Hypgeom0F1r(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_r, res, x, y);
}




/* Bessel functions and modified Bessel functions  */


void Lib_SReal_Arb_BesselJ(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_j, res, x, y);
}


void Lib_SReal_Arb_BesselY(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_y, res, x, y);
}


void Lib_SReal_Arb_BesselI(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i, res, x, y);
}


void Lib_SReal_Arb_BesselK(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k, res, x, y);
}


void Lib_SReal_Arb_BesselIScaled(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_SReal_Arb_BesselKScaled(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */





/* Airy functions  */



void Lib_SReal_Arb_AiryAi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_airy_ai, res, x);
}


void Lib_SReal_Arb_AiryAiPrime(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_airy_ai_prime, res, x);
}


void Lib_SReal_Arb_AiryBi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_airy_bi, res, x);
}


void Lib_SReal_Arb_AiryBiPrime(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_airy_bi_prime, res, x);
}



void Lib_SReal_Arb_AiryAiZero(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_zero, res, n);
}


void Lib_SReal_Arb_AiryAiPrimeZero(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_prime_zero, res, n);
}


void Lib_SReal_Arb_AiryBiZero(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_zero, res, n);
}


void Lib_SReal_Arb_AiryBiPrimeZero(float* res, const int32_t n)
{
    SReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_prime_zero, res, n);
}






/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


void Lib_SReal_Arb_Hypgeom1F1(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1_, res, a, b, z);
}


void Lib_SReal_Arb_Hypgeom1F1r(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_SReal_Arb_HypgeomU(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_u, res, a, b, z);
}






/* Gamma function and related functions */


void Lib_SReal_Arb_Gamma(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_gamma, res, x);
}


void Lib_SReal_Arb_Rgamma(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_rgamma, res, x);
}


void Lib_SReal_Arb_Lgamma(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_lgamma, res, x);
}


void Lib_SReal_Arb_RisingFactorial(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_rising, res, x, y);
}


void Lib_SReal_Arb_Beta(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_beta_, res, x, y);
}





/* Incomplete gamma functions */



void Lib_SReal_Arb_GammaUpper(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_gamma_upper_, res, x, y);
}


void Lib_SReal_Arb_GammaUpperR(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_gamma_upper_r, res, x, y);
}


void Lib_SReal_Arb_GammaLower(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_gamma_lower_, res, x, y);
}


void Lib_SReal_Arb_GammaPPrime(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_gamma_p_derivative, res, x, y);
}


void Lib_SReal_Arb_GammaP(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_gamma_p, res, x, y);
}


void Lib_SReal_Arb_GammaQ(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_gamma_q, res, x, y);
}





/* Error function and related functions */


void Lib_SReal_Arb_Erf(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_erf, res, x);
}


void Lib_SReal_Arb_Erfc(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_erfc, res, x);
}


void Lib_SReal_Arb_Erfinv(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_erfinv, res, x);
}


void Lib_SReal_Arb_Erfcinv(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_erfcinv, res, x);
}


void Lib_SReal_Arb_Erfi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_erfi, res, x);
}


void Lib_SReal_Arb_FresnelC(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_fresnelc, res, x);
}


void Lib_SReal_Arb_FresnelS(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_fresnels, res, x);
}


void Lib_SReal_Arb_Ndens(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_ndens, res, x);
}


void Lib_SReal_Arb_Ndis(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_ndis, res, x);
}







/* Exponential integrals and related functions */


void Lib_SReal_Arb_ExpIntegralE(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_expint, res, x, y);
}


void Lib_SReal_Arb_ExpIntegralEi(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_ei, res, x);
}


void Lib_SReal_Arb_SinIntegral(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_si, res, x);
}


void Lib_SReal_Arb_CosIntegral(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_ci, res, x);
}


void Lib_SReal_Arb_SinhIntegral(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_shi, res, x);
}


void Lib_SReal_Arb_CoshIntegral(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_chi, res, x);
}


void Lib_SReal_Arb_LogIntegral(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_li_, res, x);
}


void Lib_SReal_Arb_LogIntegralOffset(float* res, const float* x)
{
    SReal_Arb_Realfunc1_Prec(arb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_SReal_Arb_HermiteH(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_hermite_h, res, x, y);
}


void Lib_SReal_Arb_LaguerreL(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */


void Lib_SReal_Arb_CoulombF(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_f, res, a, b, z);
}


void Lib_SReal_Arb_CoulombG(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_g, res, a, b, z);
}





/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_SReal_Arb_Hyp2f1(float* res, const float* a, const float* b, const float* c, const float* z)
{
    SReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_SReal_Arb_Hyp2f1r(float* res, const float* a, const float* b, const float* c, const float* z)
{
    SReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1r_, res, a, b, c, z);
}





/* 2F1: Orthogonal polynomials */


void Lib_SReal_Arb_ChebyshevT(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_SReal_Arb_ChebyshevU(float* res, const float* x, const float* y)
{
    SReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_SReal_Arb_GegenbauerC(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_SReal_Arb_LegendreP(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_SReal_Arb_LegendrePv(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_SReal_Arb_LegendreQ(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_SReal_Arb_LegendreQv(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_qv_, res, a, b, z);
}


void Lib_SReal_Arb_JacobiP(float* res, const float* a, const float* b, const float* c, const float* z)
{
    SReal_Arb_Realfunc4_Prec(arb_hypgeom_jacobi_p, res, a, b, c, z);
}





/* 2F1: Incomplete Beta Function */


void Lib_SReal_Arb_BetaLower(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_, res, a, b, z);
}


void Lib_SReal_Arb_Ibeta(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_ibeta, res, a, b, z);
}


void Lib_SReal_Arb_Ibetac(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_ibetac, res, a, b, z);
}


void Lib_SReal_Arb_IbetaPrime(float* res, const float* a, const float* b, const float* z)
{
    SReal_Arb_Realfunc3_Prec(arb_ibeta_derivative, res, a, b, z);
}





/* Hypergeometric Function 1F2, overview */


void Lib_SReal_Arb_Hypgeom1F2(float* res, const float* a, const float* b, const float* c, const float* z)
{
    SReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2_, res, a, b, c, z);
}


void Lib_SReal_Arb_Hypgeom1F2r(float* res, const float* a, const float* b, const float* c, const float* z)
{
    SReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2r_, res, a, b, c, z);
}









////////////////////////////////////////////////////////
////// Acb functions
////////////////////////////////////////////////////////






/* Roots and quadratic, cubic, and quartic equations */


void Lib_SCplx_Acb_UnitRoot_ui(SCplxPtr res, const int32_t n)
{
    SCplx_Acb_Cplxfunc0Int32_Prec(acb_unit_root_, res, n);
}


void Lib_SCplx_Acb_Sqrt(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sqrt, res, x);
}


void Lib_SCplx_Acb_Rsqrt(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_rsqrt, res, x);
}


void Lib_SCplx_Acb_Cbrt(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_cbrt, res, x);
}


void Lib_SCplx_Acb_Sqrt1pm1(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sqrt1pm1, res, x);
}


void Lib_SCplx_Acb_Root_ui(SCplxPtr res, const SCplxPtr x, const int32_t n)
{
    SCplx_Acb_Cplxfunc1Int32_Prec(acb_root_ui_, res, x, n);
}






/* Exponential and related functions */


void Lib_SCplx_Acb_Exp(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_exp, res, x);
}


void Lib_SCplx_Acb_Expj(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_expj_, res, x);
}


void Lib_SCplx_Acb_Expjpi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_exp_pi_i, res, x);
}


void Lib_SCplx_Acb_Expm1(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_expm1, res, x);
}


void Lib_SCplx_Acb_Exp10(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_exp10_, res, x);
}


void Lib_SCplx_Acb_Exp2(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_exp2_, res, x);
}


void Lib_SCplx_Acb_Exp10m1(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_exp10m1_, res, x);
}


void Lib_SCplx_Acb_Exp2m1(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_exp2m1_, res, x);
}


void Lib_SCplx_Acb_ExpRel(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_exprel_, res, x);
}






/* Logarithms and related functions */



void Lib_SCplx_Acb_Log(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_log, res, x);
}


void Lib_SCplx_Acb_Logbase(SCplxPtr res, const SCplxPtr x, const SCplxPtr b)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_logbase_, res, x, b);
}


void Lib_SCplx_Acb_Log1p(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_log1p, res, x);
}


void Lib_SCplx_Acb_Log10(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_log10_, res, x);
}


void Lib_SCplx_Acb_Log2(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_log2_, res, x);
}


void Lib_SCplx_Acb_Log10p1(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_log10p1_, res, x);
}



void Lib_SCplx_Acb_Log2p1(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_log2p1_, res, x);
}




void Lib_SCplx_Acb_LambertW_ui(SCplxPtr res, const SCplxPtr x, const int32_t n)
{
    SCplx_Acb_Cplxfunc1Int32_Prec(acb_lambertw_ui_, res, x, n);
}







/* Power functions */


void Lib_SCplx_Acb_Square(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sqr, res, x);
}


void Lib_SCplx_Acb_Cube(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_cube, res, x);
}


void Lib_SCplx_Acb_Pow_si(SCplxPtr res, const SCplxPtr x, const int32_t n)
{
    SCplx_Acb_Cplxfunc1Int32_Prec(acb_pow_si_, res, x, n);
}



void Lib_SCplx_Acb_Hypot(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypot_, res, x, y);
}


void Lib_SCplx_Acb_Pow(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
}


void Lib_SCplx_Acb_Powm1(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_powm1_, res, x, y);
}


void Lib_SCplx_Acb_Pow1p(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_pow1p_, res, x, y);
}


void Lib_SCplx_Acb_Pow1pm1(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_pow1pm1_, res, x, y);
}







/* Trigonometric and related functions */



void Lib_SCplx_Acb_Sin(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sin, res, x);
}


void Lib_SCplx_Acb_Cos(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_cos, res, x);
}


void Lib_SCplx_Acb_Tan(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_tan, res, x);
}



void Lib_SCplx_Acb_Csc(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_csc, res, x);
}


void Lib_SCplx_Acb_Sec(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sec, res, x);
}


void Lib_SCplx_Acb_Cot(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_cot, res, x);
}





/* Hyperbolic functions */


void Lib_SCplx_Acb_Sinh(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sinh, res, x);
}


void Lib_SCplx_Acb_Cosh(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_cosh, res, x);
}


void Lib_SCplx_Acb_Tanh(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_tanh, res, x);
}



void Lib_SCplx_Acb_Csch(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_csch, res, x);
}


void Lib_SCplx_Acb_Sech(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sech, res, x);
}


void Lib_SCplx_Acb_Coth(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_coth, res, x);
}



void Lib_SCplx_Acb_Sinc(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sinc, res, x);
}


void Lib_SCplx_Acb_SincPi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sinc_pi, res, x);
}



void Lib_SCplx_Acb_SinPi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sin_pi, res, x);
}


void Lib_SCplx_Acb_CosPi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_cos_pi, res, x);
}


void Lib_SCplx_Acb_TanPi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_tan_pi, res, x);
}


void Lib_SCplx_Acb_CotPi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_cot_pi, res, x);
}


void Lib_SCplx_Acb_CscPi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_csc_pi, res, x);
}



void Lib_SCplx_Acb_SecPi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_sec_pi_, res, x);
}






/* Inverse trigonometric functions */


void Lib_SCplx_Acb_Asin(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_asin, res, x);
}


void Lib_SCplx_Acb_Acos(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_acos, res, x);
}


void Lib_SCplx_Acb_Atan(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_atan, res, x);
}



void Lib_SCplx_Acb_Acsc(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_acsc, res, x);
}


void Lib_SCplx_Acb_Asec(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_asec, res, x);
}


void Lib_SCplx_Acb_Acot(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_SCplx_Acb_Asinh(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_asinh, res, x);
}


void Lib_SCplx_Acb_Acosh(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_acosh, res, x);
}


void Lib_SCplx_Acb_Atanh(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_atanh, res, x);
}



void Lib_SCplx_Acb_Acsch(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_acsch, res, x);
}


void Lib_SCplx_Acb_Asech(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_asech, res, x);
}


void Lib_SCplx_Acb_Acoth(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_acoth, res, x);
}









/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_SCplx_Acb_MEllipticK(SCplxPtr res, const SCplxPtr m)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k, res, m);
}


void Lib_SCplx_Acb_MEllipticE(SCplxPtr res, const SCplxPtr m)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e, res, m);
}


void Lib_SCplx_Acb_MEllipticPi(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi, res, phi, m);

}


void Lib_SCplx_Acb_MEllipticF(SCplxPtr res, const SCplxPtr phi, const SCplxPtr m)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_, res, phi, m);

}


void Lib_SCplx_Acb_MEllipticEInc(SCplxPtr res, const SCplxPtr n, const SCplxPtr m)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_, res, n, m);
}


void Lib_SCplx_Acb_MEllipticPiInc(SCplxPtr res, const SCplxPtr n, const SCplxPtr phi, const SCplxPtr m)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_, res, n, phi, m);
}







/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_SCplx_Acb_EllipticK(SCplxPtr res, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k_k_, res, k);
}


void Lib_SCplx_Acb_EllipticE(SCplxPtr res, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e_k_, res, k);
}


void Lib_SCplx_Acb_EllipticPi(SCplxPtr res, const SCplxPtr phi, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi_k_, res, phi, k);

}


void Lib_SCplx_Acb_EllipticF(SCplxPtr res, const SCplxPtr phi, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_k_, res, phi, k);

}


void Lib_SCplx_Acb_EllipticEInc(SCplxPtr res, const SCplxPtr n, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_k_, res, n, k);
}


void Lib_SCplx_Acb_EllipticPiInc(SCplxPtr res, const SCplxPtr n, const SCplxPtr phi, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_k_, res, n, phi, k);
}



void Lib_SCplx_Acb_Agm(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */

void Lib_SCplx_Acb_Elliptic_RC(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_rc_, res, x, y);
}



void Lib_SCplx_Acb_Elliptic_RF(SCplxPtr res, const SCplxPtr x, const SCplxPtr y, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rf_, res, x, y, z);
}


void Lib_SCplx_Acb_Elliptic_RG(SCplxPtr res, const SCplxPtr x, const SCplxPtr y, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rg_, res, x, y, z);
}


void Lib_SCplx_Acb_Elliptic_RD(SCplxPtr res, const SCplxPtr x, const SCplxPtr y, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rd_, res, x, y, z);
}


void Lib_SCplx_Acb_Elliptic_RJ(SCplxPtr res, const SCplxPtr x, const SCplxPtr y, const SCplxPtr z, const SCplxPtr w)
{
    SCplx_Acb_Cplxfunc4_Prec(acb_elliptic_rj_, res, x, y, z, w);
}






/* Jacobi theta functions */


void Lib_SCplx_Acb_Theta1Q(SCplxPtr res, const SCplxPtr z, const SCplxPtr q)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_theta1q, res, z, q);
}


void Lib_SCplx_Acb_Theta2Q(SCplxPtr res, const SCplxPtr z, const SCplxPtr q)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_theta2q, res, z, q);
}


void Lib_SCplx_Acb_Theta3Q(SCplxPtr res, const SCplxPtr z, const SCplxPtr q)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_theta3q, res, z, q);
}


void Lib_SCplx_Acb_Theta4Q(SCplxPtr res, const SCplxPtr z, const SCplxPtr q)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_theta4q, res, z, q);
}



void Lib_SCplx_Acb_Theta1Tau(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_theta1, res, z, tau);
}


void Lib_SCplx_Acb_Theta2Tau(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_theta2, res, z, tau);
}


void Lib_SCplx_Acb_Theta3Tau(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_theta3, res, z, tau);
}


void Lib_SCplx_Acb_Theta4Tau(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_theta4, res, z, tau);
}







/* Jacobi elliptic functions */


void Lib_SCplx_Acb_QfromK(SCplxPtr res, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_qfromk, res, k);
}


void Lib_SCplx_Acb_TfromUQ(SCplxPtr res, const SCplxPtr u, const SCplxPtr q)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_tfrom_u_q, res, u, q);
}


void Lib_SCplx_Acb_SnTQ(SCplxPtr res, const SCplxPtr t, const SCplxPtr q)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_sn_t_q, res, t, q);
}


void Lib_SCplx_Acb_CnTQ(SCplxPtr res, const SCplxPtr t, const SCplxPtr q)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_cn_t_q, res, t, q);
}


void Lib_SCplx_Acb_DnTQ(SCplxPtr res, const SCplxPtr t, const SCplxPtr q)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_dn_t_q, res, t, q);
}


void Lib_SCplx_Acb_JacobiSN(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sn, res, u, k);
}


void Lib_SCplx_Acb_JacobiCN(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cn, res, u, k);
}


void Lib_SCplx_Acb_JacobiDN(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dn, res, u, k);
}





void Lib_SCplx_Acb_JacobiNS(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ns, res, u, k);
}


void Lib_SCplx_Acb_JacobiNC(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nc, res, u, k);
}


void Lib_SCplx_Acb_JacobiND(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nd, res, u, k);
}




void Lib_SCplx_Acb_JacobiSC(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sc, res, u, k);
}


void Lib_SCplx_Acb_JacobiSD(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sd, res, u, k);
}




void Lib_SCplx_Acb_JacobiDC(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dc, res, u, k);
}


void Lib_SCplx_Acb_JacobiDS(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ds, res, u, k);
}




void Lib_SCplx_Acb_JacobiCS(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cs, res, u, k);
}


void Lib_SCplx_Acb_JacobiCD(SCplxPtr res, const SCplxPtr u, const SCplxPtr k)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cd, res, u, k);
}







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


void Lib_SCplx_Acb_WeierstrassP(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_p, res, z, tau);
}


void Lib_SCplx_Acb_WeierstrassPInv(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_inv_p, res, z, tau);
}


void Lib_SCplx_Acb_WeierstrassPZeta(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_zeta, res, z, tau);
}


void Lib_SCplx_Acb_WeierstrassPSigma(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_elliptic_sigma, res, z, tau);
}



void Lib_SCplx_Acb_WeierstrassPPrime(SCplxPtr res, const SCplxPtr z, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_wp_prime, res, z, tau);
}



void Lib_SCplx_Acb_EllipticInvariantG2(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g2, res, tau);
}


void Lib_SCplx_Acb_EllipticInvariantG3(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g3, res, tau);
}


void Lib_SCplx_Acb_EllipticRootE1(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e1, res, tau);
}


void Lib_SCplx_Acb_EllipticRootE2(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e2, res, tau);
}


void Lib_SCplx_Acb_EllipticRootE3(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e3, res, tau);
}



void Lib_SCplx_Acb_DedekindEta(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_modular_eta, res, tau);
}


void Lib_SCplx_Acb_KleinJ(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_modular_j, res, tau);
}


void Lib_SCplx_Acb_ModularLambda(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_modular_lambda, res, tau);
}


void Lib_SCplx_Acb_ModularDelta(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_modular_delta, res, tau);
}




/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */






/* Lerch’s transcendent: overview */


void Lib_SCplx_Acb_LerchPhi(SCplxPtr res, const SCplxPtr z, const SCplxPtr s, const SCplxPtr a)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_dirichlet_lerch_phi, res, z, s, a);
}


void Lib_SCplx_Acb_LerchZeta(SCplxPtr res, const SCplxPtr lambda1, const SCplxPtr alpha, const SCplxPtr s)
{
    SCplx_Acb_Cplxfunc3_Prec(_acb_lerch_zeta, res, lambda1, alpha, s);
}


/* Polygamma functions */


void Lib_SCplx_Acb_Polygamma(SCplxPtr res, const SCplxPtr s, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_polygamma, res, s, z);
}


void Lib_SCplx_Acb_Trigamma(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_trigamma, res, x);
}


void Lib_SCplx_Acb_Digamma(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_SCplx_Acb_Polylog(SCplxPtr res, const SCplxPtr s, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_polylog, res, s, z);
}


void Lib_SCplx_Acb_Trilog(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_trilog, res, x);
}


void Lib_SCplx_Acb_Dilog(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_dilog, res, x);
}



void Lib_SCplx_Acb_ClausenSin(SCplxPtr res, const SCplxPtr s, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_clausen_sin, res, s, z);
}


void Lib_SCplx_Acb_ClausenCos(SCplxPtr res, const SCplxPtr s, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_clausen_cos, res, s, z);
}


void Lib_SCplx_Acb_Clausen2(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_clausen2, res, x);
}


void Lib_SCplx_Acb_BoseEinstein(SCplxPtr res, const SCplxPtr s, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_bose_einstein, res, s, z);
}


void Lib_SCplx_Acb_FermiDirac(SCplxPtr res, const SCplxPtr s, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_fermi_dirac, res, s, z);
}


void Lib_SCplx_Acb_LegendreChi(SCplxPtr res, const SCplxPtr s, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_legendre_chi, res, s, z);
}


void Lib_SCplx_Acb_InverseTanIntegral(SCplxPtr res, const SCplxPtr s, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_ti, res, s, z);
}





/* Hurwitz zeta function and related functions */




void Lib_SCplx_Acb_HurwitzZeta(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hurwitz_zeta, res, x, y);
}


void Lib_SCplx_Acb_Stieltjes_ui(SCplxPtr res, const SCplxPtr x, const int32_t n)
{
    SCplx_Acb_Cplxfunc1Int32_Prec(acb_stieltjes_ui_, res, x, n);
}


void Lib_SCplx_Acb_BernoulliPoly_ui(SCplxPtr res, const SCplxPtr x, const int32_t n)
{
    SCplx_Acb_Cplxfunc1Int32_Prec(acb_bernoulli_poly_ui_, res, x, n);
}



void Lib_SCplx_Acb_Harmonic(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_harmonic, res, x);
}


void Lib_SCplx_Acb_Harmonic2(SCplxPtr res, const SCplxPtr z, const SCplxPtr r)
{
    SCplx_Acb_Cplxfunc2_Prec(_acb_harmonic2, res, z, r);
}


void Lib_SCplx_Acb_EulerPoly_ui(SCplxPtr res, const SCplxPtr x, const int32_t n)
{
    SCplx_Acb_Cplxfunc1Int32_Prec(acb_euler_poly_ui_, res, x, n);
}


void Lib_SCplx_Acb_Hyperfactorial(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_hyperfac, res, x);
}


void Lib_SCplx_Acb_Superfactorial(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_superfac, res, x);
}


void Lib_SCplx_Acb_BarnesG(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_barnes_g, res, x);
}


void Lib_SCplx_Acb_LogBarnesG(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */


void Lib_SCplx_Acb_Zeta(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_zeta, res, x);
}


void Lib_SCplx_Acb_Zetam1(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_zetam1, res, x);
}


void Lib_SCplx_Acb_ZetaZero_ui(SCplxPtr res, const int32_t n)
{
    SCplx_Acb_Cplxfunc0Int32_Prec(acb_dirichlet_zeta_zero_ui_, res, n);
}


void Lib_SCplx_Acb_DirichletXi(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_xi, res, tau);
}


void Lib_SCplx_Acb_DirichletEta(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_eta, res, tau);
}


void Lib_SCplx_Acb_DirichletEtam1(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_etam1, res, x);
}


void Lib_SCplx_Acb_DirichletBeta(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_beta, res, x);
}


void Lib_SCplx_Acb_DirichletLambda(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_lambda, res, x);
}



/* Riemann-Siegel Z-function */
void Lib_SCplx_Acb_HardyZ(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_z_, res, tau);
}

/* rstheta(z) in amath */
void Lib_SCplx_Acb_HardyTheta(SCplxPtr res, const SCplxPtr tau)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_theta_, res, tau);
}









/* Additional numbertheoretic functions */




/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_SCplx_Acb_Hypgeom0F1(SCplxPtr res, const SCplxPtr a, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_, res, a, x);
}


void Lib_SCplx_Acb_Hypgeom0F1r(SCplxPtr res, const SCplxPtr a, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */



void Lib_SCplx_Acb_BesselJ(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_j, res, x, y);
}


void Lib_SCplx_Acb_BesselY(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_y, res, x, y);
}


void Lib_SCplx_Acb_BesselI(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i, res, x, y);
}


void Lib_SCplx_Acb_BesselK(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k, res, x, y);
}


void Lib_SCplx_Acb_BesselIScaled(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_SCplx_Acb_BesselKScaled(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */




/* Airy functions  */


void Lib_SCplx_Acb_AiryAi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_airy_ai, res, x);
}


void Lib_SCplx_Acb_AiryAiPrime(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_airy_ai_prime, res, x);
}


void Lib_SCplx_Acb_AiryBi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_airy_bi, res, x);
}


void Lib_SCplx_Acb_AiryBiPrime(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_airy_bi_prime, res, x);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */



void Lib_SCplx_Acb_Hypgeom1F1(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
}


void Lib_SCplx_Acb_Hypgeom1F1r(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_SCplx_Acb_HypgeomU(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_u, res, a, b, z);
}





/* Gamma function and related functions */


void Lib_SCplx_Acb_Gamma(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_gamma, res, x);
}


void Lib_SCplx_Acb_Rgamma(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_rgamma, res, x);
}


void Lib_SCplx_Acb_Lgamma(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_lgamma, res, x);
}


void Lib_SCplx_Acb_RisingFactorial(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_rising, res, x, y);
}


void Lib_SCplx_Acb_Beta(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_beta_, res, x, y);
}






/* Incomplete gamma functions */


void Lib_SCplx_Acb_GammaUpper(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_gamma_upper_, res, x, y);
}



void Lib_SCplx_Acb_GammaLower(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_gamma_lower_, res, x, y);
}



void Lib_SCplx_Acb_GammaPPrime(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_gamma_p_derivative, res, x, y);
}


void Lib_SCplx_Acb_GammaP(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_gamma_p, res, x, y);
}


void Lib_SCplx_Acb_GammaQ(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_gamma_q, res, x, y);
}







/* Error function and related functions */


void Lib_SCplx_Acb_Erf(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erf, res, x);
}


void Lib_SCplx_Acb_Erfc(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfc, res, x);
}


void Lib_SCplx_Acb_Erfi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfi, res, x);
}



void Lib_SCplx_Acb_FresnelC(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_fresnelc, res, x);
}


void Lib_SCplx_Acb_FresnelS(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_fresnels, res, x);
}


void Lib_SCplx_Acb_Ndens(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_ndens, res, x);
}


void Lib_SCplx_Acb_Ndis(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_ndis, res, x);
}






/* Exponential integrals and related functions */


void Lib_SCplx_Acb_ExpIntegralE(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_expint, res, x, y);
}



void Lib_SCplx_Acb_ExpIntegralEi(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ei, res, x);
}


void Lib_SCplx_Acb_SinIntegral(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_si, res, x);
}


void Lib_SCplx_Acb_CosIntegral(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ci, res, x);
}


void Lib_SCplx_Acb_SinhIntegral(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_shi, res, x);
}


void Lib_SCplx_Acb_CoshIntegral(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_chi, res, x);
}


void Lib_SCplx_Acb_LogIntegral(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_, res, x);
}


void Lib_SCplx_Acb_LogIntegralOffset(SCplxPtr res, const SCplxPtr x)
{
    SCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_SCplx_Acb_HermiteH(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_hermite_h, res, x, y);
}


void Lib_SCplx_Acb_LaguerreL(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */



void Lib_SCplx_Acb_CoulombF(SCplxPtr res, const SCplxPtr l, const SCplxPtr eta, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_SCplx_Acb_CoulombG(SCplxPtr res, const SCplxPtr l, const SCplxPtr eta, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_g, res, l, eta, z);
}


void Lib_SCplx_Acb_CoulombHpos(SCplxPtr res, const SCplxPtr l, const SCplxPtr eta, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hpos, res, l, eta, z);
}


void Lib_SCplx_Acb_CoulombHneg(SCplxPtr res, const SCplxPtr l, const SCplxPtr eta, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hneg, res, l, eta, z);
}







/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_SCplx_Acb_Hypgeom2F1(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_SCplx_Acb_Hypgeom2F1r(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1r_, res, a, b, c, z);
}



/* 2F1: Orthogonal polynomials */


void Lib_SCplx_Acb_ChebyshevT(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_SCplx_Acb_ChebyshevU(SCplxPtr res, const SCplxPtr x, const SCplxPtr y)
{
    SCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_SCplx_Acb_GegenbauerC(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_SCplx_Acb_LegendreP(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_SCplx_Acb_LegendrePv(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_SCplx_Acb_LegendreQ(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_SCplx_Acb_LegendreQv(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_qv_, res, a, b, z);
}



void Lib_SCplx_Acb_JacobiP(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr c, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_jacobi_p, res, a, b, c, z);
}


void Lib_SCplx_Acb_SphericalY(SCplxPtr res, const SCplxPtr n, const SCplxPtr m, const SCplxPtr theta, const SCplxPtr phi)
{
    SCplx_Acb_Cplxfunc4_Prec(_acb_hypgeom_spherical_y, res, n, m, theta, phi);
}





/* 2F1: Incomplete Beta Function */


void Lib_SCplx_Acb_BetaLower(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_beta_lower_, res, a, b, z);
}




void Lib_SCplx_Acb_Ibeta(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_ibeta, res, a, b, z);
}


void Lib_SCplx_Acb_Ibetac(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_ibetac, res, a, b, z);
}



void Lib_SCplx_Acb_IbetaPrime(SCplxPtr res, const SCplxPtr a, const SCplxPtr b, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc3_Prec(acb_ibeta_derivative, res, a, b, z);
}



/* Hypergeometric Function 1F2, overview */



void Lib_SCplx_Acb_Hypgeom1F2(SCplxPtr res, const SCplxPtr a1, const SCplxPtr b1, const SCplxPtr b2, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_SCplx_Acb_Hypgeom1F2r(SCplxPtr res, const SCplxPtr a1, const SCplxPtr b1, const SCplxPtr b2, const SCplxPtr z)
{
    SCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2r_, res, a1, b1, b2, z);
}



//
//
//
////*********************** Boost Special functions, float precision **********************************
//
//
//
//void Lib_SReal_BernoulliB2n(float* res, const int n)
//{
//    LibSReal_BernoulliB2n(res, n);
//}
//
//
//
//void Lib_SReal_TangentT2n(float* res, const int n)
//{
//    LibSReal_TangentT2n(res, n);
//}
//
//
//
//void Lib_SReal_Sqrt1pm1_Boost(float* res, const float* x)
//{
//    LibSReal_Sqrt1pm1(res, x);
//}
//
//
//
//void Lib_SReal_SinPi_Boost(float* res, const float* x)
//{
//    LibSReal_SinPi(res, x);
//}
//
//
//
//void Lib_SReal_CosPi_Boost(float* res, const float* x)
//{
//    LibSReal_CosPi(res, x);
//}
//
//
//
//void Lib_SReal_SincPi(float* res, const float* x)
//{
//    LibSReal_SincPi(res, x);
//}
//
//
//
//void Lib_SReal_SinhcPi(float* res, const float* x)
//{
//    LibSReal_SinhcPi(res, x);
//}
//
//
//
//void Lib_SReal_Tgamma_(float* res, const float* x)
//{
//    LibSReal_Tgamma_(res, x);
//}
//
//
//void Lib_SReal_Tgamma1pm1(float* res, const float* x)
//{
//    LibSReal_Tgamma1pm1(res, x);
//}
//
//
//
//void Lib_SReal_Lgamma_(float* res, const float* x)
//{
//    LibSReal_Lgamma_(res, x);
//}
//
//
//
//void Lib_SReal_Digamma(float* res, const float* x)
//{
//    LibSReal_Digamma(res, x);
//}
//
//
//
//void Lib_SReal_Trigamma(float* res, const float* x)
//{
//    LibSReal_Trigamma(res, x);
//}
//
//
//
//void Lib_SReal_Factorial(float* res, const float* x)
//{
//    LibSReal_Factorial(res, x);
//}
//
//
//
//void Lib_SReal_DoubleFactorial(float* res, const float* x)
//{
//    LibSReal_DoubleFactorial(res, x);
//}
//
//
//
//
//
//void Lib_SReal_Erf_(float* res, const float* x)
//{
//    LibSReal_Erf_(res, x);
//}
//
//
//
//void Lib_SReal_Erfc_(float* res, const float* x)
//{
//    LibSReal_Erfc_(res, x);
//}
//
//
//
//void Lib_SReal_Erf_inv(float* res, const float* x)
//{
//    LibSReal_Erf_inv(res, x);
//}
//
//
//
//void Lib_SReal_Erfc_inv(float* res, const float* x)
//{
//    LibSReal_Erfc_inv(res, x);
//}
//
//
//
//void Lib_SReal_AiryAi(float* res, const float* x)
//{
//    LibSReal_AiryAi(res, x);
//}
//
//
//
//void Lib_SReal_AiryBi(float* res, const float* x)
//{
//    LibSReal_AiryBi(res, x);
//}
//
//
//
//void Lib_SReal_AiryAiPrime(float* res, const float* x)
//{
//    LibSReal_AiryAiPrime(res, x);
//}
//
//
//
//void Lib_SReal_AiryBiPrime(float* res, const float* x)
//{
//    LibSReal_AiryBiPrime(res, x);
//}
//
//
//
//void Lib_SReal_Aizero(float* res, const int n)
//{
//    LibSReal_Aizero(res, n);
//}
//
//
//
//void Lib_SReal_Bizero(float* res, const int n)
//{
//    LibSReal_Bizero(res, n);
//}
//
//
//
//void Lib_SReal_Ellint_1_K(float* res, const float* x)
//{
//    LibSReal_Ellint_1_K(res, x);
//}
//
//
//
//void Lib_SReal_Ellint_2_K(float* res, const float* x)
//{
//    LibSReal_Ellint_2_K(res, x);
//}
//
//
//
//void Lib_SReal_Zeta(float* res, const float* x)
//{
//    LibSReal_Zeta(res, x);
//}
//
//
//
//void Lib_SReal_Ei(float* res, const float* x)
//{
//    LibSReal_Ei(res, x);
//}
//
//
//
//void Lib_SReal_LambertW0(float* res, const float* x)
//{
//    LibSReal_LambertW0(res, x);
//}
//
//
//void Lib_SReal_LambertWm1(float* res, const float* x)
//{
//    LibSReal_LambertWm1(res, x);
//}
//
//
//
//void Lib_SReal_LambertW0Prime(float* res, const float* x)
//{
//    LibSReal_LambertW0Prime(res, x);
//}
//
//
//void Lib_SReal_LambertWm1Prime(float* res, const float* x)
//{
//    LibSReal_LambertWm1Prime(res, x);
//}
//
//
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//
//
//
//void Lib_SReal_Powm1_Boost(float* res, const float* a, const float* b)
//{
//    LibSReal_Powm1(res, a, b);
//}
//
//
//
//void Lib_SReal_TgammaRatio(float* res, const float* a, const float* b)
//{
//    LibSReal_TgammaRatio(res, a, b);
//}
//
//
//
//void Lib_SReal_TgammaDeltaRatio(float* res, const float* a, const float* b)
//{
//    LibSReal_TgammaDeltaRatio(res, a, b);
//}
//
//
//
//void Lib_SReal_Binomial(float* res, const float* n, const float* k)
//{
//    LibSReal_Binomial(res, n, k);
//}
//
//void Lib_SReal_RisingFactorial(float* res, const float* x, const float* n)
//{
//    LibSReal_RisingFactorial(res, x, n);
//}
//
//
//
//
//void Lib_SReal_FallingFactorial(float* res, const float* x, const float* n)
//{
//    LibSReal_FallingFactorial(res, x, n);
//}
//
//
//
//
//void Lib_SReal_BesselJ(float* res, const float* v, const float* x)
//{
//    LibSReal_BesselJ(res, v, x);
//}
//
//
//
//void Lib_SReal_BesselY(float* res, const float* v, const float* x)
//{
//    LibSReal_BesselY(res, v, x);
//}
//
//
//
//void Lib_SReal_BesselI(float* res, const float* v, const float* x)
//{
//    LibSReal_BesselI(res, v, x);
//}
//
//
//
//void Lib_SReal_BesselK(float* res, const float* v, const float* x)
//{
//    LibSReal_BesselK(res, v, x);
//}
//
//
//
//void Lib_SReal_SphBessel(float* res, const unsigned v, const float* x)
//{
//    LibSReal_SphBessel(res, v, x);
//}
//
//
//
//void Lib_SReal_SphNeumann(float* res, const unsigned v, const float* x)
//{
//    LibSReal_SphNeumann(res, v, x);
//}
//
//
//
//
//
//void Lib_SReal_BesselJPrime(float* res, const float* v, const float* x)
//{
//    LibSReal_BesselJPrime(res, v, x);
//}
//
//
//
//void Lib_SReal_BesselYPrime(float* res, const float* v, const float* x)
//{
//    LibSReal_BesselYPrime(res, v, x);
//}
//
//
//
//void Lib_SReal_BesselIPrime(float* res, const float* v, const float* x)
//{
//    LibSReal_BesselIPrime(res, v, x);
//}
//
//
//
//void Lib_SReal_BesselKPrime(float* res, const float* v, const float* x)
//{
//    LibSReal_BesselKPrime(res, v, x);
//}
//
//
//
//void Lib_SReal_SphBesselPrime(float* res, const unsigned v, const float* x)
//{
//    LibSReal_SphBesselPrime(res, v, x);
//}
//
//
//
//void Lib_SReal_SphNeumannPrime(float* res, const unsigned v, const float* x)
//{
//    LibSReal_SphNeumannPrime(res, v, x);
//}
//
//
//
//
//
//void Lib_SReal_BesselJZero(float* res, const float* v, const int m)
//{
//    LibSReal_BesselJZero(res, v, m);
//}
//
//
//
//void Lib_SReal_BesselYZero(float* res, const float* v, const int m)
//{
//    LibSReal_BesselYZero(res, v, m);
//}
//
//
//
//
//
//void Lib_SReal_GammaP(float* res, const float* a, const float* x)
//{
//    LibSReal_GammaP(res, a, x);
//}
//
//
//void Lib_SReal_GammaQ(float* res, const float* a, const float* x)
//{
//    LibSReal_GammaQ(res, a, x);
//}
//
//
//void Lib_SReal_TgammaLower(float* res, const float* a, const float* x)
//{
//    LibSReal_TgammaLower(res, a, x);
//}
//
//
//void Lib_SReal_TgammaUpper(float* res, const float* a, const float* x)
//{
//    LibSReal_TgammaUpper(res, a, x);
//}
//
//
//
//
//void Lib_SReal_GammaPInv(float* res, const float* a, const float* p)
//{
//    LibSReal_GammaPInv(res, a, p);
//}
//
//
//void Lib_SReal_GammaQInv(float* res, const float* a, const float* q)
//{
//    LibSReal_GammaQInv(res, a, q);
//}
//
//
//void Lib_SReal_GammaPInva(float* res, const float* x, const float* p)
//{
//    LibSReal_GammaPInva(res, x, p);
//}
//
//
//void Lib_SReal_GammaQInva(float* res, const float* x, const float* q)
//{
//    LibSReal_GammaQInva(res, x, q);
//}
//
//
//
//void Lib_SReal_GammaPDerivative(float* res, const float* a, const float* x)
//{
//    LibSReal_GammaPDerivative(res, a, x);
//}
//
//
//void Lib_SReal_Beta(float* res, const float* a, const float* b)
//{
//    LibSReal_Beta(res, a, b);
//}
//
//
//
//
//
//
//
//
//
//void Lib_SReal_LegendreP(float* res, int n, const float* x)
//{
//    LibSReal_LegendreP(res, n, x);
//}
//
//
//
//void Lib_SReal_LegendreQ(float* res, int n, const float* x)
//{
//    LibSReal_LegendreQ(res, n, x);
//}
//
//
//
//void Lib_SReal_Laguerre(float* res, int n, const float* x)
//{
//    LibSReal_Laguerre(res, n, x);
//}
//
//
//
//void Lib_SReal_Hermite(float* res, int n, const float* x)
//{
//    LibSReal_Hermite(res, n, x);
//}
//
//
//
//void Lib_SReal_ChebyshevT(float* res, int n, const float* x)
//{
//    LibSReal_ChebyshevT(res, n, x);
//}
//
//
//void Lib_SReal_ChebyshevU(float* res, int n, const float* x)
//{
//    LibSReal_ChebyshevU(res, n, x);
//}
//
//
//
//void Lib_SReal_Polygamma(float* res, int n, const float* x)
//{
//    LibSReal_Polygamma(res, n, x);
//}
//
//
//
//
//
//void Lib_SReal_EllintRC(float* res, const float* x, const float* y)
//{
//    LibSReal_EllintRC(res, x, y);
//}
//
//
//void Lib_SReal_Ellint1F(float* res, const float* k, const float* phi)
//{
//    LibSReal_Ellint1F(res, k, phi);
//}
//
//
//void Lib_SReal_Ellint2F(float* res, const float* k, const float* phi)
//{
//    LibSReal_Ellint2F(res, k, phi);
//}
//
//
//void Lib_SReal_Ellint3K(float* res, const float* k, const float* n)
//{
//    LibSReal_Ellint3K(res, k, n);
//}
//
//
//
//
//void Lib_SReal_JacobiCD(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiCD(res, k, u);
//}
//
//
//void Lib_SReal_JacobiCN(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiCN(res, k, u);
//}
//
//
//void Lib_SReal_JacobiCS(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiCS(res, k, u);
//}
//
//
//void Lib_SReal_JacobiDC(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiDC(res, k, u);
//}
//
//
//void Lib_SReal_JacobiDN(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiDN(res, k, u);
//}
//
//
//void Lib_SReal_JacobiDS(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiDS(res, k, u);
//}
//
//
//void Lib_SReal_JacobiNC(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiNC(res, k, u);
//}
//
//
//void Lib_SReal_JacobiND(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiND(res, k, u);
//}
//
//
//void Lib_SReal_JacobiNS(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiNS(res, k, u);
//}
//
//
//void Lib_SReal_JacobiSC(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiSC(res, k, u);
//}
//
//
//void Lib_SReal_JacobiSD(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiSD(res, k, u);
//}
//
//
//void Lib_SReal_JacobiSN(float* res, const float* k, const float* u)
//{
//    LibSReal_JacobiSN(res, k, u);
//}
//
//
//
//void Lib_SReal_expint(float* res, const unsigned n, const float* x)
//{
//    LibSReal_expint(res, n, x);
//}
//
//
//
//
//void Lib_SReal_OwenT(float* res, const float* h, const float* a)
//{
//    LibSReal_OwenT(res, h, a);
//}
//
//
//
//
//
//void Lib_SReal_IBeta(float* res, const float* a, const float* b, const float* x)
//{
//    LibSReal_IBeta(res, a, b, x);
//}
//
//
//void Lib_SReal_IBetac(float* res, const float* a, const float* b, const float* x)
//{
//    LibSReal_IBetac(res, a, b, x);
//}
//
//
//void Lib_SReal_IBetaNonNormalized(float* res, const float* a, const float* b, const float* x)
//{
//    LibSReal_IBetaNonNormalized(res, a, b, x);
//}
//
//
//void Lib_SReal_IBetacNonNormalized(float* res, const float* a, const float* b, const float* x)
//{
//    LibSReal_IBetacNonNormalized(res, a, b, x);
//}
//
//
//void Lib_SReal_IBetaInv(float* res, const float* a, const float* b, const float* p)
//{
//    LibSReal_IBetaInv(res, a, b, p);
//}
//
//
//void Lib_SReal_IBetacInv(float* res, const float* a, const float* b, const float* q)
//{
//    LibSReal_IBetacInv(res, a, b, q);
//}
//
//
//void Lib_SReal_IBetaInva(float* res, const float* b, const float* x, const float* p)
//{
//    LibSReal_IBetaInva(res, b, x, p);
//}
//
//
//void Lib_SReal_IBetacInva(float* res, const float* b, const float* x, const float* q)
//{
//    LibSReal_IBetacInva(res, b, x, q);
//}
//
//
//void Lib_SReal_IBetaInvb(float* res, const float* a, const float* x, const float* p)
//{
//    LibSReal_IBetaInvb(res, a, x, p);
//}
//
//
//void Lib_SReal_IBetacInvb(float* res, const float* a, const float* x, const float* q)
//{
//    LibSReal_IBetacInvb(res, a, x, q);
//}
//
//
//void Lib_SReal_IBetaDerivative(float* res, const float* a, const float* b, const float* x)
//{
//    LibSReal_IBetaDerivative(res, a, b, x);
//}
//
//
//
//
//void Lib_SReal_LegendrePM(float* res, const int n, const int m, const float* x)
//{
//    LibSReal_LegendrePM(res, n, m, x);
//}
//
//
//
//void Lib_SReal_LaguerreM(float* res, const int n, const int m, const float* x)
//{
//    LibSReal_LaguerreM(res, n, m, x);
//}
//
//
//
//
//
//void Lib_SReal_EllipticRF(float* res, const float* x, const float* y, const float* z)
//{
//    LibSReal_EllipticRF(res, x, y, z);
//}
//
//
//
//void Lib_SReal_EllipticRD(float* res, const float* x, const float* y, const float* z)
//{
//    LibSReal_EllipticRD(res, x, y, z);
//}
//
//
//
//void Lib_SReal_Ellint3F(float* res, const float* k, const float* n, const float* phi)
//{
//    LibSReal_Ellint3F(res, k, n, phi);
//}
//
//
//
//
//void Lib_SReal_SphericalHarmonicR(float* res, const int n, const int m, const float* theta, const float* phi)
//{
//    LibSReal_SphericalHarmonicR(res, n, m, theta, phi);
//}
//
//
//void Lib_SReal_SphericalHarmonicI(float* res, const int n, const int m, const float* theta, const float* phi)
//{
//    LibSReal_SphericalHarmonicI(res, n, m, theta, phi);
//}
//
//
//void Lib_SReal_EllipticRJ(float* res, const float* x, const float* y, const float* z, const float* p)
//{
//    LibSReal_EllipticRJ(res, x, y, z, p);
//}
//
//
//// Hypergeometric and Theta Functions
//
//
//
//
//void Lib_SReal_Hypergeo0F1(float* res, const float* b, const float* x)
//{
//    LibSReal_Hypergeo0F1(res, b, x);
//}
//
//
//
//void Lib_SReal_Hypergeo1F1(float* res, const float* a, const float* b, const float* x)
//{
//    LibSReal_Hypergeo1F1(res, a, b, x);
//}
//
//
//
//void Lib_SReal_Hypergeo1F1r(float* res, const float* a, const float* b, const float* x)
//{
//    LibSReal_Hypergeo1F1r(res, a, b, x);
//}
//
//
//
//void Lib_SReal_LogHypergeo1F1(float* res, const float* a, const float* b, const float* x)
//{
//    LibSReal_LogHypergeo1F1(res, a, b, x);
//}
//
//
//
//
//
//void Lib_SReal_JacobiTheta1(float* res, const float* x, const float* q)
//{
//    LibSReal_JacobiTheta1(res, x, q);
//}
//
//
//void Lib_SReal_JacobiTheta2(float* res, const float* x, const float* q)
//{
//    LibSReal_JacobiTheta2(res, x, q);
//}
//
//
//void Lib_SReal_JacobiTheta3(float* res, const float* x, const float* q)
//{
//    LibSReal_JacobiTheta3(res, x, q);
//}
//
//
//void Lib_SReal_JacobiTheta4(float* res, const float* x, const float* q)
//{
//    LibSReal_JacobiTheta4(res, x, q);
//}
//
//
//
//
//
//
////*********************** Distributions, float precision  **********************************
//
//
//void Lib_SReal_ArcsineDist(long Target, float* res, float* xqp, float* a, float* b)
//{
//    LibSReal_ArcsineDist(Target, res, xqp, a, b);
//}
//
//
//void Lib_SReal_BernoulliDist(long Target, float* res, float* xqp, float* p)
//{
//    LibSReal_BernoulliDist(Target, res, xqp, p);
//}
//
//
//void Lib_SReal_BetaDist(long Target, float* res, float* xqp, float* a, float* b)
//{
//    LibSReal_BetaDist(Target, res, xqp, a, b);
//}
//
//
//void Lib_SReal_BinomialDist(long Target, float* res, float* xqp, float* n, float* p)
//{
//    LibSReal_BinomialDist(Target, res, xqp, n, p);
//}
//
//
//void Lib_SReal_CauchyDist(long Target, float* res, float* xqp, float* location, float* scale)
//{
//    LibSReal_CauchyDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_SReal_Chi2Dist(long Target, float* res, float* xqp, float* nu)
//{
//    LibSReal_Chi2Dist(Target, res, xqp, nu);
//}
//
//void Lib_SReal_ExponentialDist(long Target, float* res, float* xqp, float* lambda)
//{
//    LibSReal_ExponentialDist(Target, res, xqp, lambda);
//}
//
//
//void Lib_SReal_ExtremeValueDist(long Target, float* res, float* xqp, float* location, float* scale)
//{
//    LibSReal_ExtremeValueDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_SReal_FisherFDist(long Target, float* res, float* xqp, float* mu, float* nu)
//{
//    LibSReal_FisherFDist(Target, res, xqp, mu, nu);
//}
//
//
//void Lib_SReal_GammaDist(long Target, float* res, float* xqp, float* shape, float* scale)
//{
//    LibSReal_GammaDist(Target, res, xqp, shape, scale);
//}
//
//
//void Lib_SReal_GeometricDist(long Target, float* res, float* xqp, float* p)
//{
//    LibSReal_GeometricDist(Target, res, xqp, p);
//}
//
//
//void Lib_SReal_HypergeometricDist(long Target, float* res, float* xqp, unsigned r, unsigned n, unsigned N)
//{
//    LibSReal_HypergeometricDist(Target, res, xqp, r, n, N);
//}
//
//
//void Lib_SReal_InverseChi2Dist(long Target, float* res, float* xqp, float* df, float* scale)
//{
//    LibSReal_InverseChi2Dist(Target, res, xqp, df, scale);
//}
//
//
//
//void Lib_SReal_InverseGammaDist(long Target, float* res, float* xqp, float* shape, float* scale)
//{
//    LibSReal_InverseGammaDist(Target, res, xqp, shape, scale);
//}
//
//
//void Lib_SReal_WaldDist(long Target, float* res, float* xqp, float* mean_, float* scale)
//{
//    LibSReal_InverseGaussianDist(Target, res, xqp, mean_, scale);
//}
//
//
//void Lib_SReal_LaplaceDist(long Target, float* res, float* xqp, float* location, float* scale)
//{
//    LibSReal_LaplaceDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_SReal_LogisticDist(long Target, float* res, float* xqp, float* location, float* scale)
//{
//    LibSReal_LogisticDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_SReal_LognormalDist(long Target, float* res, float* xqp, float* location, float* scale)
//{
//    LibSReal_LognormalDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_SReal_NegBinomialDist(long Target, float* res, float* xqp, float* n, float* p)
//{
//    LibSReal_NegBinomialDist(Target, res, xqp, n, p);
//}
//
//
//void Lib_SReal_Chi2NcDist(long Target, float* res, float* xqp, float* nu, float* nc)
//{
//    LibSReal_Chi2NCDist(Target, res, xqp, nu, nc);
//}
//
//
//void Lib_SReal_StudentTNcDist(long Target, float* res, float* xqp, float* nu, float* delta)
//{
//    LibSReal_StudentTNCDist(Target, res, xqp, nu, delta);
//}
//
//
//void Lib_SReal_FisherNcDist(long Target, float* res, float* xqp, float* mu, float* nu, float* nc)
//{
//    LibSReal_FisherNCDist(Target, res, xqp, mu, nu, nc);
//}
//
//
//void Lib_SReal_BetaNcDist(long Target, float* res, float* xqp, float* a, float* b, float* nc)
//{
//    LibSReal_BetaNCDist(Target, res, xqp, a, b, nc);
//}
//
//
//void Lib_SReal_NormalDist(long Target, float* res, float* xqp, float* mean_, float* stdev)
//{
//    LibSReal_NormalDist(Target, res, xqp, mean_, stdev);
//}
//
//
//void Lib_SReal_ParetoDist(long Target, float* res, float* xqp, float* shape, float* scale)
//{
//    LibSReal_ParetoDist(Target, res, xqp, shape, scale);
//}
//
//
//void Lib_SReal_PoissonDist(long Target, float* res, float* xqp, float* nu)
//{
//    LibSReal_PoissonDist(Target, res, xqp, nu);
//}
//
//
//void Lib_SReal_RayleighDist(long Target, float* res, float* xqp, float* nu)
//{
//    LibSReal_RayleighDist(Target, res, xqp, nu);
//}
//
//
//void Lib_SReal_SkewNormalDist(long Target, float* res, float* xqp, float* mean_, float* scale, float* shape)
//{
//    LibSReal_SkewNormalDist(Target, res, xqp, mean_, scale, shape);
//}
//
//
//void Lib_SReal_StudentTDist(long Target, float* res, float* xqp, float* nu)
//{
//    LibSReal_StudentTDist(Target, res, xqp, nu);
//}
//
//
//void Lib_SReal_TriangularDist(long Target, float* res, float* xqp, float* lower, float* mode_, float* upper)
//{
//    LibSReal_TriangularDist(Target, res, xqp, lower, mode_, upper);
//}
//
//
//void Lib_SReal_WeibullDist(long Target, float* res, float* xqp, float* shape, float* scale)
//{
//    LibSReal_WeibullDist(Target, res, xqp, shape, scale);
//}
//
//
//void Lib_SReal_UniformDist(long Target, float* res, float* xqp, float* lower, float* upper)
//{
//    LibSReal_UniformDist(Target, res, xqp, lower, upper);
//}
//
//
//
//
//
//
////*********************** Numerical Calculus, float precision  **********************************
//
//
//
//
//void Lib_SReal_BracketRoot(float* res1, float* res2, int* iter, SRealFuncPtr f1, float* guess, float* factor, bool is_rising, int get_digits, unsigned int maxit)
//{
//    LibSReal_BracketRoot(res1, res2, iter, f1, guess, factor, is_rising, get_digits, maxit);
//}
//
//
//
//void Lib_SReal_NewtonRaphson(float* res,  int* iter, SRealFuncPtr f1, SRealFuncPtr f2, float* guess, float* xmin, float* xmax, int get_digits, unsigned int maxit)
//{
//    LibSReal_NewtonRaphson(res, iter, f1, f2, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_SReal_Halley(float* res,  int* iter, SRealFuncPtr f1, SRealFuncPtr f2, SRealFuncPtr f3, float* guess, float* xmin, float* xmax, int get_digits, unsigned int maxit)
//{
//    LibSReal_Halley(res, iter, f1, f2, f3, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_SReal_Schroder(float* res,  int* iter, SRealFuncPtr f1, SRealFuncPtr f2, SRealFuncPtr f3, float* guess, float* xmin, float* xmax, int get_digits, unsigned int maxit)
//{
//    LibSReal_Schroder(res, iter, f1, f2, f3, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_SReal_Brent_Minimum(float* res, float* resFx, int* iter, SRealFuncPtr f1, float* bracket_min, float* bracket_max, int bits, unsigned int maxit)
//{
//    LibSReal_Brent_Minimum(res, resFx, iter, f1, bracket_min, bracket_max, bits, maxit);
//}
//
//
//
//
//void Lib_SReal_Trapezoidal(float* res1, float* res2, float* res3, SRealFuncPtr f1, float* a, float* b)
//{
//    LibSReal_Trapezoidal(res1, res2, res3, f1, a, b);
//}
//
//
//
//// 7, 15, 20, 25 and 30
//
//void Lib_SReal_GaussLegendre(float* res1, float* res3, SRealFuncPtr f1, float* a, float* b)
//{
//    LibSReal_GaussLegendre(res1, res3, f1, a, b);
//}
//
//
//
//
////15, 31, 41, 51 and 61
//
//void Lib_SReal_GaussKronrod(float* res1, float* res2, float* res3, SRealFuncPtr f1, float* a, float* b)
//{
//    LibSReal_GaussKronrod(res1, res2, res3, f1, a, b);
//}
//
//
//
//void Lib_SReal_TanhSinh(float* res1, float* res2, float* res3, int* levels_, SRealFuncPtr f1, float* a, float* b)
//{
//    LibSReal_TanhSinh(res1, res2, res3, levels_, f1, a, b);
//}
//
//
//
//void Lib_SReal_SinhSinh(float* res1, float* res2, float* res3, int* levels_, SRealFuncPtr f1)
//{
//    LibSReal_SinhSinh(res1, res2, res3, levels_, f1);
//}
//
//
//
//void Lib_SReal_ExpSinh(float* res1, float* res2, float* res3, int* levels_, SRealFuncPtr f1)
//{
//    LibSReal_ExpSinh(res1, res2, res3, levels_, f1);
//}
//
//
//
//void Lib_SReal_Ooura_Cos(float* res1, float* res2, SRealFuncPtr f1)
//{
//    LibSReal_Ooura_Cos(res1, res2, f1);
//}
//
//
//
//void Lib_SReal_Ooura_Sin(float* res1, float* res2, SRealFuncPtr f1)
//{
//    LibSReal_Ooura_Sin(res1, res2, f1);
//}
//
//
//
//
//
//
////*********************** Boost Odeint **********************************
//
//
//void Lib_SReal_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt)
//{
//	LibSReal_Const_RungeKutta4((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_SReal_Const_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt)
//{
//	LibSReal_Const_RungeKuttaCashKarp54((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_SReal_Const_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt)
//{
//	LibSReal_Const_RungeKuttaDopri5((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_SReal_Const_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt)
//{
//	LibSReal_Const_RungeKuttaFehlberg78((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_SReal_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt)
//{
//	LibSReal_Const_AdamsBashforthMoulton((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//
//
//
//void Lib_SReal_Adaptive_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel)
//{
//	LibSReal_Adaptive_RungeKuttaDopri5((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt,     *eps_abs , *eps_rel);
//}
//
//
//void Lib_SReal_Adaptive_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel)
//{
//	LibSReal_Adaptive_RungeKuttaCashKarp54((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt, *eps_abs , *eps_rel);
//}
//
//
//void Lib_SReal_Adaptive_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel)
//{
//	LibSReal_Adaptive_RungeKuttaFehlberg78((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt, *eps_abs , *eps_rel);
//}
//
//
//void Lib_SReal_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel)
//{
//	LibSReal_Adaptive_BulirschStoer((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt, *eps_abs , *eps_rel);
//}
//
//
//
//void Lib_SReal_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel)
//{
//	LibSReal_DenseOutput_Dopri5((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt, *eps_abs , *eps_rel);
//}
//
//
//void Lib_SReal_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, float* start_time, float* end_time, float* dt, float* eps_abs, float* eps_rel)
//{
//	LibSReal_DenseOutput_BulirschStoer((SAnyFuncPtr3)f1, (SAnyFuncPtr2)f2, (SStatePtr)matX, *start_time, *end_time, *dt, *eps_abs , *eps_rel);
//}
//
//
//














































