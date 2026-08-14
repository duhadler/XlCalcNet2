
#include "mpNumC_Main.h"

#include "stdint.h"
#include <complex>
#include <vector>
#include <iostream>
#include <limits>
#include "float.h"
#include "Helperfunctions.h"
#include <numbers>

using namespace std;
using namespace std::numbers;





double* Lib_FReal_Init_Func()
{
	double* x = NULL;
	x = (double*)malloc(sizeof(double));
	*x = 0.0;
	return x;
}

void Lib_FReal_Clear(double* x)
{
	free(x);
}



/* Input and output  */


void Lib_FReal_Set(double* res, const double* x)
{
	*res = (*x);
}


void Lib_FReal_Set_Arb(double* res, const ArbPtr x)
{
	*res = arf_get_d(arb_midref((arb_ptr)x), ARF_RND_NEAR);
}

void Lib_FReal_Set_Arf(double* res, const ArfPtr x)
{
	*res = arf_get_d((arf_ptr)x, ARF_RND_NEAR);
}


void Lib_FReal_Set_Mpfr(double* res, const MpfrPtr x)
{
	*res = mpfr_get_d((mpfr_ptr)x, MPFR_RNDN);
}



FCplxPtr Lib_FCplx_Init_Func()
{
	FCplxPtr x = NULL;
	x = (std::complex<double>*) malloc(sizeof(std::complex<double>));
	return x;
}


void Lib_FCplx_Clear(FCplxPtr x)
{
	free(x);
}





/* Input and output  */

void Lib_FCplx_Set(FCplxPtr res, const FCplxPtr x)
{
	(*(std::complex<double>*) res)  = (*(std::complex<double>*) x);
}


void Lib_FCplx_Set_Real(FCplxPtr res, const double* re)
{
	(*(std::complex<double>*) res) = std::complex<double>(*re, 0);
}

void Lib_FCplx_Set2(FCplxPtr res, const double* re, const double* im)
{
	(*(std::complex<double>*) res) = std::complex<double>(*re, *im);
}



void Lib_FCplx_Imag(double* res, const FCplxPtr x)
{
	*res = (*(std::complex<double>*) x).imag();
}

void Lib_FCplx_Real(double* res, const FCplxPtr x)
{
	*res = (*(std::complex<double>*) x).real();
}




void Lib_FCplx_Set_Acb(FCplxPtr res, const AcbPtr x)
{
    (*(std::complex<double>*) res) = std::complex<double>(
        arf_get_d(arb_midref(acb_realref((acb_ptr)x)), ARF_RND_NEAR),
        arf_get_d(arb_midref(acb_imagref((acb_ptr)x)), ARF_RND_NEAR));
}



//void FCplx_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, FCplxPtr res, const FCplxPtr x1)
//{
//	//printf("using FCplx_Acb_Cplxfunc1_Prec:  ");
//	slong wp = 80;  // 53 * 1.5
//
//    acb_t out1_acb, in1_acb;
//    acb_init(out1_acb); acb_init(in1_acb);
//
//    acb_set_d_d(in1_acb, (*(std::complex<double>*) x1).real(), (*(std::complex<double>*) x1).imag());
//
//	f1(out1_acb, in1_acb, wp);
//
//    (*(std::complex<double>*) res) = std::complex<double>(
//          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
//          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));
//
//    acb_clear(out1_acb); acb_clear(in1_acb);
//}




//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////




void FReal_Arb_Realfunc0Int32_Prec(ArbFuncPtr0Int32 f0Int32, double* res, int32_t in1)
{
	//printf("using FReal_Arb_Realfunc1_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    arb_t out1_arb;
    arb_init(out1_arb);

	f0Int32((arb_ptr)out1_arb, in1, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb);
}





void FReal_Arb_Realfunc1_Prec(ArbFuncPtr1 f1, double* res, const double* x1)
{
	//printf("using FReal_Arb_Realfunc1_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);
    arb_set_d(in1_arb, (double)*x1);

	f1(out1_arb, in1_arb, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb);
}




void FReal_Arb_Realfunc1Int32_Prec(ArbFuncPtr1Int32 f1Int32, double* res, const double* x1, int32_t in2)
{
	//printf("using FReal_Arb_Realfunc1Int32_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);
    arb_set_d(in1_arb, (double)*x1);

	//f1(out1_arb, in1_arb, wp);
	f1Int32(out1_arb, in1_arb, in2, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb);
}





void FReal_Arb_Realfunc2_Prec(ArbFuncPtr2 f2, double* res, const double* x1, const double* x2)
{
	//printf("using FReal_Arb_Realfunc2_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    arb_t out1_arb, in1_arb, in2_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb);
    arb_set_d(in1_arb, (double)*x1); arb_set_d(in2_arb, (double)*x2);

	f2(out1_arb, in1_arb, in2_arb, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb);
}





void FReal_Arb_Realfunc3_Prec(ArbFuncPtr3 f3, double* res, const double* x1, const double* x2, const double* x3)
{
	//printf("using FReal_Arb_Realfunc3_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    arb_t out1_arb, in1_arb, in2_arb, in3_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb);
    arb_set_d(in1_arb, (double)*x1); arb_set_d(in2_arb, (double)*x2); arb_set_d(in3_arb, (double)*x3);

	f3(out1_arb, in1_arb, in2_arb, in3_arb, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb);
}





void FReal_Arb_Realfunc4_Prec(ArbFuncPtr4 f4, double* res, const double* x1, const double* x2, const double* x3, const double* x4)
{
	//printf("using FReal_Arb_Realfunc4_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    arb_t out1_arb, in1_arb, in2_arb, in3_arb, in4_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb); arb_init(in4_arb);
    arb_set_d(in1_arb, (double)*x1); arb_set_d(in2_arb, (double)*x2);
    arb_set_d(in3_arb, (double)*x3); arb_set_d(in4_arb, (double)*x4);

	f4(out1_arb, in1_arb, in2_arb, in3_arb, in4_arb, wp);
    *res = arf_get_d(arb_midref(out1_arb), ARF_RND_NEAR);

    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb); arb_clear(in4_arb);
}





void FCplx_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, FCplxPtr res, const int32_t in1)
{
	//printf("using FCplx_Acb_Cplxfunc0Int32_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    acb_t out1_acb;
    acb_init(out1_acb);

	f0Int32((acb_ptr)out1_acb, in1, wp);

    (*(std::complex<double>*) res) = std::complex<double>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb);
}




void FCplx_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, FCplxPtr res, const FCplxPtr x1)
{
	//printf("using FCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);

    acb_set_d_d(in1_acb, (*(std::complex<double>*) x1).real(), (*(std::complex<double>*) x1).imag());

	f1(out1_acb, in1_acb, wp);

    (*(std::complex<double>*) res) = std::complex<double>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb);
}




void FCplx_Acb_Cplxfunc1Int32_Prec(AcbFuncPtr1Int32 f1Int32, FCplxPtr res, const FCplxPtr x1, int32_t in2)
{
	//printf("using FCplx_Acb_Cplxfunc1Int32_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);

    acb_set_d_d(in1_acb, (*(std::complex<double>*) x1).real(), (*(std::complex<double>*) x1).imag());

	f1Int32((acb_ptr)out1_acb, (acb_ptr)in1_acb, in2, wp);

    (*(std::complex<double>*) res) = std::complex<double>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb);
}




