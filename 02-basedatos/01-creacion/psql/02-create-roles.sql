-- ==================================================
-- CREAR USER - ROLE
-- ==================================================

-- user for System
CREATE ROLE parkingsystem WITH LOGIN PASSWORD 'SySt3Mp4rk1ng@2O19';

-- user for CallCenter
CREATE ROLE parkingweb WITH LOGIN PASSWORD 'W3bp4rk1ng@2O19';

-- user admin
CREATE ROLE parkingadmin WITH LOGIN PASSWORD '4dM1np4rk1ng@2O19';

-- actualizar clave del postgres
ALTER USER postgres WITH PASSWORD 'Admin@2019';

