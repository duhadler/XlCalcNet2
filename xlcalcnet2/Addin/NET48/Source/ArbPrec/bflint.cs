using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using FixedPrecNet;

namespace ArbPrecNet
{
    public class BigDecimal
    {



        #region Init

        internal IntPtr mpPtr = IntPtr.Zero;


        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Lib_Mpd_Init_Func();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_Mpd_Init_Func();


        ~BigDecimal()
        {
            Lib_Mpd_Clear(mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Clear(IntPtr x);

        #endregion



        #region Conversions


        public BigDecimal()
        {
            Init();
        }


        internal string Get_Num_Str()
        {
            long StrSize2 = Lib_Mpd_SizeInBase10(mpPtr);
            int StrSize = (int)StrSize2;
            var sb = new StringBuilder(StrSize + 20);
            Lib_Mpd_Get_Str(sb, mpPtr);
            return sb.ToString();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_SizeInBase10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern UInt32 Lib_Mpd_SizeInBase10(IntPtr x);
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Get_Str", CallingConvention = CallingConvention.Cdecl)]
        internal static extern long Lib_Mpd_Get_Str(StringBuilder sb, IntPtr x);


        public override string ToString()
        {
            return Get_Num_Str();
        }


        public string __str__()
        {
            return ToString();
        }


        public string __repr__()
        {
            return "BigDecimal('" + ToString() + "')";
        }



        #endregion



        #region Arithmetic operators







        public static bool operator >=(BigDecimal x, dynamic y)
        {
            return x >= bflint.t(y);
        }
        public static bool operator <=(BigDecimal x, dynamic y)
        {
            return x <= bflint.t(y);
        }

        public static bool operator >(BigDecimal x, dynamic y)
        {
            return x > bflint.t(y);
        }
        public static bool operator <(BigDecimal x, dynamic y)
        {
            return x < bflint.t(y);
        }

        public static bool operator ==(BigDecimal x, dynamic y)
        {
            return x == bflint.t(y);
        }
        public static bool operator !=(BigDecimal x, dynamic y)
        {
            return x != bflint.t(y);
        }

        public static bool operator ==(dynamic x, BigDecimal y)
        {
            return bflint.t(x) == y;
        }
        public static bool operator !=(dynamic x, BigDecimal y)
        {
            return bflint.t(x) !=  y;
        }





        public static bool operator ==(BigDecimal x, BigDecimal y)
        {
            return Lib_Mpd_EQ(x.mpPtr, y.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_EQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_EQ(IntPtr x, IntPtr y);


        public static bool operator !=(BigDecimal x, BigDecimal y)
        {
            return Lib_Mpd_NE(x.mpPtr, y.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_NE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_NE(IntPtr x, IntPtr y);


        public static bool operator <=(BigDecimal x, BigDecimal y)
        {
            return Lib_Mpd_LE(x.mpPtr, y.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_LE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_LE(IntPtr x, IntPtr y);


        public static bool operator >(BigDecimal x, BigDecimal y)
        {
            return Lib_Mpd_GT(x.mpPtr, y.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_GT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_GT(IntPtr x, IntPtr y);


        public static bool operator >=(BigDecimal x, BigDecimal y)
        {
            return Lib_Mpd_GE(x.mpPtr, y.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_GE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_GE(IntPtr x, IntPtr y);


        public static bool operator <(BigDecimal x, BigDecimal y)
        {
            return Lib_Mpd_LT(x.mpPtr, y.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_LT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_LT(IntPtr x, IntPtr y);














        public static BigDecimal operator +(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set(IntPtr mpfr_out1, IntPtr mpfr_in1);


        public static BigDecimal operator -(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Neg(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Neg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Neg(IntPtr res, IntPtr x);









        public static BigDecimal operator +(BigDecimal x, dynamic i)
        {
            return x + bflint.t(i);
        }

        public static BigDecimal operator +(dynamic i, BigDecimal x)
        {
            return bflint.t(i) + x;
        }


        public static BigDecimalC operator +(BigDecimal x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Add_Mpd(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Add_Mpd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Add_Mpd(IntPtr res, IntPtr y, IntPtr x);


        public static BigDecimal operator +(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Add(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Add(IntPtr res, IntPtr x, IntPtr y);






        public static BigDecimal operator -(BigDecimal x, dynamic y)
        {
            return x - bflint.t(y);
        }

        public static BigDecimal operator -(dynamic x, BigDecimal y)
        {
            return bflint.t(x) - y;
        }


        public static BigDecimalC operator -(BigDecimal x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Mpd_Sub(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Mpd_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Mpd_Sub(IntPtr res, IntPtr y, IntPtr x);


        public static BigDecimal operator -(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Sub(IntPtr res, IntPtr x, IntPtr y);







        public static BigDecimal operator *(BigDecimal x, dynamic y)
        {
            return x * bflint.t(y);
        }

        public static BigDecimal operator *(dynamic x, BigDecimal y)
        {
            return bflint.t(x) * y;
        }


        public static BigDecimalC operator *(BigDecimal x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Mul_Mpd(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Mul_Mpd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Mul_Mpd(IntPtr res, IntPtr x, IntPtr y);


        public static BigDecimal operator *(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Mul(IntPtr res, IntPtr x, IntPtr y);









        public static BigDecimal operator /(BigDecimal x, dynamic y)
        {
            return x / bflint.t(y);
        }

        public static BigDecimal operator /(dynamic x, BigDecimal y)
        {
            return bflint.t(x) / y;
        }


        public static BigDecimalC operator /(BigDecimal x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Mpd_Div(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Mpd_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Mpd_Div(IntPtr res, IntPtr x, IntPtr y);


        public static BigDecimal operator /(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Div(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Div(IntPtr res, IntPtr x, IntPtr y);



        #endregion






    }









    public class bflint
    {

        /// <summary>
        /// Sets the precision for Mpd (i.e. breal)
        /// </summary>
        public static int SetPrec(uint prec)
        {
            return Lib_Mpd_SetPrec(prec);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_SetPrec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_SetPrec(uint prec);





        #region Flint Basic Functions




        #region Conversions


        /// <summary>
        /// Returns a new BigDecimal using an dynamic (an object whose operations will be resolved at runtime) as input
        /// </summary>
        public static BigDecimal t(dynamic x)
        {
            //MessageBox.Show("In BigDecimal t(dynamic i)");
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




        public static BigDecimal t(Arb x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_Arb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Arb(IntPtr mpfr_out1, IntPtr mpfr_in1);





        /// <summary>
        /// Returns a new BigDecimal using an arbitrary precision binary interval point number as input
        /// </summary>
        public static BigDecimal t(Interval x)
        {
            string tstr = "%." + (ArbPrec.GetDps() - 1).ToString() + "RE";
            var res = new BigDecimal();
            Lib_Mpd_Set_Mpfi(res.mpPtr, tstr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Mpfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Mpfi(IntPtr mpfr_out1, string template, IntPtr mpfr_in1);


        /// <summary>
        /// Returns a new BigDecimal using an arbitrary precision binary floating point number as input
        /// </summary>
        public static BigDecimal t(Mpfr x)
        {
            string tstr = "%." + (ArbPrec.GetDps() - 1).ToString() + "RE";
            var res = new BigDecimal();
            Lib_Mpd_Set_Mpfr(res.mpPtr, tstr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Mpfr(IntPtr mpfr_out1, string template, IntPtr mpfr_in1);


        /// <summary>
        /// Returns a new BigDecimal using an arbitrary precision decimal floating point number as input
        /// </summary>
        public static BigDecimal t(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_Mpd(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Mpd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Mpd(IntPtr mpfr_out1, IntPtr mpfr_in1);




        /// <summary>
        /// Returns a new BigDecimal using an octuple precision floating point number as input
        /// </summary>
        public static BigDecimal t(Octuple x)
        {
            return t(x.ToString());
        }



        /// <summary>
        /// Returns a new BigDecimal using a quadruple precision binary floating point number as input
        /// </summary>
        public static BigDecimal t(Quadruple x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_QReal(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_QReal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_QReal(IntPtr ld_out1, IntPtr mpfr_in1);



        /// <summary>
        /// Returns a new BigDecimal using an extended precision floating point number as input
        /// </summary>
        public static BigDecimal t(Extended x)
        {
            return t(x.ToString());
        }



        /// <summary>
        /// Returns a new BigDecimal using a double precision floating point number as input
        /// </summary>
        public static BigDecimal t(Double d)
        {
            var res = new BigDecimal();
            if (ArbPrec.UseRawDouble)
            {
                Lib_Mpd_Set_D(res.mpPtr, d);
            }
            else
            {
                string s = d.ToString("G14", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                Lib_Mpd_Set_Str(res.mpPtr, s);
            }
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_D", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_D(IntPtr mpfr_out1, Double d);


        /// <summary>
        /// Returns a new BigDecimal using a single precision binary floating point number as input
        /// </summary>
        public static BigDecimal t(Single x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_S(res.mpPtr, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_S", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_S(IntPtr res, ref Single x);



        /// <summary>
        /// Returns a new BigDecimal using a signed 32 bit integer as input
        /// </summary>
        public static BigDecimal t(Int32 si)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_Si(res.mpPtr, si);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Si(IntPtr res, Int32 si);



        /// <summary>
        /// Returns a new BigDecimal using an unsigned 32 bit integer as input
        /// </summary>
        public static BigDecimal t(UInt32 ui)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_Ui(res.mpPtr, ui);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Ui(IntPtr res, UInt32 ui);



        /// <summary>
        /// Returns a new BigDecimal using a signed 64 bit integer as input
        /// </summary>
        public static BigDecimal t(Int64 si64)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_Si64(res.mpPtr, si64);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Si64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Si64(IntPtr res, Int64 si64);


        /// <summary>
        /// Returns a new BigDecimal using an unsigned 64 bit integer as input
        /// </summary>
        public static BigDecimal t(UInt64 ui64)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_Ui64(res.mpPtr, ui64);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Ui64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Ui64(IntPtr res, UInt64 ui64);




        /// <summary>
        /// Returns a new BigDecimal using a System.Decimal as input
        /// </summary>
        public static BigDecimal t(decimal i)
        {
            var res = new BigDecimal();
            string s = i.ToString();
            Lib_Mpd_Set_Str(res.mpPtr, s);
            return res;
        }




        /// <summary>
        /// Returns a new BigDecimal using an arbitrary precision integer as input
        /// </summary>
        public static BigDecimal t(BigInteger i)
        {
            var res = new BigDecimal();
            string s = i.ToString();
            Lib_Mpd_Set_Str(res.mpPtr, s);
            return res;
        }



        /// <summary>
        /// Returns a new BigDecimal using a string as input
        /// </summary>
        public static BigDecimal t(string s)
        {
            var res = new BigDecimal();
            Lib_Mpd_Set_Str(res.mpPtr, s);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Set_Str", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Set_Str(IntPtr res, string s);




        #endregion





        #region General

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "bflint"; }
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
            get { return true; }
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

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Flint/*' />
        public static bflint Flint
        {
            get { return new bflint(); }
        }

        ///// <include file="docs.xml" path='docs/members[@name="Contexts"]/RealCtx/*' />
        //public static breal RealCtx
        //{
        //    get { return new breal(); }
        //}

        ///// <include file="docs.xml" path='docs/members[@name="Contexts"]/CplxCtx/*' />
        //public static bcplx CplxCtx
        //{
        //    get { return new bcplx(); }
        //}


        #endregion




        #region Basic Arithmetic


        public static BigDecimal add(BigDecimal x, BigDecimal y)
        {
            return x + y;
        }
        public static BigDecimal add(dynamic x, dynamic y)
        {
            return t(x) + t(y);
        }

        /// <summary>
        /// Return the sum of x and y
        /// </summary>
        public static void rawadd(BigDecimal res, BigDecimal x, BigDecimal y)
        {
            Lib_Mpd_Add(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Add(IntPtr res, IntPtr x, IntPtr y);



        public static BigDecimal subtract(BigDecimal x, BigDecimal y)
        {
            return x - y;
        }
        public static BigDecimal subtract(dynamic x, dynamic y)
        {
            return t(x) - t(y);
        }

        /// <summary>
        /// Return the difference of x and y
        /// </summary>
        public static void rawsub(BigDecimal res, BigDecimal x, BigDecimal y)
        {
            Lib_Mpd_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Sub(IntPtr res, IntPtr x, IntPtr y);



        public static BigDecimal multiply(BigDecimal x, BigDecimal y)
        {
            return x * y;
        }
        public static BigDecimal multiply(dynamic x, dynamic y)
        {
            return t(x) * t(y);
        }

        /// <summary>
        /// Return the product of x and y
        /// </summary>
        public static void rawmul(BigDecimal res, BigDecimal x, BigDecimal y)
        {
            Lib_Mpd_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Mul(IntPtr res, IntPtr x, IntPtr y);



        public static BigDecimal divide(BigDecimal x, BigDecimal y)
        {
            return x / y;
        }
        public static BigDecimal divide(dynamic x, dynamic y)
        {
            return t(x) / t(y);
        }

        /// <summary>
        /// Return the quotient of x and y
        /// </summary>
        public static void rawdiv(BigDecimal res, BigDecimal x, BigDecimal y)
        {
            Lib_Mpd_Div(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Div(IntPtr res, IntPtr x, IntPtr y);


        #endregion



        #region General functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static BigDecimal fma(BigDecimal x, BigDecimal y, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Fma(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Fma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Fma(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static BigDecimal fma(dynamic x, dynamic y, dynamic z)
        {
            return fma(bflint.t(x), bflint.t(y), bflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static BigDecimal fmax(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Fmax(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Fmax", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Fmax(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static BigDecimal fmax(dynamic x, dynamic y)
        {
            return fmax(bflint.t(x), bflint.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static BigDecimal fmin(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Fmin(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Fmin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Fmin(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static BigDecimal fmin(dynamic x, dynamic y)
        {
            return fmin(bflint.t(x), bflint.t(y));
        }


        #endregion



        #region Machine constants


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static BigDecimal zero()
        {
            var res = new BigDecimal();
            Lib_Mpd_Zero(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Zero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Zero(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/negzero/*' />
        public static BigDecimal negzero()
        {
            var res = new BigDecimal();
            Lib_Mpd_NegZero(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_NegZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_NegZero(IntPtr res);



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static BigDecimal one()
        {
            var res = new BigDecimal();
            Lib_Mpd_One(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_One", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_One(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static BigDecimal inf()
        {
            var res = new BigDecimal();
            Lib_Mpd_Inf(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Inf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Inf(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/neginf/*' />
        public static BigDecimal neginf()
        {
            var res = new BigDecimal();
            Lib_Mpd_NegInf(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_NegInf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_NegInf(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static BigDecimal nan()
        {
            var res = new BigDecimal();
            Lib_Mpd_Nan(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Nan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Nan(IntPtr res);



        #endregion



        #region Properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(BigDecimal x)
        {
            return Lib_Mpd_Signbit(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Signbit", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Signbit(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(dynamic x)
        {
            return signbit(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(BigDecimal x)
        {
            return 0 != Lib_Mpd_Finite(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Finite", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Finite(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isfinite/*' />
        public static bool isfinite(dynamic x)
        {
            return isfinite(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isinf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isinf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isinf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinf/*' />
        public static bool isinf(dynamic x)
        {
            return isinf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static bool isposinf(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isposinf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isposinf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isposinf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isposinf/*' />
        public static bool isposinf(dynamic x)
        {
            return isposinf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isneginf/*' />
        public static bool isneginf(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isneginf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isneginf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isneginf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isneginf/*' />
        public static bool isneginf(dynamic x)
        {
            return isneginf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isnan(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isnan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isnan(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnan/*' />
        public static bool isnan(dynamic x)
        {
            return isnan(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Iszero(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Iszero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Iszero(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/iszero/*' />
        public static bool iszero(dynamic x)
        {
            return iszero(t(x));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsPositiveZero/*' />
        //public static bool IsPositiveZero(BigDecimal x)
        //{
        //    return 0 != (Lib_Mpd_Isposzero(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isposzero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpd_Isposzero(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/IsPositiveZero/*' />
        //public static bool IsPositiveZero(dynamic x)
        //{
        //    return IsPositiveZero(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsNegativeZero/*' />
        //public static bool IsNegativeZero(BigDecimal x)
        //{
        //    return 0 != (Lib_Mpd_Isnegzero(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isnegzero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpd_Isnegzero(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/IsNegativeZero/*' />
        //public static bool IsNegativeZero(dynamic x)
        //{
        //    return IsNegativeZero(t(x));
        //}



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isone(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isone", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isone(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isone/*' />
        public static bool isone(dynamic x)
        {
            return isone(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinteger/*' />
        public static bool isinteger(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isinteger(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isinteger", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isinteger(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinteger/*' />
        public static bool isinteger(dynamic x)
        {
            return isinteger(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnumber/*' />
        public static bool isnumber(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isnumber(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isnumber", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isnumber(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnumber/*' />
        public static bool isnumber(dynamic x)
        {
            return isnumber(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isregular/*' />
        public static bool isregular(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isregular(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isregular", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isregular(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isregular/*' />
        public static bool isregular(dynamic x)
        {
            return isregular(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnormal/*' />
        public static bool isnormal(BigDecimal x)
        {
            return 0 != (Lib_Mpd_Isnormal(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isnormal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isnormal(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnormal/*' />
        public static bool isnormal(dynamic x)
        {
            return isnormal(t(x));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsSubnormal/*' />
        //public static bool IsSubnormal(BigDecimal x)
        //{
        //    return 0 != (Lib_Mpd_Issubnormal(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Issubnormal", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpd_Issubnormal(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/IsSubnormal/*' />
        //public static bool IsSubnormal(dynamic x)
        //{
        //    return IsSubnormal(t(x));
        //}



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isunordered/*' />
        public static bool isunordered(BigDecimal x, BigDecimal y)
        {
            return 0 != (Lib_Mpd_Isunordered(x.mpPtr, y.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Isunordered", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Isunordered(IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isunordered/*' />
        public static bool isunordered(dynamic x, dynamic y)
        {
            return isunordered(t(x), t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint32/*' />
        public static bool fitsint32(BigDecimal x)
        {
            return 0 != (Lib_Mpd_FitsInt32(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_FitsInt32", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_FitsInt32(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint32/*' />
        public static bool fitsint32(dynamic x)
        {
            return fitsint32(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint64/*' />
        public static bool fitsint64(BigDecimal x)
        {
            return 0 != (Lib_Mpd_FitsInt64(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_FitsInt64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_FitsInt64(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint64/*' />
        public static bool fitsint64(dynamic x)
        {
            return fitsint64(t(x));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/FitsUInt32/*' />
        //public static bool FitsUInt32(BigDecimal x)
        //{
        //    return 0 != (Lib_Mpd_FitsUInt32(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_FitsUInt32", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpd_FitsUInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/FitsUInt32/*' />
        //public static bool FitsUInt32(dynamic x)
        //{
        //    return FitsUInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/FitsUInt64/*' />
        //public static bool FitsUInt64(BigDecimal x)
        //{
        //    return 0 != (Lib_Mpd_FitsUInt64(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_FitsUInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpd_FitsUInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/FitsUInt64/*' />
        //public static bool FitsUInt64(dynamic x)
        //{
        //    return FitsUInt64(t(x));
        //}




        #endregion



        #region Integer Related Functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static BigDecimal nearbyint(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Nearbyint(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Nearbyint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Nearbyint(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static BigDecimal nearbyint(dynamic x)
        {
            return nearbyint(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static BigDecimal rint(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Rint(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Rint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Rint(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static BigDecimal rint(dynamic x)
        {
            return rint(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(BigDecimal x)
        {
            return Lib_Mpd_Lrint(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Lrint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_Lrint(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(dynamic x)
        {
            return lrint(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(BigDecimal x)
        {
            return Lib_Mpd_Llrint(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Llrint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int64 Lib_Mpd_Llrint(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(dynamic x)
        {
            return llrint(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static BigDecimal ceil(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Ceil(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Ceil", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Ceil(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static BigDecimal ceil(dynamic x)
        {
            return ceil(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static BigDecimal floor(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Floor(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Floor", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Floor(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static BigDecimal floor(dynamic x)
        {
            return floor(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static BigDecimal trunc(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Trunc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Trunc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Trunc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static BigDecimal trunc(dynamic x)
        {
            return trunc(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static BigDecimal round(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Round(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Round", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Round(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static BigDecimal round(dynamic x)
        {
            return round(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(BigDecimal x)
        {
            return Lib_Mpd_Lround(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Lround", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_Lround(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(dynamic x)
        {
            return lround(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(BigDecimal x)
        {
            return Lib_Mpd_Llround(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Llround", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int64 Lib_Mpd_Llround(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(dynamic x)
        {
            return llround(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt32/*' />
        internal static Int32 ToInt32(BigDecimal x)
        {
            return Lib_Mpd_ToInt32(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ToInt32", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_ToInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt32/*' />
        //public static Int32 ToInt32(dynamic x)
        //{
        //    return ToInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt64/*' />
        //public static Int64 ToInt64(BigDecimal x)
        //{
        //    return Lib_Mpd_ToInt64(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ToInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern Int64 Lib_Mpd_ToInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt64/*' />
        //public static Int64 ToInt64(dynamic x)
        //{
        //    return ToInt64(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt32/*' />
        //public static UInt32 ToUInt32(BigDecimal x)
        //{
        //    return Lib_Mpd_ToUInt32(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ToUInt32", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern UInt32 Lib_Mpd_ToUInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt32/*' />
        //public static UInt32 ToUInt32(dynamic x)
        //{
        //    return ToUInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt64/*' />
        //public static UInt64 ToUInt64(BigDecimal x)
        //{
        //    return Lib_Mpd_ToUInt64(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ToUInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern UInt64 Lib_Mpd_ToUInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt64/*' />
        //public static UInt64 ToUInt64(dynamic x)
        //{
        //    return ToUInt64(t(x));
        //}




        #endregion



        #region Floating point functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static BigDecimal copysign(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Copysign(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Copysign", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Copysign(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static BigDecimal copysign(dynamic x, dynamic y)
        {
            return copysign(bflint.t(x), bflint.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Frexp/*' />
        public static Tuple<BigDecimal, Int32> Frexp(BigDecimal x)
        {
            var res = new BigDecimal();
            Int32 e = 0;
            Lib_Mpd_Frexp(res.mpPtr, x.mpPtr, ref e);
            return new Tuple<BigDecimal, int>(res, e);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Frexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Frexp(IntPtr res, IntPtr x, ref Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Frexp/*' />
        public static Tuple<BigDecimal, Int32> Frexp(dynamic x)
        {
            return Frexp(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static BigDecimal logb(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Logb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Logb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Logb(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static BigDecimal logb(dynamic x)
        {
            return logb(t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(BigDecimal x)
        {
            return Lib_Mpd_Ilogb(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Ilogb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpd_Ilogb(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(dynamic x)
        {
            return ilogb(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static BigDecimal ldexp(BigDecimal x, Int32 e)
        {
            var res = new BigDecimal();
            Lib_Mpd_Ldexp(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Ldexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Ldexp(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static BigDecimal ldexp(dynamic x, dynamic e)
        {
            return ldexp(t(x), ToInt32(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static BigDecimal scalbn(BigDecimal x, Int32 e)
        {
            var res = new BigDecimal();
            Lib_Mpd_Scalbn(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Scalbn", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Scalbn(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static BigDecimal scalbn(dynamic x, dynamic e)
        {
            return scalbn(t(x), ToInt32(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static BigDecimal scalbln(BigDecimal x, Int32 e)
        {
            var res = new BigDecimal();
            Lib_Mpd_Scalbln(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Scalbln", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Scalbln(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static BigDecimal scalbln(dynamic x, dynamic e)
        {
            return scalbln(t(x), ToInt32(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static BigDecimal fdim(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Fdim(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Fdim", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Fdim(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static BigDecimal fdim(dynamic x, dynamic y)
        {
            return fdim(bflint.t(x), bflint.t(y));
        }


        #endregion



        #region Fraction and remainder Related Functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<BigDecimal, BigDecimal> modf(BigDecimal x)
        {
            BigDecimal iptr = new BigDecimal();
            BigDecimal frac = new BigDecimal();
            Lib_Mpd_Modf(frac.mpPtr, x.mpPtr, iptr.mpPtr);
            return new Tuple<BigDecimal, BigDecimal>(iptr, frac);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Modf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Modf(IntPtr frac, IntPtr x, IntPtr iptr);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<BigDecimal, BigDecimal> modf(dynamic x)
        {
            return modf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static BigDecimal fmod(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Fmod(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Fmod", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Fmod(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static BigDecimal fmod(dynamic x, dynamic y)
        {
            return fmod(bflint.t(x), bflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static BigDecimal remainder(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Remainder(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Remainder", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Remainder(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static BigDecimal remainder(dynamic x, dynamic y)
        {
            return remainder(bflint.t(x), bflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<BigDecimal, Int32> remquo(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Int32 e = 0;
            Lib_Mpd_Remquo(res.mpPtr, x.mpPtr, y.mpPtr, ref e);
            return new Tuple<BigDecimal, int>(res, e);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Remquo", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Remquo(IntPtr res, IntPtr x, IntPtr y, ref Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<BigDecimal, Int32> remquo(dynamic x)
        {
            return remquo(t(x));
        }

        #endregion



        #region Functions related to mantissa width and exponent range


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/Epsilon/*' />
        public static BigDecimal epsilon()
        {
            var res = new BigDecimal();
            Lib_Mpd_Epsilon(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Epsilon", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Epsilon(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static BigDecimal ulp(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Ulp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Ulp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Ulp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/maxvalue/*' />
        public static BigDecimal maxvalue()
        {
            var res = new BigDecimal();
            Lib_Mpd_Max(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Max", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Max(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/lowestvalue/*' />
        public static BigDecimal lowestvalue()
        {
            var res = new BigDecimal();
            Lib_Mpd_Lowest(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Lowest", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Lowest(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/minposvalue/*' />
        public static BigDecimal minposvalue()
        {
            var res = new BigDecimal();
            Lib_Mpd_Min(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Min", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Min(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nexttowards/*' />
        public static BigDecimal nexttowards(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Nexttoward(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Nexttoward", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Nexttoward(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nexttowards/*' />
        public static BigDecimal nexttowards(dynamic x, dynamic y)
        {
            return nexttowards(bflint.t(x), bflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static BigDecimal nextabove(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Nextabove(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Nextabove", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Nextabove(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static BigDecimal nextabove(dynamic x)
        {
            return nextabove(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static BigDecimal nextbelow(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Nextbelow(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Nextbelow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Nextbelow(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static BigDecimal nextbelow(dynamic x)
        {
            return nextbelow(t(x));
        }


        #endregion



        #region Mathematical Constants


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/degree/*' />
        public static BigDecimal degree()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstDegree(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstDegree", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstDegree(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phi/*' />
        public static BigDecimal phi()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstPhi(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstPhi(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln2/*' />
        public static BigDecimal ln2()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstLog2(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstLog2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstLog2(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln10/*' />
        public static BigDecimal ln10()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstLog10(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstLog10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstLog10(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pi/*' />
        public static BigDecimal pi()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstPi(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstPi(IntPtr res);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/PI/*' />
        //public static BigDecimal PI()
        //{
        //    return PI();
        //}


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/e/*' />
        public static BigDecimal e()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstE(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstE(IntPtr res);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/E/*' />
        //public static BigDecimal E()
        //{
        //    return E();
        //}


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/egamma/*' />
        public static BigDecimal egamma()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstEulerGamma(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstEulerGamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstEulerGamma(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/apery/*' />
        public static BigDecimal apery()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstApery(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstApery", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstApery(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/catalan/*' />
        public static BigDecimal catalan()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstCatalan(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstCatalan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstCatalan(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/glaisher/*' />
        public static BigDecimal glaisher()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstGlaisher(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstGlaisher", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstGlaisher(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/khinchin/*' />
        public static BigDecimal khinchin()
        {
            var res = new BigDecimal();
            Lib_Mpd_ConstKhinchin(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_ConstKhinchin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_ConstKhinchin(IntPtr res);


        #endregion



        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static BigDecimal abs(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Fabs(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Fabs", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Fabs(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static BigDecimal abs(dynamic x)
        {
            return abs(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static BigDecimal fabs(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Fabs(res.mpPtr, x.mpPtr);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static BigDecimal fabs(dynamic x)
        {
            return fabs(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static BigDecimal sign(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Sign(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Sign", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Sign(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static BigDecimal sign(dynamic x)
        {
            return sign(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static BigDecimal real(BigDecimal x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static BigDecimal real(dynamic x)
        {
            return real(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static BigDecimal imag(BigDecimal x)
        {
            return zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static BigDecimal imag(dynamic x)
        {
            return imag(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static BigDecimal phase(BigDecimal x)
        {
            return zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static BigDecimal phase(dynamic x)
        {
            return phase(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static BigDecimal conj(BigDecimal x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static BigDecimal conj(dynamic x)
        {
            return conj(t(x));
        }



        #endregion








        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static BigDecimal sqrt(BigDecimal x)
        {
            if (x < 0) return bflint.nan();
            var res = new BigDecimal();
            Lib_Mpd_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static BigDecimal sqrt(dynamic x)
        {
            return sqrt(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static BigDecimal rsqrt(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static BigDecimal rsqrt(dynamic x)
        {
            return rsqrt(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static BigDecimal cbrt(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static BigDecimal cbrt(dynamic x)
        {
            return cbrt(t(x));
        }


        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static BigDecimal exp2(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static BigDecimal exp2(dynamic x)
        {
            return exp2(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static BigDecimal exp(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static BigDecimal exp(dynamic x)
        {
            return exp(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static BigDecimal expm1(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static BigDecimal expm1(dynamic x)
        {
            return expm1(t(x));
        }


        #endregion



        #region Logarithms and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static BigDecimal log(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static BigDecimal log(dynamic x)
        {
            return log(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static BigDecimal log10(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static BigDecimal log10(dynamic x)
        {
            return log10(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static BigDecimal log2(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static BigDecimal log2(dynamic x)
        {
            return log2(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static BigDecimal log1p(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static BigDecimal log1p(dynamic x)
        {
            return log1p(t(x));
        }


        #endregion



        #region Power functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static BigDecimal sqr(BigDecimal x)
        {
            return x * x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static BigDecimal pow(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static BigDecimal pow(dynamic x, dynamic y)
        {
            return pow(bflint.t(x), bflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static BigDecimal hypot(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static BigDecimal hypot(dynamic x, dynamic y)
        {
            return hypot(bflint.t(x), bflint.t(y));
        }


        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static BigDecimal cos(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static BigDecimal cos(dynamic x)
        {
            return cos(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static BigDecimal sin(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static BigDecimal sin(dynamic x)
        {
            return sin(t(x));
        }


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Sincos/*' />
        //public static Tuple<BigDecimal, BigDecimal> Sincos(BigDecimal x)
        //{
        //    BigDecimal s = new BigDecimal(), c = new BigDecimal();
        //    Lib_Mpd_Sincos(x.mpPtr, s.mpPtr, c.mpPtr);
        //    return new Tuple<BigDecimal, BigDecimal>(s, c);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Sincos", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern void Lib_Mpd_Sincos(IntPtr x, IntPtr s, IntPtr c);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Sincos/*' />
        //public static Tuple<BigDecimal, BigDecimal> Sincos(dynamic x)
        //{
        //    return Sincos(bflint.t(x));
        //}


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static BigDecimal tan(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static BigDecimal tan(dynamic x)
        {
            return tan(t(x));
        }


        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static BigDecimal cosh(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static BigDecimal cosh(dynamic x)
        {
            return cosh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static BigDecimal sinh(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static BigDecimal sinh(dynamic x)
        {
            return sinh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static BigDecimal tanh(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static BigDecimal tanh(dynamic x)
        {
            return tanh(t(x));
        }


        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static BigDecimal acos(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static BigDecimal acos(dynamic x)
        {
            return acos(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static BigDecimal asin(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static BigDecimal asin(dynamic x)
        {
            return asin(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static BigDecimal atan(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static BigDecimal atan(dynamic x)
        {
            return atan(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static BigDecimal atan2(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Atan2(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Atan2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Atan2(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static BigDecimal atan2(dynamic x, dynamic y)
        {
            return atan2(bflint.t(x), bflint.t(y));
        }


        #endregion



        #region Inverse hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static BigDecimal acosh(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static BigDecimal acosh(dynamic x)
        {
            return acosh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static BigDecimal asinh(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static BigDecimal asinh(dynamic x)
        {
            return asinh(t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static BigDecimal atanh(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static BigDecimal atanh(dynamic x)
        {
            return atanh(t(x));
        }


        #endregion






        #region Matrix Creation


        /// <summary>
        /// Converts from a real scalar of type BigDecimal
        /// </summary>
        public static BigDecimalMat mat_t(BigDecimal x)
        {
            var matA = new BigDecimalMat();
            matA[0, 0] = x;
            return matA;
        }


        /* *********************** */

        public static BigDecimalMatC mat_cplx_t(BigDecimalMat matA)
        {
            return bflintc.mat_t(matA);
        }


        public static BigDecimalMatC mat_cplx_zeros(int n, int m)
        {
            return bflintc.mat_zeros(n, m);
        }

        /* *********************** */




        /// <summary>
        /// Returns SetZero
        /// </summary>
        public static BigDecimalMat mat_zeros(int n, int m)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_setZero, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetOnes
        /// </summary>
        public static BigDecimalMat mat_ones(int n, int m)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_setOnes, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static BigDecimalMat mat_identity(int n, int m)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static BigDecimalMat mat_eye(int n, int m)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns Random
        /// </summary>
        public static BigDecimalMat mat_random(int n, int m)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_setRandom_nm, n, m);
            return resout;
        }


        /// <summary>
        /// Returns RandomSym
        /// </summary>
        public static BigDecimalMat mat_random_symmetric(int n)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_setRandomSymmetric, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSa
        /// </summary>
        public static BigDecimalMat mat_random_selfadjoint(int n)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_setRandomSA, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSaPosdef
        /// </summary>
        public static BigDecimalMat mat_random_selfadjoint_posdef(int n)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_setRandomSAPosDef, n, n);
            return resout;
        }


        /// <summary>
        /// Returns FillLinear
        /// </summary>
        public static BigDecimalMat mat_fill_linear(int n, int m)
        {
            var resout = new BigDecimalMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpr, resout, constants.mp_FillLinear, n, m);
            return resout;
        }






        #endregion







        #endregion





        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static BigDecimal m_elliptic_k(BigDecimal m)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static BigDecimal m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static BigDecimal m_elliptic_e(BigDecimal m)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static BigDecimal m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static BigDecimal m_elliptic_pi(BigDecimal n, BigDecimal m)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static BigDecimal m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(bflint.t(x), bflint.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static BigDecimal m_elliptic_f(BigDecimal phi, BigDecimal m)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static BigDecimal m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(bflint.t(phi), bflint.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static BigDecimal m_elliptic_e_inc(BigDecimal phi, BigDecimal m)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static BigDecimal m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(bflint.t(phi), bflint.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static BigDecimal m_elliptic_pi_inc(BigDecimal n, BigDecimal phi, BigDecimal m)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_MEllipticPiInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_MEllipticPiInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static BigDecimal m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(bflint.t(n), bflint.t(phi), bflint.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static BigDecimal elliptic_k(BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static BigDecimal elliptic_k(dynamic k)
        {
            return elliptic_k(bflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static BigDecimal elliptic_e(BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static BigDecimal elliptic_e(dynamic k)
        {
            return elliptic_e(bflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static BigDecimal elliptic_pi(BigDecimal n, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static BigDecimal elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(bflint.t(n), bflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static BigDecimal elliptic_f(BigDecimal phi, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static BigDecimal elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(bflint.t(phi), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static BigDecimal elliptic_e_inc(BigDecimal phi, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static BigDecimal elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(bflint.t(phi), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static BigDecimal elliptic_pi_inc(BigDecimal n, BigDecimal phi, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static BigDecimal elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(bflint.t(n), bflint.t(phi), bflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static BigDecimal agm(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static BigDecimal agm(dynamic x, dynamic y)
        {
            return agm(bflint.t(x), bflint.t(y));
        }


        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static BigDecimal elliptic_rc(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static BigDecimal elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(bflint.t(x), bflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static BigDecimal elliptic_rf(BigDecimal x, BigDecimal y, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static BigDecimal elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(bflint.t(x), bflint.t(y), bflint.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static BigDecimal elliptic_rg(BigDecimal x, BigDecimal y, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static BigDecimal elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(bflint.t(x), bflint.t(y), bflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static BigDecimal elliptic_rd(BigDecimal x, BigDecimal y, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static BigDecimal elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(bflint.t(x), bflint.t(y), bflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static BigDecimal elliptic_rj(BigDecimal x, BigDecimal y, BigDecimal z, BigDecimal w)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static BigDecimal elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(bflint.t(x), bflint.t(y), bflint.t(z), bflint.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static BigDecimal jacobi_theta1(BigDecimal x, BigDecimal q)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static BigDecimal jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(bflint.t(x), bflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static BigDecimal jacobi_theta2(BigDecimal x, BigDecimal q)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static BigDecimal jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(bflint.t(x), bflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static BigDecimal jacobi_theta3(BigDecimal x, BigDecimal q)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static BigDecimal jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(bflint.t(x), bflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static BigDecimal jacobi_theta4(BigDecimal x, BigDecimal q)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static BigDecimal jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(bflint.t(x), bflint.t(q));
        }




        #endregion



        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static BigDecimal jacobi_sn(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static BigDecimal jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static BigDecimal jacobi_cn(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static BigDecimal jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static BigDecimal jacobi_dn(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static BigDecimal jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static BigDecimal jacobi_ns(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static BigDecimal jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static BigDecimal jacobi_nc(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static BigDecimal jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static BigDecimal jacobi_nd(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static BigDecimal jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static BigDecimal jacobi_sc(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static BigDecimal jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static BigDecimal jacobi_sd(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static BigDecimal jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static BigDecimal jacobi_dc(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static BigDecimal jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static BigDecimal jacobi_ds(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static BigDecimal jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static BigDecimal jacobi_cs(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static BigDecimal jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(bflint.t(x), bflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static BigDecimal jacobi_cd(BigDecimal x, BigDecimal k)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpd_Arb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static BigDecimal jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(bflint.t(x), bflint.t(k));
        }








        #endregion



        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static BigDecimal lerch_phi(BigDecimal s, BigDecimal z, BigDecimal a)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static BigDecimal lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(bflint.t(s), bflint.t(z), bflint.t(a));
        }





        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static BigDecimal polygamma(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static BigDecimal polygamma(dynamic s, dynamic z)
        {
            return polygamma(bflint.t(s), bflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static BigDecimal digamma(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static BigDecimal digamma(dynamic x)
        {
            return digamma(bflint.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static BigDecimal polylog(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static BigDecimal polylog(dynamic s, dynamic z)
        {
            return polylog(bflint.t(s), bflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static BigDecimal dilog(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static BigDecimal dilog(dynamic x)
        {
            return dilog(bflint.t(x));
        }






        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static BigDecimal hurwitz_zeta(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_HurwitzZeta(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static BigDecimal hurwitz_zeta(dynamic s, dynamic z)
        {
            return hurwitz_zeta(bflint.t(s), bflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static BigDecimal bernoulli(Int32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Bernoulli_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Bernoulli_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Bernoulli_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static BigDecimal bernpoly(BigDecimal x, Int32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulernum/*' />
        public static BigDecimal eulernum(Int32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Euler_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Euler_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Euler_ui(IntPtr res, Int32 n);






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static BigDecimal barnes_g(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static BigDecimal barnes_g(dynamic x)
        {
            return barnes_g(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static BigDecimal logbarnes_g(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static BigDecimal logbarnes_g(dynamic x)
        {
            return logbarnes_g(bflint.t(x));
        }






        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static BigDecimal zeta(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static BigDecimal zeta(dynamic x)
        {
            return zeta(bflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        public static BigDecimal backlund_s(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BacklundS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BacklundS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BacklundS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        public static BigDecimal backlund_s(dynamic x)
        {
            return zeta(bflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/grampoint/*' />
        public static BigDecimal grampoint(Int32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_GramPoint_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_GramPoint_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_GramPoint_ui(IntPtr res, Int32 n);







        #endregion



        #region Additional numbertheoretic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bell/*' />
        public static BigDecimal bell(Int32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Bell_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Bell_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Bell_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/partitions/*' />
        public static BigDecimal partitions(Int32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Partitions_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Partitions_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Partitions_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/primorial/*' />
        public static BigDecimal primorial(Int32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Primorial_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Primorial_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Primorial_ui(IntPtr res, Int32 n);





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static BigDecimal hyperg_0f1(BigDecimal a, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static BigDecimal hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(bflint.t(a), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static BigDecimal hyperg_0f1r(BigDecimal a, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static BigDecimal hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(bflint.t(a), bflint.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static BigDecimal bessel_jv(BigDecimal nu, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BesselJ(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BesselJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BesselJ(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static BigDecimal bessel_jv(dynamic nu, dynamic x)
        {
            return bessel_jv(bflint.t(nu), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static BigDecimal bessel_yv(BigDecimal nu, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BesselY(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BesselY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BesselY(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static BigDecimal bessel_yv(dynamic nu, dynamic x)
        {
            return bessel_yv(bflint.t(nu), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static BigDecimal bessel_iv(BigDecimal nu, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BesselI(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BesselI", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BesselI(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static BigDecimal bessel_iv(dynamic nu, dynamic x)
        {
            return bessel_iv(bflint.t(nu), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static BigDecimal bessel_kv(BigDecimal nu, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BesselK(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BesselK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BesselK(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static BigDecimal bessel_kv(dynamic nu, dynamic x)
        {
            return bessel_kv(bflint.t(nu), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_ive/*' />
        public static BigDecimal bessel_ive(BigDecimal nu, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BesselIScaled(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BesselIScaled", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BesselIScaled(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_ive/*' />
        public static BigDecimal bessel_ive(dynamic nu, dynamic x)
        {
            return bessel_ive(bflint.t(nu), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kve/*' />
        public static BigDecimal bessel_kve(BigDecimal nu, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BesselKScaled(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BesselKScaled", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BesselKScaled(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kve/*' />
        public static BigDecimal bessel_kve(dynamic nu, dynamic x)
        {
            return bessel_kve(bflint.t(nu), bflint.t(x));
        }




        #endregion



        #region 0F1: Spherical Bessel functions



        #endregion



        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static BigDecimal airy_ai(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_AiryAi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_AiryAi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static BigDecimal airy_ai(dynamic x)
        {
            return airy_ai(bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static BigDecimal airy_ai_prime(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_AiryAiPrime(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_AiryAiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static BigDecimal airy_ai_prime(dynamic x)
        {
            return airy_ai_prime(bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static BigDecimal airy_bi(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_AiryBi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_AiryBi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static BigDecimal airy_bi(dynamic x)
        {
            return airy_bi(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static BigDecimal airy_bi_prime(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_AiryBiPrime(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_AiryBiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static BigDecimal airy_bi_prime(dynamic x)
        {
            return airy_bi_prime(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        public static BigDecimal airy_ai_zero(UInt32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_AiryAiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_AiryAiZero(IntPtr res, UInt32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        public static BigDecimal airy_ai_prime_zero(UInt32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_AiryAiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_AiryAiPrimeZero(IntPtr res, UInt32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        public static BigDecimal airy_bi_zero(UInt32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_AiryBiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_AiryBiZero(IntPtr res, UInt32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        public static BigDecimal airy_bi_prime_zero(UInt32 n)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_AiryBiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_AiryBiPrimeZero(IntPtr res, UInt32 n);



        #endregion



        #region 0F1: Kelvin functions



        #endregion








        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static BigDecimal hyperg_1f1(BigDecimal a, BigDecimal b, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static BigDecimal hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(bflint.t(a), bflint.t(b), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static BigDecimal hyperg_1f1r(BigDecimal a, BigDecimal b, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static BigDecimal hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(bflint.t(a), bflint.t(b), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static BigDecimal hyperg_u(BigDecimal a, BigDecimal b, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static BigDecimal hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(bflint.t(a), bflint.t(b), bflint.t(x));
        }





        #endregion



        #region 1F1: gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static BigDecimal gamma(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static BigDecimal gamma(dynamic x)
        {
            return gamma(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static BigDecimal rgamma(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static BigDecimal rgamma(dynamic x)
        {
            return rgamma(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static BigDecimal lgamma(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static BigDecimal lgamma(dynamic x)
        {
            return lgamma(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static BigDecimal rising_factorial(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static BigDecimal rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(bflint.t(x), bflint.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static BigDecimal beta(BigDecimal x, BigDecimal y)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static BigDecimal beta(dynamic x, dynamic y)
        {
            return beta(bflint.t(x), bflint.t(y));
        }


        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static BigDecimal gamma_upper(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static BigDecimal gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(bflint.t(s), bflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static BigDecimal gamma_q(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static BigDecimal gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(bflint.t(s), bflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static BigDecimal gamma_lower(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static BigDecimal gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(bflint.t(s), bflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static BigDecimal gamma_p(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static BigDecimal gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(bflint.t(s), bflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static BigDecimal gamma_p_prime(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static BigDecimal gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(bflint.t(s), bflint.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static BigDecimal erf(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static BigDecimal erf(dynamic x)
        {
            return erf(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static BigDecimal erfc(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static BigDecimal erfc(dynamic x)
        {
            return erfc(bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static BigDecimal erf_inv(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Erfinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Erfinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Erfinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static BigDecimal erf_inv(dynamic x)
        {
            return erf_inv(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static BigDecimal erfc_inv(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Erfcinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Erfcinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Erfcinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static BigDecimal erfc_inv(dynamic x)
        {
            return erfc_inv(bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static BigDecimal erfi(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static BigDecimal erfi(dynamic x)
        {
            return erfi(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static BigDecimal fresnel_s(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static BigDecimal fresnel_s(dynamic x)
        {
            return fresnel_s(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static BigDecimal fresnel_c(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static BigDecimal fresnel_c(dynamic x)
        {
            return fresnel_c(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static BigDecimal ndens(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static BigDecimal ndens(dynamic x)
        {
            return ndens(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static BigDecimal ndis(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static BigDecimal ndis(dynamic x)
        {
            return ndis(bflint.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static BigDecimal exp_integral_e1(BigDecimal s, BigDecimal z)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static BigDecimal exp_integral_e1(dynamic s, dynamic z)
        {
            return exp_integral_e1(bflint.t(s), bflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static BigDecimal exp_integral_ei(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static BigDecimal exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static BigDecimal sin_integral(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static BigDecimal sin_integral(dynamic x)
        {
            return sin_integral(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static BigDecimal cos_integral(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static BigDecimal cos_integral(dynamic x)
        {
            return cos_integral(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static BigDecimal sinh_integral(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static BigDecimal sinh_integral(dynamic x)
        {
            return sinh_integral(bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static BigDecimal cosh_integral(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static BigDecimal cosh_integral(dynamic x)
        {
            return cosh_integral(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static BigDecimal log_integral(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static BigDecimal log_integral(dynamic x)
        {
            return log_integral(bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static BigDecimal log_integral_offset(BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static BigDecimal log_integral_offset(dynamic x)
        {
            return log_integral_offset(bflint.t(x));
        }



        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static BigDecimal hermite_h(BigDecimal n, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static BigDecimal hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(bflint.t(n), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static BigDecimal laguerre_l(BigDecimal n, BigDecimal m, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static BigDecimal laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(bflint.t(n), bflint.t(m), bflint.t(x));
        }



        #endregion



        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static BigDecimal coulomb_f(BigDecimal l, BigDecimal eta, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static BigDecimal coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(bflint.t(l), bflint.t(eta), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static BigDecimal coulomb_g(BigDecimal l, BigDecimal eta, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static BigDecimal coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(bflint.t(l), bflint.t(eta), bflint.t(x));
        }



        #endregion



        #region 1F1: Whittaker functions


        #endregion



        #region 1F1: Parabolic cylinder functions


        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static BigDecimal hyperg_2f1(BigDecimal a, BigDecimal b, BigDecimal c, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static BigDecimal hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(bflint.t(a), bflint.t(b), bflint.t(c), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static BigDecimal hyperg_2f1r(BigDecimal a, BigDecimal b, BigDecimal c, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static BigDecimal hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(bflint.t(a), bflint.t(b), bflint.t(c), bflint.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static BigDecimal chebyshev_t(BigDecimal n, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static BigDecimal chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(bflint.t(n), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static BigDecimal chebyshev_u(BigDecimal n, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static BigDecimal chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(bflint.t(n), bflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static BigDecimal gegenbauer_c(BigDecimal n, BigDecimal m, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static BigDecimal gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(bflint.t(n), bflint.t(m), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static BigDecimal jacobi_p(BigDecimal n, BigDecimal a, BigDecimal b, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static BigDecimal jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(bflint.t(n), bflint.t(a), bflint.t(b), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static BigDecimal legendre_p(BigDecimal n, BigDecimal m, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LegendreP(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static BigDecimal legendre_p(dynamic n, dynamic m, dynamic x)
        {
            return legendre_p(bflint.t(n), bflint.t(m), bflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static BigDecimal legendre_plm(BigDecimal n, BigDecimal m, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LegendrePv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static BigDecimal legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(bflint.t(n), bflint.t(m), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static BigDecimal legendre_q(BigDecimal n, BigDecimal m, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LegendreQ(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static BigDecimal legendre_q(dynamic n, dynamic m, dynamic x)
        {
            return legendre_q(bflint.t(n), bflint.t(m), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static BigDecimal legendre_qlm(BigDecimal n, BigDecimal m, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_LegendreQv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static BigDecimal legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(bflint.t(n), bflint.t(m), bflint.t(x));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static BigDecimal beta_lower(BigDecimal a, BigDecimal b, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static BigDecimal beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(bflint.t(a), bflint.t(b), bflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static BigDecimal ibeta(BigDecimal a, BigDecimal b, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static BigDecimal ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(bflint.t(a), bflint.t(b), bflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static BigDecimal ibetac(BigDecimal a, BigDecimal b, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static BigDecimal ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(bflint.t(a), bflint.t(b), bflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static BigDecimal ibeta_prime(BigDecimal a, BigDecimal b, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static BigDecimal ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(bflint.t(a), bflint.t(b), bflint.t(x));
        }


        #endregion



        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static BigDecimal hyperg_1f2(BigDecimal a1, BigDecimal b1, BigDecimal b2, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static BigDecimal hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(bflint.t(a1), bflint.t(b1), bflint.t(b2), bflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static BigDecimal hyperg_1f2r(BigDecimal a1, BigDecimal b1, BigDecimal b2, BigDecimal x)
        {
            var res = new BigDecimal();
            Lib_Mpd_Arb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpd_Arb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpd_Arb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static BigDecimal hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(bflint.t(a1), bflint.t(b1), bflint.t(b2), bflint.t(x));
        }





        #endregion


        #endregion




    }






}
