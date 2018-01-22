using System;
namespace AModel.Entities
{
  
	public class ad_myPlan1  
	{    
		public Int32 id{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int32 compid{ get; set; }   
		public String syear{ get; set; }   
		public String sweek{ get; set; }   
		public String planText{ get; set; }   
		public String opText{ get; set; }   
		public String addUsername{ get; set; }   
		public DateTime addTime{ get; set; }   
		public String lastUsername{ get; set; }   
		public DateTime lastTime{ get; set; }   
	         
	}
  
	public class ad_clientlevel  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public String info{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int32 view_lev{ get; set; }   
	         
	}
  
	public class partner_SiteInfo  
	{    
		public Int32 id{ get; set; }   
		public Int32 siteId{ get; set; }   
		public Int32 parentId{ get; set; }   
		public Int32 ChildId{ get; set; }   
		public Int32 Flag{ get; set; }   
		public DateTime Send_date{ get; set; }   
		public Int32 companyNo{ get; set; }   
		public String editUser{ get; set; }   
		public DateTime editTime{ get; set; }   
	         
	}
  
	public class site_adv  
	{    
		public Int32 id{ get; set; }   
		public Int32 kindid{ get; set; }   
		public Int32 channel{ get; set; }   
		public Int32 pageName{ get; set; }   
		public Int32 placeID{ get; set; }   
		public String username{ get; set; }   
		public String password{ get; set; }   
		public String client_name{ get; set; }   
		public String title{ get; set; }   
		public String weburl{ get; set; }   
		public String memo{ get; set; }   
		public String pic{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public String sitelist{ get; set; }   
		public String sfidlist{ get; set; }   
		public DateTime addtime{ get; set; }   
		public DateTime endtime{ get; set; }   
		public String addUser{ get; set; }   
		public Int16 advState{ get; set; }   
		public Int32 CompanyNO{ get; set; }   
		public Int32 siteID{ get; set; }   
	         
	}
  
	public class danzhou  
	{    
		public Int32 id{ get; set; }   
		public String username{ get; set; }   
		public String password{ get; set; }   
		public String rname{ get; set; }   
		public String tel{ get; set; }   
		public String phone{ get; set; }   
		public String email{ get; set; }   
		public String qq{ get; set; }   
		public String address{ get; set; }   
		public String code{ get; set; }   
	         
	}
  
	public class cwl_mywork3e21_2  
	{    
		public Int32 id{ get; set; }   
		public String planid{ get; set; }   
		public String workid{ get; set; }   
		public String title{ get; set; }   
		public DateTime shijian{ get; set; }   
		public DateTime starttime{ get; set; }   
		public DateTime endtime{ get; set; }   
		public String manager{ get; set; }   
		public String username{ get; set; }   
		public String content{ get; set; }   
		public Int16 ischeck{ get; set; }   
		public Int32 level{ get; set; }   
		public String lishu{ get; set; }   
		public String csname{ get; set; }   
		public Int16 state{ get; set; }   
		public String workuser{ get; set; }   
		public String opuser{ get; set; }   
		public DateTime lasttime{ get; set; }   
		public Int16 ishas{ get; set; }   
		public DateTime sjtime{ get; set; }   
		public Int32 workstyle{ get; set; }   
		public Int32 otherid{ get; set; }   
		public String otherclass{ get; set; }   
		public String companyno{ get; set; }   
		public Int16 isstart{ get; set; }   
		public Int32 score{ get; set; }   
		public Int32 ghour{ get; set; }   
		public Int32 gminute{ get; set; }   
		public String workType{ get; set; }   
		public String JJCD{ get; set; }   
		public String ZYCD{ get; set; }   
		public Int32 parentCode{ get; set; }   
		public Int32 View_id{ get; set; }   
		public Int32 deptType{ get; set; }   
		public Int16 hurrying{ get; set; }   
		public Int32 Childs{ get; set; }   
		public Int16 FromDay{ get; set; }   
		public Int16 EndDay{ get; set; }   
	         
	}
  
	public class cwl_temp_1  
	{    
		public Int32 id{ get; set; }   
		public String planid{ get; set; }   
		public String workid{ get; set; }   
		public String title{ get; set; }   
		public DateTime shijian{ get; set; }   
		public DateTime starttime{ get; set; }   
		public DateTime endtime{ get; set; }   
		public String manager{ get; set; }   
		public String username{ get; set; }   
		public String content{ get; set; }   
		public Int16 ischeck{ get; set; }   
		public Int32 level{ get; set; }   
		public String lishu{ get; set; }   
		public String csname{ get; set; }   
		public Int16 state{ get; set; }   
		public String workuser{ get; set; }   
		public String opuser{ get; set; }   
		public DateTime lasttime{ get; set; }   
		public Int16 ishas{ get; set; }   
		public DateTime sjtime{ get; set; }   
		public Int32 workstyle{ get; set; }   
		public Int32 otherid{ get; set; }   
		public String otherclass{ get; set; }   
		public String companyno{ get; set; }   
		public Int16 isstart{ get; set; }   
		public Int32 score{ get; set; }   
		public Int32 ghour{ get; set; }   
		public Int32 gminute{ get; set; }   
		public String workType{ get; set; }   
		public String JJCD{ get; set; }   
		public String ZYCD{ get; set; }   
		public Int32 parentCode{ get; set; }   
		public Int32 View_id{ get; set; }   
		public Int32 deptType{ get; set; }   
		public Int16 hurrying{ get; set; }   
		public Int32 Childs{ get; set; }   
		public Int16 FromDay{ get; set; }   
		public Int16 EndDay{ get; set; }   
	         
	}
  
