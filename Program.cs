using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new aof());
        }
        public static string fullnameofDB; //เอาไว้เก็บชื่อเต็ม
        public static string usernameofDB; //เอาไว้เก็บ username
        public static bool use_login=false; //เอาไว้เก็บค่าล็อกอินมีการล็อกอิน
        public static string select_room = "";
        public static bool use_select_room = false; //ไว้ตรวจสอบ
//เอาไว้ใช้ข้ามฟอร์ม
    }
}
