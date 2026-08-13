
#define MPFR_WANT_FLOAT128
#include "Helperfunctions.h"
#include "mpNumC_Main.h"
#include "BoostMpfr.h"


/** ********************** Real Basic Functions, Mpfr ******************************** **/


int64_t Lib_Mpfr_Get_Emin()
{
	return mpfr_get_emin();
}

int64_t Lib_Mpfr_Get_Emax()
{
	return mpfr_get_emax();
}

int32_t Lib_Mpfr_Set_Emin(int64_t exp)
{
    mpfr_exp_t e = exp;
	return mpfr_set_emin(e);
}

int32_t Lib_Mpfr_Set_Emax(int64_t exp)
{
    mpfr_exp_t e = exp;
	return mpfr_set_emax(e);
}

int32_t Lib_Mpfr_Check_Range(MpfrPtr x)
{
	return mpfr_check_range((mpfr_ptr)x, 0, MPFR_RNDN);
}


MpfrPtr Lib_Mpfr_Init_Func()
{
	MpfrPtr x;
	x = malloc(sizeof(__mpfr_struct));
	mpfr_init2((mpfr_ptr)x, mpfr_get_default_prec());
	return x;
}

void Lib_Mpfr_Clear(MpfrPtr x)
{
	mpfr_clear((mpfr_ptr)x);
	free(x);
}



/* Input and output  */

