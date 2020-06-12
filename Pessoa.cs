namespace Aula16
{
    public class Pessoa
    {
    public int Rg { get; set; }
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public int Cpf { get; set; }

    public Pessoa(){

    }
    public Pessoa(int _rg){
        this.Rg = _rg;
    }
    public Pessoa(string _nome){
        this.Nome = _nome;
    }
    public Pessoa(int _rg, string _nome, string _sobrenome, int _cpf){
        this.Rg = _rg;
        this.Nome = _nome;
        this.SobreNome = _sobrenome;
        this.Cpf = _cpf;
    }
    }
}