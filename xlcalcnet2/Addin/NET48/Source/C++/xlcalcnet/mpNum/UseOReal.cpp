
#include "Helperfunctions.h"

#include "mpNumC_Main.h"

#include "stdint.h"
#include <complex>
#include <limits>



//*********************** OReal Flint **********************************




//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////



void Lib_OReal_Set_Arb(ORealPtr res, const ArbPtr x)
{
	oct_set_arb(res, (arb_ptr)x);
}

//void Lib_OReal_Set_Mpfr(ORealPtr res, const MpfrPtr x)
//{
//	oct_set_(res, (arb_t)x);
//}



void Lib_OCplx_Set_Acb(OCplxPtr res, const ArbPtr x)
{
    octc_set_acb(res, (acb_ptr)x);
}



//void OCplx_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, OCplxPtr res, const int32_t in1)
//{
//    //printf("using OCplx_Cplxfunc0Int32_Prec:  ");
//	slong wp = 255;
//
//	acb_t out1_acb;
//	acb_init(out1_acb);
//
//	f0Int32((acb_ptr)out1_acb, in1, wp);
//
//	octc_set_acb(res, out1_acb);
//
//	acb_clear(out1_acb);
//}
//




void OReal_Arb_Realfunc0Int32_Prec(ArbFuncPtr0Int32 f0Int32, ORealPtr out1, const int32_t in1)
{
	//printf("using OReal_Arb_Realfunc0Int32_Prec:  ");
	slong wp = 255;
	arb_t out1_arb;
	arb_init(out1_arb);

	f0Int32((arb_ptr)out1_arb, in1, wp);

	oct_set_arb(out1, out1_arb);

	arb_clear(out1_arb);
}




void OReal_Arb_Realfunc1_Prec(ArbFuncPtr1 f1, ORealPtr res, const ORealPtr x1)
{
	//printf("using OReal_Arb_Realfunc1_Prec:  ");
	slong wp = 255;

	mpfr_t in1;
	mpfr_init2(in1, wp);
    arb_t out1_arb, in1_arb;
    arb_init(out1_arb); arb_init(in1_arb);

	mpfr_set_oct((mpfr_ptr)in1, x1);
    arf_set_mpfr(arb_midref(in1_arb), in1);

	f1(out1_arb, in1_arb, wp);

	oct_set_arb(res, out1_arb);

	arb_clear(out1_arb); arb_clear(in1_arb);
	mpfr_clear(in1);
}




void OReal_Arb_Realfunc1Int32_Prec(ArbFuncPtr1Int32 f1Int32, ORealPtr res, const ORealPtr x1, const int32_t in2)
{
	//printf("using OReal_Arb_Realfunc1Int32_Prec:  ");
	slong wp = 255;

	mpfr_t in1;
	mpfr_init2(in1, wp);
	arb_t out1_arb, in1_arb;
	arb_init(out1_arb); arb_init(in1_arb);

	mpfr_set_oct((mpfr_ptr)in1, x1); arf_set_mpfr(arb_midref(in1_arb), in1);

	f1Int32(out1_arb, in1_arb, in2, wp);

	oct_set_arb(res, out1_arb);

	arb_clear(out1_arb); arb_clear(in1_arb);
	mpfr_clear(in1);
}



void OReal_Arb_Realfunc2_Prec(ArbFuncPtr2 f2, const ORealPtr res, const ORealPtr x1, const ORealPtr x2)
{
	//printf("using OReal_Arb_Realfunc2_Prec:  ");
	slong wp = 255;

	mpfr_t in1, in2;
	mpfr_init2(in1, wp); mpfr_init2(in2, wp);
	arb_t out1_arb, in1_arb, in2_arb;
	arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb);

	mpfr_set_oct((mpfr_ptr)in1, x1); arf_set_mpfr(arb_midref(in1_arb), in1);
	mpfr_set_oct((mpfr_ptr)in2, x2); arf_set_mpfr(arb_midref(in2_arb), in2);

	f2(out1_arb, in1_arb, in2_arb, wp);

	oct_set_arb(res, out1_arb);

	arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb);
	mpfr_clear(in1); mpfr_clear(in2);
}



void OReal_Arb_Realfunc3_Prec(ArbFuncPtr3 f3, const ORealPtr res, const ORealPtr x1, const ORealPtr x2, const ORealPtr x3)
{
	//printf("using OReal_Arb_Realfunc3_Prec:  ");
	slong wp = 255;

	mpfr_t in1, in2, in3;
	mpfr_init2(in1, wp); mpfr_init2(in2, wp); mpfr_init2(in3, wp);
	arb_t out1_arb, in1_arb, in2_arb, in3_arb;
	arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb);

	mpfr_set_oct((mpfr_ptr)in1, x1); arf_set_mpfr(arb_midref(in1_arb), in1);
	mpfr_set_oct((mpfr_ptr)in2, x2); arf_set_mpfr(arb_midref(in2_arb), in2);
	mpfr_set_oct((mpfr_ptr)in3, x3); arf_set_mpfr(arb_midref(in3_arb), in3);

	f3(out1_arb, in1_arb, in2_arb, in3_arb, wp);

	oct_set_arb(res, out1_arb);

	arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb);
	mpfr_clear(in1); mpfr_clear(in2); mpfr_clear(in3);
}



void OReal_Arb_Realfunc4_Prec(ArbFuncPtr4 f4, ORealPtr res, const ORealPtr x1, const ORealPtr x2, const ORealPtr x3, const ORealPtr x4)
{
	//printf("using OReal_Arb_Realfunc4_Prec:  ");
	slong wp = 255;

	mpfr_t in1, in2, in3, in4;
	mpfr_init2(in1, wp); mpfr_init2(in2, wp); mpfr_init2(in3, wp); mpfr_init2(in4, wp);
	arb_t out1_arb, in1_arb, in2_arb, in3_arb, in4_arb;
	arb_init(out1_arb); arb_init(in1_arb); arb_init(in2_arb); arb_init(in3_arb); arb_init(in4_arb);

	mpfr_set_oct((mpfr_ptr)in1, x1); arf_set_mpfr(arb_midref(in1_arb), in1);
	mpfr_set_oct((mpfr_ptr)in2, x2); arf_set_mpfr(arb_midref(in2_arb), in2);
	mpfr_set_oct((mpfr_ptr)in3, x3); arf_set_mpfr(arb_midref(in3_arb), in3);
	mpfr_set_oct((mpfr_ptr)in4, x4); arf_set_mpfr(arb_midref(in4_arb), in4);


	f4(out1_arb, in1_arb, in2_arb, in3_arb, in4_arb, wp);

	oct_set_arb(res, out1_arb);

	arb_clear(out1_arb); arb_clear(in1_arb); arb_clear(in2_arb); arb_clear(in3_arb); arb_clear(in4_arb);
	mpfr_clear(in1); mpfr_clear(in2); mpfr_clear(in3); mpfr_clear(in4);
}



