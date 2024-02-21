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

    [Persistent(@"view_user_role")]
    public partial class VIEW_USER_ROLE : XPLiteObject
    {
        int fUSER_ROLE_ID;
        [Key]
        [Persistent(@"user_role_id")]
        public int USER_ROLE_ID
        {
            get { return fUSER_ROLE_ID; }
            set { SetPropertyValue<int>(nameof(USER_ROLE_ID), ref fUSER_ROLE_ID, value); }
        }
        int fROLE_ID;
        [Persistent(@"role_id")]
        public int ROLE_ID
        {
            get { return fROLE_ID; }
            set { SetPropertyValue<int>(nameof(ROLE_ID), ref fROLE_ID, value); }
        }
        string fROLE_CODE;
        [Size(50)]
        [Persistent(@"role_code")]
        public string ROLE_CODE
        {
            get { return fROLE_CODE; }
            set { SetPropertyValue<string>(nameof(ROLE_CODE), ref fROLE_CODE, value); }
        }
        int fORG_LV;
        [Persistent(@"org_lv")]
        public int ORG_LV
        {
            get { return fORG_LV; }
            set { SetPropertyValue<int>(nameof(ORG_LV), ref fORG_LV, value); }
        }
        int fUSER_ID;
        [Persistent(@"user_id")]
        public int USER_ID
        {
            get { return fUSER_ID; }
            set { SetPropertyValue<int>(nameof(USER_ID), ref fUSER_ID, value); }
        }
        string fROLE_NAME;
        [Size(255)]
        [Persistent(@"role_name")]
        public string ROLE_NAME
        {
            get { return fROLE_NAME; }
            set { SetPropertyValue<string>(nameof(ROLE_NAME), ref fROLE_NAME, value); }
        }
        string fRECORD_STATUS;
        [Persistent(@"record_status")]
        public string RECORD_STATUS
        {
            get { return fRECORD_STATUS; }
            set { SetPropertyValue<string>(nameof(RECORD_STATUS), ref fRECORD_STATUS, value); }
        }
        string fDEL_FLAG;
        [Persistent(@"del_flag")]
        public string DEL_FLAG
        {
            get { return fDEL_FLAG; }
            set { SetPropertyValue<string>(nameof(DEL_FLAG), ref fDEL_FLAG, value); }
        }
        string fRI_RECORD_STATUS;
        [Persistent(@"ri_record_status")]
        public string RI_RECORD_STATUS
        {
            get { return fRI_RECORD_STATUS; }
            set { SetPropertyValue<string>(nameof(RI_RECORD_STATUS), ref fRI_RECORD_STATUS, value); }
        }
        string fRI_DEL_FLAG;
        [Persistent(@"ri_del_flag")]
        public string RI_DEL_FLAG
        {
            get { return fRI_DEL_FLAG; }
            set { SetPropertyValue<string>(nameof(RI_DEL_FLAG), ref fRI_DEL_FLAG, value); }
        }
        int? fAPP_ID;
        [Persistent(@"app_id")]
        public int? APP_ID
        {
            get { return fAPP_ID; }
            set { SetPropertyValue<int?>(nameof(APP_ID), ref fAPP_ID, value); }
        }
        string fAPP_CODE;
        [Persistent(@"app_code")]
        public string APP_CODE
        {
            get { return fAPP_CODE; }
            set { SetPropertyValue<string>(nameof(APP_CODE), ref fAPP_CODE, value); }
        }
        int fROLE_ORGANIZE_ID;
        [Persistent(@"role_organize_id")]
        public int ROLE_ORGANIZE_ID
        {
            get { return fROLE_ORGANIZE_ID; }
            set { SetPropertyValue<int>(nameof(ROLE_ORGANIZE_ID), ref fROLE_ORGANIZE_ID, value); }
        }
        int fORGANIZE_ROOT_ID;
        [Persistent(@"organize_root_id")]
        public int ORGANIZE_ROOT_ID
        {
            get { return fORGANIZE_ROOT_ID; }
            set { SetPropertyValue<int>(nameof(ORGANIZE_ROOT_ID), ref fORGANIZE_ROOT_ID, value); }
        }
        string fPERSONAL_FULL_NAME;
        [Size(SizeAttribute.Unlimited)]
        [Persistent(@"personal_full_name")]
        public string PERSONAL_FULL_NAME
        {
            get { return fPERSONAL_FULL_NAME; }
            set { SetPropertyValue<string>(nameof(PERSONAL_FULL_NAME), ref fPERSONAL_FULL_NAME, value); }
        }
        string fPOSITION_NAME;
        [Size(500)]
        [Persistent(@"position_name")]
        public string POSITION_NAME
        {
            get { return fPOSITION_NAME; }
            set { SetPropertyValue<string>(nameof(POSITION_NAME), ref fPOSITION_NAME, value); }
        }
        string fORG_NAME;
        [Size(1000)]
        [Persistent(@"org_name")]
        public string ORG_NAME
        {
            get { return fORG_NAME; }
            set { SetPropertyValue<string>(nameof(ORG_NAME), ref fORG_NAME, value); }
        }
        int fPERSONAL_ID;
        [Persistent(@"personal_id")]
        public int PERSONAL_ID
        {
            get { return fPERSONAL_ID; }
            set { SetPropertyValue<int>(nameof(PERSONAL_ID), ref fPERSONAL_ID, value); }
        }
        int fORGANIZE_ID;
        [Persistent(@"organize_id")]
        public int ORGANIZE_ID
        {
            get { return fORGANIZE_ID; }
            set { SetPropertyValue<int>(nameof(ORGANIZE_ID), ref fORGANIZE_ID, value); }
        }
        string fUSER_NAME;
        [Persistent(@"user_name")]
        public string USER_NAME
        {
            get { return fUSER_NAME; }
            set { SetPropertyValue<string>(nameof(USER_NAME), ref fUSER_NAME, value); }
        }
        DateTime fCREATE_DATE;
        [Persistent(@"create_date")]
        public DateTime CREATE_DATE
        {
            get { return fCREATE_DATE; }
            set { SetPropertyValue<DateTime>(nameof(CREATE_DATE), ref fCREATE_DATE, value); }
        }
        DateTime fUPDATE_DATE;
        [Persistent(@"update_date")]
        public DateTime UPDATE_DATE
        {
            get { return fUPDATE_DATE; }
            set { SetPropertyValue<DateTime>(nameof(UPDATE_DATE), ref fUPDATE_DATE, value); }
        }
        int fCREATE_USER_ID;
        [Persistent(@"create_user_id")]
        public int CREATE_USER_ID
        {
            get { return fCREATE_USER_ID; }
            set { SetPropertyValue<int>(nameof(CREATE_USER_ID), ref fCREATE_USER_ID, value); }
        }
        int fUPDATE_USER_ID;
        [Persistent(@"update_user_id")]
        public int UPDATE_USER_ID
        {
            get { return fUPDATE_USER_ID; }
            set { SetPropertyValue<int>(nameof(UPDATE_USER_ID), ref fUPDATE_USER_ID, value); }
        }
    }

}
