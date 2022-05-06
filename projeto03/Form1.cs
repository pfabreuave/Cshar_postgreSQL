using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * pendiente agregar actualizacion del stock
 * como controlo el tamanho del comBox
 * como simplifico new
 * 
*/
namespace projeto03
{
    
    public partial class Form1 : Form
    {
        NpgsqlConnection conex = new NpgsqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String strConex = "Server=localhost;Port=5432;Database=stone;User Id=postgres;Password=psap616201;";
            conex.ConnectionString = strConex;
            conex.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.CommandText = "SELECT * from estoque limit 15";
            cmd.Connection = conex;
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cboPolos.Items.Add(dr[0]);   
            }
            dr.Close();
        }

        private void CboPolos_SelectedIndexChanged(object sender, EventArgs e)
        {

            string strSql = @"SELECT polo, stock, venda, dias_hab, 
                            ceil(venda / dias_hab) as media, 
                            ceil(stock / (venda / dias_hab)) as auto, 
                            CASE WHEN(ceil(stock / (Venda / Dias_Hab))) < 10 THEN 1 
                                 WHEN(ceil(stock / (Venda / Dias_Hab))) >= 10 
                                  AND(ceil(stock / (Venda / Dias_Hab))) <= 13 THEN 2 
                                 WHEN(ceil(stock / (Venda / Dias_Hab))) >= 14 
                                  AND(ceil(stock / (Venda / Dias_Hab))) <= 18 THEN 3 
                                 WHEN(ceil(stock / (Venda / Dias_Hab))) >= 19 
                                  AND(ceil(stock / (Venda / Dias_Hab))) <= 23 THEN 4 
                            ELSE 5 END AS cat, 
                            CASE WHEN(ceil(stock / (Venda / Dias_Hab))) >= 14 
                                  AND(ceil(stock / (Venda / Dias_Hab))) <= 18 THEN 0 
                            ELSE(14 - (ceil(stock / (Venda / Dias_Hab)))) * 
                                       ceil(Venda / Dias_Hab) END AS rep 
                            FROM(SELECT  atendimentos.polo, COUNT(*) as venda, 
                                         COUNT(distinct fecha) as dias_hab, 
                                         estoque.stock FROM public.atendimentos 
                                JOIN estoque ON(atendimentos.polo = estoque.polo) 
                                     WHERE estoque.polo = '" + cboPolos.Text + "'"; 
            strSql += "GROUP BY atendimentos.polo, estoque.stock) as t";
            NpgsqlCommand cmd = new()
            {
                CommandText = strSql,
                Connection = conex
            };
            NpgsqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            tbStock.Text = dr[1].ToString();
            tbVenda.Text = dr[2].ToString();
            tbDhabiles.Text = dr[3].ToString();
            tbPromedio.Text = dr[4].ToString();
            tbAutosuficiencia.Text = dr[5].ToString();
            tbCategoria.Text = dr[6].ToString();
            tbReposicion.Text = dr[7].ToString();
            dr.Close();    
        }
    }
}