# TP Pokemon - Funciones de Fila y Grupo

1) Mostrar `nombre`  de la especie y pokemons capturados (JOIN con Pokemon) de la misma si la cantidad es mayor o igual a `2`. Ordenar por cantidad de mayor a menor y luego por nombre de mayor a menor.

<details>
    <summary>Salida</summary>

| nombre   | cantidad|
| :---:    | :---:   |
| Venusaur |3        |
| Zapdos   |2        |
| Mewtwo   |2        |
| Magneton |2        |

**4 filas**
</details>

2) Mostrar `nombre`  de los entrenadores y cantidad de pokemons atrapados por el entrenador (JOIN por `Pokemon.idEntrenadorOriginal`) si el `dinero` que poseen estos entrenadores es superior a `500`.

<details>
    <summary>Salida</summary>

| nombre        | cantidad|
| :---:         | :---:   |
| LucasMedina04 | 12      |
| Liono02       | 6       |
| abrilchauq    | 6       |
| ...           | ...     |

**4 filas**
</details>

3) Mostrar el `nombre`  de los objetos junto con la suma de las `cantidades` que se encuentran en las mochilas. Si un entrenador tiene 3 unidades de un objeto y otro 2 unidades de ese mismo objeto, la suma de las cantidades para este objeto es 5. Ordenar por suma de cantidades de mayor a menor.

<details>
    <summary>Salida</summary>

| nombre        | cantidades|
| :---:         | :---:     |
| Super Ball    | 35        |
| Poké Ball     | 34        |
| Piedra agua   | 1         |
| ...           | ...       |

**5 filas**
</details>

4) Mostrar `nombre`  de los tipos (`Tipo.tipo`) junto con el promedio de pesos de las especies (join por `Especie.idTipo`) en las que se encuentra. Solo mostrar los `tipos` que tengan al menos 6 letras o tengan alguna `'F'` en su `nombre`  (`Tipo.tipo`). Ordenar por `tipo` de menor a mayor.

5) Mostrar `nombre`  del entrenador y la suma de los `precios de venta` de los objetos en su mochila (intervienen 3 tablas) si el `dinero` que posee el entrenador es mayor a `500` y la suma de dinero de sus objetos se encuentra entre `100` y `1000` (topes incluidos). Ordenar por suma de menor a mayor.

[<< VOLVER](../04%20BD/README.md)
