using GameBRABO.Interface;

namespace GameBRABO.Lib{
    public class JogadorA : iJogador{
        public readonly string _Nome;
        public JogadorA(string nome = "Ronaldo"){
            _Nome = nome;
        }
        // Chutar
        public string Chutar(){
            return $"{_Nome} chutou a bola.\n";
        }
        // Correr
        public string Correr(){
            return $"{_Nome} está correndo.\n";
        }
        // Passar
        public string Passar(){
            return $"{_Nome} fez um passe.\n";
        }
        // Marcar
        public string Marcar(){
            return $"{_Nome} marcou o passe.\n";
        }
        public string Dancar(){
            return "";
        }
        public string Cabecada(){
            return "";
        }
        public string Um_dois(){
            return $"{_Nome} fez um dois com outro jogador.\n";
        }
        public string Driblar(){
            return $"{_Nome} driblou um jogador.\n";
        }
        public string Carrinho(){
            return $"{_Nome} deu um carrinho em um jogador.\n";
        }
    }
}