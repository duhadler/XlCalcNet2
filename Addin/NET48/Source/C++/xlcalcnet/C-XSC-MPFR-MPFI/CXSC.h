
#include "Helperfunctions.h"


////////////////////////////////////////////////////////
////// Mpri functions
////////////////////////////////////////////////////////


void mpri_set_prec(int prec);

void mpri_pow(mpri_t res, mpri_t x, mpri_t y);

void mpri_pow_si(mpri_t res, mpri_t x, const int n);

void mpri_nroot(mpri_t res, mpri_t x, const int n);

void mpri_sqrt1px2(mpri_t res, mpri_t x);

void mpri_sqrtp1m1(mpri_t res, mpri_t x);

void mpri_sqrtx2m1(mpri_t res, mpri_t x);

void mpri_sqrt1mx2(mpri_t res, mpri_t x);

void mpri_exp10(mpri_t res, mpri_t x);

void mpri_expx2m1(mpri_t res, mpri_t x);

void mpri_expmx2(mpri_t res, mpri_t x);

void mpri_expmx2m1(mpri_t res, mpri_t x);

void mpri_acot(mpri_t res, mpri_t x);

void mpri_acoshp1(mpri_t res, mpri_t x);

void mpri_acoth(mpri_t res, mpri_t x);

void mpri_gamma(mpri_t res, mpri_t x);

void mpri_lgamma(mpri_t res, mpri_t x);

void mpri_rgamma(mpri_t res, mpri_t x);

void mpri_digamma(mpri_t res, mpri_t x);

void mpri_erf(mpri_t res, mpri_t x);

void mpri_erfc(mpri_t res, mpri_t x);




//////////////////////////////////////////////////////
//// Mpci functions
//////////////////////////////////////////////////////





void mpci_add(mpci_t res, mpci_t x, mpci_t y);

void mpci_add_r(mpci_t res, mpci_t x, mpri_t y);

void mpci_add_d(mpci_t res, mpci_t x, double y);

void mpci_add_si(mpci_t res, mpci_t x, int y);



void mpci_sub(mpci_t res, mpci_t x, mpci_t y);

void mpci_sub_r(mpci_t res, mpci_t x, mpri_t y);

void mpci_r_sub(mpci_t res, mpci_t y, mpri_t x);

void mpci_sub_d(mpci_t res, mpci_t x, double y);

void mpci_d_sub(mpci_t res, mpci_t y, double x);

void mpci_sub_si(mpci_t res, mpci_t x, int y);

void mpci_si_sub(mpci_t res, mpci_t y, int x);



void mpci_mul(mpci_t res, mpci_t x, mpci_t y);

void mpci_mul_r(mpci_t res, mpci_t x, mpri_t y);

void mpci_mul_d(mpci_t res, mpci_t x, double y);

void mpci_mul_si(mpci_t res, mpci_t x, int y);



void mpci_div(mpci_t res, mpci_t x, mpci_t y);

void mpci_div_r(mpci_t res, mpci_t x, mpri_t y);

void mpci_r_div(mpci_t res, mpci_t y, mpri_t x);

void mpci_div_d(mpci_t res, mpci_t x, double y);

void mpci_d_div(mpci_t res, mpci_t x, double y);

void mpci_div_si(mpci_t res, mpci_t x, int y);

void mpci_si_div(mpci_t res, mpci_t x, int y);



void mpci_pow(mpci_t res, mpci_t x, mpci_t y);

void mpci_pow_r(mpci_t res, mpci_t x, mpri_t y);

void mpci_pow_d(mpci_t res, mpci_t x, const double n);

void mpci_pow_si(mpci_t res, mpci_t x, const int n);

void mpci_nroot(mpci_t res, mpci_t x, const int n);

void mpci_abs(mpri_t res, mpci_t x);

void mpci_norm(mpfi_t res, mpci_t x);

void mpci_arg(mpri_t res, mpci_t x);

void mpci_Arg(mpri_t res, mpci_t x);

void mpci_inv(mpci_t res, mpci_t x);

void mpci_conj_(mpci_t res, mpci_t x);


void mpci_sqr(mpci_t res, mpci_t x);

void mpci_sqrt(mpci_t res, mpci_t x);

void mpci_rsqrt(mpci_t res, mpci_t x);

void mpci_cbrt(mpci_t res, mpci_t x);

void mpci_ln(mpci_t res, mpci_t x);

void mpci_Ln(mpci_t res, mpci_t x);

void mpci_lnp1(mpci_t res, mpci_t x);

void mpci_Lnp1(mpci_t res, mpci_t x);

void mpci_log2(mpci_t res, mpci_t x);

void mpci_log10(mpci_t res, mpci_t x);

void mpci_exp(mpci_t res, mpci_t x);

void mpci_exp2(mpci_t res, mpci_t x);

void mpci_exp10(mpci_t res, mpci_t x);

void mpci_sin(mpci_t res, mpci_t x);

void mpci_cos(mpci_t res, mpci_t x);

void mpci_tan(mpci_t res, mpci_t x);

void mpci_csc(mpci_t res, mpci_t x);

void mpci_sec(mpci_t res, mpci_t x);

void mpci_cot(mpci_t res, mpci_t x);

void mpci_asin(mpci_t res, mpci_t x);

void mpci_acos(mpci_t res, mpci_t x);

void mpci_atan(mpci_t res, mpci_t x);

void mpci_acsc(mpci_t res, mpci_t x);

void mpci_asec(mpci_t res, mpci_t x);

void mpci_acot(mpci_t res, mpci_t x);

void mpci_sinh(mpci_t res, mpci_t x);

void mpci_cosh(mpci_t res, mpci_t x);

void mpci_tanh(mpci_t res, mpci_t x);

void mpci_csch(mpci_t res, mpci_t x);

void mpci_sech(mpci_t res, mpci_t x);

void mpci_coth(mpci_t res, mpci_t x);

void mpci_asinh(mpci_t res, mpci_t x);

void mpci_acosh(mpci_t res, mpci_t x);

void mpci_atanh(mpci_t res, mpci_t x);

void mpci_acsch(mpci_t res, mpci_t x);

void mpci_asech(mpci_t res, mpci_t x);

void mpci_acoth(mpci_t res, mpci_t x);




