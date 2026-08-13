#ifdef _MSC_VER
#pragma warning (disable : 4146)
#pragma warning (disable : 4244)
#pragma warning (disable : 4267)
#endif

#if defined (USE_EIGEN)
#define Use_MpAny

#include "mpNumC_Main.h"

#include "libBoostEigenDense.h"
#include "libEigenSparse.h"

#include "HelperFunctions.h"
#include "libBoostEigenCalculus.h"





/***********************************************************************************/



void Lib_Eigen_MpAny_MultipleResults(MapPtr z, int32_t what, char *s, mpNumMatrixPtr A, mpNumMatrixPtr b)
{
    EigenLib_mpType_MultipleResults((mpmapPtr)z, what, string(s), (mpMatrixPtr) A, (mpMatrixPtr) b);
}


MapPtr Lib_Map_MpAny_Init_Func()
{
    return MapLib_mpType_Init_Func(NULL);
}


void Lib_Map_MpAny_Clear(MapPtr z)
{
    MapLib_mpType_Clear((mpmapPtr) z, NULL);
}


void Lib_Map_MpAny_GetItemValue(mpNumMatrixPtr ptr, MapPtr names, char *s)
{
    MapLib_mpType_GetItemValue((mpMatrixPtr) ptr, (mpmapPtr) names, s);
}


/***********************************************************************************/



void Lib_Eigen_MpAnyCplx_MultipleResults(MapPtr z, int32_t what, char *s, mpNumMatrixPtr A, mpNumMatrixPtr b)
{
    EigenLib_cplx_mpType_MultipleResults((mpmapPtr)z, what, string(s), (mpCplxMatrixPtr) A, (mpCplxMatrixPtr) b);
}


MapPtr Lib_Map_MpAnyCplx_Init_Func()
{
    return MapLib_cplx_mpType_Init_Func(NULL);
}


void Lib_Map_MpAnyCplx_Clear(MapPtr z)
{
    MapLib_cplx_mpType_Clear((mpmapPtr) z, NULL);
}


void Lib_Map_MpAnyCplx_GetItemValue(mpNumMatrixPtr ptr, MapPtr names, char *s)
{
    MapLib_cplx_mpType_GetItemValue((mpCplxMatrixPtr) ptr, (mpmapPtr) names, s);
}




//****************************Dense Matrix*********************************************************




mpNumMatrixPtr Lib_Eigen_MpAny_Init_Func()
{
    mpNumMatrixPtr dummy = NULL;
    return (mpNumMatrixPtr) EigenLib_mpType_Init_Func((mpMatrixPtr) dummy);
}


void Lib_Eigen_MpAny_Clear(mpNumMatrixPtr x)
{
    EigenLib_mpType_Clear((mpMatrixPtr) x);
}




void Lib_Eigen_MpAny_Sort(mpNumMatrixPtr x, int32_t SortOrder, int32_t SortCriterion)
{
    EigenLib_mpType_Sort((mpMatrixPtr) x, SortOrder, SortCriterion);
}



void Lib_Eigen_MpAny_SortRowsByColumn(mpNumMatrixPtr x, int32_t ColumnToSortBy, int32_t SortOrder, int32_t SortCriterion)
{
    EigenLib_mpType_SortRowsByColumn((mpMatrixPtr) x, ColumnToSortBy, SortOrder, SortCriterion);

}



void Lib_Eigen_MpAny_Select_Rows(mpNumMatrixPtr res, mpNumMatrixPtr A)
{
    EigenLib_mpType_Select_Rows((mpMatrixPtr) res, (mpMatrixPtr) A);

}




/* *********************************************************************************** */


void Lib_Eigen_Real_Roots_To_MonicPolynomial(int32_t mpRType, mpNumMatrixPtr polynomial_result, mpNumMatrixPtr roots_source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenLib_mpType_Roots_To_MonicPolynomial((mpMatrixPtr) polynomial_result, (mpMatrixPtr) roots_source);
}



void Lib_Eigen_Real_Poly_Eval(int32_t mpRType, mpNumMatrixPtr evaluation_result, mpNumMatrixPtr polynomial_source, mpNumMatrixPtr roots_source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenLib_mpType_Poly_Eval((mpMatrixPtr) evaluation_result, (mpMatrixPtr) polynomial_source, (mpMatrixPtr) roots_source);
}