void OCplx_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, OCplxPtr res, const int32_t in1)
{
    //printf("using OCplx_Cplxfunc0Int32_Prec:  ");
	slong wp = 255;

	acb_t out1_acb;
	acb_init(out1_acb);

	f0Int32((acb_ptr)out1_acb, in1, wp);

	octc_set_acb(res, out1_acb);

	acb_clear(out1_acb);
}



void OCplx_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, OCplxPtr res, const OCplxPtr x1)
{
    //printf("using OCplx_Cplxfunc1_Prec:  ");
	slong wp = 255;

	mpc_t in1;
	mpc_init2(in1, wp);
	mpfc_set_octc(in1, x1);

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_mpc(in1_acb, in1);

	f1(out1_acb, in1_acb, wp);

	octc_set_acb(res, out1_acb);

	acb_clear(out1_acb); acb_clear(in1_acb);
	mpc_clear(in1);
}



void OCplx_Acb_Cplxfunc1Int32_Prec(AcbFuncPtr1Int32 f1Int32, OCplxPtr res, const OCplxPtr x1, const int32_t in2)
{
    //printf("using OCplx_Cplxfunc1Int32_Prec:  ");
	slong wp = 255;

	mpc_t out1, in1;
	mpc_init2(out1, wp); mpc_init2(in1, wp);
	mpfc_set_octc(in1, x1);

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_mpc(in1_acb, in1);

	f1Int32((acb_ptr)out1_acb, (acb_ptr)in1_acb, in2, wp);

	octc_set_acb(res, out1_acb);

	acb_clear(out1_acb); acb_clear(in1_acb);
	mpc_clear(in1);
}



void OCplx_Acb_Cplxfunc2_Prec(AcbFuncPtr2 f2, OCplxPtr res, const OCplxPtr x1, const OCplxPtr x2)
{
    //printf("using OCplx_Cplxfunc2_Prec:  ");
	slong wp = 255;

	mpc_t in1, in2;
	mpc_init2(in1, wp); mpc_init2(in2, wp);
	mpfc_set_octc(in1, x1); mpfc_set_octc(in2, x2);

    acb_t out1_acb, in1_acb, in2_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2);

	f2(out1_acb, in1_acb, in2_acb, wp);

	octc_set_acb(res, out1_acb);

	acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb);
    mpc_clear(in1); mpc_clear(in2);
}



void OCplx_Acb_Cplxfunc3_Prec(AcbFuncPtr3 f3, OCplxPtr res, const OCplxPtr x1, const OCplxPtr x2, const OCplxPtr x3)
{
    //printf("using OCplx_Cplxfunc3_Prec:  ");
	slong wp = 255;

	mpc_t in1, in2, in3;
	mpc_init2(in1, wp); mpc_init2(in2, wp); mpc_init2(in3, wp);
	mpfc_set_octc(in1, x1); mpfc_set_octc(in2, x2); mpfc_set_octc(in3, x3);

    acb_t out1_acb, in1_acb, in2_acb, in3_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2); acb_set_mpc(in3_acb, in3);

	f3(out1_acb, in1_acb, in2_acb, in3_acb, wp);

	octc_set_acb(res, out1_acb);

	acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb);
	mpc_clear(in1); mpc_clear(in2); mpc_clear(in3);
}



void OCplx_Acb_Cplxfunc4_Prec(AcbFuncPtr4 f4, OCplxPtr res, const OCplxPtr x1, const OCplxPtr x2, const OCplxPtr x3, const OCplxPtr x4)
{
    //printf("using OCplx_Cplxfunc4_Prec:  ");
	slong wp = 255;

	mpc_t in1, in2, in3, in4;
	mpc_init2(in1, wp); mpc_init2(in2, wp); mpc_init2(in3, wp); mpc_init2(in4, wp);
	mpfc_set_octc(in1, x1); mpfc_set_octc(in2, x2); mpfc_set_octc(in3, x3); mpfc_set_octc(in4, x4);

    acb_t out1_acb, in1_acb, in2_acb, in3_acb, in4_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb); acb_init(in4_acb);
    acb_set_mpc(in1_acb, in1); acb_set_mpc(in2_acb, in2); acb_set_mpc(in3_acb, in3); acb_set_mpc(in4_acb, in4);

	f4(out1_acb, in1_acb, in2_acb, in3_acb, in4_acb, wp);

	octc_set_acb(res, out1_acb);

	acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb); acb_clear(in4_acb);
	mpc_clear(in1); mpc_clear(in2); mpc_clear(in3); mpc_clear(in4);
}






/* Roots and quadratic, cubic, and quartic equations */


void Lib_OReal_Arb_Sqrt(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sqrt, res, x);
}


void Lib_OReal_Arb_Rsqrt(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_rsqrt, res, x);
}


void Lib_OReal_Arb_Cbrt(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_cbrt, res, x);
}


void Lib_OReal_Arb_Sqrt1pm1(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sqrt1pm1, res, x);
}


void Lib_OReal_Arb_Root_ui(ORealPtr res, const ORealPtr x, const int32_t n)
{
    OReal_Arb_Realfunc1Int32_Prec(arb_root_ui_, res, x, n);
}


void Lib_OReal_Arb_Root_si(ORealPtr res, const ORealPtr x, const int32_t n)
{
    OReal_Arb_Realfunc1Int32_Prec(arb_root_si_, res, x, n);
}






/* Exponential and related functions */



void Lib_OReal_Arb_Exp(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_exp, res, x);
}


void Lib_OReal_Arb_Expm1(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_expm1, res, x);
}


void Lib_OReal_Arb_Exp10(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_exp10_, res, x);
}


void Lib_OReal_Arb_Exp2(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_exp2_, res, x);
}


void Lib_OReal_Arb_Exp10m1(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_exp10m1_, res, x);
}


void Lib_OReal_Arb_Exp2m1(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_exp2m1_, res, x);
}


void Lib_OReal_Arb_ExpRel(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_exprel_, res, x);
}




/* Logarithms and related functions */



void Lib_OReal_Arb_Log(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_log, res, x);
}


void Lib_OReal_Arb_Logbase(ORealPtr res, const ORealPtr x, const ORealPtr b)
{
    OReal_Arb_Realfunc2_Prec(arb_logbase_, res, x, b);
}


void Lib_OReal_Arb_Log10(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_log10, res, x);
}


void Lib_OReal_Arb_Log2(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_log2, res, x);
}


void Lib_OReal_Arb_Log1p(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_log1p, res, x);
}


void Lib_OReal_Arb_Log10p1(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_log10p1_, res, x);
}


void Lib_OReal_Arb_Log2p1(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_log2p1_, res, x);
}


void Lib_OReal_Arb_Log1mexp(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_log1mexp_, res, x);
}


void Lib_OReal_Arb_LambertW0(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_lambertw0, res, x);
}


void Lib_OReal_Arb_LambertWm1(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_lambertwm1, res, x);
}






/* Power functions */


void Lib_OReal_Arb_Square(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sqr, res, x);
}


void Lib_OReal_Arb_Cube(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_cube_, res, x);
}


void Lib_OReal_Arb_Pow_ui(ORealPtr res, const ORealPtr x, const int32_t n)
{
    OReal_Arb_Realfunc1Int32_Prec(arb_pow_ui_, res, x, n);
}


