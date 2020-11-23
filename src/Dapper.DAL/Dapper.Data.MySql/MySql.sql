CREATE TABLE `administrator` (
    `Administrator` varchar(32) CHARACTER SET utf8 NOT NULL,
    `Telphone` varchar(32) CHARACTER SET utf8 NULL,
    `MobileTel` varchar(32) CHARACTER SET utf8 NULL,
    `EMail` varchar(32) CHARACTER SET utf8 NULL,
    `AckLevel` int(11) NULL DEFAULT '0',
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Administrator`)
);


CREATE TABLE `alarmproc` (
    `Proc_Code` int(11) NULL DEFAULT '0',
    `Proc_Module` varchar(32) CHARACTER SET utf8 NULL,
    `Proc_name` varchar(48) CHARACTER SET utf8 NULL,
    `Proc_parm` varchar(200) CHARACTER SET utf8 NULL,
    `Comment` varchar(240) CHARACTER SET utf8 NULL
);


CREATE TABLE `alarmrec` (
    `proc_name` varchar(48) CHARACTER SET utf8 NULL,
    `Administrator` varchar(32) CHARACTER SET utf8 NOT NULL,
    `event` varchar(128) CHARACTER SET utf8 NOT NULL,
    `time` datetime NULL,
    `comment` varchar(64) CHARACTER SET utf8 NULL
);


CREATE TABLE `almreport` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `sta_n` int(11) NULL DEFAULT '0',
    `group_no` int(11) NULL DEFAULT '0',
    `Administrator` varchar(32) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_almreport` PRIMARY KEY (`id`)
);


CREATE TABLE `autoproc` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `iequip_no` int(11) NULL DEFAULT '0',
    `iycyx_no` int(11) NULL DEFAULT '0',
    `iycyx_type` varchar(16) CHARACTER SET utf8 NULL,
    `delay` int(11) NULL DEFAULT '0',
    `oequip_no` int(11) NULL DEFAULT '0',
    `oset_no` int(11) NULL,
    `value` varchar(255) CHARACTER SET utf8 NULL,
    `ProcDesc` varchar(255) CHARACTER SET utf8 NULL,
    `Enable` int(11) NULL DEFAULT '1',
    CONSTRAINT `PK_autoproc` PRIMARY KEY (`ID`)
);


CREATE TABLE `cur_data` (
    `tmdate` datetime NULL,
    `STA_N` int(11) NULL DEFAULT '0',
    `EQUIP_NO` int(11) NULL DEFAULT '0',
    `YC_NO` int(11) NULL DEFAULT '0',
    `data` double NULL
);


CREATE TABLE `cur_idx` (
    `sta_n` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NULL DEFAULT '0',
    `yc_no` int(11) NULL DEFAULT '0',
    `curv_no` int(11) NULL DEFAULT '0'
);


CREATE TABLE `cur_rec` (
    `tmdate` datetime NULL,
    `STA_N` int(11) NULL DEFAULT '0',
    `EQUIP_NO` int(11) NULL DEFAULT '0',
    `YC_NO` int(11) NULL DEFAULT '0',
    `data` longblob NULL
);


CREATE TABLE `drgrdrcd` (
    `guard_no` int(11) NULL DEFAULT '0',
    `door_id` int(11) NULL,
    `card_id` int(11) NULL,
    `Name` varchar(32) CHARACTER SET utf8 NULL,
    `yymmdd` datetime NULL,
    `Action` varchar(64) CHARACTER SET utf8 NULL
);


CREATE TABLE `dutysat` (
    `YYMM` varchar(8) CHARACTER SET utf8 NULL,
    `ID` varchar(8) CHARACTER SET utf8 NOT NULL,
    `Name` varchar(32) CHARACTER SET utf8 NULL,
    `D1` varchar(2) CHARACTER SET utf8 NULL,
    `D2` varchar(2) CHARACTER SET utf8 NULL,
    `D3` varchar(2) CHARACTER SET utf8 NULL,
    `D4` varchar(2) CHARACTER SET utf8 NULL,
    `D5` varchar(2) CHARACTER SET utf8 NULL,
    `D6` varchar(2) CHARACTER SET utf8 NULL,
    `D7` varchar(2) CHARACTER SET utf8 NULL,
    `D8` varchar(2) CHARACTER SET utf8 NULL,
    `D9` varchar(2) CHARACTER SET utf8 NULL,
    `D10` varchar(2) CHARACTER SET utf8 NULL,
    `D11` varchar(2) CHARACTER SET utf8 NULL,
    `D12` varchar(2) CHARACTER SET utf8 NULL,
    `D13` varchar(2) CHARACTER SET utf8 NULL,
    `D14` varchar(2) CHARACTER SET utf8 NULL,
    `D15` varchar(2) CHARACTER SET utf8 NULL,
    `D16` varchar(2) CHARACTER SET utf8 NULL,
    `D17` varchar(2) CHARACTER SET utf8 NULL,
    `D18` varchar(2) CHARACTER SET utf8 NULL,
    `D19` varchar(2) CHARACTER SET utf8 NULL,
    `D20` varchar(2) CHARACTER SET utf8 NULL,
    `D21` varchar(2) CHARACTER SET utf8 NULL,
    `D22` varchar(2) CHARACTER SET utf8 NULL,
    `D23` varchar(2) CHARACTER SET utf8 NULL,
    `D24` varchar(2) CHARACTER SET utf8 NULL,
    `D25` varchar(2) CHARACTER SET utf8 NULL,
    `D26` varchar(2) CHARACTER SET utf8 NULL,
    `D27` varchar(2) CHARACTER SET utf8 NULL,
    `D28` varchar(2) CHARACTER SET utf8 NULL,
    `D29` varchar(2) CHARACTER SET utf8 NULL,
    `D30` varchar(2) CHARACTER SET utf8 NULL,
    `D31` varchar(2) CHARACTER SET utf8 NULL,
    `M_OnTm_Count` int(11) NULL DEFAULT '0',
    `M_Late_Count` int(11) NULL DEFAULT '0',
    `M_LeaveEarly_Count` int(11) NULL DEFAULT '0',
    `A_OnTm_Count` int(11) NULL DEFAULT '0',
    `A_Late_Count` int(11) NULL DEFAULT '0',
    `A_LeaveEarly_Count` int(11) NULL DEFAULT '0'
);


CREATE TABLE `dutyset` (
    `M_InTm_Bgn` varchar(8) CHARACTER SET utf8 NULL,
    `M_InTm_End` varchar(8) CHARACTER SET utf8 NULL,
    `M_Late_Bgn` varchar(8) CHARACTER SET utf8 NULL,
    `M_Late_End` varchar(8) CHARACTER SET utf8 NULL,
    `M_Leave_Early_Bgn` varchar(8) CHARACTER SET utf8 NULL,
    `M_Leave_Early_End` varchar(8) CHARACTER SET utf8 NULL,
    `M_Leave_OnTm_Bgn` varchar(8) CHARACTER SET utf8 NULL,
    `M_Leave_OnTm_End` varchar(8) CHARACTER SET utf8 NULL,
    `A_InTm_Bgn` varchar(8) CHARACTER SET utf8 NULL,
    `A_InTm_End` varchar(8) CHARACTER SET utf8 NULL,
    `A_Late_Bgn` varchar(8) CHARACTER SET utf8 NULL,
    `A_Late_End` varchar(8) CHARACTER SET utf8 NULL,
    `A_Leave_Early_Bgn` varchar(8) CHARACTER SET utf8 NULL,
    `A_Leave_Early_End` varchar(8) CHARACTER SET utf8 NULL,
    `A_Leave_OnTm_Bgn` varchar(8) CHARACTER SET utf8 NULL,
    `A_Leave_OnTm_End` varchar(8) CHARACTER SET utf8 NULL
);


CREATE TABLE `employee` (
    `ID` varchar(8) CHARACTER SET utf8 NOT NULL,
    `Name` varchar(32) CHARACTER SET utf8 NULL,
    `CardNo` varchar(16) CHARACTER SET utf8 NULL
);


CREATE TABLE `equip` (
    `equip_no` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `equip_nm` varchar(64) CHARACTER SET utf8 NOT NULL,
    `equip_detail` varchar(255) CHARACTER SET utf8 NULL,
    `acc_cyc` int(11) NULL,
    `related_pic` varchar(255) CHARACTER SET utf8 NULL,
    `proc_advice` varchar(254) CHARACTER SET utf8 NULL,
    `out_of_contact` varchar(64) CHARACTER SET utf8 NOT NULL,
    `contacted` varchar(64) CHARACTER SET utf8 NULL,
    `event_wav` varchar(64) CHARACTER SET utf8 NULL,
    `communication_drv` varchar(128) CHARACTER SET utf8 NULL,
    `local_addr` varchar(128) CHARACTER SET utf8 NULL,
    `equip_addr` varchar(255) CHARACTER SET utf8 NULL,
    `communication_param` longtext CHARACTER SET utf8 NULL,
    `communication_time_param` varchar(32) CHARACTER SET utf8 NULL,
    `raw_equip_no` int(11) NULL DEFAULT '0',
    `tabname` varchar(15) CHARACTER SET utf8 NULL,
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `attrib` int(11) NULL DEFAULT '0',
    `sta_IP` varchar(255) CHARACTER SET utf8 NULL,
    `AlarmRiseCycle` int(11) NULL DEFAULT '0',
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    `related_video` varchar(255) CHARACTER SET utf8 NULL,
    `ZiChanID` varchar(255) CHARACTER SET utf8 NULL,
    `PlanNo` varchar(255) CHARACTER SET utf8 NULL,
    `SafeTime` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`equip_no`)
);


CREATE TABLE `equipgroup` (
    `group_no` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `group_name` varchar(50) CHARACTER SET utf8 NOT NULL,
    `equipcomb` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`group_no`)
);


CREATE TABLE `equipoperation` (
    `sta_nm` varchar(10) CHARACTER SET utf8 NOT NULL,
    `equip_id` varchar(16) CHARACTER SET utf8 NOT NULL,
    `OPERATION_ID` int(11) NULL DEFAULT '0',
    `OPERATION_TITLE` varchar(255) CHARACTER SET utf8 NOT NULL
);


CREATE TABLE `exproc_all` (
    `Proc_Code` int(11) NULL DEFAULT '0',
    `Proc_Module` varchar(32) CHARACTER SET utf8 NULL,
    `Proc_name` varchar(48) CHARACTER SET utf8 NULL,
    `Proc_parm` varchar(200) CHARACTER SET utf8 NULL,
    `Comment` varchar(240) CHARACTER SET utf8 NULL
);


CREATE TABLE `gisconfig` (
    `ID` int(11) NOT NULL,
    `ControlType` varchar(50) CHARACTER SET utf8 NULL,
    `Location` varchar(50) CHARACTER SET utf8 NULL,
    `Image` varchar(50) CHARACTER SET utf8 NULL,
    `CheckImage` varchar(50) CHARACTER SET utf8 NULL,
    `AlarmImage` varchar(50) CHARACTER SET utf8 NULL,
    `ClickCmd` varchar(50) CHARACTER SET utf8 NULL,
    `AlarmExpression` varchar(50) CHARACTER SET utf8 NULL,
    `Zoom` int(11) NULL DEFAULT '0',
    `MaxZoomNum` int(11) NULL DEFAULT '0',
    `MinZoomNum` int(11) NULL DEFAULT '0',
    `Tooltip` varchar(50) CHARACTER SET utf8 NULL,
    `ImageWith` int(11) NULL DEFAULT '0',
    `ImageHight` int(11) NULL DEFAULT '0',
    `OffsetPoint` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gisconfig` PRIMARY KEY (`ID`)
);


CREATE TABLE `gisrouteconfig` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `RouteName` varchar(255) CHARACTER SET utf8 NULL,
    `StartPoint` varchar(255) CHARACTER SET utf8 NULL,
    `EndPoint` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gisrouteconfig` PRIMARY KEY (`ID`)
);