void Lib_Mpfr_Set(MpfrPtr res, const MpfrPtr x)
{
	mpfr_set((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Set_Fmpq(MpfrPtr res, const FmpqPtr x)
{
	fmpq_get_mpfr((mpfr_ptr)res, (fmpq*)x, MPFR_RNDN);
}

void Lib_Mpfr_Set_Arb(MpfrPtr res, const ArbPtr x)
{
	arf_get_mpfr((mpfr_ptr)res, arb_midref((arb_ptr)x), MPFR_RNDN);
}

void Lib_Mpfr_Set_Arf(MpfrPtr res, const ArfPtr x)
{
	arf_get_mpfr((mpfr_ptr)res, (arf_ptr)x, MPFR_RNDN);
}
//
//void Lib_Mpfr_Set_Mpfi(MpfrPtr res, const MpfiPtr x)
//{
//	mpfi_get_fr((mpfr_ptr)res, (mpfi_ptr)x);
//}

void Lib_Mpfr_Set_Mpfr(MpfrPtr res, const MpfrPtr x)
{
	mpfr_set((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

//void Lib_Mpfr_Set_Mpd(MpfrPtr res, const MpdPtr x)
//{
//	char * src = mpd_to_sci((mpd_t *)x, 1);
//	mpfr_set_str((mpfr_ptr)res, src, 10, MPFR_RNDN);
//	free(src);
//}


void Lib_Mpfr_Set_QReal(MpfrPtr res, const QRealPtr x)
{
  mpfr_set_float128 ((mpfr_ptr)res, *(__float128*)x, MPFR_RNDN);
}

void Lib_Mpfr_Set_LD(MpfrPtr res, const long double* x)
{
  mpfr_set_ld((mpfr_ptr)res, *x, MPFR_RNDN);
}

void Lib_Mpfr_Set_D(MpfrPtr res, const double x)
{
	mpfr_set_d((mpfr_ptr)res, x, MPFR_RNDN);
}

void Lib_Mpfr_Set_S(MpfrPtr res, const float* x)
{
  mpfr_set_flt((mpfr_ptr)res, *x, MPFR_RNDN);
}


void Lib_Mpfr_Set_Si(MpfrPtr res, const int32_t x)
{
	mpfr_set_si((mpfr_ptr)res, x, MPFR_RNDN);
}

void Lib_Mpfr_Set_Si64(MpfrPtr res, const int64_t x)
{
	mpfr_set_sj((mpfr_ptr)res, x, MPFR_RNDN);
}

void Lib_Mpfr_Set_Ui(MpfrPtr res, const uint32_t x)
{
	mpfr_set_ui((mpfr_ptr)res, x, MPFR_RNDN);
}

void Lib_Mpfr_Set_Ui64(MpfrPtr res, const uint64_t x)
{
	mpfr_set_uj((mpfr_ptr)res, x, MPFR_RNDN);
}


void Lib_Mpfr_Set_Str(MpfrPtr res, const char* s)
{
	mpfr_set_str((mpfr_ptr)res, s, 10, MPFR_RNDN);
}

int32_t  Lib_Mpfr_SizeInBase10(const char *template1, MpfrPtr x)
{
    // Note: template should be something like "%.12RE", to display 12 digits in scientific notation
    return mpfr_snprintf(NULL, 0, template1, (mpfr_ptr) x);
}

int32_t  Lib_Mpfr_Get_Str(char* dest , uint32_t digits, const char *template1, MpfrPtr x)
{
    // Note: template should be something like "%.12RE", with digits = 12 to display 12 digits
    return mpfr_snprintf(dest, digits, template1, (mpfr_ptr) x);
}



/* Operator overloading vs raw arithmetic and comparisons  */

void Lib_Mpfr_Neg(MpfrPtr res, const MpfrPtr x)
{
	mpfr_neg((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Add(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_add((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}

void Lib_Mpfr_Sub(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_sub((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}

void Lib_Mpfr_Mul(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_mul((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}

void Lib_Mpfr_Div(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_div((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}


void Lib_Mpfr_Add_D(MpfrPtr res, const MpfrPtr x, const double y)
{
    mpfr_add_d((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_Sub_D(MpfrPtr res, const MpfrPtr x, const double y)
{
    mpfr_sub_d((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_D_Sub(MpfrPtr res, const MpfrPtr x, const double y)
{
    mpfr_d_sub((mpfr_ptr)res, y, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Mul_D(MpfrPtr res, const MpfrPtr x, const double y)
{
    mpfr_mul_d((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_Div_D(MpfrPtr res, const MpfrPtr x, const double y)
{
    mpfr_div_d((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_D_Div(MpfrPtr res, const MpfrPtr x, const double y)
{
    mpfr_d_div((mpfr_ptr)res, y, (mpfr_ptr)x, MPFR_RNDN);
}


void Lib_Mpfr_Add_Si(MpfrPtr res, const MpfrPtr x, const int32_t y)
{
    mpfr_add_si((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_Sub_Si(MpfrPtr res, const MpfrPtr x, const int32_t y)
{
    mpfr_sub_si((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_Si_Sub(MpfrPtr res, const MpfrPtr x, const int32_t y)
{
    mpfr_si_sub((mpfr_ptr)res, y, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Mul_Si(MpfrPtr res, const MpfrPtr x, const int32_t y)
{
    mpfr_mul_si((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_Div_Si(MpfrPtr res, const MpfrPtr x, const int32_t y)
{
    mpfr_div_si((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_Si_Div(MpfrPtr res, const MpfrPtr x, const int32_t y)
{
    mpfr_si_div((mpfr_ptr)res, y, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Inv(MpfrPtr res, const MpfrPtr x)
{
    mpfr_si_div((mpfr_ptr)res, 1, (mpfr_ptr)x, MPFR_RNDN);
}



int32_t Lib_Mpfr_LT(const MpfrPtr x, const MpfrPtr y)
{
	return mpfr_less_p((mpfr_ptr)x, (mpfr_ptr)y);
}

int32_t Lib_Mpfr_GE(const MpfrPtr x, const MpfrPtr y)
{
	return mpfr_greaterequal_p((mpfr_ptr)x, (mpfr_ptr)y);
}

int32_t Lib_Mpfr_GT(const MpfrPtr x, const MpfrPtr y)
{
	return mpfr_greater_p((mpfr_ptr)x, (mpfr_ptr)y);;
}

int32_t Lib_Mpfr_LE(const MpfrPtr x, const MpfrPtr y)
{
	return mpfr_lessequal_p((mpfr_ptr)x, (mpfr_ptr)y);
}

int32_t Lib_Mpfr_EQ(const MpfrPtr x, const MpfrPtr y)
{
	return mpfr_equal_p((mpfr_ptr)x, (mpfr_ptr)y);
}

int32_t Lib_Mpfr_NE(const MpfrPtr x, const MpfrPtr y)
{
	return mpfr_lessgreater_p((mpfr_ptr)x, (mpfr_ptr)y);
}






/* General functions for real numbers  */

void Lib_Mpfr_Fma(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z)
{
    mpfr_fma((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, (mpfr_ptr)z, MPFR_RNDN);
}

void Lib_Mpfr_Fmax(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_max((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}

void Lib_Mpfr_Fmin(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_min((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}






/* Machine constants and properties of numbers  */

void Lib_Mpfr_Zero(MpfrPtr res)
{
    mpfr_set_zero((mpfr_ptr)res, +1);
}

void Lib_Mpfr_NegZero(MpfrPtr res)
{
    mpfr_set_zero((mpfr_ptr)res, -1);
}

void Lib_Mpfr_One(MpfrPtr res)
{
	mpfr_set_si((mpfr_ptr)res, 1, MPFR_RNDN);
}

void Lib_Mpfr_Inf(MpfrPtr res)
{
    mpfr_set_inf((mpfr_ptr)res, +1);
}

void Lib_Mpfr_NegInf(MpfrPtr res)
{
    mpfr_set_inf((mpfr_ptr)res, -1);
}

void Lib_Mpfr_Nan(MpfrPtr res)
{
    mpfr_set_nan((mpfr_ptr)res);
}




/* Properties of numbers  */

int Lib_Mpfr_Signbit(const MpfrPtr x)
{
	return mpfr_signbit((mpfr_ptr)x);
}

int Lib_Mpfr_Finite(const MpfrPtr x)
{
	return mpfr_number_p((mpfr_ptr)x);
}

int Lib_Mpfr_Isinf(const MpfrPtr x)
{
	return mpfr_inf_p((mpfr_ptr)x);
}

int Lib_Mpfr_Isposinf(const MpfrPtr x)
{
	return (mpfr_inf_p((mpfr_ptr)x) && (mpfr_signbit((mpfr_ptr)x) == 0));
}

int Lib_Mpfr_Isneginf(const MpfrPtr x)
{
	return (mpfr_inf_p((mpfr_ptr)x) && (mpfr_signbit((mpfr_ptr)x) > 0));
}

int Lib_Mpfr_Isnan(const MpfrPtr x)
{
	return mpfr_nan_p((mpfr_ptr)x);
}



int Lib_Mpfr_Iszero(const MpfrPtr x)
{
	return mpfr_zero_p((mpfr_ptr)x);
}

int Lib_Mpfr_Isposzero(const MpfrPtr x)
{
	return (mpfr_zero_p((mpfr_ptr)x) && (mpfr_signbit((mpfr_ptr)x) == 0));
}

int Lib_Mpfr_Isnegzero(const MpfrPtr x)
{
	return (mpfr_zero_p((mpfr_ptr)x) && (mpfr_signbit((mpfr_ptr)x) > 0));
}

int Lib_Mpfr_Isone(const MpfrPtr x)
{
	return mpfr_cmp_ui((mpfr_ptr)x, 1);
}

int Lib_Mpfr_Isinteger(const MpfrPtr x)
{
	return mpfr_integer_p((mpfr_ptr)x);
}

int Lib_Mpfr_Isnumber(const MpfrPtr x)
{
	return mpfr_number_p((mpfr_ptr)x);
}

int Lib_Mpfr_Isregular(const MpfrPtr x)
{
	return mpfr_regular_p((mpfr_ptr)x);
}

int Lib_Mpfr_Isnormal(const MpfrPtr x)
{
	return mpfr_regular_p((mpfr_ptr)x);
}

int Lib_Mpfr_Issubnormal(const MpfrPtr x)
{
	return 0;
}

int Lib_Mpfr_Isunordered(const MpfrPtr x, const MpfrPtr y)
{
	return mpfr_unordered_p((mpfr_ptr)x, (mpfr_ptr)y);
}





int Lib_Mpfr_FitsInt32(const MpfrPtr x)
{
	return mpfr_fits_sint_p((mpfr_ptr)x, MPFR_RNDN);
}

int Lib_Mpfr_FitsInt64(const MpfrPtr x)
{
	return mpfr_fits_intmax_p((mpfr_ptr)x, MPFR_RNDN);
}

int Lib_Mpfr_FitsUInt32(const MpfrPtr x)
{
	return mpfr_fits_uint_p((mpfr_ptr)x, MPFR_RNDN);
}

int Lib_Mpfr_FitsUInt64(const MpfrPtr x)
{
	return mpfr_fits_uintmax_p((mpfr_ptr)x, MPFR_RNDN);
}






/* Integer Related Functions  */

void Lib_Mpfr_Nearbyint(MpfrPtr res, const MpfrPtr x)
{
	mpfr_rint((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Rint(MpfrPtr res, const MpfrPtr x)
{
	mpfr_rint((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

long int Lib_Mpfr_Lrint(const MpfrPtr x)
{
	return mpfr_get_si((mpfr_ptr)x, MPFR_RNDN);
}

long long int Lib_Mpfr_Llrint(const MpfrPtr x)
{
	return mpfr_get_sj((mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Ceil(MpfrPtr res, const MpfrPtr x)
{
	mpfr_ceil((mpfr_ptr)res, (mpfr_ptr)x);
}

void Lib_Mpfr_Floor(MpfrPtr res, const MpfrPtr x)
{
	mpfr_floor((mpfr_ptr)res, (mpfr_ptr)x);
}

void Lib_Mpfr_Trunc(MpfrPtr res, const MpfrPtr x)
{
	mpfr_trunc((mpfr_ptr)res, (mpfr_ptr)x);
}

void Lib_Mpfr_Round(MpfrPtr res, const MpfrPtr x)
{
	mpfr_round((mpfr_ptr)res, (mpfr_ptr)x);
}

long int Lib_Mpfr_Lround(const MpfrPtr x)
{
	return mpfr_get_si((mpfr_ptr)x, MPFR_RNDN);
}

long long int Lib_Mpfr_Llround(const MpfrPtr x)
{
	return mpfr_get_sj((mpfr_ptr)x, MPFR_RNDN);
}

int32_t Lib_Mpfr_ToInt32(const MpfrPtr x)
{
	return (int32_t)  mpfr_get_si((mpfr_ptr)x, MPFR_RNDN);
}

int64_t Lib_Mpfr_ToInt64(const MpfrPtr x)
{
	return (int64_t)  mpfr_get_sj((mpfr_ptr)x, MPFR_RNDN);
}

uint32_t Lib_Mpfr_ToUInt32(const MpfrPtr x)
{
	return (uint32_t)  mpfr_get_ui((mpfr_ptr)x, MPFR_RNDN);
}

uint64_t Lib_Mpfr_ToUInt64(const MpfrPtr x)
{
	return (uint64_t)  mpfr_get_uj((mpfr_ptr)x, MPFR_RNDN);
}









/* Floating point functions for real numbers */

void Lib_Mpfr_Copysign(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
	mpfr_copysign((mpfr_ptr)res, (mpfr_ptr)x, y, MPFR_RNDN);
}

void Lib_Mpfr_Frexp(MpfrPtr res, const MpfrPtr x, long int* e)
{
    mpfr_frexp(e, (mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Logb(MpfrPtr res, const MpfrPtr x)
{
    long int e;
    mpfr_frexp(&e, (mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
    mpfr_set_si((mpfr_ptr)res, e - 1, MPFR_RNDN);
}

int Lib_Mpfr_Ilogb(const MpfrPtr x)
{
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    long int e;
    mpfr_frexp(&e, (mpfr_ptr)temp, (mpfr_ptr)x, MPFR_RNDN);
    mpfr_clear(temp);
    return e - 1;
}

void Lib_Mpfr_Ldexp(MpfrPtr res, const MpfrPtr x, const long int e)
{
	mpfr_mul_2si((mpfr_ptr)res, (mpfr_ptr)x, e, MPFR_RNDN);
}

void Lib_Mpfr_Scalbn(MpfrPtr res, const MpfrPtr x, const int e)
{
	mpfr_mul_2si((mpfr_ptr)res, (mpfr_ptr)x, e, MPFR_RNDN);
}

void Lib_Mpfr_Scalbln(MpfrPtr res, const MpfrPtr x, const long int e)
{
	mpfr_mul_2si((mpfr_ptr)res, (mpfr_ptr)x, e, MPFR_RNDN);
}

void Lib_Mpfr_Fdim(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_dim((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}






/* Fraction and Remainder Related Functions  */

void Lib_Mpfr_Modf(MpfrPtr frac, const MpfrPtr x, MpfrPtr iptr)
{
	mpfr_modf((mpfr_ptr)iptr, (mpfr_ptr)frac, (mpfr_ptr)x, MPFR_RNDN) ;
}

void Lib_Mpfr_Fmod(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_fmod((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}

void Lib_Mpfr_Remainder(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
	mpfr_remainder((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN) ;
}

void Lib_Mpfr_Remquo(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, long* e)
{
    mpfr_remquo((mpfr_ptr)res, e, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}






/* Functions related to mantissa width and exponent range (MReal, BigDecimal) */

void Lib_Mpfr_Epsilon(MpfrPtr res)
{
	mpfr_machine_epsilon_prec((mpfr_ptr)res, mpfr_get_default_prec());
}

void Lib_Mpfr_Ulp(MpfrPtr res, const MpfrPtr x)
{
	mpfr_machine_epsilon_x((mpfr_ptr)res, (mpfr_ptr)x, mpfr_get_default_prec());
}

void Lib_Mpfr_Max(MpfrPtr res)
{
	mpfr_maxval_prec( (mpfr_ptr)res, mpfr_get_default_prec());
}

void Lib_Mpfr_Lowest(MpfrPtr res)
{
	mpfr_maxval_prec( (mpfr_ptr)res, mpfr_get_default_prec());
	mpfr_neg( (mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_Min(MpfrPtr res)
{
	mpfr_minval_prec( (mpfr_ptr)res, mpfr_get_default_prec());
}

void Lib_Mpfr_Nextabove(MpfrPtr res, const MpfrPtr x)
{
    Lib_Mpfr_Set(res, x);
	mpfr_nextabove((mpfr_ptr)res);
}

void Lib_Mpfr_Nextbelow(MpfrPtr res, const MpfrPtr x)
{
    Lib_Mpfr_Set(res, x);
	mpfr_nextbelow((mpfr_ptr)res);
}

void Lib_Mpfr_Nexttoward(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Lib_Mpfr_Set(res, x);
	mpfr_nexttoward((mpfr_ptr)res, (mpfr_ptr)y);
}






/* Mathematical Constants  */

void Lib_Mpfr_ConstDegree(MpfrPtr res)
{
    mpfr_const_degree( (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_ConstPhi(MpfrPtr res)
{
    mpfr_const_phi( (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_ConstLog2(MpfrPtr res)
{
    mpfr_const_log2( (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_ConstLog10(MpfrPtr res)
{
    mpfr_const_log10( (mpfr_ptr)res, MPFR_RNDN);
}


void Lib_Mpfr_ConstPi(MpfrPtr res)
{
    mpfr_const_pi( (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_ConstE(MpfrPtr res)
{
    mpfr_const_e( (mpfr_ptr)res, MPFR_RNDN);
}


void Lib_Mpfr_ConstEulerGamma(MpfrPtr res)
{
    mpfr_const_euler( (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_ConstApery(MpfrPtr res)
{
    mpfr_const_apery( (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_ConstCatalan(MpfrPtr res)
{
    mpfr_const_catalan( (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_ConstGlaisher(MpfrPtr res)
{
    Mpfr_Arb_Realfunc0_Prec(arb_const_glaisher, res);
}

void Lib_Mpfr_ConstKhinchin(MpfrPtr res)
{
    Mpfr_Arb_Realfunc0_Prec(arb_const_khinchin, res);
}





/* Complex components  */

void Lib_Mpfr_Fabs(MpfrPtr res, const MpfrPtr x)
{
	mpfr_abs((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Sign(MpfrPtr res, const MpfrPtr x)
{
    int sgn = mpfr_sgn((mpfr_ptr)x);
	mpfr_set_si((mpfr_ptr)res, sgn, MPFR_RNDN);
}





/* Roots and related functions  */

void Lib_Mpfr_Sqrt(MpfrPtr res, const MpfrPtr x)
{
	mpfr_sqrt((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}



void Lib_Mpfr_Sqrt1pm1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_log1p((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
    mpfr_mul_d((mpfr_ptr)res, (mpfr_ptr)res, 0.5, MPFR_RNDN);
	mpfr_expm1((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}



void Lib_Mpfr_Rsqrt(MpfrPtr res, const MpfrPtr x)
{
	mpfr_rec_sqrt((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Cbrt(MpfrPtr res, const MpfrPtr x)
{
	mpfr_cbrt((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Root_Si(MpfrPtr res, const MpfrPtr x, const int32_t k)
{
    mpfr_rootn_si((mpfr_ptr)res, (mpfr_ptr)x, k, MPFR_RNDN);
}



/* Exponential and related functions  */

void Lib_Mpfr_Exp(MpfrPtr res, const MpfrPtr x)
{
	mpfr_exp((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Exp2(MpfrPtr res, const MpfrPtr x)
{
	mpfr_exp2((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Exp10(MpfrPtr res, const MpfrPtr x)
{
	mpfr_exp10((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Expm1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_expm1((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Exp2m1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_exp2m1((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Exp10m1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_exp10m1((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}





/* Logarithms and related functions  */

void Lib_Mpfr_Log(MpfrPtr res, const MpfrPtr x)
{
	mpfr_log((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Log2(MpfrPtr res, const MpfrPtr x)
{
	mpfr_log2((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Log10(MpfrPtr res, const MpfrPtr x)
{
	mpfr_log10((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Log1p(MpfrPtr res, const MpfrPtr x)
{
	mpfr_log1p((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Log2p1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_log2p1((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Log10p1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_log10p1((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}




/* Power functions and roots  */


void Lib_Mpfr_Square(MpfrPtr res, const MpfrPtr x)
{
	mpfr_sqr((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Cube(MpfrPtr res, const MpfrPtr x)
{
	mpfr_sqr((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
	mpfr_mul((mpfr_ptr)res, (mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Hypot(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_hypot((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}

void Lib_Mpfr_Pow(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    mpfr_pow((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}



void Lib_Mpfr_Powm1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
	mpfr_log((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
    mpfr_mul((mpfr_ptr)res, (mpfr_ptr)res, (mpfr_ptr)y, MPFR_RNDN);
	mpfr_expm1((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_Pow1p(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
	mpfr_log1p((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
    mpfr_mul((mpfr_ptr)res, (mpfr_ptr)res, (mpfr_ptr)y, MPFR_RNDN);
	mpfr_exp((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_Pow1pm1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
	mpfr_log1p((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
    mpfr_mul((mpfr_ptr)res, (mpfr_ptr)res, (mpfr_ptr)y, MPFR_RNDN);
	mpfr_expm1((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}




void Lib_Mpfr_Pow_Si(MpfrPtr res, const MpfrPtr x, const int32_t n)
{
    mpfr_pow_si((mpfr_ptr)res, (mpfr_ptr)x, n, MPFR_RNDN);
}

void Lib_Mpfr_Compound_Si(MpfrPtr res, const MpfrPtr x, const int32_t n)
{
    mpfr_compound_si((mpfr_ptr)res, (mpfr_ptr)x, n, MPFR_RNDN);
}






/* Trigonometric functions  */

void Lib_Mpfr_Sin(MpfrPtr res, const MpfrPtr x)
{
	mpfr_sin((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Cos(MpfrPtr res, const MpfrPtr x)
{
	mpfr_cos((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Cosm1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_cosm1((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Tan(MpfrPtr res, const MpfrPtr x)
{
	mpfr_tan((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}


void Lib_Mpfr_Csc(MpfrPtr res, const MpfrPtr x)
{
	mpfr_csc((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Sec(MpfrPtr res, const MpfrPtr x)
{
	mpfr_sec((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Cot(MpfrPtr res, const MpfrPtr x)
{
	mpfr_cot((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}


void Lib_Mpfr_SinPi(MpfrPtr res, const MpfrPtr x)
{
	mpfr_sinpi((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_CosPi(MpfrPtr res, const MpfrPtr x)
{
	mpfr_cospi((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_TanPi(MpfrPtr res, const MpfrPtr x)
{
	mpfr_tanpi((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}



/* Hyperbolic functions  */

void Lib_Mpfr_Sinh(MpfrPtr res, const MpfrPtr x)
{
	mpfr_sinh((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Cosh(MpfrPtr res, const MpfrPtr x)
{
	mpfr_cosh((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Tanh(MpfrPtr res, const MpfrPtr x)
{
	mpfr_tanh((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}


void Lib_Mpfr_Csch(MpfrPtr res, const MpfrPtr x)
{
	mpfr_csch((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Sech(MpfrPtr res, const MpfrPtr x)
{
	mpfr_sech((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Coth(MpfrPtr res, const MpfrPtr x)
{
	mpfr_coth((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}


/* Inverse trigonometric functions  */

void Lib_Mpfr_Asin(MpfrPtr res, const MpfrPtr x)
{
	mpfr_asin((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Acos(MpfrPtr res, const MpfrPtr x)
{
	mpfr_acos((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Atan(MpfrPtr res, const MpfrPtr x)
{
	mpfr_atan((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Atan2(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
	mpfr_atan2((mpfr_ptr)res, (mpfr_ptr)x, (mpfr_ptr)y, MPFR_RNDN);
}

void Lib_Mpfr_Acsc(MpfrPtr res, const MpfrPtr x)
{
    mpfr_si_div((mpfr_ptr)res, 1, (mpfr_ptr)x, MPFR_RNDN);
	mpfr_asin((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_Asec(MpfrPtr res, const MpfrPtr x)
{
    mpfr_si_div((mpfr_ptr)res, 1, (mpfr_ptr)x, MPFR_RNDN);
	mpfr_acos((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_Acot(MpfrPtr res, const MpfrPtr x)
{
    mpfr_si_div((mpfr_ptr)res, 1, (mpfr_ptr)x, MPFR_RNDN);
	mpfr_atan((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}



/* Inverse hyperbolic functions  */

void Lib_Mpfr_Asinh(MpfrPtr res, const MpfrPtr x)
{
	mpfr_asinh((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Acosh(MpfrPtr res, const MpfrPtr x)
{
	mpfr_acosh((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Atanh(MpfrPtr res, const MpfrPtr x)
{
	mpfr_atanh((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Acsch(MpfrPtr res, const MpfrPtr x)
{
    mpfr_si_div((mpfr_ptr)res, 1, (mpfr_ptr)x, MPFR_RNDN);
	mpfr_asinh((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_Asech(MpfrPtr res, const MpfrPtr x)
{
    mpfr_si_div((mpfr_ptr)res, 1, (mpfr_ptr)x, MPFR_RNDN);
	mpfr_acosh((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}

void Lib_Mpfr_Acoth(MpfrPtr res, const MpfrPtr x)
{
    mpfr_si_div((mpfr_ptr)res, 1, (mpfr_ptr)x, MPFR_RNDN);
	mpfr_atanh((mpfr_ptr)res, (mpfr_ptr)res, MPFR_RNDN);
}



/* Special functions  */

void Lib_Mpfr_Erf(MpfrPtr res, const MpfrPtr x)
{
	mpfr_erf((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Erfc(MpfrPtr res, const MpfrPtr x)
{
	mpfr_erfc((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Tgamma(MpfrPtr res, const MpfrPtr x)
{
	mpfr_gamma((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_Lgamma(MpfrPtr res, const MpfrPtr x)
{
	mpfr_lngamma((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}


void Lib_Mpfr_BesselJ0(MpfrPtr res, const MpfrPtr x)
{
	mpfr_j0((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_BesselJ1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_j1((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_BesselJn(MpfrPtr res, const int n, const MpfrPtr x)
{
	mpfr_jn((mpfr_ptr)res, n, (mpfr_ptr)x, MPFR_RNDN);
}


void Lib_Mpfr_BesselY0(MpfrPtr res, const MpfrPtr x)
{
	mpfr_y0((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_BesselY1(MpfrPtr res, const MpfrPtr x)
{
	mpfr_y1((mpfr_ptr)res, (mpfr_ptr)x, MPFR_RNDN);
}

void Lib_Mpfr_BesselYn(MpfrPtr res, const int n, const MpfrPtr x)
{
	mpfr_yn((mpfr_ptr)res, n, (mpfr_ptr)x, MPFR_RNDN);
}







/** ********************** Complex Basic Functions, Mpfr/Mpc ******************************** **/



MpfcPtr Lib_Mpfc_Init_Func()
{
	MpfcPtr x;
	x = malloc(sizeof(__mpc_struct));
	mpc_init2((mpc_ptr)x, mpfr_get_default_prec());
	return x;
}

void Lib_Mpfc_Clear(MpfcPtr x)
{
	mpc_clear((mpc_ptr)x);
	free(x);
}



/* Input and output  */

void Lib_Mpfc_Set(MpfcPtr res, const MpfcPtr x)
{
	mpc_set((mpc_ptr)res, (mpc_ptr)x, MPFR_RNDN);
}


/* Operator overloading vs raw arithmetic and comparisons  */

void Lib_Mpfc_Neg(MpfcPtr res, const MpfcPtr x)
{
    mpc_neg((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Add(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    mpc_add((mpc_ptr)res, (mpc_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Sub(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    mpc_sub((mpc_ptr)res, (mpc_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Mul(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    mpc_mul((mpc_ptr)res, (mpc_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Div(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    mpc_div((mpc_ptr)res, (mpc_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}


void Lib_Mpfc_Add_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y)
{
    mpc_add_fr((mpc_ptr)res, (mpc_ptr)x, (mpfr_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Sub_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y)
{
    mpc_sub_fr((mpc_ptr)res, (mpc_ptr)x, (mpfr_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Mpfr_Sub(MpfcPtr res, const MpfcPtr y, const MpfrPtr x)
{
    mpc_fr_sub((mpc_ptr)res, (mpfr_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Mul_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y)
{
    mpc_mul_fr((mpc_ptr)res, (mpc_ptr)x, (mpfr_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Div_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y)
{
    mpc_div_fr((mpc_ptr)res, (mpc_ptr)x, (mpfr_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Mpfr_Div(MpfcPtr res, const MpfcPtr y, const MpfrPtr x)
{
    mpc_fr_div((mpc_ptr)res, (mpfr_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}


void Lib_Mpfc_Add_D(MpfcPtr res, const MpfcPtr x, const double y)
{
    mpfr_add_d(mpc_realref((mpc_ptr)res), mpc_realref((mpc_ptr)x), y, MPFR_RNDN);
    mpfr_add_d(mpc_imagref((mpc_ptr)res), mpc_imagref((mpc_ptr)x), y, MPFR_RNDN);
}

void Lib_Mpfc_Sub_D(MpfcPtr res, const MpfcPtr x, const double y)
{
    mpfr_sub_d(mpc_realref((mpc_ptr)res), mpc_realref((mpc_ptr)x), y, MPFR_RNDN);
    mpfr_sub_d(mpc_imagref((mpc_ptr)res), mpc_imagref((mpc_ptr)x), y, MPFR_RNDN);
}

void Lib_Mpfc_D_Sub(MpfcPtr res, const MpfcPtr y, const double x)
{
    mpfr_d_sub(mpc_realref((mpc_ptr)res), x, mpc_realref((mpc_ptr)y), MPFR_RNDN);
    mpfr_d_sub(mpc_imagref((mpc_ptr)res), x, mpc_imagref((mpc_ptr)y), MPFR_RNDN);
}

void Lib_Mpfc_Mul_D(MpfcPtr res, const MpfcPtr x, const double y)
{
    mpfr_mul_d(mpc_realref((mpc_ptr)res), mpc_realref((mpc_ptr)x), y, MPFR_RNDN);
    mpfr_mul_d(mpc_imagref((mpc_ptr)res), mpc_imagref((mpc_ptr)x), y, MPFR_RNDN);
}

void Lib_Mpfc_Div_D(MpfcPtr res, const MpfcPtr x, const double y)
{
    mpfr_div_d(mpc_realref((mpc_ptr)res), mpc_realref((mpc_ptr)x), y, MPFR_RNDN);
    mpfr_div_d(mpc_imagref((mpc_ptr)res), mpc_imagref((mpc_ptr)x), y, MPFR_RNDN);
}

void Lib_Mpfc_D_Div(MpfcPtr res, const MpfcPtr y, const double x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)y, MPC_RNDNN);
    mpfr_mul_d(mpc_realref((mpc_ptr)res), mpc_realref((mpc_ptr)res), x, MPFR_RNDN);
    mpfr_mul_d(mpc_imagref((mpc_ptr)res), mpc_imagref((mpc_ptr)res), x, MPFR_RNDN);
}


void Lib_Mpfc_Add_Si(MpfcPtr res, const MpfcPtr x, const int32_t y)
{
    mpfr_add_si(mpc_realref((mpc_ptr)res), mpc_realref((mpc_ptr)x), y, MPFR_RNDN);
    mpfr_add_si(mpc_imagref((mpc_ptr)res), mpc_imagref((mpc_ptr)x), y, MPFR_RNDN);
}

void Lib_Mpfc_Sub_Si(MpfcPtr res, const MpfcPtr x, const int32_t y)
{
    mpfr_sub_si(mpc_realref((mpc_ptr)res), mpc_realref((mpc_ptr)x), y, MPFR_RNDN);
    mpfr_sub_si(mpc_imagref((mpc_ptr)res), mpc_imagref((mpc_ptr)x), y, MPFR_RNDN);
}

void Lib_Mpfc_Si_Sub(MpfcPtr res, const MpfcPtr y, const int32_t x)
{
    mpfr_si_sub(mpc_realref((mpc_ptr)res), x, mpc_realref((mpc_ptr)y), MPFR_RNDN);
    mpfr_si_sub(mpc_imagref((mpc_ptr)res), x, mpc_imagref((mpc_ptr)y), MPFR_RNDN);
}

void Lib_Mpfc_Mul_Si(MpfcPtr res, const MpfcPtr x, const int32_t y)
{
    mpc_mul_si((mpc_ptr)res, (mpc_ptr)x, y, MPC_RNDNN);
}


void Lib_Mpfc_Inv(MpfcPtr res, const MpfcPtr x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Div_Si(MpfcPtr res, const MpfcPtr x, const int32_t y)
{
    mpfr_div_si(mpc_realref((mpc_ptr)res), mpc_realref((mpc_ptr)x), y, MPFR_RNDN);
    mpfr_div_si(mpc_imagref((mpc_ptr)res), mpc_imagref((mpc_ptr)x), y, MPFR_RNDN);
}

void Lib_Mpfc_Si_Div(MpfcPtr res, const MpfcPtr y, const int32_t x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)y, MPC_RNDNN);
    mpc_mul_si((mpc_ptr)res, (mpc_ptr)res, x, MPC_RNDNN);
}


int32_t Lib_Mpfc_Cmp(const MpfcPtr x, const MpfcPtr y)
{
    return mpc_cmp((mpc_ptr) x, (mpc_ptr) y);
}






/* Floating point functions for real numbers  */

/* Integer and Remainder Related Functions  */

/* Machine constants and properties of numbers  */

/* Complex components  */

void Lib_Mpfc_Set_Real(MpfcPtr res, const MpfrPtr re)
{
	mpc_set_fr((mpc_ptr)res, (mpfr_ptr)re, MPFR_RNDN);
}

void Lib_Mpfc_Set2(MpfcPtr res, const MpfrPtr re, const MpfrPtr im)
{
	mpc_set_fr_fr((mpc_ptr)res, (mpfr_ptr)re, (mpfr_ptr)im, MPFR_RNDN);
}

void Lib_Mpfc_Set2_Si(MpfcPtr res, const int32_t re, const int32_t im)
{
	mpc_set_si_si((mpc_ptr)res, re, im, MPFR_RNDN);
}

void Lib_Mpfc_Abs(MpfrPtr res, const MpfcPtr x)
{
	mpc_abs((mpfr_ptr)res, (mpc_ptr)x, MPFR_RNDN);
}

void Lib_Mpfc_Arg(MpfrPtr res, const MpfcPtr x)
{
	mpc_arg((mpfr_ptr)res, (mpc_ptr)x, MPFR_RNDN);
}

void Lib_Mpfc_Imag(MpfrPtr res, const MpfcPtr x)
{
	mpc_imag((mpfr_ptr)res, (mpc_ptr)x, MPFR_RNDN);
}

void Lib_Mpfc_Real(MpfrPtr res, const MpfcPtr x)
{
	mpc_real((mpfr_ptr)res, (mpc_ptr)x, MPFR_RNDN);
}

void Lib_Mpfc_Conj(MpfcPtr res, const MpfcPtr x)
{
    mpc_conj((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Proj(MpfcPtr res, const MpfcPtr x)
{
    mpc_proj((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}



/* Mathematical Constants  */


void Lib_Mpfc_Onei(MpfcPtr res)
{
    mpc_set_ui_ui((mpc_ptr)res, 0, 1, MPC_RNDNN);
}




/* Roots  */

void Lib_Mpfc_Sqrt(MpfcPtr res, const MpfcPtr x)
{
    mpc_sqrt((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Sqrt1pm1(MpfcPtr res, const MpfcPtr x)
{
    mpfc_sqrt1pm1((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Rsqrt(MpfcPtr res, const MpfcPtr x)
{
    mpc_sqrt((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)x, MPC_RNDNN);
}


void Lib_Mpfc_Cbrt(MpfcPtr res, const MpfcPtr x)
{
    mpfc_root_si((mpc_ptr)res, (mpc_ptr)x, 3);
}

void Lib_Mpfc_Root_Si(MpfcPtr res, const MpfcPtr x, const int32_t k)
{
    mpfc_root_si((mpc_ptr)res, (mpc_ptr)x, k);
}



/* Exponential and related functions  */


void Lib_Mpfc_Exp(MpfcPtr res, const MpfcPtr x)
{
    mpc_exp((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Exp2(MpfcPtr res, const MpfcPtr x)
{
    mpfc_exp2((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Exp10(MpfcPtr res, const MpfcPtr x)
{
    mpfc_exp10((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}


void Lib_Mpfc_Expm1(MpfcPtr res, const MpfcPtr x)
{
    mpfc_expm1((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Exp2m1(MpfcPtr res, const MpfcPtr x)
{
    mpfc_exp2m1((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Exp10m1(MpfcPtr res, const MpfcPtr x)
{
    mpfc_exp10m1((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}





/* Logarithms and related functions  */

void Lib_Mpfc_Log(MpfcPtr res, const MpfcPtr x)
{
    mpc_log((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Log2(MpfcPtr res, const MpfcPtr x)
{
    mpfc_log2((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Log10(MpfcPtr res, const MpfcPtr x)
{
    mpc_log10((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}


void Lib_Mpfc_Log1p(MpfcPtr res, const MpfcPtr x)
{
    mpfc_log1p((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Log2p1(MpfcPtr res, const MpfcPtr x)
{
    mpfc_log2p1((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Log10p1(MpfcPtr res, const MpfcPtr x)
{
    mpfc_log10p1((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}





/* Power functions and roots  */

void Lib_Mpfc_Square(MpfcPtr res, const MpfcPtr x)
{
    mpc_sqr((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Cube(MpfcPtr res, const MpfcPtr x)
{
    mpc_sqr((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
    mpc_mul((mpc_ptr)res, (mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}



void Lib_Mpfc_Pow(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    mpc_pow((mpc_ptr)res, (mpc_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Powm1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    mpfc_powm1((mpc_ptr)res, (mpc_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Pow1p(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    mpfc_pow1p((mpc_ptr)res, (mpc_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}

void Lib_Mpfc_Pow1pm1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    mpfc_pow1pm1((mpc_ptr)res, (mpc_ptr)x, (mpc_ptr)y, MPC_RNDNN);
}



void Lib_Mpfc_Pow_Si(MpfcPtr res, const MpfcPtr x, const int32_t y)
{
    mpc_pow_si((mpc_ptr)res, (mpc_ptr)x, y, MPC_RNDNN);
}

void Lib_Mpfc_Compound_Si(MpfcPtr res, const MpfcPtr x, const int32_t y)
{
    mpc_add_si((mpc_ptr)res, (mpc_ptr)x, 1, MPC_RNDNN);
    mpc_pow_si((mpc_ptr)res, (mpc_ptr)res, y, MPC_RNDNN);
}



void Lib_Mpfc_Pow_D(MpfcPtr res, const MpfcPtr x, const double y)
{
    mpc_pow_d((mpc_ptr)res, (mpc_ptr)x, y, MPC_RNDNN);
}

void Lib_Mpfc_Pow_Mpfr(MpfcPtr res, const MpfcPtr x, const MpfrPtr y)
{
    mpc_pow_fr((mpc_ptr)res, (mpc_ptr)x, (mpfr_ptr)y, MPC_RNDNN);
}




/* Trigonometric functions  */

void Lib_Mpfc_Sin(MpfcPtr res, const MpfcPtr x)
{
    mpc_sin((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Cos(MpfcPtr res, const MpfcPtr x)
{
    mpc_cos((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Tan(MpfcPtr res, const MpfcPtr x)
{
    mpc_tan((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}


void Lib_Mpfc_Csc(MpfcPtr res, const MpfcPtr x)
{
    mpc_sin((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)res, MPC_RNDNN);
}

void Lib_Mpfc_Sec(MpfcPtr res, const MpfcPtr x)
{
    mpc_cos((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)res, MPC_RNDNN);
}

void Lib_Mpfc_Cot(MpfcPtr res, const MpfcPtr x)
{
    mpc_tan((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)res, MPC_RNDNN);
}



void Lib_Mpfc_SinPi(MpfcPtr res, const MpfcPtr x)
{
    //mpc_sin((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_CosPi(MpfcPtr res, const MpfcPtr x)
{
    //mpc_cos((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_TanPi(MpfcPtr res, const MpfcPtr x)
{
    //mpc_tan((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}




/* Hyperbolic functions  */

void Lib_Mpfc_Sinh(MpfcPtr res, const MpfcPtr x)
{
    mpc_sinh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Cosh(MpfcPtr res, const MpfcPtr x)
{
    mpc_cosh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Tanh(MpfcPtr res, const MpfcPtr x)
{
    mpc_tanh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Csch(MpfcPtr res, const MpfcPtr x)
{
    mpc_sinh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)res, MPC_RNDNN);

}

void Lib_Mpfc_Sech(MpfcPtr res, const MpfcPtr x)
{
    mpc_cosh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)res, MPC_RNDNN);
}

void Lib_Mpfc_Coth(MpfcPtr res, const MpfcPtr x)
{
    mpc_tanh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)res, MPC_RNDNN);
}





/* Inverse trigonometric functions  */

void Lib_Mpfc_Asin(MpfcPtr res, const MpfcPtr x)
{
    mpc_asin((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Acos(MpfcPtr res, const MpfcPtr x)
{
    mpc_acos((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Atan(MpfcPtr res, const MpfcPtr x)
{
    mpc_atan((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}


void Lib_Mpfc_Acsc(MpfcPtr res, const MpfcPtr x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)x, MPC_RNDNN);
    mpc_asin((mpc_ptr)res, (mpc_ptr)res, MPC_RNDNN);
}

void Lib_Mpfc_Asec(MpfcPtr res, const MpfcPtr x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)x, MPC_RNDNN);
    mpc_acos((mpc_ptr)res, (mpc_ptr)res, MPC_RNDNN);
}

void Lib_Mpfc_Acot(MpfcPtr res, const MpfcPtr x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)x, MPC_RNDNN);
    mpc_atan((mpc_ptr)res, (mpc_ptr)res, MPC_RNDNN);
}




/* Inverse hyperbolic functions  */

void Lib_Mpfc_Asinh(MpfcPtr res, const MpfcPtr x)
{
    mpc_asinh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Acosh(MpfcPtr res, const MpfcPtr x)
{
    mpc_acosh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}

void Lib_Mpfc_Atanh(MpfcPtr res, const MpfcPtr x)
{
    mpc_atanh((mpc_ptr)res, (mpc_ptr)x, MPC_RNDNN);
}


void Lib_Mpfc_Acsch(MpfcPtr res, const MpfcPtr x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)x, MPC_RNDNN);
    mpc_asinh((mpc_ptr)res, (mpc_ptr)res, MPC_RNDNN);
}

void Lib_Mpfc_Asech(MpfcPtr res, const MpfcPtr x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)x, MPC_RNDNN);
    mpc_acosh((mpc_ptr)res, (mpc_ptr)res, MPC_RNDNN);
}

void Lib_Mpfc_Acoth(MpfcPtr res, const MpfcPtr x)
{
    mpc_ui_div((mpc_ptr)res, 1, (mpc_ptr)x, MPC_RNDNN);
    mpc_atanh((mpc_ptr)res, (mpc_ptr)res, MPC_RNDNN);
}















//*********************** Flint **********************************




//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////



void Mpfr_Arb_Realfunc0_Prec(ArbFuncPtr0 f0, MpfrPtr out1)
{
	//printf("using Mpfr_Arb_Realfunc0_Prec:  ");
	slong wp = mpfr_get_default_prec();

    arb_t out1_arb;
    arb_init(out1_arb);

	f0((arb_ptr)out1_arb, wp);

    arf_get_mpfr((mpfr_ptr)out1, arb_midref(out1_arb), MPFR_RNDN);
    arb_clear(out1_arb);
}



void Mpfr_Arb_Realfunc0Int32_Prec(ArbFuncPtr0Int32 f0Int32, MpfrPtr out1, const int32_t in1)
{
	//printf("using Mpfr_Arb_Realfunc0Int32_Prec:  ");
	slong wp = mpfr_get_default_prec();

    arb_t out1_arb;
    arb_init(out1_arb);

	f0Int32((arb_ptr)out1_arb, in1, wp);

    arf_get_mpfr((mpfr_ptr)out1, arb_midref(out1_arb), MPFR_RNDN);
    arb_clear(out1_arb);
}




void Mpfr_Arb_Realfunc1_Prec(ArbFuncPtr1 f1, MpfrPtr out1, MpfrPtr in1)
{
	//printf("using Mpfr_Arb_Realfunc1_Prec:  ");
	slong wp = mpfr_get_default_prec();

    arb_t out1_arb, in1_arb;
    arb_init(out1_arb);
    arb_init(in1_arb);
    arf_set_mpfr(arb_midref(in1_arb), (mpfr_ptr)in1);

	f1(out1_arb, in1_arb, wp);

    arf_get_mpfr((mpfr_ptr)out1, arb_midref(out1_arb), MPFR_RNDN);
    arb_clear(in1_arb);
    arb_clear(out1_arb);
}



void Mpfr_Arb_Realfunc1Int32_Prec(ArbFuncPtr1Int32 f1Int32, MpfrPtr out1, MpfrPtr in1, const int32_t in2)
{
	//printf("using Mpfr_Arb_Realfunc1_Prec:  ");
	slong wp = mpfr_get_default_prec();

    arb_t out1_arb, in1_arb;
    arb_init(out1_arb);
    arb_init(in1_arb);
    arf_set_mpfr(arb_midref(in1_arb), (mpfr_ptr)in1);

	//f1(out1_arb, in1_arb, wp);
	f1Int32(out1_arb, in1_arb, in2, wp);

    arf_get_mpfr((mpfr_ptr)out1, arb_midref(out1_arb), MPFR_RNDN);
    arb_clear(in1_arb);
    arb_clear(out1_arb);
}



void Mpfr_Arb_Realfunc2_Prec(ArbFuncPtr2 f2, MpfrPtr out1, MpfrPtr in1, MpfrPtr in2)
{
	//printf("using Mpfr_Arb_Realfunc2_Prec:  ");
	slong wp = mpfr_get_default_prec();

    arb_t out1_arb, in1_arb, in2_arb;
    arb_init(out1_arb);
    arb_init(in1_arb);
    arb_init(in2_arb);
    arf_set_mpfr(arb_midref(in1_arb), (mpfr_ptr)in1);
    arf_set_mpfr(arb_midref(in2_arb), (mpfr_ptr)in2);

	f2(out1_arb, in1_arb, in2_arb, wp);

    arf_get_mpfr((mpfr_ptr)out1, arb_midref(out1_arb), MPFR_RNDN);
    arb_clear(in2_arb);
    arb_clear(in1_arb);
    arb_clear(out1_arb);
}



void Mpfr_Arb_Realfunc3_Prec(ArbFuncPtr3 f3, MpfrPtr out1, MpfrPtr in1, MpfrPtr in2, MpfrPtr in3)
{
	//printf("using Mpfr_Arb_Realfunc3_Prec:  ");
	slong wp = mpfr_get_default_prec();

    arb_t out1_arb, in1_arb, in2_arb, in3_arb;
    arb_init(out1_arb);
    arb_init(in1_arb);
    arb_init(in2_arb);
    arb_init(in3_arb);
    arf_set_mpfr(arb_midref(in1_arb), (mpfr_ptr)in1);
    arf_set_mpfr(arb_midref(in2_arb), (mpfr_ptr)in2);
    arf_set_mpfr(arb_midref(in3_arb), (mpfr_ptr)in3);

	f3(out1_arb, in1_arb, in2_arb, in3_arb, wp);

    arf_get_mpfr((mpfr_ptr)out1, arb_midref(out1_arb), MPFR_RNDN);
    arb_clear(in3_arb);
    arb_clear(in2_arb);
    arb_clear(in1_arb);
    arb_clear(out1_arb);
}



void Mpfr_Arb_Realfunc4_Prec(ArbFuncPtr4 f4, MpfrPtr out1, MpfrPtr in1, MpfrPtr in2, MpfrPtr in3, MpfrPtr in4)
{
	//printf("using Mpfr_Arb_Realfunc4_Prec:  ");
	slong wp = mpfr_get_default_prec();

    arb_t out1_arb, in1_arb, in2_arb, in3_arb, in4_arb;
    arb_init(out1_arb);
    arb_init(in1_arb);
    arb_init(in2_arb);
    arb_init(in3_arb);
    arb_init(in4_arb);
    arf_set_mpfr(arb_midref(in1_arb), (mpfr_ptr)in1);
    arf_set_mpfr(arb_midref(in2_arb), (mpfr_ptr)in2);
    arf_set_mpfr(arb_midref(in3_arb), (mpfr_ptr)in3);
    arf_set_mpfr(arb_midref(in4_arb), (mpfr_ptr)in4);

	f4(out1_arb, in1_arb, in2_arb, in3_arb, in4_arb, wp);

    arf_get_mpfr((mpfr_ptr)out1, arb_midref(out1_arb), MPFR_RNDN);
    arb_clear(in4_arb);
    arb_clear(in3_arb);
    arb_clear(in2_arb);
    arb_clear(in1_arb);
    arb_clear(out1_arb);
}



void Mpfc_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, MpfcPtr out1, const int32_t in1)
{
	//printf("using Mpfc_Acb_Cplxfunc0Int32_Prec:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb;
    acb_init(out1_acb);

	//f1(out1_acb, in1_acb, wp);
	f0Int32((acb_ptr)out1_acb, in1, wp);

    acb_get_mpc((mpc_ptr)out1, out1_acb);
    acb_clear(out1_acb);
}



void Mpfc_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, MpfcPtr out1, MpfcPtr in1)
{
	//printf("using Mpfc_Acb_Cplxfunc1_Prec:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_mpc(in1_acb, (mpc_ptr)in1);

	f1(out1_acb, in1_acb, wp);

    acb_get_mpc((mpc_ptr)out1, out1_acb);
    acb_clear(in1_acb); acb_clear(out1_acb);
}



void Mpfc_Acb_Cplxfunc1Int32_Prec(AcbFuncPtr1Int32 f1Int32, MpfcPtr out1, MpfcPtr in1, const int32_t in2)
{
	//printf("using Mpfc_Acb_Cplxfunc1Int32_Prec:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_mpc(in1_acb, (mpc_ptr)in1);

	//f1(out1_acb, in1_acb, wp);
	f1Int32((acb_ptr)out1_acb, (acb_ptr)in1_acb, in2, wp);

    acb_get_mpc((mpc_ptr)out1, out1_acb);
    acb_clear(in1_acb); acb_clear(out1_acb);
}



void Mpfc_Acb_Cplxfunc2_Prec(AcbFuncPtr2 f2, MpfcPtr out1, MpfcPtr in1, MpfcPtr in2)
{
	//printf("using Mpfc_Acb_Cplxfunc2_Prec:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb, in2_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb);
    acb_set_mpc(in1_acb, (mpc_ptr)in1); acb_set_mpc(in2_acb, (mpc_ptr)in2);

	f2(out1_acb, in1_acb, in2_acb, wp);

    acb_get_mpc((mpc_ptr)out1, out1_acb);
    acb_clear(in2_acb); acb_clear(in1_acb); acb_clear(out1_acb);
}



void Mpfc_Acb_Cplxfunc3_Prec(AcbFuncPtr3 f3, MpfcPtr out1, MpfcPtr in1, MpfcPtr in2, MpfcPtr in3)
{
	//printf("using Mpfc_Acb_Cplxfunc3_Prec:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb, in2_acb, in3_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb);
    acb_set_mpc(in1_acb, (mpc_ptr)in1); acb_set_mpc(in2_acb, (mpc_ptr)in2); acb_set_mpc(in3_acb, (mpc_ptr)in3);

	f3(out1_acb, in1_acb, in2_acb, in3_acb, wp);

    acb_get_mpc((mpc_ptr)out1, out1_acb);
    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb);
}



void Mpfc_Acb_Cplxfunc4_Prec(AcbFuncPtr4 f4, MpfcPtr out1, MpfcPtr in1, MpfcPtr in2, MpfcPtr in3, MpfcPtr in4)
{
	//printf("using Mpfc_Acb_Cplxfunc4_Prec:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb, in2_acb, in3_acb, in4_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb); acb_init(in4_acb);
    acb_set_mpc(in1_acb, (mpc_ptr)in1); acb_set_mpc(in2_acb, (mpc_ptr)in2); acb_set_mpc(in3_acb, (mpc_ptr)in3); acb_set_mpc(in4_acb, (mpc_ptr)in4);

	f4(out1_acb, in1_acb, in2_acb, in3_acb, in4_acb, wp);

    acb_get_mpc((mpc_ptr)out1, out1_acb);
    acb_clear(in4_acb); acb_clear(in3_acb); acb_clear(in2_acb); acb_clear(in1_acb); acb_clear(out1_acb);
}




/* Roots and quadratic, cubic, and quartic equations */


void Lib_Mpfr_Arb_Sqrt(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sqrt, res, x);
}


void Lib_Mpfr_Arb_Rsqrt(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_rsqrt, res, x);
}


void Lib_Mpfr_Arb_Cbrt(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_cbrt, res, x);
}


void Lib_Mpfr_Arb_Sqrt1pm1(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sqrt1pm1, res, x);
}


void Lib_Mpfr_Arb_Root_ui(MpfrPtr res, const MpfrPtr x, const int32_t n)
{
    Mpfr_Arb_Realfunc1Int32_Prec(arb_root_ui_, res, x, n);
}


void Lib_Mpfr_Arb_Root_si(MpfrPtr res, const MpfrPtr x, const int32_t n)
{
    Mpfr_Arb_Realfunc1Int32_Prec(arb_root_si_, res, x, n);
}





/* Exponential and related functions */



void Lib_Mpfr_Arb_Exp(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_exp, res, x);
}


void Lib_Mpfr_Arb_Expm1(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_expm1, res, x);
}


void Lib_Mpfr_Arb_Exp10(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_exp10_, res, x);
}


void Lib_Mpfr_Arb_Exp2(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_exp2_, res, x);
}


void Lib_Mpfr_Arb_Exp10m1(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_exp10m1_, res, x);
}


void Lib_Mpfr_Arb_Exp2m1(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_exp2m1_, res, x);
}


void Lib_Mpfr_Arb_ExpRel(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_exprel_, res, x);
}




/* Logarithms and related functions */



void Lib_Mpfr_Arb_Log(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_log, res, x);
}


void Lib_Mpfr_Arb_Logbase(MpfrPtr res, const MpfrPtr x, const MpfrPtr b)
{
    Mpfr_Arb_Realfunc2_Prec(arb_logbase_, res, x, b);
}


void Lib_Mpfr_Arb_Log10(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_log10, res, x);
}


void Lib_Mpfr_Arb_Log2(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_log2, res, x);
}


void Lib_Mpfr_Arb_Log1p(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_log1p, res, x);
}


void Lib_Mpfr_Arb_Log10p1(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_log10p1_, res, x);
}


void Lib_Mpfr_Arb_Log2p1(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_log2p1_, res, x);
}


void Lib_Mpfr_Arb_Log1mexp(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_log1mexp_, res, x);
}


void Lib_Mpfr_Arb_LambertW0(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_lambertw0, res, x);
}


void Lib_Mpfr_Arb_LambertWm1(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_lambertwm1, res, x);
}






/* Power functions */


void Lib_Mpfr_Arb_Square(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sqr, res, x);
}


void Lib_Mpfr_Arb_Cube(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_cube_, res, x);
}


void Lib_Mpfr_Arb_Pow_ui(MpfrPtr res, const MpfrPtr x, const int32_t n)
{
    Mpfr_Arb_Realfunc1Int32_Prec(arb_pow_ui_, res, x, n);
}


void Lib_Mpfr_Arb_Pow_si(MpfrPtr res, const MpfrPtr x, const int32_t n)
{
    Mpfr_Arb_Realfunc1Int32_Prec(arb_pow_si_, res, x, n);
}


void Lib_Mpfr_Arb_Compound_si(MpfrPtr res, const MpfrPtr x, const int32_t n)
{
    Mpfr_Arb_Realfunc1Int32_Prec(arb_compound_si_, res, x, n);
}



void Lib_Mpfr_Arb_Hypot(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypot, res, x, y);
}


void Lib_Mpfr_Arb_Pow(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_pow, res, x, y);
}


void Lib_Mpfr_Arb_Powm1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_powm1_, res, x, y);
}


void Lib_Mpfr_Arb_Pow1p(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_pow1p_, res, x, y);
}


void Lib_Mpfr_Arb_Pow1pm1(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_pow1pm1_, res, x, y);
}





/* Trigonometric and related functions */


void Lib_Mpfr_Arb_Sin(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sin, res, x);
}


void Lib_Mpfr_Arb_Cos(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_cos, res, x);
}


void Lib_Mpfr_Arb_Tan(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_tan, res, x);
}



void Lib_Mpfr_Arb_Csc(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_csc, res, x);
}


void Lib_Mpfr_Arb_Sec(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sec, res, x);
}


void Lib_Mpfr_Arb_Cot(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_cot, res, x);
}


void Lib_Mpfr_Arb_Sinc(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sinc, res, x);
}


void Lib_Mpfr_Arb_SincPi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sinc_pi, res, x);
}


void Lib_Mpfr_Arb_SinPi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sin_pi, res, x);
}


void Lib_Mpfr_Arb_CosPi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_cos_pi, res, x);
}


void Lib_Mpfr_Arb_TanPi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_tan_pi, res, x);
}


void Lib_Mpfr_Arb_CscPi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_csc_pi, res, x);
}


void Lib_Mpfr_Arb_SecPi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sec_pi_, res, x);
}


void Lib_Mpfr_Arb_CotPi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_cot_pi, res, x);
}




/* Hyperbolic functions */


void Lib_Mpfr_Arb_Sinh(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sinh, res, x);
}


void Lib_Mpfr_Arb_Cosh(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_cosh, res, x);
}


void Lib_Mpfr_Arb_Tanh(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_tanh, res, x);
}



void Lib_Mpfr_Arb_Csch(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_csch, res, x);
}


void Lib_Mpfr_Arb_Sech(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_sech, res, x);
}


void Lib_Mpfr_Arb_Coth(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_coth, res, x);
}





/* Inverse trigonometric functions */


void Lib_Mpfr_Arb_Asin(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_asin, res, x);
}


void Lib_Mpfr_Arb_Acos(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_acos, res, x);
}



void Lib_Mpfr_Arb_Atan2(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_atan2, res, x, y);
}


void Lib_Mpfr_Arb_Atan(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_atan, res, x);
}



void Lib_Mpfr_Arb_Acsc(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_acsc, res, x);
}


void Lib_Mpfr_Arb_Asec(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_asec, res, x);
}


void Lib_Mpfr_Arb_Acot(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_Mpfr_Arb_Asinh(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_asinh, res, x);
}


void Lib_Mpfr_Arb_Acosh(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_acosh, res, x);
}


void Lib_Mpfr_Arb_Atanh(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_atanh, res, x);
}



void Lib_Mpfr_Arb_Acsch(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_acsch, res, x);
}


void Lib_Mpfr_Arb_Asech(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_asech, res, x);
}


void Lib_Mpfr_Arb_Acoth(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_acoth, res, x);
}







/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_Mpfr_Arb_MEllipticK(MpfrPtr res, const MpfrPtr m)
{
    Mpfr_Arb_Realfunc1_Prec(arb_elliptic_k, res, m);
}


void Lib_Mpfr_Arb_MEllipticE(MpfrPtr res, const MpfrPtr m)
{
    Mpfr_Arb_Realfunc1_Prec(arb_elliptic_e, res, m);
}


void Lib_Mpfr_Arb_MEllipticPi(MpfrPtr res, const MpfrPtr n, const MpfrPtr m)
{
    Mpfr_Arb_Realfunc2_Prec(arb_elliptic_pi, res, n, m);
}


void Lib_Mpfr_Arb_MEllipticF(MpfrPtr res, const MpfrPtr phi, const MpfrPtr m)
{
    Mpfr_Arb_Realfunc2_Prec(arb_elliptic_f_, res, phi, m);
}


void Lib_Mpfr_Arb_MEllipticEInc(MpfrPtr res, const MpfrPtr phi, const MpfrPtr m)
{
    Mpfr_Arb_Realfunc2_Prec(arb_elliptic_e_inc_, res, phi, m);
}


void Lib_Mpfr_Arb_MEllipticPiInc(MpfrPtr res, const MpfrPtr n, const MpfrPtr phi, const MpfrPtr m)
{
    Mpfr_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_, res, n, phi, m);
}




/* Legendre elliptic integrals (elliptic modulus k), and related functions */




void Lib_Mpfr_Arb_EllipticK(MpfrPtr res, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc1_Prec(arb_elliptic_k_k_, res, k);
}


void Lib_Mpfr_Arb_EllipticE(MpfrPtr res, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc1_Prec(arb_elliptic_e_k_, res, k);
}


void Lib_Mpfr_Arb_EllipticPi(MpfrPtr res, const MpfrPtr n, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(arb_elliptic_pi_k_, res, n, k);
}


void Lib_Mpfr_Arb_EllipticF(MpfrPtr res, const MpfrPtr phi, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(arb_elliptic_f_k_, res, phi, k);
}


void Lib_Mpfr_Arb_EllipticEInc(MpfrPtr res, const MpfrPtr phi, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(arb_elliptic_e_inc_k_, res, phi, k);
}


void Lib_Mpfr_Arb_EllipticPiInc(MpfrPtr res, const MpfrPtr n, const MpfrPtr phi, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_k_, res, n, phi, k);
}


void Lib_Mpfr_Arb_Agm(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */


void Lib_Mpfr_Arb_Elliptic_RC(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_elliptic_rc_, res, x, y);
}


void Lib_Mpfr_Arb_Elliptic_RF(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_elliptic_rf_, res, x, y, z);
}


void Lib_Mpfr_Arb_Elliptic_RG(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_elliptic_rg_, res, x, y, z);
}


void Lib_Mpfr_Arb_Elliptic_RD(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_elliptic_rd_, res, x, y, z);
}


void Lib_Mpfr_Arb_Elliptic_RJ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, const MpfrPtr w)
{
    Mpfr_Arb_Realfunc4_Prec(arb_elliptic_rj_, res, x, y, z, w);
}





/* Jacobi theta functions */


void Lib_Mpfr_Arb_Theta1Q(MpfrPtr res, const MpfrPtr z, const MpfrPtr q)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_theta1q, res, z, q);
}


void Lib_Mpfr_Arb_Theta2Q(MpfrPtr res, const MpfrPtr z, const MpfrPtr q)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_theta2q, res, z, q);
}


void Lib_Mpfr_Arb_Theta3Q(MpfrPtr res, const MpfrPtr z, const MpfrPtr q)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_theta3q, res, z, q);
}


void Lib_Mpfr_Arb_Theta4Q(MpfrPtr res, const MpfrPtr z, const MpfrPtr q)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_theta4q, res, z, q);
}




/* Jacobi elliptic functions */



void Lib_Mpfr_Arb_JacobiSN(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_sn, res, u, k);
}


void Lib_Mpfr_Arb_JacobiCN(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_cn, res, u, k);
}


void Lib_Mpfr_Arb_JacobiDN(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_dn, res, u, k);
}


void Lib_Mpfr_Arb_JacobiNS(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_ns, res, u, k);
}


void Lib_Mpfr_Arb_JacobiNC(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_nc, res, u, k);
}


void Lib_Mpfr_Arb_JacobiND(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_nd, res, u, k);
}


void Lib_Mpfr_Arb_JacobiSC(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_sc, res, u, k);
}


void Lib_Mpfr_Arb_JacobiSD(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_sd, res, u, k);
}


void Lib_Mpfr_Arb_JacobiDC(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_dc, res, u, k);
}


void Lib_Mpfr_Arb_JacobiDS(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_ds, res, u, k);
}


void Lib_Mpfr_Arb_JacobiCS(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_cs, res, u, k);
}


void Lib_Mpfr_Arb_JacobiCD(MpfrPtr res, const MpfrPtr u, const MpfrPtr k)
{
    Mpfr_Arb_Realfunc2_Prec(_arb_jacobi_cd, res, u, k);
}





/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */



void Lib_Mpfr_Arb_LerchPhi(MpfrPtr res, const MpfrPtr z, const MpfrPtr s, const MpfrPtr a)
{
    Mpfr_Arb_Realfunc3_Prec(arb_dirichlet_lerch_phi, res, z, s, a);
}





/* Polygamma functions */


void Lib_Mpfr_Arb_Polygamma(MpfrPtr res, const MpfrPtr s, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc2_Prec(arb_polygamma, res, s, z);
}


void Lib_Mpfr_Arb_Digamma(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_digamma, res, x);
}



/* Polylogarithms and related functions */




void Lib_Mpfr_Arb_Polylog(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_polylog, res, x, y);
}


void Lib_Mpfr_Arb_Dilog(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_dilog, res, x);
}



/* Hurwitz zeta function and related functions */


void Lib_Mpfr_Arb_HurwitzZeta(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hurwitz_zeta, res, x, y);
}



void Lib_Mpfr_Arb_Bernoulli_ui(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_bernoulli_ui_, res, n);
}


void Lib_Mpfr_Arb_Euler_ui(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_euler_number_ui_, res, n);
}



void Lib_Mpfr_Arb_BernoulliPoly_ui(MpfrPtr res, const MpfrPtr x, const int32_t n)
{
    Mpfr_Arb_Realfunc1Int32_Prec(arb_bernoulli_poly_ui_, res, x, n);
}



void Lib_Mpfr_Arb_BarnesG(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_barnes_g, res, x);
}


void Lib_Mpfr_Arb_LogBarnesG(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */



void Lib_Mpfr_Arb_Zeta(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_zeta, res, x);
}




void Lib_Mpfr_Arb_BacklundS(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(acb_dirichlet_backlund_s, res, x);
}


void Lib_Mpfr_Arb_GramPoint_ui(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_gram_point_ui_, res, n);
}







/* Additional numbertheoretic functions */


void Lib_Mpfr_Arb_Bell_ui(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_bell_ui_, res, n);
}


void Lib_Mpfr_Arb_Partitions_ui(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_partitions_ui_, res, n);
}


void Lib_Mpfr_Arb_Primorial_ui(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_primorial_nth_ui_, res, n);
}






/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_Mpfr_Arb_Hypgeom0F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_0f1_, res, a, x);
}


void Lib_Mpfr_Arb_Hypgeom0F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */


void Lib_Mpfr_Arb_BesselJ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_bessel_j, res, x, y);
}


void Lib_Mpfr_Arb_BesselY(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_bessel_y, res, x, y);
}


void Lib_Mpfr_Arb_BesselI(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i, res, x, y);
}


void Lib_Mpfr_Arb_BesselK(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k, res, x, y);
}


void Lib_Mpfr_Arb_BesselIScaled(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_Mpfr_Arb_BesselKScaled(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k_scaled, res, x, y);
}



/* Spherical Bessel functions  */





/* Airy functions  */



void Lib_Mpfr_Arb_AiryAi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_airy_ai, res, x);
}


void Lib_Mpfr_Arb_AiryAiPrime(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_airy_ai_prime, res, x);
}


void Lib_Mpfr_Arb_AiryBi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_airy_bi, res, x);
}


void Lib_Mpfr_Arb_AiryBiPrime(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_airy_bi_prime, res, x);
}




void Lib_Mpfr_Arb_AiryAiZero(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_airy_ai_zero, res, n);
}


void Lib_Mpfr_Arb_AiryAiPrimeZero(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_airy_ai_prime_zero, res, n);
}


void Lib_Mpfr_Arb_AiryBiZero(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_airy_bi_zero, res, n);
}


void Lib_Mpfr_Arb_AiryBiPrimeZero(MpfrPtr res, const int32_t n)
{
    Mpfr_Arb_Realfunc0Int32_Prec(arb_airy_bi_prime_zero, res, n);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


void Lib_Mpfr_Arb_Hypgeom1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_1f1_, res, a, b, z);
}


void Lib_Mpfr_Arb_Hypgeom1F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_Mpfr_Arb_HypgeomU(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_u, res, a, b, z);
}






/* Gamma function and related functions */


void Lib_Mpfr_Arb_Gamma(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_gamma, res, x);
}


void Lib_Mpfr_Arb_Rgamma(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_rgamma, res, x);
}


void Lib_Mpfr_Arb_Lgamma(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_lgamma, res, x);
}


void Lib_Mpfr_Arb_RisingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_rising, res, x, y);
}


void Lib_Mpfr_Arb_Beta(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_beta_, res, x, y);
}





/* Incomplete gamma functions */



void Lib_Mpfr_Arb_GammaUpper(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_gamma_upper_, res, x, y);
}


void Lib_Mpfr_Arb_GammaUpperR(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_gamma_upper_r, res, x, y);
}


void Lib_Mpfr_Arb_GammaLower(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_gamma_lower_, res, x, y);
}
//
//
//void Lib_Mpfr_Arb_GammaLowerR(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
//{
//    Mpfr_Arb_Realfunc2_Prec(arb_gamma_lower_r, res, x, y);
//}



void Lib_Mpfr_Arb_GammaPPrime(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_gamma_p_derivative, res, x, y);
}


void Lib_Mpfr_Arb_GammaP(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_gamma_p, res, x, y);
}


void Lib_Mpfr_Arb_GammaQ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_gamma_q, res, x, y);
}





/* Error function and related functions */


void Lib_Mpfr_Arb_Erf(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_erf, res, x);
}


void Lib_Mpfr_Arb_Erfc(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_erfc, res, x);
}


void Lib_Mpfr_Arb_ErfInv(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_erfinv, res, x);
}


void Lib_Mpfr_Arb_ErfcInv(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_erfcinv, res, x);
}


void Lib_Mpfr_Arb_Erfi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_erfi, res, x);
}


void Lib_Mpfr_Arb_FresnelC(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_fresnelc, res, x);
}


void Lib_Mpfr_Arb_FresnelS(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_fresnels, res, x);
}


void Lib_Mpfr_Arb_Ndens(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_ndens, res, x);
}


void Lib_Mpfr_Arb_Ndis(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_ndis, res, x);
}







/* Exponential integrals and related functions */



void Lib_Mpfr_Arb_ExpIntegralE(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_expint, res, x, y);
}



void Lib_Mpfr_Arb_ExpIntegralEi(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_ei, res, x);
}


void Lib_Mpfr_Arb_SinIntegral(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_si, res, x);
}


void Lib_Mpfr_Arb_CosIntegral(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_ci, res, x);
}


void Lib_Mpfr_Arb_SinhIntegral(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_shi, res, x);
}


void Lib_Mpfr_Arb_CoshIntegral(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_chi, res, x);
}


void Lib_Mpfr_Arb_LogIntegral(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_li_, res, x);
}


void Lib_Mpfr_Arb_LogIntegralOffset(MpfrPtr res, const MpfrPtr x)
{
    Mpfr_Arb_Realfunc1_Prec(arb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_Mpfr_Arb_HermiteH(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_hermite_h, res, x, y);
}


void Lib_Mpfr_Arb_LaguerreL(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_laguerre_l, res, a, b, z);
}




/* 1F1: Coulomb functions */


void Lib_Mpfr_Arb_CoulombF(MpfrPtr res, const MpfrPtr l, const MpfrPtr eta, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_Mpfr_Arb_CoulombG(MpfrPtr res, const MpfrPtr l, const MpfrPtr eta, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_g, res, l, eta, z);
}






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_Mpfr_Arb_Hypgeom2F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr c, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc4_Prec(arb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_Mpfr_Arb_Hypgeom2F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr c, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc4_Prec(arb_hypgeom_2f1r_, res, a, b, c, z);
}





/* 2F1: Orthogonal polynomials */


void Lib_Mpfr_Arb_ChebyshevT(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_Mpfr_Arb_ChebyshevU(MpfrPtr res, const MpfrPtr x, const MpfrPtr y)
{
    Mpfr_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_Mpfr_Arb_GegenbauerC(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_Mpfr_Arb_LegendreP(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_Mpfr_Arb_LegendrePv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_Mpfr_Arb_LegendreQ(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_Mpfr_Arb_LegendreQv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_legendre_qv_, res, a, b, z);
}


void Lib_Mpfr_Arb_JacobiP(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr c, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc4_Prec(arb_hypgeom_jacobi_p, res, a, b, c, z);
}





/* 2F1: Incomplete Beta Function */


void Lib_Mpfr_Arb_BetaLower(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_, res, a, b, z);
}


//void Lib_Mpfr_Arb_BetaLowerR(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
//{
//    Mpfr_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_r_, res, a, b, z);
//}



void Lib_Mpfr_Arb_Ibeta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_ibeta, res, a, b, z);
}


void Lib_Mpfr_Arb_Ibetac(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_ibetac, res, a, b, z);
}



void Lib_Mpfr_Arb_IbetaPrime(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc3_Prec(arb_ibeta_derivative, res, a, b, z);
}






/* Hypergeometric Function 1F2, overview */


void Lib_Mpfr_Arb_Hypgeom1F2(MpfrPtr res, const MpfrPtr a1, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc4_Prec(arb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_Mpfr_Arb_Hypgeom1F2r(MpfrPtr res, const MpfrPtr a1, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr z)
{
    Mpfr_Arb_Realfunc4_Prec(arb_hypgeom_1f2r_, res, a1, b1, b2, z);
}


















////////////////////////////////////////////////////////
////// Acb functions
////////////////////////////////////////////////////////


//
//
//void Lib_Mpfc_Acb_Exp(MpfcPtr res, const MpfcPtr x)
//{
//    Mpfc_Acb_Cplxfunc1_Prec(acb_exp, res, x);
//}
//
//void Lib_Mpfc_Acb_Sin(MpfcPtr res, const MpfcPtr x)
//{
//    Mpfc_Acb_Cplxfunc1_Prec(acb_sin, res, x);
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
//void Lib_Mpfc_Acb_Pow(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
//{
//    Mpfc_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
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
//void Lib_Mpfc_Acb_Hyp1f1(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
//{
//    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
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
//void Lib_Mpfc_Acb_Hyp2f1(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z)
//{
//    Mpfc_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
//}
//
//

/* ************************************* */








/* Roots and quadratic, cubic, and quartic equations */


void Lib_Mpfc_Acb_UnitRoot_ui(MpfcPtr res, const int32_t n)
{
    Mpfc_Acb_Cplxfunc0Int32_Prec(acb_unit_root_, res, n);
}


void Lib_Mpfc_Acb_Sqrt(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sqrt, res, x);
}


void Lib_Mpfc_Acb_Rsqrt(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_rsqrt, res, x);
}


void Lib_Mpfc_Acb_Cbrt(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_cbrt, res, x);
}


void Lib_Mpfc_Acb_Sqrt1pm1(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sqrt1pm1, res, x);
}


void Lib_Mpfc_Acb_Root_ui(MpfcPtr res, const MpfcPtr x, const int32_t n)
{
    Mpfc_Acb_Cplxfunc1Int32_Prec(acb_root_ui_, res, x, n);
}






/* Exponential and related functions */


void Lib_Mpfc_Acb_Exp(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_exp, res, x);
}


void Lib_Mpfc_Acb_Expj(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_expj_, res, x);
}


void Lib_Mpfc_Acb_Expjpi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_exp_pi_i, res, x);
}


void Lib_Mpfc_Acb_Expm1(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_expm1, res, x);
}


void Lib_Mpfc_Acb_Exp10(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_exp10_, res, x);
}


void Lib_Mpfc_Acb_Exp2(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_exp2_, res, x);
}


void Lib_Mpfc_Acb_Exp10m1(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_exp10m1_, res, x);
}


void Lib_Mpfc_Acb_Exp2m1(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_exp2m1_, res, x);
}


void Lib_Mpfc_Acb_ExpRel(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_exprel_, res, x);
}






/* Logarithms and related functions */



void Lib_Mpfc_Acb_Log(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_log, res, x);
}


void Lib_Mpfc_Acb_Logbase(MpfcPtr res, const MpfcPtr x, const MpfcPtr b)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_logbase_, res, x, b);
}


void Lib_Mpfc_Acb_Log1p(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_log1p, res, x);
}


void Lib_Mpfc_Acb_Log10(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_log10_, res, x);
}


void Lib_Mpfc_Acb_Log2(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_log2_, res, x);
}


void Lib_Mpfc_Acb_Log10p1(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_log10p1_, res, x);
}



void Lib_Mpfc_Acb_Log2p1(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_log2p1_, res, x);
}




void Lib_Mpfc_Acb_LambertW_ui(MpfcPtr res, const MpfcPtr x, const int32_t n)
{
    Mpfc_Acb_Cplxfunc1Int32_Prec(acb_lambertw_ui_, res, x, n);
}







/* Power functions */


void Lib_Mpfc_Acb_Square(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sqr, res, x);
}


void Lib_Mpfc_Acb_Cube(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_cube, res, x);
}


void Lib_Mpfc_Acb_Pow_si(MpfcPtr res, const MpfcPtr x, const int32_t n)
{
    Mpfc_Acb_Cplxfunc1Int32_Prec(acb_pow_si_, res, x, n);
}



void Lib_Mpfc_Acb_Hypot(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypot_, res, x, y);
}


void Lib_Mpfc_Acb_Pow(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
}


void Lib_Mpfc_Acb_Powm1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_powm1_, res, x, y);
}


void Lib_Mpfc_Acb_Pow1p(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_pow1p_, res, x, y);
}


void Lib_Mpfc_Acb_Pow1pm1(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_pow1pm1_, res, x, y);
}







/* Trigonometric and related functions */



void Lib_Mpfc_Acb_Sin(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sin, res, x);
}


void Lib_Mpfc_Acb_Cos(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_cos, res, x);
}


void Lib_Mpfc_Acb_Tan(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_tan, res, x);
}



void Lib_Mpfc_Acb_Csc(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_csc, res, x);
}


void Lib_Mpfc_Acb_Sec(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sec, res, x);
}


void Lib_Mpfc_Acb_Cot(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_cot, res, x);
}





/* Hyperbolic functions */


void Lib_Mpfc_Acb_Sinh(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sinh, res, x);
}


void Lib_Mpfc_Acb_Cosh(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_cosh, res, x);
}


void Lib_Mpfc_Acb_Tanh(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_tanh, res, x);
}



void Lib_Mpfc_Acb_Csch(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_csch, res, x);
}


void Lib_Mpfc_Acb_Sech(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sech, res, x);
}


void Lib_Mpfc_Acb_Coth(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_coth, res, x);
}



void Lib_Mpfc_Acb_Sinc(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sinc, res, x);
}


void Lib_Mpfc_Acb_SincPi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sinc_pi, res, x);
}



void Lib_Mpfc_Acb_SinPi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sin_pi, res, x);
}


void Lib_Mpfc_Acb_CosPi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_cos_pi, res, x);
}


void Lib_Mpfc_Acb_TanPi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_tan_pi, res, x);
}


void Lib_Mpfc_Acb_CotPi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_cot_pi, res, x);
}


void Lib_Mpfc_Acb_CscPi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_csc_pi, res, x);
}


void Lib_Mpfc_Acb_SecPi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_sec_pi_, res, x);
}









/* Inverse trigonometric functions */


void Lib_Mpfc_Acb_Asin(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_asin, res, x);
}


void Lib_Mpfc_Acb_Acos(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_acos, res, x);
}


void Lib_Mpfc_Acb_Atan(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_atan, res, x);
}



void Lib_Mpfc_Acb_Acsc(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_acsc, res, x);
}


void Lib_Mpfc_Acb_Asec(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_asec, res, x);
}


void Lib_Mpfc_Acb_Acot(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_Mpfc_Acb_Asinh(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_asinh, res, x);
}


void Lib_Mpfc_Acb_Acosh(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_acosh, res, x);
}


void Lib_Mpfc_Acb_Atanh(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_atanh, res, x);
}



void Lib_Mpfc_Acb_Acsch(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_acsch, res, x);
}


void Lib_Mpfc_Acb_Asech(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_asech, res, x);
}


void Lib_Mpfc_Acb_Acoth(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_acoth, res, x);
}









/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_Mpfc_Acb_MEllipticK(MpfcPtr res, const MpfcPtr m)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_elliptic_k, res, m);
}


void Lib_Mpfc_Acb_MEllipticE(MpfcPtr res, const MpfcPtr m)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_elliptic_e, res, m);
}


void Lib_Mpfc_Acb_MEllipticPi(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_pi, res, phi, m);

}


void Lib_Mpfc_Acb_MEllipticF(MpfcPtr res, const MpfcPtr phi, const MpfcPtr m)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_f_, res, phi, m);

}


void Lib_Mpfc_Acb_MEllipticEInc(MpfcPtr res, const MpfcPtr n, const MpfcPtr m)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_, res, n, m);
}


void Lib_Mpfc_Acb_MEllipticPiInc(MpfcPtr res, const MpfcPtr n, const MpfcPtr phi, const MpfcPtr m)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_, res, n, phi, m);
}







/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_Mpfc_Acb_EllipticK(MpfcPtr res, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_elliptic_k_k_, res, k);
}


void Lib_Mpfc_Acb_EllipticE(MpfcPtr res, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_elliptic_e_k_, res, k);
}


void Lib_Mpfc_Acb_EllipticPi(MpfcPtr res, const MpfcPtr phi, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_pi_k_, res, phi, k);

}


void Lib_Mpfc_Acb_EllipticF(MpfcPtr res, const MpfcPtr phi, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_f_k_, res, phi, k);

}


void Lib_Mpfc_Acb_EllipticEInc(MpfcPtr res, const MpfcPtr n, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_k_, res, n, k);
}


void Lib_Mpfc_Acb_EllipticPiInc(MpfcPtr res, const MpfcPtr n, const MpfcPtr phi, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_k_, res, n, phi, k);
}



void Lib_Mpfc_Acb_Agm(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */

void Lib_Mpfc_Acb_Elliptic_RC(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_rc_, res, x, y);
}



void Lib_Mpfc_Acb_Elliptic_RF(MpfcPtr res, const MpfcPtr x, const MpfcPtr y, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_elliptic_rf_, res, x, y, z);
}


void Lib_Mpfc_Acb_Elliptic_RG(MpfcPtr res, const MpfcPtr x, const MpfcPtr y, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_elliptic_rg_, res, x, y, z);
}


void Lib_Mpfc_Acb_Elliptic_RD(MpfcPtr res, const MpfcPtr x, const MpfcPtr y, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_elliptic_rd_, res, x, y, z);
}


void Lib_Mpfc_Acb_Elliptic_RJ(MpfcPtr res, const MpfcPtr x, const MpfcPtr y, const MpfcPtr z, const MpfcPtr w)
{
    Mpfc_Acb_Cplxfunc4_Prec(acb_elliptic_rj_, res, x, y, z, w);
}






/* Jacobi theta functions */


void Lib_Mpfc_Acb_Theta1Q(MpfcPtr res, const MpfcPtr z, const MpfcPtr q)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_theta1q, res, z, q);
}


void Lib_Mpfc_Acb_Theta2Q(MpfcPtr res, const MpfcPtr z, const MpfcPtr q)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_theta2q, res, z, q);
}


void Lib_Mpfc_Acb_Theta3Q(MpfcPtr res, const MpfcPtr z, const MpfcPtr q)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_theta3q, res, z, q);
}


void Lib_Mpfc_Acb_Theta4Q(MpfcPtr res, const MpfcPtr z, const MpfcPtr q)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_theta4q, res, z, q);
}



void Lib_Mpfc_Acb_Theta1Tau(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_theta1, res, z, tau);
}


void Lib_Mpfc_Acb_Theta2Tau(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_theta2, res, z, tau);
}


void Lib_Mpfc_Acb_Theta3Tau(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_theta3, res, z, tau);
}


void Lib_Mpfc_Acb_Theta4Tau(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_theta4, res, z, tau);
}







/* Jacobi elliptic functions */


void Lib_Mpfc_Acb_QfromK(MpfcPtr res, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_qfromk, res, k);
}


void Lib_Mpfc_Acb_TfromUQ(MpfcPtr res, const MpfcPtr u, const MpfcPtr q)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_tfrom_u_q, res, u, q);
}


void Lib_Mpfc_Acb_SnTQ(MpfcPtr res, const MpfcPtr t, const MpfcPtr q)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_sn_t_q, res, t, q);
}


void Lib_Mpfc_Acb_CnTQ(MpfcPtr res, const MpfcPtr t, const MpfcPtr q)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_cn_t_q, res, t, q);
}


void Lib_Mpfc_Acb_DnTQ(MpfcPtr res, const MpfcPtr t, const MpfcPtr q)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_dn_t_q, res, t, q);
}


void Lib_Mpfc_Acb_JacobiSN(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_sn, res, u, k);
}


void Lib_Mpfc_Acb_JacobiCN(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_cn, res, u, k);
}


void Lib_Mpfc_Acb_JacobiDN(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_dn, res, u, k);
}





void Lib_Mpfc_Acb_JacobiNS(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_ns, res, u, k);
}


void Lib_Mpfc_Acb_JacobiNC(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_nc, res, u, k);
}


void Lib_Mpfc_Acb_JacobiND(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_nd, res, u, k);
}




void Lib_Mpfc_Acb_JacobiSC(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_sc, res, u, k);
}


void Lib_Mpfc_Acb_JacobiSD(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_sd, res, u, k);
}




void Lib_Mpfc_Acb_JacobiDC(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_dc, res, u, k);
}


void Lib_Mpfc_Acb_JacobiDS(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_ds, res, u, k);
}




void Lib_Mpfc_Acb_JacobiCS(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_cs, res, u, k);
}


void Lib_Mpfc_Acb_JacobiCD(MpfcPtr res, const MpfcPtr u, const MpfcPtr k)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_jacobi_cd, res, u, k);
}







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


void Lib_Mpfc_Acb_WeierstrassP(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_p, res, z, tau);
}


void Lib_Mpfc_Acb_WeierstrassPInv(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_inv_p, res, z, tau);
}


void Lib_Mpfc_Acb_WeierstrassPZeta(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_zeta, res, z, tau);
}


void Lib_Mpfc_Acb_WeierstrassPSigma(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_elliptic_sigma, res, z, tau);
}



void Lib_Mpfc_Acb_WeierstrassPPrime(MpfcPtr res, const MpfcPtr z, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_wp_prime, res, z, tau);
}



void Lib_Mpfc_Acb_EllipticInvariantG2(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g2, res, tau);
}


void Lib_Mpfc_Acb_EllipticInvariantG3(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g3, res, tau);
}


void Lib_Mpfc_Acb_EllipticRootE1(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e1, res, tau);
}


void Lib_Mpfc_Acb_EllipticRootE2(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e2, res, tau);
}


void Lib_Mpfc_Acb_EllipticRootE3(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e3, res, tau);
}



void Lib_Mpfc_Acb_DedekindEta(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_modular_eta, res, tau);
}


void Lib_Mpfc_Acb_KleinJ(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_modular_j, res, tau);
}


void Lib_Mpfc_Acb_ModularLambda(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_modular_lambda, res, tau);
}


void Lib_Mpfc_Acb_ModularDelta(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_modular_delta, res, tau);
}




/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */






/* Lerch’s transcendent: overview */


void Lib_Mpfc_Acb_LerchPhi(MpfcPtr res, const MpfcPtr z, const MpfcPtr s, const MpfcPtr a)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_dirichlet_lerch_phi, res, z, s, a);
}


void Lib_Mpfc_Acb_LerchZeta(MpfcPtr res, const MpfcPtr lambda1, const MpfcPtr alpha, const MpfcPtr s)
{
    Mpfc_Acb_Cplxfunc3_Prec(_acb_lerch_zeta, res, lambda1, alpha, s);
}


/* Polygamma functions */


void Lib_Mpfc_Acb_Polygamma(MpfcPtr res, const MpfcPtr s, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_polygamma, res, s, z);
}


void Lib_Mpfc_Acb_Trigamma(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_trigamma, res, x);
}


void Lib_Mpfc_Acb_Digamma(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_Mpfc_Acb_Polylog(MpfcPtr res, const MpfcPtr s, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_polylog, res, s, z);
}


void Lib_Mpfc_Acb_Trilog(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_trilog, res, x);
}


void Lib_Mpfc_Acb_Dilog(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_dilog, res, x);
}



void Lib_Mpfc_Acb_ClausenSin(MpfcPtr res, const MpfcPtr s, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_clausen_sin, res, s, z);
}


void Lib_Mpfc_Acb_ClausenCos(MpfcPtr res, const MpfcPtr s, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_clausen_cos, res, s, z);
}


void Lib_Mpfc_Acb_Clausen2(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_clausen2, res, x);
}


void Lib_Mpfc_Acb_BoseEinstein(MpfcPtr res, const MpfcPtr s, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_bose_einstein, res, s, z);
}


void Lib_Mpfc_Acb_FermiDirac(MpfcPtr res, const MpfcPtr s, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_fermi_dirac, res, s, z);
}


void Lib_Mpfc_Acb_LegendreChi(MpfcPtr res, const MpfcPtr s, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_legendre_chi, res, s, z);
}


void Lib_Mpfc_Acb_InverseTanIntegral(MpfcPtr res, const MpfcPtr s, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_ti, res, s, z);
}





/* Hurwitz zeta function and related functions */




void Lib_Mpfc_Acb_HurwitzZeta(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hurwitz_zeta, res, x, y);
}


void Lib_Mpfc_Acb_Stieltjes_ui(MpfcPtr res, const MpfcPtr x, const int32_t n)
{
    Mpfc_Acb_Cplxfunc1Int32_Prec(acb_stieltjes_ui_, res, x, n);
}


void Lib_Mpfc_Acb_BernoulliPoly_ui(MpfcPtr res, const MpfcPtr x, const int32_t n)
{
    Mpfc_Acb_Cplxfunc1Int32_Prec(acb_bernoulli_poly_ui_, res, x, n);
}



void Lib_Mpfc_Acb_Harmonic(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_harmonic, res, x);
}


void Lib_Mpfc_Acb_Harmonic2(MpfcPtr res, const MpfcPtr z, const MpfcPtr r)
{
    Mpfc_Acb_Cplxfunc2_Prec(_acb_harmonic2, res, z, r);
}


void Lib_Mpfc_Acb_EulerPoly_ui(MpfcPtr res, const MpfcPtr x, const int32_t n)
{
    Mpfc_Acb_Cplxfunc1Int32_Prec(acb_euler_poly_ui_, res, x, n);
}


void Lib_Mpfc_Acb_Hyperfactorial(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_hyperfac, res, x);
}


void Lib_Mpfc_Acb_Superfactorial(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_superfac, res, x);
}


void Lib_Mpfc_Acb_BarnesG(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_barnes_g, res, x);
}


void Lib_Mpfc_Acb_LogBarnesG(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */


void Lib_Mpfc_Acb_Zeta(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_zeta, res, x);
}


void Lib_Mpfc_Acb_Zetam1(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_zetam1, res, x);
}


void Lib_Mpfc_Acb_ZetaZero_ui(MpfcPtr res, const int32_t n)
{
    Mpfc_Acb_Cplxfunc0Int32_Prec(acb_dirichlet_zeta_zero_ui_, res, n);
}


void Lib_Mpfc_Acb_DirichletXi(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_dirichlet_xi, res, tau);
}


void Lib_Mpfc_Acb_DirichletEta(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_dirichlet_eta, res, tau);
}


void Lib_Mpfc_Acb_DirichletEtam1(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_dirichlet_etam1, res, x);
}


void Lib_Mpfc_Acb_DirichletBeta(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_dirichlet_beta, res, x);
}


void Lib_Mpfc_Acb_DirichletLambda(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(_acb_dirichlet_lambda, res, x);
}



/* Riemann-Siegel Z-function */
void Lib_Mpfc_Acb_HardyZ(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_z_, res, tau);
}

/* rstheta(z) in amath */
void Lib_Mpfc_Acb_HardyTheta(MpfcPtr res, const MpfcPtr tau)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_theta_, res, tau);
}









/* Additional numbertheoretic functions */




/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_Mpfc_Acb_Hypgeom0F1(MpfcPtr res, const MpfcPtr a, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_, res, a, x);
}


void Lib_Mpfc_Acb_Hypgeom0F1r(MpfcPtr res, const MpfcPtr a, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */



void Lib_Mpfc_Acb_BesselJ(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_j, res, x, y);
}


void Lib_Mpfc_Acb_BesselY(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_y, res, x, y);
}


void Lib_Mpfc_Acb_BesselI(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i, res, x, y);
}


void Lib_Mpfc_Acb_BesselK(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k, res, x, y);
}


void Lib_Mpfc_Acb_BesselIScaled(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_Mpfc_Acb_BesselKScaled(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */




/* Airy functions  */


void Lib_Mpfc_Acb_AiryAi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_airy_ai, res, x);
}


void Lib_Mpfc_Acb_AiryAiPrime(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_airy_ai_prime, res, x);
}


void Lib_Mpfc_Acb_AiryBi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_airy_bi, res, x);
}


void Lib_Mpfc_Acb_AiryBiPrime(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_airy_bi_prime, res, x);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */



void Lib_Mpfc_Acb_Hypgeom1F1(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
}


void Lib_Mpfc_Acb_Hypgeom1F1r(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_Mpfc_Acb_HypgeomU(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_u, res, a, b, z);
}





/* Gamma function and related functions */


void Lib_Mpfc_Acb_Gamma(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_gamma, res, x);
}


void Lib_Mpfc_Acb_Rgamma(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_rgamma, res, x);
}


void Lib_Mpfc_Acb_Lgamma(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_lgamma, res, x);
}


void Lib_Mpfc_Acb_RisingFactorial(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_rising, res, x, y);
}


void Lib_Mpfc_Acb_Beta(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_beta_, res, x, y);
}






/* Incomplete gamma functions */


void Lib_Mpfc_Acb_GammaUpper(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_gamma_upper_, res, x, y);
}



void Lib_Mpfc_Acb_GammaLower(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_gamma_lower_, res, x, y);
}



void Lib_Mpfc_Acb_GammaPPrime(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_gamma_p_derivative, res, x, y);
}


void Lib_Mpfc_Acb_GammaP(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_gamma_p, res, x, y);
}


void Lib_Mpfc_Acb_GammaQ(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_gamma_q, res, x, y);
}







/* Error function and related functions */


void Lib_Mpfc_Acb_Erf(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_erf, res, x);
}


void Lib_Mpfc_Acb_Erfc(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_erfc, res, x);
}


void Lib_Mpfc_Acb_Erfi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_erfi, res, x);
}



void Lib_Mpfc_Acb_FresnelC(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_fresnelc, res, x);
}


void Lib_Mpfc_Acb_FresnelS(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_fresnels, res, x);
}


void Lib_Mpfc_Acb_Ndens(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_ndens, res, x);
}


void Lib_Mpfc_Acb_Ndis(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_ndis, res, x);
}






/* Exponential integrals and related functions */


void Lib_Mpfc_Acb_ExpIntegralE(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_expint, res, x, y);
}



void Lib_Mpfc_Acb_ExpIntegralEi(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_ei, res, x);
}


void Lib_Mpfc_Acb_SinIntegral(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_si, res, x);
}


void Lib_Mpfc_Acb_CosIntegral(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_ci, res, x);
}


void Lib_Mpfc_Acb_SinhIntegral(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_shi, res, x);
}


