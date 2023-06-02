class Evento 
{
  private static int ultimoIdentificador = 0;  //  Campo do identificador anterior que irá incrementar o anterior
  public int Identificador { get; } //  Campo do identificador atual

  private string nome = "";  //  Campo do nome do evento
  public string Nome
  {
    get {   return nome; }
    set {   nome = value; }
  }

  private int numero;  //  Campo do número de participantes
  public int Numero
  {
    get {   return numero; }
    set {   numero = value; }
  }
  private DateTime data;  //  Campo da data do acontecimento
  public DateTime Data
  {
    get {   return data; }
    set {   data = value; }
  }
  
  private TimeSpan duracao;  //  Campo da duração do evento
  public TimeSpan Duracao    //
  {
    get {   return duracao; }
    set {   duracao = value; }
  }
  
  private string criador = "";  //  Campo do criador
  public string Criador    //
  {
    get {   return criador; }
    set {   criador = value; }
  }

  static void Main(string[] args)
  {
    Evento myObj = new Evento();
    Console.WriteLine(myObj.nome);
  }

  public Evento()
  {
    //  Incrementa o ultimo identificador e designa ele ao identificador do evento atual
    Identificador = ++ultimoIdentificador;
  }
}