CREATE TABLE `gw_alarminfo` (
    `Id` int(11) NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `path` longtext CHARACTER SET utf8 NULL,
    `equip_no` int(11) NULL DEFAULT '0',
    `ycyx_type` varchar(255) CHARACTER SET utf8 NULL,
    `ycyx_no` int(11) NULL DEFAULT '0',
    `action` varchar(255) CHARACTER SET utf8 NULL,
    `related_video` varchar(255) CHARACTER SET utf8 NULL,
    `zichan_no` varchar(255) CHARACTER SET utf8 NULL,
    `plan_no` varchar(255) CHARACTER SET utf8 NULL,
    `related_pic` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gw_alarminfo` PRIMARY KEY (`Id`)
);


CREATE TABLE `gw_home_menu` (
    `ID` int(11) NULL,
    `groupID` int(11) NULL,
    `modulName` text CHARACTER SET utf8 NULL,
    `menuName` text CHARACTER SET utf8 NULL,
    `iconName` text CHARACTER SET utf8 NULL,
    `Reserve1` text CHARACTER SET utf8 NULL,
    `Reserve2` text CHARACTER SET utf8 NULL,
    `Reserve3` text CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_home_menu_status` (
    `ID` int(11) NOT NULL,
    `userName` varchar(50) CHARACTER SET utf8 NOT NULL,
    `modulName` varchar(50) CHARACTER SET utf8 NULL,
    `status` varchar(50) CHARACTER SET utf8 NULL,
    `Reserve1` text CHARACTER SET utf8 NULL,
    `Reserve2` text CHARACTER SET utf8 NULL,
    `Reserve3` text CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_language` (
    `id` int(11) NOT NULL,
    `userName` varchar(50) CHARACTER SET utf8 NULL,
    `languageType` int(11) NULL,
    `voiceType` int(11) NULL,
    `Reserve1` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve2` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve3` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_card` (
    `card_id` int(11) NOT NULL,
    `member_id` int(11) NULL,
    `card_no` varchar(255) CHARACTER SET utf8 NULL,
    `pwd` varchar(255) CHARACTER SET utf8 NULL,
    `valid_begin` datetime NULL,
    `valid_end` datetime NULL,
    `valided` bit(1) NOT NULL,
    `Reserve1` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve2` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve3` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve4` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_cardatdoor` (
    `card_id` int(11) NULL,
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `PermitGroup` int(11) NULL
);


CREATE TABLE `gw_mj_cardatdoor_kingkang` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `card_id` int(11) NULL,
    `time_zone_id` int(11) NULL,
    `holiday_flag` bit(1) NOT NULL,
    `anti_submarine_back_flag` bit(1) NOT NULL,
    `master_card_flag` bit(1) NOT NULL,
    `written_flag` bit(1) NOT NULL
);


CREATE TABLE `gw_mj_controller_param_kingkang` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `door_open_time` int(11) NULL,
    `door_open_alarm_time` int(11) NULL,
    `open_door_model` int(11) NULL,
    `multi_card_num` int(11) NULL,
    `door_open_time_out_alarm_flag` bit(1) NOT NULL,
    `door_without_opening_alarm_flag` bit(1) NOT NULL,
    `door_interlock_flag` bit(1) NOT NULL,
    `door_open_close_statue_flag` bit(1) NOT NULL,
    `button_time_zone_limit_flag` bit(1) NOT NULL,
    `password_time_zone_limit_flag` bit(1) NOT NULL,
    `multi_card_flag` bit(1) NOT NULL,
    `card_type_flag` bit(1) NOT NULL,
    `written_flag` bit(1) NOT NULL
);


CREATE TABLE `gw_mj_deptment` (
    `dept_id` int(11) NOT NULL,
    `dept_nm` varchar(255) CHARACTER SET utf8 NULL,
    `valid_begin` datetime NULL,
    `valid_end` datetime NULL
);


CREATE TABLE `gw_mj_doorinfo` (
    `equip_no` int(11) NOT NULL,
    `door_id` int(11) NOT NULL,
    `path` longtext CHARACTER SET utf8 NULL,
    `door_name` varchar(255) CHARACTER SET utf8 NULL,
    `related_video` varchar(255) CHARACTER SET utf8 NULL,
    `ZiChanID` varchar(255) CHARACTER SET utf8 NULL,
    `PlanNo` varchar(255) CHARACTER SET utf8 NULL,
    `Statue` varchar(255) CHARACTER SET utf8 NULL,
    `AttendanceLocusFlag` bit(1) NOT NULL,
    `Reserve1` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve2` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve3` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve4` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_doorparam` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `name` varchar(255) CHARACTER SET utf8 NULL,
    `paramtype` varchar(255) CHARACTER SET utf8 NULL,
    `disName` varchar(255) CHARACTER SET utf8 NULL,
    `value` varchar(255) CHARACTER SET utf8 NULL,
    `isUse` bit(1) NOT NULL,
    `remark` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_drgrdrcd` (
    `guard_no` smallint(6) NULL,
    `door_id` tinyint(4) NULL,
    `card_id` smallint(6) NULL,
    `Name` varchar(32) CHARACTER SET utf8 NULL,
    `yymmdd` datetime NULL,
    `Action` varchar(64) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_holiday` (
    `holiday_id` int(11) NULL,
    `holiday_name` varchar(255) CHARACTER SET utf8 NULL,
    `holiday_start` datetime NULL,
    `holiday_end` datetime NULL
);


CREATE TABLE `gw_mj_holidayatdoor` (
    `holiday_id` int(11) NULL,
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL
);


CREATE TABLE `gw_mj_member` (
    `member_id` int(11) NOT NULL,
    `dept_id` int(11) NULL,
    `member_name` varchar(255) CHARACTER SET utf8 NULL,
    `traffic_group_id` int(11) NULL,
    `tel` varchar(255) CHARACTER SET utf8 NULL,
    `addr` varchar(255) CHARACTER SET utf8 NULL,
    `member_statue` varchar(255) CHARACTER SET utf8 NULL,
    `head_flag` bit(1) NOT NULL DEFAULT b'0',
    `Reserve1` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve2` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve3` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve4` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`member_id`)
);


CREATE TABLE `gw_mj_multicardgroup` (
    `multi_cards_group_id` int(11) NOT NULL,
    `multi_cards_group_nm` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_pre_timezone_kingkang` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `time1_begin` datetime NULL,
    `time1_end` datetime NULL,
    `time2_begin` datetime NULL,
    `time2_end` datetime NULL,
    `time3_begin` datetime NULL,
    `time3_end` datetime NULL,
    `time4_begin` datetime NULL,
    `time4_end` datetime NULL
);


CREATE TABLE `gw_mj_realtimeinout` (
    `guard_no` int(11) NULL,
    `door_id` int(11) NULL,
    `card_id` int(11) NULL,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `yymmdd` datetime NULL,
    `Action` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_timegroup` (
    `time_group_id` int(11) NOT NULL,
    `equip_no` int(11) NULL,
    `time_group_name` varchar(255) CHARACTER SET utf8 NULL,
    `wk_permission` int(11) NULL,
    `time1_begin` datetime NULL,
    `time1_end` datetime NULL,
    `time2_begin` datetime NULL,
    `time2_end` datetime NULL,
    `time3_begin` datetime NULL,
    `time3_end` datetime NULL,
    `Reserve1` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve2` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve3` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve4` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_timezone_kingkang` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `time_zone_id` int(11) NOT NULL,
    `time_zone_name` varchar(255) CHARACTER SET utf8 NULL,
    `w1_time1_begin` datetime NULL,
    `w1_time1_end` datetime NULL,
    `w1_time2_begin` datetime NULL,
    `w1_time2_end` datetime NULL,
    `w1_time3_begin` datetime NULL,
    `w1_time3_end` datetime NULL,
    `w1_time4_begin` datetime NULL,
    `w1_time4_end` datetime NULL,
    `w2_time1_begin` datetime NULL,
    `w2_time1_end` datetime NULL,
    `w2_time2_begin` datetime NULL,
    `w2_time2_end` datetime NULL,
    `w2_time3_begin` datetime NULL,
    `w2_time3_end` datetime NULL,
    `w2_time4_begin` datetime NULL,
    `w2_time4_end` datetime NULL,
    `w3_time1_begin` datetime NULL,
    `w3_time1_end` datetime NULL,
    `w3_time2_begin` datetime NULL,
    `w3_time2_end` datetime NULL,
    `w3_time3_begin` datetime NULL,
    `w3_time3_end` datetime NULL,
    `w3_time4_begin` datetime NULL,
    `w3_time4_end` datetime NULL,
    `w4_time1_begin` datetime NULL,
    `w4_time1_end` datetime NULL,
    `w4_time2_begin` datetime NULL,
    `w4_time2_end` datetime NULL,
    `w4_time3_begin` datetime NULL,
    `w4_time3_end` datetime NULL,
    `w4_time4_begin` datetime NULL,
    `w4_time4_end` datetime NULL,
    `w5_time1_begin` datetime NULL,
    `w5_time1_end` datetime NULL,
    `w5_time2_begin` datetime NULL,
    `w5_time2_end` datetime NULL,
    `w5_time3_begin` datetime NULL,
    `w5_time3_end` datetime NULL,
    `w5_time4_begin` datetime NULL,
    `w5_time4_end` datetime NULL,
    `w6_time1_begin` datetime NULL,
    `w6_time1_end` datetime NULL,
    `w6_time2_begin` datetime NULL,
    `w6_time2_end` datetime NULL,
    `w6_time3_begin` datetime NULL,
    `w6_time3_end` datetime NULL,
    `w6_time4_begin` datetime NULL,
    `w6_time4_end` datetime NULL,
    `w7_time1_begin` datetime NULL,
    `w7_time1_end` datetime NULL,
    `w7_time2_begin` datetime NULL,
    `w7_time2_end` datetime NULL,
    `w7_time3_begin` datetime NULL,
    `w7_time3_end` datetime NULL,
    `w7_time4_begin` datetime NULL,
    `w7_time4_end` datetime NULL,
    `Reserve1` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve2` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve3` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve4` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_traffic_group` (
    `Group_Id` int(11) NULL,
    `Group_Name` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_mj_traffic_groupatdoor_kingkang` (
    `equip_no` int(11) NULL,
    `door_id` int(11) NULL,
    `group_id` int(11) NULL,
    `time_zone_id` int(11) NULL,
    `holiday_flag` bit(1) NOT NULL,
    `anti_submarine_back_flag` bit(1) NOT NULL,
    `master_card_flag` bit(1) NOT NULL
);


CREATE TABLE `gw_patrol_card` (
    `CardId` int(11) NOT NULL AUTO_INCREMENT,
    `CardNo` varchar(255) CHARACTER SET utf8 NULL,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `Type` int(11) NULL,
    `Orders` int(11) NULL,
    `GroupId` int(11) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`CardId`)
);


CREATE TABLE `gw_patrol_cardtype` (
    `TypeId` int(11) NOT NULL,
    `TypeName` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`TypeId`)
);


CREATE TABLE `gw_patrol_comport` (
    `MeterType` int(11) NOT NULL,
    `CommunicationParam` varchar(255) CHARACTER SET utf8 NULL,
    `Port` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`MeterType`)
);


