using System;
using System.Runtime.InteropServices;
using System.Numerics;
using FixedPrecNet;

namespace ArbPrecNet
{




    public class qflint
    {


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Quadruple t(Arb x)
        {
            var res = new Quadruple();
            Lib_QReal_Set_Arb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Set_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Set_Arb(IntPtr res, IntPtr x);


        /// <summary>
        /// Returns a new Single using an Arb number as input
        /// </summary>
        public static Quadruple t(Mpfr x)
        {
            var res = new Quadruple();
            Lib_QReal_Set_Mpfr(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Set_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Set_Mpfr(IntPtr res, IntPtr x);





        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "qflint"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return " qflint"; }
        }


        public static String fmt(Quadruple x)
        {
            return qreal.fmt(x);
        }


        public static String fmt(dynamic x)
        {
            return fmt(qreal.t(x));
        }





        #region Basic floating point functions




        #region General functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Quadruple fma(Quadruple x, Quadruple y, Quadruple z)
        {
            return qreal.fma(x, y, z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Quadruple fma(dynamic x, dynamic y, dynamic z)
        {
            return qreal.fma(x, y, z);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Quadruple fmax(Quadruple x, Quadruple y)
        {
            return qreal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Quadruple fmax(dynamic x, dynamic y)
        {
            return qreal.fmax(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Quadruple fmin(Quadruple x, Quadruple y)
        {
            return qreal.fmin(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Quadruple fmin(dynamic x, dynamic y)
        {
            return qreal.fmin(x, y);
        }


        #endregion



        #region Machine constants


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static Quadruple zero()
        {
            return qreal.zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/negzero/*' />
        public static Quadruple negzero()
        {
            return qreal.negzero();
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static Quadruple one()
        {
            return qreal.one();
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static QuadrupleC onej()
        {
            return qreal.onej();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static Quadruple inf()
        {
            return qreal.inf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/neginf/*' />
        public static Quadruple neginf()
        {
            return qreal.neginf();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static Quadruple nan()
        {
            return qreal.nan();
        }



        #endregion



        #region Properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(Quadruple x)
        {
            return qreal.signbit(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(dynamic x)
        {
            return qreal.signbit(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(Quadruple x)
        {
            return qreal.isfinite(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isfinite/*' />
        public static bool isfinite(dynamic x)
        {
            return qreal.isfinite(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(Quadruple x)
        {
            return qreal.isinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinf/*' />
        public static bool isinf(dynamic x)
        {
            return qreal.isinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static bool isposinf(Quadruple x)
        {
            return qreal.isposinf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isposinf/*' />
        public static bool isposinf(dynamic x)
        {
            return qreal.isposinf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isneginf/*' />
        public static bool isneginf(Quadruple x)
        {
            return qreal.isneginf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isneginf/*' />
        public static bool isneginf(dynamic x)
        {
            return qreal.isneginf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(Quadruple x)
        {
            return qreal.isnan(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnan/*' />
        public static bool isnan(dynamic x)
        {
            return qreal.isnan(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(Quadruple x)
        {
            return qreal.iszero(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/iszero/*' />
        public static bool iszero(dynamic x)
        {
            return qreal.iszero(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(Quadruple x)
        {
            return qreal.isone(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isone/*' />
        public static bool isone(dynamic x)
        {
            return qreal.isone(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinteger/*' />
        public static bool isinteger(Quadruple x)
        {
            return qreal.isinteger(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinteger/*' />
        public static bool isinteger(dynamic x)
        {
            return qreal.isinteger(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnumber/*' />
        public static bool isnumber(Quadruple x)
        {
            return qreal.isnumber(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnumber/*' />
        public static bool isnumber(dynamic x)
        {
            return qreal.isnumber(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isregular/*' />
        public static bool isregular(Quadruple x)
        {
            return qreal.isregular(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isregular/*' />
        public static bool isregular(dynamic x)
        {
            return qreal.isregular(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnormal/*' />
        public static bool isnormal(Quadruple x)
        {
            return qreal.isnormal(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnormal/*' />
        public static bool isnormal(dynamic x)
        {
            return qreal.isnormal(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isunordered/*' />
        public static bool isunordered(Quadruple x, Quadruple y)
        {
            return qreal.isunordered(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isunordered/*' />
        public static bool isunordered(dynamic x, dynamic y)
        {
            return qreal.isunordered(x, y);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint32/*' />
        public static bool fitsint32(Quadruple x)
        {
            return qreal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint32/*' />
        public static bool fitsint32(dynamic x)
        {
            return qreal.fitsint32(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint64/*' />
        public static bool fitsint64(Quadruple x)
        {
            return qreal.fitsint32(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint64/*' />
        public static bool fitsint64(dynamic x)
        {
            return qreal.fitsint32(x);
        }





        #endregion



        #region Integer Related Functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Quadruple nearbyint(Quadruple x)
        {
            return qreal.nearbyint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Quadruple nearbyint(dynamic x)
        {
            return qreal.nearbyint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Quadruple rint(Quadruple x)
        {
            return qreal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Quadruple rint(dynamic x)
        {
            return qreal.rint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(Quadruple x)
        {
            return qreal.lrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(dynamic x)
        {
            return qreal.lrint(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(Quadruple x)
        {
            return qreal.llrint(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(dynamic x)
        {
            return qreal.llrint(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Quadruple ceil(Quadruple x)
        {
            return qreal.ceil(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Quadruple ceil(dynamic x)
        {
            return qreal.ceil(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Quadruple floor(Quadruple x)
        {
            return qreal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Quadruple floor(dynamic x)
        {
            return qreal.floor(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Quadruple trunc(Quadruple x)
        {
            return qreal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Quadruple trunc(dynamic x)
        {
            return qreal.trunc(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Quadruple round(Quadruple x)
        {
            return qreal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Quadruple round(dynamic x)
        {
            return qreal.round(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(Quadruple x)
        {
            return qreal.lround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(dynamic x)
        {
            return qreal.lround(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(Quadruple x)
        {
            return qreal.llround(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(dynamic x)
        {
            return qreal.llround(x);
        }




        #endregion



        #region Floating point functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Quadruple copysign(Quadruple x, Quadruple y)
        {
            return qreal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Quadruple copysign(dynamic x, dynamic y)
        {
            return qreal.copysign(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Quadruple, Int32> frexp(Quadruple x)
        {
            return qreal.frexp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/frexp/*' />
        public static Tuple<Quadruple, Int32> frexp(dynamic x)
        {
            return qreal.frexp(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Quadruple logb(Quadruple x)
        {
            return qreal.logb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Quadruple logb(dynamic x)
        {
            return qreal.logb(x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(Quadruple x)
        {
            return qreal.ilogb(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(dynamic x)
        {
            return qreal.ilogb(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Quadruple ldexp(Quadruple x, Int32 e)
        {
            return qreal.ldexp(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Quadruple ldexp(dynamic x, dynamic e)
        {
            return qreal.ldexp(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Quadruple scalbn(Quadruple x, Int32 e)
        {
            return qreal.scalbn(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Quadruple scalbn(dynamic x, dynamic e)
        {
            return qreal.scalbn(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Quadruple scalbln(Quadruple x, Int32 e)
        {
            return qreal.scalbln(x, e);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Quadruple scalbln(dynamic x, dynamic e)
        {
            return qreal.scalbln(x, e);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Quadruple fdim(Quadruple x, Quadruple y)
        {
            return qreal.fdim(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Quadruple fdim(dynamic x, dynamic y)
        {
            return qreal.fdim(x, y);
        }


        #endregion



        #region Fraction and remainder Related Functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Quadruple, Quadruple> modf(Quadruple x)
        {
            return qreal.modf(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Quadruple, Quadruple> modf(dynamic x)
        {
            return qreal.modf(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Quadruple fmod(Quadruple x, Quadruple y)
        {
            return qreal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Quadruple fmod(dynamic x, dynamic y)
        {
            return qreal.fmod(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Quadruple remainder(Quadruple x, Quadruple y)
        {
            return qreal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Quadruple remainder(dynamic x, dynamic y)
        {
            return qreal.remainder(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Quadruple, Int32> remquo(Quadruple x, Quadruple y)
        {
            return qreal.remquo(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Quadruple, Int32> remquo(dynamic x, dynamic y)
        {
            return qreal.remquo(x, y);
        }

        #endregion



        #region Functions related to mantissa width and exponent range


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/epsilon/*' />
        public static Quadruple epsilon()
        {
            return qreal.epsilon();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Quadruple ulp(Quadruple x)
        {
            return qreal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Quadruple ulp(dynamic x)
        {
            return qreal.ulp(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/maxvalue/*' />
        public static Quadruple maxvalue()
        {
            return qreal.maxvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/lowestvalue/*' />
        public static Quadruple lowestvalue()
        {
            return qreal.lowestvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/minposvalue/*' />
        public static Quadruple minposvalue()
        {
            return qreal.minposvalue();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Quadruple nextafter(Quadruple x, Quadruple y)
        {
            return qreal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextafter/*' />
        public static Quadruple nextafter(dynamic x, dynamic y)
        {
            return qreal.nextafter(x, y);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Quadruple nextabove(Quadruple x)
        {
            return qreal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Quadruple nextabove(dynamic x)
        {
            return qreal.nextabove(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Quadruple nextbelow(Quadruple x)
        {
            return qreal.nextbelow(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Quadruple nextbelow(dynamic x)
        {
            return qreal.nextbelow(x);
        }


        #endregion



        #region Mathematical Constants


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/degree/*' />
        public static Quadruple degree()
        {
            return qreal.degree();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phi/*' />
        public static Quadruple phi()
        {
            return qreal.phi();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln2/*' />
        public static Quadruple ln2()
        {
            return qreal.ln2();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln10/*' />
        public static Quadruple ln10()
        {
            return qreal.ln10();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pi/*' />
        public static Quadruple pi()
        {
            return qreal.pi();
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/e/*' />
        public static Quadruple e()
        {
            return qreal.e();
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/egamma/*' />
        public static Quadruple egamma()
        {
            return qreal.egamma();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/apery/*' />
        public static Quadruple apery()
        {
            return qreal.apery();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/catalan/*' />
        public static Quadruple catalan()
        {
            return qreal.catalan();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/glaisher/*' />
        public static Quadruple glaisher()
        {
            return qreal.glaisher();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/khinchin/*' />
        public static Quadruple khinchin()
        {
            return qreal.khinchin();
        }


        #endregion




        #endregion






        #region Flint Basic Functions




        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Quadruple abs(Quadruple x)
        {
            return qreal.abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Quadruple abs(dynamic x)
        {
            return abs(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Quadruple fabs(Quadruple x)
        {
            return qreal.fabs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Quadruple fabs(dynamic x)
        {
            return fabs(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Quadruple sign(Quadruple x)
        {
            return qreal.sign(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Quadruple sign(dynamic x)
        {
            return sign(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Quadruple real(Quadruple x)
        {
            return x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Quadruple real(dynamic x)
        {
            return real(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Quadruple imag(Quadruple x)
        {
            return qreal.zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Quadruple imag(dynamic x)
        {
            return imag(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Quadruple phase(Quadruple x)
        {
            return qreal.phase(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Quadruple phase(dynamic x)
        {
            return qreal.phase(x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Quadruple conj(Quadruple x)
        {
            return x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Quadruple conj(dynamic x)
        {
            return conj(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Quadruple, Quadruple> polar(Quadruple x)
        {
            return new Tuple<Quadruple, Quadruple>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Quadruple, Quadruple> polar(dynamic x)
        {
            return polar(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static QuadrupleC rect(Quadruple r, Quadruple phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static QuadrupleC rect(dynamic r, dynamic phi)
        {
            return rect(qreal.t(r), qreal.t(phi));
        }





        #endregion




        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Quadruple sqrt(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Quadruple sqrt(dynamic x)
        {
            return sqrt(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Quadruple rsqrt(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Quadruple rsqrt(dynamic x)
        {
            return rsqrt(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Quadruple cbrt(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Quadruple cbrt(dynamic x)
        {
            return cbrt(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Quadruple sqrt1pm1(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Quadruple sqrt1pm1(dynamic x)
        {
            return sqrt1pm1(qreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nthroot/*' />
        public static Quadruple root_si(Quadruple x, Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Root_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Quadruple root_si(dynamic x, Int32 n)
        {
            return root_si(qreal.t(x), n);
        }



        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Quadruple exp(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Quadruple exp(dynamic x)
        {
            return exp(qreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static QuadrupleC expj(Quadruple x)
        {
            return qflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static QuadrupleC expj(dynamic x)
        {
            return qflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static QuadrupleC expjpi(Quadruple x)
        {
            return qflintc.expjpi(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static QuadrupleC expjpi(dynamic x)
        {
            return qflintc.expjpi(x);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Quadruple exp10(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Quadruple exp10(dynamic x)
        {
            return exp10(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Quadruple exp2(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Quadruple exp2(dynamic x)
        {
            return exp2(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Quadruple expm1(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Quadruple expm1(dynamic x)
        {
            return expm1(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Quadruple exp10m1(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Quadruple exp10m1(dynamic x)
        {
            return exp10m1(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Quadruple exp2m1(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Quadruple exp2m1(dynamic x)
        {
            return exp2m1(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Quadruple exprel(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Quadruple exprel(dynamic x)
        {
            return exprel(qreal.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Quadruple logbase(Quadruple x, Quadruple b)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Quadruple logbase(dynamic x, dynamic b)
        {
            return logbase(qreal.t(x), qreal.t(b));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Quadruple log(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Quadruple log(dynamic x)
        {
            return log(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Quadruple log10(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Quadruple log10(dynamic x)
        {
            return log10(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Quadruple log2(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Quadruple log2(dynamic x)
        {
            return log2(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Quadruple log1p(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Quadruple log1p(dynamic x)
        {
            return log1p(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Quadruple log10p1(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Quadruple log10p1(dynamic x)
        {
            return log10p1(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Quadruple log2p1(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Quadruple log2p1(dynamic x)
        {
            return log2p1(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Quadruple log1mexp(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Log1mexp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Log1mexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Log1mexp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Quadruple log1mexp(dynamic x)
        {
            return log1mexp(qreal.t(x));
        }





        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Quadruple sqr(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Quadruple sqr(dynamic x)
        {
            return sqr(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Quadruple cube(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Quadruple cube(dynamic x)
        {
            return cube(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Quadruple hypot(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Quadruple hypot(dynamic x, dynamic y)
        {
            return hypot(qreal.t(x), qreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powi/*' />
        public static Quadruple pow_si(Quadruple x, Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Pow_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Pow_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Quadruple pow_si(dynamic x, Int32 n)
        {
            return pow_si(qreal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Quadruple compound_si(Quadruple x, Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Compound_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Compound_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Compound_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Quadruple compound_si(dynamic x, Int32 n)
        {
            return compound_si(qreal.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Quadruple pow(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Quadruple pow(dynamic x, dynamic y)
        {
            return pow(qreal.t(x), qreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Quadruple powm1(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Quadruple powm1(dynamic x, dynamic y)
        {
            return powm1(qreal.t(x), qreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Quadruple pow1p(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Quadruple pow1p(dynamic x, dynamic y)
        {
            return pow1p(qreal.t(x), qreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Quadruple pow1pm1(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Quadruple pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(qreal.t(x), qreal.t(y));
        }




        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Quadruple sin(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Quadruple sin(dynamic x)
        {
            return sin(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Quadruple cos(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Quadruple cos(dynamic x)
        {
            return cos(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Quadruple tan(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Quadruple tan(dynamic x)
        {
            return tan(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Quadruple cot(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Quadruple cot(dynamic x)
        {
            return cot(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Quadruple sec(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Quadruple sec(dynamic x)
        {
            return sec(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Quadruple csc(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Quadruple csc(dynamic x)
        {
            return csc(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Quadruple sinc(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Quadruple sinc(dynamic x)
        {
            return sinc(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Quadruple sinpi(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Quadruple sinpi(dynamic x)
        {
            return sinpi(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Quadruple cospi(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Quadruple cospi(dynamic x)
        {
            return cospi(qreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Quadruple tanpi(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Quadruple tanpi(dynamic x)
        {
            return tanpi(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Quadruple cotpi(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Quadruple cotpi(dynamic x)
        {
            return cotpi(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Quadruple cscpi(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_SinPi(res.mpPtr, x.mpPtr);
            return 1/res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Quadruple cscpi(dynamic x)
        {
            return cscpi(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Quadruple secpi(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_CosPi(res.mpPtr, x.mpPtr);
            return 1 / res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Quadruple secpi(dynamic x)
        {
            return secpi(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Quadruple sincpi(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Quadruple sincpi(dynamic x)
        {
            return sincpi(qreal.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Quadruple sinh(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Quadruple sinh(dynamic x)
        {
            return sinh(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Quadruple cosh(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Quadruple cosh(dynamic x)
        {
            return cosh(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Quadruple tanh(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Quadruple tanh(dynamic x)
        {
            return tanh(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Quadruple csch(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Quadruple csch(dynamic x)
        {
            return csch(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Quadruple sech(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Quadruple sech(dynamic x)
        {
            return sech(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Quadruple coth(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Quadruple coth(dynamic x)
        {
            return coth(qreal.t(x));
        }




        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Quadruple asin(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Quadruple asin(dynamic x)
        {
            return asin(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Quadruple acos(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Quadruple acos(dynamic x)
        {
            return acos(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Quadruple atan2(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Atan2(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Atan2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Atan2(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Quadruple atan2(dynamic x, dynamic y)
        {
            return atan2(qreal.t(x), qreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Quadruple atan(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Quadruple atan(dynamic x)
        {
            return atan(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Quadruple acsc(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Quadruple acsc(dynamic x)
        {
            return acsc(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Quadruple asec(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Quadruple asec(dynamic x)
        {
            return asec(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Quadruple acot(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Quadruple acot(dynamic x)
        {
            return acot(qreal.t(x));
        }



        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Quadruple asinh(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Quadruple asinh(dynamic x)
        {
            return asinh(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Quadruple acosh(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Quadruple acosh(dynamic x)
        {
            return acosh(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Quadruple atanh(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Quadruple atanh(dynamic x)
        {
            return atanh(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Quadruple acsch(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Quadruple acsch(dynamic x)
        {
            return acsch(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Quadruple asech(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Quadruple asech(dynamic x)
        {
            return asech(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Quadruple acoth(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Quadruple acoth(dynamic x)
        {
            return acoth(qreal.t(x));
        }



        #endregion



        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Quadruple gamma(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Quadruple gamma(dynamic x)
        {
            return gamma(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Quadruple rgamma(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Quadruple rgamma(dynamic x)
        {
            return rgamma(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Quadruple lgamma(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Quadruple lgamma(dynamic x)
        {
            return lgamma(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Quadruple rising_factorial(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Quadruple rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(qreal.t(x), qreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Quadruple beta(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Quadruple beta(dynamic x, dynamic y)
        {
            return beta(qreal.t(x), qreal.t(y));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Quadruple gamma1pm1(Quadruple x)
        {
            return aflint.QRealViaArbS1(aflint.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Quadruple gamma1pm1(dynamic x)
        {
            return gamma1pm1(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Quadruple factorial(Quadruple x)
        {
            return aflint.QRealViaArbS1(aflint.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Quadruple factorial(dynamic x)
        {
            return factorial(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Quadruple doublefactorial(Quadruple x)
        {
            return aflint.QRealViaArbS1(aflint.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Quadruple doublefactorial(dynamic x)
        {
            return doublefactorial(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Quadruple falling_factorial(Quadruple a, Quadruple n)
        {
            return aflint.QRealViaArbS2(aflint.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Quadruple falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(qreal.t(a), qreal.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Quadruple gamma_ratio(Quadruple a, Quadruple b)
        {
            return aflint.QRealViaArbS2(aflint.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Quadruple gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(qreal.t(a), qreal.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Quadruple gamma_delta_ratio(Quadruple a, Quadruple delta)
        {
            return aflint.QRealViaArbS2(aflint.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Quadruple gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(qreal.t(a), qreal.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Quadruple binomial(Quadruple n, Quadruple k)
        {
            return aflint.QRealViaArbS2(aflint.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Quadruple binomial(dynamic n, dynamic k)
        {
            return binomial(qreal.t(n), qreal.t(k));
        }







        #endregion



        #region Miscellaneous


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Quadruple lambert_w0(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_LambertW0(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_LambertW0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_LambertW0(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Quadruple lambert_w0(dynamic x)
        {
            return lambert_w0(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Quadruple lambert_wm1(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_LambertWm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_LambertWm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_LambertWm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Quadruple lambert_wm1(dynamic x)
        {
            return lambert_wm1(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static QuadrupleC lambert_wk(Quadruple x, int k)
        {
            return qflintc.lambert_wk(qcplx.t(x), k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static QuadrupleC lambert_wk(dynamic x, int k)
        {
            return lambert_wk(qreal.t(x), k);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Quadruple agm(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Quadruple agm(dynamic x, dynamic y)
        {
            return agm(qreal.t(x), qreal.t(y));
        }







        #endregion





        #endregion






        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Quadruple m_elliptic_k(Quadruple m)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Quadruple m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Quadruple m_elliptic_e(Quadruple m)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Quadruple m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Quadruple m_elliptic_pi(Quadruple n, Quadruple m)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Quadruple m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(qreal.t(x), qreal.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Quadruple m_elliptic_f(Quadruple phi, Quadruple m)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Quadruple m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(qreal.t(phi), qreal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Quadruple m_elliptic_e_inc(Quadruple phi, Quadruple m)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Quadruple m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(qreal.t(phi), qreal.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Quadruple m_elliptic_pi_inc(Quadruple n, Quadruple phi, Quadruple m)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Quadruple m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(qreal.t(n), qreal.t(phi), qreal.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Quadruple elliptic_k(Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Quadruple elliptic_k(dynamic k)
        {
            return elliptic_k(qreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Quadruple elliptic_e(Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Quadruple elliptic_e(dynamic k)
        {
            return elliptic_e(qreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Quadruple elliptic_pi(Quadruple n, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Quadruple elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(qreal.t(n), qreal.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Quadruple elliptic_f(Quadruple phi, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Quadruple elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(qreal.t(phi), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Quadruple elliptic_e_inc(Quadruple phi, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Quadruple elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(qreal.t(phi), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Quadruple elliptic_pi_inc(Quadruple n, Quadruple phi, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Quadruple elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(qreal.t(n), qreal.t(phi), qreal.t(k));
        }




        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Quadruple elliptic_rc(Quadruple x, Quadruple y)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Quadruple elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(qreal.t(x), qreal.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Quadruple elliptic_rf(Quadruple x, Quadruple y, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Quadruple elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(qreal.t(x), qreal.t(y), qreal.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Quadruple elliptic_rg(Quadruple x, Quadruple y, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Quadruple elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(qreal.t(x), qreal.t(y), qreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Quadruple elliptic_rd(Quadruple x, Quadruple y, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Quadruple elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(qreal.t(x), qreal.t(y), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Quadruple elliptic_rj(Quadruple x, Quadruple y, Quadruple z, Quadruple w)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Quadruple elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(qreal.t(x), qreal.t(y), qreal.t(z), qreal.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Quadruple jacobi_theta1(Quadruple x, Quadruple q)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Quadruple jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(qreal.t(x), qreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Quadruple jacobi_theta2(Quadruple x, Quadruple q)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Quadruple jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(qreal.t(x), qreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Quadruple jacobi_theta3(Quadruple x, Quadruple q)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Quadruple jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(qreal.t(x), qreal.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Quadruple jacobi_theta4(Quadruple x, Quadruple q)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Quadruple jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(qreal.t(x), qreal.t(q));
        }




        #endregion



        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Quadruple jacobi_sn(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Quadruple jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Quadruple jacobi_cn(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Quadruple jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Quadruple jacobi_dn(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Quadruple jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Quadruple jacobi_ns(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Quadruple jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Quadruple jacobi_nc(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Quadruple jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Quadruple jacobi_nd(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Quadruple jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Quadruple jacobi_sc(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Quadruple jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Quadruple jacobi_sd(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Quadruple jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Quadruple jacobi_dc(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Quadruple jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Quadruple jacobi_ds(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Quadruple jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Quadruple jacobi_cs(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Quadruple jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(qreal.t(x), qreal.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Quadruple jacobi_cd(Quadruple x, Quadruple k)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QReal_Arb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Quadruple jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(qreal.t(x), qreal.t(k));
        }








        #endregion



        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Quadruple lerch_phi(Quadruple s, Quadruple z, Quadruple a)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Quadruple lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(qreal.t(s), qreal.t(z), qreal.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static QuadrupleC lerch_zeta(Quadruple lambda1, Quadruple alpha, Quadruple s)
        {
            var res = qflintc.lerch_zeta(lambda1, alpha, s);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static QuadrupleC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(qreal.t(lambda1), qreal.t(alpha), qreal.t(s));
        }





        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Quadruple polygamma(Quadruple s, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Quadruple polygamma(dynamic s, dynamic z)
        {
            return polygamma(qreal.t(s), qreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Quadruple trigamma(Quadruple x)
        {
            return polygamma(1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Quadruple trigamma(dynamic x)
        {
            return trigamma(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Quadruple digamma(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Quadruple digamma(dynamic x)
        {
            return digamma(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Quadruple harmonic(Quadruple x)
        {
            QuadrupleC res = qflintc.harmonic(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Quadruple harmonic(dynamic x)
        {
            return harmonic(qreal.t(x));
        }




        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Quadruple polylog(Quadruple s, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Quadruple polylog(dynamic s, dynamic z)
        {
            return polylog(qreal.t(s), qreal.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Quadruple trilog(Quadruple x)
        {
            QuadrupleC res = qflintc.trilog(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Quadruple trilog(dynamic x)
        {
            return trilog(qreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Quadruple dilog(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Quadruple dilog(dynamic x)
        {
            return dilog(qreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Quadruple clausen_sin(Quadruple s, Quadruple z)
        {
            QuadrupleC res = qflintc.clausen_sin(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Quadruple clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(qreal.t(s), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Quadruple clausen_cos(Quadruple s, Quadruple z)
        {
            QuadrupleC res = qflintc.clausen_cos(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Quadruple clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(qreal.t(s), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Quadruple clausen2(Quadruple x)
        {
            return clausen_sin(qreal.t(2), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Quadruple clausen2(dynamic x)
        {
            return clausen_sin(qreal.t(2), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Quadruple bose_einstein(Quadruple s, Quadruple z)
        {
            QuadrupleC res = qflintc.bose_einstein(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Quadruple bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(qreal.t(s), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Quadruple fermi_dirac(Quadruple s, Quadruple z)
        {
            QuadrupleC res = qflintc.fermi_dirac(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Quadruple fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(qreal.t(s), qreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Quadruple legendre_chi(Quadruple s, Quadruple z)
        {
            QuadrupleC res = qflintc.legendre_chi(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Quadruple legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(qreal.t(s), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Quadruple inverse_tan_integral(Quadruple s, Quadruple z)
        {
            QuadrupleC res = qflintc.inverse_tan_integral(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Quadruple inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(qreal.t(s), qreal.t(z));
        }







        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Quadruple hurwitz_zeta(Quadruple s, Quadruple a)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_HurwitzZeta(res.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Quadruple hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(qreal.t(s), qreal.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Quadruple harmonic2(Quadruple z, Quadruple r)
        {
            QuadrupleC res = qflintc.harmonic2(z, r);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Quadruple harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(qreal.t(z), qreal.t(r));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Quadruple bernoulli(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Bernoulli_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Bernoulli_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Bernoulli_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Quadruple bernpoly(Quadruple x, Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Quadruple bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(qreal.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulernum/*' />
        public static Quadruple eulernum(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Euler_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Euler_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Euler_ui(IntPtr res, Int32 n);






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Quadruple eulerpoly(Quadruple x, Int32 n)
        {
            QuadrupleC res = qflintc.eulerpoly(x, n);
            return res.real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Quadruple eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(qreal.t(x), n);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Quadruple barnes_g(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Quadruple barnes_g(dynamic x)
        {
            return barnes_g(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Quadruple logbarnes_g(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Quadruple logbarnes_g(dynamic x)
        {
            return logbarnes_g(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Quadruple hyperfactorial(Quadruple x)
        {
            QuadrupleC res = qflintc.hyperfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Quadruple hyperfactorial(dynamic x)
        {
            return hyperfactorial(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Quadruple superfactorial(Quadruple x)
        {
            QuadrupleC res = qflintc.superfactorial(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Quadruple superfactorial(dynamic x)
        {
            return superfactorial(qreal.t(x));
        }







        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Quadruple zeta(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Quadruple zeta(dynamic x)
        {
            return zeta(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Quadruple zetam1(Quadruple x)
        {
            QuadrupleC res = qflintc.zetam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Quadruple zetam1(dynamic x)
        {
            return zetam1(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Quadruple hardy_theta(Quadruple x)
        {
            QuadrupleC res = qflintc.hardy_theta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Quadruple hardy_theta(dynamic x)
        {
            return hardy_theta(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Quadruple hardy_z(Quadruple x)
        {
            QuadrupleC res = qflintc.hardy_z(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Quadruple hardy_z(dynamic x)
        {
            return hardy_z(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Quadruple riemann_xi(Quadruple x)
        {
            QuadrupleC res = qflintc.riemann_xi(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Quadruple riemann_xi(dynamic x)
        {
            return riemann_xi(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Quadruple dirichlet_eta(Quadruple x)
        {
            QuadrupleC res = qflintc.dirichlet_eta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Quadruple dirichlet_eta(dynamic x)
        {
            return dirichlet_eta(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Quadruple dirichlet_etam1(Quadruple x)
        {
            QuadrupleC res = qflintc.dirichlet_etam1(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Quadruple dirichlet_etam1(dynamic x)
        {
            return dirichlet_etam1(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Quadruple dirichlet_beta(Quadruple x)
        {
            QuadrupleC res = qflintc.dirichlet_beta(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Quadruple dirichlet_beta(dynamic x)
        {
            return dirichlet_beta(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Quadruple dirichlet_lambda(Quadruple x)
        {
            QuadrupleC res = qflintc.dirichlet_lambda(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Quadruple dirichlet_lambda(dynamic x)
        {
            return dirichlet_lambda(qreal.t(x));
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Quadruple backlund_s(Quadruple x)
        //{
        //    var res = new Quadruple();
        //    Lib_QReal_Arb_BacklundS(res.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_BacklundS", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QReal_Arb_BacklundS(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Quadruple backlund_s(dynamic x)
        //{
        //    return zeta(qreal.t(x));
        //}





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/grampoint/*' />
        //public static Quadruple grampoint(Int32 n)
        //{
        //    var res = new Quadruple();
        //    Lib_QReal_Arb_GramPoint_ui(res.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_GramPoint_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QReal_Arb_GramPoint_ui(IntPtr res, Int32 n);







        #endregion



        #region Additional numbertheoretic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bell/*' />
        public static Quadruple bell(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Bell_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Bell_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Bell_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/partitions/*' />
        public static Quadruple partitions(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Partitions_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Partitions_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Partitions_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/primorial/*' />
        public static Quadruple primorial(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Primorial_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Primorial_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Primorial_ui(IntPtr res, Int32 n);





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Quadruple hyperg_0f1(Quadruple a, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Quadruple hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(qreal.t(a), qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Quadruple hyperg_0f1r(Quadruple a, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Quadruple hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(qreal.t(a), qreal.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Quadruple bessel_jv(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Quadruple bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(qreal.t(nu), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Quadruple bessel_yv(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Quadruple bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(qreal.t(nu), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Quadruple bessel_iv(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Quadruple bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(qreal.t(nu), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Quadruple bessel_kv(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Quadruple bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(qreal.t(nu), qreal.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Quadruple bessel_jv_prime(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Quadruple bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(qreal.t(nu), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Quadruple bessel_yv_prime(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Quadruple bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(qreal.t(nu), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Quadruple bessel_iv_prime(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Quadruple bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(qreal.t(nu), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Quadruple bessel_kv_prime(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Quadruple bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(qreal.t(nu), qreal.t(x), scaled);
        }






        #endregion






        #region 0F1: Spherical Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Quadruple sph_bessel_jn(Quadruple n, Quadruple x, bool scaled = false)
        {
            if (!qreal.isinteger(n)) return qreal.nan();

            if (qreal.isnan(x)) return qreal.nan();
            if (qreal.isinf(x)) return qreal.zero();
            if (qreal.isneginf(x)) return qreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return qreal.one();
                    else return qreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return qreal.neginf(); else return qreal.nan();
                }
            }
            return qflintc.sph_bessel_jn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Quadruple sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(qreal.t(n), qreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Quadruple sph_bessel_yn(Quadruple n, Quadruple x, bool scaled = false)
        {
            if (!qreal.isinteger(n)) return qreal.nan();

            if (qreal.isnan(x)) return qreal.nan();
            if (qreal.isinf(x)) return qreal.zero();
            if (qreal.isneginf(x)) return qreal.zero();
            if (x == 0.0)
            {
                if (n < 0)
                {
                    if ((n == -1)) return qreal.one();
                    else return qreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 != 0) return qreal.neginf(); else return qreal.nan();
                }
            }
            return qflintc.sph_bessel_yn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Quadruple sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(qreal.t(n), qreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Quadruple sph_bessel_in(Quadruple n, Quadruple x, bool scaled = false)
        {
            if (!qreal.isinteger(n)) return qreal.nan();

            if (qreal.isnan(x)) return qreal.nan();
            if (qreal.isinf(x)) return qreal.inf();
            if (qreal.isneginf(x)) return qreal.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return qreal.one();
                    else return qreal.zero();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return qreal.neginf(); else return qreal.nan();
                }
            }
            return qflintc.sph_bessel_in(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Quadruple sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(qreal.t(n), qreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Quadruple sph_bessel_kn(Quadruple n, Quadruple x, bool scaled = false)
        {
            if (!qreal.isinteger(n)) return qreal.nan();

            if (qreal.isnan(x)) return qreal.nan();
            if (qreal.isinf(x)) return qreal.zero();
            if (qreal.isneginf(x)) return qreal.neginf();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if (lrint(n) % 2 == 0) return qreal.nan(); else return qreal.inf();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return qreal.inf(); else return qreal.nan();
                }
            }
            return qflintc.sph_bessel_kn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Quadruple sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(qreal.t(n), qreal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Quadruple besselpoly(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.besselpoly, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static Quadruple besselpoly(dynamic nu, dynamic x, bool scaled = false)
        {
            return besselpoly(qreal.t(nu), qreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Quadruple besseltheta(Quadruple nu, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2Bool1(aflint.besseltheta, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static Quadruple besseltheta(dynamic nu, dynamic x, bool scaled = false)
        {
            return besseltheta(qreal.t(nu), qreal.t(x), scaled);
        }






        #endregion





        #region Spherical Bessel functions, first derivative




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Quadruple sph_bessel_jn_prime(Quadruple n, Quadruple x, bool scaled = false)
        {
            if (!qreal.isinteger(n)) return qreal.nan();

            if (qreal.isnan(x)) return qreal.nan();
            if (qreal.isinf(x)) return qreal.zero();
            if (qreal.isneginf(x)) return qreal.zero();
            if (x == 0.0)
            {
                if (n == 1) return 1 / qreal.t(3);
                if (n >= 0) return qreal.zero();
                else
                {
                    if (lrint(n) % 2 != 0) return qreal.neginf(); else return qreal.nan();
                }
            }
            return qflintc.sph_bessel_jn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Quadruple sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(qreal.t(n), qreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Quadruple sph_bessel_yn_prime(Quadruple n, Quadruple x, bool scaled = false)
        {
            if (!qreal.isinteger(n)) return qreal.nan();

            if (qreal.isnan(x)) return qreal.nan();
            if (qreal.isinf(x)) return qreal.zero();
            if (qreal.isneginf(x)) return qreal.zero();
            if (x == 0.0)
            {
                if (n == -2) return -1 / qreal.t(3);
                if (n < 0) return qreal.zero();
                else
                {
                    if (lrint(n) % 2 == 0) return qreal.inf(); else return qreal.nan();
                }
            }
            return qflintc.sph_bessel_yn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Quadruple sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(qreal.t(n), qreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Quadruple sph_bessel_in_prime(Quadruple n, Quadruple x, bool scaled = false)
        {
            if (!qreal.isinteger(n)) return qreal.nan();

            if (qreal.isnan(x)) return qreal.nan();
            if (qreal.isinf(x)) return qreal.inf();
            if (qreal.isneginf(x))
            {
                if (lrint(n) % 2 == 0) return qreal.neginf(); else return qreal.inf();
            }
            if (x == 0.0)
            {
                if (n == 0) return qreal.zero();
                if (n < 0)
                {
                    if (lrint(n) % 2 != 0) return qreal.neginf(); else return qreal.nan();
                }
            }
            return qflintc.sph_bessel_in_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Quadruple sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(qreal.t(n), qreal.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Quadruple sph_bessel_kn_prime(Quadruple n, Quadruple x, bool scaled = false)
        {
            if (!qreal.isinteger(n)) return qreal.nan();

            if (qreal.isnan(x)) return qreal.nan();
            if (qreal.isinf(x)) return qreal.zero();
            if (qreal.isneginf(x)) return qreal.neginf();
            if (x == 0.0)
            {
                if (((n >= 0) && (lrint(n) % 2 == 0)) || ((n < 0) && (lrint(n) % 2 != 0))) return qreal.neginf();
                else return qreal.nan();
            }
            return qflintc.sph_bessel_kn_prime(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Quadruple sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(qreal.t(n), qreal.t(x), scaled);
        }





        #endregion








        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static QuadrupleC hankel_h1(Quadruple v, Quadruple x)
        {
            return bessel_jv(v, x) + qcplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static QuadrupleC hankel_h1(dynamic v, dynamic x)
        {
            return hankel_h1(qreal.t(v), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static QuadrupleC hankel_h2(Quadruple v, Quadruple x)
        {
            return bessel_jv(v, x) - qcplx.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static QuadrupleC hankel_h2(dynamic v, dynamic x)
        {
            return hankel_h2(qreal.t(v), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static QuadrupleC sph_hankel_h1(int n, Quadruple x)
        {
            return sph_bessel_jn(n, x) + qcplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static QuadrupleC sph_hankel_h1(int n, dynamic x)
        {
            return sph_hankel_h1(n, qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static QuadrupleC sph_hankel_h2(int n, Quadruple x)
        {
            return sph_bessel_jn(n, x) - qcplx.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static QuadrupleC sph_hankel_h2(int n, dynamic x)
        {
            return sph_hankel_h2(n, qreal.t(x));
        }






        #endregion






        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Quadruple airy_ai(Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS1Bool1(aflint.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Quadruple airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Quadruple airy_ai_prime(Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS1Bool1(aflint.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Quadruple airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Quadruple airy_bi(Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS1Bool1(aflint.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Quadruple airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Quadruple airy_bi_prime(Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS1Bool1(aflint.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Quadruple airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(qreal.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        public static Quadruple airy_ai_zero(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_AiryAiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_AiryAiZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        public static Quadruple airy_ai_prime_zero(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_AiryAiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_AiryAiPrimeZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        public static Quadruple airy_bi_zero(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_AiryBiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_AiryBiZero(IntPtr res, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        public static Quadruple airy_bi_prime_zero(Int32 n)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_AiryBiPrimeZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_AiryBiPrimeZero(IntPtr res, Int32 n);



        #endregion





        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Quadruple kelvin_ber(Quadruple v, Quadruple x, bool scaled = false)
        {
            return qflintc.kelvin_ber(qcplx.t(v), qcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Quadruple kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(qreal.t(v), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Quadruple kelvin_bei(Quadruple v, Quadruple x, bool scaled = false)
        {
            return qflintc.kelvin_bei(qcplx.t(v), qcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Quadruple kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(qreal.t(v), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Quadruple kelvin_ker(Quadruple v, Quadruple x, bool scaled = false)
        {
            return qflintc.kelvin_ker(qcplx.t(v), qcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Quadruple kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(qreal.t(v), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Quadruple kelvin_kei(Quadruple v, Quadruple x, bool scaled = false)
        {
            return qflintc.kelvin_kei(qcplx.t(v), qcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Quadruple kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(qreal.t(v), qreal.t(x), scaled);
        }






        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Quadruple kelvin_ber_prime(Quadruple v, Quadruple x, bool scaled = false)
        {
            return qflintc.kelvin_ber_prime(qcplx.t(v), qcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Quadruple kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(qreal.t(v), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Quadruple kelvin_bei_prime(Quadruple v, Quadruple x, bool scaled = false)
        {
            return qflintc.kelvin_bei_prime(qcplx.t(v), qcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Quadruple kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(qreal.t(v), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Quadruple kelvin_ker_prime(Quadruple v, Quadruple x, bool scaled = false)
        {
            return qflintc.kelvin_ker_prime(qcplx.t(v), qcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Quadruple kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(qreal.t(v), qreal.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Quadruple kelvin_kei_prime(Quadruple v, Quadruple x, bool scaled = false)
        {
            return qflintc.kelvin_kei_prime(qcplx.t(v), qcplx.t(x), scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Quadruple kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(qreal.t(v), qreal.t(x), scaled);
        }








        #endregion










        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Quadruple hyperg_1f1(Quadruple a, Quadruple b, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Quadruple hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(qreal.t(a), qreal.t(b), qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Quadruple hyperg_1f1r(Quadruple a, Quadruple b, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Quadruple hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(qreal.t(a), qreal.t(b), qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Quadruple hyperg_u(Quadruple a, Quadruple b, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Quadruple hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(qreal.t(a), qreal.t(b), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Quadruple hermite_h(Quadruple n, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Quadruple hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(qreal.t(n), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Quadruple hermite_he(Quadruple n, Quadruple x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Quadruple hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(qreal.t(n), qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Quadruple laguerre_l(Quadruple n, Quadruple m, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Quadruple laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(qreal.t(n), qreal.t(m), qreal.t(x));
        }





        #endregion




        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Quadruple gamma_upper(Quadruple s, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Quadruple gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(qreal.t(s), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Quadruple gamma_q(Quadruple s, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Quadruple gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(qreal.t(s), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Quadruple gamma_lower(Quadruple s, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Quadruple gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(qreal.t(s), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Quadruple gamma_p(Quadruple s, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Quadruple gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(qreal.t(s), qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Quadruple gamma_p_prime(Quadruple s, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Quadruple gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(qreal.t(s), qreal.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Quadruple erf(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Quadruple erf(dynamic x)
        {
            return erf(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Quadruple erfc(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Quadruple erfc(dynamic x)
        {
            return erfc(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Quadruple erf_inv(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Erfinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Erfinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Erfinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Quadruple erf_inv(dynamic x)
        {
            return erf_inv(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Quadruple erfc_inv(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Erfcinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Erfcinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Erfcinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Quadruple erfc_inv(dynamic x)
        {
            return erfc_inv(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Quadruple erfi(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Quadruple erfi(dynamic x)
        {
            return erfi(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Quadruple dawson(Quadruple x)
        {
            return aflint.QRealViaArbS1(aflint.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Quadruple dawson(dynamic x)
        {
            return dawson(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Quadruple fresnel_s(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Quadruple fresnel_s(dynamic x)
        {
            return fresnel_s(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Quadruple fresnel_c(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Quadruple fresnel_c(dynamic x)
        {
            return fresnel_c(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Quadruple ndens(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Quadruple ndens(dynamic x)
        {
            return ndens(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Quadruple ndis(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Quadruple ndis(dynamic x)
        {
            return ndis(qreal.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Quadruple exp_integral_en(Quadruple s, Quadruple z)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Quadruple exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(qreal.t(s), qreal.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Quadruple exp_integral_e1(Quadruple z)
        {
            if (z < 0) return -exp_integral_ei(-z);
            else return exp_integral_en(qreal.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Quadruple exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(qreal.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Quadruple exp_integral_ei(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Quadruple exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Quadruple sin_integral(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Quadruple sin_integral(dynamic x)
        {
            return sin_integral(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Quadruple cos_integral(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Quadruple cos_integral(dynamic x)
        {
            return cos_integral(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Quadruple sinh_integral(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Quadruple sinh_integral(dynamic x)
        {
            return sinh_integral(qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Quadruple cosh_integral(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Quadruple cosh_integral(dynamic x)
        {
            return cosh_integral(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Quadruple log_integral(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Quadruple log_integral(dynamic x)
        {
            return log_integral(qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Quadruple log_integral_offset(Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Quadruple log_integral_offset(dynamic x)
        {
            return log_integral_offset(qreal.t(x));
        }



        #endregion





        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Quadruple coulomb_f(Quadruple l, Quadruple eta, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Quadruple coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(qreal.t(l), qreal.t(eta), qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Quadruple coulomb_g(Quadruple l, Quadruple eta, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Quadruple coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(qreal.t(l), qreal.t(eta), qreal.t(x));
        }



        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Quadruple whittaker_m(Quadruple k, Quadruple m, Quadruple x)
        {
            return aflint.QRealViaArbS3(aflint.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static Quadruple whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(qreal.t(k), qreal.t(m), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Quadruple whittaker_w(Quadruple k, Quadruple m, Quadruple x)
        {
            return aflint.QRealViaArbS3(aflint.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static Quadruple whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(qreal.t(k), qreal.t(m), qreal.t(x));
        }






        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Quadruple pcfd(Quadruple n, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static Quadruple pcfd(dynamic n, dynamic x)
        {
            return pcfd(qreal.t(n), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Quadruple pcfu(Quadruple a, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static Quadruple pcfu(dynamic a, dynamic x)
        {
            return pcfu(qreal.t(a), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Quadruple pcfv(Quadruple a, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static Quadruple pcfv(dynamic a, dynamic x)
        {
            return pcfv(qreal.t(a), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Quadruple pcfw(Quadruple a, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static Quadruple pcfw(dynamic a, dynamic x)
        {
            return pcfw(qreal.t(a), qreal.t(x));
        }





        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Quadruple hyperg_2f1(Quadruple a, Quadruple b, Quadruple c, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Quadruple hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(qreal.t(a), qreal.t(b), qreal.t(c), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Quadruple hyperg_2f1r(Quadruple a, Quadruple b, Quadruple c, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Quadruple hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(qreal.t(a), qreal.t(b), qreal.t(c), qreal.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Quadruple chebyshev_t(Quadruple n, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Quadruple chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(qreal.t(n), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Quadruple chebyshev_u(Quadruple n, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Quadruple chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(qreal.t(n), qreal.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static Quadruple chebyshev_v(Quadruple n, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2(aflint.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Quadruple chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(qreal.t(n), qreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static Quadruple chebyshev_w(Quadruple n, Quadruple x, bool scaled = false)
        {
            return aflint.QRealViaArbS2(aflint.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Quadruple chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(qreal.t(n), qreal.t(y));
        }








        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Quadruple gegenbauer_c(Quadruple n, Quadruple m, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Quadruple gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(qreal.t(n), qreal.t(m), qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Quadruple jacobi_p(Quadruple n, Quadruple a, Quadruple b, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Quadruple jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(qreal.t(n), qreal.t(a), qreal.t(b), qreal.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Quadruple legendre_p(Quadruple n, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.legendre_p, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_p/*' />
        public static Quadruple legendre_p(dynamic n, dynamic y)
        {
            return legendre_p(qreal.t(n), qreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Quadruple legendre_q(Quadruple n, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.legendre_q, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_q/*' />
        public static Quadruple legendre_q(dynamic n, dynamic y)
        {
            return legendre_q(qreal.t(n), qreal.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Quadruple legendre_plm(Quadruple n, Quadruple m, Quadruple x)
        {
            return aflint.QRealViaArbS3(aflint.legendre_plm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_plm/*' />
        public static Quadruple legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(qreal.t(n), qreal.t(m), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Quadruple legendre_qlm(Quadruple n, Quadruple m, Quadruple x)
        {
            return aflint.QRealViaArbS3(aflint.legendre_qlm, n, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/legendre_qlm/*' />
        public static Quadruple legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(qreal.t(n), qreal.t(m), qreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_plm/*' />
        public static Quadruple toroidal_plm(Quadruple l, Quadruple m, Quadruple x)
        {
            return aflint.QRealViaArbS3(aflint.toroidal_plm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_plm/*' />
        public static Quadruple toroidal_plm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_plm(qreal.t(l), qreal.t(m), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_qlm/*' />
        public static Quadruple toroidal_qlm(Quadruple l, Quadruple m, Quadruple x)
        {
            return aflint.QRealViaArbS3(aflint.toroidal_qlm, l, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/toroidal_qlm/*' />
        public static Quadruple toroidal_qlm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_qlm(qreal.t(l), qreal.t(m), qreal.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static QuadrupleC spherical_y(Quadruple n, Quadruple m, Quadruple theta, Quadruple phi)
        {
            return qflintc.spherical_y(qcplx.t(n), qcplx.t(m), qcplx.t(theta), qcplx.t(phi));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static QuadrupleC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(qreal.t(n), qreal.t(m), qreal.t(theta), qreal.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Quadruple beta_lower(Quadruple a, Quadruple b, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Quadruple beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(qreal.t(a), qreal.t(b), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Quadruple ibeta(Quadruple a, Quadruple b, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Quadruple ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(qreal.t(a), qreal.t(b), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Quadruple ibetac(Quadruple a, Quadruple b, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Quadruple ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(qreal.t(a), qreal.t(b), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Quadruple ibeta_prime(Quadruple a, Quadruple b, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Quadruple ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(qreal.t(a), qreal.t(b), qreal.t(x));
        }


        #endregion



        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Quadruple hyperg_1f2(Quadruple a1, Quadruple b1, Quadruple b2, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Quadruple hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(qreal.t(a1), qreal.t(b1), qreal.t(b2), qreal.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Quadruple hyperg_1f2r(Quadruple a1, Quadruple b1, Quadruple b2, Quadruple x)
        {
            var res = new Quadruple();
            Lib_QReal_Arb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QReal_Arb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QReal_Arb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Quadruple hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(qreal.t(a1), qreal.t(b1), qreal.t(b2), qreal.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Quadruple airy_gi(Quadruple x)
        {
            return aflint.QRealViaArbS1(aflint.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Quadruple airy_gi(dynamic x)
        {
            return airy_gi(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Quadruple airy_hi(Quadruple x)
        {
            return aflint.QRealViaArbS1(aflint.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Quadruple airy_hi(dynamic x)
        {
            return airy_hi(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Quadruple airy_gi_prime(Quadruple x)
        {
            return aflint.QRealViaArbS1(aflint.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Quadruple airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Quadruple airy_hi_prime(Quadruple x)
        {
            return aflint.QRealViaArbS1(aflint.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Quadruple airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(qreal.t(x));
        }




        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Quadruple struve_h(Quadruple v, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Quadruple struve_h(dynamic v, dynamic x)
        {
            return struve_h(qreal.t(v), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Quadruple struve_l(Quadruple v, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Quadruple struve_l(dynamic v, dynamic x)
        {
            return struve_l(qreal.t(v), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Quadruple struve_k(Quadruple v, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Quadruple struve_k(dynamic v, dynamic x)
        {
            return struve_k(qreal.t(v), qreal.t(x));
        }


        public static Quadruple struve_m(Quadruple v, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static Quadruple struve_m(dynamic v, dynamic x)
        {
            return struve_m(qreal.t(v), qreal.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Quadruple anger_j(Quadruple v, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Quadruple anger_j(dynamic v, dynamic x)
        {
            return anger_j(qreal.t(v), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Quadruple weber_e(Quadruple v, Quadruple x)
        {
            return aflint.QRealViaArbS2(aflint.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Quadruple weber_e(dynamic v, dynamic x)
        {
            return weber_e(qreal.t(v), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Quadruple lommel_s1(Quadruple mu, Quadruple nu, Quadruple x)
        {
            return aflint.QRealViaArbS3(aflint.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Quadruple lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(qreal.t(mu), qreal.t(nu), qreal.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Quadruple lommel_s2(Quadruple mu, Quadruple nu, Quadruple x)
        {
            return aflint.QRealViaArbS3(aflint.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Quadruple lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(qreal.t(mu), qreal.t(nu), qreal.t(x));
        }


        #endregion







        #endregion





    }







    public class qflintc
    {



        /// <summary>
        /// Returns a new QuadrupleC using an ArbC number as input
        /// </summary>
        public static QuadrupleC t(ArbC x)
        {
            QuadrupleC res = qcplx.t(0);
            Lib_QCplx_Set_Acb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Set_Acb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Set_Acb(IntPtr res, IntPtr x);


        /// <summary>
        /// Returns a new QuadrupleC using an MpfrC number as input
        /// </summary>
        public static QuadrupleC t(MpfrC x)
        {
            QuadrupleC res = qcplx.t(0);
            Lib_QCplx_Set_MpfrC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Set_MpfrC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Set_MpfrC(IntPtr res, IntPtr x);






        public static String fmt(QuadrupleC z)
        {
            return qcplx.fmt(z);
        }

        public static String fmt(Quadruple x)
        {
            return qreal.fmt(x);
        }


        public static String fmt(dynamic z)
        {
            return fmt(qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "qflintc"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "qflintc"; }
        }



        public static qflint realctx
        {
            get { return new qflint(); }
        }




        #region Flint Basic Functions


        #region Complex components


        public static Quadruple abs(QuadrupleC z)
        {
            return qcplx.abs(z);
        }


        public static Quadruple abs(dynamic z)
        {
            return qcplx.abs(z);
        }


        public static Quadruple fabs(QuadrupleC z)
        {
            return qcplx.fabs(z);
        }


        public static Quadruple fabs(dynamic z)
        {
            return qcplx.fabs(z);
        }


        public static QuadrupleC sign(QuadrupleC z)
        {
            return qcplx.sign(z);
        }


        public static QuadrupleC sign(dynamic z)
        {
            return qcplx.sign(z);
        }



        public static Quadruple real(QuadrupleC z)
        {
            return z.real;
        }


        public static Quadruple real(dynamic z)
        {
            return real(qcplx.t(z));
        }


        public static Quadruple imag(QuadrupleC z)
        {
            return z.imag;
        }


        public static Quadruple imag(dynamic z)
        {
            return imag(qcplx.t(z));
        }


        public static Quadruple phase(QuadrupleC z)
        {
            return qcplx.phase(z);
        }


        public static Quadruple phase(dynamic z)
        {
            return qcplx.phase(z);
        }


        public static QuadrupleC conj(QuadrupleC z)
        {
            return qcplx.conj(z);
        }


        public static QuadrupleC conj(dynamic z)
        {
            return qcplx.conj(z);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Quadruple, Quadruple> polar(QuadrupleC x)
        {
            return new Tuple<Quadruple, Quadruple>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Quadruple, Quadruple> polar(dynamic x)
        {
            return polar(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static QuadrupleC rect(Quadruple r, Quadruple phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static QuadrupleC rect(dynamic r, dynamic phi)
        {
            return rect(qreal.t(r), qreal.t(phi));
        }





        #endregion




        #region Roots and quadratic, cubic, and quartic 


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static QuadrupleC sqrt(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static QuadrupleC sqrt(dynamic x)
        {
            return sqrt(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static QuadrupleC rsqrt(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static QuadrupleC rsqrt(dynamic x)
        {
            return sqrt(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static QuadrupleC cbrt(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static QuadrupleC cbrt(dynamic x)
        {
            return cbrt(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static QuadrupleC sqrt1pm1(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static QuadrupleC sqrt1pm1(dynamic x)
        {
            return cbrt(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static QuadrupleC unitroot(Int32 n)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_UnitRoot_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_UnitRoot_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_UnitRoot_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static QuadrupleC root_si(QuadrupleC x, Int32 n)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Root_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Root_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Root_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static QuadrupleC root_si(dynamic x, Int32 n)
        {
            return root_si(qcplx.t(x), n);
        }




        #endregion



        #region Exponential and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static QuadrupleC exp(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static QuadrupleC exp(dynamic x)
        {
            return exp(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static QuadrupleC expj(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Expj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Expj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Expj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static QuadrupleC expj(dynamic x)
        {
            return expj(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static QuadrupleC expjpi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Expjpi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Expjpi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Expjpi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static QuadrupleC expjpi(dynamic x)
        {
            return expjpi(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static QuadrupleC exp10(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static QuadrupleC exp10(dynamic x)
        {
            return exp10(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static QuadrupleC exp2(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static QuadrupleC exp2(dynamic x)
        {
            return exp2(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static QuadrupleC expm1(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static QuadrupleC expm1(dynamic x)
        {
            return expm1(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static QuadrupleC exp10m1(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static QuadrupleC exp10m1(dynamic x)
        {
            return exp10m1(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static QuadrupleC exp2m1(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static QuadrupleC exp2m1(dynamic x)
        {
            return exp2m1(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static QuadrupleC exprel(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static QuadrupleC exprel(dynamic x)
        {
            return exprel(qcplx.t(x));
        }




        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static QuadrupleC logbase(QuadrupleC x, QuadrupleC b)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static QuadrupleC logbase(dynamic x, dynamic b)
        {
            return logbase(qcplx.t(x), qcplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static QuadrupleC log(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static QuadrupleC log(dynamic x)
        {
            return log(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static QuadrupleC log10(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static QuadrupleC log10(dynamic x)
        {
            return log10(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static QuadrupleC log2(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static QuadrupleC log2(dynamic x)
        {
            return log2(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static QuadrupleC log1p(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static QuadrupleC log1p(dynamic x)
        {
            return log1p(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static QuadrupleC log10p1(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static QuadrupleC log10p1(dynamic x)
        {
            return log10p1(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static QuadrupleC log2p1(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static QuadrupleC log2p1(dynamic x)
        {
            return log2p1(qcplx.t(x));
        }



        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static QuadrupleC sqr(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static QuadrupleC sqr(dynamic x)
        {
            return sqr(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static QuadrupleC cube(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static QuadrupleC cube(dynamic x)
        {
            return cube(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static QuadrupleC hypot(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static QuadrupleC hypot(dynamic x, dynamic y)
        {
            return hypot(qcplx.t(x), qcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static QuadrupleC pow_si(QuadrupleC x, Int32 n)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Pow_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Pow_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static QuadrupleC pow_si(dynamic x, Int32 n)
        {
            return pow_si(qcplx.t(x), n);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static QuadrupleC compound_si(QuadrupleC x, Int32 n)
        {
            return pow1p(qcplx.t(x), qcplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static QuadrupleC compound_si(dynamic x, Int32 n)
        {
            return pow1p(qcplx.t(x), qcplx.t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static QuadrupleC pow(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static QuadrupleC pow(dynamic x, dynamic y)
        {
            return pow(qcplx.t(x), qcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static QuadrupleC powm1(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static QuadrupleC powm1(dynamic x, dynamic y)
        {
            return powm1(qcplx.t(x), qcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static QuadrupleC pow1p(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static QuadrupleC pow1p(dynamic x, dynamic y)
        {
            return pow1p(qcplx.t(x), qcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static QuadrupleC pow1pm1(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static QuadrupleC pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(qcplx.t(x), qcplx.t(y));
        }



        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static QuadrupleC sin(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static QuadrupleC sin(dynamic x)
        {
            return sin(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static QuadrupleC cos(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static QuadrupleC cos(dynamic x)
        {
            return cos(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static QuadrupleC tan(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static QuadrupleC tan(dynamic x)
        {
            return tan(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static QuadrupleC cot(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static QuadrupleC cot(dynamic x)
        {
            return cot(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static QuadrupleC sec(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static QuadrupleC sec(dynamic x)
        {
            return sec(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static QuadrupleC csc(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static QuadrupleC csc(dynamic x)
        {
            return csc(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static QuadrupleC sinc(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static QuadrupleC sinc(dynamic x)
        {
            return sinc(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static QuadrupleC sinpi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static QuadrupleC sinpi(dynamic x)
        {
            return sinpi(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static QuadrupleC cospi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static QuadrupleC cospi(dynamic x)
        {
            return cospi(qcplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static QuadrupleC tanpi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static QuadrupleC tanpi(dynamic x)
        {
            return tanpi(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static QuadrupleC cotpi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static QuadrupleC cotpi(dynamic x)
        {
            return cotpi(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static QuadrupleC cscpi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CscPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CscPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CscPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static QuadrupleC cscpi(dynamic x)
        {
            return cscpi(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static QuadrupleC secpi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_SecPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_SecPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_SecPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static QuadrupleC secpi(dynamic x)
        {
            return secpi(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static QuadrupleC sincpi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static QuadrupleC sincpi(dynamic x)
        {
            return sincpi(qcplx.t(x));
        }



        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static QuadrupleC cosh(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static QuadrupleC cosh(dynamic x)
        {
            return cosh(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static QuadrupleC sinh(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static QuadrupleC sinh(dynamic x)
        {
            return sinh(qcplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static QuadrupleC tanh(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static QuadrupleC tanh(dynamic x)
        {
            return tanh(qcplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static QuadrupleC csch(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static QuadrupleC csch(dynamic x)
        {
            return csch(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static QuadrupleC sech(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static QuadrupleC sech(dynamic x)
        {
            return sech(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static QuadrupleC coth(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static QuadrupleC coth(dynamic x)
        {
            return coth(qcplx.t(x));
        }





        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static QuadrupleC asin(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static QuadrupleC asin(dynamic x)
        {
            return asin(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static QuadrupleC acos(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static QuadrupleC acos(dynamic x)
        {
            return acos(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static QuadrupleC atan(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static QuadrupleC atan(dynamic x)
        {
            return atan(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static QuadrupleC acsc(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static QuadrupleC acsc(dynamic x)
        {
            return acsc(qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static QuadrupleC asec(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static QuadrupleC asec(dynamic x)
        {
            return asec(qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static QuadrupleC acot(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static QuadrupleC acot(dynamic x)
        {
            return acot(qcplx.t(x));
        }


        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static QuadrupleC asinh(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static QuadrupleC asinh(dynamic x)
        {
            return asinh(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static QuadrupleC acosh(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static QuadrupleC acosh(dynamic x)
        {
            return acosh(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static QuadrupleC atanh(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static QuadrupleC atanh(dynamic x)
        {
            return atanh(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static QuadrupleC acsch(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static QuadrupleC acsch(dynamic x)
        {
            return acsch(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static QuadrupleC asech(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static QuadrupleC asech(dynamic x)
        {
            return asech(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static QuadrupleC acoth(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static QuadrupleC acoth(dynamic x)
        {
            return acoth(qcplx.t(x));
        }





        #endregion



        #region 1F1: gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static QuadrupleC gamma(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static QuadrupleC gamma(dynamic x)
        {
            return gamma(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static QuadrupleC rgamma(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static QuadrupleC rgamma(dynamic x)
        {
            return rgamma(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static QuadrupleC lgamma(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static QuadrupleC lgamma(dynamic x)
        {
            return lgamma(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static QuadrupleC rising_factorial(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static QuadrupleC rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(qcplx.t(x), qcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static QuadrupleC beta(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static QuadrupleC beta(dynamic x, dynamic y)
        {
            return beta(qcplx.t(x), qcplx.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static QuadrupleC gamma1pm1(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.gamma1pm1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static QuadrupleC gamma1pm1(dynamic x)
        {
            return gamma1pm1(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static QuadrupleC factorial(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.factorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static QuadrupleC factorial(dynamic x)
        {
            return factorial(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static QuadrupleC doublefactorial(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.doublefactorial, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static QuadrupleC doublefactorial(dynamic x)
        {
            return doublefactorial(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static QuadrupleC falling_factorial(QuadrupleC a, QuadrupleC n)
        {
            return aflintc.QCplxViaArbCS2(aflintc.falling_factorial, a, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static QuadrupleC falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(qcplx.t(a), qcplx.t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static QuadrupleC gamma_ratio(QuadrupleC a, QuadrupleC b)
        {
            return aflintc.QCplxViaArbCS2(aflintc.gamma_ratio, a, b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static QuadrupleC gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(qcplx.t(a), qcplx.t(b));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static QuadrupleC gamma_delta_ratio(QuadrupleC a, QuadrupleC delta)
        {
            return aflintc.QCplxViaArbCS2(aflintc.gamma_delta_ratio, a, delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static QuadrupleC gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(qcplx.t(a), qcplx.t(delta));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static QuadrupleC binomial(QuadrupleC n, QuadrupleC k)
        {
            return aflintc.QCplxViaArbCS2(aflintc.binomial, n, k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static QuadrupleC binomial(dynamic n, dynamic k)
        {
            return binomial(qcplx.t(n), qcplx.t(k));
        }










        #endregion



        #region Miscellaneous



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static QuadrupleC lambert_wk(QuadrupleC x, int branch)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_LambertW_ui(res.mpPtr, x.mpPtr, branch);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LambertW_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_LambertW_ui(IntPtr res, IntPtr x, int branch);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static QuadrupleC lambert_wk(dynamic x, int branch)
        {
            return lambert_wk(qcplx.t(x), branch);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static QuadrupleC lambert_w0(QuadrupleC x)
        {
            return lambert_wk(qcplx.t(x), 0);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static QuadrupleC lambert_w0(dynamic x)
        {
            return lambert_w0(qcplx.t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static QuadrupleC lambert_wm1(QuadrupleC x)
        {
            return lambert_wk(qcplx.t(x), -1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static QuadrupleC lambert_wm1(dynamic x)
        {
            return lambert_wm1(qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static QuadrupleC agm(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static QuadrupleC agm(dynamic x, dynamic y)
        {
            return agm(qcplx.t(x), qcplx.t(y));
        }







        #endregion





        #endregion





        #region Flint Special Functions




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static QuadrupleC m_elliptic_k(QuadrupleC m)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static QuadrupleC m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static QuadrupleC m_elliptic_e(QuadrupleC m)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static QuadrupleC m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static QuadrupleC m_elliptic_pi(QuadrupleC n, QuadrupleC m)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static QuadrupleC m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(qcplx.t(x), qcplx.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static QuadrupleC m_elliptic_f(QuadrupleC phi, QuadrupleC m)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static QuadrupleC m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(qcplx.t(phi), qcplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static QuadrupleC m_elliptic_e_inc(QuadrupleC phi, QuadrupleC m)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static QuadrupleC m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(qcplx.t(phi), qcplx.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static QuadrupleC m_elliptic_pi_inc(QuadrupleC n, QuadrupleC phi, QuadrupleC m)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static QuadrupleC m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(qcplx.t(n), qcplx.t(phi), qcplx.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static QuadrupleC elliptic_k(QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static QuadrupleC elliptic_k(dynamic k)
        {
            return elliptic_k(qcplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static QuadrupleC elliptic_e(QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static QuadrupleC elliptic_e(dynamic k)
        {
            return elliptic_e(qcplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static QuadrupleC elliptic_pi(QuadrupleC n, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static QuadrupleC elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(qcplx.t(n), qcplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static QuadrupleC elliptic_f(QuadrupleC phi, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static QuadrupleC elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(qcplx.t(phi), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static QuadrupleC elliptic_e_inc(QuadrupleC phi, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static QuadrupleC elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(qcplx.t(phi), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static QuadrupleC elliptic_pi_inc(QuadrupleC n, QuadrupleC phi, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static QuadrupleC elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(qcplx.t(n), qcplx.t(phi), qcplx.t(k));
        }



        #endregion



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static QuadrupleC elliptic_rc(QuadrupleC x, QuadrupleC y)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static QuadrupleC elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(qcplx.t(x), qcplx.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static QuadrupleC elliptic_rf(QuadrupleC x, QuadrupleC y, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static QuadrupleC elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(qcplx.t(x), qcplx.t(y), qcplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static QuadrupleC elliptic_rg(QuadrupleC x, QuadrupleC y, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static QuadrupleC elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(qcplx.t(x), qcplx.t(y), qcplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static QuadrupleC elliptic_rd(QuadrupleC x, QuadrupleC y, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static QuadrupleC elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(qcplx.t(x), qcplx.t(y), qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static QuadrupleC elliptic_rj(QuadrupleC x, QuadrupleC y, QuadrupleC z, QuadrupleC w)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static QuadrupleC elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(qcplx.t(x), qcplx.t(y), qcplx.t(z), qcplx.t(w));
        }




        #endregion



        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static QuadrupleC jacobi_theta1(QuadrupleC x, QuadrupleC q)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static QuadrupleC jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(qcplx.t(x), qcplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static QuadrupleC jacobi_theta2(QuadrupleC x, QuadrupleC q)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static QuadrupleC jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(qcplx.t(x), qcplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static QuadrupleC jacobi_theta3(QuadrupleC x, QuadrupleC q)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static QuadrupleC jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(qcplx.t(x), qcplx.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static QuadrupleC jacobi_theta4(QuadrupleC x, QuadrupleC q)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static QuadrupleC jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(qcplx.t(x), qcplx.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static QuadrupleC JacobiTheta1Tau(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Theta1QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Theta1QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Theta1QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        public static QuadrupleC JacobiTheta1Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta1Tau(qcplx.t(z), qcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static QuadrupleC JacobiTheta2Tau(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Theta2QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Theta2QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Theta2QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        public static QuadrupleC JacobiTheta2Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta2Tau(qcplx.t(z), qcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static QuadrupleC JacobiTheta3Tau(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Theta3QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Theta3QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Theta3QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        public static QuadrupleC JacobiTheta3Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta3Tau(qcplx.t(z), qcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static QuadrupleC JacobiTheta4Tau(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Theta4QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Theta4QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_Theta4QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        public static QuadrupleC JacobiTheta4Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta4Tau(qcplx.t(z), qcplx.t(tau));
        }






        #endregion



        #region Jacobi elliptic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static QuadrupleC QfromK(QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_QfromK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_QfromK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_QfromK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        public static QuadrupleC QfromK(dynamic k)
        {
            return QfromK(qcplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static QuadrupleC TfromUQ(QuadrupleC u, QuadrupleC q)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_TfromUQ(res.mpPtr, u.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_TfromUQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_TfromUQ(IntPtr res, IntPtr u, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        public static QuadrupleC TfromUQ(dynamic n, dynamic k)
        {
            return TfromUQ(qcplx.t(n), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static QuadrupleC SnTQ(QuadrupleC t, QuadrupleC q)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_SnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_SnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_SnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        public static QuadrupleC SnTQ(dynamic t, dynamic q)
        {
            return SnTQ(qcplx.t(t), qcplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static QuadrupleC CnTQ(QuadrupleC t, QuadrupleC q)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_CnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        public static QuadrupleC CnTQ(dynamic t, dynamic q)
        {
            return CnTQ(qcplx.t(t), qcplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static QuadrupleC DnTQ(QuadrupleC t, QuadrupleC q)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_DnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_DnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_DnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        public static QuadrupleC DnTQ(dynamic t, dynamic q)
        {
            return DnTQ(qcplx.t(t), qcplx.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static QuadrupleC jacobi_sn(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static QuadrupleC jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static QuadrupleC jacobi_cn(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static QuadrupleC jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static QuadrupleC jacobi_dn(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static QuadrupleC jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static QuadrupleC jacobi_ns(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static QuadrupleC jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static QuadrupleC jacobi_nc(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static QuadrupleC jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static QuadrupleC jacobi_nd(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static QuadrupleC jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static QuadrupleC jacobi_sc(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static QuadrupleC jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static QuadrupleC jacobi_sd(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static QuadrupleC jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static QuadrupleC jacobi_dc(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static QuadrupleC jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static QuadrupleC jacobi_ds(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static QuadrupleC jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static QuadrupleC jacobi_cs(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static QuadrupleC jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(qcplx.t(x), qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static QuadrupleC jacobi_cd(QuadrupleC x, QuadrupleC k)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static QuadrupleC jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(qcplx.t(x), qcplx.t(k));
        }




        #endregion




        #region Conversions of parameters of Weierstrass P


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<QuadrupleC, QuadrupleC> elliptic_invariants_from_roots(QuadrupleC e1, QuadrupleC e2)
        {
            QuadrupleC e3 = -e1 - e2;
            QuadrupleC g2 = 2 * (e1 * e1 + e2 * e2 + e3 * e3);
            QuadrupleC g3 = 4 * e1 * e2 * e3;
            return new Tuple<QuadrupleC, QuadrupleC>(g2, g3);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<QuadrupleC, QuadrupleC> elliptic_invariants_from_roots(dynamic e1, dynamic e2)
        {
            return elliptic_invariants_from_roots(qcplx.t(e1), qcplx.t(e2));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<QuadrupleC, QuadrupleC> elliptic_invariants_from_tau(QuadrupleC tau)
        {
            return new Tuple<QuadrupleC, QuadrupleC>(EllipticInvariantG2(tau), EllipticInvariantG3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<QuadrupleC, QuadrupleC> elliptic_invariants_from_tau(dynamic tau)
        {
            return elliptic_invariants_from_tau(qcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<QuadrupleC, QuadrupleC, QuadrupleC> elliptic_roots_from_tau(QuadrupleC tau)
        {
            return new Tuple<QuadrupleC, QuadrupleC, QuadrupleC>(EllipticRootE1(tau), EllipticRootE2(tau), EllipticRootE3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<QuadrupleC, QuadrupleC, QuadrupleC> elliptic_roots_from_tau(dynamic tau)
        {
            return elliptic_roots_from_tau(qcplx.t(tau));
        }



        #endregion






        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static QuadrupleC weierstrass_p_t(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_WeierstrassP(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_WeierstrassP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_WeierstrassP(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static QuadrupleC weierstrass_p_t(dynamic z, dynamic tau)
        {
            return weierstrass_p_t(qcplx.t(z), qcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static QuadrupleC WeierstrassPInv(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_WeierstrassPInv(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_WeierstrassPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_WeierstrassPInv(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static QuadrupleC WeierstrassPInv(dynamic z, dynamic tau)
        {
            return WeierstrassPInv(qcplx.t(z), qcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static QuadrupleC weierstrass_zeta_t(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_WeierstrassPZeta(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_WeierstrassPZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_WeierstrassPZeta(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static QuadrupleC weierstrass_zeta_t(dynamic z, dynamic tau)
        {
            return weierstrass_zeta_t(qcplx.t(z), qcplx.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static QuadrupleC weierstrass_sigma_t(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_WeierstrassPSigma(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_WeierstrassPSigma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_WeierstrassPSigma(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static QuadrupleC weierstrass_sigma_t(dynamic z, dynamic tau)
        {
            return weierstrass_sigma_t(qcplx.t(z), qcplx.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static QuadrupleC weierstrass_pprime_t(QuadrupleC z, QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_WeierstrassPPrime(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_WeierstrassPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_WeierstrassPPrime(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static QuadrupleC weierstrass_pprime_t(dynamic z, dynamic tau)
        {
            return weierstrass_pprime_t(qcplx.t(z), qcplx.t(tau));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static QuadrupleC EllipticInvariantG2(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticInvariantG2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticInvariantG2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticInvariantG2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static QuadrupleC EllipticInvariantG2(dynamic k)
        {
            return EllipticInvariantG2(qcplx.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static QuadrupleC EllipticInvariantG3(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticInvariantG3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticInvariantG3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticInvariantG3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static QuadrupleC EllipticInvariantG3(dynamic k)
        {
            return EllipticInvariantG3(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static QuadrupleC EllipticRootE1(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticRootE1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticRootE1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticRootE1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static QuadrupleC EllipticRootE1(dynamic k)
        {
            return EllipticRootE1(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static QuadrupleC EllipticRootE2(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticRootE2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticRootE2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticRootE2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static QuadrupleC EllipticRootE2(dynamic k)
        {
            return EllipticRootE2(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static QuadrupleC EllipticRootE3(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EllipticRootE3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EllipticRootE3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_EllipticRootE3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static QuadrupleC EllipticRootE3(dynamic k)
        {
            return EllipticRootE3(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static QuadrupleC dedekind_eta(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_DedekindEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_DedekindEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_DedekindEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static QuadrupleC dedekind_eta(dynamic k)
        {
            return dedekind_eta(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static QuadrupleC klein_j(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_KleinJ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_KleinJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_KleinJ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static QuadrupleC klein_j(dynamic k)
        {
            return klein_j(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static QuadrupleC modular_lambda(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ModularLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ModularLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_ModularLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static QuadrupleC modular_lambda(dynamic k)
        {
            return modular_lambda(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static QuadrupleC modular_delta(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ModularDelta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ModularDelta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_ModularDelta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static QuadrupleC modular_delta(dynamic k)
        {
            return modular_delta(qcplx.t(k));
        }



        #endregion



        #region Weierstrass elliptic functions, in terms of (real) lattice invariants g2, g3



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static QuadrupleC lerch_phi(QuadrupleC s, QuadrupleC z, QuadrupleC a)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_LerchPhi(res.mpPtr, s.mpPtr, z.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_LerchPhi(IntPtr res, IntPtr s, IntPtr z, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static QuadrupleC lerch_phi(dynamic s, dynamic z, dynamic a)
        {
            return lerch_phi(qcplx.t(s), qcplx.t(z), qcplx.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static QuadrupleC lerch_zeta(QuadrupleC lambda1, QuadrupleC alpha, QuadrupleC s)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_LerchZeta(res.mpPtr, lambda1.mpPtr, alpha.mpPtr, s.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LerchZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_LerchZeta(IntPtr res, IntPtr lambda1, IntPtr alpha, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static QuadrupleC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(qcplx.t(lambda1), qcplx.t(alpha), qcplx.t(s));
        }




        #endregion



        #region polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static QuadrupleC polygamma(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static QuadrupleC polygamma(dynamic s, dynamic z)
        {
            return polygamma(qcplx.t(s), qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static QuadrupleC trigamma(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Trigamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Trigamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static QuadrupleC trigamma(dynamic x)
        {
            return trigamma(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static QuadrupleC digamma(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static QuadrupleC digamma(dynamic x)
        {
            return digamma(qcplx.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static QuadrupleC polylog(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static QuadrupleC polylog(dynamic s, dynamic z)
        {
            return polylog(qcplx.t(s), qcplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static QuadrupleC trilog(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Trilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Trilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Trilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static QuadrupleC trilog(dynamic x)
        {
            return trilog(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static QuadrupleC dilog(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static QuadrupleC dilog(dynamic x)
        {
            return dilog(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static QuadrupleC clausen_sin(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ClausenSin(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ClausenSin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_ClausenSin(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static QuadrupleC clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(qcplx.t(s), qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static QuadrupleC clausen_cos(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ClausenCos(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ClausenCos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_ClausenCos(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static QuadrupleC clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(qcplx.t(s), qcplx.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static QuadrupleC clausen2(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Clausen2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Clausen2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Clausen2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static QuadrupleC clausen2(dynamic x)
        {
            return clausen2(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static QuadrupleC bose_einstein(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_BoseEinstein(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_BoseEinstein", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_BoseEinstein(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static QuadrupleC bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(qcplx.t(s), qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static QuadrupleC fermi_dirac(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_FermiDirac(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_FermiDirac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_FermiDirac(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static QuadrupleC fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(qcplx.t(s), qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static QuadrupleC legendre_chi(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_LegendreChi(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LegendreChi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_LegendreChi(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static QuadrupleC legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(qcplx.t(s), qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static QuadrupleC inverse_tan_integral(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_InverseTanIntegral(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_InverseTanIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_InverseTanIntegral(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static QuadrupleC inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(qcplx.t(s), qcplx.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static QuadrupleC hurwitz_zeta(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_HurwitzZeta(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static QuadrupleC hurwitz_zeta(dynamic s, dynamic z)
        {
            return hurwitz_zeta(qcplx.t(s), qcplx.t(z));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/stieltjes/*' />
        //public static QuadrupleC stieltjes(QuadrupleC x, Int32 n)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_Stieltjes_ui(res.mpPtr, x.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Stieltjes_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_Stieltjes_ui(IntPtr res, IntPtr x, Int32 n);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static QuadrupleC bernpoly(QuadrupleC x, Int32 n)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static QuadrupleC bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(qcplx.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static QuadrupleC eulerpoly(QuadrupleC x, Int32 n)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_EulerPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_EulerPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_EulerPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static QuadrupleC eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(qcplx.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static QuadrupleC harmonic(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Harmonic(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Harmonic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Harmonic(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static QuadrupleC harmonic(dynamic x)
        {
            return harmonic(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static QuadrupleC harmonic2(QuadrupleC z, QuadrupleC r)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Harmonic2(res.mpPtr, z.mpPtr, r.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Harmonic2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Harmonic2(IntPtr res, IntPtr z, IntPtr r);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static QuadrupleC harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(qcplx.t(z), qcplx.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static QuadrupleC barnes_g(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static QuadrupleC barnes_g(dynamic x)
        {
            return barnes_g(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static QuadrupleC logbarnes_g(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static QuadrupleC logbarnes_g(dynamic x)
        {
            return logbarnes_g(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static QuadrupleC hyperfactorial(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hyperfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hyperfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hyperfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static QuadrupleC hyperfactorial(dynamic x)
        {
            return hyperfactorial(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static QuadrupleC superfactorial(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Superfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Superfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Superfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static QuadrupleC superfactorial(dynamic x)
        {
            return superfactorial(qcplx.t(x));
        }




        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static QuadrupleC zeta(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static QuadrupleC zeta(dynamic x)
        {
            return zeta(qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static QuadrupleC zetam1(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Zetam1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Zetam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Zetam1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static QuadrupleC zetam1(dynamic x)
        {
            return zetam1(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static QuadrupleC riemann_xi(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_DirichletXi(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_DirichletXi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_DirichletXi(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static QuadrupleC riemann_xi(dynamic k)
        {
            return riemann_xi(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static QuadrupleC dirichlet_eta(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_DirichletEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_DirichletEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_DirichletEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static QuadrupleC dirichlet_eta(dynamic k)
        {
            return dirichlet_eta(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static QuadrupleC dirichlet_etam1(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_DirichletEtam1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_DirichletEtam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_DirichletEtam1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static QuadrupleC dirichlet_etam1(dynamic k)
        {
            return dirichlet_etam1(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static QuadrupleC dirichlet_beta(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_DirichletBeta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_DirichletBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_DirichletBeta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static QuadrupleC dirichlet_beta(dynamic k)
        {
            return dirichlet_beta(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static QuadrupleC dirichlet_lambda(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_DirichletLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_DirichletLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_DirichletLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static QuadrupleC dirichlet_lambda(dynamic k)
        {
            return dirichlet_lambda(qcplx.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static QuadrupleC hardy_z(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_HardyZ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_HardyZ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_HardyZ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static QuadrupleC hardy_z(dynamic k)
        {
            return hardy_z(qcplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static QuadrupleC hardy_theta(QuadrupleC tau)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_HardyTheta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_HardyTheta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_QCplx_Acb_HardyTheta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static QuadrupleC hardy_theta(dynamic k)
        {
            return hardy_theta(qcplx.t(k));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta_zero/*' />
        public static QuadrupleC zeta_zero(Int32 n)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ZetaZero_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ZetaZero_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_ZetaZero_ui(IntPtr res, Int32 n);



        #endregion



        #region Additional numbertheoretic functions





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static QuadrupleC hyperg_0f1(QuadrupleC a, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static QuadrupleC hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(qcplx.t(a), qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static QuadrupleC hyperg_0f1r(QuadrupleC a, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static QuadrupleC hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(qcplx.t(a), qcplx.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static QuadrupleC bessel_jv(QuadrupleC nu, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.bessel_jv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static QuadrupleC bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(qcplx.t(nu), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static QuadrupleC bessel_yv(QuadrupleC nu, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.bessel_yv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static QuadrupleC bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(qcplx.t(nu), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static QuadrupleC bessel_iv(QuadrupleC nu, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.bessel_iv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static QuadrupleC bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(qcplx.t(nu), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static QuadrupleC bessel_kv(QuadrupleC nu, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.bessel_kv, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static QuadrupleC bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(qcplx.t(nu), qcplx.t(x), scaled);
        }









        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static QuadrupleC bessel_jv_prime(QuadrupleC nu, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.bessel_jv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static QuadrupleC bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(qcplx.t(nu), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static QuadrupleC bessel_yv_prime(QuadrupleC nu, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.bessel_yv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static QuadrupleC bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(qcplx.t(nu), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static QuadrupleC bessel_iv_prime(QuadrupleC nu, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.bessel_iv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static QuadrupleC bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(qcplx.t(nu), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static QuadrupleC bessel_kv_prime(QuadrupleC nu, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.bessel_kv_prime, nu, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static QuadrupleC bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(qcplx.t(nu), qcplx.t(x), scaled);
        }









        #endregion







        #region 0F1: Spherical Bessel functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static QuadrupleC sph_bessel_jn(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_bessel_jn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static QuadrupleC sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(qcplx.t(n), qcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static QuadrupleC sph_bessel_yn(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_bessel_yn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static QuadrupleC sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(qcplx.t(n), qcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static QuadrupleC sph_bessel_in(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_bessel_in, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static QuadrupleC sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(qcplx.t(n), qcplx.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static QuadrupleC sph_bessel_kn(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_bessel_kn, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static QuadrupleC sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(qcplx.t(n), qcplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static QuadrupleC besselpoly(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.besselpoly, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static QuadrupleC besselpoly(dynamic n, dynamic x, bool scaled = false)
        {
            return besselpoly(qcplx.t(n), qcplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static QuadrupleC besseltheta(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.besseltheta, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static QuadrupleC besseltheta(dynamic n, dynamic x, bool scaled = false)
        {
            return besseltheta(qcplx.t(n), qcplx.t(x), scaled);
        }








        #endregion



        #region 0F1: Spherical Bessel functions, first derivative


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static QuadrupleC sph_bessel_jn_prime(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_bessel_jn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static QuadrupleC sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(qcplx.t(n), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static QuadrupleC sph_bessel_yn_prime(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_bessel_yn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static QuadrupleC sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(qcplx.t(n), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static QuadrupleC sph_bessel_in_prime(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_bessel_in_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static QuadrupleC sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(qcplx.t(n), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static QuadrupleC sph_bessel_kn_prime(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_bessel_kn_prime, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static QuadrupleC sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(qcplx.t(n), qcplx.t(x), scaled);
        }



        #endregion







        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static QuadrupleC hankel_h1(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.hankel_h1, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static QuadrupleC hankel_h1(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h1(qcplx.t(v), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static QuadrupleC hankel_h2(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.hankel_h2, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static QuadrupleC hankel_h2(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h2(qcplx.t(v), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static QuadrupleC sph_hankel_h1(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_hankel_h1, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static QuadrupleC sph_hankel_h1(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h1(qcplx.t(n), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static QuadrupleC sph_hankel_h2(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.sph_hankel_h2, n, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static QuadrupleC sph_hankel_h2(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h2(qcplx.t(n), qcplx.t(x), scaled);
        }





        #endregion





        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static QuadrupleC airy_ai(QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS1Bool1(aflintc.airy_ai, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static QuadrupleC airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static QuadrupleC airy_ai_prime(QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS1Bool1(aflintc.airy_ai_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static QuadrupleC airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static QuadrupleC airy_bi(QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS1Bool1(aflintc.airy_bi, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static QuadrupleC airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static QuadrupleC airy_bi_prime(QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS1Bool1(aflintc.airy_bi_prime, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static QuadrupleC airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(qcplx.t(x), scaled);
        }








        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static QuadrupleC airy_ai(QuadrupleC x, bool scaled = false)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_AiryAi(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp((qreal.t(2) / qreal.t(3)) * x * sqrt(x));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_AiryAi(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        //public static QuadrupleC airy_ai(dynamic x, bool scaled = false)
        //{
        //    return airy_ai(qcplx.t(x), scaled);
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static QuadrupleC airy_ai_prime(QuadrupleC x, bool scaled = false)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_AiryAiPrime(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp((qreal.t(2) / qreal.t(3)) * x * sqrt(x));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_AiryAiPrime(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        //public static QuadrupleC airy_ai_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_ai_prime(qcplx.t(x), scaled);
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static QuadrupleC airy_bi(QuadrupleC x, bool scaled = false)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_AiryBi(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp(-abs(qreal.t(2) / qreal.t(3) * (x * sqrt(x)).real));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_AiryBi(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        //public static QuadrupleC airy_bi(dynamic x, bool scaled = false)
        //{
        //    return airy_bi(qcplx.t(x), scaled);
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static QuadrupleC airy_bi_prime(QuadrupleC x, bool scaled = false)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_AiryBiPrime(res.mpPtr, x.mpPtr);
        //    if (scaled) res *= exp(-abs(qreal.t(2) / qreal.t(3) * (x * sqrt(x)).real));
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_AiryBiPrime(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        //public static QuadrupleC airy_bi_prime(dynamic x, bool scaled = false)
        //{
        //    return airy_bi_prime(qcplx.t(x), scaled);
        //}



        #endregion





        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static QuadrupleC kelvin_ber(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.kelvin_ber, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static QuadrupleC kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(qcplx.t(v), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static QuadrupleC kelvin_bei(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.kelvin_bei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static QuadrupleC kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(qcplx.t(v), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static QuadrupleC kelvin_ker(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.kelvin_ker, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static QuadrupleC kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(qcplx.t(v), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static QuadrupleC kelvin_kei(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.kelvin_kei, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static QuadrupleC kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(qcplx.t(v), qcplx.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static QuadrupleC kelvin_ber_prime(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.kelvin_ber_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static QuadrupleC kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(qcplx.t(v), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static QuadrupleC kelvin_bei_prime(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.kelvin_bei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static QuadrupleC kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(qcplx.t(v), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static QuadrupleC kelvin_ker_prime(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.kelvin_ker_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static QuadrupleC kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(qcplx.t(v), qcplx.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static QuadrupleC kelvin_kei_prime(QuadrupleC v, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2Bool1(aflintc.kelvin_kei_prime, v, x, scaled);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static QuadrupleC kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(qcplx.t(v), qcplx.t(x), scaled);
        }






        #endregion











        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static QuadrupleC hyperg_1f1(QuadrupleC a, QuadrupleC b, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static QuadrupleC hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(qcplx.t(a), qcplx.t(b), qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static QuadrupleC hyperg_1f1r(QuadrupleC a, QuadrupleC b, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static QuadrupleC hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(qcplx.t(a), qcplx.t(b), qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static QuadrupleC hyperg_u(QuadrupleC a, QuadrupleC b, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static QuadrupleC hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(qcplx.t(a), qcplx.t(b), qcplx.t(x));
        }





        #endregion



        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static QuadrupleC gamma_upper(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static QuadrupleC gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(qcplx.t(s), qcplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static QuadrupleC gamma_q(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static QuadrupleC gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(qcplx.t(s), qcplx.t(z));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static QuadrupleC gamma_lower(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static QuadrupleC gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(qcplx.t(s), qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static QuadrupleC gamma_p(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static QuadrupleC gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(qcplx.t(s), qcplx.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static QuadrupleC gamma_p_prime(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static QuadrupleC gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(qcplx.t(s), qcplx.t(z));
        }



        #endregion



        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static QuadrupleC erf(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static QuadrupleC erf(dynamic x)
        {
            return erf(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static QuadrupleC erfc(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static QuadrupleC erfc(dynamic x)
        {
            return erfc(qcplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static QuadrupleC erfi(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static QuadrupleC erfi(dynamic x)
        {
            return erfi(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static QuadrupleC dawson(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.dawson, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static QuadrupleC dawson(dynamic x)
        {
            return dawson(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static QuadrupleC faddeeva(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.faddeeva, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static QuadrupleC faddeeva(dynamic x)
        {
            return faddeeva(qcplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static QuadrupleC fresnel_s(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static QuadrupleC fresnel_s(dynamic x)
        {
            return fresnel_s(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static QuadrupleC fresnel_c(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static QuadrupleC fresnel_c(dynamic x)
        {
            return fresnel_c(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static QuadrupleC ndens(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static QuadrupleC ndens(dynamic x)
        {
            return ndens(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static QuadrupleC ndis(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static QuadrupleC ndis(dynamic x)
        {
            return ndis(qcplx.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static QuadrupleC exp_integral_en(QuadrupleC s, QuadrupleC z)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static QuadrupleC exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(qcplx.t(s), qcplx.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static QuadrupleC exp_integral_e1(QuadrupleC z)
        {
            return exp_integral_en(qcplx.t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static QuadrupleC exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(qcplx.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static QuadrupleC exp_integral_ei(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static QuadrupleC exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static QuadrupleC sin_integral(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static QuadrupleC sin_integral(dynamic x)
        {
            return sin_integral(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static QuadrupleC cos_integral(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static QuadrupleC cos_integral(dynamic x)
        {
            return cos_integral(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static QuadrupleC sinh_integral(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static QuadrupleC sinh_integral(dynamic x)
        {
            return sinh_integral(qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static QuadrupleC cosh_integral(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static QuadrupleC cosh_integral(dynamic x)
        {
            return cosh_integral(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static QuadrupleC log_integral(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static QuadrupleC log_integral(dynamic x)
        {
            return log_integral(qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static QuadrupleC log_integral_offset(QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static QuadrupleC log_integral_offset(dynamic x)
        {
            return log_integral_offset(qcplx.t(x));
        }



        #endregion



        #region 1F1-related orthogonal polynomials



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static QuadrupleC hermite_h(QuadrupleC n, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static QuadrupleC hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(qcplx.t(n), qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static QuadrupleC hermite_he(QuadrupleC n, QuadrupleC x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static QuadrupleC hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(qcplx.t(n), qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static QuadrupleC laguerre_l(QuadrupleC n, QuadrupleC m, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static QuadrupleC laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(qcplx.t(n), qcplx.t(m), qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre/*' />
        public static QuadrupleC laguerre(QuadrupleC n, QuadrupleC x)
        {
            return laguerre_l(n, qcplx.t(0), x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre/*' />
        public static QuadrupleC laguerre(dynamic n, dynamic x)
        {
            return laguerre(qcplx.t(n), qcplx.t(x));
        }



        #endregion



        #region 1F1: Coulomb functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static QuadrupleC coulomb_f(QuadrupleC l, QuadrupleC eta, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static QuadrupleC coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(qcplx.t(l), qcplx.t(eta), qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static QuadrupleC coulomb_g(QuadrupleC l, QuadrupleC eta, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static QuadrupleC coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(qcplx.t(l), qcplx.t(eta), qcplx.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static QuadrupleC coulomb_hpos(QuadrupleC l, QuadrupleC eta, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CoulombHpos(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CoulombHpos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CoulombHpos(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static QuadrupleC coulomb_hpos(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hpos(qcplx.t(l), qcplx.t(eta), qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static QuadrupleC coulomb_hneg(QuadrupleC l, QuadrupleC eta, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_CoulombHneg(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_CoulombHneg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_CoulombHneg(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static QuadrupleC coulomb_hneg(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hneg(qcplx.t(l), qcplx.t(eta), qcplx.t(x));
        }





        #endregion



        #region 1F1: Whittaker functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static QuadrupleC whittaker_m(QuadrupleC k, QuadrupleC m, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS3(aflintc.whittaker_m, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_m/*' />
        public static QuadrupleC whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(qcplx.t(k), qcplx.t(m), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static QuadrupleC whittaker_w(QuadrupleC k, QuadrupleC m, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS3(aflintc.whittaker_w, k, m, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/whittaker_w/*' />
        public static QuadrupleC whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(qcplx.t(k), qcplx.t(m), qcplx.t(x));
        }





        #endregion



        #region 1F1: Parabolic cylinder functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static QuadrupleC pcfd(QuadrupleC n, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.pcfd, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfd/*' />
        public static QuadrupleC pcfd(dynamic n, dynamic x)
        {
            return pcfd(qcplx.t(n), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static QuadrupleC pcfu(QuadrupleC a, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.pcfu, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfu/*' />
        public static QuadrupleC pcfu(dynamic a, dynamic x)
        {
            return pcfu(qcplx.t(a), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static QuadrupleC pcfv(QuadrupleC a, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.pcfv, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfv/*' />
        public static QuadrupleC pcfv(dynamic a, dynamic x)
        {
            return pcfv(qcplx.t(a), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static QuadrupleC pcfw(QuadrupleC a, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.pcfw, a, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/pcfw/*' />
        public static QuadrupleC pcfw(dynamic a, dynamic x)
        {
            return pcfw(qcplx.t(a), qcplx.t(x));
        }




        #endregion








        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static QuadrupleC hyperg_2f1(QuadrupleC a, QuadrupleC b, QuadrupleC c, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static QuadrupleC hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(qcplx.t(a), qcplx.t(b), qcplx.t(c), qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static QuadrupleC hyperg_2f1r(QuadrupleC a, QuadrupleC b, QuadrupleC c, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static QuadrupleC hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(qcplx.t(a), qcplx.t(b), qcplx.t(c), qcplx.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static QuadrupleC chebyshev_t(QuadrupleC n, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static QuadrupleC chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(qcplx.t(n), qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static QuadrupleC chebyshev_u(QuadrupleC n, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static QuadrupleC chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(qcplx.t(n), qcplx.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static QuadrupleC chebyshev_v(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2(aflintc.chebyshev_v, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static QuadrupleC chebyshev_v(int n, dynamic y)
        {
            return chebyshev_v(qcplx.t(n), qcplx.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static QuadrupleC chebyshev_w(QuadrupleC n, QuadrupleC x, bool scaled = false)
        {
            return aflintc.QCplxViaArbCS2(aflintc.chebyshev_w, n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static QuadrupleC chebyshev_w(int n, dynamic y)
        {
            return chebyshev_w(qcplx.t(n), qcplx.t(y));
        }











        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static QuadrupleC gegenbauer_c(QuadrupleC n, QuadrupleC m, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static QuadrupleC gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(qcplx.t(n), qcplx.t(m), qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static QuadrupleC jacobi_p(QuadrupleC n, QuadrupleC a, QuadrupleC b, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static QuadrupleC jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(qcplx.t(n), qcplx.t(a), qcplx.t(b), qcplx.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static QuadrupleC legendre_p(QuadrupleC n, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.legendre_p, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static QuadrupleC legendre_p(dynamic n, dynamic x)
        {
            return legendre_p(qcplx.t(n), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static QuadrupleC legendre_q(QuadrupleC n, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.legendre_q, n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static QuadrupleC legendre_q(dynamic n, dynamic x)
        {
            return legendre_q(qcplx.t(n), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static QuadrupleC legendre_plm(QuadrupleC n, QuadrupleC m, QuadrupleC x, int type = 1)
        {
            return aflintc.QCplxViaArbCS3Int1(aflintc.legendre_plm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static QuadrupleC legendre_plm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_plm(qcplx.t(n), qcplx.t(m), qcplx.t(x), type);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static QuadrupleC legendre_qlm(QuadrupleC n, QuadrupleC m, QuadrupleC x, int type = 1)
        {
            return aflintc.QCplxViaArbCS3Int1(aflintc.legendre_qlm, n, m, x, type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static QuadrupleC legendre_qlm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_qlm(qcplx.t(n), qcplx.t(m), qcplx.t(x), type);
        }




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static QuadrupleC legendre_p(QuadrupleC n, QuadrupleC m, QuadrupleC x)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_LegendreP(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        //public static QuadrupleC legendre_p(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_p(qcplx.t(n), qcplx.t(m), qcplx.t(x));
        //}




        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static QuadrupleC legendre_plm(QuadrupleC n, QuadrupleC m, QuadrupleC x)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_LegendrePv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        //public static QuadrupleC legendre_plm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_plm(qcplx.t(n), qcplx.t(m), qcplx.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static QuadrupleC legendre_q(QuadrupleC n, QuadrupleC m, QuadrupleC x)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_LegendreQ(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        //public static QuadrupleC legendre_q(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_q(qcplx.t(n), qcplx.t(m), qcplx.t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static QuadrupleC legendre_qlm(QuadrupleC n, QuadrupleC m, QuadrupleC x)
        //{
        //    var res = new QuadrupleC();
        //    Lib_QCplx_Acb_LegendreQv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_QCplx_Acb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        //public static QuadrupleC legendre_qlm(dynamic n, dynamic m, dynamic x)
        //{
        //    return legendre_qlm(qcplx.t(n), qcplx.t(m), qcplx.t(x));
        //}





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static QuadrupleC spherical_y(QuadrupleC n, QuadrupleC m, QuadrupleC theta, QuadrupleC phi)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_SphericalY(res.mpPtr, n.mpPtr, m.mpPtr, theta.mpPtr, phi.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_SphericalY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_SphericalY(IntPtr res, IntPtr n, IntPtr m, IntPtr theta, IntPtr phi);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static QuadrupleC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(qcplx.t(n), qcplx.t(m), qcplx.t(theta), qcplx.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static QuadrupleC beta_lower(QuadrupleC a, QuadrupleC b, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static QuadrupleC beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(qcplx.t(a), qcplx.t(b), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static QuadrupleC ibeta(QuadrupleC a, QuadrupleC b, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static QuadrupleC ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(qcplx.t(a), qcplx.t(b), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static QuadrupleC ibetac(QuadrupleC a, QuadrupleC b, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static QuadrupleC ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(qcplx.t(a), qcplx.t(b), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static QuadrupleC ibeta_prime(QuadrupleC a, QuadrupleC b, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static QuadrupleC ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(qcplx.t(a), qcplx.t(b), qcplx.t(x));
        }


        #endregion







        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static QuadrupleC hyperg_1f2(QuadrupleC a1, QuadrupleC b1, QuadrupleC b2, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static QuadrupleC hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(qcplx.t(a1), qcplx.t(b1), qcplx.t(b2), qcplx.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static QuadrupleC hyperg_1f2r(QuadrupleC a1, QuadrupleC b1, QuadrupleC b2, QuadrupleC x)
        {
            var res = new QuadrupleC();
            Lib_QCplx_Acb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_QCplx_Acb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_QCplx_Acb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static QuadrupleC hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(qcplx.t(a1), qcplx.t(b1), qcplx.t(b2), qcplx.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static QuadrupleC airy_gi(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.airy_gi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static QuadrupleC airy_gi(dynamic x)
        {
            return airy_gi(qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static QuadrupleC airy_hi(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.airy_hi, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static QuadrupleC airy_hi(dynamic x)
        {
            return airy_hi(qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static QuadrupleC airy_gi_prime(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.airy_gi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static QuadrupleC airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static QuadrupleC airy_hi_prime(QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS1(aflintc.airy_hi_prime, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static QuadrupleC airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(qcplx.t(x));
        }




        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static QuadrupleC struve_h(QuadrupleC v, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.struve_h, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static QuadrupleC struve_h(dynamic v, dynamic x)
        {
            return struve_h(qcplx.t(v), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static QuadrupleC struve_l(QuadrupleC v, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.struve_l, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static QuadrupleC struve_l(dynamic v, dynamic x)
        {
            return struve_l(qcplx.t(v), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static QuadrupleC struve_k(QuadrupleC v, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.struve_k, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static QuadrupleC struve_k(dynamic v, dynamic x)
        {
            return struve_k(qcplx.t(v), qcplx.t(x));
        }


        public static QuadrupleC struve_m(QuadrupleC v, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.struve_m, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static QuadrupleC struve_m(dynamic v, dynamic x)
        {
            return struve_m(qcplx.t(v), qcplx.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static QuadrupleC anger_j(QuadrupleC v, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.anger_j, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static QuadrupleC anger_j(dynamic v, dynamic x)
        {
            return anger_j(qcplx.t(v), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static QuadrupleC weber_e(QuadrupleC v, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS2(aflintc.weber_e, v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static QuadrupleC weber_e(dynamic v, dynamic x)
        {
            return weber_e(qcplx.t(v), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static QuadrupleC lommel_s1(QuadrupleC mu, QuadrupleC nu, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS3(aflintc.lommel_s1, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static QuadrupleC lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(qcplx.t(mu), qcplx.t(nu), qcplx.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static QuadrupleC lommel_s2(QuadrupleC mu, QuadrupleC nu, QuadrupleC x)
        {
            return aflintc.QCplxViaArbCS3(aflintc.lommel_s2, mu, nu, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static QuadrupleC lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(qcplx.t(mu), qcplx.t(nu), qcplx.t(x));
        }


        #endregion






        #endregion


    }







}