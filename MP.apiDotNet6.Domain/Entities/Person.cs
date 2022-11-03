using MP.apiDotNet6.Domain.Validations;

namespace MP.apiDotNet6.Domain.Entities {
    public sealed class Person {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public ICollection<Purchase> Purchases { get; private set; }

        public Person(string name, string document, string phone) {
            Validation(name, document, phone);
            Purchases = new List<Purchase>();
        }

        public Person(int id, string name, string document, string phone) {
            DomainValidationException.When(id < 0 , "Id deve ser maior que Zero!");
            this.Id = id;
            Validation(name, document, phone);
            Purchases = new List<Purchase>();
        }

        private void Validation(string name, string document, string phone) {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(document), "Documento deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(phone), "Telefone deve ser informado");

            this.Name = name;
            this.Document = document;
            this.Phone = phone;
        }

    }
}