void Lib_Mpfc_Acb_CoshIntegral(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_chi, res, x);
}


void Lib_Mpfc_Acb_LogIntegral(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_li_, res, x);
}


void Lib_Mpfc_Acb_LogIntegralOffset(MpfcPtr res, const MpfcPtr x)
{
    Mpfc_Acb_Cplxfunc1_Prec(acb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_Mpfc_Acb_HermiteH(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_hermite_h, res, x, y);
}


void Lib_Mpfc_Acb_LaguerreL(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */



void Lib_Mpfc_Acb_CoulombF(MpfcPtr res, const MpfcPtr l, const MpfcPtr eta, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_Mpfc_Acb_CoulombG(MpfcPtr res, const MpfcPtr l, const MpfcPtr eta, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_g, res, l, eta, z);
}


void Lib_Mpfc_Acb_CoulombHpos(MpfcPtr res, const MpfcPtr l, const MpfcPtr eta, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hpos, res, l, eta, z);
}


void Lib_Mpfc_Acb_CoulombHneg(MpfcPtr res, const MpfcPtr l, const MpfcPtr eta, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hneg, res, l, eta, z);
}







/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_Mpfc_Acb_Hypgeom2F1(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_Mpfc_Acb_Hypgeom2F1r(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1r_, res, a, b, c, z);
}



