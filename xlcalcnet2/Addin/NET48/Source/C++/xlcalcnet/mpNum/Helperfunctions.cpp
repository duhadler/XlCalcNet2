
#include "Helperfunctions.h"


#define  MaxValueInt64  std::numeric_limits<int64_t>::max()
#define  MinValueInt64  std::numeric_limits<int64_t>::min()

#define  MaxValueUInt64  std::numeric_limits<uint64_t>::max()
#define  MinValueUInt64  std::numeric_limits<uint64_t>::min()

#define  MaxValueInt32  std::numeric_limits<int32_t>::max()
#define  MinValueInt32  std::numeric_limits<int32_t>::min()

#define  MaxValueUInt32  std::numeric_limits<uint32_t>::max()
#define  MinValueUInt32  std::numeric_limits<uint32_t>::min()






void mpfr_set_oct(MpfrPtr res, ORealPtr x)
{
    boost::multiprecision::cpp_bin_float_oct d = *(boost::multiprecision::cpp_bin_float_oct*)x;
    std::stringstream ss;
    ss.precision(std::numeric_limits<boost::multiprecision::cpp_bin_float_oct>::digits10+2);
    ss << d ;
    mpfr_set_str((mpfr_ptr)res, ss.str().c_str(), 10, MPFR_RNDN);
}



void oct_set_arb(ORealPtr res, arb_t x)
{
	char * cstr = arb_get_str(x, 237, ARB_STR_NO_RADIUS);
    (*(boost::multiprecision::cpp_bin_float_oct*)res) = static_cast<boost::multiprecision::cpp_bin_float_oct>(string(cstr));
    free(cstr);
}


//
//void oct_set_mpfr(ORealPtr res, arb_t x)
//{
//	char * cstr = mpfr_get_str(x, 237, ARB_STR_NO_RADIUS);
//    (*(boost::multiprecision::cpp_bin_float_oct*)res) = static_cast<boost::multiprecision::cpp_bin_float_oct>(string(cstr));
//    free(cstr);
//}
//



void mpfr_set_cppoct(mpfr_t res, boost::multiprecision::cpp_bin_float_oct d)
{
    std::stringstream ss;
    ss.precision(std::numeric_limits<boost::multiprecision::cpp_bin_float_oct>::digits10+2);
    ss << d ;
    mpfr_set_str((mpfr_ptr)res, ss.str().c_str(), 10, MPFR_RNDN);
}


void mpfc_set_octc(mpc_t res, OCplxPtr x)
{
    boost::multiprecision::cpp_bin_float_oct re = (*(std::complex<boost::multiprecision::cpp_bin_float_oct>*) x).real();
    boost::multiprecision::cpp_bin_float_oct im = (*(std::complex<boost::multiprecision::cpp_bin_float_oct>*) x).imag();
	mpfr_set_cppoct (res->re, re);
	mpfr_set_cppoct (res->im, im);
}



void octc_set_acb(OCplxPtr res, acb_t x)
{
	char * str_re = arb_get_str(acb_realref(x), 237, ARB_STR_NO_RADIUS);
	char * str_im = arb_get_str(acb_imagref(x), 237, ARB_STR_NO_RADIUS);
    boost::multiprecision::cpp_bin_float_oct re = static_cast<boost::multiprecision::cpp_bin_float_oct>(string(str_re));
    boost::multiprecision::cpp_bin_float_oct im = static_cast<boost::multiprecision::cpp_bin_float_oct>(string(str_im));
	(*(std::complex<boost::multiprecision::cpp_bin_float_oct>*) res) = std::complex<boost::multiprecision::cpp_bin_float_oct>(re, im);
    free(str_re); free(str_im);
}








int32_t int64_fits_int32(int64_t x)
{
	int32_t res = 0;
	if ((x >= MinValueInt32) && (x <= MaxValueInt32)) res = 1;
	return res;
}


int32_t uint64_fits_uint32(uint64_t x)
{
	int32_t res = 0;
	if ((x >= MinValueUInt32) && (x <= MaxValueUInt32)) res = 1;
	return res;
}


/* **************** FMPZ ************************ */
//
//

void fmpz_set_ui64(fmpz_t x, uint64_t uint64)
{
    fmpz_set_ui(x, uint64);
}


void fmpz_set_si64(fmpz_t x, int64_t sint64)
{
    fmpz_set_si(x, sint64);
}


int32_t fmpz_is_finite(fmpz_t x)
{
	return true;
}



int32_t fmpz_fits_uint64(fmpz_t x)
{
	int32_t res = 0;
	if (fmpz_is_finite(x))
	{
		fmpz_t t; fmpz_init(t);
		fmpz_set_ui64(t, MinValueUInt64);
		int lowerbound = fmpz_cmp(x, t);
		fmpz_set_ui64(t, MaxValueUInt64);
		int upperbound = fmpz_cmp(t, x);
		fmpz_clear(t);
		res = ((lowerbound >= 0) && (upperbound >= 0));
	}
	return res;
}


uint64_t fmpz_get_ui64_(fmpz_t x)
{
    return fmpz_get_ui(x);
}


uint64_t fmpz_get_ui64(fmpz_t x)
{
	uint64_t res = 0;
	if (fmpz_is_finite(x))
	{
		int fits = fmpz_fits_uint64(x);
		if (fits != 0) res = fmpz_get_ui64_(x);
	}
	return res;
}

/* **************** MPFR ************************ */




void Lib_Mpfr_Set_Default_Prec (int32_t prec)
{
    mpfr_set_default_prec ((mpfr_prec_t) prec);
}


int32_t Lib_Mpfr_Get_Default_Prec (void)
{
    return (int32_t) mpfr_get_default_prec ();
}


int mpfr_one_p(mpfr_t in1)
{
    return (mpfr_cmp_si(in1, 1) == 0);
}

void mpfr_set_ui64(mpfr_t x, uint64_t uint64)
{
    mpfr_set_uj(x, uint64, MPFR_RNDN);
}



void mpfr_set_si64(mpfr_t x, int64_t sint64)
{
    mpfr_set_sj(x, sint64, MPFR_RNDN);
}


void mpfr_set_fmpz(mpfr_t x, fmpz_t z)
{
    fmpz_get_mpfr (x, z, MPFR_RNDN);
}



void mpfr_set_fmpq(mpfr_t x, fmpq_t z)
{
    fmpq_get_mpfr (x, z, MPFR_RNDN);
}



void mpfr_set_arb(mpfr_t x, arb_t z)
{
    arf_get_mpfr(x, arb_midref(z), MPFR_RNDN);
}



double cosm1_(double x)
{
    if (std::abs(x) > 0.5)
    {
        return std::cos(x) - 1;
    }
    else
    {
        double res = sin((x)/2);
        return  -2 * res * res;
    }
}



void mpfr_const_degree(mpfr_t res, mpfr_rnd_t rnd)
{
    mpfr_const_pi(res, MPFR_RNDN);
    mpfr_div_si(res, res, 180, MPFR_RNDN);
}


void mpfr_const_phi(mpfr_t res, mpfr_rnd_t rnd)
{
    mpfr_sqrt_ui(res, 5, MPFR_RNDN);
    mpfr_add_ui(res, res, 1, MPFR_RNDN);
    mpfr_div_2ui(res, res, 1, MPFR_RNDN);
}


void mpfr_const_log10(mpfr_t res, mpfr_rnd_t rnd)
{
    mpfr_log_ui(res, 10, MPFR_RNDN);
}


void mpfr_const_e(mpfr_t res, mpfr_rnd_t rnd)
{
    mpfr_t ONE; mpfr_init2(ONE, mpfr_get_default_prec()); mpfr_set_si(ONE, 1, MPFR_RNDN);
    mpfr_exp(res, ONE, MPFR_RNDN);
    mpfr_clear(ONE);
}


void mpfr_const_apery(mpfr_t res, mpfr_rnd_t rnd)
{
    mpfr_zeta_ui(res, 3, MPFR_RNDN);
}





void mpfr_cosm1(mpfr_t res, mpfr_t x, mpfr_rnd_t rnd)
{
    mpfr_abs(res, x, MPFR_RNDN);
    int c = mpfr_cmp_d(res, 0.5);
    if (c >= 0)
    {
        mpfr_cos(res, x, MPFR_RNDN);
        mpfr_sub_si(res, res, 1, MPFR_RNDN);
    }
    else
    {
        mpfr_mul_d(res, x, 0.5, MPFR_RNDN);
        mpfr_sin(res, res, MPFR_RNDN);
        mpfr_sqr(res, res, MPFR_RNDN);
        mpfr_mul_d(res, res, -2.0, MPFR_RNDN);
    }
}




uint64_t mpfr_get_ui64(mpfr_t x)
{
    return mpfr_get_uj(x, MPFR_RNDN);
}


int64_t mpfr_get_si64(mpfr_t x)
{
    return mpfr_get_sj(x, MPFR_RNDN);
}




int64_t mpfr_get_str_sizeinbase10(const char *template1, MpfrPtr x)
{
    // Note: template should be something like "%.12RE", to display 12 digits in scientific notation
    return mpfr_snprintf(NULL, 0, template1, (mpfr_ptr) x);
}


int64_t mpfr_get_str_intern(char* dest , uint32_t digits, const char *template1, MpfrPtr x)
{
    // Note: template should be something like "%.12RE", with digits = 12 to display 12 digits
    return mpfr_snprintf(dest, digits, template1, (mpfr_ptr) x);
}



char *  mpfr_get_str_extern(const char *template1, uint32_t digits, mpfr_t x)
{
    // Note: template should be something like "%.12RE", with digits = 12 to display 12 digits
    char *key;
    //int keylen = mpfr_snprintf(NULL, 0, template1, x) + 10;
    int keylen = mpfr_snprintf(NULL, 0, template1, x) + 50;
    key = (char*)malloc(keylen * sizeof(char));
    mpfr_snprintf(key, digits, template1, x);
    return key;
}


    /* the smallest eps such that x + eps != x */
void mpfr_machine_epsilon_x(mpfr_t res, mpfr_t x, mp_prec_t prec)
{
    mpfr_t xn;
    mpfr_init2(xn, prec);
    mpfr_set(xn, x, MPFR_RNDN);
    if (mpfr_signbit(x) != 0)
    {
        mpfr_neg(xn, xn, MPFR_RNDN);
        mpfr_nextabove(xn);
        mpfr_add(res, xn, x, MPFR_RNDN);
    }
    else
    {
        mpfr_nextabove(xn);
        mpfr_sub(res, xn, x, MPFR_RNDN);
    }
    mpfr_clear(xn);
}



    /* at precision prec, the smallest eps such that 1 + eps != 1 */
void mpfr_machine_epsilon_prec(mpfr_t res, mp_prec_t prec)
{
    mpfr_t one;
    mpfr_init2(one, prec);
    mpfr_set_si(one, 1, MPFR_RNDN);
    mpfr_machine_epsilon_x(res, one, prec);
    mpfr_clear(one);
}



    /* at precision prec, minval = 1/2 * 2^emin = 2^(emin - 1) */
void mpfr_minval_prec(mpfr_t res, mp_prec_t prec)
{
    mpfr_t one;
    mpfr_init2(one, prec);
    mpfr_set_si(one, 1, MPFR_RNDN);
    long emin1 = mpfr_get_emin() - 1;
    mpfr_mul_2si(res, one, emin1, MPFR_RNDN);
    mpfr_clear(one);
}



    /* at precision prec, maxval = (1 - eps) * 2^emax, eps is machine epsilon */
void mpfr_maxval_prec(mpfr_t res, mp_prec_t prec)
{
    mpfr_t eps, one_minus_eps;
    mpfr_init2(eps, prec);
    mpfr_init2(one_minus_eps, prec);
    mpfr_machine_epsilon_prec(eps, prec);
    mpfr_ui_sub(one_minus_eps, 1, eps, MPFR_RNDN);
    mpfr_mul_2si(res, one_minus_eps, mpfr_get_emax(), MPFR_RNDN);
    mpfr_clear(eps);
    mpfr_clear(one_minus_eps);
}



void mpfr_cplx_abs_from_real_and_imag(mpfr_t mp_res, const mpfr_t mp_src_real, const mpfr_t mp_src_imag)
{
	mpc_t z;
	mpc_init2(z, mpfr_get_default_prec());
	mpc_set_fr_fr(z, mp_src_real, mp_src_imag, MPC_RNDNN);
	mpc_abs(mp_res, z, MPFR_RNDN);
	mpc_clear(z);
}





void mpfr_cplx_sqrt_from_real_and_imag(mpfr_t mp_res_real, mpfr_t mp_res_imag, const mpfr_t mp_src_real, const mpfr_t mp_src_imag)
{
	mpc_t z;
	mpc_init2(z, mpfr_get_default_prec());
	mpc_t res;
	mpc_init2(res, mpfr_get_default_prec());
	mpc_set_fr_fr(z, mp_src_real, mp_src_imag, MPC_RNDNN);
	mpc_sqrt(res, z, MPC_RNDNN);
	mpfr_set(mp_res_real, mpc_realref(res), MPFR_RNDN);
	mpfr_set(mp_res_imag, mpc_imagref(res), MPFR_RNDN);
	mpc_clear(z);
	mpc_clear(res);
}






/* **************** MPFC ************************ */



void mpfc_set_ui64(mpc_t x, uint64_t uint64)
{
    fmpz_t z; fmpz_init(z); fmpz_set_ui64(z, uint64);
    fmpz_get_mpfr (mpc_realref(x), z, MPFR_RNDN);
    mpfr_set_si(mpc_imagref(x), 0, MPFR_RNDN);
    fmpz_clear(z);
}



void mpfc_set_si64(mpc_t x, int64_t sint64)
{
    fmpz_t z; fmpz_init(z); fmpz_set_si64(z, sint64);
    fmpz_get_mpfr (mpc_realref(x), z, MPFR_RNDN);
    mpfr_set_si(mpc_imagref(x), 0, MPFR_RNDN);
    fmpz_clear(z);
}



void mpfc_set_fmpz(mpc_t res, fmpz_t x)
{
    mpz_t z; mpz_init(z);  fmpz_get_mpz(z, x);
    mpc_set_z(res, z, MPFR_RNDN);
    mpz_clear(z);
}


void mpfc_set_fmpq(mpc_t res, fmpq_t x)
{
    mpq_t q; mpq_init(q);  fmpq_get_mpq(q, x);
    mpc_set_q(res, q, MPFR_RNDN);
    mpq_clear(q);
}


void mpfc_set_mpfr(mpc_t res, mpfr_t x)
{
    mpc_set_fr(res, x, MPFR_RNDN);
}


void mpfc_set_arb(mpc_t out1, arb_t in1)
{
    arf_get_mpfr(out1->re, arb_midref(in1), MPFR_RNDN);
    mpfr_set_si(out1->im, 0, MPFR_RNDN);
}




void mpfc_set_acb(mpc_t out1, acb_t in1)
{
	arf_get_mpfr(out1->re, arb_midref(acb_realref((acb_ptr)in1)), MPFR_RNDN);
	arf_get_mpfr(out1->im, arb_midref(acb_imagref((acb_ptr)in1)), MPFR_RNDN);
}



void mpfc_root_si(mpc_t res, mpc_t x, const int32_t k)
{
    mpfr_t y; mpfr_init2(y, mpfr_get_default_prec());
    mpfr_set_si(y, 1, MPFR_RNDN);
    mpfr_div_si(y, y, k, MPFR_RNDN);
    mpc_pow_fr(res, x, y, MPC_RNDNN);
    mpfr_clear(y);
}


void mpfc_expm1(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t x; mpfr_init2(x, mpfr_get_default_prec());
    mpfr_t y; mpfr_init2(y, mpfr_get_default_prec());
    mpfr_t resx; mpfr_init2(resx, mpfr_get_default_prec());
    mpfr_t resy; mpfr_init2(resy, mpfr_get_default_prec());
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpc_real(x, z, MPFR_RNDN);
    mpc_imag(y, z, MPFR_RNDN);

    mpfr_expm1(resx, x, MPFR_RNDN);
    mpfr_cos(temp, y, MPFR_RNDN);
    mpfr_mul(resx, resx, temp, MPFR_RNDN);
    mpfr_cosm1(temp, y, MPFR_RNDN);
    mpfr_add(resx, resx, temp, MPFR_RNDN);

    mpfr_exp(resy, x, MPFR_RNDN);
    mpfr_sin(temp, y, MPFR_RNDN);
    mpfr_mul(resy, resy, temp, MPFR_RNDN);

    mpc_set_fr_fr(res, resx, resy, MPC_RNDNN);

    mpfr_clear(x); mpfr_clear(y); mpfr_clear(temp);
    mpfr_clear(resx); mpfr_clear(resy);
}




std::complex<double> cplx_log1p_(std::complex<double> z)
{
    /* If max(|x|, |y|) > 0.75 or x < -0.5: resx = ln(hypot(1 + x, y)); */
    /* Otherwise: resx = 0.5 * log1p(2x + x*x + y*y); */
    /* resy =  atan2(y, 1 + x); */
	double x = z.real();
	double y = z.imag();
	double resx = 0.0 ;
	if ( (std::abs(x) > 0.75) || (std::abs(y) > 0.75) || (x < -0.5) )
    {
        resx = std::log(std::hypot(1 + x, y)) ;
    }
    else
    {
        resx = 0.5 * std::log1p(2*x + x*x + y*y);
    }
	double resy = std::atan2(y, 1 + x); ;
	return std::complex<double>(resx, resy);
}



