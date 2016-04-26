


select DISTINCT row_number() OVER (ORDER BY a.status desc) || '.'::text AS sn, b.name as category,charge_name,charge_discription,hospital_fee,phic_fee,mc_fee,initcap(case when a.status = 't' then 'true' else 'false' end) as status,a.id as id from transaction.hospital_charges as a,transaction.chargecategory_master as b where a.status = 'True' and a.category_id = b.category_id order by sn asc

select DISTINCT row_number() OVER (ORDER BY a.status desc) || '.'::text AS sn, b.name as category,charge_name,charge_discription,hospital_fee,phic_fee,mc_fee,initcap(case when a.status = 't' then 'true' else 'false' end) as status,a.id as id from transaction.hospital_charges as a,transaction.chargecategory_master as b where a.status = 'True' and a.category_id = b.category_id and b.name = 'Rooms & Board Charges' order by sn asc


select DISTINCT row_number() OVER (ORDER BY p.category desc) || '.'::text AS sn, p.* from (select b.name as category,charge_name,charge_discription,hospital_fee,phic_fee,mc_fee,initcap(case when a.status = 't' then 'true' else 'false' end) as status,a.id as id from transaction.hospital_charges as a,transaction.chargecategory_master as b where a.status = 'True' and a.category_id = b.category_id and b.name = 'Rooms & Board Charges') as p where lower(p.category) like '%sp 1-2%' or lower(p.charge_name) like '%sp 1-2%' order by sn asc



select DISTINCT row_number() OVER (ORDER BY p.name desc,p.*) || '.'::text AS sn, p.* from (select patient_type as type,initcap(patient_fname)||' '||initcap(patient_mname)||' '||initcap(patient_lname) as name,initcap(patient_address1)||' '||initcap(patient_address2) as address,patient_gender as gender,patient_contactnum as contact_num,patient_phicnum as phic_num,patient_mc_insurance as mc_num,patient_id as id from transaction.patient_master where patient_status = '" + stat + "' and patient_type = '" + type + "') as p where lower(p.name) like '%" + tbsearch + "%' or p.contact_num like '%" + tbsearch + "%' order by sn asc;