void FCplx_Acb_Cplxfunc2_Prec(AcbFuncPtr2 f2, FCplxPtr res, const FCplxPtr x1, const FCplxPtr x2)
{
	//printf("using FCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    acb_t out1_acb, in1_acb, in2_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb);

    acb_set_d_d(in1_acb, (*(std::complex<double>*) x1).real(), (*(std::complex<double>*) x1).imag());
    acb_set_d_d(in2_acb, (*(std::complex<double>*) x2).real(), (*(std::complex<double>*) x2).imag());

	f2(out1_acb, in1_acb, in2_acb, wp);

    (*(std::complex<double>*) res) = std::complex<double>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb);
}




void FCplx_Acb_Cplxfunc3_Prec(AcbFuncPtr3 f3, FCplxPtr res, const FCplxPtr x1, const FCplxPtr x2, const FCplxPtr x3)
{
	//printf("using FCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    acb_t out1_acb, in1_acb, in2_acb, in3_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb);

    acb_set_d_d(in1_acb, (*(std::complex<double>*) x1).real(), (*(std::complex<double>*) x1).imag());
    acb_set_d_d(in2_acb, (*(std::complex<double>*) x2).real(), (*(std::complex<double>*) x2).imag());
    acb_set_d_d(in3_acb, (*(std::complex<double>*) x3).real(), (*(std::complex<double>*) x3).imag());

	f3(out1_acb, in1_acb, in2_acb, in3_acb, wp);

    (*(std::complex<double>*) res) = std::complex<double>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb);
}




void FCplx_Acb_Cplxfunc4_Prec(AcbFuncPtr4 f4, FCplxPtr res, const FCplxPtr x1, const FCplxPtr x2, const FCplxPtr x3, const FCplxPtr x4)
{
	//printf("using FCplx_Acb_Cplxfunc4_Prec:  ");
	slong wp = 80;  // 53 * 1.5

    acb_t out1_acb, in1_acb, in2_acb, in3_acb, in4_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb); acb_init(in4_acb);

    acb_set_d_d(in1_acb, (*(std::complex<double>*) x1).real(), (*(std::complex<double>*) x1).imag());
    acb_set_d_d(in2_acb, (*(std::complex<double>*) x2).real(), (*(std::complex<double>*) x2).imag());
    acb_set_d_d(in3_acb, (*(std::complex<double>*) x3).real(), (*(std::complex<double>*) x3).imag());
    acb_set_d_d(in4_acb, (*(std::complex<double>*) x4).real(), (*(std::complex<double>*) x4).imag());

	f4(out1_acb, in1_acb, in2_acb, in3_acb, in4_acb, wp);

    (*(std::complex<double>*) res) = std::complex<double>(
          arf_get_d(arb_midref(acb_realref(out1_acb)), ARF_RND_NEAR),
          arf_get_d(arb_midref(acb_imagref(out1_acb)), ARF_RND_NEAR));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb); acb_clear(in4_acb);
}














//*********************** Flint **********************************


//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////





/* Roots and quadratic, cubic, and quartic equations */



void Lib_FReal_Arb_Sqrt(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sqrt, res, x);
}


void Lib_FReal_Arb_Rsqrt(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_rsqrt, res, x);
}


void Lib_FReal_Arb_Cbrt(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_cbrt, res, x);
}


void Lib_FReal_Arb_Sqrt1pm1(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sqrt1pm1, res, x);
}


void Lib_FReal_Arb_Root_ui(double* res, const double* x, const int32_t n)
{
    FReal_Arb_Realfunc1Int32_Prec(arb_root_ui_, res, x, n);
}


void Lib_FReal_Arb_Root_si(double* res, const double* x, const int32_t n)
{
    FReal_Arb_Realfunc1Int32_Prec(arb_root_si_, res, x, n);
}




/* Exponential and related functions */



void Lib_FReal_Arb_Exp(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_exp, res, x);
}


void Lib_FReal_Arb_Expm1(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_expm1, res, x);
}


void Lib_FReal_Arb_Exp10(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_exp10_, res, x);
}


void Lib_FReal_Arb_Exp2(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_exp2_, res, x);
}


void Lib_FReal_Arb_Exp10m1(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_exp10m1_, res, x);
}


void Lib_FReal_Arb_Exp2m1(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_exp2m1_, res, x);
}


void Lib_FReal_Arb_ExpRel(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_exprel_, res, x);
}



/* Logarithms and related functions */



void Lib_FReal_Arb_Log(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_log, res, x);
}


void Lib_FReal_Arb_Logbase(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_logbase_, res, x, y);
}


void Lib_FReal_Arb_Log10(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_log10, res, x);
}


void Lib_FReal_Arb_Log2(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_log2, res, x);
}


void Lib_FReal_Arb_Log1p(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_log1p, res, x);
}


void Lib_FReal_Arb_Log10p1(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_log10p1_, res, x);
}


void Lib_FReal_Arb_Log2p1(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_log2p1_, res, x);
}


void Lib_FReal_Arb_Log1mexp(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_log1mexp_, res, x);
}


void Lib_FReal_Arb_LambertW0(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_lambertw0, res, x);
}


void Lib_FReal_Arb_LambertWm1(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_lambertwm1, res, x);
}





/* Power functions */


void Lib_FReal_Arb_Square(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sqr, res, x);
}


void Lib_FReal_Arb_Cube(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_cube_, res, x);
}


void Lib_FReal_Arb_Pow_ui(double* res, const double* x, const int32_t n)
{
    FReal_Arb_Realfunc1Int32_Prec(arb_pow_ui_, res, x, n);
}


void Lib_FReal_Arb_Pow_si(double* res, const double* x, const int32_t n)
{
    FReal_Arb_Realfunc1Int32_Prec(arb_pow_si_, res, x, n);
}


void Lib_FReal_Arb_Compound_si(double* res, const double* x, const int32_t n)
{
    FReal_Arb_Realfunc1Int32_Prec(arb_compound_si_, res, x, n);
}


void Lib_FReal_Arb_Hypot(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypot, res, x, y);
}


void Lib_FReal_Arb_Pow(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_pow, res, x, y);
}


void Lib_FReal_Arb_Powm1(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_powm1_, res, x, y);
}


void Lib_FReal_Arb_Pow1p(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_pow1p_, res, x, y);
}


void Lib_FReal_Arb_Pow1pm1(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_pow1pm1_, res, x, y);
}





/* Trigonometric and related functions */



void Lib_FReal_Arb_Sin(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sin, res, x);
}


void Lib_FReal_Arb_Cos(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_cos, res, x);
}


void Lib_FReal_Arb_Tan(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_tan, res, x);
}


void Lib_FReal_Arb_Csc(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_csc, res, x);
}


void Lib_FReal_Arb_Sec(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sec, res, x);
}


void Lib_FReal_Arb_Cot(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_cot, res, x);
}


void Lib_FReal_Arb_Sinc(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sinc, res, x);
}


