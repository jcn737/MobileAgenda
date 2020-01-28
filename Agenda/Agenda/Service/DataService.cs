using Agenda.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace Agenda.Service
{
    public class DataService
    {
        public int id = 4433;
        public async Task<List<Aluno>> GetAlunosAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://localhost:53177/api/alunos/";
                    var response = await client.GetStringAsync(url);
                    var aluno = JsonConvert.DeserializeObject<List<Aluno>>(response);
                    return aluno;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<Aluno> GetAlunoAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/estudante/4433";
                    var uri = new Uri(string.Concat(url, aluno.ID_Aluno));
                    var response = await client.GetStringAsync(uri);
                    var alunos = JsonConvert.DeserializeObject<Aluno>(response);
                    return alunos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public async Task<List<Janeiro>> GetJaneiroAsync(int id)
        internal async Task<List<Janeiro>> GetJaneiroAsync()
        {
            try
            {
                using (var client = new HttpClient())                //HttpRequestMessage, HttpResponseMessage
                {
                    string url = "http://localhost:53177/api/janeiro/4433";
                    var uri = new Uri(string.Concat(url, id));
                    var response = await client.GetAsync(url);

                    if (response.StatusCode == HttpStatusCode.ExpectationFailed)
                    {
                        throw new SecurityException(response.Content.ToString());
                    }
                    var userJson = await response.Content.ReadAsStringAsync();
                    var janeiro = JsonConvert.DeserializeObject<List<Janeiro>>(userJson);
                    return janeiro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal async Task<List<Fevereiro>> GetFevereiroAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/fevereiro/4433";
                    //var uri = new Uri(string.Concat(url, id));
                    var response = await client.GetStringAsync(url);
                    var fevereiro = JsonConvert.DeserializeObject<List<Fevereiro>>(response);
                    return fevereiro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Marco>> GetMarcoAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/marco/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var marco = JsonConvert.DeserializeObject<List<Marco>>(response);
                    return marco;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Abril>> GetAbrilAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/abril/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var abril = JsonConvert.DeserializeObject<List<Abril>>(response);
                    return abril;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Maio>> GetMaioAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/maio/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var maio = JsonConvert.DeserializeObject<List<Maio>>(response);
                    return maio;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Junho>> GetJunhoAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/junho/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var junho = JsonConvert.DeserializeObject<List<Junho>>(response);
                    return junho;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Julho>> GetJulhoAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/julho/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var julho = JsonConvert.DeserializeObject<List<Julho>>(response);
                    return julho;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Agosto>> GetAgostoAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/agosto/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var agosto = JsonConvert.DeserializeObject<List<Agosto>>(response);
                    return agosto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Setembro>> GetSetembroAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/setembro/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var setembro = JsonConvert.DeserializeObject<List<Setembro>>(response);
                    return setembro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Outubro>> GetOutubroAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/outubro/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var outubro = JsonConvert.DeserializeObject<List<Outubro>>(response);
                    return outubro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Novembro>> GetNovembroAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/novembro/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var novembro = JsonConvert.DeserializeObject<List<Novembro>>(response);
                    return novembro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Dezembro>> GetDezembroAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/dezembro/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var dezembro = JsonConvert.DeserializeObject<List<Dezembro>>(response);
                    return dezembro;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal async Task<List<Boletim>> GetBoletimAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/boletim/5544";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var boletim = JsonConvert.DeserializeObject<List<Boletim>>(response);
                    return boletim;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Comunicado>> GetComunicadoAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/comunicado/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var comunicado = JsonConvert.DeserializeObject<List<Comunicado>>(response);
                    return comunicado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<HoraAula>> GetHoraAulaAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/horaaula/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var horaAula = JsonConvert.DeserializeObject<List<HoraAula>>(response);
                    return horaAula;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<ListaMaterial>> GetListaMaterialAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/listamaterial/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var listaMaterial = JsonConvert.DeserializeObject<List<ListaMaterial>>(response);
                    return listaMaterial;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Reuniao>> GetReuniaosAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/reuniao/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var reuniao = JsonConvert.DeserializeObject<List<Reuniao>>(response);
                    return reuniao;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<RoteiroEstudo>> GetRoteiroEstudosAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/roteiroestudo/4433";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var roteiroEstudo = JsonConvert.DeserializeObject<List<RoteiroEstudo>>(response);
                    return roteiroEstudo;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task<List<Contato>> GetContatoAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var aluno = new Aluno();
                    string url = "http://localhost:53177/api/contato/";
                    //var uri = new Uri(string.Concat(url, id));   
                    var response = await client.GetStringAsync(url);
                    var contato = JsonConvert.DeserializeObject<List<Contato>>(response);
                    return contato;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        internal async Task<string> DownloadPage(string url)
        {
            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(new Uri(url)))
                {
                    string result = await r.Content.ReadAsStringAsync();
                    return result;
                }
            }
        }
        internal async Task AddAlunoAsync(Aluno aluno)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://localhost:56180/api/estudante/id/4433";

                    var uri = new Uri(string.Format(url, aluno.Nome));

                    var data = JsonConvert.SerializeObject(aluno);
                    var content = new StringContent(data, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = null;

                    response = await client.PostAsync(uri, content);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task UpdateAlunoAsync(Aluno aluno)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string url = "http://localhost:56180/api/estudante/nome/4433";
                    //var uri = new Uri(string.Concat(url, id));   

                    var data = JsonConvert.SerializeObject(aluno);
                    var content = new StringContent(data, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = null;
                    response = await client.PutAsync(url, content);
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception("Erro ao atualizar aluno");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        internal async Task DeletaAlunoByIdAsync(int indice)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://localhost:56180/api/estudante/nome/4433";
                    await client.DeleteAsync(string.Concat(url, indice));
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        internal async Task DeletaProdutoAsync(Aluno aluno)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://localhost:56180/api/estudante/nome/4433";
                    var uri = new Uri(string.Format(url, aluno.Nome));
                    await client.DeleteAsync(uri);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}

