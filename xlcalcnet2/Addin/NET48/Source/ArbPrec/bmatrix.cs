
using System;

namespace ArbPrecNet
{


    public class BigDecimalMap
    {

        public IntPtr mpPtr = IntPtr.Zero;

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Interop.Lib_Init_Func(constants.mp_map, constants.mp_dpr);
        }


        public BigDecimalMap()
        {
            Init();
        }


        ~BigDecimalMap()
        {
            Interop.Lib_Clear(constants.mp_map, constants.mp_dpr, mpPtr);
        }


        public BigDecimalMat this[string s]
        {
            get
            {
                var res = new BigDecimalMat();
                Interop.Lib_Map_GetItemValue(constants.mp_eigen, constants.mp_dpr, res.mpPtr, mpPtr, s);
                return res;
            }
        }

    }



    public class BigDecimalMat : RealMatMethods3<BigDecimal, BigDecimal, BigDecimalMat, BigDecimalMat, BigDecimal, BigDecimalMat, BigDecimalMat, BigDecimalMap, BigDecimalMapC, BigDecimalC, BigDecimalMatC, BigDecimalMatC>
    {

        public BigDecimalMat()
        {
            Init();
        }



        public BigDecimalSpMat ToSparse()
        {
            var res = new BigDecimalSpMat();
            AnyLibSparse.EigenSparseLib_MpAny_SparseFromDense(constants.mp_dpr, res.mpPtr, mpPtr);
            return res;
        }






        ~BigDecimalMat()
        {
            Interop.Lib_Clear(constants.mp_eigen, constants.mp_dpr, mpPtr);
        }






        #region Arithmetic Comparisons (Compare)

        public static bool operator ==(BigDecimalMat m1, BigDecimalMat m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_dpr, constants.mp_const_EQ, m1.mpPtr, m2.mpPtr) == m1.size;
        }


        public static bool operator !=(BigDecimalMat m1, BigDecimalMat m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_dpr, constants.mp_const_NE, m1.mpPtr, m2.mpPtr) == m1.size;
        }

        #endregion


        #region Arithmetic Operators (BasicArithmetic)

        public static BigDecimalMat operator +(BigDecimalMat m1)
        {
            var m2 = bflint.t(0.0d);
            return m1 + m2;
        }

        public static BigDecimalMat operator -(BigDecimalMat m1)
        {
            var m2 = bflint.t(-1.0d);
            return m2 * m1;
        }





        public static BigDecimalMat operator +(BigDecimalMat M1, BigDecimalMat M2)
        {
            var Res = new BigDecimalMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
            return Res;
        }

        public static BigDecimalMat operator +(BigDecimalMat M1, BigDecimal m2)
        {
            var Res = new BigDecimalMat();
            var t = bflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }

        public static BigDecimalMat operator +(BigDecimal m2, BigDecimalMat M1)
        {
            var Res = new BigDecimalMat();
            var t = bflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }





        public static BigDecimalMatC operator +(BigDecimalMat M1, BigDecimalC m2)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            var T1 = bflintc.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_plus_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static BigDecimalMatC operator +(BigDecimalC m2, BigDecimalMat M1)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            var T1 = bflintc.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_plus_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }







        public static BigDecimalMat operator -(BigDecimalMat M1, BigDecimalMat M2)
        {
            var Res = new BigDecimalMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_minus, M1.mpPtr, M2.mpPtr);
            return Res;
        }

        public static BigDecimalMat operator -(BigDecimalMat M1, BigDecimal m2)
        {
            var Res = new BigDecimalMat();
            var t = bflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }

        public static BigDecimalMat operator -(BigDecimal m2, BigDecimalMat M1)
        {
            var Res = new BigDecimalMat();
            var t = bflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return -Res;
        }






        public static BigDecimalMatC operator -(BigDecimalMat M1, BigDecimalC m2)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            var T1 = bflintc.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_minus_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static BigDecimalMatC operator -(BigDecimalC m2, BigDecimalMat M1)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            var T1 = bflintc.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_minus_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }








        public static BigDecimalMat operator *(BigDecimalMat m1, BigDecimalMat m2)
        {
            var m3 = new BigDecimalMat();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
            return m3;
        }

        public static BigDecimalMat operator *(BigDecimalMat M1, BigDecimal m2)
        {
            var Res = new BigDecimalMat();
            var t = bflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }

        public static BigDecimalMat operator *(BigDecimal m2, BigDecimalMat M1)
        {
            var Res = new BigDecimalMat();
            var t = bflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }







        public static BigDecimalMatC operator *(BigDecimalMat M1, BigDecimalC m2)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            var T1 = bflintc.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_times_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static BigDecimalMatC operator *(BigDecimalC m2, BigDecimalMat M1)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            var T1 = bflintc.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_times_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }







        public static BigDecimalMat operator /(BigDecimalMat m1, BigDecimalMat m2)
        {
            var m3 = new BigDecimalMat();
            var m4 = new BigDecimalMat();
            m4 = m2.Inverse();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }

        public static BigDecimalMat operator /(BigDecimalMat M1, BigDecimal m2)
        {
            var Res = new BigDecimalMat();
            var t = bflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpr, Res.mpPtr, constants.mp_const_div_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }



        public static BigDecimalMatC operator /(BigDecimalMat M1, BigDecimalC m2)
        {
            var Res = new BigDecimalMatC();
            //var t = bigdecmatc.t(m2);
            //var T1 = bigdecmatc.t(M1);
            var t = bflintc.mat_t(m2);
            var T1 = bflintc.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_div_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }







        #endregion





    }






    public class BigDecimalMapC
    {

        public IntPtr mpPtr = IntPtr.Zero;

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Interop.Lib_Init_Func(constants.mp_map, constants.mp_dpc);
        }


        public BigDecimalMapC()
        {
            Init();
        }



        ~BigDecimalMapC()
        {
            Interop.Lib_Clear(constants.mp_map, constants.mp_dpc, mpPtr);
        }


        public BigDecimalMatC this[string s]
        {
            get
            {
                var res = new BigDecimalMatC();
                Interop.Lib_Map_GetItemValue(constants.mp_eigen, constants.mp_dpc, res.mpPtr, mpPtr, s);
                return res;
            }
        }

    }



    public class BigDecimalMatC : CplxMatMethods<BigDecimalC, BigDecimalC, BigDecimalMatC, BigDecimalMat, BigDecimalC, BigDecimalMatC, BigDecimalMat, BigDecimalMapC, BigDecimalMat>
    {

        public BigDecimalMatC()
        {
            Init();
        }



        public BigDecimalSpMatC ToSparse()
        {
            var res = new BigDecimalSpMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_SparseFromDense(constants.mp_dpc, res.mpPtr, mpPtr);
            return res;
        }




        ~BigDecimalMatC()
        {
            Interop.Lib_Clear(constants.mp_eigen, constants.mp_dpc, mpPtr);
        }







        #region Arithmetic Comparisons (Compare)


        public static bool operator ==(BigDecimalMatC m1, BigDecimalMatC m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_dpc, constants.mp_const_EQ, m1.mpPtr, m2.mpPtr) == m1.size;
        }


        public static bool operator !=(BigDecimalMatC m1, BigDecimalMatC m2)
        {
            return Interop.Lib_Eigen_Compare(constants.mp_eigen, constants.mp_dpc, constants.mp_const_NE, m1.mpPtr, m2.mpPtr) == m1.size;
        }

        #endregion


        #region Arithmetic Operators (BasicArithmetic)



        public static BigDecimalMatC operator +(BigDecimalMatC m1)
        {
            var m2 = bflintc.t(0.0d);
            return m1 + m2;
        }

        public static BigDecimalMatC operator -(BigDecimalMatC m1)
        {
            var m2 = bflintc.t(-1.0d);
            return m2 * m1;
        }



        public static BigDecimalMatC operator +(BigDecimalMatC M1, BigDecimalMatC M2)
        {
            var Res = new BigDecimalMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
            return Res;
        }


        public static BigDecimalMatC operator +(BigDecimalMatC m1, BigDecimalMat m2)
        {
            var m3 = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_plus, m1.mpPtr, t.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator +(BigDecimalMat m1, BigDecimalMatC m2)
        {
            var m3 = new BigDecimalMatC();
            var t = bflintc.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_plus, t.mpPtr, m2.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator +(BigDecimalMatC M1, BigDecimalC m2)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static BigDecimalMatC operator +(BigDecimalC m2, BigDecimalMatC M1)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }






        public static BigDecimalMatC operator -(BigDecimalMatC m1, BigDecimalMatC m2)
        {
            var m3 = new BigDecimalMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator -(BigDecimalMatC m1, BigDecimalMat m2)
        {
            var m3 = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, t.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator -(BigDecimalMat m1, BigDecimalMatC m2)
        {
            var m3 = new BigDecimalMatC();
            var t = bflintc.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_minus, t.mpPtr, m2.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator -(BigDecimalMatC M1, BigDecimalC m2)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static BigDecimalMatC operator -(BigDecimalC m2, BigDecimalMatC M1)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return -Res;
        }






        public static BigDecimalMatC operator *(BigDecimalMatC m1, BigDecimalMatC m2)
        {
            var m3 = new BigDecimalMatC();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator *(BigDecimalMatC m1, BigDecimalMat m2)
        {
            var m3 = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, t.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator *(BigDecimalMat m1, BigDecimalMatC m2)
        {
            var m3 = new BigDecimalMatC();
            var t = bflintc.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_MatrixProduct, t.mpPtr, m2.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator *(BigDecimalMatC M1, BigDecimalC m2)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }


        public static BigDecimalMatC operator *(BigDecimalC m2, BigDecimalMatC M1)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }








        public static BigDecimalMatC operator /(BigDecimalMatC m1, BigDecimalMatC m2)
        {
            var m3 = new BigDecimalMatC();
            var m4 = new BigDecimalMatC();
            m4 = m2.Inverse();
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }



        public static BigDecimalMatC operator /(BigDecimalMatC m1, BigDecimalMat m2)
        {
            var m3 = new BigDecimalMatC();
            var m4 = bflintc.mat_t(m2.Inverse());
            // m4 = m2.inverse()
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m4.mpPtr);
            return m3;
        }


        public static BigDecimalMatC operator /(BigDecimalMat m1, BigDecimalMatC m2)
        {
            var m3 = new BigDecimalMatC();
            var m4 = new BigDecimalMatC();
            m4 = m2.Inverse();
            var t = bflintc.mat_t(m1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, m3.mpPtr, constants.mp_const_MatrixProduct, t.mpPtr, m4.mpPtr);
            return m3;
        }



        public static BigDecimalMatC operator /(BigDecimalMatC M1, BigDecimalC m2)
        {
            var Res = new BigDecimalMatC();
            var t = bflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_dpc, Res.mpPtr, constants.mp_const_div_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }




        #endregion



    }






    public class BigDecimalSpMat
    {

        public IntPtr mpPtr = default;


        #region Constructors

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = AnyLibSparse.Lib_EigenSparse_MpAny_Init_Func(constants.mp_dpr);
        }



        private void Init(int m, int n = 1)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_Resize, m, n);
        }


        public BigDecimalSpMat()
        {
            Init();
        }


        /// <summary>
        /// Create a new Matrix with m of rows and n columns.  
        /// </summary>
        /// <param name="m">Number of rows</param>
        /// <param name="n">Number of columns</param>
        public BigDecimalSpMat(int m, int n)
        {
            Init(m, n);
        }


        // Public Sub New(x As Double)
        // Init()
        // Lib_EigenSparse_MpAny_SetCoeff(mpPtr, x, 0, 0)
        // End Sub


        public BigDecimalSpMat(BigDecimalSpMat src)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_dpr, mpPtr, constants.mp_const_fullcopy, 0, 0, 0, 0, src.mpPtr);
        }


        public BigDecimalSpMat(BigDecimalMat src)
        {
            Init();
            AnyLibSparse.EigenSparseLib_MpAny_SparseFromDense(constants.mp_dpr, mpPtr, src.mpPtr);
        }


        ~BigDecimalSpMat()
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Clear(constants.mp_dpr, mpPtr);
        }

        #endregion


        #region Input and Output


        public BigDecimalMat ToDense()
        {
            var A = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_DenseFromSparse(constants.mp_dpr, A.mpPtr, mpPtr);
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
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_dpr, constants.mp_const_rows, mpPtr);
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
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_dpr, constants.mp_const_cols, mpPtr);
            }
        }


        public int size
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_GetInfo(constants.mp_dpr, constants.mp_const_size, mpPtr);
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
        public BigDecimalSpMat get_block(int i, int j, int p, int q)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_dpr, m1.mpPtr, constants.mp_const_block, i, j, p, q, mpPtr);
            return m1;
        }

        public void set_block(int i, int j, int p, int q, BigDecimalSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_dpr, mpPtr, constants.mp_const_block, i, j, p, q, value.mpPtr);
        }



        public BigDecimalSpMat get_row(int i)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_dpr, m1.mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, mpPtr);
            return m1;
        }

        public void set_row(int i, BigDecimalSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_dpr, mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, value.mpPtr);
        }



        public BigDecimalSpMat get_col(int j)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_dpr, m1.mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, mpPtr);
            return m1;
        }

        public void set_col(int j, BigDecimalSpMat value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_dpr, mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, value.mpPtr);
        }




        public BigDecimalSpMat get_diagonal(int q = 0)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_dpr, m1.mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, mpPtr);
            return m1;
        }

        public void set_diagonal(int q = 0, BigDecimalSpMat value = default)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_dpr, mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, value.mpPtr);
        }




        public BigDecimalSpMat get_triangularView(int View = 1)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Get_Block(constants.mp_dpr, m1.mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, mpPtr);
            return m1;
        }

        public void set_triangularView(int View = 1, BigDecimalSpMat value = default)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Put_Block(constants.mp_dpr, mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, value.mpPtr);
        }



        #endregion


        #region SetSpecialValue


        public void setZero(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_setZero, n, m);
        }



        public void setOnes(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_setOnes, n, m);
        }


        public void setIdentity(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_setIdentity, n, m);
        }


        public void resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_Resize, n, m);
        }


        public void conservative_resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_conservativeResize, n, m);
        }



        public void Random(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_setRandom_nm, n, m);
        }


        public void RandomSymmetric(int n)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_setRandomSymmetric, n, n);
        }



        public void FillLinear(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue(constants.mp_dpr, mpPtr, constants.mp_FillLinear, n, m);
        }


        #endregion





        #region SetSpecialValue2


        public void ResizeLike(BigDecimalSpMat m1)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, mpPtr, constants.mp_ResizeLike, 0, 0, 0, m1.mpPtr);
        }


        public BigDecimalSpMat asDiagonal()
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_asDiagonal, 0, 0, 0, mpPtr);
            return m1;
        }


        public BigDecimalSpMat adjoint()
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_adjoint, 0, 0, 0, mpPtr);
            return m1;
        }


        public BigDecimalSpMat conjugate()
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_conjugate, 0, 0, 0, mpPtr);
            return m1;
        }


        public BigDecimalSpMat transpose()
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_transpose, 0, 0, 0, mpPtr);
            return m1;
        }



        public BigDecimalSpMat reverse_full()
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public BigDecimalSpMat reverse_rowwise()
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public BigDecimalSpMat reverse_colwise()
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_colwise, mpPtr);
            return m1;
        }


        public BigDecimalSpMat replicate_full(int Vertical, int Horizontal)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_replicate, Vertical, Horizontal, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public BigDecimalSpMat replicate_rowwise(int Vertical)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_replicate, Vertical, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public BigDecimalSpMat replicate_colwise(int Horizontal)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_SetSpecialValue2(constants.mp_dpr, m1.mpPtr, constants.mp_replicate, 0, Horizontal, constants.mp_const_colwise, mpPtr);
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




        public static BigDecimalSpMat operator +(BigDecimalSpMat M1, BigDecimalSpMat M2)
        {
            var Res = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_dpr, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
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




        public static BigDecimalSpMat operator -(BigDecimalSpMat m1, BigDecimalSpMat m2)
        {
            var m3 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_dpr, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
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



        public static BigDecimalSpMat operator *(BigDecimalSpMat m1, BigDecimalSpMat m2)
        {
            var m3 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_dpr, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
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




        public BigDecimalSpMat cwiseProduct(BigDecimalSpMat x)
        {
            var m3 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_dpr, m3.mpPtr, constants.mp_const_cwiseProduct, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function cwiseProduct(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_cwiseProduct, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function



        public BigDecimalSpMat dotProduct(BigDecimalSpMat x)
        {
            var m3 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_dpr, m3.mpPtr, constants.mp_const_DotProduct, x.mpPtr, mpPtr);
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



        public BigDecimalSpMat cwiseQuotient(BigDecimalSpMat x)
        {
            var m3 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_BasicArithmetic(constants.mp_dpr, m3.mpPtr, constants.mp_const_cwiseQuotient, x.mpPtr, mpPtr);
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


        public BigDecimalSpMat sum(int PartialMode)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_dpr, m1.mpPtr, constants.mp_const_sum, PartialMode, mpPtr);
            return m1;
        }



        public BigDecimalSpMat prod(int PartialMode)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_dpr, m1.mpPtr, constants.mp_const_prod, PartialMode, mpPtr);
            return m1;
        }



        public BigDecimalSpMat mean(int PartialMode)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_dpr, m1.mpPtr, constants.mp_const_mean, PartialMode, mpPtr);
            return m1;
        }



        public BigDecimalSpMat minCoeff(int PartialMode)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_dpr, m1.mpPtr, constants.mp_const_minCoeff, PartialMode, mpPtr);
            return m1;
        }



        public BigDecimalSpMat maxCoeff(int PartialMode)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_dpr, m1.mpPtr, constants.mp_const_maxCoeff, PartialMode, mpPtr);
            return m1;
        }



        public BigDecimalSpMat squaredNorm(int PartialMode)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_dpr, m1.mpPtr, constants.mp_const_squaredNorm, PartialMode, mpPtr);
            return m1;
        }



        public BigDecimalSpMat Norm(int PartialMode)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_dpr, m1.mpPtr, constants.mp_const_Norm, PartialMode, mpPtr);
            return m1;
        }



        public BigDecimalSpMat stableNorm(int PartialMode)
        {
            var m1 = new BigDecimalSpMat();
            AnyLibSparse.Lib_EigenSparse_MpAny_Stats(constants.mp_dpr, m1.mpPtr, constants.mp_const_stableNorm, PartialMode, mpPtr);
            return m1;
        }


        #endregion




        #region Solver

        public BigDecimalMat solve(BigDecimalMat b)
        {
            var x = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_dpr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }


        public BigDecimalMat SimplicialLLT_Solver(BigDecimalMat b)
        {
            var x = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_dpr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_llt);
            return x;
        }


        public BigDecimalMat SimplicialLDLT_Solver(BigDecimalMat b)
        {
            var x = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_dpr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_ldlt);
            return x;
        }



        public BigDecimalMat SparseLU_Solver(BigDecimalMat b)
        {
            var x = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_dpr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_lu);
            return x;
        }



        public BigDecimalMat SparseQR_Solver(BigDecimalMat b)
        {
            var x = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_dpr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }



        public BigDecimalMat ConjugateGradient_Solver(BigDecimalMat b)
        {
            var x = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_dpr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_CG_Solver);
            return x;
        }



        public BigDecimalMat LeastSquaresConjugateGradient_Solver(BigDecimalMat b)
        {
            var x = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_dpr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_LSCG_Solver);
            return x;
        }



        public BigDecimalMat BiCGSTAB_Solver(BigDecimalMat b)
        {
            var x = new BigDecimalMat();
            AnyLibSparse.EigenSparseLib_MpAny_Solve(constants.mp_dpr, x.mpPtr, mpPtr, b.mpPtr, constants.mp_BiCGSTAB_Solver);
            return x;
        }


        #endregion



    }




    public class BigDecimalSpMatC
    {

        public IntPtr mpPtr = default;


        #region Constructors

        private void Init()
        {
            ArbPrec.Init();
            mpPtr = AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Init_Func(constants.mp_dpc);
        }



        private void Init(int m, int n = 1)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_Resize, m, n);
        }


        public BigDecimalSpMatC()
        {
            Init();
        }


        /// <summary>
        /// Create a new Matrix with m of rows and n columns.  
        /// </summary>
        /// <param name="m">Number of rows</param>
        /// <param name="n">Number of columns</param>
        public BigDecimalSpMatC(int m, int n)
        {
            Init(m, n);
        }


        // Public Sub New(x As Double)
        // Init()
        // Lib_EigenSparse_MpAny_Cplx_SetCoeff(mpPtr, x, 0, 0)
        // End Sub


        public BigDecimalSpMatC(BigDecimalSpMatC src)
        {
            Init();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_dpc, mpPtr, constants.mp_const_fullcopy, 0, 0, 0, 0, src.mpPtr);
        }


        public BigDecimalSpMatC(BigDecimalMatC src)
        {
            Init();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_SparseFromDense(constants.mp_dpc, mpPtr, src.mpPtr);
        }


        ~BigDecimalSpMatC()
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Clear(constants.mp_dpc, mpPtr);
        }

        #endregion


        #region Input and Output


        public BigDecimalMatC ToDense()
        {
            var A = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_DenseFromSparse(constants.mp_dpc, A.mpPtr, mpPtr);
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
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_dpc, constants.mp_const_rows, mpPtr);
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
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_dpc, constants.mp_const_cols, mpPtr);
            }
        }


        public int size
        {
            get
            {
                return AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_GetInfo(constants.mp_dpc, constants.mp_const_size, mpPtr);
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
        public BigDecimalSpMatC get_block(int i, int j, int p, int q)
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_dpc, m1.mpPtr, constants.mp_const_block, i, j, p, q, mpPtr);
            return m1;
        }

        public void set_block(int i, int j, int p, int q, BigDecimalSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_dpc, mpPtr, constants.mp_const_block, i, j, p, q, value.mpPtr);
        }



        public BigDecimalSpMatC get_row(int i)
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_dpc, m1.mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, mpPtr);
            return m1;
        }

        public void set_row(int i, BigDecimalSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_dpc, mpPtr, constants.mp_const_middleRows, 0, 0, i, 1, value.mpPtr);
        }



        public BigDecimalSpMatC get_col(int j)
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_dpc, m1.mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, mpPtr);
            return m1;
        }

        public void set_col(int j, BigDecimalSpMatC value)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_dpc, mpPtr, constants.mp_const_middleCols, 0, 0, j, 1, value.mpPtr);
        }




        public BigDecimalSpMatC get_diagonal(int q = 0)
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_dpc, m1.mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, mpPtr);
            return m1;
        }

        public void set_diagonal(int q = 0, BigDecimalSpMatC value = default)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_dpc, mpPtr, constants.mp_const_diagonal, 0, 0, 0, q, value.mpPtr);
        }




        public BigDecimalSpMatC get_triangularView(int View = 1)
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Get_Block(constants.mp_dpc, m1.mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, mpPtr);
            return m1;
        }

        public void set_triangularView(int View = 1, BigDecimalSpMatC value = default)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_Put_Block(constants.mp_dpc, mpPtr, constants.mp_const_triangularView, 0, 0, 0, View, value.mpPtr);
        }



        #endregion


        #region SetSpecialValue


        public void setZero(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_setZero, n, m);
        }



        public void setOnes(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_setOnes, n, m);
        }


        public void setIdentity(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_setIdentity, n, m);
        }


        public void resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_Resize, n, m);
        }


        public void conservative_resize(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_conservativeResize, n, m);
        }



        public void Random(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_setRandom_nm, n, m);
        }


        public void RandomSymmetric(int n)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_setRandomSymmetric, n, n);
        }



        public void FillLinear(int n, int m)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue(constants.mp_dpc, mpPtr, constants.mp_FillLinear, n, m);
        }


        #endregion





        #region SetSpecialValue2


        public void ResizeLike(BigDecimalSpMatC m1)
        {
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, mpPtr, constants.mp_ResizeLike, 0, 0, 0, m1.mpPtr);
        }


        public BigDecimalSpMatC asDiagonal()
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_asDiagonal, 0, 0, 0, mpPtr);
            return m1;
        }


        public BigDecimalSpMatC adjoint()
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_adjoint, 0, 0, 0, mpPtr);
            return m1;
        }


        public BigDecimalSpMatC conjugate()
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_conjugate, 0, 0, 0, mpPtr);
            return m1;
        }


        public BigDecimalSpMatC transpose()
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_transpose, 0, 0, 0, mpPtr);
            return m1;
        }



        public BigDecimalSpMatC reverse_full()
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public BigDecimalSpMatC reverse_rowwise()
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public BigDecimalSpMatC reverse_colwise()
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_reverse, 0, 0, constants.mp_const_colwise, mpPtr);
            return m1;
        }


        public BigDecimalSpMatC replicate_full(int Vertical, int Horizontal)
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_replicate, Vertical, Horizontal, constants.mp_const_full_matrix, mpPtr);
            return m1;
        }


        public BigDecimalSpMatC replicate_rowwise(int Vertical)
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_replicate, Vertical, 0, constants.mp_const_rowwise, mpPtr);
            return m1;
        }


        public BigDecimalSpMatC replicate_colwise(int Horizontal)
        {
            var m1 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_SetSpecialValue2(constants.mp_dpc, m1.mpPtr, constants.mp_replicate, 0, Horizontal, constants.mp_const_colwise, mpPtr);
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




        public static BigDecimalSpMatC operator +(BigDecimalSpMatC M1, BigDecimalSpMatC M2)
        {
            var Res = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_dpc, Res.mpPtr, constants.mp_const_plus, M1.mpPtr, M2.mpPtr);
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




        public static BigDecimalSpMatC operator -(BigDecimalSpMatC m1, BigDecimalSpMatC m2)
        {
            var m3 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_dpc, m3.mpPtr, constants.mp_const_minus, m1.mpPtr, m2.mpPtr);
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



        public static BigDecimalSpMatC operator *(BigDecimalSpMatC m1, BigDecimalSpMatC m2)
        {
            var m3 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_dpc, m3.mpPtr, constants.mp_const_MatrixProduct, m1.mpPtr, m2.mpPtr);
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




        public BigDecimalSpMatC cwiseProduct(BigDecimalSpMatC x)
        {
            var m3 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_dpc, m3.mpPtr, constants.mp_const_cwiseProduct, x.mpPtr, mpPtr);
            return m3;
        }


        // Public Function cwiseProduct(x As cplx_mat_t) As cplx_mat_t
        // Dim m3 As New cplx_mat_t()
        // Dim T1 As New cplx_mat_t(Me)
        // Lib_Eigen_Cplx_BasicArithmetic(m3.mpPtr, mp_const_cwiseProduct, T1.mpPtr, x.mpPtr)
        // Return m3
        // End Function



        public BigDecimalSpMatC dotProduct(BigDecimalSpMatC x)
        {
            var m3 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_dpc, m3.mpPtr, constants.mp_const_DotProduct, x.mpPtr, mpPtr);
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



        public BigDecimalSpMatC cwiseQuotient(BigDecimalSpMatC x)
        {
            var m3 = new BigDecimalSpMatC();
            AnyLibSparse.Lib_EigenSparse_MpAny_Cplx_BasicArithmetic(constants.mp_dpc, m3.mpPtr, constants.mp_const_cwiseQuotient, x.mpPtr, mpPtr);
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

        public BigDecimalMatC solve(BigDecimalMatC b)
        {
            var x = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_dpc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }


        public BigDecimalMatC SimplicialLLT_Solver(BigDecimalMatC b)
        {
            var x = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_dpc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_llt);
            return x;
        }


        public BigDecimalMatC SimplicialLDLT_Solver(BigDecimalMatC b)
        {
            var x = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_dpc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_ldlt);
            return x;
        }



        public BigDecimalMatC SparseLU_Solver(BigDecimalMatC b)
        {
            var x = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_dpc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_lu);
            return x;
        }



        public BigDecimalMatC SparseQR_Solver(BigDecimalMatC b)
        {
            var x = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_dpc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_householderQr);
            return x;
        }



        public BigDecimalMatC ConjugateGradient_Solver(BigDecimalMatC b)
        {
            var x = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_dpc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_CG_Solver);
            return x;
        }



        public BigDecimalMatC LeastSquaresConjugateGradient_Solver(BigDecimalMatC b)
        {
            var x = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_dpc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_LSCG_Solver);
            return x;
        }



        public BigDecimalMatC BiCGSTAB_Solver(BigDecimalMatC b)
        {
            var x = new BigDecimalMatC();
            AnyLibSparse.EigenSparseLib_MpAny_Cplx_Solve(constants.mp_dpc, x.mpPtr, mpPtr, b.mpPtr, constants.mp_BiCGSTAB_Solver);
            return x;
        }


        #endregion



    }










}