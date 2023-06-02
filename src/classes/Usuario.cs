class Usuario
{
  private string primeiroNome = "";  //  Campo dos primeiros nomes
  public string PrimeiroNome
  {
    get {   return primeiroNome; }
    set {   primeiroNome = value; }
  }

  private string sobrenome = "";  //  Campo dos sobrenomes
  public string Sobrenome
  {
    get {   return sobrenome; }
    set {   sobrenome = value; }
  }

  private string genero = "";  //  Campo do gênero
  public string Genero
  {
    get {   return genero; }
    set {   genero = value; }
  }
  private DateOnly nascimento;  //  Campo da data de nascimento
  public DateOnly Nascimento
  {
    get {   return nascimento; }
    set {   nascimento = value; }
  }

  private int idade;  //  Campo da idade
  public int Idade
  {
    get {   return idade; }
    set {   idade = value; }
  }

  public int CalcularIdade(DateOnly nascimento) //  Cálculo da idade
  {
    DateOnly hoje = DateOnly.FromDateTime(DateTime.Today); //  Pega o dia de hoje

    int anos = hoje.Year - nascimento.Year;

    //  Checa se a data atual é antes do aniversário deste ano
    //  Caso seja, subtraia 1 dos anos para adquirir a idade correta
    if (hoje < nascimento.AddYears(anos))
    {
        anos--;
    }

    return anos;
  }

  static void Main(string[] args)
  {
    Usuario myObj = new Usuario();
    myObj.Nascimento = new DateOnly();
    myObj.Idade = myObj.CalcularIdade(myObj.Nascimento);
    Console.WriteLine(myObj.idade);
  }
}