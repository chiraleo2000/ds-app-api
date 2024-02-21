﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SaoTsea.Ds.Api.EntitiesCode
{

    [Persistent(@"adm_user_role")]
    public partial class ADM_USER_ROLE : XPLiteObject
    {
        int fUSER_ROLE_ID;
        [Key(true)]
        [Persistent(@"user_role_id")]
        public int USER_ROLE_ID
        {
            get { return fUSER_ROLE_ID; }
            set { SetPropertyValue<int>(nameof(USER_ROLE_ID), ref fUSER_ROLE_ID, value); }
        }
        int fUSER_ID;
        [Persistent(@"user_id")]
        public int USER_ID
        {
            get { return fUSER_ID; }
            set { SetPropertyValue<int>(nameof(USER_ID), ref fUSER_ID, value); }
        }
        int fROLE_ID;
        [Persistent(@"role_id")]
        public int ROLE_ID
        {
            get { return fROLE_ID; }
            set { SetPropertyValue<int>(nameof(ROLE_ID), ref fROLE_ID, value); }
        }
        string fRECORD_STATUS;
        [Persistent(@"record_status")]
        [ColumnDbDefaultValue("'a'::bpchar")]
        public string RECORD_STATUS
        {
            get { return fRECORD_STATUS; }
            set { SetPropertyValue<string>(nameof(RECORD_STATUS), ref fRECORD_STATUS, value); }
        }
        string fDEL_FLAG;
        [Persistent(@"del_flag")]
        [ColumnDbDefaultValue("'n'::bpchar")]
        public string DEL_FLAG
        {
            get { return fDEL_FLAG; }
            set { SetPropertyValue<string>(nameof(DEL_FLAG), ref fDEL_FLAG, value); }
        }
        int fCREATE_USER_ID;
        [Persistent(@"create_user_id")]
        public int CREATE_USER_ID
        {
            get { return fCREATE_USER_ID; }
            set { SetPropertyValue<int>(nameof(CREATE_USER_ID), ref fCREATE_USER_ID, value); }
        }
        DateTime fCREATE_DATE;
        [Persistent(@"create_date")]
        public DateTime CREATE_DATE
        {
            get { return fCREATE_DATE; }
            set { SetPropertyValue<DateTime>(nameof(CREATE_DATE), ref fCREATE_DATE, value); }
        }
        int fUPDATE_USER_ID;
        [Persistent(@"update_user_id")]
        public int UPDATE_USER_ID
        {
            get { return fUPDATE_USER_ID; }
            set { SetPropertyValue<int>(nameof(UPDATE_USER_ID), ref fUPDATE_USER_ID, value); }
        }
        DateTime fUPDATE_DATE;
        [Persistent(@"update_date")]
        public DateTime UPDATE_DATE
        {
            get { return fUPDATE_DATE; }
            set { SetPropertyValue<DateTime>(nameof(UPDATE_DATE), ref fUPDATE_DATE, value); }
        }
    }

}
