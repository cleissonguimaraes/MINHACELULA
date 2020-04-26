using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using app02.Classes;
using System.Net;

namespace app02.Service
{
    public class DataService
    {
        HttpClient client = new HttpClient();
        private bool _aux;
        public async Task<List<Pessoa>> GetPessoasAsync()
        {
            try
            {
                string url = "https://apiminhacelula.azurewebsites.net/api/pessoas";
                var response = await client.GetStringAsync(url);
                var pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(response);
                return pessoas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Usuario>> GetUsuariosAsync()
        {
            try
            {
                string url = "https://apiminhacelula.azurewebsites.net/api/usuarios";
                var response = await client.GetStringAsync(url);
                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(response);
                return usuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        public Pessoa GetPessoaEspecificaAsync(int id)
        {
            try
            {
                string url = "https://apiminhacelula.azurewebsites.net/api/pessoas/{0}";
                var uri = new Uri(string.Format(url, id));
                /*HttpResponseMessage response = null;
                response = await bool client.Equals(uri, id);*/
                return JsonConvert.DeserializeObject<Pessoa>(uri.ToString());


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task AddPessoaAsync(Pessoa pessoa)
        {
            try
            {
                string url = "https://apiminhacelula.azurewebsites.net/api/pessoas/{0}";
                var uri = new Uri(string.Format(url,pessoa.PessoaId));
                var data = JsonConvert.SerializeObject(pessoa);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao adicionar pessoa!");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task UpdatePessoaAsync(Pessoa pessoa)
        {
            try
            {
                string url = "https://apiminhacelula.azurewebsites.net/api/pessoas/{0}";
            var uri = new Uri(string.Format(url, pessoa.PessoaId));
            var data = JsonConvert.SerializeObject(pessoa);

                var content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await client.PutAsync(uri, content);


            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao atualizar pessoa!");
            }
            }
            catch (Exception ex)
            {

            }
        }
        public async Task DeletaProdutoAsync(Pessoa pessoa)
        {
            string url = "https://apiminhacelula.azurewebsites.net/api/pessoas/{0}";
            var uri = new Uri(string.Format(url, pessoa.PessoaId));
            await client.DeleteAsync(uri);
        }
    }
}
