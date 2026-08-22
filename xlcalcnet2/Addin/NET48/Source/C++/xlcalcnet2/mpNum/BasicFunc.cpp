#ifdef _MSC_VER
#pragma warning (disable : 4146)
#pragma warning (disable : 4244)
#pragma warning (disable : 4267)
#endif

#include "Helperfunctions.h"
//#include <mp_BoostEigenConstants.h>



/* ***************** Conversion Functions back to basic types*********************************************** */

//
///* retrieve double */
//
//void Lib_Basic_Scalar_out_d(double* res, int32_t what_type, ScalarPtr in1)
//{
//	*res = 0;
//	switch (what_type) {
//	case mp_fmpz: *res = fmpz_get_d((fmpz*)in1); break;
//	case mp_fmpq: *res = fmpq_get_d((fmpq*)in1); break;
//	case mp_mprf: *res = mpfr_get_d((mpfr_ptr)in1, MPFR_RNDN); break;
////	case mp_drf: {char *s = mpd_to_sci((mpd_t *)in1, 1); *res = atof(s); } break;
//	case mp_arf: *res = arf_get_d((arf_ptr)in1, ARF_RND_NEAR); break;
//	case mp_arb: *res = arb_get_d((arb_ptr)in1); break;
//	}
//}
//
//
///* retrieve int64_t */
//
//int64_t Lib_Basic_Scalar_out_int64(int32_t what_type, ScalarPtr in1)
//{
//	int64_t res = 0;
//	switch (what_type) {
////	case mp_fmpz: res = fmpz_get_si64((fmpz*)in1); break;
////	case mp_fmpq: res = fmpq_get_si64((fmpq*)in1); break;
//	case mp_mprf: res = mpfr_get_si64((mpfr_ptr)in1); break;
////	case mp_drf: res = decr_get_si64((mpd_t *)in1); break;
//	case mp_arf: res = arf_get_si64((arf_ptr)in1); break;
//	case mp_arb: res = arb_get_si64((arb_ptr)in1); break;
//	}
//	return res;
//}
//
//
//
///* retrieve uint64_t */
//
//uint64_t Lib_Basic_Scalar_out_uint64(int32_t what_type, ScalarPtr in1)
//{
//	uint64_t res = 0;
//	switch (what_type) {
////	case mp_fmpz: res = fmpz_get_ui64((fmpz*)in1); break;
////	case mp_fmpq: res = fmpq_get_ui64((fmpq*)in1); break;
//	case mp_mprf: res = mpfr_get_ui64((mpfr_ptr)in1); break;
////	case mp_drf: res = decr_get_ui64((mpd_t *)in1); break;
//	case mp_arf: res = arf_get_ui64((arf_ptr)in1); break;
//	case mp_arb: res = arb_get_ui64((arb_ptr)in1); break;
//	}
//	return res;
//}
//
//
///* retrieve int32_t */
//
//int32_t Lib_Basic_Scalar_out_int32(int32_t what_type, ScalarPtr in1)
//{
//	int32_t res = 0;
//	switch (what_type) {
////	case mp_fmpz: res = fmpz_get_si32((fmpz*)in1); break;
////	case mp_fmpq: res = fmpq_get_si32((fmpq*)in1); break;
//	case mp_mprf: res = mpfr_get_si((mpfr_ptr)in1, MPFR_RNDN); break;
////	case mp_drf: res = decr_get_si32((mpd_t *)in1); break;
//	case mp_arf: res = arf_get_si32((arf_ptr)in1); break;
//	case mp_arb: res = arb_get_si32((arb_ptr)in1); break;
//	}
//	return res;
//}
//
//
//
///* retrieve uint32_t */
//
//uint32_t Lib_Basic_Scalar_out_uint32(int32_t what_type, ScalarPtr in1)
//{
//	uint32_t res = 0;
//	switch (what_type) {
////	case mp_fmpz: res = fmpz_get_ui32((fmpz*)in1); break;
////	case mp_fmpq: res = fmpq_get_ui32((fmpq*)in1); break;
//	case mp_mprf: res = mpfr_get_ui((mpfr_ptr)in1, MPFR_RNDN); break;
////	case mp_drf: res = decr_get_ui32((mpd_t *)in1); break;
//	case mp_arf: res = arf_get_ui32((arf_ptr)in1); break;
//	case mp_arb: res = arb_get_ui32((arb_ptr)in1); break;
//	}
//	return res;
//}
//
//
//
///* retrieve sizeinbase10 */
//
//int64_t  Lib_Basic_Scalar_Str_Sizeinbase10(int32_t what_type, char * str, int32_t digits, uint32_t flags, ScalarPtr in1)
//{
//	int64_t res = 20;
//	switch (what_type) {
////	case mp_fmpz: res = fmpz_sizeinbase((fmpz*)in1, 10) + 1; break;
////	case mp_fmpq: res = fmpq_sizeinbase((fmpq*)in1, 10); break;
//	case mp_mprf: res = mpfr_get_str_sizeinbase10(str, (mpfr_ptr)in1); break;
////	case mp_drf: res = Lib_Mpd_SizeInBase10((MpdPtr)in1); break;
//	case mp_arf: res = arf_sizeinbase10(digits, flags, (arf_ptr)in1); break;
//	case mp_arb: res = arb_sizeinbase10(digits, flags, (arb_ptr)in1); break;
//	default: res = 20; break;
//	}
//	return res;
//}
//
//
//
//
///* retrieve strings intern */
//
//int64_t  Lib_Basic_Scalar_Str_Intern(char* dest, int32_t what_type, char * str, int32_t digits, uint32_t flags, ScalarPtr in1)
//{
//	switch (what_type) {
////	case mp_fmpz: return (int64_t)fmpz_get_str(dest, 10, (fmpz*)in1); break;
//	case mp_mprf: return mpfr_get_str_intern(dest, digits, str, (mpfr_ptr)in1); break;
////	case mp_drf: return Lib_Mpd_Get_Str(dest, (MpdPtr)in1); break;
//	case mp_arf: return arf_get_str_intern(dest, in1, digits, flags); break;
//	case mp_arb: return arb_get_str_intern(dest, in1, digits, flags); break;
//	default: return 0; break;
//	}
//}
//
//
//
///* retrieve strings extern */
//
//char*  Lib_Basic_Scalar_Str_Extern(int32_t what_type, const char * str, int32_t digits, uint32_t flags, const ScalarPtr in1)
//{
//	switch (what_type) {
////	case mp_fmpz: return fmpz_get_str(NULL, digits, (fmpz*)in1); break;
////	case mp_fmpq: return fmpq_get_str(NULL, digits, (fmpq*)in1);; break;
//	case mp_mprf: return mpfr_get_str_extern(str, digits, (mpfr_ptr)in1); break;
////	case mp_drf: return Lib_Mpd_Get_Str_Func((MpdPtr)in1); break;
//	case mp_arf: return arf_get_str_extern(digits, flags, (arf_ptr)in1); break;
//	case mp_arb: return arb_get_str_extern(digits, flags, (arb_ptr)in1); break;
//	default: return NULL;
//	}
//}
//
//
//