CREATE TABLE `gw_patrol_exception` (
    `ExpId` varchar(255) CHARACTER SET utf8 NOT NULL,
    `ExpName` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`ExpId`)
);


CREATE TABLE `gw_patrol_meter` (
    `MeterId` int(11) NOT NULL AUTO_INCREMENT,
    `MeterNo` varchar(255) CHARACTER SET utf8 NULL,
    `RouteId` int(11) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`MeterId`)
);


CREATE TABLE `gw_patrol_patrolgroup` (
    `GroupId` int(11) NOT NULL AUTO_INCREMENT,
    `GroupName` varchar(255) CHARACTER SET utf8 NULL,
    `ParentId` int(11) NULL DEFAULT '0',
    CONSTRAINT `PRIMARY` PRIMARY KEY (`GroupId`)
);


CREATE TABLE `gw_patrol_plandetails` (
    `PlanTableId` int(11) NULL DEFAULT '0',
    `RouteId` int(11) NULL DEFAULT '0',
    `LocusId` varchar(255) CHARACTER SET utf8 NULL,
    `InspectorId` int(11) NULL DEFAULT '0',
    `BeginTime` datetime NULL,
    `EndTime` datetime NULL,
    `ArrivedTime` datetime NULL,
    `State` int(11) NULL DEFAULT '3',
    `ExceptionId` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_patrol_plantable` (
    `PlanTableId` int(11) NULL,
    `ExecuteDate` datetime NULL,
    `PlanMode` int(11) NULL,
    `RouteId` int(11) NULL,
    `Permit` int(11) NULL,
    `Later` int(11) NULL
);


CREATE TABLE `gw_patrol_plantabledaylist` (
    `PlanTableDayListId` int(11) NULL,
    `PlanTableId` int(11) NULL,
    `Day` int(11) NULL,
    `Orders` int(11) NULL
);


CREATE TABLE `gw_patrol_plantableinspectorlist` (
    `PlanTableInspectorListID` int(11) NULL,
    `PlanTableID` int(11) NULL,
    `InspectorID` int(11) NULL,
    `Orders` int(11) NULL
);


CREATE TABLE `gw_patrol_plantabletimelist` (
    `PlanTableTimeListId` int(11) NULL,
    `PlanTableId` int(11) NULL,
    `FromTime` datetime NULL,
    `ToTime` datetime NULL,
    `Orders` int(11) NULL
);


CREATE TABLE `gw_patrol_record_origin` (
    `Id` int(11) NOT NULL AUTO_INCREMENT,
    `Locus` varchar(255) CHARACTER SET utf8 NULL,
    `PatrolMan` varchar(255) CHARACTER SET utf8 NULL,
    `Time` datetime NULL,
    `MeterId` varchar(255) CHARACTER SET utf8 NULL,
    `ExceptionId` varchar(255) CHARACTER SET utf8 NULL DEFAULT '0',
    CONSTRAINT `PK_gw_patrol_record_origin` PRIMARY KEY (`Id`)
);


CREATE TABLE `gw_patrol_result` (
    `RouteName` varchar(255) CHARACTER SET utf8 NULL,
    `LocusCardNo` varchar(255) CHARACTER SET utf8 NULL,
    `LocusName` varchar(255) CHARACTER SET utf8 NULL,
    `InspectorName` varchar(255) CHARACTER SET utf8 NULL,
    `BeginTime` datetime NULL,
    `EndTime` datetime NULL,
    `ArrivedTime` datetime NULL,
    `StateName` varchar(255) CHARACTER SET utf8 NULL,
    `ExceptionName` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_patrol_route` (
    `RouteId` int(11) NOT NULL AUTO_INCREMENT,
    `RouteName` varchar(255) CHARACTER SET utf8 NULL,
    `ParentId` int(11) NULL DEFAULT '0',
    CONSTRAINT `PRIMARY` PRIMARY KEY (`RouteId`)
);


CREATE TABLE `gw_patrol_routesetting` (
    `SetId` int(11) NOT NULL AUTO_INCREMENT,
    `RouteId` int(11) NULL,
    `LocusId` int(11) NULL DEFAULT '0',
    `ArriaveTime` datetime NULL,
    `StayTime` int(11) NULL,
    `Orders` int(11) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`SetId`)
);