void Lib_FReal_Arb_SincPi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sinc_pi, res, x);
}


void Lib_FReal_Arb_SinPi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sin_pi, res, x);
}


void Lib_FReal_Arb_CosPi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_cos_pi, res, x);
}


void Lib_FReal_Arb_TanPi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_tan_pi, res, x);
}


void Lib_FReal_Arb_CotPi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_cot_pi, res, x);
}






/* Hyperbolic functions */


void Lib_FReal_Arb_Sinh(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sinh, res, x);
}


void Lib_FReal_Arb_Cosh(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_cosh, res, x);
}


void Lib_FReal_Arb_Tanh(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_tanh, res, x);
}


void Lib_FReal_Arb_Csch(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_csch, res, x);
}


void Lib_FReal_Arb_Sech(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_sech, res, x);
}


void Lib_FReal_Arb_Coth(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_coth, res, x);
}







/* Inverse trigonometric functions */



void Lib_FReal_Arb_Asin(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_asin, res, x);
}


void Lib_FReal_Arb_Acos(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_acos, res, x);
}


void Lib_FReal_Arb_Atan2(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_atan2, res, x, y);
}


void Lib_FReal_Arb_Atan(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_atan, res, x);
}


void Lib_FReal_Arb_Acsc(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_acsc, res, x);
}


void Lib_FReal_Arb_Asec(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_asec, res, x);
}


void Lib_FReal_Arb_Acot(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_acot, res, x);
}









/* Inverse hyperbolic functions */



void Lib_FReal_Arb_Asinh(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_asinh, res, x);
}


void Lib_FReal_Arb_Acosh(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_acosh, res, x);
}


void Lib_FReal_Arb_Atanh(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_atanh, res, x);
}


void Lib_FReal_Arb_Acsch(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_acsch, res, x);
}


void Lib_FReal_Arb_Asech(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_asech, res, x);
}


void Lib_FReal_Arb_Acoth(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_acoth, res, x);
}








/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_FReal_Arb_MEllipticK(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_elliptic_k, res, x);
}


void Lib_FReal_Arb_MEllipticE(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_elliptic_e, res, x);
}


void Lib_FReal_Arb_MEllipticPi(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_elliptic_pi, res, x, y);
}


void Lib_FReal_Arb_MEllipticF(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_elliptic_f_, res, x, y);
}


void Lib_FReal_Arb_MEllipticEInc(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_, res, x, y);
}


void Lib_FReal_Arb_MEllipticPiInc(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_, res, a, b, z);
}




/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_FReal_Arb_EllipticK(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_elliptic_k_k_, res, x);
}


void Lib_FReal_Arb_EllipticE(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_elliptic_e_k_, res, x);
}


void Lib_FReal_Arb_EllipticPi(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_elliptic_pi_k_, res, x, y);
}


void Lib_FReal_Arb_EllipticF(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_elliptic_f_k_, res, x, y);
}


void Lib_FReal_Arb_EllipticEInc(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_k_, res, x, y);
}


void Lib_FReal_Arb_EllipticPiInc(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_k_, res, a, b, z);
}


void Lib_FReal_Arb_Agm(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */


void Lib_FReal_Arb_Elliptic_RC(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_elliptic_rc_, res, x, y);
}


void Lib_FReal_Arb_Elliptic_RF(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_elliptic_rf_, res, a, b, z);
}


void Lib_FReal_Arb_Elliptic_RG(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_elliptic_rg_, res, a, b, z);
}


void Lib_FReal_Arb_Elliptic_RD(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_elliptic_rd_, res, a, b, z);
}


void Lib_FReal_Arb_Elliptic_RJ(double* res, const double* a, const double* b, const double* c, const double* z)
{
    FReal_Arb_Realfunc4_Prec(arb_elliptic_rj_, res, a, b, c, z);
}





/* Jacobi theta functions */


void Lib_FReal_Arb_Theta1Q(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_theta1q, res, x, y);
}


void Lib_FReal_Arb_Theta2Q(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_theta2q, res, x, y);
}


void Lib_FReal_Arb_Theta3Q(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_theta3q, res, x, y);
}


void Lib_FReal_Arb_Theta4Q(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_theta4q, res, x, y);
}




/* Jacobi elliptic functions */


void Lib_FReal_Arb_JacobiSN(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_sn, res, x, y);
}


void Lib_FReal_Arb_JacobiCN(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_cn, res, x, y);
}


void Lib_FReal_Arb_JacobiDN(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_dn, res, x, y);
}


void Lib_FReal_Arb_JacobiNS(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_ns, res, x, y);
}


void Lib_FReal_Arb_JacobiNC(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_nc, res, x, y);
}


void Lib_FReal_Arb_JacobiND(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_nd, res, x, y);
}


void Lib_FReal_Arb_JacobiSC(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_sc, res, x, y);
}


void Lib_FReal_Arb_JacobiSD(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_sd, res, x, y);
}


void Lib_FReal_Arb_JacobiDC(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_dc, res, x, y);
}


void Lib_FReal_Arb_JacobiDS(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_ds, res, x, y);
}


void Lib_FReal_Arb_JacobiCS(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_cs, res, x, y);
}


void Lib_FReal_Arb_JacobiCD(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(_arb_jacobi_cd, res, x, y);
}





/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */



void Lib_FReal_Arb_LerchPhi(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_dirichlet_lerch_phi, res, a, b, z);
}




/* Polygamma functions */


void Lib_FReal_Arb_Polygamma(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_polygamma, res, x, y);
}


void Lib_FReal_Arb_Digamma(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_FReal_Arb_Polylog(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_polylog, res, x, y);
}


void Lib_FReal_Arb_Dilog(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_dilog, res, x);
}




/* Hurwitz zeta function and related functions */


void Lib_FReal_Arb_HurwitzZeta(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hurwitz_zeta, res, x, y);
}



void Lib_FReal_Arb_Bernoulli_ui(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_bernoulli_ui_, res, n);
}


void Lib_FReal_Arb_Euler_ui(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_euler_number_ui_, res, n);
}


void Lib_FReal_Arb_BernoulliPoly_ui(double* res, const double* x, const int32_t n)
{
    FReal_Arb_Realfunc1Int32_Prec(arb_bernoulli_poly_ui_, res, x, n);
}



void Lib_FReal_Arb_BarnesG(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_barnes_g, res, x);
}


void Lib_FReal_Arb_LogBarnesG(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_log_barnes_g, res, x);
}






/* Riemann zeta function, and related functions */



void Lib_FReal_Arb_Zeta(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_zeta, res, x);
}


void Lib_FReal_Arb_BacklundS(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(acb_dirichlet_backlund_s, res, x);
}


void Lib_FReal_Arb_GramPoint_ui(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_gram_point_ui_, res, n);
}





/* Additional numbertheoretic functions */


void Lib_FReal_Arb_Bell_ui(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_bell_ui_, res, n);
}


void Lib_FReal_Arb_Partitions_ui(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_partitions_ui_, res, n);
}


void Lib_FReal_Arb_Primorial_ui(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_primorial_nth_ui_, res, n);
}





