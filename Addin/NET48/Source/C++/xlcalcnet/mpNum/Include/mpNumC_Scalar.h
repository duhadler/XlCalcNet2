


#ifndef MPNUMC_SCALAR_H_INCLUDED
#define MPNUMC_SCALAR_H_INCLUDED


MPNUMC_DLL_IMPORTEXPORT AnyPtr  __cdecl Lib_Init_Func(int32_t mpCat, int32_t mpType);
 MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Clear(int32_t mpCat, int32_t mpType, AnyPtr x);
 MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_ConvertMatrixAndPoly(mpNumMatrixPtr Result, int32_t proc, int32_t op1_type, int32_t op2_type, mpNumMatrixPtr Source);


MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_GetCoeff_(int32_t mpType, ScalarResPtr result, long row, long col, mpNumMatrixPtr Matrix);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_SetCoeff_(int32_t mpType, mpNumMatrixPtr Matrix, ScalarResPtr result, long row, long col);
MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl  Lib_Eigen_GetInfo(int32_t mpCat, int32_t mpType, long what, mpNumMatrixPtr Matrix);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Get_Block(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Put_Block(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_SetSpecialValue(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long m, long n);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_SetSpecialValue2(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl  Lib_Eigen_Compare(int32_t mpCat, int32_t mpType, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_BasicArithmetic(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Stats(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Stats2(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long *IndexX, long *IndexY, long what, mpNumMatrixPtr source);


MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Map_GetItemValue(int32_t mpCat, int32_t mpType, mpNumMatrixPtr ptr, MapPtr z, char *s);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_MultipleResults(int32_t mpCat, int32_t mpType, MapPtr z, int32_t what, char *s, mpNumMatrixPtr A, mpNumMatrixPtr b);



MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Use_FlintArbMat(mpNumMatrixPtr matResult, ScalarPtr scalarResult, int32_t mpdata, int32_t what, mpNumMatrixPtr matA, mpNumMatrixPtr matB);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Set_Default (int32_t what, int32_t value);
MPNUMC_DLL_IMPORTEXPORT int32_t  __cdecl Lib_Get_Default (int32_t what);

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Sort(int32_t mpType, mpNumMatrixPtr Matrix, int32_t ColumnToSortBy, int32_t SortOrder, int32_t SortCriterion);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Select_Rows(int32_t mpType, mpNumMatrixPtr res, mpNumMatrixPtr A);


/* *********************************************************************************** */

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Eigen_Real_Roots_To_MonicPolynomial(int32_t mpRType, mpNumMatrixPtr polynomial_result, mpNumMatrixPtr roots_source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Eigen_Real_Poly_Eval(int32_t mpRType, mpNumMatrixPtr evaluation_result, mpNumMatrixPtr polynomial_source, mpNumMatrixPtr roots_source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Eigen_Real_Poly_Eval_Complex(int32_t mpRType, mpNumMatrixPtr evaluation_result, mpNumMatrixPtr polynomial_source, mpNumMatrixPtr cplxroots_source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Eigen_Real_PolynomialSolver(int32_t mpRType, mpNumMatrixPtr cplxroots_result, mpNumMatrixPtr polynomial_source);

MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Eigen_Cplx_Roots_To_MonicPolynomial(int32_t mpRType, mpNumMatrixPtr polynomial_result, mpNumMatrixPtr roots_source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Eigen_Cplx_Poly_Eval_Complex(int32_t mpRType, mpNumMatrixPtr evaluation_result, mpNumMatrixPtr polynomial_source, mpNumMatrixPtr roots_source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Eigen_Cplx_PolynomialSolver(int32_t mpRType, mpNumMatrixPtr cplxroots_result, mpNumMatrixPtr polynomial_source);

/* *********************************************************************************** */

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Cplx_FFT_Fwd(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Cplx_FFT_Inv(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_FFT_Real_Fwd(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_FFT_Real_Inv(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source);





/**************************** Eigen Calculus *********************************************************/


MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_MpAny_Real_testHybrj_ext(int32_t mpRType, FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matFvec_, mpNumMatrixPtr matFjac_, mpNumMatrixPtr matInput);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_MpAny_Real_testLmder_ext(int32_t mpRType, FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matFvec_, mpNumMatrixPtr matFjac_, mpNumMatrixPtr matInput);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_MpAny_Real_CppOptLib(int32_t mpRType, int32_t what, FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm_, mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);






/****************************Sparse Real Matrix*********************************************************/

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_MpAny_PrintSparseMatrix(int32_t mpRType, mpNumMatrixPtr M);

MPNUMC_DLL_IMPORTEXPORT mpNumMatrixPtr __cdecl Lib_EigenSparse_MpAny_Init_Func(int32_t mpRType);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Clear(int32_t mpRType, mpNumMatrixPtr x);

MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl  Lib_EigenSparse_MpAny_GetInfo(int32_t mpRType, long what, mpNumMatrixPtr SourceMatrix);

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Get_Block(int32_t mpRType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Put_Block(int32_t mpRType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_SetSpecialValue(int32_t mpRType, mpNumMatrixPtr result, long what, long m, long n);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_SetSpecialValue2(int32_t mpRType, mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source);

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_BasicArithmetic(int32_t mpRType, mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Stats(int32_t mpRType, mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  EigenSparseLib_MpAny_Solve(int32_t mpRType, mpNumMatrixPtr x, mpNumMatrixPtr A, mpNumMatrixPtr b, long Decomposition);

MPNUMC_DLL_IMPORTEXPORT void __cdecl  EigenSparseLib_MpAny_DenseFromSparse(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  EigenSparseLib_MpAny_SparseFromDense(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source);



/**************************** Eigen: Sparse Complex Matrix***********************************************/


MPNUMC_DLL_IMPORTEXPORT mpNumMatrixPtr __cdecl Lib_EigenSparse_MpAny_Cplx_Init_Func(int32_t mpRType);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Cplx_Clear(int32_t mpRType, mpNumMatrixPtr x);

MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl  Lib_EigenSparse_MpAny_Cplx_GetInfo(int32_t mpRType, long what, mpNumMatrixPtr SourceMatrix);

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Cplx_Get_Block(int32_t mpRType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Cplx_Put_Block(int32_t mpRType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(int32_t mpRType, mpNumMatrixPtr result, long what, long m, long n);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(int32_t mpRType, mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source);

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(int32_t mpRType, mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);


MPNUMC_DLL_IMPORTEXPORT void __cdecl  EigenSparseLib_MpAny_Cplx_DenseFromSparse(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  EigenSparseLib_MpAny_Cplx_SparseFromDense(int32_t mpRType, mpNumMatrixPtr result, mpNumMatrixPtr source);

MPNUMC_DLL_IMPORTEXPORT void __cdecl  EigenSparseLib_MpAny_Cplx_Solve(int32_t mpRType, mpNumMatrixPtr x, mpNumMatrixPtr A, mpNumMatrixPtr b, long Decomposition);







#endif // MPNUMC_SCALAR_H_INCLUDED






