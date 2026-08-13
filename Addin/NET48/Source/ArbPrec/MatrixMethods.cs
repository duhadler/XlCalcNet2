using System;
using System.Runtime.InteropServices;

namespace ArbPrecNet
{



    internal static class Interop
    {



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Use_FlintArbMat", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Use_FlintArbMat(IntPtr matResult, IntPtr scalarResult, int mpdata, int what, IntPtr in1, IntPtr in2);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_ConvertMatrixAndPoly", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_ConvertMatrixAndPoly(IntPtr Result, int proc, int op1_type, int op2_type, IntPtr Source);




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_Init_Func(int mpCat, int mpType);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Clear(int mpCat, int mpType, IntPtr AnyPtr);




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_GetCoeff_", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_GetCoeff(int mpType, IntPtr ScalarPtr_result, int row, int col, IntPtr MatrixPtr_source);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_SetCoeff_", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_SetCoeff(int mpType, IntPtr MatrixPtr_result, IntPtr ScalarPtr_source, int row, int col);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_GetInfo", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Eigen_GetInfo(int mpCat, int mpType, int what, IntPtr MatrixPtr_source);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Get_Block", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Get_Block(int mpCat, int mpType, IntPtr MatrixPtr_result, int what, int i, int j, int p, int q, IntPtr MatrixPtr_source);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Put_Block", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Put_Block(int mpCat, int mpType, IntPtr MatrixPtr_result, int what, int i, int j, int p, int q, IntPtr MatrixPtr_source);




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_SetSpecialValue", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_SetSpecialValue(int mpCat, int mpType, IntPtr MatrixPtr_result, int what, int m, int n);


        internal static void Call_Eigen_SetSpecialValue(int mpCat, int mpType, dynamic result, int what, int m, int n)
        {
            Lib_Eigen_SetSpecialValue(mpCat, mpType, (IntPtr)result.mpPtr, what, m, n);
        }




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_SetSpecialValue2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_SetSpecialValue2(int mpCat, int mpType, IntPtr MatrixPtr_result, int what, int Vertical, int Horizontal, int PartialMode, IntPtr MatrixPtr_source);





        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Compare", CallingConvention = CallingConvention.Cdecl)]
        internal static extern uint Lib_Eigen_Compare(int mpCat, int mpType, int what, IntPtr MatrixPtr_X, IntPtr MatrixPtr_Y);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_BasicArithmetic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_BasicArithmetic(int mpCat, int mpType, IntPtr MatrixPtr_result, int what, IntPtr MatrixPtr_X, IntPtr MatrixPtr_Y);







        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Stats", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Stats(int mpCat, int mpType, IntPtr MatrixPtr_result, int what, int PartialMode, IntPtr MatrixPtr_source);


        // !!! Needs to be modified to remove ByRef !!! Switch from Int32 to Fmpz
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Stats2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Stats2(int mpCat, int mpType, IntPtr MatrixPtr_result, ref int IndexX, ref int IndexY, int what, IntPtr MatrixPtr_source);





        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Map_GetItemValue", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Map_GetItemValue(int mpCat, int mpType, IntPtr res_mpPtr, IntPtr mpPtr, string str);





        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_MultipleResults", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_MultipleResults(int mpCat, int mpType, IntPtr ResMap, int what, string str, IntPtr MatA, IntPtr MatB);

        internal static void Call_Eigen_MultipleResults(int mpCat, int mpType, dynamic ResMap, int what, string str, dynamic MatA, dynamic MatB)
        {
            Lib_Eigen_MultipleResults(mpCat, mpType, (IntPtr)ResMap.mpPtr, what, str, (IntPtr)MatA.mpPtr, (IntPtr)MatB.mpPtr);
        }




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Set_Default", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Set_Default(int what, int value);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Get_Default", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Get_Default(int what);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Sort", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Sort(int mpType, IntPtr MatrixPtr, int ColumnToSortBy, int SortOrder, int SortCriterion);




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Select_Rows", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Select_Rows(int mpType, IntPtr res, IntPtr A);






        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Real_Roots_To_MonicPolynomial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Real_Roots_To_MonicPolynomial(int mpType, IntPtr MatrixPtr_polynomial_result, IntPtr MatrixPtr_roots_source);
        internal static void Call_Eigen_Real_Roots_To_MonicPolynomial(int mpType, dynamic ResMat, dynamic MatA)
        {
            Lib_Eigen_Real_Roots_To_MonicPolynomial(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr);
        }



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Real_Poly_Eval", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Real_Poly_Eval(int mpType, IntPtr MatrixPtr_evaluation_result, IntPtr MatrixPtr_polynomial_source, IntPtr MatrixPtr_roots_source);
        internal static void Call_Eigen_Real_Poly_Eval(int mpType, dynamic ResMat, dynamic MatA, dynamic MatB)
        {
            Lib_Eigen_Real_Poly_Eval(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr, (IntPtr)MatB.mpPtr);
        }



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Real_Poly_Eval_Complex", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Real_Poly_Eval_Complex(int mpType, IntPtr MatrixPtr_cplxevaluation_result, IntPtr MatrixPtr_realpolynomial_source, IntPtr MatrixPtr_cplxroots_source);
        internal static void Call_Eigen_Real_Poly_Eval_Complex(int mpType, dynamic ResMat, dynamic MatA, dynamic MatB)
        {
            Lib_Eigen_Real_Poly_Eval_Complex(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr, (IntPtr)MatB.mpPtr);
        }



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Real_PolynomialSolver", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Real_PolynomialSolver(int mpType, IntPtr MatrixPtr_cplxroots_result, IntPtr MatrixPtr_polynomial_source);
        internal static void Call_Eigen_Real_PolynomialSolver(int mpType, dynamic ResMat, dynamic MatA)
        {
            Lib_Eigen_Real_PolynomialSolver(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr);
        }





        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Cplx_Roots_To_MonicPolynomial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Cplx_Roots_To_MonicPolynomial(int mpType, IntPtr MatrixPtr_polynomial_result, IntPtr MatrixPtr_roots_source);
        internal static void Call_Eigen_Cplx_Roots_To_MonicPolynomial(int mpType, dynamic ResMat, dynamic MatA)
        {
            Lib_Eigen_Cplx_Roots_To_MonicPolynomial(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr);
        }



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Cplx_Poly_Eval_Complex", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Cplx_Poly_Eval_Complex(int mpType, IntPtr MatrixPtr_evaluation_result, IntPtr MatrixPtr_polynomial_source, IntPtr MatrixPtr_roots_source);
        internal static void Call_Eigen_Cplx_Poly_Eval_Complex(int mpType, dynamic ResMat, dynamic MatA, dynamic MatB)
        {
            Lib_Eigen_Cplx_Poly_Eval_Complex(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr, (IntPtr)MatB.mpPtr);
        }


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Cplx_PolynomialSolver", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Cplx_PolynomialSolver(int mpType, IntPtr MatrixPtr_cplxroots_result, IntPtr MatrixPtr_polynomial_source);
        internal static void Call_Eigen_Cplx_PolynomialSolver(int mpType, dynamic ResMat, dynamic MatA)
        {
            Lib_Eigen_Cplx_PolynomialSolver(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr);
        }





        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Real_FFT_Real_Fwd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Real_FFT_Real_Fwd(int mpType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_source);
        internal static void Call_Eigen_Real_FFT_Real_Fwd(int mpType, dynamic ResMat, dynamic MatA)
        {
            Lib_Eigen_Real_FFT_Real_Fwd(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr);
        }


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Real_FFT_Real_Inv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Real_FFT_Real_Inv(int mpType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_source);
        internal static void Call_Eigen_Real_FFT_Real_Inv(int mpType, dynamic ResMat, dynamic MatA)
        {
            Lib_Eigen_Real_FFT_Real_Inv(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr);
        }



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Cplx_FFT_Fwd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Cplx_FFT_Fwd(int mpType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_source);
        internal static void Call_Eigen_Cplx_FFT_Fwd(int mpType, dynamic ResMat, dynamic MatA)
        {
            Lib_Eigen_Cplx_FFT_Fwd(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr);
        }


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_Cplx_FFT_Inv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_Cplx_FFT_Inv(int mpType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_source);
        internal static void Call_Eigen_Cplx_FFT_Inv(int mpType, dynamic ResMat, dynamic MatA)
        {
            Lib_Eigen_Cplx_FFT_Inv(mpType, (IntPtr)ResMat.mpPtr, (IntPtr)MatA.mpPtr);
        }



