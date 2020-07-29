using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WpfDownloadPlay.Entity.EnumForProject;

namespace WpfDownloadPlay.Entity.Base
{


    public abstract class BaseDataEntity
    {
        private string remarks;//备注
        private string createBy;//创建者
        private DateTime createDate;//创建日期
        private string updateBy;//修改者
        private string updateDate;//修改日期
        private EntityStateEnum entityState;//状态

        protected string Remarks { get => remarks; set => remarks = value; }
        protected string CreateBy { get => createBy; set => createBy = value; }
        protected DateTime CreateDate { get => createDate; set => createDate = value; }
        protected string UpdateBy { get => updateBy; set => updateBy = value; }
        protected string UpdateDate { get => updateDate; set => updateDate = value; }
        protected EntityStateEnum EntityState { get => entityState; set => entityState = value; }
    }
}
