//
//
//
//#include "Helperfunctions.h"
////#include <mp_BoostEigenConstants.h>
//
//
//typedef fmpq *fmpq_ptr;
//typedef fmpz *fmpz_ptr;
//
//
//
////#include "stdafx.h"
//#include <iostream>
//#include <cstdio>
//#include <cstdlib>
//#include <string>
//
//
//
//
///***************  Arb Polynomials  ************************************/
//
//
//void Lib_Arb_Poly_Set_Vector(ArbPtr Vector, ArbPolyPtr A, int32_t len)
//{
//    _arb_vec_set((arb_ptr)Vector, ((arb_poly_struct*)A)->coeffs, len);
//}
//
//
//
///***************  Acb  Polynomials  ************************************/
//
//
//
//
//
//
//
//
///**************************** Polynomials: General Functions ******************************/
////{
//
//
//int32_t FmpzPoly_Func(fmpz_poly_t fmpz_poly_Result, fmpz_poly_t fmpz_poly_Result2, int32_t what, int32_t len, FmpzPtr z, fmpz_poly_t fmpz_poly_A, fmpz_poly_t fmpz_poly_B)
//{
//    int32_t result = 0;
//    switch (what) {
//
//        case mp_poly_normalize: _fmpz_poly_normalise(fmpz_poly_A); break;
//        case mp_poly_length: result = fmpz_poly_length(fmpz_poly_A); break;
//        case mp_poly_degree: result = fmpz_poly_degree(fmpz_poly_A); break;
//
//        case mp_poly_set_coeff: fmpz_poly_set_coeff_fmpz(fmpz_poly_Result, len, (fmpz_ptr)z); break;
//        case mp_poly_get_coeff: fmpz_poly_get_coeff_fmpz((fmpz_ptr) fmpz_poly_Result, fmpz_poly_A, len); break;
//
//        case mp_poly_set: fmpz_poly_set(fmpz_poly_Result, fmpz_poly_A); break;
//        case mp_poly_neg: fmpz_poly_neg(fmpz_poly_Result, fmpz_poly_A); break;
//
//        case mp_poly_shift_left: fmpz_poly_shift_left(fmpz_poly_Result, fmpz_poly_A, len); break;
//        case mp_poly_shift_right: fmpz_poly_shift_right(fmpz_poly_Result, fmpz_poly_A, len); break;
//
////        case mp_poly_majorant: fmpz_poly_majorant((fmpz_poly_struct*)  fmpz_poly_Result, fmpz_poly_A); break;
//
//
//        case mp_poly_resize:     fmpz_poly_fit_length(fmpz_poly_A, len + 1);
//                                _fmpz_poly_set_length(fmpz_poly_A, len + 1);  break;
//
//        case mp_poly_truncate: fmpz_poly_truncate(fmpz_poly_A, len); break;
//
//        case mp_poly_scalar_mul: fmpz_poly_scalar_mul_fmpz(fmpz_poly_Result, fmpz_poly_A, (fmpz_ptr)z); break;
//        case mp_poly_scalar_div: fmpz_poly_scalar_tdiv_fmpz(fmpz_poly_Result, fmpz_poly_A, (fmpz_ptr)z); break;
//        case mp_poly_pow_ui: fmpz_poly_pow(fmpz_poly_Result, fmpz_poly_A, len); break;
//        case mp_poly_taylor_shift: fmpz_poly_taylor_shift(fmpz_poly_Result, fmpz_poly_A, (fmpz_ptr)z); break;
//
//        case mp_poly_swap: fmpz_poly_swap(fmpz_poly_A, fmpz_poly_B); break;
//        case mp_poly_equal: result = fmpz_poly_equal(fmpz_poly_A, fmpz_poly_B); break;
//
//
//        case mp_poly_add: fmpz_poly_add(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B); break;
//        case mp_poly_sub: fmpz_poly_sub(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B); break;
//        case mp_poly_mul: fmpz_poly_mul(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B); break;
//        case mp_poly_div: fmpz_poly_divrem(fmpz_poly_Result, fmpz_poly_Result2, fmpz_poly_A, fmpz_poly_B); break;
//        case mp_poly_compose: fmpz_poly_compose(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B); break;
//
//
//        case mp_poly_evaluate: fmpz_poly_evaluate_fmpz((fmpz_ptr) fmpz_poly_Result, fmpz_poly_A, (fmpz_ptr)z); break;
////        case mp_poly_evaluate2: fmpz_poly_evaluate2((fmpz_ptr) fmpz_poly_Result, (fmpz_ptr) fmpz_poly_Result2, fmpz_poly_A, (fmpz_ptr)z); break;
//
//
//        case mp_poly_evaluate_vec_iter: fmpz_poly_evaluate_fmpz_vec(fmpz_poly_Result->coeffs, fmpz_poly_A, fmpz_poly_B->coeffs, len); break;
////        case mp_poly_evaluate_vec_fast: fmpz_poly_evaluate_vec_fast(fmpz_poly_Result->coeffs, fmpz_poly_A, fmpz_poly_B->coeffs, len); break;
////
////
////        case mp_poly_interpolate_newton: fmpz_poly_interpolate_newton(fmpz_poly_Result, fmpz_poly_A->coeffs, fmpz_poly_B->coeffs, len); break;
////        case mp_poly_interpolate_barycentric: fmpz_poly_interpolate_barycentric(fmpz_poly_Result, fmpz_poly_A->coeffs, fmpz_poly_B->coeffs, len); break;
////        case mp_poly_interpolate_fast: fmpz_poly_interpolate_fast(fmpz_poly_Result, fmpz_poly_A->coeffs, fmpz_poly_B->coeffs, len); break;
//
////        case mp_poly_fmpz_interpolate_fmpz_vec: fmpz_poly_interpolate_fmpz_vec(fmpz_poly_Result,
////                               ((fmpz_poly_struct*)(fmpz_poly_A))->coeffs, ((fmpz_poly_struct*)(fmpz_poly_B))->coeffs, len);
////        break;
//
//
//
//        case mp_poly_derivative: fmpz_poly_derivative(fmpz_poly_Result, fmpz_poly_A); break;
////        case mp_poly_integral: fmpz_poly_integral(fmpz_poly_Result, fmpz_poly_A); break;
//
//        case mp_poly_product_roots: fmpz_poly_product_roots_fmpz_vec(fmpz_poly_Result, fmpz_poly_A->coeffs, len); break;
////        case mp_poly_find_roots: Fmpz_Poly_Find_Roots(fmpz_poly_Result, fmpz_poly_A, len); break;
//
//        case mp_poly_add_series: fmpz_poly_add_series(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B, len); break;
//        case mp_poly_sub_series: fmpz_poly_sub_series(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B, len); break;
//        case mp_poly_mul_series: fmpz_poly_mullow(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B, len); break;
//        case mp_poly_div_series: fmpz_poly_div_series(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B, len); break;
//        case mp_poly_inv_series: fmpz_poly_inv_series(fmpz_poly_Result, fmpz_poly_A, len); break;
//        case mp_poly_revert_series: fmpz_poly_revert_series(fmpz_poly_Result, fmpz_poly_A, len); break;
//        case mp_poly_compose_series: fmpz_poly_compose_series(fmpz_poly_Result, fmpz_poly_A, fmpz_poly_B, len); break;
//
////        case mp_poly_borel_transform: fmpz_poly_borel_transform(fmpz_poly_Result, fmpz_poly_A); break;
////        case mp_poly_inv_borel_transform: fmpz_poly_inv_borel_transform(fmpz_poly_Result, fmpz_poly_A); break;
//
//       }
//       return result;
//}
//
//
//int32_t Lib_FmpzPoly_Func(FmpzPolyPtr fmpz_poly_Result, FmpzPolyPtr fmpz_poly_Result2, int32_t what, int32_t len, FmpzPtr z, FmpzPolyPtr polyA, FmpzPolyPtr polyB)
//{
//    return FmpzPoly_Func( (fmpz_poly_struct*)fmpz_poly_Result, (fmpz_poly_struct*)fmpz_poly_Result2, what, len, z, (fmpz_poly_struct*)polyA, (fmpz_poly_struct*)polyB);
//}
//
//
//
//
//int32_t FmpqPoly_Func(fmpq_poly_t fmpq_poly_Result, fmpq_poly_t fmpq_poly_Result2, int32_t what, int32_t len, FmpqPtr z, fmpq_poly_t fmpq_poly_A, fmpq_poly_t fmpq_poly_B)
//{
//    int32_t result = 0;
//    switch (what) {
//
//        case mp_poly_normalize: _fmpq_poly_normalise(fmpq_poly_A); break;
//        case mp_poly_length: result = fmpq_poly_length(fmpq_poly_A); break;
//        case mp_poly_degree: result = fmpq_poly_degree(fmpq_poly_A); break;
//
//        case mp_poly_set_coeff: fmpq_poly_set_coeff_fmpq(fmpq_poly_Result, len, (fmpq_ptr)z); break;
//        case mp_poly_get_coeff: fmpq_poly_get_coeff_fmpq((fmpq_ptr) fmpq_poly_Result, fmpq_poly_A, len); break;
//
//        case mp_poly_set: fmpq_poly_set(fmpq_poly_Result, fmpq_poly_A); break;
//        case mp_poly_neg: fmpq_poly_neg(fmpq_poly_Result, fmpq_poly_A); break;
//
//        case mp_poly_shift_left: fmpq_poly_shift_left(fmpq_poly_Result, fmpq_poly_A, len); break;
//        case mp_poly_shift_right: fmpq_poly_shift_right(fmpq_poly_Result, fmpq_poly_A, len); break;
//
////        case mp_poly_majorant: fmpq_poly_majorant((fmpq_poly_struct*)  fmpq_poly_Result, fmpq_poly_A); break;
//
//
//        case mp_poly_resize:     fmpq_poly_fit_length(fmpq_poly_A, len + 1);
//                                _fmpq_poly_set_length(fmpq_poly_A, len + 1);  break;
//
//        case mp_poly_truncate: fmpq_poly_truncate(fmpq_poly_A, len); break;
//
//        case mp_poly_scalar_mul: fmpq_poly_scalar_mul_fmpq(fmpq_poly_Result, fmpq_poly_A, (fmpq_ptr)z); break;
//        case mp_poly_scalar_div: fmpq_poly_scalar_div_fmpq(fmpq_poly_Result, fmpq_poly_A, (fmpq_ptr)z); break;
//        case mp_poly_pow_ui: fmpq_poly_pow(fmpq_poly_Result, fmpq_poly_A, len); break;
////        case mp_poly_taylor_shift: fmpq_poly_taylor_shift(fmpq_poly_Result, fmpq_poly_A, (fmpq_ptr)z); break;
//
//        case mp_poly_swap: fmpq_poly_swap(fmpq_poly_A, fmpq_poly_B); break;
//        case mp_poly_equal: result = fmpq_poly_equal(fmpq_poly_A, fmpq_poly_B); break;
//
//
//        case mp_poly_add: fmpq_poly_add(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B); break;
//        case mp_poly_sub: fmpq_poly_sub(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B); break;
//        case mp_poly_mul: fmpq_poly_mul(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B); break;
//        case mp_poly_div: fmpq_poly_divrem(fmpq_poly_Result, fmpq_poly_Result2, fmpq_poly_A, fmpq_poly_B); break;
//        case mp_poly_compose: fmpq_poly_compose(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B); break;
//
//
//        case mp_poly_evaluate: fmpq_poly_evaluate_fmpq((fmpq_ptr) fmpq_poly_Result, fmpq_poly_A, (fmpq_ptr)z); break;
////        case mp_poly_evaluate2: fmpq_poly_evaluate2((fmpq_ptr) fmpq_poly_Result, (fmpq_ptr) fmpq_poly_Result2, fmpq_poly_A, (fmpq_ptr)z); break;
//
//
////        case mp_poly_evaluate_vec_iter: fmpq_poly_evaluate_vec_iter(fmpq_poly_Result->coeffs, fmpq_poly_A, fmpq_poly_B->coeffs, len); break;
////        case mp_poly_evaluate_vec_fast: fmpq_poly_evaluate_vec_fast(fmpq_poly_Result->coeffs, fmpq_poly_A, fmpq_poly_B->coeffs, len); break;
//
//
////        case mp_poly_interpolate_newton: fmpq_poly_interpolate_newton(fmpq_poly_Result, fmpq_poly_A->coeffs, fmpq_poly_B->coeffs, len); break;
////        case mp_poly_interpolate_barycentric: fmpq_poly_interpolate_barycentric(fmpq_poly_Result, fmpq_poly_A->coeffs, fmpq_poly_B->coeffs, len); break;
////        case mp_poly_interpolate_fast: fmpq_poly_interpolate_fast(fmpq_poly_Result, fmpq_poly_A->coeffs, fmpq_poly_B->coeffs, len); break;
//
//        case mp_poly_fmpq_interpolate_fmpz_vec: fmpq_poly_interpolate_fmpz_vec(fmpq_poly_Result,
//                               ((fmpz_poly_struct*)(fmpq_poly_A))->coeffs, ((fmpz_poly_struct*)(fmpq_poly_B))->coeffs, len);
//        break;
//
//
//
//        case mp_poly_derivative: fmpq_poly_derivative(fmpq_poly_Result, fmpq_poly_A); break;
//        case mp_poly_integral: fmpq_poly_integral(fmpq_poly_Result, fmpq_poly_A); break;
//
////        case mp_poly_product_roots: fmpq_poly_product_roots(fmpq_poly_Result, fmpq_poly_A->coeffs, len); break;
////        case mp_poly_find_roots: Fmpq_Poly_Find_Roots(fmpq_poly_Result, fmpq_poly_A, len); break;
//
//        case mp_poly_add_series: fmpq_poly_add_series(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B, len); break;
//        case mp_poly_sub_series: fmpq_poly_sub_series(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B, len); break;
//        case mp_poly_mul_series: fmpq_poly_mullow(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B, len); break;
//        case mp_poly_div_series: fmpq_poly_div_series(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B, len); break;
//        case mp_poly_inv_series: fmpq_poly_inv_series(fmpq_poly_Result, fmpq_poly_A, len); break;
//        case mp_poly_revert_series: fmpq_poly_revert_series(fmpq_poly_Result, fmpq_poly_A, len); break;
//        case mp_poly_compose_series: fmpq_poly_compose_series(fmpq_poly_Result, fmpq_poly_A, fmpq_poly_B, len); break;
//
////        case mp_poly_borel_transform: fmpq_poly_borel_transform(fmpq_poly_Result, fmpq_poly_A); break;
////        case mp_poly_inv_borel_transform: fmpq_poly_inv_borel_transform(fmpq_poly_Result, fmpq_poly_A); break;
//
//       }
//       return result;
//}
//
//int32_t Lib_FmpqPoly_Func(FmpqPolyPtr fmpq_poly_Result, FmpqPolyPtr fmpq_poly_Result2, int32_t what, int32_t len, FmpqPtr z, FmpqPolyPtr polyA, FmpqPolyPtr polyB)
//{
//    return FmpqPoly_Func( (fmpq_poly_struct*)fmpq_poly_Result, (fmpq_poly_struct*)fmpq_poly_Result2, what, len, z, (fmpq_poly_struct*)polyA, (fmpq_poly_struct*)polyB);
//}
//
//
//
//
//int32_t Acb_Poly_Find_Roots( acb_poly_t roots, acb_poly_t poly, int32_t maxiter, int32_t prec)
//{
//    int32_t degree = acb_poly_degree(poly);
//    acb_poly_fit_length(roots, degree);
//    _acb_poly_set_length(roots, degree);
//    int32_t result = 0;
//    if (degree > 0) { result = (int32_t) acb_poly_find_roots( ((roots))->coeffs, poly, NULL, maxiter, prec);}
//    return result;
//}
//
//
//int32_t ArbPoly_Func(arb_poly_t arb_poly_Result, arb_poly_t arb_poly_Result2, int32_t what, int32_t len, ArbPtr z, arb_poly_t arb_poly_A, arb_poly_t arb_poly_B)
//{
//    int32_t prec = mpfr_get_default_prec();
//
//    int32_t result = 0;
//    switch (what) {
//
//        case mp_poly_normalize: _arb_poly_normalise(arb_poly_A); break;
//        case mp_poly_length: result = arb_poly_length(arb_poly_A); break;
//        case mp_poly_degree: result = arb_poly_degree(arb_poly_A); break;
//
//        case mp_poly_set_coeff: arb_poly_set_coeff_arb(arb_poly_Result, len, (arb_ptr)z); break;
//        case mp_poly_get_coeff: arb_poly_get_coeff_arb((arb_ptr) arb_poly_Result, arb_poly_A, len); break;
//
//        case mp_poly_set: arb_poly_set(arb_poly_Result, arb_poly_A); break;
//        case mp_poly_neg: arb_poly_neg(arb_poly_Result, arb_poly_A); break;
//
//        case mp_poly_shift_left: arb_poly_shift_left(arb_poly_Result, arb_poly_A, len); break;
//        case mp_poly_shift_right: arb_poly_shift_right(arb_poly_Result, arb_poly_A, len); break;
//
//        case mp_poly_majorant: arb_poly_majorant((arb_poly_struct*)  arb_poly_Result, arb_poly_A, prec); break;
//
//
//        case mp_poly_resize:     arb_poly_fit_length(arb_poly_A, len + 1);
//                                _arb_poly_set_length(arb_poly_A, len + 1);  break;
//
//        case mp_poly_truncate: arb_poly_truncate(arb_poly_A, len); break;
//
//        case mp_poly_scalar_mul: arb_poly_scalar_mul(arb_poly_Result, arb_poly_A, (arb_ptr)z, prec); break;
//        case mp_poly_scalar_div: arb_poly_scalar_div(arb_poly_Result, arb_poly_A, (arb_ptr)z, prec); break;
//        case mp_poly_pow_ui: arb_poly_pow_ui(arb_poly_Result, arb_poly_A, len, prec); break;
//        case mp_poly_taylor_shift: arb_poly_taylor_shift(arb_poly_Result, arb_poly_A, (arb_ptr)z, prec); break;
//
//        case mp_poly_swap: arb_poly_swap(arb_poly_A, arb_poly_B); break;
//        case mp_poly_equal: result = arb_poly_equal(arb_poly_A, arb_poly_B); break;
//
//
//        case mp_poly_add: arb_poly_add(arb_poly_Result, arb_poly_A, arb_poly_B, prec); break;
//        case mp_poly_sub: arb_poly_sub(arb_poly_Result, arb_poly_A, arb_poly_B, prec); break;
//        case mp_poly_mul: arb_poly_mul(arb_poly_Result, arb_poly_A, arb_poly_B, prec); break;
//        case mp_poly_div: arb_poly_divrem(arb_poly_Result, arb_poly_Result2, arb_poly_A, arb_poly_B, prec); break;
//        case mp_poly_compose: arb_poly_compose(arb_poly_Result, arb_poly_A, arb_poly_B, prec); break;
//
//
//        case mp_poly_evaluate: arb_poly_evaluate((arb_ptr) arb_poly_Result, arb_poly_A, (arb_ptr)z, prec); break;
//        case mp_poly_evaluate2: arb_poly_evaluate2((arb_ptr) arb_poly_Result, (arb_ptr) arb_poly_Result2, arb_poly_A, (arb_ptr)z, prec); break;
//
//
//        case mp_poly_evaluate_vec_iter: arb_poly_evaluate_vec_iter(arb_poly_Result->coeffs, arb_poly_A, arb_poly_B->coeffs, len, prec); break;
//        case mp_poly_evaluate_vec_fast: arb_poly_evaluate_vec_fast(arb_poly_Result->coeffs, arb_poly_A, arb_poly_B->coeffs, len, prec); break;
//
//
//        case mp_poly_interpolate_newton: arb_poly_interpolate_newton(arb_poly_Result, arb_poly_A->coeffs, arb_poly_B->coeffs, len, prec); break;
//        case mp_poly_interpolate_barycentric: arb_poly_interpolate_barycentric(arb_poly_Result, arb_poly_A->coeffs, arb_poly_B->coeffs, len, prec); break;
//        case mp_poly_interpolate_fast: arb_poly_interpolate_fast(arb_poly_Result, arb_poly_A->coeffs, arb_poly_B->coeffs, len, prec); break;
//
//
//        case mp_poly_derivative: arb_poly_derivative(arb_poly_Result, arb_poly_A, prec); break;
//        case mp_poly_integral: arb_poly_integral(arb_poly_Result, arb_poly_A, prec); break;
//
//        case mp_poly_product_roots: arb_poly_product_roots(arb_poly_Result, arb_poly_A->coeffs, len, prec); break;
////        case mp_poly_find_roots: Arb_Poly_Find_Roots(arb_poly_Result, arb_poly_A, len, prec); break;
//
//        case mp_poly_add_series: arb_poly_add_series(arb_poly_Result, arb_poly_A, arb_poly_B, len, prec); break;
//        case mp_poly_sub_series: arb_poly_sub_series(arb_poly_Result, arb_poly_A, arb_poly_B, len, prec); break;
//        case mp_poly_mul_series: arb_poly_mullow(arb_poly_Result, arb_poly_A, arb_poly_B, len, prec); break;
//        case mp_poly_div_series: arb_poly_div_series(arb_poly_Result, arb_poly_A, arb_poly_B, len, prec); break;
//        case mp_poly_inv_series: arb_poly_inv_series(arb_poly_Result, arb_poly_A, len, prec); break;
//        case mp_poly_revert_series: arb_poly_revert_series(arb_poly_Result, arb_poly_A, len, prec); break;
//        case mp_poly_compose_series: arb_poly_compose_series(arb_poly_Result, arb_poly_A, arb_poly_B, len, prec); break;
//
//        case mp_poly_borel_transform: arb_poly_borel_transform(arb_poly_Result, arb_poly_A, prec); break;
//        case mp_poly_inv_borel_transform: arb_poly_inv_borel_transform(arb_poly_Result, arb_poly_A, prec); break;
//
//       }
//       return result;
//}
//
//
//int32_t Lib_ArbPoly_Func(ArbPolyPtr arb_poly_Result, ArbPolyPtr arb_poly_Result2, int32_t what, int32_t len, ArbPtr z, ArbPolyPtr polyA, ArbPolyPtr polyB)
//{
//    return ArbPoly_Func( (arb_poly_struct*)arb_poly_Result, (arb_poly_struct*)arb_poly_Result2, what, len, z, (arb_poly_struct*)polyA, (arb_poly_struct*)polyB);
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
////
////int32_t Lib_ArbPoly2_Func(ArbPoly2Ptr arb_poly2_Result, ArbPoly2Ptr arb_poly2_Result2, int32_t what, int32_t len, ArbPtr z, ArbPoly2Ptr poly2A, ArbPoly2Ptr poly2B)
////{
////	arb_poly_t arb_poly_Result;  arb_poly_init(arb_poly_Result);
////	arb_poly_t arb_poly_Result2; arb_poly_init(arb_poly_Result2);
////	arb_poly_t polyA; arb_poly_init(polyA);
////	arb_poly_t polyB; arb_poly_init(polyB);
////
////	if (poly2A != NULL)
////	{
////		Lib_ArbPoly_From_ArbMatrix(polyA, poly2A);
////	}
////
////	if (poly2B != NULL)
////	{
////		Lib_ArbPoly_From_ArbMatrix(polyB, poly2B);
////	}
////
////	if ((what == mp_poly_evaluate_vec_iter) || (what == mp_poly_evaluate_vec_fast))
////	{
////		Lib_ArbPoly_From_ArbMatrix(arb_poly_Result, arb_poly2_Result);
////	}
////
////	int result = 0;
////	if ((what != mp_poly_evaluate) && (what != mp_poly_evaluate2))
////	{
////		result = ArbPoly_Func((arb_poly_struct*)arb_poly_Result, (arb_poly_struct*)arb_poly_Result2, what, len, z, (arb_poly_struct*)polyA, (arb_poly_struct*)polyB);
////
////		if (arb_poly2_Result != NULL)
////		{
////			Lib_ArbMatrix_From_ArbPoly(arb_poly2_Result, arb_poly_Result);
////		}
////
////		if (arb_poly2_Result2 != NULL)
////		{
////			Lib_ArbMatrix_From_ArbPoly(arb_poly2_Result2, arb_poly_Result2);
////		}
////	}
////	else
////	{
////		result = ArbPoly_Func((arb_poly_struct*)arb_poly2_Result, (arb_poly_struct*)arb_poly2_Result2, what, len, z, (arb_poly_struct*)polyA, (arb_poly_struct*)polyB);
////	}
////
////	arb_poly_clear(arb_poly_Result);
////	arb_poly_clear(arb_poly_Result2);
////	arb_poly_clear(polyA);
////	arb_poly_clear(polyB);
////
////	return result;
////}
////
//
//
//
//
//int32_t AcbPoly_Func(acb_poly_t acb_poly_Result, acb_poly_t acb_poly_Result2, int32_t what, int32_t len, AcbPtr z, acb_poly_t acb_poly_A, acb_poly_t acb_poly_B)
//{
//    int32_t prec = mpfr_get_default_prec();
//
//    int32_t result = 0;
//    switch (what) {
//
//        case mp_poly_normalize: _acb_poly_normalise(acb_poly_A); break;
//        case mp_poly_length: result = acb_poly_length(acb_poly_A); break;
//        case mp_poly_degree: result = acb_poly_degree(acb_poly_A); break;
//
//        case mp_poly_set_coeff: acb_poly_set_coeff_acb(acb_poly_Result, len, (acb_ptr)z); break;
//        case mp_poly_get_coeff: acb_poly_get_coeff_acb((acb_ptr) acb_poly_Result, acb_poly_A, len); break;
//
//        case mp_poly_set: acb_poly_set(acb_poly_Result, acb_poly_A); break;
//        case mp_poly_neg: acb_poly_neg(acb_poly_Result, acb_poly_A); break;
//
//        case mp_poly_shift_left: acb_poly_shift_left(acb_poly_Result, acb_poly_A, len); break;
//        case mp_poly_shift_right: acb_poly_shift_right(acb_poly_Result, acb_poly_A, len); break;
//
//        case mp_poly_majorant: acb_poly_majorant((arb_poly_struct*)  acb_poly_Result, acb_poly_A, prec); break;
//
//
//        case mp_poly_resize:     acb_poly_fit_length(acb_poly_A, len + 1);
//                                _acb_poly_set_length(acb_poly_A, len + 1);  break;
//
//        case mp_poly_truncate: acb_poly_truncate(acb_poly_A, len); break;
//
//        case mp_poly_scalar_mul: acb_poly_scalar_mul(acb_poly_Result, acb_poly_A, (acb_ptr)z, prec); break;
//        case mp_poly_scalar_div: acb_poly_scalar_div(acb_poly_Result, acb_poly_A, (acb_ptr)z, prec); break;
//        case mp_poly_pow_ui: acb_poly_pow_ui(acb_poly_Result, acb_poly_A, len, prec); break;
//        case mp_poly_taylor_shift: acb_poly_taylor_shift(acb_poly_Result, acb_poly_A, (acb_ptr)z, prec); break;
//
//        case mp_poly_swap: acb_poly_swap(acb_poly_A, acb_poly_B); break;
//        case mp_poly_equal: result = acb_poly_equal(acb_poly_A, acb_poly_B); break;
//
//
//        case mp_poly_add: acb_poly_add(acb_poly_Result, acb_poly_A, acb_poly_B, prec); break;
//        case mp_poly_sub: acb_poly_sub(acb_poly_Result, acb_poly_A, acb_poly_B, prec); break;
//        case mp_poly_mul: acb_poly_mul(acb_poly_Result, acb_poly_A, acb_poly_B, prec); break;
//        case mp_poly_div: acb_poly_divrem(acb_poly_Result, acb_poly_Result2, acb_poly_A, acb_poly_B, prec); break;
//        case mp_poly_compose: acb_poly_compose(acb_poly_Result, acb_poly_A, acb_poly_B, prec); break;
//
//
//        case mp_poly_evaluate: acb_poly_evaluate((acb_ptr) acb_poly_Result, acb_poly_A, (acb_ptr)z, prec); break;
//        case mp_poly_evaluate2: acb_poly_evaluate2((acb_ptr) acb_poly_Result, (acb_ptr) acb_poly_Result2, acb_poly_A, (acb_ptr)z, prec); break;
//
//
//        case mp_poly_evaluate_vec_iter: acb_poly_evaluate_vec_iter(acb_poly_Result->coeffs, acb_poly_A, acb_poly_B->coeffs, len, prec); break;
//        case mp_poly_evaluate_vec_fast: acb_poly_evaluate_vec_fast(acb_poly_Result->coeffs, acb_poly_A, acb_poly_B->coeffs, len, prec); break;
//
//
//        case mp_poly_interpolate_newton: acb_poly_interpolate_newton(acb_poly_Result, acb_poly_A->coeffs, acb_poly_B->coeffs, len, prec); break;
//        case mp_poly_interpolate_barycentric: acb_poly_interpolate_barycentric(acb_poly_Result, acb_poly_A->coeffs, acb_poly_B->coeffs, len, prec); break;
//        case mp_poly_interpolate_fast: acb_poly_interpolate_fast(acb_poly_Result, acb_poly_A->coeffs, acb_poly_B->coeffs, len, prec); break;
//
//
//        case mp_poly_derivative: acb_poly_derivative(acb_poly_Result, acb_poly_A, prec); break;
//        case mp_poly_integral: acb_poly_integral(acb_poly_Result, acb_poly_A, prec); break;
//
//        case mp_poly_product_roots: acb_poly_product_roots(acb_poly_Result, acb_poly_A->coeffs, len, prec); break;
//        case mp_poly_find_roots: Acb_Poly_Find_Roots(acb_poly_Result, acb_poly_A, len, prec); break;
//
//        case mp_poly_add_series: acb_poly_add_series(acb_poly_Result, acb_poly_A, acb_poly_B, len, prec); break;
//        case mp_poly_sub_series: acb_poly_sub_series(acb_poly_Result, acb_poly_A, acb_poly_B, len, prec); break;
//        case mp_poly_mul_series: acb_poly_mullow(acb_poly_Result, acb_poly_A, acb_poly_B, len, prec); break;
//        case mp_poly_div_series: acb_poly_div_series(acb_poly_Result, acb_poly_A, acb_poly_B, len, prec); break;
//        case mp_poly_inv_series: acb_poly_inv_series(acb_poly_Result, acb_poly_A, len, prec); break;
//        case mp_poly_revert_series: acb_poly_revert_series(acb_poly_Result, acb_poly_A, len, prec); break;
//        case mp_poly_compose_series: acb_poly_compose_series(acb_poly_Result, acb_poly_A, acb_poly_B, len, prec); break;
//
//        case mp_poly_borel_transform: acb_poly_borel_transform(acb_poly_Result, acb_poly_A, prec); break;
//        case mp_poly_inv_borel_transform: acb_poly_inv_borel_transform(acb_poly_Result, acb_poly_A, prec); break;
//
//       }
//       return result;
//}
//
//int32_t Lib_AcbPoly_Func(AcbPolyPtr acb_poly_Result, AcbPolyPtr acb_poly_Result2, int32_t what, int32_t len, AcbPtr z, AcbPolyPtr polyA, AcbPolyPtr polyB)
//{
//    return AcbPoly_Func( (acb_poly_struct*)acb_poly_Result, (acb_poly_struct*)acb_poly_Result2, what, len, z, (acb_poly_struct*)polyA, (acb_poly_struct*)polyB);
//}
//
//
//
//
//
//
////int32_t Lib_AcbPoly2_Func(AcbPoly2Ptr acb_poly2_Result, AcbPoly2Ptr acb_poly2_Result2, int32_t what, int32_t len, AcbPtr z, AcbPoly2Ptr poly2A, AcbPoly2Ptr poly2B)
////{
////	acb_poly_t acb_poly_Result;  acb_poly_init(acb_poly_Result);
////	acb_poly_t acb_poly_Result2; acb_poly_init(acb_poly_Result2);
////	acb_poly_t polyA; acb_poly_init(polyA);
////	acb_poly_t polyB; acb_poly_init(polyB);
////
////	if (poly2A != NULL)
////	{
////		Lib_AcbPoly_From_AcbMatrix(polyA, poly2A);
////	}
////
////	if (poly2B != NULL)
////	{
////		Lib_AcbPoly_From_AcbMatrix(polyB, poly2B);
////	}
////
////	if ((what == mp_poly_evaluate_vec_iter) || (what == mp_poly_evaluate_vec_fast))
////	{
////		Lib_AcbPoly_From_AcbMatrix(acb_poly_Result, acb_poly2_Result);
////	}
////
////	int result = 0;
////	if ((what != mp_poly_evaluate) && (what != mp_poly_evaluate2))
////	{
////		result = AcbPoly_Func((acb_poly_struct*)acb_poly_Result, (acb_poly_struct*)acb_poly_Result2, what, len, z, (acb_poly_struct*)polyA, (acb_poly_struct*)polyB);
////
////		if (acb_poly2_Result != NULL)
////		{
////			Lib_AcbMatrix_From_AcbPoly(acb_poly2_Result, acb_poly_Result);
////		}
////
////		if (acb_poly2_Result2 != NULL)
////		{
////			Lib_AcbMatrix_From_AcbPoly(acb_poly2_Result2, acb_poly_Result2);
////		}
////	}
////	else
////	{
////		result = AcbPoly_Func((acb_poly_struct*)acb_poly2_Result, (acb_poly_struct*)acb_poly2_Result2, what, len, z, (acb_poly_struct*)polyA, (acb_poly_struct*)polyB);
////	}
////
////	acb_poly_clear(acb_poly_Result);
////	acb_poly_clear(acb_poly_Result2);
////	acb_poly_clear(polyA);
////	acb_poly_clear(polyB);
////
////	return result;
////}
//
//
//
//
//
////}
//
//
//
//
//
//
//
///***************************** Acb: Power Series *******************************************/
////{
//
//
//void Acb_Series_Cplxfunc1(acb_poly_t out1, long what, slong wp, slong n, acb_poly_t in1)
//{
//    switch (what) {
//        case mp_cplxfunc1_exp: acb_poly_exp_series(out1, in1, n, wp); break;
////            case mp_cplxfunc1_expm1: acb_poly_expm1_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_log: acb_poly_log_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_log1p: acb_poly_log1p_series(out1, in1, n, wp); break;
//
//        case mp_cplxfunc1_sqrt: acb_poly_sqrt_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_rsqrt: acb_poly_rsqrt_series(out1, in1, n, wp); break;
////            case mp_cplxfunc1_cbrt: acb_poly_cbrt_series(out1, in1, n, wp); break;
//
//        case mp_cplxfunc1_sin: acb_poly_sin_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_cos: acb_poly_cos_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_tan: acb_poly_tan_series(out1, in1, n, wp); break;
////            case mp_cplxfunc1_cot: acb_poly_cot_series(out1, in1, n, wp); break;
//
//
//        case mp_cplxfunc1_sinpi: acb_poly_sin_pi_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_cospi: acb_poly_cos_pi_series(out1, in1, n, wp); break;
////            case mp_cplxfunc1_tanpi: acb_poly_tan_pi_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_cotpi: acb_poly_cot_pi_series(out1, in1, n, wp); break;
//
////        case mp_cplxfunc1_asin: acb_poly_asin_series(out1, in1, n, wp); break;
////        case mp_cplxfunc1_acos: acb_poly_acos_series(out1, in1, n, wp); break;
////        case mp_cplxfunc1_atan: acb_poly_atan_series(out1, in1, n, wp); break;
//
//
//        case mp_cplxfunc1_sinh: acb_poly_sinh_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_cosh: acb_poly_cosh_series(out1, in1, n, wp); break;
////            case mp_cplxfunc1_tanh: acb_poly_tanh_series(out1, in1, n, wp); break;
////            case mp_cplxfunc1_coth: acb_poly_coth_series(out1, in1, n, wp); break;
//
//
////            case mp_cplxfunc1_asinh: acb_poly_asinh_series(out1, in1, n, wp); break;
////            case mp_cplxfunc1_acosh: acb_poly_acosh_series(out1, in1, n, wp); break;
////            case mp_cplxfunc1_atanh: acb_poly_atanh_series(out1, in1, n, wp); break;
//
//        case mp_cplxfunc1_gamma: acb_poly_gamma_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_rgamma: acb_poly_rgamma_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_lgamma: acb_poly_lgamma_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_digamma: acb_poly_digamma_series(out1, in1, n, wp); break;
//        case mp_cplxfunc1_zeta:
//            acb_t a; acb_init(a); acb_set_si(a, 1);
//            acb_poly_zeta_series(out1, in1, a, 0, n, wp);
//            acb_clear(a);
//            break;
//
//
//        case mp_cplxfunc1_erf: acb_hypgeom_erf_series(out1, in1, n, wp) ; break;
//        case mp_cplxfunc1_erfc: acb_hypgeom_erfc_series(out1, in1, n, wp) ; break;
//        case mp_cplxfunc1_erfi: acb_hypgeom_erfi_series(out1, in1, n, wp) ; break;
//
//        case mp_cplxfunc1_ei: acb_hypgeom_ei_series(out1, in1, n, wp) ; break;
//        case mp_cplxfunc1_si: acb_hypgeom_si_series(out1, in1, n, wp) ; break;
//        case mp_cplxfunc1_ci: acb_hypgeom_ci_series(out1, in1, n, wp) ; break;
//
//        case mp_cplxfunc1_shi: acb_hypgeom_shi_series(out1, in1, n, wp) ; break;
//        case mp_cplxfunc1_chi: acb_hypgeom_chi_series(out1, in1, n, wp) ; break;
//        case mp_cplxfunc1_li: acb_hypgeom_li_series(out1, in1, 0, n, wp) ; break;
//        case mp_cplxfunc1_lioffset: acb_hypgeom_li_series(out1, in1, 1, n, wp) ; break;
//
//        case mp_cplxfunc1_ai: acb_hypgeom_airy_series(out1, NULL, NULL, NULL, in1, n, wp) ; break;
//        case mp_cplxfunc1_aiprime: acb_hypgeom_airy_series(NULL, out1, NULL, NULL, in1, n, wp) ; break;
//        case mp_cplxfunc1_bi: acb_hypgeom_airy_series(NULL, NULL, out1, NULL, in1, n, wp) ; break;
//        case mp_cplxfunc1_biprime: acb_hypgeom_airy_series(NULL, NULL, NULL, out1, in1, n, wp) ; break;
//
//        case mp_cplxfunc1_fresnelc: acb_hypgeom_fresnel_series(out1, NULL, in1, 0, n, wp); break;
//        case mp_cplxfunc1_fresnels: acb_hypgeom_fresnel_series(NULL, out1, in1, 0, n, wp) ; break;
//
//        case mp_cplxfunc1_agm1: acb_poly_agm1_series(out1, in1, n, wp) ; break;
//        case mp_cplxfunc1_ellipk: acb_poly_elliptic_k_series(out1, in1, n, wp) ; break;
//
//
////acb_poly_riemann_siegel_theta_series
////acb_poly_riemann_siegel_z_series
//
//
//
//        }
//}
//
//
//void Lib_Acb_Series_Cplxfunc1(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1)
//{
//    Acb_Series_Cplxfunc1((acb_poly_struct*) out1, what, wp, n, (acb_poly_struct*) in1);
//}
//
//
//
//
//
//
//
//
//void Acb_Series_Cplxfunc1_Out2(acb_poly_t out1, acb_poly_t out2, long what, slong wp, slong n, acb_poly_t in1)
//{
//    switch (what) {
//
//        case mp_cplxfunc1_2_sin_cos: acb_poly_sin_cos_series(out1, out2, in1, n, wp); break;
//        case mp_cplxfunc1_2_sin_cos_pi: acb_poly_sin_cos_pi_series(out1, out2, in1, n, wp); break;
//        case mp_cplxfunc1_2_sinh_cosh: acb_poly_sinh_cosh_series(out1, out2, in1, n, wp); break;
//
//    }
//}
//
//
//void Lib_Acb_Series_Cplxfunc1_Out2(AcbPtr out1, AcbPtr out2, int32_t what, int32_t wp, int32_t n, AcbPtr in1)
//{
//    Acb_Series_Cplxfunc1_Out2((acb_poly_struct*) out1, (acb_poly_struct*) out2, what, wp, n, (acb_poly_struct*) in1);
//}
//
//
//
//
//void Acb_Series_Cplxfunc2(acb_poly_t out1, long what, slong wp, int32_t n, acb_poly_t in1, acb_poly_t in2)
//{
//        switch (what) {
//
//            case mp_cplxfunc2_pow: acb_poly_pow_series(out1, in1, in2, n, wp) ; break;     // add pow_ui  and square
//
//        }
//}
//
//
//void Lib_Acb_Series_Cplxfunc2(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1, AcbPtr in2)
//{
//    Acb_Series_Cplxfunc2((acb_poly_struct*) out1, what, wp, n, (acb_poly_struct*) in1, (acb_poly_struct*) in2);
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
//void Acb_Series_Cplxfunc2_ui(acb_poly_t out1, long what, slong wp, int32_t n, acb_poly_t in1, int32_t in2)
//{
//    switch (what) {
//
////        case mp_cplxfunc2_pow_ui: acb_poly_pow_ui(out1, in1, in2, wp) ; break;     // needs truncation
//        case mp_cplxfunc2_rising2_ui: acb_poly_rising_ui_series(out1, in1, in2, n, wp) ; break;     // needs truncation
//        case mp_cplxfunc2_lambertw_ui:
//            fmpz_t k; fmpz_init(k);
//            fmpz_set_si(k, in2);
//            acb_poly_lambertw_series(out1, in1, k, 0, n, wp);
//            fmpz_clear(k);
//            break;
//             //  move to cplxfunc1, all other cases complex as lambertw_k
//    }
//}
//
//
//void Lib_Acb_Series_Cplxfunc2_ui(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1, int32_t in2)
//{
//    Acb_Series_Cplxfunc2_ui((acb_poly_struct*) out1, what, wp, n, (acb_poly_struct*) in1, in2);
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
//void Acb_Series_Cplxfunc2_Acb(acb_poly_t out1, long what, slong wp, int32_t n, acb_poly_t in1, acb_t in2)
//{
//    switch (what) {
//
//        case mp_cplxfunc2_pow: acb_poly_pow_acb_series(out1, in1, in2, n, wp) ; break;     // add square
//
//        case mp_cplxfunc2_hurwitz_zeta: acb_poly_zeta_series(out1, in1, in2, 0, n, wp) ; break;
//
//        case mp_cplxfunc2_polylog: acb_poly_polylog_series(out1, in1, in2, n, wp) ; break;
//
//        case mp_cplxfunc2_elliptic_p: acb_poly_elliptic_p_series(out1, in1, in2, n, wp) ; break;
//
//
//        case mp_cplxfunc2_theta1: acb_modular_theta_series(out1, NULL, NULL, NULL, in1, in2, n, wp) ; break;
//        case mp_cplxfunc2_theta2: acb_modular_theta_series(NULL, out1, NULL, NULL, in1, in2, n, wp) ; break;
//        case mp_cplxfunc2_theta3: acb_modular_theta_series(NULL, NULL, out1, NULL, in1, in2, n, wp) ; break;
//        case mp_cplxfunc2_theta4: acb_modular_theta_series(NULL, NULL, NULL, out1, in1, in2, n, wp) ; break;
//
//        case mp_cplxfunc2_gamma_upper: acb_hypgeom_gamma_upper_series(out1, in2, in1, 0, n, wp) ; break;     // switch in1 and in2
//        case mp_cplxfunc2_gamma_upper_r: acb_hypgeom_gamma_upper_series(out1, in2, in1, 1, n, wp) ; break;     // switch in1 and in2
//        case mp_cplxfunc2_gamma_lower: acb_hypgeom_gamma_lower_series(out1, in2, in1, 0, n, wp) ; break;     // switch in1 and in2
//        case mp_cplxfunc2_gamma_lower_r: acb_hypgeom_gamma_lower_series(out1, in2, in1, 1, n, wp) ; break;     // switch in1 and in2
//
//    }
//}
//
//
//
//void Lib_Acb_Series_Cplxfunc2_Acb(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1, AcbPtr in2)
//{
//    Acb_Series_Cplxfunc2_Acb((acb_poly_struct*) out1, what, wp, n, (acb_poly_struct*) in1, (acb_ptr) in2);
//}
//
//
//
//
//
//void Acb_Series_Cplxfunc3(acb_poly_t out1, long what, slong wp, int32_t n, acb_t in1, acb_t in2, acb_poly_t in3)
//{
//    if (what >= mp_realfunc_limit)
//    {
//    }
//    else
//    {
//        switch (what) {
//            case mp_cplxfunc3_beta_lower: acb_hypgeom_beta_lower_series(out1, in1, in2, in3, 0, n, wp) ; break;
//            case mp_cplxfunc3_beta_lower_r: acb_hypgeom_beta_lower_series(out1, in1, in2, in3, 1, n, wp) ; break;
//
//            case mp_cplxfunc3_coulomb_f: acb_hypgeom_coulomb_series(out1, NULL, NULL, NULL, in1, in2, in3, n, wp) ; break;
//            case mp_cplxfunc3_coulomb_g: acb_hypgeom_coulomb_series(NULL, out1, NULL, NULL, in1, in2, in3, n, wp) ; break;
//            case mp_cplxfunc3_coulomb_hpos: acb_hypgeom_coulomb_series(NULL, NULL, out1, NULL, in1, in2, in3, n, wp) ; break;
//            case mp_cplxfunc3_coulomb_hneg: acb_hypgeom_coulomb_series(NULL, NULL, NULL, out1, in1, in2, in3, n, wp) ; break;
//
//        }
//    }
//}
//
//
//void Lib_Acb_Series_Cplxfunc3(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1, AcbPtr in2, AcbPtr in3)
//{
//    Acb_Series_Cplxfunc3((acb_poly_struct*) out1, what, wp, n, (acb_ptr) in1, (acb_ptr) in2, (acb_poly_struct*) in3);
//}
//
//
//
//
////}
//
//
//
//
//
//
///**************************** Arb: Power Series ********************************************/
////{
//
//
//void Arb_Series_Realfunc1(arb_poly_t out1, long what, slong wp, slong n, arb_poly_t in1)
//{
//    if (what >= mp_realfunc_limit)
//    {
////        arb_t out_imag, zero;
////        arb_init(out_imag); arb_init(zero);
////        Arb_Cplxfunc1(out1, out_imag, what, wp, in1, zero);
////        arb_clear(out_imag);
////        arb_clear(zero);
//    }
//    else
//    {
//        switch (what) {
//            case mp_realfunc1_exp: arb_poly_exp_series(out1, in1, n, wp); break;
////            case mp_realfunc1_expm1: arb_poly_expm1_series(out1, in1, n, wp); break;
//            case mp_realfunc1_log: arb_poly_log_series(out1, in1, n, wp); break;
//            case mp_realfunc1_log1p: arb_poly_log1p_series(out1, in1, n, wp); break;
//
//            case mp_realfunc1_sqrt: arb_poly_sqrt_series(out1, in1, n, wp); break;
//            case mp_realfunc1_rsqrt: arb_poly_rsqrt_series(out1, in1, n, wp); break;
////            case mp_realfunc1_cbrt: arb_poly_cbrt_series(out1, in1, n, wp); break;
//
//            case mp_realfunc1_sin: arb_poly_sin_series(out1, in1, n, wp); break;
//            case mp_realfunc1_cos: arb_poly_cos_series(out1, in1, n, wp); break;
//            case mp_realfunc1_tan: arb_poly_tan_series(out1, in1, n, wp); break;
////            case mp_realfunc1_cot: arb_poly_cot_series(out1, in1, n, wp); break;
//
//
//            case mp_realfunc1_sinpi: arb_poly_sin_pi_series(out1, in1, n, wp); break;
//            case mp_realfunc1_cospi: arb_poly_cos_pi_series(out1, in1, n, wp); break;
////            case mp_realfunc1_tanpi: arb_poly_tan_pi_series(out1, in1, n, wp); break;
//            case mp_realfunc1_cotpi: arb_poly_cot_pi_series(out1, in1, n, wp); break;
//
//            case mp_realfunc1_asin: arb_poly_asin_series(out1, in1, n, wp); break;
//            case mp_realfunc1_acos: arb_poly_acos_series(out1, in1, n, wp); break;
//            case mp_realfunc1_atan: arb_poly_atan_series(out1, in1, n, wp); break;
//
//
//            case mp_realfunc1_sinh: arb_poly_sinh_series(out1, in1, n, wp); break;
//            case mp_realfunc1_cosh: arb_poly_cosh_series(out1, in1, n, wp); break;
////            case mp_realfunc1_tanh: arb_poly_tanh_series(out1, in1, n, wp); break;
////            case mp_realfunc1_coth: arb_poly_coth_series(out1, in1, n, wp); break;
//
//
////            case mp_realfunc1_asinh: arb_poly_asinh_series(out1, in1, n, wp); break;
////            case mp_realfunc1_acosh: arb_poly_acosh_series(out1, in1, n, wp); break;
////            case mp_realfunc1_atanh: arb_poly_atanh_series(out1, in1, n, wp); break;
//
//            case mp_realfunc1_gamma: arb_poly_gamma_series(out1, in1, n, wp); break;
//            case mp_realfunc1_rgamma: arb_poly_rgamma_series(out1, in1, n, wp); break;
//            case mp_realfunc1_lgamma: arb_poly_lgamma_series(out1, in1, n, wp); break;
//            case mp_realfunc1_digamma: arb_poly_digamma_series(out1, in1, n, wp); break;
//            case mp_realfunc1_zeta:
//                arb_t a; arb_init(a); arb_set_si(a, 1);
//                arb_poly_zeta_series(out1, in1, a, 0, n, wp);
//                arb_clear(a);
//                break;
//
//
//            case mp_realfunc1_erf: arb_hypgeom_erf_series(out1, in1, n, wp) ; break;
//            case mp_realfunc1_erfc: arb_hypgeom_erfc_series(out1, in1, n, wp) ; break;
//            case mp_realfunc1_erfi: arb_hypgeom_erfi_series(out1, in1, n, wp) ; break;
//
//            case mp_realfunc1_ei: arb_hypgeom_ei_series(out1, in1, n, wp) ; break;
//            case mp_realfunc1_si: arb_hypgeom_si_series(out1, in1, n, wp) ; break;
//            case mp_realfunc1_ci: arb_hypgeom_ci_series(out1, in1, n, wp) ; break;
//
//            case mp_realfunc1_shi: arb_hypgeom_shi_series(out1, in1, n, wp) ; break;
//            case mp_realfunc1_chi: arb_hypgeom_chi_series(out1, in1, n, wp) ; break;
//            case mp_realfunc1_li: arb_hypgeom_li_series(out1, in1, 0, n, wp) ; break;
//            case mp_realfunc1_lioffset: arb_hypgeom_li_series(out1, in1, 1, n, wp) ; break;
//
//            case mp_realfunc1_ai: arb_hypgeom_airy_series(out1, NULL, NULL, NULL, in1, n, wp) ; break;
//            case mp_realfunc1_aiprime: arb_hypgeom_airy_series(NULL, out1, NULL, NULL, in1, n, wp) ; break;
//            case mp_realfunc1_bi: arb_hypgeom_airy_series(NULL, NULL, out1, NULL, in1, n, wp) ; break;
//            case mp_realfunc1_biprime: arb_hypgeom_airy_series(NULL, NULL, NULL, out1, in1, n, wp) ; break;
//
//            case mp_realfunc1_fresnelc: arb_hypgeom_fresnel_series(out1, NULL, in1, 0, n, wp); break;
//            case mp_realfunc1_fresnels: arb_hypgeom_fresnel_series(NULL, out1, in1, 0, n, wp) ; break;
//
//
//
//        }
//    }
//}
//
//
//void Lib_Arb_Series_Realfunc1(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1)
//{
//    Arb_Series_Realfunc1((arb_poly_struct*) out1, what, wp, n, (arb_poly_struct*) in1);
//}
//
//
//
//
//void Arb_Series_Realfunc1_Out2(arb_poly_t out1, arb_poly_t out2, long what, slong wp, slong n, arb_poly_t in1)
//{
//    switch (what) {
//
//        case mp_realfunc1_2_sin_cos: arb_poly_sin_cos_series(out1, out2, in1, n, wp); break;
//        case mp_realfunc1_2_sin_cos_pi: arb_poly_sin_cos_pi_series(out1, out2, in1, n, wp); break;
//        case mp_realfunc1_2_sinh_cosh: arb_poly_sinh_cosh_series(out1, out2, in1, n, wp); break;
//
//        // fresnel
//    }
//}
//
//
//void Lib_Arb_Series_Realfunc1_Out2(ArbPtr out1, ArbPtr out2, int32_t what, int32_t wp, int32_t n, ArbPtr in1)
//{
//    Arb_Series_Realfunc1_Out2((arb_poly_struct*) out1, (arb_poly_struct*) out2, what, wp, n, (arb_poly_struct*) in1);
//}
//
//
//
//
//void Arb_Series_Realfunc2(arb_poly_t out1, long what, slong wp, int32_t n, arb_poly_t in1, arb_t in2)
//{
//    if (what >= mp_realfunc_limit)
//    {
//    }
//    else
//    {
//        switch (what) {
//
//            case mp_realfunc2_hurwitz_zeta: arb_poly_zeta_series(out1, in1, in2, 0, n, wp) ; break;
//
//            case mp_realfunc2_pow: arb_poly_pow_arb_series(out1, in1, in2, n, wp) ; break;     // add square
//
//            case mp_realfunc2_lambertw: arb_poly_lambertw_series(out1, in1, 0, n, wp);  break;  //  move to realfunc1, all other cases complex as lambertw_k
//            case mp_realfunc1_expx2m1: arb_poly_lambertw_series(out1, in1, 1, n, wp);  break;  //  move to realfunc1, all other cases complex as lambertw_k
//
//            case mp_realfunc2_gamma_upper: arb_hypgeom_gamma_upper_series(out1, in2, in1, 0, n, wp) ; break;
//            case mp_realfunc2_gamma_upper_r: arb_hypgeom_gamma_upper_series(out1, in2, in1, 1, n, wp) ; break;
//            case mp_realfunc2_gamma_lower: arb_hypgeom_gamma_lower_series(out1, in2, in1, 0, n, wp) ; break;
//            case mp_realfunc2_gamma_lower_r: arb_hypgeom_gamma_lower_series(out1, in2, in1, 1, n, wp) ; break;
//
//        }
//    }
//}
//
//
//void Lib_Arb_Series_Realfunc2(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1, ArbPtr in2)
//{
//    Arb_Series_Realfunc2((arb_poly_struct*) out1, what, wp, n, (arb_poly_struct*) in1, (arb_ptr) in2);
//}
//
//
//
//
//void Arb_Series_Realfunc3(arb_poly_t out1, long what, slong wp, int32_t n, arb_t in1, arb_t in2, arb_poly_t in3)
//{
//    if (what >= mp_realfunc_limit)
//    {
//    }
//    else
//    {
//        switch (what) {
//            case mp_realfunc3_beta_lower: arb_hypgeom_beta_lower_series(out1, in1, in2, in3, 0, n, wp) ; break;
//            case mp_realfunc3_beta_lower_r: arb_hypgeom_beta_lower_series(out1, in1, in2, in3, 1, n, wp) ; break;
//
//            case mp_realfunc3_coulomb_f: arb_hypgeom_coulomb_series(out1, NULL, in1, in2, in3, n, wp) ; break;
//            case mp_realfunc3_coulomb_g: arb_hypgeom_coulomb_series(NULL, out1, in1, in2, in3, n, wp) ; break;
//        }
//    }
//}
//
//
//void Lib_Arb_Series_Realfunc3(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1, ArbPtr in2, ArbPtr in3)
//{
//    Arb_Series_Realfunc3((arb_poly_struct*) out1, what, wp, n, (arb_ptr) in1, (arb_ptr) in2, (arb_poly_struct*) in3);
//}
//
//
//
//
//
////void Lib_Arb_Pow_Arb_Series(ArbPtr out1, ArbPtr in1, ArbPtr in2, int32_t n, int32_t wp)
////{
////    arb_poly_pow_arb_series((arb_poly_struct*)out1, (arb_poly_struct*)in1, (arb_ptr)in2, n, wp);
////}
//
//
//
//
//
//
//
//
//void Arb_Series_Realfunc2_ui(arb_poly_t out1, long what, slong wp, int32_t n, arb_poly_t in1, int32_t in2)
//{
//    switch (what) {
//
// //       case mp_realfunc2_pow_ui: arb_poly_pow_ui(out1, in1, in2, wp) ; break;     // needs truncation
//        case mp_realfunc2_rising2_ui: arb_poly_rising_ui_series(out1, in1, in2, n, wp) ; break;     // needs truncation
//
//    }
//}
//
//
//void Lib_Arb_Series_Realfunc2_ui(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1, int32_t in2)
//{
//    Arb_Series_Realfunc2_ui((arb_poly_struct*) out1, what, wp, n, (arb_poly_struct*) in1, in2);
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
//void Arb_Series_Realfunc2_Arb(arb_poly_t out1, long what, slong wp, int32_t n, arb_poly_t in1, arb_t in2)
//{
//    switch (what) {
//
//        case mp_realfunc2_hurwitz_zeta: arb_poly_zeta_series(out1, in1, in2, 0, n, wp) ; break;
//        case mp_realfunc2_gamma_upper: arb_hypgeom_gamma_upper_series(out1, in2, in1, 0, n, wp) ; break;     // switch in1 and in2
//        case mp_realfunc2_gamma_upper_r: arb_hypgeom_gamma_upper_series(out1, in2, in1, 1, n, wp) ; break;     // switch in1 and in2
//        case mp_realfunc2_gamma_lower: arb_hypgeom_gamma_lower_series(out1, in2, in1, 0, n, wp) ; break;     // switch in1 and in2
//        case mp_realfunc2_gamma_lower_r: arb_hypgeom_gamma_lower_series(out1, in2, in1, 1, n, wp) ; break;     // switch in1 and in2
//
//    }
//}
//
//
//
//void Lib_Arb_Series_Realfunc2_Arb(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1, ArbPtr in2)
//{
//    Arb_Series_Realfunc2_Arb((arb_poly_struct*) out1, what, wp, n, (arb_poly_struct*) in1, (arb_ptr) in2);
//}
//
//
////}
//
//
//
//
//
//
//
//
//
