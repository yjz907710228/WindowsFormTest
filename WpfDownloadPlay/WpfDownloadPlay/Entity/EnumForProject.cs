using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDownloadPlay.Entity
{
    public class EnumForProject
    {
        #region 实体类状态
        public enum EntityStateEnum
        {
            异常 = 0,
            正常 = 1
        }
        #endregion

        #region 用户级别
        public enum UserLevelEnum
        {
            超级管理员 = 1,
            管理员 = 2,
            三级VIP用户 = 11,
            二级VIP用户 = 12,
            一级VIP用户 = 13,
            普通用户 = 14,
            拉黑客户 = 15
        }
        #endregion

        #region 性别
        public enum UserSexEnum
        {
            男 = 0,
            女 = 1,
            未输入 = 9
        }
        #endregion


    }
}
