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
        public MySqlConnection con = null;

        public void AbreCon() {
            try
            {
                con = new MySqlConnection(strConection);
                con.Open();
                Toast.MakeText(Application.Context, "Conexão com o banco Aberta com sucesso", ToastLength.Long).Show();
            }
            catch (Exception e)
            {
                Toast.MakeText(Application.Context,"Erro ao conectar com o banco!!!"+e,ToastLength.Long).Show();
            }
        }
        public void FechaCon()
        {
            try
            {
                con = new MySqlConnection(strConection);
                con.Close();
                Toast.MakeText(Application.Context, "Conexão com o banco Fechada com sucesso", ToastLength.Long).Show();
            }
            catch (Exception)
            {
                Toast.MakeText(Application.Context, "Erro de conexão" , ToastLength.Long).Show();
            }
        }
    }
}