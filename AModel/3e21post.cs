using System;
namespace AModel.post.Entities
{

    public class PostTel
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String oTel { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 cs { get; set; }

    }

    public class Home_xlphuodong_buy
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String orderNo { get; set; }
        public String oTitle { get; set; }
        public DateTime systime { get; set; }
        public Int32 price { get; set; }
        public String username { get; set; }
        public String oTel { get; set; }
        public Int32 oSex { get; set; }
        public String UserIDCard { get; set; }
        public Int32 oStatus { get; set; }
        public Int32 classid { get; set; }
        public Int32 xlpid { get; set; }
        public Int32 hdid { get; set; }
        public Int32 payType { get; set; }
        public Int32 isdel { get; set; }
        public String ccooUser { get; set; }

    }

    public class traffic_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String kindname { get; set; }
        public Int32 total { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public String PathUrl { get; set; }
        public Int32 kindid { get; set; }
        public Int32 viewlev { get; set; }

    }

    public class friend_hjMsg
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 jyType { get; set; }
        public Int32 Age1 { get; set; }
        public Int32 Height1 { get; set; }
        public Int32 education1 { get; set; }
        public Int32 house1 { get; set; }
        public Int32 income1 { get; set; }
        public String oContent { get; set; }
        public String UserName { get; set; }
        public Int32 oSex { get; set; }
        public Int32 Age { get; set; }
        public String Vocation { get; set; }
        public Int32 Height { get; set; }
        public Int32 weight { get; set; }
        public String Home { get; set; }
        public String oTel { get; set; }
        public String oEmail { get; set; }
        public String beizhu { get; set; }
        public Int32 isStatus { get; set; }
        public String IP { get; set; }
        public Int32 isdel { get; set; }
        public DateTime AddTime { get; set; }

    }

    public class job_JZ_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 Pid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }
        public Int32 type { get; set; }
        public String zhiwei_info { get; set; }

    }

    public class xlp_action_log
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 xlpid { get; set; }
        public String label { get; set; }
        public DateTime systime { get; set; }
        public Int32 num { get; set; }

    }

    public class advertise_Kind
    {
        public Int32 kindid { get; set; }
        public Int32 parent { get; set; }
        public String kind { get; set; }
        public Int32 level { get; set; }
        public String explain { get; set; }
        public String kindcode { get; set; }
        public Int32 xhao { get; set; }
        public String companyno { get; set; }
        public Int32 view_lev { get; set; }
        public Int32 isview { get; set; }
        public Int32 isdel { get; set; }
        public Int32 istj { get; set; }
        public Int32 siteID { get; set; }

    }

    public class traffic_kind_auto
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 fid { get; set; }
        public Int32 fid2 { get; set; }
        public String kindname { get; set; }
        public Int32 viewlev { get; set; }
        public Int32 total { get; set; }
        public String username { get; set; }
        public DateTime addtime { get; set; }

    }

    public class post_shoucang
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public String tname { get; set; }
        public Int32 tid { get; set; }
        public String title { get; set; }
        public String url { get; set; }
        public String infokinds { get; set; }
        public DateTime systime { get; set; }

    }

    public class advertise_KindDel
    {
        public Int32 id { get; set; }
        public Int32 delid { get; set; }
        public Int32 siteID { get; set; }

    }

    public class dm_class
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String cname { get; set; }
        public String cinfo { get; set; }
        public Int32 view_lev { get; set; }
        public String op { get; set; }
        public DateTime addtime { get; set; }
        public DateTime uptime { get; set; }
        public Int32 isdel { get; set; }

    }

    public class advertise_PartComp
    {
        public Int32 id { get; set; }
        public String CompName { get; set; }
        public String ComUrl { get; set; }
        public String ComUser { get; set; }
        public String ComTel { get; set; }
        public Int32 Siteid { get; set; }
        public Int32 kindid { get; set; }

    }

    public class Home_QiuGou
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public Int32 Htype { get; set; }
        public Double Mianji { get; set; }
        public Decimal IsMoney { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String wupin { get; set; }
        public String oInfo { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String delPass { get; set; }
        public String delPassOk { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 IsError { get; set; }
        public Int32 isrecom { get; set; }
        public DateTime isrecomtime { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 HXshi { get; set; }
        public Int32 HXting { get; set; }
        public Int32 HXwei { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class Home_Class
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String sName { get; set; }

    }

    public class advertise_kindon
    {
        public Int32 id { get; set; }
        public Int32 kindid { get; set; }
        public Int32 siteid { get; set; }

    }

    public class LocaWeb
    {
        public Int32 id { get; set; }
        public Int32 F_id { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String oWebName { get; set; }
        public String oWebLink { get; set; }
        public String oLinkColor { get; set; }
        public Int32 paixu { get; set; }
        public Int32 did { get; set; }

    }

    public class home_xlpshipin
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 xlpid { get; set; }
        public String title { get; set; }
        public String url { get; set; }
        public String pic { get; set; }
        public Int32 hits { get; set; }
        public DateTime addtime { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsPhone { get; set; }

    }

    public class advertise_more
    {
        public Int32 Moreid { get; set; }
        public Int32 Class1 { get; set; }
        public Int32 Class2 { get; set; }
        public String Attribute { get; set; }
        public Int32 newsflag { get; set; }
        public DateTime uptime { get; set; }
        public String txt1 { get; set; }
        public String txt2 { get; set; }
        public String txt3 { get; set; }
        public String txt4 { get; set; }
        public String txt5 { get; set; }
        public String txt6 { get; set; }
        public String txt7 { get; set; }
        public String txt8 { get; set; }
        public String txt9 { get; set; }
        public String txt10 { get; set; }
        public String txt11 { get; set; }
        public String txt12 { get; set; }
        public String txt13 { get; set; }
        public String txt14 { get; set; }
        public String txt15 { get; set; }

    }

    public class xlpTags
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XlpId { get; set; }
        public String Title { get; set; }
        public Int32 hit { get; set; }
        public Int32 isPx { get; set; }
        public Int32 isShow { get; set; }
        public String Ip { get; set; }

    }

    public class idle_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }
        public Int32 oldkind { get; set; }

    }

    public class advertise_news
    {
        public Int32 id { get; set; }
        public String title { get; set; }
        public String username { get; set; }
        public String area { get; set; }
        public String attribute { get; set; }
        public String price { get; set; }
        public String purl { get; set; }
        public String memo { get; set; }
        public Int32 class1 { get; set; }
        public Int32 class2 { get; set; }
        public DateTime editDate { get; set; }
        public Int32 siteID { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public String phonecall { get; set; }
        public String lanxiren { get; set; }
        public String E_mail { get; set; }
        public Int32 ispass { get; set; }
        public Int32 newsflag { get; set; }
        public Int32 istj { get; set; }
        public String ip { get; set; }
        public String qq { get; set; }
        public Int32 ccoochk { get; set; }
        public String password { get; set; }

    }

    public class idle_cls
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String kindname { get; set; }
        public String PathUrl { get; set; }
        public Int32 total { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }

    }

    public class PostDigg
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public String IsClsName { get; set; }
        public Int32 IsClsID { get; set; }
        public Int32 ClassId { get; set; }
        public String Ip { get; set; }

    }

    public class Home_SetArea
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String sName { get; set; }

    }

    public class area3e21
    {
        public Int32 areaid { get; set; }
        public String area { get; set; }
        public Int32 level { get; set; }
        public Int32 lishu { get; set; }
        public String flag { get; set; }
        public String ename { get; set; }
        public String ename2 { get; set; }
        public String quhao { get; set; }
        public Int32 view_lev { get; set; }

    }

    public class ClassPost
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String IsTypeName { get; set; }
        public Int32 oId { get; set; }
        public String UserName { get; set; }
        public String Content { get; set; }
        public String Ip { get; set; }
        public DateTime AddTime { get; set; }
        public String IsAdmin { get; set; }
        public Int32 IsChk { get; set; }
        public String AddUserName { get; set; }
        public Int32 ReID { get; set; }

    }

    public class sysarticles
    {
        public Int32 artid { get; set; }
        public String creation_script { get; set; }
        public String del_cmd { get; set; }
        public String description { get; set; }
        public String dest_table { get; set; }
        public Int32 filter { get; set; }
        public String filter_clause { get; set; }
        public String ins_cmd { get; set; }
        public String name { get; set; }
        public Int32 objid { get; set; }
        public Int32 pubid { get; set; }
        public Byte pre_creation_cmd { get; set; }
        public Byte status { get; set; }
        public Int32 sync_objid { get; set; }
        public Byte type { get; set; }
        public String upd_cmd { get; set; }
        public Byte[] schema_option { get; set; }
        public String dest_owner { get; set; }
        public Int32 ins_scripting_proc { get; set; }
        public Int32 del_scripting_proc { get; set; }
        public Int32 upd_scripting_proc { get; set; }
        public String custom_script { get; set; }
        public Boolean fire_triggers_on_snapshot { get; set; }

    }

    public class traffic_post
    {
        public Int32 id { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Boolean isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }
        public Int32 ischk { get; set; }

    }

    public class house_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }

    }

    public class house_post
    {
        public Int32 id { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Boolean isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }
        public Int32 ischk { get; set; }

    }

    public class job_jl_view
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 classid { get; set; }
        public DateTime addtime { get; set; }
        public Int32 type { get; set; }

    }

    public class sysarticlecolumns
    {
        public Int32 artid { get; set; }
        public Int32 colid { get; set; }
        public Boolean is_udt { get; set; }
        public Boolean is_xml { get; set; }
        public Boolean is_max { get; set; }

    }

    public class idle_kind_father
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 view_lev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public Int32 total { get; set; }
        public DateTime addtime { get; set; }
        public Int32 kindid { get; set; }

    }

    public class Home_Type
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String sName { get; set; }

    }

    public class dm_info
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 cid { get; set; }
        public Int32 fid { get; set; }
        public String title { get; set; }
        public String pic { get; set; }
        public Int32 view_lev { get; set; }
        public DateTime showtime { get; set; }
        public DateTime systime { get; set; }
        public Int32 snum { get; set; }
        public Int32 isdel { get; set; }

    }

    public class Wz_Dalei
    {
        public Int32 id { get; set; }
        public String name { get; set; }
        public Int32 siteid { get; set; }
        public String pic { get; set; }

    }

    public class house_zone
    {
        public Int32 id { get; set; }
        public String zonename { get; set; }
        public Int32 siteid { get; set; }
        public Int32 view_lev { get; set; }
        public DateTime addtime { get; set; }
        public String username { get; set; }

    }

    public class PostChk
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 UserFabu { get; set; }
        public Int32 ChkJob { get; set; }
        public Int32 ChkFangWu { get; set; }
        public Int32 ChkErShou { get; set; }
        public Int32 ChkCheLiang { get; set; }
        public Int32 ChkShengHuo { get; set; }
        public Int32 ChkShangJi { get; set; }
        public Int32 ChkJiaoYou { get; set; }
        public Int32 ChkPeiXun { get; set; }
        public Int32 JobNum { get; set; }
        public Int32 FangWuNum { get; set; }
        public Int32 ErShouNum { get; set; }
        public Int32 CheLiangNum { get; set; }
        public Int32 ShengHuoNum { get; set; }
        public Int32 ShangJiNum { get; set; }
        public Int32 JiaoYouNum { get; set; }
        public Int32 PeiXunNum { get; set; }
        public String ServicesTel { get; set; }
        public String ServicesQQ { get; set; }
        public String TelMoney { get; set; }
        public String JobTitle { get; set; }
        public String JobKey { get; set; }
        public String JobDesc { get; set; }
        public String FangWuTitle { get; set; }
        public String FangWuKey { get; set; }
        public String FangWuDesc { get; set; }
        public String ShangJiTitle { get; set; }
        public String ShangJiKey { get; set; }
        public String ShangJiDesc { get; set; }
        public String PeiXunTitle { get; set; }
        public String PeiXunKey { get; set; }
        public String PeiXunDesc { get; set; }
        public String ShengHuoTitle { get; set; }
        public String ShengHuoKey { get; set; }
        public String ShengHuoDesc { get; set; }
        public String IndexTitle { get; set; }
        public String IndexKey { get; set; }
        public String IndexDesc { get; set; }
        public String ErShouTitle { get; set; }
        public String ErShouKey { get; set; }
        public String ErShouDesc { get; set; }
        public String CheLiangTitle { get; set; }
        public String CheLiangKey { get; set; }
        public String CheLiangDesc { get; set; }
        public String JiaoYouTitle { get; set; }
        public String JiaoYouKey { get; set; }
        public String JiaoYouDesc { get; set; }
        public String JobCmdInfo { get; set; }
        public String JobMqInfo { get; set; }
        public String ShengHuoCmdInfo { get; set; }
        public String PeiXunCmdInfo { get; set; }
        public String ShangJiCmdInfo { get; set; }
        public String FwCmdInfo { get; set; }
        public String EsCmdInfo { get; set; }
        public String ClCmdInfo { get; set; }
        public String JyCmdInfo { get; set; }
        public Int32 HitType { get; set; }
        public String esshangjiainfo { get; set; }
        public String chshangjiainfo { get; set; }
        public Int32 JobHomeZXType { get; set; }
        public String hjshangjiainfo { get; set; }
        public String zjshangjiainfo { get; set; }
        public Int32 JobHomeZPType { get; set; }
        public Int32 JobJLViewType { get; set; }
        public Int32 JobJLView { get; set; }
        public Int32 JobJLViewRZ { get; set; }
        public Int32 ChkPet { get; set; }
        public Int32 PetNum { get; set; }
        public String petTitle { get; set; }
        public String petKey { get; set; }
        public String petDesc { get; set; }
        public String PetCmdInfo { get; set; }
        public Int32 CheLiangIndexBK { get; set; }
        public Int32 PetIndexBK { get; set; }
        public Int32 BianMinIndexBK { get; set; }
        public String JobJLCmdInfo { get; set; }
        public Int32 JobJlSMS { get; set; }
        public Int32 PostTjSMS { get; set; }
        public String JobRzInfo { get; set; }
        public Int32 JobJLViewMQ { get; set; }
        public Int32 JobNumRz { get; set; }
        public Int32 JobNumMq { get; set; }
        public Int32 JobMSSMSType { get; set; }
        public Int32 JobMSSMS { get; set; }
        public Int32 JobMSSMSRZ { get; set; }
        public Int32 JobMSSMSMQ { get; set; }
        public Int32 liuyanset { get; set; }
        public Int32 zhaopin_liuyanset { get; set; }
        public Int32 fangwu_liuyanset { get; set; }
        public Int32 ershou_liuyanset { get; set; }
        public Int32 cheliang_liuyanset { get; set; }
        public Int32 shenghuo_liuyanset { get; set; }
        public Int32 shangji_liuyanset { get; set; }
        public Int32 jiaoyu_liuyanset { get; set; }
        public Int32 jiaoyou_liuyanset { get; set; }
        public Int32 chongwu_liuyanset { get; set; }
        public String shshangjiainfo { get; set; }
        public Int32 post_shuiyin { get; set; }

    }

    public class job_comp
    {
        public Int32 id { get; set; }
        public Int32 infonum { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public String compname { get; set; }
        public String compaddr { get; set; }
        public Int32 comptrade { get; set; }
        public Int32 compkind { get; set; }
        public Int32 compsize { get; set; }
        public String compinfo { get; set; }
        public DateTime systime { get; set; }
        public DateTime edittime { get; set; }
        public Int32 userType { get; set; }
        public String postRemarks { get; set; }
        public DateTime uptime { get; set; }

    }

    public class Post_Adv
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 IsType { get; set; }
        public String title { get; set; }
        public String url { get; set; }
        public String pic { get; set; }
        public String username { get; set; }
        public DateTime AddTime { get; set; }

    }

    public class sysschemaarticles
    {
        public Int32 artid { get; set; }
        public String creation_script { get; set; }
        public String description { get; set; }
        public String dest_object { get; set; }
        public String name { get; set; }
        public Int32 objid { get; set; }
        public Int32 pubid { get; set; }
        public Byte pre_creation_cmd { get; set; }
        public Int32 status { get; set; }
        public Byte type { get; set; }
        public Byte[] schema_option { get; set; }
        public String dest_owner { get; set; }

    }

    public class house_sell_wuye
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String clsName { get; set; }
        public Int32 cType { get; set; }
        public Int32 view_lev { get; set; }
        public DateTime AddTime { get; set; }
        public String UserName { get; set; }

    }

    public class live_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }
        public Int32 infokind { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 classid2 { get; set; }

    }

    public class job_JZ_user
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ClassId { get; set; }
        public String UserName { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 isView { get; set; }
        public Int32 bz { get; set; }
        public Int32 jlid { get; set; }

    }

    public class sysextendedarticlesview
    {
        public Int32 artid { get; set; }
        public String creation_script { get; set; }
        public String del_cmd { get; set; }
        public String description { get; set; }
        public String dest_table { get; set; }
        public Int32 filter { get; set; }
        public String filter_clause { get; set; }
        public String ins_cmd { get; set; }
        public String name { get; set; }
        public Int32 objid { get; set; }
        public Int32 pubid { get; set; }
        public Byte pre_creation_cmd { get; set; }
        public Int32 status { get; set; }
        public Int32 sync_objid { get; set; }
        public Byte type { get; set; }
        public String upd_cmd { get; set; }
        public Byte[] schema_option { get; set; }
        public String dest_owner { get; set; }
        public Int32 ins_scripting_proc { get; set; }
        public Int32 del_scripting_proc { get; set; }
        public Int32 upd_scripting_proc { get; set; }
        public String custom_script { get; set; }
        public Int32 fire_triggers_on_snapshot { get; set; }

    }

    public class friend_hj
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String title { get; set; }
        public String address { get; set; }
        public String logo { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String QQ { get; set; }
        public String email { get; set; }
        public String map { get; set; }
        public String UpPic { get; set; }
        public String info { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime CmdTime { get; set; }
        public Int32 mapbaruser { get; set; }
        public Int32 skin { get; set; }
        public Int32 KkCountNum7 { get; set; }
        public Int32 KkCountNum30 { get; set; }

    }

    public class Fw_gfdc
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String Quyu { get; set; }
        public Int32 xqid { get; set; }
        public String areazone { get; set; }
        public Int32 Shoufu { get; set; }
        public Int32 Jiage { get; set; }
        public Int32 Manji { get; set; }
        public String Huxing { get; set; }
        public String Hclass { get; set; }
        public String oContent { get; set; }
        public String lcyaoqiu { get; set; }
        public String oTel { get; set; }
        public Int32 zhiye { get; set; }
        public String oUsername { get; set; }
        public Int32 oSex { get; set; }
        public String ip { get; set; }
        public DateTime systime { get; set; }
        public String beizhu { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 fType { get; set; }

    }

    public class job_qiyeku_news
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ClassId { get; set; }
        public String UserName { get; set; }
        public String title { get; set; }
        public String Content { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 hit { get; set; }
        public String laiyuan { get; set; }
        public Int32 Ding { get; set; }
        public Int32 Cai { get; set; }
        public Int32 fromtype { get; set; }

    }

    public class Wz_fiaolei
    {
        public Int32 id { get; set; }
        public String Name { get; set; }
        public Int32 Did { get; set; }
        public Int32 siteid { get; set; }
        public Int32 paixu { get; set; }

    }

    public class syspublications
    {
        public String description { get; set; }
        public String name { get; set; }
        public Int32 pubid { get; set; }
        public Byte repl_freq { get; set; }
        public Byte status { get; set; }
        public Byte sync_method { get; set; }
        public Byte[] snapshot_jobid { get; set; }
        public Boolean independent_agent { get; set; }
        public Boolean immediate_sync { get; set; }
        public Boolean enabled_for_internet { get; set; }
        public Boolean allow_push { get; set; }
        public Boolean allow_pull { get; set; }
        public Boolean allow_anonymous { get; set; }
        public Boolean immediate_sync_ready { get; set; }
        public Boolean allow_sync_tran { get; set; }
        public Boolean autogen_sync_procs { get; set; }
        public Int32 retention { get; set; }
        public Boolean allow_queued_tran { get; set; }
        public Boolean snapshot_in_defaultfolder { get; set; }
        public String alt_snapshot_folder { get; set; }
        public String pre_snapshot_script { get; set; }
        public String post_snapshot_script { get; set; }
        public Boolean compress_snapshot { get; set; }
        public String ftp_address { get; set; }
        public Int32 ftp_port { get; set; }
        public String ftp_subdirectory { get; set; }
        public String ftp_login { get; set; }
        public String ftp_password { get; set; }
        public Boolean allow_dts { get; set; }
        public Boolean allow_subscription_copy { get; set; }
        public Boolean centralized_conflicts { get; set; }
        public Int32 conflict_retention { get; set; }
        public Int32 conflict_policy { get; set; }
        public Int32 queue_type { get; set; }
        public String ad_guidname { get; set; }
        public Int32 backward_comp_level { get; set; }
        public Boolean allow_initialize_from_backup { get; set; }
        public Byte[] min_autonosync_lsn { get; set; }
        public Int32 replicate_ddl { get; set; }
        public Int32 options { get; set; }
        public Int32 originator_id { get; set; }

    }

    public class home_xlpliuyan
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 xlpid { get; set; }
        public String username { get; set; }
        public String title { get; set; }
        public String ip { get; set; }
        public DateTime addtime { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 isdel { get; set; }
        public Int32 fromtype { get; set; }

    }

    public class live_info
    {
        public Int32 Id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public Int32 Infokind { get; set; }
        public String Title { get; set; }
        public String info { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String Password { get; set; }
        public String sh_CompName { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public String updateuser { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 ClassId2 { get; set; }
        public Int32 ClassId2_2 { get; set; }
        public Int32 ClassId2_3 { get; set; }
        public Int32 ClassId2_4 { get; set; }
        public Int32 ClassId2_5 { get; set; }
        public Int32 source { get; set; }
        public String FWarea { get; set; }
        public Int32 areaId { get; set; }
        public String address { get; set; }
        public Int32 DX_1 { get; set; }
        public Int32 DX_2 { get; set; }
        public Int32 DX_3 { get; set; }
        public Int32 DX_4 { get; set; }
        public String FX_1 { get; set; }
        public String Fx_2 { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 OId { get; set; }
        public Int32 EId { get; set; }
        public Int32 BId { get; set; }
        public Int32 IsStatus { get; set; }

    }

    public class job_post
    {
        public Int32 id { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Boolean isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }
        public Int32 ischk { get; set; }

    }

    public class koubei_area
    {
        public Int32 siteid { get; set; }
        public String area1 { get; set; }
        public String area2 { get; set; }
        public String area3 { get; set; }
        public String siteurl { get; set; }

    }

    public class PostPay
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 jobjlpay { get; set; }
        public Int32 isali { get; set; }
        public String alipay1 { get; set; }
        public String alipay2 { get; set; }
        public String alipay3 { get; set; }
        public Int32 IsChinaBank { get; set; }
        public String BankNo { get; set; }
        public String BankKey { get; set; }
        public Int32 BankStyle { get; set; }
        public Int32 PostTjPay { get; set; }

    }

    public class job_hy_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public DateTime systime { get; set; }
        public Int32 oid { get; set; }
        public String username { get; set; }

    }

    public class Home_Zx
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String sName { get; set; }

    }

    public class post_book
    {
        public Int32 id { get; set; }
        public String stable { get; set; }
        public String schar { get; set; }
        public String svar { get; set; }
        public String sinfo { get; set; }
        public Int32 view_lev { get; set; }
        public DateTime systime { get; set; }
        public String username { get; set; }

    }

    public class post_count
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 class1 { get; set; }
        public Int32 class2 { get; set; }
        public Int32 class3 { get; set; }
        public Int32 class4 { get; set; }
        public Int32 class5 { get; set; }
        public Int32 class6 { get; set; }
        public Int32 class642 { get; set; }
        public Int32 class643 { get; set; }
        public Int32 job_Num { get; set; }
        public Int32 jl_Num { get; set; }
        public Int32 es_Num { get; set; }
        public Int32 cl_Num { get; set; }
        public Int32 friend_Num { get; set; }
        public Int32 friend_Num1 { get; set; }
        public Int32 friend_Num2 { get; set; }
        public Int32 friend_Num3 { get; set; }
        public Int32 business_Num { get; set; }
        public Int32 live_Num { get; set; }
        public Int32 Tel_Num { get; set; }
        public Int32 Edu_num { get; set; }
        public Int32 Home_ChuShou_today { get; set; }
        public Int32 Home_ChuZu_today { get; set; }
        public Int32 Home_QiuZu_today { get; set; }
        public Int32 Home_QiuGou_today { get; set; }
        public Int32 job_today { get; set; }
        public Int32 idle_today { get; set; }
        public Int32 Home_ChuShou_today_back { get; set; }
        public Int32 Home_ChuZu_today_back { get; set; }
        public Int32 Home_QiuZu_today_back { get; set; }
        public Int32 Home_QiuGou_today_back { get; set; }
        public Int32 job_today_back { get; set; }
        public Int32 idle_today_back { get; set; }
        public Int32 friend_today_back { get; set; }
        public Int32 business_today_back { get; set; }
        public Int32 live_today_back { get; set; }
        public Int32 edu_today_back { get; set; }
        public Int32 pet_today_back { get; set; }
        public Int32 cl_today_back { get; set; }
        public Int32 jobjl_today_back { get; set; }
        public Int32 Home_Chudui_today_back { get; set; }

    }

    public class qiyezhaopin
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String oTitle { get; set; }
        public String oBigLogo { get; set; }
        public String oSigLogo { get; set; }
        public String oProfile { get; set; }
        public String oAddress { get; set; }
        public String oLinkMan { get; set; }
        public String oLinkTel { get; set; }
        public String oLinkEmail { get; set; }
        public String oLinkQq { get; set; }
        public String UpImg1 { get; set; }
        public String UpImg2 { get; set; }
        public String UpImg3 { get; set; }
        public String UpImg4 { get; set; }
        public String UserPass { get; set; }
        public String oMap { get; set; }
        public Int32 CompHy { get; set; }
        public Int32 CompType { get; set; }
        public Int32 CompSize { get; set; }
        public Int32 oPx { get; set; }
        public DateTime SysTime { get; set; }
        public String CompNameing { get; set; }
        public DateTime CmdTime { get; set; }
        public Int32 skin { get; set; }
        public String website { get; set; }
        public String UpPic { get; set; }
        public Int32 mapbaruser { get; set; }

    }

    public class Fwjj
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 IsType { get; set; }
        public Int32 IsNum1 { get; set; }
        public Int32 IsNum2 { get; set; }
        public Int32 IsNum3 { get; set; }
        public Int32 IsNum4 { get; set; }
        public Int32 IsNum5 { get; set; }
        public DateTime UpTime { get; set; }
        public String Ip { get; set; }
        public String UserName { get; set; }

    }

    public class post_notic
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String title { get; set; }
        public String link { get; set; }
        public DateTime indate { get; set; }

    }

    public class house_sell_post
    {
        public Int32 id { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Boolean isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }
        public Int32 ischk { get; set; }

    }

    public class post_shop
    {
        public Int32 id { get; set; }
        public String shopname { get; set; }
        public String shoppic { get; set; }
        public String shopurl { get; set; }
        public Int32 siteid { get; set; }
        public Int32 view_lev { get; set; }
        public Int32 typeshow { get; set; }
        public DateTime closedate { get; set; }
        public Int32 redmark { get; set; }

    }

    public class Home_xlphuodong_tuangou
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 hit { get; set; }
        public String title { get; set; }
        public String info { get; set; }
        public String youhuiinfo { get; set; }
        public DateTime systime { get; set; }
        public DateTime enddate { get; set; }
        public String tel { get; set; }
        public Int32 xlpid { get; set; }
        public Int32 opx { get; set; }
        public Int32 isdel { get; set; }
        public Int32 isstatus { get; set; }
        public Int32 istype { get; set; }

    }

    public class Home_SheBei
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String sName { get; set; }
        public Int32 istype { get; set; }

    }

    public class friend_info
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Infokind { get; set; }
        public String Title { get; set; }
        public Int32 Age { get; set; }
        public Int32 Sex { get; set; }
        public String Home { get; set; }
        public Int32 education { get; set; }
        public Int32 Height { get; set; }
        public String Vocation { get; set; }
        public Int32 Age1 { get; set; }
        public Int32 Education1 { get; set; }
        public Int32 Height1 { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String info { get; set; }
        public String ip { get; set; }
        public Int32 Ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String Pic { get; set; }
        public String Password { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public String mobile { get; set; }
        public String fax { get; set; }
        public Int32 ishj { get; set; }
        public Int32 hjid { get; set; }
        public Int32 weight { get; set; }
        public Int32 house { get; set; }
        public String star { get; set; }
        public Int32 income { get; set; }
        public Int32 house1 { get; set; }
        public Int32 income1 { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class post_siteid
    {
        public Int32 siteid { get; set; }
        public Int32 hothit { get; set; }

    }

    public class XlpNews_pinglun
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 classid { get; set; }
        public String UserName { get; set; }
        public String Content { get; set; }
        public Int32 Ding { get; set; }
        public DateTime AddTime { get; set; }
        public String IP { get; set; }
        public Int32 reid { get; set; }

    }

    public class ershoujh
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ershouId { get; set; }
        public String oTitle { get; set; }
        public Int32 oMoney { get; set; }
        public Int32 oChengSe { get; set; }
        public String HtmlInfo { get; set; }
        public String oUpLoad { get; set; }
        public String LinkMan { get; set; }
        public String LinkTel { get; set; }
        public String LinkQQ { get; set; }
        public String ip { get; set; }

    }

    public class xlp_msg
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XlpId { get; set; }
        public Int32 TypeId { get; set; }
        public String Tel { get; set; }
        public String UserName { get; set; }
        public String OptInfo { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 hdid { get; set; }
        public Int32 Age { get; set; }

    }

    public class post_tel
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String info { get; set; }
        public String url { get; set; }
        public Int32 view_lev { get; set; }
        public DateTime closedate { get; set; }
        public Int32 redmark { get; set; }
        public String qq { get; set; }
        public String linkurl { get; set; }

    }

    public class User_Sys
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String Title { get; set; }
        public String Info { get; set; }
        public String Type { get; set; }
        public Int32 IdShow { get; set; }
        public String SiteUserName { get; set; }

    }

    public class live_post
    {
        public Int32 id { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Boolean isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }
        public Int32 ischk { get; set; }

    }

    public class SYNC_job_info_1__67
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public DateTime edittime { get; set; }
        public Int32 istj { get; set; }
        public DateTime istjtime { get; set; }
        public Int32 iszc { get; set; }
        public String title { get; set; }
        public Int32 kind { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 valid { get; set; }
        public DateTime validdate { get; set; }
        public Int32 education { get; set; }
        public Int32 record { get; set; }
        public Int32 sex { get; set; }
        public Int32 number { get; set; }
        public Int32 salary { get; set; }
        public String workarea { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public Int32 iserror { get; set; }
        public Int32 ispass { get; set; }
        public Int32 ccoochk { get; set; }
        public String ip { get; set; }
        public Int32 hit { get; set; }
        public String password { get; set; }
        public Int32 IsCmd { get; set; }
        public String compname { get; set; }
        public String Compaddr { get; set; }
        public Int32 Comptrade { get; set; }
        public Int32 compkind { get; set; }
        public Int32 compsize { get; set; }
        public String UpPic { get; set; }
        public Int32 IsExit { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 isdel { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countJl { get; set; }
        public Int32 countRe { get; set; }
        public Int32 areaId { get; set; }
        public String fuli { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 iswpedit { get; set; }
        public Int32 IsVip { get; set; }
        public String VipUserName { get; set; }

    }

    public class site_news
    {
        public Int32 id { get; set; }
        public String title { get; set; }
        public String title1 { get; set; }
        public String author { get; set; }
        public String memo { get; set; }
        public String comf { get; set; }
        public String comfurl { get; set; }
        public String purl { get; set; }
        public DateTime uptime { get; set; }
        public Int32 kind { get; set; }
        public String keys { get; set; }
        public String keys1 { get; set; }
        public Int16 sy { get; set; }
        public Int16 ispic { get; set; }
        public Int16 ishot { get; set; }
        public Int16 istj { get; set; }
        public Int16 isjd { get; set; }
        public Int16 isindex { get; set; }
        public Byte isjz { get; set; }
        public Byte ischk { get; set; }
        public Int32 CompanyNO { get; set; }
        public Int32 siteID { get; set; }
        public Int32 webid { get; set; }
        public Int32 newsCata { get; set; }
        public Int32 newstopic { get; set; }
        public Int32 isout { get; set; }
        public Int32 isFocusNow { get; set; }
        public Int32 postNum { get; set; }
        public Int32 upnum { get; set; }
        public Int32 hit { get; set; }
        public String flashurl { get; set; }
        public Int32 isdel { get; set; }
        public Int32 Ding { get; set; }
        public Int32 Cai { get; set; }

    }

    public class Home_IsMoney
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String sName { get; set; }

    }

    public class job_JZ_info
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public DateTime edittime { get; set; }
        public Int32 istj { get; set; }
        public DateTime istjtime { get; set; }
        public String title { get; set; }
        public Int32 kind { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 sex { get; set; }
        public Int32 number { get; set; }
        public String jzDatelist { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int32 salary { get; set; }
        public Int32 salarytype { get; set; }
        public Int32 paytype { get; set; }
        public String info { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public Int32 areaId { get; set; }
        public String workarea { get; set; }
        public Int32 iserror { get; set; }
        public Int32 ccoochk { get; set; }
        public String ip { get; set; }
        public Int32 hit { get; set; }
        public String password { get; set; }
        public Int32 IsCmd { get; set; }
        public String compname { get; set; }
        public String Compaddr { get; set; }
        public Int32 Comptrade { get; set; }
        public Int32 compkind { get; set; }
        public Int32 compsize { get; set; }
        public String compinfo { get; set; }
        public Int32 IsExit { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 isdel { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countJl { get; set; }
        public Int32 countRe { get; set; }
        public Int32 qzid { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public String VipUserName { get; set; }

    }

    public class Post_Job_Vip_Yzm
    {
        public Int32 id { get; set; }
        public String title { get; set; }
        public DateTime edittime { get; set; }
        public String username { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsExit { get; set; }
        public Int32 alljl { get; set; }
        public Int32 noViewjl { get; set; }
        public Int32 JobName { get; set; }
        public Int32 siteid { get; set; }
        public Int32 ccoochk { get; set; }

    }

    public class house_kind_cz
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }

    }

    public class syssubscriptions
    {
        public Int32 artid { get; set; }
        public Int16 srvid { get; set; }
        public String dest_db { get; set; }
        public Byte status { get; set; }
        public Byte sync_type { get; set; }
        public String login_name { get; set; }
        public Int32 subscription_type { get; set; }
        public Byte[] distribution_jobid { get; set; }
        public Byte[] timestamp { get; set; }
        public Byte update_mode { get; set; }
        public Boolean loopback_detection { get; set; }
        public Boolean queued_reinit { get; set; }
        public Byte nosync_type { get; set; }
        public String srvname { get; set; }

    }

    public class home_xlpanli
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 xlpid { get; set; }
        public String title { get; set; }
        public Int32 yusuan { get; set; }
        public Int32 mianji { get; set; }
        public String huxing { get; set; }
        public String fengge { get; set; }
        public DateTime addtime { get; set; }
        public String dianpu { get; set; }
        public String shejishi { get; set; }
        public String dianpuurl { get; set; }
        public String pic { get; set; }
        public String content { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 isdel { get; set; }
        public String dianputel { get; set; }
        public Int32 ispx { get; set; }
        public Int32 anliid { get; set; }

    }

    public class Job_Vip_AutoTime
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String AutoTime { get; set; }
        public DateTime systime { get; set; }
        public Int32 TypeId { get; set; }
        public Int32 DataId { get; set; }

    }

    public class Home_Money
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String sName { get; set; }

    }

    public class Post_Search
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String title { get; set; }
        public String classname { get; set; }
        public String url { get; set; }
        public String tel { get; set; }
        public String ip { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 infoid { get; set; }

    }

    public class sysarticleupdates
    {
        public Int32 artid { get; set; }
        public Int32 pubid { get; set; }
        public Int32 sync_ins_proc { get; set; }
        public Int32 sync_upd_proc { get; set; }
        public Int32 sync_del_proc { get; set; }
        public Boolean autogen { get; set; }
        public Int32 sync_upd_trig { get; set; }
        public Int32 conflict_tableid { get; set; }
        public Int32 ins_conflict_proc { get; set; }
        public Boolean identity_support { get; set; }

    }

    public class Home_goufangdiaocha
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 stype { get; set; }
        public String gdxiang { get; set; }
        public String zdyxiang { get; set; }
        public String bcshuoming { get; set; }
        public String lcyaoqiu { get; set; }
        public Int32 xqid { get; set; }
        public String xqname { get; set; }
        public Int32 zhiye { get; set; }
        public String username { get; set; }
        public Int32 sex { get; set; }
        public String tel { get; set; }
        public String ip { get; set; }
        public DateTime systime { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 khType { get; set; }
        public String beizhu { get; set; }

    }

    public class traffic_brand_kind
    {
        public Int32 id { get; set; }
        public String kindname { get; set; }
        public String Ename { get; set; }
        public Int32 Fid { get; set; }
        public Int32 viewlev { get; set; }
        public Int32 Levels { get; set; }

    }

    public class site_3e21
    {
        public Int32 siteid { get; set; }
        public String site_name { get; set; }
        public Int32 companyno { get; set; }
        public String weburl { get; set; }
        public Int16 web_type { get; set; }
        public Int16 agenttype { get; set; }
        public String web_dir { get; set; }
        public Int16 site_styleno { get; set; }
        public String city_type { get; set; }
        public Int32 catprono { get; set; }
        public Int32 areano { get; set; }
        public Int16 dsid { get; set; }
        public Int16 sfid { get; set; }
        public Int16 atwhere { get; set; }
        public String areatitle { get; set; }
        public String logo { get; set; }
        public String banner { get; set; }
        public String title { get; set; }
        public String memo { get; set; }
        public Int16 isview { get; set; }
        public Int16 isopen { get; set; }
        public Int16 isjf { get; set; }
        public Int16 isindex { get; set; }
        public Int16 iscity { get; set; }
        public DateTime addtime { get; set; }
        public DateTime viewtime { get; set; }
        public DateTime opentime { get; set; }
        public DateTime jftime { get; set; }
        public DateTime jfendtime { get; set; }
        public String jfusername { get; set; }
        public String yewuyuan { get; set; }
        public String addUsername { get; set; }
        public String zyusername { get; set; }
        public Int16 webState { get; set; }
        public String qq { get; set; }
        public String linkmemo { get; set; }
        public Int32 view_lev { get; set; }
        public DateTime lastAddtime { get; set; }
        public DateTime lastEditime { get; set; }
        public Int16 isout { get; set; }
        public Int16 dlisview { get; set; }
        public Int16 lmisview { get; set; }
        public DateTime lastLoginTime { get; set; }
        public Byte iszhongdian { get; set; }
        public String TitleRed { get; set; }
        public Int32 Money { get; set; }
        public Decimal yingshou { get; set; }
        public Decimal shishou { get; set; }
        public DateTime yujiaoDate { get; set; }
        public Int32 xinyong { get; set; }
        public Int32 atwhere1 { get; set; }
        public String top_name { get; set; }
        public String top_url { get; set; }

    }

    public class post_action_log
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 usertype { get; set; }
        public Int32 tabcls { get; set; }
        public String Tname { get; set; }
        public Int32 Tid { get; set; }
        public String Ttitle { get; set; }
        public Int32 Atype { get; set; }
        public DateTime systime { get; set; }

    }

    public class MSpub_identity_range
    {
        public Int32 objid { get; set; }
        public Int64 range { get; set; }
        public Int64 pub_range { get; set; }
        public Int64 current_pub_range { get; set; }
        public Int32 threshold { get; set; }
        public Int64 last_seed { get; set; }

    }

    public class house_sell_zone
    {
        public Int32 id { get; set; }
        public String zonename { get; set; }
        public Int32 siteid { get; set; }
        public Int32 view_lev { get; set; }
        public DateTime addtime { get; set; }
        public String username { get; set; }

    }

    public class job_kind_fuli
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 ispx { get; set; }
        public String kindname { get; set; }
        public DateTime systime { get; set; }
        public String username { get; set; }

    }

    public class Home_ChuZu
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public String areazone { get; set; }
        public String Htype { get; set; }
        public Int32 LouNum { get; set; }
        public Int32 IsLouNum { get; set; }
        public String wupin { get; set; }
        public Double Mianji { get; set; }
        public Decimal MoneyNum { get; set; }
        public Int32 MoneyType { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String oInfo { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String UpImg1 { get; set; }
        public String UpImg2 { get; set; }
        public String UpImg3 { get; set; }
        public String UpImg4 { get; set; }
        public String oVideo { get; set; }
        public String oMap { get; set; }
        public Int32 OnlineIsCmd { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 IsStatus { get; set; }
        public String IsNum { get; set; }
        public String delPass { get; set; }
        public String delPassOk { get; set; }
        public Int32 IsZj { get; set; }
        public Int32 ZjId { get; set; }
        public Int32 xqId { get; set; }
        public Int32 Digg1 { get; set; }
        public Int32 Digg2 { get; set; }
        public Int32 Digg3 { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public String Pic { get; set; }
        public Int32 IsRecom { get; set; }
        public DateTime IsRecomTime { get; set; }
        public Int32 IsListTop { get; set; }
        public Int32 IsError { get; set; }
        public String direction { get; set; }
        public Int32 mapsite { get; set; }
        public String ZJBeizhu { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 zjTj { get; set; }
        public DateTime zjTjtime { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 HXshi { get; set; }
        public Int32 HXting { get; set; }
        public Int32 HXwei { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 isautoup { get; set; }

    }

    public class systranschemas
    {
        public Int32 tabid { get; set; }
        public Byte[] startlsn { get; set; }
        public Byte[] endlsn { get; set; }
        public Int32 typeid { get; set; }

    }

    public class xlp_zygw
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 xlpid { get; set; }
        public String title { get; set; }
        public String pic { get; set; }
        public String sex { get; set; }
        public String tel { get; set; }
        public DateTime addtime { get; set; }
        public Int32 viewlev { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 isdel { get; set; }
        public String qq { get; set; }

    }

    public class Home_QiuZu
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public Int32 Htype { get; set; }
        public Double Mianji { get; set; }
        public Decimal IsMoney { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String wupin { get; set; }
        public String oInfo { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String delPass { get; set; }
        public String delPassOk { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 IsError { get; set; }
        public Int32 isrecom { get; set; }
        public DateTime isrecomtime { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 HXshi { get; set; }
        public Int32 HXting { get; set; }
        public Int32 HXwei { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class MSpeer_lsns
    {
        public Int32 id { get; set; }
        public DateTime last_updated { get; set; }
        public String originator { get; set; }
        public String originator_db { get; set; }
        public String originator_publication { get; set; }
        public Int32 originator_publication_id { get; set; }
        public Int32 originator_db_version { get; set; }
        public Byte[] originator_lsn { get; set; }
        public Int32 originator_version { get; set; }
        public Int32 originator_id { get; set; }

    }

    public class xlp_jiage
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XlpId { get; set; }
        public DateTime DateMonth { get; set; }
        public Int32 Money { get; set; }
        public String Info { get; set; }
        public DateTime AddTime { get; set; }

    }

    public class XlpNews
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ClassId { get; set; }
        public String UserName { get; set; }
        public String title { get; set; }
        public String Content { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 hit { get; set; }
        public String laiyuan { get; set; }
        public Int32 Ding { get; set; }
        public Int32 Cai { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 infotype { get; set; }

    }

    public class ershou_sj
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String oTitle { get; set; }
        public String oAddRess { get; set; }
        public String oLogo { get; set; }
        public String oInfo { get; set; }
        public String oLinkP { get; set; }
        public String oTel { get; set; }
        public String oQQ { get; set; }
        public String oEmail { get; set; }
        public String oMap { get; set; }
        public String UserPass { get; set; }
        public Int32 oPx { get; set; }
        public DateTime CmdTime { get; set; }
        public Int32 mapbaruser { get; set; }
        public String oBigLogo { get; set; }
        public String UpPic { get; set; }

    }

    public class Home_xlphuodong_tgbm
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 xlpid { get; set; }
        public Int32 huodongid { get; set; }
        public String linkman { get; set; }
        public String linktel { get; set; }
        public Int32 linksex { get; set; }
        public DateTime systime { get; set; }
        public Int32 istype { get; set; }
        public String ip { get; set; }

    }

    public class Job_jl_sc
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String jlid { get; set; }
        public DateTime systime { get; set; }

    }

    public class house_sell_backup
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public DateTime systime { get; set; }
        public String username { get; set; }
        public String title { get; set; }
        public String info { get; set; }
        public String url { get; set; }
        public String pic { get; set; }
        public DateTime updatetime { get; set; }
        public String address { get; set; }
        public String tel { get; set; }
        public Int32 price { get; set; }
        public Int32 state { get; set; }
        public String beizhu { get; set; }
        public DateTime opendate { get; set; }
        public String Location { get; set; }
        public Int32 Area { get; set; }
        public String Developers { get; set; }
        public String Tenement { get; set; }
        public String Enddate { get; set; }
        public String Wupin { get; set; }
        public String Pic2 { get; set; }
        public String Way { get; set; }
        public String Map { get; set; }
        public String Video { get; set; }
        public Int32 Hit { get; set; }
        public Int32 IsState { get; set; }
        public Int32 TuanGou { get; set; }
        public Int32 IsCmd { get; set; }

    }

    public class Home_gfdcWenti
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String wtTitle { get; set; }
        public Int32 wtType { get; set; }
        public String username { get; set; }
        public Int32 selNum { get; set; }
        public Int32 ispx { get; set; }
        public Int32 fid { get; set; }
        public DateTime systime { get; set; }

    }

    public class MSpeer_request
    {
        public Int32 id { get; set; }
        public String publication { get; set; }
        public DateTime sent_date { get; set; }
        public String description { get; set; }

    }

    public class MSpeer_response
    {
        public Int32 request_id { get; set; }
        public String peer { get; set; }
        public String peer_db { get; set; }
        public DateTime received_date { get; set; }

    }

    public class FwCsMoney
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String sName { get; set; }

    }

    public class MSpeer_topologyrequest
    {
        public Int32 id { get; set; }
        public String publication { get; set; }
        public DateTime sent_date { get; set; }

    }

    public class job_info
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public DateTime edittime { get; set; }
        public Int32 istj { get; set; }
        public DateTime istjtime { get; set; }
        public Int32 iszc { get; set; }
        public String title { get; set; }
        public Int32 kind { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 valid { get; set; }
        public DateTime validdate { get; set; }
        public Int32 education { get; set; }
        public Int32 record { get; set; }
        public Int32 sex { get; set; }
        public Int32 number { get; set; }
        public Int32 salary { get; set; }
        public String info { get; set; }
        public String workarea { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public Int32 iserror { get; set; }
        public Int32 ispass { get; set; }
        public Int32 ccoochk { get; set; }
        public String ip { get; set; }
        public Int32 hit { get; set; }
        public String password { get; set; }
        public Int32 IsCmd { get; set; }
        public String compname { get; set; }
        public String Compaddr { get; set; }
        public Int32 Comptrade { get; set; }
        public Int32 compkind { get; set; }
        public Int32 compsize { get; set; }
        public String compinfo { get; set; }
        public String UpPic { get; set; }
        public Int32 IsExit { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 isdel { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countJl { get; set; }
        public Int32 countRe { get; set; }
        public Int32 areaId { get; set; }
        public String fuli { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 iswpedit { get; set; }
        public Int32 IsVip { get; set; }
        public String VipUserName { get; set; }

    }

    public class post_qqQun
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String qqNum { get; set; }
        public String qqQunName { get; set; }
        public Int32 view_lev { get; set; }
        public String tabName { get; set; }
        public String UserName { get; set; }
        public String qqLink { get; set; }

    }

    public class MSpeer_topologyresponse
    {
        public Int32 request_id { get; set; }
        public String peer { get; set; }
        public Int32 peer_version { get; set; }
        public String peer_db { get; set; }
        public Int32 originator_id { get; set; }
        public Int32 peer_conflict_retention { get; set; }
        public DateTime received_date { get; set; }
        public String connection_info { get; set; }

    }

    public class xlp_yybm
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 xlpId { get; set; }
        public String UserName { get; set; }
        public String title { get; set; }
        public String tel { get; set; }
        public DateTime yydate { get; set; }
        public String info { get; set; }
        public DateTime addtime { get; set; }
        public Int32 isStatus { get; set; }
        public String beizhu { get; set; }
        public String ip { get; set; }

    }

    public class job_lt_kind
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String kindname { get; set; }
        public Int32 viewlev { get; set; }
        public DateTime AddTime { get; set; }

    }

    public class chk_qq
    {
        public Int64 qq { get; set; }

    }

    public class MSpeer_originatorid_history
    {
        public String originator_publication { get; set; }
        public Int32 originator_id { get; set; }
        public String originator_node { get; set; }
        public String originator_db { get; set; }
        public Int32 originator_db_version { get; set; }
        public Int32 originator_version { get; set; }
        public DateTime inserted_date { get; set; }

    }

    public class cheliang_chMsg
    {
        public Int32 Id { get; set; }
        public Int32 Siteid { get; set; }
        public Int32 ClassId { get; set; }
        public String Username { get; set; }
        public Int32 oSex { get; set; }
        public String oTel { get; set; }
        public String oEmail { get; set; }
        public String oContent { get; set; }
        public String ip { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 zhiye { get; set; }
        public Int32 clType { get; set; }
        public Int32 Jiage { get; set; }
        public Int32 LicenseSell { get; set; }
        public Int32 color { get; set; }
        public Int32 licheng { get; set; }
        public String beizhu { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 isdel { get; set; }

    }

    public class house_sell
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public DateTime systime { get; set; }
        public String username { get; set; }
        public String title { get; set; }
        public String info { get; set; }
        public String url { get; set; }
        public String pic { get; set; }
        public DateTime updatetime { get; set; }
        public String address { get; set; }
        public String tel { get; set; }
        public Int32 price { get; set; }
        public Int32 state { get; set; }
        public String beizhu { get; set; }
        public DateTime opendate { get; set; }
        public String Location { get; set; }
        public Int32 Area { get; set; }
        public String Developers { get; set; }
        public String Tenement { get; set; }
        public String Enddate { get; set; }
        public String Wupin { get; set; }
        public String Pic2 { get; set; }
        public String Way { get; set; }
        public String Map { get; set; }
        public String Video { get; set; }
        public Int32 Hit { get; set; }
        public Int32 IsState { get; set; }
        public Int32 TuanGou { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 IsLine { get; set; }
        public String wuyemoney { get; set; }
        public String rongjilv { get; set; }
        public String lvhua { get; set; }
        public String chewei { get; set; }
        public String jiaotong { get; set; }
        public String wuyemanage { get; set; }
        public String xcPic { get; set; }
        public String hxPic { get; set; }
        public String vipUserName { get; set; }
        public String qq { get; set; }
        public DateTime IsRecomTime { get; set; }
        public Int32 IsRecom { get; set; }
        public Int32 isdel { get; set; }
        public String ghPic { get; set; }
        public String ybPic { get; set; }
        public Int32 bbsBoard { get; set; }
        public Int32 ispx { get; set; }
        public String BigLogo { get; set; }
        public Int32 wuyeCls { get; set; }
        public String jianzhuCls { get; set; }
        public String XiangMuTeSe { get; set; }
        public String loucengInfo { get; set; }
        public String cheweiInfo { get; set; }
        public String zhuangxiuInfo { get; set; }
        public String videoText { get; set; }
        public String TopBanner { get; set; }
        public String TopBannerLink { get; set; }
        public Int32 tgcount { get; set; }
        public Int32 wdcount { get; set; }
        public Int32 isJianban { get; set; }
        public String BottomBanner { get; set; }
        public String BottomBannerLink { get; set; }
        public String Adleft { get; set; }
        public String AdleftLink { get; set; }
        public String Adright { get; set; }
        public String AdrightLink { get; set; }
        public Int32 dtcount { get; set; }
        public Int32 KkCountNum7 { get; set; }
        public Int32 KkCountNum30 { get; set; }
        public Int32 isxiaoqu { get; set; }
        public String xlp_lptd { get; set; }
        public String xlp_quanjing { get; set; }
        public Int32 xlp_cqnx { get; set; }
        public Int32 xlp_ghhs { get; set; }
        public String xlp_zdms { get; set; }
        public String xlp_zxbz { get; set; }
        public Int32 xlp_qijia { get; set; }
        public Int32 xlp_adtype { get; set; }
        public String TopBannerinfo { get; set; }
        public Int32 isnew { get; set; }
        public String weixinpic { get; set; }
        public String wxusername { get; set; }
        public DateTime wxclosedate { get; set; }
        public String pt_yljg { get; set; }
        public String pt_jyjg { get; set; }
        public String pt_sccs { get; set; }
        public String pt_cyyl { get; set; }
        public String pt_jghj { get; set; }
        public String pt_jtzk { get; set; }
        public Int32 dpcount { get; set; }
        public String bjdp_yd { get; set; }
        public String bjdp_qd { get; set; }
        public Int32 tj_area { get; set; }
        public DateTime tj_area_time { get; set; }
        public String tgInfo { get; set; }

    }

    public class PostCmd
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public Int32 sId { get; set; }
        public String TableName { get; set; }
        public String infourl { get; set; }
        public String info { get; set; }

    }

    public class MSpeer_conflictdetectionconfigrequest
    {
        public Int32 id { get; set; }
        public String publication { get; set; }
        public DateTime sent_date { get; set; }
        public Int32 timeout { get; set; }
        public DateTime modified_date { get; set; }
        public String progress_phase { get; set; }
        public Boolean phase_timed_out { get; set; }

    }

    public class job_RC_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public String kindname { get; set; }
        public Int32 viewlev { get; set; }
        public DateTime systime { get; set; }

    }

    public class dm_url
    {
        public Int32 id { get; set; }
        public Int32 cid { get; set; }
        public Int32 dmid { get; set; }
        public Int32 siteid { get; set; }
        public String title { get; set; }
        public String info { get; set; }
        public String url { get; set; }
        public DateTime addtime { get; set; }
        public Int32 view_lev { get; set; }

    }

    public class House_kftbm
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 kftid { get; set; }
        public String trueName { get; set; }
        public Int32 kftSex { get; set; }
        public String kftTel { get; set; }
        public String kftNum { get; set; }
        public String kftIP { get; set; }
        public String username { get; set; }
        public DateTime addTime { get; set; }

    }

    public class House_kft
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 kftQi { get; set; }
        public DateTime kftDate { get; set; }
        public String kftTitle { get; set; }
        public String kftHtml { get; set; }
        public DateTime addtime { get; set; }
        public Int32 isdel { get; set; }
        public Int32 isstatus { get; set; }
        public String username { get; set; }
        public String BigLogo { get; set; }
        public String topBanner { get; set; }
        public Int32 skin { get; set; }
        public String background { get; set; }
        public Int32 bgtype { get; set; }

    }

    public class zph_qiyeku
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 qy_id { get; set; }
        public Int32 zph_id { get; set; }
        public DateTime addtime { get; set; }
        public DateTime cmdtime { get; set; }
        public Int32 isdel { get; set; }
        public Int32 isstatus { get; set; }
        public Int32 istj { get; set; }
        public DateTime istjtime { get; set; }
        public Int32 isview { get; set; }
        public String beizhu { get; set; }
        public Int32 ismsg { get; set; }
        public Int32 viewlev { get; set; }

    }

    public class post_bd_mobile
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String tel { get; set; }
        public Int32 num { get; set; }
        public String code { get; set; }
        public Int32 ischk { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }

    }

    public class ershouCls
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String oTitle { get; set; }
        public Int32 oPx { get; set; }

    }

    public class log
    {
        public Int32 RowNumber { get; set; }
        public Int32 EventClass { get; set; }
        public String TextData { get; set; }
        public String ApplicationName { get; set; }
        public String NTUserName { get; set; }
        public String LoginName { get; set; }
        public Int32 ClientProcessID { get; set; }
        public Int32 SPID { get; set; }
        public DateTime StartTime { get; set; }
        public Int32 CPU { get; set; }
        public Int64 Reads { get; set; }
        public Int64 Writes { get; set; }
        public Int64 Duration { get; set; }
        public DateTime EndTime { get; set; }
        public Byte[] BinaryData { get; set; }

    }

    public class chkmd5
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 rndnum { get; set; }
        public String inputstr { get; set; }
        public String chk_dmstr { get; set; }
        public String ip { get; set; }
        public DateTime systime { get; set; }

    }

    public class MSpeer_conflictdetectionconfigresponse
    {
        public Int32 request_id { get; set; }
        public String peer_node { get; set; }
        public String peer_db { get; set; }
        public Int32 peer_version { get; set; }
        public Int32 peer_db_version { get; set; }
        public Boolean is_peer { get; set; }
        public Boolean conflictdetection_enabled { get; set; }
        public Int32 originator_id { get; set; }
        public Int32 peer_conflict_retention { get; set; }
        public Boolean peer_continue_onconflict { get; set; }
        public String peer_subscriptions { get; set; }
        public String progress_phase { get; set; }
        public DateTime modified_date { get; set; }

    }

    public class xlpjj
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 IsType { get; set; }
        public Int32 IsNum1 { get; set; }
        public Int32 IsNum2 { get; set; }
        public Int32 IsNum3 { get; set; }
        public Int32 IsNum4 { get; set; }
        public Int32 IsNum5 { get; set; }
        public DateTime UpTime { get; set; }
        public String Ip { get; set; }
        public String UserName { get; set; }

    }


    public class XlpWenDa
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ClassId { get; set; }
        public String UserName { get; set; }
        public Int32 Sex { get; set; }
        public String Tel { get; set; }
        public String Content { get; set; }
        public String IP { get; set; }
        public String AdminContent { get; set; }
        public DateTime AdminAddTime { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 khType { get; set; }
        public String beizhu { get; set; }
        public Int32 fromtype { get; set; }

    }

    public class XlpSwf
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String title { get; set; }
        public String pic { get; set; }
        public String picurl { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 ispx { get; set; }

    }

    public class FwxqStar
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XqId { get; set; }
        public String sType { get; set; }
        public Int32 StarNum { get; set; }
        public String Ip { get; set; }

    }

    public class View_1
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public DateTime edittime { get; set; }
        public Int32 istj { get; set; }
        public DateTime istjtime { get; set; }
        public Int32 iszc { get; set; }
        public String title { get; set; }
        public Int32 kind { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 valid { get; set; }
        public DateTime validdate { get; set; }
        public Int32 education { get; set; }
        public Int32 record { get; set; }
        public Int32 sex { get; set; }
        public Int32 number { get; set; }
        public Int32 salary { get; set; }
        public String info { get; set; }
        public String workarea { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public Int32 iserror { get; set; }
        public Int32 ispass { get; set; }
        public Int32 ccoochk { get; set; }
        public String ip { get; set; }
        public Int32 hit { get; set; }
        public String password { get; set; }
        public Int32 IsCmd { get; set; }
        public String compname { get; set; }
        public String Compaddr { get; set; }
        public Int32 Comptrade { get; set; }
        public Int32 compkind { get; set; }
        public Int32 compsize { get; set; }
        public String compinfo { get; set; }
        public String UpPic { get; set; }
        public Int32 IsExit { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 isdel { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countJl { get; set; }
        public Int32 countRe { get; set; }
        public Int32 compname1 { get; set; }
        public String compaddr1 { get; set; }
        public Int32 CmdTime { get; set; }

    }

    public class business_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todayNum { get; set; }
        public Int32 infokind { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 classid2 { get; set; }

    }

    public class log1
    {
        public Int32 RowNumber { get; set; }
        public Int32 EventClass { get; set; }
        public String TextData { get; set; }
        public String ApplicationName { get; set; }
        public String NTUserName { get; set; }
        public String LoginName { get; set; }
        public Int32 CPU { get; set; }
        public Int64 Reads { get; set; }
        public Int64 Writes { get; set; }
        public Int64 Duration { get; set; }
        public Int32 ClientProcessID { get; set; }
        public Int32 SPID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Byte[] BinaryData { get; set; }

    }

    public class Report_day_post
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 syear { get; set; }
        public Int32 smonth { get; set; }
        public Int32 sday { get; set; }
        public DateTime Systime { get; set; }
        public Int32 fang_user { get; set; }
        public Int32 fang_user_tuan { get; set; }
        public Int32 fang_user_xlp { get; set; }
        public Int32 fang_user_vote { get; set; }
        public Int32 fang_user_day { get; set; }
        public Int32 fang_user_day_tuan { get; set; }
        public Int32 fang_user_day_xlp { get; set; }
        public Int32 fang_user_day_vote { get; set; }
        public Int32 fang_info { get; set; }
        public Int32 fang_info_chushou { get; set; }
        public Int32 fang_info_chuzu { get; set; }
        public Int32 fang_info_chudui { get; set; }
        public Int32 fang_info_qiugou { get; set; }
        public Int32 fang_info_qiuzu { get; set; }
        public Int32 fang_info_day { get; set; }
        public Int32 fang_info_chushou_day { get; set; }
        public Int32 fang_info_chuzu_day { get; set; }
        public Int32 fang_info_chudui_day { get; set; }
        public Int32 fang_info_qiugou_day { get; set; }
        public Int32 fang_info_qiuzu_day { get; set; }
        public Int32 fang_zj { get; set; }
        public Int32 fang_zj_user { get; set; }
        public Int32 fang_zj_day { get; set; }
        public Int32 fang_zj_user_day { get; set; }
        public Int32 job_qiye { get; set; }
        public Int32 job_user { get; set; }
        public Int32 job_zp { get; set; }
        public Int32 job_zp_day { get; set; }
        public Int32 job_jz { get; set; }
        public Int32 job_jz_day { get; set; }
        public Int32 job_qiye_view { get; set; }
        public Int32 job_qiye_view_day { get; set; }
        public Int32 job_jl { get; set; }
        public Int32 job_jl_day { get; set; }

    }

    public class sysreplservers
    {
        public String srvname { get; set; }
        public Int32 srvid { get; set; }

    }

    public class syncobj_0x4231443434373534
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public DateTime systime { get; set; }
        public String username { get; set; }
        public String title { get; set; }
        public String info { get; set; }
        public String url { get; set; }
        public String pic { get; set; }
        public DateTime updatetime { get; set; }
        public String address { get; set; }
        public String tel { get; set; }
        public Int32 price { get; set; }
        public Int32 state { get; set; }
        public String beizhu { get; set; }
        public DateTime opendate { get; set; }
        public String Location { get; set; }
        public Int32 Area { get; set; }
        public String Developers { get; set; }
        public String Tenement { get; set; }
        public String Enddate { get; set; }
        public String Pic2 { get; set; }
        public String Way { get; set; }
        public String Map { get; set; }
        public String Video { get; set; }
        public Int32 Hit { get; set; }
        public Int32 IsState { get; set; }
        public Int32 TuanGou { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 IsLine { get; set; }
        public String wuyemoney { get; set; }
        public String rongjilv { get; set; }
        public String lvhua { get; set; }
        public String chewei { get; set; }
        public String vipUserName { get; set; }
        public String qq { get; set; }
        public DateTime IsRecomTime { get; set; }
        public Int32 IsRecom { get; set; }
        public Int32 isdel { get; set; }
        public String ghPic { get; set; }
        public String ybPic { get; set; }
        public Int32 bbsBoard { get; set; }
        public Int32 ispx { get; set; }
        public String BigLogo { get; set; }
        public Int32 wuyeCls { get; set; }
        public String jianzhuCls { get; set; }
        public String XiangMuTeSe { get; set; }
        public String loucengInfo { get; set; }
        public String cheweiInfo { get; set; }
        public String zhuangxiuInfo { get; set; }
        public String videoText { get; set; }
        public String TopBanner { get; set; }
        public String TopBannerLink { get; set; }
        public Int32 tgcount { get; set; }
        public Int32 wdcount { get; set; }
        public Int32 isJianban { get; set; }
        public String BottomBanner { get; set; }
        public String BottomBannerLink { get; set; }
        public String Adleft { get; set; }
        public String AdleftLink { get; set; }
        public String Adright { get; set; }
        public String AdrightLink { get; set; }
        public Int32 dtcount { get; set; }
        public Int32 KkCountNum7 { get; set; }
        public Int32 KkCountNum30 { get; set; }
        public Int32 isxiaoqu { get; set; }
        public String xlp_lptd { get; set; }
        public String xlp_quanjing { get; set; }
        public Int32 xlp_cqnx { get; set; }
        public Int32 xlp_ghhs { get; set; }
        public String xlp_zdms { get; set; }
        public String xlp_zxbz { get; set; }
        public Int32 xlp_qijia { get; set; }
        public Int32 xlp_adtype { get; set; }
        public String TopBannerinfo { get; set; }
        public Int32 isnew { get; set; }
        public String weixinpic { get; set; }
        public String wxusername { get; set; }
        public DateTime wxclosedate { get; set; }
        public String pt_yljg { get; set; }
        public String pt_jyjg { get; set; }
        public String pt_sccs { get; set; }
        public String pt_cyyl { get; set; }
        public String pt_jghj { get; set; }
        public String pt_jtzk { get; set; }
        public Int32 dpcount { get; set; }
        public Int32 tj_area { get; set; }
        public DateTime tj_area_time { get; set; }
        public String tgInfo { get; set; }

    }

    public class dm_post
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String title { get; set; }
        public String url { get; set; }
        public String op { get; set; }
        public DateTime systime { get; set; }

    }

    public class App_info
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String info { get; set; }
        public String stype { get; set; }
        public String ip { get; set; }
        public DateTime addtime { get; set; }
        public String UserName { get; set; }
        public String Tel { get; set; }

    }

    public class Home_ChuShou
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public String areazone { get; set; }
        public Int32 Htype { get; set; }
        public Int32 LouNum { get; set; }
        public Int32 IsLouNum { get; set; }
        public String oHomeYear { get; set; }
        public String wupin { get; set; }
        public Double Mianji { get; set; }
        public Decimal MoneyNum { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String oInfo { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String UpImg1 { get; set; }
        public String UpImg2 { get; set; }
        public String UpImg3 { get; set; }
        public String UpImg4 { get; set; }
        public String oVideo { get; set; }
        public String oMap { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 IsStatus { get; set; }
        public String IsNum { get; set; }
        public Int32 OnlineIsCmd { get; set; }
        public String delPass { get; set; }
        public String delPassOk { get; set; }
        public Int32 IsZj { get; set; }
        public Int32 ZjId { get; set; }
        public Int32 xqId { get; set; }
        public Int32 Digg1 { get; set; }
        public Int32 Digg2 { get; set; }
        public Int32 Digg3 { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public String Pic { get; set; }
        public Int32 IsRecom { get; set; }
        public DateTime IsRecomTime { get; set; }
        public Int32 IsListTop { get; set; }
        public Int32 IsError { get; set; }
        public String direction { get; set; }
        public Int32 mapsite { get; set; }
        public String ZJBeizhu { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 zjTj { get; set; }
        public DateTime zjTjtime { get; set; }
        public Int32 Isdaikuan { get; set; }
        public Int32 ismianshui { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 HXshi { get; set; }
        public Int32 HXting { get; set; }
        public Int32 HXwei { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 isautoup { get; set; }

    }

    public class Home_zj
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String oTitle { get; set; }
        public String oAddRess { get; set; }
        public String oLogo { get; set; }
        public String oInfo { get; set; }
        public String oLinkP { get; set; }
        public String oTel { get; set; }
        public String oQQ { get; set; }
        public String oEmail { get; set; }
        public String oMap { get; set; }
        public String UserPass { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 IsPx { get; set; }
        public Int32 ZjId { get; set; }
        public Int32 oNum { get; set; }
        public Int32 DataNum { get; set; }
        public DateTime CmdTime { get; set; }
        public Int32 skin { get; set; }
        public String UpPic { get; set; }
        public Int32 mapbaruser { get; set; }
        public Int32 cscount { get; set; }
        public Int32 czcount { get; set; }
        public Int32 KkCountNum7 { get; set; }
        public Int32 KkCountNum30 { get; set; }
        public Int32 cdcount { get; set; }
        public Int32 IsRecom { get; set; }
        public DateTime IsRecomTime { get; set; }
        public String topBanner { get; set; }
        public String background { get; set; }
        public Int32 bgtype { get; set; }
        public String navbgcolor { get; set; }
        public Int32 isautoup { get; set; }
        public Int32 autoupNum { get; set; }
        public DateTime autouptime { get; set; }
        public Int32 iscloseZs { get; set; }

    }

    public class House_kftwq
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 kftid { get; set; }
        public String wqTitle { get; set; }
        public DateTime kftDate { get; set; }
        public Int32 wqRenNum { get; set; }
        public String wqxlp { get; set; }
        public String wqHtml { get; set; }
        public String wqLink { get; set; }
        public String wqBanner { get; set; }
        public DateTime addTime { get; set; }

    }

    public class cheliang_ch
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String oTitle { get; set; }
        public String oAddRess { get; set; }
        public String oLogo { get; set; }
        public String oInfo { get; set; }
        public String oLinkP { get; set; }
        public String oTel { get; set; }
        public String oQQ { get; set; }
        public String oEmail { get; set; }
        public Int32 oPx { get; set; }
        public String oMap { get; set; }
        public DateTime CmdTime { get; set; }
        public String UserPass { get; set; }
        public Int32 mapbaruser { get; set; }
        public Int32 skin { get; set; }
        public Int32 clCount { get; set; }

    }

    public class Home_zjKk1
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 classid { get; set; }
        public String pageurl { get; set; }
        public String ip { get; set; }
        public String username { get; set; }
        public DateTime addtime { get; set; }

    }

    public class Xlp_FeedBack_Count
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 xlpid { get; set; }
        public DateTime systime { get; set; }
        public Int32 classid { get; set; }
        public Int32 total { get; set; }
        public DateTime lastUpdateTime { get; set; }
        public Int32 syear { get; set; }
        public Int32 smonth { get; set; }
        public Int32 sday { get; set; }
        public Int32 isAll { get; set; }

    }

    public class live_kind_new
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public DateTime systime { get; set; }
        public String kindname { get; set; }
        public String kindExplain { get; set; }
        public String kindNextTitle { get; set; }
        public Int32 kindNextSelect { get; set; }
        public Int32 kindlev { get; set; }
        public String username { get; set; }
        public Int32 viewlev { get; set; }
        public Int32 ishot { get; set; }
        public Int32 fid { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }
        public Int32 isdel { get; set; }
        public String CompanyTitle { get; set; }
        public String AreaTitle { get; set; }
        public Int32 kindNextNum { get; set; }
        public String kindIntroduction { get; set; }

    }

    public class work_to_do
    {
        public Int32 objectid { get; set; }
        public Int32 indexid { get; set; }
        public Int32 partitionnum { get; set; }
        public Double frag { get; set; }

    }

    public class idle_info
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Infokind { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public String Title { get; set; }
        public Int32 Chengse { get; set; }
        public Int32 workArea { get; set; }
        public Int32 Price { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String info { get; set; }
        public String ip { get; set; }
        public Int32 Ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String Pic { get; set; }
        public String password { get; set; }
        public Int32 atwhere { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 oTherId { get; set; }
        public Int32 IsExchange { get; set; }
        public String HtmlExchange { get; set; }
        public String HtmlArea { get; set; }
        public Int32 IsSource { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 ChannelId { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 isstatus { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 areaid { get; set; }
        public Int32 CPUpinpai { get; set; }
        public Int32 CPUheshu { get; set; }
        public Int32 neicun { get; set; }
        public Int32 yingpan { get; set; }
        public Int32 pingmuchicun { get; set; }
        public Int32 xianka { get; set; }
        public Int32 smallclassid { get; set; }
        public Int32 FourthId { get; set; }
        public Int32 rongji { get; set; }
        public String xinghao { get; set; }
        public String buyYear { get; set; }
        public String fapiao { get; set; }
        public String xuninum { get; set; }
        public String qinglvnum { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class SYNC_site_news_1__106
    {
        public Int32 id { get; set; }
        public String title { get; set; }
        public String title1 { get; set; }
        public String author { get; set; }
        public String memo { get; set; }
        public String comf { get; set; }
        public String comfurl { get; set; }
        public String purl { get; set; }
        public DateTime uptime { get; set; }
        public Int32 kind { get; set; }
        public String keys { get; set; }
        public String keys1 { get; set; }
        public Int16 sy { get; set; }
        public Int16 ispic { get; set; }
        public Int16 ishot { get; set; }
        public Int16 istj { get; set; }
        public Int16 isjd { get; set; }
        public Int16 isindex { get; set; }
        public Byte isjz { get; set; }
        public Byte ischk { get; set; }
        public Int32 CompanyNO { get; set; }
        public Int32 siteID { get; set; }
        public Int32 webid { get; set; }
        public Int32 newsCata { get; set; }
        public Int32 newstopic { get; set; }
        public Int32 isout { get; set; }
        public Int32 isFocusNow { get; set; }
        public Int32 postNum { get; set; }
        public Int32 upnum { get; set; }
        public Int32 hit { get; set; }
        public String flashurl { get; set; }
        public Int32 isdel { get; set; }
        public Int32 Ding { get; set; }
        public Int32 Cai { get; set; }

    }

    public class tel_area_bak
    {
        public Int32 tel { get; set; }
        public String address { get; set; }
        public String teltype { get; set; }

    }

    public class business_post
    {
        public Int32 id { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Boolean isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }
        public Int32 ischk { get; set; }

    }

    public class dtproperties
    {
        public Int32 id { get; set; }
        public Int32 objectid { get; set; }
        public String property { get; set; }
        public String value { get; set; }
        public String uvalue { get; set; }
        public Byte[] lvalue { get; set; }
        public Int32 version { get; set; }

    }

    public class job_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 Pid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }
        public Int32 type { get; set; }
        public String zhiwei_info { get; set; }
        public Int32 jltotal { get; set; }

    }

    public class job_jl_buy
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String orderNo { get; set; }
        public String oTitle { get; set; }
        public DateTime systime { get; set; }
        public Decimal price { get; set; }
        public String jlcount { get; set; }
        public String username { get; set; }
        public String oTel { get; set; }
        public Int32 oStatus { get; set; }
        public Int32 classid { get; set; }
        public Int32 uType { get; set; }
        public Int32 payType { get; set; }
        public Int32 isdel { get; set; }
        public Int32 Num { get; set; }

    }

    public class XinLouPanTg
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ClassId { get; set; }
        public String UserName { get; set; }
        public Int32 oSex { get; set; }
        public String oTel { get; set; }
        public String oContent { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 TgType { get; set; }
        public Int32 zhiye { get; set; }
        public Int32 Age { get; set; }
        public Int32 Manji { get; set; }
        public Int32 Huxing { get; set; }
        public Int32 Jiage { get; set; }
        public Int32 Shoufu { get; set; }
        public String lcyaoqiu { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 khType { get; set; }
        public String beizhu { get; set; }
        public Int32 isImport { get; set; }
        public Int32 fromtype { get; set; }

    }

    public class post_sxnum
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String tname { get; set; }
        public Int32 tid { get; set; }
        public Int32 num { get; set; }
        public Int32 tabcls { get; set; }

    }

    public class post_log
    {
        public Int32 RowNumber { get; set; }
        public Int32 EventClass { get; set; }
        public String TextData { get; set; }
        public String ApplicationName { get; set; }
        public String NTUserName { get; set; }
        public String LoginName { get; set; }
        public Int32 CPU { get; set; }
        public Int64 Reads { get; set; }
        public Int64 Writes { get; set; }
        public Int64 Duration { get; set; }
        public Int32 ClientProcessID { get; set; }
        public Int32 SPID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Byte[] BinaryData { get; set; }

    }

    public class job_jl_edu
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public Int32 jlid { get; set; }
        public String Sname { get; set; }
        public String Pname { get; set; }
        public Int32 Syear { get; set; }
        public Int32 Smonth { get; set; }
        public Int32 Eyear { get; set; }
        public Int32 Emonth { get; set; }

    }

    public class syncobj_0x3144334436384531
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 kftQi { get; set; }
        public DateTime kftDate { get; set; }
        public String kftTitle { get; set; }
        public String kftHtml { get; set; }
        public DateTime addtime { get; set; }
        public Int32 isdel { get; set; }
        public Int32 isstatus { get; set; }
        public String username { get; set; }
        public String BigLogo { get; set; }
        public String topBanner { get; set; }
        public Int32 skin { get; set; }
        public String background { get; set; }
        public Int32 bgtype { get; set; }

    }

    public class site_news_pinglun
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 classid { get; set; }
        public String UserName { get; set; }
        public String Content { get; set; }
        public Int32 Ding { get; set; }
        public DateTime AddTime { get; set; }
        public String IP { get; set; }
        public Int32 reid { get; set; }

    }

    public class cheliang_cls
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String oTitle { get; set; }
        public Int32 oPx { get; set; }

    }

    public class MqKk
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 classid { get; set; }
        public String pageurl { get; set; }
        public String ip { get; set; }
        public String username { get; set; }
        public DateTime addtime { get; set; }
        public String mstype { get; set; }

    }

    public class post_msgsend
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 comp_id { get; set; }
        public String vReceivephone { get; set; }
        public DateTime dSendDate { get; set; }
        public String vFrom { get; set; }
        public String vContent { get; set; }
        public String vUserName { get; set; }
        public Int32 nMsgNum { get; set; }
        public Int32 classid { get; set; }
        public Int32 nType { get; set; }
        public Int32 isdel { get; set; }
        public String ip { get; set; }

    }

    public class House_kftXlp
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 kftId { get; set; }
        public Int32 xlpId { get; set; }
        public DateTime addtime { get; set; }

    }

    public class postWhite
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String ccooUser { get; set; }
        public String UserName { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 oNum { get; set; }
        public Int32 tabCls { get; set; }
        public Int32 isSys { get; set; }
        public DateTime expTime { get; set; }
        public Int32 jlview { get; set; }
        public String beizu { get; set; }
        public Int32 mssms { get; set; }
        public DateTime EditTime { get; set; }

    }

    public class tel_area
    {
        public Int32 tel { get; set; }
        public String address { get; set; }
        public String teltype { get; set; }
        public Int32 qh { get; set; }

    }

    public class Home_chudui
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public String areazone { get; set; }
        public Decimal moneynumzu { get; set; }
        public Int32 hangye { get; set; }
        public String shopname { get; set; }
        public Double Mianji { get; set; }
        public Decimal MoneyNum { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String oInfo { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String oVideo { get; set; }
        public String oMap { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 IsStatus { get; set; }
        public String delPass { get; set; }
        public Int32 IsZj { get; set; }
        public Int32 ZjId { get; set; }
        public Int32 xqId { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public String Pic { get; set; }
        public Int32 IsRecom { get; set; }
        public DateTime IsRecomTime { get; set; }
        public Int32 IsListTop { get; set; }
        public Int32 IsError { get; set; }
        public Int32 countRe { get; set; }
        public Int32 zjTj { get; set; }
        public DateTime zjTjtime { get; set; }
        public String ZJBeizhu { get; set; }
        public String delPassOk { get; set; }
        public Int32 mapsite { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 fromtype { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 isautoup { get; set; }

    }

    public class site_links
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 fType { get; set; }
        public String fName { get; set; }
        public String fUrl { get; set; }
        public String fLogo { get; set; }
        public DateTime addtime { get; set; }
        public Int32 fPx { get; set; }

    }

    public class FwIndex
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 IsType { get; set; }
        public Int32 bbsId { get; set; }
        public Int32 IsBBS { get; set; }
        public Int32 IsHome { get; set; }
        public String IsBoardPx { get; set; }
        public Int32 IsfwZX { get; set; }
        public Int32 IsIndexShow { get; set; }

    }

    public class SYNC_Home_ChuShou_1__158
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public String areazone { get; set; }
        public Int32 Htype { get; set; }
        public Int32 LouNum { get; set; }
        public Int32 IsLouNum { get; set; }
        public String oHomeYear { get; set; }
        public String wupin { get; set; }
        public Double Mianji { get; set; }
        public Decimal MoneyNum { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String oInfo { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String UpImg1 { get; set; }
        public String UpImg2 { get; set; }
        public String UpImg3 { get; set; }
        public String UpImg4 { get; set; }
        public String oVideo { get; set; }
        public String oMap { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 IsStatus { get; set; }
        public String IsNum { get; set; }
        public Int32 OnlineIsCmd { get; set; }
        public String delPass { get; set; }
        public String delPassOk { get; set; }
        public Int32 IsZj { get; set; }
        public Int32 ZjId { get; set; }
        public Int32 xqId { get; set; }
        public Int32 Digg1 { get; set; }
        public Int32 Digg2 { get; set; }
        public Int32 Digg3 { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public String Pic { get; set; }
        public Int32 IsRecom { get; set; }
        public DateTime IsRecomTime { get; set; }
        public Int32 IsListTop { get; set; }
        public Int32 IsError { get; set; }
        public String direction { get; set; }
        public Int32 mapsite { get; set; }
        public String ZJBeizhu { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 zjTj { get; set; }
        public DateTime zjTjtime { get; set; }
        public Int32 Isdaikuan { get; set; }
        public Int32 ismianshui { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 HXshi { get; set; }
        public Int32 HXting { get; set; }
        public Int32 HXwei { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 isautoup { get; set; }

    }

    public class post_tj_price
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 Num { get; set; }
        public Int32 Channel { get; set; }
        public Decimal price { get; set; }
        public Int32 uType { get; set; }
        public DateTime systime { get; set; }

    }

    public class job_jl_work
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public Int32 jlid { get; set; }
        public String Cname { get; set; }
        public String PCname { get; set; }
        public String Pname { get; set; }
        public Int32 Syear { get; set; }
        public Int32 Smonth { get; set; }
        public Int32 Eyear { get; set; }
        public Int32 Emonth { get; set; }
        public String info { get; set; }
        public Int32 Salary { get; set; }

    }

    public class SYNC_Home_ChuZu_1__158
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public String areazone { get; set; }
        public String Htype { get; set; }
        public Int32 LouNum { get; set; }
        public Int32 IsLouNum { get; set; }
        public String wupin { get; set; }
        public Double Mianji { get; set; }
        public Decimal MoneyNum { get; set; }
        public Int32 MoneyType { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String oInfo { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String UpImg1 { get; set; }
        public String UpImg2 { get; set; }
        public String UpImg3 { get; set; }
        public String UpImg4 { get; set; }
        public String oVideo { get; set; }
        public String oMap { get; set; }
        public Int32 OnlineIsCmd { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 IsStatus { get; set; }
        public String IsNum { get; set; }
        public String delPass { get; set; }
        public String delPassOk { get; set; }
        public Int32 IsZj { get; set; }
        public Int32 ZjId { get; set; }
        public Int32 xqId { get; set; }
        public Int32 Digg1 { get; set; }
        public Int32 Digg2 { get; set; }
        public Int32 Digg3 { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public String Pic { get; set; }
        public Int32 IsRecom { get; set; }
        public DateTime IsRecomTime { get; set; }
        public Int32 IsListTop { get; set; }
        public Int32 IsError { get; set; }
        public String direction { get; set; }
        public Int32 mapsite { get; set; }
        public String ZJBeizhu { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 zjTj { get; set; }
        public DateTime zjTjtime { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 HXshi { get; set; }
        public Int32 HXting { get; set; }
        public Int32 HXwei { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 isautoup { get; set; }

    }

    public class xlp_xk_louceng
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XlpId { get; set; }
        public String Title { get; set; }
        public Int32 isPx { get; set; }
        public Int32 louhao { get; set; }
        public Int32 danyuan { get; set; }

    }

    public class edu_info
    {
        public Int32 Id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public Int32 Infokind { get; set; }
        public String Title { get; set; }
        public String info { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String Password { get; set; }
        public String px_CompName { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 NId { get; set; }

    }

    public class edu_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }
        public Int32 infokind { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 classid2 { get; set; }

    }

    public class Dm_Mobile
    {
        public Int32 tel { get; set; }
        public String address { get; set; }
        public String teltype { get; set; }
        public String qh { get; set; }

    }

    public class home_xlptejiafang
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 xlpid { get; set; }
        public Int32 huodongid { get; set; }
        public DateTime systime { get; set; }
        public Int32 huxing_shi { get; set; }
        public Int32 huxing_ting { get; set; }
        public Int32 huxing_wei { get; set; }
        public Int32 mianji_jianzhu { get; set; }
        public Int32 mianji_shiyong { get; set; }
        public String chaoxiang { get; set; }
        public Int32 yuanjia { get; set; }
        public Int32 xianjia { get; set; }
        public String huxinginfo { get; set; }
        public String pic { get; set; }
        public Int32 isdel { get; set; }
        public Int32 opx { get; set; }

    }

    public class job_qiyeku
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public String compname { get; set; }
        public String compaddr { get; set; }
        public Int32 comptrade { get; set; }
        public Int32 compkind { get; set; }
        public Int32 compsize { get; set; }
        public String compinfo { get; set; }
        public DateTime systime { get; set; }
        public DateTime edittime { get; set; }
        public Int32 userType { get; set; }
        public String postRemarks { get; set; }
        public DateTime uptime { get; set; }
        public String oBigLogo { get; set; }
        public String oSigLogo { get; set; }
        public String oLinkMan { get; set; }
        public String oLinkTel { get; set; }
        public String oLinkEmail { get; set; }
        public String oLinkQq { get; set; }
        public String oMap { get; set; }
        public Int32 oPx { get; set; }
        public DateTime CmdTime { get; set; }
        public Int32 skin { get; set; }
        public String website { get; set; }
        public String UpPic { get; set; }
        public Int32 mapbaruser { get; set; }
        public Int32 ismq { get; set; }
        public Int32 jobCount { get; set; }
        public Int32 indexStyle { get; set; }
        public String indexPic { get; set; }
        public Int32 ANum { get; set; }
        public String UpPic_title { get; set; }
        public String HonorPic { get; set; }
        public String HonorPic_title { get; set; }
        public String compculture { get; set; }
        public Int32 classid { get; set; }
        public String background { get; set; }
        public Int32 bgtype { get; set; }
        public String navbgcolor { get; set; }
        public Int32 ispost { get; set; }
        public Int32 ispostchk { get; set; }
        public String TempLogo { get; set; }

    }

    public class SYNC_Home_QiuGou_1__158
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public Int32 Htype { get; set; }
        public Double Mianji { get; set; }
        public Decimal IsMoney { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String wupin { get; set; }
        public String oInfo { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String delPass { get; set; }
        public String delPassOk { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 IsError { get; set; }
        public Int32 isrecom { get; set; }
        public DateTime isrecomtime { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 HXshi { get; set; }
        public Int32 HXting { get; set; }
        public Int32 HXwei { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class pet_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 kindlev { get; set; }
        public DateTime systime { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }

    }

    public class Post_Link
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String Title { get; set; }
        public String UrlLink { get; set; }
        public Int32 Px { get; set; }

    }

    public class post_day_tongji
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 Tclass { get; set; }
        public DateTime Ndate { get; set; }
        public Int32 Nyear { get; set; }
        public Int32 Nmonth { get; set; }
        public Int32 Nday { get; set; }
        public Int32 Num { get; set; }
        public Int32 tabcls { get; set; }
        public String Tname { get; set; }

    }

    public class post_zixun
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 tabcls { get; set; }
        public Int32 Stype { get; set; }
        public Int32 Kind { get; set; }
        public String UserName { get; set; }
        public String truename { get; set; }
        public String Tel { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 khType { get; set; }
        public String beizhu { get; set; }
        public Int32 isdel { get; set; }

    }

    public class PslWeb
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String oWebName { get; set; }
        public String oWebLink { get; set; }

    }

    public class ip
    {
        public Int32 id { get; set; }
        public String ip1 { get; set; }
        public String ip2 { get; set; }
        public Double onip { get; set; }
        public Double offip { get; set; }
        public String addj { get; set; }
        public String addf { get; set; }

    }

    public class XlpKk
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ClassId { get; set; }
        public String PageUrl { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }
        public String UserName { get; set; }
        public Int32 fromtype { get; set; }

    }

    public class sysdiagrams
    {
        public String name { get; set; }
        public Int32 principal_id { get; set; }
        public Int32 diagram_id { get; set; }
        public Int32 version { get; set; }
        public Byte[] definition { get; set; }

    }

    public class SYNC_Home_QiuZu_1__158
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String UserName { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 Hclass { get; set; }
        public String oTitle { get; set; }
        public String address { get; set; }
        public Int32 areaId { get; set; }
        public Int32 Htype { get; set; }
        public Double Mianji { get; set; }
        public Decimal IsMoney { get; set; }
        public Int32 zhuangxiu { get; set; }
        public String wupin { get; set; }
        public String oInfo { get; set; }
        public String linkman { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public String qq { get; set; }
        public String Ip { get; set; }
        public Int32 IsChk { get; set; }
        public Int32 hit { get; set; }
        public String delPass { get; set; }
        public String delPassOk { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 IsError { get; set; }
        public Int32 isrecom { get; set; }
        public DateTime isrecomtime { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 HXshi { get; set; }
        public Int32 HXting { get; set; }
        public Int32 HXwei { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class Post_report
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 PostClass { get; set; }
        public Int32 PostId { get; set; }
        public Int32 classId { get; set; }
        public String usertel { get; set; }
        public String userContent { get; set; }
        public DateTime addtime { get; set; }
        public String IP { get; set; }

    }

    public class post
    {
        public Int32 RowNumber { get; set; }
        public Int32 EventClass { get; set; }
        public String TextData { get; set; }
        public String ApplicationName { get; set; }
        public String NTUserName { get; set; }
        public String LoginName { get; set; }
        public Int32 CPU { get; set; }
        public Int64 Reads { get; set; }
        public Int64 Writes { get; set; }
        public Int64 Duration { get; set; }
        public Int32 ClientProcessID { get; set; }
        public Int32 SPID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Byte[] BinaryData { get; set; }

    }

    public class xlp_xk_louhao
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XlpId { get; set; }
        public String Title { get; set; }
        public Int32 isPx { get; set; }
        public String username { get; set; }
        public Int32 lcCount { get; set; }
        public Int32 dyCount { get; set; }
        public Int32 hxCount { get; set; }
        public Int32 fjCount { get; set; }
        public Int32 ysCount { get; set; }
        public Int32 zsCount { get; set; }

    }

    public class Home_xlphuodong
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String oTitle { get; set; }
        public String topBanner { get; set; }
        public String baomingBtn { get; set; }
        public Int32 hit { get; set; }
        public DateTime EndDate { get; set; }
        public Int32 price { get; set; }
        public String oTel { get; set; }
        public String oInfo { get; set; }
        public String ZhuYiFangShi { get; set; }
        public String FuKuanZhuYi { get; set; }
        public Int32 XlpId { get; set; }
        public Int32 opx { get; set; }
        public Int32 isfukuan { get; set; }

    }

    public class SYNC_edu_info_1__67
    {
        public Int32 Id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public Int32 Infokind { get; set; }
        public String Title { get; set; }
        public String info { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String Password { get; set; }
        public String px_CompName { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 NId { get; set; }

    }

    public class storeusers
    {
        public Int32 id { get; set; }
        public String username { get; set; }
        public Int32 siteid { get; set; }
        public Int32 u_type { get; set; }

    }

    public class job_jl_viewcount
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 jishu { get; set; }
        public DateTime systime { get; set; }

    }

    public class friend_kind
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }

    }

    public class post_huodong_set
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String topbackimg { get; set; }
        public String topbanner { get; set; }
        public String content { get; set; }
        public DateTime huodongtime { get; set; }
        public Int32 huodongtype { get; set; }
        public DateTime systime { get; set; }
        public String title { get; set; }
        public DateTime huodongendtime { get; set; }
        public String indexad { get; set; }

    }

    public class SYNC_job_jl_1__67
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public String title { get; set; }
        public String truename { get; set; }
        public Int32 sex { get; set; }
        public Int32 bornyear { get; set; }
        public Int32 bornmonth { get; set; }
        public Int32 borndate { get; set; }
        public Int32 ismarry { get; set; }
        public Int32 record { get; set; }
        public Int32 edu { get; set; }
        public String jiguan { get; set; }
        public String edukind { get; set; }
        public String eduaddr { get; set; }
        public String email { get; set; }
        public String tel { get; set; }
        public String qq { get; set; }
        public String wish { get; set; }
        public Int32 pay { get; set; }
        public DateTime systime { get; set; }
        public DateTime edittime { get; set; }
        public Int32 jlstate { get; set; }
        public Int32 jlkind { get; set; }
        public Int32 ccoochk { get; set; }
        public String UserImg { get; set; }
        public Int32 IsCmd { get; set; }
        public String UpUserImg1 { get; set; }
        public String UpUserImg2 { get; set; }
        public String UpUserImg3 { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 isdel { get; set; }
        public Int32 hit { get; set; }
        public String UpPic { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 IsSite { get; set; }
        public DateTime istjtime { get; set; }
        public String liangdian { get; set; }
        public String juzhudi { get; set; }
        public Int32 areaId { get; set; }
        public Int32 userType { get; set; }
        public String postRemarks { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 ANum { get; set; }

    }

    public class traffic_info
    {
        public Int32 Id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Infokind { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public String Title { get; set; }
        public Int32 workArea { get; set; }
        public Int32 source { get; set; }
        public String brand { get; set; }
        public Int32 Age { get; set; }
        public String mileage { get; set; }
        public Decimal Price { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String info { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String password { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 ClassId { get; set; }
        public String HtmlArea { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 isstatus { get; set; }
        public Int32 LicenseYear { get; set; }
        public Int32 LicenseMonth { get; set; }
        public Int32 color { get; set; }
        public String emission { get; set; }
        public Int32 gearbox { get; set; }
        public Int32 driveMode { get; set; }
        public String checkEnd { get; set; }
        public Int32 LicenseSell { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 IsHaveCar { get; set; }
        public Int32 Pinche { get; set; }
        public String QiDian { get; set; }
        public String ZhongDian { get; set; }
        public DateTime deparTime { get; set; }
        public Int32 carpoolCls { get; set; }
        public String tujingZhan { get; set; }
        public Int32 countRe { get; set; }
        public Int32 CheXing { get; set; }
        public Int32 IsBaoyang { get; set; }
        public Int32 IsShigu { get; set; }
        public Int32 XinJiu { get; set; }
        public Int32 ShiYong { get; set; }
        public Int32 GouCheYear { get; set; }
        public Int32 DianYa { get; set; }
        public Int32 DianChi { get; set; }
        public Int32 FaDongji { get; set; }
        public Int32 ZuoWei { get; set; }
        public String Map { get; set; }
        public String ShopName { get; set; }
        public Decimal FeiYong { get; set; }
        public Int32 brandN { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class post_kkYueCount_1
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 kkCount { get; set; }
        public Int32 classId { get; set; }
        public String tabName { get; set; }
        public DateTime systime { get; set; }

    }

    public class edu_post
    {
        public Int32 id { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Boolean isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }
        public Int32 ischk { get; set; }

    }

    public class SYNC_friend_info_1__67
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Infokind { get; set; }
        public String Title { get; set; }
        public Int32 Age { get; set; }
        public Int32 Sex { get; set; }
        public String Home { get; set; }
        public Int32 education { get; set; }
        public Int32 Height { get; set; }
        public String Vocation { get; set; }
        public Int32 Age1 { get; set; }
        public Int32 Education1 { get; set; }
        public Int32 Height1 { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String info { get; set; }
        public String ip { get; set; }
        public Int32 Ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String Pic { get; set; }
        public String Password { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public String mobile { get; set; }
        public String fax { get; set; }
        public Int32 ishj { get; set; }
        public Int32 hjid { get; set; }
        public Int32 weight { get; set; }
        public Int32 house { get; set; }
        public String star { get; set; }
        public Int32 income { get; set; }
        public Int32 house1 { get; set; }
        public Int32 income1 { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class pet_info
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public DateTime uptime { get; set; }
        public Int32 istj { get; set; }
        public DateTime istjtime { get; set; }
        public Int32 iserror { get; set; }
        public Int32 infokind { get; set; }
        public String title { get; set; }
        public String info { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String password { get; set; }
        public Int32 source { get; set; }
        public Int32 gongxu { get; set; }
        public Int32 hclass { get; set; }
        public Int32 price { get; set; }
        public Int32 sex { get; set; }
        public Int32 vaccines { get; set; }
        public Int32 age { get; set; }
        public Int32 ageUnits { get; set; }
        public Int32 shclass { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public Int32 IsStatus { get; set; }
        public Int32 countRe { get; set; }
        public Int32 iszhaoling { get; set; }
        public String color { get; set; }
        public String dsDate { get; set; }
        public String dsdidian { get; set; }
        public String Chouxie { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 fromtype { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class post_kkYueCount
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 kkCount { get; set; }
        public Int32 classId { get; set; }
        public String tabName { get; set; }
        public DateTime systime { get; set; }

    }

    public class SYNC_idle_info_1__67
    {
        public Int32 id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Infokind { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public String Title { get; set; }
        public Int32 Chengse { get; set; }
        public Int32 workArea { get; set; }
        public Int32 Price { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String info { get; set; }
        public String ip { get; set; }
        public Int32 Ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String Pic { get; set; }
        public String password { get; set; }
        public Int32 atwhere { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 oTherId { get; set; }
        public Int32 IsExchange { get; set; }
        public String HtmlExchange { get; set; }
        public String HtmlArea { get; set; }
        public Int32 IsSource { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 ChannelId { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 isstatus { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public Int32 areaid { get; set; }
        public Int32 CPUpinpai { get; set; }
        public Int32 CPUheshu { get; set; }
        public Int32 neicun { get; set; }
        public Int32 yingpan { get; set; }
        public Int32 pingmuchicun { get; set; }
        public Int32 xianka { get; set; }
        public Int32 smallclassid { get; set; }
        public Int32 FourthId { get; set; }
        public Int32 rongji { get; set; }
        public String xinghao { get; set; }
        public String buyYear { get; set; }
        public String fapiao { get; set; }
        public String xuninum { get; set; }
        public String qinglvnum { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class xlp_xk_huxing
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XlpId { get; set; }
        public String Title { get; set; }
        public String pic { get; set; }
        public Int32 isPx { get; set; }
        public Int32 louhao { get; set; }
        public Int32 danyuan { get; set; }

    }

    public class post_config
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 jobstate { get; set; }

    }

    public class Home_Count
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 FwCs { get; set; }
        public Int32 FwCz { get; set; }
        public Int32 FwQg { get; set; }
        public Int32 FwQz { get; set; }
        public Int32 FwXlp { get; set; }
        public Int32 FwCsTui { get; set; }
        public Int32 FwCzTui { get; set; }
        public Int32 FwCd { get; set; }
        public Int32 FwCdTui { get; set; }
        public Int32 FwXq { get; set; }
        public Int32 FwZj { get; set; }

    }

    public class post_table_nouser_BZ
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String TName { get; set; }
        public Int32 TId { get; set; }
        public String BZ { get; set; }

    }

    public class idel_kind_backup
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 viewlev { get; set; }
        public String kindname { get; set; }
        public Int32 ishot { get; set; }
        public DateTime systime { get; set; }
        public Int32 kindlev { get; set; }
        public Int32 fid { get; set; }
        public String username { get; set; }
        public Int32 total { get; set; }
        public Int32 todaynum { get; set; }

    }

    public class friend_post
    {
        public Int32 id { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Boolean isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }
        public Int32 ischk { get; set; }

    }

    public class mqzp
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public DateTime UpTime { get; set; }
        public Int32 SiteId { get; set; }
        public String UserName { get; set; }
        public String oTitle { get; set; }
        public Int32 kind { get; set; }
        public Int32 IsSex { get; set; }
        public Int32 IsTime { get; set; }
        public Int32 IsEdu { get; set; }
        public Int32 IsExp { get; set; }
        public Int32 IsNumPeo { get; set; }
        public Int32 IsMoney { get; set; }
        public String IsArea { get; set; }
        public String IsInfo { get; set; }

    }

    public class post_huodong_jiangpin
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 huodongid { get; set; }
        public String pic { get; set; }
        public String title { get; set; }
        public Int32 gailv { get; set; }
        public Int32 huodongtype { get; set; }
        public DateTime systime { get; set; }
        public Int32 istan { get; set; }
        public Int32 jiangcount { get; set; }
        public Int32 sjiangcount { get; set; }

    }

    public class Job_Vip_Config
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 JobNum { get; set; }
        public Int32 JlViewNum { get; set; }
        public Int32 MsgNum { get; set; }
        public Int32 TjJobNum { get; set; }
        public Int32 IsHelp { get; set; }
        public DateTime UpTime { get; set; }
        public String UpUserName { get; set; }
        public Int32 wzp { get; set; }

    }

    public class job_jl_price
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 Num { get; set; }
        public Int32 zNum { get; set; }
        public Decimal price { get; set; }
        public Int32 uType { get; set; }
        public DateTime systime { get; set; }

    }

    public class postimg
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public String IsClsName { get; set; }
        public Int32 IsClsID { get; set; }
        public String Title { get; set; }
        public String ImgPath { get; set; }
        public String HtmlContent { get; set; }
        public Int32 siteid { get; set; }
        public String UserName { get; set; }

    }

    public class Fwxq
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 xName { get; set; }
        public Int32 xMoney { get; set; }
        public String xKfs { get; set; }
        public String xAddRess { get; set; }
        public String xWygs { get; set; }
        public String xWyglf { get; set; }
        public DateTime xJgTime { get; set; }
        public String xRjl { get; set; }
        public String xLhl { get; set; }
        public String xInfo { get; set; }
        public String xPtss { get; set; }
        public String xMap { get; set; }
        public Int32 hit { get; set; }
        public String title { get; set; }
        public Int32 areaId { get; set; }
        public Int32 isPx { get; set; }
        public Int32 cscount { get; set; }
        public Int32 czcount { get; set; }
        public String xcpic { get; set; }
        public String chewei { get; set; }
        public String jianzhuCls { get; set; }
        public String jiaotong { get; set; }
        public String wuyemanage { get; set; }
        public String loucenginfo { get; set; }
        public String cheweiinfo { get; set; }
        public String zhuangxiuinfo { get; set; }
        public String hxpic { get; set; }
        public Int32 loupanid { get; set; }
        public Int32 M_Avg_P_1 { get; set; }
        public Int32 M_Avg_P_2 { get; set; }
        public Int32 M_Avg_P_3 { get; set; }
        public Int32 M_Avg_P_4 { get; set; }
        public Int32 M_Avg_P_5 { get; set; }
        public String pt_yljg { get; set; }
        public String pt_jyjg { get; set; }
        public String pt_sccs { get; set; }
        public String pt_cyyl { get; set; }
        public String quanjing { get; set; }

    }

    public class post_tj_buy
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String orderNo { get; set; }
        public String oTitle { get; set; }
        public DateTime systime { get; set; }
        public Decimal price { get; set; }
        public Int32 tjcount { get; set; }
        public String username { get; set; }
        public String oTel { get; set; }
        public Int32 oStatus { get; set; }
        public Int32 classid { get; set; }
        public Int32 postid { get; set; }
        public Int32 uType { get; set; }
        public Int32 payType { get; set; }
        public String tName { get; set; }
        public Int32 cid { get; set; }
        public String postTitle { get; set; }
        public Int32 isdel { get; set; }

    }

    public class Home_zjMsg
    {
        public Int32 id { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 ClassId { get; set; }
        public String UserName { get; set; }
        public Int32 oSex { get; set; }
        public String oTel { get; set; }
        public String oContent { get; set; }
        public String IP { get; set; }
        public DateTime AddTime { get; set; }
        public Int32 fwType { get; set; }
        public Int32 zhiye { get; set; }
        public Int32 Manji { get; set; }
        public Int32 Huxing { get; set; }
        public Int32 Jiage { get; set; }
        public Int32 Shoufu { get; set; }
        public String lcyaoqiu { get; set; }
        public String beizhu { get; set; }
        public Int32 isStatus { get; set; }
        public Int32 isdel { get; set; }
        public Int32 isyixiang { get; set; }

    }

    public class SYNC_live_info_1__67
    {
        public Int32 Id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public Int32 Infokind { get; set; }
        public String Title { get; set; }
        public String info { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String Password { get; set; }
        public String sh_CompName { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 countRe { get; set; }
        public String updateuser { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public Int32 ClassId { get; set; }
        public Int32 ClassId2 { get; set; }
        public Int32 ClassId2_2 { get; set; }
        public Int32 ClassId2_3 { get; set; }
        public Int32 ClassId2_4 { get; set; }
        public Int32 ClassId2_5 { get; set; }
        public Int32 source { get; set; }
        public String FWarea { get; set; }
        public Int32 areaId { get; set; }
        public String address { get; set; }
        public Int32 DX_1 { get; set; }
        public Int32 DX_2 { get; set; }
        public Int32 DX_3 { get; set; }
        public Int32 DX_4 { get; set; }
        public String FX_1 { get; set; }
        public String Fx_2 { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 OId { get; set; }
        public Int32 EId { get; set; }
        public Int32 BId { get; set; }
        public Int32 IsStatus { get; set; }

    }

    public class xlp_xk_danyuan
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XlpId { get; set; }
        public String Title { get; set; }
        public Int32 isPx { get; set; }
        public Int32 louhao { get; set; }

    }

    public class job_ms_smscount
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public Int32 jishu { get; set; }
        public DateTime systime { get; set; }

    }

    public class advertise_news_retopic
    {
        public Int32 retopicID { get; set; }
        public Int32 newsID { get; set; }
        public String content { get; set; }
        public String userName { get; set; }
        public String E_mail { get; set; }
        public DateTime editDate { get; set; }
        public Int32 isPass { get; set; }
        public String ip { get; set; }
        public Int32 usertype { get; set; }
        public String realname { get; set; }
        public Int32 siteId { get; set; }

    }

    public class SYNC_pet_info_1__67
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public DateTime systime { get; set; }
        public DateTime uptime { get; set; }
        public Int32 istj { get; set; }
        public DateTime istjtime { get; set; }
        public Int32 iserror { get; set; }
        public Int32 infokind { get; set; }
        public String title { get; set; }
        public String info { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String password { get; set; }
        public Int32 source { get; set; }
        public Int32 gongxu { get; set; }
        public Int32 hclass { get; set; }
        public Int32 price { get; set; }
        public Int32 sex { get; set; }
        public Int32 vaccines { get; set; }
        public Int32 age { get; set; }
        public Int32 ageUnits { get; set; }
        public Int32 shclass { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public Int32 IsStatus { get; set; }
        public Int32 countRe { get; set; }
        public Int32 iszhaoling { get; set; }
        public String color { get; set; }
        public String dsDate { get; set; }
        public String dsdidian { get; set; }
        public String Chouxie { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 fromtype { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class post_isdel
    {
        public Int32 id { get; set; }
        public DateTime systime { get; set; }
        public Int32 siteid { get; set; }
        public String username { get; set; }
        public String title { get; set; }
        public Int32 leibie { get; set; }
        public String tablename { get; set; }
        public Int32 tid { get; set; }
        public String tname { get; set; }
        public String tel { get; set; }

    }

    public class business_info
    {
        public Int32 Id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public Int32 Infokind { get; set; }
        public String Title { get; set; }
        public String info { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String Password { get; set; }
        public String sy_CompName { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 countRe { get; set; }
        public Int32 IsUpby { get; set; }
        public Int32 fromtype { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }
        public Int32 NId { get; set; }

    }

    public class post_setup
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 tabCls { get; set; }
        public Int32 userfabu { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 FBNum { get; set; }
        public Int32 FBNum2 { get; set; }
        public Int32 FBNum3 { get; set; }
        public Int32 SXType { get; set; }
        public Int32 SXNum { get; set; }
        public Int32 SXNum2 { get; set; }
        public Int32 SXNum3 { get; set; }
        public Int32 SXHourNum { get; set; }
        public Int32 SXHourNum2 { get; set; }
        public Int32 SXHourNum3 { get; set; }
        public Int32 TJSmsType { get; set; }
        public String ServicesTel { get; set; }
        public String ServicesQQ { get; set; }
        public Int32 JLViewType { get; set; }
        public Int32 JLNum { get; set; }
        public Int32 JLNum2 { get; set; }
        public Int32 JLNum3 { get; set; }
        public Int32 JLSmsType { get; set; }
        public Int32 MSSmsType { get; set; }
        public Int32 MSNum { get; set; }
        public Int32 MSNum2 { get; set; }
        public Int32 MSNum3 { get; set; }
        public Int32 IsTelMsg { get; set; }

    }

    public class Home_zjKk
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 classid { get; set; }
        public String pageurl { get; set; }
        public String ip { get; set; }
        public String username { get; set; }
        public DateTime addtime { get; set; }

    }

    public class post_countmoney
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 hclass { get; set; }
        public Int32 isnum1 { get; set; }
        public Int32 isnum2 { get; set; }
        public Int32 isnum3 { get; set; }
        public Int32 isnum4 { get; set; }
        public Int32 isnum5 { get; set; }

    }

    public class SYNC_traffic_info_1__67
    {
        public Int32 Id { get; set; }
        public Int32 Siteid { get; set; }
        public String Username { get; set; }
        public DateTime Systime { get; set; }
        public DateTime Uptime { get; set; }
        public Int32 Infokind { get; set; }
        public Int32 Hclass { get; set; }
        public Int32 Istj { get; set; }
        public DateTime Istjtime { get; set; }
        public Int32 Iserror { get; set; }
        public Int32 Ispass { get; set; }
        public String Title { get; set; }
        public Int32 workArea { get; set; }
        public Int32 source { get; set; }
        public String brand { get; set; }
        public Int32 Age { get; set; }
        public String mileage { get; set; }
        public Decimal Price { get; set; }
        public String linkman { get; set; }
        public String tel { get; set; }
        public String email { get; set; }
        public String qq { get; set; }
        public String info { get; set; }
        public String ip { get; set; }
        public Int32 ccoochk { get; set; }
        public Int32 hit { get; set; }
        public String pic { get; set; }
        public String password { get; set; }
        public Int32 IsCmd { get; set; }
        public Int32 ClassId { get; set; }
        public String HtmlArea { get; set; }
        public Int32 isdel { get; set; }
        public Int32 IsSite { get; set; }
        public Int32 infoNum { get; set; }
        public String CreateNum { get; set; }
        public Int32 isstatus { get; set; }
        public Int32 LicenseYear { get; set; }
        public Int32 LicenseMonth { get; set; }
        public Int32 color { get; set; }
        public String emission { get; set; }
        public Int32 gearbox { get; set; }
        public Int32 driveMode { get; set; }
        public String checkEnd { get; set; }
        public Int32 LicenseSell { get; set; }
        public Int32 fromtype { get; set; }
        public Int32 IsHaveCar { get; set; }
        public Int32 Pinche { get; set; }
        public String QiDian { get; set; }
        public String ZhongDian { get; set; }
        public DateTime deparTime { get; set; }
        public Int32 carpoolCls { get; set; }
        public String tujingZhan { get; set; }
        public Int32 countRe { get; set; }
        public Int32 CheXing { get; set; }
        public Int32 IsBaoyang { get; set; }
        public Int32 IsShigu { get; set; }
        public Int32 XinJiu { get; set; }
        public Int32 ShiYong { get; set; }
        public Int32 GouCheYear { get; set; }
        public Int32 DianYa { get; set; }
        public Int32 DianChi { get; set; }
        public Int32 FaDongji { get; set; }
        public Int32 ZuoWei { get; set; }
        public String Map { get; set; }
        public String ShopName { get; set; }
        public Decimal FeiYong { get; set; }
        public Int32 brandN { get; set; }
        public Int32 IsUpby { get; set; }
        public String LCZusername { get; set; }
        public Int32 LCZtype { get; set; }
        public String ischeckuser { get; set; }
        public DateTime ischecktime { get; set; }

    }

    public class Home_xlphuodong_price
    {
        public Int32 id { get; set; }
        public DateTime SysTime { get; set; }
        public Int32 SiteId { get; set; }
        public Int32 XlpId { get; set; }
        public Int32 HdId { get; set; }
        public String UserName { get; set; }
        public String oTitle { get; set; }
        public Int32 price { get; set; }
        public Int32 opx { get; set; }

    }

    public class friend_hjKk
    {
        public Int32 id { get; set; }
        public Int32 siteid { get; set; }
        public Int32 classid { get; set; }
        public String pageurl { get; set; }
        public String ip { get; set; }
        public String username { get; set; }
        public DateTime addtime { get; set; }

    }
}