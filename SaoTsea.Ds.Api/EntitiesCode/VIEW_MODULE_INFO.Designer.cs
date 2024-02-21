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

    [Persistent(@"view_module_info")]
    public partial class VIEW_MODULE_INFO : XPLiteObject
    {
        int fMODULE_ID;
        [Key]
        [Persistent(@"module_id")]
        public int MODULE_ID
        {
            get { return fMODULE_ID; }
            set { SetPropertyValue<int>(nameof(MODULE_ID), ref fMODULE_ID, value); }
        }
        int? fAPP_ID;
        [Persistent(@"app_id")]
        public int? APP_ID
        {
            get { return fAPP_ID; }
            set { SetPropertyValue<int?>(nameof(APP_ID), ref fAPP_ID, value); }
        }
        string fMODULE_SEQ;
        [Size(10)]
        [Persistent(@"module_seq")]
        public string MODULE_SEQ
        {
            get { return fMODULE_SEQ; }
            set { SetPropertyValue<string>(nameof(MODULE_SEQ), ref fMODULE_SEQ, value); }
        }
        string fMODULE_CODE;
        [Persistent(@"module_code")]
        public string MODULE_CODE
        {
            get { return fMODULE_CODE; }
            set { SetPropertyValue<string>(nameof(MODULE_CODE), ref fMODULE_CODE, value); }
        }
        string fMODULE_NAME;
        [Size(500)]
        [Persistent(@"module_name")]
        public string MODULE_NAME
        {
            get { return fMODULE_NAME; }
            set { SetPropertyValue<string>(nameof(MODULE_NAME), ref fMODULE_NAME, value); }
        }
        string fMODULE_REMARK;
        [Size(5000)]
        [Persistent(@"module_remark")]
        public string MODULE_REMARK
        {
            get { return fMODULE_REMARK; }
            set { SetPropertyValue<string>(nameof(MODULE_REMARK), ref fMODULE_REMARK, value); }
        }
        int fMODULE_PARENT_ID;
        [Persistent(@"module_parent_id")]
        public int MODULE_PARENT_ID
        {
            get { return fMODULE_PARENT_ID; }
            set { SetPropertyValue<int>(nameof(MODULE_PARENT_ID), ref fMODULE_PARENT_ID, value); }
        }
        int fMODULE_LEVEL;
        [Persistent(@"module_level")]
        public int MODULE_LEVEL
        {
            get { return fMODULE_LEVEL; }
            set { SetPropertyValue<int>(nameof(MODULE_LEVEL), ref fMODULE_LEVEL, value); }
        }
        char fMODULE_MAIN_FLAG;
        [Persistent(@"module_main_flag")]
        public char MODULE_MAIN_FLAG
        {
            get { return fMODULE_MAIN_FLAG; }
            set { SetPropertyValue<char>(nameof(MODULE_MAIN_FLAG), ref fMODULE_MAIN_FLAG, value); }
        }
        string fMODULE_URL;
        [Size(500)]
        [Persistent(@"module_url")]
        public string MODULE_URL
        {
            get { return fMODULE_URL; }
            set { SetPropertyValue<string>(nameof(MODULE_URL), ref fMODULE_URL, value); }
        }
        string fMODULE_ICON;
        [Persistent(@"module_icon")]
        public string MODULE_ICON
        {
            get { return fMODULE_ICON; }
            set { SetPropertyValue<string>(nameof(MODULE_ICON), ref fMODULE_ICON, value); }
        }
        char fMODULE_NEW_WINDOW_FLAG;
        [Persistent(@"module_new_window_flag")]
        public char MODULE_NEW_WINDOW_FLAG
        {
            get { return fMODULE_NEW_WINDOW_FLAG; }
            set { SetPropertyValue<char>(nameof(MODULE_NEW_WINDOW_FLAG), ref fMODULE_NEW_WINDOW_FLAG, value); }
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
        int? fUPDATE_USER_ID;
        [Persistent(@"update_user_id")]
        public int? UPDATE_USER_ID
        {
            get { return fUPDATE_USER_ID; }
            set { SetPropertyValue<int?>(nameof(UPDATE_USER_ID), ref fUPDATE_USER_ID, value); }
        }
        DateTime? fUPDATE_DATE;
        [Persistent(@"update_date")]
        public DateTime? UPDATE_DATE
        {
            get { return fUPDATE_DATE; }
            set { SetPropertyValue<DateTime?>(nameof(UPDATE_DATE), ref fUPDATE_DATE, value); }
        }
        string fPARENT_MODULE_NAME;
        [Size(500)]
        [Persistent(@"parent_module_name")]
        public string PARENT_MODULE_NAME
        {
            get { return fPARENT_MODULE_NAME; }
            set { SetPropertyValue<string>(nameof(PARENT_MODULE_NAME), ref fPARENT_MODULE_NAME, value); }
        }
    }

}