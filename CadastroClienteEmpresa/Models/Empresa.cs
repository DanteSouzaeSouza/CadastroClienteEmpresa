namespace CadastroClienteEmpresa.Models
{
    internal class Empresa
    {
        public Empresa(string nomeFantasia, string inscricaoEstadual, long cnpj, string inscricaoMunicipal,
            string razaoSocial, string cEP, string logradouro, int numero, string complemento, string bairro,
            string cidade, string uf, string pais, string telefone, string email)
        {
            NomeFantasia = nomeFantasia;
            InscricaoEstadual = inscricaoEstadual;
            Cnpj = cnpj;
            InscricaoMunicipal = inscricaoMunicipal;
            RazaoSocial = razaoSocial;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Pais = pais;
            Telefone = telefone;
            Email = email;
        }

        public string NomeFantasia { get; set; }

        public string InscricaoEstadual { get; set; }

        public long Cnpj { get; set; }

        public string InscricaoMunicipal { get; set; }

        public string RazaoSocial { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public string Pais { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return $"{nameof(NomeFantasia)}: {NomeFantasia}, {nameof(InscricaoEstadual)}: {InscricaoEstadual}, {nameof(Cnpj)}: {Cnpj}, {nameof(InscricaoMunicipal)}: {InscricaoMunicipal}, {nameof(RazaoSocial)}: {RazaoSocial}, {nameof(CEP)}: {CEP}, {nameof(Logradouro)}: {Logradouro}, {nameof(Numero)}: {Numero}, {nameof(Complemento)}: {Complemento}, {nameof(Bairro)}: {Bairro}, {nameof(Cidade)}: {Cidade}, {nameof(Uf)}: {Uf}, {nameof(Pais)}: {Pais}, {nameof(Telefone)}: {Telefone}, {nameof(Email)}: {Email}";
        }
    }
}