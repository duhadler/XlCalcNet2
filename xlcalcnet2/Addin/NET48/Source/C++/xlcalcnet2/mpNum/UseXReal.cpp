
#include "mpNumC_Main.h"
//#include "BoostXReal.h"

#include "stdint.h"
#include <complex>
#include <vector>
#include <iostream>
#include <limits>
#include "float.h"
#include "Helperfunctions.h"

using namespace std;
using namespace std::numbers;





/** ********************** Real Basic Functions, extended precision ******************************** **/


long double* Lib_XReal_Init_Func()
{
	long double* x = NULL;
	x = (long double*)malloc(sizeof(long double));
	*x = -1.0L;
	return x;
}

void Lib_XReal_Clear(long double* x)
{
	free(x);
}



/* Input and output  */


void Lib_XReal_Set(long double* res, const long double* x)
{
	*res = (*x);
}

void Lib_XReal_Set_Fmpq(long double* res, const FmpqPtr x)
{
    mpfr_t temp; mpfr_init(temp);
	fmpq_get_mpfr (temp, (fmpq*)x, MPFR_RNDN);
	*res = mpfr_get_ld(temp, MPFR_RNDN);
    mpfr_clear(temp);
}

void Lib_XReal_Set_Arb(long double* res, const ArbPtr x)
{
    mpfr_t temp; mpfr_init(temp);
	arf_get_mpfr(temp, arb_midref((arb_ptr)x), MPFR_RNDN);
	*res = mpfr_get_ld(temp, MPFR_RNDN);
	mpfr_clear(temp);
}

void Lib_XReal_Set_Arf(long double* res, const ArfPtr x)
{
    mpfr_t temp; mpfr_init(temp);
	arf_get_mpfr(temp, (arf_ptr)x, MPFR_RNDN);
	*res = mpfr_get_ld(temp, MPFR_RNDN);
	mpfr_clear(temp);
}

//void Lib_XReal_Set_Mpfi(long double* res, const MpfiPtr x)
//{
//    mpfr_t temp; mpfr_init(temp);
//    mpfi_mid ((mpfr_ptr)temp, (mpfi_ptr)x);
//    *res = mpfr_get_ld(temp, MPFR_RNDN);
//	mpfr_clear(temp);
//}

void Lib_XReal_Set_Mpfr(long double* res, const MpfrPtr x)
{
	*res = mpfr_get_ld((mpfr_ptr)x, MPFR_RNDN);
}

//void Lib_XReal_Set_Mpd(long double* res, const MpdPtr x)
//{
//	char * src = mpd_to_sci((mpd_t *)x, 1);
//    *res = std::strtold(src, NULL);
//	free(src);
//}




void Lib_XCplx_Set_Acb(XCplxPtr res, const AcbPtr x)
{
	slong wp = 96;  // 64 * 1.5
	mpc_t out1;
	mpc_init2(out1, wp);

    acb_get_mpc(out1, (acb_ptr)x);
    (*(std::complex<long double>*) res)
        = std::complex<long double>(mpfr_get_ld(out1->re, MPFR_RNDN), mpfr_get_ld(out1->im, MPFR_RNDN));

    mpc_clear(out1);
}




//
//
//void XCplx_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, XCplxPtr res, const int32_t in1)
//{
//	//printf("using XCplx_Acb_Cplxfunc1_Prec:  ");
//	slong wp = 96;  // 64 * 1.5
//
//	mpc_t out1;
//	mpc_init2(out1, wp);
//
//    acb_t out1_acb;
//    acb_init(out1_acb);
//
//	//f1(out1_acb, in1_acb, wp);
//	f0Int32((acb_ptr)out1_acb, in1, wp);
//
//    acb_get_mpc(out1, out1_acb);
//    (*(std::complex<long double>*) res)
//        = std::complex<long double>(mpfr_get_ld(out1->re, MPFR_RNDN), mpfr_get_ld(out1->im, MPFR_RNDN));
//
//    acb_clear(out1_acb);
//    mpc_clear(out1);
//}
//
//



//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////



void mpfc_set_extc(mpc_t out1, XCplxPtr in1)
{
	mpfr_set_ld (out1->re, (*(std::complex<long double>*) in1).real(), MPFR_RNDN);
	mpfr_set_ld (out1->im, (*(std::complex<long double>*) in1).imag(), MPFR_RNDN);
}



void XReal_Arb_Realfunc0Int32_Prec(ArbFuncPtr0Int32 f0Int32, long double* res, int32_t in1)
{
	//printf("using XReal_Arb_Realfunc1_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpfr_t out1;
	mpfr_init2(out1, wp);
    arb_t out1_arb;
    arb_init(out1_arb);

	//f1(out1_arb, in1_arb, wp);
	f0Int32((arb_ptr)out1_arb, in1, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *res = mpfr_get_ld((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb);
    mpfr_clear(out1);
}





void XReal_Arb_Realfunc1_Prec(ArbFuncPtr1 f1, long double* res, const long double* x1)
{
	//printf("using XReal_Arb_Realfunc1_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpfr_t out1, in1;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp);
    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);
	mpfr_set_ld((mpfr_ptr)in1, *x1, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);

	f1(out1_arb, in1_arb, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *res = mpfr_get_ld((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb);
    mpfr_clear(out1); mpfr_clear(in1);
}





void XReal_Arb_Realfunc1Int32_Prec(ArbFuncPtr1Int32 f1Int32, long double* res, const long double* x1, int32_t in2)
{
	//printf("using XReal_Arb_Realfunc1_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpfr_t out1, in1;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp);
    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);
	mpfr_set_ld((mpfr_ptr)in1, *x1, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);

	//1(out1_arb, in1_arb, wp);
	f1Int32(out1_arb, in1_arb, in2, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *res = mpfr_get_ld((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb);
    mpfr_clear(out1); mpfr_clear(in1);
}






void XReal_Arb_Realfunc2_Prec(ArbFuncPtr2 f2, long double* res, const long double* x1, const long double* x2)
{
	//printf("using XReal_Arb_Realfunc2_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpfr_t out1, in1, in2;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp); mpfr_init2(in2, wp);
    arb_t out1_arb, in1_arb, in2_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb);
	mpfr_set_ld((mpfr_ptr)in1, *x1, MPFR_RNDN);
	mpfr_set_ld((mpfr_ptr)in2, *x2, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);
    arf_set_mpfr(arb_midref(in2_arb), in2);

	f2(out1_arb, in1_arb, in2_arb, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *res = mpfr_get_ld((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb);
    mpfr_clear(out1); mpfr_clear(in1); mpfr_clear(in2);
}



void XReal_Arb_Realfunc3_Prec(ArbFuncPtr3 f3, long double* res, const long double* x1, const long double* x2, const long double* x3)
{
	//printf("using XReal_Arb_Realfunc3_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpfr_t out1, in1, in2, in3;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp); mpfr_init2(in2, wp); mpfr_init2(in3, wp);
    arb_t out1_arb, in1_arb, in2_arb, in3_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb);
	mpfr_set_ld((mpfr_ptr)in1, *x1, MPFR_RNDN);
	mpfr_set_ld((mpfr_ptr)in2, *x2, MPFR_RNDN);
	mpfr_set_ld((mpfr_ptr)in3, *x3, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);
    arf_set_mpfr(arb_midref(in2_arb), in2);
    arf_set_mpfr(arb_midref(in3_arb), in3);

	f3(out1_arb, in1_arb, in2_arb, in3_arb, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *res = mpfr_get_ld((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb);
    mpfr_clear(out1); mpfr_clear(in1); mpfr_clear(in2);	mpfr_clear(in3);
}



void XReal_Arb_Realfunc4_Prec(ArbFuncPtr4 f4, long double* res, const long double* x1, const long double* x2, const long double* x3, const long double* x4)
{
	//printf("using XReal_Arb_Realfunc4_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpfr_t out1, in1, in2, in3, in4;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp); mpfr_init2(in2, wp); mpfr_init2(in3, wp);; mpfr_init2(in4, wp);
    arb_t out1_arb, in1_arb, in2_arb, in3_arb, in4_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb); arb_init(in4_arb);
	mpfr_set_ld((mpfr_ptr)in1, *x1, MPFR_RNDN);
	mpfr_set_ld((mpfr_ptr)in2, *x2, MPFR_RNDN);
	mpfr_set_ld((mpfr_ptr)in3, *x3, MPFR_RNDN);
	mpfr_set_ld((mpfr_ptr)in4, *x4, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);
    arf_set_mpfr(arb_midref(in2_arb), in2);
    arf_set_mpfr(arb_midref(in3_arb), in3);
    arf_set_mpfr(arb_midref(in4_arb), in4);

	f4(out1_arb, in1_arb, in2_arb, in3_arb, in4_arb, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *res = mpfr_get_ld((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb); arb_clear(in4_arb);
    mpfr_clear(out1); mpfr_clear(in1); mpfr_clear(in2);	mpfr_clear(in3);	mpfr_clear(in4);
}



void XCplx_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, XCplxPtr res, const int32_t in1)
{
	//printf("using XCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpc_t out1;
	mpc_init2(out1, wp);

    acb_t out1_acb;
    acb_init(out1_acb);

	//f1(out1_acb, in1_acb, wp);
	f0Int32((acb_ptr)out1_acb, in1, wp);

    acb_get_mpc(out1, out1_acb);
    (*(std::complex<long double>*) res)
        = std::complex<long double>(mpfr_get_ld(out1->re, MPFR_RNDN), mpfr_get_ld(out1->im, MPFR_RNDN));

    acb_clear(out1_acb);
    mpc_clear(out1);
}



void XCplx_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, XCplxPtr res, const XCplxPtr x1)
{
	//printf("using XCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpc_t out1, in1;
	mpc_init2(out1, wp); mpc_init2(in1, wp);
	mpfc_set_extc(in1, x1);

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_mpc(in1_acb, in1);

	f1(out1_acb, in1_acb, wp);

    acb_get_mpc(out1, out1_acb);
    (*(std::complex<long double>*) res)
        = std::complex<long double>(mpfr_get_ld(out1->re, MPFR_RNDN), mpfr_get_ld(out1->im, MPFR_RNDN));

    acb_clear(out1_acb); acb_clear(in1_acb);
    mpc_clear(out1); mpc_clear(in1);
}



void XCplx_Acb_Cplxfunc1Int32_Prec(AcbFuncPtr1Int32 f1Int32, XCplxPtr res, const XCplxPtr x1, int32_t in2)
{
	//printf("using XCplx_Acb_Cplxfunc1Int32_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpc_t out1, in1;
	mpc_init2(out1, wp); mpc_init2(in1, wp);
	mpfc_set_extc(in1, x1);

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_mpc(in1_acb, in1);

	//f1(out1_acb, in1_acb, wp);
	f1Int32((acb_ptr)out1_acb, (acb_ptr)in1_acb, in2, wp);

    acb_get_mpc(out1, out1_acb);
    (*(std::complex<long double>*) res)
        = std::complex<long double>(mpfr_get_ld(out1->re, MPFR_RNDN), mpfr_get_ld(out1->im, MPFR_RNDN));

    acb_clear(out1_acb); acb_clear(in1_acb);
    mpc_clear(out1); mpc_clear(in1);
}



void XCplx_Acb_Cplxfunc2_Prec(AcbFuncPtr2 f2, XCplxPtr res, const XCplxPtr x1, const XCplxPtr x2)
{
	//printf("using XCplx_Acb_Cplxfunc2_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpc_t out1, in1, in2;
	mpc_init2(out1, wp); mpc_init2(in1, wp); mpc_init2(in2, wp);
	mpfc_set_extc(in1, x1); mpfc_set_extc(in2, x2);

    acb_t out1_acb, in1_acb, in2_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2);

	f2(out1_acb, in1_acb, in2_acb, wp);

    acb_get_mpc(out1, out1_acb);
    (*(std::complex<long double>*) res)
        = std::complex<long double>(mpfr_get_ld(out1->re, MPFR_RNDN), mpfr_get_ld(out1->im, MPFR_RNDN));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb);
    mpc_clear(out1); mpc_clear(in1); mpc_clear(in2);
}



void XCplx_Acb_Cplxfunc3_Prec(AcbFuncPtr3 f3, XCplxPtr res, const XCplxPtr x1, const XCplxPtr x2, const XCplxPtr x3)
{
	//printf("using XCplx_Acb_Cplxfunc3_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpc_t out1, in1, in2, in3;
	mpc_init2(out1, wp); mpc_init2(in1, wp); mpc_init2(in2, wp); mpc_init2(in3, wp);
	mpfc_set_extc(in1, x1); mpfc_set_extc(in2, x2); mpfc_set_extc(in3, x3);

    acb_t out1_acb, in1_acb, in2_acb, in3_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2); acb_set_mpc(in3_acb, in3);

	f3(out1_acb, in1_acb, in2_acb, in3_acb, wp);

    acb_get_mpc(out1, out1_acb);
    (*(std::complex<long double>*) res)
        = std::complex<long double>(mpfr_get_ld(out1->re, MPFR_RNDN), mpfr_get_ld(out1->im, MPFR_RNDN));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb);
    mpc_clear(out1); mpc_clear(in1); mpc_clear(in2); mpc_clear(in3);
}



void XCplx_Acb_Cplxfunc4_Prec(AcbFuncPtr4 f4, XCplxPtr res, const XCplxPtr x1, const XCplxPtr x2, const XCplxPtr x3, const XCplxPtr x4)
{
	//printf("using XCplx_Acb_Cplxfunc4_Prec:  ");
	slong wp = 96;  // 64 * 1.5

	mpc_t out1, in1, in2, in3, in4;
	mpc_init2(out1, wp); mpc_init2(in1, wp); mpc_init2(in2, wp); mpc_init2(in3, wp); mpc_init2(in4, wp);
	mpfc_set_extc(in1, x1); mpfc_set_extc(in2, x2); mpfc_set_extc(in3, x3); mpfc_set_extc(in4, x4);

    acb_t out1_acb, in1_acb, in2_acb, in3_acb, in4_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb); acb_init(in4_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2); acb_set_mpc(in3_acb, in3); acb_set_mpc(in4_acb, in4);

	f4(out1_acb, in1_acb, in2_acb, in3_acb, in4_acb, wp);

    acb_get_mpc(out1, out1_acb);
    (*(std::complex<long double>*) res)
        = std::complex<long double>(mpfr_get_ld(out1->re, MPFR_RNDN), mpfr_get_ld(out1->im, MPFR_RNDN));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb); acb_clear(in4_acb);
    mpc_clear(out1); mpc_clear(in1); mpc_clear(in2); mpc_clear(in3); mpc_clear(in4);
}