CREATE TABLE `gw_patrol_status` (
    `ID` int(11) NOT NULL,
    `Status` varchar(50) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gw_patrol_status` PRIMARY KEY (`ID`)
);


CREATE TABLE `gw_ptzcontrol` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `EquipNum` int(11) NULL DEFAULT '0',
    `ChannelNum` int(11) NULL DEFAULT '0',
    `ControlEquip` int(11) NULL DEFAULT '0',
    `PTZTop` int(11) NULL DEFAULT '0',
    `PTZBottom` int(11) NULL DEFAULT '0',
    `PTZLeft` int(11) NULL DEFAULT '0',
    `PTZRight` int(11) NULL DEFAULT '0',
    `PTZZoomP` int(11) NULL DEFAULT '0',
    `PTZZoomD` int(11) NULL DEFAULT '0',
    `PTZPreset` int(11) NULL DEFAULT '0',
    `PTZPresetValue` int(11) NULL DEFAULT '0',
    CONSTRAINT `PK_gw_ptzcontrol` PRIMARY KEY (`ID`)
);


CREATE TABLE `gw_qr_check` (
    `qrtype` int(11) NULL DEFAULT '0',
    `qrcreatname` varchar(255) CHARACTER SET utf8 NULL,
    `vistorname` varchar(255) CHARACTER SET utf8 NULL,
    `actionid` varchar(255) CHARACTER SET utf8 NOT NULL,
    `insertdate` datetime NULL,
    `result` int(11) NULL DEFAULT '0',
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_qr_record` (
    `qrtype` int(11) NULL DEFAULT '0',
    `qrcreatname` varchar(255) CHARACTER SET utf8 NULL,
    `vistorname` varchar(255) CHARACTER SET utf8 NULL,
    `actionid` varchar(255) CHARACTER SET utf8 NOT NULL,
    `insertdate` datetime NULL,
    `result` int(11) NULL DEFAULT '0',
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_sp_area` (
    `AreaID` int(11) NOT NULL AUTO_INCREMENT,
    `AreaName` longtext CHARACTER SET utf8 NULL,
    `AreaDvr_Channel` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`AreaID`)
);


CREATE TABLE `gw_sp_channel` (
    `ID` int(11) NOT NULL,
    `DvrID` int(11) NULL,
    `ChannelID` int(11) NULL,
    `ChannelName` longtext CHARACTER SET utf8 NULL,
    `IsCound` bit(1) NOT NULL DEFAULT b'0',
    `CompactName` varchar(255) CHARACTER SET utf8 NULL,
    `equip_addr` varchar(255) CHARACTER SET utf8 NULL,
    `communication_param` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_sp_dvrinfo` (
    `DvrID` int(11) NOT NULL AUTO_INCREMENT,
    `DvrName` varchar(255) CHARACTER SET utf8 NULL,
    `IP` longtext CHARACTER SET utf8 NULL,
    `UserName` longtext CHARACTER SET utf8 NULL,
    `PassWord` longtext CHARACTER SET utf8 NULL,
    `Port` int(11) NULL,
    `ChannelNum` int(11) NULL,
    `Describe` varchar(255) CHARACTER SET utf8 NULL,
    `DvrType` int(11) NULL DEFAULT '0',
    `CloudMultiple` int(11) NULL DEFAULT '0',
    `CloudSpeed` int(11) NULL DEFAULT '0',
    CONSTRAINT `PRIMARY` PRIMARY KEY (`DvrID`)
);


CREATE TABLE `gw_sp_dvrtype` (
    `DvrTypeID` int(11) NOT NULL AUTO_INCREMENT,
    `DvrTypeName` varchar(50) CHARACTER SET utf8 NULL,
    `ClassName` varchar(50) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`DvrTypeID`)
);


CREATE TABLE `gw_sp_group` (
    `ID` int(11) NOT NULL,
    `GroupName` varchar(255) CHARACTER SET utf8 NULL,
    `GroupList` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_sp_method` (
    `MethodID` int(11) NOT NULL AUTO_INCREMENT,
    `ModulID` int(11) NULL DEFAULT '0',
    `MethodName` varchar(50) CHARACTER SET utf8 NULL,
    `ClassName` varchar(50) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`MethodID`)
);


CREATE TABLE `gw_sp_modul` (
    `ModulID` int(11) NOT NULL AUTO_INCREMENT,
    `ModulName` varchar(50) CHARACTER SET utf8 NULL,
    `DvrTypeID` int(11) NULL DEFAULT '0',
    `ClassName` varchar(50) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`ModulID`)
);


CREATE TABLE `gw_unity_markview` (
    `SceneID` int(11) NULL,
    `ResID` int(11) NULL,
    `VPosition` varchar(255) CHARACTER SET utf8 NULL,
    `Rotation` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_unity_model` (
    `ID` double NULL,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `ResID` double NULL,
    `ParentID` double NULL,
    `SceneID` double NULL,
    `BestViewPos` varchar(255) CHARACTER SET utf8 NULL,
    `ShowMark` double NULL,
    `BestViewRot` varchar(255) CHARACTER SET utf8 NULL,
    `Rotation` varchar(255) CHARACTER SET utf8 NULL,
    `VPosition` varchar(255) CHARACTER SET utf8 NULL,
    `Scale` varchar(255) CHARACTER SET utf8 NULL,
    `ValueCMD` varchar(255) CHARACTER SET utf8 NULL,
    `WarType` double NULL,
    `ClickCMD` varchar(255) CHARACTER SET utf8 NULL,
    `WarCMD` varchar(255) CHARACTER SET utf8 NULL,
    `ToolTip` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_unity_parade` (
    `ID` int(11) NOT NULL,
    `SceneID` int(11) NULL DEFAULT '0',
    `VIndex` int(11) NULL DEFAULT '0',
    `ParadeSpeed` double NULL DEFAULT '0',
    `VPosition` varchar(255) CHARACTER SET utf8 NULL,
    `Rotation` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_unity_resource` (
    `Height` double NULL,
    `ID` double NULL,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `Width` double NULL,
    `Type` double NULL,
    `TexName` varchar(255) CHARACTER SET utf8 NULL,
    `DevName` varchar(255) CHARACTER SET utf8 NULL,
    `BestViewPos` varchar(255) CHARACTER SET utf8 NULL,
    `DevIconColor` varchar(255) CHARACTER SET utf8 NULL,
    `DevIconName` varchar(255) CHARACTER SET utf8 NULL,
    `BestViewRot` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_unity_scene` (
    `ID` int(11) NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `ShowName` varchar(255) CHARACTER SET utf8 NULL,
    `MoveSpeed` double NULL DEFAULT '0',
    `XRotSpeed` double NULL DEFAULT '0',
    `YRotSpeed` double NULL DEFAULT '0',
    `PYMoveSpeed` double NULL DEFAULT '0',
    `PYScaleSpeed` double NULL DEFAULT '0',
    `ParadeSpeed` double NULL DEFAULT '0',
    `ParadeID` int(11) NULL DEFAULT '0',
    `InitPos` varchar(255) CHARACTER SET utf8 NULL,
    `InitRot` varchar(255) CHARACTER SET utf8 NULL,
    `WalkInitPos` varchar(255) CHARACTER SET utf8 NULL,
    `WalkInitRot` varchar(255) CHARACTER SET utf8 NULL,
    `OverLookPos` varchar(255) CHARACTER SET utf8 NULL,
    `OverLookRot` varchar(255) CHARACTER SET utf8 NULL,
    `OverLookSize` double NULL DEFAULT '0',
    `SkyBox` varchar(255) CHARACTER SET utf8 NULL,
    `MinMapSize` varchar(255) CHARACTER SET utf8 NULL,
    `Version` varchar(255) CHARACTER SET utf8 NULL,
    `BundleName` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_video_cyclechannel` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `Channels` longtext CHARACTER SET utf8 NULL,
    `Interval` int(11) NULL DEFAULT '0',
    `Sort` int(11) NULL DEFAULT '0',
    CONSTRAINT `PK_gw_video_cyclechannel` PRIMARY KEY (`ID`)
);


CREATE TABLE `gw_video_preset` (
    `ID` int(11) NOT NULL,
    `ChannelId` int(11) NULL DEFAULT '0',
    `EquipId` int(11) NULL DEFAULT '0',
    `Name` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gw_videoinfo` (
    `sta_n` int(11) NULL DEFAULT '0',
    `EquipNum` int(11) NULL DEFAULT '0',
    `ID` int(11) NOT NULL,
    `ChannelName` varchar(255) CHARACTER SET utf8 NULL,
    `ChannelType` int(11) NULL DEFAULT '0',
    `ChannelNum` varchar(255) CHARACTER SET utf8 NULL,
    `ControlEquip` int(11) NULL DEFAULT '0',
    `Path` longtext CHARACTER SET utf8 NULL,
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    `Action` varchar(255) CHARACTER SET utf8 NULL,
    `StreamType` varchar(255) CHARACTER SET utf8 NULL,
    `RTSP` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gwaddinmodule` (
    `ID` int(11) NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `ClassName` varchar(255) CHARACTER SET utf8 NULL,
    `HelpPath` varchar(255) CHARACTER SET utf8 NULL,
    `MultiScreens` varchar(255) CHARACTER SET utf8 NULL,
    `WebPage` char(1) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwaddinmodule` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwassetinfo` (
    `asset_id` varchar(64) CHARACTER SET utf8 NOT NULL,
    `equip_name` varchar(64) CHARACTER SET utf8 NULL,
    `equip_detail` varchar(255) CHARACTER SET utf8 NULL,
    `equip_image` varchar(255) CHARACTER SET utf8 NULL,
    `equip_location` varchar(255) CHARACTER SET utf8 NULL,
    `equip_type` varchar(64) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`asset_id`)
);


CREATE TABLE `gwbuttonproperty` (
    `gwkey` varchar(255) CHARACTER SET utf8 NOT NULL,
    `gwcommand` longtext CHARACTER SET utf8 NULL,
    `gwdatasouce` varchar(255) CHARACTER SET utf8 NULL,
    `gwtype` varchar(255) CHARACTER SET utf8 NULL,
    `gwtooltip` varchar(255) CHARACTER SET utf8 NULL,
    `gwremark` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`gwkey`)
);


CREATE TABLE `gwdatarecorditems` (
    `equip_no` int(11) NULL,
    `data_type` varchar(1) CHARACTER SET utf8 NULL,
    `ycyx_no` int(11) NULL,
    `data_name` varchar(255) CHARACTER SET utf8 NULL,
    `userName` varchar(50) CHARACTER SET utf8 NULL
);


CREATE TABLE `gwdatarecordresult` (
    `record_time` datetime NULL,
    `equip_no` int(11) NULL,
    `data_type` varchar(1) CHARACTER SET utf8 NOT NULL,
    `ycyx_no` int(11) NULL,
    `data_name` varchar(255) CHARACTER SET utf8 NULL,
    `data_value` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gwdelayaction` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `GW_Sta_n` int(11) NULL DEFAULT '0',
    `GW_Equip_no` int(11) NULL DEFAULT '0',
    `GW_Set_no` int(11) NULL DEFAULT '0',
    `GW_Value` varchar(255) CHARACTER SET utf8 NULL,
    `GW_AddDateTime` datetime NULL,
    `GW_UserNm` varchar(255) CHARACTER SET utf8 NULL,
    `GW_DelayNum` int(11) NULL,
    `GW_State` int(11) NULL,
    `GW_Source` int(11) NULL,
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwdelayaction` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwelevatormaintain` (
    `ID` varchar(255) CHARACTER SET utf8 NULL,
    `MaintainCode` varchar(255) CHARACTER SET utf8 NULL,
    `MaintainName` varchar(255) CHARACTER SET utf8 NULL,
    `MaintainPosition` varchar(255) CHARACTER SET utf8 NULL,
    `Address` varchar(255) CHARACTER SET utf8 NULL,
    `Certificate` varchar(255) CHARACTER SET utf8 NULL,
    `CertificateLevel` varchar(255) CHARACTER SET utf8 NULL,
    `EligibilityScope` varchar(255) CHARACTER SET utf8 NULL,
    `VerificationTime` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gwelevatormarker` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `ElevatorNum` varchar(50) CHARACTER SET utf8 NOT NULL,
    `ElevatorPosition` varchar(50) CHARACTER SET utf8 NULL,
    `ElevatorPlace` longtext CHARACTER SET utf8 NULL,
    `ElevatorInfo` longtext CHARACTER SET utf8 NULL,
    `ElevatorState` int(11) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`ID`, `ElevatorNum`)
);


CREATE TABLE `gwequippages` (
    `ID` int(11) NOT NULL,
    `Name` varchar(255) CHARACTER SET utf8 NULL,
    `Pages` longtext CHARACTER SET utf8 NULL,
    `HelpPath` varchar(255) CHARACTER SET utf8 NULL,
    `MultiScreens` varchar(255) CHARACTER SET utf8 NULL,
    `WebPage` char(1) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwequippages` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwequiptreegroup` (
    `ID` int(11) NOT NULL,
    `Name` varchar(50) CHARACTER SET utf8 NULL,
    `ParentID` int(11) NULL DEFAULT '0',
    CONSTRAINT `PK_gwequiptreegroup` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwequiptreeitem` (
    `EquipID` int(11) NOT NULL,
    `GroupID` int(11) NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`EquipID`, `GroupID`)
);


CREATE TABLE `gwexproc` (
    `Proc_Code` int(11) NOT NULL,
    `Proc_Module` varchar(255) CHARACTER SET utf8 NULL,
    `Proc_name` varchar(255) CHARACTER SET utf8 NULL,
    `Proc_parm` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Proc_Code`)
);


CREATE TABLE `gwexproccmd` (
    `proc_code` int(11) NOT NULL,
    `cmd_nm` varchar(255) CHARACTER SET utf8 NOT NULL,
    `main_instruction` varchar(255) CHARACTER SET utf8 NULL,
    `minor_instruction` varchar(255) CHARACTER SET utf8 NULL,
    `value` varchar(255) CHARACTER SET utf8 NULL,
    `record` bit(1) NOT NULL DEFAULT b'1',
    CONSTRAINT `PRIMARY` PRIMARY KEY (`proc_code`, `cmd_nm`)
);


CREATE TABLE `gwmaintainer` (
    `ID` int(11) NOT NULL,
    `MaintainerName` longtext CHARACTER SET utf8 NULL,
    `MaintainerPosition` longtext CHARACTER SET utf8 NULL,
    `MaintainerInfo` longtext CHARACTER SET utf8 NULL,
    `Phone` longtext CHARACTER SET utf8 NULL,
    `Company` longtext CHARACTER SET utf8 NULL
);


CREATE TABLE `gwmapmarker` (
    `MarkerId` int(11) NOT NULL,
    `MarkerName` longtext CHARACTER SET utf8 NULL,
    `MarkerType` double NOT NULL,
    `Position` longtext CHARACTER SET utf8 NULL,
    `MinZoom` int(11) NULL DEFAULT '0',
    `MaxZoom` int(11) NULL DEFAULT '0',
    `ClassFullName` longtext CHARACTER SET utf8 NULL,
    `Data` longtext CHARACTER SET utf8 NULL,
    `AssemblyName` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    `Path` longtext CHARACTER SET utf8 NULL,
    `DefaultZoom` double NOT NULL,
    `Offset` varchar(255) CHARACTER SET utf8 NULL,
    `GroupID` varchar(255) CHARACTER SET utf8 NOT NULL,
    `xmlns` longtext CHARACTER SET utf8 NULL,
    `zIndex` int(11) NULL DEFAULT '0',
    CONSTRAINT `PRIMARY` PRIMARY KEY (`MarkerId`)
);


CREATE TABLE `gwnavigationproperty` (
    `ID` int(11) NOT NULL,
    `navigate_type` varchar(255) CHARACTER SET utf8 NOT NULL,
    `normal_image` varchar(255) CHARACTER SET utf8 NOT NULL,
    `alarm_image` longtext CHARACTER SET utf8 NOT NULL,
    `guanlian_comb` longtext CHARACTER SET utf8 NULL,
    `page_comb` longtext CHARACTER SET utf8 NULL,
    `enable` int(11) NULL,
    CONSTRAINT `PK_gwnavigationproperty` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwplan` (
    `PlanNo` varchar(255) CHARACTER SET utf8 NOT NULL,
    `Content` longtext CHARACTER SET utf8 NULL,
    `LastEditor` varchar(255) CHARACTER SET utf8 NULL,
    `EditDate` datetime NULL,
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    `IsModel` int(11) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`PlanNo`)
);


CREATE TABLE `gwplanrecord` (
    `PlanNo` varchar(255) CHARACTER SET utf8 NULL,
    `Content` longtext CHARACTER SET utf8 NULL,
    `Editor` varchar(255) CHARACTER SET utf8 NULL,
    `EditDate` datetime NULL,
    `State` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `gwproccycletable` (
    `TableID` int(11) NOT NULL,
    `DoOrder` int(11) NOT NULL,
    `Type` varchar(255) CHARACTER SET utf8 NULL,
    `equip_no` int(11) NULL,
    `set_no` int(11) NULL DEFAULT '0',
    `value` varchar(255) CHARACTER SET utf8 NULL,
    `proc_code` int(11) NULL DEFAULT '0',
    `cmd_nm` varchar(255) CHARACTER SET utf8 NULL,
    `SleepTime` int(11) NULL,
    `SleepUnit` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`TableID`, `DoOrder`)
);


CREATE TABLE `gwproccycletlist` (
    `TableID` int(11) NOT NULL,
    `TableName` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT 'new task',
    `BeginTime` datetime NOT NULL,
    `EndTime` datetime NOT NULL,
    `ZhenDianDo` int(11) NULL,
    `ZhidingDo` int(11) NULL,
    `CycleMustFinish` int(11) NULL,
    `ZhidingTime` datetime NULL,
    `MaxCycleNum` int(11) NULL DEFAULT '0',
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    `Reference` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`TableID`)
);


CREATE TABLE `gwprocspectable` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `DateName` varchar(255) CHARACTER SET utf8 NULL,
    `BeginDate` datetime NOT NULL,
    `EndDate` datetime NOT NULL,
    `TableID` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwprocspectable` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwproctimeeqptable` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `TableID` int(11) NULL DEFAULT '0',
    `Time` datetime NULL,
    `TimeDur` datetime NULL,
    `equip_no` int(11) NULL,
    `set_no` int(11) NULL DEFAULT '0',
    `value` varchar(64) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwproctimeeqptable` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwproctimesystable` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `TableID` int(11) NULL DEFAULT '0',
    `Time` datetime NULL,
    `TimeDur` datetime NULL,
    `proc_code` int(11) NULL DEFAULT '0',
    `cmd_nm` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwproctimesystable` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwproctimetlist` (
    `TableID` int(11) NOT NULL,
    `TableName` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT 'new schedule',
    `Comment` varchar(255) CHARACTER SET utf8 NULL,
    `Reference` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`TableID`)
);


CREATE TABLE `gwprocweektable` (
    `Mon` longtext CHARACTER SET utf8 NULL,
    `Tues` longtext CHARACTER SET utf8 NULL,
    `Wed` longtext CHARACTER SET utf8 NULL,
    `Thurs` longtext CHARACTER SET utf8 NULL,
    `Fri` longtext CHARACTER SET utf8 NULL,
    `Sat` longtext CHARACTER SET utf8 NULL,
    `Sun` longtext CHARACTER SET utf8 NULL
);


CREATE TABLE `gwreportinfo` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `ReportName` varchar(255) CHARACTER SET utf8 NULL,
    `Describe` varchar(255) CHARACTER SET utf8 NULL,
    `FileName` varchar(255) CHARACTER SET utf8 NULL,
    `DllName` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwreportinfo` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwrole` (
    `Name` varchar(128) CHARACTER SET utf8 NOT NULL,
    `ControlEquips` longtext CHARACTER SET utf8 NULL,
    `ControlEquips_Unit` longtext CHARACTER SET utf8 NULL,
    `BrowseEquips` longtext CHARACTER SET utf8 NULL,
    `BrowsePages` longtext CHARACTER SET utf8 NULL,
    `remark` longtext CHARACTER SET utf8 NULL,
    `SpecialBrowseEquip` longtext CHARACTER SET utf8 NULL,
    `SystemModule` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`Name`)
);


CREATE TABLE `gwsnapshotconfig` (
    `ID` int(11) NOT NULL,
    `SnapshotName` varchar(128) CHARACTER SET utf8 NULL,
    `SnapshotLevelMin` int(11) NULL,
    `SnapshotLevelMax` int(11) NULL,
    `MaxCount` int(11) NULL,
    `IsShow` int(11) NULL,
    `IconRes` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwsnapshotconfig` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwuser` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Name` varchar(128) CHARACTER SET utf8 NULL,
    `Password` longtext CHARACTER SET utf8 NULL,
    `Roles` longtext CHARACTER SET utf8 NULL,
    `HomePages` longtext CHARACTER SET utf8 NULL,
    `AutoInspectionPages` longtext CHARACTER SET utf8 NULL,
    `Remark` longtext CHARACTER SET utf8 NULL,
    `ControlLevel` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve1` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve2` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve3` varchar(255) CHARACTER SET utf8 NULL,
    `oppoUser` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwuser` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwwebmapmarker` (
    `MarkerId` int(11) NOT NULL,
    `MarkerName` longtext CHARACTER SET utf8 NULL,
    `MarkerType` decimal(18) NULL,
    `Size` varchar(50) CHARACTER SET utf8 NULL,
    `Position` text CHARACTER SET utf8 NULL,
    `Data` longtext CHARACTER SET utf8 NULL,
    `OffSet` char(10) CHARACTER SET utf8 NULL,
    `Template` varchar(50) CHARACTER SET utf8 NULL,
    `BindCmd` varchar(50) CHARACTER SET utf8 NULL,
    `Destination` varchar(50) CHARACTER SET utf8 NULL,
    `EnableRotation` int(11) NULL,
    `ProjectName` varchar(50) CHARACTER SET utf8 NULL
);


CREATE TABLE `gwzichanrecord` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `ZiChanID` varchar(255) CHARACTER SET utf8 NOT NULL,
    `WeiHuDate` datetime NULL,
    `WeiHuName` varchar(255) CHARACTER SET utf8 NULL,
    `WeiHuRecord` longtext CHARACTER SET utf8 NULL,
    `ItemAddMan` varchar(255) CHARACTER SET utf8 NULL,
    `ItemAddDate` datetime NULL,
    `Pictures` longtext CHARACTER SET utf8 NULL,
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_gwzichanrecord` PRIMARY KEY (`ID`)
);


CREATE TABLE `gwzichantable` (
    `ZiChanID` varchar(255) CHARACTER SET utf8 NOT NULL,
    `ZiChanName` varchar(255) CHARACTER SET utf8 NOT NULL,
    `ZiChanType` varchar(255) CHARACTER SET utf8 NULL,
    `ZiChanImage` varchar(255) CHARACTER SET utf8 NULL,
    `ChangJia` varchar(255) CHARACTER SET utf8 NULL,
    `LianxiRen` varchar(255) CHARACTER SET utf8 NULL,
    `LianxiTel` varchar(255) CHARACTER SET utf8 NULL,
    `LianxiMail` varchar(255) CHARACTER SET utf8 NULL,
    `GouMaiDate` datetime NULL,
    `ZiChanSite` varchar(255) CHARACTER SET utf8 NULL,
    `WeiHuDate` datetime NULL,
    `WeiHuCycle` int(11) NULL,
    `BaoXiuQiXian` datetime NULL,
    `LastEditMan` varchar(255) CHARACTER SET utf8 NULL,
    `LastEditDate` datetime NULL,
    `related_pic` varchar(255) CHARACTER SET utf8 NULL,
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`ZiChanID`)
);


CREATE TABLE `gwzichantableexcolumn` (
    `ColumnNo` varchar(255) CHARACTER SET utf8 NOT NULL,
    `ColumnName` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`ColumnNo`)
);


