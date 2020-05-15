-- ==================================================
-- CREAR DATABASE 
-- cambiar 
-- LC_COLLATE = 'Spanish_Peru.1252'
-- LC_CTYPE = 'Spanish_Peru.1252'
-- ==================================================
-- consultar collation en el server
select  * from pg_database limit 1;

-- linux - ingles
CREATE DATABASE parking_prod
  WITH OWNER = parkingadmin
       ENCODING = 'UTF8'
       TABLESPACE = tbsp_parking365
       LC_COLLATE = 'en_US.UTF-8'
       LC_CTYPE = 'en_US.UTF-8'
       CONNECTION LIMIT = -1;

-- windows - español-peru
CREATE DATABASE parking_prod
  WITH OWNER = parkingadmin
       ENCODING = 'UTF8'
       TABLESPACE = tbsp_parking365
       LC_COLLATE = 'Spanish_Peru.1252'
       LC_CTYPE = 'Spanish_Peru.1252'
       CONNECTION LIMIT = -1;

-- Eliminar base de datos
DROP DATABASE parking_prod;