//*********************** Flint **********************************


//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////





/* Roots and quadratic, cubic, and quartic equations */



void Lib_XReal_Arb_Sqrt(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sqrt, res, x);
}


void Lib_XReal_Arb_Rsqrt(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_rsqrt, res, x);
}


void Lib_XReal_Arb_Cbrt(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_cbrt, res, x);
}


void Lib_XReal_Arb_Sqrt1pm1(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sqrt1pm1, res, x);
}


void Lib_XReal_Arb_Root_ui(long double* res, const long double* x, const int32_t n)
{
    XReal_Arb_Realfunc1Int32_Prec(arb_root_ui_, res, x, n);
}




/* Exponential and related functions */



void Lib_XReal_Arb_Exp(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_exp, res, x);
}


void Lib_XReal_Arb_Expm1(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_expm1, res, x);
}


void Lib_XReal_Arb_Exp10(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_exp10_, res, x);
}


void Lib_XReal_Arb_Exp2(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_exp2_, res, x);
}


void Lib_XReal_Arb_Exp10m1(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_exp10m1_, res, x);
}


void Lib_XReal_Arb_Exp2m1(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_exp2m1_, res, x);
}


void Lib_XReal_Arb_ExpRel(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_exprel_, res, x);
}



/* Logarithms and related functions */



void Lib_XReal_Arb_Log(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_log, res, x);
}


void Lib_XReal_Arb_Logbase(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_logbase_, res, x, y);
}


void Lib_XReal_Arb_Log10(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_log10, res, x);
}


void Lib_XReal_Arb_Log2(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_log2, res, x);
}


void Lib_XReal_Arb_Log1p(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_log1p, res, x);
}


void Lib_XReal_Arb_Log10p1(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_log10p1_, res, x);
}


void Lib_XReal_Arb_Log2p1(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_log2p1_, res, x);
}


void Lib_XReal_Arb_Log1mexp(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_log1mexp_, res, x);
}


void Lib_XReal_Arb_LambertW0(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_lambertw0, res, x);
}


void Lib_XReal_Arb_LambertWm1(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_lambertwm1, res, x);
}





/* Power functions */


void Lib_XReal_Arb_Square(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sqr, res, x);
}


void Lib_XReal_Arb_Cube(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_cube_, res, x);
}


void Lib_XReal_Arb_Pow_ui(long double* res, const long double* x, const int32_t n)
{
    XReal_Arb_Realfunc1Int32_Prec(arb_pow_ui_, res, x, n);
}


void Lib_XReal_Arb_Pow_si(long double* res, const long double* x, const int32_t n)
{
    XReal_Arb_Realfunc1Int32_Prec(arb_pow_si_, res, x, n);
}


void Lib_XReal_Arb_Compound_si(long double* res, const long double* x, const int32_t n)
{
    XReal_Arb_Realfunc1Int32_Prec(arb_compound_si_, res, x, n);
}


void Lib_XReal_Arb_Hypot(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypot, res, x, y);
}


void Lib_XReal_Arb_Pow(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_pow, res, x, y);
}


void Lib_XReal_Arb_Powm1(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_powm1_, res, x, y);
}


void Lib_XReal_Arb_Pow1p(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_pow1p_, res, x, y);
}


void Lib_XReal_Arb_Pow1pm1(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_pow1pm1_, res, x, y);
}





/* Trigonometric and related functions */



void Lib_XReal_Arb_Sin(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sin, res, x);
}


void Lib_XReal_Arb_Cos(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_cos, res, x);
}


void Lib_XReal_Arb_Tan(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_tan, res, x);
}


void Lib_XReal_Arb_Csc(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_csc, res, x);
}


void Lib_XReal_Arb_Sec(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sec, res, x);
}


void Lib_XReal_Arb_Cot(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_cot, res, x);
}


void Lib_XReal_Arb_Sinc(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sinc, res, x);
}


void Lib_XReal_Arb_SincPi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sinc_pi, res, x);
}


void Lib_XReal_Arb_SinPi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sin_pi, res, x);
}


void Lib_XReal_Arb_CosPi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_cos_pi, res, x);
}


void Lib_XReal_Arb_TanPi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_tan_pi, res, x);
}


void Lib_XReal_Arb_CotPi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_cot_pi, res, x);
}






/* Hyperbolic functions */


void Lib_XReal_Arb_Sinh(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sinh, res, x);
}


void Lib_XReal_Arb_Cosh(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_cosh, res, x);
}


void Lib_XReal_Arb_Tanh(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_tanh, res, x);
}


void Lib_XReal_Arb_Csch(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_csch, res, x);
}


void Lib_XReal_Arb_Sech(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_sech, res, x);
}


void Lib_XReal_Arb_Coth(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_coth, res, x);
}







/* Inverse trigonometric functions */



void Lib_XReal_Arb_Asin(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_asin, res, x);
}


void Lib_XReal_Arb_Acos(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_acos, res, x);
}


void Lib_XReal_Arb_Atan2(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_atan2, res, x, y);
}


void Lib_XReal_Arb_Atan(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_atan, res, x);
}


void Lib_XReal_Arb_Acsc(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_acsc, res, x);
}


void Lib_XReal_Arb_Asec(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_asec, res, x);
}


void Lib_XReal_Arb_Acot(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_acot, res, x);
}









/* Inverse hyperbolic functions */



void Lib_XReal_Arb_Asinh(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_asinh, res, x);
}


void Lib_XReal_Arb_Acosh(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_acosh, res, x);
}


void Lib_XReal_Arb_Atanh(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_atanh, res, x);
}


void Lib_XReal_Arb_Acsch(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_acsch, res, x);
}


void Lib_XReal_Arb_Asech(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_asech, res, x);
}


void Lib_XReal_Arb_Acoth(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_acoth, res, x);
}








/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_XReal_Arb_MEllipticK(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_elliptic_k, res, x);
}


void Lib_XReal_Arb_MEllipticE(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_elliptic_e, res, x);
}


void Lib_XReal_Arb_MEllipticPi(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_elliptic_pi, res, x, y);
}


void Lib_XReal_Arb_MEllipticF(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_elliptic_f_, res, x, y);
}


void Lib_XReal_Arb_MEllipticEInc(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_, res, x, y);
}


void Lib_XReal_Arb_MEllipticPiInc(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_, res, a, b, z);
}




/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_XReal_Arb_EllipticK(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_elliptic_k_k_, res, x);
}


void Lib_XReal_Arb_EllipticE(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_elliptic_e_k_, res, x);
}


void Lib_XReal_Arb_EllipticPi(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_elliptic_pi_k_, res, x, y);
}


void Lib_XReal_Arb_EllipticF(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_elliptic_f_k_, res, x, y);
}


void Lib_XReal_Arb_EllipticEInc(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_k_, res, x, y);
}


void Lib_XReal_Arb_EllipticPiInc(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_k_, res, a, b, z);
}


void Lib_XReal_Arb_Agm(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */


void Lib_XReal_Arb_Elliptic_RC(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_elliptic_rc_, res, x, y);
}


void Lib_XReal_Arb_Elliptic_RF(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_elliptic_rf_, res, a, b, z);
}