void mpfc_log1p(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t x; mpfr_init2(x, mpfr_get_default_prec());
    mpfr_t y; mpfr_init2(y, mpfr_get_default_prec());
    mpfr_t resx; mpfr_init2(resx, mpfr_get_default_prec());
    mpfr_t resy; mpfr_init2(resy, mpfr_get_default_prec());
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpc_real(x, z, MPFR_RNDN);
    mpc_imag(y, z, MPFR_RNDN);

	//if ( (std::abs(x) > 0.75) || (std::abs(y) > 0.75) || (x < -0.5) )

	if ( (mpfr_cmp_d(x, 0.75) > 0) || (mpfr_cmp_d(x, -0.5) < 0) ||  (mpfr_cmp_d(y, 0.75) > 0) || (mpfr_cmp_d(y, -0.75) < 0) )

    {
        //resx = std::log(std::hypot(1 + x, y)) ;
        mpfr_add_si(temp, x, 1, MPFR_RNDN);
        mpfr_hypot(resx, temp, y, MPFR_RNDN);
        mpfr_log(resx, resx, MPFR_RNDN);
    }
    else
    {
        //resx = 0.5 * std::log1p(2*x + x*x + y*y);
        mpfr_mul_si(resx, x, 2, MPFR_RNDN);
        mpfr_sqr(temp, x, MPFR_RNDN);
        mpfr_add(resx, resx, temp, MPFR_RNDN);
        mpfr_sqr(temp, y, MPFR_RNDN);
        mpfr_add(resx, resx, temp, MPFR_RNDN);
        mpfr_log1p(resx, resx, MPFR_RNDN);
        mpfr_mul_d(resx, resx, 0.5, MPFR_RNDN);
    }
	//double resy = std::atan2(y, 1 + x);
    mpfr_add_si(temp, x, 1, MPFR_RNDN);
    mpfr_atan2(resy, y, temp, MPFR_RNDN);

    mpc_set_fr_fr(res, resx, resy, MPC_RNDNN);

    mpfr_clear(x); mpfr_clear(y); mpfr_clear(temp);
    mpfr_clear(resx); mpfr_clear(resy);
}




void mpfc_sqrt1pm1(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
	mpfc_log1p(res, z, MPC_RNDNN);
    mpc_div_ui(res, res, 2, MPC_RNDNN);
	mpfc_expm1(res, res, MPC_RNDNN);
}


void mpfc_exp2(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpfr_const_log2(temp, MPFR_RNDN);
    mpc_mul_fr(res, z, temp, MPC_RNDNN);
    mpc_exp(res, res, MPC_RNDNN);
    mpfr_clear(temp);
}

void mpfc_exp10(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpfr_set_si(temp, 10, MPFR_RNDN);
    mpfr_log(temp, temp, MPFR_RNDN);
    mpc_mul_fr(res, z, temp, MPC_RNDNN);
    mpc_exp(res, res, MPC_RNDNN);
    mpfr_clear(temp);
}

void mpfc_exp2m1(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpfr_const_log2(temp, MPFR_RNDN);
    mpc_mul_fr(res, z, temp, MPC_RNDNN);
    mpfc_expm1(res, res, MPC_RNDNN);
    mpfr_clear(temp);
}

void mpfc_exp10m1(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpfr_set_si(temp, 10, MPFR_RNDN);
    mpfr_log(temp, temp, MPFR_RNDN);
    mpc_mul_fr(res, z, temp, MPC_RNDNN);
    mpfc_expm1(res, res, MPC_RNDNN);
    mpfr_clear(temp);
}



void mpfc_log2(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpfr_const_log2(temp, MPFR_RNDN);
    mpc_log(res, z, MPC_RNDNN);
    mpc_div_fr(res, res, temp, MPC_RNDNN);
    mpfr_clear(temp);
}

void mpfc_log2p1(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpfr_const_log2(temp, MPFR_RNDN);
    mpfc_log1p(res, z, MPC_RNDNN);
    mpc_div_fr(res, res, temp, MPC_RNDNN);
    mpfr_clear(temp);
}

void mpfc_log10p1(mpc_t res, mpc_t z, mpc_rnd_t rnd)
{
    mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    mpfr_set_si(temp, 10, MPFR_RNDN);
    mpfr_log(temp, temp, MPFR_RNDN);
    mpfc_log1p(res, z, MPC_RNDNN);
    mpc_div_fr(res, res, temp, MPC_RNDNN);
    mpfr_clear(temp);
}



void mpfc_powm1(mpc_t res, mpc_t x, mpc_t y, mpc_rnd_t rnd)
{
	mpc_log(res, x, MPC_RNDNN);
    mpc_mul(res, res, y, MPC_RNDNN);
	mpfc_expm1(res, res, MPC_RNDNN);
}


void mpfc_pow1p(mpc_t res, mpc_t x, mpc_t y, mpc_rnd_t rnd)
{
	mpfc_log1p(res, x, MPC_RNDNN);
    mpc_mul(res, res, y, MPC_RNDNN);
	mpc_exp(res, res, MPC_RNDNN);
}


void mpfc_pow1pm1(mpc_t res, mpc_t x, mpc_t y, mpc_rnd_t rnd)
{
	mpfc_log1p(res, x, MPC_RNDNN);
    mpc_mul(res, res, y, MPC_RNDNN);
	mpfc_expm1(res, res, MPC_RNDNN);
}





/* **************** ARF ************************ */




void arf_get_ulp(arf_t res, const arf_t x, slong prec)
{
    // see also: https://www.boost.org/doc/libs/1_85_0/libs/math/doc/html/math_toolkit/next_float/ulp.html
    //printf("using arf_get_ulp:  \n");
    mag_t mres; mag_init(mres);
    arf_mag_set_ulp(mres, x, prec);
    arf_set_mag(res, mres);
    mag_clear(mres);
}

void arf_machine_epsilon_prec(arf_t res, slong prec)
{
    arf_t one; arf_init_set_si(one, 1);
    arf_get_ulp(res, one, prec);
    arf_clear(one);
}



void arf_maxval_prec(arf_t res, slong prec)
{
	fmpz_t one; fmpz_init_set_si(one, 1);
	fmpz_t e; fmpz_init(e);
    fmpz_one_2exp(e, 300);  //  e = 2^300 ~ 2.04 * 1E90
    arf_set_round_fmpz_2exp(res, one, e, prec, ARF_RND_NEAR);
	fmpz_clear(one); fmpz_clear(e);
}



    /* at precision prec, minval = 1/2 * 2^emin = 2^(emin - 1) */
void arf_minval_prec(arf_t res, slong prec)
{
	fmpz_t one; fmpz_init_set_si(one, 1);
	fmpz_t e; fmpz_init(e);
    fmpz_one_2exp(e, 301);  //  e = 2^300 ~ 2.04 * 1E90
    fmpz_neg(e, e);
    arf_set_round_fmpz_2exp(res, one, e, prec, ARF_RND_NEAR);
	fmpz_clear(one); fmpz_clear(e);
}




void arf_next_above(arf_t res, const arf_t x, slong prec)
{
    mag_t mres; mag_init(mres);
    arf_mag_set_ulp(mres, x, prec);
    arf_set_mag(res, mres);
    arf_add(res, res, x, prec, ARF_RND_NEAR);
    mag_clear(mres);
}


void arf_next_below(arf_t res, const arf_t x, slong prec)
{
    mag_t mres; mag_init(mres);
    arf_t x1; arf_init(x1);
    arf_neg(x1, x);
    arf_mag_set_ulp(mres, x1, prec);
    arf_set_mag(res, mres);
    arf_add(res, res, x1, prec, ARF_RND_NEAR);
    arf_neg(res, res);
    mag_clear(mres); arf_clear(x1);
}



void arf_next_toward(arf_t res, const arf_t x, const arf_t y, slong prec)
{
    int c = arf_cmp(x, y);
    if (c == 0)
    {
        arf_set(res, x);
    }
    else if (c > 0)
    {
        arf_next_above(res, x, prec);
    }
    else
    {
        arf_next_below(res, x, prec);
    }
}









int arf_FitsInt32(const arf_t x)
{
	mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    arf_get_mpfr(temp, x, MPFR_RNDN);
	int res = mpfr_fits_slong_p(temp, MPFR_RNDN);
	mpfr_clear(temp);
	return res;
}


int arf_FitsInt64(const arf_t x)
{
	mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    arf_get_mpfr(temp, x, MPFR_RNDN);
	int res = mpfr_fits_intmax_p(temp, MPFR_RNDN);
	mpfr_clear(temp);
	return res;
}




int arf_FitsUInt32(const arf_t x)
{
	mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    arf_get_mpfr(temp, x, MPFR_RNDN);
	int res = mpfr_fits_ulong_p(temp, MPFR_RNDN);
	mpfr_clear(temp);
	return res;
}


int arf_FitsUInt64(const arf_t x)
{
	mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    arf_get_mpfr(temp, x, MPFR_RNDN);
	int res = mpfr_fits_uintmax_p(temp, MPFR_RNDN);
	mpfr_clear(temp);
	return res;
}


int32_t arf_ToInt32(const arf_t x)
{
	mpfr_t m; mpfr_init2(m, mpfr_get_default_prec());
    arf_get_mpfr(m, x, MPFR_RNDN);
    int32_t res = mpfr_get_si(m, MPFR_RNDN);
	mpfr_clear(m);
	return res;
}



int64_t arf_ToInt64(const arf_t x)
{
	mpfr_t m; mpfr_init2(m, mpfr_get_default_prec());
    arf_get_mpfr(m, x, MPFR_RNDN);
    int64_t res = mpfr_get_sj(m, MPFR_RNDN);
	mpfr_clear(m);
	return res;
}



uint32_t arf_ToUInt32(const arf_t x)
{
	mpfr_t m; mpfr_init2(m, mpfr_get_default_prec());
    arf_get_mpfr(m, x, MPFR_RNDN);
    uint32_t res = mpfr_get_ui(m, MPFR_RNDN);
	mpfr_clear(m);
	return res;
}



uint64_t arf_ToUInt64(const arf_t x)
{
	mpfr_t m; mpfr_init2(m, mpfr_get_default_prec());
    arf_get_mpfr(m, x, MPFR_RNDN);
    uint64_t res = mpfr_get_uj(m, MPFR_RNDN);
	mpfr_clear(m);
	return res;
}






void arf_trunc_(arf_t res, const arf_t x)
{
    if (arf_sgn(x) > 0)
    {
        arf_floor(res, x);
    }
    else
    {
        arf_ceil(res, x);
    }
}

void arf_nint_(arf_t res, const arf_t x)
{
    if (arf_is_int(x))
    {
        arf_set(res, x);
    }
    else
    {
        arf_t t, u;
        arf_init(t);
        arf_init(u);

        arf_set_d(t, 0.5);
        arf_add(t, x, t, mpfr_get_default_prec(), ARF_RND_NEAR);

        arf_mul_2exp_si(u, x, 1);
        arf_sub_ui(u, u, 1, mpfr_get_default_prec(), ARF_RND_NEAR);
        arf_mul_2exp_si(u, u, -2);

        arf_floor(res, t);

        /* nint(x) = floor(x+0.5) - isint((2*x-1)/4) */

        if (arf_is_int(u))
        {
            arf_sub_ui(res, res, 1, mpfr_get_default_prec(), ARF_RND_NEAR);
        }
        arf_clear(t);
        arf_clear(u);
    }
}




void arf_set_ui64(arf_t x, uint64_t uint64)
{
	if (FLINT_BITS == 64)
	{
		arf_set_ui((arf_ptr)x, uint64);
	}
	else
	{
		fmpz_t z; fmpz_init(z); fmpz_set_ui64(z, uint64);
		arf_set_fmpz(x, z);
		fmpz_clear(z);
	}
}


void arf_set_si64(arf_t x, int64_t sint64)
{
	if (FLINT_BITS == 64)
	{
		arf_set_si((arf_ptr)x, sint64);
	}
	else
	{
		fmpz_t z; fmpz_init(z); fmpz_set_si64(z, sint64);
		arf_set_fmpz(x, z);
		fmpz_clear(z);
	}
}


void arf_add_d(arf_t z, const arf_t x, double d, slong prec, arf_rnd_t rnd)
{
	arf_t temp; arf_init(temp);
	arf_set_d(temp, d);
	arf_add(z, x, temp, prec, rnd);
	arf_clear(temp);
}


void arf_sub_d(arf_t z, const arf_t x, double d, slong prec, arf_rnd_t rnd)
{
	arf_t temp; arf_init(temp);
	arf_set_d(temp, d);
	arf_sub(z, x, temp, prec, rnd);
	arf_clear(temp);
}


void arf_mul_d(arf_t z, const arf_t x, double d, slong prec, arf_rnd_t rnd)
{
	arf_t temp; arf_init(temp);
	arf_set_d(temp, d);
	arf_mul(z, x, temp, prec, rnd);
	arf_clear(temp);
}



void arf_div_d(arf_t z, const arf_t x, double d, slong prec, arf_rnd_t rnd)
{
	arf_t temp; arf_init(temp);
	arf_set_d(temp, d);
	arf_div(z, x, temp, prec, rnd);
	arf_clear(temp);
}



void arf_log(arf_t z, const arf_t x, slong prec, arf_rnd_t rnd)
{
	arb_t x1; arb_init(x1);
	arb_t z1; arb_init(z1);
	arb_set_arf(x1, x);
	arb_log(z1, x1, prec);
	arf_set_round(z, arb_midref(z1), prec, rnd);
	arb_clear(x1);
	arb_clear(z1);
}



void arf_pow(arf_t z, const arf_t x, const arf_t y, slong prec, arf_rnd_t rnd)
{
	arb_t x1; arb_init(x1);
	arb_t y1; arb_init(y1);
	arb_t z1; arb_init(z1);
	arb_set_arf(x1, x);
	arb_set_arf(y1, y);
	arb_pow(z1, x1, y1, prec);
	arf_set_round(z, arb_midref(z1), prec, rnd);
	arb_clear(x1);
	arb_clear(y1);
	arb_clear(z1);
}



void arf_exp(arf_t z, const arf_t y, slong prec)
{
	arb_t y1; arb_init(y1);
	arb_t z1; arb_init(z1);
	arb_set_arf(y1, y);
	arb_exp(z1, y1, prec);
	arf_set_round(z, arb_midref(z1), prec, ARF_RND_NEAR);
	arb_clear(y1);
	arb_clear(z1);
}


void arf_sin(arf_t z, const arf_t y, slong prec)
{
	arb_t y1; arb_init(y1);
	arb_t z1; arb_init(z1);
	arb_set_arf(y1, y);
	arb_sin(z1, y1, prec);
	arf_set_round(z, arb_midref(z1), prec, ARF_RND_NEAR);
	arb_clear(y1);
	arb_clear(z1);
}


void arf_cos(arf_t z, const arf_t y, slong prec)
{
	arb_t y1; arb_init(y1);
	arb_t z1; arb_init(z1);
	arb_set_arf(y1, y);
	arb_cos(z1, y1, prec);
	arf_set_round(z, arb_midref(z1), prec, ARF_RND_NEAR);
	arb_clear(y1);
	arb_clear(z1);
}


void arf_acos(arf_t z, const arf_t y, slong prec)
{
	arb_t y1; arb_init(y1);
	arb_t z1; arb_init(z1);
	arb_set_arf(y1, y);
	arb_acos(z1, y1, prec);
	arf_set_round(z, arb_midref(z1), prec, ARF_RND_NEAR);
	arb_clear(y1);
	arb_clear(z1);
}


void arf_atan2(arf_t z, const arf_t x, const arf_t y, slong prec)
{
	arb_t x1; arb_init(x1);
	arb_t y1; arb_init(y1);
	arb_t z1; arb_init(z1);
	arb_set_arf(x1, x);
	arb_set_arf(y1, y);
	arb_atan2(z1, x1, y1, prec);
	arf_set_round(z, arb_midref(z1), prec, ARF_RND_NEAR);
	arb_clear(x1);
	arb_clear(y1);
	arb_clear(z1);
}








void arf_cplx_abs_from_real_and_imag(arf_t mp_res, arf_t mp_src_real, arf_t mp_src_imag)
{
	int32_t prec = mpfr_get_default_prec();
	arb_t mp_res1; arb_init(mp_res1);
	arb_t mp_src_real1; arb_init(mp_src_real1);
	arb_t mp_src_imag1; arb_init(mp_src_imag1);

	arb_set_arf(mp_src_real1, mp_src_real);
	arb_set_arf(mp_src_imag1, mp_src_imag);

	arb_cplx_abs_from_real_and_imag(mp_res1, mp_src_real1, mp_src_imag1);
	arf_set_round(mp_res, arb_midref(mp_res1), prec, ARF_RND_NEAR);

	arb_clear(mp_res1);
	arb_clear(mp_src_real1);
	arb_clear(mp_src_imag1);
}


