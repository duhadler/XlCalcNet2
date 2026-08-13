#define MPFR_WANT_FLOAT128
#include "mpNumC_Main.h"


#include "mpfr.h"
#include "arf.h"
#include "arb.h"
#include "acb.h"
#include "Helperfunctions.h"





/** ********************** Real Basic Functions, ARB ******************************** **/


ArbPtr Lib_Arb_Init_Func()
{
	ArbPtr x;
	x = malloc(sizeof(arb_struct));
	arb_init((arb_ptr)x);
	return x;
}

void Lib_Arb_Clear(void* x)
{
	if (x != NULL)
	{
		arb_clear((arb_ptr)x);
		free(x);
	}
}



/* Input and output  */

void Lib_Arb_Set(ArbPtr res, const ArbPtr x)
{
	arb_set((arb_ptr)res, (arb_ptr)x);
}


void Lib_Arb_Set_Fmpq(ArbPtr res, const FmpqPtr x)
{
	arb_set_fmpq((arb_ptr)res, (fmpq*)x, mpfr_get_default_prec());
}


void Lib_Arb_Set_Arb(ArbPtr res, const ArbPtr x)
{
	arb_set((arb_ptr)res, (arb_ptr)x);
}


void Lib_Arb_Set_Arf(ArbPtr res, const ArfPtr x)
{
    arb_zero((arb_ptr)res);
	arf_set(arb_midref((arb_ptr)res), (arf_ptr)x);
}



void Lib_Arb_Set_Arf_Arf(ArbPtr res, const ArfPtr left, const ArfPtr right)
{
    arb_set_interval_arf((arb_ptr)res, (arf_ptr)left, (arf_ptr)right, mpfr_get_default_prec());
}

//
//
//void Lib_Arb_Set_Mpfi(ArbPtr res, const MpfiPtr x)
//{
//    arb_set_interval_mpfr((arb_ptr)res, &(((mpfi_ptr)x)->left), &(((mpfi_ptr)x)->right), mpfr_get_default_prec());
//}


void Lib_Arb_Set_Mpfr(ArbPtr res, const MpfrPtr x)
{
    arb_zero((arb_ptr)res);
    arf_set_mpfr(arb_midref((arb_ptr)res), (mpfr_ptr)x);
}

//
//void Lib_Arb_Set_Mpd(ArbPtr res, const MpdPtr x)
//{
//    if (Lib_Mpd_Finite(x))
//    {
//        char * src = mpd_to_sci((mpd_t *)x, 1);
//        arb_set_str((arb_ptr)res, src, mpfr_get_default_prec());
//        free(src);
//    }
//    else if (Lib_Mpd_Isposinf(x)) {arb_pos_inf((arb_ptr) res);}
//    else if (Lib_Mpd_Isneginf(x)) {arb_neg_inf((arb_ptr) res);}
//    else if (Lib_Mpd_IsNan(x)) { arb_indeterminate((arb_ptr) res);}
//}
//


void Lib_Arb_Set_QReal(ArbPtr res, const QRealPtr x)
{
    mpfr_t temp; mpfr_init2(temp, 128);
    mpfr_set_float128 ((mpfr_ptr)temp, *(__float128*)x, MPFR_RNDN);
    arb_zero((arb_ptr)res);
    arf_set_mpfr(arb_midref((arb_ptr)res), temp);
    mpfr_clear(temp);
}



void Lib_Arb_Set_LD(ArbPtr res, const long double*  x)
{
    mpfr_t temp; mpfr_init2(temp, 80);
    mpfr_set_ld((mpfr_ptr)temp, *x, MPFR_RNDN);
    arb_zero((arb_ptr)res);
    arf_set_mpfr(arb_midref((arb_ptr)res), temp);
    mpfr_clear(temp);
}



void Lib_Arb_Set_D(ArbPtr res, const double x)
{
	arb_set_d((arb_ptr)res, x);
}


void Lib_Arb_Set_S(ArbPtr res, const float* x)
{
	arb_set_d((arb_ptr)res, *x);
}


void Lib_Arb_Set_Si(ArbPtr res, const int32_t x)
{
	arb_set_si((arb_ptr)res, x);
}


void Lib_Arb_Set_Si64(ArbPtr res, const int64_t x)
{
	arb_set_si((arb_ptr)res, x);
}


void Lib_Arb_Set_Ui(ArbPtr res, const uint32_t x)
{
	arb_set_si((arb_ptr)res, x);
}


void Lib_Arb_Set_Ui64(ArbPtr res, const uint64_t x)
{
	arb_set_si((arb_ptr)res, x);
}




void Lib_Arb_Set_Str(ArbPtr res, const char* s)
{
    arb_set_str((arb_ptr)res, s, mpfr_get_default_prec());
}



uint32_t Lib_Arb_SizeInBase10(int32_t n, uint32_t flags, ArbPtr x)
{
//    printf("in arb_sizeinbase10 \n");
    char * src = arb_get_str((arb_ptr)x, n, flags);
    uint32_t res = (uint32_t)strlen(src) + 1;
    free(src);
    return res;
}



int64_t Lib_Arb_Get_Str(char * dest, ArbPtr x, int32_t n, uint32_t flags)
{
//    printf("in arb_get_str_intern \n");
    if (arb_is_finite((arb_ptr) x)) {
        char * src = arb_get_str((arb_ptr) x, n, flags);
        char * res =  strcpy(dest, src);
        free(src);
        return (int64_t) res;
    }
    else
    {
        char * res = NULL;
        if (arf_is_pos_inf(arb_midref((arb_ptr) x))) {res =  strcpy(dest, "inf");}
        if (arf_is_neg_inf(arb_midref((arb_ptr) x))) {res =  strcpy(dest, "-inf");}
        if (arf_is_nan(arb_midref((arb_ptr) x))) {res =  strcpy(dest, "nan");}
        return (int64_t) res;
    }
}




void Lib_Arb_Neg(ArbPtr res, const ArbPtr x)
{
	arb_neg((arb_ptr)res, (arb_ptr)x);
}


void Lib_Arb_Inv(ArbPtr res, const ArbPtr x)
{
	arb_inv((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}



void Lib_Arb_Add(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_add((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}



void Lib_Arb_Sub(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_sub((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Arb_Mul(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_mul((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Arb_Div(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_div((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}









void Lib_Arb_Add_D(ArbPtr res, const ArbPtr x, const double y)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, y);
	arb_add((arb_ptr)res, (arb_ptr)x, temp, mpfr_get_default_prec());
	arb_clear(temp);
}


void Lib_Arb_Sub_D(ArbPtr res, const ArbPtr x, const double y)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, y);
	arb_sub((arb_ptr)res, (arb_ptr)x, temp, mpfr_get_default_prec());
	arb_clear(temp);
}


void Lib_Arb_D_Sub(ArbPtr res, const ArbPtr y, const double x)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, x);
	arb_sub((arb_ptr)res, temp, (arb_ptr)y, mpfr_get_default_prec());
	arb_clear(temp);
}


void Lib_Arb_Mul_D(ArbPtr res, const ArbPtr x, const double y)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, y);
	arb_mul((arb_ptr)res, (arb_ptr)x, temp, mpfr_get_default_prec());
	arb_clear(temp);
}


void Lib_Arb_Div_D(ArbPtr res, const ArbPtr x, const double y)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, y);
	arb_div((arb_ptr)res, (arb_ptr)x, temp, mpfr_get_default_prec());
	arb_clear(temp);
}


void Lib_Arb_D_Div(ArbPtr res, const ArbPtr y, const double x)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, x);
	arb_div((arb_ptr)res, temp, (arb_ptr)y, mpfr_get_default_prec());
	arb_clear(temp);
}














void Lib_Arb_Add_Si(ArbPtr res, const ArbPtr x, const int32_t y)
{
	arb_add_si((arb_ptr)res, (arb_ptr)x, y, mpfr_get_default_prec());
}


void Lib_Arb_Sub_Si(ArbPtr res, const ArbPtr x, const int32_t y)
{
	arb_sub_si((arb_ptr)res, (arb_ptr)x, y, mpfr_get_default_prec());
}


void Lib_Arb_Si_Sub(ArbPtr res, const ArbPtr y, const int32_t x)
{
	arb_add_si((arb_ptr)res, (arb_ptr)y, x, mpfr_get_default_prec());
	arb_neg((arb_ptr)res, (arb_ptr)res);
}


void Lib_Arb_Mul_Si(ArbPtr res, const ArbPtr x, const int32_t y)
{
	arb_mul_si((arb_ptr)res, (arb_ptr)x, y, mpfr_get_default_prec());
}


void Lib_Arb_Div_Si(ArbPtr res, const ArbPtr x, const int32_t y)
{
	arb_div_si((arb_ptr)res, (arb_ptr)x, y, mpfr_get_default_prec());
}


void Lib_Arb_Si_Div(ArbPtr res, const ArbPtr y, const int32_t x)
{
    uint32_t u = 0;
    if (x<0) {u = -x;}
    else {u = x;}
	arb_ui_div((arb_ptr)res, u, (arb_ptr)y, mpfr_get_default_prec());
	if (x<0) {arb_neg((arb_ptr)res, (arb_ptr)res);}
}











int32_t Lib_Arb_EQ(void* in1, void* in2)
{
	return arb_eq((arb_ptr)in1, (arb_ptr)in2);
}

int32_t Lib_Arb_NE(void* in1, void* in2)
{
	return arb_ne((arb_ptr)in1, (arb_ptr)in2);
}

int32_t Lib_Arb_LT(void* in1, void* in2)
{
	return arb_lt((arb_ptr)in1, (arb_ptr)in2);
}

int32_t Lib_Arb_LE(void* in1, void* in2)
{
	return arb_le((arb_ptr)in1, (arb_ptr)in2);
}

int32_t Lib_Arb_GT(void* in1, void* in2)
{
	return arb_gt((arb_ptr)in1, (arb_ptr)in2);
}

int32_t Lib_Arb_GE(void* in1, void* in2)
{
	return arb_ge((arb_ptr)in1, (arb_ptr)in2);
}










/* General functions for real numbers  */

void Lib_Arb_Fma(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z)
{
	arb_fma((arb_ptr)res, (arb_ptr)x,  (arb_ptr)y,  (arb_ptr)z, mpfr_get_default_prec());
}

