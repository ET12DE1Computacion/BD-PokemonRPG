# TP Pokemon - Triggers

1. Realizar un trigger para que cada vez que se inserte una fila en Pokemon, el trigger incremente en 1 los atributos `encuentros` y `atrapados` de la tabla `Pokedex`. En caso de que no exista dicha fila se tiene que insertar con estos atributos con valor `1`.
1. Crear el SP 'Debitar' que reciba por parámetros un idEntrenador y un monto de dinero (`MEDIUMINT`); el SP tiene que debitar (restar) dicho monto al dinero que ya posee el entrenador.
1. Realizar un trigger, para que cada vez que se haga un insert en Mochila, se verifique el el Entrenador correspondiente tenga al menos en `dinero` la suma de `Mochila.cantidad * Objeto.precioCompra` del `Objeto` en cuestión; caso contrario cancelar la operación con la leyenda `'Dinero insuficiente'`.
1. Realizar los triggers necesarios para:
    1. Que cada vez que se confirme un insert en la mochila de un entrenador, debite efectivamente `Mochila.cantidad * Objeto.precioCompra` del saldo del entrenador.
    1. Cada vez que se actualice `Mochila.cantidad` y esta nueva cantidad sea superior a la anterior, debitar la diferencia de `(Mochila.cantidadNueva - Mochila.cantidadVieja) * Objeto.precioCompra` del saldo del entrenador.

[<< VOLVER](README.md)
