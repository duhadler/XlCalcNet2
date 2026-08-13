//
//
//#ifndef MPNUMC_POLYNOMIALS_H_INCLUDED
//#define MPNUMC_POLYNOMIALS_H_INCLUDED
//
//
//
///**************************** FMPZ ******************************/
//
// MPNUMC_DLL_IMPORTEXPORT FlintRandPtr  __cdecl Lib_Flint_Rand_Init_Func();
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Flint_Rand_Init(FlintRandPtr* state);
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Flint_Rand_Clear(FlintRandPtr state);
//
//
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_FmpzMatRandom(mpNumMatrixPtr matResult, int32_t what, int32_t mRows, int32_t mCols);
//
//
//
///**************************** Polynomials: General Functions ******************************/
//
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FmpzPoly_Func(FmpzPolyPtr fmpz_poly_Result, FmpzPolyPtr fmpz_poly_Result2, int32_t what, int32_t len, FmpzPtr z, FmpzPolyPtr polyA, FmpzPolyPtr polyB);
//
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_FmpqPoly_Func(FmpqPolyPtr fmpq_poly_Result, FmpqPolyPtr fmpq_poly_Result2, int32_t what, int32_t len, FmpqPtr z, FmpqPolyPtr polyA, FmpqPolyPtr polyB);
//
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_ArbPoly_Func(ArbPolyPtr arb_poly_Result, ArbPolyPtr arb_poly_Result2, int32_t what, int32_t len, ArbPtr z, ArbPolyPtr polyA, ArbPolyPtr polyB);
//
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_AcbPoly_Func(AcbPolyPtr acb_poly_Result, AcbPolyPtr acb_poly_Result2, int32_t what, int32_t len, AcbPtr z, AcbPolyPtr polyA, AcbPolyPtr polyB);
//
//
///*************************** Polynomials: ARB *****************************/
//
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Poly_Set_Vector(ArbPtr Vector, ArbPolyPtr A, int32_t len);
//
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Series_Realfunc1(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1);
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Series_Realfunc1_Out2(ArbPtr out1, ArbPtr out2, int32_t what, int32_t wp, int32_t n, ArbPtr in1);
//
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Series_Realfunc2(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1, ArbPtr in2);
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Series_Realfunc3(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1, ArbPtr in2, ArbPtr in3);
//
//
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Arb_Series_Realfunc2_ui(ArbPtr out1, int32_t what, int32_t wp, int32_t n, ArbPtr in1, int32_t in2);
//
//
///*************************** Polynomials: ACB *****************************/
//
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Series_Cplxfunc1(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1);
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Series_Cplxfunc1_Out2(AcbPtr out1, AcbPtr out2, int32_t what, int32_t wp, int32_t n, AcbPtr in1);
//
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Series_Cplxfunc2(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1, AcbPtr in2);
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Series_Cplxfunc3(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1, AcbPtr in2, AcbPtr in3);
//
//
// MPNUMC_DLL_IMPORTEXPORT void  __cdecl Lib_Acb_Series_Cplxfunc2_ui(AcbPtr out1, int32_t what, int32_t wp, int32_t n, AcbPtr in1, int32_t in2);
//
//
//
// /*************************** Polynomials: NEW *****************************/
//
// MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_ArbPoly2_Func(ArbPoly2Ptr arb2_poly_Result, ArbPoly2Ptr arb2_poly_Result2, int32_t what, int32_t len, ArbPtr z, ArbPoly2Ptr poly2A, ArbPoly2Ptr poly2B);
//
// MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_AcbPoly2_Func(AcbPoly2Ptr acb2_poly_Result, AcbPoly2Ptr acb2_poly_Result2, int32_t what, int32_t len, AcbPtr z, AcbPoly2Ptr poly2A, AcbPoly2Ptr poly2B);
//
//
//
// /*************************** Eigen: NEW *****************************/
//
// MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_AcbMatEigEnclosureRump(AcbPtr res_lambda, mpNumMatrixPtr matJ, mpNumMatrixPtr matR,   mpNumMatrixPtr matA, AcbPtr lambda_approx, mpNumMatrixPtr matR_approx);
//
// MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_AcbMatEigSimple(mpNumMatrixPtr matResultE, mpNumMatrixPtr matResultL, mpNumMatrixPtr matResultR,   mpNumMatrixPtr matA, mpNumMatrixPtr matE_approx, mpNumMatrixPtr matR_approx);
//
// MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_AcbMatEigMultiple(mpNumMatrixPtr matResultE, mpNumMatrixPtr matA, mpNumMatrixPtr matE_approx, mpNumMatrixPtr matR_approx);
//
//
//
//
//
//
// #endif // MPNUMC_POLYNOMIALS_H_INCLUDED
//
//
//
