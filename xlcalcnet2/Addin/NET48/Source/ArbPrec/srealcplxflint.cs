using FixedPrecNet;
using System;
using System.Numerics;
using System.Runtime.InteropServices;


namespace ArbPrecNet
{



    public class sflint
    {


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Single t(Arb x)
        {
            Single res = 0.0F;
            Lib_SReal_Set_Arb(ref res, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Set_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Set_Arb(ref Single res, IntPtr x);


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Single t(Mpfr x)
        {
            Single res = 0.0F;
            Lib_SReal_Set_Mpfr(ref res, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Set_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Set_Mpfr(ref Single res, IntPtr x);




        public static String fmt(Single x)
        {
            return sreal.fmt(x);
        }


        public static String fmt(Double x)
        {
            return sreal.fmt(x);
        }


        public static String fmt(dynamic x)
        {
            return sreal.fmt(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "sflint"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return " sflint"; }
        }



        #region Basic floating point functions




        #region General functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Single fma(Single x, Single y, Single z)
        {
            return sreal.fma(x, y, z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Single fma(dynamic x, dynamic y, dynamic z)
        {
            return sreal.fma(x, y, z);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Single fmax(Single x, Single y)
        {
            return sreal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Single fmax(dynamic x, dynamic y)
        {
            return sreal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Single fmin(Single x, Single y)
        {
            return sreal.fmin(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Single fmin(dynamic x, dynamic y)
        {
            return sreal.fmin(x, y);
        }


        #endregion



        #region Machine constants


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static Single zero()
        {
            return sreal.zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/negzero/*' />
        public static Single negzero()
        {
            return sreal.negzero();
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static Single one()
        {
            return sreal.one();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static SingleC onej()
        {
            return sreal.onej();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static Single inf()
        {
            return sreal.inf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/neginf/*' />
        public static Single neginf()
        {
            return sreal.neginf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static Single nan()
        {
            return sreal.nan();
        }



        #endregion



        #region Properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(Single x)
        {
            return sreal.signbit(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(dynamic x)
        {
            return sreal.signbit(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(Single x)
        {
            return sreal.isfinite(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isfinite/*' />
        public static bool isfinite(dynamic x)
        {
            return sreal.isfinite(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(Single x)
        {
            return sreal.isinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinf/*' />
        public static bool isinf(dynamic x)
        {
            return sreal.isinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static bool isposinf(Single x)
        {
            return sreal.isposinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isposinf/*' />
        public static bool isposinf(dynamic x)
        {
            return sreal.isposinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isneginf/*' />
        public static bool isneginf(Single x)
        {
            return sreal.isneginf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isneginf/*' />
        public static bool isneginf(dynamic x)
        {
            return sreal.isneginf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(Single x)
        {
            return sreal.isnan(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnan/*' />
        public static bool isnan(dynamic x)
        {
            return sreal.isnan(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(Single x)
        {
            return sreal.iszero(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/iszero/*' />
        public static bool iszero(dynamic x)
        {
            return sreal.iszero(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(Single x)
        {
            return sreal.isone(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isone/*' />
        public static bool isone(dynamic x)
        {
            return sreal.isone(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinteger/*' />
        public static bool isinteger(Single x)
        {
            return sreal.isinteger(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinteger/*' />
        public static bool isinteger(dynamic x)
        {
            return sreal.isinteger(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnumber/*' />
        public static bool isnumber(Single x)
        {
            return sreal.isnumber(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnumber/*' />
        public static bool isnumber(dynamic x)
        {
            return sreal.isnumber(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isregular/*' />
        public static bool isregular(Single x)
        {
            return sreal.isregular(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isregular/*' />
        public static bool isregular(dynamic x)
        {
            return sreal.isregular(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnormal/*' />
        public static bool isnormal(Single x)
        {
            return sreal.isnormal(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnormal/*' />
        public static bool isnormal(dynamic x)
        {
            return sreal.isnormal(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isunordered/*' />
        public static bool isunordered(Single x, Single y)
        {
            return sreal.isunordered(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isunordered/*' />
        public static bool isunordered(dynamic x, dynamic y)
        {
            return sreal.isunordered(x, y);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint32/*' />
        public static bool fitsint32(Single x)
        {
            return sreal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint32/*' />
        public static bool fitsint32(dynamic x)
        {
            return sreal.fitsint32(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint64/*' />
        public static bool fitsint64(Single x)
        {
            return sreal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint64/*' />
        public static bool fitsint64(dynamic x)
        {
            return sreal.fitsint32(x);
        }





        #endregion



        #region Integer Related Functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Single nearbyint(Single x)
        {
            return sreal.nearbyint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Single nearbyint(dynamic x)
        {
            return sreal.nearbyint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Single rint(Single x)
        {
            return sreal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Single rint(dynamic x)
        {
            return sreal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(Single x)
        {
            return sreal.lrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(dynamic x)
        {
            return sreal.lrint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(Single x)
        {
            return sreal.llrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(dynamic x)
        {
            return sreal.llrint(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Single ceil(Single x)
        {
            return sreal.ceil(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Single ceil(dynamic x)
        {
            return sreal.ceil(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Single floor(Single x)
        {
            return sreal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Single floor(dynamic x)
        {
            return sreal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Single trunc(Single x)
        {
            return sreal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Single trunc(dynamic x)
        {
            return sreal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Single round(Single x)
        {
            return sreal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Single round(dynamic x)
        {
            return sreal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(Single x)
        {
            return sreal.lround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(dynamic x)
        {
            return sreal.lround(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(Single x)
        {
            return sreal.llround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(dynamic x)
        {
            return sreal.llround(x);
        }




        #endregion



        #region Floating point functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Single copysign(Single x, Single y)
        {
            return sreal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Single copysign(dynamic x, dynamic y)
        {
            return sreal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Single, Int32> frexp(Single x)
        {
            return sreal.frexp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Single, Int32> frexp(dynamic x)
        {
            return sreal.frexp(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Single logb(Single x)
        {
            return sreal.logb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Single logb(dynamic x)
        {
            return sreal.logb(x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(Single x)
        {
            return sreal.ilogb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(dynamic x)
        {
            return sreal.ilogb(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Single ldexp(Single x, Int32 e)
        {
            return sreal.ldexp(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Single ldexp(dynamic x, dynamic e)
        {
            return sreal.ldexp(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Single scalbn(Single x, Int32 e)
        {
            return sreal.scalbn(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Single scalbn(dynamic x, dynamic e)
        {
            return sreal.scalbn(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Single scalbln(Single x, Int32 e)
        {
            return sreal.scalbln(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Single scalbln(dynamic x, dynamic e)
        {
            return sreal.scalbln(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Single fdim(Single x, Single y)
        {
            return sreal.fdim(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Single fdim(dynamic x, dynamic y)
        {
            return sreal.fdim(x, y);
        }


        #endregion



        #region Fraction and remainder Related Functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Single, Single> modf(Single x)
        {
            return sreal.modf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Single, Single> modf(dynamic x)
        {
            return sreal.modf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Single fmod(Single x, Single y)
        {
            return sreal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Single fmod(dynamic x, dynamic y)
        {
            return sreal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Single remainder(Single x, Single y)
        {
            return sreal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Single remainder(dynamic x, dynamic y)
        {
            return sreal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Single, Int32> remquo(Single x, Single y)
        {
            return sreal.remquo(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Single, Int32> remquo(dynamic x, dynamic y)
        {
            return sreal.remquo(x, y);
        }

        #endregion



        #region Functions related to mantissa width and exponent range


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/epsilon/*' />
        public static Single epsilon()
        {
            return sreal.epsilon();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Single ulp(Single x)
        {
            return sreal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Single ulp(dynamic x)
        {
            return sreal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/maxvalue/*' />
        public static Single maxvalue()
        {
            return sreal.maxvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/lowestvalue/*' />
        public static Single lowestvalue()
        {
            return sreal.lowestvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/minposvalue/*' />
        public static Single minposvalue()
        {
            return sreal.minposvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Single nextafter(Single x, Single y)
        {
            return sreal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Single nextafter(dynamic x, dynamic y)
        {
            return sreal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Single nextabove(Single x)
        {
            return sreal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Single nextabove(dynamic x)
        {
            return sreal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Single nextbelow(Single x)
        {
            return sreal.nextbelow(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Single nextbelow(dynamic x)
        {
            return sreal.nextbelow(x);
        }


        #endregion



        #region Mathematical Constants


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/degree/*' />
        public static Single degree()
        {
            return sreal.degree();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phi/*' />
        public static Single phi()
        {
            return sreal.phi();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln2/*' />
        public static Single ln2()
        {
            return sreal.ln2();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln10/*' />
        public static Single ln10()
        {
            return sreal.ln10();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pi/*' />
        public static Single pi()
        {
            return sreal.pi();
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/e/*' />
        public static Single e()
        {
            return sreal.e();
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/egamma/*' />
        public static Single egamma()
        {
            return sreal.egamma();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/apery/*' />
        public static Single apery()
        {
            return sreal.apery();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/catalan/*' />
        public static Single catalan()
        {
            return sreal.catalan();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/glaisher/*' />
        public static Single glaisher()
        {
            return sreal.glaisher();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/khinchin/*' />
        public static Single khinchin()
        {
            return sreal.khinchin();
        }


        #endregion




        #endregion





        #region Flint Basic Functions



        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Single abs(Single x)
        {
            return Math.Abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Single abs(dynamic x)
        {
            return abs(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Single fabs(Single x)
        {
            return Math.Abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Single fabs(dynamic x)
        {
            return fabs(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Single sign(Single x)
        {
            return Math.Sign(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Single sign(dynamic x)
        {
            return sign(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Single real(Single x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Single real(dynamic x)
        {
            return real(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Single imag(Single x)
        {
            return 0.0F;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Single imag(dynamic x)
        {
            return 0.0F;
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Single phase(Single x)
        {
            return sreal.phase(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Single phase(dynamic x)
        {
            return sreal.phase(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Single conj(Single x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Single conj(dynamic x)
        {
            return conj(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Single, Single> polar(Single x)
        {
            return new Tuple<Single, Single>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Single, Single> polar(dynamic x)
        {
            return polar(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static SingleC rect(Single r, Single phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static SingleC rect(dynamic r, dynamic phi)
        {
            return rect(sreal.t(r), sreal.t(phi));
        }






        #endregion




        #region Roots and quadratic, cubic, and quartic 



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Single sqrt(Single x)
        {
            ArbPrec.Init();
            Single res = 0.0F;
            Lib_SReal_Arb_Sqrt(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Sqrt(ref Single res, ref Single x);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Single sqrt(dynamic x)
        {
            return sqrt(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Single rsqrt(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Rsqrt(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Rsqrt(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Single rsqrt(dynamic x)
        {
            return rsqrt(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Single cbrt(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Cbrt(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Cbrt(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Single cbrt(dynamic x)
        {
            return cbrt(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Single sqrt1pm1(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Sqrt1pm1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Sqrt1pm1(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Single sqrt1pm1(dynamic x)
        {
            return sqrt1pm1(sreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Single root_si(Single x, Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Root_ui(ref res, ref x, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Root_ui(ref Single res, ref Single x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Single root_si(dynamic x, Int32 n)
        {
            return root_si(sreal.t(x), n);
        }



        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Single exp(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Exp(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Exp(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Single exp(dynamic x)
        {
            return exp(sreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static SingleC expj(Single x)
        {
            return sflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static SingleC expj(dynamic x)
        {
            return sflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static SingleC expjpi(Single x)
        {
            return sflintc.expjpi(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static SingleC expjpi(dynamic x)
        {
            return sflintc.expjpi(x);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Single exp10(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Exp10(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Exp10(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Single exp10(dynamic x)
        {
            return exp10(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Single exp2(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Exp2(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Exp2(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Single exp2(dynamic x)
        {
            return exp2(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Single expm1(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Expm1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Expm1(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Single expm1(dynamic x)
        {
            return expm1(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Single exp10m1(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Exp10m1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Exp10m1(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Single exp10m1(dynamic x)
        {
            return exp10m1(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Single exp2m1(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Exp2m1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Exp2m1(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Single exp2m1(dynamic x)
        {
            return exp2m1(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Single exprel(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_ExpRel(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_ExpRel(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Single exprel(dynamic x)
        {
            return exprel(sreal.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Single logbase(Single x, Single b)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Logbase(ref res, ref x, ref b);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Logbase(ref Single res, ref Single x, ref Single b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Single logbase(dynamic x, dynamic b)
        {
            return logbase(sreal.t(x), sreal.t(b));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Single log(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Log(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Log(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Single log(dynamic x)
        {
            return log(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Single log10(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Log10(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Log10(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Single log10(dynamic x)
        {
            return log10(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Single log2(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Log2(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Log2(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Single log2(dynamic x)
        {
            return log2(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Single log1p(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Log1p(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Log1p(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Single log1p(dynamic x)
        {
            return log1p(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Single log10p1(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Log10p1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Log10p1(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Single log10p1(dynamic x)
        {
            return log10p1(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Single log2p1(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Log2p1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Log2p1(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Single log2p1(dynamic x)
        {
            return log2p1(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Single log1mexp(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Log1mexp(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Log1mexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Log1mexp(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Single log1mexp(dynamic x)
        {
            return log1mexp(sreal.t(x));
        }





        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Single sqr(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Square(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Square(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Single sqr(dynamic x)
        {
            return sqr(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Single cube(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Cube(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Cube(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Single cube(dynamic x)
        {
            return cube(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Single hypot(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypot(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypot(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Single hypot(dynamic x, dynamic y)
        {
            return hypot(sreal.t(x), sreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Single pow_si(Single x, Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Pow_si(ref res, ref x, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Pow_si(ref Single res, ref Single x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Single pow_si(dynamic x, Int32 n)
        {
            return pow_si(sreal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Single compound_si(Single x, Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Compound_si(ref res, ref x, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Compound_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Compound_si(ref Single res, ref Single x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Single compound_si(dynamic x, Int32 n)
        {
            return compound_si(sreal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Single pow(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Pow(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Pow(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Single pow(dynamic x, dynamic y)
        {
            return pow(sreal.t(x), sreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Single powm1(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Powm1(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Powm1(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Single powm1(dynamic x, dynamic y)
        {
            return powm1(sreal.t(x), sreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Single pow1p(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Pow1p(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Pow1p(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Single pow1p(dynamic x, dynamic y)
        {
            return pow1p(sreal.t(x), sreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Single pow1pm1(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Pow1pm1(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Pow1pm1(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Single pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(sreal.t(x), sreal.t(y));
        }




        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Single sin(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Sin(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Sin(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Single sin(dynamic x)
        {
            return sin(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Single cos(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Cos(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Cos(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Single cos(dynamic x)
        {
            return cos(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Single tan(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Tan(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Tan(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Single tan(dynamic x)
        {
            return tan(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Single cot(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Cot(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Cot(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Single cot(dynamic x)
        {
            return cot(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Single sec(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Sec(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Sec(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Single sec(dynamic x)
        {
            return sec(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Single csc(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Csc(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Csc(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Single csc(dynamic x)
        {
            return csc(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Single sinc(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Sinc(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Sinc(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Single sinc(dynamic x)
        {
            return sinc(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Single sinpi(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_SinPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_SinPi(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Single sinpi(dynamic x)
        {
            return sinpi(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Single cospi(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_CosPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_CosPi(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Single cospi(dynamic x)
        {
            return cospi(sreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Single tanpi(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_TanPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_TanPi(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Single tanpi(dynamic x)
        {
            return tanpi(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Single cotpi(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_CotPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_CotPi(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Single cotpi(dynamic x)
        {
            return cotpi(sreal.t(x));
        }

        // cscpi




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Single cscpi(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_SinPi(ref res, ref x);
            return 1/res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Single cscpi(dynamic x)
        {
            return cscpi(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Single secpi(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_CosPi(ref res, ref x);
            return 1 / res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Single secpi(dynamic x)
        {
            return secpi(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Single sincpi(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_SincPi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_SincPi(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Single sincpi(dynamic x)
        {
            return sincpi(sreal.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Single sinh(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Sinh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Sinh(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Single sinh(dynamic x)
        {
            return sinh(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Single cosh(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Cosh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Cosh(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Single cosh(dynamic x)
        {
            return cosh(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Single tanh(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Tanh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Tanh(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Single tanh(dynamic x)
        {
            return tanh(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Single csch(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Csch(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Csch(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Single csch(dynamic x)
        {
            return csch(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Single sech(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Sech(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Sech(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Single sech(dynamic x)
        {
            return sech(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Single coth(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Coth(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Coth(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Single coth(dynamic x)
        {
            return coth(sreal.t(x));
        }




        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Single asin(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Asin(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Asin(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Single asin(dynamic x)
        {
            return asin(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Single acos(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Acos(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Acos(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Single acos(dynamic x)
        {
            return acos(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Single atan2(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Atan2(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Atan2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Atan2(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Single atan2(dynamic x, dynamic y)
        {
            return atan2(sreal.t(x), sreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Single atan(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Atan(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Atan(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Single atan(dynamic x)
        {
            return atan(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Single acsc(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Acsc(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Acsc(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Single acsc(dynamic x)
        {
            return acsc(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Single asec(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Asec(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Asec(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Single asec(dynamic x)
        {
            return asec(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Single acot(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Acot(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Acot(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Single acot(dynamic x)
        {
            return acot(sreal.t(x));
        }



        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Single asinh(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Asinh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Asinh(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Single asinh(dynamic x)
        {
            return asinh(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Single acosh(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Acosh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Acosh(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Single acosh(dynamic x)
        {
            return acosh(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Single atanh(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Atanh(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Atanh(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Single atanh(dynamic x)
        {
            return atanh(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Single acsch(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Acsch(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Acsch(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Single acsch(dynamic x)
        {
            return acsch(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Single asech(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Asech(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Asech(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Single asech(dynamic x)
        {
            return asech(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Single acoth(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Acoth(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Acoth(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Single acoth(dynamic x)
        {
            return acoth(sreal.t(x));
        }



        #endregion



        #region Gamma and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Single gamma(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Gamma(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Gamma(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Single gamma(dynamic x)
        {
            return gamma(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Single rgamma(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Rgamma(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Rgamma(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Single rgamma(dynamic x)
        {
            return rgamma(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Single lgamma(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Lgamma(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Lgamma(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Single lgamma(dynamic x)
        {
            return lgamma(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Single rising_factorial(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_RisingFactorial(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_RisingFactorial(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Single rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(sreal.t(x), sreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Single beta(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Beta(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Beta(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Single beta(dynamic x, dynamic y)
        {
            return beta(sreal.t(x), sreal.t(y));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Single gamma1pm1(Single x)
        {
            return aflint.SRealViaArbS1(aflint.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Single gamma1pm1(dynamic x)
        {
            return gamma1pm1(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Single factorial(Single x)
        {
            return aflint.SRealViaArbS1(aflint.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Single factorial(dynamic x)
        {
            return factorial(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Single doublefactorial(Single x)
        {
            return aflint.SRealViaArbS1(aflint.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Single doublefactorial(dynamic x)
        {
            return doublefactorial(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Single falling_factorial(Single a, Single n)
        {
            return aflint.SRealViaArbS2(aflint.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Single falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(sreal.t(a), sreal.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Single gamma_ratio(Single a, Single b)
        {
            return aflint.SRealViaArbS2(aflint.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Single gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(sreal.t(a), sreal.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Single gamma_delta_ratio(Single a, Single delta)
        {
            return aflint.SRealViaArbS2(aflint.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Single gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(sreal.t(a), sreal.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Single binomial(Single n, Single k)
        {
            return aflint.SRealViaArbS2(aflint.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Single binomial(dynamic n, dynamic k)
        {
            return binomial(sreal.t(n), sreal.t(k));
        }






        #endregion



        #region Miscellaneous


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Single lambert_w0(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_LambertW0(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_LambertW0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_LambertW0(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Single lambert_w0(dynamic x)
        {
            return lambert_w0(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Single lambert_wm1(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_LambertWm1(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_LambertWm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_LambertWm1(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Single lambert_wm1(dynamic x)
        {
            return lambert_wm1(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static SingleC lambert_wk(Single x, int k)
        {
            return sflintc.lambert_wk(scplx.t(x), k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static SingleC lambert_wk(dynamic x, int k)
        {
            return lambert_wk(sreal.t(x), k);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Single agm(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Agm(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Agm(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Single agm(dynamic x, dynamic y)
        {
            return agm(sreal.t(x), sreal.t(y));
        }







        #endregion




        #endregion





        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Single m_elliptic_k(Single m)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_MEllipticK(ref res, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_MEllipticK(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Single m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Single m_elliptic_e(Single m)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_MEllipticE(ref res, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_MEllipticE(ref Single res, ref Single m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Single m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Single m_elliptic_pi(Single n, Single m)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_MEllipticPi(ref res, ref n, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_MEllipticPi(ref Single res, ref Single n, ref Single m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Single m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(sreal.t(x), sreal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Single m_elliptic_f(Single phi, Single m)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_MEllipticF(ref res, ref phi, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_MEllipticF(ref Single res, ref Single phi, ref Single m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Single m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(sreal.t(phi), sreal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Single m_elliptic_e_inc(Single phi, Single m)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_MEllipticEInc(ref res, ref phi, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_MEllipticEInc(ref Single res, ref Single phi, ref Single m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Single m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(sreal.t(phi), sreal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Single m_elliptic_pi_inc(Single n, Single phi, Single m)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_MEllipticPiInc(ref res, ref n, ref phi, ref m);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_MEllipticPiInc(ref Single res, ref Single n, ref Single phi, ref Single m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Single m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(sreal.t(n), sreal.t(phi), sreal.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Single elliptic_k(Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_EllipticK(ref res, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_EllipticK(ref Single res, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Single elliptic_k(dynamic k)
        {
            return elliptic_k(sreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Single elliptic_e(Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_EllipticE(ref res, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_EllipticE(ref Single res, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Single elliptic_e(dynamic k)
        {
            return elliptic_e(sreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Single elliptic_pi(Single n, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_EllipticPi(ref res, ref n, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_EllipticPi(ref Single res, ref Single n, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Single elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(sreal.t(n), sreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Single elliptic_f(Single phi, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_EllipticF(ref res, ref phi, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_EllipticF(ref Single res, ref Single phi, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Single elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(sreal.t(phi), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Single elliptic_e_inc(Single phi, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_EllipticEInc(ref res, ref phi, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_EllipticEInc(ref Single res, ref Single phi, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Single elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(sreal.t(phi), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Single elliptic_pi_inc(Single n, Single phi, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_EllipticPiInc(ref res, ref n, ref phi, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_EllipticPiInc(ref Single res, ref Single n, ref Single phi, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Single elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(sreal.t(n), sreal.t(phi), sreal.t(k));
        }



        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Single elliptic_rc(Single x, Single y)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Elliptic_RC(ref res, ref x, ref y);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Elliptic_RC(ref Single res, ref Single x, ref Single y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Single elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(sreal.t(x), sreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Single elliptic_rf(Single x, Single y, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Elliptic_RF(ref res, ref x, ref y, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Elliptic_RF(ref Single res, ref Single x, ref Single y, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Single elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(sreal.t(x), sreal.t(y), sreal.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Single elliptic_rg(Single x, Single y, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Elliptic_RG(ref res, ref x, ref y, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Elliptic_RG(ref Single res, ref Single x, ref Single y, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Single elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(sreal.t(x), sreal.t(y), sreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Single elliptic_rd(Single x, Single y, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Elliptic_RD(ref res, ref x, ref y, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Elliptic_RD(ref Single res, ref Single x, ref Single y, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Single elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(sreal.t(x), sreal.t(y), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Single elliptic_rj(Single x, Single y, Single z, Single w)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Elliptic_RJ(ref res, ref x, ref y, ref z, ref w);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Elliptic_RJ(ref Single res, ref Single x, ref Single y, ref Single z, ref Single w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Single elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(sreal.t(x), sreal.t(y), sreal.t(z), sreal.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Single jacobi_theta1(Single x, Single q)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Theta1Q(ref res, ref x, ref q);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Theta1Q(ref Single res, ref Single x, ref Single q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Single jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(sreal.t(x), sreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Single jacobi_theta2(Single x, Single q)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Theta2Q(ref res, ref x, ref q);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Theta2Q(ref Single res, ref Single x, ref Single q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Single jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(sreal.t(x), sreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Single jacobi_theta3(Single x, Single q)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Theta3Q(ref res, ref x, ref q);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Theta3Q(ref Single res, ref Single x, ref Single q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Single jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(sreal.t(x), sreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Single jacobi_theta4(Single x, Single q)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Theta4Q(ref res, ref x, ref q);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_Theta4Q(ref Single res, ref Single x, ref Single q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Single jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(sreal.t(x), sreal.t(q));
        }




        #endregion



        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Single jacobi_sn(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiSN(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiSN(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Single jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Single jacobi_cn(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiCN(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiCN(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Single jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Single jacobi_dn(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiDN(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiDN(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Single jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Single jacobi_ns(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiNS(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiNS(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Single jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Single jacobi_nc(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiNC(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiNC(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Single jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Single jacobi_nd(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiND(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiND(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Single jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Single jacobi_sc(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiSC(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiSC(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Single jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Single jacobi_sd(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiSD(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiSD(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Single jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Single jacobi_dc(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiDC(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiDC(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Single jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Single jacobi_ds(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiDS(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiDS(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Single jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Single jacobi_cs(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiCS(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiCS(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Single jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(sreal.t(x), sreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Single jacobi_cd(Single x, Single k)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiCD(ref res, ref x, ref k);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SReal_Arb_JacobiCD(ref Single res, ref Single x, ref Single k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Single jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(sreal.t(x), sreal.t(k));
        }








        #endregion



        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Single lerch_phi(Single s, Single z, Single a)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_LerchPhi(ref res, ref s, ref z, ref a);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_LerchPhi(ref Single res, ref Single s, ref Single z, ref Single a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Single lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(sreal.t(s), sreal.t(z), sreal.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static SingleC lerch_zeta(Single lambda1, Single alpha, Single s)
        {
            var res = sflintc.lerch_zeta(lambda1, alpha, s);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static SingleC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(sreal.t(lambda1), sreal.t(alpha), sreal.t(s));
        }






        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Single polygamma(Single s, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Polygamma(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Polygamma(ref Single res, ref Single s, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Single polygamma(dynamic s, dynamic z)
        {
            return polygamma(sreal.t(s), sreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Single trigamma(Single x)
        {
            return polygamma(1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Single trigamma(dynamic x)
        {
            return trigamma(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Single digamma(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Digamma(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Digamma(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Single digamma(dynamic x)
        {
            return digamma(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Single harmonic(Single x)
        {
            SingleC res = sflintc.harmonic(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Single harmonic(dynamic x)
        {
            return harmonic(sreal.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Single polylog(Single s, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Polylog(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Polylog(ref Single res, ref Single s, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Single polylog(dynamic s, dynamic z)
        {
            return polylog(sreal.t(s), sreal.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Single trilog(Single x)
        {
            SingleC res = sflintc.trilog(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Single trilog(dynamic x)
        {
            return trilog(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Single dilog(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Dilog(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Dilog(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Single dilog(dynamic x)
        {
            return dilog(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Single clausen_sin(Single s, Single z)
        {
            SingleC res = sflintc.clausen_sin(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Single clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(sreal.t(s), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Single clausen_cos(Single s, Single z)
        {
            SingleC res = sflintc.clausen_cos(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Single clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(sreal.t(s), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Single clausen2(Single x)
        {
            return clausen_sin(sreal.t(2), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Single clausen2(dynamic x)
        {
            return clausen_sin(sreal.t(2), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Single bose_einstein(Single s, Single z)
        {
            SingleC res = sflintc.bose_einstein(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Single bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(sreal.t(s), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Single fermi_dirac(Single s, Single z)
        {
            SingleC res = sflintc.fermi_dirac(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Single fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(sreal.t(s), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Single legendre_chi(Single s, Single z)
        {
            SingleC res = sflintc.legendre_chi(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Single legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(sreal.t(s), sreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Single inverse_tan_integral(Single s, Single z)
        {
            SingleC res = sflintc.inverse_tan_integral(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Single inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(sreal.t(s), sreal.t(z));
        }






        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Single hurwitz_zeta(Single s, Single a)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_HurwitzZeta(ref res, ref s, ref a);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_HurwitzZeta(ref Single res, ref Single s, ref Single a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Single hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(sreal.t(s), sreal.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Single harmonic2(Single z, Single r)
        {
            SingleC res = sflintc.harmonic2(z, r);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Single harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(sreal.t(z), sreal.t(r));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Single bernoulli(Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Bernoulli_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Bernoulli_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Bernoulli_ui(ref Single res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Single bernpoly(Single x, Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_BernoulliPoly_ui(ref res, ref x, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_BernoulliPoly_ui(ref Single res, ref Single x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Single bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(sreal.t(x), n);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulernum/*' />
        public static Single eulernum(Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Euler_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Euler_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Euler_ui(ref Single res, Int32 n);






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Single eulerpoly(Single x, Int32 n)
        {
            SingleC res = sflintc.eulerpoly(x, n);
            return res.real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Single eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(sreal.t(x), n);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Single barnes_g(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_BarnesG(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_BarnesG(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Single barnes_g(dynamic x)
        {
            return barnes_g(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Single logbarnes_g(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_LogBarnesG(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_LogBarnesG(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Single logbarnes_g(dynamic x)
        {
            return logbarnes_g(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Single hyperfactorial(Single x)
        {
            SingleC res = sflintc.hyperfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Single hyperfactorial(dynamic x)
        {
            return hyperfactorial(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Single superfactorial(Single x)
        {
            SingleC res = sflintc.superfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Single superfactorial(dynamic x)
        {
            return superfactorial(sreal.t(x));
        }







        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Single zeta(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Zeta(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Zeta(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Single zeta(dynamic x)
        {
            return zeta(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Single zetam1(Single x)
        {
            SingleC res = sflintc.zetam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Single zetam1(dynamic x)
        {
            return zetam1(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Single hardy_theta(Single x)
        {
            SingleC res = sflintc.hardy_theta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Single hardy_theta(dynamic x)
        {
            return hardy_theta(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Single hardy_z(Single x)
        {
            SingleC res = sflintc.hardy_z(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Single hardy_z(dynamic x)
        {
            return hardy_z(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Single riemann_xi(Single x)
        {
            SingleC res = sflintc.riemann_xi(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Single riemann_xi(dynamic x)
        {
            return riemann_xi(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Single dirichlet_eta(Single x)
        {
            SingleC res = sflintc.dirichlet_eta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Single dirichlet_eta(dynamic x)
        {
            return dirichlet_eta(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Single dirichlet_etam1(Single x)
        {
            SingleC res = sflintc.dirichlet_etam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Single dirichlet_etam1(dynamic x)
        {
            return dirichlet_etam1(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Single dirichlet_beta(Single x)
        {
            SingleC res = sflintc.dirichlet_beta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Single dirichlet_beta(dynamic x)
        {
            return dirichlet_beta(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Single dirichlet_lambda(Single x)
        {
            SingleC res = sflintc.dirichlet_lambda(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Single dirichlet_lambda(dynamic x)
        {
            return dirichlet_lambda(sreal.t(x));
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Single backlund_s(Single x)
        //{
        //    ArbPrec.Init(); Single res = 0.0F;
        //    Lib_SReal_Arb_BacklundS(ref res, ref x);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_BacklundS", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SReal_Arb_BacklundS(ref Single res, ref Single x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Single backlund_s(dynamic x)
        //{
        //    return zeta(sreal.t(x));
        //}





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/grampoint/*' />
        //public static Single grampoint(Int32 n)
        //{
        //    ArbPrec.Init(); Single res = 0.0F;
        //    Lib_SReal_Arb_GramPoint_ui(ref res, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_GramPoint_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SReal_Arb_GramPoint_ui(ref Single res, Int32 n);







        #endregion



        #region Additional numbertheoretic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bell/*' />
        public static Single bell(Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Bell_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Bell_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Bell_ui(ref Single res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/partitions/*' />
        public static Single partitions(Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Partitions_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Partitions_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Partitions_ui(ref Single res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/primorial/*' />
        public static Single primorial(Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Primorial_ui(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Primorial_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Primorial_ui(ref Single res, Int32 n);





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Single hyperg_0f1(Single a, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypgeom0F1(ref res, ref a, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypgeom0F1(ref Single res, ref Single a, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Single hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(sreal.t(a), sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Single hyperg_0f1r(Single a, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypgeom0F1r(ref res, ref a, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypgeom0F1r(ref Single res, ref Single a, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Single hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(sreal.t(a), sreal.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Single bessel_jv(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Single bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(sreal.t(nu), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Single bessel_yv(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Single bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(sreal.t(nu), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Single bessel_iv(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Single bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(sreal.t(nu), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Single bessel_kv(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Single bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(sreal.t(nu), sreal.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Single bessel_jv_prime(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Single bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(sreal.t(nu), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Single bessel_yv_prime(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Single bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(sreal.t(nu), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Single bessel_iv_prime(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Single bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(sreal.t(nu), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Single bessel_kv_prime(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Single bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(sreal.t(nu), sreal.t(x), scaled);
        }









        #endregion



        #region 0F1: Spherical Bessel functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Single sph_bessel_jn(Single n, Single x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (sreal.isnan(x)) return sreal.nan();
            if (sreal.isinf(x)) return sreal.zero();
            if (sreal.isneginf(x)) return sreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return sreal.one();
                    else return sreal.zero();
                }
                else
                {
                    if (n % 2 == 0) return sreal.neginf(); else return sreal.nan();
                }
            }
            return sflintc.sph_bessel_jn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Single sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(sreal.t(n), sreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Single sph_bessel_yn(Single n, Single x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (sreal.isnan(x)) return sreal.nan();
            if (sreal.isinf(x)) return sreal.zero();
            if (sreal.isneginf(x)) return sreal.zero();
            if (x == 0.0)
            {
                if (n < 0)
                {
                    if ((n == -1)) return sreal.one();
                    else return sreal.zero();
                }
                else
                {
                    if (n % 2 != 0) return sreal.neginf(); else return sreal.nan();
                }
            }
            return sflintc.sph_bessel_yn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Single sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(sreal.t(n), sreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Single sph_bessel_in(Single n, Single x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (sreal.isnan(x)) return sreal.nan();
            if (sreal.isinf(x)) return sreal.inf();
            if (sreal.isneginf(x)) return sreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return sreal.one();
                    else return sreal.zero();
                }
                else
                {
                    if (n % 2 == 0) return sreal.neginf(); else return sreal.nan();
                }
            }

            return sflintc.sph_bessel_in(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Single sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(sreal.t(n), sreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Single sph_bessel_kn(Single n, Single x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (sreal.isnan(x)) return sreal.nan();
            if (sreal.isinf(x)) return sreal.zero();
            if (sreal.isneginf(x)) return sreal.neginf();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if (n % 2 == 0) return sreal.nan(); else return sreal.inf();
                }
                else
                {
                    if (n % 2 == 0) return sreal.inf(); else return sreal.nan();
                }
            }

            return sflintc.sph_bessel_kn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Single sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(sreal.t(n), sreal.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Single besselpoly(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.besselpoly, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Single besselpoly(dynamic nu, dynamic x, bool scaled = false)
        {
            return besselpoly(sreal.t(nu), sreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Single besseltheta(Single nu, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2Bool1(aflint.besseltheta, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Single besseltheta(dynamic nu, dynamic x, bool scaled = false)
        {
            return besseltheta(sreal.t(nu), sreal.t(x), scaled);
        }








        #endregion



        #region Spherical Bessel functions, first derivative




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Single sph_bessel_jn_prime(Single n, Single x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (sreal.isnan(x)) return sreal.nan();
            if (sreal.isinf(x)) return sreal.zero();
            if (sreal.isneginf(x)) return sreal.zero();
            if (x == 0.0)
            {
                if (n == 1) return 1 / sreal.t(3);
                if (n >= 0) return sreal.zero();
                else
                {
                    if (n % 2 != 0) return sreal.neginf(); else return sreal.nan();
                }
            }
            return sflintc.sph_bessel_jn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Single sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(sreal.t(n), sreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Single sph_bessel_yn_prime(Single n, Single x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (sreal.isnan(x)) return sreal.nan();
            if (sreal.isinf(x)) return sreal.zero();
            if (sreal.isneginf(x)) return sreal.zero();
            if (x == 0.0)
            {
                if (n == -2) return -1 / sreal.t(3);
                if (n < 0) return sreal.zero();
                else
                {
                    if (n % 2 == 0) return sreal.inf(); else return sreal.nan();
                }
            }
            return sflintc.sph_bessel_yn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Single sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(sreal.t(n), sreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Single sph_bessel_in_prime(Single n, Single x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (sreal.isnan(x)) return sreal.nan();
            if (sreal.isinf(x)) return sreal.inf();
            if (sreal.isneginf(x))
            {
                if (n % 2 == 0) return sreal.neginf(); else return sreal.inf();
            }
            if (x == 0.0)
            {
                if (n == 0) return sreal.zero();
                if (n < 0)
                {
                    if (n % 2 != 0) return sreal.neginf(); else return sreal.nan();
                }
            }
            return sflintc.sph_bessel_in_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Single sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(sreal.t(n), sreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Single sph_bessel_kn_prime(Single n, Single x, bool scaled = false)
        {
            if (!sreal.isinteger(n)) return sreal.nan();

            if (sreal.isnan(x)) return sreal.nan();
            if (sreal.isinf(x)) return sreal.zero();
            if (sreal.isneginf(x)) return sreal.neginf();
            if (x == 0.0)
            {
                if (((n >= 0) && (n % 2 == 0)) || ((n < 0) && (n % 2 != 0))) return sreal.neginf();
                else return sreal.nan();
            }
            return sflintc.sph_bessel_kn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Single sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(sreal.t(n), sreal.t(x), scaled);
        }





        #endregion



        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static SingleC hankel_h1(Single v, Single x)
        {
            return bessel_jv(v, x) + scplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static SingleC hankel_h1(dynamic v, dynamic x)
        {
            return hankel_h1(sreal.t(v), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static SingleC hankel_h2(Single v, Single x)
        {
            return bessel_jv(v, x) - scplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static SingleC hankel_h2(dynamic v, dynamic x)
        {
            return hankel_h2(sreal.t(v), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static SingleC sph_hankel_h1(int n, Single x)
        {
            return sph_bessel_jn(n, x) + scplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static SingleC sph_hankel_h1(int n, dynamic x)
        {
            return sph_hankel_h1(n, sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static SingleC sph_hankel_h2(int n, Single x)
        {
            return sph_bessel_jn(n, x) - scplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static SingleC sph_hankel_h2(int n, dynamic x)
        {
            return sph_hankel_h2(n, sreal.t(x));
        }






        #endregion



        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Single airy_ai(Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS1Bool1(aflint.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Single airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Single airy_ai_prime(Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS1Bool1(aflint.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Single airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Single airy_bi(Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS1Bool1(aflint.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Single airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Single airy_bi_prime(Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS1Bool1(aflint.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Single airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        public static Single airy_ai_zero(Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_AiryAiZero(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_AiryAiZero(ref Single res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        public static Single airy_ai_prime_zero(UInt32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_AiryAiPrimeZero(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_AiryAiPrimeZero(ref Single res, UInt32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        public static Single airy_bi_zero(Int32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_AiryBiZero(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_AiryBiZero(ref Single res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        public static Single airy_bi_prime_zero(UInt32 n)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_AiryBiPrimeZero(ref res, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_AiryBiPrimeZero(ref Single res, UInt32 n);



        #endregion



        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Single kelvin_ber(Single v, Single x, bool scaled = false)
        {
            return sflintc.kelvin_ber(scplx.t(v), scplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Single kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(sreal.t(v), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Single kelvin_bei(Single v, Single x, bool scaled = false)
        {
            return sflintc.kelvin_bei(scplx.t(v), scplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Single kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(sreal.t(v), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Single kelvin_ker(Single v, Single x, bool scaled = false)
        {
            return sflintc.kelvin_ker(scplx.t(v), scplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Single kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(sreal.t(v), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Single kelvin_kei(Single v, Single x, bool scaled = false)
        {
            return sflintc.kelvin_kei(scplx.t(v), scplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Single kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(sreal.t(v), sreal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Single kelvin_ber_prime(Single v, Single x, bool scaled = false)
        {
            return sflintc.kelvin_ber_prime(scplx.t(v), scplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Single kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(sreal.t(v), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Single kelvin_bei_prime(Single v, Single x, bool scaled = false)
        {
            return sflintc.kelvin_bei_prime(scplx.t(v), scplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Single kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(sreal.t(v), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Single kelvin_ker_prime(Single v, Single x, bool scaled = false)
        {
            return sflintc.kelvin_ker_prime(scplx.t(v), scplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Single kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(sreal.t(v), sreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Single kelvin_kei_prime(Single v, Single x, bool scaled = false)
        {
            return sflintc.kelvin_kei_prime(scplx.t(v), scplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Single kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(sreal.t(v), sreal.t(x), scaled);
        }






        #endregion







        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Single hyperg_1f1(Single a, Single b, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypgeom1F1(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypgeom1F1(ref Single res, ref Single a, ref Single b, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Single hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(sreal.t(a), sreal.t(b), sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Single hyperg_1f1r(Single a, Single b, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypgeom1F1r(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypgeom1F1r(ref Single res, ref Single a, ref Single b, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Single hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(sreal.t(a), sreal.t(b), sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Single hyperg_u(Single a, Single b, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_HypgeomU(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_HypgeomU(ref Single res, ref Single a, ref Single b, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Single hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(sreal.t(a), sreal.t(b), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Single hermite_h(Single n, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_HermiteH(ref res, ref n, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_HermiteH(ref Single res, ref Single n, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Single hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(sreal.t(n), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Single hermite_he(Single n, Single x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Single hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(sreal.t(n), sreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Single laguerre_l(Single n, Single m, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_LaguerreL(ref res, ref n, ref m, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_LaguerreL(ref Single res, ref Single n, ref Single m, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Single laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(sreal.t(n), sreal.t(m), sreal.t(x));
        }





        #endregion




        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Single gamma_upper(Single s, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_GammaUpper(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_GammaUpper(ref Single res, ref Single s, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Single gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(sreal.t(s), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Single gamma_q(Single s, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_GammaQ(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_GammaQ(ref Single res, ref Single s, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Single gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(sreal.t(s), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Single gamma_lower(Single s, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_GammaLower(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_GammaLower(ref Single res, ref Single s, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Single gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(sreal.t(s), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Single gamma_p(Single s, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_GammaP(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_GammaP(ref Single res, ref Single s, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Single gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(sreal.t(s), sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Single gamma_p_prime(Single s, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_GammaPPrime(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_GammaPPrime(ref Single res, ref Single s, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Single gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(sreal.t(s), sreal.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Single erf(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Erf(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Erf(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Single erf(dynamic x)
        {
            return erf(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Single erfc(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Erfc(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Erfc(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Single erfc(dynamic x)
        {
            return erfc(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Single erf_inv(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Erfinv(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Erfinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Erfinv(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Single erf_inv(dynamic x)
        {
            return erf_inv(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Single erfc_inv(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Erfcinv(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Erfcinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Erfcinv(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Single erfc_inv(dynamic x)
        {
            return erfc_inv(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Single erfi(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Erfi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Erfi(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Single erfi(dynamic x)
        {
            return erfi(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Single dawson(Single x)
        {
            return aflint.SRealViaArbS1(aflint.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Single dawson(dynamic x)
        {
            return dawson(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Single fresnel_s(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_FresnelS(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_FresnelS(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Single fresnel_s(dynamic x)
        {
            return fresnel_s(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Single fresnel_c(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_FresnelC(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_FresnelC(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Single fresnel_c(dynamic x)
        {
            return fresnel_c(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Single ndens(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Ndens(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Ndens(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Single ndens(dynamic x)
        {
            return ndens(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Single ndis(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Ndis(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Ndis(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Single ndis(dynamic x)
        {
            return ndis(sreal.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Single exp_integral_en(Single s, Single z)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_ExpIntegralE(ref res, ref s, ref z);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_ExpIntegralE(ref Single res, ref Single s, ref Single z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Single exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(sreal.t(s), sreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Single exp_integral_e1(Single z)
        {
            if (z < 0) return -exp_integral_ei(-z);
            else return exp_integral_en(sreal.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Single exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(sreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Single exp_integral_ei(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_ExpIntegralEi(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_ExpIntegralEi(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Single exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Single sin_integral(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_SinIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_SinIntegral(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Single sin_integral(dynamic x)
        {
            return sin_integral(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Single cos_integral(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_CosIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_CosIntegral(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Single cos_integral(dynamic x)
        {
            return cos_integral(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Single sinh_integral(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_SinhIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_SinhIntegral(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Single sinh_integral(dynamic x)
        {
            return sinh_integral(sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Single cosh_integral(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_CoshIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_CoshIntegral(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Single cosh_integral(dynamic x)
        {
            return cosh_integral(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Single log_integral(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_LogIntegral(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_LogIntegral(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Single log_integral(dynamic x)
        {
            return log_integral(sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Single log_integral_offset(Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_LogIntegralOffset(ref res, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_LogIntegralOffset(ref Single res, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Single log_integral_offset(dynamic x)
        {
            return log_integral_offset(sreal.t(x));
        }



        #endregion





        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Single coulomb_f(Single l, Single eta, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_CoulombF(ref res, ref l, ref eta, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_CoulombF(ref Single res, ref Single l, ref Single eta, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Single coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(sreal.t(l), sreal.t(eta), sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Single coulomb_g(Single l, Single eta, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_CoulombG(ref res, ref l, ref eta, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_CoulombG(ref Single res, ref Single l, ref Single eta, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Single coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(sreal.t(l), sreal.t(eta), sreal.t(x));
        }



        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Single whittaker_m(Single k, Single m, Single x)
        {
            return aflint.SRealViaArbS3(aflint.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Single whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(sreal.t(k), sreal.t(m), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Single whittaker_w(Single k, Single m, Single x)
        {
            return aflint.SRealViaArbS3(aflint.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Single whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(sreal.t(k), sreal.t(m), sreal.t(x));
        }




        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Single pcfd(Single n, Single x)
        {
            return aflint.SRealViaArbS2(aflint.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Single pcfd(dynamic n, dynamic x)
        {
            return pcfd(sreal.t(n), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Single pcfu(Single a, Single x)
        {
            return aflint.SRealViaArbS2(aflint.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Single pcfu(dynamic a, dynamic x)
        {
            return pcfu(sreal.t(a), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Single pcfv(Single a, Single x)
        {
            return aflint.SRealViaArbS2(aflint.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Single pcfv(dynamic a, dynamic x)
        {
            return pcfv(sreal.t(a), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Single pcfw(Single a, Single x)
        {
            return aflint.SRealViaArbS2(aflint.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Single pcfw(dynamic a, dynamic x)
        {
            return pcfw(sreal.t(a), sreal.t(x));
        }





        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Single hyperg_2f1(Single a, Single b, Single c, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypgeom2F1(ref res, ref a, ref b, ref c, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hyp2f1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypgeom2F1(ref Single res, ref Single a, ref Single b, ref Single c, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Single hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(sreal.t(a), sreal.t(b), sreal.t(c), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Single hyperg_2f1r(Single a, Single b, Single c, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypgeom2F1r(ref res, ref a, ref b, ref c, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hyp2f1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypgeom2F1r(ref Single res, ref Single a, ref Single b, ref Single c, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Single hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(sreal.t(a), sreal.t(b), sreal.t(c), sreal.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Single chebyshev_t(Single n, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_ChebyshevT(ref res, ref n, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_ChebyshevT(ref Single res, ref Single n, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Single chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(sreal.t(n), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Single chebyshev_u(Single n, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_ChebyshevU(ref res, ref n, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_ChebyshevU(ref Single res, ref Single n, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Single chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(sreal.t(n), sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static Single chebyshev_v(Single n, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2(aflint.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Single chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(sreal.t(n), sreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static Single chebyshev_w(Single n, Single x, bool scaled = false)
        {
            return aflint.SRealViaArbS2(aflint.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Single chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(sreal.t(n), sreal.t(y));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Single gegenbauer_c(Single n, Single m, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_GegenbauerC(ref res, ref n, ref m, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_GegenbauerC(ref Single res, ref Single n, ref Single m, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Single gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(sreal.t(n), sreal.t(m), sreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Single jacobi_p(Single n, Single a, Single b, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_JacobiP(ref res, ref n, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_JacobiP(ref Single res, ref Single n, ref Single a, ref Single b, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Single jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(sreal.t(n), sreal.t(a), sreal.t(b), sreal.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Single legendre_p(Single n, Single x)
        {
            return aflint.SRealViaArbS2(aflint.legendre_p, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_p/*' />
        public static Single legendre_p(dynamic n, dynamic y)
        {
            return legendre_p(sreal.t(n), sreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Single legendre_q(Single n, Single x)
        {
            return aflint.SRealViaArbS2(aflint.legendre_q, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_q/*' />
        public static Single legendre_q(dynamic n, dynamic y)
        {
            return legendre_q(sreal.t(n), sreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Single legendre_plm(Single n, Single m, Single x)
        {
            return aflint.SRealViaArbS3(aflint.legendre_plm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_plm/*' />
        public static Single legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(sreal.t(n), sreal.t(m), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Single legendre_qlm(Single n, Single m, Single x)
        {
            return aflint.SRealViaArbS3(aflint.legendre_qlm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_qlm/*' />
        public static Single legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(sreal.t(n), sreal.t(m), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_plm/*' />
        public static Single toroidal_plm(Single l, Single m, Single x)
        {
            return aflint.SRealViaArbS3(aflint.toroidal_plm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_plm/*' />
        public static Single toroidal_plm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_plm(sreal.t(l), sreal.t(m), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_qlm/*' />
        public static Single toroidal_qlm(Single l, Single m, Single x)
        {
            return aflint.SRealViaArbS3(aflint.toroidal_qlm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_qlm/*' />
        public static Single toroidal_qlm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_qlm(sreal.t(l), sreal.t(m), sreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static SingleC spherical_y(Single n, Single m, Single theta, Single phi)
        {
            return sflintc.spherical_y(scplx.t(n), scplx.t(m), scplx.t(theta), scplx.t(phi));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static SingleC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(sreal.t(n), sreal.t(m), sreal.t(theta), sreal.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Single beta_lower(Single a, Single b, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_BetaLower(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_BetaLower(ref Single res, ref Single a, ref Single b, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Single beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(sreal.t(a), sreal.t(b), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Single ibeta(Single a, Single b, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Ibeta(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Ibeta(ref Single res, ref Single a, ref Single b, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Single ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(sreal.t(a), sreal.t(b), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Single ibetac(Single a, Single b, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Ibetac(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Ibetac(ref Single res, ref Single a, ref Single b, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Single ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(sreal.t(a), sreal.t(b), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Single ibeta_prime(Single a, Single b, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_IbetaPrime(ref res, ref a, ref b, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_IbetaPrime(ref Single res, ref Single a, ref Single b, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Single ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(sreal.t(a), sreal.t(b), sreal.t(x));
        }


        #endregion



        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Single hyperg_1f2(Single a1, Single b1, Single b2, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypgeom1F2(ref res, ref a1, ref b1, ref b2, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypgeom1F2(ref Single res, ref Single a1, ref Single b1, ref Single b2, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Single hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(sreal.t(a1), sreal.t(b1), sreal.t(b2), sreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Single hyperg_1f2r(Single a1, Single b1, Single b2, Single x)
        {
            ArbPrec.Init(); Single res = 0.0F;
            Lib_SReal_Arb_Hypgeom1F2r(ref res, ref a1, ref b1, ref b2, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SReal_Arb_Hypgeom1F2r(ref Single res, ref Single a1, ref Single b1, ref Single b2, ref Single x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Single hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(sreal.t(a1), sreal.t(b1), sreal.t(b2), sreal.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Single airy_gi(Single x)
        {
            return aflint.SRealViaArbS1(aflint.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Single airy_gi(dynamic x)
        {
            return airy_gi(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Single airy_hi(Single x)
        {
            return aflint.SRealViaArbS1(aflint.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Single airy_hi(dynamic x)
        {
            return airy_hi(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Single airy_gi_prime(Single x)
        {
            return aflint.SRealViaArbS1(aflint.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Single airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Single airy_hi_prime(Single x)
        {
            return aflint.SRealViaArbS1(aflint.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Single airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(sreal.t(x));
        }


        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Single struve_h(Single v, Single x)
        {
            return aflint.SRealViaArbS2(aflint.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Single struve_h(dynamic v, dynamic x)
        {
            return struve_h(sreal.t(v), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Single struve_l(Single v, Single x)
        {
            return aflint.SRealViaArbS2(aflint.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Single struve_l(dynamic v, dynamic x)
        {
            return struve_l(sreal.t(v), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Single struve_k(Single v, Single x)
        {
            return aflint.SRealViaArbS2(aflint.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Single struve_k(dynamic v, dynamic x)
        {
            return struve_k(sreal.t(v), sreal.t(x));
        }


        public static Single struve_m(Single v, Single x)
        {
            return aflint.SRealViaArbS2(aflint.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static Single struve_m(dynamic v, dynamic x)
        {
            return struve_m(sreal.t(v), sreal.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Single anger_j(Single v, Single x)
        {
            return aflint.SRealViaArbS2(aflint.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Single anger_j(dynamic v, dynamic x)
        {
            return anger_j(sreal.t(v), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Single weber_e(Single v, Single x)
        {
            return aflint.SRealViaArbS2(aflint.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Single weber_e(dynamic v, dynamic x)
        {
            return weber_e(sreal.t(v), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Single lommel_s1(Single mu, Single nu, Single x)
        {
            return aflint.SRealViaArbS3(aflint.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Single lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(sreal.t(mu), sreal.t(nu), sreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Single lommel_s2(Single mu, Single nu, Single x)
        {
            return aflint.SRealViaArbS3(aflint.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Single lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(sreal.t(mu), sreal.t(nu), sreal.t(x));
        }


        #endregion






        #endregion





    }












    public class sflintc
    {


        /// <summary>
        /// Returns a new SingleC using an ArbC number as input
        /// </summary>
        public static SingleC t(ArbC x)
        {
            SingleC res = scplx.t(0);
            Lib_SCplx_Set_Acb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Set_Acb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Set_Acb(IntPtr res, IntPtr x);


        /// <summary>
        /// Returns a new SingleC using an MpfrC number as input
        /// </summary>
        public static SingleC t(MpfrC x)
        {
            SingleC res = scplx.t(0);
            Lib_SCplx_Set_MpfrC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Set_MpfrC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Set_MpfrC(IntPtr res, IntPtr x);





        public static String fmt(SingleC z)
        {
            return scplx.fmt(z);
        }

        public static String fmt(Single x)
        {
            return sreal.fmt(x);
        }


        public static String fmt(dynamic z)
        {
            return fmt(scplx.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "sflintc"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "sflintc"; }
        }


        public static sflint realctx
        {
            get { return new sflint(); }
        }





        #region Flint Basic Functions




        #region Complex components


        public static Single abs(SingleC z)
        {
            return scplx.abs(z);
        }


        public static Single abs(dynamic z)
        {
            return scplx.abs(z);
        }

        public static Single fabs(SingleC z)
        {
            return scplx.fabs(z);
        }


        public static Single fabs(dynamic z)
        {
            return scplx.fabs(z);
        }


        public static SingleC sign(SingleC z)
        {
            return scplx.sign(z);
        }


        public static SingleC sign(dynamic z)
        {
            return scplx.sign(z);
        }



        public static Single real(SingleC z)
        {
            return z.real;
        }


        public static Single real(dynamic z)
        {
            return real(scplx.t(z));
        }



        public static Single imag(SingleC z)
        {
            return z.imag;
        }


        public static Single imag(dynamic z)
        {
            return imag(scplx.t(z));
        }



        public static Single phase(SingleC z)
        {
            return scplx.phase(z);
        }


        public static Single phase(dynamic z)
        {
            return scplx.phase(z);
        }



        public static SingleC conj(SingleC z)
        {
            return scplx.conj(z);
        }


        public static SingleC conj(dynamic z)
        {
            return scplx.conj(z);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Single, Single> polar(SingleC x)
        {
            return new Tuple<Single, Single>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Single, Single> polar(dynamic x)
        {
            return polar(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static SingleC rect(Single r, Single phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static SingleC rect(dynamic r, dynamic phi)
        {
            return rect(sreal.t(r), sreal.t(phi));
        }





        #endregion



        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static SingleC sqrt(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static SingleC sqrt(dynamic x)
        {
            return sqrt(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static SingleC rsqrt(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static SingleC rsqrt(dynamic x)
        {
            return sqrt(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static SingleC cbrt(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static SingleC cbrt(dynamic x)
        {
            return cbrt(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static SingleC sqrt1pm1(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static SingleC sqrt1pm1(dynamic x)
        {
            return cbrt(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static SingleC unitroot(Int32 n)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_UnitRoot_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_UnitRoot_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_UnitRoot_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static SingleC root_si(SingleC x, Int32 n)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Root_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static SingleC root_si(dynamic x, Int32 n)
        {
            return root_si(scplx.t(x), n);
        }


        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static SingleC exp(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static SingleC exp(dynamic x)
        {
            return exp(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static SingleC expj(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Expj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Expj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Expj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static SingleC expj(dynamic x)
        {
            return expj(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static SingleC expjpi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Expjpi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Expjpi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Expjpi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static SingleC expjpi(dynamic x)
        {
            return expjpi(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static SingleC exp10(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static SingleC exp10(dynamic x)
        {
            return exp10(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static SingleC exp2(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static SingleC exp2(dynamic x)
        {
            return exp2(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static SingleC expm1(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static SingleC expm1(dynamic x)
        {
            return expm1(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static SingleC exp10m1(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static SingleC exp10m1(dynamic x)
        {
            return exp10m1(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static SingleC exp2m1(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static SingleC exp2m1(dynamic x)
        {
            return exp2m1(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static SingleC exprel(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static SingleC exprel(dynamic x)
        {
            return exprel(scplx.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static SingleC logbase(SingleC x, SingleC b)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static SingleC logbase(dynamic x, dynamic b)
        {
            return logbase(scplx.t(x), scplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static SingleC log(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static SingleC log(dynamic x)
        {
            return log(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static SingleC log10(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static SingleC log10(dynamic x)
        {
            return log10(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static SingleC log2(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static SingleC log2(dynamic x)
        {
            return log2(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static SingleC log1p(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static SingleC log1p(dynamic x)
        {
            return log1p(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static SingleC log10p1(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static SingleC log10p1(dynamic x)
        {
            return log10p1(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static SingleC log2p1(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static SingleC log2p1(dynamic x)
        {
            return log2p1(scplx.t(x));
        }



        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static SingleC sqr(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static SingleC sqr(dynamic x)
        {
            return sqr(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static SingleC cube(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static SingleC cube(dynamic x)
        {
            return cube(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static SingleC hypot(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static SingleC hypot(dynamic x, dynamic y)
        {
            return hypot(scplx.t(x), scplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static SingleC pow_si(SingleC x, Int32 n)
        {
            var res = new SingleC();
            Lib_Arb_Arb_Pow_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Pow_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Pow_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static SingleC pow_si(dynamic x, Int32 n)
        {
            return pow_si(scplx.t(x), n);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static SingleC compound_si(SingleC x, Int32 n)
        {
            return pow1p(scplx.t(x), scplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static SingleC compound_si(dynamic x, Int32 n)
        {
            return pow1p(scplx.t(x), scplx.t(n));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static SingleC pow(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static SingleC pow(dynamic x, dynamic y)
        {
            return pow(scplx.t(x), scplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static SingleC powm1(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static SingleC powm1(dynamic x, dynamic y)
        {
            return powm1(scplx.t(x), scplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static SingleC pow1p(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static SingleC pow1p(dynamic x, dynamic y)
        {
            return pow1p(scplx.t(x), scplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static SingleC pow1pm1(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static SingleC pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(scplx.t(x), scplx.t(y));
        }



        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static SingleC sin(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static SingleC sin(dynamic x)
        {
            return sin(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static SingleC cos(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static SingleC cos(dynamic x)
        {
            return cos(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static SingleC tan(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static SingleC tan(dynamic x)
        {
            return tan(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static SingleC cot(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static SingleC cot(dynamic x)
        {
            return cot(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static SingleC sec(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static SingleC sec(dynamic x)
        {
            return sec(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static SingleC csc(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static SingleC csc(dynamic x)
        {
            return csc(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static SingleC sinc(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static SingleC sinc(dynamic x)
        {
            return sinc(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static SingleC sinpi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static SingleC sinpi(dynamic x)
        {
            return sinpi(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static SingleC cospi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static SingleC cospi(dynamic x)
        {
            return cospi(scplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static SingleC tanpi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static SingleC tanpi(dynamic x)
        {
            return tanpi(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static SingleC cotpi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static SingleC cotpi(dynamic x)
        {
            return cotpi(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static SingleC cscpi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CscPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CscPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CscPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static SingleC cscpi(dynamic x)
        {
            return cscpi(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static SingleC secpi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_SecPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_SecPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_SecPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static SingleC secpi(dynamic x)
        {
            return secpi(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static SingleC sincpi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static SingleC sincpi(dynamic x)
        {
            return sincpi(scplx.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static SingleC cosh(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static SingleC cosh(dynamic x)
        {
            return cosh(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static SingleC sinh(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static SingleC sinh(dynamic x)
        {
            return sinh(scplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static SingleC tanh(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static SingleC tanh(dynamic x)
        {
            return tanh(scplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static SingleC csch(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static SingleC csch(dynamic x)
        {
            return csch(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static SingleC sech(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static SingleC sech(dynamic x)
        {
            return sech(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static SingleC coth(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static SingleC coth(dynamic x)
        {
            return coth(scplx.t(x));
        }





        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static SingleC asin(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static SingleC asin(dynamic x)
        {
            return asin(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static SingleC acos(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static SingleC acos(dynamic x)
        {
            return acos(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static SingleC atan(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static SingleC atan(dynamic x)
        {
            return atan(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static SingleC acsc(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static SingleC acsc(dynamic x)
        {
            return acsc(scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static SingleC asec(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static SingleC asec(dynamic x)
        {
            return asec(scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static SingleC acot(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static SingleC acot(dynamic x)
        {
            return acot(scplx.t(x));
        }


        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static SingleC asinh(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static SingleC asinh(dynamic x)
        {
            return asinh(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static SingleC acosh(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static SingleC acosh(dynamic x)
        {
            return acosh(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static SingleC atanh(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static SingleC atanh(dynamic x)
        {
            return atanh(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static SingleC acsch(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static SingleC acsch(dynamic x)
        {
            return acsch(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static SingleC asech(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static SingleC asech(dynamic x)
        {
            return asech(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static SingleC acoth(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static SingleC acoth(dynamic x)
        {
            return acoth(scplx.t(x));
        }





        #endregion




        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static SingleC gamma(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static SingleC gamma(dynamic x)
        {
            return gamma(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static SingleC rgamma(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static SingleC rgamma(dynamic x)
        {
            return rgamma(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static SingleC lgamma(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static SingleC lgamma(dynamic x)
        {
            return lgamma(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static SingleC rising_factorial(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static SingleC rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(scplx.t(x), scplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static SingleC beta(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static SingleC beta(dynamic x, dynamic y)
        {
            return beta(scplx.t(x), scplx.t(y));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static SingleC gamma1pm1(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static SingleC gamma1pm1(dynamic x)
        {
            return gamma1pm1(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static SingleC factorial(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static SingleC factorial(dynamic x)
        {
            return factorial(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static SingleC doublefactorial(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static SingleC doublefactorial(dynamic x)
        {
            return doublefactorial(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static SingleC falling_factorial(SingleC a, SingleC n)
        {
            return aflintc.SCplxViaArbCS2(aflintc.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static SingleC falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(scplx.t(a), scplx.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static SingleC gamma_ratio(SingleC a, SingleC b)
        {
            return aflintc.SCplxViaArbCS2(aflintc.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static SingleC gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(scplx.t(a), scplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static SingleC gamma_delta_ratio(SingleC a, SingleC delta)
        {
            return aflintc.SCplxViaArbCS2(aflintc.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static SingleC gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(scplx.t(a), scplx.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static SingleC binomial(SingleC n, SingleC k)
        {
            return aflintc.SCplxViaArbCS2(aflintc.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static SingleC binomial(dynamic n, dynamic k)
        {
            return binomial(scplx.t(n), scplx.t(k));
        }










        #endregion



        #region Miscellaneous


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static SingleC lambert_wk(SingleC x, int branch)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_LambertW_ui(res.mpPtr, x.mpPtr, branch);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LambertW_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_LambertW_ui(IntPtr res, IntPtr x, int branch);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static SingleC lambert_wk(dynamic x, int branch)
        {
            return lambert_wk(scplx.t(x), branch);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static SingleC lambert_w0(SingleC x)
        {
            return lambert_wk(scplx.t(x), 0);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static SingleC lambert_w0(dynamic x)
        {
            return lambert_w0(scplx.t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static SingleC lambert_wm1(SingleC x)
        {
            return lambert_wk(scplx.t(x), -1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static SingleC lambert_wm1(dynamic x)
        {
            return lambert_wm1(scplx.t(x));
        }




        #endregion





        #endregion




        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static SingleC m_elliptic_k(SingleC m)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static SingleC m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static SingleC m_elliptic_e(SingleC m)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static SingleC m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static SingleC m_elliptic_pi(SingleC n, SingleC m)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static SingleC m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(scplx.t(x), scplx.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static SingleC m_elliptic_f(SingleC phi, SingleC m)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static SingleC m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(scplx.t(phi), scplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static SingleC m_elliptic_e_inc(SingleC phi, SingleC m)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static SingleC m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(scplx.t(phi), scplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static SingleC m_elliptic_pi_inc(SingleC n, SingleC phi, SingleC m)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static SingleC m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(scplx.t(n), scplx.t(phi), scplx.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static SingleC elliptic_k(SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static SingleC elliptic_k(dynamic k)
        {
            return elliptic_k(scplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static SingleC elliptic_e(SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static SingleC elliptic_e(dynamic k)
        {
            return elliptic_e(scplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static SingleC elliptic_pi(SingleC n, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static SingleC elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(scplx.t(n), scplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static SingleC elliptic_f(SingleC phi, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static SingleC elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(scplx.t(phi), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static SingleC elliptic_e_inc(SingleC phi, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static SingleC elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(scplx.t(phi), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static SingleC elliptic_pi_inc(SingleC n, SingleC phi, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static SingleC elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(scplx.t(n), scplx.t(phi), scplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static SingleC agm(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static SingleC agm(dynamic x, dynamic y)
        {
            return agm(scplx.t(x), scplx.t(y));
        }


        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static SingleC elliptic_rc(SingleC x, SingleC y)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static SingleC elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(scplx.t(x), scplx.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static SingleC elliptic_rf(SingleC x, SingleC y, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static SingleC elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(scplx.t(x), scplx.t(y), scplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static SingleC elliptic_rg(SingleC x, SingleC y, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static SingleC elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(scplx.t(x), scplx.t(y), scplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static SingleC elliptic_rd(SingleC x, SingleC y, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static SingleC elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(scplx.t(x), scplx.t(y), scplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static SingleC elliptic_rj(SingleC x, SingleC y, SingleC z, SingleC w)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static SingleC elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(scplx.t(x), scplx.t(y), scplx.t(z), scplx.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static SingleC jacobi_theta1(SingleC x, SingleC q)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static SingleC jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(scplx.t(x), scplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static SingleC jacobi_theta2(SingleC x, SingleC q)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static SingleC jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(scplx.t(x), scplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static SingleC jacobi_theta3(SingleC x, SingleC q)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static SingleC jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(scplx.t(x), scplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static SingleC jacobi_theta4(SingleC x, SingleC q)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static SingleC jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(scplx.t(x), scplx.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static SingleC JacobiTheta1Tau(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Theta1QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Theta1QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Theta1QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static SingleC JacobiTheta1Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta1Tau(scplx.t(z), scplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static SingleC JacobiTheta2Tau(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Theta2QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Theta2QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Theta2QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static SingleC JacobiTheta2Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta2Tau(scplx.t(z), scplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static SingleC JacobiTheta3Tau(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Theta3QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Theta3QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Theta3QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static SingleC JacobiTheta3Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta3Tau(scplx.t(z), scplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static SingleC JacobiTheta4Tau(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Theta4QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Theta4QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_Theta4QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static SingleC JacobiTheta4Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta4Tau(scplx.t(z), scplx.t(tau));
        }






        #endregion



        #region Jacobi elliptic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static SingleC QfromK(SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_QfromK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_QfromK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_QfromK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static SingleC QfromK(dynamic k)
        {
            return QfromK(scplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static SingleC TfromUQ(SingleC u, SingleC q)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_TfromUQ(res.mpPtr, u.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_TfromUQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_TfromUQ(IntPtr res, IntPtr u, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static SingleC TfromUQ(dynamic n, dynamic k)
        {
            return TfromUQ(scplx.t(n), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static SingleC SnTQ(SingleC t, SingleC q)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_SnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_SnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_SnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static SingleC SnTQ(dynamic t, dynamic q)
        {
            return SnTQ(scplx.t(t), scplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static SingleC CnTQ(SingleC t, SingleC q)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_CnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static SingleC CnTQ(dynamic t, dynamic q)
        {
            return CnTQ(scplx.t(t), scplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static SingleC DnTQ(SingleC t, SingleC q)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_DnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_DnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_DnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static SingleC DnTQ(dynamic t, dynamic q)
        {
            return DnTQ(scplx.t(t), scplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static SingleC jacobi_sn(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static SingleC jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static SingleC jacobi_cn(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static SingleC jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static SingleC jacobi_dn(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static SingleC jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static SingleC jacobi_ns(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static SingleC jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static SingleC jacobi_nc(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static SingleC jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static SingleC jacobi_nd(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static SingleC jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static SingleC jacobi_sc(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static SingleC jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static SingleC jacobi_sd(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static SingleC jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static SingleC jacobi_dc(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static SingleC jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static SingleC jacobi_ds(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static SingleC jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static SingleC jacobi_cs(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static SingleC jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(scplx.t(x), scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static SingleC jacobi_cd(SingleC x, SingleC k)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static SingleC jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(scplx.t(x), scplx.t(k));
        }




        #endregion



        #region Conversions of parameters of Weierstrass P


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<SingleC, SingleC> elliptic_invariants_from_roots(SingleC e1, SingleC e2)
        {
            SingleC e3 = -e1 - e2;
            SingleC g2 = 2 * (e1 * e1 + e2 * e2 + e3 * e3);
            SingleC g3 = 4 * e1 * e2 * e3;
            return new Tuple<SingleC, SingleC>(g2, g3);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<SingleC, SingleC> elliptic_invariants_from_roots(dynamic e1, dynamic e2)
        {
            return elliptic_invariants_from_roots(scplx.t(e1), scplx.t(e2));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<SingleC, SingleC> elliptic_invariants_from_tau(SingleC tau)
        {
            return new Tuple<SingleC, SingleC>(EllipticInvariantG2(tau), EllipticInvariantG3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<SingleC, SingleC> elliptic_invariants_from_tau(dynamic tau)
        {
            return elliptic_invariants_from_tau(scplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<SingleC, SingleC, SingleC> elliptic_roots_from_tau(SingleC tau)
        {
            return new Tuple<SingleC, SingleC, SingleC>(EllipticRootE1(tau), EllipticRootE2(tau), EllipticRootE3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<SingleC, SingleC, SingleC> elliptic_roots_from_tau(dynamic tau)
        {
            return elliptic_roots_from_tau(scplx.t(tau));
        }



        #endregion





        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static SingleC weierstrass_p_t(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_WeierstrassP(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_WeierstrassP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_WeierstrassP(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static SingleC weierstrass_p_t(dynamic z, dynamic tau)
        {
            return weierstrass_p_t(scplx.t(z), scplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static SingleC WeierstrassPInv(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_WeierstrassPInv(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_WeierstrassPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_WeierstrassPInv(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static SingleC WeierstrassPInv(dynamic z, dynamic tau)
        {
            return WeierstrassPInv(scplx.t(z), scplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static SingleC weierstrass_zeta_t(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_WeierstrassPZeta(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_WeierstrassPZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_WeierstrassPZeta(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static SingleC weierstrass_zeta_t(dynamic z, dynamic tau)
        {
            return weierstrass_zeta_t(scplx.t(z), scplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static SingleC weierstrass_sigma_t(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_WeierstrassPSigma(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_WeierstrassPSigma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_WeierstrassPSigma(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static SingleC weierstrass_sigma_t(dynamic z, dynamic tau)
        {
            return weierstrass_sigma_t(scplx.t(z), scplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static SingleC weierstrass_pprime_t(SingleC z, SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_WeierstrassPPrime(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_WeierstrassPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_WeierstrassPPrime(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static SingleC weierstrass_pprime_t(dynamic z, dynamic tau)
        {
            return weierstrass_pprime_t(scplx.t(z), scplx.t(tau));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static SingleC EllipticInvariantG2(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticInvariantG2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticInvariantG2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticInvariantG2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static SingleC EllipticInvariantG2(dynamic k)
        {
            return EllipticInvariantG2(scplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static SingleC EllipticInvariantG3(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticInvariantG3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticInvariantG3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticInvariantG3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static SingleC EllipticInvariantG3(dynamic k)
        {
            return EllipticInvariantG3(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static SingleC EllipticRootE1(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticRootE1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticRootE1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticRootE1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static SingleC EllipticRootE1(dynamic k)
        {
            return EllipticRootE1(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static SingleC EllipticRootE2(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticRootE2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticRootE2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticRootE2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static SingleC EllipticRootE2(dynamic k)
        {
            return EllipticRootE2(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static SingleC EllipticRootE3(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EllipticRootE3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EllipticRootE3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_EllipticRootE3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static SingleC EllipticRootE3(dynamic k)
        {
            return EllipticRootE3(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static SingleC dedekind_eta(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_DedekindEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_DedekindEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_DedekindEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static SingleC dedekind_eta(dynamic k)
        {
            return dedekind_eta(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static SingleC klein_j(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_KleinJ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_KleinJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_KleinJ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static SingleC klein_j(dynamic k)
        {
            return klein_j(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static SingleC modular_lambda(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ModularLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ModularLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_ModularLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static SingleC modular_lambda(dynamic k)
        {
            return modular_lambda(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static SingleC modular_delta(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ModularDelta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ModularDelta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_ModularDelta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static SingleC modular_delta(dynamic k)
        {
            return modular_delta(scplx.t(k));
        }



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static SingleC lerch_phi(SingleC s, SingleC z, SingleC a)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static SingleC lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(scplx.t(s), scplx.t(z), scplx.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static SingleC lerch_zeta(SingleC lambda1, SingleC alpha, SingleC s)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_LerchZeta(res.mpPtr, lambda1.mpPtr, alpha.mpPtr, s.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LerchZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_LerchZeta(IntPtr res, IntPtr lambda1, IntPtr alpha, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static SingleC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(scplx.t(lambda1), scplx.t(alpha), scplx.t(s));
        }




        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static SingleC polygamma(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static SingleC polygamma(dynamic s, dynamic z)
        {
            return polygamma(scplx.t(s), scplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static SingleC trigamma(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Trigamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Trigamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static SingleC trigamma(dynamic x)
        {
            return trigamma(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static SingleC digamma(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static SingleC digamma(dynamic x)
        {
            return digamma(scplx.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static SingleC polylog(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static SingleC polylog(dynamic s, dynamic z)
        {
            return polylog(scplx.t(s), scplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static SingleC trilog(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Trilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Trilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Trilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static SingleC trilog(dynamic x)
        {
            return trilog(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static SingleC dilog(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static SingleC dilog(dynamic x)
        {
            return dilog(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static SingleC clausen_sin(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ClausenSin(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ClausenSin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_ClausenSin(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static SingleC clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(scplx.t(s), scplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static SingleC clausen_cos(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ClausenCos(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ClausenCos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_ClausenCos(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static SingleC clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(scplx.t(s), scplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static SingleC clausen2(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Clausen2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Clausen2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Clausen2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static SingleC clausen2(dynamic x)
        {
            return clausen2(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static SingleC bose_einstein(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_BoseEinstein(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_BoseEinstein", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_BoseEinstein(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static SingleC bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(scplx.t(s), scplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static SingleC fermi_dirac(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_FermiDirac(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_FermiDirac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_FermiDirac(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static SingleC fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(scplx.t(s), scplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static SingleC legendre_chi(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_LegendreChi(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LegendreChi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_LegendreChi(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static SingleC legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(scplx.t(s), scplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static SingleC inverse_tan_integral(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_InverseTanIntegral(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_InverseTanIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_InverseTanIntegral(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static SingleC inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(scplx.t(s), scplx.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static SingleC hurwitz_zeta(SingleC s, SingleC a)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_HurwitzZeta(res.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static SingleC hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(scplx.t(s), scplx.t(a));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/stieltjes/*' />
        //public static SingleC stieltjes(SingleC x, Int32 n)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_Stieltjes_ui(res.mpPtr, x.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Stieltjes_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_Stieltjes_ui(IntPtr res, IntPtr x, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static SingleC bernpoly(SingleC x, Int32 n)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static SingleC bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(scplx.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static SingleC eulerpoly(SingleC x, Int32 n)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_EulerPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_EulerPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_EulerPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static SingleC eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(scplx.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static SingleC harmonic(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Harmonic(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Harmonic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Harmonic(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static SingleC harmonic(dynamic x)
        {
            return harmonic(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static SingleC harmonic2(SingleC z, SingleC r)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Harmonic2(res.mpPtr, z.mpPtr, r.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Harmonic2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Harmonic2(IntPtr res, IntPtr z, IntPtr r);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static SingleC harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(scplx.t(z), scplx.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static SingleC barnes_g(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static SingleC barnes_g(dynamic x)
        {
            return barnes_g(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static SingleC logbarnes_g(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static SingleC logbarnes_g(dynamic x)
        {
            return logbarnes_g(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static SingleC hyperfactorial(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hyperfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hyperfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hyperfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static SingleC hyperfactorial(dynamic x)
        {
            return hyperfactorial(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static SingleC superfactorial(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Superfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Superfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Superfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static SingleC superfactorial(dynamic x)
        {
            return superfactorial(scplx.t(x));
        }




        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static SingleC zeta(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static SingleC zeta(dynamic x)
        {
            return zeta(scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static SingleC zetam1(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Zetam1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Zetam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Zetam1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static SingleC zetam1(dynamic x)
        {
            return zetam1(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static SingleC riemann_xi(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_DirichletXi(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_DirichletXi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_DirichletXi(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static SingleC riemann_xi(dynamic k)
        {
            return riemann_xi(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static SingleC dirichlet_eta(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_DirichletEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_DirichletEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_DirichletEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static SingleC dirichlet_eta(dynamic k)
        {
            return dirichlet_eta(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static SingleC dirichlet_etam1(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_DirichletEtam1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_DirichletEtam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_DirichletEtam1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static SingleC dirichlet_etam1(dynamic k)
        {
            return dirichlet_etam1(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static SingleC dirichlet_beta(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_DirichletBeta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_DirichletBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_DirichletBeta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static SingleC dirichlet_beta(dynamic k)
        {
            return dirichlet_beta(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static SingleC dirichlet_lambda(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_DirichletLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_DirichletLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_DirichletLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static SingleC dirichlet_lambda(dynamic k)
        {
            return dirichlet_lambda(scplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static SingleC hardy_z(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_HardyZ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_HardyZ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_HardyZ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static SingleC hardy_z(dynamic k)
        {
            return hardy_z(scplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static SingleC hardy_theta(SingleC tau)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_HardyTheta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_HardyTheta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_SCplx_Acb_HardyTheta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static SingleC hardy_theta(dynamic k)
        {
            return hardy_theta(scplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta_zero/*' />
        public static SingleC zeta_zero(Int32 n)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ZetaZero_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ZetaZero_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_ZetaZero_ui(IntPtr res, Int32 n);



        #endregion



        #region Additional numbertheoretic functions





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static SingleC hyperg_0f1(SingleC a, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static SingleC hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(scplx.t(a), scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static SingleC hyperg_0f1r(SingleC a, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static SingleC hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(scplx.t(a), scplx.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static SingleC bessel_jv(SingleC nu, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static SingleC bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(scplx.t(nu), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static SingleC bessel_yv(SingleC nu, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static SingleC bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(scplx.t(nu), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static SingleC bessel_iv(SingleC nu, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static SingleC bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(scplx.t(nu), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static SingleC bessel_kv(SingleC nu, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static SingleC bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(scplx.t(nu), scplx.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static SingleC bessel_jv_prime(SingleC nu, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static SingleC bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(scplx.t(nu), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static SingleC bessel_yv_prime(SingleC nu, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static SingleC bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(scplx.t(nu), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static SingleC bessel_iv_prime(SingleC nu, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static SingleC bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(scplx.t(nu), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static SingleC bessel_kv_prime(SingleC nu, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static SingleC bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(scplx.t(nu), scplx.t(x), scaled);
        }






        #endregion







        #region 0F1: Spherical Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static SingleC sph_bessel_jn(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_bessel_jn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static SingleC sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(scplx.t(n), scplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static SingleC sph_bessel_yn(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_bessel_yn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static SingleC sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(scplx.t(n), scplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static SingleC sph_bessel_in(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_bessel_in, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static SingleC sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(scplx.t(n), scplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static SingleC sph_bessel_kn(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_bessel_kn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static SingleC sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(scplx.t(n), scplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static SingleC besselpoly(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.besselpoly, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static SingleC besselpoly(dynamic n, dynamic x, bool scaled = false)
        {
            return besselpoly(scplx.t(n), scplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static SingleC besseltheta(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.besseltheta, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static SingleC besseltheta(dynamic n, dynamic x, bool scaled = false)
        {
            return besseltheta(scplx.t(n), scplx.t(x), scaled);
        }






        #endregion



        #region 0F1: Spherical Bessel functions, first derivative


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static SingleC sph_bessel_jn_prime(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_bessel_jn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static SingleC sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(scplx.t(n), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static SingleC sph_bessel_yn_prime(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_bessel_yn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static SingleC sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(scplx.t(n), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static SingleC sph_bessel_in_prime(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_bessel_in_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static SingleC sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(scplx.t(n), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static SingleC sph_bessel_kn_prime(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_bessel_kn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static SingleC sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(scplx.t(n), scplx.t(x), scaled);
        }



        #endregion







        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static SingleC hankel_h1(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.hankel_h1, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static SingleC hankel_h1(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h1(scplx.t(v), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static SingleC hankel_h2(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.hankel_h2, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static SingleC hankel_h2(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h2(scplx.t(v), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static SingleC sph_hankel_h1(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_hankel_h1, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static SingleC sph_hankel_h1(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h1(scplx.t(n), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static SingleC sph_hankel_h2(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.sph_hankel_h2, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static SingleC sph_hankel_h2(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h2(scplx.t(n), scplx.t(x), scaled);
        }






        #endregion






        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static SingleC airy_ai(SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS1Bool1(aflintc.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static SingleC airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static SingleC airy_ai_prime(SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS1Bool1(aflintc.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static SingleC airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static SingleC airy_bi(SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS1Bool1(aflintc.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static SingleC airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static SingleC airy_bi_prime(SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS1Bool1(aflintc.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static SingleC airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(scplx.t(x), scaled);
        }



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        //public static Single airy_ai_zero(Int32 n)
        //{
        //    ArbPrec.Init(); Single res = 0.0F;
        //    Lib_SReal_Arb_AiryAiZero(ref res, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SReal_Arb_AiryAiZero(ref Single res, Int32 n);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        //public static Single airy_ai_prime_zero(UInt32 n)
        //{
        //    ArbPrec.Init(); Single res = 0.0F;
        //    Lib_SReal_Arb_AiryAiPrimeZero(ref res, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SReal_Arb_AiryAiPrimeZero(ref Single res, UInt32 n);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        //public static Single airy_bi_zero(Int32 n)
        //{
        //    ArbPrec.Init(); Single res = 0.0F;
        //    Lib_SReal_Arb_AiryBiZero(ref res, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SReal_Arb_AiryBiZero(ref Single res, Int32 n);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        //public static Single airy_bi_prime_zero(UInt32 n)
        //{
        //    ArbPrec.Init(); Single res = 0.0F;
        //    Lib_SReal_Arb_AiryBiPrimeZero(ref res, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SReal_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SReal_Arb_AiryBiPrimeZero(ref Single res, UInt32 n);




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static SingleC airy_ai(SingleC x, bool scaled = false)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_AiryAi(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp((sreal.t(2) / sreal.t(3)) * x * sqrt(x));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_AiryAi(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static SingleC airy_ai(dynamic x, bool scaled = false)
        //{
        //    return airy_ai(scplx.t(x), scaled);
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static SingleC airy_ai_prime(SingleC x, bool scaled = false)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_AiryAiPrime(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp((sreal.t(2) / sreal.t(3)) * x * sqrt(x));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_AiryAiPrime(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static SingleC airy_ai_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_ai_prime(scplx.t(x), scaled);
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static SingleC airy_bi(SingleC x, bool scaled = false)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_AiryBi(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp(-abs(sreal.t(2) / sreal.t(3) * (x * sqrt(x)).real));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_AiryBi(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static SingleC airy_bi(dynamic x, bool scaled = false)
        //{
        //    return airy_bi(scplx.t(x), scaled);
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static SingleC airy_bi_prime(SingleC x, bool scaled = false)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_AiryBiPrime(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp(-abs(sreal.t(2) / sreal.t(3) * (x * sqrt(x)).real));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_AiryBiPrime(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static SingleC airy_bi_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_bi_prime(scplx.t(x), scaled);
        //}



        #endregion





        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static SingleC kelvin_ber(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.kelvin_ber, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static SingleC kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(scplx.t(v), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static SingleC kelvin_bei(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.kelvin_bei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static SingleC kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(scplx.t(v), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static SingleC kelvin_ker(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.kelvin_ker, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static SingleC kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(scplx.t(v), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static SingleC kelvin_kei(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.kelvin_kei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static SingleC kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(scplx.t(v), scplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static SingleC kelvin_ber_prime(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.kelvin_ber_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static SingleC kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(scplx.t(v), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static SingleC kelvin_bei_prime(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.kelvin_bei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static SingleC kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(scplx.t(v), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static SingleC kelvin_ker_prime(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.kelvin_ker_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static SingleC kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(scplx.t(v), scplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static SingleC kelvin_kei_prime(SingleC v, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2Bool1(aflintc.kelvin_kei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static SingleC kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(scplx.t(v), scplx.t(x), scaled);
        }







        #endregion












        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static SingleC hyperg_1f1(SingleC a, SingleC b, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static SingleC hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(scplx.t(a), scplx.t(b), scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static SingleC hyperg_1f1r(SingleC a, SingleC b, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static SingleC hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(scplx.t(a), scplx.t(b), scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static SingleC hyperg_u(SingleC a, SingleC b, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static SingleC hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(scplx.t(a), scplx.t(b), scplx.t(x));
        }





        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static SingleC gamma_upper(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static SingleC gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(scplx.t(s), scplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static SingleC gamma_q(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static SingleC gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(scplx.t(s), scplx.t(z));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static SingleC gamma_lower(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static SingleC gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(scplx.t(s), scplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static SingleC gamma_p(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static SingleC gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(scplx.t(s), scplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static SingleC gamma_p_prime(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static SingleC gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(scplx.t(s), scplx.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static SingleC erf(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static SingleC erf(dynamic x)
        {
            return erf(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static SingleC erfc(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static SingleC erfc(dynamic x)
        {
            return erfc(scplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static SingleC erfi(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static SingleC erfi(dynamic x)
        {
            return erfi(scplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static SingleC dawson(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static SingleC dawson(dynamic x)
        {
            return dawson(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static SingleC faddeeva(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.faddeeva, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static SingleC faddeeva(dynamic x)
        {
            return faddeeva(scplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static SingleC fresnel_s(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static SingleC fresnel_s(dynamic x)
        {
            return fresnel_s(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static SingleC fresnel_c(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static SingleC fresnel_c(dynamic x)
        {
            return fresnel_c(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static SingleC ndens(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static SingleC ndens(dynamic x)
        {
            return ndens(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static SingleC ndis(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static SingleC ndis(dynamic x)
        {
            return ndis(scplx.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static SingleC exp_integral_en(SingleC s, SingleC z)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static SingleC exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(scplx.t(s), scplx.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static SingleC exp_integral_e1(SingleC z)
        {
            return exp_integral_en(scplx.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static SingleC exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(scplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static SingleC exp_integral_ei(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static SingleC exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static SingleC sin_integral(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static SingleC sin_integral(dynamic x)
        {
            return sin_integral(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static SingleC cos_integral(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static SingleC cos_integral(dynamic x)
        {
            return cos_integral(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static SingleC sinh_integral(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static SingleC sinh_integral(dynamic x)
        {
            return sinh_integral(scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static SingleC cosh_integral(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static SingleC cosh_integral(dynamic x)
        {
            return cosh_integral(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static SingleC log_integral(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static SingleC log_integral(dynamic x)
        {
            return log_integral(scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static SingleC log_integral_offset(SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static SingleC log_integral_offset(dynamic x)
        {
            return log_integral_offset(scplx.t(x));
        }



        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static SingleC hermite_h(SingleC n, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static SingleC hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(scplx.t(n), scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static SingleC hermite_he(SingleC n, SingleC x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static SingleC hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(scplx.t(n), scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static SingleC laguerre_l(SingleC n, SingleC m, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static SingleC laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(scplx.t(n), scplx.t(m), scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre/*' />
        public static SingleC laguerre(SingleC n, SingleC x)
        {
            return laguerre_l(n, scplx.t(0), x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre/*' />
        public static SingleC laguerre(dynamic n, dynamic x)
        {
            return laguerre(scplx.t(n), scplx.t(x));
        }


        #endregion



        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static SingleC coulomb_f(SingleC l, SingleC eta, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static SingleC coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(scplx.t(l), scplx.t(eta), scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static SingleC coulomb_g(SingleC l, SingleC eta, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static SingleC coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(scplx.t(l), scplx.t(eta), scplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static SingleC coulomb_hpos(SingleC l, SingleC eta, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CoulombHpos(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CoulombHpos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CoulombHpos(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static SingleC coulomb_hpos(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hpos(scplx.t(l), scplx.t(eta), scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static SingleC coulomb_hneg(SingleC l, SingleC eta, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_CoulombHneg(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_CoulombHneg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_CoulombHneg(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static SingleC coulomb_hneg(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hneg(scplx.t(l), scplx.t(eta), scplx.t(x));
        }





        #endregion



        #region 1F1: Whittaker functions


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static SingleC whittaker_m(SingleC k, SingleC m, SingleC x)
        {
            return aflintc.SCplxViaArbCS3(aflintc.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static SingleC whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(scplx.t(k), scplx.t(m), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static SingleC whittaker_w(SingleC k, SingleC m, SingleC x)
        {
            return aflintc.SCplxViaArbCS3(aflintc.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static SingleC whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(scplx.t(k), scplx.t(m), scplx.t(x));
        }




        #endregion



        #region 1F1: Parabolic cylinder functions


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static SingleC pcfd(SingleC n, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static SingleC pcfd(dynamic n, dynamic x)
        {
            return pcfd(scplx.t(n), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static SingleC pcfu(SingleC a, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static SingleC pcfu(dynamic a, dynamic x)
        {
            return pcfu(scplx.t(a), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static SingleC pcfv(SingleC a, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static SingleC pcfv(dynamic a, dynamic x)
        {
            return pcfv(scplx.t(a), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static SingleC pcfw(SingleC a, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static SingleC pcfw(dynamic a, dynamic x)
        {
            return pcfw(scplx.t(a), scplx.t(x));
        }




        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static SingleC hyperg_2f1(SingleC a, SingleC b, SingleC c, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static SingleC hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(scplx.t(a), scplx.t(b), scplx.t(c), scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static SingleC hyperg_2f1r(SingleC a, SingleC b, SingleC c, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static SingleC hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(scplx.t(a), scplx.t(b), scplx.t(c), scplx.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static SingleC chebyshev_t(SingleC n, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static SingleC chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(scplx.t(n), scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static SingleC chebyshev_u(SingleC n, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static SingleC chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(scplx.t(n), scplx.t(x));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static SingleC chebyshev_v(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2(aflintc.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static SingleC chebyshev_v(dynamic n, dynamic y)
        {
            return chebyshev_v(scplx.t(n), scplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static SingleC chebyshev_w(SingleC n, SingleC x, bool scaled = false)
        {
            return aflintc.SCplxViaArbCS2(aflintc.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static SingleC chebyshev_w(dynamic n, dynamic y)
        {
            return chebyshev_w(scplx.t(n), scplx.t(y));
        }












        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static SingleC gegenbauer_c(SingleC n, SingleC m, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static SingleC gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(scplx.t(n), scplx.t(m), scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static SingleC jacobi_p(SingleC n, SingleC a, SingleC b, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static SingleC jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(scplx.t(n), scplx.t(a), scplx.t(b), scplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static SingleC legendre_p(SingleC n, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.legendre_p, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static SingleC legendre_p(dynamic n, dynamic x)
        {
            return legendre_p(scplx.t(n), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static SingleC legendre_q(SingleC n, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.legendre_q, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static SingleC legendre_q(dynamic n, dynamic x)
        {
            return legendre_q(scplx.t(n), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static SingleC legendre_plm(SingleC n, SingleC m, SingleC x, int type = 1)
        {
            return aflintc.SCplxViaArbCS3Int1(aflintc.legendre_plm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static SingleC legendre_plm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_plm(scplx.t(n), scplx.t(m), scplx.t(x), type);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static SingleC legendre_qlm(SingleC n, SingleC m, SingleC x, int type = 1)
        {
            return aflintc.SCplxViaArbCS3Int1(aflintc.legendre_qlm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static SingleC legendre_qlm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_qlm(scplx.t(n), scplx.t(m), scplx.t(x), type);
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static SingleC legendre_p(SingleC n, SingleC m, SingleC x)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_LegendreP(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static SingleC legendre_p(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_p(scplx.t(n), scplx.t(m), scplx.t(x));
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static SingleC legendre_plm(SingleC n, SingleC m, SingleC x)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_LegendrePv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static SingleC legendre_plm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_plm(scplx.t(n), scplx.t(m), scplx.t(x));
        //}











        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static SingleC legendre_q(SingleC n, SingleC m, SingleC x)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_LegendreQ(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static SingleC legendre_q(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_q(scplx.t(n), scplx.t(m), scplx.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static SingleC legendre_qlm(SingleC n, SingleC m, SingleC x)
        //{
        //    var res = new SingleC();
        //    Lib_SCplx_Acb_LegendreQv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_SCplx_Acb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static SingleC legendre_qlm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_qlm(scplx.t(n), scplx.t(m), scplx.t(x));
        //}





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static SingleC spherical_y(SingleC n, SingleC m, SingleC theta, SingleC phi)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_SphericalY(res.mpPtr, n.mpPtr, m.mpPtr, theta.mpPtr, phi.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_SphericalY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_SphericalY(IntPtr res, IntPtr n, IntPtr m, IntPtr theta, IntPtr phi);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static SingleC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(scplx.t(n), scplx.t(m), scplx.t(theta), scplx.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static SingleC beta_lower(SingleC a, SingleC b, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static SingleC beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(scplx.t(a), scplx.t(b), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static SingleC ibeta(SingleC a, SingleC b, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static SingleC ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(scplx.t(a), scplx.t(b), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static SingleC ibetac(SingleC a, SingleC b, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static SingleC ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(scplx.t(a), scplx.t(b), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static SingleC ibeta_prime(SingleC a, SingleC b, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static SingleC ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(scplx.t(a), scplx.t(b), scplx.t(x));
        }


        #endregion







        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static SingleC hyperg_1f2(SingleC a1, SingleC b1, SingleC b2, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static SingleC hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(scplx.t(a1), scplx.t(b1), scplx.t(b2), scplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static SingleC hyperg_1f2r(SingleC a1, SingleC b1, SingleC b2, SingleC x)
        {
            var res = new SingleC();
            Lib_SCplx_Acb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_SCplx_Acb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_SCplx_Acb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static SingleC hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(scplx.t(a1), scplx.t(b1), scplx.t(b2), scplx.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static SingleC airy_gi(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static SingleC airy_gi(dynamic x)
        {
            return airy_gi(scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static SingleC airy_hi(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static SingleC airy_hi(dynamic x)
        {
            return airy_hi(scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static SingleC airy_gi_prime(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static SingleC airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static SingleC airy_hi_prime(SingleC x)
        {
            return aflintc.SCplxViaArbCS1(aflintc.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static SingleC airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(scplx.t(x));
        }


        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static SingleC struve_h(SingleC v, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static SingleC struve_h(dynamic v, dynamic x)
        {
            return struve_h(scplx.t(v), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static SingleC struve_l(SingleC v, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static SingleC struve_l(dynamic v, dynamic x)
        {
            return struve_l(scplx.t(v), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static SingleC struve_k(SingleC v, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static SingleC struve_k(dynamic v, dynamic x)
        {
            return struve_k(scplx.t(v), scplx.t(x));
        }


        public static SingleC struve_m(SingleC v, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static SingleC struve_m(dynamic v, dynamic x)
        {
            return struve_m(scplx.t(v), scplx.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static SingleC anger_j(SingleC v, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static SingleC anger_j(dynamic v, dynamic x)
        {
            return anger_j(scplx.t(v), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static SingleC weber_e(SingleC v, SingleC x)
        {
            return aflintc.SCplxViaArbCS2(aflintc.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static SingleC weber_e(dynamic v, dynamic x)
        {
            return weber_e(scplx.t(v), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static SingleC lommel_s1(SingleC mu, SingleC nu, SingleC x)
        {
            return aflintc.SCplxViaArbCS3(aflintc.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static SingleC lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(scplx.t(mu), scplx.t(nu), scplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static SingleC lommel_s2(SingleC mu, SingleC nu, SingleC x)
        {
            return aflintc.SCplxViaArbCS3(aflintc.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static SingleC lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(scplx.t(mu), scplx.t(nu), scplx.t(x));
        }


        #endregion





        #endregion


    }












}