/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_FReal_Arb_Hypgeom0F1(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_, res, x, y);
}


void Lib_FReal_Arb_Hypgeom0F1r(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_r, res, x, y);
}




/* Bessel functions and modified Bessel functions  */


void Lib_FReal_Arb_BesselJ(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_j, res, x, y);
}


void Lib_FReal_Arb_BesselY(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_y, res, x, y);
}


void Lib_FReal_Arb_BesselI(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i, res, x, y);
}


void Lib_FReal_Arb_BesselK(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k, res, x, y);
}


void Lib_FReal_Arb_BesselIScaled(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_FReal_Arb_BesselKScaled(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */





/* Airy functions  */



void Lib_FReal_Arb_AiryAi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_airy_ai, res, x);
}


void Lib_FReal_Arb_AiryAiPrime(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_airy_ai_prime, res, x);
}


void Lib_FReal_Arb_AiryBi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_airy_bi, res, x);
}


void Lib_FReal_Arb_AiryBiPrime(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_airy_bi_prime, res, x);
}




void Lib_FReal_Arb_AiryAiZero(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_zero, res, n);
}


void Lib_FReal_Arb_AiryAiPrimeZero(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_prime_zero, res, n);
}


void Lib_FReal_Arb_AiryBiZero(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_zero, res, n);
}


void Lib_FReal_Arb_AiryBiPrimeZero(double* res, const int32_t n)
{
    FReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_prime_zero, res, n);
}






/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


void Lib_FReal_Arb_Hypgeom1F1(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1_, res, a, b, z);
}


void Lib_FReal_Arb_Hypgeom1F1r(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_FReal_Arb_HypgeomU(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_u, res, a, b, z);
}






/* Gamma function and related functions */


void Lib_FReal_Arb_Gamma(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_gamma, res, x);
}


void Lib_FReal_Arb_Rgamma(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_rgamma, res, x);
}


void Lib_FReal_Arb_Lgamma(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_lgamma, res, x);
}


void Lib_FReal_Arb_RisingFactorial(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_rising, res, x, y);
}


void Lib_FReal_Arb_Beta(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_beta_, res, x, y);
}





/* Incomplete gamma functions */



void Lib_FReal_Arb_GammaUpper(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_gamma_upper_, res, x, y);
}


void Lib_FReal_Arb_GammaUpperR(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_gamma_upper_r, res, x, y);
}


void Lib_FReal_Arb_GammaLower(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_gamma_lower_, res, x, y);
}


void Lib_FReal_Arb_GammaPPrime(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_gamma_p_derivative, res, x, y);
}


void Lib_FReal_Arb_GammaP(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_gamma_p, res, x, y);
}


void Lib_FReal_Arb_GammaQ(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_gamma_q, res, x, y);
}





/* Error function and related functions */


void Lib_FReal_Arb_Erf(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_erf, res, x);
}


void Lib_FReal_Arb_Erfc(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_erfc, res, x);
}


void Lib_FReal_Arb_Erfinv(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_erfinv, res, x);
}


void Lib_FReal_Arb_Erfcinv(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_erfcinv, res, x);
}


void Lib_FReal_Arb_Erfi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_erfi, res, x);
}


void Lib_FReal_Arb_FresnelC(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_fresnelc, res, x);
}


void Lib_FReal_Arb_FresnelS(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_fresnels, res, x);
}


void Lib_FReal_Arb_Ndens(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_ndens, res, x);
}


void Lib_FReal_Arb_Ndis(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_ndis, res, x);
}







/* Exponential integrals and related functions */


void Lib_FReal_Arb_ExpIntegralE(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_expint, res, x, y);
}


void Lib_FReal_Arb_ExpIntegralEi(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_ei, res, x);
}


void Lib_FReal_Arb_SinIntegral(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_si, res, x);
}


void Lib_FReal_Arb_CosIntegral(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_ci, res, x);
}


void Lib_FReal_Arb_SinhIntegral(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_shi, res, x);
}


void Lib_FReal_Arb_CoshIntegral(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_chi, res, x);
}


void Lib_FReal_Arb_LogIntegral(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_li_, res, x);
}


void Lib_FReal_Arb_LogIntegralOffset(double* res, const double* x)
{
    FReal_Arb_Realfunc1_Prec(arb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_FReal_Arb_HermiteH(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_hermite_h, res, x, y);
}


void Lib_FReal_Arb_LaguerreL(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */


void Lib_FReal_Arb_CoulombF(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_f, res, a, b, z);
}


void Lib_FReal_Arb_CoulombG(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_g, res, a, b, z);
}





/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_FReal_Arb_Hyp2f1(double* res, const double* a, const double* b, const double* c, const double* z)
{
    FReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_FReal_Arb_Hyp2f1r(double* res, const double* a, const double* b, const double* c, const double* z)
{
    FReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1r_, res, a, b, c, z);
}





/* 2F1: Orthogonal polynomials */


void Lib_FReal_Arb_ChebyshevT(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_FReal_Arb_ChebyshevU(double* res, const double* x, const double* y)
{
    FReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_FReal_Arb_GegenbauerC(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_FReal_Arb_LegendreP(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_FReal_Arb_LegendrePv(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_FReal_Arb_LegendreQ(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_FReal_Arb_LegendreQv(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_qv_, res, a, b, z);
}


void Lib_FReal_Arb_JacobiP(double* res, const double* a, const double* b, const double* c, const double* z)
{
    FReal_Arb_Realfunc4_Prec(arb_hypgeom_jacobi_p, res, a, b, c, z);
}





/* 2F1: Incomplete Beta Function */


void Lib_FReal_Arb_BetaLower(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_, res, a, b, z);
}


void Lib_FReal_Arb_Ibeta(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_ibeta, res, a, b, z);
}


void Lib_FReal_Arb_Ibetac(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_ibetac, res, a, b, z);
}


void Lib_FReal_Arb_IbetaPrime(double* res, const double* a, const double* b, const double* z)
{
    FReal_Arb_Realfunc3_Prec(arb_ibeta_derivative, res, a, b, z);
}





/* Hypergeometric Function 1F2, overview */


void Lib_FReal_Arb_Hypgeom1F2(double* res, const double* a, const double* b, const double* c, const double* z)
{
    FReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2_, res, a, b, c, z);
}


void Lib_FReal_Arb_Hypgeom1F2r(double* res, const double* a, const double* b, const double* c, const double* z)
{
    FReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2r_, res, a, b, c, z);
}









////////////////////////////////////////////////////////
////// Acb functions
////////////////////////////////////////////////////////






/* Roots and quadratic, cubic, and quartic equations */


void Lib_FCplx_Acb_UnitRoot_ui(FCplxPtr res, const int32_t n)
{
    FCplx_Acb_Cplxfunc0Int32_Prec(acb_unit_root_, res, n);
}


void Lib_FCplx_Acb_Sqrt(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sqrt, res, x);
}


void Lib_FCplx_Acb_Rsqrt(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_rsqrt, res, x);
}


void Lib_FCplx_Acb_Cbrt(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_cbrt, res, x);
}


void Lib_FCplx_Acb_Sqrt1pm1(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sqrt1pm1, res, x);
}


