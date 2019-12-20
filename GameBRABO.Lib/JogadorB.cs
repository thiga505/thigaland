using GameBRABO.Interface;

namespace GameBRABO.Lib{
    public class JogadorB : iJogador{
        public string Chutar(){
            return "Edmundo chutou a bola.\n";
        }
        public string Correr(){
            return "Edmundo está correndo.\n";
        }
          public string Passar(){
            return "Edmundo fez um passe.\n";
        }
        public string Dancar(){
            return "Edmundo fez a dança da bundinha.\n";
        }
        public string Marcar(){
            return "Edmundo marcou o passe.\n";
        }
        public string Cabecada(){
            return "";
        }
        public string Um_dois(){
            return "Edmundo fez um dois com outro jogador.\n";
        }
        public string Driblar(){
            return "Edmundo driblou um jogador.\n";
        }
        public string Carrinho(){
            return "Edmundo deu um carrinho em um jogador.\n";
        }
    }
}