void Lib_XReal_Arb_Elliptic_RG(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_elliptic_rg_, res, a, b, z);
}


void Lib_XReal_Arb_Elliptic_RD(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_elliptic_rd_, res, a, b, z);
}


void Lib_XReal_Arb_Elliptic_RJ(long double* res, const long double* a, const long double* b, const long double* c, const long double* z)
{
    XReal_Arb_Realfunc4_Prec(arb_elliptic_rj_, res, a, b, c, z);
}





/* Jacobi theta functions */


void Lib_XReal_Arb_Theta1Q(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_theta1q, res, x, y);
}


void Lib_XReal_Arb_Theta2Q(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_theta2q, res, x, y);
}


void Lib_XReal_Arb_Theta3Q(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_theta3q, res, x, y);
}


void Lib_XReal_Arb_Theta4Q(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_theta4q, res, x, y);
}




/* Jacobi elliptic functions */


void Lib_XReal_Arb_JacobiSN(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_sn, res, x, y);
}


void Lib_XReal_Arb_JacobiCN(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_cn, res, x, y);
}


void Lib_XReal_Arb_JacobiDN(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_dn, res, x, y);
}


void Lib_XReal_Arb_JacobiNS(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_ns, res, x, y);
}


void Lib_XReal_Arb_JacobiNC(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_nc, res, x, y);
}


void Lib_XReal_Arb_JacobiND(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_nd, res, x, y);
}


void Lib_XReal_Arb_JacobiSC(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_sc, res, x, y);
}


void Lib_XReal_Arb_JacobiSD(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_sd, res, x, y);
}


void Lib_XReal_Arb_JacobiDC(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_dc, res, x, y);
}


void Lib_XReal_Arb_JacobiDS(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_ds, res, x, y);
}


void Lib_XReal_Arb_JacobiCS(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_cs, res, x, y);
}


void Lib_XReal_Arb_JacobiCD(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(_arb_jacobi_cd, res, x, y);
}





/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */



void Lib_XReal_Arb_LerchPhi(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_dirichlet_lerch_phi, res, a, b, z);
}




/* Polygamma functions */


void Lib_XReal_Arb_Polygamma(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_polygamma, res, x, y);
}


void Lib_XReal_Arb_Digamma(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_XReal_Arb_Polylog(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_polylog, res, x, y);
}


void Lib_XReal_Arb_Dilog(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_dilog, res, x);
}




/* Hurwitz zeta function and related functions */


void Lib_XReal_Arb_HurwitzZeta(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hurwitz_zeta, res, x, y);
}



void Lib_XReal_Arb_Bernoulli_ui(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_bernoulli_ui_, res, n);
}


void Lib_XReal_Arb_Euler_ui(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_euler_number_ui_, res, n);
}


void Lib_XReal_Arb_BernoulliPoly_ui(long double* res, const long double* x, const int32_t n)
{
    XReal_Arb_Realfunc1Int32_Prec(arb_bernoulli_poly_ui_, res, x, n);
}



void Lib_XReal_Arb_BarnesG(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_barnes_g, res, x);
}


void Lib_XReal_Arb_LogBarnesG(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_log_barnes_g, res, x);
}






/* Riemann zeta function, and related functions */



void Lib_XReal_Arb_Zeta(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_zeta, res, x);
}


void Lib_XReal_Arb_BacklundS(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(acb_dirichlet_backlund_s, res, x);
}


void Lib_XReal_Arb_GramPoint_ui(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_gram_point_ui_, res, n);
}





/* Additional numbertheoretic functions */


void Lib_XReal_Arb_Bell_ui(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_bell_ui_, res, n);
}


void Lib_XReal_Arb_Partitions_ui(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_partitions_ui_, res, n);
}


void Lib_XReal_Arb_Primorial_ui(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_primorial_nth_ui_, res, n);
}





/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_XReal_Arb_Hypgeom0F1(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_, res, x, y);
}


void Lib_XReal_Arb_Hypgeom0F1r(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_r, res, x, y);
}




/* Bessel functions and modified Bessel functions  */


void Lib_XReal_Arb_BesselJ(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_j, res, x, y);
}


void Lib_XReal_Arb_BesselY(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_y, res, x, y);
}


void Lib_XReal_Arb_BesselI(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i, res, x, y);
}


void Lib_XReal_Arb_BesselK(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k, res, x, y);
}


void Lib_XReal_Arb_BesselIScaled(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_XReal_Arb_BesselKScaled(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */





/* Airy functions  */



void Lib_XReal_Arb_AiryAi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_airy_ai, res, x);
}


void Lib_XReal_Arb_AiryAiPrime(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_airy_ai_prime, res, x);
}


void Lib_XReal_Arb_AiryBi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_airy_bi, res, x);
}


void Lib_XReal_Arb_AiryBiPrime(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_airy_bi_prime, res, x);
}




void Lib_XReal_Arb_AiryAiZero(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_zero, res, n);
}


void Lib_XReal_Arb_AiryAiPrimeZero(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_prime_zero, res, n);
}


void Lib_XReal_Arb_AiryBiZero(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_zero, res, n);
}


void Lib_XReal_Arb_AiryBiPrimeZero(long double* res, const int32_t n)
{
    XReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_prime_zero, res, n);
}






/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


void Lib_XReal_Arb_Hypgeom1F1(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1_, res, a, b, z);
}


void Lib_XReal_Arb_Hypgeom1F1r(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_XReal_Arb_HypgeomU(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_u, res, a, b, z);
}






/* Gamma function and related functions */


void Lib_XReal_Arb_Gamma(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_gamma, res, x);
}


void Lib_XReal_Arb_Rgamma(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_rgamma, res, x);
}


void Lib_XReal_Arb_Lgamma(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_lgamma, res, x);
}


void Lib_XReal_Arb_RisingFactorial(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_rising, res, x, y);
}


void Lib_XReal_Arb_Beta(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_beta_, res, x, y);
}





/* Incomplete gamma functions */



void Lib_XReal_Arb_GammaUpper(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_gamma_upper_, res, x, y);
}


void Lib_XReal_Arb_GammaUpperR(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_gamma_upper_r, res, x, y);
}


void Lib_XReal_Arb_GammaLower(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_gamma_lower_, res, x, y);
}


void Lib_XReal_Arb_GammaPPrime(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_gamma_p_derivative, res, x, y);
}


void Lib_XReal_Arb_GammaP(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_gamma_p, res, x, y);
}


void Lib_XReal_Arb_GammaQ(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_gamma_q, res, x, y);
}





/* Error function and related functions */


void Lib_XReal_Arb_Erf(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_erf, res, x);
}


void Lib_XReal_Arb_Erfc(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_erfc, res, x);
}


void Lib_XReal_Arb_Erfinv(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_erfinv, res, x);
}


void Lib_XReal_Arb_Erfcinv(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_erfcinv, res, x);
}


void Lib_XReal_Arb_Erfi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_erfi, res, x);
}


void Lib_XReal_Arb_FresnelC(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_fresnelc, res, x);
}


void Lib_XReal_Arb_FresnelS(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_fresnels, res, x);
}


void Lib_XReal_Arb_Ndens(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_ndens, res, x);
}


void Lib_XReal_Arb_Ndis(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_ndis, res, x);
}







/* Exponential integrals and related functions */


void Lib_XReal_Arb_ExpIntegralE(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_expint, res, x, y);
}


void Lib_XReal_Arb_ExpIntegralEi(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_ei, res, x);
}


void Lib_XReal_Arb_SinIntegral(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_si, res, x);
}


void Lib_XReal_Arb_CosIntegral(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_ci, res, x);
}


void Lib_XReal_Arb_SinhIntegral(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_shi, res, x);
}


void Lib_XReal_Arb_CoshIntegral(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_chi, res, x);
}


void Lib_XReal_Arb_LogIntegral(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_li_, res, x);
}


void Lib_XReal_Arb_LogIntegralOffset(long double* res, const long double* x)
{
    XReal_Arb_Realfunc1_Prec(arb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_XReal_Arb_HermiteH(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_hermite_h, res, x, y);
}


void Lib_XReal_Arb_LaguerreL(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */


void Lib_XReal_Arb_CoulombF(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_f, res, a, b, z);
}


void Lib_XReal_Arb_CoulombG(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_g, res, a, b, z);
}





/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_XReal_Arb_Hyp2f1(long double* res, const long double* a, const long double* b, const long double* c, const long double* z)
{
    XReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_XReal_Arb_Hyp2f1r(long double* res, const long double* a, const long double* b, const long double* c, const long double* z)
{
    XReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1r_, res, a, b, c, z);
}





/* 2F1: Orthogonal polynomials */


void Lib_XReal_Arb_ChebyshevT(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_XReal_Arb_ChebyshevU(long double* res, const long double* x, const long double* y)
{
    XReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_XReal_Arb_GegenbauerC(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_XReal_Arb_LegendreP(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_XReal_Arb_LegendrePv(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_XReal_Arb_LegendreQ(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_XReal_Arb_LegendreQv(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_qv_, res, a, b, z);
}


void Lib_XReal_Arb_JacobiP(long double* res, const long double* a, const long double* b, const long double* c, const long double* z)
{
    XReal_Arb_Realfunc4_Prec(arb_hypgeom_jacobi_p, res, a, b, c, z);
}





/* 2F1: Incomplete Beta Function */


void Lib_XReal_Arb_BetaLower(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_, res, a, b, z);
}


void Lib_XReal_Arb_Ibeta(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_ibeta, res, a, b, z);
}


void Lib_XReal_Arb_Ibetac(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_ibetac, res, a, b, z);
}


void Lib_XReal_Arb_IbetaPrime(long double* res, const long double* a, const long double* b, const long double* z)
{
    XReal_Arb_Realfunc3_Prec(arb_ibeta_derivative, res, a, b, z);
}





/* Hypergeometric Function 1F2, overview */


void Lib_XReal_Arb_Hypgeom1F2(long double* res, const long double* a, const long double* b, const long double* c, const long double* z)
{
    XReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2_, res, a, b, c, z);
}


void Lib_XReal_Arb_Hypgeom1F2r(long double* res, const long double* a, const long double* b, const long double* c, const long double* z)
{
    XReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2r_, res, a, b, c, z);
}









////////////////////////////////////////////////////////
////// Acb functions
////////////////////////////////////////////////////////






/* Roots and quadratic, cubic, and quartic equations */


void Lib_XCplx_Acb_UnitRoot_ui(XCplxPtr res, const int32_t n)
{
    XCplx_Acb_Cplxfunc0Int32_Prec(acb_unit_root_, res, n);
}


void Lib_XCplx_Acb_Sqrt(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sqrt, res, x);
}


void Lib_XCplx_Acb_Rsqrt(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_rsqrt, res, x);
}


void Lib_XCplx_Acb_Cbrt(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_cbrt, res, x);
}