void arf_cplx_sqrt_from_real_and_imag(arf_t mp_res_real, arf_t mp_res_imag, arf_t mp_src_real, arf_t mp_src_imag)
{
	int32_t prec = mpfr_get_default_prec();
	arb_t mp_res_real1; arb_init(mp_res_real1);
	arb_t mp_res_imag1; arb_init(mp_res_imag1);
	arb_t mp_src_real1; arb_init(mp_src_real1);
	arb_t mp_src_imag1; arb_init(mp_src_imag1);

	arb_set_arf(mp_src_real1, mp_src_real);
	arb_set_arf(mp_src_imag1, mp_src_imag);

	arb_cplx_sqrt_from_real_and_imag(mp_res_real1, mp_res_imag1, mp_src_real1, mp_src_imag1);
	arf_set_round(mp_res_real, arb_midref(mp_res_real1), prec, ARF_RND_NEAR);
	arf_set_round(mp_res_imag, arb_midref(mp_res_imag1), prec, ARF_RND_NEAR);

	arb_clear(mp_res_real1);
	arb_clear(mp_res_imag1);
	arb_clear(mp_src_real1);
	arb_clear(mp_src_imag1);
}







/* **************** ARB ************************ */






int arb_FitsInt32(const arb_t x)
{
	mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    arf_get_mpfr(temp, arb_midref(x), MPFR_RNDN);
	int res = mpfr_fits_slong_p(temp, MPFR_RNDN);
	mpfr_clear(temp);
	return res;
}


int arb_FitsInt64(const arb_t x)
{
	mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    arf_get_mpfr(temp, arb_midref(x), MPFR_RNDN);
	int res = mpfr_fits_intmax_p(temp, MPFR_RNDN);
	mpfr_clear(temp);
	return res;
}




int arb_FitsUInt32(const arb_t x)
{
	mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    arf_get_mpfr(temp, arb_midref(x), MPFR_RNDN);
	int res = mpfr_fits_ulong_p(temp, MPFR_RNDN);
	mpfr_clear(temp);
	return res;
}


int arb_FitsUInt64(const arb_t x)
{
	mpfr_t temp; mpfr_init2(temp, mpfr_get_default_prec());
    arf_get_mpfr(temp, arb_midref(x), MPFR_RNDN);
	int res = mpfr_fits_uintmax_p(temp, MPFR_RNDN);
	mpfr_clear(temp);
	return res;
}


int32_t arb_ToInt32(const arb_t x)
{
	mpfr_t m; mpfr_init2(m, mpfr_get_default_prec());
    arf_get_mpfr(m, arb_midref(x), MPFR_RNDN);
    int32_t res = mpfr_get_si(m, MPFR_RNDN);
	mpfr_clear(m);
	return res;
}



int64_t arb_ToInt64(const arb_t x)
{
	mpfr_t m; mpfr_init2(m, mpfr_get_default_prec());
    arf_get_mpfr(m, arb_midref(x), MPFR_RNDN);
    int64_t res = mpfr_get_sj(m, MPFR_RNDN);
	mpfr_clear(m);
	return res;
}



uint32_t arb_ToUInt32(const arb_t x)
{
	mpfr_t m; mpfr_init2(m, mpfr_get_default_prec());
    arf_get_mpfr(m, arb_midref(x), MPFR_RNDN);
    uint32_t res = mpfr_get_ui(m, MPFR_RNDN);
	mpfr_clear(m);
	return res;
}



uint64_t arb_ToUInt64(const arb_t x)
{
	mpfr_t m; mpfr_init2(m, mpfr_get_default_prec());
    arf_get_mpfr(m, arb_midref(x), MPFR_RNDN);
    uint64_t res = mpfr_get_uj(m, MPFR_RNDN);
	mpfr_clear(m);
	return res;
}













slong eval_count = 0;

int
sin_x(arb_ptr out, const arb_t inp, void* params, slong order, slong prec)
{
    int xlen = FLINT_MIN(2, order);
    flint_printf("order %wd:\n", order);

    arb_set(out, inp);
    if (xlen > 1)
        arb_one(out + 1);

    _arb_poly_sin_series(out, out, xlen, order, prec);

    eval_count++;
    return 0;
}



int
sin_x2(arb_ptr out, const arb_t inp, void* params, slong order, slong prec)
{
    arb_ptr x;

    int xlen = FLINT_MIN(2, order);
    int ylen = FLINT_MIN(3, order);

    x = _arb_vec_init(xlen);

    arb_set(x, inp);
    if (xlen > 1)
        arb_one(x + 1);

    _arb_poly_mullow(out, x, xlen, x, xlen, ylen, prec);
    _arb_poly_sin_series(out, out, ylen, order, prec);

    _arb_vec_clear(x, xlen);

    eval_count++;
    return 0;
}


void Lib_Arb_Real_Roots(void* f, double a, double b, int32_t verbose, int32_t refine, int32_t low_prec)
{
    arf_interval_ptr blocks;
    arb_calc_func_t function;
    int* info;
    void* params;
    int param1;
    //    slong digits, low_prec, high_prec, i, num, found_roots, found_unknown;
    slong digits, high_prec, i, num, found_roots, found_unknown;
    slong maxdepth, maxeval, maxfound;
    //    int refine;

    arf_t C;
    arf_interval_t t, interval;
    arb_t v, w, z;


    arb_calc_verbose = verbose;

    param1 = 0;
    params = &param1;

    if (f == NULL)
    {
        function = (arb_calc_func_t)sin_x;
    }
    else
    {
        function = (arb_calc_func_t)f;
    }



    //    function = sin_x2;
    digits = 0;

    //    refine = 0;
    if (refine > 0)
    {
        digits = refine;
        refine = 1;
    }
    maxdepth = 30;
    maxeval = 100000;
    maxfound = 100000;
    //    low_prec = 30;


    high_prec = digits * 3.32192809488736 + 10;
    found_roots = 0;
    found_unknown = 0;

    arf_init(C);
    arf_interval_init(t);
    arf_interval_init(interval);
    arb_init(v);
    arb_init(w);
    arb_init(z);

    arf_set_d(&interval->a, a);
    arf_set_d(&interval->b, b);

    flint_printf("interval: "); arf_interval_printd(interval, 15); flint_printf("\n");
    flint_printf("maxdepth = %wd, maxeval = %wd, maxfound = %wd, low_prec = %wd\n",
        maxdepth, maxeval, maxfound, low_prec);


    num = arb_calc_isolate_roots(&blocks, &info, function,
        params, interval, maxdepth, maxeval, maxfound, low_prec);

    for (i = 0; i < num; i++)
    {
        if (info[i] != 1)
        {
            if (arb_calc_verbose)
            {
                flint_printf("unable to count roots in ");
                arf_interval_printd(blocks + i, 15);
                flint_printf("\n");
            }
            found_unknown++;
            continue;
        }

        found_roots++;

        if (!refine)
            continue;

        if (arb_calc_refine_root_bisect(t,
            function, params, blocks + i, 5, low_prec)
            != ARB_CALC_SUCCESS)
        {
            flint_printf("warning: some bisection steps failed!\n");
        }

        if (arb_calc_verbose)
        {
            flint_printf("after bisection 1: ");
            arf_interval_printd(t, 15);
            flint_printf("\n");
        }

        if (arb_calc_refine_root_bisect(blocks + i,
            function, params, t, 5, low_prec)
            != ARB_CALC_SUCCESS)
        {
            flint_printf("warning: some bisection steps failed!\n");
        }

        if (arb_calc_verbose)
        {
            flint_printf("after bisection 2: ");
            arf_interval_printd(blocks + i, 15);
            flint_printf("\n");
        }

        arf_interval_get_arb(v, t, high_prec);
        arb_calc_newton_conv_factor(C, function, params, v, low_prec);

        arf_interval_get_arb(w, blocks + i, high_prec);
        if (arb_calc_refine_root_newton(z, function, params,
            w, v, C, 10, high_prec) != ARB_CALC_SUCCESS)
        {
            flint_printf("warning: some newton steps failed!\n");
        }

        flint_printf("refined root (%wd/%wd):\n", i + 1, num);
        arb_printn(z, digits + 2, 0);
        flint_printf("\n\n");
    }

    flint_printf("---------------------------------------------------------------\n");
    flint_printf("Found roots: %wd\n", found_roots);
    flint_printf("Subintervals possibly containing undetected roots: %wd\n", found_unknown);
    flint_printf("Function evaluations: %wd\n", eval_count);


    for (i = 0; i < num; i++)
        arf_interval_clear(blocks + i);
    flint_free(blocks);
    flint_free(info);


    arf_interval_clear(t);
    arf_interval_clear(interval);
    arf_clear(C);
    arb_clear(v);
    arb_clear(w);
    arb_clear(z);
}




void arb_set_ui64(arb_t x, uint64_t uint64)
{
    if (FLINT_BITS == 64)
    {
        arb_set_ui( (arb_ptr) x, uint64);
    }
    else
    {
        fmpz_t z; fmpz_init(z); fmpz_set_ui64(z, uint64);
        arb_set_fmpz(x, z);
        fmpz_clear(z);
    }
}


void arb_set_mpfr(arb_t x, mpfr_t in1)
{
	arf_set_mpfr(arb_midref(x), in1);
}


void arb_set_si64(arb_t x, int64_t sint64)
{
    if (FLINT_BITS == 64)
    {
        arb_set_si( (arb_ptr) x, sint64);
    }
    else
    {
        fmpz_t z; fmpz_init(z); fmpz_set_si64(z, sint64);
        arb_set_fmpz(x, z);
        fmpz_clear(z);
    }
}

int32_t arb_fits_int64(arb_t x)
{
	int32_t res = 0;
	if (arb_is_finite(x))
	{
		arb_t t; arb_init(t);
		arb_set_si64(t, MinValueInt64);
		int lowerbound = arf_cmp(arb_midref(x), arb_midref(t));
		arb_set_si64(t, MaxValueInt64);
		int upperbound = arf_cmp(arb_midref(t), arb_midref(x));
		arb_clear(t);
		res = ((lowerbound >= 0) && (upperbound >= 0));
		//printf("lowerbound: %i, upperbound: %i, res: %i \n", lowerbound, upperbound, res);
	}
	return res;
}



int32_t arf_fits_int64(arf_t x)
{
	arb_t temp; arb_init(temp);
	arf_set(arb_midref(temp), x);
	int64_t res = arb_fits_int64(temp);
	arb_clear(temp);
	return res;
}




int32_t arb_fits_int32(arb_t x)
{
	int32_t res = 0;
	int fits = arb_fits_int64(x);
	if (fits != 0)
	{
		int64_t res64 = arb_get_si64(x);
		res = int64_fits_int32(res64);
	}
	//printf("in arb_fits_int32;   fits: %i, res: %i \n", fits, res);
	return res;
}


int32_t arf_fits_int32(arf_t x)
{
	arb_t temp; arb_init(temp);
	arf_set(arb_midref(temp), x);
	int64_t res = arb_fits_int32(temp);
	arb_clear(temp);
	return res;
}



int32_t arb_fits_uint64(arb_t x)
{
	int32_t res = 0;
	if (arb_is_finite(x))
	{
		arb_t t; arb_init(t);
		arb_set_ui64(t, MinValueUInt64);
		int lowerbound = arf_cmp(arb_midref(x), arb_midref(t));
		arb_set_ui64(t, MaxValueUInt64);
		int upperbound = arf_cmp(arb_midref(t), arb_midref(x));
		arb_clear(t);
		res = ((lowerbound >= 0) && (upperbound >= 0));
		//printf("lowerbound: %i, upperbound: %i, res: %i \n", lowerbound, upperbound, res);
	}
	return res;
}



int32_t arf_fits_uint64(arf_t x)
{
	arb_t temp; arb_init(temp);
	arf_set(arb_midref(temp), x);
	int64_t res = arb_fits_uint64(temp);
	arb_clear(temp);
	return res;
}


int32_t arb_fits_uint32(arb_t x)
{
	int32_t res = 0;
	int fits = arb_fits_uint64(x);
	if (fits != 0)
	{
		uint64_t res64 = arb_get_ui64(x);
		res = uint64_fits_uint32(res64);
	}
	return res;
}


int32_t arf_fits_uint32(arf_t x)
{
	arb_t temp; arb_init(temp);
	arf_set(arb_midref(temp), x);
	int64_t res = arb_fits_uint32(temp);
	arb_clear(temp);
	return res;
}



int64_t arb_get_si64_(arb_t x)
{
    return arf_get_si( arb_midref(x), ARF_RND_NEAR);
}



int64_t arf_get_si64_(arf_t x)
{
    return arf_get_si(x, ARF_RND_NEAR);
}



int64_t arb_get_si64(arb_t x)
{
	int64_t res = 0;
	if (arb_is_finite(x))
	{
		int fits = arb_fits_int64(x);
		if (fits != 0) res = arb_get_si64_(x);
	}
	return res;
}


int64_t arf_get_si64(arf_t x)
{
	int64_t res = 0;
	if (arf_is_finite(x))
	{
		int fits = arf_fits_int64(x);
		if (fits != 0) res = arf_get_si64_(x);
	}
	return res;
}



uint64_t arb_get_ui64_(arb_t x)
{
	fmpz_t z; fmpz_init(z);
	arf_get_fmpz(z, arb_midref(x), ARF_RND_NEAR);
	uint64_t llui = fmpz_get_ui64(z);
	fmpz_clear(z);
	return llui;
}

uint64_t arf_get_ui64_(arf_t x)
{
	fmpz_t z; fmpz_init(z);
	arf_get_fmpz(z, x, ARF_RND_NEAR);
	uint64_t llui = fmpz_get_ui64(z);
	fmpz_clear(z);
	return llui;
}




int32_t arb_get_si32(arb_t x)
{
	int32_t res = 0;
	int fits = arb_fits_int32(x);
	if (fits != 0) res = arb_get_si64(x);
	return res;
}



int32_t arf_get_si32(arf_t x)
{
	int32_t res = 0;
	int fits = arf_fits_int32(x);
	if (fits != 0) res = arf_get_si64(x);
	return res;
}


uint64_t arb_get_ui64(arb_t x)
{
	int64_t res = 0;
	if (arb_is_finite(x))
	{
		int fits = arb_fits_uint64(x);
		if (fits != 0) res = arb_get_ui64_(x);
	}
	return res;
}


uint64_t arf_get_ui64(arf_t x)
{
	int64_t res = 0;
	if (arf_is_finite(x))
	{
		int fits = arf_fits_uint64(x);
		if (fits != 0) res = arf_get_ui64_(x);
	}
	return res;
}



uint32_t arb_get_ui32(arb_t x)
{
	uint32_t res = 0;
	int fits = arb_fits_uint32(x);
	if (fits != 0) res = arb_get_ui64(x);
	return res;
}

uint32_t arf_get_ui32(arf_t x)
{
	uint32_t res = 0;
	int fits = arf_fits_uint32(x);
	if (fits != 0) res = arf_get_ui64(x);
	return res;
}




double arb_get_d(arb_t in1)
{
    return arf_get_d( arb_midref((arb_ptr) in1), ARF_RND_NEAR);
}


void arb_add_d(arb_t z, const arb_t x, double y, slong prec)
{
	arb_t temp; arb_init(temp);
	arb_set_d(temp, y);
	arb_add(z, x, temp, prec);
	arb_clear(temp);
}


void arb_sub_d(arb_t z, const arb_t x, double y, slong prec)
{
	arb_t temp; arb_init(temp);
	arb_set_d(temp, y);
	arb_sub(z, x, temp, prec);
	arb_clear(temp);
}


void arb_mul_d(arb_t z, const arb_t x, double y, slong prec)
{
	arb_t temp; arb_init(temp);
	arb_set_d(temp, y);
	arb_mul(z, x, temp, prec);
	arb_clear(temp);
}


void arb_div_d(arb_t z, const arb_t x, double y, slong prec)
{
	arb_t temp; arb_init(temp);
	arb_set_d(temp, y);
	arb_div(z, x, temp, prec);
	arb_clear(temp);
}



int64_t arb_sizeinbase10(int32_t n, uint32_t flags, arb_t x)
{
//    printf("in arb_sizeinbase10 \n");
    char * src = arb_get_str(x, n, flags);
    uint32_t res = (uint32_t)strlen(src) + 1;
    free(src);
    return res;
}




int64_t arf_sizeinbase10(int32_t n, uint32_t flags, arf_t x)
{
	arb_t temp; arb_init(temp);
	arf_set(arb_midref(temp), (arf_ptr)x);
	mag_zero(arb_radref(temp));
	int64_t res = arb_sizeinbase10(n, flags, temp);
	arb_clear(temp);
	return res;
}



int64_t arb_get_str_intern(char * dest , ScalarPtr x, int32_t n, uint32_t flags)
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




int64_t arf_get_str_intern(char * dest, ScalarPtr x, int32_t n, uint32_t flags)
{
	//printf("in arf_get_str_intern \n");
	arb_t temp; arb_init(temp);
	arf_set(arb_midref(temp), (arf_ptr)x);
	mag_zero(arb_radref(temp));
	int64_t res = arb_get_str_intern(dest, temp, n, flags);
	arb_clear(temp);
	return res;
}




