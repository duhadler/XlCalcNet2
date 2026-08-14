using System;
using System.Runtime.InteropServices;
using System.Numerics;
using FixedPrecNet;

namespace ArbPrecNet
{




    public class eflint
    {


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Extended t(Arb x)
        {
            var res = new Extended();
            Lib_XReal_Set_Arb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Set_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Set_Arb(IntPtr res, IntPtr x);


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Extended t(Mpfr x)
        {
            var res = new Extended();
            Lib_XReal_Set_Mpfr(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Set_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Set_Mpfr(IntPtr res, IntPtr x);



        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "eflint"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return " eflint"; }
        }


        public static String fmt(Extended x)
        {
            return ereal.fmt(x);
        }


        public static String fmt(dynamic x)
        {
            return fmt(ereal.t(x));
        }





        #region Basic floating point functions




        #region General functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Extended fma(Extended x, Extended y, Extended z)
        {
            return ereal.fma(x, y, z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Extended fma(dynamic x, dynamic y, dynamic z)
        {
            return ereal.fma(x, y, z);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Extended fmax(Extended x, Extended y)
        {
            return ereal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Extended fmax(dynamic x, dynamic y)
        {
            return ereal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Extended fmin(Extended x, Extended y)
        {
            return ereal.fmin(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Extended fmin(dynamic x, dynamic y)
        {
            return ereal.fmin(x, y);
        }


        #endregion



        #region Machine constants


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static Extended zero()
        {
            return ereal.zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/negzero/*' />
        public static Extended negzero()
        {
            return ereal.negzero();
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static Extended one()
        {
            return ereal.one();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static ExtendedC onej()
        {
            return ereal.onej();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static Extended inf()
        {
            return ereal.inf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/neginf/*' />
        public static Extended neginf()
        {
            return ereal.neginf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static Extended nan()
        {
            return ereal.nan();
        }



        #endregion



        #region Properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(Extended x)
        {
            return ereal.signbit(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(dynamic x)
        {
            return ereal.signbit(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(Extended x)
        {
            return ereal.isfinite(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isfinite/*' />
        public static bool isfinite(dynamic x)
        {
            return ereal.isfinite(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(Extended x)
        {
            return ereal.isinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinf/*' />
        public static bool isinf(dynamic x)
        {
            return ereal.isinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static bool isposinf(Extended x)
        {
            return ereal.isposinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isposinf/*' />
        public static bool isposinf(dynamic x)
        {
            return ereal.isposinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isneginf/*' />
        public static bool isneginf(Extended x)
        {
            return ereal.isneginf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isneginf/*' />
        public static bool isneginf(dynamic x)
        {
            return ereal.isneginf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(Extended x)
        {
            return ereal.isnan(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnan/*' />
        public static bool isnan(dynamic x)
        {
            return ereal.isnan(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(Extended x)
        {
            return ereal.iszero(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/iszero/*' />
        public static bool iszero(dynamic x)
        {
            return ereal.iszero(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(Extended x)
        {
            return ereal.isone(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isone/*' />
        public static bool isone(dynamic x)
        {
            return ereal.isone(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinteger/*' />
        public static bool isinteger(Extended x)
        {
            return ereal.isinteger(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinteger/*' />
        public static bool isinteger(dynamic x)
        {
            return ereal.isinteger(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnumber/*' />
        public static bool isnumber(Extended x)
        {
            return ereal.isnumber(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnumber/*' />
        public static bool isnumber(dynamic x)
        {
            return ereal.isnumber(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isregular/*' />
        public static bool isregular(Extended x)
        {
            return ereal.isregular(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isregular/*' />
        public static bool isregular(dynamic x)
        {
            return ereal.isregular(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnormal/*' />
        public static bool isnormal(Extended x)
        {
            return ereal.isnormal(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnormal/*' />
        public static bool isnormal(dynamic x)
        {
            return ereal.isnormal(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isunordered/*' />
        public static bool isunordered(Extended x, Extended y)
        {
            return ereal.isunordered(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isunordered/*' />
        public static bool isunordered(dynamic x, dynamic y)
        {
            return ereal.isunordered(x, y);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint32/*' />
        public static bool fitsint32(Extended x)
        {
            return ereal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint32/*' />
        public static bool fitsint32(dynamic x)
        {
            return ereal.fitsint32(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint64/*' />
        public static bool fitsint64(Extended x)
        {
            return ereal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint64/*' />
        public static bool fitsint64(dynamic x)
        {
            return ereal.fitsint32(x);
        }





        #endregion



        #region Integer Related Functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Extended nearbyint(Extended x)
        {
            return ereal.nearbyint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Extended nearbyint(dynamic x)
        {
            return ereal.nearbyint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Extended rint(Extended x)
        {
            return ereal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Extended rint(dynamic x)
        {
            return ereal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(Extended x)
        {
            return ereal.lrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(dynamic x)
        {
            return ereal.lrint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(Extended x)
        {
            return ereal.llrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(dynamic x)
        {
            return ereal.llrint(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Extended ceil(Extended x)
        {
            return ereal.ceil(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Extended ceil(dynamic x)
        {
            return ereal.ceil(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Extended floor(Extended x)
        {
            return ereal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Extended floor(dynamic x)
        {
            return ereal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Extended trunc(Extended x)
        {
            return ereal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Extended trunc(dynamic x)
        {
            return ereal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Extended round(Extended x)
        {
            return ereal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Extended round(dynamic x)
        {
            return ereal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(Extended x)
        {
            return ereal.lround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(dynamic x)
        {
            return ereal.lround(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(Extended x)
        {
            return ereal.llround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(dynamic x)
        {
            return ereal.llround(x);
        }




        #endregion



        #region Floating point functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Extended copysign(Extended x, Extended y)
        {
            return ereal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Extended copysign(dynamic x, dynamic y)
        {
            return ereal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Extended, Int32> frexp(Extended x)
        {
            return ereal.frexp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Extended, Int32> frexp(dynamic x)
        {
            return ereal.frexp(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Extended logb(Extended x)
        {
            return ereal.logb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Extended logb(dynamic x)
        {
            return ereal.logb(x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(Extended x)
        {
            return ereal.ilogb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(dynamic x)
        {
            return ereal.ilogb(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Extended ldexp(Extended x, Int32 e)
        {
            return ereal.ldexp(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Extended ldexp(dynamic x, dynamic e)
        {
            return ereal.ldexp(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Extended scalbn(Extended x, Int32 e)
        {
            return ereal.scalbn(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Extended scalbn(dynamic x, dynamic e)
        {
            return ereal.scalbn(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Extended scalbln(Extended x, Int32 e)
        {
            return ereal.scalbln(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Extended scalbln(dynamic x, dynamic e)
        {
            return ereal.scalbln(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Extended fdim(Extended x, Extended y)
        {
            return ereal.fdim(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Extended fdim(dynamic x, dynamic y)
        {
            return ereal.fdim(x, y);
        }


        #endregion



        #region Fraction and remainder Related Functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Extended, Extended> modf(Extended x)
        {
            return ereal.modf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Extended, Extended> modf(dynamic x)
        {
            return ereal.modf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Extended fmod(Extended x, Extended y)
        {
            return ereal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Extended fmod(dynamic x, dynamic y)
        {
            return ereal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Extended remainder(Extended x, Extended y)
        {
            return ereal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Extended remainder(dynamic x, dynamic y)
        {
            return ereal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Extended, Int32> remquo(Extended x, Extended y)
        {
            return ereal.remquo(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Extended, Int32> remquo(dynamic x, dynamic y)
        {
            return ereal.remquo(x, y);
        }

        #endregion



        #region Functions related to mantissa width and exponent range


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/epsilon/*' />
        public static Extended epsilon()
        {
            return ereal.epsilon();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Extended ulp(Extended x)
        {
            return ereal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Extended ulp(dynamic x)
        {
            return ereal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/maxvalue/*' />
        public static Extended maxvalue()
        {
            return ereal.maxvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/lowestvalue/*' />
        public static Extended lowestvalue()
        {
            return ereal.lowestvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/minposvalue/*' />
        public static Extended minposvalue()
        {
            return ereal.minposvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Extended nextafter(Extended x, Extended y)
        {
            return ereal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Extended nextafter(dynamic x, dynamic y)
        {
            return ereal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Extended nextabove(Extended x)
        {
            return ereal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Extended nextabove(dynamic x)
        {
            return ereal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Extended nextbelow(Extended x)
        {
            return ereal.nextbelow(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Extended nextbelow(dynamic x)
        {
            return ereal.nextbelow(x);
        }


        #endregion



        #region Mathematical Constants


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/degree/*' />
        public static Extended degree()
        {
            return ereal.degree();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phi/*' />
        public static Extended phi()
        {
            return ereal.phi();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln2/*' />
        public static Extended ln2()
        {
            return ereal.ln2();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln10/*' />
        public static Extended ln10()
        {
            return ereal.ln10();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pi/*' />
        public static Extended pi()
        {
            return ereal.pi();
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/e/*' />
        public static Extended e()
        {
            return ereal.e();
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/egamma/*' />
        public static Extended egamma()
        {
            return ereal.egamma();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/apery/*' />
        public static Extended apery()
        {
            return ereal.apery();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/catalan/*' />
        public static Extended catalan()
        {
            return ereal.catalan();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/glaisher/*' />
        public static Extended glaisher()
        {
            return ereal.glaisher();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/khinchin/*' />
        public static Extended khinchin()
        {
            return ereal.khinchin();
        }


        #endregion




        #endregion






        #region Flint Basic Functions



        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Extended abs(Extended x)
        {
            return ereal.abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Extended abs(dynamic x)
        {
            return abs(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Extended fabs(Extended x)
        {
            return ereal.fabs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Extended fabs(dynamic x)
        {
            return fabs(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Extended sign(Extended x)
        {
            return ereal.sign(x); ;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Extended sign(dynamic x)
        {
            return sign(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Extended real(Extended x)
        {
            return x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Extended real(dynamic x)
        {
            return real(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Extended imag(Extended x)
        {
            return ereal.zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Extended imag(dynamic x)
        {
            return imag(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Extended phase(Extended x)
        {
            return ereal.phase(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Extended phase(dynamic x)
        {
            return ereal.phase(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Extended conj(Extended x)
        {
            return x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Extended conj(dynamic x)
        {
            return conj(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Extended, Extended> polar(Extended x)
        {
            return new Tuple<Extended, Extended>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Extended, Extended> polar(dynamic x)
        {
            return polar(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static ExtendedC rect(Extended r, Extended phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static ExtendedC rect(dynamic r, dynamic phi)
        {
            return rect(ereal.t(r), ereal.t(phi));
        }





        #endregion




        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Extended sqrt(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Extended sqrt(dynamic x)
        {
            return sqrt(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Extended rsqrt(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Extended rsqrt(dynamic x)
        {
            return rsqrt(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Extended cbrt(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Extended cbrt(dynamic x)
        {
            return cbrt(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Extended sqrt1pm1(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Extended sqrt1pm1(dynamic x)
        {
            return sqrt1pm1(ereal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Extended root_si(Extended x, Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_Root_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Extended root_si(dynamic x, Int32 n)
        {
            return root_si(ereal.t(x), n);
        }


        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Extended exp(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Extended exp(dynamic x)
        {
            return exp(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static ExtendedC expj(Extended x)
        {
            return eflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static ExtendedC expj(dynamic x)
        {
            return eflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static ExtendedC expjpi(Extended x)
        {
            return eflintc.expjpi(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static ExtendedC expjpi(dynamic x)
        {
            return eflintc.expjpi(x);
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Extended exp10(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Extended exp10(dynamic x)
        {
            return exp10(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Extended exp2(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Extended exp2(dynamic x)
        {
            return exp2(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Extended expm1(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Extended expm1(dynamic x)
        {
            return expm1(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Extended exp10m1(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Extended exp10m1(dynamic x)
        {
            return exp10m1(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Extended exp2m1(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Extended exp2m1(dynamic x)
        {
            return exp2m1(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Extended exprel(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Extended exprel(dynamic x)
        {
            return exprel(ereal.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Extended logbase(Extended x, Extended b)
        {
            var res = new Extended();
            Lib_XReal_Arb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Extended logbase(dynamic x, dynamic b)
        {
            return logbase(ereal.t(x), ereal.t(b));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Extended log(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Extended log(dynamic x)
        {
            return log(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Extended log10(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Extended log10(dynamic x)
        {
            return log10(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Extended log2(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Extended log2(dynamic x)
        {
            return log2(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Extended log1p(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Extended log1p(dynamic x)
        {
            return log1p(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Extended log10p1(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Extended log10p1(dynamic x)
        {
            return log10p1(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Extended log2p1(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Extended log2p1(dynamic x)
        {
            return log2p1(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Extended log1mexp(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Log1mexp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Log1mexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Log1mexp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Extended log1mexp(dynamic x)
        {
            return log1mexp(ereal.t(x));
        }




        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Extended sqr(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Extended sqr(dynamic x)
        {
            return sqr(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Extended cube(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Extended cube(dynamic x)
        {
            return cube(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Extended hypot(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Extended hypot(dynamic x, dynamic y)
        {
            return hypot(ereal.t(x), ereal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powi/*' />
        public static Extended pow_si(Extended x, Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_Pow_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Pow_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Extended pow_si(dynamic x, Int32 n)
        {
            return pow_si(ereal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Extended compound_si(Extended x, Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_Compound_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Compound_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Compound_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Extended compound_si(dynamic x, Int32 n)
        {
            return compound_si(ereal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Extended pow(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Extended pow(dynamic x, dynamic y)
        {
            return pow(ereal.t(x), ereal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Extended powm1(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Extended powm1(dynamic x, dynamic y)
        {
            return powm1(ereal.t(x), ereal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Extended pow1p(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Extended pow1p(dynamic x, dynamic y)
        {
            return pow1p(ereal.t(x), ereal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Extended pow1pm1(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Extended pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(ereal.t(x), ereal.t(y));
        }




        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Extended sin(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Extended sin(dynamic x)
        {
            return sin(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Extended cos(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Extended cos(dynamic x)
        {
            return cos(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Extended tan(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Extended tan(dynamic x)
        {
            return tan(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Extended cot(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Extended cot(dynamic x)
        {
            return cot(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Extended sec(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Extended sec(dynamic x)
        {
            return sec(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Extended csc(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Extended csc(dynamic x)
        {
            return csc(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Extended sinc(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Extended sinc(dynamic x)
        {
            return sinc(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Extended sinpi(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Extended sinpi(dynamic x)
        {
            return sinpi(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Extended cospi(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Extended cospi(dynamic x)
        {
            return cospi(ereal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Extended tanpi(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Extended tanpi(dynamic x)
        {
            return tanpi(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Extended cotpi(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Extended cotpi(dynamic x)
        {
            return cotpi(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Extended cscpi(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_SinPi(res.mpPtr, x.mpPtr);
            return 1/res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Extended cscpi(dynamic x)
        {
            return cscpi(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Extended secpi(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_CosPi(res.mpPtr, x.mpPtr);
            return 1 / res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Extended secpi(dynamic x)
        {
            return secpi(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Extended sincpi(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Extended sincpi(dynamic x)
        {
            return sincpi(ereal.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Extended sinh(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Extended sinh(dynamic x)
        {
            return sinh(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Extended cosh(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Extended cosh(dynamic x)
        {
            return cosh(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Extended tanh(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Extended tanh(dynamic x)
        {
            return tanh(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Extended csch(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Extended csch(dynamic x)
        {
            return csch(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Extended sech(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Extended sech(dynamic x)
        {
            return sech(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Extended coth(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Extended coth(dynamic x)
        {
            return coth(ereal.t(x));
        }




        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Extended asin(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Extended asin(dynamic x)
        {
            return asin(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Extended acos(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Extended acos(dynamic x)
        {
            return acos(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Extended atan2(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Atan2(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Atan2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Atan2(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Extended atan2(dynamic x, dynamic y)
        {
            return atan2(ereal.t(x), ereal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Extended atan(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Extended atan(dynamic x)
        {
            return atan(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Extended acsc(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Extended acsc(dynamic x)
        {
            return acsc(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Extended asec(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Extended asec(dynamic x)
        {
            return asec(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Extended acot(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Extended acot(dynamic x)
        {
            return acot(ereal.t(x));
        }



        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Extended asinh(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Extended asinh(dynamic x)
        {
            return asinh(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Extended acosh(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Extended acosh(dynamic x)
        {
            return acosh(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Extended atanh(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Extended atanh(dynamic x)
        {
            return atanh(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Extended acsch(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Extended acsch(dynamic x)
        {
            return acsch(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Extended asech(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Extended asech(dynamic x)
        {
            return asech(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Extended acoth(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Extended acoth(dynamic x)
        {
            return acoth(ereal.t(x));
        }



        #endregion



        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Extended gamma(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Extended gamma(dynamic x)
        {
            return gamma(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Extended rgamma(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Extended rgamma(dynamic x)
        {
            return rgamma(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Extended lgamma(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Extended lgamma(dynamic x)
        {
            return lgamma(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Extended rising_factorial(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Extended rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(ereal.t(x), ereal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Extended beta(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Extended beta(dynamic x, dynamic y)
        {
            return beta(ereal.t(x), ereal.t(y));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Extended gamma1pm1(Extended x)
        {
            return aflint.ERealViaArbS1(aflint.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Extended gamma1pm1(dynamic x)
        {
            return gamma1pm1(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Extended factorial(Extended x)
        {
            return aflint.ERealViaArbS1(aflint.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Extended factorial(dynamic x)
        {
            return factorial(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Extended doublefactorial(Extended x)
        {
            return aflint.ERealViaArbS1(aflint.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Extended doublefactorial(dynamic x)
        {
            return doublefactorial(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Extended falling_factorial(Extended a, Extended n)
        {
            return aflint.ERealViaArbS2(aflint.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Extended falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(ereal.t(a), ereal.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Extended gamma_ratio(Extended a, Extended b)
        {
            return aflint.ERealViaArbS2(aflint.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Extended gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(ereal.t(a), ereal.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Extended gamma_delta_ratio(Extended a, Extended delta)
        {
            return aflint.ERealViaArbS2(aflint.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Extended gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(ereal.t(a), ereal.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Extended binomial(Extended n, Extended k)
        {
            return aflint.ERealViaArbS2(aflint.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Extended binomial(dynamic n, dynamic k)
        {
            return binomial(ereal.t(n), ereal.t(k));
        }






        #endregion



        #region Miscellaneous


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Extended lambert_w0(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_LambertW0(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_LambertW0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_LambertW0(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Extended lambert_w0(dynamic x)
        {
            return lambert_w0(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Extended lambert_wm1(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_LambertWm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_LambertWm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_LambertWm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Extended lambert_wm1(dynamic x)
        {
            return lambert_wm1(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static ExtendedC lambert_wk(Extended x, int k)
        {
            return eflintc.lambert_wk(ecplx.t(x), k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static ExtendedC lambert_wk(dynamic x, int k)
        {
            return lambert_wk(ereal.t(x), k);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Extended agm(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Extended agm(dynamic x, dynamic y)
        {
            return agm(ereal.t(x), ereal.t(y));
        }







        #endregion



        #endregion





        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Extended m_elliptic_k(Extended m)
        {
            var res = new Extended();
            Lib_XReal_Arb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Extended m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Extended m_elliptic_e(Extended m)
        {
            var res = new Extended();
            Lib_XReal_Arb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Extended m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Extended m_elliptic_pi(Extended n, Extended m)
        {
            var res = new Extended();
            Lib_XReal_Arb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Extended m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(ereal.t(x), ereal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Extended m_elliptic_f(Extended phi, Extended m)
        {
            var res = new Extended();
            Lib_XReal_Arb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Extended m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(ereal.t(phi), ereal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Extended m_elliptic_e_inc(Extended phi, Extended m)
        {
            var res = new Extended();
            Lib_XReal_Arb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Extended m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(ereal.t(phi), ereal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Extended m_elliptic_pi_inc(Extended n, Extended phi, Extended m)
        {
            var res = new Extended();
            Lib_XReal_Arb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Extended m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(ereal.t(n), ereal.t(phi), ereal.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Extended elliptic_k(Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Extended elliptic_k(dynamic k)
        {
            return elliptic_k(ereal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Extended elliptic_e(Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Extended elliptic_e(dynamic k)
        {
            return elliptic_e(ereal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Extended elliptic_pi(Extended n, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Extended elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(ereal.t(n), ereal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Extended elliptic_f(Extended phi, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Extended elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(ereal.t(phi), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Extended elliptic_e_inc(Extended phi, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Extended elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(ereal.t(phi), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Extended elliptic_pi_inc(Extended n, Extended phi, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Extended elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(ereal.t(n), ereal.t(phi), ereal.t(k));
        }




        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Extended elliptic_rc(Extended x, Extended y)
        {
            var res = new Extended();
            Lib_XReal_Arb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Extended elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(ereal.t(x), ereal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Extended elliptic_rf(Extended x, Extended y, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Extended elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(ereal.t(x), ereal.t(y), ereal.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Extended elliptic_rg(Extended x, Extended y, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Extended elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(ereal.t(x), ereal.t(y), ereal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Extended elliptic_rd(Extended x, Extended y, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Extended elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(ereal.t(x), ereal.t(y), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Extended elliptic_rj(Extended x, Extended y, Extended z, Extended w)
        {
            var res = new Extended();
            Lib_XReal_Arb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Extended elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(ereal.t(x), ereal.t(y), ereal.t(z), ereal.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Extended jacobi_theta1(Extended x, Extended q)
        {
            var res = new Extended();
            Lib_XReal_Arb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Extended jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(ereal.t(x), ereal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Extended jacobi_theta2(Extended x, Extended q)
        {
            var res = new Extended();
            Lib_XReal_Arb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Extended jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(ereal.t(x), ereal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Extended jacobi_theta3(Extended x, Extended q)
        {
            var res = new Extended();
            Lib_XReal_Arb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Extended jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(ereal.t(x), ereal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Extended jacobi_theta4(Extended x, Extended q)
        {
            var res = new Extended();
            Lib_XReal_Arb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Extended jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(ereal.t(x), ereal.t(q));
        }




        #endregion



        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Extended jacobi_sn(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Extended jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Extended jacobi_cn(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Extended jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Extended jacobi_dn(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Extended jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Extended jacobi_ns(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Extended jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Extended jacobi_nc(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Extended jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Extended jacobi_nd(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Extended jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Extended jacobi_sc(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Extended jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Extended jacobi_sd(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Extended jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Extended jacobi_dc(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Extended jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Extended jacobi_ds(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Extended jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Extended jacobi_cs(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Extended jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(ereal.t(x), ereal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Extended jacobi_cd(Extended x, Extended k)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XReal_Arb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Extended jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(ereal.t(x), ereal.t(k));
        }








        #endregion



        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Extended lerch_phi(Extended s, Extended z, Extended a)
        {
            var res = new Extended();
            Lib_XReal_Arb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Extended lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(ereal.t(s), ereal.t(z), ereal.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static ExtendedC lerch_zeta(Extended lambda1, Extended alpha, Extended s)
        {
            var res = eflintc.lerch_zeta(lambda1, alpha, s);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static ExtendedC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(ereal.t(lambda1), ereal.t(alpha), ereal.t(s));
        }






        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Extended polygamma(Extended s, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Extended polygamma(dynamic s, dynamic z)
        {
            return polygamma(ereal.t(s), ereal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Extended trigamma(Extended x)
        {
            return polygamma(1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Extended trigamma(dynamic x)
        {
            return trigamma(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Extended digamma(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Extended digamma(dynamic x)
        {
            return digamma(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Extended harmonic(Extended x)
        {
            ExtendedC res = eflintc.harmonic(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Extended harmonic(dynamic x)
        {
            return harmonic(ereal.t(x));
        }




        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Extended polylog(Extended s, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Extended polylog(dynamic s, dynamic z)
        {
            return polylog(ereal.t(s), ereal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Extended trilog(Extended x)
        {
            ExtendedC res = eflintc.trilog(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Extended trilog(dynamic x)
        {
            return trilog(ereal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Extended dilog(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Extended dilog(dynamic x)
        {
            return dilog(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Extended clausen_sin(Extended s, Extended z)
        {
            ExtendedC res = eflintc.clausen_sin(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Extended clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(ereal.t(s), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Extended clausen_cos(Extended s, Extended z)
        {
            ExtendedC res = eflintc.clausen_cos(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Extended clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(ereal.t(s), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Extended clausen2(Extended x)
        {
            return clausen_sin(ereal.t(2), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Extended clausen2(dynamic x)
        {
            return clausen_sin(ereal.t(2), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Extended bose_einstein(Extended s, Extended z)
        {
            ExtendedC res = eflintc.bose_einstein(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Extended bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(ereal.t(s), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Extended fermi_dirac(Extended s, Extended z)
        {
            ExtendedC res = eflintc.fermi_dirac(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Extended fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(ereal.t(s), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Extended legendre_chi(Extended s, Extended z)
        {
            ExtendedC res = eflintc.legendre_chi(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Extended legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(ereal.t(s), ereal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Extended inverse_tan_integral(Extended s, Extended z)
        {
            ExtendedC res = eflintc.inverse_tan_integral(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Extended inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(ereal.t(s), ereal.t(z));
        }






        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Extended hurwitz_zeta(Extended s, Extended a)
        {
            var res = new Extended();
            Lib_XReal_Arb_HurwitzZeta(res.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Extended hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(ereal.t(s), ereal.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Extended harmonic2(Extended z, Extended r)
        {
            ExtendedC res = eflintc.harmonic2(z, r);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Extended harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(ereal.t(z), ereal.t(r));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Extended bernoulli(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_Bernoulli_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Bernoulli_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Bernoulli_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Extended bernpoly(Extended x, Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Extended bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(ereal.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulernum/*' />
        public static Extended eulernum(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_Euler_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Euler_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Euler_ui(IntPtr res, Int32 n);






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Extended eulerpoly(Extended x, Int32 n)
        {
            ExtendedC res = eflintc.eulerpoly(x, n);
            return res.real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Extended eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(ereal.t(x), n);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Extended barnes_g(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Extended barnes_g(dynamic x)
        {
            return barnes_g(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Extended logbarnes_g(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Extended logbarnes_g(dynamic x)
        {
            return logbarnes_g(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Extended hyperfactorial(Extended x)
        {
            ExtendedC res = eflintc.hyperfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Extended hyperfactorial(dynamic x)
        {
            return hyperfactorial(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Extended superfactorial(Extended x)
        {
            ExtendedC res = eflintc.superfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Extended superfactorial(dynamic x)
        {
            return superfactorial(ereal.t(x));
        }







        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Extended zeta(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Extended zeta(dynamic x)
        {
            return zeta(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Extended zetam1(Extended x)
        {
            ExtendedC res = eflintc.zetam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Extended zetam1(dynamic x)
        {
            return zetam1(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Extended hardy_theta(Extended x)
        {
            ExtendedC res = eflintc.hardy_theta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Extended hardy_theta(dynamic x)
        {
            return hardy_theta(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Extended hardy_z(Extended x)
        {
            ExtendedC res = eflintc.hardy_z(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Extended hardy_z(dynamic x)
        {
            return hardy_z(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Extended riemann_xi(Extended x)
        {
            ExtendedC res = eflintc.riemann_xi(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Extended riemann_xi(dynamic x)
        {
            return riemann_xi(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Extended dirichlet_eta(Extended x)
        {
            ExtendedC res = eflintc.dirichlet_eta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Extended dirichlet_eta(dynamic x)
        {
            return dirichlet_eta(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Extended dirichlet_etam1(Extended x)
        {
            ExtendedC res = eflintc.dirichlet_etam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Extended dirichlet_etam1(dynamic x)
        {
            return dirichlet_etam1(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Extended dirichlet_beta(Extended x)
        {
            ExtendedC res = eflintc.dirichlet_beta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Extended dirichlet_beta(dynamic x)
        {
            return dirichlet_beta(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Extended dirichlet_lambda(Extended x)
        {
            ExtendedC res = eflintc.dirichlet_lambda(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Extended dirichlet_lambda(dynamic x)
        {
            return dirichlet_lambda(ereal.t(x));
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Extended backlund_s(Extended x)
        //{
        //    var res = new Extended();
        //    Lib_XReal_Arb_BacklundS(res.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_BacklundS", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_XReal_Arb_BacklundS(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Extended backlund_s(dynamic x)
        //{
        //    return zeta(ereal.t(x));
        //}





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/grampoint/*' />
        //public static Extended grampoint(Int32 n)
        //{
        //    var res = new Extended();
        //    Lib_XReal_Arb_GramPoint_ui(res.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_GramPoint_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_XReal_Arb_GramPoint_ui(IntPtr res, Int32 n);







        #endregion



        #region Additional numbertheoretic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bell/*' />
        public static Extended bell(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_Bell_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Bell_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Bell_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/partitions/*' />
        public static Extended partitions(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_Partitions_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Partitions_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Partitions_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/primorial/*' />
        public static Extended primorial(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_Primorial_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Primorial_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Primorial_ui(IntPtr res, Int32 n);





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Extended hyperg_0f1(Extended a, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Extended hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(ereal.t(a), ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Extended hyperg_0f1r(Extended a, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Extended hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(ereal.t(a), ereal.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Extended bessel_jv(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Extended bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(ereal.t(nu), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Extended bessel_yv(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Extended bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(ereal.t(nu), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Extended bessel_iv(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Extended bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(ereal.t(nu), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Extended bessel_kv(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Extended bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(ereal.t(nu), ereal.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Extended bessel_jv_prime(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Extended bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(ereal.t(nu), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Extended bessel_yv_prime(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Extended bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(ereal.t(nu), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Extended bessel_iv_prime(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Extended bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(ereal.t(nu), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Extended bessel_kv_prime(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Extended bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(ereal.t(nu), ereal.t(x), scaled);
        }







        #endregion







        #region 0F1: Spherical Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Extended sph_bessel_jn(Extended n, Extended x, bool scaled = false)
        {
            if (!ereal.isinteger(n)) return ereal.nan();

            if (ereal.isnan(x)) return ereal.nan();
            if (ereal.isinf(x)) return ereal.zero();
            if (ereal.isneginf(x)) return ereal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return ereal.one();
                    else return ereal.zero();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return ereal.neginf(); else return ereal.nan();
                }
            }
            return eflintc.sph_bessel_jn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Extended sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(ereal.t(n), ereal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Extended sph_bessel_yn(Extended n, Extended x, bool scaled = false)
        {
            if (!ereal.isinteger(n)) return ereal.nan();

            if (ereal.isnan(x)) return ereal.nan();
            if (ereal.isinf(x)) return ereal.zero();
            if (ereal.isneginf(x)) return ereal.zero();
            if (x == 0.0)
            {
                if (n < 0)
                {
                    if ((n == -1)) return ereal.one();
                    else return ereal.zero();
                }
                else
                {
                    if (lrint(n) % 2 != 0) return ereal.neginf(); else return ereal.nan();
                }
            }
            return eflintc.sph_bessel_yn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Extended sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(ereal.t(n), ereal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Extended sph_bessel_in(Extended n, Extended x, bool scaled = false)
        {
            if (!ereal.isinteger(n)) return ereal.nan();

            if (ereal.isnan(x)) return ereal.nan();
            if (ereal.isinf(x)) return ereal.inf();
            if (ereal.isneginf(x)) return ereal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return ereal.one();
                    else return ereal.zero();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return ereal.neginf(); else return ereal.nan();
                }
            }
            return eflintc.sph_bessel_in(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Extended sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(ereal.t(n), ereal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Extended sph_bessel_kn(Extended n, Extended x, bool scaled = false)
        {
            if (!ereal.isinteger(n)) return ereal.nan();

            if (ereal.isnan(x)) return ereal.nan();
            if (ereal.isinf(x)) return ereal.zero();
            if (ereal.isneginf(x)) return ereal.neginf();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if (lrint(n) % 2 == 0) return ereal.nan(); else return ereal.inf();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return ereal.inf(); else return ereal.nan();
                }
            }
            return eflintc.sph_bessel_kn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Extended sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(ereal.t(n), ereal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Extended besselpoly(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.besselpoly, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Extended besselpoly(dynamic nu, dynamic x, bool scaled = false)
        {
            return besselpoly(ereal.t(nu), ereal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Extended besseltheta(Extended nu, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2Bool1(aflint.besseltheta, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Extended besseltheta(dynamic nu, dynamic x, bool scaled = false)
        {
            return besseltheta(ereal.t(nu), ereal.t(x), scaled);
        }







        #endregion




        #region Spherical Bessel functions, first derivative




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Extended sph_bessel_jn_prime(Extended n, Extended x, bool scaled = false)
        {
            if (!ereal.isinteger(n)) return ereal.nan();

            if (ereal.isnan(x)) return ereal.nan();
            if (ereal.isinf(x)) return ereal.zero();
            if (ereal.isneginf(x)) return ereal.zero();
            if (x == 0.0)
            {
                if (n == 1) return 1 / ereal.t(3);
                if (n >= 0) return ereal.zero();
                else
                {
                    if (lrint(n) % 2 != 0) return ereal.neginf(); else return ereal.nan();
                }
            }
            return eflintc.sph_bessel_jn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Extended sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(ereal.t(n), ereal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Extended sph_bessel_yn_prime(Extended n, Extended x, bool scaled = false)
        {
            if (!ereal.isinteger(n)) return ereal.nan();

            if (ereal.isnan(x)) return ereal.nan();
            if (ereal.isinf(x)) return ereal.zero();
            if (ereal.isneginf(x)) return ereal.zero();
            if (x == 0.0)
            {
                if (n == -2) return -1 / ereal.t(3);
                if (n < 0) return ereal.zero();
                else
                {
                    if (lrint(n) % 2 == 0) return ereal.inf(); else return ereal.nan();
                }
            }
            return eflintc.sph_bessel_yn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Extended sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(ereal.t(n), ereal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Extended sph_bessel_in_prime(Extended n, Extended x, bool scaled = false)
        {
            if (!ereal.isinteger(n)) return ereal.nan();

            if (ereal.isnan(x)) return ereal.nan();
            if (ereal.isinf(x)) return ereal.inf();
            if (ereal.isneginf(x))
            {
                if (lrint(n) % 2 == 0) return ereal.neginf(); else return ereal.inf();
            }
            if (x == 0.0)
            {
                if (n == 0) return ereal.zero();
                if (n < 0)
                {
                    if (lrint(n) % 2 != 0) return ereal.neginf(); else return ereal.nan();
                }
            }
            return eflintc.sph_bessel_in_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Extended sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(ereal.t(n), ereal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Extended sph_bessel_kn_prime(Extended n, Extended x, bool scaled = false)
        {
            if (!ereal.isinteger(n)) return ereal.nan();

            if (ereal.isnan(x)) return ereal.nan();
            if (ereal.isinf(x)) return ereal.zero();
            if (ereal.isneginf(x)) return ereal.neginf();
            if (x == 0.0)
            {
                if (((n >= 0) && (lrint(n) % 2 == 0)) || ((n < 0) && (lrint(n) % 2 != 0))) return ereal.neginf();
                else return ereal.nan();
            }
            return eflintc.sph_bessel_kn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Extended sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(ereal.t(n), ereal.t(x), scaled);
        }





        #endregion







        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static ExtendedC hankel_h1(Extended v, Extended x)
        {
            return bessel_jv(v, x) + ecplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static ExtendedC hankel_h1(dynamic v, dynamic x)
        {
            return hankel_h1(ereal.t(v), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static ExtendedC hankel_h2(Extended v, Extended x)
        {
            return bessel_jv(v, x) - ecplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static ExtendedC hankel_h2(dynamic v, dynamic x)
        {
            return hankel_h2(ereal.t(v), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static ExtendedC sph_hankel_h1(int n, Extended x)
        {
            return sph_bessel_jn(n, x) + ecplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static ExtendedC sph_hankel_h1(int n, dynamic x)
        {
            return sph_hankel_h1(n, ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static ExtendedC sph_hankel_h2(int n, Extended x)
        {
            return sph_bessel_jn(n, x) - ecplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static ExtendedC sph_hankel_h2(int n, dynamic x)
        {
            return sph_hankel_h2(n, ereal.t(x));
        }






        #endregion





        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Extended airy_ai(Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS1Bool1(aflint.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Extended airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Extended airy_ai_prime(Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS1Bool1(aflint.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Extended airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Extended airy_bi(Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS1Bool1(aflint.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Extended airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Extended airy_bi_prime(Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS1Bool1(aflint.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Extended airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(ereal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        public static Extended airy_ai_zero(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_AiryAiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_AiryAiZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        public static Extended airy_ai_prime_zero(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_AiryAiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_AiryAiPrimeZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        public static Extended airy_bi_zero(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_AiryBiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_AiryBiZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        public static Extended airy_bi_prime_zero(Int32 n)
        {
            var res = new Extended();
            Lib_XReal_Arb_AiryBiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_AiryBiPrimeZero(IntPtr res, Int32 n);



        #endregion







        #region 0F1: Kelvin functions




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Extended kelvin_ber(Extended v, Extended x, bool scaled = false)
        {
            return eflintc.kelvin_ber(ecplx.t(v), ecplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Extended kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(ereal.t(v), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Extended kelvin_bei(Extended v, Extended x, bool scaled = false)
        {
            return eflintc.kelvin_bei(ecplx.t(v), ecplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Extended kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(ereal.t(v), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Extended kelvin_ker(Extended v, Extended x, bool scaled = false)
        {
            return eflintc.kelvin_ker(ecplx.t(v), ecplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Extended kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(ereal.t(v), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Extended kelvin_kei(Extended v, Extended x, bool scaled = false)
        {
            return eflintc.kelvin_kei(ecplx.t(v), ecplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Extended kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(ereal.t(v), ereal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Extended kelvin_ber_prime(Extended v, Extended x, bool scaled = false)
        {
            return eflintc.kelvin_ber_prime(ecplx.t(v), ecplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Extended kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(ereal.t(v), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Extended kelvin_bei_prime(Extended v, Extended x, bool scaled = false)
        {
            return eflintc.kelvin_bei_prime(ecplx.t(v), ecplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Extended kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(ereal.t(v), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Extended kelvin_ker_prime(Extended v, Extended x, bool scaled = false)
        {
            return eflintc.kelvin_ker_prime(ecplx.t(v), ecplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Extended kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(ereal.t(v), ereal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Extended kelvin_kei_prime(Extended v, Extended x, bool scaled = false)
        {
            return eflintc.kelvin_kei_prime(ecplx.t(v), ecplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Extended kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(ereal.t(v), ereal.t(x), scaled);
        }









        #endregion














        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Extended hyperg_1f1(Extended a, Extended b, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Extended hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(ereal.t(a), ereal.t(b), ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Extended hyperg_1f1r(Extended a, Extended b, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Extended hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(ereal.t(a), ereal.t(b), ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Extended hyperg_u(Extended a, Extended b, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Extended hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(ereal.t(a), ereal.t(b), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Extended hermite_h(Extended n, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Extended hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(ereal.t(n), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Extended hermite_he(Extended n, Extended x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Extended hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(ereal.t(n), ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Extended laguerre_l(Extended n, Extended m, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Extended laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(ereal.t(n), ereal.t(m), ereal.t(x));
        }






        #endregion




        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Extended gamma_upper(Extended s, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Extended gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(ereal.t(s), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Extended gamma_q(Extended s, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Extended gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(ereal.t(s), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Extended gamma_lower(Extended s, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Extended gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(ereal.t(s), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Extended gamma_p(Extended s, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Extended gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(ereal.t(s), ereal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Extended gamma_p_prime(Extended s, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Extended gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(ereal.t(s), ereal.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Extended erf(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Extended erf(dynamic x)
        {
            return erf(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Extended erfc(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Extended erfc(dynamic x)
        {
            return erfc(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Extended erf_inv(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Erfinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Erfinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Erfinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Extended erf_inv(dynamic x)
        {
            return erf_inv(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Extended erfc_inv(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Erfcinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Erfcinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Erfcinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Extended erfc_inv(dynamic x)
        {
            return erfc_inv(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Extended erfi(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Extended erfi(dynamic x)
        {
            return erfi(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Extended dawson(Extended x)
        {
            return aflint.ERealViaArbS1(aflint.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Extended dawson(dynamic x)
        {
            return dawson(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Extended fresnel_s(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Extended fresnel_s(dynamic x)
        {
            return fresnel_s(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Extended fresnel_c(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Extended fresnel_c(dynamic x)
        {
            return fresnel_c(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Extended ndens(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Extended ndens(dynamic x)
        {
            return ndens(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Extended ndis(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Extended ndis(dynamic x)
        {
            return ndis(ereal.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Extended exp_integral_en(Extended s, Extended z)
        {
            var res = new Extended();
            Lib_XReal_Arb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Extended exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(ereal.t(s), ereal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Extended exp_integral_e1(Extended z)
        {
            if (z < 0) return -exp_integral_ei(-z);
            else return exp_integral_en(ereal.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Extended exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(ereal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Extended exp_integral_ei(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Extended exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Extended sin_integral(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Extended sin_integral(dynamic x)
        {
            return sin_integral(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Extended cos_integral(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Extended cos_integral(dynamic x)
        {
            return cos_integral(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Extended sinh_integral(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Extended sinh_integral(dynamic x)
        {
            return sinh_integral(ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Extended cosh_integral(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Extended cosh_integral(dynamic x)
        {
            return cosh_integral(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Extended log_integral(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Extended log_integral(dynamic x)
        {
            return log_integral(ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Extended log_integral_offset(Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Extended log_integral_offset(dynamic x)
        {
            return log_integral_offset(ereal.t(x));
        }



        #endregion





        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Extended coulomb_f(Extended l, Extended eta, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Extended coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(ereal.t(l), ereal.t(eta), ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Extended coulomb_g(Extended l, Extended eta, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Extended coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(ereal.t(l), ereal.t(eta), ereal.t(x));
        }



        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Extended whittaker_m(Extended k, Extended m, Extended x)
        {
            return aflint.ERealViaArbS3(aflint.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Extended whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(ereal.t(k), ereal.t(m), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Extended whittaker_w(Extended k, Extended m, Extended x)
        {
            return aflint.ERealViaArbS3(aflint.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Extended whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(ereal.t(k), ereal.t(m), ereal.t(x));
        }




        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Extended pcfd(Extended n, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Extended pcfd(dynamic n, dynamic x)
        {
            return pcfd(ereal.t(n), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Extended pcfu(Extended a, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Extended pcfu(dynamic a, dynamic x)
        {
            return pcfu(ereal.t(a), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Extended pcfv(Extended a, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Extended pcfv(dynamic a, dynamic x)
        {
            return pcfv(ereal.t(a), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Extended pcfw(Extended a, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Extended pcfw(dynamic a, dynamic x)
        {
            return pcfw(ereal.t(a), ereal.t(x));
        }






        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Extended hyperg_2f1(Extended a, Extended b, Extended c, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hyp2f1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Extended hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(ereal.t(a), ereal.t(b), ereal.t(c), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Extended hyperg_2f1r(Extended a, Extended b, Extended c, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hyp2f1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Extended hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(ereal.t(a), ereal.t(b), ereal.t(c), ereal.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Extended chebyshev_t(Extended n, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Extended chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(ereal.t(n), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Extended chebyshev_u(Extended n, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Extended chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(ereal.t(n), ereal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static Extended chebyshev_v(Extended n, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2(aflint.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Extended chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(ereal.t(n), ereal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static Extended chebyshev_w(Extended n, Extended x, bool scaled = false)
        {
            return aflint.ERealViaArbS2(aflint.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Extended chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(ereal.t(n), ereal.t(y));
        }








        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Extended gegenbauer_c(Extended n, Extended m, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Extended gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(ereal.t(n), ereal.t(m), ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Extended jacobi_p(Extended n, Extended a, Extended b, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Extended jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(ereal.t(n), ereal.t(a), ereal.t(b), ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Extended legendre_p(Extended n, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.legendre_p, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_p/*' />
        public static Extended legendre_p(dynamic n, dynamic y)
        {
            return legendre_p(ereal.t(n), ereal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Extended legendre_q(Extended n, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.legendre_q, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_q/*' />
        public static Extended legendre_q(dynamic n, dynamic y)
        {
            return legendre_q(ereal.t(n), ereal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Extended legendre_plm(Extended n, Extended m, Extended x)
        {
            return aflint.ERealViaArbS3(aflint.legendre_plm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_plm/*' />
        public static Extended legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(ereal.t(n), ereal.t(m), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Extended legendre_qlm(Extended n, Extended m, Extended x)
        {
            return aflint.ERealViaArbS3(aflint.legendre_qlm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_qlm/*' />
        public static Extended legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(ereal.t(n), ereal.t(m), ereal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_plm/*' />
        public static Extended toroidal_plm(Extended l, Extended m, Extended x)
        {
            return aflint.ERealViaArbS3(aflint.toroidal_plm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_plm/*' />
        public static Extended toroidal_plm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_plm(ereal.t(l), ereal.t(m), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_qlm/*' />
        public static Extended toroidal_qlm(Extended l, Extended m, Extended x)
        {
            return aflint.ERealViaArbS3(aflint.toroidal_qlm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_qlm/*' />
        public static Extended toroidal_qlm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_qlm(ereal.t(l), ereal.t(m), ereal.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static ExtendedC spherical_y(Extended n, Extended m, Extended theta, Extended phi)
        {
            return eflintc.spherical_y(ecplx.t(n), ecplx.t(m), ecplx.t(theta), ecplx.t(phi));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static ExtendedC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(ereal.t(n), ereal.t(m), ereal.t(theta), ereal.t(phi));
        }







        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Extended beta_lower(Extended a, Extended b, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Extended beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(ereal.t(a), ereal.t(b), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Extended ibeta(Extended a, Extended b, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Extended ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(ereal.t(a), ereal.t(b), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Extended ibetac(Extended a, Extended b, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Extended ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(ereal.t(a), ereal.t(b), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Extended ibeta_prime(Extended a, Extended b, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Extended ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(ereal.t(a), ereal.t(b), ereal.t(x));
        }


        #endregion



        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Extended hyperg_1f2(Extended a1, Extended b1, Extended b2, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Extended hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(ereal.t(a1), ereal.t(b1), ereal.t(b2), ereal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Extended hyperg_1f2r(Extended a1, Extended b1, Extended b2, Extended x)
        {
            var res = new Extended();
            Lib_XReal_Arb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XReal_Arb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XReal_Arb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Extended hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(ereal.t(a1), ereal.t(b1), ereal.t(b2), ereal.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Extended airy_gi(Extended x)
        {
            return aflint.ERealViaArbS1(aflint.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Extended airy_gi(dynamic x)
        {
            return airy_gi(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Extended airy_hi(Extended x)
        {
            return aflint.ERealViaArbS1(aflint.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Extended airy_hi(dynamic x)
        {
            return airy_hi(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Extended airy_gi_prime(Extended x)
        {
            return aflint.ERealViaArbS1(aflint.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Extended airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Extended airy_hi_prime(Extended x)
        {
            return aflint.ERealViaArbS1(aflint.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Extended airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(ereal.t(x));
        }



        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Extended struve_h(Extended v, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Extended struve_h(dynamic v, dynamic x)
        {
            return struve_h(ereal.t(v), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Extended struve_l(Extended v, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Extended struve_l(dynamic v, dynamic x)
        {
            return struve_l(ereal.t(v), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Extended struve_k(Extended v, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Extended struve_k(dynamic v, dynamic x)
        {
            return struve_k(ereal.t(v), ereal.t(x));
        }


        public static Extended struve_m(Extended v, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static Extended struve_m(dynamic v, dynamic x)
        {
            return struve_m(ereal.t(v), ereal.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Extended anger_j(Extended v, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Extended anger_j(dynamic v, dynamic x)
        {
            return anger_j(ereal.t(v), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Extended weber_e(Extended v, Extended x)
        {
            return aflint.ERealViaArbS2(aflint.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Extended weber_e(dynamic v, dynamic x)
        {
            return weber_e(ereal.t(v), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Extended lommel_s1(Extended mu, Extended nu, Extended x)
        {
            return aflint.ERealViaArbS3(aflint.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Extended lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(ereal.t(mu), ereal.t(nu), ereal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Extended lommel_s2(Extended mu, Extended nu, Extended x)
        {
            return aflint.ERealViaArbS3(aflint.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Extended lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(ereal.t(mu), ereal.t(nu), ereal.t(x));
        }


        #endregion






        #endregion





    }






    public class eflintc
    {



        /// <summary>
        /// Returns a new ExtendedC using an ArbC number as input
        /// </summary>
        public static ExtendedC t(ArbC x)
        {
            ExtendedC res = ecplx.t(0);
            Lib_XCplx_Set_Acb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Set_Acb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Set_Acb(IntPtr res, IntPtr x);


        /// <summary>
        /// Returns a new ExtendedC using an MpfrC number as input
        /// </summary>
        public static ExtendedC t(MpfrC x)
        {
            ExtendedC res = ecplx.t(0);
            Lib_XCplx_Set_MpfrC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Set_MpfrC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Set_MpfrC(IntPtr res, IntPtr x);







        public static String fmt(ExtendedC z)
        {
            return ecplx.fmt(z);
        }


        public static String fmt(Extended x)
        {
            return ereal.fmt(x);
        }


        public static String fmt(dynamic z)
        {
            return fmt(ecplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "eflintc"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "eflintc"; }
        }


        public static eflint realctx
        {
            get { return new eflint(); }
        }



        #region Flint Basic Functions


        #region Complex components

        public static Extended abs(ExtendedC z)
        {
            return ecplx.abs(z);
        }


        public static Extended abs(dynamic z)
        {
            return ecplx.abs(z);
        }

        public static Extended fabs(ExtendedC z)
        {
            return ecplx.fabs(z);
        }


        public static Extended fabs(dynamic z)
        {
            return ecplx.fabs(z);
        }


        public static ExtendedC sign(ExtendedC z)
        {
            return ecplx.sign(z);
        }


        public static ExtendedC sign(dynamic z)
        {
            return ecplx.sign(z);
        }


        public static Extended real(ExtendedC z)
        {
            return z.real;
        }


        public static Extended real(dynamic z)
        {
            return real(ecplx.t(z));
        }


        public static Extended imag(ExtendedC z)
        {
            return z.imag;
        }


        public static Extended imag(dynamic z)
        {
            return imag(ecplx.t(z));
        }



        public static Extended phase(ExtendedC z)
        {
            return ecplx.phase(z);
        }


        public static Extended phase(dynamic z)
        {
            return ecplx.phase(z);
        }


        public static ExtendedC conj(ExtendedC z)
        {
            return ecplx.conj(z);
        }


        public static ExtendedC conj(dynamic z)
        {
            return ecplx.conj(z);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Extended, Extended> polar(ExtendedC x)
        {
            return new Tuple<Extended, Extended>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Extended, Extended> polar(dynamic x)
        {
            return polar(ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static ExtendedC rect(Extended r, Extended phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static ExtendedC rect(dynamic r, dynamic phi)
        {
            return rect(ereal.t(r), ereal.t(phi));
        }




        #endregion




        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static ExtendedC sqrt(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static ExtendedC sqrt(dynamic x)
        {
            return sqrt(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static ExtendedC rsqrt(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static ExtendedC rsqrt(dynamic x)
        {
            return rsqrt(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static ExtendedC cbrt(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static ExtendedC cbrt(dynamic x)
        {
            return cbrt(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static ExtendedC sqrt1pm1(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static ExtendedC sqrt1pm1(dynamic x)
        {
            return cbrt(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static ExtendedC unitroot(Int32 n)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_UnitRoot_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_UnitRoot_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_UnitRoot_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static ExtendedC root_si(ExtendedC x, Int32 n)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Root_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static ExtendedC root_si(dynamic x, Int32 n)
        {
            return root_si(ecplx.t(x), n);
        }




        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static ExtendedC exp(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static ExtendedC exp(dynamic x)
        {
            return exp(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static ExtendedC expj(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Expj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Expj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Expj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static ExtendedC expj(dynamic x)
        {
            return expj(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static ExtendedC expjpi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Expjpi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Expjpi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Expjpi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static ExtendedC expjpi(dynamic x)
        {
            return expjpi(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static ExtendedC exp10(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static ExtendedC exp10(dynamic x)
        {
            return exp10(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static ExtendedC exp2(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static ExtendedC exp2(dynamic x)
        {
            return exp2(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static ExtendedC expm1(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static ExtendedC expm1(dynamic x)
        {
            return expm1(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static ExtendedC exp10m1(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static ExtendedC exp10m1(dynamic x)
        {
            return exp10m1(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static ExtendedC exp2m1(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static ExtendedC exp2m1(dynamic x)
        {
            return exp2m1(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static ExtendedC exprel(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static ExtendedC exprel(dynamic x)
        {
            return exprel(ecplx.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static ExtendedC logbase(ExtendedC x, ExtendedC b)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static ExtendedC logbase(dynamic x, dynamic b)
        {
            return logbase(ecplx.t(x), ecplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static ExtendedC log(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static ExtendedC log(dynamic x)
        {
            return log(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static ExtendedC log10(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static ExtendedC log10(dynamic x)
        {
            return log10(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static ExtendedC log2(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static ExtendedC log2(dynamic x)
        {
            return log2(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static ExtendedC log1p(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static ExtendedC log1p(dynamic x)
        {
            return log1p(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static ExtendedC log10p1(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static ExtendedC log10p1(dynamic x)
        {
            return log10p1(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static ExtendedC log2p1(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static ExtendedC log2p1(dynamic x)
        {
            return log2p1(ecplx.t(x));
        }



        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static ExtendedC sqr(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static ExtendedC sqr(dynamic x)
        {
            return sqr(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static ExtendedC cube(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static ExtendedC cube(dynamic x)
        {
            return cube(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static ExtendedC hypot(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static ExtendedC hypot(dynamic x, dynamic y)
        {
            return hypot(ecplx.t(x), ecplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static ExtendedC pow_si(ExtendedC x, Int32 n)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Pow_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Pow_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static ExtendedC pow_si(dynamic x, Int32 n)
        {
            return pow_si(ecplx.t(x), n);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static ExtendedC compound_si(ExtendedC x, Int32 n)
        {
            return pow1p(ecplx.t(x), ecplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static ExtendedC compound_si(dynamic x, Int32 n)
        {
            return pow1p(ecplx.t(x), ecplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static ExtendedC pow(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static ExtendedC pow(dynamic x, dynamic y)
        {
            return pow(ecplx.t(x), ecplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static ExtendedC powm1(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static ExtendedC powm1(dynamic x, dynamic y)
        {
            return powm1(ecplx.t(x), ecplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static ExtendedC pow1p(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static ExtendedC pow1p(dynamic x, dynamic y)
        {
            return pow1p(ecplx.t(x), ecplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static ExtendedC pow1pm1(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static ExtendedC pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(ecplx.t(x), ecplx.t(y));
        }



        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static ExtendedC sin(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static ExtendedC sin(dynamic x)
        {
            return sin(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static ExtendedC cos(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static ExtendedC cos(dynamic x)
        {
            return cos(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static ExtendedC tan(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static ExtendedC tan(dynamic x)
        {
            return tan(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static ExtendedC cot(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static ExtendedC cot(dynamic x)
        {
            return cot(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static ExtendedC sec(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static ExtendedC sec(dynamic x)
        {
            return sec(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static ExtendedC csc(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static ExtendedC csc(dynamic x)
        {
            return csc(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static ExtendedC sinc(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static ExtendedC sinc(dynamic x)
        {
            return sinc(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static ExtendedC sinpi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static ExtendedC sinpi(dynamic x)
        {
            return sinpi(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static ExtendedC cospi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static ExtendedC cospi(dynamic x)
        {
            return cospi(ecplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static ExtendedC tanpi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static ExtendedC tanpi(dynamic x)
        {
            return tanpi(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static ExtendedC cotpi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static ExtendedC cotpi(dynamic x)
        {
            return cotpi(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static ExtendedC cscpi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CscPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CscPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CscPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static ExtendedC cscpi(dynamic x)
        {
            return cscpi(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static ExtendedC secpi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_SecPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_SecPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_SecPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static ExtendedC secpi(dynamic x)
        {
            return secpi(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static ExtendedC sincpi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static ExtendedC sincpi(dynamic x)
        {
            return sincpi(ecplx.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static ExtendedC cosh(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static ExtendedC cosh(dynamic x)
        {
            return cosh(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static ExtendedC sinh(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static ExtendedC sinh(dynamic x)
        {
            return sinh(ecplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static ExtendedC tanh(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static ExtendedC tanh(dynamic x)
        {
            return tanh(ecplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static ExtendedC csch(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static ExtendedC csch(dynamic x)
        {
            return csch(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static ExtendedC sech(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static ExtendedC sech(dynamic x)
        {
            return sech(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static ExtendedC coth(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static ExtendedC coth(dynamic x)
        {
            return coth(ecplx.t(x));
        }





        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static ExtendedC asin(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static ExtendedC asin(dynamic x)
        {
            return asin(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static ExtendedC acos(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static ExtendedC acos(dynamic x)
        {
            return acos(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static ExtendedC atan(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static ExtendedC atan(dynamic x)
        {
            return atan(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static ExtendedC acsc(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static ExtendedC acsc(dynamic x)
        {
            return acsc(ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static ExtendedC asec(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static ExtendedC asec(dynamic x)
        {
            return asec(ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static ExtendedC acot(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static ExtendedC acot(dynamic x)
        {
            return acot(ecplx.t(x));
        }


        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static ExtendedC asinh(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static ExtendedC asinh(dynamic x)
        {
            return asinh(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static ExtendedC acosh(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static ExtendedC acosh(dynamic x)
        {
            return acosh(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static ExtendedC atanh(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static ExtendedC atanh(dynamic x)
        {
            return atanh(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static ExtendedC acsch(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static ExtendedC acsch(dynamic x)
        {
            return acsch(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static ExtendedC asech(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static ExtendedC asech(dynamic x)
        {
            return asech(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static ExtendedC acoth(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static ExtendedC acoth(dynamic x)
        {
            return acoth(ecplx.t(x));
        }





        #endregion




        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static ExtendedC gamma(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static ExtendedC gamma(dynamic x)
        {
            return gamma(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static ExtendedC rgamma(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static ExtendedC rgamma(dynamic x)
        {
            return rgamma(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static ExtendedC lgamma(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static ExtendedC lgamma(dynamic x)
        {
            return lgamma(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static ExtendedC rising_factorial(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static ExtendedC rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(ecplx.t(x), ecplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static ExtendedC beta(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static ExtendedC beta(dynamic x, dynamic y)
        {
            return beta(ecplx.t(x), ecplx.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static ExtendedC gamma1pm1(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static ExtendedC gamma1pm1(dynamic x)
        {
            return gamma1pm1(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static ExtendedC factorial(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static ExtendedC factorial(dynamic x)
        {
            return factorial(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static ExtendedC doublefactorial(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static ExtendedC doublefactorial(dynamic x)
        {
            return doublefactorial(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static ExtendedC falling_factorial(ExtendedC a, ExtendedC n)
        {
            return aflintc.ECplxViaArbCS2(aflintc.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static ExtendedC falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(ecplx.t(a), ecplx.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static ExtendedC gamma_ratio(ExtendedC a, ExtendedC b)
        {
            return aflintc.ECplxViaArbCS2(aflintc.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static ExtendedC gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(ecplx.t(a), ecplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static ExtendedC gamma_delta_ratio(ExtendedC a, ExtendedC delta)
        {
            return aflintc.ECplxViaArbCS2(aflintc.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static ExtendedC gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(ecplx.t(a), ecplx.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static ExtendedC binomial(ExtendedC n, ExtendedC k)
        {
            return aflintc.ECplxViaArbCS2(aflintc.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static ExtendedC binomial(dynamic n, dynamic k)
        {
            return binomial(ecplx.t(n), ecplx.t(k));
        }










        #endregion



        #region Miscellaneous



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static ExtendedC lambert_wk(ExtendedC x, int branch)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_LambertW_ui(res.mpPtr, x.mpPtr, branch);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LambertW_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_LambertW_ui(IntPtr res, IntPtr x, int branch);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static ExtendedC lambert_wk(dynamic x, int branch)
        {
            return lambert_wk(ecplx.t(x), branch);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static ExtendedC lambert_w0(ExtendedC x)
        {
            return lambert_wk(ecplx.t(x), 0);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static ExtendedC lambert_w0(dynamic x)
        {
            return lambert_w0(ecplx.t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static ExtendedC lambert_wm1(ExtendedC x)
        {
            return lambert_wk(ecplx.t(x), -1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static ExtendedC lambert_wm1(dynamic x)
        {
            return lambert_wm1(ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static ExtendedC agm(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static ExtendedC agm(dynamic x, dynamic y)
        {
            return agm(ecplx.t(x), ecplx.t(y));
        }






        #endregion




        #endregion





        #region Flint Special Functions


        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static ExtendedC elliptic_rc(ExtendedC x, ExtendedC y)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static ExtendedC elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(ecplx.t(x), ecplx.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static ExtendedC elliptic_rf(ExtendedC x, ExtendedC y, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static ExtendedC elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(ecplx.t(x), ecplx.t(y), ecplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static ExtendedC elliptic_rg(ExtendedC x, ExtendedC y, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static ExtendedC elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(ecplx.t(x), ecplx.t(y), ecplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static ExtendedC elliptic_rd(ExtendedC x, ExtendedC y, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static ExtendedC elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(ecplx.t(x), ecplx.t(y), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static ExtendedC elliptic_rj(ExtendedC x, ExtendedC y, ExtendedC z, ExtendedC w)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static ExtendedC elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(ecplx.t(x), ecplx.t(y), ecplx.t(z), ecplx.t(w));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static ExtendedC m_elliptic_k(ExtendedC m)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static ExtendedC m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static ExtendedC m_elliptic_e(ExtendedC m)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static ExtendedC m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static ExtendedC m_elliptic_pi(ExtendedC n, ExtendedC m)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static ExtendedC m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(ecplx.t(x), ecplx.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static ExtendedC m_elliptic_f(ExtendedC phi, ExtendedC m)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static ExtendedC m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(ecplx.t(phi), ecplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static ExtendedC m_elliptic_e_inc(ExtendedC phi, ExtendedC m)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static ExtendedC m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(ecplx.t(phi), ecplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static ExtendedC m_elliptic_pi_inc(ExtendedC n, ExtendedC phi, ExtendedC m)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static ExtendedC m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(ecplx.t(n), ecplx.t(phi), ecplx.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static ExtendedC elliptic_k(ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static ExtendedC elliptic_k(dynamic k)
        {
            return elliptic_k(ecplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static ExtendedC elliptic_e(ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static ExtendedC elliptic_e(dynamic k)
        {
            return elliptic_e(ecplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static ExtendedC elliptic_pi(ExtendedC n, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static ExtendedC elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(ecplx.t(n), ecplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static ExtendedC elliptic_f(ExtendedC phi, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static ExtendedC elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(ecplx.t(phi), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static ExtendedC elliptic_e_inc(ExtendedC phi, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static ExtendedC elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(ecplx.t(phi), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static ExtendedC elliptic_pi_inc(ExtendedC n, ExtendedC phi, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static ExtendedC elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(ecplx.t(n), ecplx.t(phi), ecplx.t(k));
        }



        #endregion




        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static ExtendedC jacobi_theta1(ExtendedC x, ExtendedC q)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static ExtendedC jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(ecplx.t(x), ecplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static ExtendedC jacobi_theta2(ExtendedC x, ExtendedC q)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static ExtendedC jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(ecplx.t(x), ecplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static ExtendedC jacobi_theta3(ExtendedC x, ExtendedC q)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static ExtendedC jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(ecplx.t(x), ecplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static ExtendedC jacobi_theta4(ExtendedC x, ExtendedC q)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static ExtendedC jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(ecplx.t(x), ecplx.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static ExtendedC JacobiTheta1Tau(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Theta1QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Theta1QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Theta1QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static ExtendedC JacobiTheta1Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta1Tau(ecplx.t(z), ecplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static ExtendedC JacobiTheta2Tau(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Theta2QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Theta2QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Theta2QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static ExtendedC JacobiTheta2Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta2Tau(ecplx.t(z), ecplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static ExtendedC JacobiTheta3Tau(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Theta3QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Theta3QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Theta3QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static ExtendedC JacobiTheta3Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta3Tau(ecplx.t(z), ecplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static ExtendedC JacobiTheta4Tau(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Theta4QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Theta4QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_Theta4QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static ExtendedC JacobiTheta4Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta4Tau(ecplx.t(z), ecplx.t(tau));
        }






        #endregion



        #region Jacobi elliptic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static ExtendedC QfromK(ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_QfromK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_QfromK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_QfromK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static ExtendedC QfromK(dynamic k)
        {
            return QfromK(ecplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static ExtendedC TfromUQ(ExtendedC u, ExtendedC q)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_TfromUQ(res.mpPtr, u.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_TfromUQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_TfromUQ(IntPtr res, IntPtr u, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static ExtendedC TfromUQ(dynamic n, dynamic k)
        {
            return TfromUQ(ecplx.t(n), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static ExtendedC SnTQ(ExtendedC t, ExtendedC q)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_SnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_SnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_SnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static ExtendedC SnTQ(dynamic t, dynamic q)
        {
            return SnTQ(ecplx.t(t), ecplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static ExtendedC CnTQ(ExtendedC t, ExtendedC q)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_CnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static ExtendedC CnTQ(dynamic t, dynamic q)
        {
            return CnTQ(ecplx.t(t), ecplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static ExtendedC DnTQ(ExtendedC t, ExtendedC q)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_DnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_DnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_DnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static ExtendedC DnTQ(dynamic t, dynamic q)
        {
            return DnTQ(ecplx.t(t), ecplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static ExtendedC jacobi_sn(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static ExtendedC jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static ExtendedC jacobi_cn(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static ExtendedC jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static ExtendedC jacobi_dn(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static ExtendedC jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static ExtendedC jacobi_ns(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static ExtendedC jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static ExtendedC jacobi_nc(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static ExtendedC jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static ExtendedC jacobi_nd(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static ExtendedC jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static ExtendedC jacobi_sc(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static ExtendedC jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static ExtendedC jacobi_sd(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static ExtendedC jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static ExtendedC jacobi_dc(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static ExtendedC jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static ExtendedC jacobi_ds(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static ExtendedC jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static ExtendedC jacobi_cs(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static ExtendedC jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(ecplx.t(x), ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static ExtendedC jacobi_cd(ExtendedC x, ExtendedC k)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static ExtendedC jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(ecplx.t(x), ecplx.t(k));
        }




        #endregion





        #region Conversions of parameters of Weierstrass P


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ExtendedC, ExtendedC> elliptic_invariants_from_roots(ExtendedC e1, ExtendedC e2)
        {
            ExtendedC e3 = -e1 - e2;
            ExtendedC g2 = 2 * (e1 * e1 + e2 * e2 + e3 * e3);
            ExtendedC g3 = 4 * e1 * e2 * e3;
            return new Tuple<ExtendedC, ExtendedC>(g2, g3);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ExtendedC, ExtendedC> elliptic_invariants_from_roots(dynamic e1, dynamic e2)
        {
            return elliptic_invariants_from_roots(ecplx.t(e1), ecplx.t(e2));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ExtendedC, ExtendedC> elliptic_invariants_from_tau(ExtendedC tau)
        {
            return new Tuple<ExtendedC, ExtendedC>(EllipticInvariantG2(tau), EllipticInvariantG3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ExtendedC, ExtendedC> elliptic_invariants_from_tau(dynamic tau)
        {
            return elliptic_invariants_from_tau(ecplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ExtendedC, ExtendedC, ExtendedC> elliptic_roots_from_tau(ExtendedC tau)
        {
            return new Tuple<ExtendedC, ExtendedC, ExtendedC>(EllipticRootE1(tau), EllipticRootE2(tau), EllipticRootE3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ExtendedC, ExtendedC, ExtendedC> elliptic_roots_from_tau(dynamic tau)
        {
            return elliptic_roots_from_tau(ecplx.t(tau));
        }



        #endregion






        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static ExtendedC weierstrass_p_t(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_WeierstrassP(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_WeierstrassP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_WeierstrassP(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static ExtendedC weierstrass_p_t(dynamic z, dynamic tau)
        {
            return weierstrass_p_t(ecplx.t(z), ecplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static ExtendedC WeierstrassPInv(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_WeierstrassPInv(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_WeierstrassPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_WeierstrassPInv(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static ExtendedC WeierstrassPInv(dynamic z, dynamic tau)
        {
            return WeierstrassPInv(ecplx.t(z), ecplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static ExtendedC weierstrass_zeta_t(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_WeierstrassPZeta(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_WeierstrassPZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_WeierstrassPZeta(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static ExtendedC weierstrass_zeta_t(dynamic z, dynamic tau)
        {
            return weierstrass_zeta_t(ecplx.t(z), ecplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static ExtendedC weierstrass_sigma_t(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_WeierstrassPSigma(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_WeierstrassPSigma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_WeierstrassPSigma(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static ExtendedC weierstrass_sigma_t(dynamic z, dynamic tau)
        {
            return weierstrass_sigma_t(ecplx.t(z), ecplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static ExtendedC weierstrass_pprime_t(ExtendedC z, ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_WeierstrassPPrime(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_WeierstrassPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_WeierstrassPPrime(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static ExtendedC weierstrass_pprime_t(dynamic z, dynamic tau)
        {
            return weierstrass_pprime_t(ecplx.t(z), ecplx.t(tau));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static ExtendedC EllipticInvariantG2(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticInvariantG2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticInvariantG2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticInvariantG2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static ExtendedC EllipticInvariantG2(dynamic k)
        {
            return EllipticInvariantG2(ecplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static ExtendedC EllipticInvariantG3(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticInvariantG3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticInvariantG3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticInvariantG3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static ExtendedC EllipticInvariantG3(dynamic k)
        {
            return EllipticInvariantG3(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static ExtendedC EllipticRootE1(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticRootE1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticRootE1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticRootE1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static ExtendedC EllipticRootE1(dynamic k)
        {
            return EllipticRootE1(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static ExtendedC EllipticRootE2(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticRootE2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticRootE2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticRootE2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static ExtendedC EllipticRootE2(dynamic k)
        {
            return EllipticRootE2(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static ExtendedC EllipticRootE3(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EllipticRootE3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EllipticRootE3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_EllipticRootE3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static ExtendedC EllipticRootE3(dynamic k)
        {
            return EllipticRootE3(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static ExtendedC dedekind_eta(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_DedekindEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_DedekindEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_DedekindEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static ExtendedC dedekind_eta(dynamic k)
        {
            return dedekind_eta(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static ExtendedC klein_j(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_KleinJ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_KleinJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_KleinJ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static ExtendedC klein_j(dynamic k)
        {
            return klein_j(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static ExtendedC modular_lambda(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ModularLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ModularLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_ModularLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static ExtendedC modular_lambda(dynamic k)
        {
            return modular_lambda(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static ExtendedC modular_delta(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ModularDelta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ModularDelta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_ModularDelta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static ExtendedC modular_delta(dynamic k)
        {
            return modular_delta(ecplx.t(k));
        }



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static ExtendedC lerch_phi(ExtendedC s, ExtendedC z, ExtendedC a)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static ExtendedC lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(ecplx.t(s), ecplx.t(z), ecplx.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static ExtendedC lerch_zeta(ExtendedC lambda1, ExtendedC alpha, ExtendedC s)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_LerchZeta(res.mpPtr, lambda1.mpPtr, alpha.mpPtr, s.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LerchZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_LerchZeta(IntPtr res, IntPtr lambda1, IntPtr alpha, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static ExtendedC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(ecplx.t(lambda1), ecplx.t(alpha), ecplx.t(s));
        }




        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static ExtendedC polygamma(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static ExtendedC polygamma(dynamic s, dynamic z)
        {
            return polygamma(ecplx.t(s), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static ExtendedC trigamma(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Trigamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Trigamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static ExtendedC trigamma(dynamic x)
        {
            return trigamma(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static ExtendedC digamma(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static ExtendedC digamma(dynamic x)
        {
            return digamma(ecplx.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static ExtendedC polylog(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static ExtendedC polylog(dynamic s, dynamic z)
        {
            return polylog(ecplx.t(s), ecplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static ExtendedC trilog(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Trilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Trilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Trilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static ExtendedC trilog(dynamic x)
        {
            return trilog(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static ExtendedC dilog(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static ExtendedC dilog(dynamic x)
        {
            return dilog(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static ExtendedC clausen_sin(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ClausenSin(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ClausenSin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_ClausenSin(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static ExtendedC clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(ecplx.t(s), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static ExtendedC clausen_cos(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ClausenCos(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ClausenCos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_ClausenCos(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static ExtendedC clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(ecplx.t(s), ecplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static ExtendedC clausen2(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Clausen2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Clausen2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Clausen2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static ExtendedC clausen2(dynamic x)
        {
            return clausen2(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static ExtendedC bose_einstein(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_BoseEinstein(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_BoseEinstein", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_BoseEinstein(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static ExtendedC bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(ecplx.t(s), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static ExtendedC fermi_dirac(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_FermiDirac(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_FermiDirac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_FermiDirac(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static ExtendedC fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(ecplx.t(s), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static ExtendedC legendre_chi(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_LegendreChi(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LegendreChi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_LegendreChi(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static ExtendedC legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(ecplx.t(s), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static ExtendedC inverse_tan_integral(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_InverseTanIntegral(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_InverseTanIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_InverseTanIntegral(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static ExtendedC inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(ecplx.t(s), ecplx.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static ExtendedC hurwitz_zeta(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_HurwitzZeta(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static ExtendedC hurwitz_zeta(dynamic s, dynamic z)
        {
            return hurwitz_zeta(ecplx.t(s), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/stieltjes/*' />
        public static ExtendedC stieltjes(ExtendedC x, Int32 n)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Stieltjes_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Stieltjes_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Stieltjes_ui(IntPtr res, IntPtr x, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static ExtendedC bernpoly(ExtendedC x, Int32 n)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static ExtendedC bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(ecplx.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static ExtendedC eulerpoly(ExtendedC x, Int32 n)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_EulerPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_EulerPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_EulerPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static ExtendedC eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(ecplx.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static ExtendedC harmonic(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Harmonic(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Harmonic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Harmonic(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static ExtendedC harmonic(dynamic x)
        {
            return harmonic(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static ExtendedC harmonic2(ExtendedC z, ExtendedC r)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Harmonic2(res.mpPtr, z.mpPtr, r.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Harmonic2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Harmonic2(IntPtr res, IntPtr z, IntPtr r);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static ExtendedC harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(ecplx.t(z), ecplx.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static ExtendedC barnes_g(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static ExtendedC barnes_g(dynamic x)
        {
            return barnes_g(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static ExtendedC logbarnes_g(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static ExtendedC logbarnes_g(dynamic x)
        {
            return logbarnes_g(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static ExtendedC hyperfactorial(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hyperfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hyperfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hyperfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static ExtendedC hyperfactorial(dynamic x)
        {
            return hyperfactorial(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static ExtendedC superfactorial(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Superfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Superfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Superfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static ExtendedC superfactorial(dynamic x)
        {
            return superfactorial(ecplx.t(x));
        }




        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static ExtendedC zeta(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static ExtendedC zeta(dynamic x)
        {
            return zeta(ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static ExtendedC zetam1(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Zetam1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Zetam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Zetam1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static ExtendedC zetam1(dynamic x)
        {
            return zetam1(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static ExtendedC riemann_xi(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_DirichletXi(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_DirichletXi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_DirichletXi(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static ExtendedC riemann_xi(dynamic k)
        {
            return riemann_xi(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static ExtendedC dirichlet_eta(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_DirichletEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_DirichletEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_DirichletEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static ExtendedC dirichlet_eta(dynamic k)
        {
            return dirichlet_eta(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static ExtendedC dirichlet_etam1(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_DirichletEtam1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_DirichletEtam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_DirichletEtam1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static ExtendedC dirichlet_etam1(dynamic k)
        {
            return dirichlet_etam1(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static ExtendedC dirichlet_beta(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_DirichletBeta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_DirichletBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_DirichletBeta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static ExtendedC dirichlet_beta(dynamic k)
        {
            return dirichlet_beta(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static ExtendedC dirichlet_lambda(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_DirichletLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_DirichletLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_DirichletLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static ExtendedC dirichlet_lambda(dynamic k)
        {
            return dirichlet_lambda(ecplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static ExtendedC hardy_z(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_HardyZ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_HardyZ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_HardyZ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static ExtendedC hardy_z(dynamic k)
        {
            return hardy_z(ecplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static ExtendedC hardy_theta(ExtendedC tau)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_HardyTheta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_HardyTheta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_XCplx_Acb_HardyTheta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static ExtendedC hardy_theta(dynamic k)
        {
            return hardy_theta(ecplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta_zero/*' />
        public static ExtendedC zeta_zero(Int32 n)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ZetaZero_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ZetaZero_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_ZetaZero_ui(IntPtr res, Int32 n);



        #endregion



        #region Additional numbertheoretic functions





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static ExtendedC hyperg_0f1(ExtendedC a, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static ExtendedC hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(ecplx.t(a), ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static ExtendedC hyperg_0f1r(ExtendedC a, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static ExtendedC hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(ecplx.t(a), ecplx.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static ExtendedC bessel_jv(ExtendedC nu, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static ExtendedC bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(ecplx.t(nu), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static ExtendedC bessel_yv(ExtendedC nu, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static ExtendedC bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(ecplx.t(nu), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static ExtendedC bessel_iv(ExtendedC nu, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static ExtendedC bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(ecplx.t(nu), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static ExtendedC bessel_kv(ExtendedC nu, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static ExtendedC bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(ecplx.t(nu), ecplx.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static ExtendedC bessel_jv_prime(ExtendedC nu, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static ExtendedC bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(ecplx.t(nu), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static ExtendedC bessel_yv_prime(ExtendedC nu, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static ExtendedC bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(ecplx.t(nu), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static ExtendedC bessel_iv_prime(ExtendedC nu, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static ExtendedC bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(ecplx.t(nu), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static ExtendedC bessel_kv_prime(ExtendedC nu, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static ExtendedC bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(ecplx.t(nu), ecplx.t(x), scaled);
        }









        #endregion







        #region 0F1: Spherical Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static ExtendedC sph_bessel_jn(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_bessel_jn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static ExtendedC sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(ecplx.t(n), ecplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static ExtendedC sph_bessel_yn(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_bessel_yn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static ExtendedC sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(ecplx.t(n), ecplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static ExtendedC sph_bessel_in(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_bessel_in, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static ExtendedC sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(ecplx.t(n), ecplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static ExtendedC sph_bessel_kn(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_bessel_kn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static ExtendedC sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(ecplx.t(n), ecplx.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static ExtendedC besselpoly(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.besselpoly, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static ExtendedC besselpoly(dynamic n, dynamic x, bool scaled = false)
        {
            return besselpoly(ecplx.t(n), ecplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static ExtendedC besseltheta(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.besseltheta, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static ExtendedC besseltheta(dynamic n, dynamic x, bool scaled = false)
        {
            return besseltheta(ecplx.t(n), ecplx.t(x), scaled);
        }









        #endregion



        #region 0F1: Spherical Bessel functions, first derivative


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static ExtendedC sph_bessel_jn_prime(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_bessel_jn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static ExtendedC sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(ecplx.t(n), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static ExtendedC sph_bessel_yn_prime(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_bessel_yn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static ExtendedC sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(ecplx.t(n), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static ExtendedC sph_bessel_in_prime(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_bessel_in_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static ExtendedC sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(ecplx.t(n), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static ExtendedC sph_bessel_kn_prime(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_bessel_kn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static ExtendedC sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(ecplx.t(n), ecplx.t(x), scaled);
        }



        #endregion







        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static ExtendedC hankel_h1(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.hankel_h1, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static ExtendedC hankel_h1(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h1(ecplx.t(v), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static ExtendedC hankel_h2(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.hankel_h2, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static ExtendedC hankel_h2(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h2(ecplx.t(v), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static ExtendedC sph_hankel_h1(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_hankel_h1, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static ExtendedC sph_hankel_h1(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h1(ecplx.t(n), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static ExtendedC sph_hankel_h2(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.sph_hankel_h2, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static ExtendedC sph_hankel_h2(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h2(ecplx.t(n), ecplx.t(x), scaled);
        }





        #endregion





        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static ExtendedC airy_ai(ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS1Bool1(aflintc.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static ExtendedC airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static ExtendedC airy_ai_prime(ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS1Bool1(aflintc.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static ExtendedC airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static ExtendedC airy_bi(ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS1Bool1(aflintc.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static ExtendedC airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static ExtendedC airy_bi_prime(ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS1Bool1(aflintc.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static ExtendedC airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(ecplx.t(x), scaled);
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static ExtendedC airy_ai(ExtendedC x, bool scaled = false)
        //{
        //    var res = new ExtendedC();
        //    Lib_XCplx_Acb_AiryAi(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp((ereal.t(2) / ereal.t(3)) * x * sqrt(x));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_XCplx_Acb_AiryAi(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static ExtendedC airy_ai(dynamic x, bool scaled = false)
        //{
        //    return airy_ai(ecplx.t(x), scaled);
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static ExtendedC airy_ai_prime(ExtendedC x, bool scaled = false)
        //{
        //    var res = new ExtendedC();
        //    Lib_XCplx_Acb_AiryAiPrime(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp((ereal.t(2) / ereal.t(3)) * x * sqrt(x));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_XCplx_Acb_AiryAiPrime(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static ExtendedC airy_ai_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_ai_prime(ecplx.t(x), scaled);
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static ExtendedC airy_bi(ExtendedC x, bool scaled = false)
        //{
        //    var res = new ExtendedC();
        //    Lib_XCplx_Acb_AiryBi(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp(-abs(ereal.t(2) / ereal.t(3) * (x * sqrt(x)).real));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_XCplx_Acb_AiryBi(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static ExtendedC airy_bi(dynamic x, bool scaled = false)
        //{
        //    return airy_bi(ecplx.t(x), scaled);
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static ExtendedC airy_bi_prime(ExtendedC x, bool scaled = false)
        //{
        //    var res = new ExtendedC();
        //    Lib_XCplx_Acb_AiryBiPrime(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp(-abs(ereal.t(2) / ereal.t(3) * (x * sqrt(x)).real));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_XCplx_Acb_AiryBiPrime(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static ExtendedC airy_bi_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_bi_prime(ecplx.t(x), scaled);
        //}



        #endregion






        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static ExtendedC kelvin_ber(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.kelvin_ber, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static ExtendedC kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(ecplx.t(v), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static ExtendedC kelvin_bei(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.kelvin_bei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static ExtendedC kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(ecplx.t(v), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static ExtendedC kelvin_ker(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.kelvin_ker, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static ExtendedC kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(ecplx.t(v), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static ExtendedC kelvin_kei(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.kelvin_kei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static ExtendedC kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(ecplx.t(v), ecplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static ExtendedC kelvin_ber_prime(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.kelvin_ber_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static ExtendedC kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(ecplx.t(v), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static ExtendedC kelvin_bei_prime(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.kelvin_bei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static ExtendedC kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(ecplx.t(v), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static ExtendedC kelvin_ker_prime(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.kelvin_ker_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static ExtendedC kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(ecplx.t(v), ecplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static ExtendedC kelvin_kei_prime(ExtendedC v, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2Bool1(aflintc.kelvin_kei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static ExtendedC kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(ecplx.t(v), ecplx.t(x), scaled);
        }





        #endregion













        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static ExtendedC hyperg_1f1(ExtendedC a, ExtendedC b, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static ExtendedC hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(ecplx.t(a), ecplx.t(b), ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static ExtendedC hyperg_1f1r(ExtendedC a, ExtendedC b, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static ExtendedC hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(ecplx.t(a), ecplx.t(b), ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static ExtendedC hyperg_u(ExtendedC a, ExtendedC b, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static ExtendedC hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(ecplx.t(a), ecplx.t(b), ecplx.t(x));
        }





        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static ExtendedC gamma_upper(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static ExtendedC gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(ecplx.t(s), ecplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static ExtendedC gamma_q(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static ExtendedC gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(ecplx.t(s), ecplx.t(z));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static ExtendedC gamma_lower(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static ExtendedC gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(ecplx.t(s), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static ExtendedC gamma_p(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static ExtendedC gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(ecplx.t(s), ecplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static ExtendedC gamma_p_prime(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static ExtendedC gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(ecplx.t(s), ecplx.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static ExtendedC erf(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static ExtendedC erf(dynamic x)
        {
            return erf(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static ExtendedC erfc(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static ExtendedC erfc(dynamic x)
        {
            return erfc(ecplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static ExtendedC erfi(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static ExtendedC erfi(dynamic x)
        {
            return erfi(ecplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static ExtendedC dawson(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static ExtendedC dawson(dynamic x)
        {
            return dawson(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static ExtendedC faddeeva(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.faddeeva, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static ExtendedC faddeeva(dynamic x)
        {
            return faddeeva(ecplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static ExtendedC fresnel_s(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static ExtendedC fresnel_s(dynamic x)
        {
            return fresnel_s(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static ExtendedC fresnel_c(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static ExtendedC fresnel_c(dynamic x)
        {
            return fresnel_c(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static ExtendedC ndens(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static ExtendedC ndens(dynamic x)
        {
            return ndens(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static ExtendedC ndis(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static ExtendedC ndis(dynamic x)
        {
            return ndis(ecplx.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static ExtendedC exp_integral_en(ExtendedC s, ExtendedC z)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static ExtendedC exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(ecplx.t(s), ecplx.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static ExtendedC exp_integral_e1(ExtendedC z)
        {
            return exp_integral_en(ecplx.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static ExtendedC exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(ecplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static ExtendedC exp_integral_ei(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static ExtendedC exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static ExtendedC sin_integral(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static ExtendedC sin_integral(dynamic x)
        {
            return sin_integral(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static ExtendedC cos_integral(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static ExtendedC cos_integral(dynamic x)
        {
            return cos_integral(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static ExtendedC sinh_integral(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static ExtendedC sinh_integral(dynamic x)
        {
            return sinh_integral(ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static ExtendedC cosh_integral(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static ExtendedC cosh_integral(dynamic x)
        {
            return cosh_integral(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static ExtendedC log_integral(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static ExtendedC log_integral(dynamic x)
        {
            return log_integral(ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static ExtendedC log_integral_offset(ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static ExtendedC log_integral_offset(dynamic x)
        {
            return log_integral_offset(ecplx.t(x));
        }



        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static ExtendedC hermite_h(ExtendedC n, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static ExtendedC hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(ecplx.t(n), ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static ExtendedC hermite_he(ExtendedC n, ExtendedC x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static ExtendedC hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(ecplx.t(n), ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static ExtendedC laguerre_l(ExtendedC n, ExtendedC m, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static ExtendedC laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(ecplx.t(n), ecplx.t(m), ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre/*' />
        public static ExtendedC laguerre(ExtendedC n, ExtendedC x)
        {
            return laguerre_l(n, ecplx.t(0), x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre/*' />
        public static ExtendedC laguerre(dynamic n, dynamic x)
        {
            return laguerre(ecplx.t(n), ecplx.t(x));
        }


        #endregion



        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static ExtendedC coulomb_f(ExtendedC l, ExtendedC eta, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static ExtendedC coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(ecplx.t(l), ecplx.t(eta), ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static ExtendedC coulomb_g(ExtendedC l, ExtendedC eta, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static ExtendedC coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(ecplx.t(l), ecplx.t(eta), ecplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static ExtendedC coulomb_hpos(ExtendedC l, ExtendedC eta, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CoulombHpos(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CoulombHpos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CoulombHpos(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static ExtendedC coulomb_hpos(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hpos(ecplx.t(l), ecplx.t(eta), ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static ExtendedC coulomb_hneg(ExtendedC l, ExtendedC eta, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_CoulombHneg(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_CoulombHneg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_CoulombHneg(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static ExtendedC coulomb_hneg(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hneg(ecplx.t(l), ecplx.t(eta), ecplx.t(x));
        }





        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static ExtendedC whittaker_m(ExtendedC k, ExtendedC m, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS3(aflintc.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static ExtendedC whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(ecplx.t(k), ecplx.t(m), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static ExtendedC whittaker_w(ExtendedC k, ExtendedC m, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS3(aflintc.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static ExtendedC whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(ecplx.t(k), ecplx.t(m), ecplx.t(x));
        }






        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static ExtendedC pcfd(ExtendedC n, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static ExtendedC pcfd(dynamic n, dynamic x)
        {
            return pcfd(ecplx.t(n), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static ExtendedC pcfu(ExtendedC a, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static ExtendedC pcfu(dynamic a, dynamic x)
        {
            return pcfu(ecplx.t(a), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static ExtendedC pcfv(ExtendedC a, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static ExtendedC pcfv(dynamic a, dynamic x)
        {
            return pcfv(ecplx.t(a), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static ExtendedC pcfw(ExtendedC a, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static ExtendedC pcfw(dynamic a, dynamic x)
        {
            return pcfw(ecplx.t(a), ecplx.t(x));
        }



        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static ExtendedC hyperg_2f1(ExtendedC a, ExtendedC b, ExtendedC c, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static ExtendedC hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(ecplx.t(a), ecplx.t(b), ecplx.t(c), ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static ExtendedC hyperg_2f1r(ExtendedC a, ExtendedC b, ExtendedC c, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static ExtendedC hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(ecplx.t(a), ecplx.t(b), ecplx.t(c), ecplx.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static ExtendedC chebyshev_t(ExtendedC n, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static ExtendedC chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(ecplx.t(n), ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static ExtendedC chebyshev_u(ExtendedC n, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static ExtendedC chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(ecplx.t(n), ecplx.t(x));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static ExtendedC chebyshev_v(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2(aflintc.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static ExtendedC chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(ecplx.t(n), ecplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static ExtendedC chebyshev_w(ExtendedC n, ExtendedC x, bool scaled = false)
        {
            return aflintc.ECplxViaArbCS2(aflintc.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static ExtendedC chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(ecplx.t(n), ecplx.t(y));
        }











        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static ExtendedC gegenbauer_c(ExtendedC n, ExtendedC m, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static ExtendedC gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(ecplx.t(n), ecplx.t(m), ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static ExtendedC jacobi_p(ExtendedC n, ExtendedC a, ExtendedC b, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static ExtendedC jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(ecplx.t(n), ecplx.t(a), ecplx.t(b), ecplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static ExtendedC legendre_p(ExtendedC n, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.legendre_p, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static ExtendedC legendre_p(dynamic n, dynamic x)
        {
            return legendre_p(ecplx.t(n), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static ExtendedC legendre_q(ExtendedC n, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.legendre_q, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static ExtendedC legendre_q(dynamic n, dynamic x)
        {
            return legendre_q(ecplx.t(n), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static ExtendedC legendre_plm(ExtendedC n, ExtendedC m, ExtendedC x, int type = 1)
        {
            return aflintc.ECplxViaArbCS3Int1(aflintc.legendre_plm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static ExtendedC legendre_plm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_plm(ecplx.t(n), ecplx.t(m), ecplx.t(x), type);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static ExtendedC legendre_qlm(ExtendedC n, ExtendedC m, ExtendedC x, int type = 1)
        {
            return aflintc.ECplxViaArbCS3Int1(aflintc.legendre_qlm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static ExtendedC legendre_qlm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_qlm(ecplx.t(n), ecplx.t(m), ecplx.t(x), type);
        }




        /////// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        ////public static ExtendedC legendre_p(ExtendedC n, ExtendedC m, ExtendedC x)
        ////{
        ////    var res = new ExtendedC();
        ////    Lib_XCplx_Acb_LegendreP(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        ////    return res;
        ////}
        ////[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        ////internal static extern int Lib_XCplx_Acb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /////// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        ////public static ExtendedC legendre_p(dynamic n, dynamic m, dynamic x)
        ////{
        ////    return legendre_p(ecplx.t(n), ecplx.t(m), ecplx.t(x));
        ////}




        /////// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        ////public static ExtendedC legendre_plm(ExtendedC n, ExtendedC m, ExtendedC x)
        ////{
        ////    var res = new ExtendedC();
        ////    Lib_XCplx_Acb_LegendrePv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        ////    return res;
        ////}
        ////[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        ////internal static extern int Lib_XCplx_Acb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /////// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        ////public static ExtendedC legendre_plm(dynamic n, dynamic m, dynamic x)
        ////{
        ////    return legendre_plm(ecplx.t(n), ecplx.t(m), ecplx.t(x));
        ////}



        /////// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        ////public static ExtendedC legendre_q(ExtendedC n, ExtendedC m, ExtendedC x)
        ////{
        ////    var res = new ExtendedC();
        ////    Lib_XCplx_Acb_LegendreQ(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        ////    return res;
        ////}
        ////[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        ////internal static extern int Lib_XCplx_Acb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /////// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        ////public static ExtendedC legendre_q(dynamic n, dynamic m, dynamic x)
        ////{
        ////    return legendre_q(ecplx.t(n), ecplx.t(m), ecplx.t(x));
        ////}



        /////// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        ////public static ExtendedC legendre_qlm(ExtendedC n, ExtendedC m, ExtendedC x)
        ////{
        ////    var res = new ExtendedC();
        ////    Lib_XCplx_Acb_LegendreQv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        ////    return res;
        ////}
        ////[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        ////internal static extern int Lib_XCplx_Acb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /////// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        ////public static ExtendedC legendre_qlm(dynamic n, dynamic m, dynamic x)
        ////{
        ////    return legendre_qlm(ecplx.t(n), ecplx.t(m), ecplx.t(x));
        ////}





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static ExtendedC spherical_y(ExtendedC n, ExtendedC m, ExtendedC theta, ExtendedC phi)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_SphericalY(res.mpPtr, n.mpPtr, m.mpPtr, theta.mpPtr, phi.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_SphericalY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_SphericalY(IntPtr res, IntPtr n, IntPtr m, IntPtr theta, IntPtr phi);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static ExtendedC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(ecplx.t(n), ecplx.t(m), ecplx.t(theta), ecplx.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static ExtendedC beta_lower(ExtendedC a, ExtendedC b, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static ExtendedC beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(ecplx.t(a), ecplx.t(b), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static ExtendedC ibeta(ExtendedC a, ExtendedC b, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static ExtendedC ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(ecplx.t(a), ecplx.t(b), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static ExtendedC ibetac(ExtendedC a, ExtendedC b, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static ExtendedC ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(ecplx.t(a), ecplx.t(b), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static ExtendedC ibeta_prime(ExtendedC a, ExtendedC b, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static ExtendedC ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(ecplx.t(a), ecplx.t(b), ecplx.t(x));
        }


        #endregion







        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static ExtendedC hyperg_1f2(ExtendedC a1, ExtendedC b1, ExtendedC b2, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static ExtendedC hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(ecplx.t(a1), ecplx.t(b1), ecplx.t(b2), ecplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static ExtendedC hyperg_1f2r(ExtendedC a1, ExtendedC b1, ExtendedC b2, ExtendedC x)
        {
            var res = new ExtendedC();
            Lib_XCplx_Acb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_XCplx_Acb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_XCplx_Acb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static ExtendedC hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(ecplx.t(a1), ecplx.t(b1), ecplx.t(b2), ecplx.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static ExtendedC airy_gi(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static ExtendedC airy_gi(dynamic x)
        {
            return airy_gi(ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static ExtendedC airy_hi(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static ExtendedC airy_hi(dynamic x)
        {
            return airy_hi(ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static ExtendedC airy_gi_prime(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static ExtendedC airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static ExtendedC airy_hi_prime(ExtendedC x)
        {
            return aflintc.ECplxViaArbCS1(aflintc.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static ExtendedC airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(ecplx.t(x));
        }




        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static ExtendedC struve_h(ExtendedC v, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static ExtendedC struve_h(dynamic v, dynamic x)
        {
            return struve_h(ecplx.t(v), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static ExtendedC struve_l(ExtendedC v, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static ExtendedC struve_l(dynamic v, dynamic x)
        {
            return struve_l(ecplx.t(v), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static ExtendedC struve_k(ExtendedC v, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static ExtendedC struve_k(dynamic v, dynamic x)
        {
            return struve_k(ecplx.t(v), ecplx.t(x));
        }


        public static ExtendedC struve_m(ExtendedC v, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static ExtendedC struve_m(dynamic v, dynamic x)
        {
            return struve_m(ecplx.t(v), ecplx.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static ExtendedC anger_j(ExtendedC v, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static ExtendedC anger_j(dynamic v, dynamic x)
        {
            return anger_j(ecplx.t(v), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static ExtendedC weber_e(ExtendedC v, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS2(aflintc.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static ExtendedC weber_e(dynamic v, dynamic x)
        {
            return weber_e(ecplx.t(v), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static ExtendedC lommel_s1(ExtendedC mu, ExtendedC nu, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS3(aflintc.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static ExtendedC lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(ecplx.t(mu), ecplx.t(nu), ecplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static ExtendedC lommel_s2(ExtendedC mu, ExtendedC nu, ExtendedC x)
        {
            return aflintc.ECplxViaArbCS3(aflintc.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static ExtendedC lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(ecplx.t(mu), ecplx.t(nu), ecplx.t(x));
        }


        #endregion






        #endregion


    }







}