# TP Pokemon - Join

1) Mostrar el nombre de los entrenadores junto con el nivel y apodo de sus pokemons(join por `Pokemon.idEntrenador`). Mostrar ordenados por nombre de entrenador y luego por nivel, de menor a mayor.

<details>
    <summary>Salida</summary>

| nombre        | nivel  | apodo    |
| :---:         | :---:  | :---:    |
| abrilchauq    | 13     | Jazmin   |
| abrilchauq    | 26     | _NULL_   |
| abrilchauq    | 47     | _NULL_   |
| ...           | ...    | ...      |

**36 filas**
</details>

2) Mostrar nombre de la especie, nivel y apodo de los pokemons del entrenador con `idEntrenador` igual a 1. Ordenar por `nombre` de especie de mayor a menor.

<details>
    <summary>Salida</summary>

| nombre    | nivel  | apodo    |
| :---:     | :---:  | :---:    |
| Zapdos    | 81     | Chispita |
| Venusaur  | 71     | _NULL_   |
| Venonat   | 63     | _NULL_   |
| ...       | ...    | ...      |

**6 filas**

</details>

3) Mostrar nombre de la especie, altura y nombre del tipo (`Tipo.idtipo`, join por `Especie.idTipo`) de las especies cuya altura sea mayor a 1 metro y peso sea mayor a 20 KG. Ordenar por nombre de especie de menor a mayor.

<details>
    <summary>Salida</summary>

| nombre    | altura | tipo     |
| :---:     | :---:  | :---:    |
| Aerodactyl| 1.8    | Roca     |
| Alakazam  | 1.5    | Psíquico |
| Ampharos  | 1.4    | Eléctrico|
| ...       | ...    | ...      |

**92 filas**

</details>

4) Mostrar nombre y cantidad de los objetos que posee en la mochila el entrenador con `idEntrenador` igual a 1

<details>
    <summary>Salida</summary>

| nombre         | cantidad |
| :---:          | :---:    |
| Poké Ball      | 5        |
| Piedra agua    | 1        |

**2 filas**

</details>

5) Mostrar nombre del entrenador, nivel y apodo de los pokemons que alguna vez atrapó (join por `Pokemon.idEntrenadorOriginal`). Su nivel debe ser mayor a 60 o tener un apodo que comience con `'C'` y termine con la letra `'a'`. Ordenar por nombre de entrenador y luego por nivel de menor a mayor.

<details>
    <summary>Salida</summary>

| nombre     | nivel | apodo   |
| :---:      | :---: | :---:   |
| abrilchauq | 89    | _NULL_  |
| abrilchauq | 97    | _NULL_  |
| Liono02    | 88    | Xavier  |
| ...        | ...   | ...     |

**20 filas**

</details>

[<< VOLVER](../04%20BD/README.md)
