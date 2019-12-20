using GameBRABO.Interface;

namespace GameBRABO.Lib{
    public class JogadorC : iJogador{
        public string Chutar(){
            return "Mbappé chutou a bola.\n";
        }
        public string Correr(){
            return "Mbappé está correndo.\n";
        }
        public string Passar(){
            return "Mbappé fez um passe.\n";
        }
        public string Marcar(){
            return "Mbappé marcou o passe.\n";
        }
        public string Dancar(){
            return "";
        }
        public string Cabecada(){
            return "";
        }
        public string Um_dois(){
            return "Mbappé fez um dois com outro jogador.\n";
        }
        public string Driblar(){
            return "Mbappé driblou o jogador.\n";
        }
        public string Carrinho(){
            return "Mbappé deu um carrinho em um jogador.\n";
        }
    }
}