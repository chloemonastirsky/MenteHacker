using Newtonsoft.Json;
namespace TP5.Models;

public class Juego
{

    [JsonProperty]
    public int idSala;
    [JsonProperty]
    public string pista;
    [JsonProperty]
    private string[] Claves= new string [4];

    public Juego(){
        idSala=1;
         Claves[0] = "master";
         Claves[1] = "hacker";
         Claves[2] = "173";
         Claves[3] = "salidas";
    }


    public bool pasarDeSala(string clave){
        bool pasoONo=true;
        if(clave!=Claves[idSala-1]){
            pasoONo=false;
        }else{
        idSala++;
        pasoONo=true;
        }
        return pasoONo;
    }

   

   

}
