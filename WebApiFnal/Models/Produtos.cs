namespace WebApiFnal.Models
{
    public class Produtos : Base
    {
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor {  get; set; }
        public DateTime DataCadastro { get; set; }

        


        // TIPOS DE DADOS

        string nome = "etec"; //Tipo de Referencia
        char letra = 'A'; 

        int valor = 10; // numeros Inteiros
        long valor1 = 10L; // numeros Inteiros
        byte valorB = 128; // numeros Inteiros

        float valorf = 10.5F; // numeros reais
        double valor2 = 10.5; // numeros reais
    }
}