void Lib_OReal_Arb_Pow_si(ORealPtr res, const ORealPtr x, const int32_t n)
{
    OReal_Arb_Realfunc1Int32_Prec(arb_pow_si_, res, x, n);
}


void Lib_OReal_Arb_Compound_si(ORealPtr res, const ORealPtr x, const int32_t n)
{
    OReal_Arb_Realfunc1Int32_Prec(arb_compound_si_, res, x, n);
}



void Lib_OReal_Arb_Hypot(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypot, res, x, y);
}


void Lib_OReal_Arb_Pow(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_pow, res, x, y);
}


void Lib_OReal_Arb_Powm1(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_powm1_, res, x, y);
}


void Lib_OReal_Arb_Pow1p(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_pow1p_, res, x, y);
}


void Lib_OReal_Arb_Pow1pm1(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_pow1pm1_, res, x, y);
}





/* Trigonometric and related functions */


void Lib_OReal_Arb_Sin(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sin, res, x);
}


void Lib_OReal_Arb_Cos(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_cos, res, x);
}


void Lib_OReal_Arb_Tan(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_tan, res, x);
}



void Lib_OReal_Arb_Csc(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_csc, res, x);
}


void Lib_OReal_Arb_Sec(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sec, res, x);
}


void Lib_OReal_Arb_Cot(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_cot, res, x);
}


void Lib_OReal_Arb_Sinc(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sinc, res, x);
}


void Lib_OReal_Arb_SincPi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sinc_pi, res, x);
}


void Lib_OReal_Arb_SinPi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sin_pi, res, x);
}


void Lib_OReal_Arb_CosPi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_cos_pi, res, x);
}


void Lib_OReal_Arb_TanPi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_tan_pi, res, x);
}


void Lib_OReal_Arb_CotPi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_cot_pi, res, x);
}




/* Hyperbolic functions */


void Lib_OReal_Arb_Sinh(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sinh, res, x);
}


void Lib_OReal_Arb_Cosh(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_cosh, res, x);
}


void Lib_OReal_Arb_Tanh(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_tanh, res, x);
}



void Lib_OReal_Arb_Csch(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_csch, res, x);
}


void Lib_OReal_Arb_Sech(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_sech, res, x);
}


void Lib_OReal_Arb_Coth(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_coth, res, x);
}





/* Inverse trigonometric functions */


void Lib_OReal_Arb_Asin(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_asin, res, x);
}


void Lib_OReal_Arb_Acos(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_acos, res, x);
}



void Lib_OReal_Arb_Atan2(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_atan2, res, x, y);
}


void Lib_OReal_Arb_Atan(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_atan, res, x);
}



void Lib_OReal_Arb_Acsc(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_acsc, res, x);
}


void Lib_OReal_Arb_Asec(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_asec, res, x);
}


void Lib_OReal_Arb_Acot(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_OReal_Arb_Asinh(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_asinh, res, x);
}


void Lib_OReal_Arb_Acosh(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_acosh, res, x);
}


void Lib_OReal_Arb_Atanh(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_atanh, res, x);
}



void Lib_OReal_Arb_Acsch(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_acsch, res, x);
}


void Lib_OReal_Arb_Asech(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_asech, res, x);
}


void Lib_OReal_Arb_Acoth(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_acoth, res, x);
}







/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_OReal_Arb_MEllipticK(ORealPtr res, const ORealPtr m)
{
    OReal_Arb_Realfunc1_Prec(arb_elliptic_k, res, m);
}


void Lib_OReal_Arb_MEllipticE(ORealPtr res, const ORealPtr m)
{
    OReal_Arb_Realfunc1_Prec(arb_elliptic_e, res, m);
}


void Lib_OReal_Arb_MEllipticPi(ORealPtr res, const ORealPtr n, const ORealPtr m)
{
    OReal_Arb_Realfunc2_Prec(arb_elliptic_pi, res, n, m);
}


void Lib_OReal_Arb_MEllipticF(ORealPtr res, const ORealPtr phi, const ORealPtr m)
{
    OReal_Arb_Realfunc2_Prec(arb_elliptic_f_, res, phi, m);
}


void Lib_OReal_Arb_MEllipticEInc(ORealPtr res, const ORealPtr phi, const ORealPtr m)
{
    OReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_, res, phi, m);
}


void Lib_OReal_Arb_MEllipticPiInc(ORealPtr res, const ORealPtr n, const ORealPtr phi, const ORealPtr m)
{
    OReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_, res, n, phi, m);
}




/* Legendre elliptic integrals (elliptic modulus k), and related functions */




void Lib_OReal_Arb_EllipticK(ORealPtr res, const ORealPtr k)
{
    OReal_Arb_Realfunc1_Prec(arb_elliptic_k_k_, res, k);
}


void Lib_OReal_Arb_EllipticE(ORealPtr res, const ORealPtr k)
{
    OReal_Arb_Realfunc1_Prec(arb_elliptic_e_k_, res, k);
}


void Lib_OReal_Arb_EllipticPi(ORealPtr res, const ORealPtr n, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(arb_elliptic_pi_k_, res, n, k);
}


void Lib_OReal_Arb_EllipticF(ORealPtr res, const ORealPtr phi, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(arb_elliptic_f_k_, res, phi, k);
}


void Lib_OReal_Arb_EllipticEInc(ORealPtr res, const ORealPtr phi, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(arb_elliptic_e_inc_k_, res, phi, k);
}


void Lib_OReal_Arb_EllipticPiInc(ORealPtr res, const ORealPtr n, const ORealPtr phi, const ORealPtr k)
{
    OReal_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_k_, res, n, phi, k);
}


void Lib_OReal_Arb_Agm(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */


void Lib_OReal_Arb_Elliptic_RC(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_elliptic_rc_, res, x, y);
}


void Lib_OReal_Arb_Elliptic_RF(ORealPtr res, const ORealPtr x, const ORealPtr y, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_elliptic_rf_, res, x, y, z);
}


void Lib_OReal_Arb_Elliptic_RG(ORealPtr res, const ORealPtr x, const ORealPtr y, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_elliptic_rg_, res, x, y, z);
}


void Lib_OReal_Arb_Elliptic_RD(ORealPtr res, const ORealPtr x, const ORealPtr y, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_elliptic_rd_, res, x, y, z);
}


void Lib_OReal_Arb_Elliptic_RJ(ORealPtr res, const ORealPtr x, const ORealPtr y, const ORealPtr z, const ORealPtr w)
{
    OReal_Arb_Realfunc4_Prec(arb_elliptic_rj_, res, x, y, z, w);
}





/* Jacobi theta functions */


void Lib_OReal_Arb_Theta1Q(ORealPtr res, const ORealPtr z, const ORealPtr q)
{
    OReal_Arb_Realfunc2_Prec(_arb_theta1q, res, z, q);
}


void Lib_OReal_Arb_Theta2Q(ORealPtr res, const ORealPtr z, const ORealPtr q)
{
    OReal_Arb_Realfunc2_Prec(_arb_theta2q, res, z, q);
}


