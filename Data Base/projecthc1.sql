create or replace procedure PROC_SELECT_MODAL(id_csharp in int)
    as tb_modal_return modalidade%TABLETYPE;
    cursor p_cur is
    select id_modalidade, modalidade from modalidade m inner join grupo g on (m.id_modalidade = g.id_grupo) where id_grupo = id_csharp;
    begin
    open p_cur;
        loop
            fetch p_cur into tb_modal_return;
            exit when p_cur%NOTFOUND;
            DBMS_OUTPUT.PUT_LINE(tb_modal_return);
        end loop;
    close p_cur;
    end;