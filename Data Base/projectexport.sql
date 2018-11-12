--------------------------------------------------------
--  Arquivo criado - Segunda-feira-Novembro-12-2018   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_ALUNO
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_ALUNO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_GRUPO
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_GRUPO"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_MODALIDADE
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_MODALIDADE"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 21 CACHE 20 NOORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_ID_USER
--------------------------------------------------------

   CREATE SEQUENCE  "PROJECTHC"."SEQ_ID_USER"  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 41 CACHE 20 NOORDER  NOCYCLE ;
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
	"ID_MODALIDADE" NUMBER(*,0)
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
--  DDL for Table MODALIDADE
--------------------------------------------------------

  CREATE TABLE "PROJECTHC"."MODALIDADE" 
   (	"ID_MODALIDADE" NUMBER(*,0), 
	"PONT_MAXIMA" NUMBER(*,0), 
	"TIPO_PONT" VARCHAR2(60 BYTE), 
	"ID_GRUPO" NUMBER(*,0), 
	"NOME" VARCHAR2(255 BYTE), 
	"COMPROVANTE" VARCHAR2(255 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table TB_USER
--------------------------------------------------------

  CREATE TABLE "PROJECTHC"."TB_USER" 
   (	"ID_USER" NUMBER(*,0), 
	"USER_NAME" VARCHAR2(30 BYTE), 
	"USER_PASSWORD" VARCHAR2(16 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into PROJECTHC.ALUNO
SET DEFINE OFF;
REM INSERTING into PROJECTHC.ATIVIDADE
SET DEFINE OFF;
REM INSERTING into PROJECTHC.GRUPO
SET DEFINE OFF;
Insert into PROJECTHC.GRUPO (ID_GRUPO,CARGA_MAXIMA,DESCRICAO) values ('1','100','Paricipa��o em Atividades de Ensino');
Insert into PROJECTHC.GRUPO (ID_GRUPO,CARGA_MAXIMA,DESCRICAO) values ('2','100','Participa��o em eventos de extens�o acad�mica');
Insert into PROJECTHC.GRUPO (ID_GRUPO,CARGA_MAXIMA,DESCRICAO) values ('3','100','Participa��o em Atividades de Pesquisa');
REM INSERTING into PROJECTHC.MODALIDADE
SET DEFINE OFF;
Insert into PROJECTHC.MODALIDADE (ID_MODALIDADE,PONT_MAXIMA,TIPO_PONT,ID_GRUPO,NOME,COMPROVANTE) values ('1','40','CH da discplica','1','Disciplinas Eletivas e/ou nivelamento','Certificado, Declara��o ou
Documento afim atestando
a participa��o com registro
de carga hor�ria.');
Insert into PROJECTHC.MODALIDADE (ID_MODALIDADE,PONT_MAXIMA,TIPO_PONT,ID_GRUPO,NOME,COMPROVANTE) values ('2','40','CH da Discliplina','1','Disciplinas oferecidas por outros cursos do UniFOA','Certificado, Declara��o ou Documento afim atestando a participa��o com registro de carga hor�ria.');
Insert into PROJECTHC.MODALIDADE (ID_MODALIDADE,PONT_MAXIMA,TIPO_PONT,ID_GRUPO,NOME,COMPROVANTE) values ('3','80','CH Certificada','1','Cursos de aperfei�oamento e de aprofundamento acad�mico-profissional','Certificado, Declara��o ou Documento afim atestando a participa��o com registro de carga hor�ria.');
REM INSERTING into PROJECTHC.TB_USER
SET DEFINE OFF;
Insert into PROJECTHC.TB_USER (ID_USER,USER_NAME,USER_PASSWORD) values ('1','admin','admin');
--------------------------------------------------------
--  DDL for Index PK_ID_MODALIDADES
--------------------------------------------------------

  CREATE UNIQUE INDEX "PROJECTHC"."PK_ID_MODALIDADES" ON "PROJECTHC"."MODALIDADE" ("ID_MODALIDADE") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
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
--  Constraints for Table ALUNO
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."ALUNO" ADD PRIMARY KEY ("ID_ALUNO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table GRUPO
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."GRUPO" ADD PRIMARY KEY ("ID_GRUPO")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "PROJECTHC"."GRUPO" MODIFY ("ID_GRUPO" NOT NULL ENABLE);
--------------------------------------------------------
--  Constraints for Table ATIVIDADE
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."ATIVIDADE" ADD PRIMARY KEY ("ID_ATIVIDADE")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
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
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "PROJECTHC"."MODALIDADE" MODIFY ("ID_GRUPO" NOT NULL ENABLE);
  ALTER TABLE "PROJECTHC"."MODALIDADE" MODIFY ("ID_MODALIDADE" NOT NULL ENABLE);
--------------------------------------------------------
--  Ref Constraints for Table ATIVIDADE
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."ATIVIDADE" ADD CONSTRAINT "FK_ID_GRUPO_ATIVIDADE" FOREIGN KEY ("ID_GRUPO")
	  REFERENCES "PROJECTHC"."GRUPO" ("ID_GRUPO") ENABLE;
  ALTER TABLE "PROJECTHC"."ATIVIDADE" ADD CONSTRAINT "FK_ID_MODALIDADE_ATIVIDADE" FOREIGN KEY ("ID_MODALIDADE")
	  REFERENCES "PROJECTHC"."MODALIDADE" ("ID_MODALIDADE") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table MODALIDADE
--------------------------------------------------------

  ALTER TABLE "PROJECTHC"."MODALIDADE" ADD CONSTRAINT "FK_ID_GRUPO" FOREIGN KEY ("ID_GRUPO")
	  REFERENCES "PROJECTHC"."GRUPO" ("ID_GRUPO") ENABLE;
