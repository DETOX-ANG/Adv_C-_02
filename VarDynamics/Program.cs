using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarDynamics {
    class Program {
        static void Main(string[] args) {

            //O tipo var tem que ser definido na hora que for instanciado
            var nome = "Angelo";

            //Dynamic Só é definida na hora da execução. Ao ser declarada, não é apresentado erro de compilação
            //Porém se o valor for inválido, ela apresentará um erro(exception) na hora da execução
            dynamic nomeC = "Angelo Rocha";
        }
    }
}
