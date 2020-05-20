namespace CadastroClienteEmpresa.Models
{
    internal class Telefone
    {
        public Telefone(TipoTel tipoTelefone, string codTel, string pais, string area, string numero)
        {
            TipoTelefone = tipoTelefone;
            CodTel = codTel;
            Pais = pais;
            Area = area;
            Numero = numero;
        }

        public string Area { get; set; }
        public string CodTel { get; set; }
        public string Numero { get; }
        public string Pais { get; set; }
        public TipoTel TipoTelefone { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(TipoTelefone)}: {TipoTelefone}, {nameof(CodTel)}: {CodTel}, {nameof(Pais)}: {Pais}, {nameof(Area)}: {Area}, {nameof(Numero)}: {Numero}";
        }

        internal enum TipoTel
        {
            Residencial = 0,
            Comercial = 1,
            Celular = 2,
            Contato = 3,
            Empresarial = 4
        }
    }
}