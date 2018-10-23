
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
INSERT INTO canciones VALUES(1, 'Cancion 01', 10.0, 1)
INSERT INTO canciones VALUES(2, 'Cancion 02', 11.0, 1)
INSERT INTO canciones VALUES(3, 'Cancion 03', 17.0, 1)
INSERT INTO canciones VALUES(4, 'Cancion 11',  3.0, 2)
INSERT INTO canciones VALUES(5, 'Cancion 12', 32.0, 2)
INSERT INTO canciones VALUES(6, 'Cancion 13', 10.0, 2)
INSERT INTO canciones VALUES(7, 'Cancion 21', 10.0, 3)
INSERT INTO canciones VALUES(8, 'Cancion 22', 10.0, 3)
INSERT INTO canciones VALUES(9, 'Cancion 23', 10.0, 3)

-- Tuplas Compras

INSERT INTO compras VALUES(1, 1, '2018-01-11', 23.0)
INSERT INTO compras VALUES(1, 2, '2018-02-19', 30.0)
INSERT INTO compras VALUES(1, 3, '2018-03-03', 30.0)
INSERT INTO compras VALUES(1, 4, '2018-04-21', 31.0)
INSERT INTO compras VALUES(1, 5, '2018-05-24', 30.0)
INSERT INTO compras VALUES(1, 6, '2018-06-07', 40.0)
  
-- Tuplas compra-cancion
INSERT INTO compras_cancion VALUES(1, 1)
INSERT INTO compras_cancion VALUES(4, 1)
INSERT INTO compras_cancion VALUES(8, 1)

INSERT INTO compras_cancion VALUES(3, 2)
INSERT INTO compras_cancion VALUES(4, 2)
INSERT INTO compras_cancion VALUES(1, 2)

INSERT INTO compras_cancion VALUES(7, 3)
INSERT INTO compras_cancion VALUES(3, 3)
INSERT INTO compras_cancion VALUES(4, 3)

INSERT INTO compras_cancion VALUES(6, 4)
INSERT INTO compras_cancion VALUES(2, 4)
INSERT INTO compras_cancion VALUES(7, 4)

INSERT INTO compras_cancion VALUES(8, 5)
INSERT INTO compras_cancion VALUES(9, 5)
INSERT INTO compras_cancion VALUES(6, 5)

INSERT INTO compras_cancion VALUES(6, 6)
INSERT INTO compras_cancion VALUES(7, 6)
INSERT INTO compras_cancion VALUES(8, 6)
INSERT INTO compras_cancion VALUES(9, 6)