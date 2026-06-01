# Problemas de Conteo
Esta es una aplicación web diseñada para resolver problemas de conteo, relacionados al sistema de conteo de contraseñas y de encontrar caminos minimos en una grilla.

Conceptos implementados:
- Principios fundamentales de conteo.
- Permutaciones y variaciones.
- Combinaciones.
- Principio de Inclusión-Exclusión.
- Restricciones de tipo "al menos uno".
- Caminos minimos en grillas.
- Puntos obligatorios y puntos de bloqueados.

## Capturas

## Tecnologías
- .NET 8
- Blazor
- C#
- MathJax

## Requisitos
- .NET SDK 8.0 o superior

## Instalación

Para ejecutar este proyecto, clone el respositorio:
```bash
git clone https://github.com/DioRB/ProblemasDeConteo.git
```

Ingresa a la carpeta raiz del proyecto
```bash
cd ProblemasDeConteo
```

Restaura 
```bash
dotnet restore
```

Ejecuta

```bash
dotnet run
```

Abra en un navegador la URL dada por la aplicación (normalmente https://localhost:xxxx).

Navegue y seleccione el módulo deseado, los cuales son Contador de contraseñas y Caminos en grilla

(Imagen)

## Instrucciones de uso: Conteo de contraseñas.
1. Ingrese la longitud de la contraseña.
2. Ingrese el tamaño total del alfabeto.
3. Defina los grupos de caracteres.
4. Marque los grupos requeridos.
5. Presione Calcular.

(Imagen Ejemplo numerico)

El resultado muestra la operación aritmetica utilizada (puede fallar con un gran numero de restricciones) y su resultado numérico.

## Instrucciones de uso: Caminos minimos en grilla.
1. Ingrese los valores de base (a) y de altura (b), punto donde se encuentra el destino de la grilla.
2. Presione "Generar Cuadrícula"
3. Visualice los resultados en el caso base (sin puntos obligatorios ni bloqueados) y la respectiva grilla.
4. Seleccione entre Modo Bloqueo y Modo Obligatorio, y coloque puntos a su gusto en la grilla.
5. Abajo observará las explicaciones en las secciones correspondientes de Caminos Obligatorios y Caminos Bloqueados.
6. Experimente distintos tamaños y configuraciones para analizar cómo cambian los resultados.

(Imagen de ejemplo)

El resultado muestra el desarrollo matemático utilizado para calcular la cantidad total de caminos, incluyendo los aportes de los puntos obligatorios y las restricciones impuestas por los puntos bloqueados.