        #region MINPACK


        public static void testHybrj_ext(cb2Ptr F1, cb2Ptr F2, MpfrMat xMat, MpfrMat fvecMat, MpfrMat fjacMat, MpfrMat matInput)
        {
            Lib_Eigen_MpAny_Real_testHybrj_ext(constants.mp_mprf, F1, F2, xMat.mpPtr, fvecMat.mpPtr, fjacMat.mpPtr, matInput.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_MpAny_Real_testHybrj_ext", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_MpAny_Real_testHybrj_ext(int mpType, cb2Ptr F1, cb2Ptr F2, IntPtr matXPtr, IntPtr matFvecPtr, IntPtr matFjacPtr, IntPtr matInput);



        public static void testLmder_ext(cb2Ptr F1, cb2Ptr F2, MpfrMat xMat, MpfrMat fvecMat, MpfrMat fjacMat, MpfrMat matInput)
        {
            Lib_Eigen_MpAny_Real_testLmder_ext(constants.mp_mprf, F1, F2, xMat.mpPtr, fvecMat.mpPtr, fjacMat.mpPtr, matInput.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Eigen_MpAny_Real_testLmder_ext", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Eigen_MpAny_Real_testLmder_ext(int mpType, cb2Ptr F1, cb2Ptr F2, IntPtr matXPtr, IntPtr matFvecPtr, IntPtr matFjacPtr, IntPtr matInput);


        #endregion





        // ******************************************** CppOptLib ***********************************************



        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_CppOptLibDirect", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern void Lib_Mpfr_CppOptLibDirect(int what, cbProc2Ptr F1, cbProc2Ptr F2, IntPtr matXPtr, IntPtr matGradPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr);


        //public static void NewtonDescentSolver(cbProc2Ptr F1, cbProc2Ptr F2, IntPtr matXPtr, IntPtr matGradPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr)
        //{
        //    Lib_Mpfr_CppOptLibDirect(constants.mp_newton_descent_solver, F1, F2, matXPtr, matGradPtr, matNormPtr, xPtr, fxPtr);
        //}


        //public static void GradientDescentSolver(cbProc2Ptr F1, cbProc2Ptr F2, IntPtr matXPtr, IntPtr matGradPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr)
        //{
        //    Lib_Mpfr_CppOptLibDirect(constants.mp_gradient_descent_solver, F1, F2, matXPtr, matGradPtr, matNormPtr, xPtr, fxPtr);
        //}


        //public static void ConjugatedGradientDescentSolver(cbProc2Ptr F1, cbProc2Ptr F2, IntPtr matXPtr, IntPtr matGradPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr)
        //{
        //    Lib_Mpfr_CppOptLibDirect(constants.mp_conjugated_gradient_descent_solver, F1, F2, matXPtr, matGradPtr, matNormPtr, xPtr, fxPtr);
        //}


        //public static void BfgsSolver(cbProc2Ptr F1, cbProc2Ptr F2, IntPtr matXPtr, IntPtr matGradPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr)
        //{
        //    Lib_Mpfr_CppOptLibDirect(constants.mp_bfgs_solver, F1, F2, matXPtr, matGradPtr, matNormPtr, xPtr, fxPtr);
        //}



        //public static void LbfgsSolver(cbProc2Ptr F1, cbProc2Ptr F2, IntPtr matXPtr, IntPtr matGradPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr)
        //{
        //    Lib_Mpfr_CppOptLibDirect(constants.mp_lbfgs_solver, F1, F2, matXPtr, matGradPtr, matNormPtr, xPtr, fxPtr);
        //}



        // **********************************************************************************************************************************************  



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_AcbPoly_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_AcbPoly_Func(IntPtr out1, IntPtr out2, int what, int len, IntPtr z, IntPtr polyA, IntPtr polyB);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_ArbPoly_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_ArbPoly_Func(IntPtr out1, IntPtr out2, int what, int len, IntPtr z, IntPtr polyA, IntPtr polyB);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FmpzPoly_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FmpzPoly_Func(IntPtr out1, IntPtr out2, int what, int len, IntPtr z, IntPtr polyA, IntPtr polyB);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FmpqPoly_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FmpqPoly_Func(IntPtr out1, IntPtr out2, int what, int len, IntPtr z, IntPtr polyA, IntPtr polyB);



        // ***********************************************************************************************************




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_ArbPoly2_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_ArbPoly2_Func(IntPtr out1, IntPtr out2, int what, int len, IntPtr z, IntPtr polyA, IntPtr polyB);






        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Series2_Realfunc1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Series2_Realfunc1(IntPtr BRealPolyPtr_out1, int what, int prec, int n, IntPtr BRealPolyPtr_in1);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_AcbPoly2_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_AcbPoly2_Func(IntPtr out1, IntPtr out2, int what, int len, IntPtr z, IntPtr polyA, IntPtr polyB);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Series2_Cplxfunc1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Series2_Cplxfunc1(IntPtr BRealPolyPtr_out1, int what, int prec, int n, IntPtr BRealPolyPtr_in1);





        // ***********************************************************************************************************


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Poly_Set_Vector", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Poly_Set_Vector(IntPtr BRealVecPtr, IntPtr BRealPolyPtr, int len);




        // ***********************************************************************************************************


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FmpzMatRandom", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FmpzMatRandom(IntPtr MatrixPtr_result, int what, int mRows, int mCols);


        // ***********************************************************************************************************







    }



    internal static class GMITypes
    {


        internal static int GMI(Type BaseType)
        {
            int Result = constants.mp_mprf;
            string s = BaseType.Name;
            if (s.EndsWith("FprT"))
                Result = constants.mp_xpr;
            if (s.EndsWith("FpcT"))
                Result = constants.mp_xpc;
            if (s.EndsWith("Xpr"))
                Result = constants.mp_ext;
            if (s.EndsWith("Xpc"))
                Result = constants.mp_ext_cplx;
            if (s.EndsWith("Qpr"))
                Result = constants.mp_quad;
            if (s.EndsWith("Qpc"))
                Result = constants.mp_quad_cplx;
            if (s.EndsWith("CppDecimal"))
                Result = constants.mp_dpr;
            if (s.EndsWith("CppDecimalC"))
                Result = constants.mp_dpc;

            if (s.EndsWith("Mpfr"))
                Result = constants.mp_mprf;
            if (s.EndsWith("MpfrC"))
                Result = constants.mp_mpcf;
            if (s.EndsWith("Interval"))
                Result = constants.mp_mpri;
            if (s.EndsWith("IntervalC"))
                Result = constants.mp_mpci;

            if (s.EndsWith("CppDecimal"))
                Result = constants.mp_dpr;
            if (s.EndsWith("CppDecimalC"))
                Result = constants.mp_dpc;
            if (s.EndsWith("BigFractionT"))
                Result = constants.mp_fmpq;
            if (s.EndsWith("BigIntT"))
                Result = constants.mp_fmpz;

            //if (s.EndsWith("areal_t"))
            //    Result = constants.mp_arf;
            //if (s.EndsWith("acplx_t"))
            //    Result = constants.mp_acf;
            if (s.EndsWith("Arb"))
                Result = constants.mp_apr;
            if (s.EndsWith("ArbC"))
                Result = constants.mp_apc;


            return Result;
        }


        internal static int GMIMat(Type BaseType)
        {
            int Result = constants.mp_mprf;
            string s = BaseType.Name;
            Console.WriteLine(s);
            if (s.EndsWith("FprMatT"))
                Result = constants.mp_xpr;
            if (s.EndsWith("FpcMatT"))
                Result = constants.mp_xpc;
            if (s.EndsWith("XprMatT"))
                Result = constants.mp_ext;
            if (s.EndsWith("XpcMatT"))
                Result = constants.mp_ext_cplx;
            if (s.EndsWith("QprMatT"))
                Result = constants.mp_quad;
            if (s.EndsWith("QpcMatT"))
                Result = constants.mp_quad_cplx;
            if (s.EndsWith("CppDecimalMat"))
                Result = constants.mp_dpr;
            if (s.EndsWith("CppDecimalMatC"))
                Result = constants.mp_dpc;

            if (s.EndsWith("MpfrMat"))
                Result = constants.mp_mprf;
            if (s.EndsWith("MpfrMatC"))
                Result = constants.mp_mpcf;
            if (s.EndsWith("IntervalMat"))
                Result = constants.mp_mpri;
            if (s.EndsWith("IntervalMatC"))
                Result = constants.mp_mpci;

            if (s.EndsWith("CppDecimalMat"))
                Result = constants.mp_dpr;
            if (s.EndsWith("CppDecimalMatC"))
                Result = constants.mp_dpc;
            if (s.EndsWith("BigFractionMatT"))
                Result = constants.mp_fmpq;
            if (s.EndsWith("BigIntMatT"))
                Result = constants.mp_fmpz;

            if (s.EndsWith("arealmat_t"))
                Result = constants.mp_arf;
            if (s.EndsWith("acplxmat_t"))
                Result = constants.mp_acf;
            if (s.EndsWith("ArbMat"))
                Result = constants.mp_apr;
            if (s.EndsWith("ArbMatC"))
                Result = constants.mp_apc;


            return Result;
        }


    }



    public abstract class GenericMatMethods<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType>
        where RetScalarType : new()
        where RetMatType : new()
        where RetRealType : new()
        where RetMapType : new()
    {


        public IntPtr mpPtr = (IntPtr)0;


        private IntPtr GetPtr(dynamic x)
        {
            return (IntPtr)x.mpPtr;
        }


        internal void Init()
        {
            ArbPrec.Init();
            mpPtr = Interop.Lib_Init_Func(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)));
        }



        public GenericMatMethods()
        {
            // Console.WriteLine("New: , MyMatType: {0} ", GetType(BaseType))
        }




        #region Sort and Select

        /// <summary>
    /// Sorts the entire matrix
    /// </summary>
        public void Sort(int SortOrder, int SortCriterion)
        {
            Interop.Lib_Eigen_Sort(GMITypes.GMI(typeof(BaseType)), mpPtr, -1, SortOrder, SortCriterion);
        }


        /// <summary>
    /// Sorts the matrix rows by column
    /// </summary>
        public void SortRowsByCol(int ColumnToSortBy, int SortOrder, int SortCriterion)
        {
            Interop.Lib_Eigen_Sort(GMITypes.GMI(typeof(BaseType)), mpPtr, ColumnToSortBy, SortOrder, SortCriterion);
        }



        /// <summary>
    /// Selects matrix rows which do not contain nan or Inf
    /// </summary>
        public RetMatType SelectRows()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Select_Rows(GMITypes.GMI(typeof(BaseType)), GetPtr(m1), mpPtr);
            return m1;
        }


        #endregion



        #region Get and Set Coefficients

        /// <summary>
    /// Sets or gets a coefficient of the matrix
    /// </summary>
        public RetScalarType this[int row_i, int col_j = 0]
        {
            get
            {
                var m1 = new RetScalarType();
                Interop.Lib_Eigen_GetCoeff(GMITypes.GMI(typeof(BaseType)), GetPtr(m1), row_i, col_j, mpPtr);
                return m1;
            }

            set
            {
                Interop.Lib_Eigen_SetCoeff(GMITypes.GMI(typeof(BaseType)), mpPtr, GetPtr(value), row_i, col_j);
            }

        }

        #endregion



        #region Get Info

        /// <summary>
    /// Gets the number of rows
    /// </summary>
        public int rows
        {
            get
            {
                return Interop.Lib_Eigen_GetInfo(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_rows, mpPtr);
            }
        }


        /// <summary>
    /// Gets the number of columns
    /// </summary>
        public int cols
        {
            get
            {
                return Interop.Lib_Eigen_GetInfo(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_cols, mpPtr);
            }
        }

        /// <summary>
    /// Gets the size of the matrix
    /// </summary>
        public int size
        {
            get
            {
                return Interop.Lib_Eigen_GetInfo(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_size, mpPtr);
            }
        }

        #endregion




        #region Input and Output, Conversions

        /// <summary>
    /// Displays the matrix
    /// </summary>
        public override string ToString()
        {
            string res = "";
            var m1 = new RetScalarType();
            for (int i = 0, loopTo = rows - 1; i <= loopTo; i++)
            {
                for (int j = 0, loopTo1 = cols - 1; j <= loopTo1; j++)
                {
                    m1 = this[i, j];
                    res = res + m1.ToString() + ", ";
                }
                res = res + Environment.NewLine;
            }
            return res;
        }


        /// <summary>
    /// Converts  the matrix to a string array
    /// </summary>
        public string[,] Str()
        {
            var res = new string[rows, cols];
            var m1 = new RetScalarType();
            for (int i = 0, loopTo = rows - 1; i <= loopTo; i++)
            {
                for (int j = 0, loopTo1 = cols - 1; j <= loopTo1; j++)
                {
                    m1 = this[i, j];
                    res[i, j] = m1.ToString();
                }
            }
            return res;
        }


        /// <summary>
    /// Converts  the matrix to a string array
    /// </summary>
        public string[,] StrArray()
        {
            var res = new string[rows, cols];
            var m1 = new RetScalarType();
            for (int i = 0, loopTo = rows - 1; i <= loopTo; i++)
            {
                for (int j = 0, loopTo1 = cols - 1; j <= loopTo1; j++)
                {
                    m1 = this[i, j];
                    res[i, j] = m1.ToString();
                }
            }
            return res;
        }



        /// <summary>
    /// Converts  the matrix to .NET array
    /// </summary>
        public RetScalarType[,] Mat()
        {
            var res = new RetScalarType[rows, cols];
            for (int i = 0, loopTo = rows - 1; i <= loopTo; i++)
            {
                for (int j = 0, loopTo1 = cols - 1; j <= loopTo1; j++)
                {
                    res[i, j] = new RetScalarType();
                    res[i, j] = this[i, j];
                }
            }
            return res;
        }


        /// <summary>
    /// Prints the matrix
    /// </summary>
        public void Print(string Title, int digits = 6)
        {
            Console.WriteLine(Title);
            Console.WriteLine(this);
        }



        #endregion




        #region Get and Set Blocks, Rows, Cols, Triangular ...

        /// <summary>
    /// Sets or gets a block of the matrix
    /// </summary>
        public RetMatType get_Block(int i, int j, int p, int q)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Get_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_block, i, j, p, q, mpPtr);
            return m1;
        }