CREATE TABLE `hsncardno` (
    `sta_n` int(11) NOT NULL,
    `equip_no` int(11) NOT NULL,
    `Card_No` varchar(6) CHARACTER SET utf8 NOT NULL,
    `Card_Code` varchar(10) CHARACTER SET utf8 NOT NULL,
    `Permission` varchar(1) CHARACTER SET utf8 NOT NULL DEFAULT '1'
);


CREATE TABLE `iot_device` (
    `deviceId` varchar(50) CHARACTER SET utf8 NOT NULL,
    `equipNo` int(11) NULL,
    `nodeId` varchar(50) CHARACTER SET utf8 NULL,
    `nodeType` varchar(50) CHARACTER SET utf8 NULL,
    `gatewayId` varchar(50) CHARACTER SET utf8 NULL,
    `createTime` datetime NULL,
    `lastModifiedTime` datetime NULL,
    `description` varchar(255) CHARACTER SET utf8 NULL,
    `manufactureId` varchar(50) CHARACTER SET utf8 NULL,
    `manufactureName` varchar(255) CHARACTER SET utf8 NULL,
    `mac` varchar(50) CHARACTER SET utf8 NULL,
    `location` varchar(255) CHARACTER SET utf8 NULL,
    `deviceType` varchar(50) CHARACTER SET utf8 NULL,
    `model` varchar(50) CHARACTER SET utf8 NULL,
    `swVersion` varchar(50) CHARACTER SET utf8 NULL,
    `fwVersion` varchar(50) CHARACTER SET utf8 NULL,
    `hwVersion` varchar(50) CHARACTER SET utf8 NULL,
    `imsi` varchar(50) CHARACTER SET utf8 NULL,
    `protocolType` varchar(50) CHARACTER SET utf8 NULL,
    `radiusIp` varchar(50) CHARACTER SET utf8 NULL,
    `bridgeId` varchar(50) CHARACTER SET utf8 NULL,
    `sigVersion` varchar(50) CHARACTER SET utf8 NULL,
    `serialNumber` varchar(50) CHARACTER SET utf8 NULL,
    `lnglat` varchar(255) CHARACTER SET utf8 NULL,
    `height` varchar(255) CHARACTER SET utf8 NULL,
    `reportData` longtext CHARACTER SET utf8 NULL,
    `systemType` varchar(50) CHARACTER SET utf8 NULL,
    `systemTypeName` varchar(50) CHARACTER SET utf8 NULL,
    `unitName` varchar(50) CHARACTER SET utf8 NULL,
    `buildName` varchar(50) CHARACTER SET utf8 NULL,
    `areaName` varchar(50) CHARACTER SET utf8 NULL,
    `deviceTypeId` varchar(50) CHARACTER SET utf8 NULL,
    `deviceTypeName` varchar(50) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`deviceId`)
);


CREATE TABLE `iot_deviceservice` (
    `serviceId` varchar(50) CHARACTER SET utf8 NOT NULL,
    `deviceId` varchar(50) CHARACTER SET utf8 NOT NULL,
    `ycYxSetNo` int(11) NULL,
    `serviceType` varchar(50) CHARACTER SET utf8 NULL,
    `serviceModel` varchar(50) CHARACTER SET utf8 NULL,
    `serviceOption` varchar(50) CHARACTER SET utf8 NULL,
    `description` longtext CHARACTER SET utf8 NULL,
    `currentDate` varchar(50) CHARACTER SET utf8 NULL,
    `serviceModelId` varchar(50) CHARACTER SET utf8 NULL,
    `serviceModelName` varchar(50) CHARACTER SET utf8 NULL,
    `reportMode` varchar(50) CHARACTER SET utf8 NULL,
    `reportTimespan` int(11) NOT NULL,
    `reportLimit` float NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`serviceId`, `deviceId`)
);


CREATE TABLE `iot_deviceservicemodel` (
    `serviceModelId` varchar(50) CHARACTER SET utf8 NOT NULL,
    `serviceModelName` varchar(50) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`serviceModelId`)
);


CREATE TABLE `iot_devicetype` (
    `deviceTypeId` varchar(50) CHARACTER SET utf8 NOT NULL,
    `devuceTypeName` varchar(255) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`deviceTypeId`)
);


CREATE TABLE `kingkang_cardatdoor` (
    `card_id` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NULL DEFAULT '0',
    `group_id` int(11) NULL DEFAULT '0'
);


CREATE TABLE `kingkang_dept` (
    `dept_id` int(11) NULL,
    `dept_nm` varchar(24) CHARACTER SET utf8 NOT NULL
);


CREATE TABLE `kingkang_member` (
    `card_id` int(11) NOT NULL,
    `dept_id` int(11) NULL,
    `name` varchar(8) CHARACTER SET utf8 NULL,
    `card_section` int(11) NULL DEFAULT '0',
    `card_code` int(11) NULL DEFAULT '0',
    `pwd` int(11) NULL DEFAULT '0',
    `tel` varchar(16) CHARACTER SET utf8 NULL,
    `addr` varchar(32) CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`card_id`)
);