void Lib_XCplx_Acb_Sqrt1pm1(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sqrt1pm1, res, x);
}


void Lib_XCplx_Acb_Root_ui(XCplxPtr res, const XCplxPtr x, const int32_t n)
{
    XCplx_Acb_Cplxfunc1Int32_Prec(acb_root_ui_, res, x, n);
}






/* Exponential and related functions */


void Lib_XCplx_Acb_Exp(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_exp, res, x);
}


void Lib_XCplx_Acb_Expj(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_expj_, res, x);
}


void Lib_XCplx_Acb_Expjpi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_exp_pi_i, res, x);
}


void Lib_XCplx_Acb_Expm1(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_expm1, res, x);
}


void Lib_XCplx_Acb_Exp10(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_exp10_, res, x);
}


void Lib_XCplx_Acb_Exp2(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_exp2_, res, x);
}


void Lib_XCplx_Acb_Exp10m1(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_exp10m1_, res, x);
}


void Lib_XCplx_Acb_Exp2m1(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_exp2m1_, res, x);
}


void Lib_XCplx_Acb_ExpRel(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_exprel_, res, x);
}






/* Logarithms and related functions */



void Lib_XCplx_Acb_Log(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_log, res, x);
}


void Lib_XCplx_Acb_Logbase(XCplxPtr res, const XCplxPtr x, const XCplxPtr b)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_logbase_, res, x, b);
}


void Lib_XCplx_Acb_Log1p(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_log1p, res, x);
}


void Lib_XCplx_Acb_Log10(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_log10_, res, x);
}


void Lib_XCplx_Acb_Log2(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_log2_, res, x);
}


void Lib_XCplx_Acb_Log10p1(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_log10p1_, res, x);
}



void Lib_XCplx_Acb_Log2p1(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_log2p1_, res, x);
}




void Lib_XCplx_Acb_LambertW_ui(XCplxPtr res, const XCplxPtr x, const int32_t n)
{
    XCplx_Acb_Cplxfunc1Int32_Prec(acb_lambertw_ui_, res, x, n);
}







/* Power functions */


void Lib_XCplx_Acb_Square(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sqr, res, x);
}


void Lib_XCplx_Acb_Cube(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_cube, res, x);
}


void Lib_XCplx_Acb_Pow_si(XCplxPtr res, const XCplxPtr x, const int32_t n)
{
    XCplx_Acb_Cplxfunc1Int32_Prec(acb_pow_si_, res, x, n);
}



void Lib_XCplx_Acb_Hypot(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypot_, res, x, y);
}


void Lib_XCplx_Acb_Pow(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
}


void Lib_XCplx_Acb_Powm1(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_powm1_, res, x, y);
}


void Lib_XCplx_Acb_Pow1p(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_pow1p_, res, x, y);
}


void Lib_XCplx_Acb_Pow1pm1(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_pow1pm1_, res, x, y);
}







/* Trigonometric and related functions */



void Lib_XCplx_Acb_Sin(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sin, res, x);
}


void Lib_XCplx_Acb_Cos(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_cos, res, x);
}


void Lib_XCplx_Acb_Tan(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_tan, res, x);
}



void Lib_XCplx_Acb_Csc(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_csc, res, x);
}


void Lib_XCplx_Acb_Sec(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sec, res, x);
}


void Lib_XCplx_Acb_Cot(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_cot, res, x);
}





/* Hyperbolic functions */


void Lib_XCplx_Acb_Sinh(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sinh, res, x);
}


void Lib_XCplx_Acb_Cosh(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_cosh, res, x);
}


void Lib_XCplx_Acb_Tanh(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_tanh, res, x);
}



void Lib_XCplx_Acb_Csch(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_csch, res, x);
}


void Lib_XCplx_Acb_Sech(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sech, res, x);
}


void Lib_XCplx_Acb_Coth(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_coth, res, x);
}



void Lib_XCplx_Acb_Sinc(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sinc, res, x);
}


void Lib_XCplx_Acb_SincPi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sinc_pi, res, x);
}



void Lib_XCplx_Acb_SinPi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sin_pi, res, x);
}


void Lib_XCplx_Acb_CosPi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_cos_pi, res, x);
}


void Lib_XCplx_Acb_TanPi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_tan_pi, res, x);
}


void Lib_XCplx_Acb_CotPi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_cot_pi, res, x);
}


void Lib_XCplx_Acb_CscPi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_csc_pi, res, x);
}


void Lib_XCplx_Acb_SecPi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_sec_pi_, res, x);
}






/* Inverse trigonometric functions */


void Lib_XCplx_Acb_Asin(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_asin, res, x);
}


void Lib_XCplx_Acb_Acos(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_acos, res, x);
}


void Lib_XCplx_Acb_Atan(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_atan, res, x);
}



void Lib_XCplx_Acb_Acsc(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_acsc, res, x);
}


void Lib_XCplx_Acb_Asec(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_asec, res, x);
}


void Lib_XCplx_Acb_Acot(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_XCplx_Acb_Asinh(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_asinh, res, x);
}


void Lib_XCplx_Acb_Acosh(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_acosh, res, x);
}


void Lib_XCplx_Acb_Atanh(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_atanh, res, x);
}



void Lib_XCplx_Acb_Acsch(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_acsch, res, x);
}


void Lib_XCplx_Acb_Asech(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_asech, res, x);
}


void Lib_XCplx_Acb_Acoth(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_acoth, res, x);
}









/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_XCplx_Acb_MEllipticK(XCplxPtr res, const XCplxPtr m)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k, res, m);
}


void Lib_XCplx_Acb_MEllipticE(XCplxPtr res, const XCplxPtr m)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e, res, m);
}


void Lib_XCplx_Acb_MEllipticPi(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi, res, phi, m);

}


void Lib_XCplx_Acb_MEllipticF(XCplxPtr res, const XCplxPtr phi, const XCplxPtr m)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_, res, phi, m);

}


void Lib_XCplx_Acb_MEllipticEInc(XCplxPtr res, const XCplxPtr n, const XCplxPtr m)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_, res, n, m);
}


void Lib_XCplx_Acb_MEllipticPiInc(XCplxPtr res, const XCplxPtr n, const XCplxPtr phi, const XCplxPtr m)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_, res, n, phi, m);
}







/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_XCplx_Acb_EllipticK(XCplxPtr res, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k_k_, res, k);
}


void Lib_XCplx_Acb_EllipticE(XCplxPtr res, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e_k_, res, k);
}


void Lib_XCplx_Acb_EllipticPi(XCplxPtr res, const XCplxPtr phi, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi_k_, res, phi, k);

}


void Lib_XCplx_Acb_EllipticF(XCplxPtr res, const XCplxPtr phi, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_k_, res, phi, k);

}


void Lib_XCplx_Acb_EllipticEInc(XCplxPtr res, const XCplxPtr n, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_k_, res, n, k);
}


void Lib_XCplx_Acb_EllipticPiInc(XCplxPtr res, const XCplxPtr n, const XCplxPtr phi, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_k_, res, n, phi, k);
}



void Lib_XCplx_Acb_Agm(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */

void Lib_XCplx_Acb_Elliptic_RC(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_rc_, res, x, y);
}



void Lib_XCplx_Acb_Elliptic_RF(XCplxPtr res, const XCplxPtr x, const XCplxPtr y, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rf_, res, x, y, z);
}


void Lib_XCplx_Acb_Elliptic_RG(XCplxPtr res, const XCplxPtr x, const XCplxPtr y, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rg_, res, x, y, z);
}


void Lib_XCplx_Acb_Elliptic_RD(XCplxPtr res, const XCplxPtr x, const XCplxPtr y, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rd_, res, x, y, z);
}


void Lib_XCplx_Acb_Elliptic_RJ(XCplxPtr res, const XCplxPtr x, const XCplxPtr y, const XCplxPtr z, const XCplxPtr w)
{
    XCplx_Acb_Cplxfunc4_Prec(acb_elliptic_rj_, res, x, y, z, w);
}






/* Jacobi theta functions */


void Lib_XCplx_Acb_Theta1Q(XCplxPtr res, const XCplxPtr z, const XCplxPtr q)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_theta1q, res, z, q);
}


void Lib_XCplx_Acb_Theta2Q(XCplxPtr res, const XCplxPtr z, const XCplxPtr q)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_theta2q, res, z, q);
}


void Lib_XCplx_Acb_Theta3Q(XCplxPtr res, const XCplxPtr z, const XCplxPtr q)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_theta3q, res, z, q);
}


void Lib_XCplx_Acb_Theta4Q(XCplxPtr res, const XCplxPtr z, const XCplxPtr q)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_theta4q, res, z, q);
}



void Lib_XCplx_Acb_Theta1Tau(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_theta1, res, z, tau);
}


void Lib_XCplx_Acb_Theta2Tau(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_theta2, res, z, tau);
}


void Lib_XCplx_Acb_Theta3Tau(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_theta3, res, z, tau);
}


void Lib_XCplx_Acb_Theta4Tau(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_theta4, res, z, tau);
}







/* Jacobi elliptic functions */


void Lib_XCplx_Acb_QfromK(XCplxPtr res, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_qfromk, res, k);
}


void Lib_XCplx_Acb_TfromUQ(XCplxPtr res, const XCplxPtr u, const XCplxPtr q)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_tfrom_u_q, res, u, q);
}


void Lib_XCplx_Acb_SnTQ(XCplxPtr res, const XCplxPtr t, const XCplxPtr q)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_sn_t_q, res, t, q);
}


void Lib_XCplx_Acb_CnTQ(XCplxPtr res, const XCplxPtr t, const XCplxPtr q)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_cn_t_q, res, t, q);
}


void Lib_XCplx_Acb_DnTQ(XCplxPtr res, const XCplxPtr t, const XCplxPtr q)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_dn_t_q, res, t, q);
}


void Lib_XCplx_Acb_JacobiSN(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sn, res, u, k);
}


void Lib_XCplx_Acb_JacobiCN(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cn, res, u, k);
}


void Lib_XCplx_Acb_JacobiDN(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dn, res, u, k);
}





void Lib_XCplx_Acb_JacobiNS(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ns, res, u, k);
}


void Lib_XCplx_Acb_JacobiNC(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nc, res, u, k);
}


void Lib_XCplx_Acb_JacobiND(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nd, res, u, k);
}




void Lib_XCplx_Acb_JacobiSC(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sc, res, u, k);
}


void Lib_XCplx_Acb_JacobiSD(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sd, res, u, k);
}




void Lib_XCplx_Acb_JacobiDC(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dc, res, u, k);
}


void Lib_XCplx_Acb_JacobiDS(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ds, res, u, k);
}




void Lib_XCplx_Acb_JacobiCS(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cs, res, u, k);
}


void Lib_XCplx_Acb_JacobiCD(XCplxPtr res, const XCplxPtr u, const XCplxPtr k)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cd, res, u, k);
}







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


