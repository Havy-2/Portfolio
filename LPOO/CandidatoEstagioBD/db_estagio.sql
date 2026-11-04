CREATE DATABASE IF NOT EXISTS db_estagio;
USE db_estagio;

CREATE TABLE IF NOT EXISTS candidato (
    Id INT NOT NULL AUTO_INCREMENT,
    Nome VARCHAR(100) NOT NULL,
    data_nascimento DATE NOT NULL,
    area_atuacao VARCHAR(40) NOT NULL,
    Matutino TINYINT(1) NOT NULL DEFAULT 0,
    Vespertino TINYINT(1) NOT NULL DEFAULT 0,
    Noturno TINYINT(1) NOT NULL DEFAULT 0,
    Escolaridade VARCHAR(40) NOT NULL,
    data_cadastro DATETIME DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (Id)
);

select * from candidato;