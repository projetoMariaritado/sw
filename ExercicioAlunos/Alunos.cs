namespace ExercicioAlunos;
class Alunos

{
   public string nome="" ;
   public double nota1, nota2;
   //MEDIA -> retorna um double (por exemplo um numero como 8,3)
   public double obterMedia(){
    double media = (nota1=nota2)/2;
    return media;
   }
   //SITUAÇAO -> retorna uma string ("Aprovado"ou "Reprovado")
   public string obterSituacao(double media){
    string situacao="";
    if(media>=6){
        situacao="Aprovado";
    }else{
        situacao="Reprovado";
    }
    return situacao;
   }
   //MENSAGEM ->nao retorna nada. So mostra na tela os detales (nome, media e situacao)
   public void mensagem(){
    double mediaCalculada = obterMedia();
    string resultadoSituacao = obterSituacao(mediaCalculada);
    Console.WriteLine(nome+"esta" +resultadoSituacao +"com media: " +mediaCalculada);
   }
}