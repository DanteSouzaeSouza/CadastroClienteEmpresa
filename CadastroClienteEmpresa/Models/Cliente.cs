using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClienteEmpresa.Models
{
    class Cliente
    {
        String nome;
        String rg;
        long cpf;
        String orgaoEmissor;
        String ufRg;
        String cEP;
        String logradouro;
        int numero;
        String complemento;
        String bairro;
        String cidade;
        String uf;
        String pais;
        String telefone;
        String celular;
        String email;

        public Cliente(string nome, string rg, long cpf, string orgaoEmissor, string ufRg, string cEP, string logradouro, int numero, string complemento, string bairro, string cidade, string uf, string pais, string telefone, string celular, string email)
        {
            this.nome = nome;
            this.rg = rg;
            this.cpf = cpf;
            this.orgaoEmissor = orgaoEmissor;
            this.ufRg = ufRg;
            this.cEP = cEP;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.pais = pais;
            this.telefone = telefone;
            this.celular = celular;
            this.email = email;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string OrgaoEmissor
        {
            get
            {
                return orgaoEmissor;
            }

            set
            {
                orgaoEmissor = value;
            }
        }

        public string UfRg
        {
            get
            {
                return ufRg;
            }

            set
            {
                ufRg = value;
            }
        }

        public string CEP
        {
            get
            {
                return cEP;
            }

            set
            {
                cEP = value;
            }
        }

        public string Logradouro
        {
            get
            {
                return logradouro;
            }

            set
            {
                logradouro = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                pais = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
