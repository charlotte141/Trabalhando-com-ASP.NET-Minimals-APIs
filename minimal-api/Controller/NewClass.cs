using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace minimal_api.Controller
{
    [Controller]
    [Route("[Controller]/Veiculos")]
    public class NewClass : ControllerBase
    {
        [HttpGet]
        private void Veiculos(){

        }

        [HttpGet("/{id}")]
        private void Veiculo(String id){

        }

        [HttpPost]
        private void Cadastrar(){

        }

        [HttpPut("/{id}")]
        private void ALterarVeiculo(String id){

        }
    }
}