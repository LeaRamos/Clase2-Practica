using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Clase2_Practica.Entidades;

namespace Clase2_Practica.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadorIMCController : ControllerBase
    {
        private readonly Persona _persona;
        private readonly  _personas;

        public CalculadorIMCController(Persona persona) {           
            _persona = persona;
        }
        

        [HttpGet]
        public float CalcularIMCDeUnIndividuo(float peso,float altura)
        {
            float imc = 0f;

            if (peso > 0 && altura > 0) {
                imc =  peso /(altura* altura);
            }
            return imc;
        }
    }
}
