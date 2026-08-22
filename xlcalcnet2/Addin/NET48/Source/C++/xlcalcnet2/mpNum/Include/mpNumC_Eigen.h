
/**************************** Dense Matrix: General *********************************************************/

MPNUMC_DLL_IMPORTEXPORT AnyPtr  __cdecl Lib_Eigen_Init_Func(int32_t mpCat, int32_t mpType);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Clear(int32_t mpCat, int32_t mpType, AnyPtr x);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_GetCoeff(ScalarResPtr result, long row, long col, mpNumMatrixPtr Matrix);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_SetCoeff(mpNumMatrixPtr Matrix, ScalarResPtr result, long row, long col);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Cplx_GetCoeff2(ScalarResPtr result1, ScalarResPtr result2, long row, long col, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Cplx_SetCoeff2(mpNumMatrixPtr result, ScalarPtr source1, ScalarPtr source2, long row, long col);

/* *********************************************************************************** */

MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl  Lib_Eigen_GetInfo(int32_t mpCat, int32_t mpType, long what, mpNumMatrixPtr Matrix);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Get_Block(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Put_Block(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long i, long j, long p, long q, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_SetSpecialValue(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long m, long n);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_SetSpecialValue2(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long Vertical, long Horizontal, long PartialMode, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT uint32_t __cdecl  Lib_Eigen_Compare(int32_t mpCat, int32_t mpType, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);

/* *********************************************************************************** */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_ConvertRealCplx(mpNumMatrixPtr RMat, long what, mpNumMatrixPtr CMat);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Real_ScalarArithmetic(mpNumMatrixPtr result, long what, mpNumMatrixPtr x, ScalarPtr y);;
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Real_CplxScalarArithmetic(mpNumMatrixPtr result, long what, mpNumMatrixPtr x, ScalarPtr y_re, ScalarPtr y_im);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Cplx_ScalarArithmetic(mpNumMatrixPtr result, long what, mpNumMatrixPtr x, ScalarPtr y_re, ScalarPtr y_im);

/* *********************************************************************************** */

MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_BasicArithmetic(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_BasicArithmetic_BLAS(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, mpNumMatrixPtr x, mpNumMatrixPtr y);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Stats(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long what, long PartialMode, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Stats2(int32_t mpCat, int32_t mpType, mpNumMatrixPtr result, long *IndexX, long *IndexY, long what, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_Map_GetItemValue(int32_t mpCat, int32_t mpType, mpNumMatrixPtr ptr, MapPtr z, char *s);
MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Eigen_MultipleResults(int32_t mpCat, int32_t mpType, MapPtr z, int32_t what, char *s, mpNumMatrixPtr A, mpNumMatrixPtr b);

/**************************** Dense Matrix: Extras *********************************************************/

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_Sort(mpNumMatrixPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_Sort_Rows_By_Head(mpNumMatrixPtr x);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_Select_Rows(mpNumMatrixPtr res, mpNumMatrixPtr A);

/* *********************************************************************************** */

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_Roots_To_MonicPolynomial(mpNumMatrixPtr polynomial_result, mpNumMatrixPtr roots_source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_Poly_Eval(mpNumMatrixPtr evaluation_result, mpNumMatrixPtr polynomial_source, mpNumMatrixPtr roots_source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_Poly_Eval_Complex(mpNumMatrixPtr evaluation_result, mpNumMatrixPtr polynomial_source, mpNumMatrixPtr cplxroots_source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_PolynomialSolver(mpNumMatrixPtr cplxroots_result, mpNumMatrixPtr polynomial_source);

/* *********************************************************************************** */

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_MatrixFunction(mpNumMatrixPtr result, long what, mpNumMatrixPtr A);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Cplx_MatrixFunction(mpNumMatrixPtr result, long what, mpNumMatrixPtr A);

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Cplx_FFT_Fwd(mpNumMatrixPtr result, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Cplx_FFT_Inv(mpNumMatrixPtr result, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_FFT_Real_Fwd(mpNumMatrixPtr result, mpNumMatrixPtr source);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_FFT_Real_Inv(mpNumMatrixPtr result, mpNumMatrixPtr source);

/**************************** Eigen Calculus *********************************************************/

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_testHybrj_ext(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matFvec_, mpNumMatrixPtr matFjac_, mpNumMatrixPtr matInput);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_testLmder_ext(FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matFvec_, mpNumMatrixPtr matFjac_, mpNumMatrixPtr matInput);
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_CppOptLib(int32_t what, FuncPtr f1, FuncPtr f2, mpNumMatrixPtr matX_, mpNumMatrixPtr matGrad_, mpNumMatrixPtr matNorm_, mpNumMatrixPtr xPtr, mpNumMatrixPtr resPtr);

MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_demoLinearRegression();
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_demoLogisticRegression();
MPNUMC_DLL_IMPORTEXPORT void __cdecl  Lib_Eigen_Real_demoNonNegativeLeastSquares();
