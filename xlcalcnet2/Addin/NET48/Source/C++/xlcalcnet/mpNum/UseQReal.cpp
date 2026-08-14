#define MPFR_WANT_FLOAT128
#include "Helperfunctions.h"
#include "mpNumC_Main.h"


#include "stdint.h"
#include <complex>
#include <limits>
#include <quadmath.h>


using namespace std;





/** ********************** Real Basic Functions, quadruple precision ******************************** **/


QRealPtr Lib_QReal_Init_Func()
{
	QRealPtr x = NULL;
	x = (__float128*)malloc(sizeof(__float128));
	(*(__float128*)x) = 0.0;
	return x;
}

void Lib_QReal_Clear(QRealPtr x)
{
	free(x);
}



/* Input and output  */


void Lib_QReal_Set(QRealPtr res, const QRealPtr x)
{
	(*(__float128*)res) = (*(__float128*)x);
}

void Lib_QReal_Set_Fmpq(QRealPtr res, const FmpqPtr x)
{
    mpfr_t temp; mpfr_init(temp);
	fmpq_get_mpfr (temp, (fmpq*)x, MPFR_RNDN);
	*(__float128*)res = mpfr_get_float128(temp, MPFR_RNDN);
    mpfr_clear(temp);
}

void Lib_QReal_Set_Arb(QRealPtr res, const ArbPtr x)
{
    mpfr_t temp; mpfr_init(temp);
	arf_get_mpfr(temp, arb_midref((arb_ptr)x), MPFR_RNDN);
    *(__float128*)res = mpfr_get_float128(temp, MPFR_RNDN);
	mpfr_clear(temp);
}

void Lib_QReal_Set_Mpfr(QRealPtr res, const MpfrPtr x)
{
    *(__float128*)res = mpfr_get_float128((mpfr_ptr)x, MPFR_RNDN);
}



void Lib_QReal_Set_Arf(QRealPtr res, const ArfPtr x)
{
    mpfr_t temp; mpfr_init(temp);
	arf_get_mpfr(temp, (arf_ptr)x, MPFR_RNDN);
    *(__float128*)res = mpfr_get_float128(temp, MPFR_RNDN);
	mpfr_clear(temp);
}




void Lib_QCplx_Set_Acb(QCplxPtr res, const AcbPtr x)
{
	slong wp = 170;  // 64 * 1.5
	mpc_t out1;
	mpc_init2(out1, wp);

    acb_get_mpc(out1, (acb_ptr)x);
    __real__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->re, MPFR_RNDN);
    __imag__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->im, MPFR_RNDN);

    mpc_clear(out1);
}




//
//
//void QCplx_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, QCplxPtr res, const int32_t in1)
//{
//	//printf("using QCplx_Acb_Cplxfunc0Int32_Prec:  ");
//	slong wp = 170;  // 113 * 1.5
//
//	mpc_t out1;
//	mpc_init2(out1, wp);
//
//    acb_t out1_acb;
//    acb_init(out1_acb);
//
//	f0Int32((acb_ptr)out1_acb, in1, wp);
//
//    acb_get_mpc(out1, out1_acb);
//    __real__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->re, MPFR_RNDN);
//    __imag__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->im, MPFR_RNDN);
//
//    acb_clear(out1_acb);
//    mpc_clear(out1);
//}
//


//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////




void mpfc_set_quadc(mpc_t out1, QCplxPtr in1)
{
	mpfr_set_float128 (out1->re, crealq(*(__complex128*)in1), MPFR_RNDN);
	mpfr_set_float128 (out1->im, cimagq(*(__complex128*)in1), MPFR_RNDN);
}




void QReal_Arb_Realfunc0Int32_Prec(ArbFuncPtr0Int32 f0Int32, QRealPtr res, const int32_t in1)
{
	//printf("using Arb_Arb_Realfunc0Int32_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpfr_t out1;
	mpfr_init2(out1, wp);
    arb_t out1_arb;
    arb_init(out1_arb);

	f0Int32((arb_ptr)out1_arb, in1, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *(__float128*)res = mpfr_get_float128((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb);
    mpfr_clear(out1);
}






void QReal_Arb_Realfunc1_Prec(ArbFuncPtr1 f1, QRealPtr res, const QRealPtr x1)
{
	//printf("using QReal_Arb_Realfunc1_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpfr_t out1, in1;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp);
    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);

	mpfr_set_float128 ((mpfr_ptr)in1, *(__float128*)x1, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);

	f1(out1_arb, in1_arb, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *(__float128*)res = mpfr_get_float128((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb);
    mpfr_clear(out1); mpfr_clear(in1);
}



void QReal_Arb_Realfunc1Int32_Prec(ArbFuncPtr1Int32 f1Int32, QRealPtr res, const QRealPtr x1, const int32_t in2)
{
	//printf("using QReal_Arb_Realfunc1Int32_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpfr_t out1, in1;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp);
    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);

	mpfr_set_float128 ((mpfr_ptr)in1, *(__float128*)x1, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);

	f1Int32(out1_arb, in1_arb, in2, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *(__float128*)res = mpfr_get_float128((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb);
    mpfr_clear(out1); mpfr_clear(in1);
}



void QReal_Arb_Realfunc2_Prec(ArbFuncPtr2 f2, QRealPtr res, const QRealPtr x1, const QRealPtr x2)
{
	//printf("using QReal_Arb_Realfunc2_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpfr_t out1, in1, in2;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp); mpfr_init2(in2, wp);
    arb_t out1_arb, in1_arb, in2_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb);
	mpfr_set_float128 ((mpfr_ptr)in1, *(__float128*)x1, MPFR_RNDN);
	mpfr_set_float128 ((mpfr_ptr)in2, *(__float128*)x2, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);
    arf_set_mpfr(arb_midref(in2_arb), in2);

	f2(out1_arb, in1_arb, in2_arb, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *(__float128*)res = mpfr_get_float128((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb);
    mpfr_clear(out1); mpfr_clear(in1); mpfr_clear(in2);
}



void QReal_Arb_Realfunc3_Prec(ArbFuncPtr3 f3, QRealPtr res, const QRealPtr x1, const QRealPtr x2, const QRealPtr x3)
{
	//printf("using QReal_Arb_Realfunc3_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpfr_t out1, in1, in2, in3;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp); mpfr_init2(in2, wp); mpfr_init2(in3, wp);
    arb_t out1_arb, in1_arb, in2_arb, in3_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb);
	mpfr_set_float128 ((mpfr_ptr)in1, *(__float128*)x1, MPFR_RNDN);
	mpfr_set_float128 ((mpfr_ptr)in2, *(__float128*)x2, MPFR_RNDN);
	mpfr_set_float128 ((mpfr_ptr)in3, *(__float128*)x3, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);
    arf_set_mpfr(arb_midref(in2_arb), in2);
    arf_set_mpfr(arb_midref(in3_arb), in3);

	f3(out1_arb, in1_arb, in2_arb, in3_arb, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *(__float128*)res = mpfr_get_float128((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb);
    mpfr_clear(out1); mpfr_clear(in1); mpfr_clear(in2); mpfr_clear(in3);
}



void QReal_Arb_Realfunc4_Prec(ArbFuncPtr4 f4, QRealPtr res, const QRealPtr x1, const QRealPtr x2, const QRealPtr x3, const QRealPtr x4)
{
	//printf("using QReal_Arb_Realfunc4_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpfr_t out1, in1, in2, in3, in4;
	mpfr_init2(out1, wp); mpfr_init2(in1, wp); mpfr_init2(in2, wp); mpfr_init2(in3, wp); mpfr_init2(in4, wp);
    arb_t out1_arb, in1_arb, in2_arb, in3_arb, in4_arb;
    arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb); arb_init(in4_arb);
	mpfr_set_float128 ((mpfr_ptr)in1, *(__float128*)x1, MPFR_RNDN);
	mpfr_set_float128 ((mpfr_ptr)in2, *(__float128*)x2, MPFR_RNDN);
	mpfr_set_float128 ((mpfr_ptr)in3, *(__float128*)x3, MPFR_RNDN);
	mpfr_set_float128 ((mpfr_ptr)in4, *(__float128*)x4, MPFR_RNDN);
    arf_set_mpfr(arb_midref(in1_arb), in1);
    arf_set_mpfr(arb_midref(in2_arb), in2);
    arf_set_mpfr(arb_midref(in3_arb), in3);
    arf_set_mpfr(arb_midref(in4_arb), in4);

	f4(out1_arb, in1_arb, in2_arb, in3_arb, in4_arb, wp);

    arf_get_mpfr(out1, arb_midref(out1_arb), MPFR_RNDN);
    *(__float128*)res = mpfr_get_float128((mpfr_ptr)out1, MPFR_RNDN);
    arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb); arb_clear(in4_arb);
    mpfr_clear(out1); mpfr_clear(in1); mpfr_clear(in2); mpfr_clear(in3); mpfr_clear(in4);
}



void QCplx_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, QCplxPtr res, const int32_t in1)
{
	//printf("using QCplx_Acb_Cplxfunc0Int32_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpc_t out1;
	mpc_init2(out1, wp);

    acb_t out1_acb;
    acb_init(out1_acb);

	f0Int32((acb_ptr)out1_acb, in1, wp);

    acb_get_mpc(out1, out1_acb);
    __real__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->re, MPFR_RNDN);
    __imag__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->im, MPFR_RNDN);

    acb_clear(out1_acb);
    mpc_clear(out1);
}



void QCplx_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, QCplxPtr res, const QCplxPtr x1)
{
	//printf("using QCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpc_t out1, in1;
	mpc_init2(out1, wp); mpc_init2(in1, wp);
	mpfc_set_quadc(in1, x1);

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_mpc(in1_acb, in1);

	f1(out1_acb, in1_acb, wp);

    acb_get_mpc(out1, out1_acb);
    __real__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->re, MPFR_RNDN);
    __imag__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->im, MPFR_RNDN);

    acb_clear(out1_acb); acb_clear(in1_acb);
    mpc_clear(out1); mpc_clear(in1);
}



void QCplx_Acb_Cplxfunc1Int32_Prec(AcbFuncPtr1Int32 f1Int32, QCplxPtr res, const QCplxPtr x1, const int32_t in2)
{
	//printf("using QCplx_Acb_Cplxfunc1_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpc_t out1, in1;
	mpc_init2(out1, wp); mpc_init2(in1, wp);
	mpfc_set_quadc(in1, x1);

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_mpc(in1_acb, in1);

	//f1(out1_acb, in1_acb, wp);
	f1Int32((acb_ptr)out1_acb, (acb_ptr)in1_acb, in2, wp);

    acb_get_mpc(out1, out1_acb);
    __real__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->re, MPFR_RNDN);
    __imag__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->im, MPFR_RNDN);

    acb_clear(out1_acb); acb_clear(in1_acb);
    mpc_clear(out1); mpc_clear(in1);
}



