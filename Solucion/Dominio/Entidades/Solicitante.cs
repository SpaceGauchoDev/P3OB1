using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Solicitante: Usuario
    {

        public List<Proyecto> Proyectos { get; set; }








        public bool ValidarNombreYApellido(string pNom, string pApellido)
        {
            bool result = true;

            // validamos que nombre y apellido no sean vacíos
            if (pNom == "" && pApellido == "")
            {
                result = false;
            }

            // validamos que nombre y apellido no se pasen del limite de caracteres en DB
            if (pNom.Length > 30  && pApellido.Length > 50)
            {
                result = false;
            }

            return result;
        }

        public bool ValidarCI(ulong pCI)
        {
            string CIString = pCI.ToString();

            // obtenemos el digito verificador
            var digitoVerificador = CIString[CIString.Length - 1];

            // obtenemos el numero
            var primerParte = CIString.Substring(0, CIString.Length - 1);

            // calculamos el digito verificador a partir del numero
            int digitoCalculado = CalcularDigitoVerificador(primerParte);

            // comparamos el digito verificador provisto con el digito verificador calculado
            return (Int32.Parse(digitoVerificador.ToString()) == digitoCalculado);
        }


        private int CalcularDigitoVerificador(string ci)
        {
            // ????

            var a = 0;
            var i = 0;
            if (ci.Length <= 6)
            {
                for (i = ci.Length; i < 7; i++)
                {
                    ci = '0' + ci;
                }
            }
            for (i = 0; i < 7; i++)
            {
                a += (Int32.Parse("2987634"[i].ToString()) * Int32.Parse(ci[i].ToString())) % 10;
            }
            if (a % 10 == 0)
            {
                return 0;
            }
            else
            {
                return 10 - a % 10;
            }
        }


        public bool ValidarEmail(string pEmail)
        {
            bool result = true;

            return result;
        }


        public Solicitante()
        {

        }
    }
}
