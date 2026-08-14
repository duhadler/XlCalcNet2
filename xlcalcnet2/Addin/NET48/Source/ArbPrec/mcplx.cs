using System;
using System.Numerics;
using System.Runtime.InteropServices;
using FixedPrecNet;

namespace ArbPrecNet
{




    public class MpfrC
    {

        #region Init

        internal IntPtr mpPtr = IntPtr.Zero;


        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Lib_Mpfc_Init_Func();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_Mpfc_Init_Func();


        ~MpfrC()
        {
            Lib_Mpfc_Clear(mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Clear(IntPtr x);

        #endregion


        #region Conversions



        public MpfrC()
        {
            Init();
        }


        public Mpfr real
        {
            get
            {
                var res = new Mpfr();
                Lib_Mpfc_Real(res.mpPtr, mpPtr);
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Real", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Real(IntPtr res, IntPtr z);


        public Mpfr imag
        {
            get
            {
                var res = new Mpfr();
                Lib_Mpfc_Imag(res.mpPtr, mpPtr);
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Imag", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Imag(IntPtr res, IntPtr z);




        public override string ToString()
        {
            return "(" + real.ToString() + ", " + imag.ToString() + ")";
        }


        public string __str__()
        {
            return ToString();
        }


        public string __repr__()
        {
            return "MpfrC('" + ToString() + "')";
        }


        #endregion




        #region Arithmetic operators



        public static bool operator ==(dynamic x, MpfrC y)
        {
            return mcplx.t(x) == y;
        }

        public static bool operator ==(MpfrC x, dynamic y)
        {
            return x == mcplx.t(y);
        }


        public static bool operator !=(dynamic x, MpfrC y)
        {
            return mcplx.t(x) != y;
        }

        public static bool operator !=(MpfrC x, dynamic y)
        {
            return x != mcplx.t(y);
        }



        public static bool operator ==(MpfrC m1, MpfrC m2)
        {
            return (Lib_Mpfc_Cmp(m1.mpPtr, m2.mpPtr) == 0);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Cmp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfc_Cmp(IntPtr res, IntPtr x);

        public static bool operator !=(MpfrC m1, MpfrC m2)
        {
            return (Lib_Mpfc_Cmp(m1.mpPtr, m2.mpPtr) != 0);
        }



        public static MpfrC operator +(MpfrC m1)
        {
            var res = new MpfrC();
            Lib_Mpfc_Set(res.mpPtr, m1.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Set(IntPtr res, IntPtr x);


        public static MpfrC operator -(MpfrC m1)
        {
            var res = new MpfrC();
            Lib_Mpfc_Neg(res.mpPtr, m1.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Neg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Neg(IntPtr res, IntPtr x);







        public static MpfrC operator +(MpfrC x, dynamic y)
        {
            return x + mcplx.t(y);
        }

        public static MpfrC operator +(dynamic x, MpfrC y)
        {
            return mcplx.t(x) + y;
        }


        public static MpfrC operator +(MpfrC x, Mpfr y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Add_Mpfr(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Add_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Add_Mpfr(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrC operator +(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Add(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Add(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrMatC operator +(MpfrC m2, MpfrMat M1)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            var T1 = mcplx.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_plus_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator +(MpfrC m2, MpfrMatC M1)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }









        public static MpfrC operator -(MpfrC x, dynamic y)
        {
            return x - mcplx.t(y);
        }

        public static MpfrC operator -(dynamic x, MpfrC y)
        {
            return mcplx.t(x) - y;
        }


        public static MpfrC operator -(MpfrC x, Mpfr y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Sub_Mpfr(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Sub_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Sub_Mpfr(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrC operator -(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Sub(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrMatC operator -(MpfrC m2, MpfrMat M1)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            var T1 = mcplx.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_minus_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator -(MpfrC m2, MpfrMatC M1)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return -Res;
        }








        public static MpfrC operator *(MpfrC x, dynamic y)
        {
            return x * mcplx.t(y);
        }

        public static MpfrC operator *(dynamic x, MpfrC y)
        {
            return mcplx.t(x) * y;
        }


        public static MpfrC operator *(MpfrC x, Mpfr y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Mul_Mpfr(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Mul_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Mul_Mpfr(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrC operator *(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Mul(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrMatC operator *(MpfrC m2, MpfrMat M1)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            var T1 = mcplx.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_times_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }


        public static MpfrMatC operator *(MpfrC m2, MpfrMatC M1)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }








        public static MpfrC operator /(MpfrC x, dynamic y)
        {
            return x / mcplx.t(y);
        }

        public static MpfrC operator /(dynamic x, MpfrC y)
        {
            return mcplx.t(x) / y;
        }


        public static MpfrC operator /(MpfrC x, Mpfr y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Div_Mpfr(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Div_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Div_Mpfr(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrC operator /(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Div(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Div(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrMatC operator /(MpfrC m2, MpfrMat M1)
        {
            var Res = new MpfrMatC();
            var t = mcplx.mat_t(m2);
            var T1 = mcplx.mat_t(M1);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mpcf, Res.mpPtr, constants.mp_const_div_scalar, T1.mpPtr, t.mpPtr);
            return Res;
        }







        #endregion




    }


    public class mcplx
    {


        public static String fmt(MpfrC z)
        {
            string s1 = z.real.ToString();
            string s2 = z.imag.ToString();
            string s = " " + "(" + s1 + ", " + s2 + ")";
            return s;
        }

        public static String fmt(Mpfr x)
        {
            return mreal.fmt(x);
        }


        public static String fmt(dynamic z)
        {
            return fmt(t(z));
        }



        #region Basic Functions




        #region General

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "mcplx"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "  mcplx"; }
        }


        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsRealCtx/*' />
        public static bool IsRealCtx
        {
            get { return false; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsCplxCtx/*' />
        public static bool iscplxctx
        {
            get { return true; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsIntervalOrBallCtx/*' />
        public static bool IsIntervalOrBallCtx
        {
            get { return false; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsDecimalCtx/*' />
        public static bool IsDecimalCtx
        {
            get { return false; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsFractionCtx/*' />
        public static bool IsFractionCtx
        {
            get { return false; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/HasNegativeZero/*' />
        public static bool HasNegativeZero
        {
            get { return true; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/SupportsBoost/*' />
        public static bool SupportsBoost
        {
            get { return false; }
        }



        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/realctx/*' />
        public static mreal realctx
        {
            get { return new mreal(); }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/CplxCtx/*' />
        public static mcplx CplxCtx
        {
            get { return new mcplx(); }
        }


        #endregion



        #region Conversions




        /// <summary>
        /// Returns a new MpfrC using an extended precision floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Mpfr x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Set_Real(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Set_Real", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Set_Real(IntPtr res, IntPtr x);





        /// <summary>
        /// Returns a new MpfrC using an arbitrary precision (both mantissa and exponent) ball number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Arb x)
        {
            return t(mreal.t(x));
        }





        /// <summary>
        /// Returns a new Mpfc using an arbitrary precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC T_(Mpfr x)
        {
            return t(mreal.t(x));
        }






        /// <summary>
        /// Returns a new MpfrC using a octuple precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Octuple x)
        {
            return t(mreal.t(x));
        }



        /// <summary>
        /// Returns a new MpfrC using a quadruple precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Quadruple x)
        {
            return t(mreal.t(x));
        }



        /// <summary>
        /// Returns a new MpfrC using an extended precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Extended x)
        {
            return t(mreal.t(x));
        }



        /// <summary>
        /// Returns a new Mpfc using a double precision binary floating point number for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(double x)
        {
            return t(mreal.t(x));
        }



        /// <summary>
        /// Returns a new MpfrC using a single precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Single x)
        {
            return t(mreal.t(x));
        }



        /// <summary>
        /// Returns a new Mpfc using a signed 32 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Int32 x)
        {
            return t(mreal.t(x));
        }


        /// <summary>
        /// Returns a new MpfrC using an unsigned 32 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(UInt32 x)
        {
            return t(mreal.t(x));
        }


        /// <summary>
        /// Returns a new MpfrC using a signed 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Int64 x)
        {
            return t(mreal.t(x));
        }


        /// <summary>
        /// Returns a new MpfrC using an unsigned 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(UInt64 x)
        {
            return t(mreal.t(x));
        }


        /// <summary>
        /// Returns a new MpfrC using a System.Decimal as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(decimal x)
        {
            return t(mreal.t(x));
        }


        /// <summary>
        /// Returns a new MpfrC using an unsigned 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(BigInteger x)
        {
            return t(mreal.t(x));
        }


        /// <summary>
        /// Returns a new MpfrC using a string as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(string s)
        {
            return t(mreal.t(s));
        }



        /// <summary>
        /// Returns a new MpfrC using 2 Mpfr as input for the real and imaginary part
        /// </summary>
        public static MpfrC t(Mpfr re, Mpfr im)
        {
            var res = new MpfrC();
            Lib_Mpfc_Set2(res.mpPtr, re.mpPtr, im.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Set2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Set2(IntPtr res, IntPtr re, IntPtr im);



        /// <summary>
        /// Returns a new MpfrC using a complex arbitrary (both mantissa and exponent) precision ball number as input
        /// </summary>
        public static MpfrC t(ArbC z)
        {
            return t(mreal.t(z.real), mreal.t(z.imag));
        }






        /// <summary>
        /// Returns a new Mpfc using a complex arbitrary precision binary floating point number as input
        /// </summary>
        public static MpfrC t(MpfrC z)
        {
            return t(mreal.t(z.real), mreal.t(z.imag));
        }




        /// <summary>
        /// Returns a new MpfrC using a complex quadruple precision binary floating point number as input
        /// </summary>
        public static MpfrC t(QuadrupleC z)
        {
            return t(mreal.t(z.real), mreal.t(z.imag));
        }



        /// <summary>
        /// Returns a new MpfrC using a complex extended precision binary floating point number as input
        /// </summary>
        public static MpfrC t(ExtendedC z)
        {
            return t(mreal.t(z.real), mreal.t(z.imag));
        }



        /// <summary>
        /// Returns a new Mpfc using a complex double precision binary floating point number (System.Complex) as input
        /// </summary>
        public static MpfrC t(Complex z)
        {
            return t(mreal.t(z.Real), mreal.t(z.Imaginary));
        }




        /// <summary>
        /// Returns a new MpfrC using a complex single precision binary floating point number as input
        /// </summary>
        public static MpfrC t(SingleC z)
        {
            return t(mreal.t(z.real), mreal.t(z.imag));
        }



        /// <summary>
        /// Returns a new Mpfc using 2 double as input for the real and imaginary part
        /// </summary>
        public static MpfrC t(Double d_re, Double d_im)
        {
            return t(mreal.t(d_re), mreal.t(d_im));
        }


        /// <summary>
        /// Returns a new MpfrC using 2 strings as input for the real and imaginary part
        /// </summary>
        public static MpfrC t(string s_re, string s_im)
        {
            return t(mreal.t(s_re), mreal.t(s_im));
        }


        /// <summary>
        /// Returns a new MpfrC using a general object as input
        /// </summary>
        public static MpfrC t(dynamic z)
        {
            // MsgBox(y_.GetType().ToString())
            // MsgBox(y_.ToString())
            // MsgBox(y_.real.ToString())
            string s_re = z.real.ToString();
            string s_im = z.imag.ToString();
            return t(mreal.t(s_re), mreal.t(s_im));
        }


        #endregion




        #region Basic Arithmetic and Comparisons




        public static MpfrC Negate(MpfrC x)
        {
            return -x;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Neg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Neg(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/add/*' />
        public static MpfrC add(MpfrC x, MpfrC y)
        {
            return x + y;
        }
        public static MpfrC add(dynamic x, dynamic y)
        {
            return t(x) + t(y);
        }

        public static void rawadd(MpfrC res, MpfrC x, MpfrC y)
        {
            Lib_Mpfc_Add(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Add(IntPtr res, IntPtr x, IntPtr y);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/subtract/*' />
        public static MpfrC subtract(MpfrC x, MpfrC y)
        {
            return x - y;
        }
        public static MpfrC subtract(dynamic x, dynamic y)
        {
            return t(x) - t(y);
        }

        public static void rawsub(MpfrC res, MpfrC x, MpfrC y)
        {
            Lib_Mpfc_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Sub(IntPtr res, IntPtr x, IntPtr y);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/multiply/*' />
        public static MpfrC multiply(MpfrC x, MpfrC y)
        {
            return x * y;
        }
        public static MpfrC multiply(dynamic x, dynamic y)
        {
            return t(x) * t(y);
        }
        public static void rawmul(MpfrC res, MpfrC x, MpfrC y)
        {
            Lib_Mpfc_Add(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Mul(IntPtr res, IntPtr x, IntPtr y);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/divide/*' />
        public static MpfrC divide(MpfrC x, MpfrC y)
        {
            return x / y;
        }
        public static MpfrC divide(dynamic x, dynamic y)
        {
            return t(x) / t(y);
        }
        public static void rawdiv(MpfrC res, MpfrC x, MpfrC y)
        {
            Lib_Mpfc_Div(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Div(IntPtr res, IntPtr x, IntPtr y);



        public static bool Cmp(MpfrC x, MpfrC y)
        {
            return true;
        }

        public static bool CmpAbs(MpfrC x, MpfrC y)
        {
            return true;
        }





        #endregion



        #region Machine constants and properties of numbers


        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsReal/*' />
        //public static bool IsReal(MpfrC z)
        //{
        //    return (z.imag == mflint.t(0));
        //}


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(MpfrC z)
        {
            return (z.real == mflint.t(0)) && (z.imag == mflint.t(0));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(MpfrC z)
        {
            return (z.real == mflint.t(1)) && (z.imag == mflint.t(0));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(MpfrC z)
        {
            return (mflint.isinf(z.real)) || (mflint.isinf(z.imag));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(MpfrC z)
        {
            return (mflint.isnan(z.real)) || (mflint.isnan(z.imag));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(MpfrC z)
        {
            return (mflint.isfinite(z.real)) && (mflint.isfinite(z.imag));
        }





        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static MpfrC zero()
        {
            return mflintc.t(0, 0);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static MpfrC one()
        {
            return mflintc.t(1, 0);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static MpfrC onej()
        {
            return mflintc.t(0, 1);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static MpfrC nan()
        {
            return mflintc.t(mflint.nan(), mflint.nan());
        }




        #endregion



        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Mpfr abs(MpfrC x)
        {
            var res = new Mpfr();
            Lib_Mpfc_Abs(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Abs", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Abs(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Mpfr abs(dynamic x)
        {
            return abs(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Mpfr fabs(MpfrC x)
        {
            return abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Mpfr fabs(dynamic x)
        {
            return fabs(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static MpfrC sign(MpfrC z)
        {
            if (iszero(z)) return zero();
            else return z / abs(z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static MpfrC sign(dynamic z)
        {
            return sign(t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Mpfr real(MpfrC z)
        {
            return z.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Mpfr real(dynamic x)
        {
            return real(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Mpfr imag(MpfrC z)
        {
            return z.imag;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Mpfr imag(dynamic x)
        {
            return imag(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Mpfr phase(MpfrC x)
        {
            var res = new Mpfr();
            Lib_Mpfc_Arg(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Arg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Arg(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Mpfr phase(dynamic x)
        {
            return phase(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static MpfrC conj(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Conj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Conj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Conj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static MpfrC conj(dynamic x)
        {
            return conj(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Mpfr, Mpfr> polar(MpfrC x)
        {
            return new Tuple<Mpfr, Mpfr>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Mpfr, Mpfr> polar(dynamic x)
        {
            return polar(mcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static MpfrC rect(Mpfr r, Mpfr phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static MpfrC rect(dynamic r, dynamic phi)
        {
            return rect(mreal.t(r), mreal.t(phi));
        }








        #endregion



        #region Roots and quadratic, cubic, and quartic 



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static MpfrC sqrt(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static MpfrC sqrt(dynamic x)
        {
            return sqrt(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static MpfrC sqrt1pm1(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static MpfrC sqrt1pm1(dynamic x)
        {
            return sqrt1pm1(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static MpfrC rsqrt(MpfrC x)
        {
            return 1.0 / sqrt(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static MpfrC rsqrt(dynamic x)
        {
            return rsqrt(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static MpfrC cbrt(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static MpfrC cbrt(dynamic x)
        {
            return cbrt(t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static MpfrC unitroot(Int32 n)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_UnitRoot_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_UnitRoot_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_UnitRoot_ui(IntPtr res, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static MpfrC root_si(MpfrC x, Int32 n)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Root_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static MpfrC root_si(dynamic x, Int32 n)
        {
            return root_si(t(x), n);
        }



        #region poly_equations


        public static MpfrC eval_quadratic(MpfrC x, MpfrC A, MpfrC B, MpfrC C)
        {
            return (A * x + B) * x + C;
        }

        public static MpfrC eval_quadratic(dynamic x, dynamic A, dynamic B, dynamic C)
        {
            return eval_quadratic(mcplx.t(x), mcplx.t(A), mcplx.t(B), mcplx.t(C));
        }


        // See also: Press, 3rd edition, page 227
        public static Tuple<MpfrC, MpfrC> quadratic_equation(MpfrC a, MpfrC b, MpfrC c)
        {
            MpfrC x1, x2;
            MpfrC D = mflintc.sqrt(b * b - 4 * a * c);
            MpfrC bStar = mflintc.conj(b);
            if ((bStar * D).real < mflint.t(0))
            {
                D = -D;
            }
            MpfrC q = -0.5 * (b + D);
            x1 = q / a;
            x2 = c / q;
            return new Tuple<MpfrC, MpfrC>(x1, x2);
        }
        public static Tuple<MpfrC, MpfrC> quadratic_equation(dynamic A, dynamic B, dynamic C)
        {
            return quadratic_equation(mcplx.t(A), mcplx.t(B), mcplx.t(C));
        }




        public static MpfrC eval_monic_cubic(MpfrC x, MpfrC a, MpfrC b, MpfrC c)
        {
            return ((x + a) * x + b) * x + c;
        }

        public static MpfrC eval_monic_cubic(dynamic x, dynamic a, dynamic b, dynamic c)
        {
            return eval_monic_cubic(mcplx.t(x), mcplx.t(a), mcplx.t(b), mcplx.t(c));
        }


        // See also: Press, 3rd edition, page 228
        public static Tuple<MpfrC, MpfrC, MpfrC> cubic_equation_monic(MpfrC a, MpfrC b, MpfrC c)
        {
            MpfrC x1, x2, x3;
            MpfrC Q = (a * a - 3 * b) / 9;
            MpfrC R = (2 * a * a * a - 9 * a * b + 27 * c) / 54;
            Mpfr Qr = Q.real;
            Mpfr Rr = R.real;
            if ((Q.imag == mflint.t(0.0)) && (R.imag == mflint.t(0.0)) && (Rr * Rr < Qr * Qr * Qr))
            {
                Console.WriteLine("In mflintc real Case");
                Mpfr SqrtQr = mflint.sqrt(Qr);
                Mpfr theta = mflint.acos(Rr / (SqrtQr * SqrtQr * SqrtQr));
                x1 = -2 * SqrtQr * mflint.cos((theta) / 3) - a / 3;
                x2 = -2 * SqrtQr * mflint.cos((theta + 2 * mflint.pi()) / 3) - a / 3;
                x3 = -2 * SqrtQr * mflint.cos((theta - 2 * mflint.pi()) / 3) - a / 3;
            }
            else
            {
                Console.WriteLine("In mflintc MpfrC Case");
                MpfrC D = mflintc.sqrt(R * R - Q * Q * Q);
                MpfrC RStar = mflintc.conj(R);
                if ((RStar * D).real < mflint.t(0))
                {
                    D = -D;
                }
                MpfrC A = -mflintc.cbrt(R + D);
                MpfrC B = mflintc.zero();
                if (A != mflintc.zero())
                {
                    B = Q / A;
                }
                Console.WriteLine("A: {0}", A);
                Console.WriteLine("B: {0}", B);

                x1 = (A + B) - a / 3;
                x2 = -0.5 * (A + B) - a / 3 + 0.5 * mflintc.onej() * mflint.sqrt(3) * (A - B);
                x3 = -0.5 * (A + B) - a / 3 - 0.5 * mflintc.onej() * mflint.sqrt(3) * (A - B);
            }
            return new Tuple<MpfrC, MpfrC, MpfrC>(x1, x2, x3);
        }
        public static Tuple<MpfrC, MpfrC, MpfrC> cubic_equation_monic(dynamic a, dynamic b, dynamic c)
        {
            return cubic_equation_monic(mcplx.t(a), mcplx.t(b), mcplx.t(c));
        }




        public static MpfrC eval_cubic(MpfrC x, MpfrC A, MpfrC B, MpfrC C, MpfrC D)
        {
            return ((A * x + B) * x + C) * x + D;
        }

        public static MpfrC eval_cubic(dynamic x, dynamic A, dynamic B, dynamic C, dynamic D)
        {
            return eval_cubic(mcplx.t(x), mcplx.t(A), mcplx.t(B), mcplx.t(C), mcplx.t(D));
        }


        public static Tuple<MpfrC, MpfrC, MpfrC> cubic_equation(MpfrC A, MpfrC B, MpfrC C, MpfrC D)
        {
            return cubic_equation_monic(B / A, C / A, D / A);
        }
        public static Tuple<MpfrC, MpfrC, MpfrC> cubic_equation(dynamic A, dynamic B, dynamic C, dynamic D)
        {
            return cubic_equation(mcplx.t(A), mcplx.t(B), mcplx.t(C), mcplx.t(D));
        }





        public static MpfrC eval_quartic(MpfrC x, MpfrC A, MpfrC B, MpfrC C, MpfrC D, MpfrC E)
        {
            return (((A * x + B) * x + C) * x + D) * x + E;
        }

        public static MpfrC eval_quartic(dynamic x, dynamic A, dynamic B, dynamic C, dynamic D, dynamic E)
        {
            return eval_quartic(mcplx.t(x), mcplx.t(A), mcplx.t(B), mcplx.t(C), mcplx.t(D), mcplx.t(E));
        }


        // See also: https://en.wikipedia.org/wiki/Quartic_equation#Summary_of_Ferrari's_method
        public static Tuple<MpfrC, MpfrC, MpfrC, MpfrC> quartic_equation(MpfrC A, MpfrC B, MpfrC C, MpfrC D, MpfrC E)
        {
            MpfrC x1, x2, x3, x4;
            MpfrC a = -(3 * B * B) / (8 * A * A) + C / A;
            MpfrC b = (B * B * B) / (8 * A * A * A) - (B * C) / (2 * A * A) + D / A;
            MpfrC c = -(3 * B * B * B * B) / (256 * A * A * A * A) + (C * B * B) / (16 * A * A * A) - (B * D) / (4 * A * A) + E / A;
            MpfrC V = -B / (4 * A);

            if (mflintc.iszero(b))
            {
                MpfrC W = mflintc.sqrt(a * a - 4 * c);
                MpfrC Z1 = mflintc.sqrt((-a + W) / 2);
                MpfrC Z2 = mflintc.sqrt((-a - W) / 2);
                x1 = V + Z1;
                x2 = V - Z1;
                x3 = V + Z2;
                x4 = V - Z2;
            }
            else
            {
                MpfrC e = 5 * a / 2;
                MpfrC f = 2 * a * a - c;
                MpfrC g = a * a * a / 2 - a * c / 2 - b * b / 8;
                var res = cubic_equation_monic(e, f, g);
                MpfrC y = res.Item1;
                MpfrC W = mflintc.sqrt(a + 2 * y);
                MpfrC Z1 = mflintc.sqrt(-(3 * a + 2 * y + 2 * b / W));
                MpfrC Z2 = mflintc.sqrt(-(3 * a + 2 * y - 2 * b / W));
                x1 = V + (W + Z1) / 2;
                x2 = V + (W - Z1) / 2;
                x3 = V - (W + Z2) / 2;
                x4 = V - (W - Z2) / 2;
            }
            return new Tuple<MpfrC, MpfrC, MpfrC, MpfrC>(x1, x2, x3, x4);
        }

        public static Tuple<MpfrC, MpfrC, MpfrC, MpfrC> quartic_equation(dynamic A, dynamic B, dynamic C, dynamic D, dynamic E)
        {
            return quartic_equation(mcplx.t(A), mcplx.t(B), mcplx.t(C), mcplx.t(D), mcplx.t(E));
        }


        #endregion









        #endregion



        #region Exponential and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static MpfrC exp(MpfrC x)
        {
            //MessageBox.Show("C#, MpfrC: " + x.ToString());
            var res = new MpfrC();
            Lib_Mpfc_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static MpfrC exp(dynamic x)
        {
            return exp(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static MpfrC expj(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Expj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Expj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Expj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static MpfrC expj(dynamic x)
        {
            return expj(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static MpfrC expjpi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Expjpi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Expjpi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Expjpi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static MpfrC expjpi(dynamic x)
        {
            return expjpi(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static MpfrC exp2(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static MpfrC exp2(dynamic x)
        {
            return exp2(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static MpfrC exp10(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static MpfrC exp10(dynamic x)
        {
            return exp10(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static MpfrC expm1(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static MpfrC expm1(dynamic x)
        {
            return expm1(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static MpfrC exp10m1(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static MpfrC exp10m1(dynamic x)
        {
            return exp10m1(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static MpfrC exp2m1(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static MpfrC exp2m1(dynamic x)
        {
            return exp2m1(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static MpfrC exprel(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static MpfrC exprel(dynamic x)
        {
            return exprel(mflintc.t(x));
        }





        #endregion



        #region Logarithms and related functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static MpfrC log(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static MpfrC log(dynamic x)
        {
            return log(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static MpfrC log1p(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static MpfrC log1p(dynamic x)
        {
            return log1p(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static MpfrC log2(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static MpfrC log2(dynamic x)
        {
            return log2(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static MpfrC log10(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static MpfrC log10(dynamic x)
        {
            return log10(t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static MpfrC logbase(MpfrC x, MpfrC b)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static MpfrC logbase(dynamic x, dynamic b)
        {
            return logbase(mflintc.t(x), mflintc.t(b));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static MpfrC log10p1(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static MpfrC log10p1(dynamic x)
        {
            return log10p1(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static MpfrC log2p1(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static MpfrC log2p1(dynamic x)
        {
            return log2p1(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static MpfrC lambert_wk(MpfrC x, int branch)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_LambertW_ui(res.mpPtr, x.mpPtr, branch);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LambertW_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_LambertW_ui(IntPtr res, IntPtr x, int branch);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static MpfrC lambert_wk(dynamic x, int branch)
        {
            return lambert_wk(mflintc.t(x), branch);
        }




        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static MpfrC sqr(MpfrC x)
        {
            return x * x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static MpfrC sqr(dynamic x)
        {
            return sqr(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static MpfrC cube(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static MpfrC cube(dynamic x)
        {
            return cube(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static MpfrC pow(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static MpfrC pow(dynamic x, dynamic y)
        {
            return pow(t(x), t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static MpfrC hypot(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static MpfrC hypot(dynamic x, dynamic y)
        {
            return hypot(mflintc.t(x), mflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static MpfrC pow_si(MpfrC x, Int32 n)
        {
            var res = new MpfrC();
            Lib_Arb_Arb_Pow_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Pow_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Pow_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static MpfrC pow_si(dynamic x, Int32 n)
        {
            return pow_si(mflintc.t(x), n);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static MpfrC compound_si(MpfrC x, Int32 n)
        {
            return pow1p(t(x), t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static MpfrC compound_si(dynamic x, Int32 n)
        {
            return pow1p(t(x), t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static MpfrC powm1(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static MpfrC powm1(dynamic x, dynamic y)
        {
            return powm1(mflintc.t(x), mflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static MpfrC pow1p(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static MpfrC pow1p(dynamic x, dynamic y)
        {
            return pow1p(mflintc.t(x), mflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static MpfrC pow1pm1(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static MpfrC pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(mflintc.t(x), mflintc.t(y));
        }





        #endregion



        #region Trigonometric and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static MpfrC sin(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static MpfrC sin(dynamic x)
        {
            return sin(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static MpfrC cos(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static MpfrC cos(dynamic x)
        {
            return cos(t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static MpfrC tan(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static MpfrC tan(dynamic x)
        {
            return tan(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static MpfrC cot(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static MpfrC cot(dynamic x)
        {
            return cot(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static MpfrC sec(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static MpfrC sec(dynamic x)
        {
            return sec(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static MpfrC csc(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static MpfrC csc(dynamic x)
        {
            return csc(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static MpfrC sinc(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static MpfrC sinc(dynamic x)
        {
            return sinc(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static MpfrC sinpi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static MpfrC sinpi(dynamic x)
        {
            return sinpi(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static MpfrC cospi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static MpfrC cospi(dynamic x)
        {
            return cospi(mflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static MpfrC tanpi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static MpfrC tanpi(dynamic x)
        {
            return tanpi(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static MpfrC cotpi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static MpfrC cotpi(dynamic x)
        {
            return cotpi(mflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static MpfrC cscpi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CscPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CscPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CscPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static MpfrC cscpi(dynamic x)
        {
            return cscpi(mflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static MpfrC secpi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_SecPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_SecPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_SecPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static MpfrC secpi(dynamic x)
        {
            return secpi(mflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static MpfrC sincpi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static MpfrC sincpi(dynamic x)
        {
            return sincpi(mflintc.t(x));
        }




        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static MpfrC sinh(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static MpfrC sinh(dynamic x)
        {
            return sinh(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static MpfrC cosh(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static MpfrC cosh(dynamic x)
        {
            return cosh(t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static MpfrC tanh(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static MpfrC tanh(dynamic x)
        {
            return tanh(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static MpfrC csch(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static MpfrC csch(dynamic x)
        {
            return csch(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static MpfrC sech(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static MpfrC sech(dynamic x)
        {
            return sech(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static MpfrC coth(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static MpfrC coth(dynamic x)
        {
            return coth(mflintc.t(x));
        }






        #endregion



        #region Inverse trigonometric functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static MpfrC asin(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static MpfrC asin(dynamic x)
        {
            return asin(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static MpfrC acos(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static MpfrC acos(dynamic x)
        {
            return acos(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static MpfrC atan(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static MpfrC atan(dynamic x)
        {
            return atan(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static MpfrC acsc(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static MpfrC acsc(dynamic x)
        {
            return acsc(mflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static MpfrC asec(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static MpfrC asec(dynamic x)
        {
            return asec(mflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static MpfrC acot(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static MpfrC acot(dynamic x)
        {
            return acot(mflintc.t(x));
        }



        #endregion



        #region Inverse hyperbolic functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static MpfrC asinh(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static MpfrC asinh(dynamic x)
        {
            return asinh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static MpfrC acosh(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static MpfrC acosh(dynamic x)
        {
            return acosh(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static MpfrC atanh(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static MpfrC atanh(dynamic x)
        {
            return atanh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static MpfrC acsch(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static MpfrC acsch(dynamic x)
        {
            return acsch(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static MpfrC asech(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static MpfrC asech(dynamic x)
        {
            return asech(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static MpfrC acoth(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static MpfrC acoth(dynamic x)
        {
            return acoth(mflintc.t(x));
        }





        #endregion








        #region Matrix Creation

        /// <summary>
        /// Converts from a complex scalar of type MpfrC
        /// </summary>
        public static MpfrMatC mat_t(MpfrC x)
        {
            var matA = new MpfrMatC();
            matA[0, 0] = x;
            return matA;
        }


        /// <summary>
        /// Converts from a real matrix of type MpfrMat
        /// </summary>
        public static MpfrMatC mat_t(MpfrMat matA)
        {
            var x = mat_zeros(matA.rows, matA.cols);
            Interop.Lib_ConvertMatrixAndPoly(x.mpPtr, constants.mp_conv_mat_set_real_part_in_complex, constants.mp_mpcf, constants.mp_mpcf, matA.mpPtr);
            return x;
        }

        /// <summary>
        /// Makes a deep copy from a complex matrix of type MpfrMatC
        /// </summary>
        public static MpfrMatC mat_t(MpfrMatC matA)
        {
            var matX = mat_zeros(matA.rows, matA.cols);
            matX = +matA;
            return matX;
        }



        /// <summary>
        /// Returns SetZero
        /// </summary>
        public static MpfrMatC mat_zeros(int n, int m)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_setZero, n, m);
            return resout;
        }

        /* *********************** */

        public static MpfrMatC mat_cplx_t(MpfrMatC matA)
        {
            return mat_t(matA);
        }


        public static MpfrMatC mat_cplx_zeros(int n, int m)
        {
            return mat_zeros(n, m);
        }

        /* *********************** */






        /// <summary>
        /// Returns SetOnes
        /// </summary>
        public static MpfrMatC mat_ones(int n, int m)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_setOnes, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static MpfrMatC mat_identity(int n, int m)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static MpfrMatC mat_eye(int n, int m)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns Random
        /// </summary>
        public static MpfrMatC mat_random(int n, int m)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_setRandom_nm, n, m);
            return resout;
        }


        /// <summary>
        /// Returns RandomSym
        /// </summary>
        public static MpfrMatC mat_random_symmetric(int n)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_setRandomSymmetric, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSa
        /// </summary>
        public static MpfrMatC mat_random_selfadjoint(int n)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_setRandomSA, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSaPosdef
        /// </summary>
        public static MpfrMatC mat_random_selfadjoint_posdef(int n)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_setRandomSAPosDef, n, n);
            return resout;
        }


        /// <summary>
        /// Returns FillLinear
        /// </summary>
        public static MpfrMatC mat_fill_linear(int n, int m)
        {
            var resout = new MpfrMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mpcf, resout, constants.mp_FillLinear, n, m);
            return resout;
        }





        #endregion






        #endregion






    }




}