void QCplx_Acb_Cplxfunc2_Prec(AcbFuncPtr2 f2, QCplxPtr res, const QCplxPtr x1, const QCplxPtr x2)
{
	//printf("using QCplx_Acb_Cplxfunc2_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpc_t out1, in1, in2;
	mpc_init2(out1, wp); mpc_init2(in1, wp); mpc_init2(in2, wp);
	mpfc_set_quadc(in1, x1); mpfc_set_quadc(in2, x2);

    acb_t out1_acb, in1_acb, in2_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2);

	f2(out1_acb, in1_acb, in2_acb, wp);

    acb_get_mpc(out1, out1_acb);
    __real__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->re, MPFR_RNDN);
    __imag__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->im, MPFR_RNDN);

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb);
    mpc_clear(out1); mpc_clear(in1); mpc_clear(in2);
}



void QCplx_Acb_Cplxfunc3_Prec(AcbFuncPtr3 f3, QCplxPtr res, const QCplxPtr x1, const QCplxPtr x2, const QCplxPtr x3)
{
	//printf("using QCplx_Acb_Cplxfunc3_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpc_t out1, in1, in2, in3;
	mpc_init2(out1, wp); mpc_init2(in1, wp); mpc_init2(in2, wp); mpc_init2(in3, wp);
	mpfc_set_quadc(in1, x1); mpfc_set_quadc(in2, x2); mpfc_set_quadc(in3, x3);

    acb_t out1_acb, in1_acb, in2_acb, in3_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2); acb_set_mpc(in3_acb, in3);

	f3(out1_acb, in1_acb, in2_acb, in3_acb, wp);

    acb_get_mpc(out1, out1_acb);
    __real__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->re, MPFR_RNDN);
    __imag__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->im, MPFR_RNDN);

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb);
    mpc_clear(out1); mpc_clear(in1); mpc_clear(in2); mpc_clear(in3);
}



void QCplx_Acb_Cplxfunc4_Prec(AcbFuncPtr4 f4, QCplxPtr res, const QCplxPtr x1, const QCplxPtr x2, const QCplxPtr x3, const QCplxPtr x4)
{
	//printf("using QCplx_Acb_Cplxfunc4_Prec:  ");
	slong wp = 170;  // 113 * 1.5

	mpc_t out1, in1, in2, in3, in4;
	mpc_init2(out1, wp); mpc_init2(in1, wp); mpc_init2(in2, wp); mpc_init2(in3, wp); mpc_init2(in4, wp);
	mpfc_set_quadc(in1, x1); mpfc_set_quadc(in2, x2); mpfc_set_quadc(in3, x3); mpfc_set_quadc(in4, x4);

    acb_t out1_acb, in1_acb, in2_acb, in3_acb, in4_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb); acb_init(in4_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2); acb_set_mpc(in3_acb, in3); acb_set_mpc(in4_acb, in4);

	f4(out1_acb, in1_acb, in2_acb, in3_acb, in4_acb, wp);

    acb_get_mpc(out1, out1_acb);
    __real__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->re, MPFR_RNDN);
    __imag__ (*(__complex128*)res) = mpfr_get_float128((mpfr_ptr)out1->im, MPFR_RNDN);

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb); acb_clear(in4_acb);
    mpc_clear(out1); mpc_clear(in1); mpc_clear(in2); mpc_clear(in3); mpc_clear(in4);
}





//
//
//
////**********************
//
//
//
//void Lib_QReal_Arb_Exp(QRealPtr res, const QRealPtr x)
//{
//    QReal_Arb_Realfunc1_Prec(arb_exp, res, x);
//}
//
//
//void Lib_QReal_Arb_Sin(QRealPtr res, const QRealPtr x)
//{
//    QReal_Arb_Realfunc1_Prec(arb_sin, res, x);
//}
//
//
//
//
//
////**********************
//
//
//
//void Lib_QReal_Arb_Pow(QRealPtr res, const QRealPtr x, const QRealPtr y)
//{
//    QReal_Arb_Realfunc2_Prec(arb_pow, res, x, y);
//}
//
//
//
//
////**********************
//
//
//
//void Lib_QReal_Arb_Hyp1f1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
//{
//    QReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1_, res, a, b, z);
//}
//
//
//
//
////**********************
//
//
//
//
//void Lib_QReal_Arb_Hyp2f1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z)
//{
//    QReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1_, res, a, b, c, z);
//}
//
//
///* **************************** */
//
//
//





/* Roots and quadratic, cubic, and quartic equations */


void Lib_QReal_Arb_Sqrt(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sqrt, res, x);
}


void Lib_QReal_Arb_Rsqrt(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_rsqrt, res, x);
}


void Lib_QReal_Arb_Cbrt(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_cbrt, res, x);
}


void Lib_QReal_Arb_Sqrt1pm1(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sqrt1pm1, res, x);
}


void Lib_QReal_Arb_Root_ui(QRealPtr res, const QRealPtr x, const int32_t n)
{
    QReal_Arb_Realfunc1Int32_Prec(arb_root_ui_, res, x, n);
}


void Lib_QReal_Arb_Root_si(QRealPtr res, const QRealPtr x, const int32_t n)
{
    QReal_Arb_Realfunc1Int32_Prec(arb_root_si_, res, x, n);
}





/* Exponential and related functions */



void Lib_QReal_Arb_Exp(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_exp, res, x);
}


void Lib_QReal_Arb_Expm1(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_expm1, res, x);
}


void Lib_QReal_Arb_Exp10(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_exp10_, res, x);
}


void Lib_QReal_Arb_Exp2(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_exp2_, res, x);
}


void Lib_QReal_Arb_Exp10m1(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_exp10m1_, res, x);
}


void Lib_QReal_Arb_Exp2m1(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_exp2m1_, res, x);
}


void Lib_QReal_Arb_ExpRel(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_exprel_, res, x);
}




/* Logarithms and related functions */



void Lib_QReal_Arb_Log(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_log, res, x);
}


void Lib_QReal_Arb_Logbase(QRealPtr res, const QRealPtr x, const QRealPtr b)
{
    QReal_Arb_Realfunc2_Prec(arb_logbase_, res, x, b);
}


void Lib_QReal_Arb_Log10(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_log10, res, x);
}


void Lib_QReal_Arb_Log2(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_log2, res, x);
}


void Lib_QReal_Arb_Log1p(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_log1p, res, x);
}


void Lib_QReal_Arb_Log10p1(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_log10p1_, res, x);
}


void Lib_QReal_Arb_Log2p1(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_log2p1_, res, x);
}


void Lib_QReal_Arb_Log1mexp(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_log1mexp_, res, x);
}


void Lib_QReal_Arb_LambertW0(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_lambertw0, res, x);
}


void Lib_QReal_Arb_LambertWm1(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_lambertwm1, res, x);
}






/* Power functions */


void Lib_QReal_Arb_Square(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sqr, res, x);
}


void Lib_QReal_Arb_Cube(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_cube_, res, x);
}


void Lib_QReal_Arb_Pow_ui(QRealPtr res, const QRealPtr x, const int32_t n)
{
    QReal_Arb_Realfunc1Int32_Prec(arb_pow_ui_, res, x, n);
}


void Lib_QReal_Arb_Pow_si(QRealPtr res, const QRealPtr x, const int32_t n)
{
    QReal_Arb_Realfunc1Int32_Prec(arb_pow_si_, res, x, n);
}


void Lib_QReal_Arb_Compound_si(QRealPtr res, const QRealPtr x, const int32_t n)
{
    QReal_Arb_Realfunc1Int32_Prec(arb_compound_si_, res, x, n);
}



void Lib_QReal_Arb_Hypot(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypot, res, x, y);
}


void Lib_QReal_Arb_Pow(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_pow, res, x, y);
}


void Lib_QReal_Arb_Powm1(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_powm1_, res, x, y);
}


void Lib_QReal_Arb_Pow1p(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_pow1p_, res, x, y);
}


void Lib_QReal_Arb_Pow1pm1(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_pow1pm1_, res, x, y);
}





/* Trigonometric and related functions */


void Lib_QReal_Arb_Sin(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sin, res, x);
}


void Lib_QReal_Arb_Cos(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_cos, res, x);
}


void Lib_QReal_Arb_Tan(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_tan, res, x);
}



void Lib_QReal_Arb_Csc(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_csc, res, x);
}


void Lib_QReal_Arb_Sec(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sec, res, x);
}


void Lib_QReal_Arb_Cot(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_cot, res, x);
}


void Lib_QReal_Arb_Sinc(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sinc, res, x);
}


void Lib_QReal_Arb_SincPi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sinc_pi, res, x);
}


void Lib_QReal_Arb_SinPi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sin_pi, res, x);
}


void Lib_QReal_Arb_CosPi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_cos_pi, res, x);
}


void Lib_QReal_Arb_TanPi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_tan_pi, res, x);
}


void Lib_QReal_Arb_CotPi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_cot_pi, res, x);
}




/* Hyperbolic functions */


void Lib_QReal_Arb_Sinh(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sinh, res, x);
}


void Lib_QReal_Arb_Cosh(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_cosh, res, x);
}


void Lib_QReal_Arb_Tanh(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_tanh, res, x);
}



void Lib_QReal_Arb_Csch(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_csch, res, x);
}


void Lib_QReal_Arb_Sech(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_sech, res, x);
}


void Lib_QReal_Arb_Coth(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_coth, res, x);
}





/* Inverse trigonometric functions */


void Lib_QReal_Arb_Asin(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_asin, res, x);
}


void Lib_QReal_Arb_Acos(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_acos, res, x);
}



void Lib_QReal_Arb_Atan2(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_atan2, res, x, y);
}


void Lib_QReal_Arb_Atan(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_atan, res, x);
}



void Lib_QReal_Arb_Acsc(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_acsc, res, x);
}


void Lib_QReal_Arb_Asec(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_asec, res, x);
}


void Lib_QReal_Arb_Acot(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_QReal_Arb_Asinh(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_asinh, res, x);
}


void Lib_QReal_Arb_Acosh(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_acosh, res, x);
}


void Lib_QReal_Arb_Atanh(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_atanh, res, x);
}



void Lib_QReal_Arb_Acsch(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_acsch, res, x);
}


void Lib_QReal_Arb_Asech(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_asech, res, x);
}


void Lib_QReal_Arb_Acoth(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_acoth, res, x);
}







/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_QReal_Arb_MEllipticK(QRealPtr res, const QRealPtr m)
{
    QReal_Arb_Realfunc1_Prec(arb_elliptic_k, res, m);
}


void Lib_QReal_Arb_MEllipticE(QRealPtr res, const QRealPtr m)
{
    QReal_Arb_Realfunc1_Prec(arb_elliptic_e, res, m);
}


void Lib_QReal_Arb_MEllipticPi(QRealPtr res, const QRealPtr n, const QRealPtr m)
{
    QReal_Arb_Realfunc2_Prec(arb_elliptic_pi, res, n, m);
}


void Lib_QReal_Arb_MEllipticF(QRealPtr res, const QRealPtr phi, const QRealPtr m)
{
    QReal_Arb_Realfunc2_Prec(arb_elliptic_f_, res, phi, m);
}


void Lib_QReal_Arb_MEllipticEInc(QRealPtr res, const QRealPtr phi, const QRealPtr m)
{
    QReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_, res, phi, m);
}


void Lib_QReal_Arb_MEllipticPiInc(QRealPtr res, const QRealPtr n, const QRealPtr phi, const QRealPtr m)
{
    QReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_, res, n, phi, m);
}




/* Legendre elliptic integrals (elliptic modulus k), and related functions */




