using System;
using System.Numerics;
using System.Runtime.InteropServices;
using FixedPrecNet;


namespace ArbPrecNet
{


    public class BigDecimalC
    {



        #region Init

        internal IntPtr mpPtr = IntPtr.Zero;


        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Lib_Mpdc_Init_Func();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_Mpdc_Init_Func();


        ~BigDecimalC()
        {
            Lib_Mpdc_Clear(mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Clear(IntPtr x);

        #endregion


        #region Conversions


        public BigDecimal real
        {
            get
            {
                var res = new BigDecimal();
                Lib_Mpdc_Real(res.mpPtr, mpPtr);
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Real", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Real(IntPtr res, IntPtr z);



        public BigDecimal imag
        {
            get
            {
                var res = new BigDecimal();
            Lib_Mpdc_Imag(res.mpPtr, mpPtr);
            return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Imag", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Imag(IntPtr res, IntPtr z);


        //public BigDecimal imag
        //{
        //    get
        //    {
        //        var res = new BigDecimal();
        //    Lib_Mpdc_Imag(res.mpPtr, mpPtr);
        //    return res;
        //    }
        //}



        public BigDecimalC()
        {
            Init();
        }




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
            return "BigDecimalC('" + ToString() + "')";
        }




        #endregion




        #region Arithmetic operators


        public static bool operator ==(dynamic x, BigDecimalC y)
        {
            return bflintc.t(x) == y;
        }

        public static bool operator ==(BigDecimalC x, dynamic y)
        {
            return x == bflintc.t(y);
        }


        public static bool operator !=(dynamic x, BigDecimalC y)
        {
            return bflintc.t(x) != y;
        }

        public static bool operator !=(BigDecimalC x, dynamic y)
        {
            return x != bflintc.t(y);
        }



        public static bool operator ==(BigDecimalC x, BigDecimalC y)
        {
            return x.real == y.real & x.imag == y.imag;
        }

        public static bool operator !=(BigDecimalC x, BigDecimalC y)
        {
            return x.real != y.real | x.imag != y.imag;
        }




        public static BigDecimalC operator +(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Set(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Set(IntPtr res, IntPtr a);



        public static BigDecimalC operator -(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Neg(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Neg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Neg(IntPtr res, IntPtr x);









        public static BigDecimalC operator +(BigDecimalC x, dynamic y)
        {
            return x + bflintc.t(y);
        }

        public static BigDecimalC operator +(dynamic x, BigDecimalC y)
        {
            return bflintc.t(x) + y;
        }


        public static BigDecimalC operator +(BigDecimalC x, BigDecimal y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Add_Mpd(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Add_Mpd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Add_Mpd(IntPtr res, IntPtr x, IntPtr y);


        public static BigDecimalC operator +(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Add(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Add(IntPtr res, IntPtr x, IntPtr y);








        public static BigDecimalC operator -(BigDecimalC x, dynamic y)
        {
            return x - bflintc.t(y);
        }

        public static BigDecimalC operator -(dynamic x, BigDecimalC y)
        {
            return bflintc.t(x) - y;
        }


        public static BigDecimalC operator -(BigDecimalC x, BigDecimal y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Sub_Mpd(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Sub_Mpd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Sub_Mpd(IntPtr res, IntPtr x, IntPtr y);


        public static BigDecimalC operator -(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Sub(IntPtr res, IntPtr x, IntPtr y);










        public static BigDecimalC operator *(BigDecimalC x, dynamic y)
        {
            return x * bflintc.t(y);
        }

        public static BigDecimalC operator *(dynamic x, BigDecimalC y)
        {
            return bflintc.t(x) * y;
        }


        public static BigDecimalC operator *(BigDecimalC x, BigDecimal y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Mul_Mpd(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Mul_Mpd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Mul_Mpd(IntPtr res, IntPtr x, IntPtr y);


        public static BigDecimalC operator *(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Mul(IntPtr res, IntPtr x, IntPtr y);










        public static BigDecimalC operator /(BigDecimalC x, dynamic y)
        {
            return x / bflintc.t(y);
        }

        public static BigDecimalC operator /(dynamic x, BigDecimalC y)
        {
            return bflintc.t(x) / y;
        }



        public static BigDecimalC operator /(BigDecimalC x, BigDecimal y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Div_Mpd(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Div_Mpd", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Div_Mpd(IntPtr res, IntPtr x, IntPtr y);


        public static BigDecimalC operator /(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Div(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Div(IntPtr res, IntPtr x, IntPtr y);





        #endregion


    }








    public class bflintc
    {



        #region Flint Basic Functions


        #region General

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "bflintc"; }
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
        public static bflintc Flint
        {
            get { return new bflintc(); }
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



        #region Conversions


        /// <summary>
        /// Returns a new BigDecimalC using an extended precision floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(BigDecimal x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Set_Real(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Set_Real", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Set_Real(IntPtr res, IntPtr x);





        /// <summary>
        /// Returns a new BigDecimalC using an arbitrary precision (both mantissa and exponent) ball number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Arb x)
        {
            return bflintc.t(bflint.t(x));
        }





        /// <summary>
        /// Returns a new BigDecimalC using an arbitrary precision binary interval point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Interval x)
        {
            return bflintc.t(bflint.t(x));
        }



        /// <summary>
        /// Returns a new BigDecimalC using an arbitrary precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Mpfr x)
        {
            return bflintc.t(bflint.t(x));
        }



        /// <summary>
        /// Returns a new BigDecimalC using using an arbitrary precision decimal floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC T_(BigDecimal x)
        {
            return bflintc.t(bflint.t(x));
        }





        /// <summary>
        /// Returns a new BigDecimalC using a octuple precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Octuple x)
        {
            return bflintc.t(bflint.t(x));
        }


        /// <summary>
        /// Returns a new BigDecimalC using a quadruple precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Quadruple x)
        {
            return bflintc.t(bflint.t(x));
        }



        /// <summary>
        /// Returns a new BigDecimalC using an extended precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Extended x)
        {
            return bflintc.t(bflint.t(x));
        }



        /// <summary>
        /// Returns a new BigDecimalC using a double precision binary floating point number for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(double x)
        {
            return bflintc.t(bflint.t(x));
        }



        /// <summary>
        /// Returns a new BigDecimalC using a single precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Single x)
        {
            return bflintc.t(bflint.t(x));
        }



        /// <summary>
        /// Returns a new BigDecimalC using a signed 32 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Int32 x)
        {
            return bflintc.t(bflint.t(x));
        }


        /// <summary>
        /// Returns a new BigDecimalC using an unsigned 32 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(UInt32 x)
        {
            return bflintc.t(bflint.t(x));
        }


        /// <summary>
        /// Returns a new BigDecimalC using a signed 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(Int64 x)
        {
            return bflintc.t(bflint.t(x));
        }


        /// <summary>
        /// Returns a new BigDecimalC using an unsigned 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(UInt64 x)
        {
            return bflintc.t(bflint.t(x));
        }


        /// <summary>
        /// Returns a new BigDecimalC using a System.Decimal as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(decimal x)
        {
            return bflintc.t(bflint.t(x));
        }


        /// <summary>
        /// Returns a new BigDecimalC using an unsigned 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(BigInteger x)
        {
            return bflintc.t(bflint.t(x));
        }


        /// <summary>
        /// Returns a new BigDecimalC using a string as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static BigDecimalC t(string s)
        {
            return bflintc.t(bflint.t(s));
        }



        /// <summary>
        /// Returns a new BigDecimalC using 2 BigDecimal as input for the real and imaginary part
        /// </summary>
        public static BigDecimalC t(BigDecimal re, BigDecimal im)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Set2(res.mpPtr, re.mpPtr, im.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Set2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Set2(IntPtr res, IntPtr re, IntPtr im);



        /// <summary>
        /// Returns a new BigDecimalC using a complex arbitrary (both mantissa and exponent) precision ball number as input
        /// </summary>
        public static BigDecimalC t(ArbC z)
        {
            return bflintc.t(bflint.t(z.real), bflint.t(z.imag));
        }





        /// <summary>
        /// Returns a new BigDecimalC using a complex arbitrary precision binary interval point number as input
        /// </summary>
        public static BigDecimalC t(IntervalC z)
        {
            return bflintc.t(bflint.t(z.real), bflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new BigDecimalC using a complex arbitrary precision binary floating point number as input
        /// </summary>
        public static BigDecimalC t(MpfrC z)
        {
            return bflintc.t(bflint.t(z.real), bflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new BigDecimalC using a complex arbitrary precision decimal floating point number as input
        /// </summary>
        public static BigDecimalC t(BigDecimalC z)
        {
            return bflintc.t(bflint.t(z.real), bflint.t(z.imag));
        }





        /// <summary>
        /// Returns a new BigDecimalC using a complex quadruple precision binary floating point number as input
        /// </summary>
        public static BigDecimalC t(QuadrupleC z)
        {
            return bflintc.t(bflint.t(z.real), bflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new BigDecimalC using a complex extended precision binary floating point number as input
        /// </summary>
        public static BigDecimalC t(ExtendedC z)
        {
            return bflintc.t(bflint.t(z.real), bflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new BigDecimalC using a complex extended precision binary floating point number as input
        /// </summary>
        public static BigDecimalC T_(BigDecimalC z)
        {
            return bflintc.t(bflint.t(z.real), bflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new BigDecimalC using a complex double precision binary floating point number (System.Complex) as input
        /// </summary>
        public static BigDecimalC t(Complex z)
        {
            return bflintc.t(bflint.t(z.Real), bflint.t(z.Imaginary));
        }





        /// <summary>
        /// Returns a new BigDecimalC using a complex single precision binary floating point number as input
        /// </summary>
        public static BigDecimalC t(SingleC z)
        {
            return bflintc.t(bflint.t(z.real), bflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new BigDecimalC using 2 double as input for the real and imaginary part
        /// </summary>
        public static BigDecimalC t(Double d_re, Double d_im)
        {
            return bflintc.t(bflint.t(d_re), bflint.t(d_im));
        }


        /// <summary>
        /// Returns a new BigDecimalC using 2 strings as input for the real and imaginary part
        /// </summary>
        public static BigDecimalC t(string s_re, string s_im)
        {
            return bflintc.t(bflint.t(s_re), bflint.t(s_im));
        }


        /// <summary>
        /// Returns a new BigDecimalC using a general object as input
        /// </summary>
        public static BigDecimalC t(dynamic z)
        {
            // MsgBox(y_.GetType().ToString())
            // MsgBox(y_.ToString())
            // MsgBox(y_.real.ToString())
            string s_re = z.real.ToString();
            string s_im = z.imag.ToString();
            return bflintc.t(bflint.t(s_re), bflint.t(s_im));
        }


        #endregion





        #region Basic Arithmetic and Comparisons


        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Set(IntPtr res, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/add/*' />
        public static BigDecimalC add(BigDecimalC x, BigDecimalC y)
        {
            return x + y;
        }
        public static BigDecimalC add(dynamic x, dynamic y)
        {
            return t(x) + t(y);
        }

        /// <summary>
        /// Return the sum of x and y
        /// </summary>
        public static void rawadd(BigDecimalC res, BigDecimalC x, BigDecimalC y)
        {
            Lib_Mpdc_Add(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Add(IntPtr res, IntPtr x, IntPtr y);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/subtract/*' />
        public static BigDecimalC subtract(BigDecimalC x, BigDecimalC y)
        {
            return x - y;
        }
        public static BigDecimalC subtract(dynamic x, dynamic y)
        {
            return t(x) - t(y);
        }

        /// <summary>
        /// Return the difference of x and y
        /// </summary>
        public static void rawsub(BigDecimalC res, BigDecimalC x, BigDecimalC y)
        {
            Lib_Mpdc_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Sub(IntPtr res, IntPtr x, IntPtr y);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/multiply/*' />
        public static BigDecimalC multiply(BigDecimalC x, BigDecimalC y)
        {
            return x * y;
        }
        public static BigDecimalC multiply(dynamic x, dynamic y)
        {
            return t(x) * t(y);
        }

        /// <summary>
        /// Return the product of x and y
        /// </summary>
        public static void rawmul(BigDecimalC res, BigDecimalC x, BigDecimalC y)
        {
            Lib_Mpdc_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Mul(IntPtr res, IntPtr x, IntPtr y);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/divide/*' />
        public static BigDecimalC divide(BigDecimalC x, BigDecimalC y)
        {
            return x / y;
        }
        public static BigDecimalC divide(dynamic x, dynamic y)
        {
            return t(x) / t(y);
        }

        /// <summary>
        /// Return the quotient of x and y
        /// </summary>
        public static void rawdiv(BigDecimalC res, BigDecimalC x, BigDecimalC y)
        {
            Lib_Mpdc_Div(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Div(IntPtr res, IntPtr x, IntPtr y);





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Cmp/*' />
        public static bool Cmp(BigDecimalC x, BigDecimalC y)
        {
            return true;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CmpAbs/*' />
        public static bool CmpAbs(BigDecimalC x, BigDecimalC y)
        {
            return true;
        }





        #endregion



        #region Machine constants and properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsReal/*' />
        public static bool IsReal(BigDecimalC z)
        {
            return (z.imag == bflint.t(0.0d));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(BigDecimalC z)
        {
            return (z.real == bflint.t(0.0d)) && (z.imag == bflint.t(0.0d));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(BigDecimalC z)
        {
            return (z.real == bflint.t(1.0d)) && (z.imag == bflint.t(0.0d));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(BigDecimalC z)
        {
            return (bflint.isinf(z.real)) || (bflint.isinf(z.imag));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(BigDecimalC z)
        {
            return (bflint.isnan(z.real)) || (bflint.isnan(z.imag));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(BigDecimalC z)
        {
            return (bflint.isfinite(z.real)) && (bflint.isfinite(z.imag));
        }





        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static BigDecimalC zero()
        {
            return bflintc.t(0d, 0d);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static BigDecimalC one()
        {
            return bflintc.t(1d, 0d);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onei/*' />
        public static BigDecimalC onei()
        {
            return bflintc.t(0d, 1d);
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/Onei/*' />
        //public static BigDecimalC Onei()
        //{
        //    return bflintc.t(0d, 1d);
        //}



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static BigDecimalC nan()
        {
            return bflintc.t(bflint.nan(), bflint.nan());
        }




        #endregion



        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static BigDecimal real(BigDecimalC z)
        {
            return z.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static BigDecimal real(dynamic x)
        {
            return real(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static BigDecimal imag(BigDecimalC z)
        {
            return z.imag;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static BigDecimal imag(dynamic x)
        {
            return imag(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static BigDecimal abs(BigDecimalC x)
        {
            var res = new BigDecimal();
            Lib_Mpdc_Abs(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Abs", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Abs(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static BigDecimal abs(dynamic x)
        {
            return abs(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static BigDecimal phase(BigDecimalC x)
        {
            var res = new BigDecimal();
            Lib_Mpdc_Arg(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Arg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Arg(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static BigDecimal phase(dynamic x)
        {
            return phase(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static BigDecimalC conj(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Conj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Conj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Conj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static BigDecimalC conj(dynamic x)
        {
            return conj(t(x));
        }






        #endregion



        #region Roots and quadratic, cubic, and quartic 



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static BigDecimalC sqrt(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static BigDecimalC sqrt(dynamic x)
        {
            return sqrt(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static BigDecimalC rsqrt(BigDecimalC x)
        {
            return 1.0 / sqrt(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static BigDecimalC rsqrt(dynamic x)
        {
            return rsqrt(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static BigDecimalC cbrt(BigDecimalC x)
        {
            BigDecimalC ks = bflintc.t(3);
            return bflintc.pow(x, 1 / ks);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static BigDecimalC cbrt(dynamic x)
        {
            return cbrt(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static BigDecimalC unitroot(Int32 k)
        {
            BigDecimalC ks = bflintc.t(k);
            return bflintc.pow(one(), one() / ks);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static BigDecimalC unitroot(dynamic x)
        {
            return unitroot(t(x));
        }





        // See also: Press, 3rd edition, page 227
        public static Tuple<BigDecimalC, BigDecimalC> quadratic_equation(BigDecimalC a, BigDecimalC b, BigDecimalC c)
        {
            BigDecimalC x1, x2;
            BigDecimalC D = bflintc.sqrt(b * b - 4 * a * c);
            BigDecimalC bStar = bflintc.conj(b);
            if ((bStar * D).real < bflint.t(0))
            {
                D = -D;
            }
            BigDecimalC q = -0.5 * (b + D);
            x1 = q / a;
            x2 = c / q;
            return new Tuple<BigDecimalC, BigDecimalC>(x1, x2);
        }


        // See also: Press, 3rd edition, page 228
        public static Tuple<BigDecimalC, BigDecimalC, BigDecimalC> cubic_equation_monic(BigDecimalC a, BigDecimalC b, BigDecimalC c)
        {
            BigDecimalC x1, x2, x3;
            BigDecimalC Q = (a * a - 3 * b) / 9;
            BigDecimalC R = (2 * a * a * a - 9 * a * b + 27 * c) / 54;
            BigDecimal Qr = Q.real;
            BigDecimal Rr = R.real;
            if ((Q.imag == bflint.t(0.0)) && (R.imag == bflint.t(0.0)) && (Rr * Rr < Qr * Qr * Qr))
            {
                Console.WriteLine("In bcplx real Case");
                BigDecimal SqrtQr = bflint.sqrt(Qr);
                BigDecimal theta = bflint.acos(Rr / (SqrtQr * SqrtQr * SqrtQr));
                x1 = -2 * SqrtQr * bflint.cos((theta) / 3) - a / 3;
                x2 = -2 * SqrtQr * bflint.cos((theta + 2 * bflint.pi()) / 3) - a / 3;
                x3 = -2 * SqrtQr * bflint.cos((theta - 2 * bflint.pi()) / 3) - a / 3;
            }
            else
            {
                Console.WriteLine("In bcplx BigDecimalC Case");
                BigDecimalC D = bflintc.sqrt(R * R - Q * Q * Q);
                BigDecimalC RStar = bflintc.conj(R);
                if ((RStar * D).real < bflint.t(0))
                {
                    D = -D;
                }
                BigDecimalC A = -bflintc.cbrt(R + D);
                BigDecimalC B = bflintc.zero();
                if (A != bflintc.zero())
                {
                    B = Q / A;
                }
                Console.WriteLine("A: {0}", A);
                Console.WriteLine("B: {0}", B);

                x1 = (A + B) - a / 3;
                x2 = -0.5 * (A + B) - a / 3 + 0.5 * bflintc.onei() * bflint.sqrt(3) * (A - B);
                x3 = -0.5 * (A + B) - a / 3 - 0.5 * bflintc.onei() * bflint.sqrt(3) * (A - B);
            }
            return new Tuple<BigDecimalC, BigDecimalC, BigDecimalC>(x1, x2, x3);
        }


        public static Tuple<BigDecimalC, BigDecimalC, BigDecimalC> cubic_equation(BigDecimalC A, BigDecimalC B, BigDecimalC C, BigDecimalC D)
        {
            return cubic_equation_monic(B / A, C / A, D / A);
        }



        // See also: https://en.wikipedia.org/wiki/Quartic_equation#Summary_of_Ferrari's_method
        public static Tuple<BigDecimalC, BigDecimalC, BigDecimalC, BigDecimalC> quartic_equation(BigDecimalC A, BigDecimalC B, BigDecimalC C, BigDecimalC D, BigDecimalC E)
        {
            BigDecimalC x1, x2, x3, x4;
            BigDecimalC a = -(3 * B * B) / (8 * A * A) + C / A;
            BigDecimalC b = (B * B * B) / (8 * A * A * A) - (B * C) / (2 * A * A) + D / A;
            BigDecimalC c = -(3 * B * B * B * B) / (256 * A * A * A * A) + (C * B * B) / (16 * A * A * A) - (B * D) / (4 * A * A) + E / A;
            BigDecimalC V = -B / (4 * A);

            if (bflintc.iszero(b))
            {
                BigDecimalC W = bflintc.sqrt(a * a - 4 * c);
                BigDecimalC Z1 = bflintc.sqrt((-a + W) / 2);
                BigDecimalC Z2 = bflintc.sqrt((-a - W) / 2);
                x1 = V + Z1;
                x2 = V - Z1;
                x3 = V + Z2;
                x4 = V - Z2;
            }
            else
            {
                BigDecimalC e = 5 * a / 2;
                BigDecimalC f = 2 * a * a - c;
                BigDecimalC g = a * a * a / 2 - a * c / 2 - b * b / 8;
                var res = cubic_equation_monic(e, f, g);
                BigDecimalC y = res.Item1;
                BigDecimalC W = bflintc.sqrt(a + 2 * y);
                BigDecimalC Z1 = bflintc.sqrt(-(3 * a + 2 * y + 2 * b / W));
                BigDecimalC Z2 = bflintc.sqrt(-(3 * a + 2 * y - 2 * b / W));
                x1 = V + (W + Z1) / 2;
                x2 = V + (W - Z1) / 2;
                x3 = V - (W + Z2) / 2;
                x4 = V - (W - Z2) / 2;
            }
            return new Tuple<BigDecimalC, BigDecimalC, BigDecimalC, BigDecimalC>(x1, x2, x3, x4);
        }









        #endregion



        #region Exponential and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static BigDecimalC exp(BigDecimalC x)
        {
            //MessageBox.Show("C#, BigDecimalC: " + x.ToString());
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static BigDecimalC exp(dynamic x)
        {
            return exp(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static BigDecimalC expm1(BigDecimalC x)
        {
            return exp(x) - 1;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static BigDecimalC expm1(dynamic x)
        {
            return expm1(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static BigDecimalC exp2(BigDecimalC x)
        {
            return exp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static BigDecimalC exp2(dynamic x)
        {
            return exp2(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static BigDecimalC expj(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Expi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Expi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Expi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static BigDecimalC expj(dynamic x)
        {
            return expj(t(x));
        }







        #endregion



        #region Logarithms and related functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static BigDecimalC log(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static BigDecimalC log(dynamic x)
        {
            return log(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static BigDecimalC log1p(BigDecimalC x)
        {
            return log(x + 1);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static BigDecimalC log1p(dynamic x)
        {
            return log1p(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static BigDecimalC log2(BigDecimalC x)
        {
            return log(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static BigDecimalC log2(dynamic x)
        {
            return log2(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static BigDecimalC log10(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static BigDecimalC log10(dynamic x)
        {
            return log10(t(x));
        }




        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static BigDecimalC sqr(BigDecimalC x)
        {
            return x * x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static BigDecimalC sqr(dynamic x)
        {
            return sqr(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static BigDecimalC pow(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static BigDecimalC pow(dynamic x, dynamic y)
        {
            return pow(t(x), t(y));
        }





        #endregion



        #region Trigonometric and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static BigDecimalC cos(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static BigDecimalC cos(dynamic x)
        {
            return cos(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static BigDecimalC sin(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static BigDecimalC sin(dynamic x)
        {
            return sin(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static BigDecimalC tan(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Tan(IntPtr res, IntPtr x);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static BigDecimalC tan(dynamic x)
        {
            return tan(t(x));
        }




        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static BigDecimalC cosh(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static BigDecimalC cosh(dynamic x)
        {
            return cosh(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static BigDecimalC sinh(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static BigDecimalC sinh(dynamic x)
        {
            return sinh(t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static BigDecimalC tanh(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static BigDecimalC tanh(dynamic x)
        {
            return tanh(t(x));
        }




        #endregion



        #region Inverse trigonometric functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static BigDecimalC acos(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static BigDecimalC acos(dynamic x)
        {
            return acos(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static BigDecimalC asin(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static BigDecimalC asin(dynamic x)
        {
            return asin(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static BigDecimalC atan(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static BigDecimalC atan(dynamic x)
        {
            return atan(t(x));
        }



        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static BigDecimalC acosh(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acosh(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static BigDecimalC acosh(dynamic x)
        {
            return acosh(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static BigDecimalC asinh(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static BigDecimalC asinh(dynamic x)
        {
            return asinh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static BigDecimalC atanh(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static BigDecimalC atanh(dynamic x)
        {
            return atanh(t(x));
        }




        #endregion





        #region Matrix Creation

        //public static bcplx CplxCtx()
        //{
        //    return new bcplx();
        //}

        /// <summary>
        /// Converts from a complex scalar of type BigDecimalC
        /// </summary>
        public static BigDecimalMatC mat_t(BigDecimalC x)
        {
            var matA = new BigDecimalMatC();
            matA[0, 0] = x;
            return matA;
        }

        /// <summary>
        /// Converts from a real matrix of type BigDecimalMat
        /// </summary>
        public static BigDecimalMatC mat_t(BigDecimalMat matA)
        {
            var x = mat_zeros(matA.rows, matA.cols);
            Interop.Lib_ConvertMatrixAndPoly(x.mpPtr, constants.mp_conv_mat_set_real_part_in_complex, constants.mp_dpc, constants.mp_dpc, matA.mpPtr);
            return x;
        }


        /// <summary>
        /// Makes a deep copy from a complex matrix of type BigDecimalMatC
        /// </summary>
        public static BigDecimalMatC mat_t(BigDecimalMatC matA)
        {
            var matX = mat_zeros(matA.rows, matA.cols);
            matX = +matA;
            return matX;
        }



        /// <summary>
        /// Returns SetZero
        /// </summary>
        public static BigDecimalMatC mat_zeros(int n, int m)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_setZero, n, m);
            return resout;
        }

        /* *********************** */

        public static BigDecimalMatC mat_cplx_t(BigDecimalMatC matA)
        {
            return mat_t(matA);
        }


        public static BigDecimalMatC mat_cplx_zeros(int n, int m)
        {
            return mat_zeros(n, m);
        }

        /* *********************** */






        /// <summary>
        /// Returns SetOnes
        /// </summary>
        public static BigDecimalMatC mat_ones(int n, int m)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_setOnes, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static BigDecimalMatC mat_identity(int n, int m)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static BigDecimalMatC mat_eye(int n, int m)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns Random
        /// </summary>
        public static BigDecimalMatC mat_random(int n, int m)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_setRandom_nm, n, m);
            return resout;
        }


        /// <summary>
        /// Returns RandomSym
        /// </summary>
        public static BigDecimalMatC mat_random_symmetric(int n)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_setRandomSymmetric, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSa
        /// </summary>
        public static BigDecimalMatC mat_random_selfadjoint(int n)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_setRandomSA, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSaPosdef
        /// </summary>
        public static BigDecimalMatC mat_random_selfadjoint_posdef(int n)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_setRandomSAPosDef, n, n);
            return resout;
        }


        /// <summary>
        /// Returns FillLinear
        /// </summary>
        public static BigDecimalMatC mat_fill_linear(int n, int m)
        {
            var resout = new BigDecimalMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_dpc, resout, constants.mp_FillLinear, n, m);
            return resout;
        }




        #endregion





        #endregion





        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static BigDecimalC m_elliptic_k(BigDecimalC m)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static BigDecimalC m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static BigDecimalC m_elliptic_e(BigDecimalC m)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static BigDecimalC m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static BigDecimalC m_elliptic_pi(BigDecimalC n, BigDecimalC m)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static BigDecimalC m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(bflintc.t(x), bflintc.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static BigDecimalC m_elliptic_f(BigDecimalC phi, BigDecimalC m)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static BigDecimalC m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(bflintc.t(phi), bflintc.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static BigDecimalC m_elliptic_e_inc(BigDecimalC phi, BigDecimalC m)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static BigDecimalC m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(bflintc.t(phi), bflintc.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static BigDecimalC m_elliptic_pi_inc(BigDecimalC n, BigDecimalC phi, BigDecimalC m)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_MEllipticPiInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_MEllipticPiInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static BigDecimalC m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(bflintc.t(n), bflintc.t(phi), bflintc.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static BigDecimalC elliptic_k(BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static BigDecimalC elliptic_k(dynamic k)
        {
            return elliptic_k(bflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static BigDecimalC elliptic_e(BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static BigDecimalC elliptic_e(dynamic k)
        {
            return elliptic_e(bflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static BigDecimalC elliptic_pi(BigDecimalC n, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static BigDecimalC elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(bflintc.t(n), bflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static BigDecimalC elliptic_f(BigDecimalC phi, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static BigDecimalC elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(bflintc.t(phi), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static BigDecimalC elliptic_e_inc(BigDecimalC phi, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static BigDecimalC elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(bflintc.t(phi), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static BigDecimalC elliptic_pi_inc(BigDecimalC n, BigDecimalC phi, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static BigDecimalC elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(bflintc.t(n), bflintc.t(phi), bflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static BigDecimalC agm(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static BigDecimalC agm(dynamic x, dynamic y)
        {
            return agm(bflintc.t(x), bflintc.t(y));
        }


        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static BigDecimalC elliptic_rc(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static BigDecimalC elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(bflintc.t(x), bflintc.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static BigDecimalC elliptic_rf(BigDecimalC x, BigDecimalC y, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static BigDecimalC elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(bflintc.t(x), bflintc.t(y), bflintc.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static BigDecimalC elliptic_rg(BigDecimalC x, BigDecimalC y, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static BigDecimalC elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(bflintc.t(x), bflintc.t(y), bflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static BigDecimalC elliptic_rd(BigDecimalC x, BigDecimalC y, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static BigDecimalC elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(bflintc.t(x), bflintc.t(y), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static BigDecimalC elliptic_rj(BigDecimalC x, BigDecimalC y, BigDecimalC z, BigDecimalC w)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static BigDecimalC elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(bflintc.t(x), bflintc.t(y), bflintc.t(z), bflintc.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static BigDecimalC jacobi_theta1(BigDecimalC x, BigDecimalC q)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static BigDecimalC jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(bflintc.t(x), bflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static BigDecimalC jacobi_theta2(BigDecimalC x, BigDecimalC q)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static BigDecimalC jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(bflintc.t(x), bflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static BigDecimalC jacobi_theta3(BigDecimalC x, BigDecimalC q)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static BigDecimalC jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(bflintc.t(x), bflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static BigDecimalC jacobi_theta4(BigDecimalC x, BigDecimalC q)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static BigDecimalC jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(bflintc.t(x), bflintc.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static BigDecimalC JacobiTheta1Tau(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Theta1QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Theta1QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Theta1QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static BigDecimalC JacobiTheta1Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta1Tau(bflintc.t(z), bflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static BigDecimalC JacobiTheta2Tau(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Theta2QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Theta2QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Theta2QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static BigDecimalC JacobiTheta2Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta2Tau(bflintc.t(z), bflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static BigDecimalC JacobiTheta3Tau(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Theta3QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Theta3QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Theta3QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static BigDecimalC JacobiTheta3Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta3Tau(bflintc.t(z), bflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static BigDecimalC JacobiTheta4Tau(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Theta4QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Theta4QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_Theta4QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static BigDecimalC JacobiTheta4Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta4Tau(bflintc.t(z), bflintc.t(tau));
        }






        #endregion



        #region Jacobi elliptic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static BigDecimalC QfromK(BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_QfromK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_QfromK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_QfromK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static BigDecimalC QfromK(dynamic k)
        {
            return QfromK(bflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static BigDecimalC TfromUQ(BigDecimalC u, BigDecimalC q)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_TfromUQ(res.mpPtr, u.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_TfromUQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_TfromUQ(IntPtr res, IntPtr u, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static BigDecimalC TfromUQ(dynamic n, dynamic k)
        {
            return TfromUQ(bflintc.t(n), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static BigDecimalC SnTQ(BigDecimalC t, BigDecimalC q)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_SnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_SnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_SnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static BigDecimalC SnTQ(dynamic t, dynamic q)
        {
            return SnTQ(bflintc.t(t), bflintc.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static BigDecimalC CnTQ(BigDecimalC t, BigDecimalC q)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_CnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_CnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_CnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static BigDecimalC CnTQ(dynamic t, dynamic q)
        {
            return CnTQ(bflintc.t(t), bflintc.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static BigDecimalC DnTQ(BigDecimalC t, BigDecimalC q)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_DnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_DnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_DnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static BigDecimalC DnTQ(dynamic t, dynamic q)
        {
            return DnTQ(bflintc.t(t), bflintc.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static BigDecimalC jacobi_sn(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static BigDecimalC jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static BigDecimalC jacobi_cn(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static BigDecimalC jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static BigDecimalC jacobi_dn(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static BigDecimalC jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static BigDecimalC jacobi_ns(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static BigDecimalC jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static BigDecimalC jacobi_nc(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static BigDecimalC jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static BigDecimalC jacobi_nd(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static BigDecimalC jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static BigDecimalC jacobi_sc(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static BigDecimalC jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static BigDecimalC jacobi_sd(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static BigDecimalC jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static BigDecimalC jacobi_dc(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static BigDecimalC jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static BigDecimalC jacobi_ds(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static BigDecimalC jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static BigDecimalC jacobi_cs(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static BigDecimalC jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(bflintc.t(x), bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static BigDecimalC jacobi_cd(BigDecimalC x, BigDecimalC k)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static BigDecimalC jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(bflintc.t(x), bflintc.t(k));
        }




        #endregion



        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassP/*' />
        public static BigDecimalC WeierstrassP(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_WeierstrassP(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_WeierstrassP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_WeierstrassP(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassP/*' />
        public static BigDecimalC WeierstrassP(dynamic z, dynamic tau)
        {
            return WeierstrassP(bflintc.t(z), bflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static BigDecimalC WeierstrassPInv(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_WeierstrassPInv(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_WeierstrassPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_WeierstrassPInv(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static BigDecimalC WeierstrassPInv(dynamic z, dynamic tau)
        {
            return WeierstrassPInv(bflintc.t(z), bflintc.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPZeta/*' />
        public static BigDecimalC WeierstrassPZeta(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_WeierstrassPZeta(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_WeierstrassPZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_WeierstrassPZeta(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPZeta/*' />
        public static BigDecimalC WeierstrassPZeta(dynamic z, dynamic tau)
        {
            return WeierstrassPZeta(bflintc.t(z), bflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPSigma/*' />
        public static BigDecimalC WeierstrassPSigma(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_WeierstrassPSigma(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_WeierstrassPSigma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_WeierstrassPSigma(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPSigma/*' />
        public static BigDecimalC WeierstrassPSigma(dynamic z, dynamic tau)
        {
            return WeierstrassPSigma(bflintc.t(z), bflintc.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPPrime/*' />
        public static BigDecimalC WeierstrassPPrime(BigDecimalC z, BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_WeierstrassPPrime(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_WeierstrassPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_WeierstrassPPrime(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPPrime/*' />
        public static BigDecimalC WeierstrassPPrime(dynamic z, dynamic tau)
        {
            return WeierstrassPPrime(bflintc.t(z), bflintc.t(tau));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static BigDecimalC EllipticInvariantG2(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticInvariantG2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticInvariantG2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticInvariantG2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static BigDecimalC EllipticInvariantG2(dynamic k)
        {
            return EllipticInvariantG2(bflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static BigDecimalC EllipticInvariantG3(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticInvariantG3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticInvariantG3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticInvariantG3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static BigDecimalC EllipticInvariantG3(dynamic k)
        {
            return EllipticInvariantG3(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static BigDecimalC EllipticRootE1(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticRootE1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticRootE1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticRootE1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static BigDecimalC EllipticRootE1(dynamic k)
        {
            return EllipticRootE1(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static BigDecimalC EllipticRootE2(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticRootE2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticRootE2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticRootE2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static BigDecimalC EllipticRootE2(dynamic k)
        {
            return EllipticRootE2(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static BigDecimalC EllipticRootE3(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EllipticRootE3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EllipticRootE3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_EllipticRootE3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static BigDecimalC EllipticRootE3(dynamic k)
        {
            return EllipticRootE3(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DedekindEta/*' />
        public static BigDecimalC DedekindEta(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_DedekindEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_DedekindEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_DedekindEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DedekindEta/*' />
        public static BigDecimalC DedekindEta(dynamic k)
        {
            return DedekindEta(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/KleinJ/*' />
        public static BigDecimalC KleinJ(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_KleinJ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_KleinJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_KleinJ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/KleinJ/*' />
        public static BigDecimalC KleinJ(dynamic k)
        {
            return KleinJ(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ModularLambda/*' />
        public static BigDecimalC ModularLambda(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ModularLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ModularLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_ModularLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ModularLambda/*' />
        public static BigDecimalC ModularLambda(dynamic k)
        {
            return ModularLambda(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ModularDelta/*' />
        public static BigDecimalC ModularDelta(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ModularDelta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ModularDelta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_ModularDelta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ModularDelta/*' />
        public static BigDecimalC ModularDelta(dynamic k)
        {
            return ModularDelta(bflintc.t(k));
        }



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static BigDecimalC lerch_phi(BigDecimalC s, BigDecimalC z, BigDecimalC a)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static BigDecimalC lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(bflintc.t(s), bflintc.t(z), bflintc.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static BigDecimalC lerch_zeta(BigDecimalC lambda1, BigDecimalC alpha, BigDecimalC s)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LerchZeta(res.mpPtr, lambda1.mpPtr, alpha.mpPtr, s.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LerchZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LerchZeta(IntPtr res, IntPtr lambda1, IntPtr alpha, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static BigDecimalC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(bflintc.t(lambda1), bflintc.t(alpha), bflintc.t(s));
        }




        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static BigDecimalC polygamma(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static BigDecimalC polygamma(dynamic s, dynamic z)
        {
            return polygamma(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static BigDecimalC trigamma(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Trigamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Trigamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static BigDecimalC trigamma(dynamic x)
        {
            return trigamma(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static BigDecimalC digamma(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static BigDecimalC digamma(dynamic x)
        {
            return digamma(bflintc.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static BigDecimalC polylog(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static BigDecimalC polylog(dynamic s, dynamic z)
        {
            return polylog(bflintc.t(s), bflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static BigDecimalC trilog(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Trilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Trilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Trilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static BigDecimalC trilog(dynamic x)
        {
            return trilog(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static BigDecimalC dilog(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static BigDecimalC dilog(dynamic x)
        {
            return dilog(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static BigDecimalC clausen_sin(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ClausenSin(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ClausenSin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_ClausenSin(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static BigDecimalC clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static BigDecimalC clausen_cos(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ClausenCos(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ClausenCos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_ClausenCos(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static BigDecimalC clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(bflintc.t(s), bflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static BigDecimalC clausen2(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Clausen2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Clausen2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Clausen2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static BigDecimalC clausen2(dynamic x)
        {
            return clausen2(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static BigDecimalC bose_einstein(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BoseEinstein(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BoseEinstein", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BoseEinstein(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static BigDecimalC bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static BigDecimalC fermi_dirac(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_FermiDirac(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_FermiDirac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_FermiDirac(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static BigDecimalC fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static BigDecimalC legendre_chi(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LegendreChi(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LegendreChi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LegendreChi(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static BigDecimalC legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static BigDecimalC inverse_tan_integral(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_InverseTanIntegral(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_InverseTanIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_InverseTanIntegral(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static BigDecimalC inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(bflintc.t(s), bflintc.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static BigDecimalC hurwitz_zeta(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_HurwitzZeta(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static BigDecimalC hurwitz_zeta(dynamic s, dynamic z)
        {
            return hurwitz_zeta(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/stieltjes/*' />
        public static BigDecimalC stieltjes(BigDecimalC x, Int32 n)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Stieltjes_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Stieltjes_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Stieltjes_ui(IntPtr res, IntPtr x, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static BigDecimalC bernpoly(BigDecimalC x, Int32 n)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static BigDecimalC bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(bflintc.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static BigDecimalC eulerpoly(BigDecimalC x, Int32 n)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_EulerPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_EulerPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_EulerPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static BigDecimalC eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(bflintc.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static BigDecimalC harmonic(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Harmonic(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Harmonic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Harmonic(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static BigDecimalC harmonic(dynamic x)
        {
            return harmonic(bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static BigDecimalC harmonic2(BigDecimalC z, BigDecimalC r)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Harmonic2(res.mpPtr, z.mpPtr, r.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Harmonic2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Harmonic2(IntPtr res, IntPtr z, IntPtr r);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static BigDecimalC harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(bflintc.t(z), bflintc.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static BigDecimalC barnes_g(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static BigDecimalC barnes_g(dynamic x)
        {
            return barnes_g(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static BigDecimalC logbarnes_g(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static BigDecimalC logbarnes_g(dynamic x)
        {
            return logbarnes_g(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static BigDecimalC hyperfactorial(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hyperfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hyperfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hyperfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static BigDecimalC hyperfactorial(dynamic x)
        {
            return hyperfactorial(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static BigDecimalC superfactorial(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Superfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Superfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Superfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static BigDecimalC superfactorial(dynamic x)
        {
            return superfactorial(bflintc.t(x));
        }




        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static BigDecimalC zeta(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static BigDecimalC zeta(dynamic x)
        {
            return zeta(bflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static BigDecimalC zetam1(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Zetam1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Zetam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Zetam1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static BigDecimalC zetam1(dynamic x)
        {
            return zetam1(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static BigDecimalC riemann_xi(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_DirichletXi(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_DirichletXi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_DirichletXi(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static BigDecimalC riemann_xi(dynamic k)
        {
            return riemann_xi(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static BigDecimalC dirichlet_eta(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_DirichletEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_DirichletEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_DirichletEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static BigDecimalC dirichlet_eta(dynamic k)
        {
            return dirichlet_eta(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta_m1/*' />
        public static BigDecimalC dirichlet_eta_m1(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_DirichletEtam1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_DirichletEtam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_DirichletEtam1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta_m1/*' />
        public static BigDecimalC dirichlet_eta_m1(dynamic k)
        {
            return dirichlet_eta_m1(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static BigDecimalC dirichlet_beta(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_DirichletBeta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_DirichletBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_DirichletBeta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static BigDecimalC dirichlet_beta(dynamic k)
        {
            return dirichlet_beta(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static BigDecimalC dirichlet_lambda(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_DirichletLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_DirichletLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_DirichletLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static BigDecimalC dirichlet_lambda(dynamic k)
        {
            return dirichlet_lambda(bflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static BigDecimalC hardy_z(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_HardyZ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_HardyZ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_HardyZ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static BigDecimalC hardy_z(dynamic k)
        {
            return hardy_z(bflintc.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static BigDecimalC hardy_theta(BigDecimalC tau)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_HardyTheta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_HardyTheta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Mpdc_Acb_HardyTheta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static BigDecimalC hardy_theta(dynamic k)
        {
            return hardy_theta(bflintc.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta_zero/*' />
        public static BigDecimalC zeta_zero(Int32 n)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ZetaZero_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ZetaZero_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_ZetaZero_ui(IntPtr res, Int32 n);



        #endregion



        #region Additional numbertheoretic functions





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static BigDecimalC hyperg_0f1(BigDecimalC a, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static BigDecimalC hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(bflintc.t(a), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static BigDecimalC hyperg_0f1r(BigDecimalC a, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static BigDecimalC hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(bflintc.t(a), bflintc.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static BigDecimalC bessel_jv(BigDecimalC nu, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BesselJ(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BesselJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BesselJ(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static BigDecimalC bessel_jv(dynamic nu, dynamic x)
        {
            return bessel_jv(bflintc.t(nu), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static BigDecimalC bessel_yv(BigDecimalC nu, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BesselY(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BesselY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BesselY(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static BigDecimalC bessel_yv(dynamic nu, dynamic x)
        {
            return bessel_yv(bflintc.t(nu), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static BigDecimalC bessel_iv(BigDecimalC nu, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BesselI(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BesselI", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BesselI(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static BigDecimalC bessel_iv(dynamic nu, dynamic x)
        {
            return bessel_iv(bflintc.t(nu), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static BigDecimalC bessel_kv(BigDecimalC nu, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BesselK(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BesselK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BesselK(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static BigDecimalC bessel_kv(dynamic nu, dynamic x)
        {
            return bessel_kv(bflintc.t(nu), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_ive/*' />
        public static BigDecimalC bessel_ive(BigDecimalC nu, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BesselIScaled(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BesselIScaled", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BesselIScaled(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_ive/*' />
        public static BigDecimalC bessel_ive(dynamic nu, dynamic x)
        {
            return bessel_ive(bflintc.t(nu), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kve/*' />
        public static BigDecimalC bessel_kve(BigDecimalC nu, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BesselKScaled(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BesselKScaled", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BesselKScaled(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kve/*' />
        public static BigDecimalC bessel_kve(dynamic nu, dynamic x)
        {
            return bessel_kve(bflintc.t(nu), bflintc.t(x));
        }




        #endregion



        #region 0F1: Spherical Bessel functions



        #endregion



        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static BigDecimalC airy_ai(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_AiryAi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_AiryAi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static BigDecimalC airy_ai(dynamic x)
        {
            return airy_ai(bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static BigDecimalC airy_ai_prime(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_AiryAiPrime(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_AiryAiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static BigDecimalC airy_ai_prime(dynamic x)
        {
            return airy_ai_prime(bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static BigDecimalC airy_bi(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_AiryBi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_AiryBi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static BigDecimalC airy_bi(dynamic x)
        {
            return airy_bi(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static BigDecimalC airy_bi_prime(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_AiryBiPrime(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_AiryBiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static BigDecimalC airy_bi_prime(dynamic x)
        {
            return airy_bi_prime(bflintc.t(x));
        }



        #endregion



        #region 0F1: Kelvin functions



        #endregion








        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static BigDecimalC hyperg_1f1(BigDecimalC a, BigDecimalC b, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static BigDecimalC hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(bflintc.t(a), bflintc.t(b), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static BigDecimalC hyperg_1f1r(BigDecimalC a, BigDecimalC b, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static BigDecimalC hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(bflintc.t(a), bflintc.t(b), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static BigDecimalC hyperg_u(BigDecimalC a, BigDecimalC b, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static BigDecimalC hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(bflintc.t(a), bflintc.t(b), bflintc.t(x));
        }





        #endregion



        #region 1F1: gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static BigDecimalC gamma(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static BigDecimalC gamma(dynamic x)
        {
            return gamma(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static BigDecimalC rgamma(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static BigDecimalC rgamma(dynamic x)
        {
            return rgamma(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static BigDecimalC lgamma(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static BigDecimalC lgamma(dynamic x)
        {
            return lgamma(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static BigDecimalC rising_factorial(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static BigDecimalC rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(bflintc.t(x), bflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static BigDecimalC beta(BigDecimalC x, BigDecimalC y)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static BigDecimalC beta(dynamic x, dynamic y)
        {
            return beta(bflintc.t(x), bflintc.t(y));
        }


        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static BigDecimalC gamma_upper(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static BigDecimalC gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(bflintc.t(s), bflintc.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static BigDecimalC gamma_q(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static BigDecimalC gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(bflintc.t(s), bflintc.t(z));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static BigDecimalC gamma_lower(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static BigDecimalC gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static BigDecimalC gamma_p(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static BigDecimalC gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static BigDecimalC gamma_p_prime(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static BigDecimalC gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(bflintc.t(s), bflintc.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static BigDecimalC erf(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static BigDecimalC erf(dynamic x)
        {
            return erf(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static BigDecimalC erfc(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static BigDecimalC erfc(dynamic x)
        {
            return erfc(bflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static BigDecimalC erfi(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static BigDecimalC erfi(dynamic x)
        {
            return erfi(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static BigDecimalC fresnel_s(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static BigDecimalC fresnel_s(dynamic x)
        {
            return fresnel_s(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static BigDecimalC fresnel_c(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static BigDecimalC fresnel_c(dynamic x)
        {
            return fresnel_c(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static BigDecimalC ndens(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static BigDecimalC ndens(dynamic x)
        {
            return ndens(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static BigDecimalC ndis(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static BigDecimalC ndis(dynamic x)
        {
            return ndis(bflintc.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static BigDecimalC exp_integral_e1(BigDecimalC s, BigDecimalC z)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static BigDecimalC exp_integral_e1(dynamic s, dynamic z)
        {
            return exp_integral_e1(bflintc.t(s), bflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static BigDecimalC exp_integral_ei(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static BigDecimalC exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static BigDecimalC sin_integral(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static BigDecimalC sin_integral(dynamic x)
        {
            return sin_integral(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static BigDecimalC cos_integral(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static BigDecimalC cos_integral(dynamic x)
        {
            return cos_integral(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static BigDecimalC sinh_integral(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static BigDecimalC sinh_integral(dynamic x)
        {
            return sinh_integral(bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static BigDecimalC cosh_integral(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static BigDecimalC cosh_integral(dynamic x)
        {
            return cosh_integral(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static BigDecimalC log_integral(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static BigDecimalC log_integral(dynamic x)
        {
            return log_integral(bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static BigDecimalC log_integral_offset(BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static BigDecimalC log_integral_offset(dynamic x)
        {
            return log_integral_offset(bflintc.t(x));
        }



        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static BigDecimalC hermite_h(BigDecimalC n, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static BigDecimalC hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(bflintc.t(n), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static BigDecimalC laguerre_l(BigDecimalC n, BigDecimalC m, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static BigDecimalC laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(bflintc.t(n), bflintc.t(m), bflintc.t(x));
        }



        #endregion



        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static BigDecimalC coulomb_f(BigDecimalC l, BigDecimalC eta, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static BigDecimalC coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(bflintc.t(l), bflintc.t(eta), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static BigDecimalC coulomb_g(BigDecimalC l, BigDecimalC eta, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static BigDecimalC coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(bflintc.t(l), bflintc.t(eta), bflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static BigDecimalC coulomb_hpos(BigDecimalC l, BigDecimalC eta, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_CoulombHpos(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_CoulombHpos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_CoulombHpos(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static BigDecimalC coulomb_hpos(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hpos(bflintc.t(l), bflintc.t(eta), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static BigDecimalC coulomb_hneg(BigDecimalC l, BigDecimalC eta, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_CoulombHneg(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_CoulombHneg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_CoulombHneg(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static BigDecimalC coulomb_hneg(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hneg(bflintc.t(l), bflintc.t(eta), bflintc.t(x));
        }





        #endregion



        #region 1F1: Whittaker functions


        #endregion



        #region 1F1: Parabolic cylinder functions


        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static BigDecimalC hyperg_2f1(BigDecimalC a, BigDecimalC b, BigDecimalC c, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static BigDecimalC hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(bflintc.t(a), bflintc.t(b), bflintc.t(c), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static BigDecimalC hyperg_2f1r(BigDecimalC a, BigDecimalC b, BigDecimalC c, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static BigDecimalC hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(bflintc.t(a), bflintc.t(b), bflintc.t(c), bflintc.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static BigDecimalC chebyshev_t(BigDecimalC n, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static BigDecimalC chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(bflintc.t(n), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static BigDecimalC chebyshev_u(BigDecimalC n, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static BigDecimalC chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(bflintc.t(n), bflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static BigDecimalC gegenbauer_c(BigDecimalC n, BigDecimalC m, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static BigDecimalC gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(bflintc.t(n), bflintc.t(m), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static BigDecimalC jacobi_p(BigDecimalC n, BigDecimalC a, BigDecimalC b, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static BigDecimalC jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(bflintc.t(n), bflintc.t(a), bflintc.t(b), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static BigDecimalC legendre_p(BigDecimalC n, BigDecimalC m, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LegendreP(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static BigDecimalC legendre_p(dynamic n, dynamic m, dynamic x)
        {
            return legendre_p(bflintc.t(n), bflintc.t(m), bflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static BigDecimalC legendre_plm(BigDecimalC n, BigDecimalC m, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LegendrePv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static BigDecimalC legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(bflintc.t(n), bflintc.t(m), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static BigDecimalC legendre_q(BigDecimalC n, BigDecimalC m, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LegendreQ(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static BigDecimalC legendre_q(dynamic n, dynamic m, dynamic x)
        {
            return legendre_q(bflintc.t(n), bflintc.t(m), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static BigDecimalC legendre_qlm(BigDecimalC n, BigDecimalC m, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_LegendreQv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static BigDecimalC legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(bflintc.t(n), bflintc.t(m), bflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static BigDecimalC spherical_y(BigDecimalC n, BigDecimalC m, BigDecimalC theta, BigDecimalC phi)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_SphericalY(res.mpPtr, n.mpPtr, m.mpPtr, theta.mpPtr, phi.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_SphericalY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_SphericalY(IntPtr res, IntPtr n, IntPtr m, IntPtr theta, IntPtr phi);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static BigDecimalC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(bflintc.t(n), bflintc.t(m), bflintc.t(theta), bflintc.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static BigDecimalC beta_lower(BigDecimalC a, BigDecimalC b, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static BigDecimalC beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(bflintc.t(a), bflintc.t(b), bflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static BigDecimalC ibeta(BigDecimalC a, BigDecimalC b, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static BigDecimalC ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(bflintc.t(a), bflintc.t(b), bflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static BigDecimalC ibetac(BigDecimalC a, BigDecimalC b, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static BigDecimalC ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(bflintc.t(a), bflintc.t(b), bflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static BigDecimalC ibeta_prime(BigDecimalC a, BigDecimalC b, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static BigDecimalC ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(bflintc.t(a), bflintc.t(b), bflintc.t(x));
        }


        #endregion







        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static BigDecimalC hyperg_1f2(BigDecimalC a1, BigDecimalC b1, BigDecimalC b2, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static BigDecimalC hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(bflintc.t(a1), bflintc.t(b1), bflintc.t(b2), bflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static BigDecimalC hyperg_1f2r(BigDecimalC a1, BigDecimalC b1, BigDecimalC b2, BigDecimalC x)
        {
            var res = new BigDecimalC();
            Lib_Mpdc_Acb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Mpdc_Acb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Mpdc_Acb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static BigDecimalC hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(bflintc.t(a1), bflintc.t(b1), bflintc.t(b2), bflintc.t(x));
        }





        #endregion





        #endregion


    }







}