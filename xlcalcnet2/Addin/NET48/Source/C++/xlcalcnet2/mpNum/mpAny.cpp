
#include "mpAny.h"
#include "HelperFunctions.h"



static int32_t matrixmode = mp_mprf;


void Lib_Set_Matrix_Mode(int32_t value)
{
	matrixmode = value;
}

int32_t Lib_Get_Matrix_Mode()
{
	return matrixmode;
}



int32_t get_matrix_mode()
{
	return Lib_Get_Matrix_Mode();
}




long mpAny_get_default_prec()
{
	return mpfr_get_default_prec();
}


mpScalarPtr mpAny_init_func_test()
{
    mpScalarPtr result = NULL;
	int32_t si = 0;
	int32_t what = get_matrix_mode();
	switch (what)
	{
		case mp_mprf: result = Lib_Mpfr_Init_Func();  mpfr_set_si((mpfr_ptr)result, si, MPFR_RNDN); break;
		case mp_arb: result = Lib_Arb_Init_Func();  arb_set_si((arb_ptr)result, si); break;
	}
	return result;
}


mpScalarPtr mpAny_init_func()
{
	mpScalarPtr result = NULL;
	int32_t what = get_matrix_mode();
	switch (what)
	{
        case mp_mprf: result = Lib_Mpfr_Init_Func(); break;
        case mp_arb: result = Lib_Arb_Init_Func(); break;
	}
	return result;
}



void mpAny_clear(mpScalarPtr mp)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
		case mp_mprf: Lib_Mpfr_Clear((MpfrPtr)mp); break;
		case mp_arb: Lib_Arb_Clear((arb_ptr)mp); break;
	}
}




double mpAny_get_d(mpScalarPtr mp_src)
{
    double result = 0.0;
	int32_t what = get_matrix_mode();
	switch (what)
	{
		case mp_mprf: result = mpfr_get_d((mpfr_ptr)mp_src, MPFR_RNDN); break;
		case mp_arb: result = arb_get_d((arb_ptr)mp_src); break;
	}
	return result;
}


void mpAny_set(mpScalarPtr mp_res, const mpScalarPtr mp_src)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_set((mpfr_ptr)mp_res, (mpfr_ptr)mp_src, MPFR_RNDN); break;
	case mp_arb: arb_set((arb_ptr)mp_res, (arb_ptr)mp_src); break;
	}
}


void mpAny_set_d(mpScalarPtr mp_res, const double d)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_set_d((mpfr_ptr)mp_res, d, MPFR_RNDN); break;
	case mp_arb: arb_set_d((arb_ptr)mp_res, d); break;
	}
}



void mpAny_set_ui(mpScalarPtr mp, const uint32_t ui)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_set_ui((mpfr_ptr)mp, ui, MPFR_RNDN); break;
	case mp_arb: arb_set_ui((arb_ptr)mp, ui); break;
	}
}


void mpAny_set_si(mpScalarPtr mp, const int32_t si)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_set_si((mpfr_ptr)mp, si, MPFR_RNDN); break;
	case mp_arb: arb_set_si((arb_ptr)mp, si); break;
	}
}


void mpAny_set_ui64(mpScalarPtr mp, const uint64_t ui64)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_set_ui64((mpfr_ptr)mp, ui64); break;
	case mp_arb: arb_set_ui64((arb_ptr)mp, ui64); break;
	}
}


void mpAny_set_si64(mpScalarPtr mp, const int64_t si64)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_set_si64((mpfr_ptr)mp, si64); break;
	case mp_arb: arb_set_si64((arb_ptr)mp, si64); break;
	}
}



void mpAny_add(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_add((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, (mpfr_ptr)mp_src2, MPFR_RNDN); break;
	case mp_arb: arb_add((arb_ptr)mp_res, (arb_ptr)mp_src1, (arb_ptr)mp_src2, mpfr_get_default_prec()); break;
	}
}


void mpAny_add_ui(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint32_t ui)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_add_ui((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, ui, MPFR_RNDN); break;
	case mp_arb: arb_add_ui((arb_ptr)mp_res, (arb_ptr)mp_src1, ui, mpfr_get_default_prec()); break;
	}
}


void mpAny_add_si(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int32_t si)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_add_si((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, si, MPFR_RNDN); break;
	case mp_arb: arb_add_si((arb_ptr)mp_res, (arb_ptr)mp_src1, si, mpfr_get_default_prec()); break;
	}
}


void mpAny_add_d(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const double d)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_add_d((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, d, MPFR_RNDN); break;
	case mp_arb: arb_add_d((arb_ptr)mp_res, (arb_ptr)mp_src1, d, mpfr_get_default_prec()); break;
	}
}





void mpAny_neg(mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_neg((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, MPFR_RNDN); break;
	case mp_arb: arb_neg((arb_ptr)mp_res, (arb_ptr)mp_src1); break;
	}
}


void mpAny_sub(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_sub((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, (mpfr_ptr)mp_src2, MPFR_RNDN); break;
	case mp_arb: arb_sub((arb_ptr)mp_res, (arb_ptr)mp_src1, (arb_ptr)mp_src2, mpfr_get_default_prec()); break;
	}
}


