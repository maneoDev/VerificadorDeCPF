using Microsoft.AspNetCore.Mvc;
using Verificador_de_CPF.Models;
using System.Linq;

namespace Verificador_de_CPF.Controllers {
    public class CPFController : Controller {
        public IActionResult Index() {
            return View(new CPFViewModel()); /* retorna ujm novo modelo ao recarregar a pagina*/
        }

        [HttpPost]
        public IActionResult Index(CPFViewModel model) {
            model.CPFValido = ValidarCPF(model.CPF);

            /* limpar o campo cpf depois de verificar*/
            var resultado = model.CPFValido;
            ModelState.Clear();
            return View(new CPFViewModel { CPFValido = resultado});

        }

        private bool ValidarCPF(string cpf) {
            if (string.IsNullOrWhiteSpace(cpf)) {
                return false;
            }
                /* remove pontos e traços*/
                cpf = new string(cpf.Where(char.IsDigit).ToArray());

                /* verifica se tem 11 digitos ou todos os numero iguais */
                if (cpf.Length != 11 || cpf.Distinct().Count() == 1) {
                    return false;
                }

                /* Coverte para array de inteiros*/
                int[] verificador = cpf.Select(c => int.Parse(c.ToString())).ToArray();

                /* Calculo do primeiro digito*/

                int digito1 = (verificador[0] * 10) + (verificador[1] * 9) + (verificador[2] * 8) +
                              (verificador[3] * 7) + (verificador[4] * 6) + (verificador[5] * 5) +
                              (verificador[6] * 4) + (verificador[7] * 3) + (verificador[8] * 2);

                digito1 = digito1 % 11;
                digito1 = digito1 < 2 ? 0 : 11 - digito1;
                /* usando operador tenario para identificar se o numero é menor que dois, caso sim, recebe 0
                 * caso não recebe digito - 11*/

                if (verificador[9] != digito1) {
                    return false;
                }

                /* calculo do segundo digito*/
                int digito2 = (verificador[0] * 11) + (verificador[1] * 10) + (verificador[2] * 9) +
                              (verificador[3] * 8) + (verificador[4] * 7) + (verificador[5] * 6) +
                              (verificador[6] * 5) + (verificador[7] * 4) + (verificador[8] * 3) + (digito1 * 2);

                digito2 = digito2 % 11;
                digito2 =  digito2 < 2 ? 0 : 11 - digito2;

                return verificador[10] == digito2;
            }





    }
}