char* arb_get_str_extern(int32_t n, uint32_t flags, arb_t x)
{
   return arb_get_str((arb_ptr)x, n, flags);
}



char * arf_get_str_extern(int32_t n, uint32_t flags, arf_t x)
{
	arb_t temp; arb_init(temp);
	arf_set(arb_midref(temp), (arf_ptr)x);
	mag_zero(arb_radref(temp));
	char * res = arb_get_str_extern(n, flags, temp);
	arb_clear(temp);
	return res;
}




/* **************** ARB ************************ */



void arb_get_ulp(arb_t res, const arb_t x, slong prec)
{
    arb_set_si(res, 0);
    arf_get_ulp(arb_midref(res), arb_midref(x), prec);
}


void arb_machine_epsilon_prec(arb_t res, slong prec)
{
    arb_set_si(res, 0);
    arf_machine_epsilon_prec(arb_midref(res), prec);
}



void arb_maxval_prec(arb_t res, slong prec)
{
    arb_set_si(res, 0);
    arf_maxval_prec(arb_midref(res), prec);
}



void arb_minval_prec(arb_t res, slong prec)
{
    arb_set_si(res, 0);
    arf_minval_prec(arb_midref(res), prec);
}




void arb_frexp(arb_t res, const arb_t x, fmpz_t e1)
{
    //fmpz_t e1; fmpz_init(e1);
    fmpz_t e2; fmpz_init(e2);

    arf_t x1; arf_init(x1);
    arf_t x2; arf_init(x2);

    arf_t res1; arf_init(res1);
    arf_t res2; arf_init(res2);

    arb_get_interval_arf(x1, x2, x, mpfr_get_default_prec());

    arf_frexp(res1, e1, x1);
    arf_frexp(res2, e2, x2);

    fmpz_sub(e2, e2, e1);
    arf_mul_2exp_fmpz(res1, res1, e2);
    arb_set_interval_arf(res, res1, res2, mpfr_get_default_prec());

	arf_clear(x1); arf_clear(x2);
    arf_clear(res1); arf_clear(res2);
    fmpz_clear(e2);
}





void arb_next_above(arb_t res, const arb_t x, slong prec)
{
    arb_set_si(res, 0);
    arf_next_above(arb_midref(res), arb_midref(x), prec);
}



void arb_next_below(arb_t res, const arb_t x, slong prec)
{
    arb_set_si(res, 0);
    arf_next_below(arb_midref(res), arb_midref(x), prec);
}



void arb_next_toward(arb_t res, const arb_t x, const arb_t y, slong prec)
{
    arb_set_si(res, 0);
    arf_next_toward(arb_midref(res), arb_midref(x), arb_midref(y), prec);
}




void arb_cplx_abs_from_real_and_imag(arb_t mp_res, const arb_t mp_src_real, const arb_t mp_src_imag)
{
	acb_t z;
	acb_init(z);
	acb_set_arb_arb(z, mp_src_real, mp_src_imag);
	acb_abs(mp_res, z, mpfr_get_default_prec());
	acb_clear(z);
}


void arb_cplx_sqrt_from_real_and_imag(arb_t mp_res_real, arb_t mp_res_imag, const arb_t mp_src_real, const arb_t mp_src_imag)
{
	acb_t z;
	acb_init(z);
	acb_t res;
	acb_init(res);
	acb_set_arb_arb(z, mp_src_real, mp_src_imag);
	acb_sqrt(res, z, mpfr_get_default_prec());
	arb_set(mp_res_real, acb_realref(res));
	arb_set(mp_res_imag, acb_imagref(res));
	acb_clear(z);
	acb_clear(res);
}






//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////




void Arb_RealViaCplxfunc1(AcbFuncPtr1 f1, arb_t res, const arb_t in1)
{
    //printf("using Arb_RealViaCplxfunc1:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb;
    acb_init(out1_acb); acb_init(in1_acb);
    acb_set_arb(in1_acb, in1);

    f1(out1_acb, in1_acb, wp);

    //if (acb_is_real(out1_acb)) { arb_set(res, acb_realref(out1_acb)); }
    //else { arb_indeterminate(res); }

    arb_set(res, acb_realref(out1_acb));

    acb_clear(out1_acb); acb_clear(in1_acb);
}



void Arb_RealViaCplxfunc2(AcbFuncPtr2 f2, arb_t res, const arb_t in1, const arb_t in2)
{
    //printf("using Arb_RealViaCplxfunc2:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb, in2_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb);
    acb_set_arb(in1_acb, in1); acb_set_arb(in2_acb, in2);

    f2(out1_acb, in1_acb, in2_acb, wp);

    //if (acb_is_real(out1_acb)) { arb_set(res, acb_realref(out1_acb)); }
    //else { arb_indeterminate(res); }

    arb_set(res, acb_realref(out1_acb));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb);
}



void Arb_RealViaCplxfunc3(AcbFuncPtr3 f3, arb_t res, const arb_t in1, const arb_t in2, const arb_t in3)
{
    //printf("using Arb_RealViaCplxfunc3:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb, in2_acb, in3_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb);
    acb_set_arb(in1_acb, in1); acb_set_arb(in2_acb, in2); acb_set_arb(in3_acb, in3);

    f3(out1_acb, in1_acb, in2_acb, in3_acb, wp);

    //if (acb_is_real(out1_acb)) { arb_set(res, acb_realref(out1_acb)); }
    //else { arb_indeterminate(res); }

    arb_set(res, acb_realref(out1_acb));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb);
}



void Arb_RealViaCplxfunc4(AcbFuncPtr4 f4, arb_t res, const arb_t in1, const arb_t in2, const arb_t in3, const arb_t in4)
{
    //printf("using Arb_RealViaCplxfunc4:  ");
	slong wp = mpfr_get_default_prec();

    acb_t out1_acb, in1_acb, in2_acb, in3_acb, in4_acb;
    acb_init(out1_acb); acb_init(in1_acb); acb_init(in2_acb); acb_init(in3_acb); acb_init(in4_acb);
    acb_set_arb(in1_acb, in1); acb_set_arb(in2_acb, in2); acb_set_arb(in3_acb, in3); acb_set_arb(in4_acb, in4);

    f4(out1_acb, in1_acb, in2_acb, in3_acb, in4_acb, wp);

    //if (acb_is_real(out1_acb)) { arb_set(res, acb_realref(out1_acb)); }
    //else { arb_indeterminate(res); }

    arb_set(res, acb_realref(out1_acb));

    acb_clear(out1_acb); acb_clear(in1_acb); acb_clear(in2_acb); acb_clear(in3_acb); acb_clear(in4_acb);
}




/* Constants */


void arb_const_degree_(arb_t out1, slong wp)
{
    arb_const_pi(out1, wp);
    arb_div_si(out1, out1, 180, wp);
}


void arb_const_phi_(arb_t out1, slong wp)
{
    arb_sqrt_ui(out1, 5, wp);
    arb_add_ui(out1, out1, 1, wp);
    arb_div_ui(out1, out1, 2, wp);
}





/* Roots and quadratic, cubic, and quartic equations */


void arb_cbrt(arb_t res, const arb_t x, slong prec)
{
    arb_root_ui(res, x, 3, prec) ;
}


void arb_root_ui_(arb_t out1, const arb_t x, int32_t n, slong prec)
{
    arb_root_ui(out1, x, n, prec);
}


void arb_root_si_(arb_t res, const arb_t x, int32_t n, slong prec)
{
    uint32_t n_ = (n < 0) ? -n : n;
	arb_root_ui((arb_ptr)res, (arb_ptr)x, n_, prec);
    if (n < 0) { arb_inv(res, res, prec); }
}





/* Exponential and related functions */


void arb_exp10_(arb_t out1, const arb_t in1, slong wp)
{
    arb_t log10, temp1;
    arb_init(log10); arb_init(temp1);
    arb_const_log10(log10, wp);
    arb_mul(temp1, in1, log10, wp);
    arb_exp(out1, temp1, wp);
    arb_clear(temp1); arb_clear(log10);
}



void arb_exp2_(arb_t out1, const arb_t in1, slong wp)
{
    arb_t log2, temp1;
    arb_init(log2); arb_init(temp1);
    arb_const_log2(log2, wp);
    arb_mul(temp1, in1, log2, wp);
    arb_exp(out1, temp1, wp);
    arb_clear(temp1); arb_clear(log2);
}


void arb_exp10m1_(arb_t out1, const arb_t in1, slong wp)
{
    arb_t log10;
    arb_t temp1;
    arb_init(log10); arb_init(temp1);
    arb_const_log10(log10, wp);
    arb_mul(temp1, in1, log10, wp);
    arb_expm1(out1, temp1, wp);
    arb_clear(temp1); arb_clear(log10);
}



void arb_exp2m1_(arb_t out1, const arb_t in1, slong wp)
{
    arb_t log2;
    arb_t temp1;
    arb_init(log2); arb_init(temp1);
    arb_const_log2(log2, wp);
    arb_mul(temp1, in1, log2, wp);
    arb_expm1(out1, temp1, wp);
    arb_clear(temp1); arb_clear(log2);
}



void arb_exprel_(arb_t out1, const arb_t in1, slong wp)
{
    if (arb_is_zero(in1))
    {
        arb_one(out1);
    }
    else
    {
        arb_expm1(out1, in1, wp);
        arb_div(out1, out1, in1, wp);
    }
}




/* Logarithms and related functions */



void arb_log1mexp_(arb_t out1, const arb_t x, slong wp)
{
    arb_t log2, crit, z;
    arb_init(log2); arb_init(crit); arb_init(z);
    arb_const_log2(log2, wp);
    arb_abs(crit, z);
    arb_neg(z, crit);
    arb_sub(crit, crit, log2, wp);
    int cmp = arf_cmp_ui(arb_midref(crit), 0);

    if (cmp < 0)
    {
        arb_expm1(out1, z, wp);
        arb_neg(out1, out1);
        arb_log(out1, out1, wp);
    }
    else
    {
        arb_exp(out1, z, wp);
        arb_neg(out1, out1);
        arb_log1p(out1, out1, wp);
    }
    arb_clear(crit); arb_clear(log2);arb_clear(z);
}






void arb_logbase_(arb_t out1, const arb_t z, const arb_t b, slong wp)
{
    arb_t temp1; arb_init(temp1);
    arb_log(out1, z, wp);
    arb_log(temp1, b, wp);
    arb_div(out1, out1, temp1, wp);
    arb_clear(temp1);
}




void arb_log10p1_(arb_t out1, const arb_t in1, slong wp)
{
    arb_t log10;
    arb_t temp1;
    arb_init(log10); arb_init(temp1);
    arb_const_log10(log10, wp);
    arb_log1p(temp1, in1, wp);
    arb_div(out1, temp1, log10, wp);
    arb_clear(temp1); arb_clear(log10);
}



void arb_log2p1_(arb_t out1, const arb_t in1, slong wp)
{
    arb_t log2;
    arb_t temp1;
    arb_init(log2); arb_init(temp1);
    arb_const_log2(log2, wp);
    arb_log1p(temp1, in1, wp);
    arb_div(out1, temp1, log2, wp);
    arb_clear(temp1); arb_clear(log2);
}




void arb_log2(arb_t res, const arb_t x, slong prec)
{
    arb_log_base_ui(res, x, 2, prec);
}


void arb_log10(arb_t res, const arb_t x, slong prec)
{
    arb_log_base_ui(res, x, 10, prec);
}



void arb_lambertw0(arb_t res, const arb_t x, slong prec)
{
    arb_lambertw(res, x, 0, prec);
}


void arb_lambertwm1(arb_t res, const arb_t x, slong prec)
{
    arb_lambertw(res, x, 1, prec);
}






/* Power functions */


void arb_cube_(arb_t out1, const arb_t in1, slong wp)
{
    arb_t temp1;
    arb_init(temp1);
    arb_sqr(temp1, in1, wp);
    arb_mul(out1, temp1, in1, wp);
    arb_clear(temp1);
}



void arb_pow_ui_(arb_t out1, const arb_t x, int32_t n, slong prec)
{
    arb_pow_ui(out1, x, n, prec);
}




void arb_powm1_(arb_t out1, const arb_t a, const arb_t b, slong wp)
{
    arb_t x; arb_init(x);
    arb_log(x, a, wp);
    arb_mul(x, b, x, wp);
    arb_expm1(out1, x, wp) ;
    arb_clear(x);
}



void arb_pow1p_(arb_t out1, const arb_t a, const arb_t b, slong wp)
{
    arb_t x; arb_init(x);
    arb_log1p(x, a, wp);
    arb_mul(x, b, x, wp);
    arb_expm1(out1, x, wp) ;
    arb_clear(x);
}



void arb_pow1pm1_(arb_t out1, const arb_t a, const arb_t b, slong wp)
{
    arb_t x; arb_init(x);
    arb_log1p(x, a, wp);
    arb_mul(x, b, x, wp);
    arb_expm1(out1, x, wp) ;
    arb_clear(x);
}



void arb_pow_si_(arb_t res, const arb_t x, int32_t n, slong prec)
{
    uint32_t n_ = (n < 0) ? -n : n;
	arb_pow_ui((arb_ptr)res, (arb_ptr)x, n_, prec);
    if (n < 0) { arb_inv(res, res, prec); }
}



void arb_compound_si_(arb_t res, const arb_t x, int32_t n, slong prec)
{
    uint32_t n_ = (n < 0) ? -n : n;
    arb_add_si(res, x, 1, prec);
	arb_pow_ui((arb_ptr)res, (arb_ptr)res, n_, prec);
    if (n < 0) { arb_inv(res, res, prec); }
}





/* Trigonometric and related functions */



void arb_cosm1_(arb_t res, const arb_t x, slong prec)
{
    arb_t HALF; arb_init(HALF); arb_set_d(HALF, 0.5);
    arb_abs(res, x);
    int c = arb_gt(res, HALF);
    if (c >= 0)
    {
        arb_cos(res, x, prec);
        arb_sub_si(res, res, 1, prec);
    }
    else
    {
        arb_div_si(res, x, 2, prec);
        arb_sin(res, res, prec);
        arb_sqr(res, res, prec);
        arb_mul_si(res, res, -2, prec);
    }
    arb_clear(HALF);
}


void arb_sec_pi_(arb_t res, const arb_t x, slong prec)
{
    arb_cos_pi(res, x, prec);
    arb_inv(res, res, prec);
}





/* Hyperbolic functions */






/* Inverse trigonometric functions */


void arb_acsc(arb_t out1, const arb_t in1, slong wp)
{
    arb_t y; arb_init(y); arb_inv(y, in1, wp);
    arb_asin(out1, y, wp) ;
    arb_clear(y);
}


void arb_asec(arb_t out1, const arb_t in1, slong wp)
{
    arb_t y; arb_init(y); arb_inv(y, in1, wp);
    arb_acos(out1, y, wp) ;
    arb_clear(y);
}


void arb_acot(arb_t out1, const arb_t in1, slong wp)
{
    arb_t y; arb_init(y); arb_inv(y, in1, wp);
    arb_atan(out1, y, wp) ;
    arb_clear(y);
}






/* Inverse hyperbolic functions */


void arb_acsch(arb_t out1, const arb_t in1, slong wp)
{
    arb_t y; arb_init(y); arb_inv(y, in1, wp);
    arb_asinh(out1, y, wp) ;
    arb_clear(y);
}


void arb_asech(arb_t out1, const arb_t in1, slong wp)
{
    arb_t y; arb_init(y); arb_inv(y, in1, wp);
    arb_acosh(out1, y, wp) ;
    arb_clear(y);
}


void arb_acoth(arb_t out1, const arb_t in1, slong wp)
{
    arb_t y; arb_init(y); arb_inv(y, in1, wp);
    arb_atanh(out1, y, wp) ;
    arb_clear(y);
}










/* Legendre elliptic integrals (elliptic parameter m) */


void arb_elliptic_k(arb_t res, const arb_t m, slong wp)
{
    Arb_RealViaCplxfunc1(acb_elliptic_k, res, m);
}


void arb_elliptic_e(arb_t res, const arb_t m, slong wp)
{
    Arb_RealViaCplxfunc1(acb_elliptic_e, res, m);
}


void arb_elliptic_pi(arb_t res, const arb_t n, const arb_t m, slong prec)
{
    Arb_RealViaCplxfunc2(acb_elliptic_pi, res, n, m);
}

void arb_elliptic_f_(arb_t res, const arb_t phi, const arb_t m, slong prec)
{
    Arb_RealViaCplxfunc2(acb_elliptic_f_, res, phi, m);
}

void arb_elliptic_e_inc_(arb_t res, const arb_t phi, const arb_t m, slong prec)
{
    Arb_RealViaCplxfunc2(acb_elliptic_e_inc_, res, phi, m);
}

void arb_elliptic_pi_inc_(arb_t res, const arb_t n, const arb_t phi, const arb_t m, slong prec)
{
    Arb_RealViaCplxfunc3(acb_elliptic_pi_inc_, res, n, phi, m);
}