void mpAny_sub_ui(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint32_t ui)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_sub_ui((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, ui, MPFR_RNDN); break;
	case mp_arb: arb_sub_ui((arb_ptr)mp_res, (arb_ptr)mp_src1, ui, mpfr_get_default_prec()); break;
	}
}


void mpAny_sub_si(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int32_t si)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_sub_si((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, si, MPFR_RNDN); break;
	case mp_arb: arb_sub_si((arb_ptr)mp_res, (arb_ptr)mp_src1, si, mpfr_get_default_prec()); break;
	}
}


void mpAny_sub_d(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const double d)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_sub_d((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, d, MPFR_RNDN); break;
	case mp_arb: arb_sub_d((arb_ptr)mp_res, (arb_ptr)mp_src1, d, mpfr_get_default_prec()); break;
	}
}




void mpAny_mul(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_mul((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, (mpfr_ptr)mp_src2, MPFR_RNDN); break;
	case mp_arb: arb_mul((arb_ptr)mp_res, (arb_ptr)mp_src1, (arb_ptr)mp_src2, mpfr_get_default_prec()); break;
	}
}


void mpAny_mul_ui(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint32_t ui)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_mul_ui((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, ui, MPFR_RNDN); break;
	case mp_arb: arb_mul_ui((arb_ptr)mp_res, (arb_ptr)mp_src1, ui, mpfr_get_default_prec()); break;
	}
}


void mpAny_mul_si(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int32_t si)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_mul_si((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, si, MPFR_RNDN); break;
	case mp_arb: arb_mul_si((arb_ptr)mp_res, (arb_ptr)mp_src1, si, mpfr_get_default_prec()); break;
	}
}


void mpAny_mul_d(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const double d)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_mul_d((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, d, MPFR_RNDN); break;
	case mp_arb: arb_mul_d((arb_ptr)mp_res, (arb_ptr)mp_src1, d, mpfr_get_default_prec()); break;
	}
}




void mpAny_div(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_div((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, (mpfr_ptr)mp_src2, MPFR_RNDN); break;
	case mp_arb: arb_div((arb_ptr)mp_res, (arb_ptr)mp_src1, (arb_ptr)mp_src2, mpfr_get_default_prec()); break;
	}
}


void mpAny_div_ui(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint32_t ui)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_div_ui((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, ui, MPFR_RNDN); break;
	case mp_arb: arb_div_ui((arb_ptr)mp_res, (arb_ptr)mp_src1, ui, mpfr_get_default_prec()); break;
	}
}


void mpAny_div_si(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int32_t si)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_div_si((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, si, MPFR_RNDN); break;
	case mp_arb: arb_div_si((arb_ptr)mp_res, (arb_ptr)mp_src1, si, mpfr_get_default_prec()); break;
	}
}


void mpAny_div_ui64(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const uint64_t ui)
{
	int32_t what = get_matrix_mode();
	double d = ui;
	switch (what)
	{
	case mp_mprf: mpfr_div_d((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, d, MPFR_RNDN); break;
	case mp_arb: arb_div_ui((arb_ptr)mp_res, (arb_ptr)mp_src1, ui, mpfr_get_default_prec()); break;
	}
}


void mpAny_div_si64(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const int64_t si)
{
	int32_t what = get_matrix_mode();
	double d = si;
	switch (what)
	{
	case mp_mprf: mpfr_div_d((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, d, MPFR_RNDN); break;
	case mp_arb: arb_div_si((arb_ptr)mp_res, (arb_ptr)mp_src1, si, mpfr_get_default_prec()); break;
	}
}


void mpAny_div_d(mpScalarPtr mp_res, const mpScalarPtr mp_src1, const double d)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_div_d((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, d, MPFR_RNDN); break;
	case mp_arb: arb_div_d((arb_ptr)mp_res, (arb_ptr)mp_src1, d, mpfr_get_default_prec()); break;
	}
}


int32_t mpAny_cmp(const mpScalarPtr mp_src1, const mpScalarPtr mp_src2)
{
    int32_t result = 0;
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: result = mpfr_cmp((mpfr_ptr)mp_src1, (mpfr_ptr)mp_src2); break;
	case mp_arb: result = arf_cmp(arb_midref((arb_ptr)mp_src1), arb_midref((arb_ptr)mp_src2)); break;
	}
	return result;
}


void mpAny_sqrt(const mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_sqrt((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, MPFR_RNDN); break;
	case mp_arb: arb_sqrt((arb_ptr)mp_res, (arb_ptr)mp_src1, mpfr_get_default_prec()); break;
	}
}


void mpAny_abs(const mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_abs((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, MPFR_RNDN); break;
	case mp_arb: arb_abs((arb_ptr)mp_res, (arb_ptr)mp_src1); break;
	}
}


void mpAny_ceil(const mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_ceil((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1); break;
	case mp_arb: arb_ceil((arb_ptr)mp_res, (arb_ptr)mp_src1, mpfr_get_default_prec()); break;
	}
}