void Lib_QReal_Arb_EllipticK(QRealPtr res, const QRealPtr k)
{
    QReal_Arb_Realfunc1_Prec(arb_elliptic_k_k_, res, k);
}


void Lib_QReal_Arb_EllipticE(QRealPtr res, const QRealPtr k)
{
    QReal_Arb_Realfunc1_Prec(arb_elliptic_e_k_, res, k);
}


void Lib_QReal_Arb_EllipticPi(QRealPtr res, const QRealPtr n, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(arb_elliptic_pi_k_, res, n, k);
}


void Lib_QReal_Arb_EllipticF(QRealPtr res, const QRealPtr phi, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(arb_elliptic_f_k_, res, phi, k);
}


void Lib_QReal_Arb_EllipticEInc(QRealPtr res, const QRealPtr phi, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_k_, res, phi, k);
}


void Lib_QReal_Arb_EllipticPiInc(QRealPtr res, const QRealPtr n, const QRealPtr phi, const QRealPtr k)
{
    QReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_k_, res, n, phi, k);
}


void Lib_QReal_Arb_Agm(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */


void Lib_QReal_Arb_Elliptic_RC(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_elliptic_rc_, res, x, y);
}


void Lib_QReal_Arb_Elliptic_RF(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_elliptic_rf_, res, x, y, z);
}


void Lib_QReal_Arb_Elliptic_RG(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_elliptic_rg_, res, x, y, z);
}


void Lib_QReal_Arb_Elliptic_RD(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_elliptic_rd_, res, x, y, z);
}


void Lib_QReal_Arb_Elliptic_RJ(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z, const QRealPtr w)
{
    QReal_Arb_Realfunc4_Prec(arb_elliptic_rj_, res, x, y, z, w);
}





/* Jacobi theta functions */


void Lib_QReal_Arb_Theta1Q(QRealPtr res, const QRealPtr z, const QRealPtr q)
{
    QReal_Arb_Realfunc2_Prec(_arb_theta1q, res, z, q);
}


void Lib_QReal_Arb_Theta2Q(QRealPtr res, const QRealPtr z, const QRealPtr q)
{
    QReal_Arb_Realfunc2_Prec(_arb_theta2q, res, z, q);
}


void Lib_QReal_Arb_Theta3Q(QRealPtr res, const QRealPtr z, const QRealPtr q)
{
    QReal_Arb_Realfunc2_Prec(_arb_theta3q, res, z, q);
}


void Lib_QReal_Arb_Theta4Q(QRealPtr res, const QRealPtr z, const QRealPtr q)
{
    QReal_Arb_Realfunc2_Prec(_arb_theta4q, res, z, q);
}




/* Jacobi elliptic functions */



void Lib_QReal_Arb_JacobiSN(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_sn, res, u, k);
}


void Lib_QReal_Arb_JacobiCN(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_cn, res, u, k);
}


void Lib_QReal_Arb_JacobiDN(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_dn, res, u, k);
}


void Lib_QReal_Arb_JacobiNS(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_ns, res, u, k);
}


void Lib_QReal_Arb_JacobiNC(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_nc, res, u, k);
}


void Lib_QReal_Arb_JacobiND(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_nd, res, u, k);
}


void Lib_QReal_Arb_JacobiSC(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_sc, res, u, k);
}


void Lib_QReal_Arb_JacobiSD(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_sd, res, u, k);
}


void Lib_QReal_Arb_JacobiDC(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_dc, res, u, k);
}


void Lib_QReal_Arb_JacobiDS(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_ds, res, u, k);
}


void Lib_QReal_Arb_JacobiCS(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_cs, res, u, k);
}


void Lib_QReal_Arb_JacobiCD(QRealPtr res, const QRealPtr u, const QRealPtr k)
{
    QReal_Arb_Realfunc2_Prec(_arb_jacobi_cd, res, u, k);
}





/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */



void Lib_QReal_Arb_LerchPhi(QRealPtr res, const QRealPtr z, const QRealPtr s, const QRealPtr a)
{
    QReal_Arb_Realfunc3_Prec(arb_dirichlet_lerch_phi, res, z, s, a);
}





/* Polygamma functions */


void Lib_QReal_Arb_Polygamma(QRealPtr res, const QRealPtr s, const QRealPtr z)
{
    QReal_Arb_Realfunc2_Prec(arb_polygamma, res, s, z);
}


void Lib_QReal_Arb_Digamma(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_digamma, res, x);
}



/* Polylogarithms and related functions */




void Lib_QReal_Arb_Polylog(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_polylog, res, x, y);
}


void Lib_QReal_Arb_Dilog(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_dilog, res, x);
}



/* Hurwitz zeta function and related functions */


void Lib_QReal_Arb_HurwitzZeta(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hurwitz_zeta, res, x, y);
}



void Lib_QReal_Arb_Bernoulli_ui(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_bernoulli_ui_, res, n);
}


void Lib_QReal_Arb_Euler_ui(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_euler_number_ui_, res, n);
}



void Lib_QReal_Arb_BernoulliPoly_ui(QRealPtr res, const QRealPtr x, const int32_t n)
{
    QReal_Arb_Realfunc1Int32_Prec(arb_bernoulli_poly_ui_, res, x, n);
}



void Lib_QReal_Arb_BarnesG(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_barnes_g, res, x);
}


void Lib_QReal_Arb_LogBarnesG(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */



void Lib_QReal_Arb_Zeta(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_zeta, res, x);
}



void Lib_QReal_Arb_BacklundS(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(acb_dirichlet_backlund_s, res, x);
}


void Lib_QReal_Arb_GramPoint_ui(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_gram_point_ui_, res, n);
}







/* Additional numbertheoretic functions */


void Lib_QReal_Arb_Bell_ui(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_bell_ui_, res, n);
}


void Lib_QReal_Arb_Partitions_ui(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_partitions_ui_, res, n);
}


void Lib_QReal_Arb_Primorial_ui(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_primorial_nth_ui_, res, n);
}






/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_QReal_Arb_Hypgeom0F1(QRealPtr res, const QRealPtr a, const QRealPtr x)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_, res, a, x);
}


void Lib_QReal_Arb_Hypgeom0F1r(QRealPtr res, const QRealPtr a, const QRealPtr x)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */


void Lib_QReal_Arb_BesselJ(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_j, res, x, y);
}


void Lib_QReal_Arb_BesselY(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_y, res, x, y);
}


void Lib_QReal_Arb_BesselI(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i, res, x, y);
}


void Lib_QReal_Arb_BesselK(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k, res, x, y);
}


void Lib_QReal_Arb_BesselIScaled(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_QReal_Arb_BesselKScaled(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k_scaled, res, x, y);
}



/* Spherical Bessel functions  */





/* Airy functions  */



void Lib_QReal_Arb_AiryAi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_airy_ai, res, x);
}


void Lib_QReal_Arb_AiryAiPrime(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_airy_ai_prime, res, x);
}


void Lib_QReal_Arb_AiryBi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_airy_bi, res, x);
}


void Lib_QReal_Arb_AiryBiPrime(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_airy_bi_prime, res, x);
}




void Lib_QReal_Arb_AiryAiZero(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_zero, res, n);
}


void Lib_QReal_Arb_AiryAiPrimeZero(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_prime_zero, res, n);
}


void Lib_QReal_Arb_AiryBiZero(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_zero, res, n);
}


void Lib_QReal_Arb_AiryBiPrimeZero(QRealPtr res, const int32_t n)
{
    QReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_prime_zero, res, n);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


void Lib_QReal_Arb_Hypgeom1F1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1_, res, a, b, z);
}


void Lib_QReal_Arb_Hypgeom1F1r(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_QReal_Arb_HypgeomU(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_u, res, a, b, z);
}






/* Gamma function and related functions */


void Lib_QReal_Arb_Gamma(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_gamma, res, x);
}


void Lib_QReal_Arb_Rgamma(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_rgamma, res, x);
}


void Lib_QReal_Arb_Lgamma(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_lgamma, res, x);
}


void Lib_QReal_Arb_RisingFactorial(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_rising, res, x, y);
}


void Lib_QReal_Arb_Beta(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_beta_, res, x, y);
}





/* Incomplete gamma functions */



void Lib_QReal_Arb_GammaUpper(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_gamma_upper_, res, x, y);
}


void Lib_QReal_Arb_GammaUpperR(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_gamma_upper_r, res, x, y);
}


void Lib_QReal_Arb_GammaLower(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_gamma_lower_, res, x, y);
}
//
//
//void Lib_QReal_Arb_GammaLowerR(QRealPtr res, const QRealPtr x, const QRealPtr y)
//{
//    QReal_Arb_Realfunc2_Prec(arb_gamma_lower_r, res, x, y);
//}



void Lib_QReal_Arb_GammaPPrime(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_gamma_p_derivative, res, x, y);
}


void Lib_QReal_Arb_GammaP(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_gamma_p, res, x, y);
}


void Lib_QReal_Arb_GammaQ(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_gamma_q, res, x, y);
}





/* Error function and related functions */


void Lib_QReal_Arb_Erf(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_erf, res, x);
}


void Lib_QReal_Arb_Erfc(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_erfc, res, x);
}


void Lib_QReal_Arb_ErfInv(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_erfinv, res, x);
}


void Lib_QReal_Arb_ErfcInv(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_erfcinv, res, x);
}


void Lib_QReal_Arb_Erfi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_erfi, res, x);
}


void Lib_QReal_Arb_FresnelC(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_fresnelc, res, x);
}


void Lib_QReal_Arb_FresnelS(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_fresnels, res, x);
}


void Lib_QReal_Arb_Ndens(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_ndens, res, x);
}


void Lib_QReal_Arb_Ndis(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_ndis, res, x);
}







/* Exponential integrals and related functions */



void Lib_QReal_Arb_ExpIntegralE(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_expint, res, x, y);
}



void Lib_QReal_Arb_ExpIntegralEi(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_ei, res, x);
}


void Lib_QReal_Arb_SinIntegral(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_si, res, x);
}


void Lib_QReal_Arb_CosIntegral(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_ci, res, x);
}


void Lib_QReal_Arb_SinhIntegral(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_shi, res, x);
}


void Lib_QReal_Arb_CoshIntegral(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_chi, res, x);
}


void Lib_QReal_Arb_LogIntegral(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_li_, res, x);
}


void Lib_QReal_Arb_LogIntegralOffset(QRealPtr res, const QRealPtr x)
{
    QReal_Arb_Realfunc1_Prec(arb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_QReal_Arb_HermiteH(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_hermite_h, res, x, y);
}


void Lib_QReal_Arb_LaguerreL(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_laguerre_l, res, a, b, z);
}




/* 1F1: Coulomb functions */


void Lib_QReal_Arb_CoulombF(QRealPtr res, const QRealPtr l, const QRealPtr eta, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_QReal_Arb_CoulombG(QRealPtr res, const QRealPtr l, const QRealPtr eta, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_g, res, l, eta, z);
}






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_QReal_Arb_Hypgeom2F1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z)
{
    QReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_QReal_Arb_Hypgeom2F1r(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z)
{
    QReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1r_, res, a, b, c, z);
}





/* 2F1: Orthogonal polynomials */