void Lib_OReal_Arb_Theta3Q(ORealPtr res, const ORealPtr z, const ORealPtr q)
{
    OReal_Arb_Realfunc2_Prec(_arb_theta3q, res, z, q);
}


void Lib_OReal_Arb_Theta4Q(ORealPtr res, const ORealPtr z, const ORealPtr q)
{
    OReal_Arb_Realfunc2_Prec(_arb_theta4q, res, z, q);
}




/* Jacobi elliptic functions */



void Lib_OReal_Arb_JacobiSN(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_sn, res, u, k);
}


void Lib_OReal_Arb_JacobiCN(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_cn, res, u, k);
}


void Lib_OReal_Arb_JacobiDN(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_dn, res, u, k);
}


void Lib_OReal_Arb_JacobiNS(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_ns, res, u, k);
}


void Lib_OReal_Arb_JacobiNC(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_nc, res, u, k);
}


void Lib_OReal_Arb_JacobiND(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_nd, res, u, k);
}


void Lib_OReal_Arb_JacobiSC(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_sc, res, u, k);
}


void Lib_OReal_Arb_JacobiSD(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_sd, res, u, k);
}


void Lib_OReal_Arb_JacobiDC(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_dc, res, u, k);
}


void Lib_OReal_Arb_JacobiDS(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_ds, res, u, k);
}


void Lib_OReal_Arb_JacobiCS(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_cs, res, u, k);
}


void Lib_OReal_Arb_JacobiCD(ORealPtr res, const ORealPtr u, const ORealPtr k)
{
    OReal_Arb_Realfunc2_Prec(_arb_jacobi_cd, res, u, k);
}





/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */



void Lib_OReal_Arb_LerchPhi(ORealPtr res, const ORealPtr z, const ORealPtr s, const ORealPtr a)
{
    OReal_Arb_Realfunc3_Prec(arb_dirichlet_lerch_phi, res, z, s, a);
}





/* Polygamma functions */


void Lib_OReal_Arb_Polygamma(ORealPtr res, const ORealPtr s, const ORealPtr z)
{
    OReal_Arb_Realfunc2_Prec(arb_polygamma, res, s, z);
}


void Lib_OReal_Arb_Digamma(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_digamma, res, x);
}



/* Polylogarithms and related functions */




void Lib_OReal_Arb_Polylog(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_polylog, res, x, y);
}


void Lib_OReal_Arb_Dilog(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_dilog, res, x);
}



/* Hurwitz zeta function and related functions */


void Lib_OReal_Arb_HurwitzZeta(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hurwitz_zeta, res, x, y);
}



void Lib_OReal_Arb_Bernoulli_ui(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_bernoulli_ui_, res, n);
}


void Lib_OReal_Arb_Euler_ui(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_euler_number_ui_, res, n);
}



void Lib_OReal_Arb_BernoulliPoly_ui(ORealPtr res, const ORealPtr x, const int32_t n)
{
    OReal_Arb_Realfunc1Int32_Prec(arb_bernoulli_poly_ui_, res, x, n);
}



void Lib_OReal_Arb_BarnesG(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_barnes_g, res, x);
}


void Lib_OReal_Arb_LogBarnesG(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */



void Lib_OReal_Arb_Zeta(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_zeta, res, x);
}




void Lib_OReal_Arb_BacklundS(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(acb_dirichlet_backlund_s, res, x);
}


void Lib_OReal_Arb_GramPoint_ui(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_gram_point_ui_, res, n);
}







/* Additional numbertheoretic functions */


void Lib_OReal_Arb_Bell_ui(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_bell_ui_, res, n);
}


void Lib_OReal_Arb_Partitions_ui(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_partitions_ui_, res, n);
}


void Lib_OReal_Arb_Primorial_ui(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_primorial_nth_ui_, res, n);
}






/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_OReal_Arb_Hypgeom0F1(ORealPtr res, const ORealPtr a, const ORealPtr x)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_, res, a, x);
}


void Lib_OReal_Arb_Hypgeom0F1r(ORealPtr res, const ORealPtr a, const ORealPtr x)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */


void Lib_OReal_Arb_BesselJ(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_j, res, x, y);
}


void Lib_OReal_Arb_BesselY(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_y, res, x, y);
}


void Lib_OReal_Arb_BesselI(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i, res, x, y);
}


void Lib_OReal_Arb_BesselK(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k, res, x, y);
}


void Lib_OReal_Arb_BesselIScaled(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_OReal_Arb_BesselKScaled(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k_scaled, res, x, y);
}



/* Spherical Bessel functions  */





/* Airy functions  */



void Lib_OReal_Arb_AiryAi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_airy_ai, res, x);
}


void Lib_OReal_Arb_AiryAiPrime(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_airy_ai_prime, res, x);
}


void Lib_OReal_Arb_AiryBi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_airy_bi, res, x);
}


void Lib_OReal_Arb_AiryBiPrime(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_airy_bi_prime, res, x);
}




void Lib_OReal_Arb_AiryAiZero(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_zero, res, n);
}


void Lib_OReal_Arb_AiryAiPrimeZero(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_airy_ai_prime_zero, res, n);
}


void Lib_OReal_Arb_AiryBiZero(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_zero, res, n);
}


void Lib_OReal_Arb_AiryBiPrimeZero(ORealPtr res, const int32_t n)
{
    OReal_Arb_Realfunc0Int32_Prec(arb_airy_bi_prime_zero, res, n);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


void Lib_OReal_Arb_Hypgeom1F1(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1_, res, a, b, z);
}


void Lib_OReal_Arb_Hypgeom1F1r(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_OReal_Arb_HypgeomU(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_u, res, a, b, z);
}






/* Gamma function and related functions */


void Lib_OReal_Arb_Gamma(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_gamma, res, x);
}


void Lib_OReal_Arb_Rgamma(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_rgamma, res, x);
}


void Lib_OReal_Arb_Lgamma(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_lgamma, res, x);
}


void Lib_OReal_Arb_RisingFactorial(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_rising, res, x, y);
}


void Lib_OReal_Arb_Beta(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_beta_, res, x, y);
}





/* Incomplete gamma functions */



void Lib_OReal_Arb_GammaUpper(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_gamma_upper_, res, x, y);
}


void Lib_OReal_Arb_GammaUpperR(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_gamma_upper_r, res, x, y);
}


void Lib_OReal_Arb_GammaLower(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_gamma_lower_, res, x, y);
}
//
//
//void Lib_OReal_Arb_GammaLowerR(ORealPtr res, const ORealPtr x, const ORealPtr y)
//{
//    OReal_Arb_Realfunc2_Prec(arb_gamma_lower_r, res, x, y);
//}



void Lib_OReal_Arb_GammaPPrime(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_gamma_p_derivative, res, x, y);
}


void Lib_OReal_Arb_GammaP(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_gamma_p, res, x, y);
}


void Lib_OReal_Arb_GammaQ(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_gamma_q, res, x, y);
}





/* Error function and related functions */


void Lib_OReal_Arb_Erf(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_erf, res, x);
}


void Lib_OReal_Arb_Erfc(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_erfc, res, x);
}


void Lib_OReal_Arb_ErfInv(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_erfinv, res, x);
}


