API REST de Fibonacci
Esta API REST proporciona un servicio para calcular el valor de la secuencia de Fibonacci correspondiente a un índice dado.

== Uso
La API es accesible a través de HTTP y acepta solicitudes GET en la siguiente ruta:

/api/fibonacci/{n}

Donde {n} es el índice de la secuencia de Fibonacci que deseas calcular. A continuación, se proporcionan ejemplos de uso:

=>Calcular el valor de Fibonacci para el índice 3: GET /api/fibonacci/3

=>Calcular el valor de Fibonacci para el índice 6: GET /api/fibonacci/6

La API responderá con el valor calculado de Fibonacci en formato JSON.

== Respuestas
=>Si la solicitud es válida y se completa correctamente, la API responderá con un código de estado 200 (OK) y el valor de Fibonacci calculado en el cuerpo de la respuesta JSON.

Ejemplo:

{ "value": 8 }

=>Si el índice proporcionado es negativo, la API responderá con un código de estado 400 (Bad Request) y un mensaje de error en formato JSON.

Ejemplo:

{ "error": "El índice debe ser un número no negativo." }

== Ejecución Local
Para ejecutar la API localmente, sigue estos pasos:

Paso 1) Clona el repositorio desde GitHub: https://github.com/GUBE121723/APIFibonacci

Paso 2) Abre el proyecto en Visual Studio o ejecútalo desde la línea de comandos con el comando dotnet run.

La API estará disponible en http://localhost:7271 Nota: El puerto puede variar dependiendo de tu instalación de visual estudio

Puedes acceder a la API utilizando herramientas como Postman o tu navegador web.