/* 2F1: Orthogonal polynomials */


void Lib_Mpfc_Acb_ChebyshevT(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_Mpfc_Acb_ChebyshevU(MpfcPtr res, const MpfcPtr x, const MpfcPtr y)
{
    Mpfc_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_Mpfc_Acb_GegenbauerC(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_Mpfc_Acb_LegendreP(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_Mpfc_Acb_LegendrePv(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_Mpfc_Acb_LegendreQ(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_Mpfc_Acb_LegendreQv(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_qv_, res, a, b, z);
}



void Lib_Mpfc_Acb_JacobiP(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr c, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc4_Prec(acb_hypgeom_jacobi_p, res, a, b, c, z);
}


void Lib_Mpfc_Acb_SphericalY(MpfcPtr res, const MpfcPtr n, const MpfcPtr m, const MpfcPtr theta, const MpfcPtr phi)
{
    Mpfc_Acb_Cplxfunc4_Prec(_acb_hypgeom_spherical_y, res, n, m, theta, phi);
}





/* 2F1: Incomplete Beta Function */


void Lib_Mpfc_Acb_BetaLower(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_hypgeom_beta_lower_, res, a, b, z);
}




void Lib_Mpfc_Acb_Ibeta(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_ibeta, res, a, b, z);
}


void Lib_Mpfc_Acb_Ibetac(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_ibetac, res, a, b, z);
}



void Lib_Mpfc_Acb_IbetaPrime(MpfcPtr res, const MpfcPtr a, const MpfcPtr b, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc3_Prec(acb_ibeta_derivative, res, a, b, z);
}



/* Hypergeometric Function 1F2, overview */



void Lib_Mpfc_Acb_Hypgeom1F2(MpfcPtr res, const MpfcPtr a1, const MpfcPtr b1, const MpfcPtr b2, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_Mpfc_Acb_Hypgeom1F2r(MpfcPtr res, const MpfcPtr a1, const MpfcPtr b1, const MpfcPtr b2, const MpfcPtr z)
{
    Mpfc_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2r_, res, a1, b1, b2, z);
}








//*********************** Boost Special functions , Mpfr **********************************






void Lib_Mpfr_BernoulliB2n(MpfrPtr res, const int n, int const dps)
{
    LibMpfr_BernoulliB2n(res, n, dps);
}


void Lib_Mpfr_TangentT2n(MpfrPtr res, const int n, int const dps)
{
    LibMpfr_TangentT2n(res, n, dps);
}


void Lib_Mpfr_Sqrt1pm1_Boost(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Sqrt1pm1(res, x, dps);
}


void Lib_Mpfr_SinPi_Boost(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_SinPi(res, x, dps);
}


void Lib_Mpfr_CosPi_Boost(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_CosPi(res, x, dps);
}


void Lib_Mpfr_SincPi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_SincPi(res, x, dps);
}


void Lib_Mpfr_SinhcPi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_SinhcPi(res, x, dps);
}


