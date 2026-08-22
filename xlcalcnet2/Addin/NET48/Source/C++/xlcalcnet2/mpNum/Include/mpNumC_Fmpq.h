//
//
//#ifndef MPNUMC_FMPQ_H_INCLUDED
//#define MPNUMC_FMPQ_H_INCLUDED
//
//
//
//
////*********************** Real **********************************
//
//
//
//MPNUMC_DLL_IMPORTEXPORT FmpqPtr Lib_Fmpq_Init_Func();
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Clear(FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Canonicalise(FmpqPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set(FmpqPtr res, const FmpqPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Fmpq(FmpqPtr res, const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Arb(FmpqPtr res, const ArbPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Arf(FmpqPtr res, const ArfPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Mpfi(FmpqPtr res, const MpfiPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Mpfr(FmpqPtr res, const MpfrPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Mpd(FmpqPtr res, const MpdPtr x);
////MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_CReal(FmpqPtr res, const CRealPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_QReal(FmpqPtr res, const ScalarPtr float128_in1);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_LD(FmpqPtr res, const long double* ld_in1);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_D(FmpqPtr res, const double d);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_S(FmpqPtr res, const float* f);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_D_via_Mpd(FmpqPtr res, const double d);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Si(FmpqPtr res, const int32_t num);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Si64(FmpqPtr res, const int64_t num);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Ui(FmpqPtr res, const uint32_t num);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Ui64(FmpqPtr res, const uint64_t num);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Si64_Ui64(FmpqPtr res, const int64_t num, const uint64_t den);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Ui64_Ui64(FmpqPtr res, const uint64_t num, const uint64_t den);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Str(FmpqPtr res, const char* s);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Set_Str_Str(FmpqPtr res, const char* num, const char* den);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Get_Num_Str(char * dest, const FmpqPtr x, const int b);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Get_Den_Str(char * dest, const FmpqPtr x, const int b);
//MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_Fmpq_Get_Num_Str_Sizeinbase(FmpqPtr x, const int b);
//MPNUMC_DLL_IMPORTEXPORT int64_t __cdecl Lib_Fmpq_Get_Den_Str_Sizeinbase(FmpqPtr x, const int b);
//
//
//
//
//
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Neg(FmpqPtr res, const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Inv(FmpqPtr res, const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Abs(FmpqPtr res, const FmpqPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Add(FmpqPtr res, const FmpqPtr x, const FmpqPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Sub(FmpqPtr res, const FmpqPtr x, const FmpqPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Mul(FmpqPtr res, const FmpqPtr x, const FmpqPtr y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Div(FmpqPtr res, const FmpqPtr x, const FmpqPtr y);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Add_D(FmpqPtr res, const FmpqPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Sub_D(FmpqPtr res, const FmpqPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_D_Sub(FmpqPtr res, const FmpqPtr x, const double y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Mul_D(FmpqPtr res, const FmpqPtr x, const double y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Div_D(FmpqPtr res, const FmpqPtr x, const double si);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_D_Div(FmpqPtr res, const FmpqPtr x, const double y);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Add_Si(FmpqPtr res, const FmpqPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Sub_Si(FmpqPtr res, const FmpqPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Si_Sub(FmpqPtr res, const FmpqPtr x, const int32_t y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Mul_Si(FmpqPtr res, const FmpqPtr x, const int32_t y);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Div_Si(FmpqPtr res, const FmpqPtr x, const int32_t si);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Si_Div(FmpqPtr res, const FmpqPtr x, const int32_t y);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Pow_Si(FmpqPtr res, const FmpqPtr x, const int32_t y);
//
//
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_Cmp(const FmpqPtr x, const FmpqPtr y);
//
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_LT(const FmpqPtr x, const FmpqPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_GE(const FmpqPtr x, const FmpqPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_GT(const FmpqPtr x, const FmpqPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_LE(const FmpqPtr x, const FmpqPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_EQ(const FmpqPtr x, const FmpqPtr y);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_NE(const FmpqPtr x, const FmpqPtr y);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Zero(FmpqPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_NegZero(FmpqPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_One(FmpqPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Inf(FmpqPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_NegInf(FmpqPtr res);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Nan(FmpqPtr res);
//
//
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_IsZero(const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_IsOne(const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_IsFinite(const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_IsInfinite(const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_IsNan(const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_IsRegular(const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT int32_t __cdecl Lib_Fmpq_IsInteger(const FmpqPtr x);
//
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Floor(FmpqPtr res, const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Ceil(FmpqPtr res, const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Trunc(FmpqPtr res, const FmpqPtr x);
//
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Floor_R(FmpqPtr q, FmpqPtr r, const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Ceil_R(FmpqPtr q, FmpqPtr r, const FmpqPtr x);
//MPNUMC_DLL_IMPORTEXPORT void __cdecl Lib_Fmpq_Trunc_R(FmpqPtr q, FmpqPtr r, const FmpqPtr x);
//
//
//
//
//
//#endif // MPNUMC_FMPQ_H_INCLUDED
//
//
//
//
//
//
//
//