CREATE TABLE `kingkang_tmg` (
    `equip_no` int(11) NULL DEFAULT '0',
    `group_id` int(11) NULL DEFAULT '0',
    `group_nm` varchar(32) CHARACTER SET utf8 NOT NULL,
    `w1_tm1_bgn` datetime NULL,
    `w1_tm1_end` datetime NULL,
    `w1_tm2_bgn` datetime NULL,
    `w1_tm2_end` datetime NULL,
    `w1_tm3_bgn` datetime NULL,
    `w1_tm3_end` datetime NULL,
    `w1_tm4_bgn` datetime NULL,
    `w1_tm4_end` datetime NULL,
    `w2_tm1_bgn` datetime NULL,
    `w2_tm1_end` datetime NULL,
    `w2_tm2_bgn` datetime NULL,
    `w2_tm2_end` datetime NULL,
    `w2_tm3_bgn` datetime NULL,
    `w2_tm3_end` datetime NULL,
    `w2_tm4_bgn` datetime NULL,
    `w2_tm4_end` datetime NULL,
    `w3_tm1_bgn` datetime NULL,
    `w3_tm1_end` datetime NULL,
    `w3_tm2_bgn` datetime NULL,
    `w3_tm2_end` datetime NULL,
    `w3_tm3_bgn` datetime NULL,
    `w3_tm3_end` datetime NULL,
    `w3_tm4_bgn` datetime NULL,
    `w3_tm4_end` datetime NULL,
    `w4_tm1_bgn` datetime NULL,
    `w4_tm1_end` datetime NULL,
    `w4_tm2_bgn` datetime NULL,
    `w4_tm2_end` datetime NULL,
    `w4_tm3_bgn` datetime NULL,
    `w4_tm3_end` datetime NULL,
    `w4_tm4_bgn` datetime NULL,
    `w4_tm4_end` datetime NULL,
    `w5_tm1_bgn` datetime NULL,
    `w5_tm1_end` datetime NULL,
    `w5_tm2_bgn` datetime NULL,
    `w5_tm2_end` datetime NULL,
    `w5_tm3_bgn` datetime NULL,
    `w5_tm3_end` datetime NULL,
    `w5_tm4_bgn` datetime NULL,
    `w5_tm4_end` datetime NULL,
    `w6_tm1_bgn` datetime NULL,
    `w6_tm1_end` datetime NULL,
    `w6_tm2_bgn` datetime NULL,
    `w6_tm2_end` datetime NULL,
    `w6_tm3_bgn` datetime NULL,
    `w6_tm3_end` datetime NULL,
    `w6_tm4_bgn` datetime NULL,
    `w6_tm4_end` datetime NULL,
    `w7_tm1_bgn` datetime NULL,
    `w7_tm1_end` datetime NULL,
    `w7_tm2_bgn` datetime NULL,
    `w7_tm2_end` datetime NULL,
    `w7_tm3_bgn` datetime NULL,
    `w7_tm3_end` datetime NULL,
    `w7_tm4_bgn` datetime NULL,
    `w7_tm4_end` datetime NULL
);


CREATE TABLE `matafun` (
    `matatype` varchar(5) CHARACTER SET utf8 NULL,
    `mainfunid` varchar(2) CHARACTER SET utf8 NULL,
    `mainfunnm` varchar(10) CHARACTER SET utf8 NULL,
    `minfunid` varchar(2) CHARACTER SET utf8 NULL,
    `minfunnm` varchar(10) CHARACTER SET utf8 NULL
);


CREATE TABLE `mataobj` (
    `matatype` varchar(5) CHARACTER SET utf8 NULL,
    `equiptype` varchar(20) CHARACTER SET utf8 NULL
);


CREATE TABLE `matasubtype` (
    `equiptype` varchar(20) CHARACTER SET utf8 NULL,
    `equipsubtype` varchar(32) CHARACTER SET utf8 NULL
);


CREATE TABLE `matasymb` (
    `MATATYPE` varchar(5) CHARACTER SET utf8 NULL,
    `MATANAME` varchar(20) CHARACTER SET utf8 NULL,
    `MATAARRAY` varchar(4) CHARACTER SET utf8 NULL,
    `MATAPIC` varchar(12) CHARACTER SET utf8 NULL
);


CREATE TABLE `nsladmission` (
    `sta_n` int(11) NOT NULL,
    `equip_no` int(11) NOT NULL,
    `Card_No` varchar(4) CHARACTER SET utf8 NOT NULL,
    `Reader` int(11) NULL DEFAULT '1',
    `Permission` bit(1) NOT NULL DEFAULT b'0'
);


CREATE TABLE `nslcardno` (
    `sta_n` int(11) NOT NULL,
    `equip_no` int(11) NOT NULL,
    `Card_No` varchar(4) CHARACTER SET utf8 NOT NULL,
    `Card_Code` varchar(8) CHARACTER SET utf8 NOT NULL,
    `Pin_code` varchar(4) CHARACTER SET utf8 NULL,
    `Name` varchar(32) CHARACTER SET utf8 NULL,
    `WeekGroup` varchar(1) CHARACTER SET utf8 NOT NULL DEFAULT '1'
);


CREATE TABLE `nsldateg` (
    `TimeGroup` int(11) NOT NULL DEFAULT '1',
    `Admit_Bgn1` varchar(4) CHARACTER SET utf8 NOT NULL,
    `Admit_End1` varchar(4) CHARACTER SET utf8 NULL,
    `Admit_Bgn2` varchar(4) CHARACTER SET utf8 NULL,
    `Admit_End2` varchar(4) CHARACTER SET utf8 NULL
);


CREATE TABLE `nslweekg` (
    `WeekGroup` int(11) NOT NULL,
    `Mon` int(11) NULL DEFAULT '0',
    `Tue` int(11) NULL DEFAULT '0',
    `Wed` int(11) NULL DEFAULT '0',
    `Thu` int(11) NULL DEFAULT '0',
    `Fri` int(11) NULL DEFAULT '0',
    `Sat` int(11) NULL DEFAULT '0',
    `Sun` int(11) NULL DEFAULT '0'
);


CREATE TABLE `operationequip` (
    `sta_nm` varchar(10) CHARACTER SET utf8 NOT NULL,
    `equip_id` varchar(16) CHARACTER SET utf8 NOT NULL,
    `equip_nm` varchar(64) CHARACTER SET utf8 NULL,
    `equiptype` varchar(20) CHARACTER SET utf8 NOT NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`sta_nm`, `equip_id`)
);


CREATE TABLE `operationlog` (
    `OPERATION_ID` int(11) NOT NULL AUTO_INCREMENT,
    `sta_nm` varchar(10) CHARACTER SET utf8 NOT NULL,
    `OPERATION_TITLE` varchar(255) CHARACTER SET utf8 NULL,
    `OPERATION_PERSION` varchar(16) CHARACTER SET utf8 NULL,
    `OPERATION_DATE` datetime NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`OPERATION_ID`)
);


CREATE TABLE `operationrec` (
    `OPERATION_ID` int(11) NOT NULL AUTO_INCREMENT,
    `OPERATION_TITLE` varchar(255) CHARACTER SET utf8 NOT NULL,
    `OPERATION_PERSION` varchar(16) CHARACTER SET utf8 NULL,
    `OPERATION_DATE` datetime NULL,
    `OPERATION_COMMENT` varchar(255) CHARACTER SET utf8 NULL,
    `OPERATION_PROCEDURE` longblob NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`OPERATION_ID`)
);


CREATE TABLE `personnel.faceimage` (
    `PkId` int(11) NOT NULL AUTO_INCREMENT,
    `id` varchar(100) CHARACTER SET utf8 NOT NULL,
    `time` datetime NULL,
    `sourceId` varchar(100) CHARACTER SET utf8 NULL,
    `race` varchar(100) CHARACTER SET utf8 NULL,
    `sourceType` varchar(100) CHARACTER SET utf8 NULL,
    `imageUri` varchar(200) CHARACTER SET utf8 NULL,
    `type` varchar(100) CHARACTER SET utf8 NULL,
    `alarmId` varchar(100) CHARACTER SET utf8 NULL,
    `flagId` int(11) NULL,
    `HashId` bigint(20) NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`PkId`)
);


CREATE TABLE `rawequip` (
    `raw_equip_no` int(11) NULL DEFAULT '0',
    `raw_equip_nm` varchar(64) CHARACTER SET utf8 NULL,
    `equip_detail` varchar(255) CHARACTER SET utf8 NULL,
    `acc_cyc` int(11) NULL DEFAULT '1',
    `related_pic` varchar(16) CHARACTER SET utf8 NULL,
    `proc_advice` varchar(254) CHARACTER SET utf8 NULL,
    `out_of_contact` varchar(64) CHARACTER SET utf8 NOT NULL,
    `contacted` varchar(64) CHARACTER SET utf8 NULL,
    `event_wav` varchar(15) CHARACTER SET utf8 NULL,
    `communicaton_type` int(11) NULL DEFAULT '0',
    `communication_drv` varchar(16) CHARACTER SET utf8 NULL,
    `local_addr` varchar(64) CHARACTER SET utf8 NULL,
    `equip_addr` varchar(128) CHARACTER SET utf8 NULL,
    `communication_param` varchar(64) CHARACTER SET utf8 NULL,
    `communication_time_param` varchar(32) CHARACTER SET utf8 NULL,
    `tabname` varchar(15) CHARACTER SET utf8 NULL,
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `attrib` int(11) NULL DEFAULT '0'
);


CREATE TABLE `rawycp` (
    `raw_equip_no` int(11) NULL DEFAULT '0',
    `raw_yc_no` int(11) NULL DEFAULT '0',
    `raw_yc_nm` varchar(64) CHARACTER SET utf8 NULL,
    `mapping` bit(1) NOT NULL DEFAULT b'0',
    `yc_min` double NULL DEFAULT '0',
    `yc_max` double NULL DEFAULT '1000',
    `physic_min` double NULL DEFAULT '0',
    `physic_max` double NULL DEFAULT '1000',
    `val_min` double NULL,
    `restore_min` double NULL,
    `restore_max` double NULL,
    `val_max` double NULL,
    `val_trait` int(11) NULL DEFAULT '0',
    `main_instruction` varchar(128) CHARACTER SET utf8 NULL,
    `minor_instruction` varchar(128) CHARACTER SET utf8 NULL,
    `safe_bgn` datetime NULL,
    `safe_end` datetime NULL,
    `alarm_acceptable_time` int(11) NULL DEFAULT '0',
    `restore_acceptable_time` int(11) NULL DEFAULT '0',
    `alarm_repeat_time` int(11) NULL DEFAULT '0',
    `proc_advice` varchar(254) CHARACTER SET utf8 NULL,
    `lvl_level` int(11) NULL,
    `outmin_evt` varchar(64) CHARACTER SET utf8 NULL,
    `outmax_evt` varchar(64) CHARACTER SET utf8 NULL,
    `wave_file` varchar(24) CHARACTER SET utf8 NULL,
    `related_pic` int(11) NULL DEFAULT '-1',
    `alarm_scheme` int(11) NULL DEFAULT '1',
    `curve_rcd` bit(1) NOT NULL DEFAULT b'0'
);


CREATE TABLE `rawyxp` (
    `raw_equip_no` int(11) NULL DEFAULT '0',
    `raw_yx_no` int(11) NULL DEFAULT '0',
    `raw_yx_nm` varchar(64) CHARACTER SET utf8 NULL,
    `proc_advice_r` varchar(254) CHARACTER SET utf8 NULL,
    `proc_advice_d` varchar(254) CHARACTER SET utf8 NULL,
    `level_r` int(11) NULL,
    `level_d` int(11) NULL,
    `evt_01` varchar(64) CHARACTER SET utf8 NULL,
    `evt_10` varchar(64) CHARACTER SET utf8 NULL,
    `safe_bgn` datetime NULL,
    `safe_end` datetime NULL,
    `alarm_acceptable_time` int(11) NULL DEFAULT '0',
    `restore_acceptable_time` int(11) NULL DEFAULT '0',
    `alarm_repeat_time` int(11) NULL DEFAULT '0',
    `main_instruction` varchar(128) CHARACTER SET utf8 NULL,
    `minor_instruction` varchar(128) CHARACTER SET utf8 NULL,
    `wave_file` varchar(24) CHARACTER SET utf8 NULL,
    `related_pic` int(11) NULL DEFAULT '-1',
    `inversion` bit(1) NOT NULL DEFAULT b'0',
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `initval` int(11) NULL DEFAULT '0',
    `val_trait` int(11) NULL DEFAULT '0'
);