	public class cwl_temp_mywork3e21  
	{    
		public Int32 id{ get; set; }   
		public String planid{ get; set; }   
		public String workid{ get; set; }   
		public String title{ get; set; }   
		public DateTime shijian{ get; set; }   
		public DateTime starttime{ get; set; }   
		public DateTime endtime{ get; set; }   
		public String manager{ get; set; }   
		public String username{ get; set; }   
		public String content{ get; set; }   
		public Int16 ischeck{ get; set; }   
		public Int32 level{ get; set; }   
		public String lishu{ get; set; }   
		public String csname{ get; set; }   
		public Int16 state{ get; set; }   
		public String workuser{ get; set; }   
		public String opuser{ get; set; }   
		public DateTime lasttime{ get; set; }   
		public Int16 ishas{ get; set; }   
		public DateTime sjtime{ get; set; }   
		public Int32 workstyle{ get; set; }   
		public Int32 otherid{ get; set; }   
		public String otherclass{ get; set; }   
		public String companyno{ get; set; }   
		public Int16 isstart{ get; set; }   
		public Int32 score{ get; set; }   
		public Int32 ghour{ get; set; }   
		public Int32 gminute{ get; set; }   
		public String workType{ get; set; }   
		public String JJCD{ get; set; }   
		public String ZYCD{ get; set; }   
		public Int32 parentCode{ get; set; }   
		public Int32 View_id{ get; set; }   
		public Int32 deptType{ get; set; }   
		public Int16 hurrying{ get; set; }   
		public Int32 Childs{ get; set; }   
		public Int16 FromDay{ get; set; }   
		public Int16 EndDay{ get; set; }   
	         
	}
  
	public class T_Investigation_Question  
	{    
		public Int32 ID{ get; set; }   
		public Int32 AcID{ get; set; }   
		public Int32 SiteID{ get; set; }   
		public String Title{ get; set; }   
		public Int32 Type{ get; set; }   
		public Int32 IsMust{ get; set; }   
		public Int32 input_num{ get; set; }   
		public Int32 sort{ get; set; }   
		public DateTime CreateTime{ get; set; }   
	         
	}
  
	public class ad_oper3e21  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public Int16 level{ get; set; }   
		public Int32 lishu{ get; set; }   
		public String info{ get; set; }   
		public Int16 isdel{ get; set; }   
		public Int16 siteid{ get; set; }   
		public Int32 view_lev{ get; set; }   
	         
	}
  
	public class site_advPlace  
	{    
		public Int32 id{ get; set; }   
		public String placeName{ get; set; }   
		public Int32 channel{ get; set; }   
		public Int32 pageName{ get; set; }   
		public Int16 viewStyle{ get; set; }   
		public String picSize{ get; set; }   
		public String advW{ get; set; }   
		public String advH{ get; set; }   
		public Int16 sitetype{ get; set; }   
		public Decimal price{ get; set; }   
		public String unit{ get; set; }   
		public String defaultAdv{ get; set; }   
		public String advCode{ get; set; }   
		public String memo{ get; set; }   
	         
	}
  
	public class T_Investigation_Option  
	{    
		public Int32 ID{ get; set; }   
		public Int32 QID{ get; set; }   
		public Int32 SiteID{ get; set; }   
		public String Title{ get; set; }   
		public Int32 sort{ get; set; }   
		public DateTime CreateTime{ get; set; }   
	         
	}
  
	public class area3e21  
	{    
		public Int32 areaid{ get; set; }   
		public String area{ get; set; }   
		public Int32 level{ get; set; }   
		public Int32 lishu{ get; set; }   
		public String flag{ get; set; }   
		public String ename{ get; set; }   
		public String ename2{ get; set; }   
		public String quhao{ get; set; }   
	         
	}
  
	public class site_3e21  
	{    
		public Int32 siteid{ get; set; }   
		public String site_name{ get; set; }   
		public Int32 companyno{ get; set; }   
		public String weburl{ get; set; }   
		public Int16 web_type{ get; set; }   
		public Int16 web_ver{ get; set; }   
		public String web_dir{ get; set; }   
		public Int16 site_styleno{ get; set; }   
		public Int32 catprono{ get; set; }   
		public Int32 areano{ get; set; }   
		public Int16 sfid{ get; set; }   
		public Int16 atwhere{ get; set; }   
		public String areatitle{ get; set; }   
		public String logo{ get; set; }   
		public String banner{ get; set; }   
		public String title{ get; set; }   
		public String memo{ get; set; }   
		public Int16 isview{ get; set; }   
		public Int16 isopen{ get; set; }   
		public Int16 isjf{ get; set; }   
		public Int16 isindex{ get; set; }   
		public Int16 iscity{ get; set; }   
		public DateTime addtime{ get; set; }   
		public DateTime viewtime{ get; set; }   
		public DateTime opentime{ get; set; }   
		public DateTime jftime{ get; set; }   
		public String jfusername{ get; set; }   
		public String yewuyuan{ get; set; }   
		public String addUsername{ get; set; }   
		public Int16 webState{ get; set; }   
		public String qq{ get; set; }   
		public String linkmemo{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public DateTime lastAddtime{ get; set; }   
		public DateTime lastEditime{ get; set; }   
		public Int16 isout{ get; set; }   
		public Int16 lmisview{ get; set; }   
	         
	}
  
	public class mywork3e21  
	{    
		public Int32 id{ get; set; }   
		public String planid{ get; set; }   
		public String workid{ get; set; }   
		public String title{ get; set; }   
		public DateTime shijian{ get; set; }   
		public DateTime starttime{ get; set; }   
		public DateTime endtime{ get; set; }   
		public String manager{ get; set; }   
		public String username{ get; set; }   
		public String content{ get; set; }   
		public Int16 ischeck{ get; set; }   
		public Int32 level{ get; set; }   
		public String lishu{ get; set; }   
		public String csname{ get; set; }   
		public Int16 state{ get; set; }   
		public String workuser{ get; set; }   
		public String opuser{ get; set; }   
		public DateTime lasttime{ get; set; }   
		public Int16 ishas{ get; set; }   
		public DateTime sjtime{ get; set; }   
		public Int32 workstyle{ get; set; }   
		public Int32 otherid{ get; set; }   
		public String otherclass{ get; set; }   
		public String companyno{ get; set; }   
		public Int16 isstart{ get; set; }   
		public Int32 score{ get; set; }   
		public Int32 ghour{ get; set; }   
		public Int32 gminute{ get; set; }   
		public String workType{ get; set; }   
		public String JJCD{ get; set; }   
		public String ZYCD{ get; set; }   
		public Int32 parentCode{ get; set; }   
		public Int32 View_id{ get; set; }   
		public Int32 deptType{ get; set; }   
		public Int16 hurrying{ get; set; }   
		public Int32 Childs{ get; set; }   
		public Int16 FromDay{ get; set; }   
		public Int16 EndDay{ get; set; }   
		public Int16 Flag{ get; set; }   
	         
	}
  