void Lib_Eigen_Real_Poly_Eval_Complex(int32_t mpRType, mpNumMatrixPtr evaluation_result, mpNumMatrixPtr polynomial_source, mpNumMatrixPtr cplxroots_source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenLib_mpType_Poly_Eval_Complex((mpCplxMatrixPtr) evaluation_result, (mpMatrixPtr) polynomial_source, (mpCplxMatrixPtr) cplxroots_source);
}



void Lib_Eigen_Real_PolynomialSolver(int32_t mpRType, mpNumMatrixPtr cplxroots_result, mpNumMatrixPtr polynomial_source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenLib_mpType_PolynomialSolver((mpCplxMatrixPtr) cplxroots_result, (mpMatrixPtr) polynomial_source);
}




void Lib_Eigen_Cplx_Roots_To_MonicPolynomial(int32_t mpRType, mpNumMatrixPtr polynomial_result, mpNumMatrixPtr roots_source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenLib_cplx_mpType_Roots_To_MonicPolynomial((mpCplxMatrixPtr) polynomial_result, (mpCplxMatrixPtr) roots_source);
}


void Lib_Eigen_Cplx_Poly_Eval_Complex(int32_t mpRType, mpNumMatrixPtr evaluation_result, mpNumMatrixPtr polynomial_source, mpNumMatrixPtr roots_source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenLib_cplx_mpType_Poly_Eval_Complex((mpCplxMatrixPtr) evaluation_result, (mpCplxMatrixPtr) polynomial_source, (mpCplxMatrixPtr) roots_source);;
}


void Lib_Eigen_Cplx_PolynomialSolver(int32_t mpRType, mpNumMatrixPtr cplxroots_result, mpNumMatrixPtr polynomial_source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenLib_cplx_mpType_PolynomialSolver((mpCplxMatrixPtr) cplxroots_result, (mpCplxMatrixPtr) polynomial_source);
}




/* *********************************************************************************** */





void Lib_Eigen_Real_FFT_Real_Fwd(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenLib_mpType_FFT_real_fwd((mpCplxMatrixPtr) result, (mpMatrixPtr) source);
}


void Lib_Eigen_Real_FFT_Real_Inv(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenLib_mpType_FFT_real_inv((mpMatrixPtr) result, (mpCplxMatrixPtr) source);
}


void Lib_Eigen_Cplx_FFT_Fwd(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenLib_cplx_mpType_FFT_fwd((mpCplxMatrixPtr) result, (mpCplxMatrixPtr) source);
}


void Lib_Eigen_Cplx_FFT_Inv(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenLib_cplx_mpType_FFT_inv((mpCplxMatrixPtr) result, (mpCplxMatrixPtr) source);
}





/* *********************************************************************************** */








// Coeff


