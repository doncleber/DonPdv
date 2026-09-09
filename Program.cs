using DonPdv.pdv.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonPdv
{
    static class Program
    {
        //Varivéis Globais
        public static string nomeUsuario;
        public static int nivel;
        public static Boolean logado = false;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "db_loja.db";
        public static string caminhoBanco = caminho+@"\banco\";
        
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_menuprincipal());
        }
    }
}
