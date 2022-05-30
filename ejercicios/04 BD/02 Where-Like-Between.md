# TP Pokemon - WHERE: LIKE & BETWEEN

1) Mostrar `apodo` de los pokémon cuyo `apodo` tenga al menos 2 letras `‘i’`. Ordenar por `apodo` de menor a mayor.

<details>
    <summary>Salida</summary>

| apodo    |
| :---:    |
| Chikito  |
| Chispita |

**2 filas**
</details>

2) Mostrar `nombre` y `dinero` de los entrenadores que tengan entre 10 mil y 15 mil (topes incluidos). Ordenar por `dinero` de mayor a menor y luego por nombre de mayor a menor.

<details>
    <summary>Salida</summary>

| nombre            | dinero |
| :---:             | :---:  |
| magalirodriguez09 | 15000  |
| recalDER          | 10000  |
| luchoxx87         | 10000  |
| ...               | ...    |

**5 filas**

</details>

3) Mostrar `apodo`, `nivel` y `idEntrenador` de los pokémon del entrenador con `idEntrenador` = 1 o de los pokemon con `nivel` mayor a 60. Ordenar por `idEntrenador` y luego por `nivel`, de menor a mayor.

<details>
    <summary>Salida</summary>

| apodo  | nivel  | idEntrenador |
| :---:  | :---:  | :---:        |
| _NULL_ | 44     | 1            |
| _NULL_ | 62     | 1            |
| _NULL_ | 63     | 1            |
| ...    | ...    | ...          |

**21 filas**
</details>

4) Mostrar `apodo` y `nivel` de los pokémon con `nivel` entre 60 y 100 (topes NO incluidos). Ordenar por `nivel` y `apodos`, de menor a mayor.

<details>
    <summary>Salida</summary>

| apodo  | nivel  |
| :---:  | :---:  |
| Koki   | 62     |
| _NULL_ | 63     |
| _NULL_ | 70     |
| ...    | ...    |

**19 filas**
</details>

5) Mostrar `nombre`, `precioVenta` y `precioCompra` de los objetos que terminen con la palabra `'ball'` o empiecen con la palabra `'Piedra'`, siempre y cuando su `precioCompra` se encuentre entre 500 y 2000 (topes incluidos). Ordenar por `nombre` ascendente y los encabezados de las columnas tienen que tener espacio si lo requiere.

<details>
    <summary>Salida</summary>

| nombre     | precio de venta  | precio de compra |
| :---:      | :---:            | :---:            |
| Super Ball | 300              | 600                 |

**1 fila**
</details>

[<< VOLVER](../04%20BD/README.md)