	public class Company_Toproject_3e21  
	{    
		public Int32 id{ get; set; }   
		public Int32 CompanyNo{ get; set; }   
		public Int32 ToProjectId{ get; set; }   
		public String info{ get; set; }   
		public Int32 UserId{ get; set; }   
		public DateTime SendDate{ get; set; }   
		public Int16 Flag{ get; set; }   
	         
	}
  
	public class dept3e21  
	{    
		public Int32 dept_id{ get; set; }   
		public String dept_name{ get; set; }   
		public Int32 dept_code{ get; set; }   
		public Int32 parent_dept{ get; set; }   
		public String dept_type{ get; set; }   
		public Int32 dept_level{ get; set; }   
		public String beizhu{ get; set; }   
		public Int32 area{ get; set; }   
		public String calling{ get; set; }   
		public String name{ get; set; }   
		public String linkman{ get; set; }   
		public String address{ get; set; }   
		public String post{ get; set; }   
		public String tell{ get; set; }   
		public String fax{ get; set; }   
		public String email{ get; set; }   
		public String qq{ get; set; }   
		public String wwwurl{ get; set; }   
		public DateTime opendate{ get; set; }   
		public Int32 zfsj{ get; set; }   
		public Int32 lishu{ get; set; }   
		public Int16 state{ get; set; }   
		public Int16 isdeleted{ get; set; }   
		public String yewuyuan{ get; set; }   
		public DateTime addtime{ get; set; }   
		public String addUsername{ get; set; }   
		public Int32 addsiteid{ get; set; }   
		public String bank{ get; set; }   
		public String cardNo{ get; set; }   
		public String ba{ get; set; }   
		public String Link_Tell{ get; set; }   
		public String Link_email{ get; set; }   
		public String Link_qq{ get; set; }   
		public String Latest_InCome{ get; set; }   
		public String CompTell{ get; set; }   
		public String Numb{ get; set; }   
		public String marketing{ get; set; }   
		public String cost{ get; set; }   
		public String F_gender{ get; set; }   
		public String F_mobile{ get; set; }   
		public String F_lingtong{ get; set; }   
		public String F_borned{ get; set; }   
		public String F_degree{ get; set; }   
		public String F_major{ get; set; }   
		public String F_educated{ get; set; }   
		public String F_homePhone{ get; set; }   
		public String Link_gender{ get; set; }   
		public String Link_mobile{ get; set; }   
		public String Link_lingtong{ get; set; }   
		public String Link_borned{ get; set; }   
		public String Link_degree{ get; set; }   
		public String Link_major{ get; set; }   
		public String Link_educated{ get; set; }   
		public String Link_homePhone{ get; set; }   
		public String Link_areaNo{ get; set; }   
		public String F_areaNo{ get; set; }   
		public String link_memo{ get; set; }   
		public Int32 dept_State{ get; set; }   
		public String dept_jiejue{ get; set; }   
		public Int32 dept_zhuying{ get; set; }   
		public String falv{ get; set; }   
		public String falv_url{ get; set; }   
		public String wangjing_code{ get; set; }   
		public String wangjing_img{ get; set; }   
		public String tongji_code{ get; set; }   
		public String other_code{ get; set; }   
		public String gongan_no{ get; set; }   
		public String gongan_url{ get; set; }   
		public String ben_url{ get; set; }   
		public String ben_img{ get; set; }   
	         
	}
  
	public class Company_users_3e21  
	{    
		public Int32 id{ get; set; }   
		public Int32 CompanyNo{ get; set; }   
		public String RealName{ get; set; }   
		public String linkPhone{ get; set; }   
		public String Email{ get; set; }   
		public String Oicq{ get; set; }   
		public String Introduce{ get; set; }   
		public String Education{ get; set; }   
		public String Industry{ get; set; }   
		public Int16 PositionState{ get; set; }   
		public Int32 RoleId{ get; set; }   
		public String gender{ get; set; }   
		public String degree{ get; set; }   
	         
	}
  
	public class user3e21erp  
	{    
		public Int32 id{ get; set; }   
		public String username{ get; set; }   
		public String password{ get; set; }   
		public String name{ get; set; }   
		public String idcard{ get; set; }   
		public Int32 roleid{ get; set; }   
		public Int32 style{ get; set; }   
		public Int32 state{ get; set; }   
		public Int32 companyno{ get; set; }   
		public Int32 online{ get; set; }   
		public Int32 onlinemenu{ get; set; }   
		public DateTime timeYingPin{ get; set; }   
		public DateTime timeShiYong{ get; set; }   
		public DateTime timeZhengShi{ get; set; }   
		public DateTime timeCunDang{ get; set; }   
		public DateTime timeLiZhi{ get; set; }   
		public DateTime timeJianZhi{ get; set; }   
		public DateTime shijian{ get; set; }   
		public DateTime startTime{ get; set; }   
		public DateTime endTime{ get; set; }   
		public DateTime lastTime{ get; set; }   
		public DateTime updatetime{ get; set; }   
		public String born{ get; set; }   
		public String sheng{ get; set; }   
		public String city{ get; set; }   
		public String sex{ get; set; }   
		public String address{ get; set; }   
		public String tel{ get; set; }   
		public String email{ get; set; }   
		public String oicq{ get; set; }   
		public String homepage{ get; set; }   
		public String pic{ get; set; }   
		public String spec{ get; set; }   
		public String job_id{ get; set; }   
		public String job_name{ get; set; }   
		public String degree{ get; set; }   
		public String school{ get; set; }   
		public String salary{ get; set; }   
		public String salary2{ get; set; }   
		public String marry{ get; set; }   
		public String languages{ get; set; }   
		public String memo{ get; set; }   
		public String fince{ get; set; }   
		public Int16 flag{ get; set; }   
		public String olderby{ get; set; }   
		public Int16 flaga{ get; set; }   
		public String bhight{ get; set; }   
		public String jkzk{ get; set; }   
		public String shgx{ get; set; }   
		public Int32 istj{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public String shouji{ get; set; }   
		public String xiaolingtong{ get; set; }   
		public Int32 Coins{ get; set; }   
		public Int32 admin3{ get; set; }   
		public Int32 admin3_1{ get; set; }   
		public Int32 admin3_2{ get; set; }   
		public Int32 admin3_3{ get; set; }   
	         
	}
  
