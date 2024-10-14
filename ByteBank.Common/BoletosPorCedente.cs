namespace ByteBank.Common
{
    public class BoletosPorCedente
    {
        public string CedenteNome { get; set; }
        public string CedenteCpfCnpj { get; set; }
        public string CedenteAgencia { get; set; }
        public string CedenteConta { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}