void Lib_Arb_Fmax(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_max((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}

void Lib_Arb_Fmin(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_min((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}




/* Machine constants, general  */

void Lib_Arb_Zero(ArbPtr res)
{
	arb_zero((arb_ptr)res);
}

void Lib_Arb_NegZero(ArbPtr res)
{
	arb_zero((arb_ptr)res);
}

void Lib_Arb_One(ArbPtr res)
{
	arb_one((arb_ptr)res);
}

void Lib_Arb_Inf(ArbPtr res)
{
	arb_pos_inf((arb_ptr)res);
}

void Lib_Arb_NegInf(ArbPtr res)
{
	arb_neg_inf((arb_ptr)res);
}

void Lib_Arb_Nan(ArbPtr res)
{
	arb_indeterminate((arb_ptr)res);
}





/* Properties of numbers  */

int Lib_Arb_Signbit(const ArbPtr x)
{
    return arb_is_negative((arb_ptr)x);
}

int Lib_Arb_Finite(const ArbPtr x)
{
	return  arb_is_finite((arb_ptr)x);
}

int Lib_Arb_IsZero(const ArbPtr x)
{
	return  arb_is_zero((arb_ptr)x);
}

int Lib_Arb_IsOne(const ArbPtr x)
{
	return  arb_equal_si((arb_ptr)x, 0);
}

int Lib_Arb_IsInf(const ArbPtr x)
{
	return arf_is_inf( arb_midref((arb_ptr)x)  );
}

int Lib_Arb_IsPosInf(const ArbPtr x)
{
	return arf_is_pos_inf( arb_midref((arb_ptr)x)  );
}

int Lib_Arb_IsNegInf(const ArbPtr x)
{
	return arf_is_neg_inf( arb_midref((arb_ptr)x)  );
}

int Lib_Arb_Isnan(const ArbPtr x)
{
	return arf_is_nan( arb_midref((arb_ptr)x)  );
}

int Lib_Arb_IsInteger(const ArbPtr x)
{
	return arb_is_int((arb_ptr)x);
}



int Lib_Arb_FitsInt32(const ArbPtr x)
{
	return arb_FitsInt32((arb_ptr)x);
}

int Lib_Arb_FitsInt64(const ArbPtr x)
{
	return arb_FitsInt64((arb_ptr)x);
}


int Lib_Arb_FitsUInt32(const ArbPtr x)
{
	return arb_FitsUInt32((arb_ptr)x);
}

int Lib_Arb_FitsUInt64(const ArbPtr x)
{
	return arb_FitsUInt64((arb_ptr)x);
}





/* Integer Related Functions  */

void Lib_Arb_Nearbyint(ArbPtr res, const ArbPtr x)
{
	arb_nint((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Rint(ArbPtr res, const ArbPtr x)
{
	arb_nint((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

long int Lib_Arb_Lrint(const ArbPtr x)
{
	return arf_get_si( arb_midref((arb_ptr)x) , ARF_RND_NEAR);
}

long long int Lib_Arb_Llrint(const ArbPtr x)
{
	return arf_get_si( arb_midref((arb_ptr)x) , ARF_RND_NEAR);
}


void Lib_Arb_Ceil(ArbPtr res, const ArbPtr x)
{
	arb_ceil((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Floor(ArbPtr res, const ArbPtr x)
{
	arb_floor((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Trunc(ArbPtr res, const ArbPtr x)
{
	arb_trunc((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Round(ArbPtr res, const ArbPtr x)
{
	arb_nint((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

long int Lib_Arb_Lround(const ArbPtr x)
{
	return arf_get_si( arb_midref((arb_ptr)x) , ARF_RND_NEAR);
}

long long int Lib_Arb_Llround(const ArbPtr x)
{
	return arf_get_si( arb_midref((arb_ptr)x) , ARF_RND_NEAR);
}


int32_t Lib_Arb_ToInt32(const ArbPtr x)
{
	return arb_ToInt32((arb_ptr)x);
}

int64_t Lib_Arb_ToInt64(const ArbPtr x)
{
	return arb_ToInt64((arb_ptr)x);
}


uint32_t Lib_Arb_ToUInt32(const ArbPtr x)
{
	return arb_ToUInt32((arb_ptr)x);
}

uint64_t Lib_Arb_ToUInt64(const ArbPtr x)
{
	return arb_ToUInt64((arb_ptr)x);
}




/* Floating point functions for real numbers */

void Lib_Arb_Copysign(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    arb_t temp; arb_init(temp);
    arb_sgn(temp, (arb_ptr)y);
    arb_abs((arb_ptr)res, (arb_ptr)x);
    arb_mul((arb_ptr)res, (arb_ptr)res, temp, mpfr_get_default_prec());
}

void Lib_Arb_Frexp(ArbPtr res, const ArbPtr x, FmpzPtr e)
{
    arb_frexp((arb_ptr)res, (arb_ptr)x, (fmpz_ptr)e);
}


void Lib_Arb_Logb(ArbPtr res, const ArbPtr x)
{
    arb_abs((arb_ptr)res, (arb_ptr)x);
    arb_log2((arb_ptr)res, (arb_ptr)res, mpfr_get_default_prec());
    arb_floor((arb_ptr)res, (arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_Ilogb(ArbPtr res, const ArbPtr x)
{
    arb_abs((arb_ptr)res, (arb_ptr)x);
    arb_log2((arb_ptr)res, (arb_ptr)res, mpfr_get_default_prec());
    arb_floor((arb_ptr)res, (arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_Ldexp(ArbPtr res, const ArbPtr x, const long int e)
{
	arb_mul_2exp_si((arb_ptr)res, (arb_ptr)x, e);
}

void Lib_Arb_Scalbn(ArbPtr res, const ArbPtr x, const long int e)
{
	arb_mul_2exp_si((arb_ptr)res, (arb_ptr)x, e);
}

void Lib_Arb_Scalbln(ArbPtr res, const ArbPtr x, const long int e)
{
	arb_mul_2exp_si((arb_ptr)res, (arb_ptr)x, e);
}

void Lib_Arb_Fdim(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    arb_sub((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
    if (!(arb_is_positive((arb_ptr)res))) {arb_set_si((arb_ptr)res, 0);}
}







/* Functions related to mantissa width and exponent range (MReal, BigDecimal) */

void Lib_Arb_Epsilon(ArbPtr res)
{
	arb_machine_epsilon_prec((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_Ulp(ArbPtr res, const ArbPtr x)
{
	arb_get_ulp((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Max(ArbPtr res)
{
	arb_maxval_prec( (arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_Lowest(ArbPtr res)
{
	arb_maxval_prec( (arb_ptr)res, mpfr_get_default_prec());
	arb_neg( (arb_ptr)res, (arb_ptr)res);
}

void Lib_Arb_Min(ArbPtr res)
{
	arb_minval_prec( (arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_Nextabove(ArbPtr res, const ArbPtr x)
{
	arb_next_above((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}
void Lib_Arb_Nextbelow(ArbPtr res, const ArbPtr x)
{
	arb_next_below((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Nexttoward(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    arb_next_toward((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}







/* Complex components  */

void Lib_Arb_Fabs(ArbPtr res, const ArbPtr x)
{
	arb_abs((arb_ptr)res, (arb_ptr)x);
}

void Lib_Arb_Sign(ArbPtr res, const ArbPtr x)
{
	arb_sgn((arb_ptr)res, (arb_ptr)x);
}



/* Mathematical Constants  */

void Lib_Arb_ConstDegree(ArbPtr res)
{
	arb_const_degree_((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstPhi(ArbPtr res)
{
	arb_const_phi_((arb_ptr)res, mpfr_get_default_prec());
}


void Lib_Arb_ConstLog2(ArbPtr res)
{
	arb_const_log2((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstLog10(ArbPtr res)
{
	arb_const_log10((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstPi(ArbPtr res)
{
	arb_const_pi((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstE(ArbPtr res)
{
	arb_const_e((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstEulerGamma(ArbPtr res)
{
	arb_const_euler((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstCatalan(ArbPtr res)
{
	arb_const_catalan((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstKhinchin(ArbPtr res)
{
	arb_const_khinchin((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstGlaisher(ArbPtr res)
{
	arb_const_glaisher((arb_ptr)res, mpfr_get_default_prec());
}

void Lib_Arb_ConstApery(ArbPtr res)
{
	arb_const_apery((arb_ptr)res, mpfr_get_default_prec());
}










/* Roots and related functions  */

void Lib_Arb_Sqrt(ArbPtr res, const ArbPtr x)
{
	arb_sqrt((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Sqrt1pm1(ArbPtr res, const ArbPtr x)
{
	arb_sqrt1pm1((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Rsqrt(ArbPtr res, const ArbPtr x)
{
	arb_rsqrt((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Cbrt(ArbPtr res, const ArbPtr x)
{
	arb_root_ui((arb_ptr)res, (arb_ptr)x, 3, mpfr_get_default_prec());
}


void Lib_Arb_Root_Si(ArbPtr res, const ArbPtr x, const int32_t n)
{
	arb_root_si_((arb_ptr)res, (arb_ptr)x, n, mpfr_get_default_prec());
}






/* Exponential and related functions  */


void Lib_Arb_Exp(ArbPtr res, const ArbPtr x)
{
	arb_exp((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Exp2(ArbPtr res, const ArbPtr x)
{
	arb_exp2_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Exp10(ArbPtr res, const ArbPtr x)
{
	arb_exp10_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Expm1(ArbPtr res, const ArbPtr x)
{
	arb_expm1((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Exp2m1(ArbPtr res, const ArbPtr x)
{
	arb_exp2m1_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Exp10m1(ArbPtr res, const ArbPtr x)
{
	arb_exp10m1_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}




/* Logarithms and related functions  */


void Lib_Arb_Log(ArbPtr res, const ArbPtr x)
{
	arb_log((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Log2(ArbPtr res, const ArbPtr x)
{
	arb_log2((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Log10(ArbPtr res, const ArbPtr x)
{
	arb_log10((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Log1p(ArbPtr res, const ArbPtr x)
{
	arb_log1p((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Log2p1(ArbPtr res, const ArbPtr x)
{
	arb_log2p1_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Log10p1(ArbPtr res, const ArbPtr x)
{
	arb_log10p1_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}






/* Power functions */


void Lib_Arb_Square(ArbPtr res, const ArbPtr x)
{
	arb_sqr((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Cube(ArbPtr res, const ArbPtr x)
{
	arb_cube_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Hypot(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_hypot((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}



void Lib_Arb_Pow(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_pow((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Arb_Powm1(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_powm1_((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Arb_Pow1p(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_pow1p_((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Arb_Pow1pm1(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_pow1pm1_((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}




void Lib_Arb_Pow_Si(ArbPtr res, const ArbPtr x, const int32_t n)
{
	arb_pow_si_((arb_ptr)res, (arb_ptr)x, n, mpfr_get_default_prec());
}


void Lib_Arb_Compound_Si(ArbPtr res, const ArbPtr x, const int32_t n)
{
	arb_compound_si_((arb_ptr)res, (arb_ptr)x, n, mpfr_get_default_prec());
}







/* Trigonometric functions  */

void Lib_Arb_Sin(ArbPtr res, const ArbPtr x)
{
	arb_sin((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Cos(ArbPtr res, const ArbPtr x)
{
	arb_cos((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Cosm1(ArbPtr res, const ArbPtr x)
{
	arb_cosm1_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Tan(ArbPtr res, const ArbPtr x)
{
	arb_tan((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Csc(ArbPtr res, const ArbPtr x)
{
	arb_csc((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Sec(ArbPtr res, const ArbPtr x)
{
	arb_sec((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Cot(ArbPtr res, const ArbPtr x)
{
	arb_cot((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}



void Lib_Arb_SinPi(ArbPtr res, const ArbPtr x)
{
	arb_sin_pi((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_CosPi(ArbPtr res, const ArbPtr x)
{
	arb_cos_pi((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_TanPi(ArbPtr res, const ArbPtr x)
{
	arb_tan_pi((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_CscPi(ArbPtr res, const ArbPtr x)
{
	arb_csc_pi((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_SecPi(ArbPtr res, const ArbPtr x)
{
	arb_sec_pi_((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_CotPi(ArbPtr res, const ArbPtr x)
{
	arb_cot_pi((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}






/* Hyperbolic functions  */

void Lib_Arb_Sinh(ArbPtr res, const ArbPtr x)
{
	arb_sinh((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Cosh(ArbPtr res, const ArbPtr x)
{
	arb_acosh((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Tanh(ArbPtr res, const ArbPtr x)
{
	arb_tanh((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Csch(ArbPtr res, const ArbPtr x)
{
	arb_csch((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Sech(ArbPtr res, const ArbPtr x)
{
	arb_sech((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Coth(ArbPtr res, const ArbPtr x)
{
	arb_coth((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}




/* Inverse trigonometric functions  */


void Lib_Arb_Asin(ArbPtr res, const ArbPtr x)
{
	arb_asin((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Acos(ArbPtr res, const ArbPtr x)
{
	arb_acos((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Atan(ArbPtr res, const ArbPtr x)
{
	arb_atan((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Atan2(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
	arb_atan2((arb_ptr)res, (arb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Arb_Acsc(ArbPtr res, const ArbPtr x)
{
	arb_acsc((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Asec(ArbPtr res, const ArbPtr x)
{
	arb_asec((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Acot(ArbPtr res, const ArbPtr x)
{
	arb_acot((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}





/* Inverse hyperbolic functions  */


void Lib_Arb_Asinh(ArbPtr res, const ArbPtr x)
{
	arb_asinh((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Acosh(ArbPtr res, const ArbPtr x)
{
	arb_acosh((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Atanh(ArbPtr res, const ArbPtr x)
{
	arb_atanh((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Acsch(ArbPtr res, const ArbPtr x)
{
	arb_acsch((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Asech(ArbPtr res, const ArbPtr x)
{
	arb_asech((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}


void Lib_Arb_Acoth(ArbPtr res, const ArbPtr x)
{
	arb_acoth((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}




/* Special functions  */

void Lib_Arb_Erf(ArbPtr res, const ArbPtr x)
{
	arb_hypgeom_erf((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Erfc(ArbPtr res, const ArbPtr x)
{
	arb_hypgeom_erfc((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Tgamma(ArbPtr res, const ArbPtr x)
{
	arb_gamma((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

void Lib_Arb_Lgamma(ArbPtr res, const ArbPtr x)
{
	arb_lgamma((arb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}

































/* Extra functions for ARB  */



int Lib_Arb_Contains(const ArbPtr x, const ArbPtr y)
{
	return arb_contains((arb_ptr)x,(arb_ptr)y);
}


void Lib_Arb_Set_Mid(ArbPtr res, const ArbPtr x)
{
	arf_set(arb_midref((arb_ptr)res), arb_midref((arb_ptr)x));
}

void Lib_Arb_Set_Rad(ArbPtr res, const ArbPtr x)
{
	arf_get_mag(arb_radref((arb_ptr)res), arb_midref((arb_ptr)x));
}

void Lib_Arb_Get_Mid(ArbPtr res, const ArbPtr x)
{
	arb_get_mid_arb((arb_ptr)res, (arb_ptr)x);
}

void Lib_Arb_Get_Rad(ArbPtr res, const ArbPtr x)
{
	arb_get_rad_arb((arb_ptr)res, (arb_ptr)x);
}

void Lib_Arb_Get_Infimum(ArbPtr res, const ArbPtr x)
{
	arb_get_lbound_arf(arb_midref((arb_ptr)res), (arb_ptr)x, mpfr_get_default_prec());
	mag_zero(arb_radref((arb_ptr)res));
}

void Lib_Arb_Get_Supremum(ArbPtr res, const ArbPtr x)
{
	arb_get_ubound_arf(arb_midref((arb_ptr)res), (arb_ptr)x, mpfr_get_default_prec());
	mag_zero(arb_radref((arb_ptr)res));
}


void Lib_Arb_Mid_Get_Mpfr(MpfrPtr res, const ArbPtr x)
{
	arf_get_mpfr((mpfr_ptr)res, arb_midref((arb_ptr)x), MPFR_RNDN);
}

void Lib_Arb_Get_Interval_Mpfr(MpfrPtr res1, MpfrPtr res2, const ArbPtr x)
{
	arb_get_interval_mpfr((mpfr_ptr)res1, (mpfr_ptr)res2, (arb_ptr)x);
}

void Lib_Arb_Mid_Set_Mpfr(ArbPtr res, const MpfrPtr x)
{
	arf_set_mpfr(arb_midref((arb_ptr)res), (mpfr_ptr)x);
}

void Lib_Arb_Set_Interval_Mpfr(ArbPtr res, const MpfrPtr x1, const MpfrPtr x2)
{
	arb_set_interval_mpfr((arb_ptr)res, (mpfr_ptr)x1, (mpfr_ptr)x2, mpfr_get_default_prec());
}









/**************************** ACB ******************************/


AcbPtr Lib_Acb_Init_Func()
{
	AcbPtr x;
	x = malloc(sizeof(acb_struct));
	acb_init((acb_ptr)x);
	return x;
}

void Lib_Acb_Clear(void* x)
{
	if (x != NULL)
	{
		acb_clear((acb_ptr)x);
		free(x);
	}
}





void Lib_Acb_Set(AcbPtr res, const AcbPtr x)
{
	acb_set((acb_ptr)res, (acb_ptr)x);
}




void Lib_Acb_Set_Mpfi_Mpfi(AcbPtr res, const MpfiPtr x_re, const MpfiPtr x_im)
{
//    arb_set_mpfi(arb_midref(acb_realref((acb_ptr)res1)), (mpfi_ptr)x_re);
//    arb_set_mpfi(arb_midref(acb_imagref((acb_ptr)res)), (mpfi_ptr)x_im);
}



void Lib_Acb_Set_Mpfr_Mpfr(AcbPtr res, const MpfrPtr x_re, const MpfrPtr x_im)
{
    arf_set_mpfr(arb_midref(acb_realref((acb_ptr)res)), (mpfr_ptr)x_re);
    arf_set_mpfr(arb_midref(acb_imagref((acb_ptr)res)), (mpfr_ptr)x_im);
}

//
//void Lib_Acb_Set_Mpd_Mpd(AcbPtr res, const MpdPtr x_re, const MpdPtr x_im)
//{
//	arb_set_decr(acb_realref((acb_ptr)res), (mpd_t *)x_re);
//	arb_set_decr(acb_imagref((acb_ptr)res), (mpd_t *)x_im);
//}
//


void Lib_Acb_Set_QReal_QReal(AcbPtr res, const QRealPtr x_re, const QRealPtr x_im)
{
//	arb_set_decr(acb_realref((acb_ptr)res), (mpd_t *)x_re);
//	arb_set_decr(acb_imagref((acb_ptr)res), (mpd_t *)x_im);
}




void Lib_Acb_Set_LD_LD(AcbPtr res, const long double*  x, const long double*  y)
{
//	acb_set_d_d((acb_ptr)res, x, y);
}


void Lib_Acb_Set_D_D(AcbPtr res, const double x, const double y)
{
	acb_set_d_d((acb_ptr)res, x, y);
}










void Lib_Acb_Neg(AcbPtr res, const AcbPtr x)
{
	acb_neg((acb_ptr)res, (acb_ptr)x);
}


void Lib_Acb_Inv(AcbPtr res, const AcbPtr x)
{
	acb_inv((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}





void Lib_Acb_Add(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
	acb_add((acb_ptr)res, (acb_ptr)x, (acb_ptr)y, mpfr_get_default_prec());
}


void Lib_Acb_Sub(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
	acb_sub((acb_ptr)res, (acb_ptr)x, (acb_ptr)y, mpfr_get_default_prec());
}


void Lib_Acb_Mul(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
	acb_mul((acb_ptr)res, (acb_ptr)x, (acb_ptr)y, mpfr_get_default_prec());
}


void Lib_Acb_Div(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
	acb_div((acb_ptr)res, (acb_ptr)x, (acb_ptr)y, mpfr_get_default_prec());
}






void Lib_Acb_Add_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y)
{
	acb_add_arb((acb_ptr)res, (acb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Acb_Sub_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y)
{
	acb_sub_arb((acb_ptr)res, (acb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Acb_Arb_Sub(AcbPtr res, const AcbPtr y, const ArbPtr x)
{
	acb_add_arb((acb_ptr)res, (acb_ptr)y, (arb_ptr)x, mpfr_get_default_prec());
	acb_neg((acb_ptr)res, (acb_ptr)res);
}


void Lib_Acb_Mul_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y)
{
	acb_mul_arb((acb_ptr)res, (acb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Acb_Div_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y)
{
	acb_div_arb((acb_ptr)res, (acb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}


void Lib_Acb_Arb_Div(AcbPtr res, const AcbPtr y, const ArbPtr x)
{
    acb_inv((acb_ptr)res, (acb_ptr)y, mpfr_get_default_prec());
	acb_mul_arb((acb_ptr)res, (acb_ptr)res, (arb_ptr)x, mpfr_get_default_prec());
}







void Lib_Acb_Add_D(AcbPtr res, const AcbPtr x, const double y)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, y);
	acb_add_arb((acb_ptr)res, (acb_ptr)x, temp, mpfr_get_default_prec());
	arb_clear(temp);
}



void Lib_Acb_Sub_D(AcbPtr res, const AcbPtr x, const double y)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, y);
	acb_sub_arb((acb_ptr)res, (acb_ptr)x, temp, mpfr_get_default_prec());
	arb_clear(temp);
}



void Lib_Acb_D_Sub(AcbPtr res, const AcbPtr y, const double x)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, x);
	acb_add_arb((acb_ptr)res, (acb_ptr)y, temp, mpfr_get_default_prec());
	acb_neg((acb_ptr)res, (acb_ptr)res);
	arb_clear(temp);
}



void Lib_Acb_Mul_D(AcbPtr res, const AcbPtr x, const double y)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, y);
	acb_mul_arb((acb_ptr)res, (acb_ptr)x, temp, mpfr_get_default_prec());
	arb_clear(temp);
}


void Lib_Acb_Div_D(AcbPtr res, const AcbPtr x, const double y)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, y);
	acb_div_arb((acb_ptr)res, (acb_ptr)x, temp, mpfr_get_default_prec());
	arb_clear(temp);
}


void Lib_Acb_D_Div(AcbPtr res, const AcbPtr y, const double x)
{
    arb_t temp; arb_init(temp);
    arb_set_d(temp, x);
    acb_inv((acb_ptr)res, (acb_ptr)y, mpfr_get_default_prec());
	acb_mul_arb((acb_ptr)res, (acb_ptr)res, temp, mpfr_get_default_prec());
	arb_clear(temp);
}









void Lib_Acb_Add_Si(AcbPtr res, const AcbPtr x, const int32_t y)
{
	acb_add_si((acb_ptr)res, (acb_ptr)x, y, mpfr_get_default_prec());
}



void Lib_Acb_Sub_Si(AcbPtr res, const AcbPtr x, const int32_t y)
{
	acb_sub_si((acb_ptr)res, (acb_ptr)x, y, mpfr_get_default_prec());
}



void Lib_Acb_Si_Sub(AcbPtr res, const AcbPtr y, const int32_t x)
{
	acb_sub_si((acb_ptr)res, (acb_ptr)y, x, mpfr_get_default_prec());
	acb_neg((acb_ptr)res, (acb_ptr)res);
}



void Lib_Acb_Mul_Si(AcbPtr res, const AcbPtr x, const int32_t y)
{
	acb_mul_si((acb_ptr)res, (acb_ptr)x, y, mpfr_get_default_prec());
}


void Lib_Acb_Div_Si(AcbPtr res, const AcbPtr x, const int32_t y)
{
	acb_div_si((acb_ptr)res, (acb_ptr)x, y, mpfr_get_default_prec());
}


void Lib_Acb_Si_Div(AcbPtr res, const AcbPtr y, const int32_t x)
{
    acb_inv((acb_ptr)res, (acb_ptr)y, mpfr_get_default_prec());
	acb_mul_si((acb_ptr)res, (acb_ptr)res, x, mpfr_get_default_prec());
}




int32_t Lib_Acb_EQ(void* in1, void* in2)
{
	return acb_eq((acb_ptr)in1, (acb_ptr)in2);
}



int32_t Lib_Acb_NE(void* in1, void* in2)
{
	return acb_ne((acb_ptr)in1, (acb_ptr)in2);
}





/* Floating point functions for real numbers  */

/* Integer and Remainder Related Functions  */

/* Machine constants and properties of numbers  */

void Lib_Acb_Onei(AcbPtr res)
{
	acb_onei((acb_ptr)res);
}



/* Complex components  */



void Lib_Acb_Set_Real(AcbPtr res, const ArbPtr x)
{
	acb_set_arb((acb_ptr)res, (arb_ptr)x);
}

void Lib_Acb_Set2(AcbPtr res, const ArbPtr x_re, const ArbPtr x_im)
{
	acb_set_arb_arb((acb_ptr)res, (arb_ptr)x_re, (arb_ptr)x_im);
}


void Lib_Acb_Set_Si64_Si64(AcbPtr res, const int64_t x, const int64_t y)
{
	acb_set_si_si((acb_ptr)res, x, y);
}


void Lib_Acb_Abs(ArbPtr res, const AcbPtr x)
{
	acb_abs((arb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Arg(ArbPtr res, const AcbPtr x)
{
	acb_arg((arb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Imag(ArbPtr res, const AcbPtr x)  /* get imag*/
{
	acb_get_imag((arb_ptr)res, (acb_ptr)x);
}

void Lib_Acb_Real(ArbPtr res, const AcbPtr x)  /* get real*/
{
	acb_get_real((arb_ptr)res, (acb_ptr)x);
}


void Lib_Acb_Conj(AcbPtr res, const AcbPtr x)
{
	acb_conj((acb_ptr)res, (acb_ptr)x);
}

void Lib_Acb_Proj(AcbPtr res, const AcbPtr x)
{
	//acb_proj((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}







/* Roots  */

void Lib_Acb_Sqrt(AcbPtr res, const AcbPtr x)
{
	acb_sqrt((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Sqrt1pm1(AcbPtr res, const AcbPtr x)
{
	acb_sqrt1pm1((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Rsqrt(AcbPtr res, const AcbPtr x)
{
	acb_rsqrt((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Cbrt(AcbPtr res, const AcbPtr x)
{
	acb_cbrt((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Root_Si(AcbPtr res, const AcbPtr x, const int32_t n)
{
	acb_root_si_((acb_ptr)res, (acb_ptr)x, n, mpfr_get_default_prec());
}





/* Exponential and related functions  */

void Lib_Acb_Exp(AcbPtr res, const AcbPtr x)
{
	acb_exp((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Expi(AcbPtr res, const AcbPtr x)
{
	acb_exp_pi_i((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Exp2(AcbPtr res, const AcbPtr x)
{
	acb_exp2_((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Exp10(AcbPtr res, const AcbPtr x)
{
	acb_exp10_((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Expm1(AcbPtr res, const AcbPtr x)
{
	acb_expm1((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Exp2m1(AcbPtr res, const AcbPtr x)
{
	acb_exp2m1_((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Exp10m1(AcbPtr res, const AcbPtr x)
{
	acb_exp10m1_((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}




/* Logarithms and related functions  */


void Lib_Acb_Log(AcbPtr res, const AcbPtr x)
{
	acb_log((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Log2(AcbPtr res, const AcbPtr x)
{
	acb_log2_((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Log10(AcbPtr res, const AcbPtr x)
{
	acb_log10_((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Log1p(AcbPtr res, const AcbPtr x)
{
	acb_log1p((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Log2p1(AcbPtr res, const AcbPtr x)
{
	acb_log2p1_((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Log10p1(AcbPtr res, const AcbPtr x)
{
	acb_log10p1_((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}





/* Power functions */


void Lib_Acb_Square(AcbPtr res, const AcbPtr x)
{
	acb_sqr((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Cube(AcbPtr res, const AcbPtr x)
{
	acb_cube((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}

void Lib_Acb_Pow(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
	acb_pow((acb_ptr)res, (acb_ptr)x, (acb_ptr)y, mpfr_get_default_prec());
}

void Lib_Acb_Powm1(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
	acb_powm1_((acb_ptr)res, (acb_ptr)x, (acb_ptr)y, mpfr_get_default_prec());
}

void Lib_Acb_Pow1p(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
	acb_pow1p_((acb_ptr)res, (acb_ptr)x, (acb_ptr)y, mpfr_get_default_prec());
}

void Lib_Acb_Pow1pm1(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
	acb_pow1pm1_((acb_ptr)res, (acb_ptr)x, (acb_ptr)y, mpfr_get_default_prec());
}


void Lib_Acb_Pow_Si(AcbPtr res, const AcbPtr x, const int32_t y)
{
	acb_pow_si((acb_ptr)res, (acb_ptr)x, y, mpfr_get_default_prec());
}

void Lib_Acb_Compound_Si(AcbPtr res, const AcbPtr x, const int32_t y)
{
	acb_compound_si_((acb_ptr)res, (acb_ptr)x, y, mpfr_get_default_prec());
}


void Lib_Acb_Pow_Arb(AcbPtr res, const AcbPtr x, const ArbPtr y)
{
	acb_pow_arb((acb_ptr)res, (acb_ptr)x, (arb_ptr)y, mpfr_get_default_prec());
}





/* Trigonometric functions  */


void Lib_Acb_Sin(AcbPtr res, const AcbPtr x)
{
	acb_sin((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Cos(AcbPtr res, const AcbPtr x)
{
	acb_cos((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Tan(AcbPtr res, const AcbPtr x)
{
	acb_tan((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Csc(AcbPtr res, const AcbPtr x)
{
	acb_csc((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Sec(AcbPtr res, const AcbPtr x)
{
	acb_sec((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Cot(AcbPtr res, const AcbPtr x)
{
	acb_cot((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_SinPi(AcbPtr res, const AcbPtr x)
{
	acb_sin_pi((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_CosPi(AcbPtr res, const AcbPtr x)
{
	acb_cos_pi((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_TanPi(AcbPtr res, const AcbPtr x)
{
	acb_tan_pi((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}






/* Hyperbolic functions  */


void Lib_Acb_Sinh(AcbPtr res, const AcbPtr x)
{
	acb_sinh((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Cosh(AcbPtr res, const AcbPtr x)
{
	acb_cosh((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Tanh(AcbPtr res, const AcbPtr x)
{
	acb_tanh((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Csch(AcbPtr res, const AcbPtr x)
{
	acb_csch((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Sech(AcbPtr res, const AcbPtr x)
{
	acb_sech((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Coth(AcbPtr res, const AcbPtr x)
{
	acb_coth((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}





/* Inverse trigonometric functions  */


void Lib_Acb_Asin(AcbPtr res, const AcbPtr x)
{
	acb_asin((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Acos(AcbPtr res, const AcbPtr x)
{
	acb_acos((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Atan(AcbPtr res, const AcbPtr x)
{
	acb_atan((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Acsc(AcbPtr res, const AcbPtr x)
{
	acb_acsc((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Asec(AcbPtr res, const AcbPtr x)
{
	acb_asec((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Acot(AcbPtr res, const AcbPtr x)
{
	acb_acot((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}




/* Inverse hyperbolic functions  */



void Lib_Acb_Acosh(AcbPtr res, const AcbPtr x)
{
	acb_acosh((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Asinh(AcbPtr res, const AcbPtr x)
{
	acb_asinh((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Atanh(AcbPtr res, const AcbPtr x)
{
	acb_atanh((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Acsch(AcbPtr res, const AcbPtr x)
{
	acb_acsch((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Asech(AcbPtr res, const AcbPtr x)
{
	acb_asech((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}


void Lib_Acb_Acoth(AcbPtr res, const AcbPtr x)
{
	acb_acoth((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}






















/* Extra functions for ACB  */


void Lib_Acb_Elliptic_Invariants(AcbPtr res_g2, AcbPtr res_g3, const AcbPtr tau)
{
	acb_elliptic_invariants((acb_ptr)res_g2, (acb_ptr)res_g3, (acb_ptr)tau, mpfr_get_default_prec());
}


void Lib_Acb_Elliptic_Roots(AcbPtr res_e1, AcbPtr res_e2, AcbPtr res_e3, const AcbPtr tau)
{
	acb_elliptic_roots((acb_ptr)res_e1, (acb_ptr)res_e2, (acb_ptr)res_e3, (acb_ptr)tau, mpfr_get_default_prec());
}



void Lib_Acb_Elliptic_P(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
	acb_elliptic_p((acb_ptr)res, (acb_ptr)z, (acb_ptr)tau, mpfr_get_default_prec());
}


void Lib_Acb_Modj(AcbPtr res, const AcbPtr x)
{
	acb_modular_j((acb_ptr)res, (acb_ptr)x, mpfr_get_default_prec());
}





void Lib_Acb_Elliptic_Rc(AcbPtr res, const AcbPtr z1, const AcbPtr z2)
{
	acb_elliptic_rf((acb_ptr)res, (acb_ptr)z1, (acb_ptr)z2, (acb_ptr)z2, 0, mpfr_get_default_prec());
}



void Lib_Acb_Elliptic_Rf(AcbPtr res, const AcbPtr z1, const AcbPtr z2, const AcbPtr z3)
{
	acb_elliptic_rf((acb_ptr)res, (acb_ptr)z1, (acb_ptr)z2, (acb_ptr)z3, 0, mpfr_get_default_prec());
}


void Lib_Acb_Elliptic_Rg(AcbPtr res, const AcbPtr z1, const AcbPtr z2, const AcbPtr z3)
{
	acb_elliptic_rg((acb_ptr)res, (acb_ptr)z1, (acb_ptr)z2, (acb_ptr)z3, 0, mpfr_get_default_prec());
}



void Lib_Acb_Elliptic_Rd(AcbPtr res, const AcbPtr z1, const AcbPtr z2, const AcbPtr z3)
{
	acb_elliptic_rj((acb_ptr)res, (acb_ptr)z1, (acb_ptr)z2, (acb_ptr)z3, (acb_ptr)z3, 0, mpfr_get_default_prec());
}



void Lib_Acb_Elliptic_Rj(AcbPtr res, const AcbPtr z1, const AcbPtr z2, const AcbPtr z3, const AcbPtr z4)
{
	acb_elliptic_rj((acb_ptr)res, (acb_ptr)z1, (acb_ptr)z2, (acb_ptr)z3, (acb_ptr)z4, 0, mpfr_get_default_prec());
}







//*********************** Flint **********************************





void Arb_Arb_Realfunc0_Prec(ArbFuncPtr0 f0, ArbPtr out1_arb)
{
	//printf("using Arb_Arb_Realfunc0_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f0((arb_ptr)out1_arb, wp);
}



void Arb_Arb_Realfunc0Int32_Prec(ArbFuncPtr0Int32 f0Int32, ArbPtr out1_arb, int32_t in1)
{
	//printf("using Arb_Arb_Realfunc0Int32_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f0Int32((arb_ptr)out1_arb, in1, wp);
}



void Arb_Arb_Realfunc1_Prec(ArbFuncPtr1 f1, ArbPtr out1_arb, ArbPtr in1_arb)
{
	//printf("using Arb_Arb_Realfunc1_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f1((arb_ptr)out1_arb, (arb_ptr)in1_arb, wp);
}


void Arb_Arb_Realfunc1Int32_Prec(ArbFuncPtr1Int32 f1Int32, ArbPtr out1_arb, ArbPtr in1_arb, int32_t in2)
{
	//printf("using Arb_Arb_Realfunc1_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f1Int32((arb_ptr)out1_arb, (arb_ptr)in1_arb, in2, wp);
}



void Arb_Arb_Realfunc2_Prec(ArbFuncPtr2 f2, ArbPtr out1_arb, ArbPtr in1_arb, ArbPtr in2_arb)
{
	//printf("using Arb_Arb_Realfunc2_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f2((arb_ptr)out1_arb, (arb_ptr)in1_arb, (arb_ptr)in2_arb, wp);

}


void Arb_Arb_Realfunc3_Prec(ArbFuncPtr3 f3, ArbPtr out1_arb, ArbPtr in1_arb, ArbPtr in2_arb, ArbPtr in3_arb)
{
	//printf("using Arb_Arb_Realfunc3_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f3((arb_ptr)out1_arb, (arb_ptr)in1_arb, (arb_ptr)in2_arb, (arb_ptr)in3_arb, wp);
}



void Arb_Arb_Realfunc4_Prec(ArbFuncPtr4 f4, ArbPtr out1_arb, ArbPtr in1_arb, ArbPtr in2_arb, ArbPtr in3_arb, ArbPtr in4_arb)
{
	//printf("using Arb_Arb_Realfunc4_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f4((arb_ptr)out1_arb, (arb_ptr)in1_arb, (arb_ptr)in2_arb, (arb_ptr)in3_arb, (arb_ptr)in4_arb, wp);
}





void Acb_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, AcbPtr out1_acb, int32_t in1)
{
	//printf("using Acb_Acb_Cplxfunc1Int32_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f0Int32((acb_ptr)out1_acb, in1, wp);
}



void Acb_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, AcbPtr out1_acb, AcbPtr in1_acb)
{
	//printf("using Acf_Acb_Cplxfunc1_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f1((acb_ptr)out1_acb, (acb_ptr)in1_acb, wp);
}



void Acb_Acb_Cplxfunc1Int32_Prec(AcbFuncPtr1Int32 f1Int32, AcbPtr out1_acb, AcbPtr in1_acb, int32_t in2)
{
	//printf("using Acb_Acb_Cplxfunc1Int32_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f1Int32((acb_ptr)out1_acb, (acb_ptr)in1_acb, in2, wp);
}




void Acb_Acb_Cplxfunc2_Prec(AcbFuncPtr2 f2, AcbPtr out1_acb, AcbPtr in1_acb, AcbPtr in2_acb)
{
	//printf("using Acb_Acb_Cplxfunc2_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f2((acb_ptr)out1_acb, (acb_ptr)in1_acb, (acb_ptr)in2_acb, wp);
}



void Acb_Acb_Cplxfunc3_Prec(AcbFuncPtr3 f3, AcbPtr out1_acb, AcbPtr in1_acb, AcbPtr in2_acb, AcbPtr in3_acb)
{
	//printf("using Acb_Acb_Cplxfunc3_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f3((acb_ptr)out1_acb, (acb_ptr)in1_acb, (acb_ptr)in2_acb, (acb_ptr)in3_acb, wp);
}



void Acb_Acb_Cplxfunc4_Prec(AcbFuncPtr4 f4, AcbPtr out1_acb, AcbPtr in1_acb, AcbPtr in2_acb, AcbPtr in3_acb, AcbPtr in4_acb)
{
	//printf("using Acb_Acb_Cplxfunc4_Prec:  ");
	slong wp = mpfr_get_default_prec();

	f4((acb_ptr)out1_acb, (acb_ptr)in1_acb, (acb_ptr)in2_acb, (acb_ptr)in3_acb, (acb_ptr)in4_acb, wp);
}







/* Roots and quadratic, cubic, and quartic equations */


void Lib_Arb_Arb_Sqrt(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sqrt, res, x);
}


void Lib_Arb_Arb_Rsqrt(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_rsqrt, res, x);
}


void Lib_Arb_Arb_Cbrt(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_cbrt, res, x);
}


void Lib_Arb_Arb_Sqrt1pm1(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sqrt1pm1, res, x);
}


void Lib_Arb_Arb_Root_ui(ArbPtr res, const ArbPtr x, const int32_t n)
{
    Arb_Arb_Realfunc1Int32_Prec(arb_root_ui_, res, x, n);
}


void Lib_Arb_Arb_Root_si(ArbPtr res, const ArbPtr x, const int32_t n)
{
    Arb_Arb_Realfunc1Int32_Prec(arb_root_si_, res, x, n);
}





/* Exponential and related functions */



void Lib_Arb_Arb_Exp(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_exp, res, x);
}


void Lib_Arb_Arb_Expm1(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_expm1, res, x);
}


void Lib_Arb_Arb_Exp10(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_exp10_, res, x);
}


void Lib_Arb_Arb_Exp2(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_exp2_, res, x);
}


void Lib_Arb_Arb_Exp10m1(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_exp10m1_, res, x);
}


void Lib_Arb_Arb_Exp2m1(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_exp2m1_, res, x);
}


void Lib_Arb_Arb_ExpRel(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_exprel_, res, x);
}




/* Logarithms and related functions */



void Lib_Arb_Arb_Log(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_log, res, x);
}


void Lib_Arb_Arb_Logbase(ArbPtr res, const ArbPtr x, const ArbPtr b)
{
    Arb_Arb_Realfunc2_Prec(arb_logbase_, res, x, b);
}


void Lib_Arb_Arb_Log10(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_log10, res, x);
}


void Lib_Arb_Arb_Log2(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_log2, res, x);
}


void Lib_Arb_Arb_Log1p(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_log1p, res, x);
}


void Lib_Arb_Arb_Log10p1(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_log10p1_, res, x);
}


void Lib_Arb_Arb_Log2p1(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_log2p1_, res, x);
}


void Lib_Arb_Arb_Log1mexp(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_log1mexp_, res, x);
}


void Lib_Arb_Arb_LambertW0(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_lambertw0, res, x);
}


void Lib_Arb_Arb_LambertWm1(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_lambertwm1, res, x);
}




/* Power functions */


void Lib_Arb_Arb_Square(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sqr, res, x);
}


void Lib_Arb_Arb_Cube(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_cube_, res, x);
}


void Lib_Arb_Arb_Pow_ui(ArbPtr res, const ArbPtr x, const int32_t n)
{
    Arb_Arb_Realfunc1Int32_Prec(arb_pow_ui_, res, x, n);
}


void Lib_Arb_Arb_Pow_si(ArbPtr res, const ArbPtr x, const int32_t n)
{
    Arb_Arb_Realfunc1Int32_Prec(arb_pow_si_, res, x, n);
}


void Lib_Arb_Arb_Compound_si(ArbPtr res, const ArbPtr x, const int32_t n)
{
    Arb_Arb_Realfunc1Int32_Prec(arb_compound_si_, res, x, n);
}



void Lib_Arb_Arb_Hypot(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypot, res, x, y);
}


void Lib_Arb_Arb_Pow(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_pow, res, x, y);
}


void Lib_Arb_Arb_Powm1(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_powm1_, res, x, y);
}


void Lib_Arb_Arb_Pow1p(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_pow1p_, res, x, y);
}


void Lib_Arb_Arb_Pow1pm1(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_pow1pm1_, res, x, y);
}





/* Trigonometric and related functions */


void Lib_Arb_Arb_Sin(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sin, res, x);
}


void Lib_Arb_Arb_Cos(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_cos, res, x);
}


void Lib_Arb_Arb_Tan(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_tan, res, x);
}



void Lib_Arb_Arb_Csc(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_csc, res, x);
}


void Lib_Arb_Arb_Sec(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sec, res, x);
}


void Lib_Arb_Arb_Cot(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_cot, res, x);
}


void Lib_Arb_Arb_Sinc(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sinc, res, x);
}


void Lib_Arb_Arb_SincPi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sinc_pi, res, x);
}


void Lib_Arb_Arb_SinPi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sin_pi, res, x);
}


void Lib_Arb_Arb_CosPi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_cos_pi, res, x);
}


void Lib_Arb_Arb_TanPi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_tan_pi, res, x);
}


void Lib_Arb_Arb_CscPi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_csc_pi, res, x);
}


void Lib_Arb_Arb_SecPi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sec_pi_, res, x);
}


void Lib_Arb_Arb_CotPi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_cot_pi, res, x);
}




/* Hyperbolic functions */


void Lib_Arb_Arb_Sinh(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sinh, res, x);
}


void Lib_Arb_Arb_Cosh(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_cosh, res, x);
}


void Lib_Arb_Arb_Tanh(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_tanh, res, x);
}



void Lib_Arb_Arb_Csch(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_csch, res, x);
}


void Lib_Arb_Arb_Sech(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_sech, res, x);
}


void Lib_Arb_Arb_Coth(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_coth, res, x);
}





/* Inverse trigonometric functions */


void Lib_Arb_Arb_Asin(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_asin, res, x);
}


void Lib_Arb_Arb_Acos(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_acos, res, x);
}



void Lib_Arb_Arb_Atan2(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_atan2, res, x, y);
}


void Lib_Arb_Arb_Atan(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_atan, res, x);
}



void Lib_Arb_Arb_Acsc(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_acsc, res, x);
}


void Lib_Arb_Arb_Asec(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_asec, res, x);
}


void Lib_Arb_Arb_Acot(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_Arb_Arb_Asinh(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_asinh, res, x);
}


void Lib_Arb_Arb_Acosh(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_acosh, res, x);
}


void Lib_Arb_Arb_Atanh(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_atanh, res, x);
}



void Lib_Arb_Arb_Acsch(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_acsch, res, x);
}


void Lib_Arb_Arb_Asech(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_asech, res, x);
}


void Lib_Arb_Arb_Acoth(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_acoth, res, x);
}







/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_Arb_Arb_MEllipticK(ArbPtr res, const ArbPtr m)
{
    Arb_Arb_Realfunc1_Prec(arb_elliptic_k, res, m);
}


void Lib_Arb_Arb_MEllipticE(ArbPtr res, const ArbPtr m)
{
    Arb_Arb_Realfunc1_Prec(arb_elliptic_e, res, m);
}


void Lib_Arb_Arb_MEllipticPi(ArbPtr res, const ArbPtr n, const ArbPtr m)
{
    Arb_Arb_Realfunc2_Prec(arb_elliptic_pi, res, n, m);
}


void Lib_Arb_Arb_MEllipticF(ArbPtr res, const ArbPtr phi, const ArbPtr m)
{
    Arb_Arb_Realfunc2_Prec(arb_elliptic_f_, res, phi, m);
}


void Lib_Arb_Arb_MEllipticEInc(ArbPtr res, const ArbPtr phi, const ArbPtr m)
{
    Arb_Arb_Realfunc2_Prec(arb_elliptic_e_inc_, res, phi, m);
}


void Lib_Arb_Arb_MEllipticPiInc(ArbPtr res, const ArbPtr n, const ArbPtr phi, const ArbPtr m)
{
    Arb_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_, res, n, phi, m);
}




/* Legendre elliptic integrals (elliptic modulus k), and related functions */




void Lib_Arb_Arb_EllipticK(ArbPtr res, const ArbPtr k)
{
    Arb_Arb_Realfunc1_Prec(arb_elliptic_k_k_, res, k);
}


void Lib_Arb_Arb_EllipticE(ArbPtr res, const ArbPtr k)
{
    Arb_Arb_Realfunc1_Prec(arb_elliptic_e_k_, res, k);
}


void Lib_Arb_Arb_EllipticPi(ArbPtr res, const ArbPtr n, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(arb_elliptic_pi_k_, res, n, k);
}


void Lib_Arb_Arb_EllipticF(ArbPtr res, const ArbPtr phi, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(arb_elliptic_f_k_, res, phi, k);
}


void Lib_Arb_Arb_EllipticEInc(ArbPtr res, const ArbPtr phi, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(arb_elliptic_e_inc_k_, res, phi, k);
}


void Lib_Arb_Arb_EllipticPiInc(ArbPtr res, const ArbPtr n, const ArbPtr phi, const ArbPtr k)
{
    Arb_Arb_Realfunc3_Prec(arb_elliptic_pi_inc_k_, res, n, phi, k);
}


void Lib_Arb_Arb_Agm(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */


void Lib_Arb_Arb_Elliptic_RC(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_elliptic_rc_, res, x, y);
}


void Lib_Arb_Arb_Elliptic_RF(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_elliptic_rf_, res, x, y, z);
}


void Lib_Arb_Arb_Elliptic_RG(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_elliptic_rg_, res, x, y, z);
}


void Lib_Arb_Arb_Elliptic_RD(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_elliptic_rd_, res, x, y, z);
}


void Lib_Arb_Arb_Elliptic_RJ(ArbPtr res, const ArbPtr x, const ArbPtr y, const ArbPtr z, const ArbPtr w)
{
    Arb_Arb_Realfunc4_Prec(arb_elliptic_rj_, res, x, y, z, w);
}





/* Jacobi theta functions */


void Lib_Arb_Arb_Theta1Q(ArbPtr res, const ArbPtr z, const ArbPtr q)
{
    Arb_Arb_Realfunc2_Prec(_arb_theta1q, res, z, q);
}


void Lib_Arb_Arb_Theta2Q(ArbPtr res, const ArbPtr z, const ArbPtr q)
{
    Arb_Arb_Realfunc2_Prec(_arb_theta2q, res, z, q);
}


void Lib_Arb_Arb_Theta3Q(ArbPtr res, const ArbPtr z, const ArbPtr q)
{
    Arb_Arb_Realfunc2_Prec(_arb_theta3q, res, z, q);
}


void Lib_Arb_Arb_Theta4Q(ArbPtr res, const ArbPtr z, const ArbPtr q)
{
    Arb_Arb_Realfunc2_Prec(_arb_theta4q, res, z, q);
}




/* Jacobi elliptic functions */



void Lib_Arb_Arb_JacobiSN(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_sn, res, u, k);
}


void Lib_Arb_Arb_JacobiCN(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_cn, res, u, k);
}


void Lib_Arb_Arb_JacobiDN(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_dn, res, u, k);
}


void Lib_Arb_Arb_JacobiNS(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_ns, res, u, k);
}


void Lib_Arb_Arb_JacobiNC(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_nc, res, u, k);
}


void Lib_Arb_Arb_JacobiND(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_nd, res, u, k);
}


void Lib_Arb_Arb_JacobiSC(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_sc, res, u, k);
}


void Lib_Arb_Arb_JacobiSD(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_sd, res, u, k);
}


void Lib_Arb_Arb_JacobiDC(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_dc, res, u, k);
}


void Lib_Arb_Arb_JacobiDS(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_ds, res, u, k);
}


void Lib_Arb_Arb_JacobiCS(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_cs, res, u, k);
}


void Lib_Arb_Arb_JacobiCD(ArbPtr res, const ArbPtr u, const ArbPtr k)
{
    Arb_Arb_Realfunc2_Prec(_arb_jacobi_cd, res, u, k);
}





/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */




/* Lerch’s transcendent: overview */



void Lib_Arb_Arb_LerchPhi(ArbPtr res, const ArbPtr z, const ArbPtr s, const ArbPtr a)
{
    Arb_Arb_Realfunc3_Prec(arb_dirichlet_lerch_phi, res, z, s, a);
}





/* Polygamma functions */


void Lib_Arb_Arb_Polygamma(ArbPtr res, const ArbPtr s, const ArbPtr z)
{
    Arb_Arb_Realfunc2_Prec(arb_polygamma, res, s, z);
}


void Lib_Arb_Arb_Digamma(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_digamma, res, x);
}



/* Polylogarithms and related functions */




void Lib_Arb_Arb_Polylog(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_polylog, res, x, y);
}


void Lib_Arb_Arb_Dilog(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_dilog, res, x);
}



/* Hurwitz zeta function and related functions */


void Lib_Arb_Arb_HurwitzZeta(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hurwitz_zeta, res, x, y);
}



void Lib_Arb_Arb_Bernoulli_ui(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_bernoulli_ui_, res, n);
}


void Lib_Arb_Arb_Euler_ui(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_euler_number_ui_, res, n);
}



void Lib_Arb_Arb_BernoulliPoly_ui(ArbPtr res, const ArbPtr x, const int32_t n)
{
    Arb_Arb_Realfunc1Int32_Prec(arb_bernoulli_poly_ui_, res, x, n);
}



void Lib_Arb_Arb_BarnesG(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_barnes_g, res, x);
}


void Lib_Arb_Arb_LogBarnesG(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */




void Lib_Arb_Arb_Zeta(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_zeta, res, x);
}





void Lib_Arb_Arb_BacklundS(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(acb_dirichlet_backlund_s, res, x);
}


void Lib_Arb_Arb_GramPoint_ui(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_gram_point_ui_, res, n);
}







/* Additional numbertheoretic functions */


void Lib_Arb_Arb_Bell_ui(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_bell_ui_, res, n);
}


void Lib_Arb_Arb_Partitions_ui(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_partitions_ui_, res, n);
}


void Lib_Arb_Arb_Primorial_ui(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_primorial_nth_ui_, res, n);
}






/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_Arb_Arb_Hypgeom0F1(ArbPtr res, const ArbPtr a, const ArbPtr x)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_0f1_, res, a, x);
}


void Lib_Arb_Arb_Hypgeom0F1r(ArbPtr res, const ArbPtr a, const ArbPtr x)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */


void Lib_Arb_Arb_BesselJ(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_bessel_j, res, x, y);
}


void Lib_Arb_Arb_BesselY(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_bessel_y, res, x, y);
}


void Lib_Arb_Arb_BesselI(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i, res, x, y);
}


void Lib_Arb_Arb_BesselK(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k, res, x, y);
}


void Lib_Arb_Arb_BesselIScaled(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_Arb_Arb_BesselKScaled(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_bessel_k_scaled, res, x, y);
}



/* Spherical Bessel functions  */





/* Airy functions  */



void Lib_Arb_Arb_AiryAi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_airy_ai, res, x);
}


void Lib_Arb_Arb_AiryAiPrime(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_airy_ai_prime, res, x);
}


void Lib_Arb_Arb_AiryBi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_airy_bi, res, x);
}


void Lib_Arb_Arb_AiryBiPrime(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_airy_bi_prime, res, x);
}




void Lib_Arb_Arb_AiryAiZero(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_airy_ai_zero, res, n);
}


void Lib_Arb_Arb_AiryAiPrimeZero(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_airy_ai_prime_zero, res, n);
}


void Lib_Arb_Arb_AiryBiZero(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_airy_bi_zero, res, n);
}


void Lib_Arb_Arb_AiryBiPrimeZero(ArbPtr res, const int32_t n)
{
    Arb_Arb_Realfunc0Int32_Prec(arb_airy_bi_prime_zero, res, n);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */


void Lib_Arb_Arb_Hypgeom1F1(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_1f1_, res, a, b, z);
}


void Lib_Arb_Arb_Hypgeom1F1r(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_Arb_Arb_HypgeomU(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_u, res, a, b, z);
}






/* Gamma function and related functions */


void Lib_Arb_Arb_Gamma(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_gamma, res, x);
}


void Lib_Arb_Arb_Rgamma(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_rgamma, res, x);
}


void Lib_Arb_Arb_Lgamma(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_lgamma, res, x);
}


void Lib_Arb_Arb_RisingFactorial(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_rising, res, x, y);
}


void Lib_Arb_Arb_Beta(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_beta_, res, x, y);
}





/* Incomplete gamma functions */



void Lib_Arb_Arb_GammaUpper(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_gamma_upper_, res, x, y);
}


void Lib_Arb_Arb_GammaUpperR(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_gamma_upper_r, res, x, y);
}


void Lib_Arb_Arb_GammaLower(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_gamma_lower_, res, x, y);
}
//
//
//void Lib_Arb_Arb_GammaLowerR(ArbPtr res, const ArbPtr x, const ArbPtr y)
//{
//    Arb_Arb_Realfunc2_Prec(arb_gamma_lower_r, res, x, y);
//}



void Lib_Arb_Arb_GammaPPrime(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_gamma_p_derivative, res, x, y);
}


void Lib_Arb_Arb_GammaP(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_gamma_p, res, x, y);
}


void Lib_Arb_Arb_GammaQ(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_gamma_q, res, x, y);
}





/* Error function and related functions */


void Lib_Arb_Arb_Erf(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_erf, res, x);
}


void Lib_Arb_Arb_Erfc(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_erfc, res, x);
}


void Lib_Arb_Arb_ErfInv(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_erfinv, res, x);
}


void Lib_Arb_Arb_ErfcInv(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_erfcinv, res, x);
}


void Lib_Arb_Arb_Erfi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_erfi, res, x);
}


void Lib_Arb_Arb_FresnelC(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_fresnelc, res, x);
}


void Lib_Arb_Arb_FresnelS(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_fresnels, res, x);
}


void Lib_Arb_Arb_Ndens(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_ndens, res, x);
}


void Lib_Arb_Arb_Ndis(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_ndis, res, x);
}







/* Exponential integrals and related functions */



void Lib_Arb_Arb_ExpIntegralE(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_expint, res, x, y);
}



void Lib_Arb_Arb_ExpIntegralEi(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_ei, res, x);
}


void Lib_Arb_Arb_SinIntegral(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_si, res, x);
}


void Lib_Arb_Arb_CosIntegral(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_ci, res, x);
}


void Lib_Arb_Arb_SinhIntegral(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_shi, res, x);
}


void Lib_Arb_Arb_CoshIntegral(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_chi, res, x);
}


void Lib_Arb_Arb_LogIntegral(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_li_, res, x);
}


void Lib_Arb_Arb_LogIntegralOffset(ArbPtr res, const ArbPtr x)
{
    Arb_Arb_Realfunc1_Prec(arb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_Arb_Arb_HermiteH(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_hermite_h, res, x, y);
}


void Lib_Arb_Arb_LaguerreL(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_laguerre_l, res, a, b, z);
}




/* 1F1: Coulomb functions */


void Lib_Arb_Arb_CoulombF(ArbPtr res, const ArbPtr l, const ArbPtr eta, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_Arb_Arb_CoulombG(ArbPtr res, const ArbPtr l, const ArbPtr eta, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_coulomb_g, res, l, eta, z);
}






/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_Arb_Arb_Hypgeom2F1(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr c, const ArbPtr z)
{
    Arb_Arb_Realfunc4_Prec(arb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_Arb_Arb_Hypgeom2F1r(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr c, const ArbPtr z)
{
    Arb_Arb_Realfunc4_Prec(arb_hypgeom_2f1r_, res, a, b, c, z);
}





/* 2F1: Orthogonal polynomials */


void Lib_Arb_Arb_ChebyshevT(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_Arb_Arb_ChebyshevU(ArbPtr res, const ArbPtr x, const ArbPtr y)
{
    Arb_Arb_Realfunc2_Prec(arb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_Arb_Arb_GegenbauerC(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_Arb_Arb_LegendreP(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_Arb_Arb_LegendrePv(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_Arb_Arb_LegendreQ(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_Arb_Arb_LegendreQv(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_legendre_qv_, res, a, b, z);
}


void Lib_Arb_Arb_JacobiP(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr c, const ArbPtr z)
{
    Arb_Arb_Realfunc4_Prec(arb_hypgeom_jacobi_p, res, a, b, c, z);
}





/* 2F1: Incomplete Beta Function */


void Lib_Arb_Arb_BetaLower(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_, res, a, b, z);
}


//void Lib_Arb_Arb_BetaLowerR(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
//{
//    Arb_Arb_Realfunc3_Prec(arb_hypgeom_beta_lower_r_, res, a, b, z);
//}



void Lib_Arb_Arb_Ibeta(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_ibeta, res, a, b, z);
}


void Lib_Arb_Arb_Ibetac(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_ibetac, res, a, b, z);
}



void Lib_Arb_Arb_IbetaPrime(ArbPtr res, const ArbPtr a, const ArbPtr b, const ArbPtr z)
{
    Arb_Arb_Realfunc3_Prec(arb_ibeta_derivative, res, a, b, z);
}






/* Hypergeometric Function 1F2, overview */


void Lib_Arb_Arb_Hypgeom1F2(ArbPtr res, const ArbPtr a1, const ArbPtr b1, const ArbPtr b2, const ArbPtr z)
{
    Arb_Arb_Realfunc4_Prec(arb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_Arb_Arb_Hypgeom1F2r(ArbPtr res, const ArbPtr a1, const ArbPtr b1, const ArbPtr b2, const ArbPtr z)
{
    Arb_Arb_Realfunc4_Prec(arb_hypgeom_1f2r_, res, a1, b1, b2, z);
}











//////////////////////////////////////////////////////
//// Acb functions
//////////////////////////////////////////////////////








/* Roots and quadratic, cubic, and quartic equations */


void Lib_Acb_Acb_UnitRoot_ui(AcbPtr res, const int32_t n)
{
    Acb_Acb_Cplxfunc0Int32_Prec(acb_unit_root_, res, n);
}


void Lib_Acb_Acb_Sqrt(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sqrt, res, x);
}


void Lib_Acb_Acb_Rsqrt(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_rsqrt, res, x);
}


void Lib_Acb_Acb_Cbrt(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_cbrt, res, x);
}


void Lib_Acb_Acb_Sqrt1pm1(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sqrt1pm1, res, x);
}


void Lib_Acb_Acb_Root_Si(AcbPtr res, const AcbPtr x, const int32_t n)
{
    Acb_Acb_Cplxfunc1Int32_Prec(acb_root_si_, res, x, n);
}






/* Exponential and related functions */


void Lib_Acb_Acb_Exp(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_exp, res, x);
}


void Lib_Acb_Acb_Expj(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_expj_, res, x);
}


void Lib_Acb_Acb_Expjpi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_exp_pi_i, res, x);
}


void Lib_Acb_Acb_Expm1(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_expm1, res, x);
}


void Lib_Acb_Acb_Exp10(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_exp10_, res, x);
}


void Lib_Acb_Acb_Exp2(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_exp2_, res, x);
}


void Lib_Acb_Acb_Exp10m1(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_exp10m1_, res, x);
}


void Lib_Acb_Acb_Exp2m1(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_exp2m1_, res, x);
}


void Lib_Acb_Acb_ExpRel(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_exprel_, res, x);
}






/* Logarithms and related functions */



void Lib_Acb_Acb_Log(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_log, res, x);
}


void Lib_Acb_Acb_Logbase(AcbPtr res, const AcbPtr x, const AcbPtr b)
{
    Acb_Acb_Cplxfunc2_Prec(acb_logbase_, res, x, b);
}


void Lib_Acb_Acb_Log1p(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_log1p, res, x);
}


void Lib_Acb_Acb_Log10(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_log10_, res, x);
}


void Lib_Acb_Acb_Log2(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_log2_, res, x);
}


void Lib_Acb_Acb_Log10p1(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_log10p1_, res, x);
}



void Lib_Acb_Acb_Log2p1(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_log2p1_, res, x);
}




void Lib_Acb_Acb_LambertW_ui(AcbPtr res, const AcbPtr x, const int32_t n)
{
    Acb_Acb_Cplxfunc1Int32_Prec(acb_lambertw_ui_, res, x, n);
}







/* Power functions */


void Lib_Acb_Acb_Square(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sqr, res, x);
}


void Lib_Acb_Acb_Cube(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_cube, res, x);
}


void Lib_Acb_Acb_Pow_si(AcbPtr res, const AcbPtr x, const int32_t n)
{
    Acb_Acb_Cplxfunc1Int32_Prec(acb_pow_si_, res, x, n);
}



void Lib_Acb_Acb_Hypot(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypot_, res, x, y);
}


void Lib_Acb_Acb_Pow(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_pow, res, x, y);
}


void Lib_Acb_Acb_Powm1(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_powm1_, res, x, y);
}


void Lib_Acb_Acb_Pow1p(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_pow1p_, res, x, y);
}


void Lib_Acb_Acb_Pow1pm1(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_pow1pm1_, res, x, y);
}







/* Trigonometric and related functions */



void Lib_Acb_Acb_Sin(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sin, res, x);
}


void Lib_Acb_Acb_Cos(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_cos, res, x);
}


void Lib_Acb_Acb_Tan(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_tan, res, x);
}



void Lib_Acb_Acb_Csc(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_csc, res, x);
}


void Lib_Acb_Acb_Sec(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sec, res, x);
}


void Lib_Acb_Acb_Cot(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_cot, res, x);
}


void Lib_Acb_Acb_SinPi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sin_pi, res, x);
}


void Lib_Acb_Acb_CosPi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_cos_pi, res, x);
}


void Lib_Acb_Acb_TanPi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_tan_pi, res, x);
}


void Lib_Acb_Acb_CotPi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_cot_pi, res, x);
}


void Lib_Acb_Acb_CscPi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_csc_pi, res, x);
}


void Lib_Acb_Acb_SecPi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sec_pi_, res, x);
}





void Lib_Acb_Acb_Sinc(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sinc, res, x);
}

void Lib_Acb_Acb_SincPi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sinc_pi, res, x);
}




/* Hyperbolic functions */


void Lib_Acb_Acb_Sinh(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sinh, res, x);
}


void Lib_Acb_Acb_Cosh(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_cosh, res, x);
}


void Lib_Acb_Acb_Tanh(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_tanh, res, x);
}



void Lib_Acb_Acb_Csch(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_csch, res, x);
}


void Lib_Acb_Acb_Sech(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_sech, res, x);
}


void Lib_Acb_Acb_Coth(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_coth, res, x);
}






/* Inverse trigonometric functions */


void Lib_Acb_Acb_Asin(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_asin, res, x);
}


void Lib_Acb_Acb_Acos(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_acos, res, x);
}


void Lib_Acb_Acb_Atan(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_atan, res, x);
}



void Lib_Acb_Acb_Acsc(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_acsc, res, x);
}


void Lib_Acb_Acb_Asec(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_asec, res, x);
}


void Lib_Acb_Acb_Acot(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_acot, res, x);
}







/* Inverse hyperbolic functions */


void Lib_Acb_Acb_Asinh(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_asinh, res, x);
}


void Lib_Acb_Acb_Acosh(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_acosh, res, x);
}


void Lib_Acb_Acb_Atanh(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_atanh, res, x);
}



void Lib_Acb_Acb_Acsch(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_acsch, res, x);
}


void Lib_Acb_Acb_Asech(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_asech, res, x);
}


void Lib_Acb_Acb_Acoth(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_acoth, res, x);
}









/* Legendre elliptic integrals (elliptic parameter m) */


void Lib_Acb_Acb_MEllipticK(AcbPtr res, const AcbPtr m)
{
    Acb_Acb_Cplxfunc1_Prec(acb_elliptic_k, res, m);
}


void Lib_Acb_Acb_MEllipticE(AcbPtr res, const AcbPtr m)
{
    Acb_Acb_Cplxfunc1_Prec(acb_elliptic_e, res, m);
}


void Lib_Acb_Acb_MEllipticPi(AcbPtr res, const AcbPtr phi, const AcbPtr m)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_pi, res, phi, m);

}


void Lib_Acb_Acb_MEllipticF(AcbPtr res, const AcbPtr phi, const AcbPtr m)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_f_, res, phi, m);

}


void Lib_Acb_Acb_MEllipticEInc(AcbPtr res, const AcbPtr n, const AcbPtr m)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_, res, n, m);
}


void Lib_Acb_Acb_MEllipticPiInc(AcbPtr res, const AcbPtr n, const AcbPtr phi, const AcbPtr m)
{
    Acb_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_, res, n, phi, m);
}







/* Legendre elliptic integrals (elliptic modulus k), and related functions */



void Lib_Acb_Acb_EllipticK(AcbPtr res, const AcbPtr k)
{
    Acb_Acb_Cplxfunc1_Prec(acb_elliptic_k_k_, res, k);
}


void Lib_Acb_Acb_EllipticE(AcbPtr res, const AcbPtr k)
{
    Acb_Acb_Cplxfunc1_Prec(acb_elliptic_e_k_, res, k);
}


void Lib_Acb_Acb_EllipticPi(AcbPtr res, const AcbPtr phi, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_pi_k_, res, phi, k);

}


void Lib_Acb_Acb_EllipticF(AcbPtr res, const AcbPtr phi, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_f_k_, res, phi, k);

}


void Lib_Acb_Acb_EllipticEInc(AcbPtr res, const AcbPtr n, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_e_inc_k_, res, n, k);
}


void Lib_Acb_Acb_EllipticPiInc(AcbPtr res, const AcbPtr n, const AcbPtr phi, const AcbPtr k)
{
    Acb_Acb_Cplxfunc3_Prec(acb_elliptic_pi_inc_k_, res, n, phi, k);
}



void Lib_Acb_Acb_Agm(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_agm, res, x, y);
}




/* Carlson symmetric elliptic integrals */

void Lib_Acb_Acb_Elliptic_RC(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_rc_, res, x, y);
}



void Lib_Acb_Acb_Elliptic_RF(AcbPtr res, const AcbPtr x, const AcbPtr y, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_elliptic_rf_, res, x, y, z);
}


void Lib_Acb_Acb_Elliptic_RG(AcbPtr res, const AcbPtr x, const AcbPtr y, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_elliptic_rg_, res, x, y, z);
}


void Lib_Acb_Acb_Elliptic_RD(AcbPtr res, const AcbPtr x, const AcbPtr y, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_elliptic_rd_, res, x, y, z);
}


void Lib_Acb_Acb_Elliptic_RJ(AcbPtr res, const AcbPtr x, const AcbPtr y, const AcbPtr z, const AcbPtr w)
{
    Acb_Acb_Cplxfunc4_Prec(acb_elliptic_rj_, res, x, y, z, w);
}






/* Jacobi theta functions */


void Lib_Acb_Acb_Theta1Q(AcbPtr res, const AcbPtr z, const AcbPtr q)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_theta1q, res, z, q);
}


void Lib_Acb_Acb_Theta2Q(AcbPtr res, const AcbPtr z, const AcbPtr q)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_theta2q, res, z, q);
}


void Lib_Acb_Acb_Theta3Q(AcbPtr res, const AcbPtr z, const AcbPtr q)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_theta3q, res, z, q);
}


void Lib_Acb_Acb_Theta4Q(AcbPtr res, const AcbPtr z, const AcbPtr q)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_theta4q, res, z, q);
}



void Lib_Acb_Acb_Theta1Tau(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_theta1, res, z, tau);
}


void Lib_Acb_Acb_Theta2Tau(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_theta2, res, z, tau);
}


void Lib_Acb_Acb_Theta3Tau(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_theta3, res, z, tau);
}


void Lib_Acb_Acb_Theta4Tau(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_theta4, res, z, tau);
}







/* Jacobi elliptic functions */


void Lib_Acb_Acb_QfromK(AcbPtr res, const AcbPtr k)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_qfromk, res, k);
}


void Lib_Acb_Acb_TfromUQ(AcbPtr res, const AcbPtr u, const AcbPtr q)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_tfrom_u_q, res, u, q);
}


void Lib_Acb_Acb_SnTQ(AcbPtr res, const AcbPtr t, const AcbPtr q)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_sn_t_q, res, t, q);
}


void Lib_Acb_Acb_CnTQ(AcbPtr res, const AcbPtr t, const AcbPtr q)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_cn_t_q, res, t, q);
}


void Lib_Acb_Acb_DnTQ(AcbPtr res, const AcbPtr t, const AcbPtr q)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_dn_t_q, res, t, q);
}


void Lib_Acb_Acb_JacobiSN(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_sn, res, u, k);
}


void Lib_Acb_Acb_JacobiCN(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_cn, res, u, k);
}


void Lib_Acb_Acb_JacobiDN(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_dn, res, u, k);
}





void Lib_Acb_Acb_JacobiNS(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_ns, res, u, k);
}


void Lib_Acb_Acb_JacobiNC(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_nc, res, u, k);
}


void Lib_Acb_Acb_JacobiND(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_nd, res, u, k);
}




void Lib_Acb_Acb_JacobiSC(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_sc, res, u, k);
}


void Lib_Acb_Acb_JacobiSD(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_sd, res, u, k);
}




void Lib_Acb_Acb_JacobiDC(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_dc, res, u, k);
}


void Lib_Acb_Acb_JacobiDS(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_ds, res, u, k);
}




void Lib_Acb_Acb_JacobiCS(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_cs, res, u, k);
}


void Lib_Acb_Acb_JacobiCD(AcbPtr res, const AcbPtr u, const AcbPtr k)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_jacobi_cd, res, u, k);
}







/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


void Lib_Acb_Acb_WeierstrassP(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_p, res, z, tau);
}


void Lib_Acb_Acb_WeierstrassPInv(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_inv_p, res, z, tau);
}


void Lib_Acb_Acb_WeierstrassPZeta(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_zeta, res, z, tau);
}


void Lib_Acb_Acb_WeierstrassPSigma(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(acb_elliptic_sigma, res, z, tau);
}



void Lib_Acb_Acb_WeierstrassPPrime(AcbPtr res, const AcbPtr z, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_wp_prime, res, z, tau);
}



void Lib_Acb_Acb_EllipticInvariantG2(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g2, res, tau);
}


void Lib_Acb_Acb_EllipticInvariantG3(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_elliptic_invariant_g3, res, tau);
}


void Lib_Acb_Acb_EllipticRootE1(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e1, res, tau);
}


void Lib_Acb_Acb_EllipticRootE2(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e2, res, tau);
}


void Lib_Acb_Acb_EllipticRootE3(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_elliptic_root_e3, res, tau);
}



void Lib_Acb_Acb_DedekindEta(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(acb_modular_eta, res, tau);
}


void Lib_Acb_Acb_KleinJ(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(acb_modular_j, res, tau);
}


void Lib_Acb_Acb_ModularLambda(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(acb_modular_lambda, res, tau);
}


void Lib_Acb_Acb_ModularDelta(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(acb_modular_delta, res, tau);
}




/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */






/* Lerch’s transcendent: overview */


void Lib_Acb_Acb_LerchPhi(AcbPtr res, const AcbPtr z, const AcbPtr s, const AcbPtr a)
{
    Acb_Acb_Cplxfunc3_Prec(acb_dirichlet_lerch_phi, res, z, s, a);
}


void Lib_Acb_Acb_LerchZeta(AcbPtr res, const AcbPtr lambda1, const AcbPtr alpha, const AcbPtr s)
{
    Acb_Acb_Cplxfunc3_Prec(_acb_lerch_zeta, res, lambda1, alpha, s);
}


/* Polygamma functions */


void Lib_Acb_Acb_Polygamma(AcbPtr res, const AcbPtr s, const AcbPtr z)
{
    Acb_Acb_Cplxfunc2_Prec(acb_polygamma, res, s, z);
}


void Lib_Acb_Acb_Trigamma(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_trigamma, res, x);
}


void Lib_Acb_Acb_Digamma(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_digamma, res, x);
}



/* Polylogarithms and related functions */


void Lib_Acb_Acb_Polylog(AcbPtr res, const AcbPtr s, const AcbPtr z)
{
    Acb_Acb_Cplxfunc2_Prec(acb_polylog, res, s, z);
}


void Lib_Acb_Acb_Trilog(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_trilog, res, x);
}


void Lib_Acb_Acb_Dilog(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_dilog, res, x);
}



void Lib_Acb_Acb_ClausenSin(AcbPtr res, const AcbPtr s, const AcbPtr z)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_clausen_sin, res, s, z);
}


void Lib_Acb_Acb_ClausenCos(AcbPtr res, const AcbPtr s, const AcbPtr z)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_clausen_cos, res, s, z);
}


void Lib_Acb_Acb_Clausen2(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_clausen2, res, x);
}


void Lib_Acb_Acb_BoseEinstein(AcbPtr res, const AcbPtr s, const AcbPtr z)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_bose_einstein, res, s, z);
}


void Lib_Acb_Acb_FermiDirac(AcbPtr res, const AcbPtr s, const AcbPtr z)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_fermi_dirac, res, s, z);
}


void Lib_Acb_Acb_LegendreChi(AcbPtr res, const AcbPtr s, const AcbPtr z)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_legendre_chi, res, s, z);
}


void Lib_Acb_Acb_InverseTanIntegral(AcbPtr res, const AcbPtr s, const AcbPtr z)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_ti, res, s, z);
}





/* Hurwitz zeta function and related functions */




void Lib_Acb_Acb_HurwitzZeta(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hurwitz_zeta, res, x, y);
}


void Lib_Acb_Acb_Stieltjes_ui(AcbPtr res, const AcbPtr x, const int32_t n)
{
    Acb_Acb_Cplxfunc1Int32_Prec(acb_stieltjes_ui_, res, x, n);
}


void Lib_Acb_Acb_BernoulliPoly_ui(AcbPtr res, const AcbPtr x, const int32_t n)
{
    Acb_Acb_Cplxfunc1Int32_Prec(acb_bernoulli_poly_ui_, res, x, n);
}



void Lib_Acb_Acb_Harmonic(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_harmonic, res, x);
}


void Lib_Acb_Acb_Harmonic2(AcbPtr res, const AcbPtr z, const AcbPtr r)
{
    Acb_Acb_Cplxfunc2_Prec(_acb_harmonic2, res, z, r);
}


void Lib_Acb_Acb_EulerPoly_ui(AcbPtr res, const AcbPtr x, const int32_t n)
{
    Acb_Acb_Cplxfunc1Int32_Prec(acb_euler_poly_ui_, res, x, n);
}


void Lib_Acb_Acb_Hyperfactorial(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_hyperfac, res, x);
}


void Lib_Acb_Acb_Superfactorial(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_superfac, res, x);
}


void Lib_Acb_Acb_BarnesG(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_barnes_g, res, x);
}


void Lib_Acb_Acb_LogBarnesG(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_log_barnes_g, res, x);
}





/* Riemann zeta function, and related functions */


void Lib_Acb_Acb_Zeta(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_zeta, res, x);
}


void Lib_Acb_Acb_Zetam1(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_zetam1, res, x);
}


void Lib_Acb_Acb_ZetaZero_ui(AcbPtr res, const int32_t n)
{
    Acb_Acb_Cplxfunc0Int32_Prec(acb_dirichlet_zeta_zero_ui_, res, n);
}


void Lib_Acb_Acb_DirichletXi(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(acb_dirichlet_xi, res, tau);
}


void Lib_Acb_Acb_DirichletEta(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(acb_dirichlet_eta, res, tau);
}


void Lib_Acb_Acb_DirichletEtam1(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_dirichlet_etam1, res, x);
}


void Lib_Acb_Acb_DirichletBeta(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_dirichlet_beta, res, x);
}


void Lib_Acb_Acb_DirichletLambda(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(_acb_dirichlet_lambda, res, x);
}



/* Riemann-Siegel Z-function */
void Lib_Acb_Acb_HardyZ(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_z_, res, tau);
}

/* rstheta(z) in amath */
void Lib_Acb_Acb_HardyTheta(AcbPtr res, const AcbPtr tau)
{
    Acb_Acb_Cplxfunc1_Prec(acb_dirichlet_hardy_theta_, res, tau);
}









/* Additional numbertheoretic functions */




/* Confluent Hypergeometric Limit Function 0F1, overview */


void Lib_Acb_Acb_Hypgeom0F1(AcbPtr res, const AcbPtr a, const AcbPtr x)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_, res, a, x);
}


void Lib_Acb_Acb_Hypgeom0F1r(AcbPtr res, const AcbPtr a, const AcbPtr x)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_0f1_r, res, a, x);
}





/* Bessel functions and modified Bessel functions  */



void Lib_Acb_Acb_BesselJ(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_j, res, x, y);
}


void Lib_Acb_Acb_BesselY(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_y, res, x, y);
}


void Lib_Acb_Acb_BesselI(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i, res, x, y);
}


void Lib_Acb_Acb_BesselK(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k, res, x, y);
}


void Lib_Acb_Acb_BesselIScaled(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_i_scaled, res, x, y);
}


void Lib_Acb_Acb_BesselKScaled(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_bessel_k_scaled, res, x, y);
}





/* Spherical Bessel functions  */




/* Airy functions  */


void Lib_Acb_Acb_AiryAi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_airy_ai, res, x);
}


void Lib_Acb_Acb_AiryAiPrime(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_airy_ai_prime, res, x);
}


void Lib_Acb_Acb_AiryBi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_airy_bi, res, x);
}


void Lib_Acb_Acb_AiryBiPrime(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_airy_bi_prime, res, x);
}





/* Kelvin functions  */





/* Kummer’s Confluent Hypergeometric Function 1F1 */



void Lib_Acb_Acb_Hypgeom1F1(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1_, res, a, b, z);
}


void Lib_Acb_Acb_Hypgeom1F1r(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_1f1r_, res, a, b, z);
}


void Lib_Acb_Acb_HypgeomU(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_u, res, a, b, z);
}





/* Gamma function and related functions */


void Lib_Acb_Acb_Gamma(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_gamma, res, x);
}


void Lib_Acb_Acb_Rgamma(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_rgamma, res, x);
}


void Lib_Acb_Acb_Lgamma(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_lgamma, res, x);
}


void Lib_Acb_Acb_RisingFactorial(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_rising, res, x, y);
}


void Lib_Acb_Acb_Beta(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_beta_, res, x, y);
}






/* Incomplete gamma functions */


void Lib_Acb_Acb_GammaUpper(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_gamma_upper_, res, x, y);
}



void Lib_Acb_Acb_GammaLower(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_gamma_lower_, res, x, y);
}



void Lib_Acb_Acb_GammaPPrime(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_gamma_p_derivative, res, x, y);
}


void Lib_Acb_Acb_GammaP(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_gamma_p, res, x, y);
}


void Lib_Acb_Acb_GammaQ(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_gamma_q, res, x, y);
}







/* Error function and related functions */


void Lib_Acb_Acb_Erf(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_erf, res, x);
}


void Lib_Acb_Acb_Erfc(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_erfc, res, x);
}


void Lib_Acb_Acb_Erfi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_erfi, res, x);
}



void Lib_Acb_Acb_FresnelC(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_fresnelc, res, x);
}


void Lib_Acb_Acb_FresnelS(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_fresnels, res, x);
}


void Lib_Acb_Acb_Ndens(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_ndens, res, x);
}


void Lib_Acb_Acb_Ndis(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_ndis, res, x);
}






/* Exponential integrals and related functions */


void Lib_Acb_Acb_ExpIntegralE(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_expint, res, x, y);
}



void Lib_Acb_Acb_ExpIntegralEi(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_ei, res, x);
}


void Lib_Acb_Acb_SinIntegral(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_si, res, x);
}


void Lib_Acb_Acb_CosIntegral(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_ci, res, x);
}


void Lib_Acb_Acb_SinhIntegral(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_shi, res, x);
}


void Lib_Acb_Acb_CoshIntegral(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_chi, res, x);
}


void Lib_Acb_Acb_LogIntegral(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_li_, res, x);
}


void Lib_Acb_Acb_LogIntegralOffset(AcbPtr res, const AcbPtr x)
{
    Acb_Acb_Cplxfunc1_Prec(acb_hypgeom_li_offset, res, x);
}






/* 1F1: Orthogonal polynomials */


void Lib_Acb_Acb_HermiteH(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_hermite_h, res, x, y);
}


void Lib_Acb_Acb_LaguerreL(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_laguerre_l, res, a, b, z);
}





/* 1F1: Coulomb functions */



void Lib_Acb_Acb_CoulombF(AcbPtr res, const AcbPtr l, const AcbPtr eta, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_f, res, l, eta, z);
}


void Lib_Acb_Acb_CoulombG(AcbPtr res, const AcbPtr l, const AcbPtr eta, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_g, res, l, eta, z);
}


void Lib_Acb_Acb_CoulombHpos(AcbPtr res, const AcbPtr l, const AcbPtr eta, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hpos, res, l, eta, z);
}


void Lib_Acb_Acb_CoulombHneg(AcbPtr res, const AcbPtr l, const AcbPtr eta, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_coulomb_hneg, res, l, eta, z);
}







/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void Lib_Acb_Acb_Hypgeom2F1(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr c, const AcbPtr z)
{
    Acb_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1_, res, a, b, c, z);
}


void Lib_Acb_Acb_Hypgeom2F1r(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr c, const AcbPtr z)
{
    Acb_Acb_Cplxfunc4_Prec(acb_hypgeom_2f1r_, res, a, b, c, z);
}



/* 2F1: Orthogonal polynomials */


void Lib_Acb_Acb_ChebyshevT(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_t, res, x, y);
}


void Lib_Acb_Acb_ChebyshevU(AcbPtr res, const AcbPtr x, const AcbPtr y)
{
    Acb_Acb_Cplxfunc2_Prec(acb_hypgeom_chebyshev_u, res, x, y);
}


void Lib_Acb_Acb_GegenbauerC(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_gegenbauer_c, res, a, b, z);
}


void Lib_Acb_Acb_LegendreP(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_p_, res, a, b, z);
}


void Lib_Acb_Acb_LegendrePv(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_pv_, res, a, b, z);
}


void Lib_Acb_Acb_LegendreQ(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_q_, res, a, b, z);
}


void Lib_Acb_Acb_LegendreQv(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_legendre_qv_, res, a, b, z);
}



void Lib_Acb_Acb_JacobiP(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr c, const AcbPtr z)
{
    Acb_Acb_Cplxfunc4_Prec(acb_hypgeom_jacobi_p, res, a, b, c, z);
}


void Lib_Acb_Acb_SphericalY(AcbPtr res, const AcbPtr n, const AcbPtr m, const AcbPtr theta, const AcbPtr phi)
{
    Acb_Acb_Cplxfunc4_Prec(_acb_hypgeom_spherical_y, res, n, m, theta, phi);
}





/* 2F1: Incomplete Beta Function */


void Lib_Acb_Acb_BetaLower(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_hypgeom_beta_lower_, res, a, b, z);
}




void Lib_Acb_Acb_Ibeta(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_ibeta, res, a, b, z);
}


void Lib_Acb_Acb_Ibetac(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_ibetac, res, a, b, z);
}



void Lib_Acb_Acb_IbetaPrime(AcbPtr res, const AcbPtr a, const AcbPtr b, const AcbPtr z)
{
    Acb_Acb_Cplxfunc3_Prec(acb_ibeta_derivative, res, a, b, z);
}



/* Hypergeometric Function 1F2, overview */



void Lib_Acb_Acb_Hypgeom1F2(AcbPtr res, const AcbPtr a1, const AcbPtr b1, const AcbPtr b2, const AcbPtr z)
{
    Acb_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2_, res, a1, b1, b2, z);
}


void Lib_Acb_Acb_Hypgeom1F2r(AcbPtr res, const AcbPtr a1, const AcbPtr b1, const AcbPtr b2, const AcbPtr z)
{
    Acb_Acb_Cplxfunc4_Prec(acb_hypgeom_1f2r_, res, a1, b1, b2, z);
}