	public class Partner_JoinAction  
	{    
		public Int32 id{ get; set; }   
		public Int32 CompanyNo{ get; set; }   
		public String userName{ get; set; }   
		public DateTime JoinDate{ get; set; }   
		public Int32 JoinPurpose{ get; set; }   
		public String memo{ get; set; }   
		public Byte Check{ get; set; }   
		public String CheckUser{ get; set; }   
		public DateTime CheckDate{ get; set; }   
	         
	}
  
	public class ProjectInfo_3e21  
	{    
		public Int32 id{ get; set; }   
		public Int32 ProjectId{ get; set; }   
		public DateTime StartTime{ get; set; }   
		public Int16 YunYingZT{ get; set; }   
		public Int16 ProjectState{ get; set; }   
		public String YingLiDian{ get; set; }   
	         
	}
  
	public class ProjectInfo_Assist_3e21  
	{    
		public Int32 id{ get; set; }   
		public Int32 ProjectId{ get; set; }   
		public Int32 CompanyId{ get; set; }   
		public String Partner{ get; set; }   
		public String Advise{ get; set; }   
		public DateTime SendDate{ get; set; }   
	         
	}
  
	public class partner_Const  
	{    
		public Int32 id{ get; set; }   
		public String constName{ get; set; }   
		public Int32 ParentCode{ get; set; }   
		public Int32 Flag{ get; set; }   
	         
	}
  
	public class user_role  
	{    
		public Int32 id{ get; set; }   
		public String username{ get; set; }   
		public String userlist{ get; set; }   
		public String memo{ get; set; }   
	         
	}
  
	public class T_Pro_Efield  
	{    
		public Int32 id{ get; set; }   
		public Int32 Fid{ get; set; }   
		public Int32 Cid{ get; set; }   
		public String Tname{ get; set; }   
		public String DeText{ get; set; }   
		public String field{ get; set; }   
		public Int32 Tlen{ get; set; }   
		public Int32 sort{ get; set; }   
		public Int32 pid{ get; set; }   
		public Int32 count{ get; set; }   
		public DateTime AddTime{ get; set; }   
	         
	}
  
	public class partner_Record  
	{    
		public Int32 id{ get; set; }   
		public Int32 voteid{ get; set; }   
		public String name{ get; set; }   
		public Int32 num{ get; set; }   
		public Int32 flag{ get; set; }   
		public String Memo{ get; set; }   
	         
	}
  
	public class T_Investigation_Quest  
	{    
		public Int32 ID{ get; set; }   
		public String Title{ get; set; }   
		public String Theme{ get; set; }   
		public Int32 SiteID{ get; set; }   
		public Int32 Type{ get; set; }   
		public Int32 RootId{ get; set; }   
		public Int32 Fid{ get; set; }   
		public Int32 Pid{ get; set; }   
		public DateTime CreateTime{ get; set; }   
	         
	}
  
	public class site_web_file  
	{    
		public Int32 l_id{ get; set; }   
		public Int32 b_lanmu{ get; set; }   
		public String lanmu_name{ get; set; }   
		public String weburl{ get; set; }   
		public String url{ get; set; }   
		public String urlPage{ get; set; }   
		public Boolean popedom{ get; set; }   
		public Boolean son{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public Int32 is_person{ get; set; }   
		public Boolean isdeleted{ get; set; }   
		public Byte is_old{ get; set; }   
		public Byte only_index{ get; set; }   
		public Byte state{ get; set; }   
	         
	}
  
	public class site_serverlist  
	{    
		public Int32 servid{ get; set; }   
		public String sIUSR{ get; set; }   
		public String servname{ get; set; }   
		public String servip{ get; set; }   
		public String adduser{ get; set; }   
		public DateTime addtime{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public String memo{ get; set; }   
	         
	}
  
	public class partner_RecordItem  
	{    
		public Int32 id{ get; set; }   
		public String votename{ get; set; }   
		public DateTime uptime{ get; set; }   
		public Byte state{ get; set; }   
		public Int32 Flag{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int32 is_del{ get; set; }   
		public Int32 paiming{ get; set; }   
	         
	}
  
	public class T_Activity_RegistInfo  
	{    
		public Int32 ID{ get; set; }   
		public Int32 UserID{ get; set; }   
		public Int32 SiteID{ get; set; }   
		public Int32 AcID{ get; set; }   
		public String TrueName{ get; set; }   
		public String Phone{ get; set; }   
		public String custom{ get; set; }   
		public Int32 zbAcID{ get; set; }   
		public String custom1{ get; set; }   
		public Int32 State{ get; set; }   
		public DateTime CreateTime{ get; set; }   
		public Int32 ItemId{ get; set; }   
	         
	}
  
	public class site_3e21type  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public String memo{ get; set; }   
	         
	}
  
