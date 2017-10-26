using System.Collections.Generic;

namespace Model.ConsultaCRM
{
    public class CRMCheck
    {
        public string url { get; set; }
        public int total { get; set; }
        public bool status { get; set; }
        public string mensagem { get; set; }
        public int api_limite { get; set; }
        public int api_consultas { get; set; }
        public List<CRMItem> item { get; set; }
    }
}