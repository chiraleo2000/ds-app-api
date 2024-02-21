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

    [Persistent(@"bpm_proc_inst_appointment")]
    public partial class BPM_PROC_INST_APPOINTMENT : XPLiteObject
    {
        int fAPPOINTMENT_ID;
        [Key(true)]
        [Persistent(@"appointment_id")]
        public int APPOINTMENT_ID
        {
            get { return fAPPOINTMENT_ID; }
            set { SetPropertyValue<int>(nameof(APPOINTMENT_ID), ref fAPPOINTMENT_ID, value); }
        }
        int fINST_ID;
        [Persistent(@"inst_id")]
        public int INST_ID
        {
            get { return fINST_ID; }
            set { SetPropertyValue<int>(nameof(INST_ID), ref fINST_ID, value); }
        }
        int? fAPPOINTMENT_TYPE_ID;
        [Persistent(@"appointment_type_id")]
        public int? APPOINTMENT_TYPE_ID
        {
            get { return fAPPOINTMENT_TYPE_ID; }
            set { SetPropertyValue<int?>(nameof(APPOINTMENT_TYPE_ID), ref fAPPOINTMENT_TYPE_ID, value); }
        }
        DateTime fAPPOINTMENT_DATE;
        [Persistent(@"appointment_date")]
        public DateTime APPOINTMENT_DATE
        {
            get { return fAPPOINTMENT_DATE; }
            set { SetPropertyValue<DateTime>(nameof(APPOINTMENT_DATE), ref fAPPOINTMENT_DATE, value); }
        }
        int? fCONTACT_ID;
        [Persistent(@"contact_id")]
        public int? CONTACT_ID
        {
            get { return fCONTACT_ID; }
            set { SetPropertyValue<int?>(nameof(CONTACT_ID), ref fCONTACT_ID, value); }
        }
        int? fPERSONAL_ID;
        [Persistent(@"personal_id")]
        public int? PERSONAL_ID
        {
            get { return fPERSONAL_ID; }
            set { SetPropertyValue<int?>(nameof(PERSONAL_ID), ref fPERSONAL_ID, value); }
        }
        string fAPPOINTMENT_PERSONAL_TEL_NO;
        [Size(20)]
        [Persistent(@"appointment_personal_tel_no")]
        public string APPOINTMENT_PERSONAL_TEL_NO
        {
            get { return fAPPOINTMENT_PERSONAL_TEL_NO; }
            set { SetPropertyValue<string>(nameof(APPOINTMENT_PERSONAL_TEL_NO), ref fAPPOINTMENT_PERSONAL_TEL_NO, value); }
        }
        string fAPPOINTMENT_DETAIL;
        [Size(SizeAttribute.Unlimited)]
        [Persistent(@"appointment_detail")]
        public string APPOINTMENT_DETAIL
        {
            get { return fAPPOINTMENT_DETAIL; }
            set { SetPropertyValue<string>(nameof(APPOINTMENT_DETAIL), ref fAPPOINTMENT_DETAIL, value); }
        }
        string fAPPOINTMENT_RESULT;
        [Size(SizeAttribute.Unlimited)]
        [Persistent(@"appointment_result")]
        public string APPOINTMENT_RESULT
        {
            get { return fAPPOINTMENT_RESULT; }
            set { SetPropertyValue<string>(nameof(APPOINTMENT_RESULT), ref fAPPOINTMENT_RESULT, value); }
        }
        int fSTATUS_ID;
        [Persistent(@"status_id")]
        public int STATUS_ID
        {
            get { return fSTATUS_ID; }
            set { SetPropertyValue<int>(nameof(STATUS_ID), ref fSTATUS_ID, value); }
        }
        DateTime fAPPOINTMENT_CASE_STATUS_DATETIME;
        [Persistent(@"appointment_case_status_datetime")]
        public DateTime APPOINTMENT_CASE_STATUS_DATETIME
        {
            get { return fAPPOINTMENT_CASE_STATUS_DATETIME; }
            set { SetPropertyValue<DateTime>(nameof(APPOINTMENT_CASE_STATUS_DATETIME), ref fAPPOINTMENT_CASE_STATUS_DATETIME, value); }
        }
        string fAPPOINTMENT_ASSIGNE_STATION;
        [Size(500)]
        [Persistent(@"appointment_assigne_station")]
        public string APPOINTMENT_ASSIGNE_STATION
        {
            get { return fAPPOINTMENT_ASSIGNE_STATION; }
            set { SetPropertyValue<string>(nameof(APPOINTMENT_ASSIGNE_STATION), ref fAPPOINTMENT_ASSIGNE_STATION, value); }
        }
        string fAPPOINTMENT_ALERT_FLAG;
        [Persistent(@"appointment_alert_flag")]
        public string APPOINTMENT_ALERT_FLAG
        {
            get { return fAPPOINTMENT_ALERT_FLAG; }
            set { SetPropertyValue<string>(nameof(APPOINTMENT_ALERT_FLAG), ref fAPPOINTMENT_ALERT_FLAG, value); }
        }
        DateTime fAPPOINTMENT_ALERT_DATE;
        [Persistent(@"appointment_alert_date")]
        public DateTime APPOINTMENT_ALERT_DATE
        {
            get { return fAPPOINTMENT_ALERT_DATE; }
            set { SetPropertyValue<DateTime>(nameof(APPOINTMENT_ALERT_DATE), ref fAPPOINTMENT_ALERT_DATE, value); }
        }
        string fAPPOINTMENT_ALERT_DETAIL;
        [Size(500)]
        [Persistent(@"appointment_alert_detail")]
        public string APPOINTMENT_ALERT_DETAIL
        {
            get { return fAPPOINTMENT_ALERT_DETAIL; }
            set { SetPropertyValue<string>(nameof(APPOINTMENT_ALERT_DETAIL), ref fAPPOINTMENT_ALERT_DETAIL, value); }
        }
        string fAPPOINTMENT_REFER_FLAG;
        [Persistent(@"appointment_refer_flag")]
        public string APPOINTMENT_REFER_FLAG
        {
            get { return fAPPOINTMENT_REFER_FLAG; }
            set { SetPropertyValue<string>(nameof(APPOINTMENT_REFER_FLAG), ref fAPPOINTMENT_REFER_FLAG, value); }
        }
        int fREF_INST_ID;
        [Persistent(@"ref_inst_id")]
        public int REF_INST_ID
        {
            get { return fREF_INST_ID; }
            set { SetPropertyValue<int>(nameof(REF_INST_ID), ref fREF_INST_ID, value); }
        }
        int fCREATE_PERSONAL_ID;
        [Persistent(@"create_personal_id")]
        public int CREATE_PERSONAL_ID
        {
            get { return fCREATE_PERSONAL_ID; }
            set { SetPropertyValue<int>(nameof(CREATE_PERSONAL_ID), ref fCREATE_PERSONAL_ID, value); }
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
        string fDOCUMENT_ID;
        [Size(500)]
        [Persistent(@"document_id")]
        public string DOCUMENT_ID
        {
            get { return fDOCUMENT_ID; }
            set { SetPropertyValue<string>(nameof(DOCUMENT_ID), ref fDOCUMENT_ID, value); }
        }
    }

}