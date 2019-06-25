﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZFS.Model
{
    [Serializable]
    public partial class tb_Group 
    {
        #region

        private int _isid;
        private string _GroupCode;
        private string _GroupName;

        #endregion

        [Key]
        public int isid { get { return _isid; } set { _isid = value;  } }
        public string GroupCode { get { return _GroupCode; } set { _GroupCode = value;  } }
        public string GroupName { get { return _GroupName; } set { _GroupName = value;  } }
    }
}
