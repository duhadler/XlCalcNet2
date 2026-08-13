
#ifndef HELPERFUNCTIONS_H_INCLUDED
#define HELPERFUNCTIONS_H_INCLUDED


#define MPFR_WANT_FLOAT128

#include "mpNumC_Main.h"
#include <mp_BoostEigenConstants.h>


#include <gmp.h>
#include <mpfr.h>
#include "mpc.h"

#include <flint.h>
#include <fmpz.h>
#include <fmpz_poly.h>
#include <fmpz_mat.h>
#include <fmpq.h>
#include <fmpq_poly.h>
#include <fmpq_mat.h>
#include <aprcl.h>
#include "arf.h"
#include "acf.h"
#include "arb.h"
#include "arb_calc.h"

#include "arb_mat.h"
#include "arb_poly.h"
#include "acb.h"
#include "acb_poly.h"
#include "acb_mat.h"
#include "arb_hypgeom.h"
#include "acb_hypgeom.h"
#include "acb_modular.h"
#include "acb_elliptic.h"
#include "acb_dirichlet.h"
#include "acb_calc.h"

#include <complex>
#include <limits>
#include <string.h>

#include <Eigen/Dense>
#include "MpAnyEigen.h"

#include <iostream>
#include <cstdio>
#include <cstdlib>
#include <string>
#include <algorithm>
#include <vector>

#include <quadmath.h>

#include <boost/multiprecision/cpp_bin_float.hpp>


using namespace Eigen;
using namespace std;

/***********************************************************************************/


typedef Matrix<mpAny::mpscalar, Dynamic, Dynamic> mpAnyMatrix;
typedef mpAnyMatrix* mpAnyMatrixPtr;


typedef Matrix<complex<mpAny::mpscalar>, Dynamic, Dynamic>  mpAnyMatrixC;
typedef mpAnyMatrixC* mpAnyMatrixCPtr;



typedef Matrix<double, Dynamic, Dynamic> DblMatrix;
typedef DblMatrix* DblMatrixPtr;


typedef Matrix<complex<double>, Dynamic, Dynamic>  CplxMatrix;
typedef CplxMatrix* CplxMatrixPtr;




typedef fmpq* fmpq_ptr;
typedef fmpz* fmpz_ptr;
typedef const fmpq *fmpq_srcptr;


typedef void(*ArbFuncPtr0) (arb_t, slong);

typedef void(*ArbFuncPtr0Int32) (arb_t, const int32_t, slong);

typedef void(*ArbFuncPtr1) (arb_t, const arb_t, slong);

typedef void(*ArbFuncPtr1Int32) (arb_t, const arb_t, const int32_t, slong);

typedef void(*ArbFuncPtr2) (arb_t, const arb_t, const arb_t, slong);

typedef void(*ArbFuncPtr3) (arb_t, const arb_t, const arb_t, const arb_t, slong);

typedef void(*ArbFuncPtr4) (arb_t, const arb_t, const arb_t, const arb_t, const arb_t, slong);




typedef void(*AcbFuncPtr0Int32) (acb_t, const int32_t, slong);

typedef void(*AcbFuncPtr1) (acb_t, const acb_t, slong);

typedef void(*AcbFuncPtr1Int32) (acb_t, const acb_t, const int32_t, slong);

typedef void(*AcbFuncPtr2) (acb_t, const acb_t, const acb_t, slong);

typedef void(*AcbFuncPtr3) (acb_t, const acb_t, const acb_t, const acb_t, slong);

typedef void(*AcbFuncPtr4) (acb_t, const acb_t, const acb_t, const acb_t, const acb_t, slong);






int32_t Get_Real_Type(int32_t mpType_);

/* **************** POLY ************************ */

ArbPolyPtr Lib_Poly_Arb_Init_Func();
void Lib_Poly_Arb_Clear(ArbPolyPtr A);

void Lib_ArbMatrix_From_ArbPoly(ArbMatPtr matResult, ArbPolyPtr polySource);
void Lib_ArbPoly_From_ArbMatrix(ArbPolyPtr poly_Result, ArbMatPtr matA);


AcbPolyPtr Lib_Poly_Acb_Init_Func();
void Lib_Poly_Acb_Clear(AcbPolyPtr A);

void Lib_AcbMatrix_From_AcbPoly(AcbMatPtr matResult, AcbPolyPtr polySource);
void Lib_AcbPoly_From_AcbMatrix(AcbPolyPtr poly_Result, AcbMatPtr matA);

void Lib_ArbMatrix_From_MpfrMatrix(mpNumMatrixPtr matResult, mpNumMatrixPtr matA);
void Lib_MpfrMatrix_From_ArbMatrix(mpNumMatrixPtr matResult, mpNumMatrixPtr matA);

void Lib_AcbMatrix_From_MpfcMatrix(mpNumMatrixPtr matResult, mpNumMatrixPtr matA);
void Lib_MpfcMatrix_From_AcbMatrix(mpNumMatrixPtr matResult, mpNumMatrixPtr matA);



/* **************** OCT ************************ */

void mpfr_set_oct(MpfrPtr res, ORealPtr x);

void oct_set_arb(ORealPtr res, arb_t x);

void mpfc_set_octc(mpc_t res, OCplxPtr x);

void octc_set_acb(OCplxPtr res, acb_t x);




/* **************** CPLX ************************ */

void cplx_set_acb(std::complex<double>* out1, acb_t out1_acb);

void acb_set_cplx(acb_t in1_acb, std::complex<double> in1);






/* ****************** Sort ********************************************** */




void __cdecl  Lib_Eigen_MpAny_Sort(mpNumMatrixPtr x, int32_t SortOrder, int32_t SortCriterion);
void __cdecl  Lib_Eigen_MpAny_SortRowsByColumn(mpNumMatrixPtr x, int32_t ColumnToSortBy, int32_t SortOrder, int32_t SortCriterion);

void __cdecl  Lib_Eigen_MpAnyCplx_Sort(mpNumMatrixPtr x, int32_t SortOrder, int32_t SortCriterion);
void __cdecl  Lib_Eigen_MpAnyCplx_SortRowsByColumn(mpNumMatrixPtr x, int32_t ColumnToSortBy, int32_t SortOrder, int32_t SortCriterion);

