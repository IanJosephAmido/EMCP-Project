using System;
using System.Collections.Generic;
using bggPgSql;
using vallib3._;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_emcp
{
    public class Items
    {
        private string item_id;
        public string Item_id
        {
            get { return item_id; }
            set { item_id = value; }
        }
        private string item_status;
        public string Item_status
        {
            get { return item_status; }
            set { item_status = value; }
        }
        private string item_supplier;
        public string Item_supplier
        {
            get { return item_supplier; }
            set { item_supplier = value; }
        }
        private string item_type;
        public string Item_type
        {
            get { return item_type; }
            set { item_type = value; }
        }
        private string item_discription;
        public string Item_discription
        {
            get { return item_discription; }
            set { item_discription = value; }
        }
        private string item_generic;
        public string Item_generic
        {
            get { return item_generic; }
            set { item_generic = value; }
        }
        private string item_category;
        public string Item_category
        {
            get { return item_category; }
            set { item_category = value; }
        }
        private string item_unit;
        public string Item_unit
        {
            get { return item_unit; }
            set { item_unit = value; }
        }
        private string item_pckunit;
        public string Item_pckunit
        {
            get { return item_pckunit; }
            set { item_pckunit = value; }
        }
        private string item_cseunit;
        public string Item_cseunit
        {
            get { return item_cseunit; }
            set { item_cseunit = value; }
        }
        private string item_pckqty;
        public string Item_pckqty
        {
            get { return item_pckqty; }
            set { item_pckqty = value; }
        }
        private string item_cseqty;
        public string Item_cseqty
        {
            get { return item_cseqty; }
            set { item_cseqty = value; }
        }
        private string item_untprice;
        public string Item_untprice
        {
            get { return item_untprice; }
            set { item_untprice = value; }
        }
        private string item_pckprice;
        public string Item_pckprice
        {
            get { return item_pckprice; }
            set { item_pckprice = value; }
        }
        private string item_cseprice;
        public string Item_cseprice
        {
            get { return item_cseprice; }
            set { item_cseprice = value; }
        }
        private string item_untcost;
        public string Item_untcost
        {
            get { return item_untcost; }
            set { item_untcost = value; }
        }
        private string item_pckcost;
        public string Item_pckcost
        {
            get { return item_pckcost; }
            set { item_pckcost = value; }
        }
        private string item_csecost;
        public string Item_csecost
        {
            get { return item_csecost; }
            set { item_csecost = value; }
        }
        private string item_mrkunit;
        public string Item_mrkunit
        {
            get { return item_mrkunit; }
            set { item_mrkunit = value; }
        }
        private string item_mrkpck;
        public string Item_mrkpck
        {
            get { return item_mrkpck; }
            set { item_mrkpck = value; }
        }
        private string item_mrkcse;
        public string Item_mrkcse
        {
            get { return item_mrkcse; }
            set { item_mrkcse = value; }
        }
        private string item_ebname;
        public string Item_ebname
        {
            get { return item_ebname; }
            set { item_ebname = value; }
        }
        private string item_ebtime;
        public string Item_ebtime
        {
            get { return item_ebtime; }
            set { item_ebtime = value; }
        }
        private string item_edbname;
        public string Item_edbname
        {
            get { return item_edbname; }
            set { item_edbname = value; }
        }
        private string item_edbtime;
        public string Item_edbtime
        {
            get { return item_edbtime; }
            set { item_edbtime = value; }
        }

    }
    public class Query_Items : Items
    {
        bggQueryPgSql MyQuery = new bggQueryPgSql();
        repeatedFunction repfunc = new repeatedFunction();
        string MyString;

        public string GenerateIdNew(string item,Random rnd)
        {
            MyString = "Select count(*) from transaction.item_master where item_id=";
            return repfunc.Generate_IdRandom(MyString, item, rnd);
        }

        public bool insert()
        {
            MyString = "insert into transaction.item_master (item_id,item_status,item_supplier,item_type,item_discription,item_generic,item_category,item_unit,item_pckunit,item_cseunit,item_pckqty,item_cseqty,item_untprice,item_pckprice,item_cseprice,item_untcost,item_pckcost,item_csecost,item_mrkunit,,item_mrkpck,item_mrkcse,item_ebname,item_ebtime,item_edbname,item_edbtime)" +
                       " values ('" + Item_id + "','" + Item_status + "','" + Item_supplier + "','" + Item_type + "','" + Item_discription + "','" + Item_generic + "','" + Item_category + "','" + Item_unit + "','" + Item_pckunit + "','" + Item_cseunit + "','" + Item_pckqty + "','" + Item_cseqty + "','" + Item_untprice + "','" + Item_pckprice + "','" + Item_cseprice + "','" + Item_untcost + "','" + Item_pckcost + "','" + Item_csecost + "','" + Item_mrkunit + "','" + Item_mrkpck + "','" + Item_mrkcse + "','" + Item_ebname + "','" + Item_ebtime + "','" + Item_edbname + "','" + Item_edbtime + "')";
            return MyQuery.InsertUpdateDelete(MyString);
        }

    }





}
