using Android.App;
using Android.OS;
using Android.Widget;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AppMatur2020
{
    [Activity(Label = "Home")]
    public class Home : Activity
    {
        Conexao con2 = new Conexao();
        Button btSalva, btEditar, btExcluir;
        ListView list; 


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            //carrega butons
            btSalva = FindViewById<Button>(Resource.Id.btnSalvar);
            btEditar = FindViewById<Button>(Resource.Id.btnEditar);
            btExcluir = FindViewById<Button>(Resource.Id.btnExcluir);
            list = FindViewById<ListView>(Resource.Id.listvHome);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Home);
            TextView txtBemVindo = FindViewById<TextView>(Resource.Id.textViewBemVindo);
            txtBemVindo.Text = txtBemVindo.Text +" "+ Conexao.Usuario.ToUpper();
            Listar();
        }

        private void Listar()
        {
            //MySqlCommand cmd;
            //MySqlDataReader reader;
            //ArrayAdapter<string> adapter;
            //List<string> listadeitens = new List<string>();

            //string sql = "select *from usuarios";
            //con2.AbreCon();
            //cmd = new MysqlCommand(sql, con2.con);
            //reader = cmd.ExecuteReader();
            //if (reader.HasRows) {
            //    while (reader.Read())
            //    {
                    //listadeitens.Add(reader["Usuario"].ToString());
                    //adapter = new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1, listadeitens);
                    //list.Adapter = adapter;
            //    }
            //}
            //con2.FechaCon();
        }
    }
}