void Lib_QReal_Arb_ChebyshevT(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_QReal_Arb_ChebyshevU(QRealPtr res, const QRealPtr x, const QRealPtr y)
{
    QReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_QReal_Arb_GegenbauerC(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_QReal_Arb_LegendreP(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_QReal_Arb_LegendrePv(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_QReal_Arb_LegendreQ(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_QReal_Arb_LegendreQv(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_qv_, res, a, b, z);
}


void Lib_QReal_Arb_JacobiP(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr c, const QRealPtr z)
{
    QReal_Arb_Realfunc4_Prec(arb_hypgeom_jacobi_p, res, a, b, c, z);
}





/* 2F1: Incomplete Beta Function */


void Lib_QReal_Arb_BetaLower(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_, res, a, b, z);
}


//void Lib_QReal_Arb_BetaLowerR(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
//{
//    QReal_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_r_, res, a, b, z);
//}



void Lib_QReal_Arb_Ibeta(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_ibeta, res, a, b, z);
}


void Lib_QReal_Arb_Ibetac(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_ibetac, res, a, b, z);
}



void Lib_QReal_Arb_IbetaPrime(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr z)
{
    QReal_Arb_Realfunc3_Prec(arb_ibeta_derivative, res, a, b, z);
}






/* Hypergeometric Function 1F2, overview */


void Lib_QReal_Arb_Hypgeom1F2(QRealPtr res, const QRealPtr a1, const QRealPtr b1, const QRealPtr b2, const QRealPtr z)
{
    QReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_QReal_Arb_Hypgeom1F2r(QRealPtr res, const QRealPtr a1, const QRealPtr b1, const QRealPtr b2, const QRealPtr z)
{
    QReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2r_, res, a1, b1, b2, z);
}


















////////////////////////////////////////////////////////
////// Acb functions
////////////////////////////////////////////////////////


//
//
//void Lib_QCplx_Acb_Exp(QCplxPtr res, const QCplxPtr x)
//{
//    QCplx_Acb_Cplxfunc1_Prec(acb_exp, res, x);
//}
//
//void Lib_QCplx_Acb_Sin(QCplxPtr res, const QCplxPtr x)
//{
//    QCplx_Acb_Cplxfunc1_Prec(acb_sin, res, x);
//}
//
//
//
//
//
//
//
////**********************
//
//
//
//void Lib_QCplx_Acb_Pow(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
//{
//    QCplx_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
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
////**********************
//
//
//void Lib_QCplx_Acb_Hyp1f1(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
//{
//    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
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
////**********************
//
//
//void Lib_QCplx_Acb_Hyp2f1(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z)
//{
//    QCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
//}
//
//

/* ************************************* */








/* Roots and quadratic, cubic, and quartic equations */


void Lib_QCplx_Acb_UnitRoot_ui(QCplxPtr res, const int32_t n)
{
    QCplx_Acb_Cplxfunc0Int32_Prec(acb_unit_root_, res, n);
}


void Lib_QCplx_Acb_Sqrt(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sqrt, res, x);
}


void Lib_QCplx_Acb_Rsqrt(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_rsqrt, res, x);
}


void Lib_QCplx_Acb_Cbrt(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_cbrt, res, x);
}


void Lib_QCplx_Acb_Sqrt1pm1(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sqrt1pm1, res, x);
}


void Lib_QCplx_Acb_Root_ui(QCplxPtr res, const QCplxPtr x, const int32_t n)
{
    QCplx_Acb_Cplxfunc1Int32_Prec(acb_root_ui_, res, x, n);
}






/* Exponential and related functions */


void Lib_QCplx_Acb_Exp(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_exp, res, x);
}


void Lib_QCplx_Acb_Expj(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_expj_, res, x);
}


void Lib_QCplx_Acb_Expjpi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_exp_pi_i, res, x);
}


void Lib_QCplx_Acb_Expm1(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_expm1, res, x);
}


void Lib_QCplx_Acb_Exp10(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_exp10_, res, x);
}


void Lib_QCplx_Acb_Exp2(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_exp2_, res, x);
}


void Lib_QCplx_Acb_Exp10m1(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_exp10m1_, res, x);
}


void Lib_QCplx_Acb_Exp2m1(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_exp2m1_, res, x);
}


void Lib_QCplx_Acb_ExpRel(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_exprel_, res, x);
}






/* Logarithms and related functions */



void Lib_QCplx_Acb_Log(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_log, res, x);
}


void Lib_QCplx_Acb_Logbase(QCplxPtr res, const QCplxPtr x, const QCplxPtr b)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_logbase_, res, x, b);
}


void Lib_QCplx_Acb_Log1p(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_log1p, res, x);
}


void Lib_QCplx_Acb_Log10(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_log10_, res, x);
}


void Lib_QCplx_Acb_Log2(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_log2_, res, x);
}


void Lib_QCplx_Acb_Log10p1(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_log10p1_, res, x);
}



void Lib_QCplx_Acb_Log2p1(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_log2p1_, res, x);
}




void Lib_QCplx_Acb_LambertW_ui(QCplxPtr res, const QCplxPtr x, const int32_t n)
{
    QCplx_Acb_Cplxfunc1Int32_Prec(acb_lambertw_ui_, res, x, n);
}







/* Power functions */


void Lib_QCplx_Acb_Square(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sqr, res, x);
}


void Lib_QCplx_Acb_Cube(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_cube, res, x);
}


void Lib_QCplx_Acb_Pow_si(QCplxPtr res, const QCplxPtr x, const int32_t n)
{
    QCplx_Acb_Cplxfunc1Int32_Prec(acb_pow_si_, res, x, n);
}



void Lib_QCplx_Acb_Hypot(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypot_, res, x, y);
}


void Lib_QCplx_Acb_Pow(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
}


void Lib_QCplx_Acb_Powm1(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_powm1_, res, x, y);
}


void Lib_QCplx_Acb_Pow1p(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_pow1p_, res, x, y);
}


void Lib_QCplx_Acb_Pow1pm1(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_pow1pm1_, res, x, y);
}







/* Trigonometric and related functions */



void Lib_QCplx_Acb_Sin(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sin, res, x);
}


void Lib_QCplx_Acb_Cos(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_cos, res, x);
}


void Lib_QCplx_Acb_Tan(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_tan, res, x);
}



void Lib_QCplx_Acb_Csc(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_csc, res, x);
}


void Lib_QCplx_Acb_Sec(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sec, res, x);
}


void Lib_QCplx_Acb_Cot(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_cot, res, x);
}





/* Hyperbolic functions */


void Lib_QCplx_Acb_Sinh(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sinh, res, x);
}


void Lib_QCplx_Acb_Cosh(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_cosh, res, x);
}


void Lib_QCplx_Acb_Tanh(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_tanh, res, x);
}



void Lib_QCplx_Acb_Csch(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_csch, res, x);
}


void Lib_QCplx_Acb_Sech(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sech, res, x);
}


void Lib_QCplx_Acb_Coth(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_coth, res, x);
}



void Lib_QCplx_Acb_Sinc(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sinc, res, x);
}


void Lib_QCplx_Acb_SincPi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sinc_pi, res, x);
}



void Lib_QCplx_Acb_SinPi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sin_pi, res, x);
}


void Lib_QCplx_Acb_CosPi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_cos_pi, res, x);
}


void Lib_QCplx_Acb_TanPi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_tan_pi, res, x);
}


void Lib_QCplx_Acb_CotPi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_cot_pi, res, x);
}


void Lib_QCplx_Acb_CscPi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_csc_pi, res, x);
}


void Lib_QCplx_Acb_SecPi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_sec_pi_, res, x);
}








/* Inverse trigonometric functions */


void Lib_QCplx_Acb_Asin(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_asin, res, x);
}


void Lib_QCplx_Acb_Acos(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_acos, res, x);
}


void Lib_QCplx_Acb_Atan(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_atan, res, x);
}



void Lib_QCplx_Acb_Acsc(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_acsc, res, x);
}


void Lib_QCplx_Acb_Asec(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_asec, res, x);
}


void Lib_QCplx_Acb_Acot(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_QCplx_Acb_Asinh(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_asinh, res, x);
}


void Lib_QCplx_Acb_Acosh(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_acosh, res, x);
}


void Lib_QCplx_Acb_Atanh(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_atanh, res, x);
}



void Lib_QCplx_Acb_Acsch(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_acsch, res, x);
}


void Lib_QCplx_Acb_Asech(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_asech, res, x);
}


void Lib_QCplx_Acb_Acoth(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_acoth, res, x);
}









/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_QCplx_Acb_MEllipticK(QCplxPtr res, const QCplxPtr m)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k, res, m);
}


void Lib_QCplx_Acb_MEllipticE(QCplxPtr res, const QCplxPtr m)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e, res, m);
}


void Lib_QCplx_Acb_MEllipticPi(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi, res, phi, m);

}


void Lib_QCplx_Acb_MEllipticF(QCplxPtr res, const QCplxPtr phi, const QCplxPtr m)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_, res, phi, m);

}


void Lib_QCplx_Acb_MEllipticEInc(QCplxPtr res, const QCplxPtr n, const QCplxPtr m)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_, res, n, m);
}


void Lib_QCplx_Acb_MEllipticPiInc(QCplxPtr res, const QCplxPtr n, const QCplxPtr phi, const QCplxPtr m)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_, res, n, phi, m);
}







/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_QCplx_Acb_EllipticK(QCplxPtr res, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k_k_, res, k);
}


void Lib_QCplx_Acb_EllipticE(QCplxPtr res, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e_k_, res, k);
}


void Lib_QCplx_Acb_EllipticPi(QCplxPtr res, const QCplxPtr phi, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi_k_, res, phi, k);

}


void Lib_QCplx_Acb_EllipticF(QCplxPtr res, const QCplxPtr phi, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_k_, res, phi, k);

}


void Lib_QCplx_Acb_EllipticEInc(QCplxPtr res, const QCplxPtr n, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_k_, res, n, k);
}


void Lib_QCplx_Acb_EllipticPiInc(QCplxPtr res, const QCplxPtr n, const QCplxPtr phi, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_k_, res, n, phi, k);
}



void Lib_QCplx_Acb_Agm(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */

void Lib_QCplx_Acb_Elliptic_RC(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_rc_, res, x, y);
}



void Lib_QCplx_Acb_Elliptic_RF(QCplxPtr res, const QCplxPtr x, const QCplxPtr y, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rf_, res, x, y, z);
}


void Lib_QCplx_Acb_Elliptic_RG(QCplxPtr res, const QCplxPtr x, const QCplxPtr y, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rg_, res, x, y, z);
}


void Lib_QCplx_Acb_Elliptic_RD(QCplxPtr res, const QCplxPtr x, const QCplxPtr y, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rd_, res, x, y, z);
}


void Lib_QCplx_Acb_Elliptic_RJ(QCplxPtr res, const QCplxPtr x, const QCplxPtr y, const QCplxPtr z, const QCplxPtr w)
{
    QCplx_Acb_Cplxfunc4_Prec(acb_elliptic_rj_, res, x, y, z, w);
}






/* Jacobi theta functions */


void Lib_QCplx_Acb_Theta1Q(QCplxPtr res, const QCplxPtr z, const QCplxPtr q)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_theta1q, res, z, q);
}