	public class ad_yewuzu_cy  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public String manager{ get; set; }   
		public String userlist{ get; set; }   
		public Int16 view_lev{ get; set; }   
	         
	}
  
	public class ad_yewuzu  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public String manager{ get; set; }   
		public String userlist{ get; set; }   
		public Int16 view_lev{ get; set; }   
	         
	}
  
	public class WorkRecord  
	{    
		public Int32 id{ get; set; }   
		public String username{ get; set; }   
		public String timefield{ get; set; }   
		public String Content{ get; set; }   
		public Int32 sort{ get; set; }   
		public DateTime createtime{ get; set; }   
		public String FirstContent{ get; set; }   
		public String SecondContent{ get; set; }   
		public String ThirdContent{ get; set; }   
		public String myComment{ get; set; }   
		public String myExperience{ get; set; }   
		public String LeaderComment{ get; set; }   
		public String LeaderAdverise{ get; set; }   
		public String mubiaozl{ get; set; }   
		public DateTime self_ctime{ get; set; }   
		public String self_czl{ get; set; }   
		public String self_Expzl{ get; set; }   
		public DateTime Leader_ctime{ get; set; }   
		public String Leader_czl{ get; set; }   
		public String Leader_Advzl{ get; set; }   
		public DateTime addTime{ get; set; }   
	         
	}
  
	public class ad_myPlan  
	{    
		public Int32 id{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int32 compid{ get; set; }   
		public String syear{ get; set; }   
		public String sweek{ get; set; }   
		public String planText{ get; set; }   
		public String opText{ get; set; }   
		public String addUsername{ get; set; }   
		public DateTime addTime{ get; set; }   
		public String lastUsername{ get; set; }   
		public DateTime lastTime{ get; set; }   
	         
	}
  
	public class partner_Inquest  
	{    
		public Int32 id{ get; set; }   
		public Int32 voteid{ get; set; }   
		public String name{ get; set; }   
		public Int32 flag{ get; set; }   
		public Int32 Value{ get; set; }   
	         
	}
  
	public class myShiWuPingJia3e21  
	{    
		public Int32 id{ get; set; }   
		public Int32 shiWuID{ get; set; }   
		public Int32 weekID{ get; set; }   
		public DateTime dataStart{ get; set; }   
		public DateTime dataEnd{ get; set; }   
		public Int32 manType{ get; set; }   
		public String pingjia{ get; set; }   
		public String memo{ get; set; }   
		public String username{ get; set; }   
		public DateTime addTime{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public Int32 compNo{ get; set; }   
	         
	}
  
	public class T_Operation_UpLog  
	{    
		public Int32 ID{ get; set; }   
		public Int32 UserID{ get; set; }   
		public String UserName{ get; set; }   
		public String Author{ get; set; }   
		public String IP{ get; set; }   
		public Int32 Type{ get; set; }   
		public Int32 TheirID{ get; set; }   
		public DateTime CreateTime{ get; set; }   
	         
	}
  
	public class partner_InquestItem  
	{    
		public Int32 id{ get; set; }   
		public String votename{ get; set; }   
		public Int32 state{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int32 paiming{ get; set; }   
		public Int32 Flag{ get; set; }   
	         
	}
  
	public class myShiWuWeek  
	{    
		public Int32 id{ get; set; }   
		public String title{ get; set; }   
		public DateTime dataStart{ get; set; }   
		public DateTime dataEnd{ get; set; }   
		public DateTime addTime{ get; set; }   
		public String memo{ get; set; }   
		public Int32 compNo{ get; set; }   
	         
	}
  
	public class Partner_DaBiaoInfo  
	{    
		public Int32 id{ get; set; }   
		public Int32 CompanyNo{ get; set; }   
		public Int32 DaBiaoId{ get; set; }   
		public Int32 Score{ get; set; }   
		public Int32 Flag{ get; set; }   
		public DateTime Send_date{ get; set; }   
	         
	}
  
	public class myShiWu3e21   
	{    
		public Int32 id{ get; set; }   
		public Int32 parent{ get; set; }   
		public String kind{ get; set; }   
		public Int32 fezeDept{ get; set; }   
		public Int32 fezeRole{ get; set; }   
		public String fuZe{ get; set; }   
		public Int32 jianDuDept{ get; set; }   
		public Int32 jianDuRole{ get; set; }   
		public String jianDu{ get; set; }   
		public Int32 zhiXingDept{ get; set; }   
		public Int32 zhiXingRole{ get; set; }   
		public String zhiXing{ get; set; }   
		public String memo{ get; set; }   
		public String biaoZhun{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public Int32 compNo{ get; set; }   
		public String zhidu{ get; set; }   
	         
	}
  
	public class ad_clientbasic  
	{    
		public Int32 id{ get; set; }   
		public String gname{ get; set; }   
		public Int16 callid1{ get; set; }   
		public Int16 callid2{ get; set; }   
		public Int32 area1{ get; set; }   
		public Int32 area2{ get; set; }   
		public Int32 area3{ get; set; }   
		public Int16 oper1{ get; set; }   
		public Int16 oper2{ get; set; }   
		public Int32 comp_level{ get; set; }   
		public Int16 xingzhi{ get; set; }   
		public String dizhi{ get; set; }   
		public String youbian{ get; set; }   
		public String dianhua{ get; set; }   
		public String chuanzhen{ get; set; }   
		public String weburl{ get; set; }   
		public String fanwei{ get; set; }   
		public String beizhu{ get; set; }   
		public String lx_ren{ get; set; }   
		public String lx_email{ get; set; }   
		public String lx_tel{ get; set; }   
		public String lx_zhiwu{ get; set; }   
		public String fz_ren{ get; set; }   
		public String fz_tel{ get; set; }   
		public String fz_email{ get; set; }   
		public String fz_zhiwu{ get; set; }   
		public String luruyuan{ get; set; }   
		public String yewuyuan{ get; set; }   
		public DateTime addtime{ get; set; }   
		public DateTime lasttime{ get; set; }   
		public Int16 clientState{ get; set; }   
		public Int16 resultType{ get; set; }   
		public Int16 isbaohu{ get; set; }   
		public String baohuren{ get; set; }   
		public Int32 companyno{ get; set; }   
		public Int32 siteid{ get; set; }   
	         
	}
  
