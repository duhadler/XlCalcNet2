
using System;

namespace ArbPrecNet
{


    public class ArbMatMap
    {

        public IntPtr mpPtr = IntPtr.Zero;

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Interop.Lib_Init_Func(constants.mp_map, constants.mp_apr);
        }


        public ArbMatMap()
        {
            Init();
        }




        ~ArbMatMap()
        {
            Interop.Lib_Clear(constants.mp_map, constants.mp_apr, mpPtr);
        }


        public ArbMat this[string s]
        {
            get
            {
                var res = new ArbMat();
                Interop.Lib_Map_GetItemValue(constants.mp_eigen, constants.mp_apr, res.mpPtr, mpPtr, s);
                return res;
            }
        }



    }



    public class ArbMat : fpMatMethods2<Arb, Arb, ArbMat, ArbMat, Arb, ArbMat, ArbMat, ArbMatMap>
    {

        public ArbMat()
        {
            Init();
        }



        public ArbSpMat ToSparse()
        {
            var res = new ArbSpMat();
            AnyLibSparse.EigenSparseLib_MpAny_SparseFromDense(constants.mp_apr, res.mpPtr, mpPtr);
            return res;
        }



        ~ArbMat()
        {
            Interop.Lib_Clear(constants.mp_eigen, constants.mp_apr, mpPtr);
        }







        #region Arithmetic Comparisons (Compare)

        public static bool operator ==(ArbMat m1, ArbMat m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_apr, constants.mp_const_EQ, m1.mpPtr, m2.mpPtr) == m1.size;
        }


        public static bool operator !=(ArbMat m1, ArbMat m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_apr, constants.mp_const_NE, m1.mpPtr, m2.mpPtr) == m1.size;

        }

        #endregion


        #region Arithmetic Operators (BasicArithmetic)

        public static ArbMat operator +(ArbMat m1)
        {
            var m2 = aflint.t(0.0d);
            return m1 + m2;
        }

        public static ArbMat operator -(ArbMat m1)
        {
            var m2 = aflint.t(-1.0d);
            return m2 * m1;
        }


        public static ArbMat operator +(ArbMat M1, ArbMat M2)
        {
            var Res = new ArbMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
            return Res;
        }

        public static ArbMat operator +(ArbMat M1, Arb m2)
        {
            var Res = new ArbMat();
            var t = aflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static ArbMatC operator +(ArbMat m1, ArbMatC m2)
        {
            var m3 = new ArbMatC();
            var T1 = aflintc.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_plus, T1.mpPtr, m2.mpPtr);
            return m3;
        }




        public static ArbMat operator -(ArbMat m1, ArbMat m2)
        {
            var m3 = new ArbMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
            return m3;
        }

        public static ArbMat operator -(ArbMat M1, Arb m2)
        {
            var Res = new ArbMat();
            var t = aflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static ArbMatC operator -(ArbMat m1, ArbMatC m2)
        {
            var m3 = new ArbMatC();
            var T1 = aflintc.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_minus, T1.mpPtr, m2.mpPtr);
            return m3;
        }





        public static ArbMat operator *(ArbMat m1, ArbMat m2)
        {
            var m3 = new ArbMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
            return m3;
        }

        public static ArbMat operator *(ArbMat M1, Arb m2)
        {
            var Res = new ArbMat();
            var t = aflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static ArbMatC operator *(ArbMat m1, ArbMatC m2)
        {
            var m3 = new ArbMatC();
            var T1 = aflintc.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_MatrixProduct, T1.mpPtr, m2.mpPtr);
            return m3;
        }





        public static ArbMat operator /(ArbMat m1, ArbMat m2)
        {
            var m3 = new ArbMat();
            var m4 = new ArbMat();
            m4 = m2.Inverse();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }

        public static ArbMat operator /(ArbMat M1, Arb m2)
        {
            var Res = new ArbMat();
            var t = aflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, Res.mpPtr, constants.mp_const_div_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static ArbMatC operator /(ArbMat m1, ArbMatC m2)
        {
            var m3 = new ArbMatC();
            var m4 = new ArbMatC();
            m4 = m2.Inverse();
            var T1 = aflintc.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_MatrixProduct, T1.mpPtr, m4.mpPtr);
            return m3;
        }





        #endregion



    }






    public class ArbMatMapC
    {

        public IntPtr mpPtr = IntPtr.Zero;

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Interop.Lib_Init_Func(constants.mp_map, constants.mp_apc);
        }


        public ArbMatMapC()
        {
            Init();
        }



        ~ArbMatMapC()
        {
            Interop.Lib_Clear(constants.mp_map, constants.mp_apc, mpPtr);
        }


        public ArbMatC this[string s]
        {
            get
            {
                var res = new ArbMatC();
                Interop.Lib_Map_GetItemValue(constants.mp_eigen, constants.mp_apc, res.mpPtr, mpPtr, s);
                return res;
            }
        }

    }



    public class ArbMatC : CplxMatMethods<ArbC, ArbC, ArbMatC, ArbMat, ArbC, ArbMatC, ArbMat, ArbMatMapC, ArbMat>
    {


        public ArbMatC()
        {
            Init();
        }


        public bool IsComplex()
        {
            return true;
        }



        public ArbSpMatC ToSparse()
        {
            var res = new ArbSpMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_SparseFromDense(constants.mp_apc, res.mpPtr, mpPtr);
            return res;
        }



        ~ArbMatC()
        {
            Interop.Lib_Clear(constants.mp_eigen, constants.mp_apc, mpPtr);
        }








        #region Arithmetic Comparisons (Compare)


        public static bool operator ==(ArbMatC m1, ArbMatC m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_apc, constants.mp_const_EQ, m1.mpPtr, m2.mpPtr) == m1.size;
        }


        public static bool operator !=(ArbMatC m1, ArbMatC m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_apc, constants.mp_const_NE, m1.mpPtr, m2.mpPtr) == m1.size;
        }

        #endregion


        #region Arithmetic Operators (BasicArithmetic)


        public static ArbMatC operator +(ArbMatC m1)
        {
            return m1 + aflintc.t(0);
        }


        public static ArbMatC operator -(ArbMatC m1)
        {
            return aflintc.t(-1) * m1;
        }




        public static ArbMatC operator +(ArbMatC M1, ArbMatC M2)
        {
            var Res = new ArbMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
            return Res;
        }


        public static ArbMatC operator +(ArbMatC m1, ArbMat m2)
        {
            var m3 = new ArbMatC();
            var T2 = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_plus, m1.mpPtr, T2.mpPtr);
            return m3;
        }


        public static ArbMatC operator +(ArbMatC M1, ArbC m2)
        {
            var Res = new ArbMatC();
            var t = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }





        public static ArbMatC operator -(ArbMatC m1, ArbMatC m2)
        {
            var m3 = new ArbMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
            return m3;
        }


        public static ArbMatC operator -(ArbMatC m1, ArbMat m2)
        {
            var m3 = new ArbMatC();
            var T2 = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, T2.mpPtr);
            return m3;
        }


        public static ArbMatC operator -(ArbMatC M1, ArbC m2)
        {
            var Res = new ArbMatC();
            var t = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }




        public static ArbMatC operator *(ArbMatC m1, ArbMatC m2)
        {
            var m3 = new ArbMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
            return m3;
        }


        public static ArbMatC operator *(ArbMatC m1, ArbMat m2)
        {
            var m3 = new ArbMatC();
            var T2 = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, T2.mpPtr);
            return m3;
        }


        public static ArbMatC operator *(ArbMatC M1, ArbC m2)
        {
            var Res = new ArbMatC();
            var t = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }





        public static ArbMatC operator /(ArbMatC m1, ArbMatC m2)
        {
            var m3 = new ArbMatC();
            var m4 = new ArbMatC();
            m4 = m2.Inverse();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }



        public static ArbMatC operator /(ArbMatC m1, ArbMat m2)
        {
            var m3 = new ArbMatC();
            var m4 = aflintc.mat_t(m2.Inverse());
            // m4 = m2.inverse()
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }



        public static ArbMatC operator /(ArbMatC M1, ArbC m2)
        {
            var Res = new ArbMatC();
            var t = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, Res.mpPtr, constants.mp_const_div_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        #endregion



    }






    public class ArbSpMat
    {

        public IntPtr mpPtr = IntPtr.Zero;


        #region Constructors

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = AnyLibSparse.Lib_EigenSparse_MpAny_Init_Func(constants.mp_apr);
        }



        private void Init(int m, int n = 1)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_Resize, m, n);
        }


        public ArbSpMat()
        {
            Init();
        }


        /// <summary>
        /// Create a new Matrix with m of rows and n columns.  
        /// </summary>
        /// <param name="m">Number of rows</param>
        /// <param name="n">Number of columns</param>
        public ArbSpMat(int m, int n)
        {
            Init(m, n);
        }


        // Public Sub New(x As Double)
        // Init()
        // Lib_EigenSparse_MpAny_SetCoeff(mpPtr, x, 0, 0)
        // End Sub


        public ArbSpMat(ArbSpMat src)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_apr, mpPtr, constants.mp_const_fullcopy, 0, 0, 0, 0, src.mpPtr);
        }


        public ArbSpMat(ArbMat src)
        {
            Init();
            AnyLibSparse.EigenSparseLib_MpAny_SparseFromDense(constants.mp_apr, mpPtr, src.mpPtr);
        }


        ~ArbSpMat()
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Clear(constants.mp_apr, mpPtr);
        }

        #endregion


        #region Input and Output


        public ArbMat ToDense()
        {
            var A = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_DenseFromSparse(constants.mp_apr, A.mpPtr, mpPtr);
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
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_apr, constants.mp_const_rows, mpPtr);
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
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_apr, constants.mp_const_cols, mpPtr);
            }
        }


        public int size
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_apr, constants.mp_const_size, mpPtr);
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
        public ArbSpMat get_block(int i, int j, int p, int q)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_apr, m1.mpPtr, constants.mp_const_block, i, j, p, q, mpPtr);
            return m1;
        }

        public void set_block(int i, int j, int p, int q, ArbSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_apr, mpPtr, constants.mp_const_block, i, j, p, q, value.mpPtr);
        }



        public ArbSpMat get_row(int i)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_apr, m1.mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, mpPtr);
            return m1;
        }

        public void set_row(int i, ArbSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_apr, mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, value.mpPtr);
        }



        public ArbSpMat get_col(int j)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_apr, m1.mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, mpPtr);
            return m1;
        }

        public void set_col(int j, ArbSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_apr, mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, value.mpPtr);
        }




        public ArbSpMat get_diagonal(int q = 0)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_apr, m1.mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, mpPtr);
            return m1;
        }

        public void set_diagonal(int q, ArbSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_apr, mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, value.mpPtr);
        }




        public ArbSpMat get_triangularView(int View = 1)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_apr, m1.mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, mpPtr);
            return m1;
        }

        public void set_triangularView(int View, ArbSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_apr, mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, value.mpPtr);
        }



        #endregion


        #region SetSpecialValue


        public void setZero(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_setZero, n, m);
        }



        public void setOnes(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_setOnes, n, m);
        }


        public void setIdentity(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_setIdentity, n, m);
        }


        public void resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_Resize, n, m);
        }


        public void conservative_resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_conservativeResize, n, m);
        }



        public void Random(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_setRandom_nm, n, m);
        }


        public void RandomSymmetric(int n)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_setRandomSymmetric, n, n);
        }



        public void FillLinear(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_apr, mpPtr, constants.mp_FillLinear, n, m);
        }


        #endregion





        #region SetSpecialValue2


        public void ResizeLike(ArbSpMat m1)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, mpPtr, constants.mp_ResizeLike, 0, 0, 0, m1.mpPtr);
        }


        public ArbSpMat asDiagonal()
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_asDiagonal, 0, 0, 0, mpPtr);
            return m1;
        }


        public ArbSpMat adjoint()
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_adjoint, 0, 0, 0, mpPtr);
            return m1;
        }


        public ArbSpMat conjugate()
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_conjugate, 0, 0, 0, mpPtr);
            return m1;
        }


        public ArbSpMat transpose()
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_transpose, 0, 0, 0, mpPtr);
            return m1;
        }



        public ArbSpMat reverse_full()
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public ArbSpMat reverse_rowwise()
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public ArbSpMat reverse_colwise()
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_colwise, mpPtr);
            return m1;
        }


        public ArbSpMat replicate_full(int Vertical, int Horizontal)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_replicate, Vertical, Horizontal, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public ArbSpMat replicate_rowwise(int Vertical)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_replicate, Vertical, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public ArbSpMat replicate_colwise(int Horizontal)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_apr, m1.mpPtr, constants.mp_replicate, 0, Horizontal, constants.mp_const_colwise, mpPtr);
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




        public static ArbSpMat operator +(ArbSpMat M1, ArbSpMat M2)
        {
            var Res = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_apr, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
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




        public static ArbSpMat operator -(ArbSpMat m1, ArbSpMat m2)
        {
            var m3 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_apr, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
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



        public static ArbSpMat operator *(ArbSpMat m1, ArbSpMat m2)
        {
            var m3 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_apr, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
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




        public ArbSpMat cwiseProduct(ArbSpMat x)
        {
            var m3 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_apr, m3.mpPtr, constants.mp_const_cwiseProduct, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function cwiseProduct(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_cwiseProduct, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function



        public ArbSpMat dotProduct(ArbSpMat x)
        {
            var m3 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_apr, m3.mpPtr, constants.mp_const_DotProduct, x.mpPtr, mpPtr);
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



        public ArbSpMat cwiseQuotient(ArbSpMat x)
        {
            var m3 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_apr, m3.mpPtr, constants.mp_const_cwiseQuotient, x.mpPtr, mpPtr);
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


        public ArbSpMat sum(int PartialMode)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_apr, m1.mpPtr, constants.mp_const_sum, PartialMode, mpPtr);
            return m1;
        }



        public ArbSpMat prod(int PartialMode)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_apr, m1.mpPtr, constants.mp_const_prod, PartialMode, mpPtr);
            return m1;
        }



        public ArbSpMat mean(int PartialMode)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_apr, m1.mpPtr, constants.mp_const_mean, PartialMode, mpPtr);
            return m1;
        }



        public ArbSpMat minCoeff(int PartialMode)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_apr, m1.mpPtr, constants.mp_const_minCoeff, PartialMode, mpPtr);
            return m1;
        }



        public ArbSpMat maxCoeff(int PartialMode)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_apr, m1.mpPtr, constants.mp_const_maxCoeff, PartialMode, mpPtr);
            return m1;
        }



        public ArbSpMat squaredNorm(int PartialMode)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_apr, m1.mpPtr, constants.mp_const_squaredNorm, PartialMode, mpPtr);
            return m1;
        }



        public ArbSpMat Norm(int PartialMode)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_apr, m1.mpPtr, constants.mp_const_Norm, PartialMode, mpPtr);
            return m1;
        }



        public ArbSpMat stableNorm(int PartialMode)
        {
            var m1 = new ArbSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_apr, m1.mpPtr, constants.mp_const_stableNorm, PartialMode, mpPtr);
            return m1;
        }


        #endregion




        #region Solver

        public ArbMat solve(ArbMat b)
        {
            var x = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_apr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }


        public ArbMat SimplicialLLT_Solver(ArbMat b)
        {
            var x = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_apr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_llt);
            return x;
        }


        public ArbMat SimplicialLDLT_Solver(ArbMat b)
        {
            var x = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_apr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_ldlt);
            return x;
        }



        public ArbMat SparseLU_Solver(ArbMat b)
        {
            var x = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_apr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_lu);
            return x;
        }



        public ArbMat SparseQR_Solver(ArbMat b)
        {
            var x = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_apr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }



        public ArbMat ConjugateGradient_Solver(ArbMat b)
        {
            var x = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_apr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_CG_Solver);
            return x;
        }



        public ArbMat LeastSquaresConjugateGradient_Solver(ArbMat b)
        {
            var x = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_apr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_LSCG_Solver);
            return x;
        }



        public ArbMat BiCGSTAB_Solver(ArbMat b)
        {
            var x = new ArbMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_apr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_BiCGSTAB_Solver);
            return x;
        }


        #endregion



    }




    public class ArbSpMatC
    {

        public IntPtr mpPtr = IntPtr.Zero;


        #region Constructors

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Init_Func(constants.mp_apc);
        }



        private void Init(int m, int n = 1)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_Resize, m, n);
        }


        public ArbSpMatC()
        {
            Init();
        }


        /// <summary>
        /// Create a new Matrix with m of rows and n columns.  
        /// </summary>
        /// <param name="m">Number of rows</param>
        /// <param name="n">Number of columns</param>
        public ArbSpMatC(int m, int n)
        {
            Init(m, n);
        }


        // Public Sub New(x As Double)
        // Init()
        // Lib_EigenSparse_MpAny_Cplx_SetCoeff(mpPtr, x, 0, 0)
        // End Sub


        public ArbSpMatC(ArbSpMatC src)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_apc, mpPtr, constants.mp_const_fullcopy, 0, 0, 0, 0, src.mpPtr);
        }


        public ArbSpMatC(ArbMatC src)
        {
            Init();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_SparseFromDense(constants.mp_apc, mpPtr, src.mpPtr);
        }


        ~ArbSpMatC()
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Clear(constants.mp_apc, mpPtr);
        }

        #endregion


        #region Input and Output


        public ArbMatC ToDense()
        {
            var A = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_DenseFromSparse(constants.mp_apc, A.mpPtr, mpPtr);
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
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_apc, constants.mp_const_rows, mpPtr);
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
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_apc, constants.mp_const_cols, mpPtr);
            }
        }


        public int size
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_apc, constants.mp_const_size, mpPtr);
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
        public ArbSpMatC get_block(int i, int j, int p, int q)
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_apc, m1.mpPtr, constants.mp_const_block, i, j, p, q, mpPtr);
            return m1;
        }

        public void set_block(int i, int j, int p, int q, ArbSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_apc, mpPtr, constants.mp_const_block, i, j, p, q, value.mpPtr);
        }



        public ArbSpMatC get_row(int i)
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_apc, m1.mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, mpPtr);
            return m1;
        }

        public void set_row(int i, ArbSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_apc, mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, value.mpPtr);
        }



        public ArbSpMatC get_col(int j)
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_apc, m1.mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, mpPtr);
            return m1;
        }

        public void set_col(int j, ArbSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_apc, mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, value.mpPtr);
        }




        public ArbSpMatC get_diagonal(int q = 0)
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_apc, m1.mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, mpPtr);
            return m1;
        }

        public void set_diagonal(int q, ArbSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_apc, mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, value.mpPtr);
        }




        public ArbSpMatC get_triangularView(int View = 1)
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_apc, m1.mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, mpPtr);
            return m1;
        }

        public void set_triangularView(int View, ArbSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_apc, mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, value.mpPtr);
        }



        #endregion


        #region SetSpecialValue


        public void setZero(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_setZero, n, m);
        }



        public void setOnes(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_setOnes, n, m);
        }


        public void setIdentity(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_setIdentity, n, m);
        }


        public void resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_Resize, n, m);
        }


        public void conservative_resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_conservativeResize, n, m);
        }



        public void Random(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_setRandom_nm, n, m);
        }


        public void RandomSymmetric(int n)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_setRandomSymmetric, n, n);
        }



        public void FillLinear(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_apc, mpPtr, constants.mp_FillLinear, n, m);
        }


        #endregion





        #region SetSpecialValue2


        public void ResizeLike(ArbSpMatC m1)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, mpPtr, constants.mp_ResizeLike, 0, 0, 0, m1.mpPtr);
        }


        public ArbSpMatC asDiagonal()
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_asDiagonal, 0, 0, 0, mpPtr);
            return m1;
        }


        public ArbSpMatC adjoint()
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_adjoint, 0, 0, 0, mpPtr);
            return m1;
        }


        public ArbSpMatC conjugate()
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_conjugate, 0, 0, 0, mpPtr);
            return m1;
        }


        public ArbSpMatC transpose()
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_transpose, 0, 0, 0, mpPtr);
            return m1;
        }



        public ArbSpMatC reverse_full()
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public ArbSpMatC reverse_rowwise()
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public ArbSpMatC reverse_colwise()
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_colwise, mpPtr);
            return m1;
        }


        public ArbSpMatC replicate_full(int Vertical, int Horizontal)
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_replicate, Vertical, Horizontal, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public ArbSpMatC replicate_rowwise(int Vertical)
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_replicate, Vertical, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public ArbSpMatC replicate_colwise(int Horizontal)
        {
            var m1 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_apc, m1.mpPtr, constants.mp_replicate, 0, Horizontal, constants.mp_const_colwise, mpPtr);
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




        public static ArbSpMatC operator +(ArbSpMatC M1, ArbSpMatC M2)
        {
            var Res = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_apc, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
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




        public static ArbSpMatC operator -(ArbSpMatC m1, ArbSpMatC m2)
        {
            var m3 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_apc, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
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



        public static ArbSpMatC operator *(ArbSpMatC m1, ArbSpMatC m2)
        {
            var m3 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_apc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
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




        public ArbSpMatC cwiseProduct(ArbSpMatC x)
        {
            var m3 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_apc, m3.mpPtr, constants.mp_const_cwiseProduct, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function cwiseProduct(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_cwiseProduct, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function



        public ArbSpMatC dotProduct(ArbSpMatC x)
        {
            var m3 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_apc, m3.mpPtr, constants.mp_const_DotProduct, x.mpPtr, mpPtr);
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



        public ArbSpMatC cwiseQuotient(ArbSpMatC x)
        {
            var m3 = new ArbSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_apc, m3.mpPtr, constants.mp_const_cwiseQuotient, x.mpPtr, mpPtr);
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

        public ArbMatC solve(ArbMatC b)
        {
            var x = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_apc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }


        public ArbMatC SimplicialLLT_Solver(ArbMatC b)
        {
            var x = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_apc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_llt);
            return x;
        }


        public ArbMatC SimplicialLDLT_Solver(ArbMatC b)
        {
            var x = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_apc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_ldlt);
            return x;
        }



        public ArbMatC SparseLU_Solver(ArbMatC b)
        {
            var x = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_apc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_lu);
            return x;
        }



        public ArbMatC SparseQR_Solver(ArbMatC b)
        {
            var x = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_apc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }



        public ArbMatC ConjugateGradient_Solver(ArbMatC b)
        {
            var x = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_apc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_CG_Solver);
            return x;
        }



        public ArbMatC LeastSquaresConjugateGradient_Solver(ArbMatC b)
        {
            var x = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_apc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_LSCG_Solver);
            return x;
        }



        public ArbMatC BiCGSTAB_Solver(ArbMatC b)
        {
            var x = new ArbMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_apc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_BiCGSTAB_Solver);
            return x;
        }


        #endregion



    }






}