        public void set_Block(int i, int j, int p, int q, RetMatType value)
        {
            Interop.Lib_Eigen_Put_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), mpPtr, constants.mp_const_block, i, j, p, q, GetPtr(value));
        }


        /// <summary>
    /// Sets or gets a row of the matrix
    /// </summary>
        public RetMatType get_Row(int i)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Get_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_middleRows, 0, 0, i, 1, mpPtr);
            return m1;
        }

        public void set_Row(int i, RetMatType value)
        {
            Interop.Lib_Eigen_Put_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, GetPtr(value));
        }


        /// <summary>
    /// Sets or gets a column of the matrix
    /// </summary>
        public RetMatType get_Col(int j)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Get_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_middleCols, 0, 0, j, 1, mpPtr);
            return m1;
        }

        public void set_Col(int j, RetMatType value)
        {
            Interop.Lib_Eigen_Put_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, GetPtr(value));
        }



        /// <summary>
    /// Sets or gets a (sub) diagonal of the matrix
    /// </summary>
        public RetMatType get_Diagonal(int q = 0)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Get_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_diagonal, 0, 0, 0, q, mpPtr);
            return m1;
        }

        public void set_Diagonal(int q, RetMatType value)
        {
            Interop.Lib_Eigen_Put_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, GetPtr(value));
        }



        /// <summary>
        /// Sets or gets a triangular view of the matrix
        /// </summary>
        public RetMatType get_TriangularView(int View = 1)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Get_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_triangularView, 0, 0, 0, View, mpPtr);
            return m1;
        }

        public void set_TriangularView(int View, RetMatType value)
        {
            Interop.Lib_Eigen_Put_Block(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, GetPtr(value));
        }



        #endregion




        #region SetSpecialValue


        /// <summary>
        /// Resize the matrix
        /// </summary>
        public void Resize(int n, int m)
        {
            Interop.Lib_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), mpPtr, constants.mp_Resize, n, m);
        }


        /// <summary>
    /// ConservativeResize the matrix
    /// </summary>
        public void ConservativeResize(int n, int m)
        {
            Interop.Lib_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), mpPtr, constants.mp_conservativeResize, n, m);
        }



        #endregion




        #region SetSpecialValue2


        /// <summary>
    /// ResizeLike the matrix
    /// </summary>
        public void ResizeLike(RetMatType m1)
        {
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), mpPtr, constants.mp_ResizeLike, 0, 0, 0, GetPtr(m1));
        }


        /// <summary>
    /// Return a vector as a diagonal of a matrix
    /// </summary>
        public RetMatType AsDiagonal()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_asDiagonal, 0, 0, 0, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the adjoint of a matrix
    /// </summary>
        public RetMatType Adjoint()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_adjoint, 0, 0, 0, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the Conjugate of a matrix
    /// </summary>
        public RetMatType Conjugate()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_conjugate, 0, 0, 0, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the Transpose of a matrix
    /// </summary>
        public RetMatType Transpose()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_transpose, 0, 0, 0, mpPtr);
            return m1;
        }



        /// <summary>
    /// Return the ReverseFull of a matrix
    /// </summary>
        public RetMatType ReverseFull()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_reverse, 0, 0, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the ReverseRowwise of a matrix
    /// </summary>
        public RetMatType ReverseRowwise()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_reverse, 0, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the ReverseColwise of a matrix
    /// </summary>
        public RetMatType ReverseColwise()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_reverse, 0, 0, constants.mp_const_colwise, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the ReplicateFull of a matrix
    /// </summary>
        public RetMatType ReplicateFull(int Vertical, int Horizontal)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_replicate, Vertical, Horizontal, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the ReplicateRowwise of a matrix
    /// </summary>
        public RetMatType ReplicateRowwise(int Vertical)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_replicate, Vertical, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the ReplicateColwise of a matrix
    /// </summary>
        public RetMatType ReplicateColwise(int Horizontal)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_SetSpecialValue2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_replicate, 0, Horizontal, constants.mp_const_colwise, mpPtr);
            return m1;
        }

        #endregion



        #region Arithmetic Comparisons (Compare)


        /// <summary>
    /// Return the GTcount of a matrix
    /// </summary>
        public uint GTcount(MatType Y)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_GT, mpPtr, GetPtr(Y));
        }


        /// <summary>
    /// Return the LTcount of a matrix
    /// </summary>
        public uint LTcount(MatType Y)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_LT, mpPtr, GetPtr(Y));
        }


        /// <summary>
    /// Return the LEcount of a matrix
    /// </summary>
        public uint LEcount(MatType Y)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_LE, mpPtr, GetPtr(Y));
        }


        /// <summary>
    /// Return the GEcount of a matrix
    /// </summary>
        public uint GEcount(MatType Y)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_GE, mpPtr, GetPtr(Y));
        }


        /// <summary>
    /// Return the EQcount of a matrix
    /// </summary>
        public uint EQcount(MatType Y)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_EQ, mpPtr, GetPtr(Y));
        }


        /// <summary>
    /// Return the NEcount of a matrix
    /// </summary>
        public uint NEcount(MatType Y)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), constants.mp_const_NE, mpPtr, GetPtr(Y));
        }


        #endregion





        #region Additional Operations (BasicArithmetic)



        /// <summary>
    /// Return the ConcatHorizontal of a matrix
    /// </summary>
        public RetMatType ConcatHorizontal(MatType x)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_concat_horizontal, mpPtr, GetPtr(x));
            return m1;
        }


        /// <summary>
    /// Return the ConcatVertical of a matrix
    /// </summary>
        public RetMatType ConcatVertical(MatType x)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_concat_vertical, mpPtr, GetPtr(x));
            return m1;
        }


        /// <summary>
    /// Return the CwiseProduct of a matrix
    /// </summary>
        public RetMatType CwiseProduct(MatType x)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_cwiseProduct, GetPtr(x), mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the DotProduct of a matrix
    /// </summary>
        public RetMatType DotProduct(MatType x)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_DotProduct, GetPtr(x), mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the CwiseQuotient of a matrix
    /// </summary>
        public RetMatType CwiseQuotient(MatType x)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_cwiseQuotient, GetPtr(x), mpPtr);
            return m1;
        }





        #endregion



        #region Statistical Functions (Stats)


        /// <summary>
    /// Return the Sum of a matrix
    /// </summary>
        public RetMatType Sum(int PartialMode)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_sum, PartialMode, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the Prod of a matrix
    /// </summary>
        public RetMatType Prod(int PartialMode)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_prod, PartialMode, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the mean of a matrix
    /// </summary>
        public RetMatType mean(int PartialMode)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_mean, PartialMode, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the MinCoeff of a matrix
    /// </summary>
        public RetMatType MinCoeff(int PartialMode)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_minCoeff, PartialMode, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the MaxCoeff of a matrix
    /// </summary>
        public RetMatType MaxCoeff(int PartialMode)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_maxCoeff, PartialMode, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the SquaredNorm of a matrix
    /// </summary>
        public RetMatType SquaredNorm(int PartialMode)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_squaredNorm, PartialMode, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the Norm of a matrix
    /// </summary>
        public RetMatType Norm(int PartialMode)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_Norm, PartialMode, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the StableNorm of a matrix
    /// </summary>
        public RetMatType StableNorm(int PartialMode)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_const_stableNorm, PartialMode, mpPtr);
            return m1;
        }


        #endregion




        #region Statistical Functions returning indices (Stats2)


        /// <summary>
    /// Return the MinCoeffIndex of a matrix
    /// </summary>
        public RetMatType MinCoeffIndex(ref int IndexX, ref int IndexY)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), ref IndexX, ref IndexY, constants.mp_const_minCoeff_Index, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the MaxCoeffIndex of a matrix
    /// </summary>
        public RetMatType MaxCoeffIndex(ref int IndexX, ref int IndexY)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_Stats2(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), ref IndexX, ref IndexY, constants.mp_const_maxCoeff_Index, mpPtr);
            return m1;
        }


        #endregion






    }



    public abstract class fpMatMethods<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType> : GenericMatMethods<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType>
        where RetScalarType : new()
        where RetMatType : new()
        where RetRealType : new()
        where RetMapType : new()
    {



        public fpMatMethods()
        {
        }


        private IntPtr GetPtr(dynamic x)
        {
            return (IntPtr)x.mpPtr;
        }



        #region Decompositions


        /// <summary>
    /// Return the LDLT of a matrix
    /// </summary>
        public RetMapType LDLT(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_ldlt, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the PartialPivLu of a matrix
    /// </summary>
        public RetMapType PartialPivLU(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_partialPivLu, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the PartialPivLu of a matrix
    /// </summary>
        public RetMapType FullPivLU(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_fullPivLu, results, this, b);
            return res_map;
        }



        #endregion



        #region Det, Solve, Inverse


        /// <summary>
    /// Return the Det of a matrix
    /// </summary>
        public RetMatType Det()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_mat_det, mpPtr, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the Rcond of a matrix
    /// </summary>
        public RetMatType Rcond()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_mat_rcond, mpPtr, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the Inverse of a matrix
    /// </summary>
        public RetMatType Inverse()
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_mat_inverse, mpPtr, mpPtr);
            return m1;
        }


        /// <summary>
    /// Return the Inverse of a matrix
    /// </summary>
        public RetMatType Solve(MatType b)
        {
            var m1 = new RetMatType();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), GetPtr(m1), constants.mp_mat_solve, mpPtr, GetPtr(b));
            return m1;
        }


        #endregion




    }




    public abstract class fpMatMethods2<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType> : fpMatMethods<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType>
        where RetScalarType : new()
        where RetMatType : new()
        where RetRealType : new()
        where RetMapType : new()
    {


        public fpMatMethods2()
        {
        }


        private IntPtr GetPtr(dynamic x)
        {
            return (IntPtr)x.mpPtr;
        }


        #region Decompositions


        /// <summary>
    /// Return the LLT of a matrix
    /// </summary>
        public RetMapType LLT(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_llt, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the HouseholderQR of a matrix
    /// </summary>
        public RetMapType HouseholderQR(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_householderQr, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the ColPivHouseholderQR of a matrix
    /// </summary>
        public RetMapType ColPivHouseholderQR(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_colPivHouseholderQr, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the FullPivHouseholderQR of a matrix
    /// </summary>
        public RetMapType FullPivHouseholderQR(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_fullPivHouseholderQr, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the COD of a matrix
    /// </summary>
        public RetMapType COD(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_COD, results, this, b);
            return res_map;
        }

        #endregion




    }



    public class fpMatMethods3<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType> : fpMatMethods2<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType>
        where RetScalarType : new()
        where RetMatType : new()
        where RetRealType : new()
        where RetMapType : new()
    {


        public fpMatMethods3()
        {
        }


        private IntPtr GetPtr(dynamic x)
        {
            return (IntPtr)x.mpPtr;
        }


        #region Decompositions


        /// <summary>
    /// Return the JacobiSvd of a matrix
    /// </summary>
        public RetMapType JacobiSVD(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_jacobiSvd, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the JacobiSvdThin of a matrix
    /// </summary>
        public RetMapType JacobiSvdThin(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_jacobiSvdThin, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the JacobiSvdFull of a matrix
    /// </summary>
        public RetMapType JacobiSvdFull(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_jacobiSvdFull, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the Hessenberg of a matrix
    /// </summary>
        public RetMapType Hessenberg(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_hessenberg, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the Schur of a matrix
    /// </summary>
        public RetMapType Schur(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_schur, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the Tridiag of a matrix
    /// </summary>
        public RetMapType Tridiag(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_tridiag, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the SelfAdjointEigenValuesFromTridiag of a matrix
    /// </summary>
        public RetMapType SelfAdjointEigenValuesFromTridiag(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_SelfAdjointEigenValuesFromTridiag, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the SelfAdjointEigenSystemFromTridiag of a matrix
    /// </summary>
        public RetMapType SelfAdjointEigenSystemFromTridiag(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_SelfAdjointEigenSystemFromTridiag, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the SelfAdjointEigenValues of a matrix
    /// </summary>
        public RetMapType SelfAdjointEigenValues(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_SelfAdjointEigenValues, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the SelfAdjointEigenSystem of a matrix
    /// </summary>
        public RetMapType SelfAdjointEigenSystem(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_SelfAdjointEigenSystem, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the GeneralizedSelfAdjointEigenValues of a matrix
    /// </summary>
        public RetMapType GeneralizedSelfAdjointEigenValues(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_GeneralizedSelfAdjointEigenValues, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the GeneralizedSelfAdjointEigenValues of a matrix
    /// </summary>
        public RetMapType GeneralizedSelfAdjointEigenSolver(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_GeneralizedSelfAdjointEigenSolver, results, this, b);
            return res_map;
        }





        #endregion




    }










    public abstract class RealMatMethods3<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType, CplxRetMapType, CplxMyType, CplxMatType, CplxRetMatType> : fpMatMethods3<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType>
        where RetScalarType : new()
        where RetMatType : new()
        where RetRealType : new()
        where RetMapType : new()
        where CplxRetMapType : new()
        where CplxRetMatType : new()
    {



        public RealMatMethods3()
        {
        }


        private IntPtr GetPtr(dynamic x)
        {
            return (IntPtr)x.mpPtr;
        }


        /// <summary>
    /// Return the RealQZ of a matrix
    /// </summary>
        public RetMapType RealQZ(string results, MatType b)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_realQZ, results, this, b);
            return res_map;
        }


        /// <summary>
    /// Return the PseudoEigenSystem of a matrix
    /// </summary>
        public RetMapType PseudoEigenSystem(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_PseudoEigenSystem, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the EigenValues of a matrix
    /// </summary>
        public CplxRetMapType EigenValues(string results)
        {
            var res_map = new CplxRetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(CplxMyType)), res_map, constants.mp_EigenValuesFromRealInput, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the EigenSystem of a matrix
    /// </summary>
        public CplxRetMapType EigenSystem(string results)
        {
            var res_map = new CplxRetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(CplxMyType)), res_map, constants.mp_EigenSystemFromRealInput, results, this, this);
            return res_map;
        }



        /// <summary>
    /// Return the GenEigenValues of a matrix
    /// </summary>
        public CplxRetMapType GenEigenValues(string results, RealMatType B)
        {
            var res_map = new CplxRetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(CplxMyType)), res_map, constants.mp_EigenValuesFromRealInput, results, this, B);
            return res_map;
        }


        /// <summary>
    /// Return the GenEigenSystem of a matrix
    /// </summary>
        public CplxRetMapType GenEigenSystem(string results, RealMatType B)
        {
            var res_map = new CplxRetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(CplxMyType)), res_map, constants.mp_GeneralizedEigenSystemFromRealInput, results, this, B);
            return res_map;
        }



        /// <summary>
    /// Return RootsToMonicPolynomial
    /// </summary>
        public RetMatType RootsToMonicPolynomial()
        {
            var m1 = new RetMatType();
            Interop.Call_Eigen_Real_Roots_To_MonicPolynomial(GMITypes.GMI(typeof(BaseType)), m1, this);
            return m1;
        }



        /// <summary>
    /// Evaluates a polynomial, given real roots
    /// </summary>
        public RetMatType PolyEval(RealMatType roots)
        {
            var m1 = new RetMatType();
            Interop.Call_Eigen_Real_Poly_Eval(GMITypes.GMI(typeof(BaseType)), m1, this, roots);
            return m1;
        }



        /// <summary>
    /// Evaluates a polynomial, given complex roots
    /// </summary>
        public CplxRetMatType PolyEval(CplxMatType roots)
        {
            var m1 = new CplxRetMatType();
            Interop.Call_Eigen_Real_Poly_Eval_Complex(GMITypes.GMI(typeof(BaseType)), m1, this, roots);
            return m1;
        }



        // ''' <summary>
        // ''' Evaluates a polynomial, given complex roots
        // ''' </summary>
        // Public Function PolyEval_Complex(roots As CplxMatType) As CplxRetMatType
        // Dim m1 As New CplxRetMatType
        // Interop.Call_Eigen_Real_Poly_Eval_Complex(GMI(GetType(BaseType)), m1, Me, roots)
        // Return m1
        // End Function


        /// <summary>
    /// Calculates for the roots of a polynomial, given real coefficients
    /// </summary>
        public CplxRetMatType PolynomialSolver()
        {
            var m1 = new CplxRetMatType();
            Interop.Call_Eigen_Real_PolynomialSolver(GMITypes.GMI(typeof(BaseType)), m1, this);
            return m1;
        }




        /// <summary>
    /// Calculates Real_FFT_Real_Fwd
    /// </summary>
        public CplxRetMatType FFTFwd()
        {
            var m1 = new CplxRetMatType();
            Interop.Call_Eigen_Real_FFT_Real_Fwd(GMITypes.GMI(typeof(BaseType)), m1, this);
            return m1;
        }





    }



    public abstract class CplxMatMethods<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType, RetRealMatType> : fpMatMethods3<BaseType, ScalarType, MatType, RealMatType, RetScalarType, RetMatType, RetRealType, RetMapType>
        where RetScalarType : new()
        where RetMatType : new()
        where RetRealType : new()
        where RetMapType : new()
        where RetRealMatType : new()
    {



        public CplxMatMethods()
        {
        }


        private IntPtr GetPtr(dynamic x)
        {
            return (IntPtr)x.mpPtr;
        }



        /// <summary>
    /// Return the EigenValues of a matrix
    /// </summary>
        public RetMapType EigenValues(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_EigenValues, results, this, this);
            return res_map;
        }


        /// <summary>
    /// Return the EigenSystem of a matrix
    /// </summary>
        public RetMapType EigenSystem(string results)
        {
            var res_map = new RetMapType();
            Interop.Call_Eigen_MultipleResults(constants.mp_eigen, GMITypes.GMI(typeof(BaseType)), res_map, constants.mp_EigenSystem, results, this, this);
            return res_map;
        }



        /// <summary>
    /// Return RootsToMonicPolynomial
    /// </summary>
        public RetMatType RootsToMonicPolynomial()
        {
            var m1 = new RetMatType();
            Interop.Call_Eigen_Cplx_Roots_To_MonicPolynomial(GMITypes.GMI(typeof(BaseType)), m1, this);
            return m1;
        }




        /// <summary>
    /// Evaluates a polynomial, given complex roots
    /// </summary>
        public RetMatType PolyEval(MatType roots)
        {
            var m1 = new RetMatType();
            Interop.Call_Eigen_Cplx_Poly_Eval_Complex(GMITypes.GMI(typeof(BaseType)), m1, this, roots);
            return m1;
        }



        /// <summary>
    /// Calculates for the roots of a polynomial, given real coefficients
    /// </summary>
        public RetMatType PolynomialSolver()
        {
            var m1 = new RetMatType();
            Interop.Call_Eigen_Cplx_PolynomialSolver(GMITypes.GMI(typeof(BaseType)), m1, this);
            return m1;
        }


        /// <summary>
    /// Calculates FFT_Real_Inv
    /// </summary>
        public RetRealMatType FFTRealInv()
        {
            var m1 = new RetRealMatType();
            Interop.Call_Eigen_Real_FFT_Real_Inv(GMITypes.GMI(typeof(BaseType)), m1, this);
            return m1;
        }


        // ''' <summary>
        // ''' Calculates FFT_Fwd
        // ''' </summary>
        // Public Function FFTCplxFwd() As RetMatType
        // Dim m1 As New RetMatType
        // Interop.Call_Eigen_Cplx_FFT_Fwd(GMI(GetType(BaseType)), m1, Me)
        // Return m1
        // End Function


        /// <summary>
    /// Calculates FFT_Fwd
    /// </summary>
        public RetMatType FFTFwd()
        {
            var m1 = new RetMatType();
            Interop.Call_Eigen_Cplx_FFT_Fwd(GMITypes.GMI(typeof(BaseType)), m1, this);
            return m1;
        }


        /// <summary>
    /// Calculates FFTCplxInv
    /// </summary>
        public RetMatType FFTCplxInv()
        {
            var m1 = new RetMatType();
            Interop.Call_Eigen_Cplx_FFT_Inv(GMITypes.GMI(typeof(BaseType)), m1, this);
            return m1;
        }




        #region Get and Set real and imag


        /// <summary>
    /// Return the real part of a matrix
    /// </summary>
        public RetRealType real
        {
            get
            {
                var m1 = new RetRealType();
                int what = GMITypes.GMI(typeof(BaseType));
                Interop.Lib_ConvertMatrixAndPoly(GetPtr(m1), constants.mp_conv_mat_get_real_part_from_complex, what, what, mpPtr);
                return m1;
            }

            set
            {
                int what = GMITypes.GMI(typeof(BaseType));
                Interop.Lib_ConvertMatrixAndPoly(mpPtr, constants.mp_conv_mat_set_real_part_in_complex, what, what, GetPtr(value));
            }
        }


        /// <summary>
    /// Return the imag part of a matrix
    /// </summary>
        public RetRealType imag
        {
            get
            {
                var m1 = new RetRealType();
                int what = GMITypes.GMI(typeof(BaseType));
                Interop.Lib_ConvertMatrixAndPoly(GetPtr(m1), constants.mp_conv_mat_get_imag_part_from_complex, what, what, mpPtr);
                return m1;
            }

            set
            {
                int what = GMITypes.GMI(typeof(BaseType));
                Interop.Lib_ConvertMatrixAndPoly(mpPtr, constants.mp_conv_mat_set_imag_part_in_complex, what, what, GetPtr(value));
            }
        }

        #endregion



    }







    public abstract class RealMatClass1<BaseType, RetType, RetRealType, BaseMatType, RetMatType, RetRealMatType>
            where RetType : new()
            where RetRealType : new()
            where RetMatType : new()
            where RetRealMatType : new()
    {



        #region Matrix functions


        /// <summary>
        /// Returns SetZero
        /// </summary>
        public static RetMatType Zeros(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setZero, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetOnes
        /// </summary>
        public static RetMatType Ones(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setOnes, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static RetMatType Identity(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static RetMatType Eye(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns Random
        /// </summary>
        public static RetMatType Random(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setRandom_nm, n, m);
            return resout;
        }


        /// <summary>
        /// Returns RandomSym
        /// </summary>
        public static RetMatType RandomSymmetric(int n)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setRandomSymmetric, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSa
        /// </summary>
        public static RetMatType RandomSelfAdjoint(int n)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setRandomSA, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSaPosdef
        /// </summary>
        public static RetMatType RandomSelfAdjointPosDef(int n)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setRandomSAPosDef, n, n);
            return resout;
        }


        /// <summary>
        /// Returns FillLinear
        /// </summary>
        public static RetMatType FillLinear(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_FillLinear, n, m);
            return resout;
        }





        ///// <summary>
        ///// Converts from a real matrix of type BigFractionMatT
        ///// </summary>
        //public static RetMatType t(BigFractionMatT fq)
        //{
        //    var resout = new RetMatType();
        //    Interop.CallConvertMatrixAndPoly(resout, constants.mp_conv_mat_dense_from_dense, GMITypes.GMIMat(typeof(BaseMatType)), constants.mp_fmpq, fq.mpPtr);
        //    return resout;
        //}


        ///// <summary>
        ///// Converts from a real matrix of type MpfrMat
        ///// </summary>
        //public static RetMatType t(MpfrMat fr)
        //{
        //    var resout = new RetMatType();
        //    Interop.CallConvertMatrixAndPoly(resout, constants.mp_conv_mat_dense_from_dense, GMITypes.GMIMat(typeof(BaseMatType)), constants.mp_mprf, fr.mpPtr);
        //    return resout;
        //}


        ///// <summary>
        ///// Converts from a real matrix of type CppDecimalMat
        ///// </summary>
        //public static RetMatType t(CppDecimalMat dr)
        //{
        //    var resout = new RetMatType();
        //    Interop.CallConvertMatrixAndPoly(resout, constants.mp_conv_mat_dense_from_dense, GMITypes.GMIMat(typeof(BaseMatType)), constants.mp_dpr, dr.mpPtr);
        //    return resout;
        //}


        ///// <summary>
        ///// Converts from a real matrix of type ArbMat
        ///// </summary>
        //public static RetMatType t(ArbMat ar)
        //{
        //    var resout = new RetMatType();
        //    Interop.CallConvertMatrixAndPoly(resout, constants.mp_conv_mat_dense_from_dense, GMITypes.GMIMat(typeof(BaseMatType)), constants.mp_apr, ar.mpPtr);
        //    return resout;
        //}

        #endregion




    }


    public abstract class ComplexMatClass1<BaseType, RetType, RetRealType, BaseMatType, RetMatType, RetRealMatType>
            where RetType : new()
            where RetRealType : new()
            where RetMatType : new()
            where RetRealMatType : new()
    {





        #region Matrix functions


        /// <summary>
        /// Returns SetZero
        /// </summary>
        public static RetMatType Zeros(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setZero, n, m);
            return resout;
        }



        /// <summary>
        /// Returns SetOnes
        /// </summary>
        public static RetMatType Ones(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setOnes, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static RetMatType Identity(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static RetMatType Eye(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns Random
        /// </summary>
        public static RetMatType Random(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setRandom_nm, n, m);
            return resout;
        }


        /// <summary>
        /// Returns RandomSym
        /// </summary>
        public static RetMatType MatRandomSymmetric(int n)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setRandomSymmetric, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSa
        /// </summary>
        public static RetMatType RandomSelfAdjoint(int n)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setRandomSA, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSaPosdef
        /// </summary>
        public static RetMatType RandomSelfAdjointPosDef(int n)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_setRandomSAPosDef, n, n);
            return resout;
        }


        /// <summary>
        /// Returns FillLinear
        /// </summary>
        public static RetMatType FillLinear(int n, int m)
        {
            var resout = new RetMatType();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, GMITypes.GMIMat(typeof(BaseMatType)), resout, constants.mp_FillLinear, n, m);
            return resout;
        }




        #endregion




    }










}