	public class Partner_marketInfo  
	{    
		public Int32 id{ get; set; }   
		public Int32 CompanyNo{ get; set; }   
		public String AddYear{ get; set; }   
		public String AddMonth{ get; set; }   
		public Double WebSite_InCome{ get; set; }   
		public Double Virtual_InCome{ get; set; }   
		public Double Adv_InCome{ get; set; }   
		public Double Other_InCome{ get; set; }   
	         
	}
  
	public class myplan3e21  
	{    
		public Int32 id{ get; set; }   
		public String planid{ get; set; }   
		public String username{ get; set; }   
		public String title{ get; set; }   
		public String content{ get; set; }   
		public DateTime starttime{ get; set; }   
		public DateTime endtime{ get; set; }   
		public String type{ get; set; }   
		public String mylanid{ get; set; }   
		public String manager{ get; set; }   
		public Int16 isj{ get; set; }   
		public String csname{ get; set; }   
		public DateTime lasttime{ get; set; }   
		public DateTime shijian{ get; set; }   
		public Int16 state{ get; set; }   
		public Int16 isrequest{ get; set; }   
		public String style{ get; set; }   
		public String edituser{ get; set; }   
		public DateTime sjtime{ get; set; }   
		public String otherid{ get; set; }   
		public String companyno{ get; set; }   
		public String aim{ get; set; }   
		public String step{ get; set; }   
		public String opinion{ get; set; }   
		public String leadusername{ get; set; }   
	         
	}
  
	public class T_Resource_Class_Category  
	{    
		public Int32 ID{ get; set; }   
		public String Title{ get; set; }   
		public String Description{ get; set; }   
		public Int32 SortValue{ get; set; }   
		public Int32 State{ get; set; }   
		public DateTime DeleteTime{ get; set; }   
		public DateTime CreateTime{ get; set; }   
	         
	}
  
	public class myplanop3e21  
	{    
		public Int32 id{ get; set; }   
		public String planid{ get; set; }   
		public String workid{ get; set; }   
		public String username{ get; set; }   
		public String memo{ get; set; }   
		public String opname{ get; set; }   
		public String objname{ get; set; }   
		public DateTime optime{ get; set; }   
	         
	}
  
	public class adbig_yewuzu  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public String manager{ get; set; }   
		public String userlist{ get; set; }   
		public Int16 view_lev{ get; set; }   
	         
	}
  
	public class crm_toupiao  
	{    
		public Int32 id{ get; set; }   
		public String syear{ get; set; }   
		public String smonth{ get; set; }   
		public Int32 itemID{ get; set; }   
		public String selUser{ get; set; }   
		public String addUser{ get; set; }   
		public DateTime addtime{ get; set; }   
	         
	}
  
	public class crm_touPiaoType  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public String memo{ get; set; }   
	         
	}
  
	public class T_Resource_Category  
	{    
		public Int32 ID{ get; set; }   
		public Int32 class1{ get; set; }   
		public Int32 ParentId{ get; set; }   
		public Int32 Level{ get; set; }   
		public String Title{ get; set; }   
		public String Description{ get; set; }   
		public Int32 SortValue{ get; set; }   
		public Int32 State{ get; set; }   
		public DateTime DeleteTime{ get; set; }   
		public DateTime CreateTime{ get; set; }   
	         
	}
  
	public class email  
	{    
		public Int32 id{ get; set; }   
		public String sender{ get; set; }   
		public String accepter{ get; set; }   
		public String csname{ get; set; }   
		public String title{ get; set; }   
		public String content{ get; set; }   
		public Int32 state{ get; set; }   
		public String style{ get; set; }   
		public Int32 isfile{ get; set; }   
		public DateTime createtime{ get; set; }   
		public Int32 email_size{ get; set; }   
	         
	}
  
	public class email_file  
	{    
		public Int32 id{ get; set; }   
		public Int32 email_id{ get; set; }   
		public String filepath{ get; set; }   
		public String filename{ get; set; }   
		public String filetruename{ get; set; }   
		public Int32 filesize{ get; set; }   
	         
	}
  
	public class email_log  
	{    
		public Int32 id{ get; set; }   
		public String username{ get; set; }   
		public DateTime addtime{ get; set; }   
		public String title{ get; set; }   
		public String fromMail{ get; set; }   
		public String toMail{ get; set; }   
		public String memo{ get; set; }   
		public Int32 modelID{ get; set; }   
	         
	}
  
	public class email_model  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public String memo{ get; set; }   
		public Int32 view_lev{ get; set; }   
	         
	}
  
	public class emaillist  
	{    
		public Int32 id{ get; set; }   
		public String weburl{ get; set; }   
		public String webname{ get; set; }   
		public Int32 userid{ get; set; }   
		public Int16 leavel{ get; set; }   
		public Int32 lishu{ get; set; }   
		public String shuoming{ get; set; }   
	         
	}
  
