namespace CadastroClienteEmpresa.Models
{
    internal class Cliente
    {
        public Cliente(string nome, string rg, long cpf, string orgaoEmissor, string ufRg, string cEP,
            string logradouro, int numero, string complemento, string bairro, string cidade, string uf, string pais,
            string telefone, string celular, string email)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            OrgaoEmissor = orgaoEmissor;
            UfRg = ufRg;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Pais = pais;
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }

        public string Nome { get; set; }

        public string Rg { get; set; }

        public long Cpf { get; set; }

        public string OrgaoEmissor { get; set; }

        public string UfRg { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public string Pais { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(Nome)}: {Nome}, {nameof(Rg)}: {Rg}, {nameof(Cpf)}: {Cpf}, {nameof(OrgaoEmissor)}: {OrgaoEmissor}, {nameof(UfRg)}: {UfRg}, {nameof(CEP)}: {CEP}, {nameof(Logradouro)}: {Logradouro}, {nameof(Numero)}: {Numero}, {nameof(Complemento)}: {Complemento}, {nameof(Bairro)}: {Bairro}, {nameof(Cidade)}: {Cidade}, {nameof(Uf)}: {Uf}, {nameof(Pais)}: {Pais}, {nameof(Telefone)}: {Telefone}, {nameof(Celular)}: {Celular}, {nameof(Email)}: {Email}";
        }
    }
}