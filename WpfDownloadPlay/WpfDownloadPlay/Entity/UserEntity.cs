using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDownloadPlay.Entity.Base;
using static WpfDownloadPlay.Entity.EnumForProject;

namespace WpfDownloadPlay.Entity
{


    class UserEntity :BaseDataEntity
    {
        private int userID;
        private int userNumber;
        private string userAccount;
        private string userName;
        private int phoneNumber;
        private string identityCard;//身份证
        private string userAddress;//地址
        private DateTime registrationTime;//注册时间
        private DateTime effectiveTime;//有效时间
        private TimeSpan effectiveTimeSpan;//有效时间间隔
        private Double rechargeMoney;//金额
        private UserSexEnum userSex;//性别
        private UserLevelEnum userLevel;//等级权限

        public int UserID { get => userID; set => userID = value; }
        public int UserNumber { get => userNumber; set => userNumber = value; }
        public string UserName { get => userName; set => userName = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string IdentityCard { get => identityCard; set => identityCard = value; }
        public string UserAddress { get => userAddress; set => userAddress = value; }
        public DateTime RegistrationTime { get => registrationTime; set => registrationTime = value; }
        public DateTime EffectiveTime { get => effectiveTime; set => effectiveTime = value; }
        public TimeSpan EffectiveTimeSpan { get => effectiveTimeSpan; set => effectiveTimeSpan = value; }
        public double RechargeMoney { get => rechargeMoney; set => rechargeMoney = value; }
        public UserSexEnum UserSex { get => userSex; set => userSex = value; }
        public UserLevelEnum UserLevel { get => userLevel; set => userLevel = value; }
        public string UserAccount { get => userAccount; set => userAccount = value; }
    }
}