	public class T_Pro_data  
	{    
		public Int32 id{ get; set; }   
		public Int32 companyNo{ get; set; }   
		public Int32 cid{ get; set; }   
		public String C1{ get; set; }   
		public String C2{ get; set; }   
		public String C3{ get; set; }   
		public String C4{ get; set; }   
		public String C5{ get; set; }   
		public String C6{ get; set; }   
		public String C7{ get; set; }   
		public String C8{ get; set; }   
		public String C9{ get; set; }   
		public String C10{ get; set; }   
		public String C11{ get; set; }   
		public String C12{ get; set; }   
		public String C13{ get; set; }   
		public String C14{ get; set; }   
		public String C15{ get; set; }   
		public String C16{ get; set; }   
		public String C17{ get; set; }   
		public String C18{ get; set; }   
		public String C19{ get; set; }   
		public String C20{ get; set; }   
		public String C21{ get; set; }   
		public String C22{ get; set; }   
		public String C23{ get; set; }   
		public String C24{ get; set; }   
		public String C25{ get; set; }   
		public String C26{ get; set; }   
		public String C27{ get; set; }   
		public String C28{ get; set; }   
		public String C29{ get; set; }   
		public String C30{ get; set; }   
		public Int32 ccoochk{ get; set; }   
		public DateTime AddTime{ get; set; }   
	         
	}
  
	public class email_my  
	{    
		public Int32 id{ get; set; }   
		public Int32 email_id{ get; set; }   
		public String username{ get; set; }   
		public Int32 usernamestate{ get; set; }   
		public Int32 email_state{ get; set; }   
		public Int32 issee{ get; set; }   
	         
	}
  
	public class dabiao_answer  
	{    
		public Int32 answerID{ get; set; }   
		public String title{ get; set; }   
		public Double number{ get; set; }   
		public Int32 typeID{ get; set; }   
		public String info{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public Int16 isdel{ get; set; }   
	         
	}
  
	public class T_Resource_Info  
	{    
		public Int32 ID{ get; set; }   
		public Int32 CID{ get; set; }   
		public Int32 CID1{ get; set; }   
		public Int32 CID2{ get; set; }   
		public Int32 CID3{ get; set; }   
		public Int32 CID4{ get; set; }   
		public Int32 CID5{ get; set; }   
		public Int32 CID6{ get; set; }   
		public Int32 CID7{ get; set; }   
		public Int32 CID8{ get; set; }   
		public Int32 CID9{ get; set; }   
		public String Title{ get; set; }   
		public String Description{ get; set; }   
		public String Author{ get; set; }   
		public Int32 UserID{ get; set; }   
		public String UserName{ get; set; }   
		public String Body{ get; set; }   
		public DateTime UpTime{ get; set; }   
		public DateTime DeleteTime{ get; set; }   
		public DateTime CreateTime{ get; set; }   
	         
	}
  
	public class dabiao_selList  
	{    
		public Int32 id{ get; set; }   
		public String syear{ get; set; }   
		public String smonth{ get; set; }   
		public Int32 compid{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int32 type1ID{ get; set; }   
		public Int32 type2ID{ get; set; }   
		public Int32 type3ID{ get; set; }   
		public Int32 answerID{ get; set; }   
		public Double number{ get; set; }   
		public String username{ get; set; }   
		public DateTime addtime{ get; set; }   
		public String fromIp{ get; set; }   
	         
	}
  
	public class dabiao_type  
	{    
		public Int32 typeid{ get; set; }   
		public String kindName{ get; set; }   
		public Int32 lishu{ get; set; }   
		public String weburl{ get; set; }   
		public Boolean son{ get; set; }   
		public Double totalNumber{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public String memo{ get; set; }   
		public Int16 isdel{ get; set; }   
		public Int32 kind{ get; set; }   
	         
	}
  
	public class Partner_Info_Kind  
	{    
		public Int32 id{ get; set; }   
		public Int32 KindCode{ get; set; }   
		public String KindName{ get; set; }   
		public Int32 paiming{ get; set; }   
	         
	}
  
	public class work_info  
	{    
		public Int32 id{ get; set; }   
		public Int32 docsareaid{ get; set; }   
		public Int32 pic{ get; set; }   
		public String caption{ get; set; }   
		public String contents{ get; set; }   
		public String username{ get; set; }   
		public DateTime updatetime{ get; set; }   
		public DateTime uptime{ get; set; }   
		public Int32 backnum{ get; set; }   
		public Int32 hitnum{ get; set; }   
		public Int32 parent{ get; set; }   
		public Int32 istop{ get; set; }   
		public Int32 ishot{ get; set; }   
		public String ip{ get; set; }   
		public Int32 companyno{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int16 jinji{ get; set; }   
		public Int16 infotype{ get; set; }   
		public Int16 isRenwu{ get; set; }   
		public String opUsers{ get; set; }   
		public String otherUsers{ get; set; }   
		public Int16 opstate{ get; set; }   
		public DateTime opEndDate{ get; set; }   
		public String opMemo{ get; set; }   
		public Boolean isdel{ get; set; }   
	         
	}
  
	public class mng_zhidu  
	{    
		public Int32 id{ get; set; }   
		public String siteName{ get; set; }   
		public String siteurl{ get; set; }   
		public String linkman{ get; set; }   
		public String tel{ get; set; }   
		public String email{ get; set; }   
		public Int32 outflag{ get; set; }   
		public String outuser{ get; set; }   
		public DateTime outtime{ get; set; }   
		public Int32 inflag{ get; set; }   
		public String inuser{ get; set; }   
		public DateTime intime{ get; set; }   
		public String pic{ get; set; }   
		public String title{ get; set; }   
		public String memo{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public Int32 kindid{ get; set; }   
		public Int32 addr1{ get; set; }   
		public Int32 addr2{ get; set; }   
		public Int32 addr3{ get; set; }   
		public Int32 classid{ get; set; }   
		public Int32 category{ get; set; }   
		public Int32 companyno{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int32 isindex{ get; set; }   
	         
	}
  
	public class work_infoback  
	{    
		public Int32 id{ get; set; }   
		public Int32 docsareaid{ get; set; }   
		public Int32 pic{ get; set; }   
		public String caption{ get; set; }   
		public String contents{ get; set; }   
		public String username{ get; set; }   
		public String utype{ get; set; }   
		public DateTime updatetime{ get; set; }   
		public Int32 backnum{ get; set; }   
		public Int32 hitnum{ get; set; }   
		public Int32 parent{ get; set; }   
		public String isobj{ get; set; }   
		public String ispower{ get; set; }   
		public String isutype{ get; set; }   
		public String ip{ get; set; }   
		public Int32 companyno{ get; set; }   
		public Int32 siteid{ get; set; }   
	         
	}
  
	public class work_lanmu  
	{    
		public Int32 bbs_lanmu_id{ get; set; }   
		public Int32 b_lanmu{ get; set; }   
		public String info{ get; set; }   
		public String bbs_lanmu_name{ get; set; }   
		public Int32 level{ get; set; }   
		public Int32 lishu{ get; set; }   
		public String weburl{ get; set; }   
		public Int32 isRenwu{ get; set; }   
		public Int32 companyno{ get; set; }   
		public Int32 deptid{ get; set; }   
		public String manager{ get; set; }   
		public String admin{ get; set; }   
		public Int32 view_lev{ get; set; }   
	         
	}
  
	public class work_state  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public String memo{ get; set; }   
		public Int32 view_lev{ get; set; }   
	         
	}
  
