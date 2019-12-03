using System;
using Explorando.Controllers;

namespace Explorando {
    class Program {
        static void Main (string[] args) {
            CodigoSondaController iniciar = new CodigoSondaController ();
            iniciar.EnviarComando ();
        }
    }
}