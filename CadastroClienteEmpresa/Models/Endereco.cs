﻿namespace CadastroClienteEmpresa.Models
{
    internal class Endereco
    {
        public Endereco(string codEndereco, TipoEnd tipoEndereco, string cEP, string logradouro, int numero,
            string complemento, string bairro, string cidade, string uf, string pais)
        {
            CodEndereco = codEndereco;
            TipoEndereco = tipoEndereco;
            CEP = cEP;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Uf = uf;
            Pais = pais;
        }

        public string CodEndereco { get; set; }

        public TipoEnd TipoEndereco { get; set; }

        public string CEP { get; set; }

        public string Logradouro { get; set; }

        public int Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public string Pais { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(CodEndereco)}: {CodEndereco}, {nameof(TipoEndereco)}: {TipoEndereco}, {nameof(CEP)}: {CEP}, {nameof(Logradouro)}: {Logradouro}, {nameof(Numero)}: {Numero}, {nameof(Complemento)}: {Complemento}, {nameof(Bairro)}: {Bairro}, {nameof(Cidade)}: {Cidade}, {nameof(Uf)}: {Uf}, {nameof(Pais)}: {Pais}";
        }

        internal enum TipoEnd
        {
            Comercial = 0,
            Cobrança = 1,
            Entrega = 2,
            Faturamento = 3,
            Residencial = 4,
            Trabalho = 5
        }
    }
}