	public class ad_clientStateLog  
	{    
		public Int32 id{ get; set; }   
		public DateTime addTime{ get; set; }   
		public Int16 state{ get; set; }   
		public Int16 oldstate{ get; set; }   
		public Int32 siteid{ get; set; }   
		public Int32 compid{ get; set; }   
		public String adduserName{ get; set; }   
	         
	}
  
	public class com_calling  
	{    
		public Int32 kindid{ get; set; }   
		public Int32 parent{ get; set; }   
		public String kind{ get; set; }   
		public Int32 level{ get; set; }   
		public String explain{ get; set; }   
		public String kindcode{ get; set; }   
		public Int32 xhao{ get; set; }   
		public Int32 companyno{ get; set; }   
		public String pic{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public String tjpic{ get; set; }   
		public String advPic{ get; set; }   
		public String advInfo{ get; set; }   
		public String dir{ get; set; }   
		public String js{ get; set; }   
		public DateTime JsTime{ get; set; }   
	         
	}
  
	public class com_search_log  
	{    
		public Int32 keysID{ get; set; }   
		public String keys{ get; set; }   
		public Int32 keysType{ get; set; }   
		public String fromIp{ get; set; }   
		public DateTime addTime{ get; set; }   
	         
	}
  
	public class T_Pro_Edata  
	{    
		public Int32 id{ get; set; }   
		public Int32 companyNo{ get; set; }   
		public Int32 cid{ get; set; }   
		public String B1{ get; set; }   
		public String B2{ get; set; }   
		public String B3{ get; set; }   
		public String B4{ get; set; }   
		public String B5{ get; set; }   
		public String B6{ get; set; }   
		public String B7{ get; set; }   
		public String B8{ get; set; }   
		public String B9{ get; set; }   
		public String B10{ get; set; }   
		public String B11{ get; set; }   
		public String B12{ get; set; }   
		public String B13{ get; set; }   
		public String B14{ get; set; }   
		public String B15{ get; set; }   
		public String B16{ get; set; }   
		public String B17{ get; set; }   
		public String B18{ get; set; }   
		public String B19{ get; set; }   
		public String B20{ get; set; }   
		public String B21{ get; set; }   
		public String B22{ get; set; }   
		public String B23{ get; set; }   
		public String B24{ get; set; }   
		public String B25{ get; set; }   
		public String B26{ get; set; }   
		public String B27{ get; set; }   
		public String B28{ get; set; }   
		public String B29{ get; set; }   
		public String B30{ get; set; }   
		public DateTime AddTime{ get; set; }   
	         
	}
  
	public class com_site_users  
	{    
		public Int32 id{ get; set; }   
		public String username{ get; set; }   
		public String password{ get; set; }   
		public String introduce{ get; set; }   
		public String service_name{ get; set; }   
		public Int32 kind1{ get; set; }   
		public Int32 kind2{ get; set; }   
		public Int32 kind3{ get; set; }   
		public Int32 area1{ get; set; }   
		public Int32 area2{ get; set; }   
		public Int32 area3{ get; set; }   
		public String linkman{ get; set; }   
		public String phone{ get; set; }   
		public String mobile{ get; set; }   
		public String email{ get; set; }   
		public DateTime regdate{ get; set; }   
		public String homepage{ get; set; }   
		public String keys{ get; set; }   
		public Int32 viewSum{ get; set; }   
		public Int32 istj{ get; set; }   
		public Int32 hit{ get; set; }   
		public Int32 isAgent{ get; set; }   
		public Int32 agentid{ get; set; }   
		public Int32 siteid{ get; set; }   
	         
	}
  
	public class T_Pro_field  
	{    
		public Int32 id{ get; set; }   
		public Int32 Fid{ get; set; }   
		public Int32 Cid{ get; set; }   
		public String Tname{ get; set; }   
		public String field{ get; set; }   
		public Int32 Ttype{ get; set; }   
		public String TtypeVal{ get; set; }   
		public Int32 Tlen{ get; set; }   
		public Int32 sort{ get; set; }   
		public DateTime AddTime{ get; set; }   
	         
	}
  
	public class myworkjd3e21  
	{    
		public Int32 id{ get; set; }   
		public String workid{ get; set; }   
		public Int32 workjd{ get; set; }   
		public String memo{ get; set; }   
		public DateTime updatetime{ get; set; }   
		public String username{ get; set; }   
	         
	}
  
	public class dtproperties  
	{    
		public Int32 id{ get; set; }   
		public Int32 objectid{ get; set; }   
		public String property{ get; set; }   
		public String value{ get; set; }   
		public String uvalue{ get; set; }   
		public Byte[] lvalue{ get; set; }   
		public Int32 version{ get; set; }   
	         
	}
  
	public class ad_clientxingzhi  
	{    
		public Int32 id{ get; set; }   
		public String kind{ get; set; }   
		public String info{ get; set; }   
		public Int32 view_lev{ get; set; }   
		public Int32 siteid{ get; set; }   
	         
	}
}