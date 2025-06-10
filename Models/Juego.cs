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
         Claves[0] = "Master";
         Claves[1] = "Hacker";
         Claves[2] = "173";
         Claves[3] = "Salidas";
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