/* Legendre elliptic integrals (elliptic modulus k), and related functions */

void arb_elliptic_k_k_(arb_t res, const arb_t k, slong wp)
{
    arb_t m; arb_init(m); arb_sqr(m, k, wp);
    Arb_RealViaCplxfunc1(acb_elliptic_k, res, m);
    arb_clear(m);
}

void arb_elliptic_e_k_(arb_t res, const arb_t k, slong wp)
{
    arb_t m; arb_init(m); arb_sqr(m, k, wp);
    Arb_RealViaCplxfunc1(acb_elliptic_e, res, m);
    arb_clear(m);
}

void arb_elliptic_pi_k_(arb_t res, const arb_t n, const arb_t k, slong prec)
{
    arb_t m; arb_init(m); arb_sqr(m, k, prec);
    Arb_RealViaCplxfunc2(acb_elliptic_pi, res, n, m);
    arb_clear(m);
}

void arb_elliptic_f_k_(arb_t res, const arb_t phi, const arb_t k, slong prec)
{
    arb_t m; arb_init(m); arb_sqr(m, k, prec);
    Arb_RealViaCplxfunc2(acb_elliptic_f_, res, phi, m);
    arb_clear(m);
}

void arb_elliptic_e_inc_k_(arb_t res, const arb_t phi, const arb_t k, slong prec)
{
    arb_t m; arb_init(m); arb_sqr(m, k, prec);
    Arb_RealViaCplxfunc2(acb_elliptic_e_inc_, res, phi, m);
    arb_clear(m);
}

void arb_elliptic_pi_inc_k_(arb_t res, const arb_t n, const arb_t phi, const arb_t k, slong prec)
{
    arb_t m; arb_init(m); arb_sqr(m, k, prec);
    Arb_RealViaCplxfunc3(acb_elliptic_pi_inc_, res, n, phi, m);
    arb_clear(m);
}







/* Carlson symmetric elliptic integrals */


void arb_elliptic_rc_(arb_t res, const arb_t x, const arb_t y, slong prec)
{
    Arb_RealViaCplxfunc2(acb_elliptic_rc_, res, x, y);
}


void arb_elliptic_rf_(arb_t res, const arb_t x, const arb_t y, const arb_t z, slong prec)
{
    Arb_RealViaCplxfunc3(acb_elliptic_rf_, res, x, y, z);
}


void arb_elliptic_rg_(arb_t res, const arb_t x, const arb_t y, const arb_t z, slong prec)
{
    Arb_RealViaCplxfunc3(acb_elliptic_rg_, res, x, y, z);
}


void arb_elliptic_rd_(arb_t res, const arb_t x, const arb_t y, const arb_t z, slong prec)
{
    Arb_RealViaCplxfunc3(acb_elliptic_rd_, res, x, y, z);
}


void arb_elliptic_rj_(arb_t res, const arb_t x, const arb_t y, const arb_t z, const arb_t w, slong prec)
{
    Arb_RealViaCplxfunc4(acb_elliptic_rj_, res, x, y, z, w);
}





/* Jacobi theta functions */


void _arb_theta1q(arb_t res, const arb_t z, const arb_t q, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_theta1q, res, z, q);
}


void _arb_theta2q(arb_t res, const arb_t z, const arb_t q, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_theta2q, res, z, q);
}


void _arb_theta3q(arb_t res, const arb_t z, const arb_t q, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_theta3q, res, z, q);
}


void _arb_theta4q(arb_t res, const arb_t z, const arb_t q, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_theta4q, res, z, q);
}




/* Jacobi elliptic functions */


void _arb_jacobi_sn(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_sn, res, u, k);
}

void _arb_jacobi_cn(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_cn, res, u, k);
}

void _arb_jacobi_dn(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_dn, res, u, k);
}



void _arb_jacobi_ns(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_ns, res, u, k);
}

void _arb_jacobi_nc(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_nc, res, u, k);
}

void _arb_jacobi_nd(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_nd, res, u, k);
}



void _arb_jacobi_sc(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_sc, res, u, k);
}

void _arb_jacobi_sd(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_sd, res, u, k);
}



void _arb_jacobi_dc(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_dc, res, u, k);
}

void _arb_jacobi_ds(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_ds, res, u, k);
}



void _arb_jacobi_cs(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_cs, res, u, k);
}

void _arb_jacobi_cd(arb_t res, const arb_t u, const arb_t k, slong prec)
{
    Arb_RealViaCplxfunc2(_acb_jacobi_cd, res, u, k);
}








/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */






/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

void arb_dirichlet_lerch_phi(arb_t res, const arb_t z, const arb_t s, const arb_t a, slong prec)
{
    Arb_RealViaCplxfunc3(acb_dirichlet_lerch_phi, res, z, s, a);
}





/* Polygamma functions */


void arb_polygamma(arb_t res, const arb_t s, const arb_t z, slong prec)
{
    Arb_RealViaCplxfunc2(acb_polygamma, res, s, z);
}





/* Polylogarithms and related functions */





/* Hurwitz zeta function and related functions */


void arb_bernoulli_ui_(arb_t out1, const int32_t n, slong wp)
{
    arb_bernoulli_ui(out1, n, wp);
}


void arb_bernoulli_poly_ui_(arb_t out1, const arb_t x, int32_t n, slong prec)
{
    arb_bernoulli_poly_ui(out1, n, x, prec);
}



void arb_euler_number_ui_(arb_t out1, const int32_t n, slong wp)
{
    arb_euler_number_ui(out1, n, wp);
}


void arb_barnes_g(arb_t res, const arb_t x, slong wp)
{
    Arb_RealViaCplxfunc1(acb_barnes_g, res, x);
}


void arb_log_barnes_g(arb_t res, const arb_t x, slong wp)
{
    Arb_RealViaCplxfunc1(acb_log_barnes_g, res, x);
}







/* Riemann zeta function, and related functions */



void arb_gram_point_ui_(arb_t out1, int32_t in1, slong wp)
{
    fmpz_t k; fmpz_init(k); fmpz_set_si(k, in1);
    acb_dirichlet_gram_point(out1, k, NULL, NULL, wp);
    fmpz_clear(k);
}








/* Additional numbertheoretic functions */


void arb_bell_ui_(arb_t out1, const int32_t n, slong wp)
{
    arb_bell_ui(out1, n, wp);
}


void arb_partitions_ui_(arb_t out1, const int32_t n, slong wp)
{
    arb_partitions_ui(out1, n, wp);
}


void arb_primorial_nth_ui_(arb_t out1, const int32_t n, slong wp)
{
    arb_primorial_nth_ui(out1, n, wp);
}






/* Confluent Hypergeometric Limit Function 0F1, overview */


void arb_hypgeom_0f1_(arb_t res, const arb_t a, const arb_t x, slong prec)
{
    arb_hypgeom_0f1(res, a, x, 0, prec);
}


void arb_hypgeom_0f1_r(arb_t res, const arb_t a, const arb_t x, slong prec)
{
    arb_hypgeom_0f1(res, a, x, 1, prec);
}





/* Bessel functions and modified Bessel functions  */





/* Spherical Bessel functions  */



/* Airy functions  */


void arb_airy_ai(arb_t res, const arb_t x, slong prec)
{
    arb_hypgeom_airy(res, NULL, NULL, NULL, x, prec);
}


void arb_airy_ai_prime(arb_t res, const arb_t x, slong prec)
{
    arb_hypgeom_airy(NULL, res, NULL, NULL, x, prec);
}


void arb_airy_bi(arb_t res, const arb_t x, slong prec)
{
    arb_hypgeom_airy(NULL, NULL, res, NULL, x, prec);
}


void arb_airy_bi_prime(arb_t res, const arb_t x, slong prec)
{
    arb_hypgeom_airy(NULL, NULL, NULL, res, x, prec);
}


void arb_airy_ai_zero(arb_t res, const int n, slong prec)
{
    fmpz_t k; fmpz_init(k); fmpz_set_si(k, n);
    arb_hypgeom_airy_zero(res, NULL, NULL, NULL, k, prec);
    fmpz_clear(k);
}


void arb_airy_ai_prime_zero(arb_t res, const int n, slong prec)
{
    fmpz_t k; fmpz_init(k); fmpz_set_si(k, n);
    arb_hypgeom_airy_zero(NULL, res, NULL, NULL, k, prec);
    fmpz_clear(k);
}


void arb_airy_bi_zero(arb_t res, const int n, slong prec)
{
    fmpz_t k; fmpz_init(k); fmpz_set_si(k, n);
    arb_hypgeom_airy_zero(NULL, NULL, res, NULL, k, prec);
    fmpz_clear(k);
}


void arb_airy_bi_prime_zero(arb_t res, const int n, slong prec)
{
    fmpz_t k; fmpz_init(k); fmpz_set_si(k, n);
    arb_hypgeom_airy_zero(NULL, NULL, NULL, res, k, prec);
    fmpz_clear(k);
}







/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


void arb_hypgeom_1f1_(arb_t res, const arb_t a, const arb_t b, const arb_t x, slong prec)
{
    arb_hypgeom_1f1(res, a, b, x, 0, prec) ;
}


void arb_hypgeom_1f1r_(arb_t res, const arb_t a, const arb_t b, const arb_t x, slong prec)
{
    arb_hypgeom_1f1(res, a, b, x, 1, prec) ;
}







/* Gamma function and related functions */



void arb_beta_(arb_t res, const arb_t a, const arb_t b, slong prec)
{
    arb_t t, u;

    arb_init(t);
    arb_init(u);

    arb_gamma(t, a, prec);
    arb_gamma(u, b, prec);

    arb_add(res, a, b, prec);
    arb_rgamma(res, res, prec);
    arb_mul(res, res, t, prec);
    arb_mul(res, res, u, prec);

    arb_clear(t);
    arb_clear(u);
}





/* Incomplete gamma functions */



void arb_gamma_upper_(arb_t res, const arb_t a, const arb_t x, slong prec)
{
    arb_hypgeom_gamma_upper(res, a, x, 0, prec);
}


void arb_gamma_upper_r(arb_t res, const arb_t a, const arb_t x, slong prec)
{
    arb_hypgeom_gamma_upper(res, a, x, 1, prec);
}


void arb_gamma_q(arb_t out1, const arb_t a,  const arb_t x, slong wp)
{
    arb_hypgeom_gamma_upper(out1, a, x, 1, wp);
}


void arb_gamma_lower_(arb_t res, const arb_t a, const arb_t x, slong prec)
{
    arb_hypgeom_gamma_lower(res, a, x, 0, prec);
}


void arb_gamma_lower_r(arb_t res, const arb_t a, const arb_t x, slong prec)
{
    arb_hypgeom_gamma_lower(res, a, x, 1, prec);
}


void arb_gamma_p(arb_t out1, const arb_t a,  const arb_t x, slong wp)
{
    arb_hypgeom_gamma_lower(out1, a, x, 1, wp);
}


void arb_gamma_p_derivative(arb_t out1, const arb_t a,  const arb_t x, slong wp)
{
    arb_t x1; arb_t x2; arb_t x3; arb_t a1;
    arb_init(x1); arb_init(x2); arb_init(x3); arb_init(a1);

    arb_neg(x1, x);
    arb_exp(x1, x1, wp);

    arb_add_si(a1, a, -1, wp);
    arb_pow(x2, x, a1, wp);

    arb_gamma(x3, a, wp);

    arb_mul(out1, x1, x2, wp);
    arb_div(out1, out1, x3, wp);

    arb_clear(x1); arb_clear(x2); arb_clear(x3); arb_clear(a1);
}






/* Error function and related functions */



void arb_ndens(arb_t out1, const arb_t x, slong wp)
{
    arb_t x1; arb_t x2;
    arb_init(x1); arb_init(x2);

    arb_sqr(x1, x, wp);
    arb_neg(x1, x1);
    arb_div_ui(x1, x1, 2, wp);
    arb_exp(x1, x1, wp);

    arb_const_pi(x2, wp);
    arb_mul_ui(x2, x2, 2, wp);
    arb_rsqrt(x2, x2, wp);

    arb_mul(out1, x1, x2, wp);

    arb_clear(x1); arb_clear(x2);
}


void arb_ndis(arb_t out1, const arb_t x, slong wp)
{
    arb_t x1; arb_t x2; arb_t x3;
    arb_init(x1); arb_init(x2); arb_init(x3);

    arb_neg(x1, x);
    arb_sqrt_ui(x2, 2, wp);
    arb_div(x3, x1, x2, wp);
    arb_hypgeom_erfc(out1, x3, wp);
    arb_div_ui(out1, out1, 2, wp);

    arb_clear(x1); arb_clear(x2); arb_clear(x3);
}




void arb_fresnelc(arb_t res, const arb_t x, slong prec)
{
    arb_hypgeom_fresnel(res, NULL, x, 1, prec);
}



void arb_fresnels(arb_t res, const arb_t x, slong prec)
{
    arb_hypgeom_fresnel(NULL, res, x, 1, prec);
}





/* Exponential integrals and related functions */



void arb_hypgeom_li_(arb_t res, const arb_t x, slong prec)
{
    arb_hypgeom_li(res, x, 0, prec);
}


void arb_hypgeom_li_offset(arb_t res, const arb_t x, slong prec)
{
    arb_hypgeom_li(res, x, 1, prec);
}





/* 1F1: Orthogonal polynomials */






/* 1F1: Coulomb functions */


void arb_hypgeom_coulomb_f(arb_t res, const arb_t l, const arb_t eta, const arb_t x, slong prec)
{
    arb_hypgeom_coulomb(res, NULL, l, eta, x, prec);
}


void arb_hypgeom_coulomb_g(arb_t res, const arb_t l, const arb_t eta, const arb_t x, slong prec)
{
    arb_hypgeom_coulomb(NULL, res, l, eta, x, prec);
}







/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */


void arb_hypgeom_2f1_(arb_t res, const arb_t a, const arb_t b, const arb_t c, const arb_t x, slong prec)
{
    arb_hypgeom_2f1(res, a, b, c, x, 0, prec) ;
}


void arb_hypgeom_2f1r_(arb_t res, const arb_t a, const arb_t b, const arb_t c, const arb_t x, slong prec)
{
    arb_hypgeom_2f1(res, a, b, c, x, 1, prec) ;
}




/* 2F1: Orthogonal polynomials */



void arb_hypgeom_legendre_p_(arb_t res, const arb_t n, const arb_t m, const arb_t x, slong prec)
{
    arb_hypgeom_legendre_p(res, n, m, x, 0, prec);
}


void arb_hypgeom_legendre_pv_(arb_t res, const arb_t n, const arb_t m, const arb_t x, slong prec)
{
    arb_hypgeom_legendre_p(res, n, m, x, 1, prec);
}


void arb_hypgeom_legendre_q_(arb_t res, const arb_t n, const arb_t m, const arb_t x, slong prec)
{
    arb_hypgeom_legendre_q(res, n, m, x, 0, prec);
}


void arb_hypgeom_legendre_qv_(arb_t res, const arb_t n, const arb_t m, const arb_t x, slong prec)
{
    arb_hypgeom_legendre_q(res, n, m, x, 1, prec);
}




/* 2F1: Incomplete Beta Function */


void arb_hypgeom_beta_lower_(arb_t res, const arb_t a, const arb_t b, const arb_t x, slong prec)
{
    arb_hypgeom_beta_lower(res, a, b, x, 0, prec);
}


void arb_hypgeom_beta_lower_r_(arb_t res, const arb_t a, const arb_t b, const arb_t x, slong prec)
{
    arb_hypgeom_beta_lower(res, a, b, x, 1, prec);
}


void arb_ibeta(arb_t out1, const arb_t a,  const arb_t b,  const arb_t x, slong wp)
{
    arb_hypgeom_beta_lower(out1, a, b, x, 1, wp) ;
}


void arb_ibetac(arb_t out1, const arb_t a,  const arb_t b,  const arb_t x, slong wp)
{
    arb_t x1; arb_init(x1);
    arb_neg(x1, x);
    arb_add_si(x1, x1, 1, wp);

    arb_hypgeom_beta_lower(out1, b, a, x1, 1, wp);
    arb_clear(x1);
}


void arb_ibeta_derivative(arb_t out1, const arb_t a,  const arb_t b,  const arb_t x, slong wp)
{
    arb_t x1; arb_t x2; arb_t x3; arb_t x4; arb_t a1; arb_t b1;
    arb_init(x1); arb_init(x2); arb_init(x3); arb_init(x4); arb_init(a1); arb_init(b1);

    arb_neg(x1, x);
    arb_add_si(x1, x1, 1, wp);

    arb_add_si(b1, b, -1, wp);
    arb_pow(x1, x1, b1, wp);

    arb_add_si(a1, a, -1, wp);
    arb_pow(x2, x, a1, wp);

    arb_beta_(x3, a, b, wp);

    arb_mul(out1, x1, x2, wp);
    arb_div(out1, out1, x3, wp);

    arb_clear(x1); arb_clear(x2); arb_clear(x3); arb_clear(x4); arb_clear(a1); arb_clear(b1);
}







/* Hypergeometric Function 1F2, overview */