void Lib_FCplx_Acb_Root_ui(FCplxPtr res, const FCplxPtr x, const int32_t n)
{
    FCplx_Acb_Cplxfunc1Int32_Prec(acb_root_ui_, res, x, n);
}






/* Exponential and related functions */


void Lib_FCplx_Acb_Exp(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_exp, res, x);
}


void Lib_FCplx_Acb_Expj(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_expj_, res, x);
}


void Lib_FCplx_Acb_Expjpi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_exp_pi_i, res, x);
}


void Lib_FCplx_Acb_Expm1(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_expm1, res, x);
}


void Lib_FCplx_Acb_Exp10(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_exp10_, res, x);
}


void Lib_FCplx_Acb_Exp2(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_exp2_, res, x);
}


void Lib_FCplx_Acb_Exp10m1(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_exp10m1_, res, x);
}


void Lib_FCplx_Acb_Exp2m1(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_exp2m1_, res, x);
}


void Lib_FCplx_Acb_ExpRel(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_exprel_, res, x);
}






/* Logarithms and related functions */



void Lib_FCplx_Acb_Log(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_log, res, x);
}


void Lib_FCplx_Acb_Logbase(FCplxPtr res, const FCplxPtr x, const FCplxPtr b)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_logbase_, res, x, b);
}


void Lib_FCplx_Acb_Log1p(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_log1p, res, x);
}


void Lib_FCplx_Acb_Log10(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_log10_, res, x);
}


void Lib_FCplx_Acb_Log2(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_log2_, res, x);
}


void Lib_FCplx_Acb_Log10p1(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_log10p1_, res, x);
}



void Lib_FCplx_Acb_Log2p1(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_log2p1_, res, x);
}




void Lib_FCplx_Acb_LambertW_ui(FCplxPtr res, const FCplxPtr x, const int32_t n)
{
    FCplx_Acb_Cplxfunc1Int32_Prec(acb_lambertw_ui_, res, x, n);
}







/* Power functions */


void Lib_FCplx_Acb_Square(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sqr, res, x);
}


void Lib_FCplx_Acb_Cube(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_cube, res, x);
}


void Lib_FCplx_Acb_Pow_si(FCplxPtr res, const FCplxPtr x, const int32_t n)
{
    FCplx_Acb_Cplxfunc1Int32_Prec(acb_pow_si_, res, x, n);
}



void Lib_FCplx_Acb_Hypot(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypot_, res, x, y);
}


void Lib_FCplx_Acb_Pow(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
}


void Lib_FCplx_Acb_Powm1(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_powm1_, res, x, y);
}


void Lib_FCplx_Acb_Pow1p(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_pow1p_, res, x, y);
}


void Lib_FCplx_Acb_Pow1pm1(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_pow1pm1_, res, x, y);
}







/* Trigonometric and related functions */



void Lib_FCplx_Acb_Sin(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sin, res, x);
}


void Lib_FCplx_Acb_Cos(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_cos, res, x);
}


void Lib_FCplx_Acb_Tan(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_tan, res, x);
}



void Lib_FCplx_Acb_Csc(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_csc, res, x);
}


void Lib_FCplx_Acb_Sec(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sec, res, x);
}


void Lib_FCplx_Acb_Cot(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_cot, res, x);
}





/* Hyperbolic functions */


void Lib_FCplx_Acb_Sinh(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sinh, res, x);
}


void Lib_FCplx_Acb_Cosh(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_cosh, res, x);
}


void Lib_FCplx_Acb_Tanh(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_tanh, res, x);
}



void Lib_FCplx_Acb_Csch(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_csch, res, x);
}


void Lib_FCplx_Acb_Sech(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sech, res, x);
}


void Lib_FCplx_Acb_Coth(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_coth, res, x);
}



void Lib_FCplx_Acb_Sinc(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sinc, res, x);
}


void Lib_FCplx_Acb_SincPi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sinc_pi, res, x);
}



void Lib_FCplx_Acb_SinPi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sin_pi, res, x);
}


void Lib_FCplx_Acb_CosPi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_cos_pi, res, x);
}


void Lib_FCplx_Acb_TanPi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_tan_pi, res, x);
}


void Lib_FCplx_Acb_CotPi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_cot_pi, res, x);
}


void Lib_FCplx_Acb_CscPi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_csc_pi, res, x);
}


void Lib_FCplx_Acb_SecPi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_sec_pi_, res, x);
}






/* Inverse trigonometric functions */


void Lib_FCplx_Acb_Asin(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_asin, res, x);
}


void Lib_FCplx_Acb_Acos(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_acos, res, x);
}


void Lib_FCplx_Acb_Atan(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_atan, res, x);
}



void Lib_FCplx_Acb_Acsc(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_acsc, res, x);
}


void Lib_FCplx_Acb_Asec(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_asec, res, x);
}


void Lib_FCplx_Acb_Acot(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_FCplx_Acb_Asinh(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_asinh, res, x);
}


void Lib_FCplx_Acb_Acosh(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_acosh, res, x);
}


void Lib_FCplx_Acb_Atanh(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_atanh, res, x);
}



void Lib_FCplx_Acb_Acsch(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_acsch, res, x);
}


void Lib_FCplx_Acb_Asech(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_asech, res, x);
}


void Lib_FCplx_Acb_Acoth(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_acoth, res, x);
}









/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_FCplx_Acb_MEllipticK(FCplxPtr res, const FCplxPtr m)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k, res, m);
}


void Lib_FCplx_Acb_MEllipticE(FCplxPtr res, const FCplxPtr m)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e, res, m);
}


void Lib_FCplx_Acb_MEllipticPi(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi, res, phi, m);

}


void Lib_FCplx_Acb_MEllipticF(FCplxPtr res, const FCplxPtr phi, const FCplxPtr m)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_, res, phi, m);

}


void Lib_FCplx_Acb_MEllipticEInc(FCplxPtr res, const FCplxPtr n, const FCplxPtr m)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_, res, n, m);
}


void Lib_FCplx_Acb_MEllipticPiInc(FCplxPtr res, const FCplxPtr n, const FCplxPtr phi, const FCplxPtr m)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_, res, n, phi, m);
}







/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_FCplx_Acb_EllipticK(FCplxPtr res, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k_k_, res, k);
}


void Lib_FCplx_Acb_EllipticE(FCplxPtr res, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e_k_, res, k);
}


void Lib_FCplx_Acb_EllipticPi(FCplxPtr res, const FCplxPtr phi, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi_k_, res, phi, k);

}


void Lib_FCplx_Acb_EllipticF(FCplxPtr res, const FCplxPtr phi, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_k_, res, phi, k);

}


void Lib_FCplx_Acb_EllipticEInc(FCplxPtr res, const FCplxPtr n, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_k_, res, n, k);
}


void Lib_FCplx_Acb_EllipticPiInc(FCplxPtr res, const FCplxPtr n, const FCplxPtr phi, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_k_, res, n, phi, k);
}



void Lib_FCplx_Acb_Agm(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */

void Lib_FCplx_Acb_Elliptic_RC(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_rc_, res, x, y);
}



