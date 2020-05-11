namespace CadastroClienteEmpresa.Models
{
    internal class Email
    {
        public Email(TipoEmail tipoDoEmail, string codEmail, string email)
        {
            TipoDoEmail = tipoDoEmail;
            CodEmail = codEmail;
            E_mail = email;
        }

        public string CodEmail { get; set; }

        public string E_mail { get; set; }

        public TipoEmail TipoDoEmail { get; set; }

        internal enum TipoEmail
        {
            Comercial = 0,
            Pessoal = 1,
            Geral = 2
        }

        public override string ToString()
        {
            return $"{nameof(CodEmail)}: {CodEmail}, {nameof(TipoDoEmail)}: {TipoDoEmail}, {nameof(E_mail)}: {E_mail}";
        }
    }
}