void arb_hypgeom_1f2_old(arb_t res, const arb_t a1, const arb_t b1, const arb_t b2,
                     const arb_t z, int regularized, slong prec)
{
    arb_t a;
    arb_struct b[3];
    arb_init(a);
    arb_init(b);
    arb_init(b + 1);
    arb_init(b + 2);
    arb_set(a, a1);
    arb_set(b, b1);
    arb_set(b + 1, b2);
    arb_one(b + 2);
    arb_hypgeom_pfq(res, a, 1, b, 3, z, -1, prec);
    arb_clear(a);
    arb_clear(b);
    arb_clear(b + 1);
    arb_clear(b + 2);
}








void arb_hypgeom_1f2(arb_t res, const arb_t a1, const arb_t b1, const arb_t b2,
    const arb_t z, int regularized, slong prec)
{
    arb_t a;
    arb_struct b[2];
    arb_init(a);
    arb_init(b);
    arb_init(b + 1);
    arb_set(a, a1);
    arb_set(b, b1);
    arb_set(b + 1, b2);
    arb_hypgeom_pfq(res, a, 1, b, 2, z, regularized, prec);
    arb_clear(a);
    arb_clear(b);
    arb_clear(b + 1);
}


void arb_hypgeom_1f2_(arb_t res, const arb_t a1, const arb_t b1, const arb_t b2, const arb_t z, slong prec)
{
    arb_hypgeom_1f2(res, a1, b1, b2, z, 0, prec) ;
}


void arb_hypgeom_1f2r_(arb_t res, const arb_t a1, const arb_t b1, const arb_t b2, const arb_t z, slong prec)
{
    arb_hypgeom_1f2(res, a1, b1, b2, z, 1, prec) ;
}










/* **************** ACB, general ************************ */



void Lib_Acb_GL_Integration(AcbPtr s, void* f, AcbPtr a, AcbPtr b, mpNumMatrixPtr params, int32_t  prec,
    int32_t  verbose, int32_t  rel_goal, int32_t  abs_tol_bits, int32_t  eval_limit)
{
    /* typical choice: prec = workingprec, rel_goal = prec, abs_tol_bits = prec , eval_limit = 200*/

    mag_t tol;
    acb_calc_integrate_opt_t options;

    /*  initialize  */

    acb_calc_integrate_opt_init(options);
    mag_init(tol);
    mag_set_ui_2exp_si(tol, 1, -abs_tol_bits);

    options->verbose = verbose;
    options->eval_limit = eval_limit;

    /*  Integral:   */
    acb_calc_integrate((acb_ptr)s, (acb_calc_func_t)f, params, (acb_ptr)a, (acb_ptr)b, rel_goal, tol, options, prec);

    if (verbose > 0)
    {
        flint_printf("Integral_GL: ");
        acb_printn((acb_ptr)s, 3.333 * prec, 0);
        flint_printf("\n");
        flint_printf("\n");
    }

    /*  clean up  */
    mag_clear(tol);

}





void acb_set_ui64(acb_t x, uint64_t uint64)
{
    if (FLINT_BITS == 64)
    {
        acb_set_ui( (acb_ptr) x, uint64);
    }
    else
    {
        fmpz_t z; fmpz_init(z); fmpz_set_ui64(z, uint64);
        acb_set_fmpz(x, z);
        fmpz_clear(z);
    }
}



void acb_set_si64(acb_t x, int64_t sint64)
{
    if (FLINT_BITS == 64)
    {
        acb_set_si( (acb_ptr) x, sint64);
    }
    else
    {
        fmpz_t z; fmpz_init(z); fmpz_set_si64(z, sint64);
        acb_set_fmpz(x, z);
        fmpz_clear(z);
    }
}


void acb_set_mpfr(acb_t out1, mpfr_t in1)
{
    arf_set_mpfr(arb_midref(acb_realref(out1)), (mpfr_ptr) in1);
    arf_set_si(arb_midref(acb_imagref(out1)), 0);
}



void acb_set_mpc(acb_t out1, mpc_t in1)
{
    arf_set_mpfr(arb_midref(acb_realref(out1)), mpc_realref((mpc_ptr) in1));
    arf_set_mpfr(arb_midref(acb_imagref(out1)), mpc_imagref((mpc_ptr) in1));
}



void acb_get_mpc(mpc_t out1, acb_t in1)
{
    arf_get_mpfr(mpc_realref((mpc_ptr) out1), arb_midref(acb_realref(in1)), MPFR_RNDN);
    arf_get_mpfr(mpc_imagref((mpc_ptr) out1), arb_midref(acb_imagref(in1)), MPFR_RNDN);
}

//
//void acb_set_mpci(acb_t x, mpci_t z)
//{
//	arb_set_mpfi(acb_realref((acb_ptr)x), z->real);
//	arb_set_mpfi(acb_imagref((acb_ptr)x), z->imag);
//}
//
//
//



/* **************** ACB, special functions ************************ */





//////////////////////////////////////////////////////
//// Acb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */



void acb_unit_root_(acb_t out1, int32_t k, slong wp)
{
    acb_unit_root(out1, k, wp);
}



void acb_root_ui_(acb_t out1, const acb_t in1, int32_t in2, slong wp)
{
    acb_root_ui(out1, in1,  in2, wp);
}




void acb_root_si_(acb_t res, const acb_t x, int32_t n, slong prec)
{
    uint32_t n_ = (n < 0) ? -n : n;
	acb_root_ui(res, x, n_, prec);
    if (n < 0) { acb_inv(res, res, prec); }
}



void acb_cbrt(acb_t res, const acb_t x, slong prec)
{
    acb_root_ui(res, x, 3, prec) ;
}


void acb_sqrt1pm1(acb_t out1, const acb_t in1, slong wp)
{
    acb_t y; acb_init(y);
    acb_log1p(y, in1, wp);
    acb_div_ui(y, y, 2, wp);
    acb_expm1(out1, y, wp) ;
    acb_clear(y);
}






/* Exponential and related functions */





void acb_expj_(acb_t out1, const acb_t in1, slong wp)
{
    acb_t s; acb_init(s);
    acb_sin_cos(s, out1, in1, wp);
    acb_mul_onei(s, s);
    acb_add(out1, out1, s, wp);
    acb_clear(s);
}


void acb_exp10_(acb_t out1, const acb_t in1, slong wp)
{
    arb_t log10;
    acb_t temp1;
    arb_init(log10); acb_init(temp1);
    arb_const_log10(log10, wp);
    acb_mul_arb(temp1, in1, log10, wp);
    acb_exp(out1, temp1, wp);
    acb_clear(temp1); arb_clear(log10);
}



void acb_exp2_(acb_t out1, const acb_t in1, slong wp)
{
    arb_t log2;
    acb_t temp1;
    arb_init(log2); acb_init(temp1);
    arb_const_log2(log2, wp);
    acb_mul_arb(temp1, in1, log2, wp);
    acb_exp(out1, temp1, wp);
    acb_clear(temp1); arb_clear(log2);
}



void acb_exp10m1_(acb_t out1, const acb_t in1, slong wp)
{
    arb_t log10;
    acb_t temp1;
    arb_init(log10); acb_init(temp1);
    arb_const_log10(log10, wp);
    acb_mul_arb(temp1, in1, log10, wp);
    acb_expm1(out1, temp1, wp);
    acb_clear(temp1); arb_clear(log10);
}



void acb_exp2m1_(acb_t out1, const acb_t in1, slong wp)
{
    arb_t log2;
    acb_t temp1;
    arb_init(log2); acb_init(temp1);
    arb_const_log2(log2, wp);
    acb_mul_arb(temp1, in1, log2, wp);
    acb_expm1(out1, temp1, wp);
    acb_clear(temp1); arb_clear(log2);
}



void acb_exprel_(acb_t out1, const acb_t in1, slong wp)
{
    if (acb_is_zero(in1))
    {
        acb_one(out1);
    }
    else
    {
        acb_expm1(out1, in1, wp);
        acb_div(out1, out1, in1, wp);
    }
}




/* Logarithms and related functions */



void acb_logbase_(acb_t out1, const acb_t z, const acb_t b, slong wp)
{
    acb_t temp1; acb_init(temp1);
    acb_log(out1, z, wp);
    acb_log(temp1, b, wp);
    acb_div(out1, out1, temp1, wp);
    acb_clear(temp1);
}



void acb_log10_(acb_t out1, const acb_t in1, slong wp)
{
    arb_t log10;
    acb_t temp1;
    arb_init(log10); acb_init(temp1);
    arb_const_log10(log10, wp);
    acb_log(temp1, in1, wp);
    acb_div_arb(out1, temp1, log10, wp);
    acb_clear(temp1); arb_clear(log10);
}


void acb_log2_(acb_t out1, const acb_t in1, slong wp)
{
    arb_t log2;
    acb_t temp1;
    arb_init(log2); acb_init(temp1);
    arb_const_log2(log2, wp);
    acb_log(temp1, in1, wp);
    acb_div_arb(out1, temp1, log2, wp);
    acb_clear(temp1); arb_clear(log2);
}




void acb_log10p1_(acb_t out1, const acb_t in1, slong wp)
{
    arb_t log10;
    acb_t temp1;
    arb_init(log10); acb_init(temp1);
    arb_const_log10(log10, wp);
    acb_log1p(temp1, in1, wp);
    acb_div_arb(out1, temp1, log10, wp);
    acb_clear(temp1); arb_clear(log10);
}



void acb_log2p1_(acb_t out1, const acb_t in1, slong wp)
{
    arb_t log2;
    acb_t temp1;
    arb_init(log2); acb_init(temp1);
    arb_const_log2(log2, wp);
    acb_log1p(temp1, in1, wp);
    acb_div_arb(out1, temp1, log2, wp);
    acb_clear(temp1); arb_clear(log2);
}







void acb_lambertw_ui_(acb_t out1, const acb_t in1, int32_t in2, slong wp)
{
    fmpz_t k; fmpz_init(k); fmpz_set_si(k, in2);
    acb_lambertw(out1, in1, k, 0, wp) ;
    fmpz_clear(k);
}




/* Power functions */



void acb_pow_si_(acb_t out1, const acb_t in1, int32_t in2, slong wp)
{
    acb_pow_si(out1, in1,  in2, wp);
}




void acb_compound_si_(acb_t res, const acb_t x, int32_t n, slong prec)
{
    acb_add_si(res, x, 1, prec);
	acb_pow_si((acb_ptr)res, (acb_ptr)res, n, prec);
}




void acb_powm1_(acb_t out1, const acb_t a, const acb_t b, slong wp)
{
    acb_t x; acb_init(x);
    acb_log(x, a, wp);
    acb_mul(x, b, x, wp);
    acb_expm1(out1, x, wp) ;
    acb_clear(x);
}



void acb_pow1p_(acb_t out1, const acb_t a, const acb_t b, slong wp)
{
    acb_t x; acb_init(x);
    acb_log1p(x, a, wp);
    acb_mul(x, b, x, wp);
    acb_expm1(out1, x, wp) ;
    acb_clear(x);
}



void acb_pow1pm1_(acb_t out1, const acb_t a, const acb_t b, slong wp)
{
    acb_t x; acb_init(x);
    acb_log1p(x, a, wp);
    acb_mul(x, b, x, wp);
    acb_expm1(out1, x, wp) ;
    acb_clear(x);
}




void acb_hypot_(acb_t out1, const acb_t a, const acb_t b, slong wp)
{
    acb_t x; acb_init(x); acb_sqr(x, a, wp);
    acb_t y; acb_init(y); acb_sqr(y, b, wp);
    acb_add(x, x, y, wp);
    acb_sqrt(out1, x, wp) ;
    acb_clear(x); acb_clear(y);
}




/* Trigonometric and related functions */




void acb_sec_pi_(acb_t res, const acb_t x, slong prec)
{
    acb_cos_pi(res, x, prec);
    acb_inv(res, res, prec);
}






/* Hyperbolic functions */






/* Inverse trigonometric functions */


void acb_acsc(acb_t out1, const acb_t in1, slong wp)
{
    acb_t y; acb_init(y); acb_inv(y, in1, wp);
    acb_asin(out1, y, wp) ;
    acb_clear(y);
}


void acb_asec(acb_t out1, const acb_t in1, slong wp)
{
    acb_t y; acb_init(y); acb_inv(y, in1, wp);
    acb_acos(out1, y, wp) ;
    acb_clear(y);
}


void acb_acot(acb_t out1, const acb_t in1, slong wp)
{
    acb_t y; acb_init(y); acb_inv(y, in1, wp);
    acb_atan(out1, y, wp) ;
    acb_clear(y);
}





/* Inverse hyperbolic functions */



void acb_acsch(acb_t out1, const acb_t in1, slong wp)
{
    acb_t y; acb_init(y); acb_inv(y, in1, wp);
    acb_asinh(out1, y, wp) ;
    acb_clear(y);
}


void acb_asech(acb_t out1, const acb_t in1, slong wp)
{
    acb_t y; acb_init(y); acb_inv(y, in1, wp);
    acb_acosh(out1, y, wp) ;
    acb_clear(y);
}


void acb_acoth(acb_t out1, const acb_t in1, slong wp)
{
    acb_t y; acb_init(y); acb_inv(y, in1, wp);
    acb_atanh(out1, y, wp) ;
    acb_clear(y);
}







/* Legendre elliptic integrals (elliptic parameter m) */


void acb_elliptic_f_(acb_t res, const acb_t phi, const acb_t m, slong prec)
{
   acb_elliptic_f(res, phi, m, 0, prec);
}



void acb_elliptic_e_inc_(acb_t res, const acb_t phi, const acb_t m, slong prec)
{
   acb_elliptic_e_inc(res, phi, m, 0, prec);
}




void acb_elliptic_pi_inc_(acb_t res, const acb_t n, const acb_t phi, const acb_t m, slong prec)
{
    acb_elliptic_pi_inc(res, n, phi, m, 0, prec);
}



/* Legendre elliptic integrals (elliptic modulus k), and related functions */




void acb_elliptic_k_k_(acb_t res, const acb_t k, slong prec)
{
    acb_t m; acb_init(m); acb_sqr(m, k, prec);
    acb_elliptic_k(res, m,  prec);
    acb_clear(m);
}



void acb_elliptic_e_k_(acb_t res, const acb_t k, slong prec)
{
    acb_t m; acb_init(m); acb_sqr(m, k, prec);
    acb_elliptic_e(res, m,  prec);
    acb_clear(m);
}





void acb_elliptic_pi_k_(acb_t res, const acb_t phi, const acb_t k, slong prec)
{
    acb_t m; acb_init(m); acb_sqr(m, k, prec);
    acb_elliptic_pi(res, phi, m,  prec);
    acb_clear(m);
}




void acb_elliptic_f_k_(acb_t res, const acb_t phi, const acb_t k, slong prec)
{
    acb_t m; acb_init(m); acb_sqr(m, k, prec);
    acb_elliptic_f(res, phi, m, 0, prec);
    acb_clear(m);
}




void acb_elliptic_e_inc_k_(acb_t res, const acb_t phi, const acb_t k, slong prec)
{
    acb_t m; acb_init(m); acb_sqr(m, k, prec);
    acb_elliptic_e_inc(res, phi, m, 0, prec);
    acb_clear(m);
}




void acb_elliptic_pi_inc_k_(acb_t res, const acb_t n, const acb_t phi, const acb_t k, slong prec)
{
    acb_t m; acb_init(m); acb_sqr(m, k, prec);
    acb_elliptic_pi_inc(res, n, phi, m, 0, prec);
    acb_clear(m);
}





/* Carlson symmetric elliptic integrals */




void acb_elliptic_rc_(acb_t res, const acb_t x, const acb_t y, slong prec)
{
   acb_elliptic_rf(res, x, y, y, 0, prec);
}




void acb_elliptic_rf_(acb_t res, const acb_t x, const acb_t y, const acb_t z, slong prec)
{
    acb_elliptic_rf(res, x, y, z, 0, prec);
}


void acb_elliptic_rg_(acb_t res, const acb_t x, const acb_t y, const acb_t z, slong prec)
{
    acb_elliptic_rg(res, x, y, z, 0, prec);
}


void acb_elliptic_rd_(acb_t res, const acb_t x, const acb_t y, const acb_t z, slong prec)
{
    acb_elliptic_rj(res, x, y, z, z, 0, prec);
}


void acb_elliptic_rj_(acb_t res, const acb_t x, const acb_t y, const acb_t z, const acb_t w, slong prec)
{
    acb_elliptic_rj(res, x, y, z, w, 0, prec);
}






/* Jacobi theta functions */




