
-- Tabla Usuarios
CREATE TABLE usuarios
( id_usuario     INT NOT NULL PRIMARY KEY,
  email          CHAR(50) NOT NULL,
  contraseña     CHAR(20) NOT NULL,
  nombre         CHAR(20));

-- Tabla Compras
CREATE TABLE compras
( id_cliente      INT NOT NULL REFERENCES usuarios,
  id_compra       INT NOT NULL PRIMARY KEY,
  fecha_compra    DATE,
  monto_total     MONEY ); 

-- Tabla Artistas
CREATE TABLE artistas
( id_artista     INT NOT NULL PRIMARY KEY,
  nombre         CHAR(30) NOT NULL);

-- Tabla Albums
CREATE TABLE albums
( id_album       INT NOT NULL PRIMARY KEY,
  nombre         CHAR(30) NOT NULL,
  id_artista     INT NOT NULL REFERENCES artistas);

-- Tabla Canciones
CREATE TABLE canciones
( id_cancion     INT NOT NULL PRIMARY KEY,
  nombre         char(30) NOT NULL,
  id_album       INT NOT NULL REFERENCES albums);

  
-- Tabla compra-cancion
CREATE TABLE compras_cancion
( id_cancion     INT NOT NULL REFERENCES canciones,
  id_compra      INT NOT NULL REFERENCES compras,
                 PRIMARY KEY (id_cancion, id_compra));