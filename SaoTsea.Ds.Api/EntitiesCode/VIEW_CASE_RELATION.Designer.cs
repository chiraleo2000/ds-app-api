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

    [Persistent(@"view_case_relation")]
    public partial class VIEW_CASE_RELATION : XPLiteObject
    {
        int fRELATION_ID;
        [Key]
        [Persistent(@"relation_id")]
        public int RELATION_ID
        {
            get { return fRELATION_ID; }
            set { SetPropertyValue<int>(nameof(RELATION_ID), ref fRELATION_ID, value); }
        }
        int fINST_ID;
        [Persistent(@"inst_id")]
        public int INST_ID
        {
            get { return fINST_ID; }
            set { SetPropertyValue<int>(nameof(INST_ID), ref fINST_ID, value); }
        }
        int fDATA_ID;
        [Persistent(@"data_id")]
        public int DATA_ID
        {
            get { return fDATA_ID; }
            set { SetPropertyValue<int>(nameof(DATA_ID), ref fDATA_ID, value); }
        }
        int fREF_INST_ID;
        [Persistent(@"ref_inst_id")]
        public int REF_INST_ID
        {
            get { return fREF_INST_ID; }
            set { SetPropertyValue<int>(nameof(REF_INST_ID), ref fREF_INST_ID, value); }
        }
        int fRELATION_RATE;
        [Persistent(@"relation_rate")]
        public int RELATION_RATE
        {
            get { return fRELATION_RATE; }
            set { SetPropertyValue<int>(nameof(RELATION_RATE), ref fRELATION_RATE, value); }
        }
        string fRELATION_REMARK;
        [Size(SizeAttribute.Unlimited)]
        [Persistent(@"relation_remark")]
        public string RELATION_REMARK
        {
            get { return fRELATION_REMARK; }
            set { SetPropertyValue<string>(nameof(RELATION_REMARK), ref fRELATION_REMARK, value); }
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
        int fPERSONAL_ID;
        [Persistent(@"personal_id")]
        public int PERSONAL_ID
        {
            get { return fPERSONAL_ID; }
            set { SetPropertyValue<int>(nameof(PERSONAL_ID), ref fPERSONAL_ID, value); }
        }
        int fFLOW_ID;
        [Persistent(@"flow_id")]
        public int FLOW_ID
        {
            get { return fFLOW_ID; }
            set { SetPropertyValue<int>(nameof(FLOW_ID), ref fFLOW_ID, value); }
        }
        int fFORM_ID;
        [Persistent(@"form_id")]
        public int FORM_ID
        {
            get { return fFORM_ID; }
            set { SetPropertyValue<int>(nameof(FORM_ID), ref fFORM_ID, value); }
        }
        string fWF_INSTANCE_ID;
        [Size(50)]
        [Persistent(@"wf_instance_id")]
        public string WF_INSTANCE_ID
        {
            get { return fWF_INSTANCE_ID; }
            set { SetPropertyValue<string>(nameof(WF_INSTANCE_ID), ref fWF_INSTANCE_ID, value); }
        }
        string fWF_DEFINITION_ID;
        [Size(150)]
        [Persistent(@"wf_definition_id")]
        public string WF_DEFINITION_ID
        {
            get { return fWF_DEFINITION_ID; }
            set { SetPropertyValue<string>(nameof(WF_DEFINITION_ID), ref fWF_DEFINITION_ID, value); }
        }
        string fDOCUMENT_ID;
        [Size(50)]
        [Persistent(@"document_id")]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>(nameof(DOCUMENT_ID), ref fDOCUMENT_ID, value); }
        }
        string fGROUP_STATUS_CODE;
        [Size(3)]
        [Persistent(@"group_status_code")]
        public string GROUP_STATUS_CODE
        {
            get { return fGROUP_STATUS_CODE; }
            set { SetPropertyValue<string>(nameof(GROUP_STATUS_CODE), ref fGROUP_STATUS_CODE, value); }
        }
        string fSTATUS_CODE;
        [Size(3)]
        [Persistent(@"status_code")]
        public string STATUS_CODE
        {
            get { return fSTATUS_CODE; }
            set { SetPropertyValue<string>(nameof(STATUS_CODE), ref fSTATUS_CODE, value); }
        }
        string fTRACKING_CODE;
        [Size(30)]
        [Persistent(@"tracking_code")]
        public string TRACKING_CODE
        {
            get { return fTRACKING_CODE; }
            set { SetPropertyValue<string>(nameof(TRACKING_CODE), ref fTRACKING_CODE, value); }
        }
        int fCATEGORY_ID;
        [Persistent(@"category_id")]
        public int CATEGORY_ID
        {
            get { return fCATEGORY_ID; }
            set { SetPropertyValue<int>(nameof(CATEGORY_ID), ref fCATEGORY_ID, value); }
        }
        string fFORM_NAME;
        [Size(500)]
        [Persistent(@"form_name")]
        public string FORM_NAME
        {
            get { return fFORM_NAME; }
            set { SetPropertyValue<string>(nameof(FORM_NAME), ref fFORM_NAME, value); }
        }
        string fFLOW_NAME;
        [Size(500)]
        [Persistent(@"flow_name")]
        public string FLOW_NAME
        {
            get { return fFLOW_NAME; }
            set { SetPropertyValue<string>(nameof(FLOW_NAME), ref fFLOW_NAME, value); }
        }
        string fPERSONAL_FULL_NAME;
        [Size(SizeAttribute.Unlimited)]
        [Persistent(@"personal_full_name")]
        public string PERSONAL_FULL_NAME
        {
            get { return fPERSONAL_FULL_NAME; }
            set { SetPropertyValue<string>(nameof(PERSONAL_FULL_NAME), ref fPERSONAL_FULL_NAME, value); }
        }
        string fCATEGORY_NAME;
        [Size(500)]
        [Persistent(@"category_name")]
        public string CATEGORY_NAME
        {
            get { return fCATEGORY_NAME; }
            set { SetPropertyValue<string>(nameof(CATEGORY_NAME), ref fCATEGORY_NAME, value); }
        }
        string fSTATUS_NAME;
        [Size(200)]
        [Persistent(@"status_name")]
        public string STATUS_NAME
        {
            get { return fSTATUS_NAME; }
            set { SetPropertyValue<string>(nameof(STATUS_NAME), ref fSTATUS_NAME, value); }
        }
    }

}