void Lib_Mpfr_Tgamma_(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Tgamma_(res, x, dps);
}


void Lib_Mpfr_Tgamma1pm1(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Tgamma1pm1(res, x, dps);
}







void Lib_Mpfr_Lgamma_(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Lgamma_(res, x, dps);
}



void Lib_Mpfr_Digamma(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Digamma(res, x, dps);
}



void Lib_Mpfr_Trigamma(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Trigamma(res, x, dps);
}



void Lib_Mpfr_Factorial(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Factorial(res, x, dps);
}



void Lib_Mpfr_DoubleFactorial(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_DoubleFactorial(res, x, dps);
}





void Lib_Mpfr_Erf_(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Erf_(res, x, dps);
}



void Lib_Mpfr_Erfc_(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Erfc_(res, x, dps);
}



void Lib_Mpfr_Erf_inv(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Erf_inv(res, x, dps);
}



void Lib_Mpfr_Erfc_inv(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Erfc_inv(res, x, dps);
}



void Lib_Mpfr_AiryAi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_AiryAi(res, x, dps);
}



void Lib_Mpfr_AiryBi(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_AiryBi(res, x, dps);
}



void Lib_Mpfr_AiryAiPrime(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_AiryAiPrime(res, x, dps);
}



void Lib_Mpfr_AiryBiPrime(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_AiryBiPrime(res, x, dps);
}