void Lib_XCplx_Acb_WeierstrassP(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_p, res, z, tau);
}


void Lib_XCplx_Acb_WeierstrassPInv(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_inv_p, res, z, tau);
}


void Lib_XCplx_Acb_WeierstrassPZeta(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_zeta, res, z, tau);
}


void Lib_XCplx_Acb_WeierstrassPSigma(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_elliptic_sigma, res, z, tau);
}



void Lib_XCplx_Acb_WeierstrassPPrime(XCplxPtr res, const XCplxPtr z, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_wp_prime, res, z, tau);
}



void Lib_XCplx_Acb_EllipticInvariantG2(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g2, res, tau);
}


void Lib_XCplx_Acb_EllipticInvariantG3(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g3, res, tau);
}


void Lib_XCplx_Acb_EllipticRootE1(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e1, res, tau);
}


void Lib_XCplx_Acb_EllipticRootE2(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e2, res, tau);
}


void Lib_XCplx_Acb_EllipticRootE3(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e3, res, tau);
}



void Lib_XCplx_Acb_DedekindEta(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_modular_eta, res, tau);
}


void Lib_XCplx_Acb_KleinJ(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_modular_j, res, tau);
}


void Lib_XCplx_Acb_ModularLambda(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_modular_lambda, res, tau);
}


void Lib_XCplx_Acb_ModularDelta(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_modular_delta, res, tau);
}




/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */






/* Lerch’s transcendent: overview */


void Lib_XCplx_Acb_LerchPhi(XCplxPtr res, const XCplxPtr z, const XCplxPtr s, const XCplxPtr a)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_dirichlet_lerch_phi, res, z, s, a);
}


void Lib_XCplx_Acb_LerchZeta(XCplxPtr res, const XCplxPtr lambda1, const XCplxPtr alpha, const XCplxPtr s)
{
    XCplx_Acb_Cplxfunc3_Prec(_acb_lerch_zeta, res, lambda1, alpha, s);
}


/* Polygamma functions */


void Lib_XCplx_Acb_Polygamma(XCplxPtr res, const XCplxPtr s, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_polygamma, res, s, z);
}


void Lib_XCplx_Acb_Trigamma(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_trigamma, res, x);
}


void Lib_XCplx_Acb_Digamma(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_XCplx_Acb_Polylog(XCplxPtr res, const XCplxPtr s, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_polylog, res, s, z);
}


void Lib_XCplx_Acb_Trilog(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_trilog, res, x);
}


void Lib_XCplx_Acb_Dilog(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_dilog, res, x);
}



void Lib_XCplx_Acb_ClausenSin(XCplxPtr res, const XCplxPtr s, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_clausen_sin, res, s, z);
}


void Lib_XCplx_Acb_ClausenCos(XCplxPtr res, const XCplxPtr s, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_clausen_cos, res, s, z);
}


void Lib_XCplx_Acb_Clausen2(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_clausen2, res, x);
}


void Lib_XCplx_Acb_BoseEinstein(XCplxPtr res, const XCplxPtr s, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_bose_einstein, res, s, z);
}


void Lib_XCplx_Acb_FermiDirac(XCplxPtr res, const XCplxPtr s, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_fermi_dirac, res, s, z);
}


void Lib_XCplx_Acb_LegendreChi(XCplxPtr res, const XCplxPtr s, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_legendre_chi, res, s, z);
}


void Lib_XCplx_Acb_InverseTanIntegral(XCplxPtr res, const XCplxPtr s, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_ti, res, s, z);
}





/* Hurwitz zeta function and related functions */




void Lib_XCplx_Acb_HurwitzZeta(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hurwitz_zeta, res, x, y);
}


void Lib_XCplx_Acb_Stieltjes_ui(XCplxPtr res, const XCplxPtr x, const int32_t n)
{
    XCplx_Acb_Cplxfunc1Int32_Prec(acb_stieltjes_ui_, res, x, n);
}


void Lib_XCplx_Acb_BernoulliPoly_ui(XCplxPtr res, const XCplxPtr x, const int32_t n)
{
    XCplx_Acb_Cplxfunc1Int32_Prec(acb_bernoulli_poly_ui_, res, x, n);
}



void Lib_XCplx_Acb_Harmonic(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_harmonic, res, x);
}


void Lib_XCplx_Acb_Harmonic2(XCplxPtr res, const XCplxPtr z, const XCplxPtr r)
{
    XCplx_Acb_Cplxfunc2_Prec(_acb_harmonic2, res, z, r);
}


void Lib_XCplx_Acb_EulerPoly_ui(XCplxPtr res, const XCplxPtr x, const int32_t n)
{
    XCplx_Acb_Cplxfunc1Int32_Prec(acb_euler_poly_ui_, res, x, n);
}


void Lib_XCplx_Acb_Hyperfactorial(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_hyperfac, res, x);
}


void Lib_XCplx_Acb_Superfactorial(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_superfac, res, x);
}


void Lib_XCplx_Acb_BarnesG(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_barnes_g, res, x);
}


void Lib_XCplx_Acb_LogBarnesG(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */


void Lib_XCplx_Acb_Zeta(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_zeta, res, x);
}


void Lib_XCplx_Acb_Zetam1(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_zetam1, res, x);
}


void Lib_XCplx_Acb_ZetaZero_ui(XCplxPtr res, const int32_t n)
{
    XCplx_Acb_Cplxfunc0Int32_Prec(acb_dirichlet_zeta_zero_ui_, res, n);
}


void Lib_XCplx_Acb_DirichletXi(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_xi, res, tau);
}


void Lib_XCplx_Acb_DirichletEta(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_eta, res, tau);
}


void Lib_XCplx_Acb_DirichletEtam1(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_etam1, res, x);
}


void Lib_XCplx_Acb_DirichletBeta(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_beta, res, x);
}


void Lib_XCplx_Acb_DirichletLambda(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_lambda, res, x);
}



/* Riemann-Siegel Z-function */
void Lib_XCplx_Acb_HardyZ(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_z_, res, tau);
}

/* rstheta(z) in amath */
void Lib_XCplx_Acb_HardyTheta(XCplxPtr res, const XCplxPtr tau)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_theta_, res, tau);
}









/* Additional numbertheoretic functions */




/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_XCplx_Acb_Hypgeom0F1(XCplxPtr res, const XCplxPtr a, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_, res, a, x);
}


void Lib_XCplx_Acb_Hypgeom0F1r(XCplxPtr res, const XCplxPtr a, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */



void Lib_XCplx_Acb_BesselJ(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_j, res, x, y);
}


void Lib_XCplx_Acb_BesselY(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_y, res, x, y);
}


void Lib_XCplx_Acb_BesselI(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i, res, x, y);
}


void Lib_XCplx_Acb_BesselK(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k, res, x, y);
}


void Lib_XCplx_Acb_BesselIScaled(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_XCplx_Acb_BesselKScaled(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */




/* Airy functions  */


void Lib_XCplx_Acb_AiryAi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_airy_ai, res, x);
}


void Lib_XCplx_Acb_AiryAiPrime(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_airy_ai_prime, res, x);
}


void Lib_XCplx_Acb_AiryBi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_airy_bi, res, x);
}


void Lib_XCplx_Acb_AiryBiPrime(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_airy_bi_prime, res, x);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */



void Lib_XCplx_Acb_Hypgeom1F1(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
}


void Lib_XCplx_Acb_Hypgeom1F1r(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_XCplx_Acb_HypgeomU(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_u, res, a, b, z);
}





/* Gamma function and related functions */


void Lib_XCplx_Acb_Gamma(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_gamma, res, x);
}


void Lib_XCplx_Acb_Rgamma(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_rgamma, res, x);
}


void Lib_XCplx_Acb_Lgamma(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_lgamma, res, x);
}


void Lib_XCplx_Acb_RisingFactorial(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_rising, res, x, y);
}


void Lib_XCplx_Acb_Beta(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_beta_, res, x, y);
}






/* Incomplete gamma functions */


void Lib_XCplx_Acb_GammaUpper(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_gamma_upper_, res, x, y);
}



void Lib_XCplx_Acb_GammaLower(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_gamma_lower_, res, x, y);
}



void Lib_XCplx_Acb_GammaPPrime(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_gamma_p_derivative, res, x, y);
}


void Lib_XCplx_Acb_GammaP(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_gamma_p, res, x, y);
}


void Lib_XCplx_Acb_GammaQ(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_gamma_q, res, x, y);
}







/* Error function and related functions */


void Lib_XCplx_Acb_Erf(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erf, res, x);
}


void Lib_XCplx_Acb_Erfc(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfc, res, x);
}


void Lib_XCplx_Acb_Erfi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfi, res, x);
}



void Lib_XCplx_Acb_FresnelC(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_fresnelc, res, x);
}


void Lib_XCplx_Acb_FresnelS(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_fresnels, res, x);
}


void Lib_XCplx_Acb_Ndens(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_ndens, res, x);
}


void Lib_XCplx_Acb_Ndis(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_ndis, res, x);
}






/* Exponential integrals and related functions */


void Lib_XCplx_Acb_ExpIntegralE(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_expint, res, x, y);
}



void Lib_XCplx_Acb_ExpIntegralEi(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ei, res, x);
}


void Lib_XCplx_Acb_SinIntegral(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_si, res, x);
}


void Lib_XCplx_Acb_CosIntegral(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ci, res, x);
}


void Lib_XCplx_Acb_SinhIntegral(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_shi, res, x);
}


void Lib_XCplx_Acb_CoshIntegral(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_chi, res, x);
}


void Lib_XCplx_Acb_LogIntegral(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_, res, x);
}


void Lib_XCplx_Acb_LogIntegralOffset(XCplxPtr res, const XCplxPtr x)
{
    XCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_XCplx_Acb_HermiteH(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_hermite_h, res, x, y);
}


void Lib_XCplx_Acb_LaguerreL(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */



void Lib_XCplx_Acb_CoulombF(XCplxPtr res, const XCplxPtr l, const XCplxPtr eta, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_XCplx_Acb_CoulombG(XCplxPtr res, const XCplxPtr l, const XCplxPtr eta, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_g, res, l, eta, z);
}


void Lib_XCplx_Acb_CoulombHpos(XCplxPtr res, const XCplxPtr l, const XCplxPtr eta, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hpos, res, l, eta, z);
}


void Lib_XCplx_Acb_CoulombHneg(XCplxPtr res, const XCplxPtr l, const XCplxPtr eta, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hneg, res, l, eta, z);
}







/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_XCplx_Acb_Hypgeom2F1(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr c, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_XCplx_Acb_Hypgeom2F1r(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr c, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1r_, res, a, b, c, z);
}



/* 2F1: Orthogonal polynomials */