void Lib_FCplx_Acb_Elliptic_RF(FCplxPtr res, const FCplxPtr x, const FCplxPtr y, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rf_, res, x, y, z);
}


void Lib_FCplx_Acb_Elliptic_RG(FCplxPtr res, const FCplxPtr x, const FCplxPtr y, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rg_, res, x, y, z);
}


void Lib_FCplx_Acb_Elliptic_RD(FCplxPtr res, const FCplxPtr x, const FCplxPtr y, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rd_, res, x, y, z);
}


void Lib_FCplx_Acb_Elliptic_RJ(FCplxPtr res, const FCplxPtr x, const FCplxPtr y, const FCplxPtr z, const FCplxPtr w)
{
    FCplx_Acb_Cplxfunc4_Prec(acb_elliptic_rj_, res, x, y, z, w);
}






/* Jacobi theta functions */


void Lib_FCplx_Acb_Theta1Q(FCplxPtr res, const FCplxPtr z, const FCplxPtr q)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_theta1q, res, z, q);
}


void Lib_FCplx_Acb_Theta2Q(FCplxPtr res, const FCplxPtr z, const FCplxPtr q)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_theta2q, res, z, q);
}


void Lib_FCplx_Acb_Theta3Q(FCplxPtr res, const FCplxPtr z, const FCplxPtr q)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_theta3q, res, z, q);
}


void Lib_FCplx_Acb_Theta4Q(FCplxPtr res, const FCplxPtr z, const FCplxPtr q)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_theta4q, res, z, q);
}



void Lib_FCplx_Acb_Theta1Tau(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_theta1, res, z, tau);
}


void Lib_FCplx_Acb_Theta2Tau(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_theta2, res, z, tau);
}


void Lib_FCplx_Acb_Theta3Tau(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_theta3, res, z, tau);
}


void Lib_FCplx_Acb_Theta4Tau(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_theta4, res, z, tau);
}







/* Jacobi elliptic functions */


void Lib_FCplx_Acb_QfromK(FCplxPtr res, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_qfromk, res, k);
}


void Lib_FCplx_Acb_TfromUQ(FCplxPtr res, const FCplxPtr u, const FCplxPtr q)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_tfrom_u_q, res, u, q);
}


void Lib_FCplx_Acb_SnTQ(FCplxPtr res, const FCplxPtr t, const FCplxPtr q)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_sn_t_q, res, t, q);
}


void Lib_FCplx_Acb_CnTQ(FCplxPtr res, const FCplxPtr t, const FCplxPtr q)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_cn_t_q, res, t, q);
}


void Lib_FCplx_Acb_DnTQ(FCplxPtr res, const FCplxPtr t, const FCplxPtr q)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_dn_t_q, res, t, q);
}


void Lib_FCplx_Acb_JacobiSN(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sn, res, u, k);
}


void Lib_FCplx_Acb_JacobiCN(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cn, res, u, k);
}


void Lib_FCplx_Acb_JacobiDN(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dn, res, u, k);
}





void Lib_FCplx_Acb_JacobiNS(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ns, res, u, k);
}


void Lib_FCplx_Acb_JacobiNC(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nc, res, u, k);
}


void Lib_FCplx_Acb_JacobiND(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nd, res, u, k);
}




void Lib_FCplx_Acb_JacobiSC(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sc, res, u, k);
}


void Lib_FCplx_Acb_JacobiSD(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sd, res, u, k);
}




void Lib_FCplx_Acb_JacobiDC(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dc, res, u, k);
}


void Lib_FCplx_Acb_JacobiDS(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ds, res, u, k);
}




void Lib_FCplx_Acb_JacobiCS(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cs, res, u, k);
}


void Lib_FCplx_Acb_JacobiCD(FCplxPtr res, const FCplxPtr u, const FCplxPtr k)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cd, res, u, k);
}







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


void Lib_FCplx_Acb_WeierstrassP(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_p, res, z, tau);
}


void Lib_FCplx_Acb_WeierstrassPInv(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_inv_p, res, z, tau);
}


void Lib_FCplx_Acb_WeierstrassPZeta(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_zeta, res, z, tau);
}


void Lib_FCplx_Acb_WeierstrassPSigma(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_elliptic_sigma, res, z, tau);
}



void Lib_FCplx_Acb_WeierstrassPPrime(FCplxPtr res, const FCplxPtr z, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_wp_prime, res, z, tau);
}



void Lib_FCplx_Acb_EllipticInvariantG2(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g2, res, tau);
}


void Lib_FCplx_Acb_EllipticInvariantG3(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g3, res, tau);
}


void Lib_FCplx_Acb_EllipticRootE1(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e1, res, tau);
}


void Lib_FCplx_Acb_EllipticRootE2(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e2, res, tau);
}


void Lib_FCplx_Acb_EllipticRootE3(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e3, res, tau);
}



void Lib_FCplx_Acb_DedekindEta(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_modular_eta, res, tau);
}


void Lib_FCplx_Acb_KleinJ(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_modular_j, res, tau);
}


void Lib_FCplx_Acb_ModularLambda(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_modular_lambda, res, tau);
}


void Lib_FCplx_Acb_ModularDelta(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_modular_delta, res, tau);
}




/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */






/* Lerch’s transcendent: overview */


void Lib_FCplx_Acb_LerchPhi(FCplxPtr res, const FCplxPtr z, const FCplxPtr s, const FCplxPtr a)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_dirichlet_lerch_phi, res, z, s, a);
}


void Lib_FCplx_Acb_LerchZeta(FCplxPtr res, const FCplxPtr lambda1, const FCplxPtr alpha, const FCplxPtr s)
{
    FCplx_Acb_Cplxfunc3_Prec(_acb_lerch_zeta, res, lambda1, alpha, s);
}


/* Polygamma functions */


void Lib_FCplx_Acb_Polygamma(FCplxPtr res, const FCplxPtr s, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_polygamma, res, s, z);
}


void Lib_FCplx_Acb_Trigamma(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_trigamma, res, x);
}


void Lib_FCplx_Acb_Digamma(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_FCplx_Acb_Polylog(FCplxPtr res, const FCplxPtr s, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_polylog, res, s, z);
}


void Lib_FCplx_Acb_Trilog(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_trilog, res, x);
}


void Lib_FCplx_Acb_Dilog(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_dilog, res, x);
}



void Lib_FCplx_Acb_ClausenSin(FCplxPtr res, const FCplxPtr s, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_clausen_sin, res, s, z);
}


void Lib_FCplx_Acb_ClausenCos(FCplxPtr res, const FCplxPtr s, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_clausen_cos, res, s, z);
}


void Lib_FCplx_Acb_Clausen2(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_clausen2, res, x);
}


void Lib_FCplx_Acb_BoseEinstein(FCplxPtr res, const FCplxPtr s, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_bose_einstein, res, s, z);
}


void Lib_FCplx_Acb_FermiDirac(FCplxPtr res, const FCplxPtr s, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_fermi_dirac, res, s, z);
}


void Lib_FCplx_Acb_LegendreChi(FCplxPtr res, const FCplxPtr s, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_legendre_chi, res, s, z);
}


