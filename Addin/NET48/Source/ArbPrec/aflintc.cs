using System;
using System.Numerics;
using System.Runtime.InteropServices;
using FixedPrecNet;

namespace ArbPrecNet
{


    public delegate ArbC cbFuncApc(ArbC z);


    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void cbFunction3Ptr2Int32_64(IntPtr res, IntPtr z, IntPtr parameters, Int64 order, Int64 prec);



    public delegate ArbC cb1SArbC1S(ArbC x);

    public delegate ArbC cb1SArbC2S(ArbC x, ArbC y);

    public delegate ArbC cb1SArbC3S(ArbC x, ArbC y, ArbC z);


    public delegate ArbC cb1SArbC1SBool(ArbC x, bool sc);

    public delegate ArbC cb1SArbC2SBool(ArbC x, ArbC y, bool sc);

    public delegate ArbC cb1SArbC3SInt1(ArbC x, ArbC y, ArbC z, int si);




    public class ArbC
    {

        internal IntPtr mpPtr = IntPtr.Zero;


        #region Init


        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Lib_Acb_Init_Func();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_Acb_Init_Func();



        ~ArbC()
        {
            Lib_Acb_Clear(mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Clear(IntPtr x);


        #endregion


        #region Conversions


        public Arb real
        {
            get
            {
                var res = new Arb();
                Lib_Acb_Real(res.mpPtr, mpPtr);
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Real", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Real(IntPtr res, IntPtr z);


        public Arb imag
        {
            get
            {
                var res = new Arb();
                Lib_Acb_Imag(res.mpPtr, mpPtr);
                return res;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Imag", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Imag(IntPtr res, IntPtr z);



        //public Arb imag
        //{
        //    get
        //    {
        //        var res = new Arb();
        //        Lib_Acb_Imag(res.mpPtr, mpPtr);
        //        return res;
        //    }
        //}




        public ArbC()
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
            return "ArbC('" + ToString() + "')";
        }

        #endregion




        #region Arithmetic operators



        public static bool operator ==(dynamic x, ArbC y)
        {
            return aflintc.t(x) == y;
        }

        public static bool operator ==(ArbC x, dynamic y)
        {
            return x == aflintc.t(y);
        }


        public static bool operator !=(dynamic x, ArbC y)
        {
            return aflintc.t(x) != y;
        }

        public static bool operator !=(ArbC x, dynamic y)
        {
            return x != aflintc.t(y);
        }



        public static bool operator ==(ArbC x, ArbC y)
        {
            return Lib_Acb_EQ(x.mpPtr, y.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_EQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Acb_EQ(IntPtr x, IntPtr y);


        public static bool operator !=(ArbC x, ArbC y)
        {
            return Lib_Acb_NE(x.mpPtr, y.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_NE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Acb_NE(IntPtr x, IntPtr y);







        public static ArbC operator +(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Set(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Set(IntPtr res, IntPtr x);



        public static ArbC operator -(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Neg(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Neg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Neg(IntPtr res, IntPtr x);


        public static ArbC Inv(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Inv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Inv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Inv(IntPtr res, IntPtr x);






        public static ArbC operator +(ArbC x, dynamic y)
        {
            return x + aflintc.t(y);
        }

        public static ArbC operator +(dynamic x, ArbC y)
        {
            return aflintc.t(x) + y;
        }


        public static ArbC operator +(ArbC x, Arb y)
        {
            var res = new ArbC();
            Lib_Acb_Add_Arb(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Add_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Add_Arb(IntPtr res, IntPtr x, IntPtr y);


        public static ArbC operator +(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Add(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Add(IntPtr res, IntPtr x, IntPtr y);


        public static ArbMatC operator +(ArbC m2, ArbMatC M1)
        {
            var Res = new ArbMatC();
            var t = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }







        public static ArbC operator -(ArbC x, dynamic y)
        {
            return x - aflintc.t(y);
        }

        public static ArbC operator -(dynamic x, ArbC y)
        {
            return aflintc.t(x) - y;
        }


        public static ArbC operator -(ArbC x, Arb y)
        {
            var res = new ArbC();
            Lib_Acb_Sub_Arb(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Sub_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Sub_Arb(IntPtr res, IntPtr x, IntPtr y);


        public static ArbC operator -(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Sub(IntPtr res, IntPtr x, IntPtr y);


        public static ArbMatC operator -(ArbC m2, ArbMatC M1)
        {
            var Res = new ArbMatC();
            var t = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return -Res;
        }









        public static ArbC operator *(ArbC x, dynamic y)
        {
            return x * aflintc.t(y);
        }

        public static ArbC operator *(dynamic x, ArbC y)
        {
            return aflintc.t(x) * y;
        }


        public static ArbC operator *(ArbC x, Arb y)
        {
            var res = new ArbC();
            Lib_Acb_Mul_Arb(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Mul_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Mul_Arb(IntPtr res, IntPtr x, IntPtr y);


        public static ArbC operator *(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Mul(IntPtr res, IntPtr x, IntPtr y);


        public static ArbMatC operator *(ArbC m2, ArbMatC M1)
        {
            var Res = new ArbMatC();
            var t = aflintc.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apc, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }








        public static ArbC operator /(ArbC x, dynamic y)
        {
            return x / aflintc.t(y);
        }

        public static ArbC operator /(dynamic x, ArbC y)
        {
            return aflintc.t(x) / y;
        }


        public static ArbC operator /(ArbC x, Arb y)
        {
            var res = new ArbC();
            Lib_Acb_Div_Arb(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Div_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Div_Arb(IntPtr res, IntPtr x, IntPtr y);


        public static ArbC operator /(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Div(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Div(IntPtr res, IntPtr x, IntPtr y);



        #endregion



    }





    public partial class aflintc
    {


        #region Function conversions



        public static SingleC SCplxViaArbCS1(cb1SArbC1S f, SingleC x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x);

            SingleC res = sflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static SingleC SCplxViaArbCS2(cb1SArbC2S f, SingleC x, SingleC y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y);

            SingleC res = sflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static SingleC SCplxViaArbCS3(cb1SArbC3S f, SingleC x, SingleC y, SingleC z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z);

            SingleC res = sflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }



        public static Complex DCplxViaArbCS1(cb1SArbC1S f, Complex x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x);

            Complex res = dflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Complex DCplxViaArbCS2(cb1SArbC2S f, Complex x, Complex y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y);

            Complex res = dflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Complex DCplxViaArbCS3(cb1SArbC3S f, Complex x, Complex y, Complex z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z);

            Complex res = dflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static ExtendedC ECplxViaArbCS1(cb1SArbC1S f, ExtendedC x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x);

            ExtendedC res = eflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static ExtendedC ECplxViaArbCS2(cb1SArbC2S f, ExtendedC x, ExtendedC y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y);

            ExtendedC res = eflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static ExtendedC ECplxViaArbCS3(cb1SArbC3S f, ExtendedC x, ExtendedC y, ExtendedC z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z);

            ExtendedC res = eflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static QuadrupleC QCplxViaArbCS1(cb1SArbC1S f, QuadrupleC x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x);

            QuadrupleC res = qflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static QuadrupleC QCplxViaArbCS2(cb1SArbC2S f, QuadrupleC x, QuadrupleC y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y);

            QuadrupleC res = qflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static QuadrupleC QCplxViaArbCS3(cb1SArbC3S f, QuadrupleC x, QuadrupleC y, QuadrupleC z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z);

            QuadrupleC res = qflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static OctupleC OCplxViaArbCS1(cb1SArbC1S f, OctupleC x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x);

            OctupleC res = oflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static OctupleC OCplxViaArbCS2(cb1SArbC2S f, OctupleC x, OctupleC y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y);

            OctupleC res = oflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static OctupleC OCplxViaArbCS3(cb1SArbC3S f, OctupleC x, OctupleC y, OctupleC z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z);

            OctupleC res = oflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }



        public static MpfrC MCplxViaArbCS1(cb1SArbC1S f, MpfrC x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x);

            MpfrC res = mflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static MpfrC MCplxViaArbCS2(cb1SArbC2S f, MpfrC x, MpfrC y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y);

            MpfrC res = mflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static MpfrC MCplxViaArbCS3(cb1SArbC3S f, MpfrC x, MpfrC y, MpfrC z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z);

            MpfrC res = mflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }













        public static SingleC SCplxViaArbCS1Bool1(cb1SArbC1SBool f, SingleC x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x, sc);

            SingleC res = sflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static SingleC SCplxViaArbCS2Bool1(cb1SArbC2SBool f, SingleC x, SingleC y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y, sc);

            SingleC res = sflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Complex DCplxViaArbCS1Bool1(cb1SArbC1SBool f, Complex x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x, sc);

            Complex res = dflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Complex DCplxViaArbCS2Bool1(cb1SArbC2SBool f, Complex x, Complex y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y, sc);

            Complex res = dflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static ExtendedC ECplxViaArbCS1Bool1(cb1SArbC1SBool f, ExtendedC x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x, sc);

            ExtendedC res = eflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static ExtendedC ECplxViaArbCS2Bool1(cb1SArbC2SBool f, ExtendedC x, ExtendedC y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y, sc);

            ExtendedC res = eflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static QuadrupleC QCplxViaArbCS1Bool1(cb1SArbC1SBool f, QuadrupleC x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x, sc);

            QuadrupleC res = qflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static QuadrupleC QCplxViaArbCS2Bool1(cb1SArbC2SBool f, QuadrupleC x, QuadrupleC y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y, sc);

            QuadrupleC res = qflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static OctupleC OCplxViaArbCS1Bool1(cb1SArbC1SBool f, OctupleC x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x, sc);

            OctupleC res = oflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static OctupleC OCplxViaArbCS2Bool1(cb1SArbC2SBool f, OctupleC x, OctupleC y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y, sc);

            OctupleC res = oflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static MpfrC MCplxViaArbCS1Bool1(cb1SArbC1SBool f, MpfrC x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_res = f(arbc_x, sc);

            MpfrC res = mflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static MpfrC MCplxViaArbCS2Bool1(cb1SArbC2SBool f, MpfrC x, MpfrC y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_res = f(arbc_x, arbc_y, sc);

            MpfrC res = mflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }






        public static SingleC SCplxViaArbCS3Int1(cb1SArbC3SInt1 f, SingleC x, SingleC y, SingleC z, int si)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z, si);

            SingleC res = sflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Complex DCplxViaArbCS3Int1(cb1SArbC3SInt1 f, Complex x, Complex y, Complex z, int si)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z, si);

            Complex res = dflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static ExtendedC ECplxViaArbCS3Int1(cb1SArbC3SInt1 f, ExtendedC x, ExtendedC y, ExtendedC z, int si)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z, si);

            ExtendedC res = eflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static QuadrupleC QCplxViaArbCS3Int1(cb1SArbC3SInt1 f, QuadrupleC x, QuadrupleC y, QuadrupleC z, int si)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z, si);

            QuadrupleC res = qflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static OctupleC OCplxViaArbCS3Int1(cb1SArbC3SInt1 f, OctupleC x, OctupleC y, OctupleC z, int si)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z, si);

            OctupleC res = oflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static MpfrC MCplxViaArbCS3Int1(cb1SArbC3SInt1 f, MpfrC x, MpfrC y, MpfrC z, int si)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            ArbC arbc_x = aflintc.t(x);
            ArbC arbc_y = aflintc.t(y);
            ArbC arbc_z = aflintc.t(z);
            ArbC arbc_res = f(arbc_x, arbc_y, arbc_z, si);

            MpfrC res = mflintc.t(arbc_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }




        #endregion






        public static String fmt(ArbC z)
        {
            string s1 = z.real.ToString();
            string s2 = z.imag.ToString();
            string s = "(" + s1 + ", " + s2 + ")";
            return s;
        }

        public static String fmt(Arb x)
        {
            return aflint.fmt(x);
        }


        public static String fmt(dynamic z)
        {
            return fmt(t(z));
        }



        #region Acb Calculus


        #region GL_Integration



        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Set(IntPtr res, IntPtr x);


        /// <summary>
        /// Verified Gauss-Legendre integration of the function f in the interval (a,b).
        /// </summary>
        /// <param name="f"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static ArbC GaussLegendre(cbFuncApc f, ArbC a, ArbC b)
        {
            var LG1 = new LG(f, a, b);
            return LG1.Integrate();
        }
        internal class LG
        {
            private cbFuncApc F1_;
            private ArbC a_;
            private ArbC b_;
            private ArbC X1 = new ArbC();
            private ArbC Y1 = new ArbC();
            public void funcptr1(IntPtr fxPtr, IntPtr xPtr, IntPtr parameters, Int64 order, Int64 prec)
            {
                Lib_Acb_Set(X1.mpPtr, xPtr);
                Y1 = F1_(X1);
                Lib_Acb_Set(fxPtr, Y1.mpPtr);
            }
            public LG(cbFuncApc F1, ArbC a, ArbC b)
            {
                F1_ = F1;
                a_ = a;
                b_ = b;
            }
            public ArbC Integrate()
            {
                var s = new ArbC();
                uint workingprec = ArbPrec.GetPrec();
                uint verbose = 2U;
                uint rel_goal = workingprec;
                uint abs_tol_bits = workingprec;
                uint eval_limit = 0U;
                Lib_Acb_GL_Integration(s.mpPtr, funcptr1, a_.mpPtr, b_.mpPtr, IntPtr.Zero, workingprec, verbose, rel_goal, abs_tol_bits, eval_limit);
                return s;
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_GL_Integration", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_GL_Integration(IntPtr s, cbFunction3Ptr2Int32_64 F1, IntPtr a, IntPtr b, IntPtr parameters, uint prec, uint verbose, uint rel_goal, uint abs_tol_bits, uint eval_limit);


        #endregion



        #region DE_Integration



        public static Arb DE_Integration(cbFuncApc func, Arb a, Arb b, Arb epsabsStart, Arb alpha, Arb beta)
        {
            Console.WriteLine("DE_Integration");

            string ds = "";
            var pi = aflint.pi();
            var p2 = pi / 2;
            Arb K = new Arb(), d = new Arb(), C1 = new Arb(), C2 = new Arb(), epsabs = new Arb(), h = new Arb(), n = new Arb(), hmin = new Arb(), C1Final = new Arb(), epsabsFinal = new Arb();
            double radX = 0.0, radY = 0.0;

            var nmin = aflint.t("1.0E1000000000000");
            // Console.WriteLine("nmin at start: {0}", nmin)
            Arb mu = new Arb(), nu = new Arb();
            if (alpha < beta)
            {
                mu = alpha;
                nu = beta;
            }
            else
            {
                mu = beta;
                nu = alpha;
            }

            // Determine optimal h and n
            for (int d1 = 1; d1 <= 26; d1++)
            {
                GetRectAndK(d1, ref radX, ref radY, ref ds);
                d = aflint.t(ds);
                // Console.WriteLine("radX: {0:f}, radY: {1:f}, d: {2:f}, , d1: {3}", radX, radY, d, d1)
                Arb radX_ = new Arb(), radY_ = new Arb();
                radX_ = aflint.t(radX);
                radY_ = aflint.t(radY);
                K = GetAcbK(func, a.Mid, b.Mid, radX_, radY_);

                C1 = 1 / mu * 2 * K * aflint.pow(b - a, alpha + beta - 1);
                epsabs = epsabsStart / C1;
                C2 = 2 / (aflint.pow(aflint.cos(p2 * aflint.sin(d)), alpha + beta) * aflint.cos(d));
                // Console.WriteLine("C1: {0}", C1)
                // Console.WriteLine("C2: {0}", C2)
                // Console.WriteLine("epsabs: {0}", epsabs)
                h = 2 * pi * d / aflint.log(1 + 2 * C2 / epsabs);
                n = 1 / h * aflint.log(2 / (pi * mu) * aflint.log(2 * aflint.exp(p2 * nu) / epsabs));
                // Console.WriteLine("n: {0}, nmin: {1}, n < nmin: {2}", n, nmin, (n < nmin))

                if (n < nmin)
                {
                    nmin = n;
                    hmin = h;
                    C1Final = C1;
                    epsabsFinal = epsabs;
                }
            }

            Console.WriteLine("Final epsabs {0}: ", epsabsFinal);
            Console.WriteLine("Final C1 {0:f}: ", C1Final);
            // Determine NN and MM if alpha <> beta
            Console.WriteLine("hmin: {0}, nmin: {1:f}", hmin, nmin);
            int MM, NN;
            //MM = aflint.ceil(nmin).ToInt32();
            MM = (int)aflint.ceil(nmin).AsDouble();
            NN = MM;
            // Console.WriteLine("n0: {0}", NN)
            if (mu == alpha)
            {
                //NN = NN - aflint.floor(aflint.log(beta / alpha) / hmin).ToInt32();
                NN = NN - (int)aflint.floor(aflint.log(beta / alpha) / hmin).AsDouble();
            }
            else
            {
                MM = MM - (int)aflint.floor(aflint.log(alpha / beta) / hmin).AsDouble();
            }
            Console.WriteLine("NN: {0}", NN);
            Console.WriteLine("MM: {0}", MM);


            // Perform actual integration
            Arb res = new Arb(), sum = new Arb(), u = new Arb(), t = new Arb(), f = new Arb(), PHI2 = new Arb(), c = new Arb(), b1 = new Arb(), b2 = new Arb();
            Arb x1 = new Arb(), e1 = new Arb(), e2 = new Arb(), e3 = new Arb(), fp1 = new Arb(), fm1 = new Arb(), su = new Arb(), cu = new Arb(), eu1 = new Arb(), eu2 = new Arb();
            int kk;
            sum = aflint.zero();
            // c = p2 * ((b-a)/2) ^ (alpha+beta-1) 
            b1 = (b - a) / 2;
            b2 = (b + a) / 2;
            c = p2 * aflint.pow(b1, alpha + beta - 1);
            var loopTo = NN;
            for (kk = -MM; kk <= loopTo; kk++)
            {
                u = hmin * kk;
                eu1 = aflint.exp(u);
                eu2 = 1 / eu1;
                su = (eu1 - eu2) * 0.5d; // su = sinh(u)
                cu = (eu1 + eu2) * 0.5d; // cu = cosh(u)
                x1 = p2 * su;
                e1 = aflint.exp(x1); // e1 = exp(x1)
                e2 = 1 / e1; // e2 = exp(-x1)
                e3 = 1 / (e1 + e2);
                f = (e1 - e2) * e3; // f = tanh(x1) = (e1 - e2) / (e1 + e2)
                fp1 = 2 * e1 * e3; // 1+f = 2 * e1 / (e1 + e2)
                fm1 = 2 * e2 * e3; // 1-f = 2 * e2 / (e1 + e2)
                                   // PHI2 = c * Apr.cosh(u) * (Apr.abs(1+f))^alpha * (Apr.abs(1-f))^beta
                if (alpha != 1)
                    fp1 = aflint.pow(fp1, alpha);
                if (beta != 1)
                    fm1 = aflint.pow(fm1, beta);
                PHI2 = c * cu * fp1 * fm1;
                t = f * b1 + b2;
                var tc = aflintc.t(t, aflint.zero());
                // Console.WriteLine("in Int, t: {0}, tc: {1}", t, tc)
                // sum = sum + g(t) * PHI2
                sum = sum + func(tc).real * PHI2;
            }
            res = hmin * sum;
            Console.WriteLine("ED+ET: {0}", C1Final * epsabsFinal);
            Console.WriteLine("Int1: {0}", res);
            return res;
        }



        internal static void GetRectAndK(int d1, ref double radX, ref double radY, ref string ds)
        {
            switch (d1)
            {
                case 1: { radX = 165.2d; radY = 254.3d; ds = "1.5"; break; }
                case 2: { radX = 28.375d; radY = 43.75d; ds = "1.4"; break; }
                case 3: { radX = 11.3d; radY = 17.46d; ds = "1.3"; break; }
                case 4: { radX = 6.06d; radY = 9.34d; ds = "1.2"; break; }
                case 5: { radX = 3.8d; radY = 5.795d; ds = "1.1"; break; }
                case 6: { radX = 2.633d; radY = 3.933d; ds = "1.0"; break; }

                case 7: { radX = 1.968d; radY = 2.826d; ds = "0.9"; break; }
                case 8: { radX = 1.566d; radY = 2.103d; ds = "0.8"; break; }
                case 9: { radX = 1.312d; radY = 1.5994d; ds = "0.7"; break; }
                case 10: { radX = 1.1552d; radY = 1.2276d; ds = "0.6"; break; }
                case 11: { radX = 1.065d; radY = 0.937d; ds = "0.5"; break; }
                case 12: { radX = 1.0197d; radY = 0.702d; ds = "0.4"; break; }
                case 13: { radX = 1.0032d; radY = 0.5008d; ds = "0.3"; break; }
                case 14: { radX = 1.001d; radY = 0.41d; ds = "0.25"; break; }
                case 15: { radX = 1.001d; radY = 0.3228d; ds = "0.2"; break; }
                case 16: { radX = 1.001d; radY = 0.199d; ds = "0.125"; break; }
                case 17: { radX = 1.001d; radY = 0.1584d; ds = "0.1"; break; }

                case 18: { radX = 1.001d; radY = 0.1423d; ds = "0.09"; break; }
                case 19: { radX = 1.001d; radY = 0.1263d; ds = "0.08"; break; }
                case 20: { radX = 1.001d; radY = 0.11037d; ds = "0.07"; break; }
                case 21: { radX = 1.001d; radY = 0.09456d; ds = "0.06"; break; }
                case 22: { radX = 1.001d; radY = 0.0787d; ds = "0.05"; break; }
                case 23: { radX = 1.001d; radY = 0.06296d; ds = "0.04"; break; }
                case 24: { radX = 1.001d; radY = 0.0472d; ds = "0.03"; break; }
                case 25: { radX = 1.001d; radY = 0.03145d; ds = "0.02"; break; }
                case 26: { radX = 1.0d; radY = 0.01572d; ds = "0.01"; break; }

                default: { Console.WriteLine("Error"); break; }
            }


        }



        internal static Arb GetAcbK(cbFuncApc func, Arb a, Arb b, Arb radX, Arb radY)
        {
            ArbC x = new ArbC(), z = new ArbC();
            Arb ba2 = new Arb(), av = new Arb(), x_re = new Arb(), x_im = new Arb();
            ba2 = (b - a) / 2;
            x_re.Mid = (b + a) / 2;
            x_re.Rad = ba2 * radX;
            x_im.Mid = aflint.zero();
            x_im.Rad = ba2 * radY;
            //x.Real = x_re;
            //x.Imag = x_im;

            x = aflintc.t(x_re, x_im);

            // Console.WriteLine("x.real.Infimum: {0}, x.imag.Supremum: {1}",x.real.Infimum, x.imag.Supremum)
            z = func(x);
            av = aflintc.abs(z);
            return av.Supremum();
        }

        #endregion










        #endregion






        #region Basic Functions





        #region General

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "aflintc"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return "aflintc"; }
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
            get { return true; }
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
            get { return false; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/SupportsBoost/*' />
        public static bool SupportsBoost
        {
            get { return false; }
        }


        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/realctx/*' />
        public static aflint realctx
        {
            get { return new aflint(); }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/CplxCtx/*' />
        public static aflintc CplxCtx
        {
            get { return new aflintc(); }
        }


        #endregion



        #region Conversions




        /// <summary>
        /// Returns a new ArbC using an extended precision floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(Arb x)
        {
            var res = new ArbC();
            Lib_Acb_Set_Real(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Set_Real", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Set_Real(IntPtr res, IntPtr x);




        /// <summary>
        /// Returns a new ArbC using an arbitrary precision (both mantissa and exponent) ball number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC T_(Arb x)
        {
            return aflintc.t(aflint.t(x));
        }








        /// <summary>
        /// Returns a new BallC using an arbitrary precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(Mpfr x)
        {
            return aflintc.t(aflint.t(x));
        }







        /// <summary>
        /// Returns a new ArbC using a octuple precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(Octuple x)
        {
            return aflintc.t(aflint.t(x));
        }



        /// <summary>
        /// Returns a new ArbC using a quadruple precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(Quadruple x)
        {
            return aflintc.t(aflint.t(x));
        }



        /// <summary>
        /// Returns a new ArbC using an extended precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(Extended x)
        {
            return aflintc.t(aflint.t(x));
        }



        /// <summary>
        /// Returns a new BallC using a double precision binary floating point number for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(double x)
        {
            return aflintc.t(aflint.t(x));
        }



        /// <summary>
        /// Returns a new ArbC using a single precision binary floating point number as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(Single x)
        {
            return aflintc.t(aflint.t(x));
        }



        /// <summary>
        /// Returns a new BallC using a signed 32 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(Int32 x)
        {
            return aflintc.t(aflint.t(x));
        }


        /// <summary>
        /// Returns a new ArbC using an unsigned 32 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(UInt32 x)
        {
            return aflintc.t(aflint.t(x));
        }


        /// <summary>
        /// Returns a new ArbC using a signed 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(Int64 x)
        {
            return aflintc.t(aflint.t(x));
        }


        /// <summary>
        /// Returns a new ArbC using an unsigned 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(UInt64 x)
        {
            return aflintc.t(aflint.t(x));
        }


        /// <summary>
        /// Returns a new ArbC using a System.Decimal as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(decimal x)
        {
            return aflintc.t(aflint.t(x));
        }


        /// <summary>
        /// Returns a new ArbC using an unsigned 64 bit integer as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(BigInteger x)
        {
            return aflintc.t(aflint.t(x));
        }


        /// <summary>
        /// Returns a new ArbC using a string as input for the real part; the imaginary part is set to zero.
        /// </summary>
        public static ArbC t(string s)
        {
            return aflintc.t(aflint.t(s));
        }



        /// <summary>
        /// Returns a new ArbC using 2 Arb as input for the real and imaginary part
        /// </summary>
        public static ArbC t(Arb re, Arb im)
        {
            var res = new ArbC();
            Lib_Acb_Set2(res.mpPtr, re.mpPtr, im.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Set2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Set2(IntPtr res, IntPtr re, IntPtr im);



        /// <summary>
        /// Returns a new ArbC using a complex arbitrary (both mantissa and exponent) precision ball number as input
        /// </summary>
        public static ArbC t(ArbC z)
        {
            return aflintc.t(aflint.t(z.real), aflint.t(z.imag));
        }





        /// <summary>
        /// Returns a new BallC using a complex arbitrary precision binary floating point number as input
        /// </summary>
        public static ArbC t(MpfrC z)
        {
            return aflintc.t(aflint.t(z.real), aflint.t(z.imag));
        }




        /// <summary>
        /// Returns a new ArbC using a complex quadruple precision binary floating point number as input
        /// </summary>
        public static ArbC t(QuadrupleC z)
        {
            return aflintc.t(aflint.t(z.real), aflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new ArbC using a complex extended precision binary floating point number as input
        /// </summary>
        public static ArbC t(ExtendedC z)
        {
            return aflintc.t(aflint.t(z.real), aflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new BallC using a complex double precision binary floating point number (System.Complex) as input
        /// </summary>
        public static ArbC t(Complex z)
        {
            return aflintc.t(aflint.t(z.Real), aflint.t(z.Imaginary));
        }





        /// <summary>
        /// Returns a new ArbC using a complex single precision binary floating point number as input
        /// </summary>
        public static ArbC t(SingleC z)
        {
            return aflintc.t(aflint.t(z.real), aflint.t(z.imag));
        }



        /// <summary>
        /// Returns a new BallC using 2 double as input for the real and imaginary part
        /// </summary>
        public static ArbC t(Double d_re, Double d_im)
        {
            return aflintc.t(aflint.t(d_re), aflint.t(d_im));
        }


        /// <summary>
        /// Returns a new ArbC using 2 strings as input for the real and imaginary part
        /// </summary>
        public static ArbC t(string s_re, string s_im)
        {
            return aflintc.t(aflint.t(s_re), aflint.t(s_im));
        }


        /// <summary>
        /// Returns a new ArbC using a general object as input
        /// </summary>
        public static ArbC t(dynamic z)
        {
            // MsgBox(y_.GetType().ToString())
            // MsgBox(y_.ToString())
            // MsgBox(y_.real.ToString())
            string s_re = z.real.ToString();
            string s_im = z.imag.ToString();
            return aflintc.t(aflint.t(s_re), aflint.t(s_im));
        }


        #endregion





        #region Basic Arithmetic and Comparisons


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/add/*' />
        public static ArbC add(ArbC x, ArbC y)
        {
            return x + y;
        }
        public static ArbC add(dynamic x, dynamic y)
        {
            return t(x) + t(y);
        }

        public static void rawadd(ArbC res, ArbC x, ArbC y)
        {
            Lib_Acb_Add(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Add(IntPtr res, IntPtr x, IntPtr y);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/subtract/*' />
        public static ArbC subtract(ArbC x, ArbC y)
        {
            return x - y;
        }
        public static ArbC subtract(dynamic x, dynamic y)
        {
            return t(x) - t(y);
        }

        public static void rawsub(ArbC res, ArbC x, ArbC y)
        {
            Lib_Acb_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Sub(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/multiply/*' />
        public static ArbC multiply(ArbC x, ArbC y)
        {
            return x * y;
        }
        public static ArbC multiply(dynamic x, dynamic y)
        {
            return t(x) * t(y);
        }

        public static void rawmul(ArbC res, ArbC x, ArbC y)
        {
            Lib_Acb_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Mul(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/divide/*' />
        public static ArbC divide(ArbC x, ArbC y)
        {
            return x / y;
        }
        public static ArbC divide(dynamic x, dynamic y)
        {
            return t(x) / t(y);
        }

        public static void rawdiv(ArbC res, ArbC x, ArbC y)
        {
            Lib_Acb_Div(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Div(IntPtr res, IntPtr x, IntPtr y);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Cmp/*' />
        public static bool Cmp(ArbC x, ArbC y)
        {
            return true;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CmpAbs/*' />
        public static bool CmpAbs(ArbC x, ArbC y)
        {
            return true;
        }




        public static ArbC PowUi(ArbC x, UInt64 y)
        {
            var res = new ArbC();
            Lib_Acb_Pow_Ui(res.mpPtr, x.mpPtr, y);
            return res;

        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Pow_Ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Pow_Ui(IntPtr res, IntPtr x, UInt64 y);


        public static ArbC RootUi(ArbC x, UInt64 y)
        {
            var res = new ArbC();
            Lib_Acb_Root_Ui(res.mpPtr, x.mpPtr, y);
            return res;

        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Root_Ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Root_Ui(IntPtr res, IntPtr x, UInt64 y);



        #endregion



        #region Machine constants and properties of numbers



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(ArbC z)
        {
            return (z.real == aflint.t(0)) && (z.imag == aflint.t(0));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(ArbC z)
        {
            return (z.real == aflint.t(1)) && (z.imag == aflint.t(0));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(ArbC z)
        {
            return (aflint.isinf(z.real)) || (aflint.isinf(z.imag));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(ArbC z)
        {
            return (aflint.isnan(z.real)) || (aflint.isnan(z.imag));
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(ArbC z)
        {
            return (aflint.isfinite(z.real)) && (aflint.isfinite(z.imag));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static ArbC zero()
        {
            return aflintc.t(0d, 0d);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static ArbC one()
        {
            return aflintc.t(1d, 0d);
        }


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static ArbC onej()
        {
            return aflintc.t(0d, 1d);
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static ArbC nan()
        {
            return aflintc.t(aflint.nan(), aflint.nan());
        }




        #endregion



        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Arb abs(ArbC x)
        {
            var res = new Arb();
            Lib_Acb_Abs(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Abs", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Abs(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Arb abs(dynamic x)
        {
            return abs(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Arb fabs(ArbC x)
        {
            return abs(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Arb fabs(dynamic x)
        {
            return fabs(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static ArbC sign(ArbC z)
        {
            if (iszero(z)) return zero();
            else return z / abs(z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static ArbC sign(dynamic z)
        {
            return sign(t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Arb real(ArbC z)
        {
            return z.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Arb real(dynamic x)
        {
            return real(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Arb imag(ArbC z)
        {
            return z.imag;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Arb imag(dynamic x)
        {
            return imag(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Arb phase(ArbC x)
        {
            var res = new Arb();
            Lib_Acb_Arg(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Arg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Arg(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Arb phase(dynamic x)
        {
            return phase(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static ArbC conj(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Conj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Conj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Conj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static ArbC conj(dynamic x)
        {
            return conj(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Arb, Arb> polar(ArbC x)
        {
            return new Tuple<Arb, Arb>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Arb, Arb> polar(dynamic x)
        {
            return polar(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static ArbC rect(Arb r, Arb phi)
        {
            return r * expj(phi);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rect/*' />
        public static ArbC rect(dynamic r, dynamic phi)
        {
            return rect(aflint.t(r), aflint.t(phi));
        }






        #endregion



        #region Roots and quadratic, cubic, and quartic 



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static ArbC sqrt(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static ArbC sqrt(dynamic x)
        {
            return sqrt(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static ArbC sqrt1pm1(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static ArbC sqrt1pm1(dynamic x)
        {
            return cbrt(aflintc.t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static ArbC rsqrt(ArbC x)
        {
            return 1.0 / sqrt(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static ArbC rsqrt(dynamic x)
        {
            return rsqrt(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static ArbC cbrt(ArbC x)
        {
            ArbC ks = aflintc.t(3);
            return aflintc.pow(x, 1 / ks);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static ArbC cbrt(dynamic x)
        {
            return cbrt(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static ArbC unitroot(Int32 k)
        {
            ArbC ks = aflintc.t(k);
            return aflintc.pow(one(), one() / ks);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/unitroot/*' />
        public static ArbC unitroot(dynamic x)
        {
            return unitroot(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static ArbC root_si(ArbC x, Int32 n)
        {
            var res = new ArbC();
            Lib_Acb_Root_Si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Root_Si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Root_Si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static ArbC root_si(dynamic x, Int32 n)
        {
            return root_si(t(x), n);
        }




        #region poly_equations


        public static ArbC eval_quadratic(ArbC x, ArbC A, ArbC B, ArbC C)
        {
            return (A * x + B) * x + C;
        }

        public static ArbC eval_quadratic(dynamic x, dynamic A, dynamic B, dynamic C)
        {
            return eval_quadratic(aflintc.t(x), aflintc.t(A), aflintc.t(B), aflintc.t(C));
        }


        // See also: Press, 3rd edition, page 227
        public static Tuple<ArbC, ArbC> quadratic_equation(ArbC a, ArbC b, ArbC c)
        {
            ArbC x1, x2;
            ArbC D = aflintc.sqrt(b * b - 4 * a * c);
            ArbC bStar = aflintc.conj(b);
            if ((bStar * D).real < aflint.t(0))
            {
                D = -D;
            }
            ArbC q = -0.5 * (b + D);
            x1 = q / a;
            x2 = c / q;
            return new Tuple<ArbC, ArbC>(x1, x2);
        }
        public static Tuple<ArbC, ArbC> quadratic_equation(dynamic A, dynamic B, dynamic C)
        {
            return quadratic_equation(aflintc.t(A), aflintc.t(B), aflintc.t(C));
        }




        public static ArbC eval_monic_cubic(ArbC x, ArbC a, ArbC b, ArbC c)
        {
            return ((x + a) * x + b) * x + c;
        }

        public static ArbC eval_monic_cubic(dynamic x, dynamic a, dynamic b, dynamic c)
        {
            return eval_monic_cubic(aflintc.t(x), aflintc.t(a), aflintc.t(b), aflintc.t(c));
        }


        // See also: Press, 3rd edition, page 228
        public static Tuple<ArbC, ArbC, ArbC> cubic_equation_monic(ArbC a, ArbC b, ArbC c)
        {
            ArbC x1, x2, x3;
            ArbC Q = (a * a - 3 * b) / 9;
            ArbC R = (2 * a * a * a - 9 * a * b + 27 * c) / 54;
            Arb Qr = Q.real;
            Arb Rr = R.real;
            if ((Q.imag == aflint.t(0.0)) && (R.imag == aflint.t(0.0)) && (Rr * Rr < Qr * Qr * Qr))
            {
                Console.WriteLine("In aflintc real Case");
                Arb SqrtQr = aflint.sqrt(Qr);
                Arb theta = aflint.acos(Rr / (SqrtQr * SqrtQr * SqrtQr));
                x1 = -2 * SqrtQr * aflint.cos((theta) / 3) - a / 3;
                x2 = -2 * SqrtQr * aflint.cos((theta + 2 * aflint.pi()) / 3) - a / 3;
                x3 = -2 * SqrtQr * aflint.cos((theta - 2 * aflint.pi()) / 3) - a / 3;
            }
            else
            {
                Console.WriteLine("In aflintc ArbC Case");
                ArbC D = aflintc.sqrt(R * R - Q * Q * Q);
                ArbC RStar = aflintc.conj(R);
                if ((RStar * D).real < aflint.t(0))
                {
                    D = -D;
                }
                ArbC A = -aflintc.cbrt(R + D);
                ArbC B = aflintc.zero();
                if (A != aflintc.zero())
                {
                    B = Q / A;
                }
                Console.WriteLine("A: {0}", A);
                Console.WriteLine("B: {0}", B);

                x1 = (A + B) - a / 3;
                x2 = -0.5 * (A + B) - a / 3 + 0.5 * aflintc.onej() * aflint.sqrt(3) * (A - B);
                x3 = -0.5 * (A + B) - a / 3 - 0.5 * aflintc.onej() * aflint.sqrt(3) * (A - B);
            }
            return new Tuple<ArbC, ArbC, ArbC>(x1, x2, x3);
        }
        public static Tuple<ArbC, ArbC, ArbC> cubic_equation_monic(dynamic a, dynamic b, dynamic c)
        {
            return cubic_equation_monic(aflintc.t(a), aflintc.t(b), aflintc.t(c));
        }





        public static ArbC eval_cubic(ArbC x, ArbC A, ArbC B, ArbC C, ArbC D)
        {
            return ((A * x + B) * x + C) * x + D;
        }

        public static ArbC eval_cubic(dynamic x, dynamic A, dynamic B, dynamic C, dynamic D)
        {
            return eval_cubic(aflintc.t(x), aflintc.t(A), aflintc.t(B), aflintc.t(C), aflintc.t(D));
        }

        public static Tuple<ArbC, ArbC, ArbC> cubic_equation(ArbC A, ArbC B, ArbC C, ArbC D)
        {
            return cubic_equation_monic(B / A, C / A, D / A);
        }
        public static Tuple<ArbC, ArbC, ArbC> cubic_equation(dynamic A, dynamic B, dynamic C, dynamic D)
        {
            return cubic_equation(aflintc.t(A), aflintc.t(B), aflintc.t(C), aflintc.t(D));
        }






        public static ArbC eval_quartic(ArbC x, ArbC A, ArbC B, ArbC C, ArbC D, ArbC E)
        {
            return (((A * x + B) * x + C) * x + D) * x + E;
        }

        public static ArbC eval_quartic(dynamic x, dynamic A, dynamic B, dynamic C, dynamic D, dynamic E)
        {
            return eval_quartic(aflintc.t(x), aflintc.t(A), aflintc.t(B), aflintc.t(C), aflintc.t(D), aflintc.t(E));
        }


        // See also: https://en.wikipedia.org/wiki/Quartic_equation#Summary_of_Ferrari's_method
        public static Tuple<ArbC, ArbC, ArbC, ArbC> quartic_equation(ArbC A, ArbC B, ArbC C, ArbC D, ArbC E)
        {
            ArbC x1, x2, x3, x4;
            ArbC a = -(3 * B * B) / (8 * A * A) + C / A;
            ArbC b = (B * B * B) / (8 * A * A * A) - (B * C) / (2 * A * A) + D / A;
            ArbC c = -(3 * B * B * B * B) / (256 * A * A * A * A) + (C * B * B) / (16 * A * A * A) - (B * D) / (4 * A * A) + E / A;
            ArbC V = -B / (4 * A);

            if (aflintc.iszero(b))
            {
                ArbC W = aflintc.sqrt(a * a - 4 * c);
                ArbC Z1 = aflintc.sqrt((-a + W) / 2);
                ArbC Z2 = aflintc.sqrt((-a - W) / 2);
                x1 = V + Z1;
                x2 = V - Z1;
                x3 = V + Z2;
                x4 = V - Z2;
            }
            else
            {
                ArbC e = 5 * a / 2;
                ArbC f = 2 * a * a - c;
                ArbC g = a * a * a / 2 - a * c / 2 - b * b / 8;
                var res = cubic_equation_monic(e, f, g);
                ArbC y = res.Item1;
                ArbC W = aflintc.sqrt(a + 2 * y);
                ArbC Z1 = aflintc.sqrt(-(3 * a + 2 * y + 2 * b / W));
                ArbC Z2 = aflintc.sqrt(-(3 * a + 2 * y - 2 * b / W));
                x1 = V + (W + Z1) / 2;
                x2 = V + (W - Z1) / 2;
                x3 = V - (W + Z2) / 2;
                x4 = V - (W - Z2) / 2;
            }
            return new Tuple<ArbC, ArbC, ArbC, ArbC>(x1, x2, x3, x4);
        }

        public static Tuple<ArbC, ArbC, ArbC, ArbC> quartic_equation(dynamic A, dynamic B, dynamic C, dynamic D, dynamic E)
        {
            return quartic_equation(aflintc.t(A), aflintc.t(B), aflintc.t(C), aflintc.t(D), aflintc.t(E));
        }


        #endregion









        #endregion



        #region Exponential and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static ArbC exp(ArbC x)
        {
            //MessageBox.Show("C#, ArbC: " + x.ToString());
            var res = new ArbC();
            Lib_Acb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static ArbC exp(dynamic x)
        {
            return exp(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static ArbC expj(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Expj(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Expj", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Expj(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static ArbC expj(dynamic x)
        {
            return expj(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static ArbC expjpi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Expjpi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Expjpi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Expjpi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static ArbC expjpi(dynamic x)
        {
            return expjpi(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static ArbC exp10(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static ArbC exp10(dynamic x)
        {
            return exp10(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static ArbC exp2(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static ArbC exp2(dynamic x)
        {
            return exp2(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static ArbC expm1(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static ArbC expm1(dynamic x)
        {
            return expm1(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static ArbC exp10m1(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static ArbC exp10m1(dynamic x)
        {
            return exp10m1(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static ArbC exp2m1(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static ArbC exp2m1(dynamic x)
        {
            return exp2m1(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static ArbC exprel(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static ArbC exprel(dynamic x)
        {
            return exprel(aflintc.t(x));
        }






        #endregion



        #region Logarithms and related functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static ArbC log(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static ArbC log(dynamic x)
        {
            return log(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static ArbC log1p(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static ArbC log1p(dynamic x)
        {
            return log1p(aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static ArbC log2(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static ArbC log2(dynamic x)
        {
            return log2(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static ArbC log10(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static ArbC log10(dynamic x)
        {
            return log10(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static ArbC logbase(ArbC x, ArbC b)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static ArbC logbase(dynamic x, dynamic b)
        {
            return logbase(aflintc.t(x), aflintc.t(b));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static ArbC log10p1(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static ArbC log10p1(dynamic x)
        {
            return log10p1(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static ArbC log2p1(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static ArbC log2p1(dynamic x)
        {
            return log2p1(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static ArbC lambert_wk(ArbC x, int branch)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LambertW_ui(res.mpPtr, x.mpPtr, branch);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LambertW_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LambertW_ui(IntPtr res, IntPtr x, int branch);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static ArbC lambert_wk(dynamic x, int branch)
        {
            return lambert_wk(aflintc.t(x), branch);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static ArbC lambert_w0(ArbC x)
        {
            return lambert_wk(aflintc.t(x), 0);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static ArbC lambert_w0(dynamic x)
        {
            return lambert_w0(aflintc.t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static ArbC lambert_wm1(ArbC x)
        {
            return lambert_wk(aflintc.t(x), -1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static ArbC lambert_wm1(dynamic x)
        {
            return lambert_wm1(aflintc.t(x));
        }










        #endregion



        #region Power functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static ArbC sqr(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static ArbC sqr(dynamic x)
        {
            return sqr(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static ArbC cube(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static ArbC cube(dynamic x)
        {
            return cube(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static ArbC hypot(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static ArbC hypot(dynamic x, dynamic y)
        {
            return hypot(aflintc.t(x), aflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static ArbC pow_si(ArbC x, Int32 n)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Pow_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Pow_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Pow_ui(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static ArbC pow_si(dynamic x, Int32 n)
        {
            return pow_si(aflintc.t(x), n);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static ArbC compound_si(ArbC x, Int32 n)
        {
            return pow1p(t(x), t(n));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static ArbC compound_si(dynamic x, Int32 n)
        {
            return pow1p(t(x), t(n));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static ArbC pow(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static ArbC pow(dynamic x, dynamic y)
        {
            return pow(aflintc.t(x), aflintc.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static ArbC powm1(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static ArbC powm1(dynamic x, dynamic y)
        {
            return powm1(aflintc.t(x), aflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static ArbC pow1p(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static ArbC pow1p(dynamic x, dynamic y)
        {
            return pow1p(aflintc.t(x), aflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static ArbC pow1pm1(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static ArbC pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(aflintc.t(x), aflintc.t(y));
        }





        #endregion



        #region Trigonometric and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static ArbC sin(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static ArbC sin(dynamic x)
        {
            return sin(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static ArbC cos(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static ArbC cos(dynamic x)
        {
            return cos(t(x));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static ArbC tan(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Tan(IntPtr res, IntPtr x);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static ArbC tan(dynamic x)
        {
            return tan(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static ArbC cot(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static ArbC cot(dynamic x)
        {
            return cot(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static ArbC sec(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static ArbC sec(dynamic x)
        {
            return sec(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static ArbC csc(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static ArbC csc(dynamic x)
        {
            return csc(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static ArbC sinc(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static ArbC sinc(dynamic x)
        {
            return sinc(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static ArbC sinpi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static ArbC sinpi(dynamic x)
        {
            return sinpi(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static ArbC cospi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static ArbC cospi(dynamic x)
        {
            return cospi(aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static ArbC tanpi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static ArbC tanpi(dynamic x)
        {
            return tanpi(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static ArbC cscpi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CscPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CscPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CscPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static ArbC cscpi(dynamic x)
        {
            return cscpi(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static ArbC secpi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_SecPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_SecPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_SecPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static ArbC secpi(dynamic x)
        {
            return secpi(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static ArbC cotpi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static ArbC cotpi(dynamic x)
        {
            return cotpi(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static ArbC sincpi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static ArbC sincpi(dynamic x)
        {
            return sincpi(aflintc.t(x));
        }





        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static ArbC cosh(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static ArbC cosh(dynamic x)
        {
            return cosh(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static ArbC sinh(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static ArbC sinh(dynamic x)
        {
            return sinh(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static ArbC tanh(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static ArbC tanh(dynamic x)
        {
            return tanh(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static ArbC csch(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static ArbC csch(dynamic x)
        {
            return csch(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static ArbC sech(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static ArbC sech(dynamic x)
        {
            return sech(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static ArbC coth(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static ArbC coth(dynamic x)
        {
            return coth(aflintc.t(x));
        }









        #endregion



        #region Inverse trigonometric functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static ArbC acos(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static ArbC acos(dynamic x)
        {
            return acos(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static ArbC asin(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static ArbC asin(dynamic x)
        {
            return asin(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static ArbC atan(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static ArbC atan(dynamic x)
        {
            return atan(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static ArbC acsc(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static ArbC acsc(dynamic x)
        {
            return acsc(aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static ArbC asec(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static ArbC asec(dynamic x)
        {
            return asec(aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static ArbC acot(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static ArbC acot(dynamic x)
        {
            return acot(aflintc.t(x));
        }





        #endregion



        #region Inverse hyperbolic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static ArbC acosh(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static ArbC acosh(dynamic x)
        {
            return acosh(t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static ArbC asinh(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static ArbC asinh(dynamic x)
        {
            return asinh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static ArbC atanh(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static ArbC atanh(dynamic x)
        {
            return atanh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static ArbC acsch(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static ArbC acsch(dynamic x)
        {
            return acsch(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static ArbC asech(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static ArbC asech(dynamic x)
        {
            return asech(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static ArbC acoth(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static ArbC acoth(dynamic x)
        {
            return acoth(aflintc.t(x));
        }





        #endregion




        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static ArbC gamma(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Gamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static ArbC gamma(dynamic x)
        {
            return gamma(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static ArbC lgamma(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static ArbC lgamma(dynamic x)
        {
            return lgamma(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static ArbC rgamma(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static ArbC rgamma(dynamic x)
        {
            return rgamma(aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static ArbC gamma1pm1(ArbC x)
        {
            return gamma(x + 1) - 1;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static ArbC gamma1pm1(dynamic x)
        {
            return gamma1pm1(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static ArbC factorial(ArbC x)
        {
            return gamma(x + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static ArbC factorial(dynamic x)
        {
            return factorial(aflintc.t(x));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static ArbC doublefactorial(ArbC x)
        {
            return exp2(x / 2) * pow(aflint.pi() / 2, (cospi(x) - 1) / 4) * gamma(x / 2 + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static ArbC doublefactorial(dynamic x)
        {
            return doublefactorial(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static ArbC rising_factorial(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_RisingFactorial(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_RisingFactorial(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static ArbC rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(aflintc.t(x), aflintc.t(y));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static ArbC falling_factorial(ArbC a, ArbC n)
        {
            return rising_factorial(a - n + 1, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static ArbC falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(aflintc.t(a), aflintc.t(n));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static ArbC gamma_ratio(ArbC a, ArbC b)
        {
            return gamma(a) / gamma(b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static ArbC gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(aflintc.t(a), aflintc.t(b));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static ArbC gamma_delta_ratio(ArbC a, ArbC delta)
        {
            return gamma(a) / gamma(a + delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static ArbC gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(aflintc.t(a), aflintc.t(delta));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static ArbC beta(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static ArbC beta(dynamic x, dynamic y)
        {
            return beta(aflintc.t(x), aflintc.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static ArbC binomial(ArbC n, ArbC k)
        {
            return gamma(n + 1) / (gamma(k + 1) * gamma(n - k + 1));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static ArbC binomial(dynamic n, dynamic k)
        {
            return binomial(aflintc.t(n), aflintc.t(k));
        }




        #endregion







        #region Matrix Creation



        /// <summary>
        /// Converts from a complex scalar of type ArbC
        /// </summary>
        public static ArbMatC mat_t(ArbC x)
        {
            var matA = new ArbMatC();
            matA[0, 0] = x;
            return matA;
        }



        /// <summary>
        /// Converts from a real matrix of type ArbMat
        /// </summary>
        public static ArbMatC mat_t(ArbMat matA)
        {
            var x = mat_zeros(matA.rows, matA.cols);
            Interop.Lib_ConvertMatrixAndPoly(x.mpPtr, constants.mp_conv_mat_set_real_part_in_complex, constants.mp_apc, constants.mp_apc, matA.mpPtr);
            return x;
        }

        /// <summary>
        /// Makes a deep copy from a complex matrix of type ArbMatC
        /// </summary>
        public static ArbMatC mat_t(ArbMatC matA)
        {
            var matX = mat_zeros(matA.rows, matA.cols);
            matX = +matA;
            return matX;
        }



        /// <summary>
        /// Returns SetZero
        /// </summary>
        public static ArbMatC mat_zeros(int n, int m)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_setZero, n, m);
            return resout;
        }



        /// <summary>
        /// Returns SetOnes
        /// </summary>
        public static ArbMatC mat_ones(int n, int m)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_setOnes, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static ArbMatC mat_identity(int n, int m)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static ArbMatC mat_eye(int n, int m)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns Random
        /// </summary>
        public static ArbMatC mat_random(int n, int m)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_setRandom_nm, n, m);
            return resout;
        }


        /// <summary>
        /// Returns RandomSym
        /// </summary>
        public static ArbMatC mat_random_symmetric(int n)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_setRandomSymmetric, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSa
        /// </summary>
        public static ArbMatC mat_random_selfadjoint(int n)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_setRandomSA, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSaPosdef
        /// </summary>
        public static ArbMatC mat_random_selfadjoint_posdef(int n)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_setRandomSAPosDef, n, n);
            return resout;
        }


        /// <summary>
        /// Returns FillLinear
        /// </summary>
        public static ArbMatC mat_fill_linear(int n, int m)
        {
            var resout = new ArbMatC();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apc, resout, constants.mp_FillLinear, n, m);
            return resout;
        }



        #endregion





        #endregion






        #region Special Functions


        #region Elliptic conversions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        internal static ArbC QfromK(ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_QfromK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_QfromK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_QfromK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/QfromK/*' />
        internal static ArbC QfromK(dynamic k)
        {
            return QfromK(aflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        internal static ArbC TfromUQ(ArbC u, ArbC q)
        {
            var res = new ArbC();
            Lib_Acb_Acb_TfromUQ(res.mpPtr, u.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_TfromUQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_TfromUQ(IntPtr res, IntPtr u, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/TfromUQ/*' />
        internal static ArbC TfromUQ(dynamic n, dynamic k)
        {
            return TfromUQ(aflintc.t(n), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        internal static ArbC SnTQ(ArbC t, ArbC q)
        {
            var res = new ArbC();
            Lib_Acb_Acb_SnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_SnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_SnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/SnTQ/*' />
        internal static ArbC SnTQ(dynamic t, dynamic q)
        {
            return SnTQ(aflintc.t(t), aflintc.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        internal static ArbC CnTQ(ArbC t, ArbC q)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_CnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/CnTQ/*' />
        internal static ArbC CnTQ(dynamic t, dynamic q)
        {
            return CnTQ(aflintc.t(t), aflintc.t(q));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        internal static ArbC DnTQ(ArbC t, ArbC q)
        {
            var res = new ArbC();
            Lib_Acb_Acb_DnTQ(res.mpPtr, t.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_DnTQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_DnTQ(IntPtr res, IntPtr t, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/DnTQ/*' />
        internal static ArbC DnTQ(dynamic t, dynamic q)
        {
            return DnTQ(aflintc.t(t), aflintc.t(q));
        }

        #endregion






        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static ArbC elliptic_rc(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static ArbC elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(aflintc.t(x), aflintc.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static ArbC elliptic_rf(ArbC x, ArbC y, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static ArbC elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(aflintc.t(x), aflintc.t(y), aflintc.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static ArbC elliptic_rg(ArbC x, ArbC y, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static ArbC elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(aflintc.t(x), aflintc.t(y), aflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static ArbC elliptic_rd(ArbC x, ArbC y, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static ArbC elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(aflintc.t(x), aflintc.t(y), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static ArbC elliptic_rj(ArbC x, ArbC y, ArbC z, ArbC w)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static ArbC elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(aflintc.t(x), aflintc.t(y), aflintc.t(z), aflintc.t(w));
        }




        #endregion




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static ArbC m_elliptic_k(ArbC m)
        {
            var res = new ArbC();
            Lib_Acb_Acb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static ArbC m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static ArbC m_elliptic_e(ArbC m)
        {
            var res = new ArbC();
            Lib_Acb_Acb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static ArbC m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static ArbC m_elliptic_pi(ArbC n, ArbC m)
        {
            var res = new ArbC();
            Lib_Acb_Acb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static ArbC m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(aflintc.t(x), aflintc.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static ArbC m_elliptic_f(ArbC phi, ArbC m)
        {
            var res = new ArbC();
            Lib_Acb_Acb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static ArbC m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(aflintc.t(phi), aflintc.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static ArbC m_elliptic_e_inc(ArbC phi, ArbC m)
        {
            var res = new ArbC();
            Lib_Acb_Acb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static ArbC m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(aflintc.t(phi), aflintc.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static ArbC m_elliptic_pi_inc(ArbC n, ArbC phi, ArbC m)
        {
            var res = new ArbC();
            Lib_Acb_Acb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static ArbC m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(aflintc.t(n), aflintc.t(phi), aflintc.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static ArbC elliptic_k(ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static ArbC elliptic_k(dynamic k)
        {
            return elliptic_k(aflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static ArbC elliptic_e(ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static ArbC elliptic_e(dynamic k)
        {
            return elliptic_e(aflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static ArbC elliptic_pi(ArbC n, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static ArbC elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(aflintc.t(n), aflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static ArbC elliptic_f(ArbC phi, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static ArbC elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(aflintc.t(phi), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static ArbC elliptic_e_inc(ArbC phi, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static ArbC elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(aflintc.t(phi), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static ArbC elliptic_pi_inc(ArbC n, ArbC phi, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static ArbC elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(aflintc.t(n), aflintc.t(phi), aflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static ArbC agm(ArbC x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static ArbC agm(dynamic x, dynamic y)
        {
            return agm(aflintc.t(x), aflintc.t(y));
        }


        #endregion



        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static ArbC jacobi_sn(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static ArbC jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static ArbC jacobi_cn(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static ArbC jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static ArbC jacobi_dn(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static ArbC jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static ArbC jacobi_ns(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static ArbC jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static ArbC jacobi_nc(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static ArbC jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static ArbC jacobi_nd(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static ArbC jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static ArbC jacobi_sc(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static ArbC jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static ArbC jacobi_sd(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static ArbC jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static ArbC jacobi_dc(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static ArbC jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static ArbC jacobi_ds(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static ArbC jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static ArbC jacobi_cs(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static ArbC jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(aflintc.t(x), aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static ArbC jacobi_cd(ArbC x, ArbC k)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static ArbC jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(aflintc.t(x), aflintc.t(k));
        }




        #endregion




        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static ArbC jacobi_theta1(ArbC x, ArbC q)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static ArbC jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(aflintc.t(x), aflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static ArbC jacobi_theta2(ArbC x, ArbC q)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static ArbC jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(aflintc.t(x), aflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static ArbC jacobi_theta3(ArbC x, ArbC q)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static ArbC jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(aflintc.t(x), aflintc.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static ArbC jacobi_theta4(ArbC x, ArbC q)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static ArbC jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(aflintc.t(x), aflintc.t(q));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        internal static ArbC JacobiTheta1Tau(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Theta1QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Theta1QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Theta1QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta1Tau/*' />
        internal static ArbC JacobiTheta1Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta1Tau(aflintc.t(z), aflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        internal static ArbC JacobiTheta2Tau(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Theta2QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Theta2QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Theta2QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta2Tau/*' />
        internal static ArbC JacobiTheta2Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta2Tau(aflintc.t(z), aflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        internal static ArbC JacobiTheta3Tau(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Theta3QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Theta3QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Theta3QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta3Tau/*' />
        internal static ArbC JacobiTheta3Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta3Tau(aflintc.t(z), aflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        internal static ArbC JacobiTheta4Tau(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Theta4QTau(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Theta4QTau", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_Theta4QTau(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/JacobiTheta4Tau/*' />
        internal static ArbC JacobiTheta4Tau(dynamic z, dynamic tau)
        {
            return JacobiTheta4Tau(aflintc.t(z), aflintc.t(tau));
        }






        #endregion





        #region Conversions of parameters of Weierstrass P


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ArbC, ArbC> elliptic_invariants_from_roots(ArbC e1, ArbC e2)
        {
            ArbC e3 = -e1 - e2;
            ArbC g2 = 2 * (e1 * e1 + e2 * e2 + e3 * e3);
            ArbC g3 = 4 * e1 * e2 * e3;
            return new Tuple<ArbC, ArbC>(g2, g3);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ArbC, ArbC> elliptic_invariants_from_roots(dynamic e1, dynamic e2)
        {
            return elliptic_invariants_from_roots(aflintc.t(e1), aflintc.t(e2));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ArbC, ArbC> elliptic_invariants_from_tau(ArbC tau)
        {
            return new Tuple<ArbC, ArbC>(EllipticInvariantG2(tau), EllipticInvariantG3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ArbC, ArbC> elliptic_invariants_from_tau(dynamic tau)
        {
            return elliptic_invariants_from_tau(aflintc.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ArbC, ArbC, ArbC> elliptic_roots_from_tau(ArbC tau)
        {
            return new Tuple<ArbC, ArbC, ArbC>(EllipticRootE1(tau), EllipticRootE2(tau), EllipticRootE3(tau));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2G3/*' />
        public static Tuple<ArbC, ArbC, ArbC> elliptic_roots_from_tau(dynamic tau)
        {
            return elliptic_roots_from_tau(aflintc.t(tau));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static ArbC EllipticInvariantG2(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticInvariantG2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticInvariantG2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticInvariantG2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG2/*' />
        public static ArbC EllipticInvariantG2(dynamic k)
        {
            return EllipticInvariantG2(aflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static ArbC EllipticInvariantG3(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticInvariantG3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticInvariantG3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticInvariantG3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticInvariantG3/*' />
        public static ArbC EllipticInvariantG3(dynamic k)
        {
            return EllipticInvariantG3(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static ArbC EllipticRootE1(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticRootE1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticRootE1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticRootE1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE1/*' />
        public static ArbC EllipticRootE1(dynamic k)
        {
            return EllipticRootE1(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static ArbC EllipticRootE2(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticRootE2(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticRootE2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticRootE2(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE2/*' />
        public static ArbC EllipticRootE2(dynamic k)
        {
            return EllipticRootE2(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static ArbC EllipticRootE3(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EllipticRootE3(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EllipticRootE3", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_EllipticRootE3(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/EllipticRootE3/*' />
        public static ArbC EllipticRootE3(dynamic k)
        {
            return EllipticRootE3(aflintc.t(k));
        }




        #endregion





        #region Weierstrass elliptic functions, in terms of half-period omega1 and elliptic period ratio tau




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static ArbC weierstrass_p_t(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_WeierstrassP(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_WeierstrassP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_WeierstrassP(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_p_t/*' />
        public static ArbC weierstrass_p_t(dynamic z, dynamic tau)
        {
            return weierstrass_p_t(aflintc.t(z), aflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static ArbC WeierstrassPInv(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_WeierstrassPInv(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_WeierstrassPInv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_WeierstrassPInv(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/WeierstrassPInv/*' />
        public static ArbC WeierstrassPInv(dynamic z, dynamic tau)
        {
            return WeierstrassPInv(aflintc.t(z), aflintc.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static ArbC weierstrass_zeta_t(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_WeierstrassPZeta(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_WeierstrassPZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_WeierstrassPZeta(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_zeta_t/*' />
        public static ArbC weierstrass_zeta_t(dynamic z, dynamic tau)
        {
            return weierstrass_zeta_t(aflintc.t(z), aflintc.t(tau));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static ArbC weierstrass_sigma_t(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_WeierstrassPSigma(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_WeierstrassPSigma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_WeierstrassPSigma(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_sigma_t/*' />
        public static ArbC weierstrass_sigma_t(dynamic z, dynamic tau)
        {
            return weierstrass_sigma_t(aflintc.t(z), aflintc.t(tau));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static ArbC weierstrass_pprime_t(ArbC z, ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_WeierstrassPPrime(res.mpPtr, z.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_WeierstrassPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_WeierstrassPPrime(IntPtr res, IntPtr z, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weierstrass_pprime_t/*' />
        public static ArbC weierstrass_pprime_t(dynamic z, dynamic tau)
        {
            return weierstrass_pprime_t(aflintc.t(z), aflintc.t(tau));
        }




        #endregion






        #region Modular forms



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static ArbC dedekind_eta(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_DedekindEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_DedekindEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_DedekindEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dedekind_eta/*' />
        public static ArbC dedekind_eta(dynamic k)
        {
            return dedekind_eta(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static ArbC klein_j(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_KleinJ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_KleinJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_KleinJ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/klein_j/*' />
        public static ArbC klein_j(dynamic k)
        {
            return klein_j(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static ArbC modular_lambda(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ModularLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ModularLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_ModularLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_lambda/*' />
        public static ArbC modular_lambda(dynamic k)
        {
            return modular_lambda(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static ArbC modular_delta(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ModularDelta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ModularDelta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_ModularDelta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modular_delta/*' />
        public static ArbC modular_delta(dynamic k)
        {
            return modular_delta(aflintc.t(k));
        }



        #endregion








        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static ArbC lerch_phi(ArbC z, ArbC s, ArbC a)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LerchPhi(res.mpPtr, z.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LerchPhi(IntPtr res, IntPtr z, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static ArbC lerch_phi(dynamic z, dynamic s, dynamic a)
        {
            return lerch_phi(aflintc.t(z), aflintc.t(s), aflintc.t(a));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static ArbC lerch_zeta(ArbC lambda1, ArbC alpha, ArbC s)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LerchZeta(res.mpPtr, lambda1.mpPtr, alpha.mpPtr, s.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LerchZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LerchZeta(IntPtr res, IntPtr lambda1, IntPtr alpha, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static ArbC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(aflintc.t(lambda1), aflintc.t(alpha), aflintc.t(s));
        }




        #endregion



        #region Polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static ArbC polygamma(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Polygamma(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static ArbC polygamma(dynamic s, dynamic z)
        {
            return polygamma(aflintc.t(s), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static ArbC trigamma(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Trigamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Trigamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Trigamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static ArbC trigamma(dynamic x)
        {
            return trigamma(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static ArbC digamma(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static ArbC digamma(dynamic x)
        {
            return digamma(aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static ArbC harmonic(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Harmonic(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Harmonic", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Harmonic(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static ArbC harmonic(dynamic x)
        {
            return harmonic(aflintc.t(x));
        }





        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static ArbC polylog(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Polylog(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static ArbC polylog(dynamic s, dynamic z)
        {
            return polylog(aflintc.t(s), aflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static ArbC trilog(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Trilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Trilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Trilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static ArbC trilog(dynamic x)
        {
            return trilog(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static ArbC dilog(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static ArbC dilog(dynamic x)
        {
            return dilog(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static ArbC clausen_sin(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ClausenSin(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ClausenSin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_ClausenSin(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static ArbC clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(aflintc.t(s), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static ArbC clausen_cos(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ClausenCos(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ClausenCos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_ClausenCos(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static ArbC clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(aflintc.t(s), aflintc.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static ArbC clausen2(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Clausen2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Clausen2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Clausen2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static ArbC clausen2(dynamic x)
        {
            return clausen2(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static ArbC bose_einstein(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_BoseEinstein(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_BoseEinstein", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_BoseEinstein(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static ArbC bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(aflintc.t(s), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static ArbC fermi_dirac(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_FermiDirac(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_FermiDirac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_FermiDirac(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static ArbC fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(aflintc.t(s), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static ArbC legendre_chi(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LegendreChi(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LegendreChi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LegendreChi(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static ArbC legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(aflintc.t(s), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static ArbC inverse_tan_integral(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_InverseTanIntegral(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_InverseTanIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_InverseTanIntegral(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static ArbC inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(aflintc.t(s), aflintc.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static ArbC hurwitz_zeta(ArbC s, ArbC a)
        {
            var res = new ArbC();
            Lib_Acb_Acb_HurwitzZeta(res.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static ArbC hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(aflintc.t(s), aflintc.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static ArbC harmonic2(ArbC z, ArbC r)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Harmonic2(res.mpPtr, z.mpPtr, r.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Harmonic2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Harmonic2(IntPtr res, IntPtr z, IntPtr r);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static ArbC harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(aflintc.t(z), aflintc.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static ArbC bernpoly(ArbC x, Int32 n)
        {
            var res = new ArbC();
            Lib_Acb_Acb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernpoly/*' />
        public static ArbC bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(aflintc.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static ArbC eulerpoly(ArbC x, Int32 n)
        {
            var res = new ArbC();
            Lib_Acb_Acb_EulerPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_EulerPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_EulerPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static ArbC eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(aflintc.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static ArbC barnes_g(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static ArbC barnes_g(dynamic x)
        {
            return barnes_g(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static ArbC logbarnes_g(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static ArbC logbarnes_g(dynamic x)
        {
            return logbarnes_g(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static ArbC hyperfactorial(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hyperfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hyperfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hyperfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static ArbC hyperfactorial(dynamic x)
        {
            return hyperfactorial(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static ArbC superfactorial(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Superfactorial(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Superfactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Superfactorial(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static ArbC superfactorial(dynamic x)
        {
            return superfactorial(aflintc.t(x));
        }




        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static ArbC zeta(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static ArbC zeta(dynamic x)
        {
            return zeta(aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static ArbC zetam1(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Zetam1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Zetam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Zetam1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static ArbC zetam1(dynamic x)
        {
            return zetam1(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static ArbC hardy_theta(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_HardyTheta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_HardyTheta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_HardyTheta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static ArbC hardy_theta(dynamic k)
        {
            return hardy_theta(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static ArbC hardy_z(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_HardyZ(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_HardyZ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_HardyZ(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static ArbC hardy_z(dynamic k)
        {
            return hardy_z(aflintc.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static ArbC riemann_xi(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_DirichletXi(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_DirichletXi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_DirichletXi(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static ArbC riemann_xi(dynamic k)
        {
            return riemann_xi(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static ArbC dirichlet_eta(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_DirichletEta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_DirichletEta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_DirichletEta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static ArbC dirichlet_eta(dynamic k)
        {
            return dirichlet_eta(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static ArbC dirichlet_etam1(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_DirichletEtam1(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_DirichletEtam1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_DirichletEtam1(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static ArbC dirichlet_etam1(dynamic k)
        {
            return dirichlet_etam1(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static ArbC dirichlet_beta(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_DirichletBeta(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_DirichletBeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_DirichletBeta(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static ArbC dirichlet_beta(dynamic k)
        {
            return dirichlet_beta(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static ArbC dirichlet_lambda(ArbC tau)
        {
            var res = new ArbC();
            Lib_Acb_Acb_DirichletLambda(res.mpPtr, tau.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_DirichletLambda", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Acb_DirichletLambda(IntPtr res, IntPtr tau);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static ArbC dirichlet_lambda(dynamic k)
        {
            return dirichlet_lambda(aflintc.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta_zero/*' />
        public static ArbC zeta_zero(Int32 n)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ZetaZero_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ZetaZero_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_ZetaZero_ui(IntPtr res, Int32 n);



        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static ArbC hyperg_0f1(ArbC a, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static ArbC hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(aflintc.t(a), aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static ArbC hyperg_0f1r(ArbC a, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static ArbC hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(aflintc.t(a), aflintc.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static ArbC bessel_jv(ArbC nu, ArbC x, bool scaled = false)
        {
            var res = new ArbC();
            Lib_Acb_Acb_BesselJ(res.mpPtr, nu.mpPtr, x.mpPtr);
            if (scaled) res *= aflint.exp(-abs(x.imag));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_BesselJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_BesselJ(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static ArbC bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(aflintc.t(nu), aflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static ArbC bessel_yv(ArbC nu, ArbC x, bool scaled = false)
        {
            var res = new ArbC();
            Lib_Acb_Acb_BesselY(res.mpPtr, nu.mpPtr, x.mpPtr);
            if (scaled) res *= aflint.exp(-abs(x.imag));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_BesselY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_BesselY(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static ArbC bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(aflintc.t(nu), aflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static ArbC bessel_iv(ArbC nu, ArbC x, bool scaled = false)
        {
            var res = new ArbC();
            Lib_Acb_Acb_BesselI(res.mpPtr, nu.mpPtr, x.mpPtr);
            if (scaled) res *= exp(-abs(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_BesselI", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_BesselI(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static ArbC bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(aflintc.t(nu), aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static ArbC bessel_kv(ArbC nu, ArbC x, bool scaled = false)
        {
            var res = new ArbC();
            Lib_Acb_Acb_BesselK(res.mpPtr, nu.mpPtr, x.mpPtr);
            if (scaled) res *= exp(x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_BesselK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_BesselK(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static ArbC bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(aflintc.t(nu), aflintc.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static ArbC bessel_jv_prime(ArbC nu, ArbC x, bool scaled = false)
        {
            return (bessel_jv(nu - 1, x, scaled) - bessel_jv(nu + 1, x, scaled)) / 2;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static ArbC bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(aflintc.t(nu), aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static ArbC bessel_yv_prime(ArbC nu, ArbC x, bool scaled = false)
        {
            return (bessel_yv(nu - 1, x, scaled) - bessel_yv(nu + 1, x, scaled)) / 2;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static ArbC bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(aflintc.t(nu), aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static ArbC bessel_iv_prime(ArbC nu, ArbC x, bool scaled = false)
        {
            return (bessel_iv(nu - 1, x, scaled) + bessel_iv(nu + 1, x, scaled)) / 2;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static ArbC bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(aflintc.t(nu), aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static ArbC bessel_kv_prime(ArbC nu, ArbC x, bool scaled = false)
        {
            return -(bessel_kv(nu - 1, x, scaled) + bessel_kv(nu + 1, x, scaled)) / 2;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static ArbC bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(aflintc.t(nu), aflintc.t(x), scaled);
        }







        #endregion







        #region 0F1: Spherical Bessel functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static ArbC sph_bessel_jn(ArbC n, ArbC x, bool scaled = false)
        {
            var res = bessel_jv(n + 0.5, x) / aflintc.sqrt(2 * x / aflint.pi());
            if (scaled) res *= exp(-abs(x.imag));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static ArbC sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(aflintc.t(n), aflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static ArbC sph_bessel_yn(ArbC n, ArbC x, bool scaled = false)
        {
            var res = bessel_yv(n + 0.5, x) / aflintc.sqrt(2 * x / aflint.pi());
            if (scaled) res *= exp(-abs(x.imag));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static ArbC sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(aflintc.t(n), aflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static ArbC sph_bessel_in(ArbC n, ArbC x, bool scaled = false)
        {
            var res = bessel_iv(n + 0.5, x) / aflintc.sqrt(2 * x / aflint.pi());
            if (scaled) res *= exp(-abs(x.real));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static ArbC sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(aflintc.t(n), aflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static ArbC sph_bessel_kn(ArbC n, ArbC x, bool scaled = false)
        {
            var res = bessel_kv(n + 0.5, x) / aflintc.sqrt(2 * x / aflint.pi());
            if (scaled) res *= exp(x);
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static ArbC sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(aflintc.t(n), aflintc.t(x), scaled);
        }











        ///// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_ine/*' />
        //public static ArbC sph_bessel_ine(ArbC n, ArbC x)
        //{
        //    return sph_bessel_in(n, x) * exp(-abs(x.real));
        //}

        ///// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_ine/*' />
        //public static ArbC sph_bessel_ine(dynamic n, dynamic x)
        //{
        //    return sph_bessel_ine(aflintc.t(n), aflintc.t(x));
        //}




        ///// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kne/*' />
        //public static ArbC sph_bessel_kne(ArbC n, ArbC x)
        //{
        //    return sph_bessel_kn(n, x) * exp(x);
        //}

        ///// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kne/*' />
        //public static ArbC sph_bessel_kne(dynamic n, dynamic x)
        //{
        //    return sph_bessel_kne(aflintc.t(n), aflintc.t(x));
        //}






        #endregion




        #region 0F1: Spherical Bessel functions, first derivative


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static ArbC sph_bessel_jn_prime(ArbC n, ArbC x, bool scaled = false)
        {
            if (aflintc.abs(2 * n + 1) > aflint.t(0.1))
                return (n * sph_bessel_jn(n - 1, x, scaled) - (n + 1) * sph_bessel_jn(n + 1, x, scaled)) / (2 * n + 1);
            else
                return (sph_bessel_jn(n - 1, x, scaled) - (n + 1) * sph_bessel_jn(n, x, scaled) / x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn_prime/*' />
        public static ArbC sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(aflintc.t(n), aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static ArbC sph_bessel_yn_prime(ArbC n, ArbC x, bool scaled = false)
        {
            if (aflintc.abs(2 * n + 1) > aflint.t(0.1))
                return (n * sph_bessel_yn(n - 1, x, scaled) - (n + 1) * sph_bessel_yn(n + 1, x, scaled)) / (2 * n + 1);
            else
                return (sph_bessel_yn(n - 1, x) - (n + 1) * sph_bessel_yn(n, x) / x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn_prime/*' />
        public static ArbC sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(aflintc.t(n), aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static ArbC sph_bessel_in_prime(ArbC n, ArbC x, bool scaled = false)
        {
            if (aflintc.abs(2 * n + 1) > aflint.t(0.1))
                return (n * sph_bessel_in(n - 1, x, scaled) + (n + 1) * sph_bessel_in(n + 1, x, scaled)) / (2 * n + 1);
            else
                return (sph_bessel_in(n - 1, x, scaled) - (n + 1) * sph_bessel_in(n, x, scaled) / x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in_prime/*' />
        public static ArbC sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(aflintc.t(n), aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static ArbC sph_bessel_kn_prime(ArbC n, ArbC x, bool scaled = false)
        {
            if (aflintc.abs(2 * n + 1) > aflint.t(0.1))
                return -(n * sph_bessel_kn(n - 1, x, scaled) + (n + 1) * sph_bessel_kn(n + 1, x, scaled)) / (2 * n + 1);
            else
                return -sph_bessel_kn(n - 1, x, scaled) - (n + 1) * sph_bessel_kn(n, x, scaled) / x;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn_prime/*' />
        public static ArbC sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(aflintc.t(n), aflintc.t(x), scaled);
        }



        #endregion







        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static ArbC hankel_h1(ArbC v, ArbC x, bool scaled = false)
        {
            var res = bessel_jv(v, x) + aflintc.onej() * bessel_yv(v, x);
            if (scaled) res *= exp(-aflintc.onej() * x);
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static ArbC hankel_h1(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h1(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static ArbC hankel_h2(ArbC v, ArbC x, bool scaled = false)
        {
            var res = bessel_jv(v, x) - aflintc.onej() * bessel_yv(v, x);
            if (scaled) res *= exp(aflintc.onej() * x);
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static ArbC hankel_h2(dynamic v, dynamic x, bool scaled = false)
        {
            return hankel_h2(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static ArbC sph_hankel_h1(ArbC n, ArbC x, bool scaled = false)
        {
            var res = hankel_h1(n + 0.5, x, scaled) / aflintc.sqrt(2 * x / aflint.pi());
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static ArbC sph_hankel_h1(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h1(t(n), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static ArbC sph_hankel_h2(ArbC n, ArbC x, bool scaled = false)
        {
            var res = hankel_h2(n + 0.5, x, scaled) / aflintc.sqrt(2 * x / aflint.pi());
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static ArbC sph_hankel_h2(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_hankel_h2(t(n), t(x), scaled);
        }






        #endregion





        #region 0F1: Airy functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static ArbC airy_ai(ArbC x, bool scaled = false)
        {
            var res = new ArbC();
            Lib_Acb_Acb_AiryAi(res.mpPtr, x.mpPtr);
            if (scaled) res *= exp((aflint.t(2) / aflint.t(3)) * x * sqrt(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_AiryAi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static ArbC airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(aflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static ArbC airy_ai_prime(ArbC x, bool scaled = false)
        {
            var res = new ArbC();
            Lib_Acb_Acb_AiryAiPrime(res.mpPtr, x.mpPtr);
            if (scaled) res *= exp((aflint.t(2) / aflint.t(3)) * x * sqrt(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_AiryAiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static ArbC airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(aflintc.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static ArbC airy_bi(ArbC x, bool scaled = false)
        {
            var res = new ArbC();
            Lib_Acb_Acb_AiryBi(res.mpPtr, x.mpPtr);
            if (scaled) res *= exp(-abs(aflint.t(2) / aflint.t(3) * (x * sqrt(x)).real));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_AiryBi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static ArbC airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static ArbC airy_bi_prime(ArbC x, bool scaled = false)
        {
            var res = new ArbC();
            Lib_Acb_Acb_AiryBiPrime(res.mpPtr, x.mpPtr);
            if (scaled) res *= exp(-abs(aflint.t(2) / aflint.t(3) * (x * sqrt(x)).real));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_AiryBiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static ArbC airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(aflintc.t(x), scaled);
        }



        #endregion



        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static ArbC kelvin_ber(ArbC v, ArbC x, bool scaled = false)
        {
            ArbC a = t(0.5 * aflint.sqrt(2));
            ArbC ia = aflintc.onej() * a;
            var res = 0.5 * (bessel_jv(v, x * (-a + ia)) + bessel_jv(v, x * (-a - ia)));
            if (scaled) res *= exp(-aflintc.abs(x) / sqrt(2));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static ArbC kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static ArbC kelvin_bei(ArbC v, ArbC x, bool scaled = false)
        {
            ArbC a = t(0.5 * aflint.sqrt(2));
            ArbC i = aflintc.onej();
            ArbC ia = i * a;
            var res = 0.5 * (bessel_jv(v, x * (-a + ia)) - bessel_jv(v, x * (-a - ia))) / i;
            if (scaled) res *= exp(-aflintc.abs(x) / sqrt(2));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static ArbC kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static ArbC kelvin_ker(ArbC v, ArbC x, bool scaled = false)
        {
            ArbC a = t(0.5 * aflint.sqrt(2));
            ArbC i = aflintc.onej();
            ArbC ia = i * a;
            ArbC p = 0.5 * i * v * aflint.pi();
            ArbC e1 = aflintc.exp(-p);
            ArbC e2 = aflintc.exp(p);
            var res = 0.5 * (e1 * bessel_kv(v, x * (a + ia)) + e2 * bessel_kv(v, x * (a - ia)));
            if (scaled) res *= exp(aflintc.abs(x) / sqrt(2));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static ArbC kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static ArbC kelvin_kei(ArbC v, ArbC x, bool scaled = false)
        {
            ArbC a = t(0.5 * aflint.sqrt(2));
            ArbC i = aflintc.onej();
            ArbC ia = i * a;
            ArbC p = 0.5 * i * v * aflint.pi();
            ArbC e1 = aflintc.exp(-p);
            ArbC e2 = aflintc.exp(p);
            var res = 0.5 * (e1 * bessel_kv(v, x * (a + ia)) - e2 * bessel_kv(v, x * (a - ia))) / i;
            if (scaled) res *= exp(aflintc.abs(x) / sqrt(2));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static ArbC kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(t(v), t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static ArbC kelvin_ber_prime(ArbC v, ArbC x, bool scaled = false)
        {
            ArbC a = t(0.5 * aflint.sqrt(2));
            ArbC ia = aflintc.onej() * a;
            ArbC a1 = -a + ia;
            ArbC a2 = -a - ia;
            var res = 0.5 * (a1 * bessel_jv_prime(v, x * a1) + a2 * bessel_jv_prime(v, x * a2));
            if (scaled) res *= exp(-aflintc.abs(x) / sqrt(2));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static ArbC kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static ArbC kelvin_bei_prime(ArbC v, ArbC x, bool scaled = false)
        {
            ArbC a = t(0.5 * aflint.sqrt(2));
            ArbC i = aflintc.onej();
            ArbC ia = i * a;
            ArbC a1 = -a + ia;
            ArbC a2 = -a - ia;
            var res = 0.5 * (a1 * bessel_jv_prime(v, x * a1) - a2 * bessel_jv_prime(v, x * a2)) / i;
            if (scaled) res *= exp(-aflintc.abs(x) / sqrt(2));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static ArbC kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static ArbC kelvin_ker_prime(ArbC v, ArbC x, bool scaled = false)
        {
            ArbC a = t(0.5 * aflint.sqrt(2));
            ArbC i = aflintc.onej();
            ArbC ia = i * a;
            ArbC p = 0.5 * i * v * aflint.pi();
            ArbC e1 = aflintc.exp(-p);
            ArbC e2 = aflintc.exp(p);
            ArbC a1 = a + ia;
            ArbC a2 = a - ia;
            var res = 0.5 * (e1 * a1 * bessel_kv_prime(v, x * a1) + e2 * a2 * bessel_kv_prime(v, x * a2));
            if (scaled) res *= exp(-aflintc.abs(x) / sqrt(2));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static ArbC kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static ArbC kelvin_kei_prime(ArbC v, ArbC x, bool scaled = false)
        {
            ArbC a = t(0.5 * aflint.sqrt(2));
            ArbC i = aflintc.onej();
            ArbC ia = i * a;
            ArbC p = 0.5 * i * v * aflint.pi();
            ArbC e1 = aflintc.exp(-p);
            ArbC e2 = aflintc.exp(p);
            ArbC a1 = a + ia;
            ArbC a2 = a - ia;
            var res = 0.5 * (e1 * a1 * bessel_kv_prime(v, x * a1) - e2 * a2 * bessel_kv_prime(v, x * a2)) / i;
            if (scaled) res *= exp(-aflintc.abs(x) / sqrt(2));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static ArbC kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(t(v), t(x), scaled);
        }







        #endregion







        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static ArbC hyperg_1f1(ArbC a, ArbC b, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static ArbC hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(aflintc.t(a), aflintc.t(b), aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static ArbC hyperg_1f1r(ArbC a, ArbC b, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static ArbC hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(aflintc.t(a), aflintc.t(b), aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static ArbC hyperg_u(ArbC a, ArbC b, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static ArbC hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(aflintc.t(a), aflintc.t(b), aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static ArbC hermite_h(ArbC n, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static ArbC hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(aflintc.t(n), aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static ArbC hermite_he(ArbC n, ArbC x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static ArbC hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(aflintc.t(n), aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static ArbC laguerre_l(ArbC n, ArbC m, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static ArbC laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(aflintc.t(n), aflintc.t(m), aflintc.t(x));
        }


        internal static ArbC besselpoly_(ArbC n, ArbC x)
        {
            return exp2(n + 1) * pow(1 / x, n + 1) * aflintc.hyperg_u(n + 1, 2 * n + 2, 2 / x);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static ArbC besselpoly(ArbC n, ArbC x, bool scaled = false)
        {
            if (aflintc.iszero(x))
            {
                var h = aflintc.t(aflint.sqrt(aflint.epsilon()));
                var res1 = besselpoly_(n, h * (1 + aflintc.onej()));
                var res2 = besselpoly_(n, -h * (1 + aflintc.onej()));
                if (aflint.sign(res1.real) == aflint.sign(res2.real)) return (res1 + res2) / 2;
                else return aflintc.nan();
            }
            return besselpoly_(n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besselpoly/*' />
        public static ArbC besselpoly(dynamic n, dynamic x, bool scaled = false)
        {
            return besselpoly(aflintc.t(n), aflintc.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static ArbC besseltheta_(ArbC n, ArbC x)
        {
            return exp2(n + 1) * pow(x, 2 * n + 1) * aflintc.hyperg_u(n + 1, 2 * n + 2, 2 * x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static ArbC besseltheta(ArbC n, ArbC x, bool scaled = false)
        {
            if (aflintc.iszero(x))
            {
                var h = aflintc.t(aflint.sqrt(aflint.epsilon()));
                ArbC res1 = besseltheta_(n, h * (1 + aflintc.onej()));
                ArbC res2 = besseltheta_(n, -h * (1 + aflintc.onej()));
                if (aflint.sign(res1.real) == aflint.sign(res2.real)) return (res1 + res2) / 2;
                else return aflintc.nan();
            }
            return besseltheta_(n, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/besseltheta/*' />
        public static ArbC besseltheta(dynamic n, dynamic x, bool scaled = false)
        {
            return besseltheta(aflintc.t(n), aflintc.t(x), scaled);
        }





        #endregion




        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static ArbC gamma_upper(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_GammaUpper(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static ArbC gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(aflintc.t(s), aflintc.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static ArbC gamma_q(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_GammaQ(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static ArbC gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(aflintc.t(s), aflintc.t(z));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static ArbC gamma_lower(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_GammaLower(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static ArbC gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(aflintc.t(s), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static ArbC gamma_p(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_GammaP(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static ArbC gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(aflintc.t(s), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static ArbC gamma_p_prime(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_GammaPPrime(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static ArbC gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(aflintc.t(s), aflintc.t(z));
        }



        #endregion




        #region 1F1: Coulomb, Whittaker and parabolic cylinder functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static ArbC coulomb_f(ArbC l, ArbC eta, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static ArbC coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(aflintc.t(l), aflintc.t(eta), aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static ArbC coulomb_g(ArbC l, ArbC eta, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static ArbC coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(aflintc.t(l), aflintc.t(eta), aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static ArbC coulomb_hpos(ArbC l, ArbC eta, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CoulombHpos(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CoulombHpos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CoulombHpos(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hpos/*' />
        public static ArbC coulomb_hpos(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hpos(aflintc.t(l), aflintc.t(eta), aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static ArbC coulomb_hneg(ArbC l, ArbC eta, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CoulombHneg(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CoulombHneg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CoulombHneg(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_hneg/*' />
        public static ArbC coulomb_hneg(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_hneg(aflintc.t(l), aflintc.t(eta), aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/whittaker_m/*' />
        public static ArbC whittaker_m(ArbC k, ArbC m, ArbC x)
        {
            return exp(-0.5 * x) * pow(x, 0.5 + m) * hyperg_1f1(0.5 + m - k, 1 + 2 * m, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/whittaker_m/*' />
        public static ArbC whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(aflintc.t(k), aflintc.t(m), aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/whittaker_w/*' />
        public static ArbC whittaker_w(ArbC k, ArbC m, ArbC x)
        {
            return exp(-0.5 * x) * pow(x, 0.5 + m) * hyperg_u(0.5 + m - k, 1 + 2 * m, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/whittaker_w/*' />
        public static ArbC whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(aflintc.t(k), aflintc.t(m), aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfu/*' />
        public static ArbC pcfu(ArbC a, ArbC z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 40);
            Arb p = aflint.pi();
            p = aflint.sqrt(p);
            ArbC U1 = p / (aflintc.exp2(0.5 * a + 0.25) * aflintc.gamma(0.75 + 0.5 * a));
            ArbC U2 = -p / (aflintc.exp2(0.5 * a - 0.25) * aflintc.gamma(0.25 + 0.5 * a));
            ArbC F1 = aflintc.hyperg_1f1(-0.5 * a + 0.25, 0.5, -0.5 * z * z);
            ArbC F2 = aflintc.hyperg_1f1(-0.5 * a + 0.75, 1.5, -0.5 * z * z);
            ArbC res = (U1 * F1 + U2 * z * F2) / aflintc.exp(-0.25 * z * z);
            ArbPrec.SetDps((int)OldPrec);
            return +res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfu/*' />
        public static ArbC pcfu(dynamic a, dynamic z)
        {
            return pcfu(aflintc.t(a), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfd/*' />
        public static ArbC pcfd(ArbC n, ArbC z)
        {
            return pcfu(-n - 0.5, z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfd/*' />
        public static ArbC pcfd(dynamic n, dynamic z)
        {
            return pcfd(aflintc.t(n), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfv/*' />
        public static ArbC pcfv(ArbC a, ArbC z)
        {
            Arb p = aflint.pi();
            ArbC res = aflintc.gamma(a + 0.5) * aflintc.pcfu(a, -z);
            res = res - aflintc.sin(p * a) * aflintc.pcfu(a, z);
            res = res / p;
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfv/*' />
        public static ArbC pcfv(dynamic a, dynamic z)
        {
            return pcfv(aflintc.t(a), aflintc.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfw/*' />
        public static ArbC pcfw(ArbC a, ArbC z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 40);
            ArbC j05 = aflintc.onej() / 2;
            ArbC j025 = aflintc.onej() / 4;
            ArbC W1a = aflintc.gamma(0.25 + j05 * a) / aflintc.gamma(0.75 + j05 * a);
            ArbC W1 = aflintc.exp2(-0.75) * aflintc.sqrt(aflintc.fabs(W1a));
            ArbC W2a = aflintc.gamma(0.75 + j05 * a) / aflintc.gamma(0.25 + j05 * a);
            ArbC W2 = -aflintc.exp2(-0.25) * aflintc.sqrt(aflintc.fabs(W2a));
            ArbC F1 = aflintc.exp(-j025 * z * z) * aflintc.hyperg_1f1(0.25 - j05 * a, 0.5, j05 * z * z);
            ArbC F2 = aflintc.exp(-j025 * z * z) * aflintc.hyperg_1f1(0.75 - j05 * a, 1.5, j05 * z * z);
            ArbC res = W1 * F1 + W2 * z * F2;
            ArbPrec.SetDps((int)OldPrec);
            return +res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfw/*' />
        public static ArbC pcfw(dynamic a, dynamic z)
        {
            return pcfw(aflintc.t(a), aflintc.t(z));
        }



        #endregion





        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static ArbC erf(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static ArbC erf(dynamic x)
        {
            return erf(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static ArbC erfc(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static ArbC erfc(dynamic x)
        {
            return erfc(aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static ArbC erfi(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static ArbC erfi(dynamic x)
        {
            return erfi(aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static ArbC dawson(ArbC x)
        {
            return erfi(x) * exp(-x * x) * aflint.sqrt(aflint.pi()) / 2;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static ArbC dawson(dynamic x)
        {
            return dawson(aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static ArbC faddeeva(ArbC x)
        {
            return erfc(-aflintc.onej() * x) * exp(-x * x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/faddeeva/*' />
        public static ArbC faddeeva(dynamic x)
        {
            return faddeeva(aflintc.t(x));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static ArbC fresnel_s(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static ArbC fresnel_s(dynamic x)
        {
            return fresnel_s(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static ArbC fresnel_c(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static ArbC fresnel_c(dynamic x)
        {
            return fresnel_c(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static ArbC ndens(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Ndens(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static ArbC ndens(dynamic x)
        {
            return ndens(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static ArbC ndis(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Ndis(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static ArbC ndis(dynamic x)
        {
            return ndis(aflintc.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static ArbC cosh_integral(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static ArbC cosh_integral(dynamic x)
        {
            return cosh_integral(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static ArbC cos_integral(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static ArbC cos_integral(dynamic x)
        {
            return cos_integral(aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static ArbC exp_integral_en(ArbC s, ArbC z)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_ExpIntegralE(IntPtr res, IntPtr z, IntPtr s);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static ArbC exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(aflintc.t(s), aflintc.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static ArbC exp_integral_e1(ArbC x)
        {
            return exp_integral_en(aflintc.t(1), x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static ArbC exp_integral_e1(dynamic x)
        {
            return exp_integral_e1(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static ArbC exp_integral_ei(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static ArbC exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static ArbC sin_integral(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static ArbC sin_integral(dynamic x)
        {
            return sin_integral(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static ArbC sinh_integral(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static ArbC sinh_integral(dynamic x)
        {
            return sinh_integral(aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static ArbC log_integral(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static ArbC log_integral(dynamic x)
        {
            return log_integral(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static ArbC log_integral_offset(ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static ArbC log_integral_offset(dynamic x)
        {
            return log_integral_offset(aflintc.t(x));
        }



        #endregion











        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static ArbC hyperg_2f1(ArbC a, ArbC b, ArbC c, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static ArbC hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(aflintc.t(a), aflintc.t(b), aflintc.t(c), aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static ArbC hyperg_2f1r(ArbC a, ArbC b, ArbC c, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static ArbC hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(aflintc.t(a), aflintc.t(b), aflintc.t(c), aflintc.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static ArbC chebyshev_t(ArbC n, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static ArbC chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(aflintc.t(n), aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static ArbC chebyshev_u(ArbC n, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static ArbC chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(aflintc.t(n), aflintc.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static ArbC chebyshev_v(ArbC v, ArbC x)
        {
            return expjpi(v) * (2 * v + 1) * hyperg_2f1(-v, v + 1, aflintc.t(1.5), (1 + x) / 2);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_v/*' />
        public static ArbC chebyshev_v(dynamic v, dynamic x)
        {
            return chebyshev_v(aflintc.t(v), aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static ArbC chebyshev_w(ArbC v, ArbC x)
        {
            return expjpi(v) * hyperg_2f1(-v, v + 1, aflintc.t(0.5), (1 + x) / 2);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_w/*' />
        public static ArbC chebyshev_w(dynamic v, dynamic x)
        {
            return chebyshev_w(aflintc.t(v), aflintc.t(x));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static ArbC gegenbauer_c(ArbC n, ArbC m, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static ArbC gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(aflintc.t(n), aflintc.t(m), aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static ArbC jacobi_p(ArbC n, ArbC a, ArbC b, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static ArbC jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(aflintc.t(n), aflintc.t(a), aflintc.t(b), aflintc.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        internal static ArbC legendre_plm2(ArbC n, ArbC m, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LegendreP(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LegendreP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LegendreP(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        internal static ArbC legendre_plm3(ArbC n, ArbC m, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LegendrePv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LegendrePv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LegendrePv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static ArbC legendre_plm(ArbC n, ArbC m, ArbC x, int type = 1)
        {
            ArbC res = aflintc.nan();
            switch (type)
            {
                case 2: res = legendre_plm2(n, m, x); break;
                case 3: res = legendre_plm3(n, m, x); break;
                case 1:
                default:
                    if (abs(x.real) < 1) res = legendre_plm2(n, m, x);
                    else res = legendre_plm3(n, m, x);
                    break;
            }
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static ArbC legendre_plm(dynamic n, dynamic m, dynamic x, int type=1)
        {
            return legendre_plm(aflintc.t(n), aflintc.t(m), aflintc.t(x), type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static ArbC legendre_p(ArbC n, ArbC x)
        {
            return legendre_plm(n, aflintc.t(0), x, 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static ArbC legendre_p(dynamic n, dynamic x)
        {
            return legendre_p(aflintc.t(n), aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        internal static ArbC legendre_qlm2(ArbC n, ArbC m, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LegendreQ(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LegendreQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LegendreQ(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        internal static ArbC legendre_qlm3(ArbC n, ArbC m, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_LegendreQv(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_LegendreQv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_LegendreQv(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static ArbC legendre_qlm(ArbC n, ArbC m, ArbC x, int type = 1)
        {
            ArbC res = aflintc.nan();
            switch (type)
            {
                case 2: res = legendre_qlm2(n, m, x); break;
                case 3: res = legendre_qlm3(n, m, x); break;
                case 1:
                default:
                    if (abs(x.real) < 1) res = legendre_qlm2(n, m, x);
                    else res = legendre_qlm3(n, m, x);
                    break;
            }
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static ArbC legendre_qlm(dynamic n, dynamic m, dynamic x, int type = 1)
        {
            return legendre_qlm(aflintc.t(n), aflintc.t(m), aflintc.t(x), type);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static ArbC legendre_q(ArbC n, ArbC x)
        {
            return legendre_qlm(n, aflintc.t(0), x, 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static ArbC legendre_q(dynamic n, dynamic x)
        {
            return legendre_q(aflintc.t(n), aflintc.t(x));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static ArbC spherical_y(ArbC n, ArbC m, ArbC theta, ArbC phi)
        {
            var res = new ArbC();
            Lib_Acb_Acb_SphericalY(res.mpPtr, n.mpPtr, m.mpPtr, theta.mpPtr, phi.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_SphericalY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_SphericalY(IntPtr res, IntPtr n, IntPtr m, IntPtr theta, IntPtr phi);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static ArbC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(aflintc.t(n), aflintc.t(m), aflintc.t(theta), aflintc.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static ArbC beta_lower(ArbC a, ArbC b, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static ArbC beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(aflintc.t(a), aflintc.t(b), aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static ArbC ibeta(ArbC a, ArbC b, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static ArbC ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(aflintc.t(a), aflintc.t(b), aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static ArbC ibetac(ArbC a, ArbC b, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static ArbC ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(aflintc.t(a), aflintc.t(b), aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static ArbC ibeta_prime(ArbC a, ArbC b, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static ArbC ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(aflintc.t(a), aflintc.t(b), aflintc.t(x));
        }


        #endregion







        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static ArbC hyperg_1f2(ArbC a1, ArbC b1, ArbC b2, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static ArbC hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(aflintc.t(a1), aflintc.t(b1), aflintc.t(b2), aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static ArbC hyperg_1f2r(ArbC a1, ArbC b1, ArbC b2, ArbC x)
        {
            var res = new ArbC();
            Lib_Acb_Acb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Acb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Acb_Acb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static ArbC hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(aflintc.t(a1), aflintc.t(b1), aflintc.t(b2), aflintc.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static ArbC airy_gi(ArbC x)
        {
            return 1 * airy_bi(x) / 3 - (x * x) * hyperg_1f2(1, aflintc.t(4) / 3, aflintc.t(5) / 3, x * x * x / 9) / (2 * aflint.pi());
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static ArbC airy_gi(dynamic x)
        {
            return airy_gi(aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static ArbC airy_hi(ArbC x)
        {
            return 2 * airy_bi(x) / 3 + (x * x) * hyperg_1f2(1, aflintc.t(4) / 3, aflintc.t(5) / 3, x * x * x / 9) / (2 * aflint.pi());
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static ArbC airy_hi(dynamic x)
        {
            return airy_hi(aflintc.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static ArbC airy_gi_prime(ArbC x)
        {
            ArbC x3 = x * x * x;
            ArbC x4 = x3 * x;
            return airy_bi_prime(x) / 3 - 1 / (40 * aflint.pi()) * (40 * x * hyperg_1f2(1, aflintc.t(4) / 3, aflintc.t(5) / 3, x3 / 9) + (3 * x4 * hyperg_1f2(2, aflintc.t(7) / 3, aflintc.t(8) / 3, x3 / 9)));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static ArbC airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static ArbC airy_hi_prime(ArbC x)
        {
            ArbC x3 = x * x * x;
            ArbC x4 = x3 * x;
            return 2 * airy_bi_prime(x) / 3 + 1 / (40 * aflint.pi()) * (40 * x * hyperg_1f2(1, aflintc.t(4) / 3, aflintc.t(5) / 3, x3 / 9) + (3 * x4 * hyperg_1f2(2, aflintc.t(7) / 3, aflintc.t(8) / 3, x3 / 9)));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static ArbC airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(aflintc.t(x));
        }









        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static ArbC struve_h(ArbC v, ArbC x)
        {
            return pow(x / 2, v + 1) * hyperg_1f2r(1, aflintc.t(1.5), aflintc.t(v + 1.5), -x * x / 4);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static ArbC struve_h(dynamic v, dynamic x)
        {
            return struve_h(aflintc.t(v), aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static ArbC struve_l(ArbC v, ArbC x)
        {
            ArbC i = aflintc.onej();
            return -i * exp(-aflint.pi() * v * i / 2) * struve_h(v, i * x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static ArbC struve_l(dynamic v, dynamic x)
        {
            return struve_l(aflintc.t(v), aflintc.t(x));
        }


        public static ArbC struve_k(ArbC v, ArbC x)
        {
            return struve_h(v, x) - bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static ArbC struve_k(dynamic v, dynamic x)
        {
            return struve_k(aflintc.t(v), aflintc.t(x));
        }


        public static ArbC struve_m(ArbC v, ArbC x)
        {
            return struve_l(v, x) - bessel_iv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static ArbC struve_m(dynamic v, dynamic x)
        {
            return struve_m(aflintc.t(v), aflintc.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static ArbC anger_j(ArbC v, ArbC x)
        {
            ArbC f1 = hyperg_1f2r(1, 0.5 * (3 - v), 0.5 * (3 + v), -x * x / 4);
            ArbC f2 = hyperg_1f2r(1, 0.5 * (2 - v), 0.5 * (2 + v), -x * x / 4);
            ArbC res1 = 0.5 * x * sinpi(v / 2) * f1 + cospi(v / 2) * f2;
            return res1;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static ArbC anger_j(dynamic v, dynamic x)
        {
            return anger_j(aflintc.t(v), aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static ArbC weber_e(ArbC v, ArbC x)
        {
            ArbC f1 = hyperg_1f2r(1, 0.5 * (3 - v), 0.5 * (3 + v), -x * x / 4);
            ArbC f2 = hyperg_1f2r(1, 0.5 * (2 - v), 0.5 * (2 + v), -x * x / 4);
            ArbC res1 = -0.5 * x * cospi(v / 2) * f1 + sinpi(v / 2) * f2;
            return res1;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static ArbC weber_e(dynamic v, dynamic x)
        {
            return weber_e(aflintc.t(v), aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static ArbC lommel_s1(ArbC mu, ArbC nu, ArbC x)
        {
            ArbC f1 = pow(x, mu + 1) / ((mu - nu + 1) * (mu + nu + 1));
            ArbC f2 = hyperg_1f2(1, (mu - nu + 3) / 2, (mu + nu + 3) / 2, -x * x / 4);
            ArbC res1 = f1 * f2;
            return res1;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static ArbC lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(aflintc.t(mu), aflintc.t(nu), aflintc.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static ArbC lommel_s2(ArbC mu, ArbC nu, ArbC x)
        {
            ArbC f1 = lommel_s1(mu, nu, x);
            ArbC res1 = exp2(mu - 1) * gamma((mu - nu + 1) / 2) * gamma((mu + nu + 1) / 2);
            ArbC res2 = sinpi((mu - nu) / 2) * bessel_jv(nu, x) - cospi((mu - nu) / 2) * bessel_yv(nu, x);
            return f1 + res1 * res2;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static ArbC lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(aflintc.t(mu), aflintc.t(nu), aflintc.t(x));
        }


        #endregion







        #endregion


    }






}