void Lib_Mpfr_Aizero(MpfrPtr res, const int n, int const dps)
{
    LibMpfr_Aizero(res, n, dps);
}



void Lib_Mpfr_Bizero(MpfrPtr res, const int n, int const dps)
{
    LibMpfr_Bizero(res, n, dps);
}



void Lib_Mpfr_Ellint_1_K(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Ellint_1_K(res, x, dps);
}



void Lib_Mpfr_Ellint_2_K(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Ellint_2_K(res, x, dps);
}



void Lib_Mpfr_Zeta(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Zeta(res, x, dps);
}



void Lib_Mpfr_Ei(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_Ei(res, x, dps);
}



void Lib_Mpfr_LambertW0(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_LambertW0(res, x, dps);
}


void Lib_Mpfr_LambertWm1(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_LambertWm1(res, x, dps);
}



void Lib_Mpfr_LambertW0Prime(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_LambertW0Prime(res, x, dps);
}


void Lib_Mpfr_LambertWm1Prime(MpfrPtr res, const MpfrPtr x, int const dps)
{
    LibMpfr_LambertWm1Prime(res, x, dps);
}




/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




void Lib_Mpfr_Agm(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    LibMpfr_Agm(res, a, b, dps);
}




void Lib_Mpfr_Powm1_Boost(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    LibMpfr_Powm1(res, a, b, dps);
}



