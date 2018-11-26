create table grupo(
id_grupo int not null primary key,
carga_maxima int,
descricao varchar2(255)
);
create sequence seq_id_grupo start with 1 increment by 1;
create or replace trigger trg_id_grupo
    before insert on grupo
    for each row
    begin
        select seq_id_grupo.nextval
            into :new.id_grupo
            from dual;
    end;
/


create table modalidade(
id_modalidade int not null,
comprovante varchar2(255),
pont_maxima int,
tipo_pont varchar2(60),
id_grupo int not null,
nome varchar2(255),
constraint pk_id_modalidades primary key (id_modalidade),
constraint fk_id_grupo foreign key (id_grupo) references grupo (id_grupo)
);

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

create table hora_complementar(
id_hora int not null primary key,
hora_total int,
hora_valida int,
id_aluno int,
constraint fk_id_aluno_hora foreign key (id_aluno) references aluno(id_aluno)
);
create sequence seq_id_hora start with 1 increment by 1;

create or replace trigger trg_id_hora
    before insert on hora_complementar
    for each row
        begin
            select seq_id_hora.nextval
            into :new.id_hora
            from dual;
        end;
/

create or replace procedure sum_value (a_id in int, hora_ativ in int) is
begin
for c1 in (select * from hora_complementar) loop
    -- Update if record is found.
    update hora_complementar set hora_total = hora_total + hora_ativ, hora_valida = hora_valida + hora_ativ 
    where id_aluno = a_id;
    --If no record found then, Insert.
    if SQL%ROWCOUNT = 0 then
       insert into hora_complementar (id_aluno, hora_total, hora_valida) values (a_id, hora_ativ, hora_ativ);
    end if;
end loop;
commit;
end;
/

insert into aluno (nome, matricula) values ('Stephen Hawking', 201600456);

insert into aluno (nome, matricula) values ('Roger Murtaugh', 2017102134);
insert into aluno (nome, matricula) values ('Gordon Ramsay', 201530456);
insert into aluno (nome, matricula) values ('Jorg Ancrath', 201800656);
insert into aluno (nome, matricula) values ('Jalan Kendeth', 201600436);
insert into aluno (nome, matricula) values ('George Miller', 201700111);