/***************************************************************************************/
/***************************************************************************************/
/***************************************************************************************/



///* basic arithmetic (internal) */
//
//void Basic_Scalar_Arithmetic(ScalarPtr out1, int32_t proc, int32_t op1_type, ScalarPtr in1, ScalarPtr in2)
//{
//	int32_t prec = mpfr_get_default_prec();
//
//	switch (op1_type) {
//
//
//	case mp_xrf: {
//		switch (proc) {
//		case mp_add: (*(double*)out1) = (*(double*)in1) + (*(double*)in2); break;
//		case mp_sub: (*(double*)out1) = (*(double*)in1) - (*(double*)in2); break;
//		case mp_mul: (*(double*)out1) = (*(double*)in1) * (*(double*)in2); break;
//		case mp_div: (*(double*)out1) = (*(double*)in1) / (*(double*)in2); break;
//		case mp_pow: (*(double*)out1) = (*(double*)in1) * (*(double*)in2); break;
//		}
//		break;
//	}
//
//	case mp_xcf: {
//		switch (proc) {
//		case mp_add: (*(std::complex<double>*) out1) = (*(std::complex<double>*) in1) + (*(std::complex<double>*) in2); break;
//		case mp_sub: (*(std::complex<double>*) out1) = (*(std::complex<double>*) in1) - (*(std::complex<double>*) in2); break;
//		case mp_mul: (*(std::complex<double>*) out1) = (*(std::complex<double>*) in1) * (*(std::complex<double>*) in2); break;
//		case mp_div: (*(std::complex<double>*) out1) = (*(std::complex<double>*) in1) / (*(std::complex<double>*) in2); break;
//		case mp_pow: (*(std::complex<double>*) out1) = (*(std::complex<double>*) in1) * (*(std::complex<double>*) in2); break;
//		}
//		break;
//	}
//
////
////	case mp_fmpz: {
////		switch (proc) {
////		case mp_add: fmpz_add((fmpz*)out1, (fmpz*)in1, (fmpz*)in2); break;
////		case mp_sub: fmpz_sub((fmpz*)out1, (fmpz*)in1, (fmpz*)in2); break;
////		case mp_mul: fmpz_mul((fmpz*)out1, (fmpz*)in1, (fmpz*)in2); break;
////		case mp_div: fmpz_tdiv_q((fmpz*)out1, (fmpz*)in1, (fmpz*)in2); break;
////
////			/* need to change this to integer power */
////		case mp_pow: fmpz_tdiv_q((fmpz*)out1, (fmpz*)in1, (fmpz*)in2); break;
////		}
////		break;
////	}
////
////	case mp_fmpq: {
////		switch (proc) {
////		case mp_add: fmpq_add((fmpq*)out1, (fmpq*)in1, (fmpq*)in2); break;
////		case mp_sub: fmpq_sub((fmpq*)out1, (fmpq*)in1, (fmpq*)in2); break;
////		case mp_mul: fmpq_mul((fmpq*)out1, (fmpq*)in1, (fmpq*)in2); break;
////		case mp_div: fmpq_div((fmpq*)out1, (fmpq*)in1, (fmpq*)in2); break;
////
////			/* need to change this to integer power */
////		case mp_pow: fmpq_div((fmpq*)out1, (fmpq*)in1, (fmpq*)in2); break;
////		}
////		break;
////	}
////
//	case mp_mprf: {
//		switch (proc) {
//		case mp_add: mpfr_add((mpfr_ptr)out1, (mpfr_ptr)in1, (mpfr_ptr)in2, MPFR_RNDN); break;
//		case mp_sub: mpfr_sub((mpfr_ptr)out1, (mpfr_ptr)in1, (mpfr_ptr)in2, MPFR_RNDN); break;
//		case mp_mul: mpfr_mul((mpfr_ptr)out1, (mpfr_ptr)in1, (mpfr_ptr)in2, MPFR_RNDN); break;
//		case mp_div: mpfr_div((mpfr_ptr)out1, (mpfr_ptr)in1, (mpfr_ptr)in2, MPFR_RNDN); break;
//		case mp_pow: mpfr_pow((mpfr_ptr)out1, (mpfr_ptr)in1, (mpfr_ptr)in2, MPFR_RNDN); break;
//		}
//		break;
//	}
//
//
//
//	case mp_mpcf: {
//		switch (proc) {
//		case mp_add: mpc_add((mpc_ptr)out1, (mpc_ptr)in1, (mpc_ptr)in2, MPC_RNDNN); break;
//		case mp_sub: mpc_sub((mpc_ptr)out1, (mpc_ptr)in1, (mpc_ptr)in2, MPC_RNDNN); break;
//		case mp_mul: mpc_mul((mpc_ptr)out1, (mpc_ptr)in1, (mpc_ptr)in2, MPC_RNDNN); break;
//		case mp_div: mpc_div((mpc_ptr)out1, (mpc_ptr)in1, (mpc_ptr)in2, MPC_RNDNN); break;
//		case mp_pow: mpc_pow((mpc_ptr)out1, (mpc_ptr)in1, (mpc_ptr)in2, MPC_RNDNN); break;
//		}
//		break;
//	}
//
//
//
////	case mp_drf: {
////		switch (proc) {
////		case mp_add: mpd_add((mpd_t *)out1, (mpd_t *)in1, (mpd_t *)in2, mpd_globalctx()); break;
////		case mp_sub: mpd_sub((mpd_t *)out1, (mpd_t *)in1, (mpd_t *)in2, mpd_globalctx()); break;
////		case mp_mul: mpd_mul((mpd_t *)out1, (mpd_t *)in1, (mpd_t *)in2, mpd_globalctx()); break;
////		case mp_div: mpd_div((mpd_t *)out1, (mpd_t *)in1, (mpd_t *)in2, mpd_globalctx()); break;
////		case mp_pow: mpd_pow((mpd_t *)out1, (mpd_t *)in1, (mpd_t *)in2, mpd_globalctx()); break;
////		}
////		break;
////	}
//
//
////	case mp_dcf: {
//////	    printf("arith mp_dcf:  \n");
//////	    char * src1_re = mpd_to_sci(((mpdc_ptr)in1)->real, 1);
//////        char * src1_im = mpd_to_sci(((mpdc_ptr)in1)->imag, 1);
//////        printf("src1_re: %s \n", src1_re);
//////        printf("src1_im: %s \n", src1_im);
//////
//////	    char * src2_re = mpd_to_sci(((mpdc_ptr)in2)->real, 1);
//////        char * src2_im = mpd_to_sci(((mpdc_ptr)in2)->imag, 1);
//////        printf("src2_re: %s \n", src2_re);
//////        printf("src2_im: %s \n", src2_im);
////
////		switch (proc) {
////		case mp_add: Lib_Mpdc_Add((MpdcPtr)out1, (MpdcPtr)in1, (MpdcPtr)in2); break;
////		case mp_sub: Lib_Mpdc_Sub((MpdcPtr)out1, (MpdcPtr)in1, (MpdcPtr)in2); break;
////		case mp_mul: Lib_Mpdc_Mul((MpdcPtr)out1, (MpdcPtr)in1, (MpdcPtr)in2); break;
////		case mp_div: Lib_Mpdc_Div((MpdcPtr)out1, (MpdcPtr)in1, (MpdcPtr)in2); break;
////		case mp_pow: Lib_Mpdc_Pow((MpdcPtr)out1, (MpdcPtr)in1, (MpdcPtr)in2); break;
////		}
////		break;
////	}
////
////	case mp_arf: {
////		//printf("arith mp_arf:  ");
////
////		switch (proc) {
////		case mp_add: arf_add((arf_ptr)out1, (arf_ptr)in1, (arf_ptr)in2, prec, ARF_RND_NEAR); break;
////		case mp_sub: arf_sub((arf_ptr)out1, (arf_ptr)in1, (arf_ptr)in2, prec, ARF_RND_NEAR); break;
////		case mp_mul: arf_mul((arf_ptr)out1, (arf_ptr)in1, (arf_ptr)in2, prec, ARF_RND_NEAR); break;
////		case mp_div: arf_div((arf_ptr)out1, (arf_ptr)in1, (arf_ptr)in2, prec, ARF_RND_NEAR); break;
////		case mp_pow: arf_pow((arf_ptr)out1, (arf_ptr)in1, (arf_ptr)in2, prec, ARF_RND_NEAR); break;
////		}
////		break;
////	}
////
////			   // ARF_PREC_EXACT = WORD_MAX = 9223372036854775807
////
////
////	case mp_acf: {
////		//printf("arith mp_acf:  ");
////
//////		switch (proc) {
//////		case mp_add: Lib_Acf_Add((acf_ptr)out1, (acf_ptr)in1, (acf_ptr)in2, prec); break;
//////		case mp_sub: Lib_Acf_Sub((acf_ptr)out1, (acf_ptr)in1, (acf_ptr)in2, prec); break;
//////		case mp_mul: Lib_Acf_Mul((acf_ptr)out1, (acf_ptr)in1, (acf_ptr)in2, prec); break;
//////		case mp_div: Lib_Acf_Div((acf_ptr)out1, (acf_ptr)in1, (acf_ptr)in2, prec); break;
//////		case mp_pow: Lib_Acf_Pow((acf_ptr)out1, (acf_ptr)in1, (acf_ptr)in2, prec); break;
//////		}
////		break;
////	}
//
//	case mp_arb: {
//		//printf("arith mp_arb:  ");
//
//		switch (proc) {
//		case mp_add: arb_add((arb_ptr)out1, (arb_ptr)in1, (arb_ptr)in2, prec); break;
//		case mp_sub: arb_sub((arb_ptr)out1, (arb_ptr)in1, (arb_ptr)in2, prec); break;
//		case mp_mul: arb_mul((arb_ptr)out1, (arb_ptr)in1, (arb_ptr)in2, prec); break;
//		case mp_div: arb_div((arb_ptr)out1, (arb_ptr)in1, (arb_ptr)in2, prec); break;
//		case mp_pow: arb_pow((arb_ptr)out1, (arb_ptr)in1, (arb_ptr)in2, prec); break;
//		}
//		break;
//	}
//
//	case mp_acb: {
//		switch (proc) {
//		case mp_add: acb_add((acb_ptr)out1, (acb_ptr)in1, (acb_ptr)in2, prec); break;
//		case mp_sub: acb_sub((acb_ptr)out1, (acb_ptr)in1, (acb_ptr)in2, prec); break;
//		case mp_mul: acb_mul((acb_ptr)out1, (acb_ptr)in1, (acb_ptr)in2, prec); break;
//		case mp_div: acb_div((acb_ptr)out1, (acb_ptr)in1, (acb_ptr)in2, prec); break;
//		case mp_pow: acb_pow((acb_ptr)out1, (acb_ptr)in1, (acb_ptr)in2, prec); break;
//		}
//		break;
//	}
//
//	} /* switch (op1_type) */
//}
//
//
///* basic type conversions, optionally followed by basic arithmetic */
//
//int64_t Lib_BSF2(ScalarPtr out1, int32_t proc, int32_t op1_type, int32_t op2_type, ScalarPtr in1, ScalarPtr in2, int64_t in3, double in4, double in5)
//{
//	int32_t prec = mpfr_get_default_prec();
//	bool converted = false;
//
//	//printf("proc: %i, op1_type: %i, op2_type: %i \n", proc, op1_type, op2_type);
//
//	if ((proc >= mp_xrf_set) && (proc <= mp_xcf_from_polar))
//	{
//		switch (proc) {
//		case mp_xrf_set: (*(double*)out1) = in4; break;
//		case mp_xrf_get: (*(double*)out1) = (*(double*)in1); break;
//
//		case mp_xcf_get_real_d: (*(double*)out1) = (*(std::complex<double>*) in1).real(); break;
//		case mp_xcf_get_imag_d: (*(double*)out1) = (*(std::complex<double>*) in1).imag(); break;
//
//		case mp_xcf_from_rect: (*(std::complex<double>*) out1) = std::complex<double>(in4, in5); break;
//		case mp_xcf_from_polar: (*(std::complex<double>*) out1) = std::polar<double>(in4, in5); break;
//		}
//		return 0;
//	}
//
//
//	if ((proc == mp_sizeinbase10) || (proc == mp_getstring))
//	{
//		int64_t result = 0;
//		switch (proc) {
//		case mp_sizeinbase10: result = Lib_Basic_Scalar_Str_Sizeinbase10(op1_type, (char*)in2, op2_type, in3, in1); break;
//		case mp_getstring: result = Lib_Basic_Scalar_Str_Intern((char*)out1, op1_type, (char*)in2, op2_type, in3, in1); break;
//		}
//		return result;
//	}
//
//
//	if (((op1_type == mp_int32) || (op1_type == mp_uint32) || (op1_type == mp_int64) || (op1_type == mp_uint64)) && (proc == mp_set_scalar))
//	{
//		int64_t result = 0;
//		/* conversions to integers, using return value */
//		switch (op1_type) {
//		case mp_int32: result = Lib_Basic_Scalar_out_int32(op2_type, in1); break;
//		case mp_uint32: result = Lib_Basic_Scalar_out_uint32(op2_type, in1); break;
//		case mp_int64: result = Lib_Basic_Scalar_out_int64(op2_type, in1); break;
//		case mp_uint64: result = (uint64_t)Lib_Basic_Scalar_out_uint64(op2_type, in1); break;
//		}
//		return result;
//	}
//
//
//
//	/* convert op types as necessary */
//
//
//
//	switch (op1_type) {
//
//////	case mp_double:
////	case mp_xrf:
////	    {
////		//printf("in case mp_double mp_xrf :");
////		switch (op2_type) {
////		case mp_int32: (*(double*)out1) = (int32_t)in3; break;
////		case mp_uint32: (*(double*)out1) = (uint32_t)in3; break;
////		case mp_int64: (*(double*)out1) = (int64_t)in3; break;
////		case mp_uint64: (*(double*)out1) = (uint64_t)in3; break;
////		case mp_double2:  //printf("converting from: case mp_double: \n");
////						(*(double*)out1) = (double)in4; break;
////		case mp_string: (*(double*)out1) = atof((char*)in2); break;
////		case mp_fmpz: Lib_Basic_Scalar_out_d((double*)out1, mp_fmpz, in2); break;
////		case mp_fmpq: Lib_Basic_Scalar_out_d((double*)out1, mp_fmpq, in2); break;
////		case mp_mprf: Lib_Basic_Scalar_out_d((double*)out1, mp_mprf, in2); break;
//////		case mp_drf: Lib_Basic_Scalar_out_d((double*)out1, mp_drf, in2); break;
////		case mp_arb: Lib_Basic_Scalar_out_d((double*)out1, mp_arb, in2); break;
////		}
////		break;
////	}
//
////	case mp_complex:
////	case mp_xcf:
////	{
////		//printf("in case mp_complex: case mp_xcf:");
////		switch (op2_type) {
////		case mp_int32: (*(std::complex<double>*) out1) = std::complex<double>((int32_t)in3, 0.0); break;
////		case mp_uint32: (*(std::complex<double>*) out1) = std::complex<double>((uint32_t)in3, 0.0); break;
////		case mp_int64: (*(std::complex<double>*) out1) = std::complex<double>((int64_t)in3, 0.0); break;
////		case mp_uint64: (*(std::complex<double>*) out1) = std::complex<double>((uint64_t)in3, 0.0); break;
////		case mp_double2:  //printf("converting from: case mp_double:  \n");
////			(*(std::complex<double>*) out1) = std::complex<double>((double)in4, 0.0); break;
////		case mp_complex2: (*(std::complex<double>*) out1) = (*(std::complex<double>*) in1); break;
////
////
////		case mp_string: {double d1 = atof((char*)in2); (*(std::complex<double>*) out1) = std::complex<double>(d1, 0.0); } break;
////		case mp_fmpz: {double d1; Lib_Basic_Scalar_out_d(&d1, mp_fmpz, in2);
////			(*(std::complex<double>*) out1) = std::complex<double>(d1, 0.0); } break;
////		case mp_fmpq: {double d1; Lib_Basic_Scalar_out_d(&d1, mp_fmpq, in2);
////			(*(std::complex<double>*) out1) = std::complex<double>(d1, 0.0); } break;
////		case mp_mprf: {double d1; Lib_Basic_Scalar_out_d(&d1, mp_mprf, in2);
////			(*(std::complex<double>*) out1) = std::complex<double>(d1, 0.0); } break;
////		case mp_drf: {double d1; Lib_Basic_Scalar_out_d(&d1, mp_drf, in2);
////			(*(std::complex<double>*) out1) = std::complex<double>(d1, 0.0); } break;
////		case mp_arb: {double d1; Lib_Basic_Scalar_out_d(&d1, mp_arb, in2);
////			(*(std::complex<double>*) out1) = std::complex<double>(d1, 0.0); } break;
////
////		case mp_mpcf: {double d1; Lib_Basic_Scalar_out_d(&d1, mp_mprf, mpc_realref((mpc_ptr)in2));
////			double d2; Lib_Basic_Scalar_out_d(&d2, mp_mprf, mpc_imagref((mpc_ptr)in2));
////			(*(std::complex<double>*) out1) = std::complex<double>(d1, d2); } break;
////
//////		case mp_dcf: {double d1; Lib_Basic_Scalar_out_d(&d1, mp_drf, ((mpdc_ptr)in2)->real);
//////			double d2; Lib_Basic_Scalar_out_d(&d2, mp_drf, ((mpdc_ptr)in2)->imag);
//////			(*(std::complex<double>*) out1) = std::complex<double>(d1, d2); } break;
////
////		case mp_acb: {double d1; Lib_Basic_Scalar_out_d(&d1, mp_arb, acb_realref((acb_ptr)in2));
////			double d2; Lib_Basic_Scalar_out_d(&d2, mp_arb, acb_imagref((acb_ptr)in2));
////			(*(std::complex<double>*) out1) = std::complex<double>(d1, d2); } break;
////		}
////		break;
////	}
//
//
//	case mp_mprf: {
//		if (op2_type >= mp_fmpq) {
//			converted = true;
//			switch (op2_type) {
//			case mp_int32: mpfr_set_si((mpfr_ptr)out1, (int32_t)in3, MPFR_RNDN); break;
//			case mp_uint32: mpfr_set_ui((mpfr_ptr)out1, (uint32_t)in3, MPFR_RNDN); break;
//			case mp_int64: mpfr_set_si64((mpfr_ptr)out1, (int64_t)in3); break;
//			case mp_uint64: mpfr_set_ui64((mpfr_ptr)out1, (uint64_t)in3); break;
//			case mp_double2: mpfr_set_d((mpfr_ptr)out1, (double)in4, MPFR_RNDN); break;
//			case mp_string: mpfr_set_str((mpfr_ptr)out1, (char*)in2, 10, MPFR_RNDN); break;
//			case mp_fmpz: mpfr_set_fmpz((mpfr_ptr)out1, (fmpz*)in2); break;
//			case mp_fmpq: mpfr_set_fmpq((mpfr_ptr)out1, (fmpq*)in2); break;
//			}
//		}
//		if (proc == mp_set_scalar) {
//			switch (op2_type) {
//			case mp_mprf: mpfr_set((mpfr_ptr)out1, (mpfr_ptr)in2, MPFR_RNDN); break;
//			case mp_mpcf_real: mpc_real((mpfr_ptr)out1, (mpc_ptr)in2, MPFR_RNDN); break; /* get real part; */
//			case mp_mpcf_imag: mpc_imag((mpfr_ptr)out1, (mpc_ptr)in2, MPFR_RNDN); break; /* get imag part; */
////			case mp_drf: mpfr_set_decr((mpfr_ptr)out1, (mpd_t*)in2); break;
//			case mp_arb: mpfr_set_arb((mpfr_ptr)out1, (arb_ptr)in2); break;
//			}
//		}
//		break;
//	}
//
//
//	case mp_mpcf: {
//		if (op2_type >= mp_mprf) {
//			//printf("in case mp_mpcf: \n");
//			converted = true;
//			switch (op2_type) {
//			case mp_int32: mpc_set_si((mpc_ptr)out1, (int32_t)in3, MPC_RNDNN); break;
//			case mp_uint32: mpc_set_ui((mpc_ptr)out1, (uint32_t)in3, MPC_RNDNN); break;
//			case mp_int64: mpfc_set_si64((mpc_ptr)out1, (int64_t)in3); break;
//			case mp_uint64: mpfc_set_ui64((mpc_ptr)out1, (uint64_t)in3); break;
//			case mp_double2: mpc_set_d((mpc_ptr)out1, (double)in4, MPC_RNDNN); break;
//			case mp_complex2: { mpc_set_d_d((mpc_ptr)out1, (*(std::complex<double>*) in1).real(),
//				(*(std::complex<double>*) in1).imag(), MPC_RNDNN); } break;
//			case mp_string: mpc_set_str((mpc_ptr)out1, (char*)in2, 10, MPC_RNDNN); break;
//			case mp_fmpz: mpfc_set_fmpz((mpc_ptr)out1, (fmpz*)in2); break;
//			case mp_fmpq: mpfc_set_fmpq((mpc_ptr)out1, (fmpq*)in2); break;
//			case mp_mprf: mpc_set_fr((mpc_ptr)out1, (mpfr_ptr)in2, MPC_RNDNN); break;
//			case mp_mprf_mprf: mpc_set_fr_fr((mpc_ptr)out1, (mpfr_ptr)in1, (mpfr_ptr)in2, MPC_RNDNN); break;
//			}
//		}
//		if (proc == mp_set_scalar) {
//			switch (op2_type) {
//			case mp_mpcf: mpc_set((mpc_ptr)out1, (mpc_ptr)in2, MPFR_RNDN); break;
//			case mp_mpcf_real: mpfr_set(mpc_realref((mpc_ptr)out1), (mpfr_ptr)in2, MPFR_RNDN); break; /* set real part; */
//			case mp_mpcf_imag: mpfr_set(mpc_imagref((mpc_ptr)out1), (mpfr_ptr)in2, MPFR_RNDN); break; /* set imag part; */
////			case mp_drf: mpfc_set_decr((mpc_ptr)out1, (mpd_t*)in2); break;
////			case mp_dcf: mpfc_set_Mpdc((mpc_ptr)out1, (mpdc_ptr)in2); break;
//			case mp_arb: mpfc_set_arb((mpc_ptr)out1, (arb_ptr)in2); break;
//			case mp_acb: mpfc_set_acb((mpc_ptr)out1, (acb_ptr)in2); break;
//			}
//		}
//		break;
//	}
//
//
//	case mp_arb: {
//		//if (op2_type > mp_mpri_mpri) {
//		if (op2_type > mp_arb_arb) {
//				converted = true;
//			switch (op2_type) {
//			case mp_int32: arb_set_si((arb_ptr)out1, (int32_t)in3); break;
//			case mp_uint32: arb_set_ui((arb_ptr)out1, (uint32_t)in3); break;
//			case mp_int64: arb_set_si64((arb_ptr)out1, (int64_t)in3); break;
//			case mp_uint64: arb_set_ui64((arb_ptr)out1, (uint64_t)in3); break;
//			case mp_double2: arb_set_d((arb_ptr)out1, (double)in4); break;
//			case mp_string: arb_set_str((arb_ptr)out1, (char*)in2, prec); break;
//			case mp_fmpz: arb_set_round_fmpz((arb_ptr)out1, (fmpz*)in2, prec); break;
//			case mp_fmpq: arb_set_fmpq((arb_ptr)out1, (fmpq*)in2, prec); break;
//			case mp_mprf: arb_set_mpfr((arb_ptr)out1, (mpfr_ptr)in2); break;
////			case mp_drf: arb_set_decr((arb_ptr)out1, (mpd_t*)in2); break;
//			}
//		}
//		if (proc == mp_set_scalar) {
//			switch (op2_type) {
//			case mp_arb: arb_set((arb_ptr)out1, (arb_ptr)in2); break;
//			//case mp_mpri: arb_set_mpfi((arb_ptr)out1, (mpfi_ptr)in2); break;
//
//			case mp_acb_real: acb_get_real((arb_ptr)out1, (acb_ptr)in2); break; /* get real part; */
//			case mp_acb_imag: acb_get_imag((arb_ptr)out1, (acb_ptr)in2); break; /* get imag part; */
//
//			case mp_arb_mid_get: arb_get_mid_arb((arb_ptr)out1, (arb_ptr)in2); break; /* get midpoint */
//			case mp_arb_rad_get: arb_get_rad_arb((arb_ptr)out1, (arb_ptr)in2); break; /* get radius */
//
//			case mp_arb_mid_set: arf_set(arb_midref((arb_ptr)out1), arb_midref((arb_ptr)in2)); break; /* set midpoint*/
//			case mp_arb_rad_set: arf_get_mag(arb_radref((arb_ptr)out1), arb_midref((arb_ptr)in2)); break; /* set radius */
//
//			case mp_arb_infimum: { arb_get_lbound_arf(arb_midref((arb_ptr)out1), (arb_ptr)in2, prec);
//				mag_zero(arb_radref((arb_ptr)out1)); } break; /* get infimum*/
//			case mp_arb_supremum: { arb_get_ubound_arf(arb_midref((arb_ptr)out1), (arb_ptr)in2, prec);
//				mag_zero(arb_radref((arb_ptr)out1)); } break; /* get supremum*/
//			}
//		}
//		break;
//	}
//
//
//	case mp_acb: {
//		if (op2_type >= mp_arb_arb) {
//			converted = true;
//			switch (op2_type) {
//			case mp_int32: acb_set_si((acb_ptr)out1, (int32_t)in3); break;
//			case mp_uint32: acb_set_ui((acb_ptr)out1, (uint32_t)in3); break;
//			case mp_int64: acb_set_si64((acb_ptr)out1, (int64_t)in3); break;
//			case mp_uint64: acb_set_ui64((acb_ptr)out1, (uint64_t)in3); break;
//			case mp_double2: acb_set_d((acb_ptr)out1, (double)in4); break;
//			case mp_complex2: {acb_set_d_d((acb_ptr)out1, (*(std::complex<double>*) in1).real(),
//				(*(std::complex<double>*) in1).imag()); } break;
//			case mp_fmpz: acb_set_fmpz((acb_ptr)out1, (fmpz*)in2); break;
//			case mp_fmpq: acb_set_fmpq((acb_ptr)out1, (fmpq*)in2, prec); break;
//			case mp_mprf: acb_set_mpfr((acb_ptr)out1, (mpfr_ptr)in2); break;
//			case mp_mpcf: acb_set_mpc((acb_ptr)out1, (mpc_ptr)in2); break;
////			case mp_drf: acb_set_decr((acb_ptr)out1, (mpd_t*)in2); break;
////			case mp_dcf: acb_set_Mpdc((acb_ptr)out1, (mpdc_ptr)in2); break;
//			case mp_arb: acb_set_arb((acb_ptr)out1, (arb_ptr)in2); break;
//			case mp_arb_arb: acb_set_arb_arb((acb_ptr)out1, (arb_ptr)in1, (arb_ptr)in2); break;
//			}
//		}
//		if (proc == mp_set_scalar) {
//			switch (op2_type) {
//			case mp_acb: acb_set((acb_ptr)out1, (acb_ptr)in2); break;
//			case mp_acb_real: arb_set(acb_realref((acb_ptr)out1), (arb_ptr)in2); break; /* set real part; */
//			case mp_acb_imag: arb_set(acb_imagref((acb_ptr)out1), (arb_ptr)in2); break; /* set imag part; */
//			}
//		}
//		break;
//	}
//	}
//	//}
//
//
//
//	/* return if only a conversion from in2 to out1 has been requested */
//	if (proc == mp_set_scalar) { return 0; }
//
//	/* otherwise perform the requested binary operation */
//	if (converted == false)
//	{
//		if ((proc >= mp_add) && (proc <= mp_pow))
//		{
////			printf("using converted = false, ortho:  ");
//			Basic_Scalar_Arithmetic(out1, proc, op1_type, in1, in2);
//		}
//		else
//		{
////			printf("using converted = false, reverse:  ");
//			Basic_Scalar_Arithmetic(out1, proc - mp_reverse_offset, op1_type, in2, in1);
//		}
//	}
//	else
//	{
//		if ((proc >= mp_add) && (proc <= mp_pow))
//		{
////			printf("using converted = true, ortho:  ");
//			Basic_Scalar_Arithmetic(out1, proc, op1_type, in1, out1);
//		}
//		else
//		{
////			printf("using converted = true, reverse:  ");
//			Basic_Scalar_Arithmetic(out1, proc - mp_reverse_offset, op1_type, out1, in1);
//		}
//	}
//	return 0;
//
//}
//
//
//
//int64_t Lib_BSF2s(ScalarPtr out1, int32_t proc, int32_t op1_type, int32_t op2_type, ScalarPtr in1, ScalarPtr in2, int64_t in3, double in4, double in5)
//{
//	return Lib_BSF2(out1, proc, op1_type, op2_type, in1, in2, in3, in4, in5);
//}
//