void Lib_QCplx_Acb_Theta2Q(QCplxPtr res, const QCplxPtr z, const QCplxPtr q)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_theta2q, res, z, q);
}


void Lib_QCplx_Acb_Theta3Q(QCplxPtr res, const QCplxPtr z, const QCplxPtr q)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_theta3q, res, z, q);
}


void Lib_QCplx_Acb_Theta4Q(QCplxPtr res, const QCplxPtr z, const QCplxPtr q)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_theta4q, res, z, q);
}



void Lib_QCplx_Acb_Theta1Tau(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_theta1, res, z, tau);
}


void Lib_QCplx_Acb_Theta2Tau(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_theta2, res, z, tau);
}


void Lib_QCplx_Acb_Theta3Tau(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_theta3, res, z, tau);
}


void Lib_QCplx_Acb_Theta4Tau(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_theta4, res, z, tau);
}







/* Jacobi elliptic functions */


void Lib_QCplx_Acb_QfromK(QCplxPtr res, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_qfromk, res, k);
}


void Lib_QCplx_Acb_TfromUQ(QCplxPtr res, const QCplxPtr u, const QCplxPtr q)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_tfrom_u_q, res, u, q);
}


void Lib_QCplx_Acb_SnTQ(QCplxPtr res, const QCplxPtr t, const QCplxPtr q)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_sn_t_q, res, t, q);
}


void Lib_QCplx_Acb_CnTQ(QCplxPtr res, const QCplxPtr t, const QCplxPtr q)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_cn_t_q, res, t, q);
}


void Lib_QCplx_Acb_DnTQ(QCplxPtr res, const QCplxPtr t, const QCplxPtr q)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_dn_t_q, res, t, q);
}


void Lib_QCplx_Acb_JacobiSN(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sn, res, u, k);
}


void Lib_QCplx_Acb_JacobiCN(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cn, res, u, k);
}


void Lib_QCplx_Acb_JacobiDN(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dn, res, u, k);
}





void Lib_QCplx_Acb_JacobiNS(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ns, res, u, k);
}


void Lib_QCplx_Acb_JacobiNC(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nc, res, u, k);
}


void Lib_QCplx_Acb_JacobiND(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nd, res, u, k);
}




void Lib_QCplx_Acb_JacobiSC(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sc, res, u, k);
}


void Lib_QCplx_Acb_JacobiSD(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sd, res, u, k);
}




void Lib_QCplx_Acb_JacobiDC(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dc, res, u, k);
}


void Lib_QCplx_Acb_JacobiDS(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ds, res, u, k);
}




void Lib_QCplx_Acb_JacobiCS(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cs, res, u, k);
}


void Lib_QCplx_Acb_JacobiCD(QCplxPtr res, const QCplxPtr u, const QCplxPtr k)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cd, res, u, k);
}







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


void Lib_QCplx_Acb_WeierstrassP(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_p, res, z, tau);
}


void Lib_QCplx_Acb_WeierstrassPInv(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_inv_p, res, z, tau);
}


void Lib_QCplx_Acb_WeierstrassPZeta(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_zeta, res, z, tau);
}


void Lib_QCplx_Acb_WeierstrassPSigma(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_elliptic_sigma, res, z, tau);
}



void Lib_QCplx_Acb_WeierstrassPPrime(QCplxPtr res, const QCplxPtr z, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_wp_prime, res, z, tau);
}



void Lib_QCplx_Acb_EllipticInvariantG2(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g2, res, tau);
}


void Lib_QCplx_Acb_EllipticInvariantG3(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g3, res, tau);
}


void Lib_QCplx_Acb_EllipticRootE1(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e1, res, tau);
}


void Lib_QCplx_Acb_EllipticRootE2(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e2, res, tau);
}


void Lib_QCplx_Acb_EllipticRootE3(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e3, res, tau);
}



void Lib_QCplx_Acb_DedekindEta(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_modular_eta, res, tau);
}


void Lib_QCplx_Acb_KleinJ(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_modular_j, res, tau);
}


void Lib_QCplx_Acb_ModularLambda(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_modular_lambda, res, tau);
}


void Lib_QCplx_Acb_ModularDelta(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_modular_delta, res, tau);
}




/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */






/* Lerch’s transcendent: overview */


void Lib_QCplx_Acb_LerchPhi(QCplxPtr res, const QCplxPtr z, const QCplxPtr s, const QCplxPtr a)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_dirichlet_lerch_phi, res, z, s, a);
}


void Lib_QCplx_Acb_LerchZeta(QCplxPtr res, const QCplxPtr lambda1, const QCplxPtr alpha, const QCplxPtr s)
{
    QCplx_Acb_Cplxfunc3_Prec(_acb_lerch_zeta, res, lambda1, alpha, s);
}


/* Polygamma functions */


void Lib_QCplx_Acb_Polygamma(QCplxPtr res, const QCplxPtr s, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_polygamma, res, s, z);
}


void Lib_QCplx_Acb_Trigamma(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_trigamma, res, x);
}


void Lib_QCplx_Acb_Digamma(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_QCplx_Acb_Polylog(QCplxPtr res, const QCplxPtr s, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_polylog, res, s, z);
}


void Lib_QCplx_Acb_Trilog(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_trilog, res, x);
}


void Lib_QCplx_Acb_Dilog(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_dilog, res, x);
}



void Lib_QCplx_Acb_ClausenSin(QCplxPtr res, const QCplxPtr s, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_clausen_sin, res, s, z);
}


void Lib_QCplx_Acb_ClausenCos(QCplxPtr res, const QCplxPtr s, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_clausen_cos, res, s, z);
}


void Lib_QCplx_Acb_Clausen2(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_clausen2, res, x);
}


void Lib_QCplx_Acb_BoseEinstein(QCplxPtr res, const QCplxPtr s, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_bose_einstein, res, s, z);
}


void Lib_QCplx_Acb_FermiDirac(QCplxPtr res, const QCplxPtr s, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_fermi_dirac, res, s, z);
}


void Lib_QCplx_Acb_LegendreChi(QCplxPtr res, const QCplxPtr s, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_legendre_chi, res, s, z);
}


void Lib_QCplx_Acb_InverseTanIntegral(QCplxPtr res, const QCplxPtr s, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_ti, res, s, z);
}





/* Hurwitz zeta function and related functions */




void Lib_QCplx_Acb_HurwitzZeta(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hurwitz_zeta, res, x, y);
}


void Lib_QCplx_Acb_Stieltjes_ui(QCplxPtr res, const QCplxPtr x, const int32_t n)
{
    QCplx_Acb_Cplxfunc1Int32_Prec(acb_stieltjes_ui_, res, x, n);
}


void Lib_QCplx_Acb_BernoulliPoly_ui(QCplxPtr res, const QCplxPtr x, const int32_t n)
{
    QCplx_Acb_Cplxfunc1Int32_Prec(acb_bernoulli_poly_ui_, res, x, n);
}



void Lib_QCplx_Acb_Harmonic(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_harmonic, res, x);
}


void Lib_QCplx_Acb_Harmonic2(QCplxPtr res, const QCplxPtr z, const QCplxPtr r)
{
    QCplx_Acb_Cplxfunc2_Prec(_acb_harmonic2, res, z, r);
}


void Lib_QCplx_Acb_EulerPoly_ui(QCplxPtr res, const QCplxPtr x, const int32_t n)
{
    QCplx_Acb_Cplxfunc1Int32_Prec(acb_euler_poly_ui_, res, x, n);
}


void Lib_QCplx_Acb_Hyperfactorial(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_hyperfac, res, x);
}


void Lib_QCplx_Acb_Superfactorial(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_superfac, res, x);
}


void Lib_QCplx_Acb_BarnesG(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_barnes_g, res, x);
}


void Lib_QCplx_Acb_LogBarnesG(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */


void Lib_QCplx_Acb_Zeta(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_zeta, res, x);
}


void Lib_QCplx_Acb_Zetam1(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_zetam1, res, x);
}


void Lib_QCplx_Acb_ZetaZero_ui(QCplxPtr res, const int32_t n)
{
    QCplx_Acb_Cplxfunc0Int32_Prec(acb_dirichlet_zeta_zero_ui_, res, n);
}


void Lib_QCplx_Acb_DirichletXi(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_xi, res, tau);
}


void Lib_QCplx_Acb_DirichletEta(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_eta, res, tau);
}


void Lib_QCplx_Acb_DirichletEtam1(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_etam1, res, x);
}


void Lib_QCplx_Acb_DirichletBeta(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_beta, res, x);
}


void Lib_QCplx_Acb_DirichletLambda(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_lambda, res, x);
}



/* Riemann-Siegel Z-function */
void Lib_QCplx_Acb_HardyZ(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_z_, res, tau);
}

/* rstheta(z) in amath */
void Lib_QCplx_Acb_HardyTheta(QCplxPtr res, const QCplxPtr tau)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_theta_, res, tau);
}









/* Additional numbertheoretic functions */




/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_QCplx_Acb_Hypgeom0F1(QCplxPtr res, const QCplxPtr a, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_, res, a, x);
}


void Lib_QCplx_Acb_Hypgeom0F1r(QCplxPtr res, const QCplxPtr a, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */



void Lib_QCplx_Acb_BesselJ(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_j, res, x, y);
}


void Lib_QCplx_Acb_BesselY(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_y, res, x, y);
}


void Lib_QCplx_Acb_BesselI(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i, res, x, y);
}


void Lib_QCplx_Acb_BesselK(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k, res, x, y);
}


void Lib_QCplx_Acb_BesselIScaled(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_QCplx_Acb_BesselKScaled(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */




/* Airy functions  */


void Lib_QCplx_Acb_AiryAi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_airy_ai, res, x);
}


void Lib_QCplx_Acb_AiryAiPrime(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_airy_ai_prime, res, x);
}


void Lib_QCplx_Acb_AiryBi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_airy_bi, res, x);
}


void Lib_QCplx_Acb_AiryBiPrime(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_airy_bi_prime, res, x);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */



void Lib_QCplx_Acb_Hypgeom1F1(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
}


void Lib_QCplx_Acb_Hypgeom1F1r(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_QCplx_Acb_HypgeomU(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_u, res, a, b, z);
}





/* Gamma function and related functions */


void Lib_QCplx_Acb_Gamma(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_gamma, res, x);
}


void Lib_QCplx_Acb_Rgamma(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_rgamma, res, x);
}


void Lib_QCplx_Acb_Lgamma(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_lgamma, res, x);
}


void Lib_QCplx_Acb_RisingFactorial(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_rising, res, x, y);
}


void Lib_QCplx_Acb_Beta(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_beta_, res, x, y);
}






/* Incomplete gamma functions */


void Lib_QCplx_Acb_GammaUpper(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_gamma_upper_, res, x, y);
}



void Lib_QCplx_Acb_GammaLower(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_gamma_lower_, res, x, y);
}



void Lib_QCplx_Acb_GammaPPrime(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_gamma_p_derivative, res, x, y);
}


void Lib_QCplx_Acb_GammaP(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_gamma_p, res, x, y);
}


void Lib_QCplx_Acb_GammaQ(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_gamma_q, res, x, y);
}







/* Error function and related functions */


void Lib_QCplx_Acb_Erf(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erf, res, x);
}


void Lib_QCplx_Acb_Erfc(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfc, res, x);
}