void Lib_OReal_Arb_ErfcInv(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_erfcinv, res, x);
}


void Lib_OReal_Arb_Erfi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_erfi, res, x);
}


void Lib_OReal_Arb_FresnelC(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_fresnelc, res, x);
}


void Lib_OReal_Arb_FresnelS(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_fresnels, res, x);
}


void Lib_OReal_Arb_Ndens(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_ndens, res, x);
}


void Lib_OReal_Arb_Ndis(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_ndis, res, x);
}







/* Exponential integrals and related functions */



void Lib_OReal_Arb_ExpIntegralE(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_expint, res, x, y);
}



void Lib_OReal_Arb_ExpIntegralEi(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_ei, res, x);
}


void Lib_OReal_Arb_SinIntegral(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_si, res, x);
}


void Lib_OReal_Arb_CosIntegral(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_ci, res, x);
}


void Lib_OReal_Arb_SinhIntegral(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_shi, res, x);
}


void Lib_OReal_Arb_CoshIntegral(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_chi, res, x);
}


void Lib_OReal_Arb_LogIntegral(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_li_, res, x);
}


void Lib_OReal_Arb_LogIntegralOffset(ORealPtr res, const ORealPtr x)
{
    OReal_Arb_Realfunc1_Prec(arb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_OReal_Arb_HermiteH(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_hermite_h, res, x, y);
}


void Lib_OReal_Arb_LaguerreL(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_laguerre_l, res, a, b, z);
}




/* 1F1: Coulomb functions */


void Lib_OReal_Arb_CoulombF(ORealPtr res, const ORealPtr l, const ORealPtr eta, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_OReal_Arb_CoulombG(ORealPtr res, const ORealPtr l, const ORealPtr eta, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_g, res, l, eta, z);
}






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_OReal_Arb_Hypgeom2F1(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr c, const ORealPtr z)
{
    OReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_OReal_Arb_Hypgeom2F1r(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr c, const ORealPtr z)
{
    OReal_Arb_Realfunc4_Prec(arb_hypgeom_2f1r_, res, a, b, c, z);
}





/* 2F1: Orthogonal polynomials */


void Lib_OReal_Arb_ChebyshevT(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_OReal_Arb_ChebyshevU(ORealPtr res, const ORealPtr x, const ORealPtr y)
{
    OReal_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_OReal_Arb_GegenbauerC(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_OReal_Arb_LegendreP(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_OReal_Arb_LegendrePv(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_OReal_Arb_LegendreQ(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_OReal_Arb_LegendreQv(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_legendre_qv_, res, a, b, z);
}


void Lib_OReal_Arb_JacobiP(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr c, const ORealPtr z)
{
    OReal_Arb_Realfunc4_Prec(arb_hypgeom_jacobi_p, res, a, b, c, z);
}





/* 2F1: Incomplete Beta Function */


void Lib_OReal_Arb_BetaLower(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_, res, a, b, z);
}


//void Lib_OReal_Arb_BetaLowerR(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
//{
//    OReal_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_r_, res, a, b, z);
//}



void Lib_OReal_Arb_Ibeta(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_ibeta, res, a, b, z);
}


void Lib_OReal_Arb_Ibetac(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_ibetac, res, a, b, z);
}



void Lib_OReal_Arb_IbetaPrime(ORealPtr res, const ORealPtr a, const ORealPtr b, const ORealPtr z)
{
    OReal_Arb_Realfunc3_Prec(arb_ibeta_derivative, res, a, b, z);
}






/* Hypergeometric Function 1F2, overview */


void Lib_OReal_Arb_Hypgeom1F2(ORealPtr res, const ORealPtr a1, const ORealPtr b1, const ORealPtr b2, const ORealPtr z)
{
    OReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_OReal_Arb_Hypgeom1F2r(ORealPtr res, const ORealPtr a1, const ORealPtr b1, const ORealPtr b2, const ORealPtr z)
{
    OReal_Arb_Realfunc4_Prec(arb_hypgeom_1f2r_, res, a1, b1, b2, z);
}


















//////////////////////////////////////////////////////
//// Acb functions
//////////////////////////////////////////////////////






/* Roots and quadratic, cubic, and quartic equations */


void Lib_OCplx_Acb_UnitRoot_ui(OCplxPtr res, const int32_t n)
{
    OCplx_Acb_Cplxfunc0Int32_Prec(acb_unit_root_, res, n);
}


void Lib_OCplx_Acb_Sqrt(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sqrt, res, x);
}


void Lib_OCplx_Acb_Rsqrt(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_rsqrt, res, x);
}


void Lib_OCplx_Acb_Cbrt(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_cbrt, res, x);
}


void Lib_OCplx_Acb_Sqrt1pm1(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sqrt1pm1, res, x);
}


void Lib_OCplx_Acb_Root_ui(OCplxPtr res, const OCplxPtr x, const int32_t n)
{
    OCplx_Acb_Cplxfunc1Int32_Prec(acb_root_ui_, res, x, n);
}






/* Exponential and related functions */


void Lib_OCplx_Acb_Exp(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_exp, res, x);
}


void Lib_OCplx_Acb_Expj(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_expj_, res, x);
}


void Lib_OCplx_Acb_Expjpi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_exp_pi_i, res, x);
}


void Lib_OCplx_Acb_Expm1(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_expm1, res, x);
}


void Lib_OCplx_Acb_Exp10(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_exp10_, res, x);
}


void Lib_OCplx_Acb_Exp2(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_exp2_, res, x);
}


void Lib_OCplx_Acb_Exp10m1(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_exp10m1_, res, x);
}


void Lib_OCplx_Acb_Exp2m1(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_exp2m1_, res, x);
}


void Lib_OCplx_Acb_ExpRel(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_exprel_, res, x);
}






/* Logarithms and related functions */



void Lib_OCplx_Acb_Log(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_log, res, x);
}


void Lib_OCplx_Acb_Logbase(OCplxPtr res, const OCplxPtr x, const OCplxPtr b)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_logbase_, res, x, b);
}


void Lib_OCplx_Acb_Log1p(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_log1p, res, x);
}


void Lib_OCplx_Acb_Log10(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_log10_, res, x);
}


void Lib_OCplx_Acb_Log2(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_log2_, res, x);
}


void Lib_OCplx_Acb_Log10p1(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_log10p1_, res, x);
}



void Lib_OCplx_Acb_Log2p1(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_log2p1_, res, x);
}




void Lib_OCplx_Acb_LambertW_ui(OCplxPtr res, const OCplxPtr x, const int32_t n)
{
    OCplx_Acb_Cplxfunc1Int32_Prec(acb_lambertw_ui_, res, x, n);
}







/* Power functions */


void Lib_OCplx_Acb_Square(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sqr, res, x);
}


void Lib_OCplx_Acb_Cube(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_cube, res, x);
}


void Lib_OCplx_Acb_Pow_si(OCplxPtr res, const OCplxPtr x, const int32_t n)
{
    OCplx_Acb_Cplxfunc1Int32_Prec(acb_pow_si_, res, x, n);
}



void Lib_OCplx_Acb_Hypot(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypot_, res, x, y);
}