void Lib_FCplx_Acb_InverseTanIntegral(FCplxPtr res, const FCplxPtr s, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_ti, res, s, z);
}





/* Hurwitz zeta function and related functions */




void Lib_FCplx_Acb_HurwitzZeta(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hurwitz_zeta, res, x, y);
}


void Lib_FCplx_Acb_Stieltjes_ui(FCplxPtr res, const FCplxPtr x, const int32_t n)
{
    FCplx_Acb_Cplxfunc1Int32_Prec(acb_stieltjes_ui_, res, x, n);
}


void Lib_FCplx_Acb_BernoulliPoly_ui(FCplxPtr res, const FCplxPtr x, const int32_t n)
{
    FCplx_Acb_Cplxfunc1Int32_Prec(acb_bernoulli_poly_ui_, res, x, n);
}



void Lib_FCplx_Acb_Harmonic(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_harmonic, res, x);
}


void Lib_FCplx_Acb_Harmonic2(FCplxPtr res, const FCplxPtr z, const FCplxPtr r)
{
    FCplx_Acb_Cplxfunc2_Prec(_acb_harmonic2, res, z, r);
}


void Lib_FCplx_Acb_EulerPoly_ui(FCplxPtr res, const FCplxPtr x, const int32_t n)
{
    FCplx_Acb_Cplxfunc1Int32_Prec(acb_euler_poly_ui_, res, x, n);
}


void Lib_FCplx_Acb_Hyperfactorial(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_hyperfac, res, x);
}


void Lib_FCplx_Acb_Superfactorial(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_superfac, res, x);
}


void Lib_FCplx_Acb_BarnesG(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_barnes_g, res, x);
}


void Lib_FCplx_Acb_LogBarnesG(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */


void Lib_FCplx_Acb_Zeta(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_zeta, res, x);
}


void Lib_FCplx_Acb_Zetam1(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_zetam1, res, x);
}


void Lib_FCplx_Acb_ZetaZero_ui(FCplxPtr res, const int32_t n)
{
    FCplx_Acb_Cplxfunc0Int32_Prec(acb_dirichlet_zeta_zero_ui_, res, n);
}


void Lib_FCplx_Acb_DirichletXi(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_xi, res, tau);
}


void Lib_FCplx_Acb_DirichletEta(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_eta, res, tau);
}


void Lib_FCplx_Acb_DirichletEtam1(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_etam1, res, x);
}


void Lib_FCplx_Acb_DirichletBeta(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_beta, res, x);
}


void Lib_FCplx_Acb_DirichletLambda(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_lambda, res, x);
}



/* Riemann-Siegel Z-function */
void Lib_FCplx_Acb_HardyZ(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_z_, res, tau);
}

/* rstheta(z) in amath */
void Lib_FCplx_Acb_HardyTheta(FCplxPtr res, const FCplxPtr tau)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_theta_, res, tau);
}









/* Additional numbertheoretic functions */




/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_FCplx_Acb_Hypgeom0F1(FCplxPtr res, const FCplxPtr a, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_, res, a, x);
}


void Lib_FCplx_Acb_Hypgeom0F1r(FCplxPtr res, const FCplxPtr a, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */



void Lib_FCplx_Acb_BesselJ(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_j, res, x, y);
}


void Lib_FCplx_Acb_BesselY(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_y, res, x, y);
}


void Lib_FCplx_Acb_BesselI(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i, res, x, y);
}


void Lib_FCplx_Acb_BesselK(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k, res, x, y);
}


void Lib_FCplx_Acb_BesselIScaled(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_FCplx_Acb_BesselKScaled(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */




/* Airy functions  */


void Lib_FCplx_Acb_AiryAi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_airy_ai, res, x);
}


void Lib_FCplx_Acb_AiryAiPrime(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_airy_ai_prime, res, x);
}


void Lib_FCplx_Acb_AiryBi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_airy_bi, res, x);
}


void Lib_FCplx_Acb_AiryBiPrime(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_airy_bi_prime, res, x);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */



void Lib_FCplx_Acb_Hypgeom1F1(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
}


void Lib_FCplx_Acb_Hypgeom1F1r(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_FCplx_Acb_HypgeomU(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_u, res, a, b, z);
}





/* Gamma function and related functions */


void Lib_FCplx_Acb_Gamma(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_gamma, res, x);
}


void Lib_FCplx_Acb_Rgamma(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_rgamma, res, x);
}


void Lib_FCplx_Acb_Lgamma(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_lgamma, res, x);
}


void Lib_FCplx_Acb_RisingFactorial(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_rising, res, x, y);
}


void Lib_FCplx_Acb_Beta(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_beta_, res, x, y);
}






/* Incomplete gamma functions */


void Lib_FCplx_Acb_GammaUpper(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_gamma_upper_, res, x, y);
}



void Lib_FCplx_Acb_GammaLower(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_gamma_lower_, res, x, y);
}



void Lib_FCplx_Acb_GammaPPrime(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_gamma_p_derivative, res, x, y);
}


void Lib_FCplx_Acb_GammaP(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_gamma_p, res, x, y);
}


void Lib_FCplx_Acb_GammaQ(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_gamma_q, res, x, y);
}







/* Error function and related functions */


void Lib_FCplx_Acb_Erf(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erf, res, x);
}


void Lib_FCplx_Acb_Erfc(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfc, res, x);
}


void Lib_FCplx_Acb_Erfi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfi, res, x);
}



void Lib_FCplx_Acb_FresnelC(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_fresnelc, res, x);
}


void Lib_FCplx_Acb_FresnelS(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_fresnels, res, x);
}


void Lib_FCplx_Acb_Ndens(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_ndens, res, x);
}


void Lib_FCplx_Acb_Ndis(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_ndis, res, x);
}






/* Exponential integrals and related functions */


void Lib_FCplx_Acb_ExpIntegralE(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_expint, res, x, y);
}



void Lib_FCplx_Acb_ExpIntegralEi(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ei, res, x);
}


void Lib_FCplx_Acb_SinIntegral(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_si, res, x);
}


void Lib_FCplx_Acb_CosIntegral(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ci, res, x);
}


void Lib_FCplx_Acb_SinhIntegral(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_shi, res, x);
}


void Lib_FCplx_Acb_CoshIntegral(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_chi, res, x);
}


void Lib_FCplx_Acb_LogIntegral(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_, res, x);
}


void Lib_FCplx_Acb_LogIntegralOffset(FCplxPtr res, const FCplxPtr x)
{
    FCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_FCplx_Acb_HermiteH(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_hermite_h, res, x, y);
}


void Lib_FCplx_Acb_LaguerreL(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */



void Lib_FCplx_Acb_CoulombF(FCplxPtr res, const FCplxPtr l, const FCplxPtr eta, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_FCplx_Acb_CoulombG(FCplxPtr res, const FCplxPtr l, const FCplxPtr eta, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_g, res, l, eta, z);
}


void Lib_FCplx_Acb_CoulombHpos(FCplxPtr res, const FCplxPtr l, const FCplxPtr eta, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hpos, res, l, eta, z);
}


void Lib_FCplx_Acb_CoulombHneg(FCplxPtr res, const FCplxPtr l, const FCplxPtr eta, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hneg, res, l, eta, z);
}







