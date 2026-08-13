#pragma once
#include <stdint.h>



typedef void* mpScalarPtr;


long mpAny_get_default_prec();


mpScalarPtr mpAny_init_func();

void mpAny_clear(mpScalarPtr mp);

double mpAny_get_d(mpScalarPtr mp_res);


void mpAny_set(mpScalarPtr mp_res, const mpScalarPtr mp_src);

void mpAny_set_d(mpScalarPtr mp_res, const double u);


void mpAny_set_ui(mpScalarPtr mp, const uint32_t u);

void mpAny_set_si(mpScalarPtr mp, const int32_t u);

void mpAny_set_ui64(mpScalarPtr mp, const uint64_t u);

void mpAny_set_si64(mpScalarPtr mp, const int64_t u);


void mpAny_add(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2);

void mpAny_add_ui(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint32_t u);

void mpAny_add_si(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int32_t u);

void mpAny_add_d(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const double u);


void mpAny_neg(mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_sub(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2);

void mpAny_sub_ui(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint32_t u);

void mpAny_sub_si(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int32_t u);

void mpAny_sub_d(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const double u);


void mpAny_mul(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2);

void mpAny_mul_ui(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint32_t u);

void mpAny_mul_si(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int32_t u);

void mpAny_mul_d(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const double u);


void mpAny_div(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2);

void mpAny_div_ui(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint32_t u);

void mpAny_div_si(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int32_t u);

void mpAny_div_ui64(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint64_t u);

void mpAny_div_si64(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int64_t u);

void mpAny_div_d(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const double u);


int32_t mpAny_cmp(const mpScalarPtr mp_src1, const mpScalarPtr mp_src2);

void mpAny_sqrt(const mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_abs(const mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_ceil(const mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_exp(const mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_log(const mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_sin(const mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_cos(const mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_acos(const mpScalarPtr mp_res, const mpScalarPtr mp_src1);

void mpAny_pow(const mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2);

void mpAny_atan2(const mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2);


void mpAny_swap(mpScalarPtr mp_res, mpScalarPtr mp_src1);

bool mpAny_is_nan(mpScalarPtr mp_src1);

bool mpAny_is_finite(mpScalarPtr mp_src1);


void mpAny_maxval_prec(mpScalarPtr mp_res, long prec);

void mpAny_machine_epsilon_prec(mpScalarPtr mp_res, long prec);

void mpAny_machine_epsilon_x(mpScalarPtr mp_res, mpScalarPtr mp_src1);


void mpAny_cplx_abs_from_real_and_imag(mpScalarPtr mp_res, const mpScalarPtr mp_src_real, const mpScalarPtr mp_src_imag);

void mpAny_cplx_sqrt_from_real_and_imag(mpScalarPtr mp_res_real, mpScalarPtr mp_res_imag, const mpScalarPtr mp_src_real, const mpScalarPtr mp_src_imag);