void Lib_OCplx_Acb_Pow(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
}


void Lib_OCplx_Acb_Powm1(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_powm1_, res, x, y);
}


void Lib_OCplx_Acb_Pow1p(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_pow1p_, res, x, y);
}


void Lib_OCplx_Acb_Pow1pm1(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_pow1pm1_, res, x, y);
}







/* Trigonometric and related functions */



void Lib_OCplx_Acb_Sin(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sin, res, x);
}


void Lib_OCplx_Acb_Cos(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_cos, res, x);
}


void Lib_OCplx_Acb_Tan(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_tan, res, x);
}



void Lib_OCplx_Acb_Csc(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_csc, res, x);
}


void Lib_OCplx_Acb_Sec(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sec, res, x);
}


void Lib_OCplx_Acb_Cot(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_cot, res, x);
}





/* Hyperbolic functions */


void Lib_OCplx_Acb_Sinh(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sinh, res, x);
}


void Lib_OCplx_Acb_Cosh(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_cosh, res, x);
}


void Lib_OCplx_Acb_Tanh(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_tanh, res, x);
}



void Lib_OCplx_Acb_Csch(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_csch, res, x);
}


void Lib_OCplx_Acb_Sech(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sech, res, x);
}


void Lib_OCplx_Acb_Coth(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_coth, res, x);
}



void Lib_OCplx_Acb_Sinc(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sinc, res, x);
}


void Lib_OCplx_Acb_SincPi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sinc_pi, res, x);
}



void Lib_OCplx_Acb_SinPi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sin_pi, res, x);
}


void Lib_OCplx_Acb_CosPi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_cos_pi, res, x);
}


void Lib_OCplx_Acb_TanPi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_tan_pi, res, x);
}


void Lib_OCplx_Acb_CotPi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_cot_pi, res, x);
}


void Lib_OCplx_Acb_CscPi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_csc_pi, res, x);
}


void Lib_OCplx_Acb_SecPi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_sec_pi_, res, x);
}







/* Inverse trigonometric functions */


void Lib_OCplx_Acb_Asin(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_asin, res, x);
}


void Lib_OCplx_Acb_Acos(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_acos, res, x);
}


void Lib_OCplx_Acb_Atan(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_atan, res, x);
}



void Lib_OCplx_Acb_Acsc(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_acsc, res, x);
}


void Lib_OCplx_Acb_Asec(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_asec, res, x);
}


void Lib_OCplx_Acb_Acot(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_OCplx_Acb_Asinh(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_asinh, res, x);
}


void Lib_OCplx_Acb_Acosh(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_acosh, res, x);
}


void Lib_OCplx_Acb_Atanh(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_atanh, res, x);
}



void Lib_OCplx_Acb_Acsch(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_acsch, res, x);
}


void Lib_OCplx_Acb_Asech(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_asech, res, x);
}


void Lib_OCplx_Acb_Acoth(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_acoth, res, x);
}









/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_OCplx_Acb_MEllipticK(OCplxPtr res, const OCplxPtr m)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k, res, m);
}


void Lib_OCplx_Acb_MEllipticE(OCplxPtr res, const OCplxPtr m)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e, res, m);
}


void Lib_OCplx_Acb_MEllipticPi(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi, res, phi, m);

}


void Lib_OCplx_Acb_MEllipticF(OCplxPtr res, const OCplxPtr phi, const OCplxPtr m)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_, res, phi, m);

}


void Lib_OCplx_Acb_MEllipticEInc(OCplxPtr res, const OCplxPtr n, const OCplxPtr m)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_, res, n, m);
}


void Lib_OCplx_Acb_MEllipticPiInc(OCplxPtr res, const OCplxPtr n, const OCplxPtr phi, const OCplxPtr m)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_, res, n, phi, m);
}







/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_OCplx_Acb_EllipticK(OCplxPtr res, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_elliptic_k_k_, res, k);
}


void Lib_OCplx_Acb_EllipticE(OCplxPtr res, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_elliptic_e_k_, res, k);
}


void Lib_OCplx_Acb_EllipticPi(OCplxPtr res, const OCplxPtr phi, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_pi_k_, res, phi, k);

}


void Lib_OCplx_Acb_EllipticF(OCplxPtr res, const OCplxPtr phi, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_f_k_, res, phi, k);

}


void Lib_OCplx_Acb_EllipticEInc(OCplxPtr res, const OCplxPtr n, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_k_, res, n, k);
}


void Lib_OCplx_Acb_EllipticPiInc(OCplxPtr res, const OCplxPtr n, const OCplxPtr phi, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_k_, res, n, phi, k);
}



void Lib_OCplx_Acb_Agm(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */

void Lib_OCplx_Acb_Elliptic_RC(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_rc_, res, x, y);
}



void Lib_OCplx_Acb_Elliptic_RF(OCplxPtr res, const OCplxPtr x, const OCplxPtr y, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rf_, res, x, y, z);
}


void Lib_OCplx_Acb_Elliptic_RG(OCplxPtr res, const OCplxPtr x, const OCplxPtr y, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rg_, res, x, y, z);
}


void Lib_OCplx_Acb_Elliptic_RD(OCplxPtr res, const OCplxPtr x, const OCplxPtr y, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_elliptic_rd_, res, x, y, z);
}


void Lib_OCplx_Acb_Elliptic_RJ(OCplxPtr res, const OCplxPtr x, const OCplxPtr y, const OCplxPtr z, const OCplxPtr w)
{
    OCplx_Acb_Cplxfunc4_Prec(acb_elliptic_rj_, res, x, y, z, w);
}






/* Jacobi theta functions */


void Lib_OCplx_Acb_Theta1Q(OCplxPtr res, const OCplxPtr z, const OCplxPtr q)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_theta1q, res, z, q);
}


void Lib_OCplx_Acb_Theta2Q(OCplxPtr res, const OCplxPtr z, const OCplxPtr q)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_theta2q, res, z, q);
}


void Lib_OCplx_Acb_Theta3Q(OCplxPtr res, const OCplxPtr z, const OCplxPtr q)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_theta3q, res, z, q);
}


void Lib_OCplx_Acb_Theta4Q(OCplxPtr res, const OCplxPtr z, const OCplxPtr q)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_theta4q, res, z, q);
}



void Lib_OCplx_Acb_Theta1Tau(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_theta1, res, z, tau);
}


void Lib_OCplx_Acb_Theta2Tau(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_theta2, res, z, tau);
}


void Lib_OCplx_Acb_Theta3Tau(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_theta3, res, z, tau);
}


void Lib_OCplx_Acb_Theta4Tau(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_theta4, res, z, tau);
}







/* Jacobi elliptic functions */


void Lib_OCplx_Acb_QfromK(OCplxPtr res, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_qfromk, res, k);
}


void Lib_OCplx_Acb_TfromUQ(OCplxPtr res, const OCplxPtr u, const OCplxPtr q)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_tfrom_u_q, res, u, q);
}


void Lib_OCplx_Acb_SnTQ(OCplxPtr res, const OCplxPtr t, const OCplxPtr q)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_sn_t_q, res, t, q);
}