void Lib_QCplx_Acb_Erfi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfi, res, x);
}



void Lib_QCplx_Acb_FresnelC(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_fresnelc, res, x);
}


void Lib_QCplx_Acb_FresnelS(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_fresnels, res, x);
}


void Lib_QCplx_Acb_Ndens(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_ndens, res, x);
}


void Lib_QCplx_Acb_Ndis(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_ndis, res, x);
}






/* Exponential integrals and related functions */


void Lib_QCplx_Acb_ExpIntegralE(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_expint, res, x, y);
}



void Lib_QCplx_Acb_ExpIntegralEi(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ei, res, x);
}


void Lib_QCplx_Acb_SinIntegral(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_si, res, x);
}


void Lib_QCplx_Acb_CosIntegral(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ci, res, x);
}


void Lib_QCplx_Acb_SinhIntegral(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_shi, res, x);
}


void Lib_QCplx_Acb_CoshIntegral(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_chi, res, x);
}


void Lib_QCplx_Acb_LogIntegral(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_, res, x);
}


void Lib_QCplx_Acb_LogIntegralOffset(QCplxPtr res, const QCplxPtr x)
{
    QCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_QCplx_Acb_HermiteH(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_hermite_h, res, x, y);
}


void Lib_QCplx_Acb_LaguerreL(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */



void Lib_QCplx_Acb_CoulombF(QCplxPtr res, const QCplxPtr l, const QCplxPtr eta, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_QCplx_Acb_CoulombG(QCplxPtr res, const QCplxPtr l, const QCplxPtr eta, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_g, res, l, eta, z);
}


void Lib_QCplx_Acb_CoulombHpos(QCplxPtr res, const QCplxPtr l, const QCplxPtr eta, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hpos, res, l, eta, z);
}


void Lib_QCplx_Acb_CoulombHneg(QCplxPtr res, const QCplxPtr l, const QCplxPtr eta, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hneg, res, l, eta, z);
}







/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_QCplx_Acb_Hypgeom2F1(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_QCplx_Acb_Hypgeom2F1r(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1r_, res, a, b, c, z);
}



/* 2F1: Orthogonal polynomials */


