using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMatur2020
{
    class Conexao
    {
        public static int Id { get; set; }
        public static string Usuario { get; set; }
        public static string Senha { get; set; }
        public static string Cnpj { get; set; }
        public static string NomeEmpresa { get; set; }

        public static string strConection = "SERVER=34.121.4.30;DATABASE=AppMatur2020;UID=root;PWD=r3n4t0321;PORT=3306";

  
        }
}