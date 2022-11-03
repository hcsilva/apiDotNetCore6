using MP.apiDotNet6.Domain.Validations;

namespace MP.apiDotNet6.Domain.Entities {
    public class Purchase {

        public int Id { get; private set; }
        public int ProductId { get; private set; }
        public int PersonId { get; private set; }
        public DateTime Date { get; private set; }
        public Person Person { get; private set; }
        public Product Product { get; private set; }

        public Purchase(int productId, int PersonId) {
            Validation(productId, PersonId);
        }

        public Purchase(int id, int productId, int PersonId) {
            DomainValidationException.When(id < 0, "Id deve ser maior que Zero!");
            this.Id = id;
            Validation(productId, PersonId);
        }


        private void Validation(int productId, int personId) {
            DomainValidationException.When(productId < 0, "Produto deve ser informado");
            DomainValidationException.When(personId < 0, "Código Erp deve ser informado");

            ProductId = productId;
            PersonId = personId;
            Date = DateTime.Now;
        }

    }

}

