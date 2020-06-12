namespace Aula16Construtores
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int Valor { get; set; }
        public string Cor { get; set; }

        public Produto(){

        }
        public Produto(string _nome){
            //this é usado para dizer que os atributos são iguais 
            this.Tipo = _nome;
        }
        public Produto(string _nome,string _tipo, int _valor, string _cor){
            //usamos o _para diferenciar os metodos e atributos 
            this.Nome  = _nome;
            this.Tipo  = _tipo;
            this.Valor = _valor;
            this.Cor   = _cor;

        }
    }
}

    