void mpAny_log(const mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_log((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, MPFR_RNDN); break;
	case mp_arb: arb_log((arb_ptr)mp_res, (arb_ptr)mp_src1, mpfr_get_default_prec()); break;
	}
}


void mpAny_exp(const mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_exp((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, MPFR_RNDN); break;
	case mp_arb: arb_exp((arb_ptr)mp_res, (arb_ptr)mp_src1, mpfr_get_default_prec()); break;
	}
}


void mpAny_sin(const mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_sin((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, MPFR_RNDN); break;
	case mp_arb: arb_sin((arb_ptr)mp_res, (arb_ptr)mp_src1, mpfr_get_default_prec()); break;
	}
}


void mpAny_cos(const mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_cos((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, MPFR_RNDN); break;
	case mp_arb: arb_cos((arb_ptr)mp_res, (arb_ptr)mp_src1, mpfr_get_default_prec()); break;
	}
}


void mpAny_acos(const mpScalarPtr mp_res, const mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_acos((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, MPFR_RNDN); break;
	case mp_arb: arb_acos((arb_ptr)mp_res, (arb_ptr)mp_src1, mpfr_get_default_prec()); break;
	}
}



void mpAny_pow(const mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_pow((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, (mpfr_ptr)mp_src2, MPFR_RNDN); break;
	case mp_arb: arb_pow((arb_ptr)mp_res, (arb_ptr)mp_src1, (arb_ptr)mp_src2, mpfr_get_default_prec()); break;
	}
}



void mpAny_atan2(const mpScalarPtr mp_res, const mpScalarPtr mp_src1, const mpScalarPtr mp_src2)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_atan2((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, (mpfr_ptr)mp_src2, MPFR_RNDN); break;
	case mp_arb: arb_atan2((arb_ptr)mp_res, (arb_ptr)mp_src1, (arb_ptr)mp_src2, mpfr_get_default_prec()); break;
	}
}



void mpAny_swap(mpScalarPtr mp_res, mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_swap((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1); break;
	case mp_arb: arb_swap((arb_ptr)mp_res, (arb_ptr)mp_src1); break;
	}
}


bool mpAny_is_nan(mpScalarPtr mp_src1)
{
    bool result = false;
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: result = (bool)mpfr_nan_p((mpfr_ptr)mp_src1); break;
	case mp_arb: result = (bool)(mag_is_inf(arb_radref((arb_ptr)mp_src1)) || arf_is_nan(arb_midref((arb_ptr)mp_src1))); break;
	}
	return result;
}


bool mpAny_is_finite(mpScalarPtr mp_src1)
{
    bool result = false;
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: result = (bool)mpfr_number_p((mpfr_ptr)mp_src1); break;
	case mp_arb: result = (bool)arb_is_finite((arb_ptr)mp_src1); break;
	}
	return result;
}


void mpAny_maxval_prec(mpScalarPtr mp_res, long prec)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_maxval_prec((mpfr_ptr)mp_res, prec); break;
	case mp_arb: arb_maxval_prec((arb_ptr)mp_res, prec); break;
	}
}


void mpAny_machine_epsilon_prec(mpScalarPtr mp_res, long prec)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_machine_epsilon_prec((mpfr_ptr)mp_res, prec); break;
	case mp_arb: arb_machine_epsilon_prec((arb_ptr)mp_res, prec); break;
	}
}


void mpAny_machine_epsilon_x(mpScalarPtr mp_res, mpScalarPtr mp_src1)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_machine_epsilon_x((mpfr_ptr)mp_res, (mpfr_ptr)mp_src1, mpfr_get_default_prec()); break;
	case mp_arb: arb_get_ulp((arb_ptr)mp_res, (arb_ptr)mp_src1, mpfr_get_default_prec()); break;
	}
}




void mpAny_cplx_abs_from_real_and_imag(mpScalarPtr mp_res, const mpScalarPtr mp_src_real, const mpScalarPtr mp_src_imag)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_cplx_abs_from_real_and_imag((mpfr_ptr)mp_res, (mpfr_ptr)mp_src_real, (mpfr_ptr)mp_src_imag); break;
	case mp_arb: arb_cplx_abs_from_real_and_imag((arb_ptr)mp_res, (arb_ptr)mp_src_real, (arb_ptr)mp_src_imag); break;
	}
}


void mpAny_cplx_sqrt_from_real_and_imag(mpScalarPtr mp_res_real, mpScalarPtr mp_res_imag, const mpScalarPtr mp_src_real, const mpScalarPtr mp_src_imag)
{
	int32_t what = get_matrix_mode();
	switch (what)
	{
	case mp_mprf: mpfr_cplx_sqrt_from_real_and_imag((mpfr_ptr)mp_res_real, (mpfr_ptr)mp_res_imag, (mpfr_ptr)mp_src_real, (mpfr_ptr)mp_src_imag); break;
	case mp_arb: arb_cplx_sqrt_from_real_and_imag((arb_ptr)mp_res_real, (arb_ptr)mp_res_imag, (arb_ptr)mp_src_real, (arb_ptr)mp_src_imag); break;
	}
}


