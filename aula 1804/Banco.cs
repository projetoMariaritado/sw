
namespace Juros;
class Banco
{   
    public double parcela {get;set;}
    public double valor {get;set;} 
    public int prazo {get;set;} 

    public string emprestimo(double v, int p){
        this.valor = v;
        this.prazo = p;
        double parcela = this.valor/this.prazo;
        double juros = this.valor * 0.06;
        double total = parcela + juros;
        string resposta = "O valor a ser pago é de: " + total;

        return resposta; 



    }

}