void Lib_Eigen_MpAny_GetCoeff(ScalarPtr result, long row, long col, mpNumMatrixPtr SourceMatrix)
{
	double result1;
	int32_t what = Lib_Get_Matrix_Mode();
	switch (what)
	{
	case mp_xrf: Lib_Set_Matrix_Mode(mp_xrf);
		result1 = (*(double*)(((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr()));
		(*(double*)result) = result1;
		//(*(double*)result) = (*(double*)(((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr()));
		break;
#ifndef _MSC_VER
	case mp_ext: Lib_Set_Matrix_Mode(mp_ext); (*(long double*)result) = (*(long double*)(((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr())); break;
	case mp_quad: Lib_Set_Matrix_Mode(mp_quad); (*(__float128*)result) = (*(__float128*)(((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr())); break;
#endif
	case mp_mprf: Lib_Set_Matrix_Mode(mp_mprf); mpfr_set((mpfr_ptr)result, (mpfr_ptr)(((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr()), MPFR_RNDN); break;
//	case mp_mpri: Lib_Set_Matrix_Mode(mp_mpri); mpfi_set((mpfi_ptr)result, (mpfi_ptr)(((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr())); break;
	case mp_arb: Lib_Set_Matrix_Mode(mp_arb); arb_set((arb_ptr)result, (arb_ptr)((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr()); break;
	case mp_arf: Lib_Set_Matrix_Mode(mp_arf); arf_set((arf_ptr)result, (arf_ptr)((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr()); break;
//	case mp_drf: Lib_Set_Matrix_Mode(mp_drf); Lib_Mpd_Set((mpd_t*)result, (mpd_t*)((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr()); break;
	case mp_fmpq: Lib_Set_Matrix_Mode(mp_fmpq); fmpq_set((fmpq*)result, (fmpq*)((mpMatrixPtr)SourceMatrix)->coeff(row, col).scalar_ptr()); break;
	}
}


void Lib_Eigen_MpAny_SetCoeff(mpNumMatrixPtr result, ScalarPtr src, long row, long col)
{
	int32_t what = Lib_Get_Matrix_Mode();
	switch (what)
	{
	case mp_xrf: Lib_Set_Matrix_Mode(mp_xrf); (*(double*)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr())) = (*(double*)src); break;
#ifndef _MSC_VER
	case mp_ext: Lib_Set_Matrix_Mode(mp_ext); (*(long double*)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr())) = (*(long double*)src); break;
	case mp_quad: Lib_Set_Matrix_Mode(mp_quad); (*(__float128*)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr())) = (*(__float128*)src); break;
#endif
	case mp_mprf: Lib_Set_Matrix_Mode(mp_mprf); mpfr_set((mpfr_ptr)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr()), (mpfr_ptr)src, MPFR_RNDN); break;
//	case mp_mpri: Lib_Set_Matrix_Mode(mp_mpri); mpfi_set((mpfi_ptr)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr()), (mpfi_ptr)src); break;
	case mp_arb: Lib_Set_Matrix_Mode(mp_arb); arb_set((arb_ptr)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr()), (arb_ptr)src); break;
	case mp_arf: Lib_Set_Matrix_Mode(mp_arf); arf_set((arf_ptr)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr()), (arf_ptr)src); break;
//	case mp_drf: Lib_Set_Matrix_Mode(mp_drf); Lib_Mpd_Set((mpd_t*)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr()), (mpd_t*)src); break;
	case mp_fmpq: Lib_Set_Matrix_Mode(mp_fmpq); fmpq_set((fmpq*)(((mpMatrixPtr)result)->coeff(row, col).scalar_ptr()), (fmpq*)src); break;
	}
}




uint32_t Lib_Eigen_MpAny_GetInfo(long what, mpNumMatrixPtr Matrix)
{
     long result;
     EigenLib_mpType_GetInfo(&result, what, (mpMatrixPtr) Matrix);
     return result;
}




void Lib_Eigen_MpAny_Get_Block(mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
    EigenLib_mpType_GetBlock((mpMatrixPtr) result, what, i, j, p, q, (mpMatrixPtr) source);
}


void Lib_Eigen_MpAny_Put_Block(mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
    EigenLib_mpType_PutBlock((mpMatrixPtr) result, what, i, j, p, q, (mpMatrixPtr) source);
}




//*************************************************************************************




void Lib_Eigen_MpAny_SetSpecialValue(mpNumMatrixPtr xPtr, long what, long m, long n)
{
    EigenLib_mpType_SetSpecialValue((mpMatrixPtr) xPtr, what, m, n);
}


void Lib_Eigen_MpAny_SetSpecialValue2(mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source)
{
    EigenLib_mpType_SetSpecialValue2((mpMatrixPtr) result, what, Vertical, Horizontal, PartialMode, (mpMatrixPtr) source);
}



uint32_t Lib_Eigen_MpAny_Compare(long what, mpNumMatrixPtr x, mpNumMatrixPtr y)
{
    long result;
    EigenLib_mpType_Compare(&result, what, (mpMatrixPtr) x, (mpMatrixPtr) y);
    return (uint32_t) result;
}



void Lib_Eigen_MpAny_BasicArithmetic(mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y)
{
    EigenLib_mpType_BasicArithmetic((mpMatrixPtr) result, what, (mpMatrixPtr) x, (mpMatrixPtr) y);
}




void Lib_Eigen_MpAny_Stats(mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source)
{
    EigenLib_mpType_Stats((mpMatrixPtr) result, what, PartialMode, (mpMatrixPtr) source);
}



void Lib_Eigen_MpAny_Stats2(mpNumMatrixPtr result, long *IndexX, long *IndexY, long what, mpNumMatrixPtr source)
{
    EigenLib_mpType_Stats2((mpMatrixPtr) result, IndexX, IndexY, what, (mpMatrixPtr) source);
}






/**************************** Eigen Calculus *********************************************************/







void Lib_Eigen_MpAny_Real_testHybrj_ext(int32_t mpRType, FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matFvec_, mpNumMatrixPtr matFjac_, mpNumMatrixPtr matInput)
{
    Lib_Set_Matrix_Mode(mpRType);
    testHybrj_ext((AnyFuncPtr)  f1, (AnyFuncPtr)  f2, (mpMatrixPtr) matX_, (mpMatrixPtr) matFvec_, (mpMatrixPtr) matFjac_, (mpMatrixPtr) matInput);
}



void Lib_Eigen_MpAny_Real_testLmder_ext(int32_t mpRType, FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matFvec_, mpNumMatrixPtr matFjac_, mpNumMatrixPtr matInput)
{
    Lib_Set_Matrix_Mode(mpRType);
    testLmder_ext((AnyFuncPtr)  f1, (AnyFuncPtr)  f2, (mpMatrixPtr) matX_, (mpMatrixPtr) matFvec_, (mpMatrixPtr) matFjac_, (mpMatrixPtr) matInput);
}






//*************************************************************************************
//*************************************************************************************
//*************************************************************************************
//*************************************************************************************




void Lib_Eigen_MpAnyCplx_Sort(mpNumMatrixPtr x, int32_t SortOrder, int32_t SortCriterion)
{
    EigenLib_cplx_mpType_Sort((mpCplxMatrixPtr) x, SortOrder, SortCriterion);
}




void Lib_Eigen_MpAnyCplx_SortRowsByColumn(mpNumMatrixPtr x, int32_t ColumnToSortBy, int32_t SortOrder, int32_t SortCriterion)
{
    EigenLib_cplx_mpType_SortRowsByColumn((mpCplxMatrixPtr) x, ColumnToSortBy, SortOrder, SortCriterion);

}


void Lib_Eigen_MpAnyCplx_Select_Rows(mpNumMatrixPtr res, mpNumMatrixPtr A)
{
    EigenLib_cplx_mpType_Select_Rows((mpCplxMatrixPtr) res, (mpCplxMatrixPtr) A);
}



mpNumMatrixPtr Lib_Eigen_MpAnyCplx_Init_Func()
{
    mpNumMatrixPtr dummy = NULL;
    return (mpNumMatrixPtr) EigenLib_cplx_mpType_Init_Func((mpCplxMatrixPtr) dummy);
}



void Lib_Eigen_MpAnyCplx_Clear(mpNumMatrixPtr x)
{
    EigenLib_cplx_mpType_Clear((mpCplxMatrixPtr) x);
}



// Coeff


void Lib_Eigen_MpAnyCplx_GetCoeff(ScalarPtr result, long row, long col, mpNumMatrixPtr SourceMatrix)
{
	int32_t what = Lib_Get_Matrix_Mode();
	switch (what)
	{
	case mp_xrf: Lib_Set_Matrix_Mode(mp_xrf); *((std::complex<double>*)result) = std::complex<double>(
					(*(double*)(real(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr())),
					(*(double*)(imag(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()))); break;

#ifndef _MSC_VER
	case mp_ext: Lib_Set_Matrix_Mode(mp_ext); *((std::complex<long double>*)result) = std::complex<long double>(
					(*(long double*)(real(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr())),
					(*(long double*)(imag(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()))); break;

	case mp_quad: Lib_Set_Matrix_Mode(mp_quad); *((std::complex<__float128>*)result) = std::complex<__float128>(
					(*(__float128*)(real(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr())),
					(*(__float128*)(imag(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()))); break;

#endif

	case mp_mprf: Lib_Set_Matrix_Mode(mp_mprf); mpc_set_fr_fr((mpc_ptr)result,
					(mpfr_ptr)(real(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()),
					(mpfr_ptr)(imag(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()), MPC_RNDNN); break;

//	case mp_mpri:  Lib_Set_Matrix_Mode(mp_mpri); mpci_set_mpfi_mpfi((mpci_ptr)result,
//					(mpfi_ptr)(real(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()),
//					(mpfi_ptr)(imag(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr())); break;

//	case mp_drf:  Lib_Set_Matrix_Mode(mp_drf); Lib_Mpdc_Set2((MpdcPtr)result,
//					(MpdcPtr)(real(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()),
//					(MpdcPtr)(imag(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr())); break;

	case mp_arb: Lib_Set_Matrix_Mode(mp_arb); acb_set_arb_arb((acb_ptr)result,
					(arb_ptr)real(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr(),
					(arb_ptr)imag(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()); break;

//	case mp_arf: Lib_Set_Matrix_Mode(mp_arf); Lib_Acf_Set2((acf_ptr)result,
//					(arf_ptr)real(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr(),
//					(arf_ptr)imag(((mpCplxMatrixPtr)SourceMatrix)->coeff(row, col)).scalar_ptr()); break;
	}
}


//void SetCplxCoeff_xrf(mpNumMatrixPtr result, ScalarPtr src, long row, long col)
//{
//    typedef Matrix<complex<double*>,Dynamic,Dynamic>*  mp_xrf_MatrixC;
//    double* dre = (double*) Lib_Dbl_Init_Func();
//    double* dim = (double*) Lib_Dbl_Init_Func();
//    *dre = real(*(std::complex<double>*)src);
//    *dim = imag(*(std::complex<double>*)src);
//    Lib_Set_Matrix_Mode(mp_xrf);
//    (*(mp_xrf_MatrixC)result)(row, col) = std::complex<double*>(dre, dim);
//}



//void SetCplxCoeff_ext(mpNumMatrixPtr result, ScalarPtr src, long row, long col)
//{
//    typedef Matrix<complex<long double*>,Dynamic,Dynamic>*  mp_ext_MatrixC;
//    long double* dre = (long double*) Lib_Ext_Init_Func();
//    long double* dim = (long double*) Lib_Ext_Init_Func();
//    *dre = real(*(std::complex<long double>*)src);
//    *dim = imag(*(std::complex<long double>*)src);
//    Lib_Set_Matrix_Mode(mp_ext);
//    (*(mp_ext_MatrixC)result)(row, col) = std::complex<long double*>(dre, dim);
//}


//void SetCplxCoeff_quad(mpNumMatrixPtr result, ScalarPtr src, long row, long col)
//{
//    typedef Matrix<complex<__float128*>,Dynamic,Dynamic>*  mp_quad_MatrixC;
//    __float128* dre = (__float128*) Lib_Quad_Init_Func();
//    __float128* dim = (__float128*) Lib_Quad_Init_Func();
//    *dre = real(*(std::complex<__float128>*)src);
//    *dim = imag(*(std::complex<__float128>*)src);
//    Lib_Set_Matrix_Mode(mp_quad);
//    (*(mp_quad_MatrixC)result)(row, col) = std::complex<__float128*>(dre, dim);
//}
//



void Lib_Eigen_MpAnyCplx_SetCoeff(mpNumMatrixPtr result, ScalarPtr src, long row, long col)
{
	int32_t what = Lib_Get_Matrix_Mode();
	switch (what)
	{
//	case mp_xrf: SetCplxCoeff_xrf(result, src, row, col);  break;
//#ifndef _MSC_VER
//	case mp_ext: SetCplxCoeff_ext(result, src, row, col);  break;
//	case mp_quad: SetCplxCoeff_quad(result, src, row, col);  break;
//#endif

	case mp_mprf: Lib_Set_Matrix_Mode(mp_mprf); (*(mpCplxMatrixPtr)result)(row, col) =
					std::complex<mpType>(mpAny::mpscalar(mpc_realref((mpc_ptr)src)),
					mpAny::mpscalar(mpc_imagref((mpc_ptr)src))); break;

//	case mp_mpri: Lib_Set_Matrix_Mode(mp_mpri); (*(mpCplxMatrixPtr)result)(row, col) =
//					std::complex<mpType>(mpAny::mpscalar(((mpci_ptr)src)->real),
//					mpAny::mpscalar(((mpci_ptr)src)->imag)); break;

//
//	case mp_drf: Lib_Set_Matrix_Mode(mp_drf); (*(mpCplxMatrixPtr)result)(row, col) =
//					std::complex<mpType>(mpAny::mpscalar(((mpdc_ptr)src)->real),
//					mpAny::mpscalar(((mpdc_ptr)src)->imag)); break;

	case mp_arb: Lib_Set_Matrix_Mode(mp_arb); (*(mpCplxMatrixPtr)result)(row, col) =
					std::complex<mpType>(acb_realref((acb_ptr)src),
					acb_imagref((acb_ptr)src));	break;

	case mp_arf: Lib_Set_Matrix_Mode(mp_arf); (*(mpCplxMatrixPtr)result)(row, col) =
					std::complex<mpType>(acf_realref((acf_ptr)src),
					acf_imagref((acf_ptr)src));	break;

	}
}





uint32_t Lib_Eigen_MpAnyCplx_GetInfo(long what, mpNumMatrixPtr Matrix)
{
     long result;
     EigenLib_cplx_mpType_GetInfo(&result, what, (mpCplxMatrixPtr) Matrix);
     return result;
}





void Lib_Eigen_MpAnyCplx_Get_Block(mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
    EigenLib_cplx_mpType_GetBlock((mpCplxMatrixPtr) result, what, i, j, p, q, (mpCplxMatrixPtr) source);
}


void Lib_Eigen_MpAnyCplx_Put_Block(mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
    EigenLib_cplx_mpType_PutBlock((mpCplxMatrixPtr) result, what, i, j, p, q, (mpCplxMatrixPtr) source);
}



void Lib_Eigen_MpAnyCplx_SetSpecialValue(mpNumMatrixPtr xPtr, long what, long m, long n)
{
    EigenLib_cplx_mpType_SetSpecialValue((mpCplxMatrixPtr) xPtr, what, m, n);
}



void Lib_Eigen_MpAnyCplx_SetSpecialValue2(mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source)
{
    EigenLib_cplx_mpType_SetSpecialValue2((mpCplxMatrixPtr) result, what, Vertical, Horizontal, PartialMode, (mpCplxMatrixPtr) source);
}





uint32_t Lib_Eigen_MpAnyCplx_Compare(long what, mpNumMatrixPtr x, mpNumMatrixPtr y)
{
    long result;
    EigenLib_cplx_mpType_Compare(&result, what, (mpCplxMatrixPtr) x, (mpCplxMatrixPtr) y);
    return (uint32_t) result;
}




void Lib_Eigen_MpAnyCplx_Stats(mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source)
{
	//EigenLib_cplx_mpType_Stats((mpCplxMatrixPtr)result, what, PartialMode, (mpCplxMatrixPtr)source);
}




void Lib_Eigen_MpAnyCplx_BasicArithmetic(mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y)
{
    EigenLib_cplx_mpType_BasicArithmetic((mpCplxMatrixPtr) result, what, (mpCplxMatrixPtr) x, (mpCplxMatrixPtr) y);
}








/**************************** Sparse Real Matrix ********************************************************/



mpNumMatrixPtr Lib_EigenSparse_MpAny_Init_Func(int32_t mpRType)
{
    Lib_Set_Matrix_Mode(mpRType);
    mpNumMatrixPtr dummy = NULL;
    return (mpNumMatrixPtr) EigenSparseLib_mpType_Init_Func((mpSparseMatrixPtr) dummy);
}


void Lib_EigenSparse_MpAny_Clear(int32_t mpRType, mpNumMatrixPtr x)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenSparseLib_mpType_Clear((mpSparseMatrixPtr) x);
}


uint32_t Lib_EigenSparse_MpAny_GetInfo(int32_t mpRType, long what, mpNumMatrixPtr SparseMatrix)
{
    Lib_Set_Matrix_Mode(mpRType);
     long result;
     EigenSparseLib_mpType_GetInfo(&result, what, (mpSparseMatrixPtr) SparseMatrix);
     return result;
}



void Lib_EigenSparse_MpAny_Get_Block(int32_t mpRType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenSparseLib_mpType_GetBlock((mpSparseMatrixPtr) result, what, i, j, p, q, (mpSparseMatrixPtr) source);
}


void Lib_EigenSparse_MpAny_Put_Block(int32_t mpRType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenSparseLib_mpType_PutBlock((mpSparseMatrixPtr) result, what, i, j, p, q, (mpSparseMatrixPtr) source);
}




void Lib_EigenSparse_MpAny_SetSpecialValue(int32_t mpRType, mpNumMatrixPtr xPtr, long what, long m, long n)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenSparseLib_mpType_SetSpecialValue((mpSparseMatrixPtr) xPtr, what, m, n);
}



void Lib_EigenSparse_MpAny_SetSpecialValue2(int32_t mpRType, mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenSparseLib_mpType_SetSpecialValue2((mpSparseMatrixPtr) result, what, Vertical, Horizontal, PartialMode, (mpSparseMatrixPtr) source);
}




void Lib_EigenSparse_MpAny_BasicArithmetic(int32_t mpRType, mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenSparseLib_mpType_BasicArithmetic((mpSparseMatrixPtr) result, what, (mpSparseMatrixPtr) x, (mpSparseMatrixPtr) y);
}




void Lib_EigenSparse_MpAny_Stats(int32_t mpRType, mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source)
{
    EigenSparseLib_mpType_Stats((mpSparseMatrixPtr) result, what, PartialMode, (mpSparseMatrixPtr) source);
}



void EigenSparseLib_MpAny_DenseFromSparse(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenSparseLib_mpType_DenseFromSparse((mpMatrixPtr) result, (mpSparseMatrixPtr) source);
}


void EigenSparseLib_MpAny_SparseFromDense(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(mpRType);
    EigenSparseLib_mpType_SparseFromDense((mpSparseMatrixPtr) result, (mpMatrixPtr) source);
}


void EigenSparseLib_MpAny_Solve(int32_t mpRType, mpNumMatrixPtr x, mpNumMatrixPtr A, mpNumMatrixPtr b, long Decomposition)
{
    EigenSparseLib_mpType_Solve((mpMatrixPtr) x, (mpSparseMatrixPtr) A, (mpMatrixPtr) b, Decomposition);
}





void Lib_MpAny_PrintSparseMatrix(int32_t mpRType, mpNumMatrixPtr M)
{
    Lib_Set_Matrix_Mode(mpRType);
    PrintSparseMatrix( (mpSparseMatrixPtr) M);
}





//void Lib_MpAny_SpectraSparseSymEigsSolver(int32_t mpRType, mpNumMatrixPtr eval , mpNumMatrixPtr evec , mpNumMatrixPtr M, int32_t nev, int32_t ncv)
//{
//    Lib_Set_Matrix_Mode(mpRType);
//    SpectraSparseSymEigsSolver((mpMatrixPtr) eval , (mpMatrixPtr) evec , (mpSparseMatrixPtr) M, nev, ncv);
//}
//
//void Lib_MpAny_SpectraSparseGenEigsSolver(int32_t mpRType, mpNumMatrixPtr eval , mpNumMatrixPtr evec , mpNumMatrixPtr M, int32_t nev, int32_t ncv)
//{
//    Lib_Set_Matrix_Mode(mpRType);
//    SpectraSparseGenEigsSolver((mpCplxMatrixPtr) eval , (mpCplxMatrixPtr) evec, (mpSparseMatrixPtr) M, nev, ncv);
//}
//
//
//void Lib_MpAny_SpectraSparseSymShiftSolver(int32_t mpRType, mpNumMatrixPtr eval , mpNumMatrixPtr evec , mpNumMatrixPtr M, int32_t nev, int32_t ncv)
//{
//    Lib_Set_Matrix_Mode(mpRType);
//    SpectraSparseSymShiftSolver((mpMatrixPtr) eval , (mpMatrixPtr) evec , (mpSparseMatrixPtr) M, nev, ncv);
//}
//
//


//
//
//void Lib_MpAny_SpectraDenseSymEigsSolver(int32_t mpRType, mpNumMatrixPtr eval , mpNumMatrixPtr evec , mpNumMatrixPtr M, int32_t nev, int32_t ncv)
//{
//    std::cout << "In Lib_MpAny_SpectraDenseSymEigsSolver(int32_t mpRType, mpNumMatrixPtr eval , mpNumMatrixPtr evec , mpNumMatrixPtr M, int32_t nev, int32_t ncv)" << std::endl;
//    Lib_Set_Matrix_Mode(mpRType);
//    SpectraDenseSymEigsSolver((mpMatrixPtr) eval , (mpMatrixPtr) evec , (mpMatrixPtr) M, nev, ncv);
//}
//
//
//
//void Lib_MpAny_SpectraDenseGenEigsSolver(int32_t mpRType, mpNumMatrixPtr eval , mpNumMatrixPtr evec , mpNumMatrixPtr M, int32_t nev, int32_t ncv)
//{
//    Lib_Set_Matrix_Mode(mpRType);
//    SpectraDenseGenEigsSolver((mpCplxMatrixPtr) eval , (mpCplxMatrixPtr) evec, (mpMatrixPtr) M, nev, ncv);
//}
//
//
//void Lib_MpAny_SpectraDenseSymShiftSolver(int32_t mpRType, mpNumMatrixPtr eval , mpNumMatrixPtr evec , mpNumMatrixPtr M, int32_t nev, int32_t ncv)
//{
//    std::cout << "In Lib_MpAny_SpectraDenseSymShiftSolver(int32_t mpRType, mpNumMatrixPtr eval , mpNumMatrixPtr evec , mpNumMatrixPtr M, int32_t nev, int32_t ncv)" << std::endl;
//    Lib_Set_Matrix_Mode(mpRType);
//    SpectraDenseSymShiftSolver((mpMatrixPtr) eval , (mpMatrixPtr) evec , (mpMatrixPtr) M, nev, ncv);
//}
//










//****************************Sparse Complex Matrix*********************************************************



mpNumMatrixPtr Lib_EigenSparse_MpAny_Cplx_Init_Func(int32_t mpRType)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    mpNumMatrixPtr dummy = NULL;
    return (mpNumMatrixPtr) EigenSparseLib_cplx_mpType_Init_Func((mpCplxSparseMatrixPtr) dummy);
}


void Lib_EigenSparse_MpAny_Cplx_Clear(int32_t mpRType, mpNumMatrixPtr x)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_Clear((mpCplxSparseMatrixPtr) x);
}


uint32_t Lib_EigenSparse_MpAny_Cplx_GetInfo(int32_t mpRType, long what, mpNumMatrixPtr SparseMatrix)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
     long result;
     EigenSparseLib_cplx_mpType_GetInfo(&result, what, (mpCplxSparseMatrixPtr) SparseMatrix);
     return result;
}



void Lib_EigenSparse_MpAny_Cplx_Get_Block(int32_t mpRType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_GetBlock((mpCplxSparseMatrixPtr) result, what, i, j, p, q, (mpCplxSparseMatrixPtr) source);
}


void Lib_EigenSparse_MpAny_Cplx_Put_Block(int32_t mpRType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_PutBlock((mpCplxSparseMatrixPtr) result, what, i, j, p, q, (mpCplxSparseMatrixPtr) source);
}




void Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(int32_t mpRType, mpNumMatrixPtr xPtr, long what, long m, long n)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_SetSpecialValue((mpCplxSparseMatrixPtr) xPtr, what, m, n);
}



void Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(int32_t mpRType, mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_SetSpecialValue2((mpCplxSparseMatrixPtr) result, what, Vertical, Horizontal, PartialMode, (mpCplxSparseMatrixPtr) source);
}




void Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(int32_t mpRType, mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_BasicArithmetic((mpCplxSparseMatrixPtr) result, what, (mpCplxSparseMatrixPtr) x, (mpCplxSparseMatrixPtr) y);
}





void EigenSparseLib_MpAny_Cplx_DenseFromSparse(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_DenseFromSparse((mpCplxMatrixPtr) result, (mpCplxSparseMatrixPtr) source);
}


void EigenSparseLib_MpAny_Cplx_SparseFromDense(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_SparseFromDense((mpCplxSparseMatrixPtr) result, (mpCplxMatrixPtr) source);
}




void EigenSparseLib_MpAny_Cplx_Solve(int32_t mpRType, mpNumMatrixPtr x, mpNumMatrixPtr A, mpNumMatrixPtr b, long Decomposition)
{
    Lib_Set_Matrix_Mode(Get_Real_Type(mpRType));
    EigenSparseLib_cplx_mpType_Solve((mpCplxMatrixPtr) x, (mpCplxSparseMatrixPtr) A, (mpCplxMatrixPtr) b, Decomposition);
}




























#undef  Use_MpAny
#endif