void _acb_theta_jet(acb_t res, const acb_t ncplx, const acb_t z, const acb_t tau, const acb_t dcplx, slong prec)
{
    arb_t nreal, dreal;
    arb_init(nreal); arb_init(dreal);
    acb_get_real(nreal, ncplx);
    acb_get_real(dreal, dcplx);
    int n = arf_get_si(arb_midref(nreal), ARF_RND_NEAR);
    int derivative = arf_get_si(arb_midref(dreal), ARF_RND_NEAR);
    int len = derivative + 1;
    acb_ptr t1, t2, t3, t4;
    t1 = _acb_vec_init(len);
    t2 = _acb_vec_init(len);
    t3 = _acb_vec_init(len);
    t4 = _acb_vec_init(len);

    acb_modular_theta_jet(t1, t2, t3, t4, z, tau, derivative+1, prec);

    if (n == 1) acb_set(res, t1 + derivative);
    if (n == 2) acb_set(res, t2 + derivative);
    if (n == 3) acb_set(res, t3 + derivative);
    if (n == 4) acb_set(res, t4 + derivative);

    arb_clear(nreal); arb_clear(dreal);
    _acb_vec_clear(t1, len);
    _acb_vec_clear(t2, len);
    _acb_vec_clear(t3, len);
    _acb_vec_clear(t4, len);
}




void _acb_theta1(acb_t res, const acb_t z, const acb_t tau, slong prec)
{
    acb_t a, b, c; acb_init(a); acb_init(b); acb_init(c);
    acb_modular_theta(res, a, b, c, z, tau, prec);
    acb_clear(a); acb_clear(b); acb_clear(c);
}

void _acb_theta2(acb_t res, const acb_t z, const acb_t tau, slong prec)
{
    acb_t a, b, c; acb_init(a); acb_init(b); acb_init(c);
    acb_modular_theta(a, res, b, c, z, tau, prec);
    acb_clear(a); acb_clear(b); acb_clear(c);
}

void _acb_theta3(acb_t res, const acb_t z, const acb_t tau, slong prec)
{
    acb_t a, b, c; acb_init(a); acb_init(b); acb_init(c);
    acb_modular_theta(a, b, res, c, z, tau, prec);
    acb_clear(a); acb_clear(b); acb_clear(c);
}

void _acb_theta4(acb_t res, const acb_t z, const acb_t tau, slong prec)
{
    acb_t a, b, c; acb_init(a); acb_init(b); acb_init(c);
    acb_modular_theta(a, b, c, res, z, tau, prec);
    acb_clear(a); acb_clear(b); acb_clear(c);
}

void _acb_theta1q(acb_t res, const acb_t z, const acb_t q, slong prec)
{
    acb_t tau, pi, z1; acb_init(tau); acb_init(pi); acb_init(z1);
    acb_const_pi(pi, prec);
    acb_log(tau, q, prec);
    acb_div(tau, tau, pi, prec);
    acb_div_onei(tau, tau);
    acb_div(z1, z, pi, prec);
    _acb_theta1(res, z1, tau, prec);
    acb_clear(tau); acb_clear(pi); acb_clear(z1);
}

void _acb_theta2q(acb_t res, const acb_t z, const acb_t q, slong prec)
{
    acb_t tau, pi, z1; acb_init(tau); acb_init(pi); acb_init(z1);
    acb_const_pi(pi, prec);
    acb_log(tau, q, prec);
    acb_div(tau, tau, pi, prec);
    acb_div_onei(tau, tau);
    acb_div(z1, z, pi, prec);
    _acb_theta2(res, z1, tau, prec);
    acb_clear(tau); acb_clear(pi); acb_clear(z1);
}

void _acb_theta3q(acb_t res, const acb_t z, const acb_t q, slong prec)
{
    acb_t tau, pi, z1; acb_init(tau); acb_init(pi); acb_init(z1);
    acb_const_pi(pi, prec);
    acb_log(tau, q, prec);
    acb_div(tau, tau, pi, prec);
    acb_div_onei(tau, tau);
    acb_div(z1, z, pi, prec);
    _acb_theta3(res, z1, tau, prec);
    acb_clear(tau); acb_clear(pi); acb_clear(z1);
}

void _acb_theta4q(acb_t res, const acb_t z, const acb_t q, slong prec)
{
    acb_t tau, pi, z1; acb_init(tau); acb_init(pi); acb_init(z1);
    acb_const_pi(pi, prec);
    acb_log(tau, q, prec);
    acb_div(tau, tau, pi, prec);
    acb_div_onei(tau, tau);
    acb_div(z1, z, pi, prec);
    _acb_theta4(res, z1, tau, prec);
    acb_clear(tau); acb_clear(pi); acb_clear(z1);
}




/* Jacobi elliptic functions */





void _acb_qfromk(acb_t res, const acb_t k, slong prec)
{
    acb_t kc, e1, e2, pi; acb_init(kc); acb_init(e1); acb_init(e2); acb_init(pi);
    acb_sqr(kc, k, prec);
    acb_sub_si(kc, kc, 1, prec);
    acb_neg(kc, kc);
    acb_sqrt(kc, kc, prec);
    acb_elliptic_k_k_(e1, k, prec);
    acb_elliptic_k_k_(e2, kc, prec);
    acb_const_pi(pi, prec);
    acb_div(res, e2, e1, prec);
    acb_mul(res, res, pi, prec);
    acb_neg(res, res);
    acb_exp(res, res, prec);
    acb_clear(kc); acb_clear(e1); acb_clear(e2); acb_clear(pi);
}



void _acb_tfrom_u_q(acb_t res, const acb_t u, const acb_t q, slong prec)
{
    acb_t t3, zero; acb_init(t3); acb_init(zero);
    acb_zero(zero);
    _acb_theta3q(t3, zero, q, prec);
    acb_sqr(t3, t3, prec);
    acb_div(res, u, t3, prec);
    acb_clear(t3); acb_clear(zero);
}




void _acb_sn_t_q(acb_t res, const acb_t t, const acb_t q, slong prec)
{
    acb_t t2, t3, tt1, tt4, zero;
    acb_init(t2); acb_init(t3); acb_init(tt1); acb_init(tt4); acb_init(zero);
    acb_zero(zero);
    _acb_theta2q(t2, zero, q, prec);
    _acb_theta3q(t3, zero, q, prec);

    _acb_theta1q(tt1, t, q, prec);
    _acb_theta4q(tt4, t, q, prec);

    acb_mul(t3, t3, tt1, prec);
    acb_mul(t2, t2, tt4, prec);
    acb_div(res, t3, t2, prec);
    acb_clear(t2); acb_clear(t3); acb_clear(tt1); acb_clear(tt4); acb_clear(zero);
}





void _acb_cn_t_q(acb_t res, const acb_t t, const acb_t q, slong prec)
{
    acb_t t2, t4, tt2, tt4, zero;
    acb_init(t2); acb_init(t4); acb_init(tt2); acb_init(tt4); acb_init(zero);
    acb_zero(zero);
    _acb_theta2q(t2, zero, q, prec);
    _acb_theta4q(t4, zero, q, prec);

    _acb_theta2q(tt2, t, q, prec);
    _acb_theta4q(tt4, t, q, prec);

    acb_mul(t4, t4, tt2, prec);
    acb_mul(t2, t2, tt4, prec);
    acb_div(res, t4, t2, prec);
    acb_clear(t2); acb_clear(t4); acb_clear(tt2); acb_clear(tt4); acb_clear(zero);
}






void _acb_dn_t_q(acb_t res, const acb_t t, const acb_t q, slong prec)
{
    acb_t t3, t4, tt3, tt4, zero;
    acb_init(t3); acb_init(t4); acb_init(tt3); acb_init(tt4); acb_init(zero);
    acb_zero(zero);
    _acb_theta3q(t3, zero, q, prec);
    _acb_theta4q(t4, zero, q, prec);

    _acb_theta3q(tt3, t, q, prec);
    _acb_theta4q(tt4, t, q, prec);

    acb_mul(t4, t4, tt3, prec);
    acb_mul(t3, t3, tt4, prec);
    acb_div(res, t4, t3, prec);
    acb_clear(t3); acb_clear(t4); acb_clear(tt3); acb_clear(tt4); acb_clear(zero);
}





void _acb_jacobi_sn(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t, q; acb_init(t); acb_init(q);
    _acb_qfromk(q, k, prec);
    _acb_tfrom_u_q(t, u, q, prec);
    _acb_sn_t_q(res, t, q, prec);
    acb_clear(t); acb_clear(q);
}


void _acb_jacobi_cn(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t, q; acb_init(t); acb_init(q);
    _acb_qfromk(q, k, prec);
    _acb_tfrom_u_q(t, u, q, prec);
    _acb_cn_t_q(res, t, q, prec);
    acb_clear(t); acb_clear(q);
}

void _acb_jacobi_dn(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t, q; acb_init(t); acb_init(q);
    _acb_qfromk(q, k, prec);
    _acb_tfrom_u_q(t, u, q, prec);
    _acb_dn_t_q(res, t, q, prec);
    acb_clear(t); acb_clear(q);
}




void _acb_jacobi_ns(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    _acb_jacobi_sn(res, u, k, prec);
    acb_inv(res, res, prec);
}


void _acb_jacobi_nc(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    _acb_jacobi_cn(res, u, k, prec);
    acb_inv(res, res, prec);
}


void _acb_jacobi_nd(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    _acb_jacobi_dn(res, u, k, prec);
    acb_inv(res, res, prec);
}



void _acb_jacobi_sc(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t; acb_init(t);
    _acb_jacobi_sn(res, u, k, prec);
    _acb_jacobi_cn(t, u, k, prec);
    acb_div(res, res, t, prec);
    acb_clear(t);
}



void _acb_jacobi_sd(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t; acb_init(t);
    _acb_jacobi_sn(res, u, k, prec);
    _acb_jacobi_dn(t, u, k, prec);
    acb_div(res, res, t, prec);
    acb_clear(t);
}



void _acb_jacobi_dc(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t; acb_init(t);
    _acb_jacobi_dn(res, u, k, prec);
    _acb_jacobi_cn(t, u, k, prec);
    acb_div(res, res, t, prec);
    acb_clear(t);
}



void _acb_jacobi_ds(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t; acb_init(t);
    _acb_jacobi_dn(res, u, k, prec);
    _acb_jacobi_sn(t, u, k, prec);
    acb_div(res, res, t, prec);
    acb_clear(t);
}



void _acb_jacobi_cs(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t; acb_init(t);
    _acb_jacobi_cn(res, u, k, prec);
    _acb_jacobi_sn(t, u, k, prec);
    acb_div(res, res, t, prec);
    acb_clear(t);
}



void _acb_jacobi_cd(acb_t res, const acb_t u, const acb_t k, slong prec)
{
    acb_t t; acb_init(t);
    _acb_jacobi_cn(res, u, k, prec);
    _acb_jacobi_dn(t, u, k, prec);
    acb_div(res, res, t, prec);
    acb_clear(t);
}








/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */




void _acb_wp_prime(acb_t res, const acb_t z, const acb_t tau, slong prec)
{
    acb_ptr t1;
    int len = 2;
    t1 = _acb_vec_init(len);
    acb_elliptic_p_jet(t1, z, tau, len, prec);
    acb_set(res, t1 + 1);
    _acb_vec_clear(t1, len);
}




void _acb_elliptic_invariant_g2(acb_t res, const acb_t tau, slong prec)
{
    acb_t a; acb_init(a);
    acb_elliptic_invariants(res, a, tau, prec);
    acb_clear(a);
}


void _acb_elliptic_invariant_g3(acb_t res, const acb_t tau, slong prec)
{
    acb_t a; acb_init(a);
    acb_elliptic_invariants(a, res, tau, prec);
    acb_clear(a);
}




void _acb_elliptic_root_e1(acb_t res, const acb_t tau, slong prec)
{
    acb_t a, b; acb_init(a); acb_init(b);
    acb_elliptic_roots(res, a, b, tau, prec);
    acb_clear(a); acb_clear(b);
}



void _acb_elliptic_root_e2(acb_t res, const acb_t tau, slong prec)
{
    acb_t a, b; acb_init(a); acb_init(b);
    acb_elliptic_roots(a, res, b, tau, prec);
    acb_clear(a); acb_clear(b);
}



void _acb_elliptic_root_e3(acb_t res, const acb_t tau, slong prec)
{
    acb_t a, b; acb_init(a); acb_init(b);
    acb_elliptic_roots(a, b, res, tau, prec);
    acb_clear(a); acb_clear(b);
}





/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */



void _acb_lerch_zeta(acb_t res, const acb_t lambda1, const acb_t alpha, const acb_t s, slong prec)
{
    acb_t z; acb_init(z);
    acb_mul_si(z, lambda1, 2, prec);
    acb_exp_pi_i(z, z, prec);
    acb_dirichlet_lerch_phi(res, z, s, alpha, prec);
    acb_clear(z);
}





/* Polygamma functions */



void _acb_trigamma(acb_t res, const acb_t z, slong prec)
{
    acb_t s; acb_init(s);
    acb_set_si(s, 1);
    acb_polygamma(res, s, z, prec);
    acb_clear(s);
}





/* Polylogarithms and related functions */



void _acb_trilog(acb_t res, const acb_t z, slong prec)
{
    acb_t s; acb_init(s);
    acb_set_si(s, 3);
    acb_polylog(res, s, z, prec);
    acb_clear(s);
}


void _acb_clausen_sin(acb_t res, const acb_t s, const acb_t z, slong prec)
{
    acb_t z1; acb_t z2; acb_init(z1); acb_init(z2);
    acb_mul_onei(z1, z);
    acb_exp_invexp(z1, z2, z1, prec);
    acb_polylog(z1, s, z1, prec);
    acb_polylog(z2, s, z2, prec);
    acb_sub(res, z1, z2, prec);
    acb_div_si(res, res, 2, prec);
    acb_div_onei(res, res);
    acb_clear(z1); acb_clear(z2);
}


void _acb_clausen_cos(acb_t res, const acb_t s, const acb_t z, slong prec)
{
    acb_t z1; acb_t z2; acb_init(z1); acb_init(z2);
    acb_mul_onei(z1, z);
    acb_exp_invexp(z1, z2, z1, prec);
    acb_polylog(z1, s, z1, prec);
    acb_polylog(z2, s, z2, prec);
    acb_add(res, z1, z2, prec);
    acb_div_si(res, res, 2, prec);
    acb_clear(z1); acb_clear(z2);
}



void _acb_clausen2(acb_t res, const acb_t z, slong prec)
{
    acb_t s; acb_t z1; acb_init(s); acb_init(z1);
    acb_set_si(s, 2);
    acb_mul_onei(z1, z);
    acb_exp(z1, z1, prec);
    acb_polylog(res, s, z1, prec);
    acb_clear(s); acb_clear(z1);
}


void _acb_bose_einstein(acb_t res, const acb_t s, const acb_t z, slong prec)
{
    acb_t s1; acb_t z1; acb_init(s1);  acb_init(z1);
    acb_add_si(s1, s, 1, prec);
    acb_exp(z1, z, prec);
    acb_polylog(res, s1, z1, prec);
    acb_clear(s1); acb_clear(z1);
}


void _acb_fermi_dirac(acb_t res, const acb_t s, const acb_t z, slong prec)
{
    acb_t s1; acb_t z1; acb_init(s1);  acb_init(z1);
    acb_add_si(s1, s, 1, prec);
    acb_exp(z1, z, prec);
    acb_neg(z1, z1);
    acb_polylog(res, s1, z1, prec);
    acb_neg(res, res);
    acb_clear(s1); acb_clear(z1);
}


void _acb_legendre_chi(acb_t res, const acb_t s, const acb_t z, slong prec)
{
    acb_t z1; acb_t z2; acb_init(z1); acb_init(z2);
    acb_set(z1, z);
    acb_neg(z2, z);
    acb_polylog(z1, s, z, prec);
    acb_polylog(z2, s, z2, prec);
    acb_sub(res, z1, z2, prec);
    acb_div_si(res, res, 2, prec);
    acb_clear(z1); acb_clear(z2);
}


void _acb_ti(acb_t res, const acb_t s, const acb_t z, slong prec)
{
    acb_t z1; acb_t z2; acb_init(z1); acb_init(z2);
    acb_mul_onei(z1, z);
    acb_neg(z2, z1);
    acb_polylog(z1, s, z1, prec);
    acb_polylog(z2, s, z2, prec);
    acb_sub(res, z1, z2, prec);
    acb_div_si(res, res, 2, prec);
    acb_div_onei(res, res);
    acb_clear(z1); acb_clear(z2);
}





/* Hurwitz zeta function and related functions */



void acb_stieltjes_ui_(acb_t out1, const acb_t in1, int32_t in2, slong wp)
{
    fmpz_t k; fmpz_init(k); fmpz_set_si(k, in2);
    acb_dirichlet_stieltjes(out1, k,  in1, wp);
    fmpz_clear(k);
}



void acb_bernoulli_poly_ui_(acb_t out1, const acb_t in1, int32_t n, slong wp)
{
    acb_bernoulli_poly_ui(out1,  n, in1, wp);
}



void _acb_harmonic(acb_t res, const acb_t z, slong prec)
{
    acb_t z1; arb_t g; acb_init(z1); arb_init(g);
    acb_add_si(z1, z, 1, prec);
    acb_digamma(z1, z1, prec);
    arb_const_euler(g, prec);
    acb_add_arb(res, z1, g, prec);
    acb_clear(z1); arb_clear(g);
}




