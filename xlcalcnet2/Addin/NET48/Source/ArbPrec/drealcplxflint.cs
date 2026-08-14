using System;
using System.Numerics;
using System.Runtime.InteropServices;
using FixedPrecNet;

namespace ArbPrecNet
{






    public class dflint
    {


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Double t(Arb x)
        {
            Double res = 0;
            Lib_FReal_Set_Arb(ref res, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Set_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Set_Arb(ref Double res, IntPtr x);


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Double t(Mpfr x)
        {
            Double res = 0;
            Lib_FReal_Set_Mpfr(ref res, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Set_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Set_Mpfr(ref Double res, IntPtr x);





        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "dflint"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return " dflint"; }
        }


        public static String fmt(Double x)
        {
            return dreal.fmt(x);
        }


        public static String fmt(dynamic x)
        {
            return fmt(dreal.t(x));
        }




        #region Basic floating point functions




        #region General functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Double fma(Double x, Double y, Double z)
        {
            return dreal.fma(x, y, z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Double fma(dynamic x, dynamic y, dynamic z)
        {
            return dreal.fma(x, y, z);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Double fmax(Double x, Double y)
        {
            return dreal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Double fmax(dynamic x, dynamic y)
        {
            return dreal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Double fmin(Double x, Double y)
        {
            return dreal.fmin(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Double fmin(dynamic x, dynamic y)
        {
            return dreal.fmin(x, y);
        }


        #endregion



        #region Machine constants


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static Double zero()
        {
            return dreal.zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/negzero/*' />
        public static Double negzero()
        {
            return dreal.negzero();
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static Double one()
        {
            return dreal.one();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static Complex onej()
        {
            return dreal.onej();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static Double inf()
        {
            return dreal.inf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/neginf/*' />
        public static Double neginf()
        {
            return dreal.neginf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static Double nan()
        {
            return dreal.nan();
        }



        #endregion



        #region Properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(Double x)
        {
            return dreal.signbit(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(dynamic x)
        {
            return dreal.signbit(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(Double x)
        {
            return dreal.isfinite(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isfinite/*' />
        public static bool isfinite(dynamic x)
        {
            return dreal.isfinite(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(Double x)
        {
            return dreal.isinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinf/*' />
        public static bool isinf(dynamic x)
        {
            return dreal.isinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static bool isposinf(Double x)
        {
            return dreal.isposinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isposinf/*' />
        public static bool isposinf(dynamic x)
        {
            return dreal.isposinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isneginf/*' />
        public static bool isneginf(Double x)
        {
            return dreal.isneginf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isneginf/*' />
        public static bool isneginf(dynamic x)
        {
            return dreal.isneginf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(Double x)
        {
            return dreal.isnan(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnan/*' />
        public static bool isnan(dynamic x)
        {
            return dreal.isnan(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(Double x)
        {
            return dreal.iszero(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/iszero/*' />
        public static bool iszero(dynamic x)
        {
            return dreal.iszero(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(Double x)
        {
            return dreal.isone(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isone/*' />
        public static bool isone(dynamic x)
        {
            return dreal.isone(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinteger/*' />
        public static bool isinteger(Double x)
        {
            return dreal.isinteger(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinteger/*' />
        public static bool isinteger(dynamic x)
        {
            return dreal.isinteger(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnumber/*' />
        public static bool isnumber(Double x)
        {
            return dreal.isnumber(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnumber/*' />
        public static bool isnumber(dynamic x)
        {
            return dreal.isnumber(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isregular/*' />
        public static bool isregular(Double x)
        {
            return dreal.isregular(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isregular/*' />
        public static bool isregular(dynamic x)
        {
            return dreal.isregular(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnormal/*' />
        public static bool isnormal(Double x)
        {
            return dreal.isnormal(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnormal/*' />
        public static bool isnormal(dynamic x)
        {
            return dreal.isnormal(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isunordered/*' />
        public static bool isunordered(Double x, Double y)
        {
            return dreal.isunordered(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isunordered/*' />
        public static bool isunordered(dynamic x, dynamic y)
        {
            return dreal.isunordered(x, y);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint32/*' />
        public static bool fitsint32(Double x)
        {
            return dreal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint32/*' />
        public static bool fitsint32(dynamic x)
        {
            return dreal.fitsint32(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint64/*' />
        public static bool fitsint64(Double x)
        {
            return dreal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint64/*' />
        public static bool fitsint64(dynamic x)
        {
            return dreal.fitsint32(x);
        }





        #endregion



        #region Integer Related Functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Double nearbyint(Double x)
        {
            return dreal.nearbyint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Double nearbyint(dynamic x)
        {
            return dreal.nearbyint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Double rint(Double x)
        {
            return dreal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Double rint(dynamic x)
        {
            return dreal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(Double x)
        {
            return dreal.lrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(dynamic x)
        {
            return dreal.lrint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(Double x)
        {
            return dreal.llrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(dynamic x)
        {
            return dreal.llrint(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Double ceil(Double x)
        {
            return dreal.ceil(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Double ceil(dynamic x)
        {
            return dreal.ceil(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Double floor(Double x)
        {
            return dreal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Double floor(dynamic x)
        {
            return dreal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Double trunc(Double x)
        {
            return dreal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Double trunc(dynamic x)
        {
            return dreal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Double round(Double x)
        {
            return dreal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Double round(dynamic x)
        {
            return dreal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(Double x)
        {
            return dreal.lround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(dynamic x)
        {
            return dreal.lround(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(Double x)
        {
            return dreal.llround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(dynamic x)
        {
            return dreal.llround(x);
        }




        #endregion



        #region Floating point functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Double copysign(Double x, Double y)
        {
            return dreal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Double copysign(dynamic x, dynamic y)
        {
            return dreal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Double, Int32> frexp(Double x)
        {
            return dreal.frexp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Double, Int32> frexp(dynamic x)
        {
            return dreal.frexp(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Double logb(Double x)
        {
            return dreal.logb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Double logb(dynamic x)
        {
            return dreal.logb(x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(Double x)
        {
            return dreal.ilogb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(dynamic x)
        {
            return dreal.ilogb(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Double ldexp(Double x, Int32 e)
        {
            return dreal.ldexp(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Double ldexp(dynamic x, dynamic e)
        {
            return dreal.ldexp(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Double scalbn(Double x, Int32 e)
        {
            return dreal.scalbn(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Double scalbn(dynamic x, dynamic e)
        {
            return dreal.scalbn(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Double scalbln(Double x, Int32 e)
        {
            return dreal.scalbln(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Double scalbln(dynamic x, dynamic e)
        {
            return dreal.scalbln(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Double fdim(Double x, Double y)
        {
            return dreal.fdim(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Double fdim(dynamic x, dynamic y)
        {
            return dreal.fdim(x, y);
        }


        #endregion



        #region Fraction and remainder Related Functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Double, Double> modf(Double x)
        {
            return dreal.modf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Double, Double> modf(dynamic x)
        {
            return dreal.modf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Double fmod(Double x, Double y)
        {
            return dreal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Double fmod(dynamic x, dynamic y)
        {
            return dreal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Double remainder(Double x, Double y)
        {
            return dreal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Double remainder(dynamic x, dynamic y)
        {
            return dreal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Double, Int32> remquo(Double x, Double y)
        {
            return dreal.remquo(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Double, Int32> remquo(dynamic x, dynamic y)
        {
            return dreal.remquo(x, y);
        }

        #endregion



        #region Functions related to mantissa width and exponent range


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/epsilon/*' />
        public static Double epsilon()
        {
            return dreal.epsilon();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Double ulp(Double x)
        {
            return dreal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Double ulp(dynamic x)
        {
            return dreal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/maxvalue/*' />
        public static Double maxvalue()
        {
            return dreal.maxvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/lowestvalue/*' />
        public static Double lowestvalue()
        {
            return dreal.lowestvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/minposvalue/*' />
        public static Double minposvalue()
        {
            return dreal.minposvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Double nextafter(Double x, Double y)
        {
            return dreal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Double nextafter(dynamic x, dynamic y)
        {
            return dreal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Double nextabove(Double x)
        {
            return dreal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Double nextabove(dynamic x)
        {
            return dreal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Double nextbelow(Double x)
        {
            return dreal.nextbelow(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Double nextbelow(dynamic x)
        {
            return dreal.nextbelow(x);
        }


        #endregion



        #region Mathematical Constants


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/degree/*' />
        public static Double degree()
        {
            return dreal.degree();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phi/*' />
        public static Double phi()
        {
            return dreal.phi();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln2/*' />
        public static Double ln2()
        {
            return dreal.ln2();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln10/*' />
        public static Double ln10()
        {
            return dreal.ln10();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pi/*' />
        public static Double pi()
        {
            return dreal.pi();
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/e/*' />
        public static Double e()
        {
            return dreal.e();
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/egamma/*' />
        public static Double egamma()
        {
            return dreal.egamma();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/apery/*' />
        public static Double apery()
        {
            return dreal.apery();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/catalan/*' />
        public static Double catalan()
        {
            return dreal.catalan();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/glaisher/*' />
        public static Double glaisher()
        {
            return dreal.glaisher();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/khinchin/*' />
        public static Double khinchin()
        {
            return dreal.khinchin();
        }


        #endregion




        #endregion






        #region Flint Basic Functions



        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Double abs(Double x)
        {
            return Math.Abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Double abs(dynamic x)
        {
            return abs(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Double fabs(Double x)
        {
            return Math.Abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Double fabs(dynamic x)
        {
            return fabs(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Double sign(Double x)
        {
            return Math.Sign(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Double sign(dynamic x)
        {
            return sign(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Double real(Double x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Double real(dynamic x)
        {
            return real(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Double imag(Double x)
        {
            return 0.0;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Double imag(dynamic x)
        {
            return 0.0;
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Double phase(Double x)
        {
            return dreal.phase(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Double phase(dynamic x)
        {
            return dreal.phase(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Double conj(Double x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Double conj(dynamic x)
        {
            return conj(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Double, Double> polar(Double x)
        {
            return new Tuple<Double, Double>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Double, Double> polar(dynamic x)
        {
            return polar(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static Complex rect(Double r, Double phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static Complex rect(dynamic r, dynamic phi)
        {
            return rect(dreal.t(r), dreal.t(phi));
        }





        #endregion



        #region Roots and quadratic, cubic, and quartic 



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Double sqrt(Double x)
        {
            ArbPrec.Init();
            Double res = 0.0;
            Lib_FReal_Arb_Sqrt(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Sqrt(ref Double res, ref Double x);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Double sqrt(dynamic x)
        {
            return sqrt(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Double rsqrt(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Rsqrt(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Rsqrt(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Double rsqrt(dynamic x)
        {
            return rsqrt(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Double cbrt(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Cbrt(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Cbrt(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Double cbrt(dynamic x)
        {
            return cbrt(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Double sqrt1pm1(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Sqrt1pm1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Sqrt1pm1(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Double sqrt1pm1(dynamic x)
        {
            return sqrt1pm1(dreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Double root_si(Double x, Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Root_ui(ref res, ref x, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Root_ui(ref Double res, ref Double x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Double root_si(dynamic x, Int32 n)
        {
            return root_si(dreal.t(x), n);
        }




        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Double exp(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Exp(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Exp(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Double exp(dynamic x)
        {
            return exp(dreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static Complex expj(Double x)
        {
            return dflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static Complex expj(dynamic x)
        {
            return dflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static Complex expjpi(Double x)
        {
            return dflintc.expjpi(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static Complex expjpi(dynamic x)
        {
            return dflintc.expjpi(x);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Double exp10(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Exp10(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Exp10(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Double exp10(dynamic x)
        {
            return exp10(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Double exp2(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Exp2(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Exp2(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Double exp2(dynamic x)
        {
            return exp2(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Double expm1(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Expm1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Expm1(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Double expm1(dynamic x)
        {
            return expm1(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Double exp10m1(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Exp10m1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Exp10m1(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Double exp10m1(dynamic x)
        {
            return exp10m1(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Double exp2m1(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Exp2m1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Exp2m1(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Double exp2m1(dynamic x)
        {
            return exp2m1(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Double exprel(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_ExpRel(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_ExpRel(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Double exprel(dynamic x)
        {
            return exprel(dreal.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Double logbase(Double x, Double b)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Logbase(ref res, ref x, ref b);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Logbase(ref Double res, ref Double x, ref Double b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Double logbase(dynamic x, dynamic b)
        {
            return logbase(dreal.t(x), dreal.t(b));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Double log(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Log(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Log(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Double log(dynamic x)
        {
            return log(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Double log10(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Log10(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Log10(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Double log10(dynamic x)
        {
            return log10(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Double log2(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Log2(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Log2(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Double log2(dynamic x)
        {
            return log2(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Double log1p(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Log1p(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Log1p(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Double log1p(dynamic x)
        {
            return log1p(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Double log10p1(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Log10p1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Log10p1(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Double log10p1(dynamic x)
        {
            return log10p1(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Double log2p1(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Log2p1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Log2p1(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Double log2p1(dynamic x)
        {
            return log2p1(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Double log1mexp(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Log1mexp(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Log1mexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Log1mexp(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Double log1mexp(dynamic x)
        {
            return log1mexp(dreal.t(x));
        }





        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Double sqr(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Square(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Square(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Double sqr(dynamic x)
        {
            return sqr(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Double cube(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Cube(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Cube(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Double cube(dynamic x)
        {
            return cube(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Double hypot(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypot(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypot(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Double hypot(dynamic x, dynamic y)
        {
            return hypot(dreal.t(x), dreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powi/*' />
        public static Double pow_si(Double x, Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Pow_si(ref res, ref x, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Pow_si(ref Double res, ref Double x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Double pow_si(dynamic x, Int32 n)
        {
            return pow_si(dreal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Double compound_si(Double x, Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Compound_si(ref res, ref x, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Compound_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Compound_si(ref Double res, ref Double x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Double compound_si(dynamic x, Int32 n)
        {
            return compound_si(dreal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Double pow(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Pow(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Pow(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Double pow(dynamic x, dynamic y)
        {
            return pow(dreal.t(x), dreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Double powm1(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Powm1(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Powm1(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Double powm1(dynamic x, dynamic y)
        {
            return powm1(dreal.t(x), dreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Double pow1p(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Pow1p(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Pow1p(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Double pow1p(dynamic x, dynamic y)
        {
            return pow1p(dreal.t(x), dreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Double pow1pm1(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Pow1pm1(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Pow1pm1(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Double pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(dreal.t(x), dreal.t(y));
        }




        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Double sin(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Sin(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Sin(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Double sin(dynamic x)
        {
            return sin(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Double cos(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Cos(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Cos(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Double cos(dynamic x)
        {
            return cos(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Double tan(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Tan(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Tan(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Double tan(dynamic x)
        {
            return tan(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Double cot(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Cot(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Cot(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Double cot(dynamic x)
        {
            return cot(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Double sec(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Sec(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Sec(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Double sec(dynamic x)
        {
            return sec(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Double csc(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Csc(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Csc(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Double csc(dynamic x)
        {
            return csc(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Double sinc(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Sinc(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Sinc(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Double sinc(dynamic x)
        {
            return sinc(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Double sinpi(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_SinPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_SinPi(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Double sinpi(dynamic x)
        {
            return sinpi(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Double cospi(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_CosPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_CosPi(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Double cospi(dynamic x)
        {
            return cospi(dreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Double tanpi(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_TanPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_TanPi(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Double tanpi(dynamic x)
        {
            return tanpi(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Double cotpi(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_CotPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_CotPi(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Double cotpi(dynamic x)
        {
            return cotpi(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Double cscpi(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_SinPi(ref res, ref x);
            return 1 / res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Double cscpi(dynamic x)
        {
            return cscpi(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Double secpi(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_CosPi(ref res, ref x);
            return 1 / res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Double secpi(dynamic x)
        {
            return secpi(dreal.t(x));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Double sincpi(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_SincPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_SincPi(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Double sincpi(dynamic x)
        {
            return sincpi(dreal.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Double sinh(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Sinh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Sinh(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Double sinh(dynamic x)
        {
            return sinh(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Double cosh(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Cosh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Cosh(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Double cosh(dynamic x)
        {
            return cosh(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Double tanh(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Tanh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Tanh(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Double tanh(dynamic x)
        {
            return tanh(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Double csch(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Csch(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Csch(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Double csch(dynamic x)
        {
            return csch(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Double sech(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Sech(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Sech(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Double sech(dynamic x)
        {
            return sech(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Double coth(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Coth(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Coth(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Double coth(dynamic x)
        {
            return coth(dreal.t(x));
        }




        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Double asin(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Asin(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Asin(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Double asin(dynamic x)
        {
            return asin(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Double acos(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Acos(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Acos(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Double acos(dynamic x)
        {
            return acos(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Double atan2(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Atan2(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Atan2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Atan2(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Double atan2(dynamic x, dynamic y)
        {
            return atan2(dreal.t(x), dreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Double atan(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Atan(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Atan(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Double atan(dynamic x)
        {
            return atan(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Double acsc(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Acsc(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Acsc(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Double acsc(dynamic x)
        {
            return acsc(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Double asec(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Asec(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Asec(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Double asec(dynamic x)
        {
            return asec(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Double acot(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Acot(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Acot(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Double acot(dynamic x)
        {
            return acot(dreal.t(x));
        }



        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Double asinh(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Asinh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Asinh(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Double asinh(dynamic x)
        {
            return asinh(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Double acosh(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Acosh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Acosh(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Double acosh(dynamic x)
        {
            return acosh(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Double atanh(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Atanh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Atanh(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Double atanh(dynamic x)
        {
            return atanh(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Double acsch(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Acsch(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Acsch(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Double acsch(dynamic x)
        {
            return acsch(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Double asech(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Asech(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Asech(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Double asech(dynamic x)
        {
            return asech(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Double acoth(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Acoth(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Acoth(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Double acoth(dynamic x)
        {
            return acoth(dreal.t(x));
        }



        #endregion



        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Double gamma(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Gamma(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Gamma(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Double gamma(dynamic x)
        {
            return gamma(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Double rgamma(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Rgamma(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Rgamma(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Double rgamma(dynamic x)
        {
            return rgamma(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Double lgamma(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Lgamma(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Lgamma(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Double lgamma(dynamic x)
        {
            return lgamma(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Double rising_factorial(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_RisingFactorial(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_RisingFactorial(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Double rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(dreal.t(x), dreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Double beta(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Beta(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Beta(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Double beta(dynamic x, dynamic y)
        {
            return beta(dreal.t(x), dreal.t(y));
        }








        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Double gamma1pm1(Double x)
        {
            return aflint.DRealViaArbS1(aflint.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Double gamma1pm1(dynamic x)
        {
            return gamma1pm1(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Double factorial(Double x)
        {
            return aflint.DRealViaArbS1(aflint.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Double factorial(dynamic x)
        {
            return factorial(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Double doublefactorial(Double x)
        {
            return aflint.DRealViaArbS1(aflint.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Double doublefactorial(dynamic x)
        {
            return doublefactorial(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Double falling_factorial(Double a, Double n)
        {
            return aflint.DRealViaArbS2(aflint.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Double falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(dreal.t(a), dreal.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Double gamma_ratio(Double a, Double b)
        {
            return aflint.DRealViaArbS2(aflint.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Double gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(dreal.t(a), dreal.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Double gamma_delta_ratio(Double a, Double delta)
        {
            return aflint.DRealViaArbS2(aflint.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Double gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(dreal.t(a), dreal.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Double binomial(Double n, Double k)
        {
            return aflint.DRealViaArbS2(aflint.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Double binomial(dynamic n, dynamic k)
        {
            return binomial(dreal.t(n), dreal.t(k));
        }








        #endregion




        #region Miscellaneous



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Double lambert_w0(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_LambertW0(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_LambertW0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_LambertW0(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Double lambert_w0(dynamic x)
        {
            return lambert_w0(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Double lambert_wm1(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_LambertWm1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_LambertWm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_LambertWm1(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Double lambert_wm1(dynamic x)
        {
            return lambert_wm1(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static Complex lambert_wk(Double x, int k)
        {
            return dflintc.lambert_wk(dcplx.t(x), k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static Complex lambert_wk(dynamic x, int k)
        {
            return lambert_wk(dreal.t(x), k);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Double agm(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Agm(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Agm(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Double agm(dynamic x, dynamic y)
        {
            return agm(dreal.t(x), dreal.t(y));
        }







        #endregion





        #endregion




        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Double m_elliptic_k(Double m)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_MEllipticK(ref res, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_MEllipticK(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Double m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Double m_elliptic_e(Double m)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_MEllipticE(ref res, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_MEllipticE(ref Double res, ref Double m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Double m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Double m_elliptic_pi(Double n, Double m)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_MEllipticPi(ref res, ref n, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_MEllipticPi(ref Double res, ref Double n, ref Double m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Double m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(dreal.t(x), dreal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Double m_elliptic_f(Double phi, Double m)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_MEllipticF(ref res, ref phi, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_MEllipticF(ref Double res, ref Double phi, ref Double m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Double m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(dreal.t(phi), dreal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Double m_elliptic_e_inc(Double phi, Double m)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_MEllipticEInc(ref res, ref phi, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_MEllipticEInc(ref Double res, ref Double phi, ref Double m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Double m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(dreal.t(phi), dreal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Double m_elliptic_pi_inc(Double n, Double phi, Double m)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_MEllipticPiInc(ref res, ref n, ref phi, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_MEllipticPiInc(ref Double res, ref Double n, ref Double phi, ref Double m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Double m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(dreal.t(n), dreal.t(phi), dreal.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Double elliptic_k(Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_EllipticK(ref res, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_EllipticK(ref Double res, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Double elliptic_k(dynamic k)
        {
            return elliptic_k(dreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Double elliptic_e(Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_EllipticE(ref res, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_EllipticE(ref Double res, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Double elliptic_e(dynamic k)
        {
            return elliptic_e(dreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Double elliptic_pi(Double n, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_EllipticPi(ref res, ref n, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_EllipticPi(ref Double res, ref Double n, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Double elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(dreal.t(n), dreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Double elliptic_f(Double phi, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_EllipticF(ref res, ref phi, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_EllipticF(ref Double res, ref Double phi, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Double elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(dreal.t(phi), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Double elliptic_e_inc(Double phi, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_EllipticEInc(ref res, ref phi, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_EllipticEInc(ref Double res, ref Double phi, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Double elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(dreal.t(phi), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Double elliptic_pi_inc(Double n, Double phi, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_EllipticPiInc(ref res, ref n, ref phi, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_EllipticPiInc(ref Double res, ref Double n, ref Double phi, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Double elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(dreal.t(n), dreal.t(phi), dreal.t(k));
        }



        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Double elliptic_rc(Double x, Double y)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Elliptic_RC(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Elliptic_RC(ref Double res, ref Double x, ref Double y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Double elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(dreal.t(x), dreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Double elliptic_rf(Double x, Double y, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Elliptic_RF(ref res, ref x, ref y, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Elliptic_RF(ref Double res, ref Double x, ref Double y, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Double elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(dreal.t(x), dreal.t(y), dreal.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Double elliptic_rg(Double x, Double y, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Elliptic_RG(ref res, ref x, ref y, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Elliptic_RG(ref Double res, ref Double x, ref Double y, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Double elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(dreal.t(x), dreal.t(y), dreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Double elliptic_rd(Double x, Double y, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Elliptic_RD(ref res, ref x, ref y, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Elliptic_RD(ref Double res, ref Double x, ref Double y, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Double elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(dreal.t(x), dreal.t(y), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Double elliptic_rj(Double x, Double y, Double z, Double w)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Elliptic_RJ(ref res, ref x, ref y, ref z, ref w);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Elliptic_RJ(ref Double res, ref Double x, ref Double y, ref Double z, ref Double w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Double elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(dreal.t(x), dreal.t(y), dreal.t(z), dreal.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Double jacobi_theta1(Double x, Double q)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Theta1Q(ref res, ref x, ref q);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Theta1Q(ref Double res, ref Double x, ref Double q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Double jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(dreal.t(x), dreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Double jacobi_theta2(Double x, Double q)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Theta2Q(ref res, ref x, ref q);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Theta2Q(ref Double res, ref Double x, ref Double q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Double jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(dreal.t(x), dreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Double jacobi_theta3(Double x, Double q)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Theta3Q(ref res, ref x, ref q);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Theta3Q(ref Double res, ref Double x, ref Double q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Double jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(dreal.t(x), dreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Double jacobi_theta4(Double x, Double q)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Theta4Q(ref res, ref x, ref q);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_Theta4Q(ref Double res, ref Double x, ref Double q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Double jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(dreal.t(x), dreal.t(q));
        }




        #endregion



        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Double jacobi_sn(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiSN(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiSN(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Double jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Double jacobi_cn(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiCN(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiCN(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Double jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Double jacobi_dn(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiDN(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiDN(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Double jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Double jacobi_ns(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiNS(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiNS(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Double jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Double jacobi_nc(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiNC(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiNC(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Double jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Double jacobi_nd(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiND(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiND(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Double jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Double jacobi_sc(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiSC(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiSC(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Double jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Double jacobi_sd(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiSD(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiSD(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Double jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Double jacobi_dc(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiDC(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiDC(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Double jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Double jacobi_ds(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiDS(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiDS(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Double jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Double jacobi_cs(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiCS(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiCS(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Double jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(dreal.t(x), dreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Double jacobi_cd(Double x, Double k)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiCD(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FReal_Arb_JacobiCD(ref Double res, ref Double x, ref Double k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Double jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(dreal.t(x), dreal.t(k));
        }








        #endregion



        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Double lerch_phi(Double s, Double z, Double a)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_LerchPhi(ref res, ref s, ref z, ref a);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_LerchPhi(ref Double res, ref Double s, ref Double z, ref Double a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Double lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(dreal.t(s), dreal.t(z), dreal.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static Complex lerch_zeta(Double lambda1, Double alpha, Double s)
        {
            var res = dflintc.lerch_zeta(lambda1, alpha, s);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static Complex lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(dreal.t(lambda1), dreal.t(alpha), dreal.t(s));
        }






        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Double polygamma(Double s, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Polygamma(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Polygamma(ref Double res, ref Double s, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Double polygamma(dynamic s, dynamic z)
        {
            return polygamma(dreal.t(s), dreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Double trigamma(Double x)
        {
            return polygamma(1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Double trigamma(dynamic x)
        {
            return trigamma(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Double digamma(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Digamma(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Digamma(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Double digamma(dynamic x)
        {
            return digamma(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Double harmonic(Double x)
        {
            Complex res = dflintc.harmonic(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Double harmonic(dynamic x)
        {
            return harmonic(dreal.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Double polylog(Double s, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Polylog(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Polylog(ref Double res, ref Double s, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Double polylog(dynamic s, dynamic z)
        {
            return polylog(dreal.t(s), dreal.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Double trilog(Double x)
        {
            Complex res = dflintc.trilog(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Double trilog(dynamic x)
        {
            return trilog(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Double dilog(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Dilog(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Dilog(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Double dilog(dynamic x)
        {
            return dilog(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Double clausen_sin(Double s, Double z)
        {
            Complex res = dflintc.clausen_sin(s, z);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Double clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Double clausen_cos(Double s, Double z)
        {
            Complex res = dflintc.clausen_cos(s, z);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Double clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Double clausen2(Double x)
        {
            return clausen_sin(dreal.t(2), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Double clausen2(dynamic x)
        {
            return clausen_sin(dreal.t(2), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Double bose_einstein(Double s, Double z)
        {
            Complex res = dflintc.bose_einstein(s, z);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Double bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Double fermi_dirac(Double s, Double z)
        {
            Complex res = dflintc.fermi_dirac(s, z);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Double fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Double legendre_chi(Double s, Double z)
        {
            Complex res = dflintc.legendre_chi(s, z);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Double legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Double inverse_tan_integral(Double s, Double z)
        {
            Complex res = dflintc.inverse_tan_integral(s, z);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Double inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(dreal.t(s), dreal.t(z));
        }








        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Double hurwitz_zeta(Double s, Double a)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_HurwitzZeta(ref res, ref s, ref a);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_HurwitzZeta(ref Double res, ref Double s, ref Double a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Double hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(dreal.t(s), dreal.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Double harmonic2(Double z, Double r)
        {
            Complex res = dflintc.harmonic2(z, r);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Double harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(dreal.t(z), dreal.t(r));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Double bernoulli(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Bernoulli_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Bernoulli_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Bernoulli_ui(ref Double res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Double bernpoly(Double x, Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_BernoulliPoly_ui(ref res, ref x, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_BernoulliPoly_ui(ref Double res, ref Double x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Double bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(dreal.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulernum/*' />
        public static Double eulernum(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Euler_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Euler_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Euler_ui(ref Double res, Int32 n);






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Double eulerpoly(Double x, Int32 n)
        {
            Complex res = dflintc.eulerpoly(x, n);
            return res.Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Double eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(dreal.t(x), n);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Double barnes_g(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_BarnesG(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_BarnesG(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Double barnes_g(dynamic x)
        {
            return barnes_g(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Double logbarnes_g(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_LogBarnesG(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_LogBarnesG(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Double logbarnes_g(dynamic x)
        {
            return logbarnes_g(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Double hyperfactorial(Double x)
        {
            Complex res = dflintc.hyperfactorial(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Double hyperfactorial(dynamic x)
        {
            return hyperfactorial(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Double superfactorial(Double x)
        {
            Complex res = dflintc.superfactorial(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Double superfactorial(dynamic x)
        {
            return superfactorial(dreal.t(x));
        }







        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Double zeta(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Zeta(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Zeta(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Double zeta(dynamic x)
        {
            return zeta(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Double zetam1(Double x)
        {
            Complex res = dflintc.zetam1(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Double zetam1(dynamic x)
        {
            return zetam1(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Double hardy_theta(Double x)
        {
            Complex res = dflintc.hardy_theta(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Double hardy_theta(dynamic x)
        {
            return hardy_theta(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Double hardy_z(Double x)
        {
            Complex res = dflintc.hardy_z(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Double hardy_z(dynamic x)
        {
            return hardy_z(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Double riemann_xi(Double x)
        {
            Complex res = dflintc.riemann_xi(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Double riemann_xi(dynamic x)
        {
            return riemann_xi(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Double dirichlet_eta(Double x)
        {
            Complex res = dflintc.dirichlet_eta(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Double dirichlet_eta(dynamic x)
        {
            return dirichlet_eta(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Double dirichlet_etam1(Double x)
        {
            Complex res = dflintc.dirichlet_etam1(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Double dirichlet_etam1(dynamic x)
        {
            return dirichlet_etam1(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Double dirichlet_beta(Double x)
        {
            Complex res = dflintc.dirichlet_beta(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Double dirichlet_beta(dynamic x)
        {
            return dirichlet_beta(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Double dirichlet_lambda(Double x)
        {
            Complex res = dflintc.dirichlet_lambda(x);
            return res.Real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Double dirichlet_lambda(dynamic x)
        {
            return dirichlet_lambda(dreal.t(x));
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Double backlund_s(Double x)
        //{
        //    ArbPrec.Init(); Double res = 0.0;
        //    Lib_FReal_Arb_BacklundS(ref res, ref x);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_BacklundS", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FReal_Arb_BacklundS(ref Double res, ref Double x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Double backlund_s(dynamic x)
        //{
        //    return backlund_s(dreal.t(x));
        //}





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/grampoint/*' />
        //public static Double grampoint(Int32 n)
        //{
        //    ArbPrec.Init(); Double res = 0.0;
        //    Lib_FReal_Arb_GramPoint_ui(ref res, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_GramPoint_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FReal_Arb_GramPoint_ui(ref Double res, Int32 n);







        #endregion



        #region Additional numbertheoretic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bell/*' />
        public static Double bell(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Bell_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Bell_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Bell_ui(ref Double res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/partitions/*' />
        public static Double partitions(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Partitions_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Partitions_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Partitions_ui(ref Double res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/primorial/*' />
        public static Double primorial(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Primorial_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Primorial_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Primorial_ui(ref Double res, Int32 n);





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Double hyperg_0f1(Double a, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypgeom0F1(ref res, ref a, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypgeom0F1(ref Double res, ref Double a, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Double hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(dreal.t(a), dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Double hyperg_0f1r(Double a, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypgeom0F1r(ref res, ref a, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypgeom0F1r(ref Double res, ref Double a, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Double hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(dreal.t(a), dreal.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Double bessel_jv(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Double bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(dreal.t(nu), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Double bessel_yv(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Double bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(dreal.t(nu), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Double bessel_iv(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Double bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(dreal.t(nu), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Double bessel_kv(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Double bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(dreal.t(nu), dreal.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Double bessel_jv_prime(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Double bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(dreal.t(nu), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Double bessel_yv_prime(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Double bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(dreal.t(nu), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Double bessel_iv_prime(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Double bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(dreal.t(nu), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Double bessel_kv_prime(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Double bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(dreal.t(nu), dreal.t(x), scaled);
        }







        #endregion






        #region 0F1: Spherical Bessel functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Double sph_bessel_jn(Double n, Double x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (dreal.isnan(x)) return dreal.nan();
            if (dreal.isinf(x)) return dreal.zero();
            if (dreal.isneginf(x)) return dreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return dreal.one();
                    else return dreal.zero();
                }
                else
                {
                    if (n % 2 == 0) return dreal.neginf(); else return dreal.nan();
                }
            }
            return dflintc.sph_bessel_jn(n, x, scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Double sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(dreal.t(n), dreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Double sph_bessel_yn(Double n, Double x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (dreal.isnan(x)) return dreal.nan();
            if (dreal.isinf(x)) return dreal.zero();
            if (dreal.isneginf(x)) return dreal.zero();
            if (x == 0.0)
            {
                if (n < 0)
                {
                    if ((n == -1)) return dreal.one();
                    else return dreal.zero();
                }
                else
                {
                    if (n % 2 != 0) return dreal.neginf(); else return dreal.nan();
                }
            }
            return dflintc.sph_bessel_yn(n, x, scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Double sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Double sph_bessel_in(Double n, Double x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (dreal.isnan(x)) return dreal.nan();
            if (dreal.isinf(x)) return dreal.inf();
            if (dreal.isneginf(x)) return dreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return dreal.one();
                    else return dreal.zero();
                }
                else
                {
                    if (n % 2 == 0) return dreal.neginf(); else return dreal.nan();
                }
            }
            return dflintc.sph_bessel_in(n, x, scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Double sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Double sph_bessel_kn(Double n, Double x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (dreal.isnan(x)) return dreal.nan();
            if (dreal.isinf(x)) return dreal.zero();
            if (dreal.isneginf(x)) return dreal.neginf();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if (n % 2 == 0) return dreal.nan(); else return dreal.inf();
                }
                else
                {
                    if (n % 2 == 0) return dreal.inf(); else return dreal.nan();
                }
            }
            return dflintc.sph_bessel_kn(n, x, scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Double sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(t(n), t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Double besselpoly(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.besselpoly, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Double besselpoly(dynamic nu, dynamic x, bool scaled = false)
        {
            return besselpoly(dreal.t(nu), dreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Double besseltheta(Double nu, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2Bool1(aflint.besseltheta, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Double besseltheta(dynamic nu, dynamic x, bool scaled = false)
        {
            return besseltheta(dreal.t(nu), dreal.t(x), scaled);
        }






        #endregion






        #region Spherical Bessel functions, first derivative




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Double sph_bessel_jn_prime(Double n, Double x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (dreal.isnan(x)) return dreal.nan();
            if (dreal.isinf(x)) return dreal.zero();
            if (dreal.isneginf(x)) return dreal.zero();
            if (x == 0.0)
            {
                if (n == 1) return 1 / dreal.t(3);
                if (n >= 0) return dreal.zero();
                else
                {
                    if (n % 2 != 0) return dreal.neginf(); else return dreal.nan();
                }
            }
            return dflintc.sph_bessel_jn_prime(n, x, scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Double sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Double sph_bessel_yn_prime(Double n, Double x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (dreal.isnan(x)) return dreal.nan();
            if (dreal.isinf(x)) return dreal.zero();
            if (dreal.isneginf(x)) return dreal.zero();
            if (x == 0.0)
            {
                if (n == -2) return -1 / dreal.t(3);
                if (n < 0) return dreal.zero();
                else
                {
                    if (n % 2 == 0) return dreal.inf(); else return dreal.nan();
                }
            }
            return dflintc.sph_bessel_yn_prime(n, x, scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Double sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Double sph_bessel_in_prime(Double n, Double x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (dreal.isnan(x)) return dreal.nan();
            if (dreal.isinf(x)) return dreal.inf();
            if (dreal.isneginf(x))
            {
                if (n % 2 == 0) return dreal.neginf(); else return dreal.inf();
            }
            if (x == 0.0)
            {
                if (n == 0) return dreal.zero();
                if (n < 0)
                {
                    if (n % 2 != 0) return dreal.neginf(); else return dreal.nan();
                }
            }
            return dflintc.sph_bessel_in_prime(n, x, scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Double sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Double sph_bessel_kn_prime(Double n, Double x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (dreal.isnan(x)) return dreal.nan();
            if (dreal.isinf(x)) return dreal.zero();
            if (dreal.isneginf(x)) return dreal.neginf();
            if (x == 0.0)
            {
                if (((n >= 0) && (n % 2 == 0)) || ((n < 0) && (n % 2 != 0))) return dreal.neginf();
                else return dreal.nan();
            }
            return dflintc.sph_bessel_kn_prime(n, x, scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Double sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(t(n), t(x), scaled);
        }





        #endregion







        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static Complex hankel_h1(Double v, Double x)
        {
            return bessel_jv(v, x) + dcplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static Complex hankel_h1(dynamic v, dynamic x)
        {
            return hankel_h1(dreal.t(v), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static Complex hankel_h2(Double v, Double x)
        {
            return bessel_jv(v, x) - dcplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static Complex hankel_h2(dynamic v, dynamic x)
        {
            return hankel_h2(dreal.t(v), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static Complex sph_hankel_h1(int n, Double x)
        {
            return sph_bessel_jn(n, x) + dcplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static Complex sph_hankel_h1(int n, dynamic x)
        {
            return sph_hankel_h1(n, dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static Complex sph_hankel_h2(int n, Double x)
        {
            return sph_bessel_jn(n, x) - dcplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static Complex sph_hankel_h2(int n, dynamic x)
        {
            return sph_hankel_h2(n, dreal.t(x));
        }






        #endregion






        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Double airy_ai(Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS1Bool1(aflint.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Double airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Double airy_ai_prime(Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS1Bool1(aflint.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Double airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Double airy_bi(Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS1Bool1(aflint.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Double airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Double airy_bi_prime(Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS1Bool1(aflint.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Double airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(dreal.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        public static Double airy_ai_zero(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_AiryAiZero(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_AiryAiZero(ref Double res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        public static Double airy_ai_prime_zero(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_AiryAiPrimeZero(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_AiryAiPrimeZero(ref Double res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        public static Double airy_bi_zero(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_AiryBiZero(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_AiryBiZero(ref Double res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        public static Double airy_bi_prime_zero(Int32 n)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_AiryBiPrimeZero(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_AiryBiPrimeZero(ref Double res, Int32 n);



        #endregion





        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Double kelvin_ber(Double v, Double x, bool scaled = false)
        {
            return dflintc.kelvin_ber(dcplx.t(v), dcplx.t(x), scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Double kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(dreal.t(v), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Double kelvin_bei(Double v, Double x, bool scaled = false)
        {
            return dflintc.kelvin_bei(dcplx.t(v), dcplx.t(x), scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Double kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(dreal.t(v), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Double kelvin_ker(Double v, Double x, bool scaled = false)
        {
            return dflintc.kelvin_ker(dcplx.t(v), dcplx.t(x), scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Double kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(dreal.t(v), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Double kelvin_kei(Double v, Double x, bool scaled = false)
        {
            return dflintc.kelvin_kei(dcplx.t(v), dcplx.t(x), scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Double kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(dreal.t(v), dreal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Double kelvin_ber_prime(Double v, Double x, bool scaled = false)
        {
            return dflintc.kelvin_ber_prime(dcplx.t(v), dcplx.t(x), scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Double kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(dreal.t(v), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Double kelvin_bei_prime(Double v, Double x, bool scaled = false)
        {
            return dflintc.kelvin_bei_prime(dcplx.t(v), dcplx.t(x), scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Double kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(dreal.t(v), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Double kelvin_ker_prime(Double v, Double x, bool scaled = false)
        {
            return dflintc.kelvin_ker_prime(dcplx.t(v), dcplx.t(x), scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Double kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(dreal.t(v), dreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Double kelvin_kei_prime(Double v, Double x, bool scaled = false)
        {
            return dflintc.kelvin_kei_prime(dcplx.t(v), dcplx.t(x), scaled).Real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Double kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(dreal.t(v), dreal.t(x), scaled);
        }








        #endregion












        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Double hyperg_1f1(Double a, Double b, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypgeom1F1(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypgeom1F1(ref Double res, ref Double a, ref Double b, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Double hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(dreal.t(a), dreal.t(b), dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Double hyperg_1f1r(Double a, Double b, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypgeom1F1r(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypgeom1F1r(ref Double res, ref Double a, ref Double b, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Double hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(dreal.t(a), dreal.t(b), dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Double hyperg_u(Double a, Double b, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_HypgeomU(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_HypgeomU(ref Double res, ref Double a, ref Double b, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Double hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(dreal.t(a), dreal.t(b), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Double hermite_h(Double n, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_HermiteH(ref res, ref n, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_HermiteH(ref Double res, ref Double n, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Double hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(dreal.t(n), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Double hermite_he(Double n, Double x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Double hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(dreal.t(n), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Double laguerre_l(Double n, Double m, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_LaguerreL(ref res, ref n, ref m, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_LaguerreL(ref Double res, ref Double n, ref Double m, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Double laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(dreal.t(n), dreal.t(m), dreal.t(x));
        }




        #endregion




        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Double gamma_upper(Double s, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_GammaUpper(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_GammaUpper(ref Double res, ref Double s, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Double gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Double gamma_q(Double s, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_GammaQ(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_GammaQ(ref Double res, ref Double s, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Double gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Double gamma_lower(Double s, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_GammaLower(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_GammaLower(ref Double res, ref Double s, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Double gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Double gamma_p(Double s, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_GammaP(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_GammaP(ref Double res, ref Double s, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Double gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(dreal.t(s), dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Double gamma_p_prime(Double s, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_GammaPPrime(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_GammaPPrime(ref Double res, ref Double s, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Double gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(dreal.t(s), dreal.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Double erf(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Erf(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Erf(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Double erf(dynamic x)
        {
            return erf(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Double erfc(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Erfc(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Erfc(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Double erfc(dynamic x)
        {
            return erfc(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Double erf_inv(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Erfinv(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Erfinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Erfinv(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Double erf_inv(dynamic x)
        {
            return erf_inv(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Double erfc_inv(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Erfcinv(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Erfcinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Erfcinv(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Double erfc_inv(dynamic x)
        {
            return erfc_inv(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Double erfi(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Erfi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Erfi(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Double erfi(dynamic x)
        {
            return erfi(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Double dawson(Double x)
        {
            return aflint.DRealViaArbS1(aflint.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Double dawson(dynamic x)
        {
            return dawson(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Double fresnel_s(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_FresnelS(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_FresnelS(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Double fresnel_s(dynamic x)
        {
            return fresnel_s(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Double fresnel_c(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_FresnelC(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_FresnelC(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Double fresnel_c(dynamic x)
        {
            return fresnel_c(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Double ndens(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Ndens(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Ndens(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Double ndens(dynamic x)
        {
            return ndens(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Double ndis(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Ndis(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Ndis(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Double ndis(dynamic x)
        {
            return ndis(dreal.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Double exp_integral_en(Double s, Double z)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_ExpIntegralE(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_ExpIntegralE(ref Double res, ref Double s, ref Double z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Double exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(dreal.t(s), dreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Double exp_integral_e1(Double z)
        {
            if (z < 0) return -exp_integral_ei(-z);
            else return exp_integral_en(dreal.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Double exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(dreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Double exp_integral_ei(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_ExpIntegralEi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_ExpIntegralEi(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Double exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Double sin_integral(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_SinIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_SinIntegral(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Double sin_integral(dynamic x)
        {
            return sin_integral(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Double cos_integral(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_CosIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_CosIntegral(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Double cos_integral(dynamic x)
        {
            return cos_integral(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Double sinh_integral(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_SinhIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_SinhIntegral(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Double sinh_integral(dynamic x)
        {
            return sinh_integral(dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Double cosh_integral(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_CoshIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_CoshIntegral(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Double cosh_integral(dynamic x)
        {
            return cosh_integral(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Double log_integral(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_LogIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_LogIntegral(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Double log_integral(dynamic x)
        {
            return log_integral(dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Double log_integral_offset(Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_LogIntegralOffset(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_LogIntegralOffset(ref Double res, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Double log_integral_offset(dynamic x)
        {
            return log_integral_offset(dreal.t(x));
        }



        #endregion





        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Double coulomb_f(Double l, Double eta, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_CoulombF(ref res, ref l, ref eta, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_CoulombF(ref Double res, ref Double l, ref Double eta, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Double coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(dreal.t(l), dreal.t(eta), dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Double coulomb_g(Double l, Double eta, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_CoulombG(ref res, ref l, ref eta, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_CoulombG(ref Double res, ref Double l, ref Double eta, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Double coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(dreal.t(l), dreal.t(eta), dreal.t(x));
        }



        #endregion



        #region 1F1: Whittaker functions




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Double whittaker_m(Double k, Double m, Double x)
        {
            return aflint.DRealViaArbS3(aflint.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Double whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(dreal.t(k), dreal.t(m), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Double whittaker_w(Double k, Double m, Double x)
        {
            return aflint.DRealViaArbS3(aflint.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Double whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(dreal.t(k), dreal.t(m), dreal.t(x));
        }





        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Double pcfd(Double n, Double x)
        {
            return aflint.DRealViaArbS2(aflint.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Double pcfd(dynamic n, dynamic x)
        {
            return pcfd(dreal.t(n), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Double pcfu(Double a, Double x)
        {
            return aflint.DRealViaArbS2(aflint.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Double pcfu(dynamic a, dynamic x)
        {
            return pcfu(dreal.t(a), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Double pcfv(Double a, Double x)
        {
            return aflint.DRealViaArbS2(aflint.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Double pcfv(dynamic a, dynamic x)
        {
            return pcfv(dreal.t(a), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Double pcfw(Double a, Double x)
        {
            return aflint.DRealViaArbS2(aflint.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Double pcfw(dynamic a, dynamic x)
        {
            return pcfw(dreal.t(a), dreal.t(x));
        }






        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Double hyperg_2f1(Double a, Double b, Double c, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypgeom2F1(ref res, ref a, ref b, ref c, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hyp2f1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypgeom2F1(ref Double res, ref Double a, ref Double b, ref Double c, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Double hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(dreal.t(a), dreal.t(b), dreal.t(c), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Double hyperg_2f1r(Double a, Double b, Double c, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypgeom2F1r(ref res, ref a, ref b, ref c, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hyp2f1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypgeom2F1r(ref Double res, ref Double a, ref Double b, ref Double c, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Double hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(dreal.t(a), dreal.t(b), dreal.t(c), dreal.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Double chebyshev_t(Double n, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_ChebyshevT(ref res, ref n, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_ChebyshevT(ref Double res, ref Double n, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Double chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(dreal.t(n), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Double chebyshev_u(Double n, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_ChebyshevU(ref res, ref n, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_ChebyshevU(ref Double res, ref Double n, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Double chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(dreal.t(n), dreal.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static Double chebyshev_v(Double n, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2(aflint.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Double chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(dreal.t(n), dreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static Double chebyshev_w(Double n, Double x, bool scaled = false)
        {
            return aflint.DRealViaArbS2(aflint.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Double chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(dreal.t(n), dreal.t(y));
        }








        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Double gegenbauer_c(Double n, Double m, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_GegenbauerC(ref res, ref n, ref m, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_GegenbauerC(ref Double res, ref Double n, ref Double m, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Double gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(dreal.t(n), dreal.t(m), dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Double jacobi_p(Double n, Double a, Double b, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_JacobiP(ref res, ref n, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_JacobiP(ref Double res, ref Double n, ref Double a, ref Double b, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Double jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(dreal.t(n), dreal.t(a), dreal.t(b), dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Double legendre_p(Double n, Double x)
        {
            return aflint.DRealViaArbS2(aflint.legendre_p, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_p/*' />
        public static Double legendre_p(dynamic n, dynamic y)
        {
            return legendre_p(dreal.t(n), dreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Double legendre_q(Double n, Double x)
        {
            return aflint.DRealViaArbS2(aflint.legendre_q, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_q/*' />
        public static Double legendre_q(dynamic n, dynamic y)
        {
            return legendre_q(dreal.t(n), dreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Double legendre_plm(Double n, Double m, Double x)
        {
            return aflint.DRealViaArbS3(aflint.legendre_plm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_plm/*' />
        public static Double legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(dreal.t(n), dreal.t(m), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Double legendre_qlm(Double n, Double m, Double x)
        {
            return aflint.DRealViaArbS3(aflint.legendre_qlm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_qlm/*' />
        public static Double legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(dreal.t(n), dreal.t(m), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_plm/*' />
        public static Double toroidal_plm(Double l, Double m, Double x)
        {
            return aflint.DRealViaArbS3(aflint.toroidal_plm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_plm/*' />
        public static Double toroidal_plm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_plm(dreal.t(l), dreal.t(m), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_qlm/*' />
        public static Double toroidal_qlm(Double l, Double m, Double x)
        {
            return aflint.DRealViaArbS3(aflint.toroidal_qlm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_qlm/*' />
        public static Double toroidal_qlm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_qlm(dreal.t(l), dreal.t(m), dreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static Complex spherical_y(Double n, Double m, Double theta, Double phi)
        {
            return dflintc.spherical_y(dcplx.t(n), dcplx.t(m), dcplx.t(theta), dcplx.t(phi));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static Complex spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(dreal.t(n), dreal.t(m), dreal.t(theta), dreal.t(phi));
        }









        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Double beta_lower(Double a, Double b, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_BetaLower(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_BetaLower(ref Double res, ref Double a, ref Double b, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Double beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(dreal.t(a), dreal.t(b), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Double ibeta(Double a, Double b, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Ibeta(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Ibeta(ref Double res, ref Double a, ref Double b, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Double ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(dreal.t(a), dreal.t(b), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Double ibetac(Double a, Double b, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Ibetac(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Ibetac(ref Double res, ref Double a, ref Double b, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Double ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(dreal.t(a), dreal.t(b), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Double ibeta_prime(Double a, Double b, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_IbetaPrime(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_IbetaPrime(ref Double res, ref Double a, ref Double b, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Double ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(dreal.t(a), dreal.t(b), dreal.t(x));
        }


        #endregion






        #region Hypergeometric Function 1F2, overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Double hyperg_1f2(Double a1, Double b1, Double b2, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypgeom1F2(ref res, ref a1, ref b1, ref b2, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypgeom1F2(ref Double res, ref Double a1, ref Double b1, ref Double b2, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Double hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(dreal.t(a1), dreal.t(b1), dreal.t(b2), dreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Double hyperg_1f2r(Double a1, Double b1, Double b2, Double x)
        {
            ArbPrec.Init(); Double res = 0.0;
            Lib_FReal_Arb_Hypgeom1F2r(ref res, ref a1, ref b1, ref b2, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FReal_Arb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FReal_Arb_Hypgeom1F2r(ref Double res, ref Double a1, ref Double b1, ref Double b2, ref Double x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Double hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(dreal.t(a1), dreal.t(b1), dreal.t(b2), dreal.t(x));
        }


        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Double airy_gi(Double x)
        {
            return aflint.DRealViaArbS1(aflint.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Double airy_gi(dynamic x)
        {
            return airy_gi(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Double airy_hi(Double x)
        {
            return aflint.DRealViaArbS1(aflint.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Double airy_hi(dynamic x)
        {
            return airy_hi(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Double airy_gi_prime(Double x)
        {
            return aflint.DRealViaArbS1(aflint.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Double airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Double airy_hi_prime(Double x)
        {
            return aflint.DRealViaArbS1(aflint.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Double airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(dreal.t(x));
        }


        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Double struve_h(Double v, Double x)
        {
            return aflint.DRealViaArbS2(aflint.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Double struve_h(dynamic v, dynamic x)
        {
            return struve_h(dreal.t(v), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Double struve_l(Double v, Double x)
        {
            return aflint.DRealViaArbS2(aflint.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Double struve_l(dynamic v, dynamic x)
        {
            return struve_l(dreal.t(v), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Double struve_k(Double v, Double x)
        {
            return aflint.DRealViaArbS2(aflint.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Double struve_k(dynamic v, dynamic x)
        {
            return struve_k(dreal.t(v), dreal.t(x));
        }


        public static Double struve_m(Double v, Double x)
        {
            return aflint.DRealViaArbS2(aflint.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static Double struve_m(dynamic v, dynamic x)
        {
            return struve_m(dreal.t(v), dreal.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Double anger_j(Double v, Double x)
        {
            return aflint.DRealViaArbS2(aflint.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Double anger_j(dynamic v, dynamic x)
        {
            return anger_j(dreal.t(v), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Double weber_e(Double v, Double x)
        {
            return aflint.DRealViaArbS2(aflint.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Double weber_e(dynamic v, dynamic x)
        {
            return weber_e(dreal.t(v), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Double lommel_s1(Double mu, Double nu, Double x)
        {
            return aflint.DRealViaArbS3(aflint.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Double lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(dreal.t(mu), dreal.t(nu), dreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Double lommel_s2(Double mu, Double nu, Double x)
        {
            return aflint.DRealViaArbS3(aflint.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Double lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(dreal.t(mu), dreal.t(nu), dreal.t(x));
        }


        #endregion



        #endregion


    }









    public class dflintc
    {


        /// <summary>
        /// Returns a new Complex using an ArbC number as input
        /// </summary>
        public static Complex t(ArbC x)
        {
            var res = new fcplx_t();
            Lib_FCplx_Set_Acb(res.mpPtr, x.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Set_Acb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Set_Acb(IntPtr res, IntPtr x);


        /// <summary>
        /// Returns a new Complex using an MpfrC number as input
        /// </summary>
        public static Complex t(MpfrC x)
        {
            var res = new fcplx_t();
            Lib_FCplx_Set_MpfrC(res.mpPtr, x.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Set_MpfrC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Set_MpfrC(IntPtr res, IntPtr x);



        public static String fmt(Complex z)
        {
            return dcplx.fmt(z);
        }

        public static String fmt(Double x)
        {
            return dreal.fmt(x);
        }


        public static String fmt(dynamic z)
        {
            return fmt(dcplx.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "dflintc"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "dflintc"; }
        }


        public static dflint realctx
        {
            get { return new dflint(); }
        }







        #region Flint Basic Functions



        #region Complex components


        public static Double abs(Complex z)
        {
            return dcplx.abs(z);
        }


        public static Double abs(dynamic z)
        {
            return dcplx.abs(z);
        }


        public static Double fabs(Complex z)
        {
            return dcplx.fabs(z);
        }


        public static Double fabs(dynamic z)
        {
            return dcplx.fabs(z);
        }


        public static Complex sign(Complex z)
        {
            return dcplx.sign(z);
        }


        public static Complex sign(dynamic z)
        {
            return dcplx.sign(z);
        }


        public static Double real(Complex z)
        {
            return z.Real;
        }


        public static Double real(dynamic z)
        {
            return real(dcplx.t(z));
        }



        public static Double imag(Complex z)
        {
            return z.Imaginary;
        }


        public static Double imag(dynamic z)
        {
            return imag(dcplx.t(z));
        }




        public static Double phase(Complex z)
        {
            return dcplx.phase(z);
        }


        public static Double phase(dynamic z)
        {
            return dcplx.phase(z);
        }



        public static Complex conj(Complex z)
        {
            return dcplx.conj(z);
        }


        public static Complex conj(dynamic z)
        {
            return dcplx.conj(z);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Double, Double> polar(Complex x)
        {
            return new Tuple<Double, Double>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Double, Double> polar(dynamic x)
        {
            return polar(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static Complex rect(Double r, Double phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static Complex rect(dynamic r, dynamic phi)
        {
            return rect(dreal.t(r), dreal.t(phi));
        }






        #endregion




        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Complex sqrt(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Sqrt(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Sqrt(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Complex sqrt(dynamic z1)
        {
            return sqrt(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Complex rsqrt(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Rsqrt(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Rsqrt(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Complex rsqrt(dynamic z1)
        {
            return rsqrt(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Complex cbrt(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Cbrt(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Cbrt(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Complex cbrt(dynamic z1)
        {
            return cbrt(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Complex sqrt1pm1(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Sqrt1pm1(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Sqrt1pm1(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Complex sqrt1pm1(dynamic z1)
        {
            return sqrt1pm1(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static Complex unitroot(Int32 n)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            Lib_FCplx_Acb_UnitRoot_ui(res.mpPtr, n);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_UnitRoot_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_UnitRoot_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Complex root_si(Complex x, Int32 n)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Root_ui(res.mpPtr, x_.mpPtr, n);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Complex root_si(dynamic x, Int32 n)
        {
            return root_si(dcplx.t(x), n);
        }





        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Complex exp(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Exp(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Exp(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Complex exp(dynamic z1)
        {
            return exp(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static Complex expj(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Expj(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Expj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Expj(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static Complex expj(dynamic z1)
        {
            return expj(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static Complex expjpi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Expjpi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Expjpi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Expjpi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static Complex expjpi(dynamic z1)
        {
            return expjpi(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Complex exp10(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Exp10(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Exp10(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Complex exp10(dynamic z1)
        {
            return exp10(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Complex exp2(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Exp2(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Exp2(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Complex exp2(dynamic z1)
        {
            return exp2(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Complex expm1(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Expm1(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Expm1(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Complex expm1(dynamic z1)
        {
            return expm1(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Complex exp10m1(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Exp10m1(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Exp10m1(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Complex exp10m1(dynamic z1)
        {
            return exp10m1(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Complex exp2m1(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Exp2m1(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Exp2m1(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Complex exp2m1(dynamic z1)
        {
            return exp2m1(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Complex exprel(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_ExpRel(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_ExpRel(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Complex exprel(dynamic z1)
        {
            return exprel(dcplx.t(z1));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Complex logbase(Complex x, Complex b)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var b_ = new fcplx_t(b);
            Lib_FCplx_Acb_Logbase(res.mpPtr, x_.mpPtr, b_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Logbase(IntPtr res, IntPtr x, IntPtr b);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Complex logbase(dynamic x, dynamic b)
        {
            return logbase(dcplx.t(x), dcplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Complex log(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Log(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Log(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Complex log(dynamic z1)
        {
            return log(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Complex log10(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Log10(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Log10(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Complex log10(dynamic z1)
        {
            return log10(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Complex log2(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Log2(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Log2(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Complex log2(dynamic z1)
        {
            return log2(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Complex log1p(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Log1p(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Log1p(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Complex log1p(dynamic z1)
        {
            return log1p(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Complex log10p1(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Log10p1(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Log10p1(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Complex log10p1(dynamic z1)
        {
            return log10p1(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Complex log2p1(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Log2p1(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Log2p1(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Complex log2p1(dynamic z1)
        {
            return log2p1(dcplx.t(z1));
        }





        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Complex sqr(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Square(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Square(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Complex sqr(dynamic z1)
        {
            return sqr(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Complex cube(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Cube(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Cube(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Complex cube(dynamic z1)
        {
            return cube(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Complex hypot(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_Hypot(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypot(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Complex hypot(dynamic x, dynamic y)
        {
            return hypot(dcplx.t(x), dcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Complex pow_si(Complex x, Int32 n)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Pow_si(res.mpPtr, x_.mpPtr, n);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Pow_si(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Complex pow_si(dynamic x, Int32 n)
        {
            return pow_si(dcplx.t(x), n);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Complex compound_si(Complex x, Int32 n)
        {
            return pow1p(dcplx.t(x), dcplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Complex compound_si(dynamic x, Int32 n)
        {
            return pow1p(dcplx.t(x), dcplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Complex pow(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_Pow(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Pow(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Complex pow(dynamic x, dynamic y)
        {
            return pow(dcplx.t(x), dcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Complex powm1(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_Powm1(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Powm1(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Complex powm1(dynamic x, dynamic y)
        {
            return powm1(dcplx.t(x), dcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Complex pow1p(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_Pow1p(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Pow1p(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Complex pow1p(dynamic x, dynamic y)
        {
            return pow1p(dcplx.t(x), dcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Complex pow1pm1(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_Pow1pm1(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Complex pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(dcplx.t(x), dcplx.t(y));
        }


        #endregion



        #region Trigonometric and related functions, radians


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Complex sin(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Sin(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Sin(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Complex sin(dynamic z1)
        {
            return sin(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Complex cos(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Cos(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Cos(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Complex cos(dynamic z1)
        {
            return cos(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Complex tan(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Tan(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Tan(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Complex tan(dynamic z1)
        {
            return tan(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Complex cot(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Cot(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Cot(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Complex cot(dynamic z1)
        {
            return cot(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Complex sec(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Sec(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Sec(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Complex sec(dynamic z1)
        {
            return sec(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Complex csc(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Csc(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Csc(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Complex csc(dynamic z1)
        {
            return csc(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Complex sinc(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Sinc(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Sinc(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Complex sinc(dynamic z1)
        {
            return sinc(dcplx.t(z1));
        }



        #endregion



        #region Trigonometric and related functions, multiples of pi



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Complex sinpi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_SinPi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_SinPi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Complex sinpi(dynamic z1)
        {
            return sinpi(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Complex cospi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CosPi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CosPi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Complex cospi(dynamic z1)
        {
            return cospi(dcplx.t(z1));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Complex tanpi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_TanPi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_TanPi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Complex tanpi(dynamic z1)
        {
            return tanpi(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Complex cotpi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CotPi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CotPi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Complex cotpi(dynamic z1)
        {
            return cotpi(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Complex cscpi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CscPi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CscPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CscPi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Complex cscpi(dynamic z1)
        {
            return cscpi(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Complex secpi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_SecPi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_SecPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_SecPi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Complex secpi(dynamic z1)
        {
            return secpi(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Complex sincpi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_SincPi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_SincPi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Complex sincpi(dynamic z1)
        {
            return sincpi(dcplx.t(z1));
        }








        #endregion





        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Complex cosh(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Cosh(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Cosh(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Complex cosh(dynamic z1)
        {
            return cosh(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Complex sinh(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Sinh(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Sinh(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Complex sinh(dynamic z1)
        {
            return sinh(dcplx.t(z1));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Complex tanh(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Tanh(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Tanh(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Complex tanh(dynamic z1)
        {
            return tanh(dcplx.t(z1));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Complex csch(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Csch(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Csch(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Complex csch(dynamic z1)
        {
            return csch(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Complex sech(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Sech(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Sech(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Complex sech(dynamic z1)
        {
            return sech(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Complex coth(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Coth(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Coth(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Complex coth(dynamic z1)
        {
            return coth(dcplx.t(z1));
        }





        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Complex asin(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Asin(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Asin(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Complex asin(dynamic z1)
        {
            return asin(dcplx.t(z1));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Complex acos(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Acos(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Acos(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Complex acos(dynamic z1)
        {
            return acos(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Complex atan(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Atan(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Atan(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Complex atan(dynamic z1)
        {
            return atan(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Complex acsc(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Acsc(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Acsc(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Complex acsc(dynamic z1)
        {
            return acsc(dcplx.t(z1));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Complex asec(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Asec(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Asec(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Complex asec(dynamic z1)
        {
            return asec(dcplx.t(z1));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Complex acot(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Acot(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Acot(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Complex acot(dynamic z1)
        {
            return acot(dcplx.t(z1));
        }


        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Complex asinh(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Asinh(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Asinh(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Complex asinh(dynamic z1)
        {
            return asinh(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Complex acosh(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Acosh(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Acosh(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Complex acosh(dynamic z1)
        {
            return acosh(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Complex atanh(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Atanh(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Atanh(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Complex atanh(dynamic z1)
        {
            return atanh(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Complex acsch(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Acsch(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Acsch(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Complex acsch(dynamic z1)
        {
            return acsch(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Complex asech(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Asech(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Asech(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Complex asech(dynamic z1)
        {
            return asech(dcplx.t(z1));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Complex acoth(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Acoth(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Acoth(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Complex acoth(dynamic z1)
        {
            return acoth(dcplx.t(z1));
        }





        #endregion





        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Complex gamma(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Gamma(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Gamma(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Complex gamma(dynamic x)
        {
            return gamma(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Complex rgamma(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Rgamma(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Rgamma(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Complex rgamma(dynamic x)
        {
            return rgamma(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Complex lgamma(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Lgamma(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Lgamma(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Complex lgamma(dynamic x)
        {
            return lgamma(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Complex rising_factorial(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_RisingFactorial(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Complex rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(dcplx.t(x), dcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Complex beta(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_Beta(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Beta(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Complex beta(dynamic x, dynamic y)
        {
            return beta(dcplx.t(x), dcplx.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Complex gamma1pm1(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Complex gamma1pm1(dynamic x)
        {
            return gamma1pm1(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Complex factorial(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Complex factorial(dynamic x)
        {
            return factorial(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Complex doublefactorial(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Complex doublefactorial(dynamic x)
        {
            return doublefactorial(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Complex falling_factorial(Complex a, Complex n)
        {
            return aflintc.DCplxViaArbCS2(aflintc.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Complex falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(dcplx.t(a), dcplx.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Complex gamma_ratio(Complex a, Complex b)
        {
            return aflintc.DCplxViaArbCS2(aflintc.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Complex gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(dcplx.t(a), dcplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Complex gamma_delta_ratio(Complex a, Complex delta)
        {
            return aflintc.DCplxViaArbCS2(aflintc.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Complex gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(dcplx.t(a), dcplx.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Complex binomial(Complex n, Complex k)
        {
            return aflintc.DCplxViaArbCS2(aflintc.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Complex binomial(dynamic n, dynamic k)
        {
            return binomial(dcplx.t(n), dcplx.t(k));
        }















        #endregion



        #region Miscellaneous



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static Complex lambert_wk(Complex x, int branch)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_LambertW_ui(res.mpPtr, x_.mpPtr, branch);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LambertW_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_LambertW_ui(IntPtr res, IntPtr x, int branch);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static Complex lambert_wk(dynamic z1, int branch)
        {
            return lambert_wk(dcplx.t(z1), branch);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Complex lambert_w0(Complex x)
        {
            return lambert_wk(dcplx.t(x), 0);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Complex lambert_w0(dynamic x)
        {
            return lambert_w0(dcplx.t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Complex lambert_wm1(Complex x)
        {
            return lambert_wk(dcplx.t(x), -1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Complex lambert_wm1(dynamic x)
        {
            return lambert_wm1(dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Complex agm(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_Agm(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Agm(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Complex agm(dynamic x, dynamic y)
        {
            return agm(dcplx.t(x), dcplx.t(y));
        }






        #endregion




        #endregion





        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Complex m_elliptic_k(Complex m)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var m_ = new fcplx_t(m);
            Lib_FCplx_Acb_MEllipticK(res.mpPtr, m_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_MEllipticK(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Complex m_elliptic_k(dynamic m)
        {
            return m_elliptic_k(dcplx.t(m));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Complex m_elliptic_e(Complex m)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var m_ = new fcplx_t(m);
            Lib_FCplx_Acb_MEllipticE(res.mpPtr, m_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_MEllipticE(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Complex m_elliptic_e(dynamic m)
        {
            return m_elliptic_e(dcplx.t(m));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Complex m_elliptic_pi(Complex n, Complex m)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var m_ = new fcplx_t(m);
            Lib_FCplx_Acb_MEllipticPi(res.mpPtr, n_.mpPtr, m_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Complex m_elliptic_pi(dynamic n, dynamic m)
        {
            return m_elliptic_pi(dcplx.t(n), dcplx.t(m));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Complex m_elliptic_f(Complex phi, Complex m)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var phi_ = new fcplx_t(phi);
            var m_ = new fcplx_t(m);
            Lib_FCplx_Acb_MEllipticF(res.mpPtr, phi_.mpPtr, m_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Complex m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(dcplx.t(phi), dcplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Complex m_elliptic_e_inc(Complex phi, Complex m)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var phi_ = new fcplx_t(phi);
            var m_ = new fcplx_t(m);
            Lib_FCplx_Acb_MEllipticEInc(res.mpPtr, phi_.mpPtr, m_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Complex m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(dcplx.t(phi), dcplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Complex m_elliptic_pi_inc(Complex n, Complex phi, Complex m)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var phi_ = new fcplx_t(phi);
            var m_ = new fcplx_t(m);
            Lib_FCplx_Acb_MEllipticPiInc(res.mpPtr, n_.mpPtr, phi_.mpPtr, m_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Complex m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(dcplx.t(n), dcplx.t(phi), dcplx.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Complex elliptic_k(Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_EllipticK(res.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticK(IntPtr res, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Complex elliptic_k(dynamic k)
        {
            return elliptic_k(dcplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Complex elliptic_e(Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_EllipticE(res.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticE(IntPtr res, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Complex elliptic_e(dynamic k)
        {
            return elliptic_e(dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_b/*' />
        public static Complex elliptic_b(Complex k)
        {
            return (elliptic_e(k) - sqrt(1 - k * k) * elliptic_k(k)) / (k * k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_b/*' />
        public static Complex elliptic_b(dynamic k)
        {
            return elliptic_b(dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_d/*' />
        public static Complex elliptic_d(Complex k)
        {
            return (elliptic_k(k) - elliptic_e(k)) / (k * k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_b/*' />
        public static Complex elliptic_d(dynamic k)
        {
            return elliptic_d(dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_b_inc/*' />
        public static Complex elliptic_b_inc(Complex phi, Complex k)
        {
            return (elliptic_e_inc(phi, k) - sqrt(1 - k * k) * elliptic_f(phi, k)) / (k * k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_b_inc/*' />
        public static Complex elliptic_b_inc(dynamic phi, dynamic k)
        {
            return elliptic_b_inc(dcplx.t(phi), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_d_inc/*' />
        public static Complex elliptic_d_inc(Complex phi, Complex k)
        {
            return (elliptic_f(phi, k) - elliptic_e_inc(phi, k)) / (k * k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_d_inc/*' />
        public static Complex elliptic_d_inc(dynamic phi, dynamic k)
        {
            return elliptic_d_inc(dcplx.t(phi), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_zeta/*' />
        public static Complex jacobi_zeta(Complex phi, Complex k)
        {
            return elliptic_e_inc(phi, k) - elliptic_f(phi, k) * elliptic_e(k) / elliptic_k(k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_zeta/*' />
        public static Complex jacobi_zeta(dynamic phi, dynamic k)
        {
            return jacobi_zeta(dcplx.t(phi), dcplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/heuman_lambda/*' />
        public static Complex heuman_lambda(Complex phi, Complex k)
        {
            Complex ks = sqrt(1 - k * k);
            return elliptic_f(phi, ks) / elliptic_k(ks) + (2 / dreal.pi()) * elliptic_k(k) * jacobi_zeta(phi, ks);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/heuman_lambda/*' />
        public static Complex heuman_lambda(dynamic phi, dynamic k)
        {
            return heuman_lambda(dcplx.t(phi), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Complex elliptic_pi(Complex n, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_EllipticPi(res.mpPtr, n_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Complex elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(dcplx.t(n), dcplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Complex elliptic_f(Complex phi, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            //var u = dreal.pi() / 2;
            var phi_ = new fcplx_t(phi);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_EllipticF(res.mpPtr, phi_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Complex elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(dcplx.t(phi), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Complex elliptic_e_inc(Complex phi, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var phi_ = new fcplx_t(phi);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_EllipticEInc(res.mpPtr, phi_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Complex elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(dcplx.t(phi), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Complex elliptic_pi_inc(Complex n, Complex phi, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var phi_ = new fcplx_t(phi);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_EllipticPiInc(res.mpPtr, n_.mpPtr, phi_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Complex elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return elliptic_pi_inc(dcplx.t(n), dcplx.t(phi), dcplx.t(m));
        }



        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rc/*' />
        public static Complex elliptic_rc(Complex x, Complex y)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            Lib_FCplx_Acb_Elliptic_RC(res.mpPtr, x_.mpPtr, y_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rc/*' />
        public static Complex elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(dcplx.t(x), dcplx.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Complex elliptic_rf(Complex x, Complex y, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_Elliptic_RF(res.mpPtr, x_.mpPtr, y_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Complex elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(dcplx.t(x), dcplx.t(y), dcplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Complex elliptic_rg(Complex x, Complex y, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_Elliptic_RG(res.mpPtr, x_.mpPtr, y_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Complex elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(dcplx.t(x), dcplx.t(y), dcplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Complex elliptic_rd(Complex x, Complex y, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_Elliptic_RD(res.mpPtr, x_.mpPtr, y_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Complex elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(dcplx.t(x), dcplx.t(y), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Complex elliptic_rj(Complex x, Complex y, Complex z, Complex w)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var y_ = new fcplx_t(y);
            var z_ = new fcplx_t(z);
            var w_ = new fcplx_t(w);
            Lib_FCplx_Acb_Elliptic_RJ(res.mpPtr, x_.mpPtr, y_.mpPtr, z_.mpPtr, w_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Complex elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic p)
        {
            return elliptic_rj(dcplx.t(x), dcplx.t(y), dcplx.t(z), dcplx.t(p));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Complex jacobi_theta1(Complex x, Complex q)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var q_ = new fcplx_t(q);
            Lib_FCplx_Acb_Theta1Q(res.mpPtr, x_.mpPtr, q_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Complex jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(dcplx.t(x), dcplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Complex jacobi_theta2(Complex x, Complex q)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var q_ = new fcplx_t(q);
            Lib_FCplx_Acb_Theta2Q(res.mpPtr, x_.mpPtr, q_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Complex jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(dcplx.t(x), dcplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Complex jacobi_theta3(Complex x, Complex q)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var q_ = new fcplx_t(q);
            Lib_FCplx_Acb_Theta3Q(res.mpPtr, x_.mpPtr, q_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Complex jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(dcplx.t(x), dcplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Complex jacobi_theta4(Complex x, Complex q)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var q_ = new fcplx_t(q);
            Lib_FCplx_Acb_Theta4Q(res.mpPtr, x_.mpPtr, q_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Complex jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(dcplx.t(x), dcplx.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static Complex JacobiTheta1Tau(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_Theta1Tau(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Theta1Tau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Theta1Tau(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static Complex JacobiTheta1Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta1Tau(dcplx.t(z), dcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static Complex JacobiTheta2Tau(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_Theta2Tau(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Theta2Tau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Theta2Tau(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static Complex JacobiTheta2Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta2Tau(dcplx.t(z), dcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static Complex JacobiTheta3Tau(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_Theta3Tau(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Theta3Tau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Theta3Tau(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static Complex JacobiTheta3Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta3Tau(dcplx.t(z), dcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static Complex JacobiTheta4Tau(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_Theta4Tau(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Theta4Tau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_Theta4Tau(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static Complex JacobiTheta4Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta4Tau(dcplx.t(z), dcplx.t(tau));
        }






        #endregion



        #region Jacobi elliptic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static Complex QfromK(Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_QfromK(res.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_QfromK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_QfromK(IntPtr res, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static Complex QfromK(dynamic k)
        {
            return QfromK(dcplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static Complex TfromUQ(Complex u, Complex q)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var u_ = new fcplx_t(u);
            var q_ = new fcplx_t(q);
            Lib_FCplx_Acb_TfromUQ(res.mpPtr, u_.mpPtr, q_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_TfromUQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_TfromUQ(IntPtr res, IntPtr u, IntPtr q);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static Complex TfromUQ(dynamic u, dynamic q)
        {
            return TfromUQ(dcplx.t(u), dcplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static Complex SnTQ(Complex t, Complex q)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var t_ = new fcplx_t(t);
            var q_ = new fcplx_t(q);
            Lib_FCplx_Acb_SnTQ(res.mpPtr, t_.mpPtr, q_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_SnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_SnTQ(IntPtr res, IntPtr t, IntPtr q);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static Complex SnTQ(dynamic t, dynamic q)
        {
            return SnTQ(t(t), t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static Complex CnTQ(Complex t, Complex q)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var t_ = new fcplx_t(t);
            var q_ = new fcplx_t(q);
            Lib_FCplx_Acb_CnTQ(res.mpPtr, t_.mpPtr, q_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_CnTQ(IntPtr res, IntPtr t, IntPtr q);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static Complex CnTQ(dynamic t, dynamic q)
        {
            return CnTQ(t(t), t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static Complex DnTQ(Complex t, Complex q)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var t_ = new fcplx_t(t);
            var q_ = new fcplx_t(q);
            Lib_FCplx_Acb_DnTQ(res.mpPtr, t_.mpPtr, q_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_DnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_DnTQ(IntPtr res, IntPtr t, IntPtr q);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static Complex DnTQ(dynamic t, dynamic q)
        {
            return DnTQ(t(t), t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Complex jacobi_sn(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiSN(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Complex jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Complex jacobi_cn(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiCN(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Complex jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Complex jacobi_dn(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiDN(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Complex jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Complex jacobi_ns(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiNS(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Complex jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Complex jacobi_nc(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiNC(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Complex jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Complex jacobi_nd(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiND(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiND(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Complex jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Complex jacobi_sc(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiSC(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Complex jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Complex jacobi_sd(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiSD(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Complex jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Complex jacobi_dc(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiDC(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Complex jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Complex jacobi_ds(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiDS(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Complex jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Complex jacobi_cs(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiCS(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Complex jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(dcplx.t(x), dcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Complex jacobi_cd(Complex x, Complex k)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            var k_ = new fcplx_t(k);
            Lib_FCplx_Acb_JacobiCD(res.mpPtr, x_.mpPtr, k_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Complex jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(dcplx.t(x), dcplx.t(k));
        }




        #endregion




        #region Conversions of parameters of Weierstrass P


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<Complex, Complex> elliptic_invariants_from_roots(Complex e1, Complex e2)
        {
            Complex e3 = -e1 - e2;
            Complex g2 = 2 * (e1 * e1 + e2 * e2 + e3 * e3);
            Complex g3 = 4 * e1 * e2 * e3;
            return new Tuple<Complex, Complex>(g2, g3);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<Complex, Complex> elliptic_invariants_from_roots(dynamic e1, dynamic e2)
        {
            return elliptic_invariants_from_roots(dcplx.t(e1), dcplx.t(e2));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<Complex, Complex> elliptic_invariants_from_tau(Complex tau)
        {
            return new Tuple<Complex, Complex>(EllipticInvariantG2(tau), EllipticInvariantG3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<Complex, Complex> elliptic_invariants_from_tau(dynamic tau)
        {
            return elliptic_invariants_from_tau(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<Complex, Complex, Complex> elliptic_roots_from_tau(Complex tau)
        {
            return new Tuple<Complex, Complex, Complex>(EllipticRootE1(tau), EllipticRootE2(tau), EllipticRootE3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<Complex, Complex, Complex> elliptic_roots_from_tau(dynamic tau)
        {
            return elliptic_roots_from_tau(dcplx.t(tau));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static Complex EllipticInvariantG2(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_EllipticInvariantG2(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticInvariantG2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticInvariantG2(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static Complex EllipticInvariantG2(dynamic tau)
        {
            return EllipticInvariantG2(dcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static Complex EllipticInvariantG3(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_EllipticInvariantG3(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticInvariantG3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticInvariantG3(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static Complex EllipticInvariantG3(dynamic tau)
        {
            return EllipticInvariantG3(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static Complex EllipticRootE1(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_EllipticRootE1(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticRootE1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticRootE1(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static Complex EllipticRootE1(dynamic tau)
        {
            return EllipticRootE1(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static Complex EllipticRootE2(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_EllipticRootE2(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticRootE2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticRootE2(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static Complex EllipticRootE2(dynamic tau)
        {
            return EllipticRootE2(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static Complex EllipticRootE3(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_EllipticRootE3(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EllipticRootE3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_EllipticRootE3(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static Complex EllipticRootE3(dynamic tau)
        {
            return EllipticRootE3(dcplx.t(tau));
        }





        #endregion






        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static Complex weierstrass_p_t(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_WeierstrassP(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_WeierstrassP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_WeierstrassP(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static Complex weierstrass_p_t(dynamic z, dynamic tau)
        {
            return weierstrass_p_t(dcplx.t(z), dcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static Complex WeierstrassPInv(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_WeierstrassPInv(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_WeierstrassPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_WeierstrassPInv(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static Complex WeierstrassPInv(dynamic z, dynamic tau)
        {
            return WeierstrassPInv(dcplx.t(z), dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static Complex weierstrass_zeta_t(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_WeierstrassPZeta(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_WeierstrassPZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_WeierstrassPZeta(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static Complex weierstrass_zeta_t(dynamic z, dynamic tau)
        {
            return weierstrass_zeta_t(dcplx.t(z), dcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static Complex weierstrass_sigma_t(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_WeierstrassPSigma(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_WeierstrassPSigma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_WeierstrassPSigma(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static Complex weierstrass_sigma_t(dynamic z, dynamic tau)
        {
            return weierstrass_sigma_t(dcplx.t(z), dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static Complex weierstrass_pprime_t(Complex z, Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_WeierstrassPPrime(res.mpPtr, z_.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_WeierstrassPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_WeierstrassPPrime(IntPtr res, IntPtr z, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static Complex weierstrass_pprime_t(dynamic z, dynamic tau)
        {
            return weierstrass_pprime_t(dcplx.t(z), dcplx.t(tau));
        }





        #endregion







        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion




        #region Modular elliptic functions, in terms of half-period omega1 and elliptic period ratio tau





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static Complex dedekind_eta(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_DedekindEta(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_DedekindEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_DedekindEta(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static Complex dedekind_eta(dynamic tau)
        {
            return dedekind_eta(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static Complex modular_lambda(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_ModularLambda(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ModularLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_ModularLambda(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static Complex modular_lambda(dynamic tau)
        {
            return modular_lambda(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static Complex modular_delta(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_ModularDelta(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ModularDelta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_ModularDelta(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static Complex modular_delta(dynamic tau)
        {
            return modular_delta(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static Complex klein_j(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_KleinJ(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_KleinJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_KleinJ(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static Complex klein_j(dynamic tau)
        {
            return dedekind_eta(dcplx.t(tau));
        }



        #endregion





        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Complex lerch_phi(Complex z, Complex s, Complex a)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var s_ = new fcplx_t(s);
            var a_ = new fcplx_t(a);
            Lib_FCplx_Acb_LerchPhi(res.mpPtr, z_.mpPtr, s_.mpPtr, a_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_LerchPhi(IntPtr res, IntPtr z, IntPtr s, IntPtr a);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Complex lerch_phi(dynamic z, dynamic s, dynamic a)
        {
            return lerch_phi(dcplx.t(z), dcplx.t(s), dcplx.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static Complex lerch_zeta(Complex lambda1, Complex alpha, Complex s)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var lambda1_ = new fcplx_t(lambda1);
            var alpha_ = new fcplx_t(alpha);
            var s_ = new fcplx_t(s);
            Lib_FCplx_Acb_LerchZeta(res.mpPtr, lambda1_.mpPtr, alpha_.mpPtr, s_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LerchZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_LerchZeta(IntPtr res, IntPtr lambda1, IntPtr alpha, IntPtr s);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static Complex lerch_zeta(dynamic lambda1, dynamic s, dynamic a)
        {
            return lerch_zeta(dcplx.t(lambda1), dcplx.t(s), dcplx.t(a));
        }




        #endregion



        #region Polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Complex polygamma(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_Polygamma(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Polygamma(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Complex polygamma(dynamic s, dynamic z)
        {
            return polygamma(dcplx.t(s), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Complex trigamma(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Trigamma(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Trigamma(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Complex trigamma(dynamic x)
        {
            return trigamma(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Complex digamma(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Digamma(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Digamma(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Complex digamma(dynamic x)
        {
            return digamma(dcplx.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Complex polylog(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_Polylog(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Polylog(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Complex polylog(dynamic s, dynamic z)
        {
            return polylog(dcplx.t(s), dcplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Complex trilog(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Trilog(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Trilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Trilog(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Complex trilog(dynamic x)
        {
            return trilog(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Complex dilog(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Dilog(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Dilog(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Complex dilog(dynamic x)
        {
            return dilog(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Complex clausen_sin(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_ClausenSin(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ClausenSin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_ClausenSin(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Complex clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(dcplx.t(s), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Complex clausen_cos(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_ClausenCos(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ClausenCos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_ClausenCos(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Complex clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(dcplx.t(s), dcplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Complex clausen2(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Clausen2(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Clausen2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Clausen2(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Complex clausen2(dynamic x)
        {
            return clausen2(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Complex bose_einstein(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_BoseEinstein(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_BoseEinstein", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_BoseEinstein(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Complex bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(dcplx.t(s), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Complex fermi_dirac(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_FermiDirac(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_FermiDirac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_FermiDirac(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Complex fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(dcplx.t(s), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Complex legendre_chi(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_LegendreChi(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LegendreChi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_LegendreChi(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Complex legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(dcplx.t(s), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Complex inverse_tan_integral(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_InverseTanIntegral(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_InverseTanIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_InverseTanIntegral(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Complex inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(dcplx.t(s), dcplx.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Complex hurwitz_zeta(Complex s, Complex a)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var a_ = new fcplx_t(a);
            Lib_FCplx_Acb_HurwitzZeta(res.mpPtr, s_.mpPtr, a_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr a);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Complex hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(dcplx.t(s), dcplx.t(a));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/stieltjes/*' />
        //public static Complex stieltjes(Complex x, Int32 n)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_Stieltjes_ui(res.mpPtr, x_.mpPtr, n);
        //    return new Complex(res.real, res.imag);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Stieltjes_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_Stieltjes_ui(IntPtr res, IntPtr x, Int32 n);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/stieltjes/*' />
        //public static Complex stieltjes(dynamic x, Int32 n)
        //{
        //    return stieltjes(dcplx.t(x), n);
        //}



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static Complex bernpoly(Complex x, Int32 n)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_BernoulliPoly_ui(res.mpPtr, x_.mpPtr, n);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static Complex bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(dcplx.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Complex eulerpoly(Complex x, Int32 n)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_EulerPoly_ui(res.mpPtr, x_.mpPtr, n);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_EulerPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_EulerPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Complex eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(dcplx.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Complex harmonic(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Harmonic(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Harmonic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Harmonic(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Complex harmonic(dynamic x)
        {
            return harmonic(dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Complex harmonic2(Complex z, Complex r)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var z_ = new fcplx_t(z);
            var r_ = new fcplx_t(r);
            Lib_FCplx_Acb_Harmonic2(res.mpPtr, z_.mpPtr, r_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Harmonic2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Harmonic2(IntPtr res, IntPtr z, IntPtr r);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Complex harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(dcplx.t(z), dcplx.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Complex barnes_g(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_BarnesG(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_BarnesG(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Complex barnes_g(dynamic x)
        {
            return barnes_g(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Complex logbarnes_g(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_LogBarnesG(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_LogBarnesG(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Complex logbarnes_g(dynamic x)
        {
            return logbarnes_g(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Complex hyperfactorial(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hyperfactorial(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hyperfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hyperfactorial(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Complex hyperfactorial(dynamic x)
        {
            return hyperfactorial(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Complex superfactorial(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Superfactorial(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Superfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Superfactorial(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Complex superfactorial(dynamic x)
        {
            return superfactorial(dcplx.t(x));
        }




        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Complex zeta(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Zeta(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Zeta(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Complex zeta(dynamic x)
        {
            return zeta(dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Complex zetam1(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Zetam1(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Zetam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Zetam1(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Complex zetam1(dynamic x)
        {
            return zetam1(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Complex riemann_xi(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_DirichletXi(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_DirichletXi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_DirichletXi(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Complex riemann_xi(dynamic tau)
        {
            return riemann_xi(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Complex dirichlet_eta(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_DirichletEta(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_DirichletEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_DirichletEta(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Complex dirichlet_eta(dynamic tau)
        {
            return dirichlet_eta(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Complex dirichlet_etam1(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_DirichletEtam1(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_DirichletEtam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_DirichletEtam1(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Complex dirichlet_etam1(dynamic tau)
        {
            return dirichlet_etam1(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Complex dirichlet_beta(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_DirichletBeta(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_DirichletBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_DirichletBeta(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Complex dirichlet_beta(dynamic tau)
        {
            return dirichlet_beta(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Complex dirichlet_lambda(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_DirichletLambda(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_DirichletLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_DirichletLambda(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Complex dirichlet_lambda(dynamic tau)
        {
            return dirichlet_lambda(dcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Complex hardy_z(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_HardyZ(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_HardyZ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_HardyZ(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Complex hardy_z(dynamic tau)
        {
            return hardy_z(dcplx.t(tau));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Complex hardy_theta(Complex tau)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var tau_ = new fcplx_t(tau);
            Lib_FCplx_Acb_HardyTheta(res.mpPtr, tau_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_HardyTheta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Acb_HardyTheta(IntPtr res, IntPtr tau);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Complex hardy_theta(dynamic tau)
        {
            return hardy_theta(dcplx.t(tau));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta_zero/*' />
        public static Complex zeta_zero(Int32 n)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            Lib_FCplx_Acb_ZetaZero_ui(res.mpPtr, n);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ZetaZero_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_ZetaZero_ui(IntPtr res, Int32 n);



        #endregion



        #region Additional numbertheoretic functions





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Complex hyperg_0f1(Complex a, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hypgeom0F1(res.mpPtr, a_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Complex hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(dcplx.t(a), dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Complex hyperg_0f1r(Complex a, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hypgeom0F1r(res.mpPtr, a_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Complex hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(dcplx.t(a), dcplx.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Complex bessel_jv(Complex nu, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Complex bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(dcplx.t(nu), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Complex bessel_yv(Complex nu, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Complex bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(dcplx.t(nu), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Complex bessel_iv(Complex nu, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Complex bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(dcplx.t(nu), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Complex bessel_kv(Complex nu, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Complex bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(dcplx.t(nu), dcplx.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Complex bessel_jv_prime(Complex nu, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Complex bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(dcplx.t(nu), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Complex bessel_yv_prime(Complex nu, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Complex bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(dcplx.t(nu), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Complex bessel_iv_prime(Complex nu, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Complex bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(dcplx.t(nu), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Complex bessel_kv_prime(Complex nu, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Complex bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(dcplx.t(nu), dcplx.t(x), scaled);
        }









        #endregion







        #region 0F1: Spherical Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Complex sph_bessel_jn(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_bessel_jn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Complex sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(dcplx.t(n), dcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Complex sph_bessel_yn(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_bessel_yn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Complex sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(dcplx.t(n), dcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Complex sph_bessel_in(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_bessel_in, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Complex sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(dcplx.t(n), dcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Complex sph_bessel_kn(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_bessel_kn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Complex sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(dcplx.t(n), dcplx.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Complex besselpoly(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.besselpoly, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Complex besselpoly(dynamic n, dynamic x, bool scaled = false)
        {
            return besselpoly(dcplx.t(n), dcplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Complex besseltheta(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.besseltheta, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Complex besseltheta(dynamic n, dynamic x, bool scaled = false)
        {
            return besseltheta(dcplx.t(n), dcplx.t(x), scaled);
        }










        #endregion



        #region 0F1: Spherical Bessel functions, first derivative


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static Complex sph_bessel_jn_prime(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_bessel_jn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static Complex sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(dcplx.t(n), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static Complex sph_bessel_yn_prime(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_bessel_yn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static Complex sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(dcplx.t(n), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static Complex sph_bessel_in_prime(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_bessel_in_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static Complex sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(dcplx.t(n), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static Complex sph_bessel_kn_prime(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_bessel_kn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static Complex sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(dcplx.t(n), dcplx.t(x), scaled);
        }



        #endregion






        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static Complex hankel_h1(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.hankel_h1, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static Complex hankel_h1(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h1(dcplx.t(v), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static Complex hankel_h2(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.hankel_h2, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static Complex hankel_h2(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h2(dcplx.t(v), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static Complex sph_hankel_h1(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_hankel_h1, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static Complex sph_hankel_h1(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h1(dcplx.t(n), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static Complex sph_hankel_h2(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.sph_hankel_h2, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static Complex sph_hankel_h2(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h2(dcplx.t(n), dcplx.t(x), scaled);
        }






        #endregion






        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Complex airy_ai(Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS1Bool1(aflintc.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Complex airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Complex airy_ai_prime(Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS1Bool1(aflintc.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Complex airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Complex airy_bi(Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS1Bool1(aflintc.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Complex airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Complex airy_bi_prime(Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS1Bool1(aflintc.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Complex airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(dcplx.t(x), scaled);
        }







        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static Complex airy_ai(Complex x, bool scaled = false)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_AiryAi(res.mpPtr, x_.mpPtr);
        //    var res1 = new Complex(res.real, res.imag);
        //    if (scaled) res1 = res1 * exp((dreal.t(2) / dreal.t(3)) * x * sqrt(x));
        //    return res1;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_AiryAi(IntPtr res, IntPtr x);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static Complex airy_ai(dynamic x, bool scaled = false)
        //{
        //    return airy_ai(dcplx.t(x));
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static Complex airy_ai_prime(Complex x, bool scaled = false)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_AiryAiPrime(res.mpPtr, x_.mpPtr);
        //    var res1 = new Complex(res.real, res.imag);
        //    if (scaled) res1 = res1 * exp((dreal.t(2) / dreal.t(3)) * x * sqrt(x));
        //    return res1;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_AiryAiPrime(IntPtr res, IntPtr x);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static Complex airy_ai_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_ai_prime(dcplx.t(x));
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static Complex airy_bi(Complex x, bool scaled = false)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_AiryBi(res.mpPtr, x_.mpPtr);
        //    var res1 = new Complex(res.real, res.imag);
        //    if (scaled) res1 = res1 * exp(-abs(dreal.t(2) / dreal.t(3) * (x * sqrt(x)).Real));
        //    return res1;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_AiryBi(IntPtr res, IntPtr x);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static Complex airy_bi(dynamic x, bool scaled = false)
        //{
        //    return airy_bi(dcplx.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static Complex airy_bi_prime(Complex x, bool scaled = false)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_AiryBiPrime(res.mpPtr, x_.mpPtr);
        //    var res1 = new Complex(res.real, res.imag);
        //    if (scaled) res1 = res1 * exp(-abs(dreal.t(2) / dreal.t(3) * (x * sqrt(x)).Real));
        //    return res1;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_AiryBiPrime(IntPtr res, IntPtr x);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static Complex airy_bi_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_bi_prime(dcplx.t(x));
        //}



        #endregion





        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Complex kelvin_ber(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.kelvin_ber, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Complex kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(dcplx.t(v), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Complex kelvin_bei(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.kelvin_bei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Complex kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(dcplx.t(v), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Complex kelvin_ker(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.kelvin_ker, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Complex kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(dcplx.t(v), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Complex kelvin_kei(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.kelvin_kei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Complex kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(dcplx.t(v), dcplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Complex kelvin_ber_prime(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.kelvin_ber_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Complex kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(dcplx.t(v), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Complex kelvin_bei_prime(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.kelvin_bei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Complex kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(dcplx.t(v), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Complex kelvin_ker_prime(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.kelvin_ker_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Complex kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(dcplx.t(v), dcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Complex kelvin_kei_prime(Complex v, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2Bool1(aflintc.kelvin_kei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Complex kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(dcplx.t(v), dcplx.t(x), scaled);
        }






        #endregion












        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Complex hyperg_1f1(Complex a, Complex b, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hypgeom1F1(res.mpPtr, a_.mpPtr, b_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Complex hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(dcplx.t(a), dcplx.t(b), dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Complex hyperg_1f1r(Complex a, Complex b, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hypgeom1F1r(res.mpPtr, a_.mpPtr, b_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Complex hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(dcplx.t(a), dcplx.t(b), dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Complex hyperg_u(Complex a, Complex b, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_HypgeomU(res.mpPtr, a_.mpPtr, b_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Complex hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(dcplx.t(a), dcplx.t(b), dcplx.t(x));
        }





        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Complex gamma_upper(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_GammaUpper(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Complex gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(dcplx.t(s), dcplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Complex gamma_q(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_GammaQ(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_GammaQ(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Complex gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(dcplx.t(s), dcplx.t(z));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Complex gamma_lower(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_GammaLower(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_GammaLower(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Complex gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(dcplx.t(s), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Complex gamma_p(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_GammaP(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_GammaP(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Complex gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(dcplx.t(s), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Complex gamma_p_prime(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_GammaPPrime(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Complex gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(dcplx.t(s), dcplx.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Complex erf(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Erf(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Erf(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Complex erf(dynamic x)
        {
            return erf(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Complex erfc(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Erfc(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Erfc(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Complex erfc(dynamic x)
        {
            return erfc(dcplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Complex erfi(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Erfi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Erfi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Complex erfi(dynamic x)
        {
            return erfi(dcplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Complex dawson(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Complex dawson(dynamic x)
        {
            return dawson(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static Complex faddeeva(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.faddeeva, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static Complex faddeeva(dynamic x)
        {
            return faddeeva(dcplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Complex fresnel_s(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_FresnelS(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_FresnelS(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Complex fresnel_s(dynamic x)
        {
            return fresnel_s(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Complex fresnel_c(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_FresnelC(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_FresnelC(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Complex fresnel_c(dynamic x)
        {
            return fresnel_c(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Complex ndens(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Ndens(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Ndens(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Complex ndens(dynamic x)
        {
            return ndens(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Complex ndis(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Ndis(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Ndis(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Complex ndis(dynamic x)
        {
            return ndis(dcplx.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Complex exp_integral_en(Complex s, Complex z)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var s_ = new fcplx_t(s);
            var z_ = new fcplx_t(z);
            Lib_FCplx_Acb_ExpIntegralE(res.mpPtr, s_.mpPtr, z_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Complex exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(dcplx.t(s), dcplx.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Complex exp_integral_e1(Complex z)
        {
            return exp_integral_en(dcplx.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Complex exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(dcplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Complex exp_integral_ei(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_ExpIntegralEi(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_ExpIntegralEi(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Complex exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Complex sin_integral(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_SinIntegral(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_SinIntegral(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Complex sin_integral(dynamic x)
        {
            return sin_integral(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Complex cos_integral(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CosIntegral(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CosIntegral(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Complex cos_integral(dynamic x)
        {
            return cos_integral(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Complex sinh_integral(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_SinhIntegral(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_SinhIntegral(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Complex sinh_integral(dynamic x)
        {
            return sinh_integral(dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Complex cosh_integral(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CoshIntegral(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CoshIntegral(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Complex cosh_integral(dynamic x)
        {
            return cosh_integral(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Complex log_integral(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_LogIntegral(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_LogIntegral(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Complex log_integral(dynamic x)
        {
            return log_integral(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Complex log_integral_offset(Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_LogIntegralOffset(res.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_LogIntegralOffset(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Complex log_integral_offset(dynamic x)
        {
            return log_integral_offset(dcplx.t(x));
        }



        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Complex hermite_h(Complex n, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_HermiteH(res.mpPtr, n_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_HermiteH(IntPtr res, IntPtr n, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Complex hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(dcplx.t(n), dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Complex hermite_he(Complex n, Complex x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Complex hermite_he(dynamic n, dynamic x)
        {
            return hermite_h(dcplx.t(n), dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Complex laguerre_l(Complex n, Complex m, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var m_ = new fcplx_t(m);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_LaguerreL(res.mpPtr, n_.mpPtr, m_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Complex laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(dcplx.t(n), dcplx.t(m), dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre/*' />
        public static Complex laguerre(Complex n, Complex x)
        {
            return laguerre_l(n, dcplx.t(0), x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre/*' />
        public static Complex laguerre(dynamic n, dynamic x)
        {
            return laguerre(dcplx.t(n), dcplx.t(x));
        }



        #endregion



        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Complex coulomb_f(Complex l, Complex eta, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var l_ = new fcplx_t(l);
            var eta_ = new fcplx_t(eta);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CoulombF(res.mpPtr, l_.mpPtr, eta_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Complex coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(dcplx.t(l), dcplx.t(eta), dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Complex coulomb_g(Complex l, Complex eta, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var l_ = new fcplx_t(l);
            var eta_ = new fcplx_t(eta);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CoulombG(res.mpPtr, l_.mpPtr, eta_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Complex coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(dcplx.t(l), dcplx.t(eta), dcplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static Complex coulomb_hpos(Complex l, Complex eta, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var l_ = new fcplx_t(l);
            var eta_ = new fcplx_t(eta);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CoulombHpos(res.mpPtr, l_.mpPtr, eta_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CoulombHpos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CoulombHpos(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static Complex coulomb_hpos(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hpos(dcplx.t(l), dcplx.t(eta), dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static Complex coulomb_hneg(Complex l, Complex eta, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var l_ = new fcplx_t(l);
            var eta_ = new fcplx_t(eta);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_CoulombHneg(res.mpPtr, l_.mpPtr, eta_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_CoulombHneg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_CoulombHneg(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static Complex coulomb_hneg(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hneg(dcplx.t(l), dcplx.t(eta), dcplx.t(x));
        }





        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Complex whittaker_m(Complex k, Complex m, Complex x)
        {
            return aflintc.DCplxViaArbCS3(aflintc.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Complex whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(dcplx.t(k), dcplx.t(m), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Complex whittaker_w(Complex k, Complex m, Complex x)
        {
            return aflintc.DCplxViaArbCS3(aflintc.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Complex whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(dcplx.t(k), dcplx.t(m), dcplx.t(x));
        }







        #endregion



        #region 1F1: Parabolic cylinder functions


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Complex pcfd(Complex n, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Complex pcfd(dynamic n, dynamic x)
        {
            return pcfd(dcplx.t(n), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Complex pcfu(Complex a, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Complex pcfu(dynamic a, dynamic x)
        {
            return pcfu(dcplx.t(a), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Complex pcfv(Complex a, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Complex pcfv(dynamic a, dynamic x)
        {
            return pcfv(dcplx.t(a), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Complex pcfw(Complex a, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Complex pcfw(dynamic a, dynamic x)
        {
            return pcfw(dcplx.t(a), dcplx.t(x));
        }




        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Complex hyperg_2f1(Complex a, Complex b, Complex c, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var c_ = new fcplx_t(c);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hypgeom2F1(res.mpPtr, a_.mpPtr, b_.mpPtr, c_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Complex hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic z)
        {
            return hyperg_2f1(dcplx.t(a), dcplx.t(b), dcplx.t(c), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Complex hyperg_2f1r(Complex a, Complex b, Complex c, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var c_ = new fcplx_t(c);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hypgeom2F1r(res.mpPtr, a_.mpPtr, b_.mpPtr, c_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Complex hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic z)
        {
            return hyperg_2f1r(dcplx.t(a), dcplx.t(b), dcplx.t(c), dcplx.t(z));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Complex chebyshev_t(Complex n, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_ChebyshevT(res.mpPtr, n_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Complex chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(dcplx.t(n), dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Complex chebyshev_u(Complex n, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_ChebyshevU(res.mpPtr, n_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Complex chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(dcplx.t(n), dcplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static Complex chebyshev_v(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2(aflintc.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Complex chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(dcplx.t(n), dcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static Complex chebyshev_w(Complex n, Complex x, bool scaled = false)
        {
            return aflintc.DCplxViaArbCS2(aflintc.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Complex chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(dcplx.t(n), dcplx.t(y));
        }










        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Complex gegenbauer_c(Complex n, Complex m, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var m_ = new fcplx_t(m);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_GegenbauerC(res.mpPtr, n_.mpPtr, m_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Complex gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(dcplx.t(n), dcplx.t(m), dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Complex jacobi_p(Complex n, Complex a, Complex b, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_JacobiP(res.mpPtr, n_.mpPtr, a_.mpPtr, b_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Complex jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(dcplx.t(n), dcplx.t(a), dcplx.t(b), dcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Complex legendre_p(Complex n, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.legendre_p, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Complex legendre_p(dynamic n, dynamic x)
        {
            return legendre_p(dcplx.t(n), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Complex legendre_q(Complex n, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.legendre_q, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Complex legendre_q(dynamic n, dynamic x)
        {
            return legendre_q(dcplx.t(n), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Complex legendre_plm(Complex n, Complex m, Complex x, int type = 1)
        {
            return aflintc.DCplxViaArbCS3Int1(aflintc.legendre_plm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Complex legendre_plm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_plm(dcplx.t(n), dcplx.t(m), dcplx.t(x), type);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Complex legendre_qlm(Complex n, Complex m, Complex x, int type = 1)
        {
            return aflintc.DCplxViaArbCS3Int1(aflintc.legendre_qlm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Complex legendre_qlm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_qlm(dcplx.t(n), dcplx.t(m), dcplx.t(x), type);
        }






        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static Complex legendre_p(Complex n, Complex m, Complex x)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var n_ = new fcplx_t(n);
        //    var m_ = new fcplx_t(m);
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_LegendreP(res.mpPtr, n_.mpPtr, m_.mpPtr, x_.mpPtr);
        //    return new Complex(res.real, res.imag);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static Complex legendre_p(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_p(dcplx.t(n), dcplx.t(m), dcplx.t(x));
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static Complex legendre_plm(Complex n, Complex m, Complex x)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var n_ = new fcplx_t(n);
        //    var m_ = new fcplx_t(m);
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_LegendrePv(res.mpPtr, n_.mpPtr, m_.mpPtr, x_.mpPtr);
        //    return new Complex(res.real, res.imag);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static Complex legendre_plm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_plm(dcplx.t(n), dcplx.t(m), dcplx.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static Complex legendre_q(Complex n, Complex m, Complex x)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var n_ = new fcplx_t(n);
        //    var m_ = new fcplx_t(m);
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_LegendreQ(res.mpPtr, n_.mpPtr, m_.mpPtr, x_.mpPtr);
        //    return new Complex(res.real, res.imag);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static Complex legendre_q(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_q(dcplx.t(n), dcplx.t(m), dcplx.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static Complex legendre_qlm(Complex n, Complex m, Complex x)
        //{
        //    ArbPrec.Init();
        //    var res = new fcplx_t();
        //    var n_ = new fcplx_t(n);
        //    var m_ = new fcplx_t(m);
        //    var x_ = new fcplx_t(x);
        //    Lib_FCplx_Acb_LegendreQv(res.mpPtr, n_.mpPtr, m_.mpPtr, x_.mpPtr);
        //    return new Complex(res.real, res.imag);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_FCplx_Acb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static Complex legendre_qlm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_qlm(dcplx.t(n), dcplx.t(m), dcplx.t(x));
        //}





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static Complex spherical_y(Complex n, Complex m, Complex theta, Complex phi)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var n_ = new fcplx_t(n);
            var m_ = new fcplx_t(m);
            var theta_ = new fcplx_t(theta);
            var phi_ = new fcplx_t(phi);
            Lib_FCplx_Acb_SphericalY(res.mpPtr, n_.mpPtr, m_.mpPtr, theta_.mpPtr, phi_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_SphericalY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_SphericalY(IntPtr res, IntPtr n, IntPtr m, IntPtr theta, IntPtr phi);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static Complex spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(dcplx.t(n), dcplx.t(m), dcplx.t(theta), dcplx.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Complex beta_lower(Complex a, Complex b, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_BetaLower(res.mpPtr, a_.mpPtr, b_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Complex beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(dcplx.t(a), dcplx.t(b), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Complex ibeta(Complex a, Complex b, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Ibeta(res.mpPtr, a_.mpPtr, b_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Complex ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(dcplx.t(a), dcplx.t(b), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Complex ibetac(Complex a, Complex b, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Ibetac(res.mpPtr, a_.mpPtr, b_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Complex ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(dcplx.t(a), dcplx.t(b), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Complex ibeta_prime(Complex a, Complex b, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a_ = new fcplx_t(a);
            var b_ = new fcplx_t(b);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_IbetaPrime(res.mpPtr, a_.mpPtr, b_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Complex ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(dcplx.t(a), dcplx.t(b), dcplx.t(x));
        }


        #endregion







        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Complex hyperg_1f2(Complex a1, Complex b1, Complex b2, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a1_ = new fcplx_t(a1);
            var b1_ = new fcplx_t(b1);
            var b2_ = new fcplx_t(b2);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hypgeom1F2(res.mpPtr, a1_.mpPtr, b1_.mpPtr, b2_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Complex hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic z)
        {
            return hyperg_1f2(dcplx.t(a1), dcplx.t(b1), dcplx.t(b2), dcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Complex hyperg_1f2r(Complex a1, Complex b1, Complex b2, Complex x)
        {
            ArbPrec.Init();
            var res = new fcplx_t();
            var a1_ = new fcplx_t(a1);
            var b1_ = new fcplx_t(b1);
            var b2_ = new fcplx_t(b2);
            var x_ = new fcplx_t(x);
            Lib_FCplx_Acb_Hypgeom1F2r(res.mpPtr, a1_.mpPtr, b1_.mpPtr, b2_.mpPtr, x_.mpPtr);
            return new Complex(res.real, res.imag);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Acb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_FCplx_Acb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Complex hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic z)
        {
            return hyperg_1f2r(dcplx.t(a1), dcplx.t(b1), dcplx.t(b2), dcplx.t(z));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Complex airy_gi(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Complex airy_gi(dynamic x)
        {
            return airy_gi(dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Complex airy_hi(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Complex airy_hi(dynamic x)
        {
            return airy_hi(dcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Complex airy_gi_prime(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Complex airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Complex airy_hi_prime(Complex x)
        {
            return aflintc.DCplxViaArbCS1(aflintc.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Complex airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(dcplx.t(x));
        }


        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Complex struve_h(Complex v, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Complex struve_h(dynamic v, dynamic x)
        {
            return struve_h(dcplx.t(v), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Complex struve_l(Complex v, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Complex struve_l(dynamic v, dynamic x)
        {
            return struve_l(dcplx.t(v), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Complex struve_k(Complex v, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Complex struve_k(dynamic v, dynamic x)
        {
            return struve_k(dcplx.t(v), dcplx.t(x));
        }


        public static Complex struve_m(Complex v, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static Complex struve_m(dynamic v, dynamic x)
        {
            return struve_m(dcplx.t(v), dcplx.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Complex anger_j(Complex v, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Complex anger_j(dynamic v, dynamic x)
        {
            return anger_j(dcplx.t(v), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Complex weber_e(Complex v, Complex x)
        {
            return aflintc.DCplxViaArbCS2(aflintc.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Complex weber_e(dynamic v, dynamic x)
        {
            return weber_e(dcplx.t(v), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Complex lommel_s1(Complex mu, Complex nu, Complex x)
        {
            return aflintc.DCplxViaArbCS3(aflintc.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Complex lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(dcplx.t(mu), dcplx.t(nu), dcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Complex lommel_s2(Complex mu, Complex nu, Complex x)
        {
            return aflintc.DCplxViaArbCS3(aflintc.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Complex lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(dcplx.t(mu), dcplx.t(nu), dcplx.t(x));
        }


        #endregion







        #endregion


    }







    internal class fcplx_t
    {

        public IntPtr mpPtr = IntPtr.Zero;


        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Lib_FCplx_Init_Func();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_FCplx_Init_Func();


        ~fcplx_t()
        {
            Lib_FCplx_Clear(mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Clear(IntPtr x);


        public fcplx_t()
        {
            Init();
        }


        public fcplx_t(Complex z)
        {
            Init();
            double re = z.Real;
            double im = z.Imaginary;
            Lib_FLib_FCplx_Set2Cplx_Real(mpPtr, ref re, ref im);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Set2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FLib_FCplx_Set2Cplx_Real(IntPtr res, ref double re, ref double im);


        public double real
        {
            get
            {
                double res = 0.0;
                Lib_FCplx_Real(ref res, mpPtr);
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Real", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Real(ref double res, IntPtr z);


        public double imag
        {
            get
            {
                double res = 0.0;
                Lib_FCplx_Imag(ref res, mpPtr);
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_FCplx_Imag", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_FCplx_Imag(ref double res, IntPtr z);

    }






}