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

    [Persistent(@"cms_position_mng")]
    public partial class CMS_POSITION_MNG : XPLiteObject
    {
        int fPOSITION_MNG_ID;
        [Key(true)]
        [Persistent(@"position_mng_id")]
        public int POSITION_MNG_ID
        {
            get { return fPOSITION_MNG_ID; }
            set { SetPropertyValue<int>(nameof(POSITION_MNG_ID), ref fPOSITION_MNG_ID, value); }
        }
        string fPOSITION_MNG_CODE;
        [Size(500)]
        [Persistent(@"position_mng_code")]
        public string POSITION_MNG_CODE
        {
            get { return fPOSITION_MNG_CODE; }
            set { SetPropertyValue<string>(nameof(POSITION_MNG_CODE), ref fPOSITION_MNG_CODE, value); }
        }
        string fPOSITION_MNG_NAME;
        [Size(SizeAttribute.Unlimited)]
        [Persistent(@"position_mng_name")]
        public string POSITION_MNG_NAME
        {
            get { return fPOSITION_MNG_NAME; }
            set { SetPropertyValue<string>(nameof(POSITION_MNG_NAME), ref fPOSITION_MNG_NAME, value); }
        }
        string fRECORD_STATUS;
        [Persistent(@"record_status")]
        public string RECORD_STATUS
        {
            get { return fRECORD_STATUS; }
            set { SetPropertyValue<string>(nameof(RECORD_STATUS), ref fRECORD_STATUS, value); }
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
        string fDEL_FLAG;
        [Persistent(@"del_flag")]
        public string DEL_FLAG
        {
            get { return fDEL_FLAG; }
            set { SetPropertyValue<string>(nameof(DEL_FLAG), ref fDEL_FLAG, value); }
        }
        string fPOSTION_MNG_STATUS;
        [Persistent(@"postion_mng_status")]
        public string POSTION_MNG_STATUS
        {
            get { return fPOSTION_MNG_STATUS; }
            set { SetPropertyValue<string>(nameof(POSTION_MNG_STATUS), ref fPOSTION_MNG_STATUS, value); }
        }
    }

}
