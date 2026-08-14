using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using FixedPrecNet;


namespace ArbPrecNet
{


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void cbProc2Ptr(IntPtr x, IntPtr result);


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void cb2Ptr(IntPtr x, IntPtr result);


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void cb3Ptr(IntPtr x, IntPtr result, IntPtr t);



    public delegate Mpfr cb1SMpfr1S(Mpfr x);

    public delegate void cbMpfr1S1M(Mpfr t, MpfrVec matX);

    public delegate void cbMpfr1S2M(Mpfr t, MpfrVec matX, MpfrVec matY);


    public delegate void cbMpfr2M(MpfrMat matX, MpfrMat matY);


    public delegate Mpfr cb1SMpfr1V(MpfrVec x);

    public delegate void cbMpfr2V(MpfrVec x, MpfrVec y);

    public delegate void cbMpfr1V1M(MpfrVec x, MpfrMat y);



    public class Mpfr
    {

        #region Init

        internal IntPtr mpPtr = IntPtr.Zero;


        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Lib_Mpfr_Init_Func();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_Mpfr_Init_Func();


        ~Mpfr()
        {
            Lib_Mpfr_Clear(mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Clear(IntPtr x);

        #endregion



        #region Conversions


        public Mpfr()
        {
            Init();
        }


        internal string Get_Num_Str(string tstr)
        {
            int StrSize = Lib_Mpfr_SizeInBase10(tstr, mpPtr);
            var sb = new StringBuilder(StrSize + 30);
            Lib_Mpfr_Get_Str(sb, ArbPrec.GetDps()+20, tstr, mpPtr);
            return sb.ToString();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_SizeInBase10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_SizeInBase10(string template, IntPtr x);
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Get_Str", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_Get_Str(StringBuilder sb, UInt32 digits, string template, IntPtr x);


        internal string Get_Num_Str2(string tstr)
        {
            int StrSize = Lib_Mpfr_SizeInBase10(tstr, mpPtr);
            var sb = new StringBuilder(StrSize + 30);
            Lib_Mpfr_Get_Str(sb, ArbPrec.GetPrec()+20, tstr, mpPtr);
            return sb.ToString();
        }


        internal string Get_Num_Str16(string tstr)
        {
            int StrSize = Lib_Mpfr_SizeInBase10(tstr, mpPtr);
            var sb = new StringBuilder(StrSize + 20);
            Lib_Mpfr_Get_Str(sb, ArbPrec.GetDps() + 10, tstr, mpPtr);
            return sb.ToString();
        }


        public override string ToString()
        {
            //string tstr = "%." + (ArbPrec.GetDps()-1).ToString() + "RE";
            string tstr = "%." + (ArbPrec.GetDps() - 0).ToString() + "RG";
            return Get_Num_Str(tstr);
        }


        public string AsBinaryString()
        {
            string tstr = "%." + (ArbPrec.GetPrec()).ToString() + "Rb";
            return Get_Num_Str2(tstr);
        }


        public string AsHexString()
        {
            string tstr = "%." + (ArbPrec.GetDps()).ToString() + "Ra";
            return Get_Num_Str16(tstr);
        }


        public string __str__()
        {
            return ToString();
        }

        public string __repr__()
        {
            return "Mpfr('" + ToString() + "')";
        }

        #endregion



        #region Arithmetic operators



        public static bool operator >=(Mpfr x, dynamic y)
        {
            return x >= mreal.t(y);
        }
        public static bool operator <=(Mpfr x, dynamic y)
        {
            return x <= mreal.t(y);
        }

        public static bool operator >=(dynamic x, Mpfr y)
        {
            return mreal.t(x) >= y;
        }
        public static bool operator <=(dynamic x, Mpfr y)
        {
            return mreal.t(x) <= y;
        }


        public static bool operator >(Mpfr x, dynamic y)
        {
            return x > mreal.t(y);
        }
        public static bool operator <(Mpfr x, dynamic y)
        {
            return x < mreal.t(y);
        }

        public static bool operator >(dynamic x, Mpfr y)
        {
            return mreal.t(x) > y;
        }
        public static bool operator <(dynamic x, Mpfr y)
        {
            return mreal.t(x) < y;
        }


        public static bool operator ==(Mpfr x, dynamic y)
        {
            return x == mreal.t(y);
        }
        public static bool operator !=(Mpfr x, dynamic y)
        {
            return x != mreal.t(y);
        }

        public static bool operator ==(dynamic x, Mpfr y)
        {
            return mreal.t(x) == y;
        }
        public static bool operator !=(dynamic x, Mpfr y)
        {
            return mreal.t(x) !=  y;
        }




        public static bool operator ==(Mpfr m1, Mpfr m2)
        {
            return Lib_Mpfr_EQ(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_EQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_EQ(IntPtr x, IntPtr y);


        public static bool operator !=(Mpfr m1, Mpfr m2)
        {
            return Lib_Mpfr_NE(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_NE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_NE(IntPtr x, IntPtr y);


        public static bool operator <=(Mpfr m1, Mpfr m2)
        {
            return Lib_Mpfr_LE(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_LE(IntPtr x, IntPtr y);


        public static bool operator >(Mpfr m1, Mpfr m2)
        {
            return Lib_Mpfr_GT(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_GT(IntPtr x, IntPtr y);


        public static bool operator >=(Mpfr m1, Mpfr m2)
        {
            return Lib_Mpfr_GE(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_GE(IntPtr x, IntPtr y);


        public static bool operator <(Mpfr m1, Mpfr m2)
        {
            return Lib_Mpfr_LT(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_LT(IntPtr x, IntPtr y);











        public static Mpfr operator +(Mpfr m1)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set(res.mpPtr, m1.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set(IntPtr mpfr_out1, IntPtr mpfr_in1);



        public static Mpfr operator -(Mpfr m1)
        {
            var res = new Mpfr();
            Lib_Mpfr_Neg(res.mpPtr, m1.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Neg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Neg(IntPtr res, IntPtr x);









        public static Mpfr operator +(Mpfr x, dynamic i)
        {
            return x + mreal.t(i);
        }

        public static Mpfr operator +(dynamic i, Mpfr x)
        {
            return mreal.t(i) + x;
        }


        public static MpfrC operator +(Mpfr x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Add_Mpfr(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Add_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Add_Mpfr(IntPtr res, IntPtr y, IntPtr x);


        public static Mpfr operator +(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Add(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Add(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrMat operator +(Mpfr m2, MpfrMat M1)
        {
            var Res = new MpfrMat();
            var t = mreal.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }








        public static Mpfr operator -(Mpfr x, dynamic y)
        {
            return x - mreal.t(y);
        }

        public static Mpfr operator -(dynamic x, Mpfr y)
        {
            return mreal.t(x) - y;
        }


        public static MpfrC operator -(Mpfr x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Mpfr_Sub(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Mpfr_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Mpfr_Sub(IntPtr res, IntPtr y, IntPtr x);


        public static Mpfr operator -(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Sub(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrMat operator -(Mpfr m2, MpfrMat M1)
        {
            var Res = new MpfrMat();
            var t = mreal.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return -Res;
        }











        public static Mpfr operator *(Mpfr x, dynamic y)
        {
            return x * mreal.t(y);
        }

        public static Mpfr operator *(dynamic x, Mpfr y)
        {
            return mreal.t(x) * y;
        }


        public static MpfrC operator *(Mpfr x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Mul_Mpfr(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Mul_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Mul_Mpfr(IntPtr res, IntPtr x, IntPtr y);


        public static Mpfr operator *(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Mul(IntPtr res, IntPtr x, IntPtr y);


        public static MpfrMat operator *(Mpfr m2, MpfrMat M1)
        {
            var Res = new MpfrMat();
            var t = mreal.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_mprf, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }









        public static Mpfr operator /(Mpfr x, dynamic y)
        {
            return x / mreal.t(y);
        }

        public static Mpfr operator /(dynamic x, Mpfr y)
        {
            return mreal.t(x) / y;
        }


        public static MpfrC operator /(Mpfr x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Mpfr_Div(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Mpfr_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Mpfr_Div(IntPtr res, IntPtr x, IntPtr y);


        public static Mpfr operator /(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Div(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Div(IntPtr res, IntPtr x, IntPtr y);





        #endregion


    }





    public class MpfrVec
    {

        public IntPtr mpPtr = IntPtr.Zero;

        public MpfrVec()
        {
            ArbPrec.Init();
            mpPtr = Lib_Mpfr_StateInit_Func_N(1, ArbPrec.GetDps());
        }

        public MpfrVec(int N)
        {
            ArbPrec.Init();
            mpPtr = Lib_Mpfr_StateInit_Func_N(N, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_StateInit_Func_N", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_Mpfr_StateInit_Func_N(int N, uint digits);


        ~MpfrVec()
        {
            Lib_Mpfr_StateClear(mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_StateClear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_StateClear(IntPtr AnyPtr);


        public int Size
        {
            get
            {
                int result = 0;
                Lib_Mpfr_StateGetSize(ref result, mpPtr);
                return result;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_StateGetSize", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_StateGetSize(ref int result, IntPtr MatrixPtr_source);


        public Mpfr this[int row_i]
        {
            get
            {
                var result = new Mpfr();
                Lib_Mpfr_StateGetCoeff(result.mpPtr, row_i, mpPtr, ArbPrec.GetDps());
                return result;
            }

            set
            {
                Lib_Mpfr_StateSetCoeff(mpPtr, value.mpPtr, row_i, ArbPrec.GetDps());
            }

        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_StateGetCoeff", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_StateGetCoeff(IntPtr result, int row, IntPtr MatrixPtr_source, uint digits);

        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_StateSetCoeff", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_StateSetCoeff(IntPtr MatrixPtr_result, IntPtr in1, int row, uint digits);

    }










    public class mreal
    {



        public static String fmt(Mpfr x)
        {
            string s = " " + x.ToString();
            return s;
        }


        public static String fmt(dynamic x)
        {
            return fmt(t(x));
        }



        #region VecParams


        public static MpfrVec VecParams(params dynamic[] args)
        {
            int N = args.Length;
            var matX3 = new MpfrVec(N);
            for (int i = 0; i < N; i++)
                matX3[i] = t(args[i]);
            return matX3;
        }



        #endregion





        #region Basic floating point functions



        #region General

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "mreal"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "  mreal"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/prec/*' />
        public static Int32 prec
        {
            get { return (int)ArbPrec.GetPrec(); }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsRealCtx/*' />
        public static bool IsRealCtx
        {
            get { return true; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsCplxCtx/*' />
        public static bool iscplxctx
        {
            get { return false; }
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
            get { return true; }
        }




        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/CplxCtx/*' />
        public static mcplx CplxCtx
        {
            get { return new mcplx(); }
        }


        #endregion



        #region Conversions



        /// <summary>
        /// Returns a new Mpfr using an dynamic (an object whose operations will be resolved at runtime) as input
        /// </summary>
        public static Mpfr t(dynamic x)
        {
            //MessageBox.Show("In Mpfr t(dynamic i)");
            string s = x.ToString();
            if (s.Contains("/"))
            {
                var res = s.Split('/');
                return t(res[0]) / t(res[1]);
            }
            else
            {
                return t(s);
            }
        }



        /// <summary>
        /// Returns a new Mpfr using an arbitrary precision (both mantissa and exponent) ball number as input
        /// </summary>
        public static Mpfr t(Arb x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_Arb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_Arb(IntPtr mpfr_out1, IntPtr mpfr_in1);





        /// <summary>
        /// Returns a new Mpfr using an arbitrary precision binary floating point number as input
        /// </summary>
        public static Mpfr t(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_Mpfr(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_Mpfr(IntPtr mpfr_out1, IntPtr mpfr_in1);




        ///// <summary>
        ///// Returns a new Mpfr using a Mpfr precision binary floating point number as input
        ///// </summary>
        //public static Mpfr t(Mpfr x)
        //{
        //    return t(x.ToString());
        //}



        /// <summary>
        /// Returns a new Mpfr using a quadruple precision binary floating point number as input
        /// </summary>
        public static Mpfr t(Quadruple x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_mreal(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_mreal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_mreal(IntPtr ld_out1, IntPtr mpfr_in1);



        /// <summary>
        /// Returns a new Mpfr using an extended precision floating point number as input
        /// </summary>
        public static Mpfr t(Extended x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_LD(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_LD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_LD(IntPtr res, IntPtr x);



        internal static Mpfr TDS(Double d)
        {
            var res = new Mpfr();
            string s = d.ToString("G14", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            Lib_Mpfr_Set_Str(res.mpPtr, s);
            return res;
        }

        /// <summary>
        /// Returns a new Arb using a double precision floating point number as input
        /// </summary>
        public static Mpfr t(Double d)
        {
            if ((ArbPrec.UseRawDouble) || (ArbPrec.IsExactDouble(d)))
            {
                var res = new Mpfr();
                Lib_Mpfr_Set_D(res.mpPtr, d);
                return res;
            }
            else
            {
                return TDS(d);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_D", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_D(IntPtr mpfr_out1, Double d);



        /// <summary>
        /// Returns a new Mpfr using a single precision binary floating point number as input
        /// </summary>
        public static Mpfr t(Single x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_S(res.mpPtr, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_S", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_S(IntPtr res, ref Single x);



        /// <summary>
        /// Returns a new Mpfr using a signed 32 bit integer as input
        /// </summary>
        public static Mpfr t(Int32 si)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_Si(res.mpPtr, si);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_Si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_Si(IntPtr res, Int32 si);



        /// <summary>
        /// Returns a new Mpfr using an unsigned 32 bit integer as input
        /// </summary>
        public static Mpfr t(UInt32 ui)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_Ui(res.mpPtr, ui);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_Ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_Ui(IntPtr res, UInt32 ui);



        /// <summary>
        /// Returns a new Mpfr using a signed 64 bit integer as input
        /// </summary>
        public static Mpfr t(Int64 si64)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_Si64(res.mpPtr, si64);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_Si64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_Si64(IntPtr res, Int64 si64);


        /// <summary>
        /// Returns a new Mpfr using an unsigned 64 bit integer as input
        /// </summary>
        public static Mpfr t(UInt64 ui64)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_Ui64(res.mpPtr, ui64);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_Ui64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_Ui64(IntPtr res, UInt64 ui64);


        /// <summary>
        /// Returns a new Mpfr using a System.Decimal as input
        /// </summary>
        public static Mpfr t(decimal dec)
        {
            var res = new Mpfr();
            string s = dec.ToString();
            Lib_Mpfr_Set_Str(res.mpPtr, s);
            return res;
        }


        /// <summary>
        /// Returns a new Mpfr using an arbitrary precision integer as input
        /// </summary>
        public static Mpfr t(BigInteger i)
        {
            var res = new Mpfr();
            string s = i.ToString();
            Lib_Mpfr_Set_Str(res.mpPtr, s);
            return res;
        }



        /// <summary>
        /// Returns a new Mpfr using a string as input
        /// </summary>
        public static Mpfr t(string s)
        {
            var res = new Mpfr();
            Lib_Mpfr_Set_Str(res.mpPtr, s);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set_Str", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set_Str(IntPtr res, string s);







        #endregion




        #region Basic Arithmetic


        public static Mpfr add(Mpfr x, Mpfr y)
        {
            return x + y;
        }
        public static Mpfr add(dynamic x, dynamic y)
        {
            return t(x) + t(y);
        }

        /// <summary>
        /// Return the sum of x and y
        /// </summary>
        public static void rawadd(Mpfr res, Mpfr x, Mpfr y)
        {
            Lib_Mpfr_Add(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Add(IntPtr res, IntPtr x, IntPtr y);


        public static Mpfr subtract(Mpfr x, Mpfr y)
        {
            return x - y;
        }
        public static Mpfr subtract(dynamic x, dynamic y)
        {
            return t(x) - t(y);
        }

        /// <summary>
        /// Return the difference of x and y
        /// </summary>
        public static void rawsub(Mpfr res, Mpfr x, Mpfr y)
        {
            Lib_Mpfr_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Sub(IntPtr res, IntPtr x, IntPtr y);



        public static Mpfr multiply(Mpfr x, Mpfr y)
        {
            return x * y;
        }
        public static Mpfr multiply(dynamic x, dynamic y)
        {
            return t(x) * t(y);
        }

        /// <summary>
        /// Return the product of x and y
        /// </summary>
        public static void rawmul(Mpfr res, Mpfr x, Mpfr y)
        {
            Lib_Mpfr_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Mul(IntPtr res, IntPtr x, IntPtr y);



        public static Mpfr divide(Mpfr x, Mpfr y)
        {
            return x / y;
        }
        public static Mpfr divide(dynamic x, dynamic y)
        {
            return t(x) / t(y);
        }

        /// <summary>
        /// Return the quotient of x and y
        /// </summary>
        public static void rawdiv(Mpfr res, Mpfr x, Mpfr y)
        {
            Lib_Mpfr_Div(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Div(IntPtr res, IntPtr x, IntPtr y);



        #endregion




        #region General functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Mpfr fma(Mpfr x, Mpfr y, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Fma(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Fma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Fma(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Mpfr fma(dynamic x, dynamic y, dynamic z)
        {
            return fma(mflint.t(x), mflint.t(y), mflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Mpfr fmax(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Fmax(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Fmax", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Fmax(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Mpfr fmax(dynamic x, dynamic y)
        {
            return fmax(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Mpfr fmin(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Fmin(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Fmin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Fmin(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Mpfr fmin(dynamic x, dynamic y)
        {
            return fmin(mflint.t(x), mflint.t(y));
        }


        #endregion



        #region Machine constants


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static Mpfr zero()
        {
            var res = new Mpfr();
            Lib_Mpfr_Zero(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Zero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Zero(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/negzero/*' />
        public static Mpfr negzero()
        {
            var res = new Mpfr();
            Lib_Mpfr_NegZero(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_NegZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_NegZero(IntPtr res);



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static Mpfr one()
        {
            var res = new Mpfr();
            Lib_Mpfr_One(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_One", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_One(IntPtr res);




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static MpfrC onej()
        {
            return mflintc.t(0, 1);
        }





        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static Mpfr inf()
        {
            var res = new Mpfr();
            Lib_Mpfr_Inf(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Inf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Inf(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/neginf/*' />
        public static Mpfr neginf()
        {
            var res = new Mpfr();
            Lib_Mpfr_NegInf(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_NegInf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_NegInf(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static Mpfr nan()
        {
            var res = new Mpfr();
            Lib_Mpfr_Nan(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Nan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Nan(IntPtr res);



        #endregion



        #region Properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(Mpfr x)
        {
            return Lib_Mpfr_Signbit(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Signbit", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Signbit(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(dynamic x)
        {
            return signbit(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(Mpfr x)
        {
            return 0 != Lib_Mpfr_Finite(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Finite", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Finite(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isfinite/*' />
        public static bool isfinite(dynamic x)
        {
            return isfinite(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isinf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isinf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isinf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinf/*' />
        public static bool isinf(dynamic x)
        {
            return isinf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static bool isposinf(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isposinf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isposinf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isposinf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isposinf/*' />
        public static bool isposinf(dynamic x)
        {
            return isposinf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isneginf/*' />
        public static bool isneginf(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isneginf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isneginf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isneginf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isneginf/*' />
        public static bool isneginf(dynamic x)
        {
            return isneginf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isnan(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isnan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isnan(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnan/*' />
        public static bool isnan(dynamic x)
        {
            return isnan(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Iszero(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Iszero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Iszero(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/iszero/*' />
        public static bool iszero(dynamic x)
        {
            return iszero(t(x));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsPositiveZero/*' />
        //public static bool IsPositiveZero(Mpfr x)
        //{
        //    return 0 != (Lib_Mpfr_Isposzero(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isposzero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfr_Isposzero(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/IsPositiveZero/*' />
        //public static bool IsPositiveZero(dynamic x)
        //{
        //    return IsPositiveZero(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsNegativeZero/*' />
        //public static bool IsNegativeZero(Mpfr x)
        //{
        //    return 0 != (Lib_Mpfr_Isnegzero(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isnegzero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfr_Isnegzero(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/IsNegativeZero/*' />
        //public static bool IsNegativeZero(dynamic x)
        //{
        //    return IsNegativeZero(t(x));
        //}



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isone(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isone", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isone(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isone/*' />
        public static bool isone(dynamic x)
        {
            return isone(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinteger/*' />
        public static bool isinteger(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isinteger(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isinteger", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isinteger(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinteger/*' />
        public static bool isinteger(dynamic x)
        {
            return isinteger(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnumber/*' />
        public static bool isnumber(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isnumber(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isnumber", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isnumber(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnumber/*' />
        public static bool isnumber(dynamic x)
        {
            return isnumber(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isregular/*' />
        public static bool isregular(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isregular(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isregular", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isregular(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isregular/*' />
        public static bool isregular(dynamic x)
        {
            return isregular(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnormal/*' />
        public static bool isnormal(Mpfr x)
        {
            return 0 != (Lib_Mpfr_Isnormal(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isnormal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isnormal(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnormal/*' />
        public static bool isnormal(dynamic x)
        {
            return isnormal(t(x));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsSubnormal/*' />
        //public static bool IsSubnormal(Mpfr x)
        //{
        //    return 0 != (Lib_Mpfr_Issubnormal(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Issubnormal", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfr_Issubnormal(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/IsSubnormal/*' />
        //public static bool IsSubnormal(dynamic x)
        //{
        //    return IsSubnormal(t(x));
        //}



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isunordered/*' />
        public static bool isunordered(Mpfr x, Mpfr y)
        {
            return 0 != (Lib_Mpfr_Isunordered(x.mpPtr, y.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Isunordered", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Isunordered(IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isunordered/*' />
        public static bool isunordered(dynamic x, dynamic y)
        {
            return isunordered(t(x), t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint32/*' />
        public static bool fitsint32(Mpfr x)
        {
            return 0 != (Lib_Mpfr_FitsInt32(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_FitsInt32", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_FitsInt32(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint32/*' />
        public static bool fitsint32(dynamic x)
        {
            return fitsint32(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint64/*' />
        public static bool fitsint64(Mpfr x)
        {
            return 0 != (Lib_Mpfr_FitsInt64(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_FitsInt64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_FitsInt64(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint64/*' />
        public static bool fitsint64(dynamic x)
        {
            return fitsint64(t(x));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/FitsUInt32/*' />
        //public static bool FitsUInt32(Mpfr x)
        //{
        //    return 0 != (Lib_Mpfr_FitsUInt32(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_FitsUInt32", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfr_FitsUInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/FitsUInt32/*' />
        //public static bool FitsUInt32(dynamic x)
        //{
        //    return FitsUInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/FitsUInt64/*' />
        //public static bool FitsUInt64(Mpfr x)
        //{
        //    return 0 != (Lib_Mpfr_FitsUInt64(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_FitsUInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfr_FitsUInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/FitsUInt64/*' />
        //public static bool FitsUInt64(dynamic x)
        //{
        //    return FitsUInt64(t(x));
        //}




        #endregion



        #region Integer Related Functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Mpfr nearbyint(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Nearbyint(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Nearbyint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Nearbyint(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Mpfr nearbyint(dynamic x)
        {
            return nearbyint(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Mpfr rint(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Rint(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Rint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Rint(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Mpfr rint(dynamic x)
        {
            return rint(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(Mpfr x)
        {
            return Lib_Mpfr_Lrint(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Lrint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_Lrint(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(dynamic x)
        {
            return lrint(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(Mpfr x)
        {
            return Lib_Mpfr_Llrint(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Llrint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int64 Lib_Mpfr_Llrint(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(dynamic x)
        {
            return llrint(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Mpfr ceil(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ceil(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ceil", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ceil(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Mpfr ceil(dynamic x)
        {
            return ceil(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Mpfr floor(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Floor(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Floor", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Floor(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Mpfr floor(dynamic x)
        {
            return floor(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Mpfr trunc(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Trunc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Trunc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Trunc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Mpfr trunc(dynamic x)
        {
            return trunc(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Mpfr round(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Round(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Round", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Round(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Mpfr round(dynamic x)
        {
            return round(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(Mpfr x)
        {
            return Lib_Mpfr_Lround(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Lround", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_Lround(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(dynamic x)
        {
            return lround(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(Mpfr x)
        {
            return Lib_Mpfr_Llround(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Llround", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int64 Lib_Mpfr_Llround(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(dynamic x)
        {
            return llround(t(x));
        }




        #endregion



        #region Floating point functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Mpfr copysign(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Copysign(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Copysign", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Copysign(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Mpfr copysign(dynamic x, dynamic y)
        {
            return copysign(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Frexp/*' />
        public static Tuple<Mpfr, Int32> frexp(Mpfr x)
        {
            var res = new Mpfr();
            Int32 e = 0;
            Lib_Mpfr_Frexp(res.mpPtr, x.mpPtr, ref e);
            return new Tuple<Mpfr, int>(res, e);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Frexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Frexp(IntPtr res, IntPtr x, ref Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Frexp/*' />
        public static Tuple<Mpfr, Int32> frexp(dynamic x)
        {
            return frexp(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Mpfr logb(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Logb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Logb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Logb(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Mpfr logb(dynamic x)
        {
            return logb(t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(Mpfr x)
        {
            return Lib_Mpfr_Ilogb(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ilogb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_Ilogb(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(dynamic x)
        {
            return ilogb(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Mpfr ldexp(Mpfr x, Int32 e)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ldexp(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ldexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ldexp(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Mpfr ldexp(dynamic x, dynamic e)
        {
            return ldexp(t(x), lround(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Mpfr scalbn(Mpfr x, Int32 e)
        {
            var res = new Mpfr();
            Lib_Mpfr_Scalbn(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Scalbn", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Scalbn(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Mpfr scalbn(dynamic x, dynamic e)
        {
            return scalbn(t(x), lround(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Mpfr scalbln(Mpfr x, Int32 e)
        {
            var res = new Mpfr();
            Lib_Mpfr_Scalbln(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Scalbln", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Scalbln(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Mpfr scalbln(dynamic x, dynamic e)
        {
            return scalbln(t(x), lround(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Mpfr fdim(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Fdim(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Fdim", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Fdim(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Mpfr fdim(dynamic x, dynamic y)
        {
            return fdim(mflint.t(x), mflint.t(y));
        }


        #endregion



        #region Fraction and remainder Related Functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Mpfr, Mpfr> modf(Mpfr x)
        {
            Mpfr iptr = new Mpfr();
            Mpfr frac = new Mpfr();
            Lib_Mpfr_Modf(frac.mpPtr, x.mpPtr, iptr.mpPtr);
            return new Tuple<Mpfr, Mpfr>(iptr, frac);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Modf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Modf(IntPtr frac, IntPtr x, IntPtr iptr);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Mpfr, Mpfr> modf(dynamic x)
        {
            return modf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Mpfr fmod(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Fmod(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Fmod", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Fmod(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Mpfr fmod(dynamic x, dynamic y)
        {
            return fmod(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Mpfr remainder(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Remainder(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Remainder", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Remainder(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Mpfr remainder(dynamic x, dynamic y)
        {
            return remainder(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Mpfr, Int32> remquo(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Int32 e = 0;
            Lib_Mpfr_Remquo(res.mpPtr, x.mpPtr, y.mpPtr, ref e);
            return new Tuple<Mpfr, int>(res, e);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Remquo", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Remquo(IntPtr res, IntPtr x, IntPtr y, ref Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Mpfr, Int32> remquo(dynamic x, dynamic y)
        {
            return remquo(t(x), t(y));
        }

        #endregion



        #region Functions related to mantissa width and exponent range


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/Epsilon/*' />
        public static Mpfr epsilon()
        {
            var res = new Mpfr();
            Lib_Mpfr_Epsilon(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Epsilon", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Epsilon(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Mpfr ulp(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ulp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ulp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ulp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Mpfr ulp(dynamic x)
        {
            return ulp(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/maxvalue/*' />
        public static Mpfr maxvalue()
        {
            var res = new Mpfr();
            Lib_Mpfr_Max(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Max", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Max(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/lowestvalue/*' />
        public static Mpfr lowestvalue()
        {
            var res = new Mpfr();
            Lib_Mpfr_Lowest(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Lowest", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Lowest(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/minposvalue/*' />
        public static Mpfr minposvalue()
        {
            var res = new Mpfr();
            Lib_Mpfr_Min(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Min", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Min(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nexttowards/*' />
        public static Mpfr nexttowards(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Nexttoward(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Nexttoward", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Nexttoward(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nexttowards/*' />
        public static Mpfr nexttowards(dynamic x, dynamic y)
        {
            return nexttowards(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Mpfr nextafter(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Nexttoward(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Mpfr nextafter(dynamic x, dynamic y)
        {
            return nextafter(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Mpfr nextabove(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Nextabove(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Nextabove", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Nextabove(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Mpfr nextabove(dynamic x)
        {
            return nextabove(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Mpfr nextbelow(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Nextbelow(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Nextbelow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Nextbelow(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Mpfr nextbelow(dynamic x)
        {
            return nextbelow(t(x));
        }


        #endregion



        #region Mathematical Constants


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/degree/*' />
        public static Mpfr degree()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstDegree(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstDegree", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstDegree(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phi/*' />
        public static Mpfr phi()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstPhi(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstPhi(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln2/*' />
        public static Mpfr ln2()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstLog2(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstLog2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstLog2(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln10/*' />
        public static Mpfr ln10()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstLog10(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstLog10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstLog10(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pi/*' />
        public static Mpfr pi()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstPi(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstPi(IntPtr res);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/PI/*' />
        //public static Mpfr PI()
        //{
        //    return PI();
        //}


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/e/*' />
        public static Mpfr e()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstE(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstE(IntPtr res);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/E/*' />
        //public static Mpfr E()
        //{
        //    return E();
        //}


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/egamma/*' />
        public static Mpfr egamma()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstEulerGamma(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstEulerGamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstEulerGamma(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/apery/*' />
        public static Mpfr apery()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstApery(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstApery", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstApery(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/catalan/*' />
        public static Mpfr catalan()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstCatalan(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstCatalan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstCatalan(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/glaisher/*' />
        public static Mpfr glaisher()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstGlaisher(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstGlaisher", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstGlaisher(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/khinchin/*' />
        public static Mpfr khinchin()
        {
            var res = new Mpfr();
            Lib_Mpfr_ConstKhinchin(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ConstKhinchin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ConstKhinchin(IntPtr res);


        #endregion



        #endregion





        #region Elementary scalar functions




        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Mpfr abs(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Fabs(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Fabs", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Fabs(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Mpfr abs(dynamic x)
        {
            return abs(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Mpfr fabs(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Fabs(res.mpPtr, x.mpPtr);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Mpfr fabs(dynamic x)
        {
            return fabs(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Mpfr sign(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Sign(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sign", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Sign(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Mpfr sign(dynamic x)
        {
            return sign(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Mpfr real(Mpfr x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Mpfr real(dynamic x)
        {
            return real(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Mpfr imag(Mpfr x)
        {
            return zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Mpfr imag(dynamic x)
        {
            return imag(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Mpfr phase(Mpfr x)
        {
            if (x >= zero()) return zero();
            else return pi();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Mpfr phase(dynamic x)
        {
            return phase(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Mpfr conj(Mpfr x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Mpfr conj(dynamic x)
        {
            return conj(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Mpfr, Mpfr> polar(Mpfr x)
        {
            return new Tuple<Mpfr, Mpfr>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Mpfr, Mpfr> polar(dynamic x)
        {
            return polar(mreal.t(x));
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
        public static Mpfr sqrt(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Mpfr sqrt(dynamic x)
        {
            return sqrt(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Mpfr sqrt1pm1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Mpfr sqrt1pm1(dynamic x)
        {
            return cbrt(mflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Mpfr rsqrt(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Mpfr rsqrt(dynamic x)
        {
            return rsqrt(t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Mpfr cbrt(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Mpfr cbrt(dynamic x)
        {
            return cbrt(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Mpfr root_si(Mpfr x, Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Root_Si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Root_Si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Root_Si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Mpfr root_si(dynamic x, Int32 n)
        {
            return root_si(t(x), n);
        }





        #endregion



        #region Exponential and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Mpfr exp(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Mpfr exp(dynamic x)
        {
            return exp(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static MpfrC expj(Mpfr x)
        {
            return cos(x) + onej() * sin(x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static MpfrC expj(dynamic x)
        {
            return expj(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static MpfrC expjpi(Mpfr x)
        {
            return cospi(x) + onej() * sinpi(x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static MpfrC expjpi(dynamic x)
        {
            return expjpi(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Mpfr exp2(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Mpfr exp2(dynamic x)
        {
            return exp2(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Mpfr exp10(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Mpfr exp10(dynamic x)
        {
            return exp10(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Mpfr expm1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Mpfr expm1(dynamic x)
        {
            return expm1(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Mpfr exp10m1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Mpfr exp10m1(dynamic x)
        {
            return exp10m1(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Mpfr exp2m1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Mpfr exp2m1(dynamic x)
        {
            return exp2m1(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Mpfr exprel(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Mpfr exprel(dynamic x)
        {
            return exprel(mflint.t(x));
        }







        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Mpfr log(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Mpfr log(dynamic x)
        {
            return log(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Mpfr log10(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Mpfr log10(dynamic x)
        {
            return log10(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Mpfr log2(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Mpfr log2(dynamic x)
        {
            return log2(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Mpfr logbase(Mpfr x, Mpfr b)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Mpfr logbase(dynamic x, dynamic b)
        {
            return logbase(mflint.t(x), mflint.t(b));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Mpfr log1p(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Mpfr log1p(dynamic x)
        {
            return log1p(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Mpfr log10p1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Mpfr log10p1(dynamic x)
        {
            return log10p1(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Mpfr log2p1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Mpfr log2p1(dynamic x)
        {
            return log2p1(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Mpfr log1mexp(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Log1mexp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Log1mexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Log1mexp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Mpfr log1mexp(dynamic x)
        {
            return log1mexp(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logaddexp/*' />
        public static Mpfr logaddexp(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Logaddexp(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Logaddexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Logaddexp(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logaddexp/*' />
        public static Mpfr logaddexp(dynamic x, dynamic y)
        {
            return logaddexp(mflint.t(x), mflint.t(y));
        }



        #endregion



        #region Power functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Mpfr sqr(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Mpfr sqr(dynamic x)
        {
            return sqr(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Mpfr cube(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Mpfr cube(dynamic x)
        {
            return cube(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Mpfr pow(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Mpfr pow(dynamic x, dynamic y)
        {
            return pow(mflint.t(x), mflint.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Mpfr pow_si(Mpfr x, Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Pow_Si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Pow_Si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Pow_Si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Mpfr pow_si(dynamic x, Int32 n)
        {
            return pow_si(mflint.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Mpfr compound_si(Mpfr x, Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Compound_Si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Compound_Si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Compound_Si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Mpfr compound_si(dynamic x, Int32 n)
        {
            return compound_si(mflint.t(x), n);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Mpfr hypot(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Mpfr hypot(dynamic x, dynamic y)
        {
            return hypot(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Mpfr powm1(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Mpfr powm1(dynamic x, dynamic y)
        {
            return powm1(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Mpfr pow1p(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Mpfr pow1p(dynamic x, dynamic y)
        {
            return pow1p(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Mpfr pow1pm1(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Mpfr pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(mflint.t(x), mflint.t(y));
        }



        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Mpfr cos(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Mpfr cos(dynamic x)
        {
            return cos(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Mpfr sin(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Mpfr sin(dynamic x)
        {
            return sin(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Mpfr tan(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Mpfr tan(dynamic x)
        {
            return tan(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Mpfr cot(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Mpfr cot(dynamic x)
        {
            return cot(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Mpfr sec(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Mpfr sec(dynamic x)
        {
            return sec(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Mpfr csc(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Mpfr csc(dynamic x)
        {
            return csc(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Mpfr sinc(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Mpfr sinc(dynamic x)
        {
            return sinc(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Mpfr sinpi(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Mpfr sinpi(dynamic x)
        {
            return sinpi(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Mpfr cospi(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Mpfr cospi(dynamic x)
        {
            return cospi(mflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Mpfr tanpi(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Mpfr tanpi(dynamic x)
        {
            return tanpi(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Mpfr cotpi(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Mpfr cotpi(dynamic x)
        {
            return cotpi(mflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Mpfr cscpi(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_CscPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_CscPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_CscPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Mpfr cscpi(dynamic x)
        {
            return cscpi(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Mpfr secpi(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_SecPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_SecPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_SecPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Mpfr secpi(dynamic x)
        {
            return secpi(mflint.t(x));
        }








        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Mpfr sincpi(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Mpfr sincpi(dynamic x)
        {
            return sincpi(mflint.t(x));
        }






        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Mpfr sinh(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Mpfr sinh(dynamic x)
        {
            return sinh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Mpfr cosh(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Mpfr cosh(dynamic x)
        {
            return cosh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Mpfr tanh(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Mpfr tanh(dynamic x)
        {
            return tanh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Mpfr csch(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Mpfr csch(dynamic x)
        {
            return csch(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Mpfr sech(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Mpfr sech(dynamic x)
        {
            return sech(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Mpfr coth(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Mpfr coth(dynamic x)
        {
            return coth(mflint.t(x));
        }






        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Mpfr asin(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Mpfr asin(dynamic x)
        {
            return asin(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Mpfr acos(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Acos(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Mpfr acos(dynamic x)
        {
            return acos(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Mpfr atan(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Mpfr atan(dynamic x)
        {
            return atan(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Mpfr atan2(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Atan2(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Atan2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Atan2(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Mpfr atan2(dynamic x, dynamic y)
        {
            return atan2(mflint.t(x), mflint.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Mpfr acsc(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Mpfr acsc(dynamic x)
        {
            return acsc(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Mpfr asec(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Mpfr asec(dynamic x)
        {
            return asec(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Mpfr acot(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Mpfr acot(dynamic x)
        {
            return acot(mflint.t(x));
        }





        #endregion



        #region Inverse hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Mpfr asinh(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Mpfr asinh(dynamic x)
        {
            return asinh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Mpfr acosh(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Mpfr acosh(dynamic x)
        {
            return acosh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Mpfr atanh(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Mpfr atanh(dynamic x)
        {
            return atanh(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Mpfr acsch(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Mpfr acsch(dynamic x)
        {
            return acsch(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Mpfr asech(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Mpfr asech(dynamic x)
        {
            return asech(mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Mpfr acoth(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Mpfr acoth(dynamic x)
        {
            return acoth(mflint.t(x));
        }




        #endregion



        #region Miscellaneous




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Mpfr lambert_w0(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LambertW0(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LambertW0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_LambertW0(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Mpfr lambert_w0(dynamic x)
        {
            return lambert_w0(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Mpfr lambert_wm1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LambertWm1(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LambertWm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_LambertWm1(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Mpfr lambert_wm1(dynamic x)
        {
            return lambert_wm1(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0_prime/*' />
        public static Mpfr lambert_w0_prime(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LambertW0Prime(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LambertW0Prime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_LambertW0Prime(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0_prime/*' />
        public static Mpfr lambert_w0_prime(dynamic x)
        {
            return lambert_w0_prime(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1_prime/*' />
        public static Mpfr lambert_wm1_prime(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LambertWm1Prime(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LambertWm1Prime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_LambertWm1Prime(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1_prime/*' />
        public static Mpfr lambert_wm1_prime(dynamic x)
        {
            return lambert_wm1_prime(mflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Mpfr agm(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Agm(res.mpPtr, x.mpPtr, y.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Agm(IntPtr res, IntPtr x, IntPtr y, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Mpfr agm(dynamic x, dynamic y)
        {
            return agm(mflint.t(x), mflint.t(y));
        }




        #endregion




        #endregion





        #region Special real functions





        #region Error functions for real arguments



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Mpfr ndens(Mpfr x)
        {
            return exp(-0.5 * x * x) / sqrt(2 * pi());
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Mpfr ndens(dynamic x)
        {
            return ndens(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Mpfr ndis(Mpfr x)
        {
            return 0.5 * erfc(-x / sqrt(2));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Mpfr ndis(dynamic x)
        {
            return ndis(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Mpfr erf(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Erf_(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Erf_", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Erf_(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Mpfr erf(dynamic x)
        {
            return erf(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Mpfr erfc(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Erfc_(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Erfc_", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Erfc_(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Mpfr erfc(dynamic x)
        {
            return erfc(mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ErfInv/*' />
        public static Mpfr erf_inv(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Erf_inv(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Erf_inv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Erf_inv(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ErfInv/*' />
        public static Mpfr erf_inv(dynamic x)
        {
            return erf_inv(mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ErfcInv/*' />
        public static Mpfr erfc_inv(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Erfc_inv(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Erfc_inv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Erfc_inv(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ErfcInv/*' />
        public static Mpfr erfc_inv(dynamic x)
        {
            return erfc_inv(mreal.t(x));
        }





        #endregion




        #region Gamma and related functions for real arguments and parameters


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        //public static Mpfr lgamma(Mpfr x)
        //{
        //    var res = new Mpfr();
        //    Lib_Mpfr_Lgamma(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern void Lib_Mpfr_Lgamma(IntPtr res, IntPtr x, uint dps);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        //public static Mpfr lgamma(dynamic x)
        //{
        //    return lgamma(t(x));
        //}


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Mpfr rgamma(Mpfr x)
        {
            return t(1) / gamma(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Mpfr rgamma(dynamic x)
        {
            return rgamma(t(x));
        }





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        //public static Mpfr gamma(Mpfr x)
        //{
        //    var res = new Mpfr();
        //    Lib_Mpfr_Tgamma(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Tgamma", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern void Lib_Mpfr_Tgamma(IntPtr res, IntPtr x, uint dps);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        //public static Mpfr gamma(dynamic x)
        //{
        //    return gamma(t(x));
        //}




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Mpfr gamma(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Tgamma_(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Tgamma_", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Tgamma_(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Mpfr gamma(dynamic x)
        {
            return gamma(mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma1pm1/*' />
        public static Mpfr gamma1pm1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Tgamma1pm1(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Tgamma1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Tgamma1pm1(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma1pm1/*' />
        public static Mpfr gamma1pm1(dynamic x)
        {
            return gamma1pm1(mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Mpfr lgamma(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Lgamma_(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Lgamma_", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Lgamma_(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Mpfr lgamma(dynamic x)
        {
            return lgamma(mreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/factorial/*' />
        public static Mpfr factorial(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Factorial(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Factorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Factorial(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/factorial/*' />
        public static Mpfr factorial(dynamic x)
        {
            return factorial(mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/doublefactorial/*' />
        public static Mpfr doublefactorial(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_DoubleFactorial(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_DoubleFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_DoubleFactorial(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/doublefactorial/*' />
        public static Mpfr doublefactorial(dynamic x)
        {
            return doublefactorial(mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_ratio/*' />
        public static Mpfr gamma_ratio(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_TgammaRatio(res.mpPtr, x.mpPtr, y.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_TgammaRatio", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_TgammaRatio(IntPtr res, IntPtr x, IntPtr y, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_ratio/*' />
        public static Mpfr gamma_ratio(dynamic x, dynamic y)
        {
            return gamma_ratio(mreal.t(x), mreal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_delta_ratio/*' />
        public static Mpfr gamma_delta_ratio(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_TgammaDeltaRatio(res.mpPtr, x.mpPtr, y.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_TgammaDeltaRatio", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_TgammaDeltaRatio(IntPtr res, IntPtr x, IntPtr y, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_delta_ratio/*' />
        public static Mpfr gamma_delta_ratio(dynamic x, dynamic y)
        {
            return gamma_delta_ratio(mreal.t(x), mreal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/binomial/*' />
        public static Mpfr binomial(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Binomial(res.mpPtr, x.mpPtr, y.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Binomial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Binomial(IntPtr res, IntPtr x, IntPtr y, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/binomial/*' />
        public static Mpfr binomial(dynamic x, dynamic y)
        {
            return binomial(mreal.t(x), mreal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/rising_factorial/*' />
        public static Mpfr rising_factorial(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_RisingFactorial(IntPtr res, IntPtr x, IntPtr y, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/rising_factorial/*' />
        public static Mpfr rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(mreal.t(x), mreal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/falling_factorial/*' />
        public static Mpfr falling_factorial(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_FallingFactorial(res.mpPtr, x.mpPtr, y.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_FallingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_FallingFactorial(IntPtr res, IntPtr x, IntPtr y, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/falling_factorial/*' />
        public static Mpfr falling_factorial(dynamic x, dynamic y)
        {
            return falling_factorial(mreal.t(x), mreal.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="Boost"]/beta/*' />
        public static Mpfr beta(Mpfr a, Mpfr b)
        {
            var res = new Mpfr();
            Lib_Mpfr_Beta(res.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Beta(IntPtr res, IntPtr a, IntPtr b, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/beta/*' />
        public static Mpfr beta(dynamic a, dynamic b)
        {
            return beta(mreal.t(a), mreal.t(b));
        }









        #endregion




        #region Incomplete gamma functions for real arguments and parameters




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_p/*' />
        public static Mpfr gamma_p(Mpfr a, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_GammaP(res.mpPtr, a.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GammaP(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_p/*' />
        public static Mpfr gamma_p(dynamic a, dynamic x)
        {
            return gamma_p(mreal.t(a), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_q/*' />
        public static Mpfr gamma_q(Mpfr a, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_GammaQ(res.mpPtr, a.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GammaQ(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_q/*' />
        public static Mpfr gamma_q(dynamic a, dynamic x)
        {
            return gamma_q(mreal.t(a), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_lower/*' />
        public static Mpfr gamma_lower(Mpfr a, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_TgammaLower(res.mpPtr, a.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_TgammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_TgammaLower(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_lower/*' />
        public static Mpfr gamma_lower(dynamic a, dynamic x)
        {
            return gamma_lower(mreal.t(a), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_upper/*' />
        public static Mpfr gamma_upper(Mpfr a, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_TgammaUpper(res.mpPtr, a.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_TgammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_TgammaUpper(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_upper/*' />
        public static Mpfr gamma_upper(dynamic a, dynamic x)
        {
            return gamma_upper(mreal.t(a), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_p_inv/*' />
        public static Mpfr gamma_p_inv(Mpfr a, Mpfr p)
        {
            var res = new Mpfr();
            Lib_Mpfr_GammaPInv(res.mpPtr, a.mpPtr, p.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GammaPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GammaPInv(IntPtr res, IntPtr a, IntPtr p, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_p_inv/*' />
        public static Mpfr gamma_p_inv(dynamic a, dynamic p)
        {
            return gamma_p_inv(mreal.t(a), mreal.t(p));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_q_inv/*' />
        public static Mpfr gamma_q_inv(Mpfr a, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_GammaQInv(res.mpPtr, a.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GammaQInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GammaQInv(IntPtr res, IntPtr a, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_q_inv/*' />
        public static Mpfr gamma_q_inv(dynamic a, dynamic q)
        {
            return gamma_q_inv(mreal.t(a), mreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_p_inva/*' />
        public static Mpfr gamma_p_inva(Mpfr x, Mpfr p)
        {
            var res = new Mpfr();
            Lib_Mpfr_GammaPInva(res.mpPtr, x.mpPtr, p.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GammaPInva", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GammaPInva(IntPtr res, IntPtr x, IntPtr p, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_p_inva/*' />
        public static Mpfr gamma_p_inva(dynamic x, dynamic p)
        {
            return gamma_p_inva(mreal.t(x), mreal.t(p));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_q_inva/*' />
        public static Mpfr gamma_q_inva(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_GammaQInva(res.mpPtr, x.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GammaQInva", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GammaQInva(IntPtr res, IntPtr x, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_q_inva/*' />
        public static Mpfr gamma_q_inva(dynamic x, dynamic q)
        {
            return gamma_q_inva(mreal.t(x), mreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_p_prime/*' />
        public static Mpfr gamma_p_prime(Mpfr a, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_GammaPDerivative(res.mpPtr, a.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GammaPDerivative", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GammaPDerivative(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gamma_p_prime/*' />
        public static Mpfr gamma_p_prime(dynamic a, dynamic x)
        {
            return gamma_p_prime(mreal.t(a), mreal.t(x));
        }





        #endregion



        #region Incomplete beta functions for real arguments and parameters


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta/*' />
        public static Mpfr ibeta(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta/*' />
        public static Mpfr ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(mreal.t(a), mreal.t(b), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibetac/*' />
        public static Mpfr ibetac(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibetac/*' />
        public static Mpfr ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(mreal.t(a), mreal.t(b), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/beta_lower/*' />
        public static Mpfr beta_lower(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetaNonNormalized(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetaNonNormalized", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetaNonNormalized(IntPtr res, IntPtr a, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/beta_lower/*' />
        public static Mpfr beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(mreal.t(a), mreal.t(b), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/beta_upper/*' />
        public static Mpfr beta_upper(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetacNonNormalized(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetacNonNormalized", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetacNonNormalized(IntPtr res, IntPtr a, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/beta_upper/*' />
        public static Mpfr beta_upper(dynamic a, dynamic b, dynamic x)
        {
            return beta_upper(mreal.t(a), mreal.t(b), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta_inv/*' />
        public static Mpfr ibeta_inv(Mpfr a, Mpfr b, Mpfr p)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetaInv(res.mpPtr, a.mpPtr, b.mpPtr, p.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetaInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetaInv(IntPtr res, IntPtr a, IntPtr b, IntPtr p, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta_inv/*' />
        public static Mpfr ibeta_inv(dynamic a, dynamic b, dynamic p)
        {
            return ibeta_inv(mreal.t(a), mreal.t(b), mreal.t(p));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibetac_inv/*' />
        public static Mpfr ibetac_inv(Mpfr a, Mpfr b, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetacInv(res.mpPtr, a.mpPtr, b.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetacInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetacInv(IntPtr res, IntPtr a, IntPtr b, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibetac_inv/*' />
        public static Mpfr ibetac_inv(dynamic a, dynamic b, dynamic q)
        {
            return ibetac_inv(mreal.t(a), mreal.t(b), mreal.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta_inva/*' />
        public static Mpfr ibeta_inva(Mpfr b, Mpfr x, Mpfr p)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetaInva(res.mpPtr, b.mpPtr, x.mpPtr, p.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetaInva", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetaInva(IntPtr res, IntPtr b, IntPtr x, IntPtr p, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta_inva/*' />
        public static Mpfr ibeta_inva(dynamic b, dynamic x, dynamic p)
        {
            return ibeta_inva(mreal.t(b), mreal.t(x), mreal.t(p));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibetac_inva/*' />
        public static Mpfr ibetac_inva(Mpfr b, Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetacInva(res.mpPtr, b.mpPtr, x.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetacInva", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetacInva(IntPtr res, IntPtr b, IntPtr x, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibetac_inva/*' />
        public static Mpfr ibetac_inva(dynamic b, dynamic x, dynamic q)
        {
            return ibetac_inva(mreal.t(b), mreal.t(x), mreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta_invb/*' />
        public static Mpfr ibeta_invb(Mpfr a, Mpfr x, Mpfr p)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetaInvb(res.mpPtr, a.mpPtr, x.mpPtr, p.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetaInvb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetaInvb(IntPtr res, IntPtr a, IntPtr x, IntPtr p, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta_invb/*' />
        public static Mpfr ibeta_invb(dynamic a, dynamic x, dynamic p)
        {
            return ibeta_invb(mreal.t(a), mreal.t(x), mreal.t(p));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibetac_invb/*' />
        public static Mpfr ibetac_invb(Mpfr a, Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetacInvb(res.mpPtr, a.mpPtr, x.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetacInvb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetacInvb(IntPtr res, IntPtr a, IntPtr x, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibetac_invb/*' />
        public static Mpfr ibetac_invb(dynamic a, dynamic x, dynamic q)
        {
            return ibetac_invb(mreal.t(a), mreal.t(x), mreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta_prime/*' />
        public static Mpfr ibeta_prime(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_IBetaDerivative(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_IBetaDerivative", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_IBetaDerivative(IntPtr res, IntPtr a, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ibeta_prime/*' />
        public static Mpfr ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(mreal.t(a), mreal.t(b), mreal.t(x));
        }





        #endregion



        #region Miscellaneous real functions




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/owen_t/*' />
        public static Mpfr owen_t(Mpfr h, Mpfr a)
        {
            var res = new Mpfr();
            Lib_Mpfr_OwenT(res.mpPtr, h.mpPtr, a.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_OwenT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_OwenT(IntPtr res, IntPtr h, IntPtr a, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/owen_t/*' />
        public static Mpfr owen_t(dynamic h, dynamic a)
        {
            return owen_t(mreal.t(h), mreal.t(a));
        }





        #endregion







        #endregion







        #region Special Functions



        #region Legendre elliptic integrals (elliptic modulus k), and related functions


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Ellint1K/*' />
        public static Mpfr elliptic_k(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ellint_1_K(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ellint_1_K", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ellint_1_K(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Ellint1K/*' />
        public static Mpfr elliptic_k(dynamic x)
        {
            return elliptic_k(mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Ellint2K/*' />
        public static Mpfr elliptic_e(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ellint_2_K(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ellint_2_K", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ellint_2_K(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Ellint2K/*' />
        public static Mpfr elliptic_e(dynamic x)
        {
            return elliptic_e(mreal.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rc/*' />
        public static Mpfr elliptic_rc(Mpfr a, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_EllintRC(res.mpPtr, a.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_EllintRC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_EllintRC(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rc/*' />
        public static Mpfr elliptic_rc(dynamic a, dynamic x)
        {
            return elliptic_rc(mreal.t(a), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_f/*' />
        public static Mpfr elliptic_f(Mpfr phi, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ellint1F(res.mpPtr, k.mpPtr, phi.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ellint1F", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ellint1F(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_f/*' />
        public static Mpfr elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(mreal.t(phi), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_e_inc/*' />
        public static Mpfr elliptic_e_inc(Mpfr phi, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ellint2F(res.mpPtr, k.mpPtr, phi.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ellint2F", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ellint2F(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_e_inc/*' />
        public static Mpfr elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(mreal.t(phi), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_pi/*' />
        public static Mpfr elliptic_pi(Mpfr n, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ellint3K(res.mpPtr, k.mpPtr, n.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ellint3K", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ellint3K(IntPtr res, IntPtr a, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_pi/*' />
        public static Mpfr elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(mreal.t(n), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_pi_inc/*' />
        public static Mpfr elliptic_pi_inc(Mpfr n, Mpfr phi, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ellint3F(res.mpPtr, k.mpPtr, n.mpPtr, phi.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ellint3F", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ellint3F(IntPtr res, IntPtr k, IntPtr n, IntPtr phi, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_pi_inc/*' />
        public static Mpfr elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(mreal.t(n), mreal.t(phi), mreal.t(k));
        }








        #endregion



        #region Carlson symmetric elliptic integrals




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rf/*' />
        public static Mpfr elliptic_rf(Mpfr x, Mpfr y, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_EllipticRF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_EllipticRF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_EllipticRF(IntPtr res, IntPtr x, IntPtr y, IntPtr z, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rf/*' />
        public static Mpfr elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(mreal.t(x), mreal.t(y), mreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rd/*' />
        public static Mpfr elliptic_rd(Mpfr x, Mpfr y, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_EllipticRD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_EllipticRD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_EllipticRD(IntPtr res, IntPtr x, IntPtr y, IntPtr z, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rd/*' />
        public static Mpfr elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(mreal.t(x), mreal.t(y), mreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rg/*' />
        public static Mpfr elliptic_rg(Mpfr x, Mpfr y, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_EllipticRG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_EllipticRG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_EllipticRG(IntPtr res, IntPtr x, IntPtr y, IntPtr z, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rg/*' />
        public static Mpfr elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(mreal.t(x), mreal.t(y), mreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rj/*' />
        public static Mpfr elliptic_rj(Mpfr x, Mpfr y, Mpfr z, Mpfr p)
        {
            var res = new Mpfr();
            Lib_Mpfr_EllipticRJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, p.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_EllipticRJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_EllipticRJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr p, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/elliptic_rj/*' />
        public static Mpfr elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic p)
        {
            return elliptic_rj(mreal.t(x), mreal.t(y), mreal.t(z), mreal.t(p));
        }



        #endregion



        #region Jacobi theta functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_theta1/*' />
        public static Mpfr jacobi_theta1(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiTheta1(res.mpPtr, x.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiTheta1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiTheta1(IntPtr res, IntPtr x, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_theta1/*' />
        public static Mpfr jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(mreal.t(x), mreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_theta2/*' />
        public static Mpfr jacobi_theta2(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiTheta2(res.mpPtr, x.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiTheta2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiTheta2(IntPtr res, IntPtr x, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_theta2/*' />
        public static Mpfr jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(mreal.t(x), mreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_theta3/*' />
        public static Mpfr jacobi_theta3(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiTheta3(res.mpPtr, x.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiTheta3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiTheta3(IntPtr res, IntPtr x, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_theta3/*' />
        public static Mpfr jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(mreal.t(x), mreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_theta3/*' />
        public static Mpfr jacobi_theta4(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiTheta4(res.mpPtr, x.mpPtr, q.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiTheta4", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiTheta4(IntPtr res, IntPtr x, IntPtr q, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_theta3/*' />
        public static Mpfr jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(mreal.t(x), mreal.t(q));
        }





        #endregion



        #region Jacobi elliptic functions


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_cd/*' />
        public static Mpfr jacobi_cd(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiCD(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiCD(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_cd/*' />
        public static Mpfr jacobi_cd(dynamic u, dynamic k)
        {
            return jacobi_cd(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_cn/*' />
        public static Mpfr jacobi_cn(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiCN(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiCN(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_cn/*' />
        public static Mpfr jacobi_cn(dynamic u, dynamic k)
        {
            return jacobi_cn(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_cs/*' />
        public static Mpfr jacobi_cs(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiCS(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiCS(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_cs/*' />
        public static Mpfr jacobi_cs(dynamic u, dynamic k)
        {
            return jacobi_cs(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_dc/*' />
        public static Mpfr jacobi_dc(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiDC(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiDC(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_dc/*' />
        public static Mpfr jacobi_dc(dynamic u, dynamic k)
        {
            return jacobi_dc(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_dn/*' />
        public static Mpfr jacobi_dn(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiDN(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiDN(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_dn/*' />
        public static Mpfr jacobi_dn(dynamic u, dynamic k)
        {
            return jacobi_dn(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_ds/*' />
        public static Mpfr jacobi_ds(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiDS(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiDS(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_ds/*' />
        public static Mpfr jacobi_ds(dynamic u, dynamic k)
        {
            return jacobi_ds(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_nc/*' />
        public static Mpfr jacobi_nc(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiNC(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiNC(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_nc/*' />
        public static Mpfr jacobi_nc(dynamic u, dynamic k)
        {
            return jacobi_nc(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_nd/*' />
        public static Mpfr jacobi_nd(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiND(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiND(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_nd/*' />
        public static Mpfr jacobi_nd(dynamic u, dynamic k)
        {
            return jacobi_nd(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_ns/*' />
        public static Mpfr jacobi_ns(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiNS(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiNS(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_ns/*' />
        public static Mpfr jacobi_ns(dynamic u, dynamic k)
        {
            return jacobi_ns(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_sc/*' />
        public static Mpfr jacobi_sc(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiSC(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiSC(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_sc/*' />
        public static Mpfr jacobi_sc(dynamic u, dynamic k)
        {
            return jacobi_sc(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_sd/*' />
        public static Mpfr jacobi_sd(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiSD(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiSD(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_sd/*' />
        public static Mpfr jacobi_sd(dynamic u, dynamic k)
        {
            return jacobi_sd(mreal.t(u), mreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_sn/*' />
        public static Mpfr jacobi_sn(Mpfr u, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_JacobiSN(res.mpPtr, k.mpPtr, u.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_JacobiSN(IntPtr res, IntPtr k, IntPtr u, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_sn/*' />
        public static Mpfr jacobi_sn(dynamic u, dynamic k)
        {
            return jacobi_sn(mreal.t(u), mreal.t(k));
        }




        #endregion



        #region polygamma functions




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/polygamma/*' />
        public static Mpfr polygamma(int n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Polygamma(res.mpPtr, n, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Polygamma(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/polygamma/*' />
        public static Mpfr polygamma(int n, dynamic y)
        {
            return polygamma(n, mreal.t(y));
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/digamma/*' />
        public static Mpfr digamma(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Digamma(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Digamma(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/digamma/*' />
        public static Mpfr digamma(dynamic x)
        {
            return digamma(mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/trigamma/*' />
        public static Mpfr trigamma(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Trigamma(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Trigamma(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/trigamma/*' />
        public static Mpfr trigamma(dynamic x)
        {
            return trigamma(mreal.t(x));
        }





        #endregion



        #region Hurwitz zeta function and related functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bernoulli/*' />
        public static Mpfr bernoulli(int n)
        {
            if (n == 1) return t(-0.5);
            if (n % 2 != 0) return zero();
            var res = new Mpfr();
            Lib_Mpfr_BernoulliB2n(res.mpPtr, n / 2, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BernoulliB2n", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BernoulliB2n(IntPtr res, int n, uint dps);




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/TangentT2n/*' />
        public static Mpfr TangentT2n(int n)
        {
            var res = new Mpfr();
            Lib_Mpfr_TangentT2n(res.mpPtr, n, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_TangentT2n", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_TangentT2n(IntPtr res, int n, uint dps);



        #endregion



        #region Dirichlet L-Series, Riemann zeta function, and related functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/zeta/*' />
        public static Mpfr zeta(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Zeta(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Zeta(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/zeta/*' />
        public static Mpfr zeta(dynamic x)
        {
            return zeta(mreal.t(x));
        }


        #endregion







        #region 0F1: Overview



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hyperg_0f1/*' />
        public static Mpfr hyperg_0f1(Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Hypergeo0F1(res.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Hypergeo0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Hypergeo0F1(IntPtr res, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hyperg_0f1/*' />
        public static Mpfr hyperg_0f1(dynamic b, dynamic x)
        {
            return hyperg_0f1(mreal.t(b), mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hyperg_0f1r/*' />
        public static Mpfr hyperg_0f1r(Mpfr b, Mpfr x)
        {
            if (oreal.isinteger(b) && (b <= 0))
            {
                return pow(x, -b + 1) * hyperg_0f1(-b + 2, x) / gamma(-b + 2);
            }
            else
            {
                return hyperg_0f1(b, x) / gamma(b);
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hyperg_0f1r/*' />
        public static Mpfr hyperg_0f1r(dynamic b, dynamic x)
        {
            return hyperg_0f1r(mreal.t(b), mreal.t(x));
        }





        #endregion



        #region Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_jv/*' />
        public static Mpfr bessel_jv(Mpfr v, Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselJ(res.mpPtr, v.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselJ(IntPtr res, IntPtr v, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_jv/*' />
        public static Mpfr bessel_jv(dynamic x, dynamic y, bool scaled = false)
        {
            return bessel_jv(mreal.t(x), mreal.t(y), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_yv/*' />
        public static Mpfr bessel_yv(Mpfr v, Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselY(res.mpPtr, v.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselY(IntPtr res, IntPtr v, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_yv/*' />
        public static Mpfr bessel_yv(dynamic x, dynamic y, bool scaled = false)
        {
            return bessel_yv(mreal.t(x), mreal.t(y), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_iv/*' />
        public static Mpfr bessel_iv(Mpfr v, Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselI(res.mpPtr, v.mpPtr, x.mpPtr, ArbPrec.GetDps());
            if (scaled) res *= exp(-abs(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselI", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselI(IntPtr res, IntPtr v, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_iv/*' />
        public static Mpfr bessel_iv(dynamic x, dynamic y, bool scaled = false)
        {
            return bessel_iv(mreal.t(x), mreal.t(y), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_kv/*' />
        public static Mpfr bessel_kv(Mpfr v, Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselK(res.mpPtr, v.mpPtr, x.mpPtr, ArbPrec.GetDps());
            if (scaled) res *= exp(x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselK(IntPtr res, IntPtr v, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_kv/*' />
        public static Mpfr bessel_kv(dynamic x, dynamic y, bool scaled = false)
        {
            return bessel_kv(mreal.t(x), mreal.t(y), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_jv_prime/*' />
        public static Mpfr bessel_jv_prime(Mpfr v, Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselJPrime(res.mpPtr, v.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselJPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselJPrime(IntPtr res, IntPtr v, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_jv_prime/*' />
        public static Mpfr bessel_jv_prime(dynamic x, dynamic y, bool scaled = false)
        {
            return bessel_jv_prime(mreal.t(x), mreal.t(y), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_yv_prime/*' />
        public static Mpfr bessel_yv_prime(Mpfr v, Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselYPrime(res.mpPtr, v.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselYPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselYPrime(IntPtr res, IntPtr v, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_yv_prime/*' />
        public static Mpfr bessel_yv_prime(dynamic x, dynamic y, bool scaled = false)
        {
            return bessel_yv_prime(mreal.t(x), mreal.t(y), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_iv_prime/*' />
        public static Mpfr bessel_iv_prime(Mpfr v, Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselIPrime(res.mpPtr, v.mpPtr, x.mpPtr, ArbPrec.GetDps());
            if (scaled) res *= exp(-abs(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselIPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselIPrime(IntPtr res, IntPtr v, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_iv_prime/*' />
        public static Mpfr bessel_iv_prime(dynamic x, dynamic y, bool scaled = false)
        {
            return bessel_iv_prime(mreal.t(x), mreal.t(y), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_kv_prime/*' />
        public static Mpfr bessel_kv_prime(Mpfr v, Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselKPrime(res.mpPtr, v.mpPtr, x.mpPtr, ArbPrec.GetDps());
            if (scaled) res *= exp(x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselKPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselKPrime(IntPtr res, IntPtr v, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_kv_prime/*' />
        public static Mpfr bessel_kv_prime(dynamic x, dynamic y, bool scaled = false)
        {
            return bessel_kv_prime(mreal.t(x), mreal.t(y), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_jv_zero/*' />
        public static Mpfr bessel_jv_zero(Mpfr x, int m)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselJZero(res.mpPtr, x.mpPtr, m, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselJZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselJZero(IntPtr res, IntPtr x, int m, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_jv_zero/*' />
        public static Mpfr bessel_jv_zero(dynamic x, int m)
        {
            return bessel_jv_zero(mreal.t(x), m);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_yv_zero/*' />
        public static Mpfr bessel_yv_zero(Mpfr x, int m)
        {
            var res = new Mpfr();
            Lib_Mpfr_BesselYZero(res.mpPtr, x.mpPtr, m, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BesselYZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BesselYZero(IntPtr res, IntPtr x, int m, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/bessel_yv_zero/*' />
        public static Mpfr bessel_yv_zero(dynamic x, int m)
        {
            return bessel_yv_zero(mreal.t(x), m);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_zero/*' />
        public static Mpfr sph_bessel_jn_zero(int n, int m)
        {
            return bessel_jv_zero(n + 0.5, m);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_zero/*' />
        public static Mpfr sph_bessel_yn_zero(int n, int m)
        {
            return bessel_yv_zero(n + 0.5, m);
        }




        #endregion



        #region Spherical Bessel functions and spherical modified Bessel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn/*' />
        public static Mpfr sph_bessel_jn(Mpfr n, Mpfr x, bool scaled = false)
        {
            if (!mreal.isinteger(n)) return mreal.nan();

            if (mreal.isnan(x)) return mreal.nan();
            if (mreal.isinf(x)) return mreal.zero();
            if (mreal.isneginf(x)) return mreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return mreal.one();
                    else return mreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return mreal.neginf(); else return mreal.nan();
                }
            }

            if (n < 0)
            {
                Mpfr res = sph_bessel_yn(-n - 1, x);
                if ((lrint(n) + 1) % 2 == 0) res = -res;
                return res;
            }
            else
            {
                Mpfr x1 = x;
                if (x1 <= 0) x1 = -x1;
                Mpfr res = mreal.t(0);
                Lib_Mpfr_SphBessel(res.mpPtr, lrint(n), x1.mpPtr, ArbPrec.GetDps());
                if ((x < 0) && !(lrint(n) % 2 == 0)) res = -res;
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_SphBessel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_SphBessel(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn/*' />
        public static Mpfr sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn' />
        public static Mpfr sph_bessel_yn(Mpfr n, Mpfr x, bool scaled = false)
        {
            if (!mreal.isinteger(n)) return mreal.nan();

            if (mreal.isnan(x)) return mreal.nan();
            if (mreal.isinf(x)) return mreal.zero();
            if (mreal.isneginf(x)) return mreal.zero();
            if (x == 0.0)
            {
                if (n < 0)
                {
                    if ((n == -1)) return mreal.one();
                    else return mreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 != 0) return mreal.neginf(); else return mreal.nan();
                }
            }

            if (n < 0)
            {
                Mpfr res = sph_bessel_jn(-n - 1, x);
                if ((lrint(n) + 2) % 2 == 0) res = -res;
                return res;
            }
            else
            {
                Mpfr x1 = x;
                if (x1 <= 0) x1 = -x1;
                Mpfr res = mreal.t(0);
                Lib_Mpfr_SphNeumann(res.mpPtr, lrint(n), x1.mpPtr, ArbPrec.GetDps());
                if ((x < 0) && !((lrint(n) + 1) % 2 == 0)) res = -res;
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_SphNeumann", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_SphNeumann(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn/*' />
        public static Mpfr sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(t(n), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in/*' />
        public static Mpfr sph_bessel_in(Mpfr n, Mpfr x, bool scaled = false)
        {
            if (!mreal.isinteger(n)) return mreal.nan();

            if (mreal.isnan(x)) return mreal.nan();
            if (mreal.isinf(x)) return mreal.inf();
            if (mreal.isneginf(x)) return mreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return mreal.one();
                    else return mreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return mreal.neginf(); else return mreal.nan();
                }
            }

            Mpfr x1 = x;
            if (x1 <= 0) x1 = -x1;
            Mpfr res = bessel_iv(n + 0.5, x1) / sqrt(2 * x1 / pi());
            if ((x < 0) && !(lrint(n) % 2 == 0)) res = -res;
            if (scaled) res *= exp(-abs(x));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in/*' />
        public static Mpfr sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(t(n), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn/*' />
        public static Mpfr sph_bessel_kn(Mpfr n, Mpfr x, bool scaled = false)
        {
            if (!mreal.isinteger(n)) return mreal.nan();

            if (mreal.isnan(x)) return mreal.nan();
            if (mreal.isinf(x)) return mreal.zero();
            if (mreal.isneginf(x)) return mreal.neginf();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if (lrint(n) % 2 == 0) return mreal.nan(); else return mreal.inf();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return mreal.inf(); else return mreal.nan();
                }
            }
            Mpfr res;
            if (x >= 0.0f) res = bessel_kv(n + 0.5, x) / sqrt(2 * x / pi());
            else res = -0.5f * pi() * (sph_bessel_in(n, -x) + sph_bessel_in(-n - 1, -x));
            if (scaled) res *= exp(x);
            return res;

        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn/*' />
        public static Mpfr sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(t(n), t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Mpfr besselpoly(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.besselpoly, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Mpfr besselpoly(dynamic nu, dynamic x, bool scaled = false)
        {
            return besselpoly(mreal.t(nu), mreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Mpfr besseltheta(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.besseltheta, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Mpfr besseltheta(dynamic nu, dynamic x, bool scaled = false)
        {
            return besseltheta(mreal.t(nu), mreal.t(x), scaled);
        }








        #endregion



        #region Spherical Bessel functions, first derivative




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Mpfr sph_bessel_jn_prime(Mpfr n, Mpfr x, bool scaled = false)
        {
            if (!mreal.isinteger(n)) return mreal.nan();

            if (mreal.isnan(x)) return mreal.nan();
            if (mreal.isinf(x)) return mreal.zero();
            if (mreal.isneginf(x)) return mreal.zero();
            if (x == 0.0)
            {
                if (n == 1) return 1 / mreal.t(3);
                if (n >= 0) return mreal.zero();
                else
                {
                    if (lrint(n) % 2 != 0) return mreal.neginf(); else return mreal.nan();
                }
            }
            return (n * sph_bessel_jn(n - 1, x, scaled) - (n + 1) * sph_bessel_jn(n + 1, x, scaled)) / (2 * n + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Mpfr sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Mpfr sph_bessel_yn_prime(Mpfr n, Mpfr x, bool scaled = false)
        {
            if (!mreal.isinteger(n)) return mreal.nan();

            if (mreal.isnan(x)) return mreal.nan();
            if (mreal.isinf(x)) return mreal.zero();
            if (mreal.isneginf(x)) return mreal.zero();
            if (x == 0.0)
            {
                if (n == -2) return -1 / mreal.t(3);
                if (n < 0) return mreal.zero();
                else
                {
                    if (lrint(n) % 2 == 0) return mreal.inf(); else return mreal.nan();
                }
            }
            return (n * sph_bessel_yn(n - 1, x, scaled) - (n + 1) * sph_bessel_yn(n + 1, x, scaled)) / (2 * n + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Mpfr sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Mpfr sph_bessel_in_prime(Mpfr n, Mpfr x, bool scaled = false)
        {
            if (!mreal.isinteger(n)) return mreal.nan();

            if (mreal.isnan(x)) return mreal.nan();
            if (mreal.isinf(x)) return mreal.inf();
            if (mreal.isneginf(x))
            {
                if (lrint(n) % 2 == 0) return mreal.neginf(); else return mreal.inf();
            }
            if (x == 0.0)
            {
                if (n == 0) return mreal.zero();
                if (n < 0)
                {
                    if (lrint(n) % 2 != 0) return mreal.neginf(); else return mreal.nan();
                }
            }
            return (n * sph_bessel_in(n - 1, x, scaled) + (n + 1) * sph_bessel_in(n + 1, x, scaled)) / (2 * n + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Mpfr sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Mpfr sph_bessel_kn_prime(Mpfr n, Mpfr x, bool scaled = false)
        {
            if (!mreal.isinteger(n)) return mreal.nan();

            if (mreal.isnan(x)) return mreal.nan();
            if (mreal.isinf(x)) return mreal.zero();
            if (mreal.isneginf(x)) return mreal.neginf();
            if (x == 0.0)
            {
                if (((n >= 0) && (lrint(n) % 2 == 0)) || ((n < 0) && (lrint(n) % 2 != 0))) return mreal.neginf();
                else return mreal.nan();
            }
            return -(n * sph_bessel_kn(n - 1, x, scaled) + (n + 1) * sph_bessel_kn(n + 1, x, scaled)) / (2 * n + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Mpfr sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(t(n), t(x), scaled);
        }





        #endregion



        #region Hankel functions




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static MpfrC hankel_h1(Mpfr v, Mpfr x)
        {
            return bessel_jv(v, x) + mcplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static MpfrC hankel_h1(dynamic v, dynamic x)
        {
            return hankel_h1(t(v), t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static MpfrC hankel_h2(Mpfr v, Mpfr x)
        {
            return bessel_jv(v, x) - mcplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static MpfrC hankel_h2(dynamic v, dynamic x)
        {
            return hankel_h2(t(v), t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static MpfrC sph_hankel_h1(int n, Mpfr x)
        {
            return sph_bessel_jn(n, x) + mcplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static MpfrC sph_hankel_h1(int n, dynamic x)
        {
            return sph_hankel_h1(n, t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static MpfrC sph_hankel_h2(int n, Mpfr x)
        {
            return sph_bessel_jn(n, x) - mcplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static MpfrC sph_hankel_h2(int n, dynamic x)
        {
            return sph_hankel_h2(n, t(x));
        }











        #endregion



        #region Airy functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_ai/*' />
        public static Mpfr airy_ai(Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_AiryAi(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            if ((scaled) && (x > 0)) res *= exp((mreal.t(2) / mreal.t(3)) * x * sqrt(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_AiryAi(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_ai/*' />
        public static Mpfr airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(mreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_bi/*' />
        public static Mpfr airy_bi(Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_AiryBi(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            if ((scaled) && (x > 0)) res *= exp(-abs(mreal.t(2) / mreal.t(3) * (x * sqrt(x))));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_AiryBi(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_bi/*' />
        public static Mpfr airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(mreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_ai_prime/*' />
        public static Mpfr airy_ai_prime(Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_AiryAiPrime(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            if ((scaled) && (x > 0)) res *= exp((mreal.t(2) / mreal.t(3)) * x * sqrt(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_AiryAiPrime(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_ai_prime/*' />
        public static Mpfr airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(mreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_bi_prime/*' />
        public static Mpfr airy_bi_prime(Mpfr x, bool scaled = false)
        {
            var res = new Mpfr();
            Lib_Mpfr_AiryBiPrime(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            if ((scaled) && (x > 0)) res *= exp(-abs(mreal.t(2) / mreal.t(3) * (x * sqrt(x))));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_AiryBiPrime(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_bi_prime/*' />
        public static Mpfr airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(mreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_ai_zero/*' />
        public static Mpfr airy_ai_zero(int n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Aizero(res.mpPtr, n, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Aizero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Aizero(IntPtr res, int n, uint dps);



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/airy_ai_zero/*' />
        public static Mpfr airy_bi_zero(int n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Bizero(res.mpPtr, n, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Bizero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Bizero(IntPtr res, int n, uint dps);



        #endregion








        #region 1F1 Overview




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hyperg_1f1/*' />
        public static Mpfr hyperg_1f1(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Hypergeo1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Hypergeo1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Hypergeo1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hyperg_1f1/*' />
        public static Mpfr hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(mreal.t(a), mreal.t(b), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hyperg_1f1r/*' />
        public static Mpfr hyperg_1f1r(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Hypergeo1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Hypergeo1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Hypergeo1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hyperg_1f1r/*' />
        public static Mpfr hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(mreal.t(a), mreal.t(b), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/log_hyperg_1f1/*' />
        public static Mpfr log_hyperg_1f1(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LogHypergeo1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LogHypergeo1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_LogHypergeo1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/log_hyperg_1f1/*' />
        public static Mpfr log_hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return log_hyperg_1f1(mreal.t(a), mreal.t(b), mreal.t(x));
        }



        #endregion



        #region Exponential integrals and related functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/exp_integral_ei/*' />
        public static Mpfr exp_integral_ei(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Ei(res.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ei", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ei(IntPtr res, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/exp_integral_ei/*' />
        public static Mpfr exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(mreal.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/exp_integral_en/*' />
        public static Mpfr exp_integral_en(int n, Mpfr x)
        {
            if (n < 0) return nan();
            var res = new Mpfr();
            Lib_Mpfr_expint(res.mpPtr, n, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_expint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_expint(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/exp_integral_ei/*' />
        public static Mpfr exp_integral_en(int n, dynamic x)
        {
            return exp_integral_en(n, t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Mpfr exp_integral_e1(Mpfr z)
        {
            if (z < 0) return -exp_integral_ei(-z);
            else return exp_integral_en(1, z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Mpfr exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(mreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Mpfr log_integral(Mpfr z)
        {
            if (z < 0) return nan();
            if (z == 0) return zero();
            else return exp_integral_ei(log(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Mpfr log_integral(dynamic z)
        {
            return log_integral(t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Mpfr cosh_integral(Mpfr x)
        {
            return (exp_integral_ei(x) - exp_integral_e1(x)) / 2;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Mpfr cosh_integral(dynamic z)
        {
            return cosh_integral(t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Mpfr sinh_integral(Mpfr x)
        {
            return (exp_integral_ei(x) + exp_integral_e1(x)) / 2;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Mpfr sinh_integral(dynamic z)
        {
            return sinh_integral(t(z));
        }






        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/laguerre_l/*' />
        public static Mpfr laguerre_l(int n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Laguerre(res.mpPtr, n, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Laguerre", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Laguerre(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/laguerre_l/*' />
        public static Mpfr laguerre_l(int n, dynamic y)
        {
            return laguerre_l(n, mreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hermite_h/*' />
        public static Mpfr hermite_h(int n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Hermite(res.mpPtr, n, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Hermite", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Hermite(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hermite_h/*' />
        public static Mpfr hermite_h(int n, dynamic y)
        {
            return hermite_h(n, mreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Mpfr hermite_he(int n, Mpfr x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Mpfr hermite_he(int n, dynamic x)
        {
            return hermite_he(n, mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/laguerre_l/*' />
        public static Mpfr laguerre_l(int n, int m, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LaguerreM(res.mpPtr, n, m, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LaguerreM", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_LaguerreM(IntPtr res, int n, int m, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hermite_h/*' />
        public static Mpfr laguerre_l(int n, int m, dynamic y)
        {
            return laguerre_l(n, m, mreal.t(y));
        }



        #endregion







        #region 2F1-related orthogonal polynomials





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_t/*' />
        public static Mpfr chebyshev_t(int n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_ChebyshevT(res.mpPtr, n, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ChebyshevT(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_t/*' />
        public static Mpfr chebyshev_t(int n, dynamic y)
        {
            return chebyshev_t(n, mreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_u/*' />
        public static Mpfr chebyshev_u(int n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_ChebyshevU(res.mpPtr, n, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ChebyshevU(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_u/*' />
        public static Mpfr chebyshev_u(int n, dynamic y)
        {
            return chebyshev_u(n, mreal.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Mpfr chebyshev_v(int n, Mpfr x)  // same as t_n(x)
        {
            if (x < 0.0)
            {
                int m = -1; if (n % 2 == 0) m = 1; // m = exp(i * n * pi)
                return m * chebyshev_w(n, -x);
            }
            else return sqrt(2 / (1 + x)) * chebyshev_t(2 * n + 1, sqrt((x + 1) / 2));
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_u/*' />
        public static Mpfr chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(n, t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Mpfr chebyshev_w(int n, Mpfr x)  // same as u_n(x)
        {
            if (x < 0.0)
            {
                int m = -1; if (n % 2 == 0) m = 1; // m = exp(i * n * pi)
                return m * chebyshev_v(n, -x);
            }
            else return chebyshev_u(2 * n, sqrt((x + 1) / 2));
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Mpfr chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(n, t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_p/*' />
        public static Mpfr legendre_p(int n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LegendreP(res.mpPtr, n, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_LegendreP(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_p/*' />
        public static Mpfr legendre_p(int n, dynamic y)
        {
            return legendre_p(n, mreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_q/*' />
        public static Mpfr legendre_q(int n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LegendreQ(res.mpPtr, n, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_LegendreQ(IntPtr res, int n, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_q/*' />
        public static Mpfr legendre_q(int n, dynamic y)
        {
            return legendre_q(n, mreal.t(y));
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_plm/*' />
        public static Mpfr legendre_plm(int n, int m, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_LegendrePM(res.mpPtr, n, m, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LegendrePM", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_LegendrePM(IntPtr res, int n, int m, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_plm/*' />
        public static Mpfr legendre_plm(int n, int m, dynamic y)
        {
            return legendre_plm(n, m, mreal.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gegenbauer_c/*' />
        public static Mpfr gegenbauer_c(int n, Mpfr lambda1, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Gegenbauer(res.mpPtr, n, lambda1.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Gegenbauer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Gegenbauer(IntPtr res, int n, IntPtr lambda1, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/gegenbauer_c/*' />
        public static Mpfr gegenbauer_c(int n, dynamic lambda1, dynamic x)
        {
            return gegenbauer_c(n, t(lambda1), t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_p/*' />
        public static Mpfr jacobi_p(int n, Mpfr alpha, Mpfr beta, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Jacobi(res.mpPtr, n, alpha.mpPtr, beta.mpPtr, x.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Jacobi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Jacobi(IntPtr res, int n, IntPtr alpha, IntPtr beta, IntPtr x, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/jacobi_p/*' />
        public static Mpfr jacobi_p(int n, dynamic alpha, dynamic beta, dynamic x)
        {
            return jacobi_p(n, t(alpha), t(beta), t(x));
        }









        internal static Mpfr spherical_harmonic_r(int n, int m, Mpfr theta, Mpfr phi)
        {
            var res = new Mpfr();
            Lib_Mpfr_SphericalHarmonicR(res.mpPtr, n, m, theta.mpPtr, phi.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_SphericalHarmonicR", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_SphericalHarmonicR(IntPtr res, int n, int m, IntPtr theta, IntPtr phi, uint dps);


        internal static Mpfr spherical_harmonic_i(int n, int m, Mpfr theta, Mpfr phi)
        {
            var res = new Mpfr();
            Lib_Mpfr_SphericalHarmonicI(res.mpPtr, n, m, theta.mpPtr, phi.mpPtr, ArbPrec.GetDps());
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_SphericalHarmonicI", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_SphericalHarmonicI(IntPtr res, int n, int m, IntPtr theta, IntPtr phi, uint dps);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static MpfrC spherical_y(Mpfr n, Mpfr m, Mpfr theta, Mpfr phi)
        {
            return mcplx.t(spherical_harmonic_r(lrint(n), lrint(m), theta, phi), 
                           spherical_harmonic_i(lrint(n), lrint(m), theta, phi));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static MpfrC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(mflint.t(n), mflint.t(m), mflint.t(theta), mflint.t(phi));
        }






        #endregion



        #endregion





        #region Boost Distributions as classes


        #region Base classes

        public class BaseDistClass
        {
            internal static Mpfr nil = zero();
            internal static int target = 1;
            //internal static Mpfr a_;
            //internal static Mpfr b_;
            //internal static Mpfr c_;
            //internal static Mpfr lambda1_;
            ////internal static Mpfr delta_;
            //internal static Mpfr k_;
            //internal static Mpfr m_;
            //internal static Mpfr n_;
            //internal static Mpfr p_;
            //internal static Mpfr r_;
            //internal static Mpfr mu_;
            //internal static Mpfr sigma_;


            internal virtual Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                return res;
            }

            public static mreal ctx
            {
                get { return new mreal(); }
            }



            /// <include file="docs.xml" path='docs/members[@name="Boost"]/cdf/*' />
            public Mpfr cdf(Mpfr x)
            {
                target = 2;
                return BaseDist(x);
            }


            /// <include file="docs.xml" path='docs/members[@name="Boost"]/cdf/*' />
            public Mpfr cdf(dynamic x)
            {
                target = 2;
                return BaseDist(mreal.t(x));
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/sf/*' />
            public Mpfr sf(Mpfr x)
            {
                target = 3;
                return BaseDist(x);
            }


            /// <include file="docs.xml" path='docs/members[@name="Boost"]/sf/*' />
            public Mpfr sf(dynamic x)
            {
                target = 3;
                return BaseDist(mreal.t(x));
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/hf/*' />
            public Mpfr hf(Mpfr x)
            {
                target = 4;
                return BaseDist(x);
            }


            /// <include file="docs.xml" path='docs/members[@name="Boost"]/hf/*' />
            public Mpfr hf(dynamic x)
            {
                target = 4;
                return BaseDist(mreal.t(x));
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/chf/*' />
            public Mpfr chf(Mpfr x)
            {
                target = 5;
                return BaseDist(x);
            }


            /// <include file="docs.xml" path='docs/members[@name="Boost"]/chf/*' />
            public Mpfr chf(dynamic x)
            {
                target = 5;
                return BaseDist(mreal.t(x));
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/qtf/*' />
            public Mpfr qtf(Mpfr q)
            {
                target = 6;
                return BaseDist(q);
            }


            /// <include file="docs.xml" path='docs/members[@name="Boost"]/qtf/*' />
            public Mpfr qtf(dynamic q)
            {
                target = 6;
                return BaseDist(mreal.t(q));
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/isf/*' />
            public Mpfr isf(Mpfr q)
            {
                target = 7;
                return BaseDist(q);
            }


            /// <include file="docs.xml" path='docs/members[@name="Boost"]/isf/*' />
            public Mpfr isf(dynamic q)
            {
                target = 7;
                return BaseDist(mreal.t(q));
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/mean/*' />
            public Mpfr mean()
            {
                target = 8;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/median/*' />
            public Mpfr median()
            {
                target = 9;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/mode/*' />
            public Mpfr mode()
            {
                target = 10;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/variance/*' />
            public Mpfr variance()
            {
                target = 11;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/stdev/*' />
            public Mpfr stdev()
            {
                target = 12;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/skewness/*' />
            public Mpfr skewness()
            {
                target = 13;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/kurtosis/*' />
            public Mpfr kurtosis()
            {
                target = 14;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/kurtosis_excess/*' />
            public Mpfr kurtosis_excess()
            {
                target = 15;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/support_lower_endpoint/*' />
            public Mpfr support_lower_endpoint()
            {
                target = 16;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/support_upper_endpoint/*' />
            public Mpfr support_upper_endpoint()
            {
                target = 17;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/range_lower_endpoint/*' />
            public Mpfr range_lower_endpoint()
            {
                target = 18;
                return BaseDist(nil);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/range_upper_endpoint/*' />
            public Mpfr range_upper_endpoint()
            {
                target = 19;
                return BaseDist(nil);
            }
        }


        public class BaseDistContClass : BaseDistClass
        {

            public bool IsContinuous()
            {
                return true;
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/Pdf/*' />
            public Mpfr pdf(Mpfr x)
            {
                target = 1;
                return BaseDist(x);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/Pdf/*' />
            public Mpfr pdf(dynamic x)
            {
                target = 1;
                return BaseDist(mreal.t(x));
            }
        }


        public class BaseDistDiscreteClass : BaseDistClass
        {

            public bool IsContinuous()
            {
                return false;
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/Pmf/*' />
            public Mpfr pmf(Mpfr x)
            {
                target = 1;
                return BaseDist(x);
            }

            /// <include file="docs.xml" path='docs/members[@name="Boost"]/Pmf/*' />
            public Mpfr pmf(dynamic x)
            {
                target = 1;
                return BaseDist(mreal.t(x));
            }
        }


        #endregion




        #region Closed form distributions, based on elementary functions



        #region ArcsineDist


        public class ArcsineDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_ArcsineDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ArcsineDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_ArcsineDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public ArcsineDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ArcsineDist/*' />
        public static ArcsineDistClass dist_arcsine(Mpfr a, Mpfr b)
        {
            return new ArcsineDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ArcsineDist/*' />
        public static ArcsineDistClass dist_arcsine(dynamic a, dynamic b)
        {
            return dist_arcsine(mreal.t(a), mreal.t(b));
        }

        #endregion




        #region CauchyDist


        public class CauchyDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_CauchyDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_CauchyDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_CauchyDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public CauchyDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/CauchyDist/*' />
        public static CauchyDistClass dist_cauchy(Mpfr a, Mpfr b)
        {
            return new CauchyDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/CauchyDist/*' />
        public static CauchyDistClass dist_cauchy(dynamic a, dynamic b)
        {
            return dist_cauchy(mreal.t(a), mreal.t(b));
        }

        #endregion




        #region ExponentialDist


        public class ExponentialDistClass : BaseDistContClass
        {
            Mpfr lambda1;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_ExponentialDist(target, res.mpPtr, xqp.mpPtr, lambda1.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ExponentialDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_ExponentialDist(int target, IntPtr res, IntPtr xqp, IntPtr lambda1, uint dps);

            public ExponentialDistClass(Mpfr _lambda1)
            {
                lambda1 = _lambda1;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ExponentialDist/*' />
        public static ExponentialDistClass dist_exponential(Mpfr lambda1)
        {
            return new ExponentialDistClass(lambda1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ExponentialDist/*' />
        public static ExponentialDistClass dist_exponential(dynamic lambda1)
        {
            return dist_exponential(mreal.t(lambda1));
        }

        #endregion




        #region GumbelDist


        public class GumbelDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_GumbelDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ExtremeValueDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_GumbelDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public GumbelDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GumbelDist/*' />
        public static GumbelDistClass dist_gumbel(Mpfr a, Mpfr b)
        {
            return new GumbelDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GumbelDist/*' />
        public static GumbelDistClass dist_gumbel(dynamic a, dynamic b)
        {
            return dist_gumbel(mreal.t(a), mreal.t(b));
        }

        #endregion



        #region HyperexponentialDist


        public class HyperexponentialDistClass : BaseDistContClass
        {
            private MpfrVec matProb_ = new MpfrVec();
            private MpfrVec matRate_ = new MpfrVec();

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_HyperexponentialDist(target, res.mpPtr, xqp.mpPtr, matProb_.mpPtr, matRate_.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_HyperexponentialDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_HyperexponentialDist(int target, IntPtr res, IntPtr xqp, IntPtr Prob, IntPtr Rate, uint dps);

            public HyperexponentialDistClass(MpfrVec Prob, MpfrVec Rate)
            {
                matProb_ = Prob;
                matRate_ = Rate;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/HyperexponentialDist/*' />
        public static HyperexponentialDistClass dist_hyperexponential(MpfrVec Prob, MpfrVec Rate)
        {
            return new HyperexponentialDistClass(Prob, Rate);
        }


        ///// <include file="docs.xml" path='docs/members[@name="Boost"]/HyperexponentialDist/*' />
        //public static HyperexponentialDistClass dist_hyperexponential(dynamic a, dynamic b)
        //{
        //    return dist_hyperexponential(t(a), t(b));
        //}

        #endregion





        #region KumaraswamyDist


        public class KumaraswamyDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                Mpfr res = t(0);
                Mpfr pdf = t(0);
                Mpfr sf = t(0);
                if ((target == 1) || (target == 4))
                {
                    res = a * b * pow(xqp, a - 1);
                    Mpfr temp = pow(-powm1(xqp, a), b - 1);
                    pdf = res * temp;
                }
                if ((target == 3) || (target == 4) || (target == 5))
                {
                    sf = pow(-powm1(xqp, a), b);
                }

                switch (target)
                {
                    case 1: { res = pdf; break; } // pdf
                    case 2: { res = -powm1(-powm1(xqp, a), b); break; } // cdf_P
                    case 3: { res = sf; break; } // sf, cdf_Q
                    case 4: { res = pdf / sf; break; } // Hazard
                    case 5: { res = -log(sf); break; } // CHF
                    case 6: { res = pow(-pow1pm1(-xqp, 1 / b), 1 / a); break; } // qtf, Pinv
                    case 7: { res = pow(-powm1(xqp, 1 / b), 1 / a); break; } // isf, Qinv
                    case 8: { res = t(8); break; } // Mean
                    case 9: { res = t(9); break; } // Median
                    case 10: { res = t(10); break; } // Mode
                    case 11: { res = t(11); break; } // Variance
                    case 12: { res = t(12); break; } // Stdev
                    case 13: { res = t(13); break; } // Skewness
                    case 14: { res = t(14); break; } // Kurtosis
                    case 15: { res = t(15); break; } // KurtosisExcess
                    case 16: { res = t(16); break; } // support_lower_endpoint
                    case 17: { res = t(17); break; } // support_right
                    case 18: { res = t(18); break; } // range_left
                    case 19: { res = t(19); break; } // range_right
                    default: break;
                }
                return res;
            }

            public KumaraswamyDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_kumaraswamy/*' />
        public static KumaraswamyDistClass dist_kumaraswamy(Mpfr a, Mpfr b)
        {
            return new KumaraswamyDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_kumaraswamy/*' />
        public static KumaraswamyDistClass dist_kumaraswamy(dynamic a, dynamic b)
        {
            return dist_kumaraswamy(t(a), t(b));
        }

        #endregion






        #region LaplaceDist


        public class LaplaceDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_LaplaceDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LaplaceDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_LaplaceDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public LaplaceDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/LaplaceDist/*' />
        public static LaplaceDistClass dist_laplace(Mpfr a, Mpfr b)
        {
            return new LaplaceDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/LaplaceDist/*' />
        public static LaplaceDistClass dist_laplace(dynamic a, dynamic b)
        {
            return dist_laplace(mreal.t(a), mreal.t(b));
        }

        #endregion




        #region LogisticDist


        public class LogisticDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_LogisticDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LogisticDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_LogisticDist(int target, IntPtr res, IntPtr xqp, IntPtr loc, IntPtr scale, uint dps);

            public LogisticDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/LogisticDist/*' />
        public static LogisticDistClass dist_logistic(Mpfr a, Mpfr b)
        {
            return new LogisticDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/LogisticDist/*' />
        public static LogisticDistClass dist_logistic(dynamic a, dynamic b)
        {
            return dist_logistic(mreal.t(a), mreal.t(b));
        }

        #endregion




        #region ParetoDist


        public class ParetoDistClass : BaseDistContClass
        {
            Mpfr k;
            Mpfr a;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_ParetoDist(target, res.mpPtr, xqp.mpPtr, k.mpPtr, a.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ParetoDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_ParetoDist(int target, IntPtr res, IntPtr xqp, IntPtr k, IntPtr a, uint dps);

            public ParetoDistClass(Mpfr _k, Mpfr _a)
            {
                k = _k;
                a = _a;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ParetoDist/*' />
        public static ParetoDistClass dist_pareto(Mpfr k, Mpfr a)
        {
            return new ParetoDistClass(k, a);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ParetoDist/*' />
        public static ParetoDistClass dist_pareto(dynamic k, dynamic a)
        {
            return dist_pareto(mreal.t(k), mreal.t(a));
        }

        #endregion




        #region RayleighDist


        public class RayleighDistClass : BaseDistContClass
        {
            Mpfr b;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_RayleighDist(target, res.mpPtr, xqp.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_RayleighDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_RayleighDist(int target, IntPtr res, IntPtr xqp, IntPtr b, uint dps);

            public RayleighDistClass(Mpfr _b)
            {
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/RayleighDist/*' />
        public static RayleighDistClass dist_rayleigh(Mpfr b)
        {
            return new RayleighDistClass(b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/RayleighDist/*' />
        public static RayleighDistClass dist_rayleigh(dynamic b)
        {
            return dist_rayleigh(mreal.t(b));
        }

        #endregion




        #region TriangularDist


        public class TriangularDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr m;
            Mpfr b;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_TriangularDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, m.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_TriangularDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_TriangularDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr m, IntPtr b, uint dps);

            public TriangularDistClass(Mpfr _a, Mpfr _m, Mpfr _b)
            {
                a = _a;
                m = _m;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/TriangularDist/*' />
        public static TriangularDistClass dist_triangular(Mpfr a, Mpfr m, Mpfr b)
        {
            return new TriangularDistClass(a, m, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/TriangularDist/*' />
        public static TriangularDistClass dist_triangular(dynamic a, dynamic m, dynamic b)
        {
            return dist_triangular(mreal.t(a), mreal.t(m), mreal.t(b));
        }

        #endregion




        #region UniformDist


        public class UniformDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_UniformDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_UniformDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_UniformDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public UniformDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/UniformDist/*' />
        public static UniformDistClass dist_uniform(Mpfr a, Mpfr b)
        {
            return new UniformDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/UniformDist/*' />
        public static UniformDistClass dist_uniform(dynamic a, dynamic b)
        {
            return dist_uniform(mreal.t(a), mreal.t(b));
        }

        #endregion




        #region WeibullDist


        public class WeibullDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_WeibullDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_WeibullDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_WeibullDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public WeibullDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/WeibullDist/*' />
        public static WeibullDistClass dist_weibull(Mpfr a, Mpfr b)
        {
            return new WeibullDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/WeibullDist/*' />
        public static WeibullDistClass dist_weibull(dynamic a, dynamic b)
        {
            return dist_weibull(mreal.t(a), mreal.t(b));
        }

        #endregion


        #endregion



        #region Closed form distributions, based on the error function


        #region LevyDist


        public class LevyDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                Mpfr res = t(0);
                Mpfr pdf = t(0);
                Mpfr sf = t(0);
                if ((target == 1) || (target == 4))
                {
                    Mpfr s = sqrt(b / (2 * pi()));
                    Mpfr t = exp(-b / (2 * (xqp - a)));
                    Mpfr u = pow(xqp - a, 1.5);
                    pdf = s * t / u;
                }
                if ((target == 3) || (target == 4) || (target == 5))
                {
                    Mpfr s = sqrt(b / (2 * (xqp - a)));
                    sf = erf(s);
                }

                switch (target)
                {
                    case 1: { res = pdf; break; } // pdf
                    case 2:
                        {
                            Mpfr s = sqrt(b / (2 * (xqp - a)));
                            res = erfc(s); break;
                        } // cdf_P
                    case 3: { res = sf; break; } // sf, cdf_Q
                    case 4: { res = pdf / sf; break; } // Hazard
                    case 5: { res = -log(sf); break; } // CHF
                    case 6:
                        {
                            Mpfr s1 = erfc_inv(xqp);
                            s1 = 2 * s1 * s1;
                            res = a + b / s1; break;
                        } // qtf, Pinv
                    case 7:
                        {
                            Mpfr s1 = erf_inv(xqp);
                            s1 = 2 * s1 * s1;
                            res = a + b / s1; break;
                        } // isf, Qinv
                    case 8: { res = t(8); break; } // Mean
                    case 9: { res = t(9); break; } // Median
                    case 10: { res = t(10); break; } // Mode
                    case 11: { res = t(11); break; } // Variance
                    case 12: { res = t(12); break; } // Stdev
                    case 13: { res = t(13); break; } // Skewness
                    case 14: { res = t(14); break; } // Kurtosis
                    case 15: { res = t(15); break; } // KurtosisExcess
                    case 16: { res = t(16); break; } // support_lower_endpoint
                    case 17: { res = t(17); break; } // support_right
                    case 18: { res = t(18); break; } // range_left
                    case 19: { res = t(19); break; } // range_right
                    default: break;
                }
                return res;
            }

            public LevyDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_levy/*' />
        public static LevyDistClass dist_levy(Mpfr a, Mpfr b)
        {
            return new LevyDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_levy/*' />
        public static LevyDistClass dist_levy(dynamic a, dynamic b)
        {
            return dist_levy(t(a), t(b));
        }

        #endregion




        #region LognormalDist


        public class LognormalDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_LognormalDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_LognormalDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_LognormalDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public LognormalDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/LognormalDist/*' />
        public static LognormalDistClass dist_lognormal(Mpfr a, Mpfr b)
        {
            return new LognormalDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/LognormalDist/*' />
        public static LognormalDistClass dist_lognormal(dynamic a, dynamic b)
        {
            return dist_lognormal(mreal.t(a), mreal.t(b));
        }

        #endregion





        #region MoyalDist


        public class MoyalDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                Mpfr res = t(0);
                Mpfr pdf = t(0);
                Mpfr sf = t(0);
                if ((target == 1) || (target == 4))
                {
                    Mpfr t1 = (xqp - a) / (2 * b);
                    Mpfr t2 = t("0.5") * exp(-(xqp - a) / b);
                    Mpfr s = b * sqrt(2 * pi());
                    pdf = exp(-t1 - t2) / s;
                }
                if ((target == 3) || (target == 4) || (target == 5))
                {
                    Mpfr s = exp(-(xqp - a) / (2 * b)) / sqrt(2);
                    sf = erf(s);
                }

                switch (target)
                {
                    case 1: { res = pdf; break; } // pdf
                    case 2:
                        {
                            Mpfr s = exp(-(xqp - a) / (2 * b)) / sqrt(2);
                            res = erfc(s); break;
                        } // cdf_P
                    case 3: { res = sf; break; } // sf, cdf_Q
                    case 4: { res = pdf / sf; break; } // Hazard
                    case 5: { res = -log(sf); break; } // CHF
                    case 6:
                        {
                            Mpfr s1 = erfc_inv(xqp);
                            s1 = 2 * s1 * s1;
                            res = a - b * log(s1); break;
                        } // qtf, Pinv
                    case 7:
                        {
                            Mpfr s1 = erf_inv(xqp);
                            s1 = 2 * s1 * s1;
                            res = a - b * log(s1); break;
                        } // isf, Qinv
                    case 8: { res = t(8); break; } // Mean
                    case 9: { res = t(9); break; } // Median
                    case 10: { res = t(10); break; } // Mode
                    case 11: { res = t(11); break; } // Variance
                    case 12: { res = t(12); break; } // Stdev
                    case 13: { res = t(13); break; } // Skewness
                    case 14: { res = t(14); break; } // Kurtosis
                    case 15: { res = t(15); break; } // KurtosisExcess
                    case 16: { res = t(16); break; } // support_lower_endpoint
                    case 17: { res = t(17); break; } // support_right
                    case 18: { res = t(18); break; } // range_left
                    case 19: { res = t(19); break; } // range_right
                    default: break;
                }
                return res;
            }

            public MoyalDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_moyal/*' />
        public static MoyalDistClass dist_moyal(Mpfr a, Mpfr b)
        {
            return new MoyalDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_moyal/*' />
        public static MoyalDistClass dist_moyal(dynamic a, dynamic b)
        {
            return dist_moyal(t(a), t(b));
        }

        #endregion




        #region NormalDist


        public class NormalDistClass : BaseDistContClass
        {
            Mpfr mu;
            Mpfr sigma;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_NormalDist(target, res.mpPtr, xqp.mpPtr, mu.mpPtr, sigma.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_NormalDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_NormalDist(int target, IntPtr res, IntPtr xqp, IntPtr mu, IntPtr sigma, uint dps);

            public NormalDistClass(Mpfr _mu, Mpfr _sigma)
            {
                mu = _mu;
                sigma = _sigma;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/NormalDist/*' />
        public static NormalDistClass dist_normal(Mpfr mu, Mpfr sigma)
        {
            return new NormalDistClass(mu, sigma);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/NormalDist/*' />
        public static NormalDistClass dist_normal(dynamic mu, dynamic sigma)
        {
            return dist_normal(mreal.t(mu), mreal.t(sigma));
        }

        #endregion




        #region SkewNormalDist


        public class SkewNormalDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;
            Mpfr c;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_SkewNormalDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_SkewNormalDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_SkewNormalDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, IntPtr c, uint dps);

            public SkewNormalDistClass(Mpfr _a, Mpfr _b, Mpfr _c)
            {
                a = _a;
                b = _b;
                c = _c;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/SkewNormalDist/*' />
        public static SkewNormalDistClass dist_skewnormal(Mpfr a, Mpfr b, Mpfr c)
        {
            return new SkewNormalDistClass(a, b, c);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/SkewNormalDist/*' />
        public static SkewNormalDistClass dist_skewnormal(dynamic a, dynamic b, dynamic c)
        {
            return dist_skewnormal(mreal.t(a), mreal.t(b), mreal.t(c));
        }

        #endregion




        #region WaldDist
        // InverseGaussianDist

        public class WaldDistClass : BaseDistContClass
        {
            Mpfr mu;
            Mpfr b;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_WaldDist(target, res.mpPtr, xqp.mpPtr, mu.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_WaldDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_WaldDist(int target, IntPtr res, IntPtr xqp, IntPtr mu, IntPtr b, uint dps);

            public WaldDistClass(Mpfr _mu, Mpfr _b)
            {
                mu = _mu;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/WaldDist/*' />
        public static WaldDistClass dist_wald(Mpfr mu, Mpfr b)
        {
            return new WaldDistClass(mu, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/WaldDist/*' />
        public static WaldDistClass dist_wald(dynamic mu, dynamic b)
        {
            return dist_wald(mreal.t(mu), mreal.t(b));
        }

        #endregion





        #endregion



        #region Closed form distributions, based on the incomplete gamma function



        #region ChiDist


        public class ChiDistClass : BaseDistContClass
        {
            Mpfr n;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                Mpfr res = t(0);
                Mpfr pdf = t(0);
                Mpfr sf = t(0);
                if ((target == 1) || (target == 4))
                {
                    pdf = 2 * xqp * dist_chi2(n).pdf(xqp * xqp);
                }
                if ((target == 3) || (target == 4) || (target == 5))
                {
                    sf = dist_chi2(n).sf(xqp * xqp);
                }

                switch (target)
                {
                    case 1: { res = pdf; break; } // pdf
                    case 2:
                        {
                            res = dist_chi2(n).cdf(xqp * xqp); break;
                        } // cdf_P
                    case 3: { res = sf; break; } // sf, cdf_Q
                    case 4: { res = pdf / sf; break; } // Hazard
                    case 5: { res = -log(sf); break; } // CHF
                    case 6:
                        {
                            res = sqrt(dist_chi2(n).qtf(xqp)); break;
                        } // qtf, Pinv
                    case 7:
                        {
                            res = sqrt(dist_chi2(n).isf(xqp)); break;
                        } // isf, Qinv
                    case 8: { res = t(8); break; } // Mean
                    case 9: { res = t(9); break; } // Median
                    case 10: { res = t(10); break; } // Mode
                    case 11: { res = t(11); break; } // Variance
                    case 12: { res = t(12); break; } // Stdev
                    case 13: { res = t(13); break; } // Skewness
                    case 14: { res = t(14); break; } // Kurtosis
                    case 15: { res = t(15); break; } // KurtosisExcess
                    case 16: { res = t(16); break; } // support_lower_endpoint
                    case 17: { res = t(17); break; } // support_right
                    case 18: { res = t(18); break; } // range_left
                    case 19: { res = t(19); break; } // range_right
                    default: break;
                }
                return res;
            }

            public ChiDistClass(Mpfr _n)
            {
                n = _n;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_chi/*' />
        public static ChiDistClass dist_chi(Mpfr n)
        {
            return new ChiDistClass(n);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_chi/*' />
        public static ChiDistClass dist_chi(dynamic n)
        {
            return dist_chi(t(n));
        }

        #endregion





        #region Chi2Dist


        public class Chi2DistClass : BaseDistContClass
        {
            Mpfr n;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_Chi2Dist(target, res.mpPtr, xqp.mpPtr, n.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Chi2Dist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_Chi2Dist(int target, IntPtr res, IntPtr xqp, IntPtr n, uint dps);

            public Chi2DistClass(Mpfr _n)
            {
                n = _n;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Chi2Dist/*' />
        public static Chi2DistClass dist_chi2(Mpfr n)
        {
            return new Chi2DistClass(n);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Chi2Dist/*' />
        public static Chi2DistClass dist_chi2(dynamic n)
        {
            return dist_chi2(mreal.t(n));
        }

        #endregion




        #region GammaDist


        public class GammaDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_GammaDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GammaDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_GammaDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public GammaDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GammaDist/*' />
        public static GammaDistClass dist_gamma(Mpfr a, Mpfr b)
        {
            return new GammaDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GammaDist/*' />
        public static GammaDistClass dist_gamma(dynamic a, dynamic b)
        {
            return dist_gamma(mreal.t(a), mreal.t(b));
        }

        #endregion




        #region InverseChi2Dist
        // a = df, b = scale

        public class InverseChi2DistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_InverseChi2Dist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_InverseChi2Dist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_InverseChi2Dist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public InverseChi2DistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/InverseChi2Dist/*' />
        public static InverseChi2DistClass dist_inverse_chi2(Mpfr a, Mpfr b)
        {
            return new InverseChi2DistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/InverseChi2Dist/*' />
        public static InverseChi2DistClass dist_inverse_chi2(dynamic a, dynamic b)
        {
            return dist_inverse_chi2(mreal.t(a), mreal.t(b));
        }

        #endregion




        #region InverseGammaDist
        // a = df, b = scale

        public class InverseGammaDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_InverseGammaDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_InverseGammaDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_InverseGammaDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public InverseGammaDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/InverseGammaDist/*' />
        public static InverseGammaDistClass dist_inverse_gamma(Mpfr a, Mpfr b)
        {
            return new InverseGammaDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/InverseGammaDist/*' />
        public static InverseGammaDistClass dist_inverse_gamma(dynamic a, dynamic b)
        {
            return dist_inverse_gamma(mreal.t(a), mreal.t(b));
        }

        #endregion




        #region MaxwellDist


        public class MaxwellDistClass : BaseDistContClass
        {
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                Mpfr res = t(0);
                Mpfr pdf = t(0);
                Mpfr sf = t(0);
                if ((target == 1) || (target == 4))
                {
                    Mpfr s = sqrt(2 / pi());
                    Mpfr t = (xqp * xqp) / (b * b * b);
                    Mpfr u = exp(-(xqp * xqp) / (2 * b * b));
                    pdf = s * t * u;
                }
                if ((target == 3) || (target == 4) || (target == 5))
                {
                    Mpfr n = t(1.5);
                    Mpfr t2 = (xqp * xqp) / (2 * b * b);
                    sf = gamma_q(n, t2);
                }

                switch (target)
                {
                    case 1: { res = pdf; break; } // pdf
                    case 2:
                        {
                            Mpfr n = t(1.5);
                            Mpfr t2 = (xqp * xqp) / (2 * b * b);
                            res = gamma_p(n, t2);
                            break;
                        } // cdf_P
                    case 3: { res = sf; break; } // sf, cdf_Q
                    case 4: { res = pdf / sf; break; } // Hazard
                    case 5: { res = -log(sf); break; } // CHF
                    case 6:
                        {
                            Mpfr n = t(1.5);
                            Mpfr t2 = (xqp * xqp) / (2 * b * b);
                            res = b * sqrt(2 * gamma_p_inv(n, xqp));
                            break;
                        } // qtf, Pinv
                    case 7:
                        {
                            Mpfr n = t(1.5);
                            Mpfr t2 = (xqp * xqp) / (2 * b * b);
                            res = b * sqrt(2 * gamma_q_inv(n, xqp));
                            break;
                        } // isf, Qinv
                    case 8: { res = t(8); break; } // Mean
                    case 9: { res = t(9); break; } // Median
                    case 10: { res = t(10); break; } // Mode
                    case 11: { res = t(11); break; } // Variance
                    case 12: { res = t(12); break; } // Stdev
                    case 13: { res = t(13); break; } // Skewness
                    case 14: { res = t(14); break; } // Kurtosis
                    case 15: { res = t(15); break; } // KurtosisExcess
                    case 16: { res = t(16); break; } // support_lower_endpoint
                    case 17: { res = t(17); break; } // support_right
                    case 18: { res = t(18); break; } // range_left
                    case 19: { res = t(19); break; } // range_right
                    default: break;
                }
                return res;
            }

            public MaxwellDistClass(Mpfr _b)
            {
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_maxwell/*' />
        public static MaxwellDistClass dist_maxwell(Mpfr b)
        {
            return new MaxwellDistClass(b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_maxwell/*' />
        public static MaxwellDistClass dist_maxwell(dynamic b)
        {
            return dist_maxwell(t(b));
        }

        #endregion



        #region NakagamiDist


        public class NakagamiDistClass : BaseDistContClass
        {
            Mpfr m;
            Mpfr w;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                Mpfr res = t(0);
                Mpfr pdf = t(0);
                Mpfr sf = t(0);
                if ((target == 1) || (target == 4))
                {
                    Mpfr s = exp(-m * xqp * xqp / w) * 2 * pow(m / w, m) * pow(xqp, 2 * m - 1);
                    Mpfr t = gamma(m);
                    pdf = s / t;
                }
                if ((target == 3) || (target == 4) || (target == 5))
                {
                    sf = gamma_q(m, m * xqp * xqp / w);
                }

                switch (target)
                {
                    case 1: { res = pdf; break; } // pdf
                    case 2:
                        {
                            res = gamma_p(m, m * xqp * xqp / w);
                            break;
                        } // cdf_P
                    case 3: { res = sf; break; } // sf, cdf_Q
                    case 4: { res = pdf / sf; break; } // Hazard
                    case 5: { res = -log(sf); break; } // CHF
                    case 6:
                        {
                            res = sqrt((w / m) * gamma_p_inv(m, xqp));
                            break;
                        } // qtf, Pinv
                    case 7:
                        {
                            res = sqrt((w / m) * gamma_q_inv(m, xqp));
                            break;
                        } // isf, Qinv
                    case 8: { res = t(8); break; } // Mean
                    case 9: { res = t(9); break; } // Median
                    case 10: { res = t(10); break; } // Mode
                    case 11: { res = t(11); break; } // Variance
                    case 12: { res = t(12); break; } // Stdev
                    case 13: { res = t(13); break; } // Skewness
                    case 14: { res = t(14); break; } // Kurtosis
                    case 15: { res = t(15); break; } // KurtosisExcess
                    case 16: { res = t(16); break; } // support_lower_endpoint
                    case 17: { res = t(17); break; } // support_right
                    case 18: { res = t(18); break; } // range_left
                    case 19: { res = t(19); break; } // range_right
                    default: break;
                }
                return res;
            }

            public NakagamiDistClass(Mpfr _m, Mpfr _w)
            {
                m = _m;
                w = _w;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_nakagami/*' />
        public static NakagamiDistClass dist_nakagami(Mpfr m, Mpfr w)
        {
            return new NakagamiDistClass(m, w);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/dist_nakagami/*' />
        public static NakagamiDistClass dist_nakagami(dynamic m, dynamic w)
        {
            return dist_nakagami(t(m), t(w));
        }

        #endregion







        #endregion



        #region Closed form distributions, based on the incomplete beta function


        #region BetaDist


        public class BetaDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_BetaDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BetaDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_BetaDist(int target, IntPtr res, IntPtr xqp, IntPtr a, IntPtr b, uint dps);

            public BetaDistClass(Mpfr _a, Mpfr _b)
            {
                a = _a;
                b = _b;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BetaDist/*' />
        public static BetaDistClass dist_beta(Mpfr a, Mpfr b)
        {
            return new BetaDistClass(a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BetaDist/*' />
        public static BetaDistClass dist_beta(dynamic a, dynamic b)
        {
            return dist_beta(mreal.t(a), mreal.t(b));
        }

        #endregion



        #region FisherFDist


        public class FisherFDistClass : BaseDistContClass
        {
            Mpfr m;
            Mpfr n;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_FisherFDist(target, res.mpPtr, xqp.mpPtr, m.mpPtr, n.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_FisherFDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_FisherFDist(int target, IntPtr res, IntPtr xqp, IntPtr m, IntPtr n, uint dps);

            public FisherFDistClass(Mpfr _m, Mpfr _n)
            {
                m = _m;
                n = _n;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/FisherFDist/*' />
        public static FisherFDistClass dist_fisher_f(Mpfr m, Mpfr n)
        {
            return new FisherFDistClass(m, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/FisherFDist/*' />
        public static FisherFDistClass dist_fisher_f(dynamic m, dynamic n)
        {
            return dist_fisher_f(mreal.t(m), mreal.t(n));
        }

        #endregion



        #region StudentTDist


        public class StudentTDistClass : BaseDistContClass
        {
            Mpfr n;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_StudentTDist(target, res.mpPtr, xqp.mpPtr, n.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_StudentTDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_StudentTDist(int target, IntPtr res, IntPtr xqp, IntPtr n, uint dps);

            public StudentTDistClass(Mpfr _n)
            {
                n = _n;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/StudentTDist/*' />
        public static StudentTDistClass dist_student_t(Mpfr n)
        {
            return new StudentTDistClass(n);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/StudentTDist/*' />
        public static StudentTDistClass dist_student_t(dynamic n)
        {
            return dist_student_t(mreal.t(n));
        }

        #endregion


        #endregion




        #region Non-central distribution functions


        #region Chi2NcDist


        public class Chi2NcDistClass : BaseDistContClass
        {
            Mpfr n;
            Mpfr lambda1;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_Chi2NcDist(target, res.mpPtr, xqp.mpPtr, n.mpPtr, lambda1.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Chi2NcDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_Chi2NcDist(int target, IntPtr res, IntPtr xqp, IntPtr n, IntPtr lambda1, uint dps);

            public Chi2NcDistClass(Mpfr _n, Mpfr _lambda1)
            {
                n = _n;
                lambda1 = _lambda1;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Chi2NcDist/*' />
        public static Chi2NcDistClass dist_chi2_nc(Mpfr n, Mpfr lambda1)
        {
            return new Chi2NcDistClass(n, lambda1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Chi2NcDist/*' />
        public static Chi2NcDistClass dist_chi2_nc(dynamic n, dynamic lambda1)
        {
            return dist_chi2_nc(mreal.t(n), mreal.t(lambda1));
        }

        #endregion



        #region StudentTNcDist


        public class StudentTNcDistClass : BaseDistContClass
        {
            Mpfr n;
            Mpfr delta;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_StudentTNcDist(target, res.mpPtr, xqp.mpPtr, n.mpPtr, delta.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_StudentTNcDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_StudentTNcDist(int target, IntPtr res, IntPtr xqp, IntPtr n, IntPtr delta, uint dps);

            public StudentTNcDistClass(Mpfr _n, Mpfr _delta)
            {
                n = _n;
                delta = _delta;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/StudentTNcDist/*' />
        public static StudentTNcDistClass dist_student_t_nc(Mpfr n, Mpfr delta)
        {
            return new StudentTNcDistClass(n, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/StudentTNcDist/*' />
        public static StudentTNcDistClass dist_student_t_nc(dynamic n, dynamic delta)
        {
            return dist_student_t_nc(mreal.t(n), mreal.t(delta));
        }

        #endregion



        #region FisherFNcDist


        public class FisherFNcDistClass : BaseDistContClass
        {
            Mpfr m;
            Mpfr n;
            Mpfr lambda1;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_FisherNcDist(target, res.mpPtr, xqp.mpPtr, m.mpPtr, n.mpPtr, lambda1.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_FisherNcDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_FisherNcDist(int target, IntPtr res, IntPtr xqp, IntPtr m, IntPtr n, IntPtr lambda1, uint dps);

            public FisherFNcDistClass(Mpfr _m, Mpfr _n, Mpfr _lambda1)
            {
                m = _m;
                n = _n;
                lambda1 = _lambda1;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/FisherNcDist/*' />
        public static FisherFNcDistClass dist_fisher_f_nc(Mpfr m, Mpfr n, Mpfr lambda1)
        {
            return new FisherFNcDistClass(m, n, lambda1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/FisherNcDist/*' />
        public static FisherFNcDistClass dist_fisher_f_nc(dynamic m, dynamic n, dynamic lambda1)
        {
            return dist_fisher_f_nc(mreal.t(m), mreal.t(n), mreal.t(lambda1));
        }

        #endregion



        #region BetaNcDist


        public class BetaNcDistClass : BaseDistContClass
        {
            Mpfr a;
            Mpfr b;
            Mpfr lambda1;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_BetaNcDist(target, res.mpPtr, xqp.mpPtr, a.mpPtr, b.mpPtr, lambda1.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BetaNcDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_BetaNcDist(int target, IntPtr res, IntPtr xqp, IntPtr nu, IntPtr mu, IntPtr lambda1, uint dps);

            public BetaNcDistClass(Mpfr _a, Mpfr _b, Mpfr _lambda1)
            {
                a = _a;
                b = _b;
                lambda1 = _lambda1;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BetaNcDist/*' />
        public static BetaNcDistClass dist_beta_nc(Mpfr a, Mpfr b, Mpfr lambda1)
        {
            return new BetaNcDistClass(a, b, lambda1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BetaNcDist/*' />
        public static BetaNcDistClass dist_beta_nc(dynamic a, dynamic b, dynamic lambda1)
        {
            return dist_beta_nc(mreal.t(a), mreal.t(b), mreal.t(lambda1));
        }

        #endregion



        #endregion








        #region Discrete (lattice) distribution functions


        #region BernoulliDist


        public class BernoulliDistClass : BaseDistDiscreteClass
        {
            Mpfr p;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_BernoulliDist(target, res.mpPtr, xqp.mpPtr, p.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BernoulliDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_BernoulliDist(int target, IntPtr res, IntPtr xqp, IntPtr p, uint dps);

            public BernoulliDistClass(Mpfr _p)
            {
                p = _p;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BernoulliDist/*' />
        public static BernoulliDistClass dist_bernoulli(Mpfr p)
        {
            return new BernoulliDistClass(p);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BernoulliDist/*' />
        public static BernoulliDistClass dist_bernoulli(dynamic p)
        {
            return dist_bernoulli(mreal.t(p));
        }

        #endregion



        #region GeometricDist


        public class GeometricDistClass : BaseDistDiscreteClass
        {
            Mpfr p;

            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_GeometricDist(target, res.mpPtr, xqp.mpPtr, p.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GeometricDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_GeometricDist(int target, IntPtr res, IntPtr xqp, IntPtr p, uint dps);

            public GeometricDistClass(Mpfr _p)
            {
                p = _p;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GeometricDist/*' />
        public static GeometricDistClass dist_geometric(Mpfr p)
        {
            return new GeometricDistClass(p);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GeometricDist/*' />
        public static GeometricDistClass dist_geometric(dynamic p)
        {
            return dist_geometric(mreal.t(p));
        }

        #endregion



        #region PoissonDist


        public class PoissonDistClass : BaseDistDiscreteClass
        {
            Mpfr mu;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_PoissonDist(target, res.mpPtr, xqp.mpPtr, mu.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_PoissonDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_PoissonDist(int target, IntPtr res, IntPtr xqp, IntPtr mu, uint dps);

            public PoissonDistClass(Mpfr _mu)
            {
                mu = _mu;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/PoissonDist/*' />
        public static PoissonDistClass dist_poisson(Mpfr mu)
        {
            return new PoissonDistClass(mu);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/PoissonDist/*' />
        public static PoissonDistClass dist_poisson(dynamic mu)
        {
            return dist_poisson(mreal.t(mu));
        }

        #endregion



        #region BinomialDist


        public class BinomialDistClass : BaseDistDiscreteClass
        {
            Mpfr n;
            Mpfr p;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_BinomialDist(target, res.mpPtr, xqp.mpPtr, n.mpPtr, p.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BinomialDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_BinomialDist(int target, IntPtr res, IntPtr xqp, IntPtr n, IntPtr p, uint dps);

            public BinomialDistClass(Mpfr _n, Mpfr _p)
            {
                n = _n;
                p = _p;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BinomialDist/*' />
        public static BinomialDistClass dist_binomial(Mpfr n, Mpfr p)
        {
            return new BinomialDistClass(n, p);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BinomialDist/*' />
        public static BinomialDistClass dist_binomial(dynamic n, dynamic p)
        {
            return dist_binomial(mreal.t(n), mreal.t(p));
        }

        #endregion



        #region NegBinomialDist


        public class NegBinomialDistClass : BaseDistDiscreteClass
        {
            Mpfr r;
            Mpfr p;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_NegBinomialDist(target, res.mpPtr, xqp.mpPtr, r.mpPtr, p.mpPtr, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_NegBinomialDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_NegBinomialDist(int target, IntPtr res, IntPtr xqp, IntPtr r, IntPtr p, uint dps);

            public NegBinomialDistClass(Mpfr _r, Mpfr _p)
            {
                r = _r;
                p = _p;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/NegBinomialDist/*' />
        public static NegBinomialDistClass dist_negbinomial(Mpfr r, Mpfr p)
        {
            return new NegBinomialDistClass(r, p);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/NegBinomialDist/*' />
        public static NegBinomialDistClass dist_negbinomial(dynamic r, dynamic p)
        {
            return dist_negbinomial(mreal.t(r), mreal.t(p));
        }

        #endregion



        #region HypergeometricDist


        public class HypergeometricDistClass : BaseDistDiscreteClass
        {
            internal UInt64 r__;
            internal UInt64 n__;
            internal UInt64 NN__;
            internal override Mpfr BaseDist(Mpfr xqp)
            {
                var res = new Mpfr();
                Lib_Mpfr_HypergeometricDist(target, res.mpPtr, xqp.mpPtr, r__, n__, NN__, ArbPrec.GetDps());
                return res;
            }
            [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_HypergeometricDist", CallingConvention = CallingConvention.Cdecl)]
            internal static extern void Lib_Mpfr_HypergeometricDist(int target, IntPtr res, IntPtr xqp, UInt64 r, UInt64 n, UInt64 NN, uint dps);

            public HypergeometricDistClass(UInt64 r, UInt64 n, UInt64 NN)
            {
                r__ = r;
                n__ = n;
                NN__ = NN;
            }
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/HypergeometricDist/*' />
        public static HypergeometricDistClass dist_hypergeometric(UInt64 r, UInt64 n, UInt64 NN)
        {
            return new HypergeometricDistClass(r, n, NN);
        }

        ///// <include file="docs.xml" path='docs/members[@name="Boost"]/HypergeometricDist/*' />
        //public static HypergeometricDistClass dist_hypergeometric(dynamic r, dynamic n, dynamic NN)
        //{
        //    return dist_hypergeometric(mreal.t(r), mreal.t(n), mreal.t(NN));
        //}

        #endregion








        #endregion



        #endregion







        #region Boost Calculus


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Set(IntPtr res, IntPtr x);







        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BracketRoot/*' />
        public static Tuple<Mpfr, Mpfr, int> BracketRoot(cb1SMpfr1S f, dynamic guess, dynamic factor, bool is_rising, int get_digits, uint maxit)
        {
            return BracketRoot(f, mreal.t(guess), mreal.t(factor), is_rising, get_digits, maxit);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BracketRoot/*' />
        public static Tuple<Mpfr, Mpfr, int> BracketRoot(cb1SMpfr1S f, Mpfr guess, Mpfr factor, bool is_rising, int get_digits, uint maxit)
        {
            var OBracketRoot1 = new OBracketRoot(f, guess, factor, is_rising, get_digits, maxit);
            return OBracketRoot1.Find();
        }
        internal class OBracketRoot
        {
            private cb1SMpfr1S F1_;
            private Mpfr guess_;
            private Mpfr factor_;
            private bool is_rising_;
            private int get_digits_;
            private uint maxit_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OBracketRoot(cb1SMpfr1S F1, Mpfr guess, Mpfr factor, bool is_rising, int get_digits, uint maxit)
            {
                F1_ = F1;
                guess_ = guess;
                factor_ = factor;
                is_rising_ = is_rising;
                get_digits_ = get_digits;
                maxit_ = maxit;
            }
            public Tuple<Mpfr, Mpfr, int> Find()
            {
                var res1 = new Mpfr();
                var res2 = new Mpfr();
                var iter = 0;
                Lib_Mpfr_BracketRoot(res1.mpPtr, res2.mpPtr, ref iter, funcptr1, guess_.mpPtr, factor_.mpPtr, is_rising_, get_digits_, maxit_);
                return new Tuple<Mpfr, Mpfr, int>(res1, res2, iter);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_BracketRoot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_BracketRoot(IntPtr res1, IntPtr res2, ref int iter, cb2Ptr f, IntPtr guess, IntPtr factor, bool is_rising, int get_digits, uint maxit);





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/NewtonRaphson/*' />
        public static Tuple<Mpfr, int> NewtonRaphson(cb1SMpfr1S f, cb1SMpfr1S df, dynamic guess, dynamic xmin, dynamic xmax, int get_digits, uint maxit)
        {
            return NewtonRaphson(f, df, mreal.t(guess), mreal.t(xmin), mreal.t(xmax), get_digits, maxit);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/NewtonRaphson/*' />
        public static Tuple<Mpfr, int> NewtonRaphson(cb1SMpfr1S f, cb1SMpfr1S df, Mpfr guess, Mpfr xmin, Mpfr xmax, int get_digits, uint maxit)
        {
            var ONewtonRaphson1 = new ONewtonRaphson(f, df, guess, xmin, xmax, get_digits, maxit);
            return ONewtonRaphson1.Find();
        }
        internal class ONewtonRaphson
        {
            private cb1SMpfr1S F1_;
            private cb1SMpfr1S DF1_;
            private Mpfr guess_;
            private Mpfr xmin_;
            private Mpfr xmax_;
            private int get_digits_;
            private uint maxit_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            private Mpfr DX1 = new Mpfr();
            private Mpfr DY1 = new Mpfr();
            public void funcptr0(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public void funcptr1(IntPtr dxPtr, IntPtr dfxPtr)
            {
                Lib_Mpfr_Set(DX1.mpPtr, dxPtr);
                DY1 = DF1_(DX1);
                Lib_Mpfr_Set(dfxPtr, DY1.mpPtr);
            }
            public ONewtonRaphson(cb1SMpfr1S F1, cb1SMpfr1S DF1, Mpfr guess, Mpfr xmin, Mpfr xmax, int get_digits, uint maxit)
            {
                F1_ = F1;
                DF1_ = DF1;
                guess_ = guess;
                xmin_ = xmin;
                xmax_ = xmax;
                get_digits_ = get_digits;
                maxit_ = maxit;
            }
            public Tuple<Mpfr, int> Find()
            {
                var res1 = new Mpfr();
                var iter = 0;
                Lib_Mpfr_NewtonRaphson(res1.mpPtr, ref iter, funcptr0, funcptr1, guess_.mpPtr, xmin_.mpPtr, xmax_.mpPtr, get_digits_, maxit_);
                return new Tuple<Mpfr, int>(res1, iter);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_NewtonRaphson", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_NewtonRaphson(IntPtr res, ref int iter, cb2Ptr f1, cb2Ptr df1, IntPtr guess, IntPtr xmin, IntPtr xmax, int get_digits, uint maxit);






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Halley/*' />
        public static Tuple<Mpfr, int> Halley(cb1SMpfr1S f, cb1SMpfr1S df1, cb1SMpfr1S df2, dynamic guess, dynamic xmin, dynamic xmax, int get_digits, uint maxit)
        {
            return Halley(f, df1, df2, mreal.t(guess), mreal.t(xmin), mreal.t(xmax), get_digits, maxit);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Halley/*' />
        public static Tuple<Mpfr, int> Halley(cb1SMpfr1S f, cb1SMpfr1S df1, cb1SMpfr1S df2, Mpfr guess, Mpfr xmin, Mpfr xmax, int get_digits, uint maxit)
        {
            var OHalley1 = new OHalley(f, df1, df2, guess, xmin, xmax, get_digits, maxit);
            return OHalley1.Find();
        }
        internal class OHalley
        {
            private cb1SMpfr1S F1_;
            private cb1SMpfr1S DF1_;
            private cb1SMpfr1S DF2_;
            private Mpfr guess_;
            private Mpfr xmin_;
            private Mpfr xmax_;
            private int get_digits_;
            private uint maxit_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            private Mpfr DX1 = new Mpfr();
            private Mpfr DY1 = new Mpfr();
            private Mpfr D2X1 = new Mpfr();
            private Mpfr D2Y1 = new Mpfr();
            public void funcptr0(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public void funcptr1(IntPtr dxPtr, IntPtr dfxPtr)
            {
                Lib_Mpfr_Set(DX1.mpPtr, dxPtr);
                DY1 = DF1_(DX1);
                Lib_Mpfr_Set(dfxPtr, DY1.mpPtr);
            }
            public void funcptr2(IntPtr d2xPtr, IntPtr d2fxPtr)
            {
                Lib_Mpfr_Set(D2X1.mpPtr, d2xPtr);
                D2Y1 = DF2_(DX1);
                Lib_Mpfr_Set(d2fxPtr, D2Y1.mpPtr);
            }
            public OHalley(cb1SMpfr1S F1, cb1SMpfr1S DF1, cb1SMpfr1S DF2, Mpfr guess, Mpfr xmin, Mpfr xmax, int get_digits, uint maxit)
            {
                F1_ = F1;
                DF1_ = DF1;
                DF2_ = DF2;
                guess_ = guess;
                xmin_ = xmin;
                xmax_ = xmax;
                get_digits_ = get_digits;
                maxit_ = maxit;
            }
            public Tuple<Mpfr, int> Find()
            {
                var res1 = new Mpfr();
                var iter = 0;
                Lib_Mpfr_Halley(res1.mpPtr, ref iter, funcptr0, funcptr1, funcptr2, guess_.mpPtr, xmin_.mpPtr, xmax_.mpPtr, get_digits_, maxit_);
                return new Tuple<Mpfr, int>(res1, iter);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Halley", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Halley(IntPtr res, ref int iter, cb2Ptr f1, cb2Ptr df1, cb2Ptr df2, IntPtr guess, IntPtr xmin, IntPtr xmax, int get_digits, uint maxit);






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Schroder/*' />
        public static Tuple<Mpfr, int> Schroder(cb1SMpfr1S f, cb1SMpfr1S df1, cb1SMpfr1S df2, dynamic guess, dynamic xmin, dynamic xmax, int get_digits, uint maxit)
        {
            return Schroder(f, df1, df2, mreal.t(guess), mreal.t(xmin), mreal.t(xmax), get_digits, maxit);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Schroder/*' />
        public static Tuple<Mpfr, int> Schroder(cb1SMpfr1S f, cb1SMpfr1S df1, cb1SMpfr1S df2, Mpfr guess, Mpfr xmin, Mpfr xmax, int get_digits, uint maxit)
        {
            var OSchroder1 = new OSchroder(f, df1, df2, guess, xmin, xmax, get_digits, maxit);
            return OSchroder1.Find();
        }
        internal class OSchroder
        {
            private cb1SMpfr1S F1_;
            private cb1SMpfr1S DF1_;
            private cb1SMpfr1S DF2_;
            private Mpfr guess_;
            private Mpfr xmin_;
            private Mpfr xmax_;
            private int get_digits_;
            private uint maxit_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            private Mpfr DX1 = new Mpfr();
            private Mpfr DY1 = new Mpfr();
            private Mpfr D2X1 = new Mpfr();
            private Mpfr D2Y1 = new Mpfr();
            public void funcptr0(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public void funcptr1(IntPtr dxPtr, IntPtr dfxPtr)
            {
                Lib_Mpfr_Set(DX1.mpPtr, dxPtr);
                DY1 = DF1_(DX1);
                Lib_Mpfr_Set(dfxPtr, DY1.mpPtr);
            }
            public void funcptr2(IntPtr d2xPtr, IntPtr d2fxPtr)
            {
                Lib_Mpfr_Set(D2X1.mpPtr, d2xPtr);
                D2Y1 = DF2_(DX1);
                Lib_Mpfr_Set(d2fxPtr, D2Y1.mpPtr);
            }
            public OSchroder(cb1SMpfr1S F1, cb1SMpfr1S DF1, cb1SMpfr1S DF2, Mpfr guess, Mpfr xmin, Mpfr xmax, int get_digits, uint maxit)
            {
                F1_ = F1;
                DF1_ = DF1;
                DF2_ = DF2;
                guess_ = guess;
                xmin_ = xmin;
                xmax_ = xmax;
                get_digits_ = get_digits;
                maxit_ = maxit;
            }
            public Tuple<Mpfr, int> Find()
            {
                var res1 = new Mpfr();
                var iter = 0;
                Lib_Mpfr_Schroder(res1.mpPtr, ref iter, funcptr0, funcptr1, funcptr2, guess_.mpPtr, xmin_.mpPtr, xmax_.mpPtr, get_digits_, maxit_);
                return new Tuple<Mpfr, int>(res1, iter);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Schroder", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Schroder(IntPtr res, ref int iter, cb2Ptr f1, cb2Ptr df1, cb2Ptr df2, IntPtr guess, IntPtr xmin, IntPtr xmax, int get_digits, uint maxit);






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BrentMinimum/*' />
        public static Tuple<Mpfr, Mpfr, int> Brent_Minimum(cb1SMpfr1S f, dynamic bracket_min, dynamic bracket_max, int bits, uint maxit)
        {
            return Brent_Minimum(f, mreal.t(bracket_min), mreal.t(bracket_max), bits, maxit);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/BrentMinimum/*' />
        public static Tuple<Mpfr, Mpfr, int> Brent_Minimum(cb1SMpfr1S f, Mpfr bracket_min, Mpfr bracket_max, int bits, uint maxit)
        {
            var OBrent_Minimum1 = new OBrent_Minimum(f, bracket_min, bracket_max, bits, maxit);
            return OBrent_Minimum1.Find();
        }
        internal class OBrent_Minimum
        {
            private cb1SMpfr1S F1_;
            private Mpfr bracket_min_;
            private Mpfr bracket_max_;
            private int bits_;
            private uint maxit_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OBrent_Minimum(cb1SMpfr1S F1, Mpfr bracket_min, Mpfr bracket_max, int bits, uint maxit)
            {
                F1_ = F1;
                bracket_min_ = bracket_min;
                bracket_max_ = bracket_max;
                bits_ = bits;
                maxit_ = maxit;
            }
            public Tuple<Mpfr, Mpfr, int> Find()
            {
                var result = new Mpfr();
                var resultFx = new Mpfr();
                var iter = 0;
                Lib_Mpfr_Brent_Minimum(result.mpPtr, resultFx.mpPtr, ref iter, funcptr1, bracket_min_.mpPtr, bracket_max_.mpPtr, bits_, maxit_);
                return new Tuple<Mpfr, Mpfr, int>(result, resultFx, iter);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Brent_Minimum", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Brent_Minimum(IntPtr res, IntPtr resFx, ref int iter, cb2Ptr f, IntPtr bracket_min, IntPtr bracket_max, int bits, uint maxit);


        // ******************************************************************************************************************************************************************************************************************



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Trapezoidal/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr> Trapezoidal(cb1SMpfr1S f, dynamic a, dynamic b, dynamic tol = null, uint max_refinements = 12)
        {
            if (tol == null) { tol = t(0); }
            return Trapezoidal(f, mreal.t(a), mreal.t(b), mreal.t(tol), max_refinements);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/Trapezoidal/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr> Trapezoidal(cb1SMpfr1S f, Mpfr a, Mpfr b, Mpfr tol, uint max_refinements = 12)
        {
            var OTrapezoidal1 = new OTrapezoidal(f, a, b);
            return OTrapezoidal1.Integrate();
        }
        internal class OTrapezoidal
        {
            private cb1SMpfr1S F1_;
            private Mpfr a_;
            private Mpfr b_;
            //private Mpfr tol_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OTrapezoidal(cb1SMpfr1S F1, Mpfr a, Mpfr b)
            {
                F1_ = F1;
                a_ = a;
                b_ = b;
            }
            public Tuple<Mpfr, Mpfr, Mpfr> Integrate()
            {
                Mpfr res1 = new Mpfr(), res2 = new Mpfr(), res3 = new Mpfr();
                Lib_Mpfr_Trapezoidal(res1.mpPtr, res2.mpPtr, res3.mpPtr, funcptr1, a_.mpPtr, b_.mpPtr, ArbPrec.GetDps());
                return new Tuple<Mpfr, Mpfr, Mpfr>(res1, res2, res3);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Trapezoidal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Trapezoidal(IntPtr res1, IntPtr res2, IntPtr res3, cb2Ptr f, IntPtr a, IntPtr b, uint get_digits);





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GaussLegendre/*' />
        public static Tuple<Mpfr, Mpfr> GaussLegendre(cb1SMpfr1S f, dynamic a, dynamic b)
        {
            return GaussLegendre(f, mreal.t(a), mreal.t(b));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GaussLegendre/*' />
        public static Tuple<Mpfr, Mpfr> GaussLegendre(cb1SMpfr1S f, Mpfr a, Mpfr b)
        {
            var OGaussLegendre1 = new OGaussLegendre(f, a, b);
            return OGaussLegendre1.Integrate();
        }
        internal class OGaussLegendre
        {
            private cb1SMpfr1S F1_;
            private Mpfr a_;
            private Mpfr b_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OGaussLegendre(cb1SMpfr1S F1, Mpfr a, Mpfr b)
            {
                F1_ = F1;
                a_ = a;
                b_ = b;
            }
            public Tuple<Mpfr, Mpfr> Integrate()
            {
                Mpfr res1 = new Mpfr(), res3 = new Mpfr();
                Lib_Mpfr_GaussLegendre(res1.mpPtr, res3.mpPtr, funcptr1, a_.mpPtr, b_.mpPtr, ArbPrec.GetDps());
                return new Tuple<Mpfr, Mpfr>(res1, res3);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GaussLegendre", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GaussLegendre(IntPtr res1, IntPtr res3, cb2Ptr f, IntPtr a, IntPtr b, uint get_digits);






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GaussKronrod/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr> GaussKronrod(cb1SMpfr1S f, dynamic a, dynamic b, dynamic tol = null, uint max_depth = 12)
        {
            if (tol == null) { tol = t(0); }
            return GaussKronrod(f, mreal.t(a), mreal.t(b), mreal.t(tol), max_depth);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/GaussKronrod/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr> GaussKronrod(cb1SMpfr1S f, Mpfr a, Mpfr b, Mpfr tol, uint max_depth = 12)
        {
            var OGaussKronrod1 = new OGaussKronrod(f, a, b);
            return OGaussKronrod1.Integrate();
        }
        internal class OGaussKronrod
        {
            private cb1SMpfr1S F1_;
            private Mpfr a_;
            private Mpfr b_;
            //private Mpfr tol_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OGaussKronrod(cb1SMpfr1S F1, Mpfr a, Mpfr b)
            {
                F1_ = F1;
                a_ = a;
                b_ = b;
            }
            public Tuple<Mpfr, Mpfr, Mpfr> Integrate()
            {
                Mpfr res1 = new Mpfr(), res2 = new Mpfr(), res3 = new Mpfr();
                Lib_Mpfr_GaussKronrod(res1.mpPtr, res2.mpPtr, res3.mpPtr, funcptr1, a_.mpPtr, b_.mpPtr, ArbPrec.GetDps());
                return new Tuple<Mpfr, Mpfr, Mpfr>(res1, res2, res3);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_GaussKronrod", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_GaussKronrod(IntPtr res1, IntPtr res2, IntPtr res3, cb2Ptr f, IntPtr a, IntPtr b, uint get_digits);






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/TanhSinh/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr, int> TanhSinh(cb1SMpfr1S f, dynamic a, dynamic b, dynamic tol = null, uint max_refinements = 12)
        {
            if (tol == null) { tol = t(0); }
            return TanhSinh(f, mreal.t(a), mreal.t(b), mreal.t(tol), max_refinements);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/TanhSinh/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr, int> TanhSinh(cb1SMpfr1S f, Mpfr a, Mpfr b, Mpfr tol, uint max_refinements = 12)
        {
            var OTanhSinh1 = new OTanhSinh(f, a, b);
            return OTanhSinh1.Integrate();
        }
        internal class OTanhSinh
        {
            private cb1SMpfr1S F1_;
            private Mpfr a_;
            private Mpfr b_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OTanhSinh(cb1SMpfr1S F1, Mpfr a, Mpfr b)
            {
                F1_ = F1;
                a_ = a;
                b_ = b;
            }
            public Tuple<Mpfr, Mpfr, Mpfr, int> Integrate()
            {
                Mpfr res1 = new Mpfr(), res2 = new Mpfr(), res3 = new Mpfr();
                var levels = 0;
                Lib_Mpfr_TanhSinh(res1.mpPtr, res2.mpPtr, res3.mpPtr, ref levels, funcptr1, a_.mpPtr, b_.mpPtr, ArbPrec.GetDps());
                return new Tuple<Mpfr, Mpfr, Mpfr, int>(res1, res2, res3, levels);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_TanhSinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_TanhSinh(IntPtr res1, IntPtr res2, IntPtr res3, ref int levels, cb2Ptr f, IntPtr a, IntPtr b, uint get_digits);




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/SinhSinh/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr, int> SinhSinh(cb1SMpfr1S f, dynamic tol = null, uint max_refinements = 12)
        {
            if (tol == null) { tol = t(0); }
            return SinhSinh(f, mreal.t(tol), max_refinements);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/SinhSinh/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr, int> SinhSinh(cb1SMpfr1S f, Mpfr tol, uint max_refinements = 12)
        {
            var OSinhSinh1 = new OSinhSinh(f);
            return OSinhSinh1.Integrate();
        }
        internal class OSinhSinh
        {
            private cb1SMpfr1S F1_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OSinhSinh(cb1SMpfr1S F1)
            {
                F1_ = F1;
            }
            public Tuple<Mpfr, Mpfr, Mpfr, int> Integrate()
            {
                Mpfr res1 = new Mpfr(), res2 = new Mpfr(), res3 = new Mpfr();
                var levels = 0;
                Lib_Mpfr_SinhSinh(res1.mpPtr, res2.mpPtr, res3.mpPtr, ref levels, funcptr1, ArbPrec.GetDps());
                return new Tuple<Mpfr, Mpfr, Mpfr, int>(res1, res2, res3, levels);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_SinhSinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_SinhSinh(IntPtr res1, IntPtr res2, IntPtr res3, ref int levels, cb2Ptr f, uint get_digits);






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ExpSinh/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr, int> ExpSinh(cb1SMpfr1S f, dynamic tol = null, uint max_refinements = 12)
        {
            if (tol == null) { tol = t(0); }
            return ExpSinh(f, mreal.t(tol), max_refinements);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/ExpSinh/*' />
        public static Tuple<Mpfr, Mpfr, Mpfr, int> ExpSinh(cb1SMpfr1S f, Mpfr tol, uint max_refinements = 12)
        {
            var OExpSinh1 = new OExpSinh(f);
            return OExpSinh1.Integrate();
        }
        internal class OExpSinh
        {
            private cb1SMpfr1S F1_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OExpSinh(cb1SMpfr1S F1)
            {
                F1_ = F1;
            }
            public Tuple<Mpfr, Mpfr, Mpfr, int> Integrate()
            {
                Mpfr res1 = new Mpfr(), res2 = new Mpfr(), res3 = new Mpfr();
                var levels = 0;
                Lib_Mpfr_ExpSinh(res1.mpPtr, res2.mpPtr, res3.mpPtr, ref levels, funcptr1, ArbPrec.GetDps());
                return new Tuple<Mpfr, Mpfr, Mpfr, int>(res1, res2, res3, levels);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ExpSinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_ExpSinh(IntPtr res1, IntPtr res2, IntPtr res3, ref int levels, cb2Ptr f, uint get_digits);






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/OouraCos/*' />
        public static Tuple<Mpfr, Mpfr> Ooura_Cos(cb1SMpfr1S f)
        {
            var OOoura_Cos1 = new OOoura_Cos(f);
            return OOoura_Cos1.Integrate();
        }
        internal class OOoura_Cos
        {
            private cb1SMpfr1S F1_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OOoura_Cos(cb1SMpfr1S F1)
            {
                F1_ = F1;
            }
            public Tuple<Mpfr, Mpfr> Integrate()
            {
                Mpfr result1 = new Mpfr(), result2 = new Mpfr();
                Lib_Mpfr_Ooura_Cos(result1.mpPtr, result2.mpPtr, funcptr1, ArbPrec.GetDps());
                return new Tuple<Mpfr, Mpfr>(result1, result2);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ooura_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ooura_Cos(IntPtr res1, IntPtr res2, cb2Ptr f, uint get_digits);





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/OouraSin/*' />
        public static Tuple<Mpfr, Mpfr> Ooura_Sin(cb1SMpfr1S f)
        {
            var OOoura_Sin1 = new OOoura_Sin(f);
            return OOoura_Sin1.Integrate();
        }
        internal class OOoura_Sin
        {
            private cb1SMpfr1S F1_;
            private Mpfr X1 = new Mpfr();
            private Mpfr Y1 = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                Lib_Mpfr_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Mpfr_Set(fxPtr, Y1.mpPtr);
            }
            public OOoura_Sin(cb1SMpfr1S F1)
            {
                F1_ = F1;
            }
            public Tuple<Mpfr, Mpfr> Integrate()
            {
                Mpfr result1 = new Mpfr(), result2 = new Mpfr();
                Lib_Mpfr_Ooura_Sin(result1.mpPtr, result2.mpPtr, funcptr1, ArbPrec.GetDps());
                return new Tuple<Mpfr, Mpfr>(result1, result2);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Ooura_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Ooura_Sin(IntPtr res1, IntPtr res2, cb2Ptr f, uint get_digits);









        #endregion








        #region Boost Odeint




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/RungeKutta4Const/*' />
        public static void RungeKutta4Const(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            var OOdeint1 = new OOdeintConst(1, F1, F2, matInput, StartTime, EndTime, dt);
            OOdeint1.Integrate();
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/RungeKutta4Const/*' />
        public static void RungeKutta4Const(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt)
        {
            RungeKutta4Const(F1, F2, matInput, t(StartTime), t(EndTime), t(dt));
        }


        public static void CashKarp54Const(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            var OOdeint1 = new OOdeintConst(2, F1, F2, matInput, StartTime, EndTime, dt);
            OOdeint1.Integrate();
        }


        public static void CashKarp54Const(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt)
        {
            CashKarp54Const(F1, F2, matInput, t(StartTime), t(EndTime), t(dt));
        }




        public static void DormandPrince5Const(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            var OOdeint1 = new OOdeintConst(3, F1, F2, matInput, StartTime, EndTime, dt);
            OOdeint1.Integrate();
        }


        public static void DormandPrince5Const(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt)
        {
            DormandPrince5Const(F1, F2, matInput, t(StartTime), t(EndTime), t(dt));
        }


        public static void Fehlberg78Const(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            var OOdeint1 = new OOdeintConst(4, F1, F2, matInput, StartTime, EndTime, dt);
            OOdeint1.Integrate();
        }


        public static void Fehlberg78Const(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt)
        {
            Fehlberg78Const(F1, F2, matInput, t(StartTime), t(EndTime), t(dt));
        }


        public static void AdamsBashforthMoultonConst(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            var OOdeint1 = new OOdeintConst(5, F1, F2, matInput, StartTime, EndTime, dt);
            OOdeint1.Integrate();
        }


        public static void AdamsBashforthMoultonConst(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt)
        {
            AdamsBashforthMoultonConst(F1, F2, matInput, t(StartTime), t(EndTime), t(dt));
        }


        internal class OOdeintConst
        {
            private int what_;
            private cbMpfr1S2M F1_;
            private cbMpfr1S1M F2_;
            private MpfrVec matInit_ = new MpfrVec();
            private MpfrVec matX = new MpfrVec();
            private MpfrVec matY = new MpfrVec();
            private Mpfr t = new Mpfr();
            private Mpfr StartTime_ = new Mpfr();
            private Mpfr EndTime_ = new Mpfr();
            private Mpfr dt_ = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr, IntPtr tPtr)
            {
                IntPtr tempxPtr = matX.mpPtr;
                matX.mpPtr = xPtr;
                IntPtr tempyPtr = matY.mpPtr;
                matY.mpPtr = fxPtr;
                IntPtr temptPtr = t.mpPtr;
                t.mpPtr = tPtr;
                F1_(t, matX, matY);
                matX.mpPtr = tempxPtr;
                matY.mpPtr = tempyPtr;
                t.mpPtr = temptPtr;
            }
            public void funcptr2(IntPtr xPtr, IntPtr tPtr)
            {
                IntPtr tempxPtr = matX.mpPtr;
                matX.mpPtr = xPtr;
                IntPtr temptPtr = t.mpPtr;
                t.mpPtr = tPtr;
                F2_(t, matX);
                matX.mpPtr = tempxPtr;
                t.mpPtr = temptPtr;
            }
            internal OOdeintConst(int what, cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInit, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
            {
                what_ = what;
                StartTime_ = StartTime;
                EndTime_ = EndTime;
                dt_ = dt;
                matInit_ = matInit; // Shallow copy
                F1_ = F1;
                F2_ = F2;
            }
            internal void Integrate()
            {
                switch (what_)
                {
                    case 1:
                        Mpfr_Const_RungeKutta4(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_);
                        break;
                    case 2:
                        Mpfr_Const_CashKarp54(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_);
                        break;
                    case 3:
                        Mpfr_Const_Dopri5(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_);
                        break;
                    case 4:
                        Mpfr_Const_Fehlberg78(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_);
                        break;
                    case 5:
                        Mpfr_Const_AdamsBashforthMoulton(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_);
                        break;
                    default:
                        Console.WriteLine("Not found");
                        break;
                }
            }
        }

        public static void Mpfr_Const_RungeKutta4(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            Lib_Mpfr_Const_RungeKutta4(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Const_RungeKutta4", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Const_RungeKutta4(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, uint digits);


        public static void Mpfr_Const_CashKarp54(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            Lib_Mpfr_Const_CashKarp54(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Const_CashKarp54", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Const_CashKarp54(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, uint digits);


        public static void Mpfr_Const_Dopri5(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            Lib_Mpfr_Const_Dopri5(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Const_Dopri5", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Const_Dopri5(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, uint digits);


        public static void Mpfr_Const_Fehlberg78(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            Lib_Mpfr_Const_Fehlberg78(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Const_Fehlberg78", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Const_Fehlberg78(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, uint digits);


        public static void Mpfr_Const_AdamsBashforthMoulton(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt)
        {
            Lib_Mpfr_Const_AdamsBashforthMoulton(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Const_AdamsBashforthMoulton", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Const_AdamsBashforthMoulton(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, uint digits);









        // ***********************************************************************************************************









        /// <include file="docs.xml" path='docs/members[@name="Boost"]/DormandPrince5Adaptive/*' />
        public static void DormandPrince5Adaptive(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            var OOdeint1 = new OOdeintAdaptiveDenseOutput(1, F1, F2, matInput, StartTime, EndTime, dt, epsabs, epsrel);
            OOdeint1.Integrate();
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/DormandPrince5Adaptive/*' />
        public static void DormandPrince5Adaptive(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt, dynamic epsabs, dynamic epsrel)
        {
            DormandPrince5Adaptive(F1, F2, matInput, t(StartTime), t(EndTime), t(dt), t(epsabs), t(epsrel));
        }


        public static void CashKarp54Adaptive(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            var OOdeint1 = new OOdeintAdaptiveDenseOutput(2, F1, F2, matInput, StartTime, EndTime, dt, epsabs, epsrel);
            OOdeint1.Integrate();
        }


        public static void CashKarp54Adaptive(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt, dynamic epsabs, dynamic epsrel)
        {
            CashKarp54Adaptive(F1, F2, matInput, t(StartTime), t(EndTime), t(dt), t(epsabs), t(epsrel));
        }



        public static void Fehlberg78Adaptive(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            var OOdeint1 = new OOdeintAdaptiveDenseOutput(3, F1, F2, matInput, StartTime, EndTime, dt, epsabs, epsrel);
            OOdeint1.Integrate();
        }


        public static void Fehlberg78Adaptive(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt, dynamic epsabs, dynamic epsrel)
        {
            Fehlberg78Adaptive(F1, F2, matInput, t(StartTime), t(EndTime), t(dt), t(epsabs), t(epsrel));
        }


        public static void BulirschStoerAdaptive(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            var OOdeint1 = new OOdeintAdaptiveDenseOutput(4, F1, F2, matInput, StartTime, EndTime, dt, epsabs, epsrel);
            OOdeint1.Integrate();
        }


        public static void BulirschStoerAdaptive(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt, dynamic epsabs, dynamic epsrel)
        {
            BulirschStoerAdaptive(F1, F2, matInput, t(StartTime), t(EndTime), t(dt), t(epsabs), t(epsrel));
        }


        public static void DormandPrince5DenseOutput(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            var OOdeint1 = new OOdeintAdaptiveDenseOutput(5, F1, F2, matInput, StartTime, EndTime, dt, epsabs, epsrel);
            OOdeint1.Integrate();
        }


        public static void DormandPrince5DenseOutput(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt, dynamic epsabs, dynamic epsrel)
        {
            DormandPrince5DenseOutput(F1, F2, matInput, t(StartTime), t(EndTime), t(dt), t(epsabs), t(epsrel));
        }


        public static void BulirschStoerDenseOutput(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            var OOdeint1 = new OOdeintAdaptiveDenseOutput(6, F1, F2, matInput, StartTime, EndTime, dt, epsabs, epsrel);
            OOdeint1.Integrate();
        }


        public static void BulirschStoerDenseOutput(cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInput, dynamic StartTime, dynamic EndTime, dynamic dt, dynamic epsabs, dynamic epsrel)
        {
            BulirschStoerDenseOutput(F1, F2, matInput, t(StartTime), t(EndTime), t(dt), t(epsabs), t(epsrel));
        }


        internal class OOdeintAdaptiveDenseOutput
        {
            int what_;
            private cbMpfr1S2M F1_;
            private cbMpfr1S1M F2_;
            private MpfrVec matInit_ = new MpfrVec();
            private MpfrVec matX = new MpfrVec();
            private MpfrVec matY = new MpfrVec();
            private Mpfr t = new Mpfr();
            private Mpfr StartTime_ = new Mpfr();
            private Mpfr EndTime_ = new Mpfr();
            private Mpfr dt_ = new Mpfr();
            private Mpfr epsabs_ = new Mpfr();
            private Mpfr epsrel_ = new Mpfr();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr, IntPtr tPtr)
            {
                IntPtr tempxPtr = matX.mpPtr;
                matX.mpPtr = xPtr;
                IntPtr tempyPtr = matY.mpPtr;
                matY.mpPtr = fxPtr;
                IntPtr temptPtr = t.mpPtr;
                t.mpPtr = tPtr;
                F1_(t, matX, matY);
                matX.mpPtr = tempxPtr;
                matY.mpPtr = tempyPtr;
                t.mpPtr = temptPtr;
            }
            public void funcptr2(IntPtr xPtr, IntPtr tPtr)
            {
                IntPtr tempxPtr = matX.mpPtr;
                matX.mpPtr = xPtr;
                IntPtr temptPtr = t.mpPtr;
                t.mpPtr = tPtr;
                F2_(t, matX);
                matX.mpPtr = tempxPtr;
                t.mpPtr = temptPtr;
            }
            internal OOdeintAdaptiveDenseOutput(int what, cbMpfr1S2M F1, cbMpfr1S1M F2, MpfrVec matInit, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
            {
                what_ = what;
                StartTime_ = StartTime;
                EndTime_ = EndTime;
                dt_ = dt;
                matInit_ = matInit; // Shallow copy
                F1_ = F1;
                F2_ = F2;
                epsabs_ = epsabs;
                epsrel_ = epsrel;
            }
            internal void Integrate()
            {
                switch (what_)
                {
                    case 1:
                        Mpfr_Adaptive_RungeKuttaDopri5(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_, epsabs_, epsrel_);
                        break;
                    case 2:
                        Mpfr_Adaptive_CashKarp54(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_, epsabs_, epsrel_);
                        break;
                    case 3:
                        Mpfr_Adaptive_Fehlberg78(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_, epsabs_, epsrel_);
                        break;
                    case 4:
                        Mpfr_Adaptive_BulirschStoer(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_, epsabs_, epsrel_);
                        break;
                    case 5:
                        Mpfr_DenseOutput_Dopri5(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_, epsabs_, epsrel_);
                        break;
                    case 6:
                        Mpfr_DenseOutput_BulirschStoer(funcptr1, funcptr2, matInit_, StartTime_, EndTime_, dt_, epsabs_, epsrel_);
                        break;
                    default:
                        Console.WriteLine("Not found");
                        break;
                }
            }
        }
        public static void Mpfr_Adaptive_RungeKuttaDopri5(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            Lib_Mpfr_Adaptive_Dopri5(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, epsabs.mpPtr, epsrel.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Adaptive_Dopri5", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Adaptive_Dopri5(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, IntPtr epsabs, IntPtr epsrel, uint digits);


        public static void Mpfr_Adaptive_CashKarp54(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            Lib_Mpfr_Adaptive_CashKarp54(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, epsabs.mpPtr, epsrel.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Adaptive_CashKarp54", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Adaptive_CashKarp54(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, IntPtr epsabs, IntPtr epsrel, uint digits);


        public static void Mpfr_Adaptive_Fehlberg78(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            Lib_Mpfr_Adaptive_Fehlberg78(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, epsabs.mpPtr, epsrel.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Adaptive_Fehlberg78", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Adaptive_Fehlberg78(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, IntPtr epsabs, IntPtr epsrel, uint digits);


        public static void Mpfr_Adaptive_BulirschStoer(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            Lib_Mpfr_Adaptive_BulirschStoer(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, epsabs.mpPtr, epsrel.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Adaptive_BulirschStoer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Adaptive_BulirschStoer(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, IntPtr epsabs, IntPtr epsrel, uint digits);


        public static void Mpfr_DenseOutput_Dopri5(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            Lib_Mpfr_DenseOutput_Dopri5(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, epsabs.mpPtr, epsrel.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_DenseOutput_Dopri5", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_DenseOutput_Dopri5(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, IntPtr epsabs, IntPtr epsrel, uint digits);


        public static void Mpfr_DenseOutput_BulirschStoer(cb3Ptr F1, cb2Ptr F2, MpfrVec matX, Mpfr StartTime, Mpfr EndTime, Mpfr dt, Mpfr epsabs, Mpfr epsrel)
        {
            Lib_Mpfr_DenseOutput_BulirschStoer(F1, F2, matX.mpPtr, StartTime.mpPtr, EndTime.mpPtr, dt.mpPtr, epsabs.mpPtr, epsrel.mpPtr, ArbPrec.GetDps());
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_DenseOutput_BulirschStoer", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_DenseOutput_BulirschStoer(cb3Ptr F1, cb2Ptr F2, IntPtr MatrixPtr_source, IntPtr StartTime, IntPtr EndTime, IntPtr dt, IntPtr epsabs, IntPtr epsrel, uint digits);











        #endregion










        #region Eigen calculus


        public static MpfrMat PowellHybrd(cbMpfr2M F1, cbMpfr2M F2, MpfrMat matInput)
        {
            var MPowellHybrd1 = new MPowellHybrd(F1, F2, matInput);
            var matX = MPowellHybrd1.Solve();
            return matX;
        }
        internal class MPowellHybrd
        {
            private cbMpfr2M F1_;
            private cbMpfr2M F2_;
            private MpfrMat matX1 = new MpfrMat();
            private MpfrMat matY1 = new MpfrMat();
            private MpfrMat matX2 = new MpfrMat();
            private MpfrMat matY2 = new MpfrMat();
            private MpfrMat matInput_ = new MpfrMat();
            private MpfrMat matX = new MpfrMat();
            private MpfrMat matFvec = new MpfrMat();
            private MpfrMat matFjac = new MpfrMat();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX1.mpPtr;
                matX1.mpPtr = xPtr;
                IntPtr tempyPtr = matY1.mpPtr;
                matY1.mpPtr = fxPtr;
                F1_(matX1, matY1);
                matX1.mpPtr = tempxPtr;
                matY1.mpPtr = tempyPtr;
            }
            public void funcptr2(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX2.mpPtr;
                matX2.mpPtr = xPtr;
                IntPtr tempyPtr = matY2.mpPtr;
                matY2.mpPtr = fxPtr;
                F2_(matX2, matY2);
                matX2.mpPtr = tempxPtr;
                matY2.mpPtr = tempyPtr;
            }
            internal MPowellHybrd(cbMpfr2M F1, cbMpfr2M F2, MpfrMat matInput)
            {
                int n = matInput.rows;
                matX.Resize(n, 1);
                matFvec.Resize(n, 1);
                matFjac.Resize(n, n);
                matInput_ = matInput; // Shallow copy
                F1_ = F1;
                F2_ = F2;
            }
            internal MpfrMat Solve()
            {
                Interop.testHybrj_ext(funcptr1, funcptr2, matX, matFvec, matFjac, matInput_);
                return matX;
            }
        }




        public static MpfrMat Levenberg(cbMpfr2M F1, cbMpfr2M F2, MpfrMat matInput, int n, int m)
        {
            var MLevenberg1 = new MLevenberg(F1, F2, matInput, n, m);
            var matX = MLevenberg1.Solve();
            return matX;
        }
        internal class MLevenberg
        {
            private cbMpfr2M F1_;
            private cbMpfr2M F2_;
            private MpfrMat matX1 = new MpfrMat();
            private MpfrMat matY1 = new MpfrMat();
            private MpfrMat matX2 = new MpfrMat();
            private MpfrMat matY2 = new MpfrMat();
            private MpfrMat matInput_ = new MpfrMat();
            private MpfrMat matX = new MpfrMat();
            private MpfrMat matFvec = new MpfrMat();
            private MpfrMat matFjac = new MpfrMat();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX1.mpPtr;
                matX1.mpPtr = xPtr;
                IntPtr tempyPtr = matY1.mpPtr;
                matY1.mpPtr = fxPtr;
                F1_(matX1, matY1);
                matX1.mpPtr = tempxPtr;
                matY1.mpPtr = tempyPtr;
            }
            public void funcptr2(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX2.mpPtr;
                matX2.mpPtr = xPtr;
                IntPtr tempyPtr = matY2.mpPtr;
                matY2.mpPtr = fxPtr;
                F2_(matX2, matY2);
                matX2.mpPtr = tempxPtr;
                matY2.mpPtr = tempyPtr;
            }
            internal MLevenberg(cbMpfr2M F1, cbMpfr2M F2, MpfrMat matInput, int n, int m)
            {
                matX.Resize(n, 1);
                matFvec.Resize(m, 1);
                matFjac.Resize(n, n);
                matInput_ = matInput; // Shallow copy
                F1_ = F1;
                F2_ = F2;
            }
            internal MpfrMat Solve()
            {
                Interop.testLmder_ext(funcptr1, funcptr2, matX, matFvec, matFjac, matInput_);
                return matX;
            }
        }









        #endregion










        #region Boost/CppOptLib


        public static MpfrVec NelderMeadSolver(cb1SMpfr1V F1, MpfrVec matInput)
        {
            var MSolver11 = new MOptSolver1(constants.mp_nelder_mead_solver, F1, matInput);
            return MSolver11.Solve();
        }

        public static MpfrVec CMAesSolver(cb1SMpfr1V F1, MpfrVec matInput)
        {
            var MSolver11 = new MOptSolver1(constants.mp_cma_es_solver, F1, matInput);
            return MSolver11.Solve();
        }

        internal class MOptSolver1
        {
            private int what_;
            private cb1SMpfr1V F1_;
            private MpfrVec matX1 = new MpfrVec();
            private MpfrVec matY1 = new MpfrVec();
            private MpfrVec matX_ = new MpfrVec();
            private MpfrVec matNorm_ = new MpfrVec();
            private MpfrVec X_ = new MpfrVec();
            private MpfrVec FX_ = new MpfrVec();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX1.mpPtr;
                matX1.mpPtr = xPtr;
                IntPtr tempyPtr = matY1.mpPtr;
                matY1.mpPtr = fxPtr;
                matY1[0] = F1_(matX1);
                matX1.mpPtr = tempxPtr;
                matY1.mpPtr = tempyPtr;
            }
            internal MOptSolver1(int what, cb1SMpfr1V F1, MpfrVec X)
            {
                what_ = what;
                matX_ = new MpfrVec(X.Size);
                X_ = X; // Shallow copy
                F1_ = F1;
            }
            internal MpfrVec Solve()
            {
                Lib_Mpfr_CppOptLib1(what_, funcptr1, matX_.mpPtr, matNorm_.mpPtr, X_.mpPtr, FX_.mpPtr);
                return matX_;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_CppOptLib1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_CppOptLib1(int what, cbProc2Ptr F1, IntPtr matXPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr);



        public static MpfrVec LbfgsSolver(cb1SMpfr1V F1, cbMpfr2V F2, MpfrVec matInput)
        {
            var MSolver21 = new MOptSolver2(constants.mp_lbfgs_solver, F1, F2, matInput);
            return MSolver21.Solve();
        }

        public static MpfrVec BfgsSolver(cb1SMpfr1V F1, cbMpfr2V F2, MpfrVec matInput)
        {
            var MSolver21 = new MOptSolver2(constants.mp_bfgs_solver, F1, F2, matInput);
            return MSolver21.Solve();
        }

        public static MpfrVec GradientDescentSolver(cb1SMpfr1V F1, cbMpfr2V F2, MpfrVec matInput)
        {
            var MSolver21 = new MOptSolver2(constants.mp_gradient_descent_solver, F1, F2, matInput);
            return MSolver21.Solve();
        }

        public static MpfrVec ConjugatedGradientDescentSolver(cb1SMpfr1V F1, cbMpfr2V F2, MpfrVec matInput)
        {
            var MSolver21 = new MOptSolver2(constants.mp_conjugated_gradient_descent_solver, F1, F2, matInput);
            return MSolver21.Solve();
        }

        internal class MOptSolver2
        {
            private int what_;
            private cb1SMpfr1V F1_;
            private cbMpfr2V F2_;
            private MpfrVec matX1 = new MpfrVec();
            private MpfrVec matY1 = new MpfrVec();
            private MpfrVec matX2 = new MpfrVec();
            private MpfrVec matY2 = new MpfrVec();
            private MpfrVec matX_ = new MpfrVec();
            private MpfrVec matGrad_ = new MpfrVec();
            private MpfrVec matNorm_ = new MpfrVec();
            private MpfrVec X_ = new MpfrVec();
            private MpfrVec FX_ = new MpfrVec();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX1.mpPtr;
                matX1.mpPtr = xPtr;
                IntPtr tempyPtr = matY1.mpPtr;
                matY1.mpPtr = fxPtr;
                matY1[0] = F1_(matX1);
                matX1.mpPtr = tempxPtr;
                matY1.mpPtr = tempyPtr;
            }
            public void funcptr2(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX2.mpPtr;
                matX2.mpPtr = xPtr;
                IntPtr tempyPtr = matY2.mpPtr;
                matY2.mpPtr = fxPtr;
                F2_(matX2, matY2);
                matX2.mpPtr = tempxPtr;
                matY2.mpPtr = tempyPtr;
            }
            internal MOptSolver2(int what, cb1SMpfr1V F1, cbMpfr2V F2, MpfrVec X)
            {
                what_ = what;
                matX_ = new MpfrVec(X.Size);
                matGrad_ = new MpfrVec(X.Size);
                X_ = X; // Shallow copy
                F1_ = F1;
                F2_ = F2;
            }
            internal MpfrVec Solve()
            {
                Lib_Mpfr_CppOptLib2(what_, funcptr1, funcptr2, matX_.mpPtr, matGrad_.mpPtr, matNorm_.mpPtr, X_.mpPtr, FX_.mpPtr);
                return matX_;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_CppOptLib2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_CppOptLib2(int what, cbProc2Ptr F1, cbProc2Ptr F2, IntPtr matXPtr, IntPtr matGradPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr);



        public static MpfrVec NewtonDescentSolver(cb1SMpfr1V F1, cbMpfr2V F2, cbMpfr1V1M F3, MpfrVec matInput)
        {
            var MSolver31 = new MOptSolver3(constants.mp_newton_descent_solver, F1, F2, F3, matInput);
            return MSolver31.Solve();
        }

        internal class MOptSolver3
        {
            private int what_;
            private cb1SMpfr1V F1_;
            private cbMpfr2V F2_;
            private cbMpfr1V1M F3_;
            private MpfrVec matX1 = new MpfrVec();
            private MpfrVec matY1 = new MpfrVec();
            private MpfrVec matX2 = new MpfrVec();
            private MpfrVec matY2 = new MpfrVec();
            private MpfrVec matX3 = new MpfrVec();
            private MpfrMat matY3 = new MpfrMat();
            private MpfrVec matX_ = new MpfrVec();
            private MpfrVec matGrad_ = new MpfrVec();
            private MpfrVec matNorm_ = new MpfrVec();
            private MpfrMat matHessian_ = new MpfrMat();
            private MpfrVec X_ = new MpfrVec();
            private MpfrVec FX_ = new MpfrVec();
            public void funcptr1(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX1.mpPtr;
                matX1.mpPtr = xPtr;
                IntPtr tempyPtr = matY1.mpPtr;
                matY1.mpPtr = fxPtr;
                matY1[0] = F1_(matX1);
                matX1.mpPtr = tempxPtr;
                matY1.mpPtr = tempyPtr;
            }
            public void funcptr2(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX2.mpPtr;
                matX2.mpPtr = xPtr;
                IntPtr tempyPtr = matY2.mpPtr;
                matY2.mpPtr = fxPtr;
                F2_(matX2, matY2);
                matX2.mpPtr = tempxPtr;
                matY2.mpPtr = tempyPtr;
            }
            public void funcptr3(IntPtr xPtr, IntPtr fxPtr)
            {
                IntPtr tempxPtr = matX3.mpPtr;
                matX3.mpPtr = xPtr;
                IntPtr tempyPtr = matY3.mpPtr;
                matY3.mpPtr = fxPtr;
                F3_(matX3, matY3);
                matX3.mpPtr = tempxPtr;
                matY3.mpPtr = tempyPtr;
            }
            internal MOptSolver3(int what, cb1SMpfr1V F1, cbMpfr2V F2, cbMpfr1V1M F3, MpfrVec X)
            {
                what_ = what;
                matX_ = new MpfrVec(X.Size);
                matGrad_ = new MpfrVec(X.Size);
                matHessian_.Resize(X.Size, X.Size);
                X_ = X; // Shallow copy
                F1_ = F1;
                F2_ = F2;
                F3_ = F3;
            }
            internal MpfrVec Solve()
            {
                Lib_Mpfr_CppOptLib3(what_, funcptr1, funcptr2, funcptr3, matX_.mpPtr, matHessian_.mpPtr, matGrad_.mpPtr, matNorm_.mpPtr, X_.mpPtr, FX_.mpPtr);
                return matX_;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_CppOptLib3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_CppOptLib3(int what, cbProc2Ptr F1, cbProc2Ptr F2, cbProc2Ptr F3, IntPtr matXPtr, IntPtr matHessianPtr, IntPtr matGradPtr, IntPtr matNormPtr, IntPtr xPtr, IntPtr fxPtr);



        #endregion










        #region Matrix Creation



        /// <summary>
        /// Converts from a real scalar of type CppDecimal
        /// </summary>
        public static MpfrMat mat_t(Mpfr x)
        {
            var matA = new MpfrMat();
            matA[0, 0] = x;
            return matA;
        }


        /* *********************** */

        public static MpfrMatC mat_cplx_t(MpfrMat matA)
        {
            return mcplx.mat_t(matA);
        }


        public static MpfrMatC mat_cplx_zeros(int n, int m)
        {
            return mcplx.mat_zeros(n, m);
        }

        /* *********************** */




        /// <summary>
        /// Returns SetZero
        /// </summary>
        public static MpfrMat mat_zeros(int n, int m)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_setZero, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetOnes
        /// </summary>
        public static MpfrMat mat_ones(int n, int m)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_setOnes, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static MpfrMat mat_identity(int n, int m)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static MpfrMat mat_eye(int n, int m)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns Random
        /// </summary>
        public static MpfrMat mat_random(int n, int m)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_setRandom_nm, n, m);
            return resout;
        }


        /// <summary>
        /// Returns RandomSym
        /// </summary>
        public static MpfrMat mat_random_symmetric(int n)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_setRandomSymmetric, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSa
        /// </summary>
        public static MpfrMat mat_random_selfadjoint(int n)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_setRandomSA, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSaPosdef
        /// </summary>
        public static MpfrMat mat_random_selfadjoint_posdef(int n)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_setRandomSAPosDef, n, n);
            return resout;
        }


        /// <summary>
        /// Returns FillLinear
        /// </summary>
        public static MpfrMat mat_fill_linear(int n, int m)
        {
            var resout = new MpfrMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_mprf, resout, constants.mp_FillLinear, n, m);
            return resout;
        }




        #endregion










    }







}
