create table grupo(
id_grupo int not null primary key,
carga_maxima int,
descricao varchar2(255)
);


drop table grupo;

alter table grupo add
descricao varchar2(255);


create sequence seq_id_grupo start with 1 increment by 1;

drop sequence seq_id_grupo;

create or replace trigger trg_id_grupo
    before insert on grupo
    for each row
    begin
        select seq_id_grupo.nextval
            into :new.id_grupo
            from dual;
    end;
/

insert into grupo(carga_maxima, descricao) values (100, 'Paricipação em Atividades de Ensino');

create table modalidade(
id_modalidade int not null,
descricao varchar2(255),
pont_maxima int,
tipo_pont varchar2(60),
id_grupo int not null,
nome varchar2(255),
constraint pk_id_modalidades primary key (id_modalidade),
constraint fk_id_grupo foreign key (id_grupo) references grupo (id_grupo)
);

drop table modalidade;

alter table modalidade add constraint fk_id_grupo foreign key (id_grupo) references grupo (id_grupo);
create sequence seq_id_modalidade start with 1 increment by 1;
drop sequence seq_id_modalidade;

create or replace trigger trg_id_modalidade
    before insert on modalidade
    for each row
        begin
            select seq_id_modalidade.nextval
            into :new.id_modalidade
            from dual;
        end;
/

insert into modalidade(descricao, pont_maxima, tipo_pont, id_grupo) values ('Disciplinas eletivas e/ou nivelamento', 40, 'CH da discplica', (select id_grupo from grupo where descricao = 'Paricipação em Atividades de Ensino'));

alter table modalidade
add comprovante varchar2(255);

create table tb_user(
id_user int,
user_name varchar2(30),
user_password varchar2(16)
);

create sequence seq_id_user start with 1 increment by 1;

create trigger trg_id_user
    before insert on tb_user
    for each row
        begin
            select seq_id_user.nextval
            into :new.id_user
            from dual;
        end;
/

insert into tb_user(user_name, user_password) values ('admin', 'admin');

update modalidade set nome = 'Disciplinas Eletivas e/ou nivelamento' where id_modalidade = 1;
update modalidade set comprovante = 'Certificado, Declaração ou
Documento afim atestando
a participação com registro
de carga horária.' where id_modalidade = 1;
