//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GuModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserInformation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Nickname { get; set; }
        public string Realname { get; set; }
        public string ProfilePhoto { get; set; }
        public Nullable<int> Gender { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Contry { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public bool Deleted { get; set; }
    }
}
