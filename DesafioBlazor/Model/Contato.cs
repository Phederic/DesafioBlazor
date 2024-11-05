namespace DesafioBlazor.Model
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Whatsapp { get; set; }
        public string Email { get; set; }
      
    }

    public class ContatoData
    {
        public List<Contato> Contatos = new List<Contato>
        {
        new Contato { Nome = "Alice Silva", Whatsapp = "+5511987654321", Email = "alice.silva@example.com" },
        new Contato { Nome = "Bruno Costa", Whatsapp = "+5511987654322", Email = "bruno.costa@example.com" },
        new Contato { Nome = "Carla Oliveira", Whatsapp = "+5511987654323", Email = "carla.oliveira@example.com" },
        new Contato { Nome = "Diego Santos", Whatsapp = "+5511987654324", Email = "diego.santos@example.com" },
        new Contato { Nome = "Elisa Ferreira", Whatsapp = "+5511987654325", Email = "elisa.ferreira@example.com" },
        new Contato { Nome = "Fabio Martins", Whatsapp = "+5511987654326", Email = "fabio.martins@example.com" },
        new Contato { Nome = "Gabriela Almeida", Whatsapp = "+5511987654327", Email = "gabriela.almeida@example.com" },
        new Contato { Nome = "Henrique Lima", Whatsapp = "+5511987654328", Email = "henrique.lima@example.com" },
        new Contato { Nome = "Isabel Rocha", Whatsapp = "+5511987654329", Email = "isabel.rocha@example.com" },
        new Contato { Nome = "João Pereira", Whatsapp = "+5511987654330", Email = "joao.pereira@example.com" },
        new Contato { Nome = "Karen Souza", Whatsapp = "+5511987654331", Email = "karen.souza@example.com" },
        new Contato { Nome = "Lucas Barbosa", Whatsapp = "+5511987654332", Email = "lucas.barbosa@example.com" },
        new Contato { Nome = "Mariana Gomes", Whatsapp = "+5511987654333", Email = "mariana.gomes@example.com" },
        new Contato { Nome = "Nicolas Cardoso", Whatsapp = "+5511987654334", Email = "nicolas.cardoso@example.com" },
        new Contato { Nome = "Olivia Ribeiro", Whatsapp = "+5511987654335", Email = "olivia.ribeiro@example.com" },
        new Contato { Nome = "Pedro Mendes", Whatsapp = "+5511987654336", Email = "pedro.mendes@example.com" },
        new Contato { Nome = "Quésia Dias", Whatsapp = "+5511987654337", Email = "quesia.dias@example.com" },
        new Contato { Nome = "Rafael Azevedo", Whatsapp = "+5511987654338", Email = "rafael.azevedo@example.com" },
        new Contato { Nome = "Sara Fonseca", Whatsapp = "+5511987654339", Email = "sara.fonseca@example.com" },
        new Contato { Nome = "Thiago Teixeira", Whatsapp = "+5511987654340", Email = "thiago.teixeira@example.com" }
        };
    }
}
