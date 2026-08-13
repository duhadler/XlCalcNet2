
#include "mpficlass.hpp"
#include "mpfciclass.hpp"
#include "CXSC.h"


#include <cmath>


using namespace MPFI;


////////////////////////////////////////////////////////
////// Mpri functions
////////////////////////////////////////////////////////




void mpri_set_prec(int prec)
 {
     MpfiClass::SetCurrPrecision(prec);
 }




void mpri_pow(mpri_t res, mpri_t x, mpri_t y)
 {
    MpfiClass v = pow(MpfiClass(x->real), MpfiClass(y->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_pow_si(mpri_t res, mpri_t x, const int n)
 {
    MpfiClass v = power(MpfiClass(x->real), n);
    mpfi_set(res->real, v.GetValue());
 }


void mpri_nroot(mpri_t res, mpri_t x, const int n)
 {
    MpfiClass v = sqrt(MpfiClass(x->real), n);
    mpfi_set(res->real, v.GetValue());
 }




void mpri_sqrt1px2(mpri_t res, mpri_t x)
 {
    MpfiClass v = sqrt1px2(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_sqrtp1m1(mpri_t res, mpri_t x)
 {
    MpfiClass v = sqrtp1m1(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_sqrtx2m1(mpri_t res, mpri_t x)
 {
    MpfiClass v = sqrtx2m1(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_sqrt1mx2(mpri_t res, mpri_t x)
 {
    MpfiClass v = sqrt1mx2(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }




void mpri_exp10(mpri_t res, mpri_t x)
 {
    MpfiClass v = exp10(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_expx2m1(mpri_t res, mpri_t x)
 {
    MpfiClass v = expx2m1(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_expmx2(mpri_t res, mpri_t x)
 {
    MpfiClass v = expmx2(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_expmx2m1(mpri_t res, mpri_t x)
 {
    MpfiClass v = expmx2m1(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }




void mpri_acot(mpri_t res, mpri_t x)
 {
    MpfiClass v = acot(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_acoshp1(mpri_t res, mpri_t x)
 {
    MpfiClass v = acoshp1(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_acoth(mpri_t res, mpri_t x)
 {
    MpfiClass v = acoth(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }




void mpri_gamma(mpri_t res, mpri_t x)
 {
    MpfiClass x1 = MpfiClass(x->real);
    MpfiClass v = gamma_D(x1)/digamma(x1);
    mpfi_set(res->real, v.GetValue());
 }


void mpri_lgamma(mpri_t res, mpri_t x)
 {
    MpfiClass x1 = MpfiClass(x->real);
    MpfiClass v = ln(gamma_D(x1)/digamma(x1));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_rgamma(mpri_t res, mpri_t x)
 {
    MpfiClass x1 = MpfiClass(x->real);
    MpfiClass v = digamma(x1)/gamma_D(x1);
    mpfi_set(res->real, v.GetValue());
 }


void mpri_digamma(mpri_t res, mpri_t x)
 {
    MpfiClass v = digamma(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_erf(mpri_t res, mpri_t x)
 {
    MpfiClass v = erf(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }


void mpri_erfc(mpri_t res, mpri_t x)
 {
    MpfiClass v = erfc(MpfiClass(x->real));
    mpfi_set(res->real, v.GetValue());
 }













//////////////////////////////////////////////////////
//// Mpci functions
//////////////////////////////////////////////////////


 void mpci_set2(mpci_t z, mpfi_t re, mpfi_t im)
 {
	 mpfi_set(z->real, re);
	 mpfi_set(z->imag, im);
 }





void mpci_add(mpci_t res, mpci_t x, mpci_t y)
{
    mpfi_add(res->real, x->real, y->real);
    mpfi_add(res->imag, x->imag, y->imag);
}


void mpci_add_r(mpci_t res, mpci_t x, mpri_t y)
{
    mpfi_add(res->real, x->real, y->real);
    mpfi_set(res->imag, x->imag);
}


void mpci_add_d(mpci_t res, mpci_t x, double y)
{
    mpfi_add_si(res->real, x->real, y);
    mpfi_set(res->imag, x->imag);
}


void mpci_add_si(mpci_t res, mpci_t x, int y)
{
    mpfi_add_si(res->real, x->real, y);
    mpfi_set(res->imag, x->imag);
}


void mpci_sub(mpci_t res, mpci_t x, mpci_t y)
{
    mpfi_sub(res->real, x->real, y->real);
    mpfi_sub(res->imag, x->imag, y->imag);
}


void mpci_sub_r(mpci_t res, mpci_t x, mpri_t y)
{
    mpfi_sub(res->real, x->real, y->real);
    mpfi_set(res->imag, x->imag);
}


void mpci_r_sub(mpci_t res, mpci_t y, mpri_t x)
{
    mpfi_sub(res->real, x->real, y->real);
    mpfi_neg(res->imag, y->imag);
}


void mpci_sub_d(mpci_t res, mpci_t x, double y)
{
    mpfi_sub_si(res->real, x->real, y);
    mpfi_set(res->imag, x->imag);
}


void mpci_sub_si(mpci_t res, mpci_t x, int y)
{
    mpfi_sub_si(res->real, x->real, y);
    mpfi_set(res->imag, x->imag);
}


void mpci_d_sub(mpci_t res, mpci_t y, double x)
{
    mpfi_si_sub(res->real, x, y->real);
    mpfi_set(res->imag, y->imag);
}


void mpci_si_sub(mpci_t res, mpci_t y, int x)
{
    mpfi_si_sub(res->real, x, y->real);
    mpfi_set(res->imag, y->imag);
}


void mpci_mul(mpci_t res, mpci_t x, mpci_t y)
{
    MpfciClass v = MpfciClass(x->real, x->imag) * MpfciClass(y->real, y->imag);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_mul_r(mpci_t res, mpci_t x, mpri_t y)
{
    MpfciClass v = MpfciClass(x->real, x->imag) * MpfciClass(y->real);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_mul_d(mpci_t res, mpci_t x, double y)
{
    MpfciClass v = MpfciClass(x->real, x->imag) * y;
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_mul_si(mpci_t res, mpci_t x, int y)
{
    MpfciClass v = MpfciClass(x->real, x->imag) * y;
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_div(mpci_t res, mpci_t x, mpci_t y)
{
    MpfciClass v = MpfciClass(x->real, x->imag) / MpfciClass(y->real, y->imag);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_div_r(mpci_t res, mpci_t x, mpri_t y)
{
    MpfciClass v = MpfciClass(x->real, x->imag) / MpfciClass(y->real);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_r_div(mpci_t res, mpci_t y, mpri_t x)
{
    MpfciClass v = MpfciClass(x->real) / MpfciClass(y->real, y->imag);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_div_d(mpci_t res, mpci_t x, double y)
{
    MpfciClass v = MpfciClass(x->real, x->imag) / y;
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_div_si(mpci_t res, mpci_t x, int y)
{
    MpfciClass v = MpfciClass(x->real, x->imag) / y;
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_d_div(mpci_t res, mpci_t x, double y)
{
    MpfciClass v = y / MpfciClass(x->real, x->imag);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_si_div(mpci_t res, mpci_t x, int y)
{
    MpfciClass v = y / MpfciClass(x->real, x->imag);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}



void mpci_pow(mpci_t res, mpci_t x, mpci_t y)
{
    MpfciClass v = pow(MpfciClass(x->real, x->imag) , MpfciClass(y->real, y->imag));
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_pow_r(mpci_t res, mpci_t x, mpri_t y)
{
    MpfciClass v = pow(MpfciClass(x->real, x->imag) , MpfiClass(y->real));
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_pow_d(mpci_t res, mpci_t x, const double n)
{
    MpfciClass v = power(MpfciClass(x->real, x->imag) , n);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_pow_si(mpci_t res, mpci_t x, const int n)
{
    MpfciClass v = power(MpfciClass(x->real, x->imag) , n);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_nroot(mpci_t res, mpci_t x, const int n)
{
    MpfciClass v = sqrt(MpfciClass(x->real, x->imag) , n);
    mpci_set2(res, v.GetValueRe(), v.GetValueIm());
}


void mpci_abs(mpri_t res, mpci_t x)
 {
	 MpfiClass v = abs(MpfciClass(x->real, x->imag));
	 mpfi_set(res->real, v.GetValue());
 }


void mpci_norm(mpfi_t res, mpci_t x)
{
    mpfi_t re_square; mpfi_init(re_square);
	mpfi_t im_square; mpfi_init(im_square);

	mpfi_sqr(re_square, x->real);
	mpfi_sqr(im_square, x->imag);
    mpfi_add(res, re_square, im_square);

	mpfi_clear(re_square);
	mpfi_clear(im_square);
}


void mpci_arg(mpri_t res, mpci_t x)
 {
	 MpfiClass v =arg(MpfciClass(x->real, x->imag));
	 mpfi_set(res->real, v.GetValue());
 }


void mpci_Arg(mpri_t res, mpci_t x)
 {
	 MpfiClass v =Arg(MpfciClass(x->real, x->imag));
	 mpfi_set(res->real, v.GetValue());
 }


void mpci_inv(mpci_t res, mpci_t x)
 {
	 MpfciClass v = 1.0 / (MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_conj_(mpci_t res, mpci_t x)
 {
	 MpfciClass v = conj(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_sqr(mpci_t res, mpci_t x)
 {
	 MpfciClass v = sqr(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_sqrt(mpci_t res, mpci_t x)
 {
	 MpfciClass v = sqrt(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_rsqrt(mpci_t res, mpci_t x)
 {
	 MpfciClass v = 1.0 / sqrt(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_cbrt(mpci_t res, mpci_t x)
 {
	 MpfciClass v = sqrt(MpfciClass(x->real, x->imag), 3);
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_ln(mpci_t res, mpci_t x)
 {
	 MpfciClass v = ln(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_Ln(mpci_t res, mpci_t x)
 {
	 MpfciClass v = Ln(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_lnp1(mpci_t res, mpci_t x)
 {
	 MpfciClass v = lnp1(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_Lnp1(mpci_t res, mpci_t x)
 {
	 MpfciClass v = Lnp1(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_log2(mpci_t res, mpci_t x)
 {
	 MpfciClass v = log2(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_log10(mpci_t res, mpci_t x)
 {
	 MpfciClass v = log10(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }

// MISSING: expm1



void mpci_exp(mpci_t res, mpci_t x)
 {
	 MpfciClass v = exp(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_exp2(mpci_t res, mpci_t x)
 {
	 MpfciClass v = exp2(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_exp10(mpci_t res, mpci_t x)
 {
	 MpfciClass v = exp10(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_sin(mpci_t res, mpci_t x)
 {
	 MpfciClass v = sin(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_cos(mpci_t res, mpci_t x)
 {
	 MpfciClass v = cos(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_tan(mpci_t res, mpci_t x)
 {
	 MpfciClass v = tan(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_csc(mpci_t res, mpci_t x)
 {
	 MpfciClass v = 1.0 / sin(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_sec(mpci_t res, mpci_t x)
 {
	 MpfciClass v = 1.0 / cos(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_cot(mpci_t res, mpci_t x)
 {
	 MpfciClass v = cot(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_asin(mpci_t res, mpci_t x)
 {
	 MpfciClass v = asin(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_acos(mpci_t res, mpci_t x)
 {
	 MpfciClass v = acos(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_atan(mpci_t res, mpci_t x)
 {
	 MpfciClass v = atan(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_acsc(mpci_t res, mpci_t x)
 {
	 MpfciClass v = asin(1.0 / MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_asec(mpci_t res, mpci_t x)
 {
	 MpfciClass v = acos(1.0 / MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_acot(mpci_t res, mpci_t x)
 {
	 MpfciClass v = acot(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_sinh(mpci_t res, mpci_t x)
 {
	 MpfciClass v = sinh(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_cosh(mpci_t res, mpci_t x)
 {
	 MpfciClass v = cosh(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_tanh(mpci_t res, mpci_t x)
 {
	 MpfciClass v = tanh(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_csch(mpci_t res, mpci_t x)
 {
	 MpfciClass v = 1.0 / sinh(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_sech(mpci_t res, mpci_t x)
 {
	 MpfciClass v = 1.0 / cosh(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_coth(mpci_t res, mpci_t x)
 {
	 MpfciClass v = coth(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_asinh(mpci_t res, mpci_t x)
 {
	 MpfciClass v = asinh(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_acosh(mpci_t res, mpci_t x)
 {
	 MpfciClass v = acosh(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_atanh(mpci_t res, mpci_t x)
 {
	 MpfciClass v = atanh(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_acsch(mpci_t res, mpci_t x)
 {
	 MpfciClass v = asinh(1.0 / MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_asech(mpci_t res, mpci_t x)
 {
	 MpfciClass v = acosh(1.0 / MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }


void mpci_acoth(mpci_t res, mpci_t x)
 {
	 MpfciClass v = acoth(MpfciClass(x->real, x->imag));
	 mpci_set2(res, v.GetValueRe(), v.GetValueIm());
 }














