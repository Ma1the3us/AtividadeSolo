create database dbExemploBanco;
use dbExemploBanco;

CREATE TABLE Usuario(
	Id int primary key auto_increment,
    Nome varchar(50) not null,
    Email varchar(50) not null,
    Senha varchar(50) not null
);


create table Produto(
id int primary key auto_increment,
Nome varchar(40) not null,
Descricao varchar(200),
Quantidade int not null,
Preco numeric(5,2) not null
);
select*from Produto;
SELECT * FROM Usuario;
