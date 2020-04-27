using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClienteEmpresa.Models
{
    class Empresa
    {
        String nomeFantasia;
        String inscricaoEstadual;
        long cnpj;
        String inscricaoMunicipal;
        String razaoSocial;
        String cEP;
        String logradouro;
        int numero;
        String complemento;
        String bairro;
        String cidade;
        String uf;
        String pais;
        String telefone;
        String email;

        public Empresa(string nomeFantasia, string inscricaoEstadual, long cnpj, string inscricaoMunicipal, string razaoSocial, string cEP, string logradouro, int numero, string complemento, string bairro, string cidade, string uf, string pais, string telefone, string email)
        {
            this.nomeFantasia = nomeFantasia;
            this.inscricaoEstadual = inscricaoEstadual;
            this.cnpj = cnpj;
            this.inscricaoMunicipal = inscricaoMunicipal;
            this.razaoSocial = razaoSocial;
            this.cEP = cEP;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.pais = pais;
            this.telefone = telefone;
            this.email = email;
        }

        public string NomeFantasia
        {
            get
            {
                return nomeFantasia;
            }

            set
            {
                nomeFantasia = value;
            }
        }

        public string InscricaoEstadual
        {
            get
            {
                return inscricaoEstadual;
            }

            set
            {
                inscricaoEstadual = value;
            }
        }

        public long Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string InscricaoMunicipal
        {
            get
            {
                return inscricaoMunicipal;
            }

            set
            {
                inscricaoMunicipal = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return razaoSocial;
            }

            set
            {
                razaoSocial = value;
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
