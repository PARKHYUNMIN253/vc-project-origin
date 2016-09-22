// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Threading;

namespace BizOneShot.Light.Models.WebModels
{
    public class ProcMentorGetCompNumSnReturnModel
    {
        public String CP_MP_CODE { get; set; }
        public Int32 COMP_SN { get; set; }
        public Int32 BA_SN { get; set; }
        public String NUM_SN { get; set; }
        public String SUB_NUM_SN { get; set; }
        public String CON_CODE { get; set; }
        public String TYPE_YN { get; set; }
        public String WRITE_YN { get; set; }
        public DateTime? REG_DT { get; set; }
        public DateTime? UPD_DT { get; set; }
        public Int32 BA_LOGIN_KEY { get; set; }
        public Int32 MENTOR_LOGIN_KEY { get; set; }
    }

}
