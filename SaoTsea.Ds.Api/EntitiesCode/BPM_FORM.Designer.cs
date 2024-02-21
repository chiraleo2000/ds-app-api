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

    [Persistent(@"bpm_form")]
    public partial class BPM_FORM : XPLiteObject
    {
        int fFORM_ID;
        [Key]
        [Persistent(@"form_id")]
        public int FORM_ID
        {
            get { return fFORM_ID; }
            set { SetPropertyValue<int>(nameof(FORM_ID), ref fFORM_ID, value); }
        }
        string fFORM_NAME;
        [Size(500)]
        [Persistent(@"form_name")]
        public string FORM_NAME
        {
            get { return fFORM_NAME; }
            set { SetPropertyValue<string>(nameof(FORM_NAME), ref fFORM_NAME, value); }
        }
        string fFORM_IO_ID;
        [Size(24)]
        [Persistent(@"form_io_id")]
        public string FORM_IO_ID
        {
            get { return fFORM_IO_ID; }
            set { SetPropertyValue<string>(nameof(FORM_IO_ID), ref fFORM_IO_ID, value); }
        }
        char fRECORD_STATUS;
        [Persistent(@"record_status")]
        public char RECORD_STATUS
        {
            get { return fRECORD_STATUS; }
            set { SetPropertyValue<char>(nameof(RECORD_STATUS), ref fRECORD_STATUS, value); }
        }
        char fDEL_FLAG;
        [Persistent(@"del_flag")]
        public char DEL_FLAG
        {
            get { return fDEL_FLAG; }
            set { SetPropertyValue<char>(nameof(DEL_FLAG), ref fDEL_FLAG, value); }
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
        string fFORM_CODE;
        [Persistent(@"form_code")]
        public string FORM_CODE
        {
            get { return fFORM_CODE; }
            set { SetPropertyValue<string>(nameof(FORM_CODE), ref fFORM_CODE, value); }
        }
        string fSECTION_CODE;
        [Size(2)]
        [Persistent(@"section_code")]
        public string SECTION_CODE
        {
            get { return fSECTION_CODE; }
            set { SetPropertyValue<string>(nameof(SECTION_CODE), ref fSECTION_CODE, value); }
        }
    }

}