void Lib_QCplx_Acb_ChebyshevT(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_QCplx_Acb_ChebyshevU(QCplxPtr res, const QCplxPtr x, const QCplxPtr y)
{
    QCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_QCplx_Acb_GegenbauerC(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_QCplx_Acb_LegendreP(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_QCplx_Acb_LegendrePv(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_QCplx_Acb_LegendreQ(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_QCplx_Acb_LegendreQv(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_qv_, res, a, b, z);
}



void Lib_QCplx_Acb_JacobiP(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr c, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_jacobi_p, res, a, b, c, z);
}


void Lib_QCplx_Acb_SphericalY(QCplxPtr res, const QCplxPtr n, const QCplxPtr m, const QCplxPtr theta, const QCplxPtr phi)
{
    QCplx_Acb_Cplxfunc4_Prec(_acb_hypgeom_spherical_y, res, n, m, theta, phi);
}





/* 2F1: Incomplete Beta Function */


void Lib_QCplx_Acb_BetaLower(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_beta_lower_, res, a, b, z);
}




void Lib_QCplx_Acb_Ibeta(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_ibeta, res, a, b, z);
}


void Lib_QCplx_Acb_Ibetac(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_ibetac, res, a, b, z);
}



void Lib_QCplx_Acb_IbetaPrime(QCplxPtr res, const QCplxPtr a, const QCplxPtr b, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc3_Prec(acb_ibeta_derivative, res, a, b, z);
}



/* Hypergeometric Function 1F2, overview */



void Lib_QCplx_Acb_Hypgeom1F2(QCplxPtr res, const QCplxPtr a1, const QCplxPtr b1, const QCplxPtr b2, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_QCplx_Acb_Hypgeom1F2r(QCplxPtr res, const QCplxPtr a1, const QCplxPtr b1, const QCplxPtr b2, const QCplxPtr z)
{
    QCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2r_, res, a1, b1, b2, z);
}



//
//
////*********************** Boost Special functions , quadruple precision **********************************
//
//
//
//void Lib_QReal_BernoulliB2n(QRealPtr res, const int n)
//{
//    LibQReal_BernoulliB2n(res, n);
//}
//
//
//
//void Lib_QReal_TangentT2n(QRealPtr res, const int n)
//{
//    LibQReal_TangentT2n(res, n);
//}
//
//
//
//void Lib_QReal_Sqrt1pm1_Boost(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Sqrt1pm1(res, x);
//}
//
//
//
//void Lib_QReal_SinPi_Boost(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_SinPi(res, x);
//}
//
//
//
//void Lib_QReal_CosPi_Boost(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_CosPi(res, x);
//}
//
//
//
//void Lib_QReal_SincPi(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_SincPi(res, x);
//}
//
//
//
//void Lib_QReal_SinhcPi(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_SinhcPi(res, x);
//}
//
//
//
//void Lib_QReal_Tgamma_(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Tgamma_(res, x);
//}
//
//
//void Lib_QReal_Tgamma1pm1(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Tgamma1pm1(res, x);
//}
//
//
//
//void Lib_QReal_Lgamma_(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Lgamma_(res, x);
//}
//
//
//
//void Lib_QReal_Digamma(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Digamma(res, x);
//}
//
//
//
//void Lib_QReal_Trigamma(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Trigamma(res, x);
//}
//
//
//
//void Lib_QReal_Factorial(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Factorial(res, x);
//}
//
//
//
//void Lib_QReal_DoubleFactorial(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_DoubleFactorial(res, x);
//}
//
//
//
//
//
//void Lib_QReal_Erf_(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Erf_(res, x);
//}
//
//
//
//void Lib_QReal_Erfc_(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Erfc_(res, x);
//}
//
//
//
//void Lib_QReal_Erf_inv(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Erf_inv(res, x);
//}
//
//
//
//void Lib_QReal_Erfc_inv(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Erfc_inv(res, x);
//}
//
//
//
//void Lib_QReal_AiryAi(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_AiryAi(res, x);
//}
//
//
//
//void Lib_QReal_AiryBi(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_AiryBi(res, x);
//}
//
//
//
//void Lib_QReal_AiryAiPrime(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_AiryAiPrime(res, x);
//}
//
//
//
//void Lib_QReal_AiryBiPrime(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_AiryBiPrime(res, x);
//}
//
//
//
//void Lib_QReal_Aizero(QRealPtr res, const int n)
//{
//    LibQReal_Aizero(res, n);
//}
//
//
//
//void Lib_QReal_Bizero(QRealPtr res, const int n)
//{
//    LibQReal_Bizero(res, n);
//}
//
//
//
//void Lib_QReal_Ellint_1_K(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Ellint_1_K(res, x);
//}
//
//
//
//void Lib_QReal_Ellint_2_K(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Ellint_2_K(res, x);
//}
//
//
//
//void Lib_QReal_Zeta(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Zeta(res, x);
//}
//
//
//
//void Lib_QReal_Ei(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_Ei(res, x);
//}
//
//
//
//void Lib_QReal_LambertW0(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_LambertW0(res, x);
//}
//
//
//void Lib_QReal_LambertWm1(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_LambertWm1(res, x);
//}
//
//
//
//void Lib_QReal_LambertW0Prime(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_LambertW0Prime(res, x);
//}
//
//
//void Lib_QReal_LambertWm1Prime(QRealPtr res, const QRealPtr x)
//{
//    LibQReal_LambertWm1Prime(res, x);
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
//void Lib_QReal_Powm1_Boost(QRealPtr res, const QRealPtr a, const QRealPtr b)
//{
//    LibQReal_Powm1(res, a, b);
//}
//
//
//
//void Lib_QReal_TgammaRatio(QRealPtr res, const QRealPtr a, const QRealPtr b)
//{
//    LibQReal_TgammaRatio(res, a, b);
//}
//
//
//
//void Lib_QReal_TgammaDeltaRatio(QRealPtr res, const QRealPtr a, const QRealPtr b)
//{
//    LibQReal_TgammaDeltaRatio(res, a, b);
//}
//
//
//
//void Lib_QReal_Binomial(QRealPtr res, const QRealPtr n, const QRealPtr k)
//{
//    LibQReal_Binomial(res, n, k);
//}
//
//void Lib_QReal_RisingFactorial(QRealPtr res, const QRealPtr x, const QRealPtr n)
//{
//    LibQReal_RisingFactorial(res, x, n);
//}
//
//
//
//
//void Lib_QReal_FallingFactorial(QRealPtr res, const QRealPtr x, const QRealPtr n)
//{
//    LibQReal_FallingFactorial(res, x, n);
//}
//
//
//
//
//void Lib_QReal_BesselJ(QRealPtr res, const QRealPtr v, const QRealPtr x)
//{
//    LibQReal_BesselJ(res, v, x);
//}
//
//
//
//void Lib_QReal_BesselY(QRealPtr res, const QRealPtr v, const QRealPtr x)
//{
//    LibQReal_BesselY(res, v, x);
//}
//
//
//
//void Lib_QReal_BesselI(QRealPtr res, const QRealPtr v, const QRealPtr x)
//{
//    LibQReal_BesselI(res, v, x);
//}
//
//
//
//void Lib_QReal_BesselK(QRealPtr res, const QRealPtr v, const QRealPtr x)
//{
//    LibQReal_BesselK(res, v, x);
//}
//
//
//
//void Lib_QReal_SphBessel(QRealPtr res, const unsigned v, const QRealPtr x)
//{
//    LibQReal_SphBessel(res, v, x);
//}
//
//
//
//void Lib_QReal_SphNeumann(QRealPtr res, const unsigned v, const QRealPtr x)
//{
//    LibQReal_SphNeumann(res, v, x);
//}
//
//
//
//
//
//void Lib_QReal_BesselJPrime(QRealPtr res, const QRealPtr v, const QRealPtr x)
//{
//    LibQReal_BesselJPrime(res, v, x);
//}
//
//
//
//void Lib_QReal_BesselYPrime(QRealPtr res, const QRealPtr v, const QRealPtr x)
//{
//    LibQReal_BesselYPrime(res, v, x);
//}
//
//
//
//void Lib_QReal_BesselIPrime(QRealPtr res, const QRealPtr v, const QRealPtr x)
//{
//    LibQReal_BesselIPrime(res, v, x);
//}
//
//
//
//void Lib_QReal_BesselKPrime(QRealPtr res, const QRealPtr v, const QRealPtr x)
//{
//    LibQReal_BesselKPrime(res, v, x);
//}
//
//
//
//void Lib_QReal_SphBesselPrime(QRealPtr res, const unsigned v, const QRealPtr x)
//{
//    LibQReal_SphBesselPrime(res, v, x);
//}
//
//
//
//void Lib_QReal_SphNeumannPrime(QRealPtr res, const unsigned v, const QRealPtr x)
//{
//    LibQReal_SphNeumannPrime(res, v, x);
//}
//
//
//
//
//
//void Lib_QReal_BesselJZero(QRealPtr res, const QRealPtr v, const int m)
//{
//    LibQReal_BesselJZero(res, v, m);
//}
//
//
//
//void Lib_QReal_BesselYZero(QRealPtr res, const QRealPtr v, const int m)
//{
//    LibQReal_BesselYZero(res, v, m);
//}
//
//
//
//
//
//void Lib_QReal_GammaP(QRealPtr res, const QRealPtr a, const QRealPtr x)
//{
//    LibQReal_GammaP(res, a, x);
//}
//
//
//void Lib_QReal_GammaQ(QRealPtr res, const QRealPtr a, const QRealPtr x)
//{
//    LibQReal_GammaQ(res, a, x);
//}
//
//
//void Lib_QReal_TgammaLower(QRealPtr res, const QRealPtr a, const QRealPtr x)
//{
//    LibQReal_TgammaLower(res, a, x);
//}
//
//
//void Lib_QReal_TgammaUpper(QRealPtr res, const QRealPtr a, const QRealPtr x)
//{
//    LibQReal_TgammaUpper(res, a, x);
//}
//
//
//
//
//void Lib_QReal_GammaPInv(QRealPtr res, const QRealPtr a, const QRealPtr p)
//{
//    LibQReal_GammaPInv(res, a, p);
//}
//
//
//void Lib_QReal_GammaQInv(QRealPtr res, const QRealPtr a, const QRealPtr q)
//{
//    LibQReal_GammaQInv(res, a, q);
//}
//
//
//void Lib_QReal_GammaPInva(QRealPtr res, const QRealPtr x, const QRealPtr p)
//{
//    LibQReal_GammaPInva(res, x, p);
//}
//
//
//void Lib_QReal_GammaQInva(QRealPtr res, const QRealPtr x, const QRealPtr q)
//{
//    LibQReal_GammaQInva(res, x, q);
//}
//
//
//
//void Lib_QReal_GammaPDerivative(QRealPtr res, const QRealPtr a, const QRealPtr x)
//{
//    LibQReal_GammaPDerivative(res, a, x);
//}
//
//
//void Lib_QReal_Beta(QRealPtr res, const QRealPtr a, const QRealPtr b)
//{
//    LibQReal_Beta(res, a, b);
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
//void Lib_QReal_LegendreP(QRealPtr res, int n, const QRealPtr x)
//{
//    LibQReal_LegendreP(res, n, x);
//}
//
//
//
//void Lib_QReal_LegendreQ(QRealPtr res, int n, const QRealPtr x)
//{
//    LibQReal_LegendreQ(res, n, x);
//}
//
//
//
//void Lib_QReal_Laguerre(QRealPtr res, int n, const QRealPtr x)
//{
//    LibQReal_Laguerre(res, n, x);
//}
//
//
//
//void Lib_QReal_Hermite(QRealPtr res, int n, const QRealPtr x)
//{
//    LibQReal_Hermite(res, n, x);
//}
//
//
//
//void Lib_QReal_ChebyshevT(QRealPtr res, int n, const QRealPtr x)
//{
//    LibQReal_ChebyshevT(res, n, x);
//}
//
//
//void Lib_QReal_ChebyshevU(QRealPtr res, int n, const QRealPtr x)
//{
//    LibQReal_ChebyshevU(res, n, x);
//}
//
//
//
//void Lib_QReal_Polygamma(QRealPtr res, int n, const QRealPtr x)
//{
//    LibQReal_Polygamma(res, n, x);
//}
//
//
//
//
//
//void Lib_QReal_EllintRC(QRealPtr res, const QRealPtr x, const QRealPtr y)
//{
//    LibQReal_EllintRC(res, x, y);
//}
//
//
//void Lib_QReal_Ellint1F(QRealPtr res, const QRealPtr k, const QRealPtr phi)
//{
//    LibQReal_Ellint1F(res, k, phi);
//}
//
//
//void Lib_QReal_Ellint2F(QRealPtr res, const QRealPtr k, const QRealPtr phi)
//{
//    LibQReal_Ellint2F(res, k, phi);
//}
//
//
//void Lib_QReal_Ellint3K(QRealPtr res, const QRealPtr k, const QRealPtr n)
//{
//    LibQReal_Ellint3K(res, k, n);
//}
//
//
//
//
//void Lib_QReal_JacobiCD(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiCD(res, k, u);
//}
//
//
//void Lib_QReal_JacobiCN(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiCN(res, k, u);
//}
//
//
//void Lib_QReal_JacobiCS(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiCS(res, k, u);
//}
//
//
//void Lib_QReal_JacobiDC(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiDC(res, k, u);
//}
//
//
//void Lib_QReal_JacobiDN(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiDN(res, k, u);
//}
//
//
//void Lib_QReal_JacobiDS(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiDS(res, k, u);
//}
//
//
//void Lib_QReal_JacobiNC(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiNC(res, k, u);
//}
//
//
//void Lib_QReal_JacobiND(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiND(res, k, u);
//}
//
//
//void Lib_QReal_JacobiNS(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiNS(res, k, u);
//}
//
//
//void Lib_QReal_JacobiSC(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiSC(res, k, u);
//}
//
//
//void Lib_QReal_JacobiSD(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiSD(res, k, u);
//}
//
//
//void Lib_QReal_JacobiSN(QRealPtr res, const QRealPtr k, const QRealPtr u)
//{
//    LibQReal_JacobiSN(res, k, u);
//}
//
//
//
//void Lib_QReal_expint(QRealPtr res, const unsigned n, const QRealPtr x)
//{
//    LibQReal_expint(res, n, x);
//}
//
//
//
//
//void Lib_QReal_OwenT(QRealPtr res, const QRealPtr h, const QRealPtr a)
//{
//    LibQReal_OwenT(res, h, a);
//}
//
//
//
//
//
//void Lib_QReal_IBeta(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_IBeta(res, a, b, x);
//}
//
//
//void Lib_QReal_IBetac(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_IBetac(res, a, b, x);
//}
//
//
//void Lib_QReal_IBetaNonNormalized(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_IBetaNonNormalized(res, a, b, x);
//}
//
//
//void Lib_QReal_IBetacNonNormalized(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_IBetacNonNormalized(res, a, b, x);
//}
//
//
//void Lib_QReal_IBetaInv(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr p)
//{
//    LibQReal_IBetaInv(res, a, b, p);
//}
//
//
//void Lib_QReal_IBetacInv(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr q)
//{
//    LibQReal_IBetacInv(res, a, b, q);
//}
//
//
//void Lib_QReal_IBetaInva(QRealPtr res, const QRealPtr b, const QRealPtr x, const QRealPtr p)
//{
//    LibQReal_IBetaInva(res, b, x, p);
//}
//
//
//void Lib_QReal_IBetacInva(QRealPtr res, const QRealPtr b, const QRealPtr x, const QRealPtr q)
//{
//    LibQReal_IBetacInva(res, b, x, q);
//}
//
//
//void Lib_QReal_IBetaInvb(QRealPtr res, const QRealPtr a, const QRealPtr x, const QRealPtr p)
//{
//    LibQReal_IBetaInvb(res, a, x, p);
//}
//
//
//void Lib_QReal_IBetacInvb(QRealPtr res, const QRealPtr a, const QRealPtr x, const QRealPtr q)
//{
//    LibQReal_IBetacInvb(res, a, x, q);
//}
//
//
//void Lib_QReal_IBetaDerivative(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_IBetaDerivative(res, a, b, x);
//}
//
//
//
//
//void Lib_QReal_LegendrePM(QRealPtr res, const int n, const int m, const QRealPtr x)
//{
//    LibQReal_LegendrePM(res, n, m, x);
//}
//
//
//
//void Lib_QReal_LaguerreM(QRealPtr res, const int n, const int m, const QRealPtr x)
//{
//    LibQReal_LaguerreM(res, n, m, x);
//}
//
//
//
//
//
//void Lib_QReal_EllipticRF(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z)
//{
//    LibQReal_EllipticRF(res, x, y, z);
//}
//
//
//
//void Lib_QReal_EllipticRD(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z)
//{
//    LibQReal_EllipticRD(res, x, y, z);
//}
//
//
//
//void Lib_QReal_Ellint3F(QRealPtr res, const QRealPtr k, const QRealPtr n, const QRealPtr phi)
//{
//    LibQReal_Ellint3F(res, k, n, phi);
//}
//
//
//
//
//void Lib_QReal_SphericalHarmonicR(QRealPtr res, const int n, const int m, const QRealPtr theta, const QRealPtr phi)
//{
//    LibQReal_SphericalHarmonicR(res, n, m, theta, phi);
//}
//
//
//void Lib_QReal_SphericalHarmonicI(QRealPtr res, const int n, const int m, const QRealPtr theta, const QRealPtr phi)
//{
//    LibQReal_SphericalHarmonicI(res, n, m, theta, phi);
//}
//
//
//void Lib_QReal_EllipticRJ(QRealPtr res, const QRealPtr x, const QRealPtr y, const QRealPtr z, const QRealPtr p)
//{
//    LibQReal_EllipticRJ(res, x, y, z, p);
//}
//
//
//// Hypergeometric and Theta Functions
//
//
//
//
//void Lib_QReal_Hypergeo0F1(QRealPtr res, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_Hypergeo0F1(res, b, x);
//}
//
//
//
//void Lib_QReal_Hypergeo1F1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_Hypergeo1F1(res, a, b, x);
//}
//
//
//
//void Lib_QReal_Hypergeo1F1r(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_Hypergeo1F1r(res, a, b, x);
//}
//
//
//
//void Lib_QReal_LogHypergeo1F1(QRealPtr res, const QRealPtr a, const QRealPtr b, const QRealPtr x)
//{
//    LibQReal_LogHypergeo1F1(res, a, b, x);
//}
//
//
//
//
//
//void Lib_QReal_JacobiTheta1(QRealPtr res, const QRealPtr x, const QRealPtr q)
//{
//    LibQReal_JacobiTheta1(res, x, q);
//}
//
//
//void Lib_QReal_JacobiTheta2(QRealPtr res, const QRealPtr x, const QRealPtr q)
//{
//    LibQReal_JacobiTheta2(res, x, q);
//}
//
//
//void Lib_QReal_JacobiTheta3(QRealPtr res, const QRealPtr x, const QRealPtr q)
//{
//    LibQReal_JacobiTheta3(res, x, q);
//}
//
//
//void Lib_QReal_JacobiTheta4(QRealPtr res, const QRealPtr x, const QRealPtr q)
//{
//    LibQReal_JacobiTheta4(res, x, q);
//}
//
//
//
//
////***********************  Boost Distributions, quadruple precision  **********************************
//
//
//void Lib_QReal_ArcsineDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr a, QRealPtr b)
//{
//    LibQReal_ArcsineDist(Target, res, xqp, a, b);
//}
//
//
//
//void Lib_QReal_BernoulliDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr p)
//{
//    LibQReal_BernoulliDist(Target, res, xqp, p);
//}
//
//
//
//void Lib_QReal_BetaDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr a, QRealPtr b)
//{
//    LibQReal_BetaDist(Target, res, xqp, a, b);
//}
//
//
//
//void Lib_QReal_BinomialDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr n, QRealPtr p)
//{
//    LibQReal_BinomialDist(Target, res, xqp, n, p);
//}
//
//
//
//void Lib_QReal_CauchyDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale)
//{
//    LibQReal_CauchyDist(Target, res, xqp, location, scale);
//}
//
//
//
//void Lib_QReal_Chi2Dist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu)
//{
//    LibQReal_Chi2Dist(Target, res, xqp, nu);
//}
//
//
//
//void Lib_QReal_ExponentialDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr lambda)
//{
//    LibQReal_ExponentialDist(Target, res, xqp, lambda);
//}
//
//
//
//void Lib_QReal_ExtremeValueDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale)
//{
//    LibQReal_ExtremeValueDist(Target, res, xqp, location, scale);
//}
//
//
//
//void Lib_QReal_FisherFDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mu, QRealPtr nu)
//{
//    LibQReal_FisherFDist(Target, res, xqp, mu, nu);
//}
//
//
//
//void Lib_QReal_GammaDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr shape, QRealPtr scale)
//{
//    LibQReal_GammaDist(Target, res, xqp, shape, scale);
//}
//
//
//
//void Lib_QReal_GeometricDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr p)
//{
//    LibQReal_GeometricDist(Target, res, xqp, p);
//}
//
//
//
//void Lib_QReal_HypergeometricDist(long Target, QRealPtr res, QRealPtr xqp, unsigned r, unsigned n, unsigned N)
//{
//    LibQReal_HypergeometricDist(Target, res, xqp, r, n, N);
//}
//
//
//
//void Lib_QReal_InverseChi2Dist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr df, QRealPtr scale)
//{
//    LibQReal_InverseChi2Dist(Target, res, xqp, df, scale);
//}
//
//
//
//void Lib_QReal_InverseGammaDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr shape, QRealPtr scale)
//{
//    LibQReal_InverseGammaDist(Target, res, xqp, shape, scale);
//}
//
//
//
//void Lib_QReal_WaldDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mean_, QRealPtr scale)
//{
//    LibQReal_InverseGaussianDist(Target, res, xqp, mean_, scale);
//}
//
//
//
//void Lib_QReal_LaplaceDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale)
//{
//    LibQReal_LaplaceDist(Target, res, xqp, location, scale);
//}
//
//
//
//void Lib_QReal_LogisticDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale)
//{
//    LibQReal_LogisticDist(Target, res, xqp, location, scale);
//}
//
//
//
//void Lib_QReal_LognormalDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr location, QRealPtr scale)
//{
//    LibQReal_LognormalDist(Target, res, xqp, location, scale);
//}
//
//
//
//void Lib_QReal_NegBinomialDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr n, QRealPtr p)
//{
//    LibQReal_NegBinomialDist(Target, res, xqp, n, p);
//}
//
//
//void Lib_QReal_Chi2NcDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu, QRealPtr nc)
//{
//    LibQReal_Chi2NCDist(Target, res, xqp, nu, nc);
//}
//
//
//void Lib_QReal_StudentTNcDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu, QRealPtr delta)
//{
//    LibQReal_StudentTNCDist(Target, res, xqp, nu, delta);
//}
//
//
//
//void Lib_QReal_FisherNcDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mu, QRealPtr nu, QRealPtr nc)
//{
//    LibQReal_FisherNCDist(Target, res, xqp, mu, nu, nc);
//}
//
//
//
//void Lib_QReal_BetaNcDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr a, QRealPtr b, QRealPtr nc)
//{
//    LibQReal_BetaNCDist(Target, res, xqp, a, b, nc);
//}
//
//
//
//void Lib_QReal_NormalDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mean_, QRealPtr stdev)
//{
//    LibQReal_NormalDist(Target, res, xqp, mean_, stdev);
//}
//
//
//
//void Lib_QReal_ParetoDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr shape, QRealPtr scale)
//{
//    LibQReal_ParetoDist(Target, res, xqp, shape, scale);
//}
//
//
//
//void Lib_QReal_PoissonDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu)
//{
//    LibQReal_PoissonDist(Target, res, xqp, nu);
//}
//
//
//
//void Lib_QReal_RayleighDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu)
//{
//    LibQReal_RayleighDist(Target, res, xqp, nu);
//}
//
//
//
//void Lib_QReal_SkewNormalDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr mean_, QRealPtr scale, QRealPtr shape)
//{
//    LibQReal_SkewNormalDist(Target, res, xqp, mean_, scale, shape);
//}
//
//
//
//void Lib_QReal_StudentTDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr nu)
//{
//    LibQReal_StudentTDist(Target, res, xqp, nu);
//}
//
//
//
//void Lib_QReal_TriangularDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr lower, QRealPtr mode_, QRealPtr upper)
//{
//    LibQReal_TriangularDist(Target, res, xqp, lower, mode_, upper);
//}
//
//
//
//void Lib_QReal_WeibullDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr shape, QRealPtr scale)
//{
//    LibQReal_WeibullDist(Target, res, xqp, shape, scale);
//}
//
//
//
//void Lib_QReal_UniformDist(long Target, QRealPtr res, QRealPtr xqp, QRealPtr lower, QRealPtr upper)
//{
//    LibQReal_UniformDist(Target, res, xqp, lower, upper);
//}
//
//
//
//
//
//
////*********************** Boost Numerical Calculus, quadruple precision **********************************
//
//
//
//
//void Lib_QReal_BracketRoot(QRealPtr res1, QRealPtr res2, int* iter, QuadFuncPtr f1, QRealPtr guess_, QRealPtr factor_, bool is_rising, int get_digits, unsigned int maxit)
//{
//    LibQReal_BracketRoot(res1, res2, iter, f1, guess_, factor_, is_rising, get_digits, maxit);
//}
//
//
//
//void Lib_QReal_NewtonRaphson(QRealPtr res,  int* iter, QuadFuncPtr f1, QuadFuncPtr f2, QRealPtr guess_, QRealPtr xmin_, QRealPtr xmax_, int get_digits, unsigned int maxit)
//{
//    LibQReal_NewtonRaphson(res, iter, f1, f2, guess_, xmin_, xmax_, get_digits, maxit);
//}
//
//
//
//void Lib_QReal_Halley(QRealPtr res, int* iter, QuadFuncPtr f1, QuadFuncPtr f2, QuadFuncPtr f3, QRealPtr guess_, QRealPtr xmin_, QRealPtr xmax_, int get_digits, unsigned int maxit)
//{
//    LibQReal_Halley(res, iter, f1, f2, f3, guess_, xmin_, xmax_, get_digits, maxit);
//}
//
//
//
//void Lib_QReal_Schroder(QRealPtr res, int* iter, QuadFuncPtr f1, QuadFuncPtr f2, QuadFuncPtr f3, QRealPtr guess_, QRealPtr xmin_, QRealPtr xmax_, int get_digits, unsigned int maxit)
//{
//    LibQReal_Schroder(res, iter, f1, f2, f3, guess_, xmin_, xmax_, get_digits, maxit);
//}
//
//
//
//void Lib_QReal_Brent_Minimum(QRealPtr res, QRealPtr resFx, int* iter, QuadFuncPtr f1, QRealPtr bracket_min_, QRealPtr bracket_max_, int bits, unsigned int maxit)
//{
//    LibQReal_Brent_Minimum(res, resFx, iter, f1, bracket_min_, bracket_max_, bits, maxit);
//}
//
//
//
//
//void Lib_QReal_Trapezoidal(QRealPtr res1, QRealPtr res2, QRealPtr res3, QuadFuncPtr f1, QRealPtr a_, QRealPtr b_)
//{
//    LibQReal_Trapezoidal(res1, res2, res3, f1, a_, b_);
//}
//
//
//
//// 7, 15, 20, 25 and 30
//
//void Lib_QReal_GaussLegendre(QRealPtr res1, QRealPtr res3, QuadFuncPtr f1, QRealPtr a_, QRealPtr b_)
//{
//    LibQReal_GaussLegendre(res1, res3, f1, a_, b_);
//}
//
//
//
//
////15, 31, 41, 51 and 61
//
//void Lib_QReal_GaussKronrod(QRealPtr res1, QRealPtr res2, QRealPtr res3, QuadFuncPtr f1, QRealPtr a_, QRealPtr b_)
//{
//    LibQReal_GaussKronrod(res1, res2, res3, f1, a_, b_);
//}
//
//
//
//void Lib_QReal_TanhSinh(QRealPtr res1, QRealPtr res2, QRealPtr res3, int* levels_, QuadFuncPtr f1, QRealPtr a_, QRealPtr b_)
//{
//    LibQReal_TanhSinh(res1, res2, res3, levels_, f1, a_, b_);
//}
//
//
//
//
//void Lib_QReal_SinhSinh(QRealPtr res1, QRealPtr res2, QRealPtr res3, int* levels_, QuadFuncPtr f1)
//{
//    LibQReal_SinhSinh(res1, res2, res3, levels_, f1);
//}
//
//
//
//void Lib_QReal_ExpSinh(QRealPtr res1, QRealPtr res2, QRealPtr res3, int* levels_, QuadFuncPtr f1)
//{
//    LibQReal_ExpSinh(res1, res2, res3, levels_, f1);
//}
//
//
//
//void Lib_QReal_Ooura_Cos(QRealPtr res1, QRealPtr res2, QuadFuncPtr f1)
//{
//    LibQReal_Ooura_Cos(res1, res2, f1);
//}
//
//
//
//void Lib_QReal_Ooura_Sin(QRealPtr res1, QRealPtr res2, QuadFuncPtr f1)
//{
//    LibQReal_Ooura_Sin(res1, res2, f1);
//}
//
//
//
//
//
////*********************** Boost Odeint **********************************
//
//
//
//void Lib_QReal_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_)
//{
//    LibQReal_Const_RungeKutta4((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_);
//}
//
//
//void Lib_QReal_Const_RungeKuttaCashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_)
//{
//    LibQReal_Const_RungeKuttaCashKarp54((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_);
//}
//
//
//void Lib_QReal_Const_RungeKuttaDopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_)
//{
//    LibQReal_Const_RungeKuttaDopri5((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_);
//}
//
//
//void Lib_QReal_Const_RungeKuttaFehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_)
//{
//    LibQReal_Const_RungeKuttaFehlberg78((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_);
//}
//
//
//void Lib_QReal_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_)
//{
//    LibQReal_Const_AdamsBashforthMoulton((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_);
//}
//
//
//
//
//
//
//void Lib_QReal_Adaptive_RungeKuttaDopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_)
//{
//    LibQReal_Adaptive_RungeKuttaDopri5((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_);
//}
//
//
//void Lib_QReal_Adaptive_RungeKuttaCashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_)
//{
//    LibQReal_Adaptive_RungeKuttaCashKarp54((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_);
//}
//
//
//void Lib_QReal_Adaptive_RungeKuttaFehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_)
//{
//    LibQReal_Adaptive_RungeKuttaFehlberg78((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_);
//}
//
//
//void Lib_QReal_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_)
//{
//    LibQReal_Adaptive_BulirschStoer((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_);
//}
//
//
//void Lib_QReal_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_)
//{
//    LibQReal_DenseOutput_Dopri5((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_);
//}
//
//
//void Lib_QReal_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, QRealPtr start_time_, QRealPtr end_time_, QRealPtr dt_, QRealPtr eps_abs_, QRealPtr eps_rel_)
//{
//    LibQReal_DenseOutput_BulirschStoer((QAnyFuncPtr3)f1, (QAnyFuncPtr2)f2, (QStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_);
//}













