# TP Pokemon - Funciones de Fila y Grupo

1) Mostrar todos los `apodos` de los pokemons `atrapados` durante el mes de septiembre del 2021. Ordenar por `apodo` de mayor a menor.

<details>
    <summary>Salida</summary>

| apodo      | atrapado      |
| :---:      | :---:         |
| Xavier     | 2021-09-24    |
| Chispita   | 2021-09-24    |
| Chikito    | 2021-09-24    |
| ...        | ...           |

**18 filas**
</details>

2) Mostrar el `nombre` de todas las especies junto con la cantidad de letras del mismo, siempre y cuando esta cantidad se encuentre entre `5` y `10` letras (topes incluidos). Ordenar por cantidad de letras (mayor a menor) y luego por `nombre` (menor a mayor).
Consejo: para el primer ordenamiento pueden:
  - Copiar y pegar la expresión que hayan usado para la cantidad de letras
  - Asignarle un alias a la expresión y usar ese mismo alias (con las comillas simples incluidas) en el `ORDER BY`.

<details>
    <summary>Salida</summary>

| nombre     | letras |
| :---:      | :---:  |
| Aerodactyl | 10     |
| Bellsprout | 10     |
| Butterfree | 10     |
| ...        | ...    |

**222 filas**

</details>

3) Mostrar cuántos pokemons hay con `idEspecie` igual a `3`.

<details>
    <summary>Salida</summary>

| COUNT(*) |
| :---:    |
| 3        |

**1 fila**
</details>

4) Mostrar el promedio de `nivel` de los pokemons con `idEntrenador` igual a `1`.

<details>
    <summary>Salida</summary>

| AVG(nivel) |
| :---:      |
| 70.1667    |

**1 fila**
</details>

5) Mostrar el promedio de `peso` y `altura` (info. en tabla Especie) de los pokemons con idEntrenador igual a 1 o 3 (info. en la tabla Pokemon).

<details>
    <summary>Salida</summary>

| AVG(peso ) | AVG(altura ) |
| :---:      | :---:        |
| 63.0083    | 1.65         |

**1 fila**
</details>

[<< VOLVER](../04%20BD/README.md)
