
using System;
using System.Runtime.InteropServices;


namespace ArbPrecNet
{



    public class MpfrMatMap
    {

        public IntPtr mpPtr = IntPtr.Zero;

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Interop.Lib_Init_Func(constants.mp_map, constants.mp_mprf);
        }


        public MpfrMatMap()
        {
            Init();
        }


        ~MpfrMatMap()
        {
            Interop.Lib_Clear(constants.mp_map, constants.mp_mprf, mpPtr);
        }


        public MpfrMat this[string s]
        {
            get
            {
                var res = new MpfrMat();
                Interop.Lib_Map_GetItemValue(constants.mp_eigen, constants.mp_mprf, res.mpPtr, mpPtr, s);
                return res;
            }
        }

    }



    public class MpfrMat : RealMatMethods3<Mpfr, Mpfr, MpfrMat, MpfrMat, Mpfr, MpfrMat, MpfrMat, MpfrMatMap, MpfrMatMapC, MpfrC, MpfrMatC, MpfrMatC>
    {

        public MpfrMat()
        {
            Init();
        }




        public MpfrSpMat ToSparse()
        {
            var res = new MpfrSpMat();
            AnyLibSparse.EigenSparseLib_MpAny_SparseFromDense(constants.mp_mprf, res.mpPtr, mpPtr);
            return res;
        }


        ~MpfrMat()
        {
            Interop.Lib_Clear(constants.mp_eigen, constants.mp_mprf, mpPtr);
        }






        #region Arithmetic Comparisons (Compare)

        public static bool operator ==(MpfrMat m1, MpfrMat m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_mprf, constants.mp_const_EQ, m1.mpPtr, m2.mpPtr) == m1.size;
        }


        public static bool operator !=(MpfrMat m1, MpfrMat m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_mprf, constants.mp_const_NE, m1.mpPtr, m2.mpPtr) == m1.size;
        }

        #endregion


        #region Arithmetic Operators (BasicArithmetic)

        public static MpfrMat operator +(MpfrMat m1)
        {
            var m2 = mreal.t(0.0d);
            return m1 + m2;
        }

        public static MpfrMat operator -(MpfrMat m1)
        {
            var m2 = mreal.t(-1.0d);
            return m2 * m1;
        }


        public static MpfrMat operator +(MpfrMat M1, MpfrMat M2)
        {
            var Res = new MpfrMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
            return Res;
        }

        public static MpfrMat operator +(MpfrMat M1, Mpfr m2)
        {
            var Res = new MpfrMat();
            var t = mreal.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }




        public static MpfrMatC operator +(MpfrMat M1, MpfrC m2)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            var T1 = mcplx.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_plus_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator +(MpfrMat m1, MpfrMatC m2)
        {
            var m3 = new MpfrMatC();
            var t = mcplx.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_plus, t.mpPtr, m2.mpPtr);
            return m3;
        }





        public static MpfrMat operator -(MpfrMat M1, MpfrMat M2)
        {
            var Res = new MpfrMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_minus, M1.mpPtr, M2.mpPtr);
            return Res;
        }

        public static MpfrMat operator -(MpfrMat M1, Mpfr m2)
        {
            var Res = new MpfrMat();
            var t = mreal.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }





        public static MpfrMatC operator -(MpfrMat M1, MpfrC m2)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            var T1 = mcplx.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_minus_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator -(MpfrMat m1, MpfrMatC m2)
        {
            var m3 = new MpfrMatC();
            var t = mcplx.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_minus, t.mpPtr, m2.mpPtr);
            return m3;
        }






        public static MpfrMat operator *(MpfrMat m1, MpfrMat m2)
        {
            var m3 = new MpfrMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
            return m3;
        }

        public static MpfrMat operator *(MpfrMat M1, Mpfr m2)
        {
            var Res = new MpfrMat();
            var t = mreal.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator *(MpfrMat M1, MpfrC m2)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            var T1 = mcplx.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_times_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator *(MpfrMat m1, MpfrMatC m2)
        {
            var m3 = new MpfrMatC();
            var t = mcplx.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_MatrixProduct, t.mpPtr, m2.mpPtr);
            return m3;
        }






        public static MpfrMat operator /(MpfrMat m1, MpfrMat m2)
        {
            var m3 = new MpfrMat();
            var m4 = new MpfrMat();
            m4 = m2.Inverse();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }

        public static MpfrMat operator /(MpfrMat M1, Mpfr m2)
        {
            var Res = new MpfrMat();
            var t = mreal.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_div_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator /(MpfrMat M1, MpfrC m2)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            var T1 = mcplx.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_div_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator /(MpfrMat m1, MpfrMatC m2)
        {
            var m3 = new MpfrMatC();
            var m4 = new MpfrMatC();
            m4 = m2.Inverse();
            var t = mcplx.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_MatrixProduct, t.mpPtr, m4.mpPtr);
            return m3;
        }




        #endregion





    }






    public class MpfrMatMapC
    {

        public IntPtr mpPtr = IntPtr.Zero;

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Interop.Lib_Init_Func(constants.mp_map, constants.mp_mpcf);
        }


        public MpfrMatMapC()
        {
            Init();
        }


        ~MpfrMatMapC()
        {
            Interop.Lib_Clear(constants.mp_map, constants.mp_mpcf, mpPtr);
        }


        public MpfrMatC this[string s]
        {
            get
            {
                var res = new MpfrMatC();
                Interop.Lib_Map_GetItemValue(constants.mp_eigen, constants.mp_mpcf, res.mpPtr, mpPtr, s);
                return res;
            }
        }

    }



    public class MpfrMatC : CplxMatMethods<MpfrC, MpfrC, MpfrMatC, MpfrMat, MpfrC, MpfrMatC, MpfrMat, MpfrMatMapC, MpfrMat>
    {

        public MpfrMatC()
        {
            Init();
        }


        public bool IsComplex()
        {
            return true;
        }




        public MpfrSpMatC ToSparse()
        {
            var res = new MpfrSpMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_SparseFromDense(constants.mp_mpcf, res.mpPtr, mpPtr);
            return res;
        }


        ~MpfrMatC()
        {
            Interop.Lib_Clear(constants.mp_eigen, constants.mp_mpcf, mpPtr);
        }







        #region Arithmetic Comparisons (Compare)


        public static bool operator ==(MpfrMatC m1, MpfrMatC m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_mpcf, constants.mp_const_EQ, m1.mpPtr, m2.mpPtr) == m1.size;
        }


        public static bool operator !=(MpfrMatC m1, MpfrMatC m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_mpcf, constants.mp_const_NE, m1.mpPtr, m2.mpPtr) == m1.size;
        }

        #endregion


        #region Arithmetic Operators (BasicArithmetic)




        public static MpfrMatC operator +(MpfrMatC m1)
        {
            return m1 + mflintc.zero();
        }


        public static MpfrMatC operator -(MpfrMatC m1)
        {
            return mflintc.t(-1, 0) * m1;
        }




        public static MpfrMatC operator +(MpfrMatC M1, MpfrMatC M2)
        {
            var Res = new MpfrMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
            return Res;
        }


        public static MpfrMatC operator +(MpfrMatC m1, MpfrMat m2)
        {
            var m3 = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_plus, m1.mpPtr, t.mpPtr);
            return m3;
        }


        public static MpfrMatC operator +(MpfrMatC M1, MpfrC m2)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }





        public static MpfrMatC operator -(MpfrMatC m1, MpfrMatC m2)
        {
            var m3 = new MpfrMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
            return m3;
        }


        public static MpfrMatC operator -(MpfrMatC m1, MpfrMat m2)
        {
            var m3 = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, t.mpPtr);
            return m3;
        }


        public static MpfrMatC operator -(MpfrMatC M1, MpfrC m2)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }




        public static MpfrMatC operator *(MpfrMatC m1, MpfrMatC m2)
        {
            var m3 = new MpfrMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
            return m3;
        }


        public static MpfrMatC operator *(MpfrMatC m1, MpfrMat m2)
        {
            var m3 = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, t.mpPtr);
            return m3;
        }


        public static MpfrMatC operator *(MpfrMatC M1, MpfrC m2)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }






        public static MpfrMatC operator /(MpfrMatC m1, MpfrMatC m2)
        {
            var m3 = new MpfrMatC();
            var m4 = new MpfrMatC();
            m4 = m2.Inverse();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }



        public static MpfrMatC operator /(MpfrMatC m1, MpfrMat m2)
        {
            var m3 = new MpfrMatC();
            var m4 = mcplx.mat_t(m2.Inverse());
            // m4 = m2.inverse()
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }



        public static MpfrMatC operator /(MpfrMatC M1, MpfrC m2)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_div_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        #endregion





    }







    internal static class AnyLibSparse
    {



        // *********************************************** Sparse Real*******************************************



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_EigenSparse_MpAny_Init_Func(int mpRType);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Clear(int mpRType, IntPtr a);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_GetInfo", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_EigenSparse_MpAny_GetInfo(int mpRType, int what, IntPtr MatrixPtr_source);




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_MpAny_PrintSparseMatrix", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_MpAny_PrintSparseMatrix(int mpRType, IntPtr MatrixPtr_source);




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Get_Block", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Get_Block(int mpRType, IntPtr MatrixPtr_result, int what, int i, int j, int p, int q, IntPtr MatrixPtr_source);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Put_Block", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Put_Block(int mpRType, IntPtr MatrixPtr_result, int what, int i, int j, int p, int q, IntPtr MatrixPtr_source);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_SetSpecialValue", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_SetSpecialValue(int mpRType, IntPtr MatrixPtr_result, int what, int m, int n);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_SetSpecialValue2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_SetSpecialValue2(int mpRType, IntPtr MatrixPtr_result, int what, int Vertical, int Horizontal, int PartialMode, IntPtr MatrixPtr_source);





        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_BasicArithmetic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_BasicArithmetic(int mpRType, IntPtr MatrixPtr_result, int what, IntPtr MatrixPtr_X, IntPtr MatrixPtr_Y);




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Stats", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Stats(int mpRType, IntPtr MatrixPtr_result, int what, int PartialMode, IntPtr MatrixPtr_source);




        [DllImport(ArbPrec.mpNum, EntryPoint = "EigenSparseLib_MpAny_Solve", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void EigenSparseLib_MpAny_Solve(int mpRType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_A, IntPtr MatrixPtr_b, int Decomposition);



        [DllImport(ArbPrec.mpNum, EntryPoint = "EigenSparseLib_MpAny_DenseFromSparse", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void EigenSparseLib_MpAny_DenseFromSparse(int mpRType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_X);


        [DllImport(ArbPrec.mpNum, EntryPoint = "EigenSparseLib_MpAny_SparseFromDense", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void EigenSparseLib_MpAny_SparseFromDense(int mpRType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_X);







        // *********************************************** Sparse Complex*******************************************




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Cplx_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_EigenSparse_MpAny_Cplx_Init_Func(int mpRType);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Cplx_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Cplx_Clear(int mpRType, IntPtr a);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Cplx_GetInfo", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_EigenSparse_MpAny_Cplx_GetInfo(int mpRType, int what, IntPtr MatrixPtr_source);




        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Cplx_Get_Block", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Cplx_Get_Block(int mpRType, IntPtr MatrixPtr_result, int what, int i, int j, int p, int q, IntPtr MatrixPtr_source);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Cplx_Put_Block", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Cplx_Put_Block(int mpRType, IntPtr MatrixPtr_result, int what, int i, int j, int p, int q, IntPtr MatrixPtr_source);


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Cplx_SetSpecialValue", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(int mpRType, IntPtr MatrixPtr_result, int what, int m, int n);



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(int mpRType, IntPtr MatrixPtr_result, int what, int Vertical, int Horizontal, int PartialMode, IntPtr MatrixPtr_source);





        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_EigenSparse_MpAny_Cplx_BasicArithmetic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(int mpRType, IntPtr MatrixPtr_result, int what, IntPtr MatrixPtr_X, IntPtr MatrixPtr_Y);




        [DllImport(ArbPrec.mpNum, EntryPoint = "EigenSparseLib_MpAny_Cplx_Solve", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void EigenSparseLib_MpAny_Cplx_Solve(int mpRType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_A, IntPtr MatrixPtr_b, int Decomposition);




        [DllImport(ArbPrec.mpNum, EntryPoint = "EigenSparseLib_MpAny_Cplx_DenseFromSparse", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void EigenSparseLib_MpAny_Cplx_DenseFromSparse(int mpRType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_X);




        [DllImport(ArbPrec.mpNum, EntryPoint = "EigenSparseLib_MpAny_Cplx_SparseFromDense", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void EigenSparseLib_MpAny_Cplx_SparseFromDense(int mpRType, IntPtr MatrixPtr_result, IntPtr MatrixPtr_X);



    }




    public class MpfrSpMat
    {

        public IntPtr mpPtr = IntPtr.Zero;


        #region Constructors

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = AnyLibSparse.Lib_EigenSparse_MpAny_Init_Func(constants.mp_mprf);
        }



        private void Init(int m, int n = 1)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_Resize, m, n);
        }


        public MpfrSpMat()
        {
            Init();
        }


        /// <summary>
        /// Create a new Matrix with m of rows and n columns.  
        /// </summary>
        /// <param name="m">Number of rows</param>
        /// <param name="n">Number of columns</param>
        public MpfrSpMat(int m, int n)
        {
            Init(m, n);
        }


        // Public Sub New(x As Double)
        // Init()
        // Lib_EigenSparse_MpAny_SetCoeff(mpPtr, x, 0, 0)
        // End Sub


        public MpfrSpMat(MpfrSpMat src)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_mprf, mpPtr, constants.mp_const_fullcopy, 0, 0, 0, 0, src.mpPtr);
        }


        public MpfrSpMat(MpfrMat src)
        {
            Init();
            AnyLibSparse.EigenSparseLib_MpAny_SparseFromDense(constants.mp_mprf, mpPtr, src.mpPtr);
        }


        ~MpfrSpMat()
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Clear(constants.mp_mprf, mpPtr);
        }

        #endregion


        #region Input and Output


        public MpfrMat ToDense()
        {
            var A = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_DenseFromSparse(constants.mp_mprf, A.mpPtr, mpPtr);
            return A;
        }

        public void Print(string Title, int digits = 6)
        {
            var A = ToDense();
            A.Print(Title, digits);
            // Lib_MpAny_PrintSparseMatrix(mpPtr)
        }

        #endregion


        #region Get and Set Coefficients



        #endregion


        #region Get Info

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        /// <returns>The number of rows in the matrix</returns>
        public int rows
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_mprf, constants.mp_const_rows, mpPtr);
            }
        }


        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        /// <returns>The number of columns in the matrix</returns>
        public int cols
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_mprf, constants.mp_const_cols, mpPtr);
            }
        }


        public int size
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_mprf, constants.mp_const_size, mpPtr);
            }
        }

        #endregion


        #region Get and Set Blocks, Rows, Cols, Triangular ...

        /// <summary>
        /// Gets or Sets a block
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public MpfrSpMat get_block(int i, int j, int p, int q)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_mprf, m1.mpPtr, constants.mp_const_block, i, j, p, q, mpPtr);
            return m1;
        }

        public void set_block(int i, int j, int p, int q, MpfrSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_mprf, mpPtr, constants.mp_const_block, i, j, p, q, value.mpPtr);
        }



        public MpfrSpMat get_row(int i)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_mprf, m1.mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, mpPtr);
            return m1;
        }

        public void set_row(int i, MpfrSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_mprf, mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, value.mpPtr);
        }



        public MpfrSpMat get_col(int j)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_mprf, m1.mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, mpPtr);
            return m1;
        }

        public void set_col(int j, MpfrSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_mprf, mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, value.mpPtr);
        }




        public MpfrSpMat get_diagonal(int q = 0)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_mprf, m1.mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, mpPtr);
            return m1;
        }

        public void set_diagonal(int q, MpfrSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_mprf, mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, value.mpPtr);
        }




        public MpfrSpMat get_triangularView(int View = 1)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_mprf, m1.mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, mpPtr);
            return m1;
        }

        public void set_triangularView(int View, MpfrSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_mprf, mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, value.mpPtr);
        }



        #endregion


        #region SetSpecialValue


        public void setZero(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_setZero, n, m);
        }



        public void setOnes(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_setOnes, n, m);
        }


        public void setIdentity(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_setIdentity, n, m);
        }


        public void resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_Resize, n, m);
        }


        public void conservative_resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_conservativeResize, n, m);
        }



        public void Random(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_setRandom_nm, n, m);
        }


        public void RandomSymmetric(int n)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_setRandomSymmetric, n, n);
        }



        public void FillLinear(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_mprf, mpPtr, constants.mp_FillLinear, n, m);
        }


        #endregion





        #region SetSpecialValue2


        public void ResizeLike(MpfrSpMat m1)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, mpPtr, constants.mp_ResizeLike, 0, 0, 0, m1.mpPtr);
        }


        public MpfrSpMat asDiagonal()
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_asDiagonal, 0, 0, 0, mpPtr);
            return m1;
        }


        public MpfrSpMat adjoint()
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_adjoint, 0, 0, 0, mpPtr);
            return m1;
        }


        public MpfrSpMat conjugate()
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_conjugate, 0, 0, 0, mpPtr);
            return m1;
        }


        public MpfrSpMat transpose()
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_transpose, 0, 0, 0, mpPtr);
            return m1;
        }



        public MpfrSpMat reverse_full()
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public MpfrSpMat reverse_rowwise()
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public MpfrSpMat reverse_colwise()
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_colwise, mpPtr);
            return m1;
        }


        public MpfrSpMat replicate_full(int Vertical, int Horizontal)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_replicate, Vertical, Horizontal, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public MpfrSpMat replicate_rowwise(int Vertical)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_replicate, Vertical, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public MpfrSpMat replicate_colwise(int Horizontal)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_mprf, m1.mpPtr, constants.mp_replicate, 0, Horizontal, constants.mp_const_colwise, mpPtr);
            return m1;
        }

        #endregion


        #region Arithmetic Comparisons (Compare)



        #endregion


        #region Arithmetic Operators (BasicArithmetic)


        // Public Shared Operator +(ByVal m1 As dbl_spmat_t) As dbl_spmat_t
        // Return (1.0) * m1
        // End Operator


        // Public Shared Operator -(ByVal m1 As dbl_spmat_t) As dbl_spmat_t
        // Return (-1.0) * m1
        // End Operator




        public static MpfrSpMat operator +(MpfrSpMat M1, MpfrSpMat M2)
        {
            var Res = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_mprf, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
            return Res;
        }


        // Public Shared Operator +(ByVal M1 As dbl_spmat_t, ByVal m2 As Double) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_BasicArithmetic(Res.mpPtr, mp_const_plus_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator +(ByVal m2 As Double, ByVal M1 As dbl_spmat_t) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_BasicArithmetic(Res.mpPtr, mp_const_plus_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator +(ByVal M1 As dbl_spmat_t, ByVal m2 As Complex) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_plus_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator
        // 
        // 
        // Public Shared Operator +(ByVal m2 As Complex, ByVal M1 As dbl_spmat_t) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_plus_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator




        public static MpfrSpMat operator -(MpfrSpMat m1, MpfrSpMat m2)
        {
            var m3 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_mprf, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
            return m3;
        }



        // Public Shared Operator -(ByVal M1 As dbl_spmat_t, ByVal m2 As Double) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_BasicArithmetic(Res.mpPtr, mp_const_minus_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator
        // 
        // 
        // Public Shared Operator -(ByVal m2 As Double, ByVal M1 As dbl_spmat_t) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_BasicArithmetic(Res.mpPtr, mp_const_minus_scalar, M1.mpPtr, T.mpPtr)
        // Return -Res
        // End Operator



        // Public Shared Operator -(ByVal M1 As dbl_spmat_t, ByVal m2 As Complex) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_minus_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator
        // 
        // 
        // Public Shared Operator -(ByVal m2 As Complex, ByVal M1 As dbl_spmat_t) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_minus_scalar, T1.mpPtr, T.mpPtr)
        // Return -Res
        // End Operator



        public static MpfrSpMat operator *(MpfrSpMat m1, MpfrSpMat m2)
        {
            var m3 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_mprf, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
            return m3;
        }


        // Public Shared Operator *(ByVal M1 As dbl_spmat_t, ByVal m2 As Double) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_BasicArithmetic(Res.mpPtr, mp_const_times_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator *(ByVal m2 As Double, ByVal M1 As dbl_spmat_t) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_BasicArithmetic(Res.mpPtr, mp_const_times_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator *(ByVal M1 As dbl_spmat_t, ByVal m2 As Complex) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_times_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator
        // 
        // 
        // Public Shared Operator *(ByVal m2 As Complex, ByVal M1 As dbl_spmat_t) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_times_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator




        public MpfrSpMat cwiseProduct(MpfrSpMat x)
        {
            var m3 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_mprf, m3.mpPtr, constants.mp_const_cwiseProduct, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function cwiseProduct(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_cwiseProduct, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function



        public MpfrSpMat dotProduct(MpfrSpMat x)
        {
            var m3 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_mprf, m3.mpPtr, constants.mp_const_DotProduct, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function dotProduct(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_DotProduct, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function



        // Public Shared Operator /(ByVal m1 As dbl_spmat_t, ByVal m2 As dbl_spmat_t) As dbl_spmat_t
        // Dim m3 As New dbl_spmat_t()
        // Dim m4 As New dbl_spmat_t()
        // m4 = m2.inverse()
        // Lib_EigenSparse_MpAny_BasicArithmetic(m3.mpPtr, mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr)
        // Return m3
        // End Operator


        // Public Shared Operator /(ByVal M1 As dbl_spmat_t, ByVal m2 As Double) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_BasicArithmetic(Res.mpPtr, mp_const_div_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator /(ByVal M1 As dbl_spmat_t, ByVal m2 As Complex) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_div_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator



        public MpfrSpMat cwiseQuotient(MpfrSpMat x)
        {
            var m3 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_mprf, m3.mpPtr, constants.mp_const_cwiseQuotient, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function cwiseQuotient(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_cwiseQuotient, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function


        #endregion


        #region Statistical Functions (Stats)


        public MpfrSpMat sum(int PartialMode)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_mprf, m1.mpPtr, constants.mp_const_sum, PartialMode, mpPtr);
            return m1;
        }



        public MpfrSpMat prod(int PartialMode)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_mprf, m1.mpPtr, constants.mp_const_prod, PartialMode, mpPtr);
            return m1;
        }



        public MpfrSpMat mean(int PartialMode)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_mprf, m1.mpPtr, constants.mp_const_mean, PartialMode, mpPtr);
            return m1;
        }



        public MpfrSpMat minCoeff(int PartialMode)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_mprf, m1.mpPtr, constants.mp_const_minCoeff, PartialMode, mpPtr);
            return m1;
        }



        public MpfrSpMat maxCoeff(int PartialMode)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_mprf, m1.mpPtr, constants.mp_const_maxCoeff, PartialMode, mpPtr);
            return m1;
        }



        public MpfrSpMat squaredNorm(int PartialMode)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_mprf, m1.mpPtr, constants.mp_const_squaredNorm, PartialMode, mpPtr);
            return m1;
        }



        public MpfrSpMat Norm(int PartialMode)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_mprf, m1.mpPtr, constants.mp_const_Norm, PartialMode, mpPtr);
            return m1;
        }



        public MpfrSpMat stableNorm(int PartialMode)
        {
            var m1 = new MpfrSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_mprf, m1.mpPtr, constants.mp_const_stableNorm, PartialMode, mpPtr);
            return m1;
        }


        #endregion




        #region Solver

        public MpfrMat solve(MpfrMat b)
        {
            var x = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_mprf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }


        public MpfrMat SimplicialLLT_Solver(MpfrMat b)
        {
            var x = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_mprf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_llt);
            return x;
        }


        public MpfrMat SimplicialLDLT_Solver(MpfrMat b)
        {
            var x = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_mprf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_ldlt);
            return x;
        }



        public MpfrMat SparseLU_Solver(MpfrMat b)
        {
            var x = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_mprf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_lu);
            return x;
        }



        public MpfrMat SparseQR_Solver(MpfrMat b)
        {
            var x = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_mprf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }



        public MpfrMat ConjugateGradient_Solver(MpfrMat b)
        {
            var x = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_mprf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_CG_Solver);
            return x;
        }



        public MpfrMat LeastSquaresConjugateGradient_Solver(MpfrMat b)
        {
            var x = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_mprf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_LSCG_Solver);
            return x;
        }



        public MpfrMat BiCGSTAB_Solver(MpfrMat b)
        {
            var x = new MpfrMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_mprf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_BiCGSTAB_Solver);
            return x;
        }


        #endregion



    }




    public class MpfrSpMatC
    {

        public IntPtr mpPtr = IntPtr.Zero;


        #region Constructors

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Init_Func(constants.mp_mpcf);
        }



        private void Init(int m, int n = 1)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_Resize, m, n);
        }


        public MpfrSpMatC()
        {
            Init();
        }


        /// <summary>
        /// Create a new Matrix with m of rows and n columns.  
        /// </summary>
        /// <param name="m">Number of rows</param>
        /// <param name="n">Number of columns</param>
        public MpfrSpMatC(int m, int n)
        {
            Init(m, n);
        }


        // Public Sub New(x As Double)
        // Init()
        // Lib_EigenSparse_MpAny_Cplx_SetCoeff(mpPtr, x, 0, 0)
        // End Sub


        public MpfrSpMatC(MpfrSpMatC src)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_mpcf, mpPtr, constants.mp_const_fullcopy, 0, 0, 0, 0, src.mpPtr);
        }


        public MpfrSpMatC(MpfrMatC src)
        {
            Init();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_SparseFromDense(constants.mp_mpcf, mpPtr, src.mpPtr);
        }


        ~MpfrSpMatC()
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Clear(constants.mp_mpcf, mpPtr);
        }

        #endregion


        #region Input and Output


        public MpfrMatC ToDense()
        {
            var A = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_DenseFromSparse(constants.mp_mpcf, A.mpPtr, mpPtr);
            return A;
        }

        public void Print(string Title, int digits = 6)
        {
            var A = ToDense();
            A.Print(Title, digits);
            // Lib_MpAny_PrintSparseMatrix(mpPtr)
        }

        #endregion


        #region Get and Set Coefficients



        #endregion


        #region Get Info

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        /// <returns>The number of rows in the matrix</returns>
        public int rows
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_mpcf, constants.mp_const_rows, mpPtr);
            }
        }


        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        /// <returns>The number of columns in the matrix</returns>
        public int cols
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_mpcf, constants.mp_const_cols, mpPtr);
            }
        }


        public int size
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_mpcf, constants.mp_const_size, mpPtr);
            }
        }

        #endregion


        #region Get and Set Blocks, Rows, Cols, Triangular ...

        /// <summary>
        /// Gets or Sets a block
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        public MpfrSpMatC get_block(int i, int j, int p, int q)
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_mpcf, m1.mpPtr, constants.mp_const_block, i, j, p, q, mpPtr);
            return m1;
        }

        public void set_block(int i, int j, int p, int q, MpfrSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_mpcf, mpPtr, constants.mp_const_block, i, j, p, q, value.mpPtr);
        }



        public MpfrSpMatC get_row(int i)
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_mpcf, m1.mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, mpPtr);
            return m1;
        }

        public void set_row(int i, MpfrSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_mpcf, mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, value.mpPtr);
        }



        public MpfrSpMatC get_col(int j)
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_mpcf, m1.mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, mpPtr);
            return m1;
        }

        public void set_col(int j, MpfrSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_mpcf, mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, value.mpPtr);
        }




        public MpfrSpMatC get_diagonal(int q = 0)
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_mpcf, m1.mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, mpPtr);
            return m1;
        }

        public void set_diagonal(int q, MpfrSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_mpcf, mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, value.mpPtr);
        }




        public MpfrSpMatC get_triangularView(int View = 1)
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_mpcf, m1.mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, mpPtr);
            return m1;
        }

        public void set_triangularView(int View, MpfrSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_mpcf, mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, value.mpPtr);
        }



        #endregion


        #region SetSpecialValue


        public void setZero(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_setZero, n, m);
        }



        public void setOnes(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_setOnes, n, m);
        }


        public void setIdentity(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_setIdentity, n, m);
        }


        public void resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_Resize, n, m);
        }


        public void conservative_resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_conservativeResize, n, m);
        }



        public void Random(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_setRandom_nm, n, m);
        }


        public void RandomSymmetric(int n)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_setRandomSymmetric, n, n);
        }



        public void FillLinear(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_mpcf, mpPtr, constants.mp_FillLinear, n, m);
        }


        #endregion





        #region SetSpecialValue2


        public void ResizeLike(MpfrSpMatC m1)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, mpPtr, constants.mp_ResizeLike, 0, 0, 0, m1.mpPtr);
        }


        public MpfrSpMatC asDiagonal()
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_asDiagonal, 0, 0, 0, mpPtr);
            return m1;
        }


        public MpfrSpMatC adjoint()
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_adjoint, 0, 0, 0, mpPtr);
            return m1;
        }


        public MpfrSpMatC conjugate()
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_conjugate, 0, 0, 0, mpPtr);
            return m1;
        }


        public MpfrSpMatC transpose()
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_transpose, 0, 0, 0, mpPtr);
            return m1;
        }



        public MpfrSpMatC reverse_full()
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public MpfrSpMatC reverse_rowwise()
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public MpfrSpMatC reverse_colwise()
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_colwise, mpPtr);
            return m1;
        }


        public MpfrSpMatC replicate_full(int Vertical, int Horizontal)
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_replicate, Vertical, Horizontal, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public MpfrSpMatC replicate_rowwise(int Vertical)
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_replicate, Vertical, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public MpfrSpMatC replicate_colwise(int Horizontal)
        {
            var m1 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_mpcf, m1.mpPtr, constants.mp_replicate, 0, Horizontal, constants.mp_const_colwise, mpPtr);
            return m1;
        }

        #endregion


        #region Arithmetic Comparisons (Compare)



        #endregion


        #region Arithmetic Operators (BasicArithmetic)


        // Public Shared Operator +(ByVal m1 As dbl_spmat_t) As dbl_spmat_t
        // Return (1.0) * m1
        // End Operator


        // Public Shared Operator -(ByVal m1 As dbl_spmat_t) As dbl_spmat_t
        // Return (-1.0) * m1
        // End Operator




        public static MpfrSpMatC operator +(MpfrSpMatC M1, MpfrSpMatC M2)
        {
            var Res = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_mpcf, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
            return Res;
        }


        // Public Shared Operator +(ByVal M1 As dbl_spmat_t, ByVal m2 As Double) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(Res.mpPtr, mp_const_plus_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator +(ByVal m2 As Double, ByVal M1 As dbl_spmat_t) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(Res.mpPtr, mp_const_plus_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator +(ByVal M1 As dbl_spmat_t, ByVal m2 As Complex) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_plus_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator
        // 
        // 
        // Public Shared Operator +(ByVal m2 As Complex, ByVal M1 As dbl_spmat_t) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_plus_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator




        public static MpfrSpMatC operator -(MpfrSpMatC m1, MpfrSpMatC m2)
        {
            var m3 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_mpcf, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
            return m3;
        }



        // Public Shared Operator -(ByVal M1 As dbl_spmat_t, ByVal m2 As Double) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(Res.mpPtr, mp_const_minus_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator
        // 
        // 
        // Public Shared Operator -(ByVal m2 As Double, ByVal M1 As dbl_spmat_t) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(Res.mpPtr, mp_const_minus_scalar, M1.mpPtr, T.mpPtr)
        // Return -Res
        // End Operator



        // Public Shared Operator -(ByVal M1 As dbl_spmat_t, ByVal m2 As Complex) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_minus_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator
        // 
        // 
        // Public Shared Operator -(ByVal m2 As Complex, ByVal M1 As dbl_spmat_t) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_minus_scalar, T1.mpPtr, T.mpPtr)
        // Return -Res
        // End Operator



        public static MpfrSpMatC operator *(MpfrSpMatC m1, MpfrSpMatC m2)
        {
            var m3 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_mpcf, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
            return m3;
        }


        // Public Shared Operator *(ByVal M1 As dbl_spmat_t, ByVal m2 As Double) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(Res.mpPtr, mp_const_times_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator *(ByVal m2 As Double, ByVal M1 As dbl_spmat_t) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(Res.mpPtr, mp_const_times_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator *(ByVal M1 As dbl_spmat_t, ByVal m2 As Complex) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_times_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator
        // 
        // 
        // Public Shared Operator *(ByVal m2 As Complex, ByVal M1 As dbl_spmat_t) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_times_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator




        public MpfrSpMatC cwiseProduct(MpfrSpMatC x)
        {
            var m3 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_mpcf, m3.mpPtr, constants.mp_const_cwiseProduct, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function cwiseProduct(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_cwiseProduct, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function



        public MpfrSpMatC dotProduct(MpfrSpMatC x)
        {
            var m3 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_mpcf, m3.mpPtr, constants.mp_const_DotProduct, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function dotProduct(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_DotProduct, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function



        // Public Shared Operator /(ByVal m1 As dbl_spmat_t, ByVal m2 As dbl_spmat_t) As dbl_spmat_t
        // Dim m3 As New dbl_spmat_t()
        // Dim m4 As New dbl_spmat_t()
        // m4 = m2.inverse()
        // Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(m3.mpPtr, mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr)
        // Return m3
        // End Operator


        // Public Shared Operator /(ByVal M1 As dbl_spmat_t, ByVal m2 As Double) As dbl_spmat_t
        // Dim Res As New dbl_spmat_t()
        // Dim T As New dbl_spmat_t(m2)
        // Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(Res.mpPtr, mp_const_div_scalar, M1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator


        // Public Shared Operator /(ByVal M1 As dbl_spmat_t, ByVal m2 As Complex) As cplx_mat_t
        // Dim Res As New cplx_mat_t()
        // Dim T As New cplx_mat_t(m2)
        // Dim T1 As New cplx_mat_t(M1)
        // Lib_Eigen_Cplx_BasicArithmetic(Res.mpPtr, mp_const_div_scalar, T1.mpPtr, T.mpPtr)
        // Return Res
        // End Operator



        public MpfrSpMatC cwiseQuotient(MpfrSpMatC x)
        {
            var m3 = new MpfrSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_mpcf, m3.mpPtr, constants.mp_const_cwiseQuotient, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function cwiseQuotient(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_cwiseQuotient, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function


        #endregion





        #region Solver

        public MpfrMatC solve(MpfrMatC b)
        {
            var x = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_mpcf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }


        public MpfrMatC SimplicialLLT_Solver(MpfrMatC b)
        {
            var x = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_mpcf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_llt);
            return x;
        }


        public MpfrMatC SimplicialLDLT_Solver(MpfrMatC b)
        {
            var x = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_mpcf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_ldlt);
            return x;
        }



        public MpfrMatC SparseLU_Solver(MpfrMatC b)
        {
            var x = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_mpcf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_lu);
            return x;
        }



        public MpfrMatC SparseQR_Solver(MpfrMatC b)
        {
            var x = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_mpcf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }



        public MpfrMatC ConjugateGradient_Solver(MpfrMatC b)
        {
            var x = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_mpcf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_CG_Solver);
            return x;
        }



        public MpfrMatC LeastSquaresConjugateGradient_Solver(MpfrMatC b)
        {
            var x = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_mpcf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_LSCG_Solver);
            return x;
        }



        public MpfrMatC BiCGSTAB_Solver(MpfrMatC b)
        {
            var x = new MpfrMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_mpcf, x.mpPtr, mpPtr, b.mpPtr, constants.mp_BiCGSTAB_Solver);
            return x;
        }


        #endregion



    }





}