/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_FCplx_Acb_Hypgeom2F1(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr c, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_FCplx_Acb_Hypgeom2F1r(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr c, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1r_, res, a, b, c, z);
}



/* 2F1: Orthogonal polynomials */


void Lib_FCplx_Acb_ChebyshevT(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_FCplx_Acb_ChebyshevU(FCplxPtr res, const FCplxPtr x, const FCplxPtr y)
{
    FCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_FCplx_Acb_GegenbauerC(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_FCplx_Acb_LegendreP(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_FCplx_Acb_LegendrePv(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_FCplx_Acb_LegendreQ(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_FCplx_Acb_LegendreQv(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_qv_, res, a, b, z);
}



void Lib_FCplx_Acb_JacobiP(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr c, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_jacobi_p, res, a, b, c, z);
}


void Lib_FCplx_Acb_SphericalY(FCplxPtr res, const FCplxPtr n, const FCplxPtr m, const FCplxPtr theta, const FCplxPtr phi)
{
    FCplx_Acb_Cplxfunc4_Prec(_acb_hypgeom_spherical_y, res, n, m, theta, phi);
}





/* 2F1: Incomplete Beta Function */


void Lib_FCplx_Acb_BetaLower(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_beta_lower_, res, a, b, z);
}




void Lib_FCplx_Acb_Ibeta(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_ibeta, res, a, b, z);
}


void Lib_FCplx_Acb_Ibetac(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_ibetac, res, a, b, z);
}



void Lib_FCplx_Acb_IbetaPrime(FCplxPtr res, const FCplxPtr a, const FCplxPtr b, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc3_Prec(acb_ibeta_derivative, res, a, b, z);
}



/* Hypergeometric Function 1F2, overview */



void Lib_FCplx_Acb_Hypgeom1F2(FCplxPtr res, const FCplxPtr a1, const FCplxPtr b1, const FCplxPtr b2, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_FCplx_Acb_Hypgeom1F2r(FCplxPtr res, const FCplxPtr a1, const FCplxPtr b1, const FCplxPtr b2, const FCplxPtr z)
{
    FCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2r_, res, a1, b1, b2, z);
}



//
//
//
////*********************** Boost Numerical Calculus, double precision **********************************
//
//
//
//
//
//void Lib_FReal_BracketRoot(double* res1, double* res2, int* iter, FRealFuncPtr f1, double* guess, double* factor, bool is_rising, int get_digits, unsigned int maxit)
//{
//    LibFReal_BracketRoot(res1, res2, iter, f1, guess, factor, is_rising, get_digits, maxit);
//}
//
//
//
//void Lib_FReal_NewtonRaphson(double* res,  int* iter, FRealFuncPtr f1, FRealFuncPtr f2, double* guess, double* xmin, double* xmax, int get_digits, unsigned int maxit)
//{
//    LibFReal_NewtonRaphson(res, iter, f1, f2, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_FReal_Halley(double* res,  int* iter, FRealFuncPtr f1, FRealFuncPtr f2, FRealFuncPtr f3, double* guess, double* xmin, double* xmax, int get_digits, unsigned int maxit)
//{
//    LibFReal_Halley(res, iter, f1, f2, f3, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_FReal_Schroder(double* res,  int* iter, FRealFuncPtr f1, FRealFuncPtr f2, FRealFuncPtr f3, double* guess, double* xmin, double* xmax, int get_digits, unsigned int maxit)
//{
//    LibFReal_Schroder(res, iter, f1, f2, f3, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_FReal_Brent_Minimum(double* res, double* resFx, int* iter, FRealFuncPtr f1, double* bracket_min, double* bracket_max, int bits, unsigned int maxit)
//{
//    LibFReal_Brent_Minimum(res, resFx, iter, f1, bracket_min, bracket_max, bits, maxit);
//}
//
//
//
//
//void Lib_FReal_Trapezoidal(double* res1, double* res2, double* res3, FRealFuncPtr f1, double* a, double* b)
//{
//    LibFReal_Trapezoidal(res1, res2, res3, f1, a, b);
//}
//
//
//// 7, 15, 20, 25 and 30
//
//void Lib_FReal_GaussLegendre(double* res1, double* res3, FRealFuncPtr f1, double* a, double* b)
//{
//    LibFReal_GaussLegendre(res1, res3, f1, a, b);
//}
//
//
//
////15, 31, 41, 51 and 61
//
//void Lib_FReal_GaussKronrod(double* res1, double* res2, double* res3, FRealFuncPtr f1, double* a, double* b)
//{
//    LibFReal_GaussKronrod(res1, res2, res3, f1, a, b);
//}
//
//
//
//void Lib_FReal_TanhSinh(double* res1, double* res2, double* res3, int* levels_, FRealFuncPtr f1, double* a, double* b)
//{
//    LibFReal_TanhSinh(res1, res2, res3, levels_, f1, a, b);
//}
//
//
//
//void Lib_FReal_SinhSinh(double* res1, double* res2, double* res3, int* levels_, FRealFuncPtr f1)
//{
//    LibFReal_SinhSinh(res1, res2, res3, levels_, f1);
//}
//
//
//
//void Lib_FReal_ExpSinh(double* res1, double* res2, double* res3, int* levels_, FRealFuncPtr f1)
//{
//    LibFReal_ExpSinh(res1, res2, res3, levels_, f1);
//}
//
//
//
//void Lib_FReal_Ooura_Cos(double* res1, double* res2, FRealFuncPtr f1)
//{
//    LibFReal_Ooura_Cos(res1, res2, f1);
//}
//
//
//
//void Lib_FReal_Ooura_Sin(double* res1, double* res2, FRealFuncPtr f1)
//{
//    LibFReal_Ooura_Sin(res1, res2, f1);
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
//
////*********************** Boost Odeint **********************************
//
//
//void Lib_FReal_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt)
//{
//	LibFReal_Const_RungeKutta4((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_FReal_Const_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt)
//{
//	LibFReal_Const_RungeKuttaCashKarp54((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_FReal_Const_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt)
//{
//	LibFReal_Const_RungeKuttaDopri5((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_FReal_Const_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt)
//{
//	LibFReal_Const_RungeKuttaFehlberg78((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_FReal_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt)
//{
//	LibFReal_Const_AdamsBashforthMoulton((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//
//void Lib_FReal_Adaptive_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel)
//{
//	LibFReal_Adaptive_RungeKuttaDopri5((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_FReal_Adaptive_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel)
//{
//	LibFReal_Adaptive_RungeKuttaCashKarp54((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_FReal_Adaptive_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel)
//{
//	LibFReal_Adaptive_RungeKuttaFehlberg78((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_FReal_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel)
//{
//	LibFReal_Adaptive_BulirschStoer((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_FReal_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel)
//{
//	LibFReal_DenseOutput_Dopri5((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_FReal_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, double* start_time, double* end_time, double* dt, double* eps_abs, double* eps_rel)
//{
//	LibFReal_DenseOutput_BulirschStoer((FAnyFuncPtr3)f1, (FAnyFuncPtr2)f2, (FStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
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
