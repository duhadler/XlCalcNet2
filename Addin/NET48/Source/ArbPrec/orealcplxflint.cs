using System;
using System.Runtime.InteropServices;
using System.Numerics;
using FixedPrecNet;

namespace ArbPrecNet
{




    public class oflint
    {


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Octuple t(Arb x)
        {
            var res = new Octuple();
            Lib_OReal_Set_Arb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Set_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Set_Arb(IntPtr res, IntPtr x);


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Octuple t(Mpfr x)
        {
            var res = new Octuple();
            Lib_OReal_Set_Mpfr(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Set_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Set_Mpfr(IntPtr res, IntPtr x);






        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "oflint"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return " oflint"; }
        }


        public static String fmt(Octuple x)
        {
            return oreal.fmt(x);
        }


        public static String fmt(dynamic x)
        {
            return fmt(oreal.t(x));
        }




        #region Basic floating point functions




        #region General functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Octuple fma(Octuple x, Octuple y, Octuple z)
        {
            return oreal.fma(x, y, z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Octuple fma(dynamic x, dynamic y, dynamic z)
        {
            return oreal.fma(x, y, z);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Octuple fmax(Octuple x, Octuple y)
        {
            return oreal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Octuple fmax(dynamic x, dynamic y)
        {
            return oreal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Octuple fmin(Octuple x, Octuple y)
        {
            return oreal.fmin(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Octuple fmin(dynamic x, dynamic y)
        {
            return oreal.fmin(x, y);
        }


        #endregion



        #region Machine constants


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static Octuple zero()
        {
            return oreal.zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/negzero/*' />
        public static Octuple negzero()
        {
            return oreal.negzero();
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static Octuple one()
        {
            return oreal.one();
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static OctupleC onej()
        {
            return oreal.onej();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static Octuple inf()
        {
            return oreal.inf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/neginf/*' />
        public static Octuple neginf()
        {
            return oreal.neginf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static Octuple nan()
        {
            return oreal.nan();
        }



        #endregion



        #region Properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(Octuple x)
        {
            return oreal.signbit(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(dynamic x)
        {
            return oreal.signbit(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(Octuple x)
        {
            return oreal.isfinite(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isfinite/*' />
        public static bool isfinite(dynamic x)
        {
            return oreal.isfinite(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(Octuple x)
        {
            return oreal.isinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinf/*' />
        public static bool isinf(dynamic x)
        {
            return oreal.isinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static bool isposinf(Octuple x)
        {
            return oreal.isposinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isposinf/*' />
        public static bool isposinf(dynamic x)
        {
            return oreal.isposinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isneginf/*' />
        public static bool isneginf(Octuple x)
        {
            return oreal.isneginf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isneginf/*' />
        public static bool isneginf(dynamic x)
        {
            return oreal.isneginf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(Octuple x)
        {
            return oreal.isnan(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnan/*' />
        public static bool isnan(dynamic x)
        {
            return oreal.isnan(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(Octuple x)
        {
            return oreal.iszero(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/iszero/*' />
        public static bool iszero(dynamic x)
        {
            return oreal.iszero(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(Octuple x)
        {
            return oreal.isone(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isone/*' />
        public static bool isone(dynamic x)
        {
            return oreal.isone(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinteger/*' />
        public static bool isinteger(Octuple x)
        {
            return oreal.isinteger(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinteger/*' />
        public static bool isinteger(dynamic x)
        {
            return oreal.isinteger(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnumber/*' />
        public static bool isnumber(Octuple x)
        {
            return oreal.isnumber(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnumber/*' />
        public static bool isnumber(dynamic x)
        {
            return oreal.isnumber(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isregular/*' />
        public static bool isregular(Octuple x)
        {
            return oreal.isregular(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isregular/*' />
        public static bool isregular(dynamic x)
        {
            return oreal.isregular(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnormal/*' />
        public static bool isnormal(Octuple x)
        {
            return oreal.isnormal(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnormal/*' />
        public static bool isnormal(dynamic x)
        {
            return oreal.isnormal(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isunordered/*' />
        public static bool isunordered(Octuple x, Octuple y)
        {
            return oreal.isunordered(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isunordered/*' />
        public static bool isunordered(dynamic x, dynamic y)
        {
            return oreal.isunordered(x, y);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint32/*' />
        public static bool fitsint32(Octuple x)
        {
            return oreal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint32/*' />
        public static bool fitsint32(dynamic x)
        {
            return oreal.fitsint32(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint64/*' />
        public static bool fitsint64(Octuple x)
        {
            return oreal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint64/*' />
        public static bool fitsint64(dynamic x)
        {
            return oreal.fitsint32(x);
        }





        #endregion



        #region Integer Related Functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Octuple nearbyint(Octuple x)
        {
            return oreal.nearbyint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Octuple nearbyint(dynamic x)
        {
            return oreal.nearbyint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Octuple rint(Octuple x)
        {
            return oreal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Octuple rint(dynamic x)
        {
            return oreal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(Octuple x)
        {
            return oreal.lrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(dynamic x)
        {
            return oreal.lrint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(Octuple x)
        {
            return oreal.llrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(dynamic x)
        {
            return oreal.llrint(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Octuple ceil(Octuple x)
        {
            return oreal.ceil(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Octuple ceil(dynamic x)
        {
            return oreal.ceil(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Octuple floor(Octuple x)
        {
            return oreal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Octuple floor(dynamic x)
        {
            return oreal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Octuple trunc(Octuple x)
        {
            return oreal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Octuple trunc(dynamic x)
        {
            return oreal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Octuple round(Octuple x)
        {
            return oreal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Octuple round(dynamic x)
        {
            return oreal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(Octuple x)
        {
            return oreal.lround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(dynamic x)
        {
            return oreal.lround(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(Octuple x)
        {
            return oreal.llround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(dynamic x)
        {
            return oreal.llround(x);
        }




        #endregion



        #region Floating point functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Octuple copysign(Octuple x, Octuple y)
        {
            return oreal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Octuple copysign(dynamic x, dynamic y)
        {
            return oreal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Octuple, Int32> frexp(Octuple x)
        {
            return oreal.frexp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Octuple, Int32> frexp(dynamic x)
        {
            return oreal.frexp(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Octuple logb(Octuple x)
        {
            return oreal.logb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Octuple logb(dynamic x)
        {
            return oreal.logb(x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(Octuple x)
        {
            return oreal.ilogb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(dynamic x)
        {
            return oreal.ilogb(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Octuple ldexp(Octuple x, Int32 e)
        {
            return oreal.ldexp(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Octuple ldexp(dynamic x, dynamic e)
        {
            return oreal.ldexp(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Octuple scalbn(Octuple x, Int32 e)
        {
            return oreal.scalbn(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Octuple scalbn(dynamic x, dynamic e)
        {
            return oreal.scalbn(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Octuple scalbln(Octuple x, Int32 e)
        {
            return oreal.scalbln(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Octuple scalbln(dynamic x, dynamic e)
        {
            return oreal.scalbln(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Octuple fdim(Octuple x, Octuple y)
        {
            return oreal.fdim(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Octuple fdim(dynamic x, dynamic y)
        {
            return oreal.fdim(x, y);
        }


        #endregion



        #region Fraction and remainder Related Functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Octuple, Octuple> modf(Octuple x)
        {
            return oreal.modf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Octuple, Octuple> modf(dynamic x)
        {
            return oreal.modf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Octuple fmod(Octuple x, Octuple y)
        {
            return oreal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Octuple fmod(dynamic x, dynamic y)
        {
            return oreal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Octuple remainder(Octuple x, Octuple y)
        {
            return oreal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Octuple remainder(dynamic x, dynamic y)
        {
            return oreal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Octuple, Int32> remquo(Octuple x, Octuple y)
        {
            return oreal.remquo(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Octuple, Int32> remquo(dynamic x, dynamic y)
        {
            return oreal.remquo(x, y);
        }

        #endregion



        #region Functions related to mantissa width and exponent range


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/epsilon/*' />
        public static Octuple epsilon()
        {
            return oreal.epsilon();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Octuple ulp(Octuple x)
        {
            return oreal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Octuple ulp(dynamic x)
        {
            return oreal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/maxvalue/*' />
        public static Octuple maxvalue()
        {
            return oreal.maxvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/lowestvalue/*' />
        public static Octuple lowestvalue()
        {
            return oreal.lowestvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/minposvalue/*' />
        public static Octuple minposvalue()
        {
            return oreal.minposvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Octuple nextafter(Octuple x, Octuple y)
        {
            return oreal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Octuple nextafter(dynamic x, dynamic y)
        {
            return oreal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Octuple nextabove(Octuple x)
        {
            return oreal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Octuple nextabove(dynamic x)
        {
            return oreal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Octuple nextbelow(Octuple x)
        {
            return oreal.nextbelow(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Octuple nextbelow(dynamic x)
        {
            return oreal.nextbelow(x);
        }


        #endregion



        #region Mathematical Constants


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/degree/*' />
        public static Octuple degree()
        {
            return oreal.degree();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phi/*' />
        public static Octuple phi()
        {
            return oreal.phi();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln2/*' />
        public static Octuple ln2()
        {
            return oreal.ln2();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln10/*' />
        public static Octuple ln10()
        {
            return oreal.ln10();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pi/*' />
        public static Octuple pi()
        {
            return oreal.pi();
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/e/*' />
        public static Octuple e()
        {
            return oreal.e();
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/egamma/*' />
        public static Octuple egamma()
        {
            return oreal.egamma();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/apery/*' />
        public static Octuple apery()
        {
            return oreal.apery();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/catalan/*' />
        public static Octuple catalan()
        {
            return oreal.catalan();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/glaisher/*' />
        public static Octuple glaisher()
        {
            return oreal.glaisher();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/khinchin/*' />
        public static Octuple khinchin()
        {
            return oreal.khinchin();
        }


        #endregion




        #endregion






        #region Flint Basic Functions




        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Octuple abs(Octuple x)
        {
            return oreal.abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Octuple abs(dynamic x)
        {
            return abs(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Octuple fabs(Octuple x)
        {
            return oreal.fabs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Octuple fabs(dynamic x)
        {
            return fabs(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Octuple sign(Octuple x)
        {
            return oreal.sign(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Octuple sign(dynamic x)
        {
            return sign(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Octuple real(Octuple x)
        {
            return x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Octuple real(dynamic x)
        {
            return real(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Octuple imag(Octuple x)
        {
            return oreal.zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Octuple imag(dynamic x)
        {
            return imag(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Octuple phase(Octuple x)
        {
            return oreal.phase(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Octuple phase(dynamic x)
        {
            return oreal.phase(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Octuple conj(Octuple x)
        {
            return x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Octuple conj(dynamic x)
        {
            return conj(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Octuple, Octuple> polar(Octuple x)
        {
            return new Tuple<Octuple, Octuple>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Octuple, Octuple> polar(dynamic x)
        {
            return polar(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static OctupleC rect(Octuple r, Octuple phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static OctupleC rect(dynamic r, dynamic phi)
        {
            return rect(oreal.t(r), oreal.t(phi));
        }






        #endregion





        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Octuple sqrt(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Octuple sqrt(dynamic x)
        {
            return sqrt(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Octuple rsqrt(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Octuple rsqrt(dynamic x)
        {
            return rsqrt(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Octuple cbrt(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Octuple cbrt(dynamic x)
        {
            return cbrt(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Octuple sqrt1pm1(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Octuple sqrt1pm1(dynamic x)
        {
            return sqrt1pm1(oreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nthroot/*' />
        public static Octuple root_si(Octuple x, Int32 n)
        {
            if (isinf(x)) { return inf(); }
            if (isnan(x)) { return nan(); }
            var res = new Octuple();
            Lib_OReal_Arb_Root_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Octuple root_si(dynamic x, Int32 n)
        {
            return root_si(oreal.t(x), n);
        }



        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Octuple exp(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Octuple exp(dynamic x)
        {
            return exp(oreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static OctupleC expj(Octuple x)
        {
            return oflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static OctupleC expj(dynamic x)
        {
            return oflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static OctupleC expjpi(Octuple x)
        {
            return oflintc.expjpi(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static OctupleC expjpi(dynamic x)
        {
            return oflintc.expjpi(x);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Octuple exp10(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Octuple exp10(dynamic x)
        {
            return exp10(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Octuple exp2(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Octuple exp2(dynamic x)
        {
            return exp2(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Octuple expm1(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Octuple expm1(dynamic x)
        {
            return expm1(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Octuple exp10m1(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Octuple exp10m1(dynamic x)
        {
            return exp10m1(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Octuple exp2m1(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Octuple exp2m1(dynamic x)
        {
            return exp2m1(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Octuple exprel(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Octuple exprel(dynamic x)
        {
            return exprel(oreal.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Octuple logbase(Octuple x, Octuple b)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Octuple logbase(dynamic x, dynamic b)
        {
            return logbase(oreal.t(x), oreal.t(b));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Octuple log(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Octuple log(dynamic x)
        {
            return log(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Octuple log10(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Octuple log10(dynamic x)
        {
            return log10(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Octuple log2(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Octuple log2(dynamic x)
        {
            return log2(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Octuple log1p(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Octuple log1p(dynamic x)
        {
            return log1p(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Octuple log10p1(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Octuple log10p1(dynamic x)
        {
            return log10p1(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Octuple log2p1(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Octuple log2p1(dynamic x)
        {
            return log2p1(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Octuple log1mexp(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Log1mexp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Log1mexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Log1mexp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Octuple log1mexp(dynamic x)
        {
            return log1mexp(oreal.t(x));
        }





        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Octuple sqr(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Octuple sqr(dynamic x)
        {
            return sqr(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Octuple cube(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Octuple cube(dynamic x)
        {
            return cube(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Octuple hypot(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Octuple hypot(dynamic x, dynamic y)
        {
            return hypot(oreal.t(x), oreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powi/*' />
        public static Octuple pow_si(Octuple x, Int32 n)
        {
            if (isinf(x)) { return inf(); }
            if (isnan(x)) { return nan(); }
            var res = new Octuple();
            Lib_OReal_Arb_Pow_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Pow_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Octuple pow_si(dynamic x, Int32 n)
        {
            return pow_si(oreal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Octuple compound_si(Octuple x, Int32 n)
        {
            if (isinf(x)) { return inf(); }
            if (isnan(x)) { return nan(); }
            var res = new Octuple();
            Lib_OReal_Arb_Compound_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Compound_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Compound_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Octuple compound_si(dynamic x, Int32 n)
        {
            return compound_si(oreal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Octuple pow(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Octuple pow(dynamic x, dynamic y)
        {
            return pow(oreal.t(x), oreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Octuple powm1(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Octuple powm1(dynamic x, dynamic y)
        {
            return powm1(oreal.t(x), oreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Octuple pow1p(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Octuple pow1p(dynamic x, dynamic y)
        {
            return pow1p(oreal.t(x), oreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Octuple pow1pm1(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Octuple pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(oreal.t(x), oreal.t(y));
        }




        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Octuple sin(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Octuple sin(dynamic x)
        {
            return sin(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Octuple cos(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Octuple cos(dynamic x)
        {
            return cos(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Octuple tan(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Octuple tan(dynamic x)
        {
            return tan(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Octuple cot(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Octuple cot(dynamic x)
        {
            return cot(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Octuple sec(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Octuple sec(dynamic x)
        {
            return sec(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Octuple csc(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Octuple csc(dynamic x)
        {
            return csc(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Octuple sinc(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Octuple sinc(dynamic x)
        {
            return sinc(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Octuple sinpi(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Octuple sinpi(dynamic x)
        {
            return sinpi(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Octuple cospi(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Octuple cospi(dynamic x)
        {
            return cospi(oreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Octuple tanpi(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Octuple tanpi(dynamic x)
        {
            return tanpi(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Octuple cotpi(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Octuple cotpi(dynamic x)
        {
            return cotpi(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Octuple cscpi(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_SinPi(res.mpPtr, x.mpPtr);
            return 1/res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Octuple cscpi(dynamic x)
        {
            return cscpi(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Octuple secpi(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_CosPi(res.mpPtr, x.mpPtr);
            return 1/res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Octuple secpi(dynamic x)
        {
            return secpi(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Octuple sincpi(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Octuple sincpi(dynamic x)
        {
            return sincpi(oreal.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Octuple sinh(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Octuple sinh(dynamic x)
        {
            return sinh(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Octuple cosh(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Octuple cosh(dynamic x)
        {
            return cosh(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Octuple tanh(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Octuple tanh(dynamic x)
        {
            return tanh(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Octuple csch(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Octuple csch(dynamic x)
        {
            return csch(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Octuple sech(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Octuple sech(dynamic x)
        {
            return sech(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Octuple coth(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Octuple coth(dynamic x)
        {
            return coth(oreal.t(x));
        }




        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Octuple asin(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Octuple asin(dynamic x)
        {
            return asin(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Octuple acos(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Octuple acos(dynamic x)
        {
            return acos(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Octuple atan2(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Atan2(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Atan2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Atan2(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Octuple atan2(dynamic x, dynamic y)
        {
            return atan2(oreal.t(x), oreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Octuple atan(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Octuple atan(dynamic x)
        {
            return atan(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Octuple acsc(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Octuple acsc(dynamic x)
        {
            return acsc(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Octuple asec(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Octuple asec(dynamic x)
        {
            return asec(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Octuple acot(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Octuple acot(dynamic x)
        {
            return acot(oreal.t(x));
        }



        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Octuple asinh(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Octuple asinh(dynamic x)
        {
            return asinh(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Octuple acosh(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Octuple acosh(dynamic x)
        {
            return acosh(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Octuple atanh(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Octuple atanh(dynamic x)
        {
            return atanh(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Octuple acsch(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Octuple acsch(dynamic x)
        {
            return acsch(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Octuple asech(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Octuple asech(dynamic x)
        {
            return asech(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Octuple acoth(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Octuple acoth(dynamic x)
        {
            return acoth(oreal.t(x));
        }



        #endregion



        #region Gamma and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Octuple gamma(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Octuple gamma(dynamic x)
        {
            return gamma(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Octuple rgamma(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Octuple rgamma(dynamic x)
        {
            return rgamma(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Octuple lgamma(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Octuple lgamma(dynamic x)
        {
            return lgamma(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Octuple rising_factorial(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Octuple rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(oreal.t(x), oreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Octuple beta(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Octuple beta(dynamic x, dynamic y)
        {
            return beta(oreal.t(x), oreal.t(y));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Octuple gamma1pm1(Octuple x)
        {
            return aflint.ORealViaArbS1(aflint.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Octuple gamma1pm1(dynamic x)
        {
            return gamma1pm1(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Octuple factorial(Octuple x)
        {
            return aflint.ORealViaArbS1(aflint.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Octuple factorial(dynamic x)
        {
            return factorial(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Octuple doublefactorial(Octuple x)
        {
            return aflint.ORealViaArbS1(aflint.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Octuple doublefactorial(dynamic x)
        {
            return doublefactorial(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Octuple falling_factorial(Octuple a, Octuple n)
        {
            return aflint.ORealViaArbS2(aflint.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Octuple falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(oreal.t(a), oreal.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Octuple gamma_ratio(Octuple a, Octuple b)
        {
            return aflint.ORealViaArbS2(aflint.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Octuple gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(oreal.t(a), oreal.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Octuple gamma_delta_ratio(Octuple a, Octuple delta)
        {
            return aflint.ORealViaArbS2(aflint.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Octuple gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(oreal.t(a), oreal.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Octuple binomial(Octuple n, Octuple k)
        {
            return aflint.ORealViaArbS2(aflint.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Octuple binomial(dynamic n, dynamic k)
        {
            return binomial(oreal.t(n), oreal.t(k));
        }





        #endregion



        #region Miscellaneous


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Octuple lambert_w0(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_LambertW0(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_LambertW0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_LambertW0(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Octuple lambert_w0(dynamic x)
        {
            return lambert_w0(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Octuple lambert_wm1(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_LambertWm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_LambertWm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_LambertWm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Octuple lambert_wm1(dynamic x)
        {
            return lambert_wm1(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static OctupleC lambert_wk(Octuple x, int k)
        {
            return oflintc.lambert_wk(ocplx.t(x), k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static OctupleC lambert_wk(dynamic x, int k)
        {
            return lambert_wk(oreal.t(x), k);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Octuple agm(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Agm(IntPtr res, IntPtr x, IntPtr y);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        //public static ORealMatT agm(ORealMatT x, ORealMatT y)
        //{
        //    return oreal.ORealMatTFunc2(agm, x, y);
        //}

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Octuple agm(dynamic x, dynamic y)
        {
            return agm(oreal.t(x), oreal.t(y));
        }






        #endregion






        #endregion





        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Octuple m_elliptic_k(Octuple m)
        {
            var res = new Octuple();
            Lib_OReal_Arb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_MEllipticK(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Octuple m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Octuple m_elliptic_e(Octuple m)
        {
            var res = new Octuple();
            Lib_OReal_Arb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_MEllipticE(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Octuple m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Octuple m_elliptic_pi(Octuple n, Octuple m)
        {
            var res = new Octuple();
            Lib_OReal_Arb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Octuple m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(oreal.t(x), oreal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Octuple m_elliptic_f(Octuple phi, Octuple m)
        {
            var res = new Octuple();
            Lib_OReal_Arb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Octuple m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(oreal.t(phi), oreal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Octuple m_elliptic_e_inc(Octuple phi, Octuple m)
        {
            var res = new Octuple();
            Lib_OReal_Arb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Octuple m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(oreal.t(phi), oreal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Octuple m_elliptic_pi_inc(Octuple n, Octuple phi, Octuple m)
        {
            var res = new Octuple();
            Lib_OReal_Arb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Octuple m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(oreal.t(n), oreal.t(phi), oreal.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Octuple elliptic_k(Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_EllipticK(IntPtr res, IntPtr k);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        //public static ORealMatT elliptic_k(ORealMatT k)
        //{
        //    return oreal.ORealMatTFunc(elliptic_k, k);
        //}

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Octuple elliptic_k(dynamic k)
        {
            return elliptic_k(oreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Octuple elliptic_e(Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_EllipticE(IntPtr res, IntPtr k);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        //public static ORealMatT elliptic_e(ORealMatT k)
        //{
        //    return oreal.ORealMatTFunc(elliptic_e, k);
        //}

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Octuple elliptic_e(dynamic k)
        {
            return elliptic_e(oreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Octuple elliptic_pi(Octuple n, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        //public static ORealMatT elliptic_pi(ORealMatT n, ORealMatT k)
        //{
        //    return oreal.ORealMatTFunc2(elliptic_pi, n, k);
        //}

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Octuple elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(oreal.t(n), oreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Octuple elliptic_f(Octuple phi, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        //public static ORealMatT elliptic_f(ORealMatT phi, ORealMatT k)
        //{
        //    return oreal.ORealMatTFunc2(elliptic_f, phi, k);
        //}

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Octuple elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(oreal.t(phi), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Octuple elliptic_e_inc(Octuple phi, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);

        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        //public static ORealMatT elliptic_e_inc(ORealMatT phi, ORealMatT k)
        //{
        //    return oreal.ORealMatTFunc2(elliptic_e_inc, phi, k);
        //}

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Octuple elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(oreal.t(phi), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Octuple elliptic_pi_inc(Octuple n, Octuple phi, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Octuple elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(oreal.t(n), oreal.t(phi), oreal.t(k));
        }




        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Octuple elliptic_rc(Octuple x, Octuple y)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Octuple elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(oreal.t(x), oreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Octuple elliptic_rf(Octuple x, Octuple y, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Octuple elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(oreal.t(x), oreal.t(y), oreal.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Octuple elliptic_rg(Octuple x, Octuple y, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Octuple elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(oreal.t(x), oreal.t(y), oreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Octuple elliptic_rd(Octuple x, Octuple y, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Octuple elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(oreal.t(x), oreal.t(y), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Octuple elliptic_rj(Octuple x, Octuple y, Octuple z, Octuple w)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Octuple elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(oreal.t(x), oreal.t(y), oreal.t(z), oreal.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Octuple jacobi_theta1(Octuple x, Octuple q)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Octuple jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(oreal.t(x), oreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Octuple jacobi_theta2(Octuple x, Octuple q)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Octuple jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(oreal.t(x), oreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Octuple jacobi_theta3(Octuple x, Octuple q)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Octuple jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(oreal.t(x), oreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Octuple jacobi_theta4(Octuple x, Octuple q)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Octuple jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(oreal.t(x), oreal.t(q));
        }




        #endregion



        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Octuple jacobi_sn(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Octuple jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Octuple jacobi_cn(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Octuple jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Octuple jacobi_dn(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Octuple jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Octuple jacobi_ns(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Octuple jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Octuple jacobi_nc(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Octuple jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Octuple jacobi_nd(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Octuple jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Octuple jacobi_sc(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Octuple jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Octuple jacobi_sd(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Octuple jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Octuple jacobi_dc(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Octuple jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Octuple jacobi_ds(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Octuple jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Octuple jacobi_cs(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Octuple jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(oreal.t(x), oreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Octuple jacobi_cd(Octuple x, Octuple k)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OReal_Arb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Octuple jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(oreal.t(x), oreal.t(k));
        }








        #endregion



        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Octuple lerch_phi(Octuple s, Octuple z, Octuple a)
        {
            var res = new Octuple();
            Lib_OReal_Arb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Octuple lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(oreal.t(s), oreal.t(z), oreal.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static OctupleC lerch_zeta(Octuple lambda1, Octuple alpha, Octuple s)
        {
            var res = oflintc.lerch_zeta(lambda1, alpha, s);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static OctupleC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(oreal.t(lambda1), oreal.t(alpha), oreal.t(s));
        }






        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Octuple polygamma(Octuple s, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Octuple polygamma(dynamic s, dynamic z)
        {
            return polygamma(oreal.t(s), oreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Octuple trigamma(Octuple x)
        {
            return polygamma(1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Octuple trigamma(dynamic x)
        {
            return trigamma(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Octuple digamma(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Octuple digamma(dynamic x)
        {
            return digamma(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Octuple harmonic(Octuple x)
        {
            OctupleC res = oflintc.harmonic(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Octuple harmonic(dynamic x)
        {
            return harmonic(oreal.t(x));
        }




        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Octuple polylog(Octuple s, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Octuple polylog(dynamic s, dynamic z)
        {
            return polylog(oreal.t(s), oreal.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Octuple trilog(Octuple x)
        {
            OctupleC res = oflintc.trilog(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Octuple trilog(dynamic x)
        {
            return trilog(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Octuple dilog(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Octuple dilog(dynamic x)
        {
            return dilog(oreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Octuple clausen_sin(Octuple s, Octuple z)
        {
            OctupleC res = oflintc.clausen_sin(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Octuple clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Octuple clausen_cos(Octuple s, Octuple z)
        {
            OctupleC res = oflintc.clausen_cos(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Octuple clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Octuple clausen2(Octuple x)
        {
            return clausen_sin(oreal.t(2), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Octuple clausen2(dynamic x)
        {
            return clausen_sin(oreal.t(2), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Octuple bose_einstein(Octuple s, Octuple z)
        {
            OctupleC res = oflintc.bose_einstein(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Octuple bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Octuple fermi_dirac(Octuple s, Octuple z)
        {
            OctupleC res = oflintc.fermi_dirac(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Octuple fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Octuple legendre_chi(Octuple s, Octuple z)
        {
            OctupleC res = oflintc.legendre_chi(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Octuple legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Octuple inverse_tan_integral(Octuple s, Octuple z)
        {
            OctupleC res = oflintc.inverse_tan_integral(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Octuple inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(oreal.t(s), oreal.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Octuple hurwitz_zeta(Octuple s, Octuple a)
        {
            var res = new Octuple();
            Lib_OReal_Arb_HurwitzZeta(res.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Octuple hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(oreal.t(s), oreal.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Octuple harmonic2(Octuple z, Octuple r)
        {
            OctupleC res = oflintc.harmonic2(z, r);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Octuple harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(oreal.t(z), oreal.t(r));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Octuple bernoulli(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Bernoulli_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Bernoulli_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Bernoulli_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Octuple bernpoly(Octuple x, Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Octuple bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(oreal.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulernum/*' />
        public static Octuple eulernum(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Euler_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Euler_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Euler_ui(IntPtr res, Int32 n);






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Octuple eulerpoly(Octuple x, Int32 n)
        {
            OctupleC res = oflintc.eulerpoly(x, n);
            return res.real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Octuple eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(oreal.t(x), n);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Octuple barnes_g(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Octuple barnes_g(dynamic x)
        {
            return barnes_g(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Octuple logbarnes_g(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Octuple logbarnes_g(dynamic x)
        {
            return logbarnes_g(oreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Octuple hyperfactorial(Octuple x)
        {
            OctupleC res = oflintc.hyperfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Octuple hyperfactorial(dynamic x)
        {
            return hyperfactorial(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Octuple superfactorial(Octuple x)
        {
            OctupleC res = oflintc.superfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Octuple superfactorial(dynamic x)
        {
            return superfactorial(oreal.t(x));
        }






        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Octuple zeta(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Octuple zeta(dynamic x)
        {
            return zeta(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Octuple zetam1(Octuple x)
        {
            OctupleC res = oflintc.zetam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Octuple zetam1(dynamic x)
        {
            return zetam1(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Octuple hardy_theta(Octuple x)
        {
            OctupleC res = oflintc.hardy_theta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Octuple hardy_theta(dynamic x)
        {
            return hardy_theta(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Octuple hardy_z(Octuple x)
        {
            OctupleC res = oflintc.hardy_z(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Octuple hardy_z(dynamic x)
        {
            return hardy_z(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Octuple riemann_xi(Octuple x)
        {
            OctupleC res = oflintc.riemann_xi(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Octuple riemann_xi(dynamic x)
        {
            return riemann_xi(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Octuple dirichlet_eta(Octuple x)
        {
            OctupleC res = oflintc.dirichlet_eta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Octuple dirichlet_eta(dynamic x)
        {
            return dirichlet_eta(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Octuple dirichlet_etam1(Octuple x)
        {
            OctupleC res = oflintc.dirichlet_etam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Octuple dirichlet_etam1(dynamic x)
        {
            return dirichlet_etam1(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Octuple dirichlet_beta(Octuple x)
        {
            OctupleC res = oflintc.dirichlet_beta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Octuple dirichlet_beta(dynamic x)
        {
            return dirichlet_beta(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Octuple dirichlet_lambda(Octuple x)
        {
            OctupleC res = oflintc.dirichlet_lambda(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Octuple dirichlet_lambda(dynamic x)
        {
            return dirichlet_lambda(oreal.t(x));
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Octuple backlund_s(Octuple x)
        //{
        //    var res = new Octuple();
        //    Lib_OReal_Arb_BacklundS(res.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_BacklundS", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OReal_Arb_BacklundS(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Octuple backlund_s(dynamic x)
        //{
        //    return zeta(oreal.t(x));
        //}





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/grampoint/*' />
        //public static Octuple grampoint(Int32 n)
        //{
        //    var res = new Octuple();
        //    Lib_OReal_Arb_GramPoint_ui(res.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_GramPoint_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OReal_Arb_GramPoint_ui(IntPtr res, Int32 n);







        #endregion



        #region Additional numbertheoretic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bell/*' />
        public static Octuple bell(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Bell_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Bell_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Bell_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/partitions/*' />
        public static Octuple partitions(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Partitions_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Partitions_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Partitions_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/primorial/*' />
        public static Octuple primorial(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Primorial_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Primorial_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Primorial_ui(IntPtr res, Int32 n);





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Octuple hyperg_0f1(Octuple a, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Octuple hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(oreal.t(a), oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Octuple hyperg_0f1r(Octuple a, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Octuple hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(oreal.t(a), oreal.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Octuple bessel_jv(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Octuple bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(oreal.t(nu), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Octuple bessel_yv(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Octuple bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(oreal.t(nu), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Octuple bessel_iv(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Octuple bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(oreal.t(nu), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Octuple bessel_kv(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Octuple bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(oreal.t(nu), oreal.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Octuple bessel_jv_prime(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Octuple bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(oreal.t(nu), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Octuple bessel_yv_prime(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Octuple bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(oreal.t(nu), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Octuple bessel_iv_prime(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Octuple bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(oreal.t(nu), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Octuple bessel_kv_prime(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Octuple bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(oreal.t(nu), oreal.t(x), scaled);
        }







        #endregion







        #region 0F1: Spherical Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Octuple sph_bessel_jn(Octuple n, Octuple x, bool scaled = false)
        {
            if (!oreal.isinteger(n)) return oreal.nan();

            if (oreal.isnan(x)) return oreal.nan();
            if (oreal.isinf(x)) return oreal.zero();
            if (oreal.isneginf(x)) return oreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return oreal.one();
                    else return oreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return oreal.neginf(); else return oreal.nan();
                }
            }
            return oflintc.sph_bessel_jn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Octuple sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(oreal.t(n), oreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Octuple sph_bessel_yn(Octuple n, Octuple x, bool scaled = false)
        {
            if (!oreal.isinteger(n)) return oreal.nan();

            if (oreal.isnan(x)) return oreal.nan();
            if (oreal.isinf(x)) return oreal.zero();
            if (oreal.isneginf(x)) return oreal.zero();
            if (x == 0.0)
            {
                if (n < 0)
                {
                    if ((n == -1)) return oreal.one();
                    else return oreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 != 0) return oreal.neginf(); else return oreal.nan();
                }
            }
            return oflintc.sph_bessel_yn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Octuple sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(oreal.t(n), oreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Octuple sph_bessel_in(Octuple n, Octuple x, bool scaled = false)
        {
            if (!oreal.isinteger(n)) return oreal.nan();

            if (oreal.isnan(x)) return oreal.nan();
            if (oreal.isinf(x)) return oreal.inf();
            if (oreal.isneginf(x)) return oreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return oreal.one();
                    else return oreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return oreal.neginf(); else return oreal.nan();
                }
            }
            return oflintc.sph_bessel_in(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Octuple sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(oreal.t(n), oreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Octuple sph_bessel_kn(Octuple n, Octuple x, bool scaled = false)
        {
            if (!oreal.isinteger(n)) return oreal.nan();

            if (oreal.isnan(x)) return oreal.nan();
            if (oreal.isinf(x)) return oreal.zero();
            if (oreal.isneginf(x)) return oreal.neginf();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if (lrint(n) % 2 == 0) return oreal.nan(); else return oreal.inf();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return oreal.inf(); else return oreal.nan();
                }
            }
            return oflintc.sph_bessel_kn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Octuple sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(oreal.t(n), oreal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Octuple besselpoly(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.besselpoly, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Octuple besselpoly(dynamic nu, dynamic x, bool scaled = false)
        {
            return besselpoly(oreal.t(nu), oreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Octuple besseltheta(Octuple nu, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2Bool1(aflint.besseltheta, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Octuple besseltheta(dynamic nu, dynamic x, bool scaled = false)
        {
            return besseltheta(oreal.t(nu), oreal.t(x), scaled);
        }







        #endregion





        #region Spherical Bessel functions, first derivative




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Octuple sph_bessel_jn_prime(Octuple n, Octuple x, bool scaled = false)
        {
            if (!oreal.isinteger(n)) return oreal.nan();

            if (oreal.isnan(x)) return oreal.nan();
            if (oreal.isinf(x)) return oreal.zero();
            if (oreal.isneginf(x)) return oreal.zero();
            if (x == 0.0)
            {
                if (n == 1) return 1 / oreal.t(3);
                if (n >= 0) return oreal.zero();
                else
                {
                    if (lrint(n) % 2 != 0) return oreal.neginf(); else return oreal.nan();
                }
            }
            return oflintc.sph_bessel_jn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Octuple sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(oreal.t(n), oreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Octuple sph_bessel_yn_prime(Octuple n, Octuple x, bool scaled = false)
        {
            if (!oreal.isinteger(n)) return oreal.nan();

            if (oreal.isnan(x)) return oreal.nan();
            if (oreal.isinf(x)) return oreal.zero();
            if (oreal.isneginf(x)) return oreal.zero();
            if (x == 0.0)
            {
                if (n == -2) return -1 / oreal.t(3);
                if (n < 0) return oreal.zero();
                else
                {
                    if (lrint(n) % 2 == 0) return oreal.inf(); else return oreal.nan();
                }
            }
            return oflintc.sph_bessel_yn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Octuple sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(oreal.t(n), oreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Octuple sph_bessel_in_prime(Octuple n, Octuple x, bool scaled = false)
        {
            if (!oreal.isinteger(n)) return oreal.nan();

            if (oreal.isnan(x)) return oreal.nan();
            if (oreal.isinf(x)) return oreal.inf();
            if (oreal.isneginf(x))
            {
                if (lrint(n) % 2 == 0) return oreal.neginf(); else return oreal.inf();
            }
            if (x == 0.0)
            {
                if (n == 0) return oreal.zero();
                if (n < 0)
                {
                    if (lrint(n) % 2 != 0) return oreal.neginf(); else return oreal.nan();
                }
            }
            return oflintc.sph_bessel_in_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Octuple sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(oreal.t(n), oreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Octuple sph_bessel_kn_prime(Octuple n, Octuple x, bool scaled = false)
        {
            if (!oreal.isinteger(n)) return oreal.nan();

            if (oreal.isnan(x)) return oreal.nan();
            if (oreal.isinf(x)) return oreal.zero();
            if (oreal.isneginf(x)) return oreal.neginf();
            if (x == 0.0)
            {
                if (((n >= 0) && (lrint(n) % 2 == 0)) || ((n < 0) && (lrint(n) % 2 != 0))) return oreal.neginf();
                else return oreal.nan();
            }
            return oflintc.sph_bessel_kn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Octuple sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(oreal.t(n), oreal.t(x), scaled);
        }





        #endregion







        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static OctupleC hankel_h1(Octuple v, Octuple x)
        {
            return bessel_jv(v, x) + ocplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static OctupleC hankel_h1(dynamic v, dynamic x)
        {
            return hankel_h1(oreal.t(v), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static OctupleC hankel_h2(Octuple v, Octuple x)
        {
            return bessel_jv(v, x) - ocplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static OctupleC hankel_h2(dynamic v, dynamic x)
        {
            return hankel_h2(oreal.t(v), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static OctupleC sph_hankel_h1(int n, Octuple x)
        {
            return sph_bessel_jn(n, x) + ocplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static OctupleC sph_hankel_h1(int n, dynamic x)
        {
            return sph_hankel_h1(n, oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static OctupleC sph_hankel_h2(int n, Octuple x)
        {
            return sph_bessel_jn(n, x) - ocplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static OctupleC sph_hankel_h2(int n, dynamic x)
        {
            return sph_hankel_h2(n, oreal.t(x));
        }






        #endregion







        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Octuple airy_ai(Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS1Bool1(aflint.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Octuple airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Octuple airy_ai_prime(Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS1Bool1(aflint.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Octuple airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Octuple airy_bi(Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS1Bool1(aflint.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Octuple airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Octuple airy_bi_prime(Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS1Bool1(aflint.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Octuple airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(oreal.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        public static Octuple airy_ai_zero(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_AiryAiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_AiryAiZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        public static Octuple airy_ai_prime_zero(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_AiryAiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_AiryAiPrimeZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        public static Octuple airy_bi_zero(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_AiryBiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_AiryBiZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        public static Octuple airy_bi_prime_zero(Int32 n)
        {
            var res = new Octuple();
            Lib_OReal_Arb_AiryBiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_AiryBiPrimeZero(IntPtr res, Int32 n);



        #endregion





        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Octuple kelvin_ber(Octuple v, Octuple x, bool scaled = false)
        {
            return oflintc.kelvin_ber(ocplx.t(v), ocplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Octuple kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(oreal.t(v), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Octuple kelvin_bei(Octuple v, Octuple x, bool scaled = false)
        {
            return oflintc.kelvin_bei(ocplx.t(v), ocplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Octuple kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(oreal.t(v), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Octuple kelvin_ker(Octuple v, Octuple x, bool scaled = false)
        {
            return oflintc.kelvin_ker(ocplx.t(v), ocplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Octuple kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(oreal.t(v), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Octuple kelvin_kei(Octuple v, Octuple x, bool scaled = false)
        {
            return oflintc.kelvin_kei(ocplx.t(v), ocplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Octuple kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(oreal.t(v), oreal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Octuple kelvin_ber_prime(Octuple v, Octuple x, bool scaled = false)
        {
            return oflintc.kelvin_ber_prime(ocplx.t(v), ocplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Octuple kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(oreal.t(v), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Octuple kelvin_bei_prime(Octuple v, Octuple x, bool scaled = false)
        {
            return oflintc.kelvin_bei_prime(ocplx.t(v), ocplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Octuple kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(oreal.t(v), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Octuple kelvin_ker_prime(Octuple v, Octuple x, bool scaled = false)
        {
            return oflintc.kelvin_ker_prime(ocplx.t(v), ocplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Octuple kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(oreal.t(v), oreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Octuple kelvin_kei_prime(Octuple v, Octuple x, bool scaled = false)
        {
            return oflintc.kelvin_kei_prime(ocplx.t(v), ocplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Octuple kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(oreal.t(v), oreal.t(x), scaled);
        }








        #endregion











        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Octuple hyperg_1f1(Octuple a, Octuple b, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Octuple hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(oreal.t(a), oreal.t(b), oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Octuple hyperg_1f1r(Octuple a, Octuple b, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Octuple hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(oreal.t(a), oreal.t(b), oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Octuple hyperg_u(Octuple a, Octuple b, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Octuple hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(oreal.t(a), oreal.t(b), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Octuple hermite_h(Octuple n, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Octuple hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(oreal.t(n), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Octuple hermite_he(Octuple n, Octuple x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Octuple hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(oreal.t(n), oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Octuple laguerre_l(Octuple n, Octuple m, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Octuple laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(oreal.t(n), oreal.t(m), oreal.t(x));
        }






        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Octuple gamma_upper(Octuple s, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Octuple gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Octuple gamma_q(Octuple s, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Octuple gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Octuple gamma_lower(Octuple s, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Octuple gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Octuple gamma_p(Octuple s, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Octuple gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(oreal.t(s), oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Octuple gamma_p_prime(Octuple s, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Octuple gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(oreal.t(s), oreal.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Octuple erf(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Octuple erf(dynamic x)
        {
            return erf(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Octuple erfc(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Octuple erfc(dynamic x)
        {
            return erfc(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Octuple erf_inv(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Erfinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Erfinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Erfinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Octuple erf_inv(dynamic x)
        {
            return erf_inv(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Octuple erfc_inv(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Erfcinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Erfcinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Erfcinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Octuple erfc_inv(dynamic x)
        {
            return erfc_inv(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Octuple erfi(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Octuple erfi(dynamic x)
        {
            return erfi(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Octuple dawson(Octuple x)
        {
            return aflint.ORealViaArbS1(aflint.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Octuple dawson(dynamic x)
        {
            return dawson(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Octuple fresnel_s(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Octuple fresnel_s(dynamic x)
        {
            return fresnel_s(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Octuple fresnel_c(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Octuple fresnel_c(dynamic x)
        {
            return fresnel_c(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Octuple ndens(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Octuple ndens(dynamic x)
        {
            return ndens(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Octuple ndis(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Octuple ndis(dynamic x)
        {
            return ndis(oreal.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Octuple exp_integral_en(Octuple s, Octuple z)
        {
            var res = new Octuple();
            Lib_OReal_Arb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Octuple exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(oreal.t(s), oreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Octuple exp_integral_e1(Octuple z)
        {
            if (z < 0) return -exp_integral_ei(-z);
            else return exp_integral_en(oreal.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Octuple exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(oreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Octuple exp_integral_ei(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Octuple exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Octuple sin_integral(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Octuple sin_integral(dynamic x)
        {
            return sin_integral(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Octuple cos_integral(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Octuple cos_integral(dynamic x)
        {
            return cos_integral(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Octuple sinh_integral(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Octuple sinh_integral(dynamic x)
        {
            return sinh_integral(oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Octuple cosh_integral(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Octuple cosh_integral(dynamic x)
        {
            return cosh_integral(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Octuple log_integral(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Octuple log_integral(dynamic x)
        {
            return log_integral(oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Octuple log_integral_offset(Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Octuple log_integral_offset(dynamic x)
        {
            return log_integral_offset(oreal.t(x));
        }



        #endregion





        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Octuple coulomb_f(Octuple l, Octuple eta, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Octuple coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(oreal.t(l), oreal.t(eta), oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Octuple coulomb_g(Octuple l, Octuple eta, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Octuple coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(oreal.t(l), oreal.t(eta), oreal.t(x));
        }



        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Octuple whittaker_m(Octuple k, Octuple m, Octuple x)
        {
            return aflint.ORealViaArbS3(aflint.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Octuple whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(oreal.t(k), oreal.t(m), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Octuple whittaker_w(Octuple k, Octuple m, Octuple x)
        {
            return aflint.ORealViaArbS3(aflint.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Octuple whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(oreal.t(k), oreal.t(m), oreal.t(x));
        }





        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Octuple pcfd(Octuple n, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Octuple pcfd(dynamic n, dynamic x)
        {
            return pcfd(oreal.t(n), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Octuple pcfu(Octuple a, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Octuple pcfu(dynamic a, dynamic x)
        {
            return pcfu(oreal.t(a), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Octuple pcfv(Octuple a, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Octuple pcfv(dynamic a, dynamic x)
        {
            return pcfv(oreal.t(a), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Octuple pcfw(Octuple a, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Octuple pcfw(dynamic a, dynamic x)
        {
            return pcfw(oreal.t(a), oreal.t(x));
        }





        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Octuple hyperg_2f1(Octuple a, Octuple b, Octuple c, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Octuple hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(oreal.t(a), oreal.t(b), oreal.t(c), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Octuple hyperg_2f1r(Octuple a, Octuple b, Octuple c, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Octuple hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(oreal.t(a), oreal.t(b), oreal.t(c), oreal.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Octuple chebyshev_t(Octuple n, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Octuple chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(oreal.t(n), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Octuple chebyshev_u(Octuple n, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Octuple chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(oreal.t(n), oreal.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static Octuple chebyshev_v(Octuple n, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2(aflint.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Octuple chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(oreal.t(n), oreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static Octuple chebyshev_w(Octuple n, Octuple x, bool scaled = false)
        {
            return aflint.ORealViaArbS2(aflint.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Octuple chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(oreal.t(n), oreal.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Octuple gegenbauer_c(Octuple n, Octuple m, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Octuple gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(oreal.t(n), oreal.t(m), oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Octuple jacobi_p(Octuple n, Octuple a, Octuple b, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Octuple jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(oreal.t(n), oreal.t(a), oreal.t(b), oreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Octuple legendre_p(Octuple n, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.legendre_p, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_p/*' />
        public static Octuple legendre_p(dynamic n, dynamic y)
        {
            return legendre_p(oreal.t(n), oreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Octuple legendre_q(Octuple n, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.legendre_q, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_q/*' />
        public static Octuple legendre_q(dynamic n, dynamic y)
        {
            return legendre_q(oreal.t(n), oreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Octuple legendre_plm(Octuple n, Octuple m, Octuple x)
        {
            return aflint.ORealViaArbS3(aflint.legendre_plm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_plm/*' />
        public static Octuple legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(oreal.t(n), oreal.t(m), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Octuple legendre_qlm(Octuple n, Octuple m, Octuple x)
        {
            return aflint.ORealViaArbS3(aflint.legendre_qlm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_qlm/*' />
        public static Octuple legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(oreal.t(n), oreal.t(m), oreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_plm/*' />
        public static Octuple toroidal_plm(Octuple l, Octuple m, Octuple x)
        {
            return aflint.ORealViaArbS3(aflint.toroidal_plm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_plm/*' />
        public static Octuple toroidal_plm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_plm(oreal.t(l), oreal.t(m), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_qlm/*' />
        public static Octuple toroidal_qlm(Octuple l, Octuple m, Octuple x)
        {
            return aflint.ORealViaArbS3(aflint.toroidal_qlm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_qlm/*' />
        public static Octuple toroidal_qlm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_qlm(oreal.t(l), oreal.t(m), oreal.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static OctupleC spherical_y(Octuple n, Octuple m, Octuple theta, Octuple phi)
        {
            return oflintc.spherical_y(ocplx.t(n), ocplx.t(m), ocplx.t(theta), ocplx.t(phi));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static OctupleC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(oreal.t(n), oreal.t(m), oreal.t(theta), oreal.t(phi));
        }







        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Octuple beta_lower(Octuple a, Octuple b, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Octuple beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(oreal.t(a), oreal.t(b), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Octuple ibeta(Octuple a, Octuple b, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Octuple ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(oreal.t(a), oreal.t(b), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Octuple ibetac(Octuple a, Octuple b, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Octuple ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(oreal.t(a), oreal.t(b), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Octuple ibeta_prime(Octuple a, Octuple b, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Octuple ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(oreal.t(a), oreal.t(b), oreal.t(x));
        }


        #endregion



        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Octuple hyperg_1f2(Octuple a1, Octuple b1, Octuple b2, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Octuple hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(oreal.t(a1), oreal.t(b1), oreal.t(b2), oreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Octuple hyperg_1f2r(Octuple a1, Octuple b1, Octuple b2, Octuple x)
        {
            var res = new Octuple();
            Lib_OReal_Arb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OReal_Arb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OReal_Arb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Octuple hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(oreal.t(a1), oreal.t(b1), oreal.t(b2), oreal.t(x));
        }





        #endregion



        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Octuple airy_gi(Octuple x)
        {
            return aflint.ORealViaArbS1(aflint.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Octuple airy_gi(dynamic x)
        {
            return airy_gi(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Octuple airy_hi(Octuple x)
        {
            return aflint.ORealViaArbS1(aflint.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Octuple airy_hi(dynamic x)
        {
            return airy_hi(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Octuple airy_gi_prime(Octuple x)
        {
            return aflint.ORealViaArbS1(aflint.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Octuple airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Octuple airy_hi_prime(Octuple x)
        {
            return aflint.ORealViaArbS1(aflint.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Octuple airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(oreal.t(x));
        }



        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Octuple struve_h(Octuple v, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Octuple struve_h(dynamic v, dynamic x)
        {
            return struve_h(oreal.t(v), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Octuple struve_l(Octuple v, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Octuple struve_l(dynamic v, dynamic x)
        {
            return struve_l(oreal.t(v), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Octuple struve_k(Octuple v, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Octuple struve_k(dynamic v, dynamic x)
        {
            return struve_k(oreal.t(v), oreal.t(x));
        }


        public static Octuple struve_m(Octuple v, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static Octuple struve_m(dynamic v, dynamic x)
        {
            return struve_m(oreal.t(v), oreal.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Octuple anger_j(Octuple v, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Octuple anger_j(dynamic v, dynamic x)
        {
            return anger_j(oreal.t(v), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Octuple weber_e(Octuple v, Octuple x)
        {
            return aflint.ORealViaArbS2(aflint.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Octuple weber_e(dynamic v, dynamic x)
        {
            return weber_e(oreal.t(v), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Octuple lommel_s1(Octuple mu, Octuple nu, Octuple x)
        {
            return aflint.ORealViaArbS3(aflint.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Octuple lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(oreal.t(mu), oreal.t(nu), oreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Octuple lommel_s2(Octuple mu, Octuple nu, Octuple x)
        {
            return aflint.ORealViaArbS3(aflint.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Octuple lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(oreal.t(mu), oreal.t(nu), oreal.t(x));
        }


        #endregion






        #endregion





    }






    public class oflintc
    {



        /// <summary>
        /// Returns a new OctupleC using an ArbC number as input
        /// </summary>
        public static OctupleC t(ArbC x)
        {
            OctupleC res = ocplx.t(0);
            Lib_OCplx_Set_Acb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Set_Acb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Set_Acb(IntPtr res, IntPtr x);


        /// <summary>
        /// Returns a new OctupleC using an MpfrC number as input
        /// </summary>
        public static OctupleC t(MpfrC x)
        {
            OctupleC res = ocplx.t(0);
            Lib_OCplx_Set_MpfrC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Set_MpfrC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Set_MpfrC(IntPtr res, IntPtr x);





        public static String fmt(OctupleC z)
        {
            return ocplx.fmt(z);
        }


        public static String fmt(Octuple x)
        {
            return oreal.fmt(x);
        }


        public static String fmt(dynamic z)
        {
            return fmt(ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "oflintc"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "oflintc"; }
        }


        public static oflint realctx
        {
            get { return new oflint(); }
        }



        #region Flint Basic Functions



        #region Complex components


        public static Octuple abs(OctupleC z)
        {
            return ocplx.abs(z);
        }


        public static Octuple abs(dynamic z)
        {
            return ocplx.abs(z);
        }


        public static Octuple fabs(OctupleC z)
        {
            return ocplx.fabs(z);
        }


        public static Octuple fabs(dynamic z)
        {
            return ocplx.fabs(z);
        }


        public static OctupleC sign(OctupleC z)
        {
            return ocplx.sign(z);
        }


        public static OctupleC sign(dynamic z)
        {
            return ocplx.sign(z);
        }


        public static Octuple real(OctupleC z)
        {
            return z.real;
        }


        public static Octuple real(dynamic z)
        {
            return real(ocplx.t(z));
        }



        public static Octuple imag(OctupleC z)
        {
            return z.imag;
        }


        public static Octuple imag(dynamic z)
        {
            return imag(ocplx.t(z));
        }




        public static Octuple phase(OctupleC z)
        {
            return ocplx.phase(z);
        }


        public static Octuple phase(dynamic z)
        {
            return ocplx.phase(z);
        }



        public static OctupleC conj(OctupleC z)
        {
            return ocplx.conj(z);
        }


        public static OctupleC conj(dynamic z)
        {
            return ocplx.conj(z);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Octuple, Octuple> polar(OctupleC x)
        {
            return new Tuple<Octuple, Octuple>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Octuple, Octuple> polar(dynamic x)
        {
            return polar(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static OctupleC rect(Octuple r, Octuple phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static OctupleC rect(dynamic r, dynamic phi)
        {
            return rect(oreal.t(r), oreal.t(phi));
        }






        #endregion





        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static OctupleC sqrt(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static OctupleC sqrt(dynamic x)
        {
            return sqrt(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static OctupleC rsqrt(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static OctupleC rsqrt(dynamic x)
        {
            return sqrt(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static OctupleC cbrt(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static OctupleC cbrt(dynamic x)
        {
            return cbrt(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static OctupleC sqrt1pm1(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static OctupleC sqrt1pm1(dynamic x)
        {
            return cbrt(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static OctupleC unitroot(Int32 n)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_UnitRoot_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_UnitRoot_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_UnitRoot_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static OctupleC root_si(OctupleC x, Int32 n)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Root_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static OctupleC root_si(dynamic x, Int32 n)
        {
            return root_si(ocplx.t(x), n);
        }




        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static OctupleC exp(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static OctupleC exp(dynamic x)
        {
            return exp(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static OctupleC expj(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Expj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Expj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Expj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static OctupleC expj(dynamic x)
        {
            return expj(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static OctupleC expjpi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Expjpi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Expjpi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Expjpi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static OctupleC expjpi(dynamic x)
        {
            return expjpi(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static OctupleC exp10(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static OctupleC exp10(dynamic x)
        {
            return exp10(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static OctupleC exp2(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static OctupleC exp2(dynamic x)
        {
            return exp2(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static OctupleC expm1(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static OctupleC expm1(dynamic x)
        {
            return expm1(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static OctupleC exp10m1(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static OctupleC exp10m1(dynamic x)
        {
            return exp10m1(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static OctupleC exp2m1(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static OctupleC exp2m1(dynamic x)
        {
            return exp2m1(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static OctupleC exprel(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static OctupleC exprel(dynamic x)
        {
            return exprel(ocplx.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static OctupleC logbase(OctupleC x, OctupleC b)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static OctupleC logbase(dynamic x, dynamic b)
        {
            return logbase(ocplx.t(x), ocplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static OctupleC log(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static OctupleC log(dynamic x)
        {
            return log(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static OctupleC log10(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static OctupleC log10(dynamic x)
        {
            return log10(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static OctupleC log2(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static OctupleC log2(dynamic x)
        {
            return log2(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static OctupleC log1p(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static OctupleC log1p(dynamic x)
        {
            return log1p(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static OctupleC log10p1(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static OctupleC log10p1(dynamic x)
        {
            return log10p1(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static OctupleC log2p1(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static OctupleC log2p1(dynamic x)
        {
            return log2p1(ocplx.t(x));
        }



        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static OctupleC sqr(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static OctupleC sqr(dynamic x)
        {
            return sqr(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static OctupleC cube(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static OctupleC cube(dynamic x)
        {
            return cube(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static OctupleC hypot(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static OctupleC hypot(dynamic x, dynamic y)
        {
            return hypot(ocplx.t(x), ocplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static OctupleC pow_si(OctupleC x, Int32 n)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Pow_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Pow_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static OctupleC pow_si(dynamic x, Int32 n)
        {
            return pow_si(ocplx.t(x), n);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static OctupleC compound_si(OctupleC x, Int32 n)
        {
            return pow1p(ocplx.t(x), ocplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static OctupleC compound_si(dynamic x, Int32 n)
        {
            return pow1p(ocplx.t(x), ocplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static OctupleC pow(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static OctupleC pow(dynamic x, dynamic y)
        {
            return pow(ocplx.t(x), ocplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static OctupleC powm1(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static OctupleC powm1(dynamic x, dynamic y)
        {
            return powm1(ocplx.t(x), ocplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static OctupleC pow1p(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static OctupleC pow1p(dynamic x, dynamic y)
        {
            return pow1p(ocplx.t(x), ocplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static OctupleC pow1pm1(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static OctupleC pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(ocplx.t(x), ocplx.t(y));
        }



        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static OctupleC sin(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static OctupleC sin(dynamic x)
        {
            return sin(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static OctupleC cos(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static OctupleC cos(dynamic x)
        {
            return cos(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static OctupleC tan(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static OctupleC tan(dynamic x)
        {
            return tan(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static OctupleC cot(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static OctupleC cot(dynamic x)
        {
            return cot(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static OctupleC sec(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static OctupleC sec(dynamic x)
        {
            return sec(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static OctupleC csc(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static OctupleC csc(dynamic x)
        {
            return csc(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static OctupleC sinc(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static OctupleC sinc(dynamic x)
        {
            return sinc(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static OctupleC sinpi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static OctupleC sinpi(dynamic x)
        {
            return sinpi(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static OctupleC cospi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static OctupleC cospi(dynamic x)
        {
            return cospi(ocplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static OctupleC tanpi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static OctupleC tanpi(dynamic x)
        {
            return tanpi(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static OctupleC cotpi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static OctupleC cotpi(dynamic x)
        {
            return cotpi(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static OctupleC cscpi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CscPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CscPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CscPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static OctupleC cscpi(dynamic x)
        {
            return cscpi(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static OctupleC secpi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_SecPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_SecPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_SecPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static OctupleC secpi(dynamic x)
        {
            return secpi(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static OctupleC sincpi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static OctupleC sincpi(dynamic x)
        {
            return sincpi(ocplx.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static OctupleC cosh(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static OctupleC cosh(dynamic x)
        {
            return cosh(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static OctupleC sinh(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static OctupleC sinh(dynamic x)
        {
            return sinh(ocplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static OctupleC tanh(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static OctupleC tanh(dynamic x)
        {
            return tanh(ocplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static OctupleC csch(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static OctupleC csch(dynamic x)
        {
            return csch(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static OctupleC sech(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static OctupleC sech(dynamic x)
        {
            return sech(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static OctupleC coth(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static OctupleC coth(dynamic x)
        {
            return coth(ocplx.t(x));
        }





        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static OctupleC asin(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static OctupleC asin(dynamic x)
        {
            return asin(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static OctupleC acos(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static OctupleC acos(dynamic x)
        {
            return acos(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static OctupleC atan(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static OctupleC atan(dynamic x)
        {
            return atan(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static OctupleC acsc(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static OctupleC acsc(dynamic x)
        {
            return acsc(ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static OctupleC asec(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static OctupleC asec(dynamic x)
        {
            return asec(ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static OctupleC acot(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static OctupleC acot(dynamic x)
        {
            return acot(ocplx.t(x));
        }


        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static OctupleC asinh(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static OctupleC asinh(dynamic x)
        {
            return asinh(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static OctupleC acosh(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static OctupleC acosh(dynamic x)
        {
            return acosh(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static OctupleC atanh(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static OctupleC atanh(dynamic x)
        {
            return atanh(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static OctupleC acsch(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static OctupleC acsch(dynamic x)
        {
            return acsch(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static OctupleC asech(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static OctupleC asech(dynamic x)
        {
            return asech(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static OctupleC acoth(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static OctupleC acoth(dynamic x)
        {
            return acoth(ocplx.t(x));
        }





        #endregion




        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static OctupleC gamma(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static OctupleC gamma(dynamic x)
        {
            return gamma(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static OctupleC rgamma(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static OctupleC rgamma(dynamic x)
        {
            return rgamma(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static OctupleC lgamma(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static OctupleC lgamma(dynamic x)
        {
            return lgamma(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static OctupleC rising_factorial(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static OctupleC rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(ocplx.t(x), ocplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static OctupleC beta(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static OctupleC beta(dynamic x, dynamic y)
        {
            return beta(ocplx.t(x), ocplx.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static OctupleC gamma1pm1(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static OctupleC gamma1pm1(dynamic x)
        {
            return gamma1pm1(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static OctupleC factorial(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static OctupleC factorial(dynamic x)
        {
            return factorial(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static OctupleC doublefactorial(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static OctupleC doublefactorial(dynamic x)
        {
            return doublefactorial(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static OctupleC falling_factorial(OctupleC a, OctupleC n)
        {
            return aflintc.OCplxViaArbCS2(aflintc.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static OctupleC falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(ocplx.t(a), ocplx.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static OctupleC gamma_ratio(OctupleC a, OctupleC b)
        {
            return aflintc.OCplxViaArbCS2(aflintc.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static OctupleC gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(ocplx.t(a), ocplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static OctupleC gamma_delta_ratio(OctupleC a, OctupleC delta)
        {
            return aflintc.OCplxViaArbCS2(aflintc.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static OctupleC gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(ocplx.t(a), ocplx.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static OctupleC binomial(OctupleC n, OctupleC k)
        {
            return aflintc.OCplxViaArbCS2(aflintc.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static OctupleC binomial(dynamic n, dynamic k)
        {
            return binomial(ocplx.t(n), ocplx.t(k));
        }









        #endregion



        #region Miscellaneous



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static OctupleC lambert_wk(OctupleC x, int branch)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_LambertW_ui(res.mpPtr, x.mpPtr, branch);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LambertW_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_LambertW_ui(IntPtr res, IntPtr x, int branch);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static OctupleC lambert_wk(dynamic x, int branch)
        {
            return lambert_wk(ocplx.t(x), branch);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static OctupleC lambert_w0(OctupleC x)
        {
            return lambert_wk(ocplx.t(x), 0);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static OctupleC lambert_w0(dynamic x)
        {
            return lambert_w0(ocplx.t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static OctupleC lambert_wm1(OctupleC x)
        {
            return lambert_wk(ocplx.t(x), -1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static OctupleC lambert_wm1(dynamic x)
        {
            return lambert_wm1(ocplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static OctupleC agm(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static OctupleC agm(dynamic x, dynamic y)
        {
            return agm(ocplx.t(x), ocplx.t(y));
        }





        #endregion





        #endregion





        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static OctupleC m_elliptic_k(OctupleC m)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static OctupleC m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static OctupleC m_elliptic_e(OctupleC m)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static OctupleC m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static OctupleC m_elliptic_pi(OctupleC n, OctupleC m)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static OctupleC m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(ocplx.t(x), ocplx.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static OctupleC m_elliptic_f(OctupleC phi, OctupleC m)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static OctupleC m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(ocplx.t(phi), ocplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static OctupleC m_elliptic_e_inc(OctupleC phi, OctupleC m)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static OctupleC m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(ocplx.t(phi), ocplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static OctupleC m_elliptic_pi_inc(OctupleC n, OctupleC phi, OctupleC m)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static OctupleC m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(ocplx.t(n), ocplx.t(phi), ocplx.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static OctupleC elliptic_k(OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static OctupleC elliptic_k(dynamic k)
        {
            return elliptic_k(ocplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static OctupleC elliptic_e(OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static OctupleC elliptic_e(dynamic k)
        {
            return elliptic_e(ocplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static OctupleC elliptic_pi(OctupleC n, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static OctupleC elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(ocplx.t(n), ocplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static OctupleC elliptic_f(OctupleC phi, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static OctupleC elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(ocplx.t(phi), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static OctupleC elliptic_e_inc(OctupleC phi, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static OctupleC elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(ocplx.t(phi), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static OctupleC elliptic_pi_inc(OctupleC n, OctupleC phi, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static OctupleC elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(ocplx.t(n), ocplx.t(phi), ocplx.t(k));
        }




        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static OctupleC elliptic_rc(OctupleC x, OctupleC y)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static OctupleC elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(ocplx.t(x), ocplx.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static OctupleC elliptic_rf(OctupleC x, OctupleC y, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static OctupleC elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(ocplx.t(x), ocplx.t(y), ocplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static OctupleC elliptic_rg(OctupleC x, OctupleC y, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static OctupleC elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(ocplx.t(x), ocplx.t(y), ocplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static OctupleC elliptic_rd(OctupleC x, OctupleC y, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static OctupleC elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(ocplx.t(x), ocplx.t(y), ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static OctupleC elliptic_rj(OctupleC x, OctupleC y, OctupleC z, OctupleC w)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static OctupleC elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(ocplx.t(x), ocplx.t(y), ocplx.t(z), ocplx.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static OctupleC jacobi_theta1(OctupleC x, OctupleC q)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static OctupleC jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(ocplx.t(x), ocplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static OctupleC jacobi_theta2(OctupleC x, OctupleC q)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static OctupleC jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(ocplx.t(x), ocplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static OctupleC jacobi_theta3(OctupleC x, OctupleC q)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static OctupleC jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(ocplx.t(x), ocplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static OctupleC jacobi_theta4(OctupleC x, OctupleC q)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static OctupleC jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(ocplx.t(x), ocplx.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static OctupleC JacobiTheta1Tau(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Theta1QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Theta1QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Theta1QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static OctupleC JacobiTheta1Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta1Tau(ocplx.t(z), ocplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static OctupleC JacobiTheta2Tau(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Theta2QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Theta2QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Theta2QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static OctupleC JacobiTheta2Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta2Tau(ocplx.t(z), ocplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static OctupleC JacobiTheta3Tau(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Theta3QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Theta3QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Theta3QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static OctupleC JacobiTheta3Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta3Tau(ocplx.t(z), ocplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static OctupleC JacobiTheta4Tau(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Theta4QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Theta4QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_Theta4QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static OctupleC JacobiTheta4Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta4Tau(ocplx.t(z), ocplx.t(tau));
        }






        #endregion



        #region Jacobi elliptic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static OctupleC QfromK(OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_QfromK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_QfromK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_QfromK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static OctupleC QfromK(dynamic k)
        {
            return QfromK(ocplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static OctupleC TfromUQ(OctupleC u, OctupleC q)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_TfromUQ(res.mpPtr, u.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_TfromUQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_TfromUQ(IntPtr res, IntPtr u, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static OctupleC TfromUQ(dynamic n, dynamic k)
        {
            return TfromUQ(ocplx.t(n), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static OctupleC SnTQ(OctupleC t, OctupleC q)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_SnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_SnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_SnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static OctupleC SnTQ(dynamic t, dynamic q)
        {
            return SnTQ(ocplx.t(t), ocplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static OctupleC CnTQ(OctupleC t, OctupleC q)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_CnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static OctupleC CnTQ(dynamic t, dynamic q)
        {
            return CnTQ(ocplx.t(t), ocplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static OctupleC DnTQ(OctupleC t, OctupleC q)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_DnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_DnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_DnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static OctupleC DnTQ(dynamic t, dynamic q)
        {
            return DnTQ(ocplx.t(t), ocplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static OctupleC jacobi_sn(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static OctupleC jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static OctupleC jacobi_cn(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static OctupleC jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static OctupleC jacobi_dn(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static OctupleC jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static OctupleC jacobi_ns(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static OctupleC jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static OctupleC jacobi_nc(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static OctupleC jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static OctupleC jacobi_nd(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static OctupleC jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static OctupleC jacobi_sc(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static OctupleC jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static OctupleC jacobi_sd(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static OctupleC jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static OctupleC jacobi_dc(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static OctupleC jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static OctupleC jacobi_ds(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static OctupleC jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static OctupleC jacobi_cs(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static OctupleC jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(ocplx.t(x), ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static OctupleC jacobi_cd(OctupleC x, OctupleC k)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static OctupleC jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(ocplx.t(x), ocplx.t(k));
        }




        #endregion




        #region Conversions of parameters of Weierstrass P


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<OctupleC, OctupleC> elliptic_invariants_from_roots(OctupleC e1, OctupleC e2)
        {
            OctupleC e3 = -e1 - e2;
            OctupleC g2 = 2 * (e1 * e1 + e2 * e2 + e3 * e3);
            OctupleC g3 = 4 * e1 * e2 * e3;
            return new Tuple<OctupleC, OctupleC>(g2, g3);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<OctupleC, OctupleC> elliptic_invariants_from_roots(dynamic e1, dynamic e2)
        {
            return elliptic_invariants_from_roots(ocplx.t(e1), ocplx.t(e2));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<OctupleC, OctupleC> elliptic_invariants_from_tau(OctupleC tau)
        {
            return new Tuple<OctupleC, OctupleC>(EllipticInvariantG2(tau), EllipticInvariantG3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<OctupleC, OctupleC> elliptic_invariants_from_tau(dynamic tau)
        {
            return elliptic_invariants_from_tau(ocplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<OctupleC, OctupleC, OctupleC> elliptic_roots_from_tau(OctupleC tau)
        {
            return new Tuple<OctupleC, OctupleC, OctupleC>(EllipticRootE1(tau), EllipticRootE2(tau), EllipticRootE3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<OctupleC, OctupleC, OctupleC> elliptic_roots_from_tau(dynamic tau)
        {
            return elliptic_roots_from_tau(ocplx.t(tau));
        }



        #endregion







        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static OctupleC weierstrass_p_t(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_WeierstrassP(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_WeierstrassP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_WeierstrassP(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static OctupleC weierstrass_p_t(dynamic z, dynamic tau)
        {
            return weierstrass_p_t(ocplx.t(z), ocplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static OctupleC WeierstrassPInv(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_WeierstrassPInv(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_WeierstrassPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_WeierstrassPInv(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static OctupleC WeierstrassPInv(dynamic z, dynamic tau)
        {
            return WeierstrassPInv(ocplx.t(z), ocplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static OctupleC weierstrass_zeta_t(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_WeierstrassPZeta(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_WeierstrassPZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_WeierstrassPZeta(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static OctupleC weierstrass_zeta_t(dynamic z, dynamic tau)
        {
            return weierstrass_zeta_t(ocplx.t(z), ocplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static OctupleC weierstrass_sigma_t(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_WeierstrassPSigma(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_WeierstrassPSigma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_WeierstrassPSigma(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static OctupleC weierstrass_sigma_t(dynamic z, dynamic tau)
        {
            return weierstrass_sigma_t(ocplx.t(z), ocplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static OctupleC weierstrass_pprime_t(OctupleC z, OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_WeierstrassPPrime(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_WeierstrassPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_WeierstrassPPrime(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static OctupleC weierstrass_pprime_t(dynamic z, dynamic tau)
        {
            return weierstrass_pprime_t(ocplx.t(z), ocplx.t(tau));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static OctupleC EllipticInvariantG2(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticInvariantG2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticInvariantG2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticInvariantG2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static OctupleC EllipticInvariantG2(dynamic k)
        {
            return EllipticInvariantG2(ocplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static OctupleC EllipticInvariantG3(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticInvariantG3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticInvariantG3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticInvariantG3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static OctupleC EllipticInvariantG3(dynamic k)
        {
            return EllipticInvariantG3(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static OctupleC EllipticRootE1(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticRootE1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticRootE1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticRootE1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static OctupleC EllipticRootE1(dynamic k)
        {
            return EllipticRootE1(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static OctupleC EllipticRootE2(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticRootE2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticRootE2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticRootE2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static OctupleC EllipticRootE2(dynamic k)
        {
            return EllipticRootE2(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static OctupleC EllipticRootE3(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EllipticRootE3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EllipticRootE3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_EllipticRootE3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static OctupleC EllipticRootE3(dynamic k)
        {
            return EllipticRootE3(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static OctupleC dedekind_eta(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_DedekindEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_DedekindEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_DedekindEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static OctupleC dedekind_eta(dynamic k)
        {
            return dedekind_eta(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static OctupleC klein_j(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_KleinJ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_KleinJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_KleinJ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static OctupleC klein_j(dynamic k)
        {
            return klein_j(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static OctupleC modular_lambda(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ModularLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ModularLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_ModularLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static OctupleC modular_lambda(dynamic k)
        {
            return modular_lambda(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static OctupleC modular_delta(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ModularDelta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ModularDelta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_ModularDelta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static OctupleC modular_delta(dynamic k)
        {
            return modular_delta(ocplx.t(k));
        }



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static OctupleC lerch_phi(OctupleC s, OctupleC z, OctupleC a)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static OctupleC lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(ocplx.t(s), ocplx.t(z), ocplx.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static OctupleC lerch_zeta(OctupleC lambda1, OctupleC alpha, OctupleC s)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_LerchZeta(res.mpPtr, lambda1.mpPtr, alpha.mpPtr, s.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LerchZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_LerchZeta(IntPtr res, IntPtr lambda1, IntPtr alpha, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static OctupleC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(ocplx.t(lambda1), ocplx.t(alpha), ocplx.t(s));
        }




        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static OctupleC polygamma(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static OctupleC polygamma(dynamic s, dynamic z)
        {
            return polygamma(ocplx.t(s), ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static OctupleC trigamma(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Trigamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Trigamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static OctupleC trigamma(dynamic x)
        {
            return trigamma(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static OctupleC digamma(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static OctupleC digamma(dynamic x)
        {
            return digamma(ocplx.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static OctupleC polylog(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static OctupleC polylog(dynamic s, dynamic z)
        {
            return polylog(ocplx.t(s), ocplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static OctupleC trilog(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Trilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Trilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Trilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static OctupleC trilog(dynamic x)
        {
            return trilog(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static OctupleC dilog(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static OctupleC dilog(dynamic x)
        {
            return dilog(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static OctupleC clausen_sin(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ClausenSin(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ClausenSin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_ClausenSin(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static OctupleC clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(ocplx.t(s), ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static OctupleC clausen_cos(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ClausenCos(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ClausenCos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_ClausenCos(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static OctupleC clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(ocplx.t(s), ocplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static OctupleC clausen2(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Clausen2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Clausen2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Clausen2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static OctupleC clausen2(dynamic x)
        {
            return clausen2(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static OctupleC bose_einstein(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_BoseEinstein(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_BoseEinstein", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_BoseEinstein(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static OctupleC bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(ocplx.t(s), ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static OctupleC fermi_dirac(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_FermiDirac(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_FermiDirac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_FermiDirac(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static OctupleC fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(ocplx.t(s), ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static OctupleC legendre_chi(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_LegendreChi(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LegendreChi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_LegendreChi(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static OctupleC legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(ocplx.t(s), ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static OctupleC inverse_tan_integral(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_InverseTanIntegral(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_InverseTanIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_InverseTanIntegral(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static OctupleC inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(ocplx.t(s), ocplx.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static OctupleC hurwitz_zeta(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_HurwitzZeta(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static OctupleC hurwitz_zeta(dynamic s, dynamic z)
        {
            return hurwitz_zeta(ocplx.t(s), ocplx.t(z));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/stieltjes/*' />
        //public static OctupleC stieltjes(OctupleC x, Int32 n)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_Stieltjes_ui(res.mpPtr, x.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Stieltjes_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_Stieltjes_ui(IntPtr res, IntPtr x, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static OctupleC bernpoly(OctupleC x, Int32 n)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static OctupleC bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(ocplx.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static OctupleC eulerpoly(OctupleC x, Int32 n)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_EulerPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_EulerPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_EulerPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static OctupleC eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(ocplx.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static OctupleC harmonic(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Harmonic(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Harmonic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Harmonic(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static OctupleC harmonic(dynamic x)
        {
            return harmonic(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static OctupleC harmonic2(OctupleC z, OctupleC r)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Harmonic2(res.mpPtr, z.mpPtr, r.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Harmonic2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Harmonic2(IntPtr res, IntPtr z, IntPtr r);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static OctupleC harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(ocplx.t(z), ocplx.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static OctupleC barnes_g(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static OctupleC barnes_g(dynamic x)
        {
            return barnes_g(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static OctupleC logbarnes_g(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static OctupleC logbarnes_g(dynamic x)
        {
            return logbarnes_g(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static OctupleC hyperfactorial(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hyperfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hyperfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hyperfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static OctupleC hyperfactorial(dynamic x)
        {
            return hyperfactorial(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static OctupleC superfactorial(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Superfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Superfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Superfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static OctupleC superfactorial(dynamic x)
        {
            return superfactorial(ocplx.t(x));
        }




        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static OctupleC zeta(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static OctupleC zeta(dynamic x)
        {
            return zeta(ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static OctupleC zetam1(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Zetam1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Zetam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Zetam1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static OctupleC zetam1(dynamic x)
        {
            return zetam1(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static OctupleC riemann_xi(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_DirichletXi(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_DirichletXi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_DirichletXi(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static OctupleC riemann_xi(dynamic k)
        {
            return riemann_xi(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static OctupleC dirichlet_eta(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_DirichletEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_DirichletEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_DirichletEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static OctupleC dirichlet_eta(dynamic k)
        {
            return dirichlet_eta(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static OctupleC dirichlet_etam1(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_DirichletEtam1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_DirichletEtam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_DirichletEtam1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static OctupleC dirichlet_etam1(dynamic k)
        {
            return dirichlet_etam1(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static OctupleC dirichlet_beta(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_DirichletBeta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_DirichletBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_DirichletBeta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static OctupleC dirichlet_beta(dynamic k)
        {
            return dirichlet_beta(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static OctupleC dirichlet_lambda(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_DirichletLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_DirichletLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_DirichletLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static OctupleC dirichlet_lambda(dynamic k)
        {
            return dirichlet_lambda(ocplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static OctupleC hardy_z(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_HardyZ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_HardyZ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_HardyZ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static OctupleC hardy_z(dynamic k)
        {
            return hardy_z(ocplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static OctupleC hardy_theta(OctupleC tau)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_HardyTheta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_HardyTheta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_OCplx_Acb_HardyTheta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static OctupleC hardy_theta(dynamic k)
        {
            return hardy_theta(ocplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta_zero/*' />
        public static OctupleC zeta_zero(Int32 n)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ZetaZero_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ZetaZero_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_ZetaZero_ui(IntPtr res, Int32 n);



        #endregion



        #region Additional numbertheoretic functions





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static OctupleC hyperg_0f1(OctupleC a, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static OctupleC hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(ocplx.t(a), ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static OctupleC hyperg_0f1r(OctupleC a, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static OctupleC hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(ocplx.t(a), ocplx.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static OctupleC bessel_jv(OctupleC nu, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static OctupleC bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(ocplx.t(nu), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static OctupleC bessel_yv(OctupleC nu, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static OctupleC bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(ocplx.t(nu), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static OctupleC bessel_iv(OctupleC nu, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static OctupleC bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(ocplx.t(nu), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static OctupleC bessel_kv(OctupleC nu, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static OctupleC bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(ocplx.t(nu), ocplx.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static OctupleC bessel_jv_prime(OctupleC nu, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static OctupleC bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(ocplx.t(nu), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static OctupleC bessel_yv_prime(OctupleC nu, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static OctupleC bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(ocplx.t(nu), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static OctupleC bessel_iv_prime(OctupleC nu, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static OctupleC bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(ocplx.t(nu), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static OctupleC bessel_kv_prime(OctupleC nu, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static OctupleC bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(ocplx.t(nu), ocplx.t(x), scaled);
        }









        #endregion








        #region 0F1: Spherical Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static OctupleC sph_bessel_jn(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_bessel_jn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static OctupleC sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(ocplx.t(n), ocplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static OctupleC sph_bessel_yn(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_bessel_yn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static OctupleC sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(ocplx.t(n), ocplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static OctupleC sph_bessel_in(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_bessel_in, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static OctupleC sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(ocplx.t(n), ocplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static OctupleC sph_bessel_kn(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_bessel_kn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static OctupleC sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(ocplx.t(n), ocplx.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static OctupleC besselpoly(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.besselpoly, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static OctupleC besselpoly(dynamic n, dynamic x, bool scaled = false)
        {
            return besselpoly(ocplx.t(n), ocplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static OctupleC besseltheta(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.besseltheta, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static OctupleC besseltheta(dynamic n, dynamic x, bool scaled = false)
        {
            return besseltheta(ocplx.t(n), ocplx.t(x), scaled);
        }







        #endregion



        #region 0F1: Spherical Bessel functions, first derivative


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static OctupleC sph_bessel_jn_prime(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_bessel_jn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static OctupleC sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(ocplx.t(n), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static OctupleC sph_bessel_yn_prime(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_bessel_yn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static OctupleC sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(ocplx.t(n), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static OctupleC sph_bessel_in_prime(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_bessel_in_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static OctupleC sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(ocplx.t(n), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static OctupleC sph_bessel_kn_prime(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_bessel_kn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static OctupleC sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(ocplx.t(n), ocplx.t(x), scaled);
        }



        #endregion








        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static OctupleC hankel_h1(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.hankel_h1, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static OctupleC hankel_h1(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h1(ocplx.t(v), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static OctupleC hankel_h2(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.hankel_h2, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static OctupleC hankel_h2(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h2(ocplx.t(v), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static OctupleC sph_hankel_h1(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_hankel_h1, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static OctupleC sph_hankel_h1(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h1(ocplx.t(n), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static OctupleC sph_hankel_h2(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.sph_hankel_h2, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static OctupleC sph_hankel_h2(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h2(ocplx.t(n), ocplx.t(x), scaled);
        }






        #endregion





        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static OctupleC airy_ai(OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS1Bool1(aflintc.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static OctupleC airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static OctupleC airy_ai_prime(OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS1Bool1(aflintc.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static OctupleC airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static OctupleC airy_bi(OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS1Bool1(aflintc.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static OctupleC airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static OctupleC airy_bi_prime(OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS1Bool1(aflintc.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static OctupleC airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(ocplx.t(x), scaled);
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static OctupleC airy_ai(OctupleC x, bool scaled = false)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_AiryAi(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp((oreal.t(2) / oreal.t(3)) * x * sqrt(x));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_AiryAi(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static OctupleC airy_ai(dynamic x, bool scaled = false)
        //{
        //    return airy_ai(ocplx.t(x), scaled);
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static OctupleC airy_ai_prime(OctupleC x, bool scaled = false)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_AiryAiPrime(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp((oreal.t(2) / oreal.t(3)) * x * sqrt(x));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_AiryAiPrime(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static OctupleC airy_ai_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_ai_prime(ocplx.t(x), scaled);
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static OctupleC airy_bi(OctupleC x, bool scaled = false)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_AiryBi(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp(-abs(oreal.t(2) / oreal.t(3) * (x * sqrt(x)).real));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_AiryBi(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static OctupleC airy_bi(dynamic x, bool scaled = false)
        //{
        //    return airy_bi(ocplx.t(x), scaled);
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static OctupleC airy_bi_prime(OctupleC x, bool scaled = false)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_AiryBiPrime(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp(-abs(oreal.t(2) / oreal.t(3) * (x * sqrt(x)).real));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_AiryBiPrime(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static OctupleC airy_bi_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_bi_prime(ocplx.t(x), scaled);
        //}



        #endregion



        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static OctupleC kelvin_ber(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.kelvin_ber, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static OctupleC kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(ocplx.t(v), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static OctupleC kelvin_bei(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.kelvin_bei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static OctupleC kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(ocplx.t(v), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static OctupleC kelvin_ker(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.kelvin_ker, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static OctupleC kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(ocplx.t(v), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static OctupleC kelvin_kei(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.kelvin_kei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static OctupleC kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(ocplx.t(v), ocplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static OctupleC kelvin_ber_prime(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.kelvin_ber_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static OctupleC kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(ocplx.t(v), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static OctupleC kelvin_bei_prime(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.kelvin_bei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static OctupleC kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(ocplx.t(v), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static OctupleC kelvin_ker_prime(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.kelvin_ker_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static OctupleC kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(ocplx.t(v), ocplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static OctupleC kelvin_kei_prime(OctupleC v, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2Bool1(aflintc.kelvin_kei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static OctupleC kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(ocplx.t(v), ocplx.t(x), scaled);
        }







        #endregion









        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static OctupleC hyperg_1f1(OctupleC a, OctupleC b, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static OctupleC hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(ocplx.t(a), ocplx.t(b), ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static OctupleC hyperg_1f1r(OctupleC a, OctupleC b, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static OctupleC hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(ocplx.t(a), ocplx.t(b), ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static OctupleC hyperg_u(OctupleC a, OctupleC b, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static OctupleC hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(ocplx.t(a), ocplx.t(b), ocplx.t(x));
        }





        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static OctupleC gamma_upper(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static OctupleC gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(ocplx.t(s), ocplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static OctupleC gamma_q(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static OctupleC gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(ocplx.t(s), ocplx.t(z));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static OctupleC gamma_lower(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static OctupleC gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(ocplx.t(s), ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static OctupleC gamma_p(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static OctupleC gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(ocplx.t(s), ocplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static OctupleC gamma_p_prime(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static OctupleC gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(ocplx.t(s), ocplx.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static OctupleC erf(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static OctupleC erf(dynamic x)
        {
            return erf(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static OctupleC erfc(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static OctupleC erfc(dynamic x)
        {
            return erfc(ocplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static OctupleC erfi(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static OctupleC erfi(dynamic x)
        {
            return erfi(ocplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static OctupleC dawson(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static OctupleC dawson(dynamic x)
        {
            return dawson(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static OctupleC faddeeva(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.faddeeva, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static OctupleC faddeeva(dynamic x)
        {
            return faddeeva(ocplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static OctupleC fresnel_s(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static OctupleC fresnel_s(dynamic x)
        {
            return fresnel_s(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static OctupleC fresnel_c(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static OctupleC fresnel_c(dynamic x)
        {
            return fresnel_c(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static OctupleC ndens(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static OctupleC ndens(dynamic x)
        {
            return ndens(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static OctupleC ndis(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static OctupleC ndis(dynamic x)
        {
            return ndis(ocplx.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static OctupleC exp_integral_en(OctupleC s, OctupleC z)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static OctupleC exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(ocplx.t(s), ocplx.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static OctupleC exp_integral_e1(OctupleC z)
        {
            return exp_integral_en(ocplx.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static OctupleC exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(ocplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static OctupleC exp_integral_ei(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static OctupleC exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static OctupleC sin_integral(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static OctupleC sin_integral(dynamic x)
        {
            return sin_integral(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static OctupleC cos_integral(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static OctupleC cos_integral(dynamic x)
        {
            return cos_integral(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static OctupleC sinh_integral(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static OctupleC sinh_integral(dynamic x)
        {
            return sinh_integral(ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static OctupleC cosh_integral(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static OctupleC cosh_integral(dynamic x)
        {
            return cosh_integral(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static OctupleC log_integral(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static OctupleC log_integral(dynamic x)
        {
            return log_integral(ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static OctupleC log_integral_offset(OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static OctupleC log_integral_offset(dynamic x)
        {
            return log_integral_offset(ocplx.t(x));
        }



        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static OctupleC hermite_h(OctupleC n, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static OctupleC hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(ocplx.t(n), ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static OctupleC hermite_he(OctupleC n, OctupleC x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static OctupleC hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(ocplx.t(n), ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static OctupleC laguerre_l(OctupleC n, OctupleC m, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static OctupleC laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(ocplx.t(n), ocplx.t(m), ocplx.t(x));
        }



        #endregion



        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static OctupleC coulomb_f(OctupleC l, OctupleC eta, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static OctupleC coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(ocplx.t(l), ocplx.t(eta), ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static OctupleC coulomb_g(OctupleC l, OctupleC eta, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static OctupleC coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(ocplx.t(l), ocplx.t(eta), ocplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static OctupleC coulomb_hpos(OctupleC l, OctupleC eta, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CoulombHpos(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CoulombHpos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CoulombHpos(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static OctupleC coulomb_hpos(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hpos(ocplx.t(l), ocplx.t(eta), ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static OctupleC coulomb_hneg(OctupleC l, OctupleC eta, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_CoulombHneg(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_CoulombHneg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_CoulombHneg(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static OctupleC coulomb_hneg(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hneg(ocplx.t(l), ocplx.t(eta), ocplx.t(x));
        }





        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static OctupleC whittaker_m(OctupleC k, OctupleC m, OctupleC x)
        {
            return aflintc.OCplxViaArbCS3(aflintc.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static OctupleC whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(ocplx.t(k), ocplx.t(m), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static OctupleC whittaker_w(OctupleC k, OctupleC m, OctupleC x)
        {
            return aflintc.OCplxViaArbCS3(aflintc.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static OctupleC whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(ocplx.t(k), ocplx.t(m), ocplx.t(x));
        }





        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static OctupleC pcfd(OctupleC n, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static OctupleC pcfd(dynamic n, dynamic x)
        {
            return pcfd(ocplx.t(n), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static OctupleC pcfu(OctupleC a, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static OctupleC pcfu(dynamic a, dynamic x)
        {
            return pcfu(ocplx.t(a), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static OctupleC pcfv(OctupleC a, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static OctupleC pcfv(dynamic a, dynamic x)
        {
            return pcfv(ocplx.t(a), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static OctupleC pcfw(OctupleC a, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static OctupleC pcfw(dynamic a, dynamic x)
        {
            return pcfw(ocplx.t(a), ocplx.t(x));
        }



        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static OctupleC hyperg_2f1(OctupleC a, OctupleC b, OctupleC c, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static OctupleC hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(ocplx.t(a), ocplx.t(b), ocplx.t(c), ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static OctupleC hyperg_2f1r(OctupleC a, OctupleC b, OctupleC c, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static OctupleC hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(ocplx.t(a), ocplx.t(b), ocplx.t(c), ocplx.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static OctupleC chebyshev_t(OctupleC n, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static OctupleC chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(ocplx.t(n), ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static OctupleC chebyshev_u(OctupleC n, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static OctupleC chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(ocplx.t(n), ocplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static OctupleC chebyshev_v(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2(aflintc.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static OctupleC chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(ocplx.t(n), ocplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static OctupleC chebyshev_w(OctupleC n, OctupleC x, bool scaled = false)
        {
            return aflintc.OCplxViaArbCS2(aflintc.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static OctupleC chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(ocplx.t(n), ocplx.t(y));
        }











        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static OctupleC gegenbauer_c(OctupleC n, OctupleC m, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static OctupleC gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(ocplx.t(n), ocplx.t(m), ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static OctupleC jacobi_p(OctupleC n, OctupleC a, OctupleC b, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static OctupleC jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(ocplx.t(n), ocplx.t(a), ocplx.t(b), ocplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static OctupleC legendre_p(OctupleC n, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.legendre_p, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static OctupleC legendre_p(dynamic n, dynamic x)
        {
            return legendre_p(ocplx.t(n), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static OctupleC legendre_q(OctupleC n, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.legendre_q, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static OctupleC legendre_q(dynamic n, dynamic x)
        {
            return legendre_q(ocplx.t(n), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static OctupleC legendre_plm(OctupleC n, OctupleC m, OctupleC x, int type = 1)
        {
            return aflintc.OCplxViaArbCS3Int1(aflintc.legendre_plm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static OctupleC legendre_plm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_plm(ocplx.t(n), ocplx.t(m), ocplx.t(x), type);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static OctupleC legendre_qlm(OctupleC n, OctupleC m, OctupleC x, int type = 1)
        {
            return aflintc.OCplxViaArbCS3Int1(aflintc.legendre_qlm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static OctupleC legendre_qlm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_qlm(ocplx.t(n), ocplx.t(m), ocplx.t(x), type);
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static OctupleC legendre_p(OctupleC n, OctupleC m, OctupleC x)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_LegendreP(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static OctupleC legendre_p(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_p(ocplx.t(n), ocplx.t(m), ocplx.t(x));
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static OctupleC legendre_plm(OctupleC n, OctupleC m, OctupleC x)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_LegendrePv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static OctupleC legendre_plm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_plm(ocplx.t(n), ocplx.t(m), ocplx.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static OctupleC legendre_q(OctupleC n, OctupleC m, OctupleC x)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_LegendreQ(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static OctupleC legendre_q(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_q(ocplx.t(n), ocplx.t(m), ocplx.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static OctupleC legendre_qlm(OctupleC n, OctupleC m, OctupleC x)
        //{
        //    var res = new OctupleC();
        //    Lib_OCplx_Acb_LegendreQv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_OCplx_Acb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static OctupleC legendre_qlm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_qlm(ocplx.t(n), ocplx.t(m), ocplx.t(x));
        //}





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static OctupleC spherical_y(OctupleC n, OctupleC m, OctupleC theta, OctupleC phi)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_SphericalY(res.mpPtr, n.mpPtr, m.mpPtr, theta.mpPtr, phi.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_SphericalY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_SphericalY(IntPtr res, IntPtr n, IntPtr m, IntPtr theta, IntPtr phi);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static OctupleC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(ocplx.t(n), ocplx.t(m), ocplx.t(theta), ocplx.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static OctupleC beta_lower(OctupleC a, OctupleC b, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static OctupleC beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(ocplx.t(a), ocplx.t(b), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static OctupleC ibeta(OctupleC a, OctupleC b, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static OctupleC ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(ocplx.t(a), ocplx.t(b), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static OctupleC ibetac(OctupleC a, OctupleC b, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static OctupleC ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(ocplx.t(a), ocplx.t(b), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static OctupleC ibeta_prime(OctupleC a, OctupleC b, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static OctupleC ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(ocplx.t(a), ocplx.t(b), ocplx.t(x));
        }


        #endregion







        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static OctupleC hyperg_1f2(OctupleC a1, OctupleC b1, OctupleC b2, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static OctupleC hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(ocplx.t(a1), ocplx.t(b1), ocplx.t(b2), ocplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static OctupleC hyperg_1f2r(OctupleC a1, OctupleC b1, OctupleC b2, OctupleC x)
        {
            var res = new OctupleC();
            Lib_OCplx_Acb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_OCplx_Acb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_OCplx_Acb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static OctupleC hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(ocplx.t(a1), ocplx.t(b1), ocplx.t(b2), ocplx.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static OctupleC airy_gi(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static OctupleC airy_gi(dynamic x)
        {
            return airy_gi(ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static OctupleC airy_hi(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static OctupleC airy_hi(dynamic x)
        {
            return airy_hi(ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static OctupleC airy_gi_prime(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static OctupleC airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static OctupleC airy_hi_prime(OctupleC x)
        {
            return aflintc.OCplxViaArbCS1(aflintc.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static OctupleC airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(ocplx.t(x));
        }




        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static OctupleC struve_h(OctupleC v, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static OctupleC struve_h(dynamic v, dynamic x)
        {
            return struve_h(ocplx.t(v), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static OctupleC struve_l(OctupleC v, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static OctupleC struve_l(dynamic v, dynamic x)
        {
            return struve_l(ocplx.t(v), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static OctupleC struve_k(OctupleC v, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static OctupleC struve_k(dynamic v, dynamic x)
        {
            return struve_k(ocplx.t(v), ocplx.t(x));
        }


        public static OctupleC struve_m(OctupleC v, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static OctupleC struve_m(dynamic v, dynamic x)
        {
            return struve_m(ocplx.t(v), ocplx.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static OctupleC anger_j(OctupleC v, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static OctupleC anger_j(dynamic v, dynamic x)
        {
            return anger_j(ocplx.t(v), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static OctupleC weber_e(OctupleC v, OctupleC x)
        {
            return aflintc.OCplxViaArbCS2(aflintc.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static OctupleC weber_e(dynamic v, dynamic x)
        {
            return weber_e(ocplx.t(v), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static OctupleC lommel_s1(OctupleC mu, OctupleC nu, OctupleC x)
        {
            return aflintc.OCplxViaArbCS3(aflintc.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static OctupleC lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(ocplx.t(mu), ocplx.t(nu), ocplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static OctupleC lommel_s2(OctupleC mu, OctupleC nu, OctupleC x)
        {
            return aflintc.OCplxViaArbCS3(aflintc.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static OctupleC lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(ocplx.t(mu), ocplx.t(nu), ocplx.t(x));
        }


        #endregion







        #endregion


    }







}