void __cdecl  Lib_Eigen_MpAny_Select_Rows(mpNumMatrixPtr res, mpNumMatrixPtr A);

void __cdecl  Lib_Eigen_MpAnyCplx_Select_Rows(mpNumMatrixPtr res, mpNumMatrixPtr A);


/* **************** Eigen Matrix ************************ */


 mpNumMatrixPtr __cdecl  Lib_Eigen_MpAnyCplx_Init_Func();
 void __cdecl  Lib_Eigen_MpAnyCplx_Clear(mpNumMatrixPtr x);

 mpNumMatrixPtr __cdecl  Lib_Eigen_MpAny_Init_Func();
 void __cdecl  Lib_Eigen_MpAny_Clear(mpNumMatrixPtr x);


/* **************** Eigen Map ************************ */


 MapPtr __cdecl  Lib_Map_MpAnyCplx_Init_Func();
 void __cdecl  Lib_Map_MpAnyCplx_Clear(MapPtr z);

 MapPtr __cdecl  Lib_Map_MpAny_Init_Func();
 void __cdecl  Lib_Map_MpAny_Clear(MapPtr z);


 /* *************************** Dense Matrix: MpAny ******************************************************** */


 void __cdecl  Lib_Eigen_MpAny_GetCoeff(ScalarPtr result, long row, long col, mpNumMatrixPtr SourceMatrix);
 void __cdecl  Lib_Eigen_MpAny_SetCoeff(mpNumMatrixPtr result, ScalarPtr src, long row, long col);
 //
 uint32_t __cdecl  Lib_Eigen_MpAny_GetInfo(long what, mpNumMatrixPtr Matrix);
 //
 void __cdecl  Lib_Eigen_MpAny_Get_Block(mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
 void __cdecl  Lib_Eigen_MpAny_Put_Block(mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
 void __cdecl  Lib_Eigen_MpAny_SetSpecialValue(mpNumMatrixPtr xPtr, long what, long m, long n);
 void __cdecl  Lib_Eigen_MpAny_SetSpecialValue2(mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source);
 //
 uint32_t __cdecl  Lib_Eigen_MpAny_Compare(long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
 void __cdecl  Lib_Eigen_MpAny_BasicArithmetic(mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
 void __cdecl  Lib_Eigen_MpAny_Stats(mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source);
 void __cdecl  Lib_Eigen_MpAny_Stats2(mpNumMatrixPtr result, long *IndexX, long *IndexY, long what, mpNumMatrixPtr source);

 void __cdecl  Lib_Map_MpAny_GetItemValue(mpNumMatrixPtr ptr, MapPtr z, char *s);
 void __cdecl Lib_Eigen_MpAny_MultipleResults(MapPtr z, int32_t what, char *s, mpNumMatrixPtr A, mpNumMatrixPtr b);



 /* ************************** Dense Matrix: MpAnyCplx ********************************** */

 uint32_t __cdecl  Lib_Eigen_MpAnyCplx_GetInfo(long what, mpNumMatrixPtr Matrix);
 //
 void __cdecl  Lib_Eigen_MpAnyCplx_GetCoeff(ScalarPtr result, long row, long col, mpNumMatrixPtr SourceMatrix);
 void __cdecl  Lib_Eigen_MpAnyCplx_SetCoeff(mpNumMatrixPtr result, ScalarPtr src, long row, long col);
 //
 void __cdecl  Lib_Eigen_MpAnyCplx_Get_Block(mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
 void __cdecl  Lib_Eigen_MpAnyCplx_Put_Block(mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
 void __cdecl  Lib_Eigen_MpAnyCplx_SetSpecialValue(mpNumMatrixPtr xPtr, long what, long m, long n);
 void __cdecl  Lib_Eigen_MpAnyCplx_SetSpecialValue2(mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source);
 //
 uint32_t __cdecl  Lib_Eigen_MpAnyCplx_Compare(long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
 void __cdecl  Lib_Eigen_MpAnyCplx_BasicArithmetic(mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
 void __cdecl  Lib_Eigen_MpAnyCplx_Stats(mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source);


 void __cdecl  Lib_Map_MpAnyCplx_GetItemValue(mpNumMatrixPtr ptr, MapPtr z, char *s);
 void __cdecl Lib_Eigen_MpAnyCplx_MultipleResults(MapPtr z, int32_t what, char *s, mpNumMatrixPtr A, mpNumMatrixPtr b);



/* **************** MPFR ************************ */

void Mpfr_Arb_Realfunc0_Prec(ArbFuncPtr0 f0, MpfrPtr out1);
void Mpfr_Arb_Realfunc0Int32_Prec(ArbFuncPtr0Int32 f0Int32, MpfrPtr out1, const int32_t in1);
void Mpfr_Arb_Realfunc1_Prec(ArbFuncPtr1 f1, MpfrPtr out1, MpfrPtr in1);
void Mpfr_Arb_Realfunc1Int32_Prec(ArbFuncPtr1Int32 f1Int32, MpfrPtr out1, MpfrPtr in1, const int32_t in2);
void Mpfr_Arb_Realfunc2_Prec(ArbFuncPtr2 f2, MpfrPtr out1, MpfrPtr in1, MpfrPtr in2);
void Mpfr_Arb_Realfunc3_Prec(ArbFuncPtr3 f3, MpfrPtr out1, MpfrPtr in1, MpfrPtr in2, MpfrPtr in3);
void Mpfr_Arb_Realfunc4_Prec(ArbFuncPtr4 f4, MpfrPtr out1, MpfrPtr in1, MpfrPtr in2, MpfrPtr in3, MpfrPtr in4);




  void  __cdecl Lib_Mpfr_Set_Default_Prec (int32_t prec);
  int32_t  __cdecl Lib_Mpfr_Get_Default_Prec (void);
  void  __cdecl Lib_Set_Matrix_Mode(int32_t value);
  int32_t  __cdecl Lib_Get_Matrix_Mode();







uint64_t mpfr_get_ui64(mpfr_t x);

int64_t mpfr_get_si64(mpfr_t x);



int64_t mpfr_get_str_sizeinbase10(const char *template1, MpfrPtr x);

int64_t mpfr_get_str_intern(char * dest , uint32_t digits, const char *template1, MpfrPtr x);



char *  mpfr_get_str_extern(const char *template1, uint32_t digits, mpfr_t x);



void mpfr_set_fmpz(mpfr_t x, fmpz_t z);

void mpfr_set_fmpq(mpfr_t x, fmpq_t z);

void mpfr_set_arb(mpfr_t x, arb_t z);



void mpfr_const_degree(mpfr_t res, mpfr_rnd_t rnd);

void mpfr_const_phi(mpfr_t res, mpfr_rnd_t rnd);

void mpfr_const_log10(mpfr_t res, mpfr_rnd_t rnd);

void mpfr_const_e(mpfr_t res, mpfr_rnd_t rnd);

void mpfr_const_apery(mpfr_t res, mpfr_rnd_t rnd);






void mpfr_cosm1(mpfr_t res, mpfr_t x, mpfr_rnd_t rnd);


int mpfr_one_p(mpfr_t in1);

void mpfr_set_ui64(mpfr_t x, uint64_t uint64);

void mpfr_set_si64(mpfr_t x, int64_t sint64);






void mpfr_machine_epsilon_x(mpfr_t res, mpfr_t x, mp_prec_t prec);

void mpfr_machine_epsilon_prec(mpfr_t res, mp_prec_t prec);

void mpfr_minval_prec(mpfr_t res, mp_prec_t prec);

void mpfr_maxval_prec(mpfr_t res, mp_prec_t prec);

void mpfr_cplx_abs_from_real_and_imag(mpfr_t mp_res, const mpfr_t mp_src_real, const mpfr_t mp_src_imag);

void mpfr_cplx_sqrt_from_real_and_imag(mpfr_t mp_res_real, mpfr_t mp_res_imag, const mpfr_t mp_src_real, const mpfr_t mp_src_imag);




/* **************** MPFC ************************ */

void Mpfc_Acb_Cplxfunc0Int32_Prec(AcbFuncPtr0Int32 f0Int32, MpfcPtr out1, const int32_t in1);

void Mpfc_Acb_Cplxfunc1_Prec(AcbFuncPtr1 f1, MpfcPtr out1, MpfcPtr in1);

void Mpfc_Acb_Cplxfunc1Int32_Prec(AcbFuncPtr1Int32 f1Int32, MpfcPtr out1, MpfcPtr in1, const int32_t in2);

void Mpfc_Acb_Cplxfunc2_Prec(AcbFuncPtr2 f2, MpfcPtr out1, MpfcPtr in1, MpfcPtr in2);

void Mpfc_Acb_Cplxfunc3_Prec(AcbFuncPtr3 f3, MpfcPtr out1, MpfcPtr in1, MpfcPtr in2, MpfcPtr in3);

void Mpfc_Acb_Cplxfunc4_Prec(AcbFuncPtr4 f4, MpfcPtr out1, MpfcPtr in1, MpfcPtr in2, MpfcPtr in3, MpfcPtr in4);





void mpfc_set_ui64(mpc_t x, uint64_t uint64);

void mpfc_set_si64(mpc_t x, int64_t sint64);


void mpfc_set_fmpz(mpc_t res, fmpz_t x);

void mpfc_set_fmpq(mpc_t res, fmpq_t x);

void mpfc_set_mpfr(mpc_t res, mpfr_t x);

void mpfc_set_arb(mpc_t out1, arb_t in1);

void mpfc_set_acb(mpc_t out1, acb_t in1);


void mpfc_root_si(mpc_t res, mpc_t x, const int32_t k);

void mpfc_expm1(mpc_t res, mpc_t z, mpc_rnd_t rnd);

void mpfc_log1p(mpc_t res, mpc_t z, mpc_rnd_t rnd);

void mpfc_sqrt1pm1(mpc_t res, mpc_t z, mpc_rnd_t rnd);


void mpfc_exp2(mpc_t res, mpc_t z, mpc_rnd_t rnd);

void mpfc_exp10(mpc_t res, mpc_t z, mpc_rnd_t rnd);

void mpfc_exp2m1(mpc_t res, mpc_t z, mpc_rnd_t rnd);

void mpfc_exp10m1(mpc_t res, mpc_t z, mpc_rnd_t rnd);


void mpfc_log2(mpc_t res, mpc_t z, mpc_rnd_t rnd);

void mpfc_log2p1(mpc_t res, mpc_t z, mpc_rnd_t rnd);

void mpfc_log10p1(mpc_t res, mpc_t z, mpc_rnd_t rnd);



void mpfc_powm1(mpc_t res, mpc_t x, mpc_t y, mpc_rnd_t rnd);

void mpfc_pow1p(mpc_t res, mpc_t x, mpc_t y, mpc_rnd_t rnd);

void mpfc_pow1pm1(mpc_t res, mpc_t x, mpc_t y, mpc_rnd_t rnd);











///* **************** ARB ************************ */


void Arb_Realfunc1(arb_t out1, long what, slong wp, arb_t in1);

void Arb_Realfunc2(arb_t out1, long what, slong wp, arb_t in1, arb_t in2);

void Arb_Realfunc3(arb_t out1, long what, slong wp, arb_t in1, arb_t in2, arb_t in3);

void Arb_Realfunc4(arb_t out1, long what, slong wp, arb_t in1, arb_t in2, arb_t in3, arb_t in4);


int arb_FitsInt32(const arb_t x);

int arb_FitsInt64(const arb_t x);

int arb_FitsUInt32(const arb_t x);

int arb_FitsUInt64(const arb_t x);


int32_t arb_ToInt32(const arb_t x);

int64_t arb_ToInt64(const arb_t x);

uint32_t arb_ToUInt32(const arb_t x);

uint64_t arb_ToUInt64(const arb_t x);




void arb_set_ui64(arb_t x, uint64_t uint64);

void arb_set_si64(arb_t x, int64_t sint64);

void arb_set_mpfr(arb_t x, mpfr_t in1);



int64_t arf_sizeinbase10(int32_t n, uint32_t flags, arf_t x);

int64_t arf_get_str_intern(char * dest, ScalarPtr x, int32_t n, uint32_t flags);

char * arf_get_str_extern(int32_t n, uint32_t flags, arf_t x);

int32_t arf_fits_int64(arf_t x);

int32_t arf_fits_int32(arf_t x);

int32_t arf_fits_uint64(arf_t x);

int32_t arf_fits_uint32(arf_t x);

int64_t arf_get_si64(arf_t x);

int32_t arf_get_si32(arf_t x);

uint64_t arf_get_ui64(arf_t x);

uint32_t arf_get_ui32(arf_t x);




char * arb_get_str_extern(int32_t n, uint32_t flags, arb_t x);

int64_t arb_get_str_intern(char * dest , ScalarPtr x, int32_t n, uint32_t flags);

int64_t arb_sizeinbase10(int32_t n, uint32_t flags, arb_t x);

int32_t arb_fits_int64(arb_t x);

int32_t arb_fits_uint64(arb_t x);

int32_t arb_fits_int32(arb_t x);

int32_t arb_fits_uint32(arb_t x);



uint64_t arb_get_ui64(arb_t x);

int64_t arb_get_si64(arb_t x);


uint32_t arb_get_ui32(arb_t x);

int32_t arb_get_si32(arb_t x);


double arb_get_d(arb_t in1);


void arb_add_d(arb_t z, const arb_t x, double y, slong prec);

void arb_sub_d(arb_t z, const arb_t x, double y, slong prec);

void arb_mul_d(arb_t z, const arb_t x, double y, slong prec);

void arb_div_d(arb_t z, const arb_t x, double y, slong prec);


//void arb_machine_epsilon_x(arb_t res, arb_t x, mp_prec_t prec);

void arb_get_ulp(arb_t res, const arb_t x, slong prec);

void arb_machine_epsilon_prec(arb_t res, slong prec);

void arb_maxval_prec(arb_t res, slong prec);

void arb_minval_prec(arb_t res, slong prec);


void arb_frexp(arb_t res, const arb_t x, fmpz_t e);


void arb_next_above(arb_t res, const arb_t x, slong prec);

void arb_next_below(arb_t res, const arb_t x, slong prec);

void arb_next_toward(arb_t res, const arb_t x, const arb_t y, slong prec);



void arb_cplx_abs_from_real_and_imag(arb_t mp_res, const arb_t mp_src_real, const arb_t mp_src_imag);

void arb_cplx_sqrt_from_real_and_imag(arb_t mp_res_real, arb_t mp_res_imag, const arb_t mp_src_real, const arb_t mp_src_imag);






//////////////////////////////////////////////////////
//// Arb functions
//////////////////////////////////////////////////////





/* Constants */


void arb_const_degree_(arb_t out1, slong wp);

void arb_const_phi_(arb_t out1, slong wp);




/* Roots and quadratic, cubic, and quartic equations */

void arb_cbrt(arb_t res, const arb_t x, slong prec);

void arb_root_ui_(arb_t out1, const arb_t x, int32_t n, slong prec);

void arb_root_si_(arb_t res, const arb_t x, int32_t n, slong prec);



/* Exponential and related functions */


void arb_exp10_(arb_t out1, const arb_t in1, slong wp);

void arb_exp2_(arb_t out1, const arb_t in1, slong wp);

void arb_exp10m1_(arb_t out1, const arb_t in1, slong wp);

void arb_exp2m1_(arb_t out1, const arb_t in1, slong wp);

void arb_exprel_(arb_t out1, const arb_t in1, slong wp);






/* Logarithms and related functions */


void arb_logbase_(arb_t out1, const arb_t z, const arb_t b, slong wp);

void arb_log10p1_(arb_t out1, const arb_t in1, slong wp);

void arb_log2p1_(arb_t out1, const arb_t in1, slong wp);

void arb_log2(arb_t res, const arb_t x, slong prec);

void arb_log10(arb_t res, const arb_t x, slong prec);

void arb_log1mexp_(arb_t out1, const arb_t x, slong wp);

void arb_lambertw0(arb_t res, const arb_t x, slong prec);

void arb_lambertwm1(arb_t res, const arb_t x, slong prec);



/* Power functions */

void arb_cube_(arb_t out1, const arb_t in1, slong wp);




void arb_powm1_(arb_t out1, const arb_t a, const arb_t b, slong wp);

void arb_pow1p_(arb_t out1, const arb_t a, const arb_t b, slong wp);

void arb_pow1pm1_(arb_t out1, const arb_t a, const arb_t b, slong wp);


void arb_pow_ui_(arb_t out1, const arb_t x, int32_t n, slong prec);

void arb_pow_si_(arb_t out1, const arb_t x, int32_t n, slong prec);

void arb_compound_si_(arb_t res, const arb_t x, int32_t n, slong prec);



/* Trigonometric and related functions */


void arb_cosm1_(arb_t res, const arb_t x, slong prec);

void arb_sec_pi_(arb_t res, const arb_t x, slong prec);




/* Hyperbolic functions */






/* Inverse trigonometric functions */


void arb_acsc(arb_t out1, const arb_t in1, slong wp);

void arb_asec(arb_t out1, const arb_t in1, slong wp);

void arb_acot(arb_t out1, const arb_t in1, slong wp);






/* Inverse hyperbolic functions */


void arb_acsch(arb_t out1, const arb_t in1, slong wp);

void arb_asech(arb_t out1, const arb_t in1, slong wp);

void arb_acoth(arb_t out1, const arb_t in1, slong wp);









/* Legendre elliptic integrals (elliptic parameter m) */

void arb_elliptic_k(arb_t res, const arb_t m, slong prec);

void arb_elliptic_e(arb_t res, const arb_t m, slong prec);

void arb_elliptic_pi(arb_t res, const arb_t n, const arb_t m, slong prec);

void arb_elliptic_f_(arb_t res, const arb_t phi, const arb_t m, slong prec);

void arb_elliptic_e_inc_(arb_t res, const arb_t phi, const arb_t m, slong prec);

void arb_elliptic_pi_inc_(arb_t res, const arb_t n, const arb_t phi, const arb_t m, slong prec);





/* Legendre elliptic integrals (elliptic modulus k), and related functions */

void arb_elliptic_k_k_(arb_t res, const arb_t k, slong wp);

void arb_elliptic_e_k_(arb_t res, const arb_t k, slong wp);

void arb_elliptic_pi_k_(arb_t res, const arb_t n, const arb_t k, slong prec);

void arb_elliptic_f_k_(arb_t res, const arb_t phi, const arb_t k, slong prec);

void arb_elliptic_e_inc_k_(arb_t res, const arb_t phi, const arb_t k, slong prec);

void arb_elliptic_pi_inc_k_(arb_t res, const arb_t n, const arb_t phi, const arb_t k, slong prec);





/* Carlson symmetric elliptic integrals */

void arb_elliptic_rc_(arb_t res, const arb_t x, const arb_t y, slong prec);

void arb_elliptic_rf_(arb_t res, const arb_t x, const arb_t y, const arb_t z, slong prec);

void arb_elliptic_rg_(arb_t res, const arb_t x, const arb_t y, const arb_t z, slong prec);

void arb_elliptic_rd_(arb_t res, const arb_t x, const arb_t y, const arb_t z, slong prec);

void arb_elliptic_rj_(arb_t res, const arb_t x, const arb_t y, const arb_t z, const arb_t w, slong prec);






/* Jacobi theta functions */


void _arb_theta1q(arb_t res, const arb_t z, const arb_t q, slong prec);

void _arb_theta2q(arb_t res, const arb_t z, const arb_t q, slong prec);

void _arb_theta3q(arb_t res, const arb_t z, const arb_t q, slong prec);

void _arb_theta4q(arb_t res, const arb_t z, const arb_t q, slong prec);





/* Jacobi elliptic functions */


void _arb_jacobi_sn(arb_t res, const arb_t u, const arb_t k, slong prec);

void _arb_jacobi_cn(arb_t res, const arb_t u, const arb_t k, slong prec);

void _arb_jacobi_dn(arb_t res, const arb_t u, const arb_t k, slong prec);


void _arb_jacobi_ns(arb_t res, const arb_t u, const arb_t k, slong prec);

void _arb_jacobi_nc(arb_t res, const arb_t u, const arb_t k, slong prec);

void _arb_jacobi_nd(arb_t res, const arb_t u, const arb_t k, slong prec);


void _arb_jacobi_sc(arb_t res, const arb_t u, const arb_t k, slong prec);

void _arb_jacobi_sd(arb_t res, const arb_t u, const arb_t k, slong prec);


void _arb_jacobi_dc(arb_t res, const arb_t u, const arb_t k, slong prec);

void _arb_jacobi_ds(arb_t res, const arb_t u, const arb_t k, slong prec);


void _arb_jacobi_cs(arb_t res, const arb_t u, const arb_t k, slong prec);

void _arb_jacobi_cd(arb_t res, const arb_t u, const arb_t k, slong prec);






/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */






/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

void arb_dirichlet_lerch_phi(arb_t res, const arb_t z, const arb_t s, const arb_t a, slong prec);





/* Polygamma functions */





/* Polylogarithms and related functions */

void arb_polygamma(arb_t res, const arb_t s, const arb_t z, slong prec);





/* Hurwitz zeta function and related functions */


void arb_bernoulli_ui_(arb_t out1, const int32_t n, slong wp);


void arb_bernoulli_poly_ui_(arb_t out1, const arb_t x, int32_t n, slong prec);


void arb_euler_number_ui_(arb_t out1, const int32_t n, slong wp);


void arb_barnes_g(arb_t res, const arb_t x, slong prec);

void arb_log_barnes_g(arb_t res, const arb_t x, slong prec);





/* Riemann zeta function, and related functions */



void arb_gram_point_ui_(arb_t out1, int32_t n, slong wp);




/* Additional numbertheoretic functions */

void arb_bell_ui_(arb_t out1, const int32_t n, slong wp);

void arb_primorial_nth_ui_(arb_t out1, const int32_t n, slong wp);

void arb_partitions_ui_(arb_t out1, const int32_t n, slong wp);








/* Confluent Hypergeometric Limit Function 0F1, overview */

void arb_hypgeom_0f1_(arb_t res, const arb_t a, const arb_t x, slong prec);

void arb_hypgeom_0f1_r(arb_t res, const arb_t a, const arb_t x, slong prec);





/* Bessel functions and modified Bessel functions  */





/* Spherical Bessel functions  */



/* Airy functions  */


void arb_airy_ai(arb_t res, const arb_t x, slong prec);

void arb_airy_ai_prime(arb_t res, const arb_t x, slong prec);

void arb_airy_bi(arb_t res, const arb_t x, slong prec);

void arb_airy_bi_prime(arb_t res, const arb_t x, slong prec);




void arb_airy_ai_zero(arb_t res, const int n, slong prec);

void arb_airy_ai_prime_zero(arb_t res, const int n, slong prec);

void arb_airy_bi_zero(arb_t res, const int n, slong prec);

void arb_airy_bi_prime_zero(arb_t res, const int n, slong prec);



/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */


void arb_hypgeom_1f1_(arb_t res, const arb_t a, const arb_t b, const arb_t x, slong prec);

void arb_hypgeom_1f1r_(arb_t res, const arb_t a, const arb_t b, const arb_t x, slong prec);






/* Gamma function and related functions */

void arb_beta_(arb_t res, const arb_t a, const arb_t b, slong prec);






/* Incomplete gamma functions */


void arb_gamma_upper_(arb_t res, const arb_t a, const arb_t x, slong prec);

void arb_gamma_upper_r(arb_t res, const arb_t a, const arb_t x, slong prec);

void arb_gamma_lower_(arb_t res, const arb_t a, const arb_t x, slong prec);

void arb_gamma_lower_r(arb_t res, const arb_t a, const arb_t x, slong prec);

void arb_gamma_p(arb_t out1, const arb_t a,  const arb_t x, slong wp);

void arb_gamma_q(arb_t out1, const arb_t a,  const arb_t x, slong wp);

void arb_gamma_p_derivative(arb_t out1, const arb_t a,  const arb_t x, slong wp);





/* Error function and related functions */


void arb_ndens(arb_t out1, const arb_t x, slong wp);

void arb_ndis(arb_t out1, const arb_t x, slong wp);


void arb_fresnelc(arb_t res, const arb_t x, slong prec);

void arb_fresnels(arb_t res, const arb_t x, slong prec);





/* Exponential integrals and related functions */


void arb_hypgeom_li_(arb_t res, const arb_t x, slong prec);

void arb_hypgeom_li_offset(arb_t res, const arb_t x, slong prec);





/* 1F1: Orthogonal polynomials */






/* 1F1: Coulomb functions */

void arb_hypgeom_coulomb_f(arb_t res, const arb_t l, const arb_t eta, const arb_t x, slong prec);

void arb_hypgeom_coulomb_g(arb_t res, const arb_t l, const arb_t eta, const arb_t x, slong prec);








/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */

void arb_hypgeom_2f1_(arb_t res, const arb_t a, const arb_t b, const arb_t c, const arb_t x, slong prec);

void arb_hypgeom_2f1r_(arb_t res, const arb_t a, const arb_t b, const arb_t c, const arb_t x, slong prec);





/* 2F1: Orthogonal polynomials */


void arb_hypgeom_legendre_p_(arb_t res, const arb_t n, const arb_t m, const arb_t x, slong prec);

void arb_hypgeom_legendre_pv_(arb_t res, const arb_t n, const arb_t m, const arb_t x, slong prec);

void arb_hypgeom_legendre_q_(arb_t res, const arb_t n, const arb_t m, const arb_t x, slong prec);

void arb_hypgeom_legendre_qv_(arb_t res, const arb_t n, const arb_t m, const arb_t x, slong prec);





/* 2F1: Incomplete Beta Function */


void arb_hypgeom_beta_lower_(arb_t res, const arb_t a, const arb_t b, const arb_t x, slong prec);

void arb_hypgeom_beta_lower_r_(arb_t res, const arb_t a, const arb_t b, const arb_t x, slong prec);

void arb_ibeta(arb_t out1, const arb_t a,  const arb_t b,  const arb_t x, slong wp);

void arb_ibetac(arb_t out1, const arb_t a,  const arb_t b,  const arb_t x, slong wp);

void arb_ibeta_derivative(arb_t out1, const arb_t a,  const arb_t b,  const arb_t x, slong wp);




/* Hypergeometric Function 1F2, overview */


void arb_hypgeom_1f2(arb_t res, const arb_t a1, const arb_t b1, const arb_t b2,
                     const arb_t z, int regularized, slong prec);

void arb_hypgeom_1f2_(arb_t res, const arb_t a1, const arb_t b1, const arb_t b2, const arb_t z, slong prec);

void arb_hypgeom_1f2r_(arb_t res, const arb_t a1, const arb_t b1, const arb_t b2, const arb_t z, slong prec);






















///* **************** ACB ************************ */

void acb_set_ui64(acb_t x, uint64_t uint64);

void acb_set_si64(acb_t x, int64_t sint64);


void acb_set_mpfr(acb_t out1, mpfr_t in1);

void acb_set_mpc(acb_t out1, mpc_t in1);

void acb_get_mpc(mpc_t out1, acb_t in1); /* change in UseFunc to mpfc_set_acb */




/* **************** ACB ************************ */




//////////////////////////////////////////////////////
//// Acb functions
//////////////////////////////////////////////////////



/* Roots and quadratic, cubic, and quartic equations */


void acb_root_ui_(acb_t out1, const acb_t in1, int32_t in2, slong wp);

void acb_unit_root_(acb_t out1, int32_t in1, slong wp);

void acb_cbrt(acb_t res, const acb_t x, slong prec);

void acb_sqrt1pm1(acb_t out1, const acb_t in1, slong wp);

void acb_root_si_(acb_t res, const acb_t x, int32_t n, slong prec);









/* Exponential and related functions */


void acb_expj_(acb_t out1, const acb_t in1, slong wp);

void acb_exp10_(acb_t out1, const acb_t in1, slong wp);

void acb_exp2_(acb_t out1, const acb_t in1, slong wp);

void acb_exp10m1_(acb_t out1, const acb_t in1, slong wp);

void acb_exp2m1_(acb_t out1, const acb_t in1, slong wp);

void acb_exprel_(acb_t out1, const acb_t in1, slong wp);






/* Logarithms and related functions */


void acb_logbase_(acb_t out1, const acb_t z, const acb_t b, slong wp);

void acb_log10_(acb_t out1, const acb_t in1, slong wp);

void acb_log2_(acb_t out1, const acb_t in1, slong wp);

void acb_log10p1_(acb_t out1, const acb_t in1, slong wp);

void acb_log2p1_(acb_t out1, const acb_t in1, slong wp);


void acb_lambertw_ui_(acb_t out1, const acb_t in1, int32_t in2, slong wp);



/* Power functions */


void acb_hypot_(acb_t out1, const acb_t a, const acb_t b, slong wp);


void acb_powm1_(acb_t out1, const acb_t a, const acb_t b, slong wp);

void acb_pow1p_(acb_t out1, const acb_t a, const acb_t b, slong wp);

void acb_pow1pm1_(acb_t out1, const acb_t a, const acb_t b, slong wp);


void acb_pow_si_(acb_t out1, const acb_t in1, int32_t in2, slong wp);

void acb_compound_si_(acb_t res, const acb_t x, int32_t n, slong prec);





/* Trigonometric and related functions */


void acb_sec_pi_(acb_t res, const acb_t x, slong prec);





/* Hyperbolic functions */






/* Inverse trigonometric functions */

void acb_acsc(acb_t out1, const acb_t in1, slong wp);

void acb_asec(acb_t out1, const acb_t in1, slong wp);

void acb_acot(acb_t out1, const acb_t in1, slong wp);





/* Inverse hyperbolic functions */

void acb_acsch(acb_t out1, const acb_t in1, slong wp);

void acb_asech(acb_t out1, const acb_t in1, slong wp);

void acb_acoth(acb_t out1, const acb_t in1, slong wp);









/* Legendre elliptic integrals (elliptic parameter m) */



void acb_elliptic_f_(acb_t res, const acb_t phi, const acb_t m, slong prec);

void acb_elliptic_e_inc_(acb_t res, const acb_t phi, const acb_t m, slong prec);

void acb_elliptic_pi_inc_(acb_t res, const acb_t n, const acb_t phi, const acb_t m, slong prec);




/* Legendre elliptic integrals (elliptic modulus k), and related functions */


void acb_elliptic_k_k_(acb_t res, const acb_t k, slong prec);

void acb_elliptic_e_k_(acb_t res, const acb_t k, slong prec);

void acb_elliptic_pi_k_(acb_t res, const acb_t phi, const acb_t k, slong prec);

void acb_elliptic_f_k_(acb_t res, const acb_t phi, const acb_t k, slong prec);

void acb_elliptic_e_inc_k_(acb_t res, const acb_t phi, const acb_t k, slong prec);

void acb_elliptic_pi_inc_k_(acb_t res, const acb_t n, const acb_t phi, const acb_t k, slong prec);






/* Carlson symmetric elliptic integrals */


void acb_elliptic_rc_(acb_t res, const acb_t x, const acb_t y, slong prec);

void acb_elliptic_rf_(acb_t res, const acb_t x, const acb_t y, const acb_t z, slong prec);

void acb_elliptic_rg_(acb_t res, const acb_t x, const acb_t y, const acb_t z, slong prec);

void acb_elliptic_rd_(acb_t res, const acb_t x, const acb_t y, const acb_t z, slong prec);

void acb_elliptic_rj_(acb_t res, const acb_t x, const acb_t y, const acb_t z, const acb_t w, slong prec);







/* Jacobi theta functions */


void _acb_theta_jet(acb_t res, const acb_t ncplx, const acb_t z, const acb_t tau, const acb_t dcplx, slong prec);


void _acb_theta1(acb_t res, const acb_t z, const acb_t tau, slong prec);

void _acb_theta2(acb_t res, const acb_t z, const acb_t tau, slong prec);

void _acb_theta3(acb_t res, const acb_t z, const acb_t tau, slong prec);

void _acb_theta4(acb_t res, const acb_t z, const acb_t tau, slong prec);



void _acb_theta1q(acb_t res, const acb_t z, const acb_t q, slong prec);

void _acb_theta2q(acb_t res, const acb_t z, const acb_t q, slong prec);

void _acb_theta3q(acb_t res, const acb_t z, const acb_t q, slong prec);

void _acb_theta4q(acb_t res, const acb_t z, const acb_t q, slong prec);








/* Jacobi elliptic functions */


void _acb_qfromk(acb_t res, const acb_t k, slong prec);

void _acb_tfrom_u_q(acb_t res, const acb_t u, const acb_t q, slong prec);

void _acb_sn_t_q(acb_t res, const acb_t t, const acb_t q, slong prec);

void _acb_cn_t_q(acb_t res, const acb_t t, const acb_t q, slong prec);

void _acb_dn_t_q(acb_t res, const acb_t t, const acb_t q, slong prec);


void _acb_jacobi_sn(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_cn(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_dn(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_ns(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_nc(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_nd(acb_t res, const acb_t u, const acb_t k, slong prec);


void _acb_jacobi_sc(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_sd(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_dc(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_ds(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_cs(acb_t res, const acb_t u, const acb_t k, slong prec);

void _acb_jacobi_cd(acb_t res, const acb_t u, const acb_t k, slong prec);








/* Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau */


void _acb_wp_prime(acb_t res, const acb_t z, const acb_t tau, slong prec);





void _acb_elliptic_invariant_g2(acb_t res, const acb_t tau, slong prec);

void _acb_elliptic_invariant_g3(acb_t res, const acb_t tau, slong prec);



void _acb_elliptic_root_e1(acb_t res, const acb_t tau, slong prec);

void _acb_elliptic_root_e2(acb_t res, const acb_t tau, slong prec);

void _acb_elliptic_root_e3(acb_t res, const acb_t tau, slong prec);






/* Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3 */





/* Lerch’s transcendent: overview */

void _acb_lerch_zeta(acb_t res, const acb_t lambda1, const acb_t alpha, const acb_t s, slong prec);




/* Polygamma functions */

void _acb_trigamma(acb_t res, const acb_t z, slong prec);




/* Polylogarithms and related functions */

void _acb_trilog(acb_t res, const acb_t z, slong prec);

void _acb_clausen_sin(acb_t res, const acb_t s, const acb_t z, slong prec);

void _acb_clausen_cos(acb_t res, const acb_t s, const acb_t z, slong prec);

void _acb_clausen2(acb_t res, const acb_t z, slong prec);

void _acb_bose_einstein(acb_t res, const acb_t s, const acb_t z, slong prec);

void _acb_fermi_dirac(acb_t res, const acb_t s, const acb_t z, slong prec);

void _acb_legendre_chi(acb_t res, const acb_t s, const acb_t z, slong prec);

void _acb_ti(acb_t res, const acb_t s, const acb_t z, slong prec);




/* Hurwitz zeta function and related functions */

void acb_stieltjes_ui_(acb_t out1, const acb_t in1, int32_t in2, slong wp);

void acb_bernoulli_poly_ui_(acb_t out1, const acb_t in1, int32_t in2, slong wp);

void _acb_harmonic(acb_t res, const acb_t z, slong prec);

void _acb_harmonic2(acb_t res, const acb_t z, const acb_t r, slong prec);

void acb_euler_poly_ui_(acb_t res, const acb_t z, int32_t n, slong prec);

void _acb_hyperfac(acb_t res, const acb_t z, slong prec);

void _acb_superfac(acb_t res, const acb_t z, slong prec);




/* Riemann zeta function, and related functions */

void _acb_zetam1(acb_t res, const acb_t s, slong prec);

void _acb_dirichlet_etam1(acb_t res, const acb_t s, slong prec);

void _acb_dirichlet_beta(acb_t res, const acb_t s, slong prec);

void _acb_dirichlet_lambda(acb_t res, const acb_t s, slong prec);


void acb_dirichlet_hardy_z_(acb_t res, const acb_t t, slong prec);

void acb_dirichlet_hardy_theta_(acb_t res, const acb_t t, slong prec);

void acb_dirichlet_zeta_zero_ui_(acb_t out1, int32_t in1, slong wp);





/* Additional numbertheoretic functions */





/* Confluent Hypergeometric Limit Function 0F1, overview */

void acb_hypgeom_0f1_(acb_t res, const acb_t a, const acb_t x, slong prec);

void acb_hypgeom_0f1_r(acb_t res, const acb_t a, const acb_t x, slong prec);





/* Bessel functions and modified Bessel functions  */





/* Spherical Bessel functions  */



/* Airy functions  */

void acb_airy_ai(acb_t res, const acb_t x, slong prec);

void acb_airy_ai_prime(acb_t res, const acb_t x, slong prec);

void acb_airy_bi(acb_t res, const acb_t x, slong prec);

void acb_airy_bi_prime(acb_t res, const acb_t x, slong prec);






/* Kelvin functions  */




/* Kummer’s Confluent Hypergeometric Function 1F1 */

void acb_hypgeom_1f1_(acb_t res, const acb_t a, const acb_t b, const acb_t x, slong prec);

void acb_hypgeom_1f1r_(acb_t res, const acb_t a, const acb_t b, const acb_t x, slong prec);








/* Gamma function and related functions */


void acb_beta_(acb_t res, const acb_t a, const acb_t b, slong prec);


void acb_beta_(acb_t res, const acb_t a, const acb_t b, slong prec);





/* Incomplete gamma functions */



void acb_gamma_upper_(acb_t res, const acb_t a, const acb_t x, slong prec);

void acb_gamma_upper_r(acb_t res, const acb_t a, const acb_t x, slong prec);

void acb_gamma_lower_(acb_t res, const acb_t a, const acb_t x, slong prec);

void acb_gamma_lower_r(acb_t res, const acb_t a, const acb_t x, slong prec);




void acb_gamma_p_derivative(acb_t out1, const acb_t a,  const acb_t x, slong wp);

void acb_gamma_p(acb_t out1, const acb_t a,  const acb_t x, slong wp);

void acb_gamma_q(acb_t out1, const acb_t a,  const acb_t x, slong wp);






/* Error function and related functions */


void acb_ndens(acb_t out1, const acb_t z, slong wp);

void acb_ndis(acb_t out1, const acb_t z, slong wp);

void acb_fresnelc(acb_t res, const acb_t x, slong prec);

void acb_fresnels(acb_t res, const acb_t x, slong prec);






/* Exponential integrals and related functions */


void acb_hypgeom_li_(acb_t res, const acb_t x, slong prec);

void acb_hypgeom_li_offset(acb_t res, const acb_t x, slong prec);





/* 1F1: Orthogonal polynomials */






/* 1F1: Coulomb functions */


void acb_hypgeom_coulomb_f(acb_t res, const acb_t l, const acb_t eta, const acb_t x, slong prec);

void acb_hypgeom_coulomb_g(acb_t res, const acb_t l, const acb_t eta, const acb_t x, slong prec);


void acb_hypgeom_coulomb_hpos(acb_t res, const acb_t l, const acb_t eta, const acb_t x, slong prec);

void acb_hypgeom_coulomb_hneg(acb_t res, const acb_t l, const acb_t eta, const acb_t x, slong prec);









/* 1F1: Whittaker functions */




/* 1F1: Parabolic cylinder functions */





/* Gauss Hypergeometric Function 2F1, overview */

void acb_hypgeom_2f1_(acb_t res, const acb_t a, const acb_t b, const acb_t c, const acb_t x, slong prec);

void acb_hypgeom_2f1r_(acb_t res, const acb_t a, const acb_t b, const acb_t c, const acb_t x, slong prec);






/* 2F1: Orthogonal polynomials */


void acb_hypgeom_legendre_p_(acb_t res, const acb_t n, const acb_t m, const acb_t x, slong prec);

void acb_hypgeom_legendre_pv_(acb_t res, const acb_t n, const acb_t m, const acb_t x, slong prec);

void acb_hypgeom_legendre_q_(acb_t res, const acb_t n, const acb_t m, const acb_t x, slong prec);

void acb_hypgeom_legendre_qv_(acb_t res, const acb_t n, const acb_t m, const acb_t x, slong prec);





/* 2F1: Incomplete Beta Function */


void acb_ibeta_derivative(acb_t out1, const acb_t a,  const acb_t b,  const acb_t x, slong wp);

void acb_ibeta(acb_t out1, const acb_t a,  const acb_t b,  const acb_t x, slong wp);

void acb_ibetac(acb_t out1, const acb_t a,  const acb_t b,  const acb_t x, slong wp);


void acb_hypgeom_beta_lower_(acb_t res, const acb_t a, const acb_t b, const acb_t x, slong prec);

void acb_hypgeom_beta_lower_r_(acb_t res, const acb_t a, const acb_t b, const acb_t x, slong prec);


void _acb_hypgeom_spherical_y(acb_t res, const acb_t ncplx, const acb_t mcplx, const acb_t theta, const acb_t phi, slong prec);






/* Hypergeometric Function 1F2, overview */



void acb_hypgeom_1f2(acb_t res, const acb_t a1, const acb_t b1, const acb_t b2,
                     const acb_t z, int regularized, slong prec);

void acb_hypgeom_1f2_(acb_t res, const acb_t a1, const acb_t b1, const acb_t b2, const acb_t z, slong prec);

void acb_hypgeom_1f2r_(acb_t res, const acb_t a1, const acb_t b1, const acb_t b2, const acb_t z, slong prec);











#endif // HELPERFUNCTIONS_H_INCLUDED