CREATE TABLE `resdscp` (
    `ResIdenti` varchar(240) CHARACTER SET utf8 NULL,
    `ResName` varchar(48) CHARACTER SET utf8 NULL,
    `ResType` int(11) NULL DEFAULT '1'
);


CREATE TABLE `rtuyxtab` (
    `sta_n` varchar(2) CHARACTER SET utf8 NULL,
    `equip_no` varchar(3) CHARACTER SET utf8 NULL,
    `yx_no` varchar(3) CHARACTER SET utf8 NULL,
    `flag` bit(1) NOT NULL DEFAULT b'0'
);


CREATE TABLE `sc302encode` (
    `sta_n` varchar(2) CHARACTER SET utf8 NOT NULL DEFAULT '01',
    `equip_no` varchar(2) CHARACTER SET utf8 NOT NULL,
    `CardNo` varchar(8) CHARACTER SET utf8 NOT NULL,
    `Pin` varchar(8) CHARACTER SET utf8 NULL,
    `Name` varchar(32) CHARACTER SET utf8 NULL,
    `TimeGroup` varchar(1) CHARACTER SET utf8 NOT NULL DEFAULT '1',
    `Door` varchar(1) CHARACTER SET utf8 NOT NULL DEFAULT '1'
);


CREATE TABLE `sc302timeg` (
    `sta_n` varchar(2) CHARACTER SET utf8 NOT NULL,
    `equip_no` varchar(2) CHARACTER SET utf8 NOT NULL,
    `TimeGroup` varchar(1) CHARACTER SET utf8 NOT NULL,
    `Mon` varchar(8) CHARACTER SET utf8 NULL,
    `Tue` varchar(8) CHARACTER SET utf8 NULL,
    `Wed` varchar(8) CHARACTER SET utf8 NULL,
    `Thu` varchar(8) CHARACTER SET utf8 NULL,
    `Fri` varchar(8) CHARACTER SET utf8 NULL,
    `Sat` varchar(8) CHARACTER SET utf8 NULL,
    `Sun` varchar(8) CHARACTER SET utf8 NULL
);


CREATE TABLE `setevt` (
    `sta_n` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NOT NULL,
    `event` varchar(128) CHARACTER SET utf8 NOT NULL,
    `time` datetime NOT NULL,
    `operator` longtext CHARACTER SET utf8 NOT NULL,
    `gwsource` longtext CHARACTER SET utf8 NULL
);


CREATE TABLE `setparm` (
    `equip_no` int(11) NOT NULL,
    `set_no` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `set_nm` longtext CHARACTER SET utf8 NULL,
    `set_type` varchar(1) CHARACTER SET utf8 NULL,
    `main_instruction` varchar(64) CHARACTER SET utf8 NULL,
    `minor_instruction` longtext CHARACTER SET utf8 NULL,
    `record` bit(1) NOT NULL DEFAULT b'1',
    `action` varchar(16) CHARACTER SET utf8 NULL DEFAULT '设置',
    `value` longtext CHARACTER SET utf8 NULL,
    `canexecution` bit(1) NOT NULL DEFAULT b'1',
    `VoiceKeys` longtext CHARACTER SET utf8 NULL,
    `EnableVoice` bit(1) NOT NULL DEFAULT b'0',
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    `qr_equip_no` int(11) NULL DEFAULT '0',
    CONSTRAINT `PRIMARY` PRIMARY KEY (`equip_no`, `set_no`)
);


CREATE TABLE `smsreqcont` (
    `ReqID` int(11) NULL DEFAULT '0',
    `Task` varchar(128) CHARACTER SET utf8 NULL,
    `Type` varchar(2) CHARACTER SET utf8 NULL,
    `EquipNo` int(11) NULL,
    `YcYxNo` int(11) NULL,
    `main_instruction` varchar(64) CHARACTER SET utf8 NULL,
    `minor_instruction` varchar(64) CHARACTER SET utf8 NULL,
    `value` varchar(32) CHARACTER SET utf8 NULL,
    `Remark` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `smsreqlist` (
    `ReqID` int(11) NULL DEFAULT '0',
    `ReqName` varchar(64) CHARACTER SET utf8 NULL,
    `Comment` varchar(128) CHARACTER SET utf8 NULL
);


CREATE TABLE `spealmreport` (
    `id` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `group_no` int(11) NULL DEFAULT '0',
    `Administrator` varchar(32) CHARACTER SET utf8 NULL,
    `begin_time` datetime NULL,
    `end_time` datetime NULL,
    `remark` longtext CHARACTER SET utf8 NULL
);


CREATE TABLE `station` (
    `sta_n` int(11) NULL DEFAULT '0',
    `sta_nm` varchar(64) CHARACTER SET utf8 NOT NULL,
    `sta_type` int(11) NULL DEFAULT '0'
);


CREATE TABLE `syappg` (
    `AppG` int(11) NULL DEFAULT '0',
    `opendoor1` bit(1) NOT NULL DEFAULT b'0',
    `opendoor2` bit(1) NOT NULL DEFAULT b'0',
    `opendoor3` bit(1) NOT NULL DEFAULT b'0',
    `opendoor4` bit(1) NOT NULL DEFAULT b'0',
    `outdoor1` bit(1) NOT NULL DEFAULT b'0',
    `outdoor2` bit(1) NOT NULL DEFAULT b'0',
    `outdoor3` bit(1) NOT NULL DEFAULT b'0',
    `outdoor4` bit(1) NOT NULL DEFAULT b'0',
    `perpintz1` int(11) NULL DEFAULT '0',
    `perpintz2` int(11) NULL DEFAULT '0',
    `perpintz3` int(11) NULL DEFAULT '0',
    `perpintz4` int(11) NULL DEFAULT '0',
    `secpintz1` int(11) NULL DEFAULT '0',
    `secpintz2` int(11) NULL DEFAULT '0',
    `secpintz3` int(11) NULL DEFAULT '0',
    `secpintz4` int(11) NULL DEFAULT '0',
    `weekdataG` int(11) NULL DEFAULT '0'
);


CREATE TABLE `sycardno` (
    `sta_n` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NULL DEFAULT '0',
    `name` varchar(8) CHARACTER SET utf8 NULL,
    `card_no` varchar(50) CHARACTER SET utf8 NULL,
    `cardid` varchar(50) CHARACTER SET utf8 NULL,
    `app` varchar(2) CHARACTER SET utf8 NULL,
    `cardtype` varchar(2) CHARACTER SET utf8 NULL,
    `pin` varchar(50) CHARACTER SET utf8 NULL
);


CREATE TABLE `sydatag` (
    `DataGroup` int(11) NULL DEFAULT '0',
    `TimeG1` int(11) NULL DEFAULT '0',
    `TimeG2` int(11) NULL DEFAULT '0',
    `TimeG3` int(11) NULL DEFAULT '0'
);


CREATE TABLE `sysevt` (
    `sta_n` int(11) NULL DEFAULT '0',
    `event` longtext CHARACTER SET utf8 NULL,
    `time` datetime NOT NULL,
    `confirmname` varchar(128) CHARACTER SET utf8 NULL,
    `confirmtime` datetime NULL,
    `confirmremark` varchar(255) CHARACTER SET utf8 NULL,
    `GUID` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `sytimeg` (
    `TimeGroup` int(11) NULL DEFAULT '0',
    `Admit_Bgn` varchar(4) CHARACTER SET utf8 NULL,
    `Admit_End` varchar(4) CHARACTER SET utf8 NULL
);


CREATE TABLE `tc_inoutls` (
    `ID` int(11) NOT NULL AUTO_INCREMENT,
    `Car_No` varchar(255) CHARACTER SET utf8 NULL,
    `Card_no` varchar(255) CHARACTER SET utf8 NULL,
    `Ctrl_No_i` varchar(255) CHARACTER SET utf8 NULL,
    `Ctrl_No_InVideo` varchar(255) CHARACTER SET utf8 NULL,
    `Ctrl_No_o` varchar(255) CHARACTER SET utf8 NULL,
    `Ctrl_No_OutVideo` varchar(255) CHARACTER SET utf8 NULL,
    `CardType` varchar(255) CHARACTER SET utf8 NULL,
    `Car_Type` varchar(255) CHARACTER SET utf8 NULL,
    `In_time` datetime NULL,
    `Out_time` datetime NULL,
    CONSTRAINT `PK_tc_inoutls` PRIMARY KEY (`ID`)
);


CREATE TABLE `telphone` (
    `sta_n` varchar(2) CHARACTER SET utf8 NOT NULL,
    `equip_no` varchar(2) CHARACTER SET utf8 NOT NULL,
    `phone_num` varchar(30) CHARACTER SET utf8 NOT NULL,
    `name` varchar(30) CHARACTER SET utf8 NULL,
    `permit` bit(1) NOT NULL DEFAULT b'0',
    `if_call_machine` bit(1) NOT NULL DEFAULT b'0',
    `wait_before_speak` int(11) NULL DEFAULT '0',
    `call_machine_funct_key` varchar(15) CHARACTER SET utf8 NULL,
    `call_machine_final_key` varchar(50) CHARACTER SET utf8 NULL,
    `dial_interval` int(11) NULL DEFAULT '0',
    `dial_repeat` int(11) NULL DEFAULT '0',
    CONSTRAINT `PRIMARY` PRIMARY KEY (`sta_n`, `equip_no`, `phone_num`)
);


CREATE TABLE `visitorrecord` (
    `ID` double NOT NULL,
    `sex` varchar(255) CHARACTER SET utf8 NULL,
    `Visitor` varchar(255) CHARACTER SET utf8 NULL,
    `LicenseCode` varchar(255) CHARACTER SET utf8 NULL,
    `LicenseType` varchar(255) CHARACTER SET utf8 NULL,
    `Address` longtext CHARACTER SET utf8 NULL,
    `Nation` varchar(255) CHARACTER SET utf8 NULL,
    `Birthday` datetime NULL,
    `IssuingAgency` longtext CHARACTER SET utf8 NULL,
    `LicEndDate` datetime NULL,
    `LicStartDate` datetime NULL,
    `Phone` double NULL,
    `Remark` longtext CHARACTER SET utf8 NULL,
    `Company` longtext CHARACTER SET utf8 NULL,
    `PeerNum` double NULL,
    `Event` varchar(255) CHARACTER SET utf8 NULL,
    `VisitingTime` datetime NULL,
    `Photo` longtext CHARACTER SET utf8 NULL,
    `QRCode` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_visitorrecord` PRIMARY KEY (`ID`)
);


CREATE TABLE `weekalmreport` (
    `id` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `group_no` int(11) NULL DEFAULT '0',
    `Administrator` varchar(32) CHARACTER SET utf8 NULL,
    `week_day` int(11) NULL DEFAULT '0',
    `begin_time` datetime NULL,
    `end_time` datetime NULL,
    `remark` longtext CHARACTER SET utf8 NULL
);


CREATE TABLE `weekdatag` (
    `ID` int(11) NULL DEFAULT '0',
    `sun` int(11) NULL DEFAULT '0',
    `mon` int(11) NULL DEFAULT '0',
    `tue` int(11) NULL DEFAULT '0',
    `wes` int(11) NULL DEFAULT '0',
    `tur` int(11) NULL DEFAULT '0',
    `thi` int(11) NULL DEFAULT '0',
    `sat` int(11) NULL DEFAULT '0'
);


CREATE TABLE `welcomingspeech` (
    `JSONContent` text CHARACTER SET utf8 NULL,
    `BgImage` text CHARACTER SET utf8 NULL,
    `Type` int(11) NULL,
    `siginalVal` text CHARACTER SET utf8 NULL,
    `ID` int(11) NOT NULL
);


CREATE TABLE `woacceptorder` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `work_order_id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `current_processor` int(11) NOT NULL,
    `personnel` varchar(30) CHARACTER SET utf8 NOT NULL,
    `claim` int(11) NOT NULL,
    `transfer_personnel` varchar(30) CHARACTER SET utf8 NOT NULL,
    `created_time` varchar(30) CHARACTER SET utf8 NOT NULL,
    CONSTRAINT `PK_woacceptorder` PRIMARY KEY (`id`)
);


CREATE TABLE `woattachment` (
    `id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `work_order_id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `save_date` varchar(20) CHARACTER SET utf8 NOT NULL,
    `name` varchar(30) CHARACTER SET utf8 NOT NULL,
    `extension` varchar(10) CHARACTER SET utf8 NOT NULL,
    `created_time` varchar(30) CHARACTER SET utf8 NOT NULL,
    CONSTRAINT `PK_woattachment` PRIMARY KEY (`id`)
);


CREATE TABLE `womainfeedbackattachment` (
    `id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `feedback_id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `save_date` varchar(20) CHARACTER SET utf8 NOT NULL,
    `name` varchar(30) CHARACTER SET utf8 NOT NULL,
    `extension` varchar(10) CHARACTER SET utf8 NOT NULL,
    `created_time` datetime NOT NULL,
    CONSTRAINT `PK_womainfeedbackattachment` PRIMARY KEY (`id`)
);


CREATE TABLE `womainfeedbackconfirm` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `work_order_id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `feedback_id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `status` int(11) NOT NULL,
    `remark` longtext CHARACTER SET utf8 NULL,
    `creator` varchar(30) CHARACTER SET utf8 NOT NULL,
    `created_time` datetime NOT NULL,
    CONSTRAINT `PK_womainfeedbackconfirm` PRIMARY KEY (`id`)
);


CREATE TABLE `womaintenancefeedback` (
    `id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `accept_order_id` int(11) NOT NULL,
    `level` int(11) NOT NULL,
    `maintenance_time` varchar(30) CHARACTER SET utf8 NOT NULL,
    `status` int(11) NOT NULL,
    `cause_issue` longtext CHARACTER SET utf8 NULL,
    `process_content` longtext CHARACTER SET utf8 NULL,
    `created_time` varchar(30) CHARACTER SET utf8 NOT NULL,
    CONSTRAINT `PK_womaintenancefeedback` PRIMARY KEY (`id`)
);


CREATE TABLE `worecord` (
    `id` int(11) NOT NULL AUTO_INCREMENT,
    `work_order_id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `description` longtext CHARACTER SET utf8 NOT NULL,
    `creator` varchar(30) CHARACTER SET utf8 NOT NULL,
    `created_time` varchar(30) CHARACTER SET utf8 NOT NULL,
    CONSTRAINT `PK_worecord` PRIMARY KEY (`id`)
);


CREATE TABLE `workorder` (
    `id` varchar(32) CHARACTER SET utf8 NOT NULL,
    `equip_type` varchar(50) CHARACTER SET utf8 NOT NULL,
    `topic` varchar(50) CHARACTER SET utf8 NOT NULL,
    `level` int(11) NOT NULL,
    `maintenance_site` varchar(100) CHARACTER SET utf8 NOT NULL,
    `maintenance_time` varchar(30) CHARACTER SET utf8 NOT NULL,
    `content` longtext CHARACTER SET utf8 NOT NULL,
    `status` int(11) NOT NULL,
    `creator` varchar(30) CHARACTER SET utf8 NOT NULL,
    `reason` longtext CHARACTER SET utf8 NULL,
    `created_time` varchar(30) CHARACTER SET utf8 NOT NULL,
    `modified_time` varchar(30) CHARACTER SET utf8 NOT NULL,
    `completed_time` varchar(30) CHARACTER SET utf8 NULL,
    CONSTRAINT `PK_workorder` PRIMARY KEY (`id`)
);


CREATE TABLE `workstation` (
    `sta_n` int(11) NULL DEFAULT '0',
    `sta_nm` varchar(64) CHARACTER SET utf8 NULL,
    `sta_type` varchar(2) CHARACTER SET utf8 NULL,
    `net_addr` varchar(32) CHARACTER SET utf8 NULL,
    `sub_path` varchar(64) CHARACTER SET utf8 NULL
);


CREATE TABLE `ycp` (
    `equip_no` int(11) NOT NULL,
    `yc_no` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `yc_nm` varchar(80) CHARACTER SET utf8 NULL,
    `mapping` bit(1) NOT NULL DEFAULT b'0',
    `yc_min` double NULL DEFAULT '0',
    `yc_max` double NULL DEFAULT '1000',
    `physic_min` double NULL DEFAULT '0',
    `physic_max` double NULL DEFAULT '1000',
    `val_min` double NULL,
    `restore_min` double NULL,
    `restore_max` double NULL,
    `val_max` double NULL,
    `val_trait` int(11) NULL DEFAULT '0',
    `main_instruction` varchar(254) CHARACTER SET utf8 NULL,
    `minor_instruction` varchar(254) CHARACTER SET utf8 NULL,
    `safe_bgn` datetime NOT NULL DEFAULT '2001-01-01 00:00:00',
    `safe_end` datetime NOT NULL DEFAULT '2001-01-01 00:00:00',
    `alarm_acceptable_time` int(11) NULL DEFAULT '0',
    `restore_acceptable_time` int(11) NULL DEFAULT '0',
    `alarm_repeat_time` int(11) NULL DEFAULT '0',
    `proc_advice` varchar(254) CHARACTER SET utf8 NULL,
    `lvl_level` int(11) NOT NULL,
    `outmin_evt` varchar(64) CHARACTER SET utf8 NULL,
    `outmax_evt` varchar(64) CHARACTER SET utf8 NULL,
    `wave_file` varchar(64) CHARACTER SET utf8 NULL,
    `related_pic` varchar(255) CHARACTER SET utf8 NULL,
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `curve_rcd` bit(1) NOT NULL DEFAULT b'0',
    `curve_limit` double NULL DEFAULT '0',
    `alarm_shield` longtext CHARACTER SET utf8 NULL,
    `unit` varchar(50) CHARACTER SET utf8 NULL,
    `AlarmRiseCycle` int(11) NULL DEFAULT '0',
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    `related_video` varchar(255) CHARACTER SET utf8 NULL,
    `ZiChanID` varchar(255) CHARACTER SET utf8 NULL,
    `PlanNo` varchar(255) CHARACTER SET utf8 NULL,
    `SafeTime` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`equip_no`, `yc_no`)
);


