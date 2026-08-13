using FixedPrecNet;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;


namespace ArbPrecNet
{


    public delegate Arb cb1SArb1S(Arb x);

    public delegate Arb cb1SArb2S(Arb x, Arb y);

    public delegate Arb cb1SArb3S(Arb x, Arb y, Arb z);


    public delegate Arb cb1SArb1SBool(Arb x, bool sc);

    public delegate Arb cb1SArb2SBool(Arb x, Arb y, bool sc);


    public class Arb
    {

        internal IntPtr mpPtr = IntPtr.Zero;


        #region Init


        private void Init()
        {
            ArbPrec.Init();
            mpPtr = Lib_Arb_Init_Func();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Init_Func", CallingConvention = CallingConvention.Cdecl)]
        internal static extern IntPtr Lib_Arb_Init_Func();


        ~Arb()
        {
            Lib_Arb_Clear(mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Clear", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Clear(IntPtr x);

        #endregion



        #region Conversions

        public Arb()
        {
            Init();
        }



        public Arb Infimum()
        {
            var res = new Arb();
            Lib_Arb_Get_Infimum(res.mpPtr, mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Get_Infimum", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Get_Infimum(IntPtr res, IntPtr x);


        public Arb Supremum()
        {
            var res = new Arb();
            Lib_Arb_Get_Supremum(res.mpPtr, mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Get_Supremum", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Get_Supremum(IntPtr res, IntPtr x);


        public Arb Mid
        {
            get
            {
                var res = new Arb();
                Lib_Arb_Get_Mid(res.mpPtr, mpPtr);
                return res;
            }
            set
            {
                Lib_Arb_Set_Mid(value.mpPtr, mpPtr);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Get_Mid", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Get_Mid(IntPtr res, IntPtr x);
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Mid", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Mid(IntPtr res, IntPtr x);


        public Arb Rad
        {
            get
            {
                var res = new Arb();
                Lib_Arb_Get_Rad(res.mpPtr, mpPtr);
                return res;
            }
            set
            {
                Lib_Arb_Set_Rad(value.mpPtr, mpPtr);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Get_Rad", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Get_Rad(IntPtr res, IntPtr x);
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Rad", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Rad(IntPtr res, IntPtr x);


        // flags:
        // ARB_STR_MORE = 1
        // ARB_STR_NO_RADIUS = 2
        // ARB_STR_CONDENSE = 16

        internal string Get_Num_Str(UInt32 flags)
        {
            //Console.WriteLine("in Arb_GetNumStr");
            long StrSize2 = Lib_Arb_SizeInBase10(ArbPrec.GetDps(), flags, mpPtr);
            int StrSize = (int)StrSize2;
            var sb = new StringBuilder(StrSize + 20);
            Lib_Arb_Get_Str(sb, mpPtr, ArbPrec.GetDps(), flags);
            string s = sb.ToString();
            //if (s[0] == '[') { s = s.Substring(1); }
            //if (s[0] != '[') {
            //    MessageBox.Show(s);
            //    s = " " + s; 
            //}
            return s;
            //return sb.ToString();
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_SizeInBase10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern UInt32 Lib_Arb_SizeInBase10(UInt32 n, UInt32 flags, IntPtr x);
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Get_Str", CallingConvention = CallingConvention.Cdecl)]
        internal static extern long Lib_Arb_Get_Str(StringBuilder sb, IntPtr x, UInt32 n, UInt32 flags);


        public override string ToString()
        {
            string s = Get_Num_Str(0);
            if (!s.StartsWith("[")) s = " " + s;
            return s;
        }


        public string MidOnlyToString()
        {
            return Get_Num_Str(2);
        }



        public string __str__()
        {
            return ToString();
        }


        public string __repr__()
        {
            return "Arb('" + ToString() + "')";
        }



        public double AsDouble()
        {
            string s = MidOnlyToString();
            double res = double.Parse(s);
            return res;
        }



        #endregion



        #region Arithmetic operators






        public static bool operator >=(Arb x, dynamic y)
        {
            return x >= aflint.t(y);
        }
        public static bool operator <=(Arb x, dynamic y)
        {
            return x <= aflint.t(y);
        }

        public static bool operator >=(dynamic x, Arb y)
        {
            return aflint.t(x) >= y;
        }
        public static bool operator <=(dynamic x, Arb y)
        {
            return aflint.t(x) <= y;
        }


        public static bool operator >(Arb x, dynamic y)
        {
            return x > aflint.t(y);
        }
        public static bool operator <(Arb x, dynamic y)
        {
            return x < aflint.t(y);
        }

        public static bool operator >(dynamic x, Arb y)
        {
            return aflint.t(x) > y;
        }
        public static bool operator <(dynamic x, Arb y)
        {
            return aflint.t(x) < y;
        }


        public static bool operator ==(Arb x, dynamic y)
        {
            return x == aflint.t(y);
        }
        public static bool operator !=(Arb x, dynamic y)
        {
            return x != aflint.t(y);
        }

        public static bool operator ==(dynamic x, Arb y)
        {
            return aflint.t(x) == y;
        }
        public static bool operator !=(dynamic x, Arb y)
        {
            return aflint.t(x) != y;
        }




        public static bool operator ==(Arb m1, Arb m2)
        {
            return Lib_Arb_EQ(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_EQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_EQ(IntPtr x, IntPtr y);


        public static bool operator !=(Arb m1, Arb m2)
        {
            return Lib_Arb_NE(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_NE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_NE(IntPtr x, IntPtr y);


        public static bool operator <=(Arb m1, Arb m2)
        {
            return Lib_Arb_LE(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_LE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_LE(IntPtr x, IntPtr y);


        public static bool operator <(Arb m1, Arb m2)
        {
            return Lib_Arb_LT(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_LT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_LT(IntPtr x, IntPtr y);


        public static bool operator >=(Arb m1, Arb m2)
        {
            return Lib_Arb_GE(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_GE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_GE(IntPtr x, IntPtr y);


        public static bool operator >(Arb m1, Arb m2)
        {
            return Lib_Arb_GT(m1.mpPtr, m2.mpPtr) != 0;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_GT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_GT(IntPtr x, IntPtr y);








        public static Arb operator +(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Set(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set(IntPtr res, IntPtr x);



        public static Arb operator -(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Neg(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Neg", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Neg(IntPtr res, IntPtr x);


        public static Arb Inv(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Inv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Inv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Inv(IntPtr res, IntPtr x);








        public static Arb operator +(Arb x, dynamic i)
        {
            return x + aflint.t(i);
        }

        public static Arb operator +(dynamic i, Arb x)
        {
            return aflint.t(i) + x;
        }


        public static ArbC operator +(Arb x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Add_Arb(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Add_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Add_Arb(IntPtr res, IntPtr y, IntPtr x);


        public static Arb operator +(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Add(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Add(IntPtr res, IntPtr x, IntPtr y);


        public static ArbMat operator +(Arb m2, ArbMat M1)
        {
            var Res = new ArbMat();
            var t = aflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, Res.mpPtr, constants.mp_const_plus_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }









        public static Arb operator -(Arb x, dynamic y)
        {
            return x - aflint.t(y);
        }

        public static Arb operator -(dynamic x, Arb y)
        {
            return aflint.t(x) - y;
        }


        public static ArbC operator -(Arb x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Arb_Sub(res.mpPtr, y.mpPtr, x.mpPtr);
            return -res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Arb_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Arb_Sub(IntPtr res, IntPtr y, IntPtr x);


        public static Arb operator -(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Sub(IntPtr res, IntPtr x, IntPtr y);


        public static ArbMat operator -(Arb m2, ArbMat M1)
        {
            var Res = new ArbMat();
            var t = aflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, Res.mpPtr, constants.mp_const_minus_scalar, M1.mpPtr, t.mpPtr);
            return -Res;
        }






        public static Arb operator *(Arb x, dynamic y)
        {
            return x * aflint.t(y);
        }

        public static Arb operator *(dynamic x, Arb y)
        {
            return aflint.t(x) * y;
        }


        public static ArbC operator *(Arb x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Mul_Arb(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Mul_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Mul_Arb(IntPtr res, IntPtr x, IntPtr y);


        public static Arb operator *(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Mul(IntPtr res, IntPtr x, IntPtr y);


        public static ArbMat operator *(Arb m2, ArbMat M1)
        {
            var Res = new ArbMat();
            var t = aflint.mat_t(m2);
            Interop.Lib_Eigen_BasicArithmetic(constants.mp_eigen, constants.mp_apr, Res.mpPtr, constants.mp_const_times_scalar, M1.mpPtr, t.mpPtr);
            return Res;
        }





        public static Arb operator /(Arb x, dynamic y)
        {
            var temp = aflint.t(y);
            if (aflint.iszero(temp)) return aflint.inf();
            return x / temp;

            //return x / aflint.t(y);
        }

        public static Arb operator /(dynamic x, Arb y)
        {
            var temp = aflint.t(x);
            if (aflint.iszero(y)) return aflint.inf();
            return temp / y;

            //return aflint.t(x) / y;
        }


        public static ArbC operator /(Arb x, ArbC y)
        {
            var res = new ArbC();
            Lib_Acb_Arb_Div(res.mpPtr, y.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Acb_Arb_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Acb_Arb_Div(IntPtr res, IntPtr x, IntPtr y);


        public static Arb operator /(Arb x, Arb y)
        {
            if (aflint.iszero(y)) return aflint.inf();

            var res = new Arb();
            Lib_Arb_Div(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Div(IntPtr res, IntPtr x, IntPtr y);



        #endregion


    }




    public class ArbVec
    {
        private Arb[] LocalArbArray;

        public ArbVec()
        {
            LocalArbArray = new Arb[1];
        }

        public ArbVec(int N)
        {
            LocalArbArray = new Arb[N];
        }

        public int Size
        {
            get
            {
                return LocalArbArray.Length;
            }
        }

        public Arb this[int row_i]
        {
            get
            {
                return LocalArbArray[row_i];
            }
            set
            {
                LocalArbArray[row_i] = value;
            }
        }
    }





    public partial class aflint
    {

        #region Function conversions


        public static Single SRealViaArbS1(cb1SArb1S f, Single x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x);

            Single res = sflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Single SRealViaArbS2(cb1SArb2S f, Single x, Single y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y);

            Single res = sflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Single SRealViaArbS3(cb1SArb3S f, Single x, Single y, Single z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_z = aflint.t(z);
            Arb arb_res = f(arb_x, arb_y, arb_z);

            Single res = sflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Double DRealViaArbS1(cb1SArb1S f, Double x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x);

            Double res = dflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Double DRealViaArbS2(cb1SArb2S f, Double x, Double y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y);

            Double res = dflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Double DRealViaArbS3(cb1SArb3S f, Double x, Double y, Double z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_z = aflint.t(z);
            Arb arb_res = f(arb_x, arb_y, arb_z);

            Double res = dflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Extended ERealViaArbS1(cb1SArb1S f, Extended x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x);

            Extended res = eflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Extended ERealViaArbS2(cb1SArb2S f, Extended x, Extended y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y);

            Extended res = eflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Extended ERealViaArbS3(cb1SArb3S f, Extended x, Extended y, Extended z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_z = aflint.t(z);
            Arb arb_res = f(arb_x, arb_y, arb_z);

            Extended res = eflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Quadruple QRealViaArbS1(cb1SArb1S f, Quadruple x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x);

            Quadruple res = qflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Quadruple QRealViaArbS2(cb1SArb2S f, Quadruple x, Quadruple y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y);

            Quadruple res = qflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Quadruple QRealViaArbS3(cb1SArb3S f, Quadruple x, Quadruple y, Quadruple z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_z = aflint.t(z);
            Arb arb_res = f(arb_x, arb_y, arb_z);

            Quadruple res = qflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Octuple ORealViaArbS1(cb1SArb1S f, Octuple x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x);

            Octuple res = oflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Octuple ORealViaArbS2(cb1SArb2S f, Octuple x, Octuple y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y);

            Octuple res = oflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Octuple ORealViaArbS3(cb1SArb3S f, Octuple x, Octuple y, Octuple z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_z = aflint.t(z);
            Arb arb_res = f(arb_x, arb_y, arb_z);

            Octuple res = oflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Mpfr MRealViaArbS1(cb1SArb1S f, Mpfr x)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x);

            Mpfr res = mflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Mpfr MRealViaArbS2(cb1SArb2S f, Mpfr x, Mpfr y)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y);

            Mpfr res = mflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Mpfr MRealViaArbS3(cb1SArb3S f, Mpfr x, Mpfr y, Mpfr z)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_z = aflint.t(z);
            Arb arb_res = f(arb_x, arb_y, arb_z);

            Mpfr res = mflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }








        public static Single SRealViaArbS1Bool1(cb1SArb1SBool f, Single x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x, sc);

            Single res = sflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Single SRealViaArbS2Bool1(cb1SArb2SBool f, Single x, Single y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(8 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y, sc);

            Single res = sflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Double DRealViaArbS1Bool1(cb1SArb1SBool f, Double x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x, sc);

            Double res = dflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Double DRealViaArbS2Bool1(cb1SArb2SBool f, Double x, Double y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(16 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y, sc);

            Double res = dflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Extended ERealViaArbS1Bool1(cb1SArb1SBool f, Extended x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x, sc);

            Extended res = eflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Extended ERealViaArbS2Bool1(cb1SArb2SBool f, Extended x, Extended y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(20 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y, sc);

            Extended res = eflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Quadruple QRealViaArbS1Bool1(cb1SArb1SBool f, Quadruple x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x, sc);

            Quadruple res = qflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Quadruple QRealViaArbS2Bool1(cb1SArb2SBool f, Quadruple x, Quadruple y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(34 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y, sc);

            Quadruple res = qflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Octuple ORealViaArbS1Bool1(cb1SArb1SBool f, Octuple x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x, sc);

            Octuple res = oflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Octuple ORealViaArbS2Bool1(cb1SArb2SBool f, Octuple x, Octuple y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps(72 * 3 / 2);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y, sc);

            Octuple res = oflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Mpfr MpfrViaArbS1Bool1(cb1SArb1SBool f, Mpfr x, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            Arb arb_x = aflint.t(x);
            Arb arb_res = f(arb_x, sc);

            Mpfr res = mflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }


        public static Mpfr MpfrViaArbS2Bool1(cb1SArb2SBool f, Mpfr x, Mpfr y, bool sc)
        {
            ArbPrec.Init();
            uint OldPrec = ArbPrec.GetDps();
            ArbPrec.SetDps((int)OldPrec + 20);

            Arb arb_x = aflint.t(x);
            Arb arb_y = aflint.t(y);
            Arb arb_res = f(arb_x, arb_y, sc);

            Mpfr res = mflint.t(arb_res);
            ArbPrec.SetDps((int)OldPrec);
            return res;
        }





        #endregion



        public static String fmt(Arb x)
        {
            string s = x.ToString();
            return s;
        }


        public static String fmt(dynamic x)
        {
            return fmt(t(x));
        }



        #region VecParams


        public static ArbVec VecParams(params dynamic[] args)
        {
            int N = args.Length;
            var matX3 = new ArbVec(N);
            for (int i = 0; i < N; i++)
                matX3[i] = t(args[i]);
            return matX3;
        }



        #endregion





        #region Basic Functions





        #region General

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/Name/*' />
        public static String name
        {
            get { return "aflint"; }
        }

        /// <include file="docs.xml" path='docs/members[@name="Contexts"]/fmtname/*' />
        public static String fmtname
        {
            get { return " aflint"; }
        }

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
        /// Returns a new Arb using an dynamic (an object whose operations will be resolved at runtime) as input
        /// </summary>
        public static Arb t(dynamic x)
        {
            //MessageBox.Show("In areal_t t(dynamic i)");
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
        /// Returns a new Arb using an arbitrary precision (both mantissa and exponent) ball number as input
        /// </summary>
        public static Arb t(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Set_Arb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Arb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Arb(IntPtr mpfr_out1, IntPtr mpfr_in1);






        /// <summary>
        /// Returns a new Ball using an arbitrary precision binary floating point number as input
        /// </summary>
        public static Arb t(Mpfr x)
        {
            var res = new Arb();
            Lib_Arb_Set_Mpfr(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Mpfr", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Mpfr(IntPtr mpfr_out1, IntPtr mpfr_in1);






        /// <summary>
        /// Returns a new Arb using an octuple precision binary floating point number as input
        /// </summary>
        public static Arb t(Octuple x)
        {
            return t(x.ToString());
        }


        /// <summary>
        /// Returns a new Arb using a quadruple precision binary floating point number as input
        /// </summary>
        public static Arb t(Quadruple x)
        {
            var res = new Arb();
            Lib_Arb_Set_QReal(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_QReal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_QReal(IntPtr ld_out1, IntPtr mpfr_in1);



        /// <summary>
        /// Returns a new Arb using an extended precision floating point number as input
        /// </summary>
        public static Arb t(Extended x)
        {
            var res = new Arb();
            Lib_Arb_Set_LD(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_LD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_LD(IntPtr res, IntPtr x);



        internal static Arb TDS(Double d)
        {
            var res = new Arb();
            string s = d.ToString("G14", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
            Lib_Arb_Set_Str(res.mpPtr, s);
            return res;
        }

        /// <summary>
        /// Returns a new Arb using a double precision floating point number as input
        /// </summary>
        public static Arb t(Double d)
        {
            if ((ArbPrec.UseRawDouble) || (ArbPrec.IsExactDouble(d)))
            {
                var res = new Arb();
                Lib_Arb_Set_D(res.mpPtr, d);
                return res;
            }
            else
            {
                return TDS(d);
            }
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_D", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_D(IntPtr mpfr_out1, Double d);





        /// <summary>
        /// Returns a new Arb using a single precision binary floating point number as input
        /// </summary>
        public static Arb t(Single x)
        {
            var res = new Arb();
            Lib_Arb_Set_S(res.mpPtr, ref x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_S", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_S(IntPtr res, ref Single x);



        /// <summary>
        /// Returns a new Ball using a signed 32 bit integer as input
        /// </summary>
        public static Arb t(Int32 si)
        {
            var res = new Arb();
            Lib_Arb_Set_Si(res.mpPtr, si);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Si(IntPtr res, Int32 si);



        /// <summary>
        /// Returns a new Arb using an unsigned 32 bit integer as input
        /// </summary>
        public static Arb t(UInt32 ui)
        {
            var res = new Arb();
            Lib_Arb_Set_Ui(res.mpPtr, ui);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Ui(IntPtr res, UInt32 ui);



        /// <summary>
        /// Returns a new Arb using a signed 64 bit integer as input
        /// </summary>
        public static Arb t(Int64 si64)
        {
            var res = new Arb();
            Lib_Arb_Set_Si64(res.mpPtr, si64);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Si64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Si64(IntPtr res, Int64 si64);


        /// <summary>
        /// Returns a new Arb using an unsigned 64 bit integer as input
        /// </summary>
        public static Arb t(UInt64 ui64)
        {
            var res = new Arb();
            Lib_Arb_Set_Ui64(res.mpPtr, ui64);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Ui64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Ui64(IntPtr res, UInt64 ui64);


        /// <summary>
        /// Returns a new Arb using an arbitrary precision integer as input
        /// </summary>
        public static Arb t(BigInteger i)
        {
            return t(i.ToString());
        }


        /// <summary>
        /// Returns a new Arb using a System.Decimal as input
        /// </summary>
        public static Arb t(decimal dec)
        {
            return t(dec.ToString());
        }



        /// <summary>
        /// Returns a new Arb using a string as input
        /// </summary>
        public static Arb t(string s)
        {
            var res = new Arb();
            Lib_Arb_Set_Str(res.mpPtr, s);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Set_Str", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Set_Str(IntPtr res, string s);








        #endregion



        #region VecParams, Linspace, BRealMatTFunc



        public static ArbMat Linspace(int n)
        {
            var A = aflint.mat_zeros(n, 1);
            for (int i = 0, loopTo = n - 1; i <= loopTo; i++)
                A[i] = aflint.t(i) / 10;
            return A;
        }




        #endregion



        #region Basic Arithmetic


        public static Arb add(Arb x, Arb y)
        {
            return x + y;
        }
        public static Arb add(dynamic x, dynamic y)
        {
            return t(x) + t(y);
        }

        /// <summary>
        /// Return the sum of x and y
        /// </summary>
        public static void rawadd(Arb res, Arb x, Arb y)
        {
            Lib_Arb_Add(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Add", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Add(IntPtr res, IntPtr x, IntPtr y);


        public static Arb subtract(Arb x, Arb y)
        {
            return x - y;
        }
        public static Arb subtract(dynamic x, dynamic y)
        {
            return t(x) - t(y);
        }
        /// <summary>
        /// Return the difference of x and y
        /// </summary>
        public static void rawsub(Arb res, Arb x, Arb y)
        {
            Lib_Arb_Sub(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Sub", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Sub(IntPtr res, IntPtr x, IntPtr y);


        public static Arb multiply(Arb x, Arb y)
        {
            return x * y;
        }
        public static Arb multiply(dynamic x, dynamic y)
        {
            return t(x) * t(y);
        }

        /// <summary>
        /// Return the product of x and y
        /// </summary>
        public static void rawmul(Arb res, Arb x, Arb y)
        {
            Lib_Arb_Mul(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Mul", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Mul(IntPtr res, IntPtr x, IntPtr y);


        public static Arb divide(Arb x, Arb y)
        {
            return x / y;
        }
        public static Arb divide(dynamic x, dynamic y)
        {
            return t(x) / t(y);
        }
        /// <summary>
        /// Return the quotient of x and y
        /// </summary>
        public static void rawdiv(Arb res, Arb x, Arb y)
        {
            Lib_Arb_Div(res.mpPtr, x.mpPtr, y.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Div", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Div(IntPtr res, IntPtr x, IntPtr y);



        #endregion



        #region General functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Arb fma(Arb x, Arb y, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Fma(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Fma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Fma(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fma/*' />
        public static Arb fma(dynamic x, dynamic y, dynamic z)
        {
            return fma(aflint.t(x), aflint.t(y), aflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Arb fmax(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Fmax(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Fmax", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Fmax(IntPtr res, IntPtr x, IntPtr y);




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmax/*' />
        public static Arb fmax(dynamic x, dynamic y)
        {
            return fmax(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Arb fmin(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Fmin(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Fmin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Fmin(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmin/*' />
        public static Arb fmin(dynamic x, dynamic y)
        {
            return fmin(aflint.t(x), aflint.t(y));
        }


        #endregion



        #region Machine constants


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/zero/*' />
        public static Arb zero()
        {
            var res = new Arb();
            Lib_Arb_Zero(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Zero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Zero(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/negzero/*' />
        public static Arb negzero()
        {
            var res = new Arb();
            Lib_Arb_NegZero(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_NegZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_NegZero(IntPtr res);



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/one/*' />
        public static Arb one()
        {
            var res = new Arb();
            Lib_Arb_One(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_One", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_One(IntPtr res);




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/onej/*' />
        public static ArbC onej()
        {
            return aflintc.t(0d, 1d);
        }





        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static Arb inf()
        {
            var res = new Arb();
            Lib_Arb_Inf(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Inf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Inf(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/neginf/*' />
        public static Arb neginf()
        {
            var res = new Arb();
            Lib_Arb_NegInf(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_NegInf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_NegInf(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/nan/*' />
        public static Arb nan()
        {
            var res = new Arb();
            Lib_Arb_Nan(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Nan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Nan(IntPtr res);



        #endregion



        #region Properties of numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(Arb x)
        {
            return Lib_Arb_Signbit(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Signbit", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Signbit(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/signbit/*' />
        public static int signbit(dynamic x)
        {
            return signbit(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isfinite/*' />
        public static bool isfinite(Arb x)
        {
            return 0 != Lib_Arb_Finite(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Finite", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Finite(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isfinite/*' />
        public static bool isfinite(dynamic x)
        {
            return isfinite(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinf/*' />
        public static bool isinf(Arb x)
        {
            return 0 != (Lib_Arb_IsInf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_IsInf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_IsInf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinf/*' />
        public static bool isinf(dynamic x)
        {
            return isinf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isposinf/*' />
        public static bool isposinf(Arb x)
        {
            return 0 != (Lib_Arb_IsPosInf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_IsPosInf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_IsPosInf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isposinf/*' />
        public static bool isposinf(dynamic x)
        {
            return isposinf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isneginf/*' />
        public static bool isneginf(Arb x)
        {
            return 0 != (Lib_Arb_IsNegInf(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_IsNegInf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_IsNegInf(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isneginf/*' />
        public static bool isneginf(dynamic x)
        {
            return isneginf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnan/*' />
        public static bool isnan(Arb x)
        {
            return 0 != (Lib_Arb_Isnan(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Isnan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Isnan(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnan/*' />
        public static bool isnan(dynamic x)
        {
            return isnan(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/iszero/*' />
        public static bool iszero(Arb x)
        {
            return 0 != (Lib_Arb_IsZero(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_IsZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_IsZero(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/iszero/*' />
        public static bool iszero(dynamic x)
        {
            return iszero(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isone/*' />
        public static bool isone(Arb x)
        {
            return 0 != (Lib_Arb_IsOne(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_IsOne", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_IsOne(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isone/*' />
        public static bool isone(dynamic x)
        {
            return isone(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isinteger/*' />
        public static bool isinteger(Arb x)
        {
            return 0 != (Lib_Arb_IsInteger(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_IsInteger", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_IsInteger(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isinteger/*' />
        public static bool isinteger(dynamic x)
        {
            return isinteger(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnumber/*' />
        public static bool isnumber(Arb x)
        {
            return 0 != (Lib_Arb_Isnumber(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Isnumber", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Isnumber(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnumber/*' />
        public static bool isnumber(dynamic x)
        {
            return isnumber(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isregular/*' />
        public static bool isregular(Arb x)
        {
            return 0 != (Lib_Arb_Isregular(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Isregular", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Isregular(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isregular/*' />
        public static bool isregular(dynamic x)
        {
            return isregular(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isnormal/*' />
        public static bool isnormal(Arb x)
        {
            return 0 != (Lib_Arb_Isnormal(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Isnormal", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Isnormal(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isnormal/*' />
        public static bool isnormal(dynamic x)
        {
            return isnormal(t(x));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/IsSubnormal/*' />
        //public static bool IsSubnormal(Arb x)
        //{
        //    return 0 != (Lib_Arb_Issubnormal(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Issubnormal", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Arb_Issubnormal(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/IsSubnormal/*' />
        //public static bool IsSubnormal(dynamic x)
        //{
        //    return IsSubnormal(t(x));
        //}



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/isunordered/*' />
        public static bool isunordered(Arb x, Arb y)
        {
            return 0 != (Lib_Arb_Isunordered(x.mpPtr, y.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Isunordered", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Isunordered(IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/isunordered/*' />
        public static bool isunordered(dynamic x, dynamic y)
        {
            return isunordered(t(x), t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint32/*' />
        public static bool fitsint32(Arb x)
        {
            return 0 != (Lib_Arb_FitsInt32(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_FitsInt32", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_FitsInt32(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint32/*' />
        public static bool fitsint32(dynamic x)
        {
            return fitsint32(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/fitsint64/*' />
        public static bool fitsint64(Arb x)
        {
            return 0 != (Lib_Arb_FitsInt64(x.mpPtr));
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_FitsInt64", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_FitsInt64(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fitsint64/*' />
        public static bool fitsint64(dynamic x)
        {
            return fitsint64(t(x));
        }



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/FitsUInt32/*' />
        //public static bool FitsUInt32(Arb x)
        //{
        //    return 0 != (Lib_Arb_FitsUInt32(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_FitsUInt32", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Arb_FitsUInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/FitsUInt32/*' />
        //public static bool FitsUInt32(dynamic x)
        //{
        //    return FitsUInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/FitsUInt64/*' />
        //public static bool FitsUInt64(Arb x)
        //{
        //    return 0 != (Lib_Arb_FitsUInt64(x.mpPtr));
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_FitsUInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Arb_FitsUInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/FitsUInt64/*' />
        //public static bool FitsUInt64(dynamic x)
        //{
        //    return FitsUInt64(t(x));
        //}




        #endregion



        #region Integer Related Functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Arb nearbyint(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Nearbyint(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Nearbyint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Nearbyint(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nearbyint/*' />
        public static Arb nearbyint(dynamic x)
        {
            return nearbyint(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Arb rint(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Rint(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Rint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Rint(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rint/*' />
        public static Arb rint(dynamic x)
        {
            return rint(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(Arb x)
        {
            return Lib_Arb_Lrint(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Lrint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_Lrint(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lrint/*' />
        public static Int32 lrint(dynamic x)
        {
            return lrint(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(Arb x)
        {
            return Lib_Arb_Llrint(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Llrint", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int64 Lib_Arb_Llrint(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llrint/*' />
        public static Int64 llrint(dynamic x)
        {
            return llrint(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Arb ceil(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Ceil(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Ceil", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Ceil(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ceil/*' />
        public static Arb ceil(dynamic x)
        {
            return ceil(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Arb floor(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Floor(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Floor", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Floor(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/floor/*' />
        public static Arb floor(dynamic x)
        {
            return floor(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Arb trunc(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Trunc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Trunc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Trunc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trunc/*' />
        public static Arb trunc(dynamic x)
        {
            return trunc(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Arb round(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Round(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Round", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Round(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/round/*' />
        public static Arb round(dynamic x)
        {
            return round(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(Arb x)
        {
            return Lib_Arb_Lround(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Lround", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_Lround(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lround/*' />
        public static Int32 lround(dynamic x)
        {
            return lround(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(Arb x)
        {
            return Lib_Arb_Llround(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Llround", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int64 Lib_Arb_Llround(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/llround/*' />
        public static Int64 llround(dynamic x)
        {
            return llround(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt32/*' />
        internal static Int32 ToInt32(Arb x)
        {
            return Lib_Arb_ToInt32(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ToInt32", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_ToInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt32/*' />
        //public static Int32 ToInt32(dynamic x)
        //{
        //    return ToInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt64/*' />
        //public static Int64 ToInt64(Arb x)
        //{
        //    return Lib_Arb_ToInt64(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ToInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern Int64 Lib_Arb_ToInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToInt64/*' />
        //public static Int64 ToInt64(dynamic x)
        //{
        //    return ToInt64(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt32/*' />
        //public static UInt32 ToUInt32(Arb x)
        //{
        //    return Lib_Arb_ToUInt32(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ToUInt32", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern UInt32 Lib_Arb_ToUInt32(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt32/*' />
        //public static UInt32 ToUInt32(dynamic x)
        //{
        //    return ToUInt32(t(x));
        //}



        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt64/*' />
        //public static UInt64 ToUInt64(Arb x)
        //{
        //    return Lib_Arb_ToUInt64(x.mpPtr);
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ToUInt64", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern UInt64 Lib_Arb_ToUInt64(IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ToUInt64/*' />
        //public static UInt64 ToUInt64(dynamic x)
        //{
        //    return ToUInt64(t(x));
        //}




        #endregion



        #region Floating point functions for real numbers


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Arb copysign(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Copysign(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Copysign", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Copysign(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/copysign/*' />
        public static Arb copysign(dynamic x, dynamic y)
        {
            return copysign(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Frexp/*' />
        public static Tuple<Arb, Int32> Frexp(Arb x)
        {
            var res = new Arb();
            Int32 e = 0;
            Lib_Arb_Frexp(res.mpPtr, x.mpPtr, ref e);
            return new Tuple<Arb, int>(res, e);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Frexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Frexp(IntPtr res, IntPtr x, ref Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/Frexp/*' />
        public static Tuple<Arb, Int32> Frexp(dynamic x)
        {
            return Frexp(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Arb logb(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Logb(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Logb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Logb(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logb/*' />
        public static Arb logb(dynamic x)
        {
            return logb(t(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(Arb x)
        {
            return Lib_Arb_Ilogb(x.mpPtr);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Ilogb", CallingConvention = CallingConvention.Cdecl)]
        internal static extern Int32 Lib_Arb_Ilogb(IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ilogb/*' />
        public static Int32 ilogb(dynamic x)
        {
            return ilogb(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Arb ldexp(Arb x, Int32 e)
        {
            var res = new Arb();
            Lib_Arb_Ldexp(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Ldexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Ldexp(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ldexp/*' />
        public static Arb ldexp(dynamic x, dynamic e)
        {
            return ldexp(t(x), ToInt32(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Arb scalbn(Arb x, Int32 e)
        {
            var res = new Arb();
            Lib_Arb_Scalbn(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Scalbn", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Scalbn(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbn/*' />
        public static Arb scalbn(dynamic x, dynamic e)
        {
            return scalbn(t(x), ToInt32(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Arb scalbln(Arb x, Int32 e)
        {
            var res = new Arb();
            Lib_Arb_Scalbln(res.mpPtr, x.mpPtr, e);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Scalbln", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Scalbln(IntPtr res, IntPtr x, Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/scalbln/*' />
        public static Arb scalbln(dynamic x, dynamic e)
        {
            return scalbln(t(x), ToInt32(t(e)));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Arb fdim(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Fdim(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Fdim", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Fdim(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fdim/*' />
        public static Arb fdim(dynamic x, dynamic y)
        {
            return fdim(aflint.t(x), aflint.t(y));
        }


        #endregion



        #region Fraction and remainder Related Functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Arb, Arb> modf(Arb x)
        {
            Arb iptr = new Arb();
            Arb frac = new Arb();
            Lib_Arb_Modf(frac.mpPtr, x.mpPtr, iptr.mpPtr);
            return new Tuple<Arb, Arb>(iptr, frac);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Modf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Modf(IntPtr frac, IntPtr x, IntPtr iptr);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/modf/*' />
        public static Tuple<Arb, Arb> modf(dynamic x)
        {
            return modf(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Arb fmod(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Fmod(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Fmod", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Fmod(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fmod/*' />
        public static Arb fmod(dynamic x, dynamic y)
        {
            return fmod(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Arb remainder(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Remainder(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Remainder", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Remainder(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remainder/*' />
        public static Arb remainder(dynamic x, dynamic y)
        {
            return remainder(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Arb, Int32> remquo(Arb x, Arb y)
        {
            var res = new Arb();
            Int32 e = 0;
            Lib_Arb_Remquo(res.mpPtr, x.mpPtr, y.mpPtr, ref e);
            return new Tuple<Arb, int>(res, e);
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Remquo", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Remquo(IntPtr res, IntPtr x, IntPtr y, ref Int32 e);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/remquo/*' />
        public static Tuple<Arb, Int32> remquo(dynamic x)
        {
            return remquo(t(x));
        }

        #endregion



        #region Functions related to mantissa width and exponent range


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/Epsilon/*' />
        public static Arb epsilon()
        {
            var res = new Arb();
            Lib_Arb_Epsilon(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Epsilon", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Epsilon(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ulp/*' />
        public static Arb ulp(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Ulp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Ulp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Ulp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/maxvalue/*' />
        public static Arb maxvalue()
        {
            var res = new Arb();
            Lib_Arb_Max(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Max", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Max(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/lowestvalue/*' />
        public static Arb lowestvalue()
        {
            var res = new Arb();
            Lib_Arb_Lowest(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Lowest", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Lowest(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ConstantsAndProperties"]/minposvalue/*' />
        public static Arb minposvalue()
        {
            var res = new Arb();
            Lib_Arb_Min(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Min", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Min(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nexttowards/*' />
        public static Arb nexttowards(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Nexttoward(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Nexttoward", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Nexttoward(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nexttowards/*' />
        public static Arb nexttowards(dynamic x, dynamic y)
        {
            return nexttowards(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Arb nextabove(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Nextabove(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Nextabove", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Nextabove(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextabove/*' />
        public static Arb nextabove(dynamic x)
        {
            return nextabove(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Arb nextbelow(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Nextbelow(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Nextbelow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Nextbelow(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/nextbelow/*' />
        public static Arb nextbelow(dynamic x)
        {
            return nextbelow(t(x));
        }


        #endregion



        #region Mathematical Constants


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/degree/*' />
        public static Arb degree()
        {
            var res = new Arb();
            Lib_Arb_ConstDegree(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstDegree", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstDegree(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phi/*' />
        public static Arb phi()
        {
            var res = new Arb();
            Lib_Arb_ConstPhi(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstPhi(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln2/*' />
        public static Arb ln2()
        {
            var res = new Arb();
            Lib_Arb_ConstLog2(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstLog2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstLog2(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ln10/*' />
        public static Arb ln10()
        {
            var res = new Arb();
            Lib_Arb_ConstLog10(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstLog10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstLog10(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pi/*' />
        public static Arb pi()
        {
            var res = new Arb();
            Lib_Arb_ConstPi(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstPi(IntPtr res);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/PI/*' />
        //public static Arb PI()
        //{
        //    return PI();
        //}


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/e/*' />
        public static Arb e()
        {
            var res = new Arb();
            Lib_Arb_ConstE(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstE(IntPtr res);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/E/*' />
        //public static Arb E()
        //{
        //    return E();
        //}


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/egamma/*' />
        public static Arb egamma()
        {
            var res = new Arb();
            Lib_Arb_ConstEulerGamma(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstEulerGamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstEulerGamma(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/apery/*' />
        public static Arb apery()
        {
            var res = new Arb();
            Lib_Arb_ConstApery(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstApery", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstApery(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/catalan/*' />
        public static Arb catalan()
        {
            var res = new Arb();
            Lib_Arb_ConstCatalan(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstCatalan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstCatalan(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/glaisher/*' />
        public static Arb glaisher()
        {
            var res = new Arb();
            Lib_Arb_ConstGlaisher(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstGlaisher", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstGlaisher(IntPtr res);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/khinchin/*' />
        public static Arb khinchin()
        {
            var res = new Arb();
            Lib_Arb_ConstKhinchin(res.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_ConstKhinchin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_ConstKhinchin(IntPtr res);


        #endregion



        #region Complex components


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Arb abs(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Fabs(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Fabs", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Fabs(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/abs/*' />
        public static Arb abs(dynamic x)
        {
            return abs(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Arb fabs(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Fabs(res.mpPtr, x.mpPtr);
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fabs/*' />
        public static Arb fabs(dynamic x)
        {
            return fabs(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Arb sign(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Sign(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Sign", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Sign(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sign/*' />
        public static Arb sign(dynamic x)
        {
            return sign(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Arb real(Arb x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/real/*' />
        public static Arb real(dynamic x)
        {
            return real(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Arb imag(Arb x)
        {
            return zero();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/imag/*' />
        public static Arb imag(dynamic x)
        {
            return imag(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Arb phase(Arb x)
        {
            if (x >= zero()) return zero();
            else return pi();
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/phase/*' />
        public static Arb phase(dynamic x)
        {
            return phase(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Arb conj(Arb x)
        {
            return +x;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/conj/*' />
        public static Arb conj(dynamic x)
        {
            return conj(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Arb, Arb> polar(Arb x)
        {
            return new Tuple<Arb, Arb>(abs(x), phase(x));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polar/*' />
        public static Tuple<Arb, Arb> polar(dynamic x)
        {
            return polar(aflint.t(x));
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
        public static Arb sqrt(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Sqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Sqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Sqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt/*' />
        public static Arb sqrt(dynamic x)
        {
            return sqrt(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Arb sqrt1pm1(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Sqrt1pm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Sqrt1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Sqrt1pm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqrt1pm1/*' />
        public static Arb sqrt1pm1(dynamic x)
        {
            return cbrt(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Arb rsqrt(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Rsqrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Rsqrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Rsqrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rsqrt/*' />
        public static Arb rsqrt(dynamic x)
        {
            return rsqrt(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Arb cbrt(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Cbrt(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Cbrt", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Cbrt(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cbrt/*' />
        public static Arb cbrt(dynamic x)
        {
            return cbrt(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Arb root_si(Arb x, Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_Root_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Root_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Root_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/root_si/*' />
        public static Arb root_si(dynamic x, Int32 n)
        {
            return root_si(t(x), n);
        }




        #endregion



        #region Exponential and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Arb exp(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Exp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Exp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Exp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp/*' />
        public static Arb exp(dynamic x)
        {
            return exp(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static ArbC expj(Arb x)
        {
            return aflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expj/*' />
        public static ArbC expj(dynamic x)
        {
            return aflintc.expj(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static ArbC expjpi(Arb x)
        {
            return aflintc.expjpi(x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expjpi/*' />
        public static ArbC expjpi(dynamic x)
        {
            return aflintc.expjpi(x);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Arb exp2(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Exp2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Exp2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Exp2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2/*' />
        public static Arb exp2(dynamic x)
        {
            return exp2(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Arb exp10(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Exp10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Exp10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Exp10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10/*' />
        public static Arb exp10(dynamic x)
        {
            return exp10(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Arb expm1(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Expm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Expm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Expm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/expm1/*' />
        public static Arb expm1(dynamic x)
        {
            return expm1(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Arb exp10m1(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Exp10m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Exp10m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Exp10m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp10m1/*' />
        public static Arb exp10m1(dynamic x)
        {
            return exp10m1(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Arb exp2m1(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Exp2m1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Exp2m1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Exp2m1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp2m1/*' />
        public static Arb exp2m1(dynamic x)
        {
            return exp2m1(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Arb exprel(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_ExpRel(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_ExpRel", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_ExpRel(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exprel/*' />
        public static Arb exprel(dynamic x)
        {
            return exprel(aflint.t(x));
        }





        #endregion



        #region Logarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Arb log(Arb x)
        {
            if (x == 0) return aflint.neginf();
            if (x < 0) return aflint.nan();
            if (isnan(x)) return aflint.nan();
            var res = new Arb();
            Lib_Arb_Log(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Log", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Log(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log/*' />
        public static Arb log(dynamic x)
        {
            return log(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Arb logbase(Arb x, Arb b)
        {
            var res = new Arb();
            Lib_Arb_Arb_Logbase(res.mpPtr, x.mpPtr, b.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Logbase", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Logbase(IntPtr res, IntPtr x, IntPtr b);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbase/*' />
        public static Arb logbase(dynamic x, dynamic b)
        {
            return logbase(aflint.t(x), aflint.t(b));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Arb log2(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Log2(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Log2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Log2(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2/*' />
        public static Arb log2(dynamic x)
        {
            return log2(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Arb log10(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Log10(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Log10", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Log10(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10/*' />
        public static Arb log10(dynamic x)
        {
            return log10(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Arb log1p(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Log1p(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Log1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Log1p(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1p/*' />
        public static Arb log1p(dynamic x)
        {
            return log1p(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Arb log10p1(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Log10p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Log10p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Log10p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log10p1/*' />
        public static Arb log10p1(dynamic x)
        {
            return log10p1(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Arb log2p1(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Log2p1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Log2p1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Log2p1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log2p1/*' />
        public static Arb log2p1(dynamic x)
        {
            return log2p1(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Arb log1mexp(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Log1mexp(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Log1mexp", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Log1mexp(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log1mexp/*' />
        public static Arb log1mexp(dynamic x)
        {
            return log1mexp(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Arb lambert_w0(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_LambertW0(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_LambertW0", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_LambertW0(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_w0/*' />
        public static Arb lambert_w0(dynamic x)
        {
            return lambert_w0(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Arb lambert_wm1(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_LambertWm1(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_LambertWm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_LambertWm1(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wm1/*' />
        public static Arb lambert_wm1(dynamic x)
        {
            return lambert_wm1(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static ArbC lambert_wk(Arb x, int k)
        {
            return aflintc.lambert_wk(aflintc.t(x), k);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lambert_wk/*' />
        public static ArbC lambert_wk(dynamic x, int k)
        {
            return lambert_wk(aflint.t(x), k);
        }







        #endregion



        #region Power functions

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Arb sqr(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Square(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Square", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Square(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sqr/*' />
        public static Arb sqr(dynamic x)
        {
            return sqr(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Arb cube(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Cube(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Cube", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Cube(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cube/*' />
        public static Arb cube(dynamic x)
        {
            return cube(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Arb pow(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Pow(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Pow", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Pow(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow/*' />
        public static Arb pow(dynamic x, dynamic y)
        {
            return pow(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Arb hypot(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Hypot(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Hypot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Hypot(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hypot/*' />
        public static Arb hypot(dynamic x, dynamic y)
        {
            return hypot(aflint.t(x), aflint.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powi/*' />
        public static Arb pow_si(Arb x, Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_Pow_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Pow_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Pow_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow_si/*' />
        public static Arb pow_si(dynamic x, Int32 n)
        {
            return pow_si(aflint.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Arb compound_si(Arb x, Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_Compound_si(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Compound_si", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Compound_si(IntPtr res, IntPtr x, Int32 n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/compound_si/*' />
        public static Arb compound_si(dynamic x, Int32 n)
        {
            return compound_si(aflint.t(x), n);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Arb powm1(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Arb_Powm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Powm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Powm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/powm1/*' />
        public static Arb powm1(dynamic x, dynamic y)
        {
            return powm1(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Arb pow1p(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Arb_Pow1p(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Pow1p", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Pow1p(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1p/*' />
        public static Arb pow1p(dynamic x, dynamic y)
        {
            return pow1p(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Arb pow1pm1(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Arb_Pow1pm1(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Pow1pm1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Pow1pm1(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pow1pm1/*' />
        public static Arb pow1pm1(dynamic x, dynamic y)
        {
            return pow1pm1(aflint.t(x), aflint.t(y));
        }







        #endregion



        #region Trigonometric and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Arb sin(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Sin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Sin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Sin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin/*' />
        public static Arb sin(dynamic x)
        {
            return sin(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Arb cos(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Cos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Cos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Cos(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos/*' />
        public static Arb cos(dynamic x)
        {
            return cos(t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Arb tan(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Tan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Tan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Tan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tan/*' />
        public static Arb tan(dynamic x)
        {
            return tan(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Arb cot(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Cot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Cot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Cot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cot/*' />
        public static Arb cot(dynamic x)
        {
            return cot(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Arb sec(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Sec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Sec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Sec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sec/*' />
        public static Arb sec(dynamic x)
        {
            return sec(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Arb csc(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Csc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Csc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Csc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csc/*' />
        public static Arb csc(dynamic x)
        {
            return csc(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Arb sinc(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Sinc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Sinc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Sinc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinc/*' />
        public static Arb sinc(dynamic x)
        {
            return sinc(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Arb sinpi(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_SinPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_SinPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_SinPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinpi/*' />
        public static Arb sinpi(dynamic x)
        {
            return sinpi(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Arb cospi(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_CosPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_CosPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_CosPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cospi/*' />
        public static Arb cospi(dynamic x)
        {
            return cospi(aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Arb tanpi(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_TanPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_TanPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_TanPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanpi/*' />
        public static Arb tanpi(dynamic x)
        {
            return tanpi(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Arb cotpi(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_CotPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_CotPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_CotPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cotpi/*' />
        public static Arb cotpi(dynamic x)
        {
            return cotpi(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Arb cscpi(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_SinPi(res.mpPtr, x.mpPtr);
            return 1 / res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cscpi/*' />
        public static Arb cscpi(dynamic x)
        {
            return cscpi(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Arb secpi(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_CosPi(res.mpPtr, x.mpPtr);
            return 1 / res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/secpi/*' />
        public static Arb secpi(dynamic x)
        {
            return secpi(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Arb sincpi(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_SincPi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_SincPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_SincPi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sincpi/*' />
        public static Arb sincpi(dynamic x)
        {
            return sincpi(aflint.t(x));
        }


        #endregion



        #region Hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Arb sinh(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Sinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Sinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Sinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh/*' />
        public static Arb sinh(dynamic x)
        {
            return sinh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Arb cosh(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Cosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Cosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Cosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh/*' />
        public static Arb cosh(dynamic x)
        {
            return cosh(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Arb tanh(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Tanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Tanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Tanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/tanh/*' />
        public static Arb tanh(dynamic x)
        {
            return tanh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Arb csch(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Csch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Csch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Csch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/csch/*' />
        public static Arb csch(dynamic x)
        {
            return csch(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Arb sech(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Sech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Sech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Sech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sech/*' />
        public static Arb sech(dynamic x)
        {
            return sech(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Arb coth(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Coth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Coth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Coth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coth/*' />
        public static Arb coth(dynamic x)
        {
            return coth(aflint.t(x));
        }





        #endregion



        #region Inverse trigonometric functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Arb asin(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Asin(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Asin", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Asin(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asin/*' />
        public static Arb asin(dynamic x)
        {
            return asin(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Arb acos(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Acos(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Acos", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Acos(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acos/*' />
        public static Arb acos(dynamic x)
        {
            return acos(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Arb atan(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Atan(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Atan", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Atan(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan/*' />
        public static Arb atan(dynamic x)
        {
            return atan(t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Arb atan2(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Atan2(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Atan2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Atan2(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atan2/*' />
        public static Arb atan2(dynamic x, dynamic y)
        {
            return atan2(aflint.t(x), aflint.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Arb acsc(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Acsc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Acsc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Acsc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsc/*' />
        public static Arb acsc(dynamic x)
        {
            return acsc(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Arb asec(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Asec(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Asec", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Asec(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asec/*' />
        public static Arb asec(dynamic x)
        {
            return asec(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Arb acot(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Acot(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Acot", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Acot(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acot/*' />
        public static Arb acot(dynamic x)
        {
            return acot(aflint.t(x));
        }




        #endregion



        #region Inverse hyperbolic functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Arb asinh(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Asinh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Asinh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Asinh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asinh/*' />
        public static Arb asinh(dynamic x)
        {
            return asinh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Arb acosh(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Acosh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Acosh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Acosh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acosh/*' />
        public static Arb acosh(dynamic x)
        {
            return acosh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Arb atanh(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Atanh(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Atanh", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Atanh(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/atanh/*' />
        public static Arb atanh(dynamic x)
        {
            return atanh(t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Arb acsch(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Acsch(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Acsch", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Acsch(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acsch/*' />
        public static Arb acsch(dynamic x)
        {
            return acsch(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Arb asech(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Asech(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Asech", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Asech(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/asech/*' />
        public static Arb asech(dynamic x)
        {
            return asech(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Arb acoth(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Acoth(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Acoth", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Acoth(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/acoth/*' />
        public static Arb acoth(dynamic x)
        {
            return acoth(aflint.t(x));
        }






        #endregion



        #region Gamma and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Arb gamma(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Gamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Gamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Gamma(IntPtr res, IntPtr x);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma/*' />
        public static Arb gamma(dynamic x)
        {
            return gamma(aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Arb gamma1pm1(Arb x)
        {
            return gamma(x + 1) - 1;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma1pm1/*' />
        public static Arb gamma1pm1(dynamic x)
        {
            return gamma1pm1(aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Arb rgamma(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Rgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Rgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Rgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rgamma/*' />
        public static Arb rgamma(dynamic x)
        {
            return rgamma(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Arb lgamma(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Lgamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Lgamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Lgamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lgamma/*' />
        public static Arb lgamma(dynamic x)
        {
            return lgamma(aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Arb factorial(Arb x)
        {
            return gamma(x + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/factorial/*' />
        public static Arb factorial(dynamic x)
        {
            return factorial(aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Arb doublefactorial(Arb x)
        {
            return exp2(x / 2) * pow(pi() / 2, (cospi(x) - 1) / 4) * gamma(x / 2 + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/doublefactorial/*' />
        public static Arb doublefactorial(dynamic x)
        {
            return doublefactorial(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Arb rising_factorial(Arb a, Arb n)
        {
            var res = new Arb();
            Lib_Arb_Arb_RisingFactorial(res.mpPtr, a.mpPtr, n.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_RisingFactorial", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_RisingFactorial(IntPtr res, IntPtr a, IntPtr n);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/rising_factorial/*' />
        public static Arb rising_factorial(dynamic x, dynamic y)
        {
            return rising_factorial(aflint.t(x), aflint.t(y));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Arb falling_factorial(Arb a, Arb n)
        {
            return rising_factorial(a - n + 1, n);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/falling_factorial/*' />
        public static Arb falling_factorial(dynamic a, dynamic n)
        {
            return falling_factorial(aflint.t(a), aflint.t(n));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Arb gamma_ratio(Arb a, Arb b)
        {
            return gamma(a)/ gamma(b);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_ratio/*' />
        public static Arb gamma_ratio(dynamic a, dynamic b)
        {
            return gamma_ratio(aflint.t(a), aflint.t(b));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Arb gamma_delta_ratio(Arb a, Arb delta)
        {
            return gamma(a) / gamma(a + delta);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_delta_ratio/*' />
        public static Arb gamma_delta_ratio(dynamic a, dynamic delta)
        {
            return gamma_delta_ratio(aflint.t(a), aflint.t(delta));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Arb beta(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Arb_Beta(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Beta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Beta(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta/*' />
        public static Arb beta(dynamic x, dynamic y)
        {
            return beta(aflint.t(x), aflint.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Arb binomial(Arb n, Arb k)
        {
            return gamma(n + 1) / (gamma(k + 1) * gamma(n - k + 1));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/binomial/*' />
        public static Arb binomial(dynamic n, dynamic k)
        {
            return binomial(aflint.t(n), aflint.t(k));
        }





        #endregion






        #region Matrix Creation


        /// <summary>
        /// Converts from a real scalar of type Arb
        /// </summary>
        public static ArbMat mat_t(Arb x)
        {
            var matA = new ArbMat();
            matA[0, 0] = x;
            return matA;
        }



        /// <summary>
        /// Returns SetZero
        /// </summary>
        public static ArbMat mat_zeros(int n, int m)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_setZero, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetOnes
        /// </summary>
        public static ArbMat mat_ones(int n, int m)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_setOnes, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static ArbMat mat_identity(int n, int m)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns SetIdentity
        /// </summary>
        public static ArbMat mat_eye(int n, int m)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_setIdentity, n, m);
            return resout;
        }


        /// <summary>
        /// Returns Random
        /// </summary>
        public static ArbMat mat_random(int n, int m)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_setRandom_nm, n, m);
            return resout;
        }


        /// <summary>
        /// Returns RandomSym
        /// </summary>
        public static ArbMat mat_random_symmetric(int n)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_setRandomSymmetric, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSa
        /// </summary>
        public static ArbMat mat_random_selfadjoint(int n)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_setRandomSA, n, n);
            return resout;
        }


        /// <summary>
        /// Returns RandomSaPosdef
        /// </summary>
        public static ArbMat mat_random_selfadjoint_posdef(int n)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_setRandomSAPosDef, n, n);
            return resout;
        }


        /// <summary>
        /// Returns FillLinear
        /// </summary>
        public static ArbMat mat_fill_linear(int n, int m)
        {
            var resout = new ArbMat();
            Interop.Call_Eigen_SetSpecialValue(constants.mp_eigen, constants.mp_apr, resout, constants.mp_FillLinear, n, m);
            return resout;
        }






        #endregion






        #endregion



















        #region Flint Special Functions



        #region Carlson symmetric elliptic integrals


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Arb elliptic_rc(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Arb_Elliptic_RC(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Elliptic_RC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Elliptic_RC(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Arb elliptic_rc(dynamic x, dynamic y)
        {
            return elliptic_rc(aflint.t(x), aflint.t(y));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Arb elliptic_rf(Arb x, Arb y, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_Elliptic_RF(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Elliptic_RF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Elliptic_RF(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rf/*' />
        public static Arb elliptic_rf(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rf(aflint.t(x), aflint.t(y), aflint.t(z));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Arb elliptic_rg(Arb x, Arb y, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_Elliptic_RG(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Elliptic_RG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Elliptic_RG(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rg/*' />
        public static Arb elliptic_rg(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rg(aflint.t(x), aflint.t(y), aflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Arb elliptic_rd(Arb x, Arb y, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_Elliptic_RD(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Elliptic_RD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Elliptic_RD(IntPtr res, IntPtr x, IntPtr y, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rd/*' />
        public static Arb elliptic_rd(dynamic x, dynamic y, dynamic z)
        {
            return elliptic_rd(aflint.t(x), aflint.t(y), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Arb elliptic_rj(Arb x, Arb y, Arb z, Arb w)
        {
            var res = new Arb();
            Lib_Arb_Arb_Elliptic_RJ(res.mpPtr, x.mpPtr, y.mpPtr, z.mpPtr, w.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Elliptic_RJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Elliptic_RJ(IntPtr res, IntPtr x, IntPtr y, IntPtr z, IntPtr w);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_rj/*' />
        public static Arb elliptic_rj(dynamic x, dynamic y, dynamic z, dynamic w)
        {
            return elliptic_rj(aflint.t(x), aflint.t(y), aflint.t(z), aflint.t(w));
        }




        #endregion




        #region Legendre elliptic integrals (elliptic parameter m), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Arb m_elliptic_k(Arb m)
        {
            var res = new Arb();
            Lib_Arb_Arb_MEllipticK(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_MEllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_MEllipticK(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_k/*' />
        public static Arb m_elliptic_k(dynamic x)
        {
            return m_elliptic_k(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Arb m_elliptic_e(Arb m)
        {
            var res = new Arb();
            Lib_Arb_Arb_MEllipticE(res.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_MEllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_MEllipticE(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e/*' />
        public static Arb m_elliptic_e(dynamic x)
        {
            return m_elliptic_e(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Arb m_elliptic_pi(Arb n, Arb m)
        {
            var res = new Arb();
            Lib_Arb_Arb_MEllipticPi(res.mpPtr, n.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_MEllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_MEllipticPi(IntPtr res, IntPtr n, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi/*' />
        public static Arb m_elliptic_pi(dynamic x, dynamic y)
        {
            return m_elliptic_pi(aflint.t(x), aflint.t(y));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Arb m_elliptic_f(Arb phi, Arb m)
        {
            var res = new Arb();
            Lib_Arb_Arb_MEllipticF(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_MEllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_MEllipticF(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_f/*' />
        public static Arb m_elliptic_f(dynamic phi, dynamic m)
        {
            return m_elliptic_f(aflint.t(phi), aflint.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Arb m_elliptic_e_inc(Arb phi, Arb m)
        {
            var res = new Arb();
            Lib_Arb_Arb_MEllipticEInc(res.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_MEllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_MEllipticEInc(IntPtr res, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_e_inc/*' />
        public static Arb m_elliptic_e_inc(dynamic phi, dynamic m)
        {
            return m_elliptic_e_inc(aflint.t(phi), aflint.t(m));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Arb m_elliptic_pi_inc(Arb n, Arb phi, Arb m)
        {
            var res = new Arb();
            Lib_Arb_Arb_MEllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, m.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_MEllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_MEllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr m);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/m_elliptic_pi_inc/*' />
        public static Arb m_elliptic_pi_inc(dynamic n, dynamic phi, dynamic m)
        {
            return m_elliptic_pi_inc(aflint.t(n), aflint.t(phi), aflint.t(m));
        }




        #endregion



        #region Legendre elliptic integrals (elliptic modulus k), and related functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Arb elliptic_k(Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_EllipticK(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_EllipticK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_EllipticK(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_k/*' />
        public static Arb elliptic_k(dynamic k)
        {
            return elliptic_k(aflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Arb elliptic_e(Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_EllipticE(res.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_EllipticE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_EllipticE(IntPtr res, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e/*' />
        public static Arb elliptic_e(dynamic k)
        {
            return elliptic_e(aflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Arb elliptic_pi(Arb n, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_EllipticPi(res.mpPtr, n.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_EllipticPi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_EllipticPi(IntPtr res, IntPtr n, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi/*' />
        public static Arb elliptic_pi(dynamic n, dynamic k)
        {
            return elliptic_pi(aflint.t(n), aflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Arb elliptic_f(Arb phi, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_EllipticF(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_EllipticF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_EllipticF(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_f/*' />
        public static Arb elliptic_f(dynamic phi, dynamic k)
        {
            return elliptic_f(aflint.t(phi), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Arb elliptic_e_inc(Arb phi, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_EllipticEInc(res.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_EllipticEInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_EllipticEInc(IntPtr res, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_e_inc/*' />
        public static Arb elliptic_e_inc(dynamic phi, dynamic k)
        {
            return elliptic_e_inc(aflint.t(phi), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Arb elliptic_pi_inc(Arb n, Arb phi, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_EllipticPiInc(res.mpPtr, n.mpPtr, phi.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_EllipticPiInc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_EllipticPiInc(IntPtr res, IntPtr n, IntPtr phi, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/elliptic_pi_inc/*' />
        public static Arb elliptic_pi_inc(dynamic n, dynamic phi, dynamic k)
        {
            return elliptic_pi_inc(aflint.t(n), aflint.t(phi), aflint.t(k));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Arb agm(Arb x, Arb y)
        {
            var res = new Arb();
            Lib_Arb_Arb_Agm(res.mpPtr, x.mpPtr, y.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Agm", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Agm(IntPtr res, IntPtr x, IntPtr y);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/agm/*' />
        public static Arb agm(dynamic x, dynamic y)
        {
            return agm(aflint.t(x), aflint.t(y));
        }


        #endregion




        #region Jacobi elliptic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Arb jacobi_sn(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiSN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiSN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiSN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sn/*' />
        public static Arb jacobi_sn(dynamic x, dynamic k)
        {
            return jacobi_sn(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Arb jacobi_cn(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiCN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiCN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiCN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cn/*' />
        public static Arb jacobi_cn(dynamic x, dynamic k)
        {
            return jacobi_cn(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Arb jacobi_dn(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiDN(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiDN", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiDN(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dn/*' />
        public static Arb jacobi_dn(dynamic x, dynamic k)
        {
            return jacobi_dn(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Arb jacobi_ns(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiNS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiNS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiNS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ns/*' />
        public static Arb jacobi_ns(dynamic x, dynamic k)
        {
            return jacobi_ns(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Arb jacobi_nc(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiNC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiNC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiNC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nc/*' />
        public static Arb jacobi_nc(dynamic x, dynamic k)
        {
            return jacobi_nc(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Arb jacobi_nd(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiND(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiND", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiND(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_nd/*' />
        public static Arb jacobi_nd(dynamic x, dynamic k)
        {
            return jacobi_nd(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Arb jacobi_sc(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiSC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiSC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiSC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sc/*' />
        public static Arb jacobi_sc(dynamic x, dynamic k)
        {
            return jacobi_sc(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Arb jacobi_sd(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiSD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiSD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiSD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_sd/*' />
        public static Arb jacobi_sd(dynamic x, dynamic k)
        {
            return jacobi_sd(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Arb jacobi_dc(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiDC(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiDC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiDC(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_dc/*' />
        public static Arb jacobi_dc(dynamic x, dynamic k)
        {
            return jacobi_dc(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Arb jacobi_ds(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiDS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiDS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiDS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_ds/*' />
        public static Arb jacobi_ds(dynamic x, dynamic k)
        {
            return jacobi_ds(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Arb jacobi_cs(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiCS(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiCS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiCS(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cs/*' />
        public static Arb jacobi_cs(dynamic x, dynamic k)
        {
            return jacobi_cs(aflint.t(x), aflint.t(k));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Arb jacobi_cd(Arb x, Arb k)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiCD(res.mpPtr, x.mpPtr, k.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiCD", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_JacobiCD(IntPtr res, IntPtr x, IntPtr k);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_cd/*' />
        public static Arb jacobi_cd(dynamic x, dynamic k)
        {
            return jacobi_cd(aflint.t(x), aflint.t(k));
        }








        #endregion





        #region Jacobi theta functions




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Arb jacobi_theta1(Arb x, Arb q)
        {
            var res = new Arb();
            Lib_Arb_Arb_Theta1Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Theta1Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Theta1Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta1/*' />
        public static Arb jacobi_theta1(dynamic x, dynamic q)
        {
            return jacobi_theta1(aflint.t(x), aflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Arb jacobi_theta2(Arb x, Arb q)
        {
            var res = new Arb();
            Lib_Arb_Arb_Theta2Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Theta2Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Theta2Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta2/*' />
        public static Arb jacobi_theta2(dynamic x, dynamic q)
        {
            return jacobi_theta2(aflint.t(x), aflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Arb jacobi_theta3(Arb x, Arb q)
        {
            var res = new Arb();
            Lib_Arb_Arb_Theta3Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Theta3Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Theta3Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta3/*' />
        public static Arb jacobi_theta3(dynamic x, dynamic q)
        {
            return jacobi_theta3(aflint.t(x), aflint.t(q));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Arb jacobi_theta4(Arb x, Arb q)
        {
            var res = new Arb();
            Lib_Arb_Arb_Theta4Q(res.mpPtr, x.mpPtr, q.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Theta4Q", CallingConvention = CallingConvention.Cdecl)]
        internal static extern void Lib_Arb_Arb_Theta4Q(IntPtr res, IntPtr x, IntPtr q);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_theta4/*' />
        public static Arb jacobi_theta4(dynamic x, dynamic q)
        {
            return jacobi_theta4(aflint.t(x), aflint.t(q));
        }




        #endregion






        #region Lerch’s transcendent: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Arb lerch_phi(Arb z, Arb s, Arb a)
        {
            var res = new Arb();
            Lib_Arb_Arb_LerchPhi(res.mpPtr, z.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_LerchPhi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_LerchPhi(IntPtr res, IntPtr z, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_phi/*' />
        public static Arb lerch_phi(dynamic z, dynamic s, dynamic a)
        {
            return lerch_phi(aflint.t(z), aflint.t(s), aflint.t(a));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static ArbC lerch_zeta(Arb lambda1, Arb alpha, Arb s)
        {
            var res = aflintc.lerch_zeta(aflintc.t(lambda1), aflintc.t(alpha), aflintc.t(s));
            return res;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lerch_zeta/*' />
        public static ArbC lerch_zeta(dynamic lambda1, dynamic alpha, dynamic s)
        {
            return lerch_zeta(aflint.t(lambda1), aflint.t(alpha), aflint.t(s));
        }




        #endregion



        #region Polygamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Arb polygamma(Arb s, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_Polygamma(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Polygamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Polygamma(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polygamma/*' />
        public static Arb polygamma(dynamic s, dynamic z)
        {
            return polygamma(aflint.t(s), aflint.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Arb trigamma(Arb x)
        {
            return polygamma(1, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trigamma/*' />
        public static Arb trigamma(dynamic x)
        {
            return trigamma(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Arb digamma(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Digamma(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Digamma", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Digamma(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/digamma/*' />
        public static Arb digamma(dynamic x)
        {
            return digamma(aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Arb harmonic(Arb x)
        {
            ArbC res = aflintc.harmonic(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic/*' />
        public static Arb harmonic(dynamic x)
        {
            return harmonic(aflint.t(x));
        }



        #endregion



        #region Polylogarithms and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Arb polylog(Arb s, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_Polylog(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Polylog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Polylog(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/polylog/*' />
        public static Arb polylog(dynamic s, dynamic z)
        {
            return polylog(aflint.t(s), aflint.t(z));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Arb trilog(Arb x)
        {
            ArbC res = aflintc.trilog(x);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Arb trilog(dynamic x)
        {
            return trilog(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Arb dilog(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Dilog(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Dilog", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Dilog(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dilog/*' />
        public static Arb dilog(dynamic x)
        {
            return dilog(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Arb clausen_sin(Arb s, Arb z)
        {
            ArbC res = aflintc.clausen_sin(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_sin/*' />
        public static Arb clausen_sin(dynamic s, dynamic z)
        {
            return clausen_sin(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Arb clausen_cos(Arb s, Arb z)
        {
            ArbC res = aflintc.clausen_cos(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen_cos/*' />
        public static Arb clausen_cos(dynamic s, dynamic z)
        {
            return clausen_cos(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/clausen2/*' />
        public static Arb clausen2(Arb x)
        {
            return clausen_sin(aflint.t(2), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/trilog/*' />
        public static Arb clausen2(dynamic x)
        {
            return clausen_sin(aflint.t(2), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Arb bose_einstein(Arb s, Arb z)
        {
            ArbC res = aflintc.bose_einstein(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bose_einstein/*' />
        public static Arb bose_einstein(dynamic s, dynamic z)
        {
            return bose_einstein(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Arb fermi_dirac(Arb s, Arb z)
        {
            ArbC res = aflintc.fermi_dirac(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fermi_dirac/*' />
        public static Arb fermi_dirac(dynamic s, dynamic z)
        {
            return fermi_dirac(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Arb legendre_chi(Arb s, Arb z)
        {
            ArbC res = aflintc.legendre_chi(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_chi/*' />
        public static Arb legendre_chi(dynamic s, dynamic z)
        {
            return legendre_chi(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Arb inverse_tan_integral(Arb s, Arb z)
        {
            ArbC res = aflintc.inverse_tan_integral(s, z);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/inverse_tan_integral/*' />
        public static Arb inverse_tan_integral(dynamic s, dynamic z)
        {
            return inverse_tan_integral(aflint.t(s), aflint.t(z));
        }





        #endregion



        #region Hurwitz zeta function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Arb hurwitz_zeta(Arb s, Arb a)
        {
            var res = new Arb();
            Lib_Arb_Arb_HurwitzZeta(res.mpPtr, s.mpPtr, a.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_HurwitzZeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_HurwitzZeta(IntPtr res, IntPtr s, IntPtr a);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hurwitz_zeta/*' />
        public static Arb hurwitz_zeta(dynamic s, dynamic a)
        {
            return hurwitz_zeta(aflint.t(s), aflint.t(a));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Arb harmonic2(Arb z, Arb r)
        {
            ArbC res = aflintc.harmonic2(z, r);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/harmonic2/*' />
        public static Arb harmonic2(dynamic z, dynamic r)
        {
            return harmonic2(aflint.t(z), aflint.t(r));
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Arb bernoulli(Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_Bernoulli_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Bernoulli_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Bernoulli_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Arb bernpoly(Arb x, Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_BernoulliPoly_ui(res.mpPtr, x.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_BernoulliPoly_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_BernoulliPoly_ui(IntPtr res, IntPtr x, Int32 n);

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bernoulli/*' />
        public static Arb bernpoly(dynamic x, Int32 n)
        {
            return bernpoly(aflint.t(x), n);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulernum/*' />
        public static Arb eulernum(Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_Euler_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Euler_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Euler_ui(IntPtr res, Int32 n);





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Arb eulerpoly(Arb x, Int32 n)
        {
            ArbC res = aflintc.eulerpoly(x, n);
            return res.real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/eulerpoly/*' />
        public static Arb eulerpoly(dynamic x, Int32 n)
        {
            return eulerpoly(aflint.t(x), n);
        }






        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Arb barnes_g(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_BarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_BarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_BarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/barnes_g/*' />
        public static Arb barnes_g(dynamic x)
        {
            return barnes_g(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Arb logbarnes_g(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_LogBarnesG(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_LogBarnesG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_LogBarnesG(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/logbarnes_g/*' />
        public static Arb logbarnes_g(dynamic x)
        {
            return logbarnes_g(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Arb hyperfactorial(Arb x)
        {
            ArbC res = aflintc.hyperfactorial(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperfactorial/*' />
        public static Arb hyperfactorial(dynamic x)
        {
            return hyperfactorial(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Arb superfactorial(Arb x)
        {
            ArbC res = aflintc.superfactorial(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/superfactorial/*' />
        public static Arb superfactorial(dynamic x)
        {
            return superfactorial(aflint.t(x));
        }







        #endregion



        #region Riemann zeta function, and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Arb zeta(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Zeta(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Zeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Zeta(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zeta/*' />
        public static Arb zeta(dynamic x)
        {
            return zeta(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Arb zetam1(Arb x)
        {
            ArbC res = aflintc.zetam1(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/zetam1/*' />
        public static Arb zetam1(dynamic x)
        {
            return zetam1(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Arb hardy_theta(Arb x)
        {
            ArbC res = aflintc.hardy_theta(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_theta/*' />
        public static Arb hardy_theta(dynamic x)
        {
            return hardy_theta(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Arb hardy_z(Arb x)
        {
            ArbC res = aflintc.hardy_z(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hardy_z/*' />
        public static Arb hardy_z(dynamic x)
        {
            return hardy_z(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Arb riemann_xi(Arb x)
        {
            ArbC res = aflintc.riemann_xi(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/riemann_xi/*' />
        public static Arb riemann_xi(dynamic x)
        {
            return riemann_xi(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Arb dirichlet_eta(Arb x)
        {
            ArbC res = aflintc.dirichlet_eta(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_eta/*' />
        public static Arb dirichlet_eta(dynamic x)
        {
            return dirichlet_eta(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Arb dirichlet_etam1(Arb x)
        {
            ArbC res = aflintc.dirichlet_etam1(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_etam1/*' />
        public static Arb dirichlet_etam1(dynamic x)
        {
            return dirichlet_etam1(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Arb dirichlet_beta(Arb x)
        {
            ArbC res = aflintc.dirichlet_beta(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_beta/*' />
        public static Arb dirichlet_beta(dynamic x)
        {
            return dirichlet_beta(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Arb dirichlet_lambda(Arb x)
        {
            ArbC res = aflintc.dirichlet_lambda(aflintc.t(x));
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dirichlet_lambda/*' />
        public static Arb dirichlet_lambda(dynamic x)
        {
            return dirichlet_lambda(aflint.t(x));
        }






        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Arb backlund_s(Arb x)
        //{
        //    var res = new Arb();
        //    Lib_Arb_Arb_BacklundS(res.mpPtr, x.mpPtr);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_BacklundS", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Arb_Arb_BacklundS(IntPtr res, IntPtr x);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/backlund_s/*' />
        //public static Arb backlund_s(dynamic x)
        //{
        //    return zeta(aflint.t(x));
        //}





        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/grampoint/*' />
        //public static Arb grampoint(Int32 n)
        //{
        //    var res = new Arb();
        //    Lib_Arb_Arb_GramPoint_ui(res.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_GramPoint_ui", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Arb_Arb_GramPoint_ui(IntPtr res, Int32 n);







        #endregion



        #region Additional numbertheoretic functions



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bell/*' />
        public static Arb bell(Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_Bell_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Bell_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Bell_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/partitions/*' />
        public static Arb partitions(Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_Partitions_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Partitions_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Partitions_ui(IntPtr res, Int32 n);



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/primorial/*' />
        public static Arb primorial(Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_Primorial_ui(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Primorial_ui", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Primorial_ui(IntPtr res, Int32 n);





        #endregion








        #region 0F1: Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Arb hyperg_0f1(Arb a, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Hypgeom0F1(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Hypgeom0F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Hypgeom0F1(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1/*' />
        public static Arb hyperg_0f1(dynamic a, dynamic x)
        {
            return hyperg_0f1(aflint.t(a), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Arb hyperg_0f1r(Arb a, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Hypgeom0F1r(res.mpPtr, a.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Hypgeom0F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Hypgeom0F1r(IntPtr res, IntPtr a, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_0f1r/*' />
        public static Arb hyperg_0f1r(dynamic a, dynamic x)
        {
            return hyperg_0f1r(aflint.t(a), aflint.t(x));
        }




        #endregion



        #region 0F1: Bessel functions and modified Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Arb bessel_jv(Arb nu, Arb x, bool scaled = false)
        {
            var res = new Arb();
            Lib_Arb_Arb_BesselJ(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_BesselJ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_BesselJ(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv/*' />
        public static Arb bessel_jv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv(aflint.t(nu), aflint.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Arb bessel_yv(Arb nu, Arb x, bool scaled = false)
        {
            var res = new Arb();
            Lib_Arb_Arb_BesselY(res.mpPtr, nu.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_BesselY", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_BesselY(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv/*' />
        public static Arb bessel_yv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv(aflint.t(nu), aflint.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Arb bessel_iv(Arb nu, Arb x, bool scaled = false)
        {
            var res = new Arb();
            Lib_Arb_Arb_BesselI(res.mpPtr, nu.mpPtr, x.mpPtr);
            if (scaled) res *= exp(-abs(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_BesselI", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_BesselI(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv/*' />
        public static Arb bessel_iv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv(aflint.t(nu), aflint.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Arb bessel_kv(Arb nu, Arb x, bool scaled = false)
        {
            var res = new Arb();
            Lib_Arb_Arb_BesselK(res.mpPtr, nu.mpPtr, x.mpPtr);
            if (scaled) res *= exp(x);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_BesselK", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_BesselK(IntPtr res, IntPtr nu, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv/*' />
        public static Arb bessel_kv(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv(aflint.t(nu), aflint.t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Arb bessel_jv_prime(Arb nu, Arb x, bool scaled = false)
        {
            return (bessel_jv(nu - 1, x) - bessel_jv(nu + 1, x)) / 2;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_jv_prime/*' />
        public static Arb bessel_jv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_jv_prime(aflint.t(nu), aflint.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Arb bessel_yv_prime(Arb nu, Arb x, bool scaled = false)
        {
            return (bessel_yv(nu - 1, x) - bessel_yv(nu + 1, x)) / 2;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_yv_prime/*' />
        public static Arb bessel_yv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_yv_prime(aflint.t(nu), aflint.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Arb bessel_iv_prime(Arb nu, Arb x, bool scaled = false)
        {
            var res = (bessel_iv(nu - 1, x) + bessel_iv(nu + 1, x)) / 2;
            if (scaled) res *= exp(-abs(x));
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_iv_prime/*' />
        public static Arb bessel_iv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_iv_prime(aflint.t(nu), aflint.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Arb bessel_kv_prime(Arb nu, Arb x, bool scaled = false)
        {
            var res = -(bessel_kv(nu - 1, x) + bessel_kv(nu + 1, x)) / 2;
            if (scaled) res *= exp(x);
            return res;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/bessel_kv_prime/*' />
        public static Arb bessel_kv_prime(dynamic nu, dynamic x, bool scaled = false)
        {
            return bessel_kv_prime(aflint.t(nu), aflint.t(x), scaled);
        }




        #endregion



        #region 0F1: Spherical Bessel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Arb sph_bessel_jn(Arb n, Arb x, bool scaled = false)
        {
            if (!aflint.isinteger(n)) return aflint.nan();

            if (aflint.isnan(x)) return aflint.nan();
            if (aflint.isinf(x)) return aflint.zero();
            if (aflint.isneginf(x)) return aflint.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return aflint.one();
                    else return aflint.zero();
                }
                else
                {
                    if (aflint.lrint(n) % 2 == 0) return aflint.neginf(); else return aflint.nan();
                }
            }

            return aflintc.sph_bessel_jn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_jn/*' />
        public static Arb sph_bessel_jn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Arb sph_bessel_yn(Arb n, Arb x, bool scaled = false)
        {
            if (!aflint.isinteger(n)) return aflint.nan();

            if (aflint.isnan(x)) return aflint.nan();
            if (aflint.isinf(x)) return aflint.zero();
            if (aflint.isneginf(x)) return aflint.zero();
            if (x == 0.0)
            {
                if (n < 0)
                {
                    if ((n == -1)) return aflint.one();
                    else return aflint.zero();
                }
                else
                {
                    if (aflint.lrint(n) % 2 != 0) return aflint.neginf(); else return aflint.nan();
                }
            }

            return aflintc.sph_bessel_yn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_yn/*' />
        public static Arb sph_bessel_yn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Arb sph_bessel_in(Arb n, Arb x, bool scaled = false)
        {
            if (!aflint.isinteger(n)) return aflint.nan();

            if (aflint.isnan(x)) return aflint.nan();
            if (aflint.isinf(x)) return aflint.inf();
            if (aflint.isneginf(x)) return aflint.zero();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if ((n == 0)) return aflint.one();
                    else return aflint.zero();
                }
                else
                {
                    if (aflint.lrint(n) % 2 == 0) return aflint.neginf(); else return aflint.nan();
                }
            }
            return aflintc.sph_bessel_in(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_in/*' />
        public static Arb sph_bessel_in(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Arb sph_bessel_kn(Arb n, Arb x, bool scaled = false)
        {
            if (!aflint.isinteger(n)) return aflint.nan();

            if (aflint.isnan(x)) return aflint.nan();
            if (aflint.isinf(x)) return aflint.zero();
            if (aflint.isneginf(x)) return aflint.neginf();
            if (x == 0.0)
            {
                if (n >= 0)
                {
                    if (lrint(n) % 2 == 0) return aflint.nan(); else return aflint.inf();
                }
                else
                {
                    if (lrint(n) % 2 == 0) return aflint.inf(); else return aflint.nan();
                }
            }
            return aflintc.sph_bessel_kn(n, x, scaled).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sph_bessel_kn/*' />
        public static Arb sph_bessel_kn(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/besselpoly/*' />
        public static Arb besselpoly(Arb n, Arb x, bool scaled = false)
        {
            if (!isinteger(n)) return nan();
            if (x == 0.0) return t(1.0);
            Arb res = sph_bessel_kn(n, 1 / x);
            res *= exp(1 / x) * 2 / (pi() * x);
            return res;

        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/besselpoly/*' />
        public static Arb besselpoly(dynamic n, dynamic x, bool scaled = false)
        {
            return besselpoly(t(n), t(x), scaled);
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/besseltheta/*' />
        public static Arb besseltheta(Arb n, Arb x, bool scaled = false)
        {
            var res = aflintc.besseltheta(aflintc.t(n), aflintc.t(x), scaled);
            return res.real;
        }


        /// <include file="docs.xml" path='docs/members[@name="Boost"]/besseltheta/*' />
        public static Arb besseltheta(dynamic n, dynamic x, bool scaled = false)
        {
            return besseltheta(t(n), t(x), scaled);
        }





        #endregion





        #region Spherical Bessel functions, first derivative




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Arb sph_bessel_jn_prime(Arb n, Arb x, bool scaled = false)
        {
            if (!aflint.isinteger(n)) return aflint.nan();

            if (aflint.isnan(x)) return aflint.nan();
            if (aflint.isinf(x)) return aflint.zero();
            if (aflint.isneginf(x)) return aflint.zero();
            if (x == 0.0)
            {
                if (n == 1) return 1 / aflint.t(3);
                if (n >= 0) return aflint.zero();
                else
                {
                    if (aflint.lrint(n) % 2 != 0) return aflint.neginf(); else return aflint.nan();
                }
            }
            return (n * sph_bessel_jn(n - 1, x, scaled) - (n + 1) * sph_bessel_jn(n + 1, x, scaled)) / (2 * n + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_jn_prime/*' />
        public static Arb sph_bessel_jn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_jn_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Arb sph_bessel_yn_prime(Arb n, Arb x, bool scaled = false)
        {
            if (!aflint.isinteger(n)) return aflint.nan();

            if (aflint.isnan(x)) return aflint.nan();
            if (aflint.isinf(x)) return aflint.zero();
            if (aflint.isneginf(x)) return aflint.zero();
            if (x == 0.0)
            {
                if (n == -2) return -1 / aflint.t(3);
                if (n < 0) return aflint.zero();
                else
                {
                    if (lrint(n) % 2 == 0) return aflint.inf(); else return aflint.nan();
                }
            }
            return (n * sph_bessel_yn(n - 1, x, scaled) - (n + 1) * sph_bessel_yn(n + 1, x, scaled)) / (2 * n + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_yn_prime/*' />
        public static Arb sph_bessel_yn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_yn_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Arb sph_bessel_in_prime(Arb n, Arb x, bool scaled = false)
        {
            if (!aflint.isinteger(n)) return aflint.nan();

            if (aflint.isnan(x)) return aflint.nan();
            if (aflint.isinf(x)) return aflint.inf();
            if (aflint.isneginf(x))
            {
                if (aflint.lrint(n) % 2 == 0) return aflint.neginf(); else return aflint.inf();
            }
            if (x == 0.0)
            {
                if (n == 0) return aflint.zero();
                if (n < 0)
                {
                    if (aflint.lrint(n) % 2 != 0) return aflint.neginf(); else return aflint.nan();
                }
            }
            return (n * sph_bessel_in(n - 1, x, scaled) + (n + 1) * sph_bessel_in(n + 1, x, scaled)) / (2 * n + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_in_prime/*' />
        public static Arb sph_bessel_in_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_in_prime(t(n), t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Arb sph_bessel_kn_prime(Arb n, Arb x, bool scaled = false)
        {
            if (!aflint.isinteger(n)) return aflint.nan();

            if (aflint.isnan(x)) return aflint.nan();
            if (aflint.isinf(x)) return aflint.zero();
            if (aflint.isneginf(x)) return aflint.neginf();
            if (x == 0.0)
            {
                if (((n >= 0) && (aflint.lrint(n) % 2 == 0)) || ((n < 0) && (aflint.lrint(n) % 2 != 0))) return aflint.neginf();
                else return aflint.nan();
            }
            return -(n * sph_bessel_kn(n - 1, x, scaled) + (n + 1) * sph_bessel_kn(n + 1, x, scaled)) / (2 * n + 1);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_bessel_kn_prime/*' />
        public static Arb sph_bessel_kn_prime(dynamic n, dynamic x, bool scaled = false)
        {
            return sph_bessel_kn_prime(t(n), t(x), scaled);
        }





        #endregion







        #region Hankel functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static ArbC hankel_h1(Arb v, Arb x)
        {
            return bessel_jv(v, x) + aflintc.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h1/*' />
        public static ArbC hankel_h1(dynamic v, dynamic x)
        {
            return hankel_h1(aflint.t(v), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static ArbC hankel_h2(Arb v, Arb x)
        {
            return bessel_jv(v, x) - aflintc.onej() * bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/hankel_h2/*' />
        public static ArbC hankel_h2(dynamic v, dynamic x)
        {
            return hankel_h2(aflint.t(v), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static ArbC sph_hankel_h1(int n, Arb x)
        {
            return sph_bessel_jn(n, x) + aflintc.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h1/*' />
        public static ArbC sph_hankel_h1(int n, dynamic x)
        {
            return sph_hankel_h1(n, aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static ArbC sph_hankel_h2(int n, Arb x)
        {
            return sph_bessel_jn(n, x) - aflintc.onej() * sph_bessel_yn(n, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/sph_hankel_h2/*' />
        public static ArbC sph_hankel_h2(int n, dynamic x)
        {
            return sph_hankel_h2(n, aflint.t(x));
        }






        #endregion




        #region 0F1: Airy functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Arb airy_ai(Arb x, bool scaled = false)
        {
            var res = new Arb();
            Lib_Arb_Arb_AiryAi(res.mpPtr, x.mpPtr);
            if ((scaled) && (x > 0)) res *= exp((aflint.t(2) / aflint.t(3)) * x * sqrt(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_AiryAi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_AiryAi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai/*' />
        public static Arb airy_ai(dynamic x, bool scaled = false)
        {
            return airy_ai(aflint.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Arb airy_ai_prime(Arb x, bool scaled = false)
        {
            var res = new Arb();
            Lib_Arb_Arb_AiryAiPrime(res.mpPtr, x.mpPtr);
            if ((scaled) && (x > 0)) res *= exp((aflint.t(2) / aflint.t(3)) * x * sqrt(x));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_AiryAiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_AiryAiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime/*' />
        public static Arb airy_ai_prime(dynamic x, bool scaled = false)
        {
            return airy_ai_prime(aflint.t(x), scaled);
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Arb airy_bi(Arb x, bool scaled = false)
        {
            var res = new Arb();
            Lib_Arb_Arb_AiryBi(res.mpPtr, x.mpPtr);
            if ((scaled) && (x > 0)) res *= exp(-abs(aflint.t(2) / aflint.t(3) * (x * sqrt(x))));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_AiryBi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_AiryBi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi/*' />
        public static Arb airy_bi(dynamic x, bool scaled = false)
        {
            return airy_bi(aflint.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Arb airy_bi_prime(Arb x, bool scaled = false)
        {
            var res = new Arb();
            Lib_Arb_Arb_AiryBiPrime(res.mpPtr, x.mpPtr);
            if ((scaled) && (x > 0)) res *= exp(-abs(aflint.t(2) / aflint.t(3) * (x * sqrt(x))));
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_AiryBiPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_AiryBiPrime(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime/*' />
        public static Arb airy_bi_prime(dynamic x, bool scaled = false)
        {
            return airy_bi_prime(aflint.t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_zero/*' />
        public static Arb airy_ai_zero(Int32 n)
        {
            var res = new Arb();
            Lib_Arb_Arb_AiryAiZero(res.mpPtr, n);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_AiryAiZero", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_AiryAiZero(IntPtr res, Int32 n);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_ai_prime_zero/*' />
        //public static Arb airy_ai_prime_zero(Int32 n)
        //{
        //    var res = new Arb();
        //    Lib_Arb_Arb_AiryAiPrimeZero(res.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_AiryAiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Arb_Arb_AiryAiPrimeZero(IntPtr res, Int32 n);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_zero/*' />
        //public static Arb airy_bi_zero(Int32 n)
        //{
        //    var res = new Arb();
        //    Lib_Arb_Arb_AiryBiZero(res.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_AiryBiZero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Arb_Arb_AiryBiZero(IntPtr res, Int32 n);


        ///// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_bi_prime_zero/*' />
        //public static Arb airy_bi_prime_zero(Int32 n)
        //{
        //    var res = new Arb();
        //    Lib_Arb_Arb_AiryBiPrimeZero(res.mpPtr, n);
        //    return res;
        //}
        //[DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_AiryBiPrimeZero", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Arb_Arb_AiryBiPrimeZero(IntPtr res, Int32 n);



        #endregion



        #region 0F1: Kelvin functions



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Arb kelvin_ber(Arb v, Arb x, bool scaled = false)
        {
            return aflintc.kelvin_ber(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber/*' />
        public static Arb kelvin_ber(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Arb kelvin_bei(Arb v, Arb x, bool scaled = false)
        {
            return aflintc.kelvin_bei(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei/*' />
        public static Arb kelvin_bei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Arb kelvin_ker(Arb v, Arb x, bool scaled = false)
        {
            return aflintc.kelvin_ker(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker/*' />
        public static Arb kelvin_ker(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Arb kelvin_kei(Arb v, Arb x, bool scaled = false)
        {
            return aflintc.kelvin_kei(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei/*' />
        public static Arb kelvin_kei(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei(t(v), t(x), scaled);
        }





        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Arb kelvin_ber_prime(Arb v, Arb x, bool scaled = false)
        {
            return aflintc.kelvin_ber_prime(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ber_prime/*' />
        public static Arb kelvin_ber_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ber_prime(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Arb kelvin_bei_prime(Arb v, Arb x, bool scaled = false)
        {
            return aflintc.kelvin_bei_prime(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_bei_prime/*' />
        public static Arb kelvin_bei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_bei_prime(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Arb kelvin_ker_prime(Arb v, Arb x, bool scaled = false)
        {
            return aflintc.kelvin_ker_prime(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_ker_prime/*' />
        public static Arb kelvin_ker_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_ker_prime(t(v), t(x), scaled);
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Arb kelvin_kei_prime(Arb v, Arb x, bool scaled = false)
        {
            return aflintc.kelvin_kei_prime(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/kelvin_kei_prime/*' />
        public static Arb kelvin_kei_prime(dynamic v, dynamic x, bool scaled = false)
        {
            return kelvin_kei_prime(t(v), t(x), scaled);
        }






        #endregion








        #region 1F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Arb hyperg_1f1(Arb a, Arb b, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Hypgeom1F1(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Hypgeom1F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Hypgeom1F1(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1/*' />
        public static Arb hyperg_1f1(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1(aflint.t(a), aflint.t(b), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Arb hyperg_1f1r(Arb a, Arb b, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Hypgeom1F1r(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Hypgeom1F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Hypgeom1F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f1r/*' />
        public static Arb hyperg_1f1r(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_1f1r(aflint.t(a), aflint.t(b), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Arb hyperg_u(Arb a, Arb b, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_HypgeomU(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_HypgeomU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_HypgeomU(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_u/*' />
        public static Arb hyperg_u(dynamic a, dynamic b, dynamic x)
        {
            return hyperg_u(aflint.t(a), aflint.t(b), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Arb hermite_h(Arb n, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_HermiteH(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_HermiteH", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_HermiteH(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_h/*' />
        public static Arb hermite_h(dynamic n, dynamic x)
        {
            return hermite_h(aflint.t(n), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Arb hermite_he(Arb n, Arb x)
        {
            return exp2(-n / 2) * hermite_h(n, x / sqrt(2));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hermite_he/*' />
        public static Arb hermite_he(dynamic n, dynamic x)
        {
            return hermite_he(aflint.t(n), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Arb laguerre_l(Arb n, Arb m, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_LaguerreL(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_LaguerreL", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_LaguerreL(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/laguerre_l/*' />
        public static Arb laguerre_l(dynamic n, dynamic m, dynamic x)
        {
            return laguerre_l(aflint.t(n), aflint.t(m), aflint.t(x));
        }




        #endregion





        #region 1F1: Incomplete gamma functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Arb gamma_upper(Arb s, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_GammaUpper(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_GammaUpper", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_GammaUpper(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_upper/*' />
        public static Arb gamma_upper(dynamic s, dynamic z)
        {
            return gamma_upper(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Arb gamma_q(Arb s, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_GammaQ(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_GammaQ", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_GammaQ(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_q/*' />
        public static Arb gamma_q(dynamic s, dynamic z)
        {
            return gamma_q(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Arb gamma_lower(Arb s, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_GammaLower(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_GammaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_GammaLower(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_lower/*' />
        public static Arb gamma_lower(dynamic s, dynamic z)
        {
            return gamma_lower(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Arb gamma_p(Arb s, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_GammaP(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_GammaP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_GammaP(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p/*' />
        public static Arb gamma_p(dynamic s, dynamic z)
        {
            return gamma_p(aflint.t(s), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Arb gamma_p_prime(Arb s, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_GammaPPrime(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_GammaPPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_GammaPPrime(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gamma_p_prime/*' />
        public static Arb gamma_p_prime(dynamic s, dynamic z)
        {
            return gamma_p_prime(aflint.t(s), aflint.t(z));
        }



        #endregion




        #region 1F1: Coulomb, Whittaker and parabolic cylinder functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Arb coulomb_f(Arb l, Arb eta, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_CoulombF(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_CoulombF", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_CoulombF(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_f/*' />
        public static Arb coulomb_f(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_f(aflint.t(l), aflint.t(eta), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Arb coulomb_g(Arb l, Arb eta, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_CoulombG(res.mpPtr, l.mpPtr, eta.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_CoulombG", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_CoulombG(IntPtr res, IntPtr l, IntPtr eta, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/coulomb_g/*' />
        public static Arb coulomb_g(dynamic l, dynamic eta, dynamic x)
        {
            return coulomb_g(aflint.t(l), aflint.t(eta), aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/whittaker_m/*' />
        public static Arb whittaker_m(Arb k, Arb m, Arb x)
        {
            return exp(-0.5 * x) * pow(x, 0.5 + m) * hyperg_1f1(0.5 + m - k, 1 + 2 * m, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/whittaker_m/*' />
        public static Arb whittaker_m(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_m(aflint.t(k), aflint.t(m), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/whittaker_w/*' />
        public static Arb whittaker_w(Arb k, Arb m, Arb x)
        {
            return exp(-0.5 * x) * pow(x, 0.5 + m) * hyperg_u(0.5 + m - k, 1 + 2 * m, x);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/whittaker_w/*' />
        public static Arb whittaker_w(dynamic k, dynamic m, dynamic x)
        {
            return whittaker_w(aflint.t(k), aflint.t(m), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfd/*' />
        public static Arb pcfd(Arb n, Arb z)
        {
            return aflintc.pcfd(aflintc.t(n), aflintc.t(z)).real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfd/*' />
        public static Arb pcfd(dynamic n, dynamic z)
        {
            return pcfd(aflint.t(n), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfu/*' />
        public static Arb pcfu(Arb a, Arb z)
        {
            return aflintc.pcfu(aflintc.t(a), aflintc.t(z)).real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfu/*' />
        public static Arb pcfu(dynamic a, dynamic z)
        {
            return pcfu(aflint.t(a), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfv/*' />
        public static Arb pcfv(Arb a, Arb z)
        {
            return aflintc.pcfv(aflintc.t(a), aflintc.t(z)).real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfv/*' />
        public static Arb pcfv(dynamic a, dynamic z)
        {
            return pcfv(aflint.t(a), aflint.t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfw/*' />
        public static Arb pcfw(Arb a, Arb z)
        {
            return aflintc.pcfw(aflintc.t(a), aflintc.t(z)).real;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/pcfw/*' />
        public static Arb pcfw(dynamic a, dynamic z)
        {
            return pcfw(aflint.t(a), aflint.t(z));
        }




        #endregion







        #region 1F1: Error function and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Arb erf(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Erf(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Erf", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Erf(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf/*' />
        public static Arb erf(dynamic x)
        {
            return erf(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Arb erfc(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Erfc(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Erfc", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Erfc(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc/*' />
        public static Arb erfc(dynamic x)
        {
            return erfc(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Arb erf_inv(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Erfinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Erfinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Erfinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erf_inv/*' />
        public static Arb erf_inv(dynamic x)
        {
            return erf_inv(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Arb erfc_inv(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Erfcinv(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Erfcinv", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Erfcinv(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfc_inv/*' />
        public static Arb erfc_inv(dynamic x)
        {
            return erfc_inv(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Arb erfi(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Erfi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Erfi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Erfi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/erfi/*' />
        public static Arb erfi(dynamic x)
        {
            return erfi(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Arb dawson(Arb x)
        {
            return erfi(x) * exp(-x * x) * aflint.sqrt(aflint.pi()) / 2;
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/dawson/*' />
        public static Arb dawson(dynamic x)
        {
            return dawson(aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Arb fresnel_s(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_FresnelS(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_FresnelS", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_FresnelS(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_s/*' />
        public static Arb fresnel_s(dynamic x)
        {
            return fresnel_s(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Arb fresnel_c(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_FresnelC(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_FresnelC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_FresnelC(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/fresnel_c/*' />
        public static Arb fresnel_c(dynamic x)
        {
            return fresnel_c(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Arb ndens(Arb x)
        {
            var res = new Arb();
            if (aflint.isfinite(x))
            {
                Lib_Arb_Arb_Ndens(res.mpPtr, x.mpPtr);
            }
            else if (aflint.isposinf(x)) res = aflint.zero();
            else if (aflint.isneginf(x)) res = aflint.zero();
            else if (aflint.isnan(x)) res = aflint.nan();
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Ndens", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Ndens(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndens/*' />
        public static Arb ndens(dynamic x)
        {
            return ndens(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Arb ndis(Arb x)
        {
            var res = new Arb();
            if (aflint.isfinite(x))
            {
                Lib_Arb_Arb_Ndis(res.mpPtr, x.mpPtr);
            }
            else if (aflint.isposinf(x)) res = aflint.one();
            else if (aflint.isneginf(x)) res = aflint.zero();
            else if (aflint.isnan(x)) res = aflint.nan();
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Ndis", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Ndis(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ndis/*' />
        public static Arb ndis(dynamic x)
        {
            return ndis(aflint.t(x));
        }




        #endregion



        #region 1F1: Exponential integrals and related functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Arb exp_integral_en(Arb s, Arb z)
        {
            var res = new Arb();
            Lib_Arb_Arb_ExpIntegralE(res.mpPtr, s.mpPtr, z.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_ExpIntegralE", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_ExpIntegralE(IntPtr res, IntPtr s, IntPtr z);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_en/*' />
        public static Arb exp_integral_en(dynamic s, dynamic z)
        {
            return exp_integral_en(aflint.t(s), aflint.t(z));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Arb exp_integral_e1(Arb z)
        {
            if (z < 0) return -exp_integral_ei(-z);
            else return exp_integral_en(t(1), z);
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_e1/*' />
        public static Arb exp_integral_e1(dynamic z)
        {
            return exp_integral_e1(t(z));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Arb exp_integral_ei(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_ExpIntegralEi(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_ExpIntegralEi", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_ExpIntegralEi(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/exp_integral_ei/*' />
        public static Arb exp_integral_ei(dynamic x)
        {
            return exp_integral_ei(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Arb sin_integral(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_SinIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_SinIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_SinIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sin_integral/*' />
        public static Arb sin_integral(dynamic x)
        {
            return sin_integral(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Arb cos_integral(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_CosIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_CosIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_CosIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cos_integral/*' />
        public static Arb cos_integral(dynamic x)
        {
            return cos_integral(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Arb sinh_integral(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_SinhIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_SinhIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_SinhIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/sinh_integral/*' />
        public static Arb sinh_integral(dynamic x)
        {
            return sinh_integral(aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Arb cosh_integral(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_CoshIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_CoshIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_CoshIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/cosh_integral/*' />
        public static Arb cosh_integral(dynamic x)
        {
            return cosh_integral(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Arb log_integral(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_LogIntegral(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_LogIntegral", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_LogIntegral(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral/*' />
        public static Arb log_integral(dynamic x)
        {
            return log_integral(aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Arb log_integral_offset(Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_LogIntegralOffset(res.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_LogIntegralOffset", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_LogIntegralOffset(IntPtr res, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/log_integral_offset/*' />
        public static Arb log_integral_offset(dynamic x)
        {
            return log_integral_offset(aflint.t(x));
        }



        #endregion







        #region 2F1 Overview


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Arb hyperg_2f1(Arb a, Arb b, Arb c, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Hypgeom2F1(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Hypgeom2F1", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Hypgeom2F1(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1/*' />
        public static Arb hyperg_2f1(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1(aflint.t(a), aflint.t(b), aflint.t(c), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Arb hyperg_2f1r(Arb a, Arb b, Arb c, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Hypgeom2F1r(res.mpPtr, a.mpPtr, b.mpPtr, c.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Hypgeom2F1r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Hypgeom2F1r(IntPtr res, IntPtr a, IntPtr b, IntPtr c, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_2f1r/*' />
        public static Arb hyperg_2f1r(dynamic a, dynamic b, dynamic c, dynamic x)
        {
            return hyperg_2f1r(aflint.t(a), aflint.t(b), aflint.t(c), aflint.t(x));
        }




        #endregion



        #region 2F1-related orthogonal polynomials


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Arb chebyshev_t(Arb n, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_ChebyshevT(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_ChebyshevT", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_ChebyshevT(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_t/*' />
        public static Arb chebyshev_t(dynamic n, dynamic x)
        {
            return chebyshev_t(aflint.t(n), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Arb chebyshev_u(Arb n, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_ChebyshevU(res.mpPtr, n.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_ChebyshevU", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_ChebyshevU(IntPtr res, IntPtr n, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/chebyshev_u/*' />
        public static Arb chebyshev_u(dynamic n, dynamic x)
        {
            return chebyshev_u(aflint.t(n), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_v/*' />
        public static Arb chebyshev_v(Arb n, Arb x)  // same as t_n(x)
        {
            if (!aflint.isinteger(n)) return aflint.nan();
            if (aflint.isnan(x)) return aflint.nan();
            if (x < 0.0)
            {
                int m = -1; if (lrint(n) % 2 == 0) m = 1; // m = exp(i * n * pi)
                return m * chebyshev_w(n, -x);
            }
            else return sqrt(2 / (1 + x)) * chebyshev_t(aflint.t(2 * n + 1), sqrt((x + 1) / 2));
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_u/*' />
        public static Arb chebyshev_v(dynamic n, dynamic y)
        {
            return chebyshev_v(aflint.t(n), aflint.t(y));
        }



        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Arb chebyshev_w(Arb n, Arb x)  // same as u_n(x)
        {
            if (!aflint.isinteger(n)) return aflint.nan();
            if (aflint.isnan(x)) return aflint.nan();
            if (x < 0.0)
            {
                int m = -1; if (lrint(n) % 2 == 0) m = 1; // m = exp(i * n * pi)
                return m * chebyshev_v(n, -x);
            }
            else return chebyshev_u(aflint.t(2 * n), sqrt((x + 1) / 2));
        }

        /// <include file="docs.xml" path='docs/members[@name="Boost"]/chebyshev_w/*' />
        public static Arb chebyshev_w(dynamic n, dynamic y)
        {
            return chebyshev_w(aflint.t(n), aflint.t(y));
        }







        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Arb gegenbauer_c(Arb n, Arb m, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_GegenbauerC(res.mpPtr, n.mpPtr, m.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_GegenbauerC", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_GegenbauerC(IntPtr res, IntPtr n, IntPtr m, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/gegenbauer_c/*' />
        public static Arb gegenbauer_c(dynamic n, dynamic m, dynamic x)
        {
            return gegenbauer_c(aflint.t(n), aflint.t(m), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Arb jacobi_p(Arb n, Arb a, Arb b, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_JacobiP(res.mpPtr, n.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_JacobiP", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_JacobiP(IntPtr res, IntPtr n, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/jacobi_p/*' />
        public static Arb jacobi_p(dynamic n, dynamic a, dynamic b, dynamic x)
        {
            return jacobi_p(aflint.t(n), aflint.t(a), aflint.t(b), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Arb legendre_plm(Arb n, Arb m, Arb x)
        {
            return aflintc.legendre_plm(n, m, x, 1).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_plm/*' />
        public static Arb legendre_plm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_plm(aflint.t(n), aflint.t(m), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Arb legendre_p(Arb n, Arb x)
        {
            return legendre_plm(n, aflint.t(0), x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_p/*' />
        public static Arb legendre_p(dynamic n, dynamic x)
        {
            return legendre_p(aflint.t(n), aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Arb legendre_qlm(Arb n, Arb m, Arb x)
        {
            return aflintc.legendre_qlm(n, m, x, 1).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_qlm/*' />
        public static Arb legendre_qlm(dynamic n, dynamic m, dynamic x)
        {
            return legendre_qlm(aflint.t(n), aflint.t(m), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Arb legendre_q(Arb n, Arb x)
        {
            return legendre_qlm(n, aflint.t(0), x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/legendre_q/*' />
        public static Arb legendre_q(dynamic n, dynamic x)
        {
            return legendre_q(aflint.t(n), aflint.t(x));
        }




        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_plm/*' />
        public static Arb toroidal_plm(Arb l, Arb m, Arb x)
        {
            Arb nu = l - aflint.t(0.5);
            if (x < 1) return aflint.nan();
            if (x == 1) return hyperg_2f1r(nu + 1, -nu, 1 - m, (1 - x) / 2);
            return aflintc.legendre_plm(aflint.t(l - 0.5), aflint.t(m), aflint.t(x), 3).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_plm/*' />
        public static Arb toroidal_plm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_plm(aflint.t(l), aflint.t(m), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_qlm/*' />
        public static Arb toroidal_qlm(Arb l, Arb m, Arb x)
        {
            return aflintc.legendre_qlm(aflint.t(l - 0.5), aflint.t(m), aflint.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/toroidal_qlm/*' />
        public static Arb toroidal_qlm(dynamic l, dynamic m, dynamic x)
        {
            return toroidal_qlm(aflint.t(l), aflint.t(m), aflint.t(x));
        }





        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static ArbC spherical_y(Arb n, Arb m, Arb theta, Arb phi)
        {
            return aflintc.spherical_y(aflintc.t(n), aflintc.t(m), aflintc.t(theta), aflintc.t(phi));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/spherical_y/*' />
        public static ArbC spherical_y(dynamic n, dynamic m, dynamic theta, dynamic phi)
        {
            return spherical_y(aflint.t(n), aflint.t(m), aflint.t(theta), aflint.t(phi));
        }





        #endregion



        #region 2F1-Incomplete beta Function


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Arb beta_lower(Arb a, Arb b, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_BetaLower(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_BetaLower", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_BetaLower(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/beta_lower/*' />
        public static Arb beta_lower(dynamic a, dynamic b, dynamic x)
        {
            return beta_lower(aflint.t(a), aflint.t(b), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Arb ibeta(Arb a, Arb b, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Ibeta(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Ibeta", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Ibeta(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta/*' />
        public static Arb ibeta(dynamic a, dynamic b, dynamic x)
        {
            return ibeta(aflint.t(a), aflint.t(b), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Arb ibetac(Arb a, Arb b, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Ibetac(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Ibetac", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Ibetac(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibetac/*' />
        public static Arb ibetac(dynamic a, dynamic b, dynamic x)
        {
            return ibetac(aflint.t(a), aflint.t(b), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Arb ibeta_prime(Arb a, Arb b, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_IbetaPrime(res.mpPtr, a.mpPtr, b.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_IbetaPrime", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_IbetaPrime(IntPtr res, IntPtr a, IntPtr b, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/ibeta_prime/*' />
        public static Arb ibeta_prime(dynamic a, dynamic b, dynamic x)
        {
            return ibeta_prime(aflint.t(a), aflint.t(b), aflint.t(x));
        }


        #endregion



        #region Hypergeometric Function 1F2, overview



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Arb hyperg_1f2(Arb a1, Arb b1, Arb b2, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Hypgeom1F2(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Hypgeom1F2", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Hypgeom1F2(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2/*' />
        public static Arb hyperg_1f2(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2(aflint.t(a1), aflint.t(b1), aflint.t(b2), aflint.t(x));
        }



        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Arb hyperg_1f2r(Arb a1, Arb b1, Arb b2, Arb x)
        {
            var res = new Arb();
            Lib_Arb_Arb_Hypgeom1F2r(res.mpPtr, a1.mpPtr, b1.mpPtr, b2.mpPtr, x.mpPtr);
            return res;
        }
        [DllImport(ArbPrec.mpNum, EntryPoint = "Lib_Arb_Arb_Hypgeom1F2r", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int Lib_Arb_Arb_Hypgeom1F2r(IntPtr res, IntPtr a1, IntPtr b1, IntPtr b2, IntPtr x);


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/hyperg_1f2r/*' />
        public static Arb hyperg_1f2r(dynamic a1, dynamic b1, dynamic b2, dynamic x)
        {
            return hyperg_1f2r(aflint.t(a1), aflint.t(b1), aflint.t(b2), aflint.t(x));
        }





        #endregion




        #region Scorer functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Arb airy_gi(Arb x)
        {
            return 1 * airy_bi(x) / 3 - (x * x) * hyperg_1f2(1, aflint.t(4) / 3, aflint.t(5) / 3, x * x * x / 9) / (2 * aflint.pi());
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi/*' />
        public static Arb airy_gi(dynamic x)
        {
            return airy_gi(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Arb airy_hi(Arb x)
        {
            return 2 * airy_bi(x) / 3 + (x * x) * hyperg_1f2(1, aflint.t(4) / 3, aflint.t(5) / 3, x * x * x / 9) / (2 * aflint.pi());
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi/*' />
        public static Arb airy_hi(dynamic x)
        {
            return airy_hi(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Arb airy_gi_prime(Arb x)
        {
            Arb x3 = x * x * x;
            Arb x4 = x3 * x;
            return airy_bi_prime(x) / 3 - 1 / (40 * aflint.pi()) * (40 * x * hyperg_1f2(1, aflint.t(4) / 3, aflint.t(5) / 3, x3 / 9) + (3 * x4 * hyperg_1f2(2, aflint.t(7) / 3, aflint.t(8) / 3, x3 / 9)));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_gi_prime/*' />
        public static Arb airy_gi_prime(dynamic x)
        {
            return airy_gi_prime(aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Arb airy_hi_prime(Arb x)
        {
            Arb x3 = x * x * x;
            Arb x4 = x3 * x;
            return 2 * airy_bi_prime(x) / 3 + 1 / (40 * aflint.pi()) * (40 * x * hyperg_1f2(1, aflint.t(4) / 3, aflint.t(5) / 3, x3 / 9) + (3 * x4 * hyperg_1f2(2, aflint.t(7) / 3, aflint.t(8) / 3, x3 / 9)));
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/airy_hi_prime/*' />
        public static Arb airy_hi_prime(dynamic x)
        {
            return airy_hi_prime(aflint.t(x));
        }


        #endregion



        #region Struve functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Arb struve_h(Arb v, Arb x)
        {
            return pow(x / 2, v + 1) * hyperg_1f2r(1, aflint.t(1.5), aflint.t(v + 1.5), -x * x / 4);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_h/*' />
        public static Arb struve_h(dynamic v, dynamic x)
        {
            return struve_h(aflint.t(v), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Arb struve_l(Arb v, Arb x)
        {
            return aflintc.struve_l(aflintc.t(v), aflintc.t(x)).real;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_l/*' />
        public static Arb struve_l(dynamic v, dynamic x)
        {
            return struve_l(aflint.t(v), aflint.t(x));
        }


        public static Arb struve_k(Arb v, Arb x)
        {
            return struve_h(v, x) - bessel_yv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_k/*' />
        public static Arb struve_k(dynamic v, dynamic x)
        {
            return struve_k(aflint.t(v), aflint.t(x));
        }


        public static Arb struve_m(Arb v, Arb x)
        {
            return struve_l(v, x) - bessel_iv(v, x);
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/struve_m/*' />
        public static Arb struve_m(dynamic v, dynamic x)
        {
            return struve_m(aflint.t(v), aflint.t(x));
        }


        #endregion



        #region Anger, Weber and Lommel functions


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Arb anger_j(Arb v, Arb x)
        {
            Arb f1 = hyperg_1f2r(1, 0.5 * (3 - v), 0.5 * (3 + v), -x * x / 4);
            Arb f2 = hyperg_1f2r(1, 0.5 * (2 - v), 0.5 * (2 + v), -x * x / 4);
            Arb res1 = 0.5 * x * sinpi(v / 2) * f1 + cospi(v / 2) * f2;
            return res1;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/anger_j/*' />
        public static Arb anger_j(dynamic v, dynamic x)
        {
            return anger_j(aflint.t(v), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Arb weber_e(Arb v, Arb x)
        {
            Arb f1 = hyperg_1f2r(1, 0.5 * (3 - v), 0.5 * (3 + v), -x * x / 4);
            Arb f2 = hyperg_1f2r(1, 0.5 * (2 - v), 0.5 * (2 + v), -x * x / 4);
            Arb res1 = -0.5 * x * cospi(v / 2) * f1 + sinpi(v / 2) * f2;
            return res1;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/weber_e/*' />
        public static Arb weber_e(dynamic v, dynamic x)
        {
            return weber_e(aflint.t(v), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Arb lommel_s1(Arb mu, Arb nu, Arb x)
        {
            Arb f1 = pow(x, mu + 1) / ((mu - nu + 1) * (mu + nu + 1));
            Arb f2 = hyperg_1f2(1, (mu - nu + 3) / 2, (mu + nu + 3) / 2, -x * x / 4);
            Arb res1 = f1 * f2;
            return res1;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s1/*' />
        public static Arb lommel_s1(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s1(aflint.t(mu), aflint.t(nu), aflint.t(x));
        }


        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Arb lommel_s2(Arb mu, Arb nu, Arb x)
        {
            Arb f1 = lommel_s1(mu, nu, x);
            Arb res1 = exp2(mu - 1) * gamma((mu - nu + 1) / 2) * gamma((mu + nu + 1) / 2);
            Arb res2 = sinpi((mu - nu) / 2) * bessel_jv(nu, x) - cospi((mu - nu) / 2) * bessel_yv(nu, x);
            return f1 + res1 * res2;
        }

        /// <include file="docs.xml" path='docs/members[@name="ScalarAndArrayFunctions"]/lommel_s2/*' />
        public static Arb lommel_s2(dynamic mu, dynamic nu, dynamic x)
        {
            return lommel_s2(aflint.t(mu), aflint.t(nu), aflint.t(x));
        }


        #endregion






        #endregion




    }






}