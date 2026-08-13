using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using FixedPrecNet;

namespace ArbPrecNet
{



    public static class ArbPrec
    {


        public static Boolean UseRawDouble = false;


        public static bool IsExactDouble(double z)
        {
            if (!dreal.isfinite(z)) return true;
            double x = Math.Abs(z);
            if (x >= 1.0)
            {
                if (Math.Ceiling(x) == Math.Floor(x))
                {
                    return true;
                }
                else
                {
                    double temp = 1048576;  // = 2^20
                    temp *= x;
                    if (Math.Ceiling(temp) == Math.Floor(temp))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                double temp = 1125899906842624;  // = 2^50
                temp *= x;
                if (Math.Ceiling(temp) == Math.Floor(temp))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }




        [DllImport("KERNEL32.dll", EntryPoint = "LoadLibraryA")]
        private static extern IntPtr LoadLibrary(string lpFile);
        internal const string mpNum = "ArbPrecNetGCCK8.dll";



        internal static double HasLibraryNumC()
        {
            string Curdir = Directory.GetCurrentDirectory();
            double Result = 0d;

            string FullDLLPath = Assembly.GetExecutingAssembly().Location;
            string DLLPath = Path.GetDirectoryName(FullDLLPath) + @"\";

            //MessageBox.Show(DLLPath);
            //Console.WriteLine("DLLPath: {0}", DLLPath);



            if (!DLLPath.Contains("xlcalcnet2"))
            {
                //Console.WriteLine("In contains");
                //DLLPath = DLLPath.Replace("xlcalcnet", "mpfebnet");
                DLLPath = DLLPath.Replace("xlcalcnet", "xlcalcnet2");
            }


            //MessageBox.Show(DLLPath);

            //Console.WriteLine("DLLPath: {0}", DLLPath);

            Directory.SetCurrentDirectory(DLLPath);

            string FName = DLLPath + mpNum;
            Result = (double)ArbPrec.LoadLibrary(FName);
            if (Result == 0d)
            {
                Console.WriteLine("Could not load supporting library " + mpNum);
                return 0d;
            }

            Directory.SetCurrentDirectory(Curdir);

            return Result;
        }
        private static bool _Init_IsInitialized = false;



        public static void Init()
        {
            if (!_Init_IsInitialized)
            {
                _Init_IsInitialized = true;
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

                CultureInfo ci = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
                ci.NumberFormat.NegativeInfinitySymbol = "-Inf";
                ci.NumberFormat.PositiveInfinitySymbol = "+Inf";
                Thread.CurrentThread.CurrentCulture = ci;
                double Result = HasLibraryNumC();
                //SetDps(30);
            }
        }




        public static uint GetPrec()
        {
            Init();
            return (uint)Interop.Lib_Get_Default(constants.mp_default_prec);
        }

        public static void SetPrec(uint prec2)
        {
            Init();
            Interop.Lib_Set_Default(constants.mp_default_prec, (int)prec2);
        }




        public static uint GetDps()
        {
            Init();
            return (uint)Math.Round((uint)(Interop.Lib_Get_Default(constants.mp_default_prec) * 100) / 333d);
        }

        public static void SetDps(int dps)
        {
            Init();
            Interop.Lib_Set_Default(constants.mp_default_prec, (int)Math.Round(dps * 333 / 100d));
            //Lib_Mpfi_CXSC_Set_Prec((int)Math.Round(dps * 333 / 100d));
            //Lib_Mpd_SetPrec((uint)(dps + 0));
        }
        //[DllImport(mpNum, EntryPoint = "Lib_Mpd_SetPrec", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpd_SetPrec(uint prec);

        //[DllImport(mpNum, EntryPoint = "Lib_Mpfi_CXSC_Set_Prec", CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int Lib_Mpfi_CXSC_Set_Prec(int prec);



        public static int sort_ascending()
        {
            return constants.mp_sort_ascending;
        }


        public static int sort_descending()
        {
            return constants.mp_sort_descending;
        }


        public static int sort_by_abs()
        {
            return constants.mp_sort_by_abs;
        }


        public static int sort_by_real()
        {
            return constants.mp_sort_by_real;
        }


        public static int sort_by_imag()
        {
            return constants.mp_sort_by_imag;
        }







    }
}