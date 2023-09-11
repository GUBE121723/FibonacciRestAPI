using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FibonacciRestAPI.Controllers
{
    // Definición de la ruta base para el controlador.
    [Route("api/fibonacci")]
    [ApiController]
    public class FibonacciController : Controller
    {
        // Este método permite calcular el valor de Fibonacci para un índice dado.
        [HttpGet("{n}")]
        public ActionResult<long> GetFibonacci(int n)
        {
            // Verifica si el índice es negativo y responde con un error 400 si lo es.
            if (n < 0)
            {
                return BadRequest("El índice debe ser un número no negativo.");
            }

            // Calcula el valor de Fibonacci utilizando el método privado CalculateFibonacci.
            long result = CalculateFibonacci(n);

            // Responde con el valor calculado en formato JSON y un código de estado 200 (OK).
            return Ok(result);
        }

        // Método privado para calcular el valor de Fibonacci.
        private long CalculateFibonacci(int n)
        {
            // Si el índice es 0 o 1, el valor de Fibonacci es igual al índice mismo.
            if (n <= 1)
            {
                return n;
            }

            // Utiliza una matriz para almacenar los valores de Fibonacci previamente calculados.
            long[] fibArray = new long[n + 1];
            fibArray[0] = 0;
            fibArray[1] = 1;

            // Calcula los valores de Fibonacci iterativamente desde el índice 2 hasta n.
            for (int i = 2; i <= n; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }

            // Retorna el valor de Fibonacci correspondiente al índice n.
            return fibArray[n];
        }
    }    
}
