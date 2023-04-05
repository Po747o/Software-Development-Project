create database app_contato_bd;
use app_contato_bd;

create table contato 
(con_id int not null auto_increment primary key,
con_nome varchar(100) not null,
con_data_nasc date not null,
con_sexo varchar(30) not null,
con_email varchar(100) not null,
con_telefone varchar(30) not null);

insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (1, 'Aluino', '2022/07/06', 'Male', 'atupling0@ucla.edu', '(945) 7817260');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (2, 'Daphne', '2022/05/17', 'Female', 'dcyples1@buzzfeed.com', '(799) 3960240');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (3, 'Laura', '2023/01/18', 'Female', 'lhantusch2@china.com.cn', '(803) 2391565');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (4, 'Martin', '2023/01/19', 'Male', 'mhindenberger3@livejournal.com', '(915) 2864730');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (5, 'Sharai', '2022/07/05', 'Female', 'slambotin4@constantcontact.com', '(372) 4890061');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (6, 'Emmy', '2022/04/28', 'Male', 'ecapstack5@hp.com', '(713) 1481494');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (7, 'Archibaldo', '2022/03/01', 'Male', 'atennison6@netscape.com', '(170) 5741937');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (8, 'Alisha', '2022/06/01', 'Female', 'agummery7@thetimes.co.uk', '(406) 6827210');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (9, 'Tiffani', '2022/11/17', 'Female', 'tmaccambridge8@netlog.com', '(309) 2857340');
insert into contato (con_id, con_nome, con_data_nasc, con_sexo, con_email, con_telefone) values (10, 'Enos', '2022/11/14', 'Male', 'ejiggins9@berkeley.edu', '(936) 2532641');

select * from contato;

delete from contato where (con_nome = "");