void Lib_XCplx_Acb_ChebyshevT(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_XCplx_Acb_ChebyshevU(XCplxPtr res, const XCplxPtr x, const XCplxPtr y)
{
    XCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_XCplx_Acb_GegenbauerC(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_XCplx_Acb_LegendreP(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_XCplx_Acb_LegendrePv(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_XCplx_Acb_LegendreQ(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_XCplx_Acb_LegendreQv(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_qv_, res, a, b, z);
}



void Lib_XCplx_Acb_JacobiP(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr c, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_jacobi_p, res, a, b, c, z);
}


void Lib_XCplx_Acb_SphericalY(XCplxPtr res, const XCplxPtr n, const XCplxPtr m, const XCplxPtr theta, const XCplxPtr phi)
{
    XCplx_Acb_Cplxfunc4_Prec(_acb_hypgeom_spherical_y, res, n, m, theta, phi);
}





/* 2F1: Incomplete Beta Function */


void Lib_XCplx_Acb_BetaLower(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_beta_lower_, res, a, b, z);
}




void Lib_XCplx_Acb_Ibeta(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_ibeta, res, a, b, z);
}


void Lib_XCplx_Acb_Ibetac(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_ibetac, res, a, b, z);
}



void Lib_XCplx_Acb_IbetaPrime(XCplxPtr res, const XCplxPtr a, const XCplxPtr b, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc3_Prec(acb_ibeta_derivative, res, a, b, z);
}



/* Hypergeometric Function 1F2, overview */



void Lib_XCplx_Acb_Hypgeom1F2(XCplxPtr res, const XCplxPtr a1, const XCplxPtr b1, const XCplxPtr b2, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_XCplx_Acb_Hypgeom1F2r(XCplxPtr res, const XCplxPtr a1, const XCplxPtr b1, const XCplxPtr b2, const XCplxPtr z)
{
    XCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2r_, res, a1, b1, b2, z);
}



//
//
//
////*********************** Boost Special functions , quadruple precision **********************************
//
//
//
//void Lib_XReal_BernoulliB2n(long double* res, const int n)
//{
//    LibXReal_BernoulliB2n(res, n);
//}
//
//
//
//void Lib_XReal_TangentT2n(long double* res, const int n)
//{
//    LibXReal_TangentT2n(res, n);
//}
//
//
//
//void Lib_XReal_Sqrt1pm1_Boost(long double* res, const long double* x)
//{
//    LibXReal_Sqrt1pm1(res, x);
//}
//
//
//
//void Lib_XReal_SinPi_Boost(long double* res, const long double* x)
//{
//    LibXReal_SinPi(res, x);
//}
//
//
//
//void Lib_XReal_CosPi_Boost(long double* res, const long double* x)
//{
//    LibXReal_CosPi(res, x);
//}
//
//
//
//void Lib_XReal_SincPi(long double* res, const long double* x)
//{
//    LibXReal_SincPi(res, x);
//}
//
//
//
//void Lib_XReal_SinhcPi(long double* res, const long double* x)
//{
//    LibXReal_SinhcPi(res, x);
//}
//
//
//
//void Lib_XReal_Tgamma_(long double* res, const long double* x)
//{
//    LibXReal_Tgamma_(res, x);
//}
//
//
//void Lib_XReal_Tgamma1pm1(long double* res, const long double* x)
//{
//    LibXReal_Tgamma1pm1(res, x);
//}
//
//
//
//void Lib_XReal_Lgamma_(long double* res, const long double* x)
//{
//    LibXReal_Lgamma_(res, x);
//}
//
//
//
//void Lib_XReal_Digamma(long double* res, const long double* x)
//{
//    LibXReal_Digamma(res, x);
//}
//
//
//
//void Lib_XReal_Trigamma(long double* res, const long double* x)
//{
//    LibXReal_Trigamma(res, x);
//}
//
//
//
//void Lib_XReal_Factorial(long double* res, const long double* x)
//{
//    LibXReal_Factorial(res, x);
//}
//
//
//
//void Lib_XReal_DoubleFactorial(long double* res, const long double* x)
//{
//    LibXReal_DoubleFactorial(res, x);
//}
//
//
//
//
//
//void Lib_XReal_Erf_(long double* res, const long double* x)
//{
//    LibXReal_Erf_(res, x);
//}
//
//
//
//void Lib_XReal_Erfc_(long double* res, const long double* x)
//{
//    LibXReal_Erfc_(res, x);
//}
//
//
//
//void Lib_XReal_Erf_inv(long double* res, const long double* x)
//{
//    LibXReal_Erf_inv(res, x);
//}
//
//
//
//void Lib_XReal_Erfc_inv(long double* res, const long double* x)
//{
//    LibXReal_Erfc_inv(res, x);
//}
//
//
//
//void Lib_XReal_AiryAi(long double* res, const long double* x)
//{
//    LibXReal_AiryAi(res, x);
//}
//
//
//
//void Lib_XReal_AiryBi(long double* res, const long double* x)
//{
//    LibXReal_AiryBi(res, x);
//}
//
//
//
//void Lib_XReal_AiryAiPrime(long double* res, const long double* x)
//{
//    LibXReal_AiryAiPrime(res, x);
//}
//
//
//
//void Lib_XReal_AiryBiPrime(long double* res, const long double* x)
//{
//    LibXReal_AiryBiPrime(res, x);
//}
//
//
//
//void Lib_XReal_Aizero(long double* res, const int n)
//{
//    LibXReal_Aizero(res, n);
//}
//
//
//
//void Lib_XReal_Bizero(long double* res, const int n)
//{
//    LibXReal_Bizero(res, n);
//}
//
//
//
//void Lib_XReal_Ellint_1_K(long double* res, const long double* x)
//{
//    LibXReal_Ellint_1_K(res, x);
//}
//
//
//
//void Lib_XReal_Ellint_2_K(long double* res, const long double* x)
//{
//    LibXReal_Ellint_2_K(res, x);
//}
//
//
//
//void Lib_XReal_Zeta(long double* res, const long double* x)
//{
//    LibXReal_Zeta(res, x);
//}
//
//
//
//void Lib_XReal_Ei(long double* res, const long double* x)
//{
//    LibXReal_Ei(res, x);
//}
//
//
//
//void Lib_XReal_LambertW0(long double* res, const long double* x)
//{
//    LibXReal_LambertW0(res, x);
//}
//
//
//void Lib_XReal_LambertWm1(long double* res, const long double* x)
//{
//    LibXReal_LambertWm1(res, x);
//}
//
//
//
//void Lib_XReal_LambertW0Prime(long double* res, const long double* x)
//{
//    LibXReal_LambertW0Prime(res, x);
//}
//
//
//void Lib_XReal_LambertWm1Prime(long double* res, const long double* x)
//{
//    LibXReal_LambertWm1Prime(res, x);
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
//void Lib_XReal_Powm1_Boost(long double* res, const long double* a, const long double* b)
//{
//    LibXReal_Powm1(res, a, b);
//}
//
//
//
//void Lib_XReal_TgammaRatio(long double* res, const long double* a, const long double* b)
//{
//    LibXReal_TgammaRatio(res, a, b);
//}
//
//
//
//void Lib_XReal_TgammaDeltaRatio(long double* res, const long double* a, const long double* b)
//{
//    LibXReal_TgammaDeltaRatio(res, a, b);
//}
//
//
//
//void Lib_XReal_Binomial(long double* res, const long double* n, const long double* k)
//{
//    LibXReal_Binomial(res, n, k);
//}
//
//void Lib_XReal_RisingFactorial(long double* res, const long double* x, const long double* n)
//{
//    LibXReal_RisingFactorial(res, x, n);
//}
//
//
//
//
//void Lib_XReal_FallingFactorial(long double* res, const long double* x, const long double* n)
//{
//    LibXReal_FallingFactorial(res, x, n);
//}
//
//
//
//
//void Lib_XReal_BesselJ(long double* res, const long double* v, const long double* x)
//{
//    LibXReal_BesselJ(res, v, x);
//}
//
//
//
//void Lib_XReal_BesselY(long double* res, const long double* v, const long double* x)
//{
//    LibXReal_BesselY(res, v, x);
//}
//
//
//
//void Lib_XReal_BesselI(long double* res, const long double* v, const long double* x)
//{
//    LibXReal_BesselI(res, v, x);
//}
//
//
//
//void Lib_XReal_BesselK(long double* res, const long double* v, const long double* x)
//{
//    LibXReal_BesselK(res, v, x);
//}
//
//
//
//void Lib_XReal_SphBessel(long double* res, const unsigned v, const long double* x)
//{
//    LibXReal_SphBessel(res, v, x);
//}
//
//
//
//void Lib_XReal_SphNeumann(long double* res, const unsigned v, const long double* x)
//{
//    LibXReal_SphNeumann(res, v, x);
//}
//
//
//
//
//
//void Lib_XReal_BesselJPrime(long double* res, const long double* v, const long double* x)
//{
//    LibXReal_BesselJPrime(res, v, x);
//}
//
//
//
//void Lib_XReal_BesselYPrime(long double* res, const long double* v, const long double* x)
//{
//    LibXReal_BesselYPrime(res, v, x);
//}
//
//
//
//void Lib_XReal_BesselIPrime(long double* res, const long double* v, const long double* x)
//{
//    LibXReal_BesselIPrime(res, v, x);
//}
//
//
//
//void Lib_XReal_BesselKPrime(long double* res, const long double* v, const long double* x)
//{
//    LibXReal_BesselKPrime(res, v, x);
//}
//
//
//
//void Lib_XReal_SphBesselPrime(long double* res, const unsigned v, const long double* x)
//{
//    LibXReal_SphBesselPrime(res, v, x);
//}
//
//
//
//void Lib_XReal_SphNeumannPrime(long double* res, const unsigned v, const long double* x)
//{
//    LibXReal_SphNeumannPrime(res, v, x);
//}
//
//
//
//
//
//void Lib_XReal_BesselJZero(long double* res, const long double* v, const int m)
//{
//    LibXReal_BesselJZero(res, v, m);
//}
//
//
//
//void Lib_XReal_BesselYZero(long double* res, const long double* v, const int m)
//{
//    LibXReal_BesselYZero(res, v, m);
//}
//
//
//
//
//
//void Lib_XReal_GammaP(long double* res, const long double* a, const long double* x)
//{
//    LibXReal_GammaP(res, a, x);
//}
//
//
//void Lib_XReal_GammaQ(long double* res, const long double* a, const long double* x)
//{
//    LibXReal_GammaQ(res, a, x);
//}
//
//
//void Lib_XReal_TgammaLower(long double* res, const long double* a, const long double* x)
//{
//    LibXReal_TgammaLower(res, a, x);
//}
//
//
//void Lib_XReal_TgammaUpper(long double* res, const long double* a, const long double* x)
//{
//    LibXReal_TgammaUpper(res, a, x);
//}
//
//
//
//
//void Lib_XReal_GammaPInv(long double* res, const long double* a, const long double* p)
//{
//    LibXReal_GammaPInv(res, a, p);
//}
//
//
//void Lib_XReal_GammaQInv(long double* res, const long double* a, const long double* q)
//{
//    LibXReal_GammaQInv(res, a, q);
//}
//
//
//void Lib_XReal_GammaPInva(long double* res, const long double* x, const long double* p)
//{
//    LibXReal_GammaPInva(res, x, p);
//}
//
//
//void Lib_XReal_GammaQInva(long double* res, const long double* x, const long double* q)
//{
//    LibXReal_GammaQInva(res, x, q);
//}
//
//
//
//void Lib_XReal_GammaPDerivative(long double* res, const long double* a, const long double* x)
//{
//    LibXReal_GammaPDerivative(res, a, x);
//}
//
//
//void Lib_XReal_Beta(long double* res, const long double* a, const long double* b)
//{
//    LibXReal_Beta(res, a, b);
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
//void Lib_XReal_LegendreP(long double* res, int n, const long double* x)
//{
//    LibXReal_LegendreP(res, n, x);
//}
//
//
//
//void Lib_XReal_LegendreQ(long double* res, int n, const long double* x)
//{
//    LibXReal_LegendreQ(res, n, x);
//}
//
//
//
//void Lib_XReal_Laguerre(long double* res, int n, const long double* x)
//{
//    LibXReal_Laguerre(res, n, x);
//}
//
//
//
//void Lib_XReal_Hermite(long double* res, int n, const long double* x)
//{
//    LibXReal_Hermite(res, n, x);
//}
//
//
//
//void Lib_XReal_ChebyshevT(long double* res, int n, const long double* x)
//{
//    LibXReal_ChebyshevT(res, n, x);
//}
//
//
//void Lib_XReal_ChebyshevU(long double* res, int n, const long double* x)
//{
//    LibXReal_ChebyshevU(res, n, x);
//}
//
//
//
//void Lib_XReal_Polygamma(long double* res, int n, const long double* x)
//{
//    LibXReal_Polygamma(res, n, x);
//}
//
//
//
//
//
//void Lib_XReal_EllintRC(long double* res, const long double* x, const long double* y)
//{
//    LibXReal_EllintRC(res, x, y);
//}
//
//
//void Lib_XReal_Ellint1F(long double* res, const long double* k, const long double* phi)
//{
//    LibXReal_Ellint1F(res, k, phi);
//}
//
//
//void Lib_XReal_Ellint2F(long double* res, const long double* k, const long double* phi)
//{
//    LibXReal_Ellint2F(res, k, phi);
//}
//
//
//void Lib_XReal_Ellint3K(long double* res, const long double* k, const long double* n)
//{
//    LibXReal_Ellint3K(res, k, n);
//}
//
//
//
//
//void Lib_XReal_JacobiCD(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiCD(res, k, u);
//}
//
//
//void Lib_XReal_JacobiCN(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiCN(res, k, u);
//}
//
//
//void Lib_XReal_JacobiCS(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiCS(res, k, u);
//}
//
//
//void Lib_XReal_JacobiDC(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiDC(res, k, u);
//}
//
//
//void Lib_XReal_JacobiDN(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiDN(res, k, u);
//}
//
//
//void Lib_XReal_JacobiDS(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiDS(res, k, u);
//}
//
//
//void Lib_XReal_JacobiNC(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiNC(res, k, u);
//}
//
//
//void Lib_XReal_JacobiND(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiND(res, k, u);
//}
//
//
//void Lib_XReal_JacobiNS(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiNS(res, k, u);
//}
//
//
//void Lib_XReal_JacobiSC(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiSC(res, k, u);
//}
//
//
//void Lib_XReal_JacobiSD(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiSD(res, k, u);
//}
//
//
//void Lib_XReal_JacobiSN(long double* res, const long double* k, const long double* u)
//{
//    LibXReal_JacobiSN(res, k, u);
//}
//
//
//
//void Lib_XReal_expint(long double* res, const unsigned n, const long double* x)
//{
//    LibXReal_expint(res, n, x);
//}
//
//
//
//
//void Lib_XReal_OwenT(long double* res, const long double* h, const long double* a)
//{
//    LibXReal_OwenT(res, h, a);
//}
//
//
//
//
//
//void Lib_XReal_IBeta(long double* res, const long double* a, const long double* b, const long double* x)
//{
//    LibXReal_IBeta(res, a, b, x);
//}
//
//
//void Lib_XReal_IBetac(long double* res, const long double* a, const long double* b, const long double* x)
//{
//    LibXReal_IBetac(res, a, b, x);
//}
//
//
//void Lib_XReal_IBetaNonNormalized(long double* res, const long double* a, const long double* b, const long double* x)
//{
//    LibXReal_IBetaNonNormalized(res, a, b, x);
//}
//
//
//void Lib_XReal_IBetacNonNormalized(long double* res, const long double* a, const long double* b, const long double* x)
//{
//    LibXReal_IBetacNonNormalized(res, a, b, x);
//}
//
//
//void Lib_XReal_IBetaInv(long double* res, const long double* a, const long double* b, const long double* p)
//{
//    LibXReal_IBetaInv(res, a, b, p);
//}
//
//
//void Lib_XReal_IBetacInv(long double* res, const long double* a, const long double* b, const long double* q)
//{
//    LibXReal_IBetacInv(res, a, b, q);
//}
//
//
//void Lib_XReal_IBetaInva(long double* res, const long double* b, const long double* x, const long double* p)
//{
//    LibXReal_IBetaInva(res, b, x, p);
//}
//
//
//void Lib_XReal_IBetacInva(long double* res, const long double* b, const long double* x, const long double* q)
//{
//    LibXReal_IBetacInva(res, b, x, q);
//}
//
//
//void Lib_XReal_IBetaInvb(long double* res, const long double* a, const long double* x, const long double* p)
//{
//    LibXReal_IBetaInvb(res, a, x, p);
//}
//
//
//void Lib_XReal_IBetacInvb(long double* res, const long double* a, const long double* x, const long double* q)
//{
//    LibXReal_IBetacInvb(res, a, x, q);
//}
//
//
//void Lib_XReal_IBetaDerivative(long double* res, const long double* a, const long double* b, const long double* x)
//{
//    LibXReal_IBetaDerivative(res, a, b, x);
//}
//
//
//
//
//void Lib_XReal_LegendrePM(long double* res, const int n, const int m, const long double* x)
//{
//    LibXReal_LegendrePM(res, n, m, x);
//}
//
//
//
//void Lib_XReal_LaguerreM(long double* res, const int n, const int m, const long double* x)
//{
//    LibXReal_LaguerreM(res, n, m, x);
//}
//
//
//
//
//
//void Lib_XReal_EllipticRF(long double* res, const long double* x, const long double* y, const long double* z)
//{
//    LibXReal_EllipticRF(res, x, y, z);
//}
//
//
//
//void Lib_XReal_EllipticRD(long double* res, const long double* x, const long double* y, const long double* z)
//{
//    LibXReal_EllipticRD(res, x, y, z);
//}
//
//
//
//void Lib_XReal_Ellint3F(long double* res, const long double* k, const long double* n, const long double* phi)
//{
//    LibXReal_Ellint3F(res, k, n, phi);
//}
//
//
//
//
//void Lib_XReal_SphericalHarmonicR(long double* res, const int n, const int m, const long double* theta, const long double* phi)
//{
//    LibXReal_SphericalHarmonicR(res, n, m, theta, phi);
//}
//
//
//void Lib_XReal_SphericalHarmonicI(long double* res, const int n, const int m, const long double* theta, const long double* phi)
//{
//    LibXReal_SphericalHarmonicI(res, n, m, theta, phi);
//}
//
//
//void Lib_XReal_EllipticRJ(long double* res, const long double* x, const long double* y, const long double* z, const long double* p)
//{
//    LibXReal_EllipticRJ(res, x, y, z, p);
//}
//
//
//// Hypergeometric and Theta Functions
//
//
//
//
//void Lib_XReal_Hypergeo0F1(long double* res, const long double* b, const long double* x)
//{
//    LibXReal_Hypergeo0F1(res, b, x);
//}
//
//
//
//void Lib_XReal_Hypergeo1F1(long double* res, const long double* a, const long double* b, const long double* x)
//{
//    LibXReal_Hypergeo1F1(res, a, b, x);
//}
//
//
//
//void Lib_XReal_Hypergeo1F1r(long double* res, const long double* a, const long double* b, const long double* x)
//{
//    LibXReal_Hypergeo1F1r(res, a, b, x);
//}
//
//
//
//void Lib_XReal_LogHypergeo1F1(long double* res, const long double* a, const long double* b, const long double* x)
//{
//    LibXReal_LogHypergeo1F1(res, a, b, x);
//}
//
//
//
//
//
//void Lib_XReal_JacobiTheta1(long double* res, const long double* x, const long double* q)
//{
//    LibXReal_JacobiTheta1(res, x, q);
//}
//
//
//void Lib_XReal_JacobiTheta2(long double* res, const long double* x, const long double* q)
//{
//    LibXReal_JacobiTheta2(res, x, q);
//}
//
//
//void Lib_XReal_JacobiTheta3(long double* res, const long double* x, const long double* q)
//{
//    LibXReal_JacobiTheta3(res, x, q);
//}
//
//
//void Lib_XReal_JacobiTheta4(long double* res, const long double* x, const long double* q)
//{
//    LibXReal_JacobiTheta4(res, x, q);
//}
//
//
//
//
//
////*********************** Distributions **********************************
//
//
//void Lib_XReal_ArcsineDist(long Target, long double* res, long double* xqp, long double* a, long double* b)
//{
//    LibXReal_ArcsineDist(Target, res, xqp, a, b);
//}
//
//
//void Lib_XReal_BernoulliDist(long Target, long double* res, long double* xqp, long double* p)
//{
//    LibXReal_BernoulliDist(Target, res, xqp, p);
//}
//
//
//void Lib_XReal_BetaDist(long Target, long double* res, long double* xqp, long double* a, long double* b)
//{
//    LibXReal_BetaDist(Target, res, xqp, a, b);
//}
//
//
//void Lib_XReal_BinomialDist(long Target, long double* res, long double* xqp, long double* n, long double* p)
//{
//    LibXReal_BinomialDist(Target, res, xqp, n, p);
//}
//
//
//void Lib_XReal_CauchyDist(long Target, long double* res, long double* xqp, long double* location, long double* scale)
//{
//    LibXReal_CauchyDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_XReal_Chi2Dist(long Target, long double* res, long double* xqp, long double* nu)
//{
//    LibXReal_Chi2Dist(Target, res, xqp, nu);
//}
//
//void Lib_XReal_ExponentialDist(long Target, long double* res, long double* xqp, long double* lambda)
//{
//    LibXReal_ExponentialDist(Target, res, xqp, lambda);
//}
//
//
//void Lib_XReal_GumbelDist(long Target, long double* res, long double* xqp, long double* location, long double* scale)
//{
//    LibXReal_ExtremeValueDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_XReal_FisherFDist(long Target, long double* res, long double* xqp, long double* mu, long double* nu)
//{
//    LibXReal_FisherFDist(Target, res, xqp, mu, nu);
//}
//
//
//void Lib_XReal_GammaDist(long Target, long double* res, long double* xqp, long double* shape, long double* scale)
//{
//    LibXReal_GammaDist(Target, res, xqp, shape, scale);
//}
//
//
//void Lib_XReal_GeometricDist(long Target, long double* res, long double* xqp, long double* p)
//{
//    LibXReal_GeometricDist(Target, res, xqp, p);
//}
//
//
//void Lib_XReal_HypergeometricDist(long Target, long double* res, long double* xqp, unsigned r, unsigned n, unsigned N)
//{
//    LibXReal_HypergeometricDist(Target, res, xqp, r, n, N);
//}
//
//
//void Lib_XReal_InverseChi2Dist(long Target, long double* res, long double* xqp, long double* df, long double* scale)
//{
//    LibXReal_InverseChi2Dist(Target, res, xqp, df, scale);
//}
//
//
//
//void Lib_XReal_InverseGammaDist(long Target, long double* res, long double* xqp, long double* shape, long double* scale)
//{
//    LibXReal_InverseGammaDist(Target, res, xqp, shape, scale);
//}
//
//
//void Lib_XReal_WaldDist(long Target, long double* res, long double* xqp, long double* mean_, long double* scale)
//{
//    LibXReal_InverseGaussianDist(Target, res, xqp, mean_, scale);
//}
//
//
//void Lib_XReal_LaplaceDist(long Target, long double* res, long double* xqp, long double* location, long double* scale)
//{
//    LibXReal_LaplaceDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_XReal_LogisticDist(long Target, long double* res, long double* xqp, long double* location, long double* scale)
//{
//    LibXReal_LogisticDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_XReal_LognormalDist(long Target, long double* res, long double* xqp, long double* location, long double* scale)
//{
//    LibXReal_LognormalDist(Target, res, xqp, location, scale);
//}
//
//
//void Lib_XReal_NegBinomialDist(long Target, long double* res, long double* xqp, long double* n, long double* p)
//{
//    LibXReal_NegBinomialDist(Target, res, xqp, n, p);
//}
//
//
//void Lib_XReal_Chi2NcDist(long Target, long double* res, long double* xqp, long double* nu, long double* nc)
//{
//    LibXReal_Chi2NCDist(Target, res, xqp, nu, nc);
//}
//
//
//void Lib_XReal_StudentTNcDist(long Target, long double* res, long double* xqp, long double* nu, long double* delta)
//{
//    LibXReal_StudentTNCDist(Target, res, xqp, nu, delta);
//}
//
//
//void Lib_XReal_FisherNcDist(long Target, long double* res, long double* xqp, long double* mu, long double* nu, long double* nc)
//{
//    LibXReal_FisherNCDist(Target, res, xqp, mu, nu, nc);
//}
//
//
//void Lib_XReal_BetaNcDist(long Target, long double* res, long double* xqp, long double* a, long double* b, long double* nc)
//{
//    LibXReal_BetaNCDist(Target, res, xqp, a, b, nc);
//}
//
//
//void Lib_XReal_NormalDist(long Target, long double* res, long double* xqp, long double* mean_, long double* stdev)
//{
//    LibXReal_NormalDist(Target, res, xqp, mean_, stdev);
//}
//
//
//void Lib_XReal_ParetoDist(long Target, long double* res, long double* xqp, long double* shape, long double* scale)
//{
//    LibXReal_ParetoDist(Target, res, xqp, shape, scale);
//}
//
//
//void Lib_XReal_PoissonDist(long Target, long double* res, long double* xqp, long double* nu)
//{
//    LibXReal_PoissonDist(Target, res, xqp, nu);
//}
//
//
//void Lib_XReal_RayleighDist(long Target, long double* res, long double* xqp, long double* nu)
//{
//    LibXReal_RayleighDist(Target, res, xqp, nu);
//}
//
//
//void Lib_XReal_SkewNormalDist(long Target, long double* res, long double* xqp, long double* mean_, long double* scale, long double* shape)
//{
//    LibXReal_SkewNormalDist(Target, res, xqp, mean_, scale, shape);
//}
//
//
//void Lib_XReal_StudentTDist(long Target, long double* res, long double* xqp, long double* nu)
//{
//    LibXReal_StudentTDist(Target, res, xqp, nu);
//}
//
//
//void Lib_XReal_TriangularDist(long Target, long double* res, long double* xqp, long double* lower, long double* mode_, long double* upper)
//{
//    LibXReal_TriangularDist(Target, res, xqp, lower, mode_, upper);
//}
//
//
//void Lib_XReal_WeibullDist(long Target, long double* res, long double* xqp, long double* shape, long double* scale)
//{
//    LibXReal_WeibullDist(Target, res, xqp, shape, scale);
//}
//
//
//void Lib_XReal_UniformDist(long Target, long double* res, long double* xqp, long double* lower, long double* upper)
//{
//    LibXReal_UniformDist(Target, res, xqp, lower, upper);
//}
//
//
//
//
//
//
////*********************** Extra **********************************
//
//
//
//
//void Lib_XReal_Pi(long double* res)
//{
//	LibXReal_Pi(res);
//}
//
//
//
//void Lib_XReal_E(long double* res)
//{
//	LibXReal_E(res);
//}
//
//
//void ShowExtNet(char* cstr, const long double* d)
//{
//    LibXReal_ShowExtNet(cstr, d);
//}
//
//
//
////*********************** Numerical Calculus **********************************
//
//
//
//
//
//void Lib_XReal_BracketRoot(long double* res1, long double* res2, int* iter, XRealFuncPtr f1, long double* guess, long double* factor, bool is_rising, int get_digits, unsigned int maxit)
//{
//    LibXReal_BracketRoot(res1, res2, iter, f1, guess, factor, is_rising, get_digits, maxit);
//}
//
//
//
//void Lib_XReal_NewtonRaphson(long double* res,  int* iter, XRealFuncPtr f1, XRealFuncPtr f2, long double* guess, long double* xmin, long double* xmax, int get_digits, unsigned int maxit)
//{
//    LibXReal_NewtonRaphson(res, iter, f1, f2, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_XReal_Halley(long double* res,  int* iter, XRealFuncPtr f1, XRealFuncPtr f2, XRealFuncPtr f3, long double* guess, long double* xmin, long double* xmax, int get_digits, unsigned int maxit)
//{
//    LibXReal_Halley(res, iter, f1, f2, f3, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_XReal_Schroder(long double* res,  int* iter, XRealFuncPtr f1, XRealFuncPtr f2, XRealFuncPtr f3, long double* guess, long double* xmin, long double* xmax, int get_digits, unsigned int maxit)
//{
//    LibXReal_Schroder(res, iter, f1, f2, f3, guess, xmin, xmax, get_digits, maxit);
//}
//
//
//
//void Lib_XReal_Brent_Minimum(long double* res, long double* resFx, int* iter, XRealFuncPtr f1, long double* bracket_min, long double* bracket_max, int bits, unsigned int maxit)
//{
//    LibXReal_Brent_Minimum(res, resFx, iter, f1, bracket_min, bracket_max, bits, maxit);
//}
//
//
//
//
//void Lib_XReal_Trapezoidal(long double* res1, long double* res2, long double* res3, XRealFuncPtr f1, long double* a, long double* b)
//{
//    LibXReal_Trapezoidal(res1, res2, res3, f1, a, b);
//}
//
//
//// 7, 15, 20, 25 and 30
//
//void Lib_XReal_GaussLegendre(long double* res1, long double* res3, XRealFuncPtr f1, long double* a, long double* b)
//{
//    LibXReal_GaussLegendre(res1, res3, f1, a, b);
//}
//
//
//
////15, 31, 41, 51 and 61
//
//void Lib_XReal_GaussKronrod(long double* res1, long double* res2, long double* res3, XRealFuncPtr f1, long double* a, long double* b)
//{
//    LibXReal_GaussKronrod(res1, res2, res3, f1, a, b);
//}
//
//
//
//void Lib_XReal_TanhSinh(long double* res1, long double* res2, long double* res3, int* levels_, XRealFuncPtr f1, long double* a, long double* b)
//{
//    LibXReal_TanhSinh(res1, res2, res3, levels_, f1, a, b);
//}
//
//
//
//void Lib_XReal_SinhSinh(long double* res1, long double* res2, long double* res3, int* levels_, XRealFuncPtr f1)
//{
//    LibXReal_SinhSinh(res1, res2, res3, levels_, f1);
//}
//
//
//
//void Lib_XReal_ExpSinh(long double* res1, long double* res2, long double* res3, int* levels_, XRealFuncPtr f1)
//{
//    LibXReal_ExpSinh(res1, res2, res3, levels_, f1);
//}
//
//
//
//void Lib_XReal_Ooura_Cos(long double* res1, long double* res2, XRealFuncPtr f1)
//{
//    LibXReal_Ooura_Cos(res1, res2, f1);
//}
//
//
//
//void Lib_XReal_Ooura_Sin(long double* res1, long double* res2, XRealFuncPtr f1)
//{
//    LibXReal_Ooura_Sin(res1, res2, f1);
//}
//
//
//
//
////*********************** Boost Odeint **********************************
//
//
//void Lib_XReal_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt)
//{
//	LibXReal_Const_RungeKutta4((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_XReal_Const_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt)
//{
//	LibXReal_Const_RungeKuttaCashKarp54((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_XReal_Const_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt)
//{
//	LibXReal_Const_RungeKuttaDopri5((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_XReal_Const_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt)
//{
//	LibXReal_Const_RungeKuttaFehlberg78((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//void Lib_XReal_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt)
//{
//	LibXReal_Const_AdamsBashforthMoulton((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt);
//}
//
//
//
//void Lib_XReal_Adaptive_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel)
//{
//	LibXReal_Adaptive_RungeKuttaDopri5((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_XReal_Adaptive_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel)
//{
//	LibXReal_Adaptive_RungeKuttaCashKarp54((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_XReal_Adaptive_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel)
//{
//	LibXReal_Adaptive_RungeKuttaFehlberg78((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_XReal_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel)
//{
//	LibXReal_Adaptive_BulirschStoer((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_XReal_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel)
//{
//	LibXReal_DenseOutput_Dopri5((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//void Lib_XReal_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX, long double* start_time, long double* end_time, long double* dt, long double* eps_abs, long double* eps_rel)
//{
//	LibXReal_DenseOutput_BulirschStoer((XAnyFuncPtr3)f1, (XAnyFuncPtr2)f2, (XStatePtr)matX, *start_time, *end_time, *dt, *eps_abs, *eps_rel);
//}
//
//
//
//
//






















