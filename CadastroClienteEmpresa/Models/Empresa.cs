using System.Collections.Generic;

namespace CadastroClienteEmpresa.Models
{
    internal class Empresa
    {
        public Empresa(string nomeFantasia, string inscricaoEstadual, long cnpj, string inscricaoMunicipal,
            string razaoSocial, List<Endereco> enderecos, List<Telefone> telefones, List<Email> emails)
        {
            NomeFantasia = nomeFantasia;
            InscricaoEstadual = inscricaoEstadual;
            Cnpj = cnpj;
            InscricaoMunicipal = inscricaoMunicipal;
            RazaoSocial = razaoSocial;
            Enderecos = enderecos;
            Telefones = telefones;
            Emails = emails;
        }

        public string NomeFantasia { get; set; }

        public string InscricaoEstadual { get; set; }

        public long Cnpj { get; set; }

        public string InscricaoMunicipal { get; set; }

        public string RazaoSocial { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public List<Telefone> Telefones { get; set; }

        public List<Email> Emails { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(Cnpj)}: {Cnpj}, {nameof(RazaoSocial)}: {RazaoSocial}, {nameof(NomeFantasia)}: {NomeFantasia}, {nameof(InscricaoEstadual)}: {InscricaoEstadual}, {nameof(InscricaoMunicipal)}: {InscricaoMunicipal}, {nameof(Enderecos)}: {Enderecos}, {nameof(Telefones)}: {Telefones}, {nameof(Emails)}: {Emails}";
        }
    }
}