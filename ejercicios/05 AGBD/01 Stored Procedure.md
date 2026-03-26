# TP Pokemon - Procedimientos Almacenados

1. Realizar el SP _altaTipo_ que reciba por parámetro un `tipo` y lo de alta.
1. Realizar el SP _altaEspecie_ que reciba todos los parámetros necesarios para dar de alta una `Especie`.
1. Realizar el SP _compraObjeto_ que recibe por parámetros `idEntrenador`, `idObjeto` y la `cantidad de objetos comprados`. El SP tiene que dar de alta la fila en caso de que no exista o incrementar las unidades si ya existe previamente.
1. Realizar el SP _usarObjeto_ que reciba por parámetro `idEntrenador` y `idObjeto`, el SP tiene que decrementar una unidad la fila correspondiente. En caso de quedar en `cero (0)` unidades, la fila tiene que eliminarse.
1. Realizar el SP _avistar_ cuya acción representa que un determinado `Entrenador` avistó una `Especie`, incrementando su contador encuentros en `1` (_UPDATE_) ó iniciando la fila (_INSERT_) si es que nunca lo avistó. Como último parámetro el SP recibe un booleano llamado `atrapado` que indica si lo atrapó (`TRUE`) ó no (`FALSE`), esto se tiene que tener en cuenta también para el atributo `Pokedex.atrapados`.    
    Ejemplo:
    - No existe fila para `Pokedex` con `idEntrenador = 100` y `idespecie = 25`.
    -
        ```sql
        CALL avistar (100, 25, FALSE);
        ```
    - Ahora **existe** una fila en `Pokedex` (`idEntrenador = 100`, `idEspecie = 25`, `avistado = 1`, `atrapado = 0`).
    -
        ```sql
        CALL avistar (100, 25, TRUE);
        ```
    - La fila en `Pokedex` ahora es (`idEntrenador = 100`, `idEspecie = 25`, `avistado = 2, atrapado = 1`).
    -
        ```sql
        CALL avistar (100, 25, FALSE);
        ```
    - La fila en _Pokedex_ ahora es (`idEntrenador = 100`, `idEspecie = 25`, `avistado = 3`, `atrapado = 1`).