
-- Tuplas Usuarios
INSERT INTO usuarios VALUES(1, 'em', '123', 'Emilio Mena Garcia')
INSERT INTO usuarios VALUES(2, 'a', '123', 'Usuario A')
INSERT INTO usuarios VALUES(3, 'b', '123', 'Usuario B')

-- Tuplas Artistas
INSERT INTO artistas VALUES(1, 'Artista 1')
INSERT INTO artistas VALUES(2, 'Artista 2')
INSERT INTO artistas VALUES(3, 'Artista 3')

-- Tuplas Albums
INSERT INTO albums VALUES(1, 'Album 1', 1)
INSERT INTO albums VALUES(2, 'Album 2', 2)
INSERT INTO albums VALUES(3, 'Album 3', 3)

-- Tuplas Canciones
INSERT INTO canciones VALUES(1, 'Cancion 01', 1)
INSERT INTO canciones VALUES(2, 'Cancion 02', 1)
INSERT INTO canciones VALUES(3, 'Cancion 03', 1)
INSERT INTO canciones VALUES(4, 'Cancion 11', 2)
INSERT INTO canciones VALUES(5, 'Cancion 12', 2)
INSERT INTO canciones VALUES(6, 'Cancion 13', 2)
INSERT INTO canciones VALUES(7, 'Cancion 21', 3)
INSERT INTO canciones VALUES(8, 'Cancion 22', 3)
INSERT INTO canciones VALUES(9, 'Cancion 23', 3)

-- Tuplas Compras

INSERT INTO compras VALUES(1, 1, FECHA, monto)
  
-- Tuplas compra-cancion
INSERT INTO compras_cancion VALUES(ID_CANCION, ID_COMPRA)