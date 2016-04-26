select count(*) from transaction.employee_master


Select count(*) from transaction.employee_master where employee_id



select * from transaction.useraccess

select DISTINCT row_number() OVER (ORDER BY employee_status desc) || '.'::text AS sn, initcap(employee_fname)||' '||initcap(employee_mname)||'. '||initcap(employee_lname) as name,initcap(employee_address) as address, employee_gender as gender,employee_phone as contact_num,initcap(case when employee_status = 't' then 'true' else 'false' end) as status ,employee_createdby as created_by,employee_createddate as created_date,employee_editedby as edited_by,employee_editeddate as created_date,employee_id from transaction.employee_master where employee_status = 't' order by sn asc;


select employee_id from transaction.useraccess where username = 'r5OG17pkM6Y=' and password = 'R2Clg9qmSw0=';
select * from transaction.useraccess where employee_id = 'es5311';

insert into transaction.useraccess (employee_id,authorizedby_id,username,password,access_level) values ('1','1','1','1','1')
delete from transaction.useraccess where id = '5'


select count(*) from transaction.useraccess where employee_id = 'es1999';