void Lib_Mpfr_TgammaRatio(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    LibMpfr_TgammaRatio(res, a, b, dps);
}



void Lib_Mpfr_TgammaDeltaRatio(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    LibMpfr_TgammaDeltaRatio(res, a, b, dps);
}



void Lib_Mpfr_Binomial(MpfrPtr res, const MpfrPtr n, const MpfrPtr k, int const dps)
{
    LibMpfr_Binomial(res, n, k, dps);
}

void Lib_Mpfr_RisingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr n, int const dps)
{
    LibMpfr_RisingFactorial(res, x, n, dps);
}




void Lib_Mpfr_FallingFactorial(MpfrPtr res, const MpfrPtr x, const MpfrPtr n, int const dps)
{
    LibMpfr_FallingFactorial(res, x, n, dps);
}




void Lib_Mpfr_BesselJ(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    LibMpfr_BesselJ(res, v, x, dps);
}



void Lib_Mpfr_BesselY(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    LibMpfr_BesselY(res, v, x, dps);
}



void Lib_Mpfr_BesselI(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    LibMpfr_BesselI(res, v, x, dps);
}



void Lib_Mpfr_BesselK(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    LibMpfr_BesselK(res, v, x, dps);
}



void Lib_Mpfr_SphBessel(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps)
{
    LibMpfr_SphBessel(res, v, x, dps);
}



void Lib_Mpfr_SphNeumann(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps)
{
    LibMpfr_SphNeumann(res, v, x, dps);
}





void Lib_Mpfr_BesselJPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    LibMpfr_BesselJPrime(res, v, x, dps);
}



void Lib_Mpfr_BesselYPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    LibMpfr_BesselYPrime(res, v, x, dps);
}



void Lib_Mpfr_BesselIPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    LibMpfr_BesselIPrime(res, v, x, dps);
}



void Lib_Mpfr_BesselKPrime(MpfrPtr res, const MpfrPtr v, const MpfrPtr x, int const dps)
{
    LibMpfr_BesselKPrime(res, v, x, dps);
}



void Lib_Mpfr_SphBesselPrime(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps)
{
    LibMpfr_SphBesselPrime(res, v, x, dps);
}



void Lib_Mpfr_SphNeumannPrime(MpfrPtr res, const unsigned v, const MpfrPtr x, int const dps)
{
    LibMpfr_SphNeumannPrime(res, v, x, dps);
}





void Lib_Mpfr_BesselJZero(MpfrPtr res, const MpfrPtr v, const int m, int const dps)
{
    LibMpfr_BesselJZero(res, v, m, dps);
}



void Lib_Mpfr_BesselYZero(MpfrPtr res, const MpfrPtr v, const int m, int const dps)
{
    LibMpfr_BesselYZero(res, v, m, dps);
}





void Lib_Mpfr_GammaP(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    LibMpfr_GammaP(res, a, x, dps);
}


void Lib_Mpfr_GammaQ(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    LibMpfr_GammaQ(res, a, x, dps);
}


void Lib_Mpfr_TgammaLower(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    LibMpfr_TgammaLower(res, a, x, dps);
}


void Lib_Mpfr_TgammaUpper(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    LibMpfr_TgammaUpper(res, a, x, dps);
}




void Lib_Mpfr_GammaPInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr p, int const dps)
{
    LibMpfr_GammaPInv(res, a, p, dps);
}


void Lib_Mpfr_GammaQInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr q, int const dps)
{
    LibMpfr_GammaQInv(res, a, q, dps);
}


void Lib_Mpfr_GammaPInva(MpfrPtr res, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    LibMpfr_GammaPInva(res, x, p, dps);
}


void Lib_Mpfr_GammaQInva(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    LibMpfr_GammaQInva(res, x, q, dps);
}



void Lib_Mpfr_GammaPDerivative(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, int const dps)
{
    LibMpfr_GammaPDerivative(res, a, x, dps);
}


void Lib_Mpfr_Beta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int const dps)
{
    LibMpfr_Beta(res, a, b, dps);
}









void Lib_Mpfr_LegendreP(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    LibMpfr_LegendreP(res, n, x, dps);
}



void Lib_Mpfr_LegendreQ(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    LibMpfr_LegendreQ(res, n, x, dps);
}



void Lib_Mpfr_Laguerre(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    LibMpfr_Laguerre(res, n, x, dps);
}



void Lib_Mpfr_Hermite(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    LibMpfr_Hermite(res, n, x, dps);
}



void Lib_Mpfr_ChebyshevT(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    LibMpfr_ChebyshevT(res, n, x, dps);
}


void Lib_Mpfr_ChebyshevU(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    LibMpfr_ChebyshevU(res, n, x, dps);
}



void Lib_Mpfr_Polygamma(MpfrPtr res, int n, const MpfrPtr x, int const dps)
{
    LibMpfr_Polygamma(res, n, x, dps);
}





void Lib_Mpfr_EllintRC(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, int const dps)
{
    LibMpfr_EllintRC(res, x, y, dps);
}


void Lib_Mpfr_Ellint1F(MpfrPtr res, const MpfrPtr k, const MpfrPtr phi, int const dps)
{
    LibMpfr_Ellint1F(res, k, phi, dps);
}


void Lib_Mpfr_Ellint2F(MpfrPtr res, const MpfrPtr k, const MpfrPtr phi, int const dps)
{
    LibMpfr_Ellint2F(res, k, phi, dps);
}


void Lib_Mpfr_Ellint3K(MpfrPtr res, const MpfrPtr k, const MpfrPtr n, int const dps)
{
    LibMpfr_Ellint3K(res, k, n, dps);
}




void Lib_Mpfr_JacobiCD(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiCD(res, k, u, dps);
}


void Lib_Mpfr_JacobiCN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiCN(res, k, u, dps);
}


void Lib_Mpfr_JacobiCS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiCS(res, k, u, dps);
}


void Lib_Mpfr_JacobiDC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiDC(res, k, u, dps);
}


void Lib_Mpfr_JacobiDN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiDN(res, k, u, dps);
}


void Lib_Mpfr_JacobiDS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiDS(res, k, u, dps);
}


void Lib_Mpfr_JacobiNC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiNC(res, k, u, dps);
}


void Lib_Mpfr_JacobiND(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiND(res, k, u, dps);
}


void Lib_Mpfr_JacobiNS(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiNS(res, k, u, dps);
}


void Lib_Mpfr_JacobiSC(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiSC(res, k, u, dps);
}


void Lib_Mpfr_JacobiSD(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiSD(res, k, u, dps);
}


void Lib_Mpfr_JacobiSN(MpfrPtr res, const MpfrPtr k, const MpfrPtr u, int const dps)
{
    LibMpfr_JacobiSN(res, k, u, dps);
}



void Lib_Mpfr_expint(MpfrPtr res, const unsigned n, const MpfrPtr x, int const dps)
{
    LibMpfr_expint(res, n, x, dps);
}




void Lib_Mpfr_OwenT(MpfrPtr res, const MpfrPtr h, const MpfrPtr a, int const dps)
{
    LibMpfr_OwenT(res, h, a, dps);
}





void Lib_Mpfr_IBeta(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_IBeta(res, a, b, x, dps);
}


void Lib_Mpfr_IBetac(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_IBetac(res, a, b, x, dps);
}


void Lib_Mpfr_IBetaNonNormalized(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_IBetaNonNormalized(res, a, b, x, dps);
}


void Lib_Mpfr_IBetacNonNormalized(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_IBetacNonNormalized(res, a, b, x, dps);
}


void Lib_Mpfr_IBetaInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr p, int const dps)
{
    LibMpfr_IBetaInv(res, a, b, p, dps);
}


void Lib_Mpfr_IBetacInv(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr q, int const dps)
{
    LibMpfr_IBetacInv(res, a, b, q, dps);
}


void Lib_Mpfr_IBetaInva(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    LibMpfr_IBetaInva(res, b, x, p, dps);
}


void Lib_Mpfr_IBetacInva(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    LibMpfr_IBetacInva(res, b, x, q, dps);
}


void Lib_Mpfr_IBetaInvb(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, const MpfrPtr p, int const dps)
{
    LibMpfr_IBetaInvb(res, a, x, p, dps);
}


void Lib_Mpfr_IBetacInvb(MpfrPtr res, const MpfrPtr a, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    LibMpfr_IBetacInvb(res, a, x, q, dps);
}


void Lib_Mpfr_IBetaDerivative(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_IBetaDerivative(res, a, b, x, dps);
}




void Lib_Mpfr_LegendrePM(MpfrPtr res, const int n, const int m, const MpfrPtr x, int const dps)
{
    LibMpfr_LegendrePM(res, n, m, x, dps);
}



void Lib_Mpfr_LaguerreM(MpfrPtr res, const int n, const int m, const MpfrPtr x, int const dps)
{
    LibMpfr_LaguerreM(res, n, m, x, dps);
}





void Lib_Mpfr_EllipticRF(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps)
{
    LibMpfr_EllipticRF(res, x, y, z, dps);
}



void Lib_Mpfr_EllipticRD(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps)
{
    LibMpfr_EllipticRD(res, x, y, z, dps);
}



void Lib_Mpfr_EllipticRG(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, int const dps)
{
    LibMpfr_EllipticRG(res, x, y, z, dps);
}



void Lib_Mpfr_Ellint3F(MpfrPtr res, const MpfrPtr k, const MpfrPtr n, const MpfrPtr phi, int const dps)
{
    LibMpfr_Ellint3F(res, k, n, phi, dps);
}




void Lib_Mpfr_Gegenbauer(MpfrPtr res, const int n, const MpfrPtr lambda1, const MpfrPtr x, int const dps)
{
    LibMpfr_Gegenbauer(res, n, lambda1, x, dps);
}



void Lib_Mpfr_Jacobi(MpfrPtr res, const int n, const MpfrPtr alpha, const MpfrPtr beta, const MpfrPtr x, int const dps)
{
    LibMpfr_Jacobi(res, n, alpha, beta, x, dps);
}




void Lib_Mpfr_SphericalHarmonicR(MpfrPtr res, const int n, const int m, const MpfrPtr theta, const MpfrPtr phi, int const dps)
{
    LibMpfr_SphericalHarmonicR(res, n, m, theta, phi, dps);
}


void Lib_Mpfr_SphericalHarmonicI(MpfrPtr res, const int n, const int m, const MpfrPtr theta, const MpfrPtr phi, int const dps)
{
    LibMpfr_SphericalHarmonicI(res, n, m, theta, phi, dps);
}


void Lib_Mpfr_EllipticRJ(MpfrPtr res, const MpfrPtr x, const MpfrPtr y, const MpfrPtr z, const MpfrPtr p, int const dps)
{
    LibMpfr_EllipticRJ(res, x, y, z, p, dps);
}


// Hypergeometric and Theta Functions




void Lib_Mpfr_Hypergeo0F1(MpfrPtr res, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_Hypergeo0F1(res, b, x, dps);
}



void Lib_Mpfr_Hypergeo1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_Hypergeo1F1(res, a, b, x, dps);
}



void Lib_Mpfr_Hypergeo1F1r(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_Hypergeo1F1r(res, a, b, x, dps);
}



void Lib_Mpfr_LogHypergeo1F1(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, const MpfrPtr x, int const dps)
{
    LibMpfr_LogHypergeo1F1(res, a, b, x, dps);
}




//
//
//void Lib_Mpfr_Hypergeo1F2(MpfrPtr res, const MpfrPtr a1, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr x, int const dps, unsigned digits10, double timeout)
//{
//    LibMpfr_Hypergeo1F2(res, a1, b1, b2, x, dps, digits10, timeout);
//}
//
//
//
//void Lib_Mpfr_Hypergeo2F1(MpfrPtr res, const MpfrPtr a1, const MpfrPtr a2, const MpfrPtr b1, const MpfrPtr x, int const dps, unsigned digits10, double timeout)
//{
//    LibMpfr_Hypergeo2F1(res, a1, a2, b1, x, dps, digits10, timeout);
//}
//
//
//
//void Lib_Mpfr_Hypergeo2F2(MpfrPtr res, const MpfrPtr a1, const MpfrPtr a2, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr x, int const dps, unsigned digits10, double timeout)
//{
//    LibMpfr_Hypergeo2F2(res, a1, a2, b1, b2, x, dps, digits10, timeout);
//}
//
//
//
//void Lib_Mpfr_Hypergeo2F3(MpfrPtr res, const MpfrPtr a1, const MpfrPtr a2, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr b3, const MpfrPtr x, int const dps, unsigned digits10, double timeout)
//{
//    LibMpfr_Hypergeo2F3(res, a1, a2, b1, b2, b3, x, dps, digits10, timeout);
//}
//
//
//
//void Lib_Mpfr_Hypergeo3F2(MpfrPtr res, const MpfrPtr a1, const MpfrPtr a2, const MpfrPtr a3, const MpfrPtr b1, const MpfrPtr b2, const MpfrPtr x, int const dps, unsigned digits10, double timeout)
//{
//    LibMpfr_Hypergeo3F2(res, a1, a2, a3, b1, b2, x, dps, digits10, timeout);
//}
//
//








void Lib_Mpfr_JacobiTheta1(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    LibMpfr_JacobiTheta1(res, x, q, dps);
}


void Lib_Mpfr_JacobiTheta2(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    LibMpfr_JacobiTheta2(res, x, q, dps);
}


void Lib_Mpfr_JacobiTheta3(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    LibMpfr_JacobiTheta3(res, x, q, dps);
}


void Lib_Mpfr_JacobiTheta4(MpfrPtr res, const MpfrPtr x, const MpfrPtr q, int const dps)
{
    LibMpfr_JacobiTheta4(res, x, q, dps);
}





//***********************  Boost Distributions, Mpfr  **********************************


void Lib_Mpfr_ArcsineDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, int dps)
{
    LibMpfr_ArcsineDist(Target, res, xqp, a, b, dps);
}



void Lib_Mpfr_BernoulliDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr p, int dps)
{
    LibMpfr_BernoulliDist(Target, res, xqp, p, dps);
}



void Lib_Mpfr_BetaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, int dps)
{
    LibMpfr_BetaDist(Target, res, xqp, a, b, dps);
}



void Lib_Mpfr_BinomialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, MpfrPtr p, int dps)
{
    LibMpfr_BinomialDist(Target, res, xqp, n, p, dps);
}



void Lib_Mpfr_CauchyDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    LibMpfr_CauchyDist(Target, res, xqp, location, scale, dps);
}



void Lib_Mpfr_Chi2Dist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    LibMpfr_Chi2Dist(Target, res, xqp, nu, dps);
}



void Lib_Mpfr_ExponentialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lambda, int dps)
{
    LibMpfr_ExponentialDist(Target, res, xqp, lambda, dps);
}



void Lib_Mpfr_ExtremeValueDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    LibMpfr_ExtremeValueDist(Target, res, xqp, location, scale, dps);
}



void Lib_Mpfr_FisherFDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mu, MpfrPtr nu, int dps)
{
    LibMpfr_FisherFDist(Target, res, xqp, mu, nu, dps);
}



void Lib_Mpfr_GammaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps)
{
    LibMpfr_GammaDist(Target, res, xqp, shape, scale, dps);
}



void Lib_Mpfr_GeometricDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr p, int dps)
{
    LibMpfr_GeometricDist(Target, res, xqp, p, dps);
}



void Lib_Mpfr_HypergeometricDist(long Target, MpfrPtr res, MpfrPtr xqp, unsigned r, unsigned n, unsigned N, int dps)
{
    LibMpfr_HypergeometricDist(Target, res, xqp, r, n, N, dps);
}



void Lib_Mpfr_InverseChi2Dist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr df, MpfrPtr scale, int dps)
{
    LibMpfr_InverseChi2Dist(Target, res, xqp, df, scale, dps);
}



void Lib_Mpfr_InverseGammaDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps)
{
    LibMpfr_InverseGammaDist(Target, res, xqp, shape, scale, dps);
}



void Lib_Mpfr_WaldDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr scale, int dps)
{
    LibMpfr_InverseGaussianDist(Target, res, xqp, mean_, scale, dps);
}



void Lib_Mpfr_LaplaceDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    LibMpfr_LaplaceDist(Target, res, xqp, location, scale, dps);
}



void Lib_Mpfr_LogisticDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    LibMpfr_LogisticDist(Target, res, xqp, location, scale, dps);
}



void Lib_Mpfr_LognormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr location, MpfrPtr scale, int dps)
{
    LibMpfr_LognormalDist(Target, res, xqp, location, scale, dps);
}



void Lib_Mpfr_NegBinomialDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, MpfrPtr p, int dps)
{
    LibMpfr_NegBinomialDist(Target, res, xqp, n, p, dps);
}


void Lib_Mpfr_Chi2NcDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, MpfrPtr nc, int dps)
{
    LibMpfr_Chi2NCDist(Target, res, xqp, nu, nc, dps);
}


void Lib_Mpfr_StudentTNcDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, MpfrPtr delta, int dps)
{
    LibMpfr_StudentTNCDist(Target, res, xqp, nu, delta, dps);
}



void Lib_Mpfr_FisherNcDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mu, MpfrPtr nu, MpfrPtr nc, int dps)
{
    LibMpfr_FisherNCDist(Target, res, xqp, mu, nu, nc, dps);
}



void Lib_Mpfr_BetaNcDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr a, MpfrPtr b, MpfrPtr nc, int dps)
{
    LibMpfr_BetaNCDist(Target, res, xqp, a, b, nc, dps);
}



void Lib_Mpfr_NormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr stdev, int dps)
{
    LibMpfr_NormalDist(Target, res, xqp, mean_, stdev, dps);
}



void Lib_Mpfr_ParetoDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps)
{
    LibMpfr_ParetoDist(Target, res, xqp, shape, scale, dps);
}



void Lib_Mpfr_PoissonDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    LibMpfr_PoissonDist(Target, res, xqp, nu, dps);
}



void Lib_Mpfr_RayleighDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    LibMpfr_RayleighDist(Target, res, xqp, nu, dps);
}



void Lib_Mpfr_SkewNormalDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr mean_, MpfrPtr scale, MpfrPtr shape, int dps)
{
    LibMpfr_SkewNormalDist(Target, res, xqp, mean_, scale, shape, dps);
}



void Lib_Mpfr_StudentTDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr nu, int dps)
{
    LibMpfr_StudentTDist(Target, res, xqp, nu, dps);
}



void Lib_Mpfr_TriangularDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lower, MpfrPtr mode_, MpfrPtr upper, int dps)
{
    LibMpfr_TriangularDist(Target, res, xqp, lower, mode_, upper, dps);
}



void Lib_Mpfr_WeibullDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr shape, MpfrPtr scale, int dps)
{
    LibMpfr_WeibullDist(Target, res, xqp, shape, scale, dps);
}



void Lib_Mpfr_UniformDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr lower, MpfrPtr upper, int dps)
{
    LibMpfr_UniformDist(Target, res, xqp, lower, upper, dps);
}



//*********************** New , Mpfr precision **********************************




void Lib_Mpfr_Logaddexp(MpfrPtr res, const MpfrPtr a, const MpfrPtr b, int dps)
{
    LibMpfr_Logaddexp(res, a, b, dps);
}



void Lib_Mpfr_HyperexponentialDist(long Target, MpfrPtr res, MpfrPtr xqp, mpNumMatrixPtr l1, mpNumMatrixPtr l2, int dps)
{
    LibMpfr_HyperexponentialDist(Target, res, xqp, (MpfrStatePtr)l1, (MpfrStatePtr)l2, dps);
}



void Lib_Mpfr_KolmogorovSmirnovDist(long Target, MpfrPtr res, MpfrPtr xqp, MpfrPtr n, int dps)
{
    LibMpfr_KolmogorovSmirnovDist(Target, res, xqp, n, dps);
}








//*********************** Boost Numerical Calculus, Mpfr **********************************




void Lib_Mpfr_BracketRoot(MpfrPtr res1, MpfrPtr res2, int* iter, MpfrFuncPtr f1, MpfrPtr guess_, MpfrPtr factor_, bool is_rising, int get_digits, unsigned int maxit)
{
    LibMpfr_BracketRoot(res1, res2, iter, f1, guess_, factor_, is_rising, get_digits, maxit);
}



void Lib_Mpfr_NewtonRaphson(MpfrPtr res,  int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit)
{
    LibMpfr_NewtonRaphson(res, iter, f1, f2, guess_, xmin_, xmax_, get_digits, maxit);
}



void Lib_Mpfr_Halley(MpfrPtr res, int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit)
{
    LibMpfr_Halley(res, iter, f1, f2, f3, guess_, xmin_, xmax_, get_digits, maxit);
}



void Lib_Mpfr_Schroder(MpfrPtr res, int* iter, MpfrFuncPtr f1, MpfrFuncPtr f2, MpfrFuncPtr f3, MpfrPtr guess_, MpfrPtr xmin_, MpfrPtr xmax_, int get_digits, unsigned int maxit)
{
    LibMpfr_Schroder(res, iter, f1, f2, f3, guess_, xmin_, xmax_, get_digits, maxit);
}


void Lib_Mpfr_Brent_Minimum(MpfrPtr res, MpfrPtr resFx, int* iter, MpfrFuncPtr f1, MpfrPtr bracket_min_, MpfrPtr bracket_max_, int get_digits, unsigned int maxit)
{
    LibMpfr_Brent_Minimum(res, resFx, iter, f1, bracket_min_, bracket_max_, get_digits, maxit);
}





void Lib_Mpfr_Trapezoidal(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits)
{
    LibMpfr_Trapezoidal(res1, res2, res3, f1, a_, b_, get_digits);
}



// 7, 15, 20, 25 and 30

void Lib_Mpfr_GaussLegendre(MpfrPtr res1, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits)
{
    LibMpfr_GaussLegendre(res1, res3, f1, a_, b_, get_digits);
}



//15, 31, 41, 51 and 61

void Lib_Mpfr_GaussKronrod(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits)
{
    LibMpfr_GaussKronrod(res1, res2, res3, f1, a_, b_, get_digits);
}



void Lib_Mpfr_TanhSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, MpfrPtr a_, MpfrPtr b_, int get_digits)
{
    LibMpfr_TanhSinh(res1, res2, res3, levels_, f1, a_, b_, get_digits);
}




void Lib_Mpfr_SinhSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, int get_digits)
{
    LibMpfr_SinhSinh(res1, res2, res3, levels_, f1, get_digits);
}



void Lib_Mpfr_ExpSinh(MpfrPtr res1, MpfrPtr res2, MpfrPtr res3, int* levels_, MpfrFuncPtr f1, int get_digits)
{
    LibMpfr_ExpSinh(res1, res2, res3, levels_, f1, get_digits);
}



void Lib_Mpfr_Ooura_Cos(MpfrPtr res1, MpfrPtr res2, MpfrFuncPtr f1, int get_digits)
{
    LibMpfr_Ooura_Cos(res1, res2, f1, get_digits);
}



void Lib_Mpfr_Ooura_Sin(MpfrPtr res1, MpfrPtr res2, MpfrFuncPtr f1, int get_digits)
{
    LibMpfr_Ooura_Sin(res1, res2, f1, get_digits);
}






//*********************** Boost Odeint **********************************


AnyPtr Lib_Mpfr_StateInit_Func_N(int N, int digits)
{
    return LibMpfr_StateInit_Func_N(N, digits);
}


void Lib_Mpfr_StateClear(mpNumMatrixPtr x)
{
    return LibMpfr_StateClear((MpfrStatePtr) x);
}


void Lib_Mpfr_StateGetCoeff(ScalarPtr res, long row, mpNumMatrixPtr source, int digits)
{
    LibMpfr_StateGetCoeff((MpfrPtr) res, row, (MpfrStatePtr) source, digits);
}

void Lib_Mpfr_StateSetCoeff(mpNumMatrixPtr result, ScalarPtr source, long row, int digits)
{
    LibMpfr_StateSetCoeff((MpfrStatePtr) result, (MpfrPtr) source, row, digits);
}


void Lib_Mpfr_StateGetSize(long *result, mpNumMatrixPtr x)
{
    LibMpfr_StateGetSize(result, (MpfrStatePtr)x);
}






void Lib_Mpfr_Const_RungeKutta4(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    LibMpfr_Const_RungeKutta4((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, digits);
}

void Lib_Mpfr_Const_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    LibMpfr_Const_RungeKuttaCashKarp54((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, digits);
}

void Lib_Mpfr_Const_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    LibMpfr_Const_RungeKuttaDopri5((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, digits);
}

void Lib_Mpfr_Const_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    LibMpfr_Const_RungeKuttaFehlberg78((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, digits);
}

void Lib_Mpfr_Const_AdamsBashforthMoulton(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, int digits)
{
    LibMpfr_Const_AdamsBashforthMoulton((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, digits);
}













void Lib_Mpfr_Adaptive_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    LibMpfr_Adaptive_RungeKuttaDopri5((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_, digits);
}

void Lib_Mpfr_Adaptive_CashKarp54(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    LibMpfr_Adaptive_RungeKuttaCashKarp54((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_, digits);
}

void Lib_Mpfr_Adaptive_Fehlberg78(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    LibMpfr_Adaptive_RungeKuttaFehlberg78((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_, digits);
}

void Lib_Mpfr_Adaptive_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    LibMpfr_Adaptive_BulirschStoer((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_, digits);
}

void Lib_Mpfr_DenseOutput_Dopri5(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    LibMpfr_DenseOutput_Dopri5((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_, digits);
}

void Lib_Mpfr_DenseOutput_BulirschStoer(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr x, MpfrPtr start_time_, MpfrPtr end_time_, MpfrPtr dt_, MpfrPtr eps_abs_, MpfrPtr eps_rel_, int digits)
{
    LibMpfr_DenseOutput_BulirschStoer((MpfrAnyFuncPtr3)f1, (MpfrAnyFuncPtr2)f2, (MpfrStatePtr)x, start_time_, end_time_, dt_, eps_abs_, eps_rel_, digits);
}







//*********************** Boost/CppOptLib **********************************


void Lib_Mpfr_GradientDescentSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr)
{
    LibMpfr_GradientDescentSolver((MpfrFuncPtr) f1, (MpfrFuncPtr) f2, (MpfrStatePtr) matX_, (MpfrStatePtr) matGrad_, (MpfrStatePtr) matNorm, (MpfrStatePtr) xPtr, (MpfrStatePtr) resPtr);
}


void Lib_Mpfr_ConjugatedGradientDescentSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr)
{
    LibMpfr_ConjugatedGradientDescentSolver((MpfrFuncPtr) f1, (MpfrFuncPtr) f2, (MpfrStatePtr) matX_, (MpfrStatePtr) matGrad_, (MpfrStatePtr) matNorm, (MpfrStatePtr) xPtr, (MpfrStatePtr) resPtr);
}


void Lib_Mpfr_BfgsSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr)
{
    LibMpfr_BfgsSolver((MpfrFuncPtr) f1, (MpfrFuncPtr) f2, (MpfrStatePtr) matX_, (MpfrStatePtr) matGrad_, (MpfrStatePtr) matNorm, (MpfrStatePtr) xPtr, (MpfrStatePtr) resPtr);
}


void Lib_Mpfr_LbfgsSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr)
{
    LibMpfr_LbfgsSolver((MpfrFuncPtr) f1, (MpfrFuncPtr) f2, (MpfrStatePtr) matX_, (MpfrStatePtr) matGrad_, (MpfrStatePtr) matNorm, (MpfrStatePtr) xPtr, (MpfrStatePtr) resPtr);
}

//
//void Lib_Mpfr_NewtonDescentSolver(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr)
//{
//    LibMpfr_NewtonDescentSolver((MpfrFuncPtr) f1, (MpfrFuncPtr) f2, (MpfrStatePtr) matX_, (MpfrStatePtr) matGrad_, (MpfrStatePtr) matNorm, (MpfrStatePtr) xPtr, (MpfrStatePtr) resPtr);
//}
//



void Lib_Mpfr_CppOptLib1(long what, FuncPtr f1, mpNumMatrixPtr matX_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr)
{
    LibMpfr_CppOptLibDirect1(what, (MpfrFuncPtr) f1, (MpfrStatePtr) matX_, (MpfrStatePtr) matNorm, (MpfrStatePtr) xPtr, (MpfrStatePtr) resPtr);
}


void Lib_Mpfr_CppOptLib2(long what, FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr)
{
    LibMpfr_CppOptLibDirect2(what, (MpfrFuncPtr) f1, (MpfrFuncPtr) f2, (MpfrStatePtr) matX_, (MpfrStatePtr) matGrad_, (MpfrStatePtr) matNorm, (MpfrStatePtr) xPtr, (MpfrStatePtr) resPtr);
}


void Lib_Mpfr_CppOptLib3(long what, FuncPtr f1, FuncPtr f2, FuncPtr f3, mpNumMatrixPtr matX_, mpNumMatrixPtr matHessian_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm,  mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr)
{
    LibMpfr_CppOptLibDirect3(what, (MpfrFuncPtr) f1, (MpfrFuncPtr) f2, (MpfrFuncPtr) f3, (MpfrStatePtr) matX_, (MpfrStatePtr) matHessian_, (MpfrStatePtr) matGrad_, (MpfrStatePtr) matNorm, (MpfrStatePtr) xPtr, (MpfrStatePtr) resPtr);
}












