void Lib_OCplx_Acb_CnTQ(OCplxPtr res, const OCplxPtr t, const OCplxPtr q)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_cn_t_q, res, t, q);
}


void Lib_OCplx_Acb_DnTQ(OCplxPtr res, const OCplxPtr t, const OCplxPtr q)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_dn_t_q, res, t, q);
}


void Lib_OCplx_Acb_JacobiSN(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sn, res, u, k);
}


void Lib_OCplx_Acb_JacobiCN(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cn, res, u, k);
}


void Lib_OCplx_Acb_JacobiDN(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dn, res, u, k);
}





void Lib_OCplx_Acb_JacobiNS(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ns, res, u, k);
}


void Lib_OCplx_Acb_JacobiNC(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nc, res, u, k);
}


void Lib_OCplx_Acb_JacobiND(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_nd, res, u, k);
}




void Lib_OCplx_Acb_JacobiSC(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sc, res, u, k);
}


void Lib_OCplx_Acb_JacobiSD(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_sd, res, u, k);
}




void Lib_OCplx_Acb_JacobiDC(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_dc, res, u, k);
}


void Lib_OCplx_Acb_JacobiDS(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_ds, res, u, k);
}




void Lib_OCplx_Acb_JacobiCS(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cs, res, u, k);
}


void Lib_OCplx_Acb_JacobiCD(OCplxPtr res, const OCplxPtr u, const OCplxPtr k)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_jacobi_cd, res, u, k);
}







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


void Lib_OCplx_Acb_WeierstrassP(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_p, res, z, tau);
}


void Lib_OCplx_Acb_WeierstrassPInv(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_inv_p, res, z, tau);
}


void Lib_OCplx_Acb_WeierstrassPZeta(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_zeta, res, z, tau);
}


void Lib_OCplx_Acb_WeierstrassPSigma(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_elliptic_sigma, res, z, tau);
}



void Lib_OCplx_Acb_WeierstrassPPrime(OCplxPtr res, const OCplxPtr z, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_wp_prime, res, z, tau);
}



void Lib_OCplx_Acb_EllipticInvariantG2(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g2, res, tau);
}


void Lib_OCplx_Acb_EllipticInvariantG3(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g3, res, tau);
}


void Lib_OCplx_Acb_EllipticRootE1(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e1, res, tau);
}


void Lib_OCplx_Acb_EllipticRootE2(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e2, res, tau);
}


void Lib_OCplx_Acb_EllipticRootE3(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e3, res, tau);
}



void Lib_OCplx_Acb_DedekindEta(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_modular_eta, res, tau);
}


void Lib_OCplx_Acb_KleinJ(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_modular_j, res, tau);
}


void Lib_OCplx_Acb_ModularLambda(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_modular_lambda, res, tau);
}


void Lib_OCplx_Acb_ModularDelta(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_modular_delta, res, tau);
}




/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */






/* Lerch’s transcendent: overview */


void Lib_OCplx_Acb_LerchPhi(OCplxPtr res, const OCplxPtr z, const OCplxPtr s, const OCplxPtr a)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_dirichlet_lerch_phi, res, z, s, a);
}


void Lib_OCplx_Acb_LerchZeta(OCplxPtr res, const OCplxPtr lambda1, const OCplxPtr alpha, const OCplxPtr s)
{
    OCplx_Acb_Cplxfunc3_Prec(_acb_lerch_zeta, res, lambda1, alpha, s);
}


/* Polygamma functions */


void Lib_OCplx_Acb_Polygamma(OCplxPtr res, const OCplxPtr s, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_polygamma, res, s, z);
}


void Lib_OCplx_Acb_Trigamma(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_trigamma, res, x);
}


void Lib_OCplx_Acb_Digamma(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_OCplx_Acb_Polylog(OCplxPtr res, const OCplxPtr s, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_polylog, res, s, z);
}


void Lib_OCplx_Acb_Trilog(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_trilog, res, x);
}


void Lib_OCplx_Acb_Dilog(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_dilog, res, x);
}



void Lib_OCplx_Acb_ClausenSin(OCplxPtr res, const OCplxPtr s, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_clausen_sin, res, s, z);
}


void Lib_OCplx_Acb_ClausenCos(OCplxPtr res, const OCplxPtr s, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_clausen_cos, res, s, z);
}


void Lib_OCplx_Acb_Clausen2(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_clausen2, res, x);
}


void Lib_OCplx_Acb_BoseEinstein(OCplxPtr res, const OCplxPtr s, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_bose_einstein, res, s, z);
}


void Lib_OCplx_Acb_FermiDirac(OCplxPtr res, const OCplxPtr s, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_fermi_dirac, res, s, z);
}


void Lib_OCplx_Acb_LegendreChi(OCplxPtr res, const OCplxPtr s, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_legendre_chi, res, s, z);
}


void Lib_OCplx_Acb_InverseTanIntegral(OCplxPtr res, const OCplxPtr s, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_ti, res, s, z);
}





/* Hurwitz zeta function and related functions */




void Lib_OCplx_Acb_HurwitzZeta(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hurwitz_zeta, res, x, y);
}


void Lib_OCplx_Acb_Stieltjes_ui(OCplxPtr res, const OCplxPtr x, const int32_t n)
{
    OCplx_Acb_Cplxfunc1Int32_Prec(acb_stieltjes_ui_, res, x, n);
}


void Lib_OCplx_Acb_BernoulliPoly_ui(OCplxPtr res, const OCplxPtr x, const int32_t n)
{
    OCplx_Acb_Cplxfunc1Int32_Prec(acb_bernoulli_poly_ui_, res, x, n);
}



void Lib_OCplx_Acb_Harmonic(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_harmonic, res, x);
}


void Lib_OCplx_Acb_Harmonic2(OCplxPtr res, const OCplxPtr z, const OCplxPtr r)
{
    OCplx_Acb_Cplxfunc2_Prec(_acb_harmonic2, res, z, r);
}


void Lib_OCplx_Acb_EulerPoly_ui(OCplxPtr res, const OCplxPtr x, const int32_t n)
{
    OCplx_Acb_Cplxfunc1Int32_Prec(acb_euler_poly_ui_, res, x, n);
}


void Lib_OCplx_Acb_Hyperfactorial(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_hyperfac, res, x);
}


void Lib_OCplx_Acb_Superfactorial(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_superfac, res, x);
}


void Lib_OCplx_Acb_BarnesG(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_barnes_g, res, x);
}


void Lib_OCplx_Acb_LogBarnesG(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */


void Lib_OCplx_Acb_Zeta(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_zeta, res, x);
}


void Lib_OCplx_Acb_Zetam1(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_zetam1, res, x);
}


void Lib_OCplx_Acb_ZetaZero_ui(OCplxPtr res, const int32_t n)
{
    OCplx_Acb_Cplxfunc0Int32_Prec(acb_dirichlet_zeta_zero_ui_, res, n);
}


void Lib_OCplx_Acb_DirichletXi(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_xi, res, tau);
}


void Lib_OCplx_Acb_DirichletEta(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_eta, res, tau);
}


void Lib_OCplx_Acb_DirichletEtam1(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_etam1, res, x);
}


