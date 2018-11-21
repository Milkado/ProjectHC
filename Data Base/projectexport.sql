--------------------------------------------------------
--  Arquivo criado - Terça-feira-Novembro-20-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence DEMO_CUST_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."DEMO_CUST_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence DEMO_ORDER_ITEMS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."DEMO_ORDER_ITEMS_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 61 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence DEMO_ORD_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."DEMO_ORD_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 11 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence DEMO_PROD_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."DEMO_PROD_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence DEMO_USERS_SEQ
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."DEMO_USERS_SEQ"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_ALUNO
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_ALUNO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_GRUPO
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_GRUPO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_HORA
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_HORA"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_MODALIDADE
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_MODALIDADE"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_USER
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_USER"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 81 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table ALUNO
--------------------------------------------------------

  CREATE TABLE "PROJECTHC"."ALUNO" 
   (	"ID_ALUNO" NUMBER(*,0), 
	"NOME" VARCHAR2(80 BYTE), 
	"MATRICULA" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table ATIVIDADE
--------------------------------------------------------

  CREATE TABLE "PROJECTHC"."ATIVIDADE" 
   (	"ID_ATIVIDADE" NUMBER(*,0), 
	"ATIVIDADE_REALIZADA" VARCHAR2(80 BYTE), 
	"LOCAL_REALIZ" VARCHAR2(80 BYTE), 
	"DOCUMENTO" VARCHAR2(60 BYTE), 
	"TEMPO" NUMBER(*,0), 
	"ID_GRUPO" NUMBER(*,0), 
	"ID_MODALIDADE" NUMBER(*,0), 
	"ID_ALUNO" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table GRUPO
--------------------------------------------------------

  CREATE TABLE "PROJECTHC"."GRUPO" 
   (	"ID_GRUPO" NUMBER(*,0), 
	"CARGA_MAXIMA" NUMBER(*,0), 
	"DESCRICAO" VARCHAR2(255 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table HORA_COMPLEMENTAR
--------------------------------------------------------

  CREATE TABLE "PROJECTHC"."HORA_COMPLEMENTAR" 
   (	"ID_HORA" NUMBER(*,0), 
	"HORA_TOTAL" NUMBER(*,0), 
	"HORA_VALIDA" NUMBER(*,0), 
	"ID_ALUNO" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table MODALIDADE
--------------------------------------------------------

  CREATE TABLE "PROJECTHC"."MODALIDADE" 
   (	"ID_MODALIDADE" NUMBER(*,0), 
	"COMPROVANTE" VARCHAR2(255 BYTE), 
	"PONT_MAXIMA" NUMBER(*,0), 
	"TIPO_PONT" VARCHAR2(60 BYTE), 
	"ID_GRUPO" NUMBER(*,0), 
	"NOME" VARCHAR2(255 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table TB_USER
--------------------------------------------------------

  CREATE TABLE "PROJECTHC"."TB_USER" 
   (	"ID_USER" NUMBER(*,0), 
	"USER_NAME" VARCHAR2(30 BYTE), 
	"USER_PASSWORD" VARCHAR2(16 BYTE), 
	"NOME_USER" VARCHAR2(60 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into PROJECTHC.ALUNO
SET DEFINE OFF;
Insert into PROJECTHC.ALUNO (ID_ALUNO,NOME,MATRICULA) values ('1','Stephen Hawking','201600456');
Insert into PROJECTHC.ALUNO (ID_ALUNO,NOME,MATRICULA) values ('2','Roger Murtaugh','2017102134');
Insert into PROJECTHC.ALUNO (ID_ALUNO,NOME,MATRICULA) values ('3','Gordon Ramsay','201530456');
Insert into PROJECTHC.ALUNO (ID_ALUNO,NOME,MATRICULA) values ('4','Jorg Ancrath','201800656');
Insert into PROJECTHC.ALUNO (ID_ALUNO,NOME,MATRICULA) values ('5','Jalan Kendeth','201600436');
Insert into PROJECTHC.ALUNO (ID_ALUNO,NOME,MATRICULA) values ('6','George Miller','201700111');
REM INSERTING into PROJECTHC.ATIVIDADE
SET DEFINE OFF;
REM INSERTING into PROJECTHC.GRUPO
SET DEFINE OFF;
Insert into PROJECTHC.GRUPO (ID_GRUPO,CARGA_MAXIMA,DESCRICAO) values ('1','100','Paricipação em Atividades de Ensino');
Insert into PROJECTHC.GRUPO (ID_GRUPO,CARGA_MAXIMA,DESCRICAO) values ('2','100','Participação em eventos de extensção acadêmica');
Insert into PROJECTHC.GRUPO (ID_GRUPO,CARGA_MAXIMA,DESCRICAO) values ('3','100','Participação em Atividades de Pesquisa');
REM INSERTING into PROJECTHC.HORA_COMPLEMENTAR
SET DEFINE OFF;
REM INSERTING into PROJECTHC.MODALIDADE
SET DEFINE OFF;
REM INSERTING into PROJECTHC.TB_USER
SET DEFINE OFF;
Insert into PROJECTHC.TB_USER (ID_USER,USER_NAME,USER_PASSWORD,NOME_USER) values ('1','admin','admin','Administrador');
--------------------------------------------------------
--  DDL for Index PK_ID_MODALIDADES
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTHC"."PK_ID_MODALIDADES" ON "PROJECTHC"."MODALIDADE" ("ID_MODALIDADE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Trigger TRG_ID_ALUNO
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTHC"."TRG_ID_ALUNO" 
    before insert on aluno
    for each row
        begin
            select seq_id_aluno.nextval
            into :new.id_aluno
            from dual;
        end;

/
ALTER TRIGGER "PROJECTHC"."TRG_ID_ALUNO" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_ID_GRUPO
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTHC"."TRG_ID_GRUPO" 
    before insert on grupo
    for each row
    begin
        select seq_id_grupo.nextval
            into :new.id_grupo
            from dual;
    end;

/
ALTER TRIGGER "PROJECTHC"."TRG_ID_GRUPO" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_ID_HORA
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTHC"."TRG_ID_HORA" 
    before insert on hora_complementar
    for each row
        begin
            select seq_id_hora.nextval
            into :new.id_hora
            from dual;
        end;

/
ALTER TRIGGER "PROJECTHC"."TRG_ID_HORA" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_ID_MODALIDADE
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTHC"."TRG_ID_MODALIDADE" 
    before insert on modalidade
    for each row
        begin
            select seq_id_modalidade.nextval
            into :new.id_modalidade
            from dual;
        end;

/
ALTER TRIGGER "PROJECTHC"."TRG_ID_MODALIDADE" ENABLE;
--------------------------------------------------------
--  DDL for Trigger TRG_ID_USER
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "PROJECTHC"."TRG_ID_USER" 
    before insert on tb_user
    for each row
        begin
            select seq_id_user.nextval
            into :new.id_user
            from dual;
        end;

/
ALTER TRIGGER "PROJECTHC"."TRG_ID_USER" ENABLE;
--------------------------------------------------------
--  DDL for Procedure SUM_VALUE
--------------------------------------------------------
set define off;

  CREATE OR REPLACE PROCEDURE "PROJECTHC"."SUM_VALUE" (a_id in int, hora_ativ in int) is
     begin
  update hora_complementar
  set hora_total = (hora_total + hora_ativ), hora_valida  = (hora_valida + hora_ativ) 
  where id_aluno in a_id;

  if sql%rowcount = 0 then
    insert into hora_complementar (hora_total, hora_valida, id_aluno )
    values (hora_ativ, hora_ativ, a_id );
  end if;
end;

/
--------------------------------------------------------
--  DDL for Function CUSTOM_AUTH
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "PROJECTHC"."CUSTOM_AUTH" (p_username in VARCHAR2, p_password in VARCHAR2)
return BOOLEAN
is
  l_password varchar2(4000);
  l_stored_password varchar2(4000);
  l_expires_on date;
  l_count number;
begin
-- First, check to see if the user is in the user table
select count(*) into l_count from demo_users where user_name = p_username;
if l_count > 0 then
  -- First, we fetch the stored hashed password & expire date
  select password, expires_on into l_stored_password, l_expires_on
   from demo_users where user_name = p_username;

  -- Next, we check to see if the user's account is expired
  -- If it is, return FALSE
  if l_expires_on > sysdate or l_expires_on is null then

    -- If the account is not expired, we have to apply the custom hash
    -- function to the password
    l_password := custom_hash(p_username, p_password);

    -- Finally, we compare them to see if they are the same and return
    -- either TRUE or FALSE
    if l_password = l_stored_password then
      return true;
    else
      return false;
    end if;
  else
    return false;
  end if;
else
  -- The username provided is not in the DEMO_USERS table
  return false;
end if;
end;

/
--------------------------------------------------------
--  DDL for Function CUSTOM_HASH
--------------------------------------------------------

  CREATE OR REPLACE FUNCTION "PROJECTHC"."CUSTOM_HASH" (p_username in varchar2, p_password in varchar2)
return varchar2
is
  l_password varchar2(4000);
  l_salt varchar2(4000) := 'I32HEC8FKMF01CEGXAYLL0JJWIBL8C';
begin

-- This function should be wrapped, as the hash algorhythm is exposed here.
-- You can change the value of l_salt or the method of which to call the
-- DBMS_OBFUSCATOIN toolkit, but you much reset all of your passwords
-- if you choose to do this.

l_password := utl_raw.cast_to_raw(dbms_obfuscation_toolkit.md5
  (input_string => p_password || substr(l_salt,10,13) || p_username ||
    substr(l_salt, 4,10)));
return l_password;
end;

/
--------------------------------------------------------
--  Constraints for Table GRUPO
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."GRUPO" MODIFY ("ID_GRUPO" NOT NULL ENABLE);
  ALTER TABLE "PROJECTHC"."GRUPO" ADD PRIMARY KEY ("ID_GRUPO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table MODALIDADE
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."MODALIDADE" ADD CONSTRAINT "PK_ID_MODALIDADES" PRIMARY KEY ("ID_MODALIDADE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "PROJECTHC"."MODALIDADE" MODIFY ("ID_GRUPO" NOT NULL ENABLE);
  ALTER TABLE "PROJECTHC"."MODALIDADE" MODIFY ("ID_MODALIDADE" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table ATIVIDADE
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."ATIVIDADE" ADD PRIMARY KEY ("ID_ATIVIDADE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table HORA_COMPLEMENTAR
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."HORA_COMPLEMENTAR" ADD PRIMARY KEY ("ID_HORA")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS"  ENABLE;
  ALTER TABLE "PROJECTHC"."HORA_COMPLEMENTAR" MODIFY ("ID_HORA" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table ALUNO
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."ALUNO" ADD PRIMARY KEY ("ID_ALUNO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ATIVIDADE
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."ATIVIDADE" ADD CONSTRAINT "FK_ID_ALUNO_ATIV" FOREIGN KEY ("ID_ALUNO")
	  REFERENCES "PROJECTHC"."ALUNO" ("ID_ALUNO") ENABLE;
  ALTER TABLE "PROJECTHC"."ATIVIDADE" ADD CONSTRAINT "FK_ID_GRUPO_ATIVIDADE" FOREIGN KEY ("ID_GRUPO")
	  REFERENCES "PROJECTHC"."GRUPO" ("ID_GRUPO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table HORA_COMPLEMENTAR
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."HORA_COMPLEMENTAR" ADD CONSTRAINT "FK_ID_ALUNO_HORA" FOREIGN KEY ("ID_ALUNO")
	  REFERENCES "PROJECTHC"."ALUNO" ("ID_ALUNO") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table MODALIDADE
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."MODALIDADE" ADD CONSTRAINT "FK_ID_GRUPO" FOREIGN KEY ("ID_GRUPO")
	  REFERENCES "PROJECTHC"."GRUPO" ("ID_GRUPO") ENABLE;
