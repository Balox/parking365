
-- ==================================================
-- CREAR TABLESPACE
-- ==================================================

-- Dar Permisos para crear archivos en la carpeta
-- chown postgres:postgres /home/parking365/data

-- LINUX -----------
-- chown postgres:postgres /home/data

CREATE TABLESPACE tbsp_parking365 OWNER postgres LOCATION '/home/parking365/data';

-- WINDOWS -----------
-- create folder c:/parking365/data
CREATE TABLESPACE tbsp_parking365 OWNER postgres LOCATION 'c:/parking365/data';