void Lib_OCplx_Acb_DirichletBeta(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_beta, res, x);
}


void Lib_OCplx_Acb_DirichletLambda(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(_acb_dirichlet_lambda, res, x);
}



/* Riemann-Siegel Z-function */
void Lib_OCplx_Acb_HardyZ(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_z_, res, tau);
}

/* rstheta(z) in amath */
void Lib_OCplx_Acb_HardyTheta(OCplxPtr res, const OCplxPtr tau)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_theta_, res, tau);
}









/* Additional numbertheoretic functions */




/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_OCplx_Acb_Hypgeom0F1(OCplxPtr res, const OCplxPtr a, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_, res, a, x);
}


void Lib_OCplx_Acb_Hypgeom0F1r(OCplxPtr res, const OCplxPtr a, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */



void Lib_OCplx_Acb_BesselJ(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_j, res, x, y);
}


void Lib_OCplx_Acb_BesselY(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_y, res, x, y);
}


void Lib_OCplx_Acb_BesselI(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i, res, x, y);
}


void Lib_OCplx_Acb_BesselK(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k, res, x, y);
}


void Lib_OCplx_Acb_BesselIScaled(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_OCplx_Acb_BesselKScaled(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */




/* Airy functions  */


void Lib_OCplx_Acb_AiryAi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_airy_ai, res, x);
}


void Lib_OCplx_Acb_AiryAiPrime(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_airy_ai_prime, res, x);
}


void Lib_OCplx_Acb_AiryBi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_airy_bi, res, x);
}


void Lib_OCplx_Acb_AiryBiPrime(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_airy_bi_prime, res, x);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */



void Lib_OCplx_Acb_Hypgeom1F1(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
}


void Lib_OCplx_Acb_Hypgeom1F1r(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_OCplx_Acb_HypgeomU(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_u, res, a, b, z);
}





/* Gamma function and related functions */


void Lib_OCplx_Acb_Gamma(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_gamma, res, x);
}


void Lib_OCplx_Acb_Rgamma(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_rgamma, res, x);
}


void Lib_OCplx_Acb_Lgamma(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_lgamma, res, x);
}


void Lib_OCplx_Acb_RisingFactorial(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_rising, res, x, y);
}


void Lib_OCplx_Acb_Beta(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_beta_, res, x, y);
}






/* Incomplete gamma functions */


void Lib_OCplx_Acb_GammaUpper(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_gamma_upper_, res, x, y);
}



void Lib_OCplx_Acb_GammaLower(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_gamma_lower_, res, x, y);
}



void Lib_OCplx_Acb_GammaPPrime(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_gamma_p_derivative, res, x, y);
}


void Lib_OCplx_Acb_GammaP(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_gamma_p, res, x, y);
}


void Lib_OCplx_Acb_GammaQ(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_gamma_q, res, x, y);
}







/* Error function and related functions */


void Lib_OCplx_Acb_Erf(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erf, res, x);
}


void Lib_OCplx_Acb_Erfc(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfc, res, x);
}


void Lib_OCplx_Acb_Erfi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_erfi, res, x);
}



void Lib_OCplx_Acb_FresnelC(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_fresnelc, res, x);
}


void Lib_OCplx_Acb_FresnelS(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_fresnels, res, x);
}


void Lib_OCplx_Acb_Ndens(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_ndens, res, x);
}


void Lib_OCplx_Acb_Ndis(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_ndis, res, x);
}






/* Exponential integrals and related functions */


void Lib_OCplx_Acb_ExpIntegralE(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_expint, res, x, y);
}



void Lib_OCplx_Acb_ExpIntegralEi(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ei, res, x);
}


void Lib_OCplx_Acb_SinIntegral(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_si, res, x);
}


void Lib_OCplx_Acb_CosIntegral(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_ci, res, x);
}


void Lib_OCplx_Acb_SinhIntegral(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_shi, res, x);
}


void Lib_OCplx_Acb_CoshIntegral(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_chi, res, x);
}


void Lib_OCplx_Acb_LogIntegral(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_, res, x);
}


void Lib_OCplx_Acb_LogIntegralOffset(OCplxPtr res, const OCplxPtr x)
{
    OCplx_Acb_Cplxfunc1_Prec(acb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_OCplx_Acb_HermiteH(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_hermite_h, res, x, y);
}


void Lib_OCplx_Acb_LaguerreL(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */



void Lib_OCplx_Acb_CoulombF(OCplxPtr res, const OCplxPtr l, const OCplxPtr eta, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_OCplx_Acb_CoulombG(OCplxPtr res, const OCplxPtr l, const OCplxPtr eta, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_g, res, l, eta, z);
}


void Lib_OCplx_Acb_CoulombHpos(OCplxPtr res, const OCplxPtr l, const OCplxPtr eta, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hpos, res, l, eta, z);
}


void Lib_OCplx_Acb_CoulombHneg(OCplxPtr res, const OCplxPtr l, const OCplxPtr eta, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hneg, res, l, eta, z);
}







/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_OCplx_Acb_Hypgeom2F1(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr c, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_OCplx_Acb_Hypgeom2F1r(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr c, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1r_, res, a, b, c, z);
}



/* 2F1: Orthogonal polynomials */


void Lib_OCplx_Acb_ChebyshevT(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_OCplx_Acb_ChebyshevU(OCplxPtr res, const OCplxPtr x, const OCplxPtr y)
{
    OCplx_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_OCplx_Acb_GegenbauerC(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_OCplx_Acb_LegendreP(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_OCplx_Acb_LegendrePv(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_OCplx_Acb_LegendreQ(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_OCplx_Acb_LegendreQv(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_qv_, res, a, b, z);
}



void Lib_OCplx_Acb_JacobiP(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr c, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_jacobi_p, res, a, b, c, z);
}


void Lib_OCplx_Acb_SphericalY(OCplxPtr res, const OCplxPtr n, const OCplxPtr m, const OCplxPtr theta, const OCplxPtr phi)
{
    OCplx_Acb_Cplxfunc4_Prec(_acb_hypgeom_spherical_y, res, n, m, theta, phi);
}





/* 2F1: Incomplete Beta Function */


void Lib_OCplx_Acb_BetaLower(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_hypgeom_beta_lower_, res, a, b, z);
}




void Lib_OCplx_Acb_Ibeta(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_ibeta, res, a, b, z);
}


void Lib_OCplx_Acb_Ibetac(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_ibetac, res, a, b, z);
}



void Lib_OCplx_Acb_IbetaPrime(OCplxPtr res, const OCplxPtr a, const OCplxPtr b, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc3_Prec(acb_ibeta_derivative, res, a, b, z);
}



/* Hypergeometric Function 1F2, overview */



void Lib_OCplx_Acb_Hypgeom1F2(OCplxPtr res, const OCplxPtr a1, const OCplxPtr b1, const OCplxPtr b2, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_OCplx_Acb_Hypgeom1F2r(OCplxPtr res, const OCplxPtr a1, const OCplxPtr b1, const OCplxPtr b2, const OCplxPtr z)
{
    OCplx_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2r_, res, a1, b1, b2, z);
}









