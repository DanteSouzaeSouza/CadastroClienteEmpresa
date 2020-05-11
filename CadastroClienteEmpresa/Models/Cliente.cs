using System.Collections.Generic;

namespace CadastroClienteEmpresa.Models
{
    internal class Cliente
    {
        public Cliente(string nome, string rg, long cpf, string orgaoEmissor, string ufRg, List<Endereco> enderecos,
            List<Telefone> telefones, List<Email> emails)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            OrgaoEmissor = orgaoEmissor;
            UfRg = ufRg;
            Enderecos = enderecos;
            Telefones = telefones;
            Emails = emails;
        }

        public string Nome { get; set; }

        public string Rg { get; set; }

        public long Cpf { get; set; }

        public string OrgaoEmissor { get; set; }

        public string UfRg { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public List<Telefone> Telefones { get; set; }

        public List<Email> Emails { get; set; }

        public override string ToString()
        {
            return
                $"{nameof(Nome)}: {Nome}, {nameof(Rg)}: {Rg}, {nameof(Cpf)}: {Cpf}, {nameof(OrgaoEmissor)}: {OrgaoEmissor}, {nameof(UfRg)}: {UfRg}, {nameof(Enderecos)}: {Enderecos}, {nameof(Telefones)}: {Telefones}, {nameof(Emails)}: {Emails}";
        }
    }
}