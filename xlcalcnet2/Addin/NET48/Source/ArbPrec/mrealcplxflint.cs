using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Numerics;
using FixedPrecNet;


namespace ArbPrecNet
{







    public class mflint
    {





        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "mflint"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return " mflint"; }
        }




        public static String fmt(Mpfr x)
        {
            string s = " " + x.ToString();
            return s;
        }


        public static String fmt(dynamic x)
        {
            return fmt(t(x));
        }


        #region Basic Functions





        #region General

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsRealCtx/*' />
        public static bool IsRealCtx
        {
            get { return true; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsCplxCtx/*' />
        public static bool IsCplxCtx
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

        ///// <include file="docs.xml" path='docs/members[@name="Contexts"]/Mat/*' />
        //public static mrealmat Mat
        //{
        //    get { return new mrealmat(); }
        //}


        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/realctx/*' />
        public static mflint realctx
        {
            get { return new mflint(); }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/CplxCtx/*' />
        public static mflintc CplxCtx
        {
            get { return new mflintc(); }
        }


        #endregion



        #region Conversions



        /// <summary>
        /// Returns a new Mpfr using an dynamic as input
        /// </summary>
        public static Mpfr t(dynamic x)
        {
            return mreal.t(x);
        }



        /// <summary>
        /// Returns a new Mpfr using an arbitrary precision (both mantissa and exponent) ball number as input
        /// </summary>
        public static Mpfr t(Arb x)
        {
            return mreal.t(x);
        }





        /// <summary>
        /// Returns a new Mpfr using an arbitrary precision binary floating point number as input
        /// </summary>
        public static Mpfr t(Mpfr x)
        {
            return mreal.t(x);
        }





        /// <summary>
        /// Returns a new Mpfr using a quadruple precision binary floating point number as input
        /// </summary>
        public static Mpfr t(Quadruple x)
        {
            return mreal.t(x);
        }



        /// <summary>
        /// Returns a new Mpfr using an extended precision floating point number as input
        /// </summary>
        public static Mpfr t(Extended x)
        {
            return mreal.t(x);
        }




        /// <summary>
        /// Returns a new Arb using a double precision floating point number as input
        /// </summary>
        public static Mpfr t(Double x)
        {
            return mreal.t(x);
        }



        /// <summary>
        /// Returns a new Mpfr using a single precision binary floating point number as input
        /// </summary>
        public static Mpfr t(Single x)
        {
            return mreal.t(x);
        }



        /// <summary>
        /// Returns a new Mpfr using a signed 32 bit integer as input
        /// </summary>
        public static Mpfr t(Int32 x)
        {
            return mreal.t(x);
        }



        /// <summary>
        /// Returns a new Mpfr using an unsigned 32 bit integer as input
        /// </summary>
        public static Mpfr t(UInt32 x)
        {
            return mreal.t(x);
        }



        /// <summary>
        /// Returns a new Mpfr using a signed 64 bit integer as input
        /// </summary>
        public static Mpfr t(Int64 x)
        {
            return mreal.t(x);
        }


        /// <summary>
        /// Returns a new Mpfr using an unsigned 64 bit integer as input
        /// </summary>
        public static Mpfr t(UInt64 x)
        {
            return mreal.t(x);
        }


        /// <summary>
        /// Returns a new Mpfr using an arbitrary precision integer as input
        /// </summary>
        public static Mpfr t(BigInteger x)
        {
            return mreal.t(x);
        }


        /// <summary>
        /// Returns a new Mpfr using a System.Decimal as input
        /// </summary>
        public static Mpfr t(decimal x)
        {
            return mreal.t(x);
        }



        /// <summary>
        /// Returns a new Mpfr using a string as input
        /// </summary>
        public static Mpfr t(string s)
        {
            return mreal.t(s);
        }







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
            return mreal.onej();
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



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt32/*' />
        internal static Int32 ToInt32(Mpfr x)
        {
            return Lib_Mpfr_ToInt32(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ToInt32", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Mpfr_ToInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt32/*' />
        //public static Int32 ToInt32(dynamic x)
        //{
        //    return ToInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt64/*' />
        //public static Int64 ToInt64(Mpfr x)
        //{
        //    return Lib_Mpfr_ToInt64(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ToInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern Int64 Lib_Mpfr_ToInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt64/*' />
        //public static Int64 ToInt64(dynamic x)
        //{
        //    return ToInt64(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt32/*' />
        //public static UInt32 ToUInt32(Mpfr x)
        //{
        //    return Lib_Mpfr_ToUInt32(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ToUInt32", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern UInt32 Lib_Mpfr_ToUInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt32/*' />
        //public static UInt32 ToUInt32(dynamic x)
        //{
        //    return ToUInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt64/*' />
        //public static UInt64 ToUInt64(Mpfr x)
        //{
        //    return Lib_Mpfr_ToUInt64(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_ToUInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern UInt64 Lib_Mpfr_ToUInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt64/*' />
        //public static UInt64 ToUInt64(dynamic x)
        //{
        //    return ToUInt64(t(x));
        //}




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
        public static Tuple<Mpfr, Int32> Frexp(Mpfr x)
        {
            var res = new Mpfr();
            Int32 e = 0;
            Lib_Mpfr_Frexp(res.mpPtr, x.mpPtr, ref e);
            return new Tuple<Mpfr, int>(res, e);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Frexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Frexp(IntPtr res, IntPtr x, ref Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Frexp/*' />
        public static Tuple<Mpfr, Int32> Frexp(dynamic x)
        {
            return Frexp(t(x));
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
            return ldexp(t(x), ToInt32(t(e)));
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
            return scalbn(t(x), ToInt32(t(e)));
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
            return scalbln(t(x), ToInt32(t(e)));
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
        public static Tuple<Mpfr, Int32> remquo(dynamic x)
        {
            return remquo(t(x));
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
            return mreal.phase(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Mpfr phase(dynamic x)
        {
            return mreal.phase(x);
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
            return mflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static MpfrC expj(dynamic x)
        {
            return mflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static MpfrC expjpi(Mpfr x)
        {
            return mflintc.expjpi(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static MpfrC expjpi(dynamic x)
        {
            return mflintc.expjpi(x);
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




        #region Gamma and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Mpfr gamma(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Mpfr gamma(dynamic x)
        {
            return gamma(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Mpfr rgamma(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Mpfr rgamma(dynamic x)
        {
            return rgamma(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Mpfr lgamma(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Mpfr lgamma(dynamic x)
        {
            return lgamma(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Mpfr rising_factorial(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Mpfr rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(mflint.t(x), mflint.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Mpfr beta(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Mpfr beta(dynamic x, dynamic y)
        {
            return beta(mflint.t(x), mflint.t(y));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Mpfr gamma1pm1(Mpfr x)
        {
            return aflint.MRealViaArbS1(aflint.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Mpfr gamma1pm1(dynamic x)
        {
            return gamma1pm1(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Mpfr factorial(Mpfr x)
        {
            return aflint.MRealViaArbS1(aflint.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Mpfr factorial(dynamic x)
        {
            return factorial(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Mpfr doublefactorial(Mpfr x)
        {
            return aflint.MRealViaArbS1(aflint.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Mpfr doublefactorial(dynamic x)
        {
            return doublefactorial(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Mpfr falling_factorial(Mpfr a, Mpfr n)
        {
            return aflint.MRealViaArbS2(aflint.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Mpfr falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(mreal.t(a), mreal.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Mpfr gamma_ratio(Mpfr a, Mpfr b)
        {
            return aflint.MRealViaArbS2(aflint.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Mpfr gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(mreal.t(a), mreal.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Mpfr gamma_delta_ratio(Mpfr a, Mpfr delta)
        {
            return aflint.MRealViaArbS2(aflint.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Mpfr gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(mreal.t(a), mreal.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Mpfr binomial(Mpfr n, Mpfr k)
        {
            return aflint.MRealViaArbS2(aflint.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Mpfr binomial(dynamic n, dynamic k)
        {
            return binomial(mreal.t(n), mreal.t(k));
        }








        #endregion



        #region Miscellaneous


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Mpfr lambert_w0(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_LambertW0(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_LambertW0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_LambertW0(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Mpfr lambert_w0(dynamic x)
        {
            return lambert_w0(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Mpfr lambert_wm1(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_LambertWm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_LambertWm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_LambertWm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Mpfr lambert_wm1(dynamic x)
        {
            return lambert_wm1(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static MpfrC lambert_wk(Mpfr x, int k)
        {
            return mflintc.lambert_wk(mcplx.t(x), k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static MpfrC lambert_wk(dynamic x, int k)
        {
            return lambert_wk(mreal.t(x), k);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Mpfr agm(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Mpfr agm(dynamic x, dynamic y)
        {
            return agm(mflint.t(x), mflint.t(y));
        }








        #endregion






        #endregion





        #region Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Mpfr m_elliptic_k(Mpfr m)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Mpfr m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Mpfr m_elliptic_e(Mpfr m)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Mpfr m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Mpfr m_elliptic_pi(Mpfr n, Mpfr m)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Mpfr m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(mflint.t(x), mflint.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Mpfr m_elliptic_f(Mpfr phi, Mpfr m)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Mpfr m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(mflint.t(phi), mflint.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Mpfr m_elliptic_e_inc(Mpfr phi, Mpfr m)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Mpfr m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(mflint.t(phi), mflint.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Mpfr m_elliptic_pi_inc(Mpfr n, Mpfr phi, Mpfr m)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Mpfr m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(mflint.t(n), mflint.t(phi), mflint.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Mpfr elliptic_k(Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Mpfr elliptic_k(dynamic k)
        {
            return elliptic_k(mflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Mpfr elliptic_e(Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Mpfr elliptic_e(dynamic k)
        {
            return elliptic_e(mflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Mpfr elliptic_pi(Mpfr n, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Mpfr elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(mflint.t(n), mflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Mpfr elliptic_f(Mpfr phi, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Mpfr elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(mflint.t(phi), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Mpfr elliptic_e_inc(Mpfr phi, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Mpfr elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(mflint.t(phi), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Mpfr elliptic_pi_inc(Mpfr n, Mpfr phi, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Mpfr elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(mflint.t(n), mflint.t(phi), mflint.t(k));
        }




        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Mpfr elliptic_rc(Mpfr x, Mpfr y)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Mpfr elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(mflint.t(x), mflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Mpfr elliptic_rf(Mpfr x, Mpfr y, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Mpfr elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(mflint.t(x), mflint.t(y), mflint.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Mpfr elliptic_rg(Mpfr x, Mpfr y, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Mpfr elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(mflint.t(x), mflint.t(y), mflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Mpfr elliptic_rd(Mpfr x, Mpfr y, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Mpfr elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(mflint.t(x), mflint.t(y), mflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Mpfr elliptic_rj(Mpfr x, Mpfr y, Mpfr z, Mpfr w)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Mpfr elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(mflint.t(x), mflint.t(y), mflint.t(z), mflint.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Mpfr jacobi_theta1(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Mpfr jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(mflint.t(x), mflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Mpfr jacobi_theta2(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Mpfr jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(mflint.t(x), mflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Mpfr jacobi_theta3(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Mpfr jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(mflint.t(x), mflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Mpfr jacobi_theta4(Mpfr x, Mpfr q)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Mpfr jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(mflint.t(x), mflint.t(q));
        }




        #endregion



        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Mpfr jacobi_sn(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Mpfr jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Mpfr jacobi_cn(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Mpfr jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Mpfr jacobi_dn(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Mpfr jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Mpfr jacobi_ns(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Mpfr jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Mpfr jacobi_nc(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Mpfr jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Mpfr jacobi_nd(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Mpfr jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Mpfr jacobi_sc(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Mpfr jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Mpfr jacobi_sd(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Mpfr jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Mpfr jacobi_dc(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Mpfr jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Mpfr jacobi_ds(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Mpfr jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Mpfr jacobi_cs(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Mpfr jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(mflint.t(x), mflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Mpfr jacobi_cd(Mpfr x, Mpfr k)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfr_Arb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Mpfr jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(mflint.t(x), mflint.t(k));
        }








        #endregion



        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Mpfr lerch_phi(Mpfr s, Mpfr z, Mpfr a)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Mpfr lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(mflint.t(s), mflint.t(z), mflint.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static MpfrC lerch_zeta(Mpfr lambda1, Mpfr alpha, Mpfr s)
        {
            var res = mflintc.lerch_zeta(lambda1, alpha, s);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static MpfrC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(mreal.t(lambda1), mreal.t(alpha), mreal.t(s));
        }





        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Mpfr polygamma(Mpfr s, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Mpfr polygamma(dynamic s, dynamic z)
        {
            return polygamma(mflint.t(s), mflint.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Mpfr trigamma(Mpfr x)
        {
            return polygamma(1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Mpfr trigamma(dynamic x)
        {
            return trigamma(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Mpfr digamma(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Mpfr digamma(dynamic x)
        {
            return digamma(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Mpfr harmonic(Mpfr x)
        {
            MpfrC res = mflintc.harmonic(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Mpfr harmonic(dynamic x)
        {
            return harmonic(mreal.t(x));
        }




        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Mpfr polylog(Mpfr s, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Mpfr polylog(dynamic s, dynamic z)
        {
            return polylog(mflint.t(s), mflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Mpfr trilog(Mpfr x)
        {
            MpfrC res = mflintc.trilog(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Mpfr trilog(dynamic x)
        {
            return trilog(mreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Mpfr dilog(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Mpfr dilog(dynamic x)
        {
            return dilog(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Mpfr clausen_sin(Mpfr s, Mpfr z)
        {
            MpfrC res = mflintc.clausen_sin(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Mpfr clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(mflint.t(s), mflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Mpfr clausen_cos(Mpfr s, Mpfr z)
        {
            MpfrC res = mflintc.clausen_cos(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Mpfr clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(mreal.t(s), mreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Mpfr clausen2(Mpfr x)
        {
            return clausen_sin(mreal.t(2), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Mpfr clausen2(dynamic x)
        {
            return clausen_sin(mreal.t(2), mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Mpfr bose_einstein(Mpfr s, Mpfr z)
        {
            MpfrC res = mflintc.bose_einstein(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Mpfr bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(mreal.t(s), mreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Mpfr fermi_dirac(Mpfr s, Mpfr z)
        {
            MpfrC res = mflintc.fermi_dirac(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Mpfr fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(mreal.t(s), mreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Mpfr legendre_chi(Mpfr s, Mpfr z)
        {
            MpfrC res = mflintc.legendre_chi(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Mpfr legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(mreal.t(s), mreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Mpfr inverse_tan_integral(Mpfr s, Mpfr z)
        {
            MpfrC res = mflintc.inverse_tan_integral(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Mpfr inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(mreal.t(s), mreal.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Mpfr hurwitz_zeta(Mpfr s, Mpfr a)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_HurwitzZeta(res.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Mpfr hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(mflint.t(s), mflint.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Mpfr harmonic2(Mpfr z, Mpfr r)
        {
            MpfrC res = mflintc.harmonic2(z, r);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Mpfr harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(mreal.t(z), mreal.t(r));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Mpfr bernoulli(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Bernoulli_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Bernoulli_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Bernoulli_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Mpfr bernpoly(Mpfr x, Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Mpfr bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(mreal.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulernum/*' />
        public static Mpfr eulernum(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Euler_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Euler_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Euler_ui(IntPtr res, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Mpfr eulerpoly(Mpfr x, Int32 n)
        {
            MpfrC res = mflintc.eulerpoly(x, n);
            return res.real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Mpfr eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(mreal.t(x), n);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Mpfr barnes_g(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Mpfr barnes_g(dynamic x)
        {
            return barnes_g(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Mpfr logbarnes_g(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Mpfr logbarnes_g(dynamic x)
        {
            return logbarnes_g(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Mpfr hyperfactorial(Mpfr x)
        {
            MpfrC res = mflintc.hyperfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Mpfr hyperfactorial(dynamic x)
        {
            return hyperfactorial(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Mpfr superfactorial(Mpfr x)
        {
            MpfrC res = mflintc.superfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Mpfr superfactorial(dynamic x)
        {
            return superfactorial(mreal.t(x));
        }








        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Mpfr zeta(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Mpfr zeta(dynamic x)
        {
            return zeta(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Mpfr zetam1(Mpfr x)
        {
            MpfrC res = mflintc.zetam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Mpfr zetam1(dynamic x)
        {
            return zetam1(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Mpfr hardy_theta(Mpfr x)
        {
            MpfrC res = mflintc.hardy_theta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Mpfr hardy_theta(dynamic x)
        {
            return hardy_theta(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Mpfr hardy_z(Mpfr x)
        {
            MpfrC res = mflintc.hardy_z(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Mpfr hardy_z(dynamic x)
        {
            return hardy_z(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Mpfr riemann_xi(Mpfr x)
        {
            MpfrC res = mflintc.riemann_xi(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Mpfr riemann_xi(dynamic x)
        {
            return riemann_xi(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Mpfr dirichlet_eta(Mpfr x)
        {
            MpfrC res = mflintc.dirichlet_eta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Mpfr dirichlet_eta(dynamic x)
        {
            return dirichlet_eta(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Mpfr dirichlet_etam1(Mpfr x)
        {
            MpfrC res = mflintc.dirichlet_etam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Mpfr dirichlet_etam1(dynamic x)
        {
            return dirichlet_etam1(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Mpfr dirichlet_beta(Mpfr x)
        {
            MpfrC res = mflintc.dirichlet_beta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Mpfr dirichlet_beta(dynamic x)
        {
            return dirichlet_beta(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Mpfr dirichlet_lambda(Mpfr x)
        {
            MpfrC res = mflintc.dirichlet_lambda(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Mpfr dirichlet_lambda(dynamic x)
        {
            return dirichlet_lambda(mreal.t(x));
        }





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Mpfr backlund_s(Mpfr x)
        //{
        //    var res = new Mpfr();
        //    Lib_Mpfr_Arb_BacklundS(res.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_BacklundS", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfr_Arb_BacklundS(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Mpfr backlund_s(dynamic x)
        //{
        //    return zeta(mflint.t(x));
        //}





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/grampoint/*' />
        //public static Mpfr grampoint(Int32 n)
        //{
        //    var res = new Mpfr();
        //    Lib_Mpfr_Arb_GramPoint_ui(res.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_GramPoint_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfr_Arb_GramPoint_ui(IntPtr res, Int32 n);







        #endregion



        #region Additional numbertheoretic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bell/*' />
        public static Mpfr bell(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Bell_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Bell_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Bell_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/partitions/*' />
        public static Mpfr partitions(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Partitions_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Partitions_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Partitions_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/primorial/*' />
        public static Mpfr primorial(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Primorial_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Primorial_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Primorial_ui(IntPtr res, Int32 n);





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Mpfr hyperg_0f1(Mpfr a, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Mpfr hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(mflint.t(a), mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Mpfr hyperg_0f1r(Mpfr a, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Mpfr hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(mflint.t(a), mflint.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Mpfr bessel_jv(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Mpfr bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(mreal.t(nu), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Mpfr bessel_yv(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Mpfr bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(mreal.t(nu), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Mpfr bessel_iv(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Mpfr bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(mreal.t(nu), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Mpfr bessel_kv(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Mpfr bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(mreal.t(nu), mreal.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Mpfr bessel_jv_prime(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Mpfr bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(mreal.t(nu), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Mpfr bessel_yv_prime(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Mpfr bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(mreal.t(nu), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Mpfr bessel_iv_prime(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Mpfr bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(mreal.t(nu), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Mpfr bessel_kv_prime(Mpfr nu, Mpfr x, bool scaled = false)
        {
            return aflint.MpfrViaArbS2Bool1(aflint.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Mpfr bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(mreal.t(nu), mreal.t(x), scaled);
        }







        #endregion







        #region 0F1: Spherical Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
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
            return mflintc.sph_bessel_jn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Mpfr sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(mreal.t(n), mreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
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
            return mflintc.sph_bessel_yn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Mpfr sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(mreal.t(n), mreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
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
            return mflintc.sph_bessel_in(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Mpfr sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(mreal.t(n), mreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
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
            return mflintc.sph_bessel_kn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Mpfr sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(mreal.t(n), mreal.t(x), scaled);
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
            return mflintc.sph_bessel_jn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Mpfr sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(mreal.t(n), mreal.t(x), scaled);
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
            return mflintc.sph_bessel_yn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Mpfr sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(mreal.t(n), mreal.t(x), scaled);
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
            return mflintc.sph_bessel_in_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Mpfr sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(mreal.t(n), mreal.t(x), scaled);
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
            return mflintc.sph_bessel_kn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Mpfr sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(mreal.t(n), mreal.t(x), scaled);
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






        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static MpfrC airy_ai(MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS1Bool1(aflintc.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static MpfrC airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static MpfrC airy_ai_prime(MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS1Bool1(aflintc.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static MpfrC airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static MpfrC airy_bi(MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS1Bool1(aflintc.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static MpfrC airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static MpfrC airy_bi_prime(MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS1Bool1(aflintc.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static MpfrC airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(mcplx.t(x), scaled);
        }





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static Mpfr airy_ai(Mpfr x, bool scaled = false)
        //{
        //    return aflint.MpfrViaArbS1Bool1(aflint.airy_ai, x, scaled);
        //}

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static Mpfr airy_ai(dynamic x, bool scaled = false)
        //{
        //    return airy_ai(mreal.t(x), scaled);
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static Mpfr airy_ai_prime(Mpfr x, bool scaled = false)
        //{
        //    return aflint.MpfrViaArbS1Bool1(aflint.airy_ai_prime, x, scaled);
        //}

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static Mpfr airy_ai_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_ai_prime(mreal.t(x), scaled);
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static Mpfr airy_bi(Mpfr x, bool scaled = false)
        //{
        //    return aflint.MpfrViaArbS1Bool1(aflint.airy_bi, x, scaled);
        //}

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static Mpfr airy_bi(dynamic x, bool scaled = false)
        //{
        //    return airy_bi(mreal.t(x), scaled);
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static Mpfr airy_bi_prime(Mpfr x, bool scaled = false)
        //{
        //    return aflint.MpfrViaArbS1Bool1(aflint.airy_bi_prime, x, scaled);
        //}

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static Mpfr airy_bi_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_bi_prime(mreal.t(x), scaled);
        //}





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        public static Mpfr airy_ai_zero(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_AiryAiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_AiryAiZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        public static Mpfr airy_ai_prime_zero(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_AiryAiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_AiryAiPrimeZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        public static Mpfr airy_bi_zero(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_AiryBiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_AiryBiZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        public static Mpfr airy_bi_prime_zero(Int32 n)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_AiryBiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_AiryBiPrimeZero(IntPtr res, Int32 n);



        #endregion




        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Mpfr kelvin_ber(Mpfr v, Mpfr x, bool scaled = false)
        {
            return mflintc.kelvin_ber(mcplx.t(v), mcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Mpfr kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(mreal.t(v), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Mpfr kelvin_bei(Mpfr v, Mpfr x, bool scaled = false)
        {
            return mflintc.kelvin_bei(mcplx.t(v), mcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Mpfr kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(mreal.t(v), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Mpfr kelvin_ker(Mpfr v, Mpfr x, bool scaled = false)
        {
            return mflintc.kelvin_ker(mcplx.t(v), mcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Mpfr kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(mreal.t(v), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Mpfr kelvin_kei(Mpfr v, Mpfr x, bool scaled = false)
        {
            return mflintc.kelvin_kei(mcplx.t(v), mcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Mpfr kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(mreal.t(v), mreal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Mpfr kelvin_ber_prime(Mpfr v, Mpfr x, bool scaled = false)
        {
            return mflintc.kelvin_ber_prime(mcplx.t(v), mcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Mpfr kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(mreal.t(v), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Mpfr kelvin_bei_prime(Mpfr v, Mpfr x, bool scaled = false)
        {
            return mflintc.kelvin_bei_prime(mcplx.t(v), mcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Mpfr kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(mreal.t(v), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Mpfr kelvin_ker_prime(Mpfr v, Mpfr x, bool scaled = false)
        {
            return mflintc.kelvin_ker_prime(mcplx.t(v), mcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Mpfr kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(mreal.t(v), mreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Mpfr kelvin_kei_prime(Mpfr v, Mpfr x, bool scaled = false)
        {
            return mflintc.kelvin_kei_prime(mcplx.t(v), mcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Mpfr kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(mreal.t(v), mreal.t(x), scaled);
        }









        #endregion










        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Mpfr hyperg_1f1(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Mpfr hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(mflint.t(a), mflint.t(b), mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Mpfr hyperg_1f1r(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Mpfr hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(mflint.t(a), mflint.t(b), mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Mpfr hyperg_u(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Mpfr hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(mflint.t(a), mflint.t(b), mflint.t(x));
        }

        public static Mpfr hermite_h(Mpfr n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Mpfr hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(mflint.t(n), mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Mpfr hermite_he(Mpfr n, Mpfr x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Mpfr hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(mreal.t(n), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Mpfr laguerre_l(Mpfr n, Mpfr m, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Mpfr laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(mflint.t(n), mflint.t(m), mflint.t(x));
        }






        #endregion




        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Mpfr gamma_upper(Mpfr s, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Mpfr gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(mflint.t(s), mflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Mpfr gamma_q(Mpfr s, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Mpfr gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(mflint.t(s), mflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Mpfr gamma_lower(Mpfr s, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Mpfr gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(mflint.t(s), mflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Mpfr gamma_p(Mpfr s, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Mpfr gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(mflint.t(s), mflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Mpfr gamma_p_prime(Mpfr s, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Mpfr gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(mflint.t(s), mflint.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Mpfr erf(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Mpfr erf(dynamic x)
        {
            return erf(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Mpfr erfc(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Mpfr erfc(dynamic x)
        {
            return erfc(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Mpfr erf_inv(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Erfinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Erfinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Erfinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Mpfr erf_inv(dynamic x)
        {
            return erf_inv(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Mpfr erfc_inv(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Erfcinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Erfcinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Erfcinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Mpfr erfc_inv(dynamic x)
        {
            return erfc_inv(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Mpfr erfi(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Mpfr erfi(dynamic x)
        {
            return erfi(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Mpfr dawson(Mpfr x)
        {
            return aflint.MRealViaArbS1(aflint.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Mpfr dawson(dynamic x)
        {
            return dawson(mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Mpfr fresnel_s(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Mpfr fresnel_s(dynamic x)
        {
            return fresnel_s(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Mpfr fresnel_c(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Mpfr fresnel_c(dynamic x)
        {
            return fresnel_c(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Mpfr ndens(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Mpfr ndens(dynamic x)
        {
            return ndens(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Mpfr ndis(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Mpfr ndis(dynamic x)
        {
            return ndis(mflint.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Mpfr exp_integral_en(Mpfr s, Mpfr z)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Mpfr exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(mflint.t(s), mflint.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Mpfr exp_integral_e1(Mpfr z)
        {
            if (z < 0) return -exp_integral_ei(-z);
            else return exp_integral_en(mreal.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Mpfr exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(mreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Mpfr exp_integral_ei(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Mpfr exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Mpfr sin_integral(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Mpfr sin_integral(dynamic x)
        {
            return sin_integral(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Mpfr cos_integral(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Mpfr cos_integral(dynamic x)
        {
            return cos_integral(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Mpfr sinh_integral(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Mpfr sinh_integral(dynamic x)
        {
            return sinh_integral(mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Mpfr cosh_integral(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Mpfr cosh_integral(dynamic x)
        {
            return cosh_integral(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Mpfr log_integral(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Mpfr log_integral(dynamic x)
        {
            return log_integral(mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Mpfr log_integral_offset(Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Mpfr log_integral_offset(dynamic x)
        {
            return log_integral_offset(mflint.t(x));
        }



        #endregion





        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Mpfr coulomb_f(Mpfr l, Mpfr eta, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Mpfr coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(mflint.t(l), mflint.t(eta), mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Mpfr coulomb_g(Mpfr l, Mpfr eta, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Mpfr coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(mflint.t(l), mflint.t(eta), mflint.t(x));
        }



        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Mpfr whittaker_m(Mpfr k, Mpfr m, Mpfr x)
        {
            return aflint.MRealViaArbS3(aflint.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Mpfr whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(mreal.t(k), mreal.t(m), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Mpfr whittaker_w(Mpfr k, Mpfr m, Mpfr x)
        {
            return aflint.MRealViaArbS3(aflint.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Mpfr whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(mreal.t(k), mreal.t(m), mreal.t(x));
        }





        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Mpfr pcfd(Mpfr n, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Mpfr pcfd(dynamic n, dynamic x)
        {
            return pcfd(mreal.t(n), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Mpfr pcfu(Mpfr a, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Mpfr pcfu(dynamic a, dynamic x)
        {
            return pcfu(mreal.t(a), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Mpfr pcfv(Mpfr a, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Mpfr pcfv(dynamic a, dynamic x)
        {
            return pcfv(mreal.t(a), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Mpfr pcfw(Mpfr a, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Mpfr pcfw(dynamic a, dynamic x)
        {
            return pcfw(mreal.t(a), mreal.t(x));
        }





        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Mpfr hyperg_2f1(Mpfr a, Mpfr b, Mpfr c, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Mpfr hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(mflint.t(a), mflint.t(b), mflint.t(c), mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Mpfr hyperg_2f1r(Mpfr a, Mpfr b, Mpfr c, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Mpfr hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(mflint.t(a), mflint.t(b), mflint.t(c), mflint.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Mpfr chebyshev_t(Mpfr n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Mpfr chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(mflint.t(n), mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Mpfr chebyshev_u(Mpfr n, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Mpfr chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(mflint.t(n), mflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static Mpfr chebyshev_v(Mpfr n, Mpfr x, bool scaled = false)
        {
            return aflint.MRealViaArbS2(aflint.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Mpfr chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(mreal.t(n), mreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static Mpfr chebyshev_w(Mpfr n, Mpfr x, bool scaled = false)
        {
            return aflint.MRealViaArbS2(aflint.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Mpfr chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(mreal.t(n), mreal.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Mpfr gegenbauer_c(Mpfr n, Mpfr m, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Mpfr gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(mflint.t(n), mflint.t(m), mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Mpfr jacobi_p(Mpfr n, Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Mpfr jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(mflint.t(n), mflint.t(a), mflint.t(b), mflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Mpfr legendre_p(Mpfr n, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.legendre_p, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_p/*' />
        public static Mpfr legendre_p(dynamic n, dynamic y)
        {
            return legendre_p(mreal.t(n), mreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Mpfr legendre_q(Mpfr n, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.legendre_q, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_q/*' />
        public static Mpfr legendre_q(dynamic n, dynamic y)
        {
            return legendre_q(mreal.t(n), mreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Mpfr legendre_plm(Mpfr n, Mpfr m, Mpfr x)
        {
            return aflint.MRealViaArbS3(aflint.legendre_plm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_plm/*' />
        public static Mpfr legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(mreal.t(n), mreal.t(m), mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Mpfr legendre_qlm(Mpfr n, Mpfr m, Mpfr x)
        {
            return aflint.MRealViaArbS3(aflint.legendre_qlm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_qlm/*' />
        public static Mpfr legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(mreal.t(n), mreal.t(m), mreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_plm/*' />
        public static Mpfr toroidal_plm(Mpfr l, Mpfr m, Mpfr x)
        {
            return aflint.MRealViaArbS3(aflint.toroidal_plm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_plm/*' />
        public static Mpfr toroidal_plm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_plm(mreal.t(l), mreal.t(m), mreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_qlm/*' />
        public static Mpfr toroidal_qlm(Mpfr l, Mpfr m, Mpfr x)
        {
            return aflint.MRealViaArbS3(aflint.toroidal_qlm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_qlm/*' />
        public static Mpfr toroidal_qlm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_qlm(mreal.t(l), mreal.t(m), mreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static MpfrC spherical_y(Mpfr n, Mpfr m, Mpfr theta, Mpfr phi)
        {
            return mflintc.spherical_y(mflintc.t(n), mflintc.t(m), mflintc.t(theta), mflintc.t(phi));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static MpfrC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(mflint.t(n), mflint.t(m), mflint.t(theta), mflint.t(phi));
        }








        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Mpfr beta_lower(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Mpfr beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(mflint.t(a), mflint.t(b), mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Mpfr ibeta(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Mpfr ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(mflint.t(a), mflint.t(b), mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Mpfr ibetac(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Mpfr ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(mflint.t(a), mflint.t(b), mflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Mpfr ibeta_prime(Mpfr a, Mpfr b, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Mpfr ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(mflint.t(a), mflint.t(b), mflint.t(x));
        }


        #endregion



        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Mpfr hyperg_1f2(Mpfr a1, Mpfr b1, Mpfr b2, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Mpfr hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(mflint.t(a1), mflint.t(b1), mflint.t(b2), mflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Mpfr hyperg_1f2r(Mpfr a1, Mpfr b1, Mpfr b2, Mpfr x)
        {
            var res = new Mpfr();
            Lib_Mpfr_Arb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfr_Arb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfr_Arb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Mpfr hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(mflint.t(a1), mflint.t(b1), mflint.t(b2), mflint.t(x));
        }





        #endregion



        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Mpfr airy_gi(Mpfr x)
        {
            return aflint.MRealViaArbS1(aflint.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Mpfr airy_gi(dynamic x)
        {
            return airy_gi(mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Mpfr airy_hi(Mpfr x)
        {
            return aflint.MRealViaArbS1(aflint.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Mpfr airy_hi(dynamic x)
        {
            return airy_hi(mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Mpfr airy_gi_prime(Mpfr x)
        {
            return aflint.MRealViaArbS1(aflint.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Mpfr airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Mpfr airy_hi_prime(Mpfr x)
        {
            return aflint.MRealViaArbS1(aflint.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Mpfr airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(mreal.t(x));
        }




        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Mpfr struve_h(Mpfr v, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Mpfr struve_h(dynamic v, dynamic x)
        {
            return struve_h(mreal.t(v), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Mpfr struve_l(Mpfr v, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Mpfr struve_l(dynamic v, dynamic x)
        {
            return struve_l(mreal.t(v), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Mpfr struve_k(Mpfr v, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Mpfr struve_k(dynamic v, dynamic x)
        {
            return struve_k(mreal.t(v), mreal.t(x));
        }


        public static Mpfr struve_m(Mpfr v, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static Mpfr struve_m(dynamic v, dynamic x)
        {
            return struve_m(mreal.t(v), mreal.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Mpfr anger_j(Mpfr v, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Mpfr anger_j(dynamic v, dynamic x)
        {
            return anger_j(mreal.t(v), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Mpfr weber_e(Mpfr v, Mpfr x)
        {
            return aflint.MRealViaArbS2(aflint.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Mpfr weber_e(dynamic v, dynamic x)
        {
            return weber_e(mreal.t(v), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Mpfr lommel_s1(Mpfr mu, Mpfr nu, Mpfr x)
        {
            return aflint.MRealViaArbS3(aflint.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Mpfr lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(mreal.t(mu), mreal.t(nu), mreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Mpfr lommel_s2(Mpfr mu, Mpfr nu, Mpfr x)
        {
            return aflint.MRealViaArbS3(aflint.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Mpfr lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(mreal.t(mu), mreal.t(nu), mreal.t(x));
        }


        #endregion





        #endregion




    }






    public partial class mflintc
    {



        public static String fmt(MpfrC z)
        {
            return mcplx.fmt(z);
        }


        public static String fmt(Mpfr x)
        {
            return mreal.fmt(x);
        }


        public static String fmt(dynamic z)
        {
            return fmt(mcplx.t(z));
        }




        #region Basic Functions




        #region General

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "mflintc"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "mflintc"; }
        }


        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsRealCtx/*' />
        public static bool IsRealCtx
        {
            get { return false; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/IsCplxCtx/*' />
        public static bool IsCplxCtx
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

        ///// <include file="docs.xml" path='docs/members[@name="Contexts"]/Mat/*' />
        //public static mcplxmat Mat
        //{
        //    get { return new mcplxmat(); }
        //}

        ///// <include file="docs.xml" path='docs/members[@name="Contexts"]/Flint/*' />
        //public static mcplxflint Flint
        //{
        //    get { return new mcplxflint(); }
        //}


        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/realctx/*' />
        public static mflint realctx
        {
            get { return new mflint(); }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/CplxCtx/*' />
        public static mflintc CplxCtx
        {
            get { return new mflintc(); }
        }


        #endregion



        #region Conversions




        /// <summary>
        /// Returns a new MpfrC using an extended precision floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Mpfr x)
        {
            return mcplx.t(x);
        }





        /// <summary>
        /// Returns a new MpfrC using an arbitrary precision (both mantissa and exponent) ball number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Arb x)
        {
            return mcplx.t(x);
        }







        /// <summary>
        /// Returns a new Mpfc using an arbitrary precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC T_(Mpfr x)
        {
            return mcplx.t(x);
        }





        /// <summary>
        /// Returns a new MpfrC using a quadruple precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Quadruple x)
        {
            return mcplx.t(x);
        }



        /// <summary>
        /// Returns a new MpfrC using an extended precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Extended x)
        {
            return mcplx.t(x);
        }



        /// <summary>
        /// Returns a new Mpfc using a double precision binary floating point number for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(double x)
        {
            return mcplx.t(x);
        }



        /// <summary>
        /// Returns a new MpfrC using a single precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Single x)
        {
            return mcplx.t(x);
        }



        /// <summary>
        /// Returns a new Mpfc using a signed 32 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Int32 x)
        {
            return mcplx.t(x);
        }


        /// <summary>
        /// Returns a new MpfrC using an unsigned 32 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(UInt32 x)
        {
            return mcplx.t(x);
        }


        /// <summary>
        /// Returns a new MpfrC using a signed 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(Int64 x)
        {
            return mcplx.t(x);
        }


        /// <summary>
        /// Returns a new MpfrC using an unsigned 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(UInt64 x)
        {
            return mcplx.t(x);
        }


        /// <summary>
        /// Returns a new MpfrC using an unsigned 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(BigInteger x)
        {
            return mcplx.t(x);
        }


        /// <summary>
        /// Returns a new MpfrC using a string as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static MpfrC t(string s)
        {
            return mcplx.t(s);
        }



        /// <summary>
        /// Returns a new MpfrC using 2 Mpfr as input for the real and imaginary part
        /// </summary>
        public static MpfrC t(Mpfr re, Mpfr im)
        {
            return mcplx.t(re, im);
        }



        /// <summary>
        /// Returns a new MpfrC using a complex arbitrary (both mantissa and exponent) precision ball number as input
        /// </summary>
        public static MpfrC t(ArbC z)
        {
            return mcplx.t(z);
        }






        /// <summary>
        /// Returns a new Mpfc using a complex arbitrary precision binary floating point number as input
        /// </summary>
        public static MpfrC t(MpfrC z)
        {
            return mcplx.t(z);
        }





        /// <summary>
        /// Returns a new MpfrC using a complex quadruple precision binary floating point number as input
        /// </summary>
        public static MpfrC t(QuadrupleC z)
        {
            return mcplx.t(z);
        }



        /// <summary>
        /// Returns a new MpfrC using a complex extended precision binary floating point number as input
        /// </summary>
        public static MpfrC t(ExtendedC z)
        {
            return mcplx.t(z);
        }



        /// <summary>
        /// Returns a new Mpfc using a complex double precision binary floating point number (System.Complex) as input
        /// </summary>
        public static MpfrC t(Complex z)
        {
            return mcplx.t(z);
        }





        /// <summary>
        /// Returns a new MpfrC using a complex single precision binary floating point number as input
        /// </summary>
        public static MpfrC t(SingleC z)
        {
            return mcplx.t(z);
        }



        /// <summary>
        /// Returns a new Mpfc using 2 double as input for the real and imaginary part
        /// </summary>
        public static MpfrC t(Double d_re, Double d_im)
        {
            return mcplx.t(d_re, d_im);
        }


        /// <summary>
        /// Returns a new MpfrC using 2 strings as input for the real and imaginary part
        /// </summary>
        public static MpfrC t(string s_re, string s_im)
        {
            return mcplx.t(s_re, s_im);
        }


        /// <summary>
        /// Returns a new MpfrC using a general object as input
        /// </summary>
        public static MpfrC t(dynamic z)
        {
            return mcplx.t(z);
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



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/Onei/*' />
        //public static MpfrC Onei()
        //{
        //    return mflintc.t(0, 1);
        //}


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static MpfrC nan()
        {
            return mflintc.t(mflint.nan(), mflint.nan());
        }




        #endregion



        #region Complex components


        public static Mpfr abs(MpfrC z)
        {
            return mcplx.abs(z);
        }


        public static Mpfr abs(dynamic z)
        {
            return mcplx.abs(t(z));
        }


        public static Mpfr fabs(MpfrC z)
        {
            return mcplx.fabs(z);
        }


        public static Mpfr fabs(dynamic z)
        {
            return mcplx.fabs(t(z));
        }


        public static MpfrC sign(MpfrC z)
        {
            return mcplx.sign(z);
        }


        public static MpfrC sign(dynamic z)
        {
            return mcplx.sign(t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Mpfr real(MpfrC z)
        {
            return z.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Mpfr real(dynamic z)
        {
            return real(t(z));
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



        public static Mpfr phase(MpfrC z)
        {
            return mcplx.phase(z);
        }


        public static Mpfr phase(dynamic z)
        {
            return mcplx.phase(t(z));
        }


        public static MpfrC conj(MpfrC z)
        {
            return mcplx.conj(z);
        }


        public static MpfrC conj(dynamic z)
        {
            return mcplx.conj(t(z));
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
            return cbrt(mflintc.t(x));
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
            return cbrt(mflintc.t(x));
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
            return root_si(mcplx.t(x), n);
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


        public static Tuple<MpfrC, MpfrC, MpfrC> cubic_equation(MpfrC A, MpfrC B, MpfrC C, MpfrC D)
        {
            return cubic_equation_monic(B / A, C / A, D / A);
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
            Lib_Mpfc_Acb_Pow_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Pow_si(IntPtr res, IntPtr x, Int32 n);


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




        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static MpfrC gamma(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static MpfrC gamma(dynamic x)
        {
            return gamma(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static MpfrC rgamma(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static MpfrC rgamma(dynamic x)
        {
            return rgamma(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static MpfrC lgamma(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static MpfrC lgamma(dynamic x)
        {
            return lgamma(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static MpfrC rising_factorial(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static MpfrC rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(mflintc.t(x), mflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static MpfrC beta(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static MpfrC beta(dynamic x, dynamic y)
        {
            return beta(mflintc.t(x), mflintc.t(y));
        }








        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static MpfrC gamma1pm1(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static MpfrC gamma1pm1(dynamic x)
        {
            return gamma1pm1(mcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static MpfrC factorial(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static MpfrC factorial(dynamic x)
        {
            return factorial(mcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static MpfrC doublefactorial(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static MpfrC doublefactorial(dynamic x)
        {
            return doublefactorial(mcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static MpfrC falling_factorial(MpfrC a, MpfrC n)
        {
            return aflintc.MCplxViaArbCS2(aflintc.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static MpfrC falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(mcplx.t(a), mcplx.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static MpfrC gamma_ratio(MpfrC a, MpfrC b)
        {
            return aflintc.MCplxViaArbCS2(aflintc.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static MpfrC gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(mcplx.t(a), mcplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static MpfrC gamma_delta_ratio(MpfrC a, MpfrC delta)
        {
            return aflintc.MCplxViaArbCS2(aflintc.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static MpfrC gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(mcplx.t(a), mcplx.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static MpfrC binomial(MpfrC n, MpfrC k)
        {
            return aflintc.MCplxViaArbCS2(aflintc.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static MpfrC binomial(dynamic n, dynamic k)
        {
            return binomial(mcplx.t(n), mcplx.t(k));
        }










        #endregion



        #region Miscellaneous



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




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static MpfrC lambert_w0(MpfrC x)
        {
            return lambert_wk(mflintc.t(x), 0);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static MpfrC lambert_w0(dynamic x)
        {
            return lambert_w0(mflintc.t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static MpfrC lambert_wm1(MpfrC x)
        {
            return lambert_wk(mflintc.t(x), -1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static MpfrC lambert_wm1(dynamic x)
        {
            return lambert_wm1(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static MpfrC agm(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static MpfrC agm(dynamic x, dynamic y)
        {
            return agm(mflintc.t(x), mflintc.t(y));
        }






        #endregion






        #endregion





        #region Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static MpfrC m_elliptic_k(MpfrC m)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static MpfrC m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static MpfrC m_elliptic_e(MpfrC m)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static MpfrC m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static MpfrC m_elliptic_pi(MpfrC n, MpfrC m)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static MpfrC m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(mflintc.t(x), mflintc.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static MpfrC m_elliptic_f(MpfrC phi, MpfrC m)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static MpfrC m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(mflintc.t(phi), mflintc.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static MpfrC m_elliptic_e_inc(MpfrC phi, MpfrC m)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static MpfrC m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(mflintc.t(phi), mflintc.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static MpfrC m_elliptic_pi_inc(MpfrC n, MpfrC phi, MpfrC m)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static MpfrC m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(mflintc.t(n), mflintc.t(phi), mflintc.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static MpfrC elliptic_k(MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static MpfrC elliptic_k(dynamic k)
        {
            return elliptic_k(mflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static MpfrC elliptic_e(MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static MpfrC elliptic_e(dynamic k)
        {
            return elliptic_e(mflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static MpfrC elliptic_pi(MpfrC n, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static MpfrC elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(mflintc.t(n), mflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static MpfrC elliptic_f(MpfrC phi, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static MpfrC elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(mflintc.t(phi), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static MpfrC elliptic_e_inc(MpfrC phi, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static MpfrC elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(mflintc.t(phi), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static MpfrC elliptic_pi_inc(MpfrC n, MpfrC phi, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static MpfrC elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(mflintc.t(n), mflintc.t(phi), mflintc.t(k));
        }




        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static MpfrC elliptic_rc(MpfrC x, MpfrC y)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static MpfrC elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(mflintc.t(x), mflintc.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static MpfrC elliptic_rf(MpfrC x, MpfrC y, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static MpfrC elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(mflintc.t(x), mflintc.t(y), mflintc.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static MpfrC elliptic_rg(MpfrC x, MpfrC y, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static MpfrC elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(mflintc.t(x), mflintc.t(y), mflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static MpfrC elliptic_rd(MpfrC x, MpfrC y, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static MpfrC elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(mflintc.t(x), mflintc.t(y), mflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static MpfrC elliptic_rj(MpfrC x, MpfrC y, MpfrC z, MpfrC w)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static MpfrC elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(mflintc.t(x), mflintc.t(y), mflintc.t(z), mflintc.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static MpfrC jacobi_theta1(MpfrC x, MpfrC q)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static MpfrC jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(mflintc.t(x), mflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static MpfrC jacobi_theta2(MpfrC x, MpfrC q)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static MpfrC jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(mflintc.t(x), mflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static MpfrC jacobi_theta3(MpfrC x, MpfrC q)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static MpfrC jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(mflintc.t(x), mflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static MpfrC jacobi_theta4(MpfrC x, MpfrC q)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static MpfrC jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(mflintc.t(x), mflintc.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static MpfrC JacobiTheta1Tau(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Theta1QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Theta1QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Theta1QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static MpfrC JacobiTheta1Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta1Tau(mflintc.t(z), mflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static MpfrC JacobiTheta2Tau(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Theta2QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Theta2QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Theta2QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static MpfrC JacobiTheta2Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta2Tau(mflintc.t(z), mflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static MpfrC JacobiTheta3Tau(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Theta3QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Theta3QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Theta3QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static MpfrC JacobiTheta3Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta3Tau(mflintc.t(z), mflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static MpfrC JacobiTheta4Tau(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Theta4QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Theta4QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_Theta4QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static MpfrC JacobiTheta4Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta4Tau(mflintc.t(z), mflintc.t(tau));
        }






        #endregion



        #region Jacobi elliptic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static MpfrC QfromK(MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_QfromK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_QfromK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_QfromK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static MpfrC QfromK(dynamic k)
        {
            return QfromK(mflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static MpfrC TfromUQ(MpfrC u, MpfrC q)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_TfromUQ(res.mpPtr, u.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_TfromUQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_TfromUQ(IntPtr res, IntPtr u, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static MpfrC TfromUQ(dynamic n, dynamic k)
        {
            return TfromUQ(mflintc.t(n), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static MpfrC SnTQ(MpfrC t, MpfrC q)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_SnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_SnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_SnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static MpfrC SnTQ(dynamic t, dynamic q)
        {
            return SnTQ(mflintc.t(t), mflintc.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static MpfrC CnTQ(MpfrC t, MpfrC q)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_CnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static MpfrC CnTQ(dynamic t, dynamic q)
        {
            return CnTQ(mflintc.t(t), mflintc.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static MpfrC DnTQ(MpfrC t, MpfrC q)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_DnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_DnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_DnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static MpfrC DnTQ(dynamic t, dynamic q)
        {
            return DnTQ(mflintc.t(t), mflintc.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static MpfrC jacobi_sn(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static MpfrC jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static MpfrC jacobi_cn(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static MpfrC jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static MpfrC jacobi_dn(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static MpfrC jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static MpfrC jacobi_ns(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static MpfrC jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static MpfrC jacobi_nc(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static MpfrC jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static MpfrC jacobi_nd(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static MpfrC jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static MpfrC jacobi_sc(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static MpfrC jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static MpfrC jacobi_sd(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static MpfrC jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static MpfrC jacobi_dc(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static MpfrC jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static MpfrC jacobi_ds(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static MpfrC jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static MpfrC jacobi_cs(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static MpfrC jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(mflintc.t(x), mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static MpfrC jacobi_cd(MpfrC x, MpfrC k)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static MpfrC jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(mflintc.t(x), mflintc.t(k));
        }




        #endregion





        #region Conversions of parameters of Weierstrass P


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<MpfrC, MpfrC> elliptic_invariants_from_roots(MpfrC e1, MpfrC e2)
        {
            MpfrC e3 = -e1 - e2;
            MpfrC g2 = 2 * (e1 * e1 + e2 * e2 + e3 * e3);
            MpfrC g3 = 4 * e1 * e2 * e3;
            return new Tuple<MpfrC, MpfrC>(g2, g3);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<MpfrC, MpfrC> elliptic_invariants_from_roots(dynamic e1, dynamic e2)
        {
            return elliptic_invariants_from_roots(mflintc.t(e1), mflintc.t(e2));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<MpfrC, MpfrC> elliptic_invariants_from_tau(MpfrC tau)
        {
            return new Tuple<MpfrC, MpfrC>(EllipticInvariantG2(tau), EllipticInvariantG3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<MpfrC, MpfrC> elliptic_invariants_from_tau(dynamic tau)
        {
            return elliptic_invariants_from_tau(mflintc.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<MpfrC, MpfrC, MpfrC> elliptic_roots_from_tau(MpfrC tau)
        {
            return new Tuple<MpfrC, MpfrC, MpfrC>(EllipticRootE1(tau), EllipticRootE2(tau), EllipticRootE3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<MpfrC, MpfrC, MpfrC> elliptic_roots_from_tau(dynamic tau)
        {
            return elliptic_roots_from_tau(mflintc.t(tau));
        }



        #endregion





        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static MpfrC weierstrass_p_t(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_WeierstrassP(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_WeierstrassP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_WeierstrassP(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static MpfrC weierstrass_p_t(dynamic z, dynamic tau)
        {
            return weierstrass_p_t(mflintc.t(z), mflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static MpfrC WeierstrassPInv(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_WeierstrassPInv(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_WeierstrassPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_WeierstrassPInv(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static MpfrC WeierstrassPInv(dynamic z, dynamic tau)
        {
            return WeierstrassPInv(mflintc.t(z), mflintc.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static MpfrC weierstrass_zeta_t(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_WeierstrassPZeta(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_WeierstrassPZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_WeierstrassPZeta(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static MpfrC weierstrass_zeta_t(dynamic z, dynamic tau)
        {
            return weierstrass_zeta_t(mflintc.t(z), mflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static MpfrC weierstrass_sigma_t(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_WeierstrassPSigma(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_WeierstrassPSigma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_WeierstrassPSigma(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static MpfrC weierstrass_sigma_t(dynamic z, dynamic tau)
        {
            return weierstrass_sigma_t(mflintc.t(z), mflintc.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static MpfrC weierstrass_pprime_t(MpfrC z, MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_WeierstrassPPrime(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_WeierstrassPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_WeierstrassPPrime(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static MpfrC weierstrass_pprime_t(dynamic z, dynamic tau)
        {
            return weierstrass_pprime_t(mflintc.t(z), mflintc.t(tau));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static MpfrC EllipticInvariantG2(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticInvariantG2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticInvariantG2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticInvariantG2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static MpfrC EllipticInvariantG2(dynamic k)
        {
            return EllipticInvariantG2(mflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static MpfrC EllipticInvariantG3(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticInvariantG3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticInvariantG3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticInvariantG3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static MpfrC EllipticInvariantG3(dynamic k)
        {
            return EllipticInvariantG3(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static MpfrC EllipticRootE1(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticRootE1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticRootE1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticRootE1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static MpfrC EllipticRootE1(dynamic k)
        {
            return EllipticRootE1(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static MpfrC EllipticRootE2(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticRootE2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticRootE2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticRootE2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static MpfrC EllipticRootE2(dynamic k)
        {
            return EllipticRootE2(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static MpfrC EllipticRootE3(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EllipticRootE3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EllipticRootE3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_EllipticRootE3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static MpfrC EllipticRootE3(dynamic k)
        {
            return EllipticRootE3(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static MpfrC dedekind_eta(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_DedekindEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_DedekindEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_DedekindEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static MpfrC dedekind_eta(dynamic k)
        {
            return dedekind_eta(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static MpfrC klein_j(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_KleinJ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_KleinJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_KleinJ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static MpfrC klein_j(dynamic k)
        {
            return klein_j(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static MpfrC modular_lambda(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ModularLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ModularLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_ModularLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static MpfrC modular_lambda(dynamic k)
        {
            return modular_lambda(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static MpfrC modular_delta(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ModularDelta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ModularDelta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_ModularDelta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static MpfrC modular_delta(dynamic k)
        {
            return modular_delta(mflintc.t(k));
        }



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static MpfrC lerch_phi(MpfrC s, MpfrC z, MpfrC a)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static MpfrC lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(mflintc.t(s), mflintc.t(z), mflintc.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static MpfrC lerch_zeta(MpfrC lambda1, MpfrC alpha, MpfrC s)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_LerchZeta(res.mpPtr, lambda1.mpPtr, alpha.mpPtr, s.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LerchZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_LerchZeta(IntPtr res, IntPtr lambda1, IntPtr alpha, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static MpfrC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(mflintc.t(lambda1), mflintc.t(alpha), mflintc.t(s));
        }




        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static MpfrC polygamma(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static MpfrC polygamma(dynamic s, dynamic z)
        {
            return polygamma(mflintc.t(s), mflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static MpfrC trigamma(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Trigamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Trigamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static MpfrC trigamma(dynamic x)
        {
            return trigamma(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static MpfrC digamma(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static MpfrC digamma(dynamic x)
        {
            return digamma(mflintc.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static MpfrC polylog(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static MpfrC polylog(dynamic s, dynamic z)
        {
            return polylog(mflintc.t(s), mflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static MpfrC trilog(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Trilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Trilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Trilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static MpfrC trilog(dynamic x)
        {
            return trilog(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static MpfrC dilog(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static MpfrC dilog(dynamic x)
        {
            return dilog(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static MpfrC clausen_sin(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ClausenSin(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ClausenSin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_ClausenSin(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static MpfrC clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(mflintc.t(s), mflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static MpfrC clausen_cos(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ClausenCos(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ClausenCos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_ClausenCos(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static MpfrC clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(mflintc.t(s), mflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static MpfrC clausen2(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Clausen2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Clausen2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Clausen2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static MpfrC clausen2(dynamic x)
        {
            return clausen2(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static MpfrC bose_einstein(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_BoseEinstein(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_BoseEinstein", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_BoseEinstein(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static MpfrC bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(mflintc.t(s), mflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static MpfrC fermi_dirac(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_FermiDirac(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_FermiDirac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_FermiDirac(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static MpfrC fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(mflintc.t(s), mflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static MpfrC legendre_chi(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_LegendreChi(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LegendreChi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_LegendreChi(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static MpfrC legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(mflintc.t(s), mflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static MpfrC inverse_tan_integral(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_InverseTanIntegral(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_InverseTanIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_InverseTanIntegral(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static MpfrC inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(mflintc.t(s), mflintc.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static MpfrC hurwitz_zeta(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_HurwitzZeta(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static MpfrC hurwitz_zeta(dynamic s, dynamic z)
        {
            return hurwitz_zeta(mflintc.t(s), mflintc.t(z));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/stieltjes/*' />
        //public static MpfrC stieltjes(MpfrC x, Int32 n)
        //{
        //    var res = new MpfrC();
        //    Lib_Mpfc_Acb_Stieltjes_ui(res.mpPtr, x.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Stieltjes_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfc_Acb_Stieltjes_ui(IntPtr res, IntPtr x, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static MpfrC bernpoly(MpfrC x, Int32 n)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static MpfrC bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(mflintc.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static MpfrC eulerpoly(MpfrC x, Int32 n)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_EulerPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_EulerPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_EulerPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static MpfrC eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(mflintc.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static MpfrC harmonic(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Harmonic(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Harmonic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Harmonic(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static MpfrC harmonic(dynamic x)
        {
            return harmonic(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static MpfrC harmonic2(MpfrC z, MpfrC r)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Harmonic2(res.mpPtr, z.mpPtr, r.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Harmonic2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Harmonic2(IntPtr res, IntPtr z, IntPtr r);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static MpfrC harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(mflintc.t(z), mflintc.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static MpfrC barnes_g(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static MpfrC barnes_g(dynamic x)
        {
            return barnes_g(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static MpfrC logbarnes_g(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static MpfrC logbarnes_g(dynamic x)
        {
            return logbarnes_g(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static MpfrC hyperfactorial(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hyperfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hyperfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hyperfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static MpfrC hyperfactorial(dynamic x)
        {
            return hyperfactorial(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static MpfrC superfactorial(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Superfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Superfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Superfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static MpfrC superfactorial(dynamic x)
        {
            return superfactorial(mflintc.t(x));
        }




        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static MpfrC zeta(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static MpfrC zeta(dynamic x)
        {
            return zeta(mflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static MpfrC zetam1(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Zetam1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Zetam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Zetam1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static MpfrC zetam1(dynamic x)
        {
            return zetam1(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static MpfrC riemann_xi(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_DirichletXi(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_DirichletXi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_DirichletXi(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static MpfrC riemann_xi(dynamic k)
        {
            return riemann_xi(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static MpfrC dirichlet_eta(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_DirichletEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_DirichletEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_DirichletEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static MpfrC dirichlet_eta(dynamic k)
        {
            return dirichlet_eta(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static MpfrC dirichlet_etam1(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_DirichletEtam1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_DirichletEtam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_DirichletEtam1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static MpfrC dirichlet_etam1(dynamic k)
        {
            return dirichlet_etam1(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static MpfrC dirichlet_beta(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_DirichletBeta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_DirichletBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_DirichletBeta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static MpfrC dirichlet_beta(dynamic k)
        {
            return dirichlet_beta(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static MpfrC dirichlet_lambda(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_DirichletLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_DirichletLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_DirichletLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static MpfrC dirichlet_lambda(dynamic k)
        {
            return dirichlet_lambda(mflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static MpfrC hardy_z(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_HardyZ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_HardyZ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_HardyZ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static MpfrC hardy_z(dynamic k)
        {
            return hardy_z(mflintc.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static MpfrC hardy_theta(MpfrC tau)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_HardyTheta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_HardyTheta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpfc_Acb_HardyTheta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static MpfrC hardy_theta(dynamic k)
        {
            return hardy_theta(mflintc.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta_zero/*' />
        public static MpfrC zeta_zero(Int32 n)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ZetaZero_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ZetaZero_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_ZetaZero_ui(IntPtr res, Int32 n);



        #endregion



        #region Additional numbertheoretic functions





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static MpfrC hyperg_0f1(MpfrC a, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static MpfrC hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(mflintc.t(a), mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static MpfrC hyperg_0f1r(MpfrC a, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static MpfrC hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(mflintc.t(a), mflintc.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static MpfrC bessel_jv(MpfrC nu, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static MpfrC bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(mcplx.t(nu), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static MpfrC bessel_yv(MpfrC nu, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static MpfrC bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(mcplx.t(nu), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static MpfrC bessel_iv(MpfrC nu, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static MpfrC bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(mcplx.t(nu), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static MpfrC bessel_kv(MpfrC nu, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static MpfrC bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(mcplx.t(nu), mcplx.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static MpfrC bessel_jv_prime(MpfrC nu, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static MpfrC bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(mcplx.t(nu), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static MpfrC bessel_yv_prime(MpfrC nu, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static MpfrC bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(mcplx.t(nu), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static MpfrC bessel_iv_prime(MpfrC nu, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static MpfrC bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(mcplx.t(nu), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static MpfrC bessel_kv_prime(MpfrC nu, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static MpfrC bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(mcplx.t(nu), mcplx.t(x), scaled);
        }









        #endregion








        #region 0F1: Spherical Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static MpfrC sph_bessel_jn(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_bessel_jn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static MpfrC sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(mcplx.t(n), mcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static MpfrC sph_bessel_yn(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_bessel_yn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static MpfrC sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(mcplx.t(n), mcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static MpfrC sph_bessel_in(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_bessel_in, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static MpfrC sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(mcplx.t(n), mcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static MpfrC sph_bessel_kn(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_bessel_kn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static MpfrC sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(mcplx.t(n), mcplx.t(x), scaled);
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static MpfrC besselpoly(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.besselpoly, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static MpfrC besselpoly(dynamic n, dynamic x, bool scaled = false)
        {
            return besselpoly(mcplx.t(n), mcplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static MpfrC besseltheta(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.besseltheta, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static MpfrC besseltheta(dynamic n, dynamic x, bool scaled = false)
        {
            return besseltheta(mcplx.t(n), mcplx.t(x), scaled);
        }









        #endregion



        #region 0F1: Spherical Bessel functions, first derivative


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static MpfrC sph_bessel_jn_prime(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_bessel_jn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static MpfrC sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(mcplx.t(n), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static MpfrC sph_bessel_yn_prime(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_bessel_yn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static MpfrC sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(mcplx.t(n), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static MpfrC sph_bessel_in_prime(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_bessel_in_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static MpfrC sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(mcplx.t(n), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static MpfrC sph_bessel_kn_prime(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_bessel_kn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static MpfrC sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(mcplx.t(n), mcplx.t(x), scaled);
        }



        #endregion








        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static MpfrC hankel_h1(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.hankel_h1, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static MpfrC hankel_h1(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h1(mcplx.t(v), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static MpfrC hankel_h2(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.hankel_h2, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static MpfrC hankel_h2(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h2(mcplx.t(v), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static MpfrC sph_hankel_h1(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_hankel_h1, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static MpfrC sph_hankel_h1(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h1(mcplx.t(n), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static MpfrC sph_hankel_h2(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.sph_hankel_h2, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static MpfrC sph_hankel_h2(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h2(mcplx.t(n), mcplx.t(x), scaled);
        }





        #endregion








        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static MpfrC airy_ai(MpfrC x, bool scaled = false)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_AiryAi(res.mpPtr, x.mpPtr);
            if (scaled) res *= exp((mreal.t(2) / mreal.t(3)) * x * sqrt(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_AiryAi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static MpfrC airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(mflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static MpfrC airy_ai_prime(MpfrC x, bool scaled = false)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_AiryAiPrime(res.mpPtr, x.mpPtr);
            if (scaled) res *= exp((mreal.t(2) / mreal.t(3)) * x * sqrt(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_AiryAiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static MpfrC airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(mflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static MpfrC airy_bi(MpfrC x, bool scaled = false)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_AiryBi(res.mpPtr, x.mpPtr);
            if (scaled) res *= exp(-abs(mreal.t(2) / mreal.t(3) * (x * sqrt(x)).real));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_AiryBi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static MpfrC airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(mflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static MpfrC airy_bi_prime(MpfrC x, bool scaled = false)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_AiryBiPrime(res.mpPtr, x.mpPtr);
            if (scaled) res *= exp(-abs(mreal.t(2) / mreal.t(3) * (x * sqrt(x)).real));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_AiryBiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static MpfrC airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(mflintc.t(x), scaled);
        }



        #endregion



        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static MpfrC kelvin_ber(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.kelvin_ber, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static MpfrC kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(mcplx.t(v), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static MpfrC kelvin_bei(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.kelvin_bei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static MpfrC kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(mcplx.t(v), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static MpfrC kelvin_ker(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.kelvin_ker, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static MpfrC kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(mcplx.t(v), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static MpfrC kelvin_kei(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.kelvin_kei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static MpfrC kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(mcplx.t(v), mcplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static MpfrC kelvin_ber_prime(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.kelvin_ber_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static MpfrC kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(mcplx.t(v), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static MpfrC kelvin_bei_prime(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.kelvin_bei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static MpfrC kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(mcplx.t(v), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static MpfrC kelvin_ker_prime(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.kelvin_ker_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static MpfrC kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(mcplx.t(v), mcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static MpfrC kelvin_kei_prime(MpfrC v, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2Bool1(aflintc.kelvin_kei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static MpfrC kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(mcplx.t(v), mcplx.t(x), scaled);
        }







        #endregion










        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static MpfrC hyperg_1f1(MpfrC a, MpfrC b, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static MpfrC hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(mflintc.t(a), mflintc.t(b), mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static MpfrC hyperg_1f1r(MpfrC a, MpfrC b, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static MpfrC hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(mflintc.t(a), mflintc.t(b), mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static MpfrC hyperg_u(MpfrC a, MpfrC b, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static MpfrC hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(mflintc.t(a), mflintc.t(b), mflintc.t(x));
        }





        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static MpfrC gamma_upper(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static MpfrC gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(mflintc.t(s), mflintc.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static MpfrC gamma_q(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static MpfrC gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(mflintc.t(s), mflintc.t(z));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static MpfrC gamma_lower(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static MpfrC gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(mflintc.t(s), mflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static MpfrC gamma_p(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static MpfrC gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(mflintc.t(s), mflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static MpfrC gamma_p_prime(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static MpfrC gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(mflintc.t(s), mflintc.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static MpfrC erf(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static MpfrC erf(dynamic x)
        {
            return erf(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static MpfrC erfc(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static MpfrC erfc(dynamic x)
        {
            return erfc(mflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static MpfrC erfi(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static MpfrC erfi(dynamic x)
        {
            return erfi(mflintc.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static MpfrC dawson(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static MpfrC dawson(dynamic x)
        {
            return dawson(mcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static MpfrC faddeeva(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.faddeeva, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static MpfrC faddeeva(dynamic x)
        {
            return faddeeva(mcplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static MpfrC fresnel_s(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static MpfrC fresnel_s(dynamic x)
        {
            return fresnel_s(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static MpfrC fresnel_c(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static MpfrC fresnel_c(dynamic x)
        {
            return fresnel_c(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static MpfrC ndens(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static MpfrC ndens(dynamic x)
        {
            return ndens(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static MpfrC ndis(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static MpfrC ndis(dynamic x)
        {
            return ndis(mflintc.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static MpfrC exp_integral_en(MpfrC s, MpfrC z)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static MpfrC exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(mflintc.t(s), mflintc.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static MpfrC exp_integral_e1(MpfrC z)
        {
            return exp_integral_en(mcplx.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static MpfrC exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(mcplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static MpfrC exp_integral_ei(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static MpfrC exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static MpfrC sin_integral(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static MpfrC sin_integral(dynamic x)
        {
            return sin_integral(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static MpfrC cos_integral(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static MpfrC cos_integral(dynamic x)
        {
            return cos_integral(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static MpfrC sinh_integral(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static MpfrC sinh_integral(dynamic x)
        {
            return sinh_integral(mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static MpfrC cosh_integral(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static MpfrC cosh_integral(dynamic x)
        {
            return cosh_integral(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static MpfrC log_integral(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static MpfrC log_integral(dynamic x)
        {
            return log_integral(mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static MpfrC log_integral_offset(MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static MpfrC log_integral_offset(dynamic x)
        {
            return log_integral_offset(mflintc.t(x));
        }



        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static MpfrC hermite_h(MpfrC n, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static MpfrC hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(mflintc.t(n), mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static MpfrC hermite_he(MpfrC n, MpfrC x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static MpfrC hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(mcplx.t(n), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static MpfrC laguerre_l(MpfrC n, MpfrC m, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static MpfrC laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(mflintc.t(n), mflintc.t(m), mflintc.t(x));
        }



        #endregion



        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static MpfrC coulomb_f(MpfrC l, MpfrC eta, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static MpfrC coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(mflintc.t(l), mflintc.t(eta), mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static MpfrC coulomb_g(MpfrC l, MpfrC eta, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static MpfrC coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(mflintc.t(l), mflintc.t(eta), mflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static MpfrC coulomb_hpos(MpfrC l, MpfrC eta, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CoulombHpos(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CoulombHpos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CoulombHpos(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static MpfrC coulomb_hpos(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hpos(mflintc.t(l), mflintc.t(eta), mflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static MpfrC coulomb_hneg(MpfrC l, MpfrC eta, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_CoulombHneg(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_CoulombHneg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_CoulombHneg(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static MpfrC coulomb_hneg(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hneg(mflintc.t(l), mflintc.t(eta), mflintc.t(x));
        }





        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static MpfrC whittaker_m(MpfrC k, MpfrC m, MpfrC x)
        {
            return aflintc.MCplxViaArbCS3(aflintc.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static MpfrC whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(mcplx.t(k), mcplx.t(m), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static MpfrC whittaker_w(MpfrC k, MpfrC m, MpfrC x)
        {
            return aflintc.MCplxViaArbCS3(aflintc.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static MpfrC whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(mcplx.t(k), mcplx.t(m), mcplx.t(x));
        }






        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static MpfrC pcfd(MpfrC n, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static MpfrC pcfd(dynamic n, dynamic x)
        {
            return pcfd(mcplx.t(n), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static MpfrC pcfu(MpfrC a, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static MpfrC pcfu(dynamic a, dynamic x)
        {
            return pcfu(mcplx.t(a), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static MpfrC pcfv(MpfrC a, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static MpfrC pcfv(dynamic a, dynamic x)
        {
            return pcfv(mcplx.t(a), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static MpfrC pcfw(MpfrC a, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static MpfrC pcfw(dynamic a, dynamic x)
        {
            return pcfw(mcplx.t(a), mcplx.t(x));
        }




        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static MpfrC hyperg_2f1(MpfrC a, MpfrC b, MpfrC c, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static MpfrC hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(mflintc.t(a), mflintc.t(b), mflintc.t(c), mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static MpfrC hyperg_2f1r(MpfrC a, MpfrC b, MpfrC c, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static MpfrC hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(mflintc.t(a), mflintc.t(b), mflintc.t(c), mflintc.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static MpfrC chebyshev_t(MpfrC n, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static MpfrC chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(mflintc.t(n), mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static MpfrC chebyshev_u(MpfrC n, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static MpfrC chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(mflintc.t(n), mflintc.t(x));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static MpfrC chebyshev_v(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2(aflintc.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static MpfrC chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(mcplx.t(n), mcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static MpfrC chebyshev_w(MpfrC n, MpfrC x, bool scaled = false)
        {
            return aflintc.MCplxViaArbCS2(aflintc.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static MpfrC chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(mcplx.t(n), mcplx.t(y));
        }











        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static MpfrC gegenbauer_c(MpfrC n, MpfrC m, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static MpfrC gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(mflintc.t(n), mflintc.t(m), mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static MpfrC jacobi_p(MpfrC n, MpfrC a, MpfrC b, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static MpfrC jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(mflintc.t(n), mflintc.t(a), mflintc.t(b), mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static MpfrC legendre_p(MpfrC n, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.legendre_p, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static MpfrC legendre_p(dynamic n, dynamic x)
        {
            return legendre_p(mcplx.t(n), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static MpfrC legendre_q(MpfrC n, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.legendre_q, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static MpfrC legendre_q(dynamic n, dynamic x)
        {
            return legendre_q(mcplx.t(n), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static MpfrC legendre_plm(MpfrC n, MpfrC m, MpfrC x, int type = 1)
        {
            return aflintc.MCplxViaArbCS3Int1(aflintc.legendre_plm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static MpfrC legendre_plm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_plm(mcplx.t(n), mcplx.t(m), mcplx.t(x), type);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static MpfrC legendre_qlm(MpfrC n, MpfrC m, MpfrC x, int type = 1)
        {
            return aflintc.MCplxViaArbCS3Int1(aflintc.legendre_qlm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static MpfrC legendre_qlm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_qlm(mcplx.t(n), mcplx.t(m), mcplx.t(x), type);
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static MpfrC legendre_p(MpfrC n, MpfrC m, MpfrC x)
        //{
        //    var res = new MpfrC();
        //    Lib_Mpfc_Acb_LegendreP(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfc_Acb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static MpfrC legendre_p(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_p(mflintc.t(n), mflintc.t(m), mflintc.t(x));
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static MpfrC legendre_plm(MpfrC n, MpfrC m, MpfrC x)
        //{
        //    var res = new MpfrC();
        //    Lib_Mpfc_Acb_LegendrePv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfc_Acb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static MpfrC legendre_plm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_plm(mflintc.t(n), mflintc.t(m), mflintc.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static MpfrC legendre_q(MpfrC n, MpfrC m, MpfrC x)
        //{
        //    var res = new MpfrC();
        //    Lib_Mpfc_Acb_LegendreQ(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfc_Acb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static MpfrC legendre_q(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_q(mflintc.t(n), mflintc.t(m), mflintc.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static MpfrC legendre_qlm(MpfrC n, MpfrC m, MpfrC x)
        //{
        //    var res = new MpfrC();
        //    Lib_Mpfc_Acb_LegendreQv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfc_Acb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static MpfrC legendre_qlm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_qlm(mflintc.t(n), mflintc.t(m), mflintc.t(x));
        //}





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static MpfrC spherical_y(MpfrC n, MpfrC m, MpfrC theta, MpfrC phi)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_SphericalY(res.mpPtr, n.mpPtr, m.mpPtr, theta.mpPtr, phi.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_SphericalY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_SphericalY(IntPtr res, IntPtr n, IntPtr m, IntPtr theta, IntPtr phi);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static MpfrC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(mflintc.t(n), mflintc.t(m), mflintc.t(theta), mflintc.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static MpfrC beta_lower(MpfrC a, MpfrC b, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static MpfrC beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(mflintc.t(a), mflintc.t(b), mflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static MpfrC ibeta(MpfrC a, MpfrC b, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static MpfrC ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(mflintc.t(a), mflintc.t(b), mflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static MpfrC ibetac(MpfrC a, MpfrC b, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static MpfrC ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(mflintc.t(a), mflintc.t(b), mflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static MpfrC ibeta_prime(MpfrC a, MpfrC b, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static MpfrC ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(mflintc.t(a), mflintc.t(b), mflintc.t(x));
        }


        #endregion







        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static MpfrC hyperg_1f2(MpfrC a1, MpfrC b1, MpfrC b2, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static MpfrC hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(mflintc.t(a1), mflintc.t(b1), mflintc.t(b2), mflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static MpfrC hyperg_1f2r(MpfrC a1, MpfrC b1, MpfrC b2, MpfrC x)
        {
            var res = new MpfrC();
            Lib_Mpfc_Acb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpfc_Acb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpfc_Acb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static MpfrC hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(mflintc.t(a1), mflintc.t(b1), mflintc.t(b2), mflintc.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static MpfrC airy_gi(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static MpfrC airy_gi(dynamic x)
        {
            return airy_gi(mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static MpfrC airy_hi(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static MpfrC airy_hi(dynamic x)
        {
            return airy_hi(mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static MpfrC airy_gi_prime(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static MpfrC airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static MpfrC airy_hi_prime(MpfrC x)
        {
            return aflintc.MCplxViaArbCS1(aflintc.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static MpfrC airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(mcplx.t(x));
        }




        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static MpfrC struve_h(MpfrC v, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static MpfrC struve_h(dynamic v, dynamic x)
        {
            return struve_h(mcplx.t(v), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static MpfrC struve_l(MpfrC v, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static MpfrC struve_l(dynamic v, dynamic x)
        {
            return struve_l(mcplx.t(v), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static MpfrC struve_k(MpfrC v, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static MpfrC struve_k(dynamic v, dynamic x)
        {
            return struve_k(mcplx.t(v), mcplx.t(x));
        }


        public static MpfrC struve_m(MpfrC v, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static MpfrC struve_m(dynamic v, dynamic x)
        {
            return struve_m(mcplx.t(v), mcplx.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static MpfrC anger_j(MpfrC v, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static MpfrC anger_j(dynamic v, dynamic x)
        {
            return anger_j(mcplx.t(v), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static MpfrC weber_e(MpfrC v, MpfrC x)
        {
            return aflintc.MCplxViaArbCS2(aflintc.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static MpfrC weber_e(dynamic v, dynamic x)
        {
            return weber_e(mcplx.t(v), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static MpfrC lommel_s1(MpfrC mu, MpfrC nu, MpfrC x)
        {
            return aflintc.MCplxViaArbCS3(aflintc.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static MpfrC lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(mcplx.t(mu), mcplx.t(nu), mcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static MpfrC lommel_s2(MpfrC mu, MpfrC nu, MpfrC x)
        {
            return aflintc.MCplxViaArbCS3(aflintc.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static MpfrC lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(mcplx.t(mu), mcplx.t(nu), mcplx.t(x));
        }


        #endregion










        #endregion


    }






}
