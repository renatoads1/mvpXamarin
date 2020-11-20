using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Widget;
using MySql.Data.MySqlClient;
using System;


namespace AppMatur2020
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Conexao con = new Conexao();
        EditText editTextUsuario, editTextSenha;


        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //relacionando campos a variaveis globais
            Button btnLoginAc = FindViewById<Button>(Resource.Id.btnEntrar);
            
            editTextUsuario = FindViewById<EditText>(Resource.Id.editTextUsuario);
            editTextSenha = FindViewById<EditText>(Resource.Id.editSenha);
            //delegate para o objeto os atributos
            btnLoginAc.Click += delegate
            {
                con.AbreCon();
                Login();
                
            };

            //abre conexao com o banco
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void Login() {
            if ((!String.IsNullOrEmpty(editTextUsuario.Text)) || (!String.IsNullOrEmpty(editTextSenha.Text)))
            {
                MySqlCommand cmd;
                MySqlDataReader reader;
                string strQuery = "SELECT Id,Usuario,Senha,cnpj,NomeEmpresa FROM usuarios WHERE Usuario = @usuario and Senha = @senha ";

                using (cmd = new MySqlCommand(strQuery, con.con))
                {
                    
                    cmd.Parameters.Add("@usuario", editTextUsuario.Text);
                    cmd.Parameters.Add("@senha", editTextSenha.Text);
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Conexao.Id = Convert.ToInt32(reader["id"]);
                            Conexao.Usuario = reader["Usuario"].ToString();
                            Conexao.Senha = reader["Senha"].ToString();
                            Conexao.Cnpj = reader["Cnpj"].ToString();
                            Conexao.NomeEmpresa = reader["NomeEmpresa"].ToString();
                            StartActivity(typeof(Home));
                        }

                        Toast.MakeText(Application.Context, $"Bem Vindo !!! {Conexao.Usuario} da empresa \n  {Conexao.NomeEmpresa}", ToastLength.Long).Show();
                        con.FechaCon();
                    }
                    else
                    {
                        Toast.MakeText(Application.Context, "Usuário e ou Senha Invalido!!", ToastLength.Long).Show();
                        con.FechaCon();
                    }
                }

               

                


            }
            else {
                Toast.MakeText(Application.Context, "Preencha os campos Usuário ou Senha", ToastLength.Long).Show();
                con.FechaCon();
            }
            con.FechaCon();
        }

    }
}