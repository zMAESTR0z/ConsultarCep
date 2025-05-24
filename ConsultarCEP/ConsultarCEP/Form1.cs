using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsultarCEP
{
    public partial class Form1 : Form
    {
        CEPController cepController;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=CEP;Integrated Security=True;";
            cepController = new CEPController(connectionString);
            List<ViaCEP> cep = cepController.GetCEP();
            dgv_CEP.DataSource = cep;
        }

        

        private async void bt_CEP_Click(object sender, EventArgs e)
        {
                string cep = txt_CEP.Text;

                if (!string.IsNullOrEmpty(cep))
                {
                    try
                    {
                        using (var client = new HttpClient())
                        {
                            string url = $"https://viacep.com.br/ws/{cep}/json/";

                            string json = await client.GetStringAsync(url);

                            if (!string.IsNullOrEmpty(json))
                            {
                                var endereco = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(json);

                                txt_logradouro.Text = endereco.logradouro;
                                txt_bairro.Text = endereco.bairro;
                                txt_cidade.Text = endereco.localidade;
                                txt_estado.Text = endereco.estado;

                                MessageBox.Show("Endereço encontrado com sucesso!", "Sucesso");
                            }
                            else
                            {
                                MessageBox.Show("Erro ao buscar o endereço. Verifique o CEP.", "Erro");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro durante a consulta: {ex.Message}", "Erro");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um CEP válido.", "Erro");
                }
            }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string logradouro = txt_logradouro.Text;
            string bairro = txt_bairro.Text;
            string cidade = txt_cidade.Text;
            string estado = txt_estado.Text;
            ViaCEP cep = new ViaCEP
            {
                logradouro = logradouro,
                bairro = bairro,
                cidade = cidade,
                estado = estado
            };
            cepController.SetCEP(cep);
            List<ViaCEP> cepList = cepController.GetCEP();
            dgv_CEP.DataSource = cepList;
        }

        private void btn_filtrarC_Click(object sender, EventArgs e)
        {
            string cidade = txt_FiltraCidade.Text;

            if (!string.IsNullOrEmpty(cidade))
            {
                List<ViaCEP> cepList = cepController.GetCEPByCidade(cidade);
                dgv_CEP.DataSource = cepList;
            }
            else
            {
                MessageBox.Show("Por favor, insira uma cidade para filtrar.", "Atenção");
            }
        }

        private void btn_filtrarE_Click(object sender, EventArgs e)
        {
            string estado = txt_FiltraEstado.Text;

            if (!string.IsNullOrEmpty(estado))
            {
                List<ViaCEP> cepList = cepController.GetCEPByEstado(estado);
                dgv_CEP.DataSource = cepList;
            }
            else
            {
                MessageBox.Show("Por favor, insira um estado para filtrar.", "Atenção");
            }
        }
    }


}

