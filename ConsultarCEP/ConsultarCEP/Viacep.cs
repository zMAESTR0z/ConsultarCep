using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class ViaCEP
{
    public string logradouro { get; set; }
    public string bairro { get; set; }
    public string cidade { get; set; }
    public string estado { get; set; }
}