CREATE TABLE `ycyxevt` (
    `sta_n` int(11) NULL DEFAULT '0',
    `equip_no` int(11) NOT NULL,
    `ycyx_no` int(11) NOT NULL,
    `ycyx_type` varchar(1) CHARACTER SET utf8 NOT NULL,
    `event` varchar(255) CHARACTER SET utf8 NOT NULL,
    `time` datetime NOT NULL,
    `proc_rec` varchar(255) CHARACTER SET utf8 NULL,
    `confirmname` varchar(128) CHARACTER SET utf8 NULL,
    `confirmtime` datetime NULL,
    `confirmremark` varchar(255) CHARACTER SET utf8 NULL,
    `WuBao` varchar(10) CHARACTER SET utf8 NOT NULL DEFAULT '0',
    `alarmlevel` int(11) NULL,
    `AlarmState` int(11) NOT NULL,
    `GUID` varchar(255) CHARACTER SET utf8 NULL
);


CREATE TABLE `ycyxevtreport` (
    `name` varchar(64) CHARACTER SET utf8 NULL,
    `sta_n` int(11) NULL,
    `equip_no` int(11) NOT NULL,
    `ycyx_no` int(11) NOT NULL,
    `ycyx_type` varchar(1) CHARACTER SET utf8 NOT NULL,
    `index_num` int(11) NULL DEFAULT '0'
);


CREATE TABLE `yxp` (
    `equip_no` int(11) NOT NULL,
    `yx_no` int(11) NOT NULL,
    `sta_n` int(11) NULL DEFAULT '0',
    `yx_nm` varchar(80) CHARACTER SET utf8 NULL,
    `proc_advice_r` varchar(254) CHARACTER SET utf8 NULL,
    `proc_advice_d` varchar(254) CHARACTER SET utf8 NULL,
    `level_r` int(11) NOT NULL,
    `level_d` int(11) NOT NULL,
    `evt_01` varchar(64) CHARACTER SET utf8 NULL,
    `evt_10` varchar(64) CHARACTER SET utf8 NULL,
    `main_instruction` varchar(254) CHARACTER SET utf8 NULL,
    `minor_instruction` varchar(254) CHARACTER SET utf8 NULL,
    `safe_bgn` datetime NOT NULL DEFAULT '2001-01-01 00:00:00',
    `safe_end` datetime NOT NULL DEFAULT '2001-01-01 00:00:00',
    `alarm_acceptable_time` int(11) NULL DEFAULT '0',
    `restore_acceptable_time` int(11) NULL DEFAULT '0',
    `alarm_repeat_time` int(11) NULL DEFAULT '0',
    `wave_file` varchar(64) CHARACTER SET utf8 NULL,
    `related_pic` varchar(255) CHARACTER SET utf8 NULL,
    `alarm_scheme` int(11) NULL DEFAULT '0',
    `inversion` bit(1) NOT NULL DEFAULT b'0',
    `initval` int(11) NULL DEFAULT '0',
    `val_trait` int(11) NULL DEFAULT '0',
    `alarm_shield` longtext CHARACTER SET utf8 NULL,
    `AlarmRiseCycle` int(11) NULL DEFAULT '0',
    `curve_rcd` bit(1) NOT NULL DEFAULT b'0',
    `Reserve1` longtext CHARACTER SET utf8 NULL,
    `Reserve2` longtext CHARACTER SET utf8 NULL,
    `Reserve3` longtext CHARACTER SET utf8 NULL,
    `related_video` varchar(255) CHARACTER SET utf8 NULL,
    `ZiChanID` varchar(255) CHARACTER SET utf8 NULL,
    `PlanNo` varchar(255) CHARACTER SET utf8 NULL,
    `SafeTime` longtext CHARACTER SET utf8 NULL,
    CONSTRAINT `PRIMARY` PRIMARY KEY (`equip_no`, `yx_no`)
);


CREATE INDEX `IDXKingKang_TmG_group_id` ON `kingkang_tmg` (`group_id`);


CREATE INDEX `IDXVisitorRecord_ID` ON `visitorrecord` (`ID`);


CREATE INDEX `IDXVisitorRecord_LicenseCode` ON `visitorrecord` (`LicenseCode`);


CREATE INDEX `IDXVisitorRecord_PeerNum` ON `visitorrecord` (`PeerNum`);