void _acb_harmonic2(acb_t res, const acb_t z, const acb_t r, slong prec)
{
    acb_t z1; acb_t z2; acb_init(z1); acb_init(z2);
    acb_add_si(z1, z, 1, prec);
    acb_zeta(res, r, prec);
    acb_hurwitz_zeta(z2, r, z1, prec);
    acb_sub(res, res, z2, prec);
    acb_clear(z1); acb_clear(z2);
}



void acb_euler_poly_ui_(acb_t res, const acb_t z, int32_t n, slong prec)
{
    int n1 = n+1;
    acb_t z1; acb_t z2; acb_init(z1); acb_init(z2);
    acb_bernoulli_poly_ui(res, n1, z, prec);
    acb_div_si(z1, z, 2, prec);
    acb_bernoulli_poly_ui(z2, n1, z1, prec);
    acb_mul_2exp_si(z2, z2, n1);
    acb_sub(res, res, z2, prec);
    acb_mul_si(res, res, 2, prec);
    acb_div_si(res, res, n1, prec);
    acb_clear(z1); acb_clear(z2);
}




void _acb_hyperfac(acb_t res, const acb_t z, slong prec)
{
    acb_t z1; acb_t z2; acb_t z3; acb_t z4;
    acb_init(z1); acb_init(z2); acb_init(z3); acb_init(z4);
    acb_add_si(z1, z, 1, prec);
    acb_gamma(z2, z1, prec);
    acb_barnes_g(z3, z1, prec);
    acb_pow(z4, z2, z, prec);
    acb_div(res, z4, z3, prec);
    acb_clear(z1); acb_clear(z2); acb_clear(z3); acb_clear(z4);
}



void _acb_superfac(acb_t res, const acb_t z, slong prec)
{
    acb_t z1; acb_init(z1);
    acb_add_si(z1, z, 2, prec);
    acb_barnes_g(res, z1, prec);
    acb_clear(z1);
}





/* Riemann zeta function, and related functions */


void _acb_zetam1(acb_t res, const acb_t s, slong prec)
{
    acb_t two; acb_init(two);
    acb_set_si(two, 2);
    acb_hurwitz_zeta(res, s, two, prec);
    acb_clear(two);
}


void _acb_dirichlet_etam1(acb_t res, const acb_t s, slong prec)
{
    acb_t two; acb_init(two);
    acb_t onems; acb_init(onems);
    acb_t p; acb_init(p);
    acb_t a; acb_init(a);
    acb_t b; acb_init(b);
    acb_t pb; acb_init(pb);

    acb_set_si(two, 2);
    acb_sub_si(onems, s, 1, prec);
    acb_neg(onems, onems);
    acb_pow(p, two, onems, prec);

    _acb_zetam1(a, s, prec);
    acb_zeta(b, s, prec);

    acb_mul(pb, p, b, prec);
    acb_sub(res, a, pb, prec);

    acb_clear(two); acb_clear(onems); acb_clear(p);
    acb_clear(a); acb_clear(b); acb_clear(pb);
}



void _acb_dirichlet_beta(acb_t res, const acb_t s, slong prec)
{
    acb_t z1; acb_t z2; acb_t z3; acb_t z4;
    acb_init(z1); acb_init(z2); acb_init(z3); acb_init(z4);
    acb_t q1; acb_t q3; acb_t ms; acb_t four;
    acb_init(q1); acb_init(q3); acb_init(ms); acb_init(four);

    acb_set_d(q1, 0.25);
    acb_set_d(q3, 0.75);
    acb_neg(ms, s);
    acb_set_si(four, 4);

    acb_hurwitz_zeta(z1, s, q1, prec);
    acb_hurwitz_zeta(z2, s, q3, prec);
    acb_pow(z3, four, ms, prec);
    acb_sub(z4, z1, z2, prec);
    acb_mul(res, z3, z4, prec);

    acb_clear(z1); acb_clear(z2); acb_clear(z3); acb_clear(z4);
}



void _acb_dirichlet_lambda(acb_t res, const acb_t s, slong prec)
{
    acb_t ms; acb_init(ms);
    acb_neg(ms, s);
    acb_exp2m1_(ms, ms, prec);
    acb_neg(ms, ms);
    acb_zeta(res, s, prec);
    acb_mul(res, res, ms, prec);
    acb_clear(ms);
}



void acb_dirichlet_hardy_z_(acb_t res, const acb_t t, slong prec)
{
    acb_dirichlet_hardy_z(res, t, NULL, NULL, 1, prec);
}


void acb_dirichlet_hardy_theta_(acb_t res, const acb_t t, slong prec)
{
    acb_dirichlet_hardy_theta(res, t, NULL, NULL, 1, prec);
}



void acb_dirichlet_zeta_zero_ui_(acb_t out1, int32_t in1, slong wp)
{
    fmpz_t k; fmpz_init(k); fmpz_set_si(k, in1);
    acb_dirichlet_zeta_zero(out1, k, wp);
    fmpz_clear(k);
}








/* Additional numbertheoretic functions */




void acb_hypgeom_0f1_(acb_t res, const acb_t a, const acb_t x, slong prec)
{
    acb_hypgeom_0f1(res, a, x, 0, prec);
}


void acb_hypgeom_0f1_r(acb_t res, const acb_t a, const acb_t x, slong prec)
{
    acb_hypgeom_0f1(res, a, x, 1, prec);
}







/* Confluent Hypergeometric Limit Function 0F1, overview */





/* Bessel functions and modified Bessel functions  */





/* Spherical Bessel functions  */



/* Airy functions  */




void acb_airy_ai(acb_t res, const acb_t x, slong prec)
{
    acb_hypgeom_airy(res, NULL, NULL, NULL, x, prec);
}


void acb_airy_ai_prime(acb_t res, const acb_t x, slong prec)
{
    acb_hypgeom_airy(NULL, res, NULL, NULL, x, prec);
}


void acb_airy_bi(acb_t res, const acb_t x, slong prec)
{
    acb_hypgeom_airy(NULL, NULL, res, NULL, x, prec);
}


void acb_airy_bi_prime(acb_t res, const acb_t x, slong prec)
{
    acb_hypgeom_airy(NULL, NULL, NULL, res, x, prec);
}







/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


void acb_hypgeom_1f1_(acb_t res, const acb_t a, const acb_t b, const acb_t x, slong prec)
{
    acb_hypgeom_1f1(res, a, b, x, 0, prec) ;
}


void acb_hypgeom_1f1r_(acb_t res, const acb_t a, const acb_t b, const acb_t x, slong prec)
{
    acb_hypgeom_1f1(res, a, b, x, 1, prec) ;
}






/* Gamma function and related functions */





void acb_beta_(acb_t res, const acb_t a, const acb_t b, slong prec)
{
    acb_t t, u;

    acb_init(t);
    acb_init(u);

    acb_gamma(t, a, prec);
    acb_gamma(u, b, prec);

    acb_add(res, a, b, prec);
    acb_rgamma(res, res, prec);
    acb_mul(res, res, t, prec);
    acb_mul(res, res, u, prec);

    acb_clear(t);
    acb_clear(u);
}




/* Incomplete gamma functions */



void acb_gamma_upper_(acb_t res, const acb_t a, const acb_t x, slong prec)
{
    acb_hypgeom_gamma_upper(res, a, x, 0, prec);
}


void acb_gamma_upper_r(acb_t res, const acb_t a, const acb_t x, slong prec)
{
    acb_hypgeom_gamma_upper(res, a, x, 1, prec);
}


void acb_gamma_lower_(acb_t res, const acb_t a, const acb_t x, slong prec)
{
    acb_hypgeom_gamma_lower(res, a, x, 0, prec);
}


void acb_gamma_lower_r(acb_t res, const acb_t a, const acb_t x, slong prec)
{
    acb_hypgeom_gamma_lower(res, a, x, 1, prec);
}


void acb_gamma_p(acb_t out1, const acb_t a,  const acb_t x, slong wp)
{
    acb_hypgeom_gamma_lower(out1, a, x, 1, wp);
}


void acb_gamma_q(acb_t out1, const acb_t a,  const acb_t x, slong wp)
{
    acb_hypgeom_gamma_upper(out1, a, x, 1, wp);
}




void acb_gamma_p_derivative(acb_t out1, const acb_t a,  const acb_t x, slong wp)
{
    acb_t x1; acb_t x2; acb_t x3; acb_t a1;
    acb_init(x1); acb_init(x2); acb_init(x3); acb_init(a1);

    acb_neg(x1, x);
    acb_exp(x1, x1, wp);

    acb_add_si(a1, a, -1, wp);
    acb_pow(x2, x, a1, wp);

    acb_gamma(x3, a, wp);

    acb_mul(out1, x1, x2, wp);
    acb_div(out1, out1, x3, wp);

    acb_clear(x1); acb_clear(x2); acb_clear(x3); acb_clear(a1);
}






/* Error function and related functions */





void acb_ndens(acb_t out1, const acb_t z, slong wp)
{
    acb_t z1; acb_t z2;
    acb_init(z1); acb_init(z2);

    acb_sqr(z1, z, wp);
    acb_neg(z1, z1);
    acb_div_ui(z1, z1, 2, wp);
    acb_exp(z1, z1, wp);

    acb_const_pi(z2, wp);
    acb_mul_ui(z2, z2, 2, wp);
    acb_rsqrt(z2, z2, wp);

    acb_mul(out1, z1, z2, wp);

    acb_clear(z1); acb_clear(z2);
}

void acb_ndis(acb_t out1, const acb_t z, slong wp)
{
    acb_t z1; acb_t z2;
    arb_t x1;
    acb_init(z1); acb_init(z2);
    arb_init(x1);

    acb_neg(z1, z);
    arb_sqrt_ui(x1, 2, wp);
    acb_div_arb(z2, z1, x1, wp);
    acb_hypgeom_erfc(out1, z2, wp);
    acb_div_ui(out1, out1, 2, wp);

    acb_clear(z1); acb_clear(z2);
    arb_clear(x1);
}






void acb_fresnelc(acb_t res, const acb_t x, slong prec)
{
    acb_hypgeom_fresnel(res, NULL, x, 1, prec);
}



void acb_fresnels(acb_t res, const acb_t x, slong prec)
{
    acb_hypgeom_fresnel(NULL, res, x, 1, prec);
}









/* Exponential integrals and related functions */




void acb_hypgeom_li_(acb_t res, const acb_t x, slong prec)
{
    acb_hypgeom_li(res, x, 0, prec);
}


void acb_hypgeom_li_offset(acb_t res, const acb_t x, slong prec)
{
    acb_hypgeom_li(res, x, 1, prec);
}






/* 1F1: Orthogonal polynomials */






/* 1F1: Coulomb functions */



void acb_hypgeom_coulomb_f(acb_t res, const acb_t l, const acb_t eta, const acb_t x, slong prec)
{
    acb_hypgeom_coulomb(res, NULL, NULL, NULL, l, eta, x, prec);
}


void acb_hypgeom_coulomb_g(acb_t res, const acb_t l, const acb_t eta, const acb_t x, slong prec)
{
    acb_hypgeom_coulomb(NULL, res, NULL, NULL, l, eta, x, prec);
}


void acb_hypgeom_coulomb_hpos(acb_t res, const acb_t l, const acb_t eta, const acb_t x, slong prec)
{
    acb_hypgeom_coulomb(NULL, NULL, res, NULL, l, eta, x, prec);
}


void acb_hypgeom_coulomb_hneg(acb_t res, const acb_t l, const acb_t eta, const acb_t x, slong prec)
{
    acb_hypgeom_coulomb(NULL, NULL, NULL, res, l, eta, x, prec);
}








/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */



void acb_hypgeom_2f1_(acb_t res, const acb_t a, const acb_t b, const acb_t c, const acb_t x, slong prec)
{
    acb_hypgeom_2f1(res, a, b, c, x, 0, prec) ;
}


void acb_hypgeom_2f1r_(acb_t res, const acb_t a, const acb_t b, const acb_t c, const acb_t x, slong prec)
{
    acb_hypgeom_2f1(res, a, b, c, x, 1, prec) ;
}






/* 2F1: Orthogonal polynomials */




void acb_hypgeom_legendre_p_(acb_t res, const acb_t n, const acb_t m, const acb_t x, slong prec)
{
    acb_hypgeom_legendre_p(res, n, m, x, 0, prec);
}


void acb_hypgeom_legendre_pv_(acb_t res, const acb_t n, const acb_t m, const acb_t x, slong prec)
{
    acb_hypgeom_legendre_p(res, n, m, x, 1, prec);
}


void acb_hypgeom_legendre_q_(acb_t res, const acb_t n, const acb_t m, const acb_t x, slong prec)
{
    acb_hypgeom_legendre_q(res, n, m, x, 0, prec);
}


void acb_hypgeom_legendre_qv_(acb_t res, const acb_t n, const acb_t m, const acb_t x, slong prec)
{
    acb_hypgeom_legendre_q(res, n, m, x, 1, prec);
}




void _acb_hypgeom_spherical_y(acb_t res, const acb_t ncplx, const acb_t mcplx, const acb_t theta, const acb_t phi, slong prec)
{
    arb_t nreal, mreal;
    arb_init(nreal); arb_init(mreal);
    acb_get_real(nreal, ncplx);
    acb_get_real(mreal, mcplx);
    slong n = arf_get_si(arb_midref(nreal), ARF_RND_NEAR);
    slong m = arf_get_si(arb_midref(mreal), ARF_RND_NEAR);

    acb_hypgeom_spherical_y(res, n, m, theta, phi, prec);

    arb_clear(nreal); arb_clear(mreal);
}






/* 2F1: Incomplete Beta Function */



void acb_hypgeom_beta_lower_(acb_t res, const acb_t a, const acb_t b, const acb_t x, slong prec)
{
    acb_hypgeom_beta_lower(res, a, b, x, 0, prec);
}


void acb_hypgeom_beta_lower_r_(acb_t res, const acb_t a, const acb_t b, const acb_t x, slong prec)
{
    acb_hypgeom_beta_lower(res, a, b, x, 1, prec);
}



void acb_ibeta_derivative(acb_t out1, const acb_t a,  const acb_t b,  const acb_t x, slong wp)
{
    acb_t x1; acb_t x2; acb_t x3; acb_t x4; acb_t a1; acb_t b1;
    acb_init(x1); acb_init(x2); acb_init(x3); acb_init(x4); acb_init(a1); acb_init(b1);

    acb_neg(x1, x);
    acb_add_si(x1, x1, 1, wp);

    acb_add_si(b1, b, -1, wp);
    acb_pow(x1, x1, b1, wp);

    acb_add_si(a1, a, -1, wp);
    acb_pow(x2, x, a1, wp);

    acb_beta_(x3, a, b, wp);

    acb_mul(out1, x1, x2, wp);
    acb_div(out1, out1, x3, wp);

    acb_clear(x1); acb_clear(x2); acb_clear(x3); acb_clear(x4); acb_clear(a1); acb_clear(b1);
}


void acb_ibeta(acb_t out1, const acb_t a,  const acb_t b,  const acb_t x, slong wp)
{
    acb_hypgeom_beta_lower(out1, a, b, x, 1, wp) ;
}


void acb_ibetac(acb_t out1, const acb_t a,  const acb_t b,  const acb_t x, slong wp)
{
    acb_t x1; acb_init(x1);
    acb_neg(x1, x);
    acb_add_si(x1, x1, 1, wp);

    acb_hypgeom_beta_lower(out1, b, a, x1, 1, wp);
    acb_clear(x1);
}









/* Hypergeometric Function 1F2, overview */




void acb_hypgeom_1f2_old(acb_t res, const acb_t a1, const acb_t b1, const acb_t b2,
                     const acb_t z, int regularized, slong prec)
{
    acb_t a;
    acb_struct b[3];
    acb_init(a);
    acb_init(b);
    acb_init(b + 1);
    acb_init(b + 2);
    acb_set(a, a1);
    acb_set(b, b1);
    acb_set(b + 1, b2);
    acb_one(b + 2);
    acb_hypgeom_pfq_direct(res, a, 1, b, 3, z, -1, prec);
    acb_clear(a);
    acb_clear(b);
    acb_clear(b + 1);
    acb_clear(b + 2);
}




void acb_hypgeom_1f2(acb_t res, const acb_t a1, const acb_t b1, const acb_t b2,
    const acb_t z, int regularized, slong prec)
{
    acb_t a;
    acb_struct b[2];
    acb_init(a);
    acb_init(b);
    acb_init(b + 1);
    acb_set(a, a1);
    acb_set(b, b1);
    acb_set(b + 1, b2);
    acb_hypgeom_pfq(res, a, 1, b, 2, z, regularized, prec);
    acb_clear(a);
    acb_clear(b);
    acb_clear(b + 1);
}



void acb_hypgeom_1f2_(acb_t res, const acb_t a1, const acb_t b1, const acb_t b2, const acb_t z, slong prec)
{
    acb_hypgeom_1f2(res, a1, b1, b2, z, 0, prec) ;
}


void acb_hypgeom_1f2r_(acb_t res, const acb_t a1, const acb_t b1, const acb_t b2, const acb_t z, slong prec)
{
    acb_hypgeom_1f2(res, a1, b1